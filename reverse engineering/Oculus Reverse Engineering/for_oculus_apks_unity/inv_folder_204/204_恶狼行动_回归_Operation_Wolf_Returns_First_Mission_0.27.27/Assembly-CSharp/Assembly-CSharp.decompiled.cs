using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DigitalOpus.MB.Core;
using Il2CppDummyDll;
using Sony.PS4.SaveData;
using StylizedWater;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.Layouts;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
[ExecuteInEditMode]
[AddComponentMenu("")]
public class FoliageChunk : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000003")]
	public struct Quad
	{
		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 p0;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 p1;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 p2;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 p3;

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xEE0C54", Offset = "0xEE0C54", VA = "0xEE0C54")]
		public Quad(Vector3 A, Vector3 B, Vector3 C, Vector3 D)
		{
		}
	}

	[Token(Token = "0x2000004")]
	[BurstCompile(CompileSynchronously = true)]
	private struct GrassJob : IJobParallelFor
	{
		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[ReadOnly]
		public bool billboard;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[ReadOnly]
		public int offset;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[WriteOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<Vector3> verts;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[NativeDisableParallelForRestriction]
		[WriteOnly]
		public NativeArray<int> tris;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<float> rotations;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[ReadOnly]
		public NativeArray<Vector3> points;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[ReadOnly]
		public NativeArray<Vector3> normals;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[ReadOnly]
		public NativeArray<Vector3> bitangents;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[ReadOnly]
		public Quad quad;

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xEE0E04", Offset = "0xEE0E04", VA = "0xEE0E04", Slot = "4")]
		public void Execute(int i)
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 key;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FoliageContainer container;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public List<Vector3> points;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public List<Vector3> normals;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public List<Vector4> tangents;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Vector3> bitangents;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<float> rotations;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public MeshFilter meshFilter;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public MeshRenderer meshRenderer;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Material grassMat;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	[HideInInspector]
	private int instanceID;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xEDFDF8", Offset = "0xEDFDF8", VA = "0xEDFDF8")]
	public void RemoveAt(int i)
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xEDFEC8", Offset = "0xEDFEC8", VA = "0xEDFEC8")]
	public void InitializeTransform(Transform parent, Vector3 localSpacePos)
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xEE0008", Offset = "0xEE0008", VA = "0xEE0008")]
	public void RebuildGrass(bool billboard)
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xEE0C84", Offset = "0xEE0C84", VA = "0xEE0C84")]
	public FoliageChunk()
	{
	}
}
[Token(Token = "0x2000006")]
[AddComponentMenu("")]
public class FoliageContainer : MonoBehaviour
{
	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<Vector3> chunkKeys;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<FoliageChunk> chunks;

	[Token(Token = "0x17000001")]
	public int ChunkCount
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0xEE0C08", Offset = "0xEE0C08", VA = "0xEE0C08")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xEE135C", Offset = "0xEE135C", VA = "0xEE135C")]
	public bool TryGetChunk(Vector3 key, out FoliageChunk chunk)
	{
		return default(bool);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xEE14DC", Offset = "0xEE14DC", VA = "0xEE14DC")]
	public void AddChunk(Vector3 key, FoliageChunk chunk)
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xEE0AF0", Offset = "0xEE0AF0", VA = "0xEE0AF0")]
	public void RemoveChunk(Vector3 key)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xEE1630", Offset = "0xEE1630", VA = "0xEE1630")]
	public void ClearChunks()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xEE16C0", Offset = "0xEE16C0", VA = "0xEE16C0")]
	public void InitializeTransform(Transform parent)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xEE1818", Offset = "0xEE1818", VA = "0xEE1818")]
	public void UpdateTransform()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xEE1988", Offset = "0xEE1988", VA = "0xEE1988")]
	public FoliageContainer()
	{
	}
}
[Token(Token = "0x2000007")]
public class SimpleTextureDrawing : MonoBehaviour
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material aMaterial;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RenderTexture[] aTextures;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xEE1A60", Offset = "0xEE1A60", VA = "0xEE1A60")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xEE1B80", Offset = "0xEE1B80", VA = "0xEE1B80")]
	public SimpleTextureDrawing()
	{
	}
}
[Token(Token = "0x2000008")]
public class CFX2_Demo : MonoBehaviour
{
	[Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX2_Demo <>4__this;

		[Token(Token = "0x17000002")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0xEE2BF0", Offset = "0xEE2BF0", VA = "0xEE2BF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000003")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0xEE2C38", Offset = "0xEE2C38", VA = "0xEE2C38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xEE2928", Offset = "0xEE2928", VA = "0xEE2928")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xEE2A0C", Offset = "0xEE2A0C", VA = "0xEE2A0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xEE2A10", Offset = "0xEE2A10", VA = "0xEE2A10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xEE2BF8", Offset = "0xEE2BF8", VA = "0xEE2BF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool orderedSpawns;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float step;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float order;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material groundMat;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material waterMat;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleExamples;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int exampleIndex;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string randomSpawnsDelay;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool randomSpawns;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool slowMo;

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xEE1B88", Offset = "0xEE1B88", VA = "0xEE1B88")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xEE1CD4", Offset = "0xEE1CD4", VA = "0xEE1CD4")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xEE1E34", Offset = "0xEE1E34", VA = "0xEE1E34")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xEE28B4", Offset = "0xEE28B4", VA = "0xEE28B4")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__14))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xEE2950", Offset = "0xEE2950", VA = "0xEE2950")]
	private void Update()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xEE2634", Offset = "0xEE2634", VA = "0xEE2634")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xEE2778", Offset = "0xEE2778", VA = "0xEE2778")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xEE2998", Offset = "0xEE2998", VA = "0xEE2998")]
	public CFX2_Demo()
	{
	}
}
[Token(Token = "0x200000A")]
public class CFX3_Demo : MonoBehaviour
{
	[Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class <CheckForDeletedParticles>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX3_Demo <>4__this;

		[Token(Token = "0x17000004")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0xEE40BC", Offset = "0xEE40BC", VA = "0xEE40BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000005")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002F")]
			[Address(RVA = "0xEE4104", Offset = "0xEE4104", VA = "0xEE4104", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xEE3DAC", Offset = "0xEE3DAC", VA = "0xEE3DAC")]
		[DebuggerHidden]
		public <CheckForDeletedParticles>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xEE3F40", Offset = "0xEE3F40", VA = "0xEE3F40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xEE3F44", Offset = "0xEE3F44", VA = "0xEE3F44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xEE40C4", Offset = "0xEE40C4", VA = "0xEE40C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX3_Demo <>4__this;

		[Token(Token = "0x17000006")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0xEE42F0", Offset = "0xEE42F0", VA = "0xEE42F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xEE4338", Offset = "0xEE4338", VA = "0xEE4338", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xEE3E48", Offset = "0xEE3E48", VA = "0xEE3E48")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xEE410C", Offset = "0xEE410C", VA = "0xEE410C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xEE4110", Offset = "0xEE4110", VA = "0xEE4110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xEE42F8", Offset = "0xEE42F8", VA = "0xEE42F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool orderedSpawns;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float step;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float order;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer groundRenderer;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider groundCollider;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject[] ParticleExamples;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int exampleIndex;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string randomSpawnsDelay;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool randomSpawns;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool slowMo;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private List<GameObject> onScreenParticles;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xEE2C40", Offset = "0xEE2C40", VA = "0xEE2C40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xEE2DD4", Offset = "0xEE2DD4", VA = "0xEE2DD4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xEE33F4", Offset = "0xEE33F4", VA = "0xEE33F4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xEE3148", Offset = "0xEE3148", VA = "0xEE3148")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xEE3D38", Offset = "0xEE3D38", VA = "0xEE3D38")]
	[IteratorStateMachine(typeof(<CheckForDeletedParticles>d__16))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xEE3DD4", Offset = "0xEE3DD4", VA = "0xEE3DD4")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__17))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xEE2FB0", Offset = "0xEE2FB0", VA = "0xEE2FB0")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xEE2FE4", Offset = "0xEE2FE4", VA = "0xEE2FE4")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xEE3018", Offset = "0xEE3018", VA = "0xEE3018")]
	private void destroyParticles()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xEE3E70", Offset = "0xEE3E70", VA = "0xEE3E70")]
	public CFX3_Demo()
	{
	}
}
[Token(Token = "0x200000D")]
public class CFX_Demo : MonoBehaviour
{
	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo <>4__this;

