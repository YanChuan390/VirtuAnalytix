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
	[Address(RVA = "0x2CAF070", Offset = "0x2CAF070", VA = "0x2CAF070")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x2CAF0B0", Offset = "0x2CAF0B0", VA = "0x2CAF0B0")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x2CAF470", Offset = "0x2CAF470", VA = "0x2CAF470")]
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
	[Address(RVA = "0x2CAF4E8", Offset = "0x2CAF4E8", VA = "0x2CAF4E8")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x2CAF54C", Offset = "0x2CAF54C", VA = "0x2CAF54C")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x2CAFA1C", Offset = "0x2CAFA1C", VA = "0x2CAFA1C")]
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
	[Address(RVA = "0x2CAFA94", Offset = "0x2CAFA94", VA = "0x2CAFA94")]
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
		[Address(RVA = "0x2CAFB40", Offset = "0x2CAFB40", VA = "0x2CAFB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x2CAFAB4", Offset = "0x2CAFAB4", VA = "0x2CAFAB4")]
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
	[Address(RVA = "0x2CAFBF0", Offset = "0x2CAFBF0", VA = "0x2CAFBF0")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2CB01A0", Offset = "0x2CB01A0", VA = "0x2CB01A0")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2CB050C", Offset = "0x2CB050C", VA = "0x2CB050C")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x2CB05BC", Offset = "0x2CB05BC", VA = "0x2CB05BC")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2CB066C", Offset = "0x2CB066C", VA = "0x2CB066C")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x2CB0720", Offset = "0x2CB0720", VA = "0x2CB0720")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2CB07D0", Offset = "0x2CB07D0", VA = "0x2CB07D0")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x2CB0888", Offset = "0x2CB0888", VA = "0x2CB0888")]
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
			[Address(RVA = "0x2CB1278", Offset = "0x2CB1278", VA = "0x2CB1278", Slot = "4")]
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
			[Address(RVA = "0x2CB12C0", Offset = "0x2CB12C0", VA = "0x2CB12C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2CB108C", Offset = "0x2CB108C", VA = "0x2CB108C")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2CB10B4", Offset = "0x2CB10B4", VA = "0x2CB10B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2CB10B8", Offset = "0x2CB10B8", VA = "0x2CB10B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2CB1280", Offset = "0x2CB1280", VA = "0x2CB1280", Slot = "8")]
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
	[Range(1f, 500f)]
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
	[Address(RVA = "0x2CB0B00", Offset = "0x2CB0B00", VA = "0x2CB0B00")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x2CB0B9C", Offset = "0x2CB0B9C", VA = "0x2CB0B9C")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2CB0CB8", Offset = "0x2CB0CB8", VA = "0x2CB0CB8")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2CB0DD8", Offset = "0x2CB0DD8", VA = "0x2CB0DD8")]
	public static ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x2CB0E8C", Offset = "0x2CB0E8C", VA = "0x2CB0E8C")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x2CB0F48", Offset = "0x2CB0F48", VA = "0x2CB0F48")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x2CB0FFC", Offset = "0x2CB0FFC", VA = "0x2CB0FFC")]
	[IteratorStateMachine(typeof(<StartPoolingCor>d__13))]
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
			[Address(RVA = "0x2CB1B64", Offset = "0x2CB1B64", VA = "0x2CB1B64", Slot = "4")]
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
			[Address(RVA = "0x2CB1BAC", Offset = "0x2CB1BAC", VA = "0x2CB1BAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2CB197C", Offset = "0x2CB197C", VA = "0x2CB197C")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2CB19A4", Offset = "0x2CB19A4", VA = "0x2CB19A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2CB19A8", Offset = "0x2CB19A8", VA = "0x2CB19A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2CB1B6C", Offset = "0x2CB1B6C", VA = "0x2CB1B6C", Slot = "8")]
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
	[Range(1f, 500f)]
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
	[Address(RVA = "0x2CB12C8", Offset = "0x2CB12C8", VA = "0x2CB12C8")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x2CB1364", Offset = "0x2CB1364", VA = "0x2CB1364")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x2CB1480", Offset = "0x2CB1480", VA = "0x2CB1480")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x2CB158C", Offset = "0x2CB158C", VA = "0x2CB158C")]
	public static RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x2CB177C", Offset = "0x2CB177C", VA = "0x2CB177C")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x2CB1838", Offset = "0x2CB1838", VA = "0x2CB1838")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x2CB18EC", Offset = "0x2CB18EC", VA = "0x2CB18EC")]
	[IteratorStateMachine(typeof(<StartPoolingCor>d__13))]
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
			[Address(RVA = "0x2CB2254", Offset = "0x2CB2254", VA = "0x2CB2254", Slot = "4")]
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
			[Address(RVA = "0x2CB229C", Offset = "0x2CB229C", VA = "0x2CB229C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2CB1DF0", Offset = "0x2CB1DF0", VA = "0x2CB1DF0")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2CB2030", Offset = "0x2CB2030", VA = "0x2CB2030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2CB2034", Offset = "0x2CB2034", VA = "0x2CB2034", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2CB225C", Offset = "0x2CB225C", VA = "0x2CB225C", Slot = "8")]
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
	[Address(RVA = "0x2CB1BB4", Offset = "0x2CB1BB4", VA = "0x2CB1BB4")]
	public RFStorage()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x2CB1C44", Offset = "0x2CB1C44", VA = "0x2CB1C44")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x2CB1D7C", Offset = "0x2CB1D7C", VA = "0x2CB1D7C")]
	[IteratorStateMachine(typeof(<StorageCor>d__6))]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x2CB1E18", Offset = "0x2CB1E18", VA = "0x2CB1E18")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x2CB1EEC", Offset = "0x2CB1EEC", VA = "0x2CB1EEC")]
	public void DestroyAll()
	{
	}
}
[Token(Token = "0x200000E")]
public class RFFrag
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Mesh mesh;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 pivot;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public RFDictionary subId;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public RayfireRigid fragment;

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x2CB22A4", Offset = "0x2CB22A4", VA = "0x2CB22A4")]
	public RFFrag()
	{
	}
}
[Token(Token = "0x200000F")]
public class RFTri
{
	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int meshId;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshId;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> ids;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Vector3> vpos;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<Vector3> vnormal;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector2> uvs;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector4> tangents;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<RFTri> neibTris;

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x2CB22AC", Offset = "0x2CB22AC", VA = "0x2CB22AC")]
	public RFTri()
	{
	}
}
[Serializable]
[Token(Token = "0x2000010")]
public class RFDictionary
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public List<int> keys;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<int> values;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x2CB24AC", Offset = "0x2CB24AC", VA = "0x2CB24AC")]
	public RFDictionary(Dictionary<int, int> dictionary)
	{
	}
}
[Serializable]
[Token(Token = "0x2000011")]
public class RFShatterCluster
{
	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int count;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int seed;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float relax;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int layers;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float scale;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int min;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int max;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x2CB25FC", Offset = "0x2CB25FC", VA = "0x2CB25FC")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x2CB2644", Offset = "0x2CB2644", VA = "0x2CB2644")]
	public RFShatterCluster(RFShatterCluster src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000012")]
public class RFVoronoi
{
	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int amount;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float centerBias;

	[Token(Token = "0x17000008")]
	public int Amount
	{
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2CB26F4", Offset = "0x2CB26F4", VA = "0x2CB26F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x2CB26A0", Offset = "0x2CB26A0", VA = "0x2CB26A0")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x2CB26C0", Offset = "0x2CB26C0", VA = "0x2CB26C0")]
	public RFVoronoi(RFVoronoi src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000013")]
public class RFSplinters
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType axis;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int amount;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float strength;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float centerBias;

	[Token(Token = "0x17000009")]
	public int Amount
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2CB277C", Offset = "0x2CB277C", VA = "0x2CB277C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2CB271C", Offset = "0x2CB271C", VA = "0x2CB271C")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x2CB2748", Offset = "0x2CB2748", VA = "0x2CB2748")]
	public RFSplinters(RFSplinters src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000014")]
public class RFRadial
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public AxisType centerAxis;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float radius;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float divergence;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool restrictToPlane;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int rings;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int focus;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int focusStr;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int randomRings;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int rays;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int randomRays;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int twist;

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x2CB27A4", Offset = "0x2CB27A4", VA = "0x2CB27A4")]
	public RFRadial()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x2CB27E8", Offset = "0x2CB27E8", VA = "0x2CB27E8")]
	public RFRadial(RFRadial src)
	{
	}
}
[Serializable]
[Token(Token = "0x2000015")]
public class RFSlice
{
	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public PlaneType plane;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Transform> sliceList;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x2CB284C", Offset = "0x2CB284C", VA = "0x2CB284C")]
	public RFSlice()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x2CB286C", Offset = "0x2CB286C", VA = "0x2CB286C")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x2CB28AC", Offset = "0x2CB28AC", VA = "0x2CB28AC")]
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
		[Token(Token = "0x4000087")]
		ByAmount,
		[Token(Token = "0x4000088")]
		BySize
	}

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public RFBrickType amountType;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float mult;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int amount_X;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int amount_Y;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int amount_Z;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool size_Lock;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float size_X;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float size_Y;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float size_Z;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int sizeVar_X;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public int sizeVar_Y;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public int sizeVar_Z;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float offset_X;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float offset_Y;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public float offset_Z;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool split_X;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	public bool split_Y;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
	public bool split_Z;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int split_probability;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float split_offset;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int split_rotation;

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x2CB28F8", Offset = "0x2CB28F8", VA = "0x2CB28F8")]
	public RFBricks()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class RFVoxels
{
	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0.01f, 10f)]
	public float size;

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x2CB294C", Offset = "0x2CB294C", VA = "0x2CB294C")]
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
		[Token(Token = "0x400008E")]
		Uniform,
		[Token(Token = "0x400008F")]
		Curved
	}

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public TetType lattice;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int density;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int noise;

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x2CB296C", Offset = "0x2CB296C", VA = "0x2CB296C")]
	public RFTets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2CB2998", Offset = "0x2CB2998", VA = "0x2CB2998")]
	public RFTets(RFTets src)
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class RFCluster : IComparable<RFCluster>
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform tm;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public int depth;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public Vector3 pos;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Quaternion rot;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Vector3 scl;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[HideInInspector]
	public Bounds bound;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public bool demolishable;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public RayfireRigid rigid;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public List<RFShard> shards;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float areaCollapse;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float minimumArea;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float maximumArea;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float sizeCollapse;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float minimumSize;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public float maximumSize;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public int randomCollapse;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[HideInInspector]
	public int randomSeed;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[HideInInspector]
	public bool cachedHost;

	[NonSerialized]
	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	public bool initialized;

	[NonSerialized]
	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public RFCluster mainCluster;

	[NonSerialized]
	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<RFCluster> childClusters;

	[NonSerialized]
	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public List<RFCluster> neibClusters;

	[NonSerialized]
	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public List<float> neibArea;

	[NonSerialized]
	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public List<float> neibPerc;

	[NonSerialized]
	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<RFShard> newClusterShards;

	[Token(Token = "0x1700000A")]
	public bool HasChildClusters
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2CB32DC", Offset = "0x2CB32DC", VA = "0x2CB32DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2CB60CC", Offset = "0x2CB60CC", VA = "0x2CB60CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2CB6164", Offset = "0x2CB6164", VA = "0x2CB6164")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2CB29D4", Offset = "0x2CB29D4", VA = "0x2CB29D4")]
	public RFCluster()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2CB2B24", Offset = "0x2CB2B24", VA = "0x2CB2B24")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x2CB3330", Offset = "0x2CB3330", VA = "0x2CB3330", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x2CB3430", Offset = "0x2CB3430", VA = "0x2CB3430")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x2CB3484", Offset = "0x2CB3484", VA = "0x2CB3484")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x2CB36D8", Offset = "0x2CB36D8", VA = "0x2CB36D8")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x2CB38D8", Offset = "0x2CB38D8", VA = "0x2CB38D8")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x2CB42C8", Offset = "0x2CB42C8", VA = "0x2CB42C8")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x2CB3FCC", Offset = "0x2CB3FCC", VA = "0x2CB3FCC")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x2CB48DC", Offset = "0x2CB48DC", VA = "0x2CB48DC")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x2CB4188", Offset = "0x2CB4188", VA = "0x2CB4188")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x2CB4ACC", Offset = "0x2CB4ACC", VA = "0x2CB4ACC")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x2CB51F4", Offset = "0x2CB51F4", VA = "0x2CB51F4")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x2CB4CCC", Offset = "0x2CB4CCC", VA = "0x2CB4CCC")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x2CB5488", Offset = "0x2CB5488", VA = "0x2CB5488")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x2CB5888", Offset = "0x2CB5888", VA = "0x2CB5888")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x2CB49E4", Offset = "0x2CB49E4", VA = "0x2CB49E4")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x2CB5D34", Offset = "0x2CB5D34", VA = "0x2CB5D34")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x2CB4830", Offset = "0x2CB4830", VA = "0x2CB4830")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x2CB5EB4", Offset = "0x2CB5EB4", VA = "0x2CB5EB4")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x2CB5F9C", Offset = "0x2CB5F9C", VA = "0x2CB5F9C")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x2CB620C", Offset = "0x2CB620C", VA = "0x2CB620C")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x2CB63C4", Offset = "0x2CB63C4", VA = "0x2CB63C4")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x2CB650C", Offset = "0x2CB650C", VA = "0x2CB650C")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x2CB6854", Offset = "0x2CB6854", VA = "0x2CB6854")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x2CB6C1C", Offset = "0x2CB6C1C", VA = "0x2CB6C1C")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x2CB6D40", Offset = "0x2CB6D40", VA = "0x2CB6D40")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x2CB7780", Offset = "0x2CB7780", VA = "0x2CB7780")]
	public static RFCluster GetNeibClusterArea(List<RFCluster> clusters, List<RFCluster> clusterList)
	{
		return null;
	}
}
[Token(Token = "0x200001C")]
public class RFEvent
{
	[Token(Token = "0x200001D")]
	public delegate void EventAction(RayfireRigid rigid);

	[Token(Token = "0x200001E")]
	public delegate void EventActionRoot(RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x2CB7B60", Offset = "0x2CB7B60", VA = "0x2CB7B60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x2CB7BFC", Offset = "0x2CB7BFC", VA = "0x2CB7BFC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x2CB7C98", Offset = "0x2CB7C98", VA = "0x2CB7C98")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x2CB7D34", Offset = "0x2CB7D34", VA = "0x2CB7D34")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2CB7DD0", Offset = "0x2CB7DD0", VA = "0x2CB7DD0")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2CB7DEC", Offset = "0x2CB7DEC", VA = "0x2CB7DEC")]
	public void InvokeLocalEventRoot(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2CB7E08", Offset = "0x2CB7E08", VA = "0x2CB7E08")]
	public RFEvent()
	{
	}
}
[Token(Token = "0x200001F")]
public class RFDemolitionEvent : RFEvent
{
	[Token(Token = "0x14000003")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2CB8108", Offset = "0x2CB8108", VA = "0x2CB8108")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600007A")]
		[Address(RVA = "0x2CB81C0", Offset = "0x2CB81C0", VA = "0x2CB81C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x2CB8278", Offset = "0x2CB8278", VA = "0x2CB8278")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x2CB82E4", Offset = "0x2CB82E4", VA = "0x2CB82E4")]
	public RFDemolitionEvent()
	{
	}
}
[Token(Token = "0x2000020")]
public class RFActivationEvent : RFEvent
{
	[Token(Token = "0x14000004")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2CB82EC", Offset = "0x2CB82EC", VA = "0x2CB82EC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2CB83A4", Offset = "0x2CB83A4", VA = "0x2CB83A4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2CB845C", Offset = "0x2CB845C", VA = "0x2CB845C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x2CB8518", Offset = "0x2CB8518", VA = "0x2CB8518")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x2CB85D4", Offset = "0x2CB85D4", VA = "0x2CB85D4")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2CB8640", Offset = "0x2CB8640", VA = "0x2CB8640")]
	public static void InvokeGlobalEventRoot(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2CB86AC", Offset = "0x2CB86AC", VA = "0x2CB86AC")]
	public RFActivationEvent()
	{
	}
}
[Token(Token = "0x2000021")]
public class RFRestrictionEvent : RFEvent
{
	[Token(Token = "0x14000006")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x2CB86B4", Offset = "0x2CB86B4", VA = "0x2CB86B4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x2CB876C", Offset = "0x2CB876C", VA = "0x2CB876C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2CB8824", Offset = "0x2CB8824", VA = "0x2CB8824")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2CB8890", Offset = "0x2CB8890", VA = "0x2CB8890")]
	public RFRestrictionEvent()
	{
	}
}
[Token(Token = "0x2000022")]
public class RFShotEvent
{
	[Token(Token = "0x2000023")]
	public delegate void EventAction(RayfireGun gun);

