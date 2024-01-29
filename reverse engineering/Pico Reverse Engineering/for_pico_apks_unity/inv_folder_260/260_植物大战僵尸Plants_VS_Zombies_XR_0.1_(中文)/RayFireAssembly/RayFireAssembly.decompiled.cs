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
	[Address(RVA = "0xDE9714", Offset = "0xDE9714", VA = "0xDE9714")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xDE9760", Offset = "0xDE9760", VA = "0xDE9760")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xDE9ABC", Offset = "0xDE9ABC", VA = "0xDE9ABC")]
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
	[Address(RVA = "0xE8A860", Offset = "0xE8A860", VA = "0xE8A860")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xE823CC", Offset = "0xE823CC", VA = "0xE823CC")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xE83BB4", Offset = "0xE83BB4", VA = "0xE83BB4")]
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
	[Address(RVA = "0xDF1790", Offset = "0xDF1790", VA = "0xDF1790")]
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
		[Token(Token = "0x6000009")]
		[Address(RVA = "0xDF1844", Offset = "0xDF1844", VA = "0xDF1844")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xDF17B0", Offset = "0xDF17B0", VA = "0xDF17B0")]
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

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xDF18F8", Offset = "0xDF18F8", VA = "0xDF18F8")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xDF1E5C", Offset = "0xDF1E5C", VA = "0xDF1E5C")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xDF2228", Offset = "0xDF2228", VA = "0xDF2228")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xDF22D8", Offset = "0xDF22D8", VA = "0xDF22D8")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xDF2388", Offset = "0xDF2388", VA = "0xDF2388")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xDF243C", Offset = "0xDF243C", VA = "0xDF243C")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xDF24EC", Offset = "0xDF24EC", VA = "0xDF24EC")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xDF25A4", Offset = "0xDF25A4", VA = "0xDF25A4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534EB0", Offset = "0x534EB0")]
	private sealed class <StartPoolingCor>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingParticles <>4__this;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1259080", Offset = "0x1259080", VA = "0x1259080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x12590C8", Offset = "0x12590C8", VA = "0x12590C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1258ECC", Offset = "0x1258ECC", VA = "0x1258ECC")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1258EF8", Offset = "0x1258EF8", VA = "0x1258EF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1258EFC", Offset = "0x1258EFC", VA = "0x1258EFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1259088", Offset = "0x1259088", VA = "0x1259088", Slot = "8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535A40", Offset = "0x535A40")]
	public int capacity;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int poolRate;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public ParticleSystem poolInstance;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Transform poolRoot;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public List<ParticleSystem> poolList;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xE7CACC", Offset = "0xE7CACC", VA = "0xE7CACC")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xE7CB64", Offset = "0xE7CB64", VA = "0xE7CB64")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xE7CC8C", Offset = "0xE7CC8C", VA = "0xE7CC8C")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xE7CDB8", Offset = "0xE7CDB8", VA = "0xE7CDB8")]
	public static ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xE7CE70", Offset = "0xE7CE70", VA = "0xE7CE70")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xE7CF20", Offset = "0xE7CF20", VA = "0xE7CF20")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xE7CFE8", Offset = "0xE7CFE8", VA = "0xE7CFE8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537740", Offset = "0x537740")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534EC0", Offset = "0x534EC0")]
	private sealed class <StartPoolingCor>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPoolingFragment <>4__this;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform manTm;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1258E7C", Offset = "0x1258E7C", VA = "0x1258E7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1258EC4", Offset = "0x1258EC4", VA = "0x1258EC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1258CCC", Offset = "0x1258CCC", VA = "0x1258CCC")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1258CF8", Offset = "0x1258CF8", VA = "0x1258CF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1258CFC", Offset = "0x1258CFC", VA = "0x1258CFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1258E84", Offset = "0x1258E84", VA = "0x1258E84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535AAC", Offset = "0x535AAC")]
	public int capacity;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int poolRate;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RayfireRigid poolInstance;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform poolRoot;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RayfireRigid> poolList;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool inProgress;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xE7C3F0", Offset = "0xE7C3F0", VA = "0xE7C3F0")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xE7C488", Offset = "0xE7C488", VA = "0xE7C488")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xE7C5B0", Offset = "0xE7C5B0", VA = "0xE7C5B0")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xE7C6C8", Offset = "0xE7C6C8", VA = "0xE7C6C8")]
	public static RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xE7C8C4", Offset = "0xE7C8C4", VA = "0xE7C8C4")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xE7C970", Offset = "0xE7C970", VA = "0xE7C970")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xE7CA38", Offset = "0xE7CA38", VA = "0xE7CA38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5377F0", Offset = "0x5377F0")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534ED0", Offset = "0x534ED0")]
	private sealed class <StorageCor>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFStorage <>4__this;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1259CF4", Offset = "0x1259CF4", VA = "0x1259CF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1259D3C", Offset = "0x1259D3C", VA = "0x1259D3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1259A2C", Offset = "0x1259A2C", VA = "0x1259A2C")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1259A58", Offset = "0x1259A58", VA = "0x1259A58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1259A5C", Offset = "0x1259A5C", VA = "0x1259A5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1259CFC", Offset = "0x1259CFC", VA = "0x1259CFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> storageList;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform storageRoot;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool inProgress;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float rate;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xE86634", Offset = "0xE86634", VA = "0xE86634")]
	public RFStorage()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xE866C0", Offset = "0xE866C0", VA = "0xE866C0")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xE86804", Offset = "0xE86804", VA = "0xE86804")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5378A0", Offset = "0x5378A0")]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xE8687C", Offset = "0xE8687C", VA = "0xE8687C")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xE86908", Offset = "0xE86908", VA = "0xE86908")]
	public void DestroyAll()
	{
	}
}
[Serializable]
[Token(Token = "0x200000E")]
public class RFCluster : IComparable<RFCluster>
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tm;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public int depth;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 pos;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion rot;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Vector3 scl;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public bool demolishable;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public List<RFShard> shards;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float areaCollapse;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float minimumArea;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float maximumArea;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float sizeCollapse;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float minimumSize;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public float maximumSize;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int randomCollapse;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public int randomSeed;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public bool cachedHost;

	[NonSerialized]
	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool initialized;

	[NonSerialized]
	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public RFCluster mainCluster;

	[NonSerialized]
	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFCluster> childClusters;

	[NonSerialized]
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFCluster> neibClusters;

	[NonSerialized]
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<float> neibArea;

	[NonSerialized]
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<float> neibPerc;

	[NonSerialized]
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<RFShard> newClusterShards;

	[Token(Token = "0x17000008")]
	public bool HasChildClusters
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0xFFDE94", Offset = "0xFFDE94", VA = "0xFFDE94")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x1001C28", Offset = "0x1001C28", VA = "0x1001C28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x1001CD4", Offset = "0x1001CD4", VA = "0x1001CD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xFFEF3C", Offset = "0xFFEF3C", VA = "0xFFEF3C")]
	public RFCluster()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xFFC074", Offset = "0xFFC074", VA = "0xFFC074")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xFFF07C", Offset = "0xFFF07C", VA = "0xFFF07C", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xFFC404", Offset = "0xFFC404", VA = "0xFFC404")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xFFF100", Offset = "0xFFF100", VA = "0xFFF100")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xFFF370", Offset = "0xFFF370", VA = "0xFFF370")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xFFF5B0", Offset = "0xFFF5B0", VA = "0xFFF5B0")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xFFFE34", Offset = "0xFFFE34", VA = "0xFFFE34")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xFFFB5C", Offset = "0xFFFB5C", VA = "0xFFFB5C")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x10003CC", Offset = "0x10003CC", VA = "0x10003CC")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xFFFCE0", Offset = "0xFFFCE0", VA = "0xFFFCE0")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x100058C", Offset = "0x100058C", VA = "0x100058C")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x1000CA8", Offset = "0x1000CA8", VA = "0x1000CA8")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x100072C", Offset = "0x100072C", VA = "0x100072C")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x1000E8C", Offset = "0x1000E8C", VA = "0x1000E8C")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x1001344", Offset = "0x1001344", VA = "0x1001344")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x1000484", Offset = "0x1000484", VA = "0x1000484")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x100188C", Offset = "0x100188C", VA = "0x100188C")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x10002F8", Offset = "0x10002F8", VA = "0x10002F8")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x10019FC", Offset = "0x10019FC", VA = "0x10019FC")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x1001AF4", Offset = "0x1001AF4", VA = "0x1001AF4")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x1001D90", Offset = "0x1001D90", VA = "0x1001D90")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x1001F50", Offset = "0x1001F50", VA = "0x1001F50")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x1002094", Offset = "0x1002094", VA = "0x1002094")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x1002448", Offset = "0x1002448", VA = "0x1002448")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x1002828", Offset = "0x1002828", VA = "0x1002828")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x1002974", Offset = "0x1002974", VA = "0x1002974")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x1003144", Offset = "0x1003144", VA = "0x1003144")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}
}
[Token(Token = "0x200000F")]
public class RFEvent
{
	[Token(Token = "0x2000010")]
	public delegate void EventAction(RayfireRigid rigid);

	[Token(Token = "0x2000011")]
	public delegate void EventActionMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot);

	[Token(Token = "0x2000012")]
	public delegate void EventActionRoot(RFShard shard, RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xDE8FDC", Offset = "0xDE8FDC", VA = "0xDE8FDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537950", Offset = "0x537950")]
		add
		{
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0xDE907C", Offset = "0xDE907C", VA = "0xDE907C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537960", Offset = "0x537960")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionMeshRoot LocalEventMeshRoot
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0xDE911C", Offset = "0xDE911C", VA = "0xDE911C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537970", Offset = "0x537970")]
		add
		{
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0xDE91BC", Offset = "0xDE91BC", VA = "0xDE91BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537980", Offset = "0x537980")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x600005A")]
		[Address(RVA = "0xDE925C", Offset = "0xDE925C", VA = "0xDE925C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537990", Offset = "0x537990")]
		add
		{
		}
		[Token(Token = "0x600005B")]
		[Address(RVA = "0xDE92FC", Offset = "0xDE92FC", VA = "0xDE92FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379A0", Offset = "0x5379A0")]
		remove
		{
		}
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xDE939C", Offset = "0xDE939C", VA = "0xDE939C")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xDE93B0", Offset = "0xDE93B0", VA = "0xDE93B0")]
	public void InvokeLocalEventMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xDE93C4", Offset = "0xDE93C4", VA = "0xDE93C4")]
	public void InvokeLocalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xDE52C8", Offset = "0xDE52C8", VA = "0xDE52C8")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x2000013")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0xDE50E0", Offset = "0xDE50E0", VA = "0xDE50E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379B0", Offset = "0x5379B0")]
		add
		{
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0xDE519C", Offset = "0xDE519C", VA = "0xDE519C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379C0", Offset = "0x5379C0")]
		remove
		{
		}
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xDE5258", Offset = "0xDE5258", VA = "0xDE5258")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xDE52C0", Offset = "0xDE52C0", VA = "0xDE52C0")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x2000014")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000005")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFFBBF4", Offset = "0xFFBBF4", VA = "0xFFBBF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379D0", Offset = "0x5379D0")]
		add
		{
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFFBCB0", Offset = "0xFFBCB0", VA = "0xFFBCB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379E0", Offset = "0x5379E0")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFFBD6C", Offset = "0xFFBD6C", VA = "0xFFBD6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5379F0", Offset = "0x5379F0")]
		add
		{
		}
		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFFBE2C", Offset = "0xFFBE2C", VA = "0xFFBE2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A00", Offset = "0x537A00")]
		remove
		{
		}
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xFFB308", Offset = "0xFFB308", VA = "0xFFB308")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xFFB7C4", Offset = "0xFFB7C4", VA = "0xFFB7C4")]
	public static void InvokeGlobalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xFFBEEC", Offset = "0xFFBEEC", VA = "0xFFBEEC")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x2000015")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xE813BC", Offset = "0xE813BC", VA = "0xE813BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A10", Offset = "0x537A10")]
		add
		{
		}
		[Token(Token = "0x6000078")]
		[Address(RVA = "0xE81478", Offset = "0xE81478", VA = "0xE81478")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A20", Offset = "0x537A20")]
		remove
		{
		}
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xE81534", Offset = "0xE81534", VA = "0xE81534")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xE8159C", Offset = "0xE8159C", VA = "0xE8159C")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x2000016")]
public class RFShotEvent
{
	[Token(Token = "0x2000017")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000008")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600007B")]
		[Address(RVA = "0xE84F20", Offset = "0xE84F20", VA = "0xE84F20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A30", Offset = "0x537A30")]
		add
		{
		}
		[Token(Token = "0x600007C")]
		[Address(RVA = "0xE84FDC", Offset = "0xE84FDC", VA = "0xE84FDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A40", Offset = "0x537A40")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0xE85098", Offset = "0xE85098", VA = "0xE85098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A50", Offset = "0x537A50")]
		add
		{
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0xE85138", Offset = "0xE85138", VA = "0xE85138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A60", Offset = "0x537A60")]
		remove
		{
		}
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xE851D8", Offset = "0xE851D8", VA = "0xE851D8")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xE85240", Offset = "0xE85240", VA = "0xE85240")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xE85254", Offset = "0xE85254", VA = "0xE85254")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000018")]
public class RFExplosionEvent
{
	[Token(Token = "0x2000019")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x1400000A")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0xDE93D8", Offset = "0xDE93D8", VA = "0xDE93D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A70", Offset = "0x537A70")]
		add
		{
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0xDE9494", Offset = "0xDE9494", VA = "0xDE9494")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A80", Offset = "0x537A80")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0xDE9550", Offset = "0xDE9550", VA = "0xDE9550")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537A90", Offset = "0x537A90")]
		add
		{
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0xDE95F0", Offset = "0xDE95F0", VA = "0xDE95F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AA0", Offset = "0x537AA0")]
		remove
		{
		}
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xDE9690", Offset = "0xDE9690", VA = "0xDE9690")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xDE96F8", Offset = "0xDE96F8", VA = "0xDE96F8")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xDE970C", Offset = "0xDE970C", VA = "0xDE970C")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x200001A")]
public class RFSliceEvent
{
	[Token(Token = "0x200001B")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x1400000C")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0xE85324", Offset = "0xE85324", VA = "0xE85324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AB0", Offset = "0x537AB0")]
		add
		{
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0xE853E0", Offset = "0xE853E0", VA = "0xE853E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AC0", Offset = "0x537AC0")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0xE8549C", Offset = "0xE8549C", VA = "0xE8549C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AD0", Offset = "0x537AD0")]
		add
		{
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0xE8553C", Offset = "0xE8553C", VA = "0xE8553C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AE0", Offset = "0x537AE0")]
		remove
		{
		}
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xE855DC", Offset = "0xE855DC", VA = "0xE855DC")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xE85644", Offset = "0xE85644", VA = "0xE85644")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xE85658", Offset = "0xE85658", VA = "0xE85658")]
	public RFSliceEvent()
	{
	}
}
[Token(Token = "0x200001C")]
public class RFConnectivityEvent
{
	[Token(Token = "0x200001D")]
	public delegate void EventAction(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters);

	[Token(Token = "0x1400000E")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x10061B4", Offset = "0x10061B4", VA = "0x10061B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537AF0", Offset = "0x537AF0")]
		add
		{
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1006270", Offset = "0x1006270", VA = "0x1006270")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537B00", Offset = "0x537B00")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x100632C", Offset = "0x100632C", VA = "0x100632C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537B10", Offset = "0x537B10")]
		add
		{
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x10063CC", Offset = "0x10063CC", VA = "0x10063CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x537B20", Offset = "0x537B20")]
		remove
		{
		}
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x100646C", Offset = "0x100646C", VA = "0x100646C")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x10064F0", Offset = "0x10064F0", VA = "0x10064F0")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x1006504", Offset = "0x1006504", VA = "0x1006504")]
	public RFConnectivityEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class RFFlash
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535CC8", Offset = "0x535CC8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535CC8", Offset = "0x535CC8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535CC8", Offset = "0x535CC8")]
	public float intensityMin;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535D34", Offset = "0x535D34")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535D34", Offset = "0x535D34")]
	public float intensityMax;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535D7C", Offset = "0x535D7C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535D7C", Offset = "0x535D7C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535D7C", Offset = "0x535D7C")]
	public float rangeMin;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535DE8", Offset = "0x535DE8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535DE8", Offset = "0x535DE8")]
	public float rangeMax;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535E30", Offset = "0x535E30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535E30", Offset = "0x535E30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535E30", Offset = "0x535E30")]
	public float distance;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535E9C", Offset = "0x535E9C")]
	public Color color;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xDEACC4", Offset = "0xDEACC4", VA = "0xDEACC4")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class RFDecals
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535EB0", Offset = "0x535EB0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535EB0", Offset = "0x535EB0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535EB0", Offset = "0x535EB0")]
	public float sizeMin;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535F1C", Offset = "0x535F1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535F1C", Offset = "0x535F1C")]
	public float sizeMax;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x535F64", Offset = "0x535F64")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535F64", Offset = "0x535F64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535F64", Offset = "0x535F64")]
	public float distance;

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x10071E4", Offset = "0x10071E4", VA = "0x10071E4")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x2000020")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x2000021")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x12589F8", Offset = "0x12589F8", VA = "0x12589F8")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1258A7C", Offset = "0x1258A7C", VA = "0x1258A7C")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xDF28CC", Offset = "0xDF28CC", VA = "0xDF28CC")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xDF2E04", Offset = "0xDF2E04", VA = "0xDF2E04")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xDF2F2C", Offset = "0xDF2F2C", VA = "0xDF2F2C")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xDED8E4", Offset = "0xDED8E4", VA = "0xDED8E4")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xDE5870", Offset = "0xDE5870", VA = "0xDE5870")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xDF3190", Offset = "0xDF3190", VA = "0xDF3190")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xDF3004", Offset = "0xDF3004", VA = "0xDF3004")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xDF32F4", Offset = "0xDF32F4", VA = "0xDF32F4")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000022")]
public class RFParticleNoise
{
	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x535FDC", Offset = "0x535FDC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x535FDC", Offset = "0x535FDC")]
	public bool enabled;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53602C", Offset = "0x53602C")]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536040", Offset = "0x536040")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536040", Offset = "0x536040")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536040", Offset = "0x536040")]
	public float strengthMin;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5360B4", Offset = "0x5360B4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5360B4", Offset = "0x5360B4")]
	public float strengthMax;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5360F8", Offset = "0x5360F8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5360F8", Offset = "0x5360F8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5360F8", Offset = "0x5360F8")]
	public float frequency;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536170", Offset = "0x536170")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536170", Offset = "0x536170")]
	public float scrollSpeed;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5361C0", Offset = "0x5361C0")]
	public bool damping;

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xDF3A80", Offset = "0xDF3A80", VA = "0xDF3A80")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xDF3AC4", Offset = "0xDF3AC4", VA = "0xDF3AC4")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000023")]
public class RFParticleRendering
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5361D4", Offset = "0x5361D4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5361D4", Offset = "0x5361D4")]
	public bool castShadows;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536224", Offset = "0x536224")]
	public bool receiveShadows;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536238", Offset = "0x536238")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536238", Offset = "0x536238")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536238", Offset = "0x536238")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xDF3B10", Offset = "0xDF3B10", VA = "0xDF3B10")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xDF3B40", Offset = "0xDF3B40", VA = "0xDF3B40")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000024")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x53629C", Offset = "0x53629C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53629C", Offset = "0x53629C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53629C", Offset = "0x53629C")]
	public float speedMin;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536304", Offset = "0x536304")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536304", Offset = "0x536304")]
	public float speedMax;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536348", Offset = "0x536348")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536348", Offset = "0x536348")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536348", Offset = "0x536348")]
	public float velocityMin;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5363BC", Offset = "0x5363BC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5363BC", Offset = "0x5363BC")]
	public float velocityMax;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536400", Offset = "0x536400")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536400", Offset = "0x536400")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536400", Offset = "0x536400")]
	public float gravityMin;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536468", Offset = "0x536468")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536468", Offset = "0x536468")]
	public float gravityMax;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5364B8", Offset = "0x5364B8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5364B8", Offset = "0x5364B8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5364B8", Offset = "0x5364B8")]
	public float rotationSpeed;

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0xDF385C", Offset = "0xDF385C", VA = "0xDF385C")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0xDF38A8", Offset = "0xDF38A8", VA = "0xDF38A8")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000025")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536520", Offset = "0x536520")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536520", Offset = "0x536520")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536520", Offset = "0x536520")]
	public float speedMin;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536588", Offset = "0x536588")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536588", Offset = "0x536588")]
	public float speedMax;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5365CC", Offset = "0x5365CC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5365CC", Offset = "0x5365CC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5365CC", Offset = "0x5365CC")]
	public float rotation;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536634", Offset = "0x536634")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536634", Offset = "0x536634")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536634", Offset = "0x536634")]
	public float gravityMin;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53669C", Offset = "0x53669C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53669C", Offset = "0x53669C")]
	public float gravityMax;

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0xDF38F4", Offset = "0xDF38F4", VA = "0xDF38F4")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0xDF3930", Offset = "0xDF3930", VA = "0xDF3930")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000026")]
public class RFParticleEmission
{
	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5366EC", Offset = "0x5366EC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5366EC", Offset = "0x5366EC")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53673C", Offset = "0x53673C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53673C", Offset = "0x53673C")]
	public int burstAmount;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536784", Offset = "0x536784")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536784", Offset = "0x536784")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536784", Offset = "0x536784")]
	public float distanceRate;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5367EC", Offset = "0x5367EC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5367EC", Offset = "0x5367EC")]
	public float duration;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536830", Offset = "0x536830")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536830", Offset = "0x536830")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536830", Offset = "0x536830")]
	public float lifeMin;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53689C", Offset = "0x53689C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53689C", Offset = "0x53689C")]
	public float lifeMax;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5368E4", Offset = "0x5368E4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5368E4", Offset = "0x5368E4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5368E4", Offset = "0x5368E4")]
	public float sizeMin;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536950", Offset = "0x536950")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536950", Offset = "0x536950")]
	public float sizeMax;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0xDF396C", Offset = "0xDF396C", VA = "0xDF396C")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0xDF39B4", Offset = "0xDF39B4", VA = "0xDF39B4")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000027")]
