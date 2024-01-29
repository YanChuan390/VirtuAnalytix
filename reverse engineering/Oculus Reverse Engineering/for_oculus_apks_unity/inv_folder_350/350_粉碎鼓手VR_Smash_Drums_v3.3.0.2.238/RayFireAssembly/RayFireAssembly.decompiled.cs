using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RayFire.DotNet;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

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
	[Address(RVA = "0x3008E54", Offset = "0x3008E54", VA = "0x3008E54")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3008E94", Offset = "0x3008E94", VA = "0x3008E94")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3009224", Offset = "0x3009224", VA = "0x3009224")]
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
	[Address(RVA = "0x3009294", Offset = "0x3009294", VA = "0x3009294")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x30092F8", Offset = "0x30092F8", VA = "0x30092F8")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x300972C", Offset = "0x300972C", VA = "0x300972C")]
	public static void Clear(RFShard shard)
	{
	}
}
[Serializable]
[Token(Token = "0x2000004")]
public class RFManDemolition
{
	[Token(Token = "0x2000005")]
	public enum FragmentParentType
	{
		[Token(Token = "0x4000011")]
		Manager,
		[Token(Token = "0x4000012")]
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
	[Address(RVA = "0x300979C", Offset = "0x300979C", VA = "0x300979C")]
	public void ChangeCurrentAmount(int am)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x30097BC", Offset = "0x30097BC", VA = "0x30097BC")]
	public void AmountWarning()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x3009824", Offset = "0x3009824", VA = "0x3009824")]
	public void ResetCurrentAmount()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x300982C", Offset = "0x300982C", VA = "0x300982C")]
	public RFManDemolition()
	{
	}
}
[Serializable]
[Token(Token = "0x2000006")]
public class RFMaterial
{
	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private string name;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool destructible;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int solidity;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float density;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float drag;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float angularDrag;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PhysicMaterial material;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float dynamicFriction;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float staticFriction;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float bounciness;

	[Token(Token = "0x17000001")]
	public PhysicMaterial Material
	{
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x30098CC", Offset = "0x30098CC", VA = "0x30098CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x300984C", Offset = "0x300984C", VA = "0x300984C")]
	public RFMaterial(string Name, float Density, float Drag, float AngularDrag, int Solidity, bool Destructible, float DynFriction, float StFriction, float Bounce)
	{
	}
}
[Serializable]
[Token(Token = "0x2000007")]
public class RFMaterialPresets
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFMaterial heavyMetal;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFMaterial lightMetal;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFMaterial denseRock;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFMaterial porousRock;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFMaterial concrete;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterial brick;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFMaterial glass;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMaterial rubber;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFMaterial ice;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFMaterial wood;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x300997C", Offset = "0x300997C", VA = "0x300997C")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x3009E40", Offset = "0x3009E40", VA = "0x3009E40")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x300A12C", Offset = "0x300A12C", VA = "0x300A12C")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x300A1DC", Offset = "0x300A1DC", VA = "0x300A1DC")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x300A28C", Offset = "0x300A28C", VA = "0x300A28C")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x300A340", Offset = "0x300A340", VA = "0x300A340")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x300A3F0", Offset = "0x300A3F0", VA = "0x300A3F0")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x300A4A8", Offset = "0x300A4A8", VA = "0x300A4A8")]
	public static PhysicMaterial Material(MaterialType materialType)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class RFPoolingParticles
{
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <StartPoolingCor>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingParticles <>4__this;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x300AE50", Offset = "0x300AE50", VA = "0x300AE50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x300AE98", Offset = "0x300AE98", VA = "0x300AE98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x300AC7C", Offset = "0x300AC7C", VA = "0x300AC7C")]
		[DebuggerHidden]
		public <StartPoolingCor>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x300ACA4", Offset = "0x300ACA4", VA = "0x300ACA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x300ACA8", Offset = "0x300ACA8", VA = "0x300ACA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x300AE58", Offset = "0x300AE58", VA = "0x300AE58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int capacity;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool inProgress;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int rate;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<ParticleSystem> list;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ParticleSystem inst;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform root;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject host;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ParticleSystem ps;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x300A720", Offset = "0x300A720", VA = "0x300A720")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x300A7B8", Offset = "0x300A7B8", VA = "0x300A7B8")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x300A8C8", Offset = "0x300A8C8", VA = "0x300A8C8")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x300A9D8", Offset = "0x300A9D8", VA = "0x300A9D8")]
	public ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x300AA98", Offset = "0x300AA98", VA = "0x300AA98")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x300AB54", Offset = "0x300AB54", VA = "0x300AB54")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x300AC08", Offset = "0x300AC08", VA = "0x300AC08")]
	[IteratorStateMachine(typeof(<StartPoolingCor>d__15))]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class RFPoolingFragment
{
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <StartPoolingCor>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingFragment <>4__this;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x300B6E0", Offset = "0x300B6E0", VA = "0x300B6E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x300B728", Offset = "0x300B728", VA = "0x300B728", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x300B510", Offset = "0x300B510", VA = "0x300B510")]
		[DebuggerHidden]
		public <StartPoolingCor>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x300B538", Offset = "0x300B538", VA = "0x300B538", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x300B53C", Offset = "0x300B53C", VA = "0x300B53C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x300B6E8", Offset = "0x300B6E8", VA = "0x300B6E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int capacity;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool inProgress;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<RayfireRigid> list;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int rate;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RayfireRigid inst;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform root;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject go;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshFilter mf;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private MeshRenderer mr;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private RayfireRigid rg;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody rb;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x300AEA0", Offset = "0x300AEA0", VA = "0x300AEA0")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x300AF38", Offset = "0x300AF38", VA = "0x300AF38")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x300B048", Offset = "0x300B048", VA = "0x300B048")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x300B144", Offset = "0x300B144", VA = "0x300B144")]
	public RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x300B32C", Offset = "0x300B32C", VA = "0x300B32C")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x300B3E8", Offset = "0x300B3E8", VA = "0x300B3E8")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x300B49C", Offset = "0x300B49C", VA = "0x300B49C")]
	[IteratorStateMachine(typeof(<StartPoolingCor>d__18))]
	public IEnumerator StartPoolingCor(Transform manTm)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200000C")]
public class RFStorage
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <StorageCor>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFStorage <>4__this;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x300BD88", Offset = "0x300BD88", VA = "0x300BD88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x300BDD0", Offset = "0x300BDD0", VA = "0x300BDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x300B94C", Offset = "0x300B94C", VA = "0x300B94C")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x300BB78", Offset = "0x300BB78", VA = "0x300BB78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x300BB7C", Offset = "0x300BB7C", VA = "0x300BB7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x300BD90", Offset = "0x300BD90", VA = "0x300BD90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> storageList;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform storageRoot;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inProgress;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float rate;

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x300B730", Offset = "0x300B730", VA = "0x300B730")]
	public RFStorage()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x300B7B8", Offset = "0x300B7B8", VA = "0x300B7B8")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x300B8E4", Offset = "0x300B8E4", VA = "0x300B8E4")]
	[IteratorStateMachine(typeof(<StorageCor>d__6))]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x300B974", Offset = "0x300B974", VA = "0x300B974")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x300BA34", Offset = "0x300BA34", VA = "0x300BA34")]
	public void DestroyAll()
	{
	}
}
[Token(Token = "0x200000E")]
public class RFFrag
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x300BDD8", Offset = "0x300BDD8", VA = "0x300BDD8")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x200000F")]
public class RFTri
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x300BDE0", Offset = "0x300BDE0", VA = "0x300BDE0")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class RFDictionary
{
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x300BF98", Offset = "0x300BF98", VA = "0x300BF98")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class RFShatterCluster
{
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x300C0B0", Offset = "0x300C0B0", VA = "0x300C0B0")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x300C0F8", Offset = "0x300C0F8", VA = "0x300C0F8")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class RFVoronoi
{
	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x17000008")]
	public int Amount
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x300C1A8", Offset = "0x300C1A8", VA = "0x300C1A8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x300C154", Offset = "0x300C154", VA = "0x300C154")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x300C174", Offset = "0x300C174", VA = "0x300C174")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class RFSplinters
{
	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x17000009")]
	public int Amount
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x300C230", Offset = "0x300C230", VA = "0x300C230")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x300C1D0", Offset = "0x300C1D0", VA = "0x300C1D0")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x300C1FC", Offset = "0x300C1FC", VA = "0x300C1FC")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class RFRadial
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x300C258", Offset = "0x300C258", VA = "0x300C258")]
	public RFRadial()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x300C29C", Offset = "0x300C29C", VA = "0x300C29C")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class RFSlice
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x300C300", Offset = "0x300C300", VA = "0x300C300")]
	public RFSlice()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x300C320", Offset = "0x300C320", VA = "0x300C320")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x300C35C", Offset = "0x300C35C", VA = "0x300C35C")]
	public Vector3 Axis(Transform tm)
	{
		return default(Vector3);
	}
}
[Serializable]
[Token(Token = "0x2000016")]
public class RFBricks
{
	[Token(Token = "0x2000017")]
	public enum RFBrickType
	{
		[Token(Token = "0x400008E")]
		ByAmount,
		[Token(Token = "0x400008F")]
		BySize
	}

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x300C3A8", Offset = "0x300C3A8", VA = "0x300C3A8")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class RFVoxels
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0.01f, 10f)]
	public float size;

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x300C3FC", Offset = "0x300C3FC", VA = "0x300C3FC")]
	public RFVoxels()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
public class RFTets
{
	[Token(Token = "0x200001A")]
	public enum TetType
	{
		[Token(Token = "0x4000095")]
		Uniform,
		[Token(Token = "0x4000096")]
		Curved
	}

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x300C41C", Offset = "0x300C41C", VA = "0x300C41C")]
	public RFTets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x300C448", Offset = "0x300C448", VA = "0x300C448")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class RFCluster : IComparable<RFCluster>
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tm;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 pos;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Quaternion rot;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 scl;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Bounds bound;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public bool demolishable;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RayfireRigid rigid;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<RFShard> shards;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float areaCollapse;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float minimumArea;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maximumArea;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float sizeCollapse;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float minimumSize;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float maximumSize;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int randomCollapse;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool cachedHost;

	[NonSerialized]
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
	public bool initialized;

	[NonSerialized]
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFCluster mainCluster;

	[NonSerialized]
	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFCluster> childClusters;

	[NonSerialized]
	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFCluster> neibClusters;

	[NonSerialized]
	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<float> neibArea;

	[NonSerialized]
	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<float> neibPerc;

	[NonSerialized]
	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<RFShard> newClusterShards;

	[Token(Token = "0x1700000A")]
	public bool HasChildClusters
	{
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x300C934", Offset = "0x300C934", VA = "0x300C934")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x300F5FC", Offset = "0x300F5FC", VA = "0x300F5FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x300F694", Offset = "0x300F694", VA = "0x300F694")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x300C484", Offset = "0x300C484", VA = "0x300C484")]
	public RFCluster()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x300C570", Offset = "0x300C570", VA = "0x300C570")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x300C988", Offset = "0x300C988", VA = "0x300C988", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x300CA88", Offset = "0x300CA88", VA = "0x300CA88")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x300CADC", Offset = "0x300CADC", VA = "0x300CADC")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x300CD18", Offset = "0x300CD18", VA = "0x300CD18")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x300CF0C", Offset = "0x300CF0C", VA = "0x300CF0C")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x300D7F8", Offset = "0x300D7F8", VA = "0x300D7F8")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x300D530", Offset = "0x300D530", VA = "0x300D530")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x300DE40", Offset = "0x300DE40", VA = "0x300DE40")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x300D6D0", Offset = "0x300D6D0", VA = "0x300D6D0")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x300E018", Offset = "0x300E018", VA = "0x300E018")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x300E740", Offset = "0x300E740", VA = "0x300E740")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x300E218", Offset = "0x300E218", VA = "0x300E218")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x300E9D4", Offset = "0x300E9D4", VA = "0x300E9D4")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x300EDD4", Offset = "0x300EDD4", VA = "0x300EDD4")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x300DF30", Offset = "0x300DF30", VA = "0x300DF30")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x300F280", Offset = "0x300F280", VA = "0x300F280")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x300DD94", Offset = "0x300DD94", VA = "0x300DD94")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x300F3F4", Offset = "0x300F3F4", VA = "0x300F3F4")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x300F4DC", Offset = "0x300F4DC", VA = "0x300F4DC")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x300F73C", Offset = "0x300F73C", VA = "0x300F73C")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x300F8F4", Offset = "0x300F8F4", VA = "0x300F8F4")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x300FA3C", Offset = "0x300FA3C", VA = "0x300FA3C")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x300FD84", Offset = "0x300FD84", VA = "0x300FD84")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x301014C", Offset = "0x301014C", VA = "0x301014C")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x3010270", Offset = "0x3010270", VA = "0x3010270")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x3010C80", Offset = "0x3010C80", VA = "0x3010C80")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x301105C", Offset = "0x301105C", VA = "0x301105C")]
	public static float GetClusterMass(RFCluster cluster)
	{
		return default(float);
	}
}
[Token(Token = "0x200001C")]
public class RFEvent
{
	[Token(Token = "0x200001D")]
	public delegate void EventAction(RayfireRigid rigid);

	[Token(Token = "0x200001E")]
	public delegate void EventActionMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot);

	[Token(Token = "0x200001F")]
	public delegate void EventActionRoot(RFShard shard, RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x3011108", Offset = "0x3011108", VA = "0x3011108")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x30111A4", Offset = "0x30111A4", VA = "0x30111A4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionMeshRoot LocalEventMeshRoot
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x3011240", Offset = "0x3011240", VA = "0x3011240")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x30112DC", Offset = "0x30112DC", VA = "0x30112DC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x3011378", Offset = "0x3011378", VA = "0x3011378")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x3011414", Offset = "0x3011414", VA = "0x3011414")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x30114B0", Offset = "0x30114B0", VA = "0x30114B0")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x30114CC", Offset = "0x30114CC", VA = "0x30114CC")]
	public void InvokeLocalEventMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x30114E8", Offset = "0x30114E8", VA = "0x30114E8")]
	public void InvokeLocalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x3011504", Offset = "0x3011504", VA = "0x3011504")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x2000020")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x3011968", Offset = "0x3011968", VA = "0x3011968")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x3011A20", Offset = "0x3011A20", VA = "0x3011A20")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x3011AD8", Offset = "0x3011AD8", VA = "0x3011AD8")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x3011B44", Offset = "0x3011B44", VA = "0x3011B44")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x2000021")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000005")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x3011B4C", Offset = "0x3011B4C", VA = "0x3011B4C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x3011C04", Offset = "0x3011C04", VA = "0x3011C04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x3011CBC", Offset = "0x3011CBC", VA = "0x3011CBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x3011D78", Offset = "0x3011D78", VA = "0x3011D78")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x3011E34", Offset = "0x3011E34", VA = "0x3011E34")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x3011EA0", Offset = "0x3011EA0", VA = "0x3011EA0")]
	public static void InvokeGlobalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x3011F20", Offset = "0x3011F20", VA = "0x3011F20")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x2000022")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x3011F28", Offset = "0x3011F28", VA = "0x3011F28")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x3011FE0", Offset = "0x3011FE0", VA = "0x3011FE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x3012098", Offset = "0x3012098", VA = "0x3012098")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x3012104", Offset = "0x3012104", VA = "0x3012104")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x2000023")]
public class RFShotEvent
{
	[Token(Token = "0x2000024")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000008")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x301210C", Offset = "0x301210C", VA = "0x301210C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x30121C4", Offset = "0x30121C4", VA = "0x30121C4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x301227C", Offset = "0x301227C", VA = "0x301227C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x3012318", Offset = "0x3012318", VA = "0x3012318")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x30123B4", Offset = "0x30123B4", VA = "0x30123B4")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x3012420", Offset = "0x3012420", VA = "0x3012420")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x301243C", Offset = "0x301243C", VA = "0x301243C")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000025")]
public class RFExplosionEvent
{
	[Token(Token = "0x2000026")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x1400000A")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x30125B0", Offset = "0x30125B0", VA = "0x30125B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x3012668", Offset = "0x3012668", VA = "0x3012668")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x3012720", Offset = "0x3012720", VA = "0x3012720")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x30127BC", Offset = "0x30127BC", VA = "0x30127BC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x3012858", Offset = "0x3012858", VA = "0x3012858")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x30128C4", Offset = "0x30128C4", VA = "0x30128C4")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x30128E0", Offset = "0x30128E0", VA = "0x30128E0")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x2000027")]
public class RFSliceEvent
{
	[Token(Token = "0x2000028")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x1400000C")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x3012A54", Offset = "0x3012A54", VA = "0x3012A54")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3012B0C", Offset = "0x3012B0C", VA = "0x3012B0C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3012BC4", Offset = "0x3012BC4", VA = "0x3012BC4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x3012C60", Offset = "0x3012C60", VA = "0x3012C60")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x3012CFC", Offset = "0x3012CFC", VA = "0x3012CFC")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x3012D68", Offset = "0x3012D68", VA = "0x3012D68")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x3012D84", Offset = "0x3012D84", VA = "0x3012D84")]
	public RFSliceEvent()
	{
	}
}
[Token(Token = "0x2000029")]
public class RFConnectivityEvent
{
	[Token(Token = "0x200002A")]
	public delegate void EventAction(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters);

	[Token(Token = "0x1400000E")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3012EF8", Offset = "0x3012EF8", VA = "0x3012EF8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3012FB0", Offset = "0x3012FB0", VA = "0x3012FB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3013068", Offset = "0x3013068", VA = "0x3013068")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3013104", Offset = "0x3013104", VA = "0x3013104")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x30131A0", Offset = "0x30131A0", VA = "0x30131A0")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x3013228", Offset = "0x3013228", VA = "0x3013228")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x3013244", Offset = "0x3013244", VA = "0x3013244")]
	public RFConnectivityEvent()
	{
	}
}
[Token(Token = "0x200002B")]
public class RFFadingEvent
{
	[Token(Token = "0x200002C")]
	public delegate void EventAction(Transform tm);

