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
	[Address(RVA = "0x30988E4", Offset = "0x30988E4", VA = "0x30988E4")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x3098924", Offset = "0x3098924", VA = "0x3098924")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x3098CB4", Offset = "0x3098CB4", VA = "0x3098CB4")]
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
	[Address(RVA = "0x3098D24", Offset = "0x3098D24", VA = "0x3098D24")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x3098D88", Offset = "0x3098D88", VA = "0x3098D88")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x30991BC", Offset = "0x30991BC", VA = "0x30991BC")]
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
	[Address(RVA = "0x309922C", Offset = "0x309922C", VA = "0x309922C")]
	public void ChangeCurrentAmount(int am)
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x309924C", Offset = "0x309924C", VA = "0x309924C")]
	public void AmountWarning()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x30992B4", Offset = "0x30992B4", VA = "0x30992B4")]
	public void ResetCurrentAmount()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x30992BC", Offset = "0x30992BC", VA = "0x30992BC")]
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
		[Address(RVA = "0x309935C", Offset = "0x309935C", VA = "0x309935C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x30992DC", Offset = "0x30992DC", VA = "0x30992DC")]
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
	[Address(RVA = "0x309940C", Offset = "0x309940C", VA = "0x309940C")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x30998D0", Offset = "0x30998D0", VA = "0x30998D0")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3099BBC", Offset = "0x3099BBC", VA = "0x3099BBC")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3099C6C", Offset = "0x3099C6C", VA = "0x3099C6C")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3099D1C", Offset = "0x3099D1C", VA = "0x3099D1C")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3099DD0", Offset = "0x3099DD0", VA = "0x3099DD0")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3099E80", Offset = "0x3099E80", VA = "0x3099E80")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3099F38", Offset = "0x3099F38", VA = "0x3099F38")]
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
			[Address(RVA = "0x309A8E0", Offset = "0x309A8E0", VA = "0x309A8E0", Slot = "4")]
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
			[Address(RVA = "0x309A928", Offset = "0x309A928", VA = "0x309A928", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x309A70C", Offset = "0x309A70C", VA = "0x309A70C")]
		[DebuggerHidden]
		public <StartPoolingCor>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x309A734", Offset = "0x309A734", VA = "0x309A734", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x309A738", Offset = "0x309A738", VA = "0x309A738", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x309A8E8", Offset = "0x309A8E8", VA = "0x309A8E8", Slot = "8")]
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
	[Address(RVA = "0x309A1B0", Offset = "0x309A1B0", VA = "0x309A1B0")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x309A248", Offset = "0x309A248", VA = "0x309A248")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x309A358", Offset = "0x309A358", VA = "0x309A358")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x309A468", Offset = "0x309A468", VA = "0x309A468")]
	public ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x309A528", Offset = "0x309A528", VA = "0x309A528")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x309A5E4", Offset = "0x309A5E4", VA = "0x309A5E4")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x309A698", Offset = "0x309A698", VA = "0x309A698")]
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
			[Address(RVA = "0x309B170", Offset = "0x309B170", VA = "0x309B170", Slot = "4")]
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
			[Address(RVA = "0x309B1B8", Offset = "0x309B1B8", VA = "0x309B1B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x309AFA0", Offset = "0x309AFA0", VA = "0x309AFA0")]
		[DebuggerHidden]
		public <StartPoolingCor>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x309AFC8", Offset = "0x309AFC8", VA = "0x309AFC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x309AFCC", Offset = "0x309AFCC", VA = "0x309AFCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x309B178", Offset = "0x309B178", VA = "0x309B178", Slot = "8")]
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
	[Address(RVA = "0x309A930", Offset = "0x309A930", VA = "0x309A930")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x309A9C8", Offset = "0x309A9C8", VA = "0x309A9C8")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x309AAD8", Offset = "0x309AAD8", VA = "0x309AAD8")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x309ABD4", Offset = "0x309ABD4", VA = "0x309ABD4")]
	public RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x309ADBC", Offset = "0x309ADBC", VA = "0x309ADBC")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x309AE78", Offset = "0x309AE78", VA = "0x309AE78")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x309AF2C", Offset = "0x309AF2C", VA = "0x309AF2C")]
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
			[Address(RVA = "0x309B818", Offset = "0x309B818", VA = "0x309B818", Slot = "4")]
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
			[Address(RVA = "0x309B860", Offset = "0x309B860", VA = "0x309B860", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x309B3DC", Offset = "0x309B3DC", VA = "0x309B3DC")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x309B608", Offset = "0x309B608", VA = "0x309B608", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x309B60C", Offset = "0x309B60C", VA = "0x309B60C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x309B820", Offset = "0x309B820", VA = "0x309B820", Slot = "8")]
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
	[Address(RVA = "0x309B1C0", Offset = "0x309B1C0", VA = "0x309B1C0")]
	public RFStorage()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x309B248", Offset = "0x309B248", VA = "0x309B248")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x309B374", Offset = "0x309B374", VA = "0x309B374")]
	[IteratorStateMachine(typeof(<StorageCor>d__6))]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x309B404", Offset = "0x309B404", VA = "0x309B404")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x309B4C4", Offset = "0x309B4C4", VA = "0x309B4C4")]
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
	[Address(RVA = "0x309B868", Offset = "0x309B868", VA = "0x309B868")]
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
	[Address(RVA = "0x309B870", Offset = "0x309B870", VA = "0x309B870")]
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
	[Address(RVA = "0x309BA28", Offset = "0x309BA28", VA = "0x309BA28")]
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
	[Address(RVA = "0x309BB40", Offset = "0x309BB40", VA = "0x309BB40")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x309BB88", Offset = "0x309BB88", VA = "0x309BB88")]
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
		[Address(RVA = "0x309BC38", Offset = "0x309BC38", VA = "0x309BC38")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x309BBE4", Offset = "0x309BBE4", VA = "0x309BBE4")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x309BC04", Offset = "0x309BC04", VA = "0x309BC04")]
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
		[Address(RVA = "0x309BCC0", Offset = "0x309BCC0", VA = "0x309BCC0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x309BC60", Offset = "0x309BC60", VA = "0x309BC60")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x309BC8C", Offset = "0x309BC8C", VA = "0x309BC8C")]
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
	[Address(RVA = "0x309BCE8", Offset = "0x309BCE8", VA = "0x309BCE8")]
	public RFRadial()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x309BD2C", Offset = "0x309BD2C", VA = "0x309BD2C")]
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
	[Address(RVA = "0x309BD90", Offset = "0x309BD90", VA = "0x309BD90")]
	public RFSlice()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x309BDB0", Offset = "0x309BDB0", VA = "0x309BDB0")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x309BDEC", Offset = "0x309BDEC", VA = "0x309BDEC")]
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
	[Address(RVA = "0x309BE38", Offset = "0x309BE38", VA = "0x309BE38")]
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
	[Address(RVA = "0x309BE8C", Offset = "0x309BE8C", VA = "0x309BE8C")]
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
	[Address(RVA = "0x309BEAC", Offset = "0x309BEAC", VA = "0x309BEAC")]
	public RFTets()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x309BED8", Offset = "0x309BED8", VA = "0x309BED8")]
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
		[Address(RVA = "0x309C3C4", Offset = "0x309C3C4", VA = "0x309C3C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x309F08C", Offset = "0x309F08C", VA = "0x309F08C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x309F124", Offset = "0x309F124", VA = "0x309F124")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x309BF14", Offset = "0x309BF14", VA = "0x309BF14")]
	public RFCluster()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x309C000", Offset = "0x309C000", VA = "0x309C000")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x309C418", Offset = "0x309C418", VA = "0x309C418", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x309C518", Offset = "0x309C518", VA = "0x309C518")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x309C56C", Offset = "0x309C56C", VA = "0x309C56C")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x309C7A8", Offset = "0x309C7A8", VA = "0x309C7A8")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x309C99C", Offset = "0x309C99C", VA = "0x309C99C")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x309D288", Offset = "0x309D288", VA = "0x309D288")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x309CFC0", Offset = "0x309CFC0", VA = "0x309CFC0")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x309D8D0", Offset = "0x309D8D0", VA = "0x309D8D0")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x309D160", Offset = "0x309D160", VA = "0x309D160")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x309DAA8", Offset = "0x309DAA8", VA = "0x309DAA8")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x309E1D0", Offset = "0x309E1D0", VA = "0x309E1D0")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x309DCA8", Offset = "0x309DCA8", VA = "0x309DCA8")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x309E464", Offset = "0x309E464", VA = "0x309E464")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x309E864", Offset = "0x309E864", VA = "0x309E864")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x309D9C0", Offset = "0x309D9C0", VA = "0x309D9C0")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x309ED10", Offset = "0x309ED10", VA = "0x309ED10")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x309D824", Offset = "0x309D824", VA = "0x309D824")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x309EE84", Offset = "0x309EE84", VA = "0x309EE84")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x309EF6C", Offset = "0x309EF6C", VA = "0x309EF6C")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x309F1CC", Offset = "0x309F1CC", VA = "0x309F1CC")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x309F384", Offset = "0x309F384", VA = "0x309F384")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x309F4CC", Offset = "0x309F4CC", VA = "0x309F4CC")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x309F814", Offset = "0x309F814", VA = "0x309F814")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x309FBDC", Offset = "0x309FBDC", VA = "0x309FBDC")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x309FD00", Offset = "0x309FD00", VA = "0x309FD00")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x30A0710", Offset = "0x30A0710", VA = "0x30A0710")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x30A0AEC", Offset = "0x30A0AEC", VA = "0x30A0AEC")]
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
		[Address(RVA = "0x30A0B98", Offset = "0x30A0B98", VA = "0x30A0B98")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x30A0C34", Offset = "0x30A0C34", VA = "0x30A0C34")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionMeshRoot LocalEventMeshRoot
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x30A0CD0", Offset = "0x30A0CD0", VA = "0x30A0CD0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x30A0D6C", Offset = "0x30A0D6C", VA = "0x30A0D6C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x30A0E08", Offset = "0x30A0E08", VA = "0x30A0E08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0x30A0EA4", Offset = "0x30A0EA4", VA = "0x30A0EA4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x30A0F40", Offset = "0x30A0F40", VA = "0x30A0F40")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x30A0F5C", Offset = "0x30A0F5C", VA = "0x30A0F5C")]
	public void InvokeLocalEventMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x30A0F78", Offset = "0x30A0F78", VA = "0x30A0F78")]
	public void InvokeLocalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x30A0F94", Offset = "0x30A0F94", VA = "0x30A0F94")]
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
		[Address(RVA = "0x30A13F8", Offset = "0x30A13F8", VA = "0x30A13F8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x30A14B0", Offset = "0x30A14B0", VA = "0x30A14B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x30A1568", Offset = "0x30A1568", VA = "0x30A1568")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x30A15D4", Offset = "0x30A15D4", VA = "0x30A15D4")]
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
		[Address(RVA = "0x30A15DC", Offset = "0x30A15DC", VA = "0x30A15DC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x30A1694", Offset = "0x30A1694", VA = "0x30A1694")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x30A174C", Offset = "0x30A174C", VA = "0x30A174C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x30A1808", Offset = "0x30A1808", VA = "0x30A1808")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x30A18C4", Offset = "0x30A18C4", VA = "0x30A18C4")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x30A1930", Offset = "0x30A1930", VA = "0x30A1930")]
	public static void InvokeGlobalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x30A19B0", Offset = "0x30A19B0", VA = "0x30A19B0")]
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
		[Address(RVA = "0x30A19B8", Offset = "0x30A19B8", VA = "0x30A19B8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x30A1A70", Offset = "0x30A1A70", VA = "0x30A1A70")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x30A1B28", Offset = "0x30A1B28", VA = "0x30A1B28")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x30A1B94", Offset = "0x30A1B94", VA = "0x30A1B94")]
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
		[Address(RVA = "0x30A1B9C", Offset = "0x30A1B9C", VA = "0x30A1B9C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x30A1C54", Offset = "0x30A1C54", VA = "0x30A1C54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x30A1D0C", Offset = "0x30A1D0C", VA = "0x30A1D0C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x30A1DA8", Offset = "0x30A1DA8", VA = "0x30A1DA8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x30A1E44", Offset = "0x30A1E44", VA = "0x30A1E44")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x30A1EB0", Offset = "0x30A1EB0", VA = "0x30A1EB0")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x30A1ECC", Offset = "0x30A1ECC", VA = "0x30A1ECC")]
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
		[Address(RVA = "0x30A2040", Offset = "0x30A2040", VA = "0x30A2040")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x30A20F8", Offset = "0x30A20F8", VA = "0x30A20F8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x30A21B0", Offset = "0x30A21B0", VA = "0x30A21B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x30A224C", Offset = "0x30A224C", VA = "0x30A224C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x30A22E8", Offset = "0x30A22E8", VA = "0x30A22E8")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x30A2354", Offset = "0x30A2354", VA = "0x30A2354")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x30A2370", Offset = "0x30A2370", VA = "0x30A2370")]
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
		[Address(RVA = "0x30A24E4", Offset = "0x30A24E4", VA = "0x30A24E4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x30A259C", Offset = "0x30A259C", VA = "0x30A259C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x30A2654", Offset = "0x30A2654", VA = "0x30A2654")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x30A26F0", Offset = "0x30A26F0", VA = "0x30A26F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x30A278C", Offset = "0x30A278C", VA = "0x30A278C")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x30A27F8", Offset = "0x30A27F8", VA = "0x30A27F8")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x30A2814", Offset = "0x30A2814", VA = "0x30A2814")]
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
		[Address(RVA = "0x30A2988", Offset = "0x30A2988", VA = "0x30A2988")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x30A2A40", Offset = "0x30A2A40", VA = "0x30A2A40")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x30A2AF8", Offset = "0x30A2AF8", VA = "0x30A2AF8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x30A2B94", Offset = "0x30A2B94", VA = "0x30A2B94")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x30A2C30", Offset = "0x30A2C30", VA = "0x30A2C30")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x30A2CB8", Offset = "0x30A2CB8", VA = "0x30A2CB8")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x30A2CD4", Offset = "0x30A2CD4", VA = "0x30A2CD4")]
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
		[Address(RVA = "0x30A2E58", Offset = "0x30A2E58", VA = "0x30A2E58")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x30A2F10", Offset = "0x30A2F10", VA = "0x30A2F10")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000011")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x30A2FC8", Offset = "0x30A2FC8", VA = "0x30A2FC8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30A3064", Offset = "0x30A3064", VA = "0x30A3064")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x30A3100", Offset = "0x30A3100", VA = "0x30A3100")]
	public static void InvokeGlobalEvent(Transform tm)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x30A316C", Offset = "0x30A316C", VA = "0x30A316C")]
	public void InvokeLocalEvent(Transform tm)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x30A3188", Offset = "0x30A3188", VA = "0x30A3188")]
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
	[Address(RVA = "0x30A32FC", Offset = "0x30A32FC", VA = "0x30A32FC")]
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
	[Address(RVA = "0x30A3330", Offset = "0x30A3330", VA = "0x30A3330")]
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
	[Address(RVA = "0x30A335C", Offset = "0x30A335C", VA = "0x30A335C")]
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
			[Address(RVA = "0x30A4D5C", Offset = "0x30A4D5C", VA = "0x30A4D5C", Slot = "4")]
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
			[Address(RVA = "0x30A4DA4", Offset = "0x30A4DA4", VA = "0x30A4DA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x30A4994", Offset = "0x30A4994", VA = "0x30A4994")]
		[DebuggerHidden]
		public <DeformationCor>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x30A4A7C", Offset = "0x30A4A7C", VA = "0x30A4A7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x30A4A80", Offset = "0x30A4A80", VA = "0x30A4A80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x30A4D64", Offset = "0x30A4D64", VA = "0x30A4D64", Slot = "8")]
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
		[Address(RVA = "0x30A3878", Offset = "0x30A3878", VA = "0x30A3878")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool HasDeforms
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x30A43E8", Offset = "0x30A43E8", VA = "0x30A43E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x30A33A0", Offset = "0x30A33A0", VA = "0x30A33A0")]
	public static void CreateJoints(RFCluster cluster, RFJointProperties joints)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x30A3980", Offset = "0x30A3980", VA = "0x30A3980")]
	public static RFJoint CreateJoint(RFShard shard, RFShard neib, RFJointProperties joints, int id)
	{
		return null;
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x30A40AC", Offset = "0x30A40AC", VA = "0x30A40AC")]
	public static void SetPositionMotion(ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x30A40EC", Offset = "0x30A40EC", VA = "0x30A40EC")]
	public static void SetAngularMotion(float angleLimit, RFJoint joint)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x30A3AE0", Offset = "0x30A3AE0", VA = "0x30A3AE0")]
	public static void SetAngularMotion(float angleLimit, int var, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x30A4224", Offset = "0x30A4224", VA = "0x30A4224")]
	public static void SetSpring(int damper, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x30A3C28", Offset = "0x30A3C28", VA = "0x30A3C28")]
	public static void SetSpring(int damper, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x30A42D8", Offset = "0x30A42D8", VA = "0x30A42D8")]
	public static void SetBreakForce(int force, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x30A42F4", Offset = "0x30A42F4", VA = "0x30A42F4")]
	public static void SetBreakForce(int force, List<RFJoint> jointList)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x30A3D10", Offset = "0x30A3D10", VA = "0x30A3D10")]
	public static void SetBreakForce(int force, int var, List<RFJoint> jointList, bool byMass)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x30A3FEC", Offset = "0x30A3FEC", VA = "0x30A3FEC")]
	public static void SetTransform(Transform tm1, Transform tm2, ConfigurableJoint joint)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x30A38CC", Offset = "0x30A38CC", VA = "0x30A38CC")]
	public void EmptyList()
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x30A443C", Offset = "0x30A443C", VA = "0x30A443C")]
	public void DestroyJoints()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x30A3E38", Offset = "0x30A3E38", VA = "0x30A3E38")]
	public static void SaveProperties(List<RFJoint> joints)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x30A45C0", Offset = "0x30A45C0", VA = "0x30A45C0")]
	public static RFJoint DeformJoint(RFJoint joint, RFJointProperties joints)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x30A473C", Offset = "0x30A473C", VA = "0x30A473C")]
	public static void SetDeformation(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x30A492C", Offset = "0x30A492C", VA = "0x30A492C")]
	[IteratorStateMachine(typeof(<DeformationCor>d__42))]
	public IEnumerator DeformationCor()
	{
		return null;
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x30A49BC", Offset = "0x30A49BC", VA = "0x30A49BC")]
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
		[Address(RVA = "0x30A617C", Offset = "0x30A617C", VA = "0x30A617C")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x30A59FC", Offset = "0x30A59FC", VA = "0x30A59FC")]
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
	[Address(RVA = "0x30A4DAC", Offset = "0x30A4DAC", VA = "0x30A4DAC")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x30A5A24", Offset = "0x30A5A24", VA = "0x30A5A24")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x30A5B48", Offset = "0x30A5B48", VA = "0x30A5B48")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x30A5FE0", Offset = "0x30A5FE0", VA = "0x30A5FE0")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x30A6090", Offset = "0x30A6090", VA = "0x30A6090")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x30A5D68", Offset = "0x30A5D68", VA = "0x30A5D68")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x30A5C10", Offset = "0x30A5C10", VA = "0x30A5C10")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x30A5E84", Offset = "0x30A5E84", VA = "0x30A5E84")]
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
	[Address(RVA = "0x30A61FC", Offset = "0x30A61FC", VA = "0x30A61FC")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x30A6234", Offset = "0x30A6234", VA = "0x30A6234")]
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
	[Address(RVA = "0x30A6268", Offset = "0x30A6268", VA = "0x30A6268")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x30A6294", Offset = "0x30A6294", VA = "0x30A6294")]
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
	[Address(RVA = "0x30A62E0", Offset = "0x30A62E0", VA = "0x30A62E0")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x30A6320", Offset = "0x30A6320", VA = "0x30A6320")]
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
	[Address(RVA = "0x30A6354", Offset = "0x30A6354", VA = "0x30A6354")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x30A6384", Offset = "0x30A6384", VA = "0x30A6384")]
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
	[Address(RVA = "0x30A63A8", Offset = "0x30A63A8", VA = "0x30A63A8")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x30A63E4", Offset = "0x30A63E4", VA = "0x30A63E4")]
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
	[Address(RVA = "0x30A6410", Offset = "0x30A6410", VA = "0x30A6410")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x30A6444", Offset = "0x30A6444", VA = "0x30A6444")]
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
	[Address(RVA = "0x30A6470", Offset = "0x30A6470", VA = "0x30A6470")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x30A64C4", Offset = "0x30A64C4", VA = "0x30A64C4")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x30A64F8", Offset = "0x30A64F8", VA = "0x30A64F8")]
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
	[Address(RVA = "0x30A66F0", Offset = "0x30A66F0", VA = "0x30A66F0")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x30A6720", Offset = "0x30A6720", VA = "0x30A6720")]
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
	[Address(RVA = "0x30A6744", Offset = "0x30A6744", VA = "0x30A6744")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x30A6B2C", Offset = "0x30A6B2C", VA = "0x30A6B2C")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x30A704C", Offset = "0x30A704C", VA = "0x30A704C")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x30A7120", Offset = "0x30A7120", VA = "0x30A7120")]
	public static void CreateDemolitionDebris(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x30A7E58", Offset = "0x30A7E58", VA = "0x30A7E58")]
	private static void CreateReferenceDemolitionDebris(RayfireDebris debris)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x30A7430", Offset = "0x30A7430", VA = "0x30A7430")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x30A8B58", Offset = "0x30A8B58", VA = "0x30A8B58")]
	public static void CreateActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x30A95DC", Offset = "0x30A95DC", VA = "0x30A95DC")]
	public static void CreateActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x30A8470", Offset = "0x30A8470", VA = "0x30A8470")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x30A8D94", Offset = "0x30A8D94", VA = "0x30A8D94")]
	public static void CreateDebrisCluster(RayfireRigid rigid, RayfireDebris debris)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x30A9918", Offset = "0x30A9918", VA = "0x30A9918")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x30A87F0", Offset = "0x30A87F0", VA = "0x30A87F0")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x30A91B8", Offset = "0x30A91B8", VA = "0x30A91B8")]
	public static void CreateDustCluster(RayfireRigid rigid, RayfireDust dust)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x30A9AF8", Offset = "0x30A9AF8", VA = "0x30A9AF8")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x30A9CD8", Offset = "0x30A9CD8", VA = "0x30A9CD8")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x30A9FCC", Offset = "0x30A9FCC", VA = "0x30A9FCC")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x30AA11C", Offset = "0x30AA11C", VA = "0x30AA11C")]
	private static ParticleSystem CreateParticleSystem(Transform tm, RFParticleRendering rend)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x30AA384", Offset = "0x30AA384", VA = "0x30AA384")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x30AA534", Offset = "0x30AA534", VA = "0x30AA534")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x30A7834", Offset = "0x30A7834", VA = "0x30A7834")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x30AA6E4", Offset = "0x30AA6E4", VA = "0x30AA6E4")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x30AAC38", Offset = "0x30AAC38", VA = "0x30AAC38")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x30AB638", Offset = "0x30AB638", VA = "0x30AB638")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x30ABB8C", Offset = "0x30ABB8C", VA = "0x30ABB8C")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x30ABDE8", Offset = "0x30ABDE8", VA = "0x30ABDE8")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x30ABF24", Offset = "0x30ABF24", VA = "0x30ABF24")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x30ABFE8", Offset = "0x30ABFE8", VA = "0x30ABFE8")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x30A9E28", Offset = "0x30A9E28", VA = "0x30A9E28")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x30AC02C", Offset = "0x30AC02C", VA = "0x30AC02C")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x30AC10C", Offset = "0x30AC10C", VA = "0x30AC10C")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x30AC1D0", Offset = "0x30AC1D0", VA = "0x30AC1D0")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x30AC400", Offset = "0x30AC400", VA = "0x30AC400")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x30AC698", Offset = "0x30AC698", VA = "0x30AC698")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x30AC49C", Offset = "0x30AC49C", VA = "0x30AC49C")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x30AC7A4", Offset = "0x30AC7A4", VA = "0x30AC7A4")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x30AC850", Offset = "0x30AC850", VA = "0x30AC850")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x30ACA24", Offset = "0x30ACA24", VA = "0x30ACA24")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x30ACBDC", Offset = "0x30ACBDC", VA = "0x30ACBDC")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x30ACDE0", Offset = "0x30ACDE0", VA = "0x30ACDE0")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x30ACF20", Offset = "0x30ACF20", VA = "0x30ACF20")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x30A7F88", Offset = "0x30A7F88", VA = "0x30A7F88")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x30A88F0", Offset = "0x30A88F0", VA = "0x30A88F0")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x30A81F0", Offset = "0x30A81F0", VA = "0x30A81F0")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x30A8570", Offset = "0x30A8570", VA = "0x30A8570")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x30A9F50", Offset = "0x30A9F50", VA = "0x30A9F50")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x30ACFC4", Offset = "0x30ACFC4", VA = "0x30ACFC4")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x30AD1BC", Offset = "0x30AD1BC", VA = "0x30AD1BC")]
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
		[Address(RVA = "0x30AFFEC", Offset = "0x30AFFEC", VA = "0x30AFFEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public bool SupportState
	{
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x30B0C6C", Offset = "0x30B0C6C", VA = "0x30B0C6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000013")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x30B0CBC", Offset = "0x30B0CBC", VA = "0x30B0CBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public bool Visible
	{
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x30B0CD0", Offset = "0x30B0CD0", VA = "0x30B0CD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x30AE27C", Offset = "0x30AE27C", VA = "0x30AE27C")]
	public RFShard()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x30AE2E4", Offset = "0x30AE2E4", VA = "0x30AE2E4")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x30AE630", Offset = "0x30AE630", VA = "0x30AE630")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x30AE818", Offset = "0x30AE818", VA = "0x30AE818")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x30AE934", Offset = "0x30AE934", VA = "0x30AE934", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x30AE964", Offset = "0x30AE964", VA = "0x30AE964")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x30AEA40", Offset = "0x30AEA40", VA = "0x30AEA40")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x30AEA88", Offset = "0x30AEA88", VA = "0x30AEA88")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x30AEBF0", Offset = "0x30AEBF0", VA = "0x30AEBF0")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x30AEEC8", Offset = "0x30AEEC8", VA = "0x30AEEC8")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x30AF038", Offset = "0x30AF038", VA = "0x30AF038")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x30AF210", Offset = "0x30AF210", VA = "0x30AF210")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x30AF450", Offset = "0x30AF450", VA = "0x30AF450")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x30AFDA8", Offset = "0x30AFDA8", VA = "0x30AFDA8")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x30AFEC0", Offset = "0x30AFEC0", VA = "0x30AFEC0")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x30B0040", Offset = "0x30B0040", VA = "0x30B0040")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x30B0128", Offset = "0x30B0128", VA = "0x30B0128")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x30B01B4", Offset = "0x30B01B4", VA = "0x30B01B4")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x30B031C", Offset = "0x30B031C", VA = "0x30B031C")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x30B0744", Offset = "0x30B0744", VA = "0x30B0744")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x30B0B34", Offset = "0x30B0B34", VA = "0x30B0B34")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x30B0BD0", Offset = "0x30B0BD0", VA = "0x30B0BD0")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x30B0DA8", Offset = "0x30B0DA8", VA = "0x30B0DA8")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x30B0EA8", Offset = "0x30B0EA8", VA = "0x30B0EA8")]
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
		[Address(RVA = "0x30B12A0", Offset = "0x30B12A0", VA = "0x30B12A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x30B10CC", Offset = "0x30B10CC", VA = "0x30B10CC")]
	public RFSound()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x30B10F0", Offset = "0x30B10F0", VA = "0x30B10F0")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x30B12F4", Offset = "0x30B12F4", VA = "0x30B12F4")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x30B13B8", Offset = "0x30B13B8", VA = "0x30B13B8")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x30B1528", Offset = "0x30B1528", VA = "0x30B1528")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x30B1784", Offset = "0x30B1784", VA = "0x30B1784")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x30B1B78", Offset = "0x30B1B78", VA = "0x30B1B78")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x30B1D2C", Offset = "0x30B1D2C", VA = "0x30B1D2C")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x30B1EE0", Offset = "0x30B1EE0", VA = "0x30B1EE0")]
	public static void CollisionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x30B1AC4", Offset = "0x30B1AC4", VA = "0x30B1AC4")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x30B1948", Offset = "0x30B1948", VA = "0x30B1948")]
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
			[Address(RVA = "0x30B5608", Offset = "0x30B5608", VA = "0x30B5608", Slot = "4")]
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
			[Address(RVA = "0x30B5650", Offset = "0x30B5650", VA = "0x30B5650", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x30B228C", Offset = "0x30B228C", VA = "0x30B228C")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x30B5480", Offset = "0x30B5480", VA = "0x30B5480", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x30B5484", Offset = "0x30B5484", VA = "0x30B5484", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x30B5610", Offset = "0x30B5610", VA = "0x30B5610", Slot = "8")]
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
	[Address(RVA = "0x30B2094", Offset = "0x30B2094", VA = "0x30B2094")]
	public RFStress()
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x30B216C", Offset = "0x30B216C", VA = "0x30B216C")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x30B218C", Offset = "0x30B218C", VA = "0x30B218C")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x30B2218", Offset = "0x30B2218", VA = "0x30B2218")]
	[IteratorStateMachine(typeof(<StressCor>d__21))]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x30B22B4", Offset = "0x30B22B4", VA = "0x30B22B4")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x30B255C", Offset = "0x30B255C", VA = "0x30B255C")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x30B29E0", Offset = "0x30B29E0", VA = "0x30B29E0")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x30B2A18", Offset = "0x30B2A18", VA = "0x30B2A18")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x30B2C5C", Offset = "0x30B2C5C", VA = "0x30B2C5C")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x30B2CC4", Offset = "0x30B2CC4", VA = "0x30B2CC4")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x30B2E90", Offset = "0x30B2E90", VA = "0x30B2E90")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x30B3B8C", Offset = "0x30B3B8C", VA = "0x30B3B8C")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x30B4324", Offset = "0x30B4324", VA = "0x30B4324")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x30B34D4", Offset = "0x30B34D4", VA = "0x30B34D4")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x30B4E84", Offset = "0x30B4E84", VA = "0x30B4E84")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x30B43DC", Offset = "0x30B43DC", VA = "0x30B43DC")]
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
			[Address(RVA = "0x30B69D8", Offset = "0x30B69D8", VA = "0x30B69D8", Slot = "4")]
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
			[Address(RVA = "0x30B6A20", Offset = "0x30B6A20", VA = "0x30B6A20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x30B57F8", Offset = "0x30B57F8", VA = "0x30B57F8")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x30B686C", Offset = "0x30B686C", VA = "0x30B686C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x30B6870", Offset = "0x30B6870", VA = "0x30B6870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x30B69E0", Offset = "0x30B69E0", VA = "0x30B69E0", Slot = "8")]
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
			[Address(RVA = "0x30B6BF0", Offset = "0x30B6BF0", VA = "0x30B6BF0", Slot = "4")]
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
			[Address(RVA = "0x30B6C38", Offset = "0x30B6C38", VA = "0x30B6C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x30B5894", Offset = "0x30B5894", VA = "0x30B5894")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x30B6A28", Offset = "0x30B6A28", VA = "0x30B6A28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x30B6A2C", Offset = "0x30B6A2C", VA = "0x30B6A2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x30B6BF8", Offset = "0x30B6BF8", VA = "0x30B6BF8", Slot = "8")]
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
			[Address(RVA = "0x30B6D80", Offset = "0x30B6D80", VA = "0x30B6D80", Slot = "4")]
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
			[Address(RVA = "0x30B6DC8", Offset = "0x30B6DC8", VA = "0x30B6DC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x30B5930", Offset = "0x30B5930", VA = "0x30B5930")]
		[DebuggerHidden]
		public <InactiveCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x30B6C40", Offset = "0x30B6C40", VA = "0x30B6C40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x30B6C44", Offset = "0x30B6C44", VA = "0x30B6C44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x30B6D88", Offset = "0x30B6D88", VA = "0x30B6D88", Slot = "8")]
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
			[Address(RVA = "0x30B753C", Offset = "0x30B753C", VA = "0x30B753C", Slot = "4")]
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
			[Address(RVA = "0x30B7584", Offset = "0x30B7584", VA = "0x30B7584", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x30B59CC", Offset = "0x30B59CC", VA = "0x30B59CC")]
		[DebuggerHidden]
		public <InactiveCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x30B6DD0", Offset = "0x30B6DD0", VA = "0x30B6DD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x30B6DD4", Offset = "0x30B6DD4", VA = "0x30B6DD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x30B7544", Offset = "0x30B7544", VA = "0x30B7544", Slot = "8")]
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
	[Address(RVA = "0x30B5658", Offset = "0x30B5658", VA = "0x30B5658")]
	public RFActivation()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x30B5698", Offset = "0x30B5698", VA = "0x30B5698")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x30B5688", Offset = "0x30B5688", VA = "0x30B5688")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x30B56FC", Offset = "0x30B56FC", VA = "0x30B56FC")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x30B5784", Offset = "0x30B5784", VA = "0x30B5784")]
	[IteratorStateMachine(typeof(<ActivationVelocityCor>d__24))]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x30B5820", Offset = "0x30B5820", VA = "0x30B5820")]
	[IteratorStateMachine(typeof(<ActivationOffsetCor>d__25))]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x30B58BC", Offset = "0x30B58BC", VA = "0x30B58BC")]
	[IteratorStateMachine(typeof(<InactiveCor>d__26))]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x30B5958", Offset = "0x30B5958", VA = "0x30B5958")]
	[IteratorStateMachine(typeof(<InactiveCor>d__27))]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x30B59F4", Offset = "0x30B59F4", VA = "0x30B59F4")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x30B60AC", Offset = "0x30B60AC", VA = "0x30B60AC")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x30B5F4C", Offset = "0x30B5F4C", VA = "0x30B5F4C")]
	public static void ActivationRandomRotation(Rigidbody rb)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x30B5EFC", Offset = "0x30B5EFC", VA = "0x30B5EFC")]
	private static void SetActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x30B648C", Offset = "0x30B648C", VA = "0x30B648C")]
	public static void RestoreActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x30B64DC", Offset = "0x30B64DC", VA = "0x30B64DC")]
	public static void BackupActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x30B6444", Offset = "0x30B6444", VA = "0x30B6444")]
	private static void SetActivationLayer(RFShard shard, RFActivation activation)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x30B6518", Offset = "0x30B6518", VA = "0x30B6518")]
	public static void SetActivationLayer(List<RFShard> shards, RFActivation activation, Transform root)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x30B6640", Offset = "0x30B6640", VA = "0x30B6640")]
	public static void RestoreActivationLayer(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x30B6730", Offset = "0x30B6730", VA = "0x30B6730")]
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
	[Address(RVA = "0x30B758C", Offset = "0x30B758C", VA = "0x30B758C")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x30B75A8", Offset = "0x30B75A8", VA = "0x30B75A8")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x30B7908", Offset = "0x30B7908", VA = "0x30B7908")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x30B7B18", Offset = "0x30B7B18", VA = "0x30B7B18")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x30B7FDC", Offset = "0x30B7FDC", VA = "0x30B7FDC")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x30B88E0", Offset = "0x30B88E0", VA = "0x30B88E0")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x30B76F0", Offset = "0x30B76F0", VA = "0x30B76F0")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x30B8558", Offset = "0x30B8558", VA = "0x30B8558")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x30B83CC", Offset = "0x30B83CC", VA = "0x30B83CC")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x30B80F0", Offset = "0x30B80F0", VA = "0x30B80F0")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x30B8494", Offset = "0x30B8494", VA = "0x30B8494")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x30B8774", Offset = "0x30B8774", VA = "0x30B8774")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x30B8BDC", Offset = "0x30B8BDC", VA = "0x30B8BDC")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x30B8E48", Offset = "0x30B8E48", VA = "0x30B8E48")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x30B8F30", Offset = "0x30B8F30", VA = "0x30B8F30")]
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
			[Address(RVA = "0x30BACF0", Offset = "0x30BACF0", VA = "0x30BACF0", Slot = "4")]
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
			[Address(RVA = "0x30BAD38", Offset = "0x30BAD38", VA = "0x30BAD38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x30B9940", Offset = "0x30B9940", VA = "0x30B9940")]
		[DebuggerHidden]
		public <CollapseCor>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x30BAB2C", Offset = "0x30BAB2C", VA = "0x30BAB2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x30BAB30", Offset = "0x30BAB30", VA = "0x30BAB30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x30BACF8", Offset = "0x30BACF8", VA = "0x30BACF8", Slot = "8")]
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
			[Address(RVA = "0x30BAF04", Offset = "0x30BAF04", VA = "0x30BAF04", Slot = "4")]
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
			[Address(RVA = "0x30BAF4C", Offset = "0x30BAF4C", VA = "0x30BAF4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x30B9AB0", Offset = "0x30B9AB0", VA = "0x30B9AB0")]
		[DebuggerHidden]
		public <CollapseCor>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x30BAD40", Offset = "0x30BAD40", VA = "0x30BAD40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x30BAD44", Offset = "0x30BAD44", VA = "0x30BAD44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x30BAF0C", Offset = "0x30BAF0C", VA = "0x30BAF0C", Slot = "8")]
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
	[Address(RVA = "0x30B97D4", Offset = "0x30B97D4", VA = "0x30B97D4")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x30B9804", Offset = "0x30B9804", VA = "0x30B9804")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x30B98CC", Offset = "0x30B98CC", VA = "0x30B98CC")]
	[IteratorStateMachine(typeof(<CollapseCor>d__11))]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x30B9968", Offset = "0x30B9968", VA = "0x30B9968")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x30B9A90", Offset = "0x30B9A90", VA = "0x30B9A90")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x30B9A1C", Offset = "0x30B9A1C", VA = "0x30B9A1C")]
	[IteratorStateMachine(typeof(<CollapseCor>d__14))]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x30B9AD8", Offset = "0x30B9AD8", VA = "0x30B9AD8")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x30B9BAC", Offset = "0x30B9BAC", VA = "0x30B9BAC")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x30B9B40", Offset = "0x30B9B40", VA = "0x30B9B40")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x30B9C14", Offset = "0x30B9C14", VA = "0x30B9C14")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x30BA350", Offset = "0x30BA350", VA = "0x30BA350")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x30B9F78", Offset = "0x30B9F78", VA = "0x30B9F78")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x30BA7D8", Offset = "0x30BA7D8", VA = "0x30BA7D8")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x30BA898", Offset = "0x30BA898", VA = "0x30BA898")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x30BA838", Offset = "0x30BA838", VA = "0x30BA838")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x30BA8F8", Offset = "0x30BA8F8", VA = "0x30BA8F8")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x30BA958", Offset = "0x30BA958", VA = "0x30BA958")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x30B9C80", Offset = "0x30B9C80", VA = "0x30B9C80")]
	private static int RemNeibByArea(RFCluster cluster, float minArea, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x30BA0D0", Offset = "0x30BA0D0", VA = "0x30BA0D0")]
	private static int RemNeibBySize(RFCluster cluster, float minSize, float variation, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x30BA3B4", Offset = "0x30BA3B4", VA = "0x30BA3B4")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x30BA9C0", Offset = "0x30BA9C0", VA = "0x30BA9C0")]
	private static void RemoveConnection(RFCluster cluster, int s, int n)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x30B9510", Offset = "0x30B9510", VA = "0x30B9510")]
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
	[Address(RVA = "0x30BAF54", Offset = "0x30BAF54", VA = "0x30BAF54")]
	public RFDamage()
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x30BAF8C", Offset = "0x30BAF8C", VA = "0x30BAF8C")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x30B8BD4", Offset = "0x30B8BD4", VA = "0x30B8BD4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x30BAFCC", Offset = "0x30BAFCC", VA = "0x30BAFCC")]
	public static bool ApplyDamage(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x30BB140", Offset = "0x30BB140", VA = "0x30BB140")]
	public static bool ApplyTo(RayfireRigid scr, float value, Vector3 point, float radius = 0f, [Optional] Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x30BB27C", Offset = "0x30BB27C", VA = "0x30BB27C")]
	public static bool ApplyToRigid(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x30BB178", Offset = "0x30BB178", VA = "0x30BB178")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x30BB2C4", Offset = "0x30BB2C4", VA = "0x30BB2C4")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x30BB440", Offset = "0x30BB440", VA = "0x30BB440")]
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
		[Address(RVA = "0x30C0D38", Offset = "0x30C0D38", VA = "0x30C0D38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000025")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x30BC188", Offset = "0x30BC188", VA = "0x30BC188")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x30BB648", Offset = "0x30BB648", VA = "0x30BB648")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x30BB6A0", Offset = "0x30BB6A0", VA = "0x30BB6A0")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x30B8BCC", Offset = "0x30B8BCC", VA = "0x30B8BCC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x30BB6F8", Offset = "0x30BB6F8", VA = "0x30BB6F8")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x30BB7B8", Offset = "0x30BB7B8", VA = "0x30BB7B8")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x30BB858", Offset = "0x30BB858", VA = "0x30BB858")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x30BBD90", Offset = "0x30BBD90", VA = "0x30BBD90")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x30BBF48", Offset = "0x30BBF48", VA = "0x30BBF48")]
	private static void InitNestedCluster(RFCluster parentCluster, List<RFCluster> minorClusters)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x30BBAB8", Offset = "0x30BBAB8", VA = "0x30BBAB8")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x30BC1DC", Offset = "0x30BC1DC", VA = "0x30BC1DC")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x30BC600", Offset = "0x30BC600", VA = "0x30BC600")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x30BC8D4", Offset = "0x30BC8D4", VA = "0x30BC8D4")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x30BCA84", Offset = "0x30BCA84", VA = "0x30BCA84")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x30BCDFC", Offset = "0x30BCDFC", VA = "0x30BCDFC")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x30BC704", Offset = "0x30BC704", VA = "0x30BC704")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x30BA624", Offset = "0x30BA624", VA = "0x30BA624")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x30BD698", Offset = "0x30BD698", VA = "0x30BD698")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x30BD780", Offset = "0x30BD780", VA = "0x30BD780")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x30BD878", Offset = "0x30BD878", VA = "0x30BD878")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x30BE92C", Offset = "0x30BE92C", VA = "0x30BE92C")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x30BF1DC", Offset = "0x30BF1DC", VA = "0x30BF1DC")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x30BD294", Offset = "0x30BD294", VA = "0x30BD294")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x30BDECC", Offset = "0x30BDECC", VA = "0x30BDECC")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x30BF5E0", Offset = "0x30BF5E0", VA = "0x30BF5E0")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x30BFD84", Offset = "0x30BFD84", VA = "0x30BFD84")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x30C0228", Offset = "0x30C0228", VA = "0x30C0228")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x30BFC70", Offset = "0x30BFC70", VA = "0x30BFC70")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x30C05E0", Offset = "0x30C05E0", VA = "0x30C05E0")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x30BDBA0", Offset = "0x30BDBA0", VA = "0x30BDBA0")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x30C0844", Offset = "0x30C0844", VA = "0x30C0844")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x30BDDC8", Offset = "0x30BDDC8", VA = "0x30BDDC8")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x30C0C14", Offset = "0x30C0C14", VA = "0x30C0C14")]
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
	[Address(RVA = "0x30C0DF8", Offset = "0x30C0DF8", VA = "0x30C0DF8")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x30C0E94", Offset = "0x30C0E94", VA = "0x30C0E94")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x30C10C4", Offset = "0x30C10C4", VA = "0x30C10C4")]
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
			[Address(RVA = "0x30C4AB0", Offset = "0x30C4AB0", VA = "0x30C4AB0", Slot = "4")]
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
			[Address(RVA = "0x30C4AF8", Offset = "0x30C4AF8", VA = "0x30C4AF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x30C3AA8", Offset = "0x30C3AA8", VA = "0x30C3AA8")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x30C41BC", Offset = "0x30C41BC", VA = "0x30C41BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x30C41C0", Offset = "0x30C41C0", VA = "0x30C41C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x30C4AB8", Offset = "0x30C4AB8", VA = "0x30C4AB8", Slot = "8")]
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
	[Address(RVA = "0x30C10CC", Offset = "0x30C10CC", VA = "0x30C10CC")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x30C1288", Offset = "0x30C1288", VA = "0x30C1288")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x30C127C", Offset = "0x30C127C", VA = "0x30C127C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0x30C13CC", Offset = "0x30C13CC", VA = "0x30C13CC")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000201")]
	[Address(RVA = "0x30C20E0", Offset = "0x30C20E0", VA = "0x30C20E0")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x6000202")]
	[Address(RVA = "0x30C1640", Offset = "0x30C1640", VA = "0x30C1640")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000203")]
	[Address(RVA = "0x30C2D98", Offset = "0x30C2D98", VA = "0x30C2D98")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000204")]
	[Address(RVA = "0x30C3250", Offset = "0x30C3250", VA = "0x30C3250")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000205")]
	[Address(RVA = "0x30C258C", Offset = "0x30C258C", VA = "0x30C258C")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000206")]
	[Address(RVA = "0x30C2010", Offset = "0x30C2010", VA = "0x30C2010")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000207")]
	[Address(RVA = "0x30C3984", Offset = "0x30C3984", VA = "0x30C3984")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000208")]
	[Address(RVA = "0x30C3A34", Offset = "0x30C3A34", VA = "0x30C3A34")]
	[IteratorStateMachine(typeof(<RuntimeCachingCor>d__33))]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000209")]
	[Address(RVA = "0x30C3AD0", Offset = "0x30C3AD0", VA = "0x30C3AD0")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x600020A")]
	[Address(RVA = "0x30C3AF8", Offset = "0x30C3AF8", VA = "0x30C3AF8")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x600020B")]
	[Address(RVA = "0x30C3B50", Offset = "0x30C3B50", VA = "0x30C3B50")]
	public static void Awake(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020C")]
	[Address(RVA = "0x30C3BF8", Offset = "0x30C3BF8", VA = "0x30C3BF8")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020D")]
	[Address(RVA = "0x30C3C74", Offset = "0x30C3C74", VA = "0x30C3C74")]
	private static void Prefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600020E")]
	[Address(RVA = "0x30C3E64", Offset = "0x30C3E64", VA = "0x30C3E64")]
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
			[Address(RVA = "0x30C5FBC", Offset = "0x30C5FBC", VA = "0x30C5FBC", Slot = "4")]
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
			[Address(RVA = "0x30C6004", Offset = "0x30C6004", VA = "0x30C6004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x30C4E68", Offset = "0x30C4E68", VA = "0x30C4E68")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x30C5D78", Offset = "0x30C5D78", VA = "0x30C5D78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x30C5D7C", Offset = "0x30C5D7C", VA = "0x30C5D7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x30C5FC4", Offset = "0x30C5FC4", VA = "0x30C5FC4", Slot = "8")]
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
			[Address(RVA = "0x30C6330", Offset = "0x30C6330", VA = "0x30C6330", Slot = "4")]
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
			[Address(RVA = "0x30C6378", Offset = "0x30C6378", VA = "0x30C6378", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x30C4EF8", Offset = "0x30C4EF8", VA = "0x30C4EF8")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x30C600C", Offset = "0x30C600C", VA = "0x30C600C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x30C6010", Offset = "0x30C6010", VA = "0x30C6010", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x30C6338", Offset = "0x30C6338", VA = "0x30C6338", Slot = "8")]
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
			[Address(RVA = "0x30C666C", Offset = "0x30C666C", VA = "0x30C666C", Slot = "4")]
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
			[Address(RVA = "0x30C66B4", Offset = "0x30C66B4", VA = "0x30C66B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x30C5184", Offset = "0x30C5184", VA = "0x30C5184")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x30C6380", Offset = "0x30C6380", VA = "0x30C6380", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x30C6384", Offset = "0x30C6384", VA = "0x30C6384", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x30C6674", Offset = "0x30C6674", VA = "0x30C6674", Slot = "8")]
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
			[Address(RVA = "0x30C698C", Offset = "0x30C698C", VA = "0x30C698C", Slot = "4")]
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
			[Address(RVA = "0x30C69D4", Offset = "0x30C69D4", VA = "0x30C69D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x30C51AC", Offset = "0x30C51AC", VA = "0x30C51AC")]
		[DebuggerHidden]
		public <LivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x30C66BC", Offset = "0x30C66BC", VA = "0x30C66BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x30C66C0", Offset = "0x30C66C0", VA = "0x30C66C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x30C6994", Offset = "0x30C6994", VA = "0x30C6994", Slot = "8")]
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
			[Address(RVA = "0x30C6B5C", Offset = "0x30C6B5C", VA = "0x30C6B5C", Slot = "4")]
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
			[Address(RVA = "0x30C6BA4", Offset = "0x30C6BA4", VA = "0x30C6BA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x30C523C", Offset = "0x30C523C", VA = "0x30C523C")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x30C69DC", Offset = "0x30C69DC", VA = "0x30C69DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x30C69E0", Offset = "0x30C69E0", VA = "0x30C69E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x30C6B64", Offset = "0x30C6B64", VA = "0x30C6B64", Slot = "8")]
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
			[Address(RVA = "0x30C6D8C", Offset = "0x30C6D8C", VA = "0x30C6D8C", Slot = "4")]
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
			[Address(RVA = "0x30C6DD4", Offset = "0x30C6DD4", VA = "0x30C6DD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x30C557C", Offset = "0x30C557C", VA = "0x30C557C")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x30C6BAC", Offset = "0x30C6BAC", VA = "0x30C6BAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x30C6BB0", Offset = "0x30C6BB0", VA = "0x30C6BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x30C6D94", Offset = "0x30C6D94", VA = "0x30C6D94", Slot = "8")]
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
			[Address(RVA = "0x30C6F9C", Offset = "0x30C6F9C", VA = "0x30C6F9C", Slot = "4")]
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
			[Address(RVA = "0x30C6FE4", Offset = "0x30C6FE4", VA = "0x30C6FE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x30C5618", Offset = "0x30C5618", VA = "0x30C5618")]
		[DebuggerHidden]
		public <FallDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x30C6DDC", Offset = "0x30C6DDC", VA = "0x30C6DDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x30C6DE0", Offset = "0x30C6DE0", VA = "0x30C6DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x30C6FA4", Offset = "0x30C6FA4", VA = "0x30C6FA4", Slot = "8")]
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
			[Address(RVA = "0x30C71B0", Offset = "0x30C71B0", VA = "0x30C71B0", Slot = "4")]
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
			[Address(RVA = "0x30C71F8", Offset = "0x30C71F8", VA = "0x30C71F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x30C56A8", Offset = "0x30C56A8", VA = "0x30C56A8")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x30C6FEC", Offset = "0x30C6FEC", VA = "0x30C6FEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x30C6FF0", Offset = "0x30C6FF0", VA = "0x30C6FF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x30C71B8", Offset = "0x30C71B8", VA = "0x30C71B8", Slot = "8")]
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
			[Address(RVA = "0x30C7408", Offset = "0x30C7408", VA = "0x30C7408", Slot = "4")]
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
			[Address(RVA = "0x30C7450", Offset = "0x30C7450", VA = "0x30C7450", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x30C5744", Offset = "0x30C5744", VA = "0x30C5744")]
		[DebuggerHidden]
		public <ScaleDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x30C7200", Offset = "0x30C7200", VA = "0x30C7200", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x30C7204", Offset = "0x30C7204", VA = "0x30C7204", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x30C7410", Offset = "0x30C7410", VA = "0x30C7410", Slot = "8")]
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
			[Address(RVA = "0x30C7848", Offset = "0x30C7848", VA = "0x30C7848", Slot = "4")]
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
			[Address(RVA = "0x30C7890", Offset = "0x30C7890", VA = "0x30C7890", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x30C57D4", Offset = "0x30C57D4", VA = "0x30C57D4")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x30C7458", Offset = "0x30C7458", VA = "0x30C7458", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x30C745C", Offset = "0x30C745C", VA = "0x30C745C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x30C7850", Offset = "0x30C7850", VA = "0x30C7850", Slot = "8")]
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
			[Address(RVA = "0x30C7BE0", Offset = "0x30C7BE0", VA = "0x30C7BE0", Slot = "4")]
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
			[Address(RVA = "0x30C7C28", Offset = "0x30C7C28", VA = "0x30C7C28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x30C5870", Offset = "0x30C5870", VA = "0x30C5870")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x30C7898", Offset = "0x30C7898", VA = "0x30C7898", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x30C789C", Offset = "0x30C789C", VA = "0x30C789C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x30C7BE8", Offset = "0x30C7BE8", VA = "0x30C7BE8", Slot = "8")]
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
	[Address(RVA = "0x30C4B00", Offset = "0x30C4B00", VA = "0x30C4B00")]
	public RFFade()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x30C4BC0", Offset = "0x30C4BC0", VA = "0x30C4BC0")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x30C4BAC", Offset = "0x30C4BAC", VA = "0x30C4BAC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x30C4C04", Offset = "0x30C4C04", VA = "0x30C4C04")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x30C4E00", Offset = "0x30C4E00", VA = "0x30C4E00")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__20))]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x30C4E90", Offset = "0x30C4E90", VA = "0x30C4E90")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__21))]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x30C4CF0", Offset = "0x30C4CF0", VA = "0x30C4CF0")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x30C4F88", Offset = "0x30C4F88", VA = "0x30C4F88")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x30C5068", Offset = "0x30C5068", VA = "0x30C5068")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x30C4F20", Offset = "0x30C4F20", VA = "0x30C4F20")]
	[IteratorStateMachine(typeof(<LivingCor>d__25))]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x30C4FF4", Offset = "0x30C4FF4", VA = "0x30C4FF4")]
	[IteratorStateMachine(typeof(<LivingCor>d__26))]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x30C51D4", Offset = "0x30C51D4", VA = "0x30C51D4")]
	[IteratorStateMachine(typeof(<SimulationLivingCor>d__27))]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000222")]
	[Address(RVA = "0x30C5264", Offset = "0x30C5264", VA = "0x30C5264")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000223")]
	[Address(RVA = "0x30C5440", Offset = "0x30C5440", VA = "0x30C5440")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0x30C5514", Offset = "0x30C5514", VA = "0x30C5514")]
	[IteratorStateMachine(typeof(<FallDownCor>d__30))]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x30C55A4", Offset = "0x30C55A4", VA = "0x30C55A4")]
	[IteratorStateMachine(typeof(<FallDownCor>d__31))]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x30C5640", Offset = "0x30C5640", VA = "0x30C5640")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__32))]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x30C56D0", Offset = "0x30C56D0", VA = "0x30C56D0")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__33))]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x30C576C", Offset = "0x30C576C", VA = "0x30C576C")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__34))]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x30C57FC", Offset = "0x30C57FC", VA = "0x30C57FC")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__35))]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x30C5898", Offset = "0x30C5898", VA = "0x30C5898")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x30C5AA4", Offset = "0x30C5AA4", VA = "0x30C5AA4")]
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
	[Address(RVA = "0x30C11EC", Offset = "0x30C11EC", VA = "0x30C11EC")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x30C1384", Offset = "0x30C1384", VA = "0x30C1384")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x30C2728", Offset = "0x30C2728", VA = "0x30C2728")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x30C2774", Offset = "0x30C2774", VA = "0x30C2774")]
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
			[Address(RVA = "0x30C9F9C", Offset = "0x30C9F9C", VA = "0x30C9F9C", Slot = "4")]
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
			[Address(RVA = "0x30C9FE4", Offset = "0x30C9FE4", VA = "0x30C9FE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x30C7E7C", Offset = "0x30C7E7C", VA = "0x30C7E7C")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x30C9E90", Offset = "0x30C9E90", VA = "0x30C9E90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x30C9E94", Offset = "0x30C9E94", VA = "0x30C9E94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x30C9FA4", Offset = "0x30C9FA4", VA = "0x30C9FA4", Slot = "8")]
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
	[Address(RVA = "0x30C7C30", Offset = "0x30C7C30", VA = "0x30C7C30")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x30C7DBC", Offset = "0x30C7DBC", VA = "0x30C7DBC")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x30C7CC0", Offset = "0x30C7CC0", VA = "0x30C7CC0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x30C7E08", Offset = "0x30C7E08", VA = "0x30C7E08")]
	[IteratorStateMachine(typeof(<DemolishableCor>d__28))]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x30C7EA4", Offset = "0x30C7EA4", VA = "0x30C7EA4")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x30C960C", Offset = "0x30C960C", VA = "0x30C960C")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x30C9738", Offset = "0x30C9738", VA = "0x30C9738")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x30C9864", Offset = "0x30C9864", VA = "0x30C9864")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x30C25C4", Offset = "0x30C25C4", VA = "0x30C25C4")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x30C9934", Offset = "0x30C9934", VA = "0x30C9934")]
	public bool CollisionCheck(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x30C997C", Offset = "0x30C997C", VA = "0x30C997C")]
	public void SetContactInfo(ContactPoint contact)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x30C99D4", Offset = "0x30C99D4", VA = "0x30C99D4")]
	public bool KinematicCollisionCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x30C9B48", Offset = "0x30C9B48", VA = "0x30C9B48")]
	public bool ContactPointsCheck(Collision collision, float finalSolidity)
	{
		return default(bool);
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x30C9C68", Offset = "0x30C9C68", VA = "0x30C9C68")]
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
		[Address(RVA = "0x30CD998", Offset = "0x30CD998", VA = "0x30CD998")]
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
			[Address(RVA = "0x30CDCD0", Offset = "0x30CDCD0", VA = "0x30CDCD0", Slot = "4")]
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
			[Address(RVA = "0x30CDD18", Offset = "0x30CDD18", VA = "0x30CDD18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x30CDA14", Offset = "0x30CDA14", VA = "0x30CDA14")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__72(int <>1__state)
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x30CDB70", Offset = "0x30CDB70", VA = "0x30CDB70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x30CDB74", Offset = "0x30CDB74", VA = "0x30CDB74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x30CDCD8", Offset = "0x30CDCD8", VA = "0x30CDCD8", Slot = "8")]
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
		[Address(RVA = "0x30CCDC0", Offset = "0x30CCDC0", VA = "0x30CCDC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000041")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x30C5A4C", Offset = "0x30C5A4C", VA = "0x30C5A4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000042")]
	public bool Destructible
	{
		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x30CDA3C", Offset = "0x30CDA3C", VA = "0x30CDA3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public int Solidity
	{
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x30CDAB0", Offset = "0x30CDAB0", VA = "0x30CDAB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000044")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x30CC320", Offset = "0x30CC320", VA = "0x30CC320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x30C9FEC", Offset = "0x30C9FEC", VA = "0x30C9FEC")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x30CA1B0", Offset = "0x30CA1B0", VA = "0x30CA1B0")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x30CA14C", Offset = "0x30CA14C", VA = "0x30CA14C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x30CA20C", Offset = "0x30CA20C", VA = "0x30CA20C")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x30CA280", Offset = "0x30CA280", VA = "0x30CA280")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x30CA2DC", Offset = "0x30CA2DC", VA = "0x30CA2DC")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver, float sleep = 0.005f)
	{
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x30CA498", Offset = "0x30CA498", VA = "0x30CA498")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x30CA588", Offset = "0x30CA588", VA = "0x30CA588")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x30CA5D0", Offset = "0x30CA5D0", VA = "0x30CA5D0")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x30CA60C", Offset = "0x30CA60C", VA = "0x30CA60C")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x30CA4D4", Offset = "0x30CA4D4", VA = "0x30CA4D4")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x30CA658", Offset = "0x30CA658", VA = "0x30CA658")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x30CA904", Offset = "0x30CA904", VA = "0x30CA904")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x30CA7CC", Offset = "0x30CA7CC", VA = "0x30CA7CC")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x30C297C", Offset = "0x30C297C", VA = "0x30C297C")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x30CA9F4", Offset = "0x30CA9F4", VA = "0x30CA9F4")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x30CAAD0", Offset = "0x30CAAD0", VA = "0x30CAAD0")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x30CAB14", Offset = "0x30CAB14", VA = "0x30CAB14")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x30C2810", Offset = "0x30C2810", VA = "0x30C2810")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x30CAD84", Offset = "0x30CAD84", VA = "0x30CAD84")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x30CB270", Offset = "0x30CB270", VA = "0x30CB270")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x30CB490", Offset = "0x30CB490", VA = "0x30CB490")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x30CB69C", Offset = "0x30CB69C", VA = "0x30CB69C")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x30CB810", Offset = "0x30CB810", VA = "0x30CB810")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x30CB960", Offset = "0x30CB960", VA = "0x30CB960")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x30CBDE0", Offset = "0x30CBDE0", VA = "0x30CBDE0")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x30CBEDC", Offset = "0x30CBEDC", VA = "0x30CBEDC")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x30CBFD0", Offset = "0x30CBFD0", VA = "0x30CBFD0")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x30CC19C", Offset = "0x30CC19C", VA = "0x30CC19C")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x30CC3A0", Offset = "0x30CC3A0", VA = "0x30CC3A0")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x30CC434", Offset = "0x30CC434", VA = "0x30CC434")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x30CC53C", Offset = "0x30CC53C", VA = "0x30CC53C")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x30CC630", Offset = "0x30CC630", VA = "0x30CC630")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x30CC78C", Offset = "0x30CC78C", VA = "0x30CC78C")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x30CC8A0", Offset = "0x30CC8A0", VA = "0x30CC8A0")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x30CCBB8", Offset = "0x30CCBB8", VA = "0x30CCBB8")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x30C29B8", Offset = "0x30C29B8", VA = "0x30C29B8")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x30CD50C", Offset = "0x30CD50C", VA = "0x30CD50C")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x30CD5EC", Offset = "0x30CD5EC", VA = "0x30CD5EC")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x30CD100", Offset = "0x30CD100", VA = "0x30CD100")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x30CCE14", Offset = "0x30CCE14", VA = "0x30CCE14")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x30CD324", Offset = "0x30CD324", VA = "0x30CD324")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x30CD7C8", Offset = "0x30CD7C8", VA = "0x30CD7C8")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x30CAD78", Offset = "0x30CAD78", VA = "0x30CAD78")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x30CD9A0", Offset = "0x30CD9A0", VA = "0x30CD9A0")]
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
		[Address(RVA = "0x30CDE28", Offset = "0x30CDE28", VA = "0x30CDE28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x30CDD20", Offset = "0x30CDD20", VA = "0x30CDD20")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x30CDD48", Offset = "0x30CDD48", VA = "0x30CDD48")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x30CDE7C", Offset = "0x30CDE7C", VA = "0x30CDE7C")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x30CE104", Offset = "0x30CE104", VA = "0x30CE104")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x30CEB3C", Offset = "0x30CEB3C", VA = "0x30CEB3C")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x30CECE8", Offset = "0x30CECE8", VA = "0x30CECE8")]
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
	[Address(RVA = "0x30CEEB4", Offset = "0x30CEEB4", VA = "0x30CEEB4")]
	public RFReset()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x30CEEEC", Offset = "0x30CEEEC", VA = "0x30CEEEC")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x30CEF48", Offset = "0x30CEF48", VA = "0x30CEF48")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x30CF984", Offset = "0x30CF984", VA = "0x30CF984")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x30CF238", Offset = "0x30CF238", VA = "0x30CF238")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x30CFFE4", Offset = "0x30CFFE4", VA = "0x30CFFE4")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x30D0168", Offset = "0x30D0168", VA = "0x30D0168")]
	public static void DestroyMeshRootParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x30D02D8", Offset = "0x30D02D8", VA = "0x30D02D8")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x30D098C", Offset = "0x30D098C", VA = "0x30D098C")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x30D0768", Offset = "0x30D0768", VA = "0x30D0768")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x30D05F8", Offset = "0x30D05F8", VA = "0x30D05F8")]
	public static void DestroyRigidRootParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x30D0BA8", Offset = "0x30D0BA8", VA = "0x30D0BA8")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x30CFBE0", Offset = "0x30CFBE0", VA = "0x30CFBE0")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x30D135C", Offset = "0x30D135C", VA = "0x30D135C")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x30CFD4C", Offset = "0x30CFD4C", VA = "0x30CFD4C")]
	public static void DestroyRigidParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x30D0F78", Offset = "0x30D0F78", VA = "0x30D0F78")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x30D19B4", Offset = "0x30D19B4", VA = "0x30D19B4")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x30CFC8C", Offset = "0x30CFC8C", VA = "0x30CFC8C")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x30CF110", Offset = "0x30CF110", VA = "0x30CF110")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x30D0D20", Offset = "0x30D0D20", VA = "0x30D0D20")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x30CF58C", Offset = "0x30CF58C", VA = "0x30CF58C")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x30CF700", Offset = "0x30CF700", VA = "0x30CF700")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x30CFCBC", Offset = "0x30CFCBC", VA = "0x30CFCBC")]
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
	[Address(RVA = "0x30C1258", Offset = "0x30C1258", VA = "0x30C1258")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x30C4754", Offset = "0x30C4754", VA = "0x30C4754")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x30C45E8", Offset = "0x30C45E8", VA = "0x30C45E8")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x30D1BF8", Offset = "0x30D1BF8", VA = "0x30D1BF8")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x30C4928", Offset = "0x30C4928", VA = "0x30C4928")]
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
	[Address(RVA = "0x30D1D78", Offset = "0x30D1D78", VA = "0x30D1D78")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x30D1D9C", Offset = "0x30D1D9C", VA = "0x30D1D9C")]
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
	[Address(RVA = "0x30D1E34", Offset = "0x30D1E34", VA = "0x30D1E34")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x30D1E78", Offset = "0x30D1E78", VA = "0x30D1E78")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x30D1EC0", Offset = "0x30D1EC0", VA = "0x30D1EC0")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x30D1F80", Offset = "0x30D1F80", VA = "0x30D1F80")]
	private static void SetCustomInputCloud(RFCustom custom, Transform tm)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x30D22F0", Offset = "0x30D22F0", VA = "0x30D22F0")]
	private static void SetCustomOutputCloud(RFCustom custom, int seed, Bounds bound)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x30D2554", Offset = "0x30D2554", VA = "0x30D2554")]
	private static void SetCustomBoundPoints(RFCustom custom, Bounds bound)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x30D2788", Offset = "0x30D2788", VA = "0x30D2788")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x30D27FC", Offset = "0x30D27FC", VA = "0x30D27FC")]
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
	[Address(RVA = "0x30D2864", Offset = "0x30D2864", VA = "0x30D2864")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x30D3FC0", Offset = "0x30D3FC0", VA = "0x30D3FC0")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x30D4378", Offset = "0x30D4378", VA = "0x30D4378")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x30D52D4", Offset = "0x30D52D4", VA = "0x30D52D4")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x30D5388", Offset = "0x30D5388", VA = "0x30D5388")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x30D5E00", Offset = "0x30D5E00", VA = "0x30D5E00")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x30D6248", Offset = "0x30D6248", VA = "0x30D6248")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x30D60D8", Offset = "0x30D60D8", VA = "0x30D60D8")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x30D5D70", Offset = "0x30D5D70", VA = "0x30D5D70")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x30D2EC0", Offset = "0x30D2EC0", VA = "0x30D2EC0")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x30D6788", Offset = "0x30D6788", VA = "0x30D6788")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x30D39B0", Offset = "0x30D39B0", VA = "0x30D39B0")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x30D2DFC", Offset = "0x30D2DFC", VA = "0x30D2DFC")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x30D6E04", Offset = "0x30D6E04", VA = "0x30D6E04")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x30D34CC", Offset = "0x30D34CC", VA = "0x30D34CC")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x30D5648", Offset = "0x30D5648", VA = "0x30D5648")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x30D2FA4", Offset = "0x30D2FA4", VA = "0x30D2FA4")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x30D8170", Offset = "0x30D8170", VA = "0x30D8170")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x30D82F0", Offset = "0x30D82F0", VA = "0x30D82F0")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x30D83CC", Offset = "0x30D83CC", VA = "0x30D83CC")]
	private static void SetCustomUV(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x30D8458", Offset = "0x30D8458", VA = "0x30D8458")]
	private static void SetCustomColor(RFShatter shatter, RFSurface interior)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0x30D7078", Offset = "0x30D7078", VA = "0x30D7078")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0x30D71DC", Offset = "0x30D71DC", VA = "0x30D71DC")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x30D7358", Offset = "0x30D7358", VA = "0x30D7358")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0x30D74D4", Offset = "0x30D74D4", VA = "0x30D74D4")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0x30D7788", Offset = "0x30D7788", VA = "0x30D7788")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0x30D868C", Offset = "0x30D868C", VA = "0x30D868C")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0x30D787C", Offset = "0x30D787C", VA = "0x30D787C")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x30D7BD8", Offset = "0x30D7BD8", VA = "0x30D7BD8")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x30D7E30", Offset = "0x30D7E30", VA = "0x30D7E30")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x30D8788", Offset = "0x30D8788", VA = "0x30D8788")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x30D7EFC", Offset = "0x30D7EFC", VA = "0x30D7EFC")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x30D8118", Offset = "0x30D8118", VA = "0x30D8118")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x30D6E78", Offset = "0x30D6E78", VA = "0x30D6E78")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x30D84A4", Offset = "0x30D84A4", VA = "0x30D84A4")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x30D85A8", Offset = "0x30D85A8", VA = "0x30D85A8")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x30D879C", Offset = "0x30D879C", VA = "0x30D879C")]
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
	[Address(RVA = "0x30D8A3C", Offset = "0x30D8A3C", VA = "0x30D8A3C")]
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
	[Address(RVA = "0x30D8A8C", Offset = "0x30D8A8C", VA = "0x30D8A8C")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x30D8AF4", Offset = "0x30D8AF4", VA = "0x30D8AF4")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x30D4A00", Offset = "0x30D4A00", VA = "0x30D4A00")]
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
	[Address(RVA = "0x30D8BE8", Offset = "0x30D8BE8", VA = "0x30D8BE8")]
	public RFSurface()
	{
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x30D8C14", Offset = "0x30D8C14", VA = "0x30D8C14")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x30D8C58", Offset = "0x30D8C58", VA = "0x30D8C58")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x30D54FC", Offset = "0x30D54FC", VA = "0x30D54FC")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x30D3380", Offset = "0x30D3380", VA = "0x30D3380")]
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
			[Address(RVA = "0x30DAFA4", Offset = "0x30DAFA4", VA = "0x30DAFA4", Slot = "4")]
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
			[Address(RVA = "0x30DAFEC", Offset = "0x30DAFEC", VA = "0x30DAFEC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x30D9A38", Offset = "0x30D9A38", VA = "0x30D9A38")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x30DAEAC", Offset = "0x30DAEAC", VA = "0x30DAEAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x30DAEB0", Offset = "0x30DAEB0", VA = "0x30DAEB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x30DAFAC", Offset = "0x30DAFAC", VA = "0x30DAFAC", Slot = "8")]
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
			[Address(RVA = "0x30DB19C", Offset = "0x30DB19C", VA = "0x30DB19C", Slot = "4")]
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
			[Address(RVA = "0x30DB1E4", Offset = "0x30DB1E4", VA = "0x30DB1E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x30D9A60", Offset = "0x30D9A60", VA = "0x30D9A60")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x30DAFF4", Offset = "0x30DAFF4", VA = "0x30DAFF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x30DAFF8", Offset = "0x30DAFF8", VA = "0x30DAFF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x30DB1A4", Offset = "0x30DB1A4", VA = "0x30DB1A4", Slot = "8")]
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
			[Address(RVA = "0x30DB2E4", Offset = "0x30DB2E4", VA = "0x30DB2E4", Slot = "4")]
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
			[Address(RVA = "0x30DB32C", Offset = "0x30DB32C", VA = "0x30DB32C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x30D9E18", Offset = "0x30D9E18", VA = "0x30D9E18")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x30DB1EC", Offset = "0x30DB1EC", VA = "0x30DB1EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x30DB1F0", Offset = "0x30DB1F0", VA = "0x30DB1F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x30DB2EC", Offset = "0x30DB2EC", VA = "0x30DB2EC", Slot = "8")]
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
			[Address(RVA = "0x30DB674", Offset = "0x30DB674", VA = "0x30DB674", Slot = "4")]
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
			[Address(RVA = "0x30DB6BC", Offset = "0x30DB6BC", VA = "0x30DB6BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x30DA834", Offset = "0x30DA834", VA = "0x30DA834")]
		[DebuggerHidden]
		public <AnimationCor>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x30DB334", Offset = "0x30DB334", VA = "0x30DB334", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x30DB338", Offset = "0x30DB338", VA = "0x30DB338", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x30DB67C", Offset = "0x30DB67C", VA = "0x30DB67C", Slot = "8")]
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
		[Address(RVA = "0x30DADEC", Offset = "0x30DADEC", VA = "0x30DADEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000049")]
	public bool ByLine
	{
		[Token(Token = "0x6000347")]
		[Address(RVA = "0x30D9FC4", Offset = "0x30D9FC4", VA = "0x30D9FC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x30D8EBC", Offset = "0x30D8EBC", VA = "0x30D8EBC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x30D932C", Offset = "0x30D932C", VA = "0x30D932C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x30D93C4", Offset = "0x30D93C4", VA = "0x30D93C4")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x30D94F8", Offset = "0x30D94F8", VA = "0x30D94F8")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x30D9508", Offset = "0x30D9508", VA = "0x30D9508")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x30D8F28", Offset = "0x30D8F28", VA = "0x30D8F28")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x30D915C", Offset = "0x30D915C", VA = "0x30D915C")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x30D9378", Offset = "0x30D9378", VA = "0x30D9378")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x30D951C", Offset = "0x30D951C", VA = "0x30D951C")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x30D9948", Offset = "0x30D9948", VA = "0x30D9948")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__47))]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x30D99BC", Offset = "0x30D99BC", VA = "0x30D99BC")]
	[IteratorStateMachine(typeof(<DelayedClusterCor>d__48))]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x30D9904", Offset = "0x30D9904", VA = "0x30D9904")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x30D974C", Offset = "0x30D974C", VA = "0x30D974C")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x30D9D9C", Offset = "0x30D9D9C", VA = "0x30D9D9C")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__51))]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x30D9C08", Offset = "0x30D9C08", VA = "0x30D9C08")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x30D9A88", Offset = "0x30D9A88", VA = "0x30D9A88")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x30D9E40", Offset = "0x30D9E40", VA = "0x30D9E40")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x30D9F1C", Offset = "0x30D9F1C", VA = "0x30D9F1C")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x30D9FD8", Offset = "0x30D9FD8", VA = "0x30D9FD8")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x30DA274", Offset = "0x30DA274", VA = "0x30DA274")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x30DA4A0", Offset = "0x30DA4A0", VA = "0x30DA4A0")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x30D9F5C", Offset = "0x30D9F5C", VA = "0x30D9F5C")]
	[IteratorStateMachine(typeof(<AnimationCor>d__59))]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x30DA85C", Offset = "0x30DA85C", VA = "0x30DA85C")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x30DA94C", Offset = "0x30DA94C", VA = "0x30DA94C")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x30DA9AC", Offset = "0x30DA9AC", VA = "0x30DA9AC")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x30DA9B4", Offset = "0x30DA9B4", VA = "0x30DA9B4")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x30DA9E8", Offset = "0x30DA9E8", VA = "0x30DA9E8")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x30DAD40", Offset = "0x30DAD40", VA = "0x30DAD40")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x30DAE08", Offset = "0x30DAE08", VA = "0x30DAE08")]
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
	[Address(RVA = "0x30DB6C4", Offset = "0x30DB6C4", VA = "0x30DB6C4")]
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
			[Address(RVA = "0x30DC58C", Offset = "0x30DC58C", VA = "0x30DC58C", Slot = "4")]
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
			[Address(RVA = "0x30DC5D4", Offset = "0x30DC5D4", VA = "0x30DC5D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x30DC040", Offset = "0x30DC040", VA = "0x30DC040")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x30DC4B8", Offset = "0x30DC4B8", VA = "0x30DC4B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x30DC4BC", Offset = "0x30DC4BC", VA = "0x30DC4BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x30DC594", Offset = "0x30DC594", VA = "0x30DC594", Slot = "8")]
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
		[Address(RVA = "0x30DC3BC", Offset = "0x30DC3BC", VA = "0x30DC3BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x30DB6CC", Offset = "0x30DB6CC", VA = "0x30DB6CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x30DB6D0", Offset = "0x30DB6D0", VA = "0x30DB6D0")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x30DB8D4", Offset = "0x30DB8D4", VA = "0x30DB8D4")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x30DB984", Offset = "0x30DB984", VA = "0x30DB984")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x30DB8D8", Offset = "0x30DB8D8", VA = "0x30DB8D8")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x30DB988", Offset = "0x30DB988", VA = "0x30DB988")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x30DBDDC", Offset = "0x30DBDDC", VA = "0x30DBDDC")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x30DBFD8", Offset = "0x30DBFD8", VA = "0x30DBFD8")]
	[IteratorStateMachine(typeof(<CooldownCor>d__31))]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x30DC068", Offset = "0x30DC068", VA = "0x30DC068")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x30DBEE0", Offset = "0x30DBEE0", VA = "0x30DBEE0")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x30DC090", Offset = "0x30DC090", VA = "0x30DC090")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x30DBC50", Offset = "0x30DBC50", VA = "0x30DBC50")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x30DBF90", Offset = "0x30DBF90", VA = "0x30DBF90")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x30DBB68", Offset = "0x30DBB68", VA = "0x30DBB68")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x30DC194", Offset = "0x30DC194", VA = "0x30DC194")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x30DC074", Offset = "0x30DC074", VA = "0x30DC074")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x30DC410", Offset = "0x30DC410", VA = "0x30DC410")]
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
		[Address(RVA = "0x30DDF64", Offset = "0x30DDF64", VA = "0x30DDF64")]
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
			[Address(RVA = "0x30DE650", Offset = "0x30DE650", VA = "0x30DE650", Slot = "4")]
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
			[Address(RVA = "0x30DE698", Offset = "0x30DE698", VA = "0x30DE698", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x30DC8E0", Offset = "0x30DC8E0", VA = "0x30DC8E0")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x30DE59C", Offset = "0x30DE59C", VA = "0x30DE59C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x30DE5A0", Offset = "0x30DE5A0", VA = "0x30DE5A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x30DE658", Offset = "0x30DE658", VA = "0x30DE658", Slot = "8")]
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
	[Address(RVA = "0x30DC5DC", Offset = "0x30DC5DC", VA = "0x30DC5DC")]
	private void Awake()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x30DC68C", Offset = "0x30DC68C", VA = "0x30DC68C")]
	private void Start()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x30DC704", Offset = "0x30DC704", VA = "0x30DC704")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x30DC6C0", Offset = "0x30DC6C0", VA = "0x30DC6C0")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x30DC878", Offset = "0x30DC878", VA = "0x30DC878")]
	[IteratorStateMachine(typeof(<ExplodeCor>d__37))]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x30DC770", Offset = "0x30DC770", VA = "0x30DC770")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x30DD54C", Offset = "0x30DD54C", VA = "0x30DD54C")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x30DC9AC", Offset = "0x30DC9AC", VA = "0x30DC9AC")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x30DC5E0", Offset = "0x30DC5E0", VA = "0x30DC5E0")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x30DDCDC", Offset = "0x30DDCDC", VA = "0x30DDCDC")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x30DDCF8", Offset = "0x30DDCF8", VA = "0x30DDCF8")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x30DC908", Offset = "0x30DC908", VA = "0x30DC908")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x30DD608", Offset = "0x30DD608", VA = "0x30DD608")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x30DD63C", Offset = "0x30DD63C", VA = "0x30DD63C")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x30DCA14", Offset = "0x30DCA14", VA = "0x30DCA14")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x30DCBB0", Offset = "0x30DCBB0", VA = "0x30DCBB0")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x30DCF08", Offset = "0x30DCF08", VA = "0x30DCF08")]
	private void Activate()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x30DD2E0", Offset = "0x30DD2E0", VA = "0x30DD2E0")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x30DDF6C", Offset = "0x30DDF6C", VA = "0x30DDF6C")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x30DE148", Offset = "0x30DE148", VA = "0x30DE148")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x30DE278", Offset = "0x30DE278", VA = "0x30DE278")]
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
	[Address(RVA = "0x30DE6A0", Offset = "0x30DE6A0", VA = "0x30DE6A0")]
	public void Extract()
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x30DE904", Offset = "0x30DE904", VA = "0x30DE904")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x30DE9B8", Offset = "0x30DE9B8", VA = "0x30DE9B8")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x30DF3A8", Offset = "0x30DF3A8", VA = "0x30DF3A8")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x30E0C90", Offset = "0x30E0C90", VA = "0x30E0C90")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x30DECB4", Offset = "0x30DECB4", VA = "0x30DECB4")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x30E1A60", Offset = "0x30E1A60", VA = "0x30E1A60")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x30E2058", Offset = "0x30E2058", VA = "0x30E2058")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x30E02AC", Offset = "0x30E02AC", VA = "0x30E02AC")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x30E2AA8", Offset = "0x30E2AA8", VA = "0x30E2AA8")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x30E008C", Offset = "0x30E008C", VA = "0x30E008C")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x30E345C", Offset = "0x30E345C", VA = "0x30E345C")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x30E28A4", Offset = "0x30E28A4", VA = "0x30E28A4")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x30DF270", Offset = "0x30DF270", VA = "0x30DF270")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x30DFC9C", Offset = "0x30DFC9C", VA = "0x30DFC9C")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x30E1858", Offset = "0x30E1858", VA = "0x30E1858")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x30E3584", Offset = "0x30E3584", VA = "0x30E3584")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x30E24EC", Offset = "0x30E24EC", VA = "0x30E24EC")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x30DFED0", Offset = "0x30DFED0", VA = "0x30DFED0")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x30E39A4", Offset = "0x30E39A4", VA = "0x30E39A4")]
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
	[Address(RVA = "0x30E3AF0", Offset = "0x30E3AF0", VA = "0x30E3AF0")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x30E3CA4", Offset = "0x30E3CA4", VA = "0x30E3CA4")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x30E43CC", Offset = "0x30E43CC", VA = "0x30E43CC")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x30D65BC", Offset = "0x30D65BC", VA = "0x30D65BC")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x30E4594", Offset = "0x30E4594", VA = "0x30E4594")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x30E4AD0", Offset = "0x30E4AD0", VA = "0x30E4AD0")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x30E4CDC", Offset = "0x30E4CDC", VA = "0x30E4CDC")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x30E4F04", Offset = "0x30E4F04", VA = "0x30E4F04")]
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
	[Address(RVA = "0x30E5234", Offset = "0x30E5234", VA = "0x30E5234")]
	public void Combine()
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x30E52F8", Offset = "0x30E52F8", VA = "0x30E52F8")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x30E6D3C", Offset = "0x30E6D3C", VA = "0x30E6D3C")]
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
			[Address(RVA = "0x30EBF8C", Offset = "0x30EBF8C", VA = "0x30EBF8C", Slot = "4")]
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
			[Address(RVA = "0x30EBFD4", Offset = "0x30EBFD4", VA = "0x30EBFD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x30EBEB4", Offset = "0x30EBEB4", VA = "0x30EBEB4")]
		[DebuggerHidden]
		public <ConnectivityCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x30EBEDC", Offset = "0x30EBEDC", VA = "0x30EBEDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x30EBEE0", Offset = "0x30EBEE0", VA = "0x30EBEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x30EBF94", Offset = "0x30EBF94", VA = "0x30EBF94", Slot = "8")]
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
			[Address(RVA = "0x30EC090", Offset = "0x30EC090", VA = "0x30EC090", Slot = "4")]
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
			[Address(RVA = "0x30EC0D8", Offset = "0x30EC0D8", VA = "0x30EC0D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x30EBFDC", Offset = "0x30EBFDC", VA = "0x30EBFDC")]
		[DebuggerHidden]
		public <ChildrenCor>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x30EC004", Offset = "0x30EC004", VA = "0x30EC004", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x30EC008", Offset = "0x30EC008", VA = "0x30EC008", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x30EC098", Offset = "0x30EC098", VA = "0x30EC098", Slot = "8")]
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
		[Address(RVA = "0x30E8B34", Offset = "0x30E8B34", VA = "0x30E8B34")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x30E6D64", Offset = "0x30E6D64", VA = "0x30E6D64")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x30E6E6C", Offset = "0x30E6E6C", VA = "0x30E6E6C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x30E6E78", Offset = "0x30E6E78", VA = "0x30E6E78")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x30E7044", Offset = "0x30E7044", VA = "0x30E7044")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x30E72E8", Offset = "0x30E72E8", VA = "0x30E72E8")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x30E79A0", Offset = "0x30E79A0", VA = "0x30E79A0")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x30E7A24", Offset = "0x30E7A24", VA = "0x30E7A24")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x30E7B84", Offset = "0x30E7B84", VA = "0x30E7B84")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x30E74B0", Offset = "0x30E74B0", VA = "0x30E74B0")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x30E7740", Offset = "0x30E7740", VA = "0x30E7740")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x30E83D0", Offset = "0x30E83D0", VA = "0x30E83D0")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x30E7C58", Offset = "0x30E7C58", VA = "0x30E7C58")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x30E7F10", Offset = "0x30E7F10", VA = "0x30E7F10")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x30E8498", Offset = "0x30E8498", VA = "0x30E8498")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x30E6FDC", Offset = "0x30E6FDC", VA = "0x30E6FDC")]
	[IteratorStateMachine(typeof(<ConnectivityCor>d__50))]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x30E8814", Offset = "0x30E8814", VA = "0x30E8814")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x30E8A18", Offset = "0x30E8A18", VA = "0x30E8A18")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x30E88FC", Offset = "0x30E88FC", VA = "0x30E88FC")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x30E8F20", Offset = "0x30E8F20", VA = "0x30E8F20")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x30E9444", Offset = "0x30E9444", VA = "0x30E9444")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x30E8BA0", Offset = "0x30E8BA0", VA = "0x30E8BA0")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x30E8D3C", Offset = "0x30E8D3C", VA = "0x30E8D3C")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x30E9184", Offset = "0x30E9184", VA = "0x30E9184")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x30E9260", Offset = "0x30E9260", VA = "0x30E9260")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x30EA1CC", Offset = "0x30EA1CC", VA = "0x30EA1CC")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x30E6F74", Offset = "0x30E6F74", VA = "0x30E6F74")]
	[IteratorStateMachine(typeof(<ChildrenCor>d__61))]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x30EA1D8", Offset = "0x30EA1D8", VA = "0x30EA1D8")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x30EA48C", Offset = "0x30EA48C", VA = "0x30EA48C")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x30E7648", Offset = "0x30E7648", VA = "0x30E7648")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x30EA4C0", Offset = "0x30EA4C0", VA = "0x30EA4C0")]
	public void Fracture()
	{
	}

	[Token(Token = "0x60003DE")]
	[Address(RVA = "0x30EA4CC", Offset = "0x30EA4CC", VA = "0x30EA4CC")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x30EA97C", Offset = "0x30EA97C", VA = "0x30EA97C")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x30EADE8", Offset = "0x30EADE8", VA = "0x30EADE8")]
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
		[Address(RVA = "0x30ECF28", Offset = "0x30ECF28", VA = "0x30ECF28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x30EC0E0", Offset = "0x30EC0E0", VA = "0x30EC0E0")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x30EC2DC", Offset = "0x30EC2DC", VA = "0x30EC2DC")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x30EC3B0", Offset = "0x30EC3B0", VA = "0x30EC3B0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x30EC91C", Offset = "0x30EC91C", VA = "0x30EC91C")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x30ECD48", Offset = "0x30ECD48", VA = "0x30ECD48")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x30ECA54", Offset = "0x30ECA54", VA = "0x30ECA54")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x30ECF7C", Offset = "0x30ECF7C", VA = "0x30ECF7C")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x30EC3C4", Offset = "0x30EC3C4", VA = "0x30EC3C4")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x30ED1F0", Offset = "0x30ED1F0", VA = "0x30ED1F0")]
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
		[Address(RVA = "0x30EDF3C", Offset = "0x30EDF3C", VA = "0x30EDF3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700005E")]
	public bool HasMaterials
	{
		[Token(Token = "0x6000405")]
		[Address(RVA = "0x30ED924", Offset = "0x30ED924", VA = "0x30ED924")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x30ED4C8", Offset = "0x30ED4C8", VA = "0x30ED4C8")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x30ED64C", Offset = "0x30ED64C", VA = "0x30ED64C")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x30ED720", Offset = "0x30ED720", VA = "0x30ED720")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x30ED978", Offset = "0x30ED978", VA = "0x30ED978")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x30EDD5C", Offset = "0x30EDD5C", VA = "0x30EDD5C")]
	public void Clean()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x30EDA90", Offset = "0x30EDA90", VA = "0x30EDA90")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x30EDF90", Offset = "0x30EDF90", VA = "0x30EDF90")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x30EE110", Offset = "0x30EE110", VA = "0x30EE110")]
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
			[Address(RVA = "0x30F083C", Offset = "0x30F083C", VA = "0x30F083C", Slot = "4")]
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
			[Address(RVA = "0x30F0884", Offset = "0x30F0884", VA = "0x30F0884", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x30EE290", Offset = "0x30EE290", VA = "0x30EE290")]
		[DebuggerHidden]
		public <StartShootCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x30F075C", Offset = "0x30F075C", VA = "0x30F075C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x30F0760", Offset = "0x30F0760", VA = "0x30F0760", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x30F0844", Offset = "0x30F0844", VA = "0x30F0844", Slot = "8")]
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
			[Address(RVA = "0x30F0978", Offset = "0x30F0978", VA = "0x30F0978", Slot = "4")]
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
			[Address(RVA = "0x30F09C0", Offset = "0x30F09C0", VA = "0x30F09C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x30EEB50", Offset = "0x30EEB50", VA = "0x30EEB50")]
		[DebuggerHidden]
		public <BurstCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x30F088C", Offset = "0x30F088C", VA = "0x30F088C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x30F0890", Offset = "0x30F0890", VA = "0x30F0890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x30F0980", Offset = "0x30F0980", VA = "0x30F0980", Slot = "8")]
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
		[Address(RVA = "0x30EE338", Offset = "0x30EE338", VA = "0x30EE338")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x30EE1F8", Offset = "0x30EE1F8", VA = "0x30EE1F8")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x30EE228", Offset = "0x30EE228", VA = "0x30EE228")]
	[IteratorStateMachine(typeof(<StartShootCor>d__29))]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x30EE2B8", Offset = "0x30EE2B8", VA = "0x30EE2B8")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x30EE2C0", Offset = "0x30EE2C0", VA = "0x30EE2C0")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x30EEAB8", Offset = "0x30EEAB8", VA = "0x30EEAB8")]
	public void Burst()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x30EEAE8", Offset = "0x30EEAE8", VA = "0x30EEAE8")]
	[IteratorStateMachine(typeof(<BurstCor>d__33))]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0x30EE514", Offset = "0x30EE514", VA = "0x30EE514")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0x30EF2BC", Offset = "0x30EF2BC", VA = "0x30EF2BC")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0x30EFAB4", Offset = "0x30EFAB4", VA = "0x30EFAB4")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0x30F0038", Offset = "0x30F0038", VA = "0x30F0038")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0x30EF064", Offset = "0x30EF064", VA = "0x30EF064")]
	private RayfireRigid ApplyDamage(RayfireRigid scr, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x30EEB78", Offset = "0x30EEB78", VA = "0x30EEB78")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x30EED4C", Offset = "0x30EED4C", VA = "0x30EED4C")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x30EEED8", Offset = "0x30EEED8", VA = "0x30EEED8")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x30F023C", Offset = "0x30F023C", VA = "0x30F023C")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x30F05F8", Offset = "0x30F05F8", VA = "0x30F05F8")]
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
		[Address(RVA = "0x30F1234", Offset = "0x30F1234", VA = "0x30F1234")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x30F09C8", Offset = "0x30F09C8", VA = "0x30F09C8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x30F0C08", Offset = "0x30F0C08", VA = "0x30F0C08")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x30F0C10", Offset = "0x30F0C10", VA = "0x30F0C10")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x30F09CC", Offset = "0x30F09CC", VA = "0x30F09CC")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x30F0EC0", Offset = "0x30F0EC0", VA = "0x30F0EC0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x30F0EF4", Offset = "0x30F0EF4", VA = "0x30F0EF4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x30F0C14", Offset = "0x30F0C14", VA = "0x30F0C14")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x30F0F44", Offset = "0x30F0F44", VA = "0x30F0F44")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x30F10DC", Offset = "0x30F10DC", VA = "0x30F10DC")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x30F0FC4", Offset = "0x30F0FC4", VA = "0x30F0FC4")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x30F0CD0", Offset = "0x30F0CD0", VA = "0x30F0CD0")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x30F0E00", Offset = "0x30F0E00", VA = "0x30F0E00")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x30F12E4", Offset = "0x30F12E4", VA = "0x30F12E4")]
	public void DestroyStorage()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x30F1300", Offset = "0x30F1300", VA = "0x30F1300")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x30F14F8", Offset = "0x30F14F8", VA = "0x30F14F8")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x30F162C", Offset = "0x30F162C", VA = "0x30F162C")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x30F1860", Offset = "0x30F1860", VA = "0x30F1860")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x30F1918", Offset = "0x30F1918", VA = "0x30F1918")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x30F171C", Offset = "0x30F171C", VA = "0x30F171C")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x30F1970", Offset = "0x30F1970", VA = "0x30F1970")]
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
	[Address(RVA = "0x30F1AF4", Offset = "0x30F1AF4", VA = "0x30F1AF4")]
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
			[Address(RVA = "0x30F31A4", Offset = "0x30F31A4", VA = "0x30F31A4", Slot = "4")]
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
			[Address(RVA = "0x30F31EC", Offset = "0x30F31EC", VA = "0x30F31EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x30F2CB8", Offset = "0x30F2CB8", VA = "0x30F2CB8")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x30F2D5C", Offset = "0x30F2D5C", VA = "0x30F2D5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x30F2D60", Offset = "0x30F2D60", VA = "0x30F2D60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x30F31AC", Offset = "0x30F31AC", VA = "0x30F31AC", Slot = "8")]
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
	[Address(RVA = "0x30F1D10", Offset = "0x30F1D10", VA = "0x30F1D10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x30F2038", Offset = "0x30F2038", VA = "0x30F2038")]
	private void Start()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x30F2088", Offset = "0x30F2088", VA = "0x30F2088")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x30F1D14", Offset = "0x30F1D14", VA = "0x30F1D14")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x30F2394", Offset = "0x30F2394", VA = "0x30F2394")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x30F2620", Offset = "0x30F2620", VA = "0x30F2620")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x30F2C24", Offset = "0x30F2C24", VA = "0x30F2C24")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x30F22DC", Offset = "0x30F22DC", VA = "0x30F22DC")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x30F2C50", Offset = "0x30F2C50", VA = "0x30F2C50")]
	[IteratorStateMachine(typeof(<RecordCor>d__30))]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x30F2CE0", Offset = "0x30F2CE0", VA = "0x30F2CE0")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x30F2348", Offset = "0x30F2348", VA = "0x30F2348")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x30F2CE8", Offset = "0x30F2CE8", VA = "0x30F2CE8")]
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
			[Address(RVA = "0x30F3B20", Offset = "0x30F3B20", VA = "0x30F3B20", Slot = "4")]
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
			[Address(RVA = "0x30F3B68", Offset = "0x30F3B68", VA = "0x30F3B68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x30F3740", Offset = "0x30F3740", VA = "0x30F3740")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x30F3790", Offset = "0x30F3790", VA = "0x30F3790", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x30F3794", Offset = "0x30F3794", VA = "0x30F3794", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x30F3B28", Offset = "0x30F3B28", VA = "0x30F3B28", Slot = "8")]
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
			[Address(RVA = "0x30F3EC4", Offset = "0x30F3EC4", VA = "0x30F3EC4", Slot = "4")]
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
			[Address(RVA = "0x30F3F0C", Offset = "0x30F3F0C", VA = "0x30F3F0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x30F3768", Offset = "0x30F3768", VA = "0x30F3768")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x30F3B70", Offset = "0x30F3B70", VA = "0x30F3B70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x30F3B74", Offset = "0x30F3B74", VA = "0x30F3B74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x30F3ECC", Offset = "0x30F3ECC", VA = "0x30F3ECC", Slot = "8")]
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
	[Address(RVA = "0x30F31F4", Offset = "0x30F31F4", VA = "0x30F31F4")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x30F323C", Offset = "0x30F323C", VA = "0x30F323C")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x30F3234", Offset = "0x30F3234", VA = "0x30F3234")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x30F3284", Offset = "0x30F3284", VA = "0x30F3284")]
	private void Start()
	{
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x30F3578", Offset = "0x30F3578", VA = "0x30F3578")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x30F357C", Offset = "0x30F357C", VA = "0x30F357C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x30F3354", Offset = "0x30F3354", VA = "0x30F3354")]
	public void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x30F3650", Offset = "0x30F3650", VA = "0x30F3650")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x30F3580", Offset = "0x30F3580", VA = "0x30F3580")]
	[IteratorStateMachine(typeof(<RestrictionDistanceCor>d__22))]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x30F35E8", Offset = "0x30F35E8", VA = "0x30F35E8")]
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
		[Address(RVA = "0x30F01E8", Offset = "0x30F01E8", VA = "0x30F01E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public bool HasMeshes
	{
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x30F7788", Offset = "0x30F7788", VA = "0x30F7788")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006D")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600048F")]
		[Address(RVA = "0x30F77A8", Offset = "0x30F77A8", VA = "0x30F77A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000490")]
		[Address(RVA = "0x30F77C8", Offset = "0x30F77C8", VA = "0x30F77C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x30F781C", Offset = "0x30F781C", VA = "0x30F781C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasSlices
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x30F7304", Offset = "0x30F7304", VA = "0x30F7304")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000071")]
	public bool IsCluster
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x30F7870", Offset = "0x30F7870", VA = "0x30F7870")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	public bool Visible
	{
		[Token(Token = "0x6000494")]
		[Address(RVA = "0x30F6428", Offset = "0x30F6428", VA = "0x30F6428")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000495")]
		[Address(RVA = "0x30F7884", Offset = "0x30F7884", VA = "0x30F7884")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x30F3F14", Offset = "0x30F3F14", VA = "0x30F3F14")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x30F3FD8", Offset = "0x30F3FD8", VA = "0x30F3FD8")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x30F4030", Offset = "0x30F4030", VA = "0x30F4030")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x30F4B0C", Offset = "0x30F4B0C", VA = "0x30F4B0C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x30F4B54", Offset = "0x30F4B54", VA = "0x30F4B54")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x30F4B9C", Offset = "0x30F4B9C", VA = "0x30F4B9C")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x30F4D64", Offset = "0x30F4D64", VA = "0x30F4D64")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x30F41FC", Offset = "0x30F41FC", VA = "0x30F41FC")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x30F472C", Offset = "0x30F472C", VA = "0x30F472C")]
	public void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x30F4C44", Offset = "0x30F4C44", VA = "0x30F4C44")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x30F4424", Offset = "0x30F4424", VA = "0x30F4424")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x30F521C", Offset = "0x30F521C", VA = "0x30F521C")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x30F5408", Offset = "0x30F5408", VA = "0x30F5408")]
	private void AddMeshRootRigid(Transform tm)
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x30F59BC", Offset = "0x30F59BC", VA = "0x30F59BC")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x30F4E0C", Offset = "0x30F4E0C", VA = "0x30F4E0C")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x30F49D4", Offset = "0x30F49D4", VA = "0x30F49D4")]
	public void SetObjectType()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x30F48CC", Offset = "0x30F48CC", VA = "0x30F48CC")]
	public void Default()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x30F5D60", Offset = "0x30F5D60", VA = "0x30F5D60")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x30F4A10", Offset = "0x30F4A10", VA = "0x30F4A10")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x30F5F08", Offset = "0x30F5F08", VA = "0x30F5F08")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0x30F3F40", Offset = "0x30F3F40", VA = "0x30F3F40")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x30F5FEC", Offset = "0x30F5FEC", VA = "0x30F5FEC", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x30F60E0", Offset = "0x30F60E0", VA = "0x30F60E0", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x30F6200", Offset = "0x30F6200", VA = "0x30F6200")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x30F6350", Offset = "0x30F6350", VA = "0x30F6350", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x30F64F4", Offset = "0x30F64F4", VA = "0x30F64F4")]
	public void Demolish()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x30F5AB8", Offset = "0x30F5AB8", VA = "0x30F5AB8")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x30F6DBC", Offset = "0x30F6DBC", VA = "0x30F6DBC")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x30F6F0C", Offset = "0x30F6F0C", VA = "0x30F6F0C")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x30F6F88", Offset = "0x30F6F88", VA = "0x30F6F88")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x30F704C", Offset = "0x30F704C", VA = "0x30F704C")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x30F70D8", Offset = "0x30F70D8", VA = "0x30F70D8")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x30F7364", Offset = "0x30F7364", VA = "0x30F7364")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x30F7398", Offset = "0x30F7398", VA = "0x30F7398")]
	[ContextMenu("SaveInitTransform")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x30F01E0", Offset = "0x30F01E0", VA = "0x30F01E0")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f, [Optional] Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x30EFF2C", Offset = "0x30EFF2C", VA = "0x30EFF2C")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x30F7578", Offset = "0x30F7578", VA = "0x30F7578")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x30F7620", Offset = "0x30F7620", VA = "0x30F7620")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x30F7628", Offset = "0x30F7628", VA = "0x30F7628")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x30F7680", Offset = "0x30F7680", VA = "0x30F7680")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x30F76D8", Offset = "0x30F76D8", VA = "0x30F76D8")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x30F7730", Offset = "0x30F7730", VA = "0x30F7730")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x30F7908", Offset = "0x30F7908", VA = "0x30F7908")]
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
	[Address(RVA = "0x30F7BB0", Offset = "0x30F7BB0", VA = "0x30F7BB0")]
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
		[Address(RVA = "0x30FAFD8", Offset = "0x30FAFD8", VA = "0x30FAFD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000075")]
	public bool HasDebris
	{
		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x30FB02C", Offset = "0x30FB02C", VA = "0x30FB02C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000076")]
	public bool HasDust
	{
		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x30FB080", Offset = "0x30FB080", VA = "0x30FB080")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000077")]
	public bool HasUny
	{
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x30FA998", Offset = "0x30FA998", VA = "0x30FA998")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x30F7C48", Offset = "0x30F7C48", VA = "0x30F7C48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x30F7D5C", Offset = "0x30F7D5C", VA = "0x30F7D5C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x30F7D88", Offset = "0x30F7D88", VA = "0x30F7D88")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x30F7C78", Offset = "0x30F7C78", VA = "0x30F7C78")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x30F8208", Offset = "0x30F8208", VA = "0x30F8208")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x30F8450", Offset = "0x30F8450", VA = "0x30F8450")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x30F8458", Offset = "0x30F8458", VA = "0x30F8458")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x30F85E0", Offset = "0x30F85E0", VA = "0x30F85E0")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x30F7EC8", Offset = "0x30F7EC8", VA = "0x30F7EC8")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x30F89F8", Offset = "0x30F89F8", VA = "0x30F89F8")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x30F9828", Offset = "0x30F9828", VA = "0x30F9828")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x30F8A90", Offset = "0x30F8A90", VA = "0x30F8A90")]
	private void SetShards()
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x30F9D50", Offset = "0x30F9D50", VA = "0x30F9D50")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x30F9FF8", Offset = "0x30F9FF8", VA = "0x30F9FF8")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x30FA15C", Offset = "0x30FA15C", VA = "0x30FA15C")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x30FA2B8", Offset = "0x30FA2B8", VA = "0x30FA2B8")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x30FA3F8", Offset = "0x30FA3F8", VA = "0x30FA3F8")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004A9")]
	[Address(RVA = "0x30F9400", Offset = "0x30F9400", VA = "0x30F9400")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004AA")]
	[Address(RVA = "0x30F9908", Offset = "0x30F9908", VA = "0x30F9908")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x30F9AE8", Offset = "0x30F9AE8", VA = "0x30F9AE8")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x30F95FC", Offset = "0x30F95FC", VA = "0x30F95FC")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x30F7DD0", Offset = "0x30F7DD0", VA = "0x30F7DD0")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x30FAE9C", Offset = "0x30FAE9C", VA = "0x30FAE9C")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x30FAF5C", Offset = "0x30FAF5C", VA = "0x30FAF5C")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x30FA4F8", Offset = "0x30FA4F8", VA = "0x30FA4F8")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x30FB0D4", Offset = "0x30FB0D4", VA = "0x30FB0D4")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x30FB0E0", Offset = "0x30FB0E0", VA = "0x30FB0E0")]
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
	[Address(RVA = "0x30FB29C", Offset = "0x30FB29C", VA = "0x30FB29C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x30FB418", Offset = "0x30FB418", VA = "0x30FB418")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x30FB4B8", Offset = "0x30FB4B8", VA = "0x30FB4B8")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x30FB88C", Offset = "0x30FB88C", VA = "0x30FB88C")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x30FBAE8", Offset = "0x30FBAE8", VA = "0x30FBAE8")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x30FBD90", Offset = "0x30FBD90", VA = "0x30FBD90")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x30FBF08", Offset = "0x30FBF08", VA = "0x30FBF08")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x30FC3DC", Offset = "0x30FC3DC", VA = "0x30FC3DC")]
	private List<GameObject> CreateFragments([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x30FD104", Offset = "0x30FD104", VA = "0x30FD104")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x30FD468", Offset = "0x30FD468", VA = "0x30FD468")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x30FB2A0", Offset = "0x30FB2A0", VA = "0x30FB2A0")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x60004C3")]
	[Address(RVA = "0x30FC100", Offset = "0x30FC100", VA = "0x30FC100")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x60004C4")]
	[Address(RVA = "0x30FD610", Offset = "0x30FD610", VA = "0x30FD610")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x60004C5")]
	[Address(RVA = "0x30F579C", Offset = "0x30F579C", VA = "0x30F579C")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60004C6")]
	[Address(RVA = "0x30FD8C0", Offset = "0x30FD8C0", VA = "0x30FD8C0")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x60004C7")]
	[Address(RVA = "0x30FCD80", Offset = "0x30FCD80", VA = "0x30FCD80")]
	private void SizeLimitation()
	{
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x30FCF04", Offset = "0x30FCF04", VA = "0x30FCF04")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x30FCFF4", Offset = "0x30FCFF4", VA = "0x30FCFF4")]
	private void TriangleLimitation()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x30FDB08", Offset = "0x30FDB08", VA = "0x30FDB08")]
	private void LimitationFragment(int ind)
	{
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x30FDE48", Offset = "0x30FDE48", VA = "0x30FDE48")]
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
	[Address(RVA = "0x30FE268", Offset = "0x30FE268", VA = "0x30FE268")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x30FE294", Offset = "0x30FE294", VA = "0x30FE294")]
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
	[Address(RVA = "0x30FE29C", Offset = "0x30FE29C", VA = "0x30FE29C")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x30FE2CC", Offset = "0x30FE2CC", VA = "0x30FE2CC")]
	private void Start()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x30FE2D0", Offset = "0x30FE2D0", VA = "0x30FE2D0")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x30FE424", Offset = "0x30FE424", VA = "0x30FE424")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x30FE940", Offset = "0x30FE940", VA = "0x30FE940")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x30FEA10", Offset = "0x30FEA10", VA = "0x30FEA10")]
	private void CreateSource(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x30FEC64", Offset = "0x30FEC64", VA = "0x30FEC64")]
	public void OnCollisionEnter(Collision coll)
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x30FEC68", Offset = "0x30FEC68", VA = "0x30FEC68")]
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
		[Address(RVA = "0x31004F4", Offset = "0x31004F4", VA = "0x31004F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000079")]
	private bool HasShards
	{
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x3100548", Offset = "0x3100548", VA = "0x3100548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700007A")]
	public Vector3 Extents
	{
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x30FF448", Offset = "0x30FF448", VA = "0x30FF448")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x30FEEA0", Offset = "0x30FEEA0", VA = "0x30FEEA0")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x30FEF78", Offset = "0x30FEF78", VA = "0x30FEF78")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x30FF2E8", Offset = "0x30FF2E8", VA = "0x30FF2E8")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x30FF4EC", Offset = "0x30FF4EC", VA = "0x30FF4EC")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x60004DB")]
	[Address(RVA = "0x30F58FC", Offset = "0x30F58FC", VA = "0x30F58FC")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60004DC")]
	[Address(RVA = "0x30FF510", Offset = "0x30FF510", VA = "0x30FF510")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60004DD")]
	[Address(RVA = "0x30FF60C", Offset = "0x30FF60C", VA = "0x30FF60C")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x30FF9E8", Offset = "0x30FF9E8", VA = "0x30FF9E8")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x30FF908", Offset = "0x30FF908", VA = "0x30FF908")]
	public static void SetMeshRootUnyState(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x30FFB04", Offset = "0x30FFB04", VA = "0x30FFB04")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x30FFCF8", Offset = "0x30FFCF8", VA = "0x30FFCF8")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x30F5C9C", Offset = "0x30F5C9C", VA = "0x30F5C9C")]
	public static void ResetMeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x30F66F0", Offset = "0x30F66F0", VA = "0x30F66F0")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x30FFF7C", Offset = "0x30FFF7C", VA = "0x30FFF7C")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x60004E5")]
	[Address(RVA = "0x30FFFE8", Offset = "0x30FFFE8", VA = "0x30FFFE8")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x30FA9EC", Offset = "0x30FA9EC", VA = "0x30FA9EC")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x30FADB4", Offset = "0x30FADB4", VA = "0x30FADB4")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x3100148", Offset = "0x3100148", VA = "0x3100148")]
	public void Activate()
	{
	}

	[Token(Token = "0x60004EC")]
	[Address(RVA = "0x310059C", Offset = "0x310059C", VA = "0x310059C")]
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
			[Address(RVA = "0x31019EC", Offset = "0x31019EC", VA = "0x31019EC", Slot = "4")]
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
			[Address(RVA = "0x3101A34", Offset = "0x3101A34", VA = "0x3101A34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x31006AC", Offset = "0x31006AC", VA = "0x31006AC")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x31018DC", Offset = "0x31018DC", VA = "0x31018DC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x31018E0", Offset = "0x31018E0", VA = "0x31018E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x31019F4", Offset = "0x31019F4", VA = "0x31019F4", Slot = "8")]
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
			[Address(RVA = "0x3101B60", Offset = "0x3101B60", VA = "0x3101B60", Slot = "4")]
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
			[Address(RVA = "0x3101BA8", Offset = "0x3101BA8", VA = "0x3101BA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x310073C", Offset = "0x310073C", VA = "0x310073C")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x3101A3C", Offset = "0x3101A3C", VA = "0x3101A3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x3101A40", Offset = "0x3101A40", VA = "0x3101A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x3101B68", Offset = "0x3101B68", VA = "0x3101B68", Slot = "8")]
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
	[Address(RVA = "0x31005C4", Offset = "0x31005C4", VA = "0x31005C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x31005C8", Offset = "0x31005C8", VA = "0x31005C8")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x3100644", Offset = "0x3100644", VA = "0x3100644")]
	[IteratorStateMachine(typeof(<VortexForceCor>d__50))]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x31006D4", Offset = "0x31006D4", VA = "0x31006D4")]
	[IteratorStateMachine(typeof(<SetCollidersCor>d__51))]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x3100764", Offset = "0x3100764", VA = "0x3100764")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x310079C", Offset = "0x310079C", VA = "0x310079C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x3100890", Offset = "0x3100890", VA = "0x3100890")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x3100994", Offset = "0x3100994", VA = "0x3100994")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x3100BBC", Offset = "0x3100BBC", VA = "0x3100BBC")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x3101284", Offset = "0x3101284", VA = "0x3101284")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x3101488", Offset = "0x3101488", VA = "0x3101488")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x31015BC", Offset = "0x31015BC", VA = "0x31015BC")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x31016E8", Offset = "0x31016E8", VA = "0x31016E8")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004FA")]
	[Address(RVA = "0x31013B8", Offset = "0x31013B8", VA = "0x31013B8")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004FB")]
	[Address(RVA = "0x31017C8", Offset = "0x31017C8", VA = "0x31017C8")]
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
			[Address(RVA = "0x31029C4", Offset = "0x31029C4", VA = "0x31029C4", Slot = "4")]
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
			[Address(RVA = "0x3102A0C", Offset = "0x3102A0C", VA = "0x3102A0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x3101C98", Offset = "0x3101C98", VA = "0x3101C98")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x3102904", Offset = "0x3102904", VA = "0x3102904", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x3102908", Offset = "0x3102908", VA = "0x3102908", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x31029CC", Offset = "0x31029CC", VA = "0x31029CC", Slot = "8")]
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
	[Address(RVA = "0x3101BB0", Offset = "0x3101BB0", VA = "0x3101BB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000509")]
	[Address(RVA = "0x3101BB4", Offset = "0x3101BB4", VA = "0x3101BB4")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x600050A")]
	[Address(RVA = "0x3101C30", Offset = "0x3101C30", VA = "0x3101C30")]
	[IteratorStateMachine(typeof(<WindForceCor>d__25))]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x600050B")]
	[Address(RVA = "0x3101CC0", Offset = "0x3101CC0", VA = "0x3101CC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600050C")]
	[Address(RVA = "0x3101CE0", Offset = "0x3101CE0", VA = "0x3101CE0")]
	private void Reset()
	{
	}

	[Token(Token = "0x600050D")]
	[Address(RVA = "0x3101CEC", Offset = "0x3101CEC", VA = "0x3101CEC")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600050E")]
	[Address(RVA = "0x3101EB0", Offset = "0x3101EB0", VA = "0x3101EB0")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600050F")]
	[Address(RVA = "0x3101F04", Offset = "0x3101F04", VA = "0x3101F04")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x6000510")]
	[Address(RVA = "0x310212C", Offset = "0x310212C", VA = "0x310212C")]
	private void SetForce()
	{
	}

	[Token(Token = "0x6000511")]
	[Address(RVA = "0x310247C", Offset = "0x310247C", VA = "0x310247C")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x31024D0", Offset = "0x31024D0", VA = "0x31024D0")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x3102620", Offset = "0x3102620", VA = "0x3102620")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000514")]
	[Address(RVA = "0x310242C", Offset = "0x310242C", VA = "0x310242C")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x3102758", Offset = "0x3102758", VA = "0x3102758")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000516")]
	[Address(RVA = "0x310279C", Offset = "0x310279C", VA = "0x310279C")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x31025EC", Offset = "0x31025EC", VA = "0x31025EC")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x3102454", Offset = "0x3102454", VA = "0x3102454")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x31023E4", Offset = "0x31023E4", VA = "0x31023E4")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x3102818", Offset = "0x3102818", VA = "0x3102818")]
	public RayfireWind()
	{
	}
}
