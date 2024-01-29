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
	[Address(RVA = "0x331B800", Offset = "0x331B800", VA = "0x331B800")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x331B84C", Offset = "0x331B84C", VA = "0x331B84C")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x331BBA8", Offset = "0x331BBA8", VA = "0x331BBA8")]
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
	[Address(RVA = "0x3030190", Offset = "0x3030190", VA = "0x3030190")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x302783C", Offset = "0x302783C", VA = "0x302783C")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x3028F44", Offset = "0x3028F44", VA = "0x3028F44")]
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
	[Address(RVA = "0x33244A4", Offset = "0x33244A4", VA = "0x33244A4")]
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
		[Address(RVA = "0x3324558", Offset = "0x3324558", VA = "0x3324558")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x33244C4", Offset = "0x33244C4", VA = "0x33244C4")]
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
	[Address(RVA = "0x332460C", Offset = "0x332460C", VA = "0x332460C")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x3324B70", Offset = "0x3324B70", VA = "0x3324B70")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x3324F3C", Offset = "0x3324F3C", VA = "0x3324F3C")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x3324FEC", Offset = "0x3324FEC", VA = "0x3324FEC")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x332509C", Offset = "0x332509C", VA = "0x332509C")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x3325150", Offset = "0x3325150", VA = "0x3325150")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3325200", Offset = "0x3325200", VA = "0x3325200")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x33252B8", Offset = "0x33252B8", VA = "0x33252B8")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AA4", Offset = "0x11B2AA4")]
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
			[Address(RVA = "0x3A35D60", Offset = "0x3A35D60", VA = "0x3A35D60", Slot = "4")]
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
			[Address(RVA = "0x3A35DA8", Offset = "0x3A35DA8", VA = "0x3A35DA8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x3A35BAC", Offset = "0x3A35BAC", VA = "0x3A35BAC")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x3A35BD8", Offset = "0x3A35BD8", VA = "0x3A35BD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x3A35BDC", Offset = "0x3A35BDC", VA = "0x3A35BDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x3A35D68", Offset = "0x3A35D68", VA = "0x3A35D68", Slot = "8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3634", Offset = "0x11B3634")]
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
	[Address(RVA = "0x30220E0", Offset = "0x30220E0", VA = "0x30220E0")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3022178", Offset = "0x3022178", VA = "0x3022178")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x30222A0", Offset = "0x30222A0", VA = "0x30222A0")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x30223CC", Offset = "0x30223CC", VA = "0x30223CC")]
	public static ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3022484", Offset = "0x3022484", VA = "0x3022484")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3022534", Offset = "0x3022534", VA = "0x3022534")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x30225FC", Offset = "0x30225FC", VA = "0x30225FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5324", Offset = "0x11B5324")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AB4", Offset = "0x11B2AB4")]
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
			[Address(RVA = "0x3A35B5C", Offset = "0x3A35B5C", VA = "0x3A35B5C", Slot = "4")]
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
			[Address(RVA = "0x3A35BA4", Offset = "0x3A35BA4", VA = "0x3A35BA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x3A359AC", Offset = "0x3A359AC", VA = "0x3A359AC")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x3A359D8", Offset = "0x3A359D8", VA = "0x3A359D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x3A359DC", Offset = "0x3A359DC", VA = "0x3A359DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x3A35B64", Offset = "0x3A35B64", VA = "0x3A35B64", Slot = "8")]
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
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B36A0", Offset = "0x11B36A0")]
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
	[Address(RVA = "0x3021A04", Offset = "0x3021A04", VA = "0x3021A04")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x3021A9C", Offset = "0x3021A9C", VA = "0x3021A9C")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x3021BC4", Offset = "0x3021BC4", VA = "0x3021BC4")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x3021CDC", Offset = "0x3021CDC", VA = "0x3021CDC")]
	public static RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x3021ED8", Offset = "0x3021ED8", VA = "0x3021ED8")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x3021F84", Offset = "0x3021F84", VA = "0x3021F84")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x302204C", Offset = "0x302204C", VA = "0x302204C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B53D4", Offset = "0x11B53D4")]
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
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AC4", Offset = "0x11B2AC4")]
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
			[Address(RVA = "0x3A36A8C", Offset = "0x3A36A8C", VA = "0x3A36A8C", Slot = "4")]
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
			[Address(RVA = "0x3A36AD4", Offset = "0x3A36AD4", VA = "0x3A36AD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x3A367C4", Offset = "0x3A367C4", VA = "0x3A367C4")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x3A367F0", Offset = "0x3A367F0", VA = "0x3A367F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x3A367F4", Offset = "0x3A367F4", VA = "0x3A367F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x3A36A94", Offset = "0x3A36A94", VA = "0x3A36A94", Slot = "8")]
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
	[Address(RVA = "0x302BFB4", Offset = "0x302BFB4", VA = "0x302BFB4")]
	public RFStorage()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x302C040", Offset = "0x302C040", VA = "0x302C040")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x302C184", Offset = "0x302C184", VA = "0x302C184")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5484", Offset = "0x11B5484")]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x302C1FC", Offset = "0x302C1FC", VA = "0x302C1FC")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x302C288", Offset = "0x302C288", VA = "0x302C288")]
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
		[Address(RVA = "0x37DB93C", Offset = "0x37DB93C", VA = "0x37DB93C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000009")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x600004D")]
		[Address(RVA = "0x37DF610", Offset = "0x37DF610", VA = "0x37DF610")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000A")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0x37DF6BC", Offset = "0x37DF6BC", VA = "0x37DF6BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x37DC9F0", Offset = "0x37DC9F0", VA = "0x37DC9F0")]
	public RFCluster()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x37D9B1C", Offset = "0x37D9B1C", VA = "0x37D9B1C")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x37DCB30", Offset = "0x37DCB30", VA = "0x37DCB30", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x37D9EAC", Offset = "0x37D9EAC", VA = "0x37D9EAC")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x37DCBB4", Offset = "0x37DCBB4", VA = "0x37DCBB4")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x37DCE24", Offset = "0x37DCE24", VA = "0x37DCE24")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x37DD064", Offset = "0x37DD064", VA = "0x37DD064")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x37DD870", Offset = "0x37DD870", VA = "0x37DD870")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x37DD598", Offset = "0x37DD598", VA = "0x37DD598")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x37DDDB4", Offset = "0x37DDDB4", VA = "0x37DDDB4")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x37DD71C", Offset = "0x37DD71C", VA = "0x37DD71C")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x37DDF74", Offset = "0x37DDF74", VA = "0x37DDF74")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x37DE690", Offset = "0x37DE690", VA = "0x37DE690")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x37DE114", Offset = "0x37DE114", VA = "0x37DE114")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x37DE874", Offset = "0x37DE874", VA = "0x37DE874")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x37DED2C", Offset = "0x37DED2C", VA = "0x37DED2C")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x37DDE6C", Offset = "0x37DDE6C", VA = "0x37DDE6C")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x37DF274", Offset = "0x37DF274", VA = "0x37DF274")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x37DDCE0", Offset = "0x37DDCE0", VA = "0x37DDCE0")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x37DF3E4", Offset = "0x37DF3E4", VA = "0x37DF3E4")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x37DF4DC", Offset = "0x37DF4DC", VA = "0x37DF4DC")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x37DF778", Offset = "0x37DF778", VA = "0x37DF778")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x37DF938", Offset = "0x37DF938", VA = "0x37DF938")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x37DFA7C", Offset = "0x37DFA7C", VA = "0x37DFA7C")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x37DFE30", Offset = "0x37DFE30", VA = "0x37DFE30")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x37E0210", Offset = "0x37E0210", VA = "0x37E0210")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x37E035C", Offset = "0x37E035C", VA = "0x37E035C")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x37E0B2C", Offset = "0x37E0B2C", VA = "0x37E0B2C")]
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
	public delegate void EventActionRoot(RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x331B214", Offset = "0x331B214", VA = "0x331B214")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5534", Offset = "0x11B5534")]
		add
		{
		}
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x331B2B4", Offset = "0x331B2B4", VA = "0x331B2B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5544", Offset = "0x11B5544")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x331B354", Offset = "0x331B354", VA = "0x331B354")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5554", Offset = "0x11B5554")]
		add
		{
		}
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x331B3F4", Offset = "0x331B3F4", VA = "0x331B3F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5564", Offset = "0x11B5564")]
		remove
		{
		}
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x331B494", Offset = "0x331B494", VA = "0x331B494")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x331B4A8", Offset = "0x331B4A8", VA = "0x331B4A8")]
	public void InvokeLocalEventRoot(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x331B4BC", Offset = "0x331B4BC", VA = "0x331B4BC")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x2000012")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000003")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x37E9B50", Offset = "0x37E9B50", VA = "0x37E9B50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5574", Offset = "0x11B5574")]
		add
		{
		}
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x37E9C0C", Offset = "0x37E9C0C", VA = "0x37E9C0C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5584", Offset = "0x11B5584")]
		remove
		{
		}
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x37E67B0", Offset = "0x37E67B0", VA = "0x37E67B0")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x37E9CC8", Offset = "0x37E9CC8", VA = "0x37E9CC8")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x2000013")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x37D969C", Offset = "0x37D969C", VA = "0x37D969C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5594", Offset = "0x11B5594")]
		add
		{
		}
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x37D9758", Offset = "0x37D9758", VA = "0x37D9758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55A4", Offset = "0x11B55A4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x37D9814", Offset = "0x37D9814", VA = "0x37D9814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55B4", Offset = "0x11B55B4")]
		add
		{
		}
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x37D98D4", Offset = "0x37D98D4", VA = "0x37D98D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55C4", Offset = "0x11B55C4")]
		remove
		{
		}
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x37D91E4", Offset = "0x37D91E4", VA = "0x37D91E4")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x37D9634", Offset = "0x37D9634", VA = "0x37D9634")]
	public static void InvokeGlobalEventRoot(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x37D9994", Offset = "0x37D9994", VA = "0x37D9994")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x2000014")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000006")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000070")]
		[Address(RVA = "0x302682C", Offset = "0x302682C", VA = "0x302682C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55D4", Offset = "0x11B55D4")]
		add
		{
		}
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x30268E8", Offset = "0x30268E8", VA = "0x30268E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55E4", Offset = "0x11B55E4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x30269A4", Offset = "0x30269A4", VA = "0x30269A4")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x3026A0C", Offset = "0x3026A0C", VA = "0x3026A0C")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x2000015")]
public class RFShotEvent
{
	[Token(Token = "0x2000016")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x302A8A0", Offset = "0x302A8A0", VA = "0x302A8A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B55F4", Offset = "0x11B55F4")]
		add
		{
		}
		[Token(Token = "0x6000075")]
		[Address(RVA = "0x302A95C", Offset = "0x302A95C", VA = "0x302A95C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5604", Offset = "0x11B5604")]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0x302AA18", Offset = "0x302AA18", VA = "0x302AA18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5614", Offset = "0x11B5614")]
		add
		{
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0x302AAB8", Offset = "0x302AAB8", VA = "0x302AAB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5624", Offset = "0x11B5624")]
		remove
		{
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x302AB58", Offset = "0x302AB58", VA = "0x302AB58")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x302ABC0", Offset = "0x302ABC0", VA = "0x302ABC0")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x302ABD4", Offset = "0x302ABD4", VA = "0x302ABD4")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000017")]
public class RFExplosionEvent
{
	[Token(Token = "0x2000018")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x14000009")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x331B4C4", Offset = "0x331B4C4", VA = "0x331B4C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5634", Offset = "0x11B5634")]
		add
		{
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x331B580", Offset = "0x331B580", VA = "0x331B580")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5644", Offset = "0x11B5644")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x331B63C", Offset = "0x331B63C", VA = "0x331B63C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5654", Offset = "0x11B5654")]
		add
		{
		}
		[Token(Token = "0x6000082")]
		[Address(RVA = "0x331B6DC", Offset = "0x331B6DC", VA = "0x331B6DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5664", Offset = "0x11B5664")]
		remove
		{
		}
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x331B77C", Offset = "0x331B77C", VA = "0x331B77C")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x331B7E4", Offset = "0x331B7E4", VA = "0x331B7E4")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x331B7F8", Offset = "0x331B7F8", VA = "0x331B7F8")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x2000019")]
public class RFSliceEvent
{
	[Token(Token = "0x200001A")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x1400000B")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x302ACA4", Offset = "0x302ACA4", VA = "0x302ACA4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5674", Offset = "0x11B5674")]
		add
		{
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x302AD60", Offset = "0x302AD60", VA = "0x302AD60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5684", Offset = "0x11B5684")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x302AE1C", Offset = "0x302AE1C", VA = "0x302AE1C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B5694", Offset = "0x11B5694")]
		add
		{
		}
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x302AEBC", Offset = "0x302AEBC", VA = "0x302AEBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B56A4", Offset = "0x11B56A4")]
		remove
		{
		}
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x302AF5C", Offset = "0x302AF5C", VA = "0x302AF5C")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x302AFC4", Offset = "0x302AFC4", VA = "0x302AFC4")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x302AFD8", Offset = "0x302AFD8", VA = "0x302AFD8")]
	public RFSliceEvent()
	{
	}
}
[Token(Token = "0x200001B")]
public class RFConnectivityEvent
{
	[Token(Token = "0x200001C")]
	public delegate void EventAction(RayfireConnectivity connectivity);

	[Token(Token = "0x1400000D")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x37E396C", Offset = "0x37E396C", VA = "0x37E396C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B56B4", Offset = "0x11B56B4")]
		add
		{
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x37E3A28", Offset = "0x37E3A28", VA = "0x37E3A28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B56C4", Offset = "0x11B56C4")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x37E3AE4", Offset = "0x37E3AE4", VA = "0x37E3AE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B56D4", Offset = "0x11B56D4")]
		add
		{
		}
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x37E3B84", Offset = "0x37E3B84", VA = "0x37E3B84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B56E4", Offset = "0x11B56E4")]
		remove
		{
		}
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x37E3C24", Offset = "0x37E3C24", VA = "0x37E3C24")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity)
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x37E3C8C", Offset = "0x37E3C8C", VA = "0x37E3C8C")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x37E3CA0", Offset = "0x37E3CA0", VA = "0x37E3CA0")]
	public RFConnectivityEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class RFFlash
{
	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B38AC", Offset = "0x11B38AC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B38AC", Offset = "0x11B38AC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B38AC", Offset = "0x11B38AC")]
	public float intensityMin;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3918", Offset = "0x11B3918")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3918", Offset = "0x11B3918")]
	public float intensityMax;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3960", Offset = "0x11B3960")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3960", Offset = "0x11B3960")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3960", Offset = "0x11B3960")]
	public float rangeMin;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B39CC", Offset = "0x11B39CC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B39CC", Offset = "0x11B39CC")]
	public float rangeMax;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3A14", Offset = "0x11B3A14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3A14", Offset = "0x11B3A14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3A14", Offset = "0x11B3A14")]
	public float distance;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3A80", Offset = "0x11B3A80")]
	public Color color;

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x331CE54", Offset = "0x331CE54", VA = "0x331CE54")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x200001E")]
public class RFDecals
{
	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3A94", Offset = "0x11B3A94")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3A94", Offset = "0x11B3A94")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3A94", Offset = "0x11B3A94")]
	public float sizeMin;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3B00", Offset = "0x11B3B00")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3B00", Offset = "0x11B3B00")]
	public float sizeMax;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3B48", Offset = "0x11B3B48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3B48", Offset = "0x11B3B48")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3B48", Offset = "0x11B3B48")]
	public float distance;

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x37E4728", Offset = "0x37E4728", VA = "0x37E4728")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x200001F")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x2000020")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x3A3571C", Offset = "0x3A3571C", VA = "0x3A3571C")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x3A357A0", Offset = "0x3A357A0", VA = "0x3A357A0")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x33255E0", Offset = "0x33255E0", VA = "0x33255E0")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x3325B18", Offset = "0x3325B18", VA = "0x3325B18")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x3325C40", Offset = "0x3325C40", VA = "0x3325C40")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x331FDD0", Offset = "0x331FDD0", VA = "0x331FDD0")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x3326198", Offset = "0x3326198", VA = "0x3326198")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x3325EA4", Offset = "0x3325EA4", VA = "0x3325EA4")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x3325D18", Offset = "0x3325D18", VA = "0x3325D18")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x3326008", Offset = "0x3326008", VA = "0x3326008")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000021")]
public class RFParticleNoise
{
	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3BC0", Offset = "0x11B3BC0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3BC0", Offset = "0x11B3BC0")]
	public bool enabled;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3C10", Offset = "0x11B3C10")]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3C24", Offset = "0x11B3C24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3C24", Offset = "0x11B3C24")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3C24", Offset = "0x11B3C24")]
	public float strengthMin;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3C98", Offset = "0x11B3C98")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3C98", Offset = "0x11B3C98")]
	public float strengthMax;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3CDC", Offset = "0x11B3CDC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3CDC", Offset = "0x11B3CDC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3CDC", Offset = "0x11B3CDC")]
	public float frequency;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3D54", Offset = "0x11B3D54")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3D54", Offset = "0x11B3D54")]
	public float scrollSpeed;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3DA4", Offset = "0x11B3DA4")]
	public bool damping;

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x33268B8", Offset = "0x33268B8", VA = "0x33268B8")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x33268FC", Offset = "0x33268FC", VA = "0x33268FC")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000022")]
public class RFParticleRendering
{
	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3DB8", Offset = "0x11B3DB8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3DB8", Offset = "0x11B3DB8")]
	public bool castShadows;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3E08", Offset = "0x11B3E08")]
	public bool receiveShadows;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3E1C", Offset = "0x11B3E1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3E1C", Offset = "0x11B3E1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3E1C", Offset = "0x11B3E1C")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x3326948", Offset = "0x3326948", VA = "0x3326948")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x3326978", Offset = "0x3326978", VA = "0x3326978")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000023")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3E80", Offset = "0x11B3E80")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3E80", Offset = "0x11B3E80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3E80", Offset = "0x11B3E80")]
	public float speedMin;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3EE8", Offset = "0x11B3EE8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3EE8", Offset = "0x11B3EE8")]
	public float speedMax;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3F2C", Offset = "0x11B3F2C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3F2C", Offset = "0x11B3F2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3F2C", Offset = "0x11B3F2C")]
	public float velocityMin;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3FA0", Offset = "0x11B3FA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3FA0", Offset = "0x11B3FA0")]
	public float velocityMax;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B3FE4", Offset = "0x11B3FE4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B3FE4", Offset = "0x11B3FE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B3FE4", Offset = "0x11B3FE4")]
	public float gravityMin;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B404C", Offset = "0x11B404C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B404C", Offset = "0x11B404C")]
	public float gravityMax;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B409C", Offset = "0x11B409C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B409C", Offset = "0x11B409C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B409C", Offset = "0x11B409C")]
	public float rotationSpeed;

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x3326694", Offset = "0x3326694", VA = "0x3326694")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x33266E0", Offset = "0x33266E0", VA = "0x33266E0")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000024")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4104", Offset = "0x11B4104")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4104", Offset = "0x11B4104")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4104", Offset = "0x11B4104")]
	public float speedMin;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B416C", Offset = "0x11B416C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B416C", Offset = "0x11B416C")]
	public float speedMax;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B41B0", Offset = "0x11B41B0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B41B0", Offset = "0x11B41B0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B41B0", Offset = "0x11B41B0")]
	public float rotation;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4218", Offset = "0x11B4218")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4218", Offset = "0x11B4218")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4218", Offset = "0x11B4218")]
	public float gravityMin;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4280", Offset = "0x11B4280")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4280", Offset = "0x11B4280")]
	public float gravityMax;

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x332672C", Offset = "0x332672C", VA = "0x332672C")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x3326768", Offset = "0x3326768", VA = "0x3326768")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000025")]
public class RFParticleEmission
{
	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B42D0", Offset = "0x11B42D0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B42D0", Offset = "0x11B42D0")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4320", Offset = "0x11B4320")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4320", Offset = "0x11B4320")]
	public int burstAmount;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4368", Offset = "0x11B4368")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4368", Offset = "0x11B4368")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4368", Offset = "0x11B4368")]
	public float distanceRate;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B43D0", Offset = "0x11B43D0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B43D0", Offset = "0x11B43D0")]
	public float duration;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4414", Offset = "0x11B4414")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4414", Offset = "0x11B4414")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4414", Offset = "0x11B4414")]
	public float lifeMin;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4480", Offset = "0x11B4480")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4480", Offset = "0x11B4480")]
	public float lifeMax;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B44C8", Offset = "0x11B44C8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B44C8", Offset = "0x11B44C8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B44C8", Offset = "0x11B44C8")]
	public float sizeMin;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4534", Offset = "0x11B4534")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4534", Offset = "0x11B4534")]
	public float sizeMax;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x33267A4", Offset = "0x33267A4", VA = "0x33267A4")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x33267EC", Offset = "0x33267EC", VA = "0x33267EC")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000026")]