	[Token(Token = "0x14000010")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x30133C8", Offset = "0x30133C8", VA = "0x30133C8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x3013480", Offset = "0x3013480", VA = "0x3013480")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3013538", Offset = "0x3013538", VA = "0x3013538")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30135D4", Offset = "0x30135D4", VA = "0x30135D4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3013670", Offset = "0x3013670", VA = "0x3013670")]
	public static void InvokeGlobalEvent(Transform tm)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x30136DC", Offset = "0x30136DC", VA = "0x30136DC")]
	public void InvokeLocalEvent(Transform tm)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x30136F8", Offset = "0x30136F8", VA = "0x30136F8")]
	public RFFadingEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
public class RFFlash
{
	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Intensity")]
	[Space(3f)]
	[Range(0.1f, 5f)]
	public float intensityMin;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0.1f, 5f)]
	[Space(1f)]
	public float intensityMax;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Range")]
	[Space(3f)]
	[Range(0.01f, 10f)]
	public float rangeMin;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(1f)]
	[Range(0.01f, 10f)]
	public float rangeMax;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Other")]
	[Range(0.01f, 2f)]
	[Space(3f)]
	public float distance;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(1f)]
	public Color color;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x301386C", Offset = "0x301386C", VA = "0x301386C")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class RFDecals
{
	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0.1f, 5f)]
	[Space(2f)]
	[Header("  Size")]
	public float sizeMin;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 5f)]
	[Space(1f)]
	public float sizeMax;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Header("  Limitations")]
	[Range(0.01f, 2f)]
	public float distance;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x30138A0", Offset = "0x30138A0", VA = "0x30138A0")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RFJoint
{
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int df;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConfigurableJoint jn;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody r1;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Rigidbody r2;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int br;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int an;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int dm;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x30138CC", Offset = "0x30138CC", VA = "0x30138CC")]
	public RFJoint(int Id, int Br, int An, int Dm)
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class RFJointProperties
{
	[Token(Token = "0x2000031")]
	public enum RFJointBreakType
	{
		[Token(Token = "0x40000EA")]
		Breakable,
		[Token(Token = "0x40000EB")]
		Unbreakable
	}

	[Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class <DeformationCor>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFJointProperties <>4__this;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x30152CC", Offset = "0x30152CC", VA = "0x30152CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x3015314", Offset = "0x3015314", VA = "0x3015314", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x3014F04", Offset = "0x3014F04", VA = "0x3014F04")]
		[DebuggerHidden]
		public <DeformationCor>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x3014FEC", Offset = "0x3014FEC", VA = "0x3014FEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x3014FF0", Offset = "0x3014FF0", VA = "0x3014FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x30152D4", Offset = "0x30152D4", VA = "0x30152D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFJointBreakType breakType;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int breakForce;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int breakForceVar;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool forceByMass;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool varInAwake;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int angleLimit;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int angleLimitVar;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int damper;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool deformEnable;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int deformCount;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float stiffFrc;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int stiffAbs;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int bend;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int percentage;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float weakening;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int initAmount;

	[NonSerialized]
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<RFJoint> deformList;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<RFJoint> jointList;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static SoftJointLimit jointLimit;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static SoftJointLimitSpring spring;

	[Token(Token = "0x1700000D")]
	public bool HasJoints
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x3013DE8", Offset = "0x3013DE8", VA = "0x3013DE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool HasDeforms
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3014958", Offset = "0x3014958", VA = "0x3014958")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x3013910", Offset = "0x3013910", VA = "0x3013910")]
	public static void CreateJoints(RFCluster cluster, RFJointProperties joints)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x3013EF0", Offset = "0x3013EF0", VA = "0x3013EF0")]
	public static RFJoint CreateJoint(RFShard shard, RFShard neib, RFJointProperties joints, int id)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x301461C", Offset = "0x301461C", VA = "0x301461C")]
	public static void SetPositionMotion(ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x301465C", Offset = "0x301465C", VA = "0x301465C")]
	public static void SetAngularMotion(float angleLimit, RFJoint joint)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x3014050", Offset = "0x3014050", VA = "0x3014050")]
	public static void SetAngularMotion(float angleLimit, int var, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x3014794", Offset = "0x3014794", VA = "0x3014794")]
	public static void SetSpring(int damper, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x3014198", Offset = "0x3014198", VA = "0x3014198")]
	public static void SetSpring(int damper, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x3014848", Offset = "0x3014848", VA = "0x3014848")]
	public static void SetBreakForce(int force, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x3014864", Offset = "0x3014864", VA = "0x3014864")]
	public static void SetBreakForce(int force, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x3014280", Offset = "0x3014280", VA = "0x3014280")]
	public static void SetBreakForce(int force, int var, List<RFJoint> jointList, bool byMass)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x301455C", Offset = "0x301455C", VA = "0x301455C")]
	public static void SetTransform(Transform tm1, Transform tm2, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x3013E3C", Offset = "0x3013E3C", VA = "0x3013E3C")]
	public void EmptyList()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x30149AC", Offset = "0x30149AC", VA = "0x30149AC")]
	public void DestroyJoints()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x30143A8", Offset = "0x30143A8", VA = "0x30143A8")]
	public static void SaveProperties(List<RFJoint> joints)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x3014B30", Offset = "0x3014B30", VA = "0x3014B30")]
	public static RFJoint DeformJoint(RFJoint joint, RFJointProperties joints)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x3014CAC", Offset = "0x3014CAC", VA = "0x3014CAC")]
	public static void SetDeformation(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x3014E9C", Offset = "0x3014E9C", VA = "0x3014E9C")]
	[IteratorStateMachine(typeof(<DeformationCor>d__42))]
	public IEnumerator DeformationCor()
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x3014F2C", Offset = "0x3014F2C", VA = "0x3014F2C")]
	public RFJointProperties()
	{
	}
}
[Serializable]
[Token(Token = "0x2000033")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x2000034")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x30166EC", Offset = "0x30166EC", VA = "0x30166EC")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x3015F6C", Offset = "0x3015F6C", VA = "0x3015F6C")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x301531C", Offset = "0x301531C", VA = "0x301531C")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x3015F94", Offset = "0x3015F94", VA = "0x3015F94")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x30160B8", Offset = "0x30160B8", VA = "0x30160B8")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x3016550", Offset = "0x3016550", VA = "0x3016550")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x3016600", Offset = "0x3016600", VA = "0x3016600")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x30162D8", Offset = "0x30162D8", VA = "0x30162D8")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3016180", Offset = "0x3016180", VA = "0x3016180")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x30163F4", Offset = "0x30163F4", VA = "0x30163F4")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000035")]
public class RFParticleNoise
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enabled;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strengthMin;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float strengthMax;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float frequency;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float scrollSpeed;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool damping;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x301676C", Offset = "0x301676C", VA = "0x301676C")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x30167A4", Offset = "0x30167A4", VA = "0x30167A4")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000036")]
public class RFParticleRendering
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool castShadows;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool receiveShadows;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public MotionVectorGenerationMode motionVectors;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool l;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int layer;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool t;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x30167D8", Offset = "0x30167D8", VA = "0x30167D8")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x3016804", Offset = "0x3016804", VA = "0x3016804")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000037")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float speedMin;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float speedMax;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float velocityMin;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float velocityMax;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravityMin;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float gravityMax;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float rotationSpeed;

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x3016850", Offset = "0x3016850", VA = "0x3016850")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3016890", Offset = "0x3016890", VA = "0x3016890")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000038")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float speedMin;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float speedMax;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float rotation;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float gravityMin;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float gravityMax;

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x30168C4", Offset = "0x30168C4", VA = "0x30168C4")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x30168F4", Offset = "0x30168F4", VA = "0x30168F4")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000039")]
public class RFParticleEmission
{
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int burstAmount;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float distanceRate;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float duration;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeMin;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float lifeMax;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float sizeMin;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeMax;

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3016918", Offset = "0x3016918", VA = "0x3016918")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3016954", Offset = "0x3016954", VA = "0x3016954")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x200003A")]
public class RFParticleLimitations
{
	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int minParticles;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int maxParticles;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool visible;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float sizeThreshold;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x3016980", Offset = "0x3016980", VA = "0x3016980")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x30169B4", Offset = "0x30169B4", VA = "0x30169B4")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x200003C")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x400012E")]
		ByPhysicalMaterial,
		[Token(Token = "0x400012F")]
		ByProperties
	}

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LayerMask collidesWith;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radiusScale;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float dampenMin;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float dampenMax;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float bounceMin;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float bounceMax;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x30169E0", Offset = "0x30169E0", VA = "0x30169E0")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3016A34", Offset = "0x3016A34", VA = "0x3016A34")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x3016A68", Offset = "0x3016A68", VA = "0x3016A68")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x200003D")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LayerMask collidesWith;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float radiusScale;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x3016C60", Offset = "0x3016C60", VA = "0x3016C60")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x3016C90", Offset = "0x3016C90", VA = "0x3016C90")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x200003E")]
public class RFParticles
{
	[Token(Token = "0x200003F")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x4000137")]
		ByPhysicalMaterial,
		[Token(Token = "0x4000138")]
		ByProperties
	}

	[Token(Token = "0x2000040")]
	public enum BurstType
	{
		[Token(Token = "0x400013A")]
		None,
		[Token(Token = "0x400013B")]
		TotalAmount,
		[Token(Token = "0x400013C")]
		PerOneUnitSize,
		[Token(Token = "0x400013D")]
		FragmentAmount
	}

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3016CB4", Offset = "0x3016CB4", VA = "0x3016CB4")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x301709C", Offset = "0x301709C", VA = "0x301709C")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x30175BC", Offset = "0x30175BC", VA = "0x30175BC")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x3017690", Offset = "0x3017690", VA = "0x3017690")]
	public static void CreateDemolitionDebris(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x30183C8", Offset = "0x30183C8", VA = "0x30183C8")]
	private static void CreateReferenceDemolitionDebris(RayfireDebris debris)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x30179A0", Offset = "0x30179A0", VA = "0x30179A0")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x30190C8", Offset = "0x30190C8", VA = "0x30190C8")]
	public static void CreateActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x3019B4C", Offset = "0x3019B4C", VA = "0x3019B4C")]
	public static void CreateActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x30189E0", Offset = "0x30189E0", VA = "0x30189E0")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x3019304", Offset = "0x3019304", VA = "0x3019304")]
	public static void CreateDebrisCluster(RayfireRigid rigid, RayfireDebris debris)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x3019E88", Offset = "0x3019E88", VA = "0x3019E88")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x3018D60", Offset = "0x3018D60", VA = "0x3018D60")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x3019728", Offset = "0x3019728", VA = "0x3019728")]
	public static void CreateDustCluster(RayfireRigid rigid, RayfireDust dust)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x301A068", Offset = "0x301A068", VA = "0x301A068")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x301A248", Offset = "0x301A248", VA = "0x301A248")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x301A53C", Offset = "0x301A53C", VA = "0x301A53C")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x301A68C", Offset = "0x301A68C", VA = "0x301A68C")]
	private static ParticleSystem CreateParticleSystem(Transform tm, RFParticleRendering rend)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x301A8F4", Offset = "0x301A8F4", VA = "0x301A8F4")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x301AAA4", Offset = "0x301AAA4", VA = "0x301AAA4")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x3017DA4", Offset = "0x3017DA4", VA = "0x3017DA4")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x301AC54", Offset = "0x301AC54", VA = "0x301AC54")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x301B1A8", Offset = "0x301B1A8", VA = "0x301B1A8")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x301BBA8", Offset = "0x301BBA8", VA = "0x301BBA8")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x301C0FC", Offset = "0x301C0FC", VA = "0x301C0FC")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x301C358", Offset = "0x301C358", VA = "0x301C358")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x301C494", Offset = "0x301C494", VA = "0x301C494")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x301C558", Offset = "0x301C558", VA = "0x301C558")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x301A398", Offset = "0x301A398", VA = "0x301A398")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x301C59C", Offset = "0x301C59C", VA = "0x301C59C")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x301C67C", Offset = "0x301C67C", VA = "0x301C67C")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x301C740", Offset = "0x301C740", VA = "0x301C740")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x301C970", Offset = "0x301C970", VA = "0x301C970")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x301CC08", Offset = "0x301CC08", VA = "0x301CC08")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x301CA0C", Offset = "0x301CA0C", VA = "0x301CA0C")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x301CD14", Offset = "0x301CD14", VA = "0x301CD14")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x301CDC0", Offset = "0x301CDC0", VA = "0x301CDC0")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x301CF94", Offset = "0x301CF94", VA = "0x301CF94")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x301D14C", Offset = "0x301D14C", VA = "0x301D14C")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x301D350", Offset = "0x301D350", VA = "0x301D350")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x301D490", Offset = "0x301D490", VA = "0x301D490")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x30184F8", Offset = "0x30184F8", VA = "0x30184F8")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x3018E60", Offset = "0x3018E60", VA = "0x3018E60")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x3018760", Offset = "0x3018760", VA = "0x3018760")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x3018AE0", Offset = "0x3018AE0", VA = "0x3018AE0")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x301A4C0", Offset = "0x301A4C0", VA = "0x301A4C0")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x301D534", Offset = "0x301D534", VA = "0x301D534")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x301D72C", Offset = "0x301D72C", VA = "0x301D72C")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x2000041")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float neibPosThreshold;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float neibAreaThreshold;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static float bBoxSharedAreaDiv;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float dm;

	[NonSerialized]
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m;

	[NonSerialized]
	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int lb;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int nAm;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> nIds;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<float> nArea;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> sIds;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<float> nSt;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float sSt;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform tm;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshFilter mf;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Collider col;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody rb;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool[] sCheck;

	[Token(Token = "0x17000011")]
	public bool StressState
	{
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x302055C", Offset = "0x302055C", VA = "0x302055C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public bool SupportState
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x30211DC", Offset = "0x30211DC", VA = "0x30211DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x302122C", Offset = "0x302122C", VA = "0x302122C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public bool Visible
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x3021240", Offset = "0x3021240", VA = "0x3021240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x301E7EC", Offset = "0x301E7EC", VA = "0x301E7EC")]
	public RFShard()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x301E854", Offset = "0x301E854", VA = "0x301E854")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x301EBA0", Offset = "0x301EBA0", VA = "0x301EBA0")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x301ED88", Offset = "0x301ED88", VA = "0x301ED88")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x301EEA4", Offset = "0x301EEA4", VA = "0x301EEA4", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x301EED4", Offset = "0x301EED4", VA = "0x301EED4")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x301EFB0", Offset = "0x301EFB0", VA = "0x301EFB0")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x301EFF8", Offset = "0x301EFF8", VA = "0x301EFF8")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x301F160", Offset = "0x301F160", VA = "0x301F160")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x301F438", Offset = "0x301F438", VA = "0x301F438")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x301F5A8", Offset = "0x301F5A8", VA = "0x301F5A8")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x301F780", Offset = "0x301F780", VA = "0x301F780")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x301F9C0", Offset = "0x301F9C0", VA = "0x301F9C0")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x3020318", Offset = "0x3020318", VA = "0x3020318")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x3020430", Offset = "0x3020430", VA = "0x3020430")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x30205B0", Offset = "0x30205B0", VA = "0x30205B0")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x3020698", Offset = "0x3020698", VA = "0x3020698")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x3020724", Offset = "0x3020724", VA = "0x3020724")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x302088C", Offset = "0x302088C", VA = "0x302088C")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x3020CB4", Offset = "0x3020CB4", VA = "0x3020CB4")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x30210A4", Offset = "0x30210A4", VA = "0x30210A4")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x3021140", Offset = "0x3021140", VA = "0x3021140")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x3021318", Offset = "0x3021318", VA = "0x3021318")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x3021418", Offset = "0x3021418", VA = "0x3021418")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000042")]
public class RFSound
{
	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x17000015")]
	public bool HasClips
	{
		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3021810", Offset = "0x3021810", VA = "0x3021810")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x302163C", Offset = "0x302163C", VA = "0x302163C")]
	public RFSound()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x3021660", Offset = "0x3021660", VA = "0x3021660")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x3021864", Offset = "0x3021864", VA = "0x3021864")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x3021928", Offset = "0x3021928", VA = "0x3021928")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x3021A98", Offset = "0x3021A98", VA = "0x3021A98")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x3021CF4", Offset = "0x3021CF4", VA = "0x3021CF4")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x30220E8", Offset = "0x30220E8", VA = "0x30220E8")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x302229C", Offset = "0x302229C", VA = "0x302229C")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x3022450", Offset = "0x3022450", VA = "0x3022450")]
	public static void CollisionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x3022034", Offset = "0x3022034", VA = "0x3022034")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x3021EB8", Offset = "0x3021EB8", VA = "0x3021EB8")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class RFStress
{
	[Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x3025B78", Offset = "0x3025B78", VA = "0x3025B78", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000171")]
			[Address(RVA = "0x3025BC0", Offset = "0x3025BC0", VA = "0x3025BC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x30227FC", Offset = "0x30227FC", VA = "0x30227FC")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x30259F0", Offset = "0x30259F0", VA = "0x30259F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x30259F4", Offset = "0x30259F4", VA = "0x30259F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x3025B80", Offset = "0x3025B80", VA = "0x3025B80", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x3022604", Offset = "0x3022604", VA = "0x3022604")]
	public RFStress()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x30226DC", Offset = "0x30226DC", VA = "0x30226DC")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x30226FC", Offset = "0x30226FC", VA = "0x30226FC")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x3022788", Offset = "0x3022788", VA = "0x3022788")]
	[IteratorStateMachine(typeof(<StressCor>d__21))]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x3022824", Offset = "0x3022824", VA = "0x3022824")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x3022ACC", Offset = "0x3022ACC", VA = "0x3022ACC")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x3022F50", Offset = "0x3022F50", VA = "0x3022F50")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x3022F88", Offset = "0x3022F88", VA = "0x3022F88")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x30231CC", Offset = "0x30231CC", VA = "0x30231CC")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x3023234", Offset = "0x3023234", VA = "0x3023234")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x3023400", Offset = "0x3023400", VA = "0x3023400")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x30240FC", Offset = "0x30240FC", VA = "0x30240FC")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x3024894", Offset = "0x3024894", VA = "0x3024894")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x3023A44", Offset = "0x3023A44", VA = "0x3023A44")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x30253F4", Offset = "0x30253F4", VA = "0x30253F4")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x302494C", Offset = "0x302494C", VA = "0x302494C")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x2000045")]