		[Token(Token = "0x17000008")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000041")]
			[Address(RVA = "0xEE5A44", Offset = "0xEE5A44", VA = "0xEE5A44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000043")]
			[Address(RVA = "0xEE5A8C", Offset = "0xEE5A8C", VA = "0xEE5A8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xEE5308", Offset = "0xEE5308", VA = "0xEE5308")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xEE5860", Offset = "0xEE5860", VA = "0xEE5860", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xEE5864", Offset = "0xEE5864", VA = "0xEE5864", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xEE5A4C", Offset = "0xEE5A4C", VA = "0xEE5A4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool orderedSpawns;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float step;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float range;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float order;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material groundMat;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Material waterMat;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject[] ParticleExamples;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, float> ParticlesYOffsetD;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int exampleIndex;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string randomSpawnsDelay;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool randomSpawns;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool slowMo;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xEE4340", Offset = "0xEE4340", VA = "0xEE4340")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xEE448C", Offset = "0xEE448C", VA = "0xEE448C")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xEE4734", Offset = "0xEE4734", VA = "0xEE4734")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xEE5294", Offset = "0xEE5294", VA = "0xEE5294")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__15))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xEE5330", Offset = "0xEE5330", VA = "0xEE5330")]
	private void Update()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xEE4F7C", Offset = "0xEE4F7C", VA = "0xEE4F7C")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xEE510C", Offset = "0xEE510C", VA = "0xEE510C")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xEE5378", Offset = "0xEE5378", VA = "0xEE5378")]
	public CFX_Demo()
	{
	}
}
[Token(Token = "0x200000F")]
public class CFX_Demo_New : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class <CheckForDeletedParticles>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_Demo_New <>4__this;

		[Token(Token = "0x1700000A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xEE6A7C", Offset = "0xEE6A7C", VA = "0xEE6A7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xEE6AC4", Offset = "0xEE6AC4", VA = "0xEE6AC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xEE6788", Offset = "0xEE6788", VA = "0xEE6788")]
		[DebuggerHidden]
		public <CheckForDeletedParticles>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xEE6900", Offset = "0xEE6900", VA = "0xEE6900", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xEE6904", Offset = "0xEE6904", VA = "0xEE6904", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xEE6A84", Offset = "0xEE6A84", VA = "0xEE6A84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer groundRenderer;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider groundCollider;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[Space]
	public Image slowMoBtn;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text slowMoLabel;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image camRotBtn;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text camRotLabel;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image groundBtn;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text groundLabel;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space]
	public Text EffectLabel;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text EffectIndexLabel;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject[] ParticleExamples;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int exampleIndex;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool slowMo;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 defaultCamPosition;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private Quaternion defaultCamRotation;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private List<GameObject> onScreenParticles;

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xEE5A94", Offset = "0xEE5A94", VA = "0xEE5A94")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xEE5E78", Offset = "0xEE5E78", VA = "0xEE5E78")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xEE64DC", Offset = "0xEE64DC", VA = "0xEE64DC")]
	public void OnToggleGround()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xEE659C", Offset = "0xEE659C", VA = "0xEE659C")]
	public void OnToggleCamera()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xEE666C", Offset = "0xEE666C", VA = "0xEE666C")]
	public void OnToggleSlowMo()
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xEE670C", Offset = "0xEE670C", VA = "0xEE670C")]
	public void OnPreviousEffect()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xEE6710", Offset = "0xEE6710", VA = "0xEE6710")]
	public void OnNextEffect()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xEE5D4C", Offset = "0xEE5D4C", VA = "0xEE5D4C")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xEE62B4", Offset = "0xEE62B4", VA = "0xEE62B4")]
	private GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xEE6714", Offset = "0xEE6714", VA = "0xEE6714")]
	[IteratorStateMachine(typeof(<CheckForDeletedParticles>d__25))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0xEE611C", Offset = "0xEE611C", VA = "0xEE611C")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xEE6150", Offset = "0xEE6150", VA = "0xEE6150")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xEE6184", Offset = "0xEE6184", VA = "0xEE6184")]
	private void destroyParticles()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xEE67B0", Offset = "0xEE67B0", VA = "0xEE67B0")]
	public CFX_Demo_New()
	{
	}
}
[Token(Token = "0x2000012")]
public class CFX_Demo_RandomDir : MonoBehaviour
{
	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 min;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 max;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xEE6ACC", Offset = "0xEE6ACC", VA = "0xEE6ACC")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xEE6B54", Offset = "0xEE6B54", VA = "0xEE6B54")]
	public CFX_Demo_RandomDir()
	{
	}
}
[Token(Token = "0x2000013")]
public class CFX_Demo_RandomDirectionTranslate : MonoBehaviour
{
	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 baseDir;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xEE6B6C", Offset = "0xEE6B6C", VA = "0xEE6B6C")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xEE6CB0", Offset = "0xEE6CB0", VA = "0xEE6CB0")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xEE6D8C", Offset = "0xEE6D8C", VA = "0xEE6D8C")]
	public CFX_Demo_RandomDirectionTranslate()
	{
	}
}
[Token(Token = "0x2000014")]
public class CFX_Demo_GTButton : MonoBehaviour
{
	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color NormalColor;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color HoverColor;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string Callback;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject Receiver;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Rect CollisionRect;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool Over;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xEE6E28", Offset = "0xEE6E28", VA = "0xEE6E28")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xEE6E2C", Offset = "0xEE6E2C", VA = "0xEE6E2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xEE6EFC", Offset = "0xEE6EFC", VA = "0xEE6EFC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xEE6F20", Offset = "0xEE6F20", VA = "0xEE6F20")]
	public CFX_Demo_GTButton()
	{
	}
}
[Token(Token = "0x2000015")]
public class CFX_Demo_GTToggle : MonoBehaviour
{
	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture Normal;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture Hover;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color NormalColor;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Color DisabledColor;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool State;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string Callback;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject Receiver;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rect CollisionRect;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool Over;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Text Label;

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xEE6F3C", Offset = "0xEE6F3C", VA = "0xEE6F3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xEE70D4", Offset = "0xEE70D4", VA = "0xEE70D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xEE7188", Offset = "0xEE7188", VA = "0xEE7188")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xEE6F9C", Offset = "0xEE6F9C", VA = "0xEE6F9C")]
	private void UpdateTexture()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xEE71B8", Offset = "0xEE71B8", VA = "0xEE71B8")]
	public CFX_Demo_GTToggle()
	{
	}
}
[Token(Token = "0x2000016")]
public class CFX2_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 speed;

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xEE71E4", Offset = "0xEE71E4", VA = "0xEE71E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xEE7240", Offset = "0xEE7240", VA = "0xEE7240")]
	public CFX2_AutoRotate()
	{
	}
}
[Token(Token = "0x2000017")]
public class CFX_AutodestructWhenNoChildren : MonoBehaviour
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0xEE7258", Offset = "0xEE7258", VA = "0xEE7258")]
	private void Update()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xEE72F0", Offset = "0xEE72F0", VA = "0xEE72F0")]
	public CFX_AutodestructWhenNoChildren()
	{
	}
}
[Token(Token = "0x2000018")]
public class CFX_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotation;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Space space;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xEE72F8", Offset = "0xEE72F8", VA = "0xEE72F8")]
	private void Update()
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xEE7360", Offset = "0xEE7360", VA = "0xEE7360")]
	public CFX_AutoRotate()
	{
	}
}
[Token(Token = "0x2000019")]
public class CFX_InspectorHelp : MonoBehaviour
{
	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Locked;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string Title;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string HelpText;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int MsgType;

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xEE7370", Offset = "0xEE7370", VA = "0xEE7370")]
	[ContextMenu("Unlock editing")]
	private void Unlock()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xEE7378", Offset = "0xEE7378", VA = "0xEE7378")]
	public CFX_InspectorHelp()
	{
	}
}
[Token(Token = "0x200001A")]
[RequireComponent(typeof(Light))]
public class CFX_LightFlicker : MonoBehaviour
{
	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool loop;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float smoothFactor;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float addIntensity;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float minIntensity;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float maxIntensity;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float baseIntensity;