	[Token(Token = "0x14000007")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x2CB8898", Offset = "0x2CB8898", VA = "0x2CB8898")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x2CB8950", Offset = "0x2CB8950", VA = "0x2CB8950")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x2CB8A08", Offset = "0x2CB8A08", VA = "0x2CB8A08")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2CB8AA4", Offset = "0x2CB8AA4", VA = "0x2CB8AA4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2CB8B40", Offset = "0x2CB8B40", VA = "0x2CB8B40")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x2CB8BAC", Offset = "0x2CB8BAC", VA = "0x2CB8BAC")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x2CB8BC8", Offset = "0x2CB8BC8", VA = "0x2CB8BC8")]
	public RFShotEvent()
	{
	}
}
[Token(Token = "0x2000024")]
public class RFExplosionEvent
{
	[Token(Token = "0x2000025")]
	public delegate void EventAction(RayfireBomb bomb);

	[Token(Token = "0x14000009")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x2CB8D4C", Offset = "0x2CB8D4C", VA = "0x2CB8D4C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2CB8E04", Offset = "0x2CB8E04", VA = "0x2CB8E04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x2CB8EBC", Offset = "0x2CB8EBC", VA = "0x2CB8EBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x2CB8F58", Offset = "0x2CB8F58", VA = "0x2CB8F58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x2CB8FF4", Offset = "0x2CB8FF4", VA = "0x2CB8FF4")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x2CB9060", Offset = "0x2CB9060", VA = "0x2CB9060")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x2CB907C", Offset = "0x2CB907C", VA = "0x2CB907C")]
	public RFExplosionEvent()
	{
	}
}
[Token(Token = "0x2000026")]
public class RFSliceEvent
{
	[Token(Token = "0x2000027")]
	public delegate void EventAction(RayfireBlade blade);

	[Token(Token = "0x1400000B")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2CB9200", Offset = "0x2CB9200", VA = "0x2CB9200")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2CB92B8", Offset = "0x2CB92B8", VA = "0x2CB92B8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000C")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2CB9370", Offset = "0x2CB9370", VA = "0x2CB9370")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2CB940C", Offset = "0x2CB940C", VA = "0x2CB940C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x2CB94A8", Offset = "0x2CB94A8", VA = "0x2CB94A8")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x2CB9514", Offset = "0x2CB9514", VA = "0x2CB9514")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x2CB9530", Offset = "0x2CB9530", VA = "0x2CB9530")]
	public RFSliceEvent()
	{
	}
}
[Token(Token = "0x2000028")]
public class RFConnectivityEvent
{
	[Token(Token = "0x2000029")]
	public delegate void EventAction(RayfireConnectivity connectivity);

	[Token(Token = "0x1400000D")]
	public static event EventAction GlobalEvent
	{
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2CB96B4", Offset = "0x2CB96B4", VA = "0x2CB96B4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2CB976C", Offset = "0x2CB976C", VA = "0x2CB976C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000E")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2CB9824", Offset = "0x2CB9824", VA = "0x2CB9824")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x2CB98C0", Offset = "0x2CB98C0", VA = "0x2CB98C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x2CB995C", Offset = "0x2CB995C", VA = "0x2CB995C")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity)
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x2CB99C8", Offset = "0x2CB99C8", VA = "0x2CB99C8")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity)
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x2CB99E4", Offset = "0x2CB99E4", VA = "0x2CB99E4")]
	public RFConnectivityEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x200002A")]
public class RFFlash
{
	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(3f)]
	[Range(0.1f, 5f)]
	[Header("  Intensity")]
	public float intensityMin;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(1f)]
	[Range(0.1f, 5f)]
	public float intensityMax;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Range")]
	[Range(0.01f, 10f)]
	[Space(3f)]
	public float rangeMin;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(1f)]
	[Range(0.01f, 10f)]
	public float rangeMax;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Other")]
	[Space(3f)]
	[Range(0.01f, 2f)]
	public float distance;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(1f)]
	public Color color;

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x2CB9B68", Offset = "0x2CB9B68", VA = "0x2CB9B68")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
public class RFDecals
{
	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0.1f, 5f)]
	[Space(2f)]
	[Header("  Size")]
	public float sizeMin;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 5f)]
	[Space(1f)]
	public float sizeMax;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.01f, 2f)]
	[Space(2f)]
	[Header("  Limitations")]
	public float distance;

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x2CB9B9C", Offset = "0x2CB9B9C", VA = "0x2CB9B9C")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x200002C")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x2CBB040", Offset = "0x2CBB040", VA = "0x2CBB040")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2CBA88C", Offset = "0x2CBA88C", VA = "0x2CBA88C")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x2CB9BC8", Offset = "0x2CB9BC8", VA = "0x2CB9BC8")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x2CBA8BC", Offset = "0x2CBA8BC", VA = "0x2CBA8BC")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x2CBA9E0", Offset = "0x2CBA9E0", VA = "0x2CBA9E0")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x2CBAE78", Offset = "0x2CBAE78", VA = "0x2CBAE78")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x2CBAF28", Offset = "0x2CBAF28", VA = "0x2CBAF28")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2CBAC00", Offset = "0x2CBAC00", VA = "0x2CBAC00")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2CBAAA8", Offset = "0x2CBAAA8", VA = "0x2CBAAA8")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x2CBAD1C", Offset = "0x2CBAD1C", VA = "0x2CBAD1C")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200002E")]
public class RFParticleNoise
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(3f)]
	[Header("  Main")]
	public bool enabled;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(3f)]
	[Range(0f, 3f)]
	[Header("  Strength")]
	public float strengthMin;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0f, 3f)]
	public float strengthMax;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0.001f, 3f)]
	[Header("  Other")]
	[Space(3f)]
	public float frequency;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 2f)]
	[Space(2f)]
	public float scrollSpeed;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public bool damping;

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x2CBB0C8", Offset = "0x2CBB0C8", VA = "0x2CBB0C8")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x2CBB100", Offset = "0x2CBB100", VA = "0x2CBB100")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RFParticleRendering
{
	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Shadows")]
	[Space(3f)]
	public bool castShadows;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Space(2f)]
	public bool receiveShadows;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Space(3f)]
	[Header("  Light")]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x2CBB134", Offset = "0x2CBB134", VA = "0x2CBB134")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x2CBB158", Offset = "0x2CBB158", VA = "0x2CBB158")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0f, 10f)]
	[Space(3f)]
	[Header("  Speed")]
	public float speedMin;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(0f, 10f)]
	public float speedMax;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(3f)]
	[Header("  Inherit Velocity")]
	[Range(0f, 3f)]
	public float velocityMin;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 3f)]
	[Space(2f)]
	public float velocityMax;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-2f, 2f)]
	[Space(3f)]
	[Header("  Gravity Modifier")]
	public float gravityMin;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(2f)]
	[Range(-2f, 2f)]
	public float gravityMax;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("  Rotation")]
	[Space(3f)]
	[Range(0f, 1f)]
	public float rotationSpeed;

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x2CBB184", Offset = "0x2CBB184", VA = "0x2CBB184")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x2CBB1C4", Offset = "0x2CBB1C4", VA = "0x2CBB1C4")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000031")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(0f, 10f)]
	[Header("  Speed")]
	[Space(3f)]
	public float speedMin;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0f, 10f)]
	[Space(2f)]
	public float speedMax;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Rotation")]
	[Space(3f)]
	[Range(0f, 1f)]
	public float rotation;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(-2f, 2f)]
	[Header("  Gravity Modifier")]
	[Space(3f)]
	public float gravityMin;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(-2f, 2f)]
	[Space(2f)]
	public float gravityMax;

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x2CBB1F8", Offset = "0x2CBB1F8", VA = "0x2CBB1F8")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x2CBB228", Offset = "0x2CBB228", VA = "0x2CBB228")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000032")]
public class RFParticleEmission
{
	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Burst")]
	[Space(3f)]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(0f, 500f)]
	public int burstAmount;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Distance")]
	[Space(3f)]
	[Range(0f, 5f)]
	public float distanceRate;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0.5f, 10f)]
	public float duration;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(1f, 60f)]
	[Space(3f)]
	[Header("  Lifetime")]
	public float lifeMin;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(1f, 60f)]
	[Space(2f)]
	public float lifeMax;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("  Size")]
	[Space(3f)]
	[Range(0.1f, 10f)]
	public float sizeMin;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Space(2f)]
	[Range(0.1f, 10f)]
	public float sizeMax;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x2CBB24C", Offset = "0x2CBB24C", VA = "0x2CBB24C")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x2CBB288", Offset = "0x2CBB288", VA = "0x2CBB288")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000033")]
public class RFParticleLimitations
{
	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Range(3f, 100f)]
	[Header("  Particle system")]
	[Space(3f)]
	public int minParticles;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(5f, 100f)]
	public int maxParticles;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Fragments")]
	[Space(3f)]
	[Range(10f, 100f)]
	public int percentage;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0.05f, 5f)]
	public float sizeThreshold;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Range(0f, 5f)]
	public int demolitionDepth;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x2CBB2B4", Offset = "0x2CBB2B4", VA = "0x2CBB2B4")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2CBB2EC", Offset = "0x2CBB2EC", VA = "0x2CBB2EC")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000034")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x2000035")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000FD")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000FE")]
		ByProperties
	}

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Common")]
	[Space(3f)]
	public LayerMask collidesWith;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 2f)]
	[Space(2f)]
	public float radiusScale;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Dampen")]
	[Space(3f)]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 1f)]
	[Space(2f)]
	public float dampenMin;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 1f)]
	[Space(2f)]
	public float dampenMax;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(3f)]
	[Header("  Bounce")]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 1f)]
	[Space(2f)]
	public float bounceMin;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	[Range(0f, 1f)]
	public float bounceMax;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x2CBB310", Offset = "0x2CBB310", VA = "0x2CBB310")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2CBB364", Offset = "0x2CBB364", VA = "0x2CBB364")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2CBB398", Offset = "0x2CBB398", VA = "0x2CBB398")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x2000036")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(3f)]
	[Header("  Common")]
	public LayerMask collidesWith;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	[Range(0.1f, 2f)]
	public float radiusScale;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x2CBB590", Offset = "0x2CBB590", VA = "0x2CBB590")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2CBB5C0", Offset = "0x2CBB5C0", VA = "0x2CBB5C0")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000037")]
public class RFParticles
{
	[Token(Token = "0x2000038")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x4000106")]
		ByPhysicalMaterial,
		[Token(Token = "0x4000107")]
		ByProperties
	}

	[Token(Token = "0x2000039")]
	public enum BurstType
	{
		[Token(Token = "0x4000109")]
		None,
		[Token(Token = "0x400010A")]
		TotalAmount,
		[Token(Token = "0x400010B")]
		PerOneUnitSize,
		[Token(Token = "0x400010C")]
		FragmentAmount
	}

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2CBB5E4", Offset = "0x2CBB5E4", VA = "0x2CBB5E4")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2CBBA2C", Offset = "0x2CBBA2C", VA = "0x2CBBA2C")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x2CBBF9C", Offset = "0x2CBBF9C", VA = "0x2CBBF9C")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x2CBC070", Offset = "0x2CBC070", VA = "0x2CBC070")]
	public static void CreateDemolitionDebris(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x2CBC478", Offset = "0x2CBC478", VA = "0x2CBC478")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x2CBDA44", Offset = "0x2CBDA44", VA = "0x2CBDA44")]
	public static void InitActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x2CBDBD8", Offset = "0x2CBDBD8", VA = "0x2CBDBD8")]
	public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x2CBD124", Offset = "0x2CBD124", VA = "0x2CBD124")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x2CBDF14", Offset = "0x2CBDF14", VA = "0x2CBDF14")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x2CBD6F4", Offset = "0x2CBD6F4", VA = "0x2CBD6F4")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x2CBE0D8", Offset = "0x2CBE0D8", VA = "0x2CBE0D8")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x2CBE29C", Offset = "0x2CBE29C", VA = "0x2CBE29C")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x2CBE580", Offset = "0x2CBE580", VA = "0x2CBE580")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x2CBE6E4", Offset = "0x2CBE6E4", VA = "0x2CBE6E4")]
	private static ParticleSystem CreateParticleSystem(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x2CBE8BC", Offset = "0x2CBE8BC", VA = "0x2CBE8BC")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x2CBEA6C", Offset = "0x2CBEA6C", VA = "0x2CBEA6C")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x2CBC880", Offset = "0x2CBC880", VA = "0x2CBC880")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x2CBEC1C", Offset = "0x2CBEC1C", VA = "0x2CBEC1C")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x2CBF210", Offset = "0x2CBF210", VA = "0x2CBF210")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x2CBFC40", Offset = "0x2CBFC40", VA = "0x2CBFC40")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x2CC0234", Offset = "0x2CC0234", VA = "0x2CC0234")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x2CC0490", Offset = "0x2CC0490", VA = "0x2CC0490")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x2CC05DC", Offset = "0x2CC05DC", VA = "0x2CC05DC")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x2CC06A0", Offset = "0x2CC06A0", VA = "0x2CC06A0")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x2CBE400", Offset = "0x2CBE400", VA = "0x2CBE400")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x2CC06E4", Offset = "0x2CC06E4", VA = "0x2CC06E4")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x2CC07C4", Offset = "0x2CC07C4", VA = "0x2CC07C4")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x2CC0888", Offset = "0x2CC0888", VA = "0x2CC0888")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x2CC0AB8", Offset = "0x2CC0AB8", VA = "0x2CC0AB8")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x2CC0D50", Offset = "0x2CC0D50", VA = "0x2CC0D50")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x2CC0B54", Offset = "0x2CC0B54", VA = "0x2CC0B54")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x2CC0E5C", Offset = "0x2CC0E5C", VA = "0x2CC0E5C")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x2CC0F08", Offset = "0x2CC0F08", VA = "0x2CC0F08")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x2CC10DC", Offset = "0x2CC10DC", VA = "0x2CC10DC")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x2CC1294", Offset = "0x2CC1294", VA = "0x2CC1294")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x2CC1498", Offset = "0x2CC1498", VA = "0x2CC1498")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x2CC15D8", Offset = "0x2CC15D8", VA = "0x2CC15D8")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x2CBD208", Offset = "0x2CBD208", VA = "0x2CBD208")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x2CBD7D8", Offset = "0x2CBD7D8", VA = "0x2CBD7D8")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2CBCEA4", Offset = "0x2CBCEA4", VA = "0x2CBCEA4")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2CBD474", Offset = "0x2CBD474", VA = "0x2CBD474")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x2CBE504", Offset = "0x2CBE504", VA = "0x2CBE504")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x2CC167C", Offset = "0x2CC167C", VA = "0x2CC167C")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x2CC1874", Offset = "0x2CC1874", VA = "0x2CC1874")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x200003A")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[NonSerialized]
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float m;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int nAm;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public List<int> nIds;

	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<float> nArea;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<int> sIds;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<float> nSt;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float sSt;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform tm;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public MeshFilter mf;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Collider col;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Rigidbody rb;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool[] sCheck;

	[Token(Token = "0x1700000D")]
	public bool StressState
	{
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2CC3370", Offset = "0x2CC3370", VA = "0x2CC3370")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool SupportState
	{
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2CC3ED0", Offset = "0x2CC3ED0", VA = "0x2CC3ED0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2CC3F20", Offset = "0x2CC3F20", VA = "0x2CC3F20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x2CC1958", Offset = "0x2CC1958", VA = "0x2CC1958")]
	public RFShard()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x2CB2F30", Offset = "0x2CB2F30", VA = "0x2CB2F30")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x2CC19C0", Offset = "0x2CC19C0", VA = "0x2CC19C0")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x2CC1BC8", Offset = "0x2CC1BC8", VA = "0x2CC1BC8")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x2CC1D1C", Offset = "0x2CC1D1C", VA = "0x2CC1D1C", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x2CC1D4C", Offset = "0x2CC1D4C", VA = "0x2CC1D4C")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x2CC1E20", Offset = "0x2CC1E20", VA = "0x2CC1E20")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x2CC1E60", Offset = "0x2CC1E60", VA = "0x2CC1E60")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x2CC1FA8", Offset = "0x2CC1FA8", VA = "0x2CC1FA8")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x2CC22B4", Offset = "0x2CC22B4", VA = "0x2CC22B4")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x2CC242C", Offset = "0x2CC242C", VA = "0x2CC242C")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x2CC25D8", Offset = "0x2CC25D8", VA = "0x2CC25D8")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x2CC27D4", Offset = "0x2CC27D4", VA = "0x2CC27D4")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x2CC312C", Offset = "0x2CC312C", VA = "0x2CC312C")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2CC3244", Offset = "0x2CC3244", VA = "0x2CC3244")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x2CC33C4", Offset = "0x2CC33C4", VA = "0x2CC33C4")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x2CB3EA4", Offset = "0x2CB3EA4", VA = "0x2CB3EA4")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x2CC34AC", Offset = "0x2CC34AC", VA = "0x2CC34AC")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2CC3614", Offset = "0x2CC3614", VA = "0x2CC3614")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x2CC3A40", Offset = "0x2CC3A40", VA = "0x2CC3A40")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x2CB3F30", Offset = "0x2CB3F30", VA = "0x2CB3F30")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x2CC3E34", Offset = "0x2CC3E34", VA = "0x2CC3E34")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x2CC3F34", Offset = "0x2CC3F34", VA = "0x2CC3F34")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x2CC4034", Offset = "0x2CC4034", VA = "0x2CC4034")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class RFSound
{
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x17000010")]
	public bool HasClips
	{
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x2CC53F4", Offset = "0x2CC53F4", VA = "0x2CC53F4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x2CC5200", Offset = "0x2CC5200", VA = "0x2CC5200")]
	public RFSound()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x2CC5224", Offset = "0x2CC5224", VA = "0x2CC5224")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x2CC5448", Offset = "0x2CC5448", VA = "0x2CC5448")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x2CC5534", Offset = "0x2CC5534", VA = "0x2CC5534")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x2CC56BC", Offset = "0x2CC56BC", VA = "0x2CC56BC")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x2CC5918", Offset = "0x2CC5918", VA = "0x2CC5918")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x2CC5D18", Offset = "0x2CC5D18", VA = "0x2CC5D18")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x2CC5ED8", Offset = "0x2CC5ED8", VA = "0x2CC5ED8")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x2CC5C64", Offset = "0x2CC5C64", VA = "0x2CC5C64")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x2CC5AE8", Offset = "0x2CC5AE8", VA = "0x2CC5AE8")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200003C")]