public enum AxisType
{
	[Token(Token = "0x4000183")]
	XRed,
	[Token(Token = "0x4000184")]
	YGreen,
	[Token(Token = "0x4000185")]
	ZBlue
}
[Token(Token = "0x2000046")]
public enum PlaneType
{
	[Token(Token = "0x4000187")]
	XY,
	[Token(Token = "0x4000188")]
	XZ,
	[Token(Token = "0x4000189")]
	YZ
}
[Token(Token = "0x2000047")]
public enum FragType
{
	[Token(Token = "0x400018B")]
	Voronoi = 0,
	[Token(Token = "0x400018C")]
	Splinters = 1,
	[Token(Token = "0x400018D")]
	Slabs = 2,
	[Token(Token = "0x400018E")]
	Radial = 3,
	[Token(Token = "0x400018F")]
	Custom = 5,
	[Token(Token = "0x4000190")]
	Slices = 7,
	[Token(Token = "0x4000191")]
	Bricks = 9,
	[Token(Token = "0x4000192")]
	Voxels = 10,
	[Token(Token = "0x4000193")]
	Tets = 11,
	[Token(Token = "0x4000194")]
	Decompose = 15
}
[Token(Token = "0x2000048")]
public enum DemolitionType
{
	[Token(Token = "0x4000196")]
	None = 0,
	[Token(Token = "0x4000197")]
	Runtime = 1,
	[Token(Token = "0x4000198")]
	AwakePrecache = 2,
	[Token(Token = "0x4000199")]
	AwakePrefragment = 3,
	[Token(Token = "0x400019A")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000049")]
public enum CachingType
{
	[Token(Token = "0x400019C")]
	Disable,
	[Token(Token = "0x400019D")]
	ByFrames,
	[Token(Token = "0x400019E")]
	ByFragmentsPerFrame
}
[Token(Token = "0x200004A")]
public enum FadeType
{
	[Token(Token = "0x40001A0")]
	None = 0,
	[Token(Token = "0x40001A1")]
	SimExclude = 1,
	[Token(Token = "0x40001A2")]
	FallDown = 2,
	[Token(Token = "0x40001A3")]
	ScaleDown = 3,
	[Token(Token = "0x40001A4")]
	MoveDown = 4,
	[Token(Token = "0x40001A5")]
	Destroy = 5,
	[Token(Token = "0x40001A6")]
	SetStatic = 8,
	[Token(Token = "0x40001A7")]
	SetKinematic = 9
}
[Token(Token = "0x200004B")]
public enum RFFadeLifeType
{
	[Token(Token = "0x40001A9")]
	ByLifeTime = 4,
	[Token(Token = "0x40001AA")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x200004C")]
public enum MaterialType
{
	[Token(Token = "0x40001AC")]
	HeavyMetal,
	[Token(Token = "0x40001AD")]
	LightMetal,
	[Token(Token = "0x40001AE")]
	DenseRock,
	[Token(Token = "0x40001AF")]
	PorousRock,
	[Token(Token = "0x40001B0")]
	Concrete,
	[Token(Token = "0x40001B1")]
	Brick,
	[Token(Token = "0x40001B2")]
	Glass,
	[Token(Token = "0x40001B3")]
	Rubber,
	[Token(Token = "0x40001B4")]
	Ice,
	[Token(Token = "0x40001B5")]
	Wood
}
[Token(Token = "0x200004D")]
public enum MassType
{
	[Token(Token = "0x40001B7")]
	MaterialDensity,
	[Token(Token = "0x40001B8")]
	MassProperty,
	[Token(Token = "0x40001B9")]
	RigidBodyComponent
}
[Token(Token = "0x200004E")]
public enum ObjectType
{
	[Token(Token = "0x40001BB")]
	Mesh = 0,
	[Token(Token = "0x40001BC")]
	MeshRoot = 1,
	[Token(Token = "0x40001BD")]
	SkinnedMesh = 2,
	[Token(Token = "0x40001BE")]
	NestedCluster = 4,
	[Token(Token = "0x40001BF")]
	ConnectedCluster = 5
}
[Token(Token = "0x200004F")]
public enum SimType
{
	[Token(Token = "0x40001C1")]
	Dynamic,
	[Token(Token = "0x40001C2")]
	Sleeping,
	[Token(Token = "0x40001C3")]
	Inactive,
	[Token(Token = "0x40001C4")]
	Kinematic,
	[Token(Token = "0x40001C5")]
	Static
}
[Token(Token = "0x2000050")]
public enum FragSimType
{
	[Token(Token = "0x40001C7")]
	Dynamic,
	[Token(Token = "0x40001C8")]
	Sleeping,
	[Token(Token = "0x40001C9")]
	Inactive,
	[Token(Token = "0x40001CA")]
	Kinematic,
	[Token(Token = "0x40001CB")]
	Inherit
}
[Token(Token = "0x2000051")]
public enum ConnectivityType
{
	[Token(Token = "0x40001CD")]
	ByBoundingBox = 0,
	[Token(Token = "0x40001CE")]
	ByTriangles = 1,
	[Token(Token = "0x40001CF")]
	ByPolygons = 3,
	[Token(Token = "0x40001D0")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x40001D1")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x2000052")]
public enum FragmentMode
{
	[Token(Token = "0x40001D3")]
	Runtime,
	[Token(Token = "0x40001D4")]
	Editor
}
[Token(Token = "0x2000053")]
public enum RFColliderType
{
	[Token(Token = "0x40001D6")]
	Mesh = 0,
	[Token(Token = "0x40001D7")]
	Box = 1,
	[Token(Token = "0x40001D8")]
	Sphere = 2,
	[Token(Token = "0x40001D9")]
	None = 4
}
[Token(Token = "0x2000054")]
public enum RFParenting
{
	[Token(Token = "0x40001DB")]
	Manager = 0,
	[Token(Token = "0x40001DC")]
	Parent = 1,
	[Token(Token = "0x40001DD")]
	Sphere = 2,
	[Token(Token = "0x40001DE")]
	None = 4
}
[Serializable]
[Token(Token = "0x2000055")]
public class RFActivation
{
	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <ActivationVelocityCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000018")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x3026F48", Offset = "0x3026F48", VA = "0x3026F48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x3026F90", Offset = "0x3026F90", VA = "0x3026F90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x3025D68", Offset = "0x3025D68", VA = "0x3025D68")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x3026DDC", Offset = "0x3026DDC", VA = "0x3026DDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3026DE0", Offset = "0x3026DE0", VA = "0x3026DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x3026F50", Offset = "0x3026F50", VA = "0x3026F50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <ActivationOffsetCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x1700001A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x3027160", Offset = "0x3027160", VA = "0x3027160", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x30271A8", Offset = "0x30271A8", VA = "0x30271A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3025E04", Offset = "0x3025E04", VA = "0x3025E04")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x3026F98", Offset = "0x3026F98", VA = "0x3026F98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x3026F9C", Offset = "0x3026F9C", VA = "0x3026F9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x3027168", Offset = "0x3027168", VA = "0x3027168", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class <InactiveCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x1700001C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x30272F0", Offset = "0x30272F0", VA = "0x30272F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x3027338", Offset = "0x3027338", VA = "0x3027338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x3025EA0", Offset = "0x3025EA0", VA = "0x3025EA0")]
		[DebuggerHidden]
		public <InactiveCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x30271B0", Offset = "0x30271B0", VA = "0x30271B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x30271B4", Offset = "0x30271B4", VA = "0x30271B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x30272F8", Offset = "0x30272F8", VA = "0x30272F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class <InactiveCor>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x1700001E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x3027AAC", Offset = "0x3027AAC", VA = "0x3027AAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x3027AF4", Offset = "0x3027AF4", VA = "0x3027AF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x3025F3C", Offset = "0x3025F3C", VA = "0x3025F3C")]
		[DebuggerHidden]
		public <InactiveCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x3027340", Offset = "0x3027340", VA = "0x3027340", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x3027344", Offset = "0x3027344", VA = "0x3027344", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x3027AB4", Offset = "0x3027AB4", VA = "0x3027AB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool local;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float byVelocity;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float byDamage;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool byActivator;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool byImpact;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool byConnectivity;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool unyielding;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool activatable;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool l;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int layer;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireConnectivity connect;

	[NonSerialized]
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int lb;

	[NonSerialized]
	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool activated;

	[NonSerialized]
	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool inactiveCorState;

	[NonSerialized]
	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool velocityCorState;

	[NonSerialized]
	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IEnumerator velocityEnum;

	[NonSerialized]
	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float randomRot;

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x3025BC8", Offset = "0x3025BC8", VA = "0x3025BC8")]
	public RFActivation()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x3025C08", Offset = "0x3025C08", VA = "0x3025C08")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x3025BF8", Offset = "0x3025BF8", VA = "0x3025BF8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x3025C6C", Offset = "0x3025C6C", VA = "0x3025C6C")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x3025CF4", Offset = "0x3025CF4", VA = "0x3025CF4")]
	[IteratorStateMachine(typeof(<ActivationVelocityCor>d__24))]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x3025D90", Offset = "0x3025D90", VA = "0x3025D90")]
	[IteratorStateMachine(typeof(<ActivationOffsetCor>d__25))]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x3025E2C", Offset = "0x3025E2C", VA = "0x3025E2C")]
	[IteratorStateMachine(typeof(<InactiveCor>d__26))]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x3025EC8", Offset = "0x3025EC8", VA = "0x3025EC8")]
	[IteratorStateMachine(typeof(<InactiveCor>d__27))]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x3025F64", Offset = "0x3025F64", VA = "0x3025F64")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x302661C", Offset = "0x302661C", VA = "0x302661C")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x30264BC", Offset = "0x30264BC", VA = "0x30264BC")]
	public static void ActivationRandomRotation(Rigidbody rb)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x302646C", Offset = "0x302646C", VA = "0x302646C")]
	private static void SetActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x30269FC", Offset = "0x30269FC", VA = "0x30269FC")]
	public static void RestoreActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x3026A4C", Offset = "0x3026A4C", VA = "0x3026A4C")]
	public static void BackupActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x30269B4", Offset = "0x30269B4", VA = "0x30269B4")]
	private static void SetActivationLayer(RFShard shard, RFActivation activation)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x3026A88", Offset = "0x3026A88", VA = "0x3026A88")]
	public static void SetActivationLayer(List<RFShard> shards, RFActivation activation, Transform root)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x3026BB0", Offset = "0x3026BB0", VA = "0x3026BB0")]
	public static void RestoreActivationLayer(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x3026CA0", Offset = "0x3026CA0", VA = "0x3026CA0")]
	public static void BackupActivationLayer(RayfireRigidRoot root)
	{
	}
}
[Token(Token = "0x200005A")]
public class RFBackupCluster
{
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFCluster cluster;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool saved;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x3027AFC", Offset = "0x3027AFC", VA = "0x3027AFC")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x3027B18", Offset = "0x3027B18", VA = "0x3027B18")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x3027E78", Offset = "0x3027E78", VA = "0x3027E78")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x3028088", Offset = "0x3028088", VA = "0x3028088")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x302854C", Offset = "0x302854C", VA = "0x302854C")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x3028E50", Offset = "0x3028E50", VA = "0x3028E50")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x3027C60", Offset = "0x3027C60", VA = "0x3027C60")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x3028AC8", Offset = "0x3028AC8", VA = "0x3028AC8")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x302893C", Offset = "0x302893C", VA = "0x302893C")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x3028660", Offset = "0x3028660", VA = "0x3028660")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x3028A04", Offset = "0x3028A04", VA = "0x3028A04")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x3028CE4", Offset = "0x3028CE4", VA = "0x3028CE4")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x302914C", Offset = "0x302914C", VA = "0x302914C")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x30293B8", Offset = "0x30293B8", VA = "0x30293B8")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x30294A0", Offset = "0x30294A0", VA = "0x30294A0")]
	public static void RestoreConnectivity(RayfireConnectivity scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200005B")]
public class RFCollapse
{
	[Token(Token = "0x200005C")]
	public enum RFCollapseType
	{
		[Token(Token = "0x400020E")]
		ByArea = 1,
		[Token(Token = "0x400020F")]
		BySize = 3,
		[Token(Token = "0x4000210")]
		Random = 5
	}

	[Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class <CollapseCor>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x17000020")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x302B260", Offset = "0x302B260", VA = "0x302B260", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x302B2A8", Offset = "0x302B2A8", VA = "0x302B2A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x3029EB0", Offset = "0x3029EB0", VA = "0x3029EB0")]
		[DebuggerHidden]
		public <CollapseCor>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x302B09C", Offset = "0x302B09C", VA = "0x302B09C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x302B0A0", Offset = "0x302B0A0", VA = "0x302B0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x302B268", Offset = "0x302B268", VA = "0x302B268", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class <CollapseCor>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireConnectivity scr;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x17000022")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x302B474", Offset = "0x302B474", VA = "0x302B474", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x302B4BC", Offset = "0x302B4BC", VA = "0x302B4BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x302A020", Offset = "0x302A020", VA = "0x302A020")]
		[DebuggerHidden]
		public <CollapseCor>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x302B2B0", Offset = "0x302B2B0", VA = "0x302B2B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x302B2B4", Offset = "0x302B2B4", VA = "0x302B2B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x302B47C", Offset = "0x302B47C", VA = "0x302B47C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip(" By Area: Shard will loose it's connections if it's shared area surface is less then defined value.\n By Size: Shard will loose it's connections if it's Size is less then defined value.\n Random: Shard will loose it's connections if it's random value in range from 0 to 100 is less then defined value.")]
	public RFCollapseType type;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int start;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int end;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int steps;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int var;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int seed;

	[NonSerialized]
	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool inProgress;

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x3029D44", Offset = "0x3029D44", VA = "0x3029D44")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x3029D74", Offset = "0x3029D74", VA = "0x3029D74")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x3029E3C", Offset = "0x3029E3C", VA = "0x3029E3C")]
	[IteratorStateMachine(typeof(<CollapseCor>d__11))]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x3029ED8", Offset = "0x3029ED8", VA = "0x3029ED8")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x302A000", Offset = "0x302A000", VA = "0x302A000")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x3029F8C", Offset = "0x3029F8C", VA = "0x3029F8C")]
	[IteratorStateMachine(typeof(<CollapseCor>d__14))]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x302A048", Offset = "0x302A048", VA = "0x302A048")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x302A11C", Offset = "0x302A11C", VA = "0x302A11C")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x302A0B0", Offset = "0x302A0B0", VA = "0x302A0B0")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x302A184", Offset = "0x302A184", VA = "0x302A184")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x302A8C0", Offset = "0x302A8C0", VA = "0x302A8C0")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x302A4E8", Offset = "0x302A4E8", VA = "0x302A4E8")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x302AD48", Offset = "0x302AD48", VA = "0x302AD48")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x302AE08", Offset = "0x302AE08", VA = "0x302AE08")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x302ADA8", Offset = "0x302ADA8", VA = "0x302ADA8")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x302AE68", Offset = "0x302AE68", VA = "0x302AE68")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x302AEC8", Offset = "0x302AEC8", VA = "0x302AEC8")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x302A1F0", Offset = "0x302A1F0", VA = "0x302A1F0")]
	private static int RemNeibByArea(RFCluster cluster, float minArea, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x302A640", Offset = "0x302A640", VA = "0x302A640")]
	private static int RemNeibBySize(RFCluster cluster, float minSize, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x302A924", Offset = "0x302A924", VA = "0x302A924")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x302AF30", Offset = "0x302AF30", VA = "0x302AF30")]
	private static void RemoveConnection(RFCluster cluster, int s, int n)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x3029A80", Offset = "0x3029A80", VA = "0x3029A80")]
	public static void SetRangeData(RFCluster cluster, int perc = 0)
	{
	}
}
[Serializable]
[Token(Token = "0x200005F")]
public class RFDamage
{
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxDamage;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float currentDamage;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool collect;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float multiplier;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toShards;

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x302B4C4", Offset = "0x302B4C4", VA = "0x302B4C4")]
	public RFDamage()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x302B4FC", Offset = "0x302B4FC", VA = "0x302B4FC")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x3029144", Offset = "0x3029144", VA = "0x3029144")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x302B53C", Offset = "0x302B53C", VA = "0x302B53C")]
	public static bool ApplyDamage(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x302B6B0", Offset = "0x302B6B0", VA = "0x302B6B0")]
	public static bool ApplyTo(RayfireRigid scr, float value, Vector3 point, float radius = 0f, [Optional] Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x302B7EC", Offset = "0x302B7EC", VA = "0x302B7EC")]
	public static bool ApplyToRigid(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x302B6E8", Offset = "0x302B6E8", VA = "0x302B6E8")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x302B834", Offset = "0x302B834", VA = "0x302B834")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x302B9B0", Offset = "0x302B9B0", VA = "0x302B9B0")]
	public static bool ApplyToShards(RayfireRigid scr, float value, Vector3 point, float radius)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000060")]
public class RFDemolitionCluster
{
	[Token(Token = "0x2000061")]
	public enum RFDetachType
	{
		[Token(Token = "0x400023D")]
		RatioToSize = 0,
		[Token(Token = "0x400023E")]
		WorldUnits = 3
	}

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ConnectivityType connectivity;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float minimumArea;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minimumSize;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public RFDetachType type;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ratio;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float units;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardArea;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool shardDemolition;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int minAmount;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int maxAmount;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishable;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFCollapse collapse;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int clsCount;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RFCluster> minorClusters;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool cn;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool nd;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int am;

	[NonSerialized]
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float damageRadius;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string nameApp;

	[Token(Token = "0x17000024")]
	public bool HasChildClusters
	{
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x30312A8", Offset = "0x30312A8", VA = "0x30312A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x302C6F8", Offset = "0x302C6F8", VA = "0x302C6F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x302BBB8", Offset = "0x302BBB8", VA = "0x302BBB8")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x302BC10", Offset = "0x302BC10", VA = "0x302BC10")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x302913C", Offset = "0x302913C", VA = "0x302913C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x302BC68", Offset = "0x302BC68", VA = "0x302BC68")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x302BD28", Offset = "0x302BD28", VA = "0x302BD28")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x302BDC8", Offset = "0x302BDC8", VA = "0x302BDC8")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x302C300", Offset = "0x302C300", VA = "0x302C300")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x302C4B8", Offset = "0x302C4B8", VA = "0x302C4B8")]
	private static void InitNestedCluster(RFCluster parentCluster, List<RFCluster> minorClusters)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x302C028", Offset = "0x302C028", VA = "0x302C028")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x302C74C", Offset = "0x302C74C", VA = "0x302C74C")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x302CB70", Offset = "0x302CB70", VA = "0x302CB70")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x302CE44", Offset = "0x302CE44", VA = "0x302CE44")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x302CFF4", Offset = "0x302CFF4", VA = "0x302CFF4")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x302D36C", Offset = "0x302D36C", VA = "0x302D36C")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x302CC74", Offset = "0x302CC74", VA = "0x302CC74")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x302AB94", Offset = "0x302AB94", VA = "0x302AB94")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x302DC08", Offset = "0x302DC08", VA = "0x302DC08")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x302DCF0", Offset = "0x302DCF0", VA = "0x302DCF0")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x302DDE8", Offset = "0x302DDE8", VA = "0x302DDE8")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x302EE9C", Offset = "0x302EE9C", VA = "0x302EE9C")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x302F74C", Offset = "0x302F74C", VA = "0x302F74C")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x302D804", Offset = "0x302D804", VA = "0x302D804")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x302E43C", Offset = "0x302E43C", VA = "0x302E43C")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x302FB50", Offset = "0x302FB50", VA = "0x302FB50")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x30302F4", Offset = "0x30302F4", VA = "0x30302F4")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x3030798", Offset = "0x3030798", VA = "0x3030798")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x30301E0", Offset = "0x30301E0", VA = "0x30301E0")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x3030B50", Offset = "0x3030B50", VA = "0x3030B50")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x302E110", Offset = "0x302E110", VA = "0x302E110")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x3030DB4", Offset = "0x3030DB4", VA = "0x3030DB4")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x302E338", Offset = "0x302E338", VA = "0x302E338")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x3031184", Offset = "0x3031184", VA = "0x3031184")]
	private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000062")]