	[Token(Token = "0x6000071")]
	[Address(RVA = "0xEE7380", Offset = "0xEE7380", VA = "0xEE7380")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xEE73E0", Offset = "0xEE73E0", VA = "0xEE73E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xEE73F4", Offset = "0xEE73F4", VA = "0xEE73F4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xEE74A4", Offset = "0xEE74A4", VA = "0xEE74A4")]
	public CFX_LightFlicker()
	{
	}
}
[Token(Token = "0x200001B")]
public class CFX_ShurikenThreadFix : MonoBehaviour
{
	[Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class <WaitFrame>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_ShurikenThreadFix <>4__this;

		[Token(Token = "0x1700000C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0xEE76F8", Offset = "0xEE76F8", VA = "0xEE76F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0xEE7740", Offset = "0xEE7740", VA = "0xEE7740", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0xEE7614", Offset = "0xEE7614", VA = "0xEE7614")]
		[DebuggerHidden]
		public <WaitFrame>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xEE7644", Offset = "0xEE7644", VA = "0xEE7644", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xEE7648", Offset = "0xEE7648", VA = "0xEE7648", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xEE7700", Offset = "0xEE7700", VA = "0xEE7700", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ParticleSystem[] systems;

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xEE74B4", Offset = "0xEE74B4", VA = "0xEE74B4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xEE75A0", Offset = "0xEE75A0", VA = "0xEE75A0")]
	[IteratorStateMachine(typeof(<WaitFrame>d__2))]
	private IEnumerator WaitFrame()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xEE763C", Offset = "0xEE763C", VA = "0xEE763C")]
	public CFX_ShurikenThreadFix()
	{
	}
}
[Token(Token = "0x200001D")]
[ExecuteInEditMode]
public class MC_CreateMatCap : MonoBehaviour
{
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera screenshotCamera;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material previewMaterial;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("View the saved PNG in the file browser on save")]
	public bool revealOnSave;

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xEE7748", Offset = "0xEE7748", VA = "0xEE7748")]
	public MC_CreateMatCap()
	{
	}
}
[Token(Token = "0x200001E")]
public class MC_AutoRotate : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 rotation;

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xEE7758", Offset = "0xEE7758", VA = "0xEE7758")]
	private void Update()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xEE77B8", Offset = "0xEE77B8", VA = "0xEE77B8")]
	public MC_AutoRotate()
	{
	}
}
[Token(Token = "0x200001F")]
[RequireComponent(typeof(RawImage))]
public class MC_SwitchTexture : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture[] textures;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material targetMaterial;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private RawImage image;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xEE77C0", Offset = "0xEE77C0", VA = "0xEE77C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xEE78B4", Offset = "0xEE78B4", VA = "0xEE78B4", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xEE78F0", Offset = "0xEE78F0", VA = "0xEE78F0")]
	public void NextTexture()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xEE7924", Offset = "0xEE7924", VA = "0xEE7924")]
	public void PrevTexture()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xEE7820", Offset = "0xEE7820", VA = "0xEE7820")]
	private void ReloadTexture()
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0xEE7958", Offset = "0xEE7958", VA = "0xEE7958")]
	public MC_SwitchTexture()
	{
	}
}
[Token(Token = "0x2000020")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoStopLoopedEffect : MonoBehaviour
{
	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float effectDuration;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float d;

	[Token(Token = "0x6000087")]
	[Address(RVA = "0xEE7960", Offset = "0xEE7960", VA = "0xEE7960")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0xEE796C", Offset = "0xEE796C", VA = "0xEE796C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0xEE7A84", Offset = "0xEE7A84", VA = "0xEE7A84")]
	public CFX_AutoStopLoopedEffect()
	{
	}
}
[Token(Token = "0x2000021")]
public class CFX_Demo_RotateCamera : MonoBehaviour
{
	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool rotating;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rotationCenter;

	[Token(Token = "0x600008A")]
	[Address(RVA = "0xEE7A94", Offset = "0xEE7A94", VA = "0xEE7A94")]
	private void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xEE7BD0", Offset = "0xEE7BD0", VA = "0xEE7BD0")]
	public CFX_Demo_RotateCamera()
	{
	}
}
[Token(Token = "0x2000022")]
public class CFX_Demo_Translate : MonoBehaviour
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 rotation;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 axis;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public bool gravity;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 dir;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xEE7C2C", Offset = "0xEE7C2C", VA = "0xEE7C2C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xEE7CCC", Offset = "0xEE7CCC", VA = "0xEE7CCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xEE7D3C", Offset = "0xEE7D3C", VA = "0xEE7D3C")]
	public CFX_Demo_Translate()
	{
	}
}
[Token(Token = "0x2000023")]
public class WFX_Demo : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class <RandomSpawnsCoroutine>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_Demo <>4__this;

		[Token(Token = "0x1700000E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xEE9E94", Offset = "0xEE9E94", VA = "0xEE9E94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xEE9EDC", Offset = "0xEE9EDC", VA = "0xEE9EDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0xEE9030", Offset = "0xEE9030", VA = "0xEE9030")]
		[DebuggerHidden]
		public <RandomSpawnsCoroutine>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0xEE9CB0", Offset = "0xEE9CB0", VA = "0xEE9CB0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0xEE9CB4", Offset = "0xEE9CB4", VA = "0xEE9CB4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0xEE9E9C", Offset = "0xEE9E9C", VA = "0xEE9E9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float cameraSpeed;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool orderedSpawns;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float step;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float range;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float order;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject walls;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject bulletholes;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject[] ParticleExamples;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int exampleIndex;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string randomSpawnsDelay;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool randomSpawns;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool slowMo;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
	private bool rotateCam;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Material wood;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Material concrete;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Material metal;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material checker;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Material woodWall;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Material concreteWall;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Material metalWall;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material checkerWall;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string groundTextureStr;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<string> groundTextures;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject m4;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject m4fps;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool rotate_m4;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xEE7DB8", Offset = "0xEE7DB8", VA = "0xEE7DB8")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xEE7F38", Offset = "0xEE7F38", VA = "0xEE7F38")]
	public GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xEE8194", Offset = "0xEE8194", VA = "0xEE8194")]
	private void SetActiveCrossVersions(GameObject obj, bool active)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xEE8238", Offset = "0xEE8238", VA = "0xEE8238")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xEE8FBC", Offset = "0xEE8FBC", VA = "0xEE8FBC")]
	[IteratorStateMachine(typeof(<RandomSpawnsCoroutine>d__30))]
	private IEnumerator RandomSpawnsCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xEE9058", Offset = "0xEE9058", VA = "0xEE9058")]
	private void Update()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xEE8E4C", Offset = "0xEE8E4C", VA = "0xEE8E4C")]
	private void prevTexture()
	{
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xEE8F08", Offset = "0xEE8F08", VA = "0xEE8F08")]
	private void nextTexture()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xEE91F8", Offset = "0xEE91F8", VA = "0xEE91F8")]
	private void selectMaterial()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xEE8DE4", Offset = "0xEE8DE4", VA = "0xEE8DE4")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xEE8E18", Offset = "0xEE8E18", VA = "0xEE8E18")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xEE9530", Offset = "0xEE9530", VA = "0xEE9530")]
	private void showHideStuff()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xEE9A14", Offset = "0xEE9A14", VA = "0xEE9A14")]
	public WFX_Demo()
	{
	}
}
[Token(Token = "0x2000025")]
public class WFX_Demo_DeleteAfterDelay : MonoBehaviour
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xEE9EE4", Offset = "0xEE9EE4", VA = "0xEE9EE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xEE9F84", Offset = "0xEE9F84", VA = "0xEE9F84")]
	public WFX_Demo_DeleteAfterDelay()
	{
	}
}
[Token(Token = "0x2000026")]
public class WFX_Demo_New : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <CheckForDeletedParticles>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_Demo_New <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xEEBC94", Offset = "0xEEBC94", VA = "0xEEBC94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xEEBCDC", Offset = "0xEEBCDC", VA = "0xEEBCDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xEEAE0C", Offset = "0xEEAE0C", VA = "0xEEAE0C")]
		[DebuggerHidden]
		public <CheckForDeletedParticles>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xEEBB18", Offset = "0xEEBB18", VA = "0xEEBB18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xEEBB1C", Offset = "0xEEBB1C", VA = "0xEEBB1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xEEBC9C", Offset = "0xEEBC9C", VA = "0xEEBC9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Renderer groundRenderer;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Collider groundCollider;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Space]
	[Space]
	public Image slowMoBtn;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Text slowMoLabel;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image camRotBtn;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text camRotLabel;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image groundBtn;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text groundLabel;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Space]
	public Text EffectLabel;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Text EffectIndexLabel;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject[] AdditionalEffects;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject ground;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject walls;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject bulletholes;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject m4;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject m4fps;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Material wood;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Material concrete;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material metal;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Material checker;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Material woodWall;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Material concreteWall;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Material metalWall;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Material checkerWall;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private string groundTextureStr;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private List<string> groundTextures;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private GameObject[] ParticleExamples;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private int exampleIndex;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private bool slowMo;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Vector3 defaultCamPosition;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private Quaternion defaultCamRotation;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private List<GameObject> onScreenParticles;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xEE9F94", Offset = "0xEE9F94", VA = "0xEE9F94")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xEEA2D8", Offset = "0xEEA2D8", VA = "0xEEA2D8")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xEEAB60", Offset = "0xEEAB60", VA = "0xEEAB60")]
	public void OnToggleGround()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xEEAC20", Offset = "0xEEAC20", VA = "0xEEAC20")]
	public void OnToggleCamera()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xEEACF0", Offset = "0xEEACF0", VA = "0xEEACF0")]
	public void OnToggleSlowMo()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xEEAD90", Offset = "0xEEAD90", VA = "0xEEAD90")]
	public void OnPreviousEffect()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xEEAD94", Offset = "0xEEAD94", VA = "0xEEAD94")]
	public void OnNextEffect()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xEEA1AC", Offset = "0xEEA1AC", VA = "0xEEA1AC")]
	private void UpdateUI()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xEEA770", Offset = "0xEEA770", VA = "0xEEA770")]
	public GameObject spawnParticle()
	{
		return null;
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xEEAD98", Offset = "0xEEAD98", VA = "0xEEAD98")]
	[IteratorStateMachine(typeof(<CheckForDeletedParticles>d__41))]
	private IEnumerator CheckForDeletedParticles()
	{
		return null;
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xEEA5B8", Offset = "0xEEA5B8", VA = "0xEEA5B8")]
	private void prevParticle()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xEEA5FC", Offset = "0xEEA5FC", VA = "0xEEA5FC")]
	private void nextParticle()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xEEA640", Offset = "0xEEA640", VA = "0xEEA640")]
	private void destroyParticles()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0xEEB3A8", Offset = "0xEEB3A8", VA = "0xEEB3A8")]
	private void prevTexture()
	{
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0xEEB7CC", Offset = "0xEEB7CC", VA = "0xEEB7CC")]
	private void nextTexture()
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0xEEB464", Offset = "0xEEB464", VA = "0xEEB464")]
	private void selectMaterial()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0xEEAE34", Offset = "0xEEAE34", VA = "0xEEAE34")]
	private void showHideStuff()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0xEEB880", Offset = "0xEEB880", VA = "0xEEB880")]
	public WFX_Demo_New()
	{
	}
}
[Token(Token = "0x2000028")]
public class WFX_Demo_RandomDir : MonoBehaviour
{
	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 min;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 max;

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0xEEBCE4", Offset = "0xEEBCE4", VA = "0xEEBCE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0xEEBD6C", Offset = "0xEEBD6C", VA = "0xEEBD6C")]
	public WFX_Demo_RandomDir()
	{
	}
}
[Token(Token = "0x2000029")]
public class WFX_Demo_Wall : MonoBehaviour
{
	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public WFX_Demo_New demo;

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0xEEBD84", Offset = "0xEEBD84", VA = "0xEEBD84")]
	private void OnMouseDown()
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0xEEBF28", Offset = "0xEEBF28", VA = "0xEEBF28")]
	public WFX_Demo_Wall()
	{
	}
}
[Token(Token = "0x200002A")]
[RequireComponent(typeof(ParticleSystem))]
public class CFX_AutoDestructShuriken : MonoBehaviour
{
	[Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class <CheckIfAlive>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CFX_AutoDestructShuriken <>4__this;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem <ps>5__2;

		[Token(Token = "0x17000012")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xEEC1C8", Offset = "0xEEC1C8", VA = "0xEEC1C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xEEC210", Offset = "0xEEC210", VA = "0xEEC210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xEEBFF0", Offset = "0xEEBFF0", VA = "0xEEBFF0")]
		[DebuggerHidden]
		public <CheckIfAlive>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xEEC020", Offset = "0xEEC020", VA = "0xEEC020", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xEEC024", Offset = "0xEEC024", VA = "0xEEC024", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xEEC1D0", Offset = "0xEEC1D0", VA = "0xEEC1D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool OnlyDeactivate;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool CallEvent;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnDestruct;

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0xEEBF30", Offset = "0xEEBF30", VA = "0xEEBF30")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0xEEBF7C", Offset = "0xEEBF7C", VA = "0xEEBF7C")]
	[IteratorStateMachine(typeof(<CheckIfAlive>d__4))]
	private IEnumerator CheckIfAlive()
	{
		return null;
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0xEEC018", Offset = "0xEEC018", VA = "0xEEC018")]
	public CFX_AutoDestructShuriken()
	{
	}
}
[Token(Token = "0x200002C")]
[RequireComponent(typeof(Light))]
public class CFX_LightIntensityFade : MonoBehaviour
{
	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float duration;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float delay;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float finalIntensity;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float baseIntensity;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool autodestruct;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float p_lifetime;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float p_delay;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xEEC218", Offset = "0xEEC218", VA = "0xEEC218")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xEEC278", Offset = "0xEEC278", VA = "0xEEC278")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xEEC2F4", Offset = "0xEEC2F4", VA = "0xEEC2F4")]
	private void Update()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xEEC458", Offset = "0xEEC458", VA = "0xEEC458")]
	public CFX_LightIntensityFade()
	{
	}
}
[Token(Token = "0x200002D")]
[RequireComponent(typeof(MeshFilter))]
public class WFX_BulletHoleDecal : MonoBehaviour
{
	[Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class <holeUpdate>d__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_BulletHoleDecal <>4__this;

		[Token(Token = "0x17000014")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xEECAF8", Offset = "0xEECAF8", VA = "0xEECAF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xEECB40", Offset = "0xEECB40", VA = "0xEECB40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0xEEC8D8", Offset = "0xEEC8D8", VA = "0xEEC8D8")]
		[DebuggerHidden]
		public <holeUpdate>d__12(int <>1__state)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0xEEC9D8", Offset = "0xEEC9D8", VA = "0xEEC9D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0xEEC9DC", Offset = "0xEEC9DC", VA = "0xEEC9DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0xEECB00", Offset = "0xEECB00", VA = "0xEECB00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Vector2[] quadUVs;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifetime;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float fadeoutpercent;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 frames;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool randomRotation;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool deactivate;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float life;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float fadeout;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Color color;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float orgAlpha;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xEEC468", Offset = "0xEEC468", VA = "0xEEC468")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xEEC524", Offset = "0xEEC524", VA = "0xEEC524")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xEEC864", Offset = "0xEEC864", VA = "0xEEC864")]
	[IteratorStateMachine(typeof(<holeUpdate>d__12))]
	private IEnumerator holeUpdate()
	{
		return null;
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xEEC900", Offset = "0xEEC900", VA = "0xEEC900")]
	public WFX_BulletHoleDecal()
	{
	}
}
[Token(Token = "0x200002F")]
[RequireComponent(typeof(Light))]
public class WFX_LightFlicker : MonoBehaviour
{
	[Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class <Flicker>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WFX_LightFlicker <>4__this;

		[Token(Token = "0x17000016")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xEECD54", Offset = "0xEECD54", VA = "0xEECD54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000017")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xEECD9C", Offset = "0xEECD9C", VA = "0xEECD9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0xEECC10", Offset = "0xEECC10", VA = "0xEECC10")]
		[DebuggerHidden]
		public <Flicker>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0xEECC4C", Offset = "0xEECC4C", VA = "0xEECC4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0xEECC50", Offset = "0xEECC50", VA = "0xEECC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0xEECD5C", Offset = "0xEECD5C", VA = "0xEECD5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float time;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xEECB48", Offset = "0xEECB48", VA = "0xEECB48")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xEECB9C", Offset = "0xEECB9C", VA = "0xEECB9C")]
	[IteratorStateMachine(typeof(<Flicker>d__3))]
	private IEnumerator Flicker()
	{
		return null;
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xEECC38", Offset = "0xEECC38", VA = "0xEECC38")]
	public WFX_LightFlicker()
	{
	}
}
[Token(Token = "0x2000031")]
public class CFX_SpawnSystem : MonoBehaviour
{
	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static CFX_SpawnSystem instance;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] objectsToPreload;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int[] objectsToPreloadTimes;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool hideObjectsInHierarchy;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool spawnAsChildren;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool onlyGetInactiveObjects;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	public bool instantiateIfNeeded;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool allObjectsLoaded;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<int, List<GameObject>> instantiatedObjects;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<int, int> poolCursors;

	[Token(Token = "0x17000018")]
	public static bool AllObjectsLoaded
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xEEDD34", Offset = "0xEEDD34", VA = "0xEEDD34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xEECDA4", Offset = "0xEECDA4", VA = "0xEECDA4")]
	public static GameObject GetNextObject(GameObject sourceObj, bool activateObject = true)
	{
		return null;
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0xEED524", Offset = "0xEED524", VA = "0xEED524")]
	public static void PreloadObject(GameObject sourceObj, int poolSize = 1)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0xEED8D0", Offset = "0xEED8D0", VA = "0xEED8D0")]
	public static void UnloadObjects(GameObject sourceObj)
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0xEED58C", Offset = "0xEED58C", VA = "0xEED58C")]
	private void addObjectToPool(GameObject sourceObject, int number)
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0xEED928", Offset = "0xEED928", VA = "0xEED928")]
	private void removeObjectsFromPool(GameObject sourceObject)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0xEED3C4", Offset = "0xEED3C4", VA = "0xEED3C4")]
	private void increasePoolCursor(int uniqueId)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0xEEDD88", Offset = "0xEEDD88", VA = "0xEEDD88")]
	private void Awake()
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0xEEDE88", Offset = "0xEEDE88", VA = "0xEEDE88")]
	private void Start()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0xEEDF08", Offset = "0xEEDF08", VA = "0xEEDF08")]
	public CFX_SpawnSystem()
	{
	}
}
[Token(Token = "0x2000032")]
public class BakeTexturesAtRuntime : MonoBehaviour
{
	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject target;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float elapsedTime;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_TextureCombiner.CreateAtlasesCoroutineResult result;

	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xEEE054", Offset = "0xEEE054", VA = "0xEEE054")]
	public string GetShaderNameForPipeline()
	{
		return null;
	}

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0xEEE0E0", Offset = "0xEEE0E0", VA = "0xEEE0E0")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0xEEE5E8", Offset = "0xEEE5E8", VA = "0xEEE5E8")]
	private void OnBuiltAtlasesSuccess()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0xEEE7DC", Offset = "0xEEE7DC", VA = "0xEEE7DC")]
	public BakeTexturesAtRuntime()
	{
	}
}
[Token(Token = "0x2000033")]
public class MB_BatchPrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0xEEE850", Offset = "0xEEE850", VA = "0xEEE850")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0xEEE8E8", Offset = "0xEEE8E8", VA = "0xEEE8E8")]
	public MB_BatchPrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000034")]