public class RFStress
{
	[Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x2CC9710", Offset = "0x2CC9710", VA = "0x2CC9710", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x2CC9758", Offset = "0x2CC9758", VA = "0x2CC9758", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x2CC62D0", Offset = "0x2CC62D0", VA = "0x2CC62D0")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x2CC9568", Offset = "0x2CC9568", VA = "0x2CC9568", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2CC956C", Offset = "0x2CC956C", VA = "0x2CC956C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2CC9718", Offset = "0x2CC9718", VA = "0x2CC9718", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x2CC6098", Offset = "0x2CC6098", VA = "0x2CC6098")]
	public RFStress()
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x2CC6194", Offset = "0x2CC6194", VA = "0x2CC6194")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x2CC61B4", Offset = "0x2CC61B4", VA = "0x2CC61B4")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x2CC6240", Offset = "0x2CC6240", VA = "0x2CC6240")]
	[IteratorStateMachine(typeof(<StressCor>d__21))]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x2CC62F8", Offset = "0x2CC62F8", VA = "0x2CC62F8")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x2CC65A0", Offset = "0x2CC65A0", VA = "0x2CC65A0")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x2CC6A24", Offset = "0x2CC6A24", VA = "0x2CC6A24")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x2CC6A5C", Offset = "0x2CC6A5C", VA = "0x2CC6A5C")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x2CC6CA8", Offset = "0x2CC6CA8", VA = "0x2CC6CA8")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x2CC6D10", Offset = "0x2CC6D10", VA = "0x2CC6D10")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x2CC6EDC", Offset = "0x2CC6EDC", VA = "0x2CC6EDC")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x2CC7C4C", Offset = "0x2CC7C4C", VA = "0x2CC7C4C")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x2CC83F8", Offset = "0x2CC83F8", VA = "0x2CC83F8")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x2CC752C", Offset = "0x2CC752C", VA = "0x2CC752C")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x2CC8F6C", Offset = "0x2CC8F6C", VA = "0x2CC8F6C")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x2CC84C4", Offset = "0x2CC84C4", VA = "0x2CC84C4")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x200003E")]
public enum AxisType
{
	[Token(Token = "0x400014D")]
	XRed,
	[Token(Token = "0x400014E")]
	YGreen,
	[Token(Token = "0x400014F")]
	ZBlue
}
[Token(Token = "0x200003F")]
public enum PlaneType
{
	[Token(Token = "0x4000151")]
	XY,
	[Token(Token = "0x4000152")]
	XZ,
	[Token(Token = "0x4000153")]
	YZ
}
[Token(Token = "0x2000040")]
public enum FragType
{
	[Token(Token = "0x4000155")]
	Voronoi = 0,
	[Token(Token = "0x4000156")]
	Splinters = 1,
	[Token(Token = "0x4000157")]
	Slabs = 2,
	[Token(Token = "0x4000158")]
	Radial = 3,
	[Token(Token = "0x4000159")]
	Custom = 5,
	[Token(Token = "0x400015A")]
	Slices = 7,
	[Token(Token = "0x400015B")]
	Bricks = 9,
	[Token(Token = "0x400015C")]
	Voxels = 10,
	[Token(Token = "0x400015D")]
	Tets = 11,
	[Token(Token = "0x400015E")]
	Decompose = 15
}
[Token(Token = "0x2000041")]
public enum DemolitionType
{
	[Token(Token = "0x4000160")]
	None = 0,
	[Token(Token = "0x4000161")]
	Runtime = 1,
	[Token(Token = "0x4000162")]
	AwakePrecache = 2,
	[Token(Token = "0x4000163")]
	AwakePrefragment = 3,
	[Token(Token = "0x4000164")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000042")]
public enum CachingType
{
	[Token(Token = "0x4000166")]
	Disable,
	[Token(Token = "0x4000167")]
	ByFrames,
	[Token(Token = "0x4000168")]
	ByFragmentsPerFrame
}
[Token(Token = "0x2000043")]
public enum FadeType
{
	[Token(Token = "0x400016A")]
	None = 0,
	[Token(Token = "0x400016B")]
	SimExclude = 1,
	[Token(Token = "0x400016C")]
	FallDown = 2,
	[Token(Token = "0x400016D")]
	ScaleDown = 3,
	[Token(Token = "0x400016E")]
	MoveDown = 4,
	[Token(Token = "0x400016F")]
	Destroy = 5,
	[Token(Token = "0x4000170")]
	SetStatic = 8,
	[Token(Token = "0x4000171")]
	SetKinematic = 9
}
[Token(Token = "0x2000044")]
public enum RFFadeLifeType
{
	[Token(Token = "0x4000173")]
	ByLifeTime = 4,
	[Token(Token = "0x4000174")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x2000045")]
public enum MaterialType
{
	[Token(Token = "0x4000176")]
	HeavyMetal,
	[Token(Token = "0x4000177")]
	LightMetal,
	[Token(Token = "0x4000178")]
	DenseRock,
	[Token(Token = "0x4000179")]
	PorousRock,
	[Token(Token = "0x400017A")]
	Concrete,
	[Token(Token = "0x400017B")]
	Brick,
	[Token(Token = "0x400017C")]
	Glass,
	[Token(Token = "0x400017D")]
	Rubber,
	[Token(Token = "0x400017E")]
	Ice,
	[Token(Token = "0x400017F")]
	Wood
}
[Token(Token = "0x2000046")]
public enum MassType
{
	[Token(Token = "0x4000181")]
	MaterialDensity,
	[Token(Token = "0x4000182")]
	MassProperty,
	[Token(Token = "0x4000183")]
	RigidBodyComponent
}
[Token(Token = "0x2000047")]
public enum ObjectType
{
	[Token(Token = "0x4000185")]
	Mesh = 0,
	[Token(Token = "0x4000186")]
	MeshRoot = 1,
	[Token(Token = "0x4000187")]
	SkinnedMesh = 2,
	[Token(Token = "0x4000188")]
	NestedCluster = 4,
	[Token(Token = "0x4000189")]
	ConnectedCluster = 5
}
[Token(Token = "0x2000048")]
public enum SimType
{
	[Token(Token = "0x400018B")]
	Dynamic,
	[Token(Token = "0x400018C")]
	Sleeping,
	[Token(Token = "0x400018D")]
	Inactive,
	[Token(Token = "0x400018E")]
	Kinematic,
	[Token(Token = "0x400018F")]
	Static
}
[Token(Token = "0x2000049")]
public enum FragSimType
{
	[Token(Token = "0x4000191")]
	Dynamic,
	[Token(Token = "0x4000192")]
	Sleeping,
	[Token(Token = "0x4000193")]
	Inactive,
	[Token(Token = "0x4000194")]
	Kinematic,
	[Token(Token = "0x4000195")]
	Inherit
}
[Token(Token = "0x200004A")]
public enum ConnectivityType
{
	[Token(Token = "0x4000197")]
	ByBoundingBox = 0,
	[Token(Token = "0x4000198")]
	ByTriangles = 1,
	[Token(Token = "0x4000199")]
	ByPolygons = 3,
	[Token(Token = "0x400019A")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x400019B")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x200004B")]
public enum FragmentMode
{
	[Token(Token = "0x400019D")]
	Runtime,
	[Token(Token = "0x400019E")]
	Editor
}
[Token(Token = "0x200004C")]
public enum RFColliderType
{
	[Token(Token = "0x40001A0")]
	Mesh = 0,
	[Token(Token = "0x40001A1")]
	Box = 1,
	[Token(Token = "0x40001A2")]
	Sphere = 2,
	[Token(Token = "0x40001A3")]
	None = 4
}
[Token(Token = "0x200004D")]
public enum RFParenting
{
	[Token(Token = "0x40001A5")]
	Manager = 0,
	[Token(Token = "0x40001A6")]
	Parent = 1,
	[Token(Token = "0x40001A7")]
	Sphere = 2,
	[Token(Token = "0x40001A8")]
	None = 4
}
[Serializable]
[Token(Token = "0x200004E")]
public class RFActivation
{
	[Token(Token = "0x200004F")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCA7BC", Offset = "0x2CCA7BC", VA = "0x2CCA7BC", Slot = "4")]
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
			[Address(RVA = "0x2CCA804", Offset = "0x2CCA804", VA = "0x2CCA804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2CC9958", Offset = "0x2CC9958", VA = "0x2CC9958")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x2CCA644", Offset = "0x2CCA644", VA = "0x2CCA644", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2CCA648", Offset = "0x2CCA648", VA = "0x2CCA648", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2CCA7C4", Offset = "0x2CCA7C4", VA = "0x2CCA7C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000050")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCA9E0", Offset = "0x2CCA9E0", VA = "0x2CCA9E0", Slot = "4")]
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
			[Address(RVA = "0x2CCAA28", Offset = "0x2CCAA28", VA = "0x2CCAA28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2CC9A10", Offset = "0x2CC9A10", VA = "0x2CC9A10")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2CCA80C", Offset = "0x2CCA80C", VA = "0x2CCA80C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2CCA810", Offset = "0x2CCA810", VA = "0x2CCA810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2CCA9E8", Offset = "0x2CCA9E8", VA = "0x2CCA9E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCAB7C", Offset = "0x2CCAB7C", VA = "0x2CCAB7C", Slot = "4")]
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
			[Address(RVA = "0x2CCABC4", Offset = "0x2CCABC4", VA = "0x2CCABC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2CC9AC8", Offset = "0x2CC9AC8", VA = "0x2CC9AC8")]
		[DebuggerHidden]
		public <InactiveCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2CCAA30", Offset = "0x2CCAA30", VA = "0x2CCAA30", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2CCAA34", Offset = "0x2CCAA34", VA = "0x2CCAA34", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2CCAB84", Offset = "0x2CCAB84", VA = "0x2CCAB84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCB2C8", Offset = "0x2CCB2C8", VA = "0x2CCB2C8", Slot = "4")]
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
			[Address(RVA = "0x2CCB310", Offset = "0x2CCB310", VA = "0x2CCB310", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2CC9B80", Offset = "0x2CC9B80", VA = "0x2CC9B80")]
		[DebuggerHidden]
		public <InactiveCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2CCABCC", Offset = "0x2CCABCC", VA = "0x2CCABCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2CCABD0", Offset = "0x2CCABD0", VA = "0x2CCABD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x2CCB2D0", Offset = "0x2CCB2D0", VA = "0x2CCB2D0", Slot = "8")]
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
	[Address(RVA = "0x2CC9760", Offset = "0x2CC9760", VA = "0x2CC9760")]
	public RFActivation()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x2CC97D0", Offset = "0x2CC97D0", VA = "0x2CC97D0")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x2CC97A4", Offset = "0x2CC97A4", VA = "0x2CC97A4")]
	public void Reset()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x2CC982C", Offset = "0x2CC982C", VA = "0x2CC982C")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x2CC98C8", Offset = "0x2CC98C8", VA = "0x2CC98C8")]
	[IteratorStateMachine(typeof(<ActivationVelocityCor>d__21))]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x2CC9980", Offset = "0x2CC9980", VA = "0x2CC9980")]
	[IteratorStateMachine(typeof(<ActivationOffsetCor>d__22))]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x2CC9A38", Offset = "0x2CC9A38", VA = "0x2CC9A38")]
	[IteratorStateMachine(typeof(<InactiveCor>d__23))]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x2CC9AF0", Offset = "0x2CC9AF0", VA = "0x2CC9AF0")]
	[IteratorStateMachine(typeof(<InactiveCor>d__24))]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x2CC9BA8", Offset = "0x2CC9BA8", VA = "0x2CC9BA8")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x2CCA22C", Offset = "0x2CCA22C", VA = "0x2CCA22C")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x2CCA138", Offset = "0x2CCA138", VA = "0x2CCA138")]
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
	[Address(RVA = "0x2CCB318", Offset = "0x2CCB318", VA = "0x2CCB318")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x2CCB334", Offset = "0x2CCB334", VA = "0x2CCB334")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x2CCB6B0", Offset = "0x2CCB6B0", VA = "0x2CCB6B0")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x2CCB8D8", Offset = "0x2CCB8D8", VA = "0x2CCB8D8")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x2CCBDB4", Offset = "0x2CCBDB4", VA = "0x2CCBDB4")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0x2CCC6C4", Offset = "0x2CCC6C4", VA = "0x2CCC6C4")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0x2CCB498", Offset = "0x2CCB498", VA = "0x2CCB498")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0x2CCC33C", Offset = "0x2CCC33C", VA = "0x2CCC33C")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0x2CCC1B0", Offset = "0x2CCC1B0", VA = "0x2CCC1B0")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0x2CCBEC8", Offset = "0x2CCBEC8", VA = "0x2CCBEC8")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0x2CCC278", Offset = "0x2CCC278", VA = "0x2CCC278")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0x2CCC558", Offset = "0x2CCC558", VA = "0x2CCC558")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0x2CCC9E4", Offset = "0x2CCC9E4", VA = "0x2CCC9E4")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0x2CCCC50", Offset = "0x2CCCC50", VA = "0x2CCCC50")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0x2CCCD5C", Offset = "0x2CCCD5C", VA = "0x2CCCD5C")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCE86C", Offset = "0x2CCE86C", VA = "0x2CCE86C", Slot = "4")]
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
			[Address(RVA = "0x2CCE8B4", Offset = "0x2CCE8B4", VA = "0x2CCE8B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2CCD788", Offset = "0x2CCD788", VA = "0x2CCD788")]
		[DebuggerHidden]
		public <CollapseCor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2CCE684", Offset = "0x2CCE684", VA = "0x2CCE684", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2CCE688", Offset = "0x2CCE688", VA = "0x2CCE688", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2CCE874", Offset = "0x2CCE874", VA = "0x2CCE874", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000057")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CCEA9C", Offset = "0x2CCEA9C", VA = "0x2CCEA9C", Slot = "4")]
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
			[Address(RVA = "0x2CCEAE4", Offset = "0x2CCEAE4", VA = "0x2CCEAE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2CCD8EC", Offset = "0x2CCD8EC", VA = "0x2CCD8EC")]
		[DebuggerHidden]
		public <CollapseCor>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2CCE8BC", Offset = "0x2CCE8BC", VA = "0x2CCE8BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2CCE8C0", Offset = "0x2CCE8C0", VA = "0x2CCE8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2CCEAA4", Offset = "0x2CCEAA4", VA = "0x2CCEAA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip(" By Area: Shard will loose it's connections if it's shared area surface is less then defined value.\n By Size: Shard will loose it's connections if it's Size is less then defined value.\n Random: Shard will loose it's connections if it's random value in range from 0 to 100 is less then defined value.")]
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
	[Address(RVA = "0x2CCD630", Offset = "0x2CCD630", VA = "0x2CCD630")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x2CCD65C", Offset = "0x2CCD65C", VA = "0x2CCD65C")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x2CCD6F8", Offset = "0x2CCD6F8", VA = "0x2CCD6F8")]
	[IteratorStateMachine(typeof(<CollapseCor>d__9))]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x2CCD7B0", Offset = "0x2CCD7B0", VA = "0x2CCD7B0")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x2CCD8CC", Offset = "0x2CCD8CC", VA = "0x2CCD8CC")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x2CCD83C", Offset = "0x2CCD83C", VA = "0x2CCD83C")]
	[IteratorStateMachine(typeof(<CollapseCor>d__12))]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x2CCD914", Offset = "0x2CCD914", VA = "0x2CCD914")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x2CCD9D4", Offset = "0x2CCD9D4", VA = "0x2CCD9D4")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x2CCD97C", Offset = "0x2CCD97C", VA = "0x2CCD97C")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x2CCDA3C", Offset = "0x2CCDA3C", VA = "0x2CCDA3C")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x2CCE038", Offset = "0x2CCE038", VA = "0x2CCE038")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x2CCDCDC", Offset = "0x2CCDCDC", VA = "0x2CCDCDC")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x2CCE4D0", Offset = "0x2CCE4D0", VA = "0x2CCE4D0")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x2CCE57C", Offset = "0x2CCE57C", VA = "0x2CCE57C")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x2CCE530", Offset = "0x2CCE530", VA = "0x2CCE530")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0x2CCE5DC", Offset = "0x2CCE5DC", VA = "0x2CCE5DC")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x2CCE628", Offset = "0x2CCE628", VA = "0x2CCE628")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x2CCDA94", Offset = "0x2CCDA94", VA = "0x2CCDA94")]
	private static int RemNeibByArea(RFCluster cluster, float minArea)
	{
		return default(int);
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x2CCDE34", Offset = "0x2CCDE34", VA = "0x2CCDE34")]
	private static int RemNeibBySize(RFCluster cluster, float minSize)
	{
		return default(int);
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x2CCE090", Offset = "0x2CCE090", VA = "0x2CCE090")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x2CCD368", Offset = "0x2CCD368", VA = "0x2CCD368")]
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
	[Address(RVA = "0x2CCEAEC", Offset = "0x2CCEAEC", VA = "0x2CCEAEC")]
	public RFDamage()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x2CCEB20", Offset = "0x2CCEB20", VA = "0x2CCEB20")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x2CCC9DC", Offset = "0x2CCC9DC", VA = "0x2CCC9DC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x2CCEB58", Offset = "0x2CCEB58", VA = "0x2CCEB58")]
	public static bool Apply(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x2CCEBA0", Offset = "0x2CCEBA0", VA = "0x2CCEBA0")]
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
		[Address(RVA = "0x2CD3FD4", Offset = "0x2CD3FD4", VA = "0x2CD3FD4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2CCF564", Offset = "0x2CCF564", VA = "0x2CCF564")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0x2CCECE4", Offset = "0x2CCECE4", VA = "0x2CCECE4")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x2CCED3C", Offset = "0x2CCED3C", VA = "0x2CCED3C")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x2CCC9D4", Offset = "0x2CCC9D4", VA = "0x2CCC9D4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x2CCED94", Offset = "0x2CCED94", VA = "0x2CCED94")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x2CCEE68", Offset = "0x2CCEE68", VA = "0x2CCEE68")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x2CCEF08", Offset = "0x2CCEF08", VA = "0x2CCEF08")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x2CCF3B8", Offset = "0x2CCF3B8", VA = "0x2CCF3B8")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x2CCF174", Offset = "0x2CCF174", VA = "0x2CCF174")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x2CCF5B8", Offset = "0x2CCF5B8", VA = "0x2CCF5B8")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x2CCF9F0", Offset = "0x2CCF9F0", VA = "0x2CCF9F0")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x2CCFCC8", Offset = "0x2CCFCC8", VA = "0x2CCFCC8")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x2CCFE78", Offset = "0x2CCFE78", VA = "0x2CCFE78")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x2CD0038", Offset = "0x2CD0038", VA = "0x2CD0038")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x2CCFAF4", Offset = "0x2CCFAF4", VA = "0x2CCFAF4")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x2CCE30C", Offset = "0x2CCE30C", VA = "0x2CCE30C")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x2CD0864", Offset = "0x2CD0864", VA = "0x2CD0864")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x2CD094C", Offset = "0x2CD094C", VA = "0x2CD094C")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x2CD0A44", Offset = "0x2CD0A44", VA = "0x2CD0A44")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x2CD1BA8", Offset = "0x2CD1BA8", VA = "0x2CD1BA8")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x2CD243C", Offset = "0x2CD243C", VA = "0x2CD243C")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x2CD04BC", Offset = "0x2CD04BC", VA = "0x2CD04BC")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x2CD1098", Offset = "0x2CD1098", VA = "0x2CD1098")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x2CD2864", Offset = "0x2CD2864", VA = "0x2CD2864")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x2CD300C", Offset = "0x2CD300C", VA = "0x2CD300C")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x2CD3488", Offset = "0x2CD3488", VA = "0x2CD3488")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x2CD2EF8", Offset = "0x2CD2EF8", VA = "0x2CD2EF8")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x2CD3824", Offset = "0x2CD3824", VA = "0x2CD3824")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x2CD0D6C", Offset = "0x2CD0D6C", VA = "0x2CD0D6C")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x2CD3A98", Offset = "0x2CD3A98", VA = "0x2CD3A98")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x2CD0F94", Offset = "0x2CD0F94", VA = "0x2CD0F94")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x2CD3E98", Offset = "0x2CD3E98", VA = "0x2CD3E98")]
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
	[Address(RVA = "0x2CD40A0", Offset = "0x2CD40A0", VA = "0x2CD40A0")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x2CD414C", Offset = "0x2CD414C", VA = "0x2CD414C")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x2CD4380", Offset = "0x2CD4380", VA = "0x2CD4380")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD7994", Offset = "0x2CD7994", VA = "0x2CD7994", Slot = "4")]
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
			[Address(RVA = "0x2CD79DC", Offset = "0x2CD79DC", VA = "0x2CD79DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2CD6BB8", Offset = "0x2CD6BB8", VA = "0x2CD6BB8")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2CD6BE0", Offset = "0x2CD6BE0", VA = "0x2CD6BE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2CD6BE4", Offset = "0x2CD6BE4", VA = "0x2CD6BE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2CD799C", Offset = "0x2CD799C", VA = "0x2CD799C", Slot = "8")]
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
	[Address(RVA = "0x2CD4388", Offset = "0x2CD4388", VA = "0x2CD4388")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x2CD44CC", Offset = "0x2CD44CC", VA = "0x2CD44CC")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x2CCC9C8", Offset = "0x2CCC9C8", VA = "0x2CCC9C8")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x2CD45E0", Offset = "0x2CD45E0", VA = "0x2CD45E0")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x2CD5314", Offset = "0x2CD5314", VA = "0x2CD5314")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x2CD4860", Offset = "0x2CD4860", VA = "0x2CD4860")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x2CD58F8", Offset = "0x2CD58F8", VA = "0x2CD58F8")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x2CD5DC0", Offset = "0x2CD5DC0", VA = "0x2CD5DC0")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x2CD57C8", Offset = "0x2CD57C8", VA = "0x2CD57C8")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x2CD5244", Offset = "0x2CD5244", VA = "0x2CD5244")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x2CD6504", Offset = "0x2CD6504", VA = "0x2CD6504")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x2CD5800", Offset = "0x2CD5800", VA = "0x2CD5800")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x2CD65B4", Offset = "0x2CD65B4", VA = "0x2CD65B4")]
	[IteratorStateMachine(typeof(<RuntimeCachingCor>d__33))]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x2CD6644", Offset = "0x2CD6644", VA = "0x2CD6644")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x2CD666C", Offset = "0x2CD666C", VA = "0x2CD666C")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x60001C6")]
	[Address(RVA = "0x2CD66CC", Offset = "0x2CD66CC", VA = "0x2CD66CC")]
	public static void AwakePrecache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x2CD67C4", Offset = "0x2CD67C4", VA = "0x2CD67C4")]
	public static void AwakePrefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x2CD6748", Offset = "0x2CD6748", VA = "0x2CD6748")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x2CD684C", Offset = "0x2CD684C", VA = "0x2CD684C")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x200005F")]