public class RFParticleLimitations
{
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536998", Offset = "0x536998")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536998", Offset = "0x536998")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536998", Offset = "0x536998")]
	public int minParticles;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536A10", Offset = "0x536A10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536A10", Offset = "0x536A10")]
	public int maxParticles;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536A58", Offset = "0x536A58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536A58", Offset = "0x536A58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536A58", Offset = "0x536A58")]
	public int percentage;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536AC4", Offset = "0x536AC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536AC4", Offset = "0x536AC4")]
	public float sizeThreshold;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536B0C", Offset = "0x536B0C")]
	[HideInInspector]
	public int demolitionDepth;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xDF3A00", Offset = "0xDF3A00", VA = "0xDF3A00")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xDF3A44", Offset = "0xDF3A44", VA = "0xDF3A44")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000028")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x2000029")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000B5")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000B6")]
		ByProperties
	}

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536B4C", Offset = "0x536B4C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536B4C", Offset = "0x536B4C")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536B9C", Offset = "0x536B9C")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536BB0", Offset = "0x536BB0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536BB0", Offset = "0x536BB0")]
	public float radiusScale;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536C04", Offset = "0x536C04")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536C04", Offset = "0x536C04")]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536C54", Offset = "0x536C54")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536C54", Offset = "0x536C54")]
	public float dampenMin;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536C98", Offset = "0x536C98")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536C98", Offset = "0x536C98")]
	public float dampenMax;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536CDC", Offset = "0x536CDC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536CDC", Offset = "0x536CDC")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536D2C", Offset = "0x536D2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536D2C", Offset = "0x536D2C")]
	public float bounceMin;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536D70", Offset = "0x536D70")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536D70", Offset = "0x536D70")]
	public float bounceMax;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xDF3510", Offset = "0xDF3510", VA = "0xDF3510")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xDF3570", Offset = "0xDF3570", VA = "0xDF3570")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xDF35D4", Offset = "0xDF35D4", VA = "0xDF35D4")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536DC4", Offset = "0x536DC4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536DC4", Offset = "0x536DC4")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536E14", Offset = "0x536E14")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536E28", Offset = "0x536E28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536E28", Offset = "0x536E28")]
	public float radiusScale;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xDF37F4", Offset = "0xDF37F4", VA = "0xDF37F4")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xDF3830", Offset = "0xDF3830", VA = "0xDF3830")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
public class RFParticles
{
	[Token(Token = "0x200002C")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000BE")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000BF")]
		ByProperties
	}

	[Token(Token = "0x200002D")]
	public enum BurstType
	{
		[Token(Token = "0x40000C1")]
		None,
		[Token(Token = "0x40000C2")]
		TotalAmount,
		[Token(Token = "0x40000C3")]
		PerOneUnitSize,
		[Token(Token = "0x40000C4")]
		FragmentAmount
	}

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0xDF3B6C", Offset = "0xDF3B6C", VA = "0xDF3B6C")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0xDF3F08", Offset = "0xDF3F08", VA = "0xDF3F08")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0xDF43BC", Offset = "0xDF43BC", VA = "0xDF43BC")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0xDF44BC", Offset = "0xDF44BC", VA = "0xDF44BC")]
	public static void CreateDemolitionDebris(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0xDF494C", Offset = "0xDF494C", VA = "0xDF494C")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0xDF6178", Offset = "0xDF6178", VA = "0xDF6178")]
	public static void InitActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xDF6868", Offset = "0xDF6868", VA = "0xDF6868")]
	public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xDF5818", Offset = "0xDF5818", VA = "0xDF5818")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xDF63B4", Offset = "0xDF63B4", VA = "0xDF63B4")]
	public static void CreateDebrisCluster(RayfireRigid rigid, RayfireDebris debris)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xDF6C38", Offset = "0xDF6C38", VA = "0xDF6C38")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xDF5E34", Offset = "0xDF5E34", VA = "0xDF5E34")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xDF6DC0", Offset = "0xDF6DC0", VA = "0xDF6DC0")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xDF6F48", Offset = "0xDF6F48", VA = "0xDF6F48")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xDF72A0", Offset = "0xDF72A0", VA = "0xDF72A0")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xDF7420", Offset = "0xDF7420", VA = "0xDF7420")]
	private static ParticleSystem CreateParticleSystem(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xDF75F4", Offset = "0xDF75F4", VA = "0xDF75F4")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xDF7788", Offset = "0xDF7788", VA = "0xDF7788")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xDF4DDC", Offset = "0xDF4DDC", VA = "0xDF4DDC")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xDE6B6C", Offset = "0xDE6B6C", VA = "0xDE6B6C")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xDF791C", Offset = "0xDF791C", VA = "0xDF791C")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xDF8450", Offset = "0xDF8450", VA = "0xDF8450")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xDF8918", Offset = "0xDF8918", VA = "0xDF8918")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xDF8B84", Offset = "0xDF8B84", VA = "0xDF8B84")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xDF8CE4", Offset = "0xDF8CE4", VA = "0xDF8CE4")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xDF8DA4", Offset = "0xDF8DA4", VA = "0xDF8DA4")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xDF70C8", Offset = "0xDF70C8", VA = "0xDF70C8")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xDF8DF4", Offset = "0xDF8DF4", VA = "0xDF8DF4")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xDF8EE4", Offset = "0xDF8EE4", VA = "0xDF8EE4")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xDF8FB0", Offset = "0xDF8FB0", VA = "0xDF8FB0")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xDF91EC", Offset = "0xDF91EC", VA = "0xDF91EC")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xDF9498", Offset = "0xDF9498", VA = "0xDF9498")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xDF9294", Offset = "0xDF9294", VA = "0xDF9294")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xDF95B0", Offset = "0xDF95B0", VA = "0xDF95B0")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0xDF9674", Offset = "0xDF9674", VA = "0xDF9674")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xDF984C", Offset = "0xDF984C", VA = "0xDF984C")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xDF9A18", Offset = "0xDF9A18", VA = "0xDF9A18")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xDF9C34", Offset = "0xDF9C34", VA = "0xDF9C34")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xDF9D84", Offset = "0xDF9D84", VA = "0xDF9D84")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xDF5908", Offset = "0xDF5908", VA = "0xDF5908")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xDF5F24", Offset = "0xDF5F24", VA = "0xDF5F24")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xDF5540", Offset = "0xDF5540", VA = "0xDF5540")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xDF5B5C", Offset = "0xDF5B5C", VA = "0xDF5B5C")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xDF721C", Offset = "0xDF721C", VA = "0xDF721C")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xDF9E2C", Offset = "0xDF9E2C", VA = "0xDF9E2C")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xDFA080", Offset = "0xDFA080", VA = "0xDFA080")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float neibPosThreshold;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float neibAreaThreshold;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float dm;

	[NonSerialized]
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m;

	[NonSerialized]
	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int lb;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int nAm;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> nIds;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<float> nArea;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> sIds;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<float> nSt;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float sSt;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform tm;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshFilter mf;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Collider col;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody rb;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool[] sCheck;

	[Token(Token = "0x1700000B")]
	public bool StressState
	{
		[Token(Token = "0x6000108")]
		[Address(RVA = "0xE83EBC", Offset = "0xE83EBC", VA = "0xE83EBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool SupportState
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0xE84970", Offset = "0xE84970", VA = "0xE84970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0xE849C4", Offset = "0xE849C4", VA = "0xE849C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xE81C18", Offset = "0xE81C18", VA = "0xE81C18")]
	public RFShard()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xE81C54", Offset = "0xE81C54", VA = "0xE81C54")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xE81F78", Offset = "0xE81F78", VA = "0xE81F78")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xE82148", Offset = "0xE82148", VA = "0xE82148")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xE822B0", Offset = "0xE822B0", VA = "0xE822B0", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xE822E0", Offset = "0xE822E0", VA = "0xE822E0")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xE827E8", Offset = "0xE827E8", VA = "0xE827E8")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xE82830", Offset = "0xE82830", VA = "0xE82830")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xE8295C", Offset = "0xE8295C", VA = "0xE8295C")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xE82C70", Offset = "0xE82C70", VA = "0xE82C70")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xE82DB0", Offset = "0xE82DB0", VA = "0xE82DB0")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xE82FE8", Offset = "0xE82FE8", VA = "0xE82FE8")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xE83240", Offset = "0xE83240", VA = "0xE83240")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xE83C1C", Offset = "0xE83C1C", VA = "0xE83C1C")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xE83D8C", Offset = "0xE83D8C", VA = "0xE83D8C")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE83F14", Offset = "0xE83F14", VA = "0xE83F14")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xE84004", Offset = "0xE84004", VA = "0xE84004")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xE84098", Offset = "0xE84098", VA = "0xE84098")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xE84164", Offset = "0xE84164", VA = "0xE84164")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xE84490", Offset = "0xE84490", VA = "0xE84490")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE84828", Offset = "0xE84828", VA = "0xE84828")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xE848CC", Offset = "0xE848CC", VA = "0xE848CC")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE849D8", Offset = "0xE849D8", VA = "0xE849D8")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE84AEC", Offset = "0xE84AEC", VA = "0xE84AEC")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RFSound
{
	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x1700000E")]
	public bool HasClips
	{
		[Token(Token = "0x6000118")]
		[Address(RVA = "0xE85824", Offset = "0xE85824", VA = "0xE85824")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE85660", Offset = "0xE85660", VA = "0xE85660")]
	public RFSound()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE85690", Offset = "0xE85690", VA = "0xE85690")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE8587C", Offset = "0xE8587C", VA = "0xE8587C")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE85974", Offset = "0xE85974", VA = "0xE85974")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xE85B4C", Offset = "0xE85B4C", VA = "0xE85B4C")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xE85DD0", Offset = "0xE85DD0", VA = "0xE85DD0")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xE861BC", Offset = "0xE861BC", VA = "0xE861BC")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xE863A0", Offset = "0xE863A0", VA = "0xE863A0")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xE860FC", Offset = "0xE860FC", VA = "0xE860FC")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xE85FC4", Offset = "0xE85FC4", VA = "0xE85FC4")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class RFStress
{
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534EE0", Offset = "0x534EE0")]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1259F40", Offset = "0x1259F40", VA = "0x1259F40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x1259F88", Offset = "0x1259F88", VA = "0x1259F88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1259D44", Offset = "0x1259D44", VA = "0x1259D44")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1259D70", Offset = "0x1259D70", VA = "0x1259D70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1259D74", Offset = "0x1259D74", VA = "0x1259D74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1259F48", Offset = "0x1259F48", VA = "0x1259F48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xE86A64", Offset = "0xE86A64", VA = "0xE86A64")]
	public RFStress()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xE86B54", Offset = "0xE86B54", VA = "0xE86B54")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xE86B78", Offset = "0xE86B78", VA = "0xE86B78")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0xE86C08", Offset = "0xE86C08", VA = "0xE86C08")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537B30", Offset = "0x537B30")]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xE86C9C", Offset = "0xE86C9C", VA = "0xE86C9C")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xE86FD0", Offset = "0xE86FD0", VA = "0xE86FD0")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xE875E8", Offset = "0xE875E8", VA = "0xE875E8")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xE87630", Offset = "0xE87630", VA = "0xE87630")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xE8796C", Offset = "0xE8796C", VA = "0xE8796C")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xE879E0", Offset = "0xE879E0", VA = "0xE879E0")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xE87AF4", Offset = "0xE87AF4", VA = "0xE87AF4")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xE88794", Offset = "0xE88794", VA = "0xE88794")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0xE88EB4", Offset = "0xE88EB4", VA = "0xE88EB4")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0xE87FCC", Offset = "0xE87FCC", VA = "0xE87FCC")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0xE898FC", Offset = "0xE898FC", VA = "0xE898FC")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0xE88F60", Offset = "0xE88F60", VA = "0xE88F60")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x2000032")]