public class RFDemolitionSkin
{
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> bones;

	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SkinnedMeshRenderer> skins;

	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SkinnedMeshRenderer> skins0;

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SkinnedMeshRenderer> skins1;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skins2;

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x3031368", Offset = "0x3031368", VA = "0x3031368")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x3031404", Offset = "0x3031404", VA = "0x3031404")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x3031634", Offset = "0x3031634", VA = "0x3031634")]
	public RFDemolitionSkin()
	{
	}
}
[Serializable]
[Token(Token = "0x2000063")]
public class RFDemolitionMesh
{
	[Token(Token = "0x2000064")]
	public enum MeshInputType
	{
		[Token(Token = "0x400025A")]
		AtStart = 3,
		[Token(Token = "0x400025B")]
		AtInitialization = 6,
		[Token(Token = "0x400025C")]
		AtDemolition = 9
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <RuntimeCachingCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFDemolitionMesh <>4__this;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <demolitionShouldLocal>5__2;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> <batchAmount>5__3;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <tmRefGo>5__4;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> <meshesList>5__5;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> <pivotsList>5__6;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RFDictionary> <subList>5__7;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x17000026")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x3035020", Offset = "0x3035020", VA = "0x3035020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000027")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x3035068", Offset = "0x3035068", VA = "0x3035068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x3034018", Offset = "0x3034018", VA = "0x3034018")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x303472C", Offset = "0x303472C", VA = "0x303472C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3034730", Offset = "0x3034730", VA = "0x3034730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x3035028", Offset = "0x3035028", VA = "0x3035028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000244")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000245")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int variation;

	[Token(Token = "0x4000246")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float depthFade;

	[Token(Token = "0x4000247")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float contactBias;

	[Token(Token = "0x4000248")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x4000249")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool useShatter;

	[Token(Token = "0x400024A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool addChildren;

	[Token(Token = "0x400024B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool clusterize;

	[Token(Token = "0x400024C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FragSimType simType;

	[Token(Token = "0x400024D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MeshInputType meshInput;

	[Token(Token = "0x400024E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFFragmentProperties properties;

	[Token(Token = "0x400024F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRuntimeCaching runtimeCaching;

	[Token(Token = "0x4000250")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireShatter scrShatter;

	[NonSerialized]
	[Token(Token = "0x4000251")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int badMesh;

	[NonSerialized]
	[Token(Token = "0x4000252")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int shatterMode;

	[NonSerialized]
	[Token(Token = "0x4000253")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int totalAmount;

	[NonSerialized]
	[Token(Token = "0x4000254")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int innerSubId;

	[NonSerialized]
	[Token(Token = "0x4000255")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Mesh mesh;

	[NonSerialized]
	[Token(Token = "0x4000256")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFShatter rfShatter;

	[Token(Token = "0x4000257")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Quaternion cacheRotationStart;

	[Token(Token = "0x4000258")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string fragmentStr;

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x303163C", Offset = "0x303163C", VA = "0x303163C")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x30317F8", Offset = "0x30317F8", VA = "0x30317F8")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x30317EC", Offset = "0x30317EC", VA = "0x30317EC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x303193C", Offset = "0x303193C", VA = "0x303193C")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x3032650", Offset = "0x3032650", VA = "0x3032650")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x3031BB0", Offset = "0x3031BB0", VA = "0x3031BB0")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x3033308", Offset = "0x3033308", VA = "0x3033308")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x30337C0", Offset = "0x30337C0", VA = "0x30337C0")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x3032AFC", Offset = "0x3032AFC", VA = "0x3032AFC")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x3032580", Offset = "0x3032580", VA = "0x3032580")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x3033EF4", Offset = "0x3033EF4", VA = "0x3033EF4")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x3033FA4", Offset = "0x3033FA4", VA = "0x3033FA4")]
	[IteratorStateMachine(typeof(<RuntimeCachingCor>d__33))]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x3034040", Offset = "0x3034040", VA = "0x3034040")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x3034068", Offset = "0x3034068", VA = "0x3034068")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x30340C0", Offset = "0x30340C0", VA = "0x30340C0")]
	public static void Awake(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x3034168", Offset = "0x3034168", VA = "0x3034168")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x30341E4", Offset = "0x30341E4", VA = "0x30341E4")]
	private static void Prefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x30343D4", Offset = "0x30343D4", VA = "0x30343D4")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000066")]
public class RFFade
{
	[Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class <FadeOffsetCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000028")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x303652C", Offset = "0x303652C", VA = "0x303652C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x3036574", Offset = "0x3036574", VA = "0x3036574", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x30353D8", Offset = "0x30353D8", VA = "0x30353D8")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x30362E8", Offset = "0x30362E8", VA = "0x30362E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x30362EC", Offset = "0x30362EC", VA = "0x30362EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x3036534", Offset = "0x3036534", VA = "0x3036534", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class <FadeOffsetCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x1700002A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x30368A0", Offset = "0x30368A0", VA = "0x30368A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x30368E8", Offset = "0x30368E8", VA = "0x30368E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x3035468", Offset = "0x3035468", VA = "0x3035468")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x303657C", Offset = "0x303657C", VA = "0x303657C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3036580", Offset = "0x3036580", VA = "0x3036580", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x30368A8", Offset = "0x30368A8", VA = "0x30368A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[CompilerGenerated]
	private sealed class <LivingCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x1700002C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x3036BDC", Offset = "0x3036BDC", VA = "0x3036BDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x3036C24", Offset = "0x3036C24", VA = "0x3036C24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x30356F4", Offset = "0x30356F4", VA = "0x30356F4")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x30368F0", Offset = "0x30368F0", VA = "0x30368F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x30368F4", Offset = "0x30368F4", VA = "0x30368F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x3036BE4", Offset = "0x3036BE4", VA = "0x3036BE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[CompilerGenerated]
	private sealed class <LivingCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x1700002E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x3036EFC", Offset = "0x3036EFC", VA = "0x3036EFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x3036F44", Offset = "0x3036F44", VA = "0x3036F44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x303571C", Offset = "0x303571C", VA = "0x303571C")]
		[DebuggerHidden]
		public <LivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3036C2C", Offset = "0x3036C2C", VA = "0x3036C2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3036C30", Offset = "0x3036C30", VA = "0x3036C30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x3036F04", Offset = "0x3036F04", VA = "0x3036F04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class <SimulationLivingCor>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tm;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <oldPos>5__2;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <distanceThreshold>5__3;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000030")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x30370CC", Offset = "0x30370CC", VA = "0x30370CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000249")]
			[Address(RVA = "0x3037114", Offset = "0x3037114", VA = "0x3037114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x30357AC", Offset = "0x30357AC", VA = "0x30357AC")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3036F4C", Offset = "0x3036F4C", VA = "0x3036F4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x3036F50", Offset = "0x3036F50", VA = "0x3036F50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x30370D4", Offset = "0x30370D4", VA = "0x30370D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006C")]
	[CompilerGenerated]
	private sealed class <FallDownCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x17000032")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x30372FC", Offset = "0x30372FC", VA = "0x30372FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x3037344", Offset = "0x3037344", VA = "0x3037344", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x3035AEC", Offset = "0x3035AEC", VA = "0x3035AEC")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x303711C", Offset = "0x303711C", VA = "0x303711C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x3037120", Offset = "0x3037120", VA = "0x3037120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x3037304", Offset = "0x3037304", VA = "0x3037304", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006D")]
	[CompilerGenerated]
	private sealed class <FallDownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x17000034")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x303750C", Offset = "0x303750C", VA = "0x303750C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x3037554", Offset = "0x3037554", VA = "0x3037554", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x3035B88", Offset = "0x3035B88", VA = "0x3035B88")]
		[DebuggerHidden]
		public <FallDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x303734C", Offset = "0x303734C", VA = "0x303734C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x3037350", Offset = "0x3037350", VA = "0x3037350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x3037514", Offset = "0x3037514", VA = "0x3037514", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006E")]
	[CompilerGenerated]
	private sealed class <ScaleDownCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000036")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x3037720", Offset = "0x3037720", VA = "0x3037720", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x3037768", Offset = "0x3037768", VA = "0x3037768", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x3035C18", Offset = "0x3035C18", VA = "0x3035C18")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x303755C", Offset = "0x303755C", VA = "0x303755C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x3037560", Offset = "0x3037560", VA = "0x3037560", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3037728", Offset = "0x3037728", VA = "0x3037728", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006F")]
	[CompilerGenerated]
	private sealed class <ScaleDownCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x3037978", Offset = "0x3037978", VA = "0x3037978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x30379C0", Offset = "0x30379C0", VA = "0x30379C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3035CB4", Offset = "0x3035CB4", VA = "0x3035CB4")]
		[DebuggerHidden]
		public <ScaleDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3037770", Offset = "0x3037770", VA = "0x3037770", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3037774", Offset = "0x3037774", VA = "0x3037774", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3037980", Offset = "0x3037980", VA = "0x3037980", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
	private sealed class <FadeMoveDownCor>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x3037DB8", Offset = "0x3037DB8", VA = "0x3037DB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x3037E00", Offset = "0x3037E00", VA = "0x3037E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x3035D44", Offset = "0x3035D44", VA = "0x3035D44")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x30379C8", Offset = "0x30379C8", VA = "0x30379C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x30379CC", Offset = "0x30379CC", VA = "0x30379CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x3037DC0", Offset = "0x3037DC0", VA = "0x3037DC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000071")]
	[CompilerGenerated]
	private sealed class <FadeMoveDownCor>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x3038150", Offset = "0x3038150", VA = "0x3038150", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x3038198", Offset = "0x3038198", VA = "0x3038198", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x3035DE0", Offset = "0x3035DE0", VA = "0x3035DE0")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x3037E08", Offset = "0x3037E08", VA = "0x3037E08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3037E0C", Offset = "0x3037E0C", VA = "0x3037E0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x3038158", Offset = "0x3038158", VA = "0x3038158", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onDemolition;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onActivation;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFFadeLifeType lifeType;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lifeTime;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeVariation;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public FadeType fadeType;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeTime;

	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeFilter;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardAmount;

	[NonSerialized]
	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int state;

	[NonSerialized]
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool stop;

	[NonSerialized]
	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 position;

	[NonSerialized]
	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFFadingEvent fadingEvent;

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x3035070", Offset = "0x3035070", VA = "0x3035070")]
	public RFFade()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x3035130", Offset = "0x3035130", VA = "0x3035130")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x303511C", Offset = "0x303511C", VA = "0x303511C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x3035174", Offset = "0x3035174", VA = "0x3035174")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x3035370", Offset = "0x3035370", VA = "0x3035370")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__20))]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x3035400", Offset = "0x3035400", VA = "0x3035400")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__21))]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x3035260", Offset = "0x3035260", VA = "0x3035260")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x30354F8", Offset = "0x30354F8", VA = "0x30354F8")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x30355D8", Offset = "0x30355D8", VA = "0x30355D8")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x3035490", Offset = "0x3035490", VA = "0x3035490")]
	[IteratorStateMachine(typeof(<LivingCor>d__25))]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x3035564", Offset = "0x3035564", VA = "0x3035564")]
	[IteratorStateMachine(typeof(<LivingCor>d__26))]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3035744", Offset = "0x3035744", VA = "0x3035744")]
	[IteratorStateMachine(typeof(<SimulationLivingCor>d__27))]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x30357D4", Offset = "0x30357D4", VA = "0x30357D4")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x30359B0", Offset = "0x30359B0", VA = "0x30359B0")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x3035A84", Offset = "0x3035A84", VA = "0x3035A84")]
	[IteratorStateMachine(typeof(<FallDownCor>d__30))]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x3035B14", Offset = "0x3035B14", VA = "0x3035B14")]
	[IteratorStateMachine(typeof(<FallDownCor>d__31))]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x3035BB0", Offset = "0x3035BB0", VA = "0x3035BB0")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__32))]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x3035C40", Offset = "0x3035C40", VA = "0x3035C40")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__33))]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x3035CDC", Offset = "0x3035CDC", VA = "0x3035CDC")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__34))]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3035D6C", Offset = "0x3035D6C", VA = "0x3035D6C")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__35))]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3035E08", Offset = "0x3035E08", VA = "0x3035E08")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x3036014", Offset = "0x3036014", VA = "0x3036014")]
	public static void SetOffsetFadeList(RayfireRigidRoot root)
	{
	}
}
[Serializable]
[Token(Token = "0x2000072")]
public class RFFragmentProperties
{
	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFColliderType colliderType;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sizeFilter;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool decompose;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool removeCollinear;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool l;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int layer;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool t;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x303175C", Offset = "0x303175C", VA = "0x303175C")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x30318F4", Offset = "0x30318F4", VA = "0x30318F4")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x3032C98", Offset = "0x3032C98", VA = "0x3032C98")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x3032CE4", Offset = "0x3032CE4", VA = "0x3032CE4")]
	public string GetTag(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000073")]
public class RFLimitations
{
	[Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class <DemolishableCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFLimitations <>4__this;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x303A50C", Offset = "0x303A50C", VA = "0x303A50C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x303A554", Offset = "0x303A554", VA = "0x303A554", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x30383EC", Offset = "0x30383EC", VA = "0x30383EC")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x303A400", Offset = "0x303A400", VA = "0x303A400", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x303A404", Offset = "0x303A404", VA = "0x303A404", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x303A514", Offset = "0x303A514", VA = "0x303A514", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool byCollision;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float solidity;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tag;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool visible;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool sliceByBlade;

	[NonSerialized]
	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> slicePlanes;

	[NonSerialized]
	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ContactPoint contactPoint;

	[NonSerialized]
	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 contactVector3;

	[NonSerialized]
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 contactNormal;

	[NonSerialized]
	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool demolitionShould;

	[NonSerialized]
	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool demolished;

	[NonSerialized]
	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float birthTime;

	[NonSerialized]
	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bboxSize;

	[NonSerialized]
	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int currentDepth;

	[NonSerialized]
	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool demolishableCorState;

	[NonSerialized]
	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sliceForce;

	[NonSerialized]
	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool affectInactive;

	[NonSerialized]
	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RayfireRigid ancestor;

	[NonSerialized]
	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RayfireRigid> descendants;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string rootStr;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string rigidStr;

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x30381A0", Offset = "0x30381A0", VA = "0x30381A0")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x303832C", Offset = "0x303832C", VA = "0x303832C")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x3038230", Offset = "0x3038230", VA = "0x3038230")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3038378", Offset = "0x3038378", VA = "0x3038378")]
	[IteratorStateMachine(typeof(<DemolishableCor>d__28))]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x3038414", Offset = "0x3038414", VA = "0x3038414")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x3039B7C", Offset = "0x3039B7C", VA = "0x3039B7C")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x3039CA8", Offset = "0x3039CA8", VA = "0x3039CA8")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x3039DD4", Offset = "0x3039DD4", VA = "0x3039DD4")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x3032B34", Offset = "0x3032B34", VA = "0x3032B34")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x3039EA4", Offset = "0x3039EA4", VA = "0x3039EA4")]
	public bool CollisionCheck(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x3039EEC", Offset = "0x3039EEC", VA = "0x3039EEC")]
	public void SetContactInfo(ContactPoint contact)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3039F44", Offset = "0x3039F44", VA = "0x3039F44")]
	public bool KinematicCollisionCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x303A0B8", Offset = "0x303A0B8", VA = "0x303A0B8")]
	public bool ContactPointsCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x303A1D8", Offset = "0x303A1D8", VA = "0x303A1D8")]
	public bool DamagePointsCheck(Collision collision, RayfireRigid rigid)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000075")]
public class RFPhysic
{
	[Token(Token = "0x2000076")]
	private struct RFIgnorePair
	{
		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int a;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int b;

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x303DF08", Offset = "0x303DF08", VA = "0x303DF08")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class <PhysicsDataCor>d__72 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPhysic <>4__this;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000045")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x303E240", Offset = "0x303E240", VA = "0x303E240", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x303E288", Offset = "0x303E288", VA = "0x303E288", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x303DF84", Offset = "0x303DF84", VA = "0x303DF84")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x303E0E0", Offset = "0x303E0E0", VA = "0x303E0E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x303E0E4", Offset = "0x303E0E4", VA = "0x303E0E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x303E248", Offset = "0x303E248", VA = "0x303E248", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("materialType")]
	public MaterialType mt;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhysicMaterial material;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MassType massBy;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mass;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("colliderType")]
	public RFColliderType ct;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[FormerlySerializedAs("planarCheck")]
	public bool pc;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	[FormerlySerializedAs("ignoreNear")]
	public bool ine;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	[FormerlySerializedAs("useGravity")]
	public bool gr;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[FormerlySerializedAs("solverIterations")]
	public int si;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float st;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[FormerlySerializedAs("dampening")]
	public float dm;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody rigidBody;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Collider meshCollider;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Collider> clusterColliders;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> ignoreList;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool rec;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool exclude;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int solidity;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool destructible;

	[NonSerialized]
	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3 initScale;

	[NonSerialized]
	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public Vector3 initPosition;

	[NonSerialized]
	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Quaternion initRotation;

	[NonSerialized]
	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Vector3 localPosition;

	[NonSerialized]
	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public IEnumerator physicsEnum;

	[NonSerialized]
	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool physicsDataCorState;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int coplanarVertLimit;

	[Token(Token = "0x17000040")]
	public bool HasIgnore
	{
		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x303D330", Offset = "0x303D330", VA = "0x303D330")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000041")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x3035FBC", Offset = "0x3035FBC", VA = "0x3035FBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000042")]
	public bool Destructible
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x303DFAC", Offset = "0x303DFAC", VA = "0x303DFAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public int Solidity
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x303E020", Offset = "0x303E020", VA = "0x303E020")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x303C890", Offset = "0x303C890", VA = "0x303C890")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x303A55C", Offset = "0x303A55C", VA = "0x303A55C")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x303A720", Offset = "0x303A720", VA = "0x303A720")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x303A6BC", Offset = "0x303A6BC", VA = "0x303A6BC")]
	public void Reset()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x303A77C", Offset = "0x303A77C", VA = "0x303A77C")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x303A7F0", Offset = "0x303A7F0", VA = "0x303A7F0")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x303A84C", Offset = "0x303A84C", VA = "0x303A84C")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver, float sleep = 0.005f)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x303AA08", Offset = "0x303AA08", VA = "0x303AA08")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x303AAF8", Offset = "0x303AAF8", VA = "0x303AAF8")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x303AB40", Offset = "0x303AB40", VA = "0x303AB40")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x303AB7C", Offset = "0x303AB7C", VA = "0x303AB7C")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x303AA44", Offset = "0x303AA44", VA = "0x303AA44")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x303ABC8", Offset = "0x303ABC8", VA = "0x303ABC8")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x303AE74", Offset = "0x303AE74", VA = "0x303AE74")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x303AD3C", Offset = "0x303AD3C", VA = "0x303AD3C")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x3032EEC", Offset = "0x3032EEC", VA = "0x3032EEC")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x303AF64", Offset = "0x303AF64", VA = "0x303AF64")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x303B040", Offset = "0x303B040", VA = "0x303B040")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x303B084", Offset = "0x303B084", VA = "0x303B084")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x3032D80", Offset = "0x3032D80", VA = "0x3032D80")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x303B2F4", Offset = "0x303B2F4", VA = "0x303B2F4")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x303B7E0", Offset = "0x303B7E0", VA = "0x303B7E0")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x303BA00", Offset = "0x303BA00", VA = "0x303BA00")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x303BC0C", Offset = "0x303BC0C", VA = "0x303BC0C")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x303BD80", Offset = "0x303BD80", VA = "0x303BD80")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x303BED0", Offset = "0x303BED0", VA = "0x303BED0")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x303C350", Offset = "0x303C350", VA = "0x303C350")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x303C44C", Offset = "0x303C44C", VA = "0x303C44C")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x303C540", Offset = "0x303C540", VA = "0x303C540")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x303C70C", Offset = "0x303C70C", VA = "0x303C70C")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x303C910", Offset = "0x303C910", VA = "0x303C910")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x303C9A4", Offset = "0x303C9A4", VA = "0x303C9A4")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x303CAAC", Offset = "0x303CAAC", VA = "0x303CAAC")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x303CBA0", Offset = "0x303CBA0", VA = "0x303CBA0")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x303CCFC", Offset = "0x303CCFC", VA = "0x303CCFC")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x303CE10", Offset = "0x303CE10", VA = "0x303CE10")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x303D128", Offset = "0x303D128", VA = "0x303D128")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x3032F28", Offset = "0x3032F28", VA = "0x3032F28")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x303DA7C", Offset = "0x303DA7C", VA = "0x303DA7C")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x303DB5C", Offset = "0x303DB5C", VA = "0x303DB5C")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x303D670", Offset = "0x303D670", VA = "0x303D670")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x303D384", Offset = "0x303D384", VA = "0x303D384")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x303D894", Offset = "0x303D894", VA = "0x303D894")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x303DD38", Offset = "0x303DD38", VA = "0x303DD38")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x303B2E8", Offset = "0x303B2E8", VA = "0x303B2E8")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x303DF10", Offset = "0x303DF10", VA = "0x303DF10")]
	[IteratorStateMachine(typeof(<PhysicsDataCor>d__72))]
	public IEnumerator PhysicsDataCor(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000078")]
public class RFReferenceDemolition
{
	[Token(Token = "0x2000079")]
	public enum ActionType
	{
		[Token(Token = "0x40002FC")]
		Instantiate,
		[Token(Token = "0x40002FD")]
		SetActive
	}

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject reference;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> randomList;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionType action;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool addRigid;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool inheritScale;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inheritMaterials;

	[Token(Token = "0x17000047")]
	public bool HasRandomRefs
	{
		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x303E398", Offset = "0x303E398", VA = "0x303E398")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x303E290", Offset = "0x303E290", VA = "0x303E290")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x303E2B8", Offset = "0x303E2B8", VA = "0x303E2B8")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x303E3EC", Offset = "0x303E3EC", VA = "0x303E3EC")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x303E674", Offset = "0x303E674", VA = "0x303E674")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x303F0AC", Offset = "0x303F0AC", VA = "0x303F0AC")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x303F258", Offset = "0x303F258", VA = "0x303F258")]
	private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
	{
	}
}
[Serializable]
[Token(Token = "0x200007A")]
public class RFReset
{
	[Token(Token = "0x200007B")]
	public enum PostDemolitionType
	{
		[Token(Token = "0x4000307")]
		DestroyWithDelay,
		[Token(Token = "0x4000308")]
		DeactivateToReset
	}