public class RFFade
{
	[Token(Token = "0x2000060")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD8F74", Offset = "0x2CD8F74", VA = "0x2CD8F74", Slot = "4")]
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
			[Address(RVA = "0x2CD8FBC", Offset = "0x2CD8FBC", VA = "0x2CD8FBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2CD7D30", Offset = "0x2CD7D30", VA = "0x2CD7D30")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2CD8D10", Offset = "0x2CD8D10", VA = "0x2CD8D10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2CD8D14", Offset = "0x2CD8D14", VA = "0x2CD8D14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2CD8F7C", Offset = "0x2CD8F7C", VA = "0x2CD8F7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000061")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD9308", Offset = "0x2CD9308", VA = "0x2CD9308", Slot = "4")]
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
			[Address(RVA = "0x2CD9350", Offset = "0x2CD9350", VA = "0x2CD9350", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2CD7DCC", Offset = "0x2CD7DCC", VA = "0x2CD7DCC")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2CD8FC4", Offset = "0x2CD8FC4", VA = "0x2CD8FC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2CD8FC8", Offset = "0x2CD8FC8", VA = "0x2CD8FC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2CD9310", Offset = "0x2CD9310", VA = "0x2CD9310", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD9600", Offset = "0x2CD9600", VA = "0x2CD9600", Slot = "4")]
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
			[Address(RVA = "0x2CD9648", Offset = "0x2CD9648", VA = "0x2CD9648", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2CD8080", Offset = "0x2CD8080", VA = "0x2CD8080")]
		[DebuggerHidden]
		public <LivingCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2CD9358", Offset = "0x2CD9358", VA = "0x2CD9358", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2CD935C", Offset = "0x2CD935C", VA = "0x2CD935C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2CD9608", Offset = "0x2CD9608", VA = "0x2CD9608", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD98E8", Offset = "0x2CD98E8", VA = "0x2CD98E8", Slot = "4")]
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
			[Address(RVA = "0x2CD9930", Offset = "0x2CD9930", VA = "0x2CD9930", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2CD80A8", Offset = "0x2CD80A8", VA = "0x2CD80A8")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2CD9650", Offset = "0x2CD9650", VA = "0x2CD9650", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2CD9654", Offset = "0x2CD9654", VA = "0x2CD9654", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2CD98F0", Offset = "0x2CD98F0", VA = "0x2CD98F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD9ACC", Offset = "0x2CD9ACC", VA = "0x2CD9ACC", Slot = "4")]
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
			[Address(RVA = "0x2CD9B14", Offset = "0x2CD9B14", VA = "0x2CD9B14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2CD8144", Offset = "0x2CD8144", VA = "0x2CD8144")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2CD9938", Offset = "0x2CD9938", VA = "0x2CD9938", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2CD993C", Offset = "0x2CD993C", VA = "0x2CD993C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2CD9AD4", Offset = "0x2CD9AD4", VA = "0x2CD9AD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD9D08", Offset = "0x2CD9D08", VA = "0x2CD9D08", Slot = "4")]
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
			[Address(RVA = "0x2CD9D50", Offset = "0x2CD9D50", VA = "0x2CD9D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2CD8490", Offset = "0x2CD8490", VA = "0x2CD8490")]
		[DebuggerHidden]
		public <FallDownCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x2CD9B1C", Offset = "0x2CD9B1C", VA = "0x2CD9B1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2CD9B20", Offset = "0x2CD9B20", VA = "0x2CD9B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2CD9D10", Offset = "0x2CD9D10", VA = "0x2CD9D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CD9EF8", Offset = "0x2CD9EF8", VA = "0x2CD9EF8", Slot = "4")]
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
			[Address(RVA = "0x2CD9F40", Offset = "0x2CD9F40", VA = "0x2CD9F40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2CD8548", Offset = "0x2CD8548", VA = "0x2CD8548")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2CD9D58", Offset = "0x2CD9D58", VA = "0x2CD9D58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2CD9D5C", Offset = "0x2CD9D5C", VA = "0x2CD9D5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2CD9F00", Offset = "0x2CD9F00", VA = "0x2CD9F00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000067")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CDA124", Offset = "0x2CDA124", VA = "0x2CDA124", Slot = "4")]
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
			[Address(RVA = "0x2CDA16C", Offset = "0x2CDA16C", VA = "0x2CDA16C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x2CD85E4", Offset = "0x2CD85E4", VA = "0x2CD85E4")]
		[DebuggerHidden]
		public <ScaleDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x2CD9F48", Offset = "0x2CD9F48", VA = "0x2CD9F48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x2CD9F4C", Offset = "0x2CD9F4C", VA = "0x2CD9F4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2CDA12C", Offset = "0x2CDA12C", VA = "0x2CDA12C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CDA394", Offset = "0x2CDA394", VA = "0x2CDA394", Slot = "4")]
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
			[Address(RVA = "0x2CDA3DC", Offset = "0x2CDA3DC", VA = "0x2CDA3DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2CD869C", Offset = "0x2CD869C", VA = "0x2CD869C")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2CDA174", Offset = "0x2CDA174", VA = "0x2CDA174", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2CDA178", Offset = "0x2CDA178", VA = "0x2CDA178", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2CDA39C", Offset = "0x2CDA39C", VA = "0x2CDA39C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CDA7EC", Offset = "0x2CDA7EC", VA = "0x2CDA7EC", Slot = "4")]
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
			[Address(RVA = "0x2CDA834", Offset = "0x2CDA834", VA = "0x2CDA834", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2CD8738", Offset = "0x2CD8738", VA = "0x2CD8738")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2CDA3E4", Offset = "0x2CDA3E4", VA = "0x2CDA3E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2CDA3E8", Offset = "0x2CDA3E8", VA = "0x2CDA3E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2CDA7F4", Offset = "0x2CDA7F4", VA = "0x2CDA7F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CDABA8", Offset = "0x2CDABA8", VA = "0x2CDABA8", Slot = "4")]
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
			[Address(RVA = "0x2CDABF0", Offset = "0x2CDABF0", VA = "0x2CDABF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2CD87F0", Offset = "0x2CD87F0", VA = "0x2CD87F0")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2CDA83C", Offset = "0x2CDA83C", VA = "0x2CDA83C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2CDA840", Offset = "0x2CDA840", VA = "0x2CDA840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2CDABB0", Offset = "0x2CDABB0", VA = "0x2CDABB0", Slot = "8")]
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
	[Address(RVA = "0x2CD79E4", Offset = "0x2CD79E4", VA = "0x2CD79E4")]
	public RFFade()
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x2CD7A5C", Offset = "0x2CD7A5C", VA = "0x2CD7A5C")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x2CD7A44", Offset = "0x2CD7A44", VA = "0x2CD7A44")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x2CD7AA4", Offset = "0x2CD7AA4", VA = "0x2CD7AA4")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x2CD7CBC", Offset = "0x2CD7CBC", VA = "0x2CD7CBC")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__19))]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x2CD7D58", Offset = "0x2CD7D58", VA = "0x2CD7D58")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__20))]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x2CD7BAC", Offset = "0x2CD7BAC", VA = "0x2CD7BAC")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x2CD7E68", Offset = "0x2CD7E68", VA = "0x2CD7E68")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x2CD7F64", Offset = "0x2CD7F64", VA = "0x2CD7F64")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x2CD7DF4", Offset = "0x2CD7DF4", VA = "0x2CD7DF4")]
	[IteratorStateMachine(typeof(<LivingCor>d__24))]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0x2CD7ED4", Offset = "0x2CD7ED4", VA = "0x2CD7ED4")]
	[IteratorStateMachine(typeof(<LivingCor>d__25))]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0x2CD80D0", Offset = "0x2CD80D0", VA = "0x2CD80D0")]
	[IteratorStateMachine(typeof(<SimulationLivingCor>d__26))]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0x2CD816C", Offset = "0x2CD816C", VA = "0x2CD816C")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0x2CD8348", Offset = "0x2CD8348", VA = "0x2CD8348")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0x2CD841C", Offset = "0x2CD841C", VA = "0x2CD841C")]
	[IteratorStateMachine(typeof(<FallDownCor>d__29))]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0x2CD84B8", Offset = "0x2CD84B8", VA = "0x2CD84B8")]
	[IteratorStateMachine(typeof(<FallDownCor>d__30))]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0x2CD8570", Offset = "0x2CD8570", VA = "0x2CD8570")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__31))]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0x2CD860C", Offset = "0x2CD860C", VA = "0x2CD860C")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__32))]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x2CD86C4", Offset = "0x2CD86C4", VA = "0x2CD86C4")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__33))]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x2CD8760", Offset = "0x2CD8760", VA = "0x2CD8760")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__34))]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x2CD8818", Offset = "0x2CD8818", VA = "0x2CD8818")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x2CD8A24", Offset = "0x2CD8A24", VA = "0x2CD8A24")]
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
	[Address(RVA = "0x2CDABF8", Offset = "0x2CDABF8", VA = "0x2CDABF8")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x2CDAC58", Offset = "0x2CDAC58", VA = "0x2CDAC58")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}
}
[Serializable]
[Token(Token = "0x200006C")]
public class RFLimitations
{
	[Token(Token = "0x200006D")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CDCF9C", Offset = "0x2CDCF9C", VA = "0x2CDCF9C", Slot = "4")]
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
			[Address(RVA = "0x2CDCFE4", Offset = "0x2CDCFE4", VA = "0x2CDCFE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x2CDAF38", Offset = "0x2CDAF38", VA = "0x2CDAF38")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x2CDCE84", Offset = "0x2CDCE84", VA = "0x2CDCE84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x2CDCE88", Offset = "0x2CDCE88", VA = "0x2CDCE88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x2CDCFA4", Offset = "0x2CDCFA4", VA = "0x2CDCFA4", Slot = "8")]
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
	[Address(RVA = "0x2CDAC88", Offset = "0x2CDAC88", VA = "0x2CDAC88")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x2CDAE44", Offset = "0x2CDAE44", VA = "0x2CDAE44")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x2CDAD3C", Offset = "0x2CDAD3C", VA = "0x2CDAD3C")]
	public void Reset()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x2CDAEA8", Offset = "0x2CDAEA8", VA = "0x2CDAEA8")]
	[IteratorStateMachine(typeof(<DemolishableCor>d__28))]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x2CDAF60", Offset = "0x2CDAF60", VA = "0x2CDAF60")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x2CDC944", Offset = "0x2CDC944", VA = "0x2CDC944")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x2CDCA70", Offset = "0x2CDCA70", VA = "0x2CDCA70")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0x2CDCBA8", Offset = "0x2CDCBA8", VA = "0x2CDCBA8")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0x2CDCC78", Offset = "0x2CDCC78", VA = "0x2CDCC78")]
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
		[Address(RVA = "0x2CE103C", Offset = "0x2CE103C", VA = "0x2CE103C")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000070")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CE136C", Offset = "0x2CE136C", VA = "0x2CE136C", Slot = "4")]
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
			[Address(RVA = "0x2CE13B4", Offset = "0x2CE13B4", VA = "0x2CE13B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2CE10D4", Offset = "0x2CE10D4", VA = "0x2CE10D4")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2CE1230", Offset = "0x2CE1230", VA = "0x2CE1230", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2CE1234", Offset = "0x2CE1234", VA = "0x2CE1234", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2CE1374", Offset = "0x2CE1374", VA = "0x2CE1374", Slot = "8")]
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
		[Address(RVA = "0x2CE0448", Offset = "0x2CE0448", VA = "0x2CE0448")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x2CD89CC", Offset = "0x2CD89CC", VA = "0x2CD89CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public bool Destructible
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x2CE10FC", Offset = "0x2CE10FC", VA = "0x2CE10FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003E")]
	public int Solidity
	{
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x2CE1170", Offset = "0x2CE1170", VA = "0x2CE1170")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x2CDF538", Offset = "0x2CDF538", VA = "0x2CDF538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x2CDCFEC", Offset = "0x2CDCFEC", VA = "0x2CDCFEC")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x2CDD1D0", Offset = "0x2CDD1D0", VA = "0x2CDD1D0")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x2CDD164", Offset = "0x2CDD164", VA = "0x2CDD164")]
	public void Reset()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0x2CDD248", Offset = "0x2CDD248", VA = "0x2CDD248")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x2CDD2BC", Offset = "0x2CDD2BC", VA = "0x2CDD2BC")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x2CDD318", Offset = "0x2CDD318", VA = "0x2CDD318")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x2CDD4B0", Offset = "0x2CDD4B0", VA = "0x2CDD4B0")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x2CDD5A0", Offset = "0x2CDD5A0", VA = "0x2CDD5A0")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x2CDD5E8", Offset = "0x2CDD5E8", VA = "0x2CDD5E8")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x2CDD624", Offset = "0x2CDD624", VA = "0x2CDD624")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x2CDD4EC", Offset = "0x2CDD4EC", VA = "0x2CDD4EC")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x2CDD670", Offset = "0x2CDD670", VA = "0x2CDD670")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0x2CDDB10", Offset = "0x2CDDB10", VA = "0x2CDDB10")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0x2CDD9D8", Offset = "0x2CDD9D8", VA = "0x2CDD9D8")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x6000249")]
	[Address(RVA = "0x2CDDC00", Offset = "0x2CDDC00", VA = "0x2CDDC00")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0x2CDDC3C", Offset = "0x2CDDC3C", VA = "0x2CDDC3C")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600024B")]
	[Address(RVA = "0x2CDDD18", Offset = "0x2CDDD18", VA = "0x2CDDD18")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x2CDDD5C", Offset = "0x2CDDD5C", VA = "0x2CDDD5C")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x2CDDFCC", Offset = "0x2CDDFCC", VA = "0x2CDDFCC")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x2CDE138", Offset = "0x2CDE138", VA = "0x2CDE138")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x2CDE63C", Offset = "0x2CDE63C", VA = "0x2CDE63C")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x2CDE894", Offset = "0x2CDE894", VA = "0x2CDE894")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x2CDEAB8", Offset = "0x2CDEAB8", VA = "0x2CDEAB8")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x2CDEC38", Offset = "0x2CDEC38", VA = "0x2CDEC38")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x2CDED88", Offset = "0x2CDED88", VA = "0x2CDED88")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x2CDEFDC", Offset = "0x2CDEFDC", VA = "0x2CDEFDC")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2CDF0D8", Offset = "0x2CDF0D8", VA = "0x2CDF0D8")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2CDF1D8", Offset = "0x2CDF1D8", VA = "0x2CDF1D8")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x2CDF3A8", Offset = "0x2CDF3A8", VA = "0x2CDF3A8")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x2CDF5B8", Offset = "0x2CDF5B8", VA = "0x2CDF5B8")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x2CDF64C", Offset = "0x2CDF64C", VA = "0x2CDF64C")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x2CDF754", Offset = "0x2CDF754", VA = "0x2CDF754")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x2CDF848", Offset = "0x2CDF848", VA = "0x2CDF848")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x2CDF9F4", Offset = "0x2CDF9F4", VA = "0x2CDF9F4")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x2CDFB08", Offset = "0x2CDFB08", VA = "0x2CDFB08")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x2CDFE30", Offset = "0x2CDFE30", VA = "0x2CDFE30")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x2CE0040", Offset = "0x2CE0040", VA = "0x2CE0040")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x2CE0B94", Offset = "0x2CE0B94", VA = "0x2CE0B94")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x2CE0C88", Offset = "0x2CE0C88", VA = "0x2CE0C88")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x2CE0788", Offset = "0x2CE0788", VA = "0x2CE0788")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x2CE049C", Offset = "0x2CE049C", VA = "0x2CE049C")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x2CE09AC", Offset = "0x2CE09AC", VA = "0x2CE09AC")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x2CE0E6C", Offset = "0x2CE0E6C", VA = "0x2CE0E6C")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x2CDDFC0", Offset = "0x2CDDFC0", VA = "0x2CDDFC0")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x2CE1044", Offset = "0x2CE1044", VA = "0x2CE1044")]
	[IteratorStateMachine(typeof(<PhysicsDataCor>d__71))]
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
	[Address(RVA = "0x2CE13BC", Offset = "0x2CE13BC", VA = "0x2CE13BC")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x2CE13F0", Offset = "0x2CE13F0", VA = "0x2CE13F0")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x2CE14E4", Offset = "0x2CE14E4", VA = "0x2CE14E4")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x2CE174C", Offset = "0x2CE174C", VA = "0x2CE174C")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x2CE21BC", Offset = "0x2CE21BC", VA = "0x2CE21BC")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x2CE2368", Offset = "0x2CE2368", VA = "0x2CE2368")]
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
	[Address(RVA = "0x2CE2548", Offset = "0x2CE2548", VA = "0x2CE2548")]
	public RFReset()
	{
	}

	[Token(Token = "0x600027C")]
	[Address(RVA = "0x2CE2580", Offset = "0x2CE2580", VA = "0x2CE2580")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x600027D")]
	[Address(RVA = "0x2CE25DC", Offset = "0x2CE25DC", VA = "0x2CE25DC")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027E")]
	[Address(RVA = "0x2CE302C", Offset = "0x2CE302C", VA = "0x2CE302C")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600027F")]
	[Address(RVA = "0x2CE2834", Offset = "0x2CE2834", VA = "0x2CE2834")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000280")]
	[Address(RVA = "0x2CE36C0", Offset = "0x2CE36C0", VA = "0x2CE36C0")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x2CE3844", Offset = "0x2CE3844", VA = "0x2CE3844")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x2CE3EC0", Offset = "0x2CE3EC0", VA = "0x2CE3EC0")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x2CE3C9C", Offset = "0x2CE3C9C", VA = "0x2CE3C9C")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x2CE3B2C", Offset = "0x2CE3B2C", VA = "0x2CE3B2C")]
	public static void DestroyParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x2CE40DC", Offset = "0x2CE40DC", VA = "0x2CE40DC")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x2CE3288", Offset = "0x2CE3288", VA = "0x2CE3288")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x2CE48A8", Offset = "0x2CE48A8", VA = "0x2CE48A8")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x2CE3428", Offset = "0x2CE3428", VA = "0x2CE3428")]
	public static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x2CE44C4", Offset = "0x2CE44C4", VA = "0x2CE44C4")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x2CE4F08", Offset = "0x2CE4F08", VA = "0x2CE4F08")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x2CE3368", Offset = "0x2CE3368", VA = "0x2CE3368")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x2CE270C", Offset = "0x2CE270C", VA = "0x2CE270C")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x2CE4254", Offset = "0x2CE4254", VA = "0x2CE4254")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x2CE2C50", Offset = "0x2CE2C50", VA = "0x2CE2C50")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x2CE2DC4", Offset = "0x2CE2DC4", VA = "0x2CE2DC4")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x2CE3398", Offset = "0x2CE3398", VA = "0x2CE3398")]
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
	[Range(2f, 300f)]
	public int frames;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 20f)]
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
	[Address(RVA = "0x2CE5170", Offset = "0x2CE5170", VA = "0x2CE5170")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x2CD72C0", Offset = "0x2CD72C0", VA = "0x2CD72C0")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x2CD7154", Offset = "0x2CD7154", VA = "0x2CD7154")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x2CE5194", Offset = "0x2CE5194", VA = "0x2CE5194")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x2CD7494", Offset = "0x2CD7494", VA = "0x2CD7494")]
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
	[Address(RVA = "0x2CE5314", Offset = "0x2CE5314", VA = "0x2CE5314")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x2CE5338", Offset = "0x2CE5338", VA = "0x2CE5338")]
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
	[Address(RVA = "0x2CE53D0", Offset = "0x2CE53D0", VA = "0x2CE53D0")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x2CE5414", Offset = "0x2CE5414", VA = "0x2CE5414")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x2CE5470", Offset = "0x2CE5470", VA = "0x2CE5470")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x2CE552C", Offset = "0x2CE552C", VA = "0x2CE552C")]
	private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x2CE588C", Offset = "0x2CE588C", VA = "0x2CE588C")]
	private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x2CE5AD0", Offset = "0x2CE5AD0", VA = "0x2CE5AD0")]
	private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x2CE5B8C", Offset = "0x2CE5B8C", VA = "0x2CE5B8C")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x2CE5C00", Offset = "0x2CE5C00", VA = "0x2CE5C00")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200007E")]