public enum AxisType
{
	[Token(Token = "0x4000109")]
	XRed,
	[Token(Token = "0x400010A")]
	YGreen,
	[Token(Token = "0x400010B")]
	ZBlue
}
[Token(Token = "0x2000033")]
public enum PlaneType
{
	[Token(Token = "0x400010D")]
	XY,
	[Token(Token = "0x400010E")]
	XZ,
	[Token(Token = "0x400010F")]
	YZ
}
[Token(Token = "0x2000034")]
public enum FragType
{
	[Token(Token = "0x4000111")]
	Voronoi = 0,
	[Token(Token = "0x4000112")]
	Splinters = 1,
	[Token(Token = "0x4000113")]
	Slabs = 2,
	[Token(Token = "0x4000114")]
	Radial = 3,
	[Token(Token = "0x4000115")]
	Custom = 5,
	[Token(Token = "0x4000116")]
	Slices = 7,
	[Token(Token = "0x4000117")]
	Bricks = 9,
	[Token(Token = "0x4000118")]
	Voxels = 10,
	[Token(Token = "0x4000119")]
	Tets = 11,
	[Token(Token = "0x400011A")]
	Decompose = 15
}
[Token(Token = "0x2000035")]
public enum DemolitionType
{
	[Token(Token = "0x400011C")]
	None = 0,
	[Token(Token = "0x400011D")]
	Runtime = 1,
	[Token(Token = "0x400011E")]
	AwakePrecache = 2,
	[Token(Token = "0x400011F")]
	AwakePrefragment = 3,
	[Token(Token = "0x4000120")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000036")]
public enum CachingType
{
	[Token(Token = "0x4000122")]
	Disable,
	[Token(Token = "0x4000123")]
	ByFrames,
	[Token(Token = "0x4000124")]
	ByFragmentsPerFrame
}
[Token(Token = "0x2000037")]
public enum FadeType
{
	[Token(Token = "0x4000126")]
	None = 0,
	[Token(Token = "0x4000127")]
	SimExclude = 1,
	[Token(Token = "0x4000128")]
	FallDown = 2,
	[Token(Token = "0x4000129")]
	ScaleDown = 3,
	[Token(Token = "0x400012A")]
	MoveDown = 4,
	[Token(Token = "0x400012B")]
	Destroy = 5,
	[Token(Token = "0x400012C")]
	SetStatic = 8,
	[Token(Token = "0x400012D")]
	SetKinematic = 9
}
[Token(Token = "0x2000038")]
public enum RFFadeLifeType
{
	[Token(Token = "0x400012F")]
	ByLifeTime = 4,
	[Token(Token = "0x4000130")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x2000039")]
public enum MaterialType
{
	[Token(Token = "0x4000132")]
	HeavyMetal,
	[Token(Token = "0x4000133")]
	LightMetal,
	[Token(Token = "0x4000134")]
	DenseRock,
	[Token(Token = "0x4000135")]
	PorousRock,
	[Token(Token = "0x4000136")]
	Concrete,
	[Token(Token = "0x4000137")]
	Brick,
	[Token(Token = "0x4000138")]
	Glass,
	[Token(Token = "0x4000139")]
	Rubber,
	[Token(Token = "0x400013A")]
	Ice,
	[Token(Token = "0x400013B")]
	Wood
}
[Token(Token = "0x200003A")]
public enum MassType
{
	[Token(Token = "0x400013D")]
	MaterialDensity,
	[Token(Token = "0x400013E")]
	MassProperty,
	[Token(Token = "0x400013F")]
	RigidBodyComponent
}
[Token(Token = "0x200003B")]
public enum ObjectType
{
	[Token(Token = "0x4000141")]
	Mesh = 0,
	[Token(Token = "0x4000142")]
	MeshRoot = 1,
	[Token(Token = "0x4000143")]
	SkinnedMesh = 2,
	[Token(Token = "0x4000144")]
	NestedCluster = 4,
	[Token(Token = "0x4000145")]
	ConnectedCluster = 5
}
[Token(Token = "0x200003C")]
public enum SimType
{
	[Token(Token = "0x4000147")]
	Dynamic,
	[Token(Token = "0x4000148")]
	Sleeping,
	[Token(Token = "0x4000149")]
	Inactive,
	[Token(Token = "0x400014A")]
	Kinematic,
	[Token(Token = "0x400014B")]
	Static
}
[Token(Token = "0x200003D")]
public enum FragSimType
{
	[Token(Token = "0x400014D")]
	Dynamic,
	[Token(Token = "0x400014E")]
	Sleeping,
	[Token(Token = "0x400014F")]
	Inactive,
	[Token(Token = "0x4000150")]
	Kinematic,
	[Token(Token = "0x4000151")]
	Inherit
}
[Token(Token = "0x200003E")]
public enum ConnectivityType
{
	[Token(Token = "0x4000153")]
	ByBoundingBox = 0,
	[Token(Token = "0x4000154")]
	ByTriangles = 1,
	[Token(Token = "0x4000155")]
	ByPolygons = 3,
	[Token(Token = "0x4000156")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x4000157")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x200003F")]
public enum FragmentMode
{
	[Token(Token = "0x4000159")]
	Runtime,
	[Token(Token = "0x400015A")]
	Editor
}
[Token(Token = "0x2000040")]
public enum RFColliderType
{
	[Token(Token = "0x400015C")]
	Mesh = 0,
	[Token(Token = "0x400015D")]
	Box = 1,
	[Token(Token = "0x400015E")]
	Sphere = 2,
	[Token(Token = "0x400015F")]
	None = 4
}
[Token(Token = "0x2000041")]
public enum RFParenting
{
	[Token(Token = "0x4000161")]
	Manager = 0,
	[Token(Token = "0x4000162")]
	Parent = 1,
	[Token(Token = "0x4000163")]
	Sphere = 2,
	[Token(Token = "0x4000164")]
	None = 4
}
[Token(Token = "0x2000042")]
public class RFFrag
{
	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x600012F")]
	[Address(RVA = "0xDEAD30", Offset = "0xDEAD30", VA = "0xDEAD30")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x2000043")]
public class RFTri
{
	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x6000130")]
	[Address(RVA = "0xE8A678", Offset = "0xE8A678", VA = "0xE8A678")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class RFDictionary
{
	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0xDE8E8C", Offset = "0xDE8E8C", VA = "0xDE8E8C")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000045")]
public class RFShatterCluster
{
	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x6000132")]
	[Address(RVA = "0xE84E54", Offset = "0xE84E54", VA = "0xE84E54")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0xE84EA8", Offset = "0xE84EA8", VA = "0xE84EA8")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000046")]
public class RFVoronoi
{
	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x17000011")]
	public int Amount
	{
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xE8A93C", Offset = "0xE8A93C", VA = "0xE8A93C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0xE8A8D0", Offset = "0xE8A8D0", VA = "0xE8A8D0")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0xE8A8FC", Offset = "0xE8A8FC", VA = "0xE8A8FC")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000047")]
public class RFSplinters
{
	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x17000012")]
	public int Amount
	{
		[Token(Token = "0x6000139")]
		[Address(RVA = "0xE8660C", Offset = "0xE8660C", VA = "0xE8660C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0xE86584", Offset = "0xE86584", VA = "0xE86584")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xE865BC", Offset = "0xE865BC", VA = "0xE865BC")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
public class RFRadial
{
	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xE7D07C", Offset = "0xE7D07C", VA = "0xE7D07C")]
	public RFRadial()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xE7D0CC", Offset = "0xE7D0CC", VA = "0xE7D0CC")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000049")]
public class RFSlice
{
	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xE8525C", Offset = "0xE8525C", VA = "0xE8525C")]
	public RFSlice()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xE85288", Offset = "0xE85288", VA = "0xE85288")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xE852CC", Offset = "0xE852CC", VA = "0xE852CC")]
	public Vector3 Axis(Transform tm)
	{
		return default(Vector3);
	}
}
[Serializable]
[Token(Token = "0x200004A")]
public class RFBricks
{
	[Token(Token = "0x200004B")]
	public enum RFBrickType
	{
		[Token(Token = "0x40001A5")]
		ByAmount,
		[Token(Token = "0x40001A6")]
		BySize
	}

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xFFEC60", Offset = "0xFFEC60", VA = "0xFFEC60")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x200004C")]
public class RFVoxels
{
	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536E7C", Offset = "0x536E7C")]
	public float size;

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xE8A964", Offset = "0xE8A964", VA = "0xE8A964")]
	public RFVoxels()
	{
	}
}
[Serializable]
[Token(Token = "0x200004D")]
public class RFTets
{
	[Token(Token = "0x200004E")]
	public enum TetType
	{
		[Token(Token = "0x40001AC")]
		Uniform,
		[Token(Token = "0x40001AD")]
		Curved
	}

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xE8A5F8", Offset = "0xE8A5F8", VA = "0xE8A5F8")]
	public RFTets()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xE8A630", Offset = "0xE8A630", VA = "0xE8A630")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x200004F")]
public class RFActivation
{
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534EF0", Offset = "0x534EF0")]
	private sealed class <ActivationVelocityCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x101BEDC", Offset = "0x101BEDC", VA = "0x101BEDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x101BF24", Offset = "0x101BF24", VA = "0x101BF24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x101BD6C", Offset = "0x101BD6C", VA = "0x101BD6C")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x101BD98", Offset = "0x101BD98", VA = "0x101BD98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x101BD9C", Offset = "0x101BD9C", VA = "0x101BD9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x101BEE4", Offset = "0x101BEE4", VA = "0x101BEE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F00", Offset = "0x534F00")]
	private sealed class <ActivationOffsetCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015D")]
			[Address(RVA = "0x101BD1C", Offset = "0x101BD1C", VA = "0x101BD1C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x101BD64", Offset = "0x101BD64", VA = "0x101BD64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x101BB94", Offset = "0x101BB94", VA = "0x101BB94")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x101BBC0", Offset = "0x101BBC0", VA = "0x101BBC0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x101BBC4", Offset = "0x101BBC4", VA = "0x101BBC4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x101BD24", Offset = "0x101BD24", VA = "0x101BD24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F10", Offset = "0x534F10")]
	private sealed class <InactiveCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000163")]
			[Address(RVA = "0x101C04C", Offset = "0x101C04C", VA = "0x101C04C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000165")]
			[Address(RVA = "0x101C094", Offset = "0x101C094", VA = "0x101C094", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x101BF2C", Offset = "0x101BF2C", VA = "0x101BF2C")]
		[DebuggerHidden]
		public <InactiveCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x101BF58", Offset = "0x101BF58", VA = "0x101BF58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x101BF5C", Offset = "0x101BF5C", VA = "0x101BF5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x101C054", Offset = "0x101C054", VA = "0x101C054", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F20", Offset = "0x534F20")]
	private sealed class <InactiveCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000169")]
			[Address(RVA = "0x101C814", Offset = "0x101C814", VA = "0x101C814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x101C85C", Offset = "0x101C85C", VA = "0x101C85C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x101C09C", Offset = "0x101C09C", VA = "0x101C09C")]
		[DebuggerHidden]
		public <InactiveCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x101C0C8", Offset = "0x101C0C8", VA = "0x101C0C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x101C0CC", Offset = "0x101C0CC", VA = "0x101C0CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x101C81C", Offset = "0x101C81C", VA = "0x101C81C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool local;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float byVelocity;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float byDamage;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool byActivator;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool byImpact;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool byConnectivity;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool unyielding;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool activatable;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool l;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int layer;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireConnectivity connect;

	[NonSerialized]
	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int lb;

	[NonSerialized]
	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool activated;

	[NonSerialized]
	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool inactiveCorState;

	[NonSerialized]
	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool velocityCorState;

	[NonSerialized]
	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IEnumerator velocityEnum;

	[NonSerialized]
	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xFFA8E8", Offset = "0xFFA8E8", VA = "0xFFA8E8")]
	public RFActivation()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xFFA974", Offset = "0xFFA974", VA = "0xFFA974")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xFFA938", Offset = "0xFFA938", VA = "0xFFA938")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xFFA9E0", Offset = "0xFFA9E0", VA = "0xFFA9E0")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0xFFAA88", Offset = "0xFFAA88", VA = "0xFFAA88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537BE0", Offset = "0x537BE0")]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0xFFAB1C", Offset = "0xFFAB1C", VA = "0xFFAB1C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537C40", Offset = "0x537C40")]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0xFFABB0", Offset = "0xFFABB0", VA = "0xFFABB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537CA0", Offset = "0x537CA0")]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0xFFAC44", Offset = "0xFFAC44", VA = "0xFFAC44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537D00", Offset = "0x537D00")]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0xFFACD8", Offset = "0xFFACD8", VA = "0xFFACD8")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xFFB370", Offset = "0xFFB370", VA = "0xFFB370")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xFFB2A8", Offset = "0xFFB2A8", VA = "0xFFB2A8")]
	private static void SetActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xFFB840", Offset = "0xFFB840", VA = "0xFFB840")]
	public static void RestoreActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xFFB8A0", Offset = "0xFFB8A0", VA = "0xFFB8A0")]
	public static void BackupActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xFFB76C", Offset = "0xFFB76C", VA = "0xFFB76C")]
	private static void SetActivationLayer(RFShard shard, RFActivation activation)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xFFB8E8", Offset = "0xFFB8E8", VA = "0xFFB8E8")]
	public static void SetActivationLayer(List<RFShard> shards, RFActivation activation)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xFFB9B0", Offset = "0xFFB9B0", VA = "0xFFB9B0")]
	public static void RestoreActivationLayer(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xFFBAC4", Offset = "0xFFBAC4", VA = "0xFFBAC4")]
	public static void BackupActivationLayer(RayfireRigidRoot root)
	{
	}
}
[Token(Token = "0x2000054")]
public class RFBackupCluster
{
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFCluster cluster;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool saved;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xFFBEF4", Offset = "0xFFBEF4", VA = "0xFFBEF4")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0xFFBF1C", Offset = "0xFFBF1C", VA = "0xFFBF1C")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xFFC72C", Offset = "0xFFC72C", VA = "0xFFC72C")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xFFC954", Offset = "0xFFC954", VA = "0xFFC954")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xFFCFD4", Offset = "0xFFCFD4", VA = "0xFFCFD4")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xFFDB78", Offset = "0xFFDB78", VA = "0xFFDB78")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xFFC464", Offset = "0xFFC464", VA = "0xFFC464")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xFFD6FC", Offset = "0xFFD6FC", VA = "0xFFD6FC")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xFFD4FC", Offset = "0xFFD4FC", VA = "0xFFD4FC")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xFFD114", Offset = "0xFFD114", VA = "0xFFD114")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xFFD5F4", Offset = "0xFFD5F4", VA = "0xFFD5F4")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xFFD9C0", Offset = "0xFFD9C0", VA = "0xFFD9C0")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xFFDEFC", Offset = "0xFFDEFC", VA = "0xFFDEFC")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xFFE1A0", Offset = "0xFFE1A0", VA = "0xFFE1A0")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xFFE2AC", Offset = "0xFFE2AC", VA = "0xFFE2AC")]
	public static void RestoreConnectivity(RayfireConnectivity scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000055")]
public class RFCollapse
{
	[Token(Token = "0x2000056")]
	public enum RFCollapseType
	{
		[Token(Token = "0x40001DA")]
		ByArea = 1,
		[Token(Token = "0x40001DB")]
		BySize = 3,
		[Token(Token = "0x40001DC")]
		Random = 5
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F30", Offset = "0x534F30")]
	private sealed class <CollapseCor>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x101CCFC", Offset = "0x101CCFC", VA = "0x101CCFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x101CD44", Offset = "0x101CD44", VA = "0x101CD44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x101CAD4", Offset = "0x101CAD4", VA = "0x101CAD4")]
		[DebuggerHidden]
		public <CollapseCor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x101CB00", Offset = "0x101CB00", VA = "0x101CB00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x101CB04", Offset = "0x101CB04", VA = "0x101CB04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x101CD04", Offset = "0x101CD04", VA = "0x101CD04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F40", Offset = "0x534F40")]
	private sealed class <CollapseCor>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireConnectivity scr;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x101CA84", Offset = "0x101CA84", VA = "0x101CA84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x101CACC", Offset = "0x101CACC", VA = "0x101CACC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x101C864", Offset = "0x101C864", VA = "0x101C864")]
		[DebuggerHidden]
		public <CollapseCor>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x101C890", Offset = "0x101C890", VA = "0x101C890", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x101C894", Offset = "0x101C894", VA = "0x101C894", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x101CA8C", Offset = "0x101CA8C", VA = "0x101CA8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x536E98", Offset = "0x536E98")]
	public RFCollapseType type;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int start;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int end;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int steps;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool inProgress;

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x100351C", Offset = "0x100351C", VA = "0x100351C")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x1003554", Offset = "0x1003554", VA = "0x1003554")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x10035F4", Offset = "0x10035F4", VA = "0x10035F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537EA0", Offset = "0x537EA0")]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x1003688", Offset = "0x1003688", VA = "0x1003688")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x10037AC", Offset = "0x10037AC", VA = "0x10037AC")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x1003718", Offset = "0x1003718", VA = "0x1003718")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x537F00", Offset = "0x537F00")]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x10037D0", Offset = "0x10037D0", VA = "0x10037D0")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x10038AC", Offset = "0x10038AC", VA = "0x10038AC")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x1003838", Offset = "0x1003838", VA = "0x1003838")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x1003914", Offset = "0x1003914", VA = "0x1003914")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x10040E8", Offset = "0x10040E8", VA = "0x10040E8")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x1003CC4", Offset = "0x1003CC4", VA = "0x1003CC4")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x10046EC", Offset = "0x10046EC", VA = "0x10046EC")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x10047AC", Offset = "0x10047AC", VA = "0x10047AC")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x100474C", Offset = "0x100474C", VA = "0x100474C")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x100480C", Offset = "0x100480C", VA = "0x100480C")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x100486C", Offset = "0x100486C", VA = "0x100486C")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x1003988", Offset = "0x1003988", VA = "0x1003988")]
	private static int RemNeibByArea(RFCluster cluster, float minArea)
	{
		return default(int);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x1003E00", Offset = "0x1003E00", VA = "0x1003E00")]
	private static int RemNeibBySize(RFCluster cluster, float minSize)
	{
		return default(int);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x1004170", Offset = "0x1004170", VA = "0x1004170")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x10048F8", Offset = "0x10048F8", VA = "0x10048F8")]
	private static void RemoveConnection(RFCluster cluster, int s, int n)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xFFE8A4", Offset = "0xFFE8A4", VA = "0xFFE8A4")]
	public static void SetRangeData(RFCluster cluster, int perc = 0, int seed = 0)
	{
	}
}
[Serializable]
[Token(Token = "0x2000059")]
public class RFDamage
{
	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxDamage;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float currentDamage;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool collect;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float multiplier;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toShards;

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x1006D70", Offset = "0x1006D70", VA = "0x1006D70")]
	public RFDamage()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x1006DB8", Offset = "0x1006DB8", VA = "0x1006DB8")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xFFDEF4", Offset = "0xFFDEF4", VA = "0xFFDEF4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x1006DF0", Offset = "0x1006DF0", VA = "0x1006DF0")]
	public static bool ApplyTo(RayfireRigid scr, float value, Vector3 point, float radius = 0f, [Optional] Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x100700C", Offset = "0x100700C", VA = "0x100700C")]
	public static bool ApplyToRigid(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x1006E2C", Offset = "0x1006E2C", VA = "0x1006E2C")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x1007060", Offset = "0x1007060", VA = "0x1007060")]
	public static bool ApplyDamage(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200005A")]
public class RFDemolitionCluster
{
	[Token(Token = "0x200005B")]
	public enum RFDetachType
	{
		[Token(Token = "0x4000209")]
		RatioToSize = 0,
		[Token(Token = "0x400020A")]
		WorldUnits = 3
	}

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float minimumArea;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minimumSize;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public RFDetachType type;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ratio;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float units;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardArea;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool shardDemolition;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int minAmount;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int maxAmount;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishable;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFCollapse collapse;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int clsCount;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RFCluster> minorClusters;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool cn;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool nd;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int am;

	[NonSerialized]
	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float damageRadius;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string nameApp;

	[Token(Token = "0x1700001F")]
	public bool HasChildClusters
	{
		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x100C8FC", Offset = "0x100C8FC", VA = "0x100C8FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1007BBC", Offset = "0x1007BBC", VA = "0x1007BBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x100721C", Offset = "0x100721C", VA = "0x100721C")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x1007280", Offset = "0x1007280", VA = "0x1007280")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xFFDEEC", Offset = "0xFFDEEC", VA = "0xFFDEEC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x1007310", Offset = "0x1007310", VA = "0x1007310")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x100740C", Offset = "0x100740C", VA = "0x100740C")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x10074C0", Offset = "0x10074C0", VA = "0x10074C0")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x10079B0", Offset = "0x10079B0", VA = "0x10079B0")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x1007748", Offset = "0x1007748", VA = "0x1007748")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x1007C14", Offset = "0x1007C14", VA = "0x1007C14")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x1007FCC", Offset = "0x1007FCC", VA = "0x1007FCC")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x1008288", Offset = "0x1008288", VA = "0x1008288")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x100843C", Offset = "0x100843C", VA = "0x100843C")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x100877C", Offset = "0x100877C", VA = "0x100877C")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x10080FC", Offset = "0x10080FC", VA = "0x10080FC")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x1004520", Offset = "0x1004520", VA = "0x1004520")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x1009040", Offset = "0x1009040", VA = "0x1009040")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x1009154", Offset = "0x1009154", VA = "0x1009154")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x1009264", Offset = "0x1009264", VA = "0x1009264")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x100A330", Offset = "0x100A330", VA = "0x100A330")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x100AAFC", Offset = "0x100AAFC", VA = "0x100AAFC")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1008BBC", Offset = "0x1008BBC", VA = "0x1008BBC")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x10098AC", Offset = "0x10098AC", VA = "0x10098AC")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x100AEB0", Offset = "0x100AEB0", VA = "0x100AEB0")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x100B7B0", Offset = "0x100B7B0", VA = "0x100B7B0")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x100BBF0", Offset = "0x100BBF0", VA = "0x100BBF0")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x100B690", Offset = "0x100B690", VA = "0x100B690")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x100C07C", Offset = "0x100C07C", VA = "0x100C07C")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x100952C", Offset = "0x100952C", VA = "0x100952C")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x100C35C", Offset = "0x100C35C", VA = "0x100C35C")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1009784", Offset = "0x1009784", VA = "0x1009784")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x100C78C", Offset = "0x100C78C", VA = "0x100C78C")]
	private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200005C")]
public class RFDemolitionSkin
{
	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> bones;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SkinnedMeshRenderer> skins;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SkinnedMeshRenderer> skins0;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SkinnedMeshRenderer> skins1;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skins2;

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0xDE8BB0", Offset = "0xDE8BB0", VA = "0xDE8BB0")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0xDE8C68", Offset = "0xDE8C68", VA = "0xDE8C68")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0xDE8E84", Offset = "0xDE8E84", VA = "0xDE8E84")]
	public RFDemolitionSkin()
	{
	}
}
[Serializable]
[Token(Token = "0x200005D")]
public class RFDemolitionMesh
{
	[Token(Token = "0x200005E")]
	public enum MeshInputType
	{
		[Token(Token = "0x4000226")]
		AtStart = 3,
		[Token(Token = "0x4000227")]
		AtInitialization = 6,
		[Token(Token = "0x4000228")]
		AtDemolition = 9
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F50", Offset = "0x534F50")]
	private sealed class <RuntimeCachingCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFDemolitionMesh <>4__this;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <demolitionShouldLocal>5__2;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> <batchAmount>5__3;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <tmRefGo>5__4;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> <meshesList>5__5;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> <pivotsList>5__6;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RFDictionary> <subList>5__7;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x101D828", Offset = "0x101D828", VA = "0x101D828", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x101D870", Offset = "0x101D870", VA = "0x101D870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x101D2F8", Offset = "0x101D2F8", VA = "0x101D2F8")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x101D324", Offset = "0x101D324", VA = "0x101D324", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x101D328", Offset = "0x101D328", VA = "0x101D328", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x101D830", Offset = "0x101D830", VA = "0x101D830", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int variation;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float depthFade;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float contactBias;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool useShatter;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool addChildren;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool clusterize;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FragSimType simType;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MeshInputType meshInput;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFFragmentProperties properties;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRuntimeCaching runtimeCaching;