public class RFParticleLimitations
{
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B457C", Offset = "0x11B457C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B457C", Offset = "0x11B457C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B457C", Offset = "0x11B457C")]
	public int minParticles;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B45F4", Offset = "0x11B45F4")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B45F4", Offset = "0x11B45F4")]
	public int maxParticles;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B463C", Offset = "0x11B463C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B463C", Offset = "0x11B463C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B463C", Offset = "0x11B463C")]
	public int percentage;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B46A8", Offset = "0x11B46A8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B46A8", Offset = "0x11B46A8")]
	public float sizeThreshold;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B46F0", Offset = "0x11B46F0")]
	public int demolitionDepth;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x3326838", Offset = "0x3326838", VA = "0x3326838")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x332687C", Offset = "0x332687C", VA = "0x332687C")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000027")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x2000028")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000B4")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000B5")]
		ByProperties
	}

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4730", Offset = "0x11B4730")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4730", Offset = "0x11B4730")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4780", Offset = "0x11B4780")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4794", Offset = "0x11B4794")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4794", Offset = "0x11B4794")]
	public float radiusScale;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B47E8", Offset = "0x11B47E8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B47E8", Offset = "0x11B47E8")]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4838", Offset = "0x11B4838")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4838", Offset = "0x11B4838")]
	public float dampenMin;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B487C", Offset = "0x11B487C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B487C", Offset = "0x11B487C")]
	public float dampenMax;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B48C0", Offset = "0x11B48C0")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B48C0", Offset = "0x11B48C0")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4910", Offset = "0x11B4910")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4910", Offset = "0x11B4910")]
	public float bounceMin;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4954", Offset = "0x11B4954")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4954", Offset = "0x11B4954")]
	public float bounceMax;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x3326348", Offset = "0x3326348", VA = "0x3326348")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x33263A8", Offset = "0x33263A8", VA = "0x33263A8")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x332640C", Offset = "0x332640C", VA = "0x332640C")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x2000029")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B49A8", Offset = "0x11B49A8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B49A8", Offset = "0x11B49A8")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B49F8", Offset = "0x11B49F8")]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4A0C", Offset = "0x11B4A0C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4A0C", Offset = "0x11B4A0C")]
	public float radiusScale;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x332662C", Offset = "0x332662C", VA = "0x332662C")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x3326668", Offset = "0x3326668", VA = "0x3326668")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class RFParticles
{
	[Token(Token = "0x200002B")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000BD")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000BE")]
		ByProperties
	}

	[Token(Token = "0x200002C")]
	public enum BurstType
	{
		[Token(Token = "0x40000C0")]
		None,
		[Token(Token = "0x40000C1")]
		TotalAmount,
		[Token(Token = "0x40000C2")]
		PerOneUnitSize,
		[Token(Token = "0x40000C3")]
		FragmentAmount
	}

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x33269A4", Offset = "0x33269A4", VA = "0x33269A4")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x3326D40", Offset = "0x3326D40", VA = "0x3326D40")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x33271F4", Offset = "0x33271F4", VA = "0x33271F4")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x33272F4", Offset = "0x33272F4", VA = "0x33272F4")]
	public static void CreateDemolitionDebris(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x3327784", Offset = "0x3327784", VA = "0x3327784")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x3328FB0", Offset = "0x3328FB0", VA = "0x3328FB0")]
	public static void InitActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x3329188", Offset = "0x3329188", VA = "0x3329188")]
	public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x3328650", Offset = "0x3328650", VA = "0x3328650")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x3329558", Offset = "0x3329558", VA = "0x3329558")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x3328C6C", Offset = "0x3328C6C", VA = "0x3328C6C")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x33296E0", Offset = "0x33296E0", VA = "0x33296E0")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x3329868", Offset = "0x3329868", VA = "0x3329868")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x3329B94", Offset = "0x3329B94", VA = "0x3329B94")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x3329D14", Offset = "0x3329D14", VA = "0x3329D14")]
	private static ParticleSystem CreateParticleSystem(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x3329EE8", Offset = "0x3329EE8", VA = "0x3329EE8")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x332A07C", Offset = "0x332A07C", VA = "0x332A07C")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x3327C14", Offset = "0x3327C14", VA = "0x3327C14")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x332A210", Offset = "0x332A210", VA = "0x332A210")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x332A6D8", Offset = "0x332A6D8", VA = "0x332A6D8")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x332B1C4", Offset = "0x332B1C4", VA = "0x332B1C4")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x332B68C", Offset = "0x332B68C", VA = "0x332B68C")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x332B8F8", Offset = "0x332B8F8", VA = "0x332B8F8")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x332BA58", Offset = "0x332BA58", VA = "0x332BA58")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x332BB18", Offset = "0x332BB18", VA = "0x332BB18")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x33299E8", Offset = "0x33299E8", VA = "0x33299E8")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x332BB68", Offset = "0x332BB68", VA = "0x332BB68")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x332BC58", Offset = "0x332BC58", VA = "0x332BC58")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x332BD24", Offset = "0x332BD24", VA = "0x332BD24")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x332BF60", Offset = "0x332BF60", VA = "0x332BF60")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x332C20C", Offset = "0x332C20C", VA = "0x332C20C")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x332C008", Offset = "0x332C008", VA = "0x332C008")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x332C324", Offset = "0x332C324", VA = "0x332C324")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x332C3E8", Offset = "0x332C3E8", VA = "0x332C3E8")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x332C5C0", Offset = "0x332C5C0", VA = "0x332C5C0")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x332C78C", Offset = "0x332C78C", VA = "0x332C78C")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x332C9A8", Offset = "0x332C9A8", VA = "0x332C9A8")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x332CAF8", Offset = "0x332CAF8", VA = "0x332CAF8")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x3328740", Offset = "0x3328740", VA = "0x3328740")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x3328D5C", Offset = "0x3328D5C", VA = "0x3328D5C")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x3328378", Offset = "0x3328378", VA = "0x3328378")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x3328994", Offset = "0x3328994", VA = "0x3328994")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x3329B10", Offset = "0x3329B10", VA = "0x3329B10")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x332CBA0", Offset = "0x332CBA0", VA = "0x332CBA0")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x332CDF4", Offset = "0x332CDF4", VA = "0x332CDF4")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[NonSerialized]
	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float m;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int nAm;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<int> nIds;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<float> nArea;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<int> sIds;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<float> nSt;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float sSt;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform tm;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public MeshFilter mf;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Collider col;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Rigidbody rb;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool[] sCheck;

	[Token(Token = "0x1700000B")]
	public bool StressState
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x302924C", Offset = "0x302924C", VA = "0x302924C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool SupportState
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x3029D00", Offset = "0x3029D00", VA = "0x3029D00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x3029D54", Offset = "0x3029D54", VA = "0x3029D54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x3027088", Offset = "0x3027088", VA = "0x3027088")]
	public RFShard()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x30270C4", Offset = "0x30270C4", VA = "0x30270C4")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x30273E8", Offset = "0x30273E8", VA = "0x30273E8")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x30275B8", Offset = "0x30275B8", VA = "0x30275B8")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x3027720", Offset = "0x3027720", VA = "0x3027720", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x3027750", Offset = "0x3027750", VA = "0x3027750")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x3027C58", Offset = "0x3027C58", VA = "0x3027C58")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x3027CA0", Offset = "0x3027CA0", VA = "0x3027CA0")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x3027DA0", Offset = "0x3027DA0", VA = "0x3027DA0")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x302809C", Offset = "0x302809C", VA = "0x302809C")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x30281C0", Offset = "0x30281C0", VA = "0x30281C0")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x30283C8", Offset = "0x30283C8", VA = "0x30283C8")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x30285D0", Offset = "0x30285D0", VA = "0x30285D0")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x3028FAC", Offset = "0x3028FAC", VA = "0x3028FAC")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x302911C", Offset = "0x302911C", VA = "0x302911C")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x30292A4", Offset = "0x30292A4", VA = "0x30292A4")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x3029394", Offset = "0x3029394", VA = "0x3029394")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x3029428", Offset = "0x3029428", VA = "0x3029428")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x30294F4", Offset = "0x30294F4", VA = "0x30294F4")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x3029820", Offset = "0x3029820", VA = "0x3029820")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x3029BB8", Offset = "0x3029BB8", VA = "0x3029BB8")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x3029C5C", Offset = "0x3029C5C", VA = "0x3029C5C")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x3029D68", Offset = "0x3029D68", VA = "0x3029D68")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x3029E7C", Offset = "0x3029E7C", VA = "0x3029E7C")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class RFSound
{
	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x1700000E")]
	public bool HasClips
	{
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x302B1A4", Offset = "0x302B1A4", VA = "0x302B1A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x302AFE0", Offset = "0x302AFE0", VA = "0x302AFE0")]
	public RFSound()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x302B010", Offset = "0x302B010", VA = "0x302B010")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x302B1FC", Offset = "0x302B1FC", VA = "0x302B1FC")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x302B2F4", Offset = "0x302B2F4", VA = "0x302B2F4")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x302B4CC", Offset = "0x302B4CC", VA = "0x302B4CC")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x302B750", Offset = "0x302B750", VA = "0x302B750")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x302BB3C", Offset = "0x302BB3C", VA = "0x302BB3C")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x302BD20", Offset = "0x302BD20", VA = "0x302BD20")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x302BA7C", Offset = "0x302BA7C", VA = "0x302BA7C")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x302B944", Offset = "0x302B944", VA = "0x302B944")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RFStress
{
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AD4", Offset = "0x11B2AD4")]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x1700000F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x3A36CD8", Offset = "0x3A36CD8", VA = "0x3A36CD8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000010")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x3A36D20", Offset = "0x3A36D20", VA = "0x3A36D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x3A36ADC", Offset = "0x3A36ADC", VA = "0x3A36ADC")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x3A36B08", Offset = "0x3A36B08", VA = "0x3A36B08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x3A36B0C", Offset = "0x3A36B0C", VA = "0x3A36B0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x3A36CE0", Offset = "0x3A36CE0", VA = "0x3A36CE0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x302C3E4", Offset = "0x302C3E4", VA = "0x302C3E4")]
	public RFStress()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x302C4D4", Offset = "0x302C4D4", VA = "0x302C4D4")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x302C4F8", Offset = "0x302C4F8", VA = "0x302C4F8")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x302C588", Offset = "0x302C588", VA = "0x302C588")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B56F4", Offset = "0x11B56F4")]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x302C61C", Offset = "0x302C61C", VA = "0x302C61C")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x302C950", Offset = "0x302C950", VA = "0x302C950")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x302CF68", Offset = "0x302CF68", VA = "0x302CF68")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x302CFB0", Offset = "0x302CFB0", VA = "0x302CFB0")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x302D2EC", Offset = "0x302D2EC", VA = "0x302D2EC")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x302D360", Offset = "0x302D360", VA = "0x302D360")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x302D474", Offset = "0x302D474", VA = "0x302D474")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x302E110", Offset = "0x302E110", VA = "0x302E110")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x302E7E4", Offset = "0x302E7E4", VA = "0x302E7E4")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x302D94C", Offset = "0x302D94C", VA = "0x302D94C")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x302F22C", Offset = "0x302F22C", VA = "0x302F22C")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x302E890", Offset = "0x302E890", VA = "0x302E890")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x2000031")]
public enum AxisType
{
	[Token(Token = "0x4000104")]
	XRed,
	[Token(Token = "0x4000105")]
	YGreen,
	[Token(Token = "0x4000106")]
	ZBlue
}
[Token(Token = "0x2000032")]
public enum PlaneType
{
	[Token(Token = "0x4000108")]
	XY,
	[Token(Token = "0x4000109")]
	XZ,
	[Token(Token = "0x400010A")]
	YZ
}
[Token(Token = "0x2000033")]
public enum FragType
{
	[Token(Token = "0x400010C")]
	Voronoi = 0,
	[Token(Token = "0x400010D")]
	Splinters = 1,
	[Token(Token = "0x400010E")]
	Slabs = 2,
	[Token(Token = "0x400010F")]
	Radial = 3,
	[Token(Token = "0x4000110")]
	Custom = 5,
	[Token(Token = "0x4000111")]
	Slices = 7,
	[Token(Token = "0x4000112")]
	Bricks = 9,
	[Token(Token = "0x4000113")]
	Voxels = 10,
	[Token(Token = "0x4000114")]
	Tets = 11,
	[Token(Token = "0x4000115")]
	Decompose = 15
}
[Token(Token = "0x2000034")]
public enum DemolitionType
{
	[Token(Token = "0x4000117")]
	None = 0,
	[Token(Token = "0x4000118")]
	Runtime = 1,
	[Token(Token = "0x4000119")]
	AwakePrecache = 2,
	[Token(Token = "0x400011A")]
	AwakePrefragment = 3,
	[Token(Token = "0x400011B")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000035")]
public enum CachingType
{
	[Token(Token = "0x400011D")]
	Disable,
	[Token(Token = "0x400011E")]
	ByFrames,
	[Token(Token = "0x400011F")]
	ByFragmentsPerFrame
}
[Token(Token = "0x2000036")]
public enum FadeType
{
	[Token(Token = "0x4000121")]
	None = 0,
	[Token(Token = "0x4000122")]
	SimExclude = 1,
	[Token(Token = "0x4000123")]
	FallDown = 2,
	[Token(Token = "0x4000124")]
	ScaleDown = 3,
	[Token(Token = "0x4000125")]
	MoveDown = 4,
	[Token(Token = "0x4000126")]
	Destroy = 5,
	[Token(Token = "0x4000127")]
	SetStatic = 8,
	[Token(Token = "0x4000128")]
	SetKinematic = 9
}
[Token(Token = "0x2000037")]
public enum RFFadeLifeType
{
	[Token(Token = "0x400012A")]
	ByLifeTime = 4,
	[Token(Token = "0x400012B")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x2000038")]
public enum MaterialType
{
	[Token(Token = "0x400012D")]
	HeavyMetal,
	[Token(Token = "0x400012E")]
	LightMetal,
	[Token(Token = "0x400012F")]
	DenseRock,
	[Token(Token = "0x4000130")]
	PorousRock,
	[Token(Token = "0x4000131")]
	Concrete,
	[Token(Token = "0x4000132")]
	Brick,
	[Token(Token = "0x4000133")]
	Glass,
	[Token(Token = "0x4000134")]
	Rubber,
	[Token(Token = "0x4000135")]
	Ice,
	[Token(Token = "0x4000136")]
	Wood
}
[Token(Token = "0x2000039")]
public enum MassType
{
	[Token(Token = "0x4000138")]
	MaterialDensity,
	[Token(Token = "0x4000139")]
	MassProperty,
	[Token(Token = "0x400013A")]
	RigidBodyComponent
}
[Token(Token = "0x200003A")]
public enum ObjectType
{
	[Token(Token = "0x400013C")]
	Mesh = 0,
	[Token(Token = "0x400013D")]
	MeshRoot = 1,
	[Token(Token = "0x400013E")]
	SkinnedMesh = 2,
	[Token(Token = "0x400013F")]
	NestedCluster = 4,
	[Token(Token = "0x4000140")]
	ConnectedCluster = 5
}
[Token(Token = "0x200003B")]
public enum SimType
{
	[Token(Token = "0x4000142")]
	Dynamic,
	[Token(Token = "0x4000143")]
	Sleeping,
	[Token(Token = "0x4000144")]
	Inactive,
	[Token(Token = "0x4000145")]
	Kinematic,
	[Token(Token = "0x4000146")]
	Static
}
[Token(Token = "0x200003C")]
public enum FragSimType
{
	[Token(Token = "0x4000148")]
	Dynamic,
	[Token(Token = "0x4000149")]
	Sleeping,
	[Token(Token = "0x400014A")]
	Inactive,
	[Token(Token = "0x400014B")]
	Kinematic,
	[Token(Token = "0x400014C")]
	Inherit
}
[Token(Token = "0x200003D")]
public enum ConnectivityType
{
	[Token(Token = "0x400014E")]
	ByBoundingBox = 0,
	[Token(Token = "0x400014F")]
	ByTriangles = 1,
	[Token(Token = "0x4000150")]
	ByPolygons = 3,
	[Token(Token = "0x4000151")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x4000152")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x200003E")]
public enum FragmentMode
{
	[Token(Token = "0x4000154")]
	Runtime,
	[Token(Token = "0x4000155")]
	Editor
}
[Token(Token = "0x200003F")]
public enum RFColliderType
{
	[Token(Token = "0x4000157")]
	Mesh = 0,
	[Token(Token = "0x4000158")]
	Box = 1,
	[Token(Token = "0x4000159")]
	Sphere = 2,
	[Token(Token = "0x400015A")]
	None = 4
}
[Token(Token = "0x2000040")]
public enum RFParenting
{
	[Token(Token = "0x400015C")]
	Manager = 0,
	[Token(Token = "0x400015D")]
	Parent = 1,
	[Token(Token = "0x400015E")]
	Sphere = 2,
	[Token(Token = "0x400015F")]
	None = 4
}
[Token(Token = "0x2000041")]
public class RFFrag
{
	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x331CEC0", Offset = "0x331CEC0", VA = "0x331CEC0")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x2000042")]
public class RFTri
{
	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x302FFA8", Offset = "0x302FFA8", VA = "0x302FFA8")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000043")]
public class RFDictionary
{
	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x331B0C4", Offset = "0x331B0C4", VA = "0x331B0C4")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000044")]
public class RFShatterCluster
{
	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x302A7D4", Offset = "0x302A7D4", VA = "0x302A7D4")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x302A828", Offset = "0x302A828", VA = "0x302A828")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000045")]
public class RFVoronoi
{
	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x17000011")]
	public int Amount
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x303026C", Offset = "0x303026C", VA = "0x303026C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x3030200", Offset = "0x3030200", VA = "0x3030200")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x303022C", Offset = "0x303022C", VA = "0x303022C")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000046")]
public class RFSplinters
{
	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x17000012")]
	public int Amount
	{
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x302BF8C", Offset = "0x302BF8C", VA = "0x302BF8C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x302BF04", Offset = "0x302BF04", VA = "0x302BF04")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x302BF3C", Offset = "0x302BF3C", VA = "0x302BF3C")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000047")]
public class RFRadial
{
	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x3022690", Offset = "0x3022690", VA = "0x3022690")]
	public RFRadial()
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x30226E0", Offset = "0x30226E0", VA = "0x30226E0")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000048")]
public class RFSlice
{
	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x302ABDC", Offset = "0x302ABDC", VA = "0x302ABDC")]
	public RFSlice()
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x302AC08", Offset = "0x302AC08", VA = "0x302AC08")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x302AC4C", Offset = "0x302AC4C", VA = "0x302AC4C")]
	public Vector3 Axis(Transform tm)
	{
		return default(Vector3);
	}
}
[Serializable]
[Token(Token = "0x2000049")]
public class RFBricks
{
	[Token(Token = "0x200004A")]
	public enum RFBrickType
	{
		[Token(Token = "0x40001A0")]
		ByAmount,
		[Token(Token = "0x40001A1")]
		BySize
	}

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x37DC714", Offset = "0x37DC714", VA = "0x37DC714")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x200004B")]
public class RFVoxels
{
	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4A60", Offset = "0x11B4A60")]
	public float size;

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x3030294", Offset = "0x3030294", VA = "0x3030294")]
	public RFVoxels()
	{
	}
}
[Serializable]
[Token(Token = "0x200004C")]
public class RFTets
{
	[Token(Token = "0x200004D")]
	public enum TetType
	{
		[Token(Token = "0x40001A7")]
		Uniform,
		[Token(Token = "0x40001A8")]
		Curved
	}

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x302FF28", Offset = "0x302FF28", VA = "0x302FF28")]
	public RFTets()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x302FF60", Offset = "0x302FF60", VA = "0x302FF60")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x200004E")]