	[Token(Token = "0x200007C")]
	public enum MeshResetType
	{
		[Token(Token = "0x400030A")]
		Destroy = 0,
		[Token(Token = "0x400030B")]
		ReuseInputMesh = 2,
		[Token(Token = "0x400030C")]
		ReuseFragmentMeshes = 4
	}

	[Token(Token = "0x200007D")]
	public enum FragmentsResetType
	{
		[Token(Token = "0x400030E")]
		Destroy = 0,
		[Token(Token = "0x400030F")]
		Reuse = 2,
		[Token(Token = "0x4000310")]
		Preserve = 4
	}

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool transform;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool damage;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool connectivity;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PostDemolitionType action;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float destroyDelay;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MeshResetType mesh;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FragmentsResetType fragments;

	[NonSerialized]
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toBeDestroyed;

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x303F424", Offset = "0x303F424", VA = "0x303F424")]
	public RFReset()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x303F45C", Offset = "0x303F45C", VA = "0x303F45C")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x303F4B8", Offset = "0x303F4B8", VA = "0x303F4B8")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x303FEF4", Offset = "0x303FEF4", VA = "0x303FEF4")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x303F7A8", Offset = "0x303F7A8", VA = "0x303F7A8")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x3040554", Offset = "0x3040554", VA = "0x3040554")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x30406D8", Offset = "0x30406D8", VA = "0x30406D8")]
	public static void DestroyMeshRootParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x3040848", Offset = "0x3040848", VA = "0x3040848")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x3040EFC", Offset = "0x3040EFC", VA = "0x3040EFC")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x3040CD8", Offset = "0x3040CD8", VA = "0x3040CD8")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x3040B68", Offset = "0x3040B68", VA = "0x3040B68")]
	public static void DestroyRigidRootParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x3041118", Offset = "0x3041118", VA = "0x3041118")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x3040150", Offset = "0x3040150", VA = "0x3040150")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x30418CC", Offset = "0x30418CC", VA = "0x30418CC")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x30402BC", Offset = "0x30402BC", VA = "0x30402BC")]
	public static void DestroyRigidParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x30414E8", Offset = "0x30414E8", VA = "0x30414E8")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x3041F24", Offset = "0x3041F24", VA = "0x3041F24")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x30401FC", Offset = "0x30401FC", VA = "0x30401FC")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x303F680", Offset = "0x303F680", VA = "0x303F680")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x3041290", Offset = "0x3041290", VA = "0x3041290")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x303FAFC", Offset = "0x303FAFC", VA = "0x303FAFC")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x303FC70", Offset = "0x303FC70", VA = "0x303FC70")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x304022C", Offset = "0x304022C", VA = "0x304022C")]
	public static void ResetSound(RayfireSound scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200007F")]
public class RFRuntimeCaching
{
	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CachingType type;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(2f, 300f)]
	public int frames;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 20f)]
	public int fragments;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool skipFirstDemolition;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[HideInInspector]
	public bool wasUsed;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[HideInInspector]
	public bool stop;

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x30317C8", Offset = "0x30317C8", VA = "0x30317C8")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x3034CC4", Offset = "0x3034CC4", VA = "0x3034CC4")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x3034B58", Offset = "0x3034B58", VA = "0x3034B58")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x3042168", Offset = "0x3042168", VA = "0x3042168")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x3034E98", Offset = "0x3034E98", VA = "0x3034E98")]
	public static GameObject CreateTmRef(RayfireRigid rfScr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000080")]
public class RFMirrored
{
	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PlaneType planeType;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool noPoints;

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x30422E8", Offset = "0x30422E8", VA = "0x30422E8")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x304230C", Offset = "0x304230C", VA = "0x304230C")]
	public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000081")]
public class RFCustom
{
	[Token(Token = "0x2000082")]
	public enum RFPointCloudSourceType
	{
		[Token(Token = "0x400032F")]
		ChildrenTransform = 4,
		[Token(Token = "0x4000330")]
		TransformList = 8,
		[Token(Token = "0x4000331")]
		Vector3List = 12
	}

	[Token(Token = "0x2000083")]
	public enum RFPointCloudUseType
	{
		[Token(Token = "0x4000333")]
		VolumePoints = 4,
		[Token(Token = "0x4000334")]
		PointCloud = 12
	}

	[Token(Token = "0x2000084")]
	public enum RFModifierType
	{
		[Token(Token = "0x4000336")]
		None = 0,
		[Token(Token = "0x4000337")]
		Splinters = 3,
		[Token(Token = "0x4000338")]
		Slabs = 6
	}

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFPointCloudSourceType source;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFPointCloudUseType useAs;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float radius;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool enable;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> transforms;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> vector3;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noPoints;

	[NonSerialized]
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector3> inputPoints;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Vector3> outputPoints;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<Vector3> inBoundPoints;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<Vector3> outBoundPoints;

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x30423A4", Offset = "0x30423A4", VA = "0x30423A4")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x30423E8", Offset = "0x30423E8", VA = "0x30423E8")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x3042430", Offset = "0x3042430", VA = "0x3042430")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x30424F0", Offset = "0x30424F0", VA = "0x30424F0")]
	private static void SetCustomInputCloud(RFCustom custom, Transform tm)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x3042860", Offset = "0x3042860", VA = "0x3042860")]
	private static void SetCustomOutputCloud(RFCustom custom, int seed, Bounds bound)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x3042AC4", Offset = "0x3042AC4", VA = "0x3042AC4")]
	private static void SetCustomBoundPoints(RFCustom custom, Bounds bound)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x3042CF8", Offset = "0x3042CF8", VA = "0x3042CF8")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x3042D6C", Offset = "0x3042D6C", VA = "0x3042D6C")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x2000085")]
public static class RFFragment
{
	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool silentMode;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Mesh> meshListStatic;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<Vector3> pivotListStatic;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<Dictionary<int, int>> subIdsListStatic;

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x3042DD4", Offset = "0x3042DD4", VA = "0x3042DD4")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x3044530", Offset = "0x3044530", VA = "0x3044530")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x30448E8", Offset = "0x30448E8", VA = "0x30448E8")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x3045844", Offset = "0x3045844", VA = "0x3045844")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x30458F8", Offset = "0x30458F8", VA = "0x30458F8")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x3046370", Offset = "0x3046370", VA = "0x3046370")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x30467B8", Offset = "0x30467B8", VA = "0x30467B8")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x3046648", Offset = "0x3046648", VA = "0x3046648")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x30462E0", Offset = "0x30462E0", VA = "0x30462E0")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x3043430", Offset = "0x3043430", VA = "0x3043430")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x3046CF8", Offset = "0x3046CF8", VA = "0x3046CF8")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x3043F20", Offset = "0x3043F20", VA = "0x3043F20")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x304336C", Offset = "0x304336C", VA = "0x304336C")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x3047374", Offset = "0x3047374", VA = "0x3047374")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x3043A3C", Offset = "0x3043A3C", VA = "0x3043A3C")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x3045BB8", Offset = "0x3045BB8", VA = "0x3045BB8")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x3043514", Offset = "0x3043514", VA = "0x3043514")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x30486E0", Offset = "0x30486E0", VA = "0x30486E0")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x3048860", Offset = "0x3048860", VA = "0x3048860")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x304893C", Offset = "0x304893C", VA = "0x304893C")]
	private static void SetCustomUV(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x30489C8", Offset = "0x30489C8", VA = "0x30489C8")]
	private static void SetCustomColor(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x30475E8", Offset = "0x30475E8", VA = "0x30475E8")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x304774C", Offset = "0x304774C", VA = "0x304774C")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x30478C8", Offset = "0x30478C8", VA = "0x30478C8")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x3047A44", Offset = "0x3047A44", VA = "0x3047A44")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x3047CF8", Offset = "0x3047CF8", VA = "0x3047CF8")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x3048BFC", Offset = "0x3048BFC", VA = "0x3048BFC")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x3047DEC", Offset = "0x3047DEC", VA = "0x3047DEC")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x3048148", Offset = "0x3048148", VA = "0x3048148")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x30483A0", Offset = "0x30483A0", VA = "0x30483A0")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x3048CF8", Offset = "0x3048CF8", VA = "0x3048CF8")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x304846C", Offset = "0x304846C", VA = "0x304846C")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3048688", Offset = "0x3048688", VA = "0x3048688")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x30473E8", Offset = "0x30473E8", VA = "0x30473E8")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3048A14", Offset = "0x3048A14", VA = "0x3048A14")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x3048B18", Offset = "0x3048B18", VA = "0x3048B18")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x3048D0C", Offset = "0x3048D0C", VA = "0x3048D0C")]
	public static void RescaleMesh(Mesh mesh, float scale)
	{
	}
}
[Serializable]
[Token(Token = "0x2000088")]
public class RFMeshExport
{
	[Token(Token = "0x2000089")]
	public enum MeshExportType
	{
		[Token(Token = "0x4000343")]
		LastFragments = 0,
		[Token(Token = "0x4000344")]
		Children = 3
	}

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshExportType source;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string suffix;

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x3048FAC", Offset = "0x3048FAC", VA = "0x3048FAC")]
	public RFMeshExport()
	{
	}
}
[Serializable]
[Token(Token = "0x200008A")]
public class RFShatterAdvanced
{
	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int seed;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool decompose;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool removeCollinear;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool copyComponents;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool postWeld;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool smooth;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool inputPrecap;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool outputPrecap;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool removeDoubleFaces;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int elementSizeThreshold;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool combineChildren;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inner;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool planar;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int relativeSize;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float absoluteSize;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool sizeLimitation;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeAmount;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool vertexLimitation;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int vertexAmount;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool triangleLimitation;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int triangleAmount;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float planarThreshold;

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x3048FFC", Offset = "0x3048FFC", VA = "0x3048FFC")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x3049064", Offset = "0x3049064", VA = "0x3049064")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x3044F70", Offset = "0x3044F70", VA = "0x3044F70")]
	public static bool IsCoplanar(Mesh mesh, float threshold)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200008B")]
public class RFSurface
{
	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("innerMaterial")]
	public Material iMat;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("outerMaterial")]
	public Material oMat;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("mappingScale")]
	public float mScl;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool uvE;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 uvC;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool cE;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Color cC;

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x3049158", Offset = "0x3049158", VA = "0x3049158")]
	public RFSurface()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x3049184", Offset = "0x3049184", VA = "0x3049184")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x30491C8", Offset = "0x30491C8", VA = "0x30491C8")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x3045A6C", Offset = "0x3045A6C", VA = "0x3045A6C")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x30438F0", Offset = "0x30438F0", VA = "0x30438F0")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x200008C")]