	[NonSerialized]
	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int badMesh;

	[NonSerialized]
	[Token(Token = "0x400021D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int shatterMode;

	[NonSerialized]
	[Token(Token = "0x400021E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int totalAmount;

	[NonSerialized]
	[Token(Token = "0x400021F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int innerSubId;

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Quaternion cacheRotationStart;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Mesh mesh;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFShatter rfShatter;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RayfireShatter scrShatter;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string fragmentStr;

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0xDE52D0", Offset = "0xDE52D0", VA = "0xDE52D0")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xDE5464", Offset = "0xDE5464", VA = "0xDE5464")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xDE5458", Offset = "0xDE5458", VA = "0xDE5458")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xDE55C8", Offset = "0xDE55C8", VA = "0xDE55C8")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xDE63CC", Offset = "0xDE63CC", VA = "0xDE63CC")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xDE5994", Offset = "0xDE5994", VA = "0xDE5994")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0xDE7034", Offset = "0xDE7034", VA = "0xDE7034")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0xDE7A58", Offset = "0xDE7A58", VA = "0xDE7A58")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0xDE68B8", Offset = "0xDE68B8", VA = "0xDE68B8")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0xDE62F0", Offset = "0xDE62F0", VA = "0xDE62F0")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0xDE8188", Offset = "0xDE8188", VA = "0xDE8188")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0xDE85A0", Offset = "0xDE85A0", VA = "0xDE85A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538000", Offset = "0x538000")]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xDE8634", Offset = "0xDE8634", VA = "0xDE8634")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xDE865C", Offset = "0xDE865C", VA = "0xDE865C")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xDE86C8", Offset = "0xDE86C8", VA = "0xDE86C8")]
	public static void AwakePrecache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xDE87D8", Offset = "0xDE87D8", VA = "0xDE87D8")]
	public static void AwakePrefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xDE8750", Offset = "0xDE8750", VA = "0xDE8750")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xDE886C", Offset = "0xDE886C", VA = "0xDE886C")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000060")]
public class RFFade
{
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F60", Offset = "0x534F60")]
	private sealed class <FadeOffsetCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x101F15C", Offset = "0x101F15C", VA = "0x101F15C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x101F1A4", Offset = "0x101F1A4", VA = "0x101F1A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x101EF34", Offset = "0x101EF34", VA = "0x101EF34")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x101EF60", Offset = "0x101EF60", VA = "0x101EF60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x101EF64", Offset = "0x101EF64", VA = "0x101EF64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x101F164", Offset = "0x101F164", VA = "0x101F164", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F70", Offset = "0x534F70")]
	private sealed class <FadeOffsetCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x101F564", Offset = "0x101F564", VA = "0x101F564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x101F5AC", Offset = "0x101F5AC", VA = "0x101F5AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x101F1AC", Offset = "0x101F1AC", VA = "0x101F1AC")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x101F1D8", Offset = "0x101F1D8", VA = "0x101F1D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x101F1DC", Offset = "0x101F1DC", VA = "0x101F1DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x101F56C", Offset = "0x101F56C", VA = "0x101F56C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F80", Offset = "0x534F80")]
	private sealed class <LivingCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1257D28", Offset = "0x1257D28", VA = "0x1257D28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1257D70", Offset = "0x1257D70", VA = "0x1257D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x12579F4", Offset = "0x12579F4", VA = "0x12579F4")]
		[DebuggerHidden]
		public <LivingCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1257A20", Offset = "0x1257A20", VA = "0x1257A20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1257A24", Offset = "0x1257A24", VA = "0x1257A24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1257D30", Offset = "0x1257D30", VA = "0x1257D30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534F90", Offset = "0x534F90")]
	private sealed class <LivingCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1258098", Offset = "0x1258098", VA = "0x1258098", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x12580E0", Offset = "0x12580E0", VA = "0x12580E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1257D78", Offset = "0x1257D78", VA = "0x1257D78")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1257DA4", Offset = "0x1257DA4", VA = "0x1257DA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1257DA8", Offset = "0x1257DA8", VA = "0x1257DA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x12580A0", Offset = "0x12580A0", VA = "0x12580A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FA0", Offset = "0x534FA0")]
	private sealed class <SimulationLivingCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tm;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <oldPos>5__2;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <distanceThreshold>5__3;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x1258754", Offset = "0x1258754", VA = "0x1258754", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x125879C", Offset = "0x125879C", VA = "0x125879C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x12585FC", Offset = "0x12585FC", VA = "0x12585FC")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1258628", Offset = "0x1258628", VA = "0x1258628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x125862C", Offset = "0x125862C", VA = "0x125862C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x125875C", Offset = "0x125875C", VA = "0x125875C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FB0", Offset = "0x534FB0")]
	private sealed class <FallDownCor>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x1257778", Offset = "0x1257778", VA = "0x1257778", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x12577C0", Offset = "0x12577C0", VA = "0x12577C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1257544", Offset = "0x1257544", VA = "0x1257544")]
		[DebuggerHidden]
		public <FallDownCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1257570", Offset = "0x1257570", VA = "0x1257570", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1257574", Offset = "0x1257574", VA = "0x1257574", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1257780", Offset = "0x1257780", VA = "0x1257780", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FC0", Offset = "0x534FC0")]
	private sealed class <FallDownCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x12579A4", Offset = "0x12579A4", VA = "0x12579A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x12579EC", Offset = "0x12579EC", VA = "0x12579EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x12577C8", Offset = "0x12577C8", VA = "0x12577C8")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x12577F4", Offset = "0x12577F4", VA = "0x12577F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x12577F8", Offset = "0x12577F8", VA = "0x12577F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x12579AC", Offset = "0x12579AC", VA = "0x12579AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FD0", Offset = "0x534FD0")]
	private sealed class <ScaleDownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x1258300", Offset = "0x1258300", VA = "0x1258300", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x1258348", Offset = "0x1258348", VA = "0x1258348", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x12580E8", Offset = "0x12580E8", VA = "0x12580E8")]
		[DebuggerHidden]
		public <ScaleDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1258114", Offset = "0x1258114", VA = "0x1258114", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1258118", Offset = "0x1258118", VA = "0x1258118", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1258308", Offset = "0x1258308", VA = "0x1258308", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FE0", Offset = "0x534FE0")]
	private sealed class <ScaleDownCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0x12585AC", Offset = "0x12585AC", VA = "0x12585AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x12585F4", Offset = "0x12585F4", VA = "0x12585F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1258350", Offset = "0x1258350", VA = "0x1258350")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x125837C", Offset = "0x125837C", VA = "0x125837C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1258380", Offset = "0x1258380", VA = "0x1258380", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x12585B4", Offset = "0x12585B4", VA = "0x12585B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x534FF0", Offset = "0x534FF0")]
	private sealed class <FadeMoveDownCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x101EB64", Offset = "0x101EB64", VA = "0x101EB64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x101EBAC", Offset = "0x101EBAC", VA = "0x101EBAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x101E7A8", Offset = "0x101E7A8", VA = "0x101E7A8")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x101E7D4", Offset = "0x101E7D4", VA = "0x101E7D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x101E7D8", Offset = "0x101E7D8", VA = "0x101E7D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x101EB6C", Offset = "0x101EB6C", VA = "0x101EB6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535000", Offset = "0x535000")]
	private sealed class <FadeMoveDownCor>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x101EEE4", Offset = "0x101EEE4", VA = "0x101EEE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0x101EF2C", Offset = "0x101EF2C", VA = "0x101EF2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x101EBB4", Offset = "0x101EBB4", VA = "0x101EBB4")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x101EBE0", Offset = "0x101EBE0", VA = "0x101EBE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x101EBE4", Offset = "0x101EBE4", VA = "0x101EBE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x101EEEC", Offset = "0x101EEEC", VA = "0x101EEEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onDemolition;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onActivation;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFFadeLifeType lifeType;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lifeTime;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeVariation;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public FadeType fadeType;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeTime;

	[Token(Token = "0x400023C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeFilter;

	[Token(Token = "0x400023D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardAmount;

	[NonSerialized]
	[Token(Token = "0x400023E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int state;

	[NonSerialized]
	[Token(Token = "0x400023F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool stop;

	[NonSerialized]
	[Token(Token = "0x4000240")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 position;

	[NonSerialized]
	[Token(Token = "0x4000241")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xDE9B24", Offset = "0xDE9B24", VA = "0xDE9B24")]
	public RFFade()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0xDE9BA8", Offset = "0xDE9BA8", VA = "0xDE9BA8")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0xDE9B90", Offset = "0xDE9B90", VA = "0xDE9B90")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0xDE9C1C", Offset = "0xDE9C1C", VA = "0xDE9C1C")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0xDE9E3C", Offset = "0xDE9E3C", VA = "0xDE9E3C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5380B0", Offset = "0x5380B0")]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0xDE9EB4", Offset = "0xDE9EB4", VA = "0xDE9EB4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538110", Offset = "0x538110")]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0xDE9D28", Offset = "0xDE9D28", VA = "0xDE9D28")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xDE9FA4", Offset = "0xDE9FA4", VA = "0xDE9FA4")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xDEA0B4", Offset = "0xDEA0B4", VA = "0xDEA0B4")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xDE9F2C", Offset = "0xDE9F2C", VA = "0xDE9F2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538170", Offset = "0x538170")]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xDEA020", Offset = "0xDEA020", VA = "0xDEA020")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5381D0", Offset = "0x5381D0")]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xDEA1DC", Offset = "0xDEA1DC", VA = "0xDEA1DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538230", Offset = "0x538230")]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xDEA254", Offset = "0xDEA254", VA = "0xDEA254")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xDEA464", Offset = "0xDEA464", VA = "0xDEA464")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xDEA554", Offset = "0xDEA554", VA = "0xDEA554")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538290", Offset = "0x538290")]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xDEA5CC", Offset = "0xDEA5CC", VA = "0xDEA5CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5382F0", Offset = "0x5382F0")]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xDEA660", Offset = "0xDEA660", VA = "0xDEA660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538350", Offset = "0x538350")]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xDEA6D8", Offset = "0xDEA6D8", VA = "0xDEA6D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5383B0", Offset = "0x5383B0")]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xDEA76C", Offset = "0xDEA76C", VA = "0xDEA76C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538410", Offset = "0x538410")]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xDEA7E4", Offset = "0xDEA7E4", VA = "0xDEA7E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538470", Offset = "0x538470")]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xDEA878", Offset = "0xDEA878", VA = "0xDEA878")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xDEAA2C", Offset = "0xDEAA2C", VA = "0xDEAA2C")]
	public static void SetOffsetFadeList(RayfireRigidRoot root)
	{
	}
}
[Serializable]
[Token(Token = "0x200006C")]
public class RFFragmentProperties
{
	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFColliderType colliderType;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sizeFilter;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool decompose;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool removeCollinear;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool l;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int layer;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool t;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string tag;

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xDE53E4", Offset = "0xDE53E4", VA = "0xDE53E4")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xDE5570", Offset = "0xDE5570", VA = "0xDE5570")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xDE6A70", Offset = "0xDE6A70", VA = "0xDE6A70")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xDE6AC0", Offset = "0xDE6AC0", VA = "0xDE6AC0")]
	public string GetTag(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200006D")]
public class RFLimitations
{
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535010", Offset = "0x535010")]
	private sealed class <DemolishableCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFLimitations <>4__this;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024B")]
			[Address(RVA = "0x12589A8", Offset = "0x12589A8", VA = "0x12589A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x12589F0", Offset = "0x12589F0", VA = "0x12589F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1258850", Offset = "0x1258850", VA = "0x1258850")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x125887C", Offset = "0x125887C", VA = "0x125887C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x1258880", Offset = "0x1258880", VA = "0x1258880", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x12589B0", Offset = "0x12589B0", VA = "0x12589B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool byCollision;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float solidity;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tag;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool visible;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool sliceByBlade;

	[NonSerialized]
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> slicePlanes;

	[NonSerialized]
	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ContactPoint contactPoint;

	[NonSerialized]
	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 contactVector3;

	[NonSerialized]
	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 contactNormal;

	[NonSerialized]
	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool demolitionShould;

	[NonSerialized]
	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool demolished;

	[NonSerialized]
	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float birthTime;

	[NonSerialized]
	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bboxSize;

	[NonSerialized]
	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int currentDepth;

	[NonSerialized]
	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool demolishableCorState;

	[NonSerialized]
	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sliceForce;

	[NonSerialized]
	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool affectInactive;

	[NonSerialized]
	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RayfireRigid ancestor;

	[NonSerialized]
	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RayfireRigid> descendants;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string rootStr;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string rigidStr;

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xDEF47C", Offset = "0xDEF47C", VA = "0xDEF47C")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xDEF5E4", Offset = "0xDEF5E4", VA = "0xDEF5E4")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xDEF534", Offset = "0xDEF534", VA = "0xDEF534")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xDEF658", Offset = "0xDEF658", VA = "0xDEF658")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538840", Offset = "0x538840")]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xDEF6EC", Offset = "0xDEF6EC", VA = "0xDEF6EC")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xDF13E4", Offset = "0xDF13E4", VA = "0xDF13E4")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0xDF14CC", Offset = "0xDF14CC", VA = "0xDF14CC")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xDF1628", Offset = "0xDF1628", VA = "0xDF1628")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xDE68F4", Offset = "0xDE68F4", VA = "0xDE68F4")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}
}
[Serializable]
[Token(Token = "0x200006F")]
public class RFPhysic
{
	[Token(Token = "0x2000070")]
	private struct RFIgnorePair
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int a;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int b;

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1258CC4", Offset = "0x1258CC4", VA = "0x1258CC4")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535020", Offset = "0x535020")]
	private sealed class <PhysicsDataCor>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPhysic <>4__this;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1258C74", Offset = "0x1258C74", VA = "0x1258C74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1258CBC", Offset = "0x1258CBC", VA = "0x1258CBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1258AB0", Offset = "0x1258AB0", VA = "0x1258AB0")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1258ADC", Offset = "0x1258ADC", VA = "0x1258ADC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1258AE0", Offset = "0x1258AE0", VA = "0x1258AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1258C7C", Offset = "0x1258C7C", VA = "0x1258C7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MaterialType materialType;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhysicMaterial material;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MassType massBy;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mass;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFColliderType colliderType;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool planarCheck;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool ignoreNear;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool useGravity;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int solverIterations;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float dampening;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody rigidBody;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider meshCollider;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Collider> clusterColliders;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<int> ignoreList;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool rec;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool exclude;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int solidity;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool destructible;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool physicsDataCorState;

	[NonSerialized]
	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector3 initScale;

	[NonSerialized]
	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 initPosition;

	[NonSerialized]
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Quaternion initRotation;

	[NonSerialized]
	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector3 localPosition;

	[NonSerialized]
	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public IEnumerator physicsEnum;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int coplanarVertLimit;

	[Token(Token = "0x1700003B")]
	public bool HasIgnore
	{
		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE7B60C", Offset = "0xE7B60C", VA = "0xE7B60C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE79D54", Offset = "0xE79D54", VA = "0xE79D54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public bool Destructible
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0xE7C2A0", Offset = "0xE7C2A0", VA = "0xE7C2A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003E")]
	public int Solidity
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE7C320", Offset = "0xE7C320", VA = "0xE7C320")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0xE7A574", Offset = "0xE7A574", VA = "0xE7A574")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xE77AD8", Offset = "0xE77AD8", VA = "0xE77AD8")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xE77BDC", Offset = "0xE77BDC", VA = "0xE77BDC")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xE77B9C", Offset = "0xE77B9C", VA = "0xE77B9C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xE77C6C", Offset = "0xE77C6C", VA = "0xE77C6C")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xE77CE4", Offset = "0xE77CE4", VA = "0xE77CE4")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xE77D44", Offset = "0xE77D44", VA = "0xE77D44")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xE77F1C", Offset = "0xE77F1C", VA = "0xE77F1C")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xE78020", Offset = "0xE78020", VA = "0xE78020")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xE7806C", Offset = "0xE7806C", VA = "0xE7806C")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xE780B4", Offset = "0xE780B4", VA = "0xE780B4")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xE77F5C", Offset = "0xE77F5C", VA = "0xE77F5C")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xE78104", Offset = "0xE78104", VA = "0xE78104")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xE78414", Offset = "0xE78414", VA = "0xE78414")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xE782A8", Offset = "0xE782A8", VA = "0xE782A8")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xE7851C", Offset = "0xE7851C", VA = "0xE7851C")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xE7855C", Offset = "0xE7855C", VA = "0xE7855C")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xE7864C", Offset = "0xE7864C", VA = "0xE7864C")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xE7869C", Offset = "0xE7869C", VA = "0xE7869C")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xE7896C", Offset = "0xE7896C", VA = "0xE7896C")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xE78AAC", Offset = "0xE78AAC", VA = "0xE78AAC")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xE79648", Offset = "0xE79648", VA = "0xE79648")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xE79860", Offset = "0xE79860", VA = "0xE79860")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xE79A50", Offset = "0xE79A50", VA = "0xE79A50")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xE79BE8", Offset = "0xE79BE8", VA = "0xE79BE8")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xE79DB0", Offset = "0xE79DB0", VA = "0xE79DB0")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xE7A008", Offset = "0xE7A008", VA = "0xE7A008")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xE7A11C", Offset = "0xE7A11C", VA = "0xE7A11C")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xE7A210", Offset = "0xE7A210", VA = "0xE7A210")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xE7A3A4", Offset = "0xE7A3A4", VA = "0xE7A3A4")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xE7A600", Offset = "0xE7A600", VA = "0xE7A600")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xE7A6AC", Offset = "0xE7A6AC", VA = "0xE7A6AC")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xE7A7DC", Offset = "0xE7A7DC", VA = "0xE7A7DC")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xE7A8DC", Offset = "0xE7A8DC", VA = "0xE7A8DC")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xE7AA70", Offset = "0xE7AA70", VA = "0xE7AA70")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xE7ABD8", Offset = "0xE7ABD8", VA = "0xE7ABD8")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xE7AF9C", Offset = "0xE7AF9C", VA = "0xE7AF9C")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xE7B1C8", Offset = "0xE7B1C8", VA = "0xE7B1C8")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xE7BCFC", Offset = "0xE7BCFC", VA = "0xE7BCFC")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xE7BE18", Offset = "0xE7BE18", VA = "0xE7BE18")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xE7B8E4", Offset = "0xE7B8E4", VA = "0xE7B8E4")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xE7B664", Offset = "0xE7B664", VA = "0xE7B664")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xE7BA90", Offset = "0xE7BA90", VA = "0xE7BA90")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xE7BFC0", Offset = "0xE7BFC0", VA = "0xE7BFC0")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xE78960", Offset = "0xE78960", VA = "0xE78960")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0xE7C20C", Offset = "0xE7C20C", VA = "0xE7C20C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5388F0", Offset = "0x5388F0")]
	public IEnumerator PhysicsDataCor(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000072")]
public class RFReferenceDemolition
{
	[Token(Token = "0x2000073")]
	public enum ActionType
	{
		[Token(Token = "0x40002C6")]
		Instantiate,
		[Token(Token = "0x40002C7")]
		SetActive
	}

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject reference;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> randomList;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionType action;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool addRigid;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool inheritScale;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inheritMaterials;

	[Token(Token = "0x6000288")]
	[Address(RVA = "0xE7D154", Offset = "0xE7D154", VA = "0xE7D154")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0xE7D194", Offset = "0xE7D194", VA = "0xE7D194")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0xE7D288", Offset = "0xE7D288", VA = "0xE7D288")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0xE7D4F4", Offset = "0xE7D4F4", VA = "0xE7D4F4")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0xE7DF98", Offset = "0xE7DF98", VA = "0xE7DF98")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0xE7E158", Offset = "0xE7E158", VA = "0xE7E158")]
	private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
	{
	}
}
[Serializable]
[Token(Token = "0x2000074")]
public class RFReset
{
	[Token(Token = "0x2000075")]
	public enum PostDemolitionType
	{
		[Token(Token = "0x40002D1")]
		DestroyWithDelay,
		[Token(Token = "0x40002D2")]
		DeactivateToReset
	}