public class RFActivation
{
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AE4", Offset = "0x11B2AE4")]
	private sealed class <ActivationVelocityCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x3A30E6C", Offset = "0x3A30E6C", VA = "0x3A30E6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x3A30EB4", Offset = "0x3A30EB4", VA = "0x3A30EB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x3A30CF8", Offset = "0x3A30CF8", VA = "0x3A30CF8")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x3A30D24", Offset = "0x3A30D24", VA = "0x3A30D24", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x3A30D28", Offset = "0x3A30D28", VA = "0x3A30D28", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x3A30E74", Offset = "0x3A30E74", VA = "0x3A30E74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2AF4", Offset = "0x11B2AF4")]
	private sealed class <ActivationOffsetCor>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFActivation <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x3A30CA8", Offset = "0x3A30CA8", VA = "0x3A30CA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x3A30CF0", Offset = "0x3A30CF0", VA = "0x3A30CF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x3A30B1C", Offset = "0x3A30B1C", VA = "0x3A30B1C")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x3A30B48", Offset = "0x3A30B48", VA = "0x3A30B48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x3A30B4C", Offset = "0x3A30B4C", VA = "0x3A30B4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x3A30CB0", Offset = "0x3A30CB0", VA = "0x3A30CB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B04", Offset = "0x11B2B04")]
	private sealed class <InactiveCor>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x3A30FDC", Offset = "0x3A30FDC", VA = "0x3A30FDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000156")]
			[Address(RVA = "0x3A31024", Offset = "0x3A31024", VA = "0x3A31024", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x3A30EBC", Offset = "0x3A30EBC", VA = "0x3A30EBC")]
		[DebuggerHidden]
		public <InactiveCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x3A30EE8", Offset = "0x3A30EE8", VA = "0x3A30EE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x3A30EEC", Offset = "0x3A30EEC", VA = "0x3A30EEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3A30FE4", Offset = "0x3A30FE4", VA = "0x3A30FE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B14", Offset = "0x11B2B14")]
	private sealed class <InactiveCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFActivation <>4__this;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x3A317A4", Offset = "0x3A317A4", VA = "0x3A317A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x3A317EC", Offset = "0x3A317EC", VA = "0x3A317EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x3A3102C", Offset = "0x3A3102C", VA = "0x3A3102C")]
		[DebuggerHidden]
		public <InactiveCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x3A31058", Offset = "0x3A31058", VA = "0x3A31058", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x3A3105C", Offset = "0x3A3105C", VA = "0x3A3105C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x3A317AC", Offset = "0x3A317AC", VA = "0x3A317AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool local;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float byVelocity;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float byDamage;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool byActivator;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool byImpact;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool byConnectivity;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	public bool unyielding;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool activatable;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string layer;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireConnectivity connect;

	[NonSerialized]
	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool activated;

	[NonSerialized]
	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool inactiveCorState;

	[NonSerialized]
	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool velocityCorState;

	[NonSerialized]
	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public IEnumerator velocityEnum;

	[NonSerialized]
	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x37D8774", Offset = "0x37D8774", VA = "0x37D8774")]
	public RFActivation()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x37D87FC", Offset = "0x37D87FC", VA = "0x37D87FC")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x37D87C4", Offset = "0x37D87C4", VA = "0x37D87C4")]
	public void Reset()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x37D8868", Offset = "0x37D8868", VA = "0x37D8868")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x37D8910", Offset = "0x37D8910", VA = "0x37D8910")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B57A4", Offset = "0x11B57A4")]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x37D89A4", Offset = "0x37D89A4", VA = "0x37D89A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5804", Offset = "0x11B5804")]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x37D8A38", Offset = "0x37D8A38", VA = "0x37D8A38")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5864", Offset = "0x11B5864")]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x37D8ACC", Offset = "0x37D8ACC", VA = "0x37D8ACC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B58C4", Offset = "0x11B58C4")]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x37D8B60", Offset = "0x37D8B60", VA = "0x37D8B60")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x37D924C", Offset = "0x37D924C", VA = "0x37D924C")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x37D90E4", Offset = "0x37D90E4", VA = "0x37D90E4")]
	private static void SetRigidActivationLayer(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x2000053")]
public class RFBackupCluster
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFCluster cluster;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool saved;

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x37D999C", Offset = "0x37D999C", VA = "0x37D999C")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x37D99C4", Offset = "0x37D99C4", VA = "0x37D99C4")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x37DA1D4", Offset = "0x37DA1D4", VA = "0x37DA1D4")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x37DA3FC", Offset = "0x37DA3FC", VA = "0x37DA3FC")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x37DAA7C", Offset = "0x37DAA7C", VA = "0x37DAA7C")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x37DB620", Offset = "0x37DB620", VA = "0x37DB620")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x37D9F0C", Offset = "0x37D9F0C", VA = "0x37D9F0C")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x37DB1A4", Offset = "0x37DB1A4", VA = "0x37DB1A4")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x37DAFA4", Offset = "0x37DAFA4", VA = "0x37DAFA4")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x37DABBC", Offset = "0x37DABBC", VA = "0x37DABBC")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x37DB09C", Offset = "0x37DB09C", VA = "0x37DB09C")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x37DB468", Offset = "0x37DB468", VA = "0x37DB468")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x37DB9B0", Offset = "0x37DB9B0", VA = "0x37DB9B0")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x37DBC54", Offset = "0x37DBC54", VA = "0x37DBC54")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x37DBD60", Offset = "0x37DBD60", VA = "0x37DBD60")]
	public static void RestoreConnectivity(RayfireConnectivity scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000054")]
public class RFCollapse
{
	[Token(Token = "0x2000055")]
	public enum RFCollapseType
	{
		[Token(Token = "0x40001D3")]
		ByArea = 1,
		[Token(Token = "0x40001D4")]
		BySize = 3,
		[Token(Token = "0x40001D5")]
		Random = 5
	}

	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B24", Offset = "0x11B2B24")]
	private sealed class <CollapseCor>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFCollapse <>4__this;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x3A31C8C", Offset = "0x3A31C8C", VA = "0x3A31C8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x3A31CD4", Offset = "0x3A31CD4", VA = "0x3A31CD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x3A31A64", Offset = "0x3A31A64", VA = "0x3A31A64")]
		[DebuggerHidden]
		public <CollapseCor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x3A31A90", Offset = "0x3A31A90", VA = "0x3A31A90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x3A31A94", Offset = "0x3A31A94", VA = "0x3A31A94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x3A31C94", Offset = "0x3A31C94", VA = "0x3A31C94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B34", Offset = "0x11B2B34")]
	private sealed class <CollapseCor>d__12 : IEnumerator<object>, IEnumerator, IDisposable
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
		public RayfireConnectivity scr;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <step>5__3;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int <i>5__4;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x3A31A14", Offset = "0x3A31A14", VA = "0x3A31A14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x3A31A5C", Offset = "0x3A31A5C", VA = "0x3A31A5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x3A317F4", Offset = "0x3A317F4", VA = "0x3A317F4")]
		[DebuggerHidden]
		public <CollapseCor>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x3A31820", Offset = "0x3A31820", VA = "0x3A31820", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x3A31824", Offset = "0x3A31824", VA = "0x3A31824", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x3A31A1C", Offset = "0x3A31A1C", VA = "0x3A31A1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x11B4A7C", Offset = "0x11B4A7C")]
	public RFCollapseType type;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int start;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int end;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int steps;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float duration;

	[NonSerialized]
	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool inProgress;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0x37E0F04", Offset = "0x37E0F04", VA = "0x37E0F04")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x37E0F3C", Offset = "0x37E0F3C", VA = "0x37E0F3C")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x37E0FDC", Offset = "0x37E0FDC", VA = "0x37E0FDC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5A64", Offset = "0x11B5A64")]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x37E1070", Offset = "0x37E1070", VA = "0x37E1070")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x37E1194", Offset = "0x37E1194", VA = "0x37E1194")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x37E1100", Offset = "0x37E1100", VA = "0x37E1100")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5AC4", Offset = "0x11B5AC4")]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x37E11B8", Offset = "0x37E11B8", VA = "0x37E11B8")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x37E1294", Offset = "0x37E1294", VA = "0x37E1294")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x37E1220", Offset = "0x37E1220", VA = "0x37E1220")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x37E12FC", Offset = "0x37E12FC", VA = "0x37E12FC")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x37E1AD0", Offset = "0x37E1AD0", VA = "0x37E1AD0")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x37E16AC", Offset = "0x37E16AC", VA = "0x37E16AC")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x37E20D0", Offset = "0x37E20D0", VA = "0x37E20D0")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x37E2190", Offset = "0x37E2190", VA = "0x37E2190")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x37E2130", Offset = "0x37E2130", VA = "0x37E2130")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x37E21F0", Offset = "0x37E21F0", VA = "0x37E21F0")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x37E2250", Offset = "0x37E2250", VA = "0x37E2250")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x37E1370", Offset = "0x37E1370", VA = "0x37E1370")]
	private static int RemNeibByArea(RFCluster cluster, float minArea)
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x37E17E8", Offset = "0x37E17E8", VA = "0x37E17E8")]
	private static int RemNeibBySize(RFCluster cluster, float minSize)
	{
		return default(int);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x37E1B58", Offset = "0x37E1B58", VA = "0x37E1B58")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x37DC358", Offset = "0x37DC358", VA = "0x37DC358")]
	public static void SetRangeData(RFCluster cluster, int perc = 0, int seed = 0)
	{
	}
}
[Serializable]
[Token(Token = "0x2000058")]
public class RFDamage
{
	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxDamage;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float currentDamage;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool collect;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float multiplier;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x37E450C", Offset = "0x37E450C", VA = "0x37E450C")]
	public RFDamage()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x37E454C", Offset = "0x37E454C", VA = "0x37E454C")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x37DB9A8", Offset = "0x37DB9A8", VA = "0x37DB9A8")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x37E4584", Offset = "0x37E4584", VA = "0x37E4584")]
	public static bool Apply(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x37E45D8", Offset = "0x37E45D8", VA = "0x37E45D8")]
	public static bool ApplyDamage(RayfireRigid scr, float damageValue, Vector3 damagePoint, float damageRadius = 0f)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000059")]
public class RFDemolitionCluster
{
	[Token(Token = "0x200005A")]
	public enum RFDetachType
	{
		[Token(Token = "0x4000201")]
		RatioToSize = 0,
		[Token(Token = "0x4000202")]
		WorldUnits = 3
	}

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float minimumArea;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float minimumSize;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int percentage;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public RFDetachType type;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int ratio;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float units;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardArea;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool shardDemolition;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int minAmount;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int maxAmount;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool demolishable;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFCollapse collapse;

	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int clsCount;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RFCluster> minorClusters;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool cn;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool nd;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int am;

	[NonSerialized]
	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float damageRadius;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string nameApp;

	[Token(Token = "0x1700001F")]
	public bool HasChildClusters
	{
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x37E9A88", Offset = "0x37E9A88", VA = "0x37E9A88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x37E50B8", Offset = "0x37E50B8", VA = "0x37E50B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x37E4760", Offset = "0x37E4760", VA = "0x37E4760")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x37E47C4", Offset = "0x37E47C4", VA = "0x37E47C4")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x37DB9A0", Offset = "0x37DB9A0", VA = "0x37DB9A0")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x37E4854", Offset = "0x37E4854", VA = "0x37E4854")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x37E493C", Offset = "0x37E493C", VA = "0x37E493C")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x37E49F0", Offset = "0x37E49F0", VA = "0x37E49F0")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x37E4EE0", Offset = "0x37E4EE0", VA = "0x37E4EE0")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x37E4C78", Offset = "0x37E4C78", VA = "0x37E4C78")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x37E5110", Offset = "0x37E5110", VA = "0x37E5110")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x37E549C", Offset = "0x37E549C", VA = "0x37E549C")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x37E5758", Offset = "0x37E5758", VA = "0x37E5758")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x37E590C", Offset = "0x37E590C", VA = "0x37E590C")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x37E5AC4", Offset = "0x37E5AC4", VA = "0x37E5AC4")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x37E55CC", Offset = "0x37E55CC", VA = "0x37E55CC")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x37E1F08", Offset = "0x37E1F08", VA = "0x37E1F08")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x37E62C4", Offset = "0x37E62C4", VA = "0x37E62C4")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x37E63D8", Offset = "0x37E63D8", VA = "0x37E63D8")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x37E64E8", Offset = "0x37E64E8", VA = "0x37E64E8")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x37E761C", Offset = "0x37E761C", VA = "0x37E761C")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x37E7D9C", Offset = "0x37E7D9C", VA = "0x37E7D9C")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x37E5ED4", Offset = "0x37E5ED4", VA = "0x37E5ED4")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x37E6B98", Offset = "0x37E6B98", VA = "0x37E6B98")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x37E8120", Offset = "0x37E8120", VA = "0x37E8120")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x37E89D0", Offset = "0x37E89D0", VA = "0x37E89D0")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x37E8DB0", Offset = "0x37E8DB0", VA = "0x37E8DB0")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x37E88B0", Offset = "0x37E88B0", VA = "0x37E88B0")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x37E920C", Offset = "0x37E920C", VA = "0x37E920C")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x37E6818", Offset = "0x37E6818", VA = "0x37E6818")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x37E94EC", Offset = "0x37E94EC", VA = "0x37E94EC")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x37E6A70", Offset = "0x37E6A70", VA = "0x37E6A70")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x37E9918", Offset = "0x37E9918", VA = "0x37E9918")]
	private static bool SameClusterCheck(RayfireRigid scr, List<RFShard> detachShards, int shardAmount, int clusterAmount)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200005B")]
public class RFDemolitionSkin
{
	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<Transform> bones;

	[Token(Token = "0x4000204")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<SkinnedMeshRenderer> skins;

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<SkinnedMeshRenderer> skins0;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<SkinnedMeshRenderer> skins1;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<SkinnedMeshRenderer> skins2;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x331ADE8", Offset = "0x331ADE8", VA = "0x331ADE8")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x331AEA0", Offset = "0x331AEA0", VA = "0x331AEA0")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x331B0BC", Offset = "0x331B0BC", VA = "0x331B0BC")]
	public RFDemolitionSkin()
	{
	}
}
[Serializable]
[Token(Token = "0x200005C")]
public class RFDemolitionMesh
{
	[Token(Token = "0x200005D")]
	public enum MeshInputType
	{
		[Token(Token = "0x400021D")]
		AtStart = 3,
		[Token(Token = "0x400021E")]
		AtInitialization = 6,
		[Token(Token = "0x400021F")]
		AtDemolition = 9
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B44", Offset = "0x11B2B44")]
	private sealed class <RuntimeCachingCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFDemolitionMesh <>4__this;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <demolitionShouldLocal>5__2;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<int> <batchAmount>5__3;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GameObject <tmRefGo>5__4;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<Mesh> <meshesList>5__5;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Vector3> <pivotsList>5__6;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<RFDictionary> <subList>5__7;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int <i>5__8;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x3A327CC", Offset = "0x3A327CC", VA = "0x3A327CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x3A32814", Offset = "0x3A32814", VA = "0x3A32814", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x3A32298", Offset = "0x3A32298", VA = "0x3A32298")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x3A322C4", Offset = "0x3A322C4", VA = "0x3A322C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x3A322C8", Offset = "0x3A322C8", VA = "0x3A322C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x3A327D4", Offset = "0x3A327D4", VA = "0x3A327D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int variation;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float depthFade;

	[Token(Token = "0x400020B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float contactBias;

	[Token(Token = "0x400020C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int seed;

	[Token(Token = "0x400020D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool useShatter;

	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool clusterize;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FragSimType simType;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public MeshInputType meshInput;

	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFFragmentProperties properties;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRuntimeCaching runtimeCaching;

	[NonSerialized]
	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public int badMesh;

	[NonSerialized]
	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public int shatterMode;

	[NonSerialized]
	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int totalAmount;

	[NonSerialized]
	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int innerSubId;

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public Quaternion cacheRotationStart;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Mesh mesh;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFShatter rfShatter;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RayfireShatter scrShatter;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string fragmentStr;

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x37E9CD0", Offset = "0x37E9CD0", VA = "0x37E9CD0")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x37E9DE0", Offset = "0x37E9DE0", VA = "0x37E9DE0")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x37DB994", Offset = "0x37DB994", VA = "0x37DB994")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x37E9EE8", Offset = "0x37E9EE8", VA = "0x37E9EE8")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x37EABCC", Offset = "0x37EABCC", VA = "0x37EABCC")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x37EA194", Offset = "0x37EA194", VA = "0x37EA194")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x37EB200", Offset = "0x37EB200", VA = "0x37EB200")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x37EB618", Offset = "0x37EB618", VA = "0x37EB618")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x37EB0B0", Offset = "0x37EB0B0", VA = "0x37EB0B0")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x37EAAF0", Offset = "0x37EAAF0", VA = "0x37EAAF0")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x37EBD48", Offset = "0x37EBD48", VA = "0x37EBD48")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x37EB0EC", Offset = "0x37EB0EC", VA = "0x37EB0EC")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x37EBE0C", Offset = "0x37EBE0C", VA = "0x37EBE0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5BC4", Offset = "0x11B5BC4")]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x37EBEA0", Offset = "0x37EBEA0", VA = "0x37EBEA0")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x37EBEC8", Offset = "0x37EBEC8", VA = "0x37EBEC8")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x37EBF34", Offset = "0x37EBF34", VA = "0x37EBF34")]
	public static void AwakePrecache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x37EC044", Offset = "0x37EC044", VA = "0x37EC044")]
	public static void AwakePrefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x37EBFBC", Offset = "0x37EBFBC", VA = "0x37EBFBC")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x37EC0D8", Offset = "0x37EC0D8", VA = "0x37EC0D8")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200005F")]
