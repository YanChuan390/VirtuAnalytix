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
	[Address(RVA = "0x22A34C4", Offset = "0x22A34C4", VA = "0x22A34C4")]
	private RFFace(float Area, Vector3 Normal)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x22A3504", Offset = "0x22A3504", VA = "0x22A3504")]
	public static void SetPolys(RFShard shard)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x22A3894", Offset = "0x22A3894", VA = "0x22A3894")]
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
	[Address(RVA = "0x22A3904", Offset = "0x22A3904", VA = "0x22A3904")]
	private RFTriangle(float Area, Vector3 Normal, Vector3 Pos)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x22A3968", Offset = "0x22A3968", VA = "0x22A3968")]
	public static void SetTriangles(RFShard shard)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x22A3D9C", Offset = "0x22A3D9C", VA = "0x22A3D9C")]
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
	[Address(RVA = "0x22A3E0C", Offset = "0x22A3E0C", VA = "0x22A3E0C")]
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
		[Address(RVA = "0x22A3EAC", Offset = "0x22A3EAC", VA = "0x22A3EAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x22A3E2C", Offset = "0x22A3E2C", VA = "0x22A3E2C")]
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
	[Address(RVA = "0x22A3F5C", Offset = "0x22A3F5C", VA = "0x22A3F5C")]
	public RFMaterialPresets()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x22A4420", Offset = "0x22A4420", VA = "0x22A4420")]
	public void SetMaterials()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x22A470C", Offset = "0x22A470C", VA = "0x22A470C")]
	public float Density(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x22A47BC", Offset = "0x22A47BC", VA = "0x22A47BC")]
	public float Drag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x22A486C", Offset = "0x22A486C", VA = "0x22A486C")]
	public float AngularDrag(MaterialType materialType)
	{
		return default(float);
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x22A4920", Offset = "0x22A4920", VA = "0x22A4920")]
	public int Solidity(MaterialType materialType)
	{
		return default(int);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x22A49D0", Offset = "0x22A49D0", VA = "0x22A49D0")]
	public bool Destructible(MaterialType materialType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x22A4A88", Offset = "0x22A4A88", VA = "0x22A4A88")]
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
			[Address(RVA = "0x22A541C", Offset = "0x22A541C", VA = "0x22A541C", Slot = "4")]
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
			[Address(RVA = "0x22A5464", Offset = "0x22A5464", VA = "0x22A5464", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x22A5248", Offset = "0x22A5248", VA = "0x22A5248")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x22A5270", Offset = "0x22A5270", VA = "0x22A5270", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x22A5274", Offset = "0x22A5274", VA = "0x22A5274", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x22A5424", Offset = "0x22A5424", VA = "0x22A5424", Slot = "8")]
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
	[Address(RVA = "0x22A4D00", Offset = "0x22A4D00", VA = "0x22A4D00")]
	public RFPoolingParticles()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x22A4D94", Offset = "0x22A4D94", VA = "0x22A4D94")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x22A4EA4", Offset = "0x22A4EA4", VA = "0x22A4EA4")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x22A4FB0", Offset = "0x22A4FB0", VA = "0x22A4FB0")]
	public static ParticleSystem CreateParticleInstance()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x22A5064", Offset = "0x22A5064", VA = "0x22A5064")]
	public ParticleSystem GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x22A5120", Offset = "0x22A5120", VA = "0x22A5120")]
	private ParticleSystem CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x22A51D4", Offset = "0x22A51D4", VA = "0x22A51D4")]
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
			[Address(RVA = "0x22A5C78", Offset = "0x22A5C78", VA = "0x22A5C78", Slot = "4")]
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
			[Address(RVA = "0x22A5CC0", Offset = "0x22A5CC0", VA = "0x22A5CC0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x22A5AA8", Offset = "0x22A5AA8", VA = "0x22A5AA8")]
		[DebuggerHidden]
		public <StartPoolingCor>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x22A5AD0", Offset = "0x22A5AD0", VA = "0x22A5AD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x22A5AD4", Offset = "0x22A5AD4", VA = "0x22A5AD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x22A5C80", Offset = "0x22A5C80", VA = "0x22A5C80", Slot = "8")]
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
	[Address(RVA = "0x22A546C", Offset = "0x22A546C", VA = "0x22A546C")]
	public RFPoolingFragment()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x22A5500", Offset = "0x22A5500", VA = "0x22A5500")]
	public void CreatePoolRoot(Transform manTm)
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x22A5610", Offset = "0x22A5610", VA = "0x22A5610")]
	public void CreateInstance(Transform manTm)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x22A5708", Offset = "0x22A5708", VA = "0x22A5708")]
	public static RayfireRigid CreateRigidInstance()
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x22A58C4", Offset = "0x22A58C4", VA = "0x22A58C4")]
	public RayfireRigid GetPoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x22A5980", Offset = "0x22A5980", VA = "0x22A5980")]
	private RayfireRigid CreatePoolObject(Transform manTm)
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x22A5A34", Offset = "0x22A5A34", VA = "0x22A5A34")]
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
			[Address(RVA = "0x22A6320", Offset = "0x22A6320", VA = "0x22A6320", Slot = "4")]
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
			[Address(RVA = "0x22A6368", Offset = "0x22A6368", VA = "0x22A6368", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22A5EE4", Offset = "0x22A5EE4", VA = "0x22A5EE4")]
		[DebuggerHidden]
		public <StorageCor>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x22A6110", Offset = "0x22A6110", VA = "0x22A6110", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x22A6114", Offset = "0x22A6114", VA = "0x22A6114", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x22A6328", Offset = "0x22A6328", VA = "0x22A6328", Slot = "8")]
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
	[Address(RVA = "0x22A5CC8", Offset = "0x22A5CC8", VA = "0x22A5CC8")]
	public RFStorage()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x22A5D50", Offset = "0x22A5D50", VA = "0x22A5D50")]
	public void CreateStorageRoot(Transform manTm)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x22A5E7C", Offset = "0x22A5E7C", VA = "0x22A5E7C")]
	[IteratorStateMachine(typeof(<StorageCor>d__6))]
	public IEnumerator StorageCor()
	{
		return null;
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x22A5F0C", Offset = "0x22A5F0C", VA = "0x22A5F0C")]
	public void Register(Transform tm)
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x22A5FCC", Offset = "0x22A5FCC", VA = "0x22A5FCC")]
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
	[Address(RVA = "0x22A6370", Offset = "0x22A6370", VA = "0x22A6370")]
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
	[Address(RVA = "0x22A6378", Offset = "0x22A6378", VA = "0x22A6378")]
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
	[Address(RVA = "0x22A6530", Offset = "0x22A6530", VA = "0x22A6530")]
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
	[Address(RVA = "0x22A6648", Offset = "0x22A6648", VA = "0x22A6648")]
	public RFShatterCluster()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x22A6690", Offset = "0x22A6690", VA = "0x22A6690")]
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
		[Address(RVA = "0x22A6740", Offset = "0x22A6740", VA = "0x22A6740")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x22A66EC", Offset = "0x22A66EC", VA = "0x22A66EC")]
	public RFVoronoi()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x22A670C", Offset = "0x22A670C", VA = "0x22A670C")]
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
		[Address(RVA = "0x22A67C8", Offset = "0x22A67C8", VA = "0x22A67C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x22A6768", Offset = "0x22A6768", VA = "0x22A6768")]
	public RFSplinters()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x22A6794", Offset = "0x22A6794", VA = "0x22A6794")]
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
	[Address(RVA = "0x22A67F0", Offset = "0x22A67F0", VA = "0x22A67F0")]
	public RFRadial()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x22A6834", Offset = "0x22A6834", VA = "0x22A6834")]
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
	[Address(RVA = "0x22A6898", Offset = "0x22A6898", VA = "0x22A6898")]
	public RFSlice()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x22A68B8", Offset = "0x22A68B8", VA = "0x22A68B8")]
	public RFSlice(RFSlice src)
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x22A68F4", Offset = "0x22A68F4", VA = "0x22A68F4")]
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
	[Address(RVA = "0x22A6940", Offset = "0x22A6940", VA = "0x22A6940")]
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
	[Address(RVA = "0x22A6994", Offset = "0x22A6994", VA = "0x22A6994")]
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
	[Address(RVA = "0x22A69B4", Offset = "0x22A69B4", VA = "0x22A69B4")]
	public RFTets()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x22A69E0", Offset = "0x22A69E0", VA = "0x22A69E0")]
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
		[Address(RVA = "0x22A720C", Offset = "0x22A720C", VA = "0x22A720C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000B")]
	public bool UnyieldingByShard
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x22A9FE8", Offset = "0x22A9FE8", VA = "0x22A9FE8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000C")]
	public bool UnyieldingByRigid
	{
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x22AA080", Offset = "0x22AA080", VA = "0x22AA080")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x22A6A1C", Offset = "0x22A6A1C", VA = "0x22A6A1C")]
	public RFCluster()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x22A6B10", Offset = "0x22A6B10", VA = "0x22A6B10")]
	public RFCluster(RFCluster source)
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x22A7260", Offset = "0x22A7260", VA = "0x22A7260", Slot = "4")]
	public int CompareTo(RFCluster otherCluster)
	{
		return default(int);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x22A7360", Offset = "0x22A7360", VA = "0x22A7360")]
	public static void InitCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x22A73B4", Offset = "0x22A73B4", VA = "0x22A73B4")]
	private static void InitConnectedCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x22A75F0", Offset = "0x22A75F0", VA = "0x22A75F0")]
	private static void InitNestedCluster(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x22A77E4", Offset = "0x22A77E4", VA = "0x22A77E4")]
	public static void ConnectivityUnyCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x22A81EC", Offset = "0x22A81EC", VA = "0x22A81EC")]
	public static void ConnectivityCheck(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x22A7F24", Offset = "0x22A7F24", VA = "0x22A7F24")]
	public static void NewClusterByShards(RFCluster mainCLuster, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x22A882C", Offset = "0x22A882C", VA = "0x22A882C")]
	public void AddChildCluster(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x22A80C4", Offset = "0x22A80C4", VA = "0x22A80C4")]
	public static void ReduceChildClusters(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x22A8A04", Offset = "0x22A8A04", VA = "0x22A8A04")]
	public static Bounds GetChildrenBound(Transform tm)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x22A912C", Offset = "0x22A912C", VA = "0x22A912C")]
	public static Bounds GetClusterBound(RFCluster cluster)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x22A8C04", Offset = "0x22A8C04", VA = "0x22A8C04")]
	public static Bounds GetBoundsBound(List<Bounds> bounds)
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x22A93C0", Offset = "0x22A93C0", VA = "0x22A93C0")]
	public static Bounds GetShardsBound(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x22A97C0", Offset = "0x22A97C0", VA = "0x22A97C0")]
	public static Bounds GetShardsBoundByPosition(List<RFShard> shards)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x22A891C", Offset = "0x22A891C", VA = "0x22A891C")]
	public static int GetBiggestCluster(List<RFCluster> clusters)
	{
		return default(int);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x22A9C6C", Offset = "0x22A9C6C", VA = "0x22A9C6C")]
	public static void GetSoloShards(RFCluster cluster, List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x22A8780", Offset = "0x22A8780", VA = "0x22A8780")]
	public static int GetUniqClusterId(RFCluster cluster)
	{
		return default(int);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x22A9DE0", Offset = "0x22A9DE0", VA = "0x22A9DE0")]
	public static bool IntegrityCheck(RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x22A9EC8", Offset = "0x22A9EC8", VA = "0x22A9EC8")]
	public static void CreateClusterRoot(RFCluster cluster, Vector3 pos, Quaternion rot, int layer, string tag, string nm)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x22AA128", Offset = "0x22AA128", VA = "0x22AA128")]
	private List<RFShard> GetNestedShards(bool OwnShards = false)
	{
		return null;
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x22AA2E0", Offset = "0x22AA2E0", VA = "0x22AA2E0")]
	public List<RFCluster> GetNestedClusters()
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x22AA428", Offset = "0x22AA428", VA = "0x22AA428")]
	private bool TrisNeib(RFCluster otherCluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x22AA770", Offset = "0x22AA770", VA = "0x22AA770")]
	private float NeibArea(RFCluster otherCluster)
	{
		return default(float);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x22AAB38", Offset = "0x22AAB38", VA = "0x22AAB38")]
	public int GetNeibIndArea([Optional] List<RFCluster> clusterList)
	{
		return default(int);
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x22AAC5C", Offset = "0x22AAC5C", VA = "0x22AAC5C")]
	public static void SetClusterNeib(List<RFCluster> clusters, bool connectivity)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x22AB66C", Offset = "0x22AB66C", VA = "0x22AB66C")]
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
	public delegate void EventActionMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot);

	[Token(Token = "0x200001F")]
	public delegate void EventActionRoot(RFShard shard, RayfireRigidRoot root);

	[Token(Token = "0x14000001")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600006A")]
		[Address(RVA = "0x22ABA48", Offset = "0x22ABA48", VA = "0x22ABA48")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006B")]
		[Address(RVA = "0x22ABAE4", Offset = "0x22ABAE4", VA = "0x22ABAE4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event EventActionMeshRoot LocalEventMeshRoot
	{
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x22ABB80", Offset = "0x22ABB80", VA = "0x22ABB80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x22ABC1C", Offset = "0x22ABC1C", VA = "0x22ABC1C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event EventActionRoot LocalEventRoot
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x22ABCB8", Offset = "0x22ABCB8", VA = "0x22ABCB8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x22ABD54", Offset = "0x22ABD54", VA = "0x22ABD54")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x22ABDF0", Offset = "0x22ABDF0", VA = "0x22ABDF0")]
	public void InvokeLocalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x22ABE0C", Offset = "0x22ABE0C", VA = "0x22ABE0C")]
	public void InvokeLocalEventMeshRoot(RayfireRigid rigid, RayfireRigid meshRoot)
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x22ABE28", Offset = "0x22ABE28", VA = "0x22ABE28")]
	public void InvokeLocalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x22ABE44", Offset = "0x22ABE44", VA = "0x22ABE44")]
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
		[Token(Token = "0x6000080")]
		[Address(RVA = "0x22AC2A8", Offset = "0x22AC2A8", VA = "0x22AC2A8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x22AC360", Offset = "0x22AC360", VA = "0x22AC360")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x22AC418", Offset = "0x22AC418", VA = "0x22AC418")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x22AC484", Offset = "0x22AC484", VA = "0x22AC484")]
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
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x22AC48C", Offset = "0x22AC48C", VA = "0x22AC48C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x22AC544", Offset = "0x22AC544", VA = "0x22AC544")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public static event EventActionRoot GlobalEventRoot
	{
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x22AC5FC", Offset = "0x22AC5FC", VA = "0x22AC5FC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x22AC6B8", Offset = "0x22AC6B8", VA = "0x22AC6B8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x22AC774", Offset = "0x22AC774", VA = "0x22AC774")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x22AC7E0", Offset = "0x22AC7E0", VA = "0x22AC7E0")]
	public static void InvokeGlobalEventRoot(RFShard shard, RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x22AC860", Offset = "0x22AC860", VA = "0x22AC860")]
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
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x22AC868", Offset = "0x22AC868", VA = "0x22AC868")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x22AC920", Offset = "0x22AC920", VA = "0x22AC920")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x22AC9D8", Offset = "0x22AC9D8", VA = "0x22AC9D8")]
	public static void InvokeGlobalEvent(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x22ACA44", Offset = "0x22ACA44", VA = "0x22ACA44")]
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
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x22ACA4C", Offset = "0x22ACA4C", VA = "0x22ACA4C")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x22ACB04", Offset = "0x22ACB04", VA = "0x22ACB04")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x22ACBBC", Offset = "0x22ACBBC", VA = "0x22ACBBC")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x22ACC58", Offset = "0x22ACC58", VA = "0x22ACC58")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x22ACCF4", Offset = "0x22ACCF4", VA = "0x22ACCF4")]
	public static void InvokeGlobalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x22ACD60", Offset = "0x22ACD60", VA = "0x22ACD60")]
	public void InvokeLocalEvent(RayfireGun gun)
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x22ACD7C", Offset = "0x22ACD7C", VA = "0x22ACD7C")]
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
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x22ACEF0", Offset = "0x22ACEF0", VA = "0x22ACEF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x22ACFA8", Offset = "0x22ACFA8", VA = "0x22ACFA8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x22AD060", Offset = "0x22AD060", VA = "0x22AD060")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x22AD0FC", Offset = "0x22AD0FC", VA = "0x22AD0FC")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x22AD198", Offset = "0x22AD198", VA = "0x22AD198")]
	public static void InvokeGlobalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x22AD204", Offset = "0x22AD204", VA = "0x22AD204")]
	public void InvokeLocalEvent(RayfireBomb bomb)
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x22AD220", Offset = "0x22AD220", VA = "0x22AD220")]
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
		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x22AD394", Offset = "0x22AD394", VA = "0x22AD394")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x22AD44C", Offset = "0x22AD44C", VA = "0x22AD44C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000D")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x22AD504", Offset = "0x22AD504", VA = "0x22AD504")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x22AD5A0", Offset = "0x22AD5A0", VA = "0x22AD5A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x22AD63C", Offset = "0x22AD63C", VA = "0x22AD63C")]
	public static void InvokeGlobalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x22AD6A8", Offset = "0x22AD6A8", VA = "0x22AD6A8")]
	public void InvokeLocalEvent(RayfireBlade blade)
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0x22AD6C4", Offset = "0x22AD6C4", VA = "0x22AD6C4")]
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
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x22AD838", Offset = "0x22AD838", VA = "0x22AD838")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x22AD8F0", Offset = "0x22AD8F0", VA = "0x22AD8F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400000F")]
	public event EventAction LocalEvent
	{
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x22AD9A8", Offset = "0x22AD9A8", VA = "0x22AD9A8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x22ADA44", Offset = "0x22ADA44", VA = "0x22ADA44")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x22ADAE0", Offset = "0x22ADAE0", VA = "0x22ADAE0")]
	public static void InvokeGlobalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x22ADB68", Offset = "0x22ADB68", VA = "0x22ADB68")]
	public void InvokeLocalEvent(RayfireConnectivity connectivity, List<RFShard> shards, List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x22ADB84", Offset = "0x22ADB84", VA = "0x22ADB84")]
	public RFConnectivityEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x200002B")]
public class RFFlash
{
	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Intensity")]
	[Space(3f)]
	[Range(0.1f, 5f)]
	public float intensityMin;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0.1f, 5f)]
	[Space(1f)]
	public float intensityMax;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Range")]
	[Range(0.01f, 10f)]
	[Space(3f)]
	public float rangeMin;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.01f, 10f)]
	[Space(1f)]
	public float rangeMax;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Other")]
	[Space(3f)]
	[Range(0.01f, 2f)]
	public float distance;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(1f)]
	public Color color;

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x22ADD08", Offset = "0x22ADD08", VA = "0x22ADD08")]
	public RFFlash()
	{
	}
}
[Serializable]
[Token(Token = "0x200002C")]
public class RFDecals
{
	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Range(0.1f, 5f)]
	[Space(2f)]
	[Header("  Size")]
	public float sizeMin;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 5f)]
	[Space(1f)]
	public float sizeMax;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Limitations")]
	[Space(2f)]
	[Range(0.01f, 2f)]
	public float distance;

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x22ADD3C", Offset = "0x22ADD3C", VA = "0x22ADD3C")]
	public RFDecals()
	{
	}
}
[Serializable]
[Token(Token = "0x200002D")]
public class RFMesh
{
	[Serializable]
	[Token(Token = "0x200002E")]
	public class RFSubMeshTris
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> triangles;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x22AF138", Offset = "0x22AF138", VA = "0x22AF138")]
		public RFSubMeshTris()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x22AE9B8", Offset = "0x22AE9B8", VA = "0x22AE9B8")]
		public RFSubMeshTris(List<int> tris)
		{
		}
	}

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool compress;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int subMeshCount;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Bounds bounds;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int[] triangles;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<RFSubMeshTris> subTriangles;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2[] uv;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector3[] vertices;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector4[] tangents;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public List<int> uvComp;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public List<int> verticesComp;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public List<int> tangentsComp;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x22ADD68", Offset = "0x22ADD68", VA = "0x22ADD68")]
	public RFMesh(Mesh mesh, bool comp = false)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x22AE9E0", Offset = "0x22AE9E0", VA = "0x22AE9E0")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x22AEB04", Offset = "0x22AEB04", VA = "0x22AEB04")]
	private void LoadTriangles(Mesh mesh)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x22AEF9C", Offset = "0x22AEF9C", VA = "0x22AEF9C")]
	public static Mesh BakeMesh(SkinnedMeshRenderer skin)
	{
		return null;
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x22AF04C", Offset = "0x22AF04C", VA = "0x22AF04C")]
	public static void ConvertRfMeshes(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x22AED24", Offset = "0x22AED24", VA = "0x22AED24")]
	private static Vector2[] SetCompressedUv(List<int> uvComp)
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x22AEBCC", Offset = "0x22AEBCC", VA = "0x22AEBCC")]
	private static Vector3[] SetCompressedVertices(List<int> verticesComp)
	{
		return null;
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x22AEE40", Offset = "0x22AEE40", VA = "0x22AEE40")]
	private static Vector4[] SetCompressedTangents(List<int> tangentsComp)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200002F")]
public class RFParticleNoise
{
	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Main")]
	[Space(3f)]
	public bool enabled;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemNoiseQuality quality;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 3f)]
	[Header("  Strength")]
	[Space(3f)]
	public float strengthMin;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 3f)]
	[Space(2f)]
	public float strengthMax;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Other")]
	[Space(3f)]
	[Range(0.001f, 3f)]
	public float frequency;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(2f)]
	[Range(0f, 2f)]
	public float scrollSpeed;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public bool damping;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x22AF1B8", Offset = "0x22AF1B8", VA = "0x22AF1B8")]
	public RFParticleNoise()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x22AF1F0", Offset = "0x22AF1F0", VA = "0x22AF1F0")]
	public void CopyFrom(RFParticleNoise source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000030")]
public class RFParticleRendering
{
	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Shadows")]
	[Space(3f)]
	public bool castShadows;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	[Space(2f)]
	public bool receiveShadows;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Header("  Light")]
	[Space(3f)]
	[Space(2f)]
	public LightProbeUsage lightProbes;

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x22AF224", Offset = "0x22AF224", VA = "0x22AF224")]
	public RFParticleRendering()
	{
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x22AF248", Offset = "0x22AF248", VA = "0x22AF248")]
	public void CopyFrom(RFParticleRendering source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000031")]
public class RFParticleDynamicDebris
{
	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Speed")]
	[Space(3f)]
	[Range(0f, 10f)]
	public float speedMin;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(0f, 10f)]
	public float speedMax;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Inherit Velocity")]
	[Space(3f)]
	[Range(0f, 3f)]
	public float velocityMin;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0f, 3f)]
	public float velocityMax;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("  Gravity Modifier")]
	[Space(3f)]
	[Range(-2f, 2f)]
	public float gravityMin;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(2f)]
	[Range(-2f, 2f)]
	public float gravityMax;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	[Header("  Rotation")]
	[Space(3f)]
	public float rotationSpeed;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x22AF274", Offset = "0x22AF274", VA = "0x22AF274")]
	public RFParticleDynamicDebris()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x22AF2B4", Offset = "0x22AF2B4", VA = "0x22AF2B4")]
	public void CopyFrom(RFParticleDynamicDebris source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000032")]
public class RFParticleDynamicDust
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Speed")]
	[Space(3f)]
	[Range(0f, 10f)]
	public float speedMin;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(0f, 10f)]
	public float speedMax;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Rotation")]
	[Space(3f)]
	[Range(0f, 1f)]
	public float rotation;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Gravity Modifier")]
	[Space(3f)]
	[Range(-2f, 2f)]
	public float gravityMin;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(2f)]
	[Range(-2f, 2f)]
	public float gravityMax;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x22AF2E8", Offset = "0x22AF2E8", VA = "0x22AF2E8")]
	public RFParticleDynamicDust()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x22AF318", Offset = "0x22AF318", VA = "0x22AF318")]
	public void CopyFrom(RFParticleDynamicDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000033")]
public class RFParticleEmission
{
	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(3f)]
	[Header("  Burst")]
	public RFParticles.BurstType burstType;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(0f, 500f)]
	public int burstAmount;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Distance")]
	[Space(3f)]
	[Range(0f, 5f)]
	public float distanceRate;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0.5f, 10f)]
	public float duration;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(3f)]
	[Range(1f, 60f)]
	[Header("  Lifetime")]
	public float lifeMin;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(2f)]
	[Range(1f, 60f)]
	public float lifeMax;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("  Size")]
	[Range(0.1f, 10f)]
	[Space(3f)]
	public float sizeMin;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Space(2f)]
	[Range(0.1f, 10f)]
	public float sizeMax;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x22AF33C", Offset = "0x22AF33C", VA = "0x22AF33C")]
	public RFParticleEmission()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x22AF378", Offset = "0x22AF378", VA = "0x22AF378")]
	public void CopyFrom(RFParticleEmission source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000034")]
public class RFParticleLimitations
{
	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Particle system")]
	[Space(3f)]
	[Range(3f, 100f)]
	public int minParticles;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	[Range(5f, 100f)]
	public int maxParticles;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(3f)]
	[Range(10f, 100f)]
	[Header("  Fragments")]
	public int percentage;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Space(2f)]
	[Range(0.05f, 5f)]
	public float sizeThreshold;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	[Range(0f, 5f)]
	public int demolitionDepth;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x22AF3A4", Offset = "0x22AF3A4", VA = "0x22AF3A4")]
	public RFParticleLimitations()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x22AF3DC", Offset = "0x22AF3DC", VA = "0x22AF3DC")]
	public void CopyFrom(RFParticleLimitations source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000035")]
public class RFParticleCollisionDebris
{
	[Token(Token = "0x2000036")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x40000FE")]
		ByPhysicalMaterial,
		[Token(Token = "0x40000FF")]
		ByProperties
	}

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Space(3f)]
	[Header("  Common")]
	public LayerMask collidesWith;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0.1f, 2f)]
	[Space(2f)]
	public float radiusScale;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Header("  Dampen")]
	[Space(3f)]
	public RFParticleCollisionMatType dampenType;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(2f)]
	[Range(0f, 1f)]
	public float dampenMin;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Space(2f)]
	[Range(0f, 1f)]
	public float dampenMax;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("  Bounce")]
	[Space(3f)]
	public RFParticleCollisionMatType bounceType;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Space(2f)]
	[Range(0f, 1f)]
	public float bounceMin;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	[Range(0f, 1f)]
	public float bounceMax;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[HideInInspector]
	public bool propertiesSet;

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x22AF400", Offset = "0x22AF400", VA = "0x22AF400")]
	public RFParticleCollisionDebris()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x22AF454", Offset = "0x22AF454", VA = "0x22AF454")]
	public void CopyFrom(RFParticleCollisionDebris source)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x22AF488", Offset = "0x22AF488", VA = "0x22AF488")]
	public void SetMaterialProps(RayfireDebris debris)
	{
	}
}
[Serializable]
[Token(Token = "0x2000037")]
public class RFParticleCollisionDust
{
	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Header("  Common")]
	[Space(3f)]
	public LayerMask collidesWith;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[Space(2f)]
	public ParticleSystemCollisionQuality quality;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	[Range(0.1f, 2f)]
	public float radiusScale;

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x22AF680", Offset = "0x22AF680", VA = "0x22AF680")]
	public RFParticleCollisionDust()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x22AF6B0", Offset = "0x22AF6B0", VA = "0x22AF6B0")]
	public void CopyFrom(RFParticleCollisionDust source)
	{
	}
}
[Serializable]
[Token(Token = "0x2000038")]
public class RFParticles
{
	[Token(Token = "0x2000039")]
	public enum RFParticleCollisionMatType
	{
		[Token(Token = "0x4000107")]
		ByPhysicalMaterial,
		[Token(Token = "0x4000108")]
		ByProperties
	}