	[Token(Token = "0x2000076")]
	public enum MeshResetType
	{
		[Token(Token = "0x40002D4")]
		Destroy = 0,
		[Token(Token = "0x40002D5")]
		ReuseInputMesh = 2,
		[Token(Token = "0x40002D6")]
		ReuseFragmentMeshes = 4
	}

	[Token(Token = "0x2000077")]
	public enum FragmentsResetType
	{
		[Token(Token = "0x40002D8")]
		Destroy = 0,
		[Token(Token = "0x40002D9")]
		Reuse = 2,
		[Token(Token = "0x40002DA")]
		Preserve = 4
	}

	[Serializable]
	[Token(Token = "0x2000078")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535030", Offset = "0x535030")]
	private sealed class <>c
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RayfireRigid, bool> <>9__24_0;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<RayfireRigid, bool> <>9__24_1;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<RayfireRigid, bool> <>9__30_0;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<RayfireRigid, bool> <>9__30_1;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<RayfireRigid, bool> <>9__30_2;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x1259134", Offset = "0x1259134", VA = "0x1259134")]
		public <>c()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x125913C", Offset = "0x125913C", VA = "0x125913C")]
		internal bool <DestroyFragments>b__24_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x12591A4", Offset = "0x12591A4", VA = "0x12591A4")]
		internal bool <DestroyFragments>b__24_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x125920C", Offset = "0x125920C", VA = "0x125920C")]
		internal bool <FragmentReuseState>b__30_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x1259274", Offset = "0x1259274", VA = "0x1259274")]
		internal bool <FragmentReuseState>b__30_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x1259298", Offset = "0x1259298", VA = "0x1259298")]
		internal bool <FragmentReuseState>b__30_2(RayfireRigid t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool transform;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool damage;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool connectivity;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PostDemolitionType action;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float destroyDelay;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MeshResetType mesh;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FragmentsResetType fragments;

	[NonSerialized]
	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toBeDestroyed;

	[Token(Token = "0x600028E")]
	[Address(RVA = "0xE7E34C", Offset = "0xE7E34C", VA = "0xE7E34C")]
	public RFReset()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0xE7E390", Offset = "0xE7E390", VA = "0xE7E390")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0xE7E3F4", Offset = "0xE7E3F4", VA = "0xE7E3F4")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0xE7EDD4", Offset = "0xE7EDD4", VA = "0xE7EDD4")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xE7E68C", Offset = "0xE7E68C", VA = "0xE7E68C")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xE7F51C", Offset = "0xE7F51C", VA = "0xE7F51C")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xE7F6CC", Offset = "0xE7F6CC", VA = "0xE7F6CC")]
	public static void DestroyMeshRootParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xE7F860", Offset = "0xE7F860", VA = "0xE7F860")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xE7FFEC", Offset = "0xE7FFEC", VA = "0xE7FFEC")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xE7FD60", Offset = "0xE7FD60", VA = "0xE7FD60")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xE7FBCC", Offset = "0xE7FBCC", VA = "0xE7FBCC")]
	public static void DestroyRigidRootParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xE80290", Offset = "0xE80290", VA = "0xE80290")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xE7F05C", Offset = "0xE7F05C", VA = "0xE7F05C")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xE80B48", Offset = "0xE80B48", VA = "0xE80B48")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xE7F208", Offset = "0xE7F208", VA = "0xE7F208")]
	public static void DestroyRigidParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xE806E0", Offset = "0xE806E0", VA = "0xE806E0")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xE8133C", Offset = "0xE8133C", VA = "0xE8133C")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xE7F140", Offset = "0xE7F140", VA = "0xE7F140")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xE7E540", Offset = "0xE7E540", VA = "0xE7E540")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xE80414", Offset = "0xE80414", VA = "0xE80414")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xE7EABC", Offset = "0xE7EABC", VA = "0xE7EABC")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xE7EBB8", Offset = "0xE7EBB8", VA = "0xE7EBB8")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xE7F16C", Offset = "0xE7F16C", VA = "0xE7F16C")]
	public static void ResetSound(RayfireSound scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public class RFRuntimeCaching
{
	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CachingType type;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536EF0", Offset = "0x536EF0")]
	public int frames;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x536F0C", Offset = "0x536F0C")]
	public int fragments;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool skipFirstDemolition;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[HideInInspector]
	public bool wasUsed;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[HideInInspector]
	public bool stop;

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xE8164C", Offset = "0xE8164C", VA = "0xE8164C")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xE8167C", Offset = "0xE8167C", VA = "0xE8167C")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xE81840", Offset = "0xE81840", VA = "0xE81840")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xE8192C", Offset = "0xE8192C", VA = "0xE8192C")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xE81A7C", Offset = "0xE81A7C", VA = "0xE81A7C")]
	public static GameObject CreateTmRef(RayfireRigid rfScr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200007A")]
public class RFMirrored
{
	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PlaneType planeType;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool noPoints;

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xDF34E0", Offset = "0xDF34E0", VA = "0xDF34E0")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xDEF1B8", Offset = "0xDEF1B8", VA = "0xDEF1B8")]
	public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200007B")]
public class RFCustom
{
	[Token(Token = "0x200007C")]
	public enum RFPointCloudSourceType
	{
		[Token(Token = "0x40002F5")]
		ChildrenTransform = 4,
		[Token(Token = "0x40002F6")]
		TransformList = 8,
		[Token(Token = "0x40002F7")]
		Vector3List = 12
	}

	[Token(Token = "0x200007D")]
	public enum RFPointCloudUseType
	{
		[Token(Token = "0x40002F9")]
		VolumePoints = 4,
		[Token(Token = "0x40002FA")]
		PointCloud = 12
	}

	[Token(Token = "0x200007E")]
	public enum RFModifierType
	{
		[Token(Token = "0x40002FC")]
		None = 0,
		[Token(Token = "0x40002FD")]
		Splinters = 3,
		[Token(Token = "0x40002FE")]
		Slabs = 6
	}

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFPointCloudSourceType source;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFPointCloudUseType useAs;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float radius;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool enable;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> transforms;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> vector3;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noPoints;

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x100650C", Offset = "0x100650C", VA = "0x100650C")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x100655C", Offset = "0x100655C", VA = "0x100655C")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x10065D4", Offset = "0x10065D4", VA = "0x10065D4")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x100669C", Offset = "0x100669C", VA = "0x100669C")]
	private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1006958", Offset = "0x1006958", VA = "0x1006958")]
	private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x1006B98", Offset = "0x1006B98", VA = "0x1006B98")]
	private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1006C8C", Offset = "0x1006C8C", VA = "0x1006C8C")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1006D04", Offset = "0x1006D04", VA = "0x1006D04")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200007F")]
public static class RFFragment
{
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535040", Offset = "0x535040")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFSlice slices;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x125882C", Offset = "0x125882C", VA = "0x125882C")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1258834", Offset = "0x1258834", VA = "0x1258834")]
		internal Vector3 <SetSlices>b__1(Transform t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535050", Offset = "0x535050")]
	private sealed class <>c
	{
		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Transform, Vector3> <>9__29_0;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1258808", Offset = "0x1258808", VA = "0x1258808")]
		public <>c()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1258810", Offset = "0x1258810", VA = "0x1258810")]
		internal Vector3 <SetSlices>b__29_0(Transform t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool silentMode;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Mesh> meshListStatic;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<Vector3> pivotListStatic;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<Dictionary<int, int>> subIdsListStatic;

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xDEAD38", Offset = "0xDEAD38", VA = "0xDEAD38")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xDEC2A4", Offset = "0xDEC2A4", VA = "0xDEC2A4")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xDEC5EC", Offset = "0xDEC5EC", VA = "0xDEC5EC")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xDE8244", Offset = "0xDE8244", VA = "0xDE8244")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xDECAF4", Offset = "0xDECAF4", VA = "0xDECAF4")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xDE8314", Offset = "0xDE8314", VA = "0xDE8314")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xDED5B4", Offset = "0xDED5B4", VA = "0xDED5B4")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xDED430", Offset = "0xDED430", VA = "0xDED430")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xDED398", Offset = "0xDED398", VA = "0xDED398")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xDEB3B8", Offset = "0xDEB3B8", VA = "0xDEB3B8")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xDE7448", Offset = "0xDE7448", VA = "0xDE7448")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xDEBD10", Offset = "0xDEBD10", VA = "0xDEBD10")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xDEB2E8", Offset = "0xDEB2E8", VA = "0xDEB2E8")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xDED998", Offset = "0xDED998", VA = "0xDED998")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xDEB85C", Offset = "0xDEB85C", VA = "0xDEB85C")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xDECCA4", Offset = "0xDECCA4", VA = "0xDECCA4")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xDEB4A8", Offset = "0xDEB4A8", VA = "0xDEB4A8")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xDEED54", Offset = "0xDEED54", VA = "0xDEED54")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xDEEED8", Offset = "0xDEEED8", VA = "0xDEEED8")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xDEDA18", Offset = "0xDEDA18", VA = "0xDEDA18")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xDEDB5C", Offset = "0xDEDB5C", VA = "0xDEDB5C")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xDEDCC0", Offset = "0xDEDCC0", VA = "0xDEDCC0")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xDEDE24", Offset = "0xDEDE24", VA = "0xDEDE24")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xDEE084", Offset = "0xDEE084", VA = "0xDEE084")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xDEF0FC", Offset = "0xDEF0FC", VA = "0xDEF0FC")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xDEE17C", Offset = "0xDEE17C", VA = "0xDEE17C")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xDEE4F4", Offset = "0xDEE4F4", VA = "0xDEE4F4")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xDEE72C", Offset = "0xDEE72C", VA = "0xDEE72C")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xDEF254", Offset = "0xDEF254", VA = "0xDEF254")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xDEE7A8", Offset = "0xDEE7A8", VA = "0xDEE7A8")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xDEEAFC", Offset = "0xDEEAFC", VA = "0xDEEAFC")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xDEEB58", Offset = "0xDEEB58", VA = "0xDEEB58")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xDEEFB8", Offset = "0xDEEFB8", VA = "0xDEEFB8")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xDEF0D4", Offset = "0xDEF0D4", VA = "0xDEF0D4")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xDEF268", Offset = "0xDEF268", VA = "0xDEF268")]
	public static void RescaleMesh(Mesh mesh, float scale)
	{
	}
}
[Serializable]
[Token(Token = "0x2000082")]
public class RFMeshExport
{
	[Token(Token = "0x2000083")]
	public enum MeshExportType
	{
		[Token(Token = "0x4000309")]
		LastFragments = 0,
		[Token(Token = "0x400030A")]
		Children = 3
	}

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshExportType source;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string suffix;

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xDF3484", Offset = "0xDF3484", VA = "0xDF3484")]
	public RFMeshExport()
	{
	}
}
[Serializable]
[Token(Token = "0x2000084")]
public class RFShatterAdvanced
{
	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int seed;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool decompose;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool removeCollinear;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool copyComponents;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool postWeld;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool smooth;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool inputPrecap;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool outputPrecap;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool removeDoubleFaces;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int elementSizeThreshold;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool combineChildren;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inner;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool planar;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int relativeSize;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float absoluteSize;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool sizeLimitation;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeAmount;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool vertexLimitation;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int vertexAmount;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool triangleLimitation;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int triangleAmount;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float planarThreshold;

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xE84CE4", Offset = "0xE84CE4", VA = "0xE84CE4")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xE84D58", Offset = "0xE84D58", VA = "0xE84D58")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xE78FC4", Offset = "0xE78FC4", VA = "0xE78FC4")]
	public static bool IsCoplanar(Mesh mesh, float threshold)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000085")]
public class RFSurface
{
	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material innerMaterial;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float mappingScale;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material outerMaterial;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool needNewMat;

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xE89FBC", Offset = "0xE89FBC", VA = "0xE89FBC")]
	public RFSurface()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xE8A00C", Offset = "0xE8A00C", VA = "0xE8A00C")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xE8A060", Offset = "0xE8A060", VA = "0xE8A060")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xE8A308", Offset = "0xE8A308", VA = "0xE8A308")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xE8A480", Offset = "0xE8A480", VA = "0xE8A480")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000086")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535060", Offset = "0x535060")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535060", Offset = "0x535060")]
public class RayfireActivator : MonoBehaviour
{
	[Token(Token = "0x2000087")]
	public enum ActivationType
	{
		[Token(Token = "0x4000349")]
		OnTriggerEnter,
		[Token(Token = "0x400034A")]
		OnTriggerExit,
		[Token(Token = "0x400034B")]
		OnCollision
	}

	[Token(Token = "0x2000088")]
	public enum AnimationType
	{
		[Token(Token = "0x400034D")]
		ByGlobalPositionList = 0,
		[Token(Token = "0x400034E")]
		ByStaticLine = 1,
		[Token(Token = "0x400034F")]
		ByDynamicLine = 2,
		[Token(Token = "0x4000350")]
		ByLocalPositionList = 5
	}

	[Token(Token = "0x2000089")]
	public enum GizmoType
	{
		[Token(Token = "0x4000352")]
		Box = 1,
		[Token(Token = "0x4000353")]
		Sphere = 0,
		[Token(Token = "0x4000354")]
		Collider = 2,
		[Token(Token = "0x4000355")]
		ParticleSystem = 5
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5350C0", Offset = "0x5350C0")]
	private sealed class <DelayedActivationCor>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x125A514", Offset = "0x125A514", VA = "0x125A514", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000312")]
			[Address(RVA = "0x125A55C", Offset = "0x125A55C", VA = "0x125A55C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x125A3D0", Offset = "0x125A3D0", VA = "0x125A3D0")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x125A3FC", Offset = "0x125A3FC", VA = "0x125A3FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x125A400", Offset = "0x125A400", VA = "0x125A400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x125A51C", Offset = "0x125A51C", VA = "0x125A51C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5350D0", Offset = "0x5350D0")]
	private sealed class <DelayedClusterCor>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000316")]
			[Address(RVA = "0x125A90C", Offset = "0x125A90C", VA = "0x125A90C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x125A954", Offset = "0x125A954", VA = "0x125A954", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x125A6F8", Offset = "0x125A6F8", VA = "0x125A6F8")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x125A724", Offset = "0x125A724", VA = "0x125A724", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x125A728", Offset = "0x125A728", VA = "0x125A728", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x125A914", Offset = "0x125A914", VA = "0x125A914", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5350E0", Offset = "0x5350E0")]
	private sealed class <DelayedActivationCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x125A6A8", Offset = "0x125A6A8", VA = "0x125A6A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x125A6F0", Offset = "0x125A6F0", VA = "0x125A6F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x125A564", Offset = "0x125A564", VA = "0x125A564")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x125A590", Offset = "0x125A590", VA = "0x125A590", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x125A594", Offset = "0x125A594", VA = "0x125A594", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x125A6B0", Offset = "0x125A6B0", VA = "0x125A6B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5350F0", Offset = "0x5350F0")]
	private sealed class <AnimationCor>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000322")]
			[Address(RVA = "0x125A380", Offset = "0x125A380", VA = "0x125A380", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x125A3C8", Offset = "0x125A3C8", VA = "0x125A3C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1259F90", Offset = "0x1259F90", VA = "0x1259F90")]
		[DebuggerHidden]
		public <AnimationCor>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1259FBC", Offset = "0x1259FBC", VA = "0x1259FBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1259FC0", Offset = "0x1259FC0", VA = "0x1259FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x125A388", Offset = "0x125A388", VA = "0x125A388", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GizmoType gizmoType;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sphereRadius;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 boxSize;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool checkRigid;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool checkRigidRoot;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ActivationType type;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool demolishCluster;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool apply;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 velocity;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 spin;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ForceMode mode;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool coord;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showAnimation;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float duration;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float scaleAnimation;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AnimationType positionAnimation;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LineRenderer line;

	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Vector3> positionList;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool showGizmo;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider activatorCollider;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleSystem ps;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool animating;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float pathRatio;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lineLength;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<float> checkpoints;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float delta;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float deltaRatioStep;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float distDeltaStep;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float distRatio;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float timePassed;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int activeSegment;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 positionStart;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 scaleStart;

	[Token(Token = "0x17000042")]
	public bool ByPositions
	{
		[Token(Token = "0x600030A")]
		[Address(RVA = "0xE8C734", Offset = "0xE8C734", VA = "0xE8C734")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public bool ByLine
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0xE8BB48", Offset = "0xE8BB48", VA = "0xE8BB48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xE8A990", Offset = "0xE8A990", VA = "0xE8A990")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xE8AE6C", Offset = "0xE8AE6C", VA = "0xE8AE6C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xE8AF18", Offset = "0xE8AF18", VA = "0xE8AF18")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xE8B060", Offset = "0xE8B060", VA = "0xE8B060")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xE8B070", Offset = "0xE8B070", VA = "0xE8B070")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xE8AA08", Offset = "0xE8AA08", VA = "0xE8AA08")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xE8AC70", Offset = "0xE8AC70", VA = "0xE8AC70")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xE8AEC8", Offset = "0xE8AEC8", VA = "0xE8AEC8")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xE8B084", Offset = "0xE8B084", VA = "0xE8B084")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xE8B500", Offset = "0xE8B500", VA = "0xE8B500")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5389A0", Offset = "0x5389A0")]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xE8B594", Offset = "0xE8B594", VA = "0xE8B594")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538A00", Offset = "0x538A00")]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xE8B4B8", Offset = "0xE8B4B8", VA = "0xE8B4B8")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0xE8B2E4", Offset = "0xE8B2E4", VA = "0xE8B2E4")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xE8B8F4", Offset = "0xE8B8F4", VA = "0xE8B8F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538A60", Offset = "0x538A60")]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xE8B75C", Offset = "0xE8B75C", VA = "0xE8B75C")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xE8B63C", Offset = "0xE8B63C", VA = "0xE8B63C")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xE8B99C", Offset = "0xE8B99C", VA = "0xE8B99C")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xE8BA84", Offset = "0xE8BA84", VA = "0xE8BA84")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0xE8BB5C", Offset = "0xE8BB5C", VA = "0xE8BB5C")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xE8BD80", Offset = "0xE8BD80", VA = "0xE8BD80")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xE8BF60", Offset = "0xE8BF60", VA = "0xE8BF60")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xE8BAD0", Offset = "0xE8BAD0", VA = "0xE8BAD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538AC0", Offset = "0x538AC0")]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xE8C208", Offset = "0xE8C208", VA = "0xE8C208")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xE8C31C", Offset = "0xE8C31C", VA = "0xE8C31C")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xE8C384", Offset = "0xE8C384", VA = "0xE8C384")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xE8C38C", Offset = "0xE8C38C", VA = "0xE8C38C")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xE8C3CC", Offset = "0xE8C3CC", VA = "0xE8C3CC")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xE8C668", Offset = "0xE8C668", VA = "0xE8C668")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xE8C750", Offset = "0xE8C750", VA = "0xE8C750")]
	public RayfireActivator()
	{
	}
}
[Token(Token = "0x200008E")]
public class RFSliceData
{
	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 planePos;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 planeDir;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 swingDir;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float swingStr;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float force;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float damage;

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xE8531C", Offset = "0xE8531C", VA = "0xE8531C")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x200008F")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535100", Offset = "0x535100")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535100", Offset = "0x535100")]
public class RayfireBlade : MonoBehaviour
{
	[Token(Token = "0x2000090")]
	public enum CutType
	{
		[Token(Token = "0x4000384")]
		Enter,
		[Token(Token = "0x4000385")]
		Exit,
		[Token(Token = "0x4000386")]
		EnterExit
	}