[AddComponentMenu("RayFire/Rayfire Activator")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-activator-component/")]
public class RayfireActivator : MonoBehaviour
{
	[Token(Token = "0x200008D")]
	public enum ActivationType
	{
		[Token(Token = "0x4000386")]
		OnTriggerEnter,
		[Token(Token = "0x4000387")]
		OnTriggerExit,
		[Token(Token = "0x4000388")]
		OnCollision
	}

	[Token(Token = "0x200008E")]
	public enum AnimationType
	{
		[Token(Token = "0x400038A")]
		ByGlobalPositionList = 0,
		[Token(Token = "0x400038B")]
		ByStaticLine = 1,
		[Token(Token = "0x400038C")]
		ByDynamicLine = 2,
		[Token(Token = "0x400038D")]
		ByLocalPositionList = 5
	}

	[Token(Token = "0x200008F")]
	public enum GizmoType
	{
		[Token(Token = "0x400038F")]
		Box = 1,
		[Token(Token = "0x4000390")]
		Sphere = 0,
		[Token(Token = "0x4000391")]
		Collider = 2,
		[Token(Token = "0x4000392")]
		ParticleSystem = 5
	}

	[Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class <DelayedActivationCor>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x304B514", Offset = "0x304B514", VA = "0x304B514", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x304B55C", Offset = "0x304B55C", VA = "0x304B55C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x3049FA8", Offset = "0x3049FA8", VA = "0x3049FA8")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x304B41C", Offset = "0x304B41C", VA = "0x304B41C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x304B420", Offset = "0x304B420", VA = "0x304B420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x304B51C", Offset = "0x304B51C", VA = "0x304B51C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000091")]
	[CompilerGenerated]
	private sealed class <DelayedClusterCor>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x304B70C", Offset = "0x304B70C", VA = "0x304B70C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x304B754", Offset = "0x304B754", VA = "0x304B754", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x3049FD0", Offset = "0x3049FD0", VA = "0x3049FD0")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x304B564", Offset = "0x304B564", VA = "0x304B564", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x304B568", Offset = "0x304B568", VA = "0x304B568", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x304B714", Offset = "0x304B714", VA = "0x304B714", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class <DelayedActivationCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x304B854", Offset = "0x304B854", VA = "0x304B854", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x304B89C", Offset = "0x304B89C", VA = "0x304B89C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x304A388", Offset = "0x304A388", VA = "0x304A388")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x304B75C", Offset = "0x304B75C", VA = "0x304B75C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x304B760", Offset = "0x304B760", VA = "0x304B760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x304B85C", Offset = "0x304B85C", VA = "0x304B85C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class <AnimationCor>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x304BBE4", Offset = "0x304BBE4", VA = "0x304BBE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000360")]
			[Address(RVA = "0x304BC2C", Offset = "0x304BC2C", VA = "0x304BC2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x304ADA4", Offset = "0x304ADA4", VA = "0x304ADA4")]
		[DebuggerHidden]
		public <AnimationCor>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x304B8A4", Offset = "0x304B8A4", VA = "0x304B8A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x304B8A8", Offset = "0x304B8A8", VA = "0x304B8A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x304BBEC", Offset = "0x304BBEC", VA = "0x304BBEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GizmoType gizmoType;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sphereRadius;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 boxSize;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool checkRigid;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool checkRigidRoot;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ActivationType type;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool demolishCluster;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool apply;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 velocity;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 spin;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ForceMode mode;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool coord;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showAnimation;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float duration;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float scaleAnimation;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AnimationType positionAnimation;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LineRenderer line;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Vector3> positionList;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool showGizmo;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider activatorCollider;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleSystem ps;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool animating;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float pathRatio;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lineLength;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<float> checkpoints;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float delta;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float deltaRatioStep;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float distDeltaStep;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float distRatio;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float timePassed;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int activeSegment;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 positionStart;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 scaleStart;

	[Token(Token = "0x17000048")]
	public bool ByPositions
	{
		[Token(Token = "0x6000346")]
		[Address(RVA = "0x304B35C", Offset = "0x304B35C", VA = "0x304B35C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000049")]
	public bool ByLine
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x304A534", Offset = "0x304A534", VA = "0x304A534")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x304942C", Offset = "0x304942C", VA = "0x304942C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x304989C", Offset = "0x304989C", VA = "0x304989C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x3049934", Offset = "0x3049934", VA = "0x3049934")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x3049A68", Offset = "0x3049A68", VA = "0x3049A68")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x3049A78", Offset = "0x3049A78", VA = "0x3049A78")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x3049498", Offset = "0x3049498", VA = "0x3049498")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x30496CC", Offset = "0x30496CC", VA = "0x30496CC")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x30498E8", Offset = "0x30498E8", VA = "0x30498E8")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x3049A8C", Offset = "0x3049A8C", VA = "0x3049A8C")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3049EB8", Offset = "0x3049EB8", VA = "0x3049EB8")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__47))]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x3049F2C", Offset = "0x3049F2C", VA = "0x3049F2C")]
	[IteratorStateMachine(typeof(<DelayedClusterCor>d__48))]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x3049E74", Offset = "0x3049E74", VA = "0x3049E74")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x3049CBC", Offset = "0x3049CBC", VA = "0x3049CBC")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x304A30C", Offset = "0x304A30C", VA = "0x304A30C")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__51))]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x304A178", Offset = "0x304A178", VA = "0x304A178")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x3049FF8", Offset = "0x3049FF8", VA = "0x3049FF8")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x304A3B0", Offset = "0x304A3B0", VA = "0x304A3B0")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x304A48C", Offset = "0x304A48C", VA = "0x304A48C")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x304A548", Offset = "0x304A548", VA = "0x304A548")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x304A7E4", Offset = "0x304A7E4", VA = "0x304A7E4")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x304AA10", Offset = "0x304AA10", VA = "0x304AA10")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x304A4CC", Offset = "0x304A4CC", VA = "0x304A4CC")]
	[IteratorStateMachine(typeof(<AnimationCor>d__59))]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x304ADCC", Offset = "0x304ADCC", VA = "0x304ADCC")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x304AEBC", Offset = "0x304AEBC", VA = "0x304AEBC")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x304AF1C", Offset = "0x304AF1C", VA = "0x304AF1C")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x304AF24", Offset = "0x304AF24", VA = "0x304AF24")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x304AF58", Offset = "0x304AF58", VA = "0x304AF58")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x304B2B0", Offset = "0x304B2B0", VA = "0x304B2B0")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x304B378", Offset = "0x304B378", VA = "0x304B378")]
	public RayfireActivator()
	{
	}
}
[Token(Token = "0x2000094")]
public class RFSliceData
{
	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 planePos;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 planeDir;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 swingDir;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float swingStr;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float force;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float damage;

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x304BC34", Offset = "0x304BC34", VA = "0x304BC34")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x2000095")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-blade-component/")]
[AddComponentMenu("RayFire/Rayfire Blade")]
public class RayfireBlade : MonoBehaviour
{
	[Token(Token = "0x2000096")]
	public enum CutType
	{
		[Token(Token = "0x40003C1")]
		Enter,
		[Token(Token = "0x40003C2")]
		Exit,
		[Token(Token = "0x40003C3")]
		EnterExit
	}

	[Token(Token = "0x2000097")]
	public enum ActionType
	{
		[Token(Token = "0x40003C5")]
		Slice,
		[Token(Token = "0x40003C6")]
		Demolish
	}

	[Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class <CooldownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBlade <>4__this;

		[Token(Token = "0x17000053")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x304CAFC", Offset = "0x304CAFC", VA = "0x304CAFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000054")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x304CB44", Offset = "0x304CB44", VA = "0x304CB44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x304C5B0", Offset = "0x304C5B0", VA = "0x304C5B0")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x304CA28", Offset = "0x304CA28", VA = "0x304CA28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x304CA2C", Offset = "0x304CA2C", VA = "0x304CA2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x304CB04", Offset = "0x304CB04", VA = "0x304CB04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionType actionType;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public CutType onTrigger;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaneType sliceType;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool affectInactive;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float damage;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool skin;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cooldown;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int mask;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string tagFilter;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> targets;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transForm;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3[] enterPlane;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] exitPlane;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Collider colLider;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3[] slicePlanes;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool coolDownState;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RFSliceData sliceData;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 posEnter;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 posExit;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFSliceEvent sliceEvent;

	[Token(Token = "0x17000052")]
	public bool HasTargets
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x304C92C", Offset = "0x304C92C", VA = "0x304C92C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x304BC3C", Offset = "0x304BC3C", VA = "0x304BC3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x304BC40", Offset = "0x304BC40", VA = "0x304BC40")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x304BE44", Offset = "0x304BE44", VA = "0x304BE44")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x304BEF4", Offset = "0x304BEF4", VA = "0x304BEF4")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x304BE48", Offset = "0x304BE48", VA = "0x304BE48")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x304BEF8", Offset = "0x304BEF8", VA = "0x304BEF8")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x304C34C", Offset = "0x304C34C", VA = "0x304C34C")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x304C548", Offset = "0x304C548", VA = "0x304C548")]
	[IteratorStateMachine(typeof(<CooldownCor>d__31))]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x304C5D8", Offset = "0x304C5D8", VA = "0x304C5D8")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x304C450", Offset = "0x304C450", VA = "0x304C450")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x304C600", Offset = "0x304C600", VA = "0x304C600")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x304C1C0", Offset = "0x304C1C0", VA = "0x304C1C0")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x304C500", Offset = "0x304C500", VA = "0x304C500")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x304C0D8", Offset = "0x304C0D8", VA = "0x304C0D8")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x304C704", Offset = "0x304C704", VA = "0x304C704")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x304C5E4", Offset = "0x304C5E4", VA = "0x304C5E4")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x304C980", Offset = "0x304C980", VA = "0x304C980")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000099")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-bomb-component/")]
[AddComponentMenu("RayFire/Rayfire Bomb")]
public class RayfireBomb : MonoBehaviour
{
	[Token(Token = "0x200009A")]
	public enum RangeType
	{
		[Token(Token = "0x40003E9")]
		Spherical
	}

	[Token(Token = "0x200009B")]
	public enum FadeType
	{
		[Token(Token = "0x40003EB")]
		Linear = 0,
		[Token(Token = "0x40003EC")]
		Exponential = 1,
		[Token(Token = "0x40003ED")]
		ByCurve = 3,
		[Token(Token = "0x40003EE")]
		None = 2
	}

	[Serializable]
	[Token(Token = "0x200009C")]
	public class Projectile
	{
		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionPivot;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 positionClosest;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fade;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rb;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayfireRigid rigid;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion rotation;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RFShard shard;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x304E4D4", Offset = "0x304E4D4", VA = "0x304E4D4")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class <ExplodeCor>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x17000055")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000393")]
			[Address(RVA = "0x304EBC0", Offset = "0x304EBC0", VA = "0x304EBC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000056")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x304EC08", Offset = "0x304EC08", VA = "0x304EC08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x304CE50", Offset = "0x304CE50", VA = "0x304CE50")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x304EB0C", Offset = "0x304EB0C", VA = "0x304EB0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x304EB10", Offset = "0x304EB10", VA = "0x304EB10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x304EBC8", Offset = "0x304EBC8", VA = "0x304EBC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showGizmo;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RangeType rangeType;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeType fadeType;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int deletion;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int variation;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int chaos;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool forceByMass;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool affectInactive;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool affectKinematic;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float heightOffset;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool atStart;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool destroy;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool applyDamage;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damageValue;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve curve;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool play;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float volume;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip clip;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFExplosionEvent explosionEvent;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Vector3 bombPosition;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 explPosition;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public int mask;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public string tagFilter;

	[NonSerialized]
	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Projectile> projectiles;

	[NonSerialized]
	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<Projectile> deletionProjectiles;

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x304CB4C", Offset = "0x304CB4C", VA = "0x304CB4C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x304CBFC", Offset = "0x304CBFC", VA = "0x304CBFC")]
	private void Start()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x304CC74", Offset = "0x304CC74", VA = "0x304CC74")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x304CC30", Offset = "0x304CC30", VA = "0x304CC30")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x304CDE8", Offset = "0x304CDE8", VA = "0x304CDE8")]
	[IteratorStateMachine(typeof(<ExplodeCor>d__37))]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x304CCE0", Offset = "0x304CCE0", VA = "0x304CCE0")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x304DABC", Offset = "0x304DABC", VA = "0x304DABC")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x304CF1C", Offset = "0x304CF1C", VA = "0x304CF1C")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x304CB50", Offset = "0x304CB50", VA = "0x304CB50")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x304E24C", Offset = "0x304E24C", VA = "0x304E24C")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x304E268", Offset = "0x304E268", VA = "0x304E268")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x304CE78", Offset = "0x304CE78", VA = "0x304CE78")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x304DB78", Offset = "0x304DB78", VA = "0x304DB78")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x304DBAC", Offset = "0x304DBAC", VA = "0x304DBAC")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x304CF84", Offset = "0x304CF84", VA = "0x304CF84")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x304D120", Offset = "0x304D120", VA = "0x304D120")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x304D478", Offset = "0x304D478", VA = "0x304D478")]
	private void Activate()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x304D850", Offset = "0x304D850", VA = "0x304D850")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x304E4DC", Offset = "0x304E4DC", VA = "0x304E4DC")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x304E6B8", Offset = "0x304E6B8", VA = "0x304E6B8")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x304E7E8", Offset = "0x304E7E8", VA = "0x304E7E8")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x200009E")]
[AddComponentMenu("RayFire/Rayfire Cluster")]
[SelectionBase]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-cluster-component/")]
public class RayfireCluster : MonoBehaviour
{
	[Token(Token = "0x200009F")]
	public enum ClusterType
	{
		[Token(Token = "0x400040C")]
		ByPointCloud,
		[Token(Token = "0x400040D")]
		BySharedArea
	}

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	[Space(2f)]
	[Header("  Properties")]
	public ClusterType type;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(1f, 7f)]
	public int depth;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 100f)]
	public int seed;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 4f)]
	public int smoothPass;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("  By Point Cloud")]
	[Range(2f, 100f)]
	[Space(2f)]
	public int baseAmount;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(2f, 50f)]
	public int depthAmount;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Space(2f)]
	[Header("  By Shared Area")]
	[Range(2f, 8f)]
	public int minimumAmount;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(2f, 8f)]
	public int maximumAmount;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool showGizmo;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool colorPreview;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool scalePreview;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Color wireColor;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public float previewScale;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public List<RFCluster> allClusters;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFShard> allShards;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int clusterId;

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x304EC10", Offset = "0x304EC10", VA = "0x304EC10")]
	public void Extract()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x304EE74", Offset = "0x304EE74", VA = "0x304EE74")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x304EF28", Offset = "0x304EF28", VA = "0x304EF28")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x304F918", Offset = "0x304F918", VA = "0x304F918")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x3051200", Offset = "0x3051200", VA = "0x3051200")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x304F224", Offset = "0x304F224", VA = "0x304F224")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x3051FD0", Offset = "0x3051FD0", VA = "0x3051FD0")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x30525C8", Offset = "0x30525C8", VA = "0x30525C8")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x305081C", Offset = "0x305081C", VA = "0x305081C")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x3053018", Offset = "0x3053018", VA = "0x3053018")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x30505FC", Offset = "0x30505FC", VA = "0x30505FC")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x30539CC", Offset = "0x30539CC", VA = "0x30539CC")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x3052E14", Offset = "0x3052E14", VA = "0x3052E14")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x304F7E0", Offset = "0x304F7E0", VA = "0x304F7E0")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x305020C", Offset = "0x305020C", VA = "0x305020C")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x3051DC8", Offset = "0x3051DC8", VA = "0x3051DC8")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x3053AF4", Offset = "0x3053AF4", VA = "0x3053AF4")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x3052A5C", Offset = "0x3052A5C", VA = "0x3052A5C")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x3050440", Offset = "0x3050440", VA = "0x3050440")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x3053F14", Offset = "0x3053F14", VA = "0x3053F14")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x20000A2")]
public class RFCombineMesh
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> trianglesSubId;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<int>> triangles;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> vertices;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector2> uvs;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> tangents;

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x3054060", Offset = "0x3054060", VA = "0x3054060")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x3054214", Offset = "0x3054214", VA = "0x3054214")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x305493C", Offset = "0x305493C", VA = "0x305493C")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x3046B2C", Offset = "0x3046B2C", VA = "0x3046B2C")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x3054B04", Offset = "0x3054B04", VA = "0x3054B04")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x3055040", Offset = "0x3055040", VA = "0x3055040")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x305524C", Offset = "0x305524C", VA = "0x305524C")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x3055474", Offset = "0x3055474", VA = "0x3055474")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x20000A6")]
[AddComponentMenu("RayFire/Rayfire Combine")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-combine-component/")]
public class RayfireCombine : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	public enum CombType
	{
		[Token(Token = "0x4000432")]
		Children,
		[Token(Token = "0x4000433")]
		ObjectsList
	}

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombType type;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool meshFilters;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skinnedMeshes;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool particleSystems;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeThreshold;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexThreshold;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform transForm;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mFilter;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<bool> invertNormals;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Transform> transList;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<MeshFilter> mFilters;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SkinnedMeshRenderer> skinnedMeshRends;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ParticleSystemRenderer> particleRends;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Mesh> meshList;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<int>> matIdList;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<Material>> matList;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Material> allMaterials;

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x30557A4", Offset = "0x30557A4", VA = "0x30557A4")]
	public void Combine()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x3055868", Offset = "0x3055868", VA = "0x3055868")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x30572AC", Offset = "0x30572AC", VA = "0x30572AC")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x20000A8")]
[DisallowMultipleComponent]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-connectivity-component/")]
[AddComponentMenu("RayFire/Rayfire Connectivity")]
public class RayfireConnectivity : MonoBehaviour
{
	[Token(Token = "0x20000A9")]
	public enum RFConnInitType
	{
		[Token(Token = "0x4000458")]
		AtStart = 1,
		[Token(Token = "0x4000459")]
		ByMethod = 3,
		[Token(Token = "0x400045A")]
		ByIntegrity = 5
	}

	[Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class <ConnectivityCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x305C4FC", Offset = "0x305C4FC", VA = "0x305C4FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x305C544", Offset = "0x305C544", VA = "0x305C544", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x305C424", Offset = "0x305C424", VA = "0x305C424")]
		[DebuggerHidden]
		public <ConnectivityCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x305C44C", Offset = "0x305C44C", VA = "0x305C44C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x305C450", Offset = "0x305C450", VA = "0x305C450", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x305C504", Offset = "0x305C504", VA = "0x305C504", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class <ChildrenCor>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <checkChildren>5__2;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x305C600", Offset = "0x305C600", VA = "0x305C600", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x305C648", Offset = "0x305C648", VA = "0x305C648", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x305C54C", Offset = "0x305C54C", VA = "0x305C54C")]
		[DebuggerHidden]
		public <ChildrenCor>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x305C574", Offset = "0x305C574", VA = "0x305C574", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x305C578", Offset = "0x305C578", VA = "0x305C578", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x305C608", Offset = "0x305C608", VA = "0x305C608", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConnectivityType type;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expand;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minimumArea;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumSize;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int percentage;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int seed;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool clusterize;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool demolishable;

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public RFConnInitType startCollapse;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int collapseByIntegrity;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCollapse collapse;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFConnInitType startStress;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int stressByIntegrity;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFStress stress;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showConnections;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showNodes;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool showGizmo;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool showStress;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool checkConnectivity;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool connectivityCheckNeed;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFCluster cluster;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int initShardAmount;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int clsCount;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RayfireRigidRoot rigidRootHost;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RayfireRigid meshRootHost;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Collider triggerCollider;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int triggerDebris;

	[NonSerialized]
	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool childrenChanged;

	[NonSerialized]
	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool childrenCorState;

	[NonSerialized]
	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	private bool connectivityCorState;

	[NonSerialized]
	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	private bool corState;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFConnectivityEvent connectivityEvent;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public RFJointProperties joints;

	[Token(Token = "0x17000057")]
	public float AmountIntegrity
	{
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x30590A4", Offset = "0x30590A4", VA = "0x30590A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x30572D4", Offset = "0x30572D4", VA = "0x30572D4")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x30573DC", Offset = "0x30573DC", VA = "0x30573DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x30573E8", Offset = "0x30573E8", VA = "0x30573E8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x30575B4", Offset = "0x30575B4", VA = "0x30575B4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x3057858", Offset = "0x3057858", VA = "0x3057858")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x3057F10", Offset = "0x3057F10", VA = "0x3057F10")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x3057F94", Offset = "0x3057F94", VA = "0x3057F94")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x30580F4", Offset = "0x30580F4", VA = "0x30580F4")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x3057A20", Offset = "0x3057A20", VA = "0x3057A20")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x3057CB0", Offset = "0x3057CB0", VA = "0x3057CB0")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x3058940", Offset = "0x3058940", VA = "0x3058940")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x30581C8", Offset = "0x30581C8", VA = "0x30581C8")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x3058480", Offset = "0x3058480", VA = "0x3058480")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x3058A08", Offset = "0x3058A08", VA = "0x3058A08")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x305754C", Offset = "0x305754C", VA = "0x305754C")]
	[IteratorStateMachine(typeof(<ConnectivityCor>d__50))]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x3058D84", Offset = "0x3058D84", VA = "0x3058D84")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x3058F88", Offset = "0x3058F88", VA = "0x3058F88")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x3058E6C", Offset = "0x3058E6C", VA = "0x3058E6C")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x3059490", Offset = "0x3059490", VA = "0x3059490")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x30599B4", Offset = "0x30599B4", VA = "0x30599B4")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x3059110", Offset = "0x3059110", VA = "0x3059110")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x30592AC", Offset = "0x30592AC", VA = "0x30592AC")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x30596F4", Offset = "0x30596F4", VA = "0x30596F4")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x30597D0", Offset = "0x30597D0", VA = "0x30597D0")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x305A73C", Offset = "0x305A73C", VA = "0x305A73C")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x30574E4", Offset = "0x30574E4", VA = "0x30574E4")]
	[IteratorStateMachine(typeof(<ChildrenCor>d__61))]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x305A748", Offset = "0x305A748", VA = "0x305A748")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x305A9FC", Offset = "0x305A9FC", VA = "0x305A9FC")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x3057BB8", Offset = "0x3057BB8", VA = "0x3057BB8")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x305AA30", Offset = "0x305AA30", VA = "0x305AA30")]
	public void Fracture()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x305AA3C", Offset = "0x305AA3C", VA = "0x305AA3C")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x305AEEC", Offset = "0x305AEEC", VA = "0x305AEEC")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x305B358", Offset = "0x305B358", VA = "0x305B358")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x20000AC")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Debris")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-debris-component/")]