public class RFFade
{
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B54", Offset = "0x11B2B54")]
	private sealed class <FadeOffsetCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x3A33E10", Offset = "0x3A33E10", VA = "0x3A33E10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x3A33E58", Offset = "0x3A33E58", VA = "0x3A33E58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x3A33BE4", Offset = "0x3A33BE4", VA = "0x3A33BE4")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x3A33C10", Offset = "0x3A33C10", VA = "0x3A33C10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x3A33C14", Offset = "0x3A33C14", VA = "0x3A33C14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x3A33E18", Offset = "0x3A33E18", VA = "0x3A33E18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B64", Offset = "0x11B2B64")]
	private sealed class <FadeOffsetCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot scr;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <delay>5__2;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x3A34218", Offset = "0x3A34218", VA = "0x3A34218", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x3A34260", Offset = "0x3A34260", VA = "0x3A34260", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x3A33E60", Offset = "0x3A33E60", VA = "0x3A33E60")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x3A33E8C", Offset = "0x3A33E8C", VA = "0x3A33E8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x3A33E90", Offset = "0x3A33E90", VA = "0x3A33E90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x3A34220", Offset = "0x3A34220", VA = "0x3A34220", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B74", Offset = "0x11B2B74")]
	private sealed class <LivingCor>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x3A34A4C", Offset = "0x3A34A4C", VA = "0x3A34A4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x3A34A94", Offset = "0x3A34A94", VA = "0x3A34A94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x3A34718", Offset = "0x3A34718", VA = "0x3A34718")]
		[DebuggerHidden]
		public <LivingCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x3A34744", Offset = "0x3A34744", VA = "0x3A34744", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x3A34748", Offset = "0x3A34748", VA = "0x3A34748", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x3A34A54", Offset = "0x3A34A54", VA = "0x3A34A54", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B84", Offset = "0x11B2B84")]
	private sealed class <LivingCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x3A34DBC", Offset = "0x3A34DBC", VA = "0x3A34DBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x3A34E04", Offset = "0x3A34E04", VA = "0x3A34E04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x3A34A9C", Offset = "0x3A34A9C", VA = "0x3A34A9C")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x3A34AC8", Offset = "0x3A34AC8", VA = "0x3A34AC8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x3A34ACC", Offset = "0x3A34ACC", VA = "0x3A34ACC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x3A34DC4", Offset = "0x3A34DC4", VA = "0x3A34DC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2B94", Offset = "0x11B2B94")]
	private sealed class <SimulationLivingCor>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform tm;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <oldPos>5__2;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <distanceThreshold>5__3;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x3A35478", Offset = "0x3A35478", VA = "0x3A35478", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x3A354C0", Offset = "0x3A354C0", VA = "0x3A354C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x3A35320", Offset = "0x3A35320", VA = "0x3A35320")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x3A3534C", Offset = "0x3A3534C", VA = "0x3A3534C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x3A35350", Offset = "0x3A35350", VA = "0x3A35350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3A35480", Offset = "0x3A35480", VA = "0x3A35480", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BA4", Offset = "0x11B2BA4")]
	private sealed class <FallDownCor>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x3A3449C", Offset = "0x3A3449C", VA = "0x3A3449C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x3A344E4", Offset = "0x3A344E4", VA = "0x3A344E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3A34268", Offset = "0x3A34268", VA = "0x3A34268")]
		[DebuggerHidden]
		public <FallDownCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x3A34294", Offset = "0x3A34294", VA = "0x3A34294", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x3A34298", Offset = "0x3A34298", VA = "0x3A34298", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x3A344A4", Offset = "0x3A344A4", VA = "0x3A344A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BB4", Offset = "0x11B2BB4")]
	private sealed class <FallDownCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x3A346C8", Offset = "0x3A346C8", VA = "0x3A346C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x3A34710", Offset = "0x3A34710", VA = "0x3A34710", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x3A344EC", Offset = "0x3A344EC", VA = "0x3A344EC")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x3A34518", Offset = "0x3A34518", VA = "0x3A34518", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x3A3451C", Offset = "0x3A3451C", VA = "0x3A3451C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x3A346D0", Offset = "0x3A346D0", VA = "0x3A346D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BC4", Offset = "0x11B2BC4")]
	private sealed class <ScaleDownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x3A35024", Offset = "0x3A35024", VA = "0x3A35024", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x3A3506C", Offset = "0x3A3506C", VA = "0x3A3506C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3A34E0C", Offset = "0x3A34E0C", VA = "0x3A34E0C")]
		[DebuggerHidden]
		public <ScaleDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3A34E38", Offset = "0x3A34E38", VA = "0x3A34E38", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x3A34E3C", Offset = "0x3A34E3C", VA = "0x3A34E3C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x3A3502C", Offset = "0x3A3502C", VA = "0x3A3502C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BD4", Offset = "0x11B2BD4")]
	private sealed class <ScaleDownCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigidRoot root;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFShard shard;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x3A352D0", Offset = "0x3A352D0", VA = "0x3A352D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x3A35318", Offset = "0x3A35318", VA = "0x3A35318", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x3A35074", Offset = "0x3A35074", VA = "0x3A35074")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x3A350A0", Offset = "0x3A350A0", VA = "0x3A350A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x3A350A4", Offset = "0x3A350A4", VA = "0x3A350A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x3A352D8", Offset = "0x3A352D8", VA = "0x3A352D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BE4", Offset = "0x11B2BE4")]
	private sealed class <FadeMoveDownCor>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid rigid;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <steps>5__2;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x3A33814", Offset = "0x3A33814", VA = "0x3A33814", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x3A3385C", Offset = "0x3A3385C", VA = "0x3A3385C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x3A33458", Offset = "0x3A33458", VA = "0x3A33458")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x3A33484", Offset = "0x3A33484", VA = "0x3A33484", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x3A33488", Offset = "0x3A33488", VA = "0x3A33488", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x3A3381C", Offset = "0x3A3381C", VA = "0x3A3381C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2BF4", Offset = "0x11B2BF4")]
	private sealed class <FadeMoveDownCor>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFShard shard;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot root;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <steps>5__2;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 <vectorStep>5__3;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private WaitForSeconds <wait>5__4;

		[Token(Token = "0x17000037")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x3A33B94", Offset = "0x3A33B94", VA = "0x3A33B94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x3A33BDC", Offset = "0x3A33BDC", VA = "0x3A33BDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x3A33864", Offset = "0x3A33864", VA = "0x3A33864")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x3A33890", Offset = "0x3A33890", VA = "0x3A33890", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x3A33894", Offset = "0x3A33894", VA = "0x3A33894", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x3A33B9C", Offset = "0x3A33B9C", VA = "0x3A33B9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool onDemolition;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool onActivation;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float byOffset;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public RFFadeLifeType lifeType;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float lifeTime;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float lifeVariation;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public FadeType fadeType;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fadeTime;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeFilter;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int shardAmount;

	[NonSerialized]
	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int state;

	[NonSerialized]
	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool stop;

	[NonSerialized]
	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 position;

	[NonSerialized]
	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool offsetCorState;

	[NonSerialized]
	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public IEnumerator offsetEnum;

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x331BC10", Offset = "0x331BC10", VA = "0x331BC10")]
	public RFFade()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x331BC94", Offset = "0x331BC94", VA = "0x331BC94")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x331BC7C", Offset = "0x331BC7C", VA = "0x331BC7C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x331BD08", Offset = "0x331BD08", VA = "0x331BD08")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x331BF48", Offset = "0x331BF48", VA = "0x331BF48")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5C74", Offset = "0x11B5C74")]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x331BFC0", Offset = "0x331BFC0", VA = "0x331BFC0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5CD4", Offset = "0x11B5CD4")]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x331BE34", Offset = "0x331BE34", VA = "0x331BE34")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x331C0B0", Offset = "0x331C0B0", VA = "0x331C0B0")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x331C1C0", Offset = "0x331C1C0", VA = "0x331C1C0")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x331C038", Offset = "0x331C038", VA = "0x331C038")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5D34", Offset = "0x11B5D34")]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x331C12C", Offset = "0x331C12C", VA = "0x331C12C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5D94", Offset = "0x11B5D94")]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x331C2E8", Offset = "0x331C2E8", VA = "0x331C2E8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5DF4", Offset = "0x11B5DF4")]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x331C360", Offset = "0x331C360", VA = "0x331C360")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x331C570", Offset = "0x331C570", VA = "0x331C570")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x331C660", Offset = "0x331C660", VA = "0x331C660")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5E54", Offset = "0x11B5E54")]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x331C6D8", Offset = "0x331C6D8", VA = "0x331C6D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5EB4", Offset = "0x11B5EB4")]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x331C76C", Offset = "0x331C76C", VA = "0x331C76C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5F14", Offset = "0x11B5F14")]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x331C7E4", Offset = "0x331C7E4", VA = "0x331C7E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5F74", Offset = "0x11B5F74")]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x331C878", Offset = "0x331C878", VA = "0x331C878")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B5FD4", Offset = "0x11B5FD4")]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x331C8F0", Offset = "0x331C8F0", VA = "0x331C8F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6034", Offset = "0x11B6034")]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x331C984", Offset = "0x331C984", VA = "0x331C984")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x331CBBC", Offset = "0x331CBBC", VA = "0x331CBBC")]
	public static void SetOffsetFadeList(RayfireRigidRoot root)
	{
	}
}
[Serializable]
[Token(Token = "0x200006B")]
public class RFFragmentProperties
{
	[Token(Token = "0x4000270")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFColliderType colliderType;

	[Token(Token = "0x4000271")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sizeFilter;

	[Token(Token = "0x4000272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool decompose;

	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool removeCollinear;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string layer;

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3321F78", Offset = "0x3321F78", VA = "0x3321F78")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3321FDC", Offset = "0x3321FDC", VA = "0x3321FDC")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}
}
[Serializable]
[Token(Token = "0x200006C")]
public class RFLimitations
{
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2C04", Offset = "0x11B2C04")]
	private sealed class <DemolishableCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFLimitations <>4__this;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000039")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x3A356CC", Offset = "0x3A356CC", VA = "0x3A356CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x3A35714", Offset = "0x3A35714", VA = "0x3A35714", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3A35574", Offset = "0x3A35574", VA = "0x3A35574")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x3A355A0", Offset = "0x3A355A0", VA = "0x3A355A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3A355A4", Offset = "0x3A355A4", VA = "0x3A355A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3A356D4", Offset = "0x3A356D4", VA = "0x3A356D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool byCollision;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float solidity;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string tag;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int depth;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float time;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool visible;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool sliceByBlade;

	[NonSerialized]
	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> slicePlanes;

	[NonSerialized]
	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ContactPoint contactPoint;

	[NonSerialized]
	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Vector3 contactVector3;

	[NonSerialized]
	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3 contactNormal;

	[NonSerialized]
	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public bool demolitionShould;

	[NonSerialized]
	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	public bool demolished;

	[NonSerialized]
	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float birthTime;

	[NonSerialized]
	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float bboxSize;

	[NonSerialized]
	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public int currentDepth;

	[NonSerialized]
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool demolishableCorState;

	[NonSerialized]
	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float sliceForce;

	[NonSerialized]
	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool affectInactive;

	[NonSerialized]
	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RayfireRigid ancestor;

	[NonSerialized]
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RayfireRigid> descendants;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string rootStr;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string rigidStr;

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x332201C", Offset = "0x332201C", VA = "0x332201C")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x3322184", Offset = "0x3322184", VA = "0x3322184")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x33220D4", Offset = "0x33220D4", VA = "0x33220D4")]
	public void Reset()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x33221F8", Offset = "0x33221F8", VA = "0x33221F8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6404", Offset = "0x11B6404")]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x332228C", Offset = "0x332228C", VA = "0x332228C")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x3323F7C", Offset = "0x3323F7C", VA = "0x3323F7C")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x3324064", Offset = "0x3324064", VA = "0x3324064")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x33241C0", Offset = "0x33241C0", VA = "0x33241C0")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x332429C", Offset = "0x332429C", VA = "0x332429C")]
	public static void CreateRoot(RayfireRigid rfScr)
	{
	}
}
[Serializable]
[Token(Token = "0x200006E")]
public class RFPhysic
{
	[Token(Token = "0x200006F")]
	private struct RFIgnorePair
	{
		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int a;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private int b;

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x3A359A4", Offset = "0x3A359A4", VA = "0x3A359A4")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2C14", Offset = "0x11B2C14")]
	private sealed class <PhysicsDataCor>d__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RFPhysic <>4__this;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid scr;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x3A35954", Offset = "0x3A35954", VA = "0x3A35954", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000274")]
			[Address(RVA = "0x3A3599C", Offset = "0x3A3599C", VA = "0x3A3599C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x3A357D4", Offset = "0x3A357D4", VA = "0x3A357D4")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x3A35800", Offset = "0x3A35800", VA = "0x3A35800", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x3A35804", Offset = "0x3A35804", VA = "0x3A35804", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x3A3595C", Offset = "0x3A3595C", VA = "0x3A3595C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MaterialType materialType;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public PhysicMaterial material;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MassType massBy;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float mass;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFColliderType colliderType;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool planarCheck;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool ignoreNear;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool useGravity;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int solverIterations;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float dampening;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody rigidBody;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Collider meshCollider;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Collider> clusterColliders;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<int> ignoreList;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool rec;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool exclude;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int solidity;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool destructible;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
	public bool physicsDataCorState;

	[NonSerialized]
	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 velocity;

	[NonSerialized]
	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Vector3 initScale;

	[NonSerialized]
	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 initPosition;

	[NonSerialized]
	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Quaternion initRotation;

	[NonSerialized]
	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Vector3 localPosition;

	[NonSerialized]
	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public IEnumerator physicsEnum;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int coplanarVertLimit;

	[Token(Token = "0x1700003B")]
	public bool HasIgnore
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x33304BC", Offset = "0x33304BC", VA = "0x33304BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x331CB60", Offset = "0x331CB60", VA = "0x331CB60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public bool Destructible
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x3331150", Offset = "0x3331150", VA = "0x3331150")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003E")]
	public int Solidity
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x33311CC", Offset = "0x33311CC", VA = "0x33311CC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x332F418", Offset = "0x332F418", VA = "0x332F418")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x332CECC", Offset = "0x332CECC", VA = "0x332CECC")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x332CFD0", Offset = "0x332CFD0", VA = "0x332CFD0")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x332CF90", Offset = "0x332CF90", VA = "0x332CF90")]
	public void Reset()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x332D060", Offset = "0x332D060", VA = "0x332D060")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x332D0D8", Offset = "0x332D0D8", VA = "0x332D0D8")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x332D138", Offset = "0x332D138", VA = "0x332D138")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x332D310", Offset = "0x332D310", VA = "0x332D310")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x332D414", Offset = "0x332D414", VA = "0x332D414")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x332D460", Offset = "0x332D460", VA = "0x332D460")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x332D4A8", Offset = "0x332D4A8", VA = "0x332D4A8")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x332D350", Offset = "0x332D350", VA = "0x332D350")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x332D4F8", Offset = "0x332D4F8", VA = "0x332D4F8")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x332D99C", Offset = "0x332D99C", VA = "0x332D99C")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x332D830", Offset = "0x332D830", VA = "0x332D830")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x332DAA4", Offset = "0x332DAA4", VA = "0x332DAA4")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x332DAE4", Offset = "0x332DAE4", VA = "0x332DAE4")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x332DBCC", Offset = "0x332DBCC", VA = "0x332DBCC")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x332DC1C", Offset = "0x332DC1C", VA = "0x332DC1C")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x332DEEC", Offset = "0x332DEEC", VA = "0x332DEEC")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x332E02C", Offset = "0x332E02C", VA = "0x332E02C")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x332E548", Offset = "0x332E548", VA = "0x332E548")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x332E760", Offset = "0x332E760", VA = "0x332E760")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x332E950", Offset = "0x332E950", VA = "0x332E950")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x332EAE8", Offset = "0x332EAE8", VA = "0x332EAE8")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x332EC54", Offset = "0x332EC54", VA = "0x332EC54")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x332EEAC", Offset = "0x332EEAC", VA = "0x332EEAC")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x332EFC0", Offset = "0x332EFC0", VA = "0x332EFC0")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x332F0B4", Offset = "0x332F0B4", VA = "0x332F0B4")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x332F248", Offset = "0x332F248", VA = "0x332F248")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x332F4A0", Offset = "0x332F4A0", VA = "0x332F4A0")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x332F54C", Offset = "0x332F54C", VA = "0x332F54C")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x332F678", Offset = "0x332F678", VA = "0x332F678")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x332F778", Offset = "0x332F778", VA = "0x332F778")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x332F938", Offset = "0x332F938", VA = "0x332F938")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x332FAA0", Offset = "0x332FAA0", VA = "0x332FAA0")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x332FE58", Offset = "0x332FE58", VA = "0x332FE58")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x3330078", Offset = "0x3330078", VA = "0x3330078")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x3330BAC", Offset = "0x3330BAC", VA = "0x3330BAC")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x3330CC8", Offset = "0x3330CC8", VA = "0x3330CC8")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x3330794", Offset = "0x3330794", VA = "0x3330794")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x3330514", Offset = "0x3330514", VA = "0x3330514")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x3330940", Offset = "0x3330940", VA = "0x3330940")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x3330E70", Offset = "0x3330E70", VA = "0x3330E70")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x332DEE0", Offset = "0x332DEE0", VA = "0x332DEE0")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x33310BC", Offset = "0x33310BC", VA = "0x33310BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B64B4", Offset = "0x11B64B4")]
	public IEnumerator PhysicsDataCor(RayfireRigid scr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000071")]
public class RFReferenceDemolition
{
	[Token(Token = "0x2000072")]
	public enum ActionType
	{
		[Token(Token = "0x40002B9")]
		Instantiate,
		[Token(Token = "0x40002BA")]
		SetActive
	}

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject reference;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> randomList;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ActionType action;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool addRigid;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool inheritScale;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool inheritMaterials;

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x3022768", Offset = "0x3022768", VA = "0x3022768")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x30227A8", Offset = "0x30227A8", VA = "0x30227A8")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x302289C", Offset = "0x302289C", VA = "0x302289C")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x3022B08", Offset = "0x3022B08", VA = "0x3022B08")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x30235AC", Offset = "0x30235AC", VA = "0x30235AC")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x302376C", Offset = "0x302376C", VA = "0x302376C")]
	private static void InheritMaterials(RayfireRigid scr, GameObject instGo)
	{
	}
}
[Serializable]
[Token(Token = "0x2000073")]
public class RFReset
{
	[Token(Token = "0x2000074")]
	public enum PostDemolitionType
	{
		[Token(Token = "0x40002C4")]
		DestroyWithDelay,
		[Token(Token = "0x40002C5")]
		DeactivateToReset
	}

	[Token(Token = "0x2000075")]
	public enum MeshResetType
	{
		[Token(Token = "0x40002C7")]
		Destroy = 0,
		[Token(Token = "0x40002C8")]
		ReuseInputMesh = 2,
		[Token(Token = "0x40002C9")]
		ReuseFragmentMeshes = 4
	}

	[Token(Token = "0x2000076")]
	public enum FragmentsResetType
	{
		[Token(Token = "0x40002CB")]
		Destroy = 0,
		[Token(Token = "0x40002CC")]
		Reuse = 2,
		[Token(Token = "0x40002CD")]
		Preserve = 4
	}

	[Serializable]
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2C24", Offset = "0x11B2C24")]
	private sealed class <>c
	{
		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<RayfireRigid, bool> <>9__23_0;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<RayfireRigid, bool> <>9__23_1;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<RayfireRigid, bool> <>9__29_0;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<RayfireRigid, bool> <>9__29_1;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<RayfireRigid, bool> <>9__29_2;

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3A35E14", Offset = "0x3A35E14", VA = "0x3A35E14")]
		public <>c()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x3A35E1C", Offset = "0x3A35E1C", VA = "0x3A35E1C")]
		internal bool <DestroyFragments>b__23_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3A35E84", Offset = "0x3A35E84", VA = "0x3A35E84")]
		internal bool <DestroyFragments>b__23_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x3A35EEC", Offset = "0x3A35EEC", VA = "0x3A35EEC")]
		internal bool <FragmentReuseState>b__29_0(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x3A35F54", Offset = "0x3A35F54", VA = "0x3A35F54")]
		internal bool <FragmentReuseState>b__29_1(RayfireRigid t)
		{
			return default(bool);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x3A35F78", Offset = "0x3A35F78", VA = "0x3A35F78")]
		internal bool <FragmentReuseState>b__29_2(RayfireRigid t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool transform;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool damage;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
	public bool connectivity;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PostDemolitionType action;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float destroyDelay;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MeshResetType mesh;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FragmentsResetType fragments;

	[NonSerialized]
	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool toBeDestroyed;

	[Token(Token = "0x600027B")]
	[Address(RVA = "0x3023960", Offset = "0x3023960", VA = "0x3023960")]
	public RFReset()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x30239A4", Offset = "0x30239A4", VA = "0x30239A4")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x3023A08", Offset = "0x3023A08", VA = "0x3023A08")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x30243EC", Offset = "0x30243EC", VA = "0x30243EC")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x3023C94", Offset = "0x3023C94", VA = "0x3023C94")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x3024B34", Offset = "0x3024B34", VA = "0x3024B34")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3024CE4", Offset = "0x3024CE4", VA = "0x3024CE4")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x302545C", Offset = "0x302545C", VA = "0x302545C")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x30251D0", Offset = "0x30251D0", VA = "0x30251D0")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x302503C", Offset = "0x302503C", VA = "0x302503C")]
	public static void DestroyParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x3025700", Offset = "0x3025700", VA = "0x3025700")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3024674", Offset = "0x3024674", VA = "0x3024674")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3025FB8", Offset = "0x3025FB8", VA = "0x3025FB8")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x3024820", Offset = "0x3024820", VA = "0x3024820")]
	public static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x3025B50", Offset = "0x3025B50", VA = "0x3025B50")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x30267AC", Offset = "0x30267AC", VA = "0x30267AC")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x3024758", Offset = "0x3024758", VA = "0x3024758")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x3023B48", Offset = "0x3023B48", VA = "0x3023B48")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x3025884", Offset = "0x3025884", VA = "0x3025884")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x30240C8", Offset = "0x30240C8", VA = "0x30240C8")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x30241C8", Offset = "0x30241C8", VA = "0x30241C8")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x3024784", Offset = "0x3024784", VA = "0x3024784")]
	public static void ResetSound(RayfireSound scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000078")]
public class RFRuntimeCaching
{
	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public CachingType type;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4AD4", Offset = "0x11B4AD4")]
	public int frames;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4AF0", Offset = "0x11B4AF0")]
	public int fragments;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool skipFirstDemolition;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	[HideInInspector]
	public bool inProgress;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
	[HideInInspector]
	public bool wasUsed;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
	[HideInInspector]
	public bool stop;

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x3026ABC", Offset = "0x3026ABC", VA = "0x3026ABC")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x3026AEC", Offset = "0x3026AEC", VA = "0x3026AEC")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x3026CB0", Offset = "0x3026CB0", VA = "0x3026CB0")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x3026D9C", Offset = "0x3026D9C", VA = "0x3026D9C")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x3026EEC", Offset = "0x3026EEC", VA = "0x3026EEC")]
	public static GameObject CreateTmRef(RayfireRigid rfScr)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x2000079")]
