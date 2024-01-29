using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;
using UnityStandardAssets.Utility;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class CameraController : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject cameraTarget;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float rotateSpeed;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float rotate;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float offsetDistance;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float offsetHeight;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float smoothing;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 offset;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool following;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 lastPosition;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x15B35E4", Offset = "0x15B35E4", VA = "0x15B35E4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x15B377C", Offset = "0x15B377C", VA = "0x15B377C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x15B3AE4", Offset = "0x15B3AE4", VA = "0x15B3AE4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x15B3B20", Offset = "0x15B3B20", VA = "0x15B3B20")]
	public CameraController()
	{
	}
}
[Token(Token = "0x2000003")]
public class Gravity : MonoBehaviour
{
	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform planet;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x15BE3A8", Offset = "0x15BE3A8", VA = "0x15BE3A8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x15BE694", Offset = "0x15BE694", VA = "0x15BE694")]
	public Gravity()
	{
	}
}
[Token(Token = "0x2000004")]
public class SimpleStateMachine : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	public class State
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action DoUpdate;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action DoFixedUpdate;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action DoLateUpdate;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action DoManualUpdate;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action enterState;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action exitState;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Enum currentState;

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x166BE40", Offset = "0x166BE40", VA = "0x166BE40")]
		public State()
		{
		}
	}

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool DebugGui;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector2 DebugGuiPosition;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string DebugGuiTitle;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Enum queueCommand;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected float timeEnteredState;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public State state;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Enum lastState;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Dictionary<Enum, Dictionary<string, Delegate>> _cache;

	[Token(Token = "0x17000001")]
	public Enum currentState
	{
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x166BA04", Offset = "0x166BA04", VA = "0x166BA04")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x166BA20", Offset = "0x166BA20", VA = "0x166BA20")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x166B8F8", Offset = "0x166B8F8", VA = "0x166B8F8")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x166BA78", Offset = "0x166BA78", VA = "0x166BA78")]
	private void ChangingState()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x166BAB4", Offset = "0x166BAB4", VA = "0x166BAB4")]
	private void ConfigureCurrentState()
	{
	}

	[Token(Token = "0x600000C")]
	private T ConfigureDelegate<T>(string methodRoot, T Default) where T : class
	{
		return null;
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x166BCF8", Offset = "0x166BCF8", VA = "0x166BCF8")]
	private void Update()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x166BD48", Offset = "0x166BD48", VA = "0x166BD48")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x166BD70", Offset = "0x166BD70", VA = "0x166BD70")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x166BD98", Offset = "0x166BD98", VA = "0x166BD98", Slot = "4")]
	protected virtual void EarlyGlobalSuperUpdate()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x166BD9C", Offset = "0x166BD9C", VA = "0x166BD9C", Slot = "5")]
	protected virtual void LateGlobalSuperUpdate()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x166BDA0", Offset = "0x166BDA0", VA = "0x166BDA0")]
	private static void DoNothing()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x166BDA4", Offset = "0x166BDA4", VA = "0x166BDA4")]
	public SimpleStateMachine()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF654", Offset = "0xAEF654")]