	[Token(Token = "0x200003A")]
	public enum BurstType
	{
		[Token(Token = "0x400010A")]
		None,
		[Token(Token = "0x400010B")]
		TotalAmount,
		[Token(Token = "0x400010C")]
		PerOneUnitSize,
		[Token(Token = "0x400010D")]
		FragmentAmount
	}

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ParticleSystem.MinMaxCurve constantCurve;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string debrisStr;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static string dustStr;

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x22AF6D4", Offset = "0x22AF6D4", VA = "0x22AF6D4")]
	public static void SetParticleComponents(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x22AFABC", Offset = "0x22AFABC", VA = "0x22AFABC")]
	public static void SetParticleComponents(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x22AFFDC", Offset = "0x22AFFDC", VA = "0x22AFFDC")]
	public static void InitDemolitionParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x22B00B0", Offset = "0x22B00B0", VA = "0x22B00B0")]
	public static void CreateDemolitionDebris(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x22B04B4", Offset = "0x22B04B4", VA = "0x22B04B4")]
	public static void CreateDemolitionDust(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x22B1A74", Offset = "0x22B1A74", VA = "0x22B1A74")]
	public static void InitActivationParticlesRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x22B203C", Offset = "0x22B203C", VA = "0x22B203C")]
	public static void InitActivationParticlesShard(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x22B115C", Offset = "0x22B115C", VA = "0x22B115C")]
	public static void CreateDebrisRigid(RayfireDebris target)
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x22B1C5C", Offset = "0x22B1C5C", VA = "0x22B1C5C")]
	public static void CreateDebrisCluster(RayfireRigid rigid, RayfireDebris debris)
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x22B2378", Offset = "0x22B2378", VA = "0x22B2378")]
	public static void CreateDebrisShard(RayfireRigidRoot root, RayfireDebris debris, RFShard shard)
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x22B1728", Offset = "0x22B1728", VA = "0x22B1728")]
	public static void CreateDustRigid(RayfireDust target)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x22B2534", Offset = "0x22B2534", VA = "0x22B2534")]
	public static void CreateDustShard(RayfireRigidRoot root, RayfireDust dust, RFShard shard)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x22B26F0", Offset = "0x22B26F0", VA = "0x22B26F0")]
	public static ParticleSystem CreateParticleSystemDebris(RayfireDebris debris, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x22B29DC", Offset = "0x22B29DC", VA = "0x22B29DC")]
	public static ParticleSystem CreateParticleSystemDust(RayfireDust dust, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x22B2B24", Offset = "0x22B2B24", VA = "0x22B2B24")]
	private static ParticleSystem CreateParticleSystem(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x22B2CFC", Offset = "0x22B2CFC", VA = "0x22B2CFC")]
	public static void CreateDebrisImpact(RayfireDebris debris, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x22B2EAC", Offset = "0x22B2EAC", VA = "0x22B2EAC")]
	public static void CreateDustImpact(RayfireDust dust, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x22B08B8", Offset = "0x22B08B8", VA = "0x22B08B8")]
	private static void DetachParticles(RayfireRigid source)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x22B305C", Offset = "0x22B305C", VA = "0x22B305C")]
	public static void CopyRigidParticles(RayfireRigid source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x22B35B0", Offset = "0x22B35B0", VA = "0x22B35B0")]
	public static void CopyRootMeshParticles(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0x22B3FB0", Offset = "0x22B3FB0", VA = "0x22B3FB0")]
	public static void CopyRigidRootParticles(RayfireRigidRoot source, RayfireRigid target)
	{
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x22B4504", Offset = "0x22B4504", VA = "0x22B4504")]
	public static void SetMain(ParticleSystem.MainModule main, float lifeMin, float lifeMax, float sizeMin, float sizeMax, float gravityMin, float gravityMax, float speedMin, float speedMax, float divergence, int maxParticles, float duration)
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x22B4760", Offset = "0x22B4760", VA = "0x22B4760")]
	public static void SetEmission(ParticleSystem.EmissionModule emissionModule, float distanceRate, int burstAmount)
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x22B489C", Offset = "0x22B489C", VA = "0x22B489C")]
	public static void SetShapeMesh(ParticleSystem.ShapeModule shapeModule, Mesh mesh, int emitMatIndex, Vector3 shapeScale)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x22B4960", Offset = "0x22B4960", VA = "0x22B4960")]
	public static void SetShapeObject(ParticleSystem.ShapeModule shapeModule)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x22B2838", Offset = "0x22B2838", VA = "0x22B2838")]
	public static int GetEmissionMatIndex(Renderer renderer, Material mat)
	{
		return default(int);
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x22B49A4", Offset = "0x22B49A4", VA = "0x22B49A4")]
	public static void SetVelocity(ParticleSystem.InheritVelocityModule velocity, RFParticleDynamicDebris dynamic)
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x22B4A84", Offset = "0x22B4A84", VA = "0x22B4A84")]
	public static void SetRotationOverLifeTime(ParticleSystem.RotationOverLifetimeModule rotation, RFParticleDynamicDust dynamic)
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x22B4B48", Offset = "0x22B4B48", VA = "0x22B4B48")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationByLife(float spin)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x22B4D78", Offset = "0x22B4D78", VA = "0x22B4D78")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, float size)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x22B5010", Offset = "0x22B5010", VA = "0x22B5010")]
	public static void SetSizeOverLifeTime(ParticleSystem.SizeOverLifetimeModule sizeOverLifeTime, Vector3 size)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x22B4E14", Offset = "0x22B4E14", VA = "0x22B4E14")]
	public static ParticleSystem.MinMaxCurve GetCurveSizeOverLifeTime(float val)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x22B511C", Offset = "0x22B511C", VA = "0x22B511C")]
	public static void SetRotationBySpeed(ParticleSystem.RotationBySpeedModule rotationBySpeed, float rotationSpeed)
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x22B51C8", Offset = "0x22B51C8", VA = "0x22B51C8")]
	public static ParticleSystem.MinMaxCurve GetCurveRotationBySpeed(float rotationSpeed)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x22B539C", Offset = "0x22B539C", VA = "0x22B539C")]
	public static void SetColorOverLife(ParticleSystem.ColorOverLifetimeModule colorLife, float opacity)
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x22B5554", Offset = "0x22B5554", VA = "0x22B5554")]
	public static void SetNoise(ParticleSystem.NoiseModule psNoise, RFParticleNoise scrNoise)
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x22B5758", Offset = "0x22B5758", VA = "0x22B5758")]
	public static void SetCollisionDebris(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDebris coll)
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x22B5898", Offset = "0x22B5898", VA = "0x22B5898")]
	public static void SetCollisionDust(ParticleSystem.CollisionModule psCollision, RFParticleCollisionDust coll)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x22B1240", Offset = "0x22B1240", VA = "0x22B1240")]
	public static void GetDebrisTargets(List<RayfireDebris> filtered, List<RayfireDebris> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x22B180C", Offset = "0x22B180C", VA = "0x22B180C")]
	public static void GetDustTargets(List<RayfireDust> filtered, List<RayfireDust> targets, float sizeThreshold, int percentage, int pType)
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x22B0EDC", Offset = "0x22B0EDC", VA = "0x22B0EDC")]
	public static void SetRigidDebrisFinalAmount(List<RayfireDebris> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x22B14A8", Offset = "0x22B14A8", VA = "0x22B14A8")]
	public static void SetDustFinalAmount(List<RayfireDust> targets, BurstType burstType, int burstAmount)
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x22B2960", Offset = "0x22B2960", VA = "0x22B2960")]
	public static int GetShardFinalAmount(RFShard shard, BurstType burstType, int burstAmount, float sizeSum)
	{
		return default(int);
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x22B593C", Offset = "0x22B593C", VA = "0x22B593C")]
	public static bool AmountCheck(RayfireRigid source, int pType)
	{
		return default(bool);
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x22B5B34", Offset = "0x22B5B34", VA = "0x22B5B34")]
	public RFParticles()
	{
	}
}
[Serializable]
[Token(Token = "0x200003B")]
public class RFShard : IComparable<RFShard>
{
	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float neibPosThreshold;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static float neibAreaThreshold;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float sz;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool uny;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool act;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Bounds bnd;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 pos;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SimType sm;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public float dm;

	[NonSerialized]
	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Quaternion rot;

	[NonSerialized]
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector3 scl;

	[NonSerialized]
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector3 los;

	[NonSerialized]
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float m;

	[NonSerialized]
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int lb;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public int nAm;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public List<int> nIds;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public List<float> nArea;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<int> sIds;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<float> nSt;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float sSt;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform tm;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public MeshFilter mf;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Collider col;

	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody rb;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public RayfireRigid rigid;

	[NonSerialized]
	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int fade;

	[NonSerialized]
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float fo;

	[NonSerialized]
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public List<RFTriangle> tris;

	[NonSerialized]
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public List<RFFace> poly;

	[NonSerialized]
	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public RFCluster cluster;

	[NonSerialized]
	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public List<RFShard> neibShards;

	[NonSerialized]
	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public bool check;

	[NonSerialized]
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public bool[] sCheck;

	[Token(Token = "0x1700000D")]
	public bool StressState
	{
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x22B75D4", Offset = "0x22B75D4", VA = "0x22B75D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public bool SupportState
	{
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x22B812C", Offset = "0x22B812C", VA = "0x22B812C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000F")]
	public bool InactiveOrKinematic
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x22B817C", Offset = "0x22B817C", VA = "0x22B817C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x22B5BF4", Offset = "0x22B5BF4", VA = "0x22B5BF4")]
	public RFShard()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x22A6EC0", Offset = "0x22A6EC0", VA = "0x22A6EC0")]
	public RFShard(RFShard source)
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x22B5C5C", Offset = "0x22B5C5C", VA = "0x22B5C5C")]
	public RFShard(Transform Tm)
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x22B5E44", Offset = "0x22B5E44", VA = "0x22B5E44")]
	public RFShard(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x22B5F60", Offset = "0x22B5F60", VA = "0x22B5F60", Slot = "4")]
	public int CompareTo(RFShard otherShard)
	{
		return default(int);
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x22B5F90", Offset = "0x22B5F90", VA = "0x22B5F90")]
	public static void SetMeshData(List<RFShard> shards, ConnectivityType type)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x22B6064", Offset = "0x22B6064", VA = "0x22B6064")]
	public static void SetMeshData(RFShard shard, ConnectivityType type)
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x22B60A4", Offset = "0x22B60A4", VA = "0x22B60A4")]
	public static void SetShards(RFCluster cluster, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x22B620C", Offset = "0x22B620C", VA = "0x22B620C")]
	public static void SetShardsByTransformList(RFCluster cluster, List<Transform> tmList, ConnectivityType connectivity, bool setRigid = false)
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x22B64E4", Offset = "0x22B64E4", VA = "0x22B64E4")]
	public static void SetShardsByRigidList(RFCluster cluster, List<RayfireRigid> rigids, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x22B6654", Offset = "0x22B6654", VA = "0x22B6654")]
	private float NeibAreaByPoly(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x22B682C", Offset = "0x22B682C", VA = "0x22B682C")]
	private float NeibAreaByTris(RFShard otherShard)
	{
		return default(float);
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x22B6A6C", Offset = "0x22B6A6C", VA = "0x22B6A6C")]
	public static void SetShardNeibs(List<RFShard> shards, ConnectivityType type, float minArea = 0f, float minSize = 0f, int perc = 0, int seed = 0)
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x22B7390", Offset = "0x22B7390", VA = "0x22B7390")]
	public static void ReinitNeibs(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x22B74A8", Offset = "0x22B74A8", VA = "0x22B74A8")]
	public void RemoveNeibAt(int ind)
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x22B7628", Offset = "0x22B7628", VA = "0x22B7628")]
	public void ClearNeib()
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x22A7DFC", Offset = "0x22A7DFC", VA = "0x22A7DFC")]
	public static void SetUnchecked(List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x22B7710", Offset = "0x22B7710", VA = "0x22B7710")]
	public static Plane GetSlicePlane(Bounds bound)
	{
		return default(Plane);
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x22B7878", Offset = "0x22B7878", VA = "0x22B7878")]
	public static List<RFShard> SortByDistanceToPoint(List<RFShard> shards, Vector3 point, int amount)
	{
		return null;
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x22B7CA0", Offset = "0x22B7CA0", VA = "0x22B7CA0")]
	public static List<RFShard> SortByDistanceToPlane(List<RFShard> shards, Vector3 point, Vector3 normal, int amount)
	{
		return null;
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x22A7E88", Offset = "0x22A7E88", VA = "0x22A7E88")]
	public static bool UnyieldingByShard(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x22B8090", Offset = "0x22B8090", VA = "0x22B8090")]
	public static bool AllUnyShards(List<RFShard> shards)
	{
		return default(bool);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x22B8190", Offset = "0x22B8190", VA = "0x22B8190")]
	public static RFShard GetShardByCollider(List<RFShard> shards, Collider collider)
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x22B8290", Offset = "0x22B8290", VA = "0x22B8290")]
	public static List<RFShard> GetShardsByColliders(List<RFShard> shards, List<Collider> colliders)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200003C")]
public class RFSound
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	public bool once;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float multiplier;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioClip clip;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> clips;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AudioMixerGroup outputGroup;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool played;

	[Token(Token = "0x17000010")]
	public bool HasClips
	{
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x22B8680", Offset = "0x22B8680", VA = "0x22B8680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x22B84AC", Offset = "0x22B84AC", VA = "0x22B84AC")]
	public RFSound()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x22B84D0", Offset = "0x22B84D0", VA = "0x22B84D0")]
	public RFSound(RFSound source)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x22B86D4", Offset = "0x22B86D4", VA = "0x22B86D4")]
	public static void CopySound(RayfireSound source, RayfireRigid target)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x22B8798", Offset = "0x22B8798", VA = "0x22B8798")]
	public static void CopySound(RayfireSound source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x22B8908", Offset = "0x22B8908", VA = "0x22B8908")]
	public static void Play(RayfireSound scr, AudioClip clip, AudioMixerGroup group, float volume)
	{
	}

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x22B8B64", Offset = "0x22B8B64", VA = "0x22B8B64")]
	public static void InitializationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x22B8F58", Offset = "0x22B8F58", VA = "0x22B8F58")]
	public static void ActivationSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x22B910C", Offset = "0x22B910C", VA = "0x22B910C")]
	public static void DemolitionSound(RayfireSound scr, float size)
	{
	}

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x22B8EA4", Offset = "0x22B8EA4", VA = "0x22B8EA4")]
	public static float GeVolume(RayfireSound scr, float size)
	{
		return default(float);
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x22B8D28", Offset = "0x22B8D28", VA = "0x22B8D28")]
	private static bool FilterCheck(RayfireSound scr, float size)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x200003D")]
public class RFStress
{
	[Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class <StressCor>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RayfireConnectivity scr;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RFStress <>4__this;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private WaitForSeconds <wait>5__2;

		[Token(Token = "0x17000011")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x22BC844", Offset = "0x22BC844", VA = "0x22BC844", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000012")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x22BC88C", Offset = "0x22BC88C", VA = "0x22BC88C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x22B94B8", Offset = "0x22B94B8", VA = "0x22B94B8")]
		[DebuggerHidden]
		public <StressCor>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x22BC6BC", Offset = "0x22BC6BC", VA = "0x22BC6BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x22BC6C0", Offset = "0x22BC6C0", VA = "0x22BC6C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x22BC84C", Offset = "0x22BC84C", VA = "0x22BC84C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int threshold;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float erosion;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float interval;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int support;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool exposed;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool bySize;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<RFShard> strShards;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<RFShard> supShards;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 rotCache;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 grvCache;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int supCache;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float sizeCache;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool initialized;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<RFShard> checkShards;

	[NonSerialized]
	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool inProgress;

	[NonSerialized]
	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int strAmount;

	[NonSerialized]
	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int supAmount;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<int> path;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private List<int> frontier;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<int> frontPrior;

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x22B92C0", Offset = "0x22B92C0", VA = "0x22B92C0")]
	public RFStress()
	{
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x22B9398", Offset = "0x22B9398", VA = "0x22B9398")]
	public static void StopStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x22B93B8", Offset = "0x22B93B8", VA = "0x22B93B8")]
	public static void StartStress(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x22B9444", Offset = "0x22B9444", VA = "0x22B9444")]
	[IteratorStateMachine(typeof(<StressCor>d__21))]
	private IEnumerator StressCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x22B94E0", Offset = "0x22B94E0", VA = "0x22B94E0")]
	private bool CheckSupport(RayfireConnectivity scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x22B9788", Offset = "0x22B9788", VA = "0x22B9788")]
	private static void StressErosion(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x22B9C0C", Offset = "0x22B9C0C", VA = "0x22B9C0C")]
	private static void StressCollapse(RayfireConnectivity connectivity, int maxStressValue)
	{
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x22B9C44", Offset = "0x22B9C44", VA = "0x22B9C44")]
	private static int RemNeibByStress(RFStress stress, int stressVal)
	{
		return default(int);
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x22B9E90", Offset = "0x22B9E90", VA = "0x22B9E90")]
	public static void Initialize(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x22B9EF8", Offset = "0x22B9EF8", VA = "0x22B9EF8")]
	private static bool InitializeNeed(RayfireConnectivity conn)
	{
		return default(bool);
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x22BA0C4", Offset = "0x22BA0C4", VA = "0x22BA0C4")]
	private static void SetStressConnections(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x22BADC0", Offset = "0x22BADC0", VA = "0x22BADC0")]
	private static void SetStressSupport(List<RFShard> shards, RFStress stress)
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x22BB560", Offset = "0x22BB560", VA = "0x22BB560")]
	private static void PrepareCheckShards(RFStress stress)
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x22BA708", Offset = "0x22BA708", VA = "0x22BA708")]
	private static void SetSizeMultiplier(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x22BC0C0", Offset = "0x22BC0C0", VA = "0x22BC0C0")]
	private static void SetSizeMultiplierOLD(RayfireConnectivity conn)
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x22BB618", Offset = "0x22BB618", VA = "0x22BB618")]
	private static List<int> GetPathAstar(RFStress str, List<RFShard> shards, int startId, int lastId)
	{
		return null;
	}
}
[Token(Token = "0x200003F")]
public enum AxisType
{
	[Token(Token = "0x4000152")]
	XRed,
	[Token(Token = "0x4000153")]
	YGreen,
	[Token(Token = "0x4000154")]
	ZBlue
}
[Token(Token = "0x2000040")]
public enum PlaneType
{
	[Token(Token = "0x4000156")]
	XY,
	[Token(Token = "0x4000157")]
	XZ,
	[Token(Token = "0x4000158")]
	YZ
}
[Token(Token = "0x2000041")]
public enum FragType
{
	[Token(Token = "0x400015A")]
	Voronoi = 0,
	[Token(Token = "0x400015B")]
	Splinters = 1,
	[Token(Token = "0x400015C")]
	Slabs = 2,
	[Token(Token = "0x400015D")]
	Radial = 3,
	[Token(Token = "0x400015E")]
	Custom = 5,
	[Token(Token = "0x400015F")]
	Slices = 7,
	[Token(Token = "0x4000160")]
	Bricks = 9,
	[Token(Token = "0x4000161")]
	Voxels = 10,
	[Token(Token = "0x4000162")]
	Tets = 11,
	[Token(Token = "0x4000163")]
	Decompose = 15
}
[Token(Token = "0x2000042")]
public enum DemolitionType
{
	[Token(Token = "0x4000165")]
	None = 0,
	[Token(Token = "0x4000166")]
	Runtime = 1,
	[Token(Token = "0x4000167")]
	AwakePrecache = 2,
	[Token(Token = "0x4000168")]
	AwakePrefragment = 3,
	[Token(Token = "0x4000169")]
	ReferenceDemolition = 9
}
[Token(Token = "0x2000043")]
public enum CachingType
{
	[Token(Token = "0x400016B")]
	Disable,
	[Token(Token = "0x400016C")]
	ByFrames,
	[Token(Token = "0x400016D")]
	ByFragmentsPerFrame
}
[Token(Token = "0x2000044")]
public enum FadeType
{
	[Token(Token = "0x400016F")]
	None = 0,
	[Token(Token = "0x4000170")]
	SimExclude = 1,
	[Token(Token = "0x4000171")]
	FallDown = 2,
	[Token(Token = "0x4000172")]
	ScaleDown = 3,
	[Token(Token = "0x4000173")]
	MoveDown = 4,
	[Token(Token = "0x4000174")]
	Destroy = 5,
	[Token(Token = "0x4000175")]
	SetStatic = 8,
	[Token(Token = "0x4000176")]
	SetKinematic = 9
}
[Token(Token = "0x2000045")]
public enum RFFadeLifeType
{
	[Token(Token = "0x4000178")]
	ByLifeTime = 4,
	[Token(Token = "0x4000179")]
	BySimulationAndLifeTime = 8
}
[Token(Token = "0x2000046")]
public enum MaterialType
{
	[Token(Token = "0x400017B")]
	HeavyMetal,
	[Token(Token = "0x400017C")]
	LightMetal,
	[Token(Token = "0x400017D")]
	DenseRock,
	[Token(Token = "0x400017E")]
	PorousRock,
	[Token(Token = "0x400017F")]
	Concrete,
	[Token(Token = "0x4000180")]
	Brick,
	[Token(Token = "0x4000181")]
	Glass,
	[Token(Token = "0x4000182")]
	Rubber,
	[Token(Token = "0x4000183")]
	Ice,
	[Token(Token = "0x4000184")]
	Wood
}
[Token(Token = "0x2000047")]
public enum MassType
{
	[Token(Token = "0x4000186")]
	MaterialDensity,
	[Token(Token = "0x4000187")]
	MassProperty,
	[Token(Token = "0x4000188")]
	RigidBodyComponent
}
[Token(Token = "0x2000048")]
public enum ObjectType
{
	[Token(Token = "0x400018A")]
	Mesh = 0,
	[Token(Token = "0x400018B")]
	MeshRoot = 1,
	[Token(Token = "0x400018C")]
	SkinnedMesh = 2,
	[Token(Token = "0x400018D")]
	NestedCluster = 4,
	[Token(Token = "0x400018E")]
	ConnectedCluster = 5
}
[Token(Token = "0x2000049")]
public enum SimType
{
	[Token(Token = "0x4000190")]
	Dynamic,
	[Token(Token = "0x4000191")]
	Sleeping,
	[Token(Token = "0x4000192")]
	Inactive,
	[Token(Token = "0x4000193")]
	Kinematic,
	[Token(Token = "0x4000194")]
	Static
}
[Token(Token = "0x200004A")]
public enum FragSimType
{
	[Token(Token = "0x4000196")]
	Dynamic,
	[Token(Token = "0x4000197")]
	Sleeping,
	[Token(Token = "0x4000198")]
	Inactive,
	[Token(Token = "0x4000199")]
	Kinematic,
	[Token(Token = "0x400019A")]
	Inherit
}
[Token(Token = "0x200004B")]
public enum ConnectivityType
{
	[Token(Token = "0x400019C")]
	ByBoundingBox = 0,
	[Token(Token = "0x400019D")]
	ByTriangles = 1,
	[Token(Token = "0x400019E")]
	ByPolygons = 3,
	[Token(Token = "0x400019F")]
	ByBoundingBoxAndTriangles = 2,
	[Token(Token = "0x40001A0")]
	ByBoundingBoxAndPolygons = 4
}
[Token(Token = "0x200004C")]
public enum FragmentMode
{
	[Token(Token = "0x40001A2")]
	Runtime,
	[Token(Token = "0x40001A3")]
	Editor
}
[Token(Token = "0x200004D")]
public enum RFColliderType
{
	[Token(Token = "0x40001A5")]
	Mesh = 0,
	[Token(Token = "0x40001A6")]
	Box = 1,
	[Token(Token = "0x40001A7")]
	Sphere = 2,
	[Token(Token = "0x40001A8")]
	None = 4
}
[Token(Token = "0x200004E")]
public enum RFParenting
{
	[Token(Token = "0x40001AA")]
	Manager = 0,
	[Token(Token = "0x40001AB")]
	Parent = 1,
	[Token(Token = "0x40001AC")]
	Sphere = 2,
	[Token(Token = "0x40001AD")]
	None = 4
}
[Serializable]
[Token(Token = "0x200004F")]
public class RFActivation
{
	[Token(Token = "0x2000050")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22BDB5C", Offset = "0x22BDB5C", VA = "0x22BDB5C", Slot = "4")]
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
			[Address(RVA = "0x22BDBA4", Offset = "0x22BDBA4", VA = "0x22BDBA4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x22BCA34", Offset = "0x22BCA34", VA = "0x22BCA34")]
		[DebuggerHidden]
		public <ActivationVelocityCor>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x22BD9F0", Offset = "0x22BD9F0", VA = "0x22BD9F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x22BD9F4", Offset = "0x22BD9F4", VA = "0x22BD9F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x22BDB64", Offset = "0x22BDB64", VA = "0x22BDB64", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000051")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22BDD74", Offset = "0x22BDD74", VA = "0x22BDD74", Slot = "4")]
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
			[Address(RVA = "0x22BDDBC", Offset = "0x22BDDBC", VA = "0x22BDDBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x22BCAD0", Offset = "0x22BCAD0", VA = "0x22BCAD0")]
		[DebuggerHidden]
		public <ActivationOffsetCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x22BDBAC", Offset = "0x22BDBAC", VA = "0x22BDBAC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x22BDBB0", Offset = "0x22BDBB0", VA = "0x22BDBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x22BDD7C", Offset = "0x22BDD7C", VA = "0x22BDD7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000052")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22BDF04", Offset = "0x22BDF04", VA = "0x22BDF04", Slot = "4")]
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
			[Address(RVA = "0x22BDF4C", Offset = "0x22BDF4C", VA = "0x22BDF4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x22BCB6C", Offset = "0x22BCB6C", VA = "0x22BCB6C")]
		[DebuggerHidden]
		public <InactiveCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x22BDDC4", Offset = "0x22BDDC4", VA = "0x22BDDC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x22BDDC8", Offset = "0x22BDDC8", VA = "0x22BDDC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x22BDF0C", Offset = "0x22BDF0C", VA = "0x22BDF0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000053")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22BE644", Offset = "0x22BE644", VA = "0x22BE644", Slot = "4")]
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
			[Address(RVA = "0x22BE68C", Offset = "0x22BE68C", VA = "0x22BE68C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x22BCC08", Offset = "0x22BCC08", VA = "0x22BCC08")]
		[DebuggerHidden]
		public <InactiveCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x22BDF54", Offset = "0x22BDF54", VA = "0x22BDF54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x22BDF58", Offset = "0x22BDF58", VA = "0x22BDF58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x22BE64C", Offset = "0x22BE64C", VA = "0x22BE64C", Slot = "8")]
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
	[Address(RVA = "0x22BC894", Offset = "0x22BC894", VA = "0x22BC894")]
	public RFActivation()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x22BC8D4", Offset = "0x22BC8D4", VA = "0x22BC8D4")]
	public void CopyFrom(RFActivation act)
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x22BC8C4", Offset = "0x22BC8C4", VA = "0x22BC8C4")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x22BC938", Offset = "0x22BC938", VA = "0x22BC938")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000147")]
	[Address(RVA = "0x22BC9C0", Offset = "0x22BC9C0", VA = "0x22BC9C0")]
	[IteratorStateMachine(typeof(<ActivationVelocityCor>d__23))]
	public IEnumerator ActivationVelocityCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x22BCA5C", Offset = "0x22BCA5C", VA = "0x22BCA5C")]
	[IteratorStateMachine(typeof(<ActivationOffsetCor>d__24))]
	public IEnumerator ActivationOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x22BCAF8", Offset = "0x22BCAF8", VA = "0x22BCAF8")]
	[IteratorStateMachine(typeof(<InactiveCor>d__25))]
	public IEnumerator InactiveCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x22BCB94", Offset = "0x22BCB94", VA = "0x22BCB94")]
	[IteratorStateMachine(typeof(<InactiveCor>d__26))]
	public IEnumerator InactiveCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x22BCC30", Offset = "0x22BCC30", VA = "0x22BCC30")]
	public static void ActivateRigid(RayfireRigid scr, bool connCheck = true)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x22BD254", Offset = "0x22BD254", VA = "0x22BD254")]
	public static bool ActivateShard(RFShard shard, RayfireRigidRoot rigidRoot)
	{
		return default(bool);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x22BD204", Offset = "0x22BD204", VA = "0x22BD204")]
	private static void SetActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x22BD6C8", Offset = "0x22BD6C8", VA = "0x22BD6C8")]
	public static void RestoreActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x22BD718", Offset = "0x22BD718", VA = "0x22BD718")]
	public static void BackupActivationLayer(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x22BD680", Offset = "0x22BD680", VA = "0x22BD680")]
	private static void SetActivationLayer(RFShard shard, RFActivation activation)
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x22BD754", Offset = "0x22BD754", VA = "0x22BD754")]
	public static void SetActivationLayer(List<RFShard> shards, RFActivation activation)
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x22BD814", Offset = "0x22BD814", VA = "0x22BD814")]
	public static void RestoreActivationLayer(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0x22BD904", Offset = "0x22BD904", VA = "0x22BD904")]
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
	[Address(RVA = "0x22BE694", Offset = "0x22BE694", VA = "0x22BE694")]
	private RFBackupCluster()
	{
	}

	[Token(Token = "0x600016D")]
	[Address(RVA = "0x22BE6B0", Offset = "0x22BE6B0", VA = "0x22BE6B0")]
	public static void BackupConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x22BEA10", Offset = "0x22BEA10", VA = "0x22BEA10")]
	public static void ResetRigidCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600016F")]
	[Address(RVA = "0x22BEC20", Offset = "0x22BEC20", VA = "0x22BEC20")]
	private static void DestroyParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0x22BF0E4", Offset = "0x22BF0E4", VA = "0x22BF0E4")]
	private static void ResetDeepShardRigid(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0x22BF9E8", Offset = "0x22BF9E8", VA = "0x22BF9E8")]
	private static void ResetShardRigid(RFShard shard)
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0x22BE7F8", Offset = "0x22BE7F8", VA = "0x22BE7F8")]
	public static void SaveTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0x22BF660", Offset = "0x22BF660", VA = "0x22BF660")]
	private static void RestoreShardTmRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0x22BF4D4", Offset = "0x22BF4D4", VA = "0x22BF4D4")]
	private static void ResetNestedTransformRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0x22BF1F8", Offset = "0x22BF1F8", VA = "0x22BF1F8")]
	private static void ResetNestedRootsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0x22BF59C", Offset = "0x22BF59C", VA = "0x22BF59C")]
	private static void ResetNestedParentsRecursive(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0x22BF87C", Offset = "0x22BF87C", VA = "0x22BF87C")]
	private static void DestroyRoots(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0x22BFCE4", Offset = "0x22BFCE4", VA = "0x22BFCE4")]
	private static bool BackupState(RayfireConnectivity scr, bool warning = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x22BFF50", Offset = "0x22BFF50", VA = "0x22BFF50")]
	public static void BackupConnectivity(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x22C0038", Offset = "0x22C0038", VA = "0x22C0038")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22C1C30", Offset = "0x22C1C30", VA = "0x22C1C30", Slot = "4")]
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
			[Address(RVA = "0x22C1C78", Offset = "0x22C1C78", VA = "0x22C1C78", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x22C0A1C", Offset = "0x22C0A1C", VA = "0x22C0A1C")]
		[DebuggerHidden]
		public <CollapseCor>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x22C1A60", Offset = "0x22C1A60", VA = "0x22C1A60", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x22C1A64", Offset = "0x22C1A64", VA = "0x22C1A64", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x22C1C38", Offset = "0x22C1C38", VA = "0x22C1C38", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000058")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22C1E48", Offset = "0x22C1E48", VA = "0x22C1E48", Slot = "4")]
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
			[Address(RVA = "0x22C1E90", Offset = "0x22C1E90", VA = "0x22C1E90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x22C0B64", Offset = "0x22C0B64", VA = "0x22C0B64")]
		[DebuggerHidden]
		public <CollapseCor>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x22C1C80", Offset = "0x22C1C80", VA = "0x22C1C80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x22C1C84", Offset = "0x22C1C84", VA = "0x22C1C84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x22C1E50", Offset = "0x22C1E50", VA = "0x22C1E50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[Tooltip(" By Area: Shard will loose it's connections if it's shared area surface is less then defined value.\n By Size: Shard will loose it's connections if it's Size is less then defined value.\n Random: Shard will loose it's connections if it's random value in range from 0 to 100 is less then defined value.")]
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
	[Address(RVA = "0x22C08E0", Offset = "0x22C08E0", VA = "0x22C08E0")]
	public RFCollapse()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0x22C090C", Offset = "0x22C090C", VA = "0x22C090C")]
	public static void StartCollapse(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0x22C09A8", Offset = "0x22C09A8", VA = "0x22C09A8")]
	[IteratorStateMachine(typeof(<CollapseCor>d__9))]
	private IEnumerator CollapseCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x22C0A44", Offset = "0x22C0A44", VA = "0x22C0A44")]
	public static void StartCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x22C0B44", Offset = "0x22C0B44", VA = "0x22C0B44")]
	public static void StopCollapse(RayfireConnectivity scr)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0x22C0AD0", Offset = "0x22C0AD0", VA = "0x22C0AD0")]
	[IteratorStateMachine(typeof(<CollapseCor>d__12))]
	private IEnumerator CollapseCor(RayfireConnectivity scr)
	{
		return null;
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x22C0B8C", Offset = "0x22C0B8C", VA = "0x22C0B8C")]
	public static void AreaCollapse(RayfireRigid scr, int areaPercentage)
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0x22C0C4C", Offset = "0x22C0C4C", VA = "0x22C0C4C")]
	public static void SizeCollapse(RayfireRigid scr, int sizePercentage)
	{
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0x22C0BF4", Offset = "0x22C0BF4", VA = "0x22C0BF4")]
	public static void AreaCollapse(RayfireRigid scr, float minAreaValue)
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0x22C0CB4", Offset = "0x22C0CB4", VA = "0x22C0CB4")]
	public static void SizeCollapse(RayfireRigid scr, float minSizeValue)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x22C12B0", Offset = "0x22C12B0", VA = "0x22C12B0")]
	public static void RandomCollapse(RayfireRigid scr, int randomValue, int randomSeed)
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x22C0F54", Offset = "0x22C0F54", VA = "0x22C0F54")]
	private static void CollapseCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x22C1738", Offset = "0x22C1738", VA = "0x22C1738")]
	public static void AreaCollapse(RayfireConnectivity connectivity, int areaPercentage)
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x22C17E4", Offset = "0x22C17E4", VA = "0x22C17E4")]
	public static void SizeCollapse(RayfireConnectivity connectivity, int sizePercentage)
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x22C1798", Offset = "0x22C1798", VA = "0x22C1798")]
	public static void AreaCollapse(RayfireConnectivity connectivity, float areaValue)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x22C1844", Offset = "0x22C1844", VA = "0x22C1844")]
	public static void SizeCollapse(RayfireConnectivity connectivity, float sizeValue)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x22C1890", Offset = "0x22C1890", VA = "0x22C1890")]
	public static void RandomCollapse(RayfireConnectivity connectivity, int randomPercentage, int seedValue)
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0x22C0D0C", Offset = "0x22C0D0C", VA = "0x22C0D0C")]
	private static int RemNeibByArea(RFCluster cluster, float minArea)
	{
		return default(int);
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x22C10AC", Offset = "0x22C10AC", VA = "0x22C10AC")]
	private static int RemNeibBySize(RFCluster cluster, float minSize)
	{
		return default(int);
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x22C1308", Offset = "0x22C1308", VA = "0x22C1308")]
	private static int RemNeibRandom(RFCluster cluster, int percent, int seed)
	{
		return default(int);
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x22C18EC", Offset = "0x22C18EC", VA = "0x22C18EC")]
	private static void RemoveConnection(RFCluster cluster, int s, int n)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x22C0618", Offset = "0x22C0618", VA = "0x22C0618")]
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
	[Address(RVA = "0x22C1E98", Offset = "0x22C1E98", VA = "0x22C1E98")]
	public RFDamage()
	{
	}

	[Token(Token = "0x600019E")]
	[Address(RVA = "0x22C1ED4", Offset = "0x22C1ED4", VA = "0x22C1ED4")]
	public void CopyFrom(RFDamage damage)
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0x22BFCDC", Offset = "0x22BFCDC", VA = "0x22BFCDC")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0x22C1F0C", Offset = "0x22C1F0C", VA = "0x22C1F0C")]
	public static bool ApplyTo(RayfireRigid scr, float value, Vector3 point, float radius = 0f, [Optional] Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A1")]
	[Address(RVA = "0x22C20E0", Offset = "0x22C20E0", VA = "0x22C20E0")]
	public static bool ApplyToRigid(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0x22C1F44", Offset = "0x22C1F44", VA = "0x22C1F44")]
	public static bool ApplyToShard(RayfireRigid scr, float value, Vector3 point, float radius, Collider collider)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x22C2128", Offset = "0x22C2128", VA = "0x22C2128")]
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
		[Address(RVA = "0x22C767C", Offset = "0x22C767C", VA = "0x22C767C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000020")]
	public bool HasMinorClusters
	{
		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x22C2A98", Offset = "0x22C2A98", VA = "0x22C2A98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0x22C229C", Offset = "0x22C229C", VA = "0x22C229C")]
	public RFDemolitionCluster()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x22C22F4", Offset = "0x22C22F4", VA = "0x22C22F4")]
	public void CopyFrom(RFDemolitionCluster demolition)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x22BFCD4", Offset = "0x22BFCD4", VA = "0x22BFCD4")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0x22C234C", Offset = "0x22C234C", VA = "0x22C234C")]
	public static void ResetClusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x22C2408", Offset = "0x22C2408", VA = "0x22C2408")]
	public static void ClusterizeEditor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0x22C24A8", Offset = "0x22C24A8", VA = "0x22C24A8")]
	public static void Clusterize(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0x22C2900", Offset = "0x22C2900", VA = "0x22C2900")]
	private static void ClusterizeConnected(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AB")]
	[Address(RVA = "0x22C2708", Offset = "0x22C2708", VA = "0x22C2708")]
	private static void ClusterizeNested(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001AC")]
	[Address(RVA = "0x22C2AEC", Offset = "0x22C2AEC", VA = "0x22C2AEC")]
	private static void ClusterizeNestedRecursive(RayfireRigid scr, Transform transform, RFCluster cluster, ConnectivityType connectivity)
	{
	}

	[Token(Token = "0x60001AD")]
	[Address(RVA = "0x22C2F10", Offset = "0x22C2F10", VA = "0x22C2F10")]
	public static bool DemolishCluster(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x22C31E4", Offset = "0x22C31E4", VA = "0x22C31E4")]
	public static List<RFShard> DemolishConnectedCluster(RayfireRigid scr, [Optional] Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x22C3394", Offset = "0x22C3394", VA = "0x22C3394")]
	private static Collider[] GetDetachColliders(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x22C370C", Offset = "0x22C370C", VA = "0x22C370C")]
	private static List<RFShard> DetachShardsByColliders(RayfireRigid scr, Collider[] detachColliders)
	{
		return null;
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x22C3014", Offset = "0x22C3014", VA = "0x22C3014")]
	private static void DemolishNestedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x22C1584", Offset = "0x22C1584", VA = "0x22C1584")]
	public static void PostDemolitionCluster(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x22C3FB4", Offset = "0x22C3FB4", VA = "0x22C3FB4")]
	private static void SetupDetachShards(RayfireRigid scr, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x22C409C", Offset = "0x22C409C", VA = "0x22C409C")]
	private static void CreateChildClusters(RayfireRigid scr, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x22C4194", Offset = "0x22C4194", VA = "0x22C4194")]
	private static void UpdateOriginalCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x22C5248", Offset = "0x22C5248", VA = "0x22C5248")]
	public static void SliceConnectedCluster(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x22C5B00", Offset = "0x22C5B00", VA = "0x22C5B00")]
	private static void SetupPlaneShards(RayfireRigid scr, List<RFShard> clusterShards, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x22C3BA8", Offset = "0x22C3BA8", VA = "0x22C3BA8")]
	private static void ClusterizeDetachShards(RayfireRigid scr, List<RFShard> detachShards, int clusterAmount, int sortType)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x22C47E8", Offset = "0x22C47E8", VA = "0x22C47E8")]
	public static void CreateClusterRuntime(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x22C5F08", Offset = "0x22C5F08", VA = "0x22C5F08")]
	private static void DivideAllShards(RFCluster cluster, List<RFShard> detachShards, int amount)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x22C66B4", Offset = "0x22C66B4", VA = "0x22C66B4")]
	private static void DivideShards(RFCluster mainCluster, RFCluster childCluster)
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x22C6B64", Offset = "0x22C6B64", VA = "0x22C6B64")]
	public static void DetachEdgeShards(RFCluster cluster, List<RFShard> detachShards, int edgeShardArea)
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x22C65A0", Offset = "0x22C65A0", VA = "0x22C65A0")]
	private static void DetachOneNeibShards(List<RFCluster> childClusters, List<RFShard> detachShards, int edgeAmount, int startIndex)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x22C6F20", Offset = "0x22C6F20", VA = "0x22C6F20")]
	private static void DetachOneNeibShard(RFCluster cls, List<RFShard> detachShards)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x22C44BC", Offset = "0x22C44BC", VA = "0x22C44BC")]
	private static void AddRigidComponent(RayfireRigid scr, List<RFShard> shardList)
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x22C7188", Offset = "0x22C7188", VA = "0x22C7188")]
	private static void AddRigidComponent(RayfireRigid scr, RFShard shard, Transform parent)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x22C46E4", Offset = "0x22C46E4", VA = "0x22C46E4")]
	private static void SetRigidRootShard(RayfireRigid scr, List<RFShard> shards)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x22C7558", Offset = "0x22C7558", VA = "0x22C7558")]
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
	[Address(RVA = "0x22C773C", Offset = "0x22C773C", VA = "0x22C773C")]
	public void SetupSkin(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x22C77D8", Offset = "0x22C77D8", VA = "0x22C77D8")]
	public void SeparateSkins(Vector3 planeNormal, Vector3 planePoint)
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x22C7A08", Offset = "0x22C7A08", VA = "0x22C7A08")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22CBFB0", Offset = "0x22CBFB0", VA = "0x22CBFB0", Slot = "4")]
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
			[Address(RVA = "0x22CBFF8", Offset = "0x22CBFF8", VA = "0x22CBFF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x22CADD4", Offset = "0x22CADD4", VA = "0x22CADD4")]
		[DebuggerHidden]
		public <RuntimeCachingCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x22CB354", Offset = "0x22CB354", VA = "0x22CB354", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x22CB358", Offset = "0x22CB358", VA = "0x22CB358", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x22CBFB8", Offset = "0x22CBFB8", VA = "0x22CBFB8", Slot = "8")]
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
	[Address(RVA = "0x22C7A10", Offset = "0x22C7A10", VA = "0x22C7A10")]
	public RFDemolitionMesh()
	{
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x22C7BCC", Offset = "0x22C7BCC", VA = "0x22C7BCC")]
	public void CopyFrom(RFDemolitionMesh demolition)
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x22C7BC0", Offset = "0x22C7BC0", VA = "0x22C7BC0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x22C7D10", Offset = "0x22C7D10", VA = "0x22C7D10")]
	public static bool DemolishMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x22C8A18", Offset = "0x22C8A18", VA = "0x22C8A18")]
	public static bool ClusterizeFragments(RayfireRigid rigid)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x22C7F84", Offset = "0x22C7F84", VA = "0x22C7F84")]
	public static List<RayfireRigid> CreateFragments(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x22C96D0", Offset = "0x22C96D0", VA = "0x22C96D0")]
	public static void SliceMesh(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x22CA204", Offset = "0x22CA204", VA = "0x22CA204")]
	public static List<RayfireRigid> CreateSlices(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x22C8EC4", Offset = "0x22C8EC4", VA = "0x22C8EC4")]
	private static void SetFragmentSimulationType(RayfireRigid frag, RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x22C8948", Offset = "0x22C8948", VA = "0x22C8948")]
	private static void CacheRuntime(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x22CA92C", Offset = "0x22CA92C", VA = "0x22CA92C")]
	private static void CacheInstant(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x22CAD60", Offset = "0x22CAD60", VA = "0x22CAD60")]
	[IteratorStateMachine(typeof(<RuntimeCachingCor>d__33))]
	public IEnumerator RuntimeCachingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x22CADFC", Offset = "0x22CADFC", VA = "0x22CADFC")]
	public void StopRuntimeCaching()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x22CAE24", Offset = "0x22CAE24", VA = "0x22CAE24")]
	private void ResetRuntimeCaching(RayfireRigid scr, GameObject tmRefGo)
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0x22CAE7C", Offset = "0x22CAE7C", VA = "0x22CAE7C")]
	public static void AwakePrecache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0x22CAF74", Offset = "0x22CAF74", VA = "0x22CAF74")]
	public static void AwakePrefragment(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0x22CAEF8", Offset = "0x22CAEF8", VA = "0x22CAEF8")]
	private static void PreCache(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0x22CAFFC", Offset = "0x22CAFFC", VA = "0x22CAFFC")]
	public static void ChildrenToFragments(RayfireRigid scr)
	{
	}
}
[Serializable]
[Token(Token = "0x2000060")]
public class RFFade
{
	[Token(Token = "0x2000061")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CD468", Offset = "0x22CD468", VA = "0x22CD468", Slot = "4")]
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
			[Address(RVA = "0x22CD4B0", Offset = "0x22CD4B0", VA = "0x22CD4B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x22CC314", Offset = "0x22CC314", VA = "0x22CC314")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x22CD224", Offset = "0x22CD224", VA = "0x22CD224", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x22CD228", Offset = "0x22CD228", VA = "0x22CD228", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x22CD470", Offset = "0x22CD470", VA = "0x22CD470", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000062")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CD7DC", Offset = "0x22CD7DC", VA = "0x22CD7DC", Slot = "4")]
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
			[Address(RVA = "0x22CD824", Offset = "0x22CD824", VA = "0x22CD824", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x22CC3A4", Offset = "0x22CC3A4", VA = "0x22CC3A4")]
		[DebuggerHidden]
		public <FadeOffsetCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x22CD4B8", Offset = "0x22CD4B8", VA = "0x22CD4B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x22CD4BC", Offset = "0x22CD4BC", VA = "0x22CD4BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x22CD7E4", Offset = "0x22CD7E4", VA = "0x22CD7E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000063")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CDAB8", Offset = "0x22CDAB8", VA = "0x22CDAB8", Slot = "4")]
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
			[Address(RVA = "0x22CDB00", Offset = "0x22CDB00", VA = "0x22CDB00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x22CC630", Offset = "0x22CC630", VA = "0x22CC630")]
		[DebuggerHidden]
		public <LivingCor>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x22CD82C", Offset = "0x22CD82C", VA = "0x22CD82C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x22CD830", Offset = "0x22CD830", VA = "0x22CD830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x22CDAC0", Offset = "0x22CDAC0", VA = "0x22CDAC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CDD88", Offset = "0x22CDD88", VA = "0x22CDD88", Slot = "4")]
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
			[Address(RVA = "0x22CDDD0", Offset = "0x22CDDD0", VA = "0x22CDDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x22CC658", Offset = "0x22CC658", VA = "0x22CC658")]
		[DebuggerHidden]
		public <LivingCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x22CDB08", Offset = "0x22CDB08", VA = "0x22CDB08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x22CDB0C", Offset = "0x22CDB0C", VA = "0x22CDB0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x22CDD90", Offset = "0x22CDD90", VA = "0x22CDD90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CDF58", Offset = "0x22CDF58", VA = "0x22CDF58", Slot = "4")]
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
			[Address(RVA = "0x22CDFA0", Offset = "0x22CDFA0", VA = "0x22CDFA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x22CC6E8", Offset = "0x22CC6E8", VA = "0x22CC6E8")]
		[DebuggerHidden]
		public <SimulationLivingCor>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x22CDDD8", Offset = "0x22CDDD8", VA = "0x22CDDD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x22CDDDC", Offset = "0x22CDDDC", VA = "0x22CDDDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x22CDF60", Offset = "0x22CDF60", VA = "0x22CDF60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CE188", Offset = "0x22CE188", VA = "0x22CE188", Slot = "4")]
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
			[Address(RVA = "0x22CE1D0", Offset = "0x22CE1D0", VA = "0x22CE1D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x22CCA28", Offset = "0x22CCA28", VA = "0x22CCA28")]
		[DebuggerHidden]
		public <FallDownCor>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x22CDFA8", Offset = "0x22CDFA8", VA = "0x22CDFA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x22CDFAC", Offset = "0x22CDFAC", VA = "0x22CDFAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x22CE190", Offset = "0x22CE190", VA = "0x22CE190", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000067")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CE36C", Offset = "0x22CE36C", VA = "0x22CE36C", Slot = "4")]
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
			[Address(RVA = "0x22CE3B4", Offset = "0x22CE3B4", VA = "0x22CE3B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x22CCAC4", Offset = "0x22CCAC4", VA = "0x22CCAC4")]
		[DebuggerHidden]
		public <FallDownCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x22CE1D8", Offset = "0x22CE1D8", VA = "0x22CE1D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x22CE1DC", Offset = "0x22CE1DC", VA = "0x22CE1DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x22CE374", Offset = "0x22CE374", VA = "0x22CE374", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000068")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CE580", Offset = "0x22CE580", VA = "0x22CE580", Slot = "4")]
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
			[Address(RVA = "0x22CE5C8", Offset = "0x22CE5C8", VA = "0x22CE5C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x22CCB54", Offset = "0x22CCB54", VA = "0x22CCB54")]
		[DebuggerHidden]
		public <ScaleDownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x22CE3BC", Offset = "0x22CE3BC", VA = "0x22CE3BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x22CE3C0", Offset = "0x22CE3C0", VA = "0x22CE3C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x22CE588", Offset = "0x22CE588", VA = "0x22CE588", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CE7D8", Offset = "0x22CE7D8", VA = "0x22CE7D8", Slot = "4")]
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
			[Address(RVA = "0x22CE820", Offset = "0x22CE820", VA = "0x22CE820", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x22CCBF0", Offset = "0x22CCBF0", VA = "0x22CCBF0")]
		[DebuggerHidden]
		public <ScaleDownCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x22CE5D0", Offset = "0x22CE5D0", VA = "0x22CE5D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x22CE5D4", Offset = "0x22CE5D4", VA = "0x22CE5D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x22CE7E0", Offset = "0x22CE7E0", VA = "0x22CE7E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006A")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CEC18", Offset = "0x22CEC18", VA = "0x22CEC18", Slot = "4")]
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
			[Address(RVA = "0x22CEC60", Offset = "0x22CEC60", VA = "0x22CEC60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x22CCC80", Offset = "0x22CCC80", VA = "0x22CCC80")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x22CE828", Offset = "0x22CE828", VA = "0x22CE828", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x22CE82C", Offset = "0x22CE82C", VA = "0x22CE82C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x22CEC20", Offset = "0x22CEC20", VA = "0x22CEC20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200006B")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22CEFB0", Offset = "0x22CEFB0", VA = "0x22CEFB0", Slot = "4")]
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
			[Address(RVA = "0x22CEFF8", Offset = "0x22CEFF8", VA = "0x22CEFF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x22CCD1C", Offset = "0x22CCD1C", VA = "0x22CCD1C")]
		[DebuggerHidden]
		public <FadeMoveDownCor>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x22CEC68", Offset = "0x22CEC68", VA = "0x22CEC68", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x22CEC6C", Offset = "0x22CEC6C", VA = "0x22CEC6C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x22CEFB8", Offset = "0x22CEFB8", VA = "0x22CEFB8", Slot = "8")]
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
	[Address(RVA = "0x22CC000", Offset = "0x22CC000", VA = "0x22CC000")]
	public RFFade()
	{
	}

	[Token(Token = "0x60001E3")]
	[Address(RVA = "0x22CC06C", Offset = "0x22CC06C", VA = "0x22CC06C")]
	public void CopyFrom(RFFade fade)
	{
	}

	[Token(Token = "0x60001E4")]
	[Address(RVA = "0x22CC058", Offset = "0x22CC058", VA = "0x22CC058")]
	public void Reset()
	{
	}

	[Token(Token = "0x60001E5")]
	[Address(RVA = "0x22CC0B0", Offset = "0x22CC0B0", VA = "0x22CC0B0")]
	public void DemolitionFade(List<RayfireRigid> fadeObjects)
	{
	}

	[Token(Token = "0x60001E6")]
	[Address(RVA = "0x22CC2AC", Offset = "0x22CC2AC", VA = "0x22CC2AC")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__19))]
	public static IEnumerator FadeOffsetCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001E7")]
	[Address(RVA = "0x22CC33C", Offset = "0x22CC33C", VA = "0x22CC33C")]
	[IteratorStateMachine(typeof(<FadeOffsetCor>d__20))]
	public static IEnumerator FadeOffsetCor(RayfireRigidRoot scr)
	{
		return null;
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x22CC19C", Offset = "0x22CC19C", VA = "0x22CC19C")]
	public static void FadeRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x22CC434", Offset = "0x22CC434", VA = "0x22CC434")]
	public static void FadeShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x22CC514", Offset = "0x22CC514", VA = "0x22CC514")]
	public static void FadeClusterShards(RayfireRigid scr, List<RFShard> fadeShards)
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x22CC3CC", Offset = "0x22CC3CC", VA = "0x22CC3CC")]
	[IteratorStateMachine(typeof(<LivingCor>d__24))]
	private static IEnumerator LivingCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x22CC4A0", Offset = "0x22CC4A0", VA = "0x22CC4A0")]
	[IteratorStateMachine(typeof(<LivingCor>d__25))]
	private static IEnumerator LivingCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x22CC680", Offset = "0x22CC680", VA = "0x22CC680")]
	[IteratorStateMachine(typeof(<SimulationLivingCor>d__26))]
	private static IEnumerator SimulationLivingCor(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x22CC710", Offset = "0x22CC710", VA = "0x22CC710")]
	private static void FadeExclude(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x22CC8EC", Offset = "0x22CC8EC", VA = "0x22CC8EC")]
	private static void FadeExclude(RayfireRigidRoot root, RFShard shard)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x22CC9C0", Offset = "0x22CC9C0", VA = "0x22CC9C0")]
	[IteratorStateMachine(typeof(<FallDownCor>d__29))]
	private static IEnumerator FallDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x22CCA50", Offset = "0x22CCA50", VA = "0x22CCA50")]
	[IteratorStateMachine(typeof(<FallDownCor>d__30))]
	private static IEnumerator FallDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x22CCAEC", Offset = "0x22CCAEC", VA = "0x22CCAEC")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__31))]
	private static IEnumerator ScaleDownCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x22CCB7C", Offset = "0x22CCB7C", VA = "0x22CCB7C")]
	[IteratorStateMachine(typeof(<ScaleDownCor>d__32))]
	private static IEnumerator ScaleDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x22CCC18", Offset = "0x22CCC18", VA = "0x22CCC18")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__33))]
	private static IEnumerator FadeMoveDownCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x22CCCA8", Offset = "0x22CCCA8", VA = "0x22CCCA8")]
	[IteratorStateMachine(typeof(<FadeMoveDownCor>d__34))]
	private static IEnumerator FadeMoveDownCor(RayfireRigidRoot root, RFShard shard)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x22CCD44", Offset = "0x22CCD44", VA = "0x22CCD44")]
	private static void DisableClusterColliders(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x22CCF50", Offset = "0x22CCF50", VA = "0x22CCF50")]
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
	[Address(RVA = "0x22C7B30", Offset = "0x22C7B30", VA = "0x22C7B30")]
	public RFFragmentProperties()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0x22C7CC8", Offset = "0x22C7CC8", VA = "0x22C7CC8")]
	public void CopyFrom(RFFragmentProperties fragmentProperties)
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0x22C9060", Offset = "0x22C9060", VA = "0x22C9060")]
	public int GetLayer(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0x22C90AC", Offset = "0x22C90AC", VA = "0x22C90AC")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22D0E9C", Offset = "0x22D0E9C", VA = "0x22D0E9C", Slot = "4")]
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
			[Address(RVA = "0x22D0EE4", Offset = "0x22D0EE4", VA = "0x22D0EE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x22CF24C", Offset = "0x22CF24C", VA = "0x22CF24C")]
		[DebuggerHidden]
		public <DemolishableCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x22D0D90", Offset = "0x22D0D90", VA = "0x22D0D90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x22D0D94", Offset = "0x22D0D94", VA = "0x22D0D94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x22D0EA4", Offset = "0x22D0EA4", VA = "0x22D0EA4", Slot = "8")]
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
	[Address(RVA = "0x22CF000", Offset = "0x22CF000", VA = "0x22CF000")]
	public RFLimitations()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0x22CF18C", Offset = "0x22CF18C", VA = "0x22CF18C")]
	public void CopyFrom(RFLimitations limitations)
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0x22CF090", Offset = "0x22CF090", VA = "0x22CF090")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000241")]
	[Address(RVA = "0x22CF1D8", Offset = "0x22CF1D8", VA = "0x22CF1D8")]
	[IteratorStateMachine(typeof(<DemolishableCor>d__28))]
	public IEnumerator DemolishableCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0x22CF274", Offset = "0x22CF274", VA = "0x22CF274")]
	public static void Checks(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0x22D09DC", Offset = "0x22D09DC", VA = "0x22D09DC")]
	public static void SetBound(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000244")]
	[Address(RVA = "0x22D0B08", Offset = "0x22D0B08", VA = "0x22D0B08")]
	public static void SetAncestor(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000245")]
	[Address(RVA = "0x22D0C34", Offset = "0x22D0C34", VA = "0x22D0C34")]
	public static void SetDescendants(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0x22C8EFC", Offset = "0x22C8EFC", VA = "0x22C8EFC")]
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
		[Address(RVA = "0x22D4618", Offset = "0x22D4618", VA = "0x22D4618")]
		public RFIgnorePair(int A, int B)
		{
		}
	}

	[Token(Token = "0x2000071")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22D4950", Offset = "0x22D4950", VA = "0x22D4950", Slot = "4")]
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
			[Address(RVA = "0x22D4998", Offset = "0x22D4998", VA = "0x22D4998", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x22D4694", Offset = "0x22D4694", VA = "0x22D4694")]
		[DebuggerHidden]
		public <PhysicsDataCor>d__71(int <>1__state)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x22D47F0", Offset = "0x22D47F0", VA = "0x22D47F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x22D47F4", Offset = "0x22D47F4", VA = "0x22D47F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x22D4958", Offset = "0x22D4958", VA = "0x22D4958", Slot = "8")]
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
		[Address(RVA = "0x22D3A40", Offset = "0x22D3A40", VA = "0x22D3A40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003C")]
	public bool HasClusterColliders
	{
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x22CCEF8", Offset = "0x22CCEF8", VA = "0x22CCEF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003D")]
	public bool Destructible
	{
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x22D46BC", Offset = "0x22D46BC", VA = "0x22D46BC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700003E")]
	public int Solidity
	{
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x22D4730", Offset = "0x22D4730", VA = "0x22D4730")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700003F")]
	public PhysicMaterial PhysMaterial
	{
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x22D2FB0", Offset = "0x22D2FB0", VA = "0x22D2FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x22D0EEC", Offset = "0x22D0EEC", VA = "0x22D0EEC")]
	public RFPhysic()
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x22D10AC", Offset = "0x22D10AC", VA = "0x22D10AC")]
	public void CopyFrom(RFPhysic physics)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x22D1048", Offset = "0x22D1048", VA = "0x22D1048")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x22D1100", Offset = "0x22D1100", VA = "0x22D1100")]
	public void SaveInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x22D1174", Offset = "0x22D1174", VA = "0x22D1174")]
	public void LoadInitTransform(Transform tm)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x22D11D0", Offset = "0x22D11D0", VA = "0x22D11D0")]
	public static void SetSimulationType(Rigidbody rb, SimType simulationType, ObjectType objectType, bool useGravity, int solver)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0x22D1368", Offset = "0x22D1368", VA = "0x22D1368")]
	private static void SetDynamic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0x22D1458", Offset = "0x22D1458", VA = "0x22D1458")]
	private static void SetSleeping(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0x22D14A0", Offset = "0x22D14A0", VA = "0x22D14A0")]
	private static void SetInactive(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0x22D14DC", Offset = "0x22D14DC", VA = "0x22D14DC")]
	private static void SetKinematic(Rigidbody rb, bool useGravity)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0x22D13A4", Offset = "0x22D13A4", VA = "0x22D13A4")]
	private static void SetCollisionDetection(Rigidbody rb, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000259")]
	[Address(RVA = "0x22D1528", Offset = "0x22D1528", VA = "0x22D1528")]
	public static void SetDensity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0x22D17D4", Offset = "0x22D17D4", VA = "0x22D17D4")]
	public static void SetDensity(RFShard shard, RFPhysic physics, float density)
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0x22D169C", Offset = "0x22D169C", VA = "0x22D169C")]
	private static float MassLimit(float m)
	{
		return default(float);
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0x22C92B4", Offset = "0x22C92B4", VA = "0x22C92B4")]
	public static void SetMassByParent(RFPhysic target, float targetSize, float parentMass, float parentSize)
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0x22D18C4", Offset = "0x22D18C4", VA = "0x22D18C4")]
	public static void SetDrag(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0x22D19A0", Offset = "0x22D19A0", VA = "0x22D19A0")]
	public static void SetDrag(RFShard shard, float drag, float dragAngular)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x22D19E4", Offset = "0x22D19E4", VA = "0x22D19E4")]
	public static void SetFragmentsVelocity(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0x22C9148", Offset = "0x22C9148", VA = "0x22C9148")]
	public static void SetFragmentCollider(RayfireRigid scr, Mesh mesh)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x22D1C54", Offset = "0x22D1C54", VA = "0x22D1C54")]
	public static void SetRigidCollider(RayfireRigid scr, [Optional] Mesh mesh)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0x22D2140", Offset = "0x22D2140", VA = "0x22D2140")]
	public static void SetRigidRootCollider(RayfireRigidRoot root, RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0x22D2360", Offset = "0x22D2360", VA = "0x22D2360")]
	public static void SetupMeshRootColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0x22D256C", Offset = "0x22D256C", VA = "0x22D256C")]
	public static void SetClusterCollidersByShards(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0x22D26E0", Offset = "0x22D26E0", VA = "0x22D26E0")]
	private static void CollidersRemoveNull(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0x22D2830", Offset = "0x22D2830", VA = "0x22D2830")]
	private static void SetShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0x22D2A70", Offset = "0x22D2A70", VA = "0x22D2A70")]
	private static void SetDeepShardColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0x22D2B6C", Offset = "0x22D2B6C", VA = "0x22D2B6C")]
	public static void CollectClusterColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0x22D2C60", Offset = "0x22D2C60", VA = "0x22D2C60")]
	private static void CollectDeepColliders(RayfireRigid scr, RFCluster cluster)
	{
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0x22D2E2C", Offset = "0x22D2E2C", VA = "0x22D2E2C")]
	public static void SetColliderMaterial(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x22D3030", Offset = "0x22D3030", VA = "0x22D3030")]
	public static void SetColliderMaterial(RFPhysic physics, RFShard shard)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x22D30C4", Offset = "0x22D30C4", VA = "0x22D30C4")]
	public static void SetParticleColliderMaterial(List<RayfireDebris> debris)
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x22D31CC", Offset = "0x22D31CC", VA = "0x22D31CC")]
	public static void SetColliderConvex(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x22D32C0", Offset = "0x22D32C0", VA = "0x22D32C0")]
	public static void DestroyColliders(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x22D341C", Offset = "0x22D341C", VA = "0x22D341C")]
	public static void SetPhysics(RayfireRigidRoot root)
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x22D3530", Offset = "0x22D3530", VA = "0x22D3530")]
	public static void SetPhysics(List<RFShard> shards, RFPhysic physic)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x22D3840", Offset = "0x22D3840", VA = "0x22D3840")]
	public static void SetPhysics(RFShard shard, RFPhysic physic)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x22C92F0", Offset = "0x22C92F0", VA = "0x22C92F0")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RayfireRigid> rigids)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x22D418C", Offset = "0x22D418C", VA = "0x22D418C")]
	public static void SetIgnoreColliders(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x22D426C", Offset = "0x22D426C", VA = "0x22D426C")]
	public static void SetIgnoreListShards(RFPhysic physics, List<RFShard> shards)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x22D3D80", Offset = "0x22D3D80", VA = "0x22D3D80")]
	public static List<int> GetIgnoreListFast(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x22D3A94", Offset = "0x22D3A94", VA = "0x22D3A94")]
	public static List<int> GetIgnoreListShort(List<Bounds> bounds)
	{
		return null;
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x22D3FA4", Offset = "0x22D3FA4", VA = "0x22D3FA4")]
	public static void IgnoreNeibCollision(List<RayfireRigid> rigids, List<int> pr)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x22D4448", Offset = "0x22D4448", VA = "0x22D4448")]
	public static void IgnoreNeibCollision(List<RFShard> shards, List<int> pr)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0x22D1C48", Offset = "0x22D1C48", VA = "0x22D1C48")]
	public static bool IsNull(Rigidbody rb)
	{
		return default(bool);
	}

	[Token(Token = "0x600027A")]
	[Address(RVA = "0x22D4620", Offset = "0x22D4620", VA = "0x22D4620")]
	[IteratorStateMachine(typeof(<PhysicsDataCor>d__71))]
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
	[Address(RVA = "0x22D49A0", Offset = "0x22D49A0", VA = "0x22D49A0")]
	public RFReferenceDemolition()
	{
	}

	[Token(Token = "0x6000289")]
	[Address(RVA = "0x22D49C8", Offset = "0x22D49C8", VA = "0x22D49C8")]
	public void CopyFrom(RFReferenceDemolition referenceDemolitionDml)
	{
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x22D4A94", Offset = "0x22D4A94", VA = "0x22D4A94")]
	public GameObject GetReference()
	{
		return null;
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x22D4CF8", Offset = "0x22D4CF8", VA = "0x22D4CF8")]
	public static bool DemolishReference(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x22D5730", Offset = "0x22D5730", VA = "0x22D5730")]
	private static GameObject GetInstance(RayfireRigid scr, GameObject refGo)
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x22D58DC", Offset = "0x22D58DC", VA = "0x22D58DC")]
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
	[Address(RVA = "0x22D5AA8", Offset = "0x22D5AA8", VA = "0x22D5AA8")]
	public RFReset()
	{
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x22D5AE0", Offset = "0x22D5AE0", VA = "0x22D5AE0")]
	public void CopyFrom(RFReset reset, ObjectType objectType)
	{
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x22D5B3C", Offset = "0x22D5B3C", VA = "0x22D5B3C")]
	public static void ResetRigid(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x22D659C", Offset = "0x22D659C", VA = "0x22D659C")]
	public static void ResetFade(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x22D5DA0", Offset = "0x22D5DA0", VA = "0x22D5DA0")]
	private static bool MeshRootReset(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x22D6BFC", Offset = "0x22D6BFC", VA = "0x22D6BFC")]
	private static bool MeshRootCleanup(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x22D6D80", Offset = "0x22D6D80", VA = "0x22D6D80")]
	public static void DestroyMeshRootParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x22D6EF0", Offset = "0x22D6EF0", VA = "0x22D6EF0")]
	public static void RigidRootReset(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x22D7580", Offset = "0x22D7580", VA = "0x22D7580")]
	private static void ResetParentAndTm(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0x22D735C", Offset = "0x22D735C", VA = "0x22D735C")]
	private static void ResetSimType(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0x22D71EC", Offset = "0x22D71EC", VA = "0x22D71EC")]
	public static void DestroyRigidRootParticles(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0x22D779C", Offset = "0x22D779C", VA = "0x22D779C")]
	public static void DestroyClusters(RayfireRigidRoot scr)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0x22D67F8", Offset = "0x22D67F8", VA = "0x22D67F8")]
	public static void ResetMeshDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0x22D7F50", Offset = "0x22D7F50", VA = "0x22D7F50")]
	private static void DestroyFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0x22D6964", Offset = "0x22D6964", VA = "0x22D6964")]
	public static void DestroyRigidParticles(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0x22D7B6C", Offset = "0x22D7B6C", VA = "0x22D7B6C")]
	private static void ReuseFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x22D8590", Offset = "0x22D8590", VA = "0x22D8590")]
	private static void PreserveFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x22D68A4", Offset = "0x22D68A4", VA = "0x22D68A4")]
	private static void ResetClusterDemolition(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x22D5C78", Offset = "0x22D5C78", VA = "0x22D5C78")]
	private static bool ObjectReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x22D7914", Offset = "0x22D7914", VA = "0x22D7914")]
	private static bool FragmentReuseState(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x22D61B8", Offset = "0x22D61B8", VA = "0x22D61B8")]
	private static void RestoreTransform(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x22D632C", Offset = "0x22D632C", VA = "0x22D632C")]
	public static void Reset(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x22D68D4", Offset = "0x22D68D4", VA = "0x22D68D4")]
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
	[Range(2f, 300f)]
	public int frames;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(1f, 20f)]
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
	[Address(RVA = "0x22C7B9C", Offset = "0x22C7B9C", VA = "0x22C7B9C")]
	public RFRuntimeCaching()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x22CB8E4", Offset = "0x22CB8E4", VA = "0x22CB8E4")]
	public static List<int> GetBatchByFrames(int frames, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x22CB778", Offset = "0x22CB778", VA = "0x22CB778")]
	public static List<int> GetBatchByFragments(int fragments, int amount)
	{
		return null;
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x22D87D4", Offset = "0x22D87D4", VA = "0x22D87D4")]
	public static List<int> GetMarkedElements(int batchInd, List<int> batchAmount)
	{
		return null;
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x22CBAB8", Offset = "0x22CBAB8", VA = "0x22CBAB8")]
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
	[Address(RVA = "0x22D8954", Offset = "0x22D8954", VA = "0x22D8954")]
	public RFMirrored()
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x22D8978", Offset = "0x22D8978", VA = "0x22D8978")]
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
	[Address(RVA = "0x22D8A10", Offset = "0x22D8A10", VA = "0x22D8A10")]
	public RFCustom()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x22D8A54", Offset = "0x22D8A54", VA = "0x22D8A54")]
	public RFCustom(RFCustom src)
	{
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x22D8A9C", Offset = "0x22D8A9C", VA = "0x22D8A9C")]
	public static List<Vector3> GetCustomPointCLoud(RFCustom custom, Transform tm, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x22D8B58", Offset = "0x22D8B58", VA = "0x22D8B58")]
	private static List<Vector3> GetCustomInputCloud(RFCustom custom, Transform tm)
	{
		return null;
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x22D8EB8", Offset = "0x22D8EB8", VA = "0x22D8EB8")]
	private static List<Vector3> GetCustomOutputCloud(RFCustom custom, List<Vector3> inputPoints, int seed, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x22D90FC", Offset = "0x22D90FC", VA = "0x22D90FC")]
	private static List<Vector3> GetCustomBoundPoints(List<Vector3> inputPoints, Bounds bound)
	{
		return null;
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x22D91B8", Offset = "0x22D91B8", VA = "0x22D91B8")]
	private static Vector3 RandomPointInRadius(Vector3 point, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x22D922C", Offset = "0x22D922C", VA = "0x22D922C")]
	private static Vector3 RandomVector()
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200007F")]
public static class RFFragment
{
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
	[Address(RVA = "0x22D9294", Offset = "0x22D9294", VA = "0x22D9294")]
	public static void CacheMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x22DA7A8", Offset = "0x22DA7A8", VA = "0x22DA7A8")]
	private static void RemovePlanar(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scrShatter)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x22DAB64", Offset = "0x22DAB64", VA = "0x22DAB64")]
	private static void RemoveBySize(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireShatter scr)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x22CA9D4", Offset = "0x22CA9D4", VA = "0x22CA9D4")]
	public static bool InputMesh(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x22DB1EC", Offset = "0x22DB1EC", VA = "0x22DB1EC")]
	private static bool SetRigidShatter(RayfireRigid scr)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x22CAA88", Offset = "0x22CAA88", VA = "0x22CAA88")]
	public static void CacheMeshesInst(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x22CBC40", Offset = "0x22CBC40", VA = "0x22CBC40")]
	public static void CacheMeshesMult(Transform tmSaved, ref List<Mesh> meshesList, ref List<Vector3> pivotsList, ref List<RFDictionary> subList, RayfireRigid scrRigid, List<int> batchAmount, int batchInd)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x22DBA34", Offset = "0x22DBA34", VA = "0x22DBA34")]
	private static void FinalCacheMeshes(ref Mesh[] meshes, RayfireRigid scrRigid, bool successState)
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x22DB9A4", Offset = "0x22DB9A4", VA = "0x22DB9A4")]
	private static Mesh GetDemolitionMesh(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x22D98F4", Offset = "0x22D98F4", VA = "0x22D98F4")]
	private static Mesh GetDemolitionMesh(RayfireShatter scr)
	{
		return null;
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x22C9B84", Offset = "0x22C9B84", VA = "0x22C9B84")]
	public static void SliceMeshes(ref Mesh[] meshes, ref Vector3[] pivots, ref List<RFDictionary> origSubMeshIdsRf, RayfireRigid scr, List<Vector3> sliceData)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x22DA198", Offset = "0x22DA198", VA = "0x22DA198")]
	private static bool Compute(int shatterMode, RFShatter shatter, Transform tm, ref Mesh[] meshes, ref Vector3[] pivots, Mesh mesh, int innerSubId, ref List<Dictionary<int, int>> subIds, UnityEngine.Object obj, [Optional] List<int> markedElements)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x22D9830", Offset = "0x22D9830", VA = "0x22D9830")]
	private static int GetShatterMode([Optional] RayfireShatter scrShatter)
	{
		return default(int);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x22DBBA4", Offset = "0x22DBBA4", VA = "0x22DBBA4")]
	private static bool EmptyMeshState(Mesh[] meshes)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x22D9D8C", Offset = "0x22D9D8C", VA = "0x22D9D8C")]
	private static void SetShatterFragmentProperties(RFShatter shatter, RayfireShatter scrSh)
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x22DB360", Offset = "0x22DB360", VA = "0x22DB360")]
	private static void SetRigidFragmentProperties(RFShatter shatter, RayfireShatter scrSh, RayfireRigid scrRigid)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x22D99DC", Offset = "0x22D99DC", VA = "0x22D99DC")]
	private static RFShatter SetShatter(FragmentMode fragmentMode, int shatterMode, Mesh mesh, Transform transform, RFSurface interior, bool decompose, bool delete_collinear = false, int seed = 1, bool pre_cap = true, bool remove_cap_faces = false, bool remove_double_faces = true, bool exclude_inside = false, bool post_normals_smooth = false, int min_bbox_diag_size_filter_perc = 3, int meshRemoveMinFaceFilter = 4, bool postWeld = true)
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x22DCF08", Offset = "0x22DCF08", VA = "0x22DCF08")]
	private static void SetShatterEditorMode(RFShatter shatter, float min_bbox_diag_size_filter, bool pre_cap, bool remove_cap_faces, bool remove_double_faces, bool exclude_inside, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x22DD088", Offset = "0x22DD088", VA = "0x22DD088")]
	private static void SetShatterRuntimeMode(RFShatter shatter, bool pre_cap, int meshRemoveMinFaceFilter)
	{
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x22DBC18", Offset = "0x22DBC18", VA = "0x22DBC18")]
	private static void SetVoronoi(RFShatter shatter, int numFragments, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x22DBD7C", Offset = "0x22DBD7C", VA = "0x22DBD7C")]
	private static void SetSplinters(RFShatter shatter, int numFragments, RFSplinters splint, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x22DBEF8", Offset = "0x22DBEF8", VA = "0x22DBEF8")]
	private static void SetSlabs(RFShatter shatter, int numFragments, RFSplinters slabs, Transform tm, Vector3 centerPos, float centerBias)
	{
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x22DC074", Offset = "0x22DC074", VA = "0x22DC074")]
	private static void SetRadial(RFShatter shatter, RFRadial radial, Transform tm, Vector3 centerPos, Quaternion centerDirection)
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x22DC328", Offset = "0x22DC328", VA = "0x22DC328")]
	private static void SetCustom(RFShatter shatter, RFCustom custom, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x22DD34C", Offset = "0x22DD34C", VA = "0x22DD34C")]
	private static void SetMirrored(RFShatter shatter, RFMirrored mirror, Transform tm, Bounds bound, int seed)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x22DC414", Offset = "0x22DC414", VA = "0x22DC414")]
	private static void SetSlices(RFShatter shatter, Transform tm, RFSlice slices)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x22DC770", Offset = "0x22DC770", VA = "0x22DC770")]
	private static void SetBricks(RFShatter shatter, Transform tm, RFBricks bricks, Bounds bounds)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x22DC9C8", Offset = "0x22DC9C8", VA = "0x22DC9C8")]
	private static void SetVoxels(RFShatter shatter, Transform tm, RFVoxels voxels, Bounds bounds)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x22DD404", Offset = "0x22DD404", VA = "0x22DD404")]
	private static float BoolToFloat(bool v)
	{
		return default(float);
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x22DCA94", Offset = "0x22DCA94", VA = "0x22DCA94")]
	private static void SetTet(RFShatter shatter, Bounds bounds, RFTets tets)
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x22DCCB0", Offset = "0x22DCCB0", VA = "0x22DCCB0")]
	private static void SetDecompose(RFShatter shatter)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x22DCD08", Offset = "0x22DCD08", VA = "0x22DCD08")]
	private static void SetClusters(RFShatter shatter, RFShatterCluster gluing)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x22DD164", Offset = "0x22DD164", VA = "0x22DD164")]
	private static void SetStretching(RFShatter shatter, AxisType axis, float strength, FragType fragType)
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x22DD268", Offset = "0x22DD268", VA = "0x22DD268")]
	private static Vector3 DirectionAxis(AxisType axisType)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x22DD418", Offset = "0x22DD418", VA = "0x22DD418")]
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
	[Address(RVA = "0x22DD6C0", Offset = "0x22DD6C0", VA = "0x22DD6C0")]
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
	[Address(RVA = "0x22DD710", Offset = "0x22DD710", VA = "0x22DD710")]
	public RFShatterAdvanced()
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0x22DD778", Offset = "0x22DD778", VA = "0x22DD778")]
	public RFShatterAdvanced(RFShatterAdvanced src)
	{
	}

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0x22DD81C", Offset = "0x22DD81C", VA = "0x22DD81C")]
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
	[Address(RVA = "0x22DE140", Offset = "0x22DE140", VA = "0x22DE140")]
	public RFSurface()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0x22DE170", Offset = "0x22DE170", VA = "0x22DE170")]
	public void CopyFrom(RFSurface interior)
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x22DE1A4", Offset = "0x22DE1A4", VA = "0x22DE1A4")]
	public static void SetMaterial(List<RFDictionary> origSubMeshIdsRF, Material[] sharedMaterials, RFSurface interior, MeshRenderer targetRend, int i, int amount)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x22DE408", Offset = "0x22DE408", VA = "0x22DE408")]
	public static int SetInnerSubId(RayfireRigid scr)
	{
		return default(int);
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x22DE554", Offset = "0x22DE554", VA = "0x22DE554")]
	public static int SetInnerSubId(RayfireShatter scr)
	{
		return default(int);
	}
}
[Token(Token = "0x2000086")]
[AddComponentMenu("RayFire/Rayfire Activator")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-activator-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22E0758", Offset = "0x22E0758", VA = "0x22E0758", Slot = "4")]
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
			[Address(RVA = "0x22E07A0", Offset = "0x22E07A0", VA = "0x22E07A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x22DF21C", Offset = "0x22DF21C", VA = "0x22DF21C")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x22E0660", Offset = "0x22E0660", VA = "0x22E0660", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x22E0664", Offset = "0x22E0664", VA = "0x22E0664", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x22E0760", Offset = "0x22E0760", VA = "0x22E0760", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22E0950", Offset = "0x22E0950", VA = "0x22E0950", Slot = "4")]
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
			[Address(RVA = "0x22E0998", Offset = "0x22E0998", VA = "0x22E0998", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x22DF244", Offset = "0x22DF244", VA = "0x22DF244")]
		[DebuggerHidden]
		public <DelayedClusterCor>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x22E07A8", Offset = "0x22E07A8", VA = "0x22E07A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x22E07AC", Offset = "0x22E07AC", VA = "0x22E07AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x22E0958", Offset = "0x22E0958", VA = "0x22E0958", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22E0A98", Offset = "0x22E0A98", VA = "0x22E0A98", Slot = "4")]
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
			[Address(RVA = "0x22E0AE0", Offset = "0x22E0AE0", VA = "0x22E0AE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x22DF5CC", Offset = "0x22DF5CC", VA = "0x22DF5CC")]
		[DebuggerHidden]
		public <DelayedActivationCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x22E09A0", Offset = "0x22E09A0", VA = "0x22E09A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x22E09A4", Offset = "0x22E09A4", VA = "0x22E09A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x22E0AA0", Offset = "0x22E0AA0", VA = "0x22E0AA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22E0E28", Offset = "0x22E0E28", VA = "0x22E0E28", Slot = "4")]
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
			[Address(RVA = "0x22E0E70", Offset = "0x22E0E70", VA = "0x22E0E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x22DFFE8", Offset = "0x22DFFE8", VA = "0x22DFFE8")]
		[DebuggerHidden]
		public <AnimationCor>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x22E0AE8", Offset = "0x22E0AE8", VA = "0x22E0AE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x22E0AEC", Offset = "0x22E0AEC", VA = "0x22E0AEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x22E0E30", Offset = "0x22E0E30", VA = "0x22E0E30", Slot = "8")]
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
		[Address(RVA = "0x22E05A0", Offset = "0x22E05A0", VA = "0x22E05A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000043")]
	public bool ByLine
	{
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x22DF778", Offset = "0x22DF778", VA = "0x22DF778")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x22DE6A0", Offset = "0x22DE6A0", VA = "0x22DE6A0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x22DEB10", Offset = "0x22DEB10", VA = "0x22DEB10")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x22DEBA8", Offset = "0x22DEBA8", VA = "0x22DEBA8")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x22DECDC", Offset = "0x22DECDC", VA = "0x22DECDC")]
	private void OnTriggerEnter(Collider coll)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x22DECEC", Offset = "0x22DECEC", VA = "0x22DECEC")]
	private void OnTriggerExit(Collider coll)
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x22DE70C", Offset = "0x22DE70C", VA = "0x22DE70C")]
	private void SetCollider()
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x22DE940", Offset = "0x22DE940", VA = "0x22DE940")]
	private void SetParticleSystem()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x22DEB5C", Offset = "0x22DEB5C", VA = "0x22DEB5C")]
	private void ActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x22DED00", Offset = "0x22DED00", VA = "0x22DED00")]
	private void RigidListActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x22DF12C", Offset = "0x22DF12C", VA = "0x22DF12C")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__47))]
	private IEnumerator DelayedActivationCor(RayfireRigid rigid)
	{
		return null;
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x22DF1A0", Offset = "0x22DF1A0", VA = "0x22DF1A0")]
	[IteratorStateMachine(typeof(<DelayedClusterCor>d__48))]
	private IEnumerator DelayedClusterCor(RayfireRigid rigid, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0x22DF0E8", Offset = "0x22DF0E8", VA = "0x22DF0E8")]
	private void Activate(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x60002FA")]
	[Address(RVA = "0x22DEF30", Offset = "0x22DEF30", VA = "0x22DEF30")]
	private void RigidRootActivationCheck(Collider coll)
	{
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0x22DF550", Offset = "0x22DF550", VA = "0x22DF550")]
	[IteratorStateMachine(typeof(<DelayedActivationCor>d__51))]
	private IEnumerator DelayedActivationCor(RayfireRigidRoot rigidRoot, Collider coll)
	{
		return null;
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0x22DF3EC", Offset = "0x22DF3EC", VA = "0x22DF3EC")]
	private void ActivateCollider(RayfireRigidRoot rigidRoot, Collider coll)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0x22DF26C", Offset = "0x22DF26C", VA = "0x22DF26C")]
	private void AddForce(Rigidbody rb)
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x22DF5F4", Offset = "0x22DF5F4", VA = "0x22DF5F4")]
	public void TriggerAnimation()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x22DF6D0", Offset = "0x22DF6D0", VA = "0x22DF6D0")]
	private void SetAnimation()
	{
	}

	[Token(Token = "0x6000300")]
	[Address(RVA = "0x22DF78C", Offset = "0x22DF78C", VA = "0x22DF78C")]
	private void SetWorldPointsByLine()
	{
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0x22DFA28", Offset = "0x22DFA28", VA = "0x22DFA28")]
	private void SetWorldPointsByLocal()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0x22DFC54", Offset = "0x22DFC54", VA = "0x22DFC54")]
	private void SetCheckPoints()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0x22DF710", Offset = "0x22DF710", VA = "0x22DF710")]
	[IteratorStateMachine(typeof(<AnimationCor>d__59))]
	private IEnumerator AnimationCor()
	{
		return null;
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0x22E0010", Offset = "0x22E0010", VA = "0x22E0010")]
	private int GetSegment(float ration)
	{
		return default(int);
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0x22E0100", Offset = "0x22E0100", VA = "0x22E0100")]
	private void ResetData()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0x22E0160", Offset = "0x22E0160", VA = "0x22E0160")]
	public void StopAnimation()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0x22E0168", Offset = "0x22E0168", VA = "0x22E0168")]
	public void ResetAnimation()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0x22E019C", Offset = "0x22E019C", VA = "0x22E019C")]
	public void AddPosition(Vector3 newPos)
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0x22E04F4", Offset = "0x22E04F4", VA = "0x22E04F4")]
	public void SetGizmoType(GizmoType gizmo)
	{
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0x22E05BC", Offset = "0x22E05BC", VA = "0x22E05BC")]
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
	[Address(RVA = "0x22E0E78", Offset = "0x22E0E78", VA = "0x22E0E78")]
	public RFSliceData()
	{
	}
}
[Token(Token = "0x200008F")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-blade-component/")]
[AddComponentMenu("RayFire/Rayfire Blade")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22E1D40", Offset = "0x22E1D40", VA = "0x22E1D40", Slot = "4")]
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
			[Address(RVA = "0x22E1D88", Offset = "0x22E1D88", VA = "0x22E1D88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x22E17F4", Offset = "0x22E17F4", VA = "0x22E17F4")]
		[DebuggerHidden]
		public <CooldownCor>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x22E1C6C", Offset = "0x22E1C6C", VA = "0x22E1C6C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x22E1C70", Offset = "0x22E1C70", VA = "0x22E1C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x22E1D48", Offset = "0x22E1D48", VA = "0x22E1D48", Slot = "8")]
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
		[Address(RVA = "0x22E1B70", Offset = "0x22E1B70", VA = "0x22E1B70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x22E0E80", Offset = "0x22E0E80", VA = "0x22E0E80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000327")]
	[Address(RVA = "0x22E0E84", Offset = "0x22E0E84", VA = "0x22E0E84")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0x22E1088", Offset = "0x22E1088", VA = "0x22E1088")]
	private void OnTriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0x22E1138", Offset = "0x22E1138", VA = "0x22E1138")]
	private void OnTriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0x22E108C", Offset = "0x22E108C", VA = "0x22E108C")]
	private void TriggerEnter(Collider col)
	{
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0x22E113C", Offset = "0x22E113C", VA = "0x22E113C")]
	private void TriggerExit(Collider col)
	{
	}

	[Token(Token = "0x600032C")]
	[Address(RVA = "0x22E1590", Offset = "0x22E1590", VA = "0x22E1590")]
	private void Demolish(GameObject targetObject)
	{
	}

	[Token(Token = "0x600032D")]
	[Address(RVA = "0x22E178C", Offset = "0x22E178C", VA = "0x22E178C")]
	[IteratorStateMachine(typeof(<CooldownCor>d__31))]
	private IEnumerator CooldownCor()
	{
		return null;
	}

	[Token(Token = "0x600032E")]
	[Address(RVA = "0x22E181C", Offset = "0x22E181C", VA = "0x22E181C")]
	private void SetCooldown(bool state)
	{
	}

	[Token(Token = "0x600032F")]
	[Address(RVA = "0x22E1694", Offset = "0x22E1694", VA = "0x22E1694")]
	private bool FilterCheck(GameObject targetObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000330")]
	[Address(RVA = "0x22E1844", Offset = "0x22E1844", VA = "0x22E1844")]
	public void SliceTarget()
	{
	}

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x22E1404", Offset = "0x22E1404", VA = "0x22E1404")]
	private void Slice(GameObject targetObject, Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x22E1744", Offset = "0x22E1744", VA = "0x22E1744")]
	private bool ApplyDamage(RayfireRigid scr, float damageValue)
	{
		return default(bool);
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x22E131C", Offset = "0x22E131C", VA = "0x22E131C")]
	private Vector3[] GetSlicePlane()
	{
		return null;
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x22E1948", Offset = "0x22E1948", VA = "0x22E1948")]
	private RFSliceData GetSliceData()
	{
		return null;
	}

	[Token(Token = "0x6000336")]
	[Address(RVA = "0x22E1828", Offset = "0x22E1828", VA = "0x22E1828")]
	private bool LayerCheck(int layerId)
	{
		return default(bool);
	}

	[Token(Token = "0x6000337")]
	[Address(RVA = "0x22E1BC4", Offset = "0x22E1BC4", VA = "0x22E1BC4")]
	public RayfireBlade()
	{
	}
}
[Token(Token = "0x2000093")]
[AddComponentMenu("RayFire/Rayfire Bomb")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-bomb-component/")]
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
		[Address(RVA = "0x22E3740", Offset = "0x22E3740", VA = "0x22E3740")]
		public Projectile()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22E3E2C", Offset = "0x22E3E2C", VA = "0x22E3E2C", Slot = "4")]
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
			[Address(RVA = "0x22E3E74", Offset = "0x22E3E74", VA = "0x22E3E74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x22E2094", Offset = "0x22E2094", VA = "0x22E2094")]
		[DebuggerHidden]
		public <ExplodeCor>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x22E3D78", Offset = "0x22E3D78", VA = "0x22E3D78", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x22E3D7C", Offset = "0x22E3D7C", VA = "0x22E3D7C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x22E3E34", Offset = "0x22E3E34", VA = "0x22E3E34", Slot = "8")]
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
	[Address(RVA = "0x22E1D90", Offset = "0x22E1D90", VA = "0x22E1D90")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x22E1E40", Offset = "0x22E1E40", VA = "0x22E1E40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x22E1EB8", Offset = "0x22E1EB8", VA = "0x22E1EB8")]
	public void CopyFrom(RayfireBomb scr)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x22E1E74", Offset = "0x22E1E74", VA = "0x22E1E74")]
	public void Explode(float delayLoc)
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x22E202C", Offset = "0x22E202C", VA = "0x22E202C")]
	[IteratorStateMachine(typeof(<ExplodeCor>d__37))]
	private IEnumerator ExplodeCor()
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x22E1F24", Offset = "0x22E1F24", VA = "0x22E1F24")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x22E2D28", Offset = "0x22E2D28", VA = "0x22E2D28")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x22E2160", Offset = "0x22E2160", VA = "0x22E2160")]
	private bool Setup()
	{
		return default(bool);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x22E1D94", Offset = "0x22E1D94", VA = "0x22E1D94")]
	private void ClearLists()
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x22E34B8", Offset = "0x22E34B8", VA = "0x22E34B8")]
	public void Restore()
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x22E34D4", Offset = "0x22E34D4", VA = "0x22E34D4")]
	private static void RestoreProjectiles(List<Projectile> prj)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x22E20BC", Offset = "0x22E20BC", VA = "0x22E20BC")]
	private void SetPositions()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x22E2DE4", Offset = "0x22E2DE4", VA = "0x22E2DE4")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x22E2E18", Offset = "0x22E2E18", VA = "0x22E2E18")]
	private void SetProjectiles()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x22E21C8", Offset = "0x22E21C8", VA = "0x22E21C8")]
	private bool SetRigidDamage()
	{
		return default(bool);
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x22E23E0", Offset = "0x22E23E0", VA = "0x22E23E0")]
	private void Deletion()
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x22E2738", Offset = "0x22E2738", VA = "0x22E2738")]
	private void Activate()
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x22E2ABC", Offset = "0x22E2ABC", VA = "0x22E2ABC")]
	private void SetForce()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x22E3748", Offset = "0x22E3748", VA = "0x22E3748")]
	private float Fade(Vector3 bombPos, Vector3 fragPos)
	{
		return default(float);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x22E3924", Offset = "0x22E3924", VA = "0x22E3924")]
	private Vector3 Vector(Projectile projectile)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0x22E3A54", Offset = "0x22E3A54", VA = "0x22E3A54")]
	public RayfireBomb()
	{
	}
}
[Token(Token = "0x2000098")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-cluster-component/")]
[SelectionBase]
[AddComponentMenu("RayFire/Rayfire Cluster")]
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

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Properties")]
	[Space(2f)]
	[Space(2f)]
	public ClusterType type;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(1f, 7f)]
	public int depth;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Range(0f, 100f)]
	public int seed;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Range(0f, 4f)]
	public int smoothPass;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	[Range(2f, 100f)]
	[Header("  By Point Cloud")]
	public int baseAmount;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(2f, 50f)]
	public int depthAmount;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ConnectivityType connectivity;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Header("  By Shared Area")]
	[Space(2f)]
	[Range(2f, 8f)]
	public int minimumAmount;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(2f, 8f)]
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
	[Address(RVA = "0x22E3E7C", Offset = "0x22E3E7C", VA = "0x22E3E7C")]
	public void Extract()
	{
	}

	[Token(Token = "0x600035B")]
	[Address(RVA = "0x22E40E0", Offset = "0x22E40E0", VA = "0x22E40E0")]
	public void Clusterize()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x22E4194", Offset = "0x22E4194", VA = "0x22E4194")]
	private void ClusterizeVoronoi()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x22E4B84", Offset = "0x22E4B84", VA = "0x22E4B84")]
	private List<RFCluster> ClusterizeClusterByAmount(RFCluster parentCluster, int amount)
	{
		return null;
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x22E646C", Offset = "0x22E646C", VA = "0x22E646C")]
	private void ConnectivityCheck(List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x22E4490", Offset = "0x22E4490", VA = "0x22E4490")]
	private void ClusterizeRange()
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x22E723C", Offset = "0x22E723C", VA = "0x22E723C")]
	private List<RFCluster> ClusterizeRangeShards(RFCluster mainCluster)
	{
		return null;
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0x22E7834", Offset = "0x22E7834", VA = "0x22E7834")]
	private List<RFCluster> ClusterizeRangeClusters(RFCluster parentCluster)
	{
		return null;
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0x22E5A88", Offset = "0x22E5A88", VA = "0x22E5A88")]
	private static void RoughnessPassShards(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0x22E8284", Offset = "0x22E8284", VA = "0x22E8284")]
	private void RoughnessPassClusters(List<RFCluster> clusters)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0x22E5868", Offset = "0x22E5868", VA = "0x22E5868")]
	private void SetSoloShardToCluster(List<RFShard> soloShards, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0x22E8C38", Offset = "0x22E8C38", VA = "0x22E8C38")]
	private int GetNeibIndArea(RFShard shard, [Optional] List<RFShard> shardList)
	{
		return default(int);
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0x22E8080", Offset = "0x22E8080", VA = "0x22E8080")]
	private void SetSoloClusterToCluster(List<RFCluster> soloClusters, List<RFCluster> childClusters)
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0x22E4A4C", Offset = "0x22E4A4C", VA = "0x22E4A4C")]
	private RFCluster SetupMainCluster(ConnectivityType connect)
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0x22E5478", Offset = "0x22E5478", VA = "0x22E5478")]
	private void SetClusterNames()
	{
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0x22E7034", Offset = "0x22E7034", VA = "0x22E7034")]
	private void CreateRoot(RFCluster childCluster, Transform parentTm)
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0x22E8D60", Offset = "0x22E8D60", VA = "0x22E8D60")]
	private Bounds GetShardsBound(List<RFShard> shards, [Optional] List<RFCluster> clusters)
	{
		return default(Bounds);
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0x22E7CC8", Offset = "0x22E7CC8", VA = "0x22E7CC8")]
	private static RFShard GetNeibShardArea(List<RFShard> shardGroup, List<RFShard> shardList)
	{
		return null;
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0x22E56AC", Offset = "0x22E56AC", VA = "0x22E56AC")]
	private List<Vector3> VoronoiPointCloud(Bounds bound, int am)
	{
		return null;
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0x22E9180", Offset = "0x22E9180", VA = "0x22E9180")]
	public RayfireCluster()
	{
	}
}
[Token(Token = "0x200009C")]
public class RFCombineMesh
{
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
	[Address(RVA = "0x22E92CC", Offset = "0x22E92CC", VA = "0x22E92CC")]
	public RFCombineMesh()
	{
	}

	[Token(Token = "0x6000373")]
	[Address(RVA = "0x22E9480", Offset = "0x22E9480", VA = "0x22E9480")]
	public static RFCombineMesh GetCombinedMesh(Transform transForm, List<Mesh> meshList, List<Transform> transList, List<List<int>> matIdList, List<bool> invertNormals)
	{
		return null;
	}

	[Token(Token = "0x6000374")]
	[Address(RVA = "0x22E9BA8", Offset = "0x22E9BA8", VA = "0x22E9BA8")]
	public static Mesh CreateMesh(RFCombineMesh cMesh, string name)
	{
		return null;
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0x22E9D70", Offset = "0x22E9D70", VA = "0x22E9D70")]
	public static Mesh CombineShatter(RayfireShatter shatter, Transform root, List<MeshFilter> filters)
	{
		return null;
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0x22E9F3C", Offset = "0x22E9F3C", VA = "0x22E9F3C")]
	private static void GetMeshTransMatLists(List<MeshFilter> filters, ref List<Mesh> meshList, ref List<Transform> transList, ref List<List<Material>> matList, int verts, float size)
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0x22EA478", Offset = "0x22EA478", VA = "0x22EA478")]
	public static List<Material> GetAllMaterials(List<Transform> transList, List<List<Material>> matList)
	{
		return null;
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0x22EA684", Offset = "0x22EA684", VA = "0x22EA684")]
	public static List<List<int>> GetMatIdList(List<Transform> transList, List<List<Material>> matList, List<Material> allMaterials)
	{
		return null;
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0x22EA8AC", Offset = "0x22EA8AC", VA = "0x22EA8AC")]
	public static List<bool> GetInvertList(List<Transform> transList)
	{
		return null;
	}
}
[Token(Token = "0x20000A0")]
[AddComponentMenu("RayFire/Rayfire Combine")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-combine-component/")]
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
	[Address(RVA = "0x22EABDC", Offset = "0x22EABDC", VA = "0x22EABDC")]
	public void Combine()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0x22EACA0", Offset = "0x22EACA0", VA = "0x22EACA0")]
	private bool SetData()
	{
		return default(bool);
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0x22EC6E4", Offset = "0x22EC6E4", VA = "0x22EC6E4")]
	public RayfireCombine()
	{
	}
}
[Token(Token = "0x20000A2")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-connectivity-component/")]
[AddComponentMenu("RayFire/Rayfire Connectivity")]
[DisallowMultipleComponent]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22F04D0", Offset = "0x22F04D0", VA = "0x22F04D0", Slot = "4")]
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
			[Address(RVA = "0x22F0518", Offset = "0x22F0518", VA = "0x22F0518", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x22EDFA4", Offset = "0x22EDFA4", VA = "0x22EDFA4")]
		[DebuggerHidden]
		public <ConnectivityCor>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x22F0428", Offset = "0x22F0428", VA = "0x22F0428", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x22F042C", Offset = "0x22F042C", VA = "0x22F042C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x22F04D8", Offset = "0x22F04D8", VA = "0x22F04D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A5")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22F05AC", Offset = "0x22F05AC", VA = "0x22F05AC", Slot = "4")]
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
			[Address(RVA = "0x22F05F4", Offset = "0x22F05F4", VA = "0x22F05F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x22EF754", Offset = "0x22EF754", VA = "0x22EF754")]
		[DebuggerHidden]
		public <ChildrenCor>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x22F0520", Offset = "0x22F0520", VA = "0x22F0520", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x22F0524", Offset = "0x22F0524", VA = "0x22F0524", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x22F05B4", Offset = "0x22F05B4", VA = "0x22F05B4", Slot = "8")]
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
		[Address(RVA = "0x22EE2EC", Offset = "0x22EE2EC", VA = "0x22EE2EC")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0x22EC70C", Offset = "0x22EC70C", VA = "0x22EC70C")]
	private void SetRuntimeMeshRootHost()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0x22EC814", Offset = "0x22EC814", VA = "0x22EC814")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0x22EC820", Offset = "0x22EC820", VA = "0x22EC820")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x22EC9EC", Offset = "0x22EC9EC", VA = "0x22EC9EC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0x22ECB94", Offset = "0x22ECB94", VA = "0x22ECB94")]
	private bool WarningCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x22ED220", Offset = "0x22ED220", VA = "0x22ED220")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x22ED2A4", Offset = "0x22ED2A4", VA = "0x22ED2A4")]
	private void PrepareCluster()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x22ED404", Offset = "0x22ED404", VA = "0x22ED404")]
	private RFCluster CreateCluster()
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x22ECD40", Offset = "0x22ECD40", VA = "0x22ECD40")]
	private void SetClusterForMeshRoot()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x22ECFC0", Offset = "0x22ECFC0", VA = "0x22ECFC0")]
	private void SetClusterForRigidRoot()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x22EDB60", Offset = "0x22EDB60", VA = "0x22EDB60")]
	private void SetExpand()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x22ED4D8", Offset = "0x22ED4D8", VA = "0x22ED4D8")]
	private void SetRigidListByFragments(List<RayfireRigid> rgList)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x22ED6E0", Offset = "0x22ED6E0", VA = "0x22ED6E0")]
	public static bool InitCachedShardsByRigidList(List<RayfireRigid> rigids, RFCluster cluster)
	{
		return default(bool);
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x22EDC28", Offset = "0x22EDC28", VA = "0x22EDC28")]
	public static void InitCachedShardsByRigidRoot(RayfireRigidRoot root, RFCluster cluster)
	{
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0x22EC984", Offset = "0x22EC984", VA = "0x22EC984")]
	[IteratorStateMachine(typeof(<ConnectivityCor>d__49))]
	private IEnumerator ConnectivityCor()
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x22EDFCC", Offset = "0x22EDFCC", VA = "0x22EDFCC")]
	public void CheckConnectivity()
	{
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0x22EE1D0", Offset = "0x22EE1D0", VA = "0x22EE1D0")]
	private void CheckConnectivityRigidList()
	{
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0x22EE0B4", Offset = "0x22EE0B4", VA = "0x22EE0B4")]
	private void CheckConnectivityRigidRoot()
	{
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0x22EE6D8", Offset = "0x22EE6D8", VA = "0x22EE6D8")]
	private void ActivateShards(List<RFShard> soloShards)
	{
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0x22EEB90", Offset = "0x22EEB90", VA = "0x22EEB90")]
	private void Clusterize()
	{
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0x22EE358", Offset = "0x22EE358", VA = "0x22EE358")]
	private static void CleanUpActivatedShardsRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0x22EE4F4", Offset = "0x22EE4F4", VA = "0x22EE4F4")]
	private static void CheckUnyieldingRigidList(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0x22EE8D0", Offset = "0x22EE8D0", VA = "0x22EE8D0")]
	private static void CleanUpActivatedShardsRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0x22EE9AC", Offset = "0x22EE9AC", VA = "0x22EE9AC")]
	private static void CheckUnyieldingRigidRoot(RFCluster cluster)
	{
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0x22EF748", Offset = "0x22EF748", VA = "0x22EF748")]
	private void OnTransformChildrenChanged()
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0x22EC91C", Offset = "0x22EC91C", VA = "0x22EC91C")]
	[IteratorStateMachine(typeof(<ChildrenCor>d__60))]
	private IEnumerator ChildrenCor()
	{
		return null;
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0x22EF77C", Offset = "0x22EF77C", VA = "0x22EF77C")]
	private void ChildrenCheck()
	{
	}

	[Token(Token = "0x600039F")]
	[Address(RVA = "0x22EFA30", Offset = "0x22EFA30", VA = "0x22EFA30")]
	public void ResetConnectivity()
	{
	}

	[Token(Token = "0x60003A0")]
	[Address(RVA = "0x22ECED8", Offset = "0x22ECED8", VA = "0x22ECED8")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x60003A1")]
	[Address(RVA = "0x22EFA64", Offset = "0x22EFA64", VA = "0x22EFA64")]
	public void Fracture()
	{
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x22EFA70", Offset = "0x22EFA70", VA = "0x22EFA70")]
	public void Fracture(Collider col, int debris)
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x22EFF20", Offset = "0x22EFF20", VA = "0x22EFF20")]
	private HashSet<Collider> GetOverlappedColliders(Collider col)
	{
		return null;
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x22F038C", Offset = "0x22F038C", VA = "0x22F038C")]
	public RayfireConnectivity()
	{
	}
}
[Token(Token = "0x20000A6")]
[AddComponentMenu("RayFire/Rayfire Debris")]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-debris-component/")]
[SelectionBase]
public class RayfireDebris : MonoBehaviour
{
	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Debris")]
	public bool onDemolition;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(3f)]
	[Header("  Main")]
	public GameObject debrisReference;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public Material debrisMaterial;

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("  Properties")]
	[Space(3f)]
	public RFParticleEmission emission;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(3f)]
	public RFParticleDynamicDebris dynamic;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(3f)]
	public RFParticleNoise noise;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(3f)]
	public RFParticleCollisionDebris collision;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(3f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(3f)]
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
		[Address(RVA = "0x22F1444", Offset = "0x22F1444", VA = "0x22F1444")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x22F05FC", Offset = "0x22F05FC", VA = "0x22F05FC")]
	public RayfireDebris()
	{
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x22F07F8", Offset = "0x22F07F8", VA = "0x22F07F8")]
	public void CopyFrom(RayfireDebris source)
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x22F08CC", Offset = "0x22F08CC", VA = "0x22F08CC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x22F0E38", Offset = "0x22F0E38", VA = "0x22F0E38")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x22F1264", Offset = "0x22F1264", VA = "0x22F1264")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x22F0F70", Offset = "0x22F0F70", VA = "0x22F0F70")]
	public void CreateDebris(RayfireDebris scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003B8")]
	[Address(RVA = "0x22F1498", Offset = "0x22F1498", VA = "0x22F1498")]
	private void SetParticleRendererDebris(ParticleSystemRenderer rend, RayfireDebris scr)
	{
	}

	[Token(Token = "0x60003B9")]
	[Address(RVA = "0x22F08E0", Offset = "0x22F08E0", VA = "0x22F08E0")]
	private void SetReferenceMeshes(GameObject refs)
	{
	}

	[Token(Token = "0x60003BA")]
	[Address(RVA = "0x22F16F4", Offset = "0x22F16F4", VA = "0x22F16F4")]
	private void SetDebrisMaterial(List<MeshFilter> mfs)
	{
	}
}
[Token(Token = "0x20000A8")]
[SelectionBase]
[HelpURL("http://rayfirestudios.com/unity-online-help/components/unity-dust-component/")]
[AddComponentMenu("RayFire/Rayfire Dust")]
public class RayfireDust : MonoBehaviour
{
	[Token(Token = "0x400043C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("  Emit Dust")]
	public bool onDemolition;

	[Token(Token = "0x400043D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[Space(1f)]
	public bool onActivation;

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[Space(1f)]
	public bool onImpact;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0.01f, 1f)]
	[Space(3f)]
	[Header("  Main")]
	public float opacity;

	[Token(Token = "0x4000440")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Space(2f)]
	public Material dustMaterial;

	[Token(Token = "0x4000441")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space(2f)]
	public List<Material> dustMaterials;

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Space(2f)]
	public Material emissionMaterial;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("  Properties")]
	[Space(3f)]
	public RFParticleEmission emission;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Space(2f)]
	public RFParticleDynamicDust dynamic;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Space(2f)]
	public RFParticleNoise noise;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Space(2f)]
	public RFParticleCollisionDust collision;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space(2f)]
	public RFParticleLimitations limitations;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Space(2f)]
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
		[Address(RVA = "0x22F2440", Offset = "0x22F2440", VA = "0x22F2440")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000058")]
	public bool HasMaterials
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x22F1E28", Offset = "0x22F1E28", VA = "0x22F1E28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x22F19CC", Offset = "0x22F19CC", VA = "0x22F19CC")]
	public RayfireDust()
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x22F1B50", Offset = "0x22F1B50", VA = "0x22F1B50")]
	public void CopyFrom(RayfireDust source)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x22F1C24", Offset = "0x22F1C24", VA = "0x22F1C24")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x22F1E7C", Offset = "0x22F1E7C", VA = "0x22F1E7C")]
	public ParticleSystem Emit()
	{
		return null;
	}

	[Token(Token = "0x60003C4")]
	[Address(RVA = "0x22F2260", Offset = "0x22F2260", VA = "0x22F2260")]
	public void Clean()
	{
	}

	[Token(Token = "0x60003C5")]
	[Address(RVA = "0x22F1F94", Offset = "0x22F1F94", VA = "0x22F1F94")]
	public void CreateDust(RayfireDust scr, MeshFilter emitMeshFilter, int emitMatIndex, ParticleSystem ps)
	{
	}

	[Token(Token = "0x60003C6")]
	[Address(RVA = "0x22F2494", Offset = "0x22F2494", VA = "0x22F2494")]
	private void SetParticleRendererDust(ParticleSystemRenderer rend, RayfireDust scr)
	{
	}

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x22F25FC", Offset = "0x22F25FC", VA = "0x22F25FC")]
	private void SetMaterialDust(ParticleSystemRenderer rend, List<Material> mats)
	{
	}
}
[Token(Token = "0x20000A9")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-gun-component/")]
[AddComponentMenu("RayFire/Rayfire Gun")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22F4BEC", Offset = "0x22F4BEC", VA = "0x22F4BEC", Slot = "4")]
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
			[Address(RVA = "0x22F4C34", Offset = "0x22F4C34", VA = "0x22F4C34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x22F277C", Offset = "0x22F277C", VA = "0x22F277C")]
		[DebuggerHidden]
		public <StartShootCor>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x22F4B0C", Offset = "0x22F4B0C", VA = "0x22F4B0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x22F4B10", Offset = "0x22F4B10", VA = "0x22F4B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x22F4BF4", Offset = "0x22F4BF4", VA = "0x22F4BF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22F4D28", Offset = "0x22F4D28", VA = "0x22F4D28", Slot = "4")]
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
			[Address(RVA = "0x22F4D70", Offset = "0x22F4D70", VA = "0x22F4D70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x22F2FA8", Offset = "0x22F2FA8", VA = "0x22F2FA8")]
		[DebuggerHidden]
		public <BurstCor>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x22F4C3C", Offset = "0x22F4C3C", VA = "0x22F4C3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x22F4C40", Offset = "0x22F4C40", VA = "0x22F4C40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x22F4D30", Offset = "0x22F4D30", VA = "0x22F4D30", Slot = "8")]
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
	[FormerlySerializedAs("affectRigidBodies")]
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
		[Address(RVA = "0x22F2824", Offset = "0x22F2824", VA = "0x22F2824")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x22F26E4", Offset = "0x22F26E4", VA = "0x22F26E4")]
	public void StartShooting()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x22F2714", Offset = "0x22F2714", VA = "0x22F2714")]
	[IteratorStateMachine(typeof(<StartShootCor>d__28))]
	private IEnumerator StartShootCor()
	{
		return null;
	}

	[Token(Token = "0x60003CC")]
	[Address(RVA = "0x22F27A4", Offset = "0x22F27A4", VA = "0x22F27A4")]
	public void StopShooting()
	{
	}

	[Token(Token = "0x60003CD")]
	[Address(RVA = "0x22F27AC", Offset = "0x22F27AC", VA = "0x22F27AC")]
	public void Shoot(int shootId = 1)
	{
	}

	[Token(Token = "0x60003CE")]
	[Address(RVA = "0x22F2F10", Offset = "0x22F2F10", VA = "0x22F2F10")]
	public void Burst()
	{
	}

	[Token(Token = "0x60003CF")]
	[Address(RVA = "0x22F2F40", Offset = "0x22F2F40", VA = "0x22F2F40")]
	[IteratorStateMachine(typeof(<BurstCor>d__32))]
	private IEnumerator BurstCor()
	{
		return null;
	}

	[Token(Token = "0x60003D0")]
	[Address(RVA = "0x22F2A00", Offset = "0x22F2A00", VA = "0x22F2A00")]
	public void Shoot(Vector3 shootPos, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D1")]
	[Address(RVA = "0x22F3714", Offset = "0x22F3714", VA = "0x22F3714")]
	private void ImpactRigid(RayfireRigid rigidScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D2")]
	[Address(RVA = "0x22F3F0C", Offset = "0x22F3F0C", VA = "0x22F3F0C")]
	private void ImpactRoot(RayfireRigidRoot rootScr, RaycastHit hit, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D3")]
	[Address(RVA = "0x22F43F8", Offset = "0x22F43F8", VA = "0x22F43F8")]
	private void AddForce(List<Rigidbody> impactRbList, Vector3 impactPoint, Vector3 shootVector)
	{
	}

	[Token(Token = "0x60003D4")]
	[Address(RVA = "0x22F34BC", Offset = "0x22F34BC", VA = "0x22F34BC")]
	private RayfireRigid ApplyDamage(RayfireRigid scr, RaycastHit hit, Vector3 shootPos, Vector3 shootVector, Vector3 impactPoint)
	{
		return null;
	}

	[Token(Token = "0x60003D5")]
	[Address(RVA = "0x22F2FD0", Offset = "0x22F2FD0", VA = "0x22F2FD0")]
	private void VfxFlash(Vector3 position, Vector3 normal)
	{
	}

	[Token(Token = "0x60003D6")]
	[Address(RVA = "0x22F31A4", Offset = "0x22F31A4", VA = "0x22F31A4")]
	private void VfxDebris(List<RayfireDebris> debrisList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003D7")]
	[Address(RVA = "0x22F3330", Offset = "0x22F3330", VA = "0x22F3330")]
	private void VfxDust(List<RayfireDust> dustList, Vector3 impactPos, Vector3 impactNormal)
	{
	}

	[Token(Token = "0x60003D8")]
	[Address(RVA = "0x22F45EC", Offset = "0x22F45EC", VA = "0x22F45EC")]
	private List<RayfireRigid> ActivationCheck(RayfireRigid scrTarget, Vector3 position)
	{
		return null;
	}

	[Token(Token = "0x60003DA")]
	[Address(RVA = "0x22F49A8", Offset = "0x22F49A8", VA = "0x22F49A8")]
	public RayfireGun()
	{
	}
}
[Token(Token = "0x20000AD")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Man")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-man-component/")]
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
	[FormerlySerializedAs("collisionDetection")]
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
		[Address(RVA = "0x22F55DC", Offset = "0x22F55DC", VA = "0x22F55DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003E8")]
	[Address(RVA = "0x22F4D78", Offset = "0x22F4D78", VA = "0x22F4D78")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003E9")]
	[Address(RVA = "0x22F4FB8", Offset = "0x22F4FB8", VA = "0x22F4FB8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60003EA")]
	[Address(RVA = "0x22F4FC0", Offset = "0x22F4FC0", VA = "0x22F4FC0")]
	private void Reset()
	{
	}

	[Token(Token = "0x60003EB")]
	[Address(RVA = "0x22F4D7C", Offset = "0x22F4D7C", VA = "0x22F4D7C")]
	private void SetInstance()
	{
	}

	[Token(Token = "0x60003EC")]
	[Address(RVA = "0x22F5268", Offset = "0x22F5268", VA = "0x22F5268")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x22F529C", Offset = "0x22F529C", VA = "0x22F529C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x22F4FC4", Offset = "0x22F4FC4", VA = "0x22F4FC4")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x22F52EC", Offset = "0x22F52EC", VA = "0x22F52EC")]
	private void SetGravity()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x22F5484", Offset = "0x22F5484", VA = "0x22F5484")]
	public static void RayFireManInit()
	{
	}

	[Token(Token = "0x60003F2")]
	[Address(RVA = "0x22F536C", Offset = "0x22F536C", VA = "0x22F536C")]
	private void SetLayers()
	{
	}

	[Token(Token = "0x60003F3")]
	[Address(RVA = "0x22F5078", Offset = "0x22F5078", VA = "0x22F5078")]
	private void SetPooling()
	{
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x22F51A8", Offset = "0x22F51A8", VA = "0x22F51A8")]
	private void SetStorage()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x22F5654", Offset = "0x22F5654", VA = "0x22F5654")]
	public static void SetParentByManager(Transform tm, Transform original, bool noRegister = false)
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x22F57C8", Offset = "0x22F57C8", VA = "0x22F57C8")]
	public static void SetParentToManager(Transform tm)
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x22F5868", Offset = "0x22F5868", VA = "0x22F5868")]
	public static void SetParentByManager(Transform tm)
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x22F599C", Offset = "0x22F599C", VA = "0x22F599C")]
	public static void DestroyFragment(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x22F5BD0", Offset = "0x22F5BD0", VA = "0x22F5BD0")]
	public static void DestroyShard(RayfireRigidRoot scr, RFShard shard)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x22F5C88", Offset = "0x22F5C88", VA = "0x22F5C88")]
	public static void DestroyGo(GameObject go)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x22F5A8C", Offset = "0x22F5A8C", VA = "0x22F5A8C")]
	private static void DestroyOp(RayfireRigid scr, Transform tm, float time = 0f)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x22F5CE0", Offset = "0x22F5CE0", VA = "0x22F5CE0")]
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
	[Address(RVA = "0x22F5E64", Offset = "0x22F5E64", VA = "0x22F5E64")]
	public RFCache(Transform parent, Transform tm)
	{
	}
}
[Token(Token = "0x20000AF")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Recorder")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-recorder-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22F7504", Offset = "0x22F7504", VA = "0x22F7504", Slot = "4")]
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
			[Address(RVA = "0x22F754C", Offset = "0x22F754C", VA = "0x22F754C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x22F7018", Offset = "0x22F7018", VA = "0x22F7018")]
		[DebuggerHidden]
		public <RecordCor>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x22F70BC", Offset = "0x22F70BC", VA = "0x22F70BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x22F70C0", Offset = "0x22F70C0", VA = "0x22F70C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x22F750C", Offset = "0x22F750C", VA = "0x22F750C", Slot = "8")]
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
	[Address(RVA = "0x22F6080", Offset = "0x22F6080", VA = "0x22F6080")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x22F63A8", Offset = "0x22F63A8", VA = "0x22F63A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x22F63F8", Offset = "0x22F63F8", VA = "0x22F63F8")]
	private void SetRigid()
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x22F6084", Offset = "0x22F6084", VA = "0x22F6084")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x22F66F4", Offset = "0x22F66F4", VA = "0x22F66F4")]
	private void SetModeRecord()
	{
	}

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x22F6980", Offset = "0x22F6980", VA = "0x22F6980")]
	private void SetModePlay()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x22F6F84", Offset = "0x22F6F84", VA = "0x22F6F84")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x22F663C", Offset = "0x22F663C", VA = "0x22F663C")]
	public void StartRecord()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x22F6FB0", Offset = "0x22F6FB0", VA = "0x22F6FB0")]
	[IteratorStateMachine(typeof(<RecordCor>d__30))]
	private IEnumerator RecordCor()
	{
		return null;
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x22F7040", Offset = "0x22F7040", VA = "0x22F7040")]
	public void StopRecord()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x22F66A8", Offset = "0x22F66A8", VA = "0x22F66A8")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x22F7048", Offset = "0x22F7048", VA = "0x22F7048")]
	public RayfireRecorder()
	{
	}
}
[Token(Token = "0x20000B2")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Restriction")]
[SelectionBase]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-restriction-component/")]
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
	[CompilerGenerated]
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
			[Address(RVA = "0x22F7D7C", Offset = "0x22F7D7C", VA = "0x22F7D7C", Slot = "4")]
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
			[Address(RVA = "0x22F7DC4", Offset = "0x22F7DC4", VA = "0x22F7DC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x22F7A40", Offset = "0x22F7A40", VA = "0x22F7A40")]
		[DebuggerHidden]
		public <RestrictionDistanceCor>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x22F7A90", Offset = "0x22F7A90", VA = "0x22F7A90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x22F7A94", Offset = "0x22F7A94", VA = "0x22F7A94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x22F7D84", Offset = "0x22F7D84", VA = "0x22F7D84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B7")]
	[CompilerGenerated]
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
			[Address(RVA = "0x22F8120", Offset = "0x22F8120", VA = "0x22F8120", Slot = "4")]
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
			[Address(RVA = "0x22F8168", Offset = "0x22F8168", VA = "0x22F8168", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x22F7A68", Offset = "0x22F7A68", VA = "0x22F7A68")]
		[DebuggerHidden]
		public <RestrictionTriggerCor>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x22F7DCC", Offset = "0x22F7DCC", VA = "0x22F7DCC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x22F7DD0", Offset = "0x22F7DD0", VA = "0x22F7DD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x22F8128", Offset = "0x22F8128", VA = "0x22F8128", Slot = "8")]
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
	[Address(RVA = "0x22F7554", Offset = "0x22F7554", VA = "0x22F7554")]
	public RayfireRestriction()
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0x22F759C", Offset = "0x22F759C", VA = "0x22F759C")]
	public void CopyFrom(RayfireRestriction rest)
	{
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0x22F7594", Offset = "0x22F7594", VA = "0x22F7594")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0x22F75E4", Offset = "0x22F75E4", VA = "0x22F75E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0x22F7684", Offset = "0x22F7684", VA = "0x22F7684")]
	public static void InitRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0x22F7950", Offset = "0x22F7950", VA = "0x22F7950")]
	private static void BrokeRestriction(RayfireRigid scr)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0x22F7880", Offset = "0x22F7880", VA = "0x22F7880")]
	[IteratorStateMachine(typeof(<RestrictionDistanceCor>d__19))]
	private static IEnumerator RestrictionDistanceCor(RayfireRigid scr)
	{
		return null;
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x22F78E8", Offset = "0x22F78E8", VA = "0x22F78E8")]
	[IteratorStateMachine(typeof(<RestrictionTriggerCor>d__20))]
	private static IEnumerator RestrictionTriggerCor(RayfireRigid scr)
	{
		return null;
	}
}
[Token(Token = "0x20000B8")]
[DisallowMultipleComponent]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-component/")]
[AddComponentMenu("RayFire/Rayfire Rigid")]
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
		[Address(RVA = "0x22F4598", Offset = "0x22F4598", VA = "0x22F4598")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000066")]
	public bool HasMeshes
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x22FBD14", Offset = "0x22FBD14", VA = "0x22FBD14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000067")]
	public bool HasRfMeshes
	{
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x22FBD34", Offset = "0x22FBD34", VA = "0x22FBD34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000068")]
	public bool HasDebris
	{
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x22FBD54", Offset = "0x22FBD54", VA = "0x22FBD54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000069")]
	public bool HasDust
	{
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x22FBDA8", Offset = "0x22FBDA8", VA = "0x22FBDA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public bool HasSlices
	{
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x22FB890", Offset = "0x22FB890", VA = "0x22FB890")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006B")]
	public bool IsCluster
	{
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x22FBDFC", Offset = "0x22FBDFC", VA = "0x22FBDFC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006C")]
	public float AmountIntegrity
	{
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x22FBE10", Offset = "0x22FBE10", VA = "0x22FBE10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x22F8170", Offset = "0x22F8170", VA = "0x22F8170")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x22F8234", Offset = "0x22F8234", VA = "0x22F8234")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6000427")]
	[Address(RVA = "0x22F8270", Offset = "0x22F8270", VA = "0x22F8270")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x22F8D80", Offset = "0x22F8D80", VA = "0x22F8D80")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x22F8DC8", Offset = "0x22F8DC8", VA = "0x22F8DC8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x22F8E10", Offset = "0x22F8E10", VA = "0x22F8E10")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x22F8FB8", Offset = "0x22F8FB8", VA = "0x22F8FB8")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x22F8448", Offset = "0x22F8448", VA = "0x22F8448")]
	public void SetComponentsBasic()
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x22F89B8", Offset = "0x22F89B8", VA = "0x22F89B8")]
	private void SetComponentsPhysics()
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x22F8E98", Offset = "0x22F8E98", VA = "0x22F8E98")]
	private void EditorSetupMeshRoot()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x22F8670", Offset = "0x22F8670", VA = "0x22F8670")]
	private bool SetupMeshRoot()
	{
		return default(bool);
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x22F93B8", Offset = "0x22F93B8", VA = "0x22F93B8")]
	private void MeshRootCheck()
	{
	}

	[Token(Token = "0x6000431")]
	[Address(RVA = "0x22F95A4", Offset = "0x22F95A4", VA = "0x22F95A4")]
	private void AddMeshRootRigid()
	{
	}

	[Token(Token = "0x6000432")]
	[Address(RVA = "0x22F9B54", Offset = "0x22F9B54", VA = "0x22F9B54")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x22F9040", Offset = "0x22F9040", VA = "0x22F9040")]
	private void ResetMeshRootSetup()
	{
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x22F8C3C", Offset = "0x22F8C3C", VA = "0x22F8C3C")]
	private void SetObjectType()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x22F8B58", Offset = "0x22F8B58", VA = "0x22F8B58")]
	public void Default()
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x22F9ED4", Offset = "0x22F9ED4", VA = "0x22F9ED4")]
	private void SetPhysics()
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x22F8C7C", Offset = "0x22F8C7C", VA = "0x22F8C7C")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x22FA06C", Offset = "0x22FA06C", VA = "0x22FA06C")]
	public void InactiveCors()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x22F819C", Offset = "0x22F819C", VA = "0x22F819C")]
	public void MeshInput()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x22FA150", Offset = "0x22FA150", VA = "0x22FA150", Slot = "4")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x22FA27C", Offset = "0x22FA27C", VA = "0x22FA27C", Slot = "5")]
	protected virtual bool CollisionDemolition(Collision collision)
	{
		return default(bool);
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x22FA238", Offset = "0x22FA238", VA = "0x22FA238")]
	private bool CollisionCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x22FA63C", Offset = "0x22FA63C", VA = "0x22FA63C")]
	public bool State()
	{
		return default(bool);
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x22FA770", Offset = "0x22FA770", VA = "0x22FA770", Slot = "6")]
	public virtual bool DemolitionState()
	{
		return default(bool);
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x22FA8D8", Offset = "0x22FA8D8", VA = "0x22FA8D8")]
	public void Demolish()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x22F9C50", Offset = "0x22F9C50", VA = "0x22F9C50")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x22FB15C", Offset = "0x22FB15C", VA = "0x22FB15C")]
	public void InitMeshFragments()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x22FB2B0", Offset = "0x22FB2B0", VA = "0x22FB2B0")]
	public void Prefragment()
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x22FB568", Offset = "0x22FB568", VA = "0x22FB568")]
	public void DeleteCache()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x22FB4A4", Offset = "0x22FB4A4", VA = "0x22FB4A4")]
	public void DeleteFragments()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x22FB5E4", Offset = "0x22FB5E4", VA = "0x22FB5E4")]
	public void AddSlicePlane(Vector3[] slicePlane)
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x22FB670", Offset = "0x22FB670", VA = "0x22FB670")]
	public void Slice()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x22FB8F0", Offset = "0x22FB8F0", VA = "0x22FB8F0")]
	public void CacheFrames()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x22FB924", Offset = "0x22FB924", VA = "0x22FB924")]
	[ContextMenu("SaveInitTransform")]
	public void SaveInitTransform()
	{
	}

	[Token(Token = "0x6000449")]
	[Address(RVA = "0x22F4590", Offset = "0x22F4590", VA = "0x22F4590")]
	public bool ApplyDamage(float damageValue, Vector3 damagePoint, float damageRadius = 0f, [Optional] Collider coll)
	{
		return default(bool);
	}

	[Token(Token = "0x600044A")]
	[Address(RVA = "0x22F4338", Offset = "0x22F4338", VA = "0x22F4338")]
	public void Activate(bool connCheck = true)
	{
	}

	[Token(Token = "0x600044B")]
	[Address(RVA = "0x22FBB04", Offset = "0x22FBB04", VA = "0x22FBB04")]
	public void Fade()
	{
	}

	[Token(Token = "0x600044C")]
	[Address(RVA = "0x22FBBAC", Offset = "0x22FBBAC", VA = "0x22FBBAC")]
	public void ResetRigid()
	{
	}

	[Token(Token = "0x600044D")]
	[Address(RVA = "0x22FBBB4", Offset = "0x22FBBB4", VA = "0x22FBBB4")]
	public void DestroyCollider(Collider col)
	{
	}

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x22FBC0C", Offset = "0x22FBC0C", VA = "0x22FBC0C")]
	public void DestroyObject(GameObject go)
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x22FBC64", Offset = "0x22FBC64", VA = "0x22FBC64")]
	public void DestroyRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000450")]
	[Address(RVA = "0x22FBCBC", Offset = "0x22FBCBC", VA = "0x22FBCBC")]
	public void DestroyRb(Rigidbody rb)
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x22FBE94", Offset = "0x22FBE94", VA = "0x22FBE94")]
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
	[Space(2f)]
	public RFLimitations limitations;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Space(2f)]
	public RFDemolitionCluster clusterDemolition;

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x22FC13C", Offset = "0x22FC13C", VA = "0x22FC13C")]
	public RFRigidRootDemolition()
	{
	}
}
[Token(Token = "0x20000BB")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-rigid-root-component/")]
[AddComponentMenu("RayFire/Rayfire Rigid Root")]
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
		[Address(RVA = "0x22FF524", Offset = "0x22FF524", VA = "0x22FF524")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006E")]
	public bool HasDebris
	{
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x22FF578", Offset = "0x22FF578", VA = "0x22FF578")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006F")]
	public bool HasDust
	{
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x22FF5CC", Offset = "0x22FF5CC", VA = "0x22FF5CC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000070")]
	public bool HasUny
	{
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x22FEEE4", Offset = "0x22FEEE4", VA = "0x22FEEE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x22FC1D4", Offset = "0x22FC1D4", VA = "0x22FC1D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x22FC2CC", Offset = "0x22FC2CC", VA = "0x22FC2CC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x22FC2F8", Offset = "0x22FC2F8", VA = "0x22FC2F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x22FC204", Offset = "0x22FC204", VA = "0x22FC204")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x22FC778", Offset = "0x22FC778", VA = "0x22FC778")]
	private void InitConnectivity()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x22FC9C0", Offset = "0x22FC9C0", VA = "0x22FC9C0")]
	public void ResetRigidRoot()
	{
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x22FC9C8", Offset = "0x22FC9C8", VA = "0x22FC9C8")]
	public void EditorSetup()
	{
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x22FCB50", Offset = "0x22FCB50", VA = "0x22FCB50")]
	public void ResetSetup()
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x22FC438", Offset = "0x22FC438", VA = "0x22FC438")]
	private void AwakeMethods()
	{
	}

	[Token(Token = "0x6000464")]
	[Address(RVA = "0x22FCF68", Offset = "0x22FCF68", VA = "0x22FCF68")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000465")]
	[Address(RVA = "0x22FDD98", Offset = "0x22FDD98", VA = "0x22FDD98")]
	private bool MeshRootCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x6000466")]
	[Address(RVA = "0x22FD000", Offset = "0x22FD000", VA = "0x22FD000")]
	private void SetShards()
	{
	}

	[Token(Token = "0x6000467")]
	[Address(RVA = "0x22FE2C0", Offset = "0x22FE2C0", VA = "0x22FE2C0")]
	private void SetCustomShardsLists()
	{
	}

	[Token(Token = "0x6000468")]
	[Address(RVA = "0x22FE544", Offset = "0x22FE544", VA = "0x22FE544")]
	private void SetShardsSimulationType()
	{
	}

	[Token(Token = "0x6000469")]
	[Address(RVA = "0x22FE6A8", Offset = "0x22FE6A8", VA = "0x22FE6A8")]
	private void SetParentList()
	{
	}

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x22FE804", Offset = "0x22FE804", VA = "0x22FE804")]
	private void AddShard(Transform shardTm, [Optional] RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x22FE944", Offset = "0x22FE944", VA = "0x22FE944")]
	private void AddShardWithRigid(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x22FD970", Offset = "0x22FD970", VA = "0x22FD970")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x22FDE78", Offset = "0x22FDE78", VA = "0x22FDE78")]
	private void SetCollidersMaterial()
	{
	}

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x22FE058", Offset = "0x22FE058", VA = "0x22FE058")]
	public void SetInactiveList()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x22FDB6C", Offset = "0x22FDB6C", VA = "0x22FDB6C")]
	private void SetUnyielding()
	{
	}

	[Token(Token = "0x6000470")]
	[Address(RVA = "0x22FC340", Offset = "0x22FC340", VA = "0x22FC340")]
	public void StartAllCoroutines()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0x22FF3E8", Offset = "0x22FF3E8", VA = "0x22FF3E8")]
	public void CopyPropertiesTo(RayfireRigid toScr)
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x22FF4A8", Offset = "0x22FF4A8", VA = "0x22FF4A8")]
	private static bool IsNestedCluster(Transform trans)
	{
		return default(bool);
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x22FEA44", Offset = "0x22FEA44", VA = "0x22FEA44")]
	private static bool ShardFilter(RFShard shard, RayfireRigidRoot scr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0x22FF620", Offset = "0x22FF620", VA = "0x22FF620")]
	public void CollideTest()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0x22FF62C", Offset = "0x22FF62C", VA = "0x22FF62C")]
	public RayfireRigidRoot()
	{
	}
}
[Token(Token = "0x20000BD")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-shatter-component/")]
[AddComponentMenu("RayFire/Rayfire Shatter")]
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
	[Address(RVA = "0x22FF7E8", Offset = "0x22FF7E8", VA = "0x22FF7E8")]
	private void Reset()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0x22FF964", Offset = "0x22FF964", VA = "0x22FF964")]
	private void SetVariables()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0x22FFA04", Offset = "0x22FFA04", VA = "0x22FFA04")]
	private bool MainCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0x22FFDD8", Offset = "0x22FFDD8", VA = "0x22FFDD8")]
	private bool SingleMeshCheck()
	{
		return default(bool);
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0x2300034", Offset = "0x2300034", VA = "0x2300034")]
	private bool DefineComponents()
	{
		return default(bool);
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0x23002DC", Offset = "0x23002DC", VA = "0x23002DC")]
	public Bounds GetBound()
	{
		return default(Bounds);
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0x2300454", Offset = "0x2300454", VA = "0x2300454")]
	public void Fragment(FragLastMode fragmentMode = FragLastMode.New)
	{
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0x23008F8", Offset = "0x23008F8", VA = "0x23008F8")]
	private List<GameObject> CreateFragments([Optional] Transform root)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0x2301620", Offset = "0x2301620", VA = "0x2301620")]
	public void DeleteFragmentsLast(int destroyMode = 0)
	{
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0x2301984", Offset = "0x2301984", VA = "0x2301984")]
	public void DeleteFragmentsAll()
	{
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0x22FF7EC", Offset = "0x22FF7EC", VA = "0x22FF7EC")]
	public void ResetCenter()
	{
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0x230061C", Offset = "0x230061C", VA = "0x230061C")]
	private void ScaleCheck()
	{
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0x2301B2C", Offset = "0x2301B2C", VA = "0x2301B2C")]
	public void ResetScale(float scaleValue)
	{
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0x22F9934", Offset = "0x22F9934", VA = "0x22F9934")]
	public static void CopyRootMeshShatter(RayfireRigid source, List<RayfireRigid> targets)
	{
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0x2301DDC", Offset = "0x2301DDC", VA = "0x2301DDC")]
	private void CopyFrom(RayfireShatter shatter)
	{
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0x230129C", Offset = "0x230129C", VA = "0x230129C")]
	private void SizeLimitation()
	{
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0x2301420", Offset = "0x2301420", VA = "0x2301420")]
	private void VertexLimitation()
	{
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0x2301510", Offset = "0x2301510", VA = "0x2301510")]
	private void TriangleLimitation()
	{
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x2302024", Offset = "0x2302024", VA = "0x2302024")]
	private void LimitationFragment(int ind)
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x2302364", Offset = "0x2302364", VA = "0x2302364")]
	public RayfireShatter()
	{
	}
}
[Token(Token = "0x20000BF")]
[DisallowMultipleComponent]
[AddComponentMenu("RayFire/Rayfire Snapshot")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-snapshot-component/")]
[SelectionBase]
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
	[Address(RVA = "0x2302784", Offset = "0x2302784", VA = "0x2302784")]
	private void Reset()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x23027B0", Offset = "0x23027B0", VA = "0x23027B0")]
	public RayfireSnapshot()
	{
	}
}
[Token(Token = "0x20000C0")]
[AddComponentMenu("RayFire/Rayfire Sound")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-sound-component/")]
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
	[Address(RVA = "0x23027B8", Offset = "0x23027B8", VA = "0x23027B8")]
	public RayfireSound()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x23027E0", Offset = "0x23027E0", VA = "0x23027E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0x23027E4", Offset = "0x23027E4", VA = "0x23027E4")]
	private void SetComponents()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0x23028E4", Offset = "0x23028E4", VA = "0x23028E4")]
	private void WarningCheck()
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0x2302D04", Offset = "0x2302D04", VA = "0x2302D04")]
	public void CopyFrom(RayfireSound source)
	{
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0x2302DD4", Offset = "0x2302DD4", VA = "0x2302DD4")]
	private void CreateSource(RayfireRigid scr)
	{
	}
}
[Token(Token = "0x20000C1")]
[AddComponentMenu("RayFire/Rayfire Unyielding")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-unyielding-component/")]
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
		[Address(RVA = "0x2304550", Offset = "0x2304550", VA = "0x2304550")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000072")]
	private bool HasShards
	{
		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x23045A4", Offset = "0x23045A4", VA = "0x23045A4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000073")]
	public Vector3 Extents
	{
		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x23035D0", Offset = "0x23035D0", VA = "0x23035D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0x2303028", Offset = "0x2303028", VA = "0x2303028")]
	public static void ClusterSetup(RayfireRigid rigid)
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0x2303100", Offset = "0x2303100", VA = "0x2303100")]
	private static void ClusterOverlap(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0x2303470", Offset = "0x2303470", VA = "0x2303470")]
	private static int ClusterLayerMask(RayfireRigid rigid)
	{
		return default(int);
	}

	[Token(Token = "0x600049B")]
	[Address(RVA = "0x2303674", Offset = "0x2303674", VA = "0x2303674")]
	private static void SetShardUnyState(RFShard shard, bool unyielding, bool activatable)
	{
	}

	[Token(Token = "0x600049C")]
	[Address(RVA = "0x22F9A94", Offset = "0x22F9A94", VA = "0x22F9A94")]
	public static void MeshRootSetup(RayfireRigid mRoot)
	{
	}

	[Token(Token = "0x600049D")]
	[Address(RVA = "0x2303698", Offset = "0x2303698", VA = "0x2303698")]
	private static List<RayfireUnyielding> GetUnyList(Transform tm)
	{
		return null;
	}

	[Token(Token = "0x600049E")]
	[Address(RVA = "0x2303794", Offset = "0x2303794", VA = "0x2303794")]
	private static void SetMeshRootUnyRigidList(RayfireRigid mRoot, RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x600049F")]
	[Address(RVA = "0x2303B70", Offset = "0x2303B70", VA = "0x2303B70")]
	private static int MeshRootLayerMask(RayfireRigid mRoot)
	{
		return default(int);
	}

	[Token(Token = "0x60004A0")]
	[Address(RVA = "0x2303A90", Offset = "0x2303A90", VA = "0x2303A90")]
	public static void SetMeshRootUny(Transform tm, List<RayfireUnyielding> unyList)
	{
	}

	[Token(Token = "0x60004A1")]
	[Address(RVA = "0x2303C8C", Offset = "0x2303C8C", VA = "0x2303C8C")]
	private static void SetRigidUnyState(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004A2")]
	[Address(RVA = "0x2303E80", Offset = "0x2303E80", VA = "0x2303E80")]
	private static void SetRigidUnySim(RayfireUnyielding uny)
	{
	}

	[Token(Token = "0x60004A3")]
	[Address(RVA = "0x22FAAD4", Offset = "0x22FAAD4", VA = "0x22FAAD4")]
	public static void SetUnyieldingFragments(RayfireRigid scr)
	{
	}

	[Token(Token = "0x60004A4")]
	[Address(RVA = "0x2304010", Offset = "0x2304010", VA = "0x2304010")]
	private static void SetRigidUnyState(RayfireRigid rigid, bool uny, bool act)
	{
	}

	[Token(Token = "0x60004A5")]
	[Address(RVA = "0x230407C", Offset = "0x230407C", VA = "0x230407C")]
	private static void CopyUny(RayfireUnyielding source, GameObject target)
	{
	}

	[Token(Token = "0x60004A6")]
	[Address(RVA = "0x22FEF38", Offset = "0x22FEF38", VA = "0x22FEF38")]
	public void GetRigidRootUnyShardList(RayfireRigidRoot rigidRoot)
	{
	}

	[Token(Token = "0x60004A7")]
	[Address(RVA = "0x22FF300", Offset = "0x22FF300", VA = "0x22FF300")]
	public void SetRigidRootUnyShardList()
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0x23041DC", Offset = "0x23041DC", VA = "0x23041DC")]
	public void Activate()
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x23045F8", Offset = "0x23045F8", VA = "0x23045F8")]
	public RayfireUnyielding()
	{
	}
}
[Token(Token = "0x20000C3")]
[AddComponentMenu("RayFire/Rayfire Vortex")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-vortex-component/")]
public class RayfireVortex : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2305A48", Offset = "0x2305A48", VA = "0x2305A48", Slot = "4")]
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
			[Address(RVA = "0x2305A90", Offset = "0x2305A90", VA = "0x2305A90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x2304708", Offset = "0x2304708", VA = "0x2304708")]
		[DebuggerHidden]
		public <VortexForceCor>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x2305938", Offset = "0x2305938", VA = "0x2305938", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x230593C", Offset = "0x230593C", VA = "0x230593C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2305A50", Offset = "0x2305A50", VA = "0x2305A50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2305BBC", Offset = "0x2305BBC", VA = "0x2305BBC", Slot = "4")]
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
			[Address(RVA = "0x2305C04", Offset = "0x2305C04", VA = "0x2305C04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2304798", Offset = "0x2304798", VA = "0x2304798")]
		[DebuggerHidden]
		public <SetCollidersCor>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2305A98", Offset = "0x2305A98", VA = "0x2305A98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x2305A9C", Offset = "0x2305A9C", VA = "0x2305A9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2305BC4", Offset = "0x2305BC4", VA = "0x2305BC4", Slot = "8")]
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
	[Address(RVA = "0x2304620", Offset = "0x2304620", VA = "0x2304620")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x2304624", Offset = "0x2304624", VA = "0x2304624")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x23046A0", Offset = "0x23046A0", VA = "0x23046A0")]
	[IteratorStateMachine(typeof(<VortexForceCor>d__50))]
	private IEnumerator VortexForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x2304730", Offset = "0x2304730", VA = "0x2304730")]
	[IteratorStateMachine(typeof(<SetCollidersCor>d__51))]
	private IEnumerator SetCollidersCor()
	{
		return null;
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x23047C0", Offset = "0x23047C0", VA = "0x23047C0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x23047F8", Offset = "0x23047F8", VA = "0x23047F8")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004B3")]
	[Address(RVA = "0x23048EC", Offset = "0x23048EC", VA = "0x23048EC")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004B4")]
	[Address(RVA = "0x23049F0", Offset = "0x23049F0", VA = "0x23049F0")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004B5")]
	[Address(RVA = "0x2304C18", Offset = "0x2304C18", VA = "0x2304C18")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004B6")]
	[Address(RVA = "0x23052E0", Offset = "0x23052E0", VA = "0x23052E0")]
	private Vector3 GetClosetLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004B7")]
	[Address(RVA = "0x23054E4", Offset = "0x23054E4", VA = "0x23054E4")]
	private Vector3 GetParallelLinePoint(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004B8")]
	[Address(RVA = "0x2305618", Offset = "0x2305618", VA = "0x2305618")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x60004B9")]
	[Address(RVA = "0x2305744", Offset = "0x2305744", VA = "0x2305744")]
	private static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004BA")]
	[Address(RVA = "0x2305414", Offset = "0x2305414", VA = "0x2305414")]
	private float HeightBias(float upRateOwnLoc, float centerRateOwnLoc)
	{
		return default(float);
	}

	[Token(Token = "0x60004BB")]
	[Address(RVA = "0x2305824", Offset = "0x2305824", VA = "0x2305824")]
	public RayfireVortex()
	{
	}
}
[Token(Token = "0x20000C6")]
[AddComponentMenu("RayFire/Rayfire Wind")]
[HelpURL("https://rayfirestudios.com/unity-online-help/components/unity-wind-component/")]
public class RayfireWind : MonoBehaviour
{
	[Token(Token = "0x20000C7")]
	[CompilerGenerated]
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
			[Address(RVA = "0x2306A20", Offset = "0x2306A20", VA = "0x2306A20", Slot = "4")]
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
			[Address(RVA = "0x2306A68", Offset = "0x2306A68", VA = "0x2306A68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2305CF4", Offset = "0x2305CF4", VA = "0x2305CF4")]
		[DebuggerHidden]
		public <WindForceCor>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2306960", Offset = "0x2306960", VA = "0x2306960", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x2306964", Offset = "0x2306964", VA = "0x2306964", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x2306A28", Offset = "0x2306A28", VA = "0x2306A28", Slot = "8")]
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
	[Address(RVA = "0x2305C0C", Offset = "0x2305C0C", VA = "0x2305C0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x2305C10", Offset = "0x2305C10", VA = "0x2305C10")]
	private void DefineComponents()
	{
	}

	[Token(Token = "0x60004CA")]
	[Address(RVA = "0x2305C8C", Offset = "0x2305C8C", VA = "0x2305C8C")]
	[IteratorStateMachine(typeof(<WindForceCor>d__25))]
	private IEnumerator WindForceCor()
	{
		return null;
	}

	[Token(Token = "0x60004CB")]
	[Address(RVA = "0x2305D1C", Offset = "0x2305D1C", VA = "0x2305D1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60004CC")]
	[Address(RVA = "0x2305D3C", Offset = "0x2305D3C", VA = "0x2305D3C")]
	private void Reset()
	{
	}

	[Token(Token = "0x60004CD")]
	[Address(RVA = "0x2305D48", Offset = "0x2305D48", VA = "0x2305D48")]
	private void SetColliders()
	{
	}

	[Token(Token = "0x60004CE")]
	[Address(RVA = "0x2305F0C", Offset = "0x2305F0C", VA = "0x2305F0C")]
	private void SetColliderGizmo()
	{
	}

	[Token(Token = "0x60004CF")]
	[Address(RVA = "0x2305F60", Offset = "0x2305F60", VA = "0x2305F60")]
	private void SetRigidBodies()
	{
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x2306188", Offset = "0x2306188", VA = "0x2306188")]
	private void SetForce()
	{
	}

	[Token(Token = "0x60004D1")]
	[Address(RVA = "0x23064D8", Offset = "0x23064D8", VA = "0x23064D8")]
	private Vector3 GetVectorGlobal(Vector3 worldPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x230652C", Offset = "0x230652C", VA = "0x230652C")]
	public Vector3 GetVectorLocal(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x230667C", Offset = "0x230667C", VA = "0x230667C")]
	public Vector3 GetVectorLocalPreview(Vector3 localPos)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x2306488", Offset = "0x2306488", VA = "0x2306488")]
	private float PerlinFixedGlobal(Vector3 worldPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x23067B4", Offset = "0x23067B4", VA = "0x23067B4")]
	public float PerlinFixedLocal(Vector3 localPos)
	{
		return default(float);
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x23067F8", Offset = "0x23067F8", VA = "0x23067F8")]
	public float PerlinCustomGlobal(Vector3 worldPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004D7")]
	[Address(RVA = "0x2306648", Offset = "0x2306648", VA = "0x2306648")]
	public float PerlinCustomLocal(Vector3 localPos, float SizeX, float SizeZ, float WidthScale, float LengthScale, float GlobalScale, float Offset)
	{
		return default(float);
	}

	[Token(Token = "0x60004D8")]
	[Address(RVA = "0x23064B0", Offset = "0x23064B0", VA = "0x23064B0")]
	public float WindStrength(float val)
	{
		return default(float);
	}

	[Token(Token = "0x60004D9")]
	[Address(RVA = "0x2306440", Offset = "0x2306440", VA = "0x2306440")]
	private void SetSpeed()
	{
	}

	[Token(Token = "0x60004DA")]
	[Address(RVA = "0x2306874", Offset = "0x2306874", VA = "0x2306874")]
	public RayfireWind()
	{
	}
}