public class RFMirrored
{
	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public PlaneType planeType;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool noPoints;

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x3326318", Offset = "0x3326318", VA = "0x3326318")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x3321CB4", Offset = "0x3321CB4", VA = "0x3321CB4")]
	public static List<Vector3> GetMirroredPointCLoud(RFMirrored mirror, Transform tm, int seed, Bounds bound)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200007A")]
public class RFCustom
{
	[Token(Token = "0x200007B")]
	public enum RFPointCloudSourceType
	{
		[Token(Token = "0x40002E8")]
		ChildrenTransform = 4,
		[Token(Token = "0x40002E9")]
		TransformList = 8,
		[Token(Token = "0x40002EA")]
		Vector3List = 12
	}

	[Token(Token = "0x200007C")]
	public enum RFPointCloudUseType
	{
		[Token(Token = "0x40002EC")]
		VolumePoints = 4,
		[Token(Token = "0x40002ED")]
		PointCloud = 12
	}

	[Token(Token = "0x200007D")]
	public enum RFModifierType
	{
		[Token(Token = "0x40002EF")]
		None = 0,
		[Token(Token = "0x40002F0")]
		Splinters = 3,
		[Token(Token = "0x40002F1")]
		Slabs = 6
	}

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFPointCloudSourceType source;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public RFPointCloudUseType useAs;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float radius;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool enable;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float size;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Transform> transforms;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> vector3;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool noPoints;

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x37E3CA8", Offset = "0x37E3CA8", VA = "0x37E3CA8")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x37E3CF8", Offset = "0x37E3CF8", VA = "0x37E3CF8")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x37E3D70", Offset = "0x37E3D70", VA = "0x37E3D70")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x37E3E38", Offset = "0x37E3E38", VA = "0x37E3E38")]
	private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x37E40F4", Offset = "0x37E40F4", VA = "0x37E40F4")]
	private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x37E4334", Offset = "0x37E4334", VA = "0x37E4334")]
	private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x37E4428", Offset = "0x37E4428", VA = "0x37E4428")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x37E44A0", Offset = "0x37E44A0", VA = "0x37E44A0")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200007E")]
public static class RFFragment
{
	[Token(Token = "0x200007F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2C34", Offset = "0x11B2C34")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFSlice slices;

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x3A35550", Offset = "0x3A35550", VA = "0x3A35550")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x3A35558", Offset = "0x3A35558", VA = "0x3A35558")]
		internal Vector3 <SetSlices>b__1(Transform t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x2000080")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2C44", Offset = "0x11B2C44")]
	private sealed class <>c
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Transform, Vector3> <>9__29_0;

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x3A3552C", Offset = "0x3A3552C", VA = "0x3A3552C")]
		public <>c()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x3A35534", Offset = "0x3A35534", VA = "0x3A35534")]
		internal Vector3 <SetSlices>b__29_0(Transform t)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool silentMode;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static List<Mesh> meshListStatic;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static List<Vector3> pivotListStatic;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static List<Dictionary<int, int>> subIdsListStatic;

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x331CEC8", Offset = "0x331CEC8", VA = "0x331CEC8")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x331E434", Offset = "0x331E434", VA = "0x331E434")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x331E77C", Offset = "0x331E77C", VA = "0x331E77C")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x331EC84", Offset = "0x331EC84", VA = "0x331EC84")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x331ED54", Offset = "0x331ED54", VA = "0x331ED54")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x331F690", Offset = "0x331F690", VA = "0x331F690")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x331FAA0", Offset = "0x331FAA0", VA = "0x331FAA0")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x331F91C", Offset = "0x331F91C", VA = "0x331F91C")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x331F5F8", Offset = "0x331F5F8", VA = "0x331F5F8")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x331D548", Offset = "0x331D548", VA = "0x331D548")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x331FE84", Offset = "0x331FE84", VA = "0x331FE84")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x331DEA0", Offset = "0x331DEA0", VA = "0x331DEA0")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x331D478", Offset = "0x331D478", VA = "0x331D478")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x3320494", Offset = "0x3320494", VA = "0x3320494")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x331D9EC", Offset = "0x331D9EC", VA = "0x331D9EC")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x331EF04", Offset = "0x331EF04", VA = "0x331EF04")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x331D638", Offset = "0x331D638", VA = "0x331D638")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x3321850", Offset = "0x3321850", VA = "0x3321850")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x33219D4", Offset = "0x33219D4", VA = "0x33219D4")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x3320514", Offset = "0x3320514", VA = "0x3320514")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x3320658", Offset = "0x3320658", VA = "0x3320658")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x33207BC", Offset = "0x33207BC", VA = "0x33207BC")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x3320920", Offset = "0x3320920", VA = "0x3320920")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x3320B80", Offset = "0x3320B80", VA = "0x3320B80")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x3321BF8", Offset = "0x3321BF8", VA = "0x3321BF8")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x3320C78", Offset = "0x3320C78", VA = "0x3320C78")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x3320FF0", Offset = "0x3320FF0", VA = "0x3320FF0")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x3321228", Offset = "0x3321228", VA = "0x3321228")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x3321D50", Offset = "0x3321D50", VA = "0x3321D50")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x33212A4", Offset = "0x33212A4", VA = "0x33212A4")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x33215F8", Offset = "0x33215F8", VA = "0x33215F8")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x3321654", Offset = "0x3321654", VA = "0x3321654")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x3321AB4", Offset = "0x3321AB4", VA = "0x3321AB4")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x3321BD0", Offset = "0x3321BD0", VA = "0x3321BD0")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3321D64", Offset = "0x3321D64", VA = "0x3321D64")]
	public static void RescaleMesh(Mesh mesh, float scale)
	{
	}
}
[Serializable]
[Token(Token = "0x2000081")]
public class RFMeshExport
{
	[Token(Token = "0x2000082")]
	public enum MeshExportType
	{
		[Token(Token = "0x40002FC")]
		LastFragments = 0,
		[Token(Token = "0x40002FD")]
		Children = 3
	}

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MeshExportType source;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string suffix;

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x33262BC", Offset = "0x33262BC", VA = "0x33262BC")]
	public RFMeshExport()
	{
	}
}
[Serializable]
[Token(Token = "0x2000083")]
public class RFShatterAdvanced
{
	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int seed;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool decompose;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool removeCollinear;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	public bool copyComponents;

	[Token(Token = "0x4000302")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
	public bool postWeld;

	[Token(Token = "0x4000303")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool smooth;

	[Token(Token = "0x4000304")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool inputPrecap;

	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	public bool outputPrecap;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
	public bool removeDoubleFaces;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int elementSizeThreshold;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool combineChildren;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool inner;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	public bool planar;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int relativeSize;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float absoluteSize;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool vertexLimitation;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexAmount;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float planarThreshold;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x302A014", Offset = "0x302A014", VA = "0x302A014")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x302A074", Offset = "0x302A074", VA = "0x302A074")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x302A0FC", Offset = "0x302A0FC", VA = "0x302A0FC")]
	public static bool IsCoplanar(Mesh mesh, float threshold)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000084")]
public class RFSurface
{
	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material innerMaterial;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float mappingScale;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material outerMaterial;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool needNewMat;

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x302F8EC", Offset = "0x302F8EC", VA = "0x302F8EC")]
	public RFSurface()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x302F93C", Offset = "0x302F93C", VA = "0x302F93C")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x302F990", Offset = "0x302F990", VA = "0x302F990")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x302FC38", Offset = "0x302FC38", VA = "0x302FC38")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x302FDB0", Offset = "0x302FDB0", VA = "0x302FDB0")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000085")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2C54", Offset = "0x11B2C54")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2C54", Offset = "0x11B2C54")]
public class RayfireActivator : MonoBehaviour
{
	[Token(Token = "0x2000086")]
	public enum ActivationType
	{
		[Token(Token = "0x4000337")]
		OnTriggerEnter,
		[Token(Token = "0x4000338")]
		OnTriggerExit,
		[Token(Token = "0x4000339")]
		OnCollision
	}

	[Token(Token = "0x2000087")]
	public enum AnimationType
	{
		[Token(Token = "0x400033B")]
		ByGlobalPositionList = 0,
		[Token(Token = "0x400033C")]
		ByStaticLine = 1,
		[Token(Token = "0x400033D")]
		ByDynamicLine = 2,
		[Token(Token = "0x400033E")]
		ByLocalPositionList = 5
	}

	[Token(Token = "0x2000088")]
	public enum GizmoType
	{
		[Token(Token = "0x4000340")]
		Box = 1,
		[Token(Token = "0x4000341")]
		Sphere = 0,
		[Token(Token = "0x4000342")]
		Collider = 2,
		[Token(Token = "0x4000343")]
		ParticleSystem = 5
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2CB4", Offset = "0x11B2CB4")]
	private sealed class <DelayedActivationCor>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x3A372AC", Offset = "0x3A372AC", VA = "0x3A372AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x3A372F4", Offset = "0x3A372F4", VA = "0x3A372F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x3A37168", Offset = "0x3A37168", VA = "0x3A37168")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x3A37194", Offset = "0x3A37194", VA = "0x3A37194", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x3A37198", Offset = "0x3A37198", VA = "0x3A37198", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x3A372B4", Offset = "0x3A372B4", VA = "0x3A372B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2CC4", Offset = "0x11B2CC4")]
	private sealed class <DelayedClusterCor>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigid rigid;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000302")]
			[Address(RVA = "0x3A376A4", Offset = "0x3A376A4", VA = "0x3A376A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x3A376EC", Offset = "0x3A376EC", VA = "0x3A376EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x3A37490", Offset = "0x3A37490", VA = "0x3A37490")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x3A374BC", Offset = "0x3A374BC", VA = "0x3A374BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x3A374C0", Offset = "0x3A374C0", VA = "0x3A374C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x3A376AC", Offset = "0x3A376AC", VA = "0x3A376AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2CD4", Offset = "0x11B2CD4")]
	private sealed class <DelayedActivationCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider coll;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000308")]
			[Address(RVA = "0x3A37440", Offset = "0x3A37440", VA = "0x3A37440", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x3A37488", Offset = "0x3A37488", VA = "0x3A37488", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x3A372FC", Offset = "0x3A372FC", VA = "0x3A372FC")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x3A37328", Offset = "0x3A37328", VA = "0x3A37328", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x3A3732C", Offset = "0x3A3732C", VA = "0x3A3732C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x3A37448", Offset = "0x3A37448", VA = "0x3A37448", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2CE4", Offset = "0x11B2CE4")]
	private sealed class <AnimationCor>d__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireActivator <>4__this;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x3A37118", Offset = "0x3A37118", VA = "0x3A37118", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x3A37160", Offset = "0x3A37160", VA = "0x3A37160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x3A36D28", Offset = "0x3A36D28", VA = "0x3A36D28")]
		[DebuggerHidden]
		public <AnimationCor>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x3A36D54", Offset = "0x3A36D54", VA = "0x3A36D54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x3A36D58", Offset = "0x3A36D58", VA = "0x3A36D58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x3A37120", Offset = "0x3A37120", VA = "0x3A37120", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GizmoType gizmoType;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sphereRadius;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 boxSize;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool checkRigid;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool checkRigidRoot;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ActivationType type;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float delay;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool demolishCluster;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool apply;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 velocity;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3 spin;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public ForceMode mode;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showAnimation;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float duration;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float scaleAnimation;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public AnimationType positionAnimation;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public LineRenderer line;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<Vector3> positionList;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool showGizmo;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Collider activatorCollider;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ParticleSystem ps;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<ParticleCollisionEvent> collisionEvents;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool animating;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float pathRatio;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float lineLength;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<float> checkpoints;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float delta;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private float deltaRatioStep;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float distDeltaStep;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private float distRatio;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float timePassed;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private int activeSegment;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Vector3 positionStart;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private Vector3 scaleStart;

	[Token(Token = "0x17000042")]
	public bool ByPositions
	{
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x3032030", Offset = "0x3032030", VA = "0x3032030")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public bool ByLine
	{
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x3031444", Offset = "0x3031444", VA = "0x3031444")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x30302C0", Offset = "0x30302C0", VA = "0x30302C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x303079C", Offset = "0x303079C", VA = "0x303079C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x3030848", Offset = "0x3030848", VA = "0x3030848")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x3030990", Offset = "0x3030990", VA = "0x3030990")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x30309A0", Offset = "0x30309A0", VA = "0x30309A0")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x3030338", Offset = "0x3030338", VA = "0x3030338")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x30305A0", Offset = "0x30305A0", VA = "0x30305A0")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x30307F8", Offset = "0x30307F8", VA = "0x30307F8")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x30309B4", Offset = "0x30309B4", VA = "0x30309B4")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x3030E30", Offset = "0x3030E30", VA = "0x3030E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6564", Offset = "0x11B6564")]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x3030EC4", Offset = "0x3030EC4", VA = "0x3030EC4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B65C4", Offset = "0x11B65C4")]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x3030DE8", Offset = "0x3030DE8", VA = "0x3030DE8")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x3030C14", Offset = "0x3030C14", VA = "0x3030C14")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x30311F0", Offset = "0x30311F0", VA = "0x30311F0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6624", Offset = "0x11B6624")]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x3031058", Offset = "0x3031058", VA = "0x3031058")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x3030F6C", Offset = "0x3030F6C", VA = "0x3030F6C")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x3031298", Offset = "0x3031298", VA = "0x3031298")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x3031380", Offset = "0x3031380", VA = "0x3031380")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x3031458", Offset = "0x3031458", VA = "0x3031458")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x303167C", Offset = "0x303167C", VA = "0x303167C")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x303185C", Offset = "0x303185C", VA = "0x303185C")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x30313CC", Offset = "0x30313CC", VA = "0x30313CC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6684", Offset = "0x11B6684")]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x3031B04", Offset = "0x3031B04", VA = "0x3031B04")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x3031C18", Offset = "0x3031C18", VA = "0x3031C18")]
	private void ResetData()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x3031C80", Offset = "0x3031C80", VA = "0x3031C80")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x3031C88", Offset = "0x3031C88", VA = "0x3031C88")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x3031CC8", Offset = "0x3031CC8", VA = "0x3031CC8")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x3031F64", Offset = "0x3031F64", VA = "0x3031F64")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x303204C", Offset = "0x303204C", VA = "0x303204C")]
	public RayfireActivator()
	{
	}
}
[Token(Token = "0x200008D")]
public class RFSliceData
{
	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Vector3 planePos;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 planeDir;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 swingDir;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float swingStr;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float force;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float damage;

	[Token(Token = "0x6000311")]
	[Address(RVA = "0x302AC9C", Offset = "0x302AC9C", VA = "0x302AC9C")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x200008E")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2CF4", Offset = "0x11B2CF4")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2CF4", Offset = "0x11B2CF4")]
public class RayfireBlade : MonoBehaviour
{
	[Token(Token = "0x200008F")]
	public enum CutType
	{
		[Token(Token = "0x4000372")]
		Enter,
		[Token(Token = "0x4000373")]
		Exit,
		[Token(Token = "0x4000374")]
		EnterExit
	}

	[Token(Token = "0x2000090")]
	public enum ActionType
	{
		[Token(Token = "0x4000376")]
		Slice,
		[Token(Token = "0x4000377")]
		Demolish
	}

	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2D54", Offset = "0x11B2D54")]
	private sealed class <CooldownCor>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBlade <>4__this;

		[Token(Token = "0x1700004D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x3A37808", Offset = "0x3A37808", VA = "0x3A37808", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000329")]
			[Address(RVA = "0x3A37850", Offset = "0x3A37850", VA = "0x3A37850", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x3A376F4", Offset = "0x3A376F4", VA = "0x3A376F4")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x3A37720", Offset = "0x3A37720", VA = "0x3A37720", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x3A37724", Offset = "0x3A37724", VA = "0x3A37724", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x3A37810", Offset = "0x3A37810", VA = "0x3A37810", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ActionType actionType;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public CutType onTrigger;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public PlaneType sliceType;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float force;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool affectInactive;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float damage;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool skin;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float cooldown;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int mask;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string tagFilter;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<GameObject> targets;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireRigid rigid;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform transForm;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3[] enterPlane;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Vector3[] exitPlane;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Collider colLider;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Vector3[] slicePlanes;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public bool coolDownState;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private RFSliceData sliceData;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 posEnter;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 posExit;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFSliceEvent sliceEvent;

	[Token(Token = "0x1700004C")]
	public bool HasTargets
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x3032E38", Offset = "0x3032E38", VA = "0x3032E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x30320F8", Offset = "0x30320F8", VA = "0x30320F8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x30320FC", Offset = "0x30320FC", VA = "0x30320FC")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x3032334", Offset = "0x3032334", VA = "0x3032334")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x3032410", Offset = "0x3032410", VA = "0x3032410")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x3032338", Offset = "0x3032338", VA = "0x3032338")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x3032414", Offset = "0x3032414", VA = "0x3032414")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x30328E8", Offset = "0x30328E8", VA = "0x30328E8")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x3032B18", Offset = "0x3032B18", VA = "0x3032B18")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6824", Offset = "0x11B6824")]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x3032B90", Offset = "0x3032B90", VA = "0x3032B90")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x3032A10", Offset = "0x3032A10", VA = "0x3032A10")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x3032BB8", Offset = "0x3032BB8", VA = "0x3032BB8")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x3032714", Offset = "0x3032714", VA = "0x3032714")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x3032ACC", Offset = "0x3032ACC", VA = "0x3032ACC")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x3032620", Offset = "0x3032620", VA = "0x3032620")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x3032CE0", Offset = "0x3032CE0", VA = "0x3032CE0")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x3032B9C", Offset = "0x3032B9C", VA = "0x3032B9C")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x3032E90", Offset = "0x3032E90", VA = "0x3032E90")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000092")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2D64", Offset = "0x11B2D64")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2D64", Offset = "0x11B2D64")]
public class RayfireBomb : MonoBehaviour
{
	[Token(Token = "0x2000093")]
	public enum RangeType
	{
		[Token(Token = "0x4000399")]
		Spherical
	}

	[Token(Token = "0x2000094")]
	public enum FadeType
	{
		[Token(Token = "0x400039B")]
		Linear,
		[Token(Token = "0x400039C")]
		Exponential,
		[Token(Token = "0x400039D")]
		None
	}