public static class RFFragment
{
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
	[Address(RVA = "0x2CE5C68", Offset = "0x2CE5C68", VA = "0x2CE5C68")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x2CE7208", Offset = "0x2CE7208", VA = "0x2CE7208")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x2CE7608", Offset = "0x2CE7608", VA = "0x2CE7608")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x2CD70A0", Offset = "0x2CD70A0", VA = "0x2CD70A0")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x2CE7CBC", Offset = "0x2CE7CBC", VA = "0x2CE7CBC")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x2CE8524", Offset = "0x2CE8524", VA = "0x2CE8524")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x2CD761C", Offset = "0x2CD761C", VA = "0x2CD761C")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x2CE8810", Offset = "0x2CE8810", VA = "0x2CE8810")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x2CE8494", Offset = "0x2CE8494", VA = "0x2CE8494")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x2CE6304", Offset = "0x2CE6304", VA = "0x2CE6304")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x2CE8980", Offset = "0x2CE8980", VA = "0x2CE8980")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x2CE6BA8", Offset = "0x2CE6BA8", VA = "0x2CE6BA8")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x2CE6240", Offset = "0x2CE6240", VA = "0x2CE6240")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x2CE9038", Offset = "0x2CE9038", VA = "0x2CE9038")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x2CE679C", Offset = "0x2CE679C", VA = "0x2CE679C")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x2CE7E50", Offset = "0x2CE7E50", VA = "0x2CE7E50")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x2CE63EC", Offset = "0x2CE63EC", VA = "0x2CE63EC")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x2CEA3B8", Offset = "0x2CEA3B8", VA = "0x2CEA3B8")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x2CEA538", Offset = "0x2CEA538", VA = "0x2CEA538")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x2CE90AC", Offset = "0x2CE90AC", VA = "0x2CE90AC")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x2CE9210", Offset = "0x2CE9210", VA = "0x2CE9210")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x2CE938C", Offset = "0x2CE938C", VA = "0x2CE938C")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x2CE9508", Offset = "0x2CE9508", VA = "0x2CE9508")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x2CE97BC", Offset = "0x2CE97BC", VA = "0x2CE97BC")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x2CEA7FC", Offset = "0x2CEA7FC", VA = "0x2CEA7FC")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x2CE98A8", Offset = "0x2CE98A8", VA = "0x2CE98A8")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x2CE9C20", Offset = "0x2CE9C20", VA = "0x2CE9C20")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x2CE9E78", Offset = "0x2CE9E78", VA = "0x2CE9E78")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x2CEA8B4", Offset = "0x2CEA8B4", VA = "0x2CEA8B4")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x2CE9F44", Offset = "0x2CE9F44", VA = "0x2CE9F44")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x2CEA160", Offset = "0x2CEA160", VA = "0x2CEA160")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x2CEA1B8", Offset = "0x2CEA1B8", VA = "0x2CEA1B8")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x2CEA614", Offset = "0x2CEA614", VA = "0x2CEA614")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x2CEA718", Offset = "0x2CEA718", VA = "0x2CEA718")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x2CEA8C8", Offset = "0x2CEA8C8", VA = "0x2CEA8C8")]
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
	[Address(RVA = "0x2CEAB90", Offset = "0x2CEAB90", VA = "0x2CEAB90")]
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
	[Address(RVA = "0x2CEABE8", Offset = "0x2CEABE8", VA = "0x2CEABE8")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x2CEAC3C", Offset = "0x2CEAC3C", VA = "0x2CEAC3C")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x2CEACC0", Offset = "0x2CEACC0", VA = "0x2CEACC0")]
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
	[Address(RVA = "0x2CEB5E4", Offset = "0x2CEB5E4", VA = "0x2CEB5E4")]
	public RFSurface()
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x2CEB628", Offset = "0x2CEB628", VA = "0x2CEB628")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x2CEB674", Offset = "0x2CEB674", VA = "0x2CEB674")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x2CEB910", Offset = "0x2CEB910", VA = "0x2CEB910")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x2CEBA5C", Offset = "0x2CEBA5C", VA = "0x2CEBA5C")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000085")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-activator-component/")]
[AddComponentMenu("RayFire/Rayfire Activator")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2CEDD80", Offset = "0x2CEDD80", VA = "0x2CEDD80", Slot = "4")]
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
			[Address(RVA = "0x2CEDDC8", Offset = "0x2CEDDC8", VA = "0x2CEDDC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x2CEC7B0", Offset = "0x2CEC7B0", VA = "0x2CEC7B0")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x2CEDC7C", Offset = "0x2CEDC7C", VA = "0x2CEDC7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x2CEDC80", Offset = "0x2CEDC80", VA = "0x2CEDC80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x2CEDD88", Offset = "0x2CEDD88", VA = "0x2CEDD88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CEDF98", Offset = "0x2CEDF98", VA = "0x2CEDF98", Slot = "4")]
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
			[Address(RVA = "0x2CEDFE0", Offset = "0x2CEDFE0", VA = "0x2CEDFE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x2CEC7D8", Offset = "0x2CEC7D8", VA = "0x2CEC7D8")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x2CEDDD0", Offset = "0x2CEDDD0", VA = "0x2CEDDD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x2CEDDD4", Offset = "0x2CEDDD4", VA = "0x2CEDDD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x2CEDFA0", Offset = "0x2CEDFA0", VA = "0x2CEDFA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CEE0EC", Offset = "0x2CEE0EC", VA = "0x2CEE0EC", Slot = "4")]
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
			[Address(RVA = "0x2CEE134", Offset = "0x2CEE134", VA = "0x2CEE134", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x2CECB68", Offset = "0x2CECB68", VA = "0x2CECB68")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x2CEDFE8", Offset = "0x2CEDFE8", VA = "0x2CEDFE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x2CEDFEC", Offset = "0x2CEDFEC", VA = "0x2CEDFEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x2CEE0F4", Offset = "0x2CEE0F4", VA = "0x2CEE0F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CEE488", Offset = "0x2CEE488", VA = "0x2CEE488", Slot = "4")]
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
			[Address(RVA = "0x2CEE4D0", Offset = "0x2CEE4D0", VA = "0x2CEE4D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x2CED5E4", Offset = "0x2CED5E4", VA = "0x2CED5E4")]
		[DebuggerHidden]
		public <AnimationCor>d__58(int <>1__state)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x2CEE13C", Offset = "0x2CEE13C", VA = "0x2CEE13C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x2CEE140", Offset = "0x2CEE140", VA = "0x2CEE140", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x2CEE490", Offset = "0x2CEE490", VA = "0x2CEE490", Slot = "8")]
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
		[Address(RVA = "0x2CEDBB0", Offset = "0x2CEDBB0", VA = "0x2CEDBB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public bool ByLine
	{
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x2CECD20", Offset = "0x2CECD20", VA = "0x2CECD20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x2CEBBA8", Offset = "0x2CEBBA8", VA = "0x2CEBBA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x2CEC054", Offset = "0x2CEC054", VA = "0x2CEC054")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x2CEC0EC", Offset = "0x2CEC0EC", VA = "0x2CEC0EC")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x2CEC220", Offset = "0x2CEC220", VA = "0x2CEC220")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x2CEC230", Offset = "0x2CEC230", VA = "0x2CEC230")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0x2CEBC14", Offset = "0x2CEBC14", VA = "0x2CEBC14")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0x2CEBE68", Offset = "0x2CEBE68", VA = "0x2CEBE68")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0x2CEC0A0", Offset = "0x2CEC0A0", VA = "0x2CEC0A0")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0x2CEC244", Offset = "0x2CEC244", VA = "0x2CEC244")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0x2CEC67C", Offset = "0x2CEC67C", VA = "0x2CEC67C")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__46))]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0x2CEC70C", Offset = "0x2CEC70C", VA = "0x2CEC70C")]
	[IteratorStateMachine(typeof(<DelayedClusterCor>d__47))]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0x2CEC638", Offset = "0x2CEC638", VA = "0x2CEC638")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x2CEC480", Offset = "0x2CEC480", VA = "0x2CEC480")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x2CECAC4", Offset = "0x2CECAC4", VA = "0x2CECAC4")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__50))]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0x2CEC960", Offset = "0x2CEC960", VA = "0x2CEC960")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0x2CEC800", Offset = "0x2CEC800", VA = "0x2CEC800")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x2CECB90", Offset = "0x2CECB90", VA = "0x2CECB90")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x2CECC6C", Offset = "0x2CECC6C", VA = "0x2CECC6C")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x2CECD34", Offset = "0x2CECD34", VA = "0x2CECD34")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x2CECFF0", Offset = "0x2CECFF0", VA = "0x2CECFF0")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x2CED244", Offset = "0x2CED244", VA = "0x2CED244")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x2CECCAC", Offset = "0x2CECCAC", VA = "0x2CECCAC")]
	[IteratorStateMachine(typeof(<AnimationCor>d__58))]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x2CED60C", Offset = "0x2CED60C", VA = "0x2CED60C")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x2CED6FC", Offset = "0x2CED6FC", VA = "0x2CED6FC")]
	private void ResetData()
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2CED75C", Offset = "0x2CED75C", VA = "0x2CED75C")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2CED764", Offset = "0x2CED764", VA = "0x2CED764")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2CED798", Offset = "0x2CED798", VA = "0x2CED798")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2CEDB04", Offset = "0x2CEDB04", VA = "0x2CEDB04")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x2CEDBCC", Offset = "0x2CEDBCC", VA = "0x2CEDBCC")]
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
	[Address(RVA = "0x2CEE4D8", Offset = "0x2CEE4D8", VA = "0x2CEE4D8")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x200008E")]
[AddComponentMenu("RayFire/Rayfire Blade")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-blade-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2CEF458", Offset = "0x2CEF458", VA = "0x2CEF458", Slot = "4")]
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
			[Address(RVA = "0x2CEF4A0", Offset = "0x2CEF4A0", VA = "0x2CEF4A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x2CEEEEC", Offset = "0x2CEEEEC", VA = "0x2CEEEEC")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x2CEF378", Offset = "0x2CEF378", VA = "0x2CEF378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x2CEF37C", Offset = "0x2CEF37C", VA = "0x2CEF37C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x2CEF460", Offset = "0x2CEF460", VA = "0x2CEF460", Slot = "8")]
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
		[Address(RVA = "0x2CEF268", Offset = "0x2CEF268", VA = "0x2CEF268")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x2CEE4E0", Offset = "0x2CEE4E0", VA = "0x2CEE4E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x2CEE4E4", Offset = "0x2CEE4E4", VA = "0x2CEE4E4")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x2CEE708", Offset = "0x2CEE708", VA = "0x2CEE708")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x2CEE7CC", Offset = "0x2CEE7CC", VA = "0x2CEE7CC")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x2CEE70C", Offset = "0x2CEE70C", VA = "0x2CEE70C")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x2CEE7D0", Offset = "0x2CEE7D0", VA = "0x2CEE7D0")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0x2CEEC6C", Offset = "0x2CEEC6C", VA = "0x2CEEC6C")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x2CEEE78", Offset = "0x2CEEE78", VA = "0x2CEEE78")]
	[IteratorStateMachine(typeof(<CooldownCor>d__31))]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x2CEEF14", Offset = "0x2CEEF14", VA = "0x2CEEF14")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x2CEED80", Offset = "0x2CEED80", VA = "0x2CEED80")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x2CEEF3C", Offset = "0x2CEEF3C", VA = "0x2CEEF3C")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x2CEEAB8", Offset = "0x2CEEAB8", VA = "0x2CEEAB8")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x2CEEE30", Offset = "0x2CEEE30", VA = "0x2CEEE30")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x2CEE9D0", Offset = "0x2CEE9D0", VA = "0x2CEE9D0")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x2CEF040", Offset = "0x2CEF040", VA = "0x2CEF040")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x2CEEF20", Offset = "0x2CEEF20", VA = "0x2CEEF20")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x2CEF2BC", Offset = "0x2CEF2BC", VA = "0x2CEF2BC")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000092")]