public class MB_SwapShirts : MonoBehaviour
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Renderer[] clothingAndBodyPartsBareTorso;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Renderer[] clothingAndBodyPartsBareTorsoDamagedArm;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Renderer[] clothingAndBodyPartsHoodie;

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0xEEE8F0", Offset = "0xEEE8F0", VA = "0xEEE8F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0xEEEA44", Offset = "0xEEEA44", VA = "0xEEEA44")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0xEEEBDC", Offset = "0xEEEBDC", VA = "0xEEEBDC")]
	private void ChangeOutfit(Renderer[] outfit)
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xEEF214", Offset = "0xEEF214", VA = "0xEEF214")]
	public MB_SwapShirts()
	{
	}
}
[Token(Token = "0x2000035")]
public class MB_PrepareObjectsForDynamicBatchingDescription : MonoBehaviour
{
	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xEEF21C", Offset = "0xEEF21C", VA = "0xEEF21C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xEEF2B4", Offset = "0xEEF2B4", VA = "0xEEF2B4")]
	public MB_PrepareObjectsForDynamicBatchingDescription()
	{
	}
}
[Token(Token = "0x2000036")]
public class MB_DynamicAddDeleteExample : MonoBehaviour
{
	[Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class <largeNumber>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB_DynamicAddDeleteExample <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000100")]
			[Address(RVA = "0xEEFAD4", Offset = "0xEEFAD4", VA = "0xEEFAD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000102")]
			[Address(RVA = "0xEEFB1C", Offset = "0xEEFB1C", VA = "0xEEFB1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xEEF818", Offset = "0xEEF818", VA = "0xEEF818")]
		[DebuggerHidden]
		public <largeNumber>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xEEF960", Offset = "0xEEF960", VA = "0xEEF960", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xEEF964", Offset = "0xEEF964", VA = "0xEEF964", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xEEFADC", Offset = "0xEEFADC", VA = "0xEEFADC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject prefab;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> objsInCombined;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MB3_MultiMeshBaker mbd;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] objs;

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xEEF2BC", Offset = "0xEEF2BC", VA = "0xEEF2BC")]
	private float GaussianValue()
	{
		return default(float);
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xEEF340", Offset = "0xEEF340", VA = "0xEEF340")]
	private void Start()
	{
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xEEF7A4", Offset = "0xEEF7A4", VA = "0xEEF7A4")]
	[IteratorStateMachine(typeof(<largeNumber>d__6))]
	private IEnumerator largeNumber()
	{
		return null;
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xEEF840", Offset = "0xEEF840", VA = "0xEEF840")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xEEF8D8", Offset = "0xEEF8D8", VA = "0xEEF8D8")]
	public MB_DynamicAddDeleteExample()
	{
	}
}
[Token(Token = "0x2000038")]
public class MB_Example : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objsToCombine;

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xEEFB24", Offset = "0xEEFB24", VA = "0xEEFB24")]
	private void Start()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xEEFB74", Offset = "0xEEFB74", VA = "0xEEFB74")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xEEFBF4", Offset = "0xEEFBF4", VA = "0xEEFBF4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xEEFC8C", Offset = "0xEEFC8C", VA = "0xEEFC8C")]
	public MB_Example()
	{
	}
}
[Token(Token = "0x2000039")]
public class MB_ExampleMover : MonoBehaviour
{
	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int axis;

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xEEFC94", Offset = "0xEEFC94", VA = "0xEEFC94")]
	private void Update()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xEEFDC4", Offset = "0xEEFDC4", VA = "0xEEFDC4")]
	public MB_ExampleMover()
	{
	}
}
[Token(Token = "0x200003A")]
public class MB_ExampleSkinnedMeshDescription : MonoBehaviour
{
	[Token(Token = "0x6000109")]
	[Address(RVA = "0xEEFDCC", Offset = "0xEEFDCC", VA = "0xEEFDCC")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xEEFE64", Offset = "0xEEFE64", VA = "0xEEFE64")]
	public MB_ExampleSkinnedMeshDescription()
	{
	}
}
[Token(Token = "0x200003B")]
[ExecuteInEditMode]
public class MB_MigrateMaterialsToDifferentPipeline : MonoBehaviour
{
	[Token(Token = "0x600010B")]
	[Address(RVA = "0xEEFE6C", Offset = "0xEEFE6C", VA = "0xEEFE6C")]
	public MB_MigrateMaterialsToDifferentPipeline()
	{
	}
}
[Token(Token = "0x200003C")]
public class MB_SkinnedMeshSceneController : MonoBehaviour
{
	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject swordPrefab;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject hatPrefab;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject glassesPrefab;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject workerPrefab;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject targetCharacter;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MB3_MeshBaker skinnedMeshBaker;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject swordInstance;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject glassesInstance;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject hatInstance;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xEEFE74", Offset = "0xEEFE74", VA = "0xEEFE74")]
	private void Start()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xEF0068", Offset = "0xEF0068", VA = "0xEF0068")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xEF0DD4", Offset = "0xEF0DD4", VA = "0xEF0DD4")]
	public Transform SearchHierarchyForBone(Transform current, string name)
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xEF0EE0", Offset = "0xEF0EE0", VA = "0xEF0EE0")]
	public MB_SkinnedMeshSceneController()
	{
	}
}
[Token(Token = "0x200003D")]
public class MB_SwitchBakedObjectsTexture : MonoBehaviour
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer targetRenderer;

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Material[] materials;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xEF0EE8", Offset = "0xEF0EE8", VA = "0xEF0EE8")]
	public void OnGUI()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xEF0F80", Offset = "0xEF0F80", VA = "0xEF0F80")]
	public void Start()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0xEF1020", Offset = "0xEF1020", VA = "0xEF1020")]
	public void Update()
	{
	}

	[Token(Token = "0x6000113")]
	[Address(RVA = "0xEF12BC", Offset = "0xEF12BC", VA = "0xEF12BC")]
	public MB_SwitchBakedObjectsTexture()
	{
	}
}
[Token(Token = "0x200003E")]
public class Movement : MonoBehaviour
{
	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 movementVector;