	[Serializable]
	[Token(Token = "0x2000095")]
	public class Projectile
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 positionPivot;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 positionClosest;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fade;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Rigidbody rb;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public RayfireRigid rigid;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Quaternion rotation;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public RFShard shard;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RayfireRigidRoot rigidRoot;

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x3A37998", Offset = "0x3A37998", VA = "0x3A37998")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2DC4", Offset = "0x11B2DC4")]
	private sealed class <ExplodeCor>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireBomb <>4__this;

		[Token(Token = "0x1700004F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x3A37948", Offset = "0x3A37948", VA = "0x3A37948", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x3A37990", Offset = "0x3A37990", VA = "0x3A37990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x3A37858", Offset = "0x3A37858", VA = "0x3A37858")]
		[DebuggerHidden]
		public <ExplodeCor>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x3A37884", Offset = "0x3A37884", VA = "0x3A37884", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x3A37888", Offset = "0x3A37888", VA = "0x3A37888", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x3A37950", Offset = "0x3A37950", VA = "0x3A37950", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool showGizmo;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RangeType rangeType;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FadeType fadeType;

	[Token(Token = "0x400037E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x400037F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int deletion;

	[Token(Token = "0x4000380")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float strength;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int variation;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int chaos;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool forceByMass;

	[Token(Token = "0x4000384")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	public bool affectInactive;

	[Token(Token = "0x4000385")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	public bool affectKinematic;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float heightOffset;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float delay;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool atStart;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool destroy;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool applyDamage;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float damageValue;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool play;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float volume;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip clip;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFExplosionEvent explosionEvent;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Vector3 bombPosition;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[HideInInspector]
	public Vector3 explPosition;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int mask;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public string tagFilter;

	[NonSerialized]
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private List<Projectile> projectiles;

	[NonSerialized]
	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<Projectile> deletionProjectiles;

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x3032F40", Offset = "0x3032F40", VA = "0x3032F40")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x3032FD0", Offset = "0x3032FD0", VA = "0x3032FD0")]
	private void Start()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x303306C", Offset = "0x303306C", VA = "0x303306C")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x3033014", Offset = "0x3033014", VA = "0x3033014")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x3033228", Offset = "0x3033228", VA = "0x3033228")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B68D4", Offset = "0x11B68D4")]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x3033114", Offset = "0x3033114", VA = "0x3033114")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x3033E80", Offset = "0x3033E80", VA = "0x3033E80")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x3033350", Offset = "0x3033350", VA = "0x3033350")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x3032F44", Offset = "0x3032F44", VA = "0x3032F44")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3034614", Offset = "0x3034614", VA = "0x3034614")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x303463C", Offset = "0x303463C", VA = "0x303463C")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x30332A0", Offset = "0x30332A0", VA = "0x30332A0")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x3033F48", Offset = "0x3033F48", VA = "0x3033F48")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x3033F94", Offset = "0x3033F94", VA = "0x3033F94")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x30333BC", Offset = "0x30333BC", VA = "0x30333BC")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x30335B4", Offset = "0x30335B4", VA = "0x30335B4")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x30338C8", Offset = "0x30338C8", VA = "0x30338C8")]
	private void Activate()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x3033C40", Offset = "0x3033C40", VA = "0x3033C40")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x30348CC", Offset = "0x30348CC", VA = "0x30348CC")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x3034940", Offset = "0x3034940", VA = "0x3034940")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x303499C", Offset = "0x303499C", VA = "0x303499C")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000097")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2DD4", Offset = "0x11B2DD4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2DD4", Offset = "0x11B2DD4")]
[SelectionBase]
public class RayfireCluster : MonoBehaviour
{
	[Token(Token = "0x2000098")]
	public enum ClusterType
	{
		[Token(Token = "0x40003BB")]
		ByPointCloud,
		[Token(Token = "0x40003BC")]
		BySharedArea
	}

	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2E44", Offset = "0x11B2E44")]
	private sealed class <>c__DisplayClass24_0
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFShard biggestShard;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x3A379A0", Offset = "0x3A379A0", VA = "0x3A379A0")]
		public <>c__DisplayClass24_0()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x3A379A8", Offset = "0x3A379A8", VA = "0x3A379A8")]
		internal bool <ClusterizeRangeShards>b__0(RFShard t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200009A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2E54", Offset = "0x11B2E54")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public RFCluster biggestCluster;

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x3A379D8", Offset = "0x3A379D8", VA = "0x3A379D8")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x3A379E0", Offset = "0x3A379E0", VA = "0x3A379E0")]
		internal bool <ClusterizeRangeClusters>b__0(RFCluster t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4BA8", Offset = "0x11B4BA8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4BA8", Offset = "0x11B4BA8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4BA8", Offset = "0x11B4BA8")]
	public ClusterType type;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4C18", Offset = "0x11B4C18")]
	public int depth;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4C30", Offset = "0x11B4C30")]
	public int seed;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4C4C", Offset = "0x11B4C4C")]
	public int smoothPass;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4C64", Offset = "0x11B4C64")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4C64", Offset = "0x11B4C64")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4C64", Offset = "0x11B4C64")]
	public int baseAmount;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4CDC", Offset = "0x11B4CDC")]
	public int depthAmount;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4CF8", Offset = "0x11B4CF8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4CF8", Offset = "0x11B4CF8")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4CF8", Offset = "0x11B4CF8")]
	public int minimumAmount;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B4D6C", Offset = "0x11B4D6C")]
	public int maximumAmount;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[HideInInspector]
	public bool showGizmo;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	[HideInInspector]
	public bool colorPreview;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	[HideInInspector]
	public bool scalePreview;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Color wireColor;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public float previewScale;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public List<RFCluster> allClusters;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public List<RFShard> allShards;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int clusterId;

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x3034B24", Offset = "0x3034B24", VA = "0x3034B24")]
	public void Extract()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x3034D94", Offset = "0x3034D94", VA = "0x3034D94")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x3034E24", Offset = "0x3034E24", VA = "0x3034E24")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x30356EC", Offset = "0x30356EC", VA = "0x30356EC")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x3036EBC", Offset = "0x3036EBC", VA = "0x3036EBC")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x3035060", Offset = "0x3035060", VA = "0x3035060")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x3037B20", Offset = "0x3037B20", VA = "0x3037B20")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x3037FC8", Offset = "0x3037FC8", VA = "0x3037FC8")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x303650C", Offset = "0x303650C", VA = "0x303650C")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x3038928", Offset = "0x3038928", VA = "0x3038928")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x30362E0", Offset = "0x30362E0", VA = "0x30362E0")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x30392CC", Offset = "0x30392CC", VA = "0x30392CC")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x303870C", Offset = "0x303870C", VA = "0x303870C")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x30355D8", Offset = "0x30355D8", VA = "0x30355D8")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x3035F48", Offset = "0x3035F48", VA = "0x3035F48")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x3037928", Offset = "0x3037928", VA = "0x3037928")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x303941C", Offset = "0x303941C", VA = "0x303941C")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x3038374", Offset = "0x3038374", VA = "0x3038374")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x3036160", Offset = "0x3036160", VA = "0x3036160")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x3039774", Offset = "0x3039774", VA = "0x3039774")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x200009B")]
public class RFCombineMesh
{
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2E64", Offset = "0x11B2E64")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transForm;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> transList;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int m;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Func<Vector3, Vector3> <>9__0;

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x3A31DC4", Offset = "0x3A31DC4", VA = "0x3A31DC4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x3A31DCC", Offset = "0x3A31DCC", VA = "0x3A31DCC")]
		internal Vector3 <GetCombinedMesh>b__0(Vector3 t)
		{
			return default(Vector3);
		}
	}

	[Serializable]
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2E74", Offset = "0x11B2E74")]
	private sealed class <>c
	{
		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Vector3, Vector3> <>9__7_1;

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x3A31D40", Offset = "0x3A31D40", VA = "0x3A31D40")]
		public <>c()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x3A31D48", Offset = "0x3A31D48", VA = "0x3A31D48")]
		internal Vector3 <GetCombinedMesh>b__7_1(Vector3 o)
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2E84", Offset = "0x11B2E84")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Material> allMaterials;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Material, int> <>9__0;

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x3A31D58", Offset = "0x3A31D58", VA = "0x3A31D58")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x3A31D60", Offset = "0x3A31D60", VA = "0x3A31D60")]
		internal int <GetMatIdList>b__0(Material t)
		{
			return default(int);
		}
	}

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<int> trianglesSubId;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<List<int>> triangles;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<Vector3> vertices;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<Vector3> normals;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector2> uvs;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<Vector4> tangents;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x37E22DC", Offset = "0x37E22DC", VA = "0x37E22DC")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x37E24BC", Offset = "0x37E24BC", VA = "0x37E24BC")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x37E2C3C", Offset = "0x37E2C3C", VA = "0x37E2C3C")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x37E2E14", Offset = "0x37E2E14", VA = "0x37E2E14")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x37E2FE0", Offset = "0x37E2FE0", VA = "0x37E2FE0")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x37E33C0", Offset = "0x37E33C0", VA = "0x37E33C0")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x37E35BC", Offset = "0x37E35BC", VA = "0x37E35BC")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x37E37D0", Offset = "0x37E37D0", VA = "0x37E37D0")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x200009F")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2E94", Offset = "0x11B2E94")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2E94", Offset = "0x11B2E94")]
public class RayfireCombine : MonoBehaviour
{
	[Token(Token = "0x20000A0")]
	public enum CombType
	{
		[Token(Token = "0x40003E1")]
		Children,
		[Token(Token = "0x40003E2")]
		ObjectsList
	}

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CombType type;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<GameObject> objects;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool meshFilters;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool skinnedMeshes;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool particleSystems;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float sizeThreshold;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int vertexThreshold;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Transform transForm;

	[Token(Token = "0x40003D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private MeshFilter mFilter;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private MeshRenderer mRenderer;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<bool> invertNormals;

	[Token(Token = "0x40003D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<Transform> transList;

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<MeshFilter> mFilters;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SkinnedMeshRenderer> skinnedMeshRends;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<ParticleSystemRenderer> particleRends;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Mesh> meshList;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<List<int>> matIdList;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<List<Material>> matList;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<Material> allMaterials;

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x3763DB4", Offset = "0x3763DB4", VA = "0x3763DB4")]
	public void Combine()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x3763E90", Offset = "0x3763E90", VA = "0x3763E90")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x376574C", Offset = "0x376574C", VA = "0x376574C")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x20000A1")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2EF4", Offset = "0x11B2EF4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2EF4", Offset = "0x11B2EF4")]
[DisallowMultipleComponent]
public class RayfireConnectivity : MonoBehaviour
{
	[Token(Token = "0x20000A2")]
	public enum RFConnInitType
	{
		[Token(Token = "0x4000406")]
		AtStart = 1,
		[Token(Token = "0x4000407")]
		ByMethod = 3,
		[Token(Token = "0x4000408")]
		ByIntegrity = 5
	}

	[Token(Token = "0x20000A3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2F64", Offset = "0x11B2F64")]
	private sealed class <ConnectivityCor>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x3A37C20", Offset = "0x3A37C20", VA = "0x3A37C20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x3A37C68", Offset = "0x3A37C68", VA = "0x3A37C68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x3A37B34", Offset = "0x3A37B34", VA = "0x3A37B34")]
		[DebuggerHidden]
		public <ConnectivityCor>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x3A37B60", Offset = "0x3A37B60", VA = "0x3A37B60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x3A37B64", Offset = "0x3A37B64", VA = "0x3A37B64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x3A37C28", Offset = "0x3A37C28", VA = "0x3A37C28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2F74", Offset = "0x11B2F74")]
	private sealed class <ChildrenCor>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity <>4__this;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <checkChildren>5__2;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600039B")]
			[Address(RVA = "0x3A37AE4", Offset = "0x3A37AE4", VA = "0x3A37AE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600039D")]
			[Address(RVA = "0x3A37B2C", Offset = "0x3A37B2C", VA = "0x3A37B2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x3A37A10", Offset = "0x3A37A10", VA = "0x3A37A10")]
		[DebuggerHidden]
		public <ChildrenCor>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x3A37A3C", Offset = "0x3A37A3C", VA = "0x3A37A3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x3A37A40", Offset = "0x3A37A40", VA = "0x3A37A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x3A37AEC", Offset = "0x3A37AEC", VA = "0x3A37AEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ConnectivityType type;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float expand;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float minimumArea;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float minimumSize;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int percentage;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int seed;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool clusterize;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool demolishable;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public RFConnInitType startCollapse;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int collapseByIntegrity;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCollapse collapse;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFConnInitType startStress;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int stressByIntegrity;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFStress stress;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool showConnections;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	public bool showNodes;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	public bool showGizmo;

	[Token(Token = "0x40003F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
	public bool showStress;

	[Token(Token = "0x40003F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public bool checkConnectivity;

	[Token(Token = "0x40003F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	public bool connectivityCheckNeed;

	[Token(Token = "0x40003F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x40003F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFCluster cluster;

	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int initShardAmount;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int clsCount;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RayfireRigidRoot rigidRootHost;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RayfireRigid meshRootHost;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Collider triggerCollider;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public int triggerDebris;

	[NonSerialized]
	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public RFBackupCluster backup;

	[NonSerialized]
	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public bool childrenChanged;

	[NonSerialized]
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool childrenCorState;

	[NonSerialized]
	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
	private bool connectivityCorState;

	[NonSerialized]
	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
	private bool corState;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public RFConnectivityEvent connectivityEvent;

	[Token(Token = "0x17000051")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x37674C8", Offset = "0x37674C8", VA = "0x37674C8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x3765774", Offset = "0x3765774", VA = "0x3765774")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x37658CC", Offset = "0x37658CC", VA = "0x37658CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x37658D8", Offset = "0x37658D8", VA = "0x37658D8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x3765AC8", Offset = "0x3765AC8", VA = "0x3765AC8")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x3765C8C", Offset = "0x3765C8C", VA = "0x3765C8C")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x3766334", Offset = "0x3766334", VA = "0x3766334")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x37663C4", Offset = "0x37663C4", VA = "0x37663C4")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x3766544", Offset = "0x3766544", VA = "0x3766544")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x3765E7C", Offset = "0x3765E7C", VA = "0x3765E7C")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x3766110", Offset = "0x3766110", VA = "0x3766110")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x3766DB4", Offset = "0x3766DB4", VA = "0x3766DB4")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x3766628", Offset = "0x3766628", VA = "0x3766628")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x3766844", Offset = "0x3766844", VA = "0x3766844")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x3766E90", Offset = "0x3766E90", VA = "0x3766E90")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x3765A50", Offset = "0x3765A50", VA = "0x3765A50")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6984", Offset = "0x11B6984")]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x37671EC", Offset = "0x37671EC", VA = "0x37671EC")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x37673D4", Offset = "0x37673D4", VA = "0x37673D4")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x37672E0", Offset = "0x37672E0", VA = "0x37672E0")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x3767970", Offset = "0x3767970", VA = "0x3767970")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x3767EB8", Offset = "0x3767EB8", VA = "0x3767EB8")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x3767538", Offset = "0x3767538", VA = "0x3767538")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x3767760", Offset = "0x3767760", VA = "0x3767760")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x3767B94", Offset = "0x3767B94", VA = "0x3767B94")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x3767CA8", Offset = "0x3767CA8", VA = "0x3767CA8")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x3769088", Offset = "0x3769088", VA = "0x3769088")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x37659D8", Offset = "0x37659D8", VA = "0x37659D8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B69E4", Offset = "0x11B69E4")]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x3769094", Offset = "0x3769094", VA = "0x3769094")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x3769430", Offset = "0x3769430", VA = "0x3769430")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x3765FE4", Offset = "0x3765FE4", VA = "0x3765FE4")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x3769468", Offset = "0x3769468", VA = "0x3769468")]
	public void Fracture()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x3769474", Offset = "0x3769474", VA = "0x3769474")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x3769988", Offset = "0x3769988", VA = "0x3769988")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x3769E24", Offset = "0x3769E24", VA = "0x3769E24")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x20000A5")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B2F84", Offset = "0x11B2F84")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B2F84", Offset = "0x11B2F84")]
public class RayfireDebris : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B2FF4", Offset = "0x11B2FF4")]
	private sealed class <>c
	{
		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<MeshFilter, bool> <>9__28_0;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<MeshFilter, Mesh> <>9__28_1;

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x3A37CD4", Offset = "0x3A37CD4", VA = "0x3A37CD4")]
		public <>c()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x3A37CDC", Offset = "0x3A37CDC", VA = "0x3A37CDC")]
		internal bool <SetReferenceMeshes>b__28_0(MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x3A37D90", Offset = "0x3A37D90", VA = "0x3A37D90")]
		internal Mesh <SetReferenceMeshes>b__28_1(MeshFilter mf)
		{
			return null;
		}
	}

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4DF4", Offset = "0x11B4DF4")]
	public bool onDemolition;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4E2C", Offset = "0x11B4E2C")]
	public bool onActivation;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4E40", Offset = "0x11B4E40")]
	public bool onImpact;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4E54", Offset = "0x11B4E54")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4E54", Offset = "0x11B4E54")]
	public GameObject debrisReference;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4EA4", Offset = "0x11B4EA4")]
	public Material debrisMaterial;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4EB8", Offset = "0x11B4EB8")]
	public Material emissionMaterial;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B4ECC", Offset = "0x11B4ECC")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4ECC", Offset = "0x11B4ECC")]
	public RFParticleEmission emission;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4F1C", Offset = "0x11B4F1C")]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4F30", Offset = "0x11B4F30")]
	public RFParticleNoise noise;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4F44", Offset = "0x11B4F44")]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4F58", Offset = "0x11B4F58")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B4F6C", Offset = "0x11B4F6C")]
	public RFParticleRendering rendering;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<Mesh> debrisMeshList;

	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 refScale;

	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[HideInInspector]
	public List<RayfireDebris> children;

	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000056")]
	public bool HasChildren
	{
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x376AE58", Offset = "0x376AE58", VA = "0x376AE58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x3769EC8", Offset = "0x3769EC8", VA = "0x3769EC8")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x376A100", Offset = "0x376A100", VA = "0x376A100")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x376A200", Offset = "0x376A200", VA = "0x376A200")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x376A7B8", Offset = "0x376A7B8", VA = "0x376A7B8")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x376AC24", Offset = "0x376AC24", VA = "0x376AC24")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x376A8FC", Offset = "0x376A8FC", VA = "0x376A8FC")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x376AEB0", Offset = "0x376AEB0", VA = "0x376AEB0")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x376A214", Offset = "0x376A214", VA = "0x376A214")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x376B0DC", Offset = "0x376B0DC", VA = "0x376B0DC")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x20000A7")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3004", Offset = "0x11B3004")]
[SelectionBase]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3004", Offset = "0x11B3004")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B5010", Offset = "0x11B5010")]
	public bool onDemolition;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5048", Offset = "0x11B5048")]
	public bool onActivation;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B505C", Offset = "0x11B505C")]
	public bool onImpact;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B5070", Offset = "0x11B5070")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x11B5070", Offset = "0x11B5070")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5070", Offset = "0x11B5070")]
	public float opacity;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B50DC", Offset = "0x11B50DC")]
	public Material dustMaterial;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B50F0", Offset = "0x11B50F0")]
	public List<Material> dustMaterials;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5104", Offset = "0x11B5104")]
	public Material emissionMaterial;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x11B5118", Offset = "0x11B5118")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5118", Offset = "0x11B5118")]
	public RFParticleEmission emission;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5168", Offset = "0x11B5168")]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B517C", Offset = "0x11B517C")]
	public RFParticleNoise noise;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B5190", Offset = "0x11B5190")]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B51A4", Offset = "0x11B51A4")]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B51B8", Offset = "0x11B51B8")]
	public RFParticleRendering rendering;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public ParticleSystem pSystem;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public Transform hostTm;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public bool initialized;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public List<RayfireDust> children;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int amountFinal;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public bool oldChild;

	[Token(Token = "0x17000057")]
	public bool HasChildren
	{
		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x376BE9C", Offset = "0x376BE9C", VA = "0x376BE9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000058")]
	public bool HasMaterials
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x376B7EC", Offset = "0x376B7EC", VA = "0x376B7EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x376B2DC", Offset = "0x376B2DC", VA = "0x376B2DC")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x376B4B4", Offset = "0x376B4B4", VA = "0x376B4B4")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x376B5AC", Offset = "0x376B5AC", VA = "0x376B5AC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x376B844", Offset = "0x376B844", VA = "0x376B844")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x376BC68", Offset = "0x376BC68", VA = "0x376BC68")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x376B968", Offset = "0x376B968", VA = "0x376B968")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x376BEF4", Offset = "0x376BEF4", VA = "0x376BEF4")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x376C070", Offset = "0x376C070", VA = "0x376C070")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x20000A8")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3074", Offset = "0x11B3074")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3074", Offset = "0x11B3074")]
public class RayfireGun : MonoBehaviour
{
	[Token(Token = "0x20000A9")]
	public enum ImpactType
	{
		[Token(Token = "0x4000457")]
		AddExplosionForce,
		[Token(Token = "0x4000458")]
		AddForceAtPosition
	}

	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B30D4", Offset = "0x11B30D4")]
	private sealed class <StartShootCor>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <shootId>5__2;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x3A38040", Offset = "0x3A38040", VA = "0x3A38040", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x3A38088", Offset = "0x3A38088", VA = "0x3A38088", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x3A37F24", Offset = "0x3A37F24", VA = "0x3A37F24")]
		[DebuggerHidden]
		public <StartShootCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x3A37F50", Offset = "0x3A37F50", VA = "0x3A37F50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x3A37F54", Offset = "0x3A37F54", VA = "0x3A37F54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x3A38048", Offset = "0x3A38048", VA = "0x3A38048", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B30E4", Offset = "0x11B30E4")]
	private sealed class <BurstCor>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireGun <>4__this;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x3A37ED4", Offset = "0x3A37ED4", VA = "0x3A37ED4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x3A37F1C", Offset = "0x3A37F1C", VA = "0x3A37F1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x3A37DAC", Offset = "0x3A37DAC", VA = "0x3A37DAC")]
		[DebuggerHidden]
		public <BurstCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x3A37DD8", Offset = "0x3A37DD8", VA = "0x3A37DD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x3A37DDC", Offset = "0x3A37DDC", VA = "0x3A37DDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x3A37EDC", Offset = "0x3A37EDC", VA = "0x3A37EDC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AxisType axis;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maxDistance;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform target;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int rounds;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float rate;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ImpactType type;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float strength;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float radius;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public bool demolishCluster;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	public bool affectInactive;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	public bool rigid;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	public bool rigidRoot;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x11B523C", Offset = "0x11B523C")]
	public bool rigidBody;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float damage;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool debris;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool dust;

	[Token(Token = "0x400044C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool flash;

	[Token(Token = "0x400044D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFFlash Flash;

	[Token(Token = "0x400044E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int mask;

	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool showRay;

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool showHit;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool shooting;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string untagged;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFShotEvent shotEvent;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Collider[] impactColliders;

	[Token(Token = "0x17000059")]
	public Vector3 ShootVector
	{
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x376C2B0", Offset = "0x376C2B0", VA = "0x376C2B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x376C17C", Offset = "0x376C17C", VA = "0x376C17C")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x376C1B4", Offset = "0x376C1B4", VA = "0x376C1B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6AE4", Offset = "0x11B6AE4")]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x376C22C", Offset = "0x376C22C", VA = "0x376C22C")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x376C234", Offset = "0x376C234", VA = "0x376C234")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x376C92C", Offset = "0x376C92C", VA = "0x376C92C")]
	public void Burst()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x376C964", Offset = "0x376C964", VA = "0x376C964")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6B44", Offset = "0x11B6B44")]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x376C400", Offset = "0x376C400", VA = "0x376C400")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x376D148", Offset = "0x376D148", VA = "0x376D148")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x376D8F0", Offset = "0x376D8F0", VA = "0x376D8F0")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x376DD70", Offset = "0x376DD70", VA = "0x376DD70")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x376CF28", Offset = "0x376CF28", VA = "0x376CF28")]
	private RayfireRigid ApplyDamage(RayfireRigid scrRigid, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x376C9DC", Offset = "0x376C9DC", VA = "0x376C9DC")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x376CBC8", Offset = "0x376CBC8", VA = "0x376CBC8")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x376CD78", Offset = "0x376CD78", VA = "0x376CD78")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x376DF8C", Offset = "0x376DF8C", VA = "0x376DF8C")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x376E324", Offset = "0x376E324", VA = "0x376E324")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x20000AC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B30F4", Offset = "0x11B30F4")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B30F4", Offset = "0x11B30F4")]