public class RayfireDebris : MonoBehaviour
{
	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Debris")]
	public bool onDemolition;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Main")]
	[Space(3f)]
	public GameObject debrisReference;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public Material debrisMaterial;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Space(3f)]
	[Header("  Properties")]
	public RFParticleEmission emission;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(3f)]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(3f)]
	public RFParticleNoise noise;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(3f)]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(3f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(3f)]
	public RFParticleRendering rendering;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Mesh> debrisMeshList;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 refScale;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireDebris> children;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x1700005C")]
	public bool HasChildren
	{
		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x305D498", Offset = "0x305D498", VA = "0x305D498")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x305C650", Offset = "0x305C650", VA = "0x305C650")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x305C84C", Offset = "0x305C84C", VA = "0x305C84C")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x305C920", Offset = "0x305C920", VA = "0x305C920")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x305CE8C", Offset = "0x305CE8C", VA = "0x305CE8C")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x305D2B8", Offset = "0x305D2B8", VA = "0x305D2B8")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x305CFC4", Offset = "0x305CFC4", VA = "0x305CFC4")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x305D4EC", Offset = "0x305D4EC", VA = "0x305D4EC")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x305C934", Offset = "0x305C934", VA = "0x305C934")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x305D760", Offset = "0x305D760", VA = "0x305D760")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x20000AE")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Dust")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-dust-component/")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Dust")]
	public bool onDemolition;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Main")]
	[Space(3f)]
	[Range(0.01f, 1f)]
	public float opacity;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(2f)]
	public Material dustMaterial;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public List<Material> dustMaterials;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("  Properties")]
	[Space(3f)]
	public RFParticleEmission emission;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(2f)]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(2f)]
	public RFParticleNoise noise;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(2f)]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(2f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(2f)]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<RayfireDust> children;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x1700005D")]
	public bool HasChildren
	{
		[Token(Token = "0x6000404")]
		[Address(RVA = "0x305E4AC", Offset = "0x305E4AC", VA = "0x305E4AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005E")]
	public bool HasMaterials
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x305DE94", Offset = "0x305DE94", VA = "0x305DE94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x305DA38", Offset = "0x305DA38", VA = "0x305DA38")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x305DBBC", Offset = "0x305DBBC", VA = "0x305DBBC")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x305DC90", Offset = "0x305DC90", VA = "0x305DC90")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x305DEE8", Offset = "0x305DEE8", VA = "0x305DEE8")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x305E2CC", Offset = "0x305E2CC", VA = "0x305E2CC")]
	public void Clean()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x305E000", Offset = "0x305E000", VA = "0x305E000")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x305E500", Offset = "0x305E500", VA = "0x305E500")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x305E680", Offset = "0x305E680", VA = "0x305E680")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x20000AF")]
[AddComponentMenu("RayFire/Rayfire Gun")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-gun-component/")]
public class RayfireGun : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	public enum ImpactType
	{
		[Token(Token = "0x40004AA")]
		AddExplosionForce,
		[Token(Token = "0x40004AB")]
		AddForceAtPosition
	}

	[Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class <StartShootCor>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <shootId>5__2;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x3060DAC", Offset = "0x3060DAC", VA = "0x3060DAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x3060DF4", Offset = "0x3060DF4", VA = "0x3060DF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x305E800", Offset = "0x305E800", VA = "0x305E800")]
		[DebuggerHidden]
		public <StartShootCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x3060CCC", Offset = "0x3060CCC", VA = "0x3060CCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x3060CD0", Offset = "0x3060CD0", VA = "0x3060CD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x3060DB4", Offset = "0x3060DB4", VA = "0x3060DB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class <BurstCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000062")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x3060EE8", Offset = "0x3060EE8", VA = "0x3060EE8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000063")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000423")]
			[Address(RVA = "0x3060F30", Offset = "0x3060F30", VA = "0x3060F30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x305F0C0", Offset = "0x305F0C0", VA = "0x305F0C0")]
		[DebuggerHidden]
		public <BurstCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x3060DFC", Offset = "0x3060DFC", VA = "0x3060DFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x3060E00", Offset = "0x3060E00", VA = "0x3060E00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x3060EF0", Offset = "0x3060EF0", VA = "0x3060EF0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AxisType axis;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int rounds;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rate;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ImpactType type;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float strength;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float radius;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float offset;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishCluster;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	public bool affectInactive;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	public bool rigid;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	public bool rigidRoot;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[FormerlySerializedAs("affectRigidBodies")]
	public bool rigidBody;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damage;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool debris;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool dust;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool flash;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFFlash Flash;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int mask;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool showRay;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool showHit;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool shooting;

	[Token(Token = "0x40004A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string untagged;

	[Token(Token = "0x40004A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFShotEvent shotEvent;

	[Token(Token = "0x40004A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Collider[] impactColliders;

	[Token(Token = "0x1700005F")]
	public Vector3 ShootVector
	{
		[Token(Token = "0x6000415")]
		[Address(RVA = "0x305E8A8", Offset = "0x305E8A8", VA = "0x305E8A8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x305E768", Offset = "0x305E768", VA = "0x305E768")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x305E798", Offset = "0x305E798", VA = "0x305E798")]
	[IteratorStateMachine(typeof(<StartShootCor>d__29))]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x305E828", Offset = "0x305E828", VA = "0x305E828")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x305E830", Offset = "0x305E830", VA = "0x305E830")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x305F028", Offset = "0x305F028", VA = "0x305F028")]
	public void Burst()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x305F058", Offset = "0x305F058", VA = "0x305F058")]
	[IteratorStateMachine(typeof(<BurstCor>d__33))]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x305EA84", Offset = "0x305EA84", VA = "0x305EA84")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x305F82C", Offset = "0x305F82C", VA = "0x305F82C")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x3060024", Offset = "0x3060024", VA = "0x3060024")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x30605A8", Offset = "0x30605A8", VA = "0x30605A8")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x305F5D4", Offset = "0x305F5D4", VA = "0x305F5D4")]
	private RayfireRigid ApplyDamage(RayfireRigid scr, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x305F0E8", Offset = "0x305F0E8", VA = "0x305F0E8")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x305F2BC", Offset = "0x305F2BC", VA = "0x305F2BC")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x305F448", Offset = "0x305F448", VA = "0x305F448")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x30607AC", Offset = "0x30607AC", VA = "0x30607AC")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x3060B68", Offset = "0x3060B68", VA = "0x3060B68")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x20000B3")]
[DisallowMultipleComponent]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-man-component/")]
[AddComponentMenu("RayFire/Rayfire Man")]
public class RayfireMan : MonoBehaviour
{
	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RayfireMan inst;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int buildMajor;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int buildMinor;

	[Token(Token = "0x40004B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setGravity;

	[Token(Token = "0x40004B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float multiplier;

	[Token(Token = "0x40004B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RigidbodyInterpolation interpolation;

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float colliderSize;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float colliderSizeStatic;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("collisionDetection")]
	public CollisionDetectionMode meshCollision;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CollisionDetectionMode clusterCollision;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minimumMass;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maximumMass;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterialPresets materialPresets;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject parent;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float globalSolidity;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timeQuota;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFManDemolition advancedDemolitionProperties;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFPoolingFragment fragments;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFPoolingParticles particles;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform transForm;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<string> layers;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFStorage storage;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxTimeThisFrame;

	[Token(Token = "0x17000064")]
	public static bool MaxAmountCheck
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x30617A4", Offset = "0x30617A4", VA = "0x30617A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x3060F38", Offset = "0x3060F38", VA = "0x3060F38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x3061178", Offset = "0x3061178", VA = "0x3061178")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x3061180", Offset = "0x3061180", VA = "0x3061180")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x3060F3C", Offset = "0x3060F3C", VA = "0x3060F3C")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x3061430", Offset = "0x3061430", VA = "0x3061430")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x3061464", Offset = "0x3061464", VA = "0x3061464")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3061184", Offset = "0x3061184", VA = "0x3061184")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x30614B4", Offset = "0x30614B4", VA = "0x30614B4")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x306164C", Offset = "0x306164C", VA = "0x306164C")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x3061534", Offset = "0x3061534", VA = "0x3061534")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x3061240", Offset = "0x3061240", VA = "0x3061240")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x3061370", Offset = "0x3061370", VA = "0x3061370")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x3061854", Offset = "0x3061854", VA = "0x3061854")]
	public void DestroyStorage()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x3061870", Offset = "0x3061870", VA = "0x3061870")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x3061A68", Offset = "0x3061A68", VA = "0x3061A68")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x3061B9C", Offset = "0x3061B9C", VA = "0x3061B9C")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x3061DD0", Offset = "0x3061DD0", VA = "0x3061DD0")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x3061E88", Offset = "0x3061E88", VA = "0x3061E88")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x3061C8C", Offset = "0x3061C8C", VA = "0x3061C8C")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x3061EE0", Offset = "0x3061EE0", VA = "0x3061EE0")]
	public RayfireMan()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B4")]
public class RFCache
{
	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<bool> act;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> pos;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Quaternion> rot;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform transform;

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x3062064", Offset = "0x3062064", VA = "0x3062064")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x20000B5")]
[SelectionBase]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Recorder")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-recorder-component/")]
public class RayfireRecorder : MonoBehaviour
{
	[Token(Token = "0x20000B6")]
	public enum AnimatorType
	{
		[Token(Token = "0x40004E6")]
		Disabled = 0,
		[Token(Token = "0x40004E7")]
		Record = 2,
		[Token(Token = "0x40004E8")]
		Play = 8
	}

	[Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class <RecordCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRecorder <>4__this;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044A")]
			[Address(RVA = "0x3063714", Offset = "0x3063714", VA = "0x3063714", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x306375C", Offset = "0x306375C", VA = "0x306375C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x3063228", Offset = "0x3063228", VA = "0x3063228")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x30632CC", Offset = "0x30632CC", VA = "0x30632CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x30632D0", Offset = "0x30632D0", VA = "0x30632D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x306371C", Offset = "0x306371C", VA = "0x306371C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimatorType mode;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool recordOnStart;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rate;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool reduceKeys;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float threshold;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool playOnStart;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip animationClip;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RuntimeAnimatorController controller;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool setToKinematic;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool recorder;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float recordedTime;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int stateNameHash;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string assetFolder;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string clipFolder;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stepTime;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Transform> tmList;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RFCache> cacheList;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> timeList;

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x3062280", Offset = "0x3062280", VA = "0x3062280")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x30625A8", Offset = "0x30625A8", VA = "0x30625A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x30625F8", Offset = "0x30625F8", VA = "0x30625F8")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x3062284", Offset = "0x3062284", VA = "0x3062284")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x3062904", Offset = "0x3062904", VA = "0x3062904")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x3062B90", Offset = "0x3062B90", VA = "0x3062B90")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x3063194", Offset = "0x3063194", VA = "0x3063194")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x306284C", Offset = "0x306284C", VA = "0x306284C")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x30631C0", Offset = "0x30631C0", VA = "0x30631C0")]
	[IteratorStateMachine(typeof(<RecordCor>d__30))]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x3063250", Offset = "0x3063250", VA = "0x3063250")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x30628B8", Offset = "0x30628B8", VA = "0x30628B8")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x3063258", Offset = "0x3063258", VA = "0x3063258")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x20000B8")]
[SelectionBase]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Restriction")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-restriction-component/")]
public class RayfireRestriction : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	public enum RFBoundActionType
	{
		[Token(Token = "0x40004F8")]
		Fade = 2,
		[Token(Token = "0x40004F9")]
		Reset = 4,
		[Token(Token = "0x40004FA")]
		PostDemolitionAction = 9
	}

	[Token(Token = "0x20000BA")]
	public enum RFDistanceType
	{
		[Token(Token = "0x40004FC")]
		InitializePosition = 0,
		[Token(Token = "0x40004FD")]
		TargetPosition = 2
	}

	[Token(Token = "0x20000BB")]
	public enum RFBoundTriggerType
	{
		[Token(Token = "0x40004FF")]
		Inside = 0,
		[Token(Token = "0x4000500")]
		Outside = 2
	}

	[Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class <RestrictionDistanceCor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <checkPosition>5__4;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x3064090", Offset = "0x3064090", VA = "0x3064090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x30640D8", Offset = "0x30640D8", VA = "0x30640D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x3063CB0", Offset = "0x3063CB0", VA = "0x3063CB0")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x3063D00", Offset = "0x3063D00", VA = "0x3063D00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x3063D04", Offset = "0x3063D04", VA = "0x3063D04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x3064098", Offset = "0x3064098", VA = "0x3064098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class <RestrictionTriggerCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <brokeState>5__4;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x3064434", Offset = "0x3064434", VA = "0x3064434", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x306447C", Offset = "0x306447C", VA = "0x306447C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x3063CD8", Offset = "0x3063CD8", VA = "0x3063CD8")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x30640E0", Offset = "0x30640E0", VA = "0x30640E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x30640E4", Offset = "0x30640E4", VA = "0x30640E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x306443C", Offset = "0x306443C", VA = "0x306443C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFBoundActionType breakAction;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float actionDelay;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float checkInterval;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public RFDistanceType position;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider Collider;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFBoundTriggerType region;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RayfireRigid rigid;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool broke;

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x3063764", Offset = "0x3063764", VA = "0x3063764")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x30637AC", Offset = "0x30637AC", VA = "0x30637AC")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x30637A4", Offset = "0x30637A4", VA = "0x30637A4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x30637F4", Offset = "0x30637F4", VA = "0x30637F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x3063AE8", Offset = "0x3063AE8", VA = "0x3063AE8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x3063AEC", Offset = "0x3063AEC", VA = "0x3063AEC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x30638C4", Offset = "0x30638C4", VA = "0x30638C4")]
	public void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x3063BC0", Offset = "0x3063BC0", VA = "0x3063BC0")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x3063AF0", Offset = "0x3063AF0", VA = "0x3063AF0")]
	[IteratorStateMachine(typeof(<RestrictionDistanceCor>d__22))]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x3063B58", Offset = "0x3063B58", VA = "0x3063B58")]
	[IteratorStateMachine(typeof(<RestrictionTriggerCor>d__23))]
	private IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x20000BE")]
[DisallowMultipleComponent]
[SelectionBase]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-component/")]
[AddComponentMenu("RayFire/Rayfire Rigid")]
public class RayfireRigid : MonoBehaviour
{
	[Token(Token = "0x20000BF")]
	public enum InitType
	{
		[Token(Token = "0x4000534")]
		ByMethod,
		[Token(Token = "0x4000535")]
		AtStart
	}

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectType objectType;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DemolitionType demolitionType;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFPhysic physics;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFActivation activation;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFLimitations limitations;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFDemolitionMesh meshDemolition;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFReferenceDemolition referenceDemolition;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFSurface materials;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFDamage damage;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFFade fading;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFReset reset;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool initialized;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool corState;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Mesh[] meshes;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3[] pivots;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMesh[] rfMeshes;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFDictionary> subIds;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RayfireRigid> fragments;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion cacheRotation;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform rootChild;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform rootParent;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RayfireDebris> debrisList;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RayfireDust> dustList;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RayfireRestriction restriction;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public RayfireSound sound;

	[NonSerialized]
	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RayfireRigid meshRoot;

	[NonSerialized]
	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RayfireRigidRoot rigidRoot;

	[NonSerialized]
	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<Transform> particleList;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RFDemolitionEvent demolitionEvent;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public RFRestrictionEvent restrictionEvent;

	[Token(Token = "0x1700006B")]
	public bool HasFragments
	{
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x3060758", Offset = "0x3060758", VA = "0x3060758")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public bool HasMeshes
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x3067CF8", Offset = "0x3067CF8", VA = "0x3067CF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006D")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x3067D18", Offset = "0x3067D18", VA = "0x3067D18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x3067D38", Offset = "0x3067D38", VA = "0x3067D38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x3067D8C", Offset = "0x3067D8C", VA = "0x3067D8C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasSlices
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x3067874", Offset = "0x3067874", VA = "0x3067874")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000071")]
	public bool IsCluster
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x3067DE0", Offset = "0x3067DE0", VA = "0x3067DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	public bool Visible
	{
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x3066998", Offset = "0x3066998", VA = "0x3066998")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x3067DF4", Offset = "0x3067DF4", VA = "0x3067DF4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x3064484", Offset = "0x3064484", VA = "0x3064484")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x3064548", Offset = "0x3064548", VA = "0x3064548")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x30645A0", Offset = "0x30645A0", VA = "0x30645A0")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x306507C", Offset = "0x306507C", VA = "0x306507C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x30650C4", Offset = "0x30650C4", VA = "0x30650C4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x306510C", Offset = "0x306510C", VA = "0x306510C")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x30652D4", Offset = "0x30652D4", VA = "0x30652D4")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x306476C", Offset = "0x306476C", VA = "0x306476C")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x3064C9C", Offset = "0x3064C9C", VA = "0x3064C9C")]
	public void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x30651B4", Offset = "0x30651B4", VA = "0x30651B4")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x3064994", Offset = "0x3064994", VA = "0x3064994")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x306578C", Offset = "0x306578C", VA = "0x306578C")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x3065978", Offset = "0x3065978", VA = "0x3065978")]
	private void AddMeshRootRigid(Transform tm)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x3065F2C", Offset = "0x3065F2C", VA = "0x3065F2C")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x306537C", Offset = "0x306537C", VA = "0x306537C")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x3064F44", Offset = "0x3064F44", VA = "0x3064F44")]
	public void SetObjectType()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x3064E3C", Offset = "0x3064E3C", VA = "0x3064E3C")]
	public void Default()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x30662D0", Offset = "0x30662D0", VA = "0x30662D0")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x3064F80", Offset = "0x3064F80", VA = "0x3064F80")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x3066478", Offset = "0x3066478", VA = "0x3066478")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x30644B0", Offset = "0x30644B0", VA = "0x30644B0")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x306655C", Offset = "0x306655C", VA = "0x306655C", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x3066650", Offset = "0x3066650", VA = "0x3066650", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x3066770", Offset = "0x3066770", VA = "0x3066770")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x30668C0", Offset = "0x30668C0", VA = "0x30668C0", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x3066A64", Offset = "0x3066A64", VA = "0x3066A64")]
	public void Demolish()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x3066028", Offset = "0x3066028", VA = "0x3066028")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x306732C", Offset = "0x306732C", VA = "0x306732C")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x306747C", Offset = "0x306747C", VA = "0x306747C")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x30674F8", Offset = "0x30674F8", VA = "0x30674F8")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x30675BC", Offset = "0x30675BC", VA = "0x30675BC")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x3067648", Offset = "0x3067648", VA = "0x3067648")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x30678D4", Offset = "0x30678D4", VA = "0x30678D4")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x3067908", Offset = "0x3067908", VA = "0x3067908")]
	[ContextMenu("SaveInitTransform")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x3060750", Offset = "0x3060750", VA = "0x3060750")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f, [Optional] Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x306049C", Offset = "0x306049C", VA = "0x306049C")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x3067AE8", Offset = "0x3067AE8", VA = "0x3067AE8")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x3067B90", Offset = "0x3067B90", VA = "0x3067B90")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x3067B98", Offset = "0x3067B98", VA = "0x3067B98")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x3067BF0", Offset = "0x3067BF0", VA = "0x3067BF0")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x3067C48", Offset = "0x3067C48", VA = "0x3067C48")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x3067CA0", Offset = "0x3067CA0", VA = "0x3067CA0")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x3067E78", Offset = "0x3067E78", VA = "0x3067E78")]
	public RayfireRigid()
	{
	}
}
[Serializable]
[Token(Token = "0x20000C0")]
public class RFRigidRootDemolition
{
	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(2f)]
	public RFLimitations limitations;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x3068120", Offset = "0x3068120", VA = "0x3068120")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x20000C1")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-root-component/")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Rigid Root")]