	[Token(Token = "0x2000091")]
	public enum ActionType
	{
		[Token(Token = "0x4000388")]
		Slice,
		[Token(Token = "0x4000389")]
		Demolish
	}

	[Token(Token = "0x2000092")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535160", Offset = "0x535160")]
	private sealed class <CooldownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBlade <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600033B")]
			[Address(RVA = "0x125AA70", Offset = "0x125AA70", VA = "0x125AA70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600033D")]
			[Address(RVA = "0x125AAB8", Offset = "0x125AAB8", VA = "0x125AAB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x125A95C", Offset = "0x125A95C", VA = "0x125A95C")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x125A988", Offset = "0x125A988", VA = "0x125A988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x125A98C", Offset = "0x125A98C", VA = "0x125A98C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x125AA78", Offset = "0x125AA78", VA = "0x125AA78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionType actionType;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public CutType onTrigger;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaneType sliceType;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool affectInactive;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float damage;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool skin;

	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cooldown;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int mask;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string tagFilter;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> targets;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transForm;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3[] enterPlane;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] exitPlane;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Collider colLider;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3[] slicePlanes;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool coolDownState;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RFSliceData sliceData;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 posEnter;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 posExit;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFSliceEvent sliceEvent;

	[Token(Token = "0x1700004C")]
	public bool HasTargets
	{
		[Token(Token = "0x6000335")]
		[Address(RVA = "0xE63E4C", Offset = "0xE63E4C", VA = "0xE63E4C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xE63110", Offset = "0xE63110", VA = "0xE63110")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xE63114", Offset = "0xE63114", VA = "0xE63114")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xE6334C", Offset = "0xE6334C", VA = "0xE6334C")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xE63428", Offset = "0xE63428", VA = "0xE63428")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xE63350", Offset = "0xE63350", VA = "0xE63350")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xE6342C", Offset = "0xE6342C", VA = "0xE6342C")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0xE638FC", Offset = "0xE638FC", VA = "0xE638FC")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0xE63B2C", Offset = "0xE63B2C", VA = "0xE63B2C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538C60", Offset = "0x538C60")]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0xE63BA4", Offset = "0xE63BA4", VA = "0xE63BA4")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0xE63A24", Offset = "0xE63A24", VA = "0xE63A24")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0xE63BCC", Offset = "0xE63BCC", VA = "0xE63BCC")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0xE6372C", Offset = "0xE6372C", VA = "0xE6372C")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0xE63AE0", Offset = "0xE63AE0", VA = "0xE63AE0")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0xE63638", Offset = "0xE63638", VA = "0xE63638")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0xE63CF4", Offset = "0xE63CF4", VA = "0xE63CF4")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0xE63BB0", Offset = "0xE63BB0", VA = "0xE63BB0")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0xE63EA4", Offset = "0xE63EA4", VA = "0xE63EA4")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000093")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535170", Offset = "0x535170")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535170", Offset = "0x535170")]
public class RayfireBomb : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	public enum RangeType
	{
		[Token(Token = "0x40003AC")]
		Spherical
	}

	[Token(Token = "0x2000095")]
	public enum FadeType
	{
		[Token(Token = "0x40003AE")]
		Linear = 0,
		[Token(Token = "0x40003AF")]
		Exponential = 1,
		[Token(Token = "0x40003B0")]
		ByCurve = 3,
		[Token(Token = "0x40003B1")]
		None = 2
	}

	[Serializable]
	[Token(Token = "0x2000096")]
	public class Projectile
	{
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionPivot;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 positionClosest;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fade;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rb;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayfireRigid rigid;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion rotation;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RFShard shard;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x125AC00", Offset = "0x125AC00", VA = "0x125AC00")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5351D0", Offset = "0x5351D0")]
	private sealed class <ExplodeCor>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x125ABB0", Offset = "0x125ABB0", VA = "0x125ABB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x125ABF8", Offset = "0x125ABF8", VA = "0x125ABF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x125AAC0", Offset = "0x125AAC0", VA = "0x125AAC0")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x125AAEC", Offset = "0x125AAEC", VA = "0x125AAEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x125AAF0", Offset = "0x125AAF0", VA = "0x125AAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x125ABB8", Offset = "0x125ABB8", VA = "0x125ABB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showGizmo;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RangeType rangeType;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeType fadeType;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int deletion;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int variation;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int chaos;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool forceByMass;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool affectInactive;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool affectKinematic;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float heightOffset;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool atStart;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool destroy;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool applyDamage;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damageValue;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve curve;

	[Token(Token = "0x400039F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool play;

	[Token(Token = "0x40003A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float volume;

	[Token(Token = "0x40003A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AudioClip clip;

	[Token(Token = "0x40003A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFExplosionEvent explosionEvent;

	[Token(Token = "0x40003A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Vector3 bombPosition;

	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public Vector3 explPosition;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public int mask;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public string tagFilter;

	[NonSerialized]
	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Projectile> projectiles;

	[NonSerialized]
	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private List<Projectile> deletionProjectiles;

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xE63F54", Offset = "0xE63F54", VA = "0xE63F54")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xE63FE4", Offset = "0xE63FE4", VA = "0xE63FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xE64080", Offset = "0xE64080", VA = "0xE64080")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xE64028", Offset = "0xE64028", VA = "0xE64028")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xE6423C", Offset = "0xE6423C", VA = "0xE6423C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538D10", Offset = "0x538D10")]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xE64128", Offset = "0xE64128", VA = "0xE64128")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xE64E94", Offset = "0xE64E94", VA = "0xE64E94")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xE64364", Offset = "0xE64364", VA = "0xE64364")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xE63F58", Offset = "0xE63F58", VA = "0xE63F58")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xE65628", Offset = "0xE65628", VA = "0xE65628")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xE65650", Offset = "0xE65650", VA = "0xE65650")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xE642B4", Offset = "0xE642B4", VA = "0xE642B4")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xE64F5C", Offset = "0xE64F5C", VA = "0xE64F5C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xE64FA8", Offset = "0xE64FA8", VA = "0xE64FA8")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xE643D0", Offset = "0xE643D0", VA = "0xE643D0")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xE645CC", Offset = "0xE645CC", VA = "0xE645CC")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xE648DC", Offset = "0xE648DC", VA = "0xE648DC")]
	private void Activate()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xE64C54", Offset = "0xE64C54", VA = "0xE64C54")]
	private void SetForce()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xE658E0", Offset = "0xE658E0", VA = "0xE658E0")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xE65AAC", Offset = "0xE65AAC", VA = "0xE65AAC")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xE65B08", Offset = "0xE65B08", VA = "0xE65B08")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000098")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5351E0", Offset = "0x5351E0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5351E0", Offset = "0x5351E0")]
[SelectionBase]
public class RayfireCluster : MonoBehaviour
{
	[Token(Token = "0x2000099")]
	public enum ClusterType
	{
		[Token(Token = "0x40003CF")]
		ByPointCloud,
		[Token(Token = "0x40003D0")]
		BySharedArea
	}

	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535250", Offset = "0x535250")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFShard biggestShard;

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x125AC08", Offset = "0x125AC08", VA = "0x125AC08")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x125AC10", Offset = "0x125AC10", VA = "0x125AC10")]
		internal bool <ClusterizeRangeShards>b__0(RFShard t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535260", Offset = "0x535260")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFCluster biggestCluster;

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x125AC40", Offset = "0x125AC40", VA = "0x125AC40")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x125AC48", Offset = "0x125AC48", VA = "0x125AC48")]
		internal bool <ClusterizeRangeClusters>b__0(RFCluster t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x536FC4", Offset = "0x536FC4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536FC4", Offset = "0x536FC4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x536FC4", Offset = "0x536FC4")]
	public ClusterType type;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x537034", Offset = "0x537034")]
	public int depth;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53704C", Offset = "0x53704C")]
	public int seed;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x537068", Offset = "0x537068")]
	public int smoothPass;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537080", Offset = "0x537080")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x537080", Offset = "0x537080")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x537080", Offset = "0x537080")]
	public int baseAmount;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5370F8", Offset = "0x5370F8")]
	public int depthAmount;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x537114", Offset = "0x537114")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537114", Offset = "0x537114")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x537114", Offset = "0x537114")]
	public int minimumAmount;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x537188", Offset = "0x537188")]
	public int maximumAmount;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool showGizmo;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool colorPreview;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool scalePreview;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Color wireColor;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public float previewScale;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public List<RFCluster> allClusters;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFShard> allShards;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int clusterId;

	[Token(Token = "0x600035A")]
	[Address(RVA = "0xE65E70", Offset = "0xE65E70", VA = "0xE65E70")]
	public void Extract()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xE660E0", Offset = "0xE660E0", VA = "0xE660E0")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xE66170", Offset = "0xE66170", VA = "0xE66170")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xE66AD8", Offset = "0xE66AD8", VA = "0xE66AD8")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xE682A8", Offset = "0xE682A8", VA = "0xE682A8")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xE663E4", Offset = "0xE663E4", VA = "0xE663E4")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xE68F0C", Offset = "0xE68F0C", VA = "0xE68F0C")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xE693B4", Offset = "0xE693B4", VA = "0xE693B4")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xE678F8", Offset = "0xE678F8", VA = "0xE678F8")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xE69D14", Offset = "0xE69D14", VA = "0xE69D14")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xE676CC", Offset = "0xE676CC", VA = "0xE676CC")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xE6A6B8", Offset = "0xE6A6B8", VA = "0xE6A6B8")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xE69AF8", Offset = "0xE69AF8", VA = "0xE69AF8")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xE66990", Offset = "0xE66990", VA = "0xE66990")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xE67334", Offset = "0xE67334", VA = "0xE67334")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xE68D14", Offset = "0xE68D14", VA = "0xE68D14")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xE6A808", Offset = "0xE6A808", VA = "0xE6A808")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xE69760", Offset = "0xE69760", VA = "0xE69760")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xE6754C", Offset = "0xE6754C", VA = "0xE6754C")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xE6AB60", Offset = "0xE6AB60", VA = "0xE6AB60")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x200009C")]
public class RFCombineMesh
{
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535270", Offset = "0x535270")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transForm;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> transList;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<Vector3, Vector3> <>9__0;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x101CE34", Offset = "0x101CE34", VA = "0x101CE34")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x101CE3C", Offset = "0x101CE3C", VA = "0x101CE3C")]
		internal Vector3 <GetCombinedMesh>b__0(Vector3 t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535280", Offset = "0x535280")]
	private sealed class <>c
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Vector3, Vector3> <>9__7_1;

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x101CDB0", Offset = "0x101CDB0", VA = "0x101CDB0")]
		public <>c()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x101CDB8", Offset = "0x101CDB8", VA = "0x101CDB8")]
		internal Vector3 <GetCombinedMesh>b__7_1(Vector3 o)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535290", Offset = "0x535290")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Material> allMaterials;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Material, int> <>9__0;

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x101CDC8", Offset = "0x101CDC8", VA = "0x101CDC8")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x101CDD0", Offset = "0x101CDD0", VA = "0x101CDD0")]
		internal int <GetMatIdList>b__0(Material t)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> trianglesSubId;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<int>> triangles;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> vertices;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector2> uvs;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> tangents;

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x1004B24", Offset = "0x1004B24", VA = "0x1004B24")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x1004D04", Offset = "0x1004D04", VA = "0x1004D04")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x1005484", Offset = "0x1005484", VA = "0x1005484")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x100565C", Offset = "0x100565C", VA = "0x100565C")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x1005828", Offset = "0x1005828", VA = "0x1005828")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x1005C08", Offset = "0x1005C08", VA = "0x1005C08")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x1005E04", Offset = "0x1005E04", VA = "0x1005E04")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x1006018", Offset = "0x1006018", VA = "0x1006018")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x20000A0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5352A0", Offset = "0x5352A0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5352A0", Offset = "0x5352A0")]
public class RayfireCombine : MonoBehaviour
{
	[Token(Token = "0x20000A1")]
	public enum CombType
	{
		[Token(Token = "0x40003F5")]
		Children,
		[Token(Token = "0x40003F6")]
		ObjectsList
	}

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombType type;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool meshFilters;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skinnedMeshes;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool particleSystems;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeThreshold;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexThreshold;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform transForm;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mFilter;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<bool> invertNormals;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Transform> transList;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<MeshFilter> mFilters;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SkinnedMeshRenderer> skinnedMeshRends;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ParticleSystemRenderer> particleRends;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Mesh> meshList;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<int>> matIdList;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<Material>> matList;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Material> allMaterials;

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xE6AC90", Offset = "0xE6AC90", VA = "0xE6AC90")]
	public void Combine()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xE6AD6C", Offset = "0xE6AD6C", VA = "0xE6AD6C")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xE6C628", Offset = "0xE6C628", VA = "0xE6C628")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x20000A2")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535300", Offset = "0x535300")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535300", Offset = "0x535300")]
public class RayfireConnectivity : MonoBehaviour
{
	[Token(Token = "0x20000A3")]
	public enum RFConnInitType
	{
		[Token(Token = "0x400041A")]
		AtStart = 1,
		[Token(Token = "0x400041B")]
		ByMethod = 3,
		[Token(Token = "0x400041C")]
		ByIntegrity = 5
	}

	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535370", Offset = "0x535370")]
	private sealed class <ConnectivityCor>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x125AE88", Offset = "0x125AE88", VA = "0x125AE88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x125AED0", Offset = "0x125AED0", VA = "0x125AED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x125AD9C", Offset = "0x125AD9C", VA = "0x125AD9C")]
		[DebuggerHidden]
		public <ConnectivityCor>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x125ADC8", Offset = "0x125ADC8", VA = "0x125ADC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x125ADCC", Offset = "0x125ADCC", VA = "0x125ADCC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x125AE90", Offset = "0x125AE90", VA = "0x125AE90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535380", Offset = "0x535380")]
	private sealed class <ChildrenCor>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <checkChildren>5__2;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x125AD4C", Offset = "0x125AD4C", VA = "0x125AD4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x125AD94", Offset = "0x125AD94", VA = "0x125AD94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x125AC78", Offset = "0x125AC78", VA = "0x125AC78")]
		[DebuggerHidden]
		public <ChildrenCor>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x125ACA4", Offset = "0x125ACA4", VA = "0x125ACA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x125ACA8", Offset = "0x125ACA8", VA = "0x125ACA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x125AD54", Offset = "0x125AD54", VA = "0x125AD54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConnectivityType type;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expand;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minimumArea;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumSize;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int percentage;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int seed;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool clusterize;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool demolishable;

	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public RFConnInitType startCollapse;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int collapseByIntegrity;

	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCollapse collapse;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFConnInitType startStress;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int stressByIntegrity;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFStress stress;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showConnections;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showNodes;

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool showGizmo;

	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool showStress;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool checkConnectivity;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool connectivityCheckNeed;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFCluster cluster;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int initShardAmount;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int clsCount;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RayfireRigidRoot rigidRootHost;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RayfireRigid meshRootHost;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Collider triggerCollider;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int triggerDebris;

	[NonSerialized]
	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool childrenChanged;

	[NonSerialized]
	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool childrenCorState;

	[NonSerialized]
	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	private bool connectivityCorState;

	[NonSerialized]
	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	private bool corState;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFConnectivityEvent connectivityEvent;

	[Token(Token = "0x17000051")]
	public float AmountIntegrity
	{
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xE6E478", Offset = "0xE6E478", VA = "0xE6E478")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xE6C650", Offset = "0xE6C650", VA = "0xE6C650")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xE6C7A8", Offset = "0xE6C7A8", VA = "0xE6C7A8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xE6C7B4", Offset = "0xE6C7B4", VA = "0xE6C7B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xE6C9A4", Offset = "0xE6C9A4", VA = "0xE6C9A4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xE6CB68", Offset = "0xE6CB68", VA = "0xE6CB68")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xE6D284", Offset = "0xE6D284", VA = "0xE6D284")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xE6D314", Offset = "0xE6D314", VA = "0xE6D314")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xE6D494", Offset = "0xE6D494", VA = "0xE6D494")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xE6CD58", Offset = "0xE6CD58", VA = "0xE6CD58")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xE6D02C", Offset = "0xE6D02C", VA = "0xE6D02C")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xE6DD04", Offset = "0xE6DD04", VA = "0xE6DD04")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xE6D578", Offset = "0xE6D578", VA = "0xE6D578")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xE6D794", Offset = "0xE6D794", VA = "0xE6D794")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xE6DDE0", Offset = "0xE6DDE0", VA = "0xE6DDE0")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xE6C92C", Offset = "0xE6C92C", VA = "0xE6C92C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538DC0", Offset = "0x538DC0")]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xE6E13C", Offset = "0xE6E13C", VA = "0xE6E13C")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xE6E354", Offset = "0xE6E354", VA = "0xE6E354")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xE6E230", Offset = "0xE6E230", VA = "0xE6E230")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xE6E920", Offset = "0xE6E920", VA = "0xE6E920")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xE6EE88", Offset = "0xE6EE88", VA = "0xE6EE88")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xE6E4E8", Offset = "0xE6E4E8", VA = "0xE6E4E8")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xE6E710", Offset = "0xE6E710", VA = "0xE6E710")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xE6EB64", Offset = "0xE6EB64", VA = "0xE6EB64")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xE6EC78", Offset = "0xE6EC78", VA = "0xE6EC78")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xE6FD8C", Offset = "0xE6FD8C", VA = "0xE6FD8C")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xE6C8B4", Offset = "0xE6C8B4", VA = "0xE6C8B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538E20", Offset = "0x538E20")]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xE6FD98", Offset = "0xE6FD98", VA = "0xE6FD98")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0xE70134", Offset = "0xE70134", VA = "0xE70134")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0xE6CF00", Offset = "0xE6CF00", VA = "0xE6CF00")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0xE7016C", Offset = "0xE7016C", VA = "0xE7016C")]
	public void Fracture()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0xE70178", Offset = "0xE70178", VA = "0xE70178")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0xE706B8", Offset = "0xE706B8", VA = "0xE706B8")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0xE70B54", Offset = "0xE70B54", VA = "0xE70B54")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x20000A6")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535390", Offset = "0x535390")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535390", Offset = "0x535390")]