[DisallowMultipleComponent]
public class RayfireMan : MonoBehaviour
{
	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static RayfireMan inst;

	[Token(Token = "0x4000462")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int buildMajor;

	[Token(Token = "0x4000463")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static int buildMinor;

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool setGravity;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float multiplier;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RigidbodyInterpolation interpolation;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float colliderSize;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static float colliderSizeStatic;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x11B5274", Offset = "0x11B5274")]
	public CollisionDetectionMode meshCollision;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public CollisionDetectionMode clusterCollision;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float minimumMass;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float maximumMass;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFMaterialPresets materialPresets;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject parent;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float globalSolidity;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float timeQuota;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFManDemolition advancedDemolitionProperties;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFPoolingFragment fragments;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFPoolingParticles particles;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform transForm;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public List<string> layers;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFStorage storage;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float maxTimeThisFrame;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public HashSet<string> layersHash;

	[Token(Token = "0x1700005E")]
	public static bool MaxAmountCheck
	{
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x376EDE4", Offset = "0x376EDE4", VA = "0x376EDE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x376E4A8", Offset = "0x376E4A8", VA = "0x376E4A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x376E74C", Offset = "0x376E74C", VA = "0x376E74C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x376E754", Offset = "0x376E754", VA = "0x376E754")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x376E4AC", Offset = "0x376E4AC", VA = "0x376E4AC")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x376EA4C", Offset = "0x376EA4C", VA = "0x376EA4C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x376EA84", Offset = "0x376EA84", VA = "0x376EA84")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x376E758", Offset = "0x376E758", VA = "0x376E758")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x376EAE4", Offset = "0x376EAE4", VA = "0x376EAE4")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x376EC60", Offset = "0x376EC60", VA = "0x376EC60")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x376EB30", Offset = "0x376EB30", VA = "0x376EB30")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x376E824", Offset = "0x376E824", VA = "0x376E824")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x376E958", Offset = "0x376E958", VA = "0x376E958")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x376EE68", Offset = "0x376EE68", VA = "0x376EE68")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x376F014", Offset = "0x376F014", VA = "0x376F014")]
	public static void SetParentToManager(Transform tm)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x376F0C0", Offset = "0x376F0C0", VA = "0x376F0C0")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x376F228", Offset = "0x376F228", VA = "0x376F228")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x376F4C4", Offset = "0x376F4C4", VA = "0x376F4C4")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x376F594", Offset = "0x376F594", VA = "0x376F594")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x376F340", Offset = "0x376F340", VA = "0x376F340")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x376F5F8", Offset = "0x376F5F8", VA = "0x376F5F8")]
	public RayfireMan()
	{
	}
}
[Serializable]
[Token(Token = "0x20000AD")]
public class RFCache
{
	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<bool> act;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> pos;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Quaternion> rot;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform transform;

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x37DC774", Offset = "0x37DC774", VA = "0x37DC774")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x20000AE")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3164", Offset = "0x11B3164")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3164", Offset = "0x11B3164")]
[DisallowMultipleComponent]
[SelectionBase]
public class RayfireRecorder : MonoBehaviour
{
	[Token(Token = "0x20000AF")]
	public enum AnimatorType
	{
		[Token(Token = "0x4000494")]
		Disabled = 0,
		[Token(Token = "0x4000495")]
		Record = 2,
		[Token(Token = "0x4000496")]
		Play = 8
	}

	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B31E4", Offset = "0x11B31E4")]
	private sealed class <RecordCor>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRecorder <>4__this;

