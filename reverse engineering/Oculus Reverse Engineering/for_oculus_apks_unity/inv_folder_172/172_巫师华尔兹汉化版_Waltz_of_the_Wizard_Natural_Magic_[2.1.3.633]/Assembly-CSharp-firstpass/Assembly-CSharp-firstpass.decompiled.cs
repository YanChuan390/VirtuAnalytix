using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using HellTap.MeshDecimator.Algorithms;
using HellTap.MeshDecimator.Collections;
using HellTap.MeshDecimator.Math;
using HellTap.MeshDecimator.Unity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace HellTap.MeshDecimator
{
	[Token(Token = "0x2000002")]
	public struct BoneWeight : IEquatable<BoneWeight>
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int boneIndex0;

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int boneIndex1;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int boneIndex2;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int boneIndex3;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float boneWeight0;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float boneWeight1;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float boneWeight2;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float boneWeight3;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2F7F584", Offset = "0x2F7F584", VA = "0x2F7F584")]
		public BoneWeight(int boneIndex0, int boneIndex1, int boneIndex2, int boneIndex3, float boneWeight0, float boneWeight1, float boneWeight2, float boneWeight3)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2F7F598", Offset = "0x2F7F598", VA = "0x2F7F598")]
		public static bool operator ==(BoneWeight lhs, BoneWeight rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2F7F69C", Offset = "0x2F7F69C", VA = "0x2F7F69C")]
		public static bool operator !=(BoneWeight lhs, BoneWeight rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2F7F6D8", Offset = "0x2F7F6D8", VA = "0x2F7F6D8")]
		private void MergeBoneWeight(int boneIndex, float weight)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2F7F7C4", Offset = "0x2F7F7C4", VA = "0x2F7F7C4")]
		private void Normalize()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2F7F894", Offset = "0x2F7F894", VA = "0x2F7F894", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2F7F95C", Offset = "0x2F7F95C", VA = "0x2F7F95C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2F7FA50", Offset = "0x2F7FA50", VA = "0x2F7FA50", Slot = "4")]
		public bool Equals(BoneWeight other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2F7FADC", Offset = "0x2F7FADC", VA = "0x2F7FADC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2F7FE08", Offset = "0x2F7FE08", VA = "0x2F7FE08")]
		public static void Merge(ref BoneWeight a, ref BoneWeight b)
		{
		}
	}
	[Token(Token = "0x2000003")]
	public interface ILogger
	{
		[Token(Token = "0x600000B")]
		void LogVerbose(string text);

		[Token(Token = "0x600000C")]
		void LogWarning(string text);

		[Token(Token = "0x600000D")]
		void LogError(string text);
	}
	[Token(Token = "0x2000004")]
	public static class Logging
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ILogger logger;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static object syncObj;

		[Token(Token = "0x17000001")]
		public static ILogger Logger
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2F8BB10", Offset = "0x2F8BB10", VA = "0x2F8BB10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2F8BB74", Offset = "0x2F8BB74", VA = "0x2F8BB74")]
			set
			{
			}
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2F8BCAC", Offset = "0x2F8BCAC", VA = "0x2F8BCAC")]
		static Logging()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2F8BD74", Offset = "0x2F8BD74", VA = "0x2F8BD74")]
		public static void LogVerbose(string text)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2F87608", Offset = "0x2F87608", VA = "0x2F87608")]
		public static void LogVerbose(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2F8BF4C", Offset = "0x2F8BF4C", VA = "0x2F8BF4C")]
		public static void LogWarning(string text)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2F8C128", Offset = "0x2F8C128", VA = "0x2F8C128")]
		public static void LogWarning(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2F8C1AC", Offset = "0x2F8C1AC", VA = "0x2F8C1AC")]
		public static void LogError(string text)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2F8C388", Offset = "0x2F8C388", VA = "0x2F8C388")]
		public static void LogError(string format, params object[] args)
		{
		}
	}
	[Token(Token = "0x2000005")]
	public sealed class Mesh
	{
		[Token(Token = "0x400000B")]
		public const int UVChannelCount = 4;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector3d[] vertices;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[][] indices;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HellTap.MeshDecimator.Math.Vector3[] normals;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private HellTap.MeshDecimator.Math.Vector4[] tangents;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HellTap.MeshDecimator.Math.Vector2[][] uvs2D;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HellTap.MeshDecimator.Math.Vector3[][] uvs3D;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private HellTap.MeshDecimator.Math.Vector4[][] uvs4D;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private HellTap.MeshDecimator.Math.Vector4[] colors;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] emptyIndices;

		[Token(Token = "0x17000002")]
		public int VertexCount
		{
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x2F8CA04", Offset = "0x2F8CA04", VA = "0x2F8CA04")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000003")]
		public int SubMeshCount
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x2F86D44", Offset = "0x2F86D44", VA = "0x2F86D44")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x2F8CA20", Offset = "0x2F8CA20", VA = "0x2F8CA20")]
			set
			{
			}
		}

		[Token(Token = "0x17000004")]
		public int TriangleCount
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x2F86D60", Offset = "0x2F86D60", VA = "0x2F86D60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000005")]
		public Vector3d[] Vertices
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x2F8CB14", Offset = "0x2F8CB14", VA = "0x2F8CB14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2F8CB1C", Offset = "0x2F8CB1C", VA = "0x2F8CB1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public int[] Indices
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2F8CC14", Offset = "0x2F8CC14", VA = "0x2F8CC14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2F8CD8C", Offset = "0x2F8CD8C", VA = "0x2F8CD8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public HellTap.MeshDecimator.Math.Vector3[] Normals
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x2F8CFE0", Offset = "0x2F8CFE0", VA = "0x2F8CFE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x2F88130", Offset = "0x2F88130", VA = "0x2F88130")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		public HellTap.MeshDecimator.Math.Vector4[] Tangents
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x2F8CFE8", Offset = "0x2F8CFE8", VA = "0x2F8CFE8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x2F88228", Offset = "0x2F88228", VA = "0x2F88228")]
			set
			{
			}
		}

		[Token(Token = "0x17000009")]
		public HellTap.MeshDecimator.Math.Vector2[] UV1
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x2F8CFF0", Offset = "0x2F8CFF0", VA = "0x2F8CFF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x2F8CFF8", Offset = "0x2F8CFF8", VA = "0x2F8CFF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000A")]
		public HellTap.MeshDecimator.Math.Vector2[] UV2
		{
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x2F8D004", Offset = "0x2F8D004", VA = "0x2F8D004")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x2F8D00C", Offset = "0x2F8D00C", VA = "0x2F8D00C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public HellTap.MeshDecimator.Math.Vector2[] UV3
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x2F8D018", Offset = "0x2F8D018", VA = "0x2F8D018")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x2F8D020", Offset = "0x2F8D020", VA = "0x2F8D020")]
			set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public HellTap.MeshDecimator.Math.Vector2[] UV4
		{
			[Token(Token = "0x6000029")]
			[Address(RVA = "0x2F8D02C", Offset = "0x2F8D02C", VA = "0x2F8D02C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x2F8D034", Offset = "0x2F8D034", VA = "0x2F8D034")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public HellTap.MeshDecimator.Math.Vector4[] Colors
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x2F8D040", Offset = "0x2F8D040", VA = "0x2F8D040")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x2F88320", Offset = "0x2F88320", VA = "0x2F88320")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public BoneWeight[] BoneWeights
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x2F8D048", Offset = "0x2F8D048", VA = "0x2F8D048")]
			get
			{
				return null;
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x2F88418", Offset = "0x2F88418", VA = "0x2F88418")]
			set
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2F8D050", Offset = "0x2F8D050", VA = "0x2F8D050")]
		public Mesh(Vector3d[] vertices, int[] indices)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2F87F80", Offset = "0x2F87F80", VA = "0x2F87F80")]
		public Mesh(Vector3d[] vertices, int[][] indices)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2F8CB90", Offset = "0x2F8CB90", VA = "0x2F8CB90")]
		private void ClearVertexAttributes()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2F8D208", Offset = "0x2F8D208", VA = "0x2F8D208")]
		public void RecalculateNormals()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2F8D5C8", Offset = "0x2F8D5C8", VA = "0x2F8D5C8")]
		public void RecalculateTangents()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2F8DDBC", Offset = "0x2F8DDBC", VA = "0x2F8DDBC")]
		public int GetTriangleCount(int subMeshIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2F86DEC", Offset = "0x2F86DEC", VA = "0x2F86DEC")]
		public int[] GetIndices(int subMeshIndex)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2F8CE7C", Offset = "0x2F8CE7C", VA = "0x2F8CE7C")]
		public void SetIndices(int subMeshIndex, int[] indices)
		{
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2F86ECC", Offset = "0x2F86ECC", VA = "0x2F86ECC")]
		public int GetUVDimension(int channel)
		{
			return default(int);
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2F86FBC", Offset = "0x2F86FBC", VA = "0x2F86FBC")]
		public HellTap.MeshDecimator.Math.Vector2[] GetUVs2D(int channel)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2F87054", Offset = "0x2F87054", VA = "0x2F87054")]
		public HellTap.MeshDecimator.Math.Vector3[] GetUVs3D(int channel)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2F870EC", Offset = "0x2F870EC", VA = "0x2F870EC")]
		public HellTap.MeshDecimator.Math.Vector4[] GetUVs4D(int channel)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2F8DE5C", Offset = "0x2F8DE5C", VA = "0x2F8DE5C")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector2> uvs)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2F8DF9C", Offset = "0x2F8DF9C", VA = "0x2F8DF9C")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector3> uvs)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2F8E0DC", Offset = "0x2F8E0DC", VA = "0x2F8E0DC")]
		public void GetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector4> uvs)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2F88510", Offset = "0x2F88510", VA = "0x2F88510")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector2[] uvs)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2F887C0", Offset = "0x2F887C0", VA = "0x2F887C0")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector3[] uvs)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2F88A78", Offset = "0x2F88A78", VA = "0x2F88A78")]
		public void SetUVs(int channel, HellTap.MeshDecimator.Math.Vector4[] uvs)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2F8E21C", Offset = "0x2F8E21C", VA = "0x2F8E21C")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector2> uvs)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2F8E4F8", Offset = "0x2F8E4F8", VA = "0x2F8E4F8")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector3> uvs)
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2F8E7D4", Offset = "0x2F8E7D4", VA = "0x2F8E7D4")]
		public void SetUVs(int channel, List<HellTap.MeshDecimator.Math.Vector4> uvs)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2F8EAB0", Offset = "0x2F8EAB0", VA = "0x2F8EAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000006")]
	public enum Algorithm
	{
		[Token(Token = "0x4000017")]
		Default,
		[Token(Token = "0x4000018")]
		FastQuadricMesh
	}
	[Token(Token = "0x2000007")]
	public static class MeshDecimation
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2F8EBB8", Offset = "0x2F8EBB8", VA = "0x2F8EBB8")]
		public static DecimationAlgorithm CreateAlgorithm(Algorithm algorithm, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2F8EC9C", Offset = "0x2F8EC9C", VA = "0x2F8EC9C")]
		public static Mesh DecimateMesh(Mesh mesh, int targetTriangleCount)
		{
			return null;
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x2F8ECB8", Offset = "0x2F8ECB8", VA = "0x2F8ECB8")]
		public static Mesh DecimateMesh(Algorithm algorithm, Mesh mesh, int targetTriangleCount, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2F8ED3C", Offset = "0x2F8ED3C", VA = "0x2F8ED3C")]
		public static Mesh DecimateMesh(DecimationAlgorithm algorithm, Mesh mesh, int targetTriangleCount)
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x2F8EE20", Offset = "0x2F8EE20", VA = "0x2F8EE20")]
		public static Mesh DecimateMeshLossless(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x2F8EE38", Offset = "0x2F8EE38", VA = "0x2F8EE38")]
		public static Mesh DecimateMeshLossless(Algorithm algorithm, Mesh mesh, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x2F8EEB4", Offset = "0x2F8EEB4", VA = "0x2F8EEB4")]
		public static Mesh DecimateMeshLossless(DecimationAlgorithm algorithm, Mesh mesh)
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Math
{
	[Token(Token = "0x2000008")]
	public static class MathHelper
	{
		[Token(Token = "0x4000019")]
		public const float PI = (float)System.Math.PI;

		[Token(Token = "0x400001A")]
		public const double PId = System.Math.PI;

		[Token(Token = "0x400001B")]
		public const float Deg2Rad = (float)System.Math.PI / 180f;

		[Token(Token = "0x400001C")]
		public const double Deg2Radd = System.Math.PI / 180.0;

		[Token(Token = "0x400001D")]
		public const float Rad2Deg = 180f / (float)System.Math.PI;

		[Token(Token = "0x400001E")]
		public const double Rad2Degd = 180.0 / System.Math.PI;

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x2F8C5C8", Offset = "0x2F8C5C8", VA = "0x2F8C5C8")]
		public static int Min(int val1, int val2)
		{
			return default(int);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x2F8C5D4", Offset = "0x2F8C5D4", VA = "0x2F8C5D4")]
		public static int Min(int val1, int val2, int val3)
		{
			return default(int);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x2F8C5F4", Offset = "0x2F8C5F4", VA = "0x2F8C5F4")]
		public static float Min(float val1, float val2)
		{
			return default(float);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x2F8C600", Offset = "0x2F8C600", VA = "0x2F8C600")]
		public static float Min(float val1, float val2, float val3)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2F8C620", Offset = "0x2F8C620", VA = "0x2F8C620")]
		public static double Min(double val1, double val2)
		{
			return default(double);
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x2F82FB8", Offset = "0x2F82FB8", VA = "0x2F82FB8")]
		public static double Min(double val1, double val2, double val3)
		{
			return default(double);
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x2F828BC", Offset = "0x2F828BC", VA = "0x2F828BC")]
		public static int Max(int val1, int val2)
		{
			return default(int);
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2F8C62C", Offset = "0x2F8C62C", VA = "0x2F8C62C")]
		public static int Max(int val1, int val2, int val3)
		{
			return default(int);
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x2F8C64C", Offset = "0x2F8C64C", VA = "0x2F8C64C")]
		public static float Max(float val1, float val2)
		{
			return default(float);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x2F8C658", Offset = "0x2F8C658", VA = "0x2F8C658")]
		public static float Max(float val1, float val2, float val3)
		{
			return default(float);
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x2F8C678", Offset = "0x2F8C678", VA = "0x2F8C678")]
		public static double Max(double val1, double val2)
		{
			return default(double);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2F8C684", Offset = "0x2F8C684", VA = "0x2F8C684")]
		public static double Max(double val1, double val2, double val3)
		{
			return default(double);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2F8C6A4", Offset = "0x2F8C6A4", VA = "0x2F8C6A4")]
		public static float Clamp(float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x2F8C6C0", Offset = "0x2F8C6C0", VA = "0x2F8C6C0")]
		public static double Clamp(double value, double min, double max)
		{
			return default(double);
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x2F8C6DC", Offset = "0x2F8C6DC", VA = "0x2F8C6DC")]
		public static float Clamp01(float value)
		{
			return default(float);
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x2F8C6F8", Offset = "0x2F8C6F8", VA = "0x2F8C6F8")]
		public static double Clamp01(double value)
		{
			return default(double);
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2F8C714", Offset = "0x2F8C714", VA = "0x2F8C714")]
		public static float TriangleArea(ref Vector3 p0, ref Vector3 p1, ref Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2F8C890", Offset = "0x2F8C890", VA = "0x2F8C890")]
		public static double TriangleArea(ref Vector3d p0, ref Vector3d p1, ref Vector3d p2)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8898", Offset = "0xDD8898")]
	public struct SymmetricMatrix
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double m0;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double m1;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double m2;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double m3;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double m4;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double m5;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double m6;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double m7;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public double m8;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double m9;

		[Token(Token = "0x1700000F")]
		public double Item
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x3569A28", Offset = "0x3569A28", VA = "0x3569A28")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x3569AD4", Offset = "0x3569AD4", VA = "0x3569AD4")]
		public SymmetricMatrix(double c)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x3569AEC", Offset = "0x3569AEC", VA = "0x3569AEC")]
		public SymmetricMatrix(double m0, double m1, double m2, double m3, double m4, double m5, double m6, double m7, double m8, double m9)
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x3569B08", Offset = "0x3569B08", VA = "0x3569B08")]
		public SymmetricMatrix(double a, double b, double c, double d)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x3569B48", Offset = "0x3569B48", VA = "0x3569B48")]
		public static SymmetricMatrix operator +(SymmetricMatrix a, SymmetricMatrix b)
		{
			return default(SymmetricMatrix);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x3569B84", Offset = "0x3569B84", VA = "0x3569B84")]
		internal double Determinant1()
		{
			return default(double);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x3569BDC", Offset = "0x3569BDC", VA = "0x3569BDC")]
		internal double Determinant2()
		{
			return default(double);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x3569C38", Offset = "0x3569C38", VA = "0x3569C38")]
		internal double Determinant3()
		{
			return default(double);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x3569C90", Offset = "0x3569C90", VA = "0x3569C90")]
		internal double Determinant4()
		{
			return default(double);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x3569CEC", Offset = "0x3569CEC", VA = "0x3569CEC")]
		public double Determinant(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
		{
			return default(double);
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD88D0", Offset = "0xDD88D0")]
	public struct Vector2 : IEquatable<Vector2>
	{
		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2 zero;

		[Token(Token = "0x400002A")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x17000010")]
		public float Magnitude
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x356A01C", Offset = "0x356A01C", VA = "0x356A01C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000011")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x356A0B0", Offset = "0x356A0B0", VA = "0x356A0B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000012")]
		public Vector2 Normalized
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x356A0C4", Offset = "0x356A0C4", VA = "0x356A0C4")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000013")]
		public float Item
		{
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x356A1E0", Offset = "0x356A1E0", VA = "0x356A1E0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x356A24C", Offset = "0x356A24C", VA = "0x356A24C")]
			set
			{
			}
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x356A2B8", Offset = "0x356A2B8", VA = "0x356A2B8")]
		public Vector2(float value)
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x356A2C0", Offset = "0x356A2C0", VA = "0x356A2C0")]
		public Vector2(float x, float y)
		{
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x356A2C8", Offset = "0x356A2C8", VA = "0x356A2C8")]
		public static Vector2 operator +(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x356A2D4", Offset = "0x356A2D4", VA = "0x356A2D4")]
		public static Vector2 operator -(Vector2 a, Vector2 b)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x356A2E0", Offset = "0x356A2E0", VA = "0x356A2E0")]
		public static Vector2 operator *(Vector2 a, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x356A2EC", Offset = "0x356A2EC", VA = "0x356A2EC")]
		public static Vector2 operator *(float d, Vector2 a)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x356A2FC", Offset = "0x356A2FC", VA = "0x356A2FC")]
		public static Vector2 operator /(Vector2 a, float d)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x356A308", Offset = "0x356A308", VA = "0x356A308")]
		public static Vector2 operator -(Vector2 a)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x356A314", Offset = "0x356A314", VA = "0x356A314")]
		public static bool operator ==(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x356A3B0", Offset = "0x356A3B0", VA = "0x356A3B0")]
		public static bool operator !=(Vector2 lhs, Vector2 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x356A44C", Offset = "0x356A44C", VA = "0x356A44C")]
		public static explicit operator Vector2(Vector2d v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x356A458", Offset = "0x356A458", VA = "0x356A458")]
		public static implicit operator Vector2(Vector2i v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x356A468", Offset = "0x356A468", VA = "0x356A468")]
		public void Set(float x, float y)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x356A470", Offset = "0x356A470", VA = "0x356A470")]
		public void Scale(ref Vector2 scale)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x356A490", Offset = "0x356A490", VA = "0x356A490")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x356A4D8", Offset = "0x356A4D8", VA = "0x356A4D8")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x356A518", Offset = "0x356A518", VA = "0x356A518", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x356A550", Offset = "0x356A550", VA = "0x356A550", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x356A5E4", Offset = "0x356A5E4", VA = "0x356A5E4", Slot = "4")]
		public bool Equals(Vector2 other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x356A608", Offset = "0x356A608", VA = "0x356A608", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x356A6E8", Offset = "0x356A6E8", VA = "0x356A6E8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x356A7B8", Offset = "0x356A7B8", VA = "0x356A7B8")]
		public static float Dot(ref Vector2 lhs, ref Vector2 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x356A7CC", Offset = "0x356A7CC", VA = "0x356A7CC")]
		public static void Lerp(ref Vector2 a, ref Vector2 b, float t, out Vector2 result)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x356A7E8", Offset = "0x356A7E8", VA = "0x356A7E8")]
		public static void Scale(ref Vector2 a, ref Vector2 b, out Vector2 result)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x356A13C", Offset = "0x356A13C", VA = "0x356A13C")]
		public static void Normalize(ref Vector2 value, out Vector2 result)
		{
		}
	}
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8908", Offset = "0xDD8908")]
	public struct Vector2d : IEquatable<Vector2d>
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2d zero;

		[Token(Token = "0x400002E")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x17000014")]
		public double Magnitude
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0x356A848", Offset = "0x356A848", VA = "0x356A848")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000015")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x356A8DC", Offset = "0x356A8DC", VA = "0x356A8DC")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000016")]
		public Vector2d Normalized
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x356A8F0", Offset = "0x356A8F0", VA = "0x356A8F0")]
			get
			{
				return default(Vector2d);
			}
		}

		[Token(Token = "0x17000017")]
		public double Item
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x356AA08", Offset = "0x356AA08", VA = "0x356AA08")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600008C")]
			[Address(RVA = "0x356AA74", Offset = "0x356AA74", VA = "0x356AA74")]
			set
			{
			}
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x356AAE0", Offset = "0x356AAE0", VA = "0x356AAE0")]
		public Vector2d(double value)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x356AAE8", Offset = "0x356AAE8", VA = "0x356AAE8")]
		public Vector2d(double x, double y)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x356AAF0", Offset = "0x356AAF0", VA = "0x356AAF0")]
		public static Vector2d operator +(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x356AAFC", Offset = "0x356AAFC", VA = "0x356AAFC")]
		public static Vector2d operator -(Vector2d a, Vector2d b)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x356AB08", Offset = "0x356AB08", VA = "0x356AB08")]
		public static Vector2d operator *(Vector2d a, double d)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x356AB14", Offset = "0x356AB14", VA = "0x356AB14")]
		public static Vector2d operator *(double d, Vector2d a)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x356AB24", Offset = "0x356AB24", VA = "0x356AB24")]
		public static Vector2d operator /(Vector2d a, double d)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x356AB30", Offset = "0x356AB30", VA = "0x356AB30")]
		public static Vector2d operator -(Vector2d a)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x356AB3C", Offset = "0x356AB3C", VA = "0x356AB3C")]
		public static bool operator ==(Vector2d lhs, Vector2d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x356ABD8", Offset = "0x356ABD8", VA = "0x356ABD8")]
		public static bool operator !=(Vector2d lhs, Vector2d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x356AC74", Offset = "0x356AC74", VA = "0x356AC74")]
		public static implicit operator Vector2d(Vector2 v)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x356AC80", Offset = "0x356AC80", VA = "0x356AC80")]
		public static implicit operator Vector2d(Vector2i v)
		{
			return default(Vector2d);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x356AC90", Offset = "0x356AC90", VA = "0x356AC90")]
		public void Set(double x, double y)
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x356AC98", Offset = "0x356AC98", VA = "0x356AC98")]
		public void Scale(ref Vector2d scale)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x356ACB8", Offset = "0x356ACB8", VA = "0x356ACB8")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x356AD00", Offset = "0x356AD00", VA = "0x356AD00")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x356AD40", Offset = "0x356AD40", VA = "0x356AD40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x356AD78", Offset = "0x356AD78", VA = "0x356AD78", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x356AE0C", Offset = "0x356AE0C", VA = "0x356AE0C", Slot = "4")]
		public bool Equals(Vector2d other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x356AE30", Offset = "0x356AE30", VA = "0x356AE30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x356AF10", Offset = "0x356AF10", VA = "0x356AF10")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x356AFE0", Offset = "0x356AFE0", VA = "0x356AFE0")]
		public static double Dot(ref Vector2d lhs, ref Vector2d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x356AFF4", Offset = "0x356AFF4", VA = "0x356AFF4")]
		public static void Lerp(ref Vector2d a, ref Vector2d b, double t, out Vector2d result)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x356B010", Offset = "0x356B010", VA = "0x356B010")]
		public static void Scale(ref Vector2d a, ref Vector2d b, out Vector2d result)
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x356A968", Offset = "0x356A968", VA = "0x356A968")]
		public static void Normalize(ref Vector2d value, out Vector2d result)
		{
		}
	}
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8940", Offset = "0xDD8940")]
	public struct Vector2i : IEquatable<Vector2i>
	{
		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector2i zero;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x17000018")]
		public int Magnitude
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x356B070", Offset = "0x356B070", VA = "0x356B070")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x356B0F4", Offset = "0x356B0F4", VA = "0x356B0F4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001A")]
		public int Item
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x356B104", Offset = "0x356B104", VA = "0x356B104")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x356B170", Offset = "0x356B170", VA = "0x356B170")]
			set
			{
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x356B1DC", Offset = "0x356B1DC", VA = "0x356B1DC")]
		public Vector2i(int value)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x356B1E4", Offset = "0x356B1E4", VA = "0x356B1E4")]
		public Vector2i(int x, int y)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x356B1EC", Offset = "0x356B1EC", VA = "0x356B1EC")]
		public static Vector2i operator +(Vector2i a, Vector2i b)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x356B204", Offset = "0x356B204", VA = "0x356B204")]
		public static Vector2i operator -(Vector2i a, Vector2i b)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x356B21C", Offset = "0x356B21C", VA = "0x356B21C")]
		public static Vector2i operator *(Vector2i a, int d)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x356B230", Offset = "0x356B230", VA = "0x356B230")]
		public static Vector2i operator *(int d, Vector2i a)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x356B248", Offset = "0x356B248", VA = "0x356B248")]
		public static Vector2i operator /(Vector2i a, int d)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x356B25C", Offset = "0x356B25C", VA = "0x356B25C")]
		public static Vector2i operator -(Vector2i a)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x356B270", Offset = "0x356B270", VA = "0x356B270")]
		public static bool operator ==(Vector2i lhs, Vector2i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x356B290", Offset = "0x356B290", VA = "0x356B290")]
		public static bool operator !=(Vector2i lhs, Vector2i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x356B2B0", Offset = "0x356B2B0", VA = "0x356B2B0")]
		public static explicit operator Vector2i(Vector2 v)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x356B2C0", Offset = "0x356B2C0", VA = "0x356B2C0")]
		public static explicit operator Vector2i(Vector2d v)
		{
			return default(Vector2i);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x356B2D0", Offset = "0x356B2D0", VA = "0x356B2D0")]
		public void Set(int x, int y)
		{
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x356B2D8", Offset = "0x356B2D8", VA = "0x356B2D8")]
		public void Scale(ref Vector2i scale)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x356B2F8", Offset = "0x356B2F8", VA = "0x356B2F8")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x356B338", Offset = "0x356B338", VA = "0x356B338", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x356B370", Offset = "0x356B370", VA = "0x356B370", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x356B404", Offset = "0x356B404", VA = "0x356B404", Slot = "4")]
		public bool Equals(Vector2i other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x356B42C", Offset = "0x356B42C", VA = "0x356B42C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x356B4E8", Offset = "0x356B4E8", VA = "0x356B4E8")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x356B5B8", Offset = "0x356B5B8", VA = "0x356B5B8")]
		public static void Scale(ref Vector2i a, ref Vector2i b, out Vector2i result)
		{
		}
	}
	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8978", Offset = "0xDD8978")]
	public struct Vector3 : IEquatable<Vector3>
	{
		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 zero;

		[Token(Token = "0x4000035")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x1700001B")]
		public float Magnitude
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x356B620", Offset = "0x356B620", VA = "0x356B620")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001C")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x356B6CC", Offset = "0x356B6CC", VA = "0x356B6CC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700001D")]
		public Vector3 Normalized
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x356B6EC", Offset = "0x356B6EC", VA = "0x356B6EC")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700001E")]
		public float Item
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x356B824", Offset = "0x356B824", VA = "0x356B824")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x356B8A0", Offset = "0x356B8A0", VA = "0x356B8A0")]
			set
			{
			}
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x356B91C", Offset = "0x356B91C", VA = "0x356B91C")]
		public Vector3(float value)
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x356B928", Offset = "0x356B928", VA = "0x356B928")]
		public Vector3(float x, float y, float z)
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x356B934", Offset = "0x356B934", VA = "0x356B934")]
		public Vector3(Vector3d vector)
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x356B94C", Offset = "0x356B94C", VA = "0x356B94C")]
		public static Vector3 operator +(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x356B95C", Offset = "0x356B95C", VA = "0x356B95C")]
		public static Vector3 operator -(Vector3 a, Vector3 b)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x356B96C", Offset = "0x356B96C", VA = "0x356B96C")]
		public static Vector3 operator *(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x356B97C", Offset = "0x356B97C", VA = "0x356B97C")]
		public static Vector3 operator *(float d, Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x356B990", Offset = "0x356B990", VA = "0x356B990")]
		public static Vector3 operator /(Vector3 a, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x356B9A0", Offset = "0x356B9A0", VA = "0x356B9A0")]
		public static Vector3 operator -(Vector3 a)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x356B9B0", Offset = "0x356B9B0", VA = "0x356B9B0")]
		public static bool operator ==(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x356BA68", Offset = "0x356BA68", VA = "0x356BA68")]
		public static bool operator !=(Vector3 lhs, Vector3 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x356BB20", Offset = "0x356BB20", VA = "0x356BB20")]
		public static explicit operator Vector3(Vector3d v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x356BB30", Offset = "0x356BB30", VA = "0x356BB30")]
		public static implicit operator Vector3(Vector3i v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x356BB44", Offset = "0x356BB44", VA = "0x356BB44")]
		public void Set(float x, float y, float z)
		{
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x356BB50", Offset = "0x356BB50", VA = "0x356BB50")]
		public void Scale(ref Vector3 scale)
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x356BB80", Offset = "0x356BB80", VA = "0x356BB80")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x356BBD8", Offset = "0x356BBD8", VA = "0x356BBD8")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x356BC38", Offset = "0x356BC38", VA = "0x356BC38", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x356BC8C", Offset = "0x356BC8C", VA = "0x356BC8C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x356BD30", Offset = "0x356BD30", VA = "0x356BD30", Slot = "4")]
		public bool Equals(Vector3 other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x356BD60", Offset = "0x356BD60", VA = "0x356BD60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x356BE68", Offset = "0x356BE68", VA = "0x356BE68")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x356BF60", Offset = "0x356BF60", VA = "0x356BF60")]
		public static float Dot(ref Vector3 lhs, ref Vector3 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x356BF88", Offset = "0x356BF88", VA = "0x356BF88")]
		public static void Cross(ref Vector3 lhs, ref Vector3 rhs, out Vector3 result)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x356BFC8", Offset = "0x356BFC8", VA = "0x356BFC8")]
		public static float Angle(ref Vector3 from, ref Vector3 to)
		{
			return default(float);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x356C0DC", Offset = "0x356C0DC", VA = "0x356C0DC")]
		public static void Lerp(ref Vector3 a, ref Vector3 b, float t, out Vector3 result)
		{
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x356C110", Offset = "0x356C110", VA = "0x356C110")]
		public static void Scale(ref Vector3 a, ref Vector3 b, out Vector3 result)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x356B76C", Offset = "0x356B76C", VA = "0x356B76C")]
		public static void Normalize(ref Vector3 value, out Vector3 result)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x356C134", Offset = "0x356C134", VA = "0x356C134")]
		public static void OrthoNormalize(ref Vector3 normal, ref Vector3 tangent)
		{
		}
	}
	[Token(Token = "0x200000E")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD89B0", Offset = "0xDD89B0")]
	public struct Vector3d : IEquatable<Vector3d>
	{
		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3d zero;

		[Token(Token = "0x400003A")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double z;

		[Token(Token = "0x1700001F")]
		public double Magnitude
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x356C26C", Offset = "0x356C26C", VA = "0x356C26C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000020")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x356C318", Offset = "0x356C318", VA = "0x356C318")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000021")]
		public Vector3d Normalized
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x356C338", Offset = "0x356C338", VA = "0x356C338")]
			get
			{
				return default(Vector3d);
			}
		}

		[Token(Token = "0x17000022")]
		public double Item
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x356C470", Offset = "0x356C470", VA = "0x356C470")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x356C4EC", Offset = "0x356C4EC", VA = "0x356C4EC")]
			set
			{
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x356C568", Offset = "0x356C568", VA = "0x356C568")]
		public Vector3d(double value)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x356C574", Offset = "0x356C574", VA = "0x356C574")]
		public Vector3d(double x, double y, double z)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x356C580", Offset = "0x356C580", VA = "0x356C580")]
		public Vector3d(Vector3 vector)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x356C598", Offset = "0x356C598", VA = "0x356C598")]
		public static Vector3d operator +(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x356C5A8", Offset = "0x356C5A8", VA = "0x356C5A8")]
		public static Vector3d operator -(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x356C5B8", Offset = "0x356C5B8", VA = "0x356C5B8")]
		public static Vector3d operator *(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x356C5C8", Offset = "0x356C5C8", VA = "0x356C5C8")]
		public static Vector3d operator *(double d, Vector3d a)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x356C5DC", Offset = "0x356C5DC", VA = "0x356C5DC")]
		public static Vector3d operator /(Vector3d a, double d)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x356C5EC", Offset = "0x356C5EC", VA = "0x356C5EC")]
		public static Vector3d operator -(Vector3d a)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x356C5FC", Offset = "0x356C5FC", VA = "0x356C5FC")]
		public static bool operator ==(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x356C6B4", Offset = "0x356C6B4", VA = "0x356C6B4")]
		public static bool operator !=(Vector3d lhs, Vector3d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x356C76C", Offset = "0x356C76C", VA = "0x356C76C")]
		public static implicit operator Vector3d(Vector3 v)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x356C77C", Offset = "0x356C77C", VA = "0x356C77C")]
		public static implicit operator Vector3d(Vector3i v)
		{
			return default(Vector3d);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x356C790", Offset = "0x356C790", VA = "0x356C790")]
		public void Set(double x, double y, double z)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x356C79C", Offset = "0x356C79C", VA = "0x356C79C")]
		public void Scale(ref Vector3d scale)
		{
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x356C7CC", Offset = "0x356C7CC", VA = "0x356C7CC")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x356C824", Offset = "0x356C824", VA = "0x356C824")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x356C884", Offset = "0x356C884", VA = "0x356C884", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x356C8D8", Offset = "0x356C8D8", VA = "0x356C8D8", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x356C97C", Offset = "0x356C97C", VA = "0x356C97C", Slot = "4")]
		public bool Equals(Vector3d other)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x356C9AC", Offset = "0x356C9AC", VA = "0x356C9AC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x356CAB4", Offset = "0x356CAB4", VA = "0x356CAB4")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x356CBAC", Offset = "0x356CBAC", VA = "0x356CBAC")]
		public static double Dot(ref Vector3d lhs, ref Vector3d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x356CBD4", Offset = "0x356CBD4", VA = "0x356CBD4")]
		public static void Cross(ref Vector3d lhs, ref Vector3d rhs, out Vector3d result)
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x356CC14", Offset = "0x356CC14", VA = "0x356CC14")]
		public static double Angle(ref Vector3d from, ref Vector3d to)
		{
			return default(double);
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x356CD24", Offset = "0x356CD24", VA = "0x356CD24")]
		public static void Lerp(ref Vector3d a, ref Vector3d b, double t, out Vector3d result)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x356CD58", Offset = "0x356CD58", VA = "0x356CD58")]
		public static void Scale(ref Vector3d a, ref Vector3d b, out Vector3d result)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x356C3B8", Offset = "0x356C3B8", VA = "0x356C3B8")]
		public static void Normalize(ref Vector3d value, out Vector3d result)
		{
		}
	}
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD89E8", Offset = "0xDD89E8")]
	public struct Vector3i : IEquatable<Vector3i>
	{
		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3i zero;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x17000023")]
		public int Magnitude
		{
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x356CDCC", Offset = "0x356CDCC", VA = "0x356CDCC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000024")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x356CE60", Offset = "0x356CE60", VA = "0x356CE60")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000025")]
		public int Item
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x356CE78", Offset = "0x356CE78", VA = "0x356CE78")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x356CEF4", Offset = "0x356CEF4", VA = "0x356CEF4")]
			set
			{
			}
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x356CF70", Offset = "0x356CF70", VA = "0x356CF70")]
		public Vector3i(int value)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x356CF7C", Offset = "0x356CF7C", VA = "0x356CF7C")]
		public Vector3i(int x, int y, int z)
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x356CF88", Offset = "0x356CF88", VA = "0x356CF88")]
		public static Vector3i operator +(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x356CFA4", Offset = "0x356CFA4", VA = "0x356CFA4")]
		public static Vector3i operator -(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x356CFC0", Offset = "0x356CFC0", VA = "0x356CFC0")]
		public static Vector3i operator *(Vector3i a, int d)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x356CFD8", Offset = "0x356CFD8", VA = "0x356CFD8")]
		public static Vector3i operator *(int d, Vector3i a)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x356CFF4", Offset = "0x356CFF4", VA = "0x356CFF4")]
		public static Vector3i operator /(Vector3i a, int d)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x356D00C", Offset = "0x356D00C", VA = "0x356D00C")]
		public static Vector3i operator -(Vector3i a)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x356D024", Offset = "0x356D024", VA = "0x356D024")]
		public static bool operator ==(Vector3i lhs, Vector3i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x356D054", Offset = "0x356D054", VA = "0x356D054")]
		public static bool operator !=(Vector3i lhs, Vector3i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x356D084", Offset = "0x356D084", VA = "0x356D084")]
		public static implicit operator Vector3i(Vector3 v)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x356D098", Offset = "0x356D098", VA = "0x356D098")]
		public static explicit operator Vector3i(Vector3d v)
		{
			return default(Vector3i);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x356D0AC", Offset = "0x356D0AC", VA = "0x356D0AC")]
		public void Set(int x, int y, int z)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x356D0B8", Offset = "0x356D0B8", VA = "0x356D0B8")]
		public void Scale(ref Vector3i scale)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x356D0E8", Offset = "0x356D0E8", VA = "0x356D0E8")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x356D148", Offset = "0x356D148", VA = "0x356D148", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x356D19C", Offset = "0x356D19C", VA = "0x356D19C", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x356D240", Offset = "0x356D240", VA = "0x356D240", Slot = "4")]
		public bool Equals(Vector3i other)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x356D274", Offset = "0x356D274", VA = "0x356D274", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x356D35C", Offset = "0x356D35C", VA = "0x356D35C")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x356D454", Offset = "0x356D454", VA = "0x356D454")]
		public static void Scale(ref Vector3i a, ref Vector3i b, out Vector3i result)
		{
		}
	}
	[Token(Token = "0x2000010")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8A20", Offset = "0xDD8A20")]
	public struct Vector4 : IEquatable<Vector4>
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4 zero;

		[Token(Token = "0x4000043")]
		public const float Epsilon = 9.9999994E-11f;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float w;

		[Token(Token = "0x17000026")]
		public float Magnitude
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x356D4C8", Offset = "0x356D4C8", VA = "0x356D4C8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000027")]
		public float MagnitudeSqr
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x356D57C", Offset = "0x356D57C", VA = "0x356D57C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000028")]
		public Vector4 Normalized
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x356D5A4", Offset = "0x356D5A4", VA = "0x356D5A4")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x17000029")]
		public float Item
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x356D6C0", Offset = "0x356D6C0", VA = "0x356D6C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x356D750", Offset = "0x356D750", VA = "0x356D750")]
			set
			{
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x356D7E0", Offset = "0x356D7E0", VA = "0x356D7E0")]
		public Vector4(float value)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x356D7EC", Offset = "0x356D7EC", VA = "0x356D7EC")]
		public Vector4(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x356D7F8", Offset = "0x356D7F8", VA = "0x356D7F8")]
		public static Vector4 operator +(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x356D80C", Offset = "0x356D80C", VA = "0x356D80C")]
		public static Vector4 operator -(Vector4 a, Vector4 b)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x356D820", Offset = "0x356D820", VA = "0x356D820")]
		public static Vector4 operator *(Vector4 a, float d)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x356D834", Offset = "0x356D834", VA = "0x356D834")]
		public static Vector4 operator *(float d, Vector4 a)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x356D84C", Offset = "0x356D84C", VA = "0x356D84C")]
		public static Vector4 operator /(Vector4 a, float d)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x356D860", Offset = "0x356D860", VA = "0x356D860")]
		public static Vector4 operator -(Vector4 a)
		{
			return default(Vector4);
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x356D874", Offset = "0x356D874", VA = "0x356D874")]
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x356D948", Offset = "0x356D948", VA = "0x356D948")]
		public static bool operator !=(Vector4 lhs, Vector4 rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x356DA1C", Offset = "0x356DA1C", VA = "0x356DA1C")]
		public static explicit operator Vector4(Vector4d v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x356DA30", Offset = "0x356DA30", VA = "0x356DA30")]
		public static implicit operator Vector4(Vector4i v)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x356DA4C", Offset = "0x356DA4C", VA = "0x356DA4C")]
		public void Set(float x, float y, float z, float w)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x356DA58", Offset = "0x356DA58", VA = "0x356DA58")]
		public void Scale(ref Vector4 scale)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x356DA94", Offset = "0x356DA94", VA = "0x356DA94")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x356DADC", Offset = "0x356DADC", VA = "0x356DADC")]
		public void Clamp(float min, float max)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x356DB5C", Offset = "0x356DB5C", VA = "0x356DB5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x356DBC4", Offset = "0x356DBC4", VA = "0x356DBC4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x356DC78", Offset = "0x356DC78", VA = "0x356DC78", Slot = "4")]
		public bool Equals(Vector4 other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x356DCB4", Offset = "0x356DCB4", VA = "0x356DCB4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x356DEEC", Offset = "0x356DEEC", VA = "0x356DEEC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x356E114", Offset = "0x356E114", VA = "0x356E114")]
		public static float Dot(ref Vector4 lhs, ref Vector4 rhs)
		{
			return default(float);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x356E144", Offset = "0x356E144", VA = "0x356E144")]
		public static void Lerp(ref Vector4 a, ref Vector4 b, float t, out Vector4 result)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x356E160", Offset = "0x356E160", VA = "0x356E160")]
		public static void Scale(ref Vector4 a, ref Vector4 b, out Vector4 result)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x356D620", Offset = "0x356D620", VA = "0x356D620")]
		public static void Normalize(ref Vector4 value, out Vector4 result)
		{
		}
	}
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8A58", Offset = "0xDD8A58")]
	public struct Vector4d : IEquatable<Vector4d>
	{
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4d zero;

		[Token(Token = "0x4000049")]
		public const double Epsilon = double.Epsilon;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double z;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double w;

		[Token(Token = "0x1700002A")]
		public double Magnitude
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x356E1C0", Offset = "0x356E1C0", VA = "0x356E1C0")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002B")]
		public double MagnitudeSqr
		{
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x356E274", Offset = "0x356E274", VA = "0x356E274")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700002C")]
		public Vector4d Normalized
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x356E29C", Offset = "0x356E29C", VA = "0x356E29C")]
			get
			{
				return default(Vector4d);
			}
		}

		[Token(Token = "0x1700002D")]
		public double Item
		{
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x356E3C4", Offset = "0x356E3C4", VA = "0x356E3C4")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x356E454", Offset = "0x356E454", VA = "0x356E454")]
			set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x356E4E4", Offset = "0x356E4E4", VA = "0x356E4E4")]
		public Vector4d(double value)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x356E4F0", Offset = "0x356E4F0", VA = "0x356E4F0")]
		public Vector4d(double x, double y, double z, double w)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x356E4FC", Offset = "0x356E4FC", VA = "0x356E4FC")]
		public static Vector4d operator +(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x356E510", Offset = "0x356E510", VA = "0x356E510")]
		public static Vector4d operator -(Vector4d a, Vector4d b)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x356E524", Offset = "0x356E524", VA = "0x356E524")]
		public static Vector4d operator *(Vector4d a, double d)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x356E538", Offset = "0x356E538", VA = "0x356E538")]
		public static Vector4d operator *(double d, Vector4d a)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x356E550", Offset = "0x356E550", VA = "0x356E550")]
		public static Vector4d operator /(Vector4d a, double d)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x356E564", Offset = "0x356E564", VA = "0x356E564")]
		public static Vector4d operator -(Vector4d a)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x356E578", Offset = "0x356E578", VA = "0x356E578")]
		public static bool operator ==(Vector4d lhs, Vector4d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x356E64C", Offset = "0x356E64C", VA = "0x356E64C")]
		public static bool operator !=(Vector4d lhs, Vector4d rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x356E720", Offset = "0x356E720", VA = "0x356E720")]
		public static implicit operator Vector4d(Vector4 v)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x356E734", Offset = "0x356E734", VA = "0x356E734")]
		public static implicit operator Vector4d(Vector4i v)
		{
			return default(Vector4d);
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x356E750", Offset = "0x356E750", VA = "0x356E750")]
		public void Set(double x, double y, double z, double w)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x356E75C", Offset = "0x356E75C", VA = "0x356E75C")]
		public void Scale(ref Vector4d scale)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x356E798", Offset = "0x356E798", VA = "0x356E798")]
		public void Normalize()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x356E7EC", Offset = "0x356E7EC", VA = "0x356E7EC")]
		public void Clamp(double min, double max)
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x356E86C", Offset = "0x356E86C", VA = "0x356E86C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x356E8D4", Offset = "0x356E8D4", VA = "0x356E8D4", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x356E988", Offset = "0x356E988", VA = "0x356E988", Slot = "4")]
		public bool Equals(Vector4d other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x356E9C4", Offset = "0x356E9C4", VA = "0x356E9C4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x356EBFC", Offset = "0x356EBFC", VA = "0x356EBFC")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x356EE24", Offset = "0x356EE24", VA = "0x356EE24")]
		public static double Dot(ref Vector4d lhs, ref Vector4d rhs)
		{
			return default(double);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x356EE54", Offset = "0x356EE54", VA = "0x356EE54")]
		public static void Lerp(ref Vector4d a, ref Vector4d b, double t, out Vector4d result)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x356EE7C", Offset = "0x356EE7C", VA = "0x356EE7C")]
		public static void Scale(ref Vector4d a, ref Vector4d b, out Vector4d result)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x356E31C", Offset = "0x356E31C", VA = "0x356E31C")]
		public static void Normalize(ref Vector4d value, out Vector4d result)
		{
		}
	}
	[Token(Token = "0x2000012")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8A90", Offset = "0xDD8A90")]
	public struct Vector4i : IEquatable<Vector4i>
	{
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector4i zero;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int x;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int y;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int z;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int w;

		[Token(Token = "0x1700002E")]
		public int Magnitude
		{
			[Token(Token = "0x600015E")]
			[Address(RVA = "0x356EEE4", Offset = "0x356EEE4", VA = "0x356EEE4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public int MagnitudeSqr
		{
			[Token(Token = "0x600015F")]
			[Address(RVA = "0x356EF7C", Offset = "0x356EF7C", VA = "0x356EF7C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000030")]
		public int Item
		{
			[Token(Token = "0x6000160")]
			[Address(RVA = "0x356EF90", Offset = "0x356EF90", VA = "0x356EF90")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000161")]
			[Address(RVA = "0x356F020", Offset = "0x356F020", VA = "0x356F020")]
			set
			{
			}
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x356F0B0", Offset = "0x356F0B0", VA = "0x356F0B0")]
		public Vector4i(int value)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x356F0BC", Offset = "0x356F0BC", VA = "0x356F0BC")]
		public Vector4i(int x, int y, int z, int w)
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x356F0C8", Offset = "0x356F0C8", VA = "0x356F0C8")]
		public static Vector4i operator +(Vector4i a, Vector4i b)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x356F0F4", Offset = "0x356F0F4", VA = "0x356F0F4")]
		public static Vector4i operator -(Vector4i a, Vector4i b)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x356F120", Offset = "0x356F120", VA = "0x356F120")]
		public static Vector4i operator *(Vector4i a, int d)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x356F144", Offset = "0x356F144", VA = "0x356F144")]
		public static Vector4i operator *(int d, Vector4i a)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x356F16C", Offset = "0x356F16C", VA = "0x356F16C")]
		public static Vector4i operator /(Vector4i a, int d)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x356F190", Offset = "0x356F190", VA = "0x356F190")]
		public static Vector4i operator -(Vector4i a)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x356F1B4", Offset = "0x356F1B4", VA = "0x356F1B4")]
		public static bool operator ==(Vector4i lhs, Vector4i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x356F1F0", Offset = "0x356F1F0", VA = "0x356F1F0")]
		public static bool operator !=(Vector4i lhs, Vector4i rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x356F22C", Offset = "0x356F22C", VA = "0x356F22C")]
		public static explicit operator Vector4i(Vector4 v)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x356F248", Offset = "0x356F248", VA = "0x356F248")]
		public static explicit operator Vector4i(Vector4d v)
		{
			return default(Vector4i);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x356F264", Offset = "0x356F264", VA = "0x356F264")]
		public void Set(int x, int y, int z, int w)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x356F270", Offset = "0x356F270", VA = "0x356F270")]
		public void Scale(ref Vector4i scale)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x356F2AC", Offset = "0x356F2AC", VA = "0x356F2AC")]
		public void Clamp(int min, int max)
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x356F32C", Offset = "0x356F32C", VA = "0x356F32C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x356F394", Offset = "0x356F394", VA = "0x356F394", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x356F448", Offset = "0x356F448", VA = "0x356F448", Slot = "4")]
		public bool Equals(Vector4i other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x356F48C", Offset = "0x356F48C", VA = "0x356F48C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x356F6A0", Offset = "0x356F6A0", VA = "0x356F6A0")]
		public string ToString(string format)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x356F8C8", Offset = "0x356F8C8", VA = "0x356F8C8")]
		public static void Scale(ref Vector4i a, ref Vector4i b, out Vector4i result)
		{
		}
	}
}
namespace HellTap.MeshDecimator.Loggers
{
	[Token(Token = "0x2000013")]
	public sealed class ConsoleLogger : ILogger
	{
		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2F80B14", Offset = "0x2F80B14", VA = "0x2F80B14", Slot = "4")]
		public void LogVerbose(string text)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x2F80B78", Offset = "0x2F80B78", VA = "0x2F80B78", Slot = "5")]
		public void LogWarning(string text)
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x2F80BDC", Offset = "0x2F80BDC", VA = "0x2F80BDC", Slot = "6")]
		public void LogError(string text)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x2F80C9C", Offset = "0x2F80C9C", VA = "0x2F80C9C")]
		public ConsoleLogger()
		{
		}
	}
}
namespace HellTap.MeshDecimator.Collections
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8AC8", Offset = "0xDD8AC8")]
	internal sealed class ResizableArray<T>
	{
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T[] items;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int length;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T[] emptyArr;

		[Token(Token = "0x17000031")]
		public int Length
		{
			[Token(Token = "0x600017C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000032")]
		public T[] Data
		{
			[Token(Token = "0x600017D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public T Item
		{
			[Token(Token = "0x600017E")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x600017F")]
			set
			{
			}
		}

		[Token(Token = "0x6000180")]
		public ResizableArray(int capacity)
		{
		}

		[Token(Token = "0x6000181")]
		public ResizableArray(int capacity, int length)
		{
		}

		[Token(Token = "0x6000182")]
		private void IncreaseCapacity(int capacity)
		{
		}

		[Token(Token = "0x6000183")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000184")]
		public void Resize(int length, bool trimExess = false)
		{
		}

		[Token(Token = "0x6000185")]
		public void TrimExcess()
		{
		}

		[Token(Token = "0x6000186")]
		public void Add(T item)
		{
		}
	}
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8B00", Offset = "0xDD8B00")]
	internal sealed class UVChannels<TVec>
	{
		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ResizableArray<TVec>[] channels;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TVec[][] channelsData;

		[Token(Token = "0x17000034")]
		public TVec[][] Data
		{
			[Token(Token = "0x6000188")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		public ResizableArray<TVec> Item
		{
			[Token(Token = "0x6000189")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018A")]
			set
			{
			}
		}

		[Token(Token = "0x600018B")]
		public UVChannels()
		{
		}

		[Token(Token = "0x600018C")]
		public void Resize(int capacity, bool trimExess = false)
		{
		}
	}
}
namespace HellTap.MeshDecimator.Algorithms
{
	[Token(Token = "0x2000016")]
	public abstract class DecimationAlgorithm
	{
		[Token(Token = "0x2000017")]
		public delegate void StatusReportCallback(int iteration, int originalTris, int currentTris, int targetTris);

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool preserveBorders;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private int maxVertexCount;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool verbose;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StatusReportCallback statusReportInvoker;

		[Token(Token = "0x17000036")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xDDA118", Offset = "0xDDA118")]
		public bool KeepBorders
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x2F82874", Offset = "0x2F82874", VA = "0x2F82874")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x2F8287C", Offset = "0x2F8287C", VA = "0x2F8287C")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public bool PreserveBorders
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x2F82888", Offset = "0x2F82888", VA = "0x2F82888")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x2F82890", Offset = "0x2F82890", VA = "0x2F82890")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xDDA154", Offset = "0xDDA154")]
		public bool KeepLinkedVertices
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x2F8289C", Offset = "0x2F8289C", VA = "0x2F8289C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x2F828A4", Offset = "0x2F828A4", VA = "0x2F828A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public int MaxVertexCount
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x2F828A8", Offset = "0x2F828A8", VA = "0x2F828A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x2F828B0", Offset = "0x2F828B0", VA = "0x2F828B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public bool Verbose
		{
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x2F828C8", Offset = "0x2F828C8", VA = "0x2F828C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x2F828D0", Offset = "0x2F828D0", VA = "0x2F828D0")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event StatusReportCallback StatusReport
		{
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x2F828DC", Offset = "0x2F828DC", VA = "0x2F828DC")]
			add
			{
			}
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x2F82968", Offset = "0x2F82968", VA = "0x2F82968")]
			remove
			{
			}
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2F829F4", Offset = "0x2F829F4", VA = "0x2F829F4")]
		protected void ReportStatus(int iteration, int originalTris, int currentTris, int targetTris)
		{
		}

		[Token(Token = "0x600019A")]
		public abstract void Initialize(Mesh mesh);

		[Token(Token = "0x600019B")]
		public abstract void DecimateMesh(int targetTrisCount);

		[Token(Token = "0x600019C")]
		public abstract void DecimateMeshLossless();

		[Token(Token = "0x600019D")]
		public abstract Mesh ToMesh();

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x2F82A08", Offset = "0x2F82A08", VA = "0x2F82A08")]
		protected DecimationAlgorithm()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public sealed class FastQuadricMeshSimplification : DecimationAlgorithm
	{
		[Token(Token = "0x2000019")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xDD8B38", Offset = "0xDD8B38")]
		private struct Triangle
		{
			[Token(Token = "0x4000071")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int v0;

			[Token(Token = "0x4000072")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int v1;

			[Token(Token = "0x4000073")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int v2;

			[Token(Token = "0x4000074")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public int subMeshIndex;

			[Token(Token = "0x4000075")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int va0;

			[Token(Token = "0x4000076")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int va1;

			[Token(Token = "0x4000077")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int va2;

			[Token(Token = "0x4000078")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public double err0;

			[Token(Token = "0x4000079")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public double err1;

			[Token(Token = "0x400007A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public double err2;

			[Token(Token = "0x400007B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public double err3;

			[Token(Token = "0x400007C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool deleted;

			[Token(Token = "0x400007D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool dirty;

			[Token(Token = "0x400007E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3d n;

			[Token(Token = "0x17000041")]
			public int Item
			{
				[Token(Token = "0x60001C0")]
				[Address(RVA = "0x356FD30", Offset = "0x356FD30", VA = "0x356FD30")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60001C1")]
				[Address(RVA = "0x356FD50", Offset = "0x356FD50", VA = "0x356FD50")]
				set
				{
				}
			}

			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x356FDBC", Offset = "0x356FDBC", VA = "0x356FDBC")]
			public Triangle(int v0, int v1, int v2, int subMeshIndex)
			{
			}

			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x356FDE4", Offset = "0x356FDE4", VA = "0x356FDE4")]
			public void GetAttributeIndices(int[] attributeIndices)
			{
			}

			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x356FE38", Offset = "0x356FE38", VA = "0x356FE38")]
			public void SetAttributeIndex(int index, int value)
			{
			}

			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x356FEA4", Offset = "0x356FEA4", VA = "0x356FEA4")]
			public void GetErrors(double[] err)
			{
			}
		}

		[Token(Token = "0x200001A")]
		private struct Vertex
		{
			[Token(Token = "0x400007F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3d p;

			[Token(Token = "0x4000080")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int tstart;

			[Token(Token = "0x4000081")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int tcount;

			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SymmetricMatrix q;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool border;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
			public bool seam;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
			public bool foldover;

			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x356FEF8", Offset = "0x356FEF8", VA = "0x356FEF8")]
			public Vertex(Vector3d p)
			{
			}
		}

		[Token(Token = "0x200001B")]
		private struct Ref
		{
			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int tid;

			[Token(Token = "0x4000087")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int tvertex;

			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x356FD28", Offset = "0x356FD28", VA = "0x356FD28")]
			public void Set(int tid, int tvertex)
			{
			}
		}

		[Token(Token = "0x200001C")]
		private struct BorderVertex
		{
			[Token(Token = "0x4000088")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int index;

			[Token(Token = "0x4000089")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int hash;

			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x356FC84", Offset = "0x356FC84", VA = "0x356FC84")]
			public BorderVertex(int index, int hash)
			{
			}
		}

		[Token(Token = "0x200001D")]
		private class BorderVertexComparer : IComparer<BorderVertex>
		{
			[Token(Token = "0x400008A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly BorderVertexComparer instance;

			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x356FC8C", Offset = "0x356FC8C", VA = "0x356FC8C", Slot = "4")]
			public int Compare(BorderVertex x, BorderVertex y)
			{
				return default(int);
			}

			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x356FCBC", Offset = "0x356FCBC", VA = "0x356FCBC")]
			public BorderVertexComparer()
			{
			}
		}

		[Token(Token = "0x400005C")]
		private const double DoubleEpsilon = 0.001;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool preserveSeams;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool preserveFoldovers;

		[Token(Token = "0x400005F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		private bool enableSmartLink;

		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int maxIterationCount;

		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private double agressiveness;

		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double vertexLinkDistanceSqr;

		[Token(Token = "0x4000063")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int subMeshCount;

		[Token(Token = "0x4000064")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ResizableArray<Triangle> triangles;

		[Token(Token = "0x4000065")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ResizableArray<Vertex> vertices;

		[Token(Token = "0x4000066")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private ResizableArray<Ref> refs;

		[Token(Token = "0x4000067")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector3> vertNormals;

		[Token(Token = "0x4000068")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector4> vertTangents;

		[Token(Token = "0x4000069")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector2> vertUV2D;

		[Token(Token = "0x400006A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector3> vertUV3D;

		[Token(Token = "0x400006B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private UVChannels<HellTap.MeshDecimator.Math.Vector4> vertUV4D;

		[Token(Token = "0x400006C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private ResizableArray<HellTap.MeshDecimator.Math.Vector4> vertColors;

		[Token(Token = "0x400006D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ResizableArray<BoneWeight> vertBoneWeights;

		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private int remainingVertices;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private double[] errArr;

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int[] attributeIndexArr;

		[Token(Token = "0x1700003B")]
		public bool PreserveSeams
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x2F82A10", Offset = "0x2F82A10", VA = "0x2F82A10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A4")]
			[Address(RVA = "0x2F82A18", Offset = "0x2F82A18", VA = "0x2F82A18")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public bool PreserveFoldovers
		{
			[Token(Token = "0x60001A5")]
			[Address(RVA = "0x2F82A24", Offset = "0x2F82A24", VA = "0x2F82A24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A6")]
			[Address(RVA = "0x2F82A2C", Offset = "0x2F82A2C", VA = "0x2F82A2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool EnableSmartLink
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x2F82A38", Offset = "0x2F82A38", VA = "0x2F82A38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x2F82A40", Offset = "0x2F82A40", VA = "0x2F82A40")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public int MaxIterationCount
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x2F82A4C", Offset = "0x2F82A4C", VA = "0x2F82A4C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x2F82A54", Offset = "0x2F82A54", VA = "0x2F82A54")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public double Agressiveness
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x2F82A5C", Offset = "0x2F82A5C", VA = "0x2F82A5C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x2F82A64", Offset = "0x2F82A64", VA = "0x2F82A64")]
			set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public double VertexLinkDistanceSqr
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x2F82A6C", Offset = "0x2F82A6C", VA = "0x2F82A6C")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x2F82A74", Offset = "0x2F82A74", VA = "0x2F82A74")]
			set
			{
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2F82A7C", Offset = "0x2F82A7C", VA = "0x2F82A7C")]
		public FastQuadricMeshSimplification(bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x60001B0")]
		private ResizableArray<T> InitializeVertexAttribute<T>(T[] attributeValues, string attributeName)
		{
			return null;
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2F82C58", Offset = "0x2F82C58", VA = "0x2F82C58")]
		private double VertexError(ref SymmetricMatrix q, double x, double y, double z)
		{
			return default(double);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2F82CE8", Offset = "0x2F82CE8", VA = "0x2F82CE8")]
		private double CalculateError(ref Vertex vert0, ref Vertex vert1, out Vector3d result, out int resultIndex)
		{
			return default(double);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2F82FD8", Offset = "0x2F82FD8", VA = "0x2F82FD8")]
		private bool Flipped(ref Vector3d p, int i0, int i1, ref Vertex v0, bool[] deleted)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2F833E8", Offset = "0x2F833E8", VA = "0x2F833E8")]
		private void UpdateTriangles(int i0, int ia0, ref Vertex v, ResizableArray<bool> deleted, ref int deletedTriangles)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x2F83724", Offset = "0x2F83724", VA = "0x2F83724")]
		private void MoveVertexAttributes(int i0, int i1)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2F83A3C", Offset = "0x2F83A3C", VA = "0x2F83A3C")]
		private void MergeVertexAttributes(int i0, int i1)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2F84048", Offset = "0x2F84048", VA = "0x2F84048")]
		private bool AreUVsTheSame(int channel, int indexA, int indexB)
		{
			return default(bool);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2F84364", Offset = "0x2F84364", VA = "0x2F84364")]
		private void RemoveVertexPass(int startTrisCount, int targetTrisCount, double threshold, ResizableArray<bool> deleted0, ResizableArray<bool> deleted1, ref int deletedTris)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2F849E4", Offset = "0x2F849E4", VA = "0x2F849E4")]
		private void UpdateMesh(int iteration)
		{
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2F8581C", Offset = "0x2F8581C", VA = "0x2F8581C")]
		private void UpdateReferences()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2F85BCC", Offset = "0x2F85BCC", VA = "0x2F85BCC")]
		private void CompactMesh()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2F865D8", Offset = "0x2F865D8", VA = "0x2F865D8", Slot = "4")]
		public override void Initialize(Mesh mesh)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2F87184", Offset = "0x2F87184", VA = "0x2F87184", Slot = "5")]
		public override void DecimateMesh(int targetTrisCount)
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x2F8768C", Offset = "0x2F8768C", VA = "0x2F8768C", Slot = "6")]
		public override void DecimateMeshLossless()
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2F87950", Offset = "0x2F87950", VA = "0x2F87950", Slot = "7")]
		public override Mesh ToMesh()
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Unity
{
	[Token(Token = "0x200001E")]
	public sealed class DecimatedObject : MonoBehaviour
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private LODSettings[] levels;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool generated;

		[Token(Token = "0x17000042")]
		public LODSettings[] Levels
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x2F80F0C", Offset = "0x2F80F0C", VA = "0x2F80F0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x2F80F14", Offset = "0x2F80F14", VA = "0x2F80F14")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool IsGenerated
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x2F80F1C", Offset = "0x2F80F1C", VA = "0x2F80F1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x2F80F24", Offset = "0x2F80F24", VA = "0x2F80F24")]
		private void Reset()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x2F811E0", Offset = "0x2F811E0", VA = "0x2F811E0")]
		public void GenerateLODs([Optional] LODStatusReportCallback statusCallback)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x2F811B4", Offset = "0x2F811B4", VA = "0x2F811B4")]
		public void ResetLODs()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x2F8286C", Offset = "0x2F8286C", VA = "0x2F8286C")]
		public DecimatedObject()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public delegate void LODStatusReportCallback(int lodLevel, int iteration, int originalTris, int currentTris, int targetTris);
	[Serializable]
	[Token(Token = "0x2000020")]
	public struct LODSettings
	{
		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD8E24", Offset = "0xDD8E24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD8E24", Offset = "0xDD8E24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD8E24", Offset = "0xDD8E24")]
		public float lodDistancePercentage;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD8EA4", Offset = "0xDD8EA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD8EA4", Offset = "0xDD8EA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD8EA4", Offset = "0xDD8EA4")]
		public float quality;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD8F20", Offset = "0xDD8F20")]
		[HideInInspector]
		public bool combineMeshes;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD8F6C", Offset = "0xDD8F6C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD8F6C", Offset = "0xDD8F6C")]
		public SkinQuality skinQuality;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD8FCC", Offset = "0xDD8FCC")]
		public bool receiveShadows;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9004", Offset = "0xDD9004")]
		public ShadowCastingMode shadowCasting;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD903C", Offset = "0xDD903C")]
		public MotionVectorGenerationMode motionVectors;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9074", Offset = "0xDD9074")]
		public bool skinnedMotionVectors;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD90AC", Offset = "0xDD90AC")]
		public LightProbeUsage lightProbeUsage;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD90E4", Offset = "0xDD90E4")]
		public ReflectionProbeUsage reflectionProbeUsage;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x2F8B710", Offset = "0x2F8B710", VA = "0x2F8B710")]
		public LODSettings(float quality, float lodDistancePercentage = 0.8f)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x2F8B738", Offset = "0x2F8B738", VA = "0x2F8B738")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x2F8115C", Offset = "0x2F8115C", VA = "0x2F8115C")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2F81188", Offset = "0x2F81188", VA = "0x2F81188")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2F8B760", Offset = "0x2F8B760", VA = "0x2F8B760")]
		public LODSettings(float quality, float lodDistancePercentage, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors, LightProbeUsage lightProbeUsage, ReflectionProbeUsage reflectionProbeUsage)
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class LODGenerator
	{
		[Token(Token = "0x2000022")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD8B70", Offset = "0xDD8B70")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000098")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LODStatusReportCallback statusCallback;

			[Token(Token = "0x4000099")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int levelIndex;

			[Token(Token = "0x400009A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DecimationAlgorithm.StatusReportCallback <>9__0;

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x356FF38", Offset = "0x356FF38", VA = "0x356FF38")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x356FF40", Offset = "0x356FF40", VA = "0x356FF40")]
			internal void <GenerateLODs>b__0(int iteration, int originalTris, int currentTris, int targetTris)
			{
			}
		}

		[Token(Token = "0x4000097")]
		private const string ParentGameObjectName = "_LOD_";

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2F88EEC", Offset = "0x2F88EEC", VA = "0x2F88EEC")]
		private static Renderer[] CombineRenderers(MeshRenderer[] meshRenderers, SkinnedMeshRenderer[] skinnedRenderers)
		{
			return null;
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2F88F9C", Offset = "0x2F88F9C", VA = "0x2F88F9C")]
		private static UnityEngine.Mesh GenerateStaticLOD(Transform transform, MeshRenderer renderer, float quality, out Material[] materials, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2F89784", Offset = "0x2F89784", VA = "0x2F89784")]
		private static UnityEngine.Mesh GenerateStaticLOD(Transform transform, MeshRenderer[] renderers, float quality, out Material[] materials, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x2F89BF4", Offset = "0x2F89BF4", VA = "0x2F89BF4")]
		private static UnityEngine.Mesh GenerateSkinnedLOD(Transform transform, SkinnedMeshRenderer renderer, float quality, out Material[] materials, out Transform[] mergedBones, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2F89DCC", Offset = "0x2F89DCC", VA = "0x2F89DCC")]
		private static UnityEngine.Mesh GenerateSkinnedLOD(Transform transform, SkinnedMeshRenderer[] renderers, float quality, out Material[] materials, out Transform[] mergedBones, DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2F8B49C", Offset = "0x2F8B49C", VA = "0x2F8B49C")]
		private static Transform FindRootBone(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2F8B5B8", Offset = "0x2F8B5B8", VA = "0x2F8B5B8")]
		private static void SetupLODRenderer(Renderer renderer, LODSettings settings)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2F81234", Offset = "0x2F81234", VA = "0x2F81234")]
		public static void GenerateLODs(GameObject gameObj, LODSettings[] levels, [Optional] LODStatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2F82610", Offset = "0x2F82610", VA = "0x2F82610")]
		public static void DestroyLODs(GameObject gameObj)
		{
		}
	}
	[Token(Token = "0x2000023")]
	public static class MeshDecimatorUtility
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2F8EF7C", Offset = "0x2F8EF7C", VA = "0x2F8EF7C")]
		static MeshDecimatorUtility()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x2F8F0E8", Offset = "0x2F8F0E8", VA = "0x2F8F0E8")]
		private static Vector3d[] ToSimplifyVertices(UnityEngine.Vector3[] vertices)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2F8F1EC", Offset = "0x2F8F1EC", VA = "0x2F8F1EC")]
		private static HellTap.MeshDecimator.Math.Vector2[] ToSimplifyVec(UnityEngine.Vector2[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2F8F2D4", Offset = "0x2F8F2D4", VA = "0x2F8F2D4")]
		private static HellTap.MeshDecimator.Math.Vector3[] ToSimplifyVec(UnityEngine.Vector3[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x2F8F3D4", Offset = "0x2F8F3D4", VA = "0x2F8F3D4")]
		private static HellTap.MeshDecimator.Math.Vector4[] ToSimplifyVec(UnityEngine.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x2F8F4C8", Offset = "0x2F8F4C8", VA = "0x2F8F4C8")]
		private static HellTap.MeshDecimator.Math.Vector4[] ToSimplifyVec(Color[] colors)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x2F8F5BC", Offset = "0x2F8F5BC", VA = "0x2F8F5BC")]
		private static BoneWeight[] ToSimplifyBoneWeights(UnityEngine.BoneWeight[] boneWeights)
		{
			return null;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2F8F750", Offset = "0x2F8F750", VA = "0x2F8F750")]
		private static UnityEngine.Vector3[] FromSimplifyVertices(Vector3d[] vertices)
		{
			return null;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2F8F810", Offset = "0x2F8F810", VA = "0x2F8F810")]
		private static UnityEngine.Vector2[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector2[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2F8F8C8", Offset = "0x2F8F8C8", VA = "0x2F8F8C8")]
		private static UnityEngine.Vector3[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector3[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2F8F988", Offset = "0x2F8F988", VA = "0x2F8F988")]
		private static UnityEngine.Vector4[] FromSimplifyVec(HellTap.MeshDecimator.Math.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2F8FA7C", Offset = "0x2F8FA7C", VA = "0x2F8FA7C")]
		private static Color[] FromSimplifyColor(HellTap.MeshDecimator.Math.Vector4[] vectors)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2F8FB70", Offset = "0x2F8FB70", VA = "0x2F8FB70")]
		private static UnityEngine.BoneWeight[] FromSimplifyBoneWeights(BoneWeight[] boneWeights)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x2F8FD10", Offset = "0x2F8FD10", VA = "0x2F8FD10")]
		private static void AddToList(List<Vector3d> list, UnityEngine.Vector3[] arr, int previousVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x2F8FDF8", Offset = "0x2F8FDF8", VA = "0x2F8FDF8")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector2> list, UnityEngine.Vector2[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector2 defaultValue)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x2F8FFC4", Offset = "0x2F8FFC4", VA = "0x2F8FFC4")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector3> list, UnityEngine.Vector3[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector3 defaultValue)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x2F901B0", Offset = "0x2F901B0", VA = "0x2F901B0")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector4> list, UnityEngine.Vector4[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount, HellTap.MeshDecimator.Math.Vector4 defaultValue)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x2F903A4", Offset = "0x2F903A4", VA = "0x2F903A4")]
		private static void AddToList(ref List<HellTap.MeshDecimator.Math.Vector4> list, Color[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x2F90578", Offset = "0x2F90578", VA = "0x2F90578")]
		private static void AddToList(ref List<BoneWeight> list, UnityEngine.BoneWeight[] arr, int previousVertexCount, int currentVertexCount, int totalVertexCount)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x2F907FC", Offset = "0x2F907FC", VA = "0x2F907FC")]
		private static void TransformVertices(UnityEngine.Vector3[] vertices, ref Matrix4x4 transform)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x2F9088C", Offset = "0x2F9088C", VA = "0x2F9088C")]
		private static void TransformVertices(UnityEngine.Vector3[] vertices, UnityEngine.BoneWeight[] boneWeights, Matrix4x4[] oldBindposes, Matrix4x4[] newBindposes)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x2F90DD4", Offset = "0x2F90DD4", VA = "0x2F90DD4")]
		private static Matrix4x4 ScaleMatrix(ref Matrix4x4 m, float scale)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60001FD")]
		private static T[] MergeArrays<T>(T[] arr1, T[] arr2)
		{
			return null;
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x2F90DF8", Offset = "0x2F90DF8", VA = "0x2F90DF8")]
		private static void RemapBones(UnityEngine.BoneWeight[] boneWeights, int[] boneIndices)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x2F90FA4", Offset = "0x2F90FA4", VA = "0x2F90FA4")]
		private static UnityEngine.Mesh CreateMesh(Matrix4x4[] bindposes, UnityEngine.Vector3[] vertices, Mesh destMesh, bool recalculateNormals)
		{
			return null;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x2F89174", Offset = "0x2F89174", VA = "0x2F89174")]
		public static UnityEngine.Mesh DecimateMesh(UnityEngine.Mesh mesh, Matrix4x4 transform, float quality, bool recalculateNormals, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x2F89B20", Offset = "0x2F89B20", VA = "0x2F89B20")]
		public static UnityEngine.Mesh DecimateMeshes(UnityEngine.Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, float quality, bool recalculateNormals, out Material[] resultMaterials, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x2F8A1D4", Offset = "0x2F8A1D4", VA = "0x2F8A1D4")]
		public static UnityEngine.Mesh DecimateMeshes(UnityEngine.Mesh[] meshes, Matrix4x4[] transforms, Material[][] materials, Transform[][] meshBones, float quality, bool recalculateNormals, out Material[] resultMaterials, out Transform[] mergedBones, [Optional] DecimationAlgorithm.StatusReportCallback statusCallback, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}
	}
}
namespace HellTap.MeshDecimator.Unity.Loggers
{
	[Token(Token = "0x2000024")]
	public sealed class UnityLogger : ILogger
	{
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x3569EE8", Offset = "0x3569EE8", VA = "0x3569EE8", Slot = "4")]
		public void LogVerbose(string text)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x3569F4C", Offset = "0x3569F4C", VA = "0x3569F4C", Slot = "5")]
		public void LogWarning(string text)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x3569FB0", Offset = "0x3569FB0", VA = "0x3569FB0", Slot = "6")]
		public void LogError(string text)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x356A014", Offset = "0x356A014", VA = "0x356A014")]
		public UnityLogger()
		{
		}
	}
}
namespace HellTap.MeshKit
{
	[Token(Token = "0x2000025")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8B80", Offset = "0xDD8B80")]
	[DisallowMultipleComponent]
	public class AutoLODAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD911C", Offset = "0xDD911C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD911C", Offset = "0xDD911C")]
		public MeshKit.AutoLODSettings[] levels;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD917C", Offset = "0xDD917C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD917C", Offset = "0xDD917C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD917C", Offset = "0xDD917C")]
		public float cullingDistancePercentage;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD91F8", Offset = "0xDD91F8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD91F8", Offset = "0xDD91F8")]
		public bool preserveBorders;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9258", Offset = "0xDD9258")]
		public bool preserveSeams;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9290", Offset = "0xDD9290")]
		public bool preserveFoldovers;

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x2F7F1D0", Offset = "0x2F7F1D0", VA = "0x2F7F1D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x2F7F394", Offset = "0x2F7F394", VA = "0x2F7F394")]
		public AutoLODAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000026")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8BDC", Offset = "0xDD8BDC")]
	public class CombineChildrenAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD92C8", Offset = "0xDD92C8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD92C8", Offset = "0xDD92C8")]
		public bool seperateSubMeshesFirst;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9328", Offset = "0xDD9328")]
		public bool stripUnusedVertices;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9360", Offset = "0xDD9360")]
		public bool onlySeperateEnabledRenderers;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9398", Offset = "0xDD9398")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9398", Offset = "0xDD9398")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD9398", Offset = "0xDD9398")]
		public int maximumVerticesPerObject;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9418", Offset = "0xDD9418")]
		public bool onlyCombineEnabledRenderers;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9450", Offset = "0xDD9450")]
		public bool optimizeCombinedMeshes;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9488", Offset = "0xDD9488")]
		public bool createMeshCollidersOnNewObjects;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD94C0", Offset = "0xDD94C0")]
		public int createNewObjectsWithLayer;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD94F8", Offset = "0xDD94F8")]
		public string createNewObjectsWithTag;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9530", Offset = "0xDD9530")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9530", Offset = "0xDD9530")]
		public bool destroyOriginalObjects;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9590", Offset = "0xDD9590")]
		public bool destroyObjectsWithDisabledRenderers;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD95C8", Offset = "0xDD95C8")]
		public bool destroyEmptyObjects;

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x2F7FE90", Offset = "0x2F7FE90", VA = "0x2F7FE90")]
		private void Start()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x2F80A94", Offset = "0x2F80A94", VA = "0x2F80A94")]
		public CombineChildrenAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000027")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8C28", Offset = "0xDD8C28")]
	public class DecimateMeshAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9600", Offset = "0xDD9600")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9600", Offset = "0xDD9600")]
		public bool applyToChildren;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9660", Offset = "0xDD9660")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9698", Offset = "0xDD9698")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD96D0", Offset = "0xDD96D0")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD9708", Offset = "0xDD9708")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9708", Offset = "0xDD9708")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9708", Offset = "0xDD9708")]
		public float decimatorQuality;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9780", Offset = "0xDD9780")]
		public bool recalculateNormals;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD97B8", Offset = "0xDD97B8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD97B8", Offset = "0xDD97B8")]
		public bool preserveBorders;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9818", Offset = "0xDD9818")]
		public bool preserveSeams;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9850", Offset = "0xDD9850")]
		public bool preserveFoldovers;

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x2F80CA4", Offset = "0x2F80CA4", VA = "0x2F80CA4")]
		private void Start()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x2F80EF4", Offset = "0x2F80EF4", VA = "0x2F80EF4")]
		public DecimateMeshAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000028")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8C74", Offset = "0xDD8C74")]
	public class InvertMeshAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9888", Offset = "0xDD9888")]
		public bool applyToChildren;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD98C0", Offset = "0xDD98C0")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD98F8", Offset = "0xDD98F8")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9930", Offset = "0xDD9930")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x2F88D30", Offset = "0x2F88D30", VA = "0x2F88D30")]
		private void Start()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x2F88ED4", Offset = "0x2F88ED4", VA = "0x2F88ED4")]
		public InvertMeshAtRuntime()
		{
		}
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8CC0", Offset = "0xDD8CC0")]
	[DisallowMultipleComponent]
	public class MakeDoubleSidedAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9968", Offset = "0xDD9968")]
		public bool applyToChildren;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD99A0", Offset = "0xDD99A0")]
		public bool applyToMeshFilters;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD99D8", Offset = "0xDD99D8")]
		public bool applyToSkinnedMeshRenderers;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9A10", Offset = "0xDD9A10")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x2F8C40C", Offset = "0x2F8C40C", VA = "0x2F8C40C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x2F8C5B0", Offset = "0x2F8C5B0", VA = "0x2F8C5B0")]
		public MakeDoubleSidedAtRuntime()
		{
		}
	}
	[Token(Token = "0x200002A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8D0C", Offset = "0xDD8D0C")]
	[DisallowMultipleComponent]
	public class SeperateChildrenAtRuntime : MonoBehaviour
	{
		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9A48", Offset = "0xDD9A48")]
		public bool stripUnusedVertices;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9A80", Offset = "0xDD9A80")]
		public bool onlyApplyToEnabledRenderers;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x3569948", Offset = "0x3569948", VA = "0x3569948")]
		private void Start()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x3569A18", Offset = "0x3569A18", VA = "0x3569A18")]
		public SeperateChildrenAtRuntime()
		{
		}
	}
	[Token(Token = "0x200002B")]
	public class MeshKit : MonoBehaviour
	{
		[Token(Token = "0x200002C")]
		public class BatchMeshes
		{
			[Token(Token = "0x40000C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] key;

			[Token(Token = "0x40000C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Mesh originalMesh;

			[Token(Token = "0x40000C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Mesh[] splitMeshes;

			[Token(Token = "0x40000C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ArrayList gos;

			[Token(Token = "0x600022F")]
			[Address(RVA = "0x3574CA0", Offset = "0x3574CA0", VA = "0x3574CA0")]
			public BatchMeshes()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200002D")]
		public class AutoLODSettings
		{
			[Token(Token = "0x40000C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9AB8", Offset = "0xDD9AB8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD9AB8", Offset = "0xDD9AB8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9AB8", Offset = "0xDD9AB8")]
			public float lodDistancePercentage;

			[Token(Token = "0x40000C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9B38", Offset = "0xDD9B38")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD9B38", Offset = "0xDD9B38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9B38", Offset = "0xDD9B38")]
			public float quality;

			[Token(Token = "0x40000C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9BB4", Offset = "0xDD9BB4")]
			[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xDD9BB4", Offset = "0xDD9BB4")]
			public SkinQuality skinQuality;

			[Token(Token = "0x40000C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9C14", Offset = "0xDD9C14")]
			public bool receiveShadows;

			[Token(Token = "0x40000CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9C4C", Offset = "0xDD9C4C")]
			public ShadowCastingMode shadowCasting;

			[Token(Token = "0x40000CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9C84", Offset = "0xDD9C84")]
			public MotionVectorGenerationMode motionVectors;

			[Token(Token = "0x40000CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9CBC", Offset = "0xDD9CBC")]
			public bool skinnedMotionVectors;

			[Token(Token = "0x40000CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9CF4", Offset = "0xDD9CF4")]
			public LightProbeUsage lightProbeUsage;

			[Token(Token = "0x40000CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xDD9D2C", Offset = "0xDD9D2C")]
			public ReflectionProbeUsage reflectionProbeUsage;

			[Token(Token = "0x6000230")]
			[Address(RVA = "0x3574B30", Offset = "0x3574B30", VA = "0x3574B30")]
			public AutoLODSettings(float lodDistancePercentageValue, float qualityValue = 0.8f)
			{
			}

			[Token(Token = "0x6000231")]
			[Address(RVA = "0x3574BAC", Offset = "0x3574BAC", VA = "0x3574BAC")]
			public AutoLODSettings(float lodDistancePercentage, float quality, SkinQuality skinQuality, bool receiveShadows, ShadowCastingMode shadowCasting, MotionVectorGenerationMode motionVectors, bool skinnedMotionVectors, LightProbeUsage lightProbeUsage = LightProbeUsage.BlendProbes, ReflectionProbeUsage reflectionProbeUsage = ReflectionProbeUsage.BlendProbes)
			{
			}

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x3574C58", Offset = "0x3574C58", VA = "0x3574C58")]
			public LODSettings ToLODSettings()
			{
				return default(LODSettings);
			}
		}

		[Token(Token = "0x200002E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD8D58", Offset = "0xDD8D58")]
		private sealed class <InvertMeshAtRuntime>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x40000D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x40000D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40000D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40000D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x17000045")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000236")]
				[Address(RVA = "0x3574108", Offset = "0x3574108", VA = "0x3574108", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000046")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000238")]
				[Address(RVA = "0x3574150", Offset = "0x3574150", VA = "0x3574150", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x3573780", Offset = "0x3573780", VA = "0x3573780")]
			[DebuggerHidden]
			public <InvertMeshAtRuntime>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x35737AC", Offset = "0x35737AC", VA = "0x35737AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000235")]
			[Address(RVA = "0x35737B0", Offset = "0x35737B0", VA = "0x35737B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000237")]
			[Address(RVA = "0x3574110", Offset = "0x3574110", VA = "0x3574110", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200002F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD8D68", Offset = "0xDD8D68")]
		private sealed class <MakeDoubleSidedAtRuntime>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x40000DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x40000DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40000DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40000DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x40000E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x40000E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private int <>7__wrap2;

			[Token(Token = "0x40000E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x17000047")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600023C")]
				[Address(RVA = "0x3574AE0", Offset = "0x3574AE0", VA = "0x3574AE0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000048")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600023E")]
				[Address(RVA = "0x3574B28", Offset = "0x3574B28", VA = "0x3574B28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000239")]
			[Address(RVA = "0x3574158", Offset = "0x3574158", VA = "0x3574158")]
			[DebuggerHidden]
			public <MakeDoubleSidedAtRuntime>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600023A")]
			[Address(RVA = "0x3574184", Offset = "0x3574184", VA = "0x3574184", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600023B")]
			[Address(RVA = "0x3574188", Offset = "0x3574188", VA = "0x3574188", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600023D")]
			[Address(RVA = "0x3574AE8", Offset = "0x3574AE8", VA = "0x3574AE8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD8D78", Offset = "0xDD8D78")]
		private sealed class <CombineChildrenAtRuntime>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int userMaxVertices;

			[Token(Token = "0x40000E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40000E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40000E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int createNewObjectsWithLayer;

			[Token(Token = "0x40000E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public string createNewObjectsWithTag;

			[Token(Token = "0x40000EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool createNewObjectsWithMeshColliders;

			[Token(Token = "0x40000EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			public bool deleteSourceObjects;

			[Token(Token = "0x40000EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
			public bool deleteObjectsWithDisabledRenderers;

			[Token(Token = "0x40000ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
			public bool deleteEmptyObjects;

			[Token(Token = "0x40000EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private bool <foundEmptyObjects>5__2;

			[Token(Token = "0x17000049")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000242")]
				[Address(RVA = "0x3572D00", Offset = "0x3572D00", VA = "0x3572D00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000244")]
				[Address(RVA = "0x3572D48", Offset = "0x3572D48", VA = "0x3572D48", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600023F")]
			[Address(RVA = "0x356FF74", Offset = "0x356FF74", VA = "0x356FF74")]
			[DebuggerHidden]
			public <CombineChildrenAtRuntime>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000240")]
			[Address(RVA = "0x356FFA0", Offset = "0x356FFA0", VA = "0x356FFA0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000241")]
			[Address(RVA = "0x356FFA4", Offset = "0x356FFA4", VA = "0x356FFA4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000243")]
			[Address(RVA = "0x3572D08", Offset = "0x3572D08", VA = "0x3572D08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000031")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xDD8D88", Offset = "0xDD8D88")]
		private sealed class <DecimateMeshAtRuntime>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40000EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40000F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40000F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool recursive;

			[Token(Token = "0x40000F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
			public bool optionUseMeshFilters;

			[Token(Token = "0x40000F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject go;

			[Token(Token = "0x40000F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool optionUseSkinnedMeshRenderers;

			[Token(Token = "0x40000F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool enabledRenderersOnly;

			[Token(Token = "0x40000F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float quality;

			[Token(Token = "0x40000F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool recalculateNormals;

			[Token(Token = "0x40000F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
			public bool preserveBorders;

			[Token(Token = "0x40000F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
			public bool preserveSeams;

			[Token(Token = "0x40000FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
			public bool preserveFoldovers;

			[Token(Token = "0x40000FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private MeshFilter[] <>7__wrap1;

			[Token(Token = "0x40000FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private int <>7__wrap2;

			[Token(Token = "0x40000FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private SkinnedMeshRenderer[] <>7__wrap3;

			[Token(Token = "0x1700004B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000248")]
				[Address(RVA = "0x3573730", Offset = "0x3573730", VA = "0x3573730", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600024A")]
				[Address(RVA = "0x3573778", Offset = "0x3573778", VA = "0x3573778", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000245")]
			[Address(RVA = "0x3572D50", Offset = "0x3572D50", VA = "0x3572D50")]
			[DebuggerHidden]
			public <DecimateMeshAtRuntime>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000246")]
			[Address(RVA = "0x3572D7C", Offset = "0x3572D7C", VA = "0x3572D7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000247")]
			[Address(RVA = "0x3572D80", Offset = "0x3572D80", VA = "0x3572D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000249")]
			[Address(RVA = "0x3573738", Offset = "0x3573738", VA = "0x3573738", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool debug;

		[Token(Token = "0x40000C0")]
		private const int maxVertices = 65534;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MeshKit _instance;

		[Token(Token = "0x17000044")]
		public static MeshKit com
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x2F912A8", Offset = "0x2F912A8", VA = "0x2F912A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x2F9153C", Offset = "0x2F9153C", VA = "0x2F9153C")]
		public static Mesh RebuildMesh(Mesh m, bool optionStripNormals, bool optionStripTangents, bool optionStripColors, bool optionStripUV2, bool optionStripUV3, bool optionStripUV4, bool optionStripUV5, bool optionStripUV6, bool optionStripUV7, bool optionStripUV8, bool optionRebuildNormals, bool optionRebuildTangents, float rebuildNormalsAngle = -1f)
		{
			return null;
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x2F91F80", Offset = "0x2F91F80", VA = "0x2F91F80")]
		public static Mesh StripUnusedVertices(Mesh m, bool optimize)
		{
			return null;
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x2F92024", Offset = "0x2F92024", VA = "0x2F92024")]
		public static Mesh Strip(Mesh m, bool optimize, bool stripNormals, bool stripTangents, bool stripColors, bool stripUV, bool stripUV2, bool stripUV3, bool stripUV4, bool stripUV5, bool stripUV6, bool stripUV7, bool stripUV8, bool stripBoneWeights, bool stripBindPoses)
		{
			return null;
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x2F9304C", Offset = "0x2F9304C", VA = "0x2F9304C")]
		public static Mesh[] SplitMesh(Mesh mesh, bool stripUnusedVertices)
		{
			return null;
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x2F91A64", Offset = "0x2F91A64", VA = "0x2F91A64")]
		public static Mesh CreateTangents(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2F93710", Offset = "0x2F93710", VA = "0x2F93710")]
		public static Mesh InvertMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x2F9386C", Offset = "0x2F9386C", VA = "0x2F9386C")]
		public static Mesh MakeDoubleSidedMesh(Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x2F88E1C", Offset = "0x2F88E1C", VA = "0x2F88E1C")]
		public static void InvertMesh(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x2F94950", Offset = "0x2F94950", VA = "0x2F94950")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDD9E08", Offset = "0xDD9E08")]
		public IEnumerator InvertMeshAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x2F8C4F8", Offset = "0x2F8C4F8", VA = "0x2F8C4F8")]
		public static void MakeDoubleSided(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x2F94A08", Offset = "0x2F94A08", VA = "0x2F94A08")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDD9E68", Offset = "0xDD9E68")]
		public IEnumerator MakeDoubleSidedAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly)
		{
			return null;
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x2F80998", Offset = "0x2F80998", VA = "0x2F80998")]
		public static void CombineChildren(GameObject go, bool optimizeMeshes, int createNewObjectsWithLayer, string createNewObjectsWithTag, bool enabledRenderersOnly, bool createNewObjectsWithMeshColliders, bool deleteSourceObjects, bool deleteObjectsWithDisabledRenderers, bool deleteEmptyObjects, int userMaxVertices = 65534)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x2F94AC0", Offset = "0x2F94AC0", VA = "0x2F94AC0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDD9EC8", Offset = "0xDD9EC8")]
		public IEnumerator CombineChildrenAtRuntime(GameObject go, bool optimizeMeshes, int createNewObjectsWithLayer, string createNewObjectsWithTag, bool enabledRenderersOnly, bool createNewObjectsWithMeshColliders, bool deleteSourceObjects, bool deleteObjectsWithDisabledRenderers, bool deleteEmptyObjects, int userMaxVertices = 65534)
		{
			return null;
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x2F94BB8", Offset = "0x2F94BB8", VA = "0x2F94BB8")]
		public static bool ListContains(ArrayList list, Material[] key, Mesh originalMesh, MeshFilter mf)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x2F7FFF0", Offset = "0x2F7FFF0", VA = "0x2F7FFF0")]
		public static void SeparateMeshes(GameObject go, bool onlyApplyToEnabledRenderers, bool stripUnusedVertices)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x2F95024", Offset = "0x2F95024", VA = "0x2F95024")]
		public static void RebuildSeparatedObjects(BatchMeshes bm)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x2F95788", Offset = "0x2F95788", VA = "0x2F95788")]
		public static void Rebuild(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool optionStripNormals, bool optionStripTangents, bool optionStripColors, bool optionStripUV2, bool optionStripUV3, bool optionStripUV4, bool optionStripUV5, bool optionStripUV6, bool optionStripUV7, bool optionStripUV8, bool optionRebuildNormals, bool optionRebuildTangents, float rebuildNormalsAngle = -1f)
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x2F95DCC", Offset = "0x2F95DCC", VA = "0x2F95DCC")]
		public static Mesh DecimateMesh(SkinnedMeshRenderer smr, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x2F960CC", Offset = "0x2F960CC", VA = "0x2F960CC")]
		public static Mesh DecimateMesh(MeshFilter mf, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x2F80DEC", Offset = "0x2F80DEC", VA = "0x2F80DEC")]
		public static void DecimateMesh(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x2F963CC", Offset = "0x2F963CC", VA = "0x2F963CC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xDD9F28", Offset = "0xDD9F28")]
		public IEnumerator DecimateMeshAtRuntime(GameObject go, bool recursive, bool optionUseMeshFilters, bool optionUseSkinnedMeshRenderers, bool enabledRenderersOnly, float quality, bool recalculateNormals, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
			return null;
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2F964D4", Offset = "0x2F964D4", VA = "0x2F964D4")]
		public static LODSettings[] AutoLODSetttingsToLODSettings(AutoLODSettings[] autoLODSettings)
		{
			return null;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2F965F8", Offset = "0x2F965F8", VA = "0x2F965F8")]
		public static void AutoLOD(GameObject go, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x2F7F2EC", Offset = "0x2F7F2EC", VA = "0x2F7F2EC")]
		public static void AutoLOD(GameObject go, AutoLODSettings[] levels, float cullingDistance = 1f, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x2F96874", Offset = "0x2F96874", VA = "0x2F96874")]
		public static void AutoLOD(GameObject go, LODSettings[] levels, float cullingDistance = 1f, bool preserveBorders = false, bool preserveSeams = false, bool preserveFoldovers = false)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x2F96DA8", Offset = "0x2F96DA8", VA = "0x2F96DA8")]
		public MeshKit()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public static class Arrays
	{
		[Token(Token = "0x600024B")]
		public static bool AddItem<T>(ref T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		public static void AddItemFastest<T>(ref T[] _arr, T item)
		{
		}

		[Token(Token = "0x600024D")]
		public static bool AddItemIfNotPresent<T>(ref T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		public static bool RemoveItem<T>(ref T[] _arr, ref T item, bool onlyRemoveFirstInstance = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600024F")]
		public static bool RemoveFirstItem<T>(ref T[] _arr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		public static bool RemoveItemAtIndex<T>(ref T[] _arr, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000251")]
		public static int ItemExistsAtIndex<T>(ref T[] _arr, ref T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000252")]
		public static bool ItemExists<T>(T[] _arr, T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000253")]
		public static T[] Concat<T>(this T[] a, T[] b)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		public static T[] Combine<T>(T[] a, T[] b)
		{
			return null;
		}

		[Token(Token = "0x6000255")]
		public static bool Clear<T>(ref T[] arr)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		public static bool Shift<T>(ref T[] _arr, int id, bool moveUp)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000033")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xDD8DA8", Offset = "0xDD8DA8")]
	public sealed class MeshKitAutoLOD : MonoBehaviour
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[HideInInspector]
		public bool advancedMode;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[HideInInspector]
		public bool preserveBorders;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[HideInInspector]
		public bool preserveSeams;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		[HideInInspector]
		public bool preserveFoldovers;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public LODSettings[] levels;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xDD9DB4", Offset = "0xDD9DB4")]
		public float cullingDistance;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public bool generated;

		[Token(Token = "0x1700004D")]
		public LODSettings[] Levels
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x3568864", Offset = "0x3568864", VA = "0x3568864")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x3568A2C", Offset = "0x3568A2C", VA = "0x3568A2C")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public bool IsGenerated
		{
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x3568A34", Offset = "0x3568A34", VA = "0x3568A34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3568A3C", Offset = "0x3568A3C", VA = "0x3568A3C")]
		public void Reset()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3568C58", Offset = "0x3568C58", VA = "0x3568C58")]
		public void GenerateLODs([Optional] LODStatusReportCallback statusCallback)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x3568C24", Offset = "0x3568C24", VA = "0x3568C24")]
		public void ResetLODs()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3568CC8", Offset = "0x3568CC8", VA = "0x3568CC8")]
		public MeshKitAutoLOD()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public static class MeshKitNormals
	{
		[Token(Token = "0x2000035")]
		private struct VertexKey
		{
			[Token(Token = "0x4000105")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly long _x;

			[Token(Token = "0x4000106")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly long _y;

			[Token(Token = "0x4000107")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly long _z;

			[Token(Token = "0x4000108")]
			private const int Tolerance = 100000;

			[Token(Token = "0x600025F")]
			[Address(RVA = "0x3569604", Offset = "0x3569604", VA = "0x3569604")]
			public VertexKey(UnityEngine.Vector3 position)
			{
			}

			[Token(Token = "0x6000260")]
			[Address(RVA = "0x3574CB0", Offset = "0x3574CB0", VA = "0x3574CB0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000261")]
			[Address(RVA = "0x3574D64", Offset = "0x3574D64", VA = "0x3574D64", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000036")]
		private sealed class VertexEntry
		{
			[Token(Token = "0x4000109")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] TriangleIndex;

			[Token(Token = "0x400010A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] VertexIndex;

			[Token(Token = "0x400010B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int _reserved;

			[Token(Token = "0x400010C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int _count;

			[Token(Token = "0x1700004F")]
			public int Count
			{
				[Token(Token = "0x6000262")]
				[Address(RVA = "0x3574CA8", Offset = "0x3574CA8", VA = "0x3574CA8")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000263")]
			[Address(RVA = "0x3569854", Offset = "0x3569854", VA = "0x3569854")]
			public void Add(int vertIndex, int triIndex)
			{
			}

			[Token(Token = "0x6000264")]
			[Address(RVA = "0x35697C0", Offset = "0x35697C0", VA = "0x35697C0")]
			public VertexEntry()
			{
			}
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x3568CD8", Offset = "0x3568CD8", VA = "0x3568CD8")]
		public static void RecalculateNormalsBasedOnAngleThreshold(this Mesh mesh, float angle)
		{
		}
	}
}
