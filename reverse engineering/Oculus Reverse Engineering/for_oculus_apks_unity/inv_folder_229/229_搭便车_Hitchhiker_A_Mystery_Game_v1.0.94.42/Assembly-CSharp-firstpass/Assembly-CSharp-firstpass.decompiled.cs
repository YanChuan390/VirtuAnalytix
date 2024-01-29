using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using FluffyUnderware.Curvy.Generator;
using FluffyUnderware.Curvy.ThirdParty.LibTessDotNet;
using FluffyUnderware.DevTools;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2E78", Offset = "0x9C2E78")]
internal sealed class <>f__AnonymousType0<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar>
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C578C", Offset = "0x9C578C")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C57A0", Offset = "0x9C57A0")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C57B4", Offset = "0x9C57B4")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C57C8", Offset = "0x9C57C8")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x17000001")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000001")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000002")]
	public <B>j__TPar B
	{
		[Token(Token = "0x6000002")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000003")]
	public <C>j__TPar C
	{
		[Token(Token = "0x6000003")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000004")]
	public <D>j__TPar D
	{
		[Token(Token = "0x6000004")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x6000005")]
	[DebuggerHidden]
	public <>f__AnonymousType0(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D)
	{
	}

	[Token(Token = "0x6000006")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000007")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000008")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2E88", Offset = "0x9C2E88")]
internal sealed class <>f__AnonymousType1<<A>j__TPar, <B>j__TPar, <C>j__TPar, <D>j__TPar, <E>j__TPar, <F>j__TPar>
{
	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C57DC", Offset = "0x9C57DC")]
	private readonly <A>j__TPar <A>i__Field;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C57F0", Offset = "0x9C57F0")]
	private readonly <B>j__TPar <B>i__Field;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C5804", Offset = "0x9C5804")]
	private readonly <C>j__TPar <C>i__Field;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C5818", Offset = "0x9C5818")]
	private readonly <D>j__TPar <D>i__Field;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C582C", Offset = "0x9C582C")]
	private readonly <E>j__TPar <E>i__Field;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "DebuggerBrowsableAttribute", RVA = "0x9C5840", Offset = "0x9C5840")]
	private readonly <F>j__TPar <F>i__Field;

	[Token(Token = "0x17000005")]
	public <A>j__TPar A
	{
		[Token(Token = "0x6000009")]
		get
		{
			return (<A>j__TPar)null;
		}
	}

	[Token(Token = "0x17000006")]
	public <B>j__TPar B
	{
		[Token(Token = "0x600000A")]
		get
		{
			return (<B>j__TPar)null;
		}
	}

	[Token(Token = "0x17000007")]
	public <C>j__TPar C
	{
		[Token(Token = "0x600000B")]
		get
		{
			return (<C>j__TPar)null;
		}
	}

	[Token(Token = "0x17000008")]
	public <D>j__TPar D
	{
		[Token(Token = "0x600000C")]
		get
		{
			return (<D>j__TPar)null;
		}
	}

	[Token(Token = "0x17000009")]
	public <E>j__TPar E
	{
		[Token(Token = "0x600000D")]
		get
		{
			return (<E>j__TPar)null;
		}
	}

	[Token(Token = "0x1700000A")]
	public <F>j__TPar F
	{
		[Token(Token = "0x600000E")]
		get
		{
			return (<F>j__TPar)null;
		}
	}

	[Token(Token = "0x600000F")]
	[DebuggerHidden]
	public <>f__AnonymousType1(<A>j__TPar A, <B>j__TPar B, <C>j__TPar C, <D>j__TPar D, <E>j__TPar E, <F>j__TPar F)
	{
	}

	[Token(Token = "0x6000010")]
	[DebuggerHidden]
	public override bool Equals(object value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000011")]
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000012")]
	[DebuggerHidden]
	public override string ToString()
	{
		return null;
	}
}
namespace Microsoft.CodeAnalysis
{
	[Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2E98", Offset = "0x9C2E98")]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x168E78C", Offset = "0x168E78C", VA = "0x168E78C")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Token(Token = "0x2000005")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2ED0", Offset = "0x9C2ED0")]
	internal sealed class IsReadOnlyAttribute : Attribute
	{
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x169AD8C", Offset = "0x169AD8C", VA = "0x169AD8C")]
		public IsReadOnlyAttribute()
		{
		}
	}
}
[Token(Token = "0x2000006")]
public class MeshDebuggerProxyUI : BaseMeshEffect
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh mesh;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action callback;

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1671EA4", Offset = "0x1671EA4", VA = "0x1671EA4", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1671FC8", Offset = "0x1671FC8", VA = "0x1671FC8", Slot = "8")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1672070", Offset = "0x1672070", VA = "0x1672070", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x16720C0", Offset = "0x16720C0", VA = "0x16720C0")]
	public MeshDebuggerProxyUI()
	{
	}
}
namespace VLB
{
	[Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C2F08", Offset = "0x9C2F08")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C2F08", Offset = "0x9C2F08")]
	public class BeamGeometry : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C2F78", Offset = "0x9C2F78")]
		private sealed class <CoUpdateFadeOut>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000015")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000016")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000017")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BeamGeometry <>4__this;

			[Token(Token = "0x17000016")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000049")]
				[Address(RVA = "0x1E07130", Offset = "0x1E07130", VA = "0x1E07130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600004B")]
				[Address(RVA = "0x1E07178", Offset = "0x1E07178", VA = "0x1E07178", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000046")]
			[Address(RVA = "0x1E0707C", Offset = "0x1E0707C", VA = "0x1E0707C")]
			[DebuggerHidden]
			public <CoUpdateFadeOut>d__26(int <>1__state)
			{
			}

			[Token(Token = "0x6000047")]
			[Address(RVA = "0x1E070A8", Offset = "0x1E070A8", VA = "0x1E070A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000048")]
			[Address(RVA = "0x1E070AC", Offset = "0x1E070AC", VA = "0x1E070AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1E07138", Offset = "0x1E07138", VA = "0x1E07138", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Matrix4x4 m_ColorGradientMatrix;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshType m_CurrentMeshType;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Material m_CustomMaterial;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5854", Offset = "0x9C5854")]
		private MeshRenderer <meshRenderer>k__BackingField;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5864", Offset = "0x9C5864")]
		private MeshFilter <meshFilter>k__BackingField;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5874", Offset = "0x9C5874")]
		private Mesh <coneMesh>k__BackingField;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DynamicOcclusion _dynamicOcclusion;

		[Token(Token = "0x1700000B")]
		public MeshRenderer meshRenderer
		{
			[Token(Token = "0x6000019")]
			[Address(RVA = "0x1713FF0", Offset = "0x1713FF0", VA = "0x1713FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1248", Offset = "0x9D1248")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x1713FF8", Offset = "0x1713FF8", VA = "0x1713FF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1258", Offset = "0x9D1258")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public MeshFilter meshFilter
		{
			[Token(Token = "0x600001B")]
			[Address(RVA = "0x1714000", Offset = "0x1714000", VA = "0x1714000")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1268", Offset = "0x9D1268")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x1714008", Offset = "0x1714008", VA = "0x1714008")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1278", Offset = "0x9D1278")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public Mesh coneMesh
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x1714010", Offset = "0x1714010", VA = "0x1714010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1288", Offset = "0x9D1288")]
			get
			{
				return null;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x1714018", Offset = "0x1714018", VA = "0x1714018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1298", Offset = "0x9D1298")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public bool visible
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x1714020", Offset = "0x1714020", VA = "0x1714020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x171403C", Offset = "0x171403C", VA = "0x171403C")]
			set
			{
			}
		}

		[Token(Token = "0x1700000F")]
		public int sortingLayerID
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x171405C", Offset = "0x171405C", VA = "0x171405C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x1714078", Offset = "0x1714078", VA = "0x1714078")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int sortingOrder
		{
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x1714094", Offset = "0x1714094", VA = "0x1714094")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x17140B0", Offset = "0x17140B0", VA = "0x17140B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public static bool isCustomRenderPipelineSupported
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1714A58", Offset = "0x1714A58", VA = "0x1714A58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		private bool isNoiseEnabled
		{
			[Token(Token = "0x6000033")]
			[Address(RVA = "0x1715BB8", Offset = "0x1715BB8", VA = "0x1715BB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		private bool isClippingPlaneEnabled
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0x1715C54", Offset = "0x1715C54", VA = "0x1715C54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		private bool isDepthBlendEnabled
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0x1715D20", Offset = "0x1715D20", VA = "0x1715D20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public DynamicOcclusion dynamicOcclusion
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x1716224", Offset = "0x1716224", VA = "0x1716224")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x171622C", Offset = "0x171622C", VA = "0x171622C")]
			set
			{
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17140CC", Offset = "0x17140CC", VA = "0x17140CC")]
		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return default(float);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17141B4", Offset = "0x17141B4", VA = "0x17141B4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D12A8", Offset = "0x9D12A8")]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x171422C", Offset = "0x171422C", VA = "0x171422C")]
		private void ComputeFadeOutFactor()
		{
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1714344", Offset = "0x1714344", VA = "0x1714344")]
		private void SetFadeOutFactorProp(float value)
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1714664", Offset = "0x1714664", VA = "0x1714664")]
		private void RestartFadeOutCoroutine()
		{
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1714718", Offset = "0x1714718", VA = "0x1714718")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17147D4", Offset = "0x17147D4", VA = "0x17147D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1714890", Offset = "0x1714890", VA = "0x1714890")]
		private static bool IsUsingCustomRenderPipeline()
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1714988", Offset = "0x1714988", VA = "0x1714988")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1714A60", Offset = "0x1714A60", VA = "0x1714A60")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1714B38", Offset = "0x1714B38", VA = "0x1714B38")]
		public void Initialize(VolumetricLightBeam master)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1715158", Offset = "0x1715158", VA = "0x1715158")]
		public void RegenerateMesh()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1715B40", Offset = "0x1715B40", VA = "0x1715B40")]
		private void ComputeLocalMatrix()
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1714F2C", Offset = "0x1714F2C", VA = "0x1714F2C")]
		private bool ApplyMaterial()
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x171449C", Offset = "0x171449C", VA = "0x171449C")]
		private void SetMaterialProp(int nameID, float value)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x1715D68", Offset = "0x1715D68", VA = "0x1715D68")]
		private void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x1715E94", Offset = "0x1715E94", VA = "0x1715E94")]
		private void SetMaterialProp(int nameID, Color value)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x1715FC0", Offset = "0x1715FC0", VA = "0x1715FC0")]
		private void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x17143D0", Offset = "0x17143D0", VA = "0x17143D0")]
		private void MaterialChangeStart()
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1714598", Offset = "0x1714598", VA = "0x1714598")]
		private void MaterialChangeStop()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17160F4", Offset = "0x17160F4", VA = "0x17160F4")]
		private void SendMaterialClippingPlaneProp()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x17154B0", Offset = "0x17154B0", VA = "0x17154B0")]
		public void UpdateMaterialAndBounds()
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x1716374", Offset = "0x1716374", VA = "0x1716374")]
		private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam)
		{
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17166AC", Offset = "0x17166AC", VA = "0x17166AC")]
		private void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x1716748", Offset = "0x1716748", VA = "0x1716748")]
		private static bool IsEditorCamera(Camera cam)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x171637C", Offset = "0x171637C", VA = "0x171637C")]
		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x1716750", Offset = "0x1716750", VA = "0x1716750")]
		public BeamGeometry()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C2F88", Offset = "0x9C2F88")]
	public class Config : ScriptableObject
	{
		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool geometryOverrideLayer;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int geometryLayerID;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string geometryTag;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int geometryRenderQueue;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public RenderPipeline renderPipeline;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9C5884", Offset = "0x9C5884")]
		public bool forceSinglePass;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public RenderingMode renderingMode;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HighlightNull]
		private Shader beamShader1Pass;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C58F4", Offset = "0x9C58F4")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C58F4", Offset = "0x9C58F4")]
		[HighlightNull]
		private Shader beamShader2Pass;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int sharedMeshSides;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int sharedMeshSegments;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5974", Offset = "0x9C5974")]
		public float globalNoiseScale;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 globalNoiseVelocity;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string fadeOutCameraTag;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HighlightNull]
		public TextAsset noise3DData;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int noise3DSize;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HighlightNull]
		public ParticleSystem dustParticlesPrefab;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform m_CachedFadeOutCamera;

		[Token(Token = "0x400002B")]
		private const string kAssetName = "Config";

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Config m_Instance;

		[Token(Token = "0x17000018")]
		public RenderingMode actualRenderingMode
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1C42070", Offset = "0x1C42070", VA = "0x1C42070")]
			get
			{
				return default(RenderingMode);
			}
		}

		[Token(Token = "0x17000019")]
		public bool useSinglePassShader
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1C42078", Offset = "0x1C42078", VA = "0x1C42078")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		public Shader beamShader
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1C42088", Offset = "0x1C42088", VA = "0x1C42088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public Vector4 globalNoiseParam
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x1C420A4", Offset = "0x1C420A4", VA = "0x1C420A4")]
			get
			{
				return default(Vector4);
			}
		}

		[Token(Token = "0x1700001C")]
		public Transform fadeOutCameraTransform
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1C420DC", Offset = "0x1C420DC", VA = "0x1C420DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001D")]
		public static Config Instance
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x1C3D094", Offset = "0x1C3D094", VA = "0x1C3D094")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x1C4215C", Offset = "0x1C4215C", VA = "0x1C4215C")]
		public void ForceUpdateFadeOutCamera()
		{
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x1C42208", Offset = "0x1C42208", VA = "0x1C42208")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9D1358", Offset = "0x9D1358")]
		private static void OnStartup()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x1C42284", Offset = "0x1C42284", VA = "0x1C42284")]
		public static void OnRenderPipelineChanged(RenderPipeline pipeline)
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1C42318", Offset = "0x1C42318", VA = "0x1C42318")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1C42578", Offset = "0x1C42578", VA = "0x1C42578")]
		public ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1C427B4", Offset = "0x1C427B4", VA = "0x1C427B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1C427E4", Offset = "0x1C427E4", VA = "0x1C427E4")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1C42888", Offset = "0x1C42888", VA = "0x1C42888")]
		private static Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1C42A4C", Offset = "0x1C42A4C", VA = "0x1C42A4C")]
		public Config()
		{
		}
	}
	[Token(Token = "0x200000A")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C2FC0", Offset = "0x9C2FC0")]
	public class ConfigOverride : Config
	{
		[Token(Token = "0x400002D")]
		public const string kAssetName = "VLBConfigOverride";

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1C42B4C", Offset = "0x1C42B4C", VA = "0x1C42B4C")]
		public ConfigOverride()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public static class Consts
	{
		[Token(Token = "0x400002E")]
		private const string HelpUrlBase = "http://saladgamer.com/vlb-doc/";

		[Token(Token = "0x400002F")]
		public const string HelpUrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam/";

		[Token(Token = "0x4000030")]
		public const string HelpUrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

		[Token(Token = "0x4000031")]
		public const string HelpUrlDynamicOcclusion = "http://saladgamer.com/vlb-doc/comp-dynocclusion/";

		[Token(Token = "0x4000032")]
		public const string HelpUrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

		[Token(Token = "0x4000033")]
		public const string HelpUrlConfig = "http://saladgamer.com/vlb-doc/config/";

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly bool ProceduralObjectsVisibleInEditor;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly Color FlatColor;

		[Token(Token = "0x4000036")]
		public const ColorMode ColorModeDefault = ColorMode.Flat;

		[Token(Token = "0x4000037")]
		public const float IntensityDefault = 1f;

		[Token(Token = "0x4000038")]
		public const float IntensityMin = 0f;

		[Token(Token = "0x4000039")]
		public const float IntensityMax = 8f;

		[Token(Token = "0x400003A")]
		public const float SpotAngleDefault = 35f;

		[Token(Token = "0x400003B")]
		public const float SpotAngleMin = 0.1f;

		[Token(Token = "0x400003C")]
		public const float SpotAngleMax = 179.9f;

		[Token(Token = "0x400003D")]
		public const float ConeRadiusStart = 0.1f;

		[Token(Token = "0x400003E")]
		public const MeshType GeomMeshType = MeshType.Shared;

		[Token(Token = "0x400003F")]
		public const int GeomSidesDefault = 18;

		[Token(Token = "0x4000040")]
		public const int GeomSidesMin = 3;

		[Token(Token = "0x4000041")]
		public const int GeomSidesMax = 256;

		[Token(Token = "0x4000042")]
		public const int GeomSegmentsDefault = 5;

		[Token(Token = "0x4000043")]
		public const int GeomSegmentsMin = 0;

		[Token(Token = "0x4000044")]
		public const int GeomSegmentsMax = 64;

		[Token(Token = "0x4000045")]
		public const bool GeomCap = false;

		[Token(Token = "0x4000046")]
		public const AttenuationEquation AttenuationEquationDefault = AttenuationEquation.Quadratic;

		[Token(Token = "0x4000047")]
		public const float AttenuationCustomBlending = 0.5f;

		[Token(Token = "0x4000048")]
		public const float FallOffStart = 0f;

		[Token(Token = "0x4000049")]
		public const float FallOffEnd = 3f;

		[Token(Token = "0x400004A")]
		public const float FallOffDistancesMinThreshold = 0.01f;

		[Token(Token = "0x400004B")]
		public const float DepthBlendDistance = 2f;

		[Token(Token = "0x400004C")]
		public const float CameraClippingDistance = 0.5f;

		[Token(Token = "0x400004D")]
		public const float FresnelPowMaxValue = 10f;

		[Token(Token = "0x400004E")]
		public const float FresnelPow = 8f;

		[Token(Token = "0x400004F")]
		public const float GlareFrontal = 0.5f;

		[Token(Token = "0x4000050")]
		public const float GlareBehind = 0.5f;

		[Token(Token = "0x4000051")]
		public const NoiseMode NoiseModeDefault = NoiseMode.Disabled;

		[Token(Token = "0x4000052")]
		public const float NoiseIntensityMin = 0f;

		[Token(Token = "0x4000053")]
		public const float NoiseIntensityMax = 1f;

		[Token(Token = "0x4000054")]
		public const float NoiseIntensityDefault = 0.5f;

		[Token(Token = "0x4000055")]
		public const float NoiseScaleMin = 0.01f;

		[Token(Token = "0x4000056")]
		public const float NoiseScaleMax = 2f;

		[Token(Token = "0x4000057")]
		public const float NoiseScaleDefault = 0.5f;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly Vector3 NoiseVelocityDefault;

		[Token(Token = "0x4000059")]
		public const BlendingMode BlendingModeDefault = BlendingMode.Additive;

		[Token(Token = "0x400005A")]
		public const OccluderDimensions DynOcclusionDimensionsDefault = OccluderDimensions.Occluders3D;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly LayerMask DynOcclusionLayerMaskDefault;

		[Token(Token = "0x400005C")]
		public const bool DynOcclusionConsiderTriggersDefault = false;

		[Token(Token = "0x400005D")]
		public const float DynOcclusionMinOccluderAreaDefault = 0f;

		[Token(Token = "0x400005E")]
		public const int DynOcclusionWaitFrameCountDefault = 3;

		[Token(Token = "0x400005F")]
		public const float DynOcclusionMinSurfaceRatioDefault = 0.5f;

		[Token(Token = "0x4000060")]
		public const float DynOcclusionMinSurfaceRatioMin = 50f;

		[Token(Token = "0x4000061")]
		public const float DynOcclusionMinSurfaceRatioMax = 100f;

		[Token(Token = "0x4000062")]
		public const float DynOcclusionMaxSurfaceDotDefault = 0.25f;

		[Token(Token = "0x4000063")]
		public const float DynOcclusionMaxSurfaceAngleMin = 45f;

		[Token(Token = "0x4000064")]
		public const float DynOcclusionMaxSurfaceAngleMax = 90f;

		[Token(Token = "0x4000065")]
		public const PlaneAlignment DynOcclusionPlaneAlignmentDefault = PlaneAlignment.Surface;

		[Token(Token = "0x4000066")]
		public const float DynOcclusionPlaneOffsetDefault = 0.1f;

		[Token(Token = "0x4000067")]
		public const float DynOcclusionFadeDistanceToPlaneDefault = 0.25f;

		[Token(Token = "0x4000068")]
		public const bool ConfigGeometryOverrideLayerDefault = true;

		[Token(Token = "0x4000069")]
		public const int ConfigGeometryLayerIDDefault = 1;

		[Token(Token = "0x400006A")]
		public const string ConfigGeometryTagDefault = "Untagged";

		[Token(Token = "0x400006B")]
		public const string ConfigFadeOutCameraTagDefault = "MainCamera";

		[Token(Token = "0x400006C")]
		public const RenderQueue ConfigGeometryRenderQueueDefault = RenderQueue.Transparent;

		[Token(Token = "0x400006D")]
		public const RenderPipeline ConfigGeometryRenderPipelineDefault = RenderPipeline.BuiltIn;

		[Token(Token = "0x400006E")]
		public const RenderingMode ConfigGeometryRenderingModeDefault = RenderingMode.MultiPass;

		[Token(Token = "0x400006F")]
		public const int ConfigNoise3DSizeDefault = 64;

		[Token(Token = "0x4000070")]
		public const int ConfigSharedMeshSides = 24;

		[Token(Token = "0x4000071")]
		public const int ConfigSharedMeshSegments = 5;

		[Token(Token = "0x1700001E")]
		public static HideFlags ProceduralObjectsHideFlags
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x1C42744", Offset = "0x1C42744", VA = "0x1C42744")]
			get
			{
				return default(HideFlags);
			}
		}
	}
	[Token(Token = "0x200000C")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C2FF8", Offset = "0x9C2FF8")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C2FF8", Offset = "0x9C2FF8")]
	public class DynamicOcclusion : MonoBehaviour
	{
		[Token(Token = "0x200000D")]
		public class HitResult
		{
			[Token(Token = "0x4000082")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000083")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 normal;

			[Token(Token = "0x4000084")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000085")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Collider2D collider2D;

			[Token(Token = "0x4000086")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Collider collider3D;

			[Token(Token = "0x17000023")]
			public bool hasCollider
			{
				[Token(Token = "0x600007A")]
				[Address(RVA = "0x1E0A018", Offset = "0x1E0A018", VA = "0x1E0A018")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000024")]
			public string name
			{
				[Token(Token = "0x600007B")]
				[Address(RVA = "0x1E0A0C8", Offset = "0x1E0A0C8", VA = "0x1E0A0C8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000025")]
			public Bounds bounds
			{
				[Token(Token = "0x600007C")]
				[Address(RVA = "0x1E0A1AC", Offset = "0x1E0A1AC", VA = "0x1E0A1AC")]
				get
				{
					return default(Bounds);
				}
			}

			[Token(Token = "0x6000077")]
			[Address(RVA = "0x1E09EA4", Offset = "0x1E09EA4", VA = "0x1E09EA4")]
			public HitResult(RaycastHit hit3D)
			{
			}

			[Token(Token = "0x6000078")]
			[Address(RVA = "0x1E09F2C", Offset = "0x1E09F2C", VA = "0x1E09F2C")]
			public HitResult(RaycastHit2D hit2D)
			{
			}

			[Token(Token = "0x6000079")]
			[Address(RVA = "0x1E09FB4", Offset = "0x1E09FB4", VA = "0x1E09FB4")]
			public HitResult()
			{
			}
		}

		[Token(Token = "0x200000E")]
		private enum Direction
		{
			[Token(Token = "0x4000088")]
			Up,
			[Token(Token = "0x4000089")]
			Right,
			[Token(Token = "0x400008A")]
			Down,
			[Token(Token = "0x400008B")]
			Left
		}

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public OccluderDimensions dimensions;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask layerMask;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool considerTriggers;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float minOccluderArea;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int waitFrameCount;

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float minSurfaceRatio;

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxSurfaceDot;

		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public PlaneAlignment planeAlignment;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float planeOffset;

		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float fadeDistanceToPlane;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C59C0", Offset = "0x9C59C0")]
		private HitResult <currentHit>k__BackingField;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_FrameCountToWait;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float m_RangeMultiplier;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C59D0", Offset = "0x9C59D0")]
		private Plane <planeEquationWS>k__BackingField;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private uint m_PrevNonSubHitDirectionId;

		[Token(Token = "0x1700001F")]
		public HitResult currentHit
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x168D708", Offset = "0x168D708", VA = "0x168D708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1368", Offset = "0x9D1368")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x168D710", Offset = "0x168D710", VA = "0x168D710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1378", Offset = "0x9D1378")]
			private set
			{
			}
		}

		[Token(Token = "0x17000020")]
		public Plane planeEquationWS
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x168D718", Offset = "0x168D718", VA = "0x168D718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1388", Offset = "0x9D1388")]
			get
			{
				return default(Plane);
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x168D724", Offset = "0x168D724", VA = "0x168D724")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1398", Offset = "0x9D1398")]
			private set
			{
			}
		}

		[Token(Token = "0x17000021")]
		private QueryTriggerInteraction queryTriggerInteraction
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0x168DD58", Offset = "0x168DD58", VA = "0x168DD58")]
			get
			{
				return default(QueryTriggerInteraction);
			}
		}

		[Token(Token = "0x17000022")]
		private float raycastMaxDistance
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x168DD6C", Offset = "0x168DD6C", VA = "0x168DD6C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x168D730", Offset = "0x168D730", VA = "0x168D730")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x168D78C", Offset = "0x168D78C", VA = "0x168D78C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x168D7F8", Offset = "0x168D7F8", VA = "0x168D7F8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x168D850", Offset = "0x168D850", VA = "0x168D850")]
		private void Start()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x168D90C", Offset = "0x168D90C", VA = "0x168D90C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x168DCB0", Offset = "0x168DCB0", VA = "0x168DCB0")]
		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x168DDB4", Offset = "0x168DDB4", VA = "0x168DDB4")]
		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x168DDC8", Offset = "0x168DDC8", VA = "0x168DDC8")]
		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x168E044", Offset = "0x168E044", VA = "0x168E044")]
		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x168E2F8", Offset = "0x168E2F8", VA = "0x168E2F8")]
		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x168E47C", Offset = "0x168E47C", VA = "0x168E47C")]
		private bool IsHitValid(HitResult hit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x168D94C", Offset = "0x168D94C", VA = "0x168D94C")]
		private void ProcessRaycasts()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x168E50C", Offset = "0x168E50C", VA = "0x168E50C")]
		private void SetHit(HitResult hit)
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x168D824", Offset = "0x168D824", VA = "0x168D824")]
		private void SetHitNull()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x168E5B8", Offset = "0x168E5B8", VA = "0x168E5B8")]
		private void SetClippingPlane(Plane planeWS)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x168E6BC", Offset = "0x168E6BC", VA = "0x168E6BC")]
		private void SetClippingPlaneOff()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x168E6E4", Offset = "0x168E6E4", VA = "0x168E6E4")]
		private void SetPlaneWS(Plane planeWS)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x168E6F0", Offset = "0x168E6F0", VA = "0x168E6F0")]
		public DynamicOcclusion()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public enum ColorMode
	{
		[Token(Token = "0x400008D")]
		Flat,
		[Token(Token = "0x400008E")]
		Gradient
	}
	[Token(Token = "0x2000010")]
	public enum AttenuationEquation
	{
		[Token(Token = "0x4000090")]
		Linear,
		[Token(Token = "0x4000091")]
		Quadratic,
		[Token(Token = "0x4000092")]
		Blend
	}
	[Token(Token = "0x2000011")]
	public enum BlendingMode
	{
		[Token(Token = "0x4000094")]
		Additive,
		[Token(Token = "0x4000095")]
		SoftAdditive,
		[Token(Token = "0x4000096")]
		TraditionalTransparency
	}
	[Token(Token = "0x2000012")]
	public enum NoiseMode
	{
		[Token(Token = "0x4000098")]
		Disabled,
		[Token(Token = "0x4000099")]
		WorldSpace,
		[Token(Token = "0x400009A")]
		LocalSpace
	}
	[Token(Token = "0x2000013")]
	public enum MeshType
	{
		[Token(Token = "0x400009C")]
		Shared,
		[Token(Token = "0x400009D")]
		Custom
	}
	[Token(Token = "0x2000014")]
	public enum RenderPipeline
	{
		[Token(Token = "0x400009F")]
		BuiltIn,
		[Token(Token = "0x40000A0")]
		SRP_4_0_0_or_higher
	}
	[Token(Token = "0x2000015")]
	public enum RenderingMode
	{
		[Token(Token = "0x40000A2")]
		MultiPass,
		[Token(Token = "0x40000A3")]
		SinglePass,
		[Token(Token = "0x40000A4")]
		GPUInstancing
	}
	[Token(Token = "0x2000016")]
	public enum RenderQueue
	{
		[Token(Token = "0x40000A6")]
		Custom = 0,
		[Token(Token = "0x40000A7")]
		Background = 1000,
		[Token(Token = "0x40000A8")]
		Geometry = 2000,
		[Token(Token = "0x40000A9")]
		AlphaTest = 2450,
		[Token(Token = "0x40000AA")]
		GeometryLast = 2500,
		[Token(Token = "0x40000AB")]
		Transparent = 3000,
		[Token(Token = "0x40000AC")]
		Overlay = 4000
	}
	[Token(Token = "0x2000017")]
	public enum OccluderDimensions
	{
		[Token(Token = "0x40000AE")]
		Occluders3D,
		[Token(Token = "0x40000AF")]
		Occluders2D
	}
	[Token(Token = "0x2000018")]
	public enum PlaneAlignment
	{
		[Token(Token = "0x40000B1")]
		Surface,
		[Token(Token = "0x40000B2")]
		Beam
	}
	[Token(Token = "0x2000019")]
	public enum FadeOutCameraMode
	{
		[Token(Token = "0x40000B4")]
		MainCamera,
		[Token(Token = "0x40000B5")]
		CustomObject
	}
	[Token(Token = "0x200001A")]
	public static class GlobalMesh
	{
		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Mesh ms_Mesh;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool ms_DoubleSided;

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x16942D4", Offset = "0x16942D4", VA = "0x16942D4")]
		public static Mesh Get()
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1694518", Offset = "0x1694518", VA = "0x1694518")]
		public static void Destroy()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public static class GpuInstancing
	{
		[Token(Token = "0x40000B8")]
		public const bool isSupported = true;

		[Token(Token = "0x17000026")]
		public static bool forceEnableDepthBlend
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x1694638", Offset = "0x1694638", VA = "0x1694638")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x16946B0", Offset = "0x16946B0", VA = "0x16946B0")]
		public static void SetMaterialProperties(Material material, bool enableInstancing)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1694758", Offset = "0x1694758", VA = "0x1694758")]
		public static bool CanBeBatched(VolumetricLightBeam beamA, VolumetricLightBeam beamB, ref string reasons)
		{
			return default(bool);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x16948D0", Offset = "0x16948D0", VA = "0x16948D0")]
		public static bool CanBeBatched(VolumetricLightBeam beam, ref string reason)
		{
			return default(bool);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1694A14", Offset = "0x1694A14", VA = "0x1694A14")]
		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
	[Token(Token = "0x200001C")]
	public sealed class HighlightNullAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x16979F8", Offset = "0x16979F8", VA = "0x16979F8")]
		public HighlightNullAttribute()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class MaterialKeywordSRP
	{
		[Token(Token = "0x40000B9")]
		public const string kKeyword = "VLB_SRP_API";

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x16717D4", Offset = "0x16717D4", VA = "0x16717D4")]
		public MaterialKeywordSRP()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public static class MaterialManager
	{
		[Token(Token = "0x200001F")]
		public enum BlendingMode
		{
			[Token(Token = "0x40000C1")]
			Additive,
			[Token(Token = "0x40000C2")]
			SoftAdditive,
			[Token(Token = "0x40000C3")]
			TraditionalTransparency,
			[Token(Token = "0x40000C4")]
			Count
		}

		[Token(Token = "0x2000020")]
		public enum Noise3D
		{
			[Token(Token = "0x40000C6")]
			Off,
			[Token(Token = "0x40000C7")]
			On,
			[Token(Token = "0x40000C8")]
			Count
		}

		[Token(Token = "0x2000021")]
		public enum DepthBlend
		{
			[Token(Token = "0x40000CA")]
			Off,
			[Token(Token = "0x40000CB")]
			On,
			[Token(Token = "0x40000CC")]
			Count
		}

		[Token(Token = "0x2000022")]
		public enum ColorGradient
		{
			[Token(Token = "0x40000CE")]
			Off,
			[Token(Token = "0x40000CF")]
			MatrixLow,
			[Token(Token = "0x40000D0")]
			MatrixHigh,
			[Token(Token = "0x40000D1")]
			Count
		}

		[Token(Token = "0x2000023")]
		public enum ClippingPlane
		{
			[Token(Token = "0x40000D3")]
			Off,
			[Token(Token = "0x40000D4")]
			On,
			[Token(Token = "0x40000D5")]
			Count
		}

		[Token(Token = "0x2000024")]
		public class StaticProperties
		{
			[Token(Token = "0x40000D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public BlendingMode blendingMode;

			[Token(Token = "0x40000D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Noise3D noise3D;

			[Token(Token = "0x40000D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public DepthBlend depthBlend;

			[Token(Token = "0x40000D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public ColorGradient colorGradient;

			[Token(Token = "0x40000DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClippingPlane clippingPlane;

			[Token(Token = "0x17000027")]
			public int materialID
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x1E0C4EC", Offset = "0x1E0C4EC", VA = "0x1E0C4EC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x600008B")]
			[Address(RVA = "0x1E0C510", Offset = "0x1E0C510", VA = "0x1E0C510")]
			public void ApplyToMaterial(Material mat)
			{
			}

			[Token(Token = "0x600008C")]
			[Address(RVA = "0x1E0C778", Offset = "0x1E0C778", VA = "0x1E0C778")]
			public StaticProperties()
			{
			}
		}

		[Token(Token = "0x2000025")]
		private class MaterialsGroup
		{
			[Token(Token = "0x40000DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material[] materials;

			[Token(Token = "0x600008D")]
			[Address(RVA = "0x1E0C450", Offset = "0x1E0C450", VA = "0x1E0C450")]
			public MaterialsGroup()
			{
			}
		}

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static MaterialPropertyBlock materialPropertyBlock;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly BlendMode[] BlendingMode_SrcFactor;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static readonly BlendMode[] BlendingMode_DstFactor;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static readonly bool[] BlendingMode_AlphaAsBlack;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static int kStaticPropertiesCount;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Hashtable ms_MaterialsGroup;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x16717DC", Offset = "0x16717DC", VA = "0x16717DC")]
		public static Material NewMaterial(bool gpuInstanced)
		{
			return null;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x16719AC", Offset = "0x16719AC", VA = "0x16719AC")]
		public static Material GetInstancedMaterial(uint groupID, StaticProperties staticProps)
		{
			return null;
		}
	}
	[Token(Token = "0x2000026")]
	public static class MeshGenerator
	{
		[Token(Token = "0x40000DC")]
		private const float kMinTruncatedRadius = 0.001f;

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1672888", Offset = "0x1672888", VA = "0x1672888")]
		private static float GetAngleOffset(int numSides)
		{
			return default(float);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x16728A0", Offset = "0x16728A0", VA = "0x16728A0")]
		public static Mesh GenerateConeZ_RadiusAndAngle(float lengthZ, float radiusStart, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1673158", Offset = "0x1673158", VA = "0x1673158")]
		public static Mesh GenerateConeZ_Angle(float lengthZ, float coneAngle, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1672914", Offset = "0x1672914", VA = "0x1672914")]
		public static Mesh GenerateConeZ_Radius(float lengthZ, float radiusStart, float radiusEnd, int numSides, int numSegments, bool cap, bool doubleSided)
		{
			return null;
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x16731C8", Offset = "0x16731C8", VA = "0x16731C8")]
		public static int GetVertexCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x16731E4", Offset = "0x16731E4", VA = "0x16731E4")]
		public static int GetIndicesCount(int numSides, int numSegments, bool geomCap, bool doubleSided)
		{
			return default(int);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x167320C", Offset = "0x167320C", VA = "0x167320C")]
		public static int GetSharedMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x16732B0", Offset = "0x16732B0", VA = "0x16732B0")]
		public static int GetSharedMeshIndicesCount()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000027")]
	public static class Noise3D
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool ms_IsSupportedChecked;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_IsSupported;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Texture3D ms_NoiseTexture;

		[Token(Token = "0x40000E0")]
		private const HideFlags kHideFlags = HideFlags.HideAndDontSave;

		[Token(Token = "0x40000E1")]
		private const int kMinShaderLevel = 35;

		[Token(Token = "0x17000028")]
		public static bool isSupported
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x1676A38", Offset = "0x1676A38", VA = "0x1676A38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public static bool isProperlyLoaded
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x1676C38", Offset = "0x1676C38", VA = "0x1676C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public static string isNotSupportedString
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x1676B90", Offset = "0x1676B90", VA = "0x1676B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1676CD8", Offset = "0x1676CD8", VA = "0x1676CD8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9D13A8", Offset = "0x9D13A8")]
		private static void OnStartUp()
		{
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1676D30", Offset = "0x1676D30", VA = "0x1676D30")]
		public static void LoadIfNeeded()
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1676F9C", Offset = "0x1676F9C", VA = "0x1676F9C")]
		private static Texture3D LoadTexture3D(TextAsset textData, int size)
		{
			return null;
		}
	}
	[Token(Token = "0x2000028")]
	public static class ShaderProperties
	{
		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int FadeOutFactor;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static readonly int ClippingPlaneWS;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int ClippingPlaneProps;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int ConeSlopeCosSin;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly int ConeRadius;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static readonly int ConeApexOffsetZ;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static readonly int ColorFlat;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public static readonly int AlphaInside;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static readonly int AlphaOutside;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public static readonly int AttenuationLerpLinearQuad;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static readonly int DistanceFadeStart;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static readonly int DistanceFadeEnd;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static readonly int DistanceCamClipping;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static readonly int FresnelPow;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static readonly int GlareBehind;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public static readonly int GlareFrontal;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static readonly int DrawCap;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static readonly int DepthBlendDistance;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly int NoiseLocal;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public static readonly int NoiseParam;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static readonly int CameraParams;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public static readonly int CameraBufferSizeSRP;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly int ColorGradientMatrix;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public static readonly int LocalToWorldMatrix;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static readonly int WorldToLocalMatrix;
	}
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C309C", Offset = "0x9C309C")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C309C", Offset = "0x9C309C")]
	public class TriggerZone : MonoBehaviour
	{
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool setIsTrigger;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rangeMultiplier;

		[Token(Token = "0x40000FD")]
		private const int kMeshColliderNumSides = 8;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Mesh m_Mesh;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1DD3DF4", Offset = "0x1DD3DF4", VA = "0x1DD3DF4")]
		private void Update()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1DD4024", Offset = "0x1DD4024", VA = "0x1DD4024")]
		public TriggerZone()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public static class Utils
	{
		[Token(Token = "0x200002B")]
		public enum FloatPackingPrecision
		{
			[Token(Token = "0x4000102")]
			High = 64,
			[Token(Token = "0x4000103")]
			Low = 8,
			[Token(Token = "0x4000104")]
			Undef = 0
		}

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FloatPackingPrecision ms_FloatPackingPrecision;

		[Token(Token = "0x4000100")]
		private const int kFloatPackingHighMinShaderLevel = 35;

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1E00260", Offset = "0x1E00260", VA = "0x1E00260")]
		public static float ComputeConeRadiusEnd(float fallOffEnd, float spotAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60000A1")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1E00298", Offset = "0x1E00298", VA = "0x1E00298")]
		public static string GetPath(Transform current)
		{
			return null;
		}

		[Token(Token = "0x60000A3")]
		public static T NewWithComponent<T>(string name) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60000A4")]
		public static T GetOrAddComponent<T>(this GameObject self) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		public static T GetOrAddComponent<T>(this MonoBehaviour self) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1E003D0", Offset = "0x1E003D0", VA = "0x1E003D0")]
		public static bool HasFlag(this Enum mask, Enum flags)
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1E004B0", Offset = "0x1E004B0", VA = "0x1E004B0")]
		public static Vector2 xy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1E004B4", Offset = "0x1E004B4", VA = "0x1E004B4")]
		public static Vector2 xz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1E004BC", Offset = "0x1E004BC", VA = "0x1E004BC")]
		public static Vector2 yz(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1E004C8", Offset = "0x1E004C8", VA = "0x1E004C8")]
		public static Vector2 yx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1E004D8", Offset = "0x1E004D8", VA = "0x1E004D8")]
		public static Vector2 zx(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1E004E4", Offset = "0x1E004E4", VA = "0x1E004E4")]
		public static Vector2 zy(this Vector3 aVector)
		{
			return default(Vector2);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1E004EC", Offset = "0x1E004EC", VA = "0x1E004EC")]
		public static float GetVolumeCubic(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1E00540", Offset = "0x1E00540", VA = "0x1E00540")]
		public static float GetMaxArea2D(this Bounds self)
		{
			return default(float);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1E005E0", Offset = "0x1E005E0", VA = "0x1E005E0")]
		public static Color Opaque(this Color self)
		{
			return default(Color);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1E00614", Offset = "0x1E00614", VA = "0x1E00614")]
		public static void GizmosDrawPlane(Vector3 normal, Vector3 position, Color color, float size = 1f)
		{
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1E008A0", Offset = "0x1E008A0", VA = "0x1E008A0")]
		public static Plane TranslateCustom(this Plane plane, Vector3 translation)
		{
			return default(Plane);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1E00948", Offset = "0x1E00948", VA = "0x1E00948")]
		public static bool IsValid(this Plane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1E00994", Offset = "0x1E00994", VA = "0x1E00994")]
		public static void SetKeywordEnabled(this Material mat, string name, bool enabled)
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1E009B8", Offset = "0x1E009B8", VA = "0x1E009B8")]
		public static void SetShaderKeywordEnabled(string name, bool enabled)
		{
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1E009CC", Offset = "0x1E009CC", VA = "0x1E009CC")]
		public static Matrix4x4 SampleInMatrix(this Gradient self, int floatPackingPrecision)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1E00BE8", Offset = "0x1E00BE8", VA = "0x1E00BE8")]
		public static Color[] SampleInArray(this Gradient self, int samplesCount)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1E00CCC", Offset = "0x1E00CCC", VA = "0x1E00CCC")]
		private static Vector4 Vector4_Floor(Vector4 vec)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x1E00AF0", Offset = "0x1E00AF0", VA = "0x1E00AF0")]
		public static float PackToFloat(this Color color, int floatPackingPrecision)
		{
			return default(float);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x1E00D0C", Offset = "0x1E00D0C", VA = "0x1E00D0C")]
		public static FloatPackingPrecision GetFloatPackingPrecision()
		{
			return default(FloatPackingPrecision);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x1E00DD8", Offset = "0x1E00DD8", VA = "0x1E00DD8")]
		public static void MarkCurrentSceneDirty()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1E00DDC", Offset = "0x1E00DDC", VA = "0x1E00DDC")]
		public static void MarkObjectDirty(UnityEngine.Object obj)
		{
		}
	}
	[Token(Token = "0x200002C")]
	public static class Version
	{
		[Token(Token = "0x4000105")]
		public const int Current = 1750;
	}
	[Token(Token = "0x200002D")]
	[DisallowMultipleComponent]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3140", Offset = "0x9C3140")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3140", Offset = "0x9C3140")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		[Token(Token = "0x200002E")]
		public enum Direction
		{
			[Token(Token = "0x4000117")]
			Beam,
			[Token(Token = "0x4000118")]
			Random
		}

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C59E0", Offset = "0x9C59E0")]
		public float alpha;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C59F8", Offset = "0x9C59F8")]
		public float size;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Direction direction;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speed;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float density;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5A18", Offset = "0x9C5A18")]
		public float spawnMinDistance;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5A30", Offset = "0x9C5A30")]
		public float spawnMaxDistance;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool cullingEnabled;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float cullingMaxDistance;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5A48", Offset = "0x9C5A48")]
		private bool <isCulled>k__BackingField;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool isFeatureSupported;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ParticleSystem m_Particles;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private ParticleSystemRenderer m_Renderer;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool ms_NoMainCameraLogged;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Camera ms_MainCamera;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private VolumetricLightBeam m_Master;

		[Token(Token = "0x1700002B")]
		public bool isCulled
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x1E03D08", Offset = "0x1E03D08", VA = "0x1E03D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D14D8", Offset = "0x9D14D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x1E03D10", Offset = "0x1E03D10", VA = "0x1E03D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D14E8", Offset = "0x9D14E8")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool particlesAreInstantiated
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0x1E03D1C", Offset = "0x1E03D1C", VA = "0x1E03D1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public int particlesCurrentCount
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0x1E03D84", Offset = "0x1E03D84", VA = "0x1E03D84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public int particlesMaxCount
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0x1E03E14", Offset = "0x1E03E14", VA = "0x1E03E14")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002F")]
		public Camera mainCamera
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0x1E03EBC", Offset = "0x1E03EBC", VA = "0x1E03EBC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1E0414C", Offset = "0x1E0414C", VA = "0x1E0414C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1E041BC", Offset = "0x1E041BC", VA = "0x1E041BC")]
		private void InstantiateParticleSystem()
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1E04478", Offset = "0x1E04478", VA = "0x1E04478")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1E043C0", Offset = "0x1E043C0", VA = "0x1E043C0")]
		private void SetActiveAndPlay()
		{
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1E04B48", Offset = "0x1E04B48", VA = "0x1E04B48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1E04BE4", Offset = "0x1E04BE4", VA = "0x1E04BE4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1E04CA8", Offset = "0x1E04CA8", VA = "0x1E04CA8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1E0447C", Offset = "0x1E0447C", VA = "0x1E0447C")]
		private void SetParticleProperties()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1E04CDC", Offset = "0x1E04CDC", VA = "0x1E04CDC")]
		private void UpdateCulling()
		{
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1E05070", Offset = "0x1E05070", VA = "0x1E05070")]
		public VolumetricDustParticles()
		{
		}
	}
	[Token(Token = "0x200002F")]
	[DisallowMultipleComponent]
	[SelectionBase]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C31E4", Offset = "0x9C31E4")]
	[ExecuteInEditMode]
	public class VolumetricLightBeam : MonoBehaviour
	{
		[Token(Token = "0x2000030")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3250", Offset = "0x9C3250")]
		private sealed class <CoPlaytimeUpdate>d__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000144")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000145")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000146")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VolumetricLightBeam <>4__this;

			[Token(Token = "0x1700004D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600010F")]
				[Address(RVA = "0x1E0E94C", Offset = "0x1E0E94C", VA = "0x1E0E94C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000111")]
				[Address(RVA = "0x1E0E994", Offset = "0x1E0E994", VA = "0x1E0E994", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600010C")]
			[Address(RVA = "0x1E065BC", Offset = "0x1E065BC", VA = "0x1E065BC")]
			[DebuggerHidden]
			public <CoPlaytimeUpdate>d__126(int <>1__state)
			{
			}

			[Token(Token = "0x600010D")]
			[Address(RVA = "0x1E0E8B4", Offset = "0x1E0E8B4", VA = "0x1E0E8B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600010E")]
			[Address(RVA = "0x1E0E8B8", Offset = "0x1E0E8B8", VA = "0x1E0E8B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000110")]
			[Address(RVA = "0x1E0E954", Offset = "0x1E0E954", VA = "0x1E0E954", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool colorFromLight;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public ColorMode colorMode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0x9C5A58", Offset = "0x9C5A58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5A58", Offset = "0x9C5A58")]
		public Color color;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Gradient colorGradient;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool intensityFromLight;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool intensityModeAdvanced;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5AAC", Offset = "0x9C5AAC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5AAC", Offset = "0x9C5AAC")]
		public float intensityInside;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5B00", Offset = "0x9C5B00")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5B00", Offset = "0x9C5B00")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5B00", Offset = "0x9C5B00")]
		public float intensityOutside;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public BlendingMode blendingMode;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5B78", Offset = "0x9C5B78")]
		public bool spotAngleFromLight;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5BB0", Offset = "0x9C5BB0")]
		public float spotAngle;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5BD0", Offset = "0x9C5BD0")]
		public float coneRadiusStart;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public MeshType geomMeshType;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5C08", Offset = "0x9C5C08")]
		public int geomCustomSides;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public int geomCustomSegments;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool geomCap;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5C40", Offset = "0x9C5C40")]
		public bool fallOffEndFromLight;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public AttenuationEquation attenuationEquation;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5C78", Offset = "0x9C5C78")]
		public float attenuationCustomBlending;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5C90", Offset = "0x9C5C90")]
		public float fallOffStart;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5CC8", Offset = "0x9C5CC8")]
		public float fallOffEnd;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float depthBlendDistance;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float cameraClippingDistance;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5D00", Offset = "0x9C5D00")]
		public float glareFrontal;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5D18", Offset = "0x9C5D18")]
		public float glareBehind;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5D30", Offset = "0x9C5D30")]
		public float fresnelPow;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public NoiseMode noiseMode;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5D68", Offset = "0x9C5D68")]
		[SerializeField]
		private bool _DEPRECATED_NoiseEnabled;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5DB4", Offset = "0x9C5DB4")]
		public float noiseIntensity;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public bool noiseScaleUseGlobal;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5DCC", Offset = "0x9C5DCC")]
		public float noiseScaleLocal;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool noiseVelocityUseGlobal;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 noiseVelocityLocal;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float fadeOutBegin;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float fadeOutEnd;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private int pluginVersion;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5DF8", Offset = "0x9C5DF8")]
		[SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int _SortingLayerID;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private int _SortingOrder;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5E64", Offset = "0x9C5E64")]
		private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BeamGeometry m_BeamGeom;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Coroutine m_CoPlaytimeUpdate;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Light _CachedLight;

		[Token(Token = "0x17000030")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2DCC", Offset = "0x9D2DCC")]
		public float alphaInside
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x1E0511C", Offset = "0x1E0511C", VA = "0x1E0511C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x1E05124", Offset = "0x1E05124", VA = "0x1E05124")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2E04", Offset = "0x9D2E04")]
		public float alphaOutside
		{
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x1E0512C", Offset = "0x1E0512C", VA = "0x1E0512C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000D1")]
			[Address(RVA = "0x1E05134", Offset = "0x1E05134", VA = "0x1E05134")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public float intensityGlobal
		{
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x1E0513C", Offset = "0x1E0513C", VA = "0x1E0513C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000D3")]
			[Address(RVA = "0x1E05144", Offset = "0x1E05144", VA = "0x1E05144")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public float coneAngle
		{
			[Token(Token = "0x60000D4")]
			[Address(RVA = "0x1E04E9C", Offset = "0x1E04E9C", VA = "0x1E04E9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public float coneRadiusEnd
		{
			[Token(Token = "0x60000D5")]
			[Address(RVA = "0x1E0514C", Offset = "0x1E0514C", VA = "0x1E0514C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000035")]
		public float coneVolume
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x1E051D4", Offset = "0x1E051D4", VA = "0x1E051D4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public float coneApexOffsetZ
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x1E05228", Offset = "0x1E05228", VA = "0x1E05228")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000037")]
		public int geomSides
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x1E05280", Offset = "0x1E05280", VA = "0x1E05280")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x1E05308", Offset = "0x1E05308", VA = "0x1E05308")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public int geomSegments
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x1E05390", Offset = "0x1E05390", VA = "0x1E05390")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x1E05418", Offset = "0x1E05418", VA = "0x1E05418")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2E3C", Offset = "0x9D2E3C")]
		public bool fadeEndFromLight
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x1E054A0", Offset = "0x1E054A0", VA = "0x1E054A0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x1E054A8", Offset = "0x1E054A8", VA = "0x1E054A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700003A")]
		public float attenuationLerpLinearQuad
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x1E054B4", Offset = "0x1E054B4", VA = "0x1E054B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003B")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2E74", Offset = "0x9D2E74")]
		public float fadeStart
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x1E054DC", Offset = "0x1E054DC", VA = "0x1E054DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x1E054E4", Offset = "0x1E054E4", VA = "0x1E054E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2EAC", Offset = "0x9D2EAC")]
		public float fadeEnd
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x1E054EC", Offset = "0x1E054EC", VA = "0x1E054EC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x1E054F4", Offset = "0x1E054F4", VA = "0x1E054F4")]
			set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool isNoiseEnabled
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x1E054FC", Offset = "0x1E054FC", VA = "0x1E054FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2EE4", Offset = "0x9D2EE4")]
		public bool noiseEnabled
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x1E0550C", Offset = "0x1E0550C", VA = "0x1E0550C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x1E0551C", Offset = "0x1E0551C", VA = "0x1E0551C")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool isFadeOutEnabled
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x1E05538", Offset = "0x1E05538", VA = "0x1E05538")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public int sortingLayerID
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x1E05548", Offset = "0x1E05548", VA = "0x1E05548")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0x1E05550", Offset = "0x1E05550", VA = "0x1E05550")]
			set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public string sortingLayerName
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0x1E055F4", Offset = "0x1E055F4", VA = "0x1E055F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000EA")]
			[Address(RVA = "0x1E05600", Offset = "0x1E05600", VA = "0x1E05600")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public int sortingOrder
		{
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x1E05630", Offset = "0x1E05630", VA = "0x1E05630")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x1E05638", Offset = "0x1E05638", VA = "0x1E05638")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool trackChangesDuringPlaytime
		{
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x1E056DC", Offset = "0x1E056DC", VA = "0x1E056DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x1E056E4", Offset = "0x1E056E4", VA = "0x1E056E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000044")]
		public bool isCurrentlyTrackingChanges
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x1E0575C", Offset = "0x1E0575C", VA = "0x1E0575C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool hasGeometry
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x1E04EDC", Offset = "0x1E04EDC", VA = "0x1E04EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public Bounds bounds
		{
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x1E04F48", Offset = "0x1E04F48", VA = "0x1E04F48")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000047")]
		public int blendingModeAsInt
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x1E059B8", Offset = "0x1E059B8", VA = "0x1E059B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000048")]
		public uint _INTERNAL_InstancedMaterialGroupID
		{
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x1E05A9C", Offset = "0x1E05A9C", VA = "0x1E05A9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D14F8", Offset = "0x9D14F8")]
			get
			{
				return default(uint);
			}
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x1E05AA4", Offset = "0x1E05AA4", VA = "0x1E05AA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1508", Offset = "0x9D1508")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000049")]
		public string meshStats
		{
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x1E05AAC", Offset = "0x1E05AAC", VA = "0x1E05AAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public int meshVerticesCount
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x1E05C80", Offset = "0x1E05C80", VA = "0x1E05C80")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004B")]
		public int meshTrianglesCount
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1E05D58", Offset = "0x1E05D58", VA = "0x1E05D58")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		private Light lightSpotAttached
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1E05E48", Offset = "0x1E05E48", VA = "0x1E05E48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1E0576C", Offset = "0x1E0576C", VA = "0x1E0576C")]
		public void SetDynamicOcclusion(DynamicOcclusion dynamicOcclusion)
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1E0580C", Offset = "0x1E0580C", VA = "0x1E0580C")]
		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1E05F50", Offset = "0x1E05F50", VA = "0x1E05F50")]
		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return default(float);
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1E05FB0", Offset = "0x1E05FB0", VA = "0x1E05FB0")]
		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
		{
			return default(float);
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1E06108", Offset = "0x1E06108", VA = "0x1E06108")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D1518", Offset = "0x9D1518")]
		public void Generate()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1E06114", Offset = "0x1E06114", VA = "0x1E06114", Slot = "4")]
		public virtual void GenerateGeometry()
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1E06384", Offset = "0x1E06384", VA = "0x1E06384", Slot = "5")]
		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1E06418", Offset = "0x1E06418", VA = "0x1E06418")]
		private void Start()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1E06424", Offset = "0x1E06424", VA = "0x1E06424")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1E064B0", Offset = "0x1E064B0", VA = "0x1E064B0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1E056F0", Offset = "0x1E056F0", VA = "0x1E056F0")]
		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1E06544", Offset = "0x1E06544", VA = "0x1E06544")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D1550", Offset = "0x9D1550")]
		private IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1E065E8", Offset = "0x1E065E8", VA = "0x1E065E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1E065EC", Offset = "0x1E065EC", VA = "0x1E065EC")]
		private void DestroyBeam()
		{
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1E066B0", Offset = "0x1E066B0", VA = "0x1E066B0")]
		private void AssignPropertiesFromSpotLight(Light lightSpot)
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1E067AC", Offset = "0x1E067AC", VA = "0x1E067AC")]
		private void ClampProperties()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x1E06354", Offset = "0x1E06354", VA = "0x1E06354")]
		private void ValidateProperties()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x1E0626C", Offset = "0x1E0626C", VA = "0x1E0626C")]
		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1E06950", Offset = "0x1E06950", VA = "0x1E06950")]
		public VolumetricLightBeam()
		{
		}
	}
}
namespace VLB_Samples
{
	[Token(Token = "0x2000031")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3260", Offset = "0x9C3260")]
	public class CameraToggleBeamVisibility : MonoBehaviour
	{
		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode m_KeyCode;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1C3CF98", Offset = "0x1C3CF98", VA = "0x1C3CF98")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1C3D0F0", Offset = "0x1C3D0F0", VA = "0x1C3D0F0")]
		public CameraToggleBeamVisibility()
		{
		}
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C32C0", Offset = "0x9C32C0")]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool isInsideBeam;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider m_Collider;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1C3D100", Offset = "0x1C3D100", VA = "0x1C3D100")]
		private void Start()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1C3D1F0", Offset = "0x1C3D1F0", VA = "0x1C3D1F0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1C3D2B4", Offset = "0x1C3D2B4", VA = "0x1C3D2B4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x1C3D2BC", Offset = "0x1C3D2BC", VA = "0x1C3D2BC")]
		private void OnTriggerStay(Collider trigger)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1C3D384", Offset = "0x1C3D384", VA = "0x1C3D384")]
		public CheckIfInsideBeam()
		{
		}
	}
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3378", Offset = "0x9C3378")]
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x16916D8", Offset = "0x16916D8", VA = "0x16916D8")]
		private void Start()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x16917C4", Offset = "0x16917C4", VA = "0x16917C4")]
		public FeaturesNotSupportedMessage()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class FreeCameraController : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float cameraSensitivity;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float speedNormal;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float speedFactorSlow;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float speedFactorFast;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speedClimb;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float rotationH;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float rotationV;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_UseMouseView;

		[Token(Token = "0x1700004F")]
		private bool useMouseView
		{
			[Token(Token = "0x600011B")]
			[Address(RVA = "0x1691D40", Offset = "0x1691D40", VA = "0x1691D40")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600011C")]
			[Address(RVA = "0x1691D48", Offset = "0x1691D48", VA = "0x1691D48")]
			set
			{
			}
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1691D84", Offset = "0x1691D84", VA = "0x1691D84")]
		private void Start()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x1691E1C", Offset = "0x1691E1C", VA = "0x1691E1C")]
		private void Update()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1692330", Offset = "0x1692330", VA = "0x1692330")]
		public FreeCameraController()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class LightGenerator : MonoBehaviour
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5E84", Offset = "0x9C5E84")]
		private int CountX;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9C5EC8", Offset = "0x9C5EC8")]
		[SerializeField]
		private int CountY;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float OffsetUnits;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float PositionY;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool NoiseEnabled;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool AddLight;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x16710C0", Offset = "0x16710C0", VA = "0x16710C0")]
		public void Generate()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x16717B8", Offset = "0x16717B8", VA = "0x16717B8")]
		public LightGenerator()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public class Rotater : MonoBehaviour
	{
		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C5F4C", Offset = "0x9C5F4C")]
		public Vector3 EulerSpeed;

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x168082C", Offset = "0x168082C", VA = "0x168082C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x1680900", Offset = "0x1680900", VA = "0x1680900")]
		public Rotater()
		{
		}
	}
}
namespace RuntimeInspectorNamespace
{
	[Token(Token = "0x2000037")]
	public class ColorWheelControl : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler, IPointerUpHandler
	{
		[Token(Token = "0x2000038")]
		public delegate void OnColorChangedDelegate(Color32 color);

		[Token(Token = "0x400015A")]
		private const float RGB_CONST = 2f / (float)Math.PI;

		[Token(Token = "0x400015B")]
		private const float G_CONST = (float)Math.PI * 2f / 3f;

		[Token(Token = "0x400015C")]
		private const float B_CONST = 4.1887903f;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Color m_color;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C5F84", Offset = "0x9C5F84")]
		private float <Alpha>k__BackingField;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RectTransform rectTransform;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform SelectorOut;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform SelectorIn;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WindowDragHandler colorPickerWindow;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float outer;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector2 inner;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Material mat;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool draggingOuter;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool draggingInner;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float halfSize;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float halfSizeSqr;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float outerCirclePaddingSqr;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float innerSquareHalfSize;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int pointerId;

		[Token(Token = "0x17000050")]
		public Color Color
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x1C3ECA0", Offset = "0x1C3ECA0", VA = "0x1C3ECA0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x1C3ECAC", Offset = "0x1C3ECAC", VA = "0x1C3ECAC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public float Alpha
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x1C3ED5C", Offset = "0x1C3ED5C", VA = "0x1C3ED5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1600", Offset = "0x9D1600")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x1C3ED64", Offset = "0x1C3ED64", VA = "0x1C3ED64")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1610", Offset = "0x9D1610")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event OnColorChangedDelegate OnColorChanged
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1C3E2C0", Offset = "0x1C3E2C0", VA = "0x1C3E2C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1620", Offset = "0x9D1620")]
			add
			{
			}
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1C3ED6C", Offset = "0x1C3ED6C", VA = "0x1C3ED6C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1630", Offset = "0x9D1630")]
			remove
			{
			}
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1C3EE0C", Offset = "0x1C3EE0C", VA = "0x1C3EE0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1C3EFA8", Offset = "0x1C3EFA8", VA = "0x1C3EFA8")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1C3EF34", Offset = "0x1C3EF34", VA = "0x1C3EF34")]
		private void UpdateProperties()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1C3E4B8", Offset = "0x1C3E4B8", VA = "0x1C3E4B8")]
		public void PickColor(Color c)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1C3F1D4", Offset = "0x1C3F1D4", VA = "0x1C3F1D4", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1C3F3AC", Offset = "0x1C3F3AC", VA = "0x1C3F3AC", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1C3F4B4", Offset = "0x1C3F4B4", VA = "0x1C3F4B4", Slot = "6")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1C3F304", Offset = "0x1C3F304", VA = "0x1C3F304")]
		private void GetSelectedColor(Vector2 pointerPos)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1C3F594", Offset = "0x1C3F594", VA = "0x1C3F594")]
		private void UpdateColor()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1C3F0D0", Offset = "0x1C3F0D0", VA = "0x1C3F0D0")]
		private Color GetCurrentBaseColor()
		{
			return default(Color);
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1C3F034", Offset = "0x1C3F034", VA = "0x1C3F034")]
		private void UpdateSelectors()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1C3F6A4", Offset = "0x1C3F6A4", VA = "0x1C3F6A4")]
		public ColorWheelControl()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class RuntimeHierarchy : SkinnedWindow
	{
		[Token(Token = "0x200003A")]
		public delegate void SelectionChangedDelegate(Transform selection);

		[Token(Token = "0x200003B")]
		public delegate void DoubleClickDelegate(Transform selection);

		[Token(Token = "0x400016E")]
		private const string POOL_OBJECT_NAME = "RuntimeHierarchyPool";

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float refreshInterval;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float nextRefreshTime;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float m_objectNamesRefreshInterval;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int poolCapacity;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform poolParent;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int aliveHierarchies;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<HierarchyItem> sceneDrawerPool;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static List<HierarchyItem> transformDrawerPool;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_exposeUnityScenes;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		private bool m_exposeDontDestroyOnLoadScene;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string[] pseudoScenesOrder;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool m_createDraggedReferenceOnHold;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_draggedReferenceHoldTime;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool m_canReorganizeItems;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float doubleClickThreshold;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float lastClickTime;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RuntimeInspector m_connectedInspector;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ScrollRect scrollView;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private RectTransform drawArea;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image scrollbar;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private List<HierarchyItemRoot> sceneDrawers;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private HierarchyItemRoot sceneDrawerPrefab;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private HierarchyItemTransform transformDrawerPrefab;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private HierarchyItem currentlySelectedDrawer;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Dictionary<string, HierarchyItemRoot> pseudoSceneDrawers;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Transform m_currentSelection;

		[Token(Token = "0x17000052")]
		public float ObjectNamesRefreshInterval
		{
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x1680934", Offset = "0x1680934", VA = "0x1680934")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000053")]
		public bool ExposeUnityScenes
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x168093C", Offset = "0x168093C", VA = "0x168093C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x1680944", Offset = "0x1680944", VA = "0x1680944")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public bool ExposeDontDestroyOnLoadScene
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x1680DF0", Offset = "0x1680DF0", VA = "0x1680DF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1680DF8", Offset = "0x1680DF8", VA = "0x1680DF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool CreateDraggedReferenceOnHold
		{
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x1680FFC", Offset = "0x1680FFC", VA = "0x1680FFC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x1681004", Offset = "0x1681004", VA = "0x1681004")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public float DraggedReferenceHoldTime
		{
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x1681010", Offset = "0x1681010", VA = "0x1681010")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000142")]
			[Address(RVA = "0x1681018", Offset = "0x1681018", VA = "0x1681018")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public bool CanReorganizeItems
		{
			[Token(Token = "0x6000143")]
			[Address(RVA = "0x1681020", Offset = "0x1681020", VA = "0x1681020")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000144")]
			[Address(RVA = "0x1681028", Offset = "0x1681028", VA = "0x1681028")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public RuntimeInspector ConnectedInspector
		{
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x1681034", Offset = "0x1681034", VA = "0x1681034")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x168103C", Offset = "0x168103C", VA = "0x168103C")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public Transform CurrentSelection
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x16813C0", Offset = "0x16813C0", VA = "0x16813C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x16813C8", Offset = "0x16813C8", VA = "0x16813C8")]
			private set
			{
			}
		}

		[Token(Token = "0x14000002")]
		public event SelectionChangedDelegate OnSelectionChanged
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x1681140", Offset = "0x1681140", VA = "0x1681140")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1640", Offset = "0x9D1640")]
			add
			{
			}
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x16811E0", Offset = "0x16811E0", VA = "0x16811E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1650", Offset = "0x9D1650")]
			remove
			{
			}
		}

		[Token(Token = "0x14000003")]
		public event DoubleClickDelegate OnItemDoubleClicked
		{
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x1681280", Offset = "0x1681280", VA = "0x1681280")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1660", Offset = "0x9D1660")]
			add
			{
			}
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x1681320", Offset = "0x1681320", VA = "0x1681320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1670", Offset = "0x9D1670")]
			remove
			{
			}
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x16814D8", Offset = "0x16814D8", VA = "0x16814D8", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x168173C", Offset = "0x168173C", VA = "0x168173C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x16818F8", Offset = "0x16818F8", VA = "0x16818F8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1681A94", Offset = "0x1681A94", VA = "0x1681A94", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1681AF0", Offset = "0x1681AF0", VA = "0x1681AF0")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1681B94", Offset = "0x1681B94", VA = "0x1681B94")]
		public void RefreshNameOf(Transform target)
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1681D8C", Offset = "0x1681D8C", VA = "0x1681D8C", Slot = "6")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1681EB8", Offset = "0x1681EB8", VA = "0x1681EB8")]
		public void OnClicked(HierarchyItem drawer)
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1682144", Offset = "0x1682144", VA = "0x1682144")]
		public bool Select(Transform selection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x16824AC", Offset = "0x16824AC", VA = "0x16824AC")]
		public void Deselect()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1680A44", Offset = "0x1680A44", VA = "0x1680A44")]
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1680C28", Offset = "0x1680C28", VA = "0x1680C28")]
		private void OnSceneUnloaded(Scene arg0)
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1680E5C", Offset = "0x1680E5C", VA = "0x1680E5C")]
		private Scene GetDontDestroyOnLoadScene()
		{
			return default(Scene);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x167EAD0", Offset = "0x167EAD0", VA = "0x167EAD0")]
		public void AddToPseudoScene(string scene, Transform transform)
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x168268C", Offset = "0x168268C", VA = "0x168268C")]
		public void AddToPseudoScene(string scene, IEnumerable<Transform> transforms)
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x167EB04", Offset = "0x167EB04", VA = "0x167EB04")]
		public void RemoveFromPseudoScene(string scene, Transform transform, bool deleteSceneIfEmpty)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1682B00", Offset = "0x1682B00", VA = "0x1682B00")]
		public void RemoveFromPseudoScene(string scene, IEnumerable<Transform> transforms, bool deleteSceneIfEmpty)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x16825A0", Offset = "0x16825A0", VA = "0x16825A0")]
		private HierarchyRootPseudoScene GetPseudoScene(string scene, bool createIfNotExists)
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1682FD4", Offset = "0x1682FD4", VA = "0x1682FD4")]
		public void CreatePseudoScene(string scene)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1682E00", Offset = "0x1682E00", VA = "0x1682E00")]
		private HierarchyRootPseudoScene CreatePseudoSceneInternal(string scene)
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1683058", Offset = "0x1683058", VA = "0x1683058")]
		public void DeleteAllPseudoScenes()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1682968", Offset = "0x1682968", VA = "0x1682968")]
		public void DeletePseudoScene(string scene)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x16824B4", Offset = "0x16824B4", VA = "0x16824B4")]
		private HierarchyItemRoot InstantiateSceneDrawer(IHierarchyRootContent target)
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x16833A0", Offset = "0x16833A0", VA = "0x16833A0")]
		public HierarchyItemTransform InstantiateTransformDrawer(Transform drawerParent)
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x16831CC", Offset = "0x16831CC", VA = "0x16831CC")]
		private HierarchyItem InstantiateDrawer(List<HierarchyItem> drawerPool, HierarchyItem drawerPrefab, Transform drawerParent)
		{
			return null;
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x168346C", Offset = "0x168346C", VA = "0x168346C")]
		public void PoolDrawer(HierarchyItem drawer)
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x16836E0", Offset = "0x16836E0", VA = "0x16836E0")]
		public RuntimeHierarchy()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x1683888", Offset = "0x1683888", VA = "0x1683888")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1680", Offset = "0x9D1680")]
		private void <Awake>b__59_0(Transform transform)
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class HierarchyDragDropListener : MonoBehaviour, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HierarchyItem hierarchyItem;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RuntimeHierarchy m_hierarchy;

		[Token(Token = "0x1700005A")]
		private RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1694C90", Offset = "0x1694C90", VA = "0x1694C90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1694D78", Offset = "0x1694D78", VA = "0x1694D78")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1694E54", Offset = "0x1694E54", VA = "0x1694E54", Slot = "4")]
		public void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x16955E8", Offset = "0x16955E8", VA = "0x16955E8")]
		public HierarchyDragDropListener()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class PseudoSceneSourceTransform : MonoBehaviour
	{
		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RuntimeHierarchy m_hierarchy;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_sceneName;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_hideOnDisable;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HashSet<Transform> childrenCurrent;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HashSet<Transform> childrenNew;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool updateChildren;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool isEnabled;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool isQuitting;

		[Token(Token = "0x1700005B")]
		public RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x6000176")]
			[Address(RVA = "0x167E47C", Offset = "0x167E47C", VA = "0x167E47C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x167E484", Offset = "0x167E484", VA = "0x167E484")]
			set
			{
			}
		}

		[Token(Token = "0x1700005C")]
		public string SceneName
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x167E7E0", Offset = "0x167E7E0", VA = "0x167E7E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000179")]
			[Address(RVA = "0x167E7E8", Offset = "0x167E7E8", VA = "0x167E7E8")]
			set
			{
			}
		}

		[Token(Token = "0x1700005D")]
		public bool HideOnDisable
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x167E850", Offset = "0x167E850", VA = "0x167E850")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x167E858", Offset = "0x167E858", VA = "0x167E858")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		private bool ShouldUpdateChildren
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x167E88C", Offset = "0x167E88C", VA = "0x167E88C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x167E924", Offset = "0x167E924", VA = "0x167E924")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x167E930", Offset = "0x167E930", VA = "0x167E930")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x167E94C", Offset = "0x167E94C", VA = "0x167E94C")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x167E958", Offset = "0x167E958", VA = "0x167E958")]
		private void OnTransformChildrenChanged()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x167E964", Offset = "0x167E964", VA = "0x167E964")]
		private void Update()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x167E6FC", Offset = "0x167E6FC", VA = "0x167E6FC")]
		private void AddChildrenToScene()
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x167E534", Offset = "0x167E534", VA = "0x167E534")]
		private void RemoveChildrenFromScene()
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x167EB88", Offset = "0x167EB88", VA = "0x167EB88")]
		public PseudoSceneSourceTransform()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public abstract class HierarchyItem : MonoBehaviour
	{
		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Color NORMAL_COLOR;

		[Token(Token = "0x4000197")]
		protected const float INACTIVE_ITEM_TEXT_ALPHA = 0.57f;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool initialized;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private RuntimeHierarchy m_hierarchy;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_skinVersion;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UISkin m_skin;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LayoutGroup layoutGroup;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected RectTransform contentTransform;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		protected Text nameText;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected RectTransform drawArea;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected PointerEventListener clickListener;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Image background;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Image expandArrow;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected List<HierarchyItemTransform> children;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isExpanded;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		protected bool m_isSelected;

		[Token(Token = "0x1700005F")]
		public RuntimeHierarchy Hierarchy
		{
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x16955F0", Offset = "0x16955F0", VA = "0x16955F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000186")]
			[Address(RVA = "0x16955F8", Offset = "0x16955F8", VA = "0x16955F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public UISkin Skin
		{
			[Token(Token = "0x6000187")]
			[Address(RVA = "0x16956AC", Offset = "0x16956AC", VA = "0x16956AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x16956B4", Offset = "0x16956B4", VA = "0x16956B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		protected abstract bool IsValid
		{
			[Token(Token = "0x6000189")]
			get;
		}

		[Token(Token = "0x17000062")]
		protected abstract int ChildCount
		{
			[Token(Token = "0x600018A")]
			get;
		}

		[Token(Token = "0x17000063")]
		protected virtual bool IsActive
		{
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x1695790", Offset = "0x1695790", VA = "0x1695790", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x1695798", Offset = "0x1695798", VA = "0x1695798", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public bool IsExpanded
		{
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x169579C", Offset = "0x169579C", VA = "0x169579C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x16954CC", Offset = "0x16954CC", VA = "0x16954CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public bool IsSelected
		{
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x1695864", Offset = "0x1695864", VA = "0x1695864")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x169586C", Offset = "0x169586C", VA = "0x169586C")]
			set
			{
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x169595C", Offset = "0x169595C", VA = "0x169595C", Slot = "8")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x1695A78", Offset = "0x1695A78", VA = "0x1695A78", Slot = "9")]
		public virtual void Unbind()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x16957A4", Offset = "0x16957A4", VA = "0x16957A4")]
		private void ClearChildren()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1695AC4", Offset = "0x1695AC4", VA = "0x1695AC4", Slot = "10")]
		protected virtual void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x1695C58", Offset = "0x1695C58", VA = "0x1695C58", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x16962D0", Offset = "0x16962D0", VA = "0x16962D0")]
		public void RefreshNameOf(Transform target)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x169644C", Offset = "0x169644C", VA = "0x169644C", Slot = "12")]
		protected virtual void RefreshContent()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x1696224", Offset = "0x1696224", VA = "0x1696224")]
		private void GenerateChildItem(Transform child, int index)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x16964C8", Offset = "0x16964C8", VA = "0x16964C8")]
		public HierarchyItem SelectTransform(Transform target, [Optional] Transform nextInPath)
		{
			return null;
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x16968B8", Offset = "0x16968B8", VA = "0x16968B8")]
		protected int IndexOf(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600019B")]
		protected abstract Transform GetChild(int index);

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1696990", Offset = "0x1696990", VA = "0x1696990")]
		protected HierarchyItem()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1696A28", Offset = "0x1696A28", VA = "0x1696A28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1690", Offset = "0x9D1690")]
		private void <Initialize>b__36_0(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1696A48", Offset = "0x1696A48", VA = "0x1696A48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D16A0", Offset = "0x9D16A0")]
		private void <Initialize>b__36_1(PointerEventData eventData)
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class HierarchyItemRoot : HierarchyItem
	{
		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<GameObject> childObjects;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6194", Offset = "0x9C6194")]
		private IHierarchyRootContent <Content>k__BackingField;

		[Token(Token = "0x17000066")]
		protected override bool IsValid
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x1696A58", Offset = "0x1696A58", VA = "0x1696A58", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		protected override int ChildCount
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x1696B04", Offset = "0x1696B04", VA = "0x1696B04", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000068")]
		public IHierarchyRootContent Content
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x1696B50", Offset = "0x1696B50", VA = "0x1696B50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D16B0", Offset = "0x9D16B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x1696B58", Offset = "0x1696B58", VA = "0x1696B58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D16C0", Offset = "0x9D16C0")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x1696B60", Offset = "0x1696B60", VA = "0x1696B60")]
		public void BindTo(IHierarchyRootContent target)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1696D48", Offset = "0x1696D48", VA = "0x1696D48", Slot = "9")]
		public override void Unbind()
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1696DB4", Offset = "0x1696DB4", VA = "0x1696DB4", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x1696E60", Offset = "0x1696E60", VA = "0x1696E60", Slot = "12")]
		protected override void RefreshContent()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1696F94", Offset = "0x1696F94", VA = "0x1696F94", Slot = "13")]
		protected override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x1697010", Offset = "0x1697010", VA = "0x1697010")]
		public HierarchyItemRoot()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class HierarchyItemTransform : HierarchyItem
	{
		[Token(Token = "0x2000041")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C33D8", Offset = "0x9C33D8")]
		private sealed class <CreateReferenceItemCoroutine>d__20 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HierarchyItemTransform <>4__this;

			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PointerEventData eventData;

			[Token(Token = "0x1700006D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001BB")]
				[Address(RVA = "0x1E0A498", Offset = "0x1E0A498", VA = "0x1E0A498", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001BD")]
				[Address(RVA = "0x1E0A4E0", Offset = "0x1E0A4E0", VA = "0x1E0A4E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001B8")]
			[Address(RVA = "0x1E0A328", Offset = "0x1E0A328", VA = "0x1E0A328")]
			[DebuggerHidden]
			public <CreateReferenceItemCoroutine>d__20(int <>1__state)
			{
			}

			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x1E0A354", Offset = "0x1E0A354", VA = "0x1E0A354", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x1E0A358", Offset = "0x1E0A358", VA = "0x1E0A358", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x1E0A4A0", Offset = "0x1E0A4A0", VA = "0x1E0A4A0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C61A4", Offset = "0x9C61A4")]
		private Transform <BoundTransform>k__BackingField;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IEnumerator pointerHeldCoroutine;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float nextNameRefreshTime;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool m_isActive;

		[Token(Token = "0x17000069")]
		protected override bool IsValid
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x1697094", Offset = "0x1697094", VA = "0x1697094", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		protected override int ChildCount
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x1697108", Offset = "0x1697108", VA = "0x1697108", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006B")]
		public Transform BoundTransform
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x1697124", Offset = "0x1697124", VA = "0x1697124")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D16D0", Offset = "0x9D16D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001AC")]
			[Address(RVA = "0x169712C", Offset = "0x169712C", VA = "0x169712C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D16E0", Offset = "0x9D16E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		protected override bool IsActive
		{
			[Token(Token = "0x60001AD")]
			[Address(RVA = "0x1697134", Offset = "0x1697134", VA = "0x1697134", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x169713C", Offset = "0x169713C", VA = "0x169713C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x1697208", Offset = "0x1697208", VA = "0x1697208", Slot = "8")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x1696450", Offset = "0x1696450", VA = "0x1696450")]
		public void BindTo(Transform target)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x16972EC", Offset = "0x16972EC", VA = "0x16972EC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x1697390", Offset = "0x1697390", VA = "0x1697390")]
		private void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x16974F8", Offset = "0x16974F8", VA = "0x16974F8")]
		private void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1697540", Offset = "0x1697540", VA = "0x1697540", Slot = "9")]
		public override void Unbind()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1697464", Offset = "0x1697464", VA = "0x1697464")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D16F0", Offset = "0x9D16F0")]
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x169756C", Offset = "0x169756C", VA = "0x169756C", Slot = "13")]
		protected override Transform GetChild(int index)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1697588", Offset = "0x1697588", VA = "0x1697588")]
		public HierarchyItemTransform()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class HierarchyRootPseudoScene : IHierarchyRootContent
	{
		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string name;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C61B4", Offset = "0x9C61B4")]
		private List<GameObject> <Children>k__BackingField;

		[Token(Token = "0x1700006F")]
		public bool IsValid
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x169759C", Offset = "0x169759C", VA = "0x169759C", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000070")]
		public int ChildCount
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x16975A4", Offset = "0x16975A4", VA = "0x16975A4", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000071")]
		public string Name
		{
			[Token(Token = "0x60001C0")]
			[Address(RVA = "0x16975F0", Offset = "0x16975F0", VA = "0x16975F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		public List<GameObject> Children
		{
			[Token(Token = "0x60001C1")]
			[Address(RVA = "0x16975F8", Offset = "0x16975F8", VA = "0x16975F8", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17A0", Offset = "0x9D17A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x1697600", Offset = "0x1697600", VA = "0x1697600", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17B0", Offset = "0x9D17B0")]
			set
			{
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x1697608", Offset = "0x1697608", VA = "0x1697608")]
		public HierarchyRootPseudoScene(string name)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x169763C", Offset = "0x169763C", VA = "0x169763C")]
		public void AddChild(Transform child)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1697700", Offset = "0x1697700", VA = "0x1697700")]
		public void RemoveChild(Transform child)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1697778", Offset = "0x1697778", VA = "0x1697778", Slot = "9")]
		public void Refresh()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class HierarchyRootScene : IHierarchyRootContent
	{
		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C61C4", Offset = "0x9C61C4")]
		private Scene <Scene>k__BackingField;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C61D4", Offset = "0x9C61D4")]
		private List<GameObject> <Children>k__BackingField;

		[Token(Token = "0x17000073")]
		public bool IsValid
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x1697888", Offset = "0x1697888", VA = "0x1697888", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000074")]
		public int ChildCount
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x16978B8", Offset = "0x16978B8", VA = "0x16978B8", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000075")]
		public string Name
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x1697904", Offset = "0x1697904", VA = "0x1697904", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public Scene Scene
		{
			[Token(Token = "0x60001CA")]
			[Address(RVA = "0x1697930", Offset = "0x1697930", VA = "0x1697930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17C0", Offset = "0x9D17C0")]
			get
			{
				return default(Scene);
			}
			[Token(Token = "0x60001CB")]
			[Address(RVA = "0x1697938", Offset = "0x1697938", VA = "0x1697938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17D0", Offset = "0x9D17D0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public List<GameObject> Children
		{
			[Token(Token = "0x60001CC")]
			[Address(RVA = "0x1697940", Offset = "0x1697940", VA = "0x1697940", Slot = "7")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17E0", Offset = "0x9D17E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001CD")]
			[Address(RVA = "0x1697948", Offset = "0x1697948", VA = "0x1697948", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D17F0", Offset = "0x9D17F0")]
			set
			{
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1697950", Offset = "0x1697950", VA = "0x1697950")]
		public HierarchyRootScene(Scene target)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x169797C", Offset = "0x169797C", VA = "0x169797C", Slot = "9")]
		public void Refresh()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public interface IHierarchyRootContent
	{
		[Token(Token = "0x17000078")]
		bool IsValid
		{
			[Token(Token = "0x60001D0")]
			get;
		}

		[Token(Token = "0x17000079")]
		int ChildCount
		{
			[Token(Token = "0x60001D1")]
			get;
		}

		[Token(Token = "0x1700007A")]
		string Name
		{
			[Token(Token = "0x60001D2")]
			get;
		}

		[Token(Token = "0x1700007B")]
		List<GameObject> Children
		{
			[Token(Token = "0x60001D3")]
			get;
			[Token(Token = "0x60001D4")]
			set;
		}

		[Token(Token = "0x60001D5")]
		void Refresh();
	}
	[Token(Token = "0x2000045")]
	public class RuntimeInspector : SkinnedWindow
	{
		[Token(Token = "0x2000046")]
		public delegate object InspectedObjectChangingDelegate(object previousInspectedObject, object newInspectedObject);

		[Token(Token = "0x40001B5")]
		private const string POOL_OBJECT_NAME = "RuntimeInspectorPool";

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object m_inspectedObject;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float refreshInterval;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float nextRefreshTime;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool m_debugMode;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool m_exposePrivateFields;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool m_exposePublicFields;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		[SerializeField]
		private bool m_exposePrivateProperties;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool m_exposePublicProperties;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool m_arrayIndicesStartAtOne;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool m_useTitleCaseNaming;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int m_nestLimit;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int poolCapacity;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform poolParent;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int aliveInspectors;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, List<InspectorField>> drawersPool;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RuntimeHierarchy m_connectedHierarchy;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RuntimeInspectorSettings[] settings;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private ScrollRect scrollView;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private RectTransform drawArea;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image scrollbar;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private InspectorField currentDrawer;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool inspectLock;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
		private bool isDirty;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public InspectedObjectChangingDelegate OnInspectedObjectChanging;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<Type, InspectorField> typeToDrawer;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<Type, InspectorField> typeToReferenceDrawer;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<VariableSet> hiddenVariables;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<VariableSet> exposedVariables;

		[Token(Token = "0x1700007C")]
		public object InspectedObject
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x1683A6C", Offset = "0x1683A6C", VA = "0x1683A6C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public bool IsBound
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x1683A74", Offset = "0x1683A74", VA = "0x1683A74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public bool DebugMode
		{
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x1683AE4", Offset = "0x1683AE4", VA = "0x1683AE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x1683AEC", Offset = "0x1683AEC", VA = "0x1683AEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public bool ExposePrivateFields
		{
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x1683B14", Offset = "0x1683B14", VA = "0x1683B14")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x1683B1C", Offset = "0x1683B1C", VA = "0x1683B1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000080")]
		public bool ExposePublicFields
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x1683B44", Offset = "0x1683B44", VA = "0x1683B44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x1683B4C", Offset = "0x1683B4C", VA = "0x1683B4C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public bool ExposePrivateProperties
		{
			[Token(Token = "0x60001DE")]
			[Address(RVA = "0x1683B74", Offset = "0x1683B74", VA = "0x1683B74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DF")]
			[Address(RVA = "0x1683B7C", Offset = "0x1683B7C", VA = "0x1683B7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public bool ExposePublicProperties
		{
			[Token(Token = "0x60001E0")]
			[Address(RVA = "0x1683BA4", Offset = "0x1683BA4", VA = "0x1683BA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E1")]
			[Address(RVA = "0x1683BAC", Offset = "0x1683BAC", VA = "0x1683BAC")]
			set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public bool ArrayIndicesStartAtOne
		{
			[Token(Token = "0x60001E2")]
			[Address(RVA = "0x1683BD4", Offset = "0x1683BD4", VA = "0x1683BD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E3")]
			[Address(RVA = "0x1683BDC", Offset = "0x1683BDC", VA = "0x1683BDC")]
			set
			{
			}
		}

		[Token(Token = "0x17000084")]
		public bool UseTitleCaseNaming
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x1683C04", Offset = "0x1683C04", VA = "0x1683C04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1683C0C", Offset = "0x1683C0C", VA = "0x1683C0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public int NestLimit
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x1683C34", Offset = "0x1683C34", VA = "0x1683C34")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001E7")]
			[Address(RVA = "0x1683C3C", Offset = "0x1683C3C", VA = "0x1683C3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public RuntimeHierarchy ConnectedHierarchy
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x1683C58", Offset = "0x1683C58", VA = "0x1683C58")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x1683C60", Offset = "0x1683C60", VA = "0x1683C60")]
			set
			{
			}
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1683C68", Offset = "0x1683C68", VA = "0x1683C68", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1683F4C", Offset = "0x1683F4C", VA = "0x1683F4C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16840A8", Offset = "0x16840A8", VA = "0x16840A8", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x16841B8", Offset = "0x16841B8", VA = "0x16841B8")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1684270", Offset = "0x1684270", VA = "0x1684270", Slot = "6")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x16789D8", Offset = "0x16789D8", VA = "0x16789D8")]
		public void Inspect(object obj)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1683970", Offset = "0x1683970", VA = "0x1683970")]
		public void StopInspect()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1684310", Offset = "0x1684310", VA = "0x1684310")]
		public InspectorField CreateDrawerForType(Type type, Transform drawerParent, int depth, bool drawObjectsAsFields = true)
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1684660", Offset = "0x1684660", VA = "0x1684660")]
		private InspectorField InstantiateDrawer(InspectorField drawer, Transform drawerParent)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1684404", Offset = "0x1684404", VA = "0x1684404")]
		private InspectorField GetDrawerForType(Type type, bool drawObjectsAsFields)
		{
			return null;
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x16848B8", Offset = "0x16848B8", VA = "0x16848B8")]
		public void PoolDrawer(InspectorField drawer)
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1677CA0", Offset = "0x1677CA0", VA = "0x1677CA0")]
		public ExposedVariablesEnumerator GetExposedVariablesForType(Type type)
		{
			return null;
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1684FEC", Offset = "0x1684FEC", VA = "0x1684FEC")]
		public RuntimeInspector()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x16851D8", Offset = "0x16851D8", VA = "0x16851D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1800", Offset = "0x9D1800")]
		private object <Inspect>b__67_0()
		{
			return null;
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x16851E0", Offset = "0x16851E0", VA = "0x16851E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1810", Offset = "0x9D1810")]
		private void <Inspect>b__67_1(object value)
		{
		}
	}
	[Token(Token = "0x2000047")]
	public enum ButtonVisibility
	{
		[Token(Token = "0x40001D4")]
		None,
		[Token(Token = "0x40001D5")]
		InitializedObjects,
		[Token(Token = "0x40001D6")]
		UninitializedObjects
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C33E8", Offset = "0x9C33E8")]
	public class RuntimeInspectorButtonAttribute : Attribute
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_label;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool m_isInitializer;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private ButtonVisibility m_visibility;

		[Token(Token = "0x17000087")]
		public string Label
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x16851E8", Offset = "0x16851E8", VA = "0x16851E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		public bool IsInitializer
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x16851F0", Offset = "0x16851F0", VA = "0x16851F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000089")]
		public ButtonVisibility Visibility
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x16851F8", Offset = "0x16851F8", VA = "0x16851F8")]
			get
			{
				return default(ButtonVisibility);
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1685200", Offset = "0x1685200", VA = "0x1685200")]
		public RuntimeInspectorButtonAttribute(string label, bool isInitializer, ButtonVisibility visibility)
		{
		}
	}
	[Token(Token = "0x2000049")]
	public class ArrayField : ExpandableInspectorField, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3420", Offset = "0x9C3420")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40001DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int j;

			[Token(Token = "0x40001E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArrayField <>4__this;

			[Token(Token = "0x600020F")]
			[Address(RVA = "0x1E06D08", Offset = "0x1E06D08", VA = "0x1E06D08")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1E06D10", Offset = "0x1E06D10", VA = "0x1E06D10")]
			internal object <GenerateElements>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000211")]
			[Address(RVA = "0x1E06DA0", Offset = "0x1E06DA0", VA = "0x1E06DA0")]
			internal void <GenerateElements>b__1(object value)
			{
			}
		}

		[Token(Token = "0x200004B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3430", Offset = "0x9C3430")]
		private sealed class <>c__DisplayClass13_1
		{
			[Token(Token = "0x40001E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int j;

			[Token(Token = "0x40001E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ArrayField <>4__this;

			[Token(Token = "0x6000212")]
			[Address(RVA = "0x1E06E5C", Offset = "0x1E06E5C", VA = "0x1E06E5C")]
			public <>c__DisplayClass13_1()
			{
			}

			[Token(Token = "0x6000213")]
			[Address(RVA = "0x1E06E64", Offset = "0x1E06E64", VA = "0x1E06E64")]
			internal object <GenerateElements>b__2()
			{
				return null;
			}

			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1E06F6C", Offset = "0x1E06F6C", VA = "0x1E06F6C")]
			internal void <GenerateElements>b__3(object value)
			{
			}
		}

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private LayoutElement sizeLayoutElement;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text sizeText;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private BoundInputField sizeInput;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isArray;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Type elementType;

		[Token(Token = "0x1700008A")]
		protected override int Length
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x17122A4", Offset = "0x17122A4", VA = "0x17122A4", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1712410", Offset = "0x1712410", VA = "0x1712410", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1712730", Offset = "0x1712730", VA = "0x1712730", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1712834", Offset = "0x1712834", VA = "0x1712834", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x17128D0", Offset = "0x17128D0", VA = "0x17128D0", Slot = "8")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x17129C4", Offset = "0x17129C4", VA = "0x17129C4", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1712B28", Offset = "0x1712B28", VA = "0x1712B28", Slot = "11")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1712B88", Offset = "0x1712B88", VA = "0x1712B88", Slot = "14")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1713144", Offset = "0x1713144", VA = "0x1713144", Slot = "16")]
		public void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x17138EC", Offset = "0x17138EC", VA = "0x17138EC")]
		private bool OnSizeInputBeingChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x17133F4", Offset = "0x17133F4", VA = "0x17133F4")]
		private bool OnSizeChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1713928", Offset = "0x1713928", VA = "0x1713928")]
		private object GetTemplateElement(object value)
		{
			return null;
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1713FBC", Offset = "0x1713FBC", VA = "0x1713FBC")]
		public ArrayField()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class BoolField : InspectorField
	{
		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image toggleBackground;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Toggle input;

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1716758", Offset = "0x1716758", VA = "0x1716758", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1716828", Offset = "0x1716828", VA = "0x1716828", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x17168B4", Offset = "0x17168B4", VA = "0x17168B4")]
		private void OnValueChanged(bool input)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1716924", Offset = "0x1716924", VA = "0x1716924", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x17169A0", Offset = "0x17169A0", VA = "0x17169A0", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1716A30", Offset = "0x1716A30", VA = "0x1716A30")]
		public BoolField()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class BoundsField : InspectorField
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3Field inputCenter;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3Field inputExtents;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private MemberInfo centerVariable;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private MemberInfo extentsVariable;

		[Token(Token = "0x1700008B")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x1716C8C", Offset = "0x1716C8C", VA = "0x1716C8C", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1716C94", Offset = "0x1716C94", VA = "0x1716C94", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1716D9C", Offset = "0x1716D9C", VA = "0x1716D9C", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1716E28", Offset = "0x1716E28", VA = "0x1716E28", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1716EC4", Offset = "0x1716EC4", VA = "0x1716EC4", Slot = "9")]
		protected override void OnInspectorChanged()
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1716F10", Offset = "0x1716F10", VA = "0x1716F10", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1716F5C", Offset = "0x1716F5C", VA = "0x1716F5C", Slot = "11")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1716FB0", Offset = "0x1716FB0", VA = "0x1716FB0", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1716FFC", Offset = "0x1716FFC", VA = "0x1716FFC")]
		public BoundsField()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class ColorField : InspectorField
	{
		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PointerEventListener inputColor;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Image colorImg;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool isColor32;

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1C3D5B4", Offset = "0x1C3D5B4", VA = "0x1C3D5B4", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1C3D688", Offset = "0x1C3D688", VA = "0x1C3D688", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1C3D780", Offset = "0x1C3D780", VA = "0x1C3D780", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1C3D830", Offset = "0x1C3D830", VA = "0x1C3D830")]
		private void ShowColorPicker(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1C3DC08", Offset = "0x1C3DC08", VA = "0x1C3DC08")]
		private void OnColorChanged(Color32 color)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1C3DCE8", Offset = "0x1C3DCE8", VA = "0x1C3DCE8", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1C3DDD8", Offset = "0x1C3DDD8", VA = "0x1C3DDD8")]
		public ColorField()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class DecimalField : InspectorField
	{
		[Token(Token = "0x2000050")]
		private struct NumberParser
		{
			[Token(Token = "0x2000051")]
			private delegate bool ParseFunc(string input, out object value);

			[Token(Token = "0x2000052")]
			private delegate bool EqualsFunc(object value1, object value2);

			[Serializable]
			[Token(Token = "0x2000053")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3440", Offset = "0x9C3440")]
			private sealed class <>c
			{
				[Token(Token = "0x40001F0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly <>c <>9;

				[Token(Token = "0x40001F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static ParseFunc <>9__4_0;

				[Token(Token = "0x40001F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static EqualsFunc <>9__4_1;

				[Token(Token = "0x40001F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static ParseFunc <>9__4_2;

				[Token(Token = "0x40001F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public static EqualsFunc <>9__4_3;

				[Token(Token = "0x40001F5")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public static ParseFunc <>9__4_4;

				[Token(Token = "0x40001F6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public static EqualsFunc <>9__4_5;

				[Token(Token = "0x600023E")]
				[Address(RVA = "0x1E0EA00", Offset = "0x1E0EA00", VA = "0x1E0EA00")]
				public <>c()
				{
				}

				[Token(Token = "0x600023F")]
				[Address(RVA = "0x1E0EA08", Offset = "0x1E0EA08", VA = "0x1E0EA08")]
				internal bool <.ctor>b__4_0(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x6000240")]
				[Address(RVA = "0x1E0EA98", Offset = "0x1E0EA98", VA = "0x1E0EA98")]
				internal bool <.ctor>b__4_1(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x6000241")]
				[Address(RVA = "0x1E0EB58", Offset = "0x1E0EB58", VA = "0x1E0EB58")]
				internal bool <.ctor>b__4_2(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x6000242")]
				[Address(RVA = "0x1E0EC08", Offset = "0x1E0EC08", VA = "0x1E0EC08")]
				internal bool <.ctor>b__4_3(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x6000243")]
				[Address(RVA = "0x1E0ECC8", Offset = "0x1E0ECC8", VA = "0x1E0ECC8")]
				internal bool <.ctor>b__4_4(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x6000244")]
				[Address(RVA = "0x1E0ED78", Offset = "0x1E0ED78", VA = "0x1E0ED78")]
				internal bool <.ctor>b__4_5(object value1, object value2)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x40001EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ParseFunc parseFunction;

			[Token(Token = "0x40001EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly EqualsFunc equalsFunction;

			[Token(Token = "0x6000232")]
			[Address(RVA = "0x1E089E0", Offset = "0x1E089E0", VA = "0x1E089E0")]
			public NumberParser(Type fieldType)
			{
			}

			[Token(Token = "0x6000233")]
			[Address(RVA = "0x1E08F98", Offset = "0x1E08F98", VA = "0x1E08F98")]
			public bool TryParse(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x6000234")]
			[Address(RVA = "0x1E0934C", Offset = "0x1E0934C", VA = "0x1E0934C")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField input;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NumberParser parser;

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x168BCF0", Offset = "0x168BCF0", VA = "0x168BCF0", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x168BDFC", Offset = "0x168BDFC", VA = "0x168BDFC", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x168BF44", Offset = "0x168BF44", VA = "0x168BF44", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x168BFFC", Offset = "0x168BFFC", VA = "0x168BFFC")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x168C108", Offset = "0x168C108", VA = "0x168C108", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x168C2A0", Offset = "0x168C2A0", VA = "0x168C2A0", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x168C34C", Offset = "0x168C34C", VA = "0x168C34C")]
		public DecimalField()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EnumField : InspectorField
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image dropdownArrow;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RectTransform templateTransform;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image templateBackground;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image templateCheckmark;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text templateText;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Dropdown input;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, List<string>> enumNames;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, List<object>> enumValues;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private List<string> currEnumNames;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<object> currEnumValues;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x168E9C0", Offset = "0x168E9C0", VA = "0x168E9C0", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x168EA84", Offset = "0x168EA84", VA = "0x168EA84", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x168EAA8", Offset = "0x168EAA8", VA = "0x168EAA8", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x168EE04", Offset = "0x168EE04", VA = "0x168EE04")]
		private void OnValueChanged(int input)
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x168EE7C", Offset = "0x168EE7C", VA = "0x168EE7C", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x168F020", Offset = "0x168F020", VA = "0x168F020", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x168F0A8", Offset = "0x168F0A8", VA = "0x168F0A8")]
		public EnumField()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class ExposedMethodField : InspectorField
	{
		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button invokeButton;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected ExposedMethod boundMethod;

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1690F58", Offset = "0x1690F58", VA = "0x1690F58", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1690FE4", Offset = "0x1690FE4", VA = "0x1690FE4", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x1691080", Offset = "0x1691080", VA = "0x1691080", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x16910AC", Offset = "0x16910AC", VA = "0x16910AC", Slot = "11")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x168FD30", Offset = "0x168FD30", VA = "0x168FD30")]
		public void SetBoundMethod(ExposedMethod boundMethod)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x169113C", Offset = "0x169113C", VA = "0x169113C")]
		public void InvokeMethod()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1691198", Offset = "0x1691198", VA = "0x1691198")]
		public ExposedMethodField()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class GameObjectField : ExpandableInspectorField
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private string currentTag;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<UnityEngine.Component> components;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private StringField nameField;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private StringField tagField;

		[Token(Token = "0x1700008C")]
		protected override int Length
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1692AD4", Offset = "0x1692AD4", VA = "0x1692AD4", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1692B24", Offset = "0x1692B24", VA = "0x1692B24", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1692BB0", Offset = "0x1692BB0", VA = "0x1692BB0", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1692C30", Offset = "0x1692C30", VA = "0x1692C30", Slot = "8")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1692C8C", Offset = "0x1692C8C", VA = "0x1692C8C", Slot = "14")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x169315C", Offset = "0x169315C", VA = "0x169315C", Slot = "15")]
		protected override void ClearElements()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1693250", Offset = "0x1693250", VA = "0x1693250", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1693408", Offset = "0x1693408", VA = "0x1693408")]
		public GameObjectField()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x169348C", Offset = "0x169348C", VA = "0x169348C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1820", Offset = "0x9D1820")]
		private object <GenerateElements>b__9_0()
		{
			return null;
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x169352C", Offset = "0x169352C", VA = "0x169352C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1830", Offset = "0x9D1830")]
		private void <GenerateElements>b__9_1(object value)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x16935E8", Offset = "0x16935E8", VA = "0x16935E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1840", Offset = "0x9D1840")]
		private object <GenerateElements>b__9_2()
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x1693650", Offset = "0x1693650", VA = "0x1693650")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1850", Offset = "0x9D1850")]
		private void <GenerateElements>b__9_3(object value)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x1693788", Offset = "0x1693788", VA = "0x1693788")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1860", Offset = "0x9D1860")]
		private object <GenerateElements>b__9_4()
		{
			return null;
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1693824", Offset = "0x1693824", VA = "0x1693824")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1870", Offset = "0x9D1870")]
		private void <GenerateElements>b__9_5(object value)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public abstract class InspectorField : MonoBehaviour
	{
		[Token(Token = "0x2000058")]
		public delegate object Getter();

		[Token(Token = "0x2000059")]
		public delegate void Setter(object value);

		[Token(Token = "0x200005A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3450", Offset = "0x9C3450")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000213")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public InspectorField parent;

			[Token(Token = "0x6000285")]
			[Address(RVA = "0x1E0A4E8", Offset = "0x1E0A4E8", VA = "0x1E0A4E8")]
			public <>c__DisplayClass37_0()
			{
			}
		}

		[Token(Token = "0x200005B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3460", Offset = "0x9C3460")]
		private sealed class <>c__DisplayClass37_1
		{
			[Token(Token = "0x4000214")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FieldInfo field;

			[Token(Token = "0x4000215")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass37_0 CS$<>8__locals1;

			[Token(Token = "0x6000286")]
			[Address(RVA = "0x1E0A4F0", Offset = "0x1E0A4F0", VA = "0x1E0A4F0")]
			public <>c__DisplayClass37_1()
			{
			}

			[Token(Token = "0x6000287")]
			[Address(RVA = "0x1E0A4F8", Offset = "0x1E0A4F8", VA = "0x1E0A4F8")]
			internal object <BindTo>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000288")]
			[Address(RVA = "0x1E0A534", Offset = "0x1E0A534", VA = "0x1E0A534")]
			internal void <BindTo>b__1(object value)
			{
			}

			[Token(Token = "0x6000289")]
			[Address(RVA = "0x1E0A56C", Offset = "0x1E0A56C", VA = "0x1E0A56C")]
			internal object <BindTo>b__2()
			{
				return null;
			}

			[Token(Token = "0x600028A")]
			[Address(RVA = "0x1E0A5A8", Offset = "0x1E0A5A8", VA = "0x1E0A5A8")]
			internal void <BindTo>b__3(object value)
			{
			}
		}

		[Token(Token = "0x200005C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3470", Offset = "0x9C3470")]
		private sealed class <>c__DisplayClass37_2
		{
			[Token(Token = "0x4000216")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public PropertyInfo property;

			[Token(Token = "0x4000217")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass37_0 CS$<>8__locals2;

			[Token(Token = "0x600028B")]
			[Address(RVA = "0x1E0A608", Offset = "0x1E0A608", VA = "0x1E0A608")]
			public <>c__DisplayClass37_2()
			{
			}

			[Token(Token = "0x600028C")]
			[Address(RVA = "0x1E0A610", Offset = "0x1E0A610", VA = "0x1E0A610")]
			internal object <BindTo>b__4()
			{
				return null;
			}

			[Token(Token = "0x600028D")]
			[Address(RVA = "0x1E0A650", Offset = "0x1E0A650", VA = "0x1E0A650")]
			internal void <BindTo>b__5(object value)
			{
			}

			[Token(Token = "0x600028E")]
			[Address(RVA = "0x1E0A694", Offset = "0x1E0A694", VA = "0x1E0A694")]
			internal object <BindTo>b__6()
			{
				return null;
			}

			[Token(Token = "0x600028F")]
			[Address(RVA = "0x1E0A6D4", Offset = "0x1E0A6D4", VA = "0x1E0A6D4")]
			internal void <BindTo>b__7(object value)
			{
			}
		}

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RuntimeInspector m_inspector;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_skinVersion;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UISkin m_skin;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Type m_boundVariableType;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object m_value;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_depth;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected LayoutElement layoutElement;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Text variableNameText;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image variableNameMask;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Getter getter;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Setter setter;

		[Token(Token = "0x1700008D")]
		public RuntimeInspector Inspector
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1699E70", Offset = "0x1699E70", VA = "0x1699E70")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x1699E78", Offset = "0x1699E78", VA = "0x1699E78")]
			set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public UISkin Skin
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x1699F28", Offset = "0x1699F28", VA = "0x1699F28")]
			protected get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x168F5E0", Offset = "0x168F5E0", VA = "0x168F5E0")]
			set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		protected Type BoundVariableType
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x1699F30", Offset = "0x1699F30", VA = "0x1699F30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		protected object Value
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1699F38", Offset = "0x1699F38", VA = "0x1699F38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x168C04C", Offset = "0x168C04C", VA = "0x168C04C")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public int Depth
		{
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1699F40", Offset = "0x1699F40", VA = "0x1699F40")]
			protected get
			{
				return default(int);
			}
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x168F7C0", Offset = "0x168F7C0", VA = "0x168F7C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public string Name
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1699F48", Offset = "0x1699F48", VA = "0x1699F48")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x169A000", Offset = "0x169A000", VA = "0x169A000")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public string NameRaw
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x169A0FC", Offset = "0x169A0FC", VA = "0x169A0FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1690300", Offset = "0x1690300", VA = "0x1690300")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		protected virtual float HeightMultiplier
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x169A1B4", Offset = "0x169A1B4", VA = "0x169A1B4", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000270")]
		public abstract bool SupportsType(Type type);

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x168BDF8", Offset = "0x168BDF8", VA = "0x168BDF8", Slot = "6")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1690568", Offset = "0x1690568", VA = "0x1690568")]
		public void BindTo(InspectorField parent, MemberInfo member, [Optional] string variableName)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x168FCC0", Offset = "0x168FCC0", VA = "0x168FCC0")]
		public void BindTo(Type variableType, string variableName, Getter getter, Setter setter)
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x168FEC8", Offset = "0x168FEC8", VA = "0x168FEC8")]
		public void Unbind()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x168BFF8", Offset = "0x168BFF8", VA = "0x168BFF8", Slot = "7")]
		protected virtual void OnBound()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x168F448", Offset = "0x168F448", VA = "0x168F448", Slot = "8")]
		protected virtual void OnUnbound()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x169A2B8", Offset = "0x169A2B8", VA = "0x169A2B8", Slot = "9")]
		protected virtual void OnInspectorChanged()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x168C13C", Offset = "0x168C13C", VA = "0x168C13C", Slot = "10")]
		protected virtual void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x169A2BC", Offset = "0x169A2BC", VA = "0x169A2BC", Slot = "11")]
		protected virtual void OnDepthChanged()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x168C348", Offset = "0x168C348", VA = "0x168C348", Slot = "12")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x169A1BC", Offset = "0x169A1BC", VA = "0x169A1BC")]
		private void RefreshValue()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x168C35C", Offset = "0x168C35C", VA = "0x168C35C")]
		protected InspectorField()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public abstract class ExpandableInspectorField : InspectorField
	{
		[Token(Token = "0x200005E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3480", Offset = "0x9C3480")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x4000220")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Component component;

			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x1E0A318", Offset = "0x1E0A318", VA = "0x1E0A318")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x1E0A320", Offset = "0x1E0A320", VA = "0x1E0A320")]
			internal object <CreateDrawerForComponent>b__0()
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3490", Offset = "0x9C3490")]
		private sealed class <>c
		{
			[Token(Token = "0x4000221")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Setter <>9__22_1;

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1E0A30C", Offset = "0x1E0A30C", VA = "0x1E0A30C")]
			public <>c()
			{
			}

			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x1E0A314", Offset = "0x1E0A314", VA = "0x1E0A314")]
			internal void <CreateDrawerForComponent>b__22_1(object value)
			{
			}
		}

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected RectTransform drawArea;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PointerEventListener expandToggle;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private RectTransform expandToggleTransform;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private LayoutGroup layoutGroup;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image expandArrow;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected List<InspectorField> elements;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<ExposedMethodField> exposedMethods;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private bool m_isExpanded;

		[Token(Token = "0x17000095")]
		protected virtual int Length
		{
			[Token(Token = "0x6000290")]
			[Address(RVA = "0x168F1A4", Offset = "0x168F1A4", VA = "0x168F1A4", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000096")]
		public bool IsExpanded
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x168F1F0", Offset = "0x168F1F0", VA = "0x168F1F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000292")]
			[Address(RVA = "0x168F1F8", Offset = "0x168F1F8", VA = "0x168F1F8")]
			set
			{
			}
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x168F310", Offset = "0x168F310", VA = "0x168F310", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x168F404", Offset = "0x168F404", VA = "0x168F404", Slot = "8")]
		protected override void OnUnbound()
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x168F454", Offset = "0x168F454", VA = "0x168F454", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x168F6CC", Offset = "0x168F6CC", VA = "0x168F6CC", Slot = "11")]
		protected override void OnDepthChanged()
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x168F7E0", Offset = "0x168F7E0", VA = "0x168F7E0")]
		protected void RegenerateElements()
		{
		}

		[Token(Token = "0x6000298")]
		protected abstract void GenerateElements();

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x168F8E4", Offset = "0x168F8E4", VA = "0x168F8E4")]
		private void GenerateMethods()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x168FD80", Offset = "0x168FD80", VA = "0x168FD80", Slot = "15")]
		protected virtual void ClearElements()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x168FF34", Offset = "0x168FF34", VA = "0x168FF34", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1690018", Offset = "0x1690018", VA = "0x1690018")]
		protected InspectorField CreateDrawerForComponent(UnityEngine.Component component, [Optional] string variableName)
		{
			return null;
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x16903AC", Offset = "0x16903AC", VA = "0x16903AC")]
		protected InspectorField CreateDrawerForVariable(MemberInfo variable, [Optional] string variableName)
		{
			return null;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x1690A3C", Offset = "0x1690A3C", VA = "0x1690A3C")]
		protected InspectorField CreateDrawer(Type variableType, string variableName, Getter getter, Setter setter, bool drawObjectsAsFields = true)
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x1690B50", Offset = "0x1690B50", VA = "0x1690B50")]
		protected ExpandableInspectorField()
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x1690C2C", Offset = "0x1690C2C", VA = "0x1690C2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1880", Offset = "0x9D1880")]
		private void <Initialize>b__13_0(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x1690C3C", Offset = "0x1690C3C", VA = "0x1690C3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1890", Offset = "0x9D1890")]
		private object <GenerateMethods>b__19_0()
		{
			return null;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x1690C44", Offset = "0x1690C44", VA = "0x1690C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D18A0", Offset = "0x9D18A0")]
		private void <GenerateMethods>b__19_1(object value)
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class IntegerField : InspectorField
	{
		[Token(Token = "0x2000061")]
		private struct NumberParser
		{
			[Token(Token = "0x2000062")]
			private delegate bool ParseFunc(string input, out object value);

			[Token(Token = "0x2000063")]
			private delegate bool EqualsFunc(object value1, object value2);

			[Serializable]
			[Token(Token = "0x2000064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C34A0", Offset = "0x9C34A0")]
			private sealed class <>c
			{
				[Token(Token = "0x4000227")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly <>c <>9;

				[Token(Token = "0x4000228")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public static ParseFunc <>9__4_0;

				[Token(Token = "0x4000229")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public static EqualsFunc <>9__4_1;

				[Token(Token = "0x400022A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public static ParseFunc <>9__4_2;

				[Token(Token = "0x400022B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public static EqualsFunc <>9__4_3;

				[Token(Token = "0x400022C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public static ParseFunc <>9__4_4;

				[Token(Token = "0x400022D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public static EqualsFunc <>9__4_5;

				[Token(Token = "0x400022E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
				public static ParseFunc <>9__4_6;

				[Token(Token = "0x400022F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
				public static EqualsFunc <>9__4_7;

				[Token(Token = "0x4000230")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
				public static ParseFunc <>9__4_8;

				[Token(Token = "0x4000231")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
				public static EqualsFunc <>9__4_9;

				[Token(Token = "0x4000232")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
				public static ParseFunc <>9__4_10;

				[Token(Token = "0x4000233")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
				public static EqualsFunc <>9__4_11;

				[Token(Token = "0x4000234")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
				public static ParseFunc <>9__4_12;

				[Token(Token = "0x4000235")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
				public static EqualsFunc <>9__4_13;

				[Token(Token = "0x4000236")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
				public static ParseFunc <>9__4_14;

				[Token(Token = "0x4000237")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
				public static EqualsFunc <>9__4_15;

				[Token(Token = "0x4000238")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
				public static ParseFunc <>9__4_16;

				[Token(Token = "0x4000239")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
				public static EqualsFunc <>9__4_17;

				[Token(Token = "0x60002BB")]
				[Address(RVA = "0x1E0EF7C", Offset = "0x1E0EF7C", VA = "0x1E0EF7C")]
				public <>c()
				{
				}

				[Token(Token = "0x60002BC")]
				[Address(RVA = "0x1E0EF84", Offset = "0x1E0EF84", VA = "0x1E0EF84")]
				internal bool <.ctor>b__4_0(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002BD")]
				[Address(RVA = "0x1E0F014", Offset = "0x1E0F014", VA = "0x1E0F014")]
				internal bool <.ctor>b__4_1(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002BE")]
				[Address(RVA = "0x1E0F0CC", Offset = "0x1E0F0CC", VA = "0x1E0F0CC")]
				internal bool <.ctor>b__4_2(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002BF")]
				[Address(RVA = "0x1E0F15C", Offset = "0x1E0F15C", VA = "0x1E0F15C")]
				internal bool <.ctor>b__4_3(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C0")]
				[Address(RVA = "0x1E0F214", Offset = "0x1E0F214", VA = "0x1E0F214")]
				internal bool <.ctor>b__4_4(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C1")]
				[Address(RVA = "0x1E0F2AC", Offset = "0x1E0F2AC", VA = "0x1E0F2AC")]
				internal bool <.ctor>b__4_5(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C2")]
				[Address(RVA = "0x1E0F364", Offset = "0x1E0F364", VA = "0x1E0F364")]
				internal bool <.ctor>b__4_6(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C3")]
				[Address(RVA = "0x1E0F3FC", Offset = "0x1E0F3FC", VA = "0x1E0F3FC")]
				internal bool <.ctor>b__4_7(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C4")]
				[Address(RVA = "0x1E0F4B4", Offset = "0x1E0F4B4", VA = "0x1E0F4B4")]
				internal bool <.ctor>b__4_8(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C5")]
				[Address(RVA = "0x1E0F544", Offset = "0x1E0F544", VA = "0x1E0F544")]
				internal bool <.ctor>b__4_9(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C6")]
				[Address(RVA = "0x1E0F5FC", Offset = "0x1E0F5FC", VA = "0x1E0F5FC")]
				internal bool <.ctor>b__4_10(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C7")]
				[Address(RVA = "0x1E0F68C", Offset = "0x1E0F68C", VA = "0x1E0F68C")]
				internal bool <.ctor>b__4_11(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C8")]
				[Address(RVA = "0x1E0F744", Offset = "0x1E0F744", VA = "0x1E0F744")]
				internal bool <.ctor>b__4_12(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002C9")]
				[Address(RVA = "0x1E0F7D4", Offset = "0x1E0F7D4", VA = "0x1E0F7D4")]
				internal bool <.ctor>b__4_13(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002CA")]
				[Address(RVA = "0x1E0F88C", Offset = "0x1E0F88C", VA = "0x1E0F88C")]
				internal bool <.ctor>b__4_14(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002CB")]
				[Address(RVA = "0x1E0F91C", Offset = "0x1E0F91C", VA = "0x1E0F91C")]
				internal bool <.ctor>b__4_15(object value1, object value2)
				{
					return default(bool);
				}

				[Token(Token = "0x60002CC")]
				[Address(RVA = "0x1E0F9D4", Offset = "0x1E0F9D4", VA = "0x1E0F9D4")]
				internal bool <.ctor>b__4_16(string input, out object value)
				{
					return default(bool);
				}

				[Token(Token = "0x60002CD")]
				[Address(RVA = "0x1E0FA7C", Offset = "0x1E0FA7C", VA = "0x1E0FA7C")]
				internal bool <.ctor>b__4_17(object value1, object value2)
				{
					return default(bool);
				}
			}

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly ParseFunc parseFunction;

			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly EqualsFunc equalsFunction;

			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x1E0AD58", Offset = "0x1E0AD58", VA = "0x1E0AD58")]
			public NumberParser(Type fieldType)
			{
			}

			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x1E0BCE8", Offset = "0x1E0BCE8", VA = "0x1E0BCE8")]
			public bool TryParse(string input, out object value)
			{
				return default(bool);
			}

			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x1E0C09C", Offset = "0x1E0C09C", VA = "0x1E0C09C")]
			public bool ValuesAreEqual(object value1, object value2)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField input;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private NumberParser parser;

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x169A74C", Offset = "0x169A74C", VA = "0x169A74C", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x169A854", Offset = "0x169A854", VA = "0x169A854", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x169AB9C", Offset = "0x169AB9C", VA = "0x169AB9C", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x169AC50", Offset = "0x169AC50", VA = "0x169AC50")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x169ACA0", Offset = "0x169ACA0", VA = "0x169ACA0", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x169ACD4", Offset = "0x169ACD4", VA = "0x169ACD4", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x169AD7C", Offset = "0x169AD7C", VA = "0x169AD7C")]
		public IntegerField()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class ObjectField : ExpandableInspectorField
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Button initializeObjectButton;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool elementsInitialized;

		[Token(Token = "0x17000097")]
		protected override int Length
		{
			[Token(Token = "0x60002CE")]
			[Address(RVA = "0x16774A4", Offset = "0x16774A4", VA = "0x16774A4", Slot = "13")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1677610", Offset = "0x1677610", VA = "0x1677610", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x16776B8", Offset = "0x16776B8", VA = "0x16776B8", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x16777C0", Offset = "0x16777C0", VA = "0x16777C0", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x16777CC", Offset = "0x16777CC", VA = "0x16777CC", Slot = "14")]
		protected override void GenerateElements()
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1677FD8", Offset = "0x1677FD8", VA = "0x1677FD8", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1677AC8", Offset = "0x1677AC8", VA = "0x1677AC8")]
		private bool CanInitializeNewObject()
		{
			return default(bool);
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1678008", Offset = "0x1678008", VA = "0x1678008")]
		private void InitializeObject()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x16782DC", Offset = "0x16782DC", VA = "0x16782DC")]
		public ObjectField()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class ObjectReferenceField : InspectorField, IDropHandler, IEventSystemHandler
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private PointerEventListener input;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private PointerEventListener inspectReferenceButton;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Image inspectReferenceImage;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected Image background;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		protected Text referenceNameText;

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x16782E4", Offset = "0x16782E4", VA = "0x16782E4", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x16784EC", Offset = "0x16784EC", VA = "0x16784EC", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1678584", Offset = "0x1678584", VA = "0x1678584")]
		private void ShowReferencePicker(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1678904", Offset = "0x1678904", VA = "0x1678904")]
		private void InspectReference(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1678FAC", Offset = "0x1678FAC", VA = "0x1678FAC", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x167904C", Offset = "0x167904C", VA = "0x167904C", Slot = "14")]
		protected virtual void OnReferenceChanged(UnityEngine.Object reference)
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1679448", Offset = "0x1679448", VA = "0x1679448", Slot = "13")]
		public void OnDrop(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1679858", Offset = "0x1679858", VA = "0x1679858", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1679AF4", Offset = "0x1679AF4", VA = "0x1679AF4", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1679BAC", Offset = "0x1679BAC", VA = "0x1679BAC")]
		public ObjectReferenceField()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class RectField : InspectorField
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputW;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputH;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text labelW;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text labelH;

		[Token(Token = "0x17000098")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x60002E1")]
			[Address(RVA = "0x167F424", Offset = "0x167F424", VA = "0x167F424", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x167F42C", Offset = "0x167F42C", VA = "0x167F42C", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x167F6CC", Offset = "0x167F6CC", VA = "0x167F6CC", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x167F758", Offset = "0x167F758", VA = "0x167F758", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x167F8F8", Offset = "0x167F8F8", VA = "0x167F8F8")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x167FAC8", Offset = "0x167FAC8", VA = "0x167FAC8", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x167FB7C", Offset = "0x167FB7C", VA = "0x167FB7C", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x167FDF4", Offset = "0x167FDF4", VA = "0x167FDF4")]
		public RectField()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class StringField : InspectorField
	{
		[Token(Token = "0x2000069")]
		public enum Mode
		{
			[Token(Token = "0x400024C")]
			OnValueChange,
			[Token(Token = "0x400024D")]
			OnSubmit
		}

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField input;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Mode m_setterMode;

		[Token(Token = "0x17000099")]
		public Mode SetterMode
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0x1DCE0D4", Offset = "0x1DCE0D4", VA = "0x1DCE0D4")]
			get
			{
				return default(Mode);
			}
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x1DCE0DC", Offset = "0x1DCE0DC", VA = "0x1DCE0DC")]
			set
			{
			}
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1DCE0E4", Offset = "0x1DCE0E4", VA = "0x1DCE0E4", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1DCE274", Offset = "0x1DCE274", VA = "0x1DCE274", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x1DCE300", Offset = "0x1DCE300", VA = "0x1DCE300")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x1DCE328", Offset = "0x1DCE328", VA = "0x1DCE328")]
		private bool OnValueSubmitted(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1DCE354", Offset = "0x1DCE354", VA = "0x1DCE354", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1DCE38C", Offset = "0x1DCE38C", VA = "0x1DCE38C", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1DCE428", Offset = "0x1DCE428", VA = "0x1DCE428")]
		public StringField()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class TextureReferenceField : ObjectReferenceField
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private RawImage referencePreview;

		[Token(Token = "0x1700009A")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x1DD2A30", Offset = "0x1DD2A30", VA = "0x1DD2A30", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1DD2A38", Offset = "0x1DD2A38", VA = "0x1DD2A38", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1DD2B3C", Offset = "0x1DD2B3C", VA = "0x1DD2B3C", Slot = "14")]
		protected override void OnReferenceChanged(UnityEngine.Object reference)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1DD2C68", Offset = "0x1DD2C68", VA = "0x1DD2C68")]
		public TextureReferenceField()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class Vector2Field : InspectorField
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1E016CC", Offset = "0x1E016CC", VA = "0x1E016CC", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1E01890", Offset = "0x1E01890", VA = "0x1E01890", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1E0191C", Offset = "0x1E0191C", VA = "0x1E0191C", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1E01A24", Offset = "0x1E01A24", VA = "0x1E01A24")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1E01B50", Offset = "0x1E01B50", VA = "0x1E01B50", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1E01BBC", Offset = "0x1E01BBC", VA = "0x1E01BBC", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1E01D20", Offset = "0x1E01D20", VA = "0x1E01D20")]
		public Vector2Field()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class Vector3Field : InspectorField
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputZ;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text labelZ;

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x1E01E98", Offset = "0x1E01E98", VA = "0x1E01E98", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1E020D8", Offset = "0x1E020D8", VA = "0x1E020D8", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1E02164", Offset = "0x1E02164", VA = "0x1E02164", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1E022A8", Offset = "0x1E022A8", VA = "0x1E022A8")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1E02424", Offset = "0x1E02424", VA = "0x1E02424", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1E024B4", Offset = "0x1E024B4", VA = "0x1E024B4", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1E02664", Offset = "0x1E02664", VA = "0x1E02664")]
		public Vector3Field()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class Vector4Field : InspectorField
	{
		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private BoundInputField inputX;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private BoundInputField inputY;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private BoundInputField inputZ;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private BoundInputField inputW;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Text labelX;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text labelY;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text labelZ;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text labelW;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool isQuaternion;

		[Token(Token = "0x1700009B")]
		protected override float HeightMultiplier
		{
			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1E0266C", Offset = "0x1E0266C", VA = "0x1E0266C", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1E02674", Offset = "0x1E02674", VA = "0x1E02674", Slot = "6")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1E02944", Offset = "0x1E02944", VA = "0x1E02944", Slot = "5")]
		public override bool SupportsType(Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1E02A3C", Offset = "0x1E02A3C", VA = "0x1E02A3C", Slot = "7")]
		protected override void OnBound()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1E02CD0", Offset = "0x1E02CD0", VA = "0x1E02CD0")]
		private bool OnValueChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1E02F90", Offset = "0x1E02F90", VA = "0x1E02F90", Slot = "10")]
		protected override void OnSkinChanged()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1E03044", Offset = "0x1E03044", VA = "0x1E03044", Slot = "12")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1E0337C", Offset = "0x1E0337C", VA = "0x1E0337C")]
		public Vector4Field()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class BoundInputField : MonoBehaviour
	{
		[Token(Token = "0x200006F")]
		public delegate bool OnValueChangedDelegate(BoundInputField source, string input);

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool initialized;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		private bool inputValid;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private InputField inputField;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image inputFieldBackground;

		[NonSerialized]
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string DefaultEmptyValue;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string recentText;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int m_skinVersion;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UISkin m_skin;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool inputAltered;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public OnValueChangedDelegate OnValueChanged;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public OnValueChangedDelegate OnValueSubmitted;

		[Token(Token = "0x1700009C")]
		public string Text
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1716A38", Offset = "0x1716A38", VA = "0x1716A38")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1712930", Offset = "0x1712930", VA = "0x1712930")]
			set
			{
			}
		}

		[Token(Token = "0x1700009D")]
		public UISkin Skin
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1716A54", Offset = "0x1716A54", VA = "0x1716A54")]
			get
			{
				return null;
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1712A24", Offset = "0x1712A24", VA = "0x1712A24")]
			set
			{
			}
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1716A5C", Offset = "0x1716A5C", VA = "0x1716A5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1712594", Offset = "0x1712594", VA = "0x1712594")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1716A60", Offset = "0x1716A60", VA = "0x1716A60")]
		private void InputFieldValueChanged(string str)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1716B30", Offset = "0x1716B30", VA = "0x1716B30")]
		private void InputFieldValueSubmitted(string str)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1716C08", Offset = "0x1716C08", VA = "0x1716C08")]
		public BoundInputField()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class ColorPicker : SkinnedWindow
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ColorPicker m_instance;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image panel;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ColorWheelControl colorWheel;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ColorPickerAlphaSlider alphaSlider;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text rgbaText;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BoundInputField rInput;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BoundInputField gInput;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BoundInputField bInput;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BoundInputField aInput;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LayoutElement rgbaLayoutElement;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button cancelButton;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Button okButton;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Color initialValue;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ColorWheelControl.OnColorChangedDelegate onColorChanged;

		[Token(Token = "0x1700009E")]
		public static ColorPicker Instance
		{
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x1C3D95C", Offset = "0x1C3D95C", VA = "0x1C3D95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1C3DDE0", Offset = "0x1C3DDE0", VA = "0x1C3DDE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1C3DF18", Offset = "0x1C3DF18", VA = "0x1C3DF18")]
		private void Start()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1C3DAB4", Offset = "0x1C3DAB4", VA = "0x1C3DAB4")]
		public void Show(ColorWheelControl.OnColorChangedDelegate onColorChanged, Color initialColor)
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1C3E640", Offset = "0x1C3E640", VA = "0x1C3E640")]
		public void Cancel()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1C3E6B0", Offset = "0x1C3E6B0", VA = "0x1C3E6B0")]
		public void Close()
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1C3E6F4", Offset = "0x1C3E6F4", VA = "0x1C3E6F4", Slot = "6")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1C3E360", Offset = "0x1C3E360", VA = "0x1C3E360")]
		private void OnSelectedColorChanged(Color32 color)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1C3E80C", Offset = "0x1C3E80C", VA = "0x1C3E80C")]
		private void OnAlphaChanged(float alpha)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1C3E8F8", Offset = "0x1C3E8F8", VA = "0x1C3E8F8")]
		private bool OnRGBAChanged(BoundInputField source, string input)
		{
			return default(bool);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1C3EAF4", Offset = "0x1C3EAF4", VA = "0x1C3EAF4")]
		public ColorPicker()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class ColorPickerAlphaSlider : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IDragHandler
	{
		[Token(Token = "0x2000072")]
		public delegate void OnValueChangedDelegate(float alpha);

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform rectTransform;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image alphaImage;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform selector;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_value;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public OnValueChangedDelegate OnValueChanged;

		[Token(Token = "0x1700009F")]
		public float Value
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x1C3EAFC", Offset = "0x1C3EAFC", VA = "0x1C3EAFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x1C3E5F4", Offset = "0x1C3E5F4", VA = "0x1C3E5F4")]
			set
			{
			}
		}

		[Token(Token = "0x170000A0")]
		public Color Color
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1C3EB04", Offset = "0x1C3EB04", VA = "0x1C3EB04")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1C3E5CC", Offset = "0x1C3E5CC", VA = "0x1C3E5CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1C3EB28", Offset = "0x1C3EB28", VA = "0x1C3EB28")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1C3EBA4", Offset = "0x1C3EBA4", VA = "0x1C3EBA4", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1C3EBA8", Offset = "0x1C3EBA8", VA = "0x1C3EBA8", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1C3EC98", Offset = "0x1C3EC98", VA = "0x1C3EC98")]
		public ColorPickerAlphaSlider()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class DraggedReferenceItem : MonoBehaviour, IDragHandler, IEventSystemHandler, IEndDragHandler
	{
		[Token(Token = "0x2000074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C34B0", Offset = "0x9C34B0")]
		private sealed class <ValidatePointer>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400028A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400028B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400028C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DraggedReferenceItem <>4__this;

			[Token(Token = "0x400028D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <nextValidation>5__2;

			[Token(Token = "0x170000A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000339")]
				[Address(RVA = "0x1E09878", Offset = "0x1E09878", VA = "0x1E09878", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600033B")]
				[Address(RVA = "0x1E098C0", Offset = "0x1E098C0", VA = "0x1E098C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000336")]
			[Address(RVA = "0x1E09700", Offset = "0x1E09700", VA = "0x1E09700")]
			[DebuggerHidden]
			public <ValidatePointer>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000337")]
			[Address(RVA = "0x1E0972C", Offset = "0x1E0972C", VA = "0x1E0972C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000338")]
			[Address(RVA = "0x1E09730", Offset = "0x1E09730", VA = "0x1E09730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1E09880", Offset = "0x1E09880", VA = "0x1E09880", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000281")]
		private const float VALIDATE_INTERVAL = 5f;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform rectTransform;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera worldCamera;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RectTransform canvasTransform;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement borderLayoutElement;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text referenceName;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityEngine.Object m_reference;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private PointerEventData draggingPointer;

		[Token(Token = "0x170000A1")]
		public UnityEngine.Object Reference
		{
			[Token(Token = "0x6000330")]
			[Address(RVA = "0x168C36C", Offset = "0x168C36C", VA = "0x168C36C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x168C374", Offset = "0x168C374", VA = "0x168C374")]
		public void Initialize(Canvas canvas, UnityEngine.Object reference, PointerEventData draggingPointer, UISkin skin)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x168C7D8", Offset = "0x168C7D8", VA = "0x168C7D8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D18B0", Offset = "0x9D18B0")]
		private IEnumerator ValidatePointer()
		{
			return null;
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x168C704", Offset = "0x168C704", VA = "0x168C704", Slot = "4")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x168C850", Offset = "0x168C850", VA = "0x168C850", Slot = "5")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x168C8C8", Offset = "0x168C8C8", VA = "0x168C8C8")]
		public DraggedReferenceItem()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C34C0", Offset = "0x9C34C0")]
	public class DraggedReferenceSourceCamera : MonoBehaviour
	{
		[Token(Token = "0x2000076")]
		public delegate UnityEngine.Object RaycastHitProcesserDelegate(RaycastHit hit);

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Camera _camera;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float holdTime;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private LayerMask interactableObjectsMask;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float raycastRange;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool pointerDown;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float pointerDownTime;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector2 pointerDownPos;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UnityEngine.Object hitObject;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DraggedReferenceItem draggedReference;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PointerEventData draggingPointer;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public RaycastHitProcesserDelegate ProcessRaycastHit;

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x168C8D0", Offset = "0x168C8D0", VA = "0x168C8D0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x168C92C", Offset = "0x168C92C", VA = "0x168C92C")]
		private void Update()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x168D174", Offset = "0x168D174", VA = "0x168D174")]
		public DraggedReferenceSourceCamera()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class DraggedReferenceSourceUI : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IBeginDragHandler
	{
		[Token(Token = "0x2000078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3520", Offset = "0x9C3520")]
		private sealed class <CreateReferenceItemCoroutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400029E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400029F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DraggedReferenceSourceUI <>4__this;

			[Token(Token = "0x40002A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PointerEventData eventData;

			[Token(Token = "0x40002A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <dragThreshold>5__2;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600034D")]
				[Address(RVA = "0x1E09E54", Offset = "0x1E09E54", VA = "0x1E09E54", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600034F")]
				[Address(RVA = "0x1E09E9C", Offset = "0x1E09E9C", VA = "0x1E09E9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1E09C84", Offset = "0x1E09C84", VA = "0x1E09C84")]
			[DebuggerHidden]
			public <CreateReferenceItemCoroutine>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1E09CB0", Offset = "0x1E09CB0", VA = "0x1E09CB0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1E09CB4", Offset = "0x1E09CB4", VA = "0x1E09CB4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1E09E5C", Offset = "0x1E09E5C", VA = "0x1E09E5C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UnityEngine.Object m_reference;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UISkin draggedReferenceSkin;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float holdTime;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IEnumerator pointerHeldCoroutine;

		[Token(Token = "0x170000A4")]
		public UnityEngine.Object Reference
		{
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x168D1B8", Offset = "0x168D1B8", VA = "0x168D1B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x168D1C0", Offset = "0x168D1C0", VA = "0x168D1C0")]
			set
			{
			}
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x168D1C8", Offset = "0x168D1C8", VA = "0x168D1C8", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x168D31C", Offset = "0x168D31C", VA = "0x168D31C", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x168D364", Offset = "0x168D364", VA = "0x168D364", Slot = "6")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x168D288", Offset = "0x168D288", VA = "0x168D288")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D1960", Offset = "0x9D1960")]
		private IEnumerator CreateReferenceItemCoroutine(PointerEventData eventData)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x168D3AC", Offset = "0x168D3AC", VA = "0x168D3AC")]
		public DraggedReferenceSourceUI()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public struct ExposedMethod
	{
		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly MethodInfo method;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly RuntimeInspectorButtonAttribute properties;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly bool isExtensionMethod;

		[Token(Token = "0x170000A7")]
		public string Label
		{
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1690C98", Offset = "0x1690C98", VA = "0x1690C98")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public bool IsInitializer
		{
			[Token(Token = "0x6000351")]
			[Address(RVA = "0x1690CB4", Offset = "0x1690CB4", VA = "0x1690CB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000A9")]
		public bool VisibleWhenInitialized
		{
			[Token(Token = "0x6000352")]
			[Address(RVA = "0x168FC80", Offset = "0x168FC80", VA = "0x168FC80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000AA")]
		public bool VisibleWhenUninitialized
		{
			[Token(Token = "0x6000353")]
			[Address(RVA = "0x168FCA0", Offset = "0x168FCA0", VA = "0x168FCA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1690CD0", Offset = "0x1690CD0", VA = "0x1690CD0")]
		public ExposedMethod(MethodInfo method, RuntimeInspectorButtonAttribute properties, bool isExtensionMethod)
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1690D1C", Offset = "0x1690D1C", VA = "0x1690D1C")]
		public void Call(object source)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1690E38", Offset = "0x1690E38", VA = "0x1690E38")]
		public object CallAndReturnValue(object source)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	public struct ExposedExtensionMethodHolder
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly Type extendedType;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly MethodInfo method;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly RuntimeInspectorButtonAttribute properties;

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1690C48", Offset = "0x1690C48", VA = "0x1690C48")]
		public ExposedExtensionMethodHolder(Type extendedType, MethodInfo method, RuntimeInspectorButtonAttribute properties)
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ExposedVariablesEnumerator : IEnumerator<MemberInfo>, IEnumerator, IDisposable, IEnumerable<MemberInfo>, IEnumerable
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int index;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MemberInfo[] variables;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<VariableSet> hiddenVariables;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<VariableSet> exposedVariables;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool debugMode;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool exposePrivateFields;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool exposePublicFields;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		private bool exposePrivateProperties;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool exposePublicProperties;

		[Token(Token = "0x170000AB")]
		public MemberInfo Current
		{
			[Token(Token = "0x6000358")]
			[Address(RVA = "0x16911A8", Offset = "0x16911A8", VA = "0x16911A8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000359")]
			[Address(RVA = "0x16911E8", Offset = "0x16911E8", VA = "0x16911E8", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x16911EC", Offset = "0x16911EC", VA = "0x16911EC")]
		public ExposedVariablesEnumerator(MemberInfo[] variables, List<VariableSet> hiddenVariables, List<VariableSet> exposedVariables, bool debugMode, bool exposePrivateFields, bool exposePublicFields, bool exposePrivateProperties, bool exposePublicProperties)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x16912B0", Offset = "0x16912B0", VA = "0x16912B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x16912B4", Offset = "0x16912B4", VA = "0x16912B4", Slot = "9")]
		public IEnumerator<MemberInfo> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x16912B8", Offset = "0x16912B8", VA = "0x16912B8", Slot = "10")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x16912BC", Offset = "0x16912BC", VA = "0x16912BC", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x16916CC", Offset = "0x16916CC", VA = "0x16916CC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x16914B0", Offset = "0x16914B0", VA = "0x16914B0")]
		private bool IsVariableInExposedVariablesList(string variableName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x169158C", Offset = "0x169158C", VA = "0x169158C")]
		private bool ShouldExposeVariable(MemberInfo variable)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200007C")]
	public class ObjectReferencePicker : SkinnedWindow, IListViewAdapter
	{
		[Token(Token = "0x200007D")]
		public delegate void OnReferenceChanged(UnityEngine.Object reference);

		[Serializable]
		[Token(Token = "0x200007E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3530", Offset = "0x9C3530")]
		private sealed class <>c
		{
			[Token(Token = "0x40002C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40002C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<UnityEngine.Object> <>9__33_0;

			[Token(Token = "0x6000375")]
			[Address(RVA = "0x1E0CDDC", Offset = "0x1E0CDDC", VA = "0x1E0CDDC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000376")]
			[Address(RVA = "0x1E0CDE4", Offset = "0x1E0CDE4", VA = "0x1E0CDE4")]
			internal int <GenerateReferenceItems>b__33_0(UnityEngine.Object ref1, UnityEngine.Object ref2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40002B2")]
		private const string SPRITE_ATLAS_PREFIX = "SpriteAtlasTexture-";

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ObjectReferencePicker m_instance;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private OnReferenceChanged onReferenceChanged;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image panel;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image scrollbar;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private InputField searchBar;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image searchIcon;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image searchBarBackground;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text selectPromptText;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private LayoutElement searchBarLayoutElement;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private LayoutElement buttonsLayoutElement;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Button cancelButton;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Button okButton;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private RecycledListView listView;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image listViewBackground;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private ObjectReferencePickerItem referenceItemPrefab;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private List<UnityEngine.Object> references;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private List<UnityEngine.Object> filteredReferences;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private UnityEngine.Object initialValue;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private UnityEngine.Object currentlySelectedObject;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ObjectReferencePickerItem currentlySelectedItem;

		[Token(Token = "0x170000AD")]
		public static ObjectReferencePicker Instance
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1678674", Offset = "0x1678674", VA = "0x1678674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		public int Count
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1679BB4", Offset = "0x1679BB4", VA = "0x1679BB4", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000AF")]
		public float ItemHeight
		{
			[Token(Token = "0x6000364")]
			[Address(RVA = "0x1679C00", Offset = "0x1679C00", VA = "0x1679C00", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1679C20", Offset = "0x1679C20", VA = "0x1679C20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x16787CC", Offset = "0x16787CC", VA = "0x16787CC")]
		public void Show(OnReferenceChanged onReferenceChanged, Type referenceType, UnityEngine.Object[] references, UnityEngine.Object initialReference)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x167A2E8", Offset = "0x167A2E8", VA = "0x167A2E8")]
		public void Cancel()
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x167A37C", Offset = "0x167A37C", VA = "0x167A37C")]
		public void Close()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x167A440", Offset = "0x167A440", VA = "0x167A440", Slot = "6")]
		protected override void RefreshSkin()
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1679E8C", Offset = "0x1679E8C", VA = "0x1679E8C")]
		private void GenerateReferenceItems(UnityEngine.Object[] references, Type referenceType)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x167AA74", Offset = "0x167AA74", VA = "0x167AA74", Slot = "9")]
		public RecycledListItem CreateItem(Transform parent)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x167A7A8", Offset = "0x167A7A8", VA = "0x167A7A8")]
		private void OnSearchTextChanged(string value)
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x167AD58", Offset = "0x167AD58", VA = "0x167AD58", Slot = "10")]
		public void SetItemContent(RecycledListItem item)
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x167B0A8", Offset = "0x167B0A8", VA = "0x167B0A8", Slot = "11")]
		public void OnItemClicked(RecycledListItem item)
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x167B1F0", Offset = "0x167B1F0", VA = "0x167B1F0")]
		public ObjectReferencePicker()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ObjectReferencePickerItem : RecycledListItem
	{
		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C68C4", Offset = "0x9C68C4")]
		private UnityEngine.Object <Reference>k__BackingField;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int m_skinVersion;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UISkin m_skin;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image background;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RawImage texturePreview;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private LayoutElement texturePreviewLayoutElement;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text referenceNameText;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_isSelected;

		[Token(Token = "0x170000B0")]
		public UnityEngine.Object Reference
		{
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x167B2A8", Offset = "0x167B2A8", VA = "0x167B2A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A10", Offset = "0x9D1A10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x167B2B0", Offset = "0x167B2B0", VA = "0x167B2B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A20", Offset = "0x9D1A20")]
			private set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public UISkin Skin
		{
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x167B2B8", Offset = "0x167B2B8", VA = "0x167B2B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600037A")]
			[Address(RVA = "0x167AB20", Offset = "0x167AB20", VA = "0x167AB20")]
			set
			{
			}
		}

		[Token(Token = "0x170000B2")]
		public bool IsSelected
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0x167B2C0", Offset = "0x167B2C0", VA = "0x167B2C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600037C")]
			[Address(RVA = "0x167AFEC", Offset = "0x167AFEC", VA = "0x167AFEC")]
			set
			{
			}
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x167B2C8", Offset = "0x167B2C8", VA = "0x167B2C8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x167AEA0", Offset = "0x167AEA0", VA = "0x167AEA0")]
		public void SetContent(UnityEngine.Object reference)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x167B4CC", Offset = "0x167B4CC", VA = "0x167B4CC")]
		public ObjectReferencePickerItem()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x167B4DC", Offset = "0x167B4DC", VA = "0x167B4DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A30", Offset = "0x9D1A30")]
		private void <Awake>b__17_0(PointerEventData eventData)
		{
		}
	}
	[Token(Token = "0x2000080")]
	public class PointerEventListener : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler, IPointerClickHandler
	{
		[Token(Token = "0x2000081")]
		public delegate void PointerEvent(PointerEventData eventData);

		[Token(Token = "0x14000004")]
		public event PointerEvent PointerDown
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0x167BD44", Offset = "0x167BD44", VA = "0x167BD44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A40", Offset = "0x9D1A40")]
			add
			{
			}
			[Token(Token = "0x6000382")]
			[Address(RVA = "0x167BDE4", Offset = "0x167BDE4", VA = "0x167BDE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A50", Offset = "0x9D1A50")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event PointerEvent PointerUp
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0x167BE84", Offset = "0x167BE84", VA = "0x167BE84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A60", Offset = "0x9D1A60")]
			add
			{
			}
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x167BF24", Offset = "0x167BF24", VA = "0x167BF24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A70", Offset = "0x9D1A70")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event PointerEvent PointerClick
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x167844C", Offset = "0x167844C", VA = "0x167844C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A80", Offset = "0x9D1A80")]
			add
			{
			}
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x167BFC4", Offset = "0x167BFC4", VA = "0x167BFC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1A90", Offset = "0x9D1A90")]
			remove
			{
			}
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x167C064", Offset = "0x167C064", VA = "0x167C064", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x167C078", Offset = "0x167C078", VA = "0x167C078", Slot = "5")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x167C08C", Offset = "0x167C08C", VA = "0x167C08C", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x167C0A0", Offset = "0x167C0A0", VA = "0x167C0A0")]
		public PointerEventListener()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public interface IListViewAdapter
	{
		[Token(Token = "0x170000B3")]
		int Count
		{
			[Token(Token = "0x600038F")]
			get;
		}

		[Token(Token = "0x170000B4")]
		float ItemHeight
		{
			[Token(Token = "0x6000390")]
			get;
		}

		[Token(Token = "0x6000391")]
		RecycledListItem CreateItem(Transform parent);

		[Token(Token = "0x6000392")]
		void SetItemContent(RecycledListItem item);

		[Token(Token = "0x6000393")]
		void OnItemClicked(RecycledListItem item);
	}
	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3540", Offset = "0x9C3540")]
	public class RecycledListItem : MonoBehaviour
	{
		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6934", Offset = "0x9C6934")]
		private object <Tag>k__BackingField;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6944", Offset = "0x9C6944")]
		private int <Position>k__BackingField;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IListViewAdapter adapter;

		[Token(Token = "0x170000B5")]
		public object Tag
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x167FDFC", Offset = "0x167FDFC", VA = "0x167FDFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AA0", Offset = "0x9D1AA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x167FE04", Offset = "0x167FE04", VA = "0x167FE04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AB0", Offset = "0x9D1AB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000B6")]
		public int Position
		{
			[Token(Token = "0x6000396")]
			[Address(RVA = "0x167FE0C", Offset = "0x167FE0C", VA = "0x167FE0C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AC0", Offset = "0x9D1AC0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000397")]
			[Address(RVA = "0x167FE14", Offset = "0x167FE14", VA = "0x167FE14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AD0", Offset = "0x9D1AD0")]
			set
			{
			}
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x167FE1C", Offset = "0x167FE1C", VA = "0x167FE1C")]
		internal void SetAdapter(IListViewAdapter adapter)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x167B4E0", Offset = "0x167B4E0", VA = "0x167B4E0")]
		public void OnClick()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x167B4D4", Offset = "0x167B4D4", VA = "0x167B4D4")]
		public RecycledListItem()
		{
		}
	}
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C35A0", Offset = "0x9C35A0")]
	public class RecycledListView : MonoBehaviour
	{
		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform contentTransform;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float itemHeight;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float _1OverItemHeight;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float viewportHeight;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, RecycledListItem> items;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Stack<RecycledListItem> pooledItems;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IListViewAdapter adapter;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool isDirty;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int currentTopIndex;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int currentBottomIndex;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x167FE24", Offset = "0x167FE24", VA = "0x167FE24")]
		private void Start()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x167FF04", Offset = "0x167FF04", VA = "0x167FF04")]
		private void Update()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1679DB4", Offset = "0x1679DB4", VA = "0x1679DB4")]
		public void SetAdapter(IListViewAdapter adapter)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x167A938", Offset = "0x167A938", VA = "0x167A938")]
		public void UpdateList()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x167A5CC", Offset = "0x167A5CC", VA = "0x167A5CC")]
		public void ResetList()
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x16803E8", Offset = "0x16803E8", VA = "0x16803E8")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x167FF70", Offset = "0x167FF70", VA = "0x167FF70")]
		private void UpdateItemsInTheList(bool updateAllVisibleItems = false)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x16803F4", Offset = "0x16803F4", VA = "0x16803F4")]
		private void CreateItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1680560", Offset = "0x1680560", VA = "0x1680560")]
		private void CreateItemAtIndex(int index)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1680318", Offset = "0x1680318", VA = "0x1680318")]
		private void DestroyItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1680440", Offset = "0x1680440", VA = "0x1680440")]
		private void UpdateItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1680718", Offset = "0x1680718", VA = "0x1680718")]
		public RecycledListView()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x16807F0", Offset = "0x16807F0", VA = "0x16807F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1AE0", Offset = "0x9D1AE0")]
		private void <Start>b__11_0(Vector2 pos)
		{
		}
	}
	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9C3600", Offset = "0x9C3600")]
	public class RuntimeInspectorSettings : ScriptableObject
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InspectorField[] m_standardDrawers;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private InspectorField[] m_referenceDrawers;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VariableSet[] m_hiddenVariables;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VariableSet[] m_exposedVariables;

		[Token(Token = "0x170000B7")]
		public InspectorField[] StandardDrawers
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x1685254", Offset = "0x1685254", VA = "0x1685254")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public InspectorField[] ReferenceDrawers
		{
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x168525C", Offset = "0x168525C", VA = "0x168525C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public VariableSet[] HiddenVariables
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0x1685264", Offset = "0x1685264", VA = "0x1685264")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public VariableSet[] ExposedVariables
		{
			[Token(Token = "0x60003AB")]
			[Address(RVA = "0x168526C", Offset = "0x168526C", VA = "0x168526C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1685274", Offset = "0x1685274", VA = "0x1685274")]
		public RuntimeInspectorSettings()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public static class RuntimeInspectorUtils
	{
		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<Type, MemberInfo[]> typeToVariables;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, ExposedMethod[]> typeToExposedMethods;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static HashSet<Type> serializableUnityTypes;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<ExposedExtensionMethodHolder> exposedExtensionMethods;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Canvas m_draggedReferenceItemsCanvas;

		[Token(Token = "0x170000BB")]
		public static Type ExposedExtensionMethodsHolder
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x168527C", Offset = "0x168527C", VA = "0x168527C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public static Canvas DraggedReferenceItemsCanvas
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x1685654", Offset = "0x1685654", VA = "0x1685654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1677578", Offset = "0x1677578", VA = "0x1677578")]
		public static bool IsNull(this object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1685914", Offset = "0x1685914", VA = "0x1685914")]
		public static string ToTitleCase(this string str)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x167AC9C", Offset = "0x167AC9C", VA = "0x167AC9C")]
		public static string GetName(this UnityEngine.Object obj)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1679240", Offset = "0x1679240", VA = "0x1679240")]
		public static string GetNameWithType(this object obj, [Optional] Type defaultType)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x167B3B0", Offset = "0x167B3B0", VA = "0x167B3B0")]
		public static Texture GetTexture(this UnityEngine.Object obj)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1679AC0", Offset = "0x1679AC0", VA = "0x1679AC0")]
		public static Color Tint(this Color color, float tintAmount)
		{
			return default(Color);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x1685C5C", Offset = "0x1685C5C", VA = "0x1685C5C")]
		public static DraggedReferenceItem CreateDraggedReferenceItem(UnityEngine.Object reference, PointerEventData draggingPointer, [Optional] UISkin skin)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x167952C", Offset = "0x167952C", VA = "0x167952C")]
		public static UnityEngine.Object GetAssignableObjectFromDraggedReferenceItem(PointerEventData draggingPointer, Type assignableType)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x1685DA8", Offset = "0x1685DA8", VA = "0x1685DA8")]
		private static void OnSceneLoaded(Scene arg0, LoadSceneMode arg1)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1685ECC", Offset = "0x1685ECC", VA = "0x1685ECC")]
		public static bool IsPointerValid(this PointerEventData eventData)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1684AEC", Offset = "0x1684AEC", VA = "0x1684AEC")]
		public static MemberInfo[] GetAllVariables(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1686298", Offset = "0x1686298", VA = "0x1686298")]
		public static ExposedMethod[] GetExposedMethods(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x1686794", Offset = "0x1686794", VA = "0x1686794")]
		public static bool ShouldExposeInInspector(this MemberInfo variable, bool debugMode)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x1685F70", Offset = "0x1685F70", VA = "0x1685F70")]
		private static bool IsSerializable(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x16780B0", Offset = "0x16780B0", VA = "0x16780B0")]
		public static object Instantiate(this Type type)
		{
			return null;
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x1686990", Offset = "0x1686990", VA = "0x1686990")]
		public static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x16852DC", Offset = "0x16852DC", VA = "0x16852DC")]
		private static void GetExposedExtensionMethods(Type type)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class VariableSet
	{
		[Token(Token = "0x40002EB")]
		private const string INCLUDE_ALL_VARIABLES = "*";

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_type;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Type type;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string[] m_variables;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public HashSet<string> variables;

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x1E00DE4", Offset = "0x1E00DE4", VA = "0x1E00DE4")]
		public bool Init()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1E00FC0", Offset = "0x1E00FC0", VA = "0x1E00FC0")]
		private void AddAllVariablesToSet()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1E010C0", Offset = "0x1E010C0", VA = "0x1E010C0")]
		public VariableSet()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class WindowDragHandler : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x40002F0")]
		private const int NON_EXISTING_TOUCH = -98456;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform rectTransform;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int pointerId;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector2 initialTouchPos;

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x1E06A64", Offset = "0x1E06A64", VA = "0x1E06A64")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1E06AE0", Offset = "0x1E06AE0", VA = "0x1E06AE0", Slot = "4")]
		public void OnBeginDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1E06BC8", Offset = "0x1E06BC8", VA = "0x1E06BC8", Slot = "5")]
		public void OnDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1E06CC4", Offset = "0x1E06CC4", VA = "0x1E06CC4", Slot = "6")]
		public void OnEndDrag(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1E06CF4", Offset = "0x1E06CF4", VA = "0x1E06CF4")]
		public WindowDragHandler()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public static class SkinUtils
	{
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1DC716C", Offset = "0x1DC716C", VA = "0x1DC716C")]
		public static void SetSkinText(this Text text, UISkin skin)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1DC71D0", Offset = "0x1DC71D0", VA = "0x1DC71D0")]
		public static void SetSkinInputFieldText(this Text text, UISkin skin)
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1DC7234", Offset = "0x1DC7234", VA = "0x1DC7234")]
		public static void SetSkinButtonText(this Text text, UISkin skin)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1DC7298", Offset = "0x1DC7298", VA = "0x1DC7298")]
		public static void SetSkinButton(this Button button, UISkin skin)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1DC7324", Offset = "0x1DC7324", VA = "0x1DC7324")]
		public static void SetWidth(this LayoutElement layoutElement, float width)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1DC7378", Offset = "0x1DC7378", VA = "0x1DC7378")]
		public static void SetHeight(this LayoutElement layoutElement, float height)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public abstract class SkinnedWindow : MonoBehaviour
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UISkin m_skin;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_skinVersion;

		[Token(Token = "0x170000BD")]
		public UISkin Skin
		{
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1DC73CC", Offset = "0x1DC73CC", VA = "0x1DC73CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1DC73D4", Offset = "0x1DC73D4", VA = "0x1DC73D4")]
			set
			{
			}
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1DC74B4", Offset = "0x1DC74B4", VA = "0x1DC74B4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1DC7518", Offset = "0x1DC7518", VA = "0x1DC7518", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003D3")]
		protected abstract void RefreshSkin();

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1DC7550", Offset = "0x1DC7550", VA = "0x1DC7550")]
		protected SkinnedWindow()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x9C368C", Offset = "0x9C368C")]
	public class UISkin : ScriptableObject
	{
		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_version;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Font m_font;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_fontSize;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int m_lineHeight;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int m_indentAmount;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Color m_windowColor;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Color m_backgroundColor;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Color m_textColor;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private Color m_scrollbarColor;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Color m_expandArrowColor;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Color m_inputFieldNormalBackgroundColor;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Color m_inputFieldInvalidBackgroundColor;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Color m_inputFieldTextColor;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private Color m_toggleCheckmarkColor;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private Color m_buttonBackgroundColor;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private Color m_buttonTextColor;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private Color m_selectedItemBackgroundColor;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private Color m_selectedItemTextColor;

		[Token(Token = "0x170000BE")]
		public int Version
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1DFDDA0", Offset = "0x1DFDDA0", VA = "0x1DFDDA0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000BF")]
		public Font Font
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1DFDDD8", Offset = "0x1DFDDD8", VA = "0x1DFDDD8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1DFDDE0", Offset = "0x1DFDDE0", VA = "0x1DFDDE0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public int FontSize
		{
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1DFDE80", Offset = "0x1DFDE80", VA = "0x1DFDE80")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1DFDE88", Offset = "0x1DFDE88", VA = "0x1DFDE88")]
			set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public int LineHeight
		{
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1DFDEA8", Offset = "0x1DFDEA8", VA = "0x1DFDEA8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1DFDEB0", Offset = "0x1DFDEB0", VA = "0x1DFDEB0")]
			set
			{
			}
		}

		[Token(Token = "0x170000C2")]
		public int IndentAmount
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1DFDED0", Offset = "0x1DFDED0", VA = "0x1DFDED0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1DFDED8", Offset = "0x1DFDED8", VA = "0x1DFDED8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public Color WindowColor
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1DFDEF8", Offset = "0x1DFDEF8", VA = "0x1DFDEF8")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1DFDF04", Offset = "0x1DFDF04", VA = "0x1DFDF04")]
			set
			{
			}
		}

		[Token(Token = "0x170000C4")]
		public Color BackgroundColor
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1DFDF7C", Offset = "0x1DFDF7C", VA = "0x1DFDF7C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1DFDF88", Offset = "0x1DFDF88", VA = "0x1DFDF88")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public Color TextColor
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1DFE000", Offset = "0x1DFE000", VA = "0x1DFE000")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1DFE00C", Offset = "0x1DFE00C", VA = "0x1DFE00C")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public Color ScrollbarColor
		{
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1DFE084", Offset = "0x1DFE084", VA = "0x1DFE084")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1DFE090", Offset = "0x1DFE090", VA = "0x1DFE090")]
			set
			{
			}
		}

		[Token(Token = "0x170000C7")]
		public Color ExpandArrowColor
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1DFE108", Offset = "0x1DFE108", VA = "0x1DFE108")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x1DFE114", Offset = "0x1DFE114", VA = "0x1DFE114")]
			set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public Color InputFieldNormalBackgroundColor
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1DFE18C", Offset = "0x1DFE18C", VA = "0x1DFE18C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1DFE198", Offset = "0x1DFE198", VA = "0x1DFE198")]
			set
			{
			}
		}

		[Token(Token = "0x170000C9")]
		public Color InputFieldInvalidBackgroundColor
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1DFE210", Offset = "0x1DFE210", VA = "0x1DFE210")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x1DFE21C", Offset = "0x1DFE21C", VA = "0x1DFE21C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CA")]
		public Color InputFieldTextColor
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x1DFE294", Offset = "0x1DFE294", VA = "0x1DFE294")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x1DFE2A0", Offset = "0x1DFE2A0", VA = "0x1DFE2A0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CB")]
		public Color ToggleCheckmarkColor
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1DFE318", Offset = "0x1DFE318", VA = "0x1DFE318")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1DFE324", Offset = "0x1DFE324", VA = "0x1DFE324")]
			set
			{
			}
		}

		[Token(Token = "0x170000CC")]
		public Color ButtonBackgroundColor
		{
			[Token(Token = "0x60003F1")]
			[Address(RVA = "0x1DFE39C", Offset = "0x1DFE39C", VA = "0x1DFE39C")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x1DFE3A8", Offset = "0x1DFE3A8", VA = "0x1DFE3A8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CD")]
		public Color ButtonTextColor
		{
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x1DFE420", Offset = "0x1DFE420", VA = "0x1DFE420")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x1DFE42C", Offset = "0x1DFE42C", VA = "0x1DFE42C")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public Color SelectedItemBackgroundColor
		{
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x1DFE4A4", Offset = "0x1DFE4A4", VA = "0x1DFE4A4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0x1DFE4B0", Offset = "0x1DFE4B0", VA = "0x1DFE4B0")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public Color SelectedItemTextColor
		{
			[Token(Token = "0x60003F7")]
			[Address(RVA = "0x1DFE528", Offset = "0x1DFE528", VA = "0x1DFE528")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0x1DFE534", Offset = "0x1DFE534", VA = "0x1DFE534")]
			set
			{
			}
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x1DFDDA8", Offset = "0x1DFDDA8", VA = "0x1DFDDA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x9D1C10", Offset = "0x9D1C10")]
		private void Invalidate()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1DFE5AC", Offset = "0x1DFE5AC", VA = "0x1DFE5AC")]
		public UISkin()
		{
		}
	}
}
namespace IngameDebugConsole
{
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C36F8", Offset = "0x9C36F8")]
	public class ConsoleMethodAttribute : Attribute
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_command;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_description;

		[Token(Token = "0x170000D0")]
		public string Command
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1C43628", Offset = "0x1C43628", VA = "0x1C43628")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D1")]
		public string Description
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1C43630", Offset = "0x1C43630", VA = "0x1C43630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1C43638", Offset = "0x1C43638", VA = "0x1C43638")]
		public ConsoleMethodAttribute(string command, string description)
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class ConsoleMethodInfo
	{
		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MethodInfo method;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly Type[] parameterTypes;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly object instance;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly string signature;

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1C43688", Offset = "0x1C43688", VA = "0x1C43688")]
		public ConsoleMethodInfo(MethodInfo method, Type[] parameterTypes, object instance, string signature)
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1C43708", Offset = "0x1C43708", VA = "0x1C43708")]
		public bool IsValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008E")]
	public static class DebugLogConsole
	{
		[Token(Token = "0x200008F")]
		public delegate bool ParseFunction(string input, out object output);

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ConsoleMethodInfo> methods;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Dictionary<Type, ParseFunction> parseFunctions;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Dictionary<Type, string> typeReadableNames;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static List<string> commandArguments;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static readonly string[] inputDelimiters;

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x250C964", Offset = "0x250C964", VA = "0x250C964")]
		static DebugLogConsole()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x250E318", Offset = "0x250E318", VA = "0x250E318")]
		[AttributeAttribute(Name = "ConsoleMethodAttribute", RVA = "0x9D1C48", Offset = "0x9D1C48")]
		public static void LogAllCommands()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x250E6DC", Offset = "0x250E6DC", VA = "0x250E6DC")]
		[AttributeAttribute(Name = "ConsoleMethodAttribute", RVA = "0x9D1C94", Offset = "0x9D1C94")]
		public static void LogSystemInfo()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x250F088", Offset = "0x250F088", VA = "0x250F088")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, string info, [Optional] string postfix)
		{
			return null;
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x250F144", Offset = "0x250F144", VA = "0x250F144")]
		private static StringBuilder AppendSysInfoIfPresent(this StringBuilder sb, int info, [Optional] string postfix)
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x250F1E0", Offset = "0x250F1E0", VA = "0x250F1E0")]
		public static void AddCommandInstance(string command, string description, string methodName, object instance)
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x250F4C4", Offset = "0x250F4C4", VA = "0x250F4C4")]
		public static void AddCommandStatic(string command, string description, string methodName, Type ownerType)
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x250F550", Offset = "0x250F550", VA = "0x250F550")]
		public static void RemoveCommand(string command)
		{
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x250F2E0", Offset = "0x250F2E0", VA = "0x250F2E0")]
		private static void AddCommand(string command, string description, string methodName, Type ownerType, [Optional] object instance)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x250DD10", Offset = "0x250DD10", VA = "0x250DD10")]
		private static void AddCommand(string command, string description, MethodInfo method, [Optional] object instance)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x250F5F8", Offset = "0x250F5F8", VA = "0x250F5F8")]
		public static void ExecuteCommand(string command)
		{
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x250FF84", Offset = "0x250FF84", VA = "0x250FF84")]
		private static int IndexOfDelimiter(char c)
		{
			return default(int);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x250FF50", Offset = "0x250FF50", VA = "0x250FF50")]
		private static int IndexOfChar(string command, char c, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x251007C", Offset = "0x251007C", VA = "0x251007C")]
		private static bool ParseString(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x25100BC", Offset = "0x25100BC", VA = "0x25100BC")]
		private static bool ParseBool(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x2510254", Offset = "0x2510254", VA = "0x2510254")]
		private static bool ParseInt(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x25102E4", Offset = "0x25102E4", VA = "0x25102E4")]
		private static bool ParseUInt(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x2510374", Offset = "0x2510374", VA = "0x2510374")]
		private static bool ParseLong(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x251040C", Offset = "0x251040C", VA = "0x251040C")]
		private static bool ParseULong(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x25104A4", Offset = "0x25104A4", VA = "0x25104A4")]
		private static bool ParseByte(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x2510534", Offset = "0x2510534", VA = "0x2510534")]
		private static bool ParseSByte(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x25105C4", Offset = "0x25105C4", VA = "0x25105C4")]
		private static bool ParseShort(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x2510654", Offset = "0x2510654", VA = "0x2510654")]
		private static bool ParseUShort(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x25106E4", Offset = "0x25106E4", VA = "0x25106E4")]
		private static bool ParseChar(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x251078C", Offset = "0x251078C", VA = "0x251078C")]
		private static bool ParseFloat(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x251081C", Offset = "0x251081C", VA = "0x251081C")]
		private static bool ParseDouble(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x25108CC", Offset = "0x25108CC", VA = "0x25108CC")]
		private static bool ParseDecimal(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x251097C", Offset = "0x251097C", VA = "0x251097C")]
		private static bool ParseVector2(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x25110A0", Offset = "0x25110A0", VA = "0x25110A0")]
		private static bool ParseVector3(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x251116C", Offset = "0x251116C", VA = "0x251116C")]
		private static bool ParseVector4(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x2511238", Offset = "0x2511238", VA = "0x2511238")]
		private static bool ParseGameObject(string input, out object output)
		{
			return default(bool);
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x2510A48", Offset = "0x2510A48", VA = "0x2510A48")]
		private static bool CreateVectorFromInput(string input, Type vectorType, out object output)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000090")]
	public class DebugLogEntry : IEquatable<DebugLogEntry>
	{
		[Token(Token = "0x4000313")]
		private const int HASH_NOT_CALCULATED = -623218;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string logString;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string stackTrace;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string completeLog;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Sprite logTypeSpriteRepresentation;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int count;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int hashValue;

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x16881FC", Offset = "0x16881FC", VA = "0x16881FC")]
		public DebugLogEntry(string logString, string stackTrace, Sprite sprite)
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1688278", Offset = "0x1688278", VA = "0x1688278", Slot = "4")]
		public bool Equals(DebugLogEntry other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x16882D0", Offset = "0x16882D0", VA = "0x16882D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1688344", Offset = "0x1688344", VA = "0x1688344", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9C3740", Offset = "0x9C3740")]
	public class DebugLogIndexList
	{
		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int[] indices;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int size;

		[Token(Token = "0x170000D2")]
		public int Count
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x1688400", Offset = "0x1688400", VA = "0x1688400")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D3")]
		public int Item
		{
			[Token(Token = "0x6000428")]
			[Address(RVA = "0x1688408", Offset = "0x1688408", VA = "0x1688408")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1688444", Offset = "0x1688444", VA = "0x1688444")]
		public DebugLogIndexList()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x16884B4", Offset = "0x16884B4", VA = "0x16884B4")]
		public void Add(int index)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x16885A0", Offset = "0x16885A0", VA = "0x16885A0")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class DebugLogItem : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform transformComponent;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image imageComponent;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text logText;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image logTypeImage;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject logCountParent;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text logCountText;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DebugLogEntry logEntry;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int entryIndex;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DebugLogRecycledListView manager;

		[Token(Token = "0x170000D4")]
		public RectTransform Transform
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x16885A8", Offset = "0x16885A8", VA = "0x16885A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D5")]
		public Image Image
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x16885B0", Offset = "0x16885B0", VA = "0x16885B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		public int Index
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x16885B8", Offset = "0x16885B8", VA = "0x16885B8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x16885C0", Offset = "0x16885C0", VA = "0x16885C0")]
		public void Initialize(DebugLogRecycledListView manager)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x16885C8", Offset = "0x16885C8", VA = "0x16885C8")]
		public void SetContent(DebugLogEntry logEntry, int entryIndex, bool isExpanded)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x16886E0", Offset = "0x16886E0", VA = "0x16886E0")]
		public void ShowCount()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1688744", Offset = "0x1688744", VA = "0x1688744")]
		public void HideCount()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1688764", Offset = "0x1688764", VA = "0x1688764", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x16888D0", Offset = "0x16888D0", VA = "0x16888D0")]
		public float CalculateExpandedHeight(string content)
		{
			return default(float);
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x16889CC", Offset = "0x16889CC", VA = "0x16889CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x16889EC", Offset = "0x16889EC", VA = "0x16889EC")]
		public DebugLogItem()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class DebugLogLogcatListener : AndroidJavaProxy
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Queue<string> queuedLogs;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AndroidJavaObject nativeObject;

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x16889F4", Offset = "0x16889F4", VA = "0x16889F4")]
		public DebugLogLogcatListener()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1688AC0", Offset = "0x1688AC0", VA = "0x1688AC0", Slot = "1")]
		~DebugLogLogcatListener()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1688C44", Offset = "0x1688C44", VA = "0x1688C44")]
		public void Start(string arguments)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1688B3C", Offset = "0x1688B3C", VA = "0x1688B3C")]
		public void Stop()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1688E50", Offset = "0x1688E50", VA = "0x1688E50")]
		public void OnLogReceived(string log)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1688EB4", Offset = "0x1688EB4", VA = "0x1688EB4")]
		public string GetLog()
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public enum DebugLogFilter
	{
		[Token(Token = "0x4000328")]
		None = 0,
		[Token(Token = "0x4000329")]
		Info = 1,
		[Token(Token = "0x400032A")]
		Warning = 2,
		[Token(Token = "0x400032B")]
		Error = 4,
		[Token(Token = "0x400032C")]
		All = 7
	}
	[Token(Token = "0x2000095")]
	public class DebugLogManager : MonoBehaviour
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DebugLogManager instance;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6B54", Offset = "0x9C6B54")]
		[SerializeField]
		private bool singleton;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float minimumHeight;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool startInPopupMode;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool clearCommandAfterExecution;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		[SerializeField]
		private bool receiveLogcatLogsInAndroid;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string logcatArguments;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6BF0", Offset = "0x9C6BF0")]
		private DebugLogItem logItemPrefab;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Sprite infoLog;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Sprite warningLog;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Sprite errorLog;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<LogType, Sprite> logSpriteRepresentations;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color collapseButtonNormalColor;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Color collapseButtonSelectedColor;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color filterButtonsNormalColor;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color filterButtonsSelectedColor;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9C6CAC", Offset = "0x9C6CAC")]
		[SerializeField]
		private RectTransform logWindowTR;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private RectTransform canvasTR;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private RectTransform logItemsContainer;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private InputField commandInputField;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image collapseButton;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image filterInfoButton;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image filterWarningButton;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Image filterErrorButton;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text infoEntryCountText;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text warningEntryCountText;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text errorEntryCountText;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject snapToBottomButton;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private int infoEntryCount;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private int warningEntryCount;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int errorEntryCount;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private CanvasGroup logWindowCanvasGroup;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool isLogWindowVisible;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		private bool screenDimensionsChanged;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private DebugLogPopup popupManager;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private ScrollRect logItemsScrollRect;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		private DebugLogRecycledListView recycledListView;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool isCollapseOn;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		private DebugLogFilter logFilter;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool snapToBottom;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Dictionary<DebugLogEntry, int> collapsedLogEntriesMap;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private DebugLogIndexList uncollapsedLogEntriesIndices;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private DebugLogIndexList indicesOfListEntriesToShow;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private List<DebugLogItem> pooledLogItems;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private PointerEventData nullPointerEventData;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private DebugLogLogcatListener logcatListener;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1688F2C", Offset = "0x1688F2C", VA = "0x1688F2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x168992C", Offset = "0x168992C", VA = "0x168992C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1689A58", Offset = "0x1689A58", VA = "0x1689A58")]
		private void Start()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1689AEC", Offset = "0x1689AEC", VA = "0x1689AEC")]
		private void OnRectTransformDimensionsChange()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1689AF8", Offset = "0x1689AF8", VA = "0x1689AF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x168A140", Offset = "0x168A140", VA = "0x168A140")]
		public char OnValidateCommand(string text, int charIndex, char addedChar)
		{
			return default(char);
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1689D68", Offset = "0x1689D68", VA = "0x1689D68")]
		private void ReceivedLog(string logString, string stackTrace, LogType logType)
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x168A4AC", Offset = "0x168A4AC", VA = "0x168A4AC")]
		public void SetSnapToBottom(bool snapToBottom)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x168A4B8", Offset = "0x168A4B8", VA = "0x168A4B8")]
		public void ValidateScrollPosition()
		{
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x168A4E4", Offset = "0x168A4E4", VA = "0x168A4E4")]
		public void Show()
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x168A558", Offset = "0x168A558", VA = "0x168A558")]
		public void Hide()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1689A7C", Offset = "0x1689A7C", VA = "0x1689A7C")]
		public void HideButtonPressed()
		{
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x168A620", Offset = "0x168A620", VA = "0x168A620")]
		public void ClearButtonPressed()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x168A7EC", Offset = "0x168A7EC", VA = "0x168A7EC")]
		public void CollapseButtonPressed()
		{
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x168AC4C", Offset = "0x168AC4C", VA = "0x168AC4C")]
		public void FilterLogButtonPressed()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x168ACB4", Offset = "0x168ACB4", VA = "0x168ACB4")]
		public void FilterWarningButtonPressed()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x168AD1C", Offset = "0x168AD1C", VA = "0x168AD1C")]
		public void FilterErrorButtonPressed()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x168AD84", Offset = "0x168AD84", VA = "0x168AD84")]
		public void Resize(BaseEventData dat)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x168A888", Offset = "0x168A888", VA = "0x168A888")]
		private void FilterLogs()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x168AEBC", Offset = "0x168AEBC", VA = "0x168AEBC")]
		public void PoolLogItem(DebugLogItem logItem)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x168AF40", Offset = "0x168AF40", VA = "0x168AF40")]
		public DebugLogItem PopLogItem()
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x168B068", Offset = "0x168B068", VA = "0x168B068")]
		public DebugLogManager()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
	{
		[Token(Token = "0x2000097")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3778", Offset = "0x9C3778")]
		private sealed class <MoveToPosAnimation>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400036D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400036E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400036F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DebugLogPopup <>4__this;

			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 targetPos;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <modifier>5__2;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private Vector3 <initialPos>5__3;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000466")]
				[Address(RVA = "0x1E08990", Offset = "0x1E08990", VA = "0x1E08990", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000468")]
				[Address(RVA = "0x1E089D8", Offset = "0x1E089D8", VA = "0x1E089D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1E08844", Offset = "0x1E08844", VA = "0x1E08844")]
			[DebuggerHidden]
			public <MoveToPosAnimation>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000464")]
			[Address(RVA = "0x1E08870", Offset = "0x1E08870", VA = "0x1E08870", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000465")]
			[Address(RVA = "0x1E08874", Offset = "0x1E08874", VA = "0x1E08874", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1E08998", Offset = "0x1E08998", VA = "0x1E08998", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private RectTransform popupTransform;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector2 halfSize;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Image backgroundImage;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text newInfoCountText;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text newWarningCountText;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text newErrorCountText;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int newInfoCount;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int newWarningCount;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int newErrorCount;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private Color normalColor;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private Color alertColorInfo;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Color alertColorWarning;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Color alertColorError;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool isPopupBeingDragged;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private IEnumerator moveToPosCoroutine;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x168B09C", Offset = "0x168B09C", VA = "0x168B09C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x168B1A0", Offset = "0x168B1A0", VA = "0x168B1A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1689CE8", Offset = "0x1689CE8", VA = "0x1689CE8")]
		public void OnViewportDimensionsChanged()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x168A32C", Offset = "0x168A32C", VA = "0x168A32C")]
		public void NewInfoLogArrived()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x168A3B8", Offset = "0x168A3B8", VA = "0x168A3B8")]
		public void NewWarningLogArrived()
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x168A43C", Offset = "0x168A43C", VA = "0x168A43C")]
		public void NewErrorLogArrived()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x168B370", Offset = "0x168B370", VA = "0x168B370")]
		private void Reset()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x168B430", Offset = "0x168B430", VA = "0x168B430")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9D1D00", Offset = "0x9D1D00")]
		private IEnumerator MoveToPosAnimation(Vector3 targetPos)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1689AA8", Offset = "0x1689AA8", VA = "0x1689AA8", Slot = "4")]
		public void OnPointerClick(PointerEventData data)
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x168A5B8", Offset = "0x168A5B8", VA = "0x168A5B8")]
		public void Show()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x168B4CC", Offset = "0x168B4CC", VA = "0x168B4CC")]
		public void Hide()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x168B524", Offset = "0x168B524", VA = "0x168B524", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x168B574", Offset = "0x168B574", VA = "0x168B574", Slot = "6")]
		public void OnDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x168B21C", Offset = "0x168B21C", VA = "0x168B21C", Slot = "7")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x168B5A0", Offset = "0x168B5A0", VA = "0x168B5A0")]
		public DebugLogPopup()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class DebugLogRecycledListView : MonoBehaviour
	{
		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform transformComponent;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform viewportTransform;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DebugLogManager debugManager;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color logItemNormalColor1;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color logItemNormalColor2;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color logItemSelectedColor;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private DebugLogManager manager;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float logItemHeight;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _1OverLogItemHeight;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float viewportHeight;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<DebugLogEntry> collapsedLogEntries;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DebugLogIndexList indicesOfEntriesToShow;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int indexOfSelectedLogEntry;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float positionOfSelectedLogEntry;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float heightOfSelectedLogEntry;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float deltaHeightOfSelectedLogEntry;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Dictionary<int, DebugLogItem> logItemsAtIndices;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool isCollapseOn;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private int currentTopIndex;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int currentBottomIndex;

		[Token(Token = "0x170000D9")]
		public float ItemHeight
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x168B5A8", Offset = "0x168B5A8", VA = "0x168B5A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000DA")]
		public float SelectedItemHeight
		{
			[Token(Token = "0x600046A")]
			[Address(RVA = "0x168B5B0", Offset = "0x168B5B0", VA = "0x168B5B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x168B5B8", Offset = "0x168B5B8", VA = "0x168B5B8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1689610", Offset = "0x1689610", VA = "0x1689610")]
		public void Initialize(DebugLogManager manager, List<DebugLogEntry> collapsedLogEntries, DebugLogIndexList indicesOfEntriesToShow, float logItemHeight)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x168B60C", Offset = "0x168B60C", VA = "0x168B60C")]
		public void SetCollapseMode(bool collapse)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1688780", Offset = "0x1688780", VA = "0x1688780")]
		public void OnLogItemClicked(DebugLogItem item)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x168A744", Offset = "0x168A744", VA = "0x168A744")]
		public void DeselectSelectedLogItem()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x168A2A0", Offset = "0x168A2A0", VA = "0x168A2A0")]
		public void OnLogEntriesUpdated(bool updateAllVisibleItemContents)
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x168A220", Offset = "0x168A220", VA = "0x168A220")]
		public void OnCollapsedLogEntryAtIndexUpdated(int index)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1689C88", Offset = "0x1689C88", VA = "0x1689C88")]
		public void OnViewportDimensionsChanged()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x168B6F0", Offset = "0x168B6F0", VA = "0x168B6F0")]
		private void HardResetItems()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x168B690", Offset = "0x168B690", VA = "0x168B690")]
		private void CalculateContentHeight()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x168967C", Offset = "0x168967C", VA = "0x168967C")]
		public void UpdateItemsInTheList(bool updateAllVisibleItemContents)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x168B7F4", Offset = "0x168B7F4", VA = "0x168B7F4")]
		private void CreateLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x168B958", Offset = "0x168B958", VA = "0x168B958")]
		private void CreateLogItemAtIndex(int index)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x168B728", Offset = "0x168B728", VA = "0x168B728")]
		private void DestroyLogItemsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x168B840", Offset = "0x168B840", VA = "0x168B840")]
		private void UpdateLogItemContentsBetweenIndices(int topIndex, int bottomIndex)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x168B618", Offset = "0x168B618", VA = "0x168B618")]
		private void ColorLogItem(DebugLogItem logItem, int index)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x168BA1C", Offset = "0x168BA1C", VA = "0x168BA1C")]
		public DebugLogRecycledListView()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class DebugsOnScrollListener : MonoBehaviour, IScrollHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler
	{
		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ScrollRect debugsScrollRect;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DebugLogManager debugLogManager;

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x168BBE0", Offset = "0x168BBE0", VA = "0x168BBE0", Slot = "4")]
		public void OnScroll(PointerEventData data)
		{
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x168BC48", Offset = "0x168BC48", VA = "0x168BC48", Slot = "5")]
		public void OnBeginDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x168BC64", Offset = "0x168BC64", VA = "0x168BC64", Slot = "6")]
		public void OnEndDrag(PointerEventData data)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x168BC98", Offset = "0x168BC98", VA = "0x168BC98")]
		public void OnScrollbarDragStart(BaseEventData data)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x168BCB4", Offset = "0x168BCB4", VA = "0x168BCB4")]
		public void OnScrollbarDragEnd(BaseEventData data)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x168BC14", Offset = "0x168BC14", VA = "0x168BC14")]
		private bool IsScrollbarAtBottom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x168BCE8", Offset = "0x168BCE8", VA = "0x168BCE8")]
		public DebugsOnScrollListener()
		{
		}
	}
}
namespace FluffyUnderware.DevTools
{
	[Token(Token = "0x200009A")]
	public interface IDTGroupParsingAttribute
	{
		[Token(Token = "0x170000DB")]
		string Path
		{
			[Token(Token = "0x6000483")]
			get;
		}
	}
	[Token(Token = "0x200009B")]
	public interface IDTFieldParsingAttribute
	{
	}
	[Token(Token = "0x200009C")]
	public interface IDTGroupRenderAttribute
	{
	}
	[Token(Token = "0x200009D")]
	public interface IDTFieldRenderAttribute
	{
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C3788", Offset = "0x9C3788")]
	public class DTVersionAttribute : Attribute
	{
		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Version;

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x250C568", Offset = "0x250C568", VA = "0x250C568")]
		public DTVersionAttribute(string version)
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C37BC", Offset = "0x9C37BC")]
	public class DTAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6EA8", Offset = "0x9C6EA8")]
		private int <TypeSort>k__BackingField;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int Sort;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowBelowProperty;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int Space;

		[Token(Token = "0x170000DC")]
		public int TypeSort
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x2508178", Offset = "0x2508178", VA = "0x2508178")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1DB0", Offset = "0x9D1DB0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x2508180", Offset = "0x2508180", VA = "0x2508180")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1DC0", Offset = "0x9D1DC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x2508188", Offset = "0x2508188", VA = "0x2508188", Slot = "5")]
		public virtual int CompareTo(object obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x2508258", Offset = "0x2508258", VA = "0x2508258")]
		public DTAttribute(int sortOrder, bool showBelow = false)
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class GroupAttribute : DTAttribute, IDTGroupParsingAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6EB8", Offset = "0x9C6EB8")]
		private bool <PathIsAbsolute>k__BackingField;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Expanded;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool Invisible;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Label;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Tooltip;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string HelpURL;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mPath;

		[Token(Token = "0x170000DD")]
		public string Path
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1694AE8", Offset = "0x1694AE8", VA = "0x1694AE8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x1694AF0", Offset = "0x1694AF0", VA = "0x1694AF0")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public bool PathIsAbsolute
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x1694BE4", Offset = "0x1694BE4", VA = "0x1694BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1DD0", Offset = "0x9D1DD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x1694BEC", Offset = "0x1694BEC", VA = "0x1694BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1DE0", Offset = "0x9D1DE0")]
			private set
			{
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1694BF8", Offset = "0x1694BF8", VA = "0x1694BF8")]
		public GroupAttribute(string pathAndName)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class ActionAttribute : DTAttribute
	{
		[Token(Token = "0x20000A2")]
		public enum ActionEnum
		{
			[Token(Token = "0x400039A")]
			Show,
			[Token(Token = "0x400039B")]
			Hide,
			[Token(Token = "0x400039C")]
			Enable,
			[Token(Token = "0x400039D")]
			Disable,
			[Token(Token = "0x400039E")]
			ShowInfo,
			[Token(Token = "0x400039F")]
			ShowWarning,
			[Token(Token = "0x40003A0")]
			ShowError,
			[Token(Token = "0x40003A1")]
			Callback
		}

		[Token(Token = "0x20000A3")]
		public enum ActionPositionEnum
		{
			[Token(Token = "0x40003A3")]
			Above,
			[Token(Token = "0x40003A4")]
			Below
		}

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ActionEnum Action;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ActionPositionEnum Position;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public object ActionData;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MethodInfo mCallback;

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1711FC8", Offset = "0x1711FC8", VA = "0x1711FC8")]
		protected ActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1712024", Offset = "0x1712024", VA = "0x1712024")]
		public void Callback(object classInstance)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class ConditionalAttribute : ActionAttribute
	{
		[Token(Token = "0x20000A5")]
		public enum OperatorEnum
		{
			[Token(Token = "0x40003A7")]
			AND,
			[Token(Token = "0x40003A8")]
			OR
		}

		[Token(Token = "0x20000A6")]
		public class Condition
		{
			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string FieldName;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public FieldInfo FieldInfo;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PropertyInfo PropertyInfo;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public object CompareTo;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool CompareFalse;

			[Token(Token = "0x40003AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public OperatorEnum Operator;

			[Token(Token = "0x40003AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MethodInfo MethodInfo;

			[Token(Token = "0x40003B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public string MethodName;

			[Token(Token = "0x6000496")]
			[Address(RVA = "0x1E07C64", Offset = "0x1E07C64", VA = "0x1E07C64")]
			public Condition()
			{
			}
		}

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Condition[] Conditions;

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1C41570", Offset = "0x1C41570", VA = "0x1C41570")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1C416B0", Offset = "0x1C416B0", VA = "0x1C416B0")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1C41890", Offset = "0x1C41890", VA = "0x1C41890")]
		protected ConditionalAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1C41B04", Offset = "0x1C41B04", VA = "0x1C41B04")]
		protected ConditionalAttribute(string methodToQuery)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1C41C28", Offset = "0x1C41C28", VA = "0x1C41C28", Slot = "6")]
		public virtual bool ConditionMet(object classInstance)
		{
			return default(bool);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1C41CF4", Offset = "0x1C41CF4", VA = "0x1C41CF4")]
		private bool evaluate(Condition cond, object classInstance)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A7")]
	public class SortOrderAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1DC7670", Offset = "0x1DC7670", VA = "0x1DC7670")]
		public SortOrderAttribute(int sort = 100)
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public class AsGroupAttribute : GroupAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x6000498")]
		[Address(RVA = "0x1713FC4", Offset = "0x1713FC4", VA = "0x1713FC4")]
		public AsGroupAttribute([Optional] string pathAndName)
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class TabAttribute : GroupAttribute
	{
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly string TabName;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly string TabBarName;

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1DCE6C4", Offset = "0x1DCE6C4", VA = "0x1DCE6C4")]
		public TabAttribute(string pathAndName)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1DCE754", Offset = "0x1DCE754", VA = "0x1DCE754")]
		private static bool split(string pathAndName, out string path, out string tabBar, out string tabname)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AA")]
	public class SectionAttribute : GroupAttribute
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool Fixed;

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1DC63FC", Offset = "0x1DC63FC", VA = "0x1DC63FC")]
		public SectionAttribute(string name, bool expanded = true, bool fix = false, int sort = 100)
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class NoSectionAttribute : SectionAttribute
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x16769D0", Offset = "0x16769D0", VA = "0x16769D0")]
		public NoSectionAttribute()
		{
		}
	}
	[Token(Token = "0x20000AC")]
	public class Hide : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1694C80", Offset = "0x1694C80", VA = "0x1694C80")]
		public Hide()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class Inline : DTAttribute, IDTFieldParsingAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1697A00", Offset = "0x1697A00", VA = "0x1697A00")]
		public Inline()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class ArrayExAttribute : DTAttribute, IDTFieldParsingAttribute
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Draggable;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ShowHeader;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
		public bool ShowAdd;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
		public bool ShowDelete;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool DropTarget;

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1712284", Offset = "0x1712284", VA = "0x1712284")]
		public ArrayExAttribute()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class FieldActionAttribute : ActionAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x16917CC", Offset = "0x16917CC", VA = "0x16917CC")]
		public FieldActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class GroupActionAttribute : ActionAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1694AE0", Offset = "0x1694AE0", VA = "0x1694AE0")]
		public GroupActionAttribute(string actionData, ActionEnum action = ActionEnum.Callback)
		{
		}
	}
	[Token(Token = "0x20000B1")]
	public class FieldConditionAttribute : ConditionalAttribute, IDTFieldRenderAttribute
	{
		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x16917D4", Offset = "0x16917D4", VA = "0x16917D4")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false, ActionEnum action = ActionEnum.Show, [Optional] object actionData, ActionPositionEnum position = ActionPositionEnum.Below)
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1691828", Offset = "0x1691828", VA = "0x1691828")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1691838", Offset = "0x1691838", VA = "0x1691838")]
		public FieldConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x169185C", Offset = "0x169185C", VA = "0x169185C")]
		public FieldConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class GroupConditionAttribute : ConditionalAttribute, IDTGroupRenderAttribute
	{
		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1694C38", Offset = "0x1694C38", VA = "0x1694C38")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse = false)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1694C44", Offset = "0x1694C44", VA = "0x1694C44")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2)
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1694C54", Offset = "0x1694C54", VA = "0x1694C54")]
		public GroupConditionAttribute(string fieldOrProperty, object compareTo, bool compareFalse, OperatorEnum op, string fieldOrProperty2, object compareTo2, bool compareFalse2, string fieldOrProperty3, object compareTo3, bool compareFalse3)
		{
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1694C78", Offset = "0x1694C78", VA = "0x1694C78")]
		public GroupConditionAttribute(string methodToQuery)
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public class Couple<T1, T2>
	{
		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6EC8", Offset = "0x9C6EC8")]
		private T1 <First>k__BackingField;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6ED8", Offset = "0x9C6ED8")]
		private T2 <Second>k__BackingField;

		[Token(Token = "0x170000DF")]
		public T1 First
		{
			[Token(Token = "0x60004AA")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1DF0", Offset = "0x9D1DF0")]
			get
			{
				return (T1)null;
			}
			[Token(Token = "0x60004AB")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E00", Offset = "0x9D1E00")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public T2 Second
		{
			[Token(Token = "0x60004AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E10", Offset = "0x9D1E10")]
			get
			{
				return (T2)null;
			}
			[Token(Token = "0x60004AD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E20", Offset = "0x9D1E20")]
			set
			{
			}
		}

		[Token(Token = "0x60004AE")]
		public Couple(T1 first, T2 second)
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public static class DTTween
	{
		[Token(Token = "0x20000B5")]
		public enum EasingMethod
		{
			[Token(Token = "0x40003BC")]
			Linear,
			[Token(Token = "0x40003BD")]
			ExponentialIn,
			[Token(Token = "0x40003BE")]
			ExponentialOut,
			[Token(Token = "0x40003BF")]
			ExponentialInOut,
			[Token(Token = "0x40003C0")]
			ExponentialOutIn,
			[Token(Token = "0x40003C1")]
			CircularIn,
			[Token(Token = "0x40003C2")]
			CircularOut,
			[Token(Token = "0x40003C3")]
			CircularInOut,
			[Token(Token = "0x40003C4")]
			CircularOutIn,
			[Token(Token = "0x40003C5")]
			QuadraticIn,
			[Token(Token = "0x40003C6")]
			QuadraticOut,
			[Token(Token = "0x40003C7")]
			QuadraticInOut,
			[Token(Token = "0x40003C8")]
			QuadraticOutIn,
			[Token(Token = "0x40003C9")]
			SinusIn,
			[Token(Token = "0x40003CA")]
			SinusOut,
			[Token(Token = "0x40003CB")]
			SinusInOut,
			[Token(Token = "0x40003CC")]
			SinusOutIn,
			[Token(Token = "0x40003CD")]
			CubicIn,
			[Token(Token = "0x40003CE")]
			CubicOut,
			[Token(Token = "0x40003CF")]
			CubicInOut,
			[Token(Token = "0x40003D0")]
			CubicOutIn,
			[Token(Token = "0x40003D1")]
			QuarticIn,
			[Token(Token = "0x40003D2")]
			QuarticOut,
			[Token(Token = "0x40003D3")]
			QuarticInOut,
			[Token(Token = "0x40003D4")]
			QuarticOutIn,
			[Token(Token = "0x40003D5")]
			QuinticIn,
			[Token(Token = "0x40003D6")]
			QuinticOut,
			[Token(Token = "0x40003D7")]
			QuinticInOut,
			[Token(Token = "0x40003D8")]
			QuinticOutIn
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x250A374", Offset = "0x250A374", VA = "0x250A374")]
		public static float Ease(EasingMethod method, float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x250B288", Offset = "0x250B288", VA = "0x250B288")]
		public static float Ease(EasingMethod method, float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x250B258", Offset = "0x250B258", VA = "0x250B258")]
		public static float Linear(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x250C0DC", Offset = "0x250C0DC", VA = "0x250C0DC")]
		public static float Linear(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x250A748", Offset = "0x250A748", VA = "0x250A748")]
		public static float ExpoOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x250B7D8", Offset = "0x250B7D8", VA = "0x250B7D8")]
		public static float ExpoOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x250A6F8", Offset = "0x250A6F8", VA = "0x250A6F8")]
		public static float ExpoIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x250B78C", Offset = "0x250B78C", VA = "0x250B78C")]
		public static float ExpoIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x250A79C", Offset = "0x250A79C", VA = "0x250A79C")]
		public static float ExpoInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x250B820", Offset = "0x250B820", VA = "0x250B820")]
		public static float ExpoInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x250A834", Offset = "0x250A834", VA = "0x250A834")]
		public static float ExpoOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x250B8B8", Offset = "0x250B8B8", VA = "0x250B8B8")]
		public static float ExpoOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x250A93C", Offset = "0x250A93C", VA = "0x250A93C")]
		public static float CircOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x250B9A4", Offset = "0x250B9A4", VA = "0x250B9A4")]
		public static float CircOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x250A8E4", Offset = "0x250A8E4", VA = "0x250A8E4")]
		public static float CircIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x250B950", Offset = "0x250B950", VA = "0x250B950")]
		public static float CircIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x250A994", Offset = "0x250A994", VA = "0x250A994")]
		public static float CircInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x250B9F8", Offset = "0x250B9F8", VA = "0x250B9F8")]
		public static float CircInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x250AA20", Offset = "0x250AA20", VA = "0x250AA20")]
		public static float CircOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x250BA80", Offset = "0x250BA80", VA = "0x250BA80")]
		public static float CircOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x250AB18", Offset = "0x250AB18", VA = "0x250AB18")]
		public static float QuadOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x250BB40", Offset = "0x250BB40", VA = "0x250BB40")]
		public static float QuadOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x250AAE4", Offset = "0x250AAE4", VA = "0x250AAE4")]
		public static float QuadIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x250BB2C", Offset = "0x250BB2C", VA = "0x250BB2C")]
		public static float QuadIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x250AB54", Offset = "0x250AB54", VA = "0x250AB54")]
		public static float QuadInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x250BB5C", Offset = "0x250BB5C", VA = "0x250BB5C")]
		public static float QuadInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x250ABE0", Offset = "0x250ABE0", VA = "0x250ABE0")]
		public static float QuadOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x250BBE4", Offset = "0x250BBE4", VA = "0x250BBE4")]
		public static float QuadOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x250725C", Offset = "0x250725C", VA = "0x250725C")]
		public static float SineOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x250BC78", Offset = "0x250BC78", VA = "0x250BC78")]
		public static float SineOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x250AC60", Offset = "0x250AC60", VA = "0x250AC60")]
		public static float SineIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x250BC38", Offset = "0x250BC38", VA = "0x250BC38")]
		public static float SineIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x250ACA4", Offset = "0x250ACA4", VA = "0x250ACA4")]
		public static float SineInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x250BCB4", Offset = "0x250BCB4", VA = "0x250BCB4")]
		public static float SineInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x250AD38", Offset = "0x250AD38", VA = "0x250AD38")]
		public static float SineOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x250BD3C", Offset = "0x250BD3C", VA = "0x250BD3C")]
		public static float SineOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x250AE04", Offset = "0x250AE04", VA = "0x250AE04")]
		public static float CubicOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x250BDD4", Offset = "0x250BDD4", VA = "0x250BDD4")]
		public static float CubicOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x250ADCC", Offset = "0x250ADCC", VA = "0x250ADCC")]
		public static float CubicIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x250BDBC", Offset = "0x250BDBC", VA = "0x250BDBC")]
		public static float CubicIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x250AE4C", Offset = "0x250AE4C", VA = "0x250AE4C")]
		public static float CubicInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x250BDFC", Offset = "0x250BDFC", VA = "0x250BDFC")]
		public static float CubicInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x250AEC4", Offset = "0x250AEC4", VA = "0x250AEC4")]
		public static float CubicOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x250BE50", Offset = "0x250BE50", VA = "0x250BE50")]
		public static float CubicOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x250AF94", Offset = "0x250AF94", VA = "0x250AF94")]
		public static float QuartOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x250BECC", Offset = "0x250BECC", VA = "0x250BECC")]
		public static float QuartOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x250AF58", Offset = "0x250AF58", VA = "0x250AF58")]
		public static float QuartIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x250BEB0", Offset = "0x250BEB0", VA = "0x250BEB0")]
		public static float QuartIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x250AFDC", Offset = "0x250AFDC", VA = "0x250AFDC")]
		public static float QuartInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x250BEF4", Offset = "0x250BEF4", VA = "0x250BEF4")]
		public static float QuartInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x250B058", Offset = "0x250B058", VA = "0x250B058")]
		public static float QuartOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x250BF50", Offset = "0x250BF50", VA = "0x250BF50")]
		public static float QuartOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x250720C", Offset = "0x250720C", VA = "0x250720C")]
		public static float QuintOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x250BFD8", Offset = "0x250BFD8", VA = "0x250BFD8")]
		public static float QuintOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x250B0EC", Offset = "0x250B0EC", VA = "0x250B0EC")]
		public static float QuintIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x250BFB8", Offset = "0x250BFB8", VA = "0x250BFB8")]
		public static float QuintIn(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x250B12C", Offset = "0x250B12C", VA = "0x250B12C")]
		public static float QuintInOut(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x250C008", Offset = "0x250C008", VA = "0x250C008")]
		public static float QuintInOut(float t, float b, float c, float d)
		{
			return default(float);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x250B1B4", Offset = "0x250B1B4", VA = "0x250B1B4")]
		public static float QuintOutIn(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x250C06C", Offset = "0x250C06C", VA = "0x250C06C")]
		public static float QuintOutIn(float t, float b, float c, float d)
		{
			return default(float);
		}
	}
	[Token(Token = "0x20000B6")]
	public class DTObjectDump
	{
		[Token(Token = "0x40003D9")]
		private const int INDENTSPACES = 5;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string mIndent;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private StringBuilder mSB;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private object mObject;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x25093C8", Offset = "0x25093C8", VA = "0x25093C8")]
		public DTObjectDump(object o, int indent = 0)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x250A158", Offset = "0x250A158", VA = "0x250A158", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x25095A8", Offset = "0x25095A8", VA = "0x25095A8")]
		private void AppendHeader(string name)
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2509638", Offset = "0x2509638", VA = "0x2509638")]
		private void AppendMember(MemberInfo info)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public static class DTUtility
	{
		[Token(Token = "0x170000E1")]
		public static bool IsEditorStateChange
		{
			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x250C0F4", Offset = "0x250C0F4", VA = "0x250C0F4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x250C0EC", Offset = "0x250C0EC", VA = "0x250C0EC")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x250C0FC", Offset = "0x250C0FC", VA = "0x250C0FC")]
		public static float GetHandleSize(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60004F2")]
		public static void SetPlayerPrefs<T>(string key, T value)
		{
		}

		[Token(Token = "0x60004F3")]
		public static T GetPlayerPrefs<T>(string key, T defaultValue)
		{
			return (T)null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x250C314", Offset = "0x250C314", VA = "0x250C314")]
		public static float RandomSign()
		{
			return default(float);
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x250C340", Offset = "0x250C340", VA = "0x250C340")]
		public static string GetHelpUrl(object forClass)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x250C3AC", Offset = "0x250C3AC", VA = "0x250C3AC")]
		public static string GetHelpUrl(Type classType)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x250C4EC", Offset = "0x250C4EC", VA = "0x250C4EC")]
		public static Vector3 GetCenterPosition(Vector3 fallback, params Vector3[] vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004F8")]
		public static T CreateGameObject<T>(Transform parent, string name) where T : MonoBehaviour
		{
			return null;
		}
	}
	[Token(Token = "0x20000B8")]
	public static class DTTime
	{
		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static float _EditorDeltaTime;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static float _EditorLastTime;

		[Token(Token = "0x170000E2")]
		public static double TimeSinceStartup
		{
			[Token(Token = "0x60004F9")]
			[Address(RVA = "0x250A228", Offset = "0x250A228", VA = "0x250A228")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E3")]
		public static float deltaTime
		{
			[Token(Token = "0x60004FA")]
			[Address(RVA = "0x250A244", Offset = "0x250A244", VA = "0x250A244")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x250A2AC", Offset = "0x250A2AC", VA = "0x250A2AC")]
		public static void InitializeEditorTime()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x250A30C", Offset = "0x250A30C", VA = "0x250A30C")]
		public static void UpdateEditorTime()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class TimeMeasure : Ring<long>
	{
		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Stopwatch mWatch;

		[Token(Token = "0x170000E4")]
		public double LastTicks
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0x1DD360C", Offset = "0x1DD360C", VA = "0x1DD360C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E5")]
		public double LastMS
		{
			[Token(Token = "0x6000502")]
			[Address(RVA = "0x1DD3684", Offset = "0x1DD3684", VA = "0x1DD3684")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E6")]
		public double AverageMS
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0x1DD36A4", Offset = "0x1DD36A4", VA = "0x1DD36A4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E7")]
		public double MinimumMS
		{
			[Token(Token = "0x6000504")]
			[Address(RVA = "0x1DD378C", Offset = "0x1DD378C", VA = "0x1DD378C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E8")]
		public double MaximumMS
		{
			[Token(Token = "0x6000505")]
			[Address(RVA = "0x1DD38A8", Offset = "0x1DD38A8", VA = "0x1DD38A8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E9")]
		public double AverageTicks
		{
			[Token(Token = "0x6000506")]
			[Address(RVA = "0x1DD39C4", Offset = "0x1DD39C4", VA = "0x1DD39C4")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000EA")]
		public double MinimumTicks
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0x1DD3A9C", Offset = "0x1DD3A9C", VA = "0x1DD3A9C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000EB")]
		public double MaximumTicks
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1DD3BA8", Offset = "0x1DD3BA8", VA = "0x1DD3BA8")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1DD34BC", Offset = "0x1DD34BC", VA = "0x1DD34BC")]
		public TimeMeasure(int size)
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1DD3550", Offset = "0x1DD3550", VA = "0x1DD3550")]
		public void Start()
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1DD356C", Offset = "0x1DD356C", VA = "0x1DD356C")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1DD35F0", Offset = "0x1DD35F0", VA = "0x1DD35F0")]
		public void Pause()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public static class DTMath
	{
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x250886C", Offset = "0x250886C", VA = "0x250886C")]
		public static Vector3 ParallelTransportFrame(Vector3 up, Vector3 tan0, Vector3 tan1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x25089CC", Offset = "0x25089CC", VA = "0x25089CC")]
		public static Vector3 LeftTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x25089E4", Offset = "0x25089E4", VA = "0x25089E4")]
		public static Vector3 RightTan(ref Vector3 tan, ref Vector3 up)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x25089FC", Offset = "0x25089FC", VA = "0x25089FC")]
		public static float Repeat(float t, float length)
		{
			return default(float);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2508A18", Offset = "0x2508A18", VA = "0x2508A18")]
		public static double FixNaN(double v)
		{
			return default(double);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2508A94", Offset = "0x2508A94", VA = "0x2508A94")]
		public static float FixNaN(float v)
		{
			return default(float);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2508AC4", Offset = "0x2508AC4", VA = "0x2508AC4")]
		public static Vector2 FixNaN(Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2508B18", Offset = "0x2508B18", VA = "0x2508B18")]
		public static Vector3 FixNaN(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2507AD4", Offset = "0x2507AD4", VA = "0x2507AD4")]
		public static float MapValue(float min, float max, float value, float vMin = -1f, float vMax = 1f)
		{
			return default(float);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2508B88", Offset = "0x2508B88", VA = "0x2508B88")]
		public static float SnapPrecision(float value, int decimals)
		{
			return default(float);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2508C0C", Offset = "0x2508C0C", VA = "0x2508C0C")]
		public static Vector2 SnapPrecision(Vector2 value, int decimals)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x2508C60", Offset = "0x2508C60", VA = "0x2508C60")]
		public static Vector3 SnapPrecision(Vector3 value, int decimals)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x2503BB4", Offset = "0x2503BB4", VA = "0x2503BB4")]
		public static float LinePointDistanceSqr(Vector3 l1, Vector3 l2, Vector3 p, out float frag)
		{
			return default(float);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x2508CD4", Offset = "0x2508CD4", VA = "0x2508CD4")]
		public static bool RayLineSegmentIntersection(Vector2 r0, Vector2 dir, Vector2 l1, Vector2 l2, out Vector2 hit, out float frag)
		{
			return default(bool);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2508D74", Offset = "0x2508D74", VA = "0x2508D74")]
		public static bool ShortestIntersectionLine(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 resultSegmentA, out Vector3 resultSegmentB)
		{
			return default(bool);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x2509064", Offset = "0x2509064", VA = "0x2509064")]
		public static bool LineLineIntersection(Vector3 line1A, Vector3 line1B, Vector3 line2A, Vector3 line2B, out Vector3 hitPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x2509190", Offset = "0x2509190", VA = "0x2509190")]
		public static bool LineLineIntersect(Vector2 line1A, Vector2 line1B, Vector2 line2A, Vector2 line2B, out Vector2 hitPoint, bool segmentOnly = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x25092B8", Offset = "0x25092B8", VA = "0x25092B8")]
		public static bool PointInsideTriangle(Vector3 A, Vector3 B, Vector3 C, Vector3 p, out float ac, out float ab, bool edgesAllowed)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BB")]
	public class UnityEventEx<T0> : UnityEvent<T0>
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private object mCallerList;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private MethodInfo mCallsCount;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCount;

		[Token(Token = "0x600051B")]
		public void AddListenerOnce(UnityAction<T0> call)
		{
		}

		[Token(Token = "0x600051C")]
		public bool HasListeners()
		{
			return default(bool);
		}

		[Token(Token = "0x600051D")]
		public void CheckForListeners()
		{
		}

		[Token(Token = "0x600051E")]
		public UnityEventEx()
		{
		}
	}
	[Token(Token = "0x20000BC")]
	public static class DTLog
	{
		[Token(Token = "0x600051F")]
		[Address(RVA = "0x25082A0", Offset = "0x25082A0", VA = "0x25082A0")]
		public static void Log(object message)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x2508304", Offset = "0x2508304", VA = "0x2508304")]
		public static void Log(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x250243C", Offset = "0x250243C", VA = "0x250243C")]
		public static void LogError(object message)
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x2508378", Offset = "0x2508378", VA = "0x2508378")]
		public static void LogError(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x25083EC", Offset = "0x25083EC", VA = "0x25083EC")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x2508460", Offset = "0x2508460", VA = "0x2508460")]
		public static void LogErrorFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x25084DC", Offset = "0x25084DC", VA = "0x25084DC")]
		public static void LogException(Exception exception)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x2508540", Offset = "0x2508540", VA = "0x2508540")]
		public static void LogException(Exception exception, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x25085B4", Offset = "0x25085B4", VA = "0x25085B4")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x2508628", Offset = "0x2508628", VA = "0x2508628")]
		public static void LogFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x25086A4", Offset = "0x25086A4", VA = "0x25086A4")]
		public static void LogWarning(object message)
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x2508708", Offset = "0x2508708", VA = "0x2508708")]
		public static void LogWarning(object message, UnityEngine.Object context)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x250877C", Offset = "0x250877C", VA = "0x250877C")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x25087F0", Offset = "0x25087F0", VA = "0x25087F0")]
		public static void LogWarningFormat(UnityEngine.Object context, string format, params object[] args)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000BD")]
	public struct FloatRegion
	{
		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float From;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float To;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x170000EC")]
		public static FloatRegion ZeroOne
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1691880", Offset = "0x1691880", VA = "0x1691880")]
			get
			{
				return default(FloatRegion);
			}
		}

		[Token(Token = "0x170000ED")]
		public bool Positive
		{
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1691978", Offset = "0x1691978", VA = "0x1691978")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000EE")]
		public float Low
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x169192C", Offset = "0x169192C", VA = "0x169192C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x169193C", Offset = "0x169193C", VA = "0x169193C")]
			set
			{
			}
		}

		[Token(Token = "0x170000EF")]
		public float High
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1691950", Offset = "0x1691950", VA = "0x1691950")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1691960", Offset = "0x1691960", VA = "0x1691960")]
			set
			{
			}
		}

		[Token(Token = "0x170000F0")]
		public float Random
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x1691988", Offset = "0x1691988", VA = "0x1691988")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F1")]
		public float Next
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1691994", Offset = "0x1691994", VA = "0x1691994")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F2")]
		public float Length
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x16919B0", Offset = "0x16919B0", VA = "0x16919B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F3")]
		public float LengthPositive
		{
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x16919BC", Offset = "0x16919BC", VA = "0x16919BC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1691864", Offset = "0x1691864", VA = "0x1691864")]
		public FloatRegion(float value)
		{
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1691874", Offset = "0x1691874", VA = "0x1691874")]
		public FloatRegion(float A, float B)
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x169188C", Offset = "0x169188C", VA = "0x169188C")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x16918A0", Offset = "0x16918A0", VA = "0x16918A0")]
		public void Clamp(float low, float high)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x16919D4", Offset = "0x16919D4", VA = "0x16919D4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1691A78", Offset = "0x1691A78", VA = "0x1691A78", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1691AB0", Offset = "0x1691AB0", VA = "0x1691AB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1691B5C", Offset = "0x1691B5C", VA = "0x1691B5C")]
		public static FloatRegion operator +(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1691B90", Offset = "0x1691B90", VA = "0x1691B90")]
		public static FloatRegion operator -(FloatRegion a, FloatRegion b)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1691BC4", Offset = "0x1691BC4", VA = "0x1691BC4")]
		public static FloatRegion operator -(FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1691BDC", Offset = "0x1691BDC", VA = "0x1691BDC")]
		public static FloatRegion operator *(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1691C04", Offset = "0x1691C04", VA = "0x1691C04")]
		public static FloatRegion operator *(float v, FloatRegion a)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1691C2C", Offset = "0x1691C2C", VA = "0x1691C2C")]
		public static FloatRegion operator /(FloatRegion a, float v)
		{
			return default(FloatRegion);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1691C54", Offset = "0x1691C54", VA = "0x1691C54")]
		public static bool operator ==(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1691CC4", Offset = "0x1691CC4", VA = "0x1691CC4")]
		public static bool operator !=(FloatRegion lhs, FloatRegion rhs)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x20000BE")]
	public struct IntRegion
	{
		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int From;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int To;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool SimpleValue;

		[Token(Token = "0x170000F4")]
		public static IntRegion ZeroOne
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x169A38C", Offset = "0x169A38C", VA = "0x169A38C")]
			get
			{
				return default(IntRegion);
			}
		}

		[Token(Token = "0x170000F5")]
		public bool Positive
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x169A47C", Offset = "0x169A47C", VA = "0x169A47C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F6")]
		public int Low
		{
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x169A430", Offset = "0x169A430", VA = "0x169A430")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054D")]
			[Address(RVA = "0x169A440", Offset = "0x169A440", VA = "0x169A440")]
			set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public int High
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x169A454", Offset = "0x169A454", VA = "0x169A454")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x169A464", Offset = "0x169A464", VA = "0x169A464")]
			set
			{
			}
		}

		[Token(Token = "0x170000F8")]
		public int Random
		{
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x169A48C", Offset = "0x169A48C", VA = "0x169A48C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000F9")]
		public int Length
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x169A49C", Offset = "0x169A49C", VA = "0x169A49C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FA")]
		public int LengthPositive
		{
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x169A4A8", Offset = "0x169A4A8", VA = "0x169A4A8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x169A37C", Offset = "0x169A37C", VA = "0x169A37C")]
		public IntRegion(int value)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x168BBD4", Offset = "0x168BBD4", VA = "0x168BBD4")]
		public IntRegion(int A, int B)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x169A398", Offset = "0x169A398", VA = "0x169A398")]
		public void MakePositive()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x169A3AC", Offset = "0x169A3AC", VA = "0x169A3AC")]
		public void Clamp(int low, int high)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x169A4BC", Offset = "0x169A4BC", VA = "0x169A4BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x169A560", Offset = "0x169A560", VA = "0x169A560", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x169A598", Offset = "0x169A598", VA = "0x169A598", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x169A638", Offset = "0x169A638", VA = "0x169A638")]
		public static IntRegion operator +(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x169A654", Offset = "0x169A654", VA = "0x169A654")]
		public static IntRegion operator -(IntRegion a, IntRegion b)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x169A670", Offset = "0x169A670", VA = "0x169A670")]
		public static IntRegion operator -(IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x169A688", Offset = "0x169A688", VA = "0x169A688")]
		public static IntRegion operator *(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x169A6A0", Offset = "0x169A6A0", VA = "0x169A6A0")]
		public static IntRegion operator *(int v, IntRegion a)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x169A6BC", Offset = "0x169A6BC", VA = "0x169A6BC")]
		public static IntRegion operator /(IntRegion a, int v)
		{
			return default(IntRegion);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x169A6D4", Offset = "0x169A6D4", VA = "0x169A6D4")]
		public static bool operator ==(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x169A70C", Offset = "0x169A70C", VA = "0x169A70C")]
		public static bool operator !=(IntRegion lhs, IntRegion rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BF")]
	public class WeightedRandom<T>
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mData;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mCurrentPosition;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T mCurrentItem;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6EE8", Offset = "0x9C6EE8")]
		private int <Seed>k__BackingField;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6EF8", Offset = "0x9C6EF8")]
		private bool <RandomizeSeed>k__BackingField;

		[Token(Token = "0x170000FB")]
		public int Seed
		{
			[Token(Token = "0x600055E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E30", Offset = "0x9D1E30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600055F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E40", Offset = "0x9D1E40")]
			set
			{
			}
		}

		[Token(Token = "0x170000FC")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000560")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E50", Offset = "0x9D1E50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000561")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E60", Offset = "0x9D1E60")]
			set
			{
			}
		}

		[Token(Token = "0x170000FD")]
		private int Capacity
		{
			[Token(Token = "0x6000562")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000FE")]
		public int Size
		{
			[Token(Token = "0x6000563")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000564")]
		public WeightedRandom(int initCapacity = 0)
		{
		}

		[Token(Token = "0x6000565")]
		public void Add(T item, int amount)
		{
		}

		[Token(Token = "0x6000566")]
		public T Next()
		{
			return (T)null;
		}

		[Token(Token = "0x6000567")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000568")]
		public void Clear()
		{
		}
	}
	[Token(Token = "0x20000C0")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9C37F4", Offset = "0x9C37F4")]
	public class Ring<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mList;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6F08", Offset = "0x9C6F08")]
		private int <Size>k__BackingField;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int mIndex;

		[Token(Token = "0x170000FF")]
		public int Size
		{
			[Token(Token = "0x6000569")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E70", Offset = "0x9D1E70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600056A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E80", Offset = "0x9D1E80")]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public T Item
		{
			[Token(Token = "0x6000571")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000572")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public int Count
		{
			[Token(Token = "0x6000576")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000102")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000577")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600056B")]
		public Ring(int size)
		{
		}

		[Token(Token = "0x600056C")]
		public void Add(T item)
		{
		}

		[Token(Token = "0x600056D")]
		public void Clear()
		{
		}

		[Token(Token = "0x600056E")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Token(Token = "0x600056F")]
		public void Insert(int index, T item)
		{
		}

		[Token(Token = "0x6000570")]
		public void RemoveAt(int index)
		{
		}

		[Token(Token = "0x6000573")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000574")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		public void CopyTo(T[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000578")]
		public bool Remove(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x20000C1")]
	public class Pool<T> : IPool
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<T> mObjects;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6F18", Offset = "0x9C6F18")]
		private string <Identifier>k__BackingField;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C6F28", Offset = "0x9C6F28")]
		private PoolSettings <Settings>k__BackingField;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mLastTime;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private double mDeltaTime;

		[Token(Token = "0x17000103")]
		public string Identifier
		{
			[Token(Token = "0x600057A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1E90", Offset = "0x9D1E90")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1EA0", Offset = "0x9D1EA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public PoolSettings Settings
		{
			[Token(Token = "0x600057C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1EB0", Offset = "0x9D1EB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600057D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1EC0", Offset = "0x9D1EC0")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000105")]
		public Type Type
		{
			[Token(Token = "0x600057E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		public int Count
		{
			[Token(Token = "0x6000583")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600057F")]
		public Pool([Optional] PoolSettings settings)
		{
		}

		[Token(Token = "0x6000580")]
		public void Update()
		{
		}

		[Token(Token = "0x6000581")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000582")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000584")]
		public virtual T Pop([Optional] Transform parent)
		{
			return (T)null;
		}

		[Token(Token = "0x6000585")]
		public virtual void Push(T item)
		{
		}

		[Token(Token = "0x6000586")]
		protected virtual void sendBeforePush(T item)
		{
		}

		[Token(Token = "0x6000587")]
		protected virtual void sendAfterPop(T item)
		{
		}

		[Token(Token = "0x6000588")]
		protected virtual void setParent(T item, Transform parent)
		{
		}

		[Token(Token = "0x6000589")]
		protected virtual T create()
		{
			return (T)null;
		}

		[Token(Token = "0x600058A")]
		protected virtual void destroy(T item)
		{
		}

		[Token(Token = "0x600058B")]
		private void log(string msg)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C2")]
	public class PoolSettings
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_Prewarm;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool m_AutoCreate;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		[SerializeField]
		private bool m_AutoEnableDisable;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		[Positive]
		private int m_MinItems;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Positive]
		private int m_Threshold;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Positive]
		[SerializeField]
		private float m_Speed;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Debug;

		[Token(Token = "0x17000107")]
		public bool Prewarm
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x167D4B4", Offset = "0x167D4B4", VA = "0x167D4B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x167D3C8", Offset = "0x167D3C8", VA = "0x167D3C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000108")]
		public bool AutoCreate
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x167D4BC", Offset = "0x167D4BC", VA = "0x167D4BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x167D3E8", Offset = "0x167D3E8", VA = "0x167D3E8")]
			set
			{
			}
		}

		[Token(Token = "0x17000109")]
		public bool AutoEnableDisable
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0x167D4C4", Offset = "0x167D4C4", VA = "0x167D4C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000593")]
			[Address(RVA = "0x167D4CC", Offset = "0x167D4CC", VA = "0x167D4CC")]
			set
			{
			}
		}

		[Token(Token = "0x1700010A")]
		public int MinItems
		{
			[Token(Token = "0x6000594")]
			[Address(RVA = "0x167D4EC", Offset = "0x167D4EC", VA = "0x167D4EC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x167D408", Offset = "0x167D408", VA = "0x167D408")]
			set
			{
			}
		}

		[Token(Token = "0x1700010B")]
		public int Threshold
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x167D4F4", Offset = "0x167D4F4", VA = "0x167D4F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x167D440", Offset = "0x167D440", VA = "0x167D440")]
			set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public float Speed
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x167D4FC", Offset = "0x167D4FC", VA = "0x167D4FC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x167D478", Offset = "0x167D478", VA = "0x167D478")]
			set
			{
			}
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x167D3B0", Offset = "0x167D3B0", VA = "0x167D3B0")]
		public PoolSettings()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x167CBD8", Offset = "0x167CBD8", VA = "0x167CBD8")]
		public PoolSettings(PoolSettings src)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x167C124", Offset = "0x167C124", VA = "0x167C124")]
		public void OnValidate()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public interface IPool
	{
		[Token(Token = "0x1700010D")]
		string Identifier
		{
			[Token(Token = "0x600059B")]
			get;
			[Token(Token = "0x600059C")]
			set;
		}

		[Token(Token = "0x1700010E")]
		PoolSettings Settings
		{
			[Token(Token = "0x600059D")]
			get;
		}

		[Token(Token = "0x1700010F")]
		int Count
		{
			[Token(Token = "0x60005A1")]
			get;
		}

		[Token(Token = "0x600059E")]
		void Clear();

		[Token(Token = "0x600059F")]
		void Reset();

		[Token(Token = "0x60005A0")]
		void Update();
	}
	[Token(Token = "0x20000C4")]
	public interface IPoolable
	{
		[Token(Token = "0x60005A2")]
		void OnBeforePush();

		[Token(Token = "0x60005A3")]
		void OnAfterPop();
	}
	[Token(Token = "0x20000C5")]
	public enum DTMessageType
	{
		[Token(Token = "0x40003FE")]
		None,
		[Token(Token = "0x40003FF")]
		Info,
		[Token(Token = "0x4000400")]
		Warning,
		[Token(Token = "0x4000401")]
		Error
	}
	[Token(Token = "0x20000C6")]
	public enum AttributeOptionsFlags
	{
		[Token(Token = "0x4000403")]
		None = 0,
		[Token(Token = "0x4000404")]
		Compact = 1,
		[Token(Token = "0x4000405")]
		Clipboard = 128,
		[Token(Token = "0x4000406")]
		Zero = 256,
		[Token(Token = "0x4000407")]
		One = 512,
		[Token(Token = "0x4000408")]
		Negate = 1024,
		[Token(Token = "0x4000409")]
		Full = 1920,
		[Token(Token = "0x400040A")]
		FullCompact = 1921
	}
	[Token(Token = "0x20000C7")]
	public class DTPropertyAttribute : PropertyAttribute
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Label;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Tooltip;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Color;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AttributeOptionsFlags Options;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int Precision;

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x250A178", Offset = "0x250A178", VA = "0x250A178")]
		public DTPropertyAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class LabelAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1671040", Offset = "0x1671040", VA = "0x1671040")]
		public LabelAttribute()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1671094", Offset = "0x1671094", VA = "0x1671094")]
		public LabelAttribute(string label, string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public class ToggleButtonAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1DD3CB0", Offset = "0x1DD3CB0", VA = "0x1DD3CB0")]
		public ToggleButtonAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class LayerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x167109C", Offset = "0x167109C", VA = "0x167109C")]
		public LayerAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class TagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1DCE930", Offset = "0x1DCE930", VA = "0x1DCE930")]
		public TagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CC")]
	public class VectorExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1E03384", Offset = "0x1E03384", VA = "0x1E03384")]
		public VectorExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public class AnimationCurveExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x171224C", Offset = "0x171224C", VA = "0x171224C")]
		public AnimationCurveExAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CE")]
	public class MinAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1674074", Offset = "0x1674074", VA = "0x1674074")]
		public MinAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x16740A8", Offset = "0x16740A8", VA = "0x16740A8")]
		public MinAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class PositiveAttribute : MinAttribute
	{
		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x167D504", Offset = "0x167D504", VA = "0x167D504")]
		public PositiveAttribute()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class MaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MaxValue;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1671E34", Offset = "0x1671E34", VA = "0x1671E34")]
		public MaxAttribute(float value, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1671E68", Offset = "0x1671E68", VA = "0x1671E68")]
		public MaxAttribute(string fieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class RangeExAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinValue;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MinFieldOrPropertyName;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxValue;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string MaxFieldOrPropertyName;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool Slider;

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x167EE00", Offset = "0x167EE00", VA = "0x167EE00")]
		public RangeExAttribute(float minValue, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x167EE44", Offset = "0x167EE44", VA = "0x167EE44")]
		public RangeExAttribute(string minFieldOrProperty, float maxValue, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x167EE9C", Offset = "0x167EE9C", VA = "0x167EE9C")]
		public RangeExAttribute(float minValue, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x167EEF0", Offset = "0x167EEF0", VA = "0x167EEF0")]
		public RangeExAttribute(string minFieldOrProperty, string maxFieldOrProperty, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class MinMaxAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string MaxValueField;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Min;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string MinBoundFieldOrPropertyName;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float Max;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string MaxBoundFieldOrPropertyName;

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x16740E4", Offset = "0x16740E4", VA = "0x16740E4")]
		public MinMaxAttribute(string maxValueField, string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public class EnumFlagAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x168F194", Offset = "0x168F194", VA = "0x168F194")]
		public EnumFlagAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class ObjectSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x167B594", Offset = "0x167B594", VA = "0x167B594")]
		public ObjectSelectorAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D5")]
	public class PathSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x20000D6")]
		public enum DialogMode
		{
			[Token(Token = "0x4000424")]
			OpenFile,
			[Token(Token = "0x4000425")]
			OpenFolder,
			[Token(Token = "0x4000426")]
			CreateFile
		}

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly DialogMode Mode;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Title;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Directory;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Extension;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public string DefaultName;

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x167BCC8", Offset = "0x167BCC8", VA = "0x167BCC8")]
		public PathSelectorAttribute(DialogMode mode = DialogMode.OpenFile)
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class EnumSelectionGridAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x168F19C", Offset = "0x168F19C", VA = "0x168F19C")]
		public EnumSelectionGridAttribute(string label = "", string tooltip = "")
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class DTRegionAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RegionIsOptional;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string RegionOptionsPropertyName;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseSlider;

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x250A1D0", Offset = "0x250A1D0", VA = "0x250A1D0")]
		public DTRegionAttribute()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class FloatRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1691D38", Offset = "0x1691D38", VA = "0x1691D38")]
		public FloatRegionAttribute()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class IntRegionAttribute : DTRegionAttribute
	{
		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x169A744", Offset = "0x169A744", VA = "0x169A744")]
		public IntRegionAttribute()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public struct RegionOptions<T>
	{
		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelFrom;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string LabelTo;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OptionalTooltip;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampFrom;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DTValueClamping ClampTo;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMin;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T FromMax;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMin;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T ToMax;

		[Token(Token = "0x17000110")]
		public static RegionOptions<T> Default
		{
			[Token(Token = "0x60005BD")]
			get
			{
				return default(RegionOptions<T>);
			}
		}

		[Token(Token = "0x60005BE")]
		public static RegionOptions<T> MinMax(T min, T max)
		{
			return default(RegionOptions<T>);
		}
	}
	[Token(Token = "0x20000DC")]
	public enum DTValueClamping
	{
		[Token(Token = "0x4000434")]
		None,
		[Token(Token = "0x4000435")]
		Min,
		[Token(Token = "0x4000436")]
		Max,
		[Token(Token = "0x4000437")]
		Range
	}
	[Token(Token = "0x20000DD")]
	public class ThreadPoolWorker<T> : IDisposable
	{
		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<QueuedCallback> queuedCallbackPool;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly SimplePool<LoopState<T>> loopStatePool;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _remainingWorkItems;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private ManualResetEvent _done;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleWorkItemCallBack;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private WaitCallback handleLoopCallBack;

		[Token(Token = "0x60005BF")]
		public ThreadPoolWorker()
		{
		}

		[Token(Token = "0x60005C0")]
		public void ParralelFor(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x60005C1")]
		private bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C2")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x60005C3")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x60005C4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1ED0", Offset = "0x9D1ED0")]
		private void <.ctor>b__6_0(object o)
		{
		}

		[Token(Token = "0x60005C6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1EE0", Offset = "0x9D1EE0")]
		private void <.ctor>b__6_1(object state)
		{
		}
	}
	[Token(Token = "0x20000DE")]
	internal class SimplePool<T> where T : new()
	{
		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly List<T> freeItemsBackfield;

		[Token(Token = "0x60005C7")]
		public SimplePool(int preCreatedElementsCount)
		{
		}

		[Token(Token = "0x60005C8")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x60005C9")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x20000DF")]
	internal class QueuedCallback
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WaitCallback Callback;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object State;

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x167EDF8", Offset = "0x167EDF8", VA = "0x167EDF8")]
		public QueuedCallback()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	internal class LoopState<T>
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short StartIndex;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public short EndIndex;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<T> Items;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Action<T> Action;

		[Token(Token = "0x60005CB")]
		public LoopState()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class ThreadPoolWorker : IDisposable
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C382C", Offset = "0x9C382C")]
		private sealed class <>c__4<T>
		{
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__4<T> <>9;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static WaitCallback <>9__4_0;

			[Token(Token = "0x60005DB")]
			public <>c__4()
			{
			}

			[Token(Token = "0x60005DC")]
			internal void <ParralelFor>b__4_0(object state)
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C383C", Offset = "0x9C383C")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action act;

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1E0E348", Offset = "0x1E0E348", VA = "0x1E0E348")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1E0E350", Offset = "0x1E0E350", VA = "0x1E0E350")]
			internal void <QueueWorkItem>b__0(object x)
			{
			}
		}

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _remainingWorkItems;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ManualResetEvent _done;

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1DD2C70", Offset = "0x1DD2C70", VA = "0x1DD2C70")]
		public void QueueWorkItem(WaitCallback callback)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1DD2D10", Offset = "0x1DD2D10", VA = "0x1DD2D10")]
		public void QueueWorkItem(Action act)
		{
		}

		[Token(Token = "0x60005CE")]
		public void ParralelFor<T>(Action<T> action, List<T> list)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1DD2E38", Offset = "0x1DD2E38", VA = "0x1DD2E38")]
		private void QueueWorkItem(QueuedCallback callback)
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1DD2C78", Offset = "0x1DD2C78", VA = "0x1DD2C78")]
		public void QueueWorkItem(WaitCallback callback, object state)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1DD2D18", Offset = "0x1DD2D18", VA = "0x1DD2D18")]
		public void QueueWorkItem(Action act, object state)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x1DD2FF0", Offset = "0x1DD2FF0", VA = "0x1DD2FF0")]
		public bool WaitAll()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1DD3148", Offset = "0x1DD3148", VA = "0x1DD3148")]
		public bool WaitAll(TimeSpan timeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1DD2FFC", Offset = "0x1DD2FFC", VA = "0x1DD2FFC")]
		public bool WaitAll(int millisecondsTimeout, bool exitContext)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1DD3290", Offset = "0x1DD3290", VA = "0x1DD3290")]
		private void HandleWorkItem(object state)
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1DD31A8", Offset = "0x1DD31A8", VA = "0x1DD31A8")]
		private void DoneWorkItem()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1DD2F7C", Offset = "0x1DD2F7C", VA = "0x1DD2F7C")]
		private void ThrowIfDisposed()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1DD337C", Offset = "0x1DD337C", VA = "0x1DD337C", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1DD3440", Offset = "0x1DD3440", VA = "0x1DD3440")]
		public ThreadPoolWorker()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class ComponentPool : MonoBehaviour, IPool, ISerializationCallbackReceiver
	{
		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C384C", Offset = "0x9C384C")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string typeName;

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1E07C18", Offset = "0x1E07C18", VA = "0x1E07C18")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1E07C20", Offset = "0x1E07C20", VA = "0x1E07C20")]
			internal bool <OnAfterDeserialize>b__0(Type t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Identifier;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Inline]
		[SerializeField]
		private PoolSettings m_Settings;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private PoolManager mManager;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UnityEngine.Component> mObjects;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private double mLastTime;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mDeltaTime;

		[Token(Token = "0x17000111")]
		public PoolSettings Settings
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1C3FE24", Offset = "0x1C3FE24", VA = "0x1C3FE24", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1C3FE2C", Offset = "0x1C3FE2C", VA = "0x1C3FE2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000112")]
		public PoolManager Manager
		{
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1C3FE7C", Offset = "0x1C3FE7C", VA = "0x1C3FE7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000113")]
		public string Identifier
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x1C3FF30", Offset = "0x1C3FF30", VA = "0x1C3FF30", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1C3FF38", Offset = "0x1C3FF38", VA = "0x1C3FF38", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000114")]
		public Type Type
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1C3FF8C", Offset = "0x1C3FF8C", VA = "0x1C3FF8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000115")]
		public int Count
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1C40068", Offset = "0x1C40068", VA = "0x1C40068", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1C400B4", Offset = "0x1C400B4", VA = "0x1C400B4")]
		public void Initialize(Type type, PoolSettings settings)
		{
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x1C402E4", Offset = "0x1C402E4", VA = "0x1C402E4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1C40308", Offset = "0x1C40308", VA = "0x1C40308")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1C403C4", Offset = "0x1C403C4", VA = "0x1C403C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x1C403C8", Offset = "0x1C403C8", VA = "0x1C403C8", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x1C40180", Offset = "0x1C40180", VA = "0x1C40180", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1C40898", Offset = "0x1C40898", VA = "0x1C40898")]
		public void OnSceneLoaded(Scene scn, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1C409AC", Offset = "0x1C409AC", VA = "0x1C409AC", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1C40A94", Offset = "0x1C40A94", VA = "0x1C40A94")]
		public void Push(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1C40DB4", Offset = "0x1C40DB4", VA = "0x1C40DB4")]
		public UnityEngine.Component Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60005F0")]
		public T Pop<T>(Transform parent) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1C407B4", Offset = "0x1C407B4", VA = "0x1C407B4")]
		private UnityEngine.Component create()
		{
			return null;
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1C406FC", Offset = "0x1C406FC", VA = "0x1C406FC")]
		private void destroy(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1C4118C", Offset = "0x1C4118C", VA = "0x1C4118C")]
		private void setParent(UnityEngine.Component item, Transform parent)
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1C40FC0", Offset = "0x1C40FC0", VA = "0x1C40FC0")]
		private void sendAfterPop(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1C40BEC", Offset = "0x1C40BEC", VA = "0x1C40BEC")]
		private void sendBeforePush(UnityEngine.Component item)
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1C4061C", Offset = "0x1C4061C", VA = "0x1C4061C")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1C41238", Offset = "0x1C41238", VA = "0x1C41238", Slot = "11")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1C4123C", Offset = "0x1C4123C", VA = "0x1C4123C", Slot = "12")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1C414EC", Offset = "0x1C414EC", VA = "0x1C414EC")]
		public ComponentPool()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class DTSingleton<T> : MonoBehaviour where T : MonoBehaviour, IDTSingleton
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T _instance;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static object _lock;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool applicationIsQuitting;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool isDuplicateInstance;

		[Token(Token = "0x17000116")]
		public static bool HasInstance
		{
			[Token(Token = "0x60005FC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000117")]
		public static T Instance
		{
			[Token(Token = "0x60005FD")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FE")]
		public virtual void Awake()
		{
		}

		[Token(Token = "0x60005FF")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000600")]
		protected virtual void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x6000601")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x6000602")]
		public DTSingleton()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public interface IDTSingleton
	{
		[Token(Token = "0x6000604")]
		void MergeDoubleLoaded(IDTSingleton newInstance);
	}
	[Token(Token = "0x20000E8")]
	public class DTVersionedMonoBehaviour : MonoBehaviour
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private string m_Version;

		[Token(Token = "0x17000118")]
		public string Version
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x250C59C", Offset = "0x250C59C", VA = "0x250C59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x250C5A4", Offset = "0x250C5A4", VA = "0x250C5A4")]
		protected void CheckForVersionUpgrade()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x250C5A8", Offset = "0x250C5A8", VA = "0x250C5A8", Slot = "4")]
		protected virtual bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x250C8AC", Offset = "0x250C8AC", VA = "0x250C8AC")]
		public void Destroy()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x250C95C", Offset = "0x250C95C", VA = "0x250C95C")]
		public DTVersionedMonoBehaviour()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	[ExecuteInEditMode]
	public class DuplicateEditorMesh : MonoBehaviour
	{
		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MeshFilter mFilter;

		[Token(Token = "0x17000119")]
		public MeshFilter Filter
		{
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x168D3C0", Offset = "0x168D3C0", VA = "0x168D3C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x168D474", Offset = "0x168D474", VA = "0x168D474", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x168D700", Offset = "0x168D700", VA = "0x168D700")]
		public DuplicateEditorMesh()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class InspectorNote : MonoBehaviour
	{
		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x9C70B8", Offset = "0x9C70B8")]
		[SerializeField]
		private string m_Note;

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x169A374", Offset = "0x169A374", VA = "0x169A374")]
		public InspectorNote()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class PoolManager : MonoBehaviour
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C70F8", Offset = "0x9C70F8")]
		private bool m_AutoCreatePools;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x9C7150", Offset = "0x9C7150")]
		private PoolSettings m_DefaultSettings;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C7198", Offset = "0x9C7198")]
		private bool <IsInitialized>k__BackingField;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, IPool> Pools;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Dictionary<Type, IPool> TypePools;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private IPool[] mPools;

		[Token(Token = "0x1700011A")]
		public bool AutoCreatePools
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x167C0A8", Offset = "0x167C0A8", VA = "0x167C0A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x167C0B0", Offset = "0x167C0B0", VA = "0x167C0B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700011B")]
		public PoolSettings DefaultSettings
		{
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x167C0D0", Offset = "0x167C0D0", VA = "0x167C0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x167C0D8", Offset = "0x167C0D8", VA = "0x167C0D8")]
			set
			{
			}
		}

		[Token(Token = "0x1700011C")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x167C19C", Offset = "0x167C19C", VA = "0x167C19C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1EF0", Offset = "0x9D1EF0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x167C1A4", Offset = "0x167C1A4", VA = "0x167C1A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D1F00", Offset = "0x9D1F00")]
			private set
			{
			}
		}

		[Token(Token = "0x1700011D")]
		public int Count
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x167C1B0", Offset = "0x167C1B0", VA = "0x167C1B0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x167C238", Offset = "0x167C238", VA = "0x167C238")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x167C240", Offset = "0x167C240", VA = "0x167C240")]
		private void Update()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x167C400", Offset = "0x167C400", VA = "0x167C400")]
		private void Initialize()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x167C88C", Offset = "0x167C88C", VA = "0x167C88C")]
		public string GetUniqueIdentifier(string ident)
		{
			return null;
		}

		[Token(Token = "0x6000619")]
		public Pool<T> GetTypePool<T>()
		{
			return null;
		}

		[Token(Token = "0x600061A")]
		public ComponentPool GetComponentPool<T>() where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x167C940", Offset = "0x167C940", VA = "0x167C940")]
		public PrefabPool GetPrefabPool(string identifier, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x600061C")]
		public Pool<T> CreateTypePool<T>([Optional] PoolSettings settings)
		{
			return null;
		}

		[Token(Token = "0x600061D")]
		public ComponentPool CreateComponentPool<T>([Optional] PoolSettings settings) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x167CA44", Offset = "0x167CA44", VA = "0x167CA44")]
		public PrefabPool CreatePrefabPool(string name, [Optional] PoolSettings settings, params GameObject[] prefabs)
		{
			return null;
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x167CDF4", Offset = "0x167CDF4", VA = "0x167CDF4")]
		public List<IPool> FindPools(string identifierStartsWith)
		{
			return null;
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x167CFC0", Offset = "0x167CFC0", VA = "0x167CFC0")]
		public void DeletePools(string startsWith)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x167D078", Offset = "0x167D078", VA = "0x167D078")]
		public void DeletePool(IPool pool)
		{
		}

		[Token(Token = "0x6000622")]
		public void DeletePool<T>()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x167D260", Offset = "0x167D260", VA = "0x167D260")]
		public PoolManager()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C38A4", Offset = "0x9C38A4")]
	public class PrefabPool : MonoBehaviour, IPool
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C71A8", Offset = "0x9C71A8")]
		private string m_Identifier;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<GameObject> m_Prefabs;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Inline]
		private PoolSettings m_Settings;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PoolManager mManager;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<GameObject> mObjects;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private double mLastTime;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private double mDeltaTime;

		[Token(Token = "0x1700011E")]
		public string Identifier
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x167D560", Offset = "0x167D560", VA = "0x167D560", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x167D568", Offset = "0x167D568", VA = "0x167D568", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700011F")]
		public List<GameObject> Prefabs
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x167D69C", Offset = "0x167D69C", VA = "0x167D69C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x167D6A4", Offset = "0x167D6A4", VA = "0x167D6A4")]
			set
			{
			}
		}

		[Token(Token = "0x17000120")]
		public PoolSettings Settings
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x167D6BC", Offset = "0x167D6BC", VA = "0x167D6BC", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x167D6C4", Offset = "0x167D6C4", VA = "0x167D6C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000121")]
		public PoolManager Manager
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x167D5E8", Offset = "0x167D5E8", VA = "0x167D5E8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		public int Count
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x167DAF0", Offset = "0x167DAF0", VA = "0x167DAF0", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x167D710", Offset = "0x167D710", VA = "0x167D710")]
		private void Awake()
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x167D714", Offset = "0x167D714", VA = "0x167D714")]
		private void Start()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x167CCC4", Offset = "0x167CCC4", VA = "0x167CCC4")]
		public void Initialize(string ident, PoolSettings settings, params GameObject[] prefabs)
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x167D89C", Offset = "0x167D89C", VA = "0x167D89C", Slot = "9")]
		public void Update()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x167D738", Offset = "0x167D738", VA = "0x167D738", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x167DDE8", Offset = "0x167DDE8", VA = "0x167DDE8", Slot = "7")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x167DED0", Offset = "0x167DED0", VA = "0x167DED0")]
		public GameObject Pop([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x167E12C", Offset = "0x167E12C", VA = "0x167E12C", Slot = "11")]
		public virtual void Push(GameObject item)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x167DC80", Offset = "0x167DC80", VA = "0x167DC80")]
		private GameObject create()
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x167DC1C", Offset = "0x167DC1C", VA = "0x167DC1C")]
		private void destroy(GameObject go)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x167DB3C", Offset = "0x167DB3C", VA = "0x167DB3C")]
		private void log(string msg)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x167E32C", Offset = "0x167E32C", VA = "0x167E32C")]
		private void setParent(Transform item, Transform parent)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x167E0D0", Offset = "0x167E0D0", VA = "0x167E0D0")]
		private void sendAfterPop(GameObject item)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x167E2D0", Offset = "0x167E2D0", VA = "0x167E2D0")]
		private void sendBeforePush(GameObject item)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x167E3CC", Offset = "0x167E3CC", VA = "0x167E3CC")]
		public PrefabPool()
		{
		}
	}
}
namespace FluffyUnderware.DevTools.Extensions
{
	[Token(Token = "0x20000ED")]
	public static class TransformExt
	{
		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1DD3CB8", Offset = "0x1DD3CB8", VA = "0x1DD3CB8")]
		public static void CopyFrom(this Transform t, Transform other)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1DD3D28", Offset = "0x1DD3D28", VA = "0x1DD3D28")]
		public static void SetChildrenHideFlags(this Transform t, HideFlags flags)
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public static class ObjectExt
	{
		[Token(Token = "0x600063D")]
		[Address(RVA = "0x16773CC", Offset = "0x16773CC", VA = "0x16773CC")]
		public static void Destroy(this UnityEngine.Object c)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1677430", Offset = "0x1677430", VA = "0x1677430")]
		public static string ToDumpString(this object o)
		{
			return null;
		}
	}
	[Token(Token = "0x20000EF")]
	public static class Vector2Ext
	{
		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1E01498", Offset = "0x1E01498", VA = "0x1E01498")]
		public static Vector2 Snap(this Vector2 v, float snapX, float snapY = -1f)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1E014F0", Offset = "0x1E014F0", VA = "0x1E014F0")]
		public static float AngleSigned(this Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1E01644", Offset = "0x1E01644", VA = "0x1E01644")]
		public static Vector2 LeftNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1E01658", Offset = "0x1E01658", VA = "0x1E01658")]
		public static Vector2 RightNormal(this Vector2 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1E01668", Offset = "0x1E01668", VA = "0x1E01668")]
		public static Vector2 Rotate(this Vector2 v, float degree)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1E016C8", Offset = "0x1E016C8", VA = "0x1E016C8")]
		public static Vector2 ToVector3(this Vector2 v)
		{
			return default(Vector2);
		}
	}
	[Token(Token = "0x20000F0")]
	public static class Vector3Ext
	{
		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1E01D28", Offset = "0x1E01D28", VA = "0x1E01D28")]
		public static float AngleSigned(this Vector3 a, Vector3 b, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1E01DCC", Offset = "0x1E01DCC", VA = "0x1E01DCC")]
		public static Vector3 RotateAround(this Vector3 point, Vector3 origin, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1E01E2C", Offset = "0x1E01E2C", VA = "0x1E01E2C")]
		public static Vector2 ToVector2(this Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1E01E30", Offset = "0x1E01E30", VA = "0x1E01E30")]
		public static bool Approximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1E01E64", Offset = "0x1E01E64", VA = "0x1E01E64")]
		public static bool NotApproximately(this Vector3 v1, Vector3 v2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F1")]
	public static class QuaternionExt
	{
		[Token(Token = "0x600064A")]
		[Address(RVA = "0x167EC40", Offset = "0x167EC40", VA = "0x167EC40")]
		public static bool SameOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x167ED1C", Offset = "0x167ED1C", VA = "0x167ED1C")]
		public static bool DifferentOrientation(this Quaternion q1, Quaternion q2)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F2")]
	public static class CameraExt
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Plane[] camPlanes;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Vector3 camPos;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static Vector3 camForward;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static float fov;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static float screenW;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float screenH;

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1C3C8EC", Offset = "0x1C3C8EC", VA = "0x1C3C8EC")]
		public static bool BoundsInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1C3CBE0", Offset = "0x1C3CBE0", VA = "0x1C3CBE0")]
		public static bool BoundsPartiallyInView(this Camera c, Bounds bounds)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000F3")]
	public static class GameObjectExt
	{
		[Token(Token = "0x600064F")]
		[Address(RVA = "0x169278C", Offset = "0x169278C", VA = "0x169278C")]
		public static GameObject DuplicateGameObject(this GameObject source, Transform newParent, bool keepPrefabReference = false)
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1692890", Offset = "0x1692890", VA = "0x1692890")]
		public static void StripComponents(this GameObject go, params Type[] toKeep)
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public static class ComponentExt
	{
		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1C3FA34", Offset = "0x1C3FA34", VA = "0x1C3FA34")]
		public static void StripComponents(this UnityEngine.Component c, params Type[] toKeep)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1C3FB20", Offset = "0x1C3FB20", VA = "0x1C3FB20")]
		public static GameObject AddChildGameObject(this UnityEngine.Component c, string name)
		{
			return null;
		}

		[Token(Token = "0x6000653")]
		public static T AddChildGameObject<T>(this UnityEngine.Component c, string name) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000654")]
		public static T DuplicateGameObject<T>(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false) where T : UnityEngine.Component
		{
			return null;
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1C3FBC8", Offset = "0x1C3FBC8", VA = "0x1C3FBC8")]
		public static UnityEngine.Component DuplicateGameObject(this UnityEngine.Component source, Transform newParent, bool keepPrefabConnection = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F5")]
	public static class ColorExt
	{
		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1C3D38C", Offset = "0x1C3D38C", VA = "0x1C3D38C")]
		public static string ToHtml(this Color c)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F6")]
	public static class EnumExt
	{
		[Token(Token = "0x6000657")]
		[Address(RVA = "0x168E794", Offset = "0x168E794", VA = "0x168E794")]
		public static bool HasFlag(this Enum variable, params Enum[] flags)
		{
			return default(bool);
		}

		[Token(Token = "0x6000658")]
		public static bool HasFlag<T>(this T value, T flag) where T : struct
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		public static T Set<T>(this Enum value, T append)
		{
			return (T)null;
		}

		[Token(Token = "0x600065A")]
		public static T Set<T>(this Enum value, T append, bool OnOff)
		{
			return (T)null;
		}

		[Token(Token = "0x600065B")]
		public static T Toggle<T>(this Enum value, T toggleValue)
		{
			return (T)null;
		}

		[Token(Token = "0x600065C")]
		public static T SetAll<T>(this Enum value)
		{
			return (T)null;
		}
	}
	[Token(Token = "0x20000F7")]
	public static class RectExt
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x167EF50", Offset = "0x167EF50", VA = "0x167EF50")]
		public static Rect Set(this Rect rect, Vector2 pos, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x167EFAC", Offset = "0x167EFAC", VA = "0x167EFAC")]
		public static Rect SetBetween(this Rect rect, Vector2 pos, Vector2 pos2)
		{
			return default(Rect);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x167F008", Offset = "0x167F008", VA = "0x167F008")]
		public static Rect SetPosition(this Rect rect, Vector2 pos)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x167F074", Offset = "0x167F074", VA = "0x167F074")]
		public static Rect SetPosition(this Rect rect, float x, float y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x167F0E0", Offset = "0x167F0E0", VA = "0x167F0E0")]
		public static Vector2 GetSize(this Rect rect)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x167F12C", Offset = "0x167F12C", VA = "0x167F12C")]
		public static Rect SetSize(this Rect rect, Vector2 size)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x167F198", Offset = "0x167F198", VA = "0x167F198")]
		public static Rect ScaleBy(this Rect rect, int pixel)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x167F1A0", Offset = "0x167F1A0", VA = "0x167F1A0")]
		public static Rect ScaleBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x167F278", Offset = "0x167F278", VA = "0x167F278")]
		public static Rect ShiftBy(this Rect rect, int x, int y)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x167F308", Offset = "0x167F308", VA = "0x167F308")]
		public static Rect Include(this Rect rect, Rect other)
		{
			return default(Rect);
		}
	}
	[Token(Token = "0x20000F8")]
	public static class StringExt
	{
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1DCDD7C", Offset = "0x1DCDD7C", VA = "0x1DCDD7C")]
		public static Color ColorFromHtml(this string hexString)
		{
			return default(Color);
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1DCE020", Offset = "0x1DCE020", VA = "0x1DCE020")]
		public static string TrimStart(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1DCE074", Offset = "0x1DCE074", VA = "0x1DCE074")]
		public static string TrimEnd(this string s, string trim, StringComparison compare = StringComparison.CurrentCultureIgnoreCase)
		{
			return null;
		}
	}
	[Token(Token = "0x20000F9")]
	public static class IEnumerableExt
	{
		[Token(Token = "0x600066A")]
		public static void ForEach<T>(this IEnumerable<T> ie, Action<T> action)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public static class ArrayExt
	{
		[Token(Token = "0x600066B")]
		public static T[] SubArray<T>(this T[] data, int index, int length)
		{
			return null;
		}

		[Token(Token = "0x600066C")]
		public static T[] RemoveAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x600066D")]
		public static T[] InsertAt<T>(this T[] source, int index)
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		public static T[] Swap<T>(this T[] source, int index, int with)
		{
			return null;
		}

		[Token(Token = "0x600066F")]
		public static T[] Add<T>(this T[] source, T item)
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		public static T[] AddRange<T>(this T[] source, T[] items)
		{
			return null;
		}

		[Token(Token = "0x6000671")]
		public static T[] RemoveDuplicates<T>(this T[] source)
		{
			return null;
		}

		[Token(Token = "0x6000672")]
		public static int IndexOf<T>(this T[] source, T item)
		{
			return default(int);
		}

		[Token(Token = "0x6000673")]
		public static T[] Remove<T>(this T[] source, T item)
		{
			return null;
		}
	}
	[Token(Token = "0x20000FB")]
	public static class MeshFilterExt
	{
		[Token(Token = "0x6000674")]
		[Address(RVA = "0x16720C8", Offset = "0x16720C8", VA = "0x16720C8")]
		public static Mesh PrepareNewShared(this MeshFilter m, string name = "Mesh")
		{
			return null;
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1672254", Offset = "0x1672254", VA = "0x1672254")]
		public static void CalculateTangents(this MeshFilter m)
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public static class TypeExt
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3A04", Offset = "0x9C3A04")]
		private sealed class <>c
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Assembly, IEnumerable<Type>> <>9__1_0;

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1E0E3D0", Offset = "0x1E0E3D0", VA = "0x1E0E3D0")]
			public <>c()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1E0E3D8", Offset = "0x1E0E3D8", VA = "0x1E0E3D8")]
			internal IEnumerable<Type> <GetLoadedTypes>b__1_0(Assembly a)
			{
				return null;
			}
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1DD403C", Offset = "0x1DD403C", VA = "0x1DD403C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D22B0", Offset = "0x9D22B0")]
		public static Type[] GetAllTypes(this Type typeFromAssembly)
		{
			return null;
		}

		[Token(Token = "0x6000677")]
		[Address(RVA = "0x1DD4074", Offset = "0x1DD4074", VA = "0x1DD4074")]
		public static Type[] GetLoadedTypes()
		{
			return null;
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1DD41BC", Offset = "0x1DD41BC", VA = "0x1DD41BC")]
		public static IEnumerable<Assembly> GetLoadedAssemblies()
		{
			return null;
		}

		[Token(Token = "0x6000679")]
		public static Dictionary<U, Type> GetAllTypesWithAttribute<U>(this Type type)
		{
			return null;
		}

		[Token(Token = "0x600067A")]
		public static List<FieldInfo> GetFieldsWithAttribute<T>(this Type type, bool includeInherited = false, bool includePrivate = false) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		public static T GetCustomAttribute<T>(this Type type) where T : Attribute
		{
			return null;
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1DD41E0", Offset = "0x1DD41E0", VA = "0x1DD41E0")]
		public static MethodInfo MethodByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1DD4390", Offset = "0x1DD4390", VA = "0x1DD4390")]
		public static FieldInfo FieldByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1DD4558", Offset = "0x1DD4558", VA = "0x1DD4558")]
		public static PropertyInfo PropertyByName(this Type type, string name, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1DD4708", Offset = "0x1DD4708", VA = "0x1DD4708")]
		public static FieldInfo[] GetAllFields(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1DD48C0", Offset = "0x1DD48C0", VA = "0x1DD48C0")]
		public static PropertyInfo[] GetAllProperties(this Type type, bool includeInherited = false, bool includePrivate = false)
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1DD4A78", Offset = "0x1DD4A78", VA = "0x1DD4A78")]
		public static bool IsFrameworkType(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1DD4B98", Offset = "0x1DD4B98", VA = "0x1DD4B98")]
		public static bool IsArrayOrList(this Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1DD4C88", Offset = "0x1DD4C88", VA = "0x1DD4C88")]
		public static Type GetEnumerableType(this Type t)
		{
			return null;
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1DD4D44", Offset = "0x1DD4D44", VA = "0x1DD4D44")]
		private static Type FindIEnumerable(Type seqType)
		{
			return null;
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1DD4214", Offset = "0x1DD4214", VA = "0x1DD4214")]
		private static MethodInfo GetMethodIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1DD43CC", Offset = "0x1DD43CC", VA = "0x1DD43CC")]
		private static FieldInfo GetFieldIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1DD458C", Offset = "0x1DD458C", VA = "0x1DD458C")]
		private static PropertyInfo GetPropertyIncludingBaseClasses(this Type type, string name, BindingFlags bindingFlags)
		{
			return null;
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1DD51B0", Offset = "0x1DD51B0", VA = "0x1DD51B0")]
		public static bool Matches(this Type type, params Type[] types)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000FE")]
	public static class FieldInfoExt
	{
		[Token(Token = "0x600068C")]
		public static T GetCustomAttribute<T>(this FieldInfo field) where T : Attribute
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy
{
	[Token(Token = "0x20000FF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3A24", Offset = "0x9C3A24")]
	public class MetaCGOptions : CurvyMetadataBase, ICurvyMetadata
	{
		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Positive]
		[SerializeField]
		private int m_MaterialID;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_HardEdge;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Positive]
		[SerializeField]
		private float m_MaxStepDistance;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C7318", Offset = "0x9C7318")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C7318", Offset = "0x9C7318")]
		private bool m_UVEdge;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C7414", Offset = "0x9C7414")]
		[Positive]
		private bool m_ExplicitU;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9C74D4", Offset = "0x9C74D4")]
		[Positive]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C74D4", Offset = "0x9C74D4")]
		private float m_FirstU;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C75BC", Offset = "0x9C75BC")]
		[Positive]
		[SerializeField]
		private float m_SecondU;

		[Token(Token = "0x17000123")]
		public int MaterialID
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1673A30", Offset = "0x1673A30", VA = "0x1673A30")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1673A38", Offset = "0x1673A38", VA = "0x1673A38")]
			set
			{
			}
		}

		[Token(Token = "0x17000124")]
		public bool HardEdge
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1673A84", Offset = "0x1673A84", VA = "0x1673A84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1673A8C", Offset = "0x1673A8C", VA = "0x1673A8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000125")]
		public bool UVEdge
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1673AB4", Offset = "0x1673AB4", VA = "0x1673AB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1673ABC", Offset = "0x1673ABC", VA = "0x1673ABC")]
			set
			{
			}
		}

		[Token(Token = "0x17000126")]
		public bool ExplicitU
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1673AE4", Offset = "0x1673AE4", VA = "0x1673AE4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1673AEC", Offset = "0x1673AEC", VA = "0x1673AEC")]
			set
			{
			}
		}

		[Token(Token = "0x17000127")]
		public float FirstU
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1673B14", Offset = "0x1673B14", VA = "0x1673B14")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1673B1C", Offset = "0x1673B1C", VA = "0x1673B1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000128")]
		public float SecondU
		{
			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1673B38", Offset = "0x1673B38", VA = "0x1673B38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1673B40", Offset = "0x1673B40", VA = "0x1673B40")]
			set
			{
			}
		}

		[Token(Token = "0x17000129")]
		public float MaxStepDistance
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1673B5C", Offset = "0x1673B5C", VA = "0x1673B5C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1673B64", Offset = "0x1673B64", VA = "0x1673B64")]
			set
			{
			}
		}

		[Token(Token = "0x1700012A")]
		public bool HasDifferentMaterial
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1673BB4", Offset = "0x1673BB4", VA = "0x1673BB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012B")]
		private bool showUVEdge
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1673C74", Offset = "0x1673C74", VA = "0x1673C74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012C")]
		private bool showExplicitU
		{
			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1673DC0", Offset = "0x1673DC0", VA = "0x1673DC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012D")]
		private bool showFirstU
		{
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1673E50", Offset = "0x1673E50", VA = "0x1673E50")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012E")]
		private bool showSecondU
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1673EEC", Offset = "0x1673EEC", VA = "0x1673EEC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1673F00", Offset = "0x1673F00", VA = "0x1673F00")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1673FB8", Offset = "0x1673FB8", VA = "0x1673FB8")]
		public float GetDefinedFirstU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1674004", Offset = "0x1674004", VA = "0x1674004")]
		public float GetDefinedSecondU(float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x167406C", Offset = "0x167406C", VA = "0x167406C")]
		public MetaCGOptions()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public interface ICurvyMetadata
	{
	}
	[Token(Token = "0x2000101")]
	public interface ICurvyInterpolatableMetadata : ICurvyMetadata
	{
		[Token(Token = "0x1700012F")]
		object Value
		{
			[Token(Token = "0x60006A4")]
			get;
		}

		[Token(Token = "0x60006A5")]
		object InterpolateObject(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x2000102")]
	public interface ICurvyInterpolatableMetadata<U> : ICurvyInterpolatableMetadata, ICurvyMetadata
	{
		[Token(Token = "0x60006A6")]
		U Interpolate(ICurvyMetadata b, float f);
	}
	[Token(Token = "0x2000103")]
	public enum OrientationModeEnum
	{
		[Token(Token = "0x4000475")]
		None,
		[Token(Token = "0x4000476")]
		Orientation,
		[Token(Token = "0x4000477")]
		Tangent
	}
	[Token(Token = "0x2000104")]
	public enum OrientationAxisEnum
	{
		[Token(Token = "0x4000479")]
		Up,
		[Token(Token = "0x400047A")]
		Down,
		[Token(Token = "0x400047B")]
		Forward,
		[Token(Token = "0x400047C")]
		Backward,
		[Token(Token = "0x400047D")]
		Left,
		[Token(Token = "0x400047E")]
		Right
	}
	[Token(Token = "0x2000105")]
	public enum ConnectionHeadingEnum
	{
		[Token(Token = "0x4000480")]
		Minus = -1,
		[Token(Token = "0x4000481")]
		Sharp,
		[Token(Token = "0x4000482")]
		Plus,
		[Token(Token = "0x4000483")]
		Auto
	}
	[Token(Token = "0x2000106")]
	public static class ConnectionHeadingEnumMethods
	{
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1C43534", Offset = "0x1C43534", VA = "0x1C43534")]
		public static ConnectionHeadingEnum ResolveAuto(this ConnectionHeadingEnum heading, CurvySplineSegment followUp)
		{
			return default(ConnectionHeadingEnum);
		}
	}
	[Token(Token = "0x2000107")]
	public enum CurvyUpdateMethod
	{
		[Token(Token = "0x4000485")]
		Update,
		[Token(Token = "0x4000486")]
		LateUpdate,
		[Token(Token = "0x4000487")]
		FixedUpdate
	}
	[Token(Token = "0x2000108")]
	public enum CurvyRepeatingOrderEnum
	{
		[Token(Token = "0x4000489")]
		Random,
		[Token(Token = "0x400048A")]
		Row
	}
	[Token(Token = "0x2000109")]
	public enum CurvyPlane
	{
		[Token(Token = "0x400048C")]
		XY,
		[Token(Token = "0x400048D")]
		XZ,
		[Token(Token = "0x400048E")]
		YZ
	}
	[Token(Token = "0x200010A")]
	public enum CurvyPositionMode
	{
		[Token(Token = "0x4000490")]
		Relative,
		[Token(Token = "0x4000491")]
		WorldUnits
	}
	[Token(Token = "0x200010B")]
	[Flags]
	public enum CurvyBezierModeEnum
	{
		[Token(Token = "0x4000493")]
		None = 0,
		[Token(Token = "0x4000494")]
		Direction = 1,
		[Token(Token = "0x4000495")]
		Length = 2,
		[Token(Token = "0x4000496")]
		Connections = 4,
		[Token(Token = "0x4000497")]
		Combine = 8
	}
	[Token(Token = "0x200010C")]
	public enum CurvyAdvBezierModeEnum
	{
		[Token(Token = "0x4000499")]
		None = 0,
		[Token(Token = "0x400049A")]
		Direction = 1,
		[Token(Token = "0x400049B")]
		Length = 2,
		[Token(Token = "0x400049C")]
		Combine = 8
	}
	[Token(Token = "0x200010D")]
	public enum CurvyInterpolation
	{
		[Token(Token = "0x400049E")]
		Linear,
		[Token(Token = "0x400049F")]
		CatmullRom,
		[Token(Token = "0x40004A0")]
		TCB,
		[Token(Token = "0x40004A1")]
		Bezier
	}
	[Token(Token = "0x200010E")]
	public enum CurvyClamping
	{
		[Token(Token = "0x40004A3")]
		Clamp,
		[Token(Token = "0x40004A4")]
		Loop,
		[Token(Token = "0x40004A5")]
		PingPong
	}
	[Token(Token = "0x200010F")]
	public enum CurvyOrientation
	{
		[Token(Token = "0x40004A7")]
		None,
		[Token(Token = "0x40004A8")]
		Dynamic,
		[Token(Token = "0x40004A9")]
		Static
	}
	[Token(Token = "0x2000110")]
	public enum CurvyOrientationSwirl
	{
		[Token(Token = "0x40004AB")]
		None,
		[Token(Token = "0x40004AC")]
		Segment,
		[Token(Token = "0x40004AD")]
		AnchorGroup,
		[Token(Token = "0x40004AE")]
		AnchorGroupAbs
	}
	[Token(Token = "0x2000111")]
	[Flags]
	public enum CurvySplineGizmos
	{
		[Token(Token = "0x40004B0")]
		None = 0,
		[Token(Token = "0x40004B1")]
		Curve = 2,
		[Token(Token = "0x40004B2")]
		Approximation = 4,
		[Token(Token = "0x40004B3")]
		Tangents = 8,
		[Token(Token = "0x40004B4")]
		Orientation = 0x10,
		[Token(Token = "0x40004B5")]
		Labels = 0x20,
		[Token(Token = "0x40004B6")]
		Metadata = 0x40,
		[Token(Token = "0x40004B7")]
		Bounds = 0x80,
		[Token(Token = "0x40004B8")]
		CurveBox = 0x100,
		[Token(Token = "0x40004B9")]
		CurveName = 0x200,
		[Token(Token = "0x40004BA")]
		All = 0xFFFF
	}
	[Token(Token = "0x2000112")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9C3A8C", Offset = "0x9C3A8C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3A8C", Offset = "0x9C3A8C")]
	public class CurvyConnection : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Serializable]
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3AFC", Offset = "0x9C3AFC")]
		private sealed class <>c
		{
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<CurvySplineSegment> <>9__24_0;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Predicate<CurvySplineSegment> <>9__25_0;

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1E07D6C", Offset = "0x1E07D6C", VA = "0x1E07D6C")]
			public <>c()
			{
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1E07D74", Offset = "0x1E07D74", VA = "0x1E07D74")]
			internal bool <OnBeforeSerialize>b__24_0(CurvySplineSegment cp)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1E07D80", Offset = "0x1E07D80", VA = "0x1E07D80")]
			internal bool <OnAfterDeserialize>b__25_0(CurvySplineSegment cp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Hide]
		[SerializeField]
		private List<CurvySplineSegment> m_ControlPoints;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Couple<Vector3, Quaternion> processedConnectionCoordinates;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<CurvySplineSegment, Couple<Vector3, Quaternion>> processedControlPointsCoordinates;

		[Token(Token = "0x17000130")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x16F9118", Offset = "0x16F9118", VA = "0x16F9118")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000131")]
		public int Count
		{
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x16F9190", Offset = "0x16F9190", VA = "0x16F9190")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000132")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x16F91DC", Offset = "0x16F91DC", VA = "0x16F91DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x16F9250", Offset = "0x16F9250", VA = "0x16F9250")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x16F9498", Offset = "0x16F9498", VA = "0x16F9498")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x16F949C", Offset = "0x16F949C", VA = "0x16F949C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x16F9818", Offset = "0x16F9818", VA = "0x16F9818")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x16F9850", Offset = "0x16F9850", VA = "0x16F9850")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x16F9888", Offset = "0x16F9888", VA = "0x16F9888")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x16F99E8", Offset = "0x16F99E8", VA = "0x16F99E8")]
		public static CurvyConnection Create(params CurvySplineSegment[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x16F9B5C", Offset = "0x16F9B5C", VA = "0x16F9B5C")]
		public void AddControlPoints(params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x16F9D68", Offset = "0x16F9D68", VA = "0x16F9D68")]
		public void AutoSetFollowUp()
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x16FA004", Offset = "0x16FA004", VA = "0x16FA004")]
		public void RemoveControlPoint(CurvySplineSegment controlPoint, bool destroySelfIfEmpty = true)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x16FA0E0", Offset = "0x16FA0E0", VA = "0x16FA0E0")]
		public void Delete()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x16FA170", Offset = "0x16FA170", VA = "0x16FA170")]
		public List<CurvySplineSegment> OtherControlPoints(CurvySplineSegment source)
		{
			return null;
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x16FA220", Offset = "0x16FA220", VA = "0x16FA220")]
		public void SetSynchronisationPositionAndRotation(Vector3 referencePosition, Quaternion referenceRotation)
		{
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x16F94D4", Offset = "0x16F94D4", VA = "0x16F94D4")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x16FA56C", Offset = "0x16FA56C", VA = "0x16FA56C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x16FA698", Offset = "0x16FA698", VA = "0x16FA698", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x16FA7C4", Offset = "0x16FA7C4", VA = "0x16FA7C4")]
		public CurvyConnection()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class CurvyEventArgs : EventArgs
	{
		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly object Data;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x16FC7D0", Offset = "0x16FC7D0", VA = "0x16FC7D0")]
		public CurvyEventArgs(MonoBehaviour sender, object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000115")]
	public class CurvySplineEvent : UnityEventEx<CurvySplineEventArgs>
	{
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x2500208", Offset = "0x2500208", VA = "0x2500208")]
		public CurvySplineEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000116")]
	public class CurvyControlPointEvent : UnityEventEx<CurvyControlPointEventArgs>
	{
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x16FA894", Offset = "0x16FA894", VA = "0x16FA894")]
		public CurvyControlPointEvent()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class CurvyControlPointEventArgs : CurvySplineEventArgs
	{
		[Token(Token = "0x2000118")]
		public enum ModeEnum
		{
			[Token(Token = "0x40004C7")]
			None,
			[Token(Token = "0x40004C8")]
			AddBefore,
			[Token(Token = "0x40004C9")]
			AddAfter,
			[Token(Token = "0x40004CA")]
			Delete
		}

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly ModeEnum Mode;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly CurvySplineSegment ControlPoint;

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x16FA8E0", Offset = "0x16FA8E0", VA = "0x16FA8E0")]
		public CurvyControlPointEventArgs(MonoBehaviour sender, CurvySpline spline, CurvySplineSegment cp, ModeEnum mode = ModeEnum.None, [Optional] object data)
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class CurvySplineEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvySpline Spline;

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x2500254", Offset = "0x2500254", VA = "0x2500254")]
		public CurvySplineEventArgs(MonoBehaviour sender, CurvySpline spline, [Optional] object data)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200011A")]
	public class CurvyCGEvent : UnityEventEx<CurvyCGEventArgs>
	{
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x16F8F80", Offset = "0x16F8F80", VA = "0x16F8F80")]
		public CurvyCGEvent()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class CurvyCGEventArgs : EventArgs
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly MonoBehaviour Sender;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly CurvyGenerator Generator;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CGModule Module;

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x16F8FCC", Offset = "0x16F8FCC", VA = "0x16F8FCC")]
		public CurvyCGEventArgs(CGModule module)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x16F9074", Offset = "0x16F9074", VA = "0x16F9074")]
		public CurvyCGEventArgs(CurvyGenerator generator, CGModule module)
		{
		}
	}
	[Token(Token = "0x200011C")]
	public static class CurvyGizmoHelper
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Matrix4x4 Matrix;

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x170011C", Offset = "0x170011C", VA = "0x170011C")]
		public static void SegmentCurveGizmo(CurvySplineSegment seg, Color col, float stepSize = 0.05f)
		{
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x170034C", Offset = "0x170034C", VA = "0x170034C")]
		public static void SegmentApproximationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x170055C", Offset = "0x170055C", VA = "0x170055C")]
		public static void SegmentOrientationAnchorGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1700798", Offset = "0x1700798", VA = "0x1700798")]
		public static void SegmentOrientationGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1700A0C", Offset = "0x1700A0C", VA = "0x1700A0C")]
		public static void SegmentTangentGizmo(CurvySplineSegment seg, Color col)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1700C48", Offset = "0x1700C48", VA = "0x1700C48")]
		public static void DebugPoint(Vector3 position, Color color, float scale = 1f, float duration = 0f, bool depthTest = true)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1700EB8", Offset = "0x1700EB8", VA = "0x1700EB8")]
		public static void ControlPointGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x170127C", Offset = "0x170127C", VA = "0x170127C")]
		public static void ControlPointBoxGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1701684", Offset = "0x1701684", VA = "0x1701684")]
		public static void ControlPointNameGizmo(CurvySplineSegment cp, bool selected, Color col)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x17016A8", Offset = "0x17016A8", VA = "0x17016A8")]
		public static void ConnectionGizmo(CurvySplineSegment cp)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x170193C", Offset = "0x170193C", VA = "0x170193C")]
		public static void BoundsGizmo(CurvySplineSegment cp, Color col)
		{
		}
	}
	[Token(Token = "0x200011D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3B0C", Offset = "0x9C3B0C")]
	[ExecuteInEditMode]
	public class CurvyGlobalManager : DTSingleton<CurvyGlobalManager>, IDTSingleton
	{
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool HideManager;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float SceneViewResolution;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Color DefaultGizmoColor;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Color DefaultGizmoSelectionColor;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static CurvyInterpolation DefaultInterpolation;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public static float GizmoControlPointSize;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static float GizmoOrientationLength;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public static Color GizmoOrientationColor;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public static int SplineLayer;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static CurvySplineGizmos Gizmos;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private PoolManager mPoolManager;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ComponentPool mControlPointPool;

		[Token(Token = "0x17000133")]
		public static bool ShowCurveGizmo
		{
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1701B4C", Offset = "0x1701B4C", VA = "0x1701B4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x1701BB4", Offset = "0x1701BB4", VA = "0x1701BB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000134")]
		public static bool ShowCurveBoxGizmo
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x1701C4C", Offset = "0x1701C4C", VA = "0x1701C4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x1701CB4", Offset = "0x1701CB4", VA = "0x1701CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000135")]
		public static bool ShowCurveNameGizmo
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x1701D4C", Offset = "0x1701D4C", VA = "0x1701D4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1701DB4", Offset = "0x1701DB4", VA = "0x1701DB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000136")]
		public static bool ShowApproximationGizmo
		{
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1701E4C", Offset = "0x1701E4C", VA = "0x1701E4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1701EB4", Offset = "0x1701EB4", VA = "0x1701EB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000137")]
		public static bool ShowTangentsGizmo
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x1701F4C", Offset = "0x1701F4C", VA = "0x1701F4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x1701FB4", Offset = "0x1701FB4", VA = "0x1701FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000138")]
		public static bool ShowOrientationGizmo
		{
			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x170204C", Offset = "0x170204C", VA = "0x170204C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x17020B4", Offset = "0x17020B4", VA = "0x17020B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000139")]
		public static bool ShowLabelsGizmo
		{
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x170214C", Offset = "0x170214C", VA = "0x170214C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x17021B4", Offset = "0x17021B4", VA = "0x17021B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013A")]
		public static bool ShowMetadataGizmo
		{
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x170224C", Offset = "0x170224C", VA = "0x170224C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E3")]
			[Address(RVA = "0x17022B4", Offset = "0x17022B4", VA = "0x17022B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013B")]
		public static bool ShowBoundsGizmo
		{
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x170234C", Offset = "0x170234C", VA = "0x170234C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006E5")]
			[Address(RVA = "0x17023B4", Offset = "0x17023B4", VA = "0x17023B4")]
			set
			{
			}
		}

		[Token(Token = "0x1700013C")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x60006E6")]
			[Address(RVA = "0x170244C", Offset = "0x170244C", VA = "0x170244C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013D")]
		public ComponentPool ControlPointPool
		{
			[Token(Token = "0x60006E7")]
			[Address(RVA = "0x1702500", Offset = "0x1702500", VA = "0x1702500")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		public CurvyConnection[] Connections
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0x1702508", Offset = "0x1702508", VA = "0x1702508")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1702554", Offset = "0x1702554", VA = "0x1702554")]
		public CurvyConnection[] GetContainingConnections(params CurvySpline[] splines)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1702DF8", Offset = "0x1702DF8", VA = "0x1702DF8", Slot = "4")]
		public override void Awake()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1702F74", Offset = "0x1702F74", VA = "0x1702F74")]
		private void Start()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1703004", Offset = "0x1703004", VA = "0x1703004")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9D240C", Offset = "0x9D240C")]
		private static void LoadRuntimeSettings()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1703354", Offset = "0x1703354", VA = "0x1703354")]
		public static void SaveRuntimeSettings()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x17035F4", Offset = "0x17035F4", VA = "0x17035F4", Slot = "7")]
		public new void MergeDoubleLoaded(IDTSingleton newInstance)
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x17036F4", Offset = "0x17036F4", VA = "0x17036F4")]
		public CurvyGlobalManager()
		{
		}
	}
	[Token(Token = "0x200011E")]
	[ExecuteInEditMode]
	public class CurvyMetadataBase : MonoBehaviour
	{
		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CurvySplineSegment mCP;

		[Token(Token = "0x1700013F")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1703FB8", Offset = "0x1703FB8", VA = "0x1703FB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1703FC0", Offset = "0x1703FC0", VA = "0x1703FC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1704048", Offset = "0x1704048", VA = "0x1704048", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60006F4")]
		public T GetPreviousData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		public T GetNextData<T>(bool autoCreate = true, bool segmentsOnly = true, bool useFollowUp = false) where T : MonoBehaviour, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x17040A4", Offset = "0x17040A4", VA = "0x17040A4")]
		protected void NotifyModification()
		{
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1704144", Offset = "0x1704144", VA = "0x1704144")]
		public CurvyMetadataBase()
		{
		}
	}
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C3B8C", Offset = "0x9C3B8C")]
	public class CGResourceManagerAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly string ResourceName;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ReadOnly;

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1C34B7C", Offset = "0x1C34B7C", VA = "0x1C34B7C")]
		public CGResourceManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x2000120")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C3BC4", Offset = "0x9C3BC4")]
	public sealed class CGResourceCollectionManagerAttribute : CGResourceManagerAttribute
	{
		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		public bool ShowCount;

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1C34B54", Offset = "0x1C34B54", VA = "0x1C34B54")]
		public CGResourceCollectionManagerAttribute(string resourceName)
		{
		}
	}
	[Token(Token = "0x2000121")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C3BFC", Offset = "0x9C3BFC")]
	public sealed class CGDataReferenceSelectorAttribute : DTPropertyAttribute
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly Type DataType;

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1721320", Offset = "0x1721320", VA = "0x1721320")]
		public CGDataReferenceSelectorAttribute(Type dataType)
		{
		}
	}
	[Token(Token = "0x2000122")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3C34", Offset = "0x9C3C34")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3C34", Offset = "0x9C3C34")]
	public class CurvyShape : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C76B4", Offset = "0x9C76B4")]
		private CurvyPlane m_Plane;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[HideInInspector]
		private bool m_Persistent;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<CurvyShapeInfo, Type> mShapeDefs;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CurvySpline mSpline;

		[NonSerialized]
		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Dirty;

		[Token(Token = "0x17000141")]
		public CurvyPlane Plane
		{
			[Token(Token = "0x60006FB")]
			[Address(RVA = "0x170414C", Offset = "0x170414C", VA = "0x170414C")]
			get
			{
				return default(CurvyPlane);
			}
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x1704154", Offset = "0x1704154", VA = "0x1704154")]
			set
			{
			}
		}

		[Token(Token = "0x17000142")]
		public bool Persistent
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0x1704170", Offset = "0x1704170", VA = "0x1704170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006FE")]
			[Address(RVA = "0x1704178", Offset = "0x1704178", VA = "0x1704178")]
			set
			{
			}
		}

		[Token(Token = "0x17000143")]
		public CurvySpline Spline
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x17041AC", Offset = "0x17041AC", VA = "0x17041AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		public static Dictionary<CurvyShapeInfo, Type> ShapeDefinitions
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1705828", Offset = "0x1705828", VA = "0x1705828")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x170425C", Offset = "0x170425C", VA = "0x170425C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x170438C", Offset = "0x170438C", VA = "0x170438C", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x17043A4", Offset = "0x17043A4", VA = "0x17043A4")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x170429C", Offset = "0x170429C", VA = "0x170429C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x17044A0", Offset = "0x17044A0", VA = "0x17044A0")]
		public CurvyShape Replace(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1704814", Offset = "0x1704814", VA = "0x1704814")]
		protected void PrepareSpline(CurvyInterpolation interpolation, CurvyOrientation orientation = CurvyOrientation.Dynamic, int cachedensity = 50, bool closed = true)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1704AB0", Offset = "0x1704AB0", VA = "0x1704AB0")]
		protected void SetPosition(int no, Vector3 position)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1704B54", Offset = "0x1704B54", VA = "0x1704B54")]
		protected void SetRotation(int no, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1704C00", Offset = "0x1704C00", VA = "0x1704C00")]
		protected void SetBezierHandles(int no, float distanceFrag)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1704C08", Offset = "0x1704C08", VA = "0x1704C08")]
		protected void SetBezierHandles(int no, float inDistanceFrag, float outDistanceFrag)
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1704F10", Offset = "0x1704F10", VA = "0x1704F10")]
		protected void SetBezierHandles(int no, Vector3 i, Vector3 o, Space space = Space.World)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1704E6C", Offset = "0x1704E6C", VA = "0x1704E6C")]
		public static void SetBezierHandles(float distanceFrag, bool setIn, bool setOut, params CurvySplineSegment[] controlPoints)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1705068", Offset = "0x1705068", VA = "0x1705068")]
		protected void SetCGHardEdges(params int[] controlPoints)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x17051D8", Offset = "0x17051D8", VA = "0x17051D8", Slot = "6")]
		protected virtual void ApplyShape()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x17051DC", Offset = "0x17051DC", VA = "0x17051DC")]
		protected void PrepareControlPoints(int count)
		{
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1705978", Offset = "0x1705978", VA = "0x1705978")]
		public static List<string> GetShapesMenuNames(bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1705B68", Offset = "0x1705B68", VA = "0x1705B68")]
		public static List<string> GetShapesMenuNames(Type currentShapeType, out int currentIndex, bool only2D = false)
		{
			return null;
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1705E4C", Offset = "0x1705E4C", VA = "0x1705E4C")]
		public static string GetShapeName(Type shapeType)
		{
			return null;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1704618", Offset = "0x1704618", VA = "0x1704618")]
		public static Type GetShapeType(string menuName)
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1704408", Offset = "0x1704408", VA = "0x1704408")]
		private void applyPlane()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1706020", Offset = "0x1706020", VA = "0x1706020")]
		private void applyRotation(Quaternion q)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x17062CC", Offset = "0x17062CC", VA = "0x17062CC")]
		public CurvyShape()
		{
		}
	}
	[Token(Token = "0x2000123")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C3CC8", Offset = "0x9C3CC8")]
	public sealed class CurvyShapeInfo : Attribute
	{
		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string Name;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly bool Is2D;

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x17063D4", Offset = "0x17063D4", VA = "0x17063D4")]
		public CurvyShapeInfo(string name, bool is2D = true)
		{
		}
	}
	[Token(Token = "0x2000124")]
	public class CurvyShape2D : CurvyShape
	{
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1706368", Offset = "0x1706368", VA = "0x1706368")]
		public CurvyShape2D()
		{
		}
	}
	[Token(Token = "0x2000125")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3D00", Offset = "0x9C3D00")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9C3D00", Offset = "0x9C3D00")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C3D00", Offset = "0x9C3D00")]
	public class CurvySpline : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3D98", Offset = "0x9C3D98")]
		private sealed class <>c__DisplayClass184_0
		{
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1E07FD0", Offset = "0x1E07FD0", VA = "0x1E07FD0")]
			public <>c__DisplayClass184_0()
			{
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1E07FD8", Offset = "0x1E07FD8", VA = "0x1E07FD8")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C3DA8", Offset = "0x9C3DA8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<CurvySplineSegment> <>9__289_0;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Action<CurvySplineSegment> <>9__300_0;

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x1E07F58", Offset = "0x1E07F58", VA = "0x1E07F58")]
			public <>c()
			{
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x1E07F60", Offset = "0x1E07F60", VA = "0x1E07F60")]
			internal int <SortControlPointsByName>b__289_0(CurvySplineSegment x, CurvySplineSegment y)
			{
				return default(int);
			}

			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x1E07FB4", Offset = "0x1E07FB4", VA = "0x1E07FB4")]
			internal void <ProcessDirtyControlPoints>b__300_0(CurvySplineSegment controlPoint)
			{
			}
		}

		[Token(Token = "0x40004E8")]
		public const string VERSION = "5.0.0";

		[Token(Token = "0x40004E9")]
		public const string APIVERSION = "500";

		[Token(Token = "0x40004EA")]
		public const string WEBROOT = "https://curvyeditor.com/";

		[Token(Token = "0x40004EB")]
		public const string DOCLINK = "https://curvyeditor.com/doclink/";

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private List<CurvySplineSegment> ControlPoints;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public bool ShowGizmos;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C7794", Offset = "0x9C7794")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7794", Offset = "0x9C7794")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7794", Offset = "0x9C7794")]
		[SerializeField]
		private CurvyInterpolation m_Interpolation;

		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9C7850", Offset = "0x9C7850")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7850", Offset = "0x9C7850")]
		[SerializeField]
		private bool m_RestrictTo2D;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C78C4", Offset = "0x9C78C4")]
		private bool m_Closed;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C7910", Offset = "0x9C7910")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7910", Offset = "0x9C7910")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7910", Offset = "0x9C7910")]
		private bool m_AutoEndTangents;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C79AC", Offset = "0x9C79AC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C79AC", Offset = "0x9C79AC")]
		private CurvyOrientation m_Orientation;

		[Token(Token = "0x40004F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9C7A1C", Offset = "0x9C7A1C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9C7A1C", Offset = "0x9C7A1C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C7A1C", Offset = "0x9C7A1C")]
		private float m_AutoHandleDistance;

		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C7B4C", Offset = "0x9C7B4C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9C7B4C", Offset = "0x9C7B4C")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x9C7B4C", Offset = "0x9C7B4C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7B4C", Offset = "0x9C7B4C")]
		private float m_Tension;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7C98", Offset = "0x9C7C98")]
		private float m_Continuity;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7CE4", Offset = "0x9C7CE4")]
		private float m_Bias;

		[Token(Token = "0x40004F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C7D30", Offset = "0x9C7D30")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9C7D30", Offset = "0x9C7D30")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C7D30", Offset = "0x9C7D30")]
		[SerializeField]
		private Color m_GizmoColor;

		[Token(Token = "0x40004F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C7E10", Offset = "0x9C7E10")]
		[SerializeField]
		private Color m_GizmoSelectionColor;

		[Token(Token = "0x40004F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7E78", Offset = "0x9C7E78")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9C7E78", Offset = "0x9C7E78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C7E78", Offset = "0x9C7E78")]
		[SerializeField]
		private int m_CacheDensity;

		[Token(Token = "0x40004FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7F34", Offset = "0x9C7F34")]
		[SerializeField]
		private float m_MaxPointsPerUnit;

		[Token(Token = "0x40004FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7F80", Offset = "0x9C7F80")]
		[SerializeField]
		private bool m_UsePooling;

		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C7FCC", Offset = "0x9C7FCC")]
		[SerializeField]
		private bool m_UseThreading;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C8018", Offset = "0x9C8018")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8018", Offset = "0x9C8018")]
		private bool m_CheckTransform;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[SerializeField]
		private CurvyUpdateMethod m_UpdateIn;

		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x9C8098", Offset = "0x9C8098")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C8098", Offset = "0x9C8098")]
		[SerializeField]
		private CurvySplineEvent m_OnRefresh;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x9C8120", Offset = "0x9C8120")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C8120", Offset = "0x9C8120")]
		private CurvySplineEvent m_OnAfterControlPointChanges;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x9C818C", Offset = "0x9C818C")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C818C", Offset = "0x9C818C")]
		private CurvyControlPointEvent m_OnBeforeControlPointAdd;

		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x9C81F8", Offset = "0x9C81F8")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C81F8", Offset = "0x9C81F8")]
		private CurvyControlPointEvent m_OnAfterControlPointAdd;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[AttributeAttribute(Name = "SortOrderAttribute", RVA = "0x9C8264", Offset = "0x9C8264")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C8264", Offset = "0x9C8264")]
		private CurvyControlPointEvent m_OnBeforeControlPointDelete;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mIsInitialized;

		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool isStarted;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool sendOnRefreshEventNextUpdate;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly object controlPointsRelationshipCacheLock;

		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<CurvySplineSegment> mSegments;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private ReadOnlyCollection<CurvySplineSegment> readOnlyControlPoints;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int mCacheSize;

		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Bounds? mBounds;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private bool mDirtyCurve;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE5")]
		private bool mDirtyOrientation;

		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private HashSet<CurvySplineSegment> dirtyControlPointsMinimalSet;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<CurvySplineSegment> dirtyCpsExtendedList;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private bool allControlPointsAreDirty;

		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private ThreadPoolWorker<CurvySplineSegment> mThreadWorker;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly CurvySplineEventArgs defaultSplineEventArgs;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private readonly CurvyControlPointEventArgs defaultAddAfterEventArgs;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private readonly CurvyControlPointEventArgs defaultDeleteEventArgs;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private CurvySplineSegment _lastDistToSeg;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private readonly Action<CurvySplineSegment> refreshCurveAction;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 lastProcessedPosition;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Quaternion lastProcessedRotation;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private Vector3 lastProcessedScale;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool globalCoordinatesChangedThisFrame;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x159")]
		private bool isCpsRelationshipCacheValid;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private CurvySplineSegment firstSegment;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private CurvySplineSegment lastSegment;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private CurvySplineSegment firstVisibleControlPoint;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private CurvySplineSegment lastVisibleControlPoint;

		[Token(Token = "0x17000145")]
		public CurvyInterpolation Interpolation
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1706880", Offset = "0x1706880", VA = "0x1706880")]
			get
			{
				return default(CurvyInterpolation);
			}
			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1704960", Offset = "0x1704960", VA = "0x1704960")]
			set
			{
			}
		}

		[Token(Token = "0x17000146")]
		public bool RestrictTo2D
		{
			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1706CA4", Offset = "0x1706CA4", VA = "0x1706CA4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600071E")]
			[Address(RVA = "0x1704A84", Offset = "0x1704A84", VA = "0x1704A84")]
			set
			{
			}
		}

		[Token(Token = "0x17000147")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1706CAC", Offset = "0x1706CAC", VA = "0x1706CAC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000720")]
			[Address(RVA = "0x1706CB4", Offset = "0x1706CB4", VA = "0x1706CB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000148")]
		public bool Closed
		{
			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1706D00", Offset = "0x1706D00", VA = "0x1706D00")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1704A2C", Offset = "0x1704A2C", VA = "0x1704A2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000149")]
		public bool AutoEndTangents
		{
			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1706D08", Offset = "0x1706D08", VA = "0x1706D08")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1706C24", Offset = "0x1706C24", VA = "0x1706C24")]
			set
			{
			}
		}

		[Token(Token = "0x1700014A")]
		public CurvyOrientation Orientation
		{
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1706D34", Offset = "0x1706D34", VA = "0x1706D34")]
			get
			{
				return default(CurvyOrientation);
			}
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x17049AC", Offset = "0x17049AC", VA = "0x17049AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014B")]
		public CurvyUpdateMethod UpdateIn
		{
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1706D3C", Offset = "0x1706D3C", VA = "0x1706D3C")]
			get
			{
				return default(CurvyUpdateMethod);
			}
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1706D44", Offset = "0x1706D44", VA = "0x1706D44")]
			set
			{
			}
		}

		[Token(Token = "0x1700014C")]
		public Color GizmoColor
		{
			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1706D58", Offset = "0x1706D58", VA = "0x1706D58")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1706D64", Offset = "0x1706D64", VA = "0x1706D64")]
			set
			{
			}
		}

		[Token(Token = "0x1700014D")]
		public Color GizmoSelectionColor
		{
			[Token(Token = "0x600072B")]
			[Address(RVA = "0x1706DD0", Offset = "0x1706DD0", VA = "0x1706DD0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600072C")]
			[Address(RVA = "0x1706DDC", Offset = "0x1706DDC", VA = "0x1706DDC")]
			set
			{
			}
		}

		[Token(Token = "0x1700014E")]
		public int CacheDensity
		{
			[Token(Token = "0x600072D")]
			[Address(RVA = "0x1706E48", Offset = "0x1706E48", VA = "0x1706E48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600072E")]
			[Address(RVA = "0x17049D0", Offset = "0x17049D0", VA = "0x17049D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700014F")]
		public float MaxPointsPerUnit
		{
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x1706E50", Offset = "0x1706E50", VA = "0x1706E50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x1706E58", Offset = "0x1706E58", VA = "0x1706E58")]
			set
			{
			}
		}

		[Token(Token = "0x17000150")]
		public bool UsePooling
		{
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x1706EB4", Offset = "0x1706EB4", VA = "0x1706EB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1706EBC", Offset = "0x1706EBC", VA = "0x1706EBC")]
			set
			{
			}
		}

		[Token(Token = "0x17000151")]
		public bool UseThreading
		{
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1706EDC", Offset = "0x1706EDC", VA = "0x1706EDC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1706EE4", Offset = "0x1706EE4", VA = "0x1706EE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000152")]
		public bool CheckTransform
		{
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1706F04", Offset = "0x1706F04", VA = "0x1706F04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1706F0C", Offset = "0x1706F0C", VA = "0x1706F0C")]
			set
			{
			}
		}

		[Token(Token = "0x17000153")]
		public float Tension
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1706F38", Offset = "0x1706F38", VA = "0x1706F38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1706F40", Offset = "0x1706F40", VA = "0x1706F40")]
			set
			{
			}
		}

		[Token(Token = "0x17000154")]
		public float Continuity
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1706F60", Offset = "0x1706F60", VA = "0x1706F60")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1706F68", Offset = "0x1706F68", VA = "0x1706F68")]
			set
			{
			}
		}

		[Token(Token = "0x17000155")]
		public float Bias
		{
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1706F88", Offset = "0x1706F88", VA = "0x1706F88")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1706F90", Offset = "0x1706F90", VA = "0x1706F90")]
			set
			{
			}
		}

		[Token(Token = "0x17000156")]
		public bool IsInitialized
		{
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1706FB0", Offset = "0x1706FB0", VA = "0x1706FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000157")]
		public Bounds Bounds
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x1706FB8", Offset = "0x1706FB8", VA = "0x1706FB8")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000158")]
		public int Count
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x17071D8", Offset = "0x17071D8", VA = "0x17071D8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000159")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1704E20", Offset = "0x1704E20", VA = "0x1704E20")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015A")]
		public int CacheSize
		{
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1707358", Offset = "0x1707358", VA = "0x1707358")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700015B")]
		public float Length
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1707438", Offset = "0x1707438", VA = "0x1707438")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700015C")]
		public bool Dirty
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x17072C0", Offset = "0x17072C0", VA = "0x17072C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700015D")]
		public CurvySplineSegment Item
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1707238", Offset = "0x1707238", VA = "0x1707238")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		public ReadOnlyCollection<CurvySplineSegment> ControlPointsList
		{
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1702D80", Offset = "0x1702D80", VA = "0x1702D80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		[CanBeNull]
		public CurvySplineSegment FirstVisibleControlPoint
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x1707534", Offset = "0x1707534", VA = "0x1707534")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		[CanBeNull]
		public CurvySplineSegment LastVisibleControlPoint
		{
			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1705604", Offset = "0x1705604", VA = "0x1705604")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000161")]
		public CurvySplineSegment FirstSegment
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1707B90", Offset = "0x1707B90", VA = "0x1707B90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		public CurvySplineSegment LastSegment
		{
			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1707BC4", Offset = "0x1707BC4", VA = "0x1707BC4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000163")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2F3C", Offset = "0x9D2F3C")]
		public bool IsClosed
		{
			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1707BF8", Offset = "0x1707BF8", VA = "0x1707BF8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000164")]
		public CurvySpline NextSpline
		{
			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1707C00", Offset = "0x1707C00", VA = "0x1707C00")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000165")]
		public CurvySpline PreviousSpline
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1707CD4", Offset = "0x1707CD4", VA = "0x1707CD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		public bool GlobalCoordinatesChangedThisFrame
		{
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1707DA8", Offset = "0x1707DA8", VA = "0x1707DA8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000167")]
		public CurvySplineEvent OnRefresh
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1707DB0", Offset = "0x1707DB0", VA = "0x1707DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1707DB8", Offset = "0x1707DB8", VA = "0x1707DB8")]
			set
			{
			}
		}

		[Token(Token = "0x17000168")]
		public CurvySplineEvent OnAfterControlPointChanges
		{
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1707DD0", Offset = "0x1707DD0", VA = "0x1707DD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1707DD8", Offset = "0x1707DD8", VA = "0x1707DD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000169")]
		public CurvyControlPointEvent OnBeforeControlPointAdd
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1707DF0", Offset = "0x1707DF0", VA = "0x1707DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1707DF8", Offset = "0x1707DF8", VA = "0x1707DF8")]
			set
			{
			}
		}

		[Token(Token = "0x1700016A")]
		public CurvyControlPointEvent OnAfterControlPointAdd
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1707E10", Offset = "0x1707E10", VA = "0x1707E10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1707E18", Offset = "0x1707E18", VA = "0x1707E18")]
			set
			{
			}
		}

		[Token(Token = "0x1700016B")]
		public CurvyControlPointEvent OnBeforeControlPointDelete
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1707E30", Offset = "0x1707E30", VA = "0x1707E30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1707E38", Offset = "0x1707E38", VA = "0x1707E38")]
			set
			{
			}
		}

		[Token(Token = "0x1700016C")]
		private List<CurvySplineSegment> controlPoints
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x1710FD4", Offset = "0x1710FD4", VA = "0x1710FD4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016D")]
		private List<CurvySplineSegment> Segments
		{
			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x1707324", Offset = "0x1707324", VA = "0x1707324")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1706420", Offset = "0x1706420", VA = "0x1706420")]
		public CurvySpline()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1707E50", Offset = "0x1707E50", VA = "0x1707E50")]
		public static CurvySpline Create()
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1708068", Offset = "0x1708068", VA = "0x1708068")]
		public static CurvySpline Create(CurvySpline takeOptionsFrom)
		{
			return null;
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x17081D8", Offset = "0x17081D8", VA = "0x17081D8")]
		public static int CalculateCacheSize(int density, float splineLength, float maxPointsPerUnit)
		{
			return default(int);
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x170820C", Offset = "0x170820C", VA = "0x170820C")]
		public static float CalculateSamplingPointsPerUnit(int density, float maxPointsPerUnit)
		{
			return default(float);
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x17082D0", Offset = "0x17082D0", VA = "0x17082D0")]
		public static Vector3 Bezier(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x17083C0", Offset = "0x17083C0", VA = "0x17083C0")]
		public static float BezierTangent(float T0, float P0, float P1, float T1, float t)
		{
			return default(float);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1708410", Offset = "0x1708410", VA = "0x1708410")]
		public static Vector3 BezierTangent(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x17084DC", Offset = "0x17084DC", VA = "0x17084DC")]
		public static Vector3 CatmullRom(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x17085FC", Offset = "0x17085FC", VA = "0x17085FC")]
		public static Vector3 TCB(Vector3 T0, Vector3 P0, Vector3 P1, Vector3 T1, float f, float FT0, float FC0, float FB0, float FT1, float FC1, float FB1)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1708814", Offset = "0x1708814", VA = "0x1708814")]
		public Vector3 Interpolate(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x170881C", Offset = "0x170881C", VA = "0x170881C")]
		public Vector3 Interpolate(float tf, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x17088F8", Offset = "0x17088F8", VA = "0x17088F8")]
		public Vector3 InterpolateFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000764")]
		public T GetMetadata<T>(float tf) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x17089B4", Offset = "0x17089B4", VA = "0x17089B4")]
		public UnityEngine.Component GetMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x6000766")]
		public U InterpolateMetadata<T, U>(float tf) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x1708A84", Offset = "0x1708A84", VA = "0x1708A84")]
		public object InterpolateMetadata(Type type, float tf)
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1708B54", Offset = "0x1708B54", VA = "0x1708B54")]
		public Vector3 InterpolateScale(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1708C10", Offset = "0x1708C10", VA = "0x1708C10")]
		public Vector3 GetOrientationUpFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1708CCC", Offset = "0x1708CCC", VA = "0x1708CCC")]
		public Quaternion GetOrientationFast(float tf, bool inverse = false)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x1708DA0", Offset = "0x1708DA0", VA = "0x1708DA0")]
		public Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1708E5C", Offset = "0x1708E5C", VA = "0x1708E5C")]
		public Vector3 GetTangent(float tf, Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x1708F40", Offset = "0x1708F40", VA = "0x1708F40")]
		public Vector3 GetTangentFast(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x1708FFC", Offset = "0x1708FFC", VA = "0x1708FFC")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D241C", Offset = "0x9D241C")]
		public Vector3 GetExtrusionPoint(float tf, float radius, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x17090F4", Offset = "0x17090F4", VA = "0x17090F4")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2454", Offset = "0x9D2454")]
		public Vector3 GetExtrusionPointFast(float tf, float radius, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x17091D8", Offset = "0x17091D8", VA = "0x17091D8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D248C", Offset = "0x9D248C")]
		public Vector3 GetRotatedUp(float tf, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x1709278", Offset = "0x1709278", VA = "0x1709278")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D24C4", Offset = "0x9D24C4")]
		public Vector3 GetRotatedUpFast(float tf, float angle)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1709318", Offset = "0x1709318", VA = "0x1709318")]
		public Vector3 GetTangentByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1709444", Offset = "0x1709444", VA = "0x1709444")]
		public Vector3 GetTangentByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x170946C", Offset = "0x170946C", VA = "0x170946C")]
		public Vector3 InterpolateByDistance(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1709498", Offset = "0x1709498", VA = "0x1709498")]
		public Vector3 InterpolateByDistanceFast(float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x17094C0", Offset = "0x17094C0", VA = "0x17094C0")]
		public float ExtrapolateDistanceToTF(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x17095B8", Offset = "0x17095B8", VA = "0x17095B8")]
		public float ExtrapolateDistanceToTFFast(float tf, float distance, float stepSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x17096A8", Offset = "0x17096A8", VA = "0x17096A8")]
		public float TFToDistance(float tf, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x17097A0", Offset = "0x17097A0", VA = "0x17097A0")]
		public CurvySplineSegment TFToSegment(float tf, out float localF, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1709948", Offset = "0x1709948", VA = "0x1709948")]
		public CurvySplineSegment TFToSegment(float tf, CurvyClamping clamping)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1709970", Offset = "0x1709970", VA = "0x1709970")]
		public CurvySplineSegment TFToSegment(float tf)
		{
			return null;
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x17088F0", Offset = "0x17088F0", VA = "0x17088F0")]
		public CurvySplineSegment TFToSegment(float tf, out float localF)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x1709998", Offset = "0x1709998", VA = "0x1709998")]
		public float SegmentToTF(CurvySplineSegment segment)
		{
			return default(float);
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x17099A0", Offset = "0x17099A0", VA = "0x17099A0")]
		public float SegmentToTF(CurvySplineSegment segment, float localF)
		{
			return default(float);
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x1709340", Offset = "0x1709340", VA = "0x1709340")]
		public float DistanceToTF(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x1709E38", Offset = "0x1709E38", VA = "0x1709E38")]
		public CurvySplineSegment DistanceToSegment(float distance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1709B9C", Offset = "0x1709B9C", VA = "0x1709B9C")]
		public CurvySplineSegment DistanceToSegment(float distance, out float localDistance, CurvyClamping clamping = CurvyClamping.Clamp)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1709F0C", Offset = "0x1709F0C", VA = "0x1709F0C")]
		public Vector3 Move(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1709F5C", Offset = "0x1709F5C", VA = "0x1709F5C")]
		public Vector3 MoveFast(ref float tf, ref int direction, float fDistance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1709FA8", Offset = "0x1709FA8", VA = "0x1709FA8")]
		public Vector3 MoveBy(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x1709FF8", Offset = "0x1709FF8", VA = "0x1709FF8")]
		public Vector3 MoveByFast(ref float tf, ref int direction, float distance, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x170A064", Offset = "0x170A064", VA = "0x170A064")]
		public Vector3 MoveByLengthFast(ref float tf, ref int direction, float distance, CurvyClamping clamping)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x170A134", Offset = "0x170A134", VA = "0x170A134")]
		public Vector3 MoveByAngle(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize = 0.002f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x170A364", Offset = "0x170A364", VA = "0x170A364")]
		public Vector3 MoveByAngleFast(ref float tf, ref int direction, float angle, CurvyClamping clamping, float stepSize)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x170A570", Offset = "0x170A570", VA = "0x170A570")]
		public float ClampDistance(float distance, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x170A5AC", Offset = "0x170A5AC", VA = "0x170A5AC")]
		public float ClampDistance(float distance, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x170A0F0", Offset = "0x170A0F0", VA = "0x170A0F0")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x170A600", Offset = "0x170A600", VA = "0x170A600")]
		public float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x170A65C", Offset = "0x170A65C", VA = "0x170A65C")]
		public CurvySplineSegment Add()
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x170A668", Offset = "0x170A668", VA = "0x170A668")]
		public CurvySplineSegment[] Add(params Vector3[] controlPoints)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x170AA38", Offset = "0x170AA38", VA = "0x170AA38")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x170AD10", Offset = "0x170AD10", VA = "0x170AD10")]
		public CurvySplineSegment InsertBefore(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1705420", Offset = "0x1705420", VA = "0x1705420")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x170A87C", Offset = "0x170A87C", VA = "0x170A87C")]
		public CurvySplineSegment InsertAfter(CurvySplineSegment controlPoint, Vector3 globalPosition, bool skipRefreshingAndEvents = false)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x170B2B4", Offset = "0x170B2B4", VA = "0x170B2B4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1705638", Offset = "0x1705638", VA = "0x1705638")]
		public void Delete(CurvySplineSegment controlPoint, bool skipRefreshingAndEvents = false)
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1703E04", Offset = "0x1703E04", VA = "0x1703E04")]
		public Vector3[] GetApproximation(Space space = Space.Self)
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x170B834", Offset = "0x170B834", VA = "0x170B834")]
		public Vector3[] GetApproximationT()
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x170B928", Offset = "0x170B928", VA = "0x170B928")]
		public Vector3[] GetApproximationUpVectors()
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x170BA1C", Offset = "0x170BA1C", VA = "0x170BA1C")]
		public float GetNearestPointTF(Vector3 localPosition)
		{
			return default(float);
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x170BA90", Offset = "0x170BA90", VA = "0x170BA90")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest)
		{
			return default(float);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x170BAC4", Offset = "0x170BAC4", VA = "0x170BAC4")]
		public float GetNearestPointTF(Vector3 localPosition, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x170BA5C", Offset = "0x170BA5C", VA = "0x170BA5C")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearest, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x170BB04", Offset = "0x170BB04", VA = "0x170BB04")]
		public float GetNearestPointTF(Vector3 localPosition, out Vector3 nearestPoint, [CanBeNull] out CurvySplineSegment nearestSegment, out float nearestSegmentF, int startSegmentIndex = 0, int stopSegmentIndex = -1)
		{
			return default(float);
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1704478", Offset = "0x1704478", VA = "0x1704478")]
		public void Refresh()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x170446C", Offset = "0x170446C", VA = "0x170446C")]
		public void SetDirtyAll()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x17069A0", Offset = "0x17069A0", VA = "0x17069A0")]
		public void SetDirtyAll(SplineDirtyingType dirtyingType, bool dirtyConnectedControlPoints)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x170CAE0", Offset = "0x170CAE0", VA = "0x170CAE0")]
		public void SetDirty(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x16FA514", Offset = "0x16FA514", VA = "0x16FA514")]
		public void SetDirtyPartial(CurvySplineSegment dirtyControlPoint, SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x170CFA0", Offset = "0x170CFA0", VA = "0x170CFA0")]
		public Vector3 ToWorldPosition(Vector3 localPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x170CFEC", Offset = "0x170CFEC", VA = "0x170CFEC")]
		public void SyncSplineFromHierarchy()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x170D26C", Offset = "0x170D26C", VA = "0x170D26C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D24FC", Offset = "0x9D24FC")]
		public Vector3[] GetPolygonByAngle(float angle, float minDistance)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x170D498", Offset = "0x170D498", VA = "0x170D498")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D2534", Offset = "0x9D2534")]
		public Vector3[] GetPolygon(float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x170DA70", Offset = "0x170DA70", VA = "0x170DA70")]
		public Vector3[] GetApproximationPoints(float fromTF, float toTF, bool includeEndPoint = true)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x170DE1C", Offset = "0x170DE1C", VA = "0x170DE1C")]
		public bool IsPlanar(out int ignoreAxis)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x170DE98", Offset = "0x170DE98", VA = "0x170DE98")]
		public bool IsPlanar(out bool xplanar, out bool yplanar, out bool zplanar)
		{
			return default(bool);
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x170E0BC", Offset = "0x170E0BC", VA = "0x170E0BC")]
		public bool IsPlanar(CurvyPlane plane)
		{
			return default(bool);
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x170E280", Offset = "0x170E280", VA = "0x170E280")]
		public void MakePlanar(CurvyPlane plane)
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x170E6BC", Offset = "0x170E6BC", VA = "0x170E6BC")]
		public void Subdivide([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x170ECBC", Offset = "0x170ECBC", VA = "0x170ECBC")]
		public void Simplify([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x170EFB4", Offset = "0x170EFB4", VA = "0x170EFB4")]
		public void Equalize([Optional] CurvySplineSegment fromCP, [Optional] CurvySplineSegment toCP)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x170F364", Offset = "0x170F364", VA = "0x170F364")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x170F4F8", Offset = "0x170F4F8", VA = "0x170F4F8")]
		public void MakePlanar(int axis)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x170F69C", Offset = "0x170F69C", VA = "0x170F69C")]
		public Vector3 SetPivot(float xRel = 0f, float yRel = 0f, float zRel = 0f, bool preview = false)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x170F8FC", Offset = "0x170F8FC", VA = "0x170F8FC")]
		public void Flip()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x170FBE8", Offset = "0x170FBE8", VA = "0x170FBE8")]
		public void MoveControlPoints(int startIndex, int count, CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x170FF98", Offset = "0x170FF98", VA = "0x170FF98")]
		public void JoinWith(CurvySplineSegment destCP)
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1710080", Offset = "0x1710080", VA = "0x1710080")]
		public CurvySpline Split(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1710308", Offset = "0x1710308", VA = "0x1710308")]
		public void SetFirstControlPoint(CurvySplineSegment controlPoint)
		{
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x17104A0", Offset = "0x17104A0", VA = "0x17104A0")]
		public bool IsControlPointAnOrientationAnchor(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x16F9FC0", Offset = "0x16F9FC0", VA = "0x16F9FC0")]
		public bool CanControlPointHaveFollowUp(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x1709B58", Offset = "0x1709B58", VA = "0x1709B58")]
		public short GetControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x17105F0", Offset = "0x17105F0", VA = "0x17105F0")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9D256C", Offset = "0x9D256C")]
		public short GetSegementIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1709B14", Offset = "0x1709B14", VA = "0x1709B14")]
		public short GetSegmentIndex(CurvySplineSegment segment)
		{
			return default(short);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x170B208", Offset = "0x170B208", VA = "0x170B208")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x17105F4", Offset = "0x17105F4", VA = "0x17105F4")]
		[CanBeNull]
		public short GetNextControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1710638", Offset = "0x1710638", VA = "0x1710638")]
		[CanBeNull]
		public CurvySplineSegment GetNextControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x170AC20", Offset = "0x170AC20", VA = "0x170AC20")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPoint(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x17107D8", Offset = "0x17107D8", VA = "0x17107D8")]
		[CanBeNull]
		public short GetPreviousControlPointIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x171081C", Offset = "0x171081C", VA = "0x171081C")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousControlPointUsingFollowUp(CurvySplineSegment controlPoint)
		{
			return null;
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1709E60", Offset = "0x1709E60", VA = "0x1709E60")]
		[CanBeNull]
		public CurvySplineSegment GetNextSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x1710908", Offset = "0x1710908", VA = "0x1710908")]
		[CanBeNull]
		public CurvySplineSegment GetPreviousSegment(CurvySplineSegment segment)
		{
			return null;
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x170ACCC", Offset = "0x170ACCC", VA = "0x170ACCC")]
		public bool IsControlPointASegment(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x17105AC", Offset = "0x17105AC", VA = "0x17105AC")]
		public bool IsControlPointVisible(CurvySplineSegment controlPoint)
		{
			return default(bool);
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x17109B4", Offset = "0x17109B4", VA = "0x17109B4")]
		public short GetControlPointOrientationAnchorIndex(CurvySplineSegment controlPoint)
		{
			return default(short);
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x17109F8", Offset = "0x17109F8", VA = "0x17109F8")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x1710FDC", Offset = "0x1710FDC", VA = "0x1710FDC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x17110F4", Offset = "0x17110F4", VA = "0x17110F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1708024", Offset = "0x1708024", VA = "0x1708024")]
		public void Start()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x171116C", Offset = "0x171116C", VA = "0x171116C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x1711174", Offset = "0x1711174", VA = "0x1711174")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x1711304", Offset = "0x1711304", VA = "0x1711304", Slot = "5")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x17114B0", Offset = "0x17114B0", VA = "0x17114B0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x1711794", Offset = "0x1711794", VA = "0x1711794")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x17117D8", Offset = "0x17117D8", VA = "0x17117D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x171181C", Offset = "0x171181C", VA = "0x171181C", Slot = "4")]
		protected override bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x171112C", Offset = "0x171112C", VA = "0x171112C")]
		private void Initialize()
		{
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x17114F0", Offset = "0x17114F0", VA = "0x17114F0")]
		private void doUpdate()
		{
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x1706D10", Offset = "0x1706D10", VA = "0x1706D10")]
		private bool canHaveManualEndCP()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x170CB38", Offset = "0x170CB38", VA = "0x170CB38")]
		private void SetDirty(CurvySplineSegment controlPoint, SplineDirtyingType dirtyingType, CurvySplineSegment previousControlPoint, CurvySplineSegment nextControlPoint, bool ignoreConnectionOfInputControlPoint)
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x170CA80", Offset = "0x170CA80", VA = "0x170CA80")]
		private void SetDirtyingFlags(SplineDirtyingType dirtyingType)
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x170FB7C", Offset = "0x170FB7C", VA = "0x170FB7C")]
		private void ReverseControlPoints()
		{
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1711854", Offset = "0x1711854", VA = "0x1711854")]
		private void SortControlPointsByName()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1711A2C", Offset = "0x1711A2C", VA = "0x1711A2C")]
		private static short GetNextControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1711A48", Offset = "0x1711A48", VA = "0x1711A48")]
		private static short GetPreviousControlPointIndex(short controlPointIndex, bool isSplineClosed, int controlPointsCount)
		{
			return default(short);
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1711A6C", Offset = "0x1711A6C", VA = "0x1711A6C")]
		private static bool IsControlPointASegment(int controlPointIndex, int controlPointCount, bool isClosed, bool notAutoEndTangentsAndIsCatmullRomOrTCB)
		{
			return default(bool);
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1710724", Offset = "0x1710724", VA = "0x1710724")]
		[NotNull]
		private static CurvySplineSegment GetFollowUpNextControlPoint(CurvySplineSegment followUp, ConnectionHeadingEnum headToDirection)
		{
			return null;
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x170D0FC", Offset = "0x170D0FC", VA = "0x170D0FC")]
		private void AddControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x170FE24", Offset = "0x170FE24", VA = "0x170FE24")]
		private void InsertControlPoint(int index, CurvySplineSegment item)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x170B648", Offset = "0x170B648", VA = "0x170B648")]
		private void RemoveControlPoint(CurvySplineSegment item)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x170B4D4", Offset = "0x170B4D4", VA = "0x170B4D4")]
		private void ClearControlPoints()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x1706888", Offset = "0x1706888", VA = "0x1706888")]
		internal void InvalidateControlPointsRelationshipCacheINTERNAL()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1707568", Offset = "0x1707568", VA = "0x1707568")]
		private void RebuildControlPointsRelationshipCache(bool fixNonCoherentControlPoints)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x170BD34", Offset = "0x170BD34", VA = "0x170BD34")]
		private void ProcessDirtyControlPoints()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1711D88", Offset = "0x1711D88", VA = "0x1711D88")]
		private void PrepareTTransforms()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1711AA4", Offset = "0x1711AA4", VA = "0x1711AA4")]
		private void FillDirtyCpsExtendedList()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1704138", Offset = "0x1704138", VA = "0x1704138")]
		internal void NotifyMetaDataModification()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1711F78", Offset = "0x1711F78", VA = "0x1711F78")]
		private void SyncHierarchyFromSpline(bool renameControlPoints = true)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x17119A0", Offset = "0x17119A0", VA = "0x17119A0")]
		private void UpdatedLastProcessedGlobalCoordinates()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x170ADF8", Offset = "0x170ADF8", VA = "0x170ADF8")]
		private CurvySplineSegment InsertAt(CurvySplineSegment controlPoint, Vector3 globalPosition, int insertionIndex, CurvyControlPointEventArgs.ModeEnum insertionMode, bool skipRefreshingAndEvents)
		{
			return null;
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x170CA18", Offset = "0x170CA18", VA = "0x170CA18")]
		private CurvySplineEventArgs OnRefreshEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x170A814", Offset = "0x170A814", VA = "0x170A814")]
		private CurvyControlPointEventArgs OnBeforeControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x170A968", Offset = "0x170A968", VA = "0x170A968")]
		private CurvyControlPointEventArgs OnAfterControlPointAddEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x170B46C", Offset = "0x170B46C", VA = "0x170B46C")]
		private CurvyControlPointEventArgs OnBeforeControlPointDeleteEvent(CurvyControlPointEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x170A9D0", Offset = "0x170A9D0", VA = "0x170A9D0")]
		private CurvySplineEventArgs OnAfterControlPointChangesEvent(CurvySplineEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x1711F7C", Offset = "0x1711F7C", VA = "0x1711F7C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2634", Offset = "0x9D2634")]
		private void <.ctor>b__4_0(CurvySplineSegment controlPoint)
		{
		}
	}
	[Token(Token = "0x2000128")]
	public enum SplineDirtyingType
	{
		[Token(Token = "0x400052D")]
		OrientationOnly,
		[Token(Token = "0x400052E")]
		Everything
	}
	[Token(Token = "0x2000129")]
	[ExecuteInEditMode]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3DB8", Offset = "0x9C3DB8")]
	public class CurvySplineSegment : MonoBehaviour, IPoolable
	{
		[Token(Token = "0x200012A")]
		internal readonly struct ControlPointExtrinsicProperties : IEquatable<ControlPointExtrinsicProperties>
		{
			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private readonly bool isVisible;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			private readonly short segmentIndex;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private readonly short controlPointIndex;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
			private readonly short nextControlPointIndex;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private readonly short previousControlPointIndex;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
			private readonly bool previousControlPointIsSegment;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
			private readonly bool nextControlPointIsSegment;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private readonly bool canHaveFollowUp;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			private readonly short orientationAnchorIndex;

			[Token(Token = "0x17000197")]
			internal bool IsVisible
			{
				[Token(Token = "0x6000882")]
				[Address(RVA = "0x1E0808C", Offset = "0x1E0808C", VA = "0x1E0808C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000198")]
			internal short SegmentIndex
			{
				[Token(Token = "0x6000883")]
				[Address(RVA = "0x1E08094", Offset = "0x1E08094", VA = "0x1E08094")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x17000199")]
			internal short ControlPointIndex
			{
				[Token(Token = "0x6000884")]
				[Address(RVA = "0x1E0809C", Offset = "0x1E0809C", VA = "0x1E0809C")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700019A")]
			internal short NextControlPointIndex
			{
				[Token(Token = "0x6000885")]
				[Address(RVA = "0x1E080A4", Offset = "0x1E080A4", VA = "0x1E080A4")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700019B")]
			internal short PreviousControlPointIndex
			{
				[Token(Token = "0x6000886")]
				[Address(RVA = "0x1E080AC", Offset = "0x1E080AC", VA = "0x1E080AC")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x1700019C")]
			internal bool PreviousControlPointIsSegment
			{
				[Token(Token = "0x6000887")]
				[Address(RVA = "0x1E080B4", Offset = "0x1E080B4", VA = "0x1E080B4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700019D")]
			internal bool NextControlPointIsSegment
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0x1E080BC", Offset = "0x1E080BC", VA = "0x1E080BC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700019E")]
			internal bool CanHaveFollowUp
			{
				[Token(Token = "0x6000889")]
				[Address(RVA = "0x1E080C4", Offset = "0x1E080C4", VA = "0x1E080C4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700019F")]
			internal bool IsSegment
			{
				[Token(Token = "0x600088A")]
				[Address(RVA = "0x1E080CC", Offset = "0x1E080CC", VA = "0x1E080CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001A0")]
			internal short OrientationAnchorIndex
			{
				[Token(Token = "0x600088B")]
				[Address(RVA = "0x1E080DC", Offset = "0x1E080DC", VA = "0x1E080DC")]
				get
				{
					return default(short);
				}
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1E080E4", Offset = "0x1E080E4", VA = "0x1E080E4")]
			internal ControlPointExtrinsicProperties(bool isVisible, short segmentIndex, short controlPointIndex, short previousControlPointIndex, short nextControlPointIndex, bool previousControlPointIsSegment, bool nextControlPointIsSegment, bool canHaveFollowUp, short orientationAnchorIndex)
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1E08124", Offset = "0x1E08124", VA = "0x1E08124", Slot = "4")]
			public bool Equals(ControlPointExtrinsicProperties other)
			{
				return default(bool);
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1E081E8", Offset = "0x1E081E8", VA = "0x1E081E8", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1E08270", Offset = "0x1E08270", VA = "0x1E08270", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1E083C4", Offset = "0x1E083C4", VA = "0x1E083C4")]
			public static bool operator ==(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1E083F4", Offset = "0x1E083F4", VA = "0x1E083F4")]
			public static bool operator !=(ControlPointExtrinsicProperties left, ControlPointExtrinsicProperties right)
			{
				return default(bool);
			}
		}

		[NonSerialized]
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] Approximation;

		[NonSerialized]
		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] ApproximationDistances;

		[NonSerialized]
		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] ApproximationUp;

		[NonSerialized]
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] ApproximationT;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C82D0", Offset = "0x9C82D0")]
		private float <Length>k__BackingField;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C82E0", Offset = "0x9C82E0")]
		private float <Distance>k__BackingField;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C82F0", Offset = "0x9C82F0")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9C82F0", Offset = "0x9C82F0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C82F0", Offset = "0x9C82F0")]
		[SerializeField]
		private bool m_AutoBakeOrientation;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C83AC", Offset = "0x9C83AC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C83AC", Offset = "0x9C83AC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C83AC", Offset = "0x9C83AC")]
		private bool m_OrientationAnchor;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C84A4", Offset = "0x9C84A4")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C84A4", Offset = "0x9C84A4")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C84A4", Offset = "0x9C84A4")]
		private CurvyOrientationSwirl m_Swirl;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C85B0", Offset = "0x9C85B0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9C85B0", Offset = "0x9C85B0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C85B0", Offset = "0x9C85B0")]
		[SerializeField]
		private float m_SwirlTurns;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C870C", Offset = "0x9C870C")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9C870C", Offset = "0x9C870C")]
		[SerializeField]
		private bool m_AutoHandles;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9C8804", Offset = "0x9C8804")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C8804", Offset = "0x9C8804")]
		[SerializeField]
		private float m_AutoHandleDistance;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C88FC", Offset = "0x9C88FC")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9C88FC", Offset = "0x9C88FC")]
		private Vector3 m_HandleIn;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9C89B0", Offset = "0x9C89B0")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C89B0", Offset = "0x9C89B0")]
		private Vector3 m_HandleOut;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8A64", Offset = "0x9C8A64")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C8A64", Offset = "0x9C8A64")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9C8A64", Offset = "0x9C8A64")]
		[AttributeAttribute(Name = "GroupActionAttribute", RVA = "0x9C8A64", Offset = "0x9C8A64")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8A64", Offset = "0x9C8A64")]
		private bool m_OverrideGlobalTension;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8BEC", Offset = "0x9C8BEC")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8BEC", Offset = "0x9C8BEC")]
		private bool m_OverrideGlobalContinuity;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8C78", Offset = "0x9C8C78")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8C78", Offset = "0x9C8C78")]
		[SerializeField]
		private bool m_OverrideGlobalBias;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8D04", Offset = "0x9C8D04")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C8D04", Offset = "0x9C8D04")]
		private bool m_SynchronizeTCB;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8D74", Offset = "0x9C8D74")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C8D74", Offset = "0x9C8D74")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8D74", Offset = "0x9C8D74")]
		private float m_StartTension;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8E80", Offset = "0x9C8E80")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C8E80", Offset = "0x9C8E80")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8E80", Offset = "0x9C8E80")]
		private float m_EndTension;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C8FC8", Offset = "0x9C8FC8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C8FC8", Offset = "0x9C8FC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C8FC8", Offset = "0x9C8FC8")]
		private float m_StartContinuity;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C90D4", Offset = "0x9C90D4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C90D4", Offset = "0x9C90D4")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C90D4", Offset = "0x9C90D4")]
		private float m_EndContinuity;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C921C", Offset = "0x9C921C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C921C", Offset = "0x9C921C")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C921C", Offset = "0x9C921C")]
		private float m_StartBias;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C9328", Offset = "0x9C9328")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9328", Offset = "0x9C9328")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C9328", Offset = "0x9C9328")]
		private float m_EndBias;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private CurvySplineSegment m_FollowUp;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[HideInInspector]
		private ConnectionHeadingEnum m_FollowUpHeading;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[HideInInspector]
		[SerializeField]
		private bool m_ConnectionSyncPosition;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x95")]
		[HideInInspector]
		[SerializeField]
		private bool m_ConnectionSyncRotation;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		[HideInInspector]
		private CurvyConnection m_Connection;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private int cacheSize;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 threadSafeLocalPosition;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion threadSafeLocalRotation;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CurvySpline mSpline;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float mStepSize;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Bounds? mBounds;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int mCacheLastDistanceToLocalFIndex;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private List<UnityEngine.Component> mMetaData;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Vector3 lastProcessedLocalPosition;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion lastProcessedLocalRotation;

		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private ControlPointExtrinsicProperties extrinsicPropertiesINTERNAL;

		[Token(Token = "0x1700016E")]
		public bool AutoBakeOrientation
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x250044C", Offset = "0x250044C", VA = "0x250044C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x2500454", Offset = "0x2500454", VA = "0x2500454")]
			set
			{
			}
		}

		[Token(Token = "0x1700016F")]
		public bool SerializedOrientationAnchor
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x2500474", Offset = "0x2500474", VA = "0x2500474")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x250047C", Offset = "0x250047C", VA = "0x250047C")]
			set
			{
			}
		}

		[Token(Token = "0x17000170")]
		public CurvyOrientationSwirl Swirl
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x25004E8", Offset = "0x25004E8", VA = "0x25004E8")]
			get
			{
				return default(CurvyOrientationSwirl);
			}
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x25004F0", Offset = "0x25004F0", VA = "0x25004F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000171")]
		public float SwirlTurns
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0x250052C", Offset = "0x250052C", VA = "0x250052C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x2500534", Offset = "0x2500534", VA = "0x2500534")]
			set
			{
			}
		}

		[Token(Token = "0x17000172")]
		public Vector3 HandleIn
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x250056C", Offset = "0x250056C", VA = "0x250056C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x2500578", Offset = "0x2500578", VA = "0x2500578")]
			set
			{
			}
		}

		[Token(Token = "0x17000173")]
		public Vector3 HandleOut
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x2500608", Offset = "0x2500608", VA = "0x2500608")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x2500614", Offset = "0x2500614", VA = "0x2500614")]
			set
			{
			}
		}

		[Token(Token = "0x17000174")]
		public Vector3 HandleInPosition
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x25006A4", Offset = "0x25006A4", VA = "0x25006A4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x250072C", Offset = "0x250072C", VA = "0x250072C")]
			set
			{
			}
		}

		[Token(Token = "0x17000175")]
		public Vector3 HandleOutPosition
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x25007B4", Offset = "0x25007B4", VA = "0x25007B4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x250083C", Offset = "0x250083C", VA = "0x250083C")]
			set
			{
			}
		}

		[Token(Token = "0x17000176")]
		public bool AutoHandles
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x25008C4", Offset = "0x25008C4", VA = "0x25008C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x25008CC", Offset = "0x25008CC", VA = "0x25008CC")]
			set
			{
			}
		}

		[Token(Token = "0x17000177")]
		public float AutoHandleDistance
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x2500A8C", Offset = "0x2500A8C", VA = "0x2500A8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x2500A94", Offset = "0x2500A94", VA = "0x2500A94")]
			set
			{
			}
		}

		[Token(Token = "0x17000178")]
		public bool SynchronizeTCB
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x2500AF8", Offset = "0x2500AF8", VA = "0x2500AF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x2500B00", Offset = "0x2500B00", VA = "0x2500B00")]
			set
			{
			}
		}

		[Token(Token = "0x17000179")]
		public bool OverrideGlobalTension
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x2500B48", Offset = "0x2500B48", VA = "0x2500B48")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x2500B50", Offset = "0x2500B50", VA = "0x2500B50")]
			set
			{
			}
		}

		[Token(Token = "0x1700017A")]
		public bool OverrideGlobalContinuity
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x2500B98", Offset = "0x2500B98", VA = "0x2500B98")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x2500BA0", Offset = "0x2500BA0", VA = "0x2500BA0")]
			set
			{
			}
		}

		[Token(Token = "0x1700017B")]
		public bool OverrideGlobalBias
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x2500BE8", Offset = "0x2500BE8", VA = "0x2500BE8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x2500BF0", Offset = "0x2500BF0", VA = "0x2500BF0")]
			set
			{
			}
		}

		[Token(Token = "0x1700017C")]
		public float StartTension
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x2500C38", Offset = "0x2500C38", VA = "0x2500C38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x2500C40", Offset = "0x2500C40", VA = "0x2500C40")]
			set
			{
			}
		}

		[Token(Token = "0x1700017D")]
		public float StartContinuity
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x2500C78", Offset = "0x2500C78", VA = "0x2500C78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x2500C80", Offset = "0x2500C80", VA = "0x2500C80")]
			set
			{
			}
		}

		[Token(Token = "0x1700017E")]
		public float StartBias
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x2500CB8", Offset = "0x2500CB8", VA = "0x2500CB8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x2500CC0", Offset = "0x2500CC0", VA = "0x2500CC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700017F")]
		public float EndTension
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x2500CF8", Offset = "0x2500CF8", VA = "0x2500CF8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x2500D00", Offset = "0x2500D00", VA = "0x2500D00")]
			set
			{
			}
		}

		[Token(Token = "0x17000180")]
		public float EndContinuity
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x2500D38", Offset = "0x2500D38", VA = "0x2500D38")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x2500D40", Offset = "0x2500D40", VA = "0x2500D40")]
			set
			{
			}
		}

		[Token(Token = "0x17000181")]
		public float EndBias
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x2500D78", Offset = "0x2500D78", VA = "0x2500D78")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x2500D80", Offset = "0x2500D80", VA = "0x2500D80")]
			set
			{
			}
		}

		[Token(Token = "0x17000182")]
		public CurvySplineSegment FollowUp
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x2500DB8", Offset = "0x2500DB8", VA = "0x2500DB8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x2500DC0", Offset = "0x2500DC0", VA = "0x2500DC0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000183")]
		public ConnectionHeadingEnum FollowUpHeading
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x2500EB8", Offset = "0x2500EB8", VA = "0x2500EB8")]
			get
			{
				return default(ConnectionHeadingEnum);
			}
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x2500EC0", Offset = "0x2500EC0", VA = "0x2500EC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000184")]
		public bool ConnectionSyncPosition
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x2500F78", Offset = "0x2500F78", VA = "0x2500F78")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x2500F80", Offset = "0x2500F80", VA = "0x2500F80")]
			set
			{
			}
		}

		[Token(Token = "0x17000185")]
		public bool ConnectionSyncRotation
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x2500FA0", Offset = "0x2500FA0", VA = "0x2500FA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x2500FA8", Offset = "0x2500FA8", VA = "0x2500FA8")]
			set
			{
			}
		}

		[Token(Token = "0x17000186")]
		public CurvyConnection Connection
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x2500FC8", Offset = "0x2500FC8", VA = "0x2500FC8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x2500FD0", Offset = "0x2500FD0", VA = "0x2500FD0")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000187")]
		public int CacheSize
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x25011A8", Offset = "0x25011A8", VA = "0x25011A8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x25011B0", Offset = "0x25011B0", VA = "0x25011B0")]
			private set
			{
			}
		}

		[Token(Token = "0x17000188")]
		public Bounds Bounds
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x25011B8", Offset = "0x25011B8", VA = "0x25011B8")]
			get
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x17000189")]
		public float Length
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x2501434", Offset = "0x2501434", VA = "0x2501434")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2644", Offset = "0x9D2644")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x250143C", Offset = "0x250143C", VA = "0x250143C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2654", Offset = "0x9D2654")]
			private set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public float Distance
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x2501444", Offset = "0x2501444", VA = "0x2501444")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2664", Offset = "0x9D2664")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x250144C", Offset = "0x250144C", VA = "0x250144C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2674", Offset = "0x9D2674")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700018B")]
		public float TF
		{
			[Token(Token = "0x6000830")]
			[Address(RVA = "0x2501454", Offset = "0x2501454", VA = "0x2501454")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700018C")]
		public bool IsFirstControlPoint
		{
			[Token(Token = "0x6000831")]
			[Address(RVA = "0x250147C", Offset = "0x250147C", VA = "0x250147C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018D")]
		public bool IsLastControlPoint
		{
			[Token(Token = "0x6000832")]
			[Address(RVA = "0x25014AC", Offset = "0x25014AC", VA = "0x25014AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700018E")]
		public List<UnityEngine.Component> MetaData
		{
			[Token(Token = "0x6000833")]
			[Address(RVA = "0x2501504", Offset = "0x2501504", VA = "0x2501504")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018F")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000834")]
			[Address(RVA = "0x2501610", Offset = "0x2501610", VA = "0x2501610")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		public bool HasUnprocessedLocalPosition
		{
			[Token(Token = "0x6000835")]
			[Address(RVA = "0x2501618", Offset = "0x2501618", VA = "0x2501618")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000191")]
		public bool HasUnprocessedLocalOrientation
		{
			[Token(Token = "0x6000836")]
			[Address(RVA = "0x2501658", Offset = "0x2501658", VA = "0x2501658")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000192")]
		public bool OrientatinInfluencesSpline
		{
			[Token(Token = "0x6000837")]
			[Address(RVA = "0x25016A0", Offset = "0x25016A0", VA = "0x25016A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000193")]
		private CurvyInterpolation interpolation
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x25051A4", Offset = "0x25051A4", VA = "0x25051A4")]
			get
			{
				return default(CurvyInterpolation);
			}
		}

		[Token(Token = "0x17000194")]
		private bool isDynamicOrientation
		{
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x250522C", Offset = "0x250522C", VA = "0x250522C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000195")]
		private bool IsOrientationAnchorEditable
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x25052BC", Offset = "0x25052BC", VA = "0x25052BC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000196")]
		private bool canHaveSwirl
		{
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x25053C0", Offset = "0x25053C0", VA = "0x25053C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x250174C", Offset = "0x250174C", VA = "0x250174C")]
		public void SetBezierHandleIn(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x2501B3C", Offset = "0x2501B3C", VA = "0x2501B3C")]
		public void SetBezierHandleOut(Vector3 position, Space space = Space.Self, CurvyBezierModeEnum mode = CurvyBezierModeEnum.None)
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2501F24", Offset = "0x2501F24", VA = "0x2501F24")]
		public void SetBezierHandles(float distanceFrag = -1f, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x25021DC", Offset = "0x25021DC", VA = "0x25021DC")]
		public void SetBezierHandles(float distanceFrag, Vector3 p, Vector3 n, bool setIn = true, bool setOut = true, bool noDirtying = false)
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x2501534", Offset = "0x2501534", VA = "0x2501534")]
		public void ReloadMetaData()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x2502364", Offset = "0x2502364", VA = "0x2502364")]
		public void SetFollowUp(CurvySplineSegment target, ConnectionHeadingEnum heading = ConnectionHeadingEnum.Auto)
		{
		}

		[Token(Token = "0x600083E")]
		[Address(RVA = "0x25024A0", Offset = "0x25024A0", VA = "0x25024A0")]
		public void Disconnect()
		{
		}

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x2502530", Offset = "0x2502530", VA = "0x2502530")]
		public void ResetConnectionRelatedData()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x2502584", Offset = "0x2502584", VA = "0x2502584")]
		public Vector3 Interpolate(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x25025A0", Offset = "0x25025A0", VA = "0x25025A0")]
		public Vector3 Interpolate(float localF, CurvyInterpolation interpolation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x2502DF0", Offset = "0x2502DF0", VA = "0x2502DF0")]
		public Vector3 InterpolateFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2502F48", Offset = "0x2502F48", VA = "0x2502F48")]
		public UnityEngine.Component GetMetaData(Type type, bool autoCreate = false)
		{
			return null;
		}

		[Token(Token = "0x6000844")]
		public T GetMetadata<T>(bool autoCreate = false) where T : UnityEngine.Component, ICurvyMetadata
		{
			return null;
		}

		[Token(Token = "0x6000845")]
		public U InterpolateMetadata<T, U>(float f) where T : UnityEngine.Component, ICurvyInterpolatableMetadata<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x2503208", Offset = "0x2503208", VA = "0x2503208")]
		public object InterpolateMetadata(Type type, float f)
		{
			return null;
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2503384", Offset = "0x2503384", VA = "0x2503384")]
		public void DeleteMetadata()
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x250343C", Offset = "0x250343C", VA = "0x250343C")]
		public Vector3 InterpolateScale(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2503580", Offset = "0x2503580", VA = "0x2503580")]
		public Vector3 GetTangent(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x25035D8", Offset = "0x25035D8", VA = "0x25035D8")]
		public Vector3 GetTangent(float localF, Vector3 position)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x2503778", Offset = "0x2503778", VA = "0x2503778")]
		public Vector3 GetTangentFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x2503828", Offset = "0x2503828", VA = "0x2503828")]
		public Quaternion GetOrientationFast(float localF)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x2503830", Offset = "0x2503830", VA = "0x2503830")]
		public Quaternion GetOrientationFast(float localF, bool inverse)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x25038F0", Offset = "0x25038F0", VA = "0x25038F0")]
		public Vector3 GetOrientationUpFast(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x25039A0", Offset = "0x25039A0", VA = "0x25039A0")]
		public float GetNearestPointF(Vector3 p)
		{
			return default(float);
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x2503C9C", Offset = "0x2503C9C", VA = "0x2503C9C")]
		public float DistanceToLocalF(float localDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x2503DDC", Offset = "0x2503DDC", VA = "0x2503DDC")]
		public float LocalFToDistance(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x250145C", Offset = "0x250145C", VA = "0x250145C")]
		public float LocalFToTF(float localF)
		{
			return default(float);
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x2503EB0", Offset = "0x2503EB0", VA = "0x2503EB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x2503F80", Offset = "0x2503F80", VA = "0x2503F80")]
		public void BakeOrientationToTransform()
		{
		}

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x2502EB4", Offset = "0x2502EB4", VA = "0x2502EB4")]
		public int getApproximationIndexINTERNAL(float localF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x25041B8", Offset = "0x25041B8", VA = "0x25041B8")]
		public void LinkToSpline(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x25041C0", Offset = "0x25041C0", VA = "0x25041C0")]
		public void UnlinkFromSpline()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x25041CC", Offset = "0x25041CC", VA = "0x25041CC")]
		public void SetLocalPosition(Vector3 newPosition)
		{
		}

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x2504344", Offset = "0x2504344", VA = "0x2504344")]
		public void SetPosition(Vector3 value)
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x2504028", Offset = "0x2504028", VA = "0x2504028")]
		public void SetLocalRotation(Quaternion value)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x25044BC", Offset = "0x25044BC", VA = "0x25044BC")]
		public void SetRotation(Quaternion value)
		{
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x250464C", Offset = "0x250464C", VA = "0x250464C", Slot = "4")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x600085D")]
		[Address(RVA = "0x2504734", Offset = "0x2504734", VA = "0x2504734", Slot = "5")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x600085E")]
		[Address(RVA = "0x250480C", Offset = "0x250480C", VA = "0x250480C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600085F")]
		[Address(RVA = "0x2504810", Offset = "0x2504810", VA = "0x2504810")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000860")]
		[Address(RVA = "0x2504814", Offset = "0x2504814", VA = "0x2504814")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000861")]
		[Address(RVA = "0x250511C", Offset = "0x250511C", VA = "0x250511C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000862")]
		[Address(RVA = "0x25051A0", Offset = "0x25051A0", VA = "0x25051A0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x2504738", Offset = "0x2504738", VA = "0x2504738")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000868")]
		[Address(RVA = "0x25054BC", Offset = "0x25054BC", VA = "0x25054BC")]
		internal void SetExtrinsicPropertiesINTERNAL(ControlPointExtrinsicProperties value)
		{
		}

		[Token(Token = "0x6000869")]
		[Address(RVA = "0x25054D0", Offset = "0x25054D0", VA = "0x25054D0")]
		internal unsafe ref ControlPointExtrinsicProperties GetExtrinsicPropertiesINTERNAL()
		{
			return ref *(ControlPointExtrinsicProperties*)null;
		}

		[Token(Token = "0x600086A")]
		[Address(RVA = "0x25054D8", Offset = "0x25054D8", VA = "0x25054D8")]
		private void DoUpdate()
		{
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0x2501088", Offset = "0x2501088", VA = "0x2501088")]
		private bool SetConnection(CurvyConnection newConnection)
		{
			return default(bool);
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x2500918", Offset = "0x2500918", VA = "0x2500918")]
		private bool SetAutoHandles(bool newValue)
		{
			return default(bool);
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x2503C8C", Offset = "0x2503C8C", VA = "0x2503C8C")]
		private float getApproximationLocalF(int idx)
		{
			return default(float);
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x2502CD0", Offset = "0x2502CD0", VA = "0x2502CD0")]
		private Vector3 interpolateLinear(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x2502710", Offset = "0x2502710", VA = "0x2502710")]
		private Vector3 interpolateBezier(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2502848", Offset = "0x2502848", VA = "0x2502848")]
		private Vector3 interpolateCatmull(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2502A4C", Offset = "0x2502A4C", VA = "0x2502A4C")]
		private Vector3 interpolateTCB(float localF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0x2505504", Offset = "0x2505504", VA = "0x2505504")]
		internal void refreshCurveINTERNAL(CurvyInterpolation splineInterpolation, bool isControlPointASegment, CurvySpline spline)
		{
		}

		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2505AD0", Offset = "0x2505AD0", VA = "0x2505AD0")]
		private float InterpolateBezierSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000874")]
		[Address(RVA = "0x2506374", Offset = "0x2506374", VA = "0x2506374")]
		private float InterpolateTCBSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2505EA4", Offset = "0x2505EA4", VA = "0x2505EA4")]
		private float InterpolateCatmullSegment(CurvySpline spline, CurvySplineSegment nextControlPoint, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000876")]
		[Address(RVA = "0x25069D8", Offset = "0x25069D8", VA = "0x25069D8")]
		private float InterpolateLinearSegment(CurvySpline spline, int newCacheSize)
		{
			return default(float);
		}

		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2506C40", Offset = "0x2506C40", VA = "0x2506C40")]
		internal void refreshOrientationNoneINTERNAL()
		{
		}

		[Token(Token = "0x6000878")]
		[Address(RVA = "0x2506C84", Offset = "0x2506C84", VA = "0x2506C84")]
		internal void refreshOrientationStaticINTERNAL()
		{
		}

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2506FB8", Offset = "0x2506FB8", VA = "0x2506FB8")]
		internal void refreshOrientationDynamicINTERNAL(Vector3 initialUp)
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x25071C4", Offset = "0x25071C4", VA = "0x25071C4")]
		internal void ClearBoundsINTERNAL()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2506DD8", Offset = "0x2506DD8", VA = "0x2506DD8")]
		internal Vector3 getOrthoUp0INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2506E80", Offset = "0x2506E80", VA = "0x2506E80")]
		private Vector3 getOrthoUp1INTERNAL()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x25071D8", Offset = "0x25071D8", VA = "0x25071D8")]
		internal void UnsetFollowUpWithoutDirtyingINTERNAL()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x25048AC", Offset = "0x25048AC", VA = "0x25048AC")]
		private void doGizmos(bool selected)
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x250729C", Offset = "0x250729C", VA = "0x250729C")]
		private bool SnapToFitSplineLength(float newSplineLength, float stepSize)
		{
			return default(bool);
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2507594", Offset = "0x2507594", VA = "0x2507594")]
		internal void PrepareThreadSafeTransfromINTERNAL()
		{
		}

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x25075E8", Offset = "0x25075E8", VA = "0x25075E8")]
		public CurvySplineSegment()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public static class CurvySplineSegmentDefaultValues
	{
		[Token(Token = "0x4000560")]
		public const CurvyOrientationSwirl Swirl = CurvyOrientationSwirl.None;

		[Token(Token = "0x4000561")]
		public const bool AutoHandles = true;

		[Token(Token = "0x4000562")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vector3 HandleIn;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly Vector3 HandleOut;
	}
	[Token(Token = "0x200012C")]
	public static class CurvySplineDefaultValues
	{
		[Token(Token = "0x4000565")]
		public const bool AutoEndTangents = true;

		[Token(Token = "0x4000566")]
		public const CurvyOrientation Orientation = CurvyOrientation.Dynamic;

		[Token(Token = "0x4000567")]
		public const float AutoHandleDistance = 0.39f;

		[Token(Token = "0x4000568")]
		public const int CacheDensity = 50;

		[Token(Token = "0x4000569")]
		public const float MaxPointsPerUnit = 8f;

		[Token(Token = "0x400056A")]
		public const bool UsePooling = true;

		[Token(Token = "0x400056B")]
		public const CurvyUpdateMethod UpdateIn = CurvyUpdateMethod.Update;

		[Token(Token = "0x400056C")]
		public const bool CheckTransform = true;
	}
	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3E14", Offset = "0x9C3E14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C3E14", Offset = "0x9C3E14")]
	public class CurvyUISpline : CurvySpline
	{
		[Token(Token = "0x6000893")]
		[Address(RVA = "0x25077B4", Offset = "0x25077B4", VA = "0x25077B4")]
		public static CurvyUISpline CreateUISpline(string gameObjectName = "Curvy UI Spline")
		{
			return null;
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x2507960", Offset = "0x2507960", VA = "0x2507960", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x250791C", Offset = "0x250791C", VA = "0x250791C")]
		private void SetupUISpline()
		{
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2507988", Offset = "0x2507988", VA = "0x2507988")]
		public CurvyUISpline()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ThirdParty.LibTessDotNet
{
	[Token(Token = "0x200012E")]
	internal class Dict<TValue> where TValue : class
	{
		[Token(Token = "0x200012F")]
		public class Node
		{
			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _prev;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Node _next;

			[Token(Token = "0x170001A1")]
			public TValue Key
			{
				[Token(Token = "0x600089D")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A2")]
			public Node Prev
			{
				[Token(Token = "0x600089E")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A3")]
			public Node Next
			{
				[Token(Token = "0x600089F")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A0")]
			public Node()
			{
			}
		}

		[Token(Token = "0x2000130")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Node _head;

		[Token(Token = "0x6000897")]
		public Dict(LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000898")]
		public Node Insert(TValue key)
		{
			return null;
		}

		[Token(Token = "0x6000899")]
		public Node InsertBefore(Node node, TValue key)
		{
			return null;
		}

		[Token(Token = "0x600089A")]
		public Node Find(TValue key)
		{
			return null;
		}

		[Token(Token = "0x600089B")]
		public Node Min()
		{
			return null;
		}

		[Token(Token = "0x600089C")]
		public void Remove(Node node)
		{
		}
	}
	[Token(Token = "0x2000131")]
	internal static class Geom
	{
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x16938CC", Offset = "0x16938CC", VA = "0x16938CC")]
		public static bool IsWindingInside(WindingRule rule, int n)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1693978", Offset = "0x1693978", VA = "0x1693978")]
		public static bool VertCCW(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x16939CC", Offset = "0x16939CC", VA = "0x16939CC")]
		public static bool VertEq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x1693A10", Offset = "0x1693A10", VA = "0x1693A10")]
		public static bool VertLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x1693A60", Offset = "0x1693A60", VA = "0x1693A60")]
		public static float EdgeEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x1693AD4", Offset = "0x1693AD4", VA = "0x1693AD4")]
		public static float EdgeSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x1693B38", Offset = "0x1693B38", VA = "0x1693B38")]
		public static bool TransLeq(MeshUtils.Vertex lhs, MeshUtils.Vertex rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1693B88", Offset = "0x1693B88", VA = "0x1693B88")]
		public static float TransEval(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1693BFC", Offset = "0x1693BFC", VA = "0x1693BFC")]
		public static float TransSign(MeshUtils.Vertex u, MeshUtils.Vertex v, MeshUtils.Vertex w)
		{
			return default(float);
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1693C60", Offset = "0x1693C60", VA = "0x1693C60")]
		public static bool EdgeGoesLeft(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1693C90", Offset = "0x1693C90", VA = "0x1693C90")]
		public static bool EdgeGoesRight(MeshUtils.Edge e)
		{
			return default(bool);
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1693CC4", Offset = "0x1693CC4", VA = "0x1693CC4")]
		public static float VertL1dist(MeshUtils.Vertex u, MeshUtils.Vertex v)
		{
			return default(float);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1693D5C", Offset = "0x1693D5C", VA = "0x1693D5C")]
		public static void AddWinding(MeshUtils.Edge eDst, MeshUtils.Edge eSrc)
		{
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1693DA8", Offset = "0x1693DA8", VA = "0x1693DA8")]
		public static float Interpolate(float a, float x, float b, float y)
		{
			return default(float);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x1693E04", Offset = "0x1693E04", VA = "0x1693E04")]
		private static void Swap(ref MeshUtils.Vertex a, ref MeshUtils.Vertex b)
		{
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1693E3C", Offset = "0x1693E3C", VA = "0x1693E3C")]
		public static void EdgeIntersect(MeshUtils.Vertex o1, MeshUtils.Vertex d1, MeshUtils.Vertex o2, MeshUtils.Vertex d2, MeshUtils.Vertex v)
		{
		}
	}
	[Token(Token = "0x2000132")]
	internal class LTMesh : MeshUtils.Pooled<LTMesh>
	{
		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal MeshUtils.Vertex _vHead;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal MeshUtils.Face _fHead;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal MeshUtils.Edge _eHead;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		internal MeshUtils.Edge _eHeadSym;

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x169AD94", Offset = "0x169AD94", VA = "0x169AD94")]
		public LTMesh()
		{
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x169AFF0", Offset = "0x169AFF0", VA = "0x169AFF0", Slot = "4")]
		public override void Reset()
		{
		}

		[Token(Token = "0x60008B7")]
		[Address(RVA = "0x169B044", Offset = "0x169B044", VA = "0x169B044", Slot = "5")]
		public override void OnFree()
		{
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x169B158", Offset = "0x169B158", VA = "0x169B158")]
		public MeshUtils.Edge MakeEdge()
		{
			return null;
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x169B1BC", Offset = "0x169B1BC", VA = "0x169B1BC")]
		public void Splice(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x169B2AC", Offset = "0x169B2AC", VA = "0x169B2AC")]
		public void Delete(MeshUtils.Edge eDel)
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x169B448", Offset = "0x169B448", VA = "0x169B448")]
		public MeshUtils.Edge AddEdgeVertex(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x169B4F0", Offset = "0x169B4F0", VA = "0x169B4F0")]
		public MeshUtils.Edge SplitEdge(MeshUtils.Edge eOrg)
		{
			return null;
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x169B5CC", Offset = "0x169B5CC", VA = "0x169B5CC")]
		public MeshUtils.Edge Connect(MeshUtils.Edge eOrg, MeshUtils.Edge eDst)
		{
			return null;
		}

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x169B6E8", Offset = "0x169B6E8", VA = "0x169B6E8")]
		public void ZapFace(MeshUtils.Face fZap)
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x169B860", Offset = "0x169B860", VA = "0x169B860")]
		public void MergeConvexFaces(int maxVertsPerFace)
		{
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x169B9C4", Offset = "0x169B9C4", VA = "0x169B9C4")]
		[AttributeAttribute(Name = "ConditionalAttribute", RVA = "0x9D2684", Offset = "0x9D2684")]
		public void Check()
		{
		}
	}
	[Token(Token = "0x2000133")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x9C3E9C", Offset = "0x9C3E9C")]
	public struct Vec3
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly Vec3 Zero;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float Z;

		[Token(Token = "0x170001A4")]
		public float Item
		{
			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x1E010C8", Offset = "0x1E010C8", VA = "0x1E010C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x1E01130", Offset = "0x1E01130", VA = "0x1E01130")]
			set
			{
			}
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1E01198", Offset = "0x1E01198", VA = "0x1E01198")]
		public static void Sub(ref Vec3 lhs, ref Vec3 rhs, out Vec3 result)
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x1E011CC", Offset = "0x1E011CC", VA = "0x1E011CC")]
		public static void Neg(ref Vec3 v)
		{
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1E011E8", Offset = "0x1E011E8", VA = "0x1E011E8")]
		public static void Dot(ref Vec3 u, ref Vec3 v, out float dot)
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1E01214", Offset = "0x1E01214", VA = "0x1E01214")]
		public static void Normalize(ref Vec3 v)
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1E012C8", Offset = "0x1E012C8", VA = "0x1E012C8")]
		public static int LongAxis(ref Vec3 v)
		{
			return default(int);
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1E013CC", Offset = "0x1E013CC", VA = "0x1E013CC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000134")]
	internal static class MeshUtils
	{
		[Token(Token = "0x2000135")]
		public abstract class Pooled<T> where T : Pooled<T>, new()
		{
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static Stack<T> _stack;

			[Token(Token = "0x60008D2")]
			public abstract void Reset();

			[Token(Token = "0x60008D3")]
			public virtual void OnFree()
			{
			}

			[Token(Token = "0x60008D4")]
			public static T Create()
			{
				return null;
			}

			[Token(Token = "0x60008D5")]
			public void Free()
			{
			}

			[Token(Token = "0x60008D6")]
			protected Pooled()
			{
			}
		}

		[Token(Token = "0x2000136")]
		public class Vertex : Pooled<Vertex>
		{
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Vertex _prev;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Vertex _next;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Vec3 _coords;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal float _s;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal float _t;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			internal PQHandle _pqHandle;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal int _n;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal object _data;

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x1E0CC74", Offset = "0x1E0CC74", VA = "0x1E0CC74", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x1E0CD2C", Offset = "0x1E0CD2C", VA = "0x1E0CD2C")]
			public Vertex()
			{
			}
		}

		[Token(Token = "0x2000137")]
		public class Face : Pooled<Face>
		{
			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal Face _prev;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Face _next;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _anEdge;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Face _trail;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal int _n;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _marked;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
			internal bool _inside;

			[Token(Token = "0x170001A5")]
			internal int VertsCount
			{
				[Token(Token = "0x60008D9")]
				[Address(RVA = "0x1E0CB94", Offset = "0x1E0CB94", VA = "0x1E0CB94")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x1E0CBC8", Offset = "0x1E0CBC8", VA = "0x1E0CBC8", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x1E0CC28", Offset = "0x1E0CC28", VA = "0x1E0CC28")]
			public Face()
			{
			}
		}

		[Token(Token = "0x2000138")]
		public struct EdgePair
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal Edge _e;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			internal Edge _eSym;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x1E0CACC", Offset = "0x1E0CACC", VA = "0x1E0CACC")]
			public static EdgePair Create()
			{
				return default(EdgePair);
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x1E0CA4C", Offset = "0x1E0CA4C", VA = "0x1E0CA4C")]
			public void Reset()
			{
			}
		}

		[Token(Token = "0x2000139")]
		public class Edge : Pooled<Edge>
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal EdgePair _pair;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal Edge _next;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Edge _Sym;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal Edge _Onext;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal Edge _Lnext;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal Vertex _Org;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal Face _Lface;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal Tess.ActiveRegion _activeRegion;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal int _winding;

			[Token(Token = "0x170001A6")]
			internal Face _Rface
			{
				[Token(Token = "0x60008DE")]
				[Address(RVA = "0x1E0C780", Offset = "0x1E0C780", VA = "0x1E0C780")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008DF")]
				[Address(RVA = "0x1E0C79C", Offset = "0x1E0C79C", VA = "0x1E0C79C")]
				set
				{
				}
			}

			[Token(Token = "0x170001A7")]
			internal Vertex _Dst
			{
				[Token(Token = "0x60008E0")]
				[Address(RVA = "0x1E0C7B8", Offset = "0x1E0C7B8", VA = "0x1E0C7B8")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E1")]
				[Address(RVA = "0x1E0C7D4", Offset = "0x1E0C7D4", VA = "0x1E0C7D4")]
				set
				{
				}
			}

			[Token(Token = "0x170001A8")]
			internal Edge _Oprev
			{
				[Token(Token = "0x60008E2")]
				[Address(RVA = "0x1E0C7F0", Offset = "0x1E0C7F0", VA = "0x1E0C7F0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E3")]
				[Address(RVA = "0x1E0C80C", Offset = "0x1E0C80C", VA = "0x1E0C80C")]
				set
				{
				}
			}

			[Token(Token = "0x170001A9")]
			internal Edge _Lprev
			{
				[Token(Token = "0x60008E4")]
				[Address(RVA = "0x1E0C828", Offset = "0x1E0C828", VA = "0x1E0C828")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E5")]
				[Address(RVA = "0x1E0C844", Offset = "0x1E0C844", VA = "0x1E0C844")]
				set
				{
				}
			}

			[Token(Token = "0x170001AA")]
			internal Edge _Dprev
			{
				[Token(Token = "0x60008E6")]
				[Address(RVA = "0x1E0C860", Offset = "0x1E0C860", VA = "0x1E0C860")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E7")]
				[Address(RVA = "0x1E0C87C", Offset = "0x1E0C87C", VA = "0x1E0C87C")]
				set
				{
				}
			}

			[Token(Token = "0x170001AB")]
			internal Edge _Rprev
			{
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x1E0C898", Offset = "0x1E0C898", VA = "0x1E0C898")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008E9")]
				[Address(RVA = "0x1E0C8B4", Offset = "0x1E0C8B4", VA = "0x1E0C8B4")]
				set
				{
				}
			}

			[Token(Token = "0x170001AC")]
			internal Edge _Dnext
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x1E0C8D0", Offset = "0x1E0C8D0", VA = "0x1E0C8D0")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x1E0C8F8", Offset = "0x1E0C8F8", VA = "0x1E0C8F8")]
				set
				{
				}
			}

			[Token(Token = "0x170001AD")]
			internal Edge _Rnext
			{
				[Token(Token = "0x60008EC")]
				[Address(RVA = "0x1E0C920", Offset = "0x1E0C920", VA = "0x1E0C920")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x1E0C948", Offset = "0x1E0C948", VA = "0x1E0C948")]
				set
				{
				}
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x1E0C970", Offset = "0x1E0C970", VA = "0x1E0C970")]
			internal static void EnsureFirst(ref Edge e)
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x1E0C9A0", Offset = "0x1E0C9A0", VA = "0x1E0C9A0", Slot = "4")]
			public override void Reset()
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x1E0CA80", Offset = "0x1E0CA80", VA = "0x1E0CA80")]
			public Edge()
			{
			}
		}

		[Token(Token = "0x400057A")]
		public const int Undef = -1;

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1673358", Offset = "0x1673358", VA = "0x1673358")]
		public static Edge MakeEdge(Edge eNext)
		{
			return null;
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x16734D8", Offset = "0x16734D8", VA = "0x16734D8")]
		public static void Splice(Edge a, Edge b)
		{
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1673568", Offset = "0x1673568", VA = "0x1673568")]
		public static void MakeVertex(Edge eOrig, Vertex vNext)
		{
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1673658", Offset = "0x1673658", VA = "0x1673658")]
		public static void MakeFace(Edge eOrig, Face fNext)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1673768", Offset = "0x1673768", VA = "0x1673768")]
		public static void KillEdge(Edge eDel)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x167381C", Offset = "0x167381C", VA = "0x167381C")]
		public static void KillVertex(Vertex vDel, Vertex newOrg)
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x16738D4", Offset = "0x16738D4", VA = "0x16738D4")]
		public static void KillFace(Face fDel, Face newLFace)
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x167398C", Offset = "0x167398C", VA = "0x167398C")]
		public static float FaceArea(Face f)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200013A")]
	internal struct PQHandle
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int Invalid;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int _handle;
	}
	[Token(Token = "0x200013B")]
	internal class PriorityHeap<TValue> where TValue : class
	{
		[Token(Token = "0x200013C")]
		public delegate bool LessOrEqual(TValue lhs, TValue rhs);

		[Token(Token = "0x200013D")]
		protected class HandleElem
		{
			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal TValue _key;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int _node;

			[Token(Token = "0x60008FF")]
			public HandleElem()
			{
			}
		}

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private LessOrEqual _leq;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _nodes;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private HandleElem[] _handles;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _freeList;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170001AE")]
		public bool Empty
		{
			[Token(Token = "0x60008F2")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008F3")]
		public PriorityHeap(int initialSize, LessOrEqual leq)
		{
		}

		[Token(Token = "0x60008F4")]
		private void FloatDown(int curr)
		{
		}

		[Token(Token = "0x60008F5")]
		private void FloatUp(int curr)
		{
		}

		[Token(Token = "0x60008F6")]
		public void Init()
		{
		}

		[Token(Token = "0x60008F7")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x60008F8")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x60008F9")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x200013E")]
	internal class PriorityQueue<TValue> where TValue : class
	{
		[Token(Token = "0x200013F")]
		private class StackItem
		{
			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int p;

			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			internal int r;

			[Token(Token = "0x6000908")]
			public StackItem()
			{
			}
		}

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue>.LessOrEqual _leq;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PriorityHeap<TValue> _heap;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TValue[] _keys;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int[] _order;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _size;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int _max;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _initialized;

		[Token(Token = "0x170001AF")]
		public bool Empty
		{
			[Token(Token = "0x6000900")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000901")]
		public PriorityQueue(int initialSize, PriorityHeap<TValue>.LessOrEqual leq)
		{
		}

		[Token(Token = "0x6000902")]
		private static void Swap(ref int a, ref int b)
		{
		}

		[Token(Token = "0x6000903")]
		public void Init()
		{
		}

		[Token(Token = "0x6000904")]
		public PQHandle Insert(TValue value)
		{
			return default(PQHandle);
		}

		[Token(Token = "0x6000905")]
		public TValue ExtractMin()
		{
			return null;
		}

		[Token(Token = "0x6000906")]
		public TValue Minimum()
		{
			return null;
		}

		[Token(Token = "0x6000907")]
		public void Remove(PQHandle handle)
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class Tess
	{
		[Token(Token = "0x2000141")]
		internal class ActiveRegion
		{
			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MeshUtils.Edge _eUp;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Dict<ActiveRegion>.Node _nodeUp;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _windingNumber;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _inside;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _sentinel;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _dirty;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixUpperEdge;

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x1E0E340", Offset = "0x1E0E340", VA = "0x1E0E340")]
			public ActiveRegion()
			{
			}
		}

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LTMesh _mesh;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Vec3 _normal;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vec3 _sUnit;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vec3 _tUnit;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float _bminX;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _bminY;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float _bmaxX;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float _bmaxY;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private WindingRule _windingRule;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dict<ActiveRegion> _dict;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PriorityQueue<MeshUtils.Vertex> _pq;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MeshUtils.Vertex _event;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private CombineCallback _combineCallback;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ContourVertex[] _vertices;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int _vertexCount;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int[] _elements;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private int _elementCount;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float SUnitX;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float SUnitY;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float SentinelCoord;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool NoEmptyPolygons;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool UsePooling;

		[Token(Token = "0x170001B0")]
		public Vec3 Normal
		{
			[Token(Token = "0x6000928")]
			[Address(RVA = "0x1DD1144", Offset = "0x1DD1144", VA = "0x1DD1144")]
			get
			{
				return default(Vec3);
			}
			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1DD1150", Offset = "0x1DD1150", VA = "0x1DD1150")]
			set
			{
			}
		}

		[Token(Token = "0x170001B1")]
		public ContourVertex[] Vertices
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1DD115C", Offset = "0x1DD115C", VA = "0x1DD115C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B2")]
		public int VertexCount
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1DD1164", Offset = "0x1DD1164", VA = "0x1DD1164")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B3")]
		public int[] Elements
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1DD116C", Offset = "0x1DD116C", VA = "0x1DD116C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001B4")]
		public int ElementCount
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1DD1174", Offset = "0x1DD1174", VA = "0x1DD1174")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x1DCE938", Offset = "0x1DCE938", VA = "0x1DCE938")]
		private ActiveRegion RegionBelow(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x1DCE964", Offset = "0x1DCE964", VA = "0x1DCE964")]
		private ActiveRegion RegionAbove(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x1DCE990", Offset = "0x1DCE990", VA = "0x1DCE990")]
		private bool EdgeLeq(ActiveRegion reg1, ActiveRegion reg2)
		{
			return default(bool);
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x1DCEAD8", Offset = "0x1DCEAD8", VA = "0x1DCEAD8")]
		private void DeleteRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0x1DCEB54", Offset = "0x1DCEB54", VA = "0x1DCEB54")]
		private void FixUpperEdge(ActiveRegion reg, MeshUtils.Edge newEdge)
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0x1DCEBC0", Offset = "0x1DCEBC0", VA = "0x1DCEBC0")]
		private ActiveRegion TopLeftRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x600090F")]
		[Address(RVA = "0x1DCEC88", Offset = "0x1DCEC88", VA = "0x1DCEC88")]
		private ActiveRegion TopRightRegion(ActiveRegion reg)
		{
			return null;
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1DCECEC", Offset = "0x1DCECEC", VA = "0x1DCECEC")]
		private ActiveRegion AddRegionBelow(ActiveRegion regAbove, MeshUtils.Edge eNewUp)
		{
			return null;
		}

		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1DCEDCC", Offset = "0x1DCEDCC", VA = "0x1DCEDCC")]
		private void ComputeWinding(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000912")]
		[Address(RVA = "0x1DCEE28", Offset = "0x1DCEE28", VA = "0x1DCEE28")]
		private void FinishRegion(ActiveRegion reg)
		{
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0x1DCEE78", Offset = "0x1DCEE78", VA = "0x1DCEE78")]
		private MeshUtils.Edge FinishLeftRegions(ActiveRegion regFirst, ActiveRegion regLast)
		{
			return null;
		}

		[Token(Token = "0x6000914")]
		[Address(RVA = "0x1DCEFBC", Offset = "0x1DCEFBC", VA = "0x1DCEFBC")]
		private void AddRightEdges(ActiveRegion regUp, MeshUtils.Edge eFirst, MeshUtils.Edge eLast, MeshUtils.Edge eTopLeft, bool cleanUp)
		{
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0x1DCF5F8", Offset = "0x1DCF5F8", VA = "0x1DCF5F8")]
		private void SpliceMergeVertices(MeshUtils.Edge e1, MeshUtils.Edge e2)
		{
		}

		[Token(Token = "0x6000916")]
		[Address(RVA = "0x1DCF614", Offset = "0x1DCF614", VA = "0x1DCF614")]
		private void VertexWeights(MeshUtils.Vertex isect, MeshUtils.Vertex org, MeshUtils.Vertex dst, out float w0, out float w1)
		{
		}

		[Token(Token = "0x6000917")]
		[Address(RVA = "0x1DCF718", Offset = "0x1DCF718", VA = "0x1DCF718")]
		private void GetIntersectData(MeshUtils.Vertex isect, MeshUtils.Vertex orgUp, MeshUtils.Vertex dstUp, MeshUtils.Vertex orgLo, MeshUtils.Vertex dstLo)
		{
		}

		[Token(Token = "0x6000918")]
		[Address(RVA = "0x1DCF1AC", Offset = "0x1DCF1AC", VA = "0x1DCF1AC")]
		private bool CheckForRightSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000919")]
		[Address(RVA = "0x1DCF9E4", Offset = "0x1DCF9E4", VA = "0x1DCF9E4")]
		private bool CheckForLeftSplice(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600091A")]
		[Address(RVA = "0x1DCFBA4", Offset = "0x1DCFBA4", VA = "0x1DCFBA4")]
		private bool CheckForIntersect(ActiveRegion regUp)
		{
			return default(bool);
		}

		[Token(Token = "0x600091B")]
		[Address(RVA = "0x1DCF390", Offset = "0x1DCF390", VA = "0x1DCF390")]
		private void WalkDirtyRegions(ActiveRegion regUp)
		{
		}

		[Token(Token = "0x600091C")]
		[Address(RVA = "0x1DD0288", Offset = "0x1DD0288", VA = "0x1DD0288")]
		private void ConnectRightVertex(ActiveRegion regUp, MeshUtils.Edge eBottomLeft)
		{
		}

		[Token(Token = "0x600091D")]
		[Address(RVA = "0x1DD04C0", Offset = "0x1DD04C0", VA = "0x1DD04C0")]
		private void ConnectLeftDegenerate(ActiveRegion regUp, MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600091E")]
		[Address(RVA = "0x1DD06AC", Offset = "0x1DD06AC", VA = "0x1DD06AC")]
		private void ConnectLeftVertex(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x600091F")]
		[Address(RVA = "0x1DD05CC", Offset = "0x1DD05CC", VA = "0x1DD05CC")]
		private void SweepEvent(MeshUtils.Vertex vEvent)
		{
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0x1DD0910", Offset = "0x1DD0910", VA = "0x1DD0910")]
		private void AddSentinel(float smin, float smax, float t)
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0x1DD0A58", Offset = "0x1DD0A58", VA = "0x1DD0A58")]
		private void InitEdgeDict()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0x1DD0B5C", Offset = "0x1DD0B5C", VA = "0x1DD0B5C")]
		private void DoneEdgeDict()
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0x1DD0BF0", Offset = "0x1DD0BF0", VA = "0x1DD0BF0")]
		private void RemoveDegenerateEdges()
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0x1DD0D50", Offset = "0x1DD0D50", VA = "0x1DD0D50")]
		private void InitPriorityQ()
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0x1DD0F68", Offset = "0x1DD0F68", VA = "0x1DD0F68")]
		private void DonePriorityQ()
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1DD0F74", Offset = "0x1DD0F74", VA = "0x1DD0F74")]
		private void RemoveDegenerateFaces()
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1DD1014", Offset = "0x1DD1014", VA = "0x1DD1014")]
		protected void ComputeInterior()
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1DC80AC", Offset = "0x1DC80AC", VA = "0x1DC80AC")]
		public Tess()
		{
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1DD117C", Offset = "0x1DD117C", VA = "0x1DD117C")]
		private void ComputeNormal(ref Vec3 norm)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1DD1894", Offset = "0x1DD1894", VA = "0x1DD1894")]
		private void CheckOrientation()
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1DD19AC", Offset = "0x1DD19AC", VA = "0x1DD19AC")]
		private void ProjectPolygon()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1DD1CAC", Offset = "0x1DD1CAC", VA = "0x1DD1CAC")]
		private void TessellateMonoRegion(MeshUtils.Face face)
		{
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x1DD1F0C", Offset = "0x1DD1F0C", VA = "0x1DD1F0C")]
		private void TessellateInterior()
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1DD1F78", Offset = "0x1DD1F78", VA = "0x1DD1F78")]
		private void DiscardExterior()
		{
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x1DD1FE4", Offset = "0x1DD1FE4", VA = "0x1DD1FE4")]
		private void SetWindingNumber(int value, bool keepOnlyBoundary)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x1DD20C4", Offset = "0x1DD20C4", VA = "0x1DD20C4")]
		private int GetNeighbourFace(MeshUtils.Edge edge)
		{
			return default(int);
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x1DD212C", Offset = "0x1DD212C", VA = "0x1DD212C")]
		private void OutputPolymesh(ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x1DD25A4", Offset = "0x1DD25A4", VA = "0x1DD25A4")]
		private void OutputContours()
		{
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1DD2818", Offset = "0x1DD2818", VA = "0x1DD2818")]
		private float SignedArea(ContourVertex[] vertices)
		{
			return default(float);
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x1DD28B8", Offset = "0x1DD28B8", VA = "0x1DD28B8")]
		public void AddContour(ContourVertex[] vertices)
		{
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1DC81C4", Offset = "0x1DC81C4", VA = "0x1DC81C4")]
		public void AddContour(ContourVertex[] vertices, ContourOrientation forceOrientation)
		{
		}

		[Token(Token = "0x600093C")]
		[Address(RVA = "0x1DC83B0", Offset = "0x1DC83B0", VA = "0x1DC83B0")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize)
		{
		}

		[Token(Token = "0x600093D")]
		[Address(RVA = "0x1DD28C0", Offset = "0x1DD28C0", VA = "0x1DD28C0")]
		public void Tessellate(WindingRule windingRule, ElementType elementType, int polySize, CombineCallback combineCallback)
		{
		}
	}
	[Token(Token = "0x2000142")]
	public enum WindingRule
	{
		[Token(Token = "0x40005C9")]
		EvenOdd,
		[Token(Token = "0x40005CA")]
		NonZero,
		[Token(Token = "0x40005CB")]
		Positive,
		[Token(Token = "0x40005CC")]
		Negative,
		[Token(Token = "0x40005CD")]
		AbsGeqTwo
	}
	[Token(Token = "0x2000143")]
	public enum ElementType
	{
		[Token(Token = "0x40005CF")]
		Polygons,
		[Token(Token = "0x40005D0")]
		ConnectedPolygons,
		[Token(Token = "0x40005D1")]
		BoundaryContours
	}
	[Token(Token = "0x2000144")]
	public enum ContourOrientation
	{
		[Token(Token = "0x40005D3")]
		Original,
		[Token(Token = "0x40005D4")]
		Clockwise,
		[Token(Token = "0x40005D5")]
		CounterClockwise
	}
	[Token(Token = "0x2000145")]
	public struct ContourVertex
	{
		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vec3 Position;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public object Data;

		[Token(Token = "0x600093F")]
		[Address(RVA = "0x1C43804", Offset = "0x1C43804", VA = "0x1C43804", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000146")]
	public delegate object CombineCallback(Vec3 position, object[] data, float[] weights);
	[Token(Token = "0x2000147")]
	public static class LibTessVector3Extension
	{
		[Token(Token = "0x6000944")]
		[Address(RVA = "0x16710A8", Offset = "0x16710A8", VA = "0x16710A8")]
		public static Vec3 Vec3(this Vector3 v)
		{
			return default(Vec3);
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x16710AC", Offset = "0x16710AC", VA = "0x16710AC")]
		public static ContourVertex ContourVertex(this Vector3 v)
		{
			return default(ContourVertex);
		}
	}
	[Token(Token = "0x2000148")]
	public static class LibTessV3Extension
	{
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x16710A4", Offset = "0x16710A4", VA = "0x16710A4")]
		public static Vector3 Vector3(this Vec3 v)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000149")]
	public static class UnityLibTessUtility
	{
		[Token(Token = "0x6000947")]
		[Address(RVA = "0x1DFFE64", Offset = "0x1DFFE64", VA = "0x1DFFE64")]
		public static ContourVertex[] ToContourVertex(Vector3[] v, bool zeroZ = false)
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1DFFF54", Offset = "0x1DFFF54", VA = "0x1DFFF54")]
		public static Vector3[] FromContourVertex(ContourVertex[] v)
		{
			return null;
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x1DFFFD0", Offset = "0x1DFFFD0", VA = "0x1DFFFD0")]
		public static void SetFromContourVertex(ref Vector3[] v3Array, ref ContourVertex[] cvArray)
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0x1E00118", Offset = "0x1E00118", VA = "0x1E00118")]
		public static void SetToContourVertex(ref ContourVertex[] cvArray, ref Vector3[] v3Array)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.ImportExport
{
	[Token(Token = "0x200014A")]
	public enum CurvySerializationSpace
	{
		[Token(Token = "0x40005D9")]
		Global,
		[Token(Token = "0x40005DA")]
		Local
	}
	[Serializable]
	[Token(Token = "0x200014B")]
	public class SerializedCurvySpline
	{
		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 Position;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 Rotation;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CurvyInterpolation Interpolation;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool RestrictTo2D;

		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool Closed;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		public bool AutoEndTangents;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public CurvyOrientation Orientation;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float AutoHandleDistance;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int CacheDensity;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxPointsPerUnit;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool UsePooling;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool UseThreading;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool CheckTransform;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SerializedCurvySplineSegment[] ControlPoints;

		[Token(Token = "0x600094B")]
		[Address(RVA = "0x1DC644C", Offset = "0x1DC644C", VA = "0x1DC644C")]
		public SerializedCurvySpline()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0x1DC651C", Offset = "0x1DC651C", VA = "0x1DC651C")]
		public SerializedCurvySpline([NotNull] CurvySpline spline, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0x1DC68CC", Offset = "0x1DC68CC", VA = "0x1DC68CC")]
		public void WriteIntoSpline([NotNull] CurvySpline deserializedSpline, CurvySerializationSpace space)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014C")]
	public class SerializedCurvySplineSegment
	{
		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 Rotation;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool AutoBakeOrientation;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool OrientationAnchor;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public CurvyOrientationSwirl Swirl;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float SwirlTurns;

		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool AutoHandles;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AutoHandleDistance;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 HandleOut;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 HandleIn;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0x1DC6C34", Offset = "0x1DC6C34", VA = "0x1DC6C34")]
		public SerializedCurvySplineSegment()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0x1DC67C0", Offset = "0x1DC67C0", VA = "0x1DC67C0")]
		public SerializedCurvySplineSegment([NotNull] CurvySplineSegment segment, CurvySerializationSpace space)
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0x1DC6AE0", Offset = "0x1DC6AE0", VA = "0x1DC6AE0")]
		public void WriteIntoControlPoint([NotNull] CurvySplineSegment controlPoint, CurvySerializationSpace space)
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Controllers
{
	[Token(Token = "0x200014D")]
	public abstract class ConnectedControlPointsSelector : MonoBehaviour
	{
		[Token(Token = "0x6000951")]
		public abstract CurvySplineSegment SelectConnectedControlPoint(SplineController caller, CurvyConnection connection, CurvySplineSegment currentControlPoint);

		[Token(Token = "0x6000952")]
		[Address(RVA = "0x1C4352C", Offset = "0x1C4352C", VA = "0x1C4352C")]
		protected ConnectedControlPointsSelector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200014E")]
	public class ControllerEvent : UnityEventEx<CurvyController>
	{
		[Token(Token = "0x6000953")]
		[Address(RVA = "0x1C43BCC", Offset = "0x1C43BCC", VA = "0x1C43BCC")]
		public ControllerEvent()
		{
		}
	}
	[Token(Token = "0x200014F")]
	public class CurvyControllerEventArgs : CurvyEventArgs
	{
		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly CurvyController Controller;

		[Token(Token = "0x6000954")]
		[Address(RVA = "0x16FC79C", Offset = "0x16FC79C", VA = "0x16FC79C")]
		public CurvyControllerEventArgs(MonoBehaviour sender, CurvyController controller)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000150")]
	public class CurvySplineMoveEvent : UnityEventEx<CurvySplineMoveEventArgs>
	{
		[Token(Token = "0x6000955")]
		[Address(RVA = "0x250028C", Offset = "0x250028C", VA = "0x250028C")]
		public CurvySplineMoveEvent()
		{
		}
	}
	[Token(Token = "0x2000151")]
	public class CurvySplineMoveEventArgs : CancelEventArgs
	{
		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9588", Offset = "0x9C9588")]
		private SplineController <Sender>k__BackingField;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C9598", Offset = "0x9C9598")]
		private CurvySpline <Spline>k__BackingField;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C95A8", Offset = "0x9C95A8")]
		private CurvySplineSegment <ControlPoint>k__BackingField;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C95B8", Offset = "0x9C95B8")]
		private bool <WorldUnits>k__BackingField;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C95C8", Offset = "0x9C95C8")]
		private MovementDirection <MovementDirection>k__BackingField;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C95D8", Offset = "0x9C95D8")]
		private float <Delta>k__BackingField;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C95E8", Offset = "0x9C95E8")]
		private float <Position>k__BackingField;

		[Token(Token = "0x170001B5")]
		public SplineController Sender
		{
			[Token(Token = "0x6000956")]
			[Address(RVA = "0x25002D8", Offset = "0x25002D8", VA = "0x25002D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D26EC", Offset = "0x9D26EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000957")]
			[Address(RVA = "0x25002E0", Offset = "0x25002E0", VA = "0x25002E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D26FC", Offset = "0x9D26FC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000958")]
			[Address(RVA = "0x25002E8", Offset = "0x25002E8", VA = "0x25002E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D270C", Offset = "0x9D270C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000959")]
			[Address(RVA = "0x25002F0", Offset = "0x25002F0", VA = "0x25002F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D271C", Offset = "0x9D271C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public CurvySplineSegment ControlPoint
		{
			[Token(Token = "0x600095A")]
			[Address(RVA = "0x25002F8", Offset = "0x25002F8", VA = "0x25002F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D272C", Offset = "0x9D272C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600095B")]
			[Address(RVA = "0x2500300", Offset = "0x2500300", VA = "0x2500300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D273C", Offset = "0x9D273C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B8")]
		public bool WorldUnits
		{
			[Token(Token = "0x600095C")]
			[Address(RVA = "0x2500308", Offset = "0x2500308", VA = "0x2500308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D274C", Offset = "0x9D274C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600095D")]
			[Address(RVA = "0x2500310", Offset = "0x2500310", VA = "0x2500310")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D275C", Offset = "0x9D275C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001B9")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x600095E")]
			[Address(RVA = "0x250031C", Offset = "0x250031C", VA = "0x250031C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D276C", Offset = "0x9D276C")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x600095F")]
			[Address(RVA = "0x2500324", Offset = "0x2500324", VA = "0x2500324")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D277C", Offset = "0x9D277C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BA")]
		public float Delta
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x250032C", Offset = "0x250032C", VA = "0x250032C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D278C", Offset = "0x9D278C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x2500334", Offset = "0x2500334", VA = "0x2500334")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D279C", Offset = "0x9D279C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001BB")]
		public float Position
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x250033C", Offset = "0x250033C", VA = "0x250033C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D27AC", Offset = "0x9D27AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x2500344", Offset = "0x2500344", VA = "0x2500344")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D27BC", Offset = "0x9D27BC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x250034C", Offset = "0x250034C", VA = "0x250034C")]
		public CurvySplineMoveEventArgs(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, bool usingWorldUnits, float delta, MovementDirection direction)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x25003C4", Offset = "0x25003C4", VA = "0x25003C4")]
		internal void Set_INTERNAL(SplineController sender, CurvySpline spline, CurvySplineSegment controlPoint, float position, float delta, MovementDirection direction, bool usingWorldUnits)
		{
		}
	}
	[Token(Token = "0x2000152")]
	[ExecuteInEditMode]
	public abstract class CurvyController : DTVersionedMonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000153")]
		public enum MoveModeEnum
		{
			[Token(Token = "0x4000618")]
			Relative,
			[Token(Token = "0x4000619")]
			AbsolutePrecise
		}

		[Token(Token = "0x2000154")]
		public enum CurvyControllerState
		{
			[Token(Token = "0x400061B")]
			Stopped,
			[Token(Token = "0x400061C")]
			Playing,
			[Token(Token = "0x400061D")]
			Paused
		}

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C95F8", Offset = "0x9C95F8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C95F8", Offset = "0x9C95F8")]
		public CurvyUpdateMethod UpdateIn;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C9690", Offset = "0x9C9690")]
		[SerializeField]
		private CurvyPositionMode m_PositionMode;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9C9714", Offset = "0x9C9714")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9C9714", Offset = "0x9C9714")]
		protected float m_Position;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C97B8", Offset = "0x9C97B8")]
		private MoveModeEnum m_MoveMode;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Positive]
		private float m_Speed;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private MovementDirection m_Direction;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyClamping m_Clamping;

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C988C", Offset = "0x9C988C")]
		[SerializeField]
		private bool m_PlayAutomatically;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C98D8", Offset = "0x9C98D8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C98D8", Offset = "0x9C98D8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C98D8", Offset = "0x9C98D8")]
		[SerializeField]
		private OrientationModeEnum m_OrientationMode;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C9A20", Offset = "0x9C9A20")]
		[SerializeField]
		private bool m_LockRotation;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9C9A88", Offset = "0x9C9A88")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9A88", Offset = "0x9C9A88")]
		[SerializeField]
		private OrientationAxisEnum m_OrientationAxis;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9BC4", Offset = "0x9C9BC4")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9C9BC4", Offset = "0x9C9BC4")]
		private bool m_IgnoreDirection;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x9C9CEC", Offset = "0x9C9CEC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9CEC", Offset = "0x9C9CEC")]
		[SerializeField]
		private float m_DampingDirection;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		[AttributeAttribute(Name = "MinAttribute", RVA = "0x9C9DE4", Offset = "0x9C9DE4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9DE4", Offset = "0x9C9DE4")]
		private float m_DampingUp;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9C9ED4", Offset = "0x9C9ED4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9C9ED4", Offset = "0x9C9ED4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9C9ED4", Offset = "0x9C9ED4")]
		private float m_OffsetAngle;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA074", Offset = "0x9CA074")]
		[SerializeField]
		private float m_OffsetRadius;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA178", Offset = "0x9CA178")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA178", Offset = "0x9CA178")]
		[SerializeField]
		private bool m_OffsetCompensation;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CA2B4", Offset = "0x9CA2B4")]
		private ControllerEvent onInitialized;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CA318", Offset = "0x9CA318")]
		private bool <isInitialized>k__BackingField;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private CurvyControllerState state;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 directionDampingVelocity;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 upDampingVelocity;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float prePlayPosition;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion lockedRotation;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private MovementDirection prePlayDirection;

		[Token(Token = "0x4000616")]
		protected const string ControllerNotReadyMessage = "The controller is not yet ready";

		[Token(Token = "0x170001BC")]
		public ControllerEvent OnInitialized
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x16FA92C", Offset = "0x16FA92C", VA = "0x16FA92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001BD")]
		public CurvyPositionMode PositionMode
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x16FA934", Offset = "0x16FA934", VA = "0x16FA934")]
			get
			{
				return default(CurvyPositionMode);
			}
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x16FA93C", Offset = "0x16FA93C", VA = "0x16FA93C")]
			set
			{
			}
		}

		[Token(Token = "0x170001BE")]
		public MoveModeEnum MoveMode
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x16FA944", Offset = "0x16FA944", VA = "0x16FA944")]
			get
			{
				return default(MoveModeEnum);
			}
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x16FA94C", Offset = "0x16FA94C", VA = "0x16FA94C")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public bool PlayAutomatically
		{
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x16FA960", Offset = "0x16FA960", VA = "0x16FA960")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x16FA968", Offset = "0x16FA968", VA = "0x16FA968")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public CurvyClamping Clamping
		{
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x16FA988", Offset = "0x16FA988", VA = "0x16FA988")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x16FA990", Offset = "0x16FA990", VA = "0x16FA990")]
			set
			{
			}
		}

		[Token(Token = "0x170001C1")]
		public OrientationModeEnum OrientationMode
		{
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x16FA9A4", Offset = "0x16FA9A4", VA = "0x16FA9A4")]
			get
			{
				return default(OrientationModeEnum);
			}
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x16FA9AC", Offset = "0x16FA9AC", VA = "0x16FA9AC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C2")]
		public bool LockRotation
		{
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x16FA9C0", Offset = "0x16FA9C0", VA = "0x16FA9C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x16FA9C8", Offset = "0x16FA9C8", VA = "0x16FA9C8")]
			set
			{
			}
		}

		[Token(Token = "0x170001C3")]
		public OrientationAxisEnum OrientationAxis
		{
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x16FAA30", Offset = "0x16FAA30", VA = "0x16FAA30")]
			get
			{
				return default(OrientationAxisEnum);
			}
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x16FAA38", Offset = "0x16FAA38", VA = "0x16FAA38")]
			set
			{
			}
		}

		[Token(Token = "0x170001C4")]
		public float DirectionDampingTime
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x16FAA4C", Offset = "0x16FAA4C", VA = "0x16FAA4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x16FAA54", Offset = "0x16FAA54", VA = "0x16FAA54")]
			set
			{
			}
		}

		[Token(Token = "0x170001C5")]
		public float UpDampingTime
		{
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x16FAA90", Offset = "0x16FAA90", VA = "0x16FAA90")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x16FAA98", Offset = "0x16FAA98", VA = "0x16FAA98")]
			set
			{
			}
		}

		[Token(Token = "0x170001C6")]
		public bool IgnoreDirection
		{
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x16FAAD4", Offset = "0x16FAAD4", VA = "0x16FAAD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600097A")]
			[Address(RVA = "0x16FAADC", Offset = "0x16FAADC", VA = "0x16FAADC")]
			set
			{
			}
		}

		[Token(Token = "0x170001C7")]
		public float OffsetAngle
		{
			[Token(Token = "0x600097B")]
			[Address(RVA = "0x16FAAFC", Offset = "0x16FAAFC", VA = "0x16FAAFC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600097C")]
			[Address(RVA = "0x16FAB04", Offset = "0x16FAB04", VA = "0x16FAB04")]
			set
			{
			}
		}

		[Token(Token = "0x170001C8")]
		public float OffsetRadius
		{
			[Token(Token = "0x600097D")]
			[Address(RVA = "0x16FAB18", Offset = "0x16FAB18", VA = "0x16FAB18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600097E")]
			[Address(RVA = "0x16FAB20", Offset = "0x16FAB20", VA = "0x16FAB20")]
			set
			{
			}
		}

		[Token(Token = "0x170001C9")]
		public bool OffsetCompensation
		{
			[Token(Token = "0x600097F")]
			[Address(RVA = "0x16FAB34", Offset = "0x16FAB34", VA = "0x16FAB34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000980")]
			[Address(RVA = "0x16FAB3C", Offset = "0x16FAB3C", VA = "0x16FAB3C")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public float Speed
		{
			[Token(Token = "0x6000981")]
			[Address(RVA = "0x16FAB48", Offset = "0x16FAB48", VA = "0x16FAB48")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000982")]
			[Address(RVA = "0x16FAB50", Offset = "0x16FAB50", VA = "0x16FAB50")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public float RelativePosition
		{
			[Token(Token = "0x6000983")]
			[Address(RVA = "0x16FAB64", Offset = "0x16FAB64", VA = "0x16FAB64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000984")]
			[Address(RVA = "0x16FACA8", Offset = "0x16FACA8", VA = "0x16FACA8")]
			set
			{
			}
		}

		[Token(Token = "0x170001CC")]
		public float AbsolutePosition
		{
			[Token(Token = "0x6000985")]
			[Address(RVA = "0x16FAD50", Offset = "0x16FAD50", VA = "0x16FAD50")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000986")]
			[Address(RVA = "0x16FAE30", Offset = "0x16FAE30", VA = "0x16FAE30")]
			set
			{
			}
		}

		[Token(Token = "0x170001CD")]
		public float Position
		{
			[Token(Token = "0x6000987")]
			[Address(RVA = "0x16FAEDC", Offset = "0x16FAEDC", VA = "0x16FAEDC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000988")]
			[Address(RVA = "0x16FAF34", Offset = "0x16FAF34", VA = "0x16FAF34")]
			set
			{
			}
		}

		[Token(Token = "0x170001CE")]
		public MovementDirection MovementDirection
		{
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x16FAF8C", Offset = "0x16FAF8C", VA = "0x16FAF8C")]
			get
			{
				return default(MovementDirection);
			}
			[Token(Token = "0x600098A")]
			[Address(RVA = "0x16FAF94", Offset = "0x16FAF94", VA = "0x16FAF94")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public CurvyControllerState PlayState
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x16FAF9C", Offset = "0x16FAF9C", VA = "0x16FAF9C")]
			get
			{
				return default(CurvyControllerState);
			}
		}

		[Token(Token = "0x170001D0")]
		public abstract bool IsReady
		{
			[Token(Token = "0x600098C")]
			get;
		}

		[Token(Token = "0x170001D1")]
		protected bool isInitialized
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x16FAFA4", Offset = "0x16FAFA4", VA = "0x16FAFA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D27CC", Offset = "0x9D27CC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x16FAFAC", Offset = "0x16FAFAC", VA = "0x16FAFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D27DC", Offset = "0x9D27DC")]
			private set
			{
			}
		}

		[Token(Token = "0x170001D2")]
		public virtual Transform Transform
		{
			[Token(Token = "0x6000996")]
			[Address(RVA = "0x16FB340", Offset = "0x16FB340", VA = "0x16FB340", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D3")]
		protected virtual bool ShowOrientationSection
		{
			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x16FBF34", Offset = "0x16FBF34", VA = "0x16FBF34", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D4")]
		protected virtual bool ShowOffsetSection
		{
			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x16FBF3C", Offset = "0x16FBF3C", VA = "0x16FBF3C", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D5")]
		public abstract float Length
		{
			[Token(Token = "0x60009A4")]
			get;
		}

		[Token(Token = "0x170001D6")]
		private float maxPosition
		{
			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x16FC6A0", Offset = "0x16FC6A0", VA = "0x16FC6A0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x16FAFB8", Offset = "0x16FAFB8", VA = "0x16FAFB8", Slot = "8")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x16FB020", Offset = "0x16FB020", VA = "0x16FB020", Slot = "9")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x16FB0FC", Offset = "0x16FB0FC", VA = "0x16FB0FC", Slot = "10")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x16FB118", Offset = "0x16FB118", VA = "0x16FB118", Slot = "11")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x16FB210", Offset = "0x16FB210", VA = "0x16FB210", Slot = "12")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x16FB25C", Offset = "0x16FB25C", VA = "0x16FB25C", Slot = "13")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x16FB2A8", Offset = "0x16FB2A8", VA = "0x16FB2A8", Slot = "14")]
		protected virtual void Reset()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x16FB348", Offset = "0x16FB348", VA = "0x16FB348", Slot = "16")]
		protected virtual void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x16FB8AC", Offset = "0x16FB8AC", VA = "0x16FB8AC", Slot = "17")]
		protected virtual void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0x16FBC6C", Offset = "0x16FBC6C", VA = "0x16FBC6C")]
		private void GetOrientationNoneUpAndForward(out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0x16FBE08", Offset = "0x16FBE08", VA = "0x16FBE08", Slot = "18")]
		protected virtual void Initialize()
		{
		}

		[Token(Token = "0x600099B")]
		[Address(RVA = "0x16FBECC", Offset = "0x16FBECC", VA = "0x16FBECC", Slot = "19")]
		protected virtual void Deinitialize()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0x16FBEFC", Offset = "0x16FBEFC", VA = "0x16FBEFC", Slot = "20")]
		protected virtual void BindEvents()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0x16FBF00", Offset = "0x16FBF00", VA = "0x16FBF00", Slot = "21")]
		protected virtual void UnbindEvents()
		{
		}

		[Token(Token = "0x600099E")]
		[Address(RVA = "0x16FBF04", Offset = "0x16FBF04", VA = "0x16FBF04", Slot = "22")]
		protected virtual void SavePrePlayState()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0x16FBF18", Offset = "0x16FBF18", VA = "0x16FBF18", Slot = "23")]
		protected virtual void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0x16FBF2C", Offset = "0x16FBF2C", VA = "0x16FBF2C", Slot = "24")]
		protected virtual void UserAfterInit()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0x16FBF30", Offset = "0x16FBF30", VA = "0x16FBF30", Slot = "25")]
		protected virtual void UserAfterUpdate()
		{
		}

		[Token(Token = "0x60009A5")]
		protected abstract void Advance(float speed, float deltaTime);

		[Token(Token = "0x60009A6")]
		protected abstract void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime);

		[Token(Token = "0x60009A7")]
		protected abstract float AbsoluteToRelative(float worldUnitDistance);

		[Token(Token = "0x60009A8")]
		protected abstract float RelativeToAbsolute(float relativeDistance);

		[Token(Token = "0x60009A9")]
		protected abstract Vector3 GetInterpolatedSourcePosition(float tf);

		[Token(Token = "0x60009AA")]
		protected abstract void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up);

		[Token(Token = "0x60009AB")]
		protected abstract Vector3 GetOrientation(float tf);

		[Token(Token = "0x60009AC")]
		protected abstract Vector3 GetTangent(float tf);

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x16FB0BC", Offset = "0x16FB0BC", VA = "0x16FB0BC")]
		public void Play()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x16FBF44", Offset = "0x16FBF44", VA = "0x16FBF44")]
		public void Stop()
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x16FBF80", Offset = "0x16FBF80", VA = "0x16FBF80")]
		public void Pause()
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0x16FBF98", Offset = "0x16FBF98", VA = "0x16FBF98")]
		public void Refresh()
		{
		}

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0x16FB160", Offset = "0x16FB160", VA = "0x16FB160")]
		public void ApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0x16FBFA0", Offset = "0x16FBFA0", VA = "0x16FBFA0")]
		public void TeleportTo(float newPosition)
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0x16FC020", Offset = "0x16FC020", VA = "0x16FC020")]
		public void TeleportBy(float distance, MovementDirection direction)
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0x16FC084", Offset = "0x16FC084", VA = "0x16FC084")]
		public void SetFromString(string fieldAndValue)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0x16FC660", Offset = "0x16FC660", VA = "0x16FC660")]
		private void editorUpdate()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0x16FBD78", Offset = "0x16FBD78", VA = "0x16FBD78")]
		private static Vector3 ApplyOffset(Vector3 pos, Vector3 tan, Vector3 up, float angle, float radius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0x16FAC44", Offset = "0x16FAC44", VA = "0x16FAC44")]
		protected static float GetClampedPosition(float position, CurvyPositionMode positionMode, CurvyClamping clampingMode, float length)
		{
			return default(float);
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0x16FB6A0", Offset = "0x16FB6A0", VA = "0x16FB6A0")]
		private float ComputeOffsetCompensatedSpeed(float deltaTime)
		{
			return default(float);
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0x16FC734", Offset = "0x16FC734", VA = "0x16FC734", Slot = "37")]
		public virtual void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0x16FC774", Offset = "0x16FC774", VA = "0x16FC774", Slot = "5")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0x16FC778", Offset = "0x16FC778", VA = "0x16FC778")]
		protected CurvyController()
		{
		}
	}
	[Token(Token = "0x2000155")]
	public enum MovementDirection
	{
		[Token(Token = "0x400061F")]
		Forward,
		[Token(Token = "0x4000620")]
		Backward
	}
	[Token(Token = "0x2000156")]
	public static class MovementDirectionMethods
	{
		[Token(Token = "0x60009BD")]
		[Address(RVA = "0x1676910", Offset = "0x1676910", VA = "0x1676910")]
		public static MovementDirection FromInt(int value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0x1676918", Offset = "0x1676918", VA = "0x1676918")]
		public static MovementDirection GetOpposite(this MovementDirection value)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0x1676974", Offset = "0x1676974", VA = "0x1676974")]
		public static int ToInt(this MovementDirection direction)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000157")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C3F14", Offset = "0x9C3F14")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3F14", Offset = "0x9C3F14")]
	public class PathController : CurvyController
	{
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CA328", Offset = "0x9CA328")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x9CA328", Offset = "0x9CA328")]
		[SerializeField]
		private CGDataReference m_Path;

		[Token(Token = "0x170001D7")]
		public CGDataReference Path
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x167B6F0", Offset = "0x167B6F0", VA = "0x167B6F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x167B6F8", Offset = "0x167B6F8", VA = "0x167B6F8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public CGPath PathData
		{
			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x167B700", Offset = "0x167B700", VA = "0x167B700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001D9")]
		public override float Length
		{
			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x167B774", Offset = "0x167B774", VA = "0x167B774", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001DA")]
		public override bool IsReady
		{
			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x167B7B4", Offset = "0x167B7B4", VA = "0x167B7B4", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009C5")]
		[Address(RVA = "0x167B804", Offset = "0x167B804", VA = "0x167B804", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60009C6")]
		[Address(RVA = "0x167B860", Offset = "0x167B860", VA = "0x167B860", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60009C7")]
		[Address(RVA = "0x167B8BC", Offset = "0x167B8BC", VA = "0x167B8BC", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009C8")]
		[Address(RVA = "0x167B930", Offset = "0x167B930", VA = "0x167B930", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60009C9")]
		[Address(RVA = "0x167BA08", Offset = "0x167BA08", VA = "0x167BA08", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009CA")]
		[Address(RVA = "0x167BA7C", Offset = "0x167BA7C", VA = "0x167BA7C", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x167BAF0", Offset = "0x167BAF0", VA = "0x167BAF0", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0x167BB6C", Offset = "0x167BB6C", VA = "0x167BB6C", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0x167BC58", Offset = "0x167BC58", VA = "0x167BC58")]
		public PathController()
		{
		}
	}
	[Token(Token = "0x2000158")]
	public enum SplineControllerConnectionBehavior
	{
		[Token(Token = "0x4000623")]
		CurrentSpline,
		[Token(Token = "0x4000624")]
		FollowUpSpline,
		[Token(Token = "0x4000625")]
		RandomSpline,
		[Token(Token = "0x4000626")]
		FollowUpOtherwiseRandom,
		[Token(Token = "0x4000627")]
		Custom
	}
	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3F78", Offset = "0x9C3F78")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C3F78", Offset = "0x9C3F78")]
	public class SplineController : CurvyController
	{
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CA3E8", Offset = "0x9CA3E8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA3E8", Offset = "0x9CA3E8")]
		protected CurvySpline m_Spline;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CA48C", Offset = "0x9CA48C")]
		private bool m_UseCache;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CA4D8", Offset = "0x9CA4D8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA4D8", Offset = "0x9CA4D8")]
		private SplineControllerConnectionBehavior connectionBehavior;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA58C", Offset = "0x9CA58C")]
		[SerializeField]
		private bool allowDirectionChange;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA5F4", Offset = "0x9CA5F4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA5F4", Offset = "0x9CA5F4")]
		private bool rejectCurrentSpline;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA6DC", Offset = "0x9CA6DC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA6DC", Offset = "0x9CA6DC")]
		[SerializeField]
		private bool rejectTooDivergentSplines;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA7C4", Offset = "0x9CA7C4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9CA7C4", Offset = "0x9CA7C4")]
		private float maxAllowedDivergenceAngle;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA848", Offset = "0x9CA848")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CA848", Offset = "0x9CA848")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CA848", Offset = "0x9CA848")]
		[SerializeField]
		private ConnectedControlPointsSelector connectionCustomSelector;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CA978", Offset = "0x9CA978")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnControlPointReached;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnEndReached;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private CurvySplineMoveEvent m_OnSwitch;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CAA0C", Offset = "0x9CAA0C")]
		private bool <IsSwitching>k__BackingField;

		[Token(Token = "0x4000634")]
		private const float StepSize = 0.002f;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private CurvySpline prePlaySpline;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float switchStartTime;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float switchDuration;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CurvySpline switchTarget;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float tfOnSwitchTarget;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private MovementDirection directionOnSwitchTarget;

		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private readonly CurvySplineMoveEventArgs preAllocatedEventArgs;

		[Token(Token = "0x170001DB")]
		public virtual CurvySpline Spline
		{
			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x1DC8544", Offset = "0x1DC8544", VA = "0x1DC8544", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1DC854C", Offset = "0x1DC854C", VA = "0x1DC854C", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public bool UseCache
		{
			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1DC8554", Offset = "0x1DC8554", VA = "0x1DC8554")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1DC855C", Offset = "0x1DC855C", VA = "0x1DC855C")]
			set
			{
			}
		}

		[Token(Token = "0x170001DD")]
		public SplineControllerConnectionBehavior ConnectionBehavior
		{
			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x1DC857C", Offset = "0x1DC857C", VA = "0x1DC857C")]
			get
			{
				return default(SplineControllerConnectionBehavior);
			}
			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1DC8584", Offset = "0x1DC8584", VA = "0x1DC8584")]
			set
			{
			}
		}

		[Token(Token = "0x170001DE")]
		public ConnectedControlPointsSelector ConnectionCustomSelector
		{
			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x1DC858C", Offset = "0x1DC858C", VA = "0x1DC858C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1DC8594", Offset = "0x1DC8594", VA = "0x1DC8594")]
			set
			{
			}
		}

		[Token(Token = "0x170001DF")]
		public bool AllowDirectionChange
		{
			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x1DC859C", Offset = "0x1DC859C", VA = "0x1DC859C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1DC85A4", Offset = "0x1DC85A4", VA = "0x1DC85A4")]
			set
			{
			}
		}

		[Token(Token = "0x170001E0")]
		public bool RejectCurrentSpline
		{
			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1DC85B0", Offset = "0x1DC85B0", VA = "0x1DC85B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x1DC85B8", Offset = "0x1DC85B8", VA = "0x1DC85B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public bool RejectTooDivergentSplines
		{
			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x1DC85C4", Offset = "0x1DC85C4", VA = "0x1DC85C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1DC85CC", Offset = "0x1DC85CC", VA = "0x1DC85CC")]
			set
			{
			}
		}

		[Token(Token = "0x170001E2")]
		public float MaxAllowedDivergenceAngle
		{
			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x1DC85D8", Offset = "0x1DC85D8", VA = "0x1DC85D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1DC85E0", Offset = "0x1DC85E0", VA = "0x1DC85E0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public CurvySplineMoveEvent OnControlPointReached
		{
			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1DC85E8", Offset = "0x1DC85E8", VA = "0x1DC85E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1DC85F0", Offset = "0x1DC85F0", VA = "0x1DC85F0")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public CurvySplineMoveEvent OnEndReached
		{
			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x1DC85F8", Offset = "0x1DC85F8", VA = "0x1DC85F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1DC8600", Offset = "0x1DC8600", VA = "0x1DC8600")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public CurvySplineMoveEvent OnSwitch
		{
			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1DC8608", Offset = "0x1DC8608", VA = "0x1DC8608")]
			get
			{
				return null;
			}
			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1DC8610", Offset = "0x1DC8610", VA = "0x1DC8610")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public bool IsSwitching
		{
			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1DC8618", Offset = "0x1DC8618", VA = "0x1DC8618")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D280C", Offset = "0x9D280C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1DC8620", Offset = "0x1DC8620", VA = "0x1DC8620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D281C", Offset = "0x9D281C")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public override float Length
		{
			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x1DC862C", Offset = "0x1DC862C", VA = "0x1DC862C", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001E8")]
		private float SwitchProgress
		{
			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x1DC86E4", Offset = "0x1DC86E4", VA = "0x1DC86E4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001E9")]
		public override bool IsReady
		{
			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1DC8958", Offset = "0x1DC8958", VA = "0x1DC8958", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001EA")]
		private bool ShowRandomConnectionOptions
		{
			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1DCA93C", Offset = "0x1DCA93C", VA = "0x1DCA93C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0x1DC8480", Offset = "0x1DC8480", VA = "0x1DC8480")]
		public SplineController()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0x1DC8728", Offset = "0x1DC8728", VA = "0x1DC8728", Slot = "40")]
		public virtual void SwitchTo(CurvySpline destinationSpline, float destinationTf, float duration)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0x1DC87DC", Offset = "0x1DC87DC", VA = "0x1DC87DC")]
		public void FinishCurrentSwitch()
		{
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0x1DC8828", Offset = "0x1DC8828", VA = "0x1DC8828")]
		public void CancelCurrentSwitch()
		{
		}

		[Token(Token = "0x60009EC")]
		[Address(RVA = "0x1DC8838", Offset = "0x1DC8838", VA = "0x1DC8838")]
		public static float GetAngleBetweenConnectedSplines(CurvySplineSegment before, MovementDirection movementMode, CurvySplineSegment after, bool allowMovementModeChange)
		{
			return default(float);
		}

		[Token(Token = "0x60009EE")]
		[Address(RVA = "0x1DC8A14", Offset = "0x1DC8A14", VA = "0x1DC8A14", Slot = "22")]
		protected override void SavePrePlayState()
		{
		}

		[Token(Token = "0x60009EF")]
		[Address(RVA = "0x1DC8A5C", Offset = "0x1DC8A5C", VA = "0x1DC8A5C", Slot = "23")]
		protected override void RestorePrePlayState()
		{
		}

		[Token(Token = "0x60009F0")]
		[Address(RVA = "0x1DC8A94", Offset = "0x1DC8A94", VA = "0x1DC8A94", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60009F1")]
		[Address(RVA = "0x1DC8AE0", Offset = "0x1DC8AE0", VA = "0x1DC8AE0", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0x1DC8B2C", Offset = "0x1DC8B2C", VA = "0x1DC8B2C", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x1DC8BD0", Offset = "0x1DC8BD0", VA = "0x1DC8BD0", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x1DC8D44", Offset = "0x1DC8D44", VA = "0x1DC8D44", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x1DC8DE8", Offset = "0x1DC8DE8", VA = "0x1DC8DE8", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x1DC8E64", Offset = "0x1DC8E64", VA = "0x1DC8E64", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x1DC9AB8", Offset = "0x1DC9AB8", VA = "0x1DC9AB8", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x1DC9978", Offset = "0x1DC9978", VA = "0x1DC9978")]
		private void SimulateAdvanceOnSpline(ref float tf, ref MovementDirection curyDirection, CurvySpline spline, float distance)
		{
		}

		[Token(Token = "0x60009F9")]
		[Address(RVA = "0x1DC9B1C", Offset = "0x1DC9B1C", VA = "0x1DC9B1C", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x60009FA")]
		[Address(RVA = "0x1DC9BC8", Offset = "0x1DC9BC8", VA = "0x1DC9BC8", Slot = "17")]
		protected override void ComputeTargetPositionAndRotation(out Vector3 targetPosition, out Vector3 targetUp, out Vector3 targetForward)
		{
		}

		[Token(Token = "0x60009FB")]
		[Address(RVA = "0x1DC9E58", Offset = "0x1DC9E58", VA = "0x1DC9E58")]
		private static float MovementCompatibleGetPosition(SplineController controller, CurvyPositionMode positionMode, out CurvySplineSegment controlPoint, out bool isOnControlPoint)
		{
			return default(float);
		}

		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x1DCA104", Offset = "0x1DCA104", VA = "0x1DCA104")]
		private static void MovementCompatibleSetPosition(SplineController controller, CurvyPositionMode positionMode, float position)
		{
		}

		[Token(Token = "0x60009FD")]
		[Address(RVA = "0x1DC8FA0", Offset = "0x1DC8FA0", VA = "0x1DC8FA0")]
		private void EventAwareMove(float distance)
		{
		}

		[Token(Token = "0x60009FE")]
		[Address(RVA = "0x1DCA258", Offset = "0x1DCA258", VA = "0x1DCA258")]
		private CurvySplineSegment GetCurrentControlPoint(out bool isOnControlPoint, out float position, CurvyPositionMode positionMode)
		{
			return null;
		}

		[Token(Token = "0x60009FF")]
		[Address(RVA = "0x1DCA370", Offset = "0x1DCA370", VA = "0x1DCA370")]
		private void HandleReachingNewControlPoint(CurvySplineSegment newControlPoint, CurvyPositionMode positionMode, float currentDelta, ref bool cancelMovement)
		{
		}

		[Token(Token = "0x6000A00")]
		[Address(RVA = "0x1DCA688", Offset = "0x1DCA688", VA = "0x1DCA688")]
		private CurvySplineSegment HandleRandomConnectionBehavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection, ReadOnlyCollection<CurvySplineSegment> connectedControlPoints)
		{
			return null;
		}

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0x1DC8910", Offset = "0x1DC8910", VA = "0x1DC8910")]
		private static MovementDirection GetPostConnectionDirection(CurvySplineSegment connectedControlPoint, MovementDirection currentDirection, bool directionChangeAllowed)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0x1DCA59C", Offset = "0x1DCA59C", VA = "0x1DCA59C")]
		private CurvySplineSegment HandleFolloUpConnectionBahavior(CurvySplineSegment currentControlPoint, MovementDirection currentDirection, out MovementDirection newDirection)
		{
			return null;
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0x1DCA8C0", Offset = "0x1DCA8C0", VA = "0x1DCA8C0")]
		private static MovementDirection HeadingToDirection(ConnectionHeadingEnum heading, CurvySplineSegment controlPoint, MovementDirection currentDirection)
		{
			return default(MovementDirection);
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0x1DCA294", Offset = "0x1DCA294", VA = "0x1DCA294")]
		private static float GetControlPointPosition(CurvySplineSegment controlPoint, CurvyPositionMode positionMode, MovementDirection movementDirection)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200015A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C3FDC", Offset = "0x9C3FDC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C3FDC", Offset = "0x9C3FDC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C3FDC", Offset = "0x9C3FDC")]
	public class UITextSplineController : SplineController, IMeshModifier
	{
		[Token(Token = "0x200015B")]
		protected class GlyphQuad
		{
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UIVertex[] V;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x170001F2")]
			public Vector3 Center
			{
				[Token(Token = "0x6000A1A")]
				[Address(RVA = "0x1DFF60C", Offset = "0x1DFF60C", VA = "0x1DFF60C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1E0E470", Offset = "0x1E0E470", VA = "0x1E0E470")]
			public void Load(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1DFF3F4", Offset = "0x1DFF3F4", VA = "0x1DFF3F4")]
			public void LoadTris(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1E0E688", Offset = "0x1E0E688", VA = "0x1E0E688")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1E0E6FC", Offset = "0x1E0E6FC", VA = "0x1E0E6FC")]
			public void Save(List<UIVertex> verts, int index)
			{
			}

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1DFF79C", Offset = "0x1DFF79C", VA = "0x1DFF79C")]
			public void Save(VertexHelper vh)
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1DFF62C", Offset = "0x1DFF62C", VA = "0x1DFF62C")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1DFF69C", Offset = "0x1DFF69C", VA = "0x1DFF69C")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x1DFF38C", Offset = "0x1DFF38C", VA = "0x1DFF38C")]
			public GlyphQuad()
			{
			}
		}

		[Token(Token = "0x200015C")]
		protected class GlyphPlain
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] V;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rect Rect;

			[Token(Token = "0x170001F3")]
			public Vector3 Center
			{
				[Token(Token = "0x6000A23")]
				[Address(RVA = "0x1DFEDB4", Offset = "0x1DFEDB4", VA = "0x1DFEDB4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1DFEC7C", Offset = "0x1DFEC7C", VA = "0x1DFEC7C")]
			public void Load(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1E0E3FC", Offset = "0x1E0E3FC", VA = "0x1E0E3FC")]
			public void calcRect()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1DFEF44", Offset = "0x1DFEF44", VA = "0x1DFEF44")]
			public void Save(ref Vector3[] verts, int index)
			{
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1DFEDD4", Offset = "0x1DFEDD4", VA = "0x1DFEDD4")]
			public void Transpose(Vector3 v)
			{
			}

			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x1DFEE44", Offset = "0x1DFEE44", VA = "0x1DFEE44")]
			public void Rotate(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1DFEC14", Offset = "0x1DFEC14", VA = "0x1DFEC14")]
			public GlyphPlain()
			{
			}
		}

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CAA1C", Offset = "0x9CAA1C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CAA1C", Offset = "0x9CAA1C")]
		private bool staticOrientation;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Graphic m_Graphic;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RectTransform mRect;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private Text mText;

		[Token(Token = "0x170001EB")]
		public bool StaticOrientation
		{
			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1DFE6B4", Offset = "0x1DFE6B4", VA = "0x1DFE6B4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x1DFE6BC", Offset = "0x1DFE6BC", VA = "0x1DFE6BC")]
			set
			{
			}
		}

		[Token(Token = "0x170001EC")]
		protected override bool ShowOrientationSection
		{
			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1DFE6C8", Offset = "0x1DFE6C8", VA = "0x1DFE6C8", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001ED")]
		protected override bool ShowOffsetSection
		{
			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x1DFE6D0", Offset = "0x1DFE6D0", VA = "0x1DFE6D0", Slot = "27")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001EE")]
		protected Text Text
		{
			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x1DFE6D8", Offset = "0x1DFE6D8", VA = "0x1DFE6D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EF")]
		protected RectTransform Rect
		{
			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x1DFE78C", Offset = "0x1DFE78C", VA = "0x1DFE78C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F0")]
		protected Graphic graphic
		{
			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1DFE840", Offset = "0x1DFE840", VA = "0x1DFE840")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F1")]
		public override CurvySpline Spline
		{
			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1DFF928", Offset = "0x1DFF928", VA = "0x1DFF928", Slot = "38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1DFF930", Offset = "0x1DFF930", VA = "0x1DFF930", Slot = "39")]
			set
			{
			}
		}

		[Token(Token = "0x6000A0D")]
		[Address(RVA = "0x1DFE8F4", Offset = "0x1DFE8F4", VA = "0x1DFE8F4", Slot = "16")]
		protected override void InitializedApplyDeltaTime(float deltaTime)
		{
		}

		[Token(Token = "0x6000A0E")]
		[Address(RVA = "0x1DFE934", Offset = "0x1DFE934", VA = "0x1DFE934", Slot = "41")]
		public void ModifyMesh(Mesh verts)
		{
		}

		[Token(Token = "0x6000A0F")]
		[Address(RVA = "0x1DFF07C", Offset = "0x1DFF07C", VA = "0x1DFF07C", Slot = "42")]
		public void ModifyMesh(VertexHelper vertexHelper)
		{
		}

		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x1DFF7C0", Offset = "0x1DFF7C0", VA = "0x1DFF7C0", Slot = "8")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x1DFF874", Offset = "0x1DFF874", VA = "0x1DFF874", Slot = "10")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x1DFFC70", Offset = "0x1DFFC70", VA = "0x1DFFC70", Slot = "20")]
		protected override void BindEvents()
		{
		}

		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x1DFFC98", Offset = "0x1DFFC98", VA = "0x1DFFC98", Slot = "21")]
		protected override void UnbindEvents()
		{
		}

		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x1DFFB2C", Offset = "0x1DFFB2C", VA = "0x1DFFB2C")]
		private void BindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x1DFF9F0", Offset = "0x1DFF9F0", VA = "0x1DFF9F0")]
		private void UnbindSplineRelatedEvents()
		{
		}

		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x1DFFCC0", Offset = "0x1DFFCC0", VA = "0x1DFFCC0")]
		private void OnSplineRefreshed(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x1DFFE5C", Offset = "0x1DFFE5C", VA = "0x1DFFE5C")]
		public UITextSplineController()
		{
		}
	}
	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4084", Offset = "0x9C4084")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4084", Offset = "0x9C4084")]
	public class VolumeController : CurvyController
	{
		[Token(Token = "0x4000644")]
		private const float CrossPositionRangeMin = -0.5f;

		[Token(Token = "0x4000645")]
		private const float CrossPositionRangeMax = 0.5f;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "CGDataReferenceSelectorAttribute", RVA = "0x9CAA98", Offset = "0x9CAA98")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CAA98", Offset = "0x9CAA98")]
		private CGDataReference m_Volume;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[FloatRegion]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CAB54", Offset = "0x9CAB54")]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CAC1C", Offset = "0x9CAC1C")]
		[SerializeField]
		private float crossRelativePosition;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private CurvyClamping m_CrossClamping;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[HideInInspector]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x9CACC4", Offset = "0x9CACC4")]
		private float m_CrossInitialPosition;

		[Token(Token = "0x170001F4")]
		public CGDataReference Volume
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x1E033B0", Offset = "0x1E033B0", VA = "0x1E033B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x1E033B8", Offset = "0x1E033B8", VA = "0x1E033B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001F5")]
		public CGVolume VolumeData
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x1E033C0", Offset = "0x1E033C0", VA = "0x1E033C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001F6")]
		public float CrossFrom
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1E03434", Offset = "0x1E03434", VA = "0x1E03434")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x1E0343C", Offset = "0x1E0343C", VA = "0x1E0343C")]
			set
			{
			}
		}

		[Token(Token = "0x170001F7")]
		public float CrossTo
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x1E0346C", Offset = "0x1E0346C", VA = "0x1E0346C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1E03474", Offset = "0x1E03474", VA = "0x1E03474")]
			set
			{
			}
		}

		[Token(Token = "0x170001F8")]
		public float CrossLength
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x1E034A4", Offset = "0x1E034A4", VA = "0x1E034A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001F9")]
		public CurvyClamping CrossClamping
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x1E034B0", Offset = "0x1E034B0", VA = "0x1E034B0")]
			get
			{
				return default(CurvyClamping);
			}
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x1E034B8", Offset = "0x1E034B8", VA = "0x1E034B8")]
			set
			{
			}
		}

		[Token(Token = "0x170001FA")]
		public float CrossRelativePosition
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1E034C0", Offset = "0x1E034C0", VA = "0x1E034C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1E034EC", Offset = "0x1E034EC", VA = "0x1E034EC")]
			set
			{
			}
		}

		[Token(Token = "0x170001FB")]
		public override float Length
		{
			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1E0351C", Offset = "0x1E0351C", VA = "0x1E0351C", Slot = "28")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FC")]
		public override bool IsReady
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1E03644", Offset = "0x1E03644", VA = "0x1E03644", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001FD")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000A42")]
			[Address(RVA = "0x1E03B88", Offset = "0x1E03B88", VA = "0x1E03B88")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170001FE")]
		private float MinCrossRelativePosition
		{
			[Token(Token = "0x6000A43")]
			[Address(RVA = "0x1E03BF8", Offset = "0x1E03BF8", VA = "0x1E03BF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170001FF")]
		private float MaxCrossRelativePosition
		{
			[Token(Token = "0x6000A44")]
			[Address(RVA = "0x1E03C00", Offset = "0x1E03C00", VA = "0x1E03C00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x1E0355C", Offset = "0x1E0355C", VA = "0x1E0355C")]
		public float CrossRelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x1E035D0", Offset = "0x1E035D0", VA = "0x1E035D0")]
		public float CrossAbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x1E03694", Offset = "0x1E03694", VA = "0x1E03694", Slot = "32")]
		protected override float RelativeToAbsolute(float relativeDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x1E036F0", Offset = "0x1E036F0", VA = "0x1E036F0", Slot = "31")]
		protected override float AbsoluteToRelative(float worldUnitDistance)
		{
			return default(float);
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x1E0374C", Offset = "0x1E0374C", VA = "0x1E0374C", Slot = "33")]
		protected override Vector3 GetInterpolatedSourcePosition(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x1E037E4", Offset = "0x1E037E4", VA = "0x1E037E4", Slot = "34")]
		protected override void GetInterpolatedSourcePosition(float tf, out Vector3 interpolatedPosition, out Vector3 tangent, out Vector3 up)
		{
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x1E038E8", Offset = "0x1E038E8", VA = "0x1E038E8", Slot = "36")]
		protected override Vector3 GetTangent(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x1E03980", Offset = "0x1E03980", VA = "0x1E03980", Slot = "35")]
		protected override Vector3 GetOrientation(float tf)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x1E03A18", Offset = "0x1E03A18", VA = "0x1E03A18", Slot = "29")]
		protected override void Advance(float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x1E03A94", Offset = "0x1E03A94", VA = "0x1E03A94", Slot = "30")]
		protected override void SimulateAdvance(ref float tf, ref MovementDirection curyDirection, float speed, float deltaTime)
		{
		}

		[Token(Token = "0x6000A45")]
		[Address(RVA = "0x1E034D8", Offset = "0x1E034D8", VA = "0x1E034D8")]
		private float GetClampedCrossPosition(float position)
		{
			return default(float);
		}

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0x1E03C08", Offset = "0x1E03C08", VA = "0x1E03C08", Slot = "37")]
		public override void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0x1E03C60", Offset = "0x1E03C60", VA = "0x1E03C60")]
		public VolumeController()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Components
{
	[Token(Token = "0x200015E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C40E8", Offset = "0x9C40E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C40E8", Offset = "0x9C40E8")]
	public class CurvyGLRenderer : MonoBehaviour
	{
		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[ArrayEx]
		public List<GLSlotData> Splines;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material lineMaterial;

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0x16FC864", Offset = "0x16FC864", VA = "0x16FC864")]
		private void CreateLineMaterial()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0x16FC984", Offset = "0x16FC984", VA = "0x16FC984")]
		private void OnPostRender()
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0x16FCBA4", Offset = "0x16FCBA4", VA = "0x16FCBA4")]
		private void sanitize()
		{
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0x16FCCF4", Offset = "0x16FCCF4", VA = "0x16FCCF4")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0x16FCE80", Offset = "0x16FCE80", VA = "0x16FCE80")]
		private GLSlotData getSlot(CurvySpline spline)
		{
			return null;
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0x16FD040", Offset = "0x16FD040", VA = "0x16FD040")]
		public void Add(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0x16FD134", Offset = "0x16FD134", VA = "0x16FD134")]
		public void Remove(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0x16FD258", Offset = "0x16FD258", VA = "0x16FD258")]
		public CurvyGLRenderer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class GLSlotData
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public CurvySpline Spline;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LineColor;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<Vector3[]> VertexData;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0x1692354", Offset = "0x1692354", VA = "0x1692354")]
		public void GetVertexData()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0x16924DC", Offset = "0x16924DC", VA = "0x16924DC")]
		public void Render(Material mat)
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0x16926CC", Offset = "0x16926CC", VA = "0x16926CC")]
		public GLSlotData()
		{
		}
	}
	[Token(Token = "0x2000160")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4148", Offset = "0x9C4148")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4148", Offset = "0x9C4148")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C4148", Offset = "0x9C4148")]
	[ExecuteInEditMode]
	public class CurvyLineRenderer : MonoBehaviour
	{
		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline m_Spline;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer mRenderer;

		[Token(Token = "0x17000200")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000A53")]
			[Address(RVA = "0x17038A4", Offset = "0x17038A4", VA = "0x17038A4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A54")]
			[Address(RVA = "0x17038AC", Offset = "0x17038AC", VA = "0x17038AC")]
			set
			{
			}
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x1703CAC", Offset = "0x1703CAC", VA = "0x1703CAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x1703D98", Offset = "0x1703D98", VA = "0x1703D98")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x1703DFC", Offset = "0x1703DFC", VA = "0x1703DFC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x1703E00", Offset = "0x1703E00", VA = "0x1703E00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x1703B8C", Offset = "0x1703B8C", VA = "0x1703B8C")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x1703FAC", Offset = "0x1703FAC", VA = "0x1703FAC")]
		private void OnSplineRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x1703A78", Offset = "0x1703A78", VA = "0x1703A78")]
		private void bindEvents()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x1703964", Offset = "0x1703964", VA = "0x1703964")]
		private void unbindEvents()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x1703FB0", Offset = "0x1703FB0", VA = "0x1703FB0")]
		public CurvyLineRenderer()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Shapes
{
	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4200", Offset = "0x9C4200")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C4200", Offset = "0x9C4200")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C4200", Offset = "0x9C4200")]
	public class CSCircle : CurvyShape2D
	{
		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Count;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float m_Radius;

		[Token(Token = "0x17000201")]
		public int Count
		{
			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0x1C3AD24", Offset = "0x1C3AD24", VA = "0x1C3AD24")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0x1C3AD2C", Offset = "0x1C3AD2C", VA = "0x1C3AD2C")]
			set
			{
			}
		}

		[Token(Token = "0x17000202")]
		public float Radius
		{
			[Token(Token = "0x6000A60")]
			[Address(RVA = "0x1C3AD6C", Offset = "0x1C3AD6C", VA = "0x1C3AD6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A61")]
			[Address(RVA = "0x1C3AD74", Offset = "0x1C3AD74", VA = "0x1C3AD74")]
			set
			{
			}
		}

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x1C3ADB8", Offset = "0x1C3ADB8", VA = "0x1C3ADB8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x1C3AE2C", Offset = "0x1C3AE2C", VA = "0x1C3AE2C", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x1C3AF60", Offset = "0x1C3AF60", VA = "0x1C3AF60")]
		public CSCircle()
		{
		}
	}
	[Token(Token = "0x2000162")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C42AC", Offset = "0x9C42AC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C42AC", Offset = "0x9C42AC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C42AC", Offset = "0x9C42AC")]
	public class CSPie : CSCircle
	{
		[Token(Token = "0x2000163")]
		public enum EatModeEnum
		{
			[Token(Token = "0x4000658")]
			Left,
			[Token(Token = "0x4000659")]
			Right,
			[Token(Token = "0x400065A")]
			Center
		}

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9CADCC", Offset = "0x9CADCC")]
		private float m_Roundness;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CAE0C", Offset = "0x9CAE0C")]
		[SerializeField]
		private int m_Empty;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CAE8C", Offset = "0x9CAE8C")]
		[SerializeField]
		private EatModeEnum m_Eat;

		[Token(Token = "0x17000203")]
		public float Roundness
		{
			[Token(Token = "0x6000A65")]
			[Address(RVA = "0x1C3AF74", Offset = "0x1C3AF74", VA = "0x1C3AF74")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A66")]
			[Address(RVA = "0x1C3AF7C", Offset = "0x1C3AF7C", VA = "0x1C3AF7C")]
			set
			{
			}
		}

		[Token(Token = "0x17000204")]
		public int Empty
		{
			[Token(Token = "0x6000A67")]
			[Address(RVA = "0x1C3AFB8", Offset = "0x1C3AFB8", VA = "0x1C3AFB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A68")]
			[Address(RVA = "0x1C3AFC0", Offset = "0x1C3AFC0", VA = "0x1C3AFC0")]
			set
			{
			}
		}

		[Token(Token = "0x17000205")]
		private int maxEmpty
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x1C3B008", Offset = "0x1C3B008", VA = "0x1C3B008")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000206")]
		public EatModeEnum Eat
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x1C3B010", Offset = "0x1C3B010", VA = "0x1C3B010")]
			get
			{
				return default(EatModeEnum);
			}
			[Token(Token = "0x6000A6B")]
			[Address(RVA = "0x1C3B018", Offset = "0x1C3B018", VA = "0x1C3B018")]
			set
			{
			}
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x1C3B034", Offset = "0x1C3B034", VA = "0x1C3B034", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x1C3B0BC", Offset = "0x1C3B0BC", VA = "0x1C3B0BC")]
		private Vector3 cpPosition(int i, int empty, float d)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x1C3B148", Offset = "0x1C3B148", VA = "0x1C3B148", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x1C3B7EC", Offset = "0x1C3B7EC", VA = "0x1C3B7EC")]
		public CSPie()
		{
		}
	}
	[Token(Token = "0x2000164")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4358", Offset = "0x9C4358")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C4358", Offset = "0x9C4358")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C4358", Offset = "0x9C4358")]
	public class CSRectangle : CurvyShape2D
	{
		[Token(Token = "0x400065B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private float m_Width;

		[Token(Token = "0x400065C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Positive]
		[SerializeField]
		private float m_Height;

		[Token(Token = "0x17000207")]
		public float Width
		{
			[Token(Token = "0x6000A70")]
			[Address(RVA = "0x1C3B808", Offset = "0x1C3B808", VA = "0x1C3B808")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A71")]
			[Address(RVA = "0x1C3B810", Offset = "0x1C3B810", VA = "0x1C3B810")]
			set
			{
			}
		}

		[Token(Token = "0x17000208")]
		public float Height
		{
			[Token(Token = "0x6000A72")]
			[Address(RVA = "0x1C3B854", Offset = "0x1C3B854", VA = "0x1C3B854")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A73")]
			[Address(RVA = "0x1C3B85C", Offset = "0x1C3B85C", VA = "0x1C3B85C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x1C3B8A0", Offset = "0x1C3B8A0", VA = "0x1C3B8A0", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x1C3B914", Offset = "0x1C3B914", VA = "0x1C3B914", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x1C3BABC", Offset = "0x1C3BABC", VA = "0x1C3BABC")]
		public CSRectangle()
		{
		}
	}
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C4404", Offset = "0x9C4404")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4404", Offset = "0x9C4404")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C4404", Offset = "0x9C4404")]
	public class CSRoundedRectangle : CurvyShape2D
	{
		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Positive]
		[SerializeField]
		private float m_Width;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_Height;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9CAFC4", Offset = "0x9CAFC4")]
		private float m_Roundness;

		[Token(Token = "0x17000209")]
		public float Width
		{
			[Token(Token = "0x6000A77")]
			[Address(RVA = "0x1C3BACC", Offset = "0x1C3BACC", VA = "0x1C3BACC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A78")]
			[Address(RVA = "0x1C3BAD4", Offset = "0x1C3BAD4", VA = "0x1C3BAD4")]
			set
			{
			}
		}

		[Token(Token = "0x1700020A")]
		public float Height
		{
			[Token(Token = "0x6000A79")]
			[Address(RVA = "0x1C3BB18", Offset = "0x1C3BB18", VA = "0x1C3BB18")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A7A")]
			[Address(RVA = "0x1C3BB20", Offset = "0x1C3BB20", VA = "0x1C3BB20")]
			set
			{
			}
		}

		[Token(Token = "0x1700020B")]
		public float Roundness
		{
			[Token(Token = "0x6000A7B")]
			[Address(RVA = "0x1C3BB64", Offset = "0x1C3BB64", VA = "0x1C3BB64")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A7C")]
			[Address(RVA = "0x1C3BB6C", Offset = "0x1C3BB6C", VA = "0x1C3BB6C")]
			set
			{
			}
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1C3BBA8", Offset = "0x1C3BBA8", VA = "0x1C3BBA8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1C3BC40", Offset = "0x1C3BC40", VA = "0x1C3BC40", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1C3C004", Offset = "0x1C3C004", VA = "0x1C3C004")]
		public CSRoundedRectangle()
		{
		}
	}
	[Token(Token = "0x2000166")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C44B0", Offset = "0x9C44B0")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C44B0", Offset = "0x9C44B0")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C44B0", Offset = "0x9C44B0")]
	public class CSSpiral : CurvyShape2D
	{
		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Count;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_Circles;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Positive]
		private float m_Radius;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CB10C", Offset = "0x9CB10C")]
		[SerializeField]
		private AnimationCurve m_RadiusFactor;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationCurve m_Z;

		[Token(Token = "0x1700020C")]
		public int Count
		{
			[Token(Token = "0x6000A80")]
			[Address(RVA = "0x1C3C01C", Offset = "0x1C3C01C", VA = "0x1C3C01C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A81")]
			[Address(RVA = "0x1C3C024", Offset = "0x1C3C024", VA = "0x1C3C024")]
			set
			{
			}
		}

		[Token(Token = "0x1700020D")]
		public float Circles
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1C3C064", Offset = "0x1C3C064", VA = "0x1C3C064")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A83")]
			[Address(RVA = "0x1C3C06C", Offset = "0x1C3C06C", VA = "0x1C3C06C")]
			set
			{
			}
		}

		[Token(Token = "0x1700020E")]
		public float Radius
		{
			[Token(Token = "0x6000A84")]
			[Address(RVA = "0x1C3C0B0", Offset = "0x1C3C0B0", VA = "0x1C3C0B0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A85")]
			[Address(RVA = "0x1C3C0B8", Offset = "0x1C3C0B8", VA = "0x1C3C0B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700020F")]
		public AnimationCurve RadiusFactor
		{
			[Token(Token = "0x6000A86")]
			[Address(RVA = "0x1C3C0FC", Offset = "0x1C3C0FC", VA = "0x1C3C0FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A87")]
			[Address(RVA = "0x1C3C104", Offset = "0x1C3C104", VA = "0x1C3C104")]
			set
			{
			}
		}

		[Token(Token = "0x17000210")]
		public AnimationCurve Z
		{
			[Token(Token = "0x6000A88")]
			[Address(RVA = "0x1C3C13C", Offset = "0x1C3C13C", VA = "0x1C3C13C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A89")]
			[Address(RVA = "0x1C3C144", Offset = "0x1C3C144", VA = "0x1C3C144")]
			set
			{
			}
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x1C3C17C", Offset = "0x1C3C17C", VA = "0x1C3C17C", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1C3C298", Offset = "0x1C3C298", VA = "0x1C3C298", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A8C")]
		[Address(RVA = "0x1C3C3E4", Offset = "0x1C3C3E4", VA = "0x1C3C3E4")]
		public CSSpiral()
		{
		}
	}
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C455C", Offset = "0x9C455C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C455C", Offset = "0x9C455C")]
	[AttributeAttribute(Name = "CurvyShapeInfo", RVA = "0x9C455C", Offset = "0x9C455C")]
	public class CSStar : CurvyShape2D
	{
		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Positive]
		private int m_Sides;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Positive]
		private float m_OuterRadius;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CB210", Offset = "0x9CB210")]
		[SerializeField]
		private float m_OuterRoundness;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Positive]
		[SerializeField]
		private float m_InnerRadius;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CB2B8", Offset = "0x9CB2B8")]
		private float m_InnerRoundness;

		[Token(Token = "0x17000211")]
		public int Sides
		{
			[Token(Token = "0x6000A8D")]
			[Address(RVA = "0x1C3C478", Offset = "0x1C3C478", VA = "0x1C3C478")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000A8E")]
			[Address(RVA = "0x1C3C480", Offset = "0x1C3C480", VA = "0x1C3C480")]
			set
			{
			}
		}

		[Token(Token = "0x17000212")]
		public float OuterRadius
		{
			[Token(Token = "0x6000A8F")]
			[Address(RVA = "0x1C3C4C0", Offset = "0x1C3C4C0", VA = "0x1C3C4C0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A90")]
			[Address(RVA = "0x1C3C4C8", Offset = "0x1C3C4C8", VA = "0x1C3C4C8")]
			set
			{
			}
		}

		[Token(Token = "0x17000213")]
		public float OuterRoundness
		{
			[Token(Token = "0x6000A91")]
			[Address(RVA = "0x1C3C514", Offset = "0x1C3C514", VA = "0x1C3C514")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A92")]
			[Address(RVA = "0x1C3C51C", Offset = "0x1C3C51C", VA = "0x1C3C51C")]
			set
			{
			}
		}

		[Token(Token = "0x17000214")]
		public float InnerRadius
		{
			[Token(Token = "0x6000A93")]
			[Address(RVA = "0x1C3C560", Offset = "0x1C3C560", VA = "0x1C3C560")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A94")]
			[Address(RVA = "0x1C3C568", Offset = "0x1C3C568", VA = "0x1C3C568")]
			set
			{
			}
		}

		[Token(Token = "0x17000215")]
		public float InnerRoundness
		{
			[Token(Token = "0x6000A95")]
			[Address(RVA = "0x1C3C5AC", Offset = "0x1C3C5AC", VA = "0x1C3C5AC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1C3C5B4", Offset = "0x1C3C5B4", VA = "0x1C3C5B4")]
			set
			{
			}
		}

		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x1C3C5F8", Offset = "0x1C3C5F8", VA = "0x1C3C5F8", Slot = "5")]
		protected override void Reset()
		{
		}

		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x1C3C6E4", Offset = "0x1C3C6E4", VA = "0x1C3C6E4", Slot = "6")]
		protected override void ApplyShape()
		{
		}

		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x1C3C8D0", Offset = "0x1C3C8D0", VA = "0x1C3C8D0")]
		public CSStar()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Utils
{
	[Token(Token = "0x2000168")]
	public static class CurvyUtility
	{
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2507990", Offset = "0x2507990", VA = "0x2507990")]
		public static float ClampTF(float tf, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2507A04", Offset = "0x2507A04", VA = "0x2507A04")]
		public static float ClampValue(float tf, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2507AF0", Offset = "0x2507AF0", VA = "0x2507AF0")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2507B84", Offset = "0x2507B84", VA = "0x2507B84")]
		public static float ClampTF(float tf, ref int dir, CurvyClamping clamping, float minTF, float maxTF)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2507C5C", Offset = "0x2507C5C", VA = "0x2507C5C")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2507CA4", Offset = "0x2507CA4", VA = "0x2507CA4")]
		public static float ClampDistance(float distance, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2507D70", Offset = "0x2507D70", VA = "0x2507D70")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2507E2C", Offset = "0x2507E2C", VA = "0x2507E2C")]
		public static float ClampDistance(float distance, ref int dir, CurvyClamping clamping, float length, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2507F1C", Offset = "0x2507F1C", VA = "0x2507F1C")]
		public static Material GetDefaultMaterial()
		{
			return null;
		}

		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2508038", Offset = "0x2508038", VA = "0x2508038")]
		public static bool Approximately(this float x, float y)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000169")]
	public class Spline2Mesh
	{
		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<SplinePolyLine> Lines;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public WindingRule Winding;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVTiling;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVOffset;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool SuppressUVMapping;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool UV2;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string MeshName;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool VertexLineOnly;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CB328", Offset = "0x9CB328")]
		private string <Error>k__BackingField;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tess mTess;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Mesh mMesh;

		[Token(Token = "0x17000216")]
		public string Error
		{
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1DC76A4", Offset = "0x1DC76A4", VA = "0x1DC76A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D283C", Offset = "0x9D283C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AA5")]
			[Address(RVA = "0x1DC76AC", Offset = "0x1DC76AC", VA = "0x1DC76AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D284C", Offset = "0x9D284C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1DC76B4", Offset = "0x1DC76B4", VA = "0x1DC76B4")]
		public bool Apply(out Mesh result)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1DC7BFC", Offset = "0x1DC7BFC", VA = "0x1DC7BFC")]
		private bool triangulate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1DC8184", Offset = "0x1DC8184", VA = "0x1DC8184")]
		private static bool polyLineIsValid(SplinePolyLine pl)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1DC83B8", Offset = "0x1DC83B8", VA = "0x1DC83B8")]
		public Spline2Mesh()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200016A")]
	public class SplinePolyLine
	{
		[Token(Token = "0x200016B")]
		public enum VertexCalculation
		{
			[Token(Token = "0x400067C")]
			ByApproximation,
			[Token(Token = "0x400067D")]
			ByAngle
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4618", Offset = "0x9C4618")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<Vector3> vPos;

			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 curPos;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> vTan;

			[Token(Token = "0x4000681")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curTangent;

			[Token(Token = "0x4000682")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> vTF;

			[Token(Token = "0x4000683")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float angleFromLast;

			[Token(Token = "0x4000684")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float distAccu;

			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public int linearSteps;

			[Token(Token = "0x6000AB0")]
			[Address(RVA = "0x1E0E284", Offset = "0x1E0E284", VA = "0x1E0E284")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x6000AB1")]
			[Address(RVA = "0x1E0E28C", Offset = "0x1E0E28C", VA = "0x1E0E28C")]
			internal void <GetPolygon>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ContourOrientation Orientation;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CurvySpline Spline;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public VertexCalculation VertexMode;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Angle;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Distance;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Space Space;

		[Token(Token = "0x17000217")]
		public bool IsClosed
		{
			[Token(Token = "0x6000AAD")]
			[Address(RVA = "0x1DCD708", Offset = "0x1DCD708", VA = "0x1DCD708")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x1DCD610", Offset = "0x1DCD610", VA = "0x1DCD610")]
		public SplinePolyLine(CurvySpline spline)
		{
		}

		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x1DCD6B0", Offset = "0x1DCD6B0", VA = "0x1DCD6B0")]
		public SplinePolyLine(CurvySpline spline, float angle, float distance)
		{
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1DCD64C", Offset = "0x1DCD64C", VA = "0x1DCD64C")]
		private SplinePolyLine(CurvySpline spline, VertexCalculation vertexMode, float angle, float distance, Space space = Space.World)
		{
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1DC7F74", Offset = "0x1DC7F74", VA = "0x1DC7F74")]
		public Vector3[] GetVertices()
		{
			return null;
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x1DCD798", Offset = "0x1DCD798", VA = "0x1DCD798")]
		private static Vector3[] GetPolygon(CurvySpline spline, float fromTF, float toTF, float maxAngle, float minDistance, float maxDistance, out List<float> vertexTF, out List<Vector3> vertexTangents, bool includeEndPoint = true, float stepSize = 0.01f)
		{
			return null;
		}
	}
}
namespace FluffyUnderware.Curvy.Generator
{
	[Token(Token = "0x200016D")]
	public abstract class SplineInputModuleBase : CGModule
	{
		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4628", Offset = "0x9C4628")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> sourceF;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float curDist;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CurvySpline spline;

			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<Vector3> pos;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 curPos;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<float> relF;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float startDist;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public CGShape data;

			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool fullPath;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<Vector3> tan;

			[Token(Token = "0x4000693")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Vector3 curTan;

			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public List<Vector3> up;

			[Token(Token = "0x6000AC2")]
			[Address(RVA = "0x1E0E144", Offset = "0x1E0E144", VA = "0x1E0E144")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000AC3")]
			[Address(RVA = "0x1E0E14C", Offset = "0x1E0E14C", VA = "0x1E0E14C")]
			internal void <GetSplineData>b__0(float f)
			{
			}
		}

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CB338", Offset = "0x9CB338")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CB338", Offset = "0x9CB338")]
		private bool m_UseCache;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CB3A8", Offset = "0x9CB3A8")]
		protected CurvySplineSegment m_StartCP;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CB3F4", Offset = "0x9CB3F4")]
		[SerializeField]
		protected CurvySplineSegment m_EndCP;

		[Token(Token = "0x17000218")]
		public bool UseCache
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1DCA950", Offset = "0x1DCA950", VA = "0x1DCA950")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x1DCA958", Offset = "0x1DCA958", VA = "0x1DCA958")]
			set
			{
			}
		}

		[Token(Token = "0x17000219")]
		public CurvySplineSegment StartCP
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x1DCA980", Offset = "0x1DCA980", VA = "0x1DCA980")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1DCA988", Offset = "0x1DCA988", VA = "0x1DCA988")]
			set
			{
			}
		}

		[Token(Token = "0x1700021A")]
		public CurvySplineSegment EndCP
		{
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x1DCAA3C", Offset = "0x1DCAA3C", VA = "0x1DCAA3C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x1DCAA44", Offset = "0x1DCAA44", VA = "0x1DCAA44")]
			set
			{
			}
		}

		[Token(Token = "0x6000AB8")]
		[Address(RVA = "0x1DCAAF8", Offset = "0x1DCAAF8", VA = "0x1DCAAF8", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000AB9")]
		protected abstract void ValidateStartAndEndCps();

		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x1DCAB30", Offset = "0x1DCAB30", VA = "0x1DCAB30")]
		protected float getPathLength(CurvySpline spline)
		{
			return default(float);
		}

		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x1DCAC40", Offset = "0x1DCAC40", VA = "0x1DCAC40")]
		protected bool getPathClosed(CurvySpline spline)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x1DCAD04", Offset = "0x1DCAD04", VA = "0x1DCAD04")]
		protected CGData GetSplineData(CurvySpline spline, bool fullPath, CGDataRequestRasterization raster, CGDataRequestMetaCGOptions options)
		{
			return null;
		}

		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x1DCC7B0", Offset = "0x1DCC7B0", VA = "0x1DCC7B0")]
		private static bool MoveByAngleExt(CurvySpline spline, bool useCache, ref float tf, float minDistance, float maxDistance, float maxAngle, out Vector3 pos, out Vector3 tan, out float movedDistance, float stopTF, bool loop, float stepDist)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x1DCCB04", Offset = "0x1DCCB04", VA = "0x1DCCB04")]
		private void CalculateExtendedUV(CurvySpline spline, float startTF, float endTF, List<SamplePointUData> ext, CGShape data)
		{
		}

		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x1DCD2E8", Offset = "0x1DCD2E8", VA = "0x1DCD2E8")]
		private static MetaCGOptions findPreviousReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x1DCD460", Offset = "0x1DCD460", VA = "0x1DCD460")]
		private static MetaCGOptions findNextReferenceCPOptions(CurvySpline spline, float tf, out CurvySplineSegment cp)
		{
			return null;
		}

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x1DCD608", Offset = "0x1DCD608", VA = "0x1DCD608")]
		protected SplineInputModuleBase()
		{
		}
	}
	[Token(Token = "0x200016F")]
	public class TRSModuleBase : CGModule
	{
		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB45C", Offset = "0x9CB45C")]
		private Vector3 m_Transpose;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB4C4", Offset = "0x9CB4C4")]
		private Vector3 m_Rotation;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB52C", Offset = "0x9CB52C")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x1700021B")]
		public Vector3 Transpose
		{
			[Token(Token = "0x6000AC4")]
			[Address(RVA = "0x1DCE430", Offset = "0x1DCE430", VA = "0x1DCE430")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AC5")]
			[Address(RVA = "0x1DCE43C", Offset = "0x1DCE43C", VA = "0x1DCE43C")]
			set
			{
			}
		}

		[Token(Token = "0x1700021C")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000AC6")]
			[Address(RVA = "0x1DCE4AC", Offset = "0x1DCE4AC", VA = "0x1DCE4AC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AC7")]
			[Address(RVA = "0x1DCE4B8", Offset = "0x1DCE4B8", VA = "0x1DCE4B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700021D")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000AC8")]
			[Address(RVA = "0x1DCE528", Offset = "0x1DCE528", VA = "0x1DCE528")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AC9")]
			[Address(RVA = "0x1DCE534", Offset = "0x1DCE534", VA = "0x1DCE534")]
			set
			{
			}
		}

		[Token(Token = "0x1700021E")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000ACA")]
			[Address(RVA = "0x1DCE5A4", Offset = "0x1DCE5A4", VA = "0x1DCE5A4")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x1DCE648", Offset = "0x1DCE648", VA = "0x1DCE648", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1DCE690", Offset = "0x1DCE690", VA = "0x1DCE690")]
		public TRSModuleBase()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public enum CGYesNoAuto
	{
		[Token(Token = "0x4000699")]
		Yes,
		[Token(Token = "0x400069A")]
		No,
		[Token(Token = "0x400069B")]
		Auto
	}
	[Token(Token = "0x2000171")]
	public enum CGReferenceMode
	{
		[Token(Token = "0x400069D")]
		Source,
		[Token(Token = "0x400069E")]
		Self
	}
	[Token(Token = "0x2000172")]
	public enum CGKeepAspectMode
	{
		[Token(Token = "0x40006A0")]
		Off,
		[Token(Token = "0x40006A1")]
		ScaleU,
		[Token(Token = "0x40006A2")]
		ScaleV
	}
	[Token(Token = "0x2000173")]
	public enum CGUVEnum
	{
		[Token(Token = "0x40006A4")]
		U,
		[Token(Token = "0x40006A5")]
		V
	}
	[Token(Token = "0x2000174")]
	public enum CGColliderEnum
	{
		[Token(Token = "0x40006A7")]
		None,
		[Token(Token = "0x40006A8")]
		Mesh,
		[Token(Token = "0x40006A9")]
		Box,
		[Token(Token = "0x40006AA")]
		Sphere
	}
	[Serializable]
	[Token(Token = "0x2000175")]
	public struct CGSpot : IEquatable<CGSpot>
	{
		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CB594", Offset = "0x9CB594")]
		[SerializeField]
		private int m_Index;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB5FC", Offset = "0x9CB5FC")]
		private Vector3 m_Position;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB66C", Offset = "0x9CB66C")]
		private Quaternion m_Rotation;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB6DC", Offset = "0x9CB6DC")]
		private Vector3 m_Scale;

		[Token(Token = "0x1700021F")]
		public int Index
		{
			[Token(Token = "0x6000ACD")]
			[Address(RVA = "0x1C35F0C", Offset = "0x1C35F0C", VA = "0x1C35F0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000220")]
		public Vector3 Position
		{
			[Token(Token = "0x6000ACE")]
			[Address(RVA = "0x1C35F14", Offset = "0x1C35F14", VA = "0x1C35F14")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000ACF")]
			[Address(RVA = "0x1C35F20", Offset = "0x1C35F20", VA = "0x1C35F20")]
			set
			{
			}
		}

		[Token(Token = "0x17000221")]
		public Quaternion Rotation
		{
			[Token(Token = "0x6000AD0")]
			[Address(RVA = "0x1C35F84", Offset = "0x1C35F84", VA = "0x1C35F84")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000AD1")]
			[Address(RVA = "0x1C35F90", Offset = "0x1C35F90", VA = "0x1C35F90")]
			set
			{
			}
		}

		[Token(Token = "0x17000222")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x1C35FFC", Offset = "0x1C35FFC", VA = "0x1C35FFC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AD3")]
			[Address(RVA = "0x1C36008", Offset = "0x1C36008", VA = "0x1C36008")]
			set
			{
			}
		}

		[Token(Token = "0x17000223")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000AD4")]
			[Address(RVA = "0x1C3606C", Offset = "0x1C3606C", VA = "0x1C3606C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1C360CC", Offset = "0x1C360CC", VA = "0x1C360CC")]
		public CGSpot(int index)
		{
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1C36158", Offset = "0x1C36158", VA = "0x1C36158")]
		public CGSpot(int index, Vector3 position, Quaternion rotation, Vector3 scale)
		{
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x1C36180", Offset = "0x1C36180", VA = "0x1C36180")]
		public void ToTransform(Transform transform)
		{
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x1C361E0", Offset = "0x1C361E0", VA = "0x1C361E0", Slot = "4")]
		public bool Equals(CGSpot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x1C36260", Offset = "0x1C36260", VA = "0x1C36260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x1C362FC", Offset = "0x1C362FC", VA = "0x1C362FC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x1C36370", Offset = "0x1C36370", VA = "0x1C36370")]
		public static bool operator ==(CGSpot left, CGSpot right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1C363A4", Offset = "0x1C363A4", VA = "0x1C363A4")]
		public static bool operator !=(CGSpot left, CGSpot right)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Token(Token = "0x2000176")]
	public class CGMaterialSettings
	{
		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool SwapUV;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public CGKeepAspectMode KeepAspect;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UVRotation;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector2 UVOffset;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector2 UVScale;

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x171A130", Offset = "0x171A130", VA = "0x171A130")]
		public CGMaterialSettings()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000177")]
	public class CGMaterialSettingsEx : CGMaterialSettings
	{
		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int MaterialID;

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x171BA88", Offset = "0x171BA88", VA = "0x171BA88")]
		public CGMaterialSettingsEx()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000178")]
	public class CGMeshProperties
	{
		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Mesh m_Mesh;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Material[] m_Material;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB76C", Offset = "0x9CB76C")]
		[SerializeField]
		private Vector3 m_Translation;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB7D4", Offset = "0x9CB7D4")]
		private Vector3 m_Rotation;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB83C", Offset = "0x9CB83C")]
		private Vector3 m_Scale;

		[Token(Token = "0x17000224")]
		public Mesh Mesh
		{
			[Token(Token = "0x6000ADF")]
			[Address(RVA = "0x172274C", Offset = "0x172274C", VA = "0x172274C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE0")]
			[Address(RVA = "0x1722754", Offset = "0x1722754", VA = "0x1722754")]
			set
			{
			}
		}

		[Token(Token = "0x17000225")]
		public Material[] Material
		{
			[Token(Token = "0x6000AE1")]
			[Address(RVA = "0x1722888", Offset = "0x1722888", VA = "0x1722888")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AE2")]
			[Address(RVA = "0x1722890", Offset = "0x1722890", VA = "0x1722890")]
			set
			{
			}
		}

		[Token(Token = "0x17000226")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000AE3")]
			[Address(RVA = "0x17228A8", Offset = "0x17228A8", VA = "0x17228A8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AE4")]
			[Address(RVA = "0x17228B4", Offset = "0x17228B4", VA = "0x17228B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000227")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000AE5")]
			[Address(RVA = "0x1722918", Offset = "0x1722918", VA = "0x1722918")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AE6")]
			[Address(RVA = "0x1722924", Offset = "0x1722924", VA = "0x1722924")]
			set
			{
			}
		}

		[Token(Token = "0x17000228")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000AE7")]
			[Address(RVA = "0x1722988", Offset = "0x1722988", VA = "0x1722988")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AE8")]
			[Address(RVA = "0x1722994", Offset = "0x1722994", VA = "0x1722994")]
			set
			{
			}
		}

		[Token(Token = "0x17000229")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000AE9")]
			[Address(RVA = "0x17229F8", Offset = "0x17229F8", VA = "0x17229F8")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x1722A9C", Offset = "0x1722A9C", VA = "0x1722A9C")]
		public CGMeshProperties()
		{
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1722B14", Offset = "0x1722B14", VA = "0x1722B14")]
		public CGMeshProperties(Mesh mesh)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000179")]
	public class CGGameObjectProperties
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameObject m_Object;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB8B4", Offset = "0x9CB8B4")]
		private Vector3 m_Translation;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB91C", Offset = "0x9CB91C")]
		private Vector3 m_Rotation;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CB984", Offset = "0x9CB984")]
		[SerializeField]
		private Vector3 m_Scale;

		[Token(Token = "0x1700022A")]
		public GameObject Object
		{
			[Token(Token = "0x6000AEC")]
			[Address(RVA = "0x1721F88", Offset = "0x1721F88", VA = "0x1721F88")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AED")]
			[Address(RVA = "0x1721F90", Offset = "0x1721F90", VA = "0x1721F90")]
			set
			{
			}
		}

		[Token(Token = "0x1700022B")]
		public Vector3 Translation
		{
			[Token(Token = "0x6000AEE")]
			[Address(RVA = "0x172202C", Offset = "0x172202C", VA = "0x172202C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AEF")]
			[Address(RVA = "0x1722038", Offset = "0x1722038", VA = "0x1722038")]
			set
			{
			}
		}

		[Token(Token = "0x1700022C")]
		public Vector3 Rotation
		{
			[Token(Token = "0x6000AF0")]
			[Address(RVA = "0x172209C", Offset = "0x172209C", VA = "0x172209C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AF1")]
			[Address(RVA = "0x17220A8", Offset = "0x17220A8", VA = "0x17220A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700022D")]
		public Vector3 Scale
		{
			[Token(Token = "0x6000AF2")]
			[Address(RVA = "0x172210C", Offset = "0x172210C", VA = "0x172210C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000AF3")]
			[Address(RVA = "0x1722118", Offset = "0x1722118", VA = "0x1722118")]
			set
			{
			}
		}

		[Token(Token = "0x1700022E")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000AF4")]
			[Address(RVA = "0x172217C", Offset = "0x172217C", VA = "0x172217C")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x1722220", Offset = "0x1722220", VA = "0x1722220")]
		public CGGameObjectProperties()
		{
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x1722254", Offset = "0x1722254", VA = "0x1722254")]
		public CGGameObjectProperties(GameObject gameObject)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200017A")]
	public class CGBoundsGroup
	{
		[Token(Token = "0x200017B")]
		public enum DistributionModeEnum
		{
			[Token(Token = "0x40006CE")]
			Parent,
			[Token(Token = "0x40006CF")]
			Self
		}

		[Token(Token = "0x200017C")]
		public enum RotationModeEnum
		{
			[Token(Token = "0x40006D1")]
			Full,
			[Token(Token = "0x40006D2")]
			Direction,
			[Token(Token = "0x40006D3")]
			Horizontal,
			[Token(Token = "0x40006D4")]
			Independent
		}

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private string m_Name;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_KeepTogether;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_SpaceBefore;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_SpaceAfter;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CBAA0", Offset = "0x9CBAA0")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[IntRegion]
		private IntRegion m_RepeatingItems;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9CBB94", Offset = "0x9CBB94")]
		[SerializeField]
		private DistributionModeEnum m_DistributionMode;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_PositionOffset;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[FloatRegion]
		private FloatRegion m_Height;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CBC9C", Offset = "0x9CBC9C")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x9CBC9C", Offset = "0x9CBC9C")]
		private RotationModeEnum m_RotationMode;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CBD28", Offset = "0x9CBD28")]
		[SerializeField]
		private Vector3 m_RotationOffset;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CBD90", Offset = "0x9CBD90")]
		[SerializeField]
		private Vector3 m_RotationScatter;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<CGBoundsGroupItem> m_Items;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WeightedRandom<int> mItemBag;

		[Token(Token = "0x1700022F")]
		public string Name
		{
			[Token(Token = "0x6000AF7")]
			[Address(RVA = "0x17206DC", Offset = "0x17206DC", VA = "0x17206DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000AF8")]
			[Address(RVA = "0x17206E4", Offset = "0x17206E4", VA = "0x17206E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000230")]
		public bool KeepTogether
		{
			[Token(Token = "0x6000AF9")]
			[Address(RVA = "0x172072C", Offset = "0x172072C", VA = "0x172072C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AFA")]
			[Address(RVA = "0x1720734", Offset = "0x1720734", VA = "0x1720734")]
			set
			{
			}
		}

		[Token(Token = "0x17000231")]
		public FloatRegion SpaceBefore
		{
			[Token(Token = "0x6000AFB")]
			[Address(RVA = "0x1720754", Offset = "0x1720754", VA = "0x1720754")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0x1720764", Offset = "0x1720764", VA = "0x1720764")]
			set
			{
			}
		}

		[Token(Token = "0x17000232")]
		public FloatRegion SpaceAfter
		{
			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0x17207B4", Offset = "0x17207B4", VA = "0x17207B4")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000AFE")]
			[Address(RVA = "0x17207C4", Offset = "0x17207C4", VA = "0x17207C4")]
			set
			{
			}
		}

		[Token(Token = "0x17000233")]
		public float Weight
		{
			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0x1720814", Offset = "0x1720814", VA = "0x1720814")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B00")]
			[Address(RVA = "0x172081C", Offset = "0x172081C", VA = "0x172081C")]
			set
			{
			}
		}

		[Token(Token = "0x17000234")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x6000B01")]
			[Address(RVA = "0x1720850", Offset = "0x1720850", VA = "0x1720850")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000B02")]
			[Address(RVA = "0x1720858", Offset = "0x1720858", VA = "0x1720858")]
			set
			{
			}
		}

		[Token(Token = "0x17000235")]
		public IntRegion RepeatingItems
		{
			[Token(Token = "0x6000B03")]
			[Address(RVA = "0x172086C", Offset = "0x172086C", VA = "0x172086C")]
			get
			{
				return default(IntRegion);
			}
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x172087C", Offset = "0x172087C", VA = "0x172087C")]
			set
			{
			}
		}

		[Token(Token = "0x17000236")]
		public DistributionModeEnum DistributionMode
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x17208CC", Offset = "0x17208CC", VA = "0x17208CC")]
			get
			{
				return default(DistributionModeEnum);
			}
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x17208D4", Offset = "0x17208D4", VA = "0x17208D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000237")]
		public FloatRegion PositionOffset
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x17208E8", Offset = "0x17208E8", VA = "0x17208E8")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x17208F8", Offset = "0x17208F8", VA = "0x17208F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000238")]
		public FloatRegion Height
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x1720948", Offset = "0x1720948", VA = "0x1720948")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x1720958", Offset = "0x1720958", VA = "0x1720958")]
			set
			{
			}
		}

		[Token(Token = "0x17000239")]
		public RotationModeEnum RotationMode
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x17209A8", Offset = "0x17209A8", VA = "0x17209A8")]
			get
			{
				return default(RotationModeEnum);
			}
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x17209B0", Offset = "0x17209B0", VA = "0x17209B0")]
			set
			{
			}
		}

		[Token(Token = "0x1700023A")]
		public Vector3 RotationOffset
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x17209C4", Offset = "0x17209C4", VA = "0x17209C4")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x17209D0", Offset = "0x17209D0", VA = "0x17209D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public Vector3 RotationScatter
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x1720A34", Offset = "0x1720A34", VA = "0x1720A34")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x1720A40", Offset = "0x1720A40", VA = "0x1720A40")]
			set
			{
			}
		}

		[Token(Token = "0x1700023C")]
		public List<CGBoundsGroupItem> Items
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x1720AA4", Offset = "0x1720AA4", VA = "0x1720AA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023D")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x1720178", Offset = "0x1720178", VA = "0x1720178")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x1720AAC", Offset = "0x1720AAC", VA = "0x1720AAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700023E")]
		public int LastRepeating
		{
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x1720180", Offset = "0x1720180", VA = "0x1720180")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x1720B04", Offset = "0x1720B04", VA = "0x1720B04")]
			set
			{
			}
		}

		[Token(Token = "0x1700023F")]
		public int ItemCount
		{
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x171EE98", Offset = "0x171EE98", VA = "0x171EE98")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000240")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x1720B68", Offset = "0x1720B68", VA = "0x1720B68")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x17000241")]
		private RegionOptions<float> PositionRangeOptions
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x1720BFC", Offset = "0x1720BFC", VA = "0x1720BFC")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x17000242")]
		private int lastItemIndex
		{
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x1720C6C", Offset = "0x1720C6C", VA = "0x1720C6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B17")]
		[Address(RVA = "0x171FB80", Offset = "0x171FB80", VA = "0x171FB80")]
		public CGBoundsGroup(string name)
		{
		}

		[Token(Token = "0x6000B1B")]
		[Address(RVA = "0x17202B0", Offset = "0x17202B0", VA = "0x17202B0")]
		internal void PrepareINTERNAL()
		{
		}

		[Token(Token = "0x6000B1C")]
		[Address(RVA = "0x1720188", Offset = "0x1720188", VA = "0x1720188")]
		internal int getRandomItemINTERNAL()
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200017D")]
	public class CGBoundsGroupItem
	{
		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Index;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CBE08", Offset = "0x9CBE08")]
		[SerializeField]
		private float m_Weight;

		[Token(Token = "0x17000243")]
		public float Weight
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x1720C8C", Offset = "0x1720C8C", VA = "0x1720C8C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x1720C94", Offset = "0x1720C94", VA = "0x1720C94")]
			set
			{
			}
		}

		[Token(Token = "0x6000B1F")]
		[Address(RVA = "0x171FC94", Offset = "0x171FC94", VA = "0x171FC94")]
		public CGBoundsGroupItem()
		{
		}
	}
	[Token(Token = "0x200017E")]
	public struct ControlPointOption : IEquatable<ControlPointOption>
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TF;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float Distance;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool Include;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int MaterialID;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool HardEdge;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxStepDistance;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UVEdge;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UVShift;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float FirstU;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SecondU;

		[Token(Token = "0x6000B20")]
		[Address(RVA = "0x1C36DA0", Offset = "0x1C36DA0", VA = "0x1C36DA0")]
		public ControlPointOption(float tf, float dist, bool includeAnyways, int materialID, bool hardEdge, float maxStepDistance, bool uvEdge, bool uvShift, float firstU, float secondU)
		{
		}

		[Token(Token = "0x6000B21")]
		[Address(RVA = "0x1C43898", Offset = "0x1C43898", VA = "0x1C43898", Slot = "4")]
		public bool Equals(ControlPointOption other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B22")]
		[Address(RVA = "0x1C439B0", Offset = "0x1C439B0", VA = "0x1C439B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B23")]
		[Address(RVA = "0x1C43A4C", Offset = "0x1C43A4C", VA = "0x1C43A4C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000B24")]
		[Address(RVA = "0x1C43B60", Offset = "0x1C43B60", VA = "0x1C43B60")]
		public static bool operator ==(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x1C43B94", Offset = "0x1C43B94", VA = "0x1C43B94")]
		public static bool operator !=(ControlPointOption left, ControlPointOption right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200017F")]
	public struct SamplePointsPatch : IEquatable<SamplePointsPatch>
	{
		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Start;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x17000244")]
		public int End
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x1DC5AF0", Offset = "0x1DC5AF0", VA = "0x1DC5AF0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x1DC6078", Offset = "0x1DC6078", VA = "0x1DC6078")]
			set
			{
			}
		}

		[Token(Token = "0x17000245")]
		public int TriangleCount
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x1DC5A0C", Offset = "0x1DC5A0C", VA = "0x1DC5A0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x1DC60AC", Offset = "0x1DC60AC", VA = "0x1DC60AC")]
		public SamplePointsPatch(int start)
		{
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x1DC60B4", Offset = "0x1DC60B4", VA = "0x1DC60B4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x1DC62EC", Offset = "0x1DC62EC", VA = "0x1DC62EC", Slot = "4")]
		public bool Equals(SamplePointsPatch other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x1DC6314", Offset = "0x1DC6314", VA = "0x1DC6314", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x1DC63A8", Offset = "0x1DC63A8", VA = "0x1DC63A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x1DC63BC", Offset = "0x1DC63BC", VA = "0x1DC63BC")]
		public static bool operator ==(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x1DC63DC", Offset = "0x1DC63DC", VA = "0x1DC63DC")]
		public static bool operator !=(SamplePointsPatch left, SamplePointsPatch right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000180")]
	public class SamplePointsMaterialGroup
	{
		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int MaterialID;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<SamplePointsPatch> Patches;

		[Token(Token = "0x17000246")]
		public int TriangleCount
		{
			[Token(Token = "0x6000B30")]
			[Address(RVA = "0x1DC5958", Offset = "0x1DC5958", VA = "0x1DC5958")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000247")]
		public int StartVertex
		{
			[Token(Token = "0x6000B31")]
			[Address(RVA = "0x1DC5A18", Offset = "0x1DC5A18", VA = "0x1DC5A18")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000248")]
		public int EndVertex
		{
			[Token(Token = "0x6000B32")]
			[Address(RVA = "0x1DC5A78", Offset = "0x1DC5A78", VA = "0x1DC5A78")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000249")]
		public int VertexCount
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x1DC5AFC", Offset = "0x1DC5AFC", VA = "0x1DC5AFC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x1DC5B30", Offset = "0x1DC5B30", VA = "0x1DC5B30")]
		public SamplePointsMaterialGroup(int materialID)
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1DC5BC8", Offset = "0x1DC5BC8", VA = "0x1DC5BC8")]
		public void GetLengths(CGVolume volume, out float worldLength, out float uLength)
		{
		}
	}
	[Token(Token = "0x2000181")]
	public struct SamplePointUData : IEquatable<SamplePointUData>
	{
		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Vertex;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public bool UVEdge;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float FirstU;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float SecondU;

		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x1DC5510", Offset = "0x1DC5510", VA = "0x1DC5510")]
		public SamplePointUData(int vt, bool uvEdge, float uv0, float uv1)
		{
		}

		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x1DC5524", Offset = "0x1DC5524", VA = "0x1DC5524", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x1DC577C", Offset = "0x1DC577C", VA = "0x1DC577C", Slot = "4")]
		public bool Equals(SamplePointUData other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x1DC57F8", Offset = "0x1DC57F8", VA = "0x1DC57F8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x1DC5880", Offset = "0x1DC5880", VA = "0x1DC5880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x1DC58F4", Offset = "0x1DC58F4", VA = "0x1DC58F4")]
		public static bool operator ==(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B3C")]
		[Address(RVA = "0x1DC5924", Offset = "0x1DC5924", VA = "0x1DC5924")]
		public static bool operator !=(SamplePointUData left, SamplePointUData right)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000182")]
	public class SamplePointsMaterialGroupCollection : List<SamplePointsMaterialGroup>
	{
		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaterialID;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float AspectCorrection;

		[Token(Token = "0x1700024A")]
		public int TriangleCount
		{
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x1DC5D24", Offset = "0x1DC5D24", VA = "0x1DC5D24")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B3E")]
		[Address(RVA = "0x1DC5DD0", Offset = "0x1DC5DD0", VA = "0x1DC5DD0")]
		public SamplePointsMaterialGroupCollection()
		{
		}

		[Token(Token = "0x6000B3F")]
		[Address(RVA = "0x1DC5E50", Offset = "0x1DC5E50", VA = "0x1DC5E50")]
		public SamplePointsMaterialGroupCollection(int capacity)
		{
		}

		[Token(Token = "0x6000B40")]
		[Address(RVA = "0x1DC5EE0", Offset = "0x1DC5EE0", VA = "0x1DC5EE0")]
		public SamplePointsMaterialGroupCollection(IEnumerable<SamplePointsMaterialGroup> collection)
		{
		}

		[Token(Token = "0x6000B41")]
		[Address(RVA = "0x1DC5F70", Offset = "0x1DC5F70", VA = "0x1DC5F70")]
		public void CalculateAspectCorrection(CGVolume volume, CGMaterialSettingsEx matSettings)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000183")]
	public class CGDataReference
	{
		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CGModule m_Module;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CGModuleOutputSlot mSlot;

		[Token(Token = "0x1700024B")]
		public CGData[] Data
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x1720EAC", Offset = "0x1720EAC", VA = "0x1720EAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024C")]
		public CGModuleOutputSlot Slot
		{
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x1720F20", Offset = "0x1720F20", VA = "0x1720F20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700024D")]
		public bool HasValue
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x1721140", Offset = "0x1721140", VA = "0x1721140")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024E")]
		public bool IsEmpty
		{
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x1721170", Offset = "0x1721170", VA = "0x1721170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700024F")]
		public CGModule Module
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x172117C", Offset = "0x172117C", VA = "0x172117C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000250")]
		public string SlotName
		{
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x1721184", Offset = "0x1721184", VA = "0x1721184")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B48")]
		[Address(RVA = "0x172118C", Offset = "0x172118C", VA = "0x172118C")]
		public CGDataReference()
		{
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x1721194", Offset = "0x1721194", VA = "0x1721194")]
		public CGDataReference(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x1721218", Offset = "0x1721218", VA = "0x1721218")]
		public CGDataReference(CurvyGenerator generator, string moduleName, string slotName)
		{
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x17212C8", Offset = "0x17212C8", VA = "0x17212C8")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000B4C")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000B4D")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x17211D4", Offset = "0x17211D4", VA = "0x17211D4")]
		public void setINTERNAL(CGModule module, string slotName)
		{
		}

		[Token(Token = "0x6000B4F")]
		[Address(RVA = "0x1721260", Offset = "0x1721260", VA = "0x1721260")]
		public void setINTERNAL(CurvyGenerator generator, string moduleName, string slotName)
		{
		}
	}
	[Token(Token = "0x2000184")]
	public sealed class CGDataInfoAttribute : Attribute
	{
		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Color Color;

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x1720DB0", Offset = "0x1720DB0", VA = "0x1720DB0")]
		public CGDataInfoAttribute(Color color)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x1720DFC", Offset = "0x1720DFC", VA = "0x1720DFC")]
		public CGDataInfoAttribute(float r, float g, float b, float a = 1f)
		{
		}

		[Token(Token = "0x6000B52")]
		[Address(RVA = "0x1720E70", Offset = "0x1720E70", VA = "0x1720E70")]
		public CGDataInfoAttribute(string htmlColor)
		{
		}
	}
	[Token(Token = "0x2000185")]
	public class CGData
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x17000251")]
		public virtual int Count
		{
			[Token(Token = "0x6000B53")]
			[Address(RVA = "0x1720CC8", Offset = "0x1720CC8", VA = "0x1720CC8", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B54")]
		[Address(RVA = "0x17199E8", Offset = "0x17199E8", VA = "0x17199E8")]
		public static implicit operator bool(CGData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B55")]
		public virtual T Clone<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000B56")]
		[Address(RVA = "0x1720CD0", Offset = "0x1720CD0", VA = "0x1720CD0")]
		protected int getGenericFIndex(ref float[] FMapArray, float fValue, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x17205D4", Offset = "0x17205D4", VA = "0x17205D4")]
		public CGData()
		{
		}
	}
	[Token(Token = "0x2000186")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C4638", Offset = "0x9C4638")]
	public class CGShape : CGData
	{
		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float[] SourceF;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float[] F;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3[] Position;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3[] Normal;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float[] Map;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Bounds Bounds;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<SamplePointsMaterialGroup> MaterialGroups;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool SourceIsManaged;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool Closed;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool Seamless;

		[Token(Token = "0x40006FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float Length;

		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float mCacheLastF;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int mCacheLastIndex;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float mCacheLastFrag;

		[Token(Token = "0x17000252")]
		public override int Count
		{
			[Token(Token = "0x6000B58")]
			[Address(RVA = "0x1C3534C", Offset = "0x1C3534C", VA = "0x1C3534C", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x1C33BC8", Offset = "0x1C33BC8", VA = "0x1C33BC8")]
		public CGShape()
		{
		}

		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x1C33DD8", Offset = "0x1C33DD8", VA = "0x1C33DD8")]
		public CGShape(CGShape source)
		{
		}

		[Token(Token = "0x6000B5B")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x1C341F4", Offset = "0x1C341F4", VA = "0x1C341F4")]
		public static void Copy(CGShape dest, CGShape source)
		{
		}

		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x1C35368", Offset = "0x1C35368", VA = "0x1C35368")]
		public float DistanceToF(float distance)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x1C3539C", Offset = "0x1C3539C", VA = "0x1C3539C")]
		public float FToDistance(float f)
		{
			return default(float);
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x1C34568", Offset = "0x1C34568", VA = "0x1C34568")]
		public int GetFIndex(float f, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x1C353C8", Offset = "0x1C353C8", VA = "0x1C353C8")]
		public Vector3 InterpolatePosition(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B61")]
		[Address(RVA = "0x1C3548C", Offset = "0x1C3548C", VA = "0x1C3548C")]
		public Vector3 InterpolateUp(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x1C35538", Offset = "0x1C35538", VA = "0x1C35538")]
		public void Interpolate(float f, out Vector3 pos, out Vector3 up)
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x1C3565C", Offset = "0x1C3565C", VA = "0x1C3565C")]
		public void Move(ref float f, ref int direction, float speed, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x1C35694", Offset = "0x1C35694", VA = "0x1C35694")]
		public void MoveBy(ref float f, ref int direction, float speedDist, CurvyClamping clamping)
		{
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x1C348A0", Offset = "0x1C348A0", VA = "0x1C348A0", Slot = "6")]
		public virtual void Recalculate()
		{
		}

		[Token(Token = "0x6000B66")]
		[Address(RVA = "0x1C35720", Offset = "0x1C35720", VA = "0x1C35720")]
		public void RecalculateNormals(List<int> softEdges)
		{
		}
	}
	[Token(Token = "0x2000187")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C4664", Offset = "0x9C4664")]
	public class CGPath : CGShape
	{
		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3[] Direction;

		[Token(Token = "0x6000B67")]
		[Address(RVA = "0x1C33B64", Offset = "0x1C33B64", VA = "0x1C33B64")]
		public CGPath()
		{
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x1C33D10", Offset = "0x1C33D10", VA = "0x1C33D10")]
		public CGPath(CGPath source)
		{
		}

		[Token(Token = "0x6000B69")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x1C3415C", Offset = "0x1C3415C", VA = "0x1C3415C")]
		public static void Copy(CGPath dest, CGPath source)
		{
		}

		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x1C343D0", Offset = "0x1C343D0", VA = "0x1C343D0")]
		public void Interpolate(float f, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000B6C")]
		[Address(RVA = "0x1C345D8", Offset = "0x1C345D8", VA = "0x1C345D8")]
		public void Interpolate(float f, float angleF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000B6D")]
		[Address(RVA = "0x1C34644", Offset = "0x1C34644", VA = "0x1C34644")]
		public Vector3 InterpolateDirection(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x1C346F0", Offset = "0x1C346F0", VA = "0x1C346F0", Slot = "6")]
		public override void Recalculate()
		{
		}
	}
	[Token(Token = "0x2000188")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C4690", Offset = "0x9C4690")]
	public class CGVolume : CGPath
	{
		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3[] Vertex;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Vector3[] VertexNormal;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float[] CrossF;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float[] CrossMap;

		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float[] SegmentLength;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool CrossClosed;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA9")]
		public bool CrossSeamless;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float CrossFShift;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public SamplePointsMaterialGroupCollection CrossMaterialGroups;

		[Token(Token = "0x17000253")]
		public int CrossSize
		{
			[Token(Token = "0x6000B6F")]
			[Address(RVA = "0x1C371D4", Offset = "0x1C371D4", VA = "0x1C371D4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000254")]
		public int VertexCount
		{
			[Token(Token = "0x6000B70")]
			[Address(RVA = "0x1C39758", Offset = "0x1C39758", VA = "0x1C39758")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1C39774", Offset = "0x1C39774", VA = "0x1C39774")]
		public CGVolume()
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x1C39840", Offset = "0x1C39840", VA = "0x1C39840")]
		public CGVolume(int samplePoints, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x1C39AB8", Offset = "0x1C39AB8", VA = "0x1C39AB8")]
		public CGVolume(CGPath path, CGShape crossShape)
		{
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x1C39D38", Offset = "0x1C39D38", VA = "0x1C39D38")]
		public CGVolume(CGVolume source)
		{
		}

		[Token(Token = "0x6000B75")]
		[Address(RVA = "0x1C39FEC", Offset = "0x1C39FEC", VA = "0x1C39FEC")]
		public static CGVolume Get(CGVolume data, CGPath path, CGShape crossShape)
		{
			return null;
		}

		[Token(Token = "0x6000B76")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x1C3A200", Offset = "0x1C3A200", VA = "0x1C3A200")]
		public void InterpolateVolume(float f, float crossF, out Vector3 pos, out Vector3 dir, out Vector3 up)
		{
		}

		[Token(Token = "0x6000B78")]
		[Address(RVA = "0x1C3A43C", Offset = "0x1C3A43C", VA = "0x1C3A43C")]
		public Vector3 InterpolateVolumePosition(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B79")]
		[Address(RVA = "0x1C3A5A8", Offset = "0x1C3A5A8", VA = "0x1C3A5A8")]
		public Vector3 InterpolateVolumeDirection(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x1C3A6CC", Offset = "0x1C3A6CC", VA = "0x1C3A6CC")]
		public Vector3 InterpolateVolumeUp(float f, float crossF)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x1C3A810", Offset = "0x1C3A810", VA = "0x1C3A810")]
		public float GetCrossLength(float pathF)
		{
			return default(float);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x1C3AAAC", Offset = "0x1C3AAAC", VA = "0x1C3AAAC")]
		public float CrossFToDistance(float f, float crossF, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x1C3AAF0", Offset = "0x1C3AAF0", VA = "0x1C3AAF0")]
		public float CrossDistanceToF(float f, float distance, CurvyClamping crossClamping = CurvyClamping.Clamp)
		{
			return default(float);
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x1C3A924", Offset = "0x1C3A924", VA = "0x1C3A924")]
		public void GetSegmentIndices(float pathF, out int s0Index, out int s1Index, out float frag)
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x1C3AB38", Offset = "0x1C3AB38", VA = "0x1C3AB38")]
		public int GetSegmentIndex(int segment)
		{
			return default(int);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x1C3AB58", Offset = "0x1C3AB58", VA = "0x1C3AB58")]
		public int GetCrossFIndex(float crossF, out float frag)
		{
			return default(int);
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x1C3ABB8", Offset = "0x1C3ABB8", VA = "0x1C3ABB8")]
		public int GetVertexIndex(float pathF, out float pathFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x1C3A3EC", Offset = "0x1C3A3EC", VA = "0x1C3A3EC")]
		public int GetVertexIndex(float pathF, float crossF, out float pathFrag, out float crossFrag)
		{
			return default(int);
		}

		[Token(Token = "0x6000B83")]
		[Address(RVA = "0x1C3AC3C", Offset = "0x1C3AC3C", VA = "0x1C3AC3C")]
		public Vector3[] GetSegmentVertices(params int[] segmentIndices)
		{
			return null;
		}

		[Token(Token = "0x6000B84")]
		[Address(RVA = "0x1C3A9BC", Offset = "0x1C3A9BC", VA = "0x1C3A9BC")]
		private float calcSegmentLength(int segmentIndex)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000189")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C46B8", Offset = "0x9C46B8")]
	public class CGBounds : CGData
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Bounds? mBounds;

		[Token(Token = "0x17000255")]
		public Bounds Bounds
		{
			[Token(Token = "0x6000B85")]
			[Address(RVA = "0x171ECDC", Offset = "0x171ECDC", VA = "0x171ECDC")]
			get
			{
				return default(Bounds);
			}
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x171ED78", Offset = "0x171ED78", VA = "0x171ED78")]
			set
			{
			}
		}

		[Token(Token = "0x17000256")]
		public float Depth
		{
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x171EC10", Offset = "0x171EC10", VA = "0x171EC10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000B88")]
		[Address(RVA = "0x17205CC", Offset = "0x17205CC", VA = "0x17205CC")]
		public CGBounds()
		{
		}

		[Token(Token = "0x6000B89")]
		[Address(RVA = "0x17205DC", Offset = "0x17205DC", VA = "0x17205DC")]
		public CGBounds(Bounds bounds)
		{
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x171EC48", Offset = "0x171EC48", VA = "0x171EC48")]
		public CGBounds(CGBounds source)
		{
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x1720628", Offset = "0x1720628", VA = "0x1720628", Slot = "6")]
		public virtual void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000B8C")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B8D")]
		[Address(RVA = "0x1720650", Offset = "0x1720650", VA = "0x1720650")]
		public static void Copy(CGBounds dest, CGBounds source)
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class CGVSubMesh : CGData
	{
		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] Triangles;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material Material;

		[Token(Token = "0x17000257")]
		public override int Count
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x1C395AC", Offset = "0x1C395AC", VA = "0x1C395AC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x1C39074", Offset = "0x1C39074", VA = "0x1C39074")]
		public CGVSubMesh([Optional] Material material)
		{
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x1C379D4", Offset = "0x1C379D4", VA = "0x1C379D4")]
		public CGVSubMesh(int[] triangles, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x1C395C8", Offset = "0x1C395C8", VA = "0x1C395C8")]
		public CGVSubMesh(int triangleCount, [Optional] Material material)
		{
		}

		[Token(Token = "0x6000B92")]
		[Address(RVA = "0x1C374C0", Offset = "0x1C374C0", VA = "0x1C374C0")]
		public CGVSubMesh(CGVSubMesh source)
		{
		}

		[Token(Token = "0x6000B93")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000B94")]
		[Address(RVA = "0x1C39650", Offset = "0x1C39650", VA = "0x1C39650")]
		public static CGVSubMesh Get(CGVSubMesh data, int triangleCount, [Optional] Material material)
		{
			return null;
		}

		[Token(Token = "0x6000B95")]
		[Address(RVA = "0x1C396FC", Offset = "0x1C396FC", VA = "0x1C396FC")]
		public void ShiftIndices(int offset, int startIndex = 0)
		{
		}

		[Token(Token = "0x6000B96")]
		[Address(RVA = "0x1C384C0", Offset = "0x1C384C0", VA = "0x1C384C0")]
		public void Add(CGVSubMesh other, int shiftIndexOffset = 0)
		{
		}
	}
	[Token(Token = "0x200018B")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C46DC", Offset = "0x9C46DC")]
	public class CGVMesh : CGBounds
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3[] Vertex;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2[] UV;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2[] UV2;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3[] Normal;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector4[] Tangents;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CGVSubMesh[] SubMeshes;

		[Token(Token = "0x17000258")]
		public override int Count
		{
			[Token(Token = "0x6000B97")]
			[Address(RVA = "0x1C36DE4", Offset = "0x1C36DE4", VA = "0x1C36DE4", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000259")]
		public bool HasUV
		{
			[Token(Token = "0x6000B98")]
			[Address(RVA = "0x1C36E00", Offset = "0x1C36E00", VA = "0x1C36E00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025A")]
		public bool HasUV2
		{
			[Token(Token = "0x6000B99")]
			[Address(RVA = "0x1C36E24", Offset = "0x1C36E24", VA = "0x1C36E24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025B")]
		public bool HasNormals
		{
			[Token(Token = "0x6000B9A")]
			[Address(RVA = "0x1C36E48", Offset = "0x1C36E48", VA = "0x1C36E48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025C")]
		public bool HasTangents
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x1C36E6C", Offset = "0x1C36E6C", VA = "0x1C36E6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700025D")]
		public int TriangleCount
		{
			[Token(Token = "0x6000B9C")]
			[Address(RVA = "0x1C36E90", Offset = "0x1C36E90", VA = "0x1C36E90")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x1C36F1C", Offset = "0x1C36F1C", VA = "0x1C36F1C")]
		public CGVMesh()
		{
		}

		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x1C36F34", Offset = "0x1C36F34", VA = "0x1C36F34")]
		public CGVMesh(int vertexCount, bool addUV = false, bool addUV2 = false, bool addNormals = false, bool addTangents = false)
		{
		}

		[Token(Token = "0x6000B9F")]
		[Address(RVA = "0x1C370A0", Offset = "0x1C370A0", VA = "0x1C370A0")]
		public CGVMesh(CGVolume volume)
		{
		}

		[Token(Token = "0x6000BA0")]
		[Address(RVA = "0x1C370FC", Offset = "0x1C370FC", VA = "0x1C370FC")]
		public CGVMesh(CGVolume volume, IntRegion subset)
		{
		}

		[Token(Token = "0x6000BA1")]
		[Address(RVA = "0x1C371F0", Offset = "0x1C371F0", VA = "0x1C371F0")]
		public CGVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000BA2")]
		[Address(RVA = "0x1C37578", Offset = "0x1C37578", VA = "0x1C37578")]
		public CGVMesh(CGMeshProperties meshProperties)
		{
		}

		[Token(Token = "0x6000BA3")]
		[Address(RVA = "0x1C375E4", Offset = "0x1C375E4", VA = "0x1C375E4")]
		public CGVMesh(Mesh source, Material[] materials, Matrix4x4 trsMatrix)
		{
		}

		[Token(Token = "0x6000BA4")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000BA5")]
		[Address(RVA = "0x1C37AEC", Offset = "0x1C37AEC", VA = "0x1C37AEC")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x6000BA6")]
		[Address(RVA = "0x1C37B74", Offset = "0x1C37B74", VA = "0x1C37B74")]
		public static CGVMesh Get(CGVMesh data, CGVolume source, IntRegion subset, bool addUV, bool reverseNormals)
		{
			return null;
		}

		[Token(Token = "0x6000BA7")]
		[Address(RVA = "0x1C37E98", Offset = "0x1C37E98", VA = "0x1C37E98")]
		public void SetSubMeshCount(int count)
		{
		}

		[Token(Token = "0x6000BA8")]
		[Address(RVA = "0x1C37EF4", Offset = "0x1C37EF4", VA = "0x1C37EF4")]
		public void AddSubMesh([Optional] CGVSubMesh submesh)
		{
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x1C37F60", Offset = "0x1C37F60", VA = "0x1C37F60")]
		public void MergeVMesh(CGVMesh source)
		{
		}

		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x1C385C0", Offset = "0x1C385C0", VA = "0x1C385C0")]
		public void MergeVMesh(CGVMesh source, Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x1C387BC", Offset = "0x1C387BC", VA = "0x1C387BC")]
		public void MergeVMeshes(List<CGVMesh> vMeshes, int startIndex, int endIndex)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x1C3809C", Offset = "0x1C3809C", VA = "0x1C3809C")]
		private void MergeUVsNormalsAndTangents(CGVMesh source, int preMergeVertexCount)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x1C38384", Offset = "0x1C38384", VA = "0x1C38384")]
		public CGVSubMesh GetMaterialSubMesh(Material mat, bool createIfMissing = true)
		{
			return null;
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x1C390F8", Offset = "0x1C390F8", VA = "0x1C390F8")]
		public Mesh AsMesh()
		{
			return null;
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x1C3916C", Offset = "0x1C3916C", VA = "0x1C3916C")]
		public void ToMesh(ref Mesh msh)
		{
		}

		[Token(Token = "0x6000BB0")]
		[Address(RVA = "0x1C392A8", Offset = "0x1C392A8", VA = "0x1C392A8")]
		public Material[] GetMaterials()
		{
			return null;
		}

		[Token(Token = "0x6000BB1")]
		[Address(RVA = "0x1C393AC", Offset = "0x1C393AC", VA = "0x1C393AC", Slot = "6")]
		public override void RecalculateBounds()
		{
		}

		[Token(Token = "0x6000BB2")]
		[Address(RVA = "0x1C3957C", Offset = "0x1C3957C", VA = "0x1C3957C")]
		public void RecalculateUV2()
		{
		}

		[Token(Token = "0x6000BB3")]
		[Address(RVA = "0x1C37A24", Offset = "0x1C37A24", VA = "0x1C37A24")]
		public void TRS(Matrix4x4 matrix)
		{
		}

		[Token(Token = "0x6000BB4")]
		private void copyData<T>(ref T[] src, ref T[] dst, int currentSize, int extraSize)
		{
		}
	}
	[Token(Token = "0x200018C")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C4700", Offset = "0x9C4700")]
	public class CGGameObject : CGBounds
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject Object;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 Translate;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 Rotate;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 Scale;

		[Token(Token = "0x1700025E")]
		public Matrix4x4 Matrix
		{
			[Token(Token = "0x6000BB5")]
			[Address(RVA = "0x1721740", Offset = "0x1721740", VA = "0x1721740")]
			get
			{
				return default(Matrix4x4);
			}
		}

		[Token(Token = "0x6000BB6")]
		[Address(RVA = "0x17217E4", Offset = "0x17217E4", VA = "0x17217E4")]
		public CGGameObject()
		{
		}

		[Token(Token = "0x6000BB7")]
		[Address(RVA = "0x1721818", Offset = "0x1721818", VA = "0x1721818")]
		public CGGameObject(CGGameObjectProperties properties)
		{
		}

		[Token(Token = "0x6000BB8")]
		[Address(RVA = "0x17219A4", Offset = "0x17219A4", VA = "0x17219A4")]
		public CGGameObject(GameObject obj)
		{
		}

		[Token(Token = "0x6000BB9")]
		[Address(RVA = "0x1721860", Offset = "0x1721860", VA = "0x1721860")]
		public CGGameObject(GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
		}

		[Token(Token = "0x6000BBA")]
		[Address(RVA = "0x1721A40", Offset = "0x1721A40", VA = "0x1721A40")]
		public CGGameObject(CGGameObject source)
		{
		}

		[Token(Token = "0x6000BBB")]
		public override T Clone<T>()
		{
			return null;
		}

		[Token(Token = "0x6000BBC")]
		[Address(RVA = "0x1721AC4", Offset = "0x1721AC4", VA = "0x1721AC4")]
		public static CGGameObject Get(CGGameObject data, GameObject obj, Vector3 translate, Vector3 rotate, Vector3 scale)
		{
			return null;
		}

		[Token(Token = "0x6000BBD")]
		[Address(RVA = "0x1721C10", Offset = "0x1721C10", VA = "0x1721C10", Slot = "6")]
		public override void RecalculateBounds()
		{
		}
	}
	[Token(Token = "0x200018D")]
	[AttributeAttribute(Name = "CGDataInfoAttribute", RVA = "0x9C4738", Offset = "0x9C4738")]
	public class CGSpots : CGData
	{
		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CGSpot[] Points;

		[Token(Token = "0x1700025F")]
		public override int Count
		{
			[Token(Token = "0x6000BBE")]
			[Address(RVA = "0x1C363DC", Offset = "0x1C363DC", VA = "0x1C363DC", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000BBF")]
		[Address(RVA = "0x1C363F8", Offset = "0x1C363F8", VA = "0x1C363F8")]
		public CGSpots()
		{
		}

		[Token(Token = "0x6000BC0")]
		[Address(RVA = "0x1C36460", Offset = "0x1C36460", VA = "0x1C36460")]
		public CGSpots(params CGSpot[] points)
		{
		}

		[Token(Token = "0x6000BC1")]
		[Address(RVA = "0x1C36494", Offset = "0x1C36494", VA = "0x1C36494")]
		public CGSpots(params List<CGSpot>[] lists)
		{
		}

		[Token(Token = "0x6000BC2")]
		[Address(RVA = "0x1C365E8", Offset = "0x1C365E8", VA = "0x1C365E8")]
		public CGSpots(CGSpots source)
		{
		}

		[Token(Token = "0x6000BC3")]
		public override T Clone<T>()
		{
			return null;
		}
	}
	[Token(Token = "0x200018E")]
	public class CGDataRequestParameter
	{
		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1721558", Offset = "0x1721558", VA = "0x1721558")]
		public static implicit operator bool(CGDataRequestParameter a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x1721390", Offset = "0x1721390", VA = "0x1721390")]
		public CGDataRequestParameter()
		{
		}
	}
	[Token(Token = "0x200018F")]
	public class CGDataRequestMetaCGOptions : CGDataRequestParameter
	{
		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool CheckHardEdges;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool CheckMaterialID;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool IncludeControlPoints;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
		public bool CheckExtendedUV;

		[Token(Token = "0x6000BC6")]
		[Address(RVA = "0x1719984", Offset = "0x1719984", VA = "0x1719984")]
		public CGDataRequestMetaCGOptions(bool checkEdges, bool checkMaterials, bool includeCP, bool extendedUV)
		{
		}

		[Token(Token = "0x6000BC7")]
		[Address(RVA = "0x1721398", Offset = "0x1721398", VA = "0x1721398", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BC8")]
		[Address(RVA = "0x17214A8", Offset = "0x17214A8", VA = "0x17214A8", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000190")]
	public class CGDataRequestRasterization : CGDataRequestParameter
	{
		[Token(Token = "0x2000191")]
		public enum ModeEnum
		{
			[Token(Token = "0x4000721")]
			Even,
			[Token(Token = "0x4000722")]
			Optimized
		}

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float Start;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float RasterizedRelativeLength;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Resolution;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SplineAbsoluteLength;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float AngleThreshold;

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ModeEnum Mode;

		[Token(Token = "0x6000BC9")]
		[Address(RVA = "0x1717A84", Offset = "0x1717A84", VA = "0x1717A84")]
		public CGDataRequestRasterization(float start, float rasterizedRelativeLength, int resolution, float splineAbsoluteLength, float angle, ModeEnum mode = ModeEnum.Even)
		{
		}

		[Token(Token = "0x6000BCA")]
		[Address(RVA = "0x1721564", Offset = "0x1721564", VA = "0x1721564")]
		public CGDataRequestRasterization(CGDataRequestRasterization source)
		{
		}

		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0x172158C", Offset = "0x172158C", VA = "0x172158C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0x1721680", Offset = "0x1721680", VA = "0x1721680", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000192")]
	public interface INoProcessing
	{
	}
	[Token(Token = "0x2000193")]
	public interface IExternalInput
	{
		[Token(Token = "0x17000260")]
		bool SupportsIPE
		{
			[Token(Token = "0x6000BCD")]
			get;
		}
	}
	[Token(Token = "0x2000194")]
	public interface IOnRequestProcessing
	{
		[Token(Token = "0x6000BCE")]
		CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests);
	}
	[Token(Token = "0x2000195")]
	public interface IOnRequestPath : IOnRequestProcessing
	{
		[Token(Token = "0x17000261")]
		float PathLength
		{
			[Token(Token = "0x6000BCF")]
			get;
		}

		[Token(Token = "0x17000262")]
		bool PathIsClosed
		{
			[Token(Token = "0x6000BD0")]
			get;
		}
	}
	[Token(Token = "0x2000196")]
	public interface ICGResourceLoader
	{
		[Token(Token = "0x6000BD1")]
		UnityEngine.Component Create(CGModule cgModule, string context);

		[Token(Token = "0x6000BD2")]
		void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill);
	}
	[Token(Token = "0x2000197")]
	public interface ICGResourceCollection
	{
		[Token(Token = "0x17000263")]
		int Count
		{
			[Token(Token = "0x6000BD3")]
			get;
		}

		[Token(Token = "0x17000264")]
		UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000BD4")]
			get;
		}
	}
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C475C", Offset = "0x9C475C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C475C", Offset = "0x9C475C")]
	public class CGMeshResource : DuplicateEditorMesh, IPoolable
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MeshRenderer mRenderer;

		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider mCollider;

		[Token(Token = "0x17000265")]
		public MeshRenderer Renderer
		{
			[Token(Token = "0x6000BD5")]
			[Address(RVA = "0x1722C3C", Offset = "0x1722C3C", VA = "0x1722C3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000266")]
		public Collider Collider
		{
			[Token(Token = "0x6000BD6")]
			[Address(RVA = "0x1722CF0", Offset = "0x1722CF0", VA = "0x1722CF0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x1722DA4", Offset = "0x1722DA4", VA = "0x1722DA4")]
		public Mesh Prepare()
		{
			return null;
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x1722DFC", Offset = "0x1722DFC", VA = "0x1722DFC")]
		public bool ColliderMatches(CGColliderEnum type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x1722F98", Offset = "0x1722F98", VA = "0x1722F98")]
		public void RemoveCollider()
		{
		}

		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x1723094", Offset = "0x1723094", VA = "0x1723094")]
		public bool UpdateCollider(CGColliderEnum mode, bool convex, PhysicMaterial material, MeshColliderCookingOptions meshCookingOptions = MeshColliderCookingOptions.CookForFasterSimulation | MeshColliderCookingOptions.EnableMeshCleaning | MeshColliderCookingOptions.WeldColocatedVertices)
		{
			return default(bool);
		}

		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x1723684", Offset = "0x1723684", VA = "0x1723684", Slot = "5")]
		public void OnBeforePush()
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x1723688", Offset = "0x1723688", VA = "0x1723688", Slot = "6")]
		public void OnAfterPop()
		{
		}

		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x172368C", Offset = "0x172368C", VA = "0x172368C")]
		public CGMeshResource()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000199")]
	public class CGMeshResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<CGMeshResource> Items;

		[Token(Token = "0x17000267")]
		public int Count
		{
			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x1723694", Offset = "0x1723694", VA = "0x1723694", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000268")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x17236E0", Offset = "0x17236E0", VA = "0x17236E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000BE0")]
		[Address(RVA = "0x1723734", Offset = "0x1723734", VA = "0x1723734")]
		public CGMeshResourceCollection()
		{
		}
	}
	[Token(Token = "0x200019A")]
	[ExecuteInEditMode]
	public class CGModule : DTVersionedMonoBehaviour
	{
		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9CBEA4", Offset = "0x9CBEA4")]
		private CurvyCGEvent m_OnBeforeRefresh;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9CBF00", Offset = "0x9CBF00")]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private string m_ModuleName;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private bool m_Active;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9CBFBC", Offset = "0x9CBFBC")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9CBFBC", Offset = "0x9CBFBC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9CBFBC", Offset = "0x9CBFBC")]
		[SerializeField]
		private bool m_RandomizeSeed;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[HideInInspector]
		[SerializeField]
		private int m_Seed;

		[NonSerialized]
		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public List<string> UIMessages;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CurvyGenerator mGenerator;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private int m_UniqueID;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC0D8", Offset = "0x9CC0D8")]
		private bool <CircularReferenceError>k__BackingField;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		internal int SortAncestors;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public CGModuleProperties Properties;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public List<CGModuleLink> InputLinks;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public List<CGModuleLink> OutputLinks;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC118", Offset = "0x9CC118")]
		private Dictionary<string, CGModuleInputSlot> <InputByName>k__BackingField;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC128", Offset = "0x9CC128")]
		private Dictionary<string, CGModuleOutputSlot> <OutputByName>k__BackingField;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC138", Offset = "0x9CC138")]
		private List<CGModuleInputSlot> <Input>k__BackingField;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC148", Offset = "0x9CC148")]
		private List<CGModuleOutputSlot> <Output>k__BackingField;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ModuleInfoAttribute mInfo;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private bool mDirty;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool mInitialized;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		private bool mIsConfiguredInternal;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA3")]
		private bool mStateChangeDirty;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool mLastIsConfiguredState;

		[Token(Token = "0x17000269")]
		public CurvyCGEvent OnBeforeRefresh
		{
			[Token(Token = "0x6000BE1")]
			[Address(RVA = "0x1723B18", Offset = "0x1723B18", VA = "0x1723B18")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE2")]
			[Address(RVA = "0x1723B20", Offset = "0x1723B20", VA = "0x1723B20")]
			set
			{
			}
		}

		[Token(Token = "0x1700026A")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000BE3")]
			[Address(RVA = "0x1723B38", Offset = "0x1723B38", VA = "0x1723B38")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE4")]
			[Address(RVA = "0x1723B40", Offset = "0x1723B40", VA = "0x1723B40")]
			set
			{
			}
		}

		[Token(Token = "0x1700026B")]
		public string ModuleName
		{
			[Token(Token = "0x6000BE7")]
			[Address(RVA = "0x1723C28", Offset = "0x1723C28", VA = "0x1723C28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BE8")]
			[Address(RVA = "0x1723C30", Offset = "0x1723C30", VA = "0x1723C30")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public bool Active
		{
			[Token(Token = "0x6000BE9")]
			[Address(RVA = "0x1723E80", Offset = "0x1723E80", VA = "0x1723E80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BEA")]
			[Address(RVA = "0x1723E88", Offset = "0x1723E88", VA = "0x1723E88")]
			set
			{
			}
		}

		[Token(Token = "0x1700026D")]
		public int Seed
		{
			[Token(Token = "0x6000BEB")]
			[Address(RVA = "0x1723EE4", Offset = "0x1723EE4", VA = "0x1723EE4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000BEC")]
			[Address(RVA = "0x1723EEC", Offset = "0x1723EEC", VA = "0x1723EEC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026E")]
		public bool RandomizeSeed
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x1723F04", Offset = "0x1723F04", VA = "0x1723F04")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BEE")]
			[Address(RVA = "0x1723F0C", Offset = "0x1723F0C", VA = "0x1723F0C")]
			set
			{
			}
		}

		[Token(Token = "0x1700026F")]
		public CurvyGenerator Generator
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x1723F2C", Offset = "0x1723F2C", VA = "0x1723F2C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000270")]
		public int UniqueID
		{
			[Token(Token = "0x6000BF0")]
			[Address(RVA = "0x1723F34", Offset = "0x1723F34", VA = "0x1723F34")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000271")]
		public bool CircularReferenceError
		{
			[Token(Token = "0x6000BF1")]
			[Address(RVA = "0x1723F3C", Offset = "0x1723F3C", VA = "0x1723F3C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D285C", Offset = "0x9D285C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BF2")]
			[Address(RVA = "0x1723F44", Offset = "0x1723F44", VA = "0x1723F44")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D286C", Offset = "0x9D286C")]
			set
			{
			}
		}

		[Token(Token = "0x17000272")]
		public Dictionary<string, CGModuleInputSlot> InputByName
		{
			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0x1723F50", Offset = "0x1723F50", VA = "0x1723F50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D287C", Offset = "0x9D287C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0x1723F58", Offset = "0x1723F58", VA = "0x1723F58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D288C", Offset = "0x9D288C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000273")]
		public Dictionary<string, CGModuleOutputSlot> OutputByName
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x1723F60", Offset = "0x1723F60", VA = "0x1723F60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D289C", Offset = "0x9D289C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0x1723F68", Offset = "0x1723F68", VA = "0x1723F68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28AC", Offset = "0x9D28AC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000274")]
		public List<CGModuleInputSlot> Input
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x1723F70", Offset = "0x1723F70", VA = "0x1723F70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28BC", Offset = "0x9D28BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0x1723F78", Offset = "0x1723F78", VA = "0x1723F78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28CC", Offset = "0x9D28CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000275")]
		public List<CGModuleOutputSlot> Output
		{
			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0x1723F80", Offset = "0x1723F80", VA = "0x1723F80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28DC", Offset = "0x9D28DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000BFA")]
			[Address(RVA = "0x1723F88", Offset = "0x1723F88", VA = "0x1723F88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28EC", Offset = "0x9D28EC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000276")]
		public ModuleInfoAttribute Info
		{
			[Token(Token = "0x6000BFB")]
			[Address(RVA = "0x1723F90", Offset = "0x1723F90", VA = "0x1723F90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000277")]
		public bool Dirty
		{
			[Token(Token = "0x6000BFC")]
			[Address(RVA = "0x17240D8", Offset = "0x17240D8", VA = "0x17240D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BFD")]
			[Address(RVA = "0x171704C", Offset = "0x171704C", VA = "0x171704C")]
			set
			{
			}
		}

		[Token(Token = "0x17000278")]
		public virtual bool IsConfigured
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x1725A74", Offset = "0x1725A74", VA = "0x1725A74", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000279")]
		public virtual bool IsInitialized
		{
			[Token(Token = "0x6000C05")]
			[Address(RVA = "0x1725CAC", Offset = "0x1725CAC", VA = "0x1725CAC", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1723B58", Offset = "0x1723B58", VA = "0x1723B58")]
		protected CurvyCGEventArgs OnBeforeRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1723BC0", Offset = "0x1723BC0", VA = "0x1723BC0")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000BFE")]
		[Address(RVA = "0x1719FD0", Offset = "0x1719FD0", VA = "0x1719FD0", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000BFF")]
		[Address(RVA = "0x17175E8", Offset = "0x17175E8", VA = "0x17175E8", Slot = "6")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x17242F0", Offset = "0x17242F0", VA = "0x17242F0")]
		public void Initialize()
		{
		}

		[Token(Token = "0x6000C01")]
		[Address(RVA = "0x17249B8", Offset = "0x17249B8", VA = "0x17249B8", Slot = "7")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000C02")]
		[Address(RVA = "0x17249BC", Offset = "0x17249BC", VA = "0x17249BC", Slot = "8")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000C03")]
		[Address(RVA = "0x1725A6C", Offset = "0x1725A6C", VA = "0x1725A6C")]
		private void OnDidApplyAnimationProperties()
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x1717A30", Offset = "0x1717A30", VA = "0x1717A30", Slot = "11")]
		public virtual void Refresh()
		{
		}

		[Token(Token = "0x6000C07")]
		[Address(RVA = "0x17176D4", Offset = "0x17176D4", VA = "0x17176D4", Slot = "12")]
		public virtual void Reset()
		{
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x1725CB4", Offset = "0x1725CB4", VA = "0x1725CB4")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x171DB98", Offset = "0x171DB98", VA = "0x171DB98", Slot = "13")]
		public virtual void OnStateChange()
		{
		}

		[Token(Token = "0x6000C0A")]
		[Address(RVA = "0x1725DD8", Offset = "0x1725DD8", VA = "0x1725DD8", Slot = "14")]
		public virtual void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000C0B")]
		protected static T GetRequestParameter<T>(ref CGDataRequestParameter[] requests) where T : CGDataRequestParameter
		{
			return null;
		}

		[Token(Token = "0x6000C0C")]
		[Address(RVA = "0x1725DDC", Offset = "0x1725DDC", VA = "0x1725DDC")]
		protected static void RemoveRequestParameter(ref CGDataRequestParameter[] requests, CGDataRequestParameter request)
		{
		}

		[Token(Token = "0x6000C0D")]
		[Address(RVA = "0x1725E9C", Offset = "0x1725E9C", VA = "0x1725E9C")]
		public CGModuleLink GetOutputLink(CGModuleOutputSlot outSlot, CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000C0E")]
		[Address(RVA = "0x1725F84", Offset = "0x1725F84", VA = "0x1725F84")]
		public List<CGModuleLink> GetOutputLinks(CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000C0F")]
		[Address(RVA = "0x17260C8", Offset = "0x17260C8", VA = "0x17260C8")]
		public CGModuleLink GetInputLink(CGModuleInputSlot inSlot, CGModuleOutputSlot outSlot)
		{
			return null;
		}

		[Token(Token = "0x6000C10")]
		[Address(RVA = "0x17260D0", Offset = "0x17260D0", VA = "0x17260D0")]
		public List<CGModuleLink> GetInputLinks(CGModuleInputSlot inSlot)
		{
			return null;
		}

		[Token(Token = "0x6000C11")]
		[Address(RVA = "0x1725EA4", Offset = "0x1725EA4", VA = "0x1725EA4")]
		private static CGModuleLink GetLink(List<CGModuleLink> lst, CGModuleSlot source, CGModuleSlot target)
		{
			return null;
		}

		[Token(Token = "0x6000C12")]
		[Address(RVA = "0x1725F8C", Offset = "0x1725F8C", VA = "0x1725F8C")]
		private static List<CGModuleLink> GetLinks(List<CGModuleLink> lst, CGModuleSlot source)
		{
			return null;
		}

		[Token(Token = "0x6000C13")]
		[Address(RVA = "0x17260D8", Offset = "0x17260D8", VA = "0x17260D8")]
		public CGModule CopyTo(CurvyGenerator targetGenerator)
		{
			return null;
		}

		[Token(Token = "0x6000C14")]
		[Address(RVA = "0x1726204", Offset = "0x1726204", VA = "0x1726204")]
		public UnityEngine.Component AddManagedResource(string resourceName, string context = "", int index = -1)
		{
			return null;
		}

		[Token(Token = "0x6000C15")]
		[Address(RVA = "0x17254B4", Offset = "0x17254B4", VA = "0x17254B4")]
		public void DeleteManagedResource(string resourceName, UnityEngine.Component res, string context = "", bool dontUsePool = false)
		{
		}

		[Token(Token = "0x6000C16")]
		[Address(RVA = "0x172649C", Offset = "0x172649C", VA = "0x172649C")]
		public bool IsManagedResource(UnityEngine.Component res)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C17")]
		[Address(RVA = "0x17262F4", Offset = "0x17262F4", VA = "0x17262F4")]
		protected void RenameResource(string resourceName, UnityEngine.Component resource, int index = -1)
		{
		}

		[Token(Token = "0x6000C18")]
		[Address(RVA = "0x1726584", Offset = "0x1726584", VA = "0x1726584")]
		protected PrefabPool GetPrefabPool(GameObject prefab)
		{
			return null;
		}

		[Token(Token = "0x6000C19")]
		[Address(RVA = "0x17266FC", Offset = "0x17266FC", VA = "0x17266FC")]
		public List<IPool> GetAllPrefabPools()
		{
			return null;
		}

		[Token(Token = "0x6000C1A")]
		[Address(RVA = "0x17267D4", Offset = "0x17267D4", VA = "0x17267D4")]
		public void DeleteAllPrefabPools()
		{
		}

		[Token(Token = "0x6000C1B")]
		[Address(RVA = "0x17268AC", Offset = "0x17268AC", VA = "0x17268AC")]
		public void Delete()
		{
		}

		[Token(Token = "0x6000C1C")]
		[Address(RVA = "0x1726950", Offset = "0x1726950", VA = "0x1726950")]
		public CGModuleInputSlot GetInputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000C1D")]
		[Address(RVA = "0x1725598", Offset = "0x1725598", VA = "0x1725598")]
		public List<CGModuleInputSlot> GetInputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000C1E")]
		[Address(RVA = "0x17210A4", Offset = "0x17210A4", VA = "0x17210A4")]
		public CGModuleOutputSlot GetOutputSlot(string name)
		{
			return null;
		}

		[Token(Token = "0x6000C1F")]
		[Address(RVA = "0x1725808", Offset = "0x1725808", VA = "0x1725808")]
		public List<CGModuleOutputSlot> GetOutputSlots([Optional] Type filterType)
		{
			return null;
		}

		[Token(Token = "0x6000C20")]
		[Address(RVA = "0x1724FB8", Offset = "0x1724FB8", VA = "0x1724FB8")]
		public bool GetManagedResources(out List<UnityEngine.Component> components, out List<string> componentNames)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C21")]
		[Address(RVA = "0x17261D8", Offset = "0x17261D8", VA = "0x17261D8")]
		public int SetUniqueIdINTERNAL()
		{
			return default(int);
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x17269EC", Offset = "0x17269EC", VA = "0x17269EC")]
		internal void initializeSort()
		{
		}

		[Token(Token = "0x6000C23")]
		[Address(RVA = "0x1726AA4", Offset = "0x1726AA4", VA = "0x1726AA4")]
		internal List<CGModule> decrementChilds()
		{
			return null;
		}

		[Token(Token = "0x6000C24")]
		[Address(RVA = "0x1726CD4", Offset = "0x1726CD4", VA = "0x1726CD4")]
		internal void doRefresh()
		{
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x1726E1C", Offset = "0x1726E1C", VA = "0x1726E1C")]
		private static void setSeed(int seed)
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x1723FD4", Offset = "0x1723FD4", VA = "0x1723FD4")]
		internal ModuleInfoAttribute getInfo()
		{
			return null;
		}

		[Token(Token = "0x6000C27")]
		[Address(RVA = "0x1726E24", Offset = "0x1726E24", VA = "0x1726E24")]
		private bool usesRandom()
		{
			return default(bool);
		}

		[Token(Token = "0x6000C28")]
		[Address(RVA = "0x17244F8", Offset = "0x17244F8", VA = "0x17244F8")]
		private void loadSlots()
		{
		}

		[Token(Token = "0x6000C29")]
		[Address(RVA = "0x1726E70", Offset = "0x1726E70", VA = "0x1726E70")]
		private SlotInfo getSlotInfo(FieldInfo f)
		{
			return null;
		}

		[Token(Token = "0x6000C2A")]
		[Address(RVA = "0x1724DD8", Offset = "0x1724DD8", VA = "0x1724DD8")]
		private void setTreeDirtyStateChange()
		{
		}

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x17240E0", Offset = "0x17240E0", VA = "0x17240E0")]
		private void setTreeDirtyState()
		{
		}

		[Token(Token = "0x6000C2C")]
		[Address(RVA = "0x17272E8", Offset = "0x17272E8", VA = "0x17272E8")]
		public void checkOnStateChangedINTERNAL()
		{
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x1723C88", Offset = "0x1723C88", VA = "0x1723C88")]
		public void renameManagedResourcesINTERNAL()
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x1717BC8", Offset = "0x1717BC8", VA = "0x1717BC8")]
		public CGModule()
		{
		}
	}
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C4800", Offset = "0x9C4800")]
	public sealed class ModuleInfoAttribute : Attribute, IComparable
	{
		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string MenuName;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string ModuleName;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UsesRandom;

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x167685C", Offset = "0x167685C", VA = "0x167685C")]
		public ModuleInfoAttribute(string name)
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x1676890", Offset = "0x1676890", VA = "0x1676890", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Serializable]
	[Token(Token = "0x200019C")]
	public class CGModuleProperties
	{
		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rect Dimensions;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MinWidth;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LabelWidth;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color BackgroundColor;

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x1C335A8", Offset = "0x1C335A8", VA = "0x1C335A8")]
		public CGModuleProperties()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200019D")]
	public class CGModuleLink
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_ModuleID;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string m_SlotName;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_TargetModuleID;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string m_TargetSlotName;

		[Token(Token = "0x1700027A")]
		public int ModuleID
		{
			[Token(Token = "0x6000C32")]
			[Address(RVA = "0x1C32628", Offset = "0x1C32628", VA = "0x1C32628")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700027B")]
		public string SlotName
		{
			[Token(Token = "0x6000C33")]
			[Address(RVA = "0x1C32630", Offset = "0x1C32630", VA = "0x1C32630")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027C")]
		public int TargetModuleID
		{
			[Token(Token = "0x6000C34")]
			[Address(RVA = "0x1C32638", Offset = "0x1C32638", VA = "0x1C32638")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700027D")]
		public string TargetSlotName
		{
			[Token(Token = "0x6000C35")]
			[Address(RVA = "0x1C32640", Offset = "0x1C32640", VA = "0x1C32640")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C36")]
		[Address(RVA = "0x1C32648", Offset = "0x1C32648", VA = "0x1C32648")]
		public CGModuleLink(int sourceID, string sourceSlotName, int targetID, string targetSlotName)
		{
		}

		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x1C31934", Offset = "0x1C31934", VA = "0x1C31934")]
		public CGModuleLink(CGModuleSlot source, CGModuleSlot target)
		{
		}

		[Token(Token = "0x6000C38")]
		[Address(RVA = "0x1C32708", Offset = "0x1C32708", VA = "0x1C32708")]
		public bool IsSame(CGModuleLink o)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x1C32780", Offset = "0x1C32780", VA = "0x1C32780")]
		public bool IsSame(CGModuleSlot source, CGModuleSlot target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x1C32894", Offset = "0x1C32894", VA = "0x1C32894")]
		public bool IsTo(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x1C32934", Offset = "0x1C32934", VA = "0x1C32934")]
		public bool IsFrom(CGModuleSlot s)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x1C329D4", Offset = "0x1C329D4", VA = "0x1C329D4")]
		public bool IsUsing(CGModule module)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x1C32A0C", Offset = "0x1C32A0C", VA = "0x1C32A0C")]
		public bool IsBetween(CGModuleSlot one, CGModuleSlot another)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C3E")]
		[Address(RVA = "0x1C32A84", Offset = "0x1C32A84", VA = "0x1C32A84")]
		public void SetModuleIDIINTERNAL(int moduleID, int targetModuleID)
		{
		}

		[Token(Token = "0x6000C3F")]
		[Address(RVA = "0x1C31928", Offset = "0x1C31928", VA = "0x1C31928")]
		public static implicit operator bool(CGModuleLink a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x1C32A90", Offset = "0x1C32A90", VA = "0x1C32A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200019E")]
	public class CGModuleSlot
	{
		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC198", Offset = "0x9CC198")]
		private CGModule <Module>k__BackingField;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC1A8", Offset = "0x9CC1A8")]
		private SlotInfo <Info>k__BackingField;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC1B8", Offset = "0x9CC1B8")]
		private Vector2 <Origin>k__BackingField;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC1C8", Offset = "0x9CC1C8")]
		private Rect <DropZone>k__BackingField;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<CGModuleSlot> mLinkedSlots;

		[Token(Token = "0x1700027E")]
		public CGModule Module
		{
			[Token(Token = "0x6000C41")]
			[Address(RVA = "0x1C335E4", Offset = "0x1C335E4", VA = "0x1C335E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D28FC", Offset = "0x9D28FC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C42")]
			[Address(RVA = "0x1C335EC", Offset = "0x1C335EC", VA = "0x1C335EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D290C", Offset = "0x9D290C")]
			internal set
			{
			}
		}

		[Token(Token = "0x1700027F")]
		public SlotInfo Info
		{
			[Token(Token = "0x6000C43")]
			[Address(RVA = "0x1C335F4", Offset = "0x1C335F4", VA = "0x1C335F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D291C", Offset = "0x9D291C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C44")]
			[Address(RVA = "0x1C335FC", Offset = "0x1C335FC", VA = "0x1C335FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D292C", Offset = "0x9D292C")]
			internal set
			{
			}
		}

		[Token(Token = "0x17000280")]
		public Vector2 Origin
		{
			[Token(Token = "0x6000C45")]
			[Address(RVA = "0x1C33604", Offset = "0x1C33604", VA = "0x1C33604")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D293C", Offset = "0x9D293C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000C46")]
			[Address(RVA = "0x1C3360C", Offset = "0x1C3360C", VA = "0x1C3360C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D294C", Offset = "0x9D294C")]
			set
			{
			}
		}

		[Token(Token = "0x17000281")]
		public Rect DropZone
		{
			[Token(Token = "0x6000C47")]
			[Address(RVA = "0x1C33614", Offset = "0x1C33614", VA = "0x1C33614")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D295C", Offset = "0x9D295C")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000C48")]
			[Address(RVA = "0x1C33620", Offset = "0x1C33620", VA = "0x1C33620")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D296C", Offset = "0x9D296C")]
			set
			{
			}
		}

		[Token(Token = "0x17000282")]
		public bool IsLinked
		{
			[Token(Token = "0x6000C49")]
			[Address(RVA = "0x1C332B0", Offset = "0x1C332B0", VA = "0x1C332B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000283")]
		public bool IsLinkedAndConfigured
		{
			[Token(Token = "0x6000C4A")]
			[Address(RVA = "0x1C3362C", Offset = "0x1C3362C", VA = "0x1C3362C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000284")]
		public IOnRequestProcessing OnRequestModule
		{
			[Token(Token = "0x6000C4B")]
			[Address(RVA = "0x1C32458", Offset = "0x1C32458", VA = "0x1C32458")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000285")]
		public IOnRequestPath OnRequestPathModule
		{
			[Token(Token = "0x6000C4C")]
			[Address(RVA = "0x1C33710", Offset = "0x1C33710", VA = "0x1C33710")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000286")]
		public IExternalInput ExternalInput
		{
			[Token(Token = "0x6000C4D")]
			[Address(RVA = "0x1C3375C", Offset = "0x1C3375C", VA = "0x1C3375C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000287")]
		public List<CGModuleSlot> LinkedSlots
		{
			[Token(Token = "0x6000C4E")]
			[Address(RVA = "0x1C31B5C", Offset = "0x1C31B5C", VA = "0x1C31B5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000288")]
		public int Count
		{
			[Token(Token = "0x6000C4F")]
			[Address(RVA = "0x1C322AC", Offset = "0x1C322AC", VA = "0x1C322AC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000289")]
		public string Name
		{
			[Token(Token = "0x6000C50")]
			[Address(RVA = "0x1C326B0", Offset = "0x1C326B0", VA = "0x1C326B0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x1C31538", Offset = "0x1C31538", VA = "0x1C31538")]
		public CGModuleSlot()
		{
		}

		[Token(Token = "0x6000C52")]
		[Address(RVA = "0x1C31D94", Offset = "0x1C31D94", VA = "0x1C31D94")]
		public bool HasLinkTo(CGModuleSlot other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x1C337A8", Offset = "0x1C337A8", VA = "0x1C337A8")]
		public List<CGModule> GetLinkedModules()
		{
			return null;
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x1C31E5C", Offset = "0x1C31E5C", VA = "0x1C31E5C", Slot = "4")]
		public virtual void LinkTo(CGModuleSlot other)
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x1C320D0", Offset = "0x1C320D0", VA = "0x1C320D0", Slot = "5")]
		public virtual void UnlinkFrom(CGModuleSlot other)
		{
		}

		[Token(Token = "0x6000C56")]
		[Address(RVA = "0x1C338CC", Offset = "0x1C338CC", VA = "0x1C338CC", Slot = "6")]
		public virtual void UnlinkAll()
		{
		}

		[Token(Token = "0x6000C57")]
		[Address(RVA = "0x1C319E4", Offset = "0x1C319E4", VA = "0x1C319E4")]
		public void ReInitializeLinkedSlots()
		{
		}

		[Token(Token = "0x6000C58")]
		[Address(RVA = "0x1C338D0", Offset = "0x1C338D0", VA = "0x1C338D0")]
		public void ReInitializeLinkedTargetModules()
		{
		}

		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x1C31924", Offset = "0x1C31924", VA = "0x1C31924", Slot = "7")]
		protected virtual void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000C5A")]
		[Address(RVA = "0x1C33A40", Offset = "0x1C33A40", VA = "0x1C33A40")]
		public static implicit operator bool(CGModuleSlot a)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x1C33A4C", Offset = "0x1C33A4C", VA = "0x1C33A4C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x200019F")]
	public class CGModuleInputSlot : CGModuleSlot
	{
		[Token(Token = "0x1700028A")]
		public InputSlotInfo InputInfo
		{
			[Token(Token = "0x6000C5C")]
			[Address(RVA = "0x1C314CC", Offset = "0x1C314CC", VA = "0x1C314CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x1C31530", Offset = "0x1C31530", VA = "0x1C31530")]
		public CGModuleInputSlot()
		{
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x1C31540", Offset = "0x1C31540", VA = "0x1C31540", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x1C319F0", Offset = "0x1C319F0", VA = "0x1C319F0", Slot = "6")]
		public override void UnlinkAll()
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x1C31BEC", Offset = "0x1C31BEC", VA = "0x1C31BEC", Slot = "4")]
		public override void LinkTo(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x1C31F58", Offset = "0x1C31F58", VA = "0x1C31F58", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot outputSlot)
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x1C321CC", Offset = "0x1C321CC", VA = "0x1C321CC")]
		public CGModuleOutputSlot SourceSlot(int index = 0)
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x1C322FC", Offset = "0x1C322FC", VA = "0x1C322FC")]
		public bool CanLinkTo(CGModuleOutputSlot source)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C64")]
		[Address(RVA = "0x1C32508", Offset = "0x1C32508", VA = "0x1C32508")]
		public static bool AreInputAndOutputSlotsCompatible(InputSlotInfo inputSlotInfo, bool inputSlotModuleIsOnRequest, OutputSlotInfo outputSlotInfo, bool outputSlotModuleIsOnRequest)
		{
			return default(bool);
		}

		[Token(Token = "0x6000C65")]
		[Address(RVA = "0x1C32588", Offset = "0x1C32588", VA = "0x1C32588")]
		private CGModule SourceModule(int index)
		{
			return null;
		}

		[Token(Token = "0x6000C66")]
		public T GetData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000C67")]
		public List<T> GetAllData<T>(params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000C68")]
		private CGData[] GetData<T>(int slotIndex, params CGDataRequestParameter[] requests) where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000C69")]
		private static CGData[] cloneData<T>(ref CGData[] source) where T : CGData
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x20001A0")]
	public class CGModuleOutputSlot : CGModuleSlot
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public CGData[] Data;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CGDataRequestParameter[] LastRequestParameters;

		[Token(Token = "0x1700028B")]
		public OutputSlotInfo OutputInfo
		{
			[Token(Token = "0x6000C6A")]
			[Address(RVA = "0x1C324A4", Offset = "0x1C324A4", VA = "0x1C324A4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700028C")]
		public bool HasData
		{
			[Token(Token = "0x6000C6F")]
			[Address(RVA = "0x1C3348C", Offset = "0x1C3348C", VA = "0x1C3348C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000C6B")]
		[Address(RVA = "0x1C32C90", Offset = "0x1C32C90", VA = "0x1C32C90")]
		public CGModuleOutputSlot()
		{
		}

		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x1C32CF8", Offset = "0x1C32CF8", VA = "0x1C32CF8", Slot = "7")]
		protected override void LoadLinkedSlots()
		{
		}

		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x1C330DC", Offset = "0x1C330DC", VA = "0x1C330DC", Slot = "4")]
		public override void LinkTo(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000C6E")]
		[Address(RVA = "0x1C33314", Offset = "0x1C33314", VA = "0x1C33314", Slot = "5")]
		public override void UnlinkFrom(CGModuleSlot inputSlot)
		{
		}

		[Token(Token = "0x6000C70")]
		[Address(RVA = "0x1C334CC", Offset = "0x1C334CC", VA = "0x1C334CC")]
		public void ClearData()
		{
		}

		[Token(Token = "0x6000C71")]
		public void SetData<T>(List<T> data) where T : CGData
		{
		}

		[Token(Token = "0x6000C72")]
		[Address(RVA = "0x1C33528", Offset = "0x1C33528", VA = "0x1C33528")]
		public void SetData(params CGData[] data)
		{
		}

		[Token(Token = "0x6000C73")]
		public T GetData<T>() where T : CGData
		{
			return null;
		}

		[Token(Token = "0x6000C74")]
		public T[] GetAllData<T>() where T : CGData
		{
			return null;
		}
	}
	[Token(Token = "0x20001A1")]
	public class SlotInfo : Attribute, IComparable
	{
		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly Type[] DataTypes;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Name;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string displayName;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string Tooltip;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool Array;

		[Token(Token = "0x1700028D")]
		public string DisplayName
		{
			[Token(Token = "0x6000C75")]
			[Address(RVA = "0x1DC7558", Offset = "0x1DC7558", VA = "0x1DC7558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C76")]
			[Address(RVA = "0x1DC7570", Offset = "0x1DC7570", VA = "0x1DC7570")]
			set
			{
			}
		}

		[Token(Token = "0x6000C77")]
		[Address(RVA = "0x1DC7578", Offset = "0x1DC7578", VA = "0x1DC7578")]
		protected SlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000C78")]
		[Address(RVA = "0x1DC75C8", Offset = "0x1DC75C8", VA = "0x1DC75C8")]
		protected SlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000C79")]
		[Address(RVA = "0x1DC75D4", Offset = "0x1DC75D4", VA = "0x1DC75D4", Slot = "4")]
		public int CompareTo(object obj)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001A2")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C4814", Offset = "0x9C4814")]
	public sealed class InputSlotInfo : SlotInfo
	{
		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool RequestDataOnly;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Optional;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool ModifiesData;

		[Token(Token = "0x6000C7A")]
		[Address(RVA = "0x1698200", Offset = "0x1698200", VA = "0x1698200")]
		public InputSlotInfo(string name, params Type[] type)
		{
		}

		[Token(Token = "0x6000C7B")]
		[Address(RVA = "0x1698208", Offset = "0x1698208", VA = "0x1698208")]
		public InputSlotInfo(params Type[] type)
		{
		}

		[Token(Token = "0x6000C7C")]
		[Address(RVA = "0x1698218", Offset = "0x1698218", VA = "0x1698218")]
		public bool IsValidFrom(Type outType)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20001A3")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C4848", Offset = "0x9C4848")]
	public sealed class OutputSlotInfo : SlotInfo
	{
		[Token(Token = "0x1700028E")]
		public Type DataType
		{
			[Token(Token = "0x6000C7D")]
			[Address(RVA = "0x167B59C", Offset = "0x167B59C", VA = "0x167B59C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C7E")]
		[Address(RVA = "0x167B5D0", Offset = "0x167B5D0", VA = "0x167B5D0")]
		public OutputSlotInfo(Type type)
		{
		}

		[Token(Token = "0x6000C7F")]
		[Address(RVA = "0x167B5DC", Offset = "0x167B5DC", VA = "0x167B5DC")]
		public OutputSlotInfo(string name, Type type)
		{
		}
	}
	[Token(Token = "0x20001A4")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x9C487C", Offset = "0x9C487C")]
	public sealed class ResourceLoaderAttribute : Attribute
	{
		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly string ResourceName;

		[Token(Token = "0x6000C80")]
		[Address(RVA = "0x16807F8", Offset = "0x16807F8", VA = "0x16807F8")]
		public ResourceLoaderAttribute(string resName)
		{
		}
	}
	[Token(Token = "0x20001A5")]
	public static class CGResourceHandler
	{
		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, ICGResourceLoader> Loader;

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x1C34BEC", Offset = "0x1C34BEC", VA = "0x1C34BEC")]
		public static UnityEngine.Component CreateResource(CGModule module, string resName, string context)
		{
			return null;
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x1C35048", Offset = "0x1C35048", VA = "0x1C35048")]
		public static void DestroyResource(CGModule module, string resName, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000C83")]
		[Address(RVA = "0x1C34E4C", Offset = "0x1C34E4C", VA = "0x1C34E4C")]
		private static void getLoaders()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x9C4890", Offset = "0x9C4890")]
	public class CGSplineResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x1C35D6C", Offset = "0x1C35D6C", VA = "0x1C35D6C", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000C86")]
		[Address(RVA = "0x1C35E68", Offset = "0x1C35E68", VA = "0x1C35E68", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000C87")]
		[Address(RVA = "0x1C35F04", Offset = "0x1C35F04", VA = "0x1C35F04")]
		public CGSplineResourceLoader()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x9C48C8", Offset = "0x9C48C8")]
	public class CGShapeResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000C88")]
		[Address(RVA = "0x1C35BF8", Offset = "0x1C35BF8", VA = "0x1C35BF8", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000C89")]
		[Address(RVA = "0x1C35CC8", Offset = "0x1C35CC8", VA = "0x1C35CC8", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000C8A")]
		[Address(RVA = "0x1C35D64", Offset = "0x1C35D64", VA = "0x1C35D64")]
		public CGShapeResourceLoader()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x9C4900", Offset = "0x9C4900")]
	public class CGMeshResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000C8B")]
		[Address(RVA = "0x17237B8", Offset = "0x17237B8", VA = "0x17237B8", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000C8C")]
		[Address(RVA = "0x172382C", Offset = "0x172382C", VA = "0x172382C", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x1723B10", Offset = "0x1723B10", VA = "0x1723B10")]
		public CGMeshResourceLoader()
		{
		}
	}
	[Token(Token = "0x20001A9")]
	[AttributeAttribute(Name = "ResourceLoaderAttribute", RVA = "0x9C4938", Offset = "0x9C4938")]
	public class CGGameObjectResourceLoader : ICGResourceLoader
	{
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x1722408", Offset = "0x1722408", VA = "0x1722408", Slot = "4")]
		public UnityEngine.Component Create(CGModule cgModule, string context)
		{
			return null;
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x1722524", Offset = "0x1722524", VA = "0x1722524", Slot = "5")]
		public void Destroy(CGModule cgModule, UnityEngine.Component obj, string context, bool kill)
		{
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x1722744", Offset = "0x1722744", VA = "0x1722744")]
		public CGGameObjectResourceLoader()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20001AA")]
	public class CGGameObjectResourceCollection : ICGResourceCollection
	{
		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<Transform> Items;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> PoolNames;

		[Token(Token = "0x1700028F")]
		public int Count
		{
			[Token(Token = "0x6000C91")]
			[Address(RVA = "0x1722298", Offset = "0x1722298", VA = "0x1722298", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000290")]
		public UnityEngine.Component[] ItemsArray
		{
			[Token(Token = "0x6000C92")]
			[Address(RVA = "0x17222E4", Offset = "0x17222E4", VA = "0x17222E4", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x1722338", Offset = "0x1722338", VA = "0x1722338")]
		public CGGameObjectResourceCollection()
		{
		}
	}
	[Token(Token = "0x20001AB")]
	public static class CGUtility
	{
		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x1C36624", Offset = "0x1C36624", VA = "0x1C36624")]
		public static Vector2[] CalculateUV2(Vector2[] uv)
		{
			return null;
		}

		[Token(Token = "0x6000C95")]
		[Address(RVA = "0x1C36744", Offset = "0x1C36744", VA = "0x1C36744")]
		public static List<ControlPointOption> GetControlPointsWithOptions(CGDataRequestMetaCGOptions options, CurvySpline shape, float startDist, float endDist, bool optimize, out int initialMaterialID, out float initialMaxStep)
		{
			return null;
		}
	}
	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4970", Offset = "0x9C4970")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x9C4970", Offset = "0x9C4970")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x9C4970", Offset = "0x9C4970")]
	[ExecuteInEditMode]
	public class CurvyGenerator : DTVersionedMonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4A2C", Offset = "0x9C4A2C")]
		private sealed class <>c
		{
			[Token(Token = "0x400076D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CGModule, bool> <>9__47_0;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<CGModule, float> <>9__47_1;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__65_0;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<CGModule, float> <>9__65_1;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Func<CGModuleInputSlot, IEnumerable<CGModule>> <>9__66_0;

			[Token(Token = "0x6000CC3")]
			[Address(RVA = "0x1E07DF0", Offset = "0x1E07DF0", VA = "0x1E07DF0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000CC4")]
			[Address(RVA = "0x1E07DF8", Offset = "0x1E07DF8", VA = "0x1E07DF8")]
			internal bool <ReorderModules>b__47_0(CGModule m)
			{
				return default(bool);
			}

			[Token(Token = "0x6000CC5")]
			[Address(RVA = "0x1E07E58", Offset = "0x1E07E58", VA = "0x1E07E58")]
			internal float <ReorderModules>b__47_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000CC6")]
			[Address(RVA = "0x1E07E80", Offset = "0x1E07E80", VA = "0x1E07E80")]
			internal IEnumerable<CGModule> <ReorderEndpointRecursiveInputs>b__65_0(CGModuleInputSlot i)
			{
				return null;
			}

			[Token(Token = "0x6000CC7")]
			[Address(RVA = "0x1E07E9C", Offset = "0x1E07E9C", VA = "0x1E07E9C")]
			internal float <ReorderEndpointRecursiveInputs>b__65_1(CGModule m)
			{
				return default(float);
			}

			[Token(Token = "0x6000CC8")]
			[Address(RVA = "0x1E07EC4", Offset = "0x1E07EC4", VA = "0x1E07EC4")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__66_0(CGModuleInputSlot i)
			{
				return null;
			}
		}

		[Token(Token = "0x20001AE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4A3C", Offset = "0x9C4A3C")]
		private sealed class <>c__DisplayClass66_0
		{
			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs;

			[Token(Token = "0x6000CC9")]
			[Address(RVA = "0x1E07EE0", Offset = "0x1E07EE0", VA = "0x1E07EE0")]
			public <>c__DisplayClass66_0()
			{
			}

			[Token(Token = "0x6000CCA")]
			[Address(RVA = "0x1E07EE8", Offset = "0x1E07EE8", VA = "0x1E07EE8")]
			internal IEnumerable<CGModule> <UpdateModulesRecursiveInputs>b__1(CGModule i)
			{
				return null;
			}
		}

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CC1D8", Offset = "0x9CC1D8")]
		[SerializeField]
		private bool m_ShowDebug;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CC224", Offset = "0x9CC224")]
		private bool m_AutoRefresh;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CC270", Offset = "0x9CC270")]
		[Positive]
		private int m_RefreshDelay;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CC350", Offset = "0x9CC350")]
		[Positive]
		[SerializeField]
		private int m_RefreshDelayEditor;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CC430", Offset = "0x9CC430")]
		[SerializeField]
		private CurvyCGEvent m_OnRefresh;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public List<CGModule> Modules;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		internal int m_LastModuleID;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CC4EC", Offset = "0x9CC4EC")]
		private bool <Destroying>k__BackingField;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Dictionary<int, CGModule> ModulesByID;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool mInitialized;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		private bool mInitializedPhaseOne;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool mNeedSort;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private double mLastUpdateTime;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PoolManager mPoolManager;

		[Token(Token = "0x400076B")]
		private const int ModulesReorderingDeltaX = 50;

		[Token(Token = "0x400076C")]
		private const int ModulesReorderingDeltaY = 20;

		[Token(Token = "0x17000291")]
		public bool ShowDebug
		{
			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x16FD2DC", Offset = "0x16FD2DC", VA = "0x16FD2DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x16FD2E4", Offset = "0x16FD2E4", VA = "0x16FD2E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000292")]
		public bool AutoRefresh
		{
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x16FD304", Offset = "0x16FD304", VA = "0x16FD304")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000C99")]
			[Address(RVA = "0x16FD30C", Offset = "0x16FD30C", VA = "0x16FD30C")]
			set
			{
			}
		}

		[Token(Token = "0x17000293")]
		public int RefreshDelay
		{
			[Token(Token = "0x6000C9A")]
			[Address(RVA = "0x16FD32C", Offset = "0x16FD32C", VA = "0x16FD32C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C9B")]
			[Address(RVA = "0x16FD334", Offset = "0x16FD334", VA = "0x16FD334")]
			set
			{
			}
		}

		[Token(Token = "0x17000294")]
		public int RefreshDelayEditor
		{
			[Token(Token = "0x6000C9C")]
			[Address(RVA = "0x16FD36C", Offset = "0x16FD36C", VA = "0x16FD36C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000C9D")]
			[Address(RVA = "0x16FD374", Offset = "0x16FD374", VA = "0x16FD374")]
			set
			{
			}
		}

		[Token(Token = "0x17000295")]
		public PoolManager PoolManager
		{
			[Token(Token = "0x6000C9E")]
			[Address(RVA = "0x16FD3AC", Offset = "0x16FD3AC", VA = "0x16FD3AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000296")]
		public CurvyCGEvent OnRefresh
		{
			[Token(Token = "0x6000C9F")]
			[Address(RVA = "0x16FD460", Offset = "0x16FD460", VA = "0x16FD460")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CA0")]
			[Address(RVA = "0x16FD468", Offset = "0x16FD468", VA = "0x16FD468")]
			set
			{
			}
		}

		[Token(Token = "0x17000297")]
		public bool IsInitialized
		{
			[Token(Token = "0x6000CA1")]
			[Address(RVA = "0x16FD480", Offset = "0x16FD480", VA = "0x16FD480")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000298")]
		public bool Destroying
		{
			[Token(Token = "0x6000CA2")]
			[Address(RVA = "0x16FD488", Offset = "0x16FD488", VA = "0x16FD488")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D297C", Offset = "0x9D297C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CA3")]
			[Address(RVA = "0x16FD490", Offset = "0x16FD490", VA = "0x16FD490")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D298C", Offset = "0x9D298C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x16FD49C", Offset = "0x16FD49C", VA = "0x16FD49C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x16FD4A0", Offset = "0x16FD4A0", VA = "0x16FD4A0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x16FD4C4", Offset = "0x16FD4C4", VA = "0x16FD4C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x16FD4D4", Offset = "0x16FD4D4", VA = "0x16FD4D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000CA8")]
		[Address(RVA = "0x16FD4E0", Offset = "0x16FD4E0", VA = "0x16FD4E0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000CA9")]
		[Address(RVA = "0x16FDD68", Offset = "0x16FDD68", VA = "0x16FDD68")]
		public static CurvyGenerator Create()
		{
			return null;
		}

		[Token(Token = "0x6000CAA")]
		public T AddModule<T>() where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x16FDEC4", Offset = "0x16FDEC4", VA = "0x16FDEC4")]
		public CGModule AddModule(Type type)
		{
			return null;
		}

		[Token(Token = "0x6000CAC")]
		[Address(RVA = "0x16FE040", Offset = "0x16FE040", VA = "0x16FE040")]
		public void ArrangeModules()
		{
		}

		[Token(Token = "0x6000CAD")]
		[Address(RVA = "0x16FE354", Offset = "0x16FE354", VA = "0x16FE354")]
		public void ReorderModules()
		{
		}

		[Token(Token = "0x6000CAE")]
		[Address(RVA = "0x16FF25C", Offset = "0x16FF25C", VA = "0x16FF25C")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000CAF")]
		[Address(RVA = "0x16FF3A0", Offset = "0x16FF3A0", VA = "0x16FF3A0")]
		public void DeleteModule(CGModule module)
		{
		}

		[Token(Token = "0x6000CB0")]
		public List<T> FindModules<T>(bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x16FF428", Offset = "0x16FF428", VA = "0x16FF428")]
		public List<CGModule> GetModules(bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x16FF5BC", Offset = "0x16FF5BC", VA = "0x16FF5BC")]
		public CGModule GetModule(int moduleID, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000CB3")]
		public T GetModule<T>(int moduleID, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x16FF670", Offset = "0x16FF670", VA = "0x16FF670")]
		public CGModule GetModule(string moduleName, bool includeOnRequestProcessing = false)
		{
			return null;
		}

		[Token(Token = "0x6000CB5")]
		public T GetModule<T>(string moduleName, bool includeOnRequestProcessing = false) where T : CGModule
		{
			return null;
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x16FF7C4", Offset = "0x16FF7C4", VA = "0x16FF7C4")]
		public CGModuleOutputSlot GetModuleOutputSlot(int moduleId, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000CB7")]
		[Address(RVA = "0x16FF880", Offset = "0x16FF880", VA = "0x16FF880")]
		public CGModuleOutputSlot GetModuleOutputSlot(string moduleName, string slotName)
		{
			return null;
		}

		[Token(Token = "0x6000CB8")]
		[Address(RVA = "0x16FD57C", Offset = "0x16FD57C", VA = "0x16FD57C")]
		public void Initialize(bool force = false)
		{
		}

		[Token(Token = "0x6000CB9")]
		[Address(RVA = "0x16FD9C4", Offset = "0x16FD9C4", VA = "0x16FD9C4")]
		public void Refresh(bool forceUpdate = false)
		{
		}

		[Token(Token = "0x6000CBA")]
		[Address(RVA = "0x16FFD50", Offset = "0x16FFD50", VA = "0x16FFD50")]
		protected CurvyCGEventArgs OnRefreshEvent(CurvyCGEventArgs e)
		{
			return null;
		}

		[Token(Token = "0x6000CBB")]
		[Address(RVA = "0x16FF260", Offset = "0x16FF260", VA = "0x16FF260")]
		private void clearModules()
		{
		}

		[Token(Token = "0x6000CBC")]
		[Address(RVA = "0x16FFDB8", Offset = "0x16FFDB8", VA = "0x16FFDB8")]
		public string getUniqueModuleNameINTERNAL(string name)
		{
			return null;
		}

		[Token(Token = "0x6000CBD")]
		[Address(RVA = "0x16FF93C", Offset = "0x16FF93C", VA = "0x16FF93C")]
		internal void sortModulesINTERNAL()
		{
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x16FF948", Offset = "0x16FF948", VA = "0x16FF948")]
		private bool doSortModules()
		{
			return default(bool);
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x16FED10", Offset = "0x16FED10", VA = "0x16FED10")]
		private static void ReorderEndpointRecursiveInputs(CGModule endPoint, HashSet<int> reordredModuleIds, Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs)
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x16FE9D8", Offset = "0x16FE9D8", VA = "0x16FE9D8")]
		private static HashSet<CGModule> UpdateModulesRecursiveInputs(Dictionary<CGModule, HashSet<CGModule>> modulesRecursiveInputs, CGModule moduleToAdd)
		{
			return null;
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x16FFFFC", Offset = "0x16FFFFC", VA = "0x16FFFFC")]
		public CurvyGenerator()
		{
		}
	}
}
namespace FluffyUnderware.Curvy.Generator.Modules
{
	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4A4C", Offset = "0x9C4A4C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4A4C", Offset = "0x9C4A4C")]
	public class BuildRasterizedPath : CGModule
	{
		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CC4FC", Offset = "0x9CC4FC")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CC5D0", Offset = "0x9CC5D0")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_Range;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CC6E0", Offset = "0x9CC6E0")]
		private int m_Resolution;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CC75C", Offset = "0x9CC75C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CC75C", Offset = "0x9CC75C")]
		private float m_AngleTreshold;

		[Token(Token = "0x17000299")]
		public float From
		{
			[Token(Token = "0x6000CCB")]
			[Address(RVA = "0x1717004", Offset = "0x1717004", VA = "0x1717004")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CCC")]
			[Address(RVA = "0x171700C", Offset = "0x171700C", VA = "0x171700C")]
			set
			{
			}
		}

		[Token(Token = "0x1700029A")]
		public float To
		{
			[Token(Token = "0x6000CCD")]
			[Address(RVA = "0x1717168", Offset = "0x1717168", VA = "0x1717168")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CCE")]
			[Address(RVA = "0x1717170", Offset = "0x1717170", VA = "0x1717170")]
			set
			{
			}
		}

		[Token(Token = "0x1700029B")]
		public float Length
		{
			[Token(Token = "0x6000CCF")]
			[Address(RVA = "0x17172DC", Offset = "0x17172DC", VA = "0x17172DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CD0")]
			[Address(RVA = "0x171730C", Offset = "0x171730C", VA = "0x171730C")]
			set
			{
			}
		}

		[Token(Token = "0x1700029C")]
		public int Resolution
		{
			[Token(Token = "0x6000CD1")]
			[Address(RVA = "0x171735C", Offset = "0x171735C", VA = "0x171735C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000CD2")]
			[Address(RVA = "0x1717364", Offset = "0x1717364", VA = "0x1717364")]
			set
			{
			}
		}

		[Token(Token = "0x1700029D")]
		public bool Optimize
		{
			[Token(Token = "0x6000CD3")]
			[Address(RVA = "0x17173B0", Offset = "0x17173B0", VA = "0x17173B0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CD4")]
			[Address(RVA = "0x17173B8", Offset = "0x17173B8", VA = "0x17173B8")]
			set
			{
			}
		}

		[Token(Token = "0x1700029E")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x17173DC", Offset = "0x17173DC", VA = "0x17173DC")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CD6")]
			[Address(RVA = "0x17173E4", Offset = "0x17173E4", VA = "0x17173E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700029F")]
		public CGPath Path
		{
			[Token(Token = "0x6000CD7")]
			[Address(RVA = "0x1717430", Offset = "0x1717430", VA = "0x1717430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002A0")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000CD8")]
			[Address(RVA = "0x17171E8", Offset = "0x17171E8", VA = "0x17171E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002A1")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000CD9")]
			[Address(RVA = "0x1717484", Offset = "0x1717484", VA = "0x1717484")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000CDA")]
		[Address(RVA = "0x17175A4", Offset = "0x17175A4", VA = "0x17175A4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000CDB")]
		[Address(RVA = "0x171767C", Offset = "0x171767C", VA = "0x171767C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000CDC")]
		[Address(RVA = "0x171774C", Offset = "0x171774C", VA = "0x171774C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000CDD")]
		[Address(RVA = "0x1717B08", Offset = "0x1717B08", VA = "0x1717B08")]
		public BuildRasterizedPath()
		{
		}
	}
	[Token(Token = "0x20001B0")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4AE4", Offset = "0x9C4AE4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4AE4", Offset = "0x9C4AE4")]
	public class BuildShapeExtrusion : CGModule
	{
		[Token(Token = "0x20001B1")]
		public enum ScaleModeEnum
		{
			[Token(Token = "0x400079D")]
			Simple,
			[Token(Token = "0x400079E")]
			Advanced
		}

		[Token(Token = "0x20001B2")]
		public enum CrossShiftModeEnum
		{
			[Token(Token = "0x40007A0")]
			None,
			[Token(Token = "0x40007A1")]
			ByOrientation,
			[Token(Token = "0x40007A2")]
			Custom
		}

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CC85C", Offset = "0x9CC85C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CC918", Offset = "0x9CC918")]
		[HideInInspector]
		public CGModuleInputSlot InCross;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CC9D0", Offset = "0x9CC9D0")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolume;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CCA40", Offset = "0x9CCA40")]
		[HideInInspector]
		public CGModuleOutputSlot OutVolumeHollow;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[FloatRegion]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CCAB0", Offset = "0x9CCAB0")]
		private FloatRegion m_Range;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CCB3C", Offset = "0x9CCB3C")]
		[SerializeField]
		private int m_Resolution;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private bool m_Optimize;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CCBC0", Offset = "0x9CCBC0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CCBC0", Offset = "0x9CCBC0")]
		private float m_AngleThreshold;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CCCDC", Offset = "0x9CCCDC")]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9CCCDC", Offset = "0x9CCCDC")]
		[FloatRegion]
		[SerializeField]
		private FloatRegion m_CrossRange;

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CCD94", Offset = "0x9CCD94")]
		private int m_CrossResolution;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CCE1C", Offset = "0x9CCE1C")]
		[SerializeField]
		private bool m_CrossOptimize;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CCE84", Offset = "0x9CCE84")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CCE84", Offset = "0x9CCE84")]
		private float m_CrossAngleThreshold;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CCF98", Offset = "0x9CCF98")]
		private bool m_CrossIncludeControlpoints;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CCFF8", Offset = "0x9CCFF8")]
		[SerializeField]
		private bool m_CrossHardEdges;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD060", Offset = "0x9CD060")]
		[SerializeField]
		private bool m_CrossMaterials;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD0C8", Offset = "0x9CD0C8")]
		private bool m_CrossExtendedUV;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD128", Offset = "0x9CD128")]
		private CrossShiftModeEnum m_CrossShiftMode;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CD1A4", Offset = "0x9CD1A4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD1A4", Offset = "0x9CD1A4")]
		private float m_CrossShiftValue;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD29C", Offset = "0x9CD29C")]
		[SerializeField]
		private bool m_CrossReverseNormals;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD304", Offset = "0x9CD304")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CD304", Offset = "0x9CD304")]
		private ScaleModeEnum m_ScaleMode;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD390", Offset = "0x9CD390")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD390", Offset = "0x9CD390")]
		private CGReferenceMode m_ScaleReference;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD478", Offset = "0x9CD478")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD478", Offset = "0x9CD478")]
		[SerializeField]
		private float m_ScaleOffset;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD560", Offset = "0x9CD560")]
		[SerializeField]
		private bool m_ScaleUniform;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float m_ScaleX;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD5F4", Offset = "0x9CD5F4")]
		private float m_ScaleY;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CD6A0", Offset = "0x9CD6A0")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x9CD6A0", Offset = "0x9CD6A0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD6A0", Offset = "0x9CD6A0")]
		[SerializeField]
		private AnimationCurve m_ScaleCurveX;

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CD7AC", Offset = "0x9CD7AC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CD7AC", Offset = "0x9CD7AC")]
		[AttributeAttribute(Name = "AnimationCurveExAttribute", RVA = "0x9CD7AC", Offset = "0x9CD7AC")]
		[SerializeField]
		private AnimationCurve m_ScaleCurveY;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CD908", Offset = "0x9CD908")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CD908", Offset = "0x9CD908")]
		private float m_HollowInset;

		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
		[SerializeField]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CD9C0", Offset = "0x9CD9C0")]
		private bool m_HollowReverseNormals;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CDA20", Offset = "0x9CDA20")]
		private int <PathSamples>k__BackingField;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CDA30", Offset = "0x9CDA30")]
		private int <CrossSamples>k__BackingField;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CDA40", Offset = "0x9CDA40")]
		private int <CrossGroups>k__BackingField;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CDA50", Offset = "0x9CDA50")]
		private Vector3 <CrossPosition>k__BackingField;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CDA60", Offset = "0x9CDA60")]
		private Quaternion <CrossRotation>k__BackingField;

		[Token(Token = "0x170002A2")]
		public float From
		{
			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x1717DC0", Offset = "0x1717DC0", VA = "0x1717DC0")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x1717DC8", Offset = "0x1717DC8", VA = "0x1717DC8")]
			set
			{
			}
		}

		[Token(Token = "0x170002A3")]
		public float To
		{
			[Token(Token = "0x6000CE0")]
			[Address(RVA = "0x1717E08", Offset = "0x1717E08", VA = "0x1717E08")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CE1")]
			[Address(RVA = "0x1717E10", Offset = "0x1717E10", VA = "0x1717E10")]
			set
			{
			}
		}

		[Token(Token = "0x170002A4")]
		public float Length
		{
			[Token(Token = "0x6000CE2")]
			[Address(RVA = "0x1717F80", Offset = "0x1717F80", VA = "0x1717F80")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x1717FB0", Offset = "0x1717FB0", VA = "0x1717FB0")]
			set
			{
			}
		}

		[Token(Token = "0x170002A5")]
		public int Resolution
		{
			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x1718000", Offset = "0x1718000", VA = "0x1718000")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x1718008", Offset = "0x1718008", VA = "0x1718008")]
			set
			{
			}
		}

		[Token(Token = "0x170002A6")]
		public bool Optimize
		{
			[Token(Token = "0x6000CE6")]
			[Address(RVA = "0x1718054", Offset = "0x1718054", VA = "0x1718054")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x171805C", Offset = "0x171805C", VA = "0x171805C")]
			set
			{
			}
		}

		[Token(Token = "0x170002A7")]
		public float AngleThreshold
		{
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x1718080", Offset = "0x1718080", VA = "0x1718080")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x1718088", Offset = "0x1718088", VA = "0x1718088")]
			set
			{
			}
		}

		[Token(Token = "0x170002A8")]
		public float CrossFrom
		{
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x17180D4", Offset = "0x17180D4", VA = "0x17180D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x17180DC", Offset = "0x17180DC", VA = "0x17180DC")]
			set
			{
			}
		}

		[Token(Token = "0x170002A9")]
		public float CrossTo
		{
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x171811C", Offset = "0x171811C", VA = "0x171811C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x1718124", Offset = "0x1718124", VA = "0x1718124")]
			set
			{
			}
		}

		[Token(Token = "0x170002AA")]
		public float CrossLength
		{
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x1718294", Offset = "0x1718294", VA = "0x1718294")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CEF")]
			[Address(RVA = "0x17182C4", Offset = "0x17182C4", VA = "0x17182C4")]
			set
			{
			}
		}

		[Token(Token = "0x170002AB")]
		public int CrossResolution
		{
			[Token(Token = "0x6000CF0")]
			[Address(RVA = "0x1718314", Offset = "0x1718314", VA = "0x1718314")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000CF1")]
			[Address(RVA = "0x171831C", Offset = "0x171831C", VA = "0x171831C")]
			set
			{
			}
		}

		[Token(Token = "0x170002AC")]
		public bool CrossOptimize
		{
			[Token(Token = "0x6000CF2")]
			[Address(RVA = "0x1718368", Offset = "0x1718368", VA = "0x1718368")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CF3")]
			[Address(RVA = "0x1718370", Offset = "0x1718370", VA = "0x1718370")]
			set
			{
			}
		}

		[Token(Token = "0x170002AD")]
		public float CrossAngleThreshold
		{
			[Token(Token = "0x6000CF4")]
			[Address(RVA = "0x1718394", Offset = "0x1718394", VA = "0x1718394")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000CF5")]
			[Address(RVA = "0x171839C", Offset = "0x171839C", VA = "0x171839C")]
			set
			{
			}
		}

		[Token(Token = "0x170002AE")]
		public bool CrossIncludeControlPoints
		{
			[Token(Token = "0x6000CF6")]
			[Address(RVA = "0x17183E8", Offset = "0x17183E8", VA = "0x17183E8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CF7")]
			[Address(RVA = "0x17183F0", Offset = "0x17183F0", VA = "0x17183F0")]
			set
			{
			}
		}

		[Token(Token = "0x170002AF")]
		public bool CrossHardEdges
		{
			[Token(Token = "0x6000CF8")]
			[Address(RVA = "0x1718414", Offset = "0x1718414", VA = "0x1718414")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CF9")]
			[Address(RVA = "0x171841C", Offset = "0x171841C", VA = "0x171841C")]
			set
			{
			}
		}

		[Token(Token = "0x170002B0")]
		public bool CrossMaterials
		{
			[Token(Token = "0x6000CFA")]
			[Address(RVA = "0x1718440", Offset = "0x1718440", VA = "0x1718440")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CFB")]
			[Address(RVA = "0x1718448", Offset = "0x1718448", VA = "0x1718448")]
			set
			{
			}
		}

		[Token(Token = "0x170002B1")]
		public bool CrossExtendedUV
		{
			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x171846C", Offset = "0x171846C", VA = "0x171846C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x1718474", Offset = "0x1718474", VA = "0x1718474")]
			set
			{
			}
		}

		[Token(Token = "0x170002B2")]
		public CrossShiftModeEnum CrossShiftMode
		{
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x1718498", Offset = "0x1718498", VA = "0x1718498")]
			get
			{
				return default(CrossShiftModeEnum);
			}
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x17184A0", Offset = "0x17184A0", VA = "0x17184A0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B3")]
		public float CrossShiftValue
		{
			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x17184B8", Offset = "0x17184B8", VA = "0x17184B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x17184C0", Offset = "0x17184C0", VA = "0x17184C0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B4")]
		public bool CrossReverseNormals
		{
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x1718500", Offset = "0x1718500", VA = "0x1718500")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x1718508", Offset = "0x1718508", VA = "0x1718508")]
			set
			{
			}
		}

		[Token(Token = "0x170002B5")]
		public ScaleModeEnum ScaleMode
		{
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x171852C", Offset = "0x171852C", VA = "0x171852C")]
			get
			{
				return default(ScaleModeEnum);
			}
			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x1718534", Offset = "0x1718534", VA = "0x1718534")]
			set
			{
			}
		}

		[Token(Token = "0x170002B6")]
		public CGReferenceMode ScaleReference
		{
			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x171854C", Offset = "0x171854C", VA = "0x171854C")]
			get
			{
				return default(CGReferenceMode);
			}
			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x1718554", Offset = "0x1718554", VA = "0x1718554")]
			set
			{
			}
		}

		[Token(Token = "0x170002B7")]
		public bool ScaleUniform
		{
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x171856C", Offset = "0x171856C", VA = "0x171856C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x1718574", Offset = "0x1718574", VA = "0x1718574")]
			set
			{
			}
		}

		[Token(Token = "0x170002B8")]
		public float ScaleOffset
		{
			[Token(Token = "0x6000D0A")]
			[Address(RVA = "0x1718598", Offset = "0x1718598", VA = "0x1718598")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0x17185A0", Offset = "0x17185A0", VA = "0x17185A0")]
			set
			{
			}
		}

		[Token(Token = "0x170002B9")]
		public float ScaleX
		{
			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x17185B8", Offset = "0x17185B8", VA = "0x17185B8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x17185C0", Offset = "0x17185C0", VA = "0x17185C0")]
			set
			{
			}
		}

		[Token(Token = "0x170002BA")]
		public float ScaleY
		{
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x17185D8", Offset = "0x17185D8", VA = "0x17185D8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0x17185E0", Offset = "0x17185E0", VA = "0x17185E0")]
			set
			{
			}
		}

		[Token(Token = "0x170002BB")]
		public AnimationCurve ScaleMultiplierX
		{
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x17185F8", Offset = "0x17185F8", VA = "0x17185F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x1718600", Offset = "0x1718600", VA = "0x1718600")]
			set
			{
			}
		}

		[Token(Token = "0x170002BC")]
		public AnimationCurve ScaleMultiplierY
		{
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x171863C", Offset = "0x171863C", VA = "0x171863C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x1718644", Offset = "0x1718644", VA = "0x1718644")]
			set
			{
			}
		}

		[Token(Token = "0x170002BD")]
		public float HollowInset
		{
			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x1718680", Offset = "0x1718680", VA = "0x1718680")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D15")]
			[Address(RVA = "0x1718688", Offset = "0x1718688", VA = "0x1718688")]
			set
			{
			}
		}

		[Token(Token = "0x170002BE")]
		public bool HollowReverseNormals
		{
			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x17186C4", Offset = "0x17186C4", VA = "0x17186C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0x17186CC", Offset = "0x17186CC", VA = "0x17186CC")]
			set
			{
			}
		}

		[Token(Token = "0x170002BF")]
		public int PathSamples
		{
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x17186F0", Offset = "0x17186F0", VA = "0x17186F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D299C", Offset = "0x9D299C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x17186F8", Offset = "0x17186F8", VA = "0x17186F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29AC", Offset = "0x9D29AC")]
			private set
			{
			}
		}

		[Token(Token = "0x170002C0")]
		public int CrossSamples
		{
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x1718700", Offset = "0x1718700", VA = "0x1718700")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29BC", Offset = "0x9D29BC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x1718708", Offset = "0x1718708", VA = "0x1718708")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29CC", Offset = "0x9D29CC")]
			private set
			{
			}
		}

		[Token(Token = "0x170002C1")]
		public int CrossGroups
		{
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x1718710", Offset = "0x1718710", VA = "0x1718710")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29DC", Offset = "0x9D29DC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x1718718", Offset = "0x1718718", VA = "0x1718718")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29EC", Offset = "0x9D29EC")]
			private set
			{
			}
		}

		[Token(Token = "0x170002C2")]
		public IExternalInput Cross
		{
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x1718720", Offset = "0x1718720", VA = "0x1718720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C3")]
		public Vector3 CrossPosition
		{
			[Token(Token = "0x6000D1F")]
			[Address(RVA = "0x171877C", Offset = "0x171877C", VA = "0x171877C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D29FC", Offset = "0x9D29FC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000D20")]
			[Address(RVA = "0x171878C", Offset = "0x171878C", VA = "0x171878C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A0C", Offset = "0x9D2A0C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002C4")]
		public Quaternion CrossRotation
		{
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x171879C", Offset = "0x171879C", VA = "0x171879C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A1C", Offset = "0x9D2A1C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x17187B0", Offset = "0x17187B0", VA = "0x17187B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A2C", Offset = "0x9D2A2C")]
			protected set
			{
			}
		}

		[Token(Token = "0x170002C5")]
		private bool ClampPath
		{
			[Token(Token = "0x6000D23")]
			[Address(RVA = "0x1717E88", Offset = "0x1717E88", VA = "0x1717E88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002C6")]
		private bool ClampCross
		{
			[Token(Token = "0x6000D24")]
			[Address(RVA = "0x171819C", Offset = "0x171819C", VA = "0x171819C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170002C7")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000D25")]
			[Address(RVA = "0x17187C4", Offset = "0x17187C4", VA = "0x17187C4")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170002C8")]
		private RegionOptions<float> CrossRangeOptions
		{
			[Token(Token = "0x6000D26")]
			[Address(RVA = "0x17188E4", Offset = "0x17188E4", VA = "0x17188E4")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x1718A04", Offset = "0x1718A04", VA = "0x1718A04", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x1718A48", Offset = "0x1718A48", VA = "0x1718A48", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x1718C3C", Offset = "0x1718C3C", VA = "0x1718C3C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x1719AA4", Offset = "0x1719AA4", VA = "0x1719AA4")]
		public Vector3 GetScale(float f)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x17199F4", Offset = "0x17199F4", VA = "0x17199F4")]
		private void getScaleInternal(float f, Vector3 baseScale, ref Vector3 scale)
		{
		}

		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x1719B2C", Offset = "0x1719B2C", VA = "0x1719B2C")]
		public BuildShapeExtrusion()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4B7C", Offset = "0x9C4B7C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4B7C", Offset = "0x9C4B7C")]
	public class BuildVolumeCaps : CGModule
	{
		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CDA70", Offset = "0x9CDA70")]
		[HideInInspector]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CDB14", Offset = "0x9CDB14")]
		public CGModuleInputSlot InVolumeHoles;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CDBD4", Offset = "0x9CDBD4")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CDC50", Offset = "0x9CDC50")]
		[SerializeField]
		private CGYesNoAuto m_StartCap;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private CGYesNoAuto m_EndCap;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9CDCAC", Offset = "0x9CDCAC")]
		[SerializeField]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CDD08", Offset = "0x9CDD08")]
		[Inline]
		[SerializeField]
		private CGMaterialSettings m_StartMaterialSettings;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CDD64", Offset = "0x9CDD64")]
		[SerializeField]
		private Material m_StartMaterial;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CDDCC", Offset = "0x9CDDCC")]
		[SerializeField]
		private bool m_CloneStartCap;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "AsGroupAttribute", RVA = "0x9CDE18", Offset = "0x9CDE18")]
		[AttributeAttribute(Name = "GroupConditionAttribute", RVA = "0x9CDE18", Offset = "0x9CDE18")]
		[SerializeField]
		private CGMaterialSettings m_EndMaterialSettings;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "GroupAttribute", RVA = "0x9CDED8", Offset = "0x9CDED8")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CDED8", Offset = "0x9CDED8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CDED8", Offset = "0x9CDED8")]
		private Material m_EndMaterial;

		[Token(Token = "0x170002C9")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000D2D")]
			[Address(RVA = "0x1719CCC", Offset = "0x1719CCC", VA = "0x1719CCC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D2E")]
			[Address(RVA = "0x1719CD4", Offset = "0x1719CD4", VA = "0x1719CD4")]
			set
			{
			}
		}

		[Token(Token = "0x170002CA")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000D2F")]
			[Address(RVA = "0x1719CF8", Offset = "0x1719CF8", VA = "0x1719CF8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D30")]
			[Address(RVA = "0x1719D00", Offset = "0x1719D00", VA = "0x1719D00")]
			set
			{
			}
		}

		[Token(Token = "0x170002CB")]
		public CGYesNoAuto StartCap
		{
			[Token(Token = "0x6000D31")]
			[Address(RVA = "0x1719D24", Offset = "0x1719D24", VA = "0x1719D24")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000D32")]
			[Address(RVA = "0x1719D2C", Offset = "0x1719D2C", VA = "0x1719D2C")]
			set
			{
			}
		}

		[Token(Token = "0x170002CC")]
		public Material StartMaterial
		{
			[Token(Token = "0x6000D33")]
			[Address(RVA = "0x1719D44", Offset = "0x1719D44", VA = "0x1719D44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D34")]
			[Address(RVA = "0x1719D4C", Offset = "0x1719D4C", VA = "0x1719D4C")]
			set
			{
			}
		}

		[Token(Token = "0x170002CD")]
		public CGMaterialSettings StartMaterialSettings
		{
			[Token(Token = "0x6000D35")]
			[Address(RVA = "0x1719DE8", Offset = "0x1719DE8", VA = "0x1719DE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002CE")]
		public CGYesNoAuto EndCap
		{
			[Token(Token = "0x6000D36")]
			[Address(RVA = "0x1719DF0", Offset = "0x1719DF0", VA = "0x1719DF0")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000D37")]
			[Address(RVA = "0x1719DF8", Offset = "0x1719DF8", VA = "0x1719DF8")]
			set
			{
			}
		}

		[Token(Token = "0x170002CF")]
		public bool CloneStartCap
		{
			[Token(Token = "0x6000D38")]
			[Address(RVA = "0x1719E10", Offset = "0x1719E10", VA = "0x1719E10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D39")]
			[Address(RVA = "0x1719E18", Offset = "0x1719E18", VA = "0x1719E18")]
			set
			{
			}
		}

		[Token(Token = "0x170002D0")]
		public CGMaterialSettings EndMaterialSettings
		{
			[Token(Token = "0x6000D3A")]
			[Address(RVA = "0x1719E3C", Offset = "0x1719E3C", VA = "0x1719E3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D1")]
		public Material EndMaterial
		{
			[Token(Token = "0x6000D3B")]
			[Address(RVA = "0x1719E44", Offset = "0x1719E44", VA = "0x1719E44")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D3C")]
			[Address(RVA = "0x1719E4C", Offset = "0x1719E4C", VA = "0x1719E4C")]
			set
			{
			}
		}

		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x1719EE8", Offset = "0x1719EE8", VA = "0x1719EE8", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x171A02C", Offset = "0x171A02C", VA = "0x171A02C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x171A16C", Offset = "0x171A16C", VA = "0x171A16C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x171ADE8", Offset = "0x171ADE8", VA = "0x171ADE8")]
		private static Matrix4x4 getMatrix(CGVolume vol, int index, bool inverse)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x171B1C0", Offset = "0x171B1C0", VA = "0x171B1C0")]
		private static void flipTris(ref int[] indices, int start, int end)
		{
		}

		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x171AFC4", Offset = "0x171AFC4", VA = "0x171AFC4")]
		private static Vector3[] applyMatrix(Vector3[] vt, Matrix4x4 matrix, out Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x171AC50", Offset = "0x171AC50", VA = "0x171AC50")]
		private static ContourVertex[] make2DSegment(CGVolume vol, int index)
		{
			return null;
		}

		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x171B248", Offset = "0x171B248", VA = "0x171B248")]
		private static void applyUV(Vector3[] vts, ref Vector2[] uvArray, int index, int count, CGMaterialSettings mat, Bounds bounds)
		{
		}

		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x171B518", Offset = "0x171B518", VA = "0x171B518")]
		public BuildVolumeCaps()
		{
		}
	}
	[Token(Token = "0x20001B4")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4C14", Offset = "0x9C4C14")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4C14", Offset = "0x9C4C14")]
	public class BuildVolumeMesh : CGModule
	{
		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CDFE0", Offset = "0x9CDFE0")]
		public CGModuleInputSlot InVolume;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CE084", Offset = "0x9CE084")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CE100", Offset = "0x9CE100")]
		[SerializeField]
		private bool m_GenerateUV;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool m_Split;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		[Positive]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CE15C", Offset = "0x9CE15C")]
		private float m_SplitLength;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x9CE228", Offset = "0x9CE228")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldActionAttribute", RVA = "0x9CE228", Offset = "0x9CE228")]
		private bool m_ReverseTriOrder;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[SerializeField]
		private List<CGMaterialSettingsEx> m_MaterialSettings;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		private Material[] m_Material;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<SamplePointsMaterialGroupCollection> groupsByMatID;

		[Token(Token = "0x170002D2")]
		public bool GenerateUV
		{
			[Token(Token = "0x6000D46")]
			[Address(RVA = "0x171B650", Offset = "0x171B650", VA = "0x171B650")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D47")]
			[Address(RVA = "0x171B658", Offset = "0x171B658", VA = "0x171B658")]
			set
			{
			}
		}

		[Token(Token = "0x170002D3")]
		public bool ReverseTriOrder
		{
			[Token(Token = "0x6000D48")]
			[Address(RVA = "0x171B67C", Offset = "0x171B67C", VA = "0x171B67C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D49")]
			[Address(RVA = "0x171B684", Offset = "0x171B684", VA = "0x171B684")]
			set
			{
			}
		}

		[Token(Token = "0x170002D4")]
		public bool Split
		{
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0x171B6A8", Offset = "0x171B6A8", VA = "0x171B6A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x171B6B0", Offset = "0x171B6B0", VA = "0x171B6B0")]
			set
			{
			}
		}

		[Token(Token = "0x170002D5")]
		public float SplitLength
		{
			[Token(Token = "0x6000D4C")]
			[Address(RVA = "0x171B6D4", Offset = "0x171B6D4", VA = "0x171B6D4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D4D")]
			[Address(RVA = "0x171B6DC", Offset = "0x171B6DC", VA = "0x171B6DC")]
			set
			{
			}
		}

		[Token(Token = "0x170002D6")]
		public List<CGMaterialSettingsEx> MaterialSetttings
		{
			[Token(Token = "0x6000D4E")]
			[Address(RVA = "0x171B720", Offset = "0x171B720", VA = "0x171B720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002D7")]
		public int MaterialCount
		{
			[Token(Token = "0x6000D4F")]
			[Address(RVA = "0x171B728", Offset = "0x171B728", VA = "0x171B728")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x171B774", Offset = "0x171B774", VA = "0x171B774", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x171B890", Offset = "0x171B890", VA = "0x171B890", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000D52")]
		[Address(RVA = "0x171BA8C", Offset = "0x171BA8C", VA = "0x171BA8C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000D53")]
		[Address(RVA = "0x171B7B0", Offset = "0x171B7B0", VA = "0x171B7B0")]
		public int AddMaterial()
		{
			return default(int);
		}

		[Token(Token = "0x6000D54")]
		[Address(RVA = "0x171C3F8", Offset = "0x171C3F8", VA = "0x171C3F8")]
		public void RemoveMaterial(int index)
		{
		}

		[Token(Token = "0x6000D55")]
		[Address(RVA = "0x171C57C", Offset = "0x171C57C", VA = "0x171C57C")]
		public void SetMaterial(int index, Material mat)
		{
		}

		[Token(Token = "0x6000D56")]
		[Address(RVA = "0x171C6F0", Offset = "0x171C6F0", VA = "0x171C6F0")]
		public Material GetMaterial(int index)
		{
			return null;
		}

		[Token(Token = "0x6000D57")]
		[Address(RVA = "0x171BFAC", Offset = "0x171BFAC", VA = "0x171BFAC")]
		private void prepare(CGVolume vol)
		{
		}

		[Token(Token = "0x6000D58")]
		[Address(RVA = "0x171BFD8", Offset = "0x171BFD8", VA = "0x171BFD8")]
		private void build(CGVMesh vmesh, CGVolume vol, IntRegion subset)
		{
		}

		[Token(Token = "0x6000D59")]
		[Address(RVA = "0x171CB14", Offset = "0x171CB14", VA = "0x171CB14")]
		private static void prepareSubMeshes(CGVMesh vmesh, List<SamplePointsMaterialGroupCollection> groupsBySubMeshes, int extrusions, ref Material[] materials)
		{
		}

		[Token(Token = "0x6000D5A")]
		[Address(RVA = "0x171CCC8", Offset = "0x171CCC8", VA = "0x171CCC8")]
		private void createMaterialGroupUV(ref CGVMesh vmesh, ref CGVolume vol, ref SamplePointsMaterialGroup grp, int matIndex, float grpAspectCorrection, int sample, int baseVertex)
		{
		}

		[Token(Token = "0x6000D5B")]
		[Address(RVA = "0x171CE7C", Offset = "0x171CE7C", VA = "0x171CE7C")]
		private static int createPatchTriangles(ref int[] triangles, ref int triIdx, int curVTIndex, int patchSize, int crossSize, bool reverse)
		{
			return default(int);
		}

		[Token(Token = "0x6000D5C")]
		[Address(RVA = "0x171C74C", Offset = "0x171C74C", VA = "0x171C74C")]
		private List<SamplePointsMaterialGroupCollection> getMaterialIDGroups(CGVolume volume)
		{
			return null;
		}

		[Token(Token = "0x6000D5D")]
		[Address(RVA = "0x171C4C0", Offset = "0x171C4C0", VA = "0x171C4C0")]
		private bool validateMaterialIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000D5E")]
		[Address(RVA = "0x171CFD8", Offset = "0x171CFD8", VA = "0x171CFD8")]
		public BuildVolumeMesh()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4CAC", Offset = "0x9C4CAC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4CAC", Offset = "0x9C4CAC")]
	public class BuildVolumeSpots : CGModule
	{
		[Token(Token = "0x20001B6")]
		private class GroupSet
		{
			[Token(Token = "0x40007CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CGBoundsGroup Group;

			[Token(Token = "0x40007CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float Length;

			[Token(Token = "0x40007CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int> Items;

			[Token(Token = "0x40007CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<float> Distances;

			[Token(Token = "0x6000D8F")]
			[Address(RVA = "0x1E07578", Offset = "0x1E07578", VA = "0x1E07578")]
			public GroupSet()
			{
			}
		}

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CE30C", Offset = "0x9CE30C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CE3EC", Offset = "0x9CE3EC")]
		public CGModuleInputSlot InBounds;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CE4A8", Offset = "0x9CE4A8")]
		[HideInInspector]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CE518", Offset = "0x9CE518")]
		[FloatRegion]
		private FloatRegion m_Range;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CE5A0", Offset = "0x9CE5A0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CE5A0", Offset = "0x9CE5A0")]
		[SerializeField]
		private bool m_UseVolume;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CE624", Offset = "0x9CE624")]
		[SerializeField]
		private bool m_Simulate;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9CE670", Offset = "0x9CE670")]
		[SerializeField]
		[AttributeAttribute(Name = "SectionAttribute", RVA = "0x9CE670", Offset = "0x9CE670")]
		private float m_CrossBase;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private AnimationCurve m_CrossCurve;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CE720", Offset = "0x9CE720")]
		[SerializeField]
		[ArrayEx]
		private List<CGBoundsGroup> m_Groups;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[IntRegion]
		[SerializeField]
		private IntRegion m_RepeatingGroups;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private CurvyRepeatingOrderEnum m_RepeatingOrder;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private bool m_FitEnd;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CE810", Offset = "0x9CE810")]
		private int <Count>k__BackingField;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public CGSpots SimulatedSpots;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private WeightedRandom<int> mGroupBag;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private List<CGBounds> mBounds;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CE820", Offset = "0x9CE820")]
		private CGPath <Path>k__BackingField;

		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CE830", Offset = "0x9CE830")]
		private float <StartDistance>k__BackingField;

		[Token(Token = "0x170002D8")]
		public FloatRegion Range
		{
			[Token(Token = "0x6000D5F")]
			[Address(RVA = "0x171D108", Offset = "0x171D108", VA = "0x171D108")]
			get
			{
				return default(FloatRegion);
			}
			[Token(Token = "0x6000D60")]
			[Address(RVA = "0x171D118", Offset = "0x171D118", VA = "0x171D118")]
			set
			{
			}
		}

		[Token(Token = "0x170002D9")]
		public bool UseVolume
		{
			[Token(Token = "0x6000D61")]
			[Address(RVA = "0x171D170", Offset = "0x171D170", VA = "0x171D170")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D62")]
			[Address(RVA = "0x171D178", Offset = "0x171D178", VA = "0x171D178")]
			set
			{
			}
		}

		[Token(Token = "0x170002DA")]
		public bool Simulate
		{
			[Token(Token = "0x6000D63")]
			[Address(RVA = "0x171D19C", Offset = "0x171D19C", VA = "0x171D19C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D64")]
			[Address(RVA = "0x171D1A4", Offset = "0x171D1A4", VA = "0x171D1A4")]
			set
			{
			}
		}

		[Token(Token = "0x170002DB")]
		public float CrossBase
		{
			[Token(Token = "0x6000D65")]
			[Address(RVA = "0x171D1C8", Offset = "0x171D1C8", VA = "0x171D1C8")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D66")]
			[Address(RVA = "0x171D1D0", Offset = "0x171D1D0", VA = "0x171D1D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002DC")]
		public AnimationCurve CrossCurve
		{
			[Token(Token = "0x6000D67")]
			[Address(RVA = "0x171D210", Offset = "0x171D210", VA = "0x171D210")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D68")]
			[Address(RVA = "0x171D218", Offset = "0x171D218", VA = "0x171D218")]
			set
			{
			}
		}

		[Token(Token = "0x170002DD")]
		public List<CGBoundsGroup> Groups
		{
			[Token(Token = "0x6000D69")]
			[Address(RVA = "0x171D250", Offset = "0x171D250", VA = "0x171D250")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D6A")]
			[Address(RVA = "0x171D258", Offset = "0x171D258", VA = "0x171D258")]
			set
			{
			}
		}

		[Token(Token = "0x170002DE")]
		public CurvyRepeatingOrderEnum RepeatingOrder
		{
			[Token(Token = "0x6000D6B")]
			[Address(RVA = "0x171D270", Offset = "0x171D270", VA = "0x171D270")]
			get
			{
				return default(CurvyRepeatingOrderEnum);
			}
			[Token(Token = "0x6000D6C")]
			[Address(RVA = "0x171D278", Offset = "0x171D278", VA = "0x171D278")]
			set
			{
			}
		}

		[Token(Token = "0x170002DF")]
		public int FirstRepeating
		{
			[Token(Token = "0x6000D6D")]
			[Address(RVA = "0x171D290", Offset = "0x171D290", VA = "0x171D290")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D6E")]
			[Address(RVA = "0x171D298", Offset = "0x171D298", VA = "0x171D298")]
			set
			{
			}
		}

		[Token(Token = "0x170002E0")]
		public int LastRepeating
		{
			[Token(Token = "0x6000D6F")]
			[Address(RVA = "0x171D344", Offset = "0x171D344", VA = "0x171D344")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D70")]
			[Address(RVA = "0x171D34C", Offset = "0x171D34C", VA = "0x171D34C")]
			set
			{
			}
		}

		[Token(Token = "0x170002E1")]
		public bool FitEnd
		{
			[Token(Token = "0x6000D71")]
			[Address(RVA = "0x171D3B8", Offset = "0x171D3B8", VA = "0x171D3B8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D72")]
			[Address(RVA = "0x171D3C0", Offset = "0x171D3C0", VA = "0x171D3C0")]
			set
			{
			}
		}

		[Token(Token = "0x170002E2")]
		public int GroupCount
		{
			[Token(Token = "0x6000D73")]
			[Address(RVA = "0x171D2F8", Offset = "0x171D2F8", VA = "0x171D2F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002E3")]
		public GUIContent[] BoundsNames
		{
			[Token(Token = "0x6000D74")]
			[Address(RVA = "0x171D3E4", Offset = "0x171D3E4", VA = "0x171D3E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E4")]
		public int[] BoundsIndices
		{
			[Token(Token = "0x6000D75")]
			[Address(RVA = "0x171D608", Offset = "0x171D608", VA = "0x171D608")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E5")]
		public int Count
		{
			[Token(Token = "0x6000D76")]
			[Address(RVA = "0x171D6CC", Offset = "0x171D6CC", VA = "0x171D6CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A3C", Offset = "0x9D2A3C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000D77")]
			[Address(RVA = "0x171D6D4", Offset = "0x171D6D4", VA = "0x171D6D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A4C", Offset = "0x9D2A4C")]
			private set
			{
			}
		}

		[Token(Token = "0x170002E6")]
		private int lastGroupIndex
		{
			[Token(Token = "0x6000D78")]
			[Address(RVA = "0x171D6DC", Offset = "0x171D6DC", VA = "0x171D6DC")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170002E7")]
		private RegionOptions<float> RangeOptions
		{
			[Token(Token = "0x6000D79")]
			[Address(RVA = "0x171D6FC", Offset = "0x171D6FC", VA = "0x171D6FC")]
			get
			{
				return default(RegionOptions<float>);
			}
		}

		[Token(Token = "0x170002E8")]
		private RegionOptions<int> RepeatingGroupsOptions
		{
			[Token(Token = "0x6000D7A")]
			[Address(RVA = "0x171D76C", Offset = "0x171D76C", VA = "0x171D76C")]
			get
			{
				return default(RegionOptions<int>);
			}
		}

		[Token(Token = "0x170002E9")]
		private CGPath Path
		{
			[Token(Token = "0x6000D7B")]
			[Address(RVA = "0x171D800", Offset = "0x171D800", VA = "0x171D800")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A5C", Offset = "0x9D2A5C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D7C")]
			[Address(RVA = "0x171D808", Offset = "0x171D808", VA = "0x171D808")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A6C", Offset = "0x9D2A6C")]
			set
			{
			}
		}

		[Token(Token = "0x170002EA")]
		private CGVolume Volume
		{
			[Token(Token = "0x6000D7D")]
			[Address(RVA = "0x171D818", Offset = "0x171D818", VA = "0x171D818")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002EB")]
		private float Length
		{
			[Token(Token = "0x6000D7E")]
			[Address(RVA = "0x171D898", Offset = "0x171D898", VA = "0x171D898")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002EC")]
		private float StartDistance
		{
			[Token(Token = "0x6000D7F")]
			[Address(RVA = "0x171D8D4", Offset = "0x171D8D4", VA = "0x171D8D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A7C", Offset = "0x9D2A7C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D80")]
			[Address(RVA = "0x171D8DC", Offset = "0x171D8DC", VA = "0x171D8DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A8C", Offset = "0x9D2A8C")]
			set
			{
			}
		}

		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x171D8E4", Offset = "0x171D8E4", VA = "0x171D8E4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x171D918", Offset = "0x171D918", VA = "0x171D918", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000D83")]
		[Address(RVA = "0x171DB54", Offset = "0x171DB54", VA = "0x171DB54", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000D84")]
		[Address(RVA = "0x171DC44", Offset = "0x171DC44", VA = "0x171DC44")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000D85")]
		[Address(RVA = "0x171DD44", Offset = "0x171DD44", VA = "0x171DD44", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000D86")]
		[Address(RVA = "0x171DA54", Offset = "0x171DA54", VA = "0x171DA54")]
		public CGBoundsGroup AddGroup(string name)
		{
			return null;
		}

		[Token(Token = "0x6000D87")]
		[Address(RVA = "0x171FCA4", Offset = "0x171FCA4", VA = "0x171FCA4")]
		public void RemoveGroup(CGBoundsGroup group)
		{
		}

		[Token(Token = "0x6000D88")]
		[Address(RVA = "0x171F0DC", Offset = "0x171F0DC", VA = "0x171F0DC")]
		private GroupSet addGroupItems(CGBoundsGroup group, ref List<CGSpot> spots, ref float remainingLength, ref float currentDistance, bool calcLengthOnly = false)
		{
			return null;
		}

		[Token(Token = "0x6000D89")]
		[Address(RVA = "0x171F90C", Offset = "0x171F90C", VA = "0x171F90C")]
		private void rebase(ref List<CGSpot> spots, ref List<GroupSet> sets, float currentDistance)
		{
		}

		[Token(Token = "0x6000D8A")]
		[Address(RVA = "0x171FDA4", Offset = "0x171FDA4", VA = "0x171FDA4")]
		private CGSpot getSpot(int itemID, ref CGBoundsGroup group, ref CGBounds bounds, float startDist)
		{
			return default(CGSpot);
		}

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x171EEE4", Offset = "0x171EEE4", VA = "0x171EEE4")]
		private void prepare()
		{
		}

		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x171FD14", Offset = "0x171FD14", VA = "0x171FD14")]
		private CGBounds getItemBounds(int itemIndex)
		{
			return null;
		}

		[Token(Token = "0x6000D8D")]
		[Address(RVA = "0x17201DC", Offset = "0x17201DC", VA = "0x17201DC")]
		private float getCrossValue(float globalF, CGBoundsGroup group)
		{
			return default(float);
		}

		[Token(Token = "0x6000D8E")]
		[Address(RVA = "0x1720470", Offset = "0x1720470", VA = "0x1720470")]
		public BuildVolumeSpots()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4D4C", Offset = "0x9C4D4C")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4D4C", Offset = "0x9C4D4C")]
	public class ConformPath : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CE840", Offset = "0x9CE840")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9CE918", Offset = "0x9CE918")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "VectorExAttribute", RVA = "0x9CE988", Offset = "0x9CE988")]
		private Vector3 m_Direction;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private float m_MaxDistance;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float m_Offset;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool m_Warp;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private LayerMask m_LayerMask;

		[Token(Token = "0x170002ED")]
		public Vector3 Direction
		{
			[Token(Token = "0x6000D90")]
			[Address(RVA = "0x1C42BAC", Offset = "0x1C42BAC", VA = "0x1C42BAC")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000D91")]
			[Address(RVA = "0x1C42BB8", Offset = "0x1C42BB8", VA = "0x1C42BB8")]
			set
			{
			}
		}

		[Token(Token = "0x170002EE")]
		public float MaxDistance
		{
			[Token(Token = "0x6000D92")]
			[Address(RVA = "0x1C42C28", Offset = "0x1C42C28", VA = "0x1C42C28")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D93")]
			[Address(RVA = "0x1C42C30", Offset = "0x1C42C30", VA = "0x1C42C30")]
			set
			{
			}
		}

		[Token(Token = "0x170002EF")]
		public float Offset
		{
			[Token(Token = "0x6000D94")]
			[Address(RVA = "0x1C42C4C", Offset = "0x1C42C4C", VA = "0x1C42C4C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000D95")]
			[Address(RVA = "0x1C42C54", Offset = "0x1C42C54", VA = "0x1C42C54")]
			set
			{
			}
		}

		[Token(Token = "0x170002F0")]
		public bool Warp
		{
			[Token(Token = "0x6000D96")]
			[Address(RVA = "0x1C42C70", Offset = "0x1C42C70", VA = "0x1C42C70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000D97")]
			[Address(RVA = "0x1C42C78", Offset = "0x1C42C78", VA = "0x1C42C78")]
			set
			{
			}
		}

		[Token(Token = "0x170002F1")]
		public LayerMask LayerMask
		{
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x1C42CA0", Offset = "0x1C42CA0", VA = "0x1C42CA0")]
			get
			{
				return default(LayerMask);
			}
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x1C42CA8", Offset = "0x1C42CA8", VA = "0x1C42CA8")]
			set
			{
			}
		}

		[Token(Token = "0x170002F2")]
		public float PathLength
		{
			[Token(Token = "0x6000D9C")]
			[Address(RVA = "0x1C42DF0", Offset = "0x1C42DF0", VA = "0x1C42DF0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170002F3")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000D9D")]
			[Address(RVA = "0x1C42F18", Offset = "0x1C42F18", VA = "0x1C42F18", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x1C42D04", Offset = "0x1C42D04", VA = "0x1C42D04", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x1C42D3C", Offset = "0x1C42D3C", VA = "0x1C42D3C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x1C43004", Offset = "0x1C43004", VA = "0x1C43004", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x1C4314C", Offset = "0x1C4314C", VA = "0x1C4314C")]
		public static CGPath Conform(Transform pathTransform, CGPath path, LayerMask layers, Vector3 projectionDirection, float offset, float rayLength, bool warp)
		{
			return null;
		}

		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x1C4347C", Offset = "0x1C4347C", VA = "0x1C4347C")]
		public ConformPath()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4DE4", Offset = "0x9C4DE4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4DE4", Offset = "0x9C4DE4")]
	public class CreateGameObject : CGModule
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CEA30", Offset = "0x9CEA30")]
		public CGModuleInputSlot InGameObjectArray;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CEB04", Offset = "0x9CEB04")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x9CEBC8", Offset = "0x9CEBC8")]
		private CGGameObjectResourceCollection m_Resources;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CEC20", Offset = "0x9CEC20")]
		[SerializeField]
		private bool m_MakeStatic;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x9CEC6C", Offset = "0x9CEC6C")]
		private int m_Layer;

		[Token(Token = "0x170002F4")]
		public int Layer
		{
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0x1C43C18", Offset = "0x1C43C18", VA = "0x1C43C18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000DA2")]
			[Address(RVA = "0x1C43C20", Offset = "0x1C43C20", VA = "0x1C43C20")]
			set
			{
			}
		}

		[Token(Token = "0x170002F5")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000DA3")]
			[Address(RVA = "0x1C43C6C", Offset = "0x1C43C6C", VA = "0x1C43C6C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x1C43C74", Offset = "0x1C43C74", VA = "0x1C43C74")]
			set
			{
			}
		}

		[Token(Token = "0x170002F6")]
		public CGGameObjectResourceCollection GameObjects
		{
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x1C43C9C", Offset = "0x1C43C9C", VA = "0x1C43C9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002F7")]
		public int GameObjectCount
		{
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x1C43CA4", Offset = "0x1C43CA4", VA = "0x1C43CA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x1C43CC0", Offset = "0x1C43CC0", VA = "0x1C43CC0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x1C43E6C", Offset = "0x1C43E6C", VA = "0x1C43E6C", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x1C43E70", Offset = "0x1C43E70", VA = "0x1C43E70", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x1C43D10", Offset = "0x1C43D10", VA = "0x1C43D10")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000DAB")]
		[Address(RVA = "0x1C43E74", Offset = "0x1C43E74", VA = "0x1C43E74", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x1C43EBC", Offset = "0x1C43EBC", VA = "0x1C43EBC", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x1C44784", Offset = "0x1C44784", VA = "0x1C44784")]
		public CreateGameObject()
		{
		}
	}
	[Token(Token = "0x20001B9")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4E60", Offset = "0x9C4E60")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4E60", Offset = "0x9C4E60")]
	public class CreateMesh : CGModule
	{
		[Serializable]
		[Token(Token = "0x20001BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9C4EDC", Offset = "0x9C4EDC")]
		private sealed class <>c
		{
			[Token(Token = "0x40007F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<CGSpot> <>9__108_0;

			[Token(Token = "0x6000DEC")]
			[Address(RVA = "0x1E07CD0", Offset = "0x1E07CD0", VA = "0x1E07CD0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000DED")]
			[Address(RVA = "0x1E07CD8", Offset = "0x1E07CD8", VA = "0x1E07CD8")]
			internal int <createSpotMeshes>b__108_0(CGSpot a, CGSpot b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x40007DA")]
		private const string DefaultTag = "Untagged";

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CECD4", Offset = "0x9CECD4")]
		public CGModuleInputSlot InVMeshArray;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CEDA8", Offset = "0x9CEDA8")]
		public CGModuleInputSlot InSpots;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceCollectionManagerAttribute", RVA = "0x9CEE80", Offset = "0x9CEE80")]
		private CGMeshResourceCollection m_MeshResources;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CEED8", Offset = "0x9CEED8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CEED8", Offset = "0x9CEED8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CEED8", Offset = "0x9CEED8")]
		private bool m_Combine;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CEFD8", Offset = "0x9CEFD8")]
		private bool m_GroupMeshes;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF024", Offset = "0x9CF024")]
		private CGYesNoAuto m_AddNormals;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF0DC", Offset = "0x9CF0DC")]
		private CGYesNoAuto m_AddTangents;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF194", Offset = "0x9CF194")]
		[SerializeField]
		private bool m_AddUV2;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CF24C", Offset = "0x9CF24C")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF24C", Offset = "0x9CF24C")]
		private bool m_MakeStatic;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CF328", Offset = "0x9CF328")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF328", Offset = "0x9CF328")]
		[AttributeAttribute(Name = "LayerAttribute", RVA = "0x9CF328", Offset = "0x9CF328")]
		private int m_Layer;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TagAttribute", RVA = "0x9CF43C", Offset = "0x9CF43C")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF43C", Offset = "0x9CF43C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CF43C", Offset = "0x9CF43C")]
		private string m_Tag;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CF558", Offset = "0x9CF558")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF558", Offset = "0x9CF558")]
		private bool m_RendererEnabled;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF634", Offset = "0x9CF634")]
		private ShadowCastingMode m_CastShadows;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF6EC", Offset = "0x9CF6EC")]
		private bool m_ReceiveShadows;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF7A4", Offset = "0x9CF7A4")]
		[SerializeField]
		private LightProbeUsage m_LightProbeUsage;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF85C", Offset = "0x9CF85C")]
		[SerializeField]
		[HideInInspector]
		private bool m_UseLightProbes;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF924", Offset = "0x9CF924")]
		[SerializeField]
		private ReflectionProbeUsage m_ReflectionProbes;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CF9DC", Offset = "0x9CF9DC")]
		[SerializeField]
		private Transform m_AnchorOverride;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CFA94", Offset = "0x9CFA94")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9CFA94", Offset = "0x9CFA94")]
		[SerializeField]
		private CGColliderEnum m_Collider;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CFB70", Offset = "0x9CFB70")]
		[SerializeField]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CFB70", Offset = "0x9CFB70")]
		private bool m_Convex;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CFC94", Offset = "0x9CFC94")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9CFC94", Offset = "0x9CFC94")]
		[SerializeField]
		[AttributeAttribute(Name = "EnumFlagAttribute", RVA = "0x9CFC94", Offset = "0x9CFC94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9CFC94", Offset = "0x9CFC94")]
		private MeshColliderCookingOptions m_CookingOptions;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[AttributeAttribute(Name = "LabelAttribute", RVA = "0x9CFE14", Offset = "0x9CFE14")]
		[SerializeField]
		private bool m_AutoUpdateColliders;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private PhysicMaterial m_Material;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9CFE8C", Offset = "0x9CFE8C")]
		private int <VertexCount>k__BackingField;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private int mCurrentMeshCount;

		[Token(Token = "0x170002F8")]
		public bool Combine
		{
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x16F65F0", Offset = "0x16F65F0", VA = "0x16F65F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DAF")]
			[Address(RVA = "0x16F65F8", Offset = "0x16F65F8", VA = "0x16F65F8")]
			set
			{
			}
		}

		[Token(Token = "0x170002F9")]
		public bool GroupMeshes
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x16F6620", Offset = "0x16F6620", VA = "0x16F6620")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DB1")]
			[Address(RVA = "0x16F6628", Offset = "0x16F6628", VA = "0x16F6628")]
			set
			{
			}
		}

		[Token(Token = "0x170002FA")]
		public CGYesNoAuto AddNormals
		{
			[Token(Token = "0x6000DB2")]
			[Address(RVA = "0x16F6650", Offset = "0x16F6650", VA = "0x16F6650")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x16F6658", Offset = "0x16F6658", VA = "0x16F6658")]
			set
			{
			}
		}

		[Token(Token = "0x170002FB")]
		public CGYesNoAuto AddTangents
		{
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x16F6674", Offset = "0x16F6674", VA = "0x16F6674")]
			get
			{
				return default(CGYesNoAuto);
			}
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x16F667C", Offset = "0x16F667C", VA = "0x16F667C")]
			set
			{
			}
		}

		[Token(Token = "0x170002FC")]
		public bool AddUV2
		{
			[Token(Token = "0x6000DB6")]
			[Address(RVA = "0x16F6698", Offset = "0x16F6698", VA = "0x16F6698")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DB7")]
			[Address(RVA = "0x16F66A0", Offset = "0x16F66A0", VA = "0x16F66A0")]
			set
			{
			}
		}

		[Token(Token = "0x170002FD")]
		public int Layer
		{
			[Token(Token = "0x6000DB8")]
			[Address(RVA = "0x16F66C8", Offset = "0x16F66C8", VA = "0x16F66C8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x16F66D0", Offset = "0x16F66D0", VA = "0x16F66D0")]
			set
			{
			}
		}

		[Token(Token = "0x170002FE")]
		public string Tag
		{
			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x16F671C", Offset = "0x16F671C", VA = "0x16F671C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x16F6724", Offset = "0x16F6724", VA = "0x16F6724")]
			set
			{
			}
		}

		[Token(Token = "0x170002FF")]
		public bool MakeStatic
		{
			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x16F677C", Offset = "0x16F677C", VA = "0x16F677C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x16F6784", Offset = "0x16F6784", VA = "0x16F6784")]
			set
			{
			}
		}

		[Token(Token = "0x17000300")]
		public bool RendererEnabled
		{
			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x16F67AC", Offset = "0x16F67AC", VA = "0x16F67AC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x16F67B4", Offset = "0x16F67B4", VA = "0x16F67B4")]
			set
			{
			}
		}

		[Token(Token = "0x17000301")]
		public ShadowCastingMode CastShadows
		{
			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x16F67DC", Offset = "0x16F67DC", VA = "0x16F67DC")]
			get
			{
				return default(ShadowCastingMode);
			}
			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x16F67E4", Offset = "0x16F67E4", VA = "0x16F67E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000302")]
		public bool ReceiveShadows
		{
			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x16F6800", Offset = "0x16F6800", VA = "0x16F6800")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DC3")]
			[Address(RVA = "0x16F6808", Offset = "0x16F6808", VA = "0x16F6808")]
			set
			{
			}
		}

		[Token(Token = "0x17000303")]
		public bool UseLightProbes
		{
			[Token(Token = "0x6000DC4")]
			[Address(RVA = "0x16F6830", Offset = "0x16F6830", VA = "0x16F6830")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DC5")]
			[Address(RVA = "0x16F6838", Offset = "0x16F6838", VA = "0x16F6838")]
			set
			{
			}
		}

		[Token(Token = "0x17000304")]
		public LightProbeUsage LightProbeUsage
		{
			[Token(Token = "0x6000DC6")]
			[Address(RVA = "0x16F6860", Offset = "0x16F6860", VA = "0x16F6860")]
			get
			{
				return default(LightProbeUsage);
			}
			[Token(Token = "0x6000DC7")]
			[Address(RVA = "0x16F6868", Offset = "0x16F6868", VA = "0x16F6868")]
			set
			{
			}
		}

		[Token(Token = "0x17000305")]
		public ReflectionProbeUsage ReflectionProbes
		{
			[Token(Token = "0x6000DC8")]
			[Address(RVA = "0x16F6884", Offset = "0x16F6884", VA = "0x16F6884")]
			get
			{
				return default(ReflectionProbeUsage);
			}
			[Token(Token = "0x6000DC9")]
			[Address(RVA = "0x16F688C", Offset = "0x16F688C", VA = "0x16F688C")]
			set
			{
			}
		}

		[Token(Token = "0x17000306")]
		public Transform AnchorOverride
		{
			[Token(Token = "0x6000DCA")]
			[Address(RVA = "0x16F68A8", Offset = "0x16F68A8", VA = "0x16F68A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DCB")]
			[Address(RVA = "0x16F68B0", Offset = "0x16F68B0", VA = "0x16F68B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000307")]
		public CGColliderEnum Collider
		{
			[Token(Token = "0x6000DCC")]
			[Address(RVA = "0x16F6950", Offset = "0x16F6950", VA = "0x16F6950")]
			get
			{
				return default(CGColliderEnum);
			}
			[Token(Token = "0x6000DCD")]
			[Address(RVA = "0x16F6958", Offset = "0x16F6958", VA = "0x16F6958")]
			set
			{
			}
		}

		[Token(Token = "0x17000308")]
		public bool AutoUpdateColliders
		{
			[Token(Token = "0x6000DCE")]
			[Address(RVA = "0x16F6974", Offset = "0x16F6974", VA = "0x16F6974")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x16F697C", Offset = "0x16F697C", VA = "0x16F697C")]
			set
			{
			}
		}

		[Token(Token = "0x17000309")]
		public bool Convex
		{
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x16F69A4", Offset = "0x16F69A4", VA = "0x16F69A4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x16F69AC", Offset = "0x16F69AC", VA = "0x16F69AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700030A")]
		public MeshColliderCookingOptions CookingOptions
		{
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x16F69D4", Offset = "0x16F69D4", VA = "0x16F69D4")]
			get
			{
				return default(MeshColliderCookingOptions);
			}
			[Token(Token = "0x6000DD3")]
			[Address(RVA = "0x16F69DC", Offset = "0x16F69DC", VA = "0x16F69DC")]
			set
			{
			}
		}

		[Token(Token = "0x1700030B")]
		public PhysicMaterial Material
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x16F69F8", Offset = "0x16F69F8", VA = "0x16F69F8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x16F6A00", Offset = "0x16F6A00", VA = "0x16F6A00")]
			set
			{
			}
		}

		[Token(Token = "0x1700030C")]
		public CGMeshResourceCollection Meshes
		{
			[Token(Token = "0x6000DD6")]
			[Address(RVA = "0x16F6A9C", Offset = "0x16F6A9C", VA = "0x16F6A9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700030D")]
		public int MeshCount
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x16F6AA4", Offset = "0x16F6AA4", VA = "0x16F6AA4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700030E")]
		public int VertexCount
		{
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x16F6AC0", Offset = "0x16F6AC0", VA = "0x16F6AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2A9C", Offset = "0x9D2A9C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000DD9")]
			[Address(RVA = "0x16F6AC8", Offset = "0x16F6AC8", VA = "0x16F6AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9D2AAC", Offset = "0x9D2AAC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700030F")]
		private bool canGroupMeshes
		{
			[Token(Token = "0x6000DDA")]
			[Address(RVA = "0x16F6AD0", Offset = "0x16F6AD0", VA = "0x16F6AD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000310")]
		private bool canModifyStaticFlag
		{
			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0x16F6B18", Offset = "0x16F6B18", VA = "0x16F6B18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000311")]
		private bool canUpdate
		{
			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0x16F6B20", Offset = "0x16F6B20", VA = "0x16F6B20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x16F6B5C", Offset = "0x16F6B5C", VA = "0x16F6B5C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x16F6DF0", Offset = "0x16F6DF0", VA = "0x16F6DF0", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x16F6DD4", Offset = "0x16F6DD4", VA = "0x16F6DD4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x16F6F3C", Offset = "0x16F6F3C", VA = "0x16F6F3C", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x16F6F90", Offset = "0x16F6F90", VA = "0x16F6F90", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x16F807C", Offset = "0x16F807C", VA = "0x16F807C")]
		public GameObject SaveToScene([Optional] Transform parent)
		{
			return null;
		}

		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x16F7F64", Offset = "0x16F7F64", VA = "0x16F7F64")]
		public void UpdateColliders()
		{
		}

		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x16F850C", Offset = "0x16F850C", VA = "0x16F850C", Slot = "4")]
		protected override bool UpgradeVersion(string oldVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x16F7B3C", Offset = "0x16F7B3C", VA = "0x16F7B3C")]
		private void createMeshes(ref List<CGVMesh> vMeshes, bool combine)
		{
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x16F7270", Offset = "0x16F7270", VA = "0x16F7270")]
		private void createSpotMeshes(ref List<CGVMesh> vMeshes, ref CGSpots spots, bool combine)
		{
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x16F8514", Offset = "0x16F8514", VA = "0x16F8514")]
		private CGMeshResource writeVMeshToMesh(ref CGVMesh vmesh)
		{
			return null;
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x16F6E0C", Offset = "0x16F6E0C", VA = "0x16F6E0C")]
		private void removeUnusedResource()
		{
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x16F8758", Offset = "0x16F8758", VA = "0x16F8758")]
		private CGMeshResource getNewMesh()
		{
			return null;
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x16F8A6C", Offset = "0x16F8A6C", VA = "0x16F8A6C")]
		public CreateMesh()
		{
		}
	}
	[Token(Token = "0x20001BB")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4EEC", Offset = "0x9C4EEC")]
	public class CreatePathLineRenderer : CGModule
	{
		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CFE9C", Offset = "0x9CFE9C")]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private LineRenderer mLineRenderer;

		[Token(Token = "0x17000312")]
		public LineRenderer LineRenderer
		{
			[Token(Token = "0x6000DEE")]
			[Address(RVA = "0x16F8BA4", Offset = "0x16F8BA4", VA = "0x16F8BA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000313")]
		public override bool IsConfigured
		{
			[Token(Token = "0x6000DEF")]
			[Address(RVA = "0x16F8C58", Offset = "0x16F8C58", VA = "0x16F8C58", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000314")]
		public override bool IsInitialized
		{
			[Token(Token = "0x6000DF0")]
			[Address(RVA = "0x16F8C60", Offset = "0x16F8C60", VA = "0x16F8C60", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000DF1")]
		[Address(RVA = "0x16F8C68", Offset = "0x16F8C68", VA = "0x16F8C68", Slot = "5")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000DF2")]
		[Address(RVA = "0x16F8DA0", Offset = "0x16F8DA0", VA = "0x16F8DA0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000DF3")]
		[Address(RVA = "0x16F8DA8", Offset = "0x16F8DA8", VA = "0x16F8DA8", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000DF4")]
		[Address(RVA = "0x16F8DB0", Offset = "0x16F8DB0", VA = "0x16F8DB0", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000DF5")]
		[Address(RVA = "0x16F8C90", Offset = "0x16F8C90", VA = "0x16F8C90")]
		private void createLR()
		{
		}

		[Token(Token = "0x6000DF6")]
		[Address(RVA = "0x16F8F10", Offset = "0x16F8F10", VA = "0x16F8F10")]
		public CreatePathLineRenderer()
		{
		}
	}
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4F5C", Offset = "0x9C4F5C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4F5C", Offset = "0x9C4F5C")]
	public class DebugVMesh : CGModule
	{
		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9CFF60", Offset = "0x9CFF60")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9D0024", Offset = "0x9D0024")]
		public bool ShowVertices;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowVertexID;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		public bool ShowUV;

		[Token(Token = "0x6000DF7")]
		[Address(RVA = "0x168BAB4", Offset = "0x168BAB4", VA = "0x168BAB4")]
		public DebugVMesh()
		{
		}
	}
	[Token(Token = "0x20001BD")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C4FD8", Offset = "0x9C4FD8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C4FD8", Offset = "0x9C4FD8")]
	public class DebugVolume : CGModule
	{
		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D005C", Offset = "0x9D005C")]
		public CGModuleInputSlot InData;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9D0120", Offset = "0x9D0120")]
		public bool ShowPathSamples;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		public bool ShowCrossSamples;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[IntRegion]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9D0158", Offset = "0x9D0158")]
		public IntRegion LimitCross;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool ShowNormals;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool ShowIndex;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC2")]
		public bool ShowMap;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public Color PathColor;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public Color VolumeColor;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public Color NormalColor;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9D0210", Offset = "0x9D0210")]
		public bool Interpolate;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9D0248", Offset = "0x9D0248")]
		public float InterpolatePathF;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9D029C", Offset = "0x9D029C")]
		public float InterpolateCrossF;

		[Token(Token = "0x6000DF8")]
		[Address(RVA = "0x168BB24", Offset = "0x168BB24", VA = "0x168BB24")]
		public DebugVolume()
		{
		}
	}
	[Token(Token = "0x20001BE")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C5054", Offset = "0x9C5054")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C5054", Offset = "0x9C5054")]
	public class InputGameObject : CGModule
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D02F0", Offset = "0x9D02F0")]
		public CGModuleOutputSlot OutGameObject;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[ArrayEx]
		[SerializeField]
		private List<CGGameObjectProperties> m_GameObjects;

		[Token(Token = "0x17000315")]
		public List<CGGameObjectProperties> GameObjects
		{
			[Token(Token = "0x6000DF9")]
			[Address(RVA = "0x1697A10", Offset = "0x1697A10", VA = "0x1697A10")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000316")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000DFA")]
			[Address(RVA = "0x1697A18", Offset = "0x1697A18", VA = "0x1697A18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000DFB")]
		[Address(RVA = "0x1697A20", Offset = "0x1697A20", VA = "0x1697A20", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000DFC")]
		[Address(RVA = "0x1697A90", Offset = "0x1697A90", VA = "0x1697A90", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000DFD")]
		[Address(RVA = "0x1697C74", Offset = "0x1697C74", VA = "0x1697C74", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000DFE")]
		[Address(RVA = "0x1697CD4", Offset = "0x1697CD4", VA = "0x1697CD4")]
		public InputGameObject()
		{
		}
	}
	[Token(Token = "0x20001BF")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C50EC", Offset = "0x9C50EC")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C50EC", Offset = "0x9C50EC")]
	public class InputMesh : CGModule, IExternalInput
	{
		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D03A4", Offset = "0x9D03A4")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGMeshProperties> m_Meshes;

		[Token(Token = "0x17000317")]
		public List<CGMeshProperties> Meshes
		{
			[Token(Token = "0x6000DFF")]
			[Address(RVA = "0x1697D90", Offset = "0x1697D90", VA = "0x1697D90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000318")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000E00")]
			[Address(RVA = "0x1697D98", Offset = "0x1697D98", VA = "0x1697D98", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E01")]
		[Address(RVA = "0x1697DA0", Offset = "0x1697DA0", VA = "0x1697DA0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E02")]
		[Address(RVA = "0x1697E10", Offset = "0x1697E10", VA = "0x1697E10", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000E03")]
		[Address(RVA = "0x1698038", Offset = "0x1698038", VA = "0x1698038", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000E04")]
		[Address(RVA = "0x1698098", Offset = "0x1698098", VA = "0x1698098")]
		public InputMesh()
		{
		}
	}
	[Token(Token = "0x20001C0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C5184", Offset = "0x9C5184")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C5184", Offset = "0x9C5184")]
	public class InputSplinePath : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0458", Offset = "0x9D0458")]
		[HideInInspector]
		public CGModuleOutputSlot Path;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x9D04C8", Offset = "0x9D04C8")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9D04C8", Offset = "0x9D04C8")]
		[AttributeAttribute(Name = "FieldConditionAttribute", RVA = "0x9D04C8", Offset = "0x9D04C8")]
		[SerializeField]
		private CurvySpline m_Spline;

		[Token(Token = "0x17000319")]
		public CurvySpline Spline
		{
			[Token(Token = "0x6000E05")]
			[Address(RVA = "0x1698320", Offset = "0x1698320", VA = "0x1698320")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E06")]
			[Address(RVA = "0x1698328", Offset = "0x1698328", VA = "0x1698328")]
			set
			{
			}
		}

		[Token(Token = "0x1700031A")]
		public override bool IsInitialized
		{
			[Token(Token = "0x6000E07")]
			[Address(RVA = "0x16984F8", Offset = "0x16984F8", VA = "0x16984F8", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700031B")]
		public override bool IsConfigured
		{
			[Token(Token = "0x6000E08")]
			[Address(RVA = "0x169859C", Offset = "0x169859C", VA = "0x169859C", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700031C")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000E09")]
			[Address(RVA = "0x1698628", Offset = "0x1698628", VA = "0x1698628", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700031D")]
		public float PathLength
		{
			[Token(Token = "0x6000E0A")]
			[Address(RVA = "0x1698630", Offset = "0x1698630", VA = "0x1698630", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700031E")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E0B")]
			[Address(RVA = "0x1698678", Offset = "0x1698678", VA = "0x1698678", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E0C")]
		[Address(RVA = "0x16986C0", Offset = "0x16986C0", VA = "0x16986C0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E0D")]
		[Address(RVA = "0x16986E8", Offset = "0x16986E8", VA = "0x16986E8", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000E0E")]
		[Address(RVA = "0x1698808", Offset = "0x1698808", VA = "0x1698808", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E0F")]
		[Address(RVA = "0x1698834", Offset = "0x1698834", VA = "0x1698834", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E10")]
		[Address(RVA = "0x1698A1C", Offset = "0x1698A1C", VA = "0x1698A1C", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000E11")]
		[Address(RVA = "0x1698A24", Offset = "0x1698A24", VA = "0x1698A24", Slot = "14")]
		public override void OnTemplateCreated()
		{
		}

		[Token(Token = "0x6000E12")]
		[Address(RVA = "0x1698AC8", Offset = "0x1698AC8", VA = "0x1698AC8")]
		private void m_Spline_OnRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000E13")]
		[Address(RVA = "0x16983E4", Offset = "0x16983E4", VA = "0x16983E4")]
		private void OnSplineAssigned()
		{
		}

		[Token(Token = "0x6000E14")]
		[Address(RVA = "0x1698C34", Offset = "0x1698C34", VA = "0x1698C34", Slot = "15")]
		protected override void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x6000E15")]
		[Address(RVA = "0x1698E7C", Offset = "0x1698E7C", VA = "0x1698E7C")]
		public InputSplinePath()
		{
		}
	}
	[Token(Token = "0x20001C1")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C521C", Offset = "0x9C521C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C521C", Offset = "0x9C521C")]
	public class InputSplineShape : SplineInputModuleBase, IExternalInput, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D058C", Offset = "0x9D058C")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "TabAttribute", RVA = "0x9D05FC", Offset = "0x9D05FC")]
		[SerializeField]
		[AttributeAttribute(Name = "CGResourceManagerAttribute", RVA = "0x9D05FC", Offset = "0x9D05FC")]
		private CurvySpline m_Shape;

		[Token(Token = "0x1700031F")]
		public CurvySpline Shape
		{
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x1698EEC", Offset = "0x1698EEC", VA = "0x1698EEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E17")]
			[Address(RVA = "0x1698EF4", Offset = "0x1698EF4", VA = "0x1698EF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000320")]
		public bool FreeForm
		{
			[Token(Token = "0x6000E18")]
			[Address(RVA = "0x16990D8", Offset = "0x16990D8", VA = "0x16990D8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E19")]
			[Address(RVA = "0x16991BC", Offset = "0x16991BC", VA = "0x16991BC")]
			set
			{
			}
		}

		[Token(Token = "0x17000321")]
		public override bool IsInitialized
		{
			[Token(Token = "0x6000E1A")]
			[Address(RVA = "0x169931C", Offset = "0x169931C", VA = "0x169931C", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000322")]
		public override bool IsConfigured
		{
			[Token(Token = "0x6000E1B")]
			[Address(RVA = "0x16993C0", Offset = "0x16993C0", VA = "0x16993C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000323")]
		public float PathLength
		{
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x169944C", Offset = "0x169944C", VA = "0x169944C", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000324")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0x1699494", Offset = "0x1699494", VA = "0x1699494", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000325")]
		public bool SupportsIPE
		{
			[Token(Token = "0x6000E1E")]
			[Address(RVA = "0x16994DC", Offset = "0x16994DC", VA = "0x16994DC", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E1F")]
		[Address(RVA = "0x16994E0", Offset = "0x16994E0", VA = "0x16994E0", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x1699518", Offset = "0x1699518", VA = "0x1699518", Slot = "7")]
		protected override void OnDisable()
		{
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x1699520", Offset = "0x1699520", VA = "0x1699520", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x169954C", Offset = "0x169954C", VA = "0x169954C", Slot = "19")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E23")]
		public T SetManagedShape<T>() where T : CurvyShape2D
		{
			return null;
		}

		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x16996A0", Offset = "0x16996A0", VA = "0x16996A0")]
		public void RemoveManagedShape()
		{
		}

		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x169975C", Offset = "0x169975C", VA = "0x169975C")]
		private void m_Shape_OnRefresh(CurvySplineEventArgs e)
		{
		}

		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x1698FB0", Offset = "0x1698FB0", VA = "0x1698FB0")]
		private void OnShapeAssigned()
		{
		}

		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x16998C8", Offset = "0x16998C8", VA = "0x16998C8", Slot = "15")]
		protected override void ValidateStartAndEndCps()
		{
		}

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x1699B10", Offset = "0x1699B10", VA = "0x1699B10")]
		public InputSplineShape()
		{
		}
	}
	[Token(Token = "0x20001C2")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C52B4", Offset = "0x9C52B4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C52B4", Offset = "0x9C52B4")]
	public class InputSpots : CGModule
	{
		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0670", Offset = "0x9D0670")]
		[HideInInspector]
		public CGModuleOutputSlot OutSpots;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[ArrayEx]
		private List<CGSpot> m_Spots;

		[Token(Token = "0x17000326")]
		public List<CGSpot> Spots
		{
			[Token(Token = "0x6000E29")]
			[Address(RVA = "0x1699B80", Offset = "0x1699B80", VA = "0x1699B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E2A")]
			[Address(RVA = "0x1699B88", Offset = "0x1699B88", VA = "0x1699B88")]
			set
			{
			}
		}

		[Token(Token = "0x6000E2B")]
		[Address(RVA = "0x1699BC4", Offset = "0x1699BC4", VA = "0x1699BC4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E2C")]
		[Address(RVA = "0x1699BFC", Offset = "0x1699BFC", VA = "0x1699BFC", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E2D")]
		[Address(RVA = "0x1699C6C", Offset = "0x1699C6C", VA = "0x1699C6C", Slot = "13")]
		public override void OnStateChange()
		{
		}

		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x1699C74", Offset = "0x1699C74", VA = "0x1699C74", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x1699DB4", Offset = "0x1699DB4", VA = "0x1699DB4")]
		public InputSpots()
		{
		}
	}
	[Token(Token = "0x20001C3")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C534C", Offset = "0x9C534C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C534C", Offset = "0x9C534C")]
	public class ModifierMixPaths : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[HideInInspector]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D0718", Offset = "0x9D0718")]
		public CGModuleInputSlot InPathA;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D07DC", Offset = "0x9D07DC")]
		[HideInInspector]
		public CGModuleInputSlot InPathB;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D08A8", Offset = "0x9D08A8")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9D0918", Offset = "0x9D0918")]
		[SerializeField]
		private float m_Mix;

		[Token(Token = "0x17000327")]
		public float Mix
		{
			[Token(Token = "0x6000E30")]
			[Address(RVA = "0x1674130", Offset = "0x1674130", VA = "0x1674130")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000E31")]
			[Address(RVA = "0x1674138", Offset = "0x1674138", VA = "0x1674138")]
			set
			{
			}
		}

		[Token(Token = "0x17000328")]
		public float PathLength
		{
			[Token(Token = "0x6000E32")]
			[Address(RVA = "0x1674154", Offset = "0x1674154", VA = "0x1674154", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000329")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E33")]
			[Address(RVA = "0x16742F8", Offset = "0x16742F8", VA = "0x16742F8", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E34")]
		[Address(RVA = "0x1674488", Offset = "0x1674488", VA = "0x1674488", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E35")]
		[Address(RVA = "0x16744D0", Offset = "0x16744D0", VA = "0x16744D0", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E36")]
		[Address(RVA = "0x1674510", Offset = "0x1674510", VA = "0x1674510", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E37")]
		[Address(RVA = "0x1674660", Offset = "0x1674660", VA = "0x1674660")]
		public static CGPath MixPath(CGPath pathA, CGPath pathB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000E38")]
		[Address(RVA = "0x1674E98", Offset = "0x1674E98", VA = "0x1674E98")]
		public ModifierMixPaths()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C53E4", Offset = "0x9C53E4")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C53E4", Offset = "0x9C53E4")]
	public class ModifierMixShapes : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D09A4", Offset = "0x9D09A4")]
		[HideInInspector]
		public CGModuleInputSlot InShapeA;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D0A70", Offset = "0x9D0A70")]
		[HideInInspector]
		public CGModuleInputSlot InShapeB;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0B3C", Offset = "0x9D0B3C")]
		[HideInInspector]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeExAttribute", RVA = "0x9D0BAC", Offset = "0x9D0BAC")]
		[SerializeField]
		private float m_Mix;

		[Token(Token = "0x1700032A")]
		public float Mix
		{
			[Token(Token = "0x6000E39")]
			[Address(RVA = "0x1674F6C", Offset = "0x1674F6C", VA = "0x1674F6C")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000E3A")]
			[Address(RVA = "0x1674F74", Offset = "0x1674F74", VA = "0x1674F74")]
			set
			{
			}
		}

		[Token(Token = "0x1700032B")]
		public float PathLength
		{
			[Token(Token = "0x6000E3B")]
			[Address(RVA = "0x1674F90", Offset = "0x1674F90", VA = "0x1674F90", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700032C")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E3C")]
			[Address(RVA = "0x1675134", Offset = "0x1675134", VA = "0x1675134", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x16752C4", Offset = "0x16752C4", VA = "0x16752C4", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x167530C", Offset = "0x167530C", VA = "0x167530C", Slot = "12")]
		public override void Reset()
		{
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x167534C", Offset = "0x167534C", VA = "0x167534C", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E40")]
		[Address(RVA = "0x1675490", Offset = "0x1675490", VA = "0x1675490")]
		public static CGShape MixShapes(CGShape shapeA, CGShape shapeB, float mix, [NotNull] List<string> warningsContainer)
		{
			return null;
		}

		[Token(Token = "0x6000E41")]
		[Address(RVA = "0x167491C", Offset = "0x167491C", VA = "0x167491C")]
		public static void InterpolateShape([NotNull] CGShape resultShape, CGShape mainShape, CGShape secondaryShape, float mix, [NotNull] List<string> warningsContainer)
		{
		}

		[Token(Token = "0x6000E42")]
		[Address(RVA = "0x1675590", Offset = "0x1675590", VA = "0x1675590")]
		public ModifierMixShapes()
		{
		}
	}
	[Token(Token = "0x20001C5")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C547C", Offset = "0x9C547C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C547C", Offset = "0x9C547C")]
	public class ModifierPathRelativeTranslation : CGModule, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D0C38", Offset = "0x9D0C38")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0D0C", Offset = "0x9D0D0C")]
		[HideInInspector]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0x9D0D7C", Offset = "0x9D0D7C")]
		private float lateralTranslation;

		[Token(Token = "0x1700032D")]
		public float LateralTranslation
		{
			[Token(Token = "0x6000E43")]
			[Address(RVA = "0x1675664", Offset = "0x1675664", VA = "0x1675664")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000E44")]
			[Address(RVA = "0x167566C", Offset = "0x167566C", VA = "0x167566C")]
			set
			{
			}
		}

		[Token(Token = "0x1700032E")]
		public float PathLength
		{
			[Token(Token = "0x6000E45")]
			[Address(RVA = "0x167568C", Offset = "0x167568C", VA = "0x167568C", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700032F")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E46")]
			[Address(RVA = "0x167577C", Offset = "0x167577C", VA = "0x167577C", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x1675870", Offset = "0x1675870", VA = "0x1675870", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x1675A78", Offset = "0x1675A78", VA = "0x1675A78", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E49")]
		[Address(RVA = "0x1675AC0", Offset = "0x1675AC0", VA = "0x1675AC0")]
		public ModifierPathRelativeTranslation()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C5514", Offset = "0x9C5514")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C5514", Offset = "0x9C5514")]
	public class ModifierTRSMesh : TRSModuleBase
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D0DC8", Offset = "0x9D0DC8")]
		[HideInInspector]
		public CGModuleInputSlot InVMesh;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0E84", Offset = "0x9D0E84")]
		public CGModuleOutputSlot OutVMesh;

		[Token(Token = "0x6000E4A")]
		[Address(RVA = "0x1675B68", Offset = "0x1675B68", VA = "0x1675B68", Slot = "11")]
		public override void Refresh()
		{
		}

		[Token(Token = "0x6000E4B")]
		[Address(RVA = "0x1675D6C", Offset = "0x1675D6C", VA = "0x1675D6C")]
		public ModifierTRSMesh()
		{
		}
	}
	[Token(Token = "0x20001C7")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C55AC", Offset = "0x9C55AC")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C55AC", Offset = "0x9C55AC")]
	public class ModifierTRSPath : TRSModuleBase, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D0F00", Offset = "0x9D0F00")]
		[HideInInspector]
		public CGModuleInputSlot InPath;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D0FD4", Offset = "0x9D0FD4")]
		public CGModuleOutputSlot OutPath;

		[Token(Token = "0x17000330")]
		public float PathLength
		{
			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x1675E14", Offset = "0x1675E14", VA = "0x1675E14", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000331")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x1675F04", Offset = "0x1675F04", VA = "0x1675F04", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E4E")]
		[Address(RVA = "0x1675FF8", Offset = "0x1675FF8", VA = "0x1675FF8", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E4F")]
		[Address(RVA = "0x1676290", Offset = "0x1676290", VA = "0x1676290")]
		public ModifierTRSPath()
		{
		}
	}
	[Token(Token = "0x20001C8")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C5644", Offset = "0x9C5644")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C5644", Offset = "0x9C5644")]
	public class ModifierTRSShape : TRSModuleBase, IOnRequestPath, IOnRequestProcessing
	{
		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "InputSlotInfo", RVA = "0x9D1044", Offset = "0x9D1044")]
		[HideInInspector]
		public CGModuleInputSlot InShape;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[AttributeAttribute(Name = "OutputSlotInfo", RVA = "0x9D1118", Offset = "0x9D1118")]
		public CGModuleOutputSlot OutShape;

		[Token(Token = "0x17000332")]
		public float PathLength
		{
			[Token(Token = "0x6000E50")]
			[Address(RVA = "0x1676338", Offset = "0x1676338", VA = "0x1676338", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000333")]
		public bool PathIsClosed
		{
			[Token(Token = "0x6000E51")]
			[Address(RVA = "0x1676428", Offset = "0x1676428", VA = "0x1676428", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000E52")]
		[Address(RVA = "0x167651C", Offset = "0x167651C", VA = "0x167651C", Slot = "17")]
		public CGData[] OnSlotDataRequest(CGModuleInputSlot requestedBy, CGModuleOutputSlot requestedSlot, params CGDataRequestParameter[] requests)
		{
			return null;
		}

		[Token(Token = "0x6000E53")]
		[Address(RVA = "0x16767B4", Offset = "0x16767B4", VA = "0x16767B4")]
		public ModifierTRSShape()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	[AttributeAttribute(Name = "ModuleInfoAttribute", RVA = "0x9C56DC", Offset = "0x9C56DC")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0x9C56DC", Offset = "0x9C56DC")]
	public class Note : CGModule, INoProcessing
	{
		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0x9D1188", Offset = "0x9D1188")]
		private string m_Note;

		[Token(Token = "0x17000334")]
		public string NoteText
		{
			[Token(Token = "0x6000E54")]
			[Address(RVA = "0x167732C", Offset = "0x167732C", VA = "0x167732C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E55")]
			[Address(RVA = "0x1677334", Offset = "0x1677334", VA = "0x1677334")]
			set
			{
			}
		}

		[Token(Token = "0x6000E56")]
		[Address(RVA = "0x167737C", Offset = "0x167737C", VA = "0x167737C", Slot = "6")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000E57")]
		[Address(RVA = "0x16773C4", Offset = "0x16773C4", VA = "0x16773C4")]
		public Note()
		{
		}
	}
}
namespace Apple.Arcade
{
	[Token(Token = "0x20001CA")]
	public class AppleArcadeFairPlayPlugin
	{
		[Token(Token = "0x6000E58")]
		[Address(RVA = "0x1712278", Offset = "0x1712278", VA = "0x1712278")]
		public static void FairPlayCheck()
		{
		}

		[Token(Token = "0x6000E59")]
		[Address(RVA = "0x171227C", Offset = "0x171227C", VA = "0x171227C")]
		public AppleArcadeFairPlayPlugin()
		{
		}
	}
}