[AddComponentMenu("RayFire/Rayfire Bomb")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-bomb-component/")]
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
		[Address(RVA = "0x2CF0F34", Offset = "0x2CF0F34", VA = "0x2CF0F34")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CF140C", Offset = "0x2CF140C", VA = "0x2CF140C", Slot = "4")]
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
			[Address(RVA = "0x2CF1454", Offset = "0x2CF1454", VA = "0x2CF1454", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x2CEF7E0", Offset = "0x2CEF7E0", VA = "0x2CEF7E0")]
		[DebuggerHidden]
		public <ExplodeCor>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x2CF134C", Offset = "0x2CF134C", VA = "0x2CF134C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x2CF1350", Offset = "0x2CF1350", VA = "0x2CF1350", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x2CF1414", Offset = "0x2CF1414", VA = "0x2CF1414", Slot = "8")]
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
	[Address(RVA = "0x2CEF4A8", Offset = "0x2CEF4A8", VA = "0x2CEF4A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x2CEF568", Offset = "0x2CEF568", VA = "0x2CEF568")]
	private void Start()
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x2CEF5E0", Offset = "0x2CEF5E0", VA = "0x2CEF5E0")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x2CEF59C", Offset = "0x2CEF59C", VA = "0x2CEF59C")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x2CEF76C", Offset = "0x2CEF76C", VA = "0x2CEF76C")]
	[IteratorStateMachine(typeof(<ExplodeCor>d__36))]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x2CEF664", Offset = "0x2CEF664", VA = "0x2CEF664")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x2CF0480", Offset = "0x2CF0480", VA = "0x2CF0480")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x2CEF8AC", Offset = "0x2CEF8AC", VA = "0x2CEF8AC")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x2CEF4AC", Offset = "0x2CEF4AC", VA = "0x2CEF4AC")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x2CF0CAC", Offset = "0x2CF0CAC", VA = "0x2CF0CAC")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x2CF0CC8", Offset = "0x2CF0CC8", VA = "0x2CF0CC8")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x2CEF808", Offset = "0x2CEF808", VA = "0x2CEF808")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x2CF053C", Offset = "0x2CF053C", VA = "0x2CF053C")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x2CF0580", Offset = "0x2CF0580", VA = "0x2CF0580")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x6000338")]
	[Address(RVA = "0x2CEF914", Offset = "0x2CEF914", VA = "0x2CEF914")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0x2CEFB28", Offset = "0x2CEFB28", VA = "0x2CEFB28")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0x2CEFE90", Offset = "0x2CEFE90", VA = "0x2CEFE90")]
	private void Activate()
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x2CF0214", Offset = "0x2CF0214", VA = "0x2CF0214")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x2CF0F3C", Offset = "0x2CF0F3C", VA = "0x2CF0F3C")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x2CF1084", Offset = "0x2CF1084", VA = "0x2CF1084")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x2CF11B4", Offset = "0x2CF11B4", VA = "0x2CF11B4")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000097")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-cluster-component/")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Cluster")]
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

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	[Header("  Properties")]
	[Space(2f)]
	public ClusterType type;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(1f, 7f)]
	public int depth;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 100f)]
	public int seed;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 4f)]
	public int smoothPass;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	[Header("  By Point Cloud")]
	[Range(2f, 100f)]
	public int baseAmount;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(2f, 50f)]
	public int depthAmount;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("  By Shared Area")]
	[Range(2f, 8f)]
	[Space(2f)]
	public int minimumAmount;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(2f, 8f)]
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
	[Address(RVA = "0x2CF145C", Offset = "0x2CF145C", VA = "0x2CF145C")]
	public void Extract()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x2CF16C0", Offset = "0x2CF16C0", VA = "0x2CF16C0")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x2CF1774", Offset = "0x2CF1774", VA = "0x2CF1774")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x2CF212C", Offset = "0x2CF212C", VA = "0x2CF212C")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x2CF3A68", Offset = "0x2CF3A68", VA = "0x2CF3A68")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x2CF1A68", Offset = "0x2CF1A68", VA = "0x2CF1A68")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x2CF488C", Offset = "0x2CF488C", VA = "0x2CF488C")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x2CF4EA8", Offset = "0x2CF4EA8", VA = "0x2CF4EA8")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x2CF3074", Offset = "0x2CF3074", VA = "0x2CF3074")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x2CF5934", Offset = "0x2CF5934", VA = "0x2CF5934")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x2CF2E50", Offset = "0x2CF2E50", VA = "0x2CF2E50")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x2CF62F8", Offset = "0x2CF62F8", VA = "0x2CF62F8")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x2CF572C", Offset = "0x2CF572C", VA = "0x2CF572C")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0x2CF200C", Offset = "0x2CF200C", VA = "0x2CF200C")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0x2CF2A60", Offset = "0x2CF2A60", VA = "0x2CF2A60")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x6000355")]
	[Address(RVA = "0x2CF466C", Offset = "0x2CF466C", VA = "0x2CF466C")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x6000356")]
	[Address(RVA = "0x2CF6420", Offset = "0x2CF6420", VA = "0x2CF6420")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000357")]
	[Address(RVA = "0x2CF5370", Offset = "0x2CF5370", VA = "0x2CF5370")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x6000358")]
	[Address(RVA = "0x2CF2C94", Offset = "0x2CF2C94", VA = "0x2CF2C94")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x6000359")]
	[Address(RVA = "0x2CF6840", Offset = "0x2CF6840", VA = "0x2CF6840")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x200009B")]
public class RFCombineMesh
{
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
	[Address(RVA = "0x2CF69A4", Offset = "0x2CF69A4", VA = "0x2CF69A4")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x2CF6B9C", Offset = "0x2CF6B9C", VA = "0x2CF6B9C")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x2CF72FC", Offset = "0x2CF72FC", VA = "0x2CF72FC")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x2CF74C4", Offset = "0x2CF74C4", VA = "0x2CF74C4")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x2CF769C", Offset = "0x2CF769C", VA = "0x2CF769C")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x2CF7BEC", Offset = "0x2CF7BEC", VA = "0x2CF7BEC")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x2CF7DFC", Offset = "0x2CF7DFC", VA = "0x2CF7DFC")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x2CF8044", Offset = "0x2CF8044", VA = "0x2CF8044")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x200009F")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-combine-component/")]
[AddComponentMenu("RayFire/Rayfire Combine")]
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
	[Address(RVA = "0x2CF8380", Offset = "0x2CF8380", VA = "0x2CF8380")]
	public void Combine()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0x2CF8444", Offset = "0x2CF8444", VA = "0x2CF8444")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x2CFA060", Offset = "0x2CFA060", VA = "0x2CFA060")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x20000A1")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Connectivity")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-connectivity-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2CFDE50", Offset = "0x2CFDE50", VA = "0x2CFDE50", Slot = "4")]
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
			[Address(RVA = "0x2CFDE98", Offset = "0x2CFDE98", VA = "0x2CFDE98", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x2CFBA08", Offset = "0x2CFBA08", VA = "0x2CFBA08")]
		[DebuggerHidden]
		public <ConnectivityCor>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x2CFDD9C", Offset = "0x2CFDD9C", VA = "0x2CFDD9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x2CFDDA0", Offset = "0x2CFDDA0", VA = "0x2CFDDA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x2CFDE58", Offset = "0x2CFDE58", VA = "0x2CFDE58", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A4")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2CFDF3C", Offset = "0x2CFDF3C", VA = "0x2CFDF3C", Slot = "4")]
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
			[Address(RVA = "0x2CFDF84", Offset = "0x2CFDF84", VA = "0x2CFDF84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x2CFD0C8", Offset = "0x2CFD0C8", VA = "0x2CFD0C8")]
		[DebuggerHidden]
		public <ChildrenCor>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x2CFDEA0", Offset = "0x2CFDEA0", VA = "0x2CFDEA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x2CFDEA4", Offset = "0x2CFDEA4", VA = "0x2CFDEA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x2CFDF44", Offset = "0x2CFDF44", VA = "0x2CFDF44", Slot = "8")]
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
		[Address(RVA = "0x2CFBD00", Offset = "0x2CFBD00", VA = "0x2CFBD00")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x2CFA088", Offset = "0x2CFA088", VA = "0x2CFA088")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x2CFA1C4", Offset = "0x2CFA1C4", VA = "0x2CFA1C4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000372")]
	[Address(RVA = "0x2CFA1D0", Offset = "0x2CFA1D0", VA = "0x2CFA1D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x2CFA3B4", Offset = "0x2CFA3B4", VA = "0x2CFA3B4")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x2CFA55C", Offset = "0x2CFA55C", VA = "0x2CFA55C")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x2CFABF0", Offset = "0x2CFABF0", VA = "0x2CFABF0")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x2CFAC74", Offset = "0x2CFAC74", VA = "0x2CFAC74")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x2CFADF0", Offset = "0x2CFADF0", VA = "0x2CFADF0")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x2CFA708", Offset = "0x2CFA708", VA = "0x2CFA708")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x2CFA9A0", Offset = "0x2CFA9A0", VA = "0x2CFA9A0")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0x2CFB5A8", Offset = "0x2CFB5A8", VA = "0x2CFB5A8")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0x2CFAED4", Offset = "0x2CFAED4", VA = "0x2CFAED4")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0x2CFB0FC", Offset = "0x2CFB0FC", VA = "0x2CFB0FC")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0x2CFB670", Offset = "0x2CFB670", VA = "0x2CFB670")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0x2CFA340", Offset = "0x2CFA340", VA = "0x2CFA340")]
	[IteratorStateMachine(typeof(<ConnectivityCor>d__49))]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0x2CFBA30", Offset = "0x2CFBA30", VA = "0x2CFBA30")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x2CFBC0C", Offset = "0x2CFBC0C", VA = "0x2CFBC0C")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0x2CFBB18", Offset = "0x2CFBB18", VA = "0x2CFBB18")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x2CFC0FC", Offset = "0x2CFC0FC", VA = "0x2CFC0FC")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x2CFC5A4", Offset = "0x2CFC5A4", VA = "0x2CFC5A4")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x2CFBD6C", Offset = "0x2CFBD6C", VA = "0x2CFBD6C")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x2CFBF10", Offset = "0x2CFBF10", VA = "0x2CFBF10")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x2CFC2D4", Offset = "0x2CFC2D4", VA = "0x2CFC2D4")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x2CFC3B8", Offset = "0x2CFC3B8", VA = "0x2CFC3B8")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x2CFD0BC", Offset = "0x2CFD0BC", VA = "0x2CFD0BC")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x2CFA2CC", Offset = "0x2CFA2CC", VA = "0x2CFA2CC")]
	[IteratorStateMachine(typeof(<ChildrenCor>d__60))]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x2CFD0F0", Offset = "0x2CFD0F0", VA = "0x2CFD0F0")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x2CFD3A4", Offset = "0x2CFD3A4", VA = "0x2CFD3A4")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x2CFA874", Offset = "0x2CFA874", VA = "0x2CFA874")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x2CFD3D8", Offset = "0x2CFD3D8", VA = "0x2CFD3D8")]
	public void Fracture()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x2CFD3E4", Offset = "0x2CFD3E4", VA = "0x2CFD3E4")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x2CFD888", Offset = "0x2CFD888", VA = "0x2CFD888")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x2CFDCF4", Offset = "0x2CFDCF4", VA = "0x2CFDCF4")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x20000A5")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Debris")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-debris-component/")]