	[Token(Token = "0x6000114")]
	[Address(RVA = "0xEF12C4", Offset = "0xEF12C4", VA = "0xEF12C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0xEF134C", Offset = "0xEF134C", VA = "0xEF134C")]
	public Movement()
	{
	}
}
[Token(Token = "0x200003F")]
[ExecuteInEditMode]
public class MobilePostProcessing : MonoBehaviour
{
	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Blur;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	public float BlurAmount;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D BlurMask;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Bloom;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Color BloomColor;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Range(0f, 5f)]
	public float BloomAmount;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(0f, 1f)]
	public float BloomDiffuse;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Range(0f, 1f)]
	public float BloomThreshold;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0f, 1f)]
	public float BloomSoftness;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public bool LUT;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Range(0f, 1f)]
	public float LutAmount;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Texture2D SourceLut;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool ImageFiltering;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Color Color;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Range(0f, 1f)]
	public float Contrast;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Range(-1f, 1f)]
	public float Brightness;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Range(-1f, 1f)]
	public float Saturation;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Range(-1f, 1f)]
	public float Exposure;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[Range(-1f, 1f)]
	public float Gamma;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Range(0f, 1f)]
	public float Sharpness;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public bool ChromaticAberration;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float Offset;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	[Range(-1f, 1f)]
	public float FishEyeDistortion;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Range(0f, 1f)]
	public float GlitchAmount;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool Distortion;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Range(0f, 1f)]
	public float LensDistortion;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public bool Vignette;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Color VignetteColor;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Range(0f, 1f)]
	public float VignetteAmount;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[Range(0.001f, 1f)]
	public float VignetteSoftness;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int blurTexString;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int maskTextureString;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly int blurAmountString;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static readonly int bloomColorString;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly int blDiffuseString;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	private static readonly int blDataString;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int lutTextureString;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int lutAmountString;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int colorString;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly int contrastString;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly int brightnessString;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static readonly int saturationString;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly int centralFactorString;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private static readonly int sideFactorString;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly int offsetString;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private static readonly int fishEyeString;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly int lensdistortionString;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static readonly int vignetteColorString;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static readonly int vignetteAmountString;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static readonly int vignetteSoftnessString;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static readonly string bloomKeyword;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static readonly string blurKeyword;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private static readonly string chromaKeyword;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private static readonly string lutKeyword;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private static readonly string filterKeyword;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private static readonly string shaprenKeyword;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private static readonly string distortionKeyword;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Material material;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Texture2D previous;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Texture3D converted3D;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private float t;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private float a;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float knee;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int numberOfPasses;

	[Token(Token = "0x6000116")]
	[Address(RVA = "0xEF1354", Offset = "0xEF1354", VA = "0xEF1354")]
	public void Start()
	{
	}

	[Token(Token = "0x6000117")]
	[Address(RVA = "0xEF1418", Offset = "0xEF1418", VA = "0xEF1418")]
	public void Update()
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0xEF16AC", Offset = "0xEF16AC", VA = "0xEF16AC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0xEF14B8", Offset = "0xEF14B8", VA = "0xEF14B8")]
	private void Convert3D(Texture2D temp3DTex)
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0xEF1740", Offset = "0xEF1740", VA = "0xEF1740")]
	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0xEF25D0", Offset = "0xEF25D0", VA = "0xEF25D0")]
	public MobilePostProcessing()
	{
	}
}
[Token(Token = "0x2000040")]
[ExecuteInEditMode]
public class EditValues : MonoBehaviour
{
	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Blur;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	public float BlurAmount;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool Bloom;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color BloomColor;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[Range(0f, 5f)]
	public float BloomAmount;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	public float BloomDiffuse;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[Range(0f, 1f)]
	public float BloomThreshold;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Range(0f, 1f)]
	public float BloomSoftness;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool LUT;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0f, 1f)]
	public float LutAmount;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Texture2D SourceLut;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool ImageFiltering;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public Color Color;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[Range(0f, 1f)]
	public float Contrast;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Range(-1f, 1f)]
	public float Brightness;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[Range(-1f, 1f)]
	public float Saturation;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Range(-1f, 1f)]
	public float Exposure;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Range(-1f, 1f)]
	public float Gamma;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Range(0f, 1f)]
	public float Sharpness;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public bool ChromaticAberration;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float Offset;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[Range(-1f, 1f)]
	public float FishEyeDistortion;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Range(0f, 1f)]
	public float GlitchAmount;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public bool Distortion;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Range(0f, 1f)]
	public float LensDistortion;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public bool Vignette;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Color VignetteColor;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Range(0f, 1f)]
	public float VignetteAmount;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	[Range(0.001f, 1f)]
	public float VignetteSoftness;

	[Token(Token = "0x600011D")]
	[Address(RVA = "0xEF2AF0", Offset = "0xEF2AF0", VA = "0xEF2AF0")]
	private void Update()
	{
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0xEF2E10", Offset = "0xEF2E10", VA = "0xEF2E10")]
	public EditValues()
	{
	}
}
[Token(Token = "0x2000041")]
public class OculusSpatializerFMOD : MonoBehaviour
{
	[Token(Token = "0x2000042")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioRaycastCallback _raycastCallback;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float particleSize;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float particleOffset;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject room;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] dims;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] coefs;

	[Token(Token = "0x4000196")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] points;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3[] normals;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem sys;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x400019C")]
	private const string strOSP = "OculusSpatializerFMOD";

	[Token(Token = "0x600011F")]
	[Address(RVA = "0xEF2E4C", Offset = "0xEF2E4C", VA = "0xEF2E4C")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0xEF2E54", Offset = "0xEF2E54", VA = "0xEF2E54")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0xEF2FE4", Offset = "0xEF2FE4", VA = "0xEF2FE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0xEF3138", Offset = "0xEF3138", VA = "0xEF3138")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0xEF3230", Offset = "0xEF3230", VA = "0xEF3230")]
	private void Update()
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0xEF3B9C", Offset = "0xEF3B9C", VA = "0xEF3B9C")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000125")]
	[Address(RVA = "0xEF31AC", Offset = "0xEF31AC", VA = "0xEF31AC")]
	private static extern int OSP_FMOD_AssignRayCastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000126")]
	[Address(RVA = "0xEF3930", Offset = "0xEF3930", VA = "0xEF3930")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000127")]
	[Address(RVA = "0xEF39AC", Offset = "0xEF39AC", VA = "0xEF39AC")]
	private static extern int OSP_FMOD_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000128")]
	[Address(RVA = "0xEF3A28", Offset = "0xEF3A28", VA = "0xEF3A28")]
	private static extern int OSP_FMOD_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x6000129")]
	[Address(RVA = "0xEF3AA4", Offset = "0xEF3AA4", VA = "0xEF3AA4")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x600012A")]
	[Address(RVA = "0xEF3B20", Offset = "0xEF3B20", VA = "0xEF3B20")]
	private static extern int OSP_FMOD_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x600012B")]
	[Address(RVA = "0xEF4924", Offset = "0xEF4924", VA = "0xEF4924")]
	private static extern int OSP_FMOD_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x600012C")]
	[Address(RVA = "0xEF49C8", Offset = "0xEF49C8", VA = "0xEF49C8")]
	private static extern int OSP_FMOD_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x600012D")]
	[Address(RVA = "0xEF4A6C", Offset = "0xEF4A6C", VA = "0xEF4A6C")]
	public OculusSpatializerFMOD()
	{
	}
}
[Token(Token = "0x2000043")]
[DisallowMultipleComponent]
public class Outline : MonoBehaviour
{
	[Token(Token = "0x2000044")]
	public enum Mode
	{
		[Token(Token = "0x40001A9")]
		OutlineAll,
		[Token(Token = "0x40001AA")]
		OutlineVisible,
		[Token(Token = "0x40001AB")]
		OutlineHidden,
		[Token(Token = "0x40001AC")]
		OutlineAndSilhouette,
		[Token(Token = "0x40001AD")]
		SilhouetteOnly
	}

	[Serializable]
	[Token(Token = "0x2000045")]
	private class ListVector3
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Vector3> data;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xEF66FC", Offset = "0xEF66FC", VA = "0xEF66FC")]
		public ListVector3()
		{
		}
	}

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static HashSet<Mesh> registeredMeshes;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Mode outlineMode;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Color outlineColor;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[Range(0f, 50f)]
	[SerializeField]
	private float outlineWidth;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("Precompute enabled: Per-vertex calculations are performed in the editor and serialized with the object. Precompute disabled: Per-vertex calculations are performed at runtime in Awake(). This may cause a pause for large meshes.")]
	[SerializeField]
	[Header("Optional")]
	private bool precomputeOutline;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private List<Mesh> bakeKeys;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private List<ListVector3> bakeValues;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Renderer[] renderers;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Material outlineMaskMaterial;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material outlineFillMaterial;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool needsUpdate;

	[Token(Token = "0x1700001B")]
	public Mode OutlineMode
	{
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xEF4DA8", Offset = "0xEF4DA8", VA = "0xEF4DA8")]
		get
		{
			return default(Mode);
		}
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xEF4DB0", Offset = "0xEF4DB0", VA = "0xEF4DB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public Color OutlineColor
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0xEF4DC0", Offset = "0xEF4DC0", VA = "0xEF4DC0")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xEF4DCC", Offset = "0xEF4DCC", VA = "0xEF4DCC")]
		set
		{
		}
	}

	[Token(Token = "0x1700001D")]
	public float OutlineWidth
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0xEF4DE0", Offset = "0xEF4DE0", VA = "0xEF4DE0")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xEF4DE8", Offset = "0xEF4DE8", VA = "0xEF4DE8")]
		set
		{
		}
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xEF4DF8", Offset = "0xEF4DF8", VA = "0xEF4DF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xEF5308", Offset = "0xEF5308", VA = "0xEF5308")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xEF54BC", Offset = "0xEF54BC", VA = "0xEF54BC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xEF584C", Offset = "0xEF584C", VA = "0xEF584C")]
	private void Update()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xEF5A0C", Offset = "0xEF5A0C", VA = "0xEF5A0C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xEF5B24", Offset = "0xEF5B24", VA = "0xEF5B24")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xEF55D4", Offset = "0xEF55D4", VA = "0xEF55D4")]
	private void Bake()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xEF4F98", Offset = "0xEF4F98", VA = "0xEF4F98")]
	private void LoadSmoothNormals()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xEF5B8C", Offset = "0xEF5B8C", VA = "0xEF5B8C")]
	private List<Vector3> SmoothNormals(Mesh mesh)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xEF6704", Offset = "0xEF6704", VA = "0xEF6704")]
	private void CombineSubmeshes(Mesh mesh, Material[] materials)
	{
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xEF5860", Offset = "0xEF5860", VA = "0xEF5860")]
	private void UpdateMaterialProperties()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xEF67AC", Offset = "0xEF67AC", VA = "0xEF67AC")]
	public Outline()
	{
	}
}
[Token(Token = "0x2000047")]
public struct CustomDeviceState : IInputStateTypeInfo
{
	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[InputControl(name = "thirdButton", layout = "Button", bit = 2u, displayName = "Third Button")]
	[InputControl(name = "secondButton", layout = "Button", bit = 1u, displayName = "Second Button")]
	[InputControl(name = "firstButton", layout = "Button", bit = 0u, displayName = "First Button")]
	public ushort buttons;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	[InputControl(name = "stick/x", defaultState = 127, format = "BYTE", offset = 0u, parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "stick", format = "VC2B", layout = "Stick", displayName = "Main Stick")]
	public byte x;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	[InputControl(name = "stick/y", defaultState = 127, format = "BYTE", offset = 1u, parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "stick/up", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=2,clampMin=0,clampMax=1")]
	[InputControl(name = "stick/down", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=2,clampMin=-1,clampMax=0,invert")]
	[InputControl(name = "stick/left", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=2,clampMin=-1,clampMax=0,invert")]
	[InputControl(name = "stick/right", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=2,clampMin=0,clampMax=1")]
	public byte y;

	[Token(Token = "0x1700001E")]
	public FourCC format
	{
		[Token(Token = "0x600014B")]
		[Address(RVA = "0xEF6A84", Offset = "0xEF6A84", VA = "0xEF6A84", Slot = "4")]
		get
		{
			return default(FourCC);
		}
	}
}
[Token(Token = "0x2000048")]
[InputControlLayout(stateType = typeof(CustomDeviceState))]
public class CustomDevice : InputDevice, IInputUpdateCallbackReceiver
{
	[Token(Token = "0x1700001F")]
	public ButtonControl firstButton
	{
		[Token(Token = "0x600014D")]
		[Address(RVA = "0xEF6B88", Offset = "0xEF6B88", VA = "0xEF6B88")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600014E")]
		[Address(RVA = "0xEF6B90", Offset = "0xEF6B90", VA = "0xEF6B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000020")]
	public ButtonControl secondButton
	{
		[Token(Token = "0x600014F")]
		[Address(RVA = "0xEF6BA0", Offset = "0xEF6BA0", VA = "0xEF6BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xEF6BA8", Offset = "0xEF6BA8", VA = "0xEF6BA8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000021")]
	public ButtonControl thirdButton
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0xEF6BB8", Offset = "0xEF6BB8", VA = "0xEF6BB8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xEF6BC0", Offset = "0xEF6BC0", VA = "0xEF6BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000022")]
	public StickControl stick
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xEF6BD0", Offset = "0xEF6BD0", VA = "0xEF6BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000154")]
		[Address(RVA = "0xEF6BD8", Offset = "0xEF6BD8", VA = "0xEF6BD8")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000023")]
	public static CustomDevice current
	{
		[Token(Token = "0x6000156")]
		[Address(RVA = "0xEF6D2C", Offset = "0xEF6D2C", VA = "0xEF6D2C")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000157")]
		[Address(RVA = "0xEF6D74", Offset = "0xEF6D74", VA = "0xEF6D74")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0xEF6AB4", Offset = "0xEF6AB4", VA = "0xEF6AB4")]
	[RuntimeInitializeOnLoadMethod]
	private static void Initialize()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xEF6BE8", Offset = "0xEF6BE8", VA = "0xEF6BE8", Slot = "13")]
	protected override void FinishSetup()
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xEF6DCC", Offset = "0xEF6DCC", VA = "0xEF6DCC", Slot = "17")]
	public override void MakeCurrent()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xEF6E2C", Offset = "0xEF6E2C", VA = "0xEF6E2C", Slot = "19")]
	protected override void OnRemoved()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xEF6EC8", Offset = "0xEF6EC8", VA = "0xEF6EC8", Slot = "22")]
	public void OnUpdate()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xEF70B4", Offset = "0xEF70B4", VA = "0xEF70B4")]
	public CustomDevice()
	{
	}
}
[Token(Token = "0x2000049")]
internal class SimpleNativePlugin : MonoBehaviour
{
	[Token(Token = "0x200004A")]
	private struct ReturnedStructure
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int number;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr _text;

		[Token(Token = "0x17000024")]
		public string text
		{
			[Token(Token = "0x6000166")]
			[Address(RVA = "0xEF78EC", Offset = "0xEF78EC", VA = "0xEF78EC")]
			get
			{
				return null;
			}
		}
	}

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private string infoText;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int infoCount;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ReturnedStructure returnedStructure;

	[PreserveSig]
	[Token(Token = "0x600015C")]
	[Address(RVA = "0xEF70BC", Offset = "0xEF70BC", VA = "0xEF70BC")]
	private static extern int GetInteger();

	[PreserveSig]
	[Token(Token = "0x600015D")]
	[Address(RVA = "0xEF7124", Offset = "0xEF7124", VA = "0xEF7124")]
	private static extern IntPtr GetString();

	[PreserveSig]
	[Token(Token = "0x600015E")]
	[Address(RVA = "0xEF718C", Offset = "0xEF718C", VA = "0xEF718C")]
	private static extern int AddTwoIntegers(int i1, int i2);

	[PreserveSig]
	[Token(Token = "0x600015F")]
	[Address(RVA = "0xEF7210", Offset = "0xEF7210", VA = "0xEF7210")]
	private static extern float AddTwoFloats(float f1, float f2);

	[PreserveSig]
	[Token(Token = "0x6000160")]
	[Address(RVA = "0xEF7290", Offset = "0xEF7290", VA = "0xEF7290")]
	private static extern bool ReturnAStructure(out ReturnedStructure data);

	[Token(Token = "0x6000161")]
	[Address(RVA = "0xEF7314", Offset = "0xEF7314", VA = "0xEF7314")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000162")]
	[Address(RVA = "0xEF7414", Offset = "0xEF7414", VA = "0xEF7414")]
	private void Update()
	{
	}

	[Token(Token = "0x6000163")]
	[Address(RVA = "0xEF7424", Offset = "0xEF7424", VA = "0xEF7424")]
	private void Start()
	{
	}

	[Token(Token = "0x6000164")]
	[Address(RVA = "0xEF77D0", Offset = "0xEF77D0", VA = "0xEF77D0")]
	public static string StringFromNativeAscii(IntPtr nativeUtf8)
	{
		return null;
	}

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xEF7948", Offset = "0xEF7948", VA = "0xEF7948")]
	public SimpleNativePlugin()
	{
	}
}
[Token(Token = "0x200004B")]
public class ExampleWriteFilesRequest : FileOps.FileOperationRequest
{
	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string myTestData;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string myOtherTestData;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public byte[] largeData;

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xEF7950", Offset = "0xEF7950", VA = "0xEF7950", Slot = "7")]
	public override void DoFileOperations(Mounting.MountPoint mp, FileOps.FileOperationResponse response)
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xEF7D94", Offset = "0xEF7D94", VA = "0xEF7D94")]
	public ExampleWriteFilesRequest()
	{
	}
}
[Token(Token = "0x200004C")]
public class ExampleWriteFilesResponse : FileOps.FileOperationResponse
{
	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public DateTime lastWriteTime;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public long totalFileSizeWritten;

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xEF7E48", Offset = "0xEF7E48", VA = "0xEF7E48")]
	public ExampleWriteFilesResponse()
	{
	}
}
[Token(Token = "0x200004D")]
public class ExampleEnumerateFilesRequest : FileOps.FileOperationRequest
{
	[Token(Token = "0x600016A")]
	[Address(RVA = "0xEF7E50", Offset = "0xEF7E50", VA = "0xEF7E50", Slot = "7")]
	public override void DoFileOperations(Mounting.MountPoint mp, FileOps.FileOperationResponse response)
	{
	}

	[Token(Token = "0x600016B")]
	[Address(RVA = "0xEF7F34", Offset = "0xEF7F34", VA = "0xEF7F34")]
	public ExampleEnumerateFilesRequest()
	{
	}
}
[Token(Token = "0x200004E")]
public class ExampleEnumerateFilesResponse : FileOps.FileOperationResponse
{
	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] files;

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xEF7F3C", Offset = "0xEF7F3C", VA = "0xEF7F3C")]
	public ExampleEnumerateFilesResponse()
	{
	}
}
[Token(Token = "0x200004F")]
public class ExampleReadFilesRequest : FileOps.FileOperationRequest
{
	[Token(Token = "0x600016D")]
	[Address(RVA = "0xEF7F44", Offset = "0xEF7F44", VA = "0xEF7F44", Slot = "7")]
	public override void DoFileOperations(Mounting.MountPoint mp, FileOps.FileOperationResponse response)
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0xEF8360", Offset = "0xEF8360", VA = "0xEF8360")]
	public ExampleReadFilesRequest()
	{
	}
}
[Token(Token = "0x2000050")]
public class ExampleReadFilesResponse : FileOps.FileOperationResponse
{
	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string myTestData;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string myOtherTestData;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public byte[] largeData;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xEF8368", Offset = "0xEF8368", VA = "0xEF8368")]
	public ExampleReadFilesResponse()
	{
	}
}
[Token(Token = "0x2000051")]
public class GetScreenShot : MonoBehaviour
{
	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool doScreenshot;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public byte[] screenShotBytes;

	[Token(Token = "0x17000025")]
	public bool IsWaiting
	{
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xEF8370", Offset = "0xEF8370", VA = "0xEF8370")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xEF8378", Offset = "0xEF8378", VA = "0xEF8378")]
	public void DoScreenShot()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xEF83A0", Offset = "0xEF83A0", VA = "0xEF83A0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xEF83A4", Offset = "0xEF83A4", VA = "0xEF83A4")]
	public GetScreenShot()
	{
	}
}
[Token(Token = "0x2000052")]
public static class SaveDataDirNames
{
}
[Token(Token = "0x2000053")]
public class SaveIconWithScreenShot : MonoBehaviour
{
	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool doScreenshot;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Mounting.MountPoint currentMP;

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xEF83AC", Offset = "0xEF83AC", VA = "0xEF83AC")]
	public void DoScreenShot(Mounting.MountPoint mp)
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xEF83DC", Offset = "0xEF83DC", VA = "0xEF83DC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xEF83E0", Offset = "0xEF83E0", VA = "0xEF83E0")]
	public void SaveIcon(Mounting.MountPoint mp, byte[] pngBytes)
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xEF83E4", Offset = "0xEF83E4", VA = "0xEF83E4")]
	public SaveIconWithScreenShot()
	{
	}
}
[Token(Token = "0x2000054")]
public class SpinCube : MonoBehaviour
{
	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speed;

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xEF83EC", Offset = "0xEF83EC", VA = "0xEF83EC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xEF8484", Offset = "0xEF8484", VA = "0xEF8484")]
	public SpinCube()
	{
	}
}
[Token(Token = "0x2000055")]
[RequireComponent(typeof(Rigidbody))]
public class BuoyantObject : MonoBehaviour
{
	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Color red;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color green;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color blue;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Color orange;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float steepness;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float wavelength;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float speed;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float[] directions;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("Water Object")]
	public StylizedWaterURP water;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Header("Buoyancy")]
	[Range(1f, 5f)]
	public float strength;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[Range(0.2f, 5f)]
	public float objectDepth;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float velocityDrag;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float angularDrag;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[Header("Effectors")]
	public Transform[] effectors;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Rigidbody rb;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3[] effectorProjections;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xEF8494", Offset = "0xEF8494", VA = "0xEF8494")]
	private void Awake()
	{
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xEF85F4", Offset = "0xEF85F4", VA = "0xEF85F4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xEF8614", Offset = "0xEF8614", VA = "0xEF8614")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xEF8A88", Offset = "0xEF8A88", VA = "0xEF8A88")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xEF8D60", Offset = "0xEF8D60", VA = "0xEF8D60")]
	public BuoyantObject()
	{
	}
}
[Token(Token = "0x2000056")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000057")]
	public class Section
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xEF8E08", Offset = "0xEF8E08", VA = "0xEF8E08")]
		public Section()
		{
		}
	}

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string title;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Section[] sections;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool loadedLayout;

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xEF8E00", Offset = "0xEF8E00", VA = "0xEF8E00")]
	public Readme()
	{
	}
}
namespace StylizedWater
{
	[Token(Token = "0x2000058")]
	public static class GerstnerWaveDisplacement
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0xEF8E10", Offset = "0xEF8E10", VA = "0xEF8E10")]
		private static Vector3 GerstnerWave(Vector3 position, float steepness, float wavelength, float speed, float direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0xEF88E0", Offset = "0xEF88E0", VA = "0xEF88E0")]
		public static Vector3 GetWaveDisplacement(Vector3 position, float steepness, float wavelength, float speed, float[] directions)
		{
			return default(Vector3);
		}
	}
}
namespace SaveData
{
	[Token(Token = "0x2000059")]
	public class AutoSaveProcess
	{
		[Token(Token = "0x200005A")]
		public delegate void ErrorHandler(uint errorCode);

		[Token(Token = "0x200005B")]
		private enum SaveState
		{
			[Token(Token = "0x40001E6")]
			Begin,
			[Token(Token = "0x40001E7")]
			SaveFiles,
			[Token(Token = "0x40001E8")]
			WriteIcon,
			[Token(Token = "0x40001E9")]
			WriteParams,
			[Token(Token = "0x40001EA")]
			Unmount,
			[Token(Token = "0x40001EB")]
			HandleError,
			[Token(Token = "0x40001EC")]
			LoadFiles,
			[Token(Token = "0x40001ED")]
			Exit
		}

		[Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class <StartAutoSaveProcess>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DirName autoSaveDirName;

			[Token(Token = "0x40001F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int userId;

			[Token(Token = "0x40001F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ulong newSaveDataBlocks;

			[Token(Token = "0x40001F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public FileOps.FileOperationRequest fileRequest;

			[Token(Token = "0x40001F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public FileOps.FileOperationResponse fileResponse;

			[Token(Token = "0x40001F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Dialogs.NewItem newItem;

			[Token(Token = "0x40001F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public SaveDataParams saveDataParams;

			[Token(Token = "0x40001F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public bool backup;

			[Token(Token = "0x40001F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public ErrorHandler errHandler;

			[Token(Token = "0x40001F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private SaveState <currentState>5__2;

			[Token(Token = "0x40001FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Mounting.MountResponse <mountResponse>5__3;

			[Token(Token = "0x40001FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Mounting.MountPoint <mp>5__4;

			[Token(Token = "0x40001FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int <errorCode>5__5;

			[Token(Token = "0x40001FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private EmptyResponse <iconResponse>5__6;

			[Token(Token = "0x40001FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private EmptyResponse <paramsResponse>5__7;

			[Token(Token = "0x17000026")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000191")]
				[Address(RVA = "0xEFA088", Offset = "0xEFA088", VA = "0xEFA088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000027")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000193")]
				[Address(RVA = "0xEFA0D0", Offset = "0xEFA0D0", VA = "0xEFA0D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600018E")]
			[Address(RVA = "0xEF908C", Offset = "0xEF908C", VA = "0xEF908C")]
			[DebuggerHidden]
			public <StartAutoSaveProcess>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600018F")]
			[Address(RVA = "0xEF9AB0", Offset = "0xEF9AB0", VA = "0xEF9AB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000190")]
			[Address(RVA = "0xEF9AB4", Offset = "0xEF9AB4", VA = "0xEF9AB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000192")]
			[Address(RVA = "0xEFA090", Offset = "0xEFA090", VA = "0xEFA090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <StartAutoSaveLoadProcess>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000200")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000201")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int userId;

			[Token(Token = "0x4000202")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public DirName dirName;

			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FileOps.FileOperationRequest fileRequest;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public FileOps.FileOperationResponse fileResponse;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ErrorHandler errHandler;

			[Token(Token = "0x4000206")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private SaveState <currentState>5__2;

			[Token(Token = "0x4000207")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private Mounting.MountResponse <mountResponse>5__3;

			[Token(Token = "0x4000208")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Mounting.MountPoint <mp>5__4;

			[Token(Token = "0x4000209")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <errorCode>5__5;

			[Token(Token = "0x400020A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private EmptyResponse <unmountResponse>5__6;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000197")]
				[Address(RVA = "0xEFA458", Offset = "0xEFA458", VA = "0xEFA458", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000199")]
				[Address(RVA = "0xEFA4A0", Offset = "0xEFA4A0", VA = "0xEFA4A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000194")]
			[Address(RVA = "0xEF917C", Offset = "0xEF917C", VA = "0xEF917C")]
			[DebuggerHidden]
			public <StartAutoSaveLoadProcess>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x6000195")]
			[Address(RVA = "0xEFA0D8", Offset = "0xEFA0D8", VA = "0xEFA0D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000196")]
			[Address(RVA = "0xEFA0DC", Offset = "0xEFA0DC", VA = "0xEFA0DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000198")]
			[Address(RVA = "0xEFA460", Offset = "0xEFA460", VA = "0xEFA460", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0xEF8F6C", Offset = "0xEF8F6C", VA = "0xEF8F6C")]
		[IteratorStateMachine(typeof(<StartAutoSaveProcess>d__2))]
		public static IEnumerator StartAutoSaveProcess(int userId, Dialogs.NewItem newItem, DirName autoSaveDirName, ulong newSaveDataBlocks, SaveDataParams saveDataParams, FileOps.FileOperationRequest fileRequest, FileOps.FileOperationResponse fileResponse, bool backup, ErrorHandler errHandler)
		{
			return null;
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xEF90B4", Offset = "0xEF90B4", VA = "0xEF90B4")]
		[IteratorStateMachine(typeof(<StartAutoSaveLoadProcess>d__3))]
		public static IEnumerator StartAutoSaveLoadProcess(int userId, DirName dirName, FileOps.FileOperationRequest fileRequest, FileOps.FileOperationResponse fileResponse, ErrorHandler errHandler)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xEF91A4", Offset = "0xEF91A4", VA = "0xEF91A4")]
		internal static int MountSaveData(int userId, ulong blocks, Mounting.MountResponse mountResponse, DirName dirName, Mounting.MountModeFlags flags)
		{
			return default(int);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xEF937C", Offset = "0xEF937C", VA = "0xEF937C")]
		internal static int UnmountSaveData(int userId, EmptyResponse unmountResponse, Mounting.MountPoint mp, bool backup)
		{
			return default(int);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xEF9550", Offset = "0xEF9550", VA = "0xEF9550")]
		internal static int WriteIcon(int userId, EmptyResponse iconResponse, Mounting.MountPoint mp, Dialogs.NewItem newItem)
		{
			return default(int);
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xEF9754", Offset = "0xEF9754", VA = "0xEF9754")]
		internal static int WriteParams(int userId, EmptyResponse paramsResponse, Mounting.MountPoint mp, SaveDataParams saveDataParams)
		{
			return default(int);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xEF9930", Offset = "0xEF9930", VA = "0xEF9930")]
		public AutoSaveProcess()
		{
		}
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Token(Token = "0x200005E")]
	public class PostProcessUrp : ScriptableRendererFeature
	{
		[Serializable]
		[Token(Token = "0x200005F")]
		public class PostProcessSettings
		{
			[Token(Token = "0x400020E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RenderPassEvent Event;

			[Token(Token = "0x400020F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Material blitMaterial;

			[Token(Token = "0x4000210")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool Blur;

			[Token(Token = "0x4000211")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			public float BlurAmount;

			[Token(Token = "0x4000212")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Texture2D BlurMask;

			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool Bloom;

			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Color BloomColor;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Range(0f, 5f)]
			public float BloomAmount;

			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Range(0f, 1f)]
			public float BloomDiffuse;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[Range(0f, 1f)]
			public float BloomThreshold;

			[Token(Token = "0x4000218")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Range(0f, 1f)]
			public float BloomSoftness;

			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool LUT;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			public float LutAmount;

			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Texture2D SourceLut;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public bool ImageFiltering;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Color Color;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Range(0f, 1f)]
			public float Contrast;

			[Token(Token = "0x400021F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(-1f, 1f)]
			public float Brightness;

			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(-1f, 1f)]
			public float Saturation;

			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(-1f, 1f)]
			public float Exposure;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(-1f, 1f)]
			public float Gamma;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Range(0f, 1f)]
			public float Sharpness;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			public bool ChromaticAberration;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public float Offset;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Range(-1f, 1f)]
			public float FishEyeDistortion;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Range(0f, 1f)]
			public float GlitchAmount;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public bool Distortion;

			[Token(Token = "0x4000229")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Range(0f, 1f)]
			public float LensDistortion;

			[Token(Token = "0x400022A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			public bool Vignette;

			[Token(Token = "0x400022B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Color VignetteColor;

			[Token(Token = "0x400022C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[Range(0f, 1f)]
			public float VignetteAmount;

			[Token(Token = "0x400022D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			[Range(0.001f, 1f)]
			public float VignetteSoftness;

			[Token(Token = "0x600019F")]
			[Address(RVA = "0xEFADC0", Offset = "0xEFADC0", VA = "0xEFADC0")]
			public PostProcessSettings()
			{
			}
		}

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PostProcessSettings settings;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PostProcessUrpPass ppsUrpPass;

		[Token(Token = "0x1700002A")]
		public static PostProcessUrp Instance
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0xEFA4A8", Offset = "0xEFA4A8", VA = "0xEFA4A8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0xEFA4F0", Offset = "0xEFA4F0", VA = "0xEFA4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xEFA548", Offset = "0xEFA548", VA = "0xEFA548", Slot = "5")]
		public override void Create()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xEFAC0C", Offset = "0xEFAC0C", VA = "0xEFAC0C", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xEFAD50", Offset = "0xEFAD50", VA = "0xEFAD50")]
		public PostProcessUrp()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class PostProcessUrpPass : ScriptableRenderPass
	{
		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Material material;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private RenderTargetIdentifier source;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private RenderTargetIdentifier blurTemp;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private RenderTargetIdentifier blurTemp1;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private RenderTargetIdentifier blurTex;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private RenderTargetIdentifier tempCopy;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool maskSet;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private int numberOfPasses;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private readonly string tag;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private readonly bool blur;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private readonly float blurAmount;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private readonly Texture2D blurMask;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private readonly bool bloom;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private readonly Color bloomColor;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private readonly float bloomAmount;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private readonly float bloomDiffuse;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private readonly float bloomThreshold;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private readonly float bloomSoftness;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		private readonly bool lut;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private readonly Texture2D sourceLut;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private readonly float lutAmount;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		private readonly bool imageFiltering;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private readonly Color color;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private readonly float contrast;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private readonly float brightness;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private readonly float saturation;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private readonly float exposure;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private readonly float gamma;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private readonly float sharpness;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private readonly bool chromaticAberration;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private readonly float offset;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private readonly float fishEyeDistortion;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23C")]
		private readonly float glitchAmount;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private readonly bool distortion;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x244")]
		private readonly float lensDistortion;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private readonly bool vignette;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private readonly Color vignetteColor;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private readonly float vignetteAmount;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private readonly float vignetteSoftness;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int blurTexString;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int maskTextureString;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int blurAmountString;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int bloomColorString;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly int blDiffuseString;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static readonly int blDataString;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly int lutTextureString;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private static readonly int lutAmountString;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly int colorString;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static readonly int contrastString;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly int brightnessString;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private static readonly int saturationString;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int centralFactorString;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int sideFactorString;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly int offsetString;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private static readonly int fishEyeString;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly int lensdistortionString;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private static readonly int vignetteColorString;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly int vignetteAmountString;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private static readonly int vignetteSoftnessString;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static readonly int blurTempString;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private static readonly int blurTemp1String;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly int tempCopyString;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static readonly string bloomKeyword;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly string blurKeyword;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static readonly string chromaKeyword;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly string lutKeyword;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static readonly string filterKeyword;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static readonly string shaprenKeyword;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static readonly string distortionKeyword;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private Texture2D previous;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private Texture3D converted3D;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private float t;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27C")]
		private float a;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private float knee;

		[Token(Token = "0x1700002B")]
		public FilterMode filterMode
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0xEFAE04", Offset = "0xEFAE04", VA = "0xEFAE04")]
			[CompilerGenerated]
			get
			{
				return default(FilterMode);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0xEFAE0C", Offset = "0xEFAE0C", VA = "0xEFAE0C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xEFA808", Offset = "0xEFA808", VA = "0xEFA808")]
		public PostProcessUrpPass(RenderPassEvent renderPassEvent, Material material, bool blur, float blurAmount, Texture2D blurMask, bool bloom, Color bloomColor, float bloomAmount, float bloomDiffuse, float bloomThreshold, float bloomSoftness, bool lut, float lutAmount, Texture2D sourceLut, bool imageFiltering, Color color, float contrast, float saturation, float brightness, float exposure, float gamma, float sharpness, bool chromaticAberration, float offset, float fishEyeDistortion, float glitchAmount, bool distortion, float lensDistortion, bool vignette, Color vignetteColor, float vignetteAmount, float vignetteSoftness, string tag)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xEFAE14", Offset = "0xEFAE14", VA = "0xEFAE14")]
		public void Setup(RenderTargetIdentifier source)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xEFAE30", Offset = "0xEFAE30", VA = "0xEFAE30", Slot = "9")]
		public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xEFC098", Offset = "0xEFC098", VA = "0xEFC098", Slot = "4")]
		public override void FrameCleanup(CommandBuffer cmd)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xEFC008", Offset = "0xEFC008", VA = "0xEFC008")]
		private void isConverted()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xEFC14C", Offset = "0xEFC14C", VA = "0xEFC14C")]
		private void Convert(Texture2D tempTex)
		{
		}
	}
}
namespace Tayx.Graphy.CustomizationScene
{
	[Token(Token = "0x2000061")]
	public class G_CUIColorPicker : MonoBehaviour
	{
		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider alphaSlider;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image alphaSliderBGImage;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Color _color;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Action<Color> _onValueChange;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action _update;

		[Token(Token = "0x1700002C")]
		public Color Color
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0xEFC8B0", Offset = "0xEFC8B0", VA = "0xEFC8B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0xEFC8BC", Offset = "0xEFC8BC", VA = "0xEFC8BC")]
			set
			{
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xEFD068", Offset = "0xEFD068", VA = "0xEFD068")]
		public void SetOnValueChangeCallback(Action<Color> onValueChange)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xEFD070", Offset = "0xEFD070", VA = "0xEFD070")]
		private static void RGBToHSV(Color color, out float h, out float s, out float v)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xEFD240", Offset = "0xEFD240", VA = "0xEFD240")]
		private static bool GetLocalMouse(GameObject go, out Vector2 result)
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0xEFD3DC", Offset = "0xEFD3DC", VA = "0xEFD3DC")]
		private static Vector2 GetWidgetSize(GameObject go)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xEFD470", Offset = "0xEFD470", VA = "0xEFD470")]
		private GameObject GO(string name)
		{
			return null;
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xEFC8C0", Offset = "0xEFC8C0", VA = "0xEFC8C0")]
		private void Setup(Color inputColor)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xEFD4AC", Offset = "0xEFD4AC", VA = "0xEFD4AC")]
		public void SetRandomColor()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xEFD5C8", Offset = "0xEFD5C8", VA = "0xEFD5C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xEFD5E0", Offset = "0xEFD5E0", VA = "0xEFD5E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xEFD688", Offset = "0xEFD688", VA = "0xEFD688")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xEFD6A4", Offset = "0xEFD6A4", VA = "0xEFD6A4")]
		public G_CUIColorPicker()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class CustomizeGraphy : MonoBehaviour
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Customize Graphy")]
		[SerializeField]
		private G_CUIColorPicker m_colorPicker;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Toggle m_backgroundToggle;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Dropdown m_graphyModeDropdown;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button m_backgroundColorButton;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Dropdown m_graphModulePositionDropdown;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Fps")]
		[SerializeField]
		private Dropdown m_fpsModuleStateDropdown;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private InputField m_goodInputField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InputField m_cautionInputField;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button m_goodColorButton;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Button m_cautionColorButton;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Button m_criticalColorButton;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Slider m_fpsGraphResolutionSlider;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Slider m_fpsTextUpdateRateSlider;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Header("Memory")]
		private Dropdown m_ramModuleStateDropdown;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Button m_reservedColorButton;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Button m_allocatedColorButton;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Button m_monoColorButton;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Slider m_ramGraphResolutionSlider;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Slider m_ramTextUpdateRateSlider;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Header("Audio")]
		[SerializeField]
		private Dropdown m_audioModuleStateDropdown;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Button m_audioGraphColorButton;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Dropdown m_findAudioListenerDropdown;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Dropdown m_fttWindowDropdown;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Slider m_spectrumSizeSlider;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Slider m_audioGraphResolutionSlider;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Slider m_audioTextUpdateRateSlider;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Header("Advanced")]
		[SerializeField]
		private Dropdown m_advancedModulePositionDropdown;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Toggle m_advancedModuleToggle;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Header("Other")]
		private Button m_musicButton;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Button m_sfxButton;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private Slider m_musicVolumeSlider;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private Slider m_sfxVolumeSlider;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private AudioSource m_musicAudioSource;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private AudioSource m_sfxAudioSource;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private List<AudioClip> m_sfxAudioClips;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private GraphyManager m_graphyManager;

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xEFDCE8", Offset = "0xEFDCE8", VA = "0xEFDCE8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xEFDD68", Offset = "0xEFDD68", VA = "0xEFDD68")]
		private void SetupCallbacks()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xEFEB7C", Offset = "0xEFEB7C", VA = "0xEFEB7C")]
		private void ToggleMusic()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xEFEBC4", Offset = "0xEFEBC4", VA = "0xEFEBC4")]
		private void PlayRandomSFX()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0xEFEC80", Offset = "0xEFEC80", VA = "0xEFEC80")]
		public CustomizeGraphy()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class ForceSliderToMultipleOf3 : MonoBehaviour
	{
		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0xEFFE0C", Offset = "0xEFFE0C", VA = "0xEFFE0C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0xEFFEA4", Offset = "0xEFFEA4", VA = "0xEFFEA4")]
		public ForceSliderToMultipleOf3()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class ForceSliderToPowerOf2 : MonoBehaviour
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int[] m_powerOf2Values;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_text;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0xEFFEAC", Offset = "0xEFFEAC", VA = "0xEFFEAC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0xEFFFD8", Offset = "0xEFFFD8", VA = "0xEFFFD8")]
		public ForceSliderToPowerOf2()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[RequireComponent(typeof(Text))]
	public class UpdateTextWithSliderValue : MonoBehaviour
	{
		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Slider m_slider;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Text m_text;

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0xF00068", Offset = "0xF00068", VA = "0xF00068")]
		private void Start()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0xF000C0", Offset = "0xF000C0", VA = "0xF000C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0xF00128", Offset = "0xF00128", VA = "0xF00128")]
		public UpdateTextWithSliderValue()
		{
		}
	}
}
namespace AmazingAssets.TerrainToMesh.Example
{
	[Token(Token = "0x2000067")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportDetailMesh : MonoBehaviour
	{
		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0xF00130", Offset = "0xF00130", VA = "0xF00130")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0xF00460", Offset = "0xF00460", VA = "0xF00460")]
		public ExportDetailMesh()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportGrass : MonoBehaviour
	{
		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0xF00470", Offset = "0xF00470", VA = "0xF00470")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0xF00AF0", Offset = "0xF00AF0", VA = "0xF00AF0")]
		private void BakeHealthyAndDryColorsInsideVertexColor(Mesh mesh, DetailPrototype detailPrototype)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0xF00CA0", Offset = "0xF00CA0", VA = "0xF00CA0")]
		public ExportGrass()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportMesh : MonoBehaviour
	{
		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0xF00CB0", Offset = "0xF00CB0", VA = "0xF00CB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0xF00E00", Offset = "0xF00E00", VA = "0xF00E00")]
		public ExportMesh()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportMeshAndBasemap : MonoBehaviour
	{
		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int mapsResolution;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool exportHoles;

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0xF00E10", Offset = "0xF00E10", VA = "0xF00E10")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0xF0111C", Offset = "0xF0111C", VA = "0xF0111C")]
		private void InitializeMaterial(Material material)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0xF01464", Offset = "0xF01464", VA = "0xF01464")]
		private void SetupAlphaTest(Material material)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0xF015EC", Offset = "0xF015EC", VA = "0xF015EC")]
		public ExportMeshAndBasemap()
		{
		}
	}
	[Token(Token = "0x200006B")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportMeshAndBasemapByPositionIndex : MonoBehaviour
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int mapsResolution;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool exportHoles;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int chunkCountHorizontal;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int chunkCountVertical;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 3f)]
		[Header("Chunk count is 4x4")]
		public int positionX;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int positionY;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xF01604", Offset = "0xF01604", VA = "0xF01604")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0xF01940", Offset = "0xF01940", VA = "0xF01940")]
		private void InitializeMaterial(Material material)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0xF01C88", Offset = "0xF01C88", VA = "0xF01C88")]
		private void SetupAlphaTest(Material material)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0xF01E10", Offset = "0xF01E10", VA = "0xF01E10")]
		public ExportMeshAndBasemapByPositionIndex()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportMeshAndSplatmap : MonoBehaviour
	{
		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool terrainHasHoles;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool createFallbackTextures;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0xF01E30", Offset = "0xF01E30", VA = "0xF01E30")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0xF01FE0", Offset = "0xF01FE0", VA = "0xF01FE0")]
		public ExportMeshAndSplatmap()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportMeshWithEdgeFall : MonoBehaviour
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EdgeFall edgeFall;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D edgeFallTexture;

		[Token(Token = "0x6000200")]
		[Address(RVA = "0xF01FF0", Offset = "0xF01FF0", VA = "0xF01FF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xF02244", Offset = "0xF02244", VA = "0xF02244")]
		public ExportMeshWithEdgeFall()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class ExportTrees : MonoBehaviour
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TerrainData terrainData;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int vertexCountHorizontal;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int vertexCountVertical;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xF022C8", Offset = "0xF022C8", VA = "0xF022C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xF025DC", Offset = "0xF025DC", VA = "0xF025DC")]
		public ExportTrees()
		{
		}
	}
}