[DisallowMultipleComponent]
public class RayfireRigidRoot : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	public enum InitType
	{
		[Token(Token = "0x4000559")]
		ByMethod,
		[Token(Token = "0x400055A")]
		AtStart
	}

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFPhysic physics;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFActivation activation;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFRigidRootDemolition demolition;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFFade fading;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFReset reset;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform tm;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireSound sound;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> meshRoots;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool initialized;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool cached;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float sizeBox;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float sizeSum;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Collider> collidersList;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<RFShard> meshRootShards;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<RFShard> rigidRootShards;

	[NonSerialized]
	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<RFCluster> clusters;

	[NonSerialized]
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFShard> inactiveShards;

	[NonSerialized]
	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFShard> offsetFadeShards;

	[NonSerialized]
	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFShard> destroyShards;

	[NonSerialized]
	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFShard> meshRigidShards;

	[NonSerialized]
	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Transform> parentList;

	[NonSerialized]
	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RayfireDebris> debrisList;

	[NonSerialized]
	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<RayfireDust> dustList;

	[NonSerialized]
	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RayfireUnyielding> unyList;

	[NonSerialized]
	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Transform> particleList;

	[NonSerialized]
	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool corState;

	[NonSerialized]
	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public HashSet<Collider> collidersHash;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string strRoot;

	[Token(Token = "0x17000074")]
	public bool HasClusters
	{
		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x306B548", Offset = "0x306B548", VA = "0x306B548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000075")]
	public bool HasDebris
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x306B59C", Offset = "0x306B59C", VA = "0x306B59C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000076")]
	public bool HasDust
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x306B5F0", Offset = "0x306B5F0", VA = "0x306B5F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000077")]
	public bool HasUny
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x306AF08", Offset = "0x306AF08", VA = "0x306AF08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x30681B8", Offset = "0x30681B8", VA = "0x30681B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x30682CC", Offset = "0x30682CC", VA = "0x30682CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x30682F8", Offset = "0x30682F8", VA = "0x30682F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x30681E8", Offset = "0x30681E8", VA = "0x30681E8")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x3068778", Offset = "0x3068778", VA = "0x3068778")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x30689C0", Offset = "0x30689C0", VA = "0x30689C0")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x30689C8", Offset = "0x30689C8", VA = "0x30689C8")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x3068B50", Offset = "0x3068B50", VA = "0x3068B50")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x3068438", Offset = "0x3068438", VA = "0x3068438")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x3068F68", Offset = "0x3068F68", VA = "0x3068F68")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x3069D98", Offset = "0x3069D98", VA = "0x3069D98")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x3069000", Offset = "0x3069000", VA = "0x3069000")]
	private void SetShards()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x306A2C0", Offset = "0x306A2C0", VA = "0x306A2C0")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x306A568", Offset = "0x306A568", VA = "0x306A568")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x306A6CC", Offset = "0x306A6CC", VA = "0x306A6CC")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x306A828", Offset = "0x306A828", VA = "0x306A828")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x306A968", Offset = "0x306A968", VA = "0x306A968")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x3069970", Offset = "0x3069970", VA = "0x3069970")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x3069E78", Offset = "0x3069E78", VA = "0x3069E78")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x306A058", Offset = "0x306A058", VA = "0x306A058")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x3069B6C", Offset = "0x3069B6C", VA = "0x3069B6C")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x3068340", Offset = "0x3068340", VA = "0x3068340")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x306B40C", Offset = "0x306B40C", VA = "0x306B40C")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x306B4CC", Offset = "0x306B4CC", VA = "0x306B4CC")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x306AA68", Offset = "0x306AA68", VA = "0x306AA68")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x306B644", Offset = "0x306B644", VA = "0x306B644")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x306B650", Offset = "0x306B650", VA = "0x306B650")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x20000C3")]
[AddComponentMenu("RayFire/Rayfire Shatter")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-shatter-component/")]
public class RayfireShatter : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	public enum FragLastMode
	{
		[Token(Token = "0x4000585")]
		New,
		[Token(Token = "0x4000586")]
		ToLast
	}

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FragType type;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFVoronoi voronoi;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSplinters splinters;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSplinters slabs;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRadial radial;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCustom custom;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMirrored mirrored;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFSlice slice;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFBricks bricks;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFVoxels voxels;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFTets tets;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public FragmentMode mode;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSurface material;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RFShatterCluster clusters;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFShatterAdvanced advanced;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMeshExport export;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool showCenter;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 centerPosition;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion centerDirection;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Mesh[] meshes;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3[] pivots;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Transform> rootChildList;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<GameObject> fragmentsAll;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<GameObject> fragmentsLast;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<RFDictionary> origSubMeshIdsRF;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Material[] materials;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int shatterMode;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool colorPreview;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool scalePreview;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float previewScale;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float size;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float rescaleFix;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Vector3 originalScale;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[HideInInspector]
	public bool resetState;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float minSize;

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x306B80C", Offset = "0x306B80C", VA = "0x306B80C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x306B988", Offset = "0x306B988", VA = "0x306B988")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x306BA28", Offset = "0x306BA28", VA = "0x306BA28")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x306BDFC", Offset = "0x306BDFC", VA = "0x306BDFC")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x306C058", Offset = "0x306C058", VA = "0x306C058")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x306C300", Offset = "0x306C300", VA = "0x306C300")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x306C478", Offset = "0x306C478", VA = "0x306C478")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x306C94C", Offset = "0x306C94C", VA = "0x306C94C")]
	private List<GameObject> CreateFragments([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x306D674", Offset = "0x306D674", VA = "0x306D674")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x306D9D8", Offset = "0x306D9D8", VA = "0x306D9D8")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x306B810", Offset = "0x306B810", VA = "0x306B810")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x306C670", Offset = "0x306C670", VA = "0x306C670")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x306DB80", Offset = "0x306DB80", VA = "0x306DB80")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x3065D0C", Offset = "0x3065D0C", VA = "0x3065D0C")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x306DE30", Offset = "0x306DE30", VA = "0x306DE30")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x306D2F0", Offset = "0x306D2F0", VA = "0x306D2F0")]
	private void SizeLimitation()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x306D474", Offset = "0x306D474", VA = "0x306D474")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x306D564", Offset = "0x306D564", VA = "0x306D564")]
	private void TriangleLimitation()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x306E078", Offset = "0x306E078", VA = "0x306E078")]
	private void LimitationFragment(int ind)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x306E3B8", Offset = "0x306E3B8", VA = "0x306E3B8")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x20000C5")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-snapshot-component/")]
[AddComponentMenu("RayFire/Rayfire Snapshot")]
[DisallowMultipleComponent]
[SelectionBase]
public class RayfireSnapshot : MonoBehaviour
{
	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string assetName;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool compress;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEngine.Object snapshotAsset;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeFilter;

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x306E7D8", Offset = "0x306E7D8", VA = "0x306E7D8")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x306E804", Offset = "0x306E804", VA = "0x306E804")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x20000C6")]
[SelectionBase]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-sound-component/")]
[AddComponentMenu("RayFire/Rayfire Sound")]
public class RayfireSound : MonoBehaviour
{
	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float baseVolume;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeVolume;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFSound initialization;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSound activation;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSound demolition;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFSound collision;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float relativeVelocity;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float lastCollision;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float minimumSize;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float cameraDistance;

	[NonSerialized]
	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RayfireRigidRoot rigidRoot;

	[NonSerialized]
	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x306E80C", Offset = "0x306E80C", VA = "0x306E80C")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x306E83C", Offset = "0x306E83C", VA = "0x306E83C")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x306E840", Offset = "0x306E840", VA = "0x306E840")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x306E994", Offset = "0x306E994", VA = "0x306E994")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x306EEB0", Offset = "0x306EEB0", VA = "0x306EEB0")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x306EF80", Offset = "0x306EF80", VA = "0x306EF80")]
	private void CreateSource(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x306F1D4", Offset = "0x306F1D4", VA = "0x306F1D4")]
	public void OnCollisionEnter(Collision coll)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x306F1D8", Offset = "0x306F1D8", VA = "0x306F1D8")]
	private void CollisionSound(Collision coll)
	{
	}
}
[Token(Token = "0x20000C7")]
[AddComponentMenu("RayFire/Rayfire Unyielding")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-unyielding-component/")]
public class RayfireUnyielding : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	public enum UnySimType
	{
		[Token(Token = "0x40005A3")]
		Original = 1,
		[Token(Token = "0x40005A4")]
		Inactive,
		[Token(Token = "0x40005A5")]
		Kinematic
	}

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool unyielding;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activatable;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UnySimType simulationType;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 centerPosition;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RayfireRigid rigidHost;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RFShard> shardList;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool showGizmo;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool showCenter;

	[Token(Token = "0x17000078")]
	private bool HasRigids
	{
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x3070A64", Offset = "0x3070A64", VA = "0x3070A64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000079")]
	private bool HasShards
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x3070AB8", Offset = "0x3070AB8", VA = "0x3070AB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007A")]
	public Vector3 Extents
	{
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x306F9B8", Offset = "0x306F9B8", VA = "0x306F9B8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x306F410", Offset = "0x306F410", VA = "0x306F410")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x306F4E8", Offset = "0x306F4E8", VA = "0x306F4E8")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x306F858", Offset = "0x306F858", VA = "0x306F858")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x306FA5C", Offset = "0x306FA5C", VA = "0x306FA5C")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x3065E6C", Offset = "0x3065E6C", VA = "0x3065E6C")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x306FA80", Offset = "0x306FA80", VA = "0x306FA80")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x306FB7C", Offset = "0x306FB7C", VA = "0x306FB7C")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x306FF58", Offset = "0x306FF58", VA = "0x306FF58")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x306FE78", Offset = "0x306FE78", VA = "0x306FE78")]
	public static void SetMeshRootUnyState(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x3070074", Offset = "0x3070074", VA = "0x3070074")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x3070268", Offset = "0x3070268", VA = "0x3070268")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x306620C", Offset = "0x306620C", VA = "0x306620C")]
	public static void ResetMeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x3066C60", Offset = "0x3066C60", VA = "0x3066C60")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x30704EC", Offset = "0x30704EC", VA = "0x30704EC")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x3070558", Offset = "0x3070558", VA = "0x3070558")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x306AF5C", Offset = "0x306AF5C", VA = "0x306AF5C")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x306B324", Offset = "0x306B324", VA = "0x306B324")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x30706B8", Offset = "0x30706B8", VA = "0x30706B8")]
	public void Activate()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x3070B0C", Offset = "0x3070B0C", VA = "0x3070B0C")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x20000C9")]
[AddComponentMenu("RayFire/Rayfire Vortex")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-vortex-component/")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000CA")]
	[CompilerGenerated]
	private sealed class <VortexForceCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x3071F5C", Offset = "0x3071F5C", VA = "0x3071F5C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x3071FA4", Offset = "0x3071FA4", VA = "0x3071FA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x3070C1C", Offset = "0x3070C1C", VA = "0x3070C1C")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x3071E4C", Offset = "0x3071E4C", VA = "0x3071E4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x3071E50", Offset = "0x3071E50", VA = "0x3071E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x3071F64", Offset = "0x3071F64", VA = "0x3071F64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class <SetCollidersCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x30720D0", Offset = "0x30720D0", VA = "0x30720D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x3072118", Offset = "0x3072118", VA = "0x3072118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x3070CAC", Offset = "0x3070CAC", VA = "0x3070CAC")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x3071FAC", Offset = "0x3071FAC", VA = "0x3071FAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x3071FB0", Offset = "0x3071FB0", VA = "0x3071FB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x30720D8", Offset = "0x30720D8", VA = "0x30720D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 bot;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 top;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 normal;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 direction;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 rbPos;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 linePoint;

	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 vectorUp;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 centerOutVector;

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 vectorCenter;

	[Token(Token = "0x40005B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 perpend;

	[Token(Token = "0x40005B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 vectorSwirl;

	[Token(Token = "0x40005B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 forceVector;

	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float distancePerpend;

	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float distanceBottom;

	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float upRateNow;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float localRadius;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float upRateOwn;

	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float centerRateOwn;

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float centerRateNow;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float upRateDif;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float centerRateDif;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float maxRadius;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float axisDistance;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Plane bottomPlane;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float torqueVal;

	[Token(Token = "0x40005C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool topHandle;

	[Token(Token = "0x40005C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 topAnchor;

	[Token(Token = "0x40005C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 bottomAnchor;

	[Token(Token = "0x40005C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool showGizmo;

	[Token(Token = "0x40005C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float topRadius;

	[Token(Token = "0x40005C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float bottomRadius;

	[Token(Token = "0x40005C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float eye;

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool forceByMass;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float stiffness;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float swirlStrength;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool enableTorque;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float torqueStrength;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float torqueVariation;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool enableHeightBias;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float biasSpeed;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float biasSpread;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int seed;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int circles;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int mask;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public string tagFilter;

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x3070B34", Offset = "0x3070B34", VA = "0x3070B34")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x3070B38", Offset = "0x3070B38", VA = "0x3070B38")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x3070BB4", Offset = "0x3070BB4", VA = "0x3070BB4")]
	[IteratorStateMachine(typeof(<VortexForceCor>d__50))]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x3070C44", Offset = "0x3070C44", VA = "0x3070C44")]
	[IteratorStateMachine(typeof(<SetCollidersCor>d__51))]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x3070CD4", Offset = "0x3070CD4", VA = "0x3070CD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x3070D0C", Offset = "0x3070D0C", VA = "0x3070D0C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x3070E00", Offset = "0x3070E00", VA = "0x3070E00")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x3070F04", Offset = "0x3070F04", VA = "0x3070F04")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x307112C", Offset = "0x307112C", VA = "0x307112C")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x30717F4", Offset = "0x30717F4", VA = "0x30717F4")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x30719F8", Offset = "0x30719F8", VA = "0x30719F8")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x3071B2C", Offset = "0x3071B2C", VA = "0x3071B2C")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x3071C58", Offset = "0x3071C58", VA = "0x3071C58")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x3071928", Offset = "0x3071928", VA = "0x3071928")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x3071D38", Offset = "0x3071D38", VA = "0x3071D38")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x20000CC")]
[AddComponentMenu("RayFire/Rayfire Wind")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-wind-component/")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class <WindForceCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireWind <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600051E")]
			[Address(RVA = "0x3072F34", Offset = "0x3072F34", VA = "0x3072F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000520")]
			[Address(RVA = "0x3072F7C", Offset = "0x3072F7C", VA = "0x3072F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x3072208", Offset = "0x3072208", VA = "0x3072208")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x3072E74", Offset = "0x3072E74", VA = "0x3072E74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x3072E78", Offset = "0x3072E78", VA = "0x3072E78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x3072F3C", Offset = "0x3072F3C", VA = "0x3072F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 gizmoSize;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showGizmo;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float globalScale;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lengthScale;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float widthScale;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speed;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showNoise;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minimum;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maximum;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float torque;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceByMass;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float divergency;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float turbulence;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float previewDensity;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float previewSize;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int mask;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform transForm;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider[] colliders;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 halfExtents;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 center;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float offset;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x6000508")]
	[Address(RVA = "0x3072120", Offset = "0x3072120", VA = "0x3072120")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x3072124", Offset = "0x3072124", VA = "0x3072124")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x30721A0", Offset = "0x30721A0", VA = "0x30721A0")]
	[IteratorStateMachine(typeof(<WindForceCor>d__25))]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x3072230", Offset = "0x3072230", VA = "0x3072230")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x3072250", Offset = "0x3072250", VA = "0x3072250")]
	private void Reset()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x307225C", Offset = "0x307225C", VA = "0x307225C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x3072420", Offset = "0x3072420", VA = "0x3072420")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x3072474", Offset = "0x3072474", VA = "0x3072474")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x307269C", Offset = "0x307269C", VA = "0x307269C")]
	private void SetForce()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x30729EC", Offset = "0x30729EC", VA = "0x30729EC")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x3072A40", Offset = "0x3072A40", VA = "0x3072A40")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x3072B90", Offset = "0x3072B90", VA = "0x3072B90")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x307299C", Offset = "0x307299C", VA = "0x307299C")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x3072CC8", Offset = "0x3072CC8", VA = "0x3072CC8")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x3072D0C", Offset = "0x3072D0C", VA = "0x3072D0C")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x3072B5C", Offset = "0x3072B5C", VA = "0x3072B5C")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x30729C4", Offset = "0x30729C4", VA = "0x30729C4")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x3072954", Offset = "0x3072954", VA = "0x3072954")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x3072D88", Offset = "0x3072D88", VA = "0x3072D88")]
	public RayfireWind()
	{
	}
}