public class RayfireDebris : MonoBehaviour
{
	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Debris")]
	public bool onDemolition;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Main")]
	[Space(3f)]
	public GameObject debrisReference;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public Material debrisMaterial;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("  Properties")]
	[Space(3f)]
	public RFParticleEmission emission;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(3f)]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(3f)]
	public RFParticleNoise noise;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(3f)]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(3f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(3f)]
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
		[Address(RVA = "0x2CFEEC8", Offset = "0x2CFEEC8", VA = "0x2CFEEC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x2CFDF8C", Offset = "0x2CFDF8C", VA = "0x2CFDF8C")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x2CFE210", Offset = "0x2CFE210", VA = "0x2CFE210")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x2CFE30C", Offset = "0x2CFE30C", VA = "0x2CFE30C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x2CFE8BC", Offset = "0x2CFE8BC", VA = "0x2CFE8BC")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x2CFECE8", Offset = "0x2CFECE8", VA = "0x2CFECE8")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x2CFE9F4", Offset = "0x2CFE9F4", VA = "0x2CFE9F4")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x2CFEF1C", Offset = "0x2CFEF1C", VA = "0x2CFEF1C")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x2CFE320", Offset = "0x2CFE320", VA = "0x2CFE320")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x2CFF17C", Offset = "0x2CFF17C", VA = "0x2CFF17C")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x20000A7")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Dust")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-dust-component/")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Dust")]
	public bool onDemolition;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Main")]
	[Range(0.01f, 1f)]
	[Space(3f)]
	public float opacity;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(2f)]
	public Material dustMaterial;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public List<Material> dustMaterials;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("  Properties")]
	[Space(3f)]
	public RFParticleEmission emission;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(2f)]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(2f)]
	public RFParticleNoise noise;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(2f)]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(2f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(2f)]
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
		[Address(RVA = "0x2CFFF84", Offset = "0x2CFFF84", VA = "0x2CFFF84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000058")]
	public bool HasMaterials
	{
		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x2CFF96C", Offset = "0x2CFF96C", VA = "0x2CFF96C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003AC")]
	[Address(RVA = "0x2CFF484", Offset = "0x2CFF484", VA = "0x2CFF484")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003AD")]
	[Address(RVA = "0x2CFF674", Offset = "0x2CFF674", VA = "0x2CFF674")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003AE")]
	[Address(RVA = "0x2CFF768", Offset = "0x2CFF768", VA = "0x2CFF768")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003AF")]
	[Address(RVA = "0x2CFF9C0", Offset = "0x2CFF9C0", VA = "0x2CFF9C0")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x2CFFDA4", Offset = "0x2CFFDA4", VA = "0x2CFFDA4")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x2CFFAD8", Offset = "0x2CFFAD8", VA = "0x2CFFAD8")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x2CFFFD8", Offset = "0x2CFFFD8", VA = "0x2CFFFD8")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x2D00140", Offset = "0x2D00140", VA = "0x2D00140")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x20000A8")]
[AddComponentMenu("RayFire/Rayfire Gun")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-gun-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2D02778", Offset = "0x2D02778", VA = "0x2D02778", Slot = "4")]
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
			[Address(RVA = "0x2D027C0", Offset = "0x2D027C0", VA = "0x2D027C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x2D002CC", Offset = "0x2D002CC", VA = "0x2D002CC")]
		[DebuggerHidden]
		public <StartShootCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x2D0268C", Offset = "0x2D0268C", VA = "0x2D0268C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x2D02690", Offset = "0x2D02690", VA = "0x2D02690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x2D02780", Offset = "0x2D02780", VA = "0x2D02780", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2D028C0", Offset = "0x2D028C0", VA = "0x2D028C0", Slot = "4")]
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
			[Address(RVA = "0x2D02908", Offset = "0x2D02908", VA = "0x2D02908", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x2D00AE0", Offset = "0x2D00AE0", VA = "0x2D00AE0")]
		[DebuggerHidden]
		public <BurstCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x2D027C8", Offset = "0x2D027C8", VA = "0x2D027C8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x2D027CC", Offset = "0x2D027CC", VA = "0x2D027CC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x2D028C8", Offset = "0x2D028C8", VA = "0x2D028C8", Slot = "8")]
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
	[FormerlySerializedAs("affectRigidBodies")]
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
		[Address(RVA = "0x2D00374", Offset = "0x2D00374", VA = "0x2D00374")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x2D00228", Offset = "0x2D00228", VA = "0x2D00228")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x2D00258", Offset = "0x2D00258", VA = "0x2D00258")]
	[IteratorStateMachine(typeof(<StartShootCor>d__28))]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x2D002F4", Offset = "0x2D002F4", VA = "0x2D002F4")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x2D002FC", Offset = "0x2D002FC", VA = "0x2D002FC")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x2D00A3C", Offset = "0x2D00A3C", VA = "0x2D00A3C")]
	public void Burst()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x2D00A6C", Offset = "0x2D00A6C", VA = "0x2D00A6C")]
	[IteratorStateMachine(typeof(<BurstCor>d__32))]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x2D00550", Offset = "0x2D00550", VA = "0x2D00550")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x2D01234", Offset = "0x2D01234", VA = "0x2D01234")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x2D01A68", Offset = "0x2D01A68", VA = "0x2D01A68")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x2D01F38", Offset = "0x2D01F38", VA = "0x2D01F38")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x2D00FF4", Offset = "0x2D00FF4", VA = "0x2D00FF4")]
	private RayfireRigid ApplyDamage(RayfireRigid scrRigid, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x2D00B08", Offset = "0x2D00B08", VA = "0x2D00B08")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x2D00CDC", Offset = "0x2D00CDC", VA = "0x2D00CDC")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x2D00E68", Offset = "0x2D00E68", VA = "0x2D00E68")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x2D0212C", Offset = "0x2D0212C", VA = "0x2D0212C")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x2D024F8", Offset = "0x2D024F8", VA = "0x2D024F8")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x20000AC")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Man")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-man-component/")]
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
	[FormerlySerializedAs("collisionDetection")]
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
		[Address(RVA = "0x2D03240", Offset = "0x2D03240", VA = "0x2D03240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x2D02910", Offset = "0x2D02910", VA = "0x2D02910")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x2D02B60", Offset = "0x2D02B60", VA = "0x2D02B60")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x2D02B68", Offset = "0x2D02B68", VA = "0x2D02B68")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x2D02914", Offset = "0x2D02914", VA = "0x2D02914")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x2D02E48", Offset = "0x2D02E48", VA = "0x2D02E48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003D9")]
	[Address(RVA = "0x2D02E7C", Offset = "0x2D02E7C", VA = "0x2D02E7C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x2D02B6C", Offset = "0x2D02B6C", VA = "0x2D02B6C")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003DB")]
	[Address(RVA = "0x2D02ECC", Offset = "0x2D02ECC", VA = "0x2D02ECC")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x60003DC")]
	[Address(RVA = "0x2D030D8", Offset = "0x2D030D8", VA = "0x2D030D8")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x60003DD")]
	[Address(RVA = "0x2D02F4C", Offset = "0x2D02F4C", VA = "0x2D02F4C")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x60003DF")]
	[Address(RVA = "0x2D02C30", Offset = "0x2D02C30", VA = "0x2D02C30")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x60003E0")]
	[Address(RVA = "0x2D02D60", Offset = "0x2D02D60", VA = "0x2D02D60")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x60003E1")]
	[Address(RVA = "0x2D032B8", Offset = "0x2D032B8", VA = "0x2D032B8")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x2D0342C", Offset = "0x2D0342C", VA = "0x2D0342C")]
	public static void SetParentToManager(Transform tm)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x2D034CC", Offset = "0x2D034CC", VA = "0x2D034CC")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x2D03600", Offset = "0x2D03600", VA = "0x2D03600")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x2D03834", Offset = "0x2D03834", VA = "0x2D03834")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60003E6")]
	[Address(RVA = "0x2D038EC", Offset = "0x2D038EC", VA = "0x2D038EC")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x60003E7")]
	[Address(RVA = "0x2D036F0", Offset = "0x2D036F0", VA = "0x2D036F0")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x2D03944", Offset = "0x2D03944", VA = "0x2D03944")]
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
	[Address(RVA = "0x2D03B04", Offset = "0x2D03B04", VA = "0x2D03B04")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x20000AE")]
[AddComponentMenu("RayFire/Rayfire Recorder")]
[SelectionBase]
[DisallowMultipleComponent]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-recorder-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2D053EC", Offset = "0x2D053EC", VA = "0x2D053EC", Slot = "4")]
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
			[Address(RVA = "0x2D05434", Offset = "0x2D05434", VA = "0x2D05434", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x2D04EEC", Offset = "0x2D04EEC", VA = "0x2D04EEC")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x2D04F98", Offset = "0x2D04F98", VA = "0x2D04F98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x2D04F9C", Offset = "0x2D04F9C", VA = "0x2D04F9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x2D053F4", Offset = "0x2D053F4", VA = "0x2D053F4", Slot = "8")]
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
	[Address(RVA = "0x2D03D78", Offset = "0x2D03D78", VA = "0x2D03D78")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x2D04128", Offset = "0x2D04128", VA = "0x2D04128")]
	private void Start()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x2D04178", Offset = "0x2D04178", VA = "0x2D04178")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x2D03D7C", Offset = "0x2D03D7C", VA = "0x2D03D7C")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x2D04474", Offset = "0x2D04474", VA = "0x2D04474")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x2D04744", Offset = "0x2D04744", VA = "0x2D04744")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x60003F1")]
	[Address(RVA = "0x2D04E44", Offset = "0x2D04E44", VA = "0x2D04E44")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x2D043BC", Offset = "0x2D043BC", VA = "0x2D043BC")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x2D04E78", Offset = "0x2D04E78", VA = "0x2D04E78")]
	[IteratorStateMachine(typeof(<RecordCor>d__30))]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x2D04F14", Offset = "0x2D04F14", VA = "0x2D04F14")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x2D04428", Offset = "0x2D04428", VA = "0x2D04428")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x2D04F1C", Offset = "0x2D04F1C", VA = "0x2D04F1C")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x20000B1")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-restriction-component/")]
[DisallowMultipleComponent]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Restriction")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x2D05D1C", Offset = "0x2D05D1C", VA = "0x2D05D1C", Slot = "4")]
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
			[Address(RVA = "0x2D05D64", Offset = "0x2D05D64", VA = "0x2D05D64", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x2D05998", Offset = "0x2D05998", VA = "0x2D05998")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x2D059E8", Offset = "0x2D059E8", VA = "0x2D059E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x2D059EC", Offset = "0x2D059EC", VA = "0x2D059EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x2D05D24", Offset = "0x2D05D24", VA = "0x2D05D24", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2D06118", Offset = "0x2D06118", VA = "0x2D06118", Slot = "4")]
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
			[Address(RVA = "0x2D06160", Offset = "0x2D06160", VA = "0x2D06160", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x2D059C0", Offset = "0x2D059C0", VA = "0x2D059C0")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x2D05D6C", Offset = "0x2D05D6C", VA = "0x2D05D6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x2D05D70", Offset = "0x2D05D70", VA = "0x2D05D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x2D06120", Offset = "0x2D06120", VA = "0x2D06120", Slot = "8")]
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
	[Address(RVA = "0x2D0543C", Offset = "0x2D0543C", VA = "0x2D0543C")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x2D054A0", Offset = "0x2D054A0", VA = "0x2D054A0")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x2D05498", Offset = "0x2D05498", VA = "0x2D05498")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x2D0550C", Offset = "0x2D0550C", VA = "0x2D0550C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x2D055C4", Offset = "0x2D055C4", VA = "0x2D055C4")]
	public static void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x2D058A8", Offset = "0x2D058A8", VA = "0x2D058A8")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x2D057C0", Offset = "0x2D057C0", VA = "0x2D057C0")]
	[IteratorStateMachine(typeof(<RestrictionDistanceCor>d__19))]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x2D05834", Offset = "0x2D05834", VA = "0x2D05834")]
	[IteratorStateMachine(typeof(<RestrictionTriggerCor>d__20))]
	private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x20000B7")]
[AddComponentMenu("RayFire/Rayfire Rigid")]
[SelectionBase]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-component/")]
[DisallowMultipleComponent]
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
		[Address(RVA = "0x2D020D8", Offset = "0x2D020D8", VA = "0x2D020D8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public bool HasMeshes
	{
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2D09E38", Offset = "0x2D09E38", VA = "0x2D09E38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000067")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2D09E58", Offset = "0x2D09E58", VA = "0x2D09E58")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000068")]
	public bool HasDebris
	{
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2D09E78", Offset = "0x2D09E78", VA = "0x2D09E78")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000069")]
	public bool HasDust
	{
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2D09ECC", Offset = "0x2D09ECC", VA = "0x2D09ECC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public bool HasSlices
	{
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x2D099B4", Offset = "0x2D099B4", VA = "0x2D099B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public bool IsCluster
	{
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x2D09F20", Offset = "0x2D09F20", VA = "0x2D09F20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x2D09F34", Offset = "0x2D09F34", VA = "0x2D09F34")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0x2D06168", Offset = "0x2D06168", VA = "0x2D06168")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x2D0622C", Offset = "0x2D0622C", VA = "0x2D0622C")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x2D06268", Offset = "0x2D06268", VA = "0x2D06268")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x2D06E44", Offset = "0x2D06E44", VA = "0x2D06E44")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x2D06E8C", Offset = "0x2D06E8C", VA = "0x2D06E8C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x2D06ED4", Offset = "0x2D06ED4", VA = "0x2D06ED4")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x2D0707C", Offset = "0x2D0707C", VA = "0x2D0707C")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x2D06440", Offset = "0x2D06440", VA = "0x2D06440")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x2D06A44", Offset = "0x2D06A44", VA = "0x2D06A44")]
	private void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x2D06F5C", Offset = "0x2D06F5C", VA = "0x2D06F5C")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x2D066EC", Offset = "0x2D066EC", VA = "0x2D066EC")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x2D074B4", Offset = "0x2D074B4", VA = "0x2D074B4")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x2D076C4", Offset = "0x2D076C4", VA = "0x2D076C4")]
	private void AddMeshRootRigid()
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x2D07CB0", Offset = "0x2D07CB0", VA = "0x2D07CB0")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x2D07104", Offset = "0x2D07104", VA = "0x2D07104")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x2D06CE8", Offset = "0x2D06CE8", VA = "0x2D06CE8")]
	private void SetObjectType()
	{
	}

	[Token(Token = "0x6000421")]
	[Address(RVA = "0x2D06C10", Offset = "0x2D06C10", VA = "0x2D06C10")]
	public void Default()
	{
	}

	[Token(Token = "0x6000422")]
	[Address(RVA = "0x2D08008", Offset = "0x2D08008", VA = "0x2D08008")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000423")]
	[Address(RVA = "0x2D06D28", Offset = "0x2D06D28", VA = "0x2D06D28")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x2D081A0", Offset = "0x2D081A0", VA = "0x2D081A0")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x2D06194", Offset = "0x2D06194", VA = "0x2D06194")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x2D0829C", Offset = "0x2D0829C", VA = "0x2D0829C", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x2D08380", Offset = "0x2D08380", VA = "0x2D08380", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x2D086F4", Offset = "0x2D086F4", VA = "0x2D086F4")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x2D08828", Offset = "0x2D08828", VA = "0x2D08828", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x2D08990", Offset = "0x2D08990", VA = "0x2D08990")]
	public void Demolish()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x2D07DD0", Offset = "0x2D07DD0", VA = "0x2D07DD0")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x2D09214", Offset = "0x2D09214", VA = "0x2D09214")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x2D09368", Offset = "0x2D09368", VA = "0x2D09368")]
	public void Prefragment()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x2D0965C", Offset = "0x2D0965C", VA = "0x2D0965C")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x2D09578", Offset = "0x2D09578", VA = "0x2D09578")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x2D09708", Offset = "0x2D09708", VA = "0x2D09708")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x2D09794", Offset = "0x2D09794", VA = "0x2D09794")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x2D09A14", Offset = "0x2D09A14", VA = "0x2D09A14")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x2D09A48", Offset = "0x2D09A48", VA = "0x2D09A48")]
	[ContextMenu("SaveInitTransform")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x2D020D0", Offset = "0x2D020D0", VA = "0x2D020D0")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x2D01E78", Offset = "0x2D01E78", VA = "0x2D01E78")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x2D09C28", Offset = "0x2D09C28", VA = "0x2D09C28")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x2D09CD0", Offset = "0x2D09CD0", VA = "0x2D09CD0")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x2D09CD8", Offset = "0x2D09CD8", VA = "0x2D09CD8")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x2D09D30", Offset = "0x2D09D30", VA = "0x2D09D30")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x2D09D88", Offset = "0x2D09D88", VA = "0x2D09D88")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x2D09DE0", Offset = "0x2D09DE0", VA = "0x2D09DE0")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x2D09FB8", Offset = "0x2D09FB8", VA = "0x2D09FB8")]
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
	[Space(2f)]
	public RFLimitations limitations;

	[Token(Token = "0x40004E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x2D0A2FC", Offset = "0x2D0A2FC", VA = "0x2D0A2FC")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x20000BA")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Rigid Root")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-root-component/")]