[SelectionBase]
public class RayfireDebris : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535400", Offset = "0x535400")]
	private sealed class <>c
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, bool> <>9__28_0;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<MeshFilter, Mesh> <>9__28_1;

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x125AF3C", Offset = "0x125AF3C", VA = "0x125AF3C")]
		public <>c()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x125AF44", Offset = "0x125AF44", VA = "0x125AF44")]
		internal bool <SetReferenceMeshes>b__28_0(MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x125AFF8", Offset = "0x125AFF8", VA = "0x125AFF8")]
		internal Mesh <SetReferenceMeshes>b__28_1(MeshFilter mf)
		{
			return null;
		}
	}

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x537210", Offset = "0x537210")]
	public bool onDemolition;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537248", Offset = "0x537248")]
	public bool onActivation;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53725C", Offset = "0x53725C")]
	public bool onImpact;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537270", Offset = "0x537270")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x537270", Offset = "0x537270")]
	public GameObject debrisReference;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5372C0", Offset = "0x5372C0")]
	public Material debrisMaterial;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5372D4", Offset = "0x5372D4")]
	public Material emissionMaterial;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x5372E8", Offset = "0x5372E8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5372E8", Offset = "0x5372E8")]
	public RFParticleEmission emission;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537338", Offset = "0x537338")]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53734C", Offset = "0x53734C")]
	public RFParticleNoise noise;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537360", Offset = "0x537360")]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537374", Offset = "0x537374")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537388", Offset = "0x537388")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Mesh> debrisMeshList;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 refScale;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireDebris> children;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000056")]
	public bool HasChildren
	{
		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xE71B88", Offset = "0xE71B88", VA = "0xE71B88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0xE70BF8", Offset = "0xE70BF8", VA = "0xE70BF8")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0xE70E30", Offset = "0xE70E30", VA = "0xE70E30")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0xE70F30", Offset = "0xE70F30", VA = "0xE70F30")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0xE714E8", Offset = "0xE714E8", VA = "0xE714E8")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0xE71954", Offset = "0xE71954", VA = "0xE71954")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0xE7162C", Offset = "0xE7162C", VA = "0xE7162C")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0xE71BE0", Offset = "0xE71BE0", VA = "0xE71BE0")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0xE70F44", Offset = "0xE70F44", VA = "0xE70F44")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0xE71E0C", Offset = "0xE71E0C", VA = "0xE71E0C")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x20000A8")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535410", Offset = "0x535410")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535410", Offset = "0x535410")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x53742C", Offset = "0x53742C")]
	public bool onDemolition;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537464", Offset = "0x537464")]
	public bool onActivation;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537478", Offset = "0x537478")]
	public bool onImpact;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x53748C", Offset = "0x53748C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53748C", Offset = "0x53748C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x53748C", Offset = "0x53748C")]
	public float opacity;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5374F8", Offset = "0x5374F8")]
	public Material dustMaterial;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x53750C", Offset = "0x53750C")]
	public List<Material> dustMaterials;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537520", Offset = "0x537520")]
	public Material emissionMaterial;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x537534", Offset = "0x537534")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537534", Offset = "0x537534")]
	public RFParticleEmission emission;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537584", Offset = "0x537584")]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x537598", Offset = "0x537598")]
	public RFParticleNoise noise;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5375AC", Offset = "0x5375AC")]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5375C0", Offset = "0x5375C0")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5375D4", Offset = "0x5375D4")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<RayfireDust> children;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000057")]
	public bool HasChildren
	{
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE72BCC", Offset = "0xE72BCC", VA = "0xE72BCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000058")]
	public bool HasMaterials
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xE7251C", Offset = "0xE7251C", VA = "0xE7251C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0xE7200C", Offset = "0xE7200C", VA = "0xE7200C")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0xE721E4", Offset = "0xE721E4", VA = "0xE721E4")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0xE722DC", Offset = "0xE722DC", VA = "0xE722DC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0xE72574", Offset = "0xE72574", VA = "0xE72574")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0xE72998", Offset = "0xE72998", VA = "0xE72998")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0xE72698", Offset = "0xE72698", VA = "0xE72698")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0xE72C24", Offset = "0xE72C24", VA = "0xE72C24")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0xE72DA0", Offset = "0xE72DA0", VA = "0xE72DA0")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x20000A9")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535480", Offset = "0x535480")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535480", Offset = "0x535480")]
public class RayfireGun : MonoBehaviour
{
	[Token(Token = "0x20000AA")]
	public enum ImpactType
	{
		[Token(Token = "0x400046B")]
		AddExplosionForce,
		[Token(Token = "0x400046C")]
		AddForceAtPosition
	}

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5354E0", Offset = "0x5354E0")]
	private sealed class <StartShootCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <shootId>5__2;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x125B2A8", Offset = "0x125B2A8", VA = "0x125B2A8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x125B2F0", Offset = "0x125B2F0", VA = "0x125B2F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x125B18C", Offset = "0x125B18C", VA = "0x125B18C")]
		[DebuggerHidden]
		public <StartShootCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x125B1B8", Offset = "0x125B1B8", VA = "0x125B1B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x125B1BC", Offset = "0x125B1BC", VA = "0x125B1BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x125B2B0", Offset = "0x125B2B0", VA = "0x125B2B0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5354F0", Offset = "0x5354F0")]
	private sealed class <BurstCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x125B13C", Offset = "0x125B13C", VA = "0x125B13C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x125B184", Offset = "0x125B184", VA = "0x125B184", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x125B014", Offset = "0x125B014", VA = "0x125B014")]
		[DebuggerHidden]
		public <BurstCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x125B040", Offset = "0x125B040", VA = "0x125B040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x125B044", Offset = "0x125B044", VA = "0x125B044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x125B144", Offset = "0x125B144", VA = "0x125B144", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AxisType axis;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int rounds;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rate;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ImpactType type;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float strength;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float radius;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool demolishCluster;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool affectInactive;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool rigid;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool rigidRoot;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x537658", Offset = "0x537658")]
	public bool rigidBody;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float damage;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool debris;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool dust;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool flash;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFFlash Flash;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int mask;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool showRay;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool showHit;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool shooting;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string untagged;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFShotEvent shotEvent;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Collider[] impactColliders;

	[Token(Token = "0x17000059")]
	public Vector3 ShootVector
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xE72FE0", Offset = "0xE72FE0", VA = "0xE72FE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0xE72EAC", Offset = "0xE72EAC", VA = "0xE72EAC")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0xE72EE4", Offset = "0xE72EE4", VA = "0xE72EE4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538F20", Offset = "0x538F20")]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0xE72F5C", Offset = "0xE72F5C", VA = "0xE72F5C")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0xE72F64", Offset = "0xE72F64", VA = "0xE72F64")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0xE73684", Offset = "0xE73684", VA = "0xE73684")]
	public void Burst()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0xE736BC", Offset = "0xE736BC", VA = "0xE736BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x538F80", Offset = "0x538F80")]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0xE73130", Offset = "0xE73130", VA = "0xE73130")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0xE73EB0", Offset = "0xE73EB0", VA = "0xE73EB0")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0xE74660", Offset = "0xE74660", VA = "0xE74660")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0xE74A6C", Offset = "0xE74A6C", VA = "0xE74A6C")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0xE73C80", Offset = "0xE73C80", VA = "0xE73C80")]
	private RayfireRigid ApplyDamage(RayfireRigid scr, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0xE73734", Offset = "0xE73734", VA = "0xE73734")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0xE73920", Offset = "0xE73920", VA = "0xE73920")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0xE73AD0", Offset = "0xE73AD0", VA = "0xE73AD0")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0xE74C28", Offset = "0xE74C28", VA = "0xE74C28")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0xE74FC4", Offset = "0xE74FC4", VA = "0xE74FC4")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x20000AD")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535500", Offset = "0x535500")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535500", Offset = "0x535500")]
[DisallowMultipleComponent]
public class RayfireMan : MonoBehaviour
{
	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RayfireMan inst;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int buildMajor;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int buildMinor;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setGravity;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float multiplier;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RigidbodyInterpolation interpolation;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float colliderSize;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float colliderSizeStatic;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x537690", Offset = "0x537690")]
	public CollisionDetectionMode meshCollision;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CollisionDetectionMode clusterCollision;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minimumMass;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maximumMass;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterialPresets materialPresets;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject parent;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float globalSolidity;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timeQuota;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFManDemolition advancedDemolitionProperties;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFPoolingFragment fragments;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFPoolingParticles particles;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform transForm;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<string> layers;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFStorage storage;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxTimeThisFrame;

	[Token(Token = "0x1700005E")]
	public static bool MaxAmountCheck
	{
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xE75A30", Offset = "0xE75A30", VA = "0xE75A30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0xE75148", Offset = "0xE75148", VA = "0xE75148")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0xE753EC", Offset = "0xE753EC", VA = "0xE753EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0xE753F4", Offset = "0xE753F4", VA = "0xE753F4")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0xE7514C", Offset = "0xE7514C", VA = "0xE7514C")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0xE756EC", Offset = "0xE756EC", VA = "0xE756EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0xE75724", Offset = "0xE75724", VA = "0xE75724")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0xE753F8", Offset = "0xE753F8", VA = "0xE753F8")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0xE75784", Offset = "0xE75784", VA = "0xE75784")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0xE758AC", Offset = "0xE758AC", VA = "0xE758AC")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0xE757D0", Offset = "0xE757D0", VA = "0xE757D0")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0xE754C4", Offset = "0xE754C4", VA = "0xE754C4")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0xE755F8", Offset = "0xE755F8", VA = "0xE755F8")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0xE75AB4", Offset = "0xE75AB4", VA = "0xE75AB4")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0xE75C60", Offset = "0xE75C60", VA = "0xE75C60")]
	public static void SetParentToManager(Transform tm)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0xE75D0C", Offset = "0xE75D0C", VA = "0xE75D0C")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0xE65994", Offset = "0xE65994", VA = "0xE65994")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0xE75FF8", Offset = "0xE75FF8", VA = "0xE75FF8")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0xE760C8", Offset = "0xE760C8", VA = "0xE760C8")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0xE75E74", Offset = "0xE75E74", VA = "0xE75E74")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0xE7612C", Offset = "0xE7612C", VA = "0xE7612C")]
	public RayfireMan()
	{
	}
}
[Serializable]
[Token(Token = "0x20000AE")]
public class RFCache
{
	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<bool> act;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> pos;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Quaternion> rot;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform transform;

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0xFFECC0", Offset = "0xFFECC0", VA = "0xFFECC0")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x20000AF")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535570", Offset = "0x535570")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535570", Offset = "0x535570")]
[DisallowMultipleComponent]
[SelectionBase]
public class RayfireRecorder : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	public enum AnimatorType
	{
		[Token(Token = "0x40004A7")]
		Disabled = 0,
		[Token(Token = "0x40004A8")]
		Record = 2,
		[Token(Token = "0x40004A9")]
		Play = 8
	}

	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5355F0", Offset = "0x5355F0")]
	private sealed class <RecordCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRecorder <>4__this;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x125B6A4", Offset = "0x125B6A4", VA = "0x125B6A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x125B6EC", Offset = "0x125B6EC", VA = "0x125B6EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x125B2F8", Offset = "0x125B2F8", VA = "0x125B2F8")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x125B324", Offset = "0x125B324", VA = "0x125B324", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x125B328", Offset = "0x125B328", VA = "0x125B328", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x125B6AC", Offset = "0x125B6AC", VA = "0x125B6AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimatorType mode;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool recordOnStart;

	[Token(Token = "0x4000493")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x4000494")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x4000495")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rate;

	[Token(Token = "0x4000496")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool reduceKeys;

	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float threshold;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool playOnStart;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip animationClip;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RuntimeAnimatorController controller;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool setToKinematic;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool recorder;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float recordedTime;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int stateNameHash;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string assetFolder;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string clipFolder;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stepTime;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Transform> tmList;

	[Token(Token = "0x40004A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RFCache> cacheList;

	[Token(Token = "0x40004A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> timeList;

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0xE762E0", Offset = "0xE762E0", VA = "0xE762E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0xE76694", Offset = "0xE76694", VA = "0xE76694")]
	private void Start()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0xE766F8", Offset = "0xE766F8", VA = "0xE766F8")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0xE762E4", Offset = "0xE762E4", VA = "0xE762E4")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0xE769FC", Offset = "0xE769FC", VA = "0xE769FC")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0xE76C80", Offset = "0xE76C80", VA = "0xE76C80")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xE773D8", Offset = "0xE773D8", VA = "0xE773D8")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xE76930", Offset = "0xE76930", VA = "0xE76930")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xE77418", Offset = "0xE77418", VA = "0xE77418")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x539080", Offset = "0x539080")]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xE77490", Offset = "0xE77490", VA = "0xE77490")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xE769A0", Offset = "0xE769A0", VA = "0xE769A0")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xE77498", Offset = "0xE77498", VA = "0xE77498")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x20000B2")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535600", Offset = "0x535600")]
[DisallowMultipleComponent]
[SelectionBase]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535600", Offset = "0x535600")]
public class RayfireRestriction : MonoBehaviour
{
	[Token(Token = "0x20000B3")]
	public enum RFBoundActionType
	{
		[Token(Token = "0x40004B8")]
		Fade = 2,
		[Token(Token = "0x40004B9")]
		Reset = 4,
		[Token(Token = "0x40004BA")]
		PostDemolitionAction = 9
	}

	[Token(Token = "0x20000B4")]
	public enum RFDistanceType
	{
		[Token(Token = "0x40004BC")]
		InitializePosition = 0,
		[Token(Token = "0x40004BD")]
		TargetPosition = 2
	}

	[Token(Token = "0x20000B5")]
	public enum RFBoundTriggerType
	{
		[Token(Token = "0x40004BF")]
		Inside = 0,
		[Token(Token = "0x40004C0")]
		Outside = 2
	}

	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535680", Offset = "0x535680")]
	private sealed class <RestrictionDistanceCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <checkPosition>5__4;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x125BA14", Offset = "0x125BA14", VA = "0x125BA14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x125BA5C", Offset = "0x125BA5C", VA = "0x125BA5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x125B6F4", Offset = "0x125B6F4", VA = "0x125B6F4")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x125B720", Offset = "0x125B720", VA = "0x125B720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x125B724", Offset = "0x125B724", VA = "0x125B724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x125BA1C", Offset = "0x125BA1C", VA = "0x125BA1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535690", Offset = "0x535690")]
	private sealed class <RestrictionTriggerCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
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
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <brokeState>5__4;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000422")]
			[Address(RVA = "0x125BE60", Offset = "0x125BE60", VA = "0x125BE60", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0x125BEA8", Offset = "0x125BEA8", VA = "0x125BEA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x125BA64", Offset = "0x125BA64", VA = "0x125BA64")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x125BA90", Offset = "0x125BA90", VA = "0x125BA90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x125BA94", Offset = "0x125BA94", VA = "0x125BA94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x125BE68", Offset = "0x125BE68", VA = "0x125BE68", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x40004AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFBoundActionType breakAction;

	[Token(Token = "0x40004AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float actionDelay;

	[Token(Token = "0x40004B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float checkInterval;

	[Token(Token = "0x40004B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x40004B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public RFDistanceType position;

	[Token(Token = "0x40004B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x40004B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider Collider;

	[Token(Token = "0x40004B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFBoundTriggerType region;

	[Token(Token = "0x40004B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool broke;

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xE77518", Offset = "0xE77518", VA = "0xE77518")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xE77588", Offset = "0xE77588", VA = "0xE77588")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xE77580", Offset = "0xE77580", VA = "0xE77580")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xE77604", Offset = "0xE77604", VA = "0xE77604")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xE776BC", Offset = "0xE776BC", VA = "0xE776BC")]
	public static void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xE779DC", Offset = "0xE779DC", VA = "0xE779DC")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xE778EC", Offset = "0xE778EC", VA = "0xE778EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x539130", Offset = "0x539130")]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xE77964", Offset = "0xE77964", VA = "0xE77964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x539190", Offset = "0x539190")]
	private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x20000B8")]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5356A0", Offset = "0x5356A0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5356A0", Offset = "0x5356A0")]
[SelectionBase]
public class RayfireRigid : MonoBehaviour
{
	[Token(Token = "0x20000B9")]
	public enum InitType
	{
		[Token(Token = "0x40004F4")]
		ByMethod,
		[Token(Token = "0x40004F5")]
		AtStart
	}

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectType objectType;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DemolitionType demolitionType;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFPhysic physics;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFActivation activation;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFLimitations limitations;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFDemolitionMesh meshDemolition;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFReferenceDemolition referenceDemolition;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFSurface materials;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFDamage damage;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFFade fading;

	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFReset reset;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool initialized;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool corState;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Mesh[] meshes;

	[Token(Token = "0x40004DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3[] pivots;

	[Token(Token = "0x40004DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMesh[] rfMeshes;

	[Token(Token = "0x40004E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFDictionary> subIds;

	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RayfireRigid> fragments;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion cacheRotation;

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform rootChild;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform rootParent;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RayfireDebris> debrisList;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RayfireDust> dustList;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RayfireRestriction restriction;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public RayfireSound sound;

	[NonSerialized]
	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RayfireRigid meshRoot;

	[NonSerialized]
	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RayfireRigidRoot rigidRoot;

	[NonSerialized]
	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public List<Transform> particleList;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RFDemolitionEvent demolitionEvent;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public RFRestrictionEvent restrictionEvent;

	[Token(Token = "0x17000065")]
	public bool HasFragments
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x100E15C", Offset = "0x100E15C", VA = "0x100E15C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public bool HasMeshes
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1010DA8", Offset = "0x1010DA8", VA = "0x1010DA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000067")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1010DC8", Offset = "0x1010DC8", VA = "0x1010DC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000068")]
	public bool HasDebris
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1010DE8", Offset = "0x1010DE8", VA = "0x1010DE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000069")]
	public bool HasDust
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1010E40", Offset = "0x1010E40", VA = "0x1010E40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public bool HasSlices
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x10107B4", Offset = "0x10107B4", VA = "0x10107B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public bool IsCluster
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1010E98", Offset = "0x1010E98", VA = "0x1010E98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1010EAC", Offset = "0x1010EAC", VA = "0x1010EAC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x100C9C4", Offset = "0x100C9C4", VA = "0x100C9C4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x100CAA4", Offset = "0x100CAA4", VA = "0x100CAA4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x100CAF0", Offset = "0x100CAF0", VA = "0x100CAF0")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x100D7AC", Offset = "0x100D7AC", VA = "0x100D7AC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x100D80C", Offset = "0x100D80C", VA = "0x100D80C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x100D864", Offset = "0x100D864", VA = "0x100D864")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x100DA40", Offset = "0x100DA40", VA = "0x100DA40")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x100CD04", Offset = "0x100CD04", VA = "0x100CD04")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x100D368", Offset = "0x100D368", VA = "0x100D368")]
	private void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x100D8F8", Offset = "0x100D8F8", VA = "0x100D8F8")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x100CFB4", Offset = "0x100CFB4", VA = "0x100CFB4")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x100DF54", Offset = "0x100DF54", VA = "0x100DF54")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x100E1B4", Offset = "0x100E1B4", VA = "0x100E1B4")]
	private void AddMeshRootRigid()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x100E78C", Offset = "0x100E78C", VA = "0x100E78C")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x100DAD4", Offset = "0x100DAD4", VA = "0x100DAD4")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x100D640", Offset = "0x100D640", VA = "0x100D640")]
	private void SetObjectType()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x100D550", Offset = "0x100D550", VA = "0x100D550")]
	public void Default()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x100EB80", Offset = "0x100EB80", VA = "0x100EB80")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x100D688", Offset = "0x100D688", VA = "0x100D688")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x100ED54", Offset = "0x100ED54", VA = "0x100ED54")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x100CA00", Offset = "0x100CA00", VA = "0x100CA00")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x100EE54", Offset = "0x100EE54", VA = "0x100EE54", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x100EF90", Offset = "0x100EF90", VA = "0x100EF90", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x100EF48", Offset = "0x100EF48", VA = "0x100EF48")]
	private bool CollisionCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x100F304", Offset = "0x100F304", VA = "0x100F304")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x100F458", Offset = "0x100F458", VA = "0x100F458", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x100F5EC", Offset = "0x100F5EC", VA = "0x100F5EC")]
	public void Demolish()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x100E8CC", Offset = "0x100E8CC", VA = "0x100E8CC")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x100FF24", Offset = "0x100FF24", VA = "0x100FF24")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x1010094", Offset = "0x1010094", VA = "0x1010094")]
	public void Prefragment()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x1010430", Offset = "0x1010430", VA = "0x1010430")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x1010314", Offset = "0x1010314", VA = "0x1010314")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x10104D8", Offset = "0x10104D8", VA = "0x10104D8")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x1010574", Offset = "0x1010574", VA = "0x1010574")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x1010818", Offset = "0x1010818", VA = "0x1010818")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x1010858", Offset = "0x1010858", VA = "0x1010858")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x539290", Offset = "0x539290")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x100F2FC", Offset = "0x100F2FC", VA = "0x100F2FC")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f, [Optional] Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x1010A7C", Offset = "0x1010A7C", VA = "0x1010A7C")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x1010B4C", Offset = "0x1010B4C", VA = "0x1010B4C")]
	public void Fade()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x1010C10", Offset = "0x1010C10", VA = "0x1010C10")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x1010C18", Offset = "0x1010C18", VA = "0x1010C18")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x1010C7C", Offset = "0x1010C7C", VA = "0x1010C7C")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x1010CE0", Offset = "0x1010CE0", VA = "0x1010CE0")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x1010D44", Offset = "0x1010D44", VA = "0x1010D44")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x1010F34", Offset = "0x1010F34", VA = "0x1010F34")]
	public RayfireRigid()
	{
	}
}
[Serializable]
[Token(Token = "0x20000BA")]
public class RFRigidRootDemolition
{
	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5376C8", Offset = "0x5376C8")]
	public RFLimitations limitations;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x5376DC", Offset = "0x5376DC")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x600045A")]
	[Address(RVA = "0xE815A4", Offset = "0xE815A4", VA = "0xE815A4")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x20000BB")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535720", Offset = "0x535720")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535720", Offset = "0x535720")]