public class BSPTree : MonoBehaviour
{
	[Token(Token = "0x200005F")]
	public class Node
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 partitionPoint;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 partitionNormal;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Node positiveChild;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Node negativeChild;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] triangles;

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x15B1090", Offset = "0x15B1090", VA = "0x15B1090")]
		public Node()
		{
		}
	}

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool drawMeshTreeOnStart;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int triangleCount;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int vertexCount;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] vertices;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] tris;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3[] triangleNormals;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Mesh mesh;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Node tree;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x15B004C", Offset = "0x15B004C", VA = "0x15B004C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x15B045C", Offset = "0x15B045C", VA = "0x15B045C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x15B046C", Offset = "0x15B046C", VA = "0x15B046C")]
	public Vector3 ClosestPointOn(Vector3 to, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x15B05A0", Offset = "0x15B05A0", VA = "0x15B05A0")]
	private void FindClosestTriangles(Node node, Vector3 to, float radius, List<int> triangles)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x15B06B8", Offset = "0x15B06B8", VA = "0x15B06B8")]
	private Vector3 ClosestPointOnTriangle(int[] triangles, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x15B037C", Offset = "0x15B037C", VA = "0x15B037C")]
	private void BuildTriangleTree()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x15B1098", Offset = "0x15B1098", VA = "0x15B1098")]
	private void RecursivePartition(List<int> triangles, int depth, Node parent)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x15B229C", Offset = "0x15B229C", VA = "0x15B229C")]
	private void Split(List<int> triangles, Vector3 partitionPoint, Vector3 partitionNormal, out List<int> positiveTriangles, out List<int> negativeTriangles)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x15B0A14", Offset = "0x15B0A14", VA = "0x15B0A14")]
	private bool PointAbovePlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x15B091C", Offset = "0x15B091C", VA = "0x15B091C")]
	private float PointDistanceFromPlane(Vector3 planeOrigin, Vector3 planeNormal, Vector3 point)
	{
		return default(float);
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x15B0AEC", Offset = "0x15B0AEC", VA = "0x15B0AEC")]
	public static void ClosestPointOnTriangleToPoint(ref Vector3 vertex1, ref Vector3 vertex2, ref Vector3 vertex3, ref Vector3 point, out Vector3 result)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x15B26F8", Offset = "0x15B26F8", VA = "0x15B26F8")]
	private void DrawTriangleSet(int[] triangles, Color color)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x15B2A38", Offset = "0x15B2A38", VA = "0x15B2A38")]
	public BSPTree()
	{
	}
}
[Token(Token = "0x2000006")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF6B8", Offset = "0xAEF6B8")]
public class BruteForceMesh : MonoBehaviour
{
	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int triangleCount;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3[] vertices;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] tris;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] triangleNormals;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Mesh mesh;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x15B2A40", Offset = "0x15B2A40", VA = "0x15B2A40")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x15B2D44", Offset = "0x15B2D44", VA = "0x15B2D44")]
	public Vector3 ClosestPointOn(Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x15B2DD8", Offset = "0x15B2DD8", VA = "0x15B2DD8")]
	private Vector3 ClosestPointOnTriangle(int[] triangles, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x15B3038", Offset = "0x15B3038", VA = "0x15B3038")]
	private void ClosestPointOnTriangleToPoint(ref Vector3 vertex1, ref Vector3 vertex2, ref Vector3 vertex3, ref Vector3 point, out Vector3 result)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x15B35DC", Offset = "0x15B35DC", VA = "0x15B35DC")]
	public BruteForceMesh()
	{
	}
}
[Token(Token = "0x2000007")]
public class SuperCharacterController : MonoBehaviour
{
	[Token(Token = "0x2000060")]
	[SerializeField]
	public struct Ground
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1064", Offset = "0xAF1064")]
		private RaycastHit <hit>k__BackingField;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1074", Offset = "0xAF1074")]
		private RaycastHit <nearHit>k__BackingField;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1084", Offset = "0xAF1084")]
		private RaycastHit <farHit>k__BackingField;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1094", Offset = "0xAF1094")]
		private RaycastHit <secondaryHit>k__BackingField;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10A4", Offset = "0xAF10A4")]
		private SuperCollisionType <collisionType>k__BackingField;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10B4", Offset = "0xAF10B4")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x17000020")]
		public RaycastHit hit
		{
			[Token(Token = "0x60002C0")]
			[Address(RVA = "0x166F8A0", Offset = "0x166F8A0", VA = "0x166F8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2294", Offset = "0xAF2294")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x166F8B4", Offset = "0x166F8B4", VA = "0x166F8B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22A4", Offset = "0xAF22A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000021")]
		public RaycastHit nearHit
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x166F8D0", Offset = "0x166F8D0", VA = "0x166F8D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22B4", Offset = "0xAF22B4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x166F8E8", Offset = "0x166F8E8", VA = "0x166F8E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22C4", Offset = "0xAF22C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public RaycastHit farHit
		{
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x166F908", Offset = "0x166F908", VA = "0x166F908")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22D4", Offset = "0xAF22D4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x166F920", Offset = "0x166F920", VA = "0x166F920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22E4", Offset = "0xAF22E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public RaycastHit secondaryHit
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x166F940", Offset = "0x166F940", VA = "0x166F940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF22F4", Offset = "0xAF22F4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x166F958", Offset = "0x166F958", VA = "0x166F958")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2304", Offset = "0xAF2304")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public SuperCollisionType collisionType
		{
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x166F978", Offset = "0x166F978", VA = "0x166F978")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2314", Offset = "0xAF2314")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x166F980", Offset = "0x166F980", VA = "0x166F980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2324", Offset = "0xAF2324")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Transform transform
		{
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x166F988", Offset = "0x166F988", VA = "0x166F988")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2334", Offset = "0xAF2334")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x166F990", Offset = "0x166F990", VA = "0x166F990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2344", Offset = "0xAF2344")]
			set
			{
			}
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x166F998", Offset = "0x166F998", VA = "0x166F998")]
		public Ground(RaycastHit hit, RaycastHit nearHit, RaycastHit farHit, RaycastHit secondaryHit, SuperCollisionType superCollisionType, Transform hitTransform)
		{
		}
	}

	[Token(Token = "0x2000061")]
	public delegate void UpdateDelegate();

	[Token(Token = "0x2000062")]
	protected struct IgnoredCollider
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Collider collider;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int layer;

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x166F334", Offset = "0x166F334", VA = "0x166F334")]
		public IgnoredCollider(Collider collider, int layer)
		{
		}
	}

	[Token(Token = "0x2000063")]
	public class SuperGround
	{
		[Token(Token = "0x20000E0")]
		private class GroundHit
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF116C", Offset = "0xAF116C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF117C", Offset = "0xAF117C")]
			private Vector3 <normal>k__BackingField;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF118C", Offset = "0xAF118C")]
			private float <distance>k__BackingField;

			[Token(Token = "0x17000063")]
			public Vector3 point
			{
				[Token(Token = "0x6000455")]
				[Address(RVA = "0x1670430", Offset = "0x1670430", VA = "0x1670430")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B14", Offset = "0xAF2B14")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000456")]
				[Address(RVA = "0x167043C", Offset = "0x167043C", VA = "0x167043C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B24", Offset = "0xAF2B24")]
				private set
				{
				}
			}

			[Token(Token = "0x17000064")]
			public Vector3 normal
			{
				[Token(Token = "0x6000457")]
				[Address(RVA = "0x1670448", Offset = "0x1670448", VA = "0x1670448")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B34", Offset = "0xAF2B34")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000458")]
				[Address(RVA = "0x1670454", Offset = "0x1670454", VA = "0x1670454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B44", Offset = "0xAF2B44")]
				private set
				{
				}
			}

			[Token(Token = "0x17000065")]
			public float distance
			{
				[Token(Token = "0x6000459")]
				[Address(RVA = "0x1670460", Offset = "0x1670460", VA = "0x1670460")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B54", Offset = "0xAF2B54")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600045A")]
				[Address(RVA = "0x1670468", Offset = "0x1670468", VA = "0x1670468")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2B64", Offset = "0xAF2B64")]
				private set
				{
				}
			}

			[Token(Token = "0x600045B")]
			[Address(RVA = "0x166FE2C", Offset = "0x166FE2C", VA = "0x166FE2C")]
			public GroundHit(Vector3 point, Vector3 normal, float distance)
			{
			}
		}

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LayerMask walkable;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SuperCharacterController controller;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private QueryTriggerInteraction triggerInteraction;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GroundHit primaryGround;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private GroundHit nearGround;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GroundHit farGround;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private GroundHit stepGround;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private GroundHit flushGround;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10C4", Offset = "0xAF10C4")]
		private SuperCollisionType <superCollisionType>k__BackingField;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10D4", Offset = "0xAF10D4")]
		private Transform <transform>k__BackingField;

		[Token(Token = "0x400025F")]
		private const float groundingUpperBoundAngle = 60f;

		[Token(Token = "0x4000260")]
		private const float groundingMaxPercentFromCenter = 0.85f;

		[Token(Token = "0x4000261")]
		private const float groundingMinPercentFromcenter = 0.5f;

		[Token(Token = "0x17000026")]
		public SuperCollisionType superCollisionType
		{
			[Token(Token = "0x60002D3")]
			[Address(RVA = "0x166FA0C", Offset = "0x166FA0C", VA = "0x166FA0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2354", Offset = "0xAF2354")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D4")]
			[Address(RVA = "0x166FA14", Offset = "0x166FA14", VA = "0x166FA14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2364", Offset = "0xAF2364")]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public Transform transform
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x166FA1C", Offset = "0x166FA1C", VA = "0x166FA1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2374", Offset = "0xAF2374")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002D6")]
			[Address(RVA = "0x166FA24", Offset = "0x166FA24", VA = "0x166FA24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2384", Offset = "0xAF2384")]
			private set
			{
			}
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x166C814", Offset = "0x166C814", VA = "0x166C814")]
		public SuperGround(LayerMask walkable, SuperCharacterController controller, QueryTriggerInteraction triggerInteraction)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x166E034", Offset = "0x166E034", VA = "0x166E034")]
		public void ProbeGround(Vector3 origin, int iter)
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x166FA2C", Offset = "0x166FA2C", VA = "0x166FA2C")]
		private void ResetGrounds()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x166FE9C", Offset = "0x166FE9C", VA = "0x166FE9C")]
		public bool IsGrounded(bool currentlyGrounded, float distance)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x166FECC", Offset = "0x166FECC", VA = "0x166FECC")]
		public bool IsGrounded(bool currentlyGrounded, float distance, out Vector3 groundNormal)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1670210", Offset = "0x1670210", VA = "0x1670210")]
		private bool OnSteadyGround(Vector3 normal, Vector3 point)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x166EF78", Offset = "0x166EF78", VA = "0x166EF78")]
		public Vector3 PrimaryNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x166EF98", Offset = "0x166EF98", VA = "0x166EF98")]
		public float Distance()
		{
			return default(float);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x166DB0C", Offset = "0x166DB0C", VA = "0x166DB0C")]
		public void DebugGround(bool primary, bool near, bool far, bool flush, bool step)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x166FA40", Offset = "0x166FA40", VA = "0x166FA40")]
		private bool SimulateSphereCast(Vector3 groundNormal, out RaycastHit hit)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 debugMove;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private QueryTriggerInteraction triggerInteraction;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool fixedTimeStep;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private int fixedUpdatesPerSecond;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private bool clampToMovingGround;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[SerializeField]
	private bool debugSpheres;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[SerializeField]
	private bool debugGrounding;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	[SerializeField]
	private bool debugPushbackMesssages;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private CollisionSphere[] spheres;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LayerMask Walkable;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Collider ownCollider;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public float radius;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0680", Offset = "0xAF0680")]
	private float <deltaTime>k__BackingField;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0690", Offset = "0xAF0690")]
	private SuperGround <currentGround>k__BackingField;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06A0", Offset = "0xAF06A0")]
	private CollisionSphere <feet>k__BackingField;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06B0", Offset = "0xAF06B0")]
	private CollisionSphere <head>k__BackingField;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06C0", Offset = "0xAF06C0")]
	private List<SuperCollision> <collisionData>k__BackingField;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06D0", Offset = "0xAF06D0")]
	private Transform <currentlyClampedTo>k__BackingField;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06E0", Offset = "0xAF06E0")]
	private float <heightScale>k__BackingField;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF06F0", Offset = "0xAF06F0")]
	private float <radiusScale>k__BackingField;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0700", Offset = "0xAF0700")]
	private bool <manualUpdateOnly>k__BackingField;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Vector3 initialPosition;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 groundOffset;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 lastGroundPosition;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool clamping;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBD")]
	private bool slopeLimiting;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private List<Collider> ignoredColliders;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<IgnoredCollider> ignoredColliderStack;

	[Token(Token = "0x400003D")]
	private const float Tolerance = 0.05f;

	[Token(Token = "0x400003E")]
	private const float TinyTolerance = 0.01f;

	[Token(Token = "0x400003F")]
	private const string TemporaryLayer = "TempCast";

	[Token(Token = "0x4000040")]
	private const int MaxPushbackIterations = 2;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int TemporaryLayerIndex;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private float fixedDeltaTime;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SuperCollisionType defaultCollisionType;

	[Token(Token = "0x17000002")]
	public float deltaTime
	{
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x166BF60", Offset = "0x166BF60", VA = "0x166BF60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF119C", Offset = "0xAF119C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x166BF68", Offset = "0x166BF68", VA = "0x166BF68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11AC", Offset = "0xAF11AC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000003")]
	public SuperGround currentGround
	{
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x166BF70", Offset = "0x166BF70", VA = "0x166BF70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11BC", Offset = "0xAF11BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x166BF78", Offset = "0x166BF78", VA = "0x166BF78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11CC", Offset = "0xAF11CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000004")]
	public CollisionSphere feet
	{
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x166BF80", Offset = "0x166BF80", VA = "0x166BF80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11DC", Offset = "0xAF11DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x166BF88", Offset = "0x166BF88", VA = "0x166BF88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11EC", Offset = "0xAF11EC")]
		private set
		{
		}
	}

	[Token(Token = "0x17000005")]
	public CollisionSphere head
	{
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x166BF90", Offset = "0x166BF90", VA = "0x166BF90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF11FC", Offset = "0xAF11FC")]
		get
		{
			return null;
		}
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x166BF98", Offset = "0x166BF98", VA = "0x166BF98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF120C", Offset = "0xAF120C")]
		private set
		{
		}
	}

	[Token(Token = "0x17000006")]
	public float height
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x166BFA0", Offset = "0x166BFA0", VA = "0x166BFA0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000007")]
	public Vector3 up
	{
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x166C1B8", Offset = "0x166C1B8", VA = "0x166C1B8")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000008")]
	public Vector3 down
	{
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x166C1DC", Offset = "0x166C1DC", VA = "0x166C1DC")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000009")]
	public List<SuperCollision> collisionData
	{
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x166C284", Offset = "0x166C284", VA = "0x166C284")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF121C", Offset = "0xAF121C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x166C28C", Offset = "0x166C28C", VA = "0x166C28C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF122C", Offset = "0xAF122C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public Transform currentlyClampedTo
	{
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x166C294", Offset = "0x166C294", VA = "0x166C294")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF123C", Offset = "0xAF123C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x166C29C", Offset = "0x166C29C", VA = "0x166C29C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF124C", Offset = "0xAF124C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public float heightScale
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x166C2A4", Offset = "0x166C2A4", VA = "0x166C2A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF125C", Offset = "0xAF125C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x166C2AC", Offset = "0x166C2AC", VA = "0x166C2AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF126C", Offset = "0xAF126C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public float radiusScale
	{
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x166C2B4", Offset = "0x166C2B4", VA = "0x166C2B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF127C", Offset = "0xAF127C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x166C2BC", Offset = "0x166C2BC", VA = "0x166C2BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF128C", Offset = "0xAF128C")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool manualUpdateOnly
	{
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x166C2C4", Offset = "0x166C2C4", VA = "0x166C2C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF129C", Offset = "0xAF129C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x166C2CC", Offset = "0x166C2CC", VA = "0x166C2CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF12AC", Offset = "0xAF12AC")]
		set
		{
		}
	}

	[Token(Token = "0x14000001")]
	public event UpdateDelegate AfterSingleUpdate
	{
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x166C2D8", Offset = "0x166C2D8", VA = "0x166C2D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF12BC", Offset = "0xAF12BC")]
		add
		{
		}
		[Token(Token = "0x600003C")]
		[Address(RVA = "0x166C37C", Offset = "0x166C37C", VA = "0x166C37C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF12CC", Offset = "0xAF12CC")]
		remove
		{
		}
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x166C420", Offset = "0x166C420", VA = "0x166C420")]
	private void Awake()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x166C858", Offset = "0x166C858", VA = "0x166C858")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x166CDAC", Offset = "0x166CDAC", VA = "0x166CDAC")]
	public void ManualUpdate(float deltaTime)
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x166C8DC", Offset = "0x166C8DC", VA = "0x166C8DC")]
	private void SingleUpdate()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x166CDB4", Offset = "0x166CDB4", VA = "0x166CDB4")]
	private void ProbeGround(int iter)
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x166D500", Offset = "0x166D500", VA = "0x166D500")]
	private bool SlopeLimit()
	{
		return default(bool);
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x166D9F8", Offset = "0x166D9F8", VA = "0x166D9F8")]
	private void ClampToGround()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x166EFB4", Offset = "0x166EFB4", VA = "0x166EFB4")]
	public void EnableClamping()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x166EFC0", Offset = "0x166EFC0", VA = "0x166EFC0")]
	public void DisableClamping()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x166EFC8", Offset = "0x166EFC8", VA = "0x166EFC8")]
	public void EnableSlopeLimit()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x166EFD4", Offset = "0x166EFD4", VA = "0x166EFD4")]
	public void DisableSlopeLimit()
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x166EFDC", Offset = "0x166EFDC", VA = "0x166EFDC")]
	public bool IsClamping()
	{
		return default(bool);
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x166CDF4", Offset = "0x166CDF4", VA = "0x166CDF4")]
	private void RecursivePushback(int depth, int maxDepth)
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x166DF2C", Offset = "0x166DF2C", VA = "0x166DF2C")]
	private void PushIgnoredColliders()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x166EEB4", Offset = "0x166EEB4", VA = "0x166EEB4")]
	private void PopIgnoredColliders()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x166F340", Offset = "0x166F340", VA = "0x166F340")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x166C074", Offset = "0x166C074", VA = "0x166C074")]
	public Vector3 SpherePosition(CollisionSphere sphere)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x166F434", Offset = "0x166F434", VA = "0x166F434")]
	public bool PointBelowHead(Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x166F534", Offset = "0x166F534", VA = "0x166F534")]
	public bool PointAboveFeet(Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x166C7AC", Offset = "0x166C7AC", VA = "0x166C7AC")]
	public void IgnoreCollider(Collider col)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x166F634", Offset = "0x166F634", VA = "0x166F634")]
	public void RemoveIgnoredCollider(Collider col)
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x166F69C", Offset = "0x166F69C", VA = "0x166F69C")]
	public void ClearIgnoredColliders()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x166F6F4", Offset = "0x166F6F4", VA = "0x166F6F4")]
	public SuperCharacterController()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class CollisionSphere
{
	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float offset;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public bool isFeet;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	public bool isHead;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x15B3B30", Offset = "0x15B3B30", VA = "0x15B3B30")]
	public CollisionSphere(float offset, bool isFeet, bool isHead)
	{
	}
}
[Token(Token = "0x2000009")]
public struct SuperCollision
{
	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public CollisionSphere collisionSphere;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public SuperCollisionType superCollisionType;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public GameObject gameObject;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 point;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 normal;
}
[Token(Token = "0x200000A")]
public static class SuperCollider
{
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x166EFE4", Offset = "0x166EFE4", VA = "0x166EFE4")]
	public static bool ClosestPointOnSurface(Collider collider, Vector3 to, float radius, out Vector3 closestPointOnSurface)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x1670818", Offset = "0x1670818", VA = "0x1670818")]
	public static Vector3 ClosestPointOnSurface(SphereCollider collider, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x16704B8", Offset = "0x16704B8", VA = "0x16704B8")]
	public static Vector3 ClosestPointOnSurface(BoxCollider collider, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x1670A1C", Offset = "0x1670A1C", VA = "0x1670A1C")]
	public static Vector3 ClosestPointOnSurface(CapsuleCollider collider, Vector3 to)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x1670D80", Offset = "0x1670D80", VA = "0x1670D80")]
	public static Vector3 ClosestPointOnSurface(TerrainCollider collider, Vector3 to, float radius, bool debug = false)
	{
		return default(Vector3);
	}
}
[Token(Token = "0x200000B")]
public class SuperCollisionType : MonoBehaviour
{
	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float StandAngle;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float SlopeLimit;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x1671654", Offset = "0x1671654", VA = "0x1671654")]
	public SuperCollisionType()
	{
	}
}
[Token(Token = "0x200000C")]
public static class SuperMath
{
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x1671668", Offset = "0x1671668", VA = "0x1671668")]
	public static Vector3 ClampAngleOnPlane(Vector3 origin, Vector3 direction, float angle, Vector3 planeNormal)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x16717F4", Offset = "0x16717F4", VA = "0x16717F4")]
	public static float BoundedInterpolation(float[] bounds, float[] values, float t)
	{
		return default(float);
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x1671888", Offset = "0x1671888", VA = "0x1671888")]
	public static bool PointAbovePlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1671968", Offset = "0x1671968", VA = "0x1671968")]
	public static bool Timer(float startTime, float duration)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x167199C", Offset = "0x167199C", VA = "0x167199C")]
	public static float ClampAngle(float angle)
	{
		return default(float);
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x16719C8", Offset = "0x16719C8", VA = "0x16719C8")]
	public static float CalculateJumpSpeed(float jumpHeight, float gravity)
	{
		return default(float);
	}
}
[Token(Token = "0x200000D")]
public class SuperStateMachine : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	public class State
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action DoSuperUpdate;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action enterState;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action exitState;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Enum currentState;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1671D14", Offset = "0x1671D14", VA = "0x1671D14")]
		public State()
		{
		}
	}

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected float timeEnteredState;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public State state;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public Enum lastState;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<Enum, Dictionary<string, Delegate>> _cache;

	[Token(Token = "0x1700000E")]
	public Enum currentState
	{
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1671A5C", Offset = "0x1671A5C", VA = "0x1671A5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1669F8C", Offset = "0x1669F8C", VA = "0x1669F8C")]
		set
		{
		}
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x1671A78", Offset = "0x1671A78", VA = "0x1671A78")]
	private void ChangingState()
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1671AB4", Offset = "0x1671AB4", VA = "0x1671AB4")]
	private void ConfigureCurrentState()
	{
	}

	[Token(Token = "0x6000065")]
	private T ConfigureDelegate<T>(string methodRoot, T Default) where T : class
	{
		return null;
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1671C2C", Offset = "0x1671C2C", VA = "0x1671C2C")]
	private void SuperUpdate()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x1671C7C", Offset = "0x1671C7C", VA = "0x1671C7C", Slot = "4")]
	protected virtual void EarlyGlobalSuperUpdate()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x1671C80", Offset = "0x1671C80", VA = "0x1671C80", Slot = "5")]
	protected virtual void LateGlobalSuperUpdate()
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1671C84", Offset = "0x1671C84", VA = "0x1671C84")]
	private static void DoNothing()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x1671C88", Offset = "0x1671C88", VA = "0x1671C88")]
	public SuperStateMachine()
	{
	}
}
[Token(Token = "0x200000E")]
public static class DebugDraw
{
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x15BD560", Offset = "0x15BD560", VA = "0x15BD560")]
	public static void DrawMarker(Vector3 position, float size, Color color, float duration, bool depthTest = true)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x15BD870", Offset = "0x15BD870", VA = "0x15BD870")]
	public static void DrawPlane(Vector3 position, Vector3 normal, float size, Color color, float duration, bool depthTest = true)
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x15BDD48", Offset = "0x15BDD48", VA = "0x15BDD48")]
	public static void DrawVector(Vector3 position, Vector3 direction, float raySize, float markerSize, Color color, float duration, bool depthTest = true)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x15BDED0", Offset = "0x15BDED0", VA = "0x15BDED0")]
	public static void DrawTriangle(Vector3 a, Vector3 b, Vector3 c, Color color)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x15B2878", Offset = "0x15B2878", VA = "0x15B2878")]
	public static void DrawTriangle(Vector3 a, Vector3 b, Vector3 c, Color color, Transform t)
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x15BE014", Offset = "0x15BE014", VA = "0x15BE014")]
	public static void DrawMesh(Mesh mesh, Color color, Transform t)
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x15B2694", Offset = "0x15B2694", VA = "0x15B2694")]
	public static Color RandomColor()
	{
		return default(Color);
	}
}
[Token(Token = "0x200000F")]
public class Math3d : MonoBehaviour
{
	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Transform tempChild;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Transform tempParent;

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x15BE69C", Offset = "0x15BE69C", VA = "0x15BE69C")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x15BE85C", Offset = "0x15BE85C", VA = "0x15BE85C")]
	public static Vector3 AddVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x15B2204", Offset = "0x15B2204", VA = "0x15B2204")]
	public static Vector3 SetVectorLength(Vector3 vector, float size)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x15BE954", Offset = "0x15BE954", VA = "0x15BE954")]
	public static Quaternion SubtractRotation(Quaternion B, Quaternion A)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x15BEA1C", Offset = "0x15BEA1C", VA = "0x15BEA1C")]
	public static bool PlanePlaneIntersection(out Vector3 linePoint, out Vector3 lineVec, Vector3 plane1Normal, Vector3 plane1Position, Vector3 plane2Normal, Vector3 plane2Position)
	{
		return default(bool);
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x15BEC40", Offset = "0x15BEC40", VA = "0x15BEC40")]
	public static bool LinePlaneIntersection(out Vector3 intersection, Vector3 linePoint, Vector3 lineVec, Vector3 planeNormal, Vector3 planePoint)
	{
		return default(bool);
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x15BEDE8", Offset = "0x15BEDE8", VA = "0x15BEDE8")]
	public static bool LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x15BF054", Offset = "0x15BF054", VA = "0x15BF054")]
	public static bool ClosestPointsOnTwoLines(out Vector3 closestPointLine1, out Vector3 closestPointLine2, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
	{
		return default(bool);
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x15BF308", Offset = "0x15BF308", VA = "0x15BF308")]
	public static Vector3 ProjectPointOnLine(Vector3 linePoint, Vector3 lineVec, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x15BF410", Offset = "0x15BF410", VA = "0x15BF410")]
	public static Vector3 ProjectPointOnLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x15BF734", Offset = "0x15BF734", VA = "0x15BF734")]
	public static Vector3 ProjectPointOnPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x15BF978", Offset = "0x15BF978", VA = "0x15BF978")]
	public static Vector3 ProjectVectorOnPlane(Vector3 planeNormal, Vector3 vector)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x15BF8A0", Offset = "0x15BF8A0", VA = "0x15BF8A0")]
	public static float SignedDistancePlanePoint(Vector3 planeNormal, Vector3 planePoint, Vector3 point)
	{
		return default(float);
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x15BFA54", Offset = "0x15BFA54", VA = "0x15BFA54")]
	public static float SignedDotProduct(Vector3 vectorA, Vector3 vectorB, Vector3 normal)
	{
		return default(float);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x15BFB20", Offset = "0x15BFB20", VA = "0x15BFB20")]
	public static float SignedVectorAngle(Vector3 referenceVector, Vector3 otherVector, Vector3 normal)
	{
		return default(float);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x15BFC64", Offset = "0x15BFC64", VA = "0x15BFC64")]
	public static float AngleVectorPlane(Vector3 vector, Vector3 normal)
	{
		return default(float);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x15BFD4C", Offset = "0x15BFD4C", VA = "0x15BFD4C")]
	public static float DotProductAngle(Vector3 vec1, Vector3 vec2)
	{
		return default(float);
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x15BFE38", Offset = "0x15BFE38", VA = "0x15BFE38")]
	public static void PlaneFrom3Points(out Vector3 planeNormal, out Vector3 planePoint, Vector3 pointA, Vector3 pointB, Vector3 pointC)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x15C00DC", Offset = "0x15C00DC", VA = "0x15C00DC")]
	public static Vector3 GetForwardVector(Quaternion q)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x15C01BC", Offset = "0x15C01BC", VA = "0x15C01BC")]
	public static Vector3 GetUpVector(Quaternion q)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x15C029C", Offset = "0x15C029C", VA = "0x15C029C")]
	public static Vector3 GetRightVector(Quaternion q)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x15C037C", Offset = "0x15C037C", VA = "0x15C037C")]
	public static Quaternion QuaternionFromMatrix(Matrix4x4 m)
	{
		return default(Quaternion);
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x15C0498", Offset = "0x15C0498", VA = "0x15C0498")]
	public static Vector3 PositionFromMatrix(Matrix4x4 m)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x15C04D8", Offset = "0x15C04D8", VA = "0x15C04D8")]
	public static void LookRotationExtended(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 customForward, Vector3 customUp)
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x15C0658", Offset = "0x15C0658", VA = "0x15C0658")]
	public static void TransformWithParent(out Quaternion childRotation, out Vector3 childPosition, Quaternion parentRotation, Vector3 parentPosition, Quaternion startParentRotation, Vector3 startParentPosition, Quaternion startChildRotation, Vector3 startChildPosition)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x15C08B8", Offset = "0x15C08B8", VA = "0x15C08B8")]
	public static void PreciseAlign(ref GameObject gameObjectInOut, Vector3 alignWithVector, Vector3 alignWithNormal, Vector3 alignWithPosition, Vector3 triangleForward, Vector3 triangleNormal, Vector3 trianglePosition)
	{
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x15C0AAC", Offset = "0x15C0AAC", VA = "0x15C0AAC")]
	private void VectorsToTransform(ref GameObject gameObjectInOut, Vector3 positionVector, Vector3 directionVector, Vector3 normalVector)
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x15BF5D4", Offset = "0x15BF5D4", VA = "0x15BF5D4")]
	public static int PointOnWhichSideOfLineSegment(Vector3 linePoint1, Vector3 linePoint2, Vector3 point)
	{
		return default(int);
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x15C0BC4", Offset = "0x15C0BC4", VA = "0x15C0BC4")]
	public static float MouseDistanceToLine(Vector3 linePoint1, Vector3 linePoint2)
	{
		return default(float);
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0x15C0D7C", Offset = "0x15C0D7C", VA = "0x15C0D7C")]
	public static float MouseDistanceToCircle(Vector3 point, float radius)
	{
		return default(float);
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x15C0EB8", Offset = "0x15C0EB8", VA = "0x15C0EB8")]
	public static bool IsLineInRectangle(Vector3 linePoint1, Vector3 linePoint2, Vector3 rectA, Vector3 rectB, Vector3 rectC, Vector3 rectD)
	{
		return default(bool);
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x15C1194", Offset = "0x15C1194", VA = "0x15C1194")]
	public static bool IsPointInRectangle(Vector3 point, Vector3 rectA, Vector3 rectC, Vector3 rectB, Vector3 rectD)
	{
		return default(bool);
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x15C147C", Offset = "0x15C147C", VA = "0x15C147C")]
	public static bool AreLineSegmentsCrossing(Vector3 pointA1, Vector3 pointA2, Vector3 pointB1, Vector3 pointB2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x15C16C8", Offset = "0x15C16C8", VA = "0x15C16C8")]
	public Math3d()
	{
	}
}
[Token(Token = "0x2000010")]
public class AlphaButtonClickMask : MonoBehaviour, ICanvasRaycastFilter
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Image _image;

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x15AFB88", Offset = "0x15AFB88", VA = "0x15AFB88")]
	public void Start()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x15AFD38", Offset = "0x15AFD38", VA = "0x15AFD38", Slot = "4")]
	public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
	{
		return default(bool);
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x15B0044", Offset = "0x15B0044", VA = "0x15B0044")]
	public AlphaButtonClickMask()
	{
	}
}
[Token(Token = "0x2000011")]
public class EventSystemChecker : MonoBehaviour
{
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x15BE200", Offset = "0x15BE200", VA = "0x15BE200")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x15BE2DC", Offset = "0x15BE2DC", VA = "0x15BE2DC")]
	public EventSystemChecker()
	{
	}
}
[Token(Token = "0x2000012")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF71C", Offset = "0xAEF71C")]
public class ForcedReset : MonoBehaviour
{
	[Token(Token = "0x600009A")]
	[Address(RVA = "0x15BE2E4", Offset = "0x15BE2E4", VA = "0x15BE2E4")]
	private void Update()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x15BE3A0", Offset = "0x15BE3A0", VA = "0x15BE3A0")]
	public ForcedReset()
	{
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000013")]
	public class ActivateTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000065")]
		public enum Mode
		{
			[Token(Token = "0x4000267")]
			Trigger,
			[Token(Token = "0x4000268")]
			Replace,
			[Token(Token = "0x4000269")]
			Activate,
			[Token(Token = "0x400026A")]
			Enable,
			[Token(Token = "0x400026B")]
			Animate,
			[Token(Token = "0x400026C")]
			Deactivate
		}

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mode action;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object target;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject source;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int triggerCount;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool repeatTrigger;

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x2017DCC", Offset = "0x2017DCC", VA = "0x2017DCC")]
		private void DoActivateTrigger()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x2018234", Offset = "0x2018234", VA = "0x2018234")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x2018238", Offset = "0x2018238", VA = "0x2018238")]
		public ActivateTrigger()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class AutoMobileShaderSwitch : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000066")]
		public class ReplacementDefinition
		{
			[Token(Token = "0x400026D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Shader original;

			[Token(Token = "0x400026E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Shader replacement;

			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x2018BB8", Offset = "0x2018BB8", VA = "0x2018BB8")]
			public ReplacementDefinition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000067")]
		public class ReplacementList
		{
			[Token(Token = "0x400026F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ReplacementDefinition[] items;

			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x2018BC0", Offset = "0x2018BC0", VA = "0x2018BC0")]
			public ReplacementList()
			{
			}
		}

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ReplacementList m_ReplacementList;

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x2018250", Offset = "0x2018250", VA = "0x2018250")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x2018BB0", Offset = "0x2018BB0", VA = "0x2018BB0")]
		public AutoMobileShaderSwitch()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class AutoMoveAndRotate : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000068")]
		public class Vector3andSpace
		{
			[Token(Token = "0x4000270")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 value;

			[Token(Token = "0x4000271")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Space space;

			[Token(Token = "0x60002E3")]
			[Address(RVA = "0x2018D90", Offset = "0x2018D90", VA = "0x2018D90")]
			public Vector3andSpace()
			{
			}
		}

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3andSpace moveUnitsPerSecond;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3andSpace rotateDegreesPerSecond;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool ignoreTimescale;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_LastRealTime;

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x2018C20", Offset = "0x2018C20", VA = "0x2018C20")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x2018C48", Offset = "0x2018C48", VA = "0x2018C48")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x2018D88", Offset = "0x2018D88", VA = "0x2018D88")]
		public AutoMoveAndRotate()
		{
		}
	}
	[Token(Token = "0x2000016")]
	public class CameraRefocus
	{
		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Lookatpoint;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform Parent;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OrigCameraPos;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_Refocus;

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x2018DA0", Offset = "0x2018DA0", VA = "0x2018DA0")]
		public CameraRefocus(Camera camera, Transform parent, Vector3 origCameraPos)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x2018E00", Offset = "0x2018E00", VA = "0x2018E00")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x2018E08", Offset = "0x2018E08", VA = "0x2018E08")]
		public void ChangeParent(Transform parent)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x2018E10", Offset = "0x2018E10", VA = "0x2018E10")]
		public void GetFocusPoint()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x2018F70", Offset = "0x2018F70", VA = "0x2018F70")]
		public void SetFocusPoint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000017")]
	public class CurveControlledBob
	{
		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HorizontalBobRange;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float VerticalBobRange;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve Bobcurve;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float VerticaltoHorizontalRatio;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float m_CyclePositionX;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_CyclePositionY;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_BobBaseInterval;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_Time;

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x2018FC4", Offset = "0x2018FC4", VA = "0x2018FC4")]
		public void Setup(Camera camera, float bobBaseInterval)
		{
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x2019068", Offset = "0x2019068", VA = "0x2019068")]
		public Vector3 DoHeadBob(float speed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x2019188", Offset = "0x2019188", VA = "0x2019188")]
		public CurveControlledBob()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x2000069")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0050", Offset = "0xAF0050")]
		private sealed class <DragObject>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000272")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000273")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000274")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DragRigidbody <>4__this;

			[Token(Token = "0x4000275")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000276")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <oldDrag>5__2;

			[Token(Token = "0x4000277")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <oldAngularDrag>5__3;

			[Token(Token = "0x4000278")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Camera <mainCamera>5__4;

			[Token(Token = "0x17000028")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002E7")]
				[Address(RVA = "0x2019AD4", Offset = "0x2019AD4", VA = "0x2019AD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000029")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002E9")]
				[Address(RVA = "0x2019B3C", Offset = "0x2019B3C", VA = "0x2019B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x201985C", Offset = "0x201985C", VA = "0x201985C")]
			[DebuggerHidden]
			public <DragObject>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x60002E5")]
			[Address(RVA = "0x2019890", Offset = "0x2019890", VA = "0x2019890", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002E6")]
			[Address(RVA = "0x2019894", Offset = "0x2019894", VA = "0x2019894", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x2019ADC", Offset = "0x2019ADC", VA = "0x2019ADC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400006D")]
		private const float k_Spring = 50f;

		[Token(Token = "0x400006E")]
		private const float k_Damper = 5f;

		[Token(Token = "0x400006F")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000070")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000071")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x4000072")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x20193C8", Offset = "0x20193C8", VA = "0x20193C8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x20197DC", Offset = "0x20197DC", VA = "0x20197DC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF12DC", Offset = "0xAF12DC")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x201972C", Offset = "0x201972C", VA = "0x201972C")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x2019888", Offset = "0x2019888", VA = "0x2019888")]
		public DragRigidbody()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class DynamicShadowSettings : MonoBehaviour
	{
		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Light sunLight;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float minHeight;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minShadowDistance;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float minShadowBias;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float maxHeight;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxShadowDistance;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float maxShadowBias;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float adaptTime;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_SmoothHeight;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_ChangeSpeed;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_OriginalStrength;

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x2019B44", Offset = "0x2019B44", VA = "0x2019B44")]
		private void Start()
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x2019B78", Offset = "0x2019B78", VA = "0x2019B78")]
		private void Update()
		{
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x2019DEC", Offset = "0x2019DEC", VA = "0x2019DEC")]
		public DynamicShadowSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001A")]
	public class FOVKick
	{
		[Token(Token = "0x200006A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0060", Offset = "0xAF0060")]
		private sealed class <FOVKickUp>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000279")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400027B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x400027C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700002A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002ED")]
				[Address(RVA = "0x201A3E8", Offset = "0x201A3E8", VA = "0x201A3E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002EF")]
				[Address(RVA = "0x201A450", Offset = "0x201A450", VA = "0x201A450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x2019FB8", Offset = "0x2019FB8", VA = "0x2019FB8")]
			[DebuggerHidden]
			public <FOVKickUp>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x201A284", Offset = "0x201A284", VA = "0x201A284", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x201A288", Offset = "0x201A288", VA = "0x201A288", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x201A3F0", Offset = "0x201A3F0", VA = "0x201A3F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200006B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0070", Offset = "0xAF0070")]
		private sealed class <FOVKickDown>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400027D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400027E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400027F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FOVKick <>4__this;

			[Token(Token = "0x4000280")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700002C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x201A214", Offset = "0x201A214", VA = "0x201A214", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002F5")]
				[Address(RVA = "0x201A27C", Offset = "0x201A27C", VA = "0x201A27C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x201A054", Offset = "0x201A054", VA = "0x201A054")]
			[DebuggerHidden]
			public <FOVKickDown>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x201A09C", Offset = "0x201A09C", VA = "0x201A09C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x201A0A0", Offset = "0x201A0A0", VA = "0x201A0A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x201A21C", Offset = "0x201A21C", VA = "0x201A21C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Camera Camera;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public float originalFov;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FOVIncrease;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float TimeToIncrease;

		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float TimeToDecrease;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve IncreaseCurve;

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x2019E20", Offset = "0x2019E20", VA = "0x2019E20")]
		public void Setup(Camera camera)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2019E60", Offset = "0x2019E60", VA = "0x2019E60")]
		private void CheckStatus(Camera camera)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x2019F40", Offset = "0x2019F40", VA = "0x2019F40")]
		public void ChangeCamera(Camera camera)
		{
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x2019F48", Offset = "0x2019F48", VA = "0x2019F48")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1340", Offset = "0xAF1340")]
		public IEnumerator FOVKickUp()
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x2019FE4", Offset = "0x2019FE4", VA = "0x2019FE4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF13A4", Offset = "0xAF13A4")]
		public IEnumerator FOVKickDown()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x201A080", Offset = "0x201A080", VA = "0x201A080")]
		public FOVKick()
		{
		}
	}
	[Token(Token = "0x200001B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF780", Offset = "0xAEF780")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x4000085")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000089")]
		private const string display = "{0} FPS";

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x201A458", Offset = "0x201A458", VA = "0x201A458")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x201A4C4", Offset = "0x201A4C4", VA = "0x201A4C4")]
		private void Update()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x201A5C0", Offset = "0x201A5C0", VA = "0x201A5C0")]
		public FPSCounter()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class FollowTarget : MonoBehaviour
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 offset;

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x201A5C8", Offset = "0x201A5C8", VA = "0x201A5C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x201A6A8", Offset = "0x201A6A8", VA = "0x201A6A8")]
		public FollowTarget()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200001D")]
	public class LerpControlledBob
	{
		[Token(Token = "0x200006C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0080", Offset = "0xAF0080")]
		private sealed class <DoBobCycle>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000281")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000282")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000283")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LerpControlledBob <>4__this;

			[Token(Token = "0x4000284")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <t>5__2;

			[Token(Token = "0x1700002E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002F9")]
				[Address(RVA = "0x201A998", Offset = "0x201A998", VA = "0x201A998", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60002FB")]
				[Address(RVA = "0x201AA00", Offset = "0x201AA00", VA = "0x201AA00", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x201A780", Offset = "0x201A780", VA = "0x201A780")]
			[DebuggerHidden]
			public <DoBobCycle>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x201A7B4", Offset = "0x201A7B4", VA = "0x201A7B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x201A7B8", Offset = "0x201A7B8", VA = "0x201A7B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x201A9A0", Offset = "0x201A9A0", VA = "0x201A9A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x201A708", Offset = "0x201A708", VA = "0x201A708")]
		public float Offset()
		{
			return default(float);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x201A710", Offset = "0x201A710", VA = "0x201A710")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1408", Offset = "0xAF1408")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x201A7AC", Offset = "0x201A7AC", VA = "0x201A7AC")]
		public LerpControlledBob()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class ObjectResetter : MonoBehaviour
	{
		[Token(Token = "0x200006D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0090", Offset = "0xAF0090")]
		private sealed class <ResetCoroutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000285")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000286")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000287")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000288")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ObjectResetter <>4__this;

			[Token(Token = "0x17000030")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x201AE08", Offset = "0x201AE08", VA = "0x201AE08", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000031")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000301")]
				[Address(RVA = "0x201AE70", Offset = "0x201AE70", VA = "0x201AE70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60002FC")]
			[Address(RVA = "0x201ABA0", Offset = "0x201ABA0", VA = "0x201ABA0")]
			[DebuggerHidden]
			public <ResetCoroutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x201ABD4", Offset = "0x201ABD4", VA = "0x201ABD4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x201ABD8", Offset = "0x201ABD8", VA = "0x201ABD8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000300")]
			[Address(RVA = "0x201AE10", Offset = "0x201AE10", VA = "0x201AE10", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vector3 originalPosition;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Quaternion originalRotation;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Transform> originalStructure;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody Rigidbody;

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x201AA08", Offset = "0x201AA08", VA = "0x201AA08")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x201AAF4", Offset = "0x201AAF4", VA = "0x201AAF4")]
		public void DelayedReset(float delay)
		{
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x201AB20", Offset = "0x201AB20", VA = "0x201AB20")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF146C", Offset = "0xAF146C")]
		public IEnumerator ResetCoroutine(float delay)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x201ABCC", Offset = "0x201ABCC", VA = "0x201ABCC")]
		public ObjectResetter()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class ParticleSystemDestroyer : MonoBehaviour
	{
		[Token(Token = "0x200006E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00A0", Offset = "0xAF00A0")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000289")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ParticleSystemDestroyer <>4__this;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private ParticleSystem[] <systems>5__2;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <stopTime>5__3;

			[Token(Token = "0x17000032")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000305")]
				[Address(RVA = "0x201B26C", Offset = "0x201B26C", VA = "0x201B26C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000033")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000307")]
				[Address(RVA = "0x201B2D4", Offset = "0x201B2D4", VA = "0x201B2D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x201AEE8", Offset = "0x201AEE8", VA = "0x201AEE8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x201AF34", Offset = "0x201AF34", VA = "0x201AF34", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x201AF38", Offset = "0x201AF38", VA = "0x201AF38", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x201B274", Offset = "0x201B274", VA = "0x201B274", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float minDuration;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float maxDuration;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_MaxLifetime;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool m_EarlyStop;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x201AE78", Offset = "0x201AE78", VA = "0x201AE78")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF14D0", Offset = "0xAF14D0")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x201AF14", Offset = "0x201AF14", VA = "0x201AF14")]
		public void Stop()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x201AF20", Offset = "0x201AF20", VA = "0x201AF20")]
		public ParticleSystemDestroyer()
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x400028F")]
			Standalone,
			[Token(Token = "0x4000290")]
			Mobile
		}

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x201B2DC", Offset = "0x201B2DC", VA = "0x201B2DC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x201B2E0", Offset = "0x201B2E0", VA = "0x201B2E0")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x201B2FC", Offset = "0x201B2FC", VA = "0x201B2FC")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x201B658", Offset = "0x201B658", VA = "0x201B658")]
		public PlatformSpecificContent()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public class SimpleActivatorMenu : MonoBehaviour
	{
		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] objects;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_CurrentActiveObject;

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x201B6D0", Offset = "0x201B6D0", VA = "0x201B6D0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x201B6D8", Offset = "0x201B6D8", VA = "0x201B6D8")]
		public void NextCamera()
		{
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x201B774", Offset = "0x201B774", VA = "0x201B774")]
		public SimpleActivatorMenu()
		{
		}
	}
	[Token(Token = "0x2000022")]
	public class SimpleMouseRotator : MonoBehaviour
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector2 rotationRange;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float rotationSpeed;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float dampingTime;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool autoZeroVerticalOnMobile;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool autoZeroHorizontalOnMobile;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool relative;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_TargetAngles;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_FollowVelocity;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x201B77C", Offset = "0x201B77C", VA = "0x201B77C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x201B7B8", Offset = "0x201B7B8", VA = "0x201B7B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x201BBF4", Offset = "0x201BBF4", VA = "0x201BBF4")]
		public SimpleMouseRotator()
		{
		}
	}
	[Token(Token = "0x2000023")]
	public class SmoothFollow : MonoBehaviour
	{
		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float height;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float rotationDamping;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float heightDamping;

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x201BCB4", Offset = "0x201BCB4", VA = "0x201BCB4")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x201BCB8", Offset = "0x201BCB8", VA = "0x201BCB8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x201BFE4", Offset = "0x201BFE4", VA = "0x201BFE4")]
		public SmoothFollow()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x2000070")]
		public enum Action
		{
			[Token(Token = "0x4000292")]
			Activate,
			[Token(Token = "0x4000293")]
			Deactivate,
			[Token(Token = "0x4000294")]
			Destroy,
			[Token(Token = "0x4000295")]
			ReloadLevel,
			[Token(Token = "0x4000296")]
			Call
		}

		[Serializable]
		[Token(Token = "0x2000071")]
		public class Entry
		{
			[Token(Token = "0x4000297")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x4000298")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x4000299")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000308")]
			[Address(RVA = "0x201C74C", Offset = "0x201C74C", VA = "0x201C74C")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000072")]
		public class Entries
		{
			[Token(Token = "0x400029A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000309")]
			[Address(RVA = "0x201C360", Offset = "0x201C360", VA = "0x201C360")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x2000073")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00B0", Offset = "0xAF00B0")]
		private sealed class <Activate>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400029D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000034")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600030D")]
				[Address(RVA = "0x201C434", Offset = "0x201C434", VA = "0x201C434", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000035")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600030F")]
				[Address(RVA = "0x201C49C", Offset = "0x201C49C", VA = "0x201C49C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600030A")]
			[Address(RVA = "0x201C274", Offset = "0x201C274", VA = "0x201C274")]
			[DebuggerHidden]
			public <Activate>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x600030B")]
			[Address(RVA = "0x201C368", Offset = "0x201C368", VA = "0x201C368", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600030C")]
			[Address(RVA = "0x201C36C", Offset = "0x201C36C", VA = "0x201C36C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600030E")]
			[Address(RVA = "0x201C43C", Offset = "0x201C43C", VA = "0x201C43C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00C0", Offset = "0xAF00C0")]
		private sealed class <Deactivate>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000036")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000313")]
				[Address(RVA = "0x201C570", Offset = "0x201C570", VA = "0x201C570", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000037")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000315")]
				[Address(RVA = "0x201C5D8", Offset = "0x201C5D8", VA = "0x201C5D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000310")]
			[Address(RVA = "0x201C2A0", Offset = "0x201C2A0", VA = "0x201C2A0")]
			[DebuggerHidden]
			public <Deactivate>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000311")]
			[Address(RVA = "0x201C4A4", Offset = "0x201C4A4", VA = "0x201C4A4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000312")]
			[Address(RVA = "0x201C4A8", Offset = "0x201C4A8", VA = "0x201C4A8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000314")]
			[Address(RVA = "0x201C578", Offset = "0x201C578", VA = "0x201C578", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00D0", Offset = "0xAF00D0")]
		private sealed class <ReloadLevel>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x17000038")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000319")]
				[Address(RVA = "0x201C6DC", Offset = "0x201C6DC", VA = "0x201C6DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000039")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600031B")]
				[Address(RVA = "0x201C744", Offset = "0x201C744", VA = "0x201C744", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000316")]
			[Address(RVA = "0x201C2CC", Offset = "0x201C2CC", VA = "0x201C2CC")]
			[DebuggerHidden]
			public <ReloadLevel>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000317")]
			[Address(RVA = "0x201C5E0", Offset = "0x201C5E0", VA = "0x201C5E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000318")]
			[Address(RVA = "0x201C5E4", Offset = "0x201C5E4", VA = "0x201C5E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600031A")]
			[Address(RVA = "0x201C6E4", Offset = "0x201C6E4", VA = "0x201C6E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x201BFF8", Offset = "0x201BFF8", VA = "0x201BFF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x201C124", Offset = "0x201C124", VA = "0x201C124")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1534", Offset = "0xAF1534")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x201C194", Offset = "0x201C194", VA = "0x201C194")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1598", Offset = "0xAF1598")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x201C204", Offset = "0x201C204", VA = "0x201C204")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF15FC", Offset = "0xAF15FC")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x201C2F8", Offset = "0x201C2F8", VA = "0x201C2F8")]
		public TimedObjectActivator()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x201C754", Offset = "0x201C754", VA = "0x201C754")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x201C7AC", Offset = "0x201C7AC", VA = "0x201C7AC")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x201C84C", Offset = "0x201C84C", VA = "0x201C84C")]
		public TimedObjectDestructor()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class WaypointCircuit : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000076")]
		public class WaypointList
		{
			[Token(Token = "0x40002A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public WaypointCircuit circuit;

			[Token(Token = "0x40002A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform[] items;

			[Token(Token = "0x600031C")]
			[Address(RVA = "0x201D68C", Offset = "0x201D68C", VA = "0x201D68C")]
			public WaypointList()
			{
			}
		}

		[Token(Token = "0x2000077")]
		public struct RoutePoint
		{
			[Token(Token = "0x40002A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40002A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 direction;

			[Token(Token = "0x600031D")]
			[Address(RVA = "0x201D018", Offset = "0x201D018", VA = "0x201D018")]
			public RoutePoint(Vector3 position, Vector3 direction)
			{
			}
		}

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WaypointList waypointList;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool smoothRoute;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int numPoints;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3[] points;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float[] distances;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float editorVisualisationSubsteps;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0810", Offset = "0xAF0810")]
		private float <Length>k__BackingField;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int p0n;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int p1n;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int p2n;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int p3n;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float i;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 P0;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 P1;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 P2;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 P3;

		[Token(Token = "0x1700000F")]
		public float Length
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x201C85C", Offset = "0x201C85C", VA = "0x201C85C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1660", Offset = "0xAF1660")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x201C864", Offset = "0x201C864", VA = "0x201C864")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1670", Offset = "0xAF1670")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public Transform[] Waypoints
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x201C86C", Offset = "0x201C86C", VA = "0x201C86C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x201C888", Offset = "0x201C888", VA = "0x201C888")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x201CBB0", Offset = "0x201CBB0", VA = "0x201CBB0")]
		public RoutePoint GetRoutePoint(float dist)
		{
			return default(RoutePoint);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x201CCC0", Offset = "0x201CCC0", VA = "0x201CCC0")]
		public Vector3 GetRoutePosition(float dist)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x201D028", Offset = "0x201D028", VA = "0x201D028")]
		private Vector3 CatmullRom(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float i)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x201C8E4", Offset = "0x201C8E4", VA = "0x201C8E4")]
		private void CachePositionsAndDistances()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x201D390", Offset = "0x201D390", VA = "0x201D390")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x201D610", Offset = "0x201D610", VA = "0x201D610")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x201D398", Offset = "0x201D398", VA = "0x201D398")]
		private void DrawGizmos(bool selected)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x201D618", Offset = "0x201D618", VA = "0x201D618")]
		public WaypointCircuit()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000078")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40002A9")]
			SmoothAlongRoute,
			[Token(Token = "0x40002AA")]
			PointToPoint
		}

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0890", Offset = "0xAF0890")]
		private WaypointCircuit.RoutePoint <targetPoint>k__BackingField;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF08A0", Offset = "0xAF08A0")]
		private WaypointCircuit.RoutePoint <speedPoint>k__BackingField;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF08B0", Offset = "0xAF08B0")]
		private WaypointCircuit.RoutePoint <progressPoint>k__BackingField;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000011")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x201D6EC", Offset = "0x201D6EC", VA = "0x201D6EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1680", Offset = "0xAF1680")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x201D700", Offset = "0x201D700", VA = "0x201D700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1690", Offset = "0xAF1690")]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x201D714", Offset = "0x201D714", VA = "0x201D714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16A0", Offset = "0xAF16A0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x201D728", Offset = "0x201D728", VA = "0x201D728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16B0", Offset = "0xAF16B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x201D73C", Offset = "0x201D73C", VA = "0x201D73C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16C0", Offset = "0xAF16C0")]
			get
			{
				return default(WaypointCircuit.RoutePoint);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x201D750", Offset = "0x201D750", VA = "0x201D750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16D0", Offset = "0xAF16D0")]
			private set
			{
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x201D764", Offset = "0x201D764", VA = "0x201D764")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x201D848", Offset = "0x201D848", VA = "0x201D848")]
		public void Reset()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x201D920", Offset = "0x201D920", VA = "0x201D920")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x201DE88", Offset = "0x201DE88", VA = "0x201DE88")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x201E060", Offset = "0x201E060", VA = "0x201E060")]
		public WaypointProgressTracker()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000028")]
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axisName;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float axisValue;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float responseSpeed;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float returnToCentreSpeed;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AxisTouchButton m_PairedWith;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CrossPlatformInputManager.VirtualAxis m_Axis;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1677F48", Offset = "0x1677F48", VA = "0x1677F48")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x16781D8", Offset = "0x16781D8", VA = "0x16781D8")]
		private void FindPairedButton()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1678358", Offset = "0x1678358", VA = "0x1678358")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x16783D8", Offset = "0x16783D8", VA = "0x16783D8", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x16784C0", Offset = "0x16784C0", VA = "0x16784C0", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1678568", Offset = "0x1678568", VA = "0x1678568")]
		public AxisTouchButton()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class ButtonHandler : MonoBehaviour
	{
		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x16785D4", Offset = "0x16785D4", VA = "0x16785D4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x16785D8", Offset = "0x16785D8", VA = "0x16785D8")]
		public void SetDownState()
		{
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x16786C0", Offset = "0x16786C0", VA = "0x16786C0")]
		public void SetUpState()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x16787A8", Offset = "0x16787A8", VA = "0x16787A8")]
		public void SetAxisPositiveState()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1678890", Offset = "0x1678890", VA = "0x1678890")]
		public void SetAxisNeutralState()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1678978", Offset = "0x1678978", VA = "0x1678978")]
		public void SetAxisNegativeState()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1678A60", Offset = "0x1678A60", VA = "0x1678A60")]
		public void Update()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1678A64", Offset = "0x1678A64", VA = "0x1678A64")]
		public ButtonHandler()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class CrossPlatformInputManager
	{
		[Token(Token = "0x2000079")]
		public enum ActiveInputMethod
		{
			[Token(Token = "0x40002AC")]
			Hardware,
			[Token(Token = "0x40002AD")]
			Touch
		}

		[Token(Token = "0x200007A")]
		public class VirtualAxis
		{
			[Token(Token = "0x40002AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10E4", Offset = "0xAF10E4")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private float m_Value;

			[Token(Token = "0x40002B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF10F4", Offset = "0xAF10F4")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x1700003A")]
			public string name
			{
				[Token(Token = "0x600031E")]
				[Address(RVA = "0x16798CC", Offset = "0x16798CC", VA = "0x16798CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2664", Offset = "0xAF2664")]
				get
				{
					return null;
				}
				[Token(Token = "0x600031F")]
				[Address(RVA = "0x16798D4", Offset = "0x16798D4", VA = "0x16798D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2674", Offset = "0xAF2674")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003B")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x6000320")]
				[Address(RVA = "0x16798DC", Offset = "0x16798DC", VA = "0x16798DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2684", Offset = "0xAF2684")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000321")]
				[Address(RVA = "0x16798E4", Offset = "0x16798E4", VA = "0x16798E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF2694", Offset = "0xAF2694")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003C")]
			public float GetValue
			{
				[Token(Token = "0x6000326")]
				[Address(RVA = "0x1679938", Offset = "0x1679938", VA = "0x1679938")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x1700003D")]
			public float GetValueRaw
			{
				[Token(Token = "0x6000327")]
				[Address(RVA = "0x1679940", Offset = "0x1679940", VA = "0x1679940")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6000322")]
			[Address(RVA = "0x16780B4", Offset = "0x16780B4", VA = "0x16780B4")]
			public VirtualAxis(string name)
			{
			}

			[Token(Token = "0x6000323")]
			[Address(RVA = "0x16798F0", Offset = "0x16798F0", VA = "0x16798F0")]
			public VirtualAxis(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1678370", Offset = "0x1678370", VA = "0x1678370")]
			public void Remove()
			{
			}

			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1679930", Offset = "0x1679930", VA = "0x1679930")]
			public void Update(float value)
			{
			}
		}

		[Token(Token = "0x200007B")]
		public class VirtualButton
		{
			[Token(Token = "0x40002B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1104", Offset = "0xAF1104")]
			private string <name>k__BackingField;

			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1114", Offset = "0xAF1114")]
			private bool <matchWithInputManager>k__BackingField;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private int m_LastPressedFrame;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int m_ReleasedFrame;

			[Token(Token = "0x40002B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private bool m_Pressed;

			[Token(Token = "0x1700003E")]
			public string name
			{
				[Token(Token = "0x6000328")]
				[Address(RVA = "0x1679948", Offset = "0x1679948", VA = "0x1679948")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF26A4", Offset = "0xAF26A4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000329")]
				[Address(RVA = "0x1679950", Offset = "0x1679950", VA = "0x1679950")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF26B4", Offset = "0xAF26B4")]
				private set
				{
				}
			}

			[Token(Token = "0x1700003F")]
			public bool matchWithInputManager
			{
				[Token(Token = "0x600032A")]
				[Address(RVA = "0x1679958", Offset = "0x1679958", VA = "0x1679958")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF26C4", Offset = "0xAF26C4")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600032B")]
				[Address(RVA = "0x1679960", Offset = "0x1679960", VA = "0x1679960")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF26D4", Offset = "0xAF26D4")]
				private set
				{
				}
			}

			[Token(Token = "0x17000040")]
			public bool GetButton
			{
				[Token(Token = "0x6000331")]
				[Address(RVA = "0x1679AC0", Offset = "0x1679AC0", VA = "0x1679AC0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000041")]
			public bool GetButtonDown
			{
				[Token(Token = "0x6000332")]
				[Address(RVA = "0x1679AC8", Offset = "0x1679AC8", VA = "0x1679AC8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000042")]
			public bool GetButtonUp
			{
				[Token(Token = "0x6000333")]
				[Address(RVA = "0x1679AF8", Offset = "0x1679AF8", VA = "0x1679AF8")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600032C")]
			[Address(RVA = "0x167996C", Offset = "0x167996C", VA = "0x167996C")]
			public VirtualButton(string name)
			{
			}

			[Token(Token = "0x600032D")]
			[Address(RVA = "0x16799A8", Offset = "0x16799A8", VA = "0x16799A8")]
			public VirtualButton(string name, bool matchToInputSettings)
			{
			}

			[Token(Token = "0x600032E")]
			[Address(RVA = "0x16799F0", Offset = "0x16799F0", VA = "0x16799F0")]
			public void Pressed()
			{
			}

			[Token(Token = "0x600032F")]
			[Address(RVA = "0x1679A2C", Offset = "0x1679A2C", VA = "0x1679A2C")]
			public void Released()
			{
			}

			[Token(Token = "0x6000330")]
			[Address(RVA = "0x1679A58", Offset = "0x1679A58", VA = "0x1679A58")]
			public void Remove()
			{
			}
		}

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VirtualInput activeInput;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static VirtualInput s_TouchInput;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static VirtualInput s_HardwareInput;

		[Token(Token = "0x17000014")]
		public static Vector3 mousePosition
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x167954C", Offset = "0x167954C", VA = "0x167954C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1678A6C", Offset = "0x1678A6C", VA = "0x1678A6C")]
		static CrossPlatformInputManager()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1678B0C", Offset = "0x1678B0C", VA = "0x1678B0C")]
		public static void SwitchActiveInputMethod(ActiveInputMethod activeInputMethod)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x167803C", Offset = "0x167803C", VA = "0x167803C")]
		public static bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1678C24", Offset = "0x1678C24", VA = "0x1678C24")]
		public static bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x16780E8", Offset = "0x16780E8", VA = "0x16780E8")]
		public static void RegisterVirtualAxis(VirtualAxis axis)
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1678E2C", Offset = "0x1678E2C", VA = "0x1678E2C")]
		public static void RegisterVirtualButton(VirtualButton button)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1678FCC", Offset = "0x1678FCC", VA = "0x1678FCC")]
		public static void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x167911C", Offset = "0x167911C", VA = "0x167911C")]
		public static void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1678160", Offset = "0x1678160", VA = "0x1678160")]
		public static VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1672EB8", Offset = "0x1672EB8", VA = "0x1672EB8")]
		public static float GetAxis(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x1679350", Offset = "0x1679350", VA = "0x1679350")]
		public static float GetAxisRaw(string name)
		{
			return default(float);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x16792C0", Offset = "0x16792C0", VA = "0x16792C0")]
		private static float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x16793B8", Offset = "0x16793B8", VA = "0x16793B8")]
		public static bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1674434", Offset = "0x1674434", VA = "0x1674434")]
		public static bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x1679438", Offset = "0x1679438", VA = "0x1679438")]
		public static bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1678640", Offset = "0x1678640", VA = "0x1678640")]
		public static void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1678728", Offset = "0x1678728", VA = "0x1678728")]
		public static void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1678810", Offset = "0x1678810", VA = "0x1678810")]
		public static void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x16789E0", Offset = "0x16789E0", VA = "0x16789E0")]
		public static void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x16788F8", Offset = "0x16788F8", VA = "0x16788F8")]
		public static void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x16794B8", Offset = "0x16794B8", VA = "0x16794B8")]
		public static void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x16795C8", Offset = "0x16795C8", VA = "0x16795C8")]
		public static void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x16796C4", Offset = "0x16796C4", VA = "0x16796C4")]
		public static void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x16797CC", Offset = "0x16797CC", VA = "0x16797CC")]
		public static void SetVirtualMousePositionZ(float f)
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class InputAxisScrollbar : MonoBehaviour
	{
		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string axis;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1679B28", Offset = "0x1679B28", VA = "0x1679B28")]
		private void Update()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x1679B2C", Offset = "0x1679B2C", VA = "0x1679B2C")]
		public void HandleInput(float value)
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1679BAC", Offset = "0x1679BAC", VA = "0x1679BAC")]
		public InputAxisScrollbar()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class Joystick : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IDragHandler
	{
		[Token(Token = "0x200007C")]
		public enum AxisOption
		{
			[Token(Token = "0x40002B7")]
			Both,
			[Token(Token = "0x40002B8")]
			OnlyHorizontal,
			[Token(Token = "0x40002B9")]
			OnlyVertical
		}

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int MovementRange;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_UseX;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		private bool m_UseY;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1679BB4", Offset = "0x1679BB4", VA = "0x1679BB4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1679CF4", Offset = "0x1679CF4", VA = "0x1679CF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x1679D30", Offset = "0x1679D30", VA = "0x1679D30")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x1679BB8", Offset = "0x1679BB8", VA = "0x1679BB8")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x1679E20", Offset = "0x1679E20", VA = "0x1679E20", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x167A010", Offset = "0x167A010", VA = "0x167A010", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x167A058", Offset = "0x167A058", VA = "0x167A058", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x167A05C", Offset = "0x167A05C", VA = "0x167A05C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x167A0AC", Offset = "0x167A0AC", VA = "0x167A0AC")]
		public Joystick()
		{
		}
	}
	[Token(Token = "0x200002D")]
	[ExecuteInEditMode]
	public class MobileControlRig : MonoBehaviour
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x167A11C", Offset = "0x167A11C", VA = "0x167A11C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x167A12C", Offset = "0x167A12C", VA = "0x167A12C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x167A124", Offset = "0x167A124", VA = "0x167A124")]
		private void CheckEnableControlRig()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x167A208", Offset = "0x167A208", VA = "0x167A208")]
		private void EnableControlRig(bool enabled)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x167A474", Offset = "0x167A474", VA = "0x167A474")]
		public MobileControlRig()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x200007D")]
		public enum AxisOptions
		{
			[Token(Token = "0x40002BB")]
			ForwardAxis,
			[Token(Token = "0x40002BC")]
			SidewaysAxis
		}

		[Serializable]
		[Token(Token = "0x200007E")]
		public class AxisMapping
		{
			[Token(Token = "0x20000E1")]
			public enum MappingType
			{
				[Token(Token = "0x400039C")]
				NamedAxis,
				[Token(Token = "0x400039D")]
				MousePositionX,
				[Token(Token = "0x400039E")]
				MousePositionY,
				[Token(Token = "0x400039F")]
				MousePositionZ
			}

			[Token(Token = "0x40002BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40002BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x6000334")]
			[Address(RVA = "0x167B324", Offset = "0x167B324", VA = "0x167B324")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x167AFB0", Offset = "0x167AFB0", VA = "0x167AFB0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x167B070", Offset = "0x167B070", VA = "0x167B070")]
		private void Update()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x167B2FC", Offset = "0x167B2FC", VA = "0x167B2FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x167B314", Offset = "0x167B314", VA = "0x167B314")]
		public TiltInput()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF7F4", Offset = "0xAEF7F4")]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
	{
		[Token(Token = "0x200007F")]
		public enum AxisOption
		{
			[Token(Token = "0x40002C0")]
			Both,
			[Token(Token = "0x40002C1")]
			OnlyHorizontal,
			[Token(Token = "0x40002C2")]
			OnlyVertical
		}

		[Token(Token = "0x2000080")]
		public enum ControlStyle
		{
			[Token(Token = "0x40002C4")]
			Absolute,
			[Token(Token = "0x40002C5")]
			Relative,
			[Token(Token = "0x40002C6")]
			Swipe
		}

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AxisOption axesToUse;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ControlStyle controlStyle;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string horizontalAxisName;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string verticalAxisName;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float Xsensitivity;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Ysensitivity;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_StartPos;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector2 m_PreviousDelta;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_JoytickOutput;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_UseX;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_UseY;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CrossPlatformInputManager.VirtualAxis m_VerticalVirtualAxis;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool m_Dragging;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_Id;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector2 m_PreviousTouchPos;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 m_Center;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Image m_Image;

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x167B32C", Offset = "0x167B32C", VA = "0x167B32C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x167B46C", Offset = "0x167B46C", VA = "0x167B46C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x167B330", Offset = "0x167B330", VA = "0x167B330")]
		private void CreateVirtualAxes()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x167B4E8", Offset = "0x167B4E8", VA = "0x167B4E8")]
		private void UpdateVirtualAxes(Vector3 value)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x167B554", Offset = "0x167B554", VA = "0x167B554", Slot = "4")]
		public void OnPointerDown(PointerEventData data)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x167B604", Offset = "0x167B604", VA = "0x167B604")]
		private void Update()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x167B7D8", Offset = "0x167B7D8", VA = "0x167B7D8", Slot = "5")]
		public void OnPointerUp(PointerEventData data)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x167B850", Offset = "0x167B850", VA = "0x167B850")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x167B944", Offset = "0x167B944", VA = "0x167B944")]
		public TouchPad()
		{
		}
	}
	[Token(Token = "0x2000030")]
	public abstract class VirtualInput
	{
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF08C0", Offset = "0xAF08C0")]
		private Vector3 <virtualMousePosition>k__BackingField;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected List<string> m_AlwaysUseVirtual;

		[Token(Token = "0x17000015")]
		public Vector3 virtualMousePosition
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x167B9BC", Offset = "0x167B9BC", VA = "0x167B9BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16E0", Offset = "0xAF16E0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x167B9C8", Offset = "0x167B9C8", VA = "0x167B9C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF16F0", Offset = "0xAF16F0")]
			private set
			{
			}
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1678BBC", Offset = "0x1678BBC", VA = "0x1678BBC")]
		public bool AxisExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1678C9C", Offset = "0x1678C9C", VA = "0x1678C9C")]
		public bool ButtonExists(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1678D04", Offset = "0x1678D04", VA = "0x1678D04")]
		public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1678EA4", Offset = "0x1678EA4", VA = "0x1678EA4")]
		public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1679084", Offset = "0x1679084", VA = "0x1679084")]
		public void UnRegisterVirtualAxis(string name)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1679194", Offset = "0x1679194", VA = "0x1679194")]
		public void UnRegisterVirtualButton(string name)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x167922C", Offset = "0x167922C", VA = "0x167922C")]
		public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1679678", Offset = "0x1679678", VA = "0x1679678")]
		public void SetVirtualMousePositionX(float f)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1679778", Offset = "0x1679778", VA = "0x1679778")]
		public void SetVirtualMousePositionY(float f)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x167987C", Offset = "0x167987C", VA = "0x167987C")]
		public void SetVirtualMousePositionZ(float f)
		{
		}

		[Token(Token = "0x6000145")]
		public abstract float GetAxis(string name, bool raw);

		[Token(Token = "0x6000146")]
		public abstract bool GetButton(string name);

		[Token(Token = "0x6000147")]
		public abstract bool GetButtonDown(string name);

		[Token(Token = "0x6000148")]
		public abstract bool GetButtonUp(string name);

		[Token(Token = "0x6000149")]
		public abstract void SetButtonDown(string name);

		[Token(Token = "0x600014A")]
		public abstract void SetButtonUp(string name);

		[Token(Token = "0x600014B")]
		public abstract void SetAxisPositive(string name);

		[Token(Token = "0x600014C")]
		public abstract void SetAxisNegative(string name);

		[Token(Token = "0x600014D")]
		public abstract void SetAxisZero(string name);

		[Token(Token = "0x600014E")]
		public abstract void SetAxis(string name, float value);

		[Token(Token = "0x600014F")]
		public abstract Vector3 MousePosition();

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x167AC28", Offset = "0x167AC28", VA = "0x167AC28")]
		protected VirtualInput()
		{
		}
	}
}
namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	[Token(Token = "0x2000031")]
	public class MobileInput : VirtualInput
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x167A47C", Offset = "0x167A47C", VA = "0x167A47C")]
		private void AddButton(string name)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x167A510", Offset = "0x167A510", VA = "0x167A510")]
		private void AddAxes(string name)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x167A59C", Offset = "0x167A59C", VA = "0x167A59C", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x167A638", Offset = "0x167A638", VA = "0x167A638", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x167A6F0", Offset = "0x167A6F0", VA = "0x167A6F0", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x167A79C", Offset = "0x167A79C", VA = "0x167A79C", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x167A83C", Offset = "0x167A83C", VA = "0x167A83C", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x167A8DC", Offset = "0x167A8DC", VA = "0x167A8DC", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x167A978", Offset = "0x167A978", VA = "0x167A978", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x167AA20", Offset = "0x167AA20", VA = "0x167AA20", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x167AAD0", Offset = "0x167AAD0", VA = "0x167AAD0", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x167AB80", Offset = "0x167AB80", VA = "0x167AB80", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x167AC1C", Offset = "0x167AC1C", VA = "0x167AC1C", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1678B04", Offset = "0x1678B04", VA = "0x1678B04")]
		public MobileInput()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class StandaloneInput : VirtualInput
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x167ACE8", Offset = "0x167ACE8", VA = "0x167ACE8", Slot = "4")]
		public override float GetAxis(string name, bool raw)
		{
			return default(float);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x167ACFC", Offset = "0x167ACFC", VA = "0x167ACFC", Slot = "5")]
		public override bool GetButton(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x167AD08", Offset = "0x167AD08", VA = "0x167AD08", Slot = "6")]
		public override bool GetButtonDown(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x167AD14", Offset = "0x167AD14", VA = "0x167AD14", Slot = "7")]
		public override bool GetButtonUp(string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x167AD20", Offset = "0x167AD20", VA = "0x167AD20", Slot = "8")]
		public override void SetButtonDown(string name)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x167AD8C", Offset = "0x167AD8C", VA = "0x167AD8C", Slot = "9")]
		public override void SetButtonUp(string name)
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x167ADF8", Offset = "0x167ADF8", VA = "0x167ADF8", Slot = "10")]
		public override void SetAxisPositive(string name)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x167AE64", Offset = "0x167AE64", VA = "0x167AE64", Slot = "11")]
		public override void SetAxisNegative(string name)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x167AED0", Offset = "0x167AED0", VA = "0x167AED0", Slot = "12")]
		public override void SetAxisZero(string name)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x167AF3C", Offset = "0x167AF3C", VA = "0x167AF3C", Slot = "13")]
		public override void SetAxis(string name, float value)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x167AFA8", Offset = "0x167AFA8", VA = "0x167AFA8", Slot = "14")]
		public override Vector3 MousePosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1678B08", Offset = "0x1678B08", VA = "0x1678B08")]
		public StandaloneInput()
		{
		}
	}
}
namespace UnityStandardAssets.Vehicles.Ball
{
	[Token(Token = "0x2000033")]
	public class Ball : MonoBehaviour
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovePower;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_UseTorque;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_MaxAngularVelocity;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x4000102")]
		private const float k_GroundRayLength = 1f;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x201E07C", Offset = "0x201E07C", VA = "0x201E07C")]
		private void Start()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x201E0F0", Offset = "0x201E0F0", VA = "0x201E0F0")]
		public void Move(Vector3 moveDirection, bool jump)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x201E2EC", Offset = "0x201E2EC", VA = "0x201E2EC")]
		public Ball()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class BallUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Ball ball;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 move;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform cam;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 camForward;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool jump;

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x201E310", Offset = "0x201E310", VA = "0x201E310")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x201E404", Offset = "0x201E404", VA = "0x201E404")]
		private void Update()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x201E6AC", Offset = "0x201E6AC", VA = "0x201E6AC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x201E6E8", Offset = "0x201E6E8", VA = "0x201E6E8")]
		public BallUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF858", Offset = "0xAEF858")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF858", Offset = "0xAEF858")]
	public class AICharacterControl : MonoBehaviour
	{
		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0910", Offset = "0xAF0910")]
		private NavMeshAgent <agent>k__BackingField;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0920", Offset = "0xAF0920")]
		private ThirdPersonCharacter <character>k__BackingField;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x17000016")]
		public NavMeshAgent agent
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x16769F4", Offset = "0x16769F4", VA = "0x16769F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1700", Offset = "0xAF1700")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000173")]
			[Address(RVA = "0x16769FC", Offset = "0x16769FC", VA = "0x16769FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1710", Offset = "0xAF1710")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public ThirdPersonCharacter character
		{
			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1676A04", Offset = "0x1676A04", VA = "0x1676A04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1720", Offset = "0xAF1720")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1676A0C", Offset = "0x1676A0C", VA = "0x1676A0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1730", Offset = "0xAF1730")]
			private set
			{
			}
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1676A14", Offset = "0x1676A14", VA = "0x1676A14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1676AB0", Offset = "0x1676AB0", VA = "0x1676AB0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1676D8C", Offset = "0x1676D8C", VA = "0x1676D8C")]
		public void SetTarget(Transform target)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1676D94", Offset = "0x1676D94", VA = "0x1676D94")]
		public AICharacterControl()
		{
		}
	}
	[Token(Token = "0x2000036")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF8E4", Offset = "0xAEF8E4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF8E4", Offset = "0xAEF8E4")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF8E4", Offset = "0xAEF8E4")]
	public class ThirdPersonCharacter : MonoBehaviour
	{
		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_MovingTurnSpeed;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float m_StationaryTurnSpeed;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_JumpPower;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0960", Offset = "0xAF0960")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_RunCycleLegOffset;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_MoveSpeedMultiplier;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_AnimSpeedMultiplier;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_GroundCheckDistance;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Animator m_Animator;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_IsGrounded;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_OrigGroundCheckDistance;

		[Token(Token = "0x4000118")]
		private const float k_Half = 0.5f;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_TurnAmount;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_ForwardAmount;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 m_GroundNormal;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_CapsuleHeight;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 m_CapsuleCenter;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_Crouching;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1676D9C", Offset = "0x1676D9C", VA = "0x1676D9C")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x1676BD4", Offset = "0x1676BD4", VA = "0x1676BD4")]
		public void Move(Vector3 move, bool crouch, bool jump)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x1677324", Offset = "0x1677324", VA = "0x1677324")]
		private void ScaleCapsuleForCrouching(bool crouch)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x16775C0", Offset = "0x16775C0", VA = "0x16775C0")]
		private void PreventStandingInLowHeadroom()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1677778", Offset = "0x1677778", VA = "0x1677778")]
		private void UpdateAnimator(Vector3 move)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1677210", Offset = "0x1677210", VA = "0x1677210")]
		private void HandleAirborneMovement()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x16770D0", Offset = "0x16770D0", VA = "0x16770D0")]
		private void HandleGroundedMovement(bool crouch, bool jump)
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1677000", Offset = "0x1677000", VA = "0x1677000")]
		private void ApplyExtraTurnRotation()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x16779C4", Offset = "0x16779C4", VA = "0x16779C4")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1676E6C", Offset = "0x1676E6C", VA = "0x1676E6C")]
		private void CheckGroundStatus()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1677AF4", Offset = "0x1677AF4", VA = "0x1677AF4")]
		public ThirdPersonCharacter()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF998", Offset = "0xAEF998")]
	public class ThirdPersonUserControl : MonoBehaviour
	{
		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ThirdPersonCharacter m_Character;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_Cam;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 m_CamForward;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 m_Move;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_Jump;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1677B14", Offset = "0x1677B14", VA = "0x1677B14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1677C1C", Offset = "0x1677C1C", VA = "0x1677C1C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1677C9C", Offset = "0x1677C9C", VA = "0x1677C9C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1677F40", Offset = "0x1677F40", VA = "0x1677F40")]
		public ThirdPersonUserControl()
		{
		}
	}
}
namespace UnityStandardAssets.Characters.FirstPerson
{
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF9FC", Offset = "0xAEF9FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEF9FC", Offset = "0xAEF9FC")]
	public class FirstPersonController : MonoBehaviour
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_IsWalking;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		public float m_WalkSpeed;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_RunSpeed;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0A10", Offset = "0xAF0A10")]
		private float m_RunstepLenghten;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float m_JumpSpeed;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_StickToGroundForce;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_GravityMultiplier;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MouseLook m_MouseLook;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_UseFovKick;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private FOVKick m_FovKick;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_UseHeadBob;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CurveControlledBob m_HeadBob;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LerpControlledBob m_JumpBob;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_StepInterval;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AudioClip[] m_FootstepSounds;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private AudioClip m_JumpSound;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private AudioClip m_LandSound;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Camera m_Camera;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_Jump;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_YRotation;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector2 m_Input;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 m_MoveDir;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private CharacterController m_CharacterController;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private CollisionFlags m_CollisionFlags;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float m_StepCycle;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float m_NextStep;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private bool m_Jumping;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x1674168", Offset = "0x1674168", VA = "0x1674168")]
		private void Start()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x16742C8", Offset = "0x16742C8", VA = "0x16742C8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x16744B4", Offset = "0x16744B4", VA = "0x16744B4")]
		private void PlayLandingSound()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x1674508", Offset = "0x1674508", VA = "0x1674508")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1674ACC", Offset = "0x1674ACC", VA = "0x1674ACC")]
		private void PlayJumpSound()
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1674B0C", Offset = "0x1674B0C", VA = "0x1674B0C")]
		private void ProgressStepCycle(float speed)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x1674DE8", Offset = "0x1674DE8", VA = "0x1674DE8")]
		private void PlayFootStepAudio()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x1674C10", Offset = "0x1674C10", VA = "0x1674C10")]
		private void UpdateCameraPosition(float speed)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x167492C", Offset = "0x167492C", VA = "0x167492C")]
		private void GetInput(out float speed)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x16743E0", Offset = "0x16743E0", VA = "0x16743E0")]
		private void RotateView()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x1675224", Offset = "0x1675224", VA = "0x1675224")]
		private void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x16753A4", Offset = "0x16753A4", VA = "0x16753A4")]
		public FirstPersonController()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class HeadBob : MonoBehaviour
	{
		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera Camera;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CurveControlledBob motionBob;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LerpControlledBob jumpAndLandingBob;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public RigidbodyFirstPersonController rigidbodyFirstPersonController;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float StrideInterval;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0B20", Offset = "0xAF0B20")]
		public float RunningStrideLengthen;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_OriginalCameraPosition;

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x167547C", Offset = "0x167547C", VA = "0x167547C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x16754D8", Offset = "0x16754D8", VA = "0x16754D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16756F0", Offset = "0x16756F0", VA = "0x16756F0")]
		public HeadBob()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200003A")]
	public class MouseLook
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1674274", Offset = "0x1674274", VA = "0x1674274")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1674F34", Offset = "0x1674F34", VA = "0x1674F34")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1675840", Offset = "0x1675840", VA = "0x1675840")]
		public void SetCursorLock(bool value)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1674DD8", Offset = "0x1674DD8", VA = "0x1674DD8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1675874", Offset = "0x1675874", VA = "0x1675874")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1675778", Offset = "0x1675778", VA = "0x1675778")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16758F0", Offset = "0x16758F0", VA = "0x16758F0")]
		public MouseLook()
		{
		}
	}
	[Token(Token = "0x200003B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFA88", Offset = "0xAEFA88")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFA88", Offset = "0xAEFA88")]
	public class RigidbodyFirstPersonController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000081")]
		public class MovementSettings
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ForwardSpeed;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float BackwardSpeed;

			[Token(Token = "0x40002C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float StrafeSpeed;

			[Token(Token = "0x40002CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float RunMultiplier;

			[Token(Token = "0x40002CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public KeyCode RunKey;

			[Token(Token = "0x40002CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public float JumpForce;

			[Token(Token = "0x40002CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public AnimationCurve SlopeCurveModifier;

			[Token(Token = "0x40002CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[HideInInspector]
			public float CurrentTargetSpeed;

			[Token(Token = "0x6000335")]
			[Address(RVA = "0x1676670", Offset = "0x1676670", VA = "0x1676670")]
			public void UpdateDesiredTargetSpeed(Vector2 input)
			{
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1676820", Offset = "0x1676820", VA = "0x1676820")]
			public MovementSettings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000082")]
		public class AdvancedSettings
		{
			[Token(Token = "0x40002CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float groundCheckDistance;

			[Token(Token = "0x40002D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float stickToGroundHelperDistance;

			[Token(Token = "0x40002D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float slowDownRate;

			[Token(Token = "0x40002D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool airControl;

			[Token(Token = "0x40002D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAF1134", Offset = "0xAF1134")]
			public float shellOffset;

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x16769D8", Offset = "0x16769D8", VA = "0x16769D8")]
			public AdvancedSettings()
			{
			}
		}

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Camera cam;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MovementSettings movementSettings;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MouseLook mouseLook;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AdvancedSettings advancedSettings;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private CapsuleCollider m_Capsule;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_YRotation;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 m_GroundContactNormal;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_Jump;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool m_PreviouslyGrounded;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		private bool m_Jumping;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		private bool m_IsGrounded;

		[Token(Token = "0x17000018")]
		public Vector3 Velocity
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x16756CC", Offset = "0x16756CC", VA = "0x16756CC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000019")]
		public bool Grounded
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1675924", Offset = "0x1675924", VA = "0x1675924")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public bool Jumping
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x167592C", Offset = "0x167592C", VA = "0x167592C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public bool Running
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x16756E8", Offset = "0x16756E8", VA = "0x16756E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1675934", Offset = "0x1675934", VA = "0x1675934")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x16759E0", Offset = "0x16759E0", VA = "0x16759E0")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1675C74", Offset = "0x1675C74", VA = "0x1675C74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1676338", Offset = "0x1676338", VA = "0x1676338")]
		private float SlopeMultiplier()
		{
			return default(float);
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16763F0", Offset = "0x16763F0", VA = "0x16763F0")]
		private void StickToGroundHelper()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1676288", Offset = "0x1676288", VA = "0x1676288")]
		private Vector2 GetInput()
		{
			return default(Vector2);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1675A6C", Offset = "0x1675A6C", VA = "0x1675A6C")]
		private void RotateView()
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x16760A0", Offset = "0x16760A0", VA = "0x16760A0")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x167673C", Offset = "0x167673C", VA = "0x167673C")]
		public RigidbodyFirstPersonController()
		{
		}
	}
}
namespace UnityStandardAssets.Cameras
{
	[Token(Token = "0x200003C")]
	public abstract class AbstractTargetFollower : MonoBehaviour
	{
		[Token(Token = "0x2000083")]
		public enum UpdateType
		{
			[Token(Token = "0x40002D5")]
			FixedUpdate,
			[Token(Token = "0x40002D6")]
			LateUpdate,
			[Token(Token = "0x40002D7")]
			ManualUpdate
		}

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected Transform m_Target;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool m_AutoTargetPlayer;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private UpdateType m_UpdateType;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected Rigidbody targetRigidbody;

		[Token(Token = "0x1700001C")]
		public Transform Target
		{
			[Token(Token = "0x60001B3")]
			[Address(RVA = "0x16721C4", Offset = "0x16721C4", VA = "0x16721C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1671DD4", Offset = "0x1671DD4", VA = "0x1671DD4", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1671F38", Offset = "0x1671F38", VA = "0x1671F38")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x167200C", Offset = "0x167200C", VA = "0x167200C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x16720E4", Offset = "0x16720E4", VA = "0x16720E4")]
		public void ManualUpdate()
		{
		}

		[Token(Token = "0x60001B0")]
		protected abstract void FollowTarget(float deltaTime);

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x1671E7C", Offset = "0x1671E7C", VA = "0x1671E7C")]
		public void FindAndTargetPlayer()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x16721BC", Offset = "0x16721BC", VA = "0x16721BC", Slot = "6")]
		public virtual void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x16721CC", Offset = "0x16721CC", VA = "0x16721CC")]
		protected AbstractTargetFollower()
		{
		}
	}
	[Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	public class AutoCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_RollSpeed;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_FollowVelocity;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[SerializeField]
		private bool m_FollowTilt;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_SpinTurnLimit;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float m_TargetVelocityLowerLimit;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SmoothTurnTime;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_LastFlatAngle;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_CurrentTurnAmount;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_TurnSpeedVelocityChange;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 m_RollUp;

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x16721DC", Offset = "0x16721DC", VA = "0x16721DC", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1672750", Offset = "0x1672750", VA = "0x1672750")]
		public AutoCam()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class FreeLookCam : PivotBasedCameraRig
	{
		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float m_MoveSpeed;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0BF8", Offset = "0xAF0BF8")]
		[SerializeField]
		private float m_TurnSpeed;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_TurnSmoothing;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_TiltMax;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_TiltMin;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_LockCursor;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[SerializeField]
		private bool m_VerticalAutoReturn;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_LookAngle;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_TiltAngle;

		[Token(Token = "0x400017B")]
		private const float k_LookDistance = 100f;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 m_PivotEulers;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion m_PivotTargetRot;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion m_TransformTargetRot;

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x167280C", Offset = "0x167280C", VA = "0x167280C", Slot = "7")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x1672944", Offset = "0x1672944", VA = "0x1672944")]
		protected void Update()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x1672D34", Offset = "0x1672D34", VA = "0x1672D34")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1672D58", Offset = "0x1672D58", VA = "0x1672D58", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x16729A4", Offset = "0x16729A4", VA = "0x16729A4")]
		private void HandleRotationMovement()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1672F20", Offset = "0x1672F20", VA = "0x1672F20")]
		public FreeLookCam()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class HandHeldCam : LookatTarget
	{
		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_SwaySpeed;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_BaseSwayAmount;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_TrackingSwayAmount;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0CB8", Offset = "0xAF0CB8")]
		[SerializeField]
		private float m_TrackingBias;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1672F48", Offset = "0x1672F48", VA = "0x1672F48", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x16733EC", Offset = "0x16733EC", VA = "0x16733EC")]
		public HandHeldCam()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class LookatTarget : AbstractTargetFollower
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Vector2 m_RotationRange;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_FollowSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 m_FollowAngles;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion m_OriginalRotation;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Vector3 m_FollowVelocity;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x167342C", Offset = "0x167342C", VA = "0x167342C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x16730D8", Offset = "0x16730D8", VA = "0x16730D8", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1673414", Offset = "0x1673414", VA = "0x1673414")]
		public LookatTarget()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public abstract class PivotBasedCameraRig : AbstractTargetFollower
	{
		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Transform m_Cam;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Transform m_Pivot;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Vector3 m_LastTargetPosition;

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x16728CC", Offset = "0x16728CC", VA = "0x16728CC", Slot = "7")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x16727FC", Offset = "0x16727FC", VA = "0x16727FC")]
		protected PivotBasedCameraRig()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class ProtectCameraFromWallClip : MonoBehaviour
	{
		[Token(Token = "0x2000084")]
		public class RayHitComparer : IComparer
		{
			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1673C48", Offset = "0x1673C48", VA = "0x1673C48", Slot = "4")]
			public int Compare(object x, object y)
			{
				return default(int);
			}

			[Token(Token = "0x6000339")]
			[Address(RVA = "0x167355C", Offset = "0x167355C", VA = "0x167355C")]
			public RayHitComparer()
			{
			}
		}

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float clipMoveTime;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float returnTime;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float sphereCastRadius;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool visualiseInEditor;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float closestDistance;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0D18", Offset = "0xAF0D18")]
		private bool <protecting>k__BackingField;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string dontClipTag;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_Cam;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_Pivot;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float m_OriginalDist;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float m_MoveVelocity;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_CurrentDist;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Ray m_Ray;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit[] m_Hits;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RayHitComparer m_RayHitComparer;

		[Token(Token = "0x1700001D")]
		public bool protecting
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x1673470", Offset = "0x1673470", VA = "0x1673470")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1740", Offset = "0xAF1740")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x1673478", Offset = "0x1673478", VA = "0x1673478")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1750", Offset = "0xAF1750")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1673484", Offset = "0x1673484", VA = "0x1673484")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1673564", Offset = "0x1673564", VA = "0x1673564")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1673BD0", Offset = "0x1673BD0", VA = "0x1673BD0")]
		public ProtectCameraFromWallClip()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class TargetFieldOfView : AbstractTargetFollower
	{
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float m_FovAdjustTime;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float m_ZoomAmountMultiplier;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_IncludeEffectsInSize;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_BoundSize;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_FovAdjustVelocity;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Cam;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform m_LastTarget;

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1673D50", Offset = "0x1673D50", VA = "0x1673D50", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1673FA0", Offset = "0x1673FA0", VA = "0x1673FA0", Slot = "5")]
		protected override void FollowTarget(float deltaTime)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x167411C", Offset = "0x167411C", VA = "0x167411C", Slot = "6")]
		public override void SetTarget(Transform newTransform)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1673DC0", Offset = "0x1673DC0", VA = "0x1673DC0")]
		public static float MaxBoundsExtent(Transform obj, bool includeEffects)
		{
			return default(float);
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x167414C", Offset = "0x167414C", VA = "0x167414C")]
		public TargetFieldOfView()
		{
		}
	}
}
namespace UnityStandardAssets.ImageEffects
{
	[Token(Token = "0x2000044")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFB24", Offset = "0xAEFB24")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFB24", Offset = "0xAEFB24")]
	public class Bloom : PostEffectsBase
	{
		[Token(Token = "0x2000085")]
		public enum LensFlareStyle
		{
			[Token(Token = "0x40002D9")]
			Ghosting,
			[Token(Token = "0x40002DA")]
			Anamorphic,
			[Token(Token = "0x40002DB")]
			Combined
		}

		[Token(Token = "0x2000086")]
		public enum TweakMode
		{
			[Token(Token = "0x40002DD")]
			Basic,
			[Token(Token = "0x40002DE")]
			Complex
		}

		[Token(Token = "0x2000087")]
		public enum HDRBloomMode
		{
			[Token(Token = "0x40002E0")]
			Auto,
			[Token(Token = "0x40002E1")]
			On,
			[Token(Token = "0x40002E2")]
			Off
		}

		[Token(Token = "0x2000088")]
		public enum BloomScreenBlendMode
		{
			[Token(Token = "0x40002E4")]
			Screen,
			[Token(Token = "0x40002E5")]
			Add
		}

		[Token(Token = "0x2000089")]
		public enum BloomQuality
		{
			[Token(Token = "0x40002E7")]
			Cheap,
			[Token(Token = "0x40002E8")]
			High
		}

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public TweakMode tweakMode;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BloomScreenBlendMode screenBlendMode;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public HDRBloomMode hdr;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool doHdr;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float sepBlurSpread;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public BloomQuality quality;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float bloomIntensity;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float bloomThreshold;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color bloomThresholdColor;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int bloomBlurIterations;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float flareRotation;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LensFlareStyle lensflareMode;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float hollyStretchWidth;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float lensflareIntensity;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float lensflareThreshold;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float lensFlareSaturation;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Color flareColorA;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color flareColorB;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public Color flareColorC;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Color flareColorD;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Texture2D lensFlareVignetteMask;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Shader lensFlareShader;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Material lensFlareMaterial;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Shader screenBlendShader;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Material screenBlend;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public Shader blurAndFlaresShader;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Material blurAndFlaresMaterial;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Shader brightPassFilterShader;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Material brightPassFilterMaterial;

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x167B9D4", Offset = "0x167B9D4", VA = "0x167B9D4", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x167BFA0", Offset = "0x167BFA0", VA = "0x167BFA0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x167D35C", Offset = "0x167D35C", VA = "0x167D35C")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x167D15C", Offset = "0x167D15C", VA = "0x167D15C")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x167CE64", Offset = "0x167CE64", VA = "0x167CE64")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x167CD80", Offset = "0x167CD80", VA = "0x167CD80")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x167CF50", Offset = "0x167CF50", VA = "0x167CF50")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x167D424", Offset = "0x167D424", VA = "0x167D424")]
		public Bloom()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFBBC", Offset = "0xAEFBBC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFBBC", Offset = "0xAEFBBC")]
	public class ImageEffectBase : MonoBehaviour
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Shader shader;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x1700001E")]
		protected Material material
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x167D630", Offset = "0x167D630", VA = "0x167D630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x167D580", Offset = "0x167D580", VA = "0x167D580", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x167D6F4", Offset = "0x167D6F4", VA = "0x167D6F4", Slot = "5")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x167D7A4", Offset = "0x167D7A4", VA = "0x167D7A4")]
		public ImageEffectBase()
		{
		}
	}
	[Token(Token = "0x2000046")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFC44", Offset = "0xAEFC44")]
	public class ImageEffects
	{
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x167D7AC", Offset = "0x167D7AC", VA = "0x167D7AC")]
		public static void RenderDistortion(Material material, RenderTexture source, RenderTexture destination, float angle, Vector2 center, Vector2 radius)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x167DA28", Offset = "0x167DA28", VA = "0x167DA28")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAF1760", Offset = "0xAF1760")]
		public static void Blit(RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x167DAA0", Offset = "0x167DAA0", VA = "0x167DAA0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xAF1798", Offset = "0xAF1798")]
		public static void BlitWithMaterial(Material material, RenderTexture source, RenderTexture dest)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x167DB20", Offset = "0x167DB20", VA = "0x167DB20")]
		public ImageEffects()
		{
		}
	}
	[Token(Token = "0x2000047")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFC7C", Offset = "0xAEFC7C")]
	public class PostEffectsBase : MonoBehaviour
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected bool supportHDRTextures;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		protected bool supportDX11;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		protected bool isSupported;

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x167BB64", Offset = "0x167BB64", VA = "0x167BB64")]
		protected Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x167DB54", Offset = "0x167DB54", VA = "0x167DB54")]
		protected Material CreateMaterial(Shader s, Material m2Create)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x167DD44", Offset = "0x167DD44", VA = "0x167DD44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x167DD50", Offset = "0x167DD50", VA = "0x167DD50")]
		protected bool CheckSupport()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x167DD58", Offset = "0x167DD58", VA = "0x167DD58", Slot = "4")]
		public virtual bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x167DE08", Offset = "0x167DE08", VA = "0x167DE08")]
		protected void Start()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x167BA5C", Offset = "0x167BA5C", VA = "0x167BA5C")]
		protected bool CheckSupport(bool needDepth)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x167DE14", Offset = "0x167DE14", VA = "0x167DE14")]
		protected bool CheckSupport(bool needDepth, bool needHdr)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x167DE70", Offset = "0x167DE70", VA = "0x167DE70")]
		public bool Dx11Support()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x167BEF8", Offset = "0x167BEF8", VA = "0x167BEF8")]
		protected void ReportAutoDisable()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x167DE78", Offset = "0x167DE78", VA = "0x167DE78")]
		private bool CheckShader(Shader s)
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x167DB28", Offset = "0x167DB28", VA = "0x167DB28")]
		protected void NotSupported()
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x167E078", Offset = "0x167E078", VA = "0x167E078")]
		protected void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x167D56C", Offset = "0x167D56C", VA = "0x167D56C")]
		public PostEffectsBase()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFCF0", Offset = "0xAEFCF0")]
	internal class PostEffectsHelper : MonoBehaviour
	{
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x167E3F4", Offset = "0x167E3F4", VA = "0x167E3F4")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x167E460", Offset = "0x167E460", VA = "0x167E460")]
		private static void DrawLowLevelPlaneAlignedWithCamera(float dist, RenderTexture source, RenderTexture dest, Material material, Camera cameraForProjectionMatrix)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x167E6DC", Offset = "0x167E6DC", VA = "0x167E6DC")]
		private static void DrawBorder(RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x167EA54", Offset = "0x167EA54", VA = "0x167EA54")]
		private static void DrawLowLevelQuad(float x1, float x2, float y1, float y2, RenderTexture source, RenderTexture dest, Material material)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x167EC00", Offset = "0x167EC00", VA = "0x167EC00")]
		public PostEffectsHelper()
		{
		}
	}
	[Token(Token = "0x2000049")]
	internal class Quads
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentQuads;

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x167EC08", Offset = "0x167EC08", VA = "0x167EC08")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x167ED2C", Offset = "0x167ED2C", VA = "0x167ED2C")]
		public static void Cleanup()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x167EEFC", Offset = "0x167EEFC", VA = "0x167EEFC")]
		public static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x167F1BC", Offset = "0x167F1BC", VA = "0x167F1BC")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x167F6F0", Offset = "0x167F6F0", VA = "0x167F6F0")]
		public Quads()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFD64", Offset = "0xAEFD64")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFD64", Offset = "0xAEFD64")]
	public class ScreenOverlay : PostEffectsBase
	{
		[Token(Token = "0x200008A")]
		public enum OverlayBlendMode
		{
			[Token(Token = "0x40002EA")]
			Additive,
			[Token(Token = "0x40002EB")]
			ScreenBlend,
			[Token(Token = "0x40002EC")]
			Multiply,
			[Token(Token = "0x40002ED")]
			Overlay,
			[Token(Token = "0x40002EE")]
			AlphaBlend
		}

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public OverlayBlendMode blendMode;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float intensity;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture2D texture;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Shader overlayShader;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Material overlayMaterial;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2016098", Offset = "0x2016098", VA = "0x2016098", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x20160FC", Offset = "0x20160FC", VA = "0x20160FC")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2016264", Offset = "0x2016264", VA = "0x2016264")]
		public ScreenOverlay()
		{
		}
	}
	[Token(Token = "0x200004B")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFDFC", Offset = "0xAEFDFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFDFC", Offset = "0xAEFDFC")]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0D58", Offset = "0xAF0D58")]
		public float intensity;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0D70", Offset = "0xAF0D70")]
		public float radius;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0D8C", Offset = "0xAF0D8C")]
		public int blurIterations;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0DA4", Offset = "0xAF0DA4")]
		public float blurFilterDistance;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0DBC", Offset = "0xAF0DBC")]
		public int downsample;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Texture2D rand;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader aoShader;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material aoMaterial;

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2016278", Offset = "0x2016278", VA = "0x2016278", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x20162DC", Offset = "0x20162DC", VA = "0x20162DC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2016384", Offset = "0x2016384", VA = "0x2016384")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x2016958", Offset = "0x2016958", VA = "0x2016958")]
		public ScreenSpaceAmbientObscurance()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFE94", Offset = "0xAEFE94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xAEFE94", Offset = "0xAEFE94")]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200008B")]
		public enum SSAOSamples
		{
			[Token(Token = "0x40002F0")]
			Low,
			[Token(Token = "0x40002F1")]
			Medium,
			[Token(Token = "0x40002F2")]
			High
		}

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float m_Radius;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public SSAOSamples m_SampleCount;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_OcclusionIntensity;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int m_Blur;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int m_Downsampling;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_OcclusionAttenuation;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_MinZ;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Shader m_SSAOShader;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Material m_SSAOMaterial;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture2D m_RandomTexture;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_Supported;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2016978", Offset = "0x2016978", VA = "0x2016978")]
		private static Material CreateMaterial(Shader shader)
		{
			return null;
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2016A28", Offset = "0x2016A28", VA = "0x2016A28")]
		private static void DestroyMaterial(Material mat)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2016AC4", Offset = "0x2016AC4", VA = "0x2016AC4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2016ACC", Offset = "0x2016ACC", VA = "0x2016ACC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2016C60", Offset = "0x2016C60", VA = "0x2016C60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x2016BA4", Offset = "0x2016BA4", VA = "0x2016BA4")]
		private void CreateMaterials()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x2016CD4", Offset = "0x2016CD4", VA = "0x2016CD4")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x2017390", Offset = "0x2017390", VA = "0x2017390")]
		public ScreenSpaceAmbientOcclusion()
		{
		}
	}
	[Token(Token = "0x200004D")]
	internal class Triangles
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh[] meshes;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int currentTris;

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x20173C4", Offset = "0x20173C4", VA = "0x20173C4")]
		private static bool HasMeshes()
		{
			return default(bool);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2017500", Offset = "0x2017500", VA = "0x2017500")]
		private static void Cleanup()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x20176D0", Offset = "0x20176D0", VA = "0x20176D0")]
		private static Mesh[] GetMeshes(int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2017990", Offset = "0x2017990", VA = "0x2017990")]
		private static Mesh GetMesh(int triCount, int triOffset, int totalWidth, int totalHeight)
		{
			return null;
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2017DC0", Offset = "0x2017DC0", VA = "0x2017DC0")]
		public Triangles()
		{
		}
	}
}
namespace RPGCharacterAnims
{
	[Token(Token = "0x200004E")]
	public class GUIControlsFREE : MonoBehaviour
	{
		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RPGCharacterControllerFREE rpgCharacterController;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RPGCharacterMovementControllerFREE rpgCharacterMovementController;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool useNavAgent;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x15C16D4", Offset = "0x15C16D4", VA = "0x15C16D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x15C1744", Offset = "0x15C1744", VA = "0x15C1744")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x15C2868", Offset = "0x15C2868", VA = "0x15C2868")]
		public GUIControlsFREE()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class IKHandsFREE : MonoBehaviour
	{
		[Token(Token = "0x200008C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00E0", Offset = "0xAF00E0")]
		private sealed class <_BlendIK>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int weapon;

			[Token(Token = "0x40002F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IKHandsFREE <>4__this;

			[Token(Token = "0x40002F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float delay;

			[Token(Token = "0x40002F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool blendOn;

			[Token(Token = "0x40002F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float timeToBlend;

			[Token(Token = "0x40002FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <t>5__2;

			[Token(Token = "0x40002FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <blendTo>5__3;

			[Token(Token = "0x40002FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <blendFrom>5__4;

			[Token(Token = "0x17000043")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600033D")]
				[Address(RVA = "0x15C2CD4", Offset = "0x15C2CD4", VA = "0x15C2CD4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000044")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033F")]
				[Address(RVA = "0x15C2D3C", Offset = "0x15C2D3C", VA = "0x15C2D3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x15C2A88", Offset = "0x15C2A88", VA = "0x15C2A88")]
			[DebuggerHidden]
			public <_BlendIK>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600033B")]
			[Address(RVA = "0x15C2B1C", Offset = "0x15C2B1C", VA = "0x15C2B1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600033C")]
			[Address(RVA = "0x15C2B20", Offset = "0x15C2B20", VA = "0x15C2B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033E")]
			[Address(RVA = "0x15C2CDC", Offset = "0x15C2CDC", VA = "0x15C2CDC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RPGCharacterWeaponControllerFREE rpgCharacterWeaponController;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHandObj;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform attachLeft;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0DD4", Offset = "0xAF0DD4")]
		public float leftHandPositionWeight;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAF0DEC", Offset = "0xAF0DEC")]
		public float leftHandRotationWeight;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform blendToTransform;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x15C2870", Offset = "0x15C2870", VA = "0x15C2870")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x15C28E0", Offset = "0x15C28E0", VA = "0x15C28E0")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x15C29E4", Offset = "0x15C29E4", VA = "0x15C29E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF17F0", Offset = "0xAF17F0")]
		public IEnumerator _BlendIK(bool blendOn, float delay, float timeToBlend, int weapon)
		{
			return null;
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x15C2AB4", Offset = "0x15C2AB4", VA = "0x15C2AB4")]
		private void GetCurrentWeaponAttachPoint(int weapon)
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x15C2B14", Offset = "0x15C2B14", VA = "0x15C2B14")]
		public IKHandsFREE()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFF2C", Offset = "0xAEFF2C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFF2C", Offset = "0xAEFF2C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAEFF2C", Offset = "0xAEFF2C")]
	public class RPGCharacterControllerFREE : MonoBehaviour
	{
		[Token(Token = "0x200008D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF00F0", Offset = "0xAF00F0")]
		private sealed class <_Turning>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int direction;

			[Token(Token = "0x4000300")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RPGCharacterControllerFREE <>4__this;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000343")]
				[Address(RVA = "0x15C47DC", Offset = "0x15C47DC", VA = "0x15C47DC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000345")]
				[Address(RVA = "0x15C4844", Offset = "0x15C4844", VA = "0x15C4844", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000340")]
			[Address(RVA = "0x15C346C", Offset = "0x15C346C", VA = "0x15C346C")]
			[DebuggerHidden]
			public <_Turning>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000341")]
			[Address(RVA = "0x15C46C4", Offset = "0x15C46C4", VA = "0x15C46C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000342")]
			[Address(RVA = "0x15C46C8", Offset = "0x15C46C8", VA = "0x15C46C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000344")]
			[Address(RVA = "0x15C47E4", Offset = "0x15C47E4", VA = "0x15C47E4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0100", Offset = "0xAF0100")]
		private sealed class <_GetCurrentAnimationLength>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000301")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000302")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000303")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterControllerFREE <>4__this;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000349")]
				[Address(RVA = "0x15C43E8", Offset = "0x15C43E8", VA = "0x15C43E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034B")]
				[Address(RVA = "0x15C4450", Offset = "0x15C4450", VA = "0x15C4450", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000346")]
			[Address(RVA = "0x15C39E8", Offset = "0x15C39E8", VA = "0x15C39E8")]
			[DebuggerHidden]
			public <_GetCurrentAnimationLength>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x6000347")]
			[Address(RVA = "0x15C42D4", Offset = "0x15C42D4", VA = "0x15C42D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000348")]
			[Address(RVA = "0x15C42D8", Offset = "0x15C42D8", VA = "0x15C42D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x15C43F0", Offset = "0x15C43F0", VA = "0x15C43F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200008F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0110", Offset = "0xAF0110")]
		private sealed class <_Lock>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000305")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000306")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delayTime;

			[Token(Token = "0x4000307")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public bool lockMovement;

			[Token(Token = "0x4000308")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RPGCharacterControllerFREE <>4__this;

			[Token(Token = "0x4000309")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool lockAction;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool timed;

			[Token(Token = "0x400030B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lockTime;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x15C4654", Offset = "0x15C4654", VA = "0x15C4654", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000351")]
				[Address(RVA = "0x15C46BC", Offset = "0x15C46BC", VA = "0x15C46BC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x15C3AD0", Offset = "0x15C3AD0", VA = "0x15C3AD0")]
			[DebuggerHidden]
			public <_Lock>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x15C4458", Offset = "0x15C4458", VA = "0x15C4458", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x15C445C", Offset = "0x15C445C", VA = "0x15C445C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x15C465C", Offset = "0x15C465C", VA = "0x15C465C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public RPGCharacterMovementControllerFREE rpgCharacterMovementController;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public RPGCharacterWeaponControllerFREE rpgCharacterWeaponController;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public RPGCharacterInputControllerFREE rpgCharacterInputController;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public IKHandsFREE ikHands;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Weapon weapon;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public GameObject target;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public bool isDead;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[HideInInspector]
		public bool isBlocking;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[HideInInspector]
		public bool isStrafing;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		[HideInInspector]
		public bool canAction;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float animationSpeed;

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x15C2D44", Offset = "0x15C2D44", VA = "0x15C2D44")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x15C2F64", Offset = "0x15C2F64", VA = "0x15C2F64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x15C3044", Offset = "0x15C3044", VA = "0x15C3044")]
		private void Update()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x15C3310", Offset = "0x15C3310", VA = "0x15C3310")]
		private void UpdateAnimationSpeed()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x15C2138", Offset = "0x15C2138", VA = "0x15C2138")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1854", Offset = "0xAF1854")]
		public IEnumerator _Turning(int direction)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x15C21B8", Offset = "0x15C21B8", VA = "0x15C21B8")]
		public void Attack(int attackSide)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x15C23B0", Offset = "0x15C23B0", VA = "0x15C23B0")]
		public void AttackKick(int kickSide)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x15C3370", Offset = "0x15C3370", VA = "0x15C3370")]
		private void Strafing()
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x15C342C", Offset = "0x15C342C", VA = "0x15C342C")]
		private void Rolling()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x15C24B4", Offset = "0x15C24B4", VA = "0x15C24B4")]
		public void GetHit()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x15C2760", Offset = "0x15C2760", VA = "0x15C2760")]
		public void Death()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x15C27E8", Offset = "0x15C27E8", VA = "0x15C27E8")]
		public void Revive()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x15C38F0", Offset = "0x15C38F0", VA = "0x15C38F0")]
		private void LockAction()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x15C38F8", Offset = "0x15C38F8", VA = "0x15C38F8")]
		private void UnLock(bool movement, bool actions)
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x15C3964", Offset = "0x15C3964", VA = "0x15C3964")]
		public void Hit()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x15C3968", Offset = "0x15C3968", VA = "0x15C3968")]
		public void Shoot()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x15C396C", Offset = "0x15C396C", VA = "0x15C396C")]
		public void FootR()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x15C3970", Offset = "0x15C3970", VA = "0x15C3970")]
		public void FootL()
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x15C3974", Offset = "0x15C3974", VA = "0x15C3974")]
		public void Land()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x15C3978", Offset = "0x15C3978", VA = "0x15C3978")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF18B8", Offset = "0xAF18B8")]
		private IEnumerator _GetCurrentAnimationLength()
		{
			return null;
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x15C3498", Offset = "0x15C3498", VA = "0x15C3498")]
		public void Lock(bool lockMovement, bool lockAction, bool timed, float delayTime, float lockTime)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x15C3A14", Offset = "0x15C3A14", VA = "0x15C3A14")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF191C", Offset = "0xAF191C")]
		public IEnumerator _Lock(bool lockMovement, bool lockAction, bool timed, float delayTime, float lockTime)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x15C3AFC", Offset = "0x15C3AFC", VA = "0x15C3AFC")]
		private void SetAnimator(int weapon, int weaponSwitch, int Lweapon, int Rweapon, int weaponSide)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x15C3F1C", Offset = "0x15C3F1C", VA = "0x15C3F1C")]
		public void SetWeaponState(int weaponNumber)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x15C3F3C", Offset = "0x15C3F3C", VA = "0x15C3F3C")]
		public void AnimatorDebug()
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x15C42BC", Offset = "0x15C42BC", VA = "0x15C42BC")]
		public RPGCharacterControllerFREE()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public class RPGCharacterInputControllerFREE : MonoBehaviour
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool inputJump;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool inputLightHit;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool inputDeath;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[HideInInspector]
		public bool inputAttackL;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public bool inputAttackR;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		[HideInInspector]
		public bool inputSwitchUpDown;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		[HideInInspector]
		public bool inputStrafe;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public float inputAimVertical;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public float inputAimHorizontal;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public float inputHorizontal;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public float inputVertical;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[HideInInspector]
		public bool inputRoll;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[HideInInspector]
		public bool allowedInput;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[HideInInspector]
		public Vector3 moveInput;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public Vector2 aimInput;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x15C484C", Offset = "0x15C484C", VA = "0x15C484C")]
		private void Inputs()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x15C49C4", Offset = "0x15C49C4", VA = "0x15C49C4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x15C49D0", Offset = "0x15C49D0", VA = "0x15C49D0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x15C4A24", Offset = "0x15C4A24", VA = "0x15C4A24")]
		private Vector3 CameraRelativeInput(float inputX, float inputZ)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x15C4BB4", Offset = "0x15C4BB4", VA = "0x15C4BB4")]
		public bool HasAnyInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x15C4CBC", Offset = "0x15C4CBC", VA = "0x15C4CBC")]
		public bool HasMoveInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x15C4D74", Offset = "0x15C4D74", VA = "0x15C4D74")]
		public bool HasAimInput()
		{
			return default(bool);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x15C4DD0", Offset = "0x15C4DD0", VA = "0x15C4DD0")]
		public RPGCharacterInputControllerFREE()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public enum RPGCharacterStateFREE
	{
		[Token(Token = "0x4000206")]
		Idle = 0,
		[Token(Token = "0x4000207")]
		Move = 1,
		[Token(Token = "0x4000208")]
		Jump = 2,
		[Token(Token = "0x4000209")]
		DoubleJump = 3,
		[Token(Token = "0x400020A")]
		Fall = 4,
		[Token(Token = "0x400020B")]
		Block = 6,
		[Token(Token = "0x400020C")]
		Roll = 8
	}
	[Token(Token = "0x2000053")]
	public class RPGCharacterMovementControllerFREE : SuperStateMachine
	{
		[Token(Token = "0x2000090")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0120", Offset = "0xAF0120")]
		private sealed class <_Roll>d__55 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400030C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterMovementControllerFREE <>4__this;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int roll;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000355")]
				[Address(RVA = "0x1669FE4", Offset = "0x1669FE4", VA = "0x1669FE4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000357")]
				[Address(RVA = "0x166A04C", Offset = "0x166A04C", VA = "0x166A04C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x1669D90", Offset = "0x1669D90", VA = "0x1669D90")]
			[DebuggerHidden]
			public <_Roll>d__55(int <>1__state)
			{
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x1669DBC", Offset = "0x1669DBC", VA = "0x1669DBC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x1669DC0", Offset = "0x1669DC0", VA = "0x1669DC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000356")]
			[Address(RVA = "0x1669FEC", Offset = "0x1669FEC", VA = "0x1669FEC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000091")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0130", Offset = "0xAF0130")]
		private sealed class <_Knockback>d__62 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterMovementControllerFREE <>4__this;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 knockDirection;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int knockBackAmount;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int variableAmount;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x1669B64", Offset = "0x1669B64", VA = "0x1669B64", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600035D")]
				[Address(RVA = "0x1669BCC", Offset = "0x1669BCC", VA = "0x1669BCC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000358")]
			[Address(RVA = "0x1669A48", Offset = "0x1669A48", VA = "0x1669A48")]
			[DebuggerHidden]
			public <_Knockback>d__62(int <>1__state)
			{
			}

			[Token(Token = "0x6000359")]
			[Address(RVA = "0x1669A74", Offset = "0x1669A74", VA = "0x1669A74", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600035A")]
			[Address(RVA = "0x1669A78", Offset = "0x1669A78", VA = "0x1669A78", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600035C")]
			[Address(RVA = "0x1669B6C", Offset = "0x1669B6C", VA = "0x1669B6C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000092")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0140", Offset = "0xAF0140")]
		private sealed class <_KnockbackForce>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000317")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000318")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterMovementControllerFREE <>4__this;

			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 knockDirection;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int knockBackAmount;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int variableAmount;

			[Token(Token = "0x1700004F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x1669D20", Offset = "0x1669D20", VA = "0x1669D20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000050")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x1669D88", Offset = "0x1669D88", VA = "0x1669D88", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600035E")]
			[Address(RVA = "0x1669BD4", Offset = "0x1669BD4", VA = "0x1669BD4")]
			[DebuggerHidden]
			public <_KnockbackForce>d__63(int <>1__state)
			{
			}

			[Token(Token = "0x600035F")]
			[Address(RVA = "0x1669C00", Offset = "0x1669C00", VA = "0x1669C00", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000360")]
			[Address(RVA = "0x1669C04", Offset = "0x1669C04", VA = "0x1669C04", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1669D28", Offset = "0x1669D28", VA = "0x1669D28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SuperCharacterController superCharacterController;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RPGCharacterControllerFREE rpgCharacterController;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public NavMeshAgent navMeshAgent;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private RPGCharacterInputControllerFREE rpgCharacterInputController;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rb;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Animator animator;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public RPGCharacterStateFREE rpgCharacterState;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[HideInInspector]
		public bool useMeshNav;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0FA4", Offset = "0xAF0FA4")]
		private Vector3 <lookDirection>k__BackingField;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[HideInInspector]
		public bool isKnockback;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float knockbackMultiplier;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[HideInInspector]
		public bool canJump;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		[HideInInspector]
		public bool canDoubleJump;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		private bool doublejumped;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float gravity;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float jumpAcceleration;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float jumpHeight;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float doubleJumpHeight;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 currentVelocity;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[HideInInspector]
		public bool isMoving;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[HideInInspector]
		public bool canMove;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float movementAcceleration;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float walkSpeed;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float runSpeed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float rotationSpeed;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float groundFriction;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[HideInInspector]
		public bool isRolling;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float rollSpeed;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float rollduration;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int rollNumber;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float inAirSpeed;

		[Token(Token = "0x1700001F")]
		[HideInInspector]
		public Vector3 lookDirection
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x15C4DE0", Offset = "0x15C4DE0", VA = "0x15C4DE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1980", Offset = "0xAF1980")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x15C4DEC", Offset = "0x15C4DEC", VA = "0x15C4DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF1990", Offset = "0xAF1990")]
			private set
			{
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x15C4DF8", Offset = "0x15C4DF8", VA = "0x15C4DF8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x15C4F4C", Offset = "0x15C4F4C", VA = "0x15C4F4C", Slot = "4")]
		protected override void EarlyGlobalSuperUpdate()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x15C4F50", Offset = "0x15C4F50", VA = "0x15C4F50", Slot = "5")]
		protected override void LateGlobalSuperUpdate()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x15C5524", Offset = "0x15C5524", VA = "0x15C5524")]
		private bool AcquiringGround()
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x15C2088", Offset = "0x15C2088", VA = "0x15C2088")]
		public bool MaintainingGround()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x15BE5B0", Offset = "0x15BE5B0", VA = "0x15BE5B0")]
		public void RotateGravity(Vector3 up)
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x15C5558", Offset = "0x15C5558", VA = "0x15C5558")]
		private Vector3 LocalMovement()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x15C5578", Offset = "0x15C5578", VA = "0x15C5578")]
		private float CalculateJumpSpeed(float jumpHeight, float gravity)
		{
			return default(float);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x15C560C", Offset = "0x15C560C", VA = "0x15C560C")]
		private void Idle_EnterState()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x15C5698", Offset = "0x15C5698", VA = "0x15C5698")]
		private void Idle_SuperUpdate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x15C5800", Offset = "0x15C5800", VA = "0x15C5800")]
		private void Idle_ExitState()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x15C5804", Offset = "0x15C5804", VA = "0x15C5804")]
		private void Move_SuperUpdate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x15C5AB4", Offset = "0x15C5AB4", VA = "0x15C5AB4")]
		private void Jump_EnterState()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x15C5C4C", Offset = "0x15C5C4C", VA = "0x15C5C4C")]
		private void Jump_SuperUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x15C5FDC", Offset = "0x15C5FDC", VA = "0x15C5FDC")]
		private void DoubleJump_EnterState()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x15C6114", Offset = "0x15C6114", VA = "0x15C6114")]
		private void DoubleJump_SuperUpdate()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x15C5F34", Offset = "0x15C5F34", VA = "0x15C5F34")]
		private void DoubleJump()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x15C6118", Offset = "0x15C6118", VA = "0x15C6118")]
		private void Fall_EnterState()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x15C61C8", Offset = "0x15C61C8", VA = "0x15C61C8")]
		private void Fall_SuperUpdate()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x15C6374", Offset = "0x15C6374", VA = "0x15C6374")]
		private void Roll_SuperUpdate()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x15C3544", Offset = "0x15C3544", VA = "0x15C3544")]
		public void DirectionalRoll()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x15C20B8", Offset = "0x15C20B8", VA = "0x15C20B8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF19A0", Offset = "0xAF19A0")]
		public IEnumerator _Roll(int roll)
		{
			return null;
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x15C66A0", Offset = "0x15C66A0", VA = "0x15C66A0")]
		public void SwitchCollisionOff()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x15C2F7C", Offset = "0x15C2F7C", VA = "0x15C2F7C")]
		public void SwitchCollisionOn()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x15C5274", Offset = "0x15C5274", VA = "0x15C5274")]
		private void RotateTowardsMovementDir()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x15C6764", Offset = "0x15C6764", VA = "0x15C6764")]
		private void RotateTowardsTarget(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x15C6978", Offset = "0x15C6978", VA = "0x15C6978")]
		private void Aiming()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x15C5430", Offset = "0x15C5430", VA = "0x15C5430")]
		private void Strafing(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x15C3848", Offset = "0x15C3848", VA = "0x15C3848")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1A04", Offset = "0xAF1A04")]
		public IEnumerator _Knockback(Vector3 knockDirection, int knockBackAmount, int variableAmount)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x15C6D24", Offset = "0x15C6D24", VA = "0x15C6D24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1A68", Offset = "0xAF1A68")]
		private IEnumerator _KnockbackForce(Vector3 knockDirection, int knockBackAmount, int variableAmount)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x15C45A0", Offset = "0x15C45A0", VA = "0x15C45A0")]
		public void LockMovement()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x15C3938", Offset = "0x15C3938", VA = "0x15C3938")]
		public void UnlockMovement()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x15C6DCC", Offset = "0x15C6DCC", VA = "0x15C6DCC")]
		public RPGCharacterMovementControllerFREE()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public enum Weapon
	{
		[Token(Token = "0x400022D")]
		UNARMED = 0,
		[Token(Token = "0x400022E")]
		TWOHANDSWORD = 1,
		[Token(Token = "0x400022F")]
		TWOHANDSPEAR = 2,
		[Token(Token = "0x4000230")]
		TWOHANDAXE = 3,
		[Token(Token = "0x4000231")]
		TWOHANDBOW = 4,
		[Token(Token = "0x4000232")]
		TWOHANDCROSSBOW = 5,
		[Token(Token = "0x4000233")]
		STAFF = 6,
		[Token(Token = "0x4000234")]
		ARMED = 7,
		[Token(Token = "0x4000235")]
		RELAX = 8,
		[Token(Token = "0x4000236")]
		RIFLE = 9,
		[Token(Token = "0x4000237")]
		SHIELD = 11,
		[Token(Token = "0x4000238")]
		ARMEDSHIELD = 12
	}
	[Token(Token = "0x2000055")]
	public class RPGCharacterWeaponControllerFREE : MonoBehaviour
	{
		[Token(Token = "0x2000093")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0150", Offset = "0xAF0150")]
		private sealed class <_SwitchWeapon>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400031E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x400031F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int weaponNumber;

			[Token(Token = "0x17000051")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000367")]
				[Address(RVA = "0x166B504", Offset = "0x166B504", VA = "0x166B504", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000052")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000369")]
				[Address(RVA = "0x166B56C", Offset = "0x166B56C", VA = "0x166B56C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000364")]
			[Address(RVA = "0x166A1F0", Offset = "0x166A1F0", VA = "0x166A1F0")]
			[DebuggerHidden]
			public <_SwitchWeapon>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x166B33C", Offset = "0x166B33C", VA = "0x166B33C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x166B340", Offset = "0x166B340", VA = "0x166B340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000368")]
			[Address(RVA = "0x166B50C", Offset = "0x166B50C", VA = "0x166B50C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000094")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0160", Offset = "0xAF0160")]
		private sealed class <_UnSheathWeapon>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000320")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000321")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000322")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x4000323")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int weaponNumber;

			[Token(Token = "0x17000053")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x166B784", Offset = "0x166B784", VA = "0x166B784", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000054")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600036F")]
				[Address(RVA = "0x166B7EC", Offset = "0x166B7EC", VA = "0x166B7EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600036A")]
			[Address(RVA = "0x166A29C", Offset = "0x166A29C", VA = "0x166A29C")]
			[DebuggerHidden]
			public <_UnSheathWeapon>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x600036B")]
			[Address(RVA = "0x166B574", Offset = "0x166B574", VA = "0x166B574", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600036C")]
			[Address(RVA = "0x166B578", Offset = "0x166B578", VA = "0x166B578", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600036E")]
			[Address(RVA = "0x166B78C", Offset = "0x166B78C", VA = "0x166B78C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000095")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0170", Offset = "0xAF0170")]
		private sealed class <_SheathWeapon>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000324")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000325")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000326")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int weaponTo;

			[Token(Token = "0x4000327")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x4000328")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int weaponNumber;

			[Token(Token = "0x17000055")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x166B2CC", Offset = "0x166B2CC", VA = "0x166B2CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000056")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000375")]
				[Address(RVA = "0x166B334", Offset = "0x166B334", VA = "0x166B334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000370")]
			[Address(RVA = "0x166A350", Offset = "0x166A350", VA = "0x166A350")]
			[DebuggerHidden]
			public <_SheathWeapon>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000371")]
			[Address(RVA = "0x166B064", Offset = "0x166B064", VA = "0x166B064", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000372")]
			[Address(RVA = "0x166B068", Offset = "0x166B068", VA = "0x166B068", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000374")]
			[Address(RVA = "0x166B2D4", Offset = "0x166B2D4", VA = "0x166B2D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000096")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0180", Offset = "0xAF0180")]
		private sealed class <_InstantWeaponSwitch>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000329")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x400032C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int weaponNumber;

			[Token(Token = "0x17000057")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000379")]
				[Address(RVA = "0x166AFF4", Offset = "0x166AFF4", VA = "0x166AFF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000058")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600037B")]
				[Address(RVA = "0x166B05C", Offset = "0x166B05C", VA = "0x166B05C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x166A3FC", Offset = "0x166A3FC", VA = "0x166A3FC")]
			[DebuggerHidden]
			public <_InstantWeaponSwitch>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000377")]
			[Address(RVA = "0x166AE9C", Offset = "0x166AE9C", VA = "0x166AE9C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000378")]
			[Address(RVA = "0x166AEA0", Offset = "0x166AEA0", VA = "0x166AEA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600037A")]
			[Address(RVA = "0x166AFFC", Offset = "0x166AFFC", VA = "0x166AFFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0190", Offset = "0xAF0190")]
		private sealed class <_HideAllWeapons>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400032D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool timed;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool resetToUnarmed;

			[Token(Token = "0x17000059")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x166AE2C", Offset = "0x166AE2C", VA = "0x166AE2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x166AE94", Offset = "0x166AE94", VA = "0x166AE94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600037C")]
			[Address(RVA = "0x166A81C", Offset = "0x166A81C", VA = "0x166A81C")]
			[DebuggerHidden]
			public <_HideAllWeapons>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600037D")]
			[Address(RVA = "0x166AC70", Offset = "0x166AC70", VA = "0x166AC70", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600037E")]
			[Address(RVA = "0x166AC74", Offset = "0x166AC74", VA = "0x166AC74", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x166AE34", Offset = "0x166AE34", VA = "0x166AE34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000098")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01A0", Offset = "0xAF01A0")]
		private sealed class <_WeaponVisibility>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RPGCharacterWeaponControllerFREE <>4__this;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int weaponNumber;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public bool visible;

			[Token(Token = "0x1700005B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000385")]
				[Address(RVA = "0x166B888", Offset = "0x166B888", VA = "0x166B888", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000387")]
				[Address(RVA = "0x166B8F0", Offset = "0x166B8F0", VA = "0x166B8F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x166AC28", Offset = "0x166AC28", VA = "0x166AC28")]
			[DebuggerHidden]
			public <_WeaponVisibility>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000383")]
			[Address(RVA = "0x166B7F4", Offset = "0x166B7F4", VA = "0x166B7F4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000384")]
			[Address(RVA = "0x166B7F8", Offset = "0x166B7F8", VA = "0x166B7F8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000386")]
			[Address(RVA = "0x166B890", Offset = "0x166B890", VA = "0x166B890", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RPGCharacterControllerFREE rpgCharacterController;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public int leftWeapon;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public bool isSwitchingFinished;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[HideInInspector]
		public bool isWeaponSwitching;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
		[HideInInspector]
		public bool instantWeaponSwitch;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject twoHandSword;

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x166A054", Offset = "0x166A054", VA = "0x166A054")]
		private void Awake()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x166A170", Offset = "0x166A170", VA = "0x166A170")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1ACC", Offset = "0xAF1ACC")]
		public IEnumerator _SwitchWeapon(int weaponNumber)
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x166A21C", Offset = "0x166A21C", VA = "0x166A21C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1B30", Offset = "0xAF1B30")]
		public IEnumerator _UnSheathWeapon(int weaponNumber)
		{
			return null;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x166A2C8", Offset = "0x166A2C8", VA = "0x166A2C8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1B94", Offset = "0xAF1B94")]
		public IEnumerator _SheathWeapon(int weaponNumber, int weaponTo)
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x166A37C", Offset = "0x166A37C", VA = "0x166A37C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1BF8", Offset = "0xAF1BF8")]
		private IEnumerator _InstantWeaponSwitch(int weaponNumber)
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x166A428", Offset = "0x166A428", VA = "0x166A428")]
		private void DoWeaponSwitch(int weaponSwitch, int weaponVisibility, int weaponNumber, int leftRight, bool sheath)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x166A784", Offset = "0x166A784", VA = "0x166A784")]
		public void SwitchWeaponTwoHand(int upDown)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x166A80C", Offset = "0x166A80C", VA = "0x166A80C")]
		public void WeaponSwitch()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x166A0E0", Offset = "0x166A0E0", VA = "0x166A0E0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1C5C", Offset = "0xAF1C5C")]
		public IEnumerator _HideAllWeapons(bool timed, bool resetToUnarmed)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x166A848", Offset = "0x166A848", VA = "0x166A848")]
		private void SetAnimator(int weapon, int weaponSwitch, int Lweapon, int Rweapon, int weaponSide)
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x166A6F8", Offset = "0x166A6F8", VA = "0x166A6F8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAF1CC0", Offset = "0xAF1CC0")]
		public IEnumerator _WeaponVisibility(int weaponNumber, bool visible, bool dual)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x166AC54", Offset = "0x166AC54", VA = "0x166AC54")]
		public bool IsNoWeapon(int weaponNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x166A6D0", Offset = "0x166A6D0", VA = "0x166A6D0")]
		public bool Is2HandedWeapon(int weaponNumber)
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x166AC60", Offset = "0x166AC60", VA = "0x166AC60")]
		public RPGCharacterWeaponControllerFREE()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000056")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000099")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01B0", Offset = "0xAF01B0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000388")]
			[Address(RVA = "0x15B3FA8", Offset = "0x15B3FA8", VA = "0x15B3FA8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000389")]
			[Address(RVA = "0x15B4768", Offset = "0x15B4768", VA = "0x15B4768")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600038A")]
			[Address(RVA = "0x15B4784", Offset = "0x15B4784", VA = "0x15B4784")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200009A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01C0", Offset = "0xAF01C0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x600038B")]
			[Address(RVA = "0x15B40EC", Offset = "0x15B40EC", VA = "0x15B40EC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600038C")]
			[Address(RVA = "0x15B47A0", Offset = "0x15B47A0", VA = "0x15B47A0")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x15B47BC", Offset = "0x15B47BC", VA = "0x15B47BC")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200009B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01D0", Offset = "0xAF01D0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x15B4234", Offset = "0x15B4234", VA = "0x15B4234")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x15B47D8", Offset = "0x15B47D8", VA = "0x15B47D8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000390")]
			[Address(RVA = "0x15B4818", Offset = "0x15B4818", VA = "0x15B4818")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x15B3E44", Offset = "0x15B3E44", VA = "0x15B3E44")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x15B3FB0", Offset = "0x15B3FB0", VA = "0x15B3FB0")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x15B40F4", Offset = "0x15B40F4", VA = "0x15B40F4")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x15B423C", Offset = "0x15B423C", VA = "0x15B423C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x15B42B4", Offset = "0x15B42B4", VA = "0x15B42B4")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x15B432C", Offset = "0x15B432C", VA = "0x15B432C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x15B4394", Offset = "0x15B4394", VA = "0x15B4394")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x15B441C", Offset = "0x15B441C", VA = "0x15B441C")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x15B4484", Offset = "0x15B4484", VA = "0x15B4484")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x15B44EC", Offset = "0x15B44EC", VA = "0x15B44EC")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x15B4554", Offset = "0x15B4554", VA = "0x15B4554")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x15B45BC", Offset = "0x15B45BC", VA = "0x15B45BC")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x15B462C", Offset = "0x15B462C", VA = "0x15B462C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x15B4698", Offset = "0x15B4698", VA = "0x15B4698")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x15B4700", Offset = "0x15B4700", VA = "0x15B4700")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000057")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x200009C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01E0", Offset = "0xAF01E0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x15B49AC", Offset = "0x15B49AC", VA = "0x15B49AC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000392")]
			[Address(RVA = "0x15B5D48", Offset = "0x15B5D48", VA = "0x15B5D48")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200009D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF01F0", Offset = "0xAF01F0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x15B4B3C", Offset = "0x15B4B3C", VA = "0x15B4B3C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x15B5E84", Offset = "0x15B5E84", VA = "0x15B5E84")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200009E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0200", Offset = "0xAF0200")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x15B4CCC", Offset = "0x15B4CCC", VA = "0x15B4CCC")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000396")]
			[Address(RVA = "0x15B5EA0", Offset = "0x15B5EA0", VA = "0x15B5EA0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200009F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0210", Offset = "0xAF0210")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x15B4E5C", Offset = "0x15B4E5C", VA = "0x15B4E5C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000398")]
			[Address(RVA = "0x15B5EBC", Offset = "0x15B5EBC", VA = "0x15B5EBC")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0220", Offset = "0xAF0220")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000399")]
			[Address(RVA = "0x15B4FD0", Offset = "0x15B4FD0", VA = "0x15B4FD0")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600039A")]
			[Address(RVA = "0x15B5ED8", Offset = "0x15B5ED8", VA = "0x15B5ED8")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0230", Offset = "0xAF0230")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x15B51BC", Offset = "0x15B51BC", VA = "0x15B51BC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x15B5EF4", Offset = "0x15B5EF4", VA = "0x15B5EF4")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x20000A2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0240", Offset = "0xAF0240")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000344")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000345")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000346")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000347")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x15B5638", Offset = "0x15B5638", VA = "0x15B5638")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x15B5F10", Offset = "0x15B5F10", VA = "0x15B5F10")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600039F")]
			[Address(RVA = "0x15B5F2C", Offset = "0x15B5F2C", VA = "0x15B5F2C")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x15B5F60", Offset = "0x15B5F60", VA = "0x15B5F60")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x15B5F7C", Offset = "0x15B5F7C", VA = "0x15B5F7C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003A2")]
			[Address(RVA = "0x15B5F98", Offset = "0x15B5F98", VA = "0x15B5F98")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x20000A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0250", Offset = "0xAF0250")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000348")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60003A3")]
			[Address(RVA = "0x15B582C", Offset = "0x15B582C", VA = "0x15B582C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60003A4")]
			[Address(RVA = "0x15B6058", Offset = "0x15B6058", VA = "0x15B6058")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000A4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0260", Offset = "0xAF0260")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000349")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400034A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60003A5")]
			[Address(RVA = "0x15B5A34", Offset = "0x15B5A34", VA = "0x15B5A34")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60003A6")]
			[Address(RVA = "0x15B6074", Offset = "0x15B6074", VA = "0x15B6074")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003A7")]
			[Address(RVA = "0x15B6090", Offset = "0x15B6090", VA = "0x15B6090")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000A5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0270", Offset = "0xAF0270")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400034B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x15B5BB4", Offset = "0x15B5BB4", VA = "0x15B5BB4")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x15B6194", Offset = "0x15B6194", VA = "0x15B6194")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x20000A6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0280", Offset = "0xAF0280")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x400034C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x400034D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x15B5D40", Offset = "0x15B5D40", VA = "0x15B5D40")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x15B5D64", Offset = "0x15B5D64", VA = "0x15B5D64")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x15B5D80", Offset = "0x15B5D80", VA = "0x15B5D80")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x15B483C", Offset = "0x15B483C", VA = "0x15B483C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x15B49B4", Offset = "0x15B49B4", VA = "0x15B49B4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x15B4B44", Offset = "0x15B4B44", VA = "0x15B4B44")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x15B4CD4", Offset = "0x15B4CD4", VA = "0x15B4CD4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x15B4E64", Offset = "0x15B4E64", VA = "0x15B4E64")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x15B4FD8", Offset = "0x15B4FD8", VA = "0x15B4FD8")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x15B51C4", Offset = "0x15B51C4", VA = "0x15B51C4")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x15B5640", Offset = "0x15B5640", VA = "0x15B5640")]
		public static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x15B5834", Offset = "0x15B5834", VA = "0x15B5834")]
		public static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x15B5A3C", Offset = "0x15B5A3C", VA = "0x15B5A3C")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x15B5BBC", Offset = "0x15B5BBC", VA = "0x15B5BBC")]
		internal static TweenerCore<Vector3, Path, PathOptions> DOLocalPath(this Rigidbody target, Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x20000A7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0290", Offset = "0xAF0290")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400034E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x15B6318", Offset = "0x15B6318", VA = "0x15B6318")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x15B6AE0", Offset = "0x15B6AE0", VA = "0x15B6AE0")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000A8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02A0", Offset = "0xAF02A0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400034F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60003AF")]
			[Address(RVA = "0x15B6494", Offset = "0x15B6494", VA = "0x15B6494")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x15B6AFC", Offset = "0x15B6AFC", VA = "0x15B6AFC")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000A9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02B0", Offset = "0xAF02B0")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000350")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x15B6610", Offset = "0x15B6610", VA = "0x15B6610")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x15B6B18", Offset = "0x15B6B18", VA = "0x15B6B18")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000AA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02C0", Offset = "0xAF02C0")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000351")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x15B6758", Offset = "0x15B6758", VA = "0x15B6758")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x15B6B34", Offset = "0x15B6B34", VA = "0x15B6B34")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x20000AB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02D0", Offset = "0xAF02D0")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000352")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x4000353")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000354")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000355")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000356")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000357")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000358")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x15B6AD8", Offset = "0x15B6AD8", VA = "0x15B6AD8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x15B6B50", Offset = "0x15B6B50", VA = "0x15B6B50")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x15B6B6C", Offset = "0x15B6B6C", VA = "0x15B6B6C")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x15B6B88", Offset = "0x15B6B88", VA = "0x15B6B88")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x15B6BBC", Offset = "0x15B6BBC", VA = "0x15B6BBC")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x15B6BD8", Offset = "0x15B6BD8", VA = "0x15B6BD8")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x15B6BF4", Offset = "0x15B6BF4", VA = "0x15B6BF4")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x15B61B0", Offset = "0x15B61B0", VA = "0x15B61B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x15B6320", Offset = "0x15B6320", VA = "0x15B6320")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x15B649C", Offset = "0x15B649C", VA = "0x15B649C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x15B6618", Offset = "0x15B6618", VA = "0x15B6618")]
		public static TweenerCore<float, float, FloatOptions> DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x15B6760", Offset = "0x15B6760", VA = "0x15B6760")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x2000059")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x20000AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02E0", Offset = "0xAF02E0")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000359")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x15B6E80", Offset = "0x15B6E80", VA = "0x15B6E80")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x15B7390", Offset = "0x15B7390", VA = "0x15B7390")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x15B73AC", Offset = "0x15B73AC", VA = "0x15B73AC")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF02F0", Offset = "0xAF02F0")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400035A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x15B6FC4", Offset = "0x15B6FC4", VA = "0x15B6FC4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x15B73C8", Offset = "0x15B73C8", VA = "0x15B73C8")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x15B73E4", Offset = "0x15B73E4", VA = "0x15B73E4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0300", Offset = "0xAF0300")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400035B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400035C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x15B7388", Offset = "0x15B7388", VA = "0x15B7388")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x15B7400", Offset = "0x15B7400", VA = "0x15B7400")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x15B740C", Offset = "0x15B740C", VA = "0x15B740C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x15B6D1C", Offset = "0x15B6D1C", VA = "0x15B6D1C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x15B6E88", Offset = "0x15B6E88", VA = "0x15B6E88")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x15B6FCC", Offset = "0x15B6FCC", VA = "0x15B6FCC")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x15B71A4", Offset = "0x15B71A4", VA = "0x15B71A4")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200005A")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x20000AF")]
		public static class Utils
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x15BC2C4", Offset = "0x15BC2C4", VA = "0x15BC2C4")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x20000B0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0310", Offset = "0xAF0310")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400035D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x15B75F4", Offset = "0x15B75F4", VA = "0x15B75F4")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x15BB180", Offset = "0x15BB180", VA = "0x15BB180")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x15BB19C", Offset = "0x15BB19C", VA = "0x15BB19C")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000B1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0320", Offset = "0xAF0320")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400035E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x15B7760", Offset = "0x15B7760", VA = "0x15B7760")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x15BB3F0", Offset = "0x15BB3F0", VA = "0x15BB3F0")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x15BB414", Offset = "0x15BB414", VA = "0x15BB414")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0330", Offset = "0xAF0330")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400035F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x15B78A4", Offset = "0x15B78A4", VA = "0x15B78A4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x15BBA7C", Offset = "0x15BBA7C", VA = "0x15BBA7C")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x15BBAA0", Offset = "0x15BBAA0", VA = "0x15BBAA0")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0340", Offset = "0xAF0340")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000360")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x15B7A10", Offset = "0x15B7A10", VA = "0x15B7A10")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x15BBF68", Offset = "0x15BBF68", VA = "0x15BBF68")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x15BBF8C", Offset = "0x15BBF8C", VA = "0x15BBF8C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0350", Offset = "0xAF0350")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000361")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x15B7B54", Offset = "0x15B7B54", VA = "0x15B7B54")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x15BBFB0", Offset = "0x15BBFB0", VA = "0x15BBFB0")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x15BBFD4", Offset = "0x15BBFD4", VA = "0x15BBFD4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000B5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0360", Offset = "0xAF0360")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000362")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x15B7CBC", Offset = "0x15B7CBC", VA = "0x15B7CBC")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x15BBFF8", Offset = "0x15BBFF8", VA = "0x15BBFF8")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x15BC014", Offset = "0x15BC014", VA = "0x15BC014")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0370", Offset = "0xAF0370")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000363")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x15B8000", Offset = "0x15B8000", VA = "0x15B8000")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x15BC030", Offset = "0x15BC030", VA = "0x15BC030")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x15BC0B0", Offset = "0x15BC0B0", VA = "0x15BC0B0")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0380", Offset = "0xAF0380")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000364")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x15B8164", Offset = "0x15B8164", VA = "0x15B8164")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x15BC10C", Offset = "0x15BC10C", VA = "0x15BC10C")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x15BC18C", Offset = "0x15BC18C", VA = "0x15BC18C")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0390", Offset = "0xAF0390")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000365")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x15B82C8", Offset = "0x15B82C8", VA = "0x15B82C8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x15BC1E8", Offset = "0x15BC1E8", VA = "0x15BC1E8")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x15BC268", Offset = "0x15BC268", VA = "0x15BC268")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03A0", Offset = "0xAF03A0")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000366")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x15B8434", Offset = "0x15B8434", VA = "0x15B8434")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x15BB1B8", Offset = "0x15BB1B8", VA = "0x15BB1B8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x15BB1D8", Offset = "0x15BB1D8", VA = "0x15BB1D8")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03B0", Offset = "0xAF03B0")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000367")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x15B8578", Offset = "0x15B8578", VA = "0x15B8578")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x15BB1F4", Offset = "0x15BB1F4", VA = "0x15BB1F4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x15BB214", Offset = "0x15BB214", VA = "0x15BB214")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000BB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03C0", Offset = "0xAF03C0")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000368")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x15B86CC", Offset = "0x15B86CC", VA = "0x15B86CC")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x15BB230", Offset = "0x15BB230", VA = "0x15BB230")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x15BB24C", Offset = "0x15BB24C", VA = "0x15BB24C")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03D0", Offset = "0xAF03D0")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000369")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x15B8830", Offset = "0x15B8830", VA = "0x15B8830")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x15BB268", Offset = "0x15BB268", VA = "0x15BB268")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x15BB284", Offset = "0x15BB284", VA = "0x15BB284")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03E0", Offset = "0xAF03E0")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x400036A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x15B89A8", Offset = "0x15B89A8", VA = "0x15B89A8")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x15BB2A0", Offset = "0x15BB2A0", VA = "0x15BB2A0")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x15BB2BC", Offset = "0x15BB2BC", VA = "0x15BB2BC")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000BE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF03F0", Offset = "0xAF03F0")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x400036B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x15B8B20", Offset = "0x15B8B20", VA = "0x15B8B20")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x15BB2D8", Offset = "0x15BB2D8", VA = "0x15BB2D8")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x15BB2F4", Offset = "0x15BB2F4", VA = "0x15BB2F4")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0400", Offset = "0xAF0400")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x400036C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x15B8C8C", Offset = "0x15B8C8C", VA = "0x15B8C8C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x15BB310", Offset = "0x15BB310", VA = "0x15BB310")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x15BB32C", Offset = "0x15BB32C", VA = "0x15BB32C")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0410", Offset = "0xAF0410")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x15B8E10", Offset = "0x15B8E10", VA = "0x15B8E10")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x15BB348", Offset = "0x15BB348", VA = "0x15BB348")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x15BB364", Offset = "0x15BB364", VA = "0x15BB364")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0420", Offset = "0xAF0420")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003F9")]
			[Address(RVA = "0x15B8F94", Offset = "0x15B8F94", VA = "0x15B8F94")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x15BB380", Offset = "0x15BB380", VA = "0x15BB380")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x15BB39C", Offset = "0x15BB39C", VA = "0x15BB39C")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0430", Offset = "0xAF0430")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x15B9118", Offset = "0x15B9118", VA = "0x15B9118")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60003FD")]
			[Address(RVA = "0x15BB3B8", Offset = "0x15BB3B8", VA = "0x15BB3B8")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003FE")]
			[Address(RVA = "0x15BB3D4", Offset = "0x15BB3D4", VA = "0x15BB3D4")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0440", Offset = "0xAF0440")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60003FF")]
			[Address(RVA = "0x15B927C", Offset = "0x15B927C", VA = "0x15B927C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x6000400")]
			[Address(RVA = "0x15BB438", Offset = "0x15BB438", VA = "0x15BB438")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000401")]
			[Address(RVA = "0x15BB454", Offset = "0x15BB454", VA = "0x15BB454")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0450", Offset = "0xAF0450")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000402")]
			[Address(RVA = "0x15B93E0", Offset = "0x15B93E0", VA = "0x15B93E0")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000403")]
			[Address(RVA = "0x15BB470", Offset = "0x15BB470", VA = "0x15BB470")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000404")]
			[Address(RVA = "0x15BB48C", Offset = "0x15BB48C", VA = "0x15BB48C")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0460", Offset = "0xAF0460")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000405")]
			[Address(RVA = "0x15B9534", Offset = "0x15B9534", VA = "0x15B9534")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x6000406")]
			[Address(RVA = "0x15BB4A8", Offset = "0x15BB4A8", VA = "0x15BB4A8")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000407")]
			[Address(RVA = "0x15BB4C4", Offset = "0x15BB4C4", VA = "0x15BB4C4")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0470", Offset = "0xAF0470")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000408")]
			[Address(RVA = "0x15B96A0", Offset = "0x15B96A0", VA = "0x15B96A0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x6000409")]
			[Address(RVA = "0x15BB4E0", Offset = "0x15BB4E0", VA = "0x15BB4E0")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600040A")]
			[Address(RVA = "0x15BB4FC", Offset = "0x15BB4FC", VA = "0x15BB4FC")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0480", Offset = "0xAF0480")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600040B")]
			[Address(RVA = "0x15B980C", Offset = "0x15B980C", VA = "0x15B980C")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x600040C")]
			[Address(RVA = "0x15BB518", Offset = "0x15BB518", VA = "0x15BB518")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600040D")]
			[Address(RVA = "0x15BB534", Offset = "0x15BB534", VA = "0x15BB534")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0490", Offset = "0xAF0490")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x600040E")]
			[Address(RVA = "0x15B9970", Offset = "0x15B9970", VA = "0x15B9970")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x15BB550", Offset = "0x15BB550", VA = "0x15BB550")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x15BB56C", Offset = "0x15BB56C", VA = "0x15BB56C")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000C9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04A0", Offset = "0xAF04A0")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x15B9B28", Offset = "0x15B9B28", VA = "0x15B9B28")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x15BB588", Offset = "0x15BB588", VA = "0x15BB588")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x15BB618", Offset = "0x15BB618", VA = "0x15BB618")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000CA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04B0", Offset = "0xAF04B0")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x15B9CB0", Offset = "0x15B9CB0", VA = "0x15B9CB0")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x15BB6BC", Offset = "0x15BB6BC", VA = "0x15BB6BC")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000416")]
			[Address(RVA = "0x15BB74C", Offset = "0x15BB74C", VA = "0x15BB74C")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000CB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04C0", Offset = "0xAF04C0")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x15B9E84", Offset = "0x15B9E84", VA = "0x15B9E84")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x15BB7F0", Offset = "0x15BB7F0", VA = "0x15BB7F0")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x15BB880", Offset = "0x15BB880", VA = "0x15BB880")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x20000CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04D0", Offset = "0xAF04D0")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x400037A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400037B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400037C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400037D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x15BA208", Offset = "0x15BA208", VA = "0x15BA208")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x15BB924", Offset = "0x15BB924", VA = "0x15BB924")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x15BB940", Offset = "0x15BB940", VA = "0x15BB940")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x15BB95C", Offset = "0x15BB95C", VA = "0x15BB95C")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x15BB990", Offset = "0x15BB990", VA = "0x15BB990")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x15BB9AC", Offset = "0x15BB9AC", VA = "0x15BB9AC")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x15BB9C8", Offset = "0x15BB9C8", VA = "0x15BB9C8")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x20000CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04E0", Offset = "0xAF04E0")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x15BA360", Offset = "0x15BA360", VA = "0x15BA360")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000422")]
			[Address(RVA = "0x15BBAC4", Offset = "0x15BBAC4", VA = "0x15BBAC4")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000423")]
			[Address(RVA = "0x15BBB34", Offset = "0x15BBB34", VA = "0x15BBB34")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF04F0", Offset = "0xAF04F0")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000424")]
			[Address(RVA = "0x15BA4A8", Offset = "0x15BA4A8", VA = "0x15BA4A8")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000425")]
			[Address(RVA = "0x15BBB80", Offset = "0x15BBB80", VA = "0x15BBB80")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000426")]
			[Address(RVA = "0x15BBB9C", Offset = "0x15BBB9C", VA = "0x15BBB9C")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000CF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0500", Offset = "0xAF0500")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x4000381")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000427")]
			[Address(RVA = "0x15BA5F0", Offset = "0x15BA5F0", VA = "0x15BA5F0")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000428")]
			[Address(RVA = "0x15BBBB8", Offset = "0x15BBBB8", VA = "0x15BBBB8")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000429")]
			[Address(RVA = "0x15BBBD4", Offset = "0x15BBBD4", VA = "0x15BBBD4")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0510", Offset = "0xAF0510")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x4000382")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x600042A")]
			[Address(RVA = "0x15BA744", Offset = "0x15BA744", VA = "0x15BA744")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600042B")]
			[Address(RVA = "0x15BBBF0", Offset = "0x15BBBF0", VA = "0x15BBBF0")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600042C")]
			[Address(RVA = "0x15BBC14", Offset = "0x15BBC14", VA = "0x15BBC14")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20000D1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0520", Offset = "0xAF0520")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x4000383")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600042D")]
			[Address(RVA = "0x15BA8B0", Offset = "0x15BA8B0", VA = "0x15BA8B0")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600042E")]
			[Address(RVA = "0x15BBC38", Offset = "0x15BBC38", VA = "0x15BBC38")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600042F")]
			[Address(RVA = "0x15BBC5C", Offset = "0x15BBC5C", VA = "0x15BBC5C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0530", Offset = "0xAF0530")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x4000384")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000430")]
			[Address(RVA = "0x15BA9F4", Offset = "0x15BA9F4", VA = "0x15BA9F4")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000431")]
			[Address(RVA = "0x15BBC80", Offset = "0x15BBC80", VA = "0x15BBC80")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000432")]
			[Address(RVA = "0x15BBCA4", Offset = "0x15BBCA4", VA = "0x15BBCA4")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0540", Offset = "0xAF0540")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000385")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000433")]
			[Address(RVA = "0x15BAB9C", Offset = "0x15BAB9C", VA = "0x15BAB9C")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000434")]
			[Address(RVA = "0x15BBCC8", Offset = "0x15BBCC8", VA = "0x15BBCC8")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000435")]
			[Address(RVA = "0x15BBCEC", Offset = "0x15BBCEC", VA = "0x15BBCEC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x20000D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0550", Offset = "0xAF0550")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000386")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000387")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000436")]
			[Address(RVA = "0x15BAD90", Offset = "0x15BAD90", VA = "0x15BAD90")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000437")]
			[Address(RVA = "0x15BBD10", Offset = "0x15BBD10", VA = "0x15BBD10")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000438")]
			[Address(RVA = "0x15BBD1C", Offset = "0x15BBD1C", VA = "0x15BBD1C")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0560", Offset = "0xAF0560")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000388")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x4000389")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000439")]
			[Address(RVA = "0x15BAF84", Offset = "0x15BAF84", VA = "0x15BAF84")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x600043A")]
			[Address(RVA = "0x15BBDD8", Offset = "0x15BBDD8", VA = "0x15BBDD8")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043B")]
			[Address(RVA = "0x15BBDE4", Offset = "0x15BBDE4", VA = "0x15BBDE4")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0570", Offset = "0xAF0570")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x400038A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x400038B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600043C")]
			[Address(RVA = "0x15BB178", Offset = "0x15BB178", VA = "0x15BB178")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600043D")]
			[Address(RVA = "0x15BBEA0", Offset = "0x15BBEA0", VA = "0x15BBEA0")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600043E")]
			[Address(RVA = "0x15BBEAC", Offset = "0x15BBEAC", VA = "0x15BBEAC")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x15B74B8", Offset = "0x15B74B8", VA = "0x15B74B8")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x15B75FC", Offset = "0x15B75FC", VA = "0x15B75FC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x15B7768", Offset = "0x15B7768", VA = "0x15B7768")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x15B78AC", Offset = "0x15B78AC", VA = "0x15B78AC")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x15B7A18", Offset = "0x15B7A18", VA = "0x15B7A18")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x15B7B5C", Offset = "0x15B7B5C", VA = "0x15B7B5C")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x15B7CC4", Offset = "0x15B7CC4", VA = "0x15B7CC4")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x15B7EA4", Offset = "0x15B7EA4", VA = "0x15B7EA4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x15B8008", Offset = "0x15B8008", VA = "0x15B8008")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x15B816C", Offset = "0x15B816C", VA = "0x15B816C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x15B82D0", Offset = "0x15B82D0", VA = "0x15B82D0")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x15B843C", Offset = "0x15B843C", VA = "0x15B843C")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x15B8580", Offset = "0x15B8580", VA = "0x15B8580")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x15B86D4", Offset = "0x15B86D4", VA = "0x15B86D4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x15B8838", Offset = "0x15B8838", VA = "0x15B8838")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x15B89B0", Offset = "0x15B89B0", VA = "0x15B89B0")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x15B8B28", Offset = "0x15B8B28", VA = "0x15B8B28")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x15B8C94", Offset = "0x15B8C94", VA = "0x15B8C94")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x15B8E18", Offset = "0x15B8E18", VA = "0x15B8E18")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x15B8F9C", Offset = "0x15B8F9C", VA = "0x15B8F9C")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x15B9120", Offset = "0x15B9120", VA = "0x15B9120")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x15B9284", Offset = "0x15B9284", VA = "0x15B9284")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x15B93E8", Offset = "0x15B93E8", VA = "0x15B93E8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x15B953C", Offset = "0x15B953C", VA = "0x15B953C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x15B96A8", Offset = "0x15B96A8", VA = "0x15B96A8")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x15B9814", Offset = "0x15B9814", VA = "0x15B9814")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x15B9978", Offset = "0x15B9978", VA = "0x15B9978")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x15B9B30", Offset = "0x15B9B30", VA = "0x15B9B30")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x15B9CB8", Offset = "0x15B9CB8", VA = "0x15B9CB8")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x15B9E8C", Offset = "0x15B9E8C", VA = "0x15B9E8C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x15BA210", Offset = "0x15BA210", VA = "0x15BA210")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x15BA368", Offset = "0x15BA368", VA = "0x15BA368")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x15BA4B0", Offset = "0x15BA4B0", VA = "0x15BA4B0")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x15BA5F8", Offset = "0x15BA5F8", VA = "0x15BA5F8")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x15BA74C", Offset = "0x15BA74C", VA = "0x15BA74C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x15BA8B8", Offset = "0x15BA8B8", VA = "0x15BA8B8")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x15BA9FC", Offset = "0x15BA9FC", VA = "0x15BA9FC")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x15BABA4", Offset = "0x15BABA4", VA = "0x15BABA4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x15BAD98", Offset = "0x15BAD98", VA = "0x15BAD98")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x15BAF8C", Offset = "0x15BAF8C", VA = "0x15BAF8C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200005B")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x20000D7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0580", Offset = "0xAF0580")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400038C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400038D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600043F")]
			[Address(RVA = "0x15BCE7C", Offset = "0x15BCE7C", VA = "0x15BCE7C")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x6000440")]
			[Address(RVA = "0x15BD01C", Offset = "0x15BD01C", VA = "0x15BD01C")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000441")]
			[Address(RVA = "0x15BD040", Offset = "0x15BD040", VA = "0x15BD040")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAF0590", Offset = "0xAF0590")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x400038E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x400038F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000442")]
			[Address(RVA = "0x15BD014", Offset = "0x15BD014", VA = "0x15BD014")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000443")]
			[Address(RVA = "0x15BD064", Offset = "0x15BD064", VA = "0x15BD064")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000444")]
			[Address(RVA = "0x15BD088", Offset = "0x15BD088", VA = "0x15BD088")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x15BC570", Offset = "0x15BC570", VA = "0x15BC570")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x15BC74C", Offset = "0x15BC74C", VA = "0x15BC74C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x15BC93C", Offset = "0x15BC93C", VA = "0x15BC93C")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x15BC9D4", Offset = "0x15BC9D4", VA = "0x15BC9D4")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x15BCA6C", Offset = "0x15BCA6C", VA = "0x15BCA6C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x15BCB04", Offset = "0x15BCB04", VA = "0x15BCB04")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x15BCBAC", Offset = "0x15BCBAC", VA = "0x15BCBAC")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x15BCC54", Offset = "0x15BCC54", VA = "0x15BCC54")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x15BCCEC", Offset = "0x15BCCEC", VA = "0x15BCCEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x15BCE84", Offset = "0x15BCE84", VA = "0x15BCE84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200005C")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x20000D9")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000390")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000445")]
				[Address(RVA = "0x15B3B84", Offset = "0x15B3B84", VA = "0x15B3B84", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000446")]
			[Address(RVA = "0x15B3BB8", Offset = "0x15B3BB8", VA = "0x15B3BB8")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000DA")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000391")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000447")]
				[Address(RVA = "0x15B3D54", Offset = "0x15B3D54", VA = "0x15B3D54", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000448")]
			[Address(RVA = "0x15B3DB8", Offset = "0x15B3DB8", VA = "0x15B3DB8")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000DB")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000392")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700005F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000449")]
				[Address(RVA = "0x15B3C6C", Offset = "0x15B3C6C", VA = "0x15B3C6C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044A")]
			[Address(RVA = "0x15B3C88", Offset = "0x15B3C88", VA = "0x15B3C88")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x20000DC")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x17000060")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600044B")]
				[Address(RVA = "0x15B3BE4", Offset = "0x15B3BE4", VA = "0x15B3BE4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044C")]
			[Address(RVA = "0x15B3C30", Offset = "0x15B3C30", VA = "0x15B3C30")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x20000DD")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x17000061")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600044D")]
				[Address(RVA = "0x15B3CB4", Offset = "0x15B3CB4", VA = "0x15B3CB4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600044E")]
			[Address(RVA = "0x15B3D18", Offset = "0x15B3D18", VA = "0x15B3D18")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x20000DE")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x17000062")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600044F")]
				[Address(RVA = "0x15B3DE4", Offset = "0x15B3DE4", VA = "0x15B3DE4", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000450")]
			[Address(RVA = "0x15B3E18", Offset = "0x15B3E18", VA = "0x15B3E18")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200005D")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x20000DF")]
		public static class Physics
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x15BD1F0", Offset = "0x15BD1F0", VA = "0x15BD1F0")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000452")]
			[Address(RVA = "0x15BD2F8", Offset = "0x15BD2F8", VA = "0x15BD2F8")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000453")]
			[Address(RVA = "0x15BD388", Offset = "0x15BD388", VA = "0x15BD388")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000454")]
			[Address(RVA = "0x15BD418", Offset = "0x15BD418", VA = "0x15BD418")]
			[Preserve]
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x15BD0AC", Offset = "0x15BD0AC", VA = "0x15BD0AC")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x15BD150", Offset = "0x15BD150", VA = "0x15BD150")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