[SelectionBase]
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
		[Address(RVA = "0x2D0D940", Offset = "0x2D0D940", VA = "0x2D0D940")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x2D0D994", Offset = "0x2D0D994", VA = "0x2D0D994")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x2D0D9E8", Offset = "0x2D0D9E8", VA = "0x2D0D9E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasUny
	{
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x2D0D2E4", Offset = "0x2D0D2E4", VA = "0x2D0D2E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x2D0A3AC", Offset = "0x2D0A3AC", VA = "0x2D0A3AC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x2D0A4A4", Offset = "0x2D0A4A4", VA = "0x2D0A4A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x2D0A4D0", Offset = "0x2D0A4D0", VA = "0x2D0A4D0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x2D0A3DC", Offset = "0x2D0A3DC", VA = "0x2D0A3DC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x2D0A95C", Offset = "0x2D0A95C", VA = "0x2D0A95C")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x2D0ABC8", Offset = "0x2D0ABC8", VA = "0x2D0ABC8")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x2D0ABD0", Offset = "0x2D0ABD0", VA = "0x2D0ABD0")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x2D0AD58", Offset = "0x2D0AD58", VA = "0x2D0AD58")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x2D0A61C", Offset = "0x2D0A61C", VA = "0x2D0A61C")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x2D0B208", Offset = "0x2D0B208", VA = "0x2D0B208")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x2D0C10C", Offset = "0x2D0C10C", VA = "0x2D0C10C")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x2D0B2B4", Offset = "0x2D0B2B4", VA = "0x2D0B2B4")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x2D0C654", Offset = "0x2D0C654", VA = "0x2D0C654")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x2D0C8FC", Offset = "0x2D0C8FC", VA = "0x2D0C8FC")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x2D0CA60", Offset = "0x2D0CA60", VA = "0x2D0CA60")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x2D0CBD8", Offset = "0x2D0CBD8", VA = "0x2D0CBD8")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x2D0CD3C", Offset = "0x2D0CD3C", VA = "0x2D0CD3C")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x2D0BCB4", Offset = "0x2D0BCB4", VA = "0x2D0BCB4")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x2D0C1EC", Offset = "0x2D0C1EC", VA = "0x2D0C1EC")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x2D0C3D8", Offset = "0x2D0C3D8", VA = "0x2D0C3D8")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x2D0BEE0", Offset = "0x2D0BEE0", VA = "0x2D0BEE0")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x2D0A518", Offset = "0x2D0A518", VA = "0x2D0A518")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x2D0D7F8", Offset = "0x2D0D7F8", VA = "0x2D0D7F8")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x2D0D8C4", Offset = "0x2D0D8C4", VA = "0x2D0D8C4")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x2D0CE40", Offset = "0x2D0CE40", VA = "0x2D0CE40")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x2D0DA3C", Offset = "0x2D0DA3C", VA = "0x2D0DA3C")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x2D0DA48", Offset = "0x2D0DA48", VA = "0x2D0DA48")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x20000BC")]
[AddComponentMenu("RayFire/Rayfire Shatter")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-shatter-component/")]
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
	[Address(RVA = "0x2D0DC58", Offset = "0x2D0DC58", VA = "0x2D0DC58")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x2D0DDD4", Offset = "0x2D0DDD4", VA = "0x2D0DDD4")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x2D0DE7C", Offset = "0x2D0DE7C", VA = "0x2D0DE7C")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x2D0E250", Offset = "0x2D0E250", VA = "0x2D0E250")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x2D0E4AC", Offset = "0x2D0E4AC", VA = "0x2D0E4AC")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x2D0E7AC", Offset = "0x2D0E7AC", VA = "0x2D0E7AC")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x2D0E93C", Offset = "0x2D0E93C", VA = "0x2D0E93C")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x2D0EDE8", Offset = "0x2D0EDE8", VA = "0x2D0EDE8")]
	private List<GameObject> CreateFragments([Optional] GameObject lastRoot)
	{
		return null;
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x2D0F9E4", Offset = "0x2D0F9E4", VA = "0x2D0F9E4")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x2D0FD48", Offset = "0x2D0FD48", VA = "0x2D0FD48")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x2D0DC5C", Offset = "0x2D0DC5C", VA = "0x2D0DC5C")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x2D0EB0C", Offset = "0x2D0EB0C", VA = "0x2D0EB0C")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x2D0FEF0", Offset = "0x2D0FEF0", VA = "0x2D0FEF0")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x2D07A84", Offset = "0x2D07A84", VA = "0x2D07A84")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x2D101A0", Offset = "0x2D101A0", VA = "0x2D101A0")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0x2D0F7EC", Offset = "0x2D0F7EC", VA = "0x2D0F7EC")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0x2D10454", Offset = "0x2D10454", VA = "0x2D10454")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x20000BE")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-snapshot-component/")]
[AddComponentMenu("RayFire/Rayfire Snapshot")]
[DisallowMultipleComponent]
[SelectionBase]
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
	[Address(RVA = "0x2D10950", Offset = "0x2D10950", VA = "0x2D10950")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x2D10984", Offset = "0x2D10984", VA = "0x2D10984")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x20000BF")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-sound-component/")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Sound")]
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
	[Address(RVA = "0x2D1098C", Offset = "0x2D1098C", VA = "0x2D1098C")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0x2D109B4", Offset = "0x2D109B4", VA = "0x2D109B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x2D109B8", Offset = "0x2D109B8", VA = "0x2D109B8")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x2D10AEC", Offset = "0x2D10AEC", VA = "0x2D10AEC")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x2D10F0C", Offset = "0x2D10F0C", VA = "0x2D10F0C")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x2D11000", Offset = "0x2D11000", VA = "0x2D11000")]
	private void CreateSource(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x20000C0")]
[AddComponentMenu("RayFire/Rayfire Unyielding")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-unyielding-component/")]
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
		[Address(RVA = "0x2D127C0", Offset = "0x2D127C0", VA = "0x2D127C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	private bool HasShards
	{
		[Token(Token = "0x6000492")]
		[Address(RVA = "0x2D12814", Offset = "0x2D12814", VA = "0x2D12814")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public Vector3 Extents
	{
		[Token(Token = "0x6000493")]
		[Address(RVA = "0x2D11824", Offset = "0x2D11824", VA = "0x2D11824")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x2D11254", Offset = "0x2D11254", VA = "0x2D11254")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2D11340", Offset = "0x2D11340", VA = "0x2D11340")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x2D116C4", Offset = "0x2D116C4", VA = "0x2D116C4")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2D118C8", Offset = "0x2D118C8", VA = "0x2D118C8")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x2D07BF0", Offset = "0x2D07BF0", VA = "0x2D07BF0")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x2D118EC", Offset = "0x2D118EC", VA = "0x2D118EC")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x2D119E8", Offset = "0x2D119E8", VA = "0x2D119E8")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x2D11DD4", Offset = "0x2D11DD4", VA = "0x2D11DD4")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x2D11CF4", Offset = "0x2D11CF4", VA = "0x2D11CF4")]
	public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x2D11EF0", Offset = "0x2D11EF0", VA = "0x2D11EF0")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x2D120E4", Offset = "0x2D120E4", VA = "0x2D120E4")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x2D08B8C", Offset = "0x2D08B8C", VA = "0x2D08B8C")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x2D12274", Offset = "0x2D12274", VA = "0x2D12274")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x2D122E0", Offset = "0x2D122E0", VA = "0x2D122E0")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x2D0D338", Offset = "0x2D0D338", VA = "0x2D0D338")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x2D0D710", Offset = "0x2D0D710", VA = "0x2D0D710")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x2D12440", Offset = "0x2D12440", VA = "0x2D12440")]
	public void Activate()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x2D12868", Offset = "0x2D12868", VA = "0x2D12868")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x20000C2")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-vortex-component/")]
[AddComponentMenu("RayFire/Rayfire Vortex")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000C3")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2D13D28", Offset = "0x2D13D28", VA = "0x2D13D28", Slot = "4")]
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
			[Address(RVA = "0x2D13D70", Offset = "0x2D13D70", VA = "0x2D13D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x2D13BD4", Offset = "0x2D13BD4", VA = "0x2D13BD4")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x2D13BFC", Offset = "0x2D13BFC", VA = "0x2D13BFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x2D13C00", Offset = "0x2D13C00", VA = "0x2D13C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x2D13D30", Offset = "0x2D13D30", VA = "0x2D13D30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C4")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2D13EE8", Offset = "0x2D13EE8", VA = "0x2D13EE8", Slot = "4")]
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
			[Address(RVA = "0x2D13F30", Offset = "0x2D13F30", VA = "0x2D13F30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x2D13D78", Offset = "0x2D13D78", VA = "0x2D13D78")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2D13DA0", Offset = "0x2D13DA0", VA = "0x2D13DA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2D13DA4", Offset = "0x2D13DA4", VA = "0x2D13DA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x2D13EF0", Offset = "0x2D13EF0", VA = "0x2D13EF0", Slot = "8")]
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
	[Address(RVA = "0x2D12890", Offset = "0x2D12890", VA = "0x2D12890")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2D12894", Offset = "0x2D12894", VA = "0x2D12894")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x2D12924", Offset = "0x2D12924", VA = "0x2D12924")]
	[IteratorStateMachine(typeof(<VortexForceCor>d__50))]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x2D12998", Offset = "0x2D12998", VA = "0x2D12998")]
	[IteratorStateMachine(typeof(<SetCollidersCor>d__51))]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x2D12A0C", Offset = "0x2D12A0C", VA = "0x2D12A0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x2D12A44", Offset = "0x2D12A44", VA = "0x2D12A44")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x2D12B68", Offset = "0x2D12B68", VA = "0x2D12B68")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x2D12C6C", Offset = "0x2D12C6C", VA = "0x2D12C6C")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x2D12EA0", Offset = "0x2D12EA0", VA = "0x2D12EA0")]
	private void SetForce()
	{
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x2D13568", Offset = "0x2D13568", VA = "0x2D13568")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x2D1376C", Offset = "0x2D1376C", VA = "0x2D1376C")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x2D138A0", Offset = "0x2D138A0", VA = "0x2D138A0")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x2D139CC", Offset = "0x2D139CC", VA = "0x2D139CC")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x2D1369C", Offset = "0x2D1369C", VA = "0x2D1369C")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x2D13AAC", Offset = "0x2D13AAC", VA = "0x2D13AAC")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x20000C5")]
[AddComponentMenu("RayFire/Rayfire Wind")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-wind-component/")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000C6")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2D14DAC", Offset = "0x2D14DAC", VA = "0x2D14DAC", Slot = "4")]
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
			[Address(RVA = "0x2D14DF4", Offset = "0x2D14DF4", VA = "0x2D14DF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2D14040", Offset = "0x2D14040", VA = "0x2D14040")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2D14CE0", Offset = "0x2D14CE0", VA = "0x2D14CE0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2D14CE4", Offset = "0x2D14CE4", VA = "0x2D14CE4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2D14DB4", Offset = "0x2D14DB4", VA = "0x2D14DB4", Slot = "8")]
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
	[Address(RVA = "0x2D13F38", Offset = "0x2D13F38", VA = "0x2D13F38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x2D13F3C", Offset = "0x2D13F3C", VA = "0x2D13F3C")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x2D13FCC", Offset = "0x2D13FCC", VA = "0x2D13FCC")]
	[IteratorStateMachine(typeof(<WindForceCor>d__25))]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x2D14068", Offset = "0x2D14068", VA = "0x2D14068")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x2D14088", Offset = "0x2D14088", VA = "0x2D14088")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x2D14094", Offset = "0x2D14094", VA = "0x2D14094")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x2D1426C", Offset = "0x2D1426C", VA = "0x2D1426C")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x2D142C0", Offset = "0x2D142C0", VA = "0x2D142C0")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x2D144F4", Offset = "0x2D144F4", VA = "0x2D144F4")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x2D14844", Offset = "0x2D14844", VA = "0x2D14844")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x2D14898", Offset = "0x2D14898", VA = "0x2D14898")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x2D149E8", Offset = "0x2D149E8", VA = "0x2D149E8")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BC")]
	[Address(RVA = "0x2D147F4", Offset = "0x2D147F4", VA = "0x2D147F4")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004BD")]
	[Address(RVA = "0x2D14B20", Offset = "0x2D14B20", VA = "0x2D14B20")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004BE")]
	[Address(RVA = "0x2D14B64", Offset = "0x2D14B64", VA = "0x2D14B64")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004BF")]
	[Address(RVA = "0x2D149B4", Offset = "0x2D149B4", VA = "0x2D149B4")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004C0")]
	[Address(RVA = "0x2D1481C", Offset = "0x2D1481C", VA = "0x2D1481C")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60004C1")]
	[Address(RVA = "0x2D147AC", Offset = "0x2D147AC", VA = "0x2D147AC")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x60004C2")]
	[Address(RVA = "0x2D14BE0", Offset = "0x2D14BE0", VA = "0x2D14BE0")]
	public RayfireWind()
	{
	}
}