		[Token(Token = "0x1700005F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x3A3843C", Offset = "0x3A3843C", VA = "0x3A3843C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x3A38484", Offset = "0x3A38484", VA = "0x3A38484", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x3A38090", Offset = "0x3A38090", VA = "0x3A38090")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x3A380BC", Offset = "0x3A380BC", VA = "0x3A380BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x3A380C0", Offset = "0x3A380C0", VA = "0x3A380C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x3A38444", Offset = "0x3A38444", VA = "0x3A38444", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimatorType mode;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool recordOnStart;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string clipName;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float duration;

	[Token(Token = "0x4000482")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rate;

	[Token(Token = "0x4000483")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool reduceKeys;

	[Token(Token = "0x4000484")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float threshold;

	[Token(Token = "0x4000485")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool playOnStart;

	[Token(Token = "0x4000486")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationClip animationClip;

	[Token(Token = "0x4000487")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RuntimeAnimatorController controller;

	[Token(Token = "0x4000488")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool setToKinematic;

	[Token(Token = "0x4000489")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool recorder;

	[Token(Token = "0x400048A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float recordedTime;

	[Token(Token = "0x400048B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int stateNameHash;

	[Token(Token = "0x400048C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string assetFolder;

	[Token(Token = "0x400048D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string clipFolder;

	[Token(Token = "0x400048E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float stepTime;

	[Token(Token = "0x400048F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator animator;

	[Token(Token = "0x4000490")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<Transform> tmList;

	[Token(Token = "0x4000491")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<RFCache> cacheList;

	[Token(Token = "0x4000492")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private List<float> timeList;

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x376F7AC", Offset = "0x376F7AC", VA = "0x376F7AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x376FB60", Offset = "0x376FB60", VA = "0x376FB60")]
	private void Start()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x376FBC4", Offset = "0x376FBC4", VA = "0x376FBC4")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x376F7B0", Offset = "0x376F7B0", VA = "0x376F7B0")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x376FEC8", Offset = "0x376FEC8", VA = "0x376FEC8")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x377014C", Offset = "0x377014C", VA = "0x377014C")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x37708A4", Offset = "0x37708A4", VA = "0x37708A4")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x376FDFC", Offset = "0x376FDFC", VA = "0x376FDFC")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x37708E4", Offset = "0x37708E4", VA = "0x37708E4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6C44", Offset = "0x11B6C44")]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x377095C", Offset = "0x377095C", VA = "0x377095C")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x376FE6C", Offset = "0x376FE6C", VA = "0x376FE6C")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x3770964", Offset = "0x3770964", VA = "0x3770964")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x20000B1")]
[DisallowMultipleComponent]
[SelectionBase]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B31F4", Offset = "0x11B31F4")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B31F4", Offset = "0x11B31F4")]
public class RayfireRestriction : MonoBehaviour
{
	[Token(Token = "0x20000B2")]
	public enum RFBoundActionType
	{
		[Token(Token = "0x40004A5")]
		Fade = 2,
		[Token(Token = "0x40004A6")]
		Reset = 4,
		[Token(Token = "0x40004A7")]
		PostDemolitionAction = 9
	}

	[Token(Token = "0x20000B3")]
	public enum RFDistanceType
	{
		[Token(Token = "0x40004A9")]
		InitializePosition = 0,
		[Token(Token = "0x40004AA")]
		TargetPosition = 2
	}

	[Token(Token = "0x20000B4")]
	public enum RFBoundTriggerType
	{
		[Token(Token = "0x40004AC")]
		Inside = 0,
		[Token(Token = "0x40004AD")]
		Outside = 2
	}

	[Token(Token = "0x20000B5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B3274", Offset = "0x11B3274")]
	private sealed class <RestrictionDistanceCor>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <checkPosition>5__4;

		[Token(Token = "0x17000061")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x3A387AC", Offset = "0x3A387AC", VA = "0x3A387AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x3A387F4", Offset = "0x3A387F4", VA = "0x3A387F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x3A3848C", Offset = "0x3A3848C", VA = "0x3A3848C")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x3A384B8", Offset = "0x3A384B8", VA = "0x3A384B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x3A384BC", Offset = "0x3A384BC", VA = "0x3A384BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x3A387B4", Offset = "0x3A387B4", VA = "0x3A387B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B3284", Offset = "0x11B3284")]
	private sealed class <RestrictionTriggerCor>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireRigid scr;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private WaitForSeconds <intervalDelay>5__2;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <actionDelay>5__3;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <brokeState>5__4;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x3A38BF8", Offset = "0x3A38BF8", VA = "0x3A38BF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000410")]
			[Address(RVA = "0x3A38C40", Offset = "0x3A38C40", VA = "0x3A38C40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x3A387FC", Offset = "0x3A387FC", VA = "0x3A387FC")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x3A38828", Offset = "0x3A38828", VA = "0x3A38828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x3A3882C", Offset = "0x3A3882C", VA = "0x3A3882C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x3A38C00", Offset = "0x3A38C00", VA = "0x3A38C00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool enable;

	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public RFBoundActionType breakAction;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float actionDelay;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float checkInterval;

	[Token(Token = "0x400049E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float distance;

	[Token(Token = "0x400049F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public RFDistanceType position;

	[Token(Token = "0x40004A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform target;

	[Token(Token = "0x40004A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider Collider;

	[Token(Token = "0x40004A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFBoundTriggerType region;

	[Token(Token = "0x40004A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool broke;

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x37709E4", Offset = "0x37709E4", VA = "0x37709E4")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x3770A54", Offset = "0x3770A54", VA = "0x3770A54")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x3770A4C", Offset = "0x3770A4C", VA = "0x3770A4C")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x3770AD0", Offset = "0x3770AD0", VA = "0x3770AD0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x3770B88", Offset = "0x3770B88", VA = "0x3770B88")]
	public static void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x3770EA8", Offset = "0x3770EA8", VA = "0x3770EA8")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x3770DB8", Offset = "0x3770DB8", VA = "0x3770DB8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6CF4", Offset = "0x11B6CF4")]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x3770E30", Offset = "0x3770E30", VA = "0x3770E30")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6D54", Offset = "0x11B6D54")]
	private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x20000B7")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3294", Offset = "0x11B3294")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3294", Offset = "0x11B3294")]
public class RayfireRigid : MonoBehaviour
{
	[Token(Token = "0x20000B8")]
	public enum InitType
	{
		[Token(Token = "0x40004DF")]
		ByMethod,
		[Token(Token = "0x40004E0")]
		AtStart
	}

	[Token(Token = "0x40004BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40004BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40004BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ObjectType objectType;

	[Token(Token = "0x40004BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public DemolitionType demolitionType;

	[Token(Token = "0x40004BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFPhysic physics;

	[Token(Token = "0x40004BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFActivation activation;

	[Token(Token = "0x40004C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFLimitations limitations;

	[Token(Token = "0x40004C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFDemolitionMesh meshDemolition;

	[Token(Token = "0x40004C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x40004C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFReferenceDemolition referenceDemolition;

	[Token(Token = "0x40004C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFSurface materials;

	[Token(Token = "0x40004C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFDamage damage;

	[Token(Token = "0x40004C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFFade fading;

	[Token(Token = "0x40004C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public RFReset reset;

	[Token(Token = "0x40004C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public bool initialized;

	[Token(Token = "0x40004C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	public bool corState;

	[Token(Token = "0x40004CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Mesh[] meshes;

	[Token(Token = "0x40004CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3[] pivots;

	[Token(Token = "0x40004CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMesh[] rfMeshes;

	[Token(Token = "0x40004CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFDictionary> subIds;

	[Token(Token = "0x40004CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RayfireRigid> fragments;

	[Token(Token = "0x40004CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion cacheRotation;

	[Token(Token = "0x40004D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x40004D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform rootChild;

	[Token(Token = "0x40004D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform rootParent;

	[Token(Token = "0x40004D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x40004D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x40004D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x40004D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RayfireDebris> debrisList;

	[Token(Token = "0x40004D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RayfireDust> dustList;

	[Token(Token = "0x40004D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public RayfireRestriction restriction;

	[Token(Token = "0x40004D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public RayfireSound sound;

	[NonSerialized]
	[Token(Token = "0x40004DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public RayfireRigidRoot rigidRoot;

	[Token(Token = "0x40004DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public RFDemolitionEvent demolitionEvent;

	[Token(Token = "0x40004DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x40004DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public RFRestrictionEvent restrictionEvent;

	[Token(Token = "0x17000065")]
	public bool HasFragments
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x376DF34", Offset = "0x376DF34", VA = "0x376DF34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public bool HasMeshes
	{
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x3774458", Offset = "0x3774458", VA = "0x3774458")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000067")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x3774478", Offset = "0x3774478", VA = "0x3774478")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000068")]
	public bool HasDebris
	{
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x3774498", Offset = "0x3774498", VA = "0x3774498")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000069")]
	public bool HasDust
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x37744F0", Offset = "0x37744F0", VA = "0x37744F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public bool HasSlices
	{
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x3773FF8", Offset = "0x3773FF8", VA = "0x3773FF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public bool IsCluster
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x3774548", Offset = "0x3774548", VA = "0x3774548")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x377455C", Offset = "0x377455C", VA = "0x377455C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x3770FA4", Offset = "0x3770FA4", VA = "0x3770FA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x3771084", Offset = "0x3771084", VA = "0x3771084")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x37710D0", Offset = "0x37710D0", VA = "0x37710D0")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x3771D80", Offset = "0x3771D80", VA = "0x3771D80")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x3771DE0", Offset = "0x3771DE0", VA = "0x3771DE0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x3771E38", Offset = "0x3771E38", VA = "0x3771E38")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x3772010", Offset = "0x3772010", VA = "0x3772010")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x37712E0", Offset = "0x37712E0", VA = "0x37712E0")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x377194C", Offset = "0x377194C", VA = "0x377194C")]
	private void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x3771ECC", Offset = "0x3771ECC", VA = "0x3771ECC")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x3771590", Offset = "0x3771590", VA = "0x3771590")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x37724E8", Offset = "0x37724E8", VA = "0x37724E8")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x37726F0", Offset = "0x37726F0", VA = "0x37726F0")]
	private void AddMeshRootRigid()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x3772A54", Offset = "0x3772A54", VA = "0x3772A54")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x37720A4", Offset = "0x37720A4", VA = "0x37720A4")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x3771C18", Offset = "0x3771C18", VA = "0x3771C18")]
	private void SetObjectType()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x3771B34", Offset = "0x3771B34", VA = "0x3771B34")]
	public void Default()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x3772B90", Offset = "0x3772B90", VA = "0x3772B90")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x3771C60", Offset = "0x3771C60", VA = "0x3771C60")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x3772D64", Offset = "0x3772D64", VA = "0x3772D64")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x3770FE0", Offset = "0x3770FE0", VA = "0x3770FE0")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x3772E64", Offset = "0x3772E64", VA = "0x3772E64", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x3772F54", Offset = "0x3772F54", VA = "0x3772F54", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x377325C", Offset = "0x377325C", VA = "0x377325C")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x37733AC", Offset = "0x37733AC", VA = "0x37733AC", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x3773540", Offset = "0x3773540", VA = "0x3773540")]
	public void Demolish()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x3768D84", Offset = "0x3768D84", VA = "0x3768D84")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x377376C", Offset = "0x377376C", VA = "0x377376C")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x37738DC", Offset = "0x37738DC", VA = "0x37738DC")]
	public void Prefragment()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x3773C78", Offset = "0x3773C78", VA = "0x3773C78")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x3773B5C", Offset = "0x3773B5C", VA = "0x3773B5C")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x3773D20", Offset = "0x3773D20", VA = "0x3773D20")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x3773DBC", Offset = "0x3773DBC", VA = "0x3773DBC")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x377405C", Offset = "0x377405C", VA = "0x377405C")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x377409C", Offset = "0x377409C", VA = "0x377409C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x11B6E54", Offset = "0x11B6E54")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x376DF2C", Offset = "0x376DF2C", VA = "0x376DF2C")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x376DCA0", Offset = "0x376DCA0", VA = "0x376DCA0")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x3768FC4", Offset = "0x3768FC4", VA = "0x3768FC4")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x37742C0", Offset = "0x37742C0", VA = "0x37742C0")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x37742C8", Offset = "0x37742C8", VA = "0x37742C8")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x377432C", Offset = "0x377432C", VA = "0x377432C")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x3774390", Offset = "0x3774390", VA = "0x3774390")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x37743F4", Offset = "0x37743F4", VA = "0x37743F4")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x37745E4", Offset = "0x37745E4", VA = "0x37745E4")]
	public RayfireRigid()
	{
	}
}
[Serializable]
[Token(Token = "0x20000B9")]
public class RFRigidRootDemolition
{
	[Token(Token = "0x40004E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B52AC", Offset = "0x11B52AC")]
	public RFLimitations limitations;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0x11B52C0", Offset = "0x11B52C0")]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x3026A14", Offset = "0x3026A14", VA = "0x3026A14")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x20000BA")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3314", Offset = "0x11B3314")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3314", Offset = "0x11B3314")]
public class RayfireRigidRoot : MonoBehaviour
{
	[Token(Token = "0x20000BB")]
	public enum InitType
	{
		[Token(Token = "0x4000504")]
		ByMethod,
		[Token(Token = "0x4000505")]
		AtStart
	}

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public InitType initialization;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public SimType simulationType;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFPhysic physics;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFActivation activation;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFRigidRootDemolition demolition;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFFade fading;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFReset reset;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform tm;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RayfireSound sound;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFCluster cluster;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<RayfireRigid> meshRoots;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool initialized;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool cached;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float sizeBox;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float sizeSum;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<Collider> collidersList;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<RFShard> meshRootShards;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<RFShard> rigidRootShards;

	[NonSerialized]
	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<RFCluster> clusters;

	[NonSerialized]
	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<RFShard> inactiveShards;

	[NonSerialized]
	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<RFShard> offsetFadeShards;

	[NonSerialized]
	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFShard> destroyShards;

	[NonSerialized]
	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFShard> meshRigidShards;

	[NonSerialized]
	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<Transform> parentList;

	[NonSerialized]
	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<RayfireDebris> debrisList;

	[NonSerialized]
	[Token(Token = "0x40004FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public List<RayfireDust> dustList;

	[NonSerialized]
	[Token(Token = "0x40004FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RayfireUnyielding> unyList;

	[NonSerialized]
	[Token(Token = "0x40004FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<Transform> particleList;

	[NonSerialized]
	[Token(Token = "0x40004FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool corState;

	[NonSerialized]
	[Token(Token = "0x4000500")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public HashSet<Collider> collidersHash;

	[Token(Token = "0x4000501")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public RFActivationEvent activationEvent;

	[Token(Token = "0x4000502")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string strRoot;

	[Token(Token = "0x1700006D")]
	public bool HasClusters
	{
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x37779EC", Offset = "0x37779EC", VA = "0x37779EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x3777A44", Offset = "0x3777A44", VA = "0x3777A44")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x3777A9C", Offset = "0x3777A9C", VA = "0x3777A9C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasUny
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x3777914", Offset = "0x3777914", VA = "0x3777914")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x37748F4", Offset = "0x37748F4", VA = "0x37748F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x37749A4", Offset = "0x37749A4", VA = "0x37749A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x37749D4", Offset = "0x37749D4", VA = "0x37749D4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x3774930", Offset = "0x3774930", VA = "0x3774930")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x3774ED0", Offset = "0x3774ED0", VA = "0x3774ED0")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x3775124", Offset = "0x3775124", VA = "0x3775124")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x377512C", Offset = "0x377512C", VA = "0x377512C")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x37752E0", Offset = "0x37752E0", VA = "0x37752E0")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x3774B34", Offset = "0x3774B34", VA = "0x3774B34")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x37757E0", Offset = "0x37757E0", VA = "0x37757E0")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x377670C", Offset = "0x377670C", VA = "0x377670C")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x3775888", Offset = "0x3775888", VA = "0x3775888")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x3776C8C", Offset = "0x3776C8C", VA = "0x3776C8C")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x3776F28", Offset = "0x3776F28", VA = "0x3776F28")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x3777120", Offset = "0x3777120", VA = "0x3777120")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x3777254", Offset = "0x3777254", VA = "0x3777254")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x3777368", Offset = "0x3777368", VA = "0x3777368")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x37761EC", Offset = "0x37761EC", VA = "0x37761EC")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x37767F8", Offset = "0x37767F8", VA = "0x37767F8")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x3776A1C", Offset = "0x3776A1C", VA = "0x3776A1C")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x3776430", Offset = "0x3776430", VA = "0x3776430")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x3774A2C", Offset = "0x3774A2C", VA = "0x3774A2C")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x3768CB4", Offset = "0x3768CB4", VA = "0x3768CB4")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x377796C", Offset = "0x377796C", VA = "0x377796C")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x3777420", Offset = "0x3777420", VA = "0x3777420")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x3777AF4", Offset = "0x3777AF4", VA = "0x3777AF4")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x3777B00", Offset = "0x3777B00", VA = "0x3777B00")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x20000BC")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3394", Offset = "0x11B3394")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3394", Offset = "0x11B3394")]
public class RayfireShatter : MonoBehaviour
{
	[Token(Token = "0x20000BD")]
	public enum FragLastMode
	{
		[Token(Token = "0x4000530")]
		New,
		[Token(Token = "0x4000531")]
		ToLast
	}

	[Token(Token = "0x4000506")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FragType type;

	[Token(Token = "0x4000507")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFVoronoi voronoi;

	[Token(Token = "0x4000508")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSplinters splinters;

	[Token(Token = "0x4000509")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSplinters slabs;

	[Token(Token = "0x400050A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RFRadial radial;

	[Token(Token = "0x400050B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RFCustom custom;

	[Token(Token = "0x400050C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RFMirrored mirrored;

	[Token(Token = "0x400050D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public RFSlice slice;

	[Token(Token = "0x400050E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public RFBricks bricks;

	[Token(Token = "0x400050F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public RFVoxels voxels;

	[Token(Token = "0x4000510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public RFTets tets;

	[Token(Token = "0x4000511")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public FragmentMode mode;

	[Token(Token = "0x4000512")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public RFSurface material;

	[Token(Token = "0x4000513")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public RFShatterCluster clusters;

	[Token(Token = "0x4000514")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RFShatterAdvanced advanced;

	[Token(Token = "0x4000515")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public RFMeshExport export;

	[Token(Token = "0x4000516")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool showCenter;

	[Token(Token = "0x4000517")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public Vector3 centerPosition;

	[Token(Token = "0x4000518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Quaternion centerDirection;

	[Token(Token = "0x4000519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform transForm;

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshFilter meshFilter;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public SkinnedMeshRenderer skinnedMeshRend;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<MeshFilter> meshFilters;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Mesh[] meshes;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Vector3[] pivots;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<Transform> rootChildList;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public List<GameObject> fragmentsAll;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public List<GameObject> fragmentsLast;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public List<RFDictionary> origSubMeshIdsRF;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Material[] materials;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public int shatterMode;

	[Token(Token = "0x4000526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool colorPreview;

	[Token(Token = "0x4000527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11D")]
	public bool scalePreview;

	[Token(Token = "0x4000528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float previewScale;

	[Token(Token = "0x4000529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float size;

	[Token(Token = "0x400052A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float rescaleFix;

	[Token(Token = "0x400052B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public Vector3 originalScale;

	[Token(Token = "0x400052C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x400052D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[HideInInspector]
	public bool resetState;

	[Token(Token = "0x400052E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float minSize;

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x3A29180", Offset = "0x3A29180", VA = "0x3A29180")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x3A292B0", Offset = "0x3A292B0", VA = "0x3A292B0")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x3A29358", Offset = "0x3A29358", VA = "0x3A29358")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x3A297F0", Offset = "0x3A297F0", VA = "0x3A297F0")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x3A29A80", Offset = "0x3A29A80", VA = "0x3A29A80")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x3A29DA0", Offset = "0x3A29DA0", VA = "0x3A29DA0")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x3A29F5C", Offset = "0x3A29F5C", VA = "0x3A29F5C")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x3A2A3DC", Offset = "0x3A2A3DC", VA = "0x3A2A3DC")]
	private List<GameObject> CreateFragments([Optional] GameObject lastRoot)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x3A2AF44", Offset = "0x3A2AF44", VA = "0x3A2AF44")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x3A2B344", Offset = "0x3A2B344", VA = "0x3A2B344")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x3A29184", Offset = "0x3A29184", VA = "0x3A29184")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x3A2A15C", Offset = "0x3A2A15C", VA = "0x3A2A15C")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x3A2B4D4", Offset = "0x3A2B4D4", VA = "0x3A2B4D4")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x3A2B73C", Offset = "0x3A2B73C", VA = "0x3A2B73C")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x3A2B8DC", Offset = "0x3A2B8DC", VA = "0x3A2B8DC")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x3A2AD1C", Offset = "0x3A2AD1C", VA = "0x3A2AD1C")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x3A2BB74", Offset = "0x3A2BB74", VA = "0x3A2BB74")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x20000BE")]
[SelectionBase]
[DisallowMultipleComponent]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B33F4", Offset = "0x11B33F4")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B33F4", Offset = "0x11B33F4")]
public class RayfireSnapshot : MonoBehaviour
{
	[Token(Token = "0x4000532")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string assetName;

	[Token(Token = "0x4000533")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool compress;

	[Token(Token = "0x4000534")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEngine.Object snapshotAsset;

	[Token(Token = "0x4000535")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float sizeFilter;

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x3A2C02C", Offset = "0x3A2C02C", VA = "0x3A2C02C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x3A2C06C", Offset = "0x3A2C06C", VA = "0x3A2C06C")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x20000BF")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3474", Offset = "0x11B3474")]
[SelectionBase]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3474", Offset = "0x11B3474")]
public class RayfireSound : MonoBehaviour
{
	[Token(Token = "0x4000536")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float baseVolume;

	[Token(Token = "0x4000537")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float sizeVolume;

	[Token(Token = "0x4000538")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RFSound initialization;

	[Token(Token = "0x4000539")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFSound activation;

	[Token(Token = "0x400053A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RFSound demolition;

	[Token(Token = "0x400053B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float minimumSize;

	[Token(Token = "0x400053C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float cameraDistance;

	[Token(Token = "0x400053D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RayfireRigid rigid;

	[Token(Token = "0x400053E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RayfireRigidRoot rigidRoot;

	[Token(Token = "0x600047A")]
	[Address(RVA = "0x3A2C074", Offset = "0x3A2C074", VA = "0x3A2C074")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x3A2C0A8", Offset = "0x3A2C0A8", VA = "0x3A2C0A8")]
	private void Start()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x3A2C0AC", Offset = "0x3A2C0AC", VA = "0x3A2C0AC")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x3A2C1F4", Offset = "0x3A2C1F4", VA = "0x3A2C1F4")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x3A2C69C", Offset = "0x3A2C69C", VA = "0x3A2C69C")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x3A2C7A0", Offset = "0x3A2C7A0", VA = "0x3A2C7A0")]
	private void CreateSource(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x20000C0")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B34E4", Offset = "0x11B34E4")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B34E4", Offset = "0x11B34E4")]
public class RayfireUnyielding : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	public enum UnySimType
	{
		[Token(Token = "0x400054A")]
		Original = 1,
		[Token(Token = "0x400054B")]
		Inactive,
		[Token(Token = "0x400054C")]
		Kinematic
	}

	[Token(Token = "0x400053F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool unyielding;

	[Token(Token = "0x4000540")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool activatable;

	[Token(Token = "0x4000541")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public UnySimType simulationType;

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 centerPosition;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 size;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RayfireRigid rigidHost;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RayfireRigid> rigidList;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<RFShard> shardList;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool showGizmo;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool showCenter;

	[Token(Token = "0x17000071")]
	private bool HasRigids
	{
		[Token(Token = "0x6000491")]
		[Address(RVA = "0x3A2EE04", Offset = "0x3A2EE04", VA = "0x3A2EE04")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	private bool HasShards
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x3A2EE5C", Offset = "0x3A2EE5C", VA = "0x3A2EE5C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public Vector3 Extents
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x3A2CFDC", Offset = "0x3A2CFDC", VA = "0x3A2CFDC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x3A2CA00", Offset = "0x3A2CA00", VA = "0x3A2CA00")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x3A2CAF8", Offset = "0x3A2CAF8", VA = "0x3A2CAF8")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x3A2CE64", Offset = "0x3A2CE64", VA = "0x3A2CE64")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x3A2D08C", Offset = "0x3A2D08C", VA = "0x3A2D08C")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x3A2D0B0", Offset = "0x3A2D0B0", VA = "0x3A2D0B0")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x3A2D174", Offset = "0x3A2D174", VA = "0x3A2D174")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x3A2D288", Offset = "0x3A2D288", VA = "0x3A2D288")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x3A2D69C", Offset = "0x3A2D69C", VA = "0x3A2D69C")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x3A2D588", Offset = "0x3A2D588", VA = "0x3A2D588")]
	public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x3A2D7EC", Offset = "0x3A2D7EC", VA = "0x3A2D7EC")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x3A2DA68", Offset = "0x3A2DA68", VA = "0x3A2DA68")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x3A2DC48", Offset = "0x3A2DC48", VA = "0x3A2DC48")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x3A2E34C", Offset = "0x3A2E34C", VA = "0x3A2E34C")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x3A2E3D8", Offset = "0x3A2E3D8", VA = "0x3A2E3D8")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x3A2E550", Offset = "0x3A2E550", VA = "0x3A2E550")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x3A2E930", Offset = "0x3A2E930", VA = "0x3A2E930")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x3A2EA58", Offset = "0x3A2EA58", VA = "0x3A2EA58")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x3A2EEB4", Offset = "0x3A2EEB4", VA = "0x3A2EEB4")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x20000C2")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B3544", Offset = "0x11B3544")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B3544", Offset = "0x11B3544")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B35A4", Offset = "0x11B35A4")]
	private sealed class <VortexForceCor>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x3A38F04", Offset = "0x3A38F04", VA = "0x3A38F04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x3A38F4C", Offset = "0x3A38F4C", VA = "0x3A38F4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x3A2EFE4", Offset = "0x3A2EFE4", VA = "0x3A2EFE4")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x3A38DD8", Offset = "0x3A38DD8", VA = "0x3A38DD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x3A38DDC", Offset = "0x3A38DDC", VA = "0x3A38DDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x3A38F0C", Offset = "0x3A38F0C", VA = "0x3A38F0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B35B4", Offset = "0x11B35B4")]
	private sealed class <SetCollidersCor>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireVortex <>4__this;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x3A38D88", Offset = "0x3A38D88", VA = "0x3A38D88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x3A38DD0", Offset = "0x3A38DD0", VA = "0x3A38DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x3A2F088", Offset = "0x3A2F088", VA = "0x3A2F088")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x3A38C48", Offset = "0x3A38C48", VA = "0x3A38C48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x3A38C4C", Offset = "0x3A38C4C", VA = "0x3A38C4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x3A38D90", Offset = "0x3A38D90", VA = "0x3A38D90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public Transform transForm;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Collider[] colliders;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 bot;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 top;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 normal;

	[Token(Token = "0x4000553")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 direction;

	[Token(Token = "0x4000554")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 rbPos;

	[Token(Token = "0x4000555")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 linePoint;

	[Token(Token = "0x4000556")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 vectorUp;

	[Token(Token = "0x4000557")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 centerOutVector;

	[Token(Token = "0x4000558")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 vectorCenter;

	[Token(Token = "0x4000559")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private Vector3 perpend;

	[Token(Token = "0x400055A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Vector3 vectorSwirl;

	[Token(Token = "0x400055B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private Vector3 forceVector;

	[Token(Token = "0x400055C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float distancePerpend;

	[Token(Token = "0x400055D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float distanceBottom;

	[Token(Token = "0x400055E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float upRateNow;

	[Token(Token = "0x400055F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private float localRadius;

	[Token(Token = "0x4000560")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private float upRateOwn;

	[Token(Token = "0x4000561")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float centerRateOwn;

	[Token(Token = "0x4000562")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float centerRateNow;

	[Token(Token = "0x4000563")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float upRateDif;

	[Token(Token = "0x4000564")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float centerRateDif;

	[Token(Token = "0x4000565")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float maxRadius;

	[Token(Token = "0x4000566")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float axisDistance;

	[Token(Token = "0x4000567")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Plane bottomPlane;

	[Token(Token = "0x4000568")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float torqueVal;

	[Token(Token = "0x4000569")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool topHandle;

	[Token(Token = "0x400056A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public Vector3 topAnchor;

	[Token(Token = "0x400056B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Vector3 bottomAnchor;

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
	public bool showGizmo;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public float topRadius;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	public float bottomRadius;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public float eye;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public bool forceByMass;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public float stiffness;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	public float swirlStrength;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public bool enableTorque;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	public float torqueStrength;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public float torqueVariation;

	[Token(Token = "0x4000576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	public bool enableHeightBias;

	[Token(Token = "0x4000577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public float biasSpeed;

	[Token(Token = "0x4000578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	public float biasSpread;

	[Token(Token = "0x4000579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public int seed;

	[Token(Token = "0x400057A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public int circles;

	[Token(Token = "0x400057B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public int mask;

	[Token(Token = "0x400057C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public string tagFilter;

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x3A2EEDC", Offset = "0x3A2EEDC", VA = "0x3A2EEDC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x3A2EEE0", Offset = "0x3A2EEE0", VA = "0x3A2EEE0")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x3A2EF6C", Offset = "0x3A2EF6C", VA = "0x3A2EF6C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6E8C", Offset = "0x11B6E8C")]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x3A2F010", Offset = "0x3A2F010", VA = "0x3A2F010")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6EEC", Offset = "0x11B6EEC")]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x3A2F0B4", Offset = "0x3A2F0B4", VA = "0x3A2F0B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x3A2F0F8", Offset = "0x3A2F0F8", VA = "0x3A2F0F8")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x3A2F228", Offset = "0x3A2F228", VA = "0x3A2F228")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x3A2F32C", Offset = "0x3A2F32C", VA = "0x3A2F32C")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x3A2F51C", Offset = "0x3A2F51C", VA = "0x3A2F51C")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x3A2FA38", Offset = "0x3A2FA38", VA = "0x3A2FA38")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x3A2FB68", Offset = "0x3A2FB68", VA = "0x3A2FB68")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x3A2FBBC", Offset = "0x3A2FBBC", VA = "0x3A2FBBC")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x3A2FCBC", Offset = "0x3A2FCBC", VA = "0x3A2FCBC")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x3A2FA8C", Offset = "0x3A2FA8C", VA = "0x3A2FA8C")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x3A2FCEC", Offset = "0x3A2FCEC", VA = "0x3A2FCEC")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x20000C5")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x11B35C4", Offset = "0x11B35C4")]
[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x11B35C4", Offset = "0x11B35C4")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000C6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x11B3624", Offset = "0x11B3624")]
	private sealed class <WindForceCor>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireWind <>4__this;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C6")]
			[Address(RVA = "0x3A39020", Offset = "0x3A39020", VA = "0x3A39020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0x3A39068", Offset = "0x3A39068", VA = "0x3A39068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x3A2FF14", Offset = "0x3A2FF14", VA = "0x3A2FF14")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x3A38F54", Offset = "0x3A38F54", VA = "0x3A38F54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x3A38F58", Offset = "0x3A38F58", VA = "0x3A38F58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x3A39028", Offset = "0x3A39028", VA = "0x3A39028", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000583")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 gizmoSize;

	[Token(Token = "0x4000584")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool showGizmo;

	[Token(Token = "0x4000585")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float globalScale;

	[Token(Token = "0x4000586")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float lengthScale;

	[Token(Token = "0x4000587")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float widthScale;

	[Token(Token = "0x4000588")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float speed;

	[Token(Token = "0x4000589")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool showNoise;

	[Token(Token = "0x400058A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float minimum;

	[Token(Token = "0x400058B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float maximum;

	[Token(Token = "0x400058C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float torque;

	[Token(Token = "0x400058D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool forceByMass;

	[Token(Token = "0x400058E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float divergency;

	[Token(Token = "0x400058F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float turbulence;

	[Token(Token = "0x4000590")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float previewDensity;

	[Token(Token = "0x4000591")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float previewSize;

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int mask;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string tagFilter;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform transForm;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Collider[] colliders;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 halfExtents;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Vector3 center;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float offset;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x3A2FE0C", Offset = "0x3A2FE0C", VA = "0x3A2FE0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x3A2FE10", Offset = "0x3A2FE10", VA = "0x3A2FE10")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x3A2FE9C", Offset = "0x3A2FE9C", VA = "0x3A2FE9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x11B6FEC", Offset = "0x11B6FEC")]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x3A2FF40", Offset = "0x3A2FF40", VA = "0x3A2FF40")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x3A2FF6C", Offset = "0x3A2FF6C", VA = "0x3A2FF6C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x3A2FF78", Offset = "0x3A2FF78", VA = "0x3A2FF78")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x3A3015C", Offset = "0x3A3015C", VA = "0x3A3015C")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x3A301BC", Offset = "0x3A301BC", VA = "0x3A301BC")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x3A303AC", Offset = "0x3A303AC", VA = "0x3A303AC")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x3A306C0", Offset = "0x3A306C0", VA = "0x3A306C0")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x3A30720", Offset = "0x3A30720", VA = "0x3A30720")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x3A30864", Offset = "0x3A30864", VA = "0x3A30864")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x3A30674", Offset = "0x3A30674", VA = "0x3A30674")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x3A30964", Offset = "0x3A30964", VA = "0x3A30964")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x3A309A8", Offset = "0x3A309A8", VA = "0x3A309A8")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x3A30830", Offset = "0x3A30830", VA = "0x3A30830")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x3A306A8", Offset = "0x3A306A8", VA = "0x3A306A8")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x3A3062C", Offset = "0x3A3062C", VA = "0x3A3062C")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x3A30A28", Offset = "0x3A30A28", VA = "0x3A30A28")]
	public RayfireWind()
	{
	}
}
