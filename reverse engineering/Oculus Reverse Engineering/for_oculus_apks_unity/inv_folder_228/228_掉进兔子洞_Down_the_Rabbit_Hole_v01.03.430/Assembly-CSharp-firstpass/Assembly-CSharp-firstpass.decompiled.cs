using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Cortopia.BE.Runtime.Actions;
using Cortopia.BE.Runtime.Actions.Connectors;
using Cortopia.BE.Runtime.Actions.Interfaces;
using Cortopia.BE.Runtime.Components.Senses.Hearing;
using Cortopia.BE.Runtime.Components.Senses.Hearing.Collections;
using Cortopia.BE.Runtime.Components.Senses.Sight;
using Cortopia.BE.Runtime.Components.Senses.Sight.Collections;
using Cortopia.BE.Runtime.Events;
using Cortopia.BE.Runtime.Events.ActionEvents;
using Cortopia.BE.Runtime.Nodes;
using Cortopia.BE.Runtime.Nodes.Properties;
using Cortopia.BE.Runtime.Transition;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;
using UnityEngine.Timeline;
using UnityEngine.UI;
using Viveport.Internal;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920C40", Offset = "0x920C40")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x20000DD")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000377")]
		Normal,
		[Token(Token = "0x4000378")]
		AnimatePhysics,
		[Token(Token = "0x4000379")]
		UnscaledTime
	}

	[Token(Token = "0x20000DE")]
	public enum FreezeAxis
	{
		[Token(Token = "0x400037B")]
		None,
		[Token(Token = "0x400037C")]
		X,
		[Token(Token = "0x400037D")]
		Y,
		[Token(Token = "0x400037E")]
		Z
	}

	[Token(Token = "0x20000DF")]
	private class Particle
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Damping;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Elasticity;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Stiffness;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Inert;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Radius;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_BoneLength;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 m_Position;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x10A09F8", Offset = "0x10A09F8", VA = "0x10A09F8")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_Root;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_UpdateRate;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9216D8", Offset = "0x9216D8")]
	public float m_Damping;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x9216F0", Offset = "0x9216F0")]
	public float m_Elasticity;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x921708", Offset = "0x921708")]
	public float m_Stiffness;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x921720", Offset = "0x921720")]
	public float m_Inert;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_Radius;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_EndLength;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 m_Force;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool m_DistantDisable;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float m_DistanceToObject;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 m_LocalGravity;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float m_BoneTotalLength;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float m_ObjectScale;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_Time;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float m_Weight;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool m_DistantDisabled;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Particle> m_Particles;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x109D990", Offset = "0x109D990", VA = "0x109D990")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x109DB54", Offset = "0x109DB54", VA = "0x109DB54")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x109DBA8", Offset = "0x109DBA8", VA = "0x109DBA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x109DBD8", Offset = "0x109DBD8", VA = "0x109DBD8")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x109DB84", Offset = "0x109DB84", VA = "0x109DB84")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x109DC38", Offset = "0x109DC38", VA = "0x109DC38")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x109E3FC", Offset = "0x109E3FC", VA = "0x109E3FC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x109E400", Offset = "0x109E400", VA = "0x109E400")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x109E404", Offset = "0x109E404", VA = "0x109E404")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x109E520", Offset = "0x109E520", VA = "0x109E520")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x109E718", Offset = "0x109E718", VA = "0x109E718")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x109E774", Offset = "0x109E774", VA = "0x109E774")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x109DE58", Offset = "0x109DE58", VA = "0x109DE58")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x109D994", Offset = "0x109D994", VA = "0x109D994")]
	private void SetupParticles()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x109FE14", Offset = "0x109FE14", VA = "0x109FE14")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x10A05FC", Offset = "0x10A05FC", VA = "0x10A05FC")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x109E0C8", Offset = "0x109E0C8", VA = "0x109E0C8")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x109E238", Offset = "0x109E238", VA = "0x109E238")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x109E77C", Offset = "0x109E77C", VA = "0x109E77C")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x109EB14", Offset = "0x109EB14", VA = "0x109EB14")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x109F3A0", Offset = "0x109F3A0", VA = "0x109F3A0")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x10A0AD8", Offset = "0x10A0AD8", VA = "0x10A0AD8")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x109FAA0", Offset = "0x109FAA0", VA = "0x109FAA0")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x10A0BB8", Offset = "0x10A0BB8", VA = "0x10A0BB8")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x2000003")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920C78", Offset = "0x920C78")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_Height;

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x10A0CD8", Offset = "0x10A0CD8", VA = "0x10A0CD8")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x10A0D70", Offset = "0x10A0D70", VA = "0x10A0D70", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x10A0FCC", Offset = "0x10A0FCC", VA = "0x10A0FCC")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x10A1160", Offset = "0x10A1160", VA = "0x10A1160")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x10A1304", Offset = "0x10A1304", VA = "0x10A1304")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x10A1740", Offset = "0x10A1740", VA = "0x10A1740")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x10A1B50", Offset = "0x10A1B50", VA = "0x10A1B50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x10A1D3C", Offset = "0x10A1D3C", VA = "0x10A1D3C")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x2000004")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x20000E0")]
	public enum Direction
	{
		[Token(Token = "0x400038D")]
		X,
		[Token(Token = "0x400038E")]
		Y,
		[Token(Token = "0x400038F")]
		Z
	}

	[Token(Token = "0x20000E1")]
	public enum Bound
	{
		[Token(Token = "0x4000391")]
		Outside,
		[Token(Token = "0x4000392")]
		Inside
	}

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Direction m_Direction;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 m_Center;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Bound m_Bound;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x10A1DC8", Offset = "0x10A1DC8", VA = "0x10A1DC8", Slot = "4")]
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x10A1D48", Offset = "0x10A1D48", VA = "0x10A1D48")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920CB0", Offset = "0x920CB0")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x10A1DCC", Offset = "0x10A1DCC", VA = "0x10A1DCC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x10A1DD0", Offset = "0x10A1DD0", VA = "0x10A1DD0", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x10A2000", Offset = "0x10A2000", VA = "0x10A2000")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x10A2214", Offset = "0x10A2214", VA = "0x10A2214")]
	public DynamicBonePlaneCollider()
	{
	}
}
namespace PublicKeyConvert
{
	[Token(Token = "0x2000006")]
	public class PEMKeyLoader
	{
		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static byte[] SeqOID;

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1CB48E4", Offset = "0x1CB48E4", VA = "0x1CB48E4")]
		private static bool CompareBytearrays(byte[] a, byte[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1CB49B0", Offset = "0x1CB49B0", VA = "0x1CB49B0")]
		public static RSACryptoServiceProvider CryptoServiceProviderFromPublicKeyInfo(byte[] x509key)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1CB4EF0", Offset = "0x1CB4EF0", VA = "0x1CB4EF0")]
		public static RSACryptoServiceProvider CryptoServiceProviderFromPublicKeyInfo(string base64EncodedKey)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1CB5000", Offset = "0x1CB5000", VA = "0x1CB5000")]
		public PEMKeyLoader()
		{
		}
	}
}
namespace Viveport
{
	[Token(Token = "0x2000007")]
	public class MainThreadDispatcher : MonoBehaviour
	{
		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9210F8", Offset = "0x9210F8")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000393")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MainThreadDispatcher <>4__this;

			[Token(Token = "0x4000394")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public IEnumerator action;

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1CC4FDC", Offset = "0x1CC4FDC", VA = "0x1CC4FDC")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1CC5134", Offset = "0x1CC5134", VA = "0x1CC5134")]
			internal void <Enqueue>b__0()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921108", Offset = "0x921108")]
		private sealed class <ActionWrapper>d__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000395")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000396")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000397")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action action;

			[Token(Token = "0x170000A3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000727")]
				[Address(RVA = "0x1CC51D8", Offset = "0x1CC51D8", VA = "0x1CC51D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000729")]
				[Address(RVA = "0x1CC5248", Offset = "0x1CC5248", VA = "0x1CC5248", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1CC5080", Offset = "0x1CC5080", VA = "0x1CC5080")]
			[DebuggerHidden]
			public <ActionWrapper>d__12(int <>1__state)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1CC5168", Offset = "0x1CC5168", VA = "0x1CC5168", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000726")]
			[Address(RVA = "0x1CC516C", Offset = "0x1CC516C", VA = "0x1CC516C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1CC51E0", Offset = "0x1CC51E0", VA = "0x1CC51E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921118", Offset = "0x921118")]
		private sealed class <ActionWrapper>d__13<T1> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1> action;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 param1;

			[Token(Token = "0x170000A5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600072D")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600072F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600072A")]
			[DebuggerHidden]
			public <ActionWrapper>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600072B")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600072C")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600072E")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921128", Offset = "0x921128")]
		private sealed class <ActionWrapper>d__14<T1, T2> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400039C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x400039D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1, T2> action;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 param1;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 param2;

			[Token(Token = "0x170000A7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000733")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000735")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000730")]
			[DebuggerHidden]
			public <ActionWrapper>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000731")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000732")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000734")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921138", Offset = "0x921138")]
		private sealed class <ActionWrapper>d__15<T1, T2, T3> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40003A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40003A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1, T2, T3> action;

			[Token(Token = "0x40003A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 param1;

			[Token(Token = "0x40003A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 param2;

			[Token(Token = "0x40003A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T3 param3;

			[Token(Token = "0x170000A9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000739")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600073B")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000736")]
			[DebuggerHidden]
			public <ActionWrapper>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000737")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000738")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600073A")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921148", Offset = "0x921148")]
		private sealed class <ActionWrapper>d__16<T1, T2, T3, T4> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40003A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40003A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x40003A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T1, T2, T3, T4> action;

			[Token(Token = "0x40003AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T1 param1;

			[Token(Token = "0x40003AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T2 param2;

			[Token(Token = "0x40003AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T3 param3;

			[Token(Token = "0x40003AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T4 param4;

			[Token(Token = "0x170000AB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600073F")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000741")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600073C")]
			[DebuggerHidden]
			public <ActionWrapper>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x600073D")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600073E")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000740")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly Queue<Action> actions;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static MainThreadDispatcher instance;

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1CC49FC", Offset = "0x1CC49FC", VA = "0x1CC49FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1CC4B10", Offset = "0x1CC4B10", VA = "0x1CC4B10")]
		public void Update()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x1CC4CB8", Offset = "0x1CC4CB8", VA = "0x1CC4CB8")]
		public static MainThreadDispatcher Instance()
		{
			return null;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1CC4DC0", Offset = "0x1CC4DC0", VA = "0x1CC4DC0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1CC4E28", Offset = "0x1CC4E28", VA = "0x1CC4E28")]
		public void Enqueue(IEnumerator action)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1CC4FE4", Offset = "0x1CC4FE4", VA = "0x1CC4FE4")]
		public void Enqueue(Action action)
		{
		}

		[Token(Token = "0x6000032")]
		public void Enqueue<T1>(Action<T1> action, T1 param1)
		{
		}

		[Token(Token = "0x6000033")]
		public void Enqueue<T1, T2>(Action<T1, T2> action, T1 param1, T2 param2)
		{
		}

		[Token(Token = "0x6000034")]
		public void Enqueue<T1, T2, T3>(Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3)
		{
		}

		[Token(Token = "0x6000035")]
		public void Enqueue<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 param1, T2 param2, T3 param3, T4 param4)
		{
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x1CC500C", Offset = "0x1CC500C", VA = "0x1CC500C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x922410", Offset = "0x922410")]
		private IEnumerator ActionWrapper(Action action)
		{
			return null;
		}

		[Token(Token = "0x6000037")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x922474", Offset = "0x922474")]
		private IEnumerator ActionWrapper<T1>(Action<T1> action, T1 param1)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9224D8", Offset = "0x9224D8")]
		private IEnumerator ActionWrapper<T1, T2>(Action<T1, T2> action, T1 param1, T2 param2)
		{
			return null;
		}

		[Token(Token = "0x6000039")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x92253C", Offset = "0x92253C")]
		private IEnumerator ActionWrapper<T1, T2, T3>(Action<T1, T2, T3> action, T1 param1, T2 param2, T3 param3)
		{
			return null;
		}

		[Token(Token = "0x600003A")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9225A0", Offset = "0x9225A0")]
		private IEnumerator ActionWrapper<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 param1, T2 param2, T3 param3, T4 param4)
		{
			return null;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x1CC50AC", Offset = "0x1CC50AC", VA = "0x1CC50AC")]
		public MainThreadDispatcher()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public enum Locale
	{
		[Token(Token = "0x400002A")]
		US,
		[Token(Token = "0x400002B")]
		DE,
		[Token(Token = "0x400002C")]
		JP,
		[Token(Token = "0x400002D")]
		KR,
		[Token(Token = "0x400002E")]
		RU,
		[Token(Token = "0x400002F")]
		CN,
		[Token(Token = "0x4000030")]
		TW,
		[Token(Token = "0x4000031")]
		FR
	}
	[Token(Token = "0x2000009")]
	public delegate void StatusCallback(int nResult);
	[Token(Token = "0x200000A")]
	public delegate void StatusCallback2(int nResult, string message);
	[Token(Token = "0x200000B")]
	public delegate void QueryRuntimeModeCallback(int nResult, int emu);
	[Token(Token = "0x200000C")]
	public class Leaderboard
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921738", Offset = "0x921738")]
		private int <Rank>k__BackingField;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921748", Offset = "0x921748")]
		private int <Score>k__BackingField;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921758", Offset = "0x921758")]
		private string <UserName>k__BackingField;

		[Token(Token = "0x17000001")]
		public int Rank
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x1CC49E4", Offset = "0x1CC49E4", VA = "0x1CC49E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922604", Offset = "0x922604")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x1CC4834", Offset = "0x1CC4834", VA = "0x1CC4834")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922614", Offset = "0x922614")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public int Score
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x1CC49EC", Offset = "0x1CC49EC", VA = "0x1CC49EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922624", Offset = "0x922624")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x1CC483C", Offset = "0x1CC483C", VA = "0x1CC483C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922634", Offset = "0x922634")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public string UserName
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x1CC49F4", Offset = "0x1CC49F4", VA = "0x1CC49F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922644", Offset = "0x922644")]
			get
			{
				return null;
			}
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x1CC482C", Offset = "0x1CC482C", VA = "0x1CC482C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922654", Offset = "0x922654")]
			set
			{
			}
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x1CC4824", Offset = "0x1CC4824", VA = "0x1CC4824")]
		public Leaderboard()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class SubscriptionStatus
	{
		[Token(Token = "0x20000E8")]
		public enum Platform
		{
			[Token(Token = "0x40003AF")]
			Windows,
			[Token(Token = "0x40003B0")]
			Android
		}

		[Token(Token = "0x20000E9")]
		public enum TransactionType
		{
			[Token(Token = "0x40003B2")]
			Unknown,
			[Token(Token = "0x40003B3")]
			Paid,
			[Token(Token = "0x40003B4")]
			Redeem,
			[Token(Token = "0x40003B5")]
			FreeTrial
		}

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921768", Offset = "0x921768")]
		private List<Platform> <Platforms>k__BackingField;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921778", Offset = "0x921778")]
		private TransactionType <Type>k__BackingField;

		[Token(Token = "0x17000004")]
		public List<Platform> Platforms
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x1CC6504", Offset = "0x1CC6504", VA = "0x1CC6504")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922664", Offset = "0x922664")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x1CC651C", Offset = "0x1CC651C", VA = "0x1CC651C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922674", Offset = "0x922674")]
			set
			{
			}
		}

		[Token(Token = "0x17000005")]
		public TransactionType Type
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x1CC6524", Offset = "0x1CC6524", VA = "0x1CC6524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922684", Offset = "0x922684")]
			get
			{
				return default(TransactionType);
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x1CC650C", Offset = "0x1CC650C", VA = "0x1CC650C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922694", Offset = "0x922694")]
			set
			{
			}
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x1CC648C", Offset = "0x1CC648C", VA = "0x1CC648C")]
		public SubscriptionStatus()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class Api
	{
		[Token(Token = "0x20000EA")]
		public abstract class LicenseChecker
		{
			[Token(Token = "0x6000742")]
			public abstract void OnSuccess(long issueTime, long expirationTime, int latestVersion, bool updateRequired);

			[Token(Token = "0x6000743")]
			public abstract void OnFailure(int errorCode, string errorMessage);

			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1CB6380", Offset = "0x1CB6380", VA = "0x1CB6380")]
			protected LicenseChecker()
			{
			}
		}

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static readonly List<GetLicenseCallback> InternalGetLicenseCallbacks;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal static readonly List<Viveport.Internal.StatusCallback> InternalStatusCallbacks;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal static readonly List<Viveport.Internal.QueryRuntimeModeCallback> InternalQueryRunTimeCallbacks;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal static readonly List<Viveport.Internal.StatusCallback2> InternalStatusCallback2s;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		internal static readonly List<LicenseChecker> InternalLicenseCheckers;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Viveport.Internal.StatusCallback initIl2cppCallback;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Viveport.Internal.StatusCallback shutdownIl2cppCallback;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static Viveport.Internal.QueryRuntimeModeCallback queryRuntimeModeIl2cppCallback;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static readonly string VERSION;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static string _appId;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static string _appKey;

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1CB543C", Offset = "0x1CB543C", VA = "0x1CB543C")]
		public static void GetLicense(LicenseChecker checker, string appId, string appKey)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1CB533C", Offset = "0x1CB533C", VA = "0x1CB533C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x9226A4", Offset = "0x9226A4")]
		private static void InitIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1CB5B68", Offset = "0x1CB5B68", VA = "0x1CB5B68")]
		public static int Init(StatusCallback callback, string appId)
		{
			return default(int);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1CB53BC", Offset = "0x1CB53BC", VA = "0x1CB53BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922708", Offset = "0x922708")]
		private static void ShutdownIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1CB5E98", Offset = "0x1CB5E98", VA = "0x1CB5E98")]
		public static int Shutdown(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1CB60F8", Offset = "0x1CB60F8", VA = "0x1CB60F8")]
		public static string Version()
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1CB6214", Offset = "0x1CB6214", VA = "0x1CB6214")]
		public Api()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class User
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Viveport.Internal.StatusCallback isReadyIl2cppCallback;

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1CC6534", Offset = "0x1CC6534", VA = "0x1CC6534")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x92276C", Offset = "0x92276C")]
		private static void IsReadyIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1CC659C", Offset = "0x1CC659C", VA = "0x1CC659C")]
		public static int IsReady(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1CC66F4", Offset = "0x1CC66F4", VA = "0x1CC66F4")]
		public static string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1CC6728", Offset = "0x1CC6728", VA = "0x1CC6728")]
		public static string GetUserName()
		{
			return null;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1CC675C", Offset = "0x1CC675C", VA = "0x1CC675C")]
		public static string GetUserAvatarUrl()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1CC6790", Offset = "0x1CC6790", VA = "0x1CC6790")]
		public User()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class UserStats
	{
		[Token(Token = "0x20000EB")]
		public enum LeaderBoardRequestType
		{
			[Token(Token = "0x40003B7")]
			GlobalData,
			[Token(Token = "0x40003B8")]
			GlobalDataAroundUser,
			[Token(Token = "0x40003B9")]
			LocalData,
			[Token(Token = "0x40003BA")]
			LocalDataAroundUser
		}

		[Token(Token = "0x20000EC")]
		public enum LeaderBoardTimeRange
		{
			[Token(Token = "0x40003BC")]
			AllTime,
			[Token(Token = "0x40003BD")]
			Daily,
			[Token(Token = "0x40003BE")]
			Weekly,
			[Token(Token = "0x40003BF")]
			Monthly
		}

		[Token(Token = "0x20000ED")]
		public enum LeaderBoardSortMethod
		{
			[Token(Token = "0x40003C1")]
			None,
			[Token(Token = "0x40003C2")]
			Ascending,
			[Token(Token = "0x40003C3")]
			Descending
		}

		[Token(Token = "0x20000EE")]
		public enum LeaderBoardDiaplayType
		{
			[Token(Token = "0x40003C5")]
			None,
			[Token(Token = "0x40003C6")]
			Numeric,
			[Token(Token = "0x40003C7")]
			TimeSeconds,
			[Token(Token = "0x40003C8")]
			TimeMilliSeconds
		}

		[Token(Token = "0x20000EF")]
		public enum LeaderBoardScoreMethod
		{
			[Token(Token = "0x40003CA")]
			None,
			[Token(Token = "0x40003CB")]
			KeepBest,
			[Token(Token = "0x40003CC")]
			ForceUpdate
		}

		[Token(Token = "0x20000F0")]
		public enum AchievementDisplayAttribute
		{
			[Token(Token = "0x40003CE")]
			Name,
			[Token(Token = "0x40003CF")]
			Desc,
			[Token(Token = "0x40003D0")]
			Hidden
		}

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Viveport.Internal.StatusCallback isReadyIl2cppCallback;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Viveport.Internal.StatusCallback downloadStatsIl2cppCallback;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Viveport.Internal.StatusCallback uploadStatsIl2cppCallback;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Viveport.Internal.StatusCallback downloadLeaderboardScoresIl2cppCallback;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Viveport.Internal.StatusCallback uploadLeaderboardScoreIl2cppCallback;

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1CC6798", Offset = "0x1CC6798", VA = "0x1CC6798")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x9227D0", Offset = "0x9227D0")]
		private static void IsReadyIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1CC69A0", Offset = "0x1CC69A0", VA = "0x1CC69A0")]
		public static int IsReady(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1CC6800", Offset = "0x1CC6800", VA = "0x1CC6800")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922834", Offset = "0x922834")]
		private static void DownloadStatsIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1CC6AF8", Offset = "0x1CC6AF8", VA = "0x1CC6AF8")]
		public static int DownloadStats(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1CC6C50", Offset = "0x1CC6C50", VA = "0x1CC6C50")]
		public static int GetStat(string name, int defaultValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1CC6C54", Offset = "0x1CC6C54", VA = "0x1CC6C54")]
		public static float GetStat(string name, float defaultValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1CC6C58", Offset = "0x1CC6C58", VA = "0x1CC6C58")]
		public static void SetStat(string name, int value)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1CC6C5C", Offset = "0x1CC6C5C", VA = "0x1CC6C5C")]
		public static void SetStat(string name, float value)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1CC6868", Offset = "0x1CC6868", VA = "0x1CC6868")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922898", Offset = "0x922898")]
		private static void UploadStatsIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1CC6C60", Offset = "0x1CC6C60", VA = "0x1CC6C60")]
		public static int UploadStats(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1CC6DB8", Offset = "0x1CC6DB8", VA = "0x1CC6DB8")]
		public static bool GetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1CC6DBC", Offset = "0x1CC6DBC", VA = "0x1CC6DBC")]
		public static int GetAchievementUnlockTime(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1CC6DC0", Offset = "0x1CC6DC0", VA = "0x1CC6DC0")]
		public static string GetAchievementIcon(string pchName)
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1CC6DC4", Offset = "0x1CC6DC4", VA = "0x1CC6DC4")]
		public static string GetAchievementDisplayAttribute(string pchName, AchievementDisplayAttribute attr)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1CC6DC8", Offset = "0x1CC6DC8", VA = "0x1CC6DC8")]
		public static string GetAchievementDisplayAttribute(string pchName, AchievementDisplayAttribute attr, Locale locale)
		{
			return null;
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1CC6DCC", Offset = "0x1CC6DCC", VA = "0x1CC6DCC")]
		public static int SetAchievement(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1CC6DD0", Offset = "0x1CC6DD0", VA = "0x1CC6DD0")]
		public static int ClearAchievement(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1CC68D0", Offset = "0x1CC68D0", VA = "0x1CC68D0")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x9228FC", Offset = "0x9228FC")]
		private static void DownloadLeaderboardScoresIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1CC6DD4", Offset = "0x1CC6DD4", VA = "0x1CC6DD4")]
		public static int DownloadLeaderboardScores(StatusCallback callback, string pchLeaderboardName, LeaderBoardRequestType eLeaderboardDataRequest, LeaderBoardTimeRange eLeaderboardDataTimeRange, int nRangeStart, int nRangeEnd)
		{
			return default(int);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1CC6938", Offset = "0x1CC6938", VA = "0x1CC6938")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922960", Offset = "0x922960")]
		private static void UploadLeaderboardScoreIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1CC6F6C", Offset = "0x1CC6F6C", VA = "0x1CC6F6C")]
		public static int UploadLeaderboardScore(StatusCallback callback, string pchLeaderboardName, int nScore)
		{
			return default(int);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1CC70DC", Offset = "0x1CC70DC", VA = "0x1CC70DC")]
		public static Leaderboard GetLeaderboardScore(int index)
		{
			return null;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1CC70E0", Offset = "0x1CC70E0", VA = "0x1CC70E0")]
		public static int GetLeaderboardScoreCount()
		{
			return default(int);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1CC70E4", Offset = "0x1CC70E4", VA = "0x1CC70E4")]
		public static LeaderBoardSortMethod GetLeaderboardSortMethod()
		{
			return default(LeaderBoardSortMethod);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1CC70E8", Offset = "0x1CC70E8", VA = "0x1CC70E8")]
		public static LeaderBoardDiaplayType GetLeaderboardDisplayType()
		{
			return default(LeaderBoardDiaplayType);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1CC70EC", Offset = "0x1CC70EC", VA = "0x1CC70EC")]
		public UserStats()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class ArcadeLeaderboard
	{
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1CB6390", Offset = "0x1CB6390", VA = "0x1CB6390")]
		public ArcadeLeaderboard()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public class IAPurchase
	{
		[Token(Token = "0x20000F1")]
		private class IAPHandler : BaseHandler
		{
			[Token(Token = "0x40003D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IAPurchaseListener listener;

			[Token(Token = "0x6000745")]
			[Address(RVA = "0x1CB81B0", Offset = "0x1CB81B0", VA = "0x1CB81B0")]
			public IAPHandler(IAPurchaseListener cb)
			{
			}

			[Token(Token = "0x6000746")]
			[Address(RVA = "0x1CB821C", Offset = "0x1CB821C", VA = "0x1CB821C")]
			public IAPurchaseCallback getIsReadyHandler()
			{
				return null;
			}

			[Token(Token = "0x6000747")]
			[Address(RVA = "0x1CBA7D0", Offset = "0x1CBA7D0", VA = "0x1CBA7D0", Slot = "4")]
			protected override void IsReadyHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000748")]
			[Address(RVA = "0x1CB8508", Offset = "0x1CB8508", VA = "0x1CB8508")]
			public IAPurchaseCallback getRequestHandler()
			{
				return null;
			}

			[Token(Token = "0x6000749")]
			[Address(RVA = "0x1CBAD14", Offset = "0x1CBAD14", VA = "0x1CBAD14", Slot = "5")]
			protected override void RequestHandler(int code, string message)
			{
			}

			[Token(Token = "0x600074A")]
			[Address(RVA = "0x1CB8A9C", Offset = "0x1CB8A9C", VA = "0x1CB8A9C")]
			public IAPurchaseCallback getPurchaseHandler()
			{
				return null;
			}

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x1CBB258", Offset = "0x1CBB258", VA = "0x1CBB258", Slot = "6")]
			protected override void PurchaseHandler(int code, string message)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x1CB8D78", Offset = "0x1CB8D78", VA = "0x1CB8D78")]
			public IAPurchaseCallback getQueryHandler()
			{
				return null;
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x1CBB944", Offset = "0x1CBB944", VA = "0x1CBB944", Slot = "7")]
			protected override void QueryHandler(int code, string message)
			{
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x1CB9044", Offset = "0x1CB9044", VA = "0x1CB9044")]
			public IAPurchaseCallback getQueryListHandler()
			{
				return null;
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x1CBC528", Offset = "0x1CBC528", VA = "0x1CBC528", Slot = "8")]
			protected override void QueryListHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x1CB92BC", Offset = "0x1CB92BC", VA = "0x1CB92BC")]
			public IAPurchaseCallback getBalanceHandler()
			{
				return null;
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x1CBD73C", Offset = "0x1CBD73C", VA = "0x1CBD73C", Slot = "9")]
			protected override void BalanceHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000752")]
			[Address(RVA = "0x1CB958C", Offset = "0x1CB958C", VA = "0x1CB958C")]
			public IAPurchaseCallback getRequestSubscriptionHandler()
			{
				return null;
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x1CBDE2C", Offset = "0x1CBDE2C", VA = "0x1CBDE2C", Slot = "10")]
			protected override void RequestSubscriptionHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000754")]
			[Address(RVA = "0x1CB9A94", Offset = "0x1CB9A94", VA = "0x1CB9A94")]
			public IAPurchaseCallback getRequestSubscriptionWithPlanIDHandler()
			{
				return null;
			}

			[Token(Token = "0x6000755")]
			[Address(RVA = "0x1CBE354", Offset = "0x1CBE354", VA = "0x1CBE354", Slot = "11")]
			protected override void RequestSubscriptionWithPlanIDHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000756")]
			[Address(RVA = "0x1CB9D70", Offset = "0x1CB9D70", VA = "0x1CB9D70")]
			public IAPurchaseCallback getSubscribeHandler()
			{
				return null;
			}

			[Token(Token = "0x6000757")]
			[Address(RVA = "0x1CBE87C", Offset = "0x1CBE87C", VA = "0x1CBE87C", Slot = "12")]
			protected override void SubscribeHandler(int code, string message)
			{
			}

			[Token(Token = "0x6000758")]
			[Address(RVA = "0x1CBA04C", Offset = "0x1CBA04C", VA = "0x1CBA04C")]
			public IAPurchaseCallback getQuerySubscriptionHandler()
			{
				return null;
			}

			[Token(Token = "0x6000759")]
			[Address(RVA = "0x1CBF030", Offset = "0x1CBF030", VA = "0x1CBF030", Slot = "13")]
			protected override void QuerySubscriptionHandler(int code, string message)
			{
			}

			[Token(Token = "0x600075A")]
			[Address(RVA = "0x1CBA318", Offset = "0x1CBA318", VA = "0x1CBA318")]
			public IAPurchaseCallback getQuerySubscriptionListHandler()
			{
				return null;
			}

			[Token(Token = "0x600075B")]
			[Address(RVA = "0x1CBF5D8", Offset = "0x1CBF5D8", VA = "0x1CBF5D8", Slot = "14")]
			protected override void QuerySubscriptionListHandler(int code, string message)
			{
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x1CBA5A0", Offset = "0x1CBA5A0", VA = "0x1CBA5A0")]
			public IAPurchaseCallback getCancelSubscriptionHandler()
			{
				return null;
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x1CBFB78", Offset = "0x1CBFB78", VA = "0x1CBFB78", Slot = "15")]
			protected override void CancelSubscriptionHandler(int code, string message)
			{
			}
		}

		[Token(Token = "0x20000F2")]
		private abstract class BaseHandler
		{
			[Token(Token = "0x600075E")]
			protected abstract void IsReadyHandler(int code, string message);

			[Token(Token = "0x600075F")]
			protected abstract void RequestHandler(int code, string message);

			[Token(Token = "0x6000760")]
			protected abstract void PurchaseHandler(int code, string message);

			[Token(Token = "0x6000761")]
			protected abstract void QueryHandler(int code, string message);

			[Token(Token = "0x6000762")]
			protected abstract void QueryListHandler(int code, string message);

			[Token(Token = "0x6000763")]
			protected abstract void BalanceHandler(int code, string message);

			[Token(Token = "0x6000764")]
			protected abstract void RequestSubscriptionHandler(int code, string message);

			[Token(Token = "0x6000765")]
			protected abstract void RequestSubscriptionWithPlanIDHandler(int code, string message);

			[Token(Token = "0x6000766")]
			protected abstract void SubscribeHandler(int code, string message);

			[Token(Token = "0x6000767")]
			protected abstract void QuerySubscriptionHandler(int code, string message);

			[Token(Token = "0x6000768")]
			protected abstract void QuerySubscriptionListHandler(int code, string message);

			[Token(Token = "0x6000769")]
			protected abstract void CancelSubscriptionHandler(int code, string message);

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x1CBA7C8", Offset = "0x1CBA7C8", VA = "0x1CBA7C8")]
			protected BaseHandler()
			{
			}
		}

		[Token(Token = "0x20000F3")]
		public class IAPurchaseListener
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x1CBFFF0", Offset = "0x1CBFFF0", VA = "0x1CBFFF0", Slot = "4")]
			public virtual void OnSuccess(string pchCurrencyName)
			{
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x1CBFFF4", Offset = "0x1CBFFF4", VA = "0x1CBFFF4", Slot = "5")]
			public virtual void OnRequestSuccess(string pchPurchaseId)
			{
			}

			[Token(Token = "0x600076D")]
			[Address(RVA = "0x1CBFFF8", Offset = "0x1CBFFF8", VA = "0x1CBFFF8", Slot = "6")]
			public virtual void OnPurchaseSuccess(string pchPurchaseId)
			{
			}

			[Token(Token = "0x600076E")]
			[Address(RVA = "0x1CBFFFC", Offset = "0x1CBFFFC", VA = "0x1CBFFFC", Slot = "7")]
			public virtual void OnQuerySuccess(QueryResponse response)
			{
			}

			[Token(Token = "0x600076F")]
			[Address(RVA = "0x1CC0000", Offset = "0x1CC0000", VA = "0x1CC0000", Slot = "8")]
			public virtual void OnQuerySuccess(QueryListResponse response)
			{
			}

			[Token(Token = "0x6000770")]
			[Address(RVA = "0x1CC0004", Offset = "0x1CC0004", VA = "0x1CC0004", Slot = "9")]
			public virtual void OnBalanceSuccess(string pchBalance)
			{
			}

			[Token(Token = "0x6000771")]
			[Address(RVA = "0x1CC0008", Offset = "0x1CC0008", VA = "0x1CC0008", Slot = "10")]
			public virtual void OnFailure(int nCode, string pchMessage)
			{
			}

			[Token(Token = "0x6000772")]
			[Address(RVA = "0x1CC000C", Offset = "0x1CC000C", VA = "0x1CC000C", Slot = "11")]
			public virtual void OnRequestSubscriptionSuccess(string pchSubscriptionId)
			{
			}

			[Token(Token = "0x6000773")]
			[Address(RVA = "0x1CC0010", Offset = "0x1CC0010", VA = "0x1CC0010", Slot = "12")]
			public virtual void OnRequestSubscriptionWithPlanIDSuccess(string pchSubscriptionId)
			{
			}

			[Token(Token = "0x6000774")]
			[Address(RVA = "0x1CC0014", Offset = "0x1CC0014", VA = "0x1CC0014", Slot = "13")]
			public virtual void OnSubscribeSuccess(string pchSubscriptionId)
			{
			}

			[Token(Token = "0x6000775")]
			[Address(RVA = "0x1CC0018", Offset = "0x1CC0018", VA = "0x1CC0018", Slot = "14")]
			public virtual void OnQuerySubscriptionSuccess(Subscription[] subscriptionlist)
			{
			}

			[Token(Token = "0x6000776")]
			[Address(RVA = "0x1CC001C", Offset = "0x1CC001C", VA = "0x1CC001C", Slot = "15")]
			public virtual void OnQuerySubscriptionListSuccess(Subscription[] subscriptionlist)
			{
			}

			[Token(Token = "0x6000777")]
			[Address(RVA = "0x1CC0020", Offset = "0x1CC0020", VA = "0x1CC0020", Slot = "16")]
			public virtual void OnCancelSubscriptionSuccess(bool bCanceled)
			{
			}

			[Token(Token = "0x6000778")]
			[Address(RVA = "0x1CC0024", Offset = "0x1CC0024", VA = "0x1CC0024")]
			public IAPurchaseListener()
			{
			}
		}

		[Token(Token = "0x20000F4")]
		public class QueryResponse
		{
			[Token(Token = "0x40003D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922190", Offset = "0x922190")]
			private string <order_id>k__BackingField;

			[Token(Token = "0x40003D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221A0", Offset = "0x9221A0")]
			private string <purchase_id>k__BackingField;

			[Token(Token = "0x40003D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221B0", Offset = "0x9221B0")]
			private string <status>k__BackingField;

			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221C0", Offset = "0x9221C0")]
			private string <price>k__BackingField;

			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221D0", Offset = "0x9221D0")]
			private string <currency>k__BackingField;

			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221E0", Offset = "0x9221E0")]
			private long <paid_timestamp>k__BackingField;

			[Token(Token = "0x170000AD")]
			public string order_id
			{
				[Token(Token = "0x6000779")]
				[Address(RVA = "0x1CC0044", Offset = "0x1CC0044", VA = "0x1CC0044")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9246D4", Offset = "0x9246D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600077A")]
				[Address(RVA = "0x1CBC500", Offset = "0x1CBC500", VA = "0x1CBC500")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9246E4", Offset = "0x9246E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000AE")]
			public string purchase_id
			{
				[Token(Token = "0x600077B")]
				[Address(RVA = "0x1CC004C", Offset = "0x1CC004C", VA = "0x1CC004C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9246F4", Offset = "0x9246F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600077C")]
				[Address(RVA = "0x1CBC4F8", Offset = "0x1CBC4F8", VA = "0x1CBC4F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924704", Offset = "0x924704")]
				set
				{
				}
			}

			[Token(Token = "0x170000AF")]
			public string status
			{
				[Token(Token = "0x600077D")]
				[Address(RVA = "0x1CC0054", Offset = "0x1CC0054", VA = "0x1CC0054")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924714", Offset = "0x924714")]
				get
				{
					return null;
				}
				[Token(Token = "0x600077E")]
				[Address(RVA = "0x1CBC520", Offset = "0x1CBC520", VA = "0x1CBC520")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924724", Offset = "0x924724")]
				set
				{
				}
			}

			[Token(Token = "0x170000B0")]
			public string price
			{
				[Token(Token = "0x600077F")]
				[Address(RVA = "0x1CC005C", Offset = "0x1CC005C", VA = "0x1CC005C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924734", Offset = "0x924734")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000780")]
				[Address(RVA = "0x1CBC508", Offset = "0x1CBC508", VA = "0x1CBC508")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924744", Offset = "0x924744")]
				set
				{
				}
			}

			[Token(Token = "0x170000B1")]
			public string currency
			{
				[Token(Token = "0x6000781")]
				[Address(RVA = "0x1CC0064", Offset = "0x1CC0064", VA = "0x1CC0064")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924754", Offset = "0x924754")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000782")]
				[Address(RVA = "0x1CBC510", Offset = "0x1CBC510", VA = "0x1CBC510")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924764", Offset = "0x924764")]
				set
				{
				}
			}

			[Token(Token = "0x170000B2")]
			public long paid_timestamp
			{
				[Token(Token = "0x6000783")]
				[Address(RVA = "0x1CC006C", Offset = "0x1CC006C", VA = "0x1CC006C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924774", Offset = "0x924774")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000784")]
				[Address(RVA = "0x1CBC518", Offset = "0x1CBC518", VA = "0x1CBC518")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924784", Offset = "0x924784")]
				set
				{
				}
			}

			[Token(Token = "0x6000785")]
			[Address(RVA = "0x1CBC4F0", Offset = "0x1CBC4F0", VA = "0x1CBC4F0")]
			public QueryResponse()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		public class QueryResponse2
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9221F0", Offset = "0x9221F0")]
			private string <order_id>k__BackingField;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922200", Offset = "0x922200")]
			private string <app_id>k__BackingField;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922210", Offset = "0x922210")]
			private string <purchase_id>k__BackingField;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922220", Offset = "0x922220")]
			private string <user_data>k__BackingField;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922230", Offset = "0x922230")]
			private string <price>k__BackingField;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922240", Offset = "0x922240")]
			private string <currency>k__BackingField;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922250", Offset = "0x922250")]
			private long <paid_timestamp>k__BackingField;

			[Token(Token = "0x170000B3")]
			public string order_id
			{
				[Token(Token = "0x6000786")]
				[Address(RVA = "0x1CC0074", Offset = "0x1CC0074", VA = "0x1CC0074")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924794", Offset = "0x924794")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000787")]
				[Address(RVA = "0x1CBD6FC", Offset = "0x1CBD6FC", VA = "0x1CBD6FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247A4", Offset = "0x9247A4")]
				set
				{
				}
			}

			[Token(Token = "0x170000B4")]
			public string app_id
			{
				[Token(Token = "0x6000788")]
				[Address(RVA = "0x1CC007C", Offset = "0x1CC007C", VA = "0x1CC007C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247B4", Offset = "0x9247B4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000789")]
				[Address(RVA = "0x1CBD6E4", Offset = "0x1CBD6E4", VA = "0x1CBD6E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247C4", Offset = "0x9247C4")]
				set
				{
				}
			}

			[Token(Token = "0x170000B5")]
			public string purchase_id
			{
				[Token(Token = "0x600078A")]
				[Address(RVA = "0x1CC0084", Offset = "0x1CC0084", VA = "0x1CC0084")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247D4", Offset = "0x9247D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600078B")]
				[Address(RVA = "0x1CBD6F4", Offset = "0x1CBD6F4", VA = "0x1CBD6F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247E4", Offset = "0x9247E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000B6")]
			public string user_data
			{
				[Token(Token = "0x600078C")]
				[Address(RVA = "0x1CC008C", Offset = "0x1CC008C", VA = "0x1CC008C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9247F4", Offset = "0x9247F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600078D")]
				[Address(RVA = "0x1CBD70C", Offset = "0x1CBD70C", VA = "0x1CBD70C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924804", Offset = "0x924804")]
				set
				{
				}
			}

			[Token(Token = "0x170000B7")]
			public string price
			{
				[Token(Token = "0x600078E")]
				[Address(RVA = "0x1CC0094", Offset = "0x1CC0094", VA = "0x1CC0094")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924814", Offset = "0x924814")]
				get
				{
					return null;
				}
				[Token(Token = "0x600078F")]
				[Address(RVA = "0x1CBD704", Offset = "0x1CBD704", VA = "0x1CBD704")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924824", Offset = "0x924824")]
				set
				{
				}
			}

			[Token(Token = "0x170000B8")]
			public string currency
			{
				[Token(Token = "0x6000790")]
				[Address(RVA = "0x1CC009C", Offset = "0x1CC009C", VA = "0x1CC009C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924834", Offset = "0x924834")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000791")]
				[Address(RVA = "0x1CBD6EC", Offset = "0x1CBD6EC", VA = "0x1CBD6EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924844", Offset = "0x924844")]
				set
				{
				}
			}

			[Token(Token = "0x170000B9")]
			public long paid_timestamp
			{
				[Token(Token = "0x6000792")]
				[Address(RVA = "0x1CC00A4", Offset = "0x1CC00A4", VA = "0x1CC00A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924854", Offset = "0x924854")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x6000793")]
				[Address(RVA = "0x1CBD714", Offset = "0x1CBD714", VA = "0x1CBD714")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924864", Offset = "0x924864")]
				set
				{
				}
			}

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x1CBD6DC", Offset = "0x1CBD6DC", VA = "0x1CBD6DC")]
			public QueryResponse2()
			{
			}
		}

		[Token(Token = "0x20000F6")]
		public class QueryListResponse
		{
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922260", Offset = "0x922260")]
			private int <total>k__BackingField;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922270", Offset = "0x922270")]
			private int <from>k__BackingField;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922280", Offset = "0x922280")]
			private int <to>k__BackingField;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<QueryResponse2> purchaseList;

			[Token(Token = "0x170000BA")]
			public int total
			{
				[Token(Token = "0x6000795")]
				[Address(RVA = "0x1CC002C", Offset = "0x1CC002C", VA = "0x1CC002C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924874", Offset = "0x924874")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000796")]
				[Address(RVA = "0x1CBD724", Offset = "0x1CBD724", VA = "0x1CBD724")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924884", Offset = "0x924884")]
				set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			public int from
			{
				[Token(Token = "0x6000797")]
				[Address(RVA = "0x1CC0034", Offset = "0x1CC0034", VA = "0x1CC0034")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924894", Offset = "0x924894")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6000798")]
				[Address(RVA = "0x1CBD72C", Offset = "0x1CBD72C", VA = "0x1CBD72C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248A4", Offset = "0x9248A4")]
				set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			public int to
			{
				[Token(Token = "0x6000799")]
				[Address(RVA = "0x1CC003C", Offset = "0x1CC003C", VA = "0x1CC003C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248B4", Offset = "0x9248B4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600079A")]
				[Address(RVA = "0x1CBD734", Offset = "0x1CBD734", VA = "0x1CBD734")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248C4", Offset = "0x9248C4")]
				set
				{
				}
			}

			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1CBD71C", Offset = "0x1CBD71C", VA = "0x1CBD71C")]
			public QueryListResponse()
			{
			}
		}

		[Token(Token = "0x20000F7")]
		public class StatusDetailTransaction
		{
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922290", Offset = "0x922290")]
			private long <create_time>k__BackingField;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222A0", Offset = "0x9222A0")]
			private string <payment_method>k__BackingField;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222B0", Offset = "0x9222B0")]
			private string <status>k__BackingField;

			[Token(Token = "0x170000BD")]
			public long create_time
			{
				[Token(Token = "0x600079C")]
				[Address(RVA = "0x1CC0114", Offset = "0x1CC0114", VA = "0x1CC0114")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248D4", Offset = "0x9248D4")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x600079D")]
				[Address(RVA = "0x1CC011C", Offset = "0x1CC011C", VA = "0x1CC011C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248E4", Offset = "0x9248E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000BE")]
			public string payment_method
			{
				[Token(Token = "0x600079E")]
				[Address(RVA = "0x1CC0124", Offset = "0x1CC0124", VA = "0x1CC0124")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9248F4", Offset = "0x9248F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x600079F")]
				[Address(RVA = "0x1CC012C", Offset = "0x1CC012C", VA = "0x1CC012C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924904", Offset = "0x924904")]
				set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			public string status
			{
				[Token(Token = "0x60007A0")]
				[Address(RVA = "0x1CC0134", Offset = "0x1CC0134", VA = "0x1CC0134")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924914", Offset = "0x924914")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A1")]
				[Address(RVA = "0x1CC013C", Offset = "0x1CC013C", VA = "0x1CC013C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924924", Offset = "0x924924")]
				set
				{
				}
			}

			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x1CC0144", Offset = "0x1CC0144", VA = "0x1CC0144")]
			public StatusDetailTransaction()
			{
			}
		}

		[Token(Token = "0x20000F8")]
		public class StatusDetail
		{
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222C0", Offset = "0x9222C0")]
			private long <date_next_charge>k__BackingField;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222D0", Offset = "0x9222D0")]
			private StatusDetailTransaction[] <transactions>k__BackingField;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222E0", Offset = "0x9222E0")]
			private string <cancel_reason>k__BackingField;

			[Token(Token = "0x170000C0")]
			public long date_next_charge
			{
				[Token(Token = "0x60007A3")]
				[Address(RVA = "0x1CC00DC", Offset = "0x1CC00DC", VA = "0x1CC00DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924934", Offset = "0x924934")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60007A4")]
				[Address(RVA = "0x1CC00E4", Offset = "0x1CC00E4", VA = "0x1CC00E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924944", Offset = "0x924944")]
				set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			public StatusDetailTransaction[] transactions
			{
				[Token(Token = "0x60007A5")]
				[Address(RVA = "0x1CC00EC", Offset = "0x1CC00EC", VA = "0x1CC00EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924954", Offset = "0x924954")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A6")]
				[Address(RVA = "0x1CC00F4", Offset = "0x1CC00F4", VA = "0x1CC00F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924964", Offset = "0x924964")]
				set
				{
				}
			}

			[Token(Token = "0x170000C2")]
			public string cancel_reason
			{
				[Token(Token = "0x60007A7")]
				[Address(RVA = "0x1CC00FC", Offset = "0x1CC00FC", VA = "0x1CC00FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924974", Offset = "0x924974")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007A8")]
				[Address(RVA = "0x1CC0104", Offset = "0x1CC0104", VA = "0x1CC0104")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924984", Offset = "0x924984")]
				set
				{
				}
			}

			[Token(Token = "0x60007A9")]
			[Address(RVA = "0x1CC010C", Offset = "0x1CC010C", VA = "0x1CC010C")]
			public StatusDetail()
			{
			}
		}

		[Token(Token = "0x20000F9")]
		public class TimePeriod
		{
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9222F0", Offset = "0x9222F0")]
			private string <time_type>k__BackingField;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922300", Offset = "0x922300")]
			private int <value>k__BackingField;

			[Token(Token = "0x170000C3")]
			public string time_type
			{
				[Token(Token = "0x60007AA")]
				[Address(RVA = "0x1CC0224", Offset = "0x1CC0224", VA = "0x1CC0224")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924994", Offset = "0x924994")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007AB")]
				[Address(RVA = "0x1CC022C", Offset = "0x1CC022C", VA = "0x1CC022C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249A4", Offset = "0x9249A4")]
				set
				{
				}
			}

			[Token(Token = "0x170000C4")]
			public int value
			{
				[Token(Token = "0x60007AC")]
				[Address(RVA = "0x1CC0234", Offset = "0x1CC0234", VA = "0x1CC0234")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249B4", Offset = "0x9249B4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60007AD")]
				[Address(RVA = "0x1CC023C", Offset = "0x1CC023C", VA = "0x1CC023C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249C4", Offset = "0x9249C4")]
				set
				{
				}
			}

			[Token(Token = "0x60007AE")]
			[Address(RVA = "0x1CC0244", Offset = "0x1CC0244", VA = "0x1CC0244")]
			public TimePeriod()
			{
			}
		}

		[Token(Token = "0x20000FA")]
		public class Subscription
		{
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922310", Offset = "0x922310")]
			private string <app_id>k__BackingField;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922320", Offset = "0x922320")]
			private string <order_id>k__BackingField;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922330", Offset = "0x922330")]
			private string <subscription_id>k__BackingField;

			[Token(Token = "0x40003EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922340", Offset = "0x922340")]
			private string <price>k__BackingField;

			[Token(Token = "0x40003EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922350", Offset = "0x922350")]
			private string <currency>k__BackingField;

			[Token(Token = "0x40003F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922360", Offset = "0x922360")]
			private long <subscribed_timestamp>k__BackingField;

			[Token(Token = "0x40003F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922370", Offset = "0x922370")]
			private TimePeriod <free_trial_period>k__BackingField;

			[Token(Token = "0x40003F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922380", Offset = "0x922380")]
			private TimePeriod <charge_period>k__BackingField;

			[Token(Token = "0x40003F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922390", Offset = "0x922390")]
			private int <number_of_charge_period>k__BackingField;

			[Token(Token = "0x40003F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223A0", Offset = "0x9223A0")]
			private string <plan_id>k__BackingField;

			[Token(Token = "0x40003F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223B0", Offset = "0x9223B0")]
			private string <plan_name>k__BackingField;

			[Token(Token = "0x40003F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223C0", Offset = "0x9223C0")]
			private string <status>k__BackingField;

			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223D0", Offset = "0x9223D0")]
			private StatusDetail <status_detail>k__BackingField;

			[Token(Token = "0x170000C5")]
			public string app_id
			{
				[Token(Token = "0x60007AF")]
				[Address(RVA = "0x1CC014C", Offset = "0x1CC014C", VA = "0x1CC014C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249D4", Offset = "0x9249D4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007B0")]
				[Address(RVA = "0x1CC0154", Offset = "0x1CC0154", VA = "0x1CC0154")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249E4", Offset = "0x9249E4")]
				set
				{
				}
			}

			[Token(Token = "0x170000C6")]
			public string order_id
			{
				[Token(Token = "0x60007B1")]
				[Address(RVA = "0x1CC015C", Offset = "0x1CC015C", VA = "0x1CC015C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9249F4", Offset = "0x9249F4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007B2")]
				[Address(RVA = "0x1CC0164", Offset = "0x1CC0164", VA = "0x1CC0164")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A04", Offset = "0x924A04")]
				set
				{
				}
			}

			[Token(Token = "0x170000C7")]
			public string subscription_id
			{
				[Token(Token = "0x60007B3")]
				[Address(RVA = "0x1CC016C", Offset = "0x1CC016C", VA = "0x1CC016C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A14", Offset = "0x924A14")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007B4")]
				[Address(RVA = "0x1CC0174", Offset = "0x1CC0174", VA = "0x1CC0174")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A24", Offset = "0x924A24")]
				set
				{
				}
			}

			[Token(Token = "0x170000C8")]
			public string price
			{
				[Token(Token = "0x60007B5")]
				[Address(RVA = "0x1CC017C", Offset = "0x1CC017C", VA = "0x1CC017C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A34", Offset = "0x924A34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007B6")]
				[Address(RVA = "0x1CC0184", Offset = "0x1CC0184", VA = "0x1CC0184")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A44", Offset = "0x924A44")]
				set
				{
				}
			}

			[Token(Token = "0x170000C9")]
			public string currency
			{
				[Token(Token = "0x60007B7")]
				[Address(RVA = "0x1CC018C", Offset = "0x1CC018C", VA = "0x1CC018C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A54", Offset = "0x924A54")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007B8")]
				[Address(RVA = "0x1CC0194", Offset = "0x1CC0194", VA = "0x1CC0194")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A64", Offset = "0x924A64")]
				set
				{
				}
			}

			[Token(Token = "0x170000CA")]
			public long subscribed_timestamp
			{
				[Token(Token = "0x60007B9")]
				[Address(RVA = "0x1CC019C", Offset = "0x1CC019C", VA = "0x1CC019C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A74", Offset = "0x924A74")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x60007BA")]
				[Address(RVA = "0x1CC01A4", Offset = "0x1CC01A4", VA = "0x1CC01A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A84", Offset = "0x924A84")]
				set
				{
				}
			}

			[Token(Token = "0x170000CB")]
			public TimePeriod free_trial_period
			{
				[Token(Token = "0x60007BB")]
				[Address(RVA = "0x1CC01AC", Offset = "0x1CC01AC", VA = "0x1CC01AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924A94", Offset = "0x924A94")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007BC")]
				[Address(RVA = "0x1CC01B4", Offset = "0x1CC01B4", VA = "0x1CC01B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AA4", Offset = "0x924AA4")]
				set
				{
				}
			}

			[Token(Token = "0x170000CC")]
			public TimePeriod charge_period
			{
				[Token(Token = "0x60007BD")]
				[Address(RVA = "0x1CC01BC", Offset = "0x1CC01BC", VA = "0x1CC01BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AB4", Offset = "0x924AB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007BE")]
				[Address(RVA = "0x1CC01C4", Offset = "0x1CC01C4", VA = "0x1CC01C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AC4", Offset = "0x924AC4")]
				set
				{
				}
			}

			[Token(Token = "0x170000CD")]
			public int number_of_charge_period
			{
				[Token(Token = "0x60007BF")]
				[Address(RVA = "0x1CC01CC", Offset = "0x1CC01CC", VA = "0x1CC01CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AD4", Offset = "0x924AD4")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60007C0")]
				[Address(RVA = "0x1CC01D4", Offset = "0x1CC01D4", VA = "0x1CC01D4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AE4", Offset = "0x924AE4")]
				set
				{
				}
			}

			[Token(Token = "0x170000CE")]
			public string plan_id
			{
				[Token(Token = "0x60007C1")]
				[Address(RVA = "0x1CC01DC", Offset = "0x1CC01DC", VA = "0x1CC01DC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924AF4", Offset = "0x924AF4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007C2")]
				[Address(RVA = "0x1CC01E4", Offset = "0x1CC01E4", VA = "0x1CC01E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B04", Offset = "0x924B04")]
				set
				{
				}
			}

			[Token(Token = "0x170000CF")]
			public string plan_name
			{
				[Token(Token = "0x60007C3")]
				[Address(RVA = "0x1CC01EC", Offset = "0x1CC01EC", VA = "0x1CC01EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B14", Offset = "0x924B14")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007C4")]
				[Address(RVA = "0x1CC01F4", Offset = "0x1CC01F4", VA = "0x1CC01F4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B24", Offset = "0x924B24")]
				set
				{
				}
			}

			[Token(Token = "0x170000D0")]
			public string status
			{
				[Token(Token = "0x60007C5")]
				[Address(RVA = "0x1CC01FC", Offset = "0x1CC01FC", VA = "0x1CC01FC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B34", Offset = "0x924B34")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007C6")]
				[Address(RVA = "0x1CC0204", Offset = "0x1CC0204", VA = "0x1CC0204")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B44", Offset = "0x924B44")]
				set
				{
				}
			}

			[Token(Token = "0x170000D1")]
			public StatusDetail status_detail
			{
				[Token(Token = "0x60007C7")]
				[Address(RVA = "0x1CC020C", Offset = "0x1CC020C", VA = "0x1CC020C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B54", Offset = "0x924B54")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007C8")]
				[Address(RVA = "0x1CC0214", Offset = "0x1CC0214", VA = "0x1CC0214")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B64", Offset = "0x924B64")]
				set
				{
				}
			}

			[Token(Token = "0x60007C9")]
			[Address(RVA = "0x1CC021C", Offset = "0x1CC021C", VA = "0x1CC021C")]
			public Subscription()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		public class QuerySubscritionResponse
		{
			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223E0", Offset = "0x9223E0")]
			private int <statusCode>k__BackingField;

			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9223F0", Offset = "0x9223F0")]
			private string <message>k__BackingField;

			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922400", Offset = "0x922400")]
			private List<Subscription> <subscriptions>k__BackingField;

			[Token(Token = "0x170000D2")]
			public int statusCode
			{
				[Token(Token = "0x60007CA")]
				[Address(RVA = "0x1CC00AC", Offset = "0x1CC00AC", VA = "0x1CC00AC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B74", Offset = "0x924B74")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60007CB")]
				[Address(RVA = "0x1CC00B4", Offset = "0x1CC00B4", VA = "0x1CC00B4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B84", Offset = "0x924B84")]
				set
				{
				}
			}

			[Token(Token = "0x170000D3")]
			public string message
			{
				[Token(Token = "0x60007CC")]
				[Address(RVA = "0x1CC00BC", Offset = "0x1CC00BC", VA = "0x1CC00BC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924B94", Offset = "0x924B94")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007CD")]
				[Address(RVA = "0x1CC00C4", Offset = "0x1CC00C4", VA = "0x1CC00C4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924BA4", Offset = "0x924BA4")]
				set
				{
				}
			}

			[Token(Token = "0x170000D4")]
			public List<Subscription> subscriptions
			{
				[Token(Token = "0x60007CE")]
				[Address(RVA = "0x1CBF5D0", Offset = "0x1CBF5D0", VA = "0x1CBF5D0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924BB4", Offset = "0x924BB4")]
				get
				{
					return null;
				}
				[Token(Token = "0x60007CF")]
				[Address(RVA = "0x1CC00CC", Offset = "0x1CC00CC", VA = "0x1CC00CC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924BC4", Offset = "0x924BC4")]
				set
				{
				}
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1CC00D4", Offset = "0x1CC00D4", VA = "0x1CC00D4")]
			public QuerySubscritionResponse()
			{
			}
		}

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IAPurchaseCallback isReadyIl2cppCallback;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IAPurchaseCallback request01Il2cppCallback;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IAPurchaseCallback request02Il2cppCallback;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IAPurchaseCallback purchaseIl2cppCallback;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IAPurchaseCallback query01Il2cppCallback;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IAPurchaseCallback query02Il2cppCallback;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static IAPurchaseCallback getBalanceIl2cppCallback;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static IAPurchaseCallback requestSubscriptionIl2cppCallback;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static IAPurchaseCallback requestSubscriptionWithPlanIDIl2cppCallback;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static IAPurchaseCallback subscribeIl2cppCallback;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static IAPurchaseCallback querySubscriptionIl2cppCallback;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static IAPurchaseCallback querySubscriptionListIl2cppCallback;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static IAPurchaseCallback cancelSubscriptionIl2cppCallback;

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1CB7674", Offset = "0x1CB7674", VA = "0x1CB7674")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x9229C4", Offset = "0x9229C4")]
		private static void IsReadyIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1CB80F4", Offset = "0x1CB80F4", VA = "0x1CB80F4")]
		public static void IsReady(IAPurchaseListener listener, string pchAppKey)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1CB76EC", Offset = "0x1CB76EC", VA = "0x1CB76EC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922A28", Offset = "0x922A28")]
		private static void Request01Il2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1CB844C", Offset = "0x1CB844C", VA = "0x1CB844C")]
		public static void Request(IAPurchaseListener listener, string pchPrice)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1CB7764", Offset = "0x1CB7764", VA = "0x1CB7764")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922A8C", Offset = "0x922A8C")]
		private static void Request02Il2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1CB8728", Offset = "0x1CB8728", VA = "0x1CB8728")]
		public static void Request(IAPurchaseListener listener, string pchPrice, string pchUserData)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1CB77DC", Offset = "0x1CB77DC", VA = "0x1CB77DC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922AF0", Offset = "0x922AF0")]
		private static void PurchaseIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1CB89E0", Offset = "0x1CB89E0", VA = "0x1CB89E0")]
		public static void Purchase(IAPurchaseListener listener, string pchPurchaseId)
		{
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1CB7854", Offset = "0x1CB7854", VA = "0x1CB7854")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922B54", Offset = "0x922B54")]
		private static void Query01Il2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1CB8CBC", Offset = "0x1CB8CBC", VA = "0x1CB8CBC")]
		public static void Query(IAPurchaseListener listener, string pchPurchaseId)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1CB78CC", Offset = "0x1CB78CC", VA = "0x1CB78CC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922BB8", Offset = "0x922BB8")]
		private static void Query02Il2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1CB8F98", Offset = "0x1CB8F98", VA = "0x1CB8F98")]
		public static void Query(IAPurchaseListener listener)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1CB7944", Offset = "0x1CB7944", VA = "0x1CB7944")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922C1C", Offset = "0x922C1C")]
		private static void GetBalanceIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1CB9210", Offset = "0x1CB9210", VA = "0x1CB9210")]
		public static void GetBalance(IAPurchaseListener listener)
		{
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1CB79BC", Offset = "0x1CB79BC", VA = "0x1CB79BC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922C80", Offset = "0x922C80")]
		private static void RequestSubscriptionIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1CB9488", Offset = "0x1CB9488", VA = "0x1CB9488")]
		public static void RequestSubscription(IAPurchaseListener listener, string pchPrice, string pchFreeTrialType, int nFreeTrialValue, string pchChargePeriodType, int nChargePeriodValue, int nNumberOfChargePeriod, string pchPlanId)
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1CB7A34", Offset = "0x1CB7A34", VA = "0x1CB7A34")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922CE4", Offset = "0x922CE4")]
		private static void RequestSubscriptionWithPlanIDIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1CB99D8", Offset = "0x1CB99D8", VA = "0x1CB99D8")]
		public static void RequestSubscriptionWithPlanID(IAPurchaseListener listener, string pchPlanId)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1CB7AAC", Offset = "0x1CB7AAC", VA = "0x1CB7AAC")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922D48", Offset = "0x922D48")]
		private static void SubscribeIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1CB9CB4", Offset = "0x1CB9CB4", VA = "0x1CB9CB4")]
		public static void Subscribe(IAPurchaseListener listener, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1CB7B24", Offset = "0x1CB7B24", VA = "0x1CB7B24")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922DAC", Offset = "0x922DAC")]
		private static void QuerySubscriptionIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1CB9F90", Offset = "0x1CB9F90", VA = "0x1CB9F90")]
		public static void QuerySubscription(IAPurchaseListener listener, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1CB7B9C", Offset = "0x1CB7B9C", VA = "0x1CB7B9C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922E10", Offset = "0x922E10")]
		private static void QuerySubscriptionListIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1CBA26C", Offset = "0x1CBA26C", VA = "0x1CBA26C")]
		public static void QuerySubscriptionList(IAPurchaseListener listener)
		{
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1CB7C14", Offset = "0x1CB7C14", VA = "0x1CB7C14")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922E74", Offset = "0x922E74")]
		private static void CancelSubscriptionIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x1CBA4E4", Offset = "0x1CBA4E4", VA = "0x1CBA4E4")]
		public static void CancelSubscription(IAPurchaseListener listener, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x1CBA7C0", Offset = "0x1CBA7C0", VA = "0x1CBA7C0")]
		public IAPurchase()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class DLC
	{
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x1CB6A24", Offset = "0x1CB6A24", VA = "0x1CB6A24")]
		public DLC()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class Subscription
	{
		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Viveport.Internal.StatusCallback2 isReadyIl2cppCallback;

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x1CC6178", Offset = "0x1CC6178", VA = "0x1CC6178")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922ED8", Offset = "0x922ED8")]
		private static void IsReadyIl2cppCallback(int errorCode, string message)
		{
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1CC61F0", Offset = "0x1CC61F0", VA = "0x1CC61F0")]
		public static void IsReady(StatusCallback2 callback)
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1CC6348", Offset = "0x1CC6348", VA = "0x1CC6348")]
		public static SubscriptionStatus GetUserStatus()
		{
			return null;
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1CC6514", Offset = "0x1CC6514", VA = "0x1CC6514")]
		public Subscription()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public class Deeplink
	{
		[Token(Token = "0x20000FC")]
		public abstract class DeeplinkChecker
		{
			[Token(Token = "0x60007D1")]
			public abstract void OnSuccess();

			[Token(Token = "0x60007D2")]
			public abstract void OnFailure(int errorCode, string errorMessage);

			[Token(Token = "0x60007D3")]
			[Address(RVA = "0x1CB766C", Offset = "0x1CB766C", VA = "0x1CB766C")]
			protected DeeplinkChecker()
			{
			}
		}

		[Token(Token = "0x4000056")]
		private const int MaxIdLength = 256;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Viveport.Internal.StatusCallback isReadyIl2cppCallback;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Viveport.Internal.StatusCallback2 goToAppIl2cppCallback;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Viveport.Internal.StatusCallback2 goToAppWithBranchNameIl2cppCallback;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Viveport.Internal.StatusCallback2 goToStoreIl2cppCallback;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Viveport.Internal.StatusCallback2 goToAppOrGoToStoreIl2cppCallback;

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1CB6A2C", Offset = "0x1CB6A2C", VA = "0x1CB6A2C")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x922F3C", Offset = "0x922F3C")]
		private static void IsReadyIl2cppCallback(int errorCode)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1CB6A94", Offset = "0x1CB6A94", VA = "0x1CB6A94")]
		public static void IsReady(StatusCallback callback)
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1CB6CF4", Offset = "0x1CB6CF4", VA = "0x1CB6CF4")]
		public static void GoToApp(DeeplinkChecker checker, string appId, string launchData)
		{
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x1CB6FAC", Offset = "0x1CB6FAC", VA = "0x1CB6FAC")]
		public static void GoToApp(DeeplinkChecker checker, string appId, string launchData, string branchName)
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1CB7070", Offset = "0x1CB7070", VA = "0x1CB7070")]
		public static void GoToStore(DeeplinkChecker checker, string appId = "")
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1CB72B4", Offset = "0x1CB72B4", VA = "0x1CB72B4")]
		public static void GoToAppOrGoToStore(DeeplinkChecker checker, string appId, string launchData)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1CB756C", Offset = "0x1CB756C", VA = "0x1CB756C")]
		public static string GetAppLaunchData()
		{
			return null;
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x1CB7664", Offset = "0x1CB7664", VA = "0x1CB7664")]
		public Deeplink()
		{
		}
	}
	[Token(Token = "0x2000016")]
	internal class Token
	{
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1CC652C", Offset = "0x1CC652C", VA = "0x1CC652C")]
		public Token()
		{
		}
	}
}
namespace Viveport.Internal
{
	[Token(Token = "0x2000017")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x920CE8", Offset = "0x920CE8")]
	internal delegate void GetLicenseCallback(string message, string signature);
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x920CFC", Offset = "0x920CFC")]
	internal delegate void StatusCallback(int nResult);
	[Token(Token = "0x2000019")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x920D10", Offset = "0x920D10")]
	internal delegate void StatusCallback2(int nResult, string message);
	[Token(Token = "0x200001A")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x920D24", Offset = "0x920D24")]
	internal delegate void QueryRuntimeModeCallback(int nResult, int nMode);
	[Token(Token = "0x200001B")]
	internal enum ELeaderboardDataRequest
	{
		[Token(Token = "0x400005D")]
		k_ELeaderboardDataRequestGlobal,
		[Token(Token = "0x400005E")]
		k_ELeaderboardDataRequestGlobalAroundUser,
		[Token(Token = "0x400005F")]
		k_ELeaderboardDataRequestLocal,
		[Token(Token = "0x4000060")]
		k_ELeaderboardDataRequestLocaleAroundUser
	}
	[Token(Token = "0x200001C")]
	internal enum ELeaderboardDataTimeRange
	{
		[Token(Token = "0x4000062")]
		k_ELeaderboardDataScropeAllTime,
		[Token(Token = "0x4000063")]
		k_ELeaderboardDataScropeDaily,
		[Token(Token = "0x4000064")]
		k_ELeaderboardDataScropeWeekly,
		[Token(Token = "0x4000065")]
		k_ELeaderboardDataScropeMonthly
	}
	[Token(Token = "0x200001D")]
	internal enum ELeaderboardSortMethod
	{
		[Token(Token = "0x4000067")]
		k_ELeaderboardSortMethodNone,
		[Token(Token = "0x4000068")]
		k_ELeaderboardSortMethodAscending,
		[Token(Token = "0x4000069")]
		k_ELeaderboardSortMethodDescending
	}
	[Token(Token = "0x200001E")]
	internal enum ELeaderboardDisplayType
	{
		[Token(Token = "0x400006B")]
		k_ELeaderboardDisplayTypeNone,
		[Token(Token = "0x400006C")]
		k_ELeaderboardDisplayTypeNumeric,
		[Token(Token = "0x400006D")]
		k_ELeaderboardDisplayTypeTimeSeconds,
		[Token(Token = "0x400006E")]
		k_ELeaderboardDisplayTypeTimeMilliSeconds
	}
	[Token(Token = "0x200001F")]
	internal enum ELeaderboardUploadScoreMethod
	{
		[Token(Token = "0x4000070")]
		k_ELeaderboardUploadScoreMethodNone,
		[Token(Token = "0x4000071")]
		k_ELeaderboardUploadScoreMethodKeepBest,
		[Token(Token = "0x4000072")]
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
	[Token(Token = "0x2000020")]
	internal enum ESubscriptionTransactionType
	{
		[Token(Token = "0x4000074")]
		UNKNOWN,
		[Token(Token = "0x4000075")]
		PAID,
		[Token(Token = "0x4000076")]
		REDEEM,
		[Token(Token = "0x4000077")]
		FREEE_TRIAL
	}
	[Token(Token = "0x2000021")]
	internal enum ELocale
	{
		[Token(Token = "0x4000079")]
		k_ELocaleUS,
		[Token(Token = "0x400007A")]
		k_ELocaleDE,
		[Token(Token = "0x400007B")]
		k_ELocaleJP,
		[Token(Token = "0x400007C")]
		k_ELocaleKR,
		[Token(Token = "0x400007D")]
		k_ELocaleRU,
		[Token(Token = "0x400007E")]
		k_ELocaleCN,
		[Token(Token = "0x400007F")]
		k_ELocaleTW,
		[Token(Token = "0x4000080")]
		k_ELocaleFR
	}
	[Token(Token = "0x2000022")]
	internal enum EAchievementDisplayAttribute
	{
		[Token(Token = "0x4000082")]
		k_EAchievementDisplayAttributeName,
		[Token(Token = "0x4000083")]
		k_EAchievementDisplayAttributeDesc,
		[Token(Token = "0x4000084")]
		k_EAchievementDisplayAttributeHidden
	}
	[Token(Token = "0x2000023")]
	internal struct LeaderboardEntry_t
	{
		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal int m_nGlobalRank;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		internal int m_nScore;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string m_pUserName;
	}
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "UnmanagedFunctionPointerAttribute", RVA = "0x920D38", Offset = "0x920D38")]
	internal delegate void IAPurchaseCallback(int code, string message);
	[Token(Token = "0x2000025")]
	internal struct IAPCurrency_t
	{
		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal string m_pName;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		internal string m_pSymbol;
	}
	[Token(Token = "0x2000026")]
	internal class Api
	{
		[Token(Token = "0x20000FD")]
		internal class AndroidLicenseChecker : AndroidJavaProxy
		{
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Viveport.Api.LicenseChecker checker;

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x1CC0FC8", Offset = "0x1CC0FC8", VA = "0x1CC0FC8")]
			internal AndroidLicenseChecker(Viveport.Api.LicenseChecker checker)
			{
			}

			[Token(Token = "0x60007D5")]
			[Address(RVA = "0x1CC1058", Offset = "0x1CC1058", VA = "0x1CC1058")]
			internal void onSuccess(long issueTime, long expirationTime, int latestVersion, bool updateRequired)
			{
			}

			[Token(Token = "0x60007D6")]
			[Address(RVA = "0x1CC12A4", Offset = "0x1CC12A4", VA = "0x1CC12A4")]
			internal void onFailure(int errorCode, string errorMessage)
			{
			}
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x1CB5CE8", Offset = "0x1CB5CE8", VA = "0x1CB5CE8")]
		internal static int Init(StatusCallback callback, string pchAppKey)
		{
			return default(int);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x1CB5FE8", Offset = "0x1CB5FE8", VA = "0x1CB5FE8")]
		internal static int Shutdown(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x1CB618C", Offset = "0x1CB618C", VA = "0x1CB618C")]
		internal static string Version()
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x1CB5534", Offset = "0x1CB5534", VA = "0x1CB5534")]
		internal static void GetLicense(Viveport.Api.LicenseChecker checker, string appId, string appKey)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x1CC1050", Offset = "0x1CC1050", VA = "0x1CC1050")]
		public Api()
		{
		}
	}
	[Token(Token = "0x2000027")]
	internal class User
	{
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x1CC2A40", Offset = "0x1CC2A40", VA = "0x1CC2A40")]
		internal static int IsReady(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x1CC2B9C", Offset = "0x1CC2B9C", VA = "0x1CC2B9C")]
		internal static string GetUserId()
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x1CC2C90", Offset = "0x1CC2C90", VA = "0x1CC2C90")]
		internal static string GetUserName()
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x1CC2D84", Offset = "0x1CC2D84", VA = "0x1CC2D84")]
		internal static string GetUserAvatarUrl()
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x1CC2E78", Offset = "0x1CC2E78", VA = "0x1CC2E78")]
		public User()
		{
		}
	}
	[Token(Token = "0x2000028")]
	internal class UserStats
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x1CC2E80", Offset = "0x1CC2E80", VA = "0x1CC2E80")]
		internal static int IsReady(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x1CC2FDC", Offset = "0x1CC2FDC", VA = "0x1CC2FDC")]
		internal static int DownloadStats(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x1CC3138", Offset = "0x1CC3138", VA = "0x1CC3138")]
		internal static int UploadStats(StatusCallback callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x1CC3294", Offset = "0x1CC3294", VA = "0x1CC3294")]
		internal static int SetStat(string pchName, int nData)
		{
			return default(int);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x1CC33F4", Offset = "0x1CC33F4", VA = "0x1CC33F4")]
		internal static int SetStat(string pchName, float fData)
		{
			return default(int);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x1CC355C", Offset = "0x1CC355C", VA = "0x1CC355C")]
		internal static int GetStat(string pchName, int nData)
		{
			return default(int);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x1CC36BC", Offset = "0x1CC36BC", VA = "0x1CC36BC")]
		internal static float GetStat(string pchName, float fData)
		{
			return default(float);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x1CC3824", Offset = "0x1CC3824", VA = "0x1CC3824")]
		internal static bool GetAchievement(string pchName)
		{
			return default(bool);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x1CC3910", Offset = "0x1CC3910", VA = "0x1CC3910")]
		internal static int GetAchievementUnlockTime(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x1CC39FC", Offset = "0x1CC39FC", VA = "0x1CC39FC")]
		internal static int SetAchievement(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x1CC3AE8", Offset = "0x1CC3AE8", VA = "0x1CC3AE8")]
		internal static int ClearAchievement(string pchName)
		{
			return default(int);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x1CC3BD4", Offset = "0x1CC3BD4", VA = "0x1CC3BD4")]
		internal static string GetAchievementDisplayAttribute(string pchName, EAchievementDisplayAttribute attr)
		{
			return null;
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x1CC3D34", Offset = "0x1CC3D34", VA = "0x1CC3D34")]
		internal static string GetAchievementDisplayAttribute(string pchName, EAchievementDisplayAttribute attr, ELocale locale)
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x1CC3EF4", Offset = "0x1CC3EF4", VA = "0x1CC3EF4")]
		internal static string GetAchievementIcon(string pchName)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x1CC3FE0", Offset = "0x1CC3FE0", VA = "0x1CC3FE0")]
		internal static int DownloadLeaderboardScores(StatusCallback callback, string pchLeaderboardName, ELeaderboardDataRequest nDataRequest, ELeaderboardDataTimeRange nTimeRange, int nRangeStart, int nRangeEnd)
		{
			return default(int);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x1CC4334", Offset = "0x1CC4334", VA = "0x1CC4334")]
		internal static int UploadLeaderboardScore(StatusCallback callback, string pchLeaderboardName, int nScores)
		{
			return default(int);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x1CC4558", Offset = "0x1CC4558", VA = "0x1CC4558")]
		internal static Leaderboard GetLeaderboardScore(int nIndex)
		{
			return null;
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x1CC4844", Offset = "0x1CC4844", VA = "0x1CC4844")]
		internal static int GetLeaderboardScoreCount()
		{
			return default(int);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x1CC48CC", Offset = "0x1CC48CC", VA = "0x1CC48CC")]
		internal static ELeaderboardSortMethod GetLeaderboardSortMethod()
		{
			return default(ELeaderboardSortMethod);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x1CC4954", Offset = "0x1CC4954", VA = "0x1CC4954")]
		internal static ELeaderboardDisplayType GetLeaderboardDisplayType()
		{
			return default(ELeaderboardDisplayType);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x1CC49DC", Offset = "0x1CC49DC", VA = "0x1CC49DC")]
		public UserStats()
		{
		}
	}
	[Token(Token = "0x2000029")]
	internal class Deeplink
	{
		[Token(Token = "0x20000FE")]
		internal class AndroidDeeplinkChecker : AndroidJavaProxy
		{
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Viveport.Deeplink.DeeplinkChecker checker;

			[Token(Token = "0x60007D7")]
			[Address(RVA = "0x1CC14C4", Offset = "0x1CC14C4", VA = "0x1CC14C4")]
			internal AndroidDeeplinkChecker(Viveport.Deeplink.DeeplinkChecker checker)
			{
			}

			[Token(Token = "0x60007D8")]
			[Address(RVA = "0x1CC1554", Offset = "0x1CC1554", VA = "0x1CC1554")]
			internal void onSuccess()
			{
			}

			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x1CC15E0", Offset = "0x1CC15E0", VA = "0x1CC15E0")]
			internal void onFailure(int errorCode, string errorMessage)
			{
			}
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x1CB6BEC", Offset = "0x1CB6BEC", VA = "0x1CB6BEC")]
		internal static void IsReady(StatusCallback callback)
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x1CB6DB8", Offset = "0x1CB6DB8", VA = "0x1CB6DB8")]
		internal static void GoToApp(Viveport.Deeplink.DeeplinkChecker checker, string appId, string launchData)
		{
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x1CB710C", Offset = "0x1CB710C", VA = "0x1CB710C")]
		internal static void GoToStore(Viveport.Deeplink.DeeplinkChecker checker, string appId)
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1CB7378", Offset = "0x1CB7378", VA = "0x1CB7378")]
		internal static void GoToAppOrGoToStore(Viveport.Deeplink.DeeplinkChecker checker, string appId, string launchData)
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1CB7570", Offset = "0x1CB7570", VA = "0x1CB7570")]
		internal static string GetAppLaunchData()
		{
			return null;
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1CC154C", Offset = "0x1CC154C", VA = "0x1CC154C")]
		public Deeplink()
		{
		}
	}
	[Token(Token = "0x200002A")]
	internal class IAPurchase
	{
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1CB82A4", Offset = "0x1CB82A4", VA = "0x1CB82A4")]
		internal static void IsReady(IAPurchaseCallback callback, string pchAppKey)
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x1CB8580", Offset = "0x1CB8580", VA = "0x1CB8580")]
		internal static void Request(IAPurchaseCallback callback, string pchPrice)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1CB87EC", Offset = "0x1CB87EC", VA = "0x1CB87EC")]
		internal static void Request(IAPurchaseCallback callback, string pchPrice, string pchUserData)
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x1CB8B14", Offset = "0x1CB8B14", VA = "0x1CB8B14")]
		internal static void Purchase(IAPurchaseCallback callback, string pchPurchaseId)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1CB8DF0", Offset = "0x1CB8DF0", VA = "0x1CB8DF0")]
		internal static void Query(IAPurchaseCallback callback, string pchPurchaseId)
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1CB90BC", Offset = "0x1CB90BC", VA = "0x1CB90BC")]
		internal static void Query(IAPurchaseCallback callback)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1CB9334", Offset = "0x1CB9334", VA = "0x1CB9334")]
		internal static void GetBalance(IAPurchaseCallback callback)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1CB9604", Offset = "0x1CB9604", VA = "0x1CB9604")]
		internal static void RequestSubscription(IAPurchaseCallback callback, string pchPrice, string pchFreeTrialType, int nFreeTrialValue, string pchChargePeriodType, int nChargePeriodValue, int nNumberOfChargePeriod, string pchPlanId)
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x1CB9B0C", Offset = "0x1CB9B0C", VA = "0x1CB9B0C")]
		internal static void RequestSubscriptionWithPlanID(IAPurchaseCallback callback, string pchPlanId)
		{
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1CB9DE8", Offset = "0x1CB9DE8", VA = "0x1CB9DE8")]
		internal static void Subscribe(IAPurchaseCallback callback, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x1CBA0C4", Offset = "0x1CBA0C4", VA = "0x1CBA0C4")]
		internal static void QuerySubscription(IAPurchaseCallback callback, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1CBA390", Offset = "0x1CBA390", VA = "0x1CBA390")]
		internal static void QuerySubscriptionList(IAPurchaseCallback callback)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x1CBA618", Offset = "0x1CBA618", VA = "0x1CBA618")]
		internal static void CancelSubscription(IAPurchaseCallback callback, string pchSubscriptionId)
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1CC1FCC", Offset = "0x1CC1FCC", VA = "0x1CC1FCC")]
		public IAPurchase()
		{
		}
	}
	[Token(Token = "0x200002B")]
	internal class Subscription
	{
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x1CC26E8", Offset = "0x1CC26E8", VA = "0x1CC26E8")]
		internal static int IsReady(StatusCallback2 callback)
		{
			return default(int);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x1CC2844", Offset = "0x1CC2844", VA = "0x1CC2844")]
		internal static bool IsWindowsSubscriber()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x1CC28CC", Offset = "0x1CC28CC", VA = "0x1CC28CC")]
		internal static bool IsAndroidSubscriber()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x1CC2954", Offset = "0x1CC2954", VA = "0x1CC2954")]
		internal static ESubscriptionTransactionType GetTransactionType()
		{
			return default(ESubscriptionTransactionType);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x1CC2A38", Offset = "0x1CC2A38", VA = "0x1CC2A38")]
		public Subscription()
		{
		}
	}
	[Token(Token = "0x200002C")]
	internal class Android
	{
		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static AndroidJavaObject _api;

		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static AndroidJavaObject _iAPurchase;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static AndroidJavaClass _unityPlayer;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static AndroidJavaObject _user;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static AndroidJavaObject _userStats;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static AndroidJavaObject _subscription;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static AndroidJavaObject _deeplink;

		[Token(Token = "0x17000006")]
		internal static AndroidJavaClass UnityPlayer
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x1CC0688", Offset = "0x1CC0688", VA = "0x1CC0688")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000007")]
		internal static AndroidJavaObject CurrentActivity
		{
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x1CC0718", Offset = "0x1CC0718", VA = "0x1CC0718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		internal static AndroidJavaObject CurrentContext
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x1CC0780", Offset = "0x1CC0780", VA = "0x1CC0780")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x1CC024C", Offset = "0x1CC024C", VA = "0x1CC024C")]
		internal static AndroidJavaObject GetJavaAPI()
		{
			return null;
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x1CC0304", Offset = "0x1CC0304", VA = "0x1CC0304")]
		internal static AndroidJavaObject GetJavaUser()
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x1CC03B8", Offset = "0x1CC03B8", VA = "0x1CC03B8")]
		internal static AndroidJavaObject GetJavaUserStats()
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x1CC046C", Offset = "0x1CC046C", VA = "0x1CC046C")]
		internal static AndroidJavaObject GetJavaIAPurchase()
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1CC0520", Offset = "0x1CC0520", VA = "0x1CC0520")]
		internal static AndroidJavaObject GetJavaSubscription()
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1CC05D4", Offset = "0x1CC05D4", VA = "0x1CC05D4")]
		internal static AndroidJavaObject GetDeeplink()
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1CC0784", Offset = "0x1CC0784", VA = "0x1CC0784")]
		public Android()
		{
		}
	}
	[Token(Token = "0x200002D")]
	internal class AndroidPluginCallback : AndroidJavaProxy
	{
		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IAPurchaseCallback callback;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private StatusCallback statusCallback;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private StatusCallback2 statusCallback2;

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1CC078C", Offset = "0x1CC078C", VA = "0x1CC078C")]
		internal AndroidPluginCallback(IAPurchaseCallback callback)
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x1CC0814", Offset = "0x1CC0814", VA = "0x1CC0814")]
		internal AndroidPluginCallback(StatusCallback callback)
		{
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1CC089C", Offset = "0x1CC089C", VA = "0x1CC089C")]
		internal AndroidPluginCallback(StatusCallback2 callback)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1CC0924", Offset = "0x1CC0924", VA = "0x1CC0924")]
		internal void onResult(int statusCode, string result)
		{
		}
	}
}
namespace Viveport.Arcade
{
	[Token(Token = "0x200002E")]
	internal class Session
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x1CB6388", Offset = "0x1CB6388", VA = "0x1CB6388")]
		public Session()
		{
		}
	}
}
namespace Viveport.Core
{
	[Token(Token = "0x200002F")]
	public class Logger
	{
		[Token(Token = "0x4000094")]
		private const string LoggerTypeNameUnity = "UnityEngine.Debug";

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _hasDetected;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		private static bool _usingUnityLog;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Type _unityLogType;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1CB6398", Offset = "0x1CB6398", VA = "0x1CB6398")]
		public static void Log(string message)
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1CB67AC", Offset = "0x1CB67AC", VA = "0x1CB67AC")]
		private static void ConsoleLog(string message)
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1CB6468", Offset = "0x1CB6468", VA = "0x1CB6468")]
		private static void UnityLog(string message)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1CB6848", Offset = "0x1CB6848", VA = "0x1CB6848")]
		private static Type GetType(string typeName)
		{
			return null;
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1CB69C8", Offset = "0x1CB69C8", VA = "0x1CB69C8")]
		public Logger()
		{
		}
	}
}
namespace LitJson
{
	[Token(Token = "0x2000030")]
	public enum JsonType
	{
		[Token(Token = "0x4000099")]
		None,
		[Token(Token = "0x400009A")]
		Object,
		[Token(Token = "0x400009B")]
		Array,
		[Token(Token = "0x400009C")]
		String,
		[Token(Token = "0x400009D")]
		Int,
		[Token(Token = "0x400009E")]
		Long,
		[Token(Token = "0x400009F")]
		Double,
		[Token(Token = "0x40000A0")]
		Boolean
	}
	[Token(Token = "0x2000031")]
	public interface IJsonWrapper : IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary
	{
		[Token(Token = "0x17000009")]
		bool IsArray
		{
			[Token(Token = "0x6000108")]
			get;
		}

		[Token(Token = "0x1700000A")]
		bool IsBoolean
		{
			[Token(Token = "0x6000109")]
			get;
		}

		[Token(Token = "0x1700000B")]
		bool IsDouble
		{
			[Token(Token = "0x600010A")]
			get;
		}

		[Token(Token = "0x1700000C")]
		bool IsInt
		{
			[Token(Token = "0x600010B")]
			get;
		}

		[Token(Token = "0x1700000D")]
		bool IsLong
		{
			[Token(Token = "0x600010C")]
			get;
		}

		[Token(Token = "0x1700000E")]
		bool IsObject
		{
			[Token(Token = "0x600010D")]
			get;
		}

		[Token(Token = "0x1700000F")]
		bool IsString
		{
			[Token(Token = "0x600010E")]
			get;
		}

		[Token(Token = "0x600010F")]
		bool GetBoolean();

		[Token(Token = "0x6000110")]
		double GetDouble();

		[Token(Token = "0x6000111")]
		int GetInt();

		[Token(Token = "0x6000112")]
		JsonType GetJsonType();

		[Token(Token = "0x6000113")]
		long GetLong();

		[Token(Token = "0x6000114")]
		string GetString();

		[Token(Token = "0x6000115")]
		void SetBoolean(bool val);

		[Token(Token = "0x6000116")]
		void SetDouble(double val);

		[Token(Token = "0x6000117")]
		void SetInt(int val);

		[Token(Token = "0x6000118")]
		void SetJsonType(JsonType type);

		[Token(Token = "0x6000119")]
		void SetLong(long val);

		[Token(Token = "0x600011A")]
		void SetString(string val);

		[Token(Token = "0x600011B")]
		string ToJson();

		[Token(Token = "0x600011C")]
		void ToJson(JsonWriter writer);
	}
	[Token(Token = "0x2000032")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x920D4C", Offset = "0x920D4C")]
	public class JsonData : IJsonWrapper, IList, ICollection, IEnumerable, IOrderedDictionary, IDictionary, IEquatable<JsonData>
	{
		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IList<JsonData> inst_array;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inst_boolean;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double inst_double;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int inst_int;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long inst_long;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IDictionary<string, JsonData> inst_object;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string inst_string;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string json;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private JsonType type;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IList<KeyValuePair<string, JsonData>> object_list;

		[Token(Token = "0x17000010")]
		public int Count
		{
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x11A61C4", Offset = "0x11A61C4", VA = "0x11A61C4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000011")]
		public bool IsArray
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x11A63A0", Offset = "0x11A63A0", VA = "0x11A63A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		public bool IsBoolean
		{
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x11A63B0", Offset = "0x11A63B0", VA = "0x11A63B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000013")]
		public bool IsDouble
		{
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x11A63C0", Offset = "0x11A63C0", VA = "0x11A63C0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000014")]
		public bool IsInt
		{
			[Token(Token = "0x6000121")]
			[Address(RVA = "0x11A63D0", Offset = "0x11A63D0", VA = "0x11A63D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000015")]
		public bool IsLong
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x11A63E0", Offset = "0x11A63E0", VA = "0x11A63E0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool IsObject
		{
			[Token(Token = "0x6000123")]
			[Address(RVA = "0x11A63F0", Offset = "0x11A63F0", VA = "0x11A63F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool IsString
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0x11A6400", Offset = "0x11A6400", VA = "0x11A6400")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000018")]
		private int System.Collections.ICollection.Count
		{
			[Token(Token = "0x6000125")]
			[Address(RVA = "0x11A6410", Offset = "0x11A6410", VA = "0x11A6410", Slot = "37")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000019")]
		private bool System.Collections.ICollection.IsSynchronized
		{
			[Token(Token = "0x6000126")]
			[Address(RVA = "0x11A6414", Offset = "0x11A6414", VA = "0x11A6414", Slot = "39")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.ICollection.SyncRoot
		{
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x11A64D0", Offset = "0x11A64D0", VA = "0x11A64D0", Slot = "38")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		private bool System.Collections.IDictionary.IsFixedSize
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x11A658C", Offset = "0x11A658C", VA = "0x11A658C", Slot = "54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001C")]
		private bool System.Collections.IDictionary.IsReadOnly
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x11A67BC", Offset = "0x11A67BC", VA = "0x11A67BC", Slot = "53")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		private ICollection System.Collections.IDictionary.Keys
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x11A6878", Offset = "0x11A6878", VA = "0x11A6878", Slot = "48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private ICollection System.Collections.IDictionary.Values
		{
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x11A6C44", Offset = "0x11A6C44", VA = "0x11A6C44", Slot = "49")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		private bool LitJson.IJsonWrapper.IsArray
		{
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x11A7010", Offset = "0x11A7010", VA = "0x11A7010", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		private bool LitJson.IJsonWrapper.IsBoolean
		{
			[Token(Token = "0x600012D")]
			[Address(RVA = "0x11A7020", Offset = "0x11A7020", VA = "0x11A7020", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		private bool LitJson.IJsonWrapper.IsDouble
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x11A7030", Offset = "0x11A7030", VA = "0x11A7030", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000022")]
		private bool LitJson.IJsonWrapper.IsInt
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x11A7040", Offset = "0x11A7040", VA = "0x11A7040", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		private bool LitJson.IJsonWrapper.IsLong
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0x11A7050", Offset = "0x11A7050", VA = "0x11A7050", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		private bool LitJson.IJsonWrapper.IsObject
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x11A7060", Offset = "0x11A7060", VA = "0x11A7060", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		private bool LitJson.IJsonWrapper.IsString
		{
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x11A7070", Offset = "0x11A7070", VA = "0x11A7070", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		private bool System.Collections.IList.IsFixedSize
		{
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x11A7080", Offset = "0x11A7080", VA = "0x11A7080", Slot = "31")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		private bool System.Collections.IList.IsReadOnly
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x11A7284", Offset = "0x11A7284", VA = "0x11A7284", Slot = "30")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IDictionary.Item
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x11A7340", Offset = "0x11A7340", VA = "0x11A7340", Slot = "46")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x11A7408", Offset = "0x11A7408", VA = "0x11A7408", Slot = "47")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		private object System.Collections.Specialized.IOrderedDictionary.Item
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x11A79B8", Offset = "0x11A79B8", VA = "0x11A79B8", Slot = "41")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x11A7AB0", Offset = "0x11A7AB0", VA = "0x11A7AB0", Slot = "42")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IList.Item
		{
			[Token(Token = "0x6000139")]
			[Address(RVA = "0x11A7CFC", Offset = "0x11A7CFC", VA = "0x11A7CFC", Slot = "25")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013A")]
			[Address(RVA = "0x11A7DC4", Offset = "0x11A7DC4", VA = "0x11A7DC4", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public JsonData Item
		{
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x11A80E4", Offset = "0x11A80E4", VA = "0x11A80E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x11A75D0", Offset = "0x11A75D0", VA = "0x11A75D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public JsonData Item
		{
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x11A81B0", Offset = "0x11A81B0", VA = "0x11A81B0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x11A7E08", Offset = "0x11A7E08", VA = "0x11A7E08")]
			set
			{
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x11A8334", Offset = "0x11A8334", VA = "0x11A8334")]
		public JsonData()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x11A833C", Offset = "0x11A833C", VA = "0x11A833C")]
		public JsonData(bool boolean)
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x11A8374", Offset = "0x11A8374", VA = "0x11A8374")]
		public JsonData(double number)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x11A83B0", Offset = "0x11A83B0", VA = "0x11A83B0")]
		public JsonData(int number)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x11A83E4", Offset = "0x11A83E4", VA = "0x11A83E4")]
		public JsonData(long number)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x11A8418", Offset = "0x11A8418", VA = "0x11A8418")]
		public JsonData(object obj)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x11A85F4", Offset = "0x11A85F4", VA = "0x11A85F4")]
		public JsonData(string str)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x11A8628", Offset = "0x11A8628", VA = "0x11A8628")]
		public static implicit operator JsonData(bool data)
		{
			return null;
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x11A8698", Offset = "0x11A8698", VA = "0x11A8698")]
		public static implicit operator JsonData(double data)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x11A870C", Offset = "0x11A870C", VA = "0x11A870C")]
		public static implicit operator JsonData(int data)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x11A8778", Offset = "0x11A8778", VA = "0x11A8778")]
		public static implicit operator JsonData(long data)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x11A87E4", Offset = "0x11A87E4", VA = "0x11A87E4")]
		public static implicit operator JsonData(string data)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x11A8850", Offset = "0x11A8850", VA = "0x11A8850")]
		public static explicit operator bool(JsonData data)
		{
			return default(bool);
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x11A88F0", Offset = "0x11A88F0", VA = "0x11A88F0")]
		public static explicit operator double(JsonData data)
		{
			return default(double);
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x11A8990", Offset = "0x11A8990", VA = "0x11A8990")]
		public static explicit operator int(JsonData data)
		{
			return default(int);
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x11A8A30", Offset = "0x11A8A30", VA = "0x11A8A30")]
		public static explicit operator long(JsonData data)
		{
			return default(long);
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x11A8AD0", Offset = "0x11A8AD0", VA = "0x11A8AD0")]
		public static explicit operator string(JsonData data)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x11A8B70", Offset = "0x11A8B70", VA = "0x11A8B70", Slot = "36")]
		private void System.Collections.ICollection.CopyTo(Array array, int index)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x11A8C40", Offset = "0x11A8C40", VA = "0x11A8C40", Slot = "51")]
		private void System.Collections.IDictionary.Add(object key, object value)
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x11A8E3C", Offset = "0x11A8E3C", VA = "0x11A8E3C", Slot = "52")]
		private void System.Collections.IDictionary.Clear()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x11A8F7C", Offset = "0x11A8F7C", VA = "0x11A8F7C", Slot = "50")]
		private bool System.Collections.IDictionary.Contains(object key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x11A9048", Offset = "0x11A9048", VA = "0x11A9048", Slot = "55")]
		private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x11A90F0", Offset = "0x11A90F0", VA = "0x11A90F0", Slot = "56")]
		private void System.Collections.IDictionary.Remove(object key)
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x11A9400", Offset = "0x11A9400", VA = "0x11A9400", Slot = "40")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x11A94B8", Offset = "0x11A94B8", VA = "0x11A94B8", Slot = "11")]
		private bool LitJson.IJsonWrapper.GetBoolean()
		{
			return default(bool);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x11A954C", Offset = "0x11A954C", VA = "0x11A954C", Slot = "12")]
		private double LitJson.IJsonWrapper.GetDouble()
		{
			return default(double);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x11A95E0", Offset = "0x11A95E0", VA = "0x11A95E0", Slot = "13")]
		private int LitJson.IJsonWrapper.GetInt()
		{
			return default(int);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x11A9674", Offset = "0x11A9674", VA = "0x11A9674", Slot = "15")]
		private long LitJson.IJsonWrapper.GetLong()
		{
			return default(long);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x11A9708", Offset = "0x11A9708", VA = "0x11A9708", Slot = "16")]
		private string LitJson.IJsonWrapper.GetString()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x11A979C", Offset = "0x11A979C", VA = "0x11A979C", Slot = "17")]
		private void LitJson.IJsonWrapper.SetBoolean(bool val)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x11A97B4", Offset = "0x11A97B4", VA = "0x11A97B4", Slot = "18")]
		private void LitJson.IJsonWrapper.SetDouble(double val)
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x11A97C8", Offset = "0x11A97C8", VA = "0x11A97C8", Slot = "19")]
		private void LitJson.IJsonWrapper.SetInt(int val)
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x11A97DC", Offset = "0x11A97DC", VA = "0x11A97DC", Slot = "21")]
		private void LitJson.IJsonWrapper.SetLong(long val)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x11A97F0", Offset = "0x11A97F0", VA = "0x11A97F0", Slot = "22")]
		private void LitJson.IJsonWrapper.SetString(string val)
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x11A9800", Offset = "0x11A9800", VA = "0x11A9800", Slot = "23")]
		private string LitJson.IJsonWrapper.ToJson()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x11A98C8", Offset = "0x11A98C8", VA = "0x11A98C8", Slot = "24")]
		private void LitJson.IJsonWrapper.ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x11A9940", Offset = "0x11A9940", VA = "0x11A9940", Slot = "27")]
		private int System.Collections.IList.Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x11A9A20", Offset = "0x11A9A20", VA = "0x11A9A20", Slot = "29")]
		private void System.Collections.IList.Clear()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x11A9AE4", Offset = "0x11A9AE4", VA = "0x11A9AE4", Slot = "28")]
		private bool System.Collections.IList.Contains(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x11A9BB0", Offset = "0x11A9BB0", VA = "0x11A9BB0", Slot = "32")]
		private int System.Collections.IList.IndexOf(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x11A9C7C", Offset = "0x11A9C7C", VA = "0x11A9C7C", Slot = "33")]
		private void System.Collections.IList.Insert(int index, object value)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x11A9D58", Offset = "0x11A9D58", VA = "0x11A9D58", Slot = "34")]
		private void System.Collections.IList.Remove(object value)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x11A9E2C", Offset = "0x11A9E2C", VA = "0x11A9E2C", Slot = "35")]
		private void System.Collections.IList.RemoveAt(int index)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x11A9F00", Offset = "0x11A9F00", VA = "0x11A9F00", Slot = "43")]
		private IDictionaryEnumerator System.Collections.Specialized.IOrderedDictionary.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x11A9FEC", Offset = "0x11A9FEC", VA = "0x11A9FEC", Slot = "44")]
		private void System.Collections.Specialized.IOrderedDictionary.Insert(int idx, object key, object value)
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x11AA17C", Offset = "0x11AA17C", VA = "0x11AA17C", Slot = "45")]
		private void System.Collections.Specialized.IOrderedDictionary.RemoveAt(int idx)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x11A6280", Offset = "0x11A6280", VA = "0x11A6280")]
		private ICollection EnsureCollection()
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x11A6648", Offset = "0x11A6648", VA = "0x11A6648")]
		private IDictionary EnsureDictionary()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x11A713C", Offset = "0x11A713C", VA = "0x11A713C")]
		private IList EnsureList()
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x11A7534", Offset = "0x11A7534", VA = "0x11A7534")]
		private JsonData ToJsonData(object obj)
		{
			return null;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x11AA378", Offset = "0x11AA378", VA = "0x11AA378")]
		private static void WriteJson(IJsonWrapper obj, JsonWriter writer)
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x11A9944", Offset = "0x11A9944", VA = "0x11A9944")]
		public int Add(object value)
		{
			return default(int);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x11ABA64", Offset = "0x11ABA64", VA = "0x11ABA64")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x11ABB80", Offset = "0x11ABB80", VA = "0x11ABB80", Slot = "57")]
		public bool Equals(JsonData x)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x11ABCA4", Offset = "0x11ABCA4", VA = "0x11ABCA4", Slot = "14")]
		public JsonType GetJsonType()
		{
			return default(JsonType);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x11ABCAC", Offset = "0x11ABCAC", VA = "0x11ABCAC", Slot = "20")]
		public void SetJsonType(JsonType type)
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x11A9804", Offset = "0x11A9804", VA = "0x11A9804")]
		public string ToJson()
		{
			return null;
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x11A98CC", Offset = "0x11A98CC", VA = "0x11A98CC")]
		public void ToJson(JsonWriter writer)
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x11ABE88", Offset = "0x11ABE88", VA = "0x11ABE88", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000033")]
	internal class OrderedDictionaryEnumerator : IDictionaryEnumerator, IEnumerator
	{
		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IEnumerator<KeyValuePair<string, JsonData>> list_enumerator;

		[Token(Token = "0x1700002D")]
		public object Current
		{
			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1CB3F98", Offset = "0x1CB3F98", VA = "0x1CB3F98", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		public DictionaryEntry Entry
		{
			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1CB4004", Offset = "0x1CB4004", VA = "0x1CB4004", Slot = "6")]
			get
			{
				return default(DictionaryEntry);
			}
		}

		[Token(Token = "0x1700002F")]
		public object Key
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1CB4118", Offset = "0x1CB4118", VA = "0x1CB4118", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public object Value
		{
			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1CB41F8", Offset = "0x1CB41F8", VA = "0x1CB41F8", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1CB42D8", Offset = "0x1CB42D8", VA = "0x1CB42D8")]
		public OrderedDictionaryEnumerator(IEnumerator<KeyValuePair<string, JsonData>> enumerator)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1CB4304", Offset = "0x1CB4304", VA = "0x1CB4304", Slot = "7")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1CB43B8", Offset = "0x1CB43B8", VA = "0x1CB43B8", Slot = "9")]
		public void Reset()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class JsonException : ApplicationException
	{
		[Token(Token = "0x6000181")]
		[Address(RVA = "0x11ABF68", Offset = "0x11ABF68", VA = "0x11ABF68")]
		public JsonException()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x11ABF70", Offset = "0x11ABF70", VA = "0x11ABF70")]
		internal JsonException(ParserToken token)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11AC000", Offset = "0x11AC000", VA = "0x11AC000")]
		internal JsonException(ParserToken token, Exception inner_exception)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x11AC0A0", Offset = "0x11AC0A0", VA = "0x11AC0A0")]
		internal JsonException(int c)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x11AC130", Offset = "0x11AC130", VA = "0x11AC130")]
		internal JsonException(int c, Exception inner_exception)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x11AC1D0", Offset = "0x11AC1D0", VA = "0x11AC1D0")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x11AC1D8", Offset = "0x11AC1D8", VA = "0x11AC1D8")]
		public JsonException(string message, Exception inner_exception)
		{
		}
	}
	[Token(Token = "0x2000035")]
	internal struct PropertyMetadata
	{
		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool IsField;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Type Type;
	}
	[Token(Token = "0x2000036")]
	internal struct ArrayMetadata
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool is_array;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
		private bool is_list;

		[Token(Token = "0x17000031")]
		public Type ElementType
		{
			[Token(Token = "0x6000188")]
			[Address(RVA = "0x9DE798", Offset = "0x9DE798", VA = "0x9DE798")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000189")]
			[Address(RVA = "0x9DE7A0", Offset = "0x9DE7A0", VA = "0x9DE7A0")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public bool IsArray
		{
			[Token(Token = "0x600018A")]
			[Address(RVA = "0x9DE7A8", Offset = "0x9DE7A8", VA = "0x9DE7A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018B")]
			[Address(RVA = "0x9DE7B0", Offset = "0x9DE7B0", VA = "0x9DE7B0")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public bool IsList
		{
			[Token(Token = "0x600018C")]
			[Address(RVA = "0x9DE7BC", Offset = "0x9DE7BC", VA = "0x9DE7BC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600018D")]
			[Address(RVA = "0x9DE7C4", Offset = "0x9DE7C4", VA = "0x9DE7C4")]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000037")]
	internal struct ObjectMetadata
	{
		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Type element_type;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private bool is_dictionary;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IDictionary<string, PropertyMetadata> properties;

		[Token(Token = "0x17000034")]
		public Type ElementType
		{
			[Token(Token = "0x600018E")]
			[Address(RVA = "0x9FE128", Offset = "0x9FE128", VA = "0x9FE128")]
			get
			{
				return null;
			}
			[Token(Token = "0x600018F")]
			[Address(RVA = "0x9FE130", Offset = "0x9FE130", VA = "0x9FE130")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public bool IsDictionary
		{
			[Token(Token = "0x6000190")]
			[Address(RVA = "0x9FE138", Offset = "0x9FE138", VA = "0x9FE138")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x9FE140", Offset = "0x9FE140", VA = "0x9FE140")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public IDictionary<string, PropertyMetadata> Properties
		{
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x9FE14C", Offset = "0x9FE14C", VA = "0x9FE14C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x9FE154", Offset = "0x9FE154", VA = "0x9FE154")]
			set
			{
			}
		}
	}
	[Token(Token = "0x2000038")]
	internal delegate void ExporterFunc(object obj, JsonWriter writer);
	[Token(Token = "0x2000039")]
	public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
	[Token(Token = "0x200003A")]
	internal delegate object ImporterFunc(object input);
	[Token(Token = "0x200003B")]
	public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
	[Token(Token = "0x200003C")]
	public delegate IJsonWrapper WrapperFactory();
	[Token(Token = "0x200003D")]
	public class JsonMapper
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921158", Offset = "0x921158")]
		private sealed class <>c
		{
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static ExporterFunc <>9__23_0;

			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static ExporterFunc <>9__23_1;

			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static ExporterFunc <>9__23_2;

			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static ExporterFunc <>9__23_3;

			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static ExporterFunc <>9__23_4;

			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static ExporterFunc <>9__23_5;

			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static ExporterFunc <>9__23_6;

			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static ExporterFunc <>9__23_7;

			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static ExporterFunc <>9__23_8;

			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static ExporterFunc <>9__23_9;

			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static ImporterFunc <>9__24_0;

			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static ImporterFunc <>9__24_1;

			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static ImporterFunc <>9__24_2;

			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static ImporterFunc <>9__24_3;

			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static ImporterFunc <>9__24_4;

			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static ImporterFunc <>9__24_5;

			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static ImporterFunc <>9__24_6;

			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static ImporterFunc <>9__24_7;

			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static ImporterFunc <>9__24_8;

			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static ImporterFunc <>9__24_9;

			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static ImporterFunc <>9__24_10;

			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static ImporterFunc <>9__24_11;

			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static ImporterFunc <>9__24_12;

			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static WrapperFactory <>9__29_0;

			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static WrapperFactory <>9__30_0;

			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static WrapperFactory <>9__31_0;

			[Token(Token = "0x60007DB")]
			[Address(RVA = "0x11B44B0", Offset = "0x11B44B0", VA = "0x11B44B0")]
			public <>c()
			{
			}

			[Token(Token = "0x60007DC")]
			[Address(RVA = "0x11B44B8", Offset = "0x11B44B8", VA = "0x11B44B8")]
			internal void <RegisterBaseExporters>b__23_0(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007DD")]
			[Address(RVA = "0x11B455C", Offset = "0x11B455C", VA = "0x11B455C")]
			internal void <RegisterBaseExporters>b__23_1(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007DE")]
			[Address(RVA = "0x11B4600", Offset = "0x11B4600", VA = "0x11B4600")]
			internal void <RegisterBaseExporters>b__23_2(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007DF")]
			[Address(RVA = "0x11B46D8", Offset = "0x11B46D8", VA = "0x11B46D8")]
			internal void <RegisterBaseExporters>b__23_3(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x11B4838", Offset = "0x11B4838", VA = "0x11B4838")]
			internal void <RegisterBaseExporters>b__23_4(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E1")]
			[Address(RVA = "0x11B48DC", Offset = "0x11B48DC", VA = "0x11B48DC")]
			internal void <RegisterBaseExporters>b__23_5(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x11B4980", Offset = "0x11B4980", VA = "0x11B4980")]
			internal void <RegisterBaseExporters>b__23_6(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x11B4A24", Offset = "0x11B4A24", VA = "0x11B4A24")]
			internal void <RegisterBaseExporters>b__23_7(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x11B4AC8", Offset = "0x11B4AC8", VA = "0x11B4AC8")]
			internal void <RegisterBaseExporters>b__23_8(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x11B4B3C", Offset = "0x11B4B3C", VA = "0x11B4B3C")]
			internal void <RegisterBaseExporters>b__23_9(object obj, JsonWriter writer)
			{
			}

			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x11B4BB4", Offset = "0x11B4BB4", VA = "0x11B4BB4")]
			internal object <RegisterBaseImporters>b__24_0(object input)
			{
				return null;
			}

			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x11B4C58", Offset = "0x11B4C58", VA = "0x11B4C58")]
			internal object <RegisterBaseImporters>b__24_1(object input)
			{
				return null;
			}

			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x11B4CFC", Offset = "0x11B4CFC", VA = "0x11B4CFC")]
			internal object <RegisterBaseImporters>b__24_2(object input)
			{
				return null;
			}

			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x11B4DA0", Offset = "0x11B4DA0", VA = "0x11B4DA0")]
			internal object <RegisterBaseImporters>b__24_3(object input)
			{
				return null;
			}

			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x11B4E44", Offset = "0x11B4E44", VA = "0x11B4E44")]
			internal object <RegisterBaseImporters>b__24_4(object input)
			{
				return null;
			}

			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x11B4EE8", Offset = "0x11B4EE8", VA = "0x11B4EE8")]
			internal object <RegisterBaseImporters>b__24_5(object input)
			{
				return null;
			}

			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x11B4F8C", Offset = "0x11B4F8C", VA = "0x11B4F8C")]
			internal object <RegisterBaseImporters>b__24_6(object input)
			{
				return null;
			}

			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x11B502C", Offset = "0x11B502C", VA = "0x11B502C")]
			internal object <RegisterBaseImporters>b__24_7(object input)
			{
				return null;
			}

			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x11B50D0", Offset = "0x11B50D0", VA = "0x11B50D0")]
			internal object <RegisterBaseImporters>b__24_8(object input)
			{
				return null;
			}

			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x11B5170", Offset = "0x11B5170", VA = "0x11B5170")]
			internal object <RegisterBaseImporters>b__24_9(object input)
			{
				return null;
			}

			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x11B5214", Offset = "0x11B5214", VA = "0x11B5214")]
			internal object <RegisterBaseImporters>b__24_10(object input)
			{
				return null;
			}

			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x11B52B8", Offset = "0x11B52B8", VA = "0x11B52B8")]
			internal object <RegisterBaseImporters>b__24_11(object input)
			{
				return null;
			}

			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x11B53B4", Offset = "0x11B53B4", VA = "0x11B53B4")]
			internal object <RegisterBaseImporters>b__24_12(object input)
			{
				return null;
			}

			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x11B54E4", Offset = "0x11B54E4", VA = "0x11B54E4")]
			internal IJsonWrapper <ToObject>b__29_0()
			{
				return null;
			}

			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x11B5540", Offset = "0x11B5540", VA = "0x11B5540")]
			internal IJsonWrapper <ToObject>b__30_0()
			{
				return null;
			}

			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x11B559C", Offset = "0x11B559C", VA = "0x11B559C")]
			internal IJsonWrapper <ToObject>b__31_0()
			{
				return null;
			}
		}

		[Token(Token = "0x2000100")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921168", Offset = "0x921168")]
		private sealed class <>c__DisplayClass37_0<T>
		{
			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ExporterFunc<T> exporter;

			[Token(Token = "0x60007F6")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x60007F7")]
			internal void <RegisterExporter>b__0(object obj, JsonWriter writer)
			{
			}
		}

		[Token(Token = "0x2000101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921178", Offset = "0x921178")]
		private sealed class <>c__DisplayClass38_0<TJson, TValue>
		{
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ImporterFunc<TJson, TValue> importer;

			[Token(Token = "0x60007F8")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x60007F9")]
			internal object <RegisterImporter>b__0(object input)
			{
				return null;
			}
		}

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int max_nesting_depth;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IFormatProvider datetime_format;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static IDictionary<Type, ExporterFunc> base_exporters_table;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static IDictionary<Type, ExporterFunc> custom_exporters_table;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> base_importers_table;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static IDictionary<Type, IDictionary<Type, ImporterFunc>> custom_importers_table;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static IDictionary<Type, ArrayMetadata> array_metadata;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static readonly object array_metadata_lock;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static IDictionary<Type, IDictionary<Type, MethodInfo>> conv_ops;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static readonly object conv_ops_lock;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static IDictionary<Type, ObjectMetadata> object_metadata;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static readonly object object_metadata_lock;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static IDictionary<Type, IList<PropertyMetadata>> type_properties;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static readonly object type_properties_lock;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static JsonWriter static_writer;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static readonly object static_writer_lock;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x11AC1E0", Offset = "0x11AC1E0", VA = "0x11AC1E0")]
		static JsonMapper()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11AE0AC", Offset = "0x11AE0AC", VA = "0x11AE0AC")]
		private static void AddArrayMetadata(Type type)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x11AE5B4", Offset = "0x11AE5B4", VA = "0x11AE5B4")]
		private static void AddObjectMetadata(Type type)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11AEDA0", Offset = "0x11AEDA0", VA = "0x11AEDA0")]
		private static void AddTypeProperties(Type type)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x11AF334", Offset = "0x11AF334", VA = "0x11AF334")]
		private static MethodInfo GetConvOp(Type t1, Type t2)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x11AFC44", Offset = "0x11AFC44", VA = "0x11AFC44")]
		private static object ReadValue(Type inst_type, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x11B14B0", Offset = "0x11B14B0", VA = "0x11B14B0")]
		private static IJsonWrapper ReadValue(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x11AC538", Offset = "0x11AC538", VA = "0x11AC538")]
		private static void RegisterBaseExporters()
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x11AD368", Offset = "0x11AD368", VA = "0x11AD368")]
		private static void RegisterBaseImporters()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x11B1C18", Offset = "0x11B1C18", VA = "0x11B1C18")]
		private static void RegisterImporter(IDictionary<Type, IDictionary<Type, ImporterFunc>> table, Type json_type, Type value_type, ImporterFunc importer)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x11B1E7C", Offset = "0x11B1E7C", VA = "0x11B1E7C")]
		private static void WriteValue(object obj, JsonWriter writer, bool writer_is_private, int depth)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x11B3974", Offset = "0x11B3974", VA = "0x11B3974")]
		public static string ToJson(object obj)
		{
			return null;
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x11B3BE0", Offset = "0x11B3BE0", VA = "0x11B3BE0")]
		public static void ToJson(object obj, JsonWriter writer)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x11B3C5C", Offset = "0x11B3C5C", VA = "0x11B3C5C")]
		public static JsonData ToObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x11B3E54", Offset = "0x11B3E54", VA = "0x11B3E54")]
		public static JsonData ToObject(TextReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x11B4000", Offset = "0x11B4000", VA = "0x11B4000")]
		public static JsonData ToObject(string json)
		{
			return null;
		}

		[Token(Token = "0x60001B8")]
		public static T ToObject<T>(JsonReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x60001B9")]
		public static T ToObject<T>(TextReader reader)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BA")]
		public static T ToObject<T>(string json)
		{
			return (T)null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x11B3DE0", Offset = "0x11B3DE0", VA = "0x11B3DE0")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x11B4184", Offset = "0x11B4184", VA = "0x11B4184")]
		public static IJsonWrapper ToWrapper(WrapperFactory factory, string json)
		{
			return null;
		}

		[Token(Token = "0x60001BD")]
		public static void RegisterExporter<T>(ExporterFunc<T> exporter)
		{
		}

		[Token(Token = "0x60001BE")]
		public static void RegisterImporter<TJson, TValue>(ImporterFunc<TJson, TValue> importer)
		{
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x11B428C", Offset = "0x11B428C", VA = "0x11B428C")]
		public static void UnregisterExporters()
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x11B4368", Offset = "0x11B4368", VA = "0x11B4368")]
		public static void UnregisterImporters()
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x11B4444", Offset = "0x11B4444", VA = "0x11B4444")]
		public JsonMapper()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public enum JsonToken
	{
		[Token(Token = "0x40000C6")]
		None,
		[Token(Token = "0x40000C7")]
		ObjectStart,
		[Token(Token = "0x40000C8")]
		PropertyName,
		[Token(Token = "0x40000C9")]
		ObjectEnd,
		[Token(Token = "0x40000CA")]
		ArrayStart,
		[Token(Token = "0x40000CB")]
		ArrayEnd,
		[Token(Token = "0x40000CC")]
		Int,
		[Token(Token = "0x40000CD")]
		Long,
		[Token(Token = "0x40000CE")]
		Double,
		[Token(Token = "0x40000CF")]
		String,
		[Token(Token = "0x40000D0")]
		Boolean,
		[Token(Token = "0x40000D1")]
		Null
	}
	[Token(Token = "0x200003F")]
	public class JsonReader
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IDictionary<int, IDictionary<int, int[]>> parse_table;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Stack<int> automaton_stack;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int current_input;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int current_symbol;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool end_of_json;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		private bool end_of_input;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Lexer lexer;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool parser_in_string;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool parser_return;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool read_started;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextReader reader;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool reader_is_owned;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object token_value;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private JsonToken token;

		[Token(Token = "0x17000037")]
		public bool AllowComments
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x11B55F8", Offset = "0x11B55F8", VA = "0x11B55F8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C3")]
			[Address(RVA = "0x11B5628", Offset = "0x11B5628", VA = "0x11B5628")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60001C4")]
			[Address(RVA = "0x11B5660", Offset = "0x11B5660", VA = "0x11B5660")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x11B5690", Offset = "0x11B5690", VA = "0x11B5690")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool EndOfInput
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x11B56C8", Offset = "0x11B56C8", VA = "0x11B56C8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool EndOfJson
		{
			[Token(Token = "0x60001C7")]
			[Address(RVA = "0x11B56D0", Offset = "0x11B56D0", VA = "0x11B56D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public JsonToken Token
		{
			[Token(Token = "0x60001C8")]
			[Address(RVA = "0x11B14A0", Offset = "0x11B14A0", VA = "0x11B14A0")]
			get
			{
				return default(JsonToken);
			}
		}

		[Token(Token = "0x1700003C")]
		public object Value
		{
			[Token(Token = "0x60001C9")]
			[Address(RVA = "0x11B14A8", Offset = "0x11B14A8", VA = "0x11B14A8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x11B56D8", Offset = "0x11B56D8", VA = "0x11B56D8")]
		static JsonReader()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x11B4214", Offset = "0x11B4214", VA = "0x11B4214")]
		public JsonReader(string json_text)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x11B3FF8", Offset = "0x11B3FF8", VA = "0x11B3FF8")]
		public JsonReader(TextReader reader)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x11B5ED0", Offset = "0x11B5ED0", VA = "0x11B5ED0")]
		private JsonReader(TextReader reader, bool owned)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x11B56DC", Offset = "0x11B56DC", VA = "0x11B56DC")]
		private static void PopulateParseTable()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11B6144", Offset = "0x11B6144", VA = "0x11B6144")]
		private static void TableAddCol(ParserToken row, int col, params int[] symbols)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x11B6030", Offset = "0x11B6030", VA = "0x11B6030")]
		private static void TableAddRow(ParserToken rule)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x11B62B4", Offset = "0x11B62B4", VA = "0x11B62B4")]
		private void ProcessNumber(string number)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x11B6450", Offset = "0x11B6450", VA = "0x11B6450")]
		private void ProcessSymbol()
		{
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x11B6614", Offset = "0x11B6614", VA = "0x11B6614")]
		private bool ReadToken()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x11B66A8", Offset = "0x11B66A8", VA = "0x11B66A8")]
		public void Close()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x11B0FF4", Offset = "0x11B0FF4", VA = "0x11B0FF4")]
		public bool Read()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000040")]
	internal enum Condition
	{
		[Token(Token = "0x40000E1")]
		InArray,
		[Token(Token = "0x40000E2")]
		InObject,
		[Token(Token = "0x40000E3")]
		NotAProperty,
		[Token(Token = "0x40000E4")]
		Property,
		[Token(Token = "0x40000E5")]
		Value
	}
	[Token(Token = "0x2000041")]
	internal class WriterContext
	{
		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int Count;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool InArray;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
		public bool InObject;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
		public bool ExpectingValue;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Padding;

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1CB48DC", Offset = "0x1CB48DC", VA = "0x1CB48DC")]
		public WriterContext()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class JsonWriter
	{
		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static NumberFormatInfo number_format;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private WriterContext context;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Stack<WriterContext> ctx_stack;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool has_reached_end;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private char[] hex_seq;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int indentation;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int indent_value;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StringBuilder inst_string_builder;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool pretty_print;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool validate;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private TextWriter writer;

		[Token(Token = "0x1700003D")]
		public int IndentValue
		{
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x11B6700", Offset = "0x11B6700", VA = "0x11B6700")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60001D8")]
			[Address(RVA = "0x11B6708", Offset = "0x11B6708", VA = "0x11B6708")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool PrettyPrint
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x11B671C", Offset = "0x11B671C", VA = "0x11B671C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DA")]
			[Address(RVA = "0x11B6724", Offset = "0x11B6724", VA = "0x11B6724")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public TextWriter TextWriter
		{
			[Token(Token = "0x60001DB")]
			[Address(RVA = "0x11B3888", Offset = "0x11B3888", VA = "0x11B3888")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public bool Validate
		{
			[Token(Token = "0x60001DC")]
			[Address(RVA = "0x11ABE80", Offset = "0x11ABE80", VA = "0x11ABE80")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001DD")]
			[Address(RVA = "0x11ABE74", Offset = "0x11ABE74", VA = "0x11ABE74")]
			set
			{
			}
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x11B6730", Offset = "0x11B6730", VA = "0x11B6730")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x11AC49C", Offset = "0x11AC49C", VA = "0x11AC49C")]
		public JsonWriter()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x11B6864", Offset = "0x11B6864", VA = "0x11B6864")]
		public JsonWriter(StringBuilder sb)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x11ABDCC", Offset = "0x11ABDCC", VA = "0x11ABDCC")]
		public JsonWriter(TextWriter writer)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x11B68D8", Offset = "0x11B68D8", VA = "0x11B68D8")]
		private void DoValidation(Condition cond)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x11B6788", Offset = "0x11B6788", VA = "0x11B6788")]
		private void Init()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x11B6B5C", Offset = "0x11B6B5C", VA = "0x11B6B5C")]
		private static void IntToHex(int n, char[] hex)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x11B6C0C", Offset = "0x11B6C0C", VA = "0x11B6C0C")]
		private void Indent()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x11B6C24", Offset = "0x11B6C24", VA = "0x11B6C24")]
		private void Put(string str)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x11B6CD4", Offset = "0x11B6CD4", VA = "0x11B6CD4")]
		private void PutNewline()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x11B6CDC", Offset = "0x11B6CDC", VA = "0x11B6CDC")]
		private void PutNewline(bool add_comma)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x11B6DA0", Offset = "0x11B6DA0", VA = "0x11B6DA0")]
		private void PutString(string str)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x11B710C", Offset = "0x11B710C", VA = "0x11B710C")]
		private void Unindent()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x11B7124", Offset = "0x11B7124", VA = "0x11B7124", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x11B3AF4", Offset = "0x11B3AF4", VA = "0x11B3AF4")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x11AB0F8", Offset = "0x11AB0F8", VA = "0x11AB0F8")]
		public void Write(bool boolean)
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x11B474C", Offset = "0x11B474C", VA = "0x11B474C")]
		public void Write(decimal number)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x11AB1A4", Offset = "0x11AB1A4", VA = "0x11AB1A4")]
		public void Write(double number)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x11AB304", Offset = "0x11AB304", VA = "0x11AB304")]
		public void Write(int number)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x11AB3E8", Offset = "0x11AB3E8", VA = "0x11AB3E8")]
		public void Write(long number)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x11AB058", Offset = "0x11AB058", VA = "0x11AB058")]
		public void Write(string str)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x11B3890", Offset = "0x11B3890", VA = "0x11B3890")]
		public void Write(ulong number)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x11AB5B0", Offset = "0x11AB5B0", VA = "0x11AB5B0")]
		public void WriteArrayEnd()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x11AB4CC", Offset = "0x11AB4CC", VA = "0x11AB4CC")]
		public void WriteArrayStart()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x11AB954", Offset = "0x11AB954", VA = "0x11AB954")]
		public void WriteObjectEnd()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x11AB6C0", Offset = "0x11AB6C0", VA = "0x11AB6C0")]
		public void WriteObjectStart()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x11AB7A4", Offset = "0x11AB7A4", VA = "0x11AB7A4")]
		public void WritePropertyName(string property_name)
		{
		}
	}
	[Token(Token = "0x2000043")]
	internal class FsmContext
	{
		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool Return;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int NextState;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Lexer L;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int StateStack;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x11A5A2C", Offset = "0x11A5A2C", VA = "0x11A5A2C")]
		public FsmContext()
		{
		}
	}
	[Token(Token = "0x2000044")]
	internal class Lexer
	{
		[Token(Token = "0x2000102")]
		private delegate bool StateHandler(FsmContext ctx);

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static int[] fsm_return_table;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static StateHandler[] fsm_handler_table;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool allow_comments;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		private bool allow_single_quoted_strings;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		private bool end_of_input;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private FsmContext fsm_context;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int input_buffer;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int input_char;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextReader reader;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int state;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private StringBuilder string_buffer;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string string_value;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int token;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int unichar;

		[Token(Token = "0x17000041")]
		public bool AllowComments
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x1CB07C8", Offset = "0x1CB07C8", VA = "0x1CB07C8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x1CB07D0", Offset = "0x1CB07D0", VA = "0x1CB07D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000042")]
		public bool AllowSingleQuotedStrings
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x1CB07DC", Offset = "0x1CB07DC", VA = "0x1CB07DC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x1CB07E4", Offset = "0x1CB07E4", VA = "0x1CB07E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000043")]
		public bool EndOfInput
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x1CB07F0", Offset = "0x1CB07F0", VA = "0x1CB07F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public int Token
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x1CB07F8", Offset = "0x1CB07F8", VA = "0x1CB07F8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000045")]
		public string StringValue
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x1CB0800", Offset = "0x1CB0800", VA = "0x1CB0800")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x1CB0808", Offset = "0x1CB0808", VA = "0x1CB0808")]
		static Lexer()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1CB14B8", Offset = "0x1CB14B8", VA = "0x1CB14B8")]
		public Lexer(TextReader reader)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1CB1580", Offset = "0x1CB1580", VA = "0x1CB1580")]
		private static int HexValue(int digit)
		{
			return default(int);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1CB080C", Offset = "0x1CB080C", VA = "0x1CB080C")]
		private static void PopulateFsmTables()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1CB160C", Offset = "0x1CB160C", VA = "0x1CB160C")]
		private static char ProcessEscChar(int esc_char)
		{
			return default(char);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1CB170C", Offset = "0x1CB170C", VA = "0x1CB170C")]
		private static bool State1(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1CB1A60", Offset = "0x1CB1A60", VA = "0x1CB1A60")]
		private static bool State2(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1CB1BB0", Offset = "0x1CB1BB0", VA = "0x1CB1BB0")]
		private static bool State3(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1CB1E10", Offset = "0x1CB1E10", VA = "0x1CB1E10")]
		private static bool State4(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1CB1FE0", Offset = "0x1CB1FE0", VA = "0x1CB1FE0")]
		private static bool State5(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1CB20CC", Offset = "0x1CB20CC", VA = "0x1CB20CC")]
		private static bool State6(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1CB22D0", Offset = "0x1CB22D0", VA = "0x1CB22D0")]
		private static bool State7(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1CB23E0", Offset = "0x1CB23E0", VA = "0x1CB23E0")]
		private static bool State8(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1CB2578", Offset = "0x1CB2578", VA = "0x1CB2578")]
		private static bool State9(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1CB25F8", Offset = "0x1CB25F8", VA = "0x1CB25F8")]
		private static bool State10(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1CB2678", Offset = "0x1CB2678", VA = "0x1CB2678")]
		private static bool State11(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1CB26F8", Offset = "0x1CB26F8", VA = "0x1CB26F8")]
		private static bool State12(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1CB2778", Offset = "0x1CB2778", VA = "0x1CB2778")]
		private static bool State13(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1CB27F8", Offset = "0x1CB27F8", VA = "0x1CB27F8")]
		private static bool State14(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1CB2878", Offset = "0x1CB2878", VA = "0x1CB2878")]
		private static bool State15(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1CB28F8", Offset = "0x1CB28F8", VA = "0x1CB28F8")]
		private static bool State16(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1CB2978", Offset = "0x1CB2978", VA = "0x1CB2978")]
		private static bool State17(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1CB29F8", Offset = "0x1CB29F8", VA = "0x1CB29F8")]
		private static bool State18(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1CB2A78", Offset = "0x1CB2A78", VA = "0x1CB2A78")]
		private static bool State19(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1CB2B88", Offset = "0x1CB2B88", VA = "0x1CB2B88")]
		private static bool State20(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1CB2C08", Offset = "0x1CB2C08", VA = "0x1CB2C08")]
		private static bool State21(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1CB2D9C", Offset = "0x1CB2D9C", VA = "0x1CB2D9C")]
		private static bool State22(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1CB305C", Offset = "0x1CB305C", VA = "0x1CB305C")]
		private static bool State23(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1CB316C", Offset = "0x1CB316C", VA = "0x1CB316C")]
		private static bool State24(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1CB3204", Offset = "0x1CB3204", VA = "0x1CB3204")]
		private static bool State25(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1CB3294", Offset = "0x1CB3294", VA = "0x1CB3294")]
		private static bool State26(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1CB3314", Offset = "0x1CB3314", VA = "0x1CB3314")]
		private static bool State27(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1CB3394", Offset = "0x1CB3394", VA = "0x1CB3394")]
		private static bool State28(FsmContext ctx)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1CB1A28", Offset = "0x1CB1A28", VA = "0x1CB1A28")]
		private bool GetChar()
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1CB3438", Offset = "0x1CB3438", VA = "0x1CB3438")]
		private int NextChar()
		{
			return default(int);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1CB3480", Offset = "0x1CB3480", VA = "0x1CB3480")]
		public bool NextToken()
		{
			return default(bool);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1CB1E04", Offset = "0x1CB1E04", VA = "0x1CB1E04")]
		private void UngetChar()
		{
		}
	}
	[Token(Token = "0x2000045")]
	internal enum ParserToken
	{
		[Token(Token = "0x4000109")]
		None = 65536,
		[Token(Token = "0x400010A")]
		Number,
		[Token(Token = "0x400010B")]
		True,
		[Token(Token = "0x400010C")]
		False,
		[Token(Token = "0x400010D")]
		Null,
		[Token(Token = "0x400010E")]
		CharSeq,
		[Token(Token = "0x400010F")]
		Char,
		[Token(Token = "0x4000110")]
		Text,
		[Token(Token = "0x4000111")]
		Object,
		[Token(Token = "0x4000112")]
		ObjectPrime,
		[Token(Token = "0x4000113")]
		Pair,
		[Token(Token = "0x4000114")]
		PairRest,
		[Token(Token = "0x4000115")]
		Array,
		[Token(Token = "0x4000116")]
		ArrayPrime,
		[Token(Token = "0x4000117")]
		Value,
		[Token(Token = "0x4000118")]
		ValueRest,
		[Token(Token = "0x4000119")]
		String,
		[Token(Token = "0x400011A")]
		End,
		[Token(Token = "0x400011B")]
		Epsilon
	}
}
namespace UnityEngine.AI
{
	[Token(Token = "0x2000046")]
	[Flags]
	public enum NavMeshAreas
	{
		[Token(Token = "0x400011D")]
		Walkable = 1,
		[Token(Token = "0x400011E")]
		NotWalkable = 2,
		[Token(Token = "0x400011F")]
		Jump = 4,
		[Token(Token = "0x4000120")]
		MainCharacter = 8,
		[Token(Token = "0x4000121")]
		Companion = 0x10,
		[Token(Token = "0x4000122")]
		Transition = 0x20
	}
	[Token(Token = "0x2000047")]
	public struct AreaMask
	{
		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921788", Offset = "0x921788")]
		private readonly int <Value>k__BackingField;

		[Token(Token = "0x17000046")]
		public int Value
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x9FE1A8", Offset = "0x9FE1A8", VA = "0x9FE1A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x922FA0", Offset = "0x922FA0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000047")]
		public NavMeshAreas Enum
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x9FE1B0", Offset = "0x9FE1B0", VA = "0x9FE1B0")]
			get
			{
				return default(NavMeshAreas);
			}
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9FE1B8", Offset = "0x9FE1B8", VA = "0x9FE1B8")]
		public AreaMask(int value)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9FE1C0", Offset = "0x9FE1C0", VA = "0x9FE1C0")]
		public AreaMask(NavMeshAreas areas)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1CB50A4", Offset = "0x1CB50A4", VA = "0x1CB50A4")]
		public static implicit operator AreaMask(int value)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1CB50AC", Offset = "0x1CB50AC", VA = "0x1CB50AC")]
		public static implicit operator AreaMask(string name)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1CB50D0", Offset = "0x1CB50D0", VA = "0x1CB50D0")]
		public static implicit operator AreaMask(NavMeshAreas areas)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1CB50D8", Offset = "0x1CB50D8", VA = "0x1CB50D8")]
		public static implicit operator NavMeshAreas(AreaMask flag)
		{
			return default(NavMeshAreas);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1CB50DC", Offset = "0x1CB50DC", VA = "0x1CB50DC")]
		public static implicit operator int(AreaMask flag)
		{
			return default(int);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1CB50E0", Offset = "0x1CB50E0", VA = "0x1CB50E0")]
		public static bool operator ==(AreaMask a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1CB510C", Offset = "0x1CB510C", VA = "0x1CB510C")]
		public static bool operator !=(AreaMask a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1CB513C", Offset = "0x1CB513C", VA = "0x1CB513C")]
		public static int operator +(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1CB5150", Offset = "0x1CB5150", VA = "0x1CB5150")]
		public static int operator -(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1CB5164", Offset = "0x1CB5164", VA = "0x1CB5164")]
		public static int operator |(AreaMask a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1CB516C", Offset = "0x1CB516C", VA = "0x1CB516C")]
		public static int operator ~(AreaMask a)
		{
			return default(int);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x1CB5174", Offset = "0x1CB5174", VA = "0x1CB5174")]
		public static int operator +(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1CB517C", Offset = "0x1CB517C", VA = "0x1CB517C")]
		public static int operator -(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x1CB5184", Offset = "0x1CB5184", VA = "0x1CB5184")]
		public static int operator |(int a, AreaMask b)
		{
			return default(int);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1CB518C", Offset = "0x1CB518C", VA = "0x1CB518C")]
		public static int operator +(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1CB5194", Offset = "0x1CB5194", VA = "0x1CB5194")]
		public static int operator -(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x1CB519C", Offset = "0x1CB519C", VA = "0x1CB519C")]
		public static int operator |(AreaMask a, int b)
		{
			return default(int);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x9FE1C8", Offset = "0x9FE1C8", VA = "0x9FE1C8")]
		public bool HasFlag(AreaMask flag)
		{
			return default(bool);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x9FE1FC", Offset = "0x9FE1FC", VA = "0x9FE1FC")]
		public bool HasFlag(int value)
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x9FE20C", Offset = "0x9FE20C", VA = "0x9FE20C")]
		public AreaMask Add(AreaMask flag)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x9FE218", Offset = "0x9FE218", VA = "0x9FE218")]
		public AreaMask Remove(AreaMask flag)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x9FE224", Offset = "0x9FE224", VA = "0x9FE224")]
		public AreaMask Add(NavMeshAreas flags)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x9FE230", Offset = "0x9FE230", VA = "0x9FE230")]
		public AreaMask Remove(NavMeshAreas flags)
		{
			return default(AreaMask);
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x9FE23C", Offset = "0x9FE23C", VA = "0x9FE23C")]
		public bool Equals(AreaMask other)
		{
			return default(bool);
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x9FE24C", Offset = "0x9FE24C", VA = "0x9FE24C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x9FE254", Offset = "0x9FE254", VA = "0x9FE254", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x9FE25C", Offset = "0x9FE25C", VA = "0x9FE25C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}
	}
}
namespace I2.Loc
{
	[Token(Token = "0x2000048")]
	public static class PersistentStorage
	{
		[Token(Token = "0x2000103")]
		public enum eFileType
		{
			[Token(Token = "0x400041B")]
			Raw,
			[Token(Token = "0x400041C")]
			Persistent,
			[Token(Token = "0x400041D")]
			Temporal,
			[Token(Token = "0x400041E")]
			Streaming
		}

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xEAD9DC", Offset = "0xEAD9DC", VA = "0xEAD9DC")]
		public static void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0xEACE78", Offset = "0xEACE78", VA = "0xEACE78")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xEAD078", Offset = "0xEAD078", VA = "0xEAD078")]
		public static void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xEACDD0", Offset = "0xEACDD0", VA = "0xEACDD0")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xEADFE4", Offset = "0xEADFE4", VA = "0xEADFE4")]
		public static void ForceSaveSettings()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0xEAF3AC", Offset = "0xEAF3AC", VA = "0xEAF3AC")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xEADF1C", Offset = "0xEADF1C", VA = "0xEADF1C")]
		public static bool SaveFile(eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0xEACD10", Offset = "0xEACD10", VA = "0xEACD10")]
		public static string LoadFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xEACFB8", Offset = "0xEACFB8", VA = "0xEACFB8")]
		public static bool DeleteFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xEAF750", Offset = "0xEAF750", VA = "0xEAF750")]
		public static bool HasFile(eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000049")]
	public abstract class I2BasePersistentStorage
	{
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10B11F4", Offset = "0x10B11F4", VA = "0x10B11F4", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10B14BC", Offset = "0x10B14BC", VA = "0x10B14BC", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10B1710", Offset = "0x10B1710", VA = "0x10B1710", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x10B1930", Offset = "0x10B1930", VA = "0x10B1930", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x10B1938", Offset = "0x10B1938", VA = "0x10B1938", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x10B1944", Offset = "0x10B1944", VA = "0x10B1944", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x10B194C", Offset = "0x10B194C", VA = "0x10B194C")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x10B19F8", Offset = "0x10B19F8", VA = "0x10B19F8", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x10B1CCC", Offset = "0x10B1CCC", VA = "0x10B1CCC", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x10B1F8C", Offset = "0x10B1F8C", VA = "0x10B1F8C", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10B2240", Offset = "0x10B2240", VA = "0x10B2240", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10B24F4", Offset = "0x10B24F4", VA = "0x10B24F4")]
		protected I2BasePersistentStorage()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class I2CustomPersistentStorage : I2BasePersistentStorage
	{
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xEA44D4", Offset = "0xEA44D4", VA = "0xEA44D4")]
		public I2CustomPersistentStorage()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class BaseSpecializationManager
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string[] mSpecializations;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> mSpecializationsFallbacks;

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x10A3098", Offset = "0x10A3098", VA = "0x10A3098", Slot = "4")]
		public virtual void InitializeSpecializations()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10A368C", Offset = "0x10A368C", VA = "0x10A368C", Slot = "5")]
		public virtual string GetCurrentSpecialization()
		{
			return null;
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x10A36F0", Offset = "0x10A36F0", VA = "0x10A36F0", Slot = "6")]
		public virtual string GetFallbackSpecialization(string specialization)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x10A3798", Offset = "0x10A3798", VA = "0x10A3798")]
		public BaseSpecializationManager()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x11A19A8", Offset = "0x11A19A8", VA = "0x11A19A8")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x11A19D8", Offset = "0x11A19D8", VA = "0x11A19D8")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x11A1C48", Offset = "0x11A1C48", VA = "0x11A1C48")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x11A1F7C", Offset = "0x11A1F7C", VA = "0x11A1F7C")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x11A1D58", Offset = "0x11A1D58", VA = "0x11A1D58")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x11A2350", Offset = "0x11A2350", VA = "0x11A2350")]
		public static void AppendSpecializations(string text, [Optional] List<string> list)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004D")]
	public class EventCallback
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MonoBehaviour Target;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string MethodName;

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x10A3BB4", Offset = "0x10A3BB4", VA = "0x10A3BB4")]
		public void Execute([Optional] UnityEngine.Object Sender)
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x10A3C40", Offset = "0x10A3C40", VA = "0x10A3C40")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x10A3CD4", Offset = "0x10A3CD4", VA = "0x10A3CD4")]
		public EventCallback()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public enum ePluralType
	{
		[Token(Token = "0x400012B")]
		Zero,
		[Token(Token = "0x400012C")]
		One,
		[Token(Token = "0x400012D")]
		Two,
		[Token(Token = "0x400012E")]
		Few,
		[Token(Token = "0x400012F")]
		Many,
		[Token(Token = "0x4000130")]
		Plural
	}
	[Token(Token = "0x200004F")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x2000104")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x10A3D34", Offset = "0x10A3D34", VA = "0x10A3D34")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x10A41F0", Offset = "0x10A41F0", VA = "0x10A41F0")]
		public static List<string> GetLanguagesForDropdown(string Filter, string CodesToExclude)
		{
			return null;
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x10A4000", Offset = "0x10A4000", VA = "0x10A4000")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default(bool);
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x10A4768", Offset = "0x10A4768", VA = "0x10A4768")]
		public static string GetFormatedLanguageName(string Language)
		{
			return null;
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x10A48CC", Offset = "0x10A48CC", VA = "0x10A48CC")]
		public static string GetCodedLanguage(string Language, string code)
		{
			return null;
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x10A4994", Offset = "0x10A4994", VA = "0x10A4994")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x10A4B34", Offset = "0x10A4B34", VA = "0x10A4B34")]
		public static string GetGoogleLanguageCode(string InternationalCode)
		{
			return null;
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10A4D38", Offset = "0x10A4D38", VA = "0x10A4D38")]
		public static string GetLanguageName(string code, bool useParenthesesForRegion = false, bool allowDiscardRegion = true)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10A5060", Offset = "0x10A5060", VA = "0x10A5060")]
		public static List<string> GetAllInternationalCodes()
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10A5248", Offset = "0x10A5248", VA = "0x10A5248")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default(bool);
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x10A5438", Offset = "0x10A5438", VA = "0x10A5438")]
		private static int GetPluralRule(string langCode)
		{
			return default(int);
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x10A5648", Offset = "0x10A5648", VA = "0x10A5648")]
		public static bool LanguageHasPluralType(string langCode, string pluralType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x10A57CC", Offset = "0x10A57CC", VA = "0x10A57CC")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default(ePluralType);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x10A5EDC", Offset = "0x10A5EDC", VA = "0x10A5EDC")]
		public static int GetPluralTestNumber(string langCode, ePluralType pluralType)
		{
			return default(int);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x10A5EC4", Offset = "0x10A5EC4", VA = "0x10A5EC4")]
		private static bool inRange(int amount, int min, int max)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000050")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x2000105")]
		public delegate void fnOnTranslated(string Translation, string Error);

		[Token(Token = "0x2000106")]
		public delegate void fnOnTranslationReady(Dictionary<string, TranslationQuery> dict, string error);

		[Token(Token = "0x2000107")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921188", Offset = "0x921188")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public fnOnTranslated OnTranslationReady;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string text;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Dictionary<string, TranslationQuery> queries;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string LanguageCodeTo;

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x10AC5E4", Offset = "0x10AC5E4", VA = "0x10AC5E4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x10AFE60", Offset = "0x10AFE60", VA = "0x10AFE60")]
			internal void <Translate>b__0(Dictionary<string, TranslationQuery> results, string error)
			{
			}
		}

		[Token(Token = "0x2000108")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921198", Offset = "0x921198")]
		private sealed class <WaitForTranslations>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000D5")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600080B")]
				[Address(RVA = "0x10B012C", Offset = "0x10B012C", VA = "0x10B012C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080D")]
				[Address(RVA = "0x10B019C", Offset = "0x10B019C", VA = "0x10B019C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x10ADDB0", Offset = "0x10ADDB0", VA = "0x10ADDB0")]
			[DebuggerHidden]
			public <WaitForTranslations>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x10AFF5C", Offset = "0x10AFF5C", VA = "0x10AFF5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x10AFF60", Offset = "0x10AFF60", VA = "0x10AFF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080C")]
			[Address(RVA = "0x10B0134", Offset = "0x10B0134", VA = "0x10B0134", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x10AC2C4", Offset = "0x10AC2C4", VA = "0x10AC2C4")]
		public static bool CanTranslate()
		{
			return default(bool);
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x10AC390", Offset = "0x10AC390", VA = "0x10AC390")]
		public static void Translate(string text, string LanguageCodeFrom, string LanguageCodeTo, fnOnTranslated OnTranslationReady)
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x10AD028", Offset = "0x10AD028", VA = "0x10AD028")]
		public static string ForceTranslate(string text, string LanguageCodeFrom, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10ACF94", Offset = "0x10ACF94", VA = "0x10ACF94")]
		public static void Translate(Dictionary<string, TranslationQuery> requests, fnOnTranslationReady OnTranslationReady, bool usePOST = true)
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x10AD670", Offset = "0x10AD670", VA = "0x10AD670")]
		public static bool ForceTranslate(Dictionary<string, TranslationQuery> requests, bool usePOST = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x10AD6FC", Offset = "0x10AD6FC", VA = "0x10AD6FC")]
		public static List<string> ConvertTranslationRequest(Dictionary<string, TranslationQuery> requests, bool encodeGET)
		{
			return null;
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10AD578", Offset = "0x10AD578", VA = "0x10AD578")]
		private static void AddTranslationJob(TranslationJob job)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x10ADD50", Offset = "0x10ADD50", VA = "0x10ADD50")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x922FB0", Offset = "0x922FB0")]
		private static IEnumerator WaitForTranslations()
		{
			return null;
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x10ADDDC", Offset = "0x10ADDDC", VA = "0x10ADDDC")]
		public static string ParseTranslationResult(string html, Dictionary<string, TranslationQuery> requests)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10AE5BC", Offset = "0x10AE5BC", VA = "0x10AE5BC")]
		public static bool IsTranslating()
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10AE6A0", Offset = "0x10AE6A0", VA = "0x10AE6A0")]
		public static void CancelCurrentGoogleTranslations()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x10ACD6C", Offset = "0x10ACD6C", VA = "0x10ACD6C")]
		public static void CreateQueries(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x10AE860", Offset = "0x10AE860", VA = "0x10AE860")]
		private static void CreateQueries_Plurals(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x10AD168", Offset = "0x10AD168", VA = "0x10AD168")]
		public static void AddQuery(string text, string LanguageCodeFrom, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x10AF424", Offset = "0x10AF424", VA = "0x10AF424")]
		private static string GetTranslation(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x10AE328", Offset = "0x10AE328", VA = "0x10AE328")]
		private static TranslationQuery FindQueryFromOrigText(string origText, Dictionary<string, TranslationQuery> dict)
		{
			return default(TranslationQuery);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x10AEB58", Offset = "0x10AEB58", VA = "0x10AEB58")]
		public static bool HasParameters(string text)
		{
			return default(bool);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x10AEDA0", Offset = "0x10AEDA0", VA = "0x10AEDA0")]
		public static string GetPluralParameter(string text, bool forceTag)
		{
			return null;
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x10AEBFC", Offset = "0x10AEBFC", VA = "0x10AEBFC")]
		public static string GetPluralText(string text, string pluralType)
		{
			return null;
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x10AF528", Offset = "0x10AF528", VA = "0x10AF528")]
		private static int FindClosingTag(string tag, MatchCollection matches, int startIndex)
		{
			return default(int);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x10AE518", Offset = "0x10AE518", VA = "0x10AE518")]
		private static string GetGoogleNoTranslateTag(int tagNumber)
		{
			return null;
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x10AEEB0", Offset = "0x10AEEB0", VA = "0x10AEEB0")]
		private static void ParseNonTranslatableElements(ref TranslationQuery query)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x10AD440", Offset = "0x10AD440", VA = "0x10AD440")]
		public static string GetQueryResult(string text, string LanguageCodeTo, Dictionary<string, TranslationQuery> dict)
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x10AF624", Offset = "0x10AF624", VA = "0x10AF624")]
		public static string RebuildTranslation(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x10AF8DC", Offset = "0x10AF8DC", VA = "0x10AF8DC")]
		private static string RebuildTranslation_Plural(string text, Dictionary<string, TranslationQuery> dict, string LanguageCodeTo)
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10AFC9C", Offset = "0x10AFC9C", VA = "0x10AFC9C")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x10ADC84", Offset = "0x10ADC84", VA = "0x10ADC84")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
	[Token(Token = "0x2000051")]
	public struct TranslationQuery
	{
		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string OrigText;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string Text;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string LanguageCode;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string[] TargetLanguagesCode;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string[] Results;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Tags;
	}
	[Token(Token = "0x2000052")]
	public class TranslationJob : IDisposable
	{
		[Token(Token = "0x2000109")]
		public enum eJobState
		{
			[Token(Token = "0x400042A")]
			Running,
			[Token(Token = "0x400042B")]
			Succeeded,
			[Token(Token = "0x400042C")]
			Failed
		}

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public eJobState mJobState;

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x11A364C", Offset = "0x11A364C", VA = "0x11A364C", Slot = "5")]
		public virtual eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x11A3654", Offset = "0x11A3654", VA = "0x11A3654", Slot = "6")]
		public virtual void Dispose()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x11A3658", Offset = "0x11A3658", VA = "0x11A3658")]
		public TranslationJob()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public class TranslationJob_WWW : TranslationJob
	{
		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityWebRequest www;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x11A5140", Offset = "0x11A5140", VA = "0x11A5140", Slot = "6")]
		public override void Dispose()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x11A3700", Offset = "0x11A3700", VA = "0x11A3700")]
		public TranslationJob_WWW()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class TranslationJob_GET : TranslationJob_WWW
	{
		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<string> mQueries;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string mErrorMessage;

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x11A3660", Offset = "0x11A3660", VA = "0x11A3660")]
		public TranslationJob_GET(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x11A3708", Offset = "0x11A3708", VA = "0x11A3708")]
		private void ExecuteNextQuery()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x11A3860", Offset = "0x11A3860", VA = "0x11A3860", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x11A3930", Offset = "0x11A3930", VA = "0x11A3930")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class TranslationJob_Main : TranslationJob
	{
		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TranslationJob_WEB mWeb;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TranslationJob_POST mPost;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TranslationJob_GET mGet;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mErrorMessage;

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x11A3A58", Offset = "0x11A3A58", VA = "0x11A3A58")]
		public TranslationJob_Main(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x11A3C50", Offset = "0x11A3C50", VA = "0x11A3C50", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x11A3E20", Offset = "0x11A3E20", VA = "0x11A3E20", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class TranslationJob_POST : TranslationJob_WWW
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x11A3ADC", Offset = "0x11A3ADC", VA = "0x11A3ADC")]
		public TranslationJob_POST(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x11A3E6C", Offset = "0x11A3E6C", VA = "0x11A3E6C", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x11A3F2C", Offset = "0x11A3F2C", VA = "0x11A3F2C")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class TranslationJob_WEB : TranslationJob_WWW
	{
		[Serializable]
		[Token(Token = "0x200010A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211A8", Offset = "0x9211A8")]
		private sealed class <>c
		{
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Comparison<KeyValuePair<string, string>> <>9__8_0;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static MatchEvaluator <>9__12_0;

			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static MatchEvaluator <>9__12_1;

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x11A4F14", Offset = "0x11A4F14", VA = "0x11A4F14")]
			public <>c()
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x11A4F1C", Offset = "0x11A4F1C", VA = "0x11A4F1C")]
			internal int <FindAllQueries>b__8_0(KeyValuePair<string, string> a, KeyValuePair<string, string> b)
			{
				return default(int);
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x11A4FAC", Offset = "0x11A4FAC", VA = "0x11A4FAC")]
			internal string <ParseTranslationResult>b__12_0(Match match)
			{
				return null;
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x11A5078", Offset = "0x11A5078", VA = "0x11A5078")]
			internal string <ParseTranslationResult>b__12_1(Match match)
			{
				return null;
			}
		}

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<string, TranslationQuery> _requests;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string mErrorMessage;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string mCurrentBatch_ToLanguageCode;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mCurrentBatch_FromLanguageCode;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private List<string> mCurrentBatch_Text;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<KeyValuePair<string, string>> mQueries;

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x11A4040", Offset = "0x11A4040", VA = "0x11A4040")]
		public TranslationJob_WEB(Dictionary<string, TranslationQuery> requests, GoogleTranslation.fnOnTranslationReady OnTranslationReady)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x11A4084", Offset = "0x11A4084", VA = "0x11A4084")]
		private void FindAllQueries()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x11A43E0", Offset = "0x11A43E0", VA = "0x11A43E0")]
		private void ExecuteNextBatch()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x11A47C4", Offset = "0x11A47C4", VA = "0x11A47C4", Slot = "5")]
		public override eJobState GetState()
		{
			return default(eJobState);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x11A4894", Offset = "0x11A4894", VA = "0x11A4894")]
		public void ProcessResult(byte[] bytes, string errorMsg)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x11A49C8", Offset = "0x11A49C8", VA = "0x11A49C8")]
		private string ParseTranslationResult(string html, string OriginalText)
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	public enum eLanguageDataFlags
	{
		[Token(Token = "0x4000150")]
		DISABLED = 1,
		[Token(Token = "0x4000151")]
		KEEP_LOADED = 2,
		[Token(Token = "0x4000152")]
		NOT_LOADED = 4
	}
	[Serializable]
	[Token(Token = "0x2000059")]
	public class LanguageData
	{
		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Code;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public byte Flags;

		[NonSerialized]
		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool Compressed;

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xEA57A0", Offset = "0xEA57A0", VA = "0xEA57A0")]
		public bool IsEnabled()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0xEA57B0", Offset = "0xEA57B0", VA = "0xEA57B0")]
		public void SetEnabled(bool bEnabled)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0xEA57CC", Offset = "0xEA57CC", VA = "0xEA57CC")]
		public bool IsLoaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0xEA57DC", Offset = "0xEA57DC", VA = "0xEA57DC")]
		public bool CanBeUnloaded()
		{
			return default(bool);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0xEA57EC", Offset = "0xEA57EC", VA = "0xEA57EC")]
		public void SetLoaded(bool loaded)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0xEA580C", Offset = "0xEA580C", VA = "0xEA580C")]
		public void SetCanBeUnLoaded(bool allowUnloading)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0xEA582C", Offset = "0xEA582C", VA = "0xEA582C")]
		public LanguageData()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920D94", Offset = "0x920D94")]
	[ExecuteInEditMode]
	public class LanguageSource : MonoBehaviour, ISerializationCallbackReceiver, ILanguageSource
	{
		[Token(Token = "0x200010B")]
		public delegate void fnOnSourceUpdated(LanguageSourceData source, bool ReceivedNewData, string errorMsg);

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int version;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool NeverDestroy;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
		public bool GoogleLiveSyncIsUptoDate;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public List<UnityEngine.Object> Assets;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Google_WebServiceURL;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public LanguageSourceData.eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public LanguageSourceData.eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public bool CaseInsensitiveTerms;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LanguageSourceData.MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public string mTerm_AppName;

		[Token(Token = "0x17000048")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0xEA5834", Offset = "0xEA5834", VA = "0xEA5834", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0xEA583C", Offset = "0xEA583C", VA = "0xEA583C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public event fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0xEA5844", Offset = "0xEA5844", VA = "0xEA5844")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923014", Offset = "0x923014")]
			add
			{
			}
			[Token(Token = "0x60002B5")]
			[Address(RVA = "0xEA5930", Offset = "0xEA5930", VA = "0xEA5930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923024", Offset = "0x923024")]
			remove
			{
			}
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0xEA5A1C", Offset = "0xEA5A1C", VA = "0xEA5A1C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0xEA5AE0", Offset = "0xEA5AE0", VA = "0xEA5AE0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0xEA5B74", Offset = "0xEA5B74", VA = "0xEA5B74")]
		public string GetSourceName()
		{
			return null;
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0xEA5C88", Offset = "0xEA5C88", VA = "0xEA5C88", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0xEA5C94", Offset = "0xEA5C94", VA = "0xEA5C94", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0xEA6368", Offset = "0xEA6368", VA = "0xEA6368")]
		public LanguageSource()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0x920DE0", Offset = "0x920DE0")]
	public class LanguageSourceAsset : ScriptableObject, ILanguageSource
	{
		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LanguageSourceData mSource;

		[Token(Token = "0x17000049")]
		public LanguageSourceData SourceData
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0xEA6CE4", Offset = "0xEA6CE4", VA = "0xEA6CE4", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0xEA6CEC", Offset = "0xEA6CEC", VA = "0xEA6CEC", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0xEA6CF4", Offset = "0xEA6CF4", VA = "0xEA6CF4")]
		public LanguageSourceAsset()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public interface ILanguageSource
	{
		[Token(Token = "0x1700004A")]
		LanguageSourceData SourceData
		{
			[Token(Token = "0x60002BF")]
			get;
			[Token(Token = "0x60002C0")]
			set;
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	[ExecuteInEditMode]
	public class LanguageSourceData
	{
		[Token(Token = "0x200010C")]
		public enum MissingTranslationAction
		{
			[Token(Token = "0x4000432")]
			Empty,
			[Token(Token = "0x4000433")]
			Fallback,
			[Token(Token = "0x4000434")]
			ShowWarning,
			[Token(Token = "0x4000435")]
			ShowTerm
		}

		[Token(Token = "0x200010D")]
		public enum eAllowUnloadLanguages
		{
			[Token(Token = "0x4000437")]
			Never,
			[Token(Token = "0x4000438")]
			OnlyInDevice,
			[Token(Token = "0x4000439")]
			EditorAndDevice
		}

		[Token(Token = "0x200010E")]
		public enum eGoogleUpdateFrequency
		{
			[Token(Token = "0x400043B")]
			Always,
			[Token(Token = "0x400043C")]
			Never,
			[Token(Token = "0x400043D")]
			Daily,
			[Token(Token = "0x400043E")]
			Weekly,
			[Token(Token = "0x400043F")]
			Monthly,
			[Token(Token = "0x4000440")]
			OnlyOnce,
			[Token(Token = "0x4000441")]
			EveryOtherDay
		}

		[Token(Token = "0x200010F")]
		public enum eGoogleUpdateSynchronization
		{
			[Token(Token = "0x4000443")]
			Manual,
			[Token(Token = "0x4000444")]
			OnSceneLoaded,
			[Token(Token = "0x4000445")]
			AsSoonAsDownloaded
		}

		[Serializable]
		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211B8", Offset = "0x9211B8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__39_0;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__39_1;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__39_2;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__39_3;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static Comparison<TermData> <>9__43_0;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static Comparison<TermData> <>9__47_0;

			[Token(Token = "0x6000818")]
			[Address(RVA = "0xEB0500", Offset = "0xEB0500", VA = "0xEB0500")]
			public <>c()
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0xEB0508", Offset = "0xEB0508", VA = "0xEB0508")]
			internal bool <UpdateAssetDictionary>b__39_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0xEB0574", Offset = "0xEB0574", VA = "0xEB0574")]
			internal string <UpdateAssetDictionary>b__39_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0xEB05A4", Offset = "0xEB05A4", VA = "0xEB05A4")]
			internal string <UpdateAssetDictionary>b__39_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0xEB0654", Offset = "0xEB0654", VA = "0xEB0654")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__39_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0xEB06A4", Offset = "0xEB06A4", VA = "0xEB06A4")]
			internal int <Export_I2CSV>b__43_0(TermData a, TermData b)
			{
				return default(int);
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0xEB06EC", Offset = "0xEB06EC", VA = "0xEB06EC")]
			internal int <Export_CSV>b__47_0(TermData a, TermData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211C8", Offset = "0x9211C8")]
		private sealed class <Import_Google_Coroutine>d__65 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public LanguageSourceData <>4__this;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool JustCheck;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x170000D7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000822")]
				[Address(RVA = "0xEB0A3C", Offset = "0xEB0A3C", VA = "0xEB0A3C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000824")]
				[Address(RVA = "0xEB0AAC", Offset = "0xEB0AAC", VA = "0xEB0AAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0xEADB28", Offset = "0xEADB28", VA = "0xEADB28")]
			[DebuggerHidden]
			public <Import_Google_Coroutine>d__65(int <>1__state)
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0xEB0734", Offset = "0xEB0734", VA = "0xEB0734", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0xEB0738", Offset = "0xEB0738", VA = "0xEB0738", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0xEB0A44", Offset = "0xEB0A44", VA = "0xEB0A44", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[NonSerialized]
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ILanguageSource owner;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool UserAgreesToHaveItOnTheScene;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool UserAgreesToHaveItInsideThePluginsFolder;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool GoogleLiveSyncIsUptoDate;

		[NonSerialized]
		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool mIsGlobalSource;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<TermData> mTerms;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool CaseInsensitiveTerms;

		[NonSerialized]
		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<string, TermData> mDictionary;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MissingTranslationAction OnMissingTranslation;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string mTerm_AppName;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<LanguageData> mLanguages;

		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool IgnoreDeviceLanguage;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public eAllowUnloadLanguages _AllowUnloadingLanguages;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string Google_WebServiceURL;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string Google_SpreadsheetKey;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public string Google_SpreadsheetName;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public string Google_LastUpdatedVersion;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public eGoogleUpdateFrequency GoogleUpdateFrequency;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public eGoogleUpdateFrequency GoogleInEditorCheckFrequency;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public eGoogleUpdateSynchronization GoogleUpdateSynchronization;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float GoogleUpdateDelay;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public List<UnityEngine.Object> Assets;

		[NonSerialized]
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private string mDelayedGoogleData;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string EmptyCategory;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static char[] CategorySeparators;

		[Token(Token = "0x1700004B")]
		public UnityEngine.Object ownerObject
		{
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0xEA6D58", Offset = "0xEA6D58", VA = "0xEA6D58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000002")]
		public event LanguageSource.fnOnSourceUpdated Event_OnSourceUpdateFromGoogle
		{
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0xEA627C", Offset = "0xEA627C", VA = "0xEA627C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923034", Offset = "0x923034")]
			add
			{
			}
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0xEA6DDC", Offset = "0xEA6DDC", VA = "0xEA6DDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923044", Offset = "0x923044")]
			remove
			{
			}
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0xEA5A60", Offset = "0xEA5A60", VA = "0xEA5A60")]
		public void Awake()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0xEA5B10", Offset = "0xEA5B10", VA = "0xEA5B10")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0xEA78A0", Offset = "0xEA78A0", VA = "0xEA78A0")]
		public bool IsEqualTo(LanguageSourceData Source)
		{
			return default(bool);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0xEA7F44", Offset = "0xEA7F44", VA = "0xEA7F44")]
		internal bool ManagerHasASimilarSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0xEA8070", Offset = "0xEA8070", VA = "0xEA8070")]
		public void ClearAllData()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0xEA813C", Offset = "0xEA813C", VA = "0xEA813C")]
		public bool IsGlobalSource()
		{
			return default(bool);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0xEA8144", Offset = "0xEA8144", VA = "0xEA8144")]
		public void Editor_SetDirty()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0xEA73FC", Offset = "0xEA73FC", VA = "0xEA73FC")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0xEA8148", Offset = "0xEA8148", VA = "0xEA8148")]
		public UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0xEA8238", Offset = "0xEA8238", VA = "0xEA8238")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0xEA82A8", Offset = "0xEA82A8", VA = "0xEA82A8")]
		public void AddAsset(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0xEA835C", Offset = "0xEA835C", VA = "0xEA835C")]
		public string Export_I2CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0xEA8A6C", Offset = "0xEA8A6C", VA = "0xEA8A6C")]
		private static void AppendI2Term(StringBuilder Builder, int nLanguages, string Term, TermData termData, char Separator, string forceSpecialization)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0xEA8DA0", Offset = "0xEA8DA0", VA = "0xEA8DA0")]
		private static void AppendI2Text(StringBuilder Builder, string text)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0xEA8E90", Offset = "0xEA8E90", VA = "0xEA8E90")]
		private string Export_Language_to_Cache(int langIndex, bool fillTermWithFallback)
		{
			return null;
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0xEA94EC", Offset = "0xEA94EC", VA = "0xEA94EC")]
		public string Export_CSV(string Category, char Separator = ',', bool specializationsAsRows = true)
		{
			return null;
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0xEA9E54", Offset = "0xEA9E54", VA = "0xEA9E54")]
		private static void AppendTerm(StringBuilder Builder, int nLanguages, string Term, TermData termData, string specialization, char Separator)
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0xEA9CE8", Offset = "0xEA9CE8", VA = "0xEA9CE8")]
		private static void AppendString(StringBuilder Builder, string Text, char Separator)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0xEAA154", Offset = "0xEAA154", VA = "0xEAA154")]
		private static void AppendTranslation(StringBuilder Builder, string Text, char Separator, string tags)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0xEAA2FC", Offset = "0xEAA2FC", VA = "0xEAA2FC")]
		public UnityWebRequest Export_Google_CreateWWWcall(eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0xEAA504", Offset = "0xEAA504", VA = "0xEAA504")]
		private string Export_Google_CreateData()
		{
			return null;
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0xEAAB24", Offset = "0xEAAB24", VA = "0xEAAB24")]
		public string Import_CSV(string Category, string CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xEAB9C0", Offset = "0xEAB9C0", VA = "0xEAB9C0")]
		public string Import_I2CSV(string Category, string I2CSVstring, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xEAAC54", Offset = "0xEAAC54", VA = "0xEAAC54")]
		public string Import_CSV(string Category, List<string[]> CSV, eSpreadsheetUpdateMode UpdateMode = eSpreadsheetUpdateMode.Replace)
		{
			return null;
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xEABC08", Offset = "0xEABC08", VA = "0xEABC08")]
		private bool ArrayContains(string MainText, params string[] texts)
		{
			return default(bool);
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xEAC0EC", Offset = "0xEAC0EC", VA = "0xEAC0EC")]
		public static eTermType GetTermType(string type)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xEAC3D0", Offset = "0xEAC3D0", VA = "0xEAC3D0")]
		private void Import_Language_from_Cache(int langIndex, string langData, bool useFallback, bool onlyCurrentSpecialization)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xEAC678", Offset = "0xEAC678", VA = "0xEAC678")]
		public static void FreeUnusedLanguages()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xEAC8A4", Offset = "0xEAC8A4", VA = "0xEAC8A4")]
		public void Import_Google_FromCache()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xEACF28", Offset = "0xEACF28", VA = "0xEACF28")]
		private bool IsNewerVersion(string currentVersion, string newVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xEAD768", Offset = "0xEAD768", VA = "0xEAD768")]
		public void Import_Google(bool ForceUpdate, bool justCheck)
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xEACB10", Offset = "0xEACB10", VA = "0xEACB10")]
		private string GetSourcePlayerPrefName()
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xEADA8C", Offset = "0xEADA8C", VA = "0xEADA8C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x923054", Offset = "0x923054")]
		private IEnumerator Import_Google_Coroutine(bool JustCheck)
		{
			return null;
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xEADB54", Offset = "0xEADB54", VA = "0xEADB54")]
		private void ApplyDownloadedDataOnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xEADBD8", Offset = "0xEADBD8", VA = "0xEADBD8")]
		public void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xEADD1C", Offset = "0xEADD1C", VA = "0xEADD1C")]
		public UnityWebRequest Import_Google_CreateWWWcall(bool ForceUpdate, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xEADE74", Offset = "0xEADE74", VA = "0xEADE74")]
		public bool HasGoogleSpreadsheet()
		{
			return default(bool);
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0xEAD120", Offset = "0xEAD120", VA = "0xEAD120")]
		public string Import_Google_Result(string JsonString, eSpreadsheetUpdateMode UpdateMode, bool saveInPlayerPrefs = false)
		{
			return null;
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xEA7ACC", Offset = "0xEA7ACC", VA = "0xEA7ACC")]
		public int GetLanguageIndex(string language, bool AllowDiscartingRegion = true, bool SkipDisabled = true)
		{
			return default(int);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0xEAE27C", Offset = "0xEAE27C", VA = "0xEAE27C")]
		public LanguageData GetLanguageData(string language, bool AllowDiscartingRegion = true)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xEAE318", Offset = "0xEAE318", VA = "0xEAE318")]
		public bool IsCurrentLanguage(int languageIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xEABCC0", Offset = "0xEABCC0", VA = "0xEABCC0")]
		public int GetLanguageIndexFromCode(string Code, bool exactMatch = true, bool ignoreDisabled = false)
		{
			return default(int);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xEAE07C", Offset = "0xEAE07C", VA = "0xEAE07C")]
		public static int GetCommonWordInLanguageNames(string Language1, string Language2)
		{
			return default(int);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0xEAE3CC", Offset = "0xEAE3CC", VA = "0xEAE3CC")]
		public static bool AreTheSameLanguage(string Language1, string Language2)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xEAE468", Offset = "0xEAE468", VA = "0xEAE468")]
		public static string GetLanguageWithoutRegion(string Language)
		{
			return null;
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0xEAE534", Offset = "0xEAE534", VA = "0xEAE534")]
		public void AddLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xEAE5BC", Offset = "0xEAE5BC", VA = "0xEAE5BC")]
		public void AddLanguage(string LanguageName, string LanguageCode)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xEAE798", Offset = "0xEAE798", VA = "0xEAE798")]
		public void RemoveLanguage(string LanguageName)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xEAEB10", Offset = "0xEAEB10", VA = "0xEAEB10")]
		public List<string> GetLanguages(bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0xEAEC68", Offset = "0xEAEC68", VA = "0xEAEC68")]
		public List<string> GetLanguagesCode(bool allowRegions = true, bool skipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xEAEE38", Offset = "0xEAEE38", VA = "0xEAEE38")]
		public bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0xEAEEE8", Offset = "0xEAEEE8", VA = "0xEAEEE8")]
		public void EnableLanguage(string Language, bool bEnabled)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xEAEFA0", Offset = "0xEAEFA0", VA = "0xEAEFA0")]
		public bool AllowUnloadingLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xEAEFB0", Offset = "0xEAEFB0", VA = "0xEAEFB0")]
		private string GetSavedLanguageFileName(int languageIndex)
		{
			return null;
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xEAF208", Offset = "0xEAF208", VA = "0xEAF208")]
		public void LoadLanguage(int languageIndex, bool UnloadOtherLanguages, bool useFallback, bool onlyCurrentSpecialization, bool forceLoad)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0xEAF6A4", Offset = "0xEAF6A4", VA = "0xEAF6A4")]
		public void LoadAllLanguages(bool forceLoad = false)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xEAF444", Offset = "0xEAF444", VA = "0xEAF444")]
		public void UnloadLanguage(int languageIndex)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0xEAC298", Offset = "0xEAC298", VA = "0xEAC298")]
		public void SaveLanguages(bool unloadAll, PersistentStorage.eFileType fileLocation = PersistentStorage.eFileType.Temporal)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xEAC1CC", Offset = "0xEAC1CC", VA = "0xEAC1CC")]
		public bool HasUnloadedLanguages()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xEAA910", Offset = "0xEAA910", VA = "0xEAA910")]
		public List<string> GetCategories(bool OnlyMainCategory = false, [Optional] List<string> Categories)
		{
			return null;
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xEAF93C", Offset = "0xEAF93C", VA = "0xEAF93C")]
		public static string GetKeyFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xEAF810", Offset = "0xEAF810", VA = "0xEAF810")]
		public static string GetCategoryFromFullTerm(string FullTerm, bool OnlyMainCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xEAFA44", Offset = "0xEAFA44", VA = "0xEAFA44")]
		public static void DeserializeFullTerm(string FullTerm, out string Key, out string Category, bool OnlyMainCategory = false)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0xEA7114", Offset = "0xEA7114", VA = "0xEA7114")]
		public void UpdateDictionary(bool force = false)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xEAFBBC", Offset = "0xEAFBBC", VA = "0xEAFBBC")]
		public string GetTranslation(string term, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0xEAFC68", Offset = "0xEAFC68", VA = "0xEAFC68")]
		public bool TryGetTranslation(string term, out string Translation, [Optional] string overrideLanguage, [Optional] string overrideSpecialization, bool skipDisabled = false, bool allowCategoryMistmatch = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xEA91A4", Offset = "0xEA91A4", VA = "0xEA91A4")]
		private bool TryGetFallbackTranslation(TermData termData, out string Translation, int langIndex, [Optional] string overrideSpecialization, bool skipDisabled = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xEAFE7C", Offset = "0xEAFE7C", VA = "0xEAFE7C")]
		public TermData AddTerm(string term)
		{
			return null;
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xEA7CF4", Offset = "0xEA7CF4", VA = "0xEA7CF4")]
		public TermData GetTermData(string term, bool allowCategoryMistmatch = false)
		{
			return null;
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0xEB0098", Offset = "0xEB0098", VA = "0xEB0098")]
		public bool ContainsTerm(string term)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xEB00B8", Offset = "0xEB00B8", VA = "0xEB00B8")]
		public List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0xEAFE88", Offset = "0xEAFE88", VA = "0xEAFE88")]
		public TermData AddTerm(string NewTerm, eTermType termType, bool SaveSource = true)
		{
			return null;
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xEB02D8", Offset = "0xEB02D8", VA = "0xEB02D8")]
		public void RemoveTerm(string term)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xEABEC4", Offset = "0xEABEC4", VA = "0xEABEC4")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xEA6100", Offset = "0xEA6100", VA = "0xEA6100")]
		public LanguageSourceData()
		{
		}
	}
	[Token(Token = "0x200005E")]
	public enum eSpreadsheetUpdateMode
	{
		[Token(Token = "0x4000189")]
		None,
		[Token(Token = "0x400018A")]
		Replace,
		[Token(Token = "0x400018B")]
		Merge,
		[Token(Token = "0x400018C")]
		AddNewTerms
	}
	[Token(Token = "0x200005F")]
	public class LocalizationReader
	{
		[Token(Token = "0x6000310")]
		[Address(RVA = "0xEB94CC", Offset = "0xEB94CC", VA = "0xEB94CC")]
		public static Dictionary<string, string> ReadTextAsset(TextAsset asset)
		{
			return null;
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0xEB972C", Offset = "0xEB972C", VA = "0xEB972C")]
		public static bool TextAsset_ReadLine(string line, out string key, out string value, out string category, out string comment, out string termType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0xEB9BC4", Offset = "0xEB9BC4", VA = "0xEB9BC4")]
		public static string ReadCSVfile(string Path, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0xEAAB6C", Offset = "0xEAAB6C", VA = "0xEAAB6C")]
		public static List<string[]> ReadCSV(string Text, char Separator = ',')
		{
			return null;
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xEB9D6C", Offset = "0xEB9D6C", VA = "0xEB9D6C")]
		private static string[] ParseCSVline(string Line, ref int iStart, char Separator)
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0xEB9F9C", Offset = "0xEB9F9C", VA = "0xEB9F9C")]
		private static void AddCSVtoken(ref List<string> list, ref string Line, int iEnd, ref int iWordStart)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0xEABA04", Offset = "0xEABA04", VA = "0xEABA04")]
		public static List<string[]> ReadI2CSV(string Text)
		{
			return null;
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0xEB9AF8", Offset = "0xEB9AF8", VA = "0xEB9AF8")]
		public static void ValidateFullTerm(ref string Term)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0xEBA168", Offset = "0xEBA168", VA = "0xEBA168")]
		public static string EncodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0xEB9A5C", Offset = "0xEB9A5C", VA = "0xEB9A5C")]
		public static string DecodeString(string str)
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0xEBA254", Offset = "0xEBA254", VA = "0xEBA254")]
		public LocalizationReader()
		{
		}
	}
	[Token(Token = "0x2000060")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920E60", Offset = "0x920E60")]
	public class Localize : MonoBehaviour
	{
		[Token(Token = "0x2000112")]
		public enum TermModification
		{
			[Token(Token = "0x4000453")]
			DontModify,
			[Token(Token = "0x4000454")]
			ToUpper,
			[Token(Token = "0x4000455")]
			ToLower,
			[Token(Token = "0x4000456")]
			ToUpperFirst,
			[Token(Token = "0x4000457")]
			ToTitle
		}

		[Serializable]
		[Token(Token = "0x2000113")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211D8", Offset = "0x9211D8")]
		private sealed class <>c
		{
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<UnityEngine.Object> <>9__49_0;

			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<UnityEngine.Object, string> <>9__49_1;

			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<IGrouping<string, UnityEngine.Object>, string> <>9__49_2;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static Func<IGrouping<string, UnityEngine.Object>, UnityEngine.Object> <>9__49_3;

			[Token(Token = "0x6000826")]
			[Address(RVA = "0xEBB38C", Offset = "0xEBB38C", VA = "0xEBB38C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0xEBB394", Offset = "0xEBB394", VA = "0xEBB394")]
			internal bool <UpdateAssetDictionary>b__49_0(UnityEngine.Object x)
			{
				return default(bool);
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0xEBB400", Offset = "0xEBB400", VA = "0xEBB400")]
			internal string <UpdateAssetDictionary>b__49_1(UnityEngine.Object o)
			{
				return null;
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0xEBB430", Offset = "0xEBB430", VA = "0xEBB430")]
			internal string <UpdateAssetDictionary>b__49_2(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0xEBB4E0", Offset = "0xEBB4E0", VA = "0xEBB4E0")]
			internal UnityEngine.Object <UpdateAssetDictionary>b__49_3(IGrouping<string, UnityEngine.Object> g)
			{
				return null;
			}
		}

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string mTerm;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string mTermSecondary;

		[NonSerialized]
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string FinalTerm;

		[NonSerialized]
		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string FinalSecondaryTerm;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TermModification PrimaryTermModifier;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public TermModification SecondaryTermModifier;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string TermPrefix;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string TermSuffix;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool LocalizeOnAwake;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private string LastLocalizedLanguage;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool IgnoreRTL;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int MaxCharactersInRTL;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool IgnoreNumbersInRTL;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool CorrectAlignmentForRTL;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AddSpacesToJoinedLanguages;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		public bool AllowLocalizedParameters;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<UnityEngine.Object> TranslatedObjects;

		[NonSerialized]
		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Dictionary<string, UnityEngine.Object> mAssetDictionary;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent LocalizeEvent;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string MainTranslation;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string SecondaryTranslation;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string CallBackTerm;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string CallBackSecondaryTerm;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Localize CurrentLocalizeComponent;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool AlwaysForceLocalize;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public EventCallback LocalizeCallBack;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool mGUI_ShowReferences;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool mGUI_ShowTems;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		public bool mGUI_ShowCallback;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public ILocalizeTarget mLocalizeTarget;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public string mLocalizeTargetName;

		[Token(Token = "0x1700004C")]
		public string Term
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0xEBA25C", Offset = "0xEBA25C", VA = "0xEBA25C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0xEBA264", Offset = "0xEBA264", VA = "0xEBA264")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public string SecondaryTerm
		{
			[Token(Token = "0x600031D")]
			[Address(RVA = "0xEBA2A8", Offset = "0xEBA2A8", VA = "0xEBA2A8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600031E")]
			[Address(RVA = "0xEBA2B0", Offset = "0xEBA2B0", VA = "0xEBA2B0")]
			set
			{
			}
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0xEBA314", Offset = "0xEBA314", VA = "0xEBA314")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0xEBABAC", Offset = "0xEBABAC", VA = "0xEBABAC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0xEBABB4", Offset = "0xEBABB4", VA = "0xEBABB4")]
		public bool HasCallback()
		{
			return default(bool);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0xEB6EB4", Offset = "0xEB6EB4", VA = "0xEB6EB4")]
		public void OnLocalize(bool Force = false)
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0xEBA668", Offset = "0xEBA668", VA = "0xEBA668")]
		public bool FindTarget()
		{
			return default(bool);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0xEBAC1C", Offset = "0xEBAC1C", VA = "0xEBAC1C")]
		public void GetFinalTerms(out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0xEBAD98", Offset = "0xEBAD98", VA = "0xEBAD98")]
		public string GetMainTargetsText()
		{
			return null;
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0xEBAE78", Offset = "0xEBAE78", VA = "0xEBAE78")]
		public void SetFinalTerms(string Main, string Secondary, out string primaryTerm, out string secondaryTerm, bool RemoveNonASCII)
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0xEBA268", Offset = "0xEBA268", VA = "0xEBA268")]
		public void SetTerm(string primary)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0xEBA2C0", Offset = "0xEBA2C0", VA = "0xEBA2C0")]
		public void SetTerm(string primary, string secondary)
		{
		}

		[Token(Token = "0x6000329")]
		internal T GetSecondaryTranslatedObj<T>(ref string mainTranslation, ref string secondaryTranslation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0xEBA358", Offset = "0xEBA358", VA = "0xEBA358")]
		public void UpdateAssetDictionary()
		{
		}

		[Token(Token = "0x600032B")]
		internal T GetObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600032C")]
		private T GetTranslatedObject<T>(string Translation) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xEBAEC0", Offset = "0xEBAEC0", VA = "0xEBAEC0")]
		private void DeserializeTranslation(string translation, out string value, out string secondary)
		{
		}

		[Token(Token = "0x600032E")]
		public T FindTranslatedObject<T>(string value) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0xEBB014", Offset = "0xEBB014", VA = "0xEBB014")]
		public bool HasTranslatedObject(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xEBB0C0", Offset = "0xEBB0C0", VA = "0xEBB0C0")]
		public void AddTranslatedObject(UnityEngine.Object Obj)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0xEBB174", Offset = "0xEBB174", VA = "0xEBB174")]
		public void SetGlobalLanguage(string Language)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xEBB1D8", Offset = "0xEBB1D8", VA = "0xEBB1D8")]
		public Localize()
		{
		}
	}
	[Token(Token = "0x2000061")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920E98", Offset = "0x920E98")]
	public class LocalizeDropdown : MonoBehaviour
	{
		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<string> _Terms;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xEBB530", Offset = "0xEBB530", VA = "0xEBB530")]
		public void Start()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xEBB6C8", Offset = "0xEBB6C8", VA = "0xEBB6C8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0xEBB758", Offset = "0xEBB758", VA = "0xEBB758")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xEBB5C8", Offset = "0xEBB5C8", VA = "0xEBB5C8")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0xEBB7CC", Offset = "0xEBB7CC", VA = "0xEBB7CC")]
		private void FillValues()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0xEBB9A8", Offset = "0xEBB9A8", VA = "0xEBB9A8")]
		public void UpdateLocalization()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0xEBBDF8", Offset = "0xEBBDF8", VA = "0xEBBDF8")]
		public void UpdateLocalizationTMPro()
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0xEBBC34", Offset = "0xEBBC34", VA = "0xEBBC34")]
		private void FillValuesTMPro()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0xEBC078", Offset = "0xEBC078", VA = "0xEBC078")]
		public LocalizeDropdown()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public static class LocalizationManager
	{
		[Token(Token = "0x2000114")]
		public delegate object _GetParam(string param);

		[Token(Token = "0x2000115")]
		public delegate void OnLocalizeCallback();

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211E8", Offset = "0x9211E8")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000833")]
			[Address(RVA = "0xEB2FFC", Offset = "0xEB2FFC", VA = "0xEB2FFC")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0xEB8A60", Offset = "0xEB8A60", VA = "0xEB8A60")]
			internal bool <GetAllLanguages>b__0(string x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9211F8", Offset = "0x9211F8")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400045F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<string> Languages;

			[Token(Token = "0x4000460")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Func<string, bool> <>9__0;

			[Token(Token = "0x6000835")]
			[Address(RVA = "0xEB3234", Offset = "0xEB3234", VA = "0xEB3234")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0xEB8ADC", Offset = "0xEB8ADC", VA = "0xEB8ADC")]
			internal bool <GetAllLanguagesCode>b__0(string x)
			{
				return default(bool);
			}
		}

		[Serializable]
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921208", Offset = "0x921208")]
		private sealed class <>c
		{
			[Token(Token = "0x4000461")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000462")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static _GetParam <>9__41_0;

			[Token(Token = "0x6000838")]
			[Address(RVA = "0xEB89F0", Offset = "0xEB89F0", VA = "0xEB89F0")]
			public <>c()
			{
			}

			[Token(Token = "0x6000839")]
			[Address(RVA = "0xEB89F8", Offset = "0xEB89F8", VA = "0xEB89F8")]
			internal object <ApplyLocalizationParams>b__41_0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921218", Offset = "0x921218")]
		private sealed class <>c__DisplayClass42_0
		{
			[Token(Token = "0x4000463")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject root;

			[Token(Token = "0x600083A")]
			[Address(RVA = "0xEB3CC8", Offset = "0xEB3CC8", VA = "0xEB3CC8")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0xEB8B58", Offset = "0xEB8B58", VA = "0xEB8B58")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921228", Offset = "0x921228")]
		private sealed class <>c__DisplayClass43_0
		{
			[Token(Token = "0x4000464")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Dictionary<string, object> parameters;

			[Token(Token = "0x600083C")]
			[Address(RVA = "0xEB3DA4", Offset = "0xEB3DA4", VA = "0xEB3DA4")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x600083D")]
			[Address(RVA = "0xEB8BD0", Offset = "0xEB8BD0", VA = "0xEB8BD0")]
			internal object <ApplyLocalizationParams>b__0(string p)
			{
				return null;
			}
		}

		[Token(Token = "0x200011B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921238", Offset = "0x921238")]
		private sealed class <Delayed_Import_Google>d__59 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000465")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000466")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000467")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000468")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public LanguageSourceData source;

			[Token(Token = "0x4000469")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool justCheck;

			[Token(Token = "0x170000D9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0xEB8EB4", Offset = "0xEB8EB4", VA = "0xEB8EB4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0xEB8F24", Offset = "0xEB8F24", VA = "0xEB8F24", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0xEB5818", Offset = "0xEB5818", VA = "0xEB5818")]
			[DebuggerHidden]
			public <Delayed_Import_Google>d__59(int <>1__state)
			{
			}

			[Token(Token = "0x600083F")]
			[Address(RVA = "0xEB8DFC", Offset = "0xEB8DFC", VA = "0xEB8DFC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0xEB8E00", Offset = "0xEB8E00", VA = "0xEB8E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000842")]
			[Address(RVA = "0xEB8EBC", Offset = "0xEB8EBC", VA = "0xEB8EBC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200011C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921248", Offset = "0x921248")]
		private sealed class <>c__DisplayClass69_0
		{
			[Token(Token = "0x400046A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ILocalizeTargetDescriptor desc;

			[Token(Token = "0x6000844")]
			[Address(RVA = "0xEB63C8", Offset = "0xEB63C8", VA = "0xEB63C8")]
			public <>c__DisplayClass69_0()
			{
			}

			[Token(Token = "0x6000845")]
			[Address(RVA = "0xEB8C58", Offset = "0xEB8C58", VA = "0xEB8C58")]
			internal bool <RegisterTarget>b__0(ILocalizeTargetDescriptor x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200011D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921258", Offset = "0x921258")]
		private sealed class <Coroutine_LocalizeAll>d__84 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400046B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400046C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x170000DB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000849")]
				[Address(RVA = "0xEB8D84", Offset = "0xEB8D84", VA = "0xEB8D84", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600084B")]
				[Address(RVA = "0xEB8DF4", Offset = "0xEB8DF4", VA = "0xEB8DF4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000846")]
			[Address(RVA = "0xEB6E88", Offset = "0xEB6E88", VA = "0xEB6E88")]
			[DebuggerHidden]
			public <Coroutine_LocalizeAll>d__84(int <>1__state)
			{
			}

			[Token(Token = "0x6000847")]
			[Address(RVA = "0xEB8CA4", Offset = "0xEB8CA4", VA = "0xEB8CA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000848")]
			[Address(RVA = "0xEB8CA8", Offset = "0xEB8CA8", VA = "0xEB8CA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600084A")]
			[Address(RVA = "0xEB8D8C", Offset = "0xEB8D8C", VA = "0xEB8D8C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string mCurrentLanguage;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static string mLanguageCode;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CultureInfo mCurrentCulture;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static bool mChangeCultureInfo;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public static bool IsRight2Left;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public static bool HasJoinedWords;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static List<ILocalizationParamsManager> ParamManagers;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string[] LanguagesRTL;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static List<LanguageSourceData> Sources;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] GlobalSources;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static string mCurrentDeviceLanguage;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static List<ILocalizeTargetDescriptor> mLocalizeTargets;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static bool mLocalizeIsScheduled;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private static bool mLocalizeIsScheduledWithForcedValue;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public static bool HighlightLocalizedTargets;

		[Token(Token = "0x1700004E")]
		public static string CurrentLanguage
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0xEAC838", Offset = "0xEAC838", VA = "0xEAC838")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0xEB1324", Offset = "0xEB1324", VA = "0xEB1324")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public static string CurrentLanguageCode
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0xEB1DB0", Offset = "0xEB1DB0", VA = "0xEB1DB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0xEB1E1C", Offset = "0xEB1E1C", VA = "0xEB1E1C")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public static string CurrentRegion
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0xEB2140", Offset = "0xEB2140", VA = "0xEB2140")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0xEB230C", Offset = "0xEB230C", VA = "0xEB230C")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public static string CurrentRegionCode
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0xEB250C", Offset = "0xEB250C", VA = "0xEB250C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0xEB25F8", Offset = "0xEB25F8", VA = "0xEB25F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public static CultureInfo CurrentCulture
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0xEB2720", Offset = "0xEB2720", VA = "0xEB2720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x14000003")]
		public static event OnLocalizeCallback OnLocalizeEvent
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0xEB63D0", Offset = "0xEB63D0", VA = "0xEB63D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92311C", Offset = "0x92311C")]
			add
			{
			}
			[Token(Token = "0x6000371")]
			[Address(RVA = "0xEB6500", Offset = "0xEB6500", VA = "0xEB6500")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92312C", Offset = "0x92312C")]
			remove
			{
			}
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0xEB0AB4", Offset = "0xEB0AB4", VA = "0xEB0AB4")]
		public static void InitializeIfNeeded()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0xEB12DC", Offset = "0xEB12DC", VA = "0xEB12DC")]
		public static string GetVersion()
		{
			return null;
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0xEADF14", Offset = "0xEADF14", VA = "0xEADF14")]
		public static int GetRequiredWebServiceVersion()
		{
			return default(int);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0xEAA720", Offset = "0xEAA720", VA = "0xEAA720")]
		public static string GetWebServiceURL([Optional] LanguageSourceData source)
		{
			return null;
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0xEB1BB4", Offset = "0xEB1BB4", VA = "0xEB1BB4")]
		public static void SetLanguageAndCode(string LanguageName, string LanguageCode, bool RememberLanguage = true, bool Force = false)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0xEB2788", Offset = "0xEB2788", VA = "0xEB2788")]
		private static CultureInfo CreateCultureForCode(string code)
		{
			return null;
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0xEB29A0", Offset = "0xEB29A0", VA = "0xEB29A0")]
		public static void EnableChangingCultureInfo(bool bEnable)
		{
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0xEB2888", Offset = "0xEB2888", VA = "0xEB2888")]
		private static void SetCurrentCultureInfo()
		{
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0xEB0DE4", Offset = "0xEB0DE4", VA = "0xEB0DE4")]
		private static void SelectStartupLanguage()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0xEB2B20", Offset = "0xEB2B20", VA = "0xEB2B20")]
		public static bool HasLanguage(string Language, bool AllowDiscartingRegion = true, bool Initialize = true, bool SkipDisabled = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0xEB1414", Offset = "0xEB1414", VA = "0xEB1414")]
		public static string GetSupportedLanguage(string Language, bool ignoreDisabled = false)
		{
			return null;
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0xEB1994", Offset = "0xEB1994", VA = "0xEB1994")]
		public static string GetLanguageCode(string Language)
		{
			return null;
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0xEB1F10", Offset = "0xEB1F10", VA = "0xEB1F10")]
		public static string GetLanguageFromCode(string Code, bool exactMatch = true)
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0xEB2D64", Offset = "0xEB2D64", VA = "0xEB2D64")]
		public static List<string> GetAllLanguages(bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0xEB3004", Offset = "0xEB3004", VA = "0xEB3004")]
		public static List<string> GetAllLanguagesCode(bool allowRegions = true, bool SkipDisabled = true)
		{
			return null;
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0xEB323C", Offset = "0xEB323C", VA = "0xEB323C")]
		public static bool IsLanguageEnabled(string Language)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0xEB3364", Offset = "0xEB3364", VA = "0xEB3364")]
		private static void LoadCurrentLanguage()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0xEB34D8", Offset = "0xEB34D8", VA = "0xEB34D8")]
		public static void PreviewLanguage(string NewLanguage)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0xEB0B9C", Offset = "0xEB0B9C", VA = "0xEB0B9C")]
		public static void AutoLoadGlobalParamManagers()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0xEB35C0", Offset = "0xEB35C0", VA = "0xEB35C0")]
		public static void ApplyLocalizationParams(ref string translation, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0xEB3BF4", Offset = "0xEB3BF4", VA = "0xEB3BF4")]
		public static void ApplyLocalizationParams(ref string translation, GameObject root, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0xEB3CD0", Offset = "0xEB3CD0", VA = "0xEB3CD0")]
		public static void ApplyLocalizationParams(ref string translation, Dictionary<string, object> parameters, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0xEB36D8", Offset = "0xEB36D8", VA = "0xEB36D8")]
		public static void ApplyLocalizationParams(ref string translation, _GetParam getParam, bool allowLocalizedParameters = true)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0xEB4684", Offset = "0xEB4684", VA = "0xEB4684")]
		internal static string GetLocalizationParam(string ParamName, GameObject root)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0xEB4978", Offset = "0xEB4978", VA = "0xEB4978")]
		private static string GetPluralType(MatchCollection matches, string langCode, _GetParam getParam)
		{
			return null;
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0xEB4BF0", Offset = "0xEB4BF0", VA = "0xEB4BF0")]
		public static string ApplyRTLfix(string line)
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0xEB4C5C", Offset = "0xEB4C5C", VA = "0xEB4C5C")]
		public static string ApplyRTLfix(string line, int maxCharacters, bool ignoreNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0xEB5178", Offset = "0xEB5178", VA = "0xEB5178")]
		public static string FixRTL_IfNeeded(string text, int maxCharacters = 0, bool ignoreNumber = false)
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0xEB2918", Offset = "0xEB2918", VA = "0xEB2918")]
		public static bool IsRTL(string Code)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0xEB0D48", Offset = "0xEB0D48", VA = "0xEB0D48")]
		public static bool UpdateSources()
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0xEB522C", Offset = "0xEB522C", VA = "0xEB522C")]
		private static void UnregisterDeletededSources()
		{
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0xEB5554", Offset = "0xEB5554", VA = "0xEB5554")]
		private static void RegisterSceneSources()
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0xEB535C", Offset = "0xEB535C", VA = "0xEB535C")]
		private static void RegisterSourceInResources()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0xEA6EC8", Offset = "0xEA6EC8", VA = "0xEA6EC8")]
		internal static void AddSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0xEB575C", Offset = "0xEB575C", VA = "0xEB575C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9230B8", Offset = "0x9230B8")]
		private static IEnumerator Delayed_Import_Google(LanguageSourceData source, float delay, bool justCheck)
		{
			return null;
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0xEA7814", Offset = "0xEA7814", VA = "0xEA7814")]
		internal static void RemoveSource(LanguageSourceData Source)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0xEB5844", Offset = "0xEB5844", VA = "0xEB5844")]
		public static bool IsGlobalSource(string SourceName)
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0xEB58CC", Offset = "0xEB58CC", VA = "0xEB58CC")]
		public static LanguageSourceData GetSourceContaining(string term, bool fallbackToFirst = true)
		{
			return null;
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0xEB5AF0", Offset = "0xEB5AF0", VA = "0xEB5AF0")]
		public static UnityEngine.Object FindAsset(string value)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0xEB5C50", Offset = "0xEB5C50", VA = "0xEB5C50")]
		public static void ApplyDownloadedDataFromGoogle()
		{
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0xEB2A54", Offset = "0xEB2A54", VA = "0xEB2A54")]
		public static string GetCurrentDeviceLanguage(bool force = false)
		{
			return null;
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0xEB5D60", Offset = "0xEB5D60", VA = "0xEB5D60")]
		private static void DetectDeviceLanguage()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0xEB6128", Offset = "0xEB6128", VA = "0xEB6128")]
		public static void RegisterTarget(ILocalizeTargetDescriptor desc)
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0xEB6630", Offset = "0xEB6630", VA = "0xEB6630")]
		public static string GetTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0xEB6918", Offset = "0xEB6918", VA = "0xEB6918")]
		public static string GetTermTranslation(string Term, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0xEB66F4", Offset = "0xEB66F4", VA = "0xEB66F4")]
		public static bool TryGetTranslation(string Term, out string Translation, bool FixForRTL = true, int maxLineLengthForRTL = 0, bool ignoreRTLnumbers = true, bool applyParameters = false, [Optional] GameObject localParametersRoot, [Optional] string overrideLanguage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000375")]
		public static T GetTranslatedObject<T>(string AssetName, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000376")]
		public static T GetTranslatedObjectByTermName<T>(string Term, [Optional] Localize optionalLocComp) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0xEB69C4", Offset = "0xEB69C4", VA = "0xEB69C4")]
		public static string GetAppName(string languageCode)
		{
			return null;
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xEA770C", Offset = "0xEA770C", VA = "0xEA770C")]
		public static void LocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xEB6E28", Offset = "0xEB6E28", VA = "0xEB6E28")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x92313C", Offset = "0x92313C")]
		private static IEnumerator Coroutine_LocalizeAll()
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xEB6C38", Offset = "0xEB6C38", VA = "0xEB6C38")]
		private static void DoLocalizeAll(bool Force = false)
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0xEB7BE8", Offset = "0xEB7BE8", VA = "0xEB7BE8")]
		public static List<string> GetCategories()
		{
			return null;
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xEB7D28", Offset = "0xEB7D28", VA = "0xEB7D28")]
		public static List<string> GetTermsList([Optional] string Category)
		{
			return null;
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0xEB7FD4", Offset = "0xEB7FD4", VA = "0xEB7FD4")]
		public static TermData GetTermData(string term)
		{
			return null;
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xEB44FC", Offset = "0xEB44FC", VA = "0xEB44FC")]
		public static TermData GetTermData(string term, out LanguageSourceData source)
		{
			return null;
		}
	}
	[Token(Token = "0x2000063")]
	public abstract class ILocalizeTarget : ScriptableObject
	{
		[Token(Token = "0x6000380")]
		public abstract bool IsValid(Localize cmp);

		[Token(Token = "0x6000381")]
		public abstract void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm);

		[Token(Token = "0x6000382")]
		public abstract void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation);

		[Token(Token = "0x6000383")]
		public abstract bool CanUseSecondaryTerm();

		[Token(Token = "0x6000384")]
		public abstract bool AllowMainTermToBeRTL();

		[Token(Token = "0x6000385")]
		public abstract bool AllowSecondTermToBeRTL();

		[Token(Token = "0x6000386")]
		public abstract eTermType GetPrimaryTermType(Localize cmp);

		[Token(Token = "0x6000387")]
		public abstract eTermType GetSecondaryTermType(Localize cmp);

		[Token(Token = "0x6000388")]
		[Address(RVA = "0xEA5790", Offset = "0xEA5790", VA = "0xEA5790")]
		protected ILocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public abstract class LocalizeTarget<T> : ILocalizeTarget where T : UnityEngine.Object
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T mTarget;

		[Token(Token = "0x6000389")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x600038A")]
		protected LocalizeTarget()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class ILocalizeTargetDescriptor
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int Priority;

		[Token(Token = "0x600038B")]
		public abstract bool CanLocalize(Localize cmp);

		[Token(Token = "0x600038C")]
		public abstract ILocalizeTarget CreateTarget(Localize cmp);

		[Token(Token = "0x600038D")]
		public abstract Type GetTargetType();

		[Token(Token = "0x600038E")]
		[Address(RVA = "0xEA5798", Offset = "0xEA5798", VA = "0xEA5798")]
		protected ILocalizeTargetDescriptor()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public abstract class LocalizeTargetDesc<T> : ILocalizeTargetDescriptor where T : ILocalizeTarget
	{
		[Token(Token = "0x600038F")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000390")]
		public override Type GetTargetType()
		{
			return null;
		}

		[Token(Token = "0x6000391")]
		protected LocalizeTargetDesc()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class LocalizeTargetDesc_Type<T, G> : LocalizeTargetDesc<G> where T : UnityEngine.Object where G : LocalizeTarget<T>
	{
		[Token(Token = "0x6000392")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		public override ILocalizeTarget CreateTarget(Localize cmp)
		{
			return null;
		}

		[Token(Token = "0x6000394")]
		public LocalizeTargetDesc_Type()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class LocalizeTarget_TextMeshPro_Label : LocalizeTarget<TextMeshPro>
	{
		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0xEBC1E4", Offset = "0xEBC1E4", VA = "0xEBC1E4")]
		static LocalizeTarget_TextMeshPro_Label()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0xEBC1E8", Offset = "0xEBC1E8", VA = "0xEBC1E8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9231A0", Offset = "0x9231A0")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0xEBC2B0", Offset = "0xEBC2B0", VA = "0xEBC2B0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0xEBC2B8", Offset = "0xEBC2B8", VA = "0xEBC2B8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0xEBC2C0", Offset = "0xEBC2C0", VA = "0xEBC2C0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0xEBC2C8", Offset = "0xEBC2C8", VA = "0xEBC2C8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0xEBC2D0", Offset = "0xEBC2D0", VA = "0xEBC2D0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0xEBC2D8", Offset = "0xEBC2D8", VA = "0xEBC2D8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0xEBC42C", Offset = "0xEBC42C", VA = "0xEBC42C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0xEBCB80", Offset = "0xEBCB80", VA = "0xEBCB80")]
		internal static TMP_FontAsset GetTMPFontFromMaterial(Localize cmp, string matName)
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xEBCE8C", Offset = "0xEBCE8C", VA = "0xEBCE8C")]
		internal static void InitAlignment_TMPro(bool isRTL, TextAlignmentOptions alignment, out TextAlignmentOptions alignLTR, out TextAlignmentOptions alignRTL)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xEBCA20", Offset = "0xEBCA20", VA = "0xEBCA20")]
		internal static void SetFont(TMP_Text label, TMP_FontAsset newFont)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xEBCD40", Offset = "0xEBCD40", VA = "0xEBCD40")]
		internal static void SetMaterial(TMP_Text label, Material newMat)
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0xEBD0A0", Offset = "0xEBD0A0", VA = "0xEBD0A0")]
		public LocalizeTarget_TextMeshPro_Label()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class LocalizeTarget_TextMeshPro_UGUI : LocalizeTarget<TextMeshProUGUI>
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextAlignmentOptions mAlignment_RTL;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TextAlignmentOptions mAlignment_LTR;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool mAlignmentWasRTL;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool mInitializeAlignment;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xEBD104", Offset = "0xEBD104", VA = "0xEBD104")]
		static LocalizeTarget_TextMeshPro_UGUI()
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0xEBD108", Offset = "0xEBD108", VA = "0xEBD108")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9231B4", Offset = "0x9231B4")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xEBD1D0", Offset = "0xEBD1D0", VA = "0xEBD1D0", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xEBD1D8", Offset = "0xEBD1D8", VA = "0xEBD1D8", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xEBD1E0", Offset = "0xEBD1E0", VA = "0xEBD1E0", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0xEBD1E8", Offset = "0xEBD1E8", VA = "0xEBD1E8", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xEBD1F0", Offset = "0xEBD1F0", VA = "0xEBD1F0", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0xEBD1F8", Offset = "0xEBD1F8", VA = "0xEBD1F8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xEBD34C", Offset = "0xEBD34C", VA = "0xEBD34C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xEBD940", Offset = "0xEBD940", VA = "0xEBD940")]
		public LocalizeTarget_TextMeshPro_UGUI()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class LocalizeTarget_UnityStandard_AudioSource : LocalizeTarget<AudioSource>
	{
		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xEBD9A4", Offset = "0xEBD9A4", VA = "0xEBD9A4")]
		static LocalizeTarget_UnityStandard_AudioSource()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0xEBD9A8", Offset = "0xEBD9A8", VA = "0xEBD9A8")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9231C8", Offset = "0x9231C8")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xEBDA70", Offset = "0xEBDA70", VA = "0xEBDA70", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0xEBDA78", Offset = "0xEBDA78", VA = "0xEBDA78", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xEBDA80", Offset = "0xEBDA80", VA = "0xEBDA80", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xEBDA88", Offset = "0xEBDA88", VA = "0xEBDA88", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xEBDA90", Offset = "0xEBDA90", VA = "0xEBDA90", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0xEBDA98", Offset = "0xEBDA98", VA = "0xEBDA98", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xEBDB90", Offset = "0xEBDB90", VA = "0xEBDB90", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0xEBDD58", Offset = "0xEBDD58", VA = "0xEBDD58")]
		public LocalizeTarget_UnityStandard_AudioSource()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class LocalizeTargetDesc_Child : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Child>
	{
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xEBC0E8", Offset = "0xEBC0E8", VA = "0xEBC0E8", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xEBC13C", Offset = "0xEBC13C", VA = "0xEBC13C")]
		public LocalizeTargetDesc_Child()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class LocalizeTarget_UnityStandard_Child : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xEBDDA8", Offset = "0xEBDDA8", VA = "0xEBDDA8")]
		static LocalizeTarget_UnityStandard_Child()
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0xEBDDAC", Offset = "0xEBDDAC", VA = "0xEBDDAC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9231DC", Offset = "0x9231DC")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xEBDE68", Offset = "0xEBDE68", VA = "0xEBDE68", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0xEBDEBC", Offset = "0xEBDEBC", VA = "0xEBDEBC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xEBDEC4", Offset = "0xEBDEC4", VA = "0xEBDEC4", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xEBDECC", Offset = "0xEBDECC", VA = "0xEBDECC", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xEBDED4", Offset = "0xEBDED4", VA = "0xEBDED4", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0xEBDEDC", Offset = "0xEBDEDC", VA = "0xEBDEDC", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xEBDEE4", Offset = "0xEBDEE4", VA = "0xEBDEE4", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0xEBDF30", Offset = "0xEBDF30", VA = "0xEBDF30", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xEBE0DC", Offset = "0xEBE0DC", VA = "0xEBE0DC")]
		public LocalizeTarget_UnityStandard_Child()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class LocalizeTarget_UnityStandard_MeshRenderer : LocalizeTarget<MeshRenderer>
	{
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xEBE12C", Offset = "0xEBE12C", VA = "0xEBE12C")]
		static LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xEBE130", Offset = "0xEBE130", VA = "0xEBE130")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x9231F0", Offset = "0x9231F0")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xEBE1F8", Offset = "0xEBE1F8", VA = "0xEBE1F8", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xEBE200", Offset = "0xEBE200", VA = "0xEBE200", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xEBE208", Offset = "0xEBE208", VA = "0xEBE208", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xEBE210", Offset = "0xEBE210", VA = "0xEBE210", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xEBE218", Offset = "0xEBE218", VA = "0xEBE218", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xEBE220", Offset = "0xEBE220", VA = "0xEBE220", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0xEBE46C", Offset = "0xEBE46C", VA = "0xEBE46C", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xEBE68C", Offset = "0xEBE68C", VA = "0xEBE68C")]
		public LocalizeTarget_UnityStandard_MeshRenderer()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class LocalizeTargetDesc_Prefab : LocalizeTargetDesc<LocalizeTarget_UnityStandard_Prefab>
	{
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0xEBC18C", Offset = "0xEBC18C", VA = "0xEBC18C", Slot = "4")]
		public override bool CanLocalize(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xEBC194", Offset = "0xEBC194", VA = "0xEBC194")]
		public LocalizeTargetDesc_Prefab()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class LocalizeTarget_UnityStandard_Prefab : LocalizeTarget<GameObject>
	{
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xEBE6DC", Offset = "0xEBE6DC", VA = "0xEBE6DC")]
		static LocalizeTarget_UnityStandard_Prefab()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xEBE6E0", Offset = "0xEBE6E0", VA = "0xEBE6E0")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x923204", Offset = "0x923204")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0xEBE79C", Offset = "0xEBE79C", VA = "0xEBE79C", Slot = "4")]
		public override bool IsValid(Localize cmp)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xEBE7A4", Offset = "0xEBE7A4", VA = "0xEBE7A4", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0xEBE7AC", Offset = "0xEBE7AC", VA = "0xEBE7AC", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xEBE7B4", Offset = "0xEBE7B4", VA = "0xEBE7B4", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xEBE7BC", Offset = "0xEBE7BC", VA = "0xEBE7BC", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xEBE7C4", Offset = "0xEBE7C4", VA = "0xEBE7C4", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0xEBE7CC", Offset = "0xEBE7CC", VA = "0xEBE7CC", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xEBE818", Offset = "0xEBE818", VA = "0xEBE818", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0xEBEA98", Offset = "0xEBEA98", VA = "0xEBEA98")]
		private Transform InstantiateNewPrefab(Localize cmp, string mainTranslation)
		{
			return null;
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xEBECE0", Offset = "0xEBECE0", VA = "0xEBECE0")]
		public LocalizeTarget_UnityStandard_Prefab()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class LocalizeTarget_UnityStandard_SpriteRenderer : LocalizeTarget<SpriteRenderer>
	{
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xEBED30", Offset = "0xEBED30", VA = "0xEBED30")]
		static LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xEBED34", Offset = "0xEBED34", VA = "0xEBED34")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x923218", Offset = "0x923218")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0xEBEDFC", Offset = "0xEBEDFC", VA = "0xEBEDFC", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xEBEE04", Offset = "0xEBEE04", VA = "0xEBEE04", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0xEBEE0C", Offset = "0xEBEE0C", VA = "0xEBEE0C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xEBEE14", Offset = "0xEBEE14", VA = "0xEBEE14", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xEBEE1C", Offset = "0xEBEE1C", VA = "0xEBEE1C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xEBEE24", Offset = "0xEBEE24", VA = "0xEBEE24", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0xEBEF20", Offset = "0xEBEF20", VA = "0xEBEF20", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xEBF044", Offset = "0xEBF044", VA = "0xEBF044")]
		public LocalizeTarget_UnityStandard_SpriteRenderer()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class LocalizeTarget_UnityStandard_TextMesh : LocalizeTarget<TextMesh>
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAlignment mAlignment_RTL;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAlignment mAlignment_LTR;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0xEBF094", Offset = "0xEBF094", VA = "0xEBF094")]
		static LocalizeTarget_UnityStandard_TextMesh()
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xEBF098", Offset = "0xEBF098", VA = "0xEBF098")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x92322C", Offset = "0x92322C")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xEBF160", Offset = "0xEBF160", VA = "0xEBF160", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xEBF168", Offset = "0xEBF168", VA = "0xEBF168", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0xEBF170", Offset = "0xEBF170", VA = "0xEBF170", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xEBF178", Offset = "0xEBF178", VA = "0xEBF178", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0xEBF180", Offset = "0xEBF180", VA = "0xEBF180", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xEBF188", Offset = "0xEBF188", VA = "0xEBF188", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xEBF2E8", Offset = "0xEBF2E8", VA = "0xEBF2E8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xEBF5E8", Offset = "0xEBF5E8", VA = "0xEBF5E8")]
		public LocalizeTarget_UnityStandard_TextMesh()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class LocalizeTarget_UnityUI_Image : LocalizeTarget<Image>
	{
		[Token(Token = "0x60003F0")]
		[Address(RVA = "0xEBF648", Offset = "0xEBF648", VA = "0xEBF648")]
		static LocalizeTarget_UnityUI_Image()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xEBF64C", Offset = "0xEBF64C", VA = "0xEBF64C")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x923240", Offset = "0x923240")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0xEBF714", Offset = "0xEBF714", VA = "0xEBF714", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xEBF71C", Offset = "0xEBF71C", VA = "0xEBF71C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xEBF724", Offset = "0xEBF724", VA = "0xEBF724", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xEBF72C", Offset = "0xEBF72C", VA = "0xEBF72C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0xEBF7D0", Offset = "0xEBF7D0", VA = "0xEBF7D0", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xEBF7D8", Offset = "0xEBF7D8", VA = "0xEBF7D8", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0xEBF9CC", Offset = "0xEBF9CC", VA = "0xEBF9CC", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xEBFAF0", Offset = "0xEBFAF0", VA = "0xEBFAF0")]
		public LocalizeTarget_UnityUI_Image()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class LocalizeTarget_UnityUI_RawImage : LocalizeTarget<RawImage>
	{
		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xEBFB40", Offset = "0xEBFB40", VA = "0xEBFB40")]
		static LocalizeTarget_UnityUI_RawImage()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xEBFB44", Offset = "0xEBFB44", VA = "0xEBFB44")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x923254", Offset = "0x923254")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0xEBFC0C", Offset = "0xEBFC0C", VA = "0xEBFC0C", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xEBFC14", Offset = "0xEBFC14", VA = "0xEBFC14", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0xEBFC1C", Offset = "0xEBFC1C", VA = "0xEBFC1C", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xEBFC24", Offset = "0xEBFC24", VA = "0xEBFC24", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xEBFC2C", Offset = "0xEBFC2C", VA = "0xEBFC2C", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xEBFC34", Offset = "0xEBFC34", VA = "0xEBFC34", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0xEBFD34", Offset = "0xEBFD34", VA = "0xEBFD34", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xEBFE58", Offset = "0xEBFE58", VA = "0xEBFE58")]
		public LocalizeTarget_UnityUI_RawImage()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class LocalizeTarget_UnityUI_Text : LocalizeTarget<Text>
	{
		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextAnchor mAlignment_RTL;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private TextAnchor mAlignment_LTR;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool mAlignmentWasRTL;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool mInitializeAlignment;

		[Token(Token = "0x6000404")]
		[Address(RVA = "0xEBFEA8", Offset = "0xEBFEA8", VA = "0xEBFEA8")]
		static LocalizeTarget_UnityUI_Text()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0xEBFEAC", Offset = "0xEBFEAC", VA = "0xEBFEAC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x923268", Offset = "0x923268")]
		private static void AutoRegister()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0xEBFF74", Offset = "0xEBFF74", VA = "0xEBFF74", Slot = "10")]
		public override eTermType GetPrimaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0xEBFF7C", Offset = "0xEBFF7C", VA = "0xEBFF7C", Slot = "11")]
		public override eTermType GetSecondaryTermType(Localize cmp)
		{
			return default(eTermType);
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0xEBFF84", Offset = "0xEBFF84", VA = "0xEBFF84", Slot = "7")]
		public override bool CanUseSecondaryTerm()
		{
			return default(bool);
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0xEBFF8C", Offset = "0xEBFF8C", VA = "0xEBFF8C", Slot = "8")]
		public override bool AllowMainTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0xEBFF94", Offset = "0xEBFF94", VA = "0xEBFF94", Slot = "9")]
		public override bool AllowSecondTermToBeRTL()
		{
			return default(bool);
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0xEBFF9C", Offset = "0xEBFF9C", VA = "0xEBFF9C", Slot = "5")]
		public override void GetFinalTerms(Localize cmp, string Main, string Secondary, out string primaryTerm, out string secondaryTerm)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xEC00F8", Offset = "0xEC00F8", VA = "0xEC00F8", Slot = "6")]
		public override void DoLocalize(Localize cmp, string mainTranslation, string secondaryTranslation)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xEC04A4", Offset = "0xEC04A4", VA = "0xEC04A4")]
		private void InitAlignment(bool isRTL, TextAnchor alignment, out TextAnchor alignLTR, out TextAnchor alignRTL)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xEC0564", Offset = "0xEC0564", VA = "0xEC0564")]
		public LocalizeTarget_UnityUI_Text()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public enum eTermType
	{
		[Token(Token = "0x40001D1")]
		Text,
		[Token(Token = "0x40001D2")]
		Font,
		[Token(Token = "0x40001D3")]
		Texture,
		[Token(Token = "0x40001D4")]
		AudioClip,
		[Token(Token = "0x40001D5")]
		GameObject,
		[Token(Token = "0x40001D6")]
		Sprite,
		[Token(Token = "0x40001D7")]
		Material,
		[Token(Token = "0x40001D8")]
		Child,
		[Token(Token = "0x40001D9")]
		Mesh,
		[Token(Token = "0x40001DA")]
		TextMeshPFont,
		[Token(Token = "0x40001DB")]
		Object
	}
	[Token(Token = "0x2000076")]
	public enum TranslationFlag : byte
	{
		[Token(Token = "0x40001DD")]
		Normal = 1,
		[Token(Token = "0x40001DE")]
		AutoTranslated
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public class TermData
	{
		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Term;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public eTermType TermType;

		[NonSerialized]
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string Description;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string[] Languages;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public byte[] Flags;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] Languages_Touch;

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x11A2B4C", Offset = "0x11A2B4C", VA = "0x11A2B4C")]
		public string GetTranslation(int idx, [Optional] string specialization, bool editMode = false)
		{
			return null;
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x11A2C88", Offset = "0x11A2C88", VA = "0x11A2C88")]
		public void SetTranslation(int idx, string translation, [Optional] string specialization)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x11A2D98", Offset = "0x11A2D98", VA = "0x11A2D98")]
		public void RemoveSpecialization(string specialization)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x11A2DF8", Offset = "0x11A2DF8", VA = "0x11A2DF8")]
		public void RemoveSpecialization(int idx, string specialization)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x11A2FA4", Offset = "0x11A2FA4", VA = "0x11A2FA4")]
		public bool IsAutoTranslated(int idx, bool IsTouch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x11A2FFC", Offset = "0x11A2FFC", VA = "0x11A2FFC")]
		public void Validate()
		{
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x11A32C0", Offset = "0x11A32C0", VA = "0x11A32C0")]
		public bool IsTerm(string name, bool allowCategoryMistmatch)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x11A3358", Offset = "0x11A3358", VA = "0x11A3358")]
		public bool HasSpecializations()
		{
			return default(bool);
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x11A347C", Offset = "0x11A347C", VA = "0x11A347C")]
		public List<string> GetAllSpecializations()
		{
			return null;
		}

		[Token(Token = "0x6000418")]
		[Address(RVA = "0x11A3580", Offset = "0x11A3580", VA = "0x11A3580")]
		public TermData()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class TermsPopup : PropertyAttribute
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9217E8", Offset = "0x9217E8")]
		private string <Filter>k__BackingField;

		[Token(Token = "0x17000053")]
		public string Filter
		{
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x11A3644", Offset = "0x11A3644", VA = "0x11A3644")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92327C", Offset = "0x92327C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x11A363C", Offset = "0x11A363C", VA = "0x11A363C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x92328C", Offset = "0x92328C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x11A3610", Offset = "0x11A3610", VA = "0x11A3610")]
		public TermsPopup(string filter = "")
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class AutoChangeCultureInfo : MonoBehaviour
	{
		[Token(Token = "0x600041C")]
		[Address(RVA = "0x10A302C", Offset = "0x10A302C", VA = "0x10A302C")]
		public void Start()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x10A3090", Offset = "0x10A3090", VA = "0x10A3090")]
		public AutoChangeCultureInfo()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class CoroutineManager : MonoBehaviour
	{
		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static CoroutineManager mInstance;

		[Token(Token = "0x17000054")]
		private static CoroutineManager pInstance
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x10A37A0", Offset = "0x10A37A0", VA = "0x10A37A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x10A38F0", Offset = "0x10A38F0", VA = "0x10A38F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x10A3984", Offset = "0x10A3984", VA = "0x10A3984")]
		public static Coroutine Start(IEnumerator coroutine)
		{
			return null;
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x10A39BC", Offset = "0x10A39BC", VA = "0x10A39BC")]
		public CoroutineManager()
		{
		}
	}
	[Token(Token = "0x200007B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920ED0", Offset = "0x920ED0")]
	public class CustomLocalizeCallback : MonoBehaviour
	{
		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent _OnLocalize;

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x10A39C4", Offset = "0x10A39C4", VA = "0x10A39C4")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x10A3A88", Offset = "0x10A3A88", VA = "0x10A3A88")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x10A3B1C", Offset = "0x10A3B1C", VA = "0x10A3B1C")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x10A3B4C", Offset = "0x10A3B4C", VA = "0x10A3B4C")]
		public CustomLocalizeCallback()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class HindiFixer
	{
		[Serializable]
		[Token(Token = "0x200011E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921268", Offset = "0x921268")]
		private sealed class <>c
		{
			[Token(Token = "0x400046D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400046E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__0_0;

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x10B11E0", Offset = "0x10B11E0", VA = "0x10B11E0")]
			public <>c()
			{
			}

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x10B11E8", Offset = "0x10B11E8", VA = "0x10B11E8")]
			internal bool <Fix>b__0_0(char x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x10B09AC", Offset = "0x10B09AC", VA = "0x10B09AC")]
		internal static string Fix(string text)
		{
			return null;
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x10B1174", Offset = "0x10B1174", VA = "0x10B1174")]
		public HindiFixer()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public static class I2Utils
	{
		[Serializable]
		[Token(Token = "0x200011F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921278", Offset = "0x921278")]
		private sealed class <>c
		{
			[Token(Token = "0x400046F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000470")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<char, bool> <>9__6_0;

			[Token(Token = "0x6000850")]
			[Address(RVA = "0xEA577C", Offset = "0xEA577C", VA = "0xEA577C")]
			public <>c()
			{
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0xEA5784", Offset = "0xEA5784", VA = "0xEA5784")]
			internal bool <SplitLine>b__6_0(char c)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001E8")]
		public const string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";

		[Token(Token = "0x40001E9")]
		public const string NumberChars = "0123456789";

		[Token(Token = "0x40001EA")]
		public const string ValidNameSymbols = ".-_$#@*()[]{}+:?!&',^=<>~`";

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xEA44DC", Offset = "0xEA44DC", VA = "0xEA44DC")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xEA45F0", Offset = "0xEA45F0", VA = "0xEA45F0")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xEA4898", Offset = "0xEA4898", VA = "0xEA4898")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0xEA494C", Offset = "0xEA494C", VA = "0xEA494C")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xEA4CA4", Offset = "0xEA4CA4", VA = "0xEA4CA4")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default(bool);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0xEA48CC", Offset = "0xEA48CC", VA = "0xEA48CC")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xEA4E90", Offset = "0xEA4E90", VA = "0xEA4E90")]
		public static bool RemoveResourcesPath(ref string sPath)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xEA51A8", Offset = "0xEA51A8", VA = "0xEA51A8")]
		public static bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xEA51B0", Offset = "0xEA51B0", VA = "0xEA51B0")]
		public static string GetPath(this Transform tr)
		{
			return null;
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0xEA52A0", Offset = "0xEA52A0", VA = "0xEA52A0")]
		public static Transform FindObject(string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xEA52CC", Offset = "0xEA52CC", VA = "0xEA52CC")]
		public static Transform FindObject(Scene scene, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0xEA5478", Offset = "0xEA5478", VA = "0xEA5478")]
		public static Transform FindObject(Transform root, string objectPath)
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		public static H FindInParents<H>(Transform tr) where H : Component
		{
			return null;
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xEA5600", Offset = "0xEA5600", VA = "0xEA5600")]
		public static string GetCaptureMatch(Match match)
		{
			return null;
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xEA56EC", Offset = "0xEA56EC", VA = "0xEA56EC")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
	[Token(Token = "0x200007E")]
	public interface ILocalizationParamsManager
	{
		[Token(Token = "0x6000437")]
		string GetParameterValue(string Param);
	}
	[Token(Token = "0x200007F")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x2000120")]
		public struct ParamValue
		{
			[Token(Token = "0x4000471")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xEB8FAC", Offset = "0xEB8FAC", VA = "0xEB8FAC", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0xEB9098", Offset = "0xEB9098", VA = "0xEB9098")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xEB9218", Offset = "0xEB9218", VA = "0xEB9218")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xEB92C8", Offset = "0xEB92C8", VA = "0xEB92C8", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xEB92D8", Offset = "0xEB92D8", VA = "0xEB92D8")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0xEB93D0", Offset = "0xEB93D0", VA = "0xEB93D0")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xEB945C", Offset = "0xEB945C", VA = "0xEB945C")]
		public LocalizationParamsManager()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public struct LocalizedString
	{
		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string mTerm;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public bool mRTL_IgnoreArabicFix;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int mRTL_MaxLineLength;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool mRTL_ConvertNumbers;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool m_DontLocalizeParameters;

		[Token(Token = "0x600043F")]
		[Address(RVA = "0xEC05C4", Offset = "0xEC05C4", VA = "0xEC05C4")]
		public static implicit operator string(LocalizedString s)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xEC0690", Offset = "0xEC0690", VA = "0xEC0690")]
		public static implicit operator LocalizedString(string term)
		{
			return default(LocalizedString);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x9D73A8", Offset = "0x9D73A8", VA = "0x9D73A8")]
		public LocalizedString(LocalizedString str)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x9D73EC", Offset = "0x9D73EC", VA = "0x9D73EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x2000081")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x119A940", Offset = "0x119A940", VA = "0x119A940", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x119AA3C", Offset = "0x119AA3C", VA = "0x119AA3C", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x119AAC8", Offset = "0x119AAC8", VA = "0x119AAC8", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x119AAD0", Offset = "0x119AAD0", VA = "0x119AAD0")]
		public RegisterGlobalParameters()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public interface IResourceManager_Bundles
	{
		[Token(Token = "0x6000447")]
		UnityEngine.Object LoadFromBundle(string path, Type assetType);
	}
	[Token(Token = "0x2000083")]
	public class ResourceManager : MonoBehaviour
	{
		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static ResourceManager mInstance;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<IResourceManager_Bundles> mBundleManagers;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UnityEngine.Object[] Assets;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<string, UnityEngine.Object> mResourcesCache;

		[Token(Token = "0x17000055")]
		public static ResourceManager pInstance
		{
			[Token(Token = "0x6000448")]
			[Address(RVA = "0x119AAD8", Offset = "0x119AAD8", VA = "0x119AAD8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x119AEAC", Offset = "0x119AEAC", VA = "0x119AEAC")]
		public static void MyOnLevelWasLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600044A")]
		public T GetAsset<T>(string Name) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x119AF98", Offset = "0x119AF98", VA = "0x119AF98")]
		private UnityEngine.Object FindAsset(string Name)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x119B11C", Offset = "0x119B11C", VA = "0x119B11C")]
		public bool HasAsset(UnityEngine.Object Obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600044D")]
		public T LoadFromResources<T>(string Path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		public T LoadFromBundle<T>(string path) where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x119AF24", Offset = "0x119AF24", VA = "0x119AF24")]
		public void CleanResourceCache()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x119B18C", Offset = "0x119B18C", VA = "0x119B18C")]
		public ResourceManager()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class RTLFixer
	{
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1196E68", Offset = "0x1196E68", VA = "0x1196E68")]
		public static string Fix(string str)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1197160", Offset = "0x1197160", VA = "0x1197160")]
		public static string Fix(string str, bool rtl)
		{
			return null;
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1196E74", Offset = "0x1196E74", VA = "0x1196E74")]
		public static string Fix(string str, bool showTashkeel, bool useHinduNumbers)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x11989F4", Offset = "0x11989F4", VA = "0x11989F4")]
		public RTLFixer()
		{
		}
	}
	[Token(Token = "0x2000085")]
	internal enum IsolatedArabicLetters
	{
		[Token(Token = "0x40001F7")]
		Hamza = 65152,
		[Token(Token = "0x40001F8")]
		Alef = 65165,
		[Token(Token = "0x40001F9")]
		AlefHamza = 65155,
		[Token(Token = "0x40001FA")]
		WawHamza = 65157,
		[Token(Token = "0x40001FB")]
		AlefMaksoor = 65159,
		[Token(Token = "0x40001FC")]
		AlefMaksora = 64508,
		[Token(Token = "0x40001FD")]
		HamzaNabera = 65161,
		[Token(Token = "0x40001FE")]
		Ba = 65167,
		[Token(Token = "0x40001FF")]
		Ta = 65173,
		[Token(Token = "0x4000200")]
		Tha2 = 65177,
		[Token(Token = "0x4000201")]
		Jeem = 65181,
		[Token(Token = "0x4000202")]
		H7aa = 65185,
		[Token(Token = "0x4000203")]
		Khaa2 = 65189,
		[Token(Token = "0x4000204")]
		Dal = 65193,
		[Token(Token = "0x4000205")]
		Thal = 65195,
		[Token(Token = "0x4000206")]
		Ra2 = 65197,
		[Token(Token = "0x4000207")]
		Zeen = 65199,
		[Token(Token = "0x4000208")]
		Seen = 65201,
		[Token(Token = "0x4000209")]
		Sheen = 65205,
		[Token(Token = "0x400020A")]
		S9a = 65209,
		[Token(Token = "0x400020B")]
		Dha = 65213,
		[Token(Token = "0x400020C")]
		T6a = 65217,
		[Token(Token = "0x400020D")]
		T6ha = 65221,
		[Token(Token = "0x400020E")]
		Ain = 65225,
		[Token(Token = "0x400020F")]
		Gain = 65229,
		[Token(Token = "0x4000210")]
		Fa = 65233,
		[Token(Token = "0x4000211")]
		Gaf = 65237,
		[Token(Token = "0x4000212")]
		Kaf = 65241,
		[Token(Token = "0x4000213")]
		Lam = 65245,
		[Token(Token = "0x4000214")]
		Meem = 65249,
		[Token(Token = "0x4000215")]
		Noon = 65253,
		[Token(Token = "0x4000216")]
		Ha = 65257,
		[Token(Token = "0x4000217")]
		Waw = 65261,
		[Token(Token = "0x4000218")]
		Ya = 65265,
		[Token(Token = "0x4000219")]
		AlefMad = 65153,
		[Token(Token = "0x400021A")]
		TaMarboota = 65171,
		[Token(Token = "0x400021B")]
		PersianPe = 64342,
		[Token(Token = "0x400021C")]
		PersianChe = 64378,
		[Token(Token = "0x400021D")]
		PersianZe = 64394,
		[Token(Token = "0x400021E")]
		PersianGaf = 64402,
		[Token(Token = "0x400021F")]
		PersianGaf2 = 64398
	}
	[Token(Token = "0x2000086")]
	internal enum GeneralArabicLetters
	{
		[Token(Token = "0x4000221")]
		Hamza = 1569,
		[Token(Token = "0x4000222")]
		Alef = 1575,
		[Token(Token = "0x4000223")]
		AlefHamza = 1571,
		[Token(Token = "0x4000224")]
		WawHamza = 1572,
		[Token(Token = "0x4000225")]
		AlefMaksoor = 1573,
		[Token(Token = "0x4000226")]
		AlefMagsora = 1609,
		[Token(Token = "0x4000227")]
		HamzaNabera = 1574,
		[Token(Token = "0x4000228")]
		Ba = 1576,
		[Token(Token = "0x4000229")]
		Ta = 1578,
		[Token(Token = "0x400022A")]
		Tha2 = 1579,
		[Token(Token = "0x400022B")]
		Jeem = 1580,
		[Token(Token = "0x400022C")]
		H7aa = 1581,
		[Token(Token = "0x400022D")]
		Khaa2 = 1582,
		[Token(Token = "0x400022E")]
		Dal = 1583,
		[Token(Token = "0x400022F")]
		Thal = 1584,
		[Token(Token = "0x4000230")]
		Ra2 = 1585,
		[Token(Token = "0x4000231")]
		Zeen = 1586,
		[Token(Token = "0x4000232")]
		Seen = 1587,
		[Token(Token = "0x4000233")]
		Sheen = 1588,
		[Token(Token = "0x4000234")]
		S9a = 1589,
		[Token(Token = "0x4000235")]
		Dha = 1590,
		[Token(Token = "0x4000236")]
		T6a = 1591,
		[Token(Token = "0x4000237")]
		T6ha = 1592,
		[Token(Token = "0x4000238")]
		Ain = 1593,
		[Token(Token = "0x4000239")]
		Gain = 1594,
		[Token(Token = "0x400023A")]
		Fa = 1601,
		[Token(Token = "0x400023B")]
		Gaf = 1602,
		[Token(Token = "0x400023C")]
		Kaf = 1603,
		[Token(Token = "0x400023D")]
		Lam = 1604,
		[Token(Token = "0x400023E")]
		Meem = 1605,
		[Token(Token = "0x400023F")]
		Noon = 1606,
		[Token(Token = "0x4000240")]
		Ha = 1607,
		[Token(Token = "0x4000241")]
		Waw = 1608,
		[Token(Token = "0x4000242")]
		Ya = 1610,
		[Token(Token = "0x4000243")]
		AlefMad = 1570,
		[Token(Token = "0x4000244")]
		TaMarboota = 1577,
		[Token(Token = "0x4000245")]
		PersianPe = 1662,
		[Token(Token = "0x4000246")]
		PersianChe = 1670,
		[Token(Token = "0x4000247")]
		PersianZe = 1688,
		[Token(Token = "0x4000248")]
		PersianGaf = 1711,
		[Token(Token = "0x4000249")]
		PersianGaf2 = 1705
	}
	[Token(Token = "0x2000087")]
	internal class ArabicMapping
	{
		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int from;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int to;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x10A2218", Offset = "0x10A2218", VA = "0x10A2218")]
		public ArabicMapping(int from, int to)
		{
		}
	}
	[Token(Token = "0x2000088")]
	internal class ArabicTable
	{
		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ArabicMapping> mapList;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static ArabicTable arabicMapper;

		[Token(Token = "0x17000056")]
		internal static ArabicTable ArabicMapper
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x10A2E78", Offset = "0x10A2E78", VA = "0x10A2E78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x10A2250", Offset = "0x10A2250", VA = "0x10A2250")]
		private ArabicTable()
		{
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x10A2EF0", Offset = "0x10A2EF0", VA = "0x10A2EF0")]
		internal int Convert(int toBeConverted)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000089")]
	internal class TashkeelLocation
	{
		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char tashkeel;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int position;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x11990F8", Offset = "0x11990F8", VA = "0x11990F8")]
		public TashkeelLocation(char tashkeel, int position)
		{
		}
	}
	[Token(Token = "0x200008A")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x11989FC", Offset = "0x11989FC", VA = "0x11989FC")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1199134", Offset = "0x1199134", VA = "0x1199134")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x11973F4", Offset = "0x11973F4", VA = "0x11973F4")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x11993B4", Offset = "0x11993B4", VA = "0x11993B4")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x119A120", Offset = "0x119A120", VA = "0x119A120")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1199D54", Offset = "0x1199D54", VA = "0x1199D54")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1199530", Offset = "0x1199530", VA = "0x1199530")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x119A8D8", Offset = "0x119A8D8", VA = "0x119A8D8")]
		public RTLFixerTool()
		{
		}
	}
	[Token(Token = "0x200008B")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920F18", Offset = "0x920F18")]
	public class SetLanguage : MonoBehaviour
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string _Language;

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x119B260", Offset = "0x119B260", VA = "0x119B260")]
		private void OnClick()
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x119B264", Offset = "0x119B264", VA = "0x119B264")]
		public void ApplyLanguage()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x119B320", Offset = "0x119B320", VA = "0x119B320")]
		public SetLanguage()
		{
		}
	}
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x920F50", Offset = "0x920F50")]
	public class SetLanguageDropdown : MonoBehaviour
	{
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x119B328", Offset = "0x119B328", VA = "0x119B328")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x119B5F4", Offset = "0x119B5F4", VA = "0x119B5F4")]
		private void OnValueChanged(int index)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x119B708", Offset = "0x119B708", VA = "0x119B708")]
		public SetLanguageDropdown()
		{
		}
	}
	[Token(Token = "0x200008D")]
	public class StringObfucator
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x11A2594", Offset = "0x11A2594", VA = "0x11A2594")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x11A2938", Offset = "0x11A2938", VA = "0x11A2938")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x11A289C", Offset = "0x11A289C", VA = "0x11A289C")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x11A2A1C", Offset = "0x11A2A1C", VA = "0x11A2A1C")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x11A2678", Offset = "0x11A2678", VA = "0x11A2678")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x11A2AD4", Offset = "0x11A2AD4", VA = "0x11A2AD4")]
		public StringObfucator()
		{
		}
	}
}
namespace I2.Loc.SimpleJSON
{
	[Token(Token = "0x200008E")]
	public enum JSONBinaryTag
	{
		[Token(Token = "0x4000255")]
		Array = 1,
		[Token(Token = "0x4000256")]
		Class,
		[Token(Token = "0x4000257")]
		Value,
		[Token(Token = "0x4000258")]
		IntValue,
		[Token(Token = "0x4000259")]
		DoubleValue,
		[Token(Token = "0x400025A")]
		BoolValue,
		[Token(Token = "0x400025B")]
		FloatValue
	}
	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x920F88", Offset = "0x920F88")]
	public class JSONNode
	{
		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921288", Offset = "0x921288")]
		private sealed class <get_Childs>d__17 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170000DD")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000855")]
				[Address(RVA = "0x11A1134", Offset = "0x11A1134", VA = "0x11A1134", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DE")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000857")]
				[Address(RVA = "0x11A11A4", Offset = "0x11A11A4", VA = "0x11A11A4", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x119FD84", Offset = "0x119FD84", VA = "0x119FD84")]
			[DebuggerHidden]
			public <get_Childs>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x11A1118", Offset = "0x11A1118", VA = "0x11A1118", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x11A111C", Offset = "0x11A111C", VA = "0x11A111C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x11A113C", Offset = "0x11A113C", VA = "0x11A113C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x11A11AC", Offset = "0x11A11AC", VA = "0x11A11AC", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x11A1244", Offset = "0x11A1244", VA = "0x11A1244", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921298", Offset = "0x921298")]
		private sealed class <get_DeepChilds>d__19 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170000DF")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600085F")]
				[Address(RVA = "0x11A187C", Offset = "0x11A187C", VA = "0x11A187C", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E0")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000861")]
				[Address(RVA = "0x11A18EC", Offset = "0x11A18EC", VA = "0x11A18EC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x119FE40", Offset = "0x119FE40", VA = "0x119FE40")]
			[DebuggerHidden]
			public <get_DeepChilds>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x11A1248", Offset = "0x11A1248", VA = "0x11A1248", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x11A1440", Offset = "0x11A1440", VA = "0x11A1440", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x11A1380", Offset = "0x11A1380", VA = "0x11A1380")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x11A12C0", Offset = "0x11A12C0", VA = "0x11A12C0")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x11A1884", Offset = "0x11A1884", VA = "0x11A1884", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x11A18F4", Offset = "0x11A18F4", VA = "0x11A18F4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x11A19A4", Offset = "0x11A19A4", VA = "0x11A19A4", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000471")]
			[Address(RVA = "0x119FC28", Offset = "0x119FC28", VA = "0x119FC28", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000472")]
			[Address(RVA = "0x119FC30", Offset = "0x119FC30", VA = "0x119FC30", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000058")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000473")]
			[Address(RVA = "0x119FC34", Offset = "0x119FC34", VA = "0x119FC34", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000474")]
			[Address(RVA = "0x119FC3C", Offset = "0x119FC3C", VA = "0x119FC3C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public virtual string Value
		{
			[Token(Token = "0x6000475")]
			[Address(RVA = "0x119FC40", Offset = "0x119FC40", VA = "0x119FC40", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000476")]
			[Address(RVA = "0x119FC88", Offset = "0x119FC88", VA = "0x119FC88", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public virtual int Count
		{
			[Token(Token = "0x6000477")]
			[Address(RVA = "0x119FC8C", Offset = "0x119FC8C", VA = "0x119FC8C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005B")]
		public virtual IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x119FD14", Offset = "0x119FD14", VA = "0x119FD14", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9232AC", Offset = "0x9232AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005C")]
		public IEnumerable<JSONNode> DeepChilds
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x119FDBC", Offset = "0x119FDBC", VA = "0x119FDBC")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x923310", Offset = "0x923310")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x119FF08", Offset = "0x119FF08", VA = "0x119FF08", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x119FF48", Offset = "0x119FF48", VA = "0x119FF48", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x119FF88", Offset = "0x119FF88", VA = "0x119FF88", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x119FFCC", Offset = "0x119FFCC", VA = "0x119FFCC", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x11A000C", Offset = "0x11A000C", VA = "0x11A000C", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x11A00B0", Offset = "0x11A00B0", VA = "0x11A00B0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000060")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x11A00F0", Offset = "0x11A00F0", VA = "0x11A00F0", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x11A01B8", Offset = "0x11A01B8", VA = "0x11A01B8", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x11A023C", Offset = "0x11A023C", VA = "0x11A023C", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000062")]
		public virtual JSONClass AsObject
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x11A02BC", Offset = "0x11A02BC", VA = "0x11A02BC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x119FC24", Offset = "0x119FC24", VA = "0x119FC24", Slot = "4")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x119FC94", Offset = "0x119FC94", VA = "0x119FC94", Slot = "12")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x119FCFC", Offset = "0x119FCFC", VA = "0x119FCFC", Slot = "13")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x119FD04", Offset = "0x119FD04", VA = "0x119FD04", Slot = "14")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x119FD0C", Offset = "0x119FD0C", VA = "0x119FD0C", Slot = "15")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x119FE78", Offset = "0x119FE78", VA = "0x119FE78", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x119FEC0", Offset = "0x119FEC0", VA = "0x119FEC0", Slot = "17")]
		public virtual string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x11A033C", Offset = "0x11A033C", VA = "0x11A033C")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x11A03A0", Offset = "0x11A03A0", VA = "0x11A03A0")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x119E6FC", Offset = "0x119E6FC", VA = "0x119E6FC")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x11A03F0", Offset = "0x11A03F0", VA = "0x11A03F0")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x11A040C", Offset = "0x11A040C", VA = "0x11A040C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x119F68C", Offset = "0x119F68C", VA = "0x119F68C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x119DDD4", Offset = "0x119DDD4", VA = "0x119DDD4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x119B714", Offset = "0x119B714", VA = "0x119B714")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x11A0418", Offset = "0x11A0418", VA = "0x11A0418", Slot = "28")]
		public virtual void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x11A041C", Offset = "0x11A041C", VA = "0x11A041C")]
		public void SaveToStream(Stream aData)
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x11A049C", Offset = "0x11A049C", VA = "0x11A049C")]
		public void SaveToCompressedStream(Stream aData)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x11A0510", Offset = "0x11A0510", VA = "0x11A0510")]
		public void SaveToCompressedFile(string aFileName)
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x11A0584", Offset = "0x11A0584", VA = "0x11A0584")]
		public string SaveToCompressedBase64()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x11A05F8", Offset = "0x11A05F8", VA = "0x11A05F8")]
		public void SaveToFile(string aFileName)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x11A077C", Offset = "0x11A077C", VA = "0x11A077C")]
		public string SaveToBase64()
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x11A0918", Offset = "0x11A0918", VA = "0x11A0918")]
		public static JSONNode Deserialize(BinaryReader aReader)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x11A0CB8", Offset = "0x11A0CB8", VA = "0x11A0CB8")]
		public static JSONNode LoadFromCompressedFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x11A0D2C", Offset = "0x11A0D2C", VA = "0x11A0D2C")]
		public static JSONNode LoadFromCompressedStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x11A0DA0", Offset = "0x11A0DA0", VA = "0x11A0DA0")]
		public static JSONNode LoadFromCompressedBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x11A0E14", Offset = "0x11A0E14", VA = "0x11A0E14")]
		public static JSONNode LoadFromStream(Stream aData)
		{
			return null;
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x11A0F44", Offset = "0x11A0F44", VA = "0x11A0F44")]
		public static JSONNode LoadFromFile(string aFileName)
		{
			return null;
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x11A1060", Offset = "0x11A1060", VA = "0x11A1060")]
		public static JSONNode LoadFromBase64(string aBase64)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x119CA50", Offset = "0x119CA50", VA = "0x119CA50")]
		public JSONNode()
		{
		}
	}
	[Token(Token = "0x2000090")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x920FC0", Offset = "0x920FC0")]
	public class JSONArray : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212A8", Offset = "0x9212A8")]
		private sealed class <get_Childs>d__13 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000E1")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000868")]
				[Address(RVA = "0x119CEA0", Offset = "0x119CEA0", VA = "0x119CEA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E2")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086A")]
				[Address(RVA = "0x119CF10", Offset = "0x119CF10", VA = "0x119CF10", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x119C3E4", Offset = "0x119C3E4", VA = "0x119C3E4")]
			[DebuggerHidden]
			public <get_Childs>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x119CCB8", Offset = "0x119CCB8", VA = "0x119CCB8", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x119CD2C", Offset = "0x119CD2C", VA = "0x119CD2C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x119CCD4", Offset = "0x119CCD4", VA = "0x119CCD4")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x119CEA8", Offset = "0x119CEA8", VA = "0x119CEA8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x119CF18", Offset = "0x119CF18", VA = "0x119CF18", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x119CFC8", Offset = "0x119CFC8", VA = "0x119CFC8", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212B8", Offset = "0x9212B8")]
		private sealed class <GetEnumerator>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000E3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000871")]
				[Address(RVA = "0x119CC40", Offset = "0x119CC40", VA = "0x119CC40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000873")]
				[Address(RVA = "0x119CCB0", Offset = "0x119CCB0", VA = "0x119CCB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x119C490", Offset = "0x119C490", VA = "0x119C490")]
			[DebuggerHidden]
			public <GetEnumerator>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x119CA58", Offset = "0x119CA58", VA = "0x119CA58", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x119CACC", Offset = "0x119CACC", VA = "0x119CACC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x119CA74", Offset = "0x119CA74", VA = "0x119CA74")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x119CC48", Offset = "0x119CC48", VA = "0x119CC48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x17000063")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x119BE90", Offset = "0x119BE90", VA = "0x119BE90", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x119BF8C", Offset = "0x119BF8C", VA = "0x119BF8C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0x119C068", Offset = "0x119C068", VA = "0x119C068", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0x119C0CC", Offset = "0x119C0CC", VA = "0x119C0CC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000065")]
		public override int Count
		{
			[Token(Token = "0x60004A5")]
			[Address(RVA = "0x119C13C", Offset = "0x119C13C", VA = "0x119C13C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000066")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x119C360", Offset = "0x119C360", VA = "0x119C360", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x923374", Offset = "0x923374")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x119C19C", Offset = "0x119C19C", VA = "0x119C19C", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x119C20C", Offset = "0x119C20C", VA = "0x119C20C", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x119C2E8", Offset = "0x119C2E8", VA = "0x119C2E8", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x119C41C", Offset = "0x119C41C", VA = "0x119C41C", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9233D8", Offset = "0x9233D8")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x119C4BC", Offset = "0x119C4BC", VA = "0x119C4BC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x119C688", Offset = "0x119C688", VA = "0x119C688", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x119C8B4", Offset = "0x119C8B4", VA = "0x119C8B4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x119C9E0", Offset = "0x119C9E0", VA = "0x119C9E0")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x2000091")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x920FF8", Offset = "0x920FF8")]
	public class JSONClass : JSONNode, IEnumerable
	{
		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212C8", Offset = "0x9212C8")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x119D880", Offset = "0x119D880", VA = "0x119D880")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x119E690", Offset = "0x119E690", VA = "0x119E690")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212D8", Offset = "0x9212D8")]
		private sealed class <get_Childs>d__14 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONClass <>4__this;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000E5")]
			private JSONNode System.Collections.Generic.IEnumerator<I2.Loc.SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x600087A")]
				[Address(RVA = "0x119EC38", Offset = "0x119EC38", VA = "0x119EC38", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600087C")]
				[Address(RVA = "0x119ECA8", Offset = "0x119ECA8", VA = "0x119ECA8", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x119D90C", Offset = "0x119D90C", VA = "0x119D90C")]
			[DebuggerHidden]
			public <get_Childs>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x119EA20", Offset = "0x119EA20", VA = "0x119EA20", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x119EA94", Offset = "0x119EA94", VA = "0x119EA94", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x119EA3C", Offset = "0x119EA3C", VA = "0x119EA3C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x119EC40", Offset = "0x119EC40", VA = "0x119EC40", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x119ECB0", Offset = "0x119ECB0", VA = "0x119ECB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<I2.Loc.SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x600087E")]
			[Address(RVA = "0x119ED60", Offset = "0x119ED60", VA = "0x119ED60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x2000127")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212E8", Offset = "0x9212E8")]
		private sealed class <GetEnumerator>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public JSONClass <>4__this;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170000E7")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000883")]
				[Address(RVA = "0x119E9A8", Offset = "0x119E9A8", VA = "0x119E9A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E8")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000885")]
				[Address(RVA = "0x119EA18", Offset = "0x119EA18", VA = "0x119EA18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x119D9B8", Offset = "0x119D9B8", VA = "0x119D9B8")]
			[DebuggerHidden]
			public <GetEnumerator>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000880")]
			[Address(RVA = "0x119E794", Offset = "0x119E794", VA = "0x119E794", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x119E808", Offset = "0x119E808", VA = "0x119E808", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000882")]
			[Address(RVA = "0x119E7B0", Offset = "0x119E7B0", VA = "0x119E7B0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x119E9B0", Offset = "0x119E9B0", VA = "0x119E9B0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x17000067")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0x119CFCC", Offset = "0x119CFCC", VA = "0x119CFCC", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x119D0D4", Offset = "0x119D0D4", VA = "0x119D0D4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000068")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x119D1A8", Offset = "0x119D1A8", VA = "0x119D1A8", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x119D26C", Offset = "0x119D26C", VA = "0x119D26C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000069")]
		public override int Count
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x119D35C", Offset = "0x119D35C", VA = "0x119D35C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006A")]
		public override IEnumerable<JSONNode> Childs
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x119D888", Offset = "0x119D888", VA = "0x119D888", Slot = "16")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x92343C", Offset = "0x92343C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x119D3BC", Offset = "0x119D3BC", VA = "0x119D3BC", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x119D4F4", Offset = "0x119D4F4", VA = "0x119D4F4", Slot = "13")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x119D5CC", Offset = "0x119D5CC", VA = "0x119D5CC", Slot = "14")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x119D6CC", Offset = "0x119D6CC", VA = "0x119D6CC", Slot = "15")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x119D944", Offset = "0x119D944", VA = "0x119D944", Slot = "29")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x9234A0", Offset = "0x9234A0")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x119D9E4", Offset = "0x119D9E4", VA = "0x119D9E4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x119DF60", Offset = "0x119DF60", VA = "0x119DF60", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x119E3D4", Offset = "0x119E3D4", VA = "0x119E3D4", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x119E5E4", Offset = "0x119E5E4", VA = "0x119E5E4")]
		public JSONClass()
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class JSONData : JSONNode
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x1700006B")]
		public override string Value
		{
			[Token(Token = "0x60004BE")]
			[Address(RVA = "0x119ED64", Offset = "0x119ED64", VA = "0x119ED64", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0x119ED6C", Offset = "0x119ED6C", VA = "0x119ED6C", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x119ED74", Offset = "0x119ED74", VA = "0x119ED74")]
		public JSONData(string aData)
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x119EDA0", Offset = "0x119EDA0", VA = "0x119EDA0")]
		public JSONData(float aData)
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x119EDE4", Offset = "0x119EDE4", VA = "0x119EDE4")]
		public JSONData(double aData)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x119EE28", Offset = "0x119EE28", VA = "0x119EE28")]
		public JSONData(bool aData)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x119EE64", Offset = "0x119EE64", VA = "0x119EE64")]
		public JSONData(int aData)
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x119EEA0", Offset = "0x119EEA0", VA = "0x119EEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x119EF04", Offset = "0x119EF04", VA = "0x119EF04", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x119EF68", Offset = "0x119EF68", VA = "0x119EF68", Slot = "28")]
		public override void Serialize(BinaryWriter aWriter)
		{
		}
	}
	[Token(Token = "0x2000093")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x921030", Offset = "0x921030")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x1700006C")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x119F328", Offset = "0x119F328", VA = "0x119F328", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x119F38C", Offset = "0x119F38C", VA = "0x119F38C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public override JSONNode Item
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x119F418", Offset = "0x119F418", VA = "0x119F418", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x119F488", Offset = "0x119F488", VA = "0x119F488", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public override int AsInt
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x119F724", Offset = "0x119F724", VA = "0x119F724", Slot = "18")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x119F7A8", Offset = "0x119F7A8", VA = "0x119F7A8", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public override float AsFloat
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0x119F830", Offset = "0x119F830", VA = "0x119F830", Slot = "20")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x119F8B4", Offset = "0x119F8B4", VA = "0x119F8B4", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public override double AsDouble
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x119F93C", Offset = "0x119F93C", VA = "0x119F93C", Slot = "22")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x119F9C0", Offset = "0x119F9C0", VA = "0x119F9C0", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public override bool AsBool
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x119FA48", Offset = "0x119FA48", VA = "0x119FA48", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x119FACC", Offset = "0x119FACC", VA = "0x119FACC", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x119FB54", Offset = "0x119FB54", VA = "0x119FB54", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		public override JSONClass AsObject
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x119FBBC", Offset = "0x119FBBC", VA = "0x119FBBC", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x119BF60", Offset = "0x119BF60", VA = "0x119BF60")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x119D09C", Offset = "0x119D09C", VA = "0x119D09C")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x119F2AC", Offset = "0x119F2AC", VA = "0x119F2AC")]
		private void Set(JSONNode aVal)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x119F51C", Offset = "0x119F51C", VA = "0x119F51C", Slot = "12")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x119F5A8", Offset = "0x119F5A8", VA = "0x119F5A8", Slot = "4")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x119F63C", Offset = "0x119F63C", VA = "0x119F63C")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x119F654", Offset = "0x119F654", VA = "0x119F654")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x119F66C", Offset = "0x119F66C", VA = "0x119F66C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x119F684", Offset = "0x119F684", VA = "0x119F684", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x119F694", Offset = "0x119F694", VA = "0x119F694", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x119F6DC", Offset = "0x119F6DC", VA = "0x119F6DC", Slot = "17")]
		public override string ToString(string aPrefix)
		{
			return null;
		}
	}
	[Token(Token = "0x2000094")]
	public static class JSON
	{
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x119B710", Offset = "0x119B710", VA = "0x119B710")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x2000095")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9212F8", Offset = "0x9212F8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x1275824", Offset = "0x1275824", VA = "0x1275824")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x1276008", Offset = "0x1276008", VA = "0x1276008")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x1276038", Offset = "0x1276038", VA = "0x1276038")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921308", Offset = "0x921308")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x127596C", Offset = "0x127596C", VA = "0x127596C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x1276078", Offset = "0x1276078", VA = "0x1276078")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x12760A8", Offset = "0x12760A8", VA = "0x12760A8")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921318", Offset = "0x921318")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1275AD4", Offset = "0x1275AD4", VA = "0x1275AD4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x12760E8", Offset = "0x12760E8", VA = "0x12760E8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1276134", Offset = "0x1276134", VA = "0x1276134")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x12756BC", Offset = "0x12756BC", VA = "0x12756BC")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x127582C", Offset = "0x127582C", VA = "0x127582C")]
		public static TweenerCore<float, float, FloatOptions> DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1275974", Offset = "0x1275974", VA = "0x1275974")]
		public static TweenerCore<float, float, FloatOptions> DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1275ADC", Offset = "0x1275ADC", VA = "0x1275ADC")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1275B54", Offset = "0x1275B54", VA = "0x1275B54")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1275BCC", Offset = "0x1275BCC", VA = "0x1275BCC")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1275C34", Offset = "0x1275C34", VA = "0x1275C34")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1275CBC", Offset = "0x1275CBC", VA = "0x1275CBC")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1275D24", Offset = "0x1275D24", VA = "0x1275D24")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1275D8C", Offset = "0x1275D8C", VA = "0x1275D8C")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1275DF4", Offset = "0x1275DF4", VA = "0x1275DF4")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1275E5C", Offset = "0x1275E5C", VA = "0x1275E5C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1275ECC", Offset = "0x1275ECC", VA = "0x1275ECC")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1275F38", Offset = "0x1275F38", VA = "0x1275F38")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1275FA0", Offset = "0x1275FA0", VA = "0x1275FA0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000096")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x200012B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921328", Offset = "0x921328")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1095B08", Offset = "0x1095B08", VA = "0x1095B08")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000890")]
			[Address(RVA = "0x1095B10", Offset = "0x1095B10", VA = "0x1095B10")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921338", Offset = "0x921338")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1095CA0", Offset = "0x1095CA0", VA = "0x1095CA0")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x1095CA8", Offset = "0x1095CA8", VA = "0x1095CA8")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921348", Offset = "0x921348")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x1095CD8", Offset = "0x1095CD8", VA = "0x1095CD8")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1095CE0", Offset = "0x1095CE0", VA = "0x1095CE0")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921358", Offset = "0x921358")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1095D10", Offset = "0x1095D10", VA = "0x1095D10")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000896")]
			[Address(RVA = "0x1095D18", Offset = "0x1095D18", VA = "0x1095D18")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921368", Offset = "0x921368")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1095D48", Offset = "0x1095D48", VA = "0x1095D48")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1095D50", Offset = "0x1095D50", VA = "0x1095D50")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921378", Offset = "0x921378")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x1095D80", Offset = "0x1095D80", VA = "0x1095D80")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1095D88", Offset = "0x1095D88", VA = "0x1095D88")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921388", Offset = "0x921388")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1095DB8", Offset = "0x1095DB8", VA = "0x1095DB8")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1095DC0", Offset = "0x1095DC0", VA = "0x1095DC0")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600089D")]
			[Address(RVA = "0x1095DF0", Offset = "0x1095DF0", VA = "0x1095DF0")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1095E2C", Offset = "0x1095E2C", VA = "0x1095E2C")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600089F")]
			[Address(RVA = "0x1095E5C", Offset = "0x1095E5C", VA = "0x1095E5C")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1095E8C", Offset = "0x1095E8C", VA = "0x1095E8C")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921398", Offset = "0x921398")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1095F74", Offset = "0x1095F74", VA = "0x1095F74")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1095F7C", Offset = "0x1095F7C", VA = "0x1095F7C")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213A8", Offset = "0x9213A8")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60008A3")]
			[Address(RVA = "0x1095FAC", Offset = "0x1095FAC", VA = "0x1095FAC")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x1095FB4", Offset = "0x1095FB4", VA = "0x1095FB4")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008A5")]
			[Address(RVA = "0x1095FE4", Offset = "0x1095FE4", VA = "0x1095FE4")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000134")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213B8", Offset = "0x9213B8")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x109610C", Offset = "0x109610C", VA = "0x109610C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1096114", Offset = "0x1096114", VA = "0x1096114")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000135")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213C8", Offset = "0x9213C8")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1095B40", Offset = "0x1095B40", VA = "0x1095B40")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60008A9")]
			[Address(RVA = "0x1095B48", Offset = "0x1095B48", VA = "0x1095B48")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x1095B78", Offset = "0x1095B78", VA = "0x1095B78")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1276178", Offset = "0x1276178", VA = "0x1276178")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x12762F8", Offset = "0x12762F8", VA = "0x12762F8")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1276490", Offset = "0x1276490", VA = "0x1276490")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1276628", Offset = "0x1276628", VA = "0x1276628")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x12767C0", Offset = "0x12767C0", VA = "0x12767C0")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1276944", Offset = "0x1276944", VA = "0x1276944")]
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1276B60", Offset = "0x1276B60", VA = "0x1276B60")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1277034", Offset = "0x1277034", VA = "0x1277034")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x127725C", Offset = "0x127725C", VA = "0x127725C")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x12774DC", Offset = "0x12774DC", VA = "0x12774DC")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1277690", Offset = "0x1277690", VA = "0x1277690")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x2000097")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x2000136")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213D8", Offset = "0x9213D8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60008AB")]
			[Address(RVA = "0x10962AC", Offset = "0x10962AC", VA = "0x10962AC")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60008AC")]
			[Address(RVA = "0x109681C", Offset = "0x109681C", VA = "0x109681C")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008AD")]
			[Address(RVA = "0x109684C", Offset = "0x109684C", VA = "0x109684C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000137")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213E8", Offset = "0x9213E8")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60008AE")]
			[Address(RVA = "0x10963F4", Offset = "0x10963F4", VA = "0x10963F4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60008AF")]
			[Address(RVA = "0x10968AC", Offset = "0x10968AC", VA = "0x10968AC")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x10968DC", Offset = "0x10968DC", VA = "0x10968DC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000138")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9213F8", Offset = "0x9213F8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1096814", Offset = "0x1096814", VA = "0x1096814")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x109693C", Offset = "0x109693C", VA = "0x109693C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1096948", Offset = "0x1096948", VA = "0x1096948")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1096144", Offset = "0x1096144", VA = "0x1096144")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x10962B4", Offset = "0x10962B4", VA = "0x10962B4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x10963FC", Offset = "0x10963FC", VA = "0x10963FC")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x10965E8", Offset = "0x10965E8", VA = "0x10965E8")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000098")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x2000139")]
		public static class Utils
		{
			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x109C3C0", Offset = "0x109C3C0", VA = "0x109C3C0")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200013A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921408", Offset = "0x921408")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1096B64", Offset = "0x1096B64", VA = "0x1096B64")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x109A888", Offset = "0x109A888", VA = "0x109A888")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x109A8B8", Offset = "0x109A8B8", VA = "0x109A8B8")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200013B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921418", Offset = "0x921418")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1096CD4", Offset = "0x1096CD4", VA = "0x1096CD4")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x109AE18", Offset = "0x109AE18", VA = "0x109AE18")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008BA")]
			[Address(RVA = "0x109AE50", Offset = "0x109AE50", VA = "0x109AE50")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921428", Offset = "0x921428")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60008BB")]
			[Address(RVA = "0x1096E1C", Offset = "0x1096E1C", VA = "0x1096E1C")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60008BC")]
			[Address(RVA = "0x109B780", Offset = "0x109B780", VA = "0x109B780")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008BD")]
			[Address(RVA = "0x109B7B8", Offset = "0x109B7B8", VA = "0x109B7B8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921438", Offset = "0x921438")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60008BE")]
			[Address(RVA = "0x1096F8C", Offset = "0x1096F8C", VA = "0x1096F8C")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60008BF")]
			[Address(RVA = "0x109BF04", Offset = "0x109BF04", VA = "0x109BF04")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x109BF3C", Offset = "0x109BF3C", VA = "0x109BF3C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921448", Offset = "0x921448")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x10970D4", Offset = "0x10970D4", VA = "0x10970D4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x109BFA4", Offset = "0x109BFA4", VA = "0x109BFA4")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008C3")]
			[Address(RVA = "0x109BFDC", Offset = "0x109BFDC", VA = "0x109BFDC")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200013F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921458", Offset = "0x921458")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Image target;

			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1097240", Offset = "0x1097240", VA = "0x1097240")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x109C044", Offset = "0x109C044", VA = "0x109C044")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x109C074", Offset = "0x109C074", VA = "0x109C074")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000140")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921468", Offset = "0x921468")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x109759C", Offset = "0x109759C", VA = "0x109759C")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60008C8")]
			[Address(RVA = "0x109C0B4", Offset = "0x109C0B4", VA = "0x109C0B4")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008C9")]
			[Address(RVA = "0x109C140", Offset = "0x109C140", VA = "0x109C140")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000141")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921478", Offset = "0x921478")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60008CA")]
			[Address(RVA = "0x1097704", Offset = "0x1097704", VA = "0x1097704")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x109C1B8", Offset = "0x109C1B8", VA = "0x109C1B8")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x109C244", Offset = "0x109C244", VA = "0x109C244")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000142")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921488", Offset = "0x921488")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x109786C", Offset = "0x109786C", VA = "0x109786C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x109C2BC", Offset = "0x109C2BC", VA = "0x109C2BC")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x109C348", Offset = "0x109C348", VA = "0x109C348")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000143")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921498", Offset = "0x921498")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x10979DC", Offset = "0x10979DC", VA = "0x10979DC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x109A8F8", Offset = "0x109A8F8", VA = "0x109A8F8")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x109A928", Offset = "0x109A928", VA = "0x109A928")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214A8", Offset = "0x9214A8")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1097B24", Offset = "0x1097B24", VA = "0x1097B24")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x109A988", Offset = "0x109A988", VA = "0x109A988")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x109A9B8", Offset = "0x109A9B8", VA = "0x109A9B8")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214B8", Offset = "0x9214B8")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x1097C7C", Offset = "0x1097C7C", VA = "0x1097C7C")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60008D7")]
			[Address(RVA = "0x109AA18", Offset = "0x109AA18", VA = "0x109AA18")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008D8")]
			[Address(RVA = "0x109AA48", Offset = "0x109AA48", VA = "0x109AA48")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000146")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214C8", Offset = "0x9214C8")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x1097DE4", Offset = "0x1097DE4", VA = "0x1097DE4")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60008DA")]
			[Address(RVA = "0x109AA90", Offset = "0x109AA90", VA = "0x109AA90")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x109AAC0", Offset = "0x109AAC0", VA = "0x109AAC0")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000147")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214D8", Offset = "0x9214D8")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x1097F60", Offset = "0x1097F60", VA = "0x1097F60")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x109AB08", Offset = "0x109AB08", VA = "0x109AB08")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x109AB38", Offset = "0x109AB38", VA = "0x109AB38")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214E8", Offset = "0x9214E8")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x10980DC", Offset = "0x10980DC", VA = "0x10980DC")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x109AB80", Offset = "0x109AB80", VA = "0x109AB80")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x109ABB0", Offset = "0x109ABB0", VA = "0x109ABB0")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9214F8", Offset = "0x9214F8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x109824C", Offset = "0x109824C", VA = "0x109824C")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x109ABF8", Offset = "0x109ABF8", VA = "0x109ABF8")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x109AC28", Offset = "0x109AC28", VA = "0x109AC28")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921508", Offset = "0x921508")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x10983D4", Offset = "0x10983D4", VA = "0x10983D4")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x109AC80", Offset = "0x109AC80", VA = "0x109AC80")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x109ACB0", Offset = "0x109ACB0", VA = "0x109ACB0")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921518", Offset = "0x921518")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x109855C", Offset = "0x109855C", VA = "0x109855C")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x109AD08", Offset = "0x109AD08", VA = "0x109AD08")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x109AD38", Offset = "0x109AD38", VA = "0x109AD38")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921528", Offset = "0x921528")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x10986E4", Offset = "0x10986E4", VA = "0x10986E4")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x109AD90", Offset = "0x109AD90", VA = "0x109AD90")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60008ED")]
			[Address(RVA = "0x109ADC0", Offset = "0x109ADC0", VA = "0x109ADC0")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921538", Offset = "0x921538")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x109884C", Offset = "0x109884C", VA = "0x109884C")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x109AEB8", Offset = "0x109AEB8", VA = "0x109AEB8")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x109AEE8", Offset = "0x109AEE8", VA = "0x109AEE8")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921548", Offset = "0x921548")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008F1")]
			[Address(RVA = "0x10989B4", Offset = "0x10989B4", VA = "0x10989B4")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x109AF30", Offset = "0x109AF30", VA = "0x109AF30")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008F3")]
			[Address(RVA = "0x109AF60", Offset = "0x109AF60", VA = "0x109AF60")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921558", Offset = "0x921558")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x1098B0C", Offset = "0x1098B0C", VA = "0x1098B0C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x109AFA8", Offset = "0x109AFA8", VA = "0x109AFA8")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x109AFD8", Offset = "0x109AFD8", VA = "0x109AFD8")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921568", Offset = "0x921568")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008F7")]
			[Address(RVA = "0x1098C7C", Offset = "0x1098C7C", VA = "0x1098C7C")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x109B020", Offset = "0x109B020", VA = "0x109B020")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x109B050", Offset = "0x109B050", VA = "0x109B050")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921578", Offset = "0x921578")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1098DEC", Offset = "0x1098DEC", VA = "0x1098DEC")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x109B098", Offset = "0x109B098", VA = "0x109B098")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x109B0C8", Offset = "0x109B0C8", VA = "0x109B0C8")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921588", Offset = "0x921588")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60008FD")]
			[Address(RVA = "0x1098F54", Offset = "0x1098F54", VA = "0x1098F54")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x109B110", Offset = "0x109B110", VA = "0x109B110")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60008FF")]
			[Address(RVA = "0x109B140", Offset = "0x109B140", VA = "0x109B140")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921598", Offset = "0x921598")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000900")]
			[Address(RVA = "0x1099110", Offset = "0x1099110", VA = "0x1099110")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x6000901")]
			[Address(RVA = "0x109B188", Offset = "0x109B188", VA = "0x109B188")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000902")]
			[Address(RVA = "0x109B220", Offset = "0x109B220", VA = "0x109B220")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215A8", Offset = "0x9215A8")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000903")]
			[Address(RVA = "0x109929C", Offset = "0x109929C", VA = "0x109929C")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x6000904")]
			[Address(RVA = "0x109B2D8", Offset = "0x109B2D8", VA = "0x109B2D8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000905")]
			[Address(RVA = "0x109B370", Offset = "0x109B370", VA = "0x109B370")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215B8", Offset = "0x9215B8")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000906")]
			[Address(RVA = "0x1099474", Offset = "0x1099474", VA = "0x1099474")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x109B428", Offset = "0x109B428", VA = "0x109B428")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x109B4C0", Offset = "0x109B4C0", VA = "0x109B4C0")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215C8", Offset = "0x9215C8")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x40004CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x1099850", Offset = "0x1099850", VA = "0x1099850")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x109B578", Offset = "0x109B578", VA = "0x109B578")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x109B5A8", Offset = "0x109B5A8", VA = "0x109B5A8")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x109B5F0", Offset = "0x109B5F0", VA = "0x109B5F0")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x600090D")]
			[Address(RVA = "0x109B62C", Offset = "0x109B62C", VA = "0x109B62C")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x109B65C", Offset = "0x109B65C", VA = "0x109B65C")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x109B6A4", Offset = "0x109B6A4", VA = "0x109B6A4")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215D8", Offset = "0x9215D8")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x40004CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x10999AC", Offset = "0x10999AC", VA = "0x10999AC")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x109B820", Offset = "0x109B820", VA = "0x109B820")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x109B89C", Offset = "0x109B89C", VA = "0x109B89C")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215E8", Offset = "0x9215E8")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x40004CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x1099AF8", Offset = "0x1099AF8", VA = "0x1099AF8")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x109B904", Offset = "0x109B904", VA = "0x109B904")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x109B934", Offset = "0x109B934", VA = "0x109B934")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9215F8", Offset = "0x9215F8")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x40004CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1099C44", Offset = "0x1099C44", VA = "0x1099C44")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000917")]
			[Address(RVA = "0x109B974", Offset = "0x109B974", VA = "0x109B974")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x109B9A4", Offset = "0x109B9A4", VA = "0x109B9A4")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921608", Offset = "0x921608")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000919")]
			[Address(RVA = "0x1099D9C", Offset = "0x1099D9C", VA = "0x1099D9C")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x109B9E4", Offset = "0x109B9E4", VA = "0x109B9E4")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x109BA1C", Offset = "0x109BA1C", VA = "0x109BA1C")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921618", Offset = "0x921618")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1099F0C", Offset = "0x1099F0C", VA = "0x1099F0C")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x600091D")]
			[Address(RVA = "0x109BA64", Offset = "0x109BA64", VA = "0x109BA64")]
			internal Color <DOColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x109BA9C", Offset = "0x109BA9C", VA = "0x109BA9C")]
			internal void <DOColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921628", Offset = "0x921628")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x600091F")]
			[Address(RVA = "0x109A054", Offset = "0x109A054", VA = "0x109A054")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x109BB04", Offset = "0x109BB04", VA = "0x109BB04")]
			internal Color <DOFade>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x109BB3C", Offset = "0x109BB3C", VA = "0x109BB3C")]
			internal void <DOFade>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921638", Offset = "0x921638")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x109A1CC", Offset = "0x109A1CC", VA = "0x109A1CC")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000923")]
			[Address(RVA = "0x109BBA4", Offset = "0x109BBA4", VA = "0x109BBA4")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x109BBDC", Offset = "0x109BBDC", VA = "0x109BBDC")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x200015E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921648", Offset = "0x921648")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000925")]
			[Address(RVA = "0x109A408", Offset = "0x109A408", VA = "0x109A408")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x109BC1C", Offset = "0x109BC1C", VA = "0x109BC1C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x6000927")]
			[Address(RVA = "0x109BC28", Offset = "0x109BC28", VA = "0x109BC28")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921658", Offset = "0x921658")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Image target;

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x109A644", Offset = "0x109A644", VA = "0x109A644")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x109BD14", Offset = "0x109BD14", VA = "0x109BD14")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x109BD20", Offset = "0x109BD20", VA = "0x109BD20")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921668", Offset = "0x921668")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Color to;

			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x109A880", Offset = "0x109A880", VA = "0x109A880")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x109BE0C", Offset = "0x109BE0C", VA = "0x109BE0C")]
			internal Color <DOBlendableColor>b__0()
			{
				return default(Color);
			}

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x109BE18", Offset = "0x109BE18", VA = "0x109BE18")]
			internal void <DOBlendableColor>b__1(Color x)
			{
			}
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1096A24", Offset = "0x1096A24", VA = "0x1096A24")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1096B6C", Offset = "0x1096B6C", VA = "0x1096B6C")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1096CDC", Offset = "0x1096CDC", VA = "0x1096CDC")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1096E24", Offset = "0x1096E24", VA = "0x1096E24")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1096F94", Offset = "0x1096F94", VA = "0x1096F94")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x10970DC", Offset = "0x10970DC", VA = "0x10970DC")]
		public static TweenerCore<float, float, FloatOptions> DOFillAmount(this Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1097248", Offset = "0x1097248", VA = "0x1097248")]
		public static Sequence DOGradientColor(this Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x109743C", Offset = "0x109743C", VA = "0x109743C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x10975A4", Offset = "0x10975A4", VA = "0x10975A4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x109770C", Offset = "0x109770C", VA = "0x109770C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1097874", Offset = "0x1097874", VA = "0x1097874")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Outline target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x10979E4", Offset = "0x10979E4", VA = "0x10979E4")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1097B2C", Offset = "0x1097B2C", VA = "0x1097B2C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1097C84", Offset = "0x1097C84", VA = "0x1097C84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1097DEC", Offset = "0x1097DEC", VA = "0x1097DEC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1097F68", Offset = "0x1097F68", VA = "0x1097F68")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x10980E4", Offset = "0x10980E4", VA = "0x10980E4")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1098254", Offset = "0x1098254", VA = "0x1098254")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x10983DC", Offset = "0x10983DC", VA = "0x10983DC")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1098564", Offset = "0x1098564", VA = "0x1098564")]
		public static TweenerCore<Vector3, Vector3, VectorOptions> DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x10986EC", Offset = "0x10986EC", VA = "0x10986EC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1098854", Offset = "0x1098854", VA = "0x1098854")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x10989BC", Offset = "0x10989BC", VA = "0x10989BC")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1098B14", Offset = "0x1098B14", VA = "0x1098B14")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1098C84", Offset = "0x1098C84", VA = "0x1098C84")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1098DF4", Offset = "0x1098DF4", VA = "0x1098DF4")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1098F5C", Offset = "0x1098F5C", VA = "0x1098F5C")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1099118", Offset = "0x1099118", VA = "0x1099118")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x10992A4", Offset = "0x10992A4", VA = "0x10992A4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x109947C", Offset = "0x109947C", VA = "0x109947C")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1099858", Offset = "0x1099858", VA = "0x1099858")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x10999B4", Offset = "0x10999B4", VA = "0x10999B4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1099B00", Offset = "0x1099B00", VA = "0x1099B00")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1099C4C", Offset = "0x1099C4C", VA = "0x1099C4C")]
		public static TweenerCore<float, float, FloatOptions> DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1099DA4", Offset = "0x1099DA4", VA = "0x1099DA4")]
		public static TweenerCore<Color, Color, ColorOptions> DOColor(this Text target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1099F14", Offset = "0x1099F14", VA = "0x1099F14")]
		public static TweenerCore<Color, Color, ColorOptions> DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x109A05C", Offset = "0x109A05C", VA = "0x109A05C")]
		public static TweenerCore<string, string, StringOptions> DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x109A1D4", Offset = "0x109A1D4", VA = "0x109A1D4")]
		public static Tweener DOBlendableColor(this Graphic target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x109A410", Offset = "0x109A410", VA = "0x109A410")]
		public static Tweener DOBlendableColor(this Image target, Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x109A64C", Offset = "0x109A64C", VA = "0x109A64C")]
		public static Tweener DOBlendableColor(this Text target, Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x2000099")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921678", Offset = "0x921678")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x109D118", Offset = "0x109D118", VA = "0x109D118")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x109D334", Offset = "0x109D334", VA = "0x109D334")]
			internal Vector2 <DOOffset>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x109D36C", Offset = "0x109D36C", VA = "0x109D36C")]
			internal void <DOOffset>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921688", Offset = "0x921688")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Material target;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int propertyID;

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x109D32C", Offset = "0x109D32C", VA = "0x109D32C")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x109D3BC", Offset = "0x109D3BC", VA = "0x109D3BC")]
			internal Vector2 <DOTiling>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0x109D3F4", Offset = "0x109D3F4", VA = "0x109D3F4")]
			internal void <DOTiling>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x109C6D8", Offset = "0x109C6D8", VA = "0x109C6D8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x109C8C8", Offset = "0x109C8C8", VA = "0x109C8C8")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x109CACC", Offset = "0x109CACC", VA = "0x109CACC")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x109CB7C", Offset = "0x109CB7C", VA = "0x109CB7C")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x109CC2C", Offset = "0x109CC2C", VA = "0x109CC2C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x109CCDC", Offset = "0x109CCDC", VA = "0x109CCDC")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x109CD9C", Offset = "0x109CD9C", VA = "0x109CD9C")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x109CE5C", Offset = "0x109CE5C", VA = "0x109CE5C")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x109CF0C", Offset = "0x109CF0C", VA = "0x109CF0C")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOOffset(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x109D120", Offset = "0x109D120", VA = "0x109D120")]
		public static TweenerCore<Vector2, Vector2, VectorOptions> DOTiling(this Material target, Vector2 endValue, int propertyID, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x200009A")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000163")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000E9")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0x1275304", Offset = "0x1275304", VA = "0x1275304", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0x127535C", Offset = "0x127535C", VA = "0x127535C")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000164")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000EA")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000936")]
				[Address(RVA = "0x1275548", Offset = "0x1275548", VA = "0x1275548", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x12755FC", Offset = "0x12755FC", VA = "0x12755FC")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000165")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000EB")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000938")]
				[Address(RVA = "0x1275420", Offset = "0x1275420", VA = "0x1275420", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0x1275450", Offset = "0x1275450", VA = "0x1275450")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000166")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x170000EC")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600093A")]
				[Address(RVA = "0x1275388", Offset = "0x1275388", VA = "0x1275388", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0x12753E4", Offset = "0x12753E4", VA = "0x12753E4")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x2000167")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x170000ED")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0x127547C", Offset = "0x127547C", VA = "0x127547C", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x127550C", Offset = "0x127550C", VA = "0x127550C")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x2000168")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x170000EE")]
			public override bool keepWaiting
			{
				[Token(Token = "0x600093E")]
				[Address(RVA = "0x1275628", Offset = "0x1275628", VA = "0x1275628", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x600093F")]
			[Address(RVA = "0x1275690", Offset = "0x1275690", VA = "0x1275690")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x200009B")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x2000169")]
		public static class Physics
		{
			[Token(Token = "0x6000940")]
			[Address(RVA = "0x109D59C", Offset = "0x109D59C", VA = "0x109D59C")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000941")]
			[Address(RVA = "0x109D788", Offset = "0x109D788", VA = "0x109D788")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000942")]
			[Address(RVA = "0x109D790", Offset = "0x109D790", VA = "0x109D790")]
			[Preserve]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000943")]
			[Address(RVA = "0x109D824", Offset = "0x109D824", VA = "0x109D824")]
			[Preserve]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x109D444", Offset = "0x109D444", VA = "0x109D444")]
		[Preserve]
		public static void Init()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x109D4E8", Offset = "0x109D4E8", VA = "0x109D4E8")]
		[Preserve]
		private static void Preserver()
		{
		}
	}
}
namespace CurvesAndSplines
{
	[Token(Token = "0x200009C")]
	public static class Bezier
	{
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1272594", Offset = "0x1272594", VA = "0x1272594")]
		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1272720", Offset = "0x1272720", VA = "0x1272720")]
		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x127287C", Offset = "0x127287C", VA = "0x127287C")]
		public static Vector3 GetPoint(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1272A74", Offset = "0x1272A74", VA = "0x1272A74")]
		public static Vector3 GetFirstDerivative(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3, float t)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x200009D")]
	public enum BezierControlPointMode
	{
		[Token(Token = "0x4000263")]
		Free,
		[Token(Token = "0x4000264")]
		Aligned,
		[Token(Token = "0x4000265")]
		Mirrored
	}
	[Token(Token = "0x200009E")]
	public class BezierCurve : MonoBehaviour
	{
		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3[] m_points;

		[Token(Token = "0x17000074")]
		public Vector3[] Points
		{
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x1272CB4", Offset = "0x1272CB4", VA = "0x1272CB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1272CBC", Offset = "0x1272CBC", VA = "0x1272CBC")]
		public Vector3 GetPoint(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1272E48", Offset = "0x1272E48", VA = "0x1272E48")]
		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1273078", Offset = "0x1273078", VA = "0x1273078")]
		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x12730A8", Offset = "0x12730A8", VA = "0x12730A8")]
		public void Reset()
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1273254", Offset = "0x1273254", VA = "0x1273254")]
		public BezierCurve()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class BezierSpline : MonoBehaviour
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Vector3[] m_points;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BezierControlPointMode[] m_modes;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool m_loop;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool m_isReversed;

		[Token(Token = "0x17000075")]
		public bool Loop
		{
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x127325C", Offset = "0x127325C", VA = "0x127325C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x1273264", Offset = "0x1273264", VA = "0x1273264")]
			set
			{
			}
		}

		[Token(Token = "0x17000076")]
		public bool IsReversed
		{
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x1273948", Offset = "0x1273948", VA = "0x1273948")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x1273950", Offset = "0x1273950", VA = "0x1273950")]
			set
			{
			}
		}

		[Token(Token = "0x17000077")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x127395C", Offset = "0x127395C", VA = "0x127395C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000078")]
		public int CurveCount
		{
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1273F54", Offset = "0x1273F54", VA = "0x1273F54")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1273988", Offset = "0x1273988", VA = "0x1273988")]
		public Vector3 GetControlPoint(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1273354", Offset = "0x1273354", VA = "0x1273354")]
		public void SetControlPoint(int index, Vector3 point)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1273DB0", Offset = "0x1273DB0", VA = "0x1273DB0")]
		public BezierControlPointMode GetControlPointMode(int index)
		{
			return default(BezierControlPointMode);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1273E20", Offset = "0x1273E20", VA = "0x1273E20")]
		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x12739E4", Offset = "0x12739E4", VA = "0x12739E4")]
		private void EnforceMode(int index)
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x1273F9C", Offset = "0x1273F9C", VA = "0x1273F9C")]
		public Vector3 GetPoint(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x127423C", Offset = "0x127423C", VA = "0x127423C")]
		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1274560", Offset = "0x1274560", VA = "0x1274560")]
		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1274590", Offset = "0x1274590", VA = "0x1274590")]
		public void AddCurve()
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1274978", Offset = "0x1274978", VA = "0x1274978")]
		public void RemoveCurve()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1274B90", Offset = "0x1274B90", VA = "0x1274B90")]
		public void Reset()
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1274D54", Offset = "0x1274D54", VA = "0x1274D54")]
		public BezierSpline()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class Line : MonoBehaviour
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 P0;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 P1;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1274D5C", Offset = "0x1274D5C", VA = "0x1274D5C")]
		public Line()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class SplineDecorator : MonoBehaviour
	{
		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BezierSpline m_spline;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private int m_frequency;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_lookForward;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform[] m_items;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1274D64", Offset = "0x1274D64", VA = "0x1274D64")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x127506C", Offset = "0x127506C", VA = "0x127506C")]
		public SplineDecorator()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class SplineWalker : MonoBehaviour
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BezierSpline m_spline;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_duration;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool m_lookForward;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SplineWalkerMode m_mode;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_progress;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_goingForward;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x12750D8", Offset = "0x12750D8", VA = "0x12750D8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x12752E8", Offset = "0x12752E8", VA = "0x12752E8")]
		public SplineWalker()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public enum SplineWalkerMode
	{
		[Token(Token = "0x4000278")]
		Once,
		[Token(Token = "0x4000279")]
		Loop,
		[Token(Token = "0x400027A")]
		PingPong
	}
}
namespace Cortopia.CortopiaExtensions
{
	[Token(Token = "0x20000A4")]
	public static class ExtensionMethods
	{
		[Serializable]
		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921698", Offset = "0x921698")]
		private sealed class <>c__13<T>
		{
			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__13<T> <>9;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<T, string> <>9__13_0;

			[Token(Token = "0x6000945")]
			public <>c__13()
			{
			}

			[Token(Token = "0x6000946")]
			internal string <ToFormattedString>b__13_0(T p)
			{
				return null;
			}
		}

		[Serializable]
		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9216A8", Offset = "0x9216A8")]
		private sealed class <>c__14<TK, TV>
		{
			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c__14<TK, TV> <>9;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Func<KeyValuePair<TK, TV>, string> <>9__14_0;

			[Token(Token = "0x6000948")]
			public <>c__14()
			{
			}

			[Token(Token = "0x6000949")]
			internal string <ToFormattedString>b__14_0(KeyValuePair<TK, TV> p)
			{
				return null;
			}
		}

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static System.Random sm_random;

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1270D48", Offset = "0x1270D48", VA = "0x1270D48")]
		public static int Wrap(this int value, int min, int max)
		{
			return default(int);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1270D64", Offset = "0x1270D64", VA = "0x1270D64")]
		public static string SplitCase(this string value)
		{
			return null;
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1270E58", Offset = "0x1270E58", VA = "0x1270E58")]
		public static string Truncate(this string value, int maxLength)
		{
			return null;
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1270ED0", Offset = "0x1270ED0", VA = "0x1270ED0")]
		public static bool IsNullOrEmpty(this string value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000559")]
		public static IList<T> MoveItemToIndex<T>(this IList<T> list, T item, int index)
		{
			return null;
		}

		[Token(Token = "0x600055A")]
		public static T GetRandomElement<T>(this IList<T> list)
		{
			return (T)null;
		}

		[Token(Token = "0x600055B")]
		public static T GetRandomElement<T>(this IList<T> list, T excludedElement) where T : IEquatable<T>
		{
			return (T)null;
		}

		[Token(Token = "0x600055C")]
		public static KeyValuePair<TK, TV> GetRandomElement<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return default(KeyValuePair<TK, TV>);
		}

		[Token(Token = "0x600055D")]
		public static void Shuffle<T>(this T[] array)
		{
		}

		[Token(Token = "0x600055E")]
		public static void Shuffle<T>(this IList<T> array)
		{
		}

		[Token(Token = "0x600055F")]
		public static bool IsEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000560")]
		public static bool IsNullOrEmpty<T>(this ICollection<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x6000561")]
		public static string ToFormattedString<T>(this IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x6000562")]
		public static string ToFormattedString<TK, TV>(this IDictionary<TK, TV> dictionary)
		{
			return null;
		}

		[Token(Token = "0x6000563")]
		public static bool ContainsFlag<T>(this Enum e, T mask) where T : struct, IConvertible
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		public static bool FastRemove<T>(this IList<T> list, T removeElement)
		{
			return default(bool);
		}

		[Token(Token = "0x6000565")]
		public static void FastRemove<T>(this IList<T> list, int index)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public enum ResetBehaviour
	{
		[Token(Token = "0x400027D")]
		Position = 1,
		[Token(Token = "0x400027E")]
		Rotation = 2,
		[Token(Token = "0x400027F")]
		Scale = 4,
		[Token(Token = "0x4000280")]
		PositionAndRotation = 3,
		[Token(Token = "0x4000281")]
		All = 7
	}
	[Token(Token = "0x20000A6")]
	public static class EnumExtensions
	{
		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1270D3C", Offset = "0x1270D3C", VA = "0x1270D3C")]
		public static bool ContainsFlag(this ResetBehaviour a, ResetBehaviour b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000A7")]
	public static class UnityExtensionMethods
	{
		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1270F68", Offset = "0x1270F68", VA = "0x1270F68")]
		public static Transform RetrieveOrCreateChild(this Transform transform, string childName, bool includeInactive = false)
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1271108", Offset = "0x1271108", VA = "0x1271108")]
		public static Transform RetrieveChild(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1271298", Offset = "0x1271298", VA = "0x1271298")]
		public static void SetParent(this Transform transform, Transform parent, ResetBehaviour resetBehaviour)
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x127144C", Offset = "0x127144C", VA = "0x127144C")]
		public static List<Transform> RetrieveChildren(this Transform transform, string childName, bool includeInactive = false, bool includePartials = false)
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x12715F8", Offset = "0x12715F8", VA = "0x12715F8")]
		public static Transform FindFirstChildWithName(this Transform transform, string childName)
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x1271994", Offset = "0x1271994", VA = "0x1271994")]
		public static bool HasParameterOfType(this Animator animator, string parameterName, AnimatorControllerParameterType parameterType)
		{
			return default(bool);
		}

		[Token(Token = "0x600056E")]
		public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		public static T GetOrAddComponent<T>(this Component component) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		public static T GetOrAddComponent<T>(this Transform transform) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1271A7C", Offset = "0x1271A7C", VA = "0x1271A7C")]
		public static float GetRoll(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1271B24", Offset = "0x1271B24", VA = "0x1271B24")]
		public static float GetPitch(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1271BCC", Offset = "0x1271BCC", VA = "0x1271BCC")]
		public static float GetYaw(this Quaternion quaternion)
		{
			return default(float);
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x1271C5C", Offset = "0x1271C5C", VA = "0x1271C5C")]
		public static bool IsValid(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1271C8C", Offset = "0x1271C8C", VA = "0x1271C8C")]
		public static bool IsValidThorough(this Quaternion quaternion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1271D88", Offset = "0x1271D88", VA = "0x1271D88")]
		public static bool AlmostEquals(this Vector3 first, Vector3 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x1271E6C", Offset = "0x1271E6C", VA = "0x1271E6C")]
		public static bool AlmostEquals(this Vector2 first, Vector2 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1271F30", Offset = "0x1271F30", VA = "0x1271F30")]
		public static bool AlmostEquals(this Quaternion first, Quaternion second, float maxAngle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x1272008", Offset = "0x1272008", VA = "0x1272008")]
		public static bool AlmostEquals(this float first, float second, float floatDiff)
		{
			return default(bool);
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1272090", Offset = "0x1272090", VA = "0x1272090")]
		public static void SetTimelineBinding(this PlayableDirector director, string trackName, Animator bindingAnimator)
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1272374", Offset = "0x1272374", VA = "0x1272374")]
		public static void SetTimelineBinding(this PlayableDirector director, string trackName, AudioSource bindingAudioSource)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x12722B0", Offset = "0x12722B0", VA = "0x12722B0")]
		public static TrackAsset GetTrackByName(this TimelineAsset timeline, string trackName)
		{
			return null;
		}
	}
}
namespace Cortopia.BE.Runtime
{
	[Token(Token = "0x20000A8")]
	public class BehaviourSystem : ScriptableObject
	{
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Node m_firstNode;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private Rect m_startNodeRect;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MonoBehaviour m_owner;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<Node> Nodes;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921920", Offset = "0x921920")]
		private bool <IsLooping>k__BackingField;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921930", Offset = "0x921930")]
		private Node <CurrentNode>k__BackingField;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921940", Offset = "0x921940")]
		private NodePriority <CurrentNodePriority>k__BackingField;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921950", Offset = "0x921950")]
		private Node <PendingNodeChange>k__BackingField;

		[Token(Token = "0x17000079")]
		public virtual bool IsLooping
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1263304", Offset = "0x1263304", VA = "0x1263304", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923C94", Offset = "0x923C94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x126330C", Offset = "0x126330C", VA = "0x126330C", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CA4", Offset = "0x923CA4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		public Node CurrentNode
		{
			[Token(Token = "0x600057F")]
			[Address(RVA = "0x1263318", Offset = "0x1263318", VA = "0x1263318")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CB4", Offset = "0x923CB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000580")]
			[Address(RVA = "0x1263320", Offset = "0x1263320", VA = "0x1263320")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CC4", Offset = "0x923CC4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007B")]
		public NodePriority CurrentNodePriority
		{
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x1263328", Offset = "0x1263328", VA = "0x1263328")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CD4", Offset = "0x923CD4")]
			get
			{
				return default(NodePriority);
			}
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x1263330", Offset = "0x1263330", VA = "0x1263330")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CE4", Offset = "0x923CE4")]
			set
			{
			}
		}

		[Token(Token = "0x1700007C")]
		public Node FirstNode
		{
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1263338", Offset = "0x1263338", VA = "0x1263338")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007D")]
		public Rect StartNodeRect
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1263340", Offset = "0x1263340", VA = "0x1263340")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000585")]
			[Address(RVA = "0x126334C", Offset = "0x126334C", VA = "0x126334C")]
			set
			{
			}
		}

		[Token(Token = "0x1700007E")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x1263358", Offset = "0x1263358", VA = "0x1263358")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000587")]
			[Address(RVA = "0x1263360", Offset = "0x1263360", VA = "0x1263360")]
			set
			{
			}
		}

		[Token(Token = "0x1700007F")]
		public Node PendingNodeChange
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1263678", Offset = "0x1263678", VA = "0x1263678")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923CF4", Offset = "0x923CF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1263680", Offset = "0x1263680", VA = "0x1263680")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D04", Offset = "0x923D04")]
			private set
			{
			}
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1263364", Offset = "0x1263364", VA = "0x1263364")]
		private void SetOwner(MonoBehaviour owner)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1263820", Offset = "0x1263820", VA = "0x1263820")]
		public void Initialize()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1263954", Offset = "0x1263954", VA = "0x1263954")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x1263A80", Offset = "0x1263A80", VA = "0x1263A80")]
		public void AddNode(Node newNode)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1263B2C", Offset = "0x1263B2C", VA = "0x1263B2C")]
		public void RemoveNode(Node node)
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1263B9C", Offset = "0x1263B9C", VA = "0x1263B9C")]
		public void SetFirstNode(Node node)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x12638A4", Offset = "0x12638A4", VA = "0x12638A4")]
		public void ChangeNode(Node newNode)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1263C78", Offset = "0x1263C78", VA = "0x1263C78")]
		public void SetPendingNodeChange(Node newNode)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1263DC0", Offset = "0x1263DC0", VA = "0x1263DC0")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1263DC8", Offset = "0x1263DC8", VA = "0x1263DC8")]
		public void Restart()
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1263DD0", Offset = "0x1263DD0", VA = "0x1263DD0")]
		private void NodeFinished()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1263EE8", Offset = "0x1263EE8", VA = "0x1263EE8", Slot = "6")]
		public virtual bool UpdateNode()
		{
			return default(bool);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1263FB4", Offset = "0x1263FB4", VA = "0x1263FB4")]
		public BehaviourSystem()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class BehaviourTree : BehaviourSystem
	{
		[Token(Token = "0x400028A")]
		private const int m_maxIterationCount = 64;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[HideInInspector]
		private State m_ownerState;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool m_doStateIteration;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921998", Offset = "0x921998")]
		private Branch <LastBranch>k__BackingField;

		[Token(Token = "0x17000080")]
		public State OwnerState
		{
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1264024", Offset = "0x1264024", VA = "0x1264024")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x126402C", Offset = "0x126402C", VA = "0x126402C")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public Branch LastBranch
		{
			[Token(Token = "0x6000599")]
			[Address(RVA = "0x1264034", Offset = "0x1264034", VA = "0x1264034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D14", Offset = "0x923D14")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x126403C", Offset = "0x126403C", VA = "0x126403C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D24", Offset = "0x923D24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public override bool IsLooping
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1264044", Offset = "0x1264044", VA = "0x1264044", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x126404C", Offset = "0x126404C", VA = "0x126404C", Slot = "6")]
		public override bool UpdateNode()
		{
			return default(bool);
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x12641D8", Offset = "0x12641D8", VA = "0x12641D8")]
		public BehaviourTree()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class BE_Objective
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<Func<bool>> m_objectiveConditions;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x12630B0", Offset = "0x12630B0", VA = "0x12630B0")]
		public BE_Objective([Optional] Func<bool> condition)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1263150", Offset = "0x1263150", VA = "0x1263150")]
		public void AddCondition(Func<bool> condition)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x12631C0", Offset = "0x12631C0", VA = "0x12631C0")]
		public bool AreAllConditionsMet()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000AB")]
	public class StateMachine : BehaviourSystem
	{
		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private bool m_isLooping;

		[Token(Token = "0x17000083")]
		public override bool IsLooping
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1270CEC", Offset = "0x1270CEC", VA = "0x1270CEC", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1270CF4", Offset = "0x1270CF4", VA = "0x1270CF4", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1270D00", Offset = "0x1270D00", VA = "0x1270D00")]
		public StateMachine()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Transition
{
	[Serializable]
	[Token(Token = "0x20000AC")]
	public class BE_Transition
	{
		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Node From;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Node To;

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1270D04", Offset = "0x1270D04", VA = "0x1270D04")]
		public BE_Transition(Node from, Node to)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Nodes
{
	[Token(Token = "0x20000AD")]
	public class Branch : Node
	{
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x126F708", Offset = "0x126F708", VA = "0x126F708", Slot = "6")]
		public override void UpdateNode()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x126F818", Offset = "0x126F818", VA = "0x126F818")]
		public Branch()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class Node : ScriptableObject
	{
		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<BE_Transition> m_transitions;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<BE_Action> m_beActions;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BE_Transition m_activeTransition;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<BE_Action> m_actionsToProcessThisUpdate;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<BE_Action> m_processedActionsThisUpdate;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<BE_Action> m_finishedActions;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9219D8", Offset = "0x9219D8")]
		private string <Name>k__BackingField;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9219E8", Offset = "0x9219E8")]
		private MonoBehaviour <Owner>k__BackingField;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9219F8", Offset = "0x9219F8")]
		private bool <IsRunning>k__BackingField;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921A08", Offset = "0x921A08")]
		private bool <IsFinished>k__BackingField;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921A18", Offset = "0x921A18")]
		private int <Index>k__BackingField;

		[Token(Token = "0x17000084")]
		public List<BE_Action> Actions
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x126F918", Offset = "0x126F918", VA = "0x126F918")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		public string Name
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x126F920", Offset = "0x126F920", VA = "0x126F920")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D34", Offset = "0x923D34")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x126F928", Offset = "0x126F928", VA = "0x126F928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D44", Offset = "0x923D44")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public MonoBehaviour Owner
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x125FC30", Offset = "0x125FC30", VA = "0x125FC30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D54", Offset = "0x923D54")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x126F930", Offset = "0x126F930", VA = "0x126F930")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D64", Offset = "0x923D64")]
			private set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public bool IsRunning
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x126F938", Offset = "0x126F938", VA = "0x126F938")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D74", Offset = "0x923D74")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x126F940", Offset = "0x126F940", VA = "0x126F940")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D84", Offset = "0x923D84")]
			private set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public bool IsFinished
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1263FAC", Offset = "0x1263FAC", VA = "0x1263FAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923D94", Offset = "0x923D94")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x126F80C", Offset = "0x126F80C", VA = "0x126F80C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DA4", Offset = "0x923DA4")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public int Index
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x126F94C", Offset = "0x126F94C", VA = "0x126F94C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DB4", Offset = "0x923DB4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x126F954", Offset = "0x126F954", VA = "0x126F954")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DC4", Offset = "0x923DC4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x126F95C", Offset = "0x126F95C", VA = "0x126F95C")]
		private void RemoveActionSubAsset(BE_Action action)
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x126F9FC", Offset = "0x126F9FC", VA = "0x126F9FC")]
		public void Initialize(string name)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x126FA7C", Offset = "0x126FA7C", VA = "0x126FA7C", Slot = "4")]
		public virtual void SetOwner(BehaviourSystem system, MonoBehaviour owner)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1263688", Offset = "0x1263688", VA = "0x1263688")]
		public void UpdateTransitions(List<Node> oldStates, List<Node> newStates)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x126FC24", Offset = "0x126FC24", VA = "0x126FC24", Slot = "5")]
		public virtual void UpdateReferences()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x126FC28", Offset = "0x126FC28", VA = "0x126FC28")]
		public void UpdateActions()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x126FDE8", Offset = "0x126FDE8", VA = "0x126FDE8")]
		public void AddActionInstance(BE_Action action)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x126FE68", Offset = "0x126FE68", VA = "0x126FE68")]
		public void RemoveActionInstance(BE_Action action)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x126FF14", Offset = "0x126FF14", VA = "0x126FF14")]
		public void ClearTransitions()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x126FF74", Offset = "0x126FF74", VA = "0x126FF74")]
		public void AddTransition(BE_Transition transition)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x126FFE4", Offset = "0x126FFE4", VA = "0x126FFE4")]
		public List<BE_Transition> GetTransitions()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1263C0C", Offset = "0x1263C0C", VA = "0x1263C0C")]
		public void EnterState()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1263BA4", Offset = "0x1263BA4", VA = "0x1263BA4")]
		public void ExitState()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1263CA8", Offset = "0x1263CA8", VA = "0x1263CA8")]
		public void ForceFinish()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1263EE0", Offset = "0x1263EE0", VA = "0x1263EE0")]
		public BE_Transition GetActiveTransition()
		{
			return null;
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x125F0E4", Offset = "0x125F0E4", VA = "0x125F0E4")]
		public void OnActionFinished(BE_Action action)
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x125F7DC", Offset = "0x125F7DC", VA = "0x125F7DC")]
		public void PerformTransition(int index)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1270054", Offset = "0x1270054", VA = "0x1270054")]
		private void AddActionsToProcess()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1270188", Offset = "0x1270188", VA = "0x1270188")]
		public void ProcessActions()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x126F730", Offset = "0x126F730", VA = "0x126F730", Slot = "6")]
		public virtual void UpdateNode()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1270400", Offset = "0x1270400", VA = "0x1270400")]
		public void OnRemove()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x126F81C", Offset = "0x126F81C", VA = "0x126F81C")]
		public Node()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class State : Node
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<BehaviourTree> m_behaviourTrees;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921A38", Offset = "0x921A38")]
		private Branch <CurrentBranch>k__BackingField;

		[Token(Token = "0x1700008A")]
		public List<BehaviourTree> BehaviourTrees
		{
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x1270720", Offset = "0x1270720", VA = "0x1270720")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008B")]
		public Branch CurrentBranch
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1270728", Offset = "0x1270728", VA = "0x1270728")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DD4", Offset = "0x923DD4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1270730", Offset = "0x1270730", VA = "0x1270730")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DE4", Offset = "0x923DE4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1270738", Offset = "0x1270738", VA = "0x1270738", Slot = "4")]
		public override void SetOwner(BehaviourSystem system, MonoBehaviour owner)
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x12708E8", Offset = "0x12708E8", VA = "0x12708E8", Slot = "5")]
		public override void UpdateReferences()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1270A14", Offset = "0x1270A14", VA = "0x1270A14")]
		public void AddBehaviourTreeInstance(BehaviourTree behaviourTree)
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1270A94", Offset = "0x1270A94", VA = "0x1270A94")]
		public void RemoveActionInstance(BehaviourTree behaviourTree)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1270B40", Offset = "0x1270B40", VA = "0x1270B40", Slot = "6")]
		public override void UpdateNode()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1270C7C", Offset = "0x1270C7C", VA = "0x1270C7C")]
		public State()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Nodes.Properties
{
	[Token(Token = "0x20000B0")]
	public static class NodeColor
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static IDictionary<NodePriority, Color> StateTypeColorDictionary;

		[Token(Token = "0x1700008C")]
		public static Color Neutral
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1270468", Offset = "0x1270468", VA = "0x1270468")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x1700008D")]
		public static Color Normal
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1270470", Offset = "0x1270470", VA = "0x1270470")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x1700008E")]
		public static Color Prioritized
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1270478", Offset = "0x1270478", VA = "0x1270478")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x1700008F")]
		public static Color Imminent
		{
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1270480", Offset = "0x1270480", VA = "0x1270480")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1270488", Offset = "0x1270488", VA = "0x1270488")]
		public static Color GetStateColor(NodePriority type)
		{
			return default(Color);
		}
	}
	[Token(Token = "0x20000B1")]
	public enum NodePriority
	{
		[Token(Token = "0x40002A1")]
		Normal,
		[Token(Token = "0x40002A2")]
		Prioritized,
		[Token(Token = "0x40002A3")]
		Imminent
	}
}
namespace Cortopia.BE.Runtime.Managers
{
	[Token(Token = "0x20000B2")]
	public static class ReferenceManager
	{
		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static IDictionary<BehaviourSystem, BehaviourSystem> sm_behaviourSystemMapping;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static IDictionary<Node, Node> sm_nodeMapping;

		[Token(Token = "0x60005D7")]
		public static T InstantiateBehaviourSystem<T>(T original) where T : BehaviourSystem
		{
			return null;
		}

		[Token(Token = "0x60005D8")]
		public static T InstantiateNode<T>(T original) where T : Node
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		public static T GetBehaviourSystemInstance<T>(T original) where T : BehaviourSystem
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		public static T GetNodeInstance<T>(T original) where T : Node
		{
			return null;
		}
	}
}
namespace Cortopia.BE.Runtime.Instance
{
	[Token(Token = "0x20000B3")]
	public class BE_AI : MonoBehaviour
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BehaviourSystem m_behaviourAsset;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string m_currentStateName;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float m_updateInterval;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_updateintervalDelta;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921A68", Offset = "0x921A68")]
		private BE_Objective <Objective>k__BackingField;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_initialized;

		[Token(Token = "0x17000090")]
		public BE_Objective Objective
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x126F39C", Offset = "0x126F39C", VA = "0x126F39C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923DF4", Offset = "0x923DF4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x126F3A4", Offset = "0x126F3A4", VA = "0x126F3A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E04", Offset = "0x923E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public BehaviourSystem BehaviourSystem
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x126F3AC", Offset = "0x126F3AC", VA = "0x126F3AC")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x126F3B4", Offset = "0x126F3B4", VA = "0x126F3B4")]
			set
			{
			}
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x126F3BC", Offset = "0x126F3BC", VA = "0x126F3BC", Slot = "4")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x126F524", Offset = "0x126F524", VA = "0x126F524", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x126F65C", Offset = "0x126F65C", VA = "0x126F65C")]
		public BE_AI()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Events
{
	[Token(Token = "0x20000B4")]
	public class EventDelegate : MonoBehaviour
	{
		[Token(Token = "0x200016C")]
		public delegate void EventHandler();

		[Token(Token = "0x200016D")]
		public delegate void EventHandlerParam<TParam>(TParam param);

		[Token(Token = "0x200016E")]
		public delegate void EventHandlerMultipleParam<TParam1, TParam2>(TParam1 param1, TParam2 param2);

		[Serializable]
		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9216B8", Offset = "0x9216B8")]
		private sealed class <>c
		{
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static EventHandler <>9__200_0;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static EventHandler <>9__200_1;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static EventHandler <>9__200_2;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public static EventHandlerParam<int> <>9__200_3;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public static EventHandler <>9__200_4;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public static EventHandlerParam<bool> <>9__200_5;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public static EventHandlerParam<bool> <>9__200_6;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public static EventHandler <>9__200_7;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public static EventHandlerMultipleParam<float[], int> <>9__200_8;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public static EventHandler <>9__200_9;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public static EventHandler <>9__200_10;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public static EventHandlerParam<Collision> <>9__200_11;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public static EventHandlerParam<Collision2D> <>9__200_12;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public static EventHandlerParam<Collision> <>9__200_13;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public static EventHandlerParam<Collision2D> <>9__200_14;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public static EventHandlerParam<Collision> <>9__200_15;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public static EventHandlerParam<Collision2D> <>9__200_16;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public static EventHandler <>9__200_17;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public static EventHandlerParam<ControllerColliderHit> <>9__200_18;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public static EventHandler <>9__200_19;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public static EventHandler <>9__200_20;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public static EventHandler <>9__200_21;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public static EventHandler <>9__200_22;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public static EventHandler <>9__200_23;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			public static EventHandler <>9__200_24;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			public static EventHandlerParam<float> <>9__200_25;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			public static EventHandler <>9__200_26;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
			public static EventHandler <>9__200_27;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			public static EventHandler <>9__200_28;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			public static EventHandler <>9__200_29;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			public static EventHandler <>9__200_30;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
			public static EventHandler <>9__200_31;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			public static EventHandler <>9__200_32;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			public static EventHandlerParam<GameObject> <>9__200_33;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			public static EventHandler <>9__200_34;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			public static EventHandler <>9__200_35;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public static EventHandler <>9__200_36;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public static EventHandlerMultipleParam<RenderTexture, RenderTexture> <>9__200_37;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public static EventHandler <>9__200_38;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			public static EventHandler <>9__200_39;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
			public static EventHandlerParam<Collider> <>9__200_40;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			public static EventHandlerParam<Collider2D> <>9__200_41;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
			public static EventHandlerParam<Collider> <>9__200_42;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public static EventHandlerParam<Collider2D> <>9__200_43;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public static EventHandlerParam<Collider> <>9__200_44;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			public static EventHandlerParam<Collider2D> <>9__200_45;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
			public static EventHandler <>9__200_46;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			public static EventHandler <>9__200_47;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			public static EventHandler <>9__200_48;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
			public static EventHandler <>9__200_49;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			public static EventHandler <>9__200_50;

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x126F288", Offset = "0x126F288", VA = "0x126F288")]
			public <>c()
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x126F290", Offset = "0x126F290", VA = "0x126F290")]
			internal void <.ctor>b__200_0()
			{
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x126F294", Offset = "0x126F294", VA = "0x126F294")]
			internal void <.ctor>b__200_1()
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x126F298", Offset = "0x126F298", VA = "0x126F298")]
			internal void <.ctor>b__200_2()
			{
			}

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x126F29C", Offset = "0x126F29C", VA = "0x126F29C")]
			internal void <.ctor>b__200_3(int layerIndex)
			{
			}

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x126F2A0", Offset = "0x126F2A0", VA = "0x126F2A0")]
			internal void <.ctor>b__200_4()
			{
			}

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x126F2A4", Offset = "0x126F2A4", VA = "0x126F2A4")]
			internal void <.ctor>b__200_5(bool focusStatus)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x126F2A8", Offset = "0x126F2A8", VA = "0x126F2A8")]
			internal void <.ctor>b__200_6(bool pauseStatus)
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x126F2AC", Offset = "0x126F2AC", VA = "0x126F2AC")]
			internal void <.ctor>b__200_7()
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x126F2B0", Offset = "0x126F2B0", VA = "0x126F2B0")]
			internal void <.ctor>b__200_8(float[] data, int channels)
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x126F2B4", Offset = "0x126F2B4", VA = "0x126F2B4")]
			internal void <.ctor>b__200_9()
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x126F2B8", Offset = "0x126F2B8", VA = "0x126F2B8")]
			internal void <.ctor>b__200_10()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x126F2BC", Offset = "0x126F2BC", VA = "0x126F2BC")]
			internal void <.ctor>b__200_11(Collision collision)
			{
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0x126F2C0", Offset = "0x126F2C0", VA = "0x126F2C0")]
			internal void <.ctor>b__200_12(Collision2D collision)
			{
			}

			[Token(Token = "0x6000965")]
			[Address(RVA = "0x126F2C4", Offset = "0x126F2C4", VA = "0x126F2C4")]
			internal void <.ctor>b__200_13(Collision collision)
			{
			}

			[Token(Token = "0x6000966")]
			[Address(RVA = "0x126F2C8", Offset = "0x126F2C8", VA = "0x126F2C8")]
			internal void <.ctor>b__200_14(Collision2D collision)
			{
			}

			[Token(Token = "0x6000967")]
			[Address(RVA = "0x126F2CC", Offset = "0x126F2CC", VA = "0x126F2CC")]
			internal void <.ctor>b__200_15(Collision collision)
			{
			}

			[Token(Token = "0x6000968")]
			[Address(RVA = "0x126F2D0", Offset = "0x126F2D0", VA = "0x126F2D0")]
			internal void <.ctor>b__200_16(Collision2D collision)
			{
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x126F2D4", Offset = "0x126F2D4", VA = "0x126F2D4")]
			internal void <.ctor>b__200_17()
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x126F2D8", Offset = "0x126F2D8", VA = "0x126F2D8")]
			internal void <.ctor>b__200_18(ControllerColliderHit hit)
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x126F2DC", Offset = "0x126F2DC", VA = "0x126F2DC")]
			internal void <.ctor>b__200_19()
			{
			}

			[Token(Token = "0x600096C")]
			[Address(RVA = "0x126F2E0", Offset = "0x126F2E0", VA = "0x126F2E0")]
			internal void <.ctor>b__200_20()
			{
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x126F2E4", Offset = "0x126F2E4", VA = "0x126F2E4")]
			internal void <.ctor>b__200_21()
			{
			}

			[Token(Token = "0x600096E")]
			[Address(RVA = "0x126F2E8", Offset = "0x126F2E8", VA = "0x126F2E8")]
			internal void <.ctor>b__200_22()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x126F2EC", Offset = "0x126F2EC", VA = "0x126F2EC")]
			internal void <.ctor>b__200_23()
			{
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x126F2F0", Offset = "0x126F2F0", VA = "0x126F2F0")]
			internal void <.ctor>b__200_24()
			{
			}

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x126F2F4", Offset = "0x126F2F4", VA = "0x126F2F4")]
			internal void <.ctor>b__200_25(float breakForce)
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x126F2F8", Offset = "0x126F2F8", VA = "0x126F2F8")]
			internal void <.ctor>b__200_26()
			{
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x126F2FC", Offset = "0x126F2FC", VA = "0x126F2FC")]
			internal void <.ctor>b__200_27()
			{
			}

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x126F300", Offset = "0x126F300", VA = "0x126F300")]
			internal void <.ctor>b__200_28()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x126F304", Offset = "0x126F304", VA = "0x126F304")]
			internal void <.ctor>b__200_29()
			{
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x126F308", Offset = "0x126F308", VA = "0x126F308")]
			internal void <.ctor>b__200_30()
			{
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x126F30C", Offset = "0x126F30C", VA = "0x126F30C")]
			internal void <.ctor>b__200_31()
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x126F310", Offset = "0x126F310", VA = "0x126F310")]
			internal void <.ctor>b__200_32()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x126F314", Offset = "0x126F314", VA = "0x126F314")]
			internal void <.ctor>b__200_33(GameObject other)
			{
			}

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x126F318", Offset = "0x126F318", VA = "0x126F318")]
			internal void <.ctor>b__200_34()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x126F31C", Offset = "0x126F31C", VA = "0x126F31C")]
			internal void <.ctor>b__200_35()
			{
			}

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x126F320", Offset = "0x126F320", VA = "0x126F320")]
			internal void <.ctor>b__200_36()
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x126F324", Offset = "0x126F324", VA = "0x126F324")]
			internal void <.ctor>b__200_37(RenderTexture src, RenderTexture dest)
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x126F328", Offset = "0x126F328", VA = "0x126F328")]
			internal void <.ctor>b__200_38()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x126F32C", Offset = "0x126F32C", VA = "0x126F32C")]
			internal void <.ctor>b__200_39()
			{
			}

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x126F330", Offset = "0x126F330", VA = "0x126F330")]
			internal void <.ctor>b__200_40(Collider other)
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x126F334", Offset = "0x126F334", VA = "0x126F334")]
			internal void <.ctor>b__200_41(Collider2D other)
			{
			}

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x126F338", Offset = "0x126F338", VA = "0x126F338")]
			internal void <.ctor>b__200_42(Collider other)
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x126F33C", Offset = "0x126F33C", VA = "0x126F33C")]
			internal void <.ctor>b__200_43(Collider2D other)
			{
			}

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x126F340", Offset = "0x126F340", VA = "0x126F340")]
			internal void <.ctor>b__200_44(Collider other)
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x126F344", Offset = "0x126F344", VA = "0x126F344")]
			internal void <.ctor>b__200_45(Collider2D other)
			{
			}

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x126F348", Offset = "0x126F348", VA = "0x126F348")]
			internal void <.ctor>b__200_46()
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x126F34C", Offset = "0x126F34C", VA = "0x126F34C")]
			internal void <.ctor>b__200_47()
			{
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x126F350", Offset = "0x126F350", VA = "0x126F350")]
			internal void <.ctor>b__200_48()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x126F354", Offset = "0x126F354", VA = "0x126F354")]
			internal void <.ctor>b__200_49()
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x126F358", Offset = "0x126F358", VA = "0x126F358")]
			internal void <.ctor>b__200_50()
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event EventHandler AwakeEvent
		{
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x1267308", Offset = "0x1267308", VA = "0x1267308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E14", Offset = "0x923E14")]
			add
			{
			}
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x12673F4", Offset = "0x12673F4", VA = "0x12673F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E24", Offset = "0x923E24")]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event EventHandler FixedUpdateEvent
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x12674E0", Offset = "0x12674E0", VA = "0x12674E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E34", Offset = "0x923E34")]
			add
			{
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x12675CC", Offset = "0x12675CC", VA = "0x12675CC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E44", Offset = "0x923E44")]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event EventHandler LateUpdateEvent
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x12676B8", Offset = "0x12676B8", VA = "0x12676B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E54", Offset = "0x923E54")]
			add
			{
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x12677A4", Offset = "0x12677A4", VA = "0x12677A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E64", Offset = "0x923E64")]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public event EventHandlerParam<int> OnAnimatorIKEvent
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1267890", Offset = "0x1267890", VA = "0x1267890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E74", Offset = "0x923E74")]
			add
			{
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x126797C", Offset = "0x126797C", VA = "0x126797C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E84", Offset = "0x923E84")]
			remove
			{
			}
		}

		[Token(Token = "0x14000008")]
		public event EventHandler OnAnimatorMoveEvent
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1267A68", Offset = "0x1267A68", VA = "0x1267A68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923E94", Offset = "0x923E94")]
			add
			{
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1267B54", Offset = "0x1267B54", VA = "0x1267B54")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923EA4", Offset = "0x923EA4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public event EventHandlerParam<bool> OnApplicationFocusEvent
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1267C40", Offset = "0x1267C40", VA = "0x1267C40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923EB4", Offset = "0x923EB4")]
			add
			{
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1267D2C", Offset = "0x1267D2C", VA = "0x1267D2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923EC4", Offset = "0x923EC4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000A")]
		public event EventHandlerParam<bool> OnApplicationPauseEvent
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1267E18", Offset = "0x1267E18", VA = "0x1267E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923ED4", Offset = "0x923ED4")]
			add
			{
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1267F04", Offset = "0x1267F04", VA = "0x1267F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923EE4", Offset = "0x923EE4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000B")]
		public event EventHandler OnApplicationQuitEvent
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x1267FF0", Offset = "0x1267FF0", VA = "0x1267FF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923EF4", Offset = "0x923EF4")]
			add
			{
			}
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x12680DC", Offset = "0x12680DC", VA = "0x12680DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F04", Offset = "0x923F04")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public event EventHandlerMultipleParam<float[], int> OnAudioFilterReadEvent
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x12681C8", Offset = "0x12681C8", VA = "0x12681C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F14", Offset = "0x923F14")]
			add
			{
			}
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x12682B4", Offset = "0x12682B4", VA = "0x12682B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F24", Offset = "0x923F24")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000D")]
		public event EventHandler OnBecameInvisibleEvent
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x12683A0", Offset = "0x12683A0", VA = "0x12683A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F34", Offset = "0x923F34")]
			add
			{
			}
			[Token(Token = "0x60005F6")]
			[Address(RVA = "0x126848C", Offset = "0x126848C", VA = "0x126848C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F44", Offset = "0x923F44")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler OnBecameVisibleEvent
		{
			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1268578", Offset = "0x1268578", VA = "0x1268578")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F54", Offset = "0x923F54")]
			add
			{
			}
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1268664", Offset = "0x1268664", VA = "0x1268664")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F64", Offset = "0x923F64")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000F")]
		public event EventHandlerParam<Collision> OnCollisionEnterEvent
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x12601A8", Offset = "0x12601A8", VA = "0x12601A8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F74", Offset = "0x923F74")]
			add
			{
			}
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x12605D8", Offset = "0x12605D8", VA = "0x12605D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F84", Offset = "0x923F84")]
			remove
			{
			}
		}

		[Token(Token = "0x14000010")]
		public event EventHandlerParam<Collision2D> OnCollisionEnter2DEvent
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1268750", Offset = "0x1268750", VA = "0x1268750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923F94", Offset = "0x923F94")]
			add
			{
			}
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x126883C", Offset = "0x126883C", VA = "0x126883C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FA4", Offset = "0x923FA4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000011")]
		public event EventHandlerParam<Collision> OnCollisionExitEvent
		{
			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x12613F4", Offset = "0x12613F4", VA = "0x12613F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FB4", Offset = "0x923FB4")]
			add
			{
			}
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x12614E0", Offset = "0x12614E0", VA = "0x12614E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FC4", Offset = "0x923FC4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000012")]
		public event EventHandlerParam<Collision2D> OnCollisionExit2DEvent
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1268928", Offset = "0x1268928", VA = "0x1268928")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FD4", Offset = "0x923FD4")]
			add
			{
			}
			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1268A14", Offset = "0x1268A14", VA = "0x1268A14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FE4", Offset = "0x923FE4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000013")]
		public event EventHandlerParam<Collision> OnCollisionStayEvent
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0x126121C", Offset = "0x126121C", VA = "0x126121C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x923FF4", Offset = "0x923FF4")]
			add
			{
			}
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1261308", Offset = "0x1261308", VA = "0x1261308")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924004", Offset = "0x924004")]
			remove
			{
			}
		}

		[Token(Token = "0x14000014")]
		public event EventHandlerParam<Collision2D> OnCollisionStay2DEvent
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1268B00", Offset = "0x1268B00", VA = "0x1268B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924014", Offset = "0x924014")]
			add
			{
			}
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1268BEC", Offset = "0x1268BEC", VA = "0x1268BEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924024", Offset = "0x924024")]
			remove
			{
			}
		}

		[Token(Token = "0x14000015")]
		public event EventHandler OnConnectedToServerEvent
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1268CD8", Offset = "0x1268CD8", VA = "0x1268CD8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924034", Offset = "0x924034")]
			add
			{
			}
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1268DC4", Offset = "0x1268DC4", VA = "0x1268DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924044", Offset = "0x924044")]
			remove
			{
			}
		}

		[Token(Token = "0x14000016")]
		public event EventHandlerParam<ControllerColliderHit> OnControllerColliderHitEvent
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1268EB0", Offset = "0x1268EB0", VA = "0x1268EB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924054", Offset = "0x924054")]
			add
			{
			}
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1268F9C", Offset = "0x1268F9C", VA = "0x1268F9C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924064", Offset = "0x924064")]
			remove
			{
			}
		}

		[Token(Token = "0x14000017")]
		public event EventHandler OnDestroyEvent
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x12602A4", Offset = "0x12602A4", VA = "0x12602A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924074", Offset = "0x924074")]
			add
			{
			}
			[Token(Token = "0x600060A")]
			[Address(RVA = "0x12606C4", Offset = "0x12606C4", VA = "0x12606C4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924084", Offset = "0x924084")]
			remove
			{
			}
		}

		[Token(Token = "0x14000018")]
		public event EventHandler OnDisableEvent
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1269088", Offset = "0x1269088", VA = "0x1269088")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924094", Offset = "0x924094")]
			add
			{
			}
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1269174", Offset = "0x1269174", VA = "0x1269174")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240A4", Offset = "0x9240A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000019")]
		public event EventHandler OnDrawGizmosEvent
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1269260", Offset = "0x1269260", VA = "0x1269260")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240B4", Offset = "0x9240B4")]
			add
			{
			}
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x126934C", Offset = "0x126934C", VA = "0x126934C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240C4", Offset = "0x9240C4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001A")]
		public event EventHandler OnDrawGizmosSelectedEvent
		{
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1269438", Offset = "0x1269438", VA = "0x1269438")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240D4", Offset = "0x9240D4")]
			add
			{
			}
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1269524", Offset = "0x1269524", VA = "0x1269524")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240E4", Offset = "0x9240E4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001B")]
		public event EventHandler OnEnableEvent
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1269610", Offset = "0x1269610", VA = "0x1269610")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9240F4", Offset = "0x9240F4")]
			add
			{
			}
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x12696FC", Offset = "0x12696FC", VA = "0x12696FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924104", Offset = "0x924104")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001C")]
		public event EventHandler OnGUIEvent
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x12697E8", Offset = "0x12697E8", VA = "0x12697E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924114", Offset = "0x924114")]
			add
			{
			}
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x12698D4", Offset = "0x12698D4", VA = "0x12698D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924124", Offset = "0x924124")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001D")]
		public event EventHandlerParam<float> OnJointBreakEvent
		{
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x12699C0", Offset = "0x12699C0", VA = "0x12699C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924134", Offset = "0x924134")]
			add
			{
			}
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1269AAC", Offset = "0x1269AAC", VA = "0x1269AAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924144", Offset = "0x924144")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001E")]
		public event EventHandler OnMouseDownEvent
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1269B98", Offset = "0x1269B98", VA = "0x1269B98")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924154", Offset = "0x924154")]
			add
			{
			}
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1269C84", Offset = "0x1269C84", VA = "0x1269C84")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924164", Offset = "0x924164")]
			remove
			{
			}
		}

		[Token(Token = "0x1400001F")]
		public event EventHandler OnMouseDragEvent
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1269D70", Offset = "0x1269D70", VA = "0x1269D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924174", Offset = "0x924174")]
			add
			{
			}
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1269E5C", Offset = "0x1269E5C", VA = "0x1269E5C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924184", Offset = "0x924184")]
			remove
			{
			}
		}

		[Token(Token = "0x14000020")]
		public event EventHandler OnMouseEnterEvent
		{
			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1269F48", Offset = "0x1269F48", VA = "0x1269F48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924194", Offset = "0x924194")]
			add
			{
			}
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x126A034", Offset = "0x126A034", VA = "0x126A034")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241A4", Offset = "0x9241A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000021")]
		public event EventHandler OnMouseExitEvent
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0x126A120", Offset = "0x126A120", VA = "0x126A120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241B4", Offset = "0x9241B4")]
			add
			{
			}
			[Token(Token = "0x600061E")]
			[Address(RVA = "0x126A210", Offset = "0x126A210", VA = "0x126A210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241C4", Offset = "0x9241C4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000022")]
		public event EventHandler OnMouseOverEvent
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0x126A300", Offset = "0x126A300", VA = "0x126A300")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241D4", Offset = "0x9241D4")]
			add
			{
			}
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x126A3F0", Offset = "0x126A3F0", VA = "0x126A3F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241E4", Offset = "0x9241E4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000023")]
		public event EventHandler OnMouseUpEvent
		{
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x126A4E0", Offset = "0x126A4E0", VA = "0x126A4E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9241F4", Offset = "0x9241F4")]
			add
			{
			}
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x126A5D0", Offset = "0x126A5D0", VA = "0x126A5D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924204", Offset = "0x924204")]
			remove
			{
			}
		}

		[Token(Token = "0x14000024")]
		public event EventHandler OnMouseUpAsButtonEvent
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x126A6C0", Offset = "0x126A6C0", VA = "0x126A6C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924214", Offset = "0x924214")]
			add
			{
			}
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x126A7B0", Offset = "0x126A7B0", VA = "0x126A7B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924224", Offset = "0x924224")]
			remove
			{
			}
		}

		[Token(Token = "0x14000025")]
		public event EventHandlerParam<GameObject> OnParticleCollisionEvent
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x126A8A0", Offset = "0x126A8A0", VA = "0x126A8A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924234", Offset = "0x924234")]
			add
			{
			}
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x126A990", Offset = "0x126A990", VA = "0x126A990")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924244", Offset = "0x924244")]
			remove
			{
			}
		}

		[Token(Token = "0x14000026")]
		public event EventHandler OnPostRenderEvent
		{
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x126AA80", Offset = "0x126AA80", VA = "0x126AA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924254", Offset = "0x924254")]
			add
			{
			}
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x126AB70", Offset = "0x126AB70", VA = "0x126AB70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924264", Offset = "0x924264")]
			remove
			{
			}
		}

		[Token(Token = "0x14000027")]
		public event EventHandler OnPreCullEvent
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x126AC60", Offset = "0x126AC60", VA = "0x126AC60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924274", Offset = "0x924274")]
			add
			{
			}
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x126AD50", Offset = "0x126AD50", VA = "0x126AD50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924284", Offset = "0x924284")]
			remove
			{
			}
		}

		[Token(Token = "0x14000028")]
		public event EventHandler OnPreRenderEvent
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x126AE40", Offset = "0x126AE40", VA = "0x126AE40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924294", Offset = "0x924294")]
			add
			{
			}
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x126AF30", Offset = "0x126AF30", VA = "0x126AF30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242A4", Offset = "0x9242A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000029")]
		public event EventHandlerMultipleParam<RenderTexture, RenderTexture> OnRenderImageEvent
		{
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x126B020", Offset = "0x126B020", VA = "0x126B020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242B4", Offset = "0x9242B4")]
			add
			{
			}
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x126B110", Offset = "0x126B110", VA = "0x126B110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242C4", Offset = "0x9242C4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002A")]
		public event EventHandler OnRenderObjectEvent
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x126B200", Offset = "0x126B200", VA = "0x126B200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242D4", Offset = "0x9242D4")]
			add
			{
			}
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x126B2F0", Offset = "0x126B2F0", VA = "0x126B2F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242E4", Offset = "0x9242E4")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002B")]
		public event EventHandler OnServerInitializedEvent
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x126B3E0", Offset = "0x126B3E0", VA = "0x126B3E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9242F4", Offset = "0x9242F4")]
			add
			{
			}
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x126B4D0", Offset = "0x126B4D0", VA = "0x126B4D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924304", Offset = "0x924304")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002C")]
		public event EventHandlerParam<Collider> OnTriggerEnterEvent
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x12600B8", Offset = "0x12600B8", VA = "0x12600B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924314", Offset = "0x924314")]
			add
			{
			}
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x12604E8", Offset = "0x12604E8", VA = "0x12604E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924324", Offset = "0x924324")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002D")]
		public event EventHandlerParam<Collider2D> OnTriggerEnter2DEvent
		{
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x126B5C0", Offset = "0x126B5C0", VA = "0x126B5C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924334", Offset = "0x924334")]
			add
			{
			}
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x126B6B0", Offset = "0x126B6B0", VA = "0x126B6B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924344", Offset = "0x924344")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002E")]
		public event EventHandlerParam<Collider> OnTriggerExitEvent
		{
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x126199C", Offset = "0x126199C", VA = "0x126199C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924354", Offset = "0x924354")]
			add
			{
			}
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x1261BE4", Offset = "0x1261BE4", VA = "0x1261BE4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924364", Offset = "0x924364")]
			remove
			{
			}
		}

		[Token(Token = "0x1400002F")]
		public event EventHandlerParam<Collider2D> OnTriggerExit2DEvent
		{
			[Token(Token = "0x6000639")]
			[Address(RVA = "0x126B7A0", Offset = "0x126B7A0", VA = "0x126B7A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924374", Offset = "0x924374")]
			add
			{
			}
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x126B890", Offset = "0x126B890", VA = "0x126B890")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924384", Offset = "0x924384")]
			remove
			{
			}
		}

		[Token(Token = "0x14000030")]
		public event EventHandlerParam<Collider> OnTriggerStayEvent
		{
			[Token(Token = "0x600063B")]
			[Address(RVA = "0x126B980", Offset = "0x126B980", VA = "0x126B980")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924394", Offset = "0x924394")]
			add
			{
			}
			[Token(Token = "0x600063C")]
			[Address(RVA = "0x126BA70", Offset = "0x126BA70", VA = "0x126BA70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243A4", Offset = "0x9243A4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000031")]
		public event EventHandlerParam<Collider2D> OnTriggerStay2DEvent
		{
			[Token(Token = "0x600063D")]
			[Address(RVA = "0x126BB60", Offset = "0x126BB60", VA = "0x126BB60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243B4", Offset = "0x9243B4")]
			add
			{
			}
			[Token(Token = "0x600063E")]
			[Address(RVA = "0x126BC50", Offset = "0x126BC50", VA = "0x126BC50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243C4", Offset = "0x9243C4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000032")]
		public event EventHandler OnValidateEvent
		{
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x126BD40", Offset = "0x126BD40", VA = "0x126BD40")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243D4", Offset = "0x9243D4")]
			add
			{
			}
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x126BE30", Offset = "0x126BE30", VA = "0x126BE30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243E4", Offset = "0x9243E4")]
			remove
			{
			}
		}

		[Token(Token = "0x14000033")]
		public event EventHandler OnWillRenderObjectEvent
		{
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x126BF20", Offset = "0x126BF20", VA = "0x126BF20")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9243F4", Offset = "0x9243F4")]
			add
			{
			}
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x126C010", Offset = "0x126C010", VA = "0x126C010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924404", Offset = "0x924404")]
			remove
			{
			}
		}

		[Token(Token = "0x14000034")]
		public event EventHandler ResetEvent
		{
			[Token(Token = "0x6000643")]
			[Address(RVA = "0x126C100", Offset = "0x126C100", VA = "0x126C100")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924414", Offset = "0x924414")]
			add
			{
			}
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x126C1F0", Offset = "0x126C1F0", VA = "0x126C1F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924424", Offset = "0x924424")]
			remove
			{
			}
		}

		[Token(Token = "0x14000035")]
		public event EventHandler StartEvent
		{
			[Token(Token = "0x6000645")]
			[Address(RVA = "0x126C2E0", Offset = "0x126C2E0", VA = "0x126C2E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924434", Offset = "0x924434")]
			add
			{
			}
			[Token(Token = "0x6000646")]
			[Address(RVA = "0x126C3D0", Offset = "0x126C3D0", VA = "0x126C3D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924444", Offset = "0x924444")]
			remove
			{
			}
		}

		[Token(Token = "0x14000036")]
		public event EventHandler UpdateEvent
		{
			[Token(Token = "0x6000647")]
			[Address(RVA = "0x126C4C0", Offset = "0x126C4C0", VA = "0x126C4C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924454", Offset = "0x924454")]
			add
			{
			}
			[Token(Token = "0x6000648")]
			[Address(RVA = "0x126C5B0", Offset = "0x126C5B0", VA = "0x126C5B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924464", Offset = "0x924464")]
			remove
			{
			}
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x126C6A0", Offset = "0x126C6A0", VA = "0x126C6A0")]
		public void Awake()
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x126CACC", Offset = "0x126CACC", VA = "0x126CACC")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x126CAF8", Offset = "0x126CAF8", VA = "0x126CAF8")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x126CB24", Offset = "0x126CB24", VA = "0x126CB24")]
		public void OnAnimatorIK(int layerIndex)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x126CB94", Offset = "0x126CB94", VA = "0x126CB94")]
		public void OnAnimatorMove()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x126CBC0", Offset = "0x126CBC0", VA = "0x126CBC0")]
		public void OnApplicationFocus(bool focusStatus)
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x126CC30", Offset = "0x126CC30", VA = "0x126CC30")]
		public void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x126CCA0", Offset = "0x126CCA0", VA = "0x126CCA0")]
		public void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x126CCCC", Offset = "0x126CCCC", VA = "0x126CCCC")]
		public void OnAudioFilterRead(float[] data, int channels)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x126CD44", Offset = "0x126CD44", VA = "0x126CD44")]
		public void OnBecameInvisible()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x126CD70", Offset = "0x126CD70", VA = "0x126CD70")]
		public void OnBecameVisible()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x126CD9C", Offset = "0x126CD9C", VA = "0x126CD9C")]
		public void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x126CE0C", Offset = "0x126CE0C", VA = "0x126CE0C")]
		public void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x126CE7C", Offset = "0x126CE7C", VA = "0x126CE7C")]
		public void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x126CEEC", Offset = "0x126CEEC", VA = "0x126CEEC")]
		public void OnCollisionExit2D(Collision2D collision)
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x126CF5C", Offset = "0x126CF5C", VA = "0x126CF5C")]
		public void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x126CFCC", Offset = "0x126CFCC", VA = "0x126CFCC")]
		public void OnCollisionStay2D(Collision2D collision)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x126D03C", Offset = "0x126D03C", VA = "0x126D03C")]
		public void OnConnectedToServer()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x126D068", Offset = "0x126D068", VA = "0x126D068")]
		public void OnControllerColliderHit(ControllerColliderHit hit)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x126D0D8", Offset = "0x126D0D8", VA = "0x126D0D8")]
		public void OnDestroy()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x126D104", Offset = "0x126D104", VA = "0x126D104")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x126D130", Offset = "0x126D130", VA = "0x126D130")]
		public void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x126D15C", Offset = "0x126D15C", VA = "0x126D15C")]
		public void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x126D188", Offset = "0x126D188", VA = "0x126D188")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x126D1B4", Offset = "0x126D1B4", VA = "0x126D1B4")]
		public void OnGUI()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x126D1E0", Offset = "0x126D1E0", VA = "0x126D1E0")]
		public void OnJointBreak(float breakForce)
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x126D250", Offset = "0x126D250", VA = "0x126D250")]
		public void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x126D2C0", Offset = "0x126D2C0", VA = "0x126D2C0")]
		public void OnPostRender()
		{
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x126D2EC", Offset = "0x126D2EC", VA = "0x126D2EC")]
		public void OnPreCull()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x126D318", Offset = "0x126D318", VA = "0x126D318")]
		public void OnPreRender()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x126D344", Offset = "0x126D344", VA = "0x126D344")]
		public void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x126D3BC", Offset = "0x126D3BC", VA = "0x126D3BC")]
		public void OnRenderObject()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x126D3E8", Offset = "0x126D3E8", VA = "0x126D3E8")]
		public void OnServerInitialized()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x126D414", Offset = "0x126D414", VA = "0x126D414")]
		public void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x126D484", Offset = "0x126D484", VA = "0x126D484")]
		public void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x126D4F4", Offset = "0x126D4F4", VA = "0x126D4F4")]
		public void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x126D564", Offset = "0x126D564", VA = "0x126D564")]
		public void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x126D5D4", Offset = "0x126D5D4", VA = "0x126D5D4")]
		public void OnTriggerStay(Collider other)
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x126D644", Offset = "0x126D644", VA = "0x126D644")]
		public void OnTriggerStay2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x126D6B4", Offset = "0x126D6B4", VA = "0x126D6B4")]
		public void OnValidate()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x126D6E0", Offset = "0x126D6E0", VA = "0x126D6E0")]
		public void OnWillRenderObject()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x126D70C", Offset = "0x126D70C", VA = "0x126D70C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x126D738", Offset = "0x126D738", VA = "0x126D738")]
		public void Start()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x126D764", Offset = "0x126D764", VA = "0x126D764")]
		public void Update()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x126D790", Offset = "0x126D790", VA = "0x126D790")]
		public EventDelegate()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Events.ActionEvents
{
	[Serializable]
	[Token(Token = "0x20000B5")]
	public class ActionEvent : UnityEvent
	{
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1267300", Offset = "0x1267300", VA = "0x1267300")]
		public ActionEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000B6")]
	public class StateChangeEvent : UnityEvent<State>
	{
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x125F708", Offset = "0x125F708", VA = "0x125F708")]
		public StateChangeEvent()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses
{
	[Token(Token = "0x20000B7")]
	public class Sense : MonoBehaviour
	{
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1264B0C", Offset = "0x1264B0C", VA = "0x1264B0C")]
		public Sense()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Sight
{
	[Serializable]
	[Token(Token = "0x20000B8")]
	public struct FieldOfView
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x921DA8", Offset = "0x921DA8")]
		private float m_angle;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x921DEC", Offset = "0x921DEC")]
		private float m_distance;

		[Token(Token = "0x17000092")]
		public float Angle
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x9E0130", Offset = "0x9E0130", VA = "0x9E0130")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000093")]
		public float Distance
		{
			[Token(Token = "0x600067A")]
			[Address(RVA = "0x9E0138", Offset = "0x9E0138", VA = "0x9E0138")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000094")]
		public float AngleFromForward
		{
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x9E0140", Offset = "0x9E0140", VA = "0x9E0140")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x9E0150", Offset = "0x9E0150", VA = "0x9E0150")]
		public FieldOfView(float angle, float distance)
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public interface ISight
	{
		[Token(Token = "0x600067D")]
		Sight GetSight();
	}
	[Token(Token = "0x20000BA")]
	public class Sight : Sense
	{
		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_runInUpdate;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private FieldOfView m_fov;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private LayerMask m_targetMask;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private LayerMask m_obstacleMask;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_origin;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Collider[] m_excludedColliders;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool m_excludeSelf;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_targetsCachedTime;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SightRayCollection m_unblockedRays;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GameObject m_sightObj;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ColliderCollection m_visibleTargets;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ColliderCollection m_allTargetsInSightRange;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Collider m_currentTargetCollider;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Collider[] m_currentMatchingLayerColliders;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Component[] m_currentMatchingTypes;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Component[] m_currentMatchingComponents;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ColliderCollection m_currentColliders;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] m_currentBoundPositions;

		[Token(Token = "0x17000095")]
		public Transform Origin
		{
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x1265010", Offset = "0x1265010", VA = "0x1265010")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		public FieldOfView FOV
		{
			[Token(Token = "0x600067F")]
			[Address(RVA = "0x12650A0", Offset = "0x12650A0", VA = "0x12650A0")]
			get
			{
				return default(FieldOfView);
			}
		}

		[Token(Token = "0x17000097")]
		public ColliderCollection VisibleTargets
		{
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x12650A8", Offset = "0x12650A8", VA = "0x12650A8")]
			get
			{
				return default(ColliderCollection);
			}
		}

		[Token(Token = "0x17000098")]
		public ColliderCollection AllTargetsInSightRange
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0x12650B4", Offset = "0x12650B4", VA = "0x12650B4")]
			get
			{
				return default(ColliderCollection);
			}
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x12650C0", Offset = "0x12650C0", VA = "0x12650C0")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x1265314", Offset = "0x1265314", VA = "0x1265314")]
		private void SetSightOrigin(Transform originTransform)
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x126531C", Offset = "0x126531C", VA = "0x126531C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x12655D0", Offset = "0x12655D0", VA = "0x12655D0")]
		private ColliderCollection GetTargetsInFieldOfVision()
		{
			return default(ColliderCollection);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x126598C", Offset = "0x126598C", VA = "0x126598C")]
		public bool IsInLineOfSight(Collider target)
		{
			return default(bool);
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x12659D8", Offset = "0x12659D8", VA = "0x12659D8")]
		public bool IsInLineOfSight(Collider target, out SightRay unblockedRay)
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1266334", Offset = "0x1266334", VA = "0x1266334")]
		public bool IsRayBlocked(Vector3 rayStart, Vector3 rayEnd, [Optional] Collider testedCollider)
		{
			return default(bool);
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1266208", Offset = "0x1266208", VA = "0x1266208")]
		public bool IsRayBlocked(ref SightRay sightRay, [Optional] Collider testedCollider)
		{
			return default(bool);
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x12664D0", Offset = "0x12664D0", VA = "0x12664D0")]
		private void UpdateVisibleTargets()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x126669C", Offset = "0x126669C", VA = "0x126669C")]
		public bool IsVisible(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x12666C8", Offset = "0x12666C8", VA = "0x12666C8")]
		public bool IsInSightRange(Collider collider)
		{
			return default(bool);
		}

		[Token(Token = "0x600068D")]
		public T GetClosest<T>(T[] components, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x12666F4", Offset = "0x12666F4", VA = "0x12666F4")]
		public int MatchTargets(Collider[] matchingTargets, bool InFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x600068F")]
		public int MatchTargets<T>(T[] matchingTargets, bool InFieldOfView = true, int length = -1, float customRange = 0f) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x12666F8", Offset = "0x12666F8", VA = "0x12666F8")]
		public int FindTargets(Collider[] matchingColliders, LayerMask layerMask, bool InFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return default(int);
		}

		[Token(Token = "0x6000691")]
		public int FindTargets<T>(T[] matchingComponents, LayerMask layerMask, bool InFieldOfView = true, int length = -1, float customRange = 0f) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1266788", Offset = "0x1266788", VA = "0x1266788")]
		public Collider GetClosestTarget(bool InFieldOfView = true, float customRange = 0f, int length = -1)
		{
			return null;
		}

		[Token(Token = "0x6000693")]
		public T GetClosestTarget<T>(bool InFieldOfView = true, float customRange = 0f, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x12627C8", Offset = "0x12627C8", VA = "0x12627C8")]
		public Collider GetClosestTarget(LayerMask layerMask, bool InFieldOfView = true, float customRange = 0f, int length = -1)
		{
			return null;
		}

		[Token(Token = "0x6000695")]
		public T GetClosestTarget<T>(LayerMask layerMask, bool InFieldOfView = true, float customRange = 0f, int length = -1) where T : Component
		{
			return null;
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1266800", Offset = "0x1266800", VA = "0x1266800")]
		public Component GetClosestTarget(Type type, bool inFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1266B20", Offset = "0x1266B20", VA = "0x1266B20")]
		public Component GetClosestTarget(Type type, LayerMask layerMask, bool inFieldOfView = true, int length = -1, float customRange = 0f)
		{
			return null;
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1266C30", Offset = "0x1266C30", VA = "0x1266C30")]
		private int FindTargetsInLayers(Collider[] matchingColliders, Collider[] colliders, LayerMask layerMask, int length = -1)
		{
			return default(int);
		}

		[Token(Token = "0x6000699")]
		private int FindTargetsInLayers<T>(T[] matchingComponents, Collider[] colliders, LayerMask layerMask, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600069A")]
		private int FindTargetsInLayers<T>(T[] matchingComponents, T[] collection, LayerMask layerMask, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600069B")]
		private int FindTargetsInRange<T>(T[] targetsInRange, T[] collection, float range, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600069C")]
		private T GetTargetInRange<T>(T target, float range) where T : Component
		{
			return null;
		}

		[Token(Token = "0x600069D")]
		private int FindTargetsOfType<T>(Component[] matchingComponents, Collider[] colliders, int length = -1) where T : Component
		{
			return default(int);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x12668F0", Offset = "0x12668F0", VA = "0x12668F0")]
		private int FindTargetsOfType(Component[] matchingComponents, Collider[] colliders, Type type, int length = -1)
		{
			return default(int);
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1266DD8", Offset = "0x1266DD8", VA = "0x1266DD8")]
		public SightRay GetUnblockedSightRayForCollider(Collider collider)
		{
			return default(SightRay);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x126523C", Offset = "0x126523C", VA = "0x126523C")]
		private bool ArrayContains(Collider[] collection, Collider element)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A1")]
		private bool IsEmpty<T>(List<T> collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		private bool IsEmpty<T>(T[] collection)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1262DB4", Offset = "0x1262DB4", VA = "0x1262DB4")]
		public void TryUpdateOutdatedVisualTargets()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1266F8C", Offset = "0x1266F8C", VA = "0x1266F8C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1266F88", Offset = "0x1266F88", VA = "0x1266F88")]
		public void UpdateSight()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1266F9C", Offset = "0x1266F9C", VA = "0x1266F9C")]
		public Sight()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public struct SightRay
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly SightRay Invalid;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static readonly Color HitColor;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static readonly Color MissColor;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921EA0", Offset = "0x921EA0")]
		private readonly Vector3 <Origin>k__BackingField;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921EB0", Offset = "0x921EB0")]
		private Vector3 <Direction>k__BackingField;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921EC0", Offset = "0x921EC0")]
		private readonly Vector3 <End>k__BackingField;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921ED0", Offset = "0x921ED0")]
		private readonly float <Range>k__BackingField;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921EE0", Offset = "0x921EE0")]
		private bool <IsBlocked>k__BackingField;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921EF0", Offset = "0x921EF0")]
		private Color <Color>k__BackingField;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921F00", Offset = "0x921F00")]
		private Collider <HitCollider>k__BackingField;

		[Token(Token = "0x17000099")]
		public Vector3 Origin
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x9E01A4", Offset = "0x9E01A4", VA = "0x9E01A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924474", Offset = "0x924474")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700009A")]
		public Vector3 Direction
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x9E01B0", Offset = "0x9E01B0", VA = "0x9E01B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924484", Offset = "0x924484")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x9E01BC", Offset = "0x9E01BC", VA = "0x9E01BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924494", Offset = "0x924494")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009B")]
		public Vector3 End
		{
			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x9E01C8", Offset = "0x9E01C8", VA = "0x9E01C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244A4", Offset = "0x9244A4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700009C")]
		public float Range
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x9E01D4", Offset = "0x9E01D4", VA = "0x9E01D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244B4", Offset = "0x9244B4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700009D")]
		public bool IsBlocked
		{
			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x9E01DC", Offset = "0x9E01DC", VA = "0x9E01DC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244C4", Offset = "0x9244C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x9E01E4", Offset = "0x9E01E4", VA = "0x9E01E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244D4", Offset = "0x9244D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public Color Color
		{
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x9E01F0", Offset = "0x9E01F0", VA = "0x9E01F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244E4", Offset = "0x9244E4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x9E01FC", Offset = "0x9E01FC", VA = "0x9E01FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9244F4", Offset = "0x9244F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700009F")]
		public Collider HitCollider
		{
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x9E0208", Offset = "0x9E0208", VA = "0x9E0208")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924504", Offset = "0x924504")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x9E0210", Offset = "0x9E0210", VA = "0x9E0210")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924514", Offset = "0x924514")]
			private set
			{
			}
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x9E0218", Offset = "0x9E0218", VA = "0x9E0218")]
		public SightRay(Vector3 origin, Vector3 end, [Optional] Collider hitCollider, bool isBlocked = true)
		{
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x9E0224", Offset = "0x9E0224", VA = "0x9E0224")]
		public void SetBlocked(bool isBlocked)
		{
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x9E0230", Offset = "0x9E0230", VA = "0x9E0230")]
		public void SetHitCollider(Collider collider)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x9E0238", Offset = "0x9E0238", VA = "0x9E0238")]
		public bool IsInvalid()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x9E0240", Offset = "0x9E0240", VA = "0x9E0240")]
		public bool EqualTo(SightRay ray)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x9E0280", Offset = "0x9E0280", VA = "0x9E0280")]
		public bool AlmostEquals(Vector3 target, Vector3 second, float sqrMagnitudePrecision)
		{
			return default(bool);
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Sight.Collections
{
	[Token(Token = "0x20000BC")]
	public struct ColliderCollection
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Collider[] Colliders;

		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x9E0084", Offset = "0x9E0084", VA = "0x9E0084")]
		public ColliderCollection(int size)
		{
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x9E008C", Offset = "0x9E008C", VA = "0x9E008C")]
		public bool Contains(Collider element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BD")]
	public struct ComponentCollection<T> where T : Component
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] Components;

		[Token(Token = "0x60006BB")]
		public ComponentCollection(int size)
		{
		}

		[Token(Token = "0x60006BC")]
		public bool Contains(T element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BE")]
	public struct SightRayCollection
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public SightRay[] SightRays;

		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x9E00E0", Offset = "0x9E00E0", VA = "0x9E00E0")]
		public SightRayCollection(int size)
		{
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x9E00E8", Offset = "0x9E00E8", VA = "0x9E00E8")]
		public bool Contains(SightRay element)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000BF")]
	public struct VectorCollection
	{
		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Count;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector3[] Vectors;

		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x9E0128", Offset = "0x9E0128", VA = "0x9E0128")]
		public VectorCollection(int size)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Hearing
{
	[Token(Token = "0x20000C0")]
	public struct AudibleSource
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 Position;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float Amplitude;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float RegisteredTime;

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x9DFFE4", Offset = "0x9DFFE4", VA = "0x9DFFE4")]
		public AudibleSource(Vector3 position, float amplitude, float registeredTime)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000C1")]
	public class AudioEvent : UnityEvent<Vector3, float>
	{
		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static AudioEvent Event;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x12641EC", Offset = "0x12641EC", VA = "0x12641EC")]
		public AudioEvent()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public class Hearing : Sense
	{
		[Token(Token = "0x4000309")]
		private const float MinDistanceVolumeCap = 0.1f;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_runInUpdate;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x921F20", Offset = "0x921F20")]
		private float m_sensitivity;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float m_minRange;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float m_maxRange;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int m_sourceRegistryCapacity;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform m_origin;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_noticeDuration;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudibleSourceCollection m_registeredAudioSources;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudibleSourceCollection HeardAudioPositions;

		[Token(Token = "0x170000A0")]
		public float MinRange
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x12644A8", Offset = "0x12644A8", VA = "0x12644A8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000A1")]
		public float MaxRange
		{
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x12644B0", Offset = "0x12644B0", VA = "0x12644B0")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x12644B8", Offset = "0x12644B8", VA = "0x12644B8")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x12645BC", Offset = "0x12645BC", VA = "0x12645BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1264638", Offset = "0x1264638", VA = "0x1264638")]
		private void OnAudioEvent(Vector3 position, float amplitude)
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1264788", Offset = "0x1264788", VA = "0x1264788")]
		private float GetVolumeFactorAtDistance(Vector3 position)
		{
			return default(float);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x12648C4", Offset = "0x12648C4", VA = "0x12648C4")]
		public bool IsWithinHearingRange(Vector3 position)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x126240C", Offset = "0x126240C", VA = "0x126240C")]
		public bool IsWithinHearingRange(Vector3 position, float range)
		{
			return default(bool);
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x12649CC", Offset = "0x12649CC", VA = "0x12649CC")]
		private void UpdateHearing()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1264AD4", Offset = "0x1264AD4", VA = "0x1264AD4")]
		private void Update()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1264AE4", Offset = "0x1264AE4", VA = "0x1264AE4")]
		public Hearing()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public interface IHearing
	{
		[Token(Token = "0x60006CE")]
		Hearing GetHearing();

		[Token(Token = "0x60006CF")]
		Vector3 GetOpponentPosition();
	}
}
namespace Cortopia.BE.Runtime.Components.Senses.Hearing.Collections
{
	[Token(Token = "0x20000C4")]
	public struct AudibleSourceCollection
	{
		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int m_nextIndex;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int Count;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AudibleSource[] Sources;

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x9DFFF4", Offset = "0x9DFFF4", VA = "0x9DFFF4")]
		public AudibleSourceCollection(int size)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x9DFFFC", Offset = "0x9DFFFC", VA = "0x9DFFFC")]
		public void Add(Vector3 position, float amplitude)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x9E0004", Offset = "0x9E0004", VA = "0x9E0004")]
		public void Add(AudibleSource source)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions
{
	[Serializable]
	[Token(Token = "0x20000C5")]
	public class BE_Action : ScriptableObject
	{
		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x921FA0", Offset = "0x921FA0")]
		public List<TransitionConnector> TransitionConnectors;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Node OwnerNode;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string TypeName;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x921FD8", Offset = "0x921FD8")]
		private string <Description>k__BackingField;

		[Token(Token = "0x170000A2")]
		public string Description
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0x125EDE0", Offset = "0x125EDE0", VA = "0x125EDE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924524", Offset = "0x924524")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x125EDE8", Offset = "0x125EDE8", VA = "0x125EDE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x924534", Offset = "0x924534")]
			protected set
			{
			}
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x125EDF0", Offset = "0x125EDF0", VA = "0x125EDF0", Slot = "4")]
		public virtual void Initialize()
		{
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x125EDF4", Offset = "0x125EDF4", VA = "0x125EDF4")]
		public void AddTransitionConnector(TransitionConnector connector)
		{
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x125EF60", Offset = "0x125EF60", VA = "0x125EF60")]
		public int GetTransitionIndexByName(string transitionName)
		{
			return default(int);
		}

		[Token(Token = "0x60006D8")]
		public T GetValidComponent<T>(Component owner)
		{
			return (T)null;
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x125F0A8", Offset = "0x125F0A8", VA = "0x125F0A8", Slot = "5")]
		public virtual void Process()
		{
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x125F0AC", Offset = "0x125F0AC", VA = "0x125F0AC", Slot = "6")]
		public virtual void DrawCustomProperties()
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x125F0B0", Offset = "0x125F0B0", VA = "0x125F0B0")]
		public void Finish()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x125F2C4", Offset = "0x125F2C4", VA = "0x125F2C4")]
		public BE_Action()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public enum RelationalOperator
	{
		[Token(Token = "0x400031B")]
		Equal,
		[Token(Token = "0x400031C")]
		Not,
		[Token(Token = "0x400031D")]
		Greater,
		[Token(Token = "0x400031E")]
		Less,
		[Token(Token = "0x400031F")]
		GreaterOrEqual,
		[Token(Token = "0x4000320")]
		LessOrEqual
	}
}
namespace Cortopia.BE.Runtime.Actions.SightSense
{
	[Token(Token = "0x20000C7")]
	public class InLineOfSight : BE_Action
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsInsideFOV;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Distance;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseLayerMask;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1262AF0", Offset = "0x1262AF0", VA = "0x1262AF0", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1262BB8", Offset = "0x1262BB8", VA = "0x1262BB8", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1262E10", Offset = "0x1262E10", VA = "0x1262E10")]
		public InLineOfSight()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class InProximityRange : BE_Action
	{
		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UseLayerMask;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1262E14", Offset = "0x1262E14", VA = "0x1262E14", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1262EDC", Offset = "0x1262EDC", VA = "0x1262EDC", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x12630AC", Offset = "0x12630AC", VA = "0x12630AC")]
		public InProximityRange()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Senses
{
	[Token(Token = "0x20000C9")]
	public class InHearingRange : BE_Action
	{
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private Hearing m_hearing;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IHearing m_interface;

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1262144", Offset = "0x1262144", VA = "0x1262144", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x126220C", Offset = "0x126220C", VA = "0x126220C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x126251C", Offset = "0x126251C", VA = "0x126251C")]
		public InHearingRange()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class InLineOfSight : BE_Action
	{
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsInsideFOV;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float Distance;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool UseLayerMask;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1262520", Offset = "0x1262520", VA = "0x1262520", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x12625E8", Offset = "0x12625E8", VA = "0x12625E8", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1262850", Offset = "0x1262850", VA = "0x1262850")]
		public InLineOfSight()
		{
		}
	}
	[Token(Token = "0x20000CB")]
	public class InProximityRange : BE_Action
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Range;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool UseLayerMask;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LayerMask LayerMaskFilter;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Component m_componentFilter;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		private Sight m_sight;

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1262854", Offset = "0x1262854", VA = "0x1262854", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x126291C", Offset = "0x126291C", VA = "0x126291C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1262AEC", Offset = "0x1262AEC", VA = "0x1262AEC")]
		public InProximityRange()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Script
{
	[Token(Token = "0x20000CC")]
	public class CallScriptMethod : BE_Action
	{
		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x9216C8", Offset = "0x9216C8")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MethodInfo method;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CallScriptMethod <>4__this;

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x12620D4", Offset = "0x12620D4", VA = "0x12620D4")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x12620E0", Offset = "0x12620E0", VA = "0x12620E0")]
			internal void <Process>b__0(object[] caller)
			{
			}
		}

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string MethodName;

		[Token(Token = "0x400033B")]
		private const int MaxInheritanceLevel = 3;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action<object[]> m_action;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private object[] m_object;

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1261EC4", Offset = "0x1261EC4", VA = "0x1261EC4", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x12620DC", Offset = "0x12620DC", VA = "0x12620DC")]
		public CallScriptMethod()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Randomness
{
	[Token(Token = "0x20000CD")]
	public class RandomBranch : BE_Action
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int TransitionsCount;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly System.Random m_random;

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1261CD8", Offset = "0x1261CD8", VA = "0x1261CD8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1261DA0", Offset = "0x1261DA0", VA = "0x1261DA0", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1261E0C", Offset = "0x1261E0C", VA = "0x1261E0C")]
		public RandomBranch()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Physics.Collision
{
	[Token(Token = "0x20000CE")]
	public enum ColliderEventType
	{
		[Token(Token = "0x4000341")]
		Default,
		[Token(Token = "0x4000342")]
		OnEnter,
		[Token(Token = "0x4000343")]
		OnStay,
		[Token(Token = "0x4000344")]
		OnExit
	}
	[Token(Token = "0x20000CF")]
	public class OnColliderEnter : BE_Action
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsTrigger;

		[NonSerialized]
		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_hasEntered;

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x125FD88", Offset = "0x125FD88", VA = "0x125FD88", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x125FE50", Offset = "0x125FE50", VA = "0x125FE50", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1260390", Offset = "0x1260390", VA = "0x1260390")]
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x126039C", Offset = "0x126039C", VA = "0x126039C")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x12603A8", Offset = "0x12603A8", VA = "0x12603A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x12607B0", Offset = "0x12607B0", VA = "0x12607B0")]
		public OnColliderEnter()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class OnColliderEvent : BE_Action
	{
		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x922100", Offset = "0x922100")]
		public bool IsTrigger;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0x922138", Offset = "0x922138")]
		public bool OnEnter;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		public bool OnStay;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
		public bool OnExit;

		[NonSerialized]
		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ColliderEventType m_currentState;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IDictionary<ColliderEventType, TransitionConnector> m_transitionTypes;

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x12607B4", Offset = "0x12607B4", VA = "0x12607B4", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x12608EC", Offset = "0x12608EC", VA = "0x12608EC")]
		private void AddConnector(ColliderEventType colliderEvent, TransitionConnector connector)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x12609C8", Offset = "0x12609C8", VA = "0x12609C8", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1260F94", Offset = "0x1260F94", VA = "0x1260F94")]
		private void OnCollisionEnter(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1261000", Offset = "0x1261000", VA = "0x1261000")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x126106C", Offset = "0x126106C", VA = "0x126106C")]
		private void OnCollisionStay(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x12610D8", Offset = "0x12610D8", VA = "0x12610D8")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1261144", Offset = "0x1261144", VA = "0x1261144")]
		private void OnCollisionExit(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x12611B0", Offset = "0x12611B0", VA = "0x12611B0")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x1260B6C", Offset = "0x1260B6C", VA = "0x1260B6C")]
		private void SetEventDelegates(bool shouldActivate)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x12615CC", Offset = "0x12615CC", VA = "0x12615CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x12615F4", Offset = "0x12615F4", VA = "0x12615F4")]
		public OnColliderEvent()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class OnColliderExit : BE_Action
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool IsTrigger;

		[NonSerialized]
		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider m_collider;

		[NonSerialized]
		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EventDelegate m_eventDelegate;

		[NonSerialized]
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool m_hasExited;

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x1261670", Offset = "0x1261670", VA = "0x1261670", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x1261738", Offset = "0x1261738", VA = "0x1261738", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x1261A8C", Offset = "0x1261A8C", VA = "0x1261A8C")]
		private void OnCollisionExit(UnityEngine.Collision collision)
		{
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1261A98", Offset = "0x1261A98", VA = "0x1261A98")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1261AA4", Offset = "0x1261AA4", VA = "0x1261AA4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1261CD4", Offset = "0x1261CD4", VA = "0x1261CD4")]
		public OnColliderExit()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Parameters
{
	[Serializable]
	[Token(Token = "0x20000D2")]
	public class BE_ActionParam
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public object Value;

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x125FD50", Offset = "0x125FD50", VA = "0x125FD50")]
		public BE_ActionParam(string name, object value)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Movement
{
	[Token(Token = "0x20000D3")]
	public class Rotate : BE_Action
	{
		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 EulerAngles;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float Seconds;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve Curve;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float m_duration;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 m_frameDeltaRotation;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 m_totalRotation;

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x125F9B8", Offset = "0x125F9B8", VA = "0x125F9B8", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x125FA08", Offset = "0x125FA08", VA = "0x125FA08", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x125FC38", Offset = "0x125FC38", VA = "0x125FC38")]
		public Rotate()
		{
		}
	}
	[Token(Token = "0x20000D4")]
	public class Wait : BE_Action
	{
		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float Seconds;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_duration;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_lastUpdateTime;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool m_isStarted;

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x125FC3C", Offset = "0x125FC3C", VA = "0x125FC3C", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x125FC8C", Offset = "0x125FC8C", VA = "0x125FC8C", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x125FD4C", Offset = "0x125FD4C", VA = "0x125FD4C")]
		public Wait()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Interfaces
{
	[Token(Token = "0x20000D5")]
	public interface IBehaviourSystemReferable
	{
		[Token(Token = "0x6000710")]
		void UpdateReferences();
	}
}
namespace Cortopia.BE.Runtime.Actions.Execution
{
	[Token(Token = "0x20000D6")]
	public class ChangeState : BE_Action, IBehaviourSystemReferable
	{
		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public State State;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public StateMachine StateMachine;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private StateChangeEvent m_stateChangeEvent;

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x125F458", Offset = "0x125F458", VA = "0x125F458", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x125F4A8", Offset = "0x125F4A8", VA = "0x125F4A8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x125F580", Offset = "0x125F580", VA = "0x125F580", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x125F4B0", Offset = "0x125F4B0", VA = "0x125F4B0")]
		private void SetListenerActive(bool shouldBeActive)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x125F60C", Offset = "0x125F60C", VA = "0x125F60C", Slot = "7")]
		public void UpdateReferences()
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x125F6A8", Offset = "0x125F6A8", VA = "0x125F6A8")]
		public ChangeState()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public enum ExecutionType
	{
		[Token(Token = "0x4000365")]
		FixedNumber,
		[Token(Token = "0x4000366")]
		Infinity
	}
	[Token(Token = "0x20000D8")]
	public class PerformTransition : BE_Action
	{
		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int ConnectionIndex;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x125F758", Offset = "0x125F758", VA = "0x125F758", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x125F7A8", Offset = "0x125F7A8", VA = "0x125F7A8", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x125F890", Offset = "0x125F890", VA = "0x125F890")]
		public PerformTransition()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class Repeat : BE_Action
	{
		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ExecutionType RepetitionType;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint Repetitions;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private uint m_repetitions;

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x125F894", Offset = "0x125F894", VA = "0x125F894", Slot = "4")]
		public override void Initialize()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x125F8E4", Offset = "0x125F8E4", VA = "0x125F8E4", Slot = "5")]
		public override void Process()
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x125F9AC", Offset = "0x125F9AC", VA = "0x125F9AC")]
		public Repeat()
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Connectors
{
	[Serializable]
	[Token(Token = "0x20000DA")]
	public class TransitionConnector
	{
		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public string Name;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public int TransitionIndex;

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x125F41C", Offset = "0x125F41C", VA = "0x125F41C")]
		public TransitionConnector(string name, int index)
		{
		}
	}
}
namespace Cortopia.BE.Runtime.Actions.Conditions
{
	[Token(Token = "0x20000DB")]
	public class RelationalCondition : BE_Action
	{
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x125F338", Offset = "0x125F338", VA = "0x125F338")]
		protected bool Evaluate(RelationalOperator type, int a, int b)
		{
			return default(bool);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x125F3A8", Offset = "0x125F3A8", VA = "0x125F3A8")]
		protected bool Evaluate(RelationalOperator type, float a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x125F418", Offset = "0x125F418", VA = "0x125F418")]
		public RelationalCondition()
		{
		}
	}
}