[DisallowMultipleComponent]
[SelectionBase]
public class RayfireRigidRoot : MonoBehaviour
{
	[Token(Token = "0x20000BC")]
	public enum InitType
	{
		[Token(Token = "0x4000519")]
		ByMethod,
		[Token(Token = "0x400051A")]
		AtStart
	}

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFPhysic physics;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFActivation activation;

	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFRigidRootDemolition demolition;

	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFFade fading;

	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFReset reset;

	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform tm;

	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireSound sound;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> meshRoots;

	[Token(Token = "0x4000503")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool initialized;

	[Token(Token = "0x4000504")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool cached;

	[Token(Token = "0x4000505")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float sizeBox;

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float sizeSum;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Collider> collidersList;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<RFShard> meshRootShards;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<RFShard> rigidRootShards;

	[NonSerialized]
	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<RFCluster> clusters;

	[NonSerialized]
	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFShard> inactiveShards;

	[NonSerialized]
	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFShard> offsetFadeShards;

	[NonSerialized]
	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFShard> destroyShards;

	[NonSerialized]
	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFShard> meshRigidShards;

	[NonSerialized]
	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Transform> parentList;

	[NonSerialized]
	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RayfireDebris> debrisList;

	[NonSerialized]
	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<RayfireDust> dustList;

	[NonSerialized]
	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RayfireUnyielding> unyList;

	[NonSerialized]
	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Transform> particleList;

	[NonSerialized]
	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool corState;

	[NonSerialized]
	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public HashSet<Collider> collidersHash;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string strRoot;

	[Token(Token = "0x1700006D")]
	public bool HasClusters
	{
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1014924", Offset = "0x1014924", VA = "0x1014924")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x101497C", Offset = "0x101497C", VA = "0x101497C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x10149D4", Offset = "0x10149D4", VA = "0x10149D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasUny
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1014274", Offset = "0x1014274", VA = "0x1014274")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x1011244", Offset = "0x1011244", VA = "0x1011244")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x10112F4", Offset = "0x10112F4", VA = "0x10112F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x1011324", Offset = "0x1011324", VA = "0x1011324")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x1011280", Offset = "0x1011280", VA = "0x1011280")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x1011824", Offset = "0x1011824", VA = "0x1011824")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x1011A7C", Offset = "0x1011A7C", VA = "0x1011A7C")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x1011A84", Offset = "0x1011A84", VA = "0x1011A84")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x1011C3C", Offset = "0x1011C3C", VA = "0x1011C3C")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x1011484", Offset = "0x1011484", VA = "0x1011484")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x1012140", Offset = "0x1012140", VA = "0x1012140")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x1013064", Offset = "0x1013064", VA = "0x1013064")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x10121E8", Offset = "0x10121E8", VA = "0x10121E8")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x10135E4", Offset = "0x10135E4", VA = "0x10135E4")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x1013888", Offset = "0x1013888", VA = "0x1013888")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x1013A80", Offset = "0x1013A80", VA = "0x1013A80")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x1013BB4", Offset = "0x1013BB4", VA = "0x1013BB4")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x1013CC8", Offset = "0x1013CC8", VA = "0x1013CC8")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x1012B4C", Offset = "0x1012B4C", VA = "0x1012B4C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x1013150", Offset = "0x1013150", VA = "0x1013150")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x1013374", Offset = "0x1013374", VA = "0x1013374")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x1012D90", Offset = "0x1012D90", VA = "0x1012D90")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x101137C", Offset = "0x101137C", VA = "0x101137C")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x10147D4", Offset = "0x10147D4", VA = "0x10147D4")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x10148A4", Offset = "0x10148A4", VA = "0x10148A4")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x1013D80", Offset = "0x1013D80", VA = "0x1013D80")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x1014A2C", Offset = "0x1014A2C", VA = "0x1014A2C")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x1014A38", Offset = "0x1014A38", VA = "0x1014A38")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x20000BD")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5357A0", Offset = "0x5357A0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5357A0", Offset = "0x5357A0")]
public class RayfireShatter : MonoBehaviour
{
	[Token(Token = "0x20000BE")]
	public enum FragLastMode
	{
		[Token(Token = "0x4000545")]
		New,
		[Token(Token = "0x4000546")]
		ToLast
	}

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FragType type;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFVoronoi voronoi;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSplinters splinters;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSplinters slabs;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRadial radial;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCustom custom;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMirrored mirrored;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFSlice slice;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFBricks bricks;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFVoxels voxels;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFTets tets;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public FragmentMode mode;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSurface material;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RFShatterCluster clusters;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFShatterAdvanced advanced;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMeshExport export;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool showCenter;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 centerPosition;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion centerDirection;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x400052F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000530")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x4000531")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Mesh[] meshes;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3[] pivots;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Transform> rootChildList;

	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<GameObject> fragmentsAll;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<GameObject> fragmentsLast;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<RFDictionary> origSubMeshIdsRF;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Material[] materials;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int shatterMode;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool colorPreview;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool scalePreview;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float previewScale;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float size;

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float rescaleFix;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Vector3 originalScale;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[HideInInspector]
	public bool resetState;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float minSize;

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x1014C2C", Offset = "0x1014C2C", VA = "0x1014C2C")]
	private void Reset()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x1014D5C", Offset = "0x1014D5C", VA = "0x1014D5C")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x1014E04", Offset = "0x1014E04", VA = "0x1014E04")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x101529C", Offset = "0x101529C", VA = "0x101529C")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x101552C", Offset = "0x101552C", VA = "0x101552C")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x101584C", Offset = "0x101584C", VA = "0x101584C")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x1015A08", Offset = "0x1015A08", VA = "0x1015A08")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x1015E88", Offset = "0x1015E88", VA = "0x1015E88")]
	private List<GameObject> CreateFragments([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x1016B68", Offset = "0x1016B68", VA = "0x1016B68")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x1016F68", Offset = "0x1016F68", VA = "0x1016F68")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x1014C30", Offset = "0x1014C30", VA = "0x1014C30")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x1015C08", Offset = "0x1015C08", VA = "0x1015C08")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x10170F8", Offset = "0x10170F8", VA = "0x10170F8")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x100E528", Offset = "0x100E528", VA = "0x100E528")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x1017360", Offset = "0x1017360", VA = "0x1017360")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x10167D8", Offset = "0x10167D8", VA = "0x10167D8")]
	private void SizeLimitation()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x1016928", Offset = "0x1016928", VA = "0x1016928")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x1016A38", Offset = "0x1016A38", VA = "0x1016A38")]
	private void TriangleLimitation()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x10175F8", Offset = "0x10175F8", VA = "0x10175F8")]
	private void LimitationFragment(int ind)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x1017944", Offset = "0x1017944", VA = "0x1017944")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x20000BF")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535800", Offset = "0x535800")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535800", Offset = "0x535800")]
public class RayfireSnapshot : MonoBehaviour
{
	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string assetName;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool compress;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEngine.Object snapshotAsset;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeFilter;

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x1017DFC", Offset = "0x1017DFC", VA = "0x1017DFC")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1017E3C", Offset = "0x1017E3C", VA = "0x1017E3C")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x20000C0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535880", Offset = "0x535880")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535880", Offset = "0x535880")]
[SelectionBase]
public class RayfireSound : MonoBehaviour
{
	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float baseVolume;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeVolume;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFSound initialization;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSound activation;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSound demolition;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minimumSize;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float cameraDistance;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireRigid rigid;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RayfireRigidRoot rigidRoot;

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x1017E44", Offset = "0x1017E44", VA = "0x1017E44")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1017E78", Offset = "0x1017E78", VA = "0x1017E78")]
	private void Start()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x1017E7C", Offset = "0x1017E7C", VA = "0x1017E7C")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x1017FC4", Offset = "0x1017FC4", VA = "0x1017FC4")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x101846C", Offset = "0x101846C", VA = "0x101846C")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x1018570", Offset = "0x1018570", VA = "0x1018570")]
	private void CreateSource(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x20000C1")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5358F0", Offset = "0x5358F0")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5358F0", Offset = "0x5358F0")]
public class RayfireUnyielding : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	public enum UnySimType
	{
		[Token(Token = "0x400055F")]
		Original = 1,
		[Token(Token = "0x4000560")]
		Inactive,
		[Token(Token = "0x4000561")]
		Kinematic
	}

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool unyielding;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activatable;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UnySimType simulationType;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 centerPosition;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RayfireRigid rigidHost;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RFShard> shardList;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool showGizmo;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool showCenter;

	[Token(Token = "0x17000071")]
	private bool HasRigids
	{
		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1019F00", Offset = "0x1019F00", VA = "0x1019F00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	private bool HasShards
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1019F58", Offset = "0x1019F58", VA = "0x1019F58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public Vector3 Extents
	{
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1018DAC", Offset = "0x1018DAC", VA = "0x1018DAC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x10187D0", Offset = "0x10187D0", VA = "0x10187D0")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x10188C8", Offset = "0x10188C8", VA = "0x10188C8")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x1018C34", Offset = "0x1018C34", VA = "0x1018C34")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x1018E5C", Offset = "0x1018E5C", VA = "0x1018E5C")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x100E6C8", Offset = "0x100E6C8", VA = "0x100E6C8")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x1018E80", Offset = "0x1018E80", VA = "0x1018E80")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x1018F94", Offset = "0x1018F94", VA = "0x1018F94")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x10193A8", Offset = "0x10193A8", VA = "0x10193A8")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x1019294", Offset = "0x1019294", VA = "0x1019294")]
	public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x10194F8", Offset = "0x10194F8", VA = "0x10194F8")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x1019774", Offset = "0x1019774", VA = "0x1019774")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x100F818", Offset = "0x100F818", VA = "0x100F818")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x1019954", Offset = "0x1019954", VA = "0x1019954")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x10199E0", Offset = "0x10199E0", VA = "0x10199E0")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x10142CC", Offset = "0x10142CC", VA = "0x10142CC")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x10146AC", Offset = "0x10146AC", VA = "0x10146AC")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x1019B58", Offset = "0x1019B58", VA = "0x1019B58")]
	public void Activate()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x1019FB0", Offset = "0x1019FB0", VA = "0x1019FB0")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x20000C3")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x535950", Offset = "0x535950")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x535950", Offset = "0x535950")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5359B0", Offset = "0x5359B0")]
	private sealed class <VortexForceCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x125C1D4", Offset = "0x125C1D4", VA = "0x125C1D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0x125C21C", Offset = "0x125C21C", VA = "0x125C21C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x125C078", Offset = "0x125C078", VA = "0x125C078")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x125C0A4", Offset = "0x125C0A4", VA = "0x125C0A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x125C0A8", Offset = "0x125C0A8", VA = "0x125C0A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x125C1DC", Offset = "0x125C1DC", VA = "0x125C1DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5359C0", Offset = "0x5359C0")]
	private sealed class <SetCollidersCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0x125C028", Offset = "0x125C028", VA = "0x125C028", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x125C070", Offset = "0x125C070", VA = "0x125C070", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x125BEB0", Offset = "0x125BEB0", VA = "0x125BEB0")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x125BEDC", Offset = "0x125BEDC", VA = "0x125BEDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x125BEE0", Offset = "0x125BEE0", VA = "0x125BEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x125C030", Offset = "0x125C030", VA = "0x125C030", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 bot;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 top;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 normal;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 direction;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 rbPos;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 linePoint;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 vectorUp;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 centerOutVector;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 vectorCenter;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 perpend;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 vectorSwirl;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 forceVector;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float distancePerpend;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float distanceBottom;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float upRateNow;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float localRadius;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float upRateOwn;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float centerRateOwn;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float centerRateNow;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float upRateDif;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float centerRateDif;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float maxRadius;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float axisDistance;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Plane bottomPlane;

	[Token(Token = "0x400057D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float torqueVal;

	[Token(Token = "0x400057E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool topHandle;

	[Token(Token = "0x400057F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 topAnchor;

	[Token(Token = "0x4000580")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 bottomAnchor;

	[Token(Token = "0x4000581")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool showGizmo;

	[Token(Token = "0x4000582")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float topRadius;

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float bottomRadius;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float eye;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool forceByMass;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float stiffness;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float swirlStrength;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool enableTorque;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float torqueStrength;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float torqueVariation;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool enableHeightBias;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float biasSpeed;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float biasSpread;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int seed;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int circles;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int mask;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public string tagFilter;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x1019FD8", Offset = "0x1019FD8", VA = "0x1019FD8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x1019FDC", Offset = "0x1019FDC", VA = "0x1019FDC")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x101A068", Offset = "0x101A068", VA = "0x101A068")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x5392C8", Offset = "0x5392C8")]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x101A0E0", Offset = "0x101A0E0", VA = "0x101A0E0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x539328", Offset = "0x539328")]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x101A158", Offset = "0x101A158", VA = "0x101A158")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x101A19C", Offset = "0x101A19C", VA = "0x101A19C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x101A2CC", Offset = "0x101A2CC", VA = "0x101A2CC")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x101A3D0", Offset = "0x101A3D0", VA = "0x101A3D0")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x101A5C0", Offset = "0x101A5C0", VA = "0x101A5C0")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x101AADC", Offset = "0x101AADC", VA = "0x101AADC")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x101AC0C", Offset = "0x101AC0C", VA = "0x101AC0C")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x101AC60", Offset = "0x101AC60", VA = "0x101AC60")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x101AD60", Offset = "0x101AD60", VA = "0x101AD60")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x101AB30", Offset = "0x101AB30", VA = "0x101AB30")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x101AD90", Offset = "0x101AD90", VA = "0x101AD90")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x20000C6")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x5359D0", Offset = "0x5359D0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x5359D0", Offset = "0x5359D0")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x535A30", Offset = "0x535A30")]
	private sealed class <WindForceCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireWind <>4__this;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x125C328", Offset = "0x125C328", VA = "0x125C328", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x125C370", Offset = "0x125C370", VA = "0x125C370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x125C224", Offset = "0x125C224", VA = "0x125C224")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x125C250", Offset = "0x125C250", VA = "0x125C250", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x125C254", Offset = "0x125C254", VA = "0x125C254", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x125C330", Offset = "0x125C330", VA = "0x125C330", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 gizmoSize;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showGizmo;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float globalScale;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lengthScale;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float widthScale;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speed;

	[Token(Token = "0x400059E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showNoise;

	[Token(Token = "0x400059F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minimum;

	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maximum;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float torque;

	[Token(Token = "0x40005A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceByMass;

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float divergency;

	[Token(Token = "0x40005A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float turbulence;

	[Token(Token = "0x40005A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float previewDensity;

	[Token(Token = "0x40005A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float previewSize;

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int mask;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform transForm;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider[] colliders;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 halfExtents;

	[Token(Token = "0x40005AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 center;

	[Token(Token = "0x40005AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float offset;

	[Token(Token = "0x40005AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x101AEB0", Offset = "0x101AEB0", VA = "0x101AEB0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x101AEB4", Offset = "0x101AEB4", VA = "0x101AEB4")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x101AF40", Offset = "0x101AF40", VA = "0x101AF40")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x539428", Offset = "0x539428")]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x101AFB8", Offset = "0x101AFB8", VA = "0x101AFB8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x101AFE4", Offset = "0x101AFE4", VA = "0x101AFE4")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x101AFF0", Offset = "0x101AFF0", VA = "0x101AFF0")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x101B1D4", Offset = "0x101B1D4", VA = "0x101B1D4")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x101B234", Offset = "0x101B234", VA = "0x101B234")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x101B424", Offset = "0x101B424", VA = "0x101B424")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x101B738", Offset = "0x101B738", VA = "0x101B738")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x101B798", Offset = "0x101B798", VA = "0x101B798")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x101B8DC", Offset = "0x101B8DC", VA = "0x101B8DC")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x101B6EC", Offset = "0x101B6EC", VA = "0x101B6EC")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x101B9DC", Offset = "0x101B9DC", VA = "0x101B9DC")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x101BA20", Offset = "0x101BA20", VA = "0x101BA20")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x101B8A8", Offset = "0x101B8A8", VA = "0x101B8A8")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x101B720", Offset = "0x101B720", VA = "0x101B720")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x101B6A4", Offset = "0x101B6A4", VA = "0x101B6A4")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x101BAA0", Offset = "0x101BAA0", VA = "0x101BAA0")]
	public RayfireWind()
	{
	}
}
