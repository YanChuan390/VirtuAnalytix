using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DeviceTracker;
using Il2CppDummyDll;
using RootMotion.Demos;
using RootMotion.FinalIK;
using TMPro;
using Unity.XR.PXR;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class FixNonUniformScale : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool running;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xACD8F4", Offset = "0xACD8F4", VA = "0xACD8F4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xACD970", Offset = "0xACD970", VA = "0xACD970")]
	public void MakeUniform()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xACDDF8", Offset = "0xACDDF8", VA = "0xACDDF8")]
	public FixNonUniformScale()
	{
	}
}
[Token(Token = "0x2000003")]
public class DynamicBoneDemo1 : MonoBehaviour
{
	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject m_Player;

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xACDE00", Offset = "0xACDE00", VA = "0xACDE00")]
	private void Update()
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0xACDF44", Offset = "0xACDF44", VA = "0xACDF44")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0xACE264", Offset = "0xACE264", VA = "0xACE264")]
	public DynamicBoneDemo1()
	{
	}
}
[Token(Token = "0x2000004")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone")]
public class DynamicBone : MonoBehaviour
{
	[Token(Token = "0x2000005")]
	public enum UpdateMode
	{
		[Token(Token = "0x4000024")]
		Normal,
		[Token(Token = "0x4000025")]
		AnimatePhysics,
		[Token(Token = "0x4000026")]
		UnscaledTime
	}

	[Token(Token = "0x2000006")]
	public enum FreezeAxis
	{
		[Token(Token = "0x4000028")]
		None,
		[Token(Token = "0x4000029")]
		X,
		[Token(Token = "0x400002A")]
		Y,
		[Token(Token = "0x400002B")]
		Z
	}

	[Token(Token = "0x2000007")]
	private class Particle
	{
		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform m_Transform;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_ParentIndex;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float m_Damping;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float m_Elasticity;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float m_Stiffness;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float m_Inert;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float m_Radius;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_BoneLength;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 m_Position;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 m_PrevPosition;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 m_EndOffset;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 m_InitLocalPosition;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion m_InitLocalRotation;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xAD04D8", Offset = "0xAD04D8", VA = "0xAD04D8")]
		public Particle()
		{
		}
	}

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform m_Root;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_UpdateRate;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public UpdateMode m_UpdateMode;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Range(0f, 1f)]
	public float m_Damping;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AnimationCurve m_DampingDistrib;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Range(0f, 1f)]
	public float m_Elasticity;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve m_ElasticityDistrib;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Range(0f, 1f)]
	public float m_Stiffness;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AnimationCurve m_StiffnessDistrib;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Range(0f, 1f)]
	public float m_Inert;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AnimationCurve m_InertDistrib;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float m_Radius;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AnimationCurve m_RadiusDistrib;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float m_EndLength;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public Vector3 m_EndOffset;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Vector3 m_Gravity;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public Vector3 m_Force;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<DynamicBoneColliderBase> m_Colliders;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public List<Transform> m_Exclusions;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public FreezeAxis m_FreezeAxis;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public bool m_DistantDisable;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform m_ReferenceObject;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float m_DistanceToObject;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 m_LocalGravity;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Vector3 m_ObjectMove;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private Vector3 m_ObjectPrevPosition;

	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float m_BoneTotalLength;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float m_ObjectScale;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float m_Time;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float m_Weight;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool m_DistantDisabled;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<Particle> m_Particles;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0xACE26C", Offset = "0xACE26C", VA = "0xACE26C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0xACE3DC", Offset = "0xACE3DC", VA = "0xACE3DC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0xACE430", Offset = "0xACE430", VA = "0xACE430")]
	private void Update()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0xACE460", Offset = "0xACE460", VA = "0xACE460")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xACE40C", Offset = "0xACE40C", VA = "0xACE40C")]
	private void PreUpdate()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xACE4B0", Offset = "0xACE4B0", VA = "0xACE4B0")]
	private void CheckDistance()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xACEA38", Offset = "0xACEA38", VA = "0xACEA38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xACEA3C", Offset = "0xACEA3C", VA = "0xACEA3C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xACEA40", Offset = "0xACEA40", VA = "0xACEA40")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xACEAEC", Offset = "0xACEAEC", VA = "0xACEAEC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xACEC7C", Offset = "0xACEC7C", VA = "0xACEC7C")]
	public void SetWeight(float w)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xACECCC", Offset = "0xACECCC", VA = "0xACECCC")]
	public float GetWeight()
	{
		return default(float);
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xACE628", Offset = "0xACE628", VA = "0xACE628")]
	private void UpdateDynamicBones(float t)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xACE270", Offset = "0xACE270", VA = "0xACE270")]
	private void SetupParticles()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xACFC54", Offset = "0xACFC54", VA = "0xACFC54")]
	private void AppendParticles(Transform b, int parentIndex, float boneLength)
	{
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xAD021C", Offset = "0xAD021C", VA = "0xAD021C")]
	public void UpdateParameters()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0xACE7EC", Offset = "0xACE7EC", VA = "0xACE7EC")]
	private void InitTransforms()
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xACE8F0", Offset = "0xACE8F0", VA = "0xACE8F0")]
	private void ResetParticlesPosition()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xACECD4", Offset = "0xACECD4", VA = "0xACECD4")]
	private void UpdateParticles1()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xACEF38", Offset = "0xACEF38", VA = "0xACEF38")]
	private void UpdateParticles2()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xACF554", Offset = "0xACF554", VA = "0xACF554")]
	private void SkipUpdateParticles()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xAD05B4", Offset = "0xAD05B4", VA = "0xAD05B4")]
	private static Vector3 MirrorVector(Vector3 v, Vector3 axis)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xACF9F8", Offset = "0xACF9F8", VA = "0xACF9F8")]
	private void ApplyParticlesToTransforms()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xAD05E8", Offset = "0xAD05E8", VA = "0xAD05E8")]
	public DynamicBone()
	{
	}
}
[Token(Token = "0x2000008")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Collider")]
public class DynamicBoneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float m_Radius;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float m_Height;

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xAD0738", Offset = "0xAD0738", VA = "0xAD0738")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xAD0750", Offset = "0xAD0750", VA = "0xAD0750", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xAD0944", Offset = "0xAD0944", VA = "0xAD0944")]
	private static void OutsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xAD09A4", Offset = "0xAD09A4", VA = "0xAD09A4")]
	private static void InsideSphere(ref Vector3 particlePosition, float particleRadius, Vector3 sphereCenter, float sphereRadius)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xAD09FC", Offset = "0xAD09FC", VA = "0xAD09FC")]
	private static void OutsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x6000025")]
	[Address(RVA = "0xAD0B70", Offset = "0xAD0B70", VA = "0xAD0B70")]
	private static void InsideCapsule(ref Vector3 particlePosition, float particleRadius, Vector3 capsuleP0, Vector3 capsuleP1, float capsuleRadius)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0xAD0CCC", Offset = "0xAD0CCC", VA = "0xAD0CCC")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0xAD0E68", Offset = "0xAD0E68", VA = "0xAD0E68")]
	public DynamicBoneCollider()
	{
	}
}
[Token(Token = "0x2000009")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	[Token(Token = "0x200000A")]
	public enum Direction
	{
		[Token(Token = "0x400003F")]
		X,
		[Token(Token = "0x4000040")]
		Y,
		[Token(Token = "0x4000041")]
		Z
	}

	[Token(Token = "0x200000B")]
	public enum Bound
	{
		[Token(Token = "0x4000043")]
		Outside,
		[Token(Token = "0x4000044")]
		Inside
	}

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Direction m_Direction;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Vector3 m_Center;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Bound m_Bound;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0xAD0ED8", Offset = "0xAD0ED8", VA = "0xAD0ED8", Slot = "4")]
	public virtual void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0xAD0E74", Offset = "0xAD0E74", VA = "0xAD0E74")]
	public DynamicBoneColliderBase()
	{
	}
}
[Token(Token = "0x200000C")]
[AddComponentMenu("Dynamic Bone/Dynamic Bone Plane Collider")]
public class DynamicBonePlaneCollider : DynamicBoneColliderBase
{
	[Token(Token = "0x600002A")]
	[Address(RVA = "0xAD0EDC", Offset = "0xAD0EDC", VA = "0xAD0EDC")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0xAD0EE0", Offset = "0xAD0EE0", VA = "0xAD0EE0", Slot = "4")]
	public override void Collide(ref Vector3 particlePosition, float particleRadius)
	{
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0xAD1068", Offset = "0xAD1068", VA = "0xAD1068")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0xAD11C8", Offset = "0xAD11C8", VA = "0xAD11C8")]
	public DynamicBonePlaneCollider()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
public class MirrorReflection2 : MonoBehaviour
{
	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Hashtable m_ReflectionCameras;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;

	[Token(Token = "0x600002E")]
	[Address(RVA = "0xAD11CC", Offset = "0xAD11CC", VA = "0xAD11CC")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0xAD20E8", Offset = "0xAD20E8", VA = "0xAD20E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0xAD1BD4", Offset = "0xAD1BD4", VA = "0xAD1BD4")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0xAD16F0", Offset = "0xAD16F0", VA = "0xAD16F0")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xAD2188", Offset = "0xAD2188", VA = "0xAD2188")]
	private static float sgn(float a)
	{
		return default(float);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xAD1F38", Offset = "0xAD1F38", VA = "0xAD1F38")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default(Vector4);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xAD1EA4", Offset = "0xAD1EA4", VA = "0xAD1EA4")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0xAD21A8", Offset = "0xAD21A8", VA = "0xAD21A8")]
	public MirrorReflection2()
	{
	}
}
[Token(Token = "0x200000E")]
public class AvatarDemo : MonoBehaviour
{
	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRIKCalibrationController controller;

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xAD2238", Offset = "0xAD2238", VA = "0xAD2238")]
	private void Start()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xAD2288", Offset = "0xAD2288", VA = "0xAD2288")]
	private void Update()
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xAD2354", Offset = "0xAD2354", VA = "0xAD2354")]
	public void CalibrationIK()
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xAD238C", Offset = "0xAD238C", VA = "0xAD238C")]
	public AvatarDemo()
	{
	}
}
[Token(Token = "0x200000F")]
public class BodyTrackerTest : MonoBehaviour
{
	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform headAnchor;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform rightFootAnchor;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform leftFootAnchor;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform leftHandAnchor;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform rightHandAnchor;

	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform modelScale;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform roleCenter;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform MirrorPanel;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform cameraCenter;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector3 MirrorCenterOffset;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public Vector3 HeadCenterOffset;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public VRIKCalibrationController controller;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private double displayTime;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private IDeviceInputReader inputReader;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool OpenLogWriter;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int LOG_SAMPLE_FRAME;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int m_runLogTime;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public string nativeFileName;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool CloseLogPrint;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private float poseFloorOffset;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float poseHeadOffset;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool hasInitOffset;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public float ConfigUnityGroundHeight;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float ConfigUnityFBXHeight;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float ConfigIKHeadOffset;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float curMinFrameAnklePosY;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private float limitHeadHeight;

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xAD2394", Offset = "0xAD2394", VA = "0xAD2394")]
	private void Start()
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xAD2564", Offset = "0xAD2564", VA = "0xAD2564")]
	private float SyncAnkleIKPositionY(float trackingY)
	{
		return default(float);
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xAD2588", Offset = "0xAD2588", VA = "0xAD2588")]
	private float SyncHeadIKPositionY(float trackingY)
	{
		return default(float);
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xAD25B8", Offset = "0xAD25B8", VA = "0xAD25B8")]
	private void calcInitFloorOffset(float trackingY, float headY)
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0xAD25F0", Offset = "0xAD25F0", VA = "0xAD25F0")]
	private void CalcOffsetData(bool active)
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0xAD2778", Offset = "0xAD2778", VA = "0xAD2778")]
	private void ResetOffset()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0xAD2784", Offset = "0xAD2784", VA = "0xAD2784")]
	private void RefreshDeviceData()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0xAD27A4", Offset = "0xAD27A4", VA = "0xAD27A4")]
	private void RefreshAnkle()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0xAD2BF8", Offset = "0xAD2BF8", VA = "0xAD2BF8")]
	private void RefreshHead()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xAD3300", Offset = "0xAD3300", VA = "0xAD3300")]
	private void RefreshCtrl()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xAD3C74", Offset = "0xAD3C74", VA = "0xAD3C74")]
	private void RefreshMirror()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xAD3D64", Offset = "0xAD3D64", VA = "0xAD3D64")]
	private void Update()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0xAD3088", Offset = "0xAD3088", VA = "0xAD3088")]
	private void SwitfLog(string content)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0xAD2B40", Offset = "0xAD2B40", VA = "0xAD2B40")]
	private void InputLogWrite(DeviceInputWriter.LogNameType name, Vector3 pos, Quaternion quaternion)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0xAD24B4", Offset = "0xAD24B4", VA = "0xAD24B4")]
	private void StartLog(bool openLog)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0xAD3E0C", Offset = "0xAD3E0C", VA = "0xAD3E0C")]
	private void UpdateLogState()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0xAD4108", Offset = "0xAD4108", VA = "0xAD4108")]
	[ContextMenu("RunLocalFileReader")]
	public void LoadNativeFile()
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0xAD4498", Offset = "0xAD4498", VA = "0xAD4498")]
	[ContextMenu("Play")]
	public void PlayNativeFile()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0xAD4568", Offset = "0xAD4568", VA = "0xAD4568")]
	[ContextMenu("PlayFrame1")]
	public void PlayFrame1()
	{
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0xAD463C", Offset = "0xAD463C", VA = "0xAD463C")]
	public BodyTrackerTest()
	{
	}
}
[Token(Token = "0x2000010")]
public class DeviceInputWriter
{
	[Token(Token = "0x2000011")]
	public enum LogNameType
	{
		[Token(Token = "0x400006D")]
		NONE,
		[Token(Token = "0x400006E")]
		LeftFoot,
		[Token(Token = "0x400006F")]
		RightFoot,
		[Token(Token = "0x4000070")]
		LeftHand,
		[Token(Token = "0x4000071")]
		RightHand,
		[Token(Token = "0x4000072")]
		Head
	}

	[Token(Token = "0x2000012")]
	public class UnityTransformInfo
	{
		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 pos;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion quaternion;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int nameType;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int frame;

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xAD47EC", Offset = "0xAD47EC", VA = "0xAD47EC")]
		public string GenToString()
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xAD4AA0", Offset = "0xAD4AA0", VA = "0xAD4AA0")]
		public void CreateByString(string line1, string line2, string line3)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xAD4754", Offset = "0xAD4754", VA = "0xAD4754")]
		public void CreateByData(int name, int frame, Vector3 pos, Quaternion quaternion)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xAD474C", Offset = "0xAD474C", VA = "0xAD474C")]
		public UnityTransformInfo()
		{
		}
	}

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DeviceInputWriter _instance;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<UnityTransformInfo> m_waitSaveItemList;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StringBuilder m_writeBuilder;

	[Token(Token = "0x17000001")]
	public static DeviceInputWriter Instance
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0xAD3140", Offset = "0xAD3140", VA = "0xAD3140")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0xAD31BC", Offset = "0xAD31BC", VA = "0xAD31BC")]
	public void CollectInput(LogNameType name, int frame, Vector3 pos, Quaternion quaternion)
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0xAD3F04", Offset = "0xAD3F04", VA = "0xAD3F04")]
	public void SaveToFile(string fileName)
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0xAD3E90", Offset = "0xAD3E90", VA = "0xAD3E90")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0xAD476C", Offset = "0xAD476C", VA = "0xAD476C")]
	private string GetTimeStamp()
	{
		return null;
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0xAD46A0", Offset = "0xAD46A0", VA = "0xAD46A0")]
	public DeviceInputWriter()
	{
	}
}
[Token(Token = "0x2000013")]
public class DeviceInputReaderBuilder
{
	[Token(Token = "0x2000014")]
	public enum InputReaderType
	{
		[Token(Token = "0x4000078")]
		Editor,
		[Token(Token = "0x4000079")]
		XR,
		[Token(Token = "0x400007A")]
		Swift,
		[Token(Token = "0x400007B")]
		NativeFile
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xAD23BC", Offset = "0xAD23BC", VA = "0xAD23BC")]
	public static IDeviceInputReader CreateReader(InputReaderType readerType = InputReaderType.XR, bool forceApply = false)
	{
		return null;
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xAD4CD8", Offset = "0xAD4CD8", VA = "0xAD4CD8")]
	public DeviceInputReaderBuilder()
	{
	}
}
[Token(Token = "0x2000015")]
public class EditorUnityInputReader : IDeviceInputReader
{
	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
	private Transform headTrans;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
	private Transform leftHandTrans;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
	private Transform rightHandTrans;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
	private Transform leftFootTrans;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
	private Transform rightFootTrans;

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xAD4CE0", Offset = "0xAD4CE0", VA = "0xAD4CE0", Slot = "4")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xAD4F04", Offset = "0xAD4F04", VA = "0xAD4F04")]
	private void SetTrackingData(BodyTrackerBones type, Vector3 pos, Quaternion quaternion)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xAD4FD0", Offset = "0xAD4FD0", VA = "0xAD4FD0", Slot = "5")]
	public override void OnUpdateDevicePose()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xAD4C3C", Offset = "0xAD4C3C", VA = "0xAD4C3C")]
	public EditorUnityInputReader()
	{
	}
}
[Token(Token = "0x2000016")]
public class FileInputReader : IDeviceInputReader
{
	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
	private Dictionary<int, List<DeviceInputWriter.UnityTransformInfo>> m_frame_items;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
	private List<DeviceInputWriter.UnityTransformInfo> m_curFrameData;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
	private int m_applyFrame;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x534")]
	private int maxFrame;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
	private Transform headTrans;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
	private Transform leftHandTrans;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
	private Transform rightHandTrans;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
	private Transform leftFootTrans;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
	private Transform rightFootTrans;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
	private Unity.XR.PXR.BodyTrackerResult pxrResult;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
	private bool sampleFrame;

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xAD52B0", Offset = "0xAD52B0", VA = "0xAD52B0", Slot = "4")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xAD5580", Offset = "0xAD5580", VA = "0xAD5580", Slot = "5")]
	public override void OnUpdateDevicePose()
	{
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0xAD5CB4", Offset = "0xAD5CB4", VA = "0xAD5CB4")]
	private void SetTrackingData(BodyTrackerBones type, Vector3 pos, Quaternion quaternion)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xAD4190", Offset = "0xAD4190", VA = "0xAD4190")]
	public void InitDataByFile(string fileName)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xAD454C", Offset = "0xAD454C", VA = "0xAD454C")]
	public void StartPlay()
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xAD461C", Offset = "0xAD461C", VA = "0xAD461C")]
	public void SampleFrame(int frame)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xAD5C44", Offset = "0xAD5C44", VA = "0xAD5C44")]
	private List<DeviceInputWriter.UnityTransformInfo> GetCurFrameData(int frame)
	{
		return null;
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xAD5964", Offset = "0xAD5964", VA = "0xAD5964")]
	private void ChangeEditorInput()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xAD4C54", Offset = "0xAD4C54", VA = "0xAD4C54")]
	public FileInputReader()
	{
	}
}
[Token(Token = "0x2000017")]
public class PXRDeviceInputReader : IDeviceInputReader
{
	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
	private double displayTime;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
	private Unity.XR.PXR.BodyTrackerResult pxrResult;

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xAD5D80", Offset = "0xAD5D80", VA = "0xAD5D80", Slot = "4")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xAD5E6C", Offset = "0xAD5E6C", VA = "0xAD5E6C")]
	private void ClonePXRBodyTrackingDataToResult(Unity.XR.PXR.BodyTrackerTransform from, DeviceTracker.BodyTrackerTransform to)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xAD5F18", Offset = "0xAD5F18", VA = "0xAD5F18", Slot = "5")]
	public override void OnUpdateDevicePose()
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xAD4C44", Offset = "0xAD4C44", VA = "0xAD4C44")]
	public PXRDeviceInputReader()
	{
	}
}
[Token(Token = "0x2000018")]
public class SwiftDeviceInputReader : IDeviceInputReader
{
	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
	private GameObject mirrorGo;

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xAD6054", Offset = "0xAD6054", VA = "0xAD6054", Slot = "4")]
	public override void OnInitialize()
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xAD61F4", Offset = "0xAD61F4", VA = "0xAD61F4", Slot = "5")]
	public override void OnUpdateDevicePose()
	{
	}

	[PreserveSig]
	[Token(Token = "0x600006D")]
	[Address(RVA = "0xAD6BAC", Offset = "0xAD6BAC", VA = "0xAD6BAC")]
	public static extern int PT_GetBodyTrackingData(ref DeviceTracker.BodyTrackerResult bodyTrackerResult);

	[PreserveSig]
	[Token(Token = "0x600006E")]
	[Address(RVA = "0xAD6178", Offset = "0xAD6178", VA = "0xAD6178")]
	public static extern int PT_SetBodyTrackingMode(int mode);

	[PreserveSig]
	[Token(Token = "0x600006F")]
	[Address(RVA = "0xAD6CD8", Offset = "0xAD6CD8", VA = "0xAD6CD8")]
	public static extern int PT_GetHeadTrackingData(ref SixDof sixDof);

	[PreserveSig]
	[Token(Token = "0x6000070")]
	[Address(RVA = "0xAD6DD8", Offset = "0xAD6DD8", VA = "0xAD6DD8")]
	public static extern int PT_GetControllerData(ref AlgoResult gLeft, ref AlgoResult gRight, ref AlgoResult left, ref AlgoResult right);

	[PreserveSig]
	[Token(Token = "0x6000071")]
	[Address(RVA = "0xAD6C74", Offset = "0xAD6C74", VA = "0xAD6C74")]
	public static extern double getFloorHeightProp();

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xAD4C4C", Offset = "0xAD4C4C", VA = "0xAD4C4C")]
	public SwiftDeviceInputReader()
	{
	}
}
[Token(Token = "0x2000019")]
public class PoseDemo : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRIK ik;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI text;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform lefteye;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform righteye;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xAD6FEC", Offset = "0xAD6FEC", VA = "0xAD6FEC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xAD7AD8", Offset = "0xAD7AD8", VA = "0xAD7AD8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xAD7ADC", Offset = "0xAD7ADC", VA = "0xAD7ADC")]
	public PoseDemo()
	{
	}
}
[Token(Token = "0x200001A")]
public class ProcessController : MonoBehaviour
{
	[Token(Token = "0x200001B")]
	private enum ViewDirection
	{
		[Token(Token = "0x40000A5")]
		Back,
		[Token(Token = "0x40000A6")]
		Right,
		[Token(Token = "0x40000A7")]
		Right_Forward,
		[Token(Token = "0x40000A8")]
		Forward,
		[Token(Token = "0x40000A9")]
		Left_Forward,
		[Token(Token = "0x40000AA")]
		Left
	}

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static ProcessController Instance;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject RenderCameraObj;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject mModelObj;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float mViewRadius;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float mCameraHeight;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<Vector3> mViewPositionList;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int mViewIndex;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool mPrimaryButtonDown;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
	private bool mSecondaryButtonDown;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
	private bool mGripButtonDown;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3F")]
	private bool mLoadModel;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int mLayer_Player_Mirror;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int mLayer_Player_Default;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 mDiffPosition;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject[] mModelsArray;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Dictionary<int, GameObject> mModelDic;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int mModelIndex;

	[Token(Token = "0x17000002")]
	public Vector3 DiffPosition
	{
		[Token(Token = "0x6000076")]
		[Address(RVA = "0xAD7AE4", Offset = "0xAD7AE4", VA = "0xAD7AE4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000077")]
		[Address(RVA = "0xAD7AF0", Offset = "0xAD7AF0", VA = "0xAD7AF0")]
		set
		{
		}
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xAD7AFC", Offset = "0xAD7AFC", VA = "0xAD7AFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xAD7BEC", Offset = "0xAD7BEC", VA = "0xAD7BEC")]
	private void Start()
	{
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xAD7C54", Offset = "0xAD7C54", VA = "0xAD7C54")]
	private void Update()
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xAD7C58", Offset = "0xAD7C58", VA = "0xAD7C58")]
	private void OnApplicationPause(bool pause)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xAD7CFC", Offset = "0xAD7CFC", VA = "0xAD7CFC")]
	private void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xAD831C", Offset = "0xAD831C", VA = "0xAD831C")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xAD7B70", Offset = "0xAD7B70", VA = "0xAD7B70")]
	public string GetLogPath()
	{
		return null;
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xAD7DC0", Offset = "0xAD7DC0", VA = "0xAD7DC0")]
	private void Init()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xAD8384", Offset = "0xAD8384", VA = "0xAD8384")]
	private Vector3 GetViewPosition(ViewDirection dir, float radius)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0xAD869C", Offset = "0xAD869C", VA = "0xAD869C")]
	private void SetModelLayer(GameObject modelObj, int layer)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0xAD8444", Offset = "0xAD8444", VA = "0xAD8444")]
	private GameObject LoadModel(int modelIndex)
	{
		return null;
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0xAD87C0", Offset = "0xAD87C0", VA = "0xAD87C0")]
	public ProcessController()
	{
	}
}
[Token(Token = "0x200001C")]
public class SimpleSample : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	public enum BodyTrackerBones
	{
		[Token(Token = "0x40000B6")]
		Pelvis = 0,
		[Token(Token = "0x40000B7")]
		LEFT_HIP = 1,
		[Token(Token = "0x40000B8")]
		RIGHT_HIP = 2,
		[Token(Token = "0x40000B9")]
		SPINE1 = 3,
		[Token(Token = "0x40000BA")]
		LEFT_KNEE = 4,
		[Token(Token = "0x40000BB")]
		RIGHT_KNEE = 5,
		[Token(Token = "0x40000BC")]
		SPINE2 = 6,
		[Token(Token = "0x40000BD")]
		LEFT_ANKLE = 7,
		[Token(Token = "0x40000BE")]
		RIGHT_ANKLE = 8,
		[Token(Token = "0x40000BF")]
		SPINE3 = 9,
		[Token(Token = "0x40000C0")]
		LEFT_FOOT = 10,
		[Token(Token = "0x40000C1")]
		RIGHT_FOOT = 11,
		[Token(Token = "0x40000C2")]
		NECK = 12,
		[Token(Token = "0x40000C3")]
		LEFT_COLLAR = 13,
		[Token(Token = "0x40000C4")]
		RIGHT_COLLAR = 14,
		[Token(Token = "0x40000C5")]
		HEAD = 15,
		[Token(Token = "0x40000C6")]
		LEFT_SHOULDER = 16,
		[Token(Token = "0x40000C7")]
		RIGHT_SHOULDER = 17,
		[Token(Token = "0x40000C8")]
		LEFT_ELBOW = 18,
		[Token(Token = "0x40000C9")]
		RIGHT_ELBOW = 19,
		[Token(Token = "0x40000CA")]
		LEFT_WRIST = 20,
		[Token(Token = "0x40000CB")]
		RIGHT_WRIST = 21,
		[Token(Token = "0x40000CC")]
		LEFT_HAND = 22,
		[Token(Token = "0x40000CD")]
		RIGHT_HAND = 23,
		[Token(Token = "0x40000CE")]
		NONE_Bones = 24,
		[Token(Token = "0x40000CF")]
		MIN_Bones = 0,
		[Token(Token = "0x40000D0")]
		MAX_Bones = 23,
		[Token(Token = "0x40000D1")]
		Bones_NUM = 24
	}

	[Token(Token = "0x200001E")]
	public struct BodyTrackerTransPose
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long TimeStamp;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double PosX;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double PosY;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double PosZ;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double RotQx;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double RotQy;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double RotQz;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double RotQw;
	}

	[Token(Token = "0x200001F")]
	public struct BodyTrackerResult
	{
		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BodyTrackerTransform[] trackingdata;
	}

	[Token(Token = "0x2000020")]
	public struct BodyTrackerTransform
	{
		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BodyTrackerBones bone;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BodyTrackerTransPose localpose;

		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BodyTrackerTransPose globalpose;

		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public double[] velo;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public double[] acce;

		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public double[] wvelo;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public double[] wacce;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public uint Action;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public byte[] reserved;
	}

	[Token(Token = "0x2000021")]
	public struct SixDof
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long timestamp;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double x;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double y;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double z;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double rw;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double rx;

		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double ry;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double rz;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte type;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public byte confidence;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PoseErrorType error;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double plane_height;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public byte plane_status;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public byte relocation_status;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public byte[] reserved;
	}

	[Token(Token = "0x2000022")]
	public enum PoseErrorType
	{
		[Token(Token = "0x40000F4")]
		BRIGHT_LIGHT_ERROR = 1,
		[Token(Token = "0x40000F5")]
		LOW_LIGHT_ERROR = 2,
		[Token(Token = "0x40000F6")]
		LOW_FEATURE_COUNT_ERROR = 4,
		[Token(Token = "0x40000F7")]
		CAMERA_CALIBRATION_ERROR = 8,
		[Token(Token = "0x40000F8")]
		RELOCATION_IN_PROGRESS = 0x10,
		[Token(Token = "0x40000F9")]
		INITILIZATION_IN_PROGRESS = 0x20,
		[Token(Token = "0x40000FA")]
		NO_CAMERA_ERROR = 0x40,
		[Token(Token = "0x40000FB")]
		NO_IMU_ERROR = 0x80,
		[Token(Token = "0x40000FC")]
		IMU_JITTER_ERROR = 0x100,
		[Token(Token = "0x40000FD")]
		UNKNOWN_ERROR = 0x200
	}

	[Token(Token = "0x2000023")]
	public struct AlgoResult
	{
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SixDof pose;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SixDof relocation_pose;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public double vx;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public double vy;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public double vz;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public double ax;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public double ay;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public double az;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public double wx;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public double wy;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public double wz;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public double w_ax;

		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public double w_ay;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public double w_az;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public byte[] reserved;
	}

	[Token(Token = "0x2000024")]
	public enum BodyTrackerRole
	{
		[Token(Token = "0x400010E")]
		Pelvis = 0,
		[Token(Token = "0x400010F")]
		LEFT_HIP = 1,
		[Token(Token = "0x4000110")]
		RIGHT_HIP = 2,
		[Token(Token = "0x4000111")]
		SPINE1 = 3,
		[Token(Token = "0x4000112")]
		LEFT_KNEE = 4,
		[Token(Token = "0x4000113")]
		RIGHT_KNEE = 5,
		[Token(Token = "0x4000114")]
		SPINE2 = 6,
		[Token(Token = "0x4000115")]
		LEFT_ANKLE = 7,
		[Token(Token = "0x4000116")]
		RIGHT_ANKLE = 8,
		[Token(Token = "0x4000117")]
		SPINE3 = 9,
		[Token(Token = "0x4000118")]
		LEFT_FOOT = 10,
		[Token(Token = "0x4000119")]
		RIGHT_FOOT = 11,
		[Token(Token = "0x400011A")]
		NECK = 12,
		[Token(Token = "0x400011B")]
		LEFT_COLLAR = 13,
		[Token(Token = "0x400011C")]
		RIGHT_COLLAR = 14,
		[Token(Token = "0x400011D")]
		HEAD = 15,
		[Token(Token = "0x400011E")]
		LEFT_SHOULDER = 16,
		[Token(Token = "0x400011F")]
		RIGHT_SHOULDER = 17,
		[Token(Token = "0x4000120")]
		LEFT_ELBOW = 18,
		[Token(Token = "0x4000121")]
		RIGHT_ELBOW = 19,
		[Token(Token = "0x4000122")]
		LEFT_WRIST = 20,
		[Token(Token = "0x4000123")]
		RIGHT_WRIST = 21,
		[Token(Token = "0x4000124")]
		LEFT_HAND = 22,
		[Token(Token = "0x4000125")]
		RIGHT_HAND = 23,
		[Token(Token = "0x4000126")]
		NONE_ROLE = 24,
		[Token(Token = "0x4000127")]
		MIN_ROLE = 0,
		[Token(Token = "0x4000128")]
		MAX_ROLE = 23,
		[Token(Token = "0x4000129")]
		ROLE_NUM = 24
	}

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public List<Transform> BonesList;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Dictionary<int, Quaternion> mRotationDic;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BodyTrackerResult mBodyTrackerResult;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private double mDisplayTime;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 position;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Quaternion rotation;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 rightFootPosition;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string logPath;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 leftAnklePos;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private Vector3 rightAnklePos;

	[Token(Token = "0x6000084")]
	[Address(RVA = "0xAD88A0", Offset = "0xAD88A0", VA = "0xAD88A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0xAD8A14", Offset = "0xAD8A14", VA = "0xAD8A14")]
	private void Update()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000086")]
	[Address(RVA = "0xAD94FC", Offset = "0xAD94FC", VA = "0xAD94FC")]
	public static extern int PT_GetBodyTrackingData(ref BodyTrackerResult mBodyTrackerResult);

	[PreserveSig]
	[Token(Token = "0x6000087")]
	[Address(RVA = "0xAD9620", Offset = "0xAD9620", VA = "0xAD9620")]
	public static extern int PT_SetBodyTrackingMode(int mode);

	[PreserveSig]
	[Token(Token = "0x6000088")]
	[Address(RVA = "0xAD969C", Offset = "0xAD969C", VA = "0xAD969C")]
	public static extern int PT_GetHeadTrackingData(ref SixDof sixDof);

	[PreserveSig]
	[Token(Token = "0x6000089")]
	[Address(RVA = "0xAD9794", Offset = "0xAD9794", VA = "0xAD9794")]
	public static extern int PT_GetControllerData(ref AlgoResult gLeft, ref AlgoResult gRight, ref AlgoResult left, ref AlgoResult right);

	[PreserveSig]
	[Token(Token = "0x600008A")]
	[Address(RVA = "0xAD95BC", Offset = "0xAD95BC", VA = "0xAD95BC")]
	public static extern double getFloorHeightProp();

	[Token(Token = "0x600008B")]
	[Address(RVA = "0xAD9988", Offset = "0xAD9988", VA = "0xAD9988")]
	public SimpleSample()
	{
	}
}
[Token(Token = "0x2000025")]
public class UIExample : MonoBehaviour
{
	[Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class <CountDown>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UIExample <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xADC244", Offset = "0xADC244", VA = "0xADC244", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xADC28C", Offset = "0xADC28C", VA = "0xADC28C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0xADA0CC", Offset = "0xADA0CC", VA = "0xADA0CC")]
		[DebuggerHidden]
		public <CountDown>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0xADC158", Offset = "0xADC158", VA = "0xADC158", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0xADC15C", Offset = "0xADC15C", VA = "0xADC15C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xADC24C", Offset = "0xADC24C", VA = "0xADC24C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button StartButton;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button EndButton;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI text;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button AutoButton;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button AutoButton2;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button Button0;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button Button1;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Button Button2;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Button Button3;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Button Button4;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Button Button5;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Button Button6;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Button Button7;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Button Button8;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Button Button9;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Button ButtonX;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI Text1;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshProUGUI Text2;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshProUGUI Text3;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI Text4;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI Text5;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI countdownText;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform Head;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Transform LeftHand;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform RightHand;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform LeftFoot;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform RightFoot;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public VRIK vrik;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private IDisposable temp;

	[Token(Token = "0x600008C")]
	[Address(RVA = "0xAD9A7C", Offset = "0xAD9A7C", VA = "0xAD9A7C")]
	private void Start()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xADA054", Offset = "0xADA054", VA = "0xADA054")]
	[IteratorStateMachine(typeof(<CountDown>d__30))]
	private IEnumerator CountDown(float time)
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xADA0F4", Offset = "0xADA0F4", VA = "0xADA0F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xADB2FC", Offset = "0xADB2FC", VA = "0xADB2FC")]
	public UIExample()
	{
	}
}
[Token(Token = "0x2000028")]
public class VRAnimatorController : MonoBehaviour
{
	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float speedTreshold;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Range(0f, 1f)]
	public float smoothing;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator animator;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 previousPos;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 previousRot;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private VRIK ik;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool isInit;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private VRRig rig;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool hasFace;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public int faceID;

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xADC294", Offset = "0xADC294", VA = "0xADC294")]
	private void Start()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xADC298", Offset = "0xADC298", VA = "0xADC298")]
	public void Init()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xADC368", Offset = "0xADC368", VA = "0xADC368")]
	private void Update()
	{
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0xADC618", Offset = "0xADC618", VA = "0xADC618")]
	public void Event_LeftStep()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0xADC61C", Offset = "0xADC61C", VA = "0xADC61C")]
	public void Event_RightStep()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0xADC620", Offset = "0xADC620", VA = "0xADC620")]
	public VRAnimatorController()
	{
	}
}
[Token(Token = "0x2000029")]
public class VRRig : MonoBehaviour
{
	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform playArea;

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0xADC634", Offset = "0xADC634", VA = "0xADC634")]
	private void Start()
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0xADC638", Offset = "0xADC638", VA = "0xADC638")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0xADC71C", Offset = "0xADC71C", VA = "0xADC71C")]
	public VRRig()
	{
	}
}
namespace UniRx.WebRequest
{
	[Token(Token = "0x200002A")]
	public static class ObservableWebRequest
	{
		[Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class <Fetch>d__14<T> : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000184")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000185")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private object <>2__current;

			[Token(Token = "0x4000186")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IDictionary<string, string> headers;

			[Token(Token = "0x4000187")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public UnityWebRequest request;

			[Token(Token = "0x4000188")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IProgress<float> reportProgress;

			[Token(Token = "0x4000189")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IObserver<T> observer;

			[Token(Token = "0x400018A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CancellationToken cancel;

			[Token(Token = "0x400018B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private UnityWebRequestAsyncOperation <operation>5__2;

			[Token(Token = "0x17000005")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000E2")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000006")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000E4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000DF")]
			[DebuggerHidden]
			public <Fetch>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60000E0")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E1")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E3")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class <FetchRequest>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400018C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400018D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400018E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x400018F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDictionary<string, string> headers;

			[Token(Token = "0x4000190")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IObserver<UnityWebRequest> observer;

			[Token(Token = "0x4000191")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IProgress<float> reportProgress;

			[Token(Token = "0x4000192")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancel;

			[Token(Token = "0x4000193")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <>7__wrap1;

			[Token(Token = "0x17000007")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000E9")]
				[Address(RVA = "0xADDFC0", Offset = "0xADDFC0", VA = "0xADDFC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000008")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000EB")]
				[Address(RVA = "0xADE008", Offset = "0xADE008", VA = "0xADE008", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000E5")]
			[Address(RVA = "0xADD650", Offset = "0xADD650", VA = "0xADD650")]
			[DebuggerHidden]
			public <FetchRequest>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xADDBE0", Offset = "0xADDBE0", VA = "0xADDBE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000E7")]
			[Address(RVA = "0xADDBFC", Offset = "0xADDBFC", VA = "0xADDBFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xADDF10", Offset = "0xADDF10", VA = "0xADDF10")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000EA")]
			[Address(RVA = "0xADDFC8", Offset = "0xADDFC8", VA = "0xADDFC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class <FetchText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000194")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000195")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000196")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x4000197")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDictionary<string, string> headers;

			[Token(Token = "0x4000198")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IObserver<string> observer;

			[Token(Token = "0x4000199")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IProgress<float> reportProgress;

			[Token(Token = "0x400019A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancel;

			[Token(Token = "0x400019B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <>7__wrap1;

			[Token(Token = "0x17000009")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F0")]
				[Address(RVA = "0x110D534", Offset = "0x110D534", VA = "0x110D534", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F2")]
				[Address(RVA = "0x110D57C", Offset = "0x110D57C", VA = "0x110D57C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x110CFD0", Offset = "0x110CFD0", VA = "0x110CFD0")]
			[DebuggerHidden]
			public <FetchText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x110CFF8", Offset = "0x110CFF8", VA = "0x110CFF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x110D014", Offset = "0x110D014", VA = "0x110D014", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x110D484", Offset = "0x110D484", VA = "0x110D484")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x110D53C", Offset = "0x110D53C", VA = "0x110D53C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class <FetchAssetBundle>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400019C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400019D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400019E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x400019F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDictionary<string, string> headers;

			[Token(Token = "0x40001A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IObserver<AssetBundle> observer;

			[Token(Token = "0x40001A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IProgress<float> reportProgress;

			[Token(Token = "0x40001A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancel;

			[Token(Token = "0x40001A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <>7__wrap1;

			[Token(Token = "0x1700000B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000F7")]
				[Address(RVA = "0x110D9EC", Offset = "0x110D9EC", VA = "0x110D9EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60000F9")]
				[Address(RVA = "0x110DA34", Offset = "0x110DA34", VA = "0x110DA34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x110D584", Offset = "0x110D584", VA = "0x110D584")]
			[DebuggerHidden]
			public <FetchAssetBundle>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x110D5AC", Offset = "0x110D5AC", VA = "0x110D5AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x110D5C8", Offset = "0x110D5C8", VA = "0x110D5C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x110D93C", Offset = "0x110D93C", VA = "0x110D93C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x110D9F4", Offset = "0x110D9F4", VA = "0x110D9F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class <FetchBytes>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40001A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40001A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40001A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityWebRequest request;

			[Token(Token = "0x40001A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IDictionary<string, string> headers;

			[Token(Token = "0x40001A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public IObserver<byte[]> observer;

			[Token(Token = "0x40001A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public IProgress<float> reportProgress;

			[Token(Token = "0x40001AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancel;

			[Token(Token = "0x40001AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private UnityWebRequest <>7__wrap1;

			[Token(Token = "0x1700000D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60000FE")]
				[Address(RVA = "0x110DE70", Offset = "0x110DE70", VA = "0x110DE70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000100")]
				[Address(RVA = "0x110DEB8", Offset = "0x110DEB8", VA = "0x110DEB8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x110DA3C", Offset = "0x110DA3C", VA = "0x110DA3C")]
			[DebuggerHidden]
			public <FetchBytes>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x110DA64", Offset = "0x110DA64", VA = "0x110DA64", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x110DA80", Offset = "0x110DA80", VA = "0x110DA80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x110DDC0", Offset = "0x110DDC0", VA = "0x110DDC0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x110DE78", Offset = "0x110DE78", VA = "0x110DE78", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xADC724", Offset = "0xADC724", VA = "0xADC724")]
		public static IObservable<UnityWebRequest> ToRequestObservable(this UnityWebRequest request, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xADC820", Offset = "0xADC820", VA = "0xADC820")]
		public static IObservable<string> ToObservable(this UnityWebRequest request, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xADC91C", Offset = "0xADC91C", VA = "0xADC91C")]
		public static IObservable<byte[]> ToBytesObservable(this UnityWebRequest request, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0xADCA18", Offset = "0xADCA18", VA = "0xADCA18")]
		public static IObservable<string> Get(string url, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xADCB1C", Offset = "0xADCB1C", VA = "0xADCB1C")]
		public static IObservable<byte[]> GetAndGetBytes(string url, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0xADCC20", Offset = "0xADCC20", VA = "0xADCC20")]
		public static IObservable<UnityWebRequest> GetRequest(string url, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xADCD24", Offset = "0xADCD24", VA = "0xADCD24")]
		public static IObservable<string> Post(string url, Dictionary<string, string> postData, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xADCE34", Offset = "0xADCE34", VA = "0xADCE34")]
		public static IObservable<string> Put(string url, string putData, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xADCF44", Offset = "0xADCF44", VA = "0xADCF44")]
		public static IObservable<string> PostJson(string url, string json, [Optional] IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0xADD190", Offset = "0xADD190", VA = "0xADD190")]
		public static IObservable<byte[]> PostAndGetBytes(string url, Dictionary<string, string> postData, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xADD294", Offset = "0xADD294", VA = "0xADD294")]
		public static IObservable<byte[]> PostAndGetBytes(string url, Dictionary<string, string> postData, IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0xADD3A4", Offset = "0xADD3A4", VA = "0xADD3A4")]
		public static IObservable<UnityWebRequest> PostRequest(string url, Dictionary<string, string> postData, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xADD4A8", Offset = "0xADD4A8", VA = "0xADD4A8")]
		public static IObservable<UnityWebRequest> PostRequest(string url, Dictionary<string, string> postData, IDictionary<string, string> headers, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xADD5B8", Offset = "0xADD5B8", VA = "0xADD5B8")]
		public static IObservable<AssetBundle> LoadFromCacheOrDownload(string url, uint version, uint crc, [Optional] IProgress<float> progress)
		{
			return null;
		}

		[Token(Token = "0x60000C0")]
		[IteratorStateMachine(typeof(<Fetch>d__14<>))]
		private static IEnumerator Fetch<T>(UnityWebRequest request, IDictionary<string, string> headers, IObserver<T> observer, IProgress<float> reportProgress, CancellationToken cancel)
		{
			return null;
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0xADD5C0", Offset = "0xADD5C0", VA = "0xADD5C0")]
		[IteratorStateMachine(typeof(<FetchRequest>d__15))]
		private static IEnumerator FetchRequest(UnityWebRequest request, IDictionary<string, string> headers, IObserver<UnityWebRequest> observer, IProgress<float> reportProgress, CancellationToken cancel)
		{
			return null;
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xADD678", Offset = "0xADD678", VA = "0xADD678")]
		[IteratorStateMachine(typeof(<FetchText>d__16))]
		private static IEnumerator FetchText(UnityWebRequest request, IDictionary<string, string> headers, IObserver<string> observer, IProgress<float> reportProgress, CancellationToken cancel)
		{
			return null;
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0xADD708", Offset = "0xADD708", VA = "0xADD708")]
		[IteratorStateMachine(typeof(<FetchAssetBundle>d__17))]
		private static IEnumerator FetchAssetBundle(UnityWebRequest request, IDictionary<string, string> headers, IObserver<AssetBundle> observer, IProgress<float> reportProgress, CancellationToken cancel)
		{
			return null;
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xADD798", Offset = "0xADD798", VA = "0xADD798")]
		[IteratorStateMachine(typeof(<FetchBytes>d__18))]
		private static IEnumerator FetchBytes(UnityWebRequest request, IDictionary<string, string> headers, IObserver<byte[]> observer, IProgress<float> reportProgress, CancellationToken cancel)
		{
			return null;
		}
	}
	[Token(Token = "0x200003D")]
	public class UnityWebRequestErrorException : Exception
	{
		[Token(Token = "0x1700000F")]
		public string RawErrorMessage
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x110DEC0", Offset = "0x110DEC0", VA = "0x110DEC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x110DEC8", Offset = "0x110DEC8", VA = "0x110DEC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public bool HasResponse
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x110DED0", Offset = "0x110DED0", VA = "0x110DED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x110DED8", Offset = "0x110DED8", VA = "0x110DED8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000011")]
		public string Text
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x110DEE4", Offset = "0x110DEE4", VA = "0x110DEE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x110DEEC", Offset = "0x110DEEC", VA = "0x110DEEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000012")]
		public HttpStatusCode StatusCode
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x110DEF4", Offset = "0x110DEF4", VA = "0x110DEF4")]
			[CompilerGenerated]
			get
			{
				return default(HttpStatusCode);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x110DEFC", Offset = "0x110DEFC", VA = "0x110DEFC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000013")]
		public Dictionary<string, string> ResponseHeaders
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x110DF04", Offset = "0x110DF04", VA = "0x110DF04")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x110DF0C", Offset = "0x110DF0C", VA = "0x110DF0C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public UnityWebRequest Request
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x110DF14", Offset = "0x110DF14", VA = "0x110DF14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x110DF1C", Offset = "0x110DF1C", VA = "0x110DF1C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x110D398", Offset = "0x110D398", VA = "0x110D398")]
		public UnityWebRequestErrorException(UnityWebRequest request)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x110DF24", Offset = "0x110DF24", VA = "0x110DF24", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace DeviceTracker
{
	[Token(Token = "0x200003E")]
	public enum BodyTrackerBones
	{
		[Token(Token = "0x40001B3")]
		Pelvis = 0,
		[Token(Token = "0x40001B4")]
		LEFT_HIP = 1,
		[Token(Token = "0x40001B5")]
		RIGHT_HIP = 2,
		[Token(Token = "0x40001B6")]
		SPINE1 = 3,
		[Token(Token = "0x40001B7")]
		LEFT_KNEE = 4,
		[Token(Token = "0x40001B8")]
		RIGHT_KNEE = 5,
		[Token(Token = "0x40001B9")]
		SPINE2 = 6,
		[Token(Token = "0x40001BA")]
		LEFT_ANKLE = 7,
		[Token(Token = "0x40001BB")]
		RIGHT_ANKLE = 8,
		[Token(Token = "0x40001BC")]
		SPINE3 = 9,
		[Token(Token = "0x40001BD")]
		LEFT_FOOT = 10,
		[Token(Token = "0x40001BE")]
		RIGHT_FOOT = 11,
		[Token(Token = "0x40001BF")]
		NECK = 12,
		[Token(Token = "0x40001C0")]
		LEFT_COLLAR = 13,
		[Token(Token = "0x40001C1")]
		RIGHT_COLLAR = 14,
		[Token(Token = "0x40001C2")]
		HEAD = 15,
		[Token(Token = "0x40001C3")]
		LEFT_SHOULDER = 16,
		[Token(Token = "0x40001C4")]
		RIGHT_SHOULDER = 17,
		[Token(Token = "0x40001C5")]
		LEFT_ELBOW = 18,
		[Token(Token = "0x40001C6")]
		RIGHT_ELBOW = 19,
		[Token(Token = "0x40001C7")]
		LEFT_WRIST = 20,
		[Token(Token = "0x40001C8")]
		RIGHT_WRIST = 21,
		[Token(Token = "0x40001C9")]
		LEFT_HAND = 22,
		[Token(Token = "0x40001CA")]
		RIGHT_HAND = 23,
		[Token(Token = "0x40001CB")]
		NONE_Bones = 24,
		[Token(Token = "0x40001CC")]
		MIN_Bones = 0,
		[Token(Token = "0x40001CD")]
		MAX_Bones = 23,
		[Token(Token = "0x40001CE")]
		Bones_NUM = 24
	}
	[Token(Token = "0x200003F")]
	public struct BodyTrackerTransPose
	{
		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long TimeStamp;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double PosX;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double PosY;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double PosZ;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double RotQx;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double RotQy;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double RotQz;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double RotQw;
	}
	[Token(Token = "0x2000040")]
	public struct BodyTrackerResult
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BodyTrackerTransform[] trackingdata;
	}
	[Token(Token = "0x2000041")]
	public struct BodyTrackerTransform
	{
		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BodyTrackerBones bone;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BodyTrackerTransPose localpose;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public BodyTrackerTransPose globalpose;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public double[] velo;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public double[] acce;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public double[] wvelo;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public double[] wacce;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public uint Action;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public byte[] reserved;
	}
	[Token(Token = "0x2000042")]
	public struct SixDof
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public long timestamp;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double x;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double y;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double z;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double rw;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double rx;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public double ry;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public double rz;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public byte type;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public byte confidence;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PoseErrorType error;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public double plane_height;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public byte plane_status;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public byte relocation_status;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public byte[] reserved;
	}
	[Token(Token = "0x2000043")]
	public enum PoseErrorType
	{
		[Token(Token = "0x40001F1")]
		BRIGHT_LIGHT_ERROR = 1,
		[Token(Token = "0x40001F2")]
		LOW_LIGHT_ERROR = 2,
		[Token(Token = "0x40001F3")]
		LOW_FEATURE_COUNT_ERROR = 4,
		[Token(Token = "0x40001F4")]
		CAMERA_CALIBRATION_ERROR = 8,
		[Token(Token = "0x40001F5")]
		RELOCATION_IN_PROGRESS = 0x10,
		[Token(Token = "0x40001F6")]
		INITILIZATION_IN_PROGRESS = 0x20,
		[Token(Token = "0x40001F7")]
		NO_CAMERA_ERROR = 0x40,
		[Token(Token = "0x40001F8")]
		NO_IMU_ERROR = 0x80,
		[Token(Token = "0x40001F9")]
		IMU_JITTER_ERROR = 0x100,
		[Token(Token = "0x40001FA")]
		UNKNOWN_ERROR = 0x200
	}
	[Token(Token = "0x2000044")]
	public struct AlgoResult
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public SixDof pose;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public SixDof relocation_pose;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public double vx;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public double vy;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public double vz;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public double ax;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public double ay;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public double az;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public double wx;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public double wy;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public double wz;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public double w_ax;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public double w_ay;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public double w_az;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		public byte[] reserved;
	}
	[Token(Token = "0x2000045")]
	public enum ControllerType
	{
		[Token(Token = "0x400020B")]
		GLOBLE_LEFT,
		[Token(Token = "0x400020C")]
		GLOBEL_RIGHT,
		[Token(Token = "0x400020D")]
		LOCLA_LEFT,
		[Token(Token = "0x400020E")]
		LOCAL_RIGHT
	}
	[Token(Token = "0x2000046")]
	public class IDeviceInputReader
	{
		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool mSwiftValid;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool mHeadValid;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
		public bool mCtrlValid;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected BodyTrackerResult bodyTrackerResult;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SixDof headData;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AlgoResult gLeftData;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		public AlgoResult gRightData;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		public AlgoResult leftData;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		public AlgoResult rightData;

		[Token(Token = "0x17000015")]
		public bool IsSwiftValid
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x110DF9C", Offset = "0x110DF9C", VA = "0x110DF9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000016")]
		public bool IsHeadValid
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x110DFA4", Offset = "0x110DFA4", VA = "0x110DFA4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000017")]
		public bool IsCtrlValid
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0x110DFB8", Offset = "0x110DFB8", VA = "0x110DFB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x110DFAC", Offset = "0x110DFAC", VA = "0x110DFAC")]
		public void SetHeadValid(bool valid)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x110DFC0", Offset = "0x110DFC0", VA = "0x110DFC0")]
		public void SetCtrlValid(bool valid)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x110DFCC", Offset = "0x110DFCC", VA = "0x110DFCC", Slot = "4")]
		public virtual void OnInitialize()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x110E094", Offset = "0x110E094", VA = "0x110E094", Slot = "5")]
		public virtual void OnUpdateDevicePose()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x110E098", Offset = "0x110E098", VA = "0x110E098", Slot = "6")]
		public virtual BodyTrackerResult GetTrackerResult()
		{
			return default(BodyTrackerResult);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x110E0A0", Offset = "0x110E0A0", VA = "0x110E0A0")]
		public void SetSwiftValid(bool valid)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x110E0AC", Offset = "0x110E0AC", VA = "0x110E0AC")]
		protected BodyTrackerTransform GetOrCreateResultTrackingdata(int index)
		{
			return default(BodyTrackerTransform);
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x110E12C", Offset = "0x110E12C", VA = "0x110E12C")]
		protected void SetResultTrackingdata(int index, BodyTrackerTransform data)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x110E1AC", Offset = "0x110E1AC", VA = "0x110E1AC", Slot = "7")]
		public virtual BodyTrackerTransPose GetBonesLocalPose(BodyTrackerBones type)
		{
			return default(BodyTrackerTransPose);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x110E1F4", Offset = "0x110E1F4", VA = "0x110E1F4", Slot = "8")]
		public virtual Vector3 GetBonesLocalPosition(BodyTrackerBones type)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x110E238", Offset = "0x110E238", VA = "0x110E238")]
		public SixDof GetHeadTrackingData()
		{
			return default(SixDof);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x110E248", Offset = "0x110E248", VA = "0x110E248")]
		public AlgoResult GetControllerData(ControllerType type)
		{
			return default(AlgoResult);
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x110E298", Offset = "0x110E298", VA = "0x110E298")]
		public IDeviceInputReader()
		{
		}
	}
}
namespace BoneTool.Script.Runtime
{
	[Token(Token = "0x2000047")]
	[RequireComponent(typeof(BoneVisualiser))]
	public class BonePoseLib : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000048")]
		public class ArmaturePose
		{
			[Token(Token = "0x4000219")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string Name;

			[Token(Token = "0x400021A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public List<BonePose> BonePoses;

			[Token(Token = "0x6000124")]
			[Address(RVA = "0x110E8A0", Offset = "0x110E8A0", VA = "0x110E8A0")]
			public ArmaturePose()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000049")]
		public struct BonePose
		{
			[Token(Token = "0x400021B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 SavedPos;

			[Token(Token = "0x400021C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 SavedRot;

			[Token(Token = "0x400021D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 SavedSca;

			[Token(Token = "0x400021E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform TargetTransform;

			[Token(Token = "0x6000125")]
			[Address(RVA = "0x110E60C", Offset = "0x110E60C", VA = "0x110E60C")]
			public BonePose(Transform targetTransform)
			{
			}

			[Token(Token = "0x6000126")]
			[Address(RVA = "0x110E840", Offset = "0x110E840", VA = "0x110E840")]
			public void Apply()
			{
			}
		}

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<ArmaturePose> Poses;

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x110E2A0", Offset = "0x110E2A0", VA = "0x110E2A0")]
		public void AddPose(ArmaturePose pose)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x110E348", Offset = "0x110E348", VA = "0x110E348")]
		public void RemovePose(string poseName)
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x110E424", Offset = "0x110E424", VA = "0x110E424")]
		public void SetPose(int index)
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x110E674", Offset = "0x110E674", VA = "0x110E674")]
		public void ApplyPose(int index)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x110E898", Offset = "0x110E898", VA = "0x110E898")]
		public BonePoseLib()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	public class BoneVisualiser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200004B")]
		private struct BoneTransform
		{
			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform Target;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Vector3 LocalPosition;

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x110EB68", Offset = "0x110EB68", VA = "0x110EB68")]
			public BoneTransform(Transform target, Vector3 localPosition)
			{
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x110EB9C", Offset = "0x110EB9C", VA = "0x110EB9C")]
			public void SetLocalPosition(Vector3 position)
			{
			}
		}

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform RootNode;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float BoneGizmosSize;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color BoneColor;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool HideRoot;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool EnableConstraint;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform _preRootNode;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform[] _childNodes;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneTransform[] _previousTransforms;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x110E8F0", Offset = "0x110E8F0", VA = "0x110E8F0")]
		public Transform[] GetChildNodes()
		{
			return null;
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x110E8F8", Offset = "0x110E8F8", VA = "0x110E8F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x110EA24", Offset = "0x110EA24", VA = "0x110EA24")]
		public void PopulateChildren()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x110EB78", Offset = "0x110EB78", VA = "0x110EB78")]
		public BoneVisualiser()
		{
		}
	}
}
namespace BNG
{
	[Token(Token = "0x200004C")]
	public enum HandPoseId
	{
		[Token(Token = "0x400022A")]
		Default = 0,
		[Token(Token = "0x400022B")]
		Generic = 1,
		[Token(Token = "0x400022C")]
		PingPongBall = 2,
		[Token(Token = "0x400022D")]
		Controller = 3,
		[Token(Token = "0x400022E")]
		Rock = 4,
		[Token(Token = "0x400022F")]
		PistolGrip = 50
	}
	[Token(Token = "0x200004D")]
	public class HandPoseDefinitions : MonoBehaviour
	{
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x110EBA8", Offset = "0x110EBA8", VA = "0x110EBA8")]
		public HandPoseDefinitions()
		{
		}
	}
	[Token(Token = "0x200004E")]
	[RequireComponent(typeof(HandPoser))]
	[ExecuteInEditMode]
	public class AutoPoser : MonoBehaviour
	{
		[Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <updateAutoPoseRoutine>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000248")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AutoPoser <>4__this;

			[Token(Token = "0x1700001A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000147")]
				[Address(RVA = "0x1110484", Offset = "0x1110484", VA = "0x1110484", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000149")]
				[Address(RVA = "0x11104CC", Offset = "0x11104CC", VA = "0x11104CC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000144")]
			[Address(RVA = "0x110F2C0", Offset = "0x110F2C0", VA = "0x110F2C0")]
			[DebuggerHidden]
			public <updateAutoPoseRoutine>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x6000145")]
			[Address(RVA = "0x11103C8", Offset = "0x11103C8", VA = "0x11103C8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000146")]
			[Address(RVA = "0x11103CC", Offset = "0x11103CC", VA = "0x11103CC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000148")]
			[Address(RVA = "0x111048C", Offset = "0x111048C", VA = "0x111048C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("(Required) A HandPose in the fully open position. AutoPose will lerp each finger joint between OpenHandPose and ClosedHandPose until contact is made at each finger tip.")]
		[Header("Auto Pose Settings")]
		public HandPose OpenHandPose;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("(Required) A HandPose in the fully closed position. AutoPose will lerp each finger between OpenHandPose and ClosedHandPose until contact is made at each finger tip.")]
		public HandPose ClosedHandPose;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Finger Tip Collision")]
		[Range(0f, 0.02f)]
		[Tooltip("Radius (in meters) of the fingertips to use when checking for collisions during auto-posing. Only used if a FingerTipCollider is not defined. (Default : 0.00875)")]
		public float FingerTipRadius;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) Index Finger Offset - Use this to manually position and scale your finger tip collider")]
		public FingerTipCollider ThumbCollider;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) Index Finger Offset - Use this to manually position and scale your finger tip collider")]
		public FingerTipCollider IndexFingerCollider;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) Index Finger Offset - Use this to manually position and scale your finger tip collider")]
		public FingerTipCollider MiddleFingerCollider;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) Index Finger Offset - Use this to manually position and scale your finger tip collider")]
		public FingerTipCollider RingFingerCollider;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) Index Finger Offset - Use this to manually position and scale your finger tip collider")]
		public FingerTipCollider PinkyFingerCollider;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Continuous Update")]
		[Tooltip("If true the hand will auto pose in Update(). Also works in the editor.")]
		public bool UpdateContinuously;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("(Optional) The HandPose to use when UpdateContinuously = true and no collisions have been detected. If not specified, the hand will make a ClosedHandPose shape when no collisions have been found.")]
		public HandPose IdleHandPose;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LayerMask CollisionLayerMask;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Header("Editor Gizmos")]
		public bool ShowGizmos;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public GizmoDisplayType GizmoType;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Color GizmoColor;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public HandPoser InspectedPose;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private HandPoseDefinition currentPose;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HandPoseDefinition tempPose;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private HandPoseDefinition collisionPose;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int _count;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool _thumbHit;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool _indexHit;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		private bool _middleHit;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF")]
		private bool _ringHit;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool _pinkyHit;

		[Token(Token = "0x17000018")]
		public HandPoseDefinition CollisionPose
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0x110EBB0", Offset = "0x110EBB0", VA = "0x110EBB0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000019")]
		public bool CollisionDetected
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0x110EBB8", Offset = "0x110EBB8", VA = "0x110EBB8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x110EBF0", Offset = "0x110EBF0", VA = "0x110EBF0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x110EC7C", Offset = "0x110EC7C", VA = "0x110EC7C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x110EE90", Offset = "0x110EE90", VA = "0x110EE90")]
		private void Update()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x110F1E8", Offset = "0x110F1E8", VA = "0x110F1E8", Slot = "4")]
		public virtual void UpdateAutoPose(bool lerp)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x110F238", Offset = "0x110F238", VA = "0x110F238", Slot = "5")]
		public virtual void UpdateAutoPoseOnce()
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x110F258", Offset = "0x110F258", VA = "0x110F258")]
		[IteratorStateMachine(typeof(<updateAutoPoseRoutine>d__33))]
		private IEnumerator updateAutoPoseRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x110EFA8", Offset = "0x110EFA8", VA = "0x110EFA8")]
		public HandPoseDefinition GetAutoPose()
		{
			return null;
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x110F2E8", Offset = "0x110F2E8", VA = "0x110F2E8")]
		public HandPoseDefinition CopyHandDefinition(HandPoseDefinition ToCopy)
		{
			return null;
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x110F9AC", Offset = "0x110F9AC", VA = "0x110F9AC")]
		public FingerJoint GetJointCopy(FingerJoint ToClone)
		{
			return null;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x110F868", Offset = "0x110F868", VA = "0x110F868")]
		public List<FingerJoint> GetJointsCopy(List<FingerJoint> ToClone)
		{
			return null;
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x110F3C4", Offset = "0x110F3C4", VA = "0x110F3C4")]
		public bool GetThumbHit(HandPoser poser)
		{
			return default(bool);
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x110F4B0", Offset = "0x110F4B0", VA = "0x110F4B0")]
		public bool GetIndexHit(HandPoser poser)
		{
			return default(bool);
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x110F59C", Offset = "0x110F59C", VA = "0x110F59C")]
		public bool GetMiddleHit(HandPoser poser)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x110F688", Offset = "0x110F688", VA = "0x110F688")]
		public bool GetRingHit(HandPoser poser)
		{
			return default(bool);
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x110F774", Offset = "0x110F774", VA = "0x110F774")]
		public bool GetPinkyHit(HandPoser poser)
		{
			return default(bool);
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x110FC84", Offset = "0x110FC84", VA = "0x110FC84", Slot = "6")]
		public virtual bool LoopThroughJoints(List<Transform> fromJoints, List<FingerJoint> toJoints, Vector3 tipPosition, float tipRadius)
		{
			return default(bool);
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x111000C", Offset = "0x111000C", VA = "0x111000C", Slot = "7")]
		public virtual bool IsValidCollision(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1110094", Offset = "0x1110094", VA = "0x1110094")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1110258", Offset = "0x1110258", VA = "0x1110258")]
		public void DrawJointGizmo(FingerTipCollider tipCollider, Vector3 defaultPosition, float radius, GizmoDisplayType gizmoType)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1110384", Offset = "0x1110384", VA = "0x1110384")]
		public AutoPoser()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public enum GizmoDisplayType
	{
		[Token(Token = "0x400024C")]
		Wire,
		[Token(Token = "0x400024D")]
		Solid,
		[Token(Token = "0x400024E")]
		None
	}
	[Token(Token = "0x2000051")]
	public class BoneMapping : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000052")]
		public enum Mode
		{
			[Token(Token = "0x4000253")]
			FromToRotation,
			[Token(Token = "0x4000254")]
			MatchRotation
		}

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoneObject[] Fingers;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Shown for Debug : ")]
		public bool ShowGizmos;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x11104D4", Offset = "0x11104D4", VA = "0x11104D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x111077C", Offset = "0x111077C", VA = "0x111077C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1110BD8", Offset = "0x1110BD8", VA = "0x1110BD8")]
		public BoneMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000053")]
	public class BoneObject
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] targetBones;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] destinationBones;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 avatarForwardAxis;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 avatarUpAxis;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 targetForwardAxis;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 targetUpAxis;

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1110BF0", Offset = "0x1110BF0", VA = "0x1110BF0")]
		public BoneObject()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public class EditorHandle : MonoBehaviour
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowTransformName;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float Radius;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color BaseColor;

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1110D4C", Offset = "0x1110D4C", VA = "0x1110D4C")]
		public EditorHandle()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000055")]
	public class FingerJoint
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		public string TransformName;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Vector3 LocalPosition;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		public Quaternion LocalRotation;

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x110FA38", Offset = "0x110FA38", VA = "0x110FA38")]
		public FingerJoint()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public class FingerTipCollider : MonoBehaviour
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 0.02f)]
		[Tooltip("Radius (in meters) of the fingertip to use when checking for collisions during auto-posing. (Default : 0.00875)")]
		public float Radius;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1110D6C", Offset = "0x1110D6C", VA = "0x1110D6C")]
		public FingerTipCollider()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000057")]
	public class HandPose : ScriptableObject
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Pose Name")]
		public string PoseName;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Joint Definitions")]
		public HandPoseDefinition Joints;

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1110D80", Offset = "0x1110D80", VA = "0x1110D80")]
		public HandPose()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000058")]
	public class HandPoseDefinition
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		[Header("Wrist")]
		public FingerJoint WristJoint;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Thumb")]
		[SerializeField]
		public List<FingerJoint> ThumbJoints;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("Index")]
		public List<FingerJoint> IndexJoints;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Middle")]
		[SerializeField]
		public List<FingerJoint> MiddleJoints;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Header("Ring")]
		public List<FingerJoint> RingJoints;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Pinky")]
		[SerializeField]
		public List<FingerJoint> PinkyJoints;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Header("Other")]
		public List<FingerJoint> OtherJoints;

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x110F860", Offset = "0x110F860", VA = "0x110F860")]
		public HandPoseDefinition()
		{
		}
	}
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	public class HandPoser : MonoBehaviour
	{
		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowGizmos;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Path of the directory where handposes should be stored. Tip : Keep these in a 'Resources' directory so you can use Resources.Load().")]
		public string ResourcePath;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string PoseName;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public HandPose CurrentPose;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float AnimationSpeed;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform WristJoint;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<Transform> ThumbJoints;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<Transform> IndexJoints;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public List<Transform> MiddleJoints;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public List<Transform> RingJoints;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public List<Transform> PinkyJoints;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public List<Transform> OtherJoints;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private HandPose previousPose;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool doSingleAnimation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
		public bool ContinuousUpdate;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float editorAnimationTime;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float maxEditorAnimationTime;

		[Token(Token = "0x1700001C")]
		public HandPoseDefinition HandPoseJoints
		{
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x1110D88", Offset = "0x1110D88", VA = "0x1110D88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1110D94", Offset = "0x1110D94", VA = "0x1110D94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x1110DB4", Offset = "0x1110DB4", VA = "0x1110DB4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x1110DF0", Offset = "0x1110DF0", VA = "0x1110DF0")]
		public void CheckForPoseChange()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x1110DA4", Offset = "0x1110DA4", VA = "0x1110DA4")]
		public void OnPoseChanged()
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x1110F28", Offset = "0x1110F28", VA = "0x1110F28")]
		public FingerJoint GetWristJoint()
		{
			return null;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x1110F38", Offset = "0x1110F38", VA = "0x1110F38")]
		public List<FingerJoint> GetThumbJoints()
		{
			return null;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x1110F48", Offset = "0x1110F48", VA = "0x1110F48")]
		public List<FingerJoint> GetIndexJoints()
		{
			return null;
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x1110F58", Offset = "0x1110F58", VA = "0x1110F58")]
		public List<FingerJoint> GetMiddleJoints()
		{
			return null;
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x1110F68", Offset = "0x1110F68", VA = "0x1110F68")]
		public List<FingerJoint> GetRingJoints()
		{
			return null;
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x1110F78", Offset = "0x1110F78", VA = "0x1110F78")]
		public List<FingerJoint> GetPinkyJoints()
		{
			return null;
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x1110F88", Offset = "0x1110F88", VA = "0x1110F88")]
		public List<FingerJoint> GetOtherJoints()
		{
			return null;
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x1110F98", Offset = "0x1110F98", VA = "0x1110F98")]
		public Transform GetTip(List<Transform> transforms)
		{
			return null;
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x1111008", Offset = "0x1111008", VA = "0x1111008")]
		public Transform GetThumbTip()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x1111010", Offset = "0x1111010", VA = "0x1111010")]
		public Transform GetIndexTip()
		{
			return null;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x1111018", Offset = "0x1111018", VA = "0x1111018")]
		public Transform GetMiddleTip()
		{
			return null;
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x1111020", Offset = "0x1111020", VA = "0x1111020")]
		public Transform GetRingTip()
		{
			return null;
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x1111028", Offset = "0x1111028", VA = "0x1111028")]
		public Transform GetPinkyTip()
		{
			return null;
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x110FA40", Offset = "0x110FA40", VA = "0x110FA40")]
		public static Vector3 GetFingerTipPositionWithOffset(List<Transform> jointTransforms, float tipRadius)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x1111030", Offset = "0x1111030", VA = "0x1111030", Slot = "4")]
		public virtual List<FingerJoint> GetJointsFromTransforms(List<Transform> jointTransforms)
		{
			return null;
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x11111E4", Offset = "0x11111E4", VA = "0x11111E4", Slot = "5")]
		public virtual FingerJoint GetJointFromTransform(Transform jointTransform)
		{
			return null;
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x11112BC", Offset = "0x11112BC", VA = "0x11112BC", Slot = "6")]
		public virtual void UpdateHandPose(HandPoseDefinition pose, bool lerp)
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x11113A4", Offset = "0x11113A4", VA = "0x11113A4", Slot = "7")]
		public virtual void UpdateJoint(FingerJoint fromJoint, Transform toTransform, bool doLerp)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x1111578", Offset = "0x1111578", VA = "0x1111578", Slot = "8")]
		public virtual void UpdateJoints(List<FingerJoint> joints, List<Transform> toTransforms, bool doLerp)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x111175C", Offset = "0x111175C", VA = "0x111175C", Slot = "9")]
		public virtual HandPoseDefinition GetHandPoseDefinition()
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x1111864", Offset = "0x1111864", VA = "0x1111864", Slot = "10")]
		public virtual void SavePoseAsScriptablObject(string poseName)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x11118CC", Offset = "0x11118CC", VA = "0x11118CC", Slot = "11")]
		public virtual void CreateUniquePose(string poseName)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x11119F4", Offset = "0x11119F4", VA = "0x11119F4", Slot = "12")]
		public virtual HandPose GetHandPoseScriptableObject()
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x11119FC", Offset = "0x11119FC", VA = "0x11119FC", Slot = "13")]
		public virtual void DoPoseUpdate()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x1111AC0", Offset = "0x1111AC0", VA = "0x1111AC0", Slot = "14")]
		public virtual void ResetEditorHandles()
		{
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x1111C04", Offset = "0x1111C04", VA = "0x1111C04")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x1111C08", Offset = "0x1111C08", VA = "0x1111C08")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[ExecuteInEditMode]
	public class SkeletonVisualizer : MonoBehaviour
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ShowGizmos;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float JointRadius;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float BoneThickness;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Color GizmoColor;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool ShowTransformNames;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool isQuiting;

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x1111C94", Offset = "0x1111C94", VA = "0x1111C94")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x1111CA0", Offset = "0x1111CA0", VA = "0x1111CA0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x1111CA4", Offset = "0x1111CA4", VA = "0x1111CA4", Slot = "4")]
		public virtual bool IsTipOfBone(Transform fingerJoint)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x1111D94", Offset = "0x1111D94", VA = "0x1111D94")]
		public void ResetEditorHandles()
		{
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x1111ED8", Offset = "0x1111ED8", VA = "0x1111ED8")]
		public SkeletonVisualizer()
		{
		}
	}
	[Token(Token = "0x200005B")]
	public class BNGIKPlayerScale : MonoBehaviour
	{
		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float scaleMlp;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public ControllerBinding ScalePlayerInput;

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x1111F00", Offset = "0x1111F00", VA = "0x1111F00")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x1112074", Offset = "0x1112074", VA = "0x1112074")]
		public BNGIKPlayerScale()
		{
		}
	}
	[Token(Token = "0x200005C")]
	public class FingerMapping : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200005D")]
		public enum Mode
		{
			[Token(Token = "0x400028B")]
			FromToRotation,
			[Token(Token = "0x400028C")]
			MatchRotation
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Mode mode;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Finger[] fingers;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Shown for Debug : ")]
		public bool ShowGizmos;

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x1112088", Offset = "0x1112088", VA = "0x1112088")]
		private void Start()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x11121CC", Offset = "0x11121CC", VA = "0x11121CC")]
		private void AfterVRIK()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x11126E0", Offset = "0x11126E0", VA = "0x11126E0")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x11129EC", Offset = "0x11129EC", VA = "0x11129EC")]
		public FingerMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class Finger
	{
		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] avatarBones;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] targetBones;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 avatarForwardAxis;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 avatarUpAxis;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 targetForwardAxis;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 targetUpAxis;

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x1112A04", Offset = "0x1112A04", VA = "0x1112A04")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200005F")]
	public class IKHandTargetMover : MonoBehaviour
	{
		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabber grabber;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform HandTarget;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 positionOffset;

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x1112B60", Offset = "0x1112B60", VA = "0x1112B60")]
		private void Update()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x1112E20", Offset = "0x1112E20", VA = "0x1112E20")]
		public IKHandTargetMover()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public class DemoCube : MonoBehaviour
	{
		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material HighlightMaterial;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Material ActiveMaterial;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool active;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool hovering;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Material initialMaterial;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private MeshRenderer render;

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x1112E94", Offset = "0x1112E94", VA = "0x1112E94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x1112EF8", Offset = "0x1112EF8", VA = "0x1112EF8")]
		public void SetActive(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x1112F58", Offset = "0x1112F58", VA = "0x1112F58")]
		public void SetInactive(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x1112F60", Offset = "0x1112F60", VA = "0x1112F60")]
		public void SetHovering(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x1112F6C", Offset = "0x1112F6C", VA = "0x1112F6C")]
		public void ResetHovering(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x1112F04", Offset = "0x1112F04", VA = "0x1112F04")]
		public void UpdateMaterial()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x1112F74", Offset = "0x1112F74", VA = "0x1112F74")]
		public DemoCube()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class DemoScript : MonoBehaviour
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text LabelToUpdate;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProjectileLauncher DemoLauncher;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int MaxLaunchedObjects;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<GameObject> launchedObjects;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Text JoystickText;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject AmmoObject;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform ItemsHolder;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Grabbable, PosRot> _initalGrabbables;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody cubeRigid;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody cubeRigid1;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody cubeRigid2;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigid3;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private List<Grabbable> demoClips;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 rotateX;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 rotateY;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rotateZ;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rotateXYX;

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x1112F7C", Offset = "0x1112F7C", VA = "0x1112F7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x11133D8", Offset = "0x11133D8", VA = "0x11133D8")]
		private void Update()
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x1113518", Offset = "0x1113518", VA = "0x1113518")]
		public void UpdateSliderText(float sliderValue)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x1113668", Offset = "0x1113668", VA = "0x1113668")]
		public void UpdateJoystickText(float leverX, float leverY)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x11137A4", Offset = "0x11137A4", VA = "0x11137A4")]
		public void ResetGrabbables()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x1113B20", Offset = "0x1113B20", VA = "0x1113B20")]
		public void GrabAmmo(Grabber grabber)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x1113FDC", Offset = "0x1113FDC", VA = "0x1113FDC")]
		public void ShootLauncher()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x11131E8", Offset = "0x11131E8", VA = "0x11131E8")]
		private void initGravityCubes()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x11133DC", Offset = "0x11133DC", VA = "0x11133DC")]
		private void rotateGravityCubes()
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11141A0", Offset = "0x11141A0", VA = "0x11141A0")]
		public DemoScript()
		{
		}
	}
	[Token(Token = "0x2000062")]
	public class PosRot
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 Position;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion Rotation;

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x11131E0", Offset = "0x11131E0", VA = "0x11131E0")]
		public PosRot()
		{
		}
	}
	[Token(Token = "0x2000063")]
	public class CharacterConstraint : MonoBehaviour
	{
		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private BNGPlayerController bngController;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CharacterController character;

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x11141CC", Offset = "0x11141CC", VA = "0x11141CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x1114250", Offset = "0x1114250", VA = "0x1114250")]
		private void Update()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x111425C", Offset = "0x111425C", VA = "0x111425C", Slot = "4")]
		public virtual void CheckCharacterCollisionMove()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x11143CC", Offset = "0x11143CC", VA = "0x11143CC")]
		public CharacterConstraint()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class CharacterIK : MonoBehaviour
	{
		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform FollowLeftController;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform FollowRightController;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform FollowLeftFoot;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform FollowRightFoot;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform FollowHead;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float FootYPosition;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool IKActive;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool IKFeetActive;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool HideHead;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		public bool HideLeftArm;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool HideRightArm;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool HideLeftHand;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool HideRightHand;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		public bool HideLegs;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform HipsJoint;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CharacterController FollowPlayer;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform headBone;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform leftShoulderJoint;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform rightShoulderJoint;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform leftHandJoint;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform rightHandJoint;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Animator animator;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float HipOffset;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public Vector3 hideBoneScale;

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11143D4", Offset = "0x11143D4", VA = "0x11143D4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11144AC", Offset = "0x11144AC", VA = "0x11144AC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x1114914", Offset = "0x1114914", VA = "0x1114914")]
		private void OnAnimatorIK()
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x1114D5C", Offset = "0x1114D5C", VA = "0x1114D5C")]
		public CharacterIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class CharacterYOffset : MonoBehaviour
	{
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x1114D88", Offset = "0x1114D88", VA = "0x1114D88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x1114E2C", Offset = "0x1114E2C", VA = "0x1114E2C")]
		public CharacterYOffset()
		{
		}
	}
	[Token(Token = "0x2000066")]
	public class Climbable : Grabbable
	{
		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private PlayerClimbing playerClimbing;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x1114E34", Offset = "0x1114E34", VA = "0x1114E34")]
		private void Start()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x1114F14", Offset = "0x1114F14", VA = "0x1114F14", Slot = "20")]
		public override void GrabItem(Grabber grabbedBy)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x1114FB0", Offset = "0x1114FB0", VA = "0x1114FB0", Slot = "28")]
		public override void DropItem(Grabber droppedBy)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x1115070", Offset = "0x1115070", VA = "0x1115070")]
		public Climbable()
		{
		}
	}
	[Token(Token = "0x2000067")]
	public class CollisionSound : MonoBehaviour
	{
		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip CollisionAudio;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AudioSource audioSource;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float startTime;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Collider col;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable grab;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MinimumVolume;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaximumVolume;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool RecentlyPlayedSound;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float lastPlayedSound;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float LastRelativeVelocity;

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x1115078", Offset = "0x1115078", VA = "0x1115078")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11151A4", Offset = "0x11151A4", VA = "0x11151A4")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x111556C", Offset = "0x111556C", VA = "0x111556C")]
		private void resetLastPlayedSound()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x1115574", Offset = "0x1115574", VA = "0x1115574")]
		public CollisionSound()
		{
		}
	}
	[Token(Token = "0x2000068")]
	public class ConstrainLocalPosition : MonoBehaviour
	{
		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool ConstrainLocalX;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LocalXMin;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LocalXMax;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool ConstrainLocalY;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LocalYMin;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float LocalYMax;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool ConstrainLocalZ;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float LocalZMin;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float LocalZMax;

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x1115588", Offset = "0x1115588", VA = "0x1115588")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x111558C", Offset = "0x111558C", VA = "0x111558C")]
		private void doConstrain()
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x1115688", Offset = "0x1115688", VA = "0x1115688")]
		public ConstrainLocalPosition()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class Damageable : MonoBehaviour
	{
		[Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class <RespawnRoutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40002F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40002F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40002F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float seconds;

			[Token(Token = "0x40002F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Damageable <>4__this;

			[Token(Token = "0x1700001D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60001B1")]
				[Address(RVA = "0x1116404", Offset = "0x1116404", VA = "0x1116404", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700001E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60001B3")]
				[Address(RVA = "0x111644C", Offset = "0x111644C", VA = "0x111644C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60001AE")]
			[Address(RVA = "0x1115FA0", Offset = "0x1115FA0", VA = "0x1115FA0")]
			[DebuggerHidden]
			public <RespawnRoutine>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x1115FF0", Offset = "0x1115FF0", VA = "0x1115FF0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x1115FF4", Offset = "0x1115FF4", VA = "0x1115FF4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x111640C", Offset = "0x111640C", VA = "0x111640C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Health;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float _startingHealth;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If specified, this GameObject will be instantiated at this transform's position on death.")]
		public GameObject SpawnOnDeath;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Activate these GameObjects on Death")]
		public List<GameObject> ActivateGameObjectsOnDeath;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Deactivate these GameObjects on Death")]
		public List<GameObject> DeactivateGameObjectsOnDeath;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Deactivate these Colliders on Death")]
		public List<Collider> DeactivateCollidersOnDeath;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Destroy this object on Death? False if need to respawn.")]
		public bool DestroyOnDeath;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		[Tooltip("If this object is a Grabbable it can be dropped on Death")]
		public bool DropOnDeath;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("How long to wait before destroying this objects")]
		public float DestroyDelay;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If true the object will be reactivated according to RespawnTime")]
		public bool Respawn;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If Respawn true, this gameObject will reactivate after RespawnTime. In seconds.")]
		public float RespawnTime;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Remove any decals that were parented to this object on death. Useful for clearing unused decals.")]
		public bool RemoveBulletHolesOnDeath;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Events")]
		[Tooltip("Optional Event to be called when receiving damage. Takes damage amount as a float parameter.")]
		public FloatEvent onDamaged;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Optional Event to be called once health is <= 0")]
		public UnityEvent onDestroyed;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Optional Event to be called once the object has been respawned, if Respawn is true and after RespawnTime")]
		public UnityEvent onRespawn;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool destroyed;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody rigid;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool initialWasKinematic;

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x11156A4", Offset = "0x11156A4", VA = "0x11156A4")]
		private void Start()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x1115758", Offset = "0x1115758", VA = "0x1115758", Slot = "4")]
		public virtual void DealDamage(float damageAmount)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x1115808", Offset = "0x1115808", VA = "0x1115808", Slot = "5")]
		public virtual void DealDamage(float damageAmount, [Optional] Vector3? hitPosition, [Optional] Vector3? hitNormal, bool reactToHit = true, [Optional] GameObject sender, [Optional] GameObject receiver)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11158A4", Offset = "0x11158A4", VA = "0x11158A4", Slot = "6")]
		public virtual void DestroyThis()
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x1115F28", Offset = "0x1115F28", VA = "0x1115F28")]
		[IteratorStateMachine(typeof(<RespawnRoutine>d__22))]
		private IEnumerator RespawnRoutine(float seconds)
		{
			return null;
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1115FC8", Offset = "0x1115FC8", VA = "0x1115FC8")]
		public Damageable()
		{
		}
	}
	[Token(Token = "0x200006B")]
	public class DamageCollider : MonoBehaviour
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Damage;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rigidbody ColliderRigidbody;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MinForce;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float LastRelativeVelocity;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LastDamageForce;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool TakeCollisionDamage;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float CollisionDamage;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Damageable thisDamageable;

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x1116454", Offset = "0x1116454", VA = "0x1116454")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x1116504", Offset = "0x1116504", VA = "0x1116504")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x1116548", Offset = "0x1116548", VA = "0x1116548", Slot = "4")]
		public virtual void OnCollisionEvent(Collision collision)
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x1116818", Offset = "0x1116818", VA = "0x1116818")]
		public DamageCollider()
		{
		}
	}
	[Token(Token = "0x200006C")]
	public class DestroyObjectWithDelay : MonoBehaviour
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float DestroySeconds;

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x111683C", Offset = "0x111683C", VA = "0x111683C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x11168B8", Offset = "0x11168B8", VA = "0x11168B8")]
		public DestroyObjectWithDelay()
		{
		}
	}
	[Token(Token = "0x200006D")]
	public class FollowRigidbody : MonoBehaviour
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform FollowTransform;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody rigid;

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x11168C0", Offset = "0x11168C0", VA = "0x11168C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x1116910", Offset = "0x1116910", VA = "0x1116910")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x1116950", Offset = "0x1116950", VA = "0x1116950")]
		public FollowRigidbody()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class FollowTransform : MonoBehaviour
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform FollowTarget;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool MatchRotation;

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x1116958", Offset = "0x1116958", VA = "0x1116958")]
		private void Update()
		{
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1116A38", Offset = "0x1116A38", VA = "0x1116A38")]
		public FollowTransform()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class GrabAction : GrabbableEvents
	{
		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrabberEvent OnGrabEvent;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Grabbable g;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float lastGrabTime;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float minTimeBetweenGrabs;

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1116A48", Offset = "0x1116A48", VA = "0x1116A48", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x1116B88", Offset = "0x1116B88", VA = "0x1116B88")]
		public GrabAction()
		{
		}
	}
	[Token(Token = "0x2000070")]
	public class GrabbableBezierLine : GrabbableEvents
	{
		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool HighlightOnGrabbable;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool HighlightOnRemoteGrabbable;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public LineRenderer LineToDraw;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int SegmentCount;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float LerpAmount;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float HeightAdjustment;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Grabber lineToGrabber;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Grabber lineRemoteGrabbing;

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x1116B9C", Offset = "0x1116B9C", VA = "0x1116B9C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1116CBC", Offset = "0x1116CBC", VA = "0x1116CBC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x111714C", Offset = "0x111714C", VA = "0x111714C", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x1117170", Offset = "0x1117170", VA = "0x1117170", Slot = "8")]
		public override void OnBecomesClosestGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1117250", Offset = "0x1117250", VA = "0x1117250", Slot = "10")]
		public override void OnNoLongerClosestGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1117288", Offset = "0x1117288", VA = "0x1117288", Slot = "12")]
		public override void OnBecomesClosestRemoteGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x11172C4", Offset = "0x11172C4", VA = "0x11172C4", Slot = "14")]
		public override void OnNoLongerClosestRemoteGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x11171AC", Offset = "0x11171AC", VA = "0x11171AC")]
		public void HighlightItem(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1116C3C", Offset = "0x1116C3C", VA = "0x1116C3C")]
		public void UnhighlightItem()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1116FE4", Offset = "0x1116FE4", VA = "0x1116FE4")]
		public void DrawBezierCurve(Vector3 point0, Vector3 point1, Vector3 point2, LineRenderer lineRenderer)
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x11172FC", Offset = "0x11172FC", VA = "0x11172FC")]
		public GrabbableBezierLine()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public class GrabbableHaptics : GrabbableEvents
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool HapticsOnValidPickup;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool HapticsOnValidRemotePickup;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool HapticsOnCollision;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		public bool HapticsOnGrab;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float VibrateFrequency;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float VibrateAmplitude;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float VibrateDuration;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Grabber currentGrabber;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x111731C", Offset = "0x111731C", VA = "0x111731C", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x11173E4", Offset = "0x11173E4", VA = "0x11173E4", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x11173EC", Offset = "0x11173EC", VA = "0x11173EC", Slot = "7")]
		public override void OnBecomesClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x11173FC", Offset = "0x11173FC", VA = "0x11173FC", Slot = "11")]
		public override void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1117348", Offset = "0x1117348", VA = "0x1117348")]
		private void doHaptics(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x111740C", Offset = "0x111740C", VA = "0x111740C")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1117514", Offset = "0x1117514", VA = "0x1117514")]
		public GrabbableHaptics()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class GrabbableHighlight : GrabbableEvents
	{
		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool HighlightOnGrabbable;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool HighlightOnRemoteGrabbable;

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x111753C", Offset = "0x111753C", VA = "0x111753C", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1117544", Offset = "0x1117544", VA = "0x1117544", Slot = "7")]
		public override void OnBecomesClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x111754C", Offset = "0x111754C", VA = "0x111754C", Slot = "9")]
		public override void OnNoLongerClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1117550", Offset = "0x1117550", VA = "0x1117550", Slot = "11")]
		public override void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1117554", Offset = "0x1117554", VA = "0x1117554", Slot = "13")]
		public override void OnNoLongerClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1117548", Offset = "0x1117548", VA = "0x1117548")]
		public void HighlightItem()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1117540", Offset = "0x1117540", VA = "0x1117540")]
		public void UnhighlightItem()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1117558", Offset = "0x1117558", VA = "0x1117558")]
		public GrabbableHighlight()
		{
		}
	}
	[Token(Token = "0x2000073")]
	public class GrabbableHighlightMaterial : GrabbableEvents
	{
		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool HighlightOnGrabbable;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool HighlightOnRemoteGrabbable;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Materials to assign to Renderer when not being highlighted. ")]
		public List<Material> StandardMaterials;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Materials to assign to Renderer when being highlighted")]
		public List<Material> HighlightMaterials;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Renderer Renderer;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1117568", Offset = "0x1117568", VA = "0x1117568")]
		private void Start()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1117744", Offset = "0x1117744", VA = "0x1117744", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x11177F8", Offset = "0x11177F8", VA = "0x11177F8", Slot = "7")]
		public override void OnBecomesClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x11178B8", Offset = "0x11178B8", VA = "0x11178B8", Slot = "9")]
		public override void OnNoLongerClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x11178C8", Offset = "0x11178C8", VA = "0x11178C8", Slot = "11")]
		public override void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x11178D8", Offset = "0x11178D8", VA = "0x11178D8", Slot = "13")]
		public override void OnNoLongerClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1117808", Offset = "0x1117808", VA = "0x1117808")]
		public void HighlightItem()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1117748", Offset = "0x1117748", VA = "0x1117748")]
		public void UnhighlightItem()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x11178E8", Offset = "0x11178E8", VA = "0x11178E8")]
		public GrabbableHighlightMaterial()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class GrabbableRingHelper : GrabbableEvents
	{
		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool RingOnValidPickup;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool RingOnValidRemotePickup;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float RingHelperScale;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x11178F8", Offset = "0x11178F8", VA = "0x11178F8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1117BB0", Offset = "0x1117BB0", VA = "0x1117BB0")]
		public GrabbableRingHelper()
		{
		}
	}
	[Token(Token = "0x2000075")]
	public class GrabPointTrigger : MonoBehaviour
	{
		[Token(Token = "0x2000076")]
		public enum HandMovement
		{
			[Token(Token = "0x400032B")]
			Instant,
			[Token(Token = "0x400032C")]
			Lerp,
			[Token(Token = "0x400032D")]
			None
		}

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("How to move the hand to the nearest grab point. If set to 'None', the hand model will remain at the controller.")]
		[Header("Hand Movement")]
		public HandMovement MoveInStyle;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("How to move the hand back to the grabber")]
		public HandMovement MoveOutStyle;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How to fast to move the hand if MovementStyle = 'Lerp' or 'Linear'")]
		public float HandSpeed;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true the hand model will continue to move towards the closest grab point. If false, the hand will only move towards the closest grab point once upon entering the trigger.")]
		public bool LiveUpdateNearestGrabPoint;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If specified this Grabbable will be grabbed if the user holds down the grab button while this preview is active")]
		[Header("Grabbable Options")]
		public Grabbable GrabObject;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If specified this Grabbable must be held for this component to work")]
		public Grabbable OtherGrabbableMustBeHeld;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Grab Points to move towards when the grabber is within the Trigger area.")]
		public List<GrabPoint> GrabPoints;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Grabber currentGrabber;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Grabbable dummyGrabbable;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private GrabPoint closestPoint;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Grabber grabberInTrigger;

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x1117BCC", Offset = "0x1117BCC", VA = "0x1117BCC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1117EFC", Offset = "0x1117EFC", VA = "0x1117EFC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1118384", Offset = "0x1118384", VA = "0x1118384", Slot = "4")]
		public virtual void UpdateGrabPoint(GrabPoint newPoint)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x11184FC", Offset = "0x11184FC", VA = "0x11184FC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1118740", Offset = "0x1118740", VA = "0x1118740")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1118348", Offset = "0x1118348", VA = "0x1118348")]
		private void setGrabber(Grabber theGrabber)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x1118874", Offset = "0x1118874", VA = "0x1118874", Slot = "5")]
		public virtual void ReleaseGrabber()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x1118920", Offset = "0x1118920", VA = "0x1118920")]
		public GrabPointTrigger()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class LineToTransform : MonoBehaviour
	{
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform ConnectTo;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private LineRenderer line;

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x1118938", Offset = "0x1118938", VA = "0x1118938")]
		private void Start()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x111893C", Offset = "0x111893C", VA = "0x111893C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1118940", Offset = "0x1118940", VA = "0x1118940")]
		public void UpdateLine()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1118AD8", Offset = "0x1118AD8", VA = "0x1118AD8")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1118ADC", Offset = "0x1118ADC", VA = "0x1118ADC")]
		public LineToTransform()
		{
		}
	}
	[Token(Token = "0x2000078")]
	public class LookAtTransform : MonoBehaviour
	{
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LookAt;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UseLerp;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Speed;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool UseUpdate;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool UseLateUpdate;

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1118AE4", Offset = "0x1118AE4", VA = "0x1118AE4")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1118CE4", Offset = "0x1118CE4", VA = "0x1118CE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x1118AF4", Offset = "0x1118AF4", VA = "0x1118AF4")]
		private void lookAt()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1118CF4", Offset = "0x1118CF4", VA = "0x1118CF4")]
		public LookAtTransform()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class PlaySoundOnGrab : GrabbableEvents
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip SoundToPlay;

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x1118D10", Offset = "0x1118D10", VA = "0x1118D10", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1118DD0", Offset = "0x1118DD0", VA = "0x1118DD0")]
		public PlaySoundOnGrab()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class PunctureCollider : MonoBehaviour
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Minimum distance (in meters) an object must be attached once punctured. Upon initial puncture the object will be inserted this distance from the puncture point.")]
		[Header("Puncture properties : ")]
		public float FRequiredPenetrationForce;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Minimum distance (in meters) an object must be attached once punctured. Upon initial puncture the object will be inserted this distance from the puncture point.")]
		public float MinPenetration;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Minimum distance the object can be penetrated (in meters).")]
		public float MaxPenetration;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("How far away the object must be from it's entry point to consider breaking the joint. Set to 0 if you do not want to break the joint based on distance.")]
		public float BreakDistance;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How far away the object must be from it's entry point to consider breaking the joint. Set to 0 if you do not want to break the joint based on distance.")]
		public List<Collider> PunctureColliders;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Is the object currently embedded in another object?")]
		[Header("Shown for Debug : ")]
		public bool HasPunctured;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The object currently embedded in")]
		public GameObject PuncturedObject;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How far (in meters) our object has been embedded into")]
		public float PunctureValue;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float previousPunctureValue;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Collider col;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Collider hitCollilder;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Collider[] ignoreColliders;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody rigid;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GameObject jointHelper;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody jointHelperRigid;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJoint jointHelperJoint;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable thisGrabbable;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FixedJoint fj;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float yPuncture;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float yPunctureMin;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float yPunctureMax;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float TargetDistance;

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x1118DD8", Offset = "0x1118DD8", VA = "0x1118DD8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x1118E84", Offset = "0x1118E84", VA = "0x1118E84")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x1118FF8", Offset = "0x1118FF8", VA = "0x1118FF8", Slot = "4")]
		public virtual void UpdatePunctureValue()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1119194", Offset = "0x1119194", VA = "0x1119194", Slot = "5")]
		public virtual void MovePunctureUp()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x1119244", Offset = "0x1119244", VA = "0x1119244", Slot = "6")]
		public virtual void MovePunctureDown()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x11192F4", Offset = "0x11192F4", VA = "0x11192F4", Slot = "7")]
		public virtual void CheckBreakDistance()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1119570", Offset = "0x1119570", VA = "0x1119570", Slot = "8")]
		public virtual void CheckPunctureRelease()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1119618", Offset = "0x1119618", VA = "0x1119618", Slot = "9")]
		public virtual void AdjustJointMass()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x111971C", Offset = "0x111971C", VA = "0x111971C", Slot = "10")]
		public virtual void ApplyResistanceForce()
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1119818", Offset = "0x1119818", VA = "0x1119818", Slot = "11")]
		public virtual void DoPuncture(Collider colliderHit, Vector3 connectPosition)
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1119BA8", Offset = "0x1119BA8", VA = "0x1119BA8")]
		public void SetPenetration(float penetrationAmount)
		{
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x11193B8", Offset = "0x11193B8", VA = "0x11193B8")]
		public void ReleasePuncture()
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1119CB0", Offset = "0x1119CB0", VA = "0x1119CB0", Slot = "12")]
		public virtual bool CanPunctureObject(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1119D74", Offset = "0x1119D74", VA = "0x1119D74")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1119F50", Offset = "0x1119F50", VA = "0x1119F50")]
		public PunctureCollider()
		{
		}
	}
	[Token(Token = "0x200007B")]
	public class ReturnToSnapZone : MonoBehaviour
	{
		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The SnapZone to return to if not being held")]
		public SnapZone ReturnTo;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How fast to Lerp Towards the SnapZone")]
		public float LerpSpeed;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("How long to wait before starting to Lerp the object back towards the SnapZone. In Seconds.")]
		public float ReturnDelay;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float currentDelay;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Grabbable grab;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody rigid;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool useGravityInitial;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Initiate snap if distance between the Grabbable and SnapZone is <= SnapDistance")]
		public float SnapDistance;

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1119F64", Offset = "0x1119F64", VA = "0x1119F64")]
		private void Start()
		{
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1119FF8", Offset = "0x1119FF8", VA = "0x1119FF8")]
		private void Update()
		{
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x111A11C", Offset = "0x111A11C", VA = "0x111A11C")]
		private void moveToSnapZone()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x111A3B4", Offset = "0x111A3B4", VA = "0x111A3B4")]
		public ReturnToSnapZone()
		{
		}
	}
	[Token(Token = "0x200007C")]
	public class RotateTowards : MonoBehaviour
	{
		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TargetTransform;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x111A3D4", Offset = "0x111A3D4", VA = "0x111A3D4")]
		private void Update()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x111A4BC", Offset = "0x111A4BC", VA = "0x111A4BC")]
		public RotateTowards()
		{
		}
	}
	[Token(Token = "0x200007D")]
	public class RotateWithHMD : MonoBehaviour
	{
		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to rotate along with")]
		public Transform FollowTransform;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Character Capsule to  rotate along with")]
		public CharacterController Character;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 Offset;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float RotateSpeed;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MovementSmoothing;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 velocity;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("If true this transform will be parented to the characterController. Set this to true if you want the position and rotation to align with the character controller without delay.")]
		public bool ParentToCharacter;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform originalParent;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform followTransform;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform camTransform;

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x111A4C4", Offset = "0x111A4C4", VA = "0x111A4C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x111A6A4", Offset = "0x111A6A4", VA = "0x111A6A4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x111A6A8", Offset = "0x111A6A8", VA = "0x111A6A8")]
		private void UpdatePosition()
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x111AA9C", Offset = "0x111AA9C", VA = "0x111AA9C")]
		public RotateWithHMD()
		{
		}
	}
	[Token(Token = "0x200007E")]
	public class ScaleBetweenPoints : MonoBehaviour
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Begin;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform End;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool DoUpdate;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool DoLateUpdate;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool LookAtTarget;

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x111AB08", Offset = "0x111AB08", VA = "0x111AB08")]
		private void Update()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x111AD0C", Offset = "0x111AD0C", VA = "0x111AD0C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x111AB18", Offset = "0x111AB18", VA = "0x111AB18")]
		private void doScale()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x111AD1C", Offset = "0x111AD1C", VA = "0x111AD1C")]
		public ScaleBetweenPoints()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class ScreenFader : MonoBehaviour
	{
		[Token(Token = "0x2000080")]
		[CompilerGenerated]
		private sealed class <fadeOutWithDelay>d__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delaySeconds;

			[Token(Token = "0x4000373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ScreenFader <>4__this;

			[Token(Token = "0x1700001F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000225")]
				[Address(RVA = "0x111B850", Offset = "0x111B850", VA = "0x111B850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000020")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000227")]
				[Address(RVA = "0x111B898", Offset = "0x111B898", VA = "0x111B898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000222")]
			[Address(RVA = "0x111B35C", Offset = "0x111B35C", VA = "0x111B35C")]
			[DebuggerHidden]
			public <fadeOutWithDelay>d__17(int <>1__state)
			{
			}

			[Token(Token = "0x6000223")]
			[Address(RVA = "0x111B798", Offset = "0x111B798", VA = "0x111B798", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000224")]
			[Address(RVA = "0x111B79C", Offset = "0x111B79C", VA = "0x111B79C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000226")]
			[Address(RVA = "0x111B858", Offset = "0x111B858", VA = "0x111B858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000081")]
		[CompilerGenerated]
		private sealed class <doFade>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float alphaFrom;

			[Token(Token = "0x4000377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ScreenFader <>4__this;

			[Token(Token = "0x4000378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float alphaTo;

			[Token(Token = "0x4000379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float <alpha>5__2;

			[Token(Token = "0x17000021")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600022B")]
				[Address(RVA = "0x111BA34", Offset = "0x111BA34", VA = "0x111BA34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000022")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600022D")]
				[Address(RVA = "0x111BA7C", Offset = "0x111BA7C", VA = "0x111BA7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000228")]
			[Address(RVA = "0x111B5D8", Offset = "0x111B5D8", VA = "0x111B5D8")]
			[DebuggerHidden]
			public <doFade>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000229")]
			[Address(RVA = "0x111B8A0", Offset = "0x111B8A0", VA = "0x111B8A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600022A")]
			[Address(RVA = "0x111B8A4", Offset = "0x111B8A4", VA = "0x111B8A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600022C")]
			[Address(RVA = "0x111BA3C", Offset = "0x111BA3C", VA = "0x111BA3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Should the screen fade in when a new level is loaded")]
		public bool FadeOnSceneLoaded;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Color of the fade. Alpha will be modified when fading in / out")]
		public Color FadeColor;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How fast to fade in / out")]
		public float FadeInSpeed;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeOutSpeed;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Wait X seconds before fading scene in")]
		public float SceneFadeInDelay;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private GameObject fadeObject;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RectTransform fadeObjectRect;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Canvas fadeCanvas;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CanvasGroup canvasGroup;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Image fadeImage;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IEnumerator fadeRoutine;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private string faderName;

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x111AD2C", Offset = "0x111AD2C", VA = "0x111AD2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x111AD38", Offset = "0x111AD38", VA = "0x111AD38", Slot = "4")]
		protected virtual void initialize()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x111B0F4", Offset = "0x111B0F4", VA = "0x111B0F4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x111B198", Offset = "0x111B198", VA = "0x111B198")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x111B23C", Offset = "0x111B23C", VA = "0x111B23C")]
		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x111B2E4", Offset = "0x111B2E4", VA = "0x111B2E4")]
		[IteratorStateMachine(typeof(<fadeOutWithDelay>d__17))]
		private IEnumerator fadeOutWithDelay(float delaySeconds)
		{
			return null;
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x111B384", Offset = "0x111B384", VA = "0x111B384", Slot = "5")]
		public virtual void DoFadeIn()
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x111B4BC", Offset = "0x111B4BC", VA = "0x111B4BC", Slot = "6")]
		public virtual void DoFadeOut()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x111B510", Offset = "0x111B510", VA = "0x111B510", Slot = "7")]
		public virtual void SetFadeLevel(float fadeLevel)
		{
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x111B43C", Offset = "0x111B43C", VA = "0x111B43C")]
		[IteratorStateMachine(typeof(<doFade>d__21))]
		private IEnumerator doFade(float alphaFrom, float alphaTo)
		{
			return null;
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x111B600", Offset = "0x111B600", VA = "0x111B600", Slot = "8")]
		protected virtual void updateImageAlpha(float alphaValue)
		{
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x111B720", Offset = "0x111B720", VA = "0x111B720")]
		public ScreenFader()
		{
		}
	}
	[Token(Token = "0x2000082")]
	public class SnapZoneRingHelper : MonoBehaviour
	{
		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SnapZone Snap;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color RestingColor;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Color ValidSnapColor;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float RestingScale;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float ValidSnapScale;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CanvasScaler ringCanvas;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Text ringText;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private GrabbablesInTrigger nearbyGrabbables;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool validSnap;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float ScaleSpeed;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x111BA84", Offset = "0x111BA84", VA = "0x111BA84")]
		private void Start()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x111BB30", Offset = "0x111BB30", VA = "0x111BB30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x111BC04", Offset = "0x111BC04", VA = "0x111BC04")]
		private bool checkIsValidSnap()
		{
			return default(bool);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x111BCDC", Offset = "0x111BCDC", VA = "0x111BCDC")]
		public SnapZoneRingHelper()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public class Tooltip : MonoBehaviour
	{
		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 TipOffset;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool UseWorldYAxis;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MaxViewDistance;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform childTransform;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform DrawLineTo;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LineToTransform lineTo;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform lookAt;

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x111BD08", Offset = "0x111BD08", VA = "0x111BD08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x111BE00", Offset = "0x111BE00", VA = "0x111BE00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x111C138", Offset = "0x111C138", VA = "0x111C138")]
		public Tooltip()
		{
		}
	}
	[Token(Token = "0x2000084")]
	public class VelocityTracker : MonoBehaviour
	{
		[Token(Token = "0x2000085")]
		public enum VelocityTrackingType
		{
			[Token(Token = "0x4000398")]
			Device,
			[Token(Token = "0x4000399")]
			PerFrame
		}

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This setting determines how retrieve the velocity. If 'Device' is selected and ControllerHand is specified, then velocity will be retrieved from the connected physical controller. Otherwise velocity is calculated on a per frame basis.")]
		public VelocityTrackingType trackingType;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If ControllerHand is specified as Left or Right then velocity will attempt to be retrieved from the physical controller. If None, velocity will be calculated per frame.")]
		public ControllerHand controllerHand;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How many frames to use when averaging retrieving velocity using GetAveragedVelocity / GetAveragedAngularVelocity")]
		public float AverageVelocityCount;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 _velocity;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 _angularVelocity;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 _lastPosition;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion _lastRotation;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<Vector3> previousVelocities;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Vector3> previousAngularVelocities;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float angle;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 axis;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private GameObject playSpace;

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x111C160", Offset = "0x111C160", VA = "0x111C160")]
		private void Start()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x111C1B0", Offset = "0x111C1B0", VA = "0x111C1B0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x111C210", Offset = "0x111C210", VA = "0x111C210", Slot = "4")]
		public virtual void UpdateVelocities()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x111C238", Offset = "0x111C238", VA = "0x111C238", Slot = "5")]
		public virtual void UpdateVelocity()
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x111C394", Offset = "0x111C394", VA = "0x111C394", Slot = "6")]
		public virtual void UpdateAngularVelocity()
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x111C5C0", Offset = "0x111C5C0", VA = "0x111C5C0", Slot = "7")]
		public virtual Vector3 GetVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x111C74C", Offset = "0x111C74C", VA = "0x111C74C", Slot = "8")]
		public virtual Vector3 GetAveragedVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x111C75C", Offset = "0x111C75C", VA = "0x111C75C", Slot = "9")]
		public virtual Vector3 GetAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x111C768", Offset = "0x111C768", VA = "0x111C768", Slot = "10")]
		public virtual Vector3 GetAveragedAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x111C778", Offset = "0x111C778", VA = "0x111C778", Slot = "11")]
		public virtual Vector3 GetAveragedVector(List<Vector3> vectors)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x111C880", Offset = "0x111C880", VA = "0x111C880")]
		public VelocityTracker()
		{
		}
	}
	[Token(Token = "0x2000086")]
	public enum LocomotionType
	{
		[Token(Token = "0x400039B")]
		Teleport,
		[Token(Token = "0x400039C")]
		SmoothLocomotion,
		[Token(Token = "0x400039D")]
		None
	}
	[Token(Token = "0x2000087")]
	public class BNGPlayerController : MonoBehaviour
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Camera Options : ")]
		[Tooltip("If true the CharacterController will move along with the HMD, as long as there are no obstacle's in the way")]
		public bool MoveCharacterWithCamera;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[Tooltip("If true the CharacterController will rotate it's Y angle to match the HMD's Y angle")]
		public bool RotateCharacterWithCamera;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Transform Setup ")]
		[Tooltip("The TrackingSpace represents your tracking space origin.")]
		public Transform TrackingSpace;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The CameraRig is a Transform that is used to offset the main camera. The main camera should be parented to this.")]
		public Transform CameraRig;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The CenterEyeAnchor is typically the Transform that contains your Main Camera")]
		public Transform CenterEyeAnchor;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Ground checks : ")]
		[Tooltip("Raycast against these layers to check if player is grounded")]
		public LayerMask GroundedLayers;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("How far off the ground the player currently is. 0 = Grounded, 1 = 1 Meter in the air.")]
		public float DistanceFromGround;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("DistanceFromGround will subtract this value when determining distance from ground")]
		public float DistanceFromGroundOffset;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Player Capsule Settings : ")]
		[Tooltip("Minimum Height our Player's capsule collider can be (in meters)")]
		public float MinimumCapsuleHeight;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Maximum Height our Player's capsule collider can be (in meters)")]
		public float MaximumCapsuleHeight;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[HideInInspector]
		public float LastTeleportTime;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Player Y Offset : ")]
		[Tooltip("Offset the height of the CharacterController by this amount")]
		public float CharacterControllerYOffset;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[HideInInspector]
		public float CameraHeight;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("If true the Camera will be offset by ElevateCameraHeight if no HMD is active or connected. This prevents the camera from falling to the floor and can allow you to use keyboard controls.")]
		[Header("Misc : ")]
		public bool ElevateCameraIfNoHMDPresent;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("How high (in meters) to elevate the player camera if no HMD is present and ElevateCameraIfNoHMDPresent is true. 1.65 = about 5.4' tall. ")]
		public float ElevateCameraHeight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Minimum Y position our player is allowed to go. Useful for floating point precision and making sure player didn't fall through the map.")]
		public float MinElevation;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float MaxElevation;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public float LastPlayerMoveTime;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private CharacterController characterController;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody playerRigid;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private CapsuleCollider playerCapsule;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PlayerClimbing playerClimbing;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool isClimbing;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		private bool wasClimbing;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public RaycastHit groundHit;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private RaycastHit hit;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Transform mainCamera;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 _initialPosition;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float SphereColliderRadius;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Vector3 moveTest;

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x111C92C", Offset = "0x111C92C", VA = "0x111C92C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x111CAF0", Offset = "0x111CAF0", VA = "0x111CAF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x111CD78", Offset = "0x111CD78", VA = "0x111CD78")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x111CDA0", Offset = "0x111CDA0", VA = "0x111CDA0", Slot = "4")]
		public virtual void CheckPlayerElevationRespawn()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x111CFB0", Offset = "0x111CFB0", VA = "0x111CFB0", Slot = "5")]
		public virtual void UpdateDistanceFromGround()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x111D618", Offset = "0x111D618", VA = "0x111D618", Slot = "6")]
		public virtual void RotateTrackingSpaceToCamera()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x111D7D8", Offset = "0x111D7D8", VA = "0x111D7D8", Slot = "7")]
		public virtual void UpdateCameraRigPosition()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x111D9C4", Offset = "0x111D9C4", VA = "0x111D9C4", Slot = "8")]
		public virtual void UpdateCharacterHeight()
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x111DC3C", Offset = "0x111DC3C", VA = "0x111DC3C", Slot = "9")]
		public virtual void UpdateCameraHeight()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x111DCB8", Offset = "0x111DCB8", VA = "0x111DCB8", Slot = "10")]
		public virtual void CheckCharacterCollisionMove()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x111DF44", Offset = "0x111DF44", VA = "0x111DF44", Slot = "11")]
		public virtual void CheckRigidbodyCapsuleMove(Vector3 movePosition)
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x111E0B0", Offset = "0x111E0B0", VA = "0x111E0B0")]
		public bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x111E14C", Offset = "0x111E14C", VA = "0x111E14C", Slot = "12")]
		public virtual void OnClimbingChange()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x111E16C", Offset = "0x111E16C", VA = "0x111E16C")]
		public BNGPlayerController()
		{
		}
	}
	[Token(Token = "0x2000088")]
	public class Button : MonoBehaviour
	{
		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Local Y position of the button when it is pushed all the way down. Local Y position will never be less than this.")]
		public float MinLocalY;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The Local Y position of the button when it is not being pushed. Local Y position will never be greater than this.")]
		public float MaxLocalY;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How far away from MinLocalY / MaxLocalY to be considered a click")]
		public float ClickTolerance;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true the button can be pressed by physical object by utiizing a Spring Joint. Set to false if you don't need / want physics interactions, or are using this on a moving platform.")]
		public bool AllowPhysicsForces;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private List<Grabber> grabbers;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<UITrigger> uiTriggers;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private SpringJoint joint;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool clickingDown;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AudioClip ButtonClick;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip ButtonClickUp;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent onButtonDown;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public UnityEvent onButtonUp;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody rigid;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float ButtonSpeed;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float SpringForce;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 buttonDownPosition;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 buttonUpPosition;

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x111E1C0", Offset = "0x111E1C0", VA = "0x111E1C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x111E2E4", Offset = "0x111E2E4", VA = "0x111E2E4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x111E6D8", Offset = "0x111E6D8", VA = "0x111E6D8", Slot = "4")]
		public virtual Vector3 GetButtonUpPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x111E730", Offset = "0x111E730", VA = "0x111E730", Slot = "5")]
		public virtual Vector3 GetButtonDownPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x111E788", Offset = "0x111E788", VA = "0x111E788", Slot = "6")]
		public virtual void OnButtonDown()
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x111E850", Offset = "0x111E850", VA = "0x111E850", Slot = "7")]
		public virtual void OnButtonUp()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x111E918", Offset = "0x111E918", VA = "0x111E918")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x111EBD4", Offset = "0x111EBD4", VA = "0x111EBD4")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x111ED74", Offset = "0x111ED74", VA = "0x111ED74")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x111EF40", Offset = "0x111EF40", VA = "0x111EF40")]
		public Button()
		{
		}
	}
	[Token(Token = "0x2000089")]
	public class ControllerModelSelector : MonoBehaviour
	{
		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int disableIndex;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool isQuitting;

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1274F08", Offset = "0x1274F08", VA = "0x1274F08")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1275084", Offset = "0x1275084", VA = "0x1275084")]
		public void UpdateControllerModel()
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1275344", Offset = "0x1275344", VA = "0x1275344")]
		public void EnableChildController(int childIndex)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x12753D4", Offset = "0x12753D4", VA = "0x12753D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1275564", Offset = "0x1275564", VA = "0x1275564")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1275570", Offset = "0x1275570", VA = "0x1275570")]
		public ControllerModelSelector()
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class Grabbable : MonoBehaviour
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool BeingHeld;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Grabber> validGrabbers;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected List<Grabber> heldByGrabbers;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected bool wasKinematic;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		protected bool usedGravity;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected CollisionDetectionMode initialCollisionMode;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected RigidbodyInterpolation initialInterpolationMode;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected bool remoteGrabbing;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Configure which button is used to initiate the grab")]
		[Header("Grab Settings")]
		public GrabButton GrabButton;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("'Inherit' will inherit this setting from the Grabber. 'Hold' requires the user to hold the GrabButton down. 'Toggle' will drop / release the Grabbable on button activation.")]
		public HoldType Grabtype;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Kinematic Physics locks the object in place on the hand / grabber. Physics Joint and Velocity types allow collisions with the environment.")]
		public GrabPhysics GrabPhysics;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Snap to a location or grab anywhere on the object")]
		public GrabType GrabMechanic;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How fast to Lerp the object to the hand")]
		public float GrabSpeed;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Can the object be picked up from far away. Must be within RemoteGrabber Trigger")]
		[Header("Remote Grab")]
		public bool RemoteGrabbable;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public RemoteGrabMovement RemoteGrabMechanic;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Max Distance Object can be Remote Grabbed. Not applicable if RemoteGrabbable is false")]
		public float RemoteGrabDistance;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Throwing")]
		[Tooltip("Multiply controller's velocity times this when throwing")]
		public float ThrowForceMultiplier;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Multiply controller's angular velocity times this when throwing")]
		public float ThrowForceMultiplierAngular;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Drop the item if object's center travels this far from the Grabber's Center (in meters). Set to 0 to disable distance break.")]
		public float BreakDistance;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Enabling this will hide the Transform specified in the Grabber's HandGraphics property")]
		[Header("Hand Options")]
		public bool HideHandGraphics;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
		[Tooltip("Parent this object to the hands for instantaneous movement. Object will travel 1:1 with the controller but may have trouble detecting fast moving collisions.")]
		public bool ParentToHands;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E")]
		[Tooltip("If true, the hand model will be attached to the grabbed object. This separates it from a 1:1 match with the controller, but may look more realistic.")]
		public bool ParentHandModel;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F")]
		[Tooltip("If true, the hand model will snap to the nearest GrabPoint. Otherwise the hand model will stay with the Grabber.")]
		public bool SnapHandModel;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Misc")]
		[Tooltip("Set to false to disable dropping. If false, will be permanently attached to whatever grabs this.")]
		public bool CanBeDropped;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[Tooltip("Can this object be snapped to snap zones? Set to false if you never want this to be snappable. Further filtering can be done on the SnapZones")]
		public bool CanBeSnappedToSnapZone;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[Tooltip("If true, the object will always have kinematic disabled when dropped, even if it was initially kinematic.")]
		public bool ForceDisableKinematicOnDrop;

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		[Tooltip("If true, the object will instantly position / rotate to the grabber instead of using velocity / force. This will only happen if no collisions have recently occurred. When using this method, the Grabbable's Rigidbody willbe instantly rotated / moved, taking in to account the interpolation settings. May clip through objects if moving fast enough.")]
		public bool InstantMovement;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, all child colliders will be considered Grabbable. If false, you will need to add the 'GrabbableChild' component to any child colliders that you wish to also be considered grabbable.")]
		public bool MakeChildCollidersGrabbable;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Default Hand Pose")]
		[Tooltip("A hand controller can read this value to determine how to animate when grabbing this object. 'AnimatorID' = specify an Animator ID to be set on the hand animator after grabbing this object. 'HandPose' = use a HandPose scriptable object. 'AutoPoseOnce' = DO an auto pose one time upon grabbing this object. 'AutoPoseContinuous' = Keep running attempting an autopose while grabbing this item.")]
		public HandPoseType handPoseType;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		protected HandPoseType initialHandPoseType;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("If HandPoseType = 'HandPose', this HandPose object will be applied to the hand on pickup")]
		public HandPose SelectedHandPose;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		protected HandPose initialHandPose;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("This HandPose Id will be passed to the Hand Animator when equipped. You can add new hand poses in the HandPoseDefinitions.cs file.")]
		public HandPoseId CustomHandPose;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected HandPoseId initialHandPoseId;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Header("Two-Handed Grab Behavior")]
		[Tooltip("What to do if another grabber grabs this while equipped.")]
		public OtherGrabBehavior SecondaryGrabBehavior;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Tooltip("How to behave when two hands are grabbing this object. LookAt = Have the primary Grabber 'LookAt' the secondary grabber. For example, holding a rifle in the right controller will have it rotate towards the left controller. AveragePositionRotation = Use a point and rotation in space that is half-way between both grabbers.")]
		public TwoHandedPositionType TwoHandedPosition;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("How far to lerp between grabber positions. For example, 0.5 = halfway between the primary and secondary grabber. 0 = use the primary grabber's position, 1 = use the secondary grabber's position.")]
		[Range(0f, 1f)]
		public float TwoHandedPostionLerpAmount;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Tooltip("How to behave when two hands are grabbing this object. LookAt = Have the primary Grabber 'LookAt' the secondary grabber. For example, holding a rifle in the right controller will have it rotate towards the left controller. AveragePositionRotation = Use a point and rotation in space that is half-way between both grabbers.")]
		public TwoHandedRotationType TwoHandedRotation;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("How far to lerp / slerp between grabber rotation. For example, 0.5 = halfway between the primary and secondary grabber. 0 = use the primary grabber's rotation, 1 = use the secondary grabber's position.")]
		[Range(0f, 1f)]
		public float TwoHandedRotationLerpAmount;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Tooltip("How to repond if you are holding an object with two hands, and then drop the primary grabber. For example, you may want to drop the object, transfer it to the second hand, or do nothing at all.")]
		public TwoHandedDropMechanic TwoHandedDropBehavior;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Which vector to use when TwoHandedRotation = LookAtSecondary. Ex : Horizontal = A rifle type setup where you want to aim down the sites; Vertical = A melee type setup where the object is vertical")]
		public TwoHandedLookDirection TwoHandedLookVector;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Tooltip("How quickly to Lerp towards the SecondaryGrabbable if TwoHandedGrabBehavior = LookAt")]
		public float SecondHandLookSpeed;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("If specified, this object will be used as a secondary grabbable instead of relying on grab points on this object. If 'TwoHandedGrabBehavior' is specified as LookAt, this is the object the grabber will be rotated towards. If 'TwoHandedGrabBehavior' is specified as AveragePositionRotation, this is the object the grabber use to calculate position.")]
		[Header("Secondary Grabbale Object")]
		public Grabbable SecondaryGrabbable;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Header("Grab Restrictions")]
		[Tooltip("The Grabbable can only be grabbed if this grabbable is being held. Example : If you only want a weapon part to be grabbable if the weapon itself is being held.")]
		public Grabbable OtherGrabbableMustBeGrabbed;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Physics Joint Settings")]
		[Tooltip("A higher Spring Force will make the Grabbable more rigid")]
		public float CollisionSpring;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("How much Slerp Force to apply to the joint when something is in contact with the grabbable")]
		public float CollisionSlerp;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("How to restrict the Configurable Joint's xMotion when colliding with an object. Position can be free, completely locked, or limited.")]
		public ConfigurableJointMotion CollisionLinearMotionX;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("How to restrict the Configurable Joint's yMotion when colliding with an object. Position can be free, completely locked, or limited.")]
		public ConfigurableJointMotion CollisionLinearMotionY;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("How to restrict the Configurable Joint's zMotion when colliding with an object. Position can be free, completely locked, or limited.")]
		public ConfigurableJointMotion CollisionLinearMotionZ;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Tooltip("Restrict the rotation around the X axes to be Free, completely Locked, or Limited when colliding with an object.")]
		public ConfigurableJointMotion CollisionAngularMotionX;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("Restrict the rotation around the Y axes to be Free, completely Locked, or Limited when colliding with an object.")]
		public ConfigurableJointMotion CollisionAngularMotionY;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Tooltip("Restrict the rotation around Z axes to be Free, completely Locked, or Limited when colliding with an object.")]
		public ConfigurableJointMotion CollisionAngularMotionZ;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("If true, the object's velocity will be adjusted to match the grabber. This is in addition to any forces added by the configurable joint.")]
		public bool ApplyCorrectiveForce;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Header("Velocity Grab Settings")]
		public float MoveVelocityForce;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float MoveAngularVelocityForce;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[HideInInspector]
		public float LastGrabTime;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[HideInInspector]
		public float LastDropTime;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[HideInInspector]
		public bool AddControllerVelocityOnDrop;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private float journeyLength;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Header("Shown for Debug : ")]
		public List<Collider> collisions;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected Transform primaryGrabOffset;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		protected Transform secondaryGrabOffset;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[HideInInspector]
		public GrabPoint ActiveGrabPoint;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[HideInInspector]
		public Vector3 SecondaryLookOffset;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		[HideInInspector]
		public Transform SecondaryLookAtTransform;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[HideInInspector]
		public Transform LocalOffsetTransform;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Transform _grabTransform;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Transform _grabTransformSecondary;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		[Tooltip("If Grab Mechanic is set to Snap, the closest GrabPoint will be used. Add a SnapPoint Component to a GrabPoint to specify custom hand poses and rotation.")]
		[Header("Grab Points")]
		public List<Transform> GrabPoints;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private bool _canBeMoved;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		protected Transform originalParent;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		protected InputBridge input;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		protected ConfigurableJoint connectedJoint;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		protected Vector3 previousPosition;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		protected float lastItemTeleportTime;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected bool recentlyTeleported;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A9")]
		[HideInInspector]
		public bool UseCustomInspector;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private BNGPlayerController _player;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		protected Collider col;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		protected Rigidbody rigid;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		protected Grabber flyingTo;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		protected List<GrabbableEvents> events;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		protected bool didParentHands;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D9")]
		private bool initiatedFlick;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private float flickStartVelocity;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float FlickSpeed;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		public float lastFlickTime;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		public float FlickForce;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private float angle;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Vector3 axis;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		private Vector3 angularTarget;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Vector3 angularMovement;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		private bool subscribedToEvents;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x215")]
		private bool grabbableIsLocked;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Transform _priorParent;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private Vector3 _priorLocalOffsetPosition;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private Quaternion _priorLocalOffsetRotation;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Grabber _priorPrimaryGrabber;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private bool lockPos;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x249")]
		private bool lockRot;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24C")]
		private int lockRequests;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private bool quitting;

		[Token(Token = "0x17000023")]
		public bool BeingHeldWithTwoHands
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x1275578", Offset = "0x1275578", VA = "0x1275578")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000024")]
		public List<Grabber> HeldByGrabbers
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x1275634", Offset = "0x1275634", VA = "0x1275634")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000025")]
		public bool RemoteGrabbing
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x127563C", Offset = "0x127563C", VA = "0x127563C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000026")]
		public Vector3 OriginalScale
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x1275644", Offset = "0x1275644", VA = "0x1275644")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x1275654", Offset = "0x1275654", VA = "0x1275654")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000027")]
		public float lastCollisionSeconds
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x1275664", Offset = "0x1275664", VA = "0x1275664")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x127566C", Offset = "0x127566C", VA = "0x127566C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public float lastNoCollisionSeconds
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x1275674", Offset = "0x1275674", VA = "0x1275674")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x127567C", Offset = "0x127567C", VA = "0x127567C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool RecentlyCollided
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x1275684", Offset = "0x1275684", VA = "0x1275684")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public float requestSpringTime
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x12756FC", Offset = "0x12756FC", VA = "0x12756FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x1275704", Offset = "0x1275704", VA = "0x1275704")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		private Vector3 grabPosition
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x127570C", Offset = "0x127570C", VA = "0x127570C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002C")]
		[HideInInspector]
		public Vector3 GrabPositionOffset
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x1275794", Offset = "0x1275794", VA = "0x1275794")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002D")]
		[HideInInspector]
		public Vector3 GrabRotationOffset
		{
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x1275854", Offset = "0x1275854", VA = "0x1275854")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		public Transform grabTransform
		{
			[Token(Token = "0x600026D")]
			[Address(RVA = "0x1275914", Offset = "0x1275914", VA = "0x1275914")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		public Transform grabTransformSecondary
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1275A58", Offset = "0x1275A58", VA = "0x1275A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		public bool CanBeMoved
		{
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1275BB0", Offset = "0x1275BB0", VA = "0x1275BB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		protected BNGPlayerController player
		{
			[Token(Token = "0x6000270")]
			[Address(RVA = "0x1275BB8", Offset = "0x1275BB8", VA = "0x1275BB8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		public Grabber FlyingToGrabber
		{
			[Token(Token = "0x6000271")]
			[Address(RVA = "0x1275BC8", Offset = "0x1275BC8", VA = "0x1275BC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		public bool DidParentHands
		{
			[Token(Token = "0x6000272")]
			[Address(RVA = "0x1275BD0", Offset = "0x1275BD0", VA = "0x1275BD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1275BD8", Offset = "0x1275BD8", VA = "0x1275BD8")]
		protected void Awake()
		{
		}

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x12761C4", Offset = "0x12761C4", VA = "0x12761C4", Slot = "4")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x12775F0", Offset = "0x12775F0", VA = "0x12775F0", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1277714", Offset = "0x1277714", VA = "0x1277714", Slot = "6")]
		public virtual Vector3 GetGrabberWithGrabPointOffset(Grabber grabber, Transform grabPoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1277884", Offset = "0x1277884", VA = "0x1277884", Slot = "7")]
		public virtual Quaternion GetGrabberWithOffsetWorldRotation(Grabber grabber)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1276F8C", Offset = "0x1276F8C", VA = "0x1276F8C")]
		protected void positionHandGraphics(Grabber g)
		{
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1277944", Offset = "0x1277944", VA = "0x1277944", Slot = "8")]
		public virtual bool IsGrabbable()
		{
			return default(bool);
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1277A1C", Offset = "0x1277A1C", VA = "0x1277A1C", Slot = "9")]
		public virtual void UpdateRemoteGrab()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1277A60", Offset = "0x1277A60", VA = "0x1277A60", Slot = "10")]
		public virtual void CheckRemoteGrabLinear()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1278348", Offset = "0x1278348", VA = "0x1278348", Slot = "11")]
		public virtual void CheckRemoteGrabVelocity()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1278EA0", Offset = "0x1278EA0", VA = "0x1278EA0", Slot = "12")]
		public virtual void InitiateFlick()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1279054", Offset = "0x1279054", VA = "0x1279054")]
		public Vector3 GetVelocityToHitTargetByTime(Vector3 startPosition, Vector3 targetPosition, Vector3 gravityBase, float timeToTarget)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x12794F4", Offset = "0x12794F4", VA = "0x12794F4", Slot = "13")]
		public virtual void CheckRemoteGrabFlick()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x12796CC", Offset = "0x12796CC", VA = "0x12796CC", Slot = "14")]
		public virtual void UpdateFixedJoints()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1279A48", Offset = "0x1279A48", VA = "0x1279A48", Slot = "15")]
		public virtual void UpdatePhysicsJoints()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1279E98", Offset = "0x1279E98", VA = "0x1279E98")]
		private void setPositionSpring(float spring, float damper)
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x127A024", Offset = "0x127A024", VA = "0x127A024")]
		private void setSlerpDrive(float slerp, float damper)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x127A0FC", Offset = "0x127A0FC", VA = "0x127A0FC", Slot = "16")]
		public virtual Vector3 GetGrabberVector3(Grabber grabber, bool isSecondary)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x127A150", Offset = "0x127A150", VA = "0x127A150", Slot = "17")]
		public virtual Quaternion GetGrabberQuaternion(Grabber grabber, bool isSecondary)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1279788", Offset = "0x1279788", VA = "0x1279788")]
		private void moveWithVelocity()
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x127A338", Offset = "0x127A338", VA = "0x127A338")]
		private void rotateWithVelocity()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x127A190", Offset = "0x127A190", VA = "0x127A190")]
		public Vector3 GetGrabbersAveragedPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1278798", Offset = "0x1278798", VA = "0x1278798")]
		public Quaternion GetGrabbersAveragedRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x127A818", Offset = "0x127A818", VA = "0x127A818", Slot = "18")]
		public virtual void UpdateKinematicPhysics()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x127AE7C", Offset = "0x127AE7C", VA = "0x127AE7C", Slot = "19")]
		public virtual void UpdateVelocityPhysics()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1276CD4", Offset = "0x1276CD4", VA = "0x1276CD4")]
		private void checkParentHands(Grabber g)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x12760D8", Offset = "0x12760D8", VA = "0x12760D8")]
		private bool canBeMoved()
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1277080", Offset = "0x1277080", VA = "0x1277080")]
		private void checkSecondaryLook()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x127ACB4", Offset = "0x127ACB4", VA = "0x127ACB4")]
		private void rotateGrabber(bool lerp = false)
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x127B1A8", Offset = "0x127B1A8", VA = "0x127B1A8")]
		public Transform GetGrabPoint()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x127B1B0", Offset = "0x127B1B0", VA = "0x127B1B0", Slot = "20")]
		public virtual void GrabItem(Grabber grabbedBy)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x127BC14", Offset = "0x127BC14", VA = "0x127BC14", Slot = "21")]
		protected virtual void setupConfigJointGrab(Grabber grabbedBy, GrabType grabType)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x127BE00", Offset = "0x127BE00", VA = "0x127BE00", Slot = "22")]
		protected virtual void setupFixedJointGrab(Grabber grabbedBy, GrabType grabType)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x127BF10", Offset = "0x127BF10", VA = "0x127BF10", Slot = "23")]
		protected virtual void setupKinematicGrab(Grabber grabbedBy, GrabType grabType)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x127C01C", Offset = "0x127C01C", VA = "0x127C01C", Slot = "24")]
		protected virtual void setupVelocityGrab(Grabber grabbedBy, GrabType grabType)
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x127C068", Offset = "0x127C068", VA = "0x127C068", Slot = "25")]
		public virtual void GrabRemoteItem(Grabber grabbedBy)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x127C168", Offset = "0x127C168", VA = "0x127C168", Slot = "26")]
		public virtual void ResetGrabbing()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x127C230", Offset = "0x127C230", VA = "0x127C230", Slot = "27")]
		public virtual void DropItem(Grabber droppedBy, bool resetVelocity, bool resetParent)
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x127B0C4", Offset = "0x127B0C4", VA = "0x127B0C4")]
		private void clearLookAtTransform()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x12767C0", Offset = "0x12767C0", VA = "0x12767C0")]
		private void callEvents(Grabber g)
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x127CCF4", Offset = "0x127CCF4", VA = "0x127CCF4", Slot = "28")]
		public virtual void DropItem(Grabber droppedBy)
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x127CD0C", Offset = "0x127CD0C", VA = "0x127CD0C", Slot = "29")]
		public virtual void DropItem(bool resetVelocity, bool resetParent)
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x127CD5C", Offset = "0x127CD5C", VA = "0x127CD5C")]
		public void ResetScale()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x127C9F8", Offset = "0x127C9F8", VA = "0x127C9F8")]
		public void ResetParent()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x127CD8C", Offset = "0x127CD8C", VA = "0x127CD8C")]
		public void UpdateOriginalParent(Transform newOriginalParent)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x127CD94", Offset = "0x127CD94", VA = "0x127CD94")]
		public void UpdateOriginalParent()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x127CDC0", Offset = "0x127CDC0", VA = "0x127CDC0")]
		public ControllerHand GetControllerHand(Grabber g)
		{
			return default(ControllerHand);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x127CE38", Offset = "0x127CE38", VA = "0x127CE38", Slot = "30")]
		public virtual Grabber GetPrimaryGrabber()
		{
			return null;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x127CF6C", Offset = "0x127CF6C", VA = "0x127CF6C", Slot = "31")]
		public virtual Grabber GetClosestGrabber()
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x127D118", Offset = "0x127D118", VA = "0x127D118", Slot = "32")]
		public virtual Transform GetClosestGrabPoint(Grabber grabber)
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x127D448", Offset = "0x127D448", VA = "0x127D448", Slot = "33")]
		public virtual void Release(Vector3 velocity, Vector3 angularVelocity)
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x127D588", Offset = "0x127D588", VA = "0x127D588", Slot = "34")]
		public virtual bool IsValidCollision(Collision collision)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x127D5C0", Offset = "0x127D5C0", VA = "0x127D5C0", Slot = "35")]
		public virtual bool IsValidCollision(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x127D758", Offset = "0x127D758", VA = "0x127D758", Slot = "36")]
		public virtual void parentHandGraphics(Grabber g)
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x127BD1C", Offset = "0x127BD1C", VA = "0x127BD1C")]
		private void setupConfigJoint(Grabber g)
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x127CA20", Offset = "0x127CA20", VA = "0x127CA20")]
		private void removeConfigJoint()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x127BAF8", Offset = "0x127BAF8", VA = "0x127BAF8")]
		private void addGrabber(Grabber g)
		{
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x127CAF4", Offset = "0x127CAF4", VA = "0x127CAF4")]
		private void removeGrabber(Grabber g)
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x127819C", Offset = "0x127819C", VA = "0x127819C")]
		private void movePosition(Vector3 worldPosition)
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x127826C", Offset = "0x127826C", VA = "0x127826C")]
		private void moveRotation(Quaternion worldRotation)
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x127AC74", Offset = "0x127AC74", VA = "0x127AC74")]
		protected Vector3 getRemotePosition(Grabber toGrabber)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x1277F68", Offset = "0x1277F68", VA = "0x1277F68")]
		protected Quaternion getRemoteRotation(Grabber grabber)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x127664C", Offset = "0x127664C", VA = "0x127664C")]
		private void filterCollisions()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x127D84C", Offset = "0x127D84C", VA = "0x127D84C", Slot = "37")]
		public virtual BNGPlayerController GetBNGPlayerController()
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x127D970", Offset = "0x127D970", VA = "0x127D970", Slot = "38")]
		public virtual void RequestSpringTime(float seconds)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x127D9A8", Offset = "0x127D9A8", VA = "0x127D9A8", Slot = "39")]
		public virtual void AddValidGrabber(Grabber grabber)
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x127DAC4", Offset = "0x127DAC4", VA = "0x127DAC4", Slot = "40")]
		public virtual void RemoveValidGrabber(Grabber grabber)
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x127DB54", Offset = "0x127DB54", VA = "0x127DB54", Slot = "41")]
		public virtual void SubscribeToMoveEvents()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x127DDE4", Offset = "0x127DDE4", VA = "0x127DDE4", Slot = "42")]
		public virtual void UnsubscribeFromMoveEvents()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x127E060", Offset = "0x127E060", VA = "0x127E060", Slot = "43")]
		public virtual void LockGrabbable()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x127E07C", Offset = "0x127E07C", VA = "0x127E07C", Slot = "44")]
		public virtual void LockGrabbableWithRotation()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x127E098", Offset = "0x127E098", VA = "0x127E098", Slot = "45")]
		public virtual void RequestLockGrabbable()
		{
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x127E244", Offset = "0x127E244", VA = "0x127E244", Slot = "46")]
		public virtual void RequestUnlockGrabbable()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x127E274", Offset = "0x127E274", VA = "0x127E274", Slot = "47")]
		public virtual void ResetLockResets()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x127E32C", Offset = "0x127E32C", VA = "0x127E32C", Slot = "48")]
		public virtual void LockGrabbable(bool lockPosition, bool lockRotation, bool overridePriorLock)
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x127E55C", Offset = "0x127E55C", VA = "0x127E55C", Slot = "49")]
		public virtual void UnlockGrabbable()
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x127E908", Offset = "0x127E908", VA = "0x127E908")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x127EACC", Offset = "0x127EACC", VA = "0x127EACC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x127EBE8", Offset = "0x127EBE8", VA = "0x127EBE8")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x127ECA4", Offset = "0x127ECA4", VA = "0x127ECA4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x127ECB0", Offset = "0x127ECB0", VA = "0x127ECB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x127ECDC", Offset = "0x127ECDC", VA = "0x127ECDC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x127EE2C", Offset = "0x127EE2C", VA = "0x127EE2C")]
		public Grabbable()
		{
		}
	}
	[Token(Token = "0x200008B")]
	public enum GrabType
	{
		[Token(Token = "0x400043C")]
		Snap,
		[Token(Token = "0x400043D")]
		Precise
	}
	[Token(Token = "0x200008C")]
	public enum RemoteGrabMovement
	{
		[Token(Token = "0x400043F")]
		Linear,
		[Token(Token = "0x4000440")]
		Velocity,
		[Token(Token = "0x4000441")]
		Flick
	}
	[Token(Token = "0x200008D")]
	public enum GrabPhysics
	{
		[Token(Token = "0x4000443")]
		None = 2,
		[Token(Token = "0x4000444")]
		PhysicsJoint = 0,
		[Token(Token = "0x4000445")]
		FixedJoint = 3,
		[Token(Token = "0x4000446")]
		Velocity = 4,
		[Token(Token = "0x4000447")]
		Kinematic = 1
	}
	[Token(Token = "0x200008E")]
	public enum OtherGrabBehavior
	{
		[Token(Token = "0x4000449")]
		None,
		[Token(Token = "0x400044A")]
		SwapHands,
		[Token(Token = "0x400044B")]
		DualGrab
	}
	[Token(Token = "0x200008F")]
	public enum TwoHandedPositionType
	{
		[Token(Token = "0x400044D")]
		Lerp,
		[Token(Token = "0x400044E")]
		None
	}
	[Token(Token = "0x2000090")]
	public enum TwoHandedRotationType
	{
		[Token(Token = "0x4000450")]
		Lerp,
		[Token(Token = "0x4000451")]
		Slerp,
		[Token(Token = "0x4000452")]
		LookAtSecondary,
		[Token(Token = "0x4000453")]
		None
	}
	[Token(Token = "0x2000091")]
	public enum TwoHandedDropMechanic
	{
		[Token(Token = "0x4000455")]
		Drop,
		[Token(Token = "0x4000456")]
		Transfer,
		[Token(Token = "0x4000457")]
		None
	}
	[Token(Token = "0x2000092")]
	public enum TwoHandedLookDirection
	{
		[Token(Token = "0x4000459")]
		Horizontal,
		[Token(Token = "0x400045A")]
		Vertical
	}
	[Token(Token = "0x2000093")]
	public enum HandPoseType
	{
		[Token(Token = "0x400045C")]
		AnimatorID,
		[Token(Token = "0x400045D")]
		HandPose,
		[Token(Token = "0x400045E")]
		AutoPoseOnce,
		[Token(Token = "0x400045F")]
		AutoPoseContinuous,
		[Token(Token = "0x4000460")]
		None
	}
	[Token(Token = "0x2000094")]
	public class GrabbableChild : MonoBehaviour
	{
		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Parent Grabbable Object to be grabbed.")]
		public Grabbable ParentGrabbable;

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x127EED0", Offset = "0x127EED0", VA = "0x127EED0")]
		public GrabbableChild()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[RequireComponent(typeof(Grabbable))]
	public abstract class GrabbableEvents : MonoBehaviour
	{
		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Grabbable grab;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected Grabber thisGrabber;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected InputBridge input;

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x127EED8", Offset = "0x127EED8", VA = "0x127EED8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x127EF5C", Offset = "0x127EF5C", VA = "0x127EF5C", Slot = "5")]
		public virtual void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x127EF64", Offset = "0x127EF64", VA = "0x127EF64", Slot = "6")]
		public virtual void OnRelease()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x127EF68", Offset = "0x127EF68", VA = "0x127EF68", Slot = "7")]
		public virtual void OnBecomesClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x127EF6C", Offset = "0x127EF6C", VA = "0x127EF6C", Slot = "8")]
		public virtual void OnBecomesClosestGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x127EF70", Offset = "0x127EF70", VA = "0x127EF70", Slot = "9")]
		public virtual void OnNoLongerClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x127EF74", Offset = "0x127EF74", VA = "0x127EF74", Slot = "10")]
		public virtual void OnNoLongerClosestGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x127EF78", Offset = "0x127EF78", VA = "0x127EF78", Slot = "11")]
		public virtual void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x127EF7C", Offset = "0x127EF7C", VA = "0x127EF7C", Slot = "12")]
		public virtual void OnBecomesClosestRemoteGrabbable(Grabber theGrabber)
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x127EF80", Offset = "0x127EF80", VA = "0x127EF80", Slot = "13")]
		public virtual void OnNoLongerClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x127EF84", Offset = "0x127EF84", VA = "0x127EF84", Slot = "14")]
		public virtual void OnNoLongerClosestRemoteGrabbable(Grabber theGrabber)
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x127EF88", Offset = "0x127EF88", VA = "0x127EF88", Slot = "15")]
		public virtual void OnGrip(float gripValue)
		{
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x127EF8C", Offset = "0x127EF8C", VA = "0x127EF8C", Slot = "16")]
		public virtual void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x127EF90", Offset = "0x127EF90", VA = "0x127EF90", Slot = "17")]
		public virtual void OnTriggerDown()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x127EF94", Offset = "0x127EF94", VA = "0x127EF94", Slot = "18")]
		public virtual void OnTriggerUp()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x127EF98", Offset = "0x127EF98", VA = "0x127EF98", Slot = "19")]
		public virtual void OnButton1()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x127EF9C", Offset = "0x127EF9C", VA = "0x127EF9C", Slot = "20")]
		public virtual void OnButton1Down()
		{
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x127EFA0", Offset = "0x127EFA0", VA = "0x127EFA0", Slot = "21")]
		public virtual void OnButton1Up()
		{
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x127EFA4", Offset = "0x127EFA4", VA = "0x127EFA4", Slot = "22")]
		public virtual void OnButton2()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x127EFA8", Offset = "0x127EFA8", VA = "0x127EFA8", Slot = "23")]
		public virtual void OnButton2Down()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x127EFAC", Offset = "0x127EFAC", VA = "0x127EFAC", Slot = "24")]
		public virtual void OnButton2Up()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x127EFB0", Offset = "0x127EFB0", VA = "0x127EFB0", Slot = "25")]
		public virtual void OnSnapZoneEnter()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x127EFB4", Offset = "0x127EFB4", VA = "0x127EFB4", Slot = "26")]
		public virtual void OnSnapZoneExit()
		{
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x127EFB8", Offset = "0x127EFB8", VA = "0x127EFB8")]
		protected GrabbableEvents()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000096")]
	public class FloatEvent : UnityEvent<float>
	{
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x127EFC0", Offset = "0x127EFC0", VA = "0x127EFC0")]
		public FloatEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000097")]
	public class FloatFloatEvent : UnityEvent<float, float>
	{
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x127F008", Offset = "0x127F008", VA = "0x127F008")]
		public FloatFloatEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000098")]
	public class GrabberEvent : UnityEvent<Grabber>
	{
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x127F050", Offset = "0x127F050", VA = "0x127F050")]
		public GrabberEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000099")]
	public class GrabbableEvent : UnityEvent<Grabbable>
	{
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x127F098", Offset = "0x127F098", VA = "0x127F098")]
		public GrabbableEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009A")]
	public class RaycastHitEvent : UnityEvent<RaycastHit>
	{
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x127F0E0", Offset = "0x127F0E0", VA = "0x127F0E0")]
		public RaycastHitEvent()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class Vector2Event : UnityEvent<Vector2>
	{
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x127F128", Offset = "0x127F128", VA = "0x127F128")]
		public Vector2Event()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class Vector3Event : UnityEvent<Vector3>
	{
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x127F170", Offset = "0x127F170", VA = "0x127F170")]
		public Vector3Event()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class PointerEventDataEvent : UnityEvent<PointerEventData>
	{
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x127F1B8", Offset = "0x127F1B8", VA = "0x127F1B8")]
		public PointerEventDataEvent()
		{
		}
	}
	[Token(Token = "0x200009E")]
	public class GrabbablesInTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<Collider, Grabbable> NearbyGrabbables;

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<Collider, Grabbable> ValidGrabbables;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Grabbable ClosestGrabbable;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Dictionary<Collider, Grabbable> ValidRemoteGrabbables;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Grabbable ClosestRemoteGrabbable;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool FireGrabbableEvents;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Grabbable _closest;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float _lastDistance;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _thisDistance;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Dictionary<Collider, Grabbable> _valids;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<Collider, Grabbable> _filtered;

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x127F200", Offset = "0x127F200", VA = "0x127F200")]
		private void Start()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x127F2B4", Offset = "0x127F2B4", VA = "0x127F2B4")]
		private void Update()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x127F2CC", Offset = "0x127F2CC", VA = "0x127F2CC")]
		private void updateClosestGrabbable()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x127F31C", Offset = "0x127F31C", VA = "0x127F31C")]
		private void updateClosestRemoteGrabbables()
		{
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x127F5E8", Offset = "0x127F5E8", VA = "0x127F5E8", Slot = "4")]
		public virtual Grabbable GetClosestGrabbable(Dictionary<Collider, Grabbable> grabbables, bool remoteOnly = false)
		{
			return null;
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x127F3A4", Offset = "0x127F3A4", VA = "0x127F3A4")]
		public Dictionary<Collider, Grabbable> GetValidGrabbables(Dictionary<Collider, Grabbable> grabs)
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x127F8FC", Offset = "0x127F8FC", VA = "0x127F8FC", Slot = "5")]
		protected virtual bool isValidGrabbable(Collider col, Grabbable grab)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x127FB64", Offset = "0x127FB64", VA = "0x127FB64", Slot = "6")]
		public virtual Dictionary<Collider, Grabbable> SanitizeGrabbables(Dictionary<Collider, Grabbable> grabs)
		{
			return null;
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x127FED4", Offset = "0x127FED4", VA = "0x127FED4", Slot = "7")]
		public virtual void AddNearbyGrabbable(Collider col, Grabbable grabObject)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x127FFFC", Offset = "0x127FFFC", VA = "0x127FFFC", Slot = "8")]
		public virtual void RemoveNearbyGrabbable(Collider col, Grabbable grabObject)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x12800D4", Offset = "0x12800D4", VA = "0x12800D4", Slot = "9")]
		public virtual void RemoveNearbyGrabbable(Grabbable grabObject)
		{
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x12802C4", Offset = "0x12802C4", VA = "0x12802C4", Slot = "10")]
		public virtual void AddValidRemoteGrabbable(Collider col, Grabbable grabObject)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1280590", Offset = "0x1280590", VA = "0x1280590", Slot = "11")]
		public virtual void RemoveValidRemoteGrabbable(Collider col, Grabbable grabObject)
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1280668", Offset = "0x1280668", VA = "0x1280668")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x12807B8", Offset = "0x12807B8", VA = "0x12807B8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x12808E0", Offset = "0x12808E0", VA = "0x12808E0")]
		public GrabbablesInTrigger()
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class GrabbableUnityEvents : GrabbableEvents
	{
		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrabberEvent onGrab;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UnityEvent onRelease;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent onBecomesClosestGrabbable;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public UnityEvent onNoLongerClosestGrabbable;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public UnityEvent onBecomesClosestRemoteGrabbable;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public UnityEvent onNoLongerClosestRemoteGrabbable;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FloatEvent onGrip;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public FloatEvent onTrigger;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UnityEvent onTriggerDown;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public UnityEvent onTriggerUp;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public UnityEvent onButton1;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UnityEvent onButton1Down;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UnityEvent onButton1Up;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UnityEvent onButton2;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UnityEvent onButton2Down;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UnityEvent onButton2Up;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UnityEvent onSnapZoneEnter;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UnityEvent onSnapZoneExit;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x12808F0", Offset = "0x12808F0", VA = "0x12808F0", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1280954", Offset = "0x1280954", VA = "0x1280954", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1280968", Offset = "0x1280968", VA = "0x1280968", Slot = "7")]
		public override void OnBecomesClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x128097C", Offset = "0x128097C", VA = "0x128097C", Slot = "9")]
		public override void OnNoLongerClosestGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x1280990", Offset = "0x1280990", VA = "0x1280990", Slot = "11")]
		public override void OnBecomesClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x12809A4", Offset = "0x12809A4", VA = "0x12809A4", Slot = "13")]
		public override void OnNoLongerClosestRemoteGrabbable(ControllerHand touchingHand)
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x12809B8", Offset = "0x12809B8", VA = "0x12809B8", Slot = "15")]
		public override void OnGrip(float gripValue)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x1280A24", Offset = "0x1280A24", VA = "0x1280A24", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x1280A90", Offset = "0x1280A90", VA = "0x1280A90", Slot = "17")]
		public override void OnTriggerDown()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x1280AA4", Offset = "0x1280AA4", VA = "0x1280AA4", Slot = "18")]
		public override void OnTriggerUp()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x1280AB8", Offset = "0x1280AB8", VA = "0x1280AB8", Slot = "19")]
		public override void OnButton1()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1280ACC", Offset = "0x1280ACC", VA = "0x1280ACC", Slot = "20")]
		public override void OnButton1Down()
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x1280AE0", Offset = "0x1280AE0", VA = "0x1280AE0", Slot = "21")]
		public override void OnButton1Up()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x1280AF4", Offset = "0x1280AF4", VA = "0x1280AF4", Slot = "22")]
		public override void OnButton2()
		{
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x1280B08", Offset = "0x1280B08", VA = "0x1280B08", Slot = "23")]
		public override void OnButton2Down()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1280B1C", Offset = "0x1280B1C", VA = "0x1280B1C", Slot = "24")]
		public override void OnButton2Up()
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1280B30", Offset = "0x1280B30", VA = "0x1280B30", Slot = "25")]
		public override void OnSnapZoneEnter()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1280B44", Offset = "0x1280B44", VA = "0x1280B44", Slot = "26")]
		public override void OnSnapZoneExit()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1280B58", Offset = "0x1280B58", VA = "0x1280B58")]
		public GrabbableUnityEvents()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[RequireComponent(typeof(GrabbablesInTrigger))]
	public class Grabber : MonoBehaviour
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Which controller side. None if not attached to a controller.")]
		[Header("Hand Side")]
		public ControllerHand HandSide;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The default hold type for all Grabbables. A Grabbable can manually override this default.")]
		[Header("Grab Settings")]
		public HoldType DefaultHoldType;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The default grab button for all Grabbables. A Grabbable can manually override this default.")]
		public GrabButton DefaultGrabButton;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Hold / Release")]
		[Tooltip("0-1 determine how much to consider a grip. Example : 0.75 is holding the grip down 3/4 of the way.")]
		[Range(0f, 1f)]
		public float GripAmount;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much grip considered to release an object (0-1). Example : 0.75 is holding the grip down 3/4 of the way")]
		[Range(0f, 1f)]
		public float ReleaseGripAmount;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How many seconds to check for grab input while Grip is held down. After grip is held down for this long, grip will need to be repressed in order to pick up an object.")]
		public float GrabCheckSeconds;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float currentGrabTime;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Equip on Start")]
		[Tooltip("Assign a Grabbable here if you want to auto equip it on Start")]
		public Grabbable EquipGrabbableOnStart;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Root transform that holds hands models. We may want to hide these while holding certain objects, or parent this object to the grabbable so they follow the object perfectly.")]
		[Header("Hand Graphics")]
		public Transform HandsGraphics;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform handsGraphicsParent;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 handsGraphicsPosition;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion handsGraphicsRotation;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Shown for Debug :")]
		[Tooltip("The Grabbable we are currently holding. Null if not holding anything.")]
		public Grabbable HeldGrabbable;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Same as holding down grip if set to true. Should not have same value as ForceRelease.")]
		public bool ForceGrab;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[Tooltip("Force the release of grip if set to true. Should not have same value as ForceGrab.")]
		public bool ForceRelease;

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Time.time when we last dropped a Grabbable")]
		public float LastDropTime;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable previousClosest;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Grabbable previousClosestRemote;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private GrabbablesInTrigger grabsInTrigger;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Grabbable flyingGrabbable;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float flyingTime;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[HideInInspector]
		public Vector3 PreviousPosition;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		public Transform DummyTransform;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Rigidbody rb;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private InputBridge input;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private ConfigurableJoint joint;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[HideInInspector]
		public bool FreshGrip;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Header("Grabber Events")]
		[Tooltip("Called immediately before a Grabbable object is officially grabbed")]
		public GrabbableEvent onGrabEvent;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("Called immediately after a Grabbable object is grabbed. Use this if you need the Grabbable object to be setup before accessing it")]
		public GrabbableEvent onAfterGrabEvent;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Called immediately before droppping an item")]
		public GrabbableEvent onReleaseEvent;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[HideInInspector]
		public VelocityTracker velocityTracker;

		[Token(Token = "0x17000034")]
		public bool HoldingItem
		{
			[Token(Token = "0x600030A")]
			[Address(RVA = "0x1280B60", Offset = "0x1280B60", VA = "0x1280B60")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public bool RemoteGrabbingItem
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0x1280BC0", Offset = "0x1280BC0", VA = "0x1280BC0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000036")]
		public GrabbablesInTrigger GrabsInTrigger
		{
			[Token(Token = "0x600030C")]
			[Address(RVA = "0x1280C20", Offset = "0x1280C20", VA = "0x1280C20")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000037")]
		public Grabbable RemoteGrabbingGrabbable
		{
			[Token(Token = "0x600030D")]
			[Address(RVA = "0x1280C28", Offset = "0x1280C28", VA = "0x1280C28")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		public Vector3 handsGraphicsGrabberOffset
		{
			[Token(Token = "0x600030E")]
			[Address(RVA = "0x1280C30", Offset = "0x1280C30", VA = "0x1280C30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600030F")]
			[Address(RVA = "0x1280C3C", Offset = "0x1280C3C", VA = "0x1280C3C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 handsGraphicsGrabberOffsetRotation
		{
			[Token(Token = "0x6000310")]
			[Address(RVA = "0x1280C48", Offset = "0x1280C48", VA = "0x1280C48")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000311")]
			[Address(RVA = "0x1280C54", Offset = "0x1280C54", VA = "0x1280C54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x1280C60", Offset = "0x1280C60", VA = "0x1280C60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x12810BC", Offset = "0x12810BC", VA = "0x12810BC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x128126C", Offset = "0x128126C", VA = "0x128126C")]
		private void updateFreshGrabStatus()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x12812E0", Offset = "0x12812E0", VA = "0x12812E0")]
		private void checkGrabbableEvents()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x1281974", Offset = "0x1281974", VA = "0x1281974", Slot = "4")]
		public virtual bool InputCheckGrab()
		{
			return default(bool);
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1281A5C", Offset = "0x1281A5C", VA = "0x1281A5C", Slot = "5")]
		public virtual bool GetInputDownForGrabbable(Grabbable grabObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1281B40", Offset = "0x1281B40", VA = "0x1281B40")]
		private HoldType getHoldType(Grabbable grab)
		{
			return default(HoldType);
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1281CC4", Offset = "0x1281CC4", VA = "0x1281CC4", Slot = "6")]
		public virtual GrabButton GetGrabButton(Grabbable grab)
		{
			return default(GrabButton);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x1281998", Offset = "0x1281998", VA = "0x1281998")]
		private Grabbable getClosestOrRemote()
		{
			return null;
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x12817B4", Offset = "0x12817B4", VA = "0x12817B4")]
		private bool inputCheckRelease()
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1281894", Offset = "0x1281894", VA = "0x1281894")]
		private float getGrabInput(GrabButton btn)
		{
			return default(float);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1281BD8", Offset = "0x1281BD8", VA = "0x1281BD8")]
		private bool getToggleInput(GrabButton btn)
		{
			return default(bool);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1281D5C", Offset = "0x1281D5C", VA = "0x1281D5C", Slot = "7")]
		public virtual bool TryGrab()
		{
			return default(bool);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1281E9C", Offset = "0x1281E9C", VA = "0x1281E9C", Slot = "8")]
		public virtual void GrabGrabbable(Grabbable item)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x128200C", Offset = "0x128200C", VA = "0x128200C", Slot = "9")]
		public virtual void DidDrop()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1282124", Offset = "0x1282124", VA = "0x1282124", Slot = "10")]
		public virtual void HideHandGraphics()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x12821B8", Offset = "0x12821B8", VA = "0x12821B8", Slot = "11")]
		public virtual void ResetHandGraphics()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x12822B4", Offset = "0x12822B4", VA = "0x12822B4", Slot = "12")]
		public virtual void TryRelease()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x12811E0", Offset = "0x12811E0", VA = "0x12811E0")]
		private void resetFlyingGrabbable()
		{
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1282348", Offset = "0x1282348", VA = "0x1282348", Slot = "13")]
		public virtual Vector3 GetGrabberAveragedVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1282368", Offset = "0x1282368", VA = "0x1282368", Slot = "14")]
		public virtual Vector3 GetGrabberAveragedAngularVelocity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1282388", Offset = "0x1282388", VA = "0x1282388")]
		public Grabber()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class GrabPoint : MonoBehaviour
	{
		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Hand Pose")]
		public HandPoseType handPoseType;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If HandPoseType = 'HandPose', this HandPose object will be applied to the hand when this grab point is in use")]
		public HandPose SelectedHandPose;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If HandPoseType = 'AnimatorID', this id will be set on the hand animator when grabbed. Set to 'Default' to inherit the Grabbable's HandPose. Otherwise this HandPose ID will be used.")]
		public HandPoseId HandPose;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Can this Grab Point be used by a left-handed Grabber?")]
		[Header("Valid Hands")]
		public bool LeftHandIsValid;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Tooltip("Can this Grab Point be used by a right-handed Grabber?")]
		public bool RightHandIsValid;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Parent to")]
		[Tooltip("If specified, the Hand Model will be parented here when snapped")]
		public Transform HandPosition;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Angle Restriction")]
		[Range(0f, 360f)]
		[Tooltip("GrabPoint is not considered valid if the angle between the GrabPoint and Grabber is greater than this amount")]
		public float MaxDegreeDifferenceAllowed;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Header("Finger Blending")]
		[Tooltip("Minimum value Hand Animator will blend to. Example : If IndexBlendMin = 0.4 and Trigger button is not held down, the LayerWeight will be set to 0.4")]
		[Range(0f, 1f)]
		public float IndexBlendMin;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Maximum value Hand Animator will blend to. Example : If IndexBlendMax = 0.6 and Trigger button is held all the way down, the LayerWeight will be set to 0.6")]
		public float IndexBlendMax;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		[Tooltip("Minimum value Hand Animator will blend to if thumb control is not being touched.")]
		public float ThumbBlendMin;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Maximum value Hand Animator will blend to if thumb control is being touched.")]
		public float ThumbBlendMax;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 previewModelOffsetLeft;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 previewModelOffsetRight;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Show a green arc in the Scene view representing MaxDegreeDifferenceAllowed")]
		[Header("Editor")]
		public bool ShowAngleGizmo;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool offsetFound;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x12823AC", Offset = "0x12823AC", VA = "0x12823AC")]
		public void UpdatePreviewTransforms()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1282720", Offset = "0x1282720", VA = "0x1282720")]
		public void UpdateHandPosePreview()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x12828C8", Offset = "0x12828C8", VA = "0x12828C8")]
		public void UpdateAutoPoserPreview()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1282B80", Offset = "0x1282B80", VA = "0x1282B80")]
		public void UpdateChildAnimators()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1282D08", Offset = "0x1282D08", VA = "0x1282D08")]
		public GrabPoint()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class HandModelSelector : MonoBehaviour
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Child index of the hand model to use if nothing stored in playerprefs or LoadHandSelectionFromPrefs set to false")]
		public int DefaultHandsModel;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If true, the selected hand model will be saved and loaded from player prefs")]
		public bool LoadHandSelectionFromPrefs;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Input used to toggle between hands")]
		public ControllerBinding ToggleHandsInput;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("This transform holds all of the hand models. Can be used to enabled / disabled various hand options.")]
		public Transform LeftHandGFXHolder;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This transform holds all of the hand models. Can be used to enabled / disabled various hand options")]
		public Transform RightHandGFXHolder;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _selectedHandGFX;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Used for IK Hands / Body option")]
		public CharacterIK IKBody;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private UIPointer uiPoint;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<Transform> leftHandModels;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform activatedLeftModel;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private List<Transform> rightHandModels;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform activatedRightModel;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1282D4C", Offset = "0x1282D4C", VA = "0x1282D4C")]
		private void Start()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x12834DC", Offset = "0x12834DC", VA = "0x12834DC")]
		private void Update()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1282DDC", Offset = "0x1282DDC", VA = "0x1282DDC")]
		public void CacheHandModels()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1282FCC", Offset = "0x1282FCC", VA = "0x1282FCC")]
		public void ChangeHandsModel(int childIndex, bool save = false)
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1283514", Offset = "0x1283514", VA = "0x1283514")]
		public HandModelSelector()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class HeadCollisionFade : MonoBehaviour
	{
		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ScreenFader fader;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float FadeDistance;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float FadeOutDistance;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MinFade;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float MaxFade;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FadeSpeed;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Only fade the screen if the HMD is registering as Active")]
		public bool CheckOnlyIfHMDActive;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		public bool IgnoreHeldGrabbables;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform DistanceTransform;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int cols;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float currentFade;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastFade;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<Collider> collisions;

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x128352C", Offset = "0x128352C", VA = "0x128352C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x12835D8", Offset = "0x12835D8", VA = "0x12835D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x128388C", Offset = "0x128388C", VA = "0x128388C")]
		private void OnCollisionEnter(Collision col)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1283B7C", Offset = "0x1283B7C", VA = "0x1283B7C")]
		private void OnCollisionExit(Collision col)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1283C7C", Offset = "0x1283C7C", VA = "0x1283C7C")]
		public HeadCollisionFade()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class HingeHelper : GrabbableEvents
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If True the SnapGraphics tranfsorm will have its local Y rotation snapped to the nearest degrees specified in SnapDegrees")]
		public bool SnapToDegrees;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Snap the Y rotation to the nearest")]
		public float SnapDegrees;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The Transform of the object to be rotated if SnapToDegrees is true")]
		public Transform SnapGraphics;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Play this sound on snap")]
		public AudioClip SnapSound;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Randomize pitch of SnapSound by this amount")]
		public float RandomizePitch;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Add haptics amount (0-1) to controller if SnapToDegrees is True. Set this to 0 for no Haptics.")]
		public float SnapHaptics;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Text LabelToUpdate;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FloatEvent onHingeChange;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FloatEvent onHingeSnapChange;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody rigid;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _lastDegrees;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _lastSnapDegrees;

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1283CA0", Offset = "0x1283CA0", VA = "0x1283CA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1283CF0", Offset = "0x1283CF0", VA = "0x1283CF0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1283F8C", Offset = "0x1283F8C", VA = "0x1283F8C")]
		public void OnSnapChange(float yAngle)
		{
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1284310", Offset = "0x1284310", VA = "0x1284310", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1283F20", Offset = "0x1283F20", VA = "0x1283F20")]
		public void OnHingeChange(float hingeAmount)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1283EFC", Offset = "0x1283EFC", VA = "0x1283EFC")]
		private float getSmoothedValue(float val)
		{
			return default(float);
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x12843BC", Offset = "0x12843BC", VA = "0x12843BC")]
		public HingeHelper()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public enum ControllerHand
	{
		[Token(Token = "0x40004D8")]
		Left,
		[Token(Token = "0x40004D9")]
		Right,
		[Token(Token = "0x40004DA")]
		None
	}
	[Token(Token = "0x20000A6")]
	public enum ControllerBinding
	{
		[Token(Token = "0x40004DC")]
		None,
		[Token(Token = "0x40004DD")]
		AButton,
		[Token(Token = "0x40004DE")]
		AButtonDown,
		[Token(Token = "0x40004DF")]
		BButton,
		[Token(Token = "0x40004E0")]
		BButtonDown,
		[Token(Token = "0x40004E1")]
		XButton,
		[Token(Token = "0x40004E2")]
		XButtonDown,
		[Token(Token = "0x40004E3")]
		YButton,
		[Token(Token = "0x40004E4")]
		YButtonDown,
		[Token(Token = "0x40004E5")]
		LeftTrigger,
		[Token(Token = "0x40004E6")]
		LeftTriggerDown,
		[Token(Token = "0x40004E7")]
		LeftGrip,
		[Token(Token = "0x40004E8")]
		LeftGripDown,
		[Token(Token = "0x40004E9")]
		LeftThumbstick,
		[Token(Token = "0x40004EA")]
		LeftThumbstickDown,
		[Token(Token = "0x40004EB")]
		RightTrigger,
		[Token(Token = "0x40004EC")]
		RightTriggerDown,
		[Token(Token = "0x40004ED")]
		RightGrip,
		[Token(Token = "0x40004EE")]
		RightGripDown,
		[Token(Token = "0x40004EF")]
		RightThumbstick,
		[Token(Token = "0x40004F0")]
		RightThumbstickDown,
		[Token(Token = "0x40004F1")]
		StartButton,
		[Token(Token = "0x40004F2")]
		StartButtonDown,
		[Token(Token = "0x40004F3")]
		BackButton,
		[Token(Token = "0x40004F4")]
		BackButtonDown
	}
	[Token(Token = "0x20000A7")]
	public enum GrabbedControllerBinding
	{
		[Token(Token = "0x40004F6")]
		None,
		[Token(Token = "0x40004F7")]
		Button1,
		[Token(Token = "0x40004F8")]
		Button1Down,
		[Token(Token = "0x40004F9")]
		Button2,
		[Token(Token = "0x40004FA")]
		Button2Down,
		[Token(Token = "0x40004FB")]
		Trigger,
		[Token(Token = "0x40004FC")]
		TriggerDown,
		[Token(Token = "0x40004FD")]
		Grip,
		[Token(Token = "0x40004FE")]
		GripDown
	}
	[Token(Token = "0x20000A8")]
	public enum InputAxis
	{
		[Token(Token = "0x4000500")]
		None,
		[Token(Token = "0x4000501")]
		LeftThumbStickAxis,
		[Token(Token = "0x4000502")]
		LeftTouchPadAxis,
		[Token(Token = "0x4000503")]
		RightThumbStickAxis,
		[Token(Token = "0x4000504")]
		RightTouchPadAxis
	}
	[Token(Token = "0x20000A9")]
	public enum ControllerType
	{
		[Token(Token = "0x4000506")]
		None,
		[Token(Token = "0x4000507")]
		Unknown,
		[Token(Token = "0x4000508")]
		OculusTouch,
		[Token(Token = "0x4000509")]
		Wand,
		[Token(Token = "0x400050A")]
		Knuckles
	}
	[Token(Token = "0x20000AA")]
	public enum HandControl
	{
		[Token(Token = "0x400050C")]
		LeftGrip,
		[Token(Token = "0x400050D")]
		RightGrip,
		[Token(Token = "0x400050E")]
		LeftTrigger,
		[Token(Token = "0x400050F")]
		RightTrigger,
		[Token(Token = "0x4000510")]
		None
	}
	[Token(Token = "0x20000AB")]
	public enum GrabButton
	{
		[Token(Token = "0x4000512")]
		Grip,
		[Token(Token = "0x4000513")]
		Trigger,
		[Token(Token = "0x4000514")]
		Inherit
	}
	[Token(Token = "0x20000AC")]
	public enum HoldType
	{
		[Token(Token = "0x4000516")]
		HoldDown,
		[Token(Token = "0x4000517")]
		Toggle,
		[Token(Token = "0x4000518")]
		Inherit
	}
	[Token(Token = "0x20000AD")]
	public enum XRInputSource
	{
		[Token(Token = "0x400051A")]
		XRInput,
		[Token(Token = "0x400051B")]
		OVRInput,
		[Token(Token = "0x400051C")]
		SteamVR,
		[Token(Token = "0x400051D")]
		Pico,
		[Token(Token = "0x400051E")]
		UnityInput
	}
	[Token(Token = "0x20000AE")]
	public enum SDKProvider
	{
		[Token(Token = "0x4000520")]
		Unknown,
		[Token(Token = "0x4000521")]
		OculusSDK,
		[Token(Token = "0x4000522")]
		OpenVR
	}
	[Token(Token = "0x20000AF")]
	public class InputBridge : MonoBehaviour
	{
		[Token(Token = "0x20000B0")]
		public delegate void InputsUpdatedAction();

		[Token(Token = "0x20000B1")]
		public delegate void ControllerFoundAction();

		[Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private sealed class <changeOriginModeRoutine>d__167 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public InputBridge <>4__this;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TrackingOriginModeFlags trackingOrigin;

			[Token(Token = "0x17000042")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000390")]
				[Address(RVA = "0x12A0134", Offset = "0x12A0134", VA = "0x12A0134", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000043")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000392")]
				[Address(RVA = "0x12A017C", Offset = "0x12A017C", VA = "0x12A017C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600038D")]
			[Address(RVA = "0x129FEF0", Offset = "0x129FEF0", VA = "0x129FEF0")]
			[DebuggerHidden]
			public <changeOriginModeRoutine>d__167(int <>1__state)
			{
			}

			[Token(Token = "0x600038E")]
			[Address(RVA = "0x129FF18", Offset = "0x129FF18", VA = "0x129FF18", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600038F")]
			[Address(RVA = "0x129FF1C", Offset = "0x129FF1C", VA = "0x129FF1C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000391")]
			[Address(RVA = "0x12A013C", Offset = "0x12A013C", VA = "0x12A013C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000B3")]
		[CompilerGenerated]
		private sealed class <Vibrate>d__169 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float duration;

			[Token(Token = "0x17000044")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000396")]
				[Address(RVA = "0x12A0250", Offset = "0x12A0250", VA = "0x12A0250", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000045")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x12A0298", Offset = "0x12A0298", VA = "0x12A0298", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000393")]
			[Address(RVA = "0x12A0184", Offset = "0x12A0184", VA = "0x12A0184")]
			[DebuggerHidden]
			public <Vibrate>d__169(int <>1__state)
			{
			}

			[Token(Token = "0x6000394")]
			[Address(RVA = "0x12A01AC", Offset = "0x12A01AC", VA = "0x12A01AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000395")]
			[Address(RVA = "0x12A01B0", Offset = "0x12A01B0", VA = "0x12A01B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000397")]
			[Address(RVA = "0x12A0258", Offset = "0x12A0258", VA = "0x12A0258", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InputBridge _instance;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Header("Input Settings")]
		public XRInputSource InputSource;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Specify an InputActionSet for when using the Unity Input system. These actions will be enabled on load.")]
		[SerializeField]
		public InputActionAsset actionSet;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Set the TrackingOriginModeFlags on device connect. Should typically be set to 'Floor'")]
		[SerializeField]
		[Header("Tracking Origin")]
		public TrackingOriginModeFlags TrackingOrigin;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Header("Thumbstick Deadzone")]
		[Tooltip("Thumbstick X must be greater than this amount to be considered valid")]
		public float ThumbstickDeadzoneX;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Thumbstick Y must be greater than this amount to be considered valid")]
		public float ThumbstickDeadzoneY;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("Grip")]
		public float LeftGrip;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool LeftGripDown;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float RightGrip;

		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool RightGripDown;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Trigger")]
		public float LeftTrigger;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool LeftTriggerNear;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool LeftTriggerUp;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		public bool LeftTriggerDown;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float RightTrigger;

		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool RightTriggerUp;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RightTriggerDown;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool RightTriggerNear;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool LeftThumbNear;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool RightThumbNear;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[Header("Thumbstick")]
		public bool LeftThumbstickDown;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		public bool LeftThumbstickUp;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		public bool RightThumbstickDown;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool RightThumbstickUp;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		public bool LeftThumbstick;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A")]
		public bool RightThumbstick;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B")]
		[Header("Buttons")]
		public bool AButton;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Returns true if the A Button was pressed down this frame but not last")]
		public bool AButtonDown;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		public bool AButtonUp;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		public bool BButton;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		[Tooltip("Returns true if the B Button was pressed down this frame but not last")]
		public bool BButtonDown;

		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool BButtonUp;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool XButton;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		[Tooltip("Returns true if the X Button was pressed down this frame but not last")]
		public bool XButtonDown;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool XButtonUp;

		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public bool YButton;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		public bool YButtonDown;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		public bool YButtonUp;

		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		public bool StartButton;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool StartButtonDown;

		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool BackButton;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool BackButtonDown;

		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Header("Axis")]
		public Vector2 LeftThumbstickAxis;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector2 RightThumbstickAxis;

		[Token(Token = "0x400054F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Vector2 LeftTouchPadAxis;

		[Token(Token = "0x4000550")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector2 RightTouchPadAxis;

		[Token(Token = "0x4000551")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float _downThreshold;

		[Token(Token = "0x4000552")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool SteamVRSupport;

		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Header("HMD / Hardware")]
		public ControllerType ConnectedControllerType;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Is there an HMD present and in use.")]
		public bool HMDActive;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA5")]
		[Tooltip("Returns true if the controller has both a Touchpad and a Joystick. Currently on the Valve Index has both.")]
		public bool SupportsBothTouchPadAndJoystick;

		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA6")]
		[Tooltip("Returns true if the controllers support the 'indexTouch' XR input mapping. Currently only Oculus devices on the Oculus SDK support thumb touch. OpenVR is not supported.")]
		public bool SupportsIndexTouch;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA7")]
		[Tooltip("Returns true if the controllers support the 'ThumbTouch' (or near thumbstick) XR input mapping. Currently only Oculus devices on the Oculus SDK support thumb touch. OpenVR is not supported.")]
		public bool SupportsThumbTouch;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static List<UnityEngine.XR.InputDevice> devices;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InputAction leftGrip;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private InputAction leftTrigger;

		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InputAction leftTriggerNear;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InputAction rightGrip;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private InputAction rightTrigger;

		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InputAction rightTriggerNear;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private InputAction leftThumbstick;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private InputAction leftThumbstickDown;

		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private InputAction leftThumbNear;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private InputAction leftTouchpad;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private InputAction leftTouchpadDown;

		[Token(Token = "0x400056C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private InputAction rightThumbstick;

		[Token(Token = "0x400056D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private InputAction rightThumbstickDown;

		[Token(Token = "0x400056E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private InputAction rightThumbNear;

		[Token(Token = "0x400056F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private InputAction rightTouchpad;

		[Token(Token = "0x4000570")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private InputAction rightTouchpadDown;

		[Token(Token = "0x4000571")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private InputAction aButton;

		[Token(Token = "0x4000572")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private InputAction bButton;

		[Token(Token = "0x4000573")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private InputAction xButton;

		[Token(Token = "0x4000574")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private InputAction yButton;

		[Token(Token = "0x4000575")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private InputAction startButton;

		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private InputAction backButton;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[HideInInspector]
		public bool ShowInputDebugger;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private UnityEngine.XR.InputDevice primaryLeftController;

		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private UnityEngine.XR.InputDevice primaryRightController;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private InputFeatureUsage<Vector2> thumbstickAxis;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private InputFeatureUsage<Vector2> thumbstickAxisSecondary;

		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private InputFeatureUsage<bool> thumbstickAxisClick;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private bool setTrackingOrigin;

		[Token(Token = "0x1700003A")]
		public static InputBridge Instance
		{
			[Token(Token = "0x600033E")]
			[Address(RVA = "0x127519C", Offset = "0x127519C", VA = "0x127519C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public float DownThreshold
		{
			[Token(Token = "0x600033F")]
			[Address(RVA = "0x12843D8", Offset = "0x12843D8", VA = "0x12843D8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003C")]
		public SDKProvider LoadedSDK
		{
			[Token(Token = "0x6000340")]
			[Address(RVA = "0x12843E0", Offset = "0x12843E0", VA = "0x12843E0")]
			[CompilerGenerated]
			get
			{
				return default(SDKProvider);
			}
			[Token(Token = "0x6000341")]
			[Address(RVA = "0x12843E8", Offset = "0x12843E8", VA = "0x12843E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003D")]
		public bool IsOculusDevice
		{
			[Token(Token = "0x6000342")]
			[Address(RVA = "0x12843F0", Offset = "0x12843F0", VA = "0x12843F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000343")]
			[Address(RVA = "0x12843F8", Offset = "0x12843F8", VA = "0x12843F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public bool IsOculusQuest
		{
			[Token(Token = "0x6000344")]
			[Address(RVA = "0x1284404", Offset = "0x1284404", VA = "0x1284404")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000345")]
			[Address(RVA = "0x128440C", Offset = "0x128440C", VA = "0x128440C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public bool IsHTCDevice
		{
			[Token(Token = "0x6000346")]
			[Address(RVA = "0x1284418", Offset = "0x1284418", VA = "0x1284418")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000347")]
			[Address(RVA = "0x1284420", Offset = "0x1284420", VA = "0x1284420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000040")]
		public bool IsPicoDevice
		{
			[Token(Token = "0x6000348")]
			[Address(RVA = "0x128442C", Offset = "0x128442C", VA = "0x128442C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000349")]
			[Address(RVA = "0x1284434", Offset = "0x1284434", VA = "0x1284434")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000041")]
		public bool IsValveIndexController
		{
			[Token(Token = "0x600034A")]
			[Address(RVA = "0x1284440", Offset = "0x1284440", VA = "0x1284440")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x1284448", Offset = "0x1284448", VA = "0x1284448")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event InputsUpdatedAction OnInputsUpdated
		{
			[Token(Token = "0x600034C")]
			[Address(RVA = "0x1284454", Offset = "0x1284454", VA = "0x1284454")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1284530", Offset = "0x1284530", VA = "0x1284530")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000002")]
		public static event ControllerFoundAction OnControllerFound
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1274FA8", Offset = "0x1274FA8", VA = "0x1274FA8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1275488", Offset = "0x1275488", VA = "0x1275488")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x128460C", Offset = "0x128460C", VA = "0x128460C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1284934", Offset = "0x1284934", VA = "0x1284934")]
		private void Start()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1284948", Offset = "0x1284948", VA = "0x1284948")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1284A48", Offset = "0x1284A48", VA = "0x1284A48")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1284B38", Offset = "0x1284B38", VA = "0x1284B38")]
		private void Update()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1284B64", Offset = "0x1284B64", VA = "0x1284B64", Slot = "4")]
		public virtual void UpdateInputs()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1284C50", Offset = "0x1284C50", VA = "0x1284C50", Slot = "5")]
		public virtual void UpdateSteamInput()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1284C54", Offset = "0x1284C54", VA = "0x1284C54", Slot = "6")]
		public virtual void UpdateXRInput()
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1285994", Offset = "0x1285994", VA = "0x1285994", Slot = "7")]
		public virtual void UpdateUnityInput()
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1285DDC", Offset = "0x1285DDC", VA = "0x1285DDC", Slot = "8")]
		public virtual void CreateUnityInputActions()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x12863E8", Offset = "0x12863E8", VA = "0x12863E8", Slot = "9")]
		public virtual void EnableActions()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x12867FC", Offset = "0x12867FC", VA = "0x12867FC", Slot = "10")]
		public virtual void DisableActions()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1286350", Offset = "0x1286350", VA = "0x1286350")]
		public InputAction CreateInputAction(string actionName, string binding, bool valueType)
		{
			return null;
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1286C10", Offset = "0x1286C10", VA = "0x1286C10", Slot = "11")]
		public virtual void UpdateOVRInput()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1286C84", Offset = "0x1286C84", VA = "0x1286C84", Slot = "12")]
		public virtual void UpdatePicoInput()
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1286C88", Offset = "0x1286C88", VA = "0x1286C88", Slot = "13")]
		public virtual void UpdateDeviceActive()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x12858B4", Offset = "0x12858B4", VA = "0x12858B4")]
		private float correctValue(float inputValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1286E0C", Offset = "0x1286E0C", VA = "0x1286E0C")]
		public bool GetControllerBindingValue(ControllerBinding val)
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x1286F54", Offset = "0x1286F54", VA = "0x1286F54")]
		public bool GetGrabbedControllerBinding(GrabbedControllerBinding val, ControllerHand hand)
		{
			return default(bool);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x128706C", Offset = "0x128706C", VA = "0x128706C")]
		public Vector2 GetInputAxisValue(InputAxis val)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x128584C", Offset = "0x128584C", VA = "0x128584C")]
		private Vector2 ApplyDeadZones(Vector2 pos, float deadZoneX, float deadZoneY)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1287108", Offset = "0x1287108", VA = "0x1287108")]
		private void onDeviceChanged(UnityEngine.XR.InputDevice inputDevice)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1284788", Offset = "0x1284788", VA = "0x1284788")]
		private void setDeviceProperties()
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x1287130", Offset = "0x1287130", VA = "0x1287130", Slot = "14")]
		public virtual bool GetSupportsIndexTouch()
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x1287138", Offset = "0x1287138", VA = "0x1287138", Slot = "15")]
		public virtual SDKProvider GetLoadedSDK()
		{
			return default(SDKProvider);
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x12871E0", Offset = "0x12871E0", VA = "0x12871E0", Slot = "16")]
		public virtual bool GetSupportsThumbTouch()
		{
			return default(bool);
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x12871E8", Offset = "0x12871E8", VA = "0x12871E8", Slot = "17")]
		public virtual bool GetIsOculusDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x12872A4", Offset = "0x12872A4", VA = "0x12872A4", Slot = "18")]
		public virtual bool GetIsOculusQuest()
		{
			return default(bool);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x12873AC", Offset = "0x12873AC", VA = "0x12873AC", Slot = "19")]
		public virtual bool GetIsHTCDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x128743C", Offset = "0x128743C", VA = "0x128743C", Slot = "20")]
		public virtual bool GetIsPicoDevice()
		{
			return default(bool);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1286D3C", Offset = "0x1286D3C", VA = "0x1286D3C")]
		public UnityEngine.XR.InputDevice GetHMD()
		{
			return default(UnityEngine.XR.InputDevice);
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x12874B0", Offset = "0x12874B0", VA = "0x12874B0")]
		public string GetHMDName()
		{
			return null;
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x12874D8", Offset = "0x12874D8", VA = "0x12874D8")]
		public Vector3 GetHMDLocalPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1287564", Offset = "0x1287564", VA = "0x1287564")]
		public Quaternion GetHMDLocalRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1285644", Offset = "0x1285644", VA = "0x1285644")]
		public UnityEngine.XR.InputDevice GetLeftController()
		{
			return default(UnityEngine.XR.InputDevice);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1285714", Offset = "0x1285714", VA = "0x1285714")]
		public UnityEngine.XR.InputDevice GetRightController()
		{
			return default(UnityEngine.XR.InputDevice);
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x12875EC", Offset = "0x12875EC", VA = "0x12875EC")]
		public Vector3 GetControllerLocalPosition(ControllerHand handSide)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x12876D4", Offset = "0x12876D4", VA = "0x12876D4")]
		public Quaternion GetControllerLocalRotation(ControllerHand handSide)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x12877B0", Offset = "0x12877B0", VA = "0x12877B0", Slot = "21")]
		public virtual ControllerType GetControllerType()
		{
			return default(ControllerType);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x12877E4", Offset = "0x12877E4", VA = "0x12877E4")]
		public Vector3 GetControllerVelocity(ControllerHand hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x127962C", Offset = "0x127962C", VA = "0x127962C")]
		public Vector3 GetControllerAngularVelocity(ControllerHand hand)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x12878C0", Offset = "0x12878C0", VA = "0x12878C0", Slot = "22")]
		public virtual string GetControllerName()
		{
			return null;
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1287A18", Offset = "0x1287A18", VA = "0x1287A18", Slot = "23")]
		public virtual bool GetIsValveIndexController()
		{
			return default(bool);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x128586C", Offset = "0x128586C", VA = "0x128586C")]
		private float getFeatureUsage(UnityEngine.XR.InputDevice device, InputFeatureUsage<float> usage, bool clamp = true)
		{
			return default(float);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x12857E4", Offset = "0x12857E4", VA = "0x12857E4")]
		private bool getFeatureUsage(UnityEngine.XR.InputDevice device, InputFeatureUsage<bool> usage)
		{
			return default(bool);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1285818", Offset = "0x1285818", VA = "0x1285818")]
		private Vector2 getFeatureUsage(UnityEngine.XR.InputDevice device, InputFeatureUsage<Vector2> usage)
		{
			return default(Vector2);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1287884", Offset = "0x1287884", VA = "0x1287884")]
		private Vector3 getFeatureUsage(UnityEngine.XR.InputDevice device, InputFeatureUsage<Vector3> usage)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1287B18", Offset = "0x1287B18", VA = "0x1287B18", Slot = "24")]
		public virtual void SetTrackingOriginMode(TrackingOriginModeFlags trackingOrigin)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1287B38", Offset = "0x1287B38", VA = "0x1287B38")]
		[IteratorStateMachine(typeof(<changeOriginModeRoutine>d__167))]
		private IEnumerator changeOriginModeRoutine(TrackingOriginModeFlags trackingOrigin)
		{
			return null;
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1284144", Offset = "0x1284144", VA = "0x1284144")]
		public void VibrateController(float frequency, float amplitude, float duration, ControllerHand hand)
		{
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1287BB0", Offset = "0x1287BB0", VA = "0x1287BB0")]
		[IteratorStateMachine(typeof(<Vibrate>d__169))]
		private IEnumerator Vibrate(float frequency, float amplitude, float duration, ControllerHand hand)
		{
			return null;
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1287C20", Offset = "0x1287C20", VA = "0x1287C20")]
		public InputBridge()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class JoystickControl : MonoBehaviour
	{
		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Any values below this threshold will not be passed to events")]
		[Header("Deadzone")]
		public float DeadZone;

		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MinDegrees;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaxDegrees;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float LeverPercentageX;

		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float LeverPercentageY;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector2 LeverVector;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool UseSmoothLook;

		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float SmoothLookSpeed;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public bool KinematicWhileInactive;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FloatFloatEvent onJoystickChange;

		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2Event onJoystickVectorChange;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Grabbable grab;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rb;

		[Token(Token = "0x4000592")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentRotation;

		[Token(Token = "0x4000593")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float angleX;

		[Token(Token = "0x4000594")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angleY;

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x12A02A0", Offset = "0x12A02A0", VA = "0x12A02A0")]
		private void Start()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x12A031C", Offset = "0x12A031C", VA = "0x12A031C")]
		private void Update()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x12A0B28", Offset = "0x12A0B28", VA = "0x12A0B28")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x12A0644", Offset = "0x12A0644", VA = "0x12A0644")]
		private void doJoystickLook()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x12A0BD4", Offset = "0x12A0BD4", VA = "0x12A0BD4", Slot = "4")]
		public virtual void OnJoystickChange(float leverX, float leverY)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x12A0C48", Offset = "0x12A0C48", VA = "0x12A0C48", Slot = "5")]
		public virtual void OnJoystickChange(Vector2 joystickVector)
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x12A0CBC", Offset = "0x12A0CBC", VA = "0x12A0CBC")]
		public JoystickControl()
		{
		}
	}
	[Token(Token = "0x20000B5")]
	public class JoystickVehicleControl : MonoBehaviour
	{
		[Token(Token = "0x4000595")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Grab Object")]
		public Grabbable JoystickGrabbable;

		[Token(Token = "0x4000596")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Set to True to Lerp towards the held hand. Set to False for Instant movement")]
		[Header("Movement Speed")]
		public bool UseSmoothLook;

		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SmoothLookSpeed;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Hinge X")]
		public Transform HingeXTransform;

		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float MinXAngle;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxXAngle;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Hinge Y")]
		public Transform HingeYTransform;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MinYAngle;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MaxYAngle;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Return To Center")]
		[Tooltip("How fast to return to center if nothing is holding the Joystick. Set to 0 if you do not wish to Return to Center")]
		public float ReturnToCenterSpeed;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Any values below this threshold will not be passed to events")]
		[Header("Deadzone")]
		public float DeadZone;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public FloatFloatEvent onJoystickChange;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector2Event onJoystickVectorChange;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Shown for Debug : ")]
		public float LeverPercentageX;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float LeverPercentageY;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Vector2 LeverVector;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float angleX;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float angleY;

		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Quaternion originalRot;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x12A0CE8", Offset = "0x12A0CE8", VA = "0x12A0CE8")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x12A12A4", Offset = "0x12A12A4", VA = "0x12A12A4", Slot = "4")]
		public virtual void CallJoystickEvents()
		{
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x12A13E0", Offset = "0x12A13E0", VA = "0x12A13E0", Slot = "5")]
		public virtual void OnJoystickChange(float leverX, float leverY)
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x12A1454", Offset = "0x12A1454", VA = "0x12A1454", Slot = "6")]
		public virtual void OnJoystickChange(Vector2 joystickVector)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x12A14C8", Offset = "0x12A14C8", VA = "0x12A14C8")]
		public JoystickVehicleControl()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	public class Lever : MonoBehaviour
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Rotation Limits")]
		[Tooltip("Minimum X value in Local Euler Angles")]
		public float MinimumXRotation;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Maximum X value in Local Euler Angles")]
		public float MaximumXRotation;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Initial Rotation")]
		public float InitialXRotation;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Audio")]
		public AudioClip SwitchOnSound;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip SwitchOffSound;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Tolerance before considering a switch flipped On or Off. Ex : 1.25 Tolerance means switch can be 98.25% up and considered switched on, or 1.25% down to be considered switched off.")]
		[Header("Tolerance")]
		public float SwitchTolerance;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("If true the lever will lerp towards the Grabber. If false the lever will instantly point to the grabber")]
		[Header("Smooth Look")]
		public bool UseSmoothLook;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The speed at which to Lerp towards the Grabber if UseSmoothLook is enabled")]
		public float SmoothLookSpeed;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("If false, the lever's rigidbody will be kinematic when not being held. Disable this if you don't want your lever to interact with physics or if you need moving platform support.")]
		[Header("Moving Platform Support")]
		public bool AllowPhysicsForces;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Tooltip("If ReturnToCenter true and KinematicWhileInactive true then the lever will smooth look back to center when not being held")]
		[Header("Return to Center (Must be Kinematic)")]
		public bool ReturnToCenter;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("How fast to return to center if not being held")]
		public float ReturnLookSpeed;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("If true the lever will look directly at the Grabber and not factor in an initial offset")]
		[Header("Snap Settings")]
		public bool SnapToGrabber;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		[Header("Misc")]
		[Tooltip("If true, the Lever will be dropped once switched on or off")]
		public bool DropLeverOnActivation;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Current position of the lever as expressed as a percentage 1-100")]
		[Header("Shown for Debug")]
		public float LeverPercentage;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true will show an angle helper in editor mode (Gizmos must be enabled)")]
		public bool ShowEditorGizmos;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Events")]
		[Tooltip("Called when lever was up, but is now in the down position")]
		public UnityEvent onLeverDown;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Called when lever was down, but is now in the up position")]
		public UnityEvent onLeverUp;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Called if the lever changes position at all")]
		public FloatEvent onLeverChange;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Grabbable grab;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody rb;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AudioSource audioSource;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool switchedOn;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ConfigurableJoint configJoint;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private HingeJoint hingedJoint;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 _lastLocalAngle;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Quaternion initialOffset;

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x12A1544", Offset = "0x12A1544", VA = "0x12A1544")]
		private void Start()
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x12A16FC", Offset = "0x12A16FC", VA = "0x12A16FC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x12A172C", Offset = "0x12A172C", VA = "0x12A172C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x12A1978", Offset = "0x12A1978", VA = "0x12A1978", Slot = "4")]
		public virtual float GetAnglePercentage(float currentAngle)
		{
			return default(float);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x12A1B18", Offset = "0x12A1B18", VA = "0x12A1B18")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x12A1B1C", Offset = "0x12A1B1C", VA = "0x12A1B1C")]
		private void doLeverLook()
		{
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x12A2090", Offset = "0x12A2090", VA = "0x12A2090", Slot = "5")]
		public virtual void SetLeverAngle(float angle)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x12A20DC", Offset = "0x12A20DC", VA = "0x12A20DC", Slot = "6")]
		public virtual void OnLeverChange(float percentage)
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x12A2148", Offset = "0x12A2148", VA = "0x12A2148", Slot = "7")]
		public virtual void OnLeverDown()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x12A2244", Offset = "0x12A2244", VA = "0x12A2244", Slot = "8")]
		public virtual void OnLeverUp()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x12A2344", Offset = "0x12A2344", VA = "0x12A2344")]
		public Lever()
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class LocomotionManager : MonoBehaviour
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Locomotion Type")]
		[Tooltip("Default locomotion to use if nothing stored in playerprefs. 0 = Teleport. 1 = SmoothLocomotion")]
		public LocomotionType DefaultLocomotion;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private LocomotionType selectedLocomotion;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Save / Loading")]
		[Tooltip("If true, locomotion type will be saved and loaded from player prefs")]
		public bool LoadLocomotionFromPrefs;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Input")]
		public List<ControllerBinding> locomotionToggleInput;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The action used to toggle locomotion type")]
		public InputActionReference LocomotionToggleAction;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BNGPlayerController player;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PlayerTeleport teleport;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool actionToggle;

		[Token(Token = "0x17000046")]
		public LocomotionType SelectedLocomotion
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x12A23D0", Offset = "0x12A23D0", VA = "0x12A23D0")]
			get
			{
				return default(LocomotionType);
			}
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x12A23D8", Offset = "0x12A23D8", VA = "0x12A23D8")]
		private void Start()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x12A2510", Offset = "0x12A2510", VA = "0x12A2510")]
		private void Update()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x12A253C", Offset = "0x12A253C", VA = "0x12A253C", Slot = "4")]
		public virtual void CheckControllerToggleInput()
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x12A2690", Offset = "0x12A2690", VA = "0x12A2690")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x12A2790", Offset = "0x12A2790", VA = "0x12A2790")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x12A2890", Offset = "0x12A2890", VA = "0x12A2890")]
		public void OnLocomotionToggle(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x12A266C", Offset = "0x12A266C", VA = "0x12A266C")]
		public void LocomotionToggle()
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x12A289C", Offset = "0x12A289C", VA = "0x12A289C")]
		public void UpdateTeleportStatus()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x12A2498", Offset = "0x12A2498", VA = "0x12A2498")]
		public void ChangeLocomotion(LocomotionType locomotionType, bool save)
		{
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x12A28C8", Offset = "0x12A28C8", VA = "0x12A28C8")]
		public void ChangeLocomotionType(LocomotionType loc)
		{
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x12A29D4", Offset = "0x12A29D4", VA = "0x12A29D4")]
		private void toggleTeleport(bool enabled)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x12A2A10", Offset = "0x12A2A10", VA = "0x12A2A10")]
		private void toggleSmoothLocomotion(bool enabled)
		{
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x12A2AC4", Offset = "0x12A2AC4", VA = "0x12A2AC4")]
		public void ToggleLocomotionType()
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x12A2AD4", Offset = "0x12A2AD4", VA = "0x12A2AD4")]
		public LocomotionManager()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public class PlayerClimbing : MonoBehaviour
	{
		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Climbing Transforms")]
		public Transform LeftControllerTransform;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform RightControllerTransform;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Set the player's capsule collider height to this amount while climbing. This can allow you to shorten the capsule collider a bit, making it easier to navigate over ledges.")]
		[Header("Capsule Settings")]
		public float ClimbingCapsuleHeight;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Set the player's capsule collider capsule center to this amount while climbing.")]
		public float ClimbingCapsuleCenter;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Haptics")]
		public bool ApplyHapticsOnGrab;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Frequency of haptics to play on grab if 'ApplyHapticsOnGrab' is true")]
		public float VibrateFrequency;

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Amplitute of haptics to play on grab if 'ApplyHapticsOnGrab' is true")]
		public float VibrateAmplitude;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Duration of haptics to play on grab if 'ApplyHapticsOnGrab' is true")]
		public float VibrateDuration;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Grabber> climbers;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool wasGrippingClimbable;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CharacterController characterController;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PlayerGravity playerGravity;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Rigidbody playerRigid;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _checkedRigidPlayer;

		[Token(Token = "0x40005DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool _isRigidPlayer;

		[Token(Token = "0x40005DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		[Header("Shown for Debug : ")]
		public bool GrippingClimbable;

		[Token(Token = "0x40005DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 moveDirection;

		[Token(Token = "0x40005DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 previousLeftControllerPosition;

		[Token(Token = "0x40005DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 previousRightControllerPosition;

		[Token(Token = "0x40005DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 controllerMoveAmount;

		[Token(Token = "0x17000047")]
		public bool IsRigidbodyPlayer
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x12A2BBC", Offset = "0x12A2BBC", VA = "0x12A2BBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x12A2C68", Offset = "0x12A2C68", VA = "0x12A2C68")]
		public void Start()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x12A2D7C", Offset = "0x12A2D7C", VA = "0x12A2D7C")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x12A2E50", Offset = "0x12A2E50", VA = "0x12A2E50", Slot = "4")]
		public virtual void AddClimber(Climbable climbable, Grabber grab)
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x12A318C", Offset = "0x12A318C", VA = "0x12A318C", Slot = "5")]
		public virtual void RemoveClimber(Grabber grab)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x12A329C", Offset = "0x12A329C", VA = "0x12A329C", Slot = "6")]
		public virtual bool GrippingAtLeastOneClimbable()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x12A33F4", Offset = "0x12A33F4", VA = "0x12A33F4", Slot = "7")]
		protected virtual void checkClimbing()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x12A3980", Offset = "0x12A3980", VA = "0x12A3980")]
		private void DoPhysicalClimbing()
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x12A3800", Offset = "0x12A3800", VA = "0x12A3800")]
		private void onGrabbedClimbable()
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x12A38BC", Offset = "0x12A38BC", VA = "0x12A38BC")]
		private void onReleasedClimbable()
		{
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x12A3D34", Offset = "0x12A3D34", VA = "0x12A3D34")]
		public PlayerClimbing()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	public class PlayerGravity : MonoBehaviour
	{
		[Token(Token = "0x40005E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will apply gravity to the CharacterController component, or RigidBody if no CC is present.")]
		public bool GravityEnabled;

		[Token(Token = "0x40005E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Amount of Gravity to apply to the CharacterController or Rigidbody. Default is 'Physics.gravity'.")]
		public Vector3 Gravity;

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private CharacterController characterController;

		[Token(Token = "0x40005E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x40005E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody playerRigidbody;

		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _movementY;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _initialGravityModifier;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _validRigidBody;

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x12A3DBC", Offset = "0x12A3DBC", VA = "0x12A3DBC")]
		private void Start()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x12A3EB4", Offset = "0x12A3EB4", VA = "0x12A3EB4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x12A402C", Offset = "0x12A402C", VA = "0x12A402C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x12A3CBC", Offset = "0x12A3CBC", VA = "0x12A3CBC")]
		public void ToggleGravity(bool gravityOn)
		{
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x12A4104", Offset = "0x12A4104", VA = "0x12A4104")]
		public PlayerGravity()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	public class PlayerMovingPlatformSupport : MonoBehaviour
	{
		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Ground checks : ")]
		[Tooltip("Raycast against these layers to check if player is on a moving platform")]
		public LayerMask GroundedLayers;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected RaycastHit groundHit;

		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CharacterController characterController;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _initialCharacterParent;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float DistanceFromGround;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public MovingPlatform CurrentPlatform;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool wasOnPlatform;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool requiresReparent;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x12A4134", Offset = "0x12A4134", VA = "0x12A4134")]
		private void Start()
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x12A41D0", Offset = "0x12A41D0", VA = "0x12A41D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x12A41DC", Offset = "0x12A41DC", VA = "0x12A41DC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x12A41E8", Offset = "0x12A41E8", VA = "0x12A41E8", Slot = "4")]
		public virtual void CheckMovingPlatform()
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x12A4598", Offset = "0x12A4598", VA = "0x12A4598", Slot = "5")]
		public virtual void UpdateDistanceFromGround()
		{
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x12A498C", Offset = "0x12A498C", VA = "0x12A498C")]
		public PlayerMovingPlatformSupport()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	public enum RotationMechanic
	{
		[Token(Token = "0x40005F2")]
		Snap,
		[Token(Token = "0x40005F3")]
		Smooth
	}
	[Token(Token = "0x20000BC")]
	public class PlayerRotation : MonoBehaviour
	{
		[Token(Token = "0x20000BD")]
		public delegate void OnBeforeRotateAction();

		[Token(Token = "0x20000BE")]
		public delegate void OnAfterRotateAction();

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Set to false to skip Update")]
		[Header("Input")]
		public bool AllowInput;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Used to determine whether to turn left / right. This can be an X Axis on the thumbstick, for example. -1 to snap left, 1 to snap right.")]
		public List<InputAxis> inputAxis;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Unity Input Action used to rotate the player")]
		public InputActionReference RotateAction;

		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Snap rotation will rotate a fixed amount of degrees on turn. Smooth will linearly rotate the player.")]
		[Header("Smooth / Snap Turning")]
		public RotationMechanic RotationType;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("How many degrees to rotate if RotationType is set to 'Snap'")]
		[Header("Snap Turn Settings")]
		public float SnapRotationAmount;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Thumbstick X axis must be >= this amount to be considered an input event")]
		public float SnapInputAmount;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Header("Smooth Turn Settings")]
		[Tooltip("How fast to rotate the player if RotationType is set to 'Smooth'")]
		public float SmoothTurnSpeed;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Thumbstick X axis must be >= this amount to be considered an input event")]
		public float SmoothTurnMinInput;

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float recentSnapTurnTime;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float rotationAmount;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float xAxis;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float previousXInput;

		[Token(Token = "0x14000003")]
		public static event OnBeforeRotateAction OnBeforeRotate
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x12A4994", Offset = "0x12A4994", VA = "0x12A4994")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x12A4A4C", Offset = "0x12A4A4C", VA = "0x12A4A4C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000004")]
		public static event OnAfterRotateAction OnAfterRotate
		{
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x12A4B04", Offset = "0x12A4B04", VA = "0x12A4B04")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x12A4BC0", Offset = "0x12A4BC0", VA = "0x12A4BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x12A4C7C", Offset = "0x12A4C7C", VA = "0x12A4C7C")]
		private void Update()
		{
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x12A4CD8", Offset = "0x12A4CD8", VA = "0x12A4CD8", Slot = "4")]
		public virtual float GetAxisInput()
		{
			return default(float);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x12A4E70", Offset = "0x12A4E70", VA = "0x12A4E70", Slot = "5")]
		public virtual void DoSnapRotation(float xInput)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x12A504C", Offset = "0x12A504C", VA = "0x12A504C", Slot = "6")]
		public virtual bool RecentlySnapTurned()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x12A507C", Offset = "0x12A507C", VA = "0x12A507C", Slot = "7")]
		public virtual void DoSmoothRotation(float xInput)
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x12A5178", Offset = "0x12A5178", VA = "0x12A5178")]
		public PlayerRotation()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public enum TeleportControls
	{
		[Token(Token = "0x4000603")]
		ThumbstickRotate,
		[Token(Token = "0x4000604")]
		ThumbstickDown,
		[Token(Token = "0x4000605")]
		BButton,
		[Token(Token = "0x4000606")]
		None
	}
	[Token(Token = "0x20000C0")]
	public class PlayerTeleport : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		public delegate void OnBeforeTeleportFadeAction();

		[Token(Token = "0x20000C2")]
		public delegate void OnBeforeTeleportAction();

		[Token(Token = "0x20000C3")]
		public delegate void OnAfterTeleportAction();

		[Token(Token = "0x20000C4")]
		[CompilerGenerated]
		private sealed class <doTeleport>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlayerTeleport <>4__this;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 playerDestination;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public bool rotatePlayer;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion playerRotation;

			[Token(Token = "0x1700004A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x12A8204", Offset = "0x12A8204", VA = "0x12A8204", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700004B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000418")]
				[Address(RVA = "0x12A824C", Offset = "0x12A824C", VA = "0x12A824C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x12A74EC", Offset = "0x12A74EC", VA = "0x12A74EC")]
			[DebuggerHidden]
			public <doTeleport>d__81(int <>1__state)
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x12A7E3C", Offset = "0x12A7E3C", VA = "0x12A7E3C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x12A7E40", Offset = "0x12A7E40", VA = "0x12A7E40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000417")]
			[Address(RVA = "0x12A820C", Offset = "0x12A820C", VA = "0x12A820C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The LineRenderer to use when showing a teleport preview")]
		[Header("Colors")]
		public LineRenderer TeleportLine;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If a Valid Teleport destination is found, color of 'TeleportLine' will be updated to this.")]
		public Color ValidTeleport;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If a Valid Teleport destination is not found, color of 'TeleportLine' will be updated to this.")]
		public Color InvalidTeleport;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Hand Side")]
		[Tooltip("Whether the Teleport should initiate from the left or right controller. This affects input and where the teleport line should begin from.")]
		public ControllerHand HandSide;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Transform Definitions")]
		[Tooltip("Where the Teleport Line should begin if using the left ControllerHand")]
		public Transform TeleportBeginTransform;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Where the Teleport Line should begin if using the right ControllerHand")]
		public Transform TeleportBeginTransformAlt;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Transform indicating where Player should be placed on teleport.")]
		public Transform TeleportDestination;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[Tooltip("The TeleportDestination if we are hitting one. Null if not.")]
		public TeleportDestination DestinationObject;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("GameObject to move around when initiating a teleport.")]
		public GameObject TeleportMarker;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Transform indicating direction Player will rotate to on teleport.")]
		public Transform DirectionIndicator;

		[Token(Token = "0x4000611")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Header("Teleport Physics")]
		public float MaxRange;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("More segments means a smoother line, at the cost of performance.")]
		public int SegmentCount;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("How much velocity to apply when calculating a parabola. Set to a very high number for a straight line.")]
		public float SimulationVelocity;

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Tooltip("Scale of each segment used when calculating parabola")]
		public float SegmentScale;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("Layers")]
		[Tooltip("Raycast layers to use when determining collision")]
		public LayerMask CollisionLayers;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Tooltip("Raycast layers to use when determining if the collided object is a valid teleport. If it is not valid then the line will be red and unable to teleport.")]
		public LayerMask ValidLayers;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Method used to initiate a teleport. If these don't fit your needs you can override the KeyDownForTeleport() and KeyUpFromTeleport() methods.")]
		[Header("Controls")]
		public TeleportControls ControlType;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Unity Input Action used to initiate Teleport")]
		public InputActionReference InitiateTeleportAction;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("If true the user can rotate the teleport marker before initiating a teleport.")]
		public bool AllowTeleportRotation;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
		private bool _reachThumbThreshold;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA2")]
		[Tooltip("If true the teleport marker will always be the same rotation as the player")]
		public bool ForceStraightArrow;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[Header("Slope")]
		[Tooltip("Max Angle / Slope the teleport marker can be to be considered a valid teleport.")]
		public float MaxSlope;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Offset")]
		[Tooltip("Offset the player's Y position from TeleportDestination")]
		public float TeleportYOffset;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Screen Fade")]
		[Tooltip("Use ScreenFader on teleportation if true.")]
		public bool FadeScreenOnTeleport;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("If FadeScreenOnTeleport = true, fade the screen at this speed.")]
		public float TeleportFadeSpeed;

		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Tooltip("Seconds to wait before initiating teleport. Useful if you want to fade the screen  before teleporting.")]
		public float TeleportDelay;

		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("Physics Material to apply to the sphere collider when no controls are being issued.")]
		[Header("Physics Material")]
		public PhysicMaterial FrictionMaterial;

		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CharacterController controller;

		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private BNGPlayerController playerController;

		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Rigidbody playerRigid;

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private InputBridge input;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Transform cameraRig;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private ScreenFader fader;

		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool aimingTeleport;

		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF1")]
		private bool validTeleport;

		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF2")]
		private bool teleportationEnabled;

		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private int _invalidFrames;

		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float _initialLineWidth;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool setVariables;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Collider _hitObject;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 _hitVector;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float _hitAngle;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private RaycastHit hit;

		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3[] segments;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3 segVelocity;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float segTime;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int segCount;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private bool isDestination;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector2 teleportAxis;

		[Token(Token = "0x17000048")]
		private Transform teleportTransform
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x12A5470", Offset = "0x12A5470", VA = "0x12A5470")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private Vector2 handedThumbstickAxis
		{
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x12A548C", Offset = "0x12A548C", VA = "0x12A548C")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x14000005")]
		public static event OnBeforeTeleportFadeAction OnBeforeTeleportFade
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x12A54CC", Offset = "0x12A54CC", VA = "0x12A54CC")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x12A5584", Offset = "0x12A5584", VA = "0x12A5584")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public static event OnBeforeTeleportAction OnBeforeTeleport
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x12A563C", Offset = "0x12A563C", VA = "0x12A563C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0x12A56F8", Offset = "0x12A56F8", VA = "0x12A56F8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000007")]
		public static event OnAfterTeleportAction OnAfterTeleport
		{
			[Token(Token = "0x60003ED")]
			[Address(RVA = "0x12A57B4", Offset = "0x12A57B4", VA = "0x12A57B4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60003EE")]
			[Address(RVA = "0x12A5870", Offset = "0x12A5870", VA = "0x12A5870")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x12A592C", Offset = "0x12A592C", VA = "0x12A592C")]
		private void Start()
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x12A5C40", Offset = "0x12A5C40", VA = "0x12A5C40")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x12A5930", Offset = "0x12A5930", VA = "0x12A5930")]
		private void setupVariables()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x12A5D28", Offset = "0x12A5D28", VA = "0x12A5D28")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x12A5DB4", Offset = "0x12A5DB4", VA = "0x12A5DB4")]
		public void DoCheckTeleport()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x12A5EB8", Offset = "0x12A5EB8", VA = "0x12A5EB8")]
		public void TryOrHideTeleport()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x12A2AA4", Offset = "0x12A2AA4", VA = "0x12A2AA4")]
		public void EnableTeleportation()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x12A2AB0", Offset = "0x12A2AB0", VA = "0x12A2AB0")]
		public void DisableTeleportation()
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x12A5ED4", Offset = "0x12A5ED4", VA = "0x12A5ED4", Slot = "4")]
		protected virtual void calculateParabola()
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x12A6934", Offset = "0x12A6934", VA = "0x12A6934", Slot = "5")]
		protected virtual bool teleportClear()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x12A6B8C", Offset = "0x12A6B8C", VA = "0x12A6B8C", Slot = "6")]
		protected virtual void hideTeleport()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x12A6BE0", Offset = "0x12A6BE0", VA = "0x12A6BE0", Slot = "7")]
		protected virtual void updateTeleport()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x12A6C38", Offset = "0x12A6C38", VA = "0x12A6C38", Slot = "8")]
		protected virtual void rotateMarker()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x12A6FB4", Offset = "0x12A6FB4", VA = "0x12A6FB4", Slot = "9")]
		protected virtual void tryTeleport()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x12A7260", Offset = "0x12A7260", VA = "0x12A7260", Slot = "10")]
		public virtual void BeforeTeleportFade()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x12A7328", Offset = "0x12A7328", VA = "0x12A7328", Slot = "11")]
		public virtual void BeforeTeleport()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x12A73F0", Offset = "0x12A73F0", VA = "0x12A73F0", Slot = "12")]
		public virtual void AfterTeleport()
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x12A7198", Offset = "0x12A7198", VA = "0x12A7198")]
		[IteratorStateMachine(typeof(<doTeleport>d__81))]
		private IEnumerator doTeleport(Vector3 playerDestination, Quaternion playerRotation, bool rotatePlayer)
		{
			return null;
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x12A7514", Offset = "0x12A7514", VA = "0x12A7514")]
		public void TeleportPlayer(Vector3 destination, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x12A7538", Offset = "0x12A7538", VA = "0x12A7538")]
		public void TeleportPlayerToTransform(Transform destination)
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x12A75D4", Offset = "0x12A75D4", VA = "0x12A75D4", Slot = "13")]
		public virtual bool KeyDownForTeleport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x12A78A4", Offset = "0x12A78A4", VA = "0x12A78A4", Slot = "14")]
		public virtual bool KeyUpFromTeleport()
		{
			return default(bool);
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x12A7994", Offset = "0x12A7994", VA = "0x12A7994")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x12A7AA0", Offset = "0x12A7AA0", VA = "0x12A7AA0")]
		public PlayerTeleport()
		{
		}
	}
	[Token(Token = "0x20000C5")]
	public class PointerEvents : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Maximium Distance")]
		[Tooltip("Maximum Distance this object can be from the UIPointer to be considered valid and receive events")]
		public float MaxDistance;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("Enable Events")]
		[Tooltip("If True then the Unity Events below will be sent. Set to False if you need to disable sending pointer events.")]
		public bool Enabled;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Unity Events : ")]
		public PointerEventDataEvent OnPointerClickEvent;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PointerEventDataEvent OnPointerEnterEvent;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PointerEventDataEvent OnPointerExitEvent;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PointerEventDataEvent OnPointerDownEvent;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public PointerEventDataEvent OnPointerUpEvent;

		[Token(Token = "0x6000419")]
		[Address(RVA = "0x12A8254", Offset = "0x12A8254", VA = "0x12A8254", Slot = "9")]
		public virtual void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x12A82D0", Offset = "0x12A82D0", VA = "0x12A82D0", Slot = "10")]
		public virtual void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041B")]
		[Address(RVA = "0x12A834C", Offset = "0x12A834C", VA = "0x12A834C", Slot = "11")]
		public virtual void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0x12A83AC", Offset = "0x12A83AC", VA = "0x12A83AC", Slot = "12")]
		public virtual void OnPointerDown(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x12A8428", Offset = "0x12A8428", VA = "0x12A8428", Slot = "13")]
		public virtual void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0x12A8488", Offset = "0x12A8488", VA = "0x12A8488", Slot = "14")]
		public virtual bool DistanceExceeded(PointerEventData eventData)
		{
			return default(bool);
		}

		[Token(Token = "0x600041F")]
		[Address(RVA = "0x12A84A8", Offset = "0x12A84A8", VA = "0x12A84A8")]
		public PointerEvents()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public enum RemoteGrabType
	{
		[Token(Token = "0x4000649")]
		Trigger,
		[Token(Token = "0x400064A")]
		Raycast,
		[Token(Token = "0x400064B")]
		Spherecast
	}
	[Token(Token = "0x20000C7")]
	public class RemoteGrabber : MonoBehaviour
	{
		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RemoteGrabType PhysicsCheckType;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float RaycastLength;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float SphereCastLength;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float SphereCastRadius;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask RemoteGrabLayers;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrabbablesInTrigger ParentGrabber;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider _lastColliderHit;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool ShowGizmos;

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x12A84C0", Offset = "0x12A84C0", VA = "0x12A84C0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x12A85A0", Offset = "0x12A85A0", VA = "0x12A85A0", Slot = "4")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x12A87C8", Offset = "0x12A87C8", VA = "0x12A87C8")]
		private void ObjectHit(Collider colliderHit)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x12A8938", Offset = "0x12A8938", VA = "0x12A8938")]
		public void RemovePreviousHitObject()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x12A8A54", Offset = "0x12A8A54", VA = "0x12A8A54")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x12A8C24", Offset = "0x12A8C24", VA = "0x12A8C24")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x12A8DD4", Offset = "0x12A8DD4", VA = "0x12A8DD4")]
		public RemoteGrabber()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	public class Slider : MonoBehaviour
	{
		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float _slidePercentage;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FloatEvent onSliderChange;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastSliderPercentage;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float slideRangeLow;

		[Token(Token = "0x4000658")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float slideRangeHigh;

		[Token(Token = "0x4000659")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float slideRange;

		[Token(Token = "0x1700004C")]
		public float SlidePercentage
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0x12A8E18", Offset = "0x12A8E18", VA = "0x12A8E18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x12A8E20", Offset = "0x12A8E20", VA = "0x12A8E20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x12A8F28", Offset = "0x12A8F28", VA = "0x12A8F28")]
		private void Update()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x12A8FA8", Offset = "0x12A8FA8", VA = "0x12A8FA8", Slot = "4")]
		public virtual void OnSliderChange(float percentage)
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x12A9014", Offset = "0x12A9014", VA = "0x12A9014")]
		public Slider()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	public enum MovementVector
	{
		[Token(Token = "0x400065B")]
		HMD,
		[Token(Token = "0x400065C")]
		Controller
	}
	[Token(Token = "0x20000CA")]
	public class SmoothLocomotion : MonoBehaviour
	{
		[Token(Token = "0x20000CB")]
		public delegate void OnBeforeMoveAction();

		[Token(Token = "0x20000CC")]
		public delegate void OnAfterMoveAction();

		[Token(Token = "0x400065D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PlayerControllerType ControllerType;

		[Token(Token = "0x400065E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Header("CharacterController Settings : ")]
		public float MovementSpeed;

		[Token(Token = "0x400065F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How much force to apply to the rigidbody when the player is grounded")]
		[Header("Rigidbody Settings : ")]
		public float MovementForce;

		[Token(Token = "0x4000660")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Maximium velocity of the player's rigidbody in X, Z. Used to constrain max speed movement.")]
		public float MaxHorizontalVelocity;

		[Token(Token = "0x4000661")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Maximium velocity of the player's rigidbody on the Y axis. Used to constrain max vertical movement, such as jumping and falling.")]
		public float MaxVerticalVelocity;

		[Token(Token = "0x4000662")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How far up from the characters feet is considered a step. Anything below this will be considered grounded.")]
		public float StepHeight;

		[Token(Token = "0x4000663")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Maximium angle a slope can be to be considered grounded. Negated if contact distance from the player's feet is less than StepHeight.")]
		public float MaxSlopeAngle;

		[Token(Token = "0x4000664")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Physics Material to apply to the sphere collider while moving. Use this to dynamically adjust friction and bounciness.")]
		public PhysicMaterial MovementMaterial;

		[Token(Token = "0x4000665")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Physics Material to apply to the sphere collider when no controls are being issues. Use this to slow t he player down, or allow them to slide across surfaces.")]
		public PhysicMaterial FrictionMaterial;

		[Token(Token = "0x4000666")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("How much drag to apply to the player while moving")]
		public float MovementDrag;

		[Token(Token = "0x4000667")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("How much drag to apply to the player while standing still. Used to slow down the player or prevent from sliding down a hill.")]
		public float StaticDrag;

		[Token(Token = "0x4000668")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much drag to apply to the player when in the air / not grounded.")]
		public float AirDrag;

		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("(Optional) If specified, this transform's forward direction will determine the movement direction ")]
		[Header("Forward Direction : ")]
		public Transform ForwardDirection;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Set to false if you do not want to respond to input commands. (For example, if paused or in a menu)")]
		[Header("Input : ")]
		public bool AllowInput;

		[Token(Token = "0x400066B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		[Tooltip("Set to false if you do not want SmoothLocomotion to update movement at all.")]
		[Header("Input : ")]
		public bool UpdateMovement;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Used to determine which direction to move. Example : Left Thumbstick Axis or Touchpad. ")]
		public List<InputAxis> inputAxis;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Input Action used to affect movement")]
		public InputActionReference MoveAction;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("If true, movement events will only be sent if the Application has focus (Or Play window, if running in the Unity Editor)")]
		public bool RequireAppFocus;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Header("Sprint : ")]
		public float SprintSpeed;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The key(s) to use to initiate sprint. You can also override the SprintKeyDown() function to determine your sprint criteria.")]
		public List<ControllerBinding> SprintInput;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Unity Input Action used to enable sprinting")]
		public InputActionReference SprintAction;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Header("Strafe : ")]
		public float StrafeSpeed;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float StrafeSprintSpeed;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Amount of 'force' to apply to the player during Jump")]
		[Header("Jump : ")]
		public float JumpForce;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("The key(s) to use to initiate a jump. You can also override the CheckJump() function to determine your jump criteria.")]
		public List<ControllerBinding> JumpInput;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("Unity Input Action used to initiate a jump")]
		public InputActionReference JumpAction;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Can the player move when not grounded? Set to true if you want to be able to move the joysticks and have the player respond to input even when not grounded.")]
		[Header("Air Control : ")]
		public bool AirControl;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Tooltip("How fast the player can move in the air if AirControl = true. Example : 0.5 = Player will move at half the speed of MovementSpeed")]
		public float AirControlSpeed;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private BNGPlayerController playerController;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private CharacterController characterController;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Rigidbody playerRigid;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private SphereCollider playerSphere;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private float movementX;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private float movementY;

		[Token(Token = "0x400067F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private float movementZ;

		[Token(Token = "0x4000680")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float _verticalSpeed;

		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 additionalMovement;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private bool playerInitialized;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float lastJumpTime;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private float lastMoveTime;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public float Magnitude;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[Header("Shown for Debug : ")]
		public int GroundContacts;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float SurfaceAngle;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float SurfaceHeight;

		[Token(Token = "0x14000008")]
		public static event OnBeforeMoveAction OnBeforeMove
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x12A9028", Offset = "0x12A9028", VA = "0x12A9028")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600042D")]
			[Address(RVA = "0x12A90E0", Offset = "0x12A90E0", VA = "0x12A90E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000009")]
		public static event OnAfterMoveAction OnAfterMove
		{
			[Token(Token = "0x600042E")]
			[Address(RVA = "0x12A9198", Offset = "0x12A9198", VA = "0x12A9198")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x12A9254", Offset = "0x12A9254", VA = "0x12A9254")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x12A9310", Offset = "0x12A9310", VA = "0x12A9310", Slot = "4")]
		public virtual void Update()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x12A9358", Offset = "0x12A9358", VA = "0x12A9358", Slot = "5")]
		public virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x12A9390", Offset = "0x12A9390", VA = "0x12A9390", Slot = "6")]
		public virtual void CheckControllerReferences()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x12A9530", Offset = "0x12A9530", VA = "0x12A9530", Slot = "7")]
		public virtual void UpdateInputs()
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x12A963C", Offset = "0x12A963C", VA = "0x12A963C", Slot = "8")]
		public virtual void DoRigidBodyJump()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x12A96D0", Offset = "0x12A96D0", VA = "0x12A96D0", Slot = "9")]
		public virtual Vector2 GetMovementAxis()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x12A9B14", Offset = "0x12A9B14", VA = "0x12A9B14", Slot = "10")]
		public virtual void MoveCharacter()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x12A9D18", Offset = "0x12A9D18", VA = "0x12A9D18", Slot = "11")]
		public virtual void MoveRigidCharacter(Vector3 moveTo)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x12A9D1C", Offset = "0x12A9D1C", VA = "0x12A9D1C", Slot = "12")]
		public virtual void MoveRigidCharacter()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x12AA1D4", Offset = "0x12AA1D4", VA = "0x12AA1D4", Slot = "13")]
		public virtual void MoveCharacter(Vector3 motion)
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x12AA4A0", Offset = "0x12AA4A0", VA = "0x12AA4A0", Slot = "14")]
		public virtual bool CheckJump()
		{
			return default(bool);
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x12AA620", Offset = "0x12AA620", VA = "0x12AA620", Slot = "15")]
		public virtual bool CheckSprint()
		{
			return default(bool);
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x12AA790", Offset = "0x12AA790", VA = "0x12AA790", Slot = "16")]
		public virtual bool IsGrounded()
		{
			return default(bool);
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x12AA820", Offset = "0x12AA820", VA = "0x12AA820", Slot = "17")]
		public virtual void SetupCharacterController()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x12AA9C0", Offset = "0x12AA9C0", VA = "0x12AA9C0", Slot = "18")]
		public virtual void SetupRigidbodyPlayer()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x12AAC2C", Offset = "0x12AAC2C", VA = "0x12AAC2C", Slot = "19")]
		public virtual void EnableMovement()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x12AAC38", Offset = "0x12AAC38", VA = "0x12AAC38", Slot = "20")]
		public virtual void DisableMovement()
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x12AAC40", Offset = "0x12AAC40", VA = "0x12AAC40")]
		private void OnCollisionStay(Collision collisionInfo)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x12AAF58", Offset = "0x12AAF58", VA = "0x12AAF58")]
		public SmoothLocomotion()
		{
		}
	}
	[Token(Token = "0x20000CD")]
	public enum PlayerControllerType
	{
		[Token(Token = "0x400068C")]
		CharacterController,
		[Token(Token = "0x400068D")]
		Rigidbody
	}
	[Token(Token = "0x20000CE")]
	public class SnapZone : MonoBehaviour
	{
		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The currently held item. Set this in the editor to equip on Start().")]
		[Header("Starting / Held Item")]
		public Grabbable HeldItem;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("TSet this in the editor to equip on Start().")]
		public Grabbable StartingItem;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If false, Item will Move back to inventory space if player drops it.")]
		[Header("Options")]
		public bool CanDropItem;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("If false the snap zone cannot have it's content replaced.")]
		public bool CanSwapItem;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		[Tooltip("If false the snap zone cannot have it's content replaced.")]
		public bool CanRemoveItem;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Multiply Item Scale times this when in snap zone.")]
		public float ScaleItem;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float _scaleTo;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool DisableColliders;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Collider> disabledColliders;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("If true the item inside the SnapZone will be duplicated, instead of removed, from the SnapZone.")]
		public bool DuplicateItemOnGrab;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Only snap if Grabbable was dropped maximum of X seconds ago")]
		public float MaxDropTime;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public float LastSnapTime;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Filtering")]
		[Tooltip("If not empty, can only snap objects if transform name contains one of these strings")]
		public List<string> OnlyAllowNames;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Do not allow snapping if transform contains one of these names")]
		public List<string> ExcludeTransformNames;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Audio")]
		public AudioClip SoundOnSnap;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip SoundOnUnsnap;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Events")]
		public GrabbableEvent OnSnapEvent;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public GrabbableEvent OnDetachEvent;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GrabbablesInTrigger gZone;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rigidbody heldItemRigid;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool heldItemWasKinematic;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Grabbable trackedItem;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[HideInInspector]
		public Grabbable ClosestGrabbable;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private SnapZoneOffset offset;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x12AB3D4", Offset = "0x12AB3D4", VA = "0x12AB3D4")]
		private void Start()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x12ABAF8", Offset = "0x12ABAF8", VA = "0x12ABAF8")]
		private void Update()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x12ABE74", Offset = "0x12ABE74", VA = "0x12ABE74")]
		private Grabbable getClosestGrabbable()
		{
			return null;
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x12AB4F8", Offset = "0x12AB4F8", VA = "0x12AB4F8")]
		public void GrabGrabbable(Grabbable grab)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x12AC79C", Offset = "0x12AC79C", VA = "0x12AC79C")]
		private void disableGrabbable(Grabbable grab)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x12AC898", Offset = "0x12AC898", VA = "0x12AC898")]
		public void GrabEquipped(Grabber grabber)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x12ACBCC", Offset = "0x12ACBCC", VA = "0x12ACBCC", Slot = "4")]
		public virtual bool CanBeRemoved()
		{
			return default(bool);
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x12AC3B8", Offset = "0x12AC3B8", VA = "0x12AC3B8")]
		public void ReleaseAll()
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x12ACC28", Offset = "0x12ACC28", VA = "0x12ACC28")]
		public SnapZone()
		{
		}
	}
	[Token(Token = "0x20000CF")]
	public class SnapZoneOffset : MonoBehaviour
	{
		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 LocalPositionOffset;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 LocalRotationOffset;

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x12ACCCC", Offset = "0x12ACCCC", VA = "0x12ACCCC")]
		public SnapZoneOffset()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class SnapZoneScale : MonoBehaviour
	{
		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Local Scale (x, y and z) of Grabbable when inside the SnapZone")]
		public float Scale;

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x12ACCD4", Offset = "0x12ACCD4", VA = "0x12ACCD4")]
		public SnapZoneScale()
		{
		}
	}
	[Token(Token = "0x20000D1")]
	public class SteeringWheel : GrabbableEvents
	{
		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Rotation Limits")]
		[Tooltip("Maximum Z value in Local Euler Angles. Can be < -360. Ex : -450")]
		public float MinAngle;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Maximum Z value in Local Euler Angles. Can be > 360. Ex : 450")]
		public float MaxAngle;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The Transform to rotate on its Z axis.")]
		[Header("Rotation Object")]
		public Transform RotatorObject;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation Speed")]
		[Tooltip("How fast to move the wheel towards the target angle. 0 = Instant.")]
		public float RotationSpeed;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Two-Handed Option")]
		[Tooltip("IF true both hands will effect the rotation of the steering wheel while grabbed with both hands. Set to false if you only want one hand to control the rotation.")]
		public bool AllowTwoHanded;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[Header("Return to Center")]
		public bool ReturnToCenter;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float ReturnToCenterSpeed;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Debug Options")]
		public Text DebugText;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Called if the SteeringWheel changes angle. Returns the current angle in degrees, clamped between MinAngle / MaxAngle")]
		[Header("Events")]
		public FloatEvent onAngleChange;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Called every frame. Returns the current current rotation between -1, 1")]
		public FloatEvent onValueChange;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If true will show an angle helper in editor mode (Gizmos must be enabled)")]
		[Header("Editor Option")]
		public bool ShowEditorGizmos;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		protected Vector3 rotatePosition;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 previousPrimaryPosition;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected Vector3 previousSecondaryPosition;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		protected float targetAngle;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		protected float previousTargetAngle;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected float smoothedAngle;

		[Token(Token = "0x1700004D")]
		public float Angle
		{
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x12ACCE4", Offset = "0x12ACCE4", VA = "0x12ACCE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004E")]
		public float RawAngle
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x12ACD00", Offset = "0x12ACD00", VA = "0x12ACD00")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700004F")]
		public float ScaleValue
		{
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x12ACD08", Offset = "0x12ACD08", VA = "0x12ACD08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000050")]
		public float ScaleValueInverted
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x12ACD30", Offset = "0x12ACD30", VA = "0x12ACD30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000051")]
		public float AngleInverted
		{
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x12ACD68", Offset = "0x12ACD68", VA = "0x12ACD68")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000052")]
		public Grabber PrimaryGrabber
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x12ACD88", Offset = "0x12ACD88", VA = "0x12ACD88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		public Grabber SecondaryGrabber
		{
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x12ACE30", Offset = "0x12ACE30", VA = "0x12ACE30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x12ACED4", Offset = "0x12ACED4", VA = "0x12ACED4")]
		private void Update()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x12ACF8C", Offset = "0x12ACF8C", VA = "0x12ACF8C", Slot = "27")]
		public virtual void UpdateAngleCalculations()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x12AD22C", Offset = "0x12AD22C", VA = "0x12AD22C")]
		public float GetRelativeAngle(Vector3 position1, Vector3 position2)
		{
			return default(float);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x12AD368", Offset = "0x12AD368", VA = "0x12AD368", Slot = "28")]
		public virtual void ApplyAngleToSteeringWheel(float angle)
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x12AD390", Offset = "0x12AD390", VA = "0x12AD390", Slot = "29")]
		public virtual void UpdatePreviewText()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x12AD50C", Offset = "0x12AD50C", VA = "0x12AD50C", Slot = "30")]
		public virtual void CallEvents()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x12AD5A8", Offset = "0x12AD5A8", VA = "0x12AD5A8", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x12AD6B0", Offset = "0x12AD6B0", VA = "0x12AD6B0", Slot = "31")]
		public virtual void ReturnToCenterAngle()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x12ACD8C", Offset = "0x12ACD8C", VA = "0x12ACD8C")]
		public Grabber GetPrimaryGrabber()
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x12ACE34", Offset = "0x12ACE34", VA = "0x12ACE34")]
		public Grabber GetSecondaryGrabber()
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x12AD768", Offset = "0x12AD768", VA = "0x12AD768", Slot = "32")]
		public virtual void UpdatePreviousAngle(float angle)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x12AD770", Offset = "0x12AD770", VA = "0x12AD770", Slot = "33")]
		public virtual float GetScaledValue(float value, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x12AD790", Offset = "0x12AD790", VA = "0x12AD790")]
		public SteeringWheel()
		{
		}
	}
	[Token(Token = "0x20000D2")]
	public class TrackedDevice : MonoBehaviour
	{
		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TrackableDevice Device;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected UnityEngine.XR.InputDevice deviceToTrack;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Vector3 initialLocalPosition;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected Quaternion initialLocalRotation;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		protected Vector3 currentLocalPosition;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Quaternion currentLocalRotation;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x12AD7B8", Offset = "0x12AD7B8", VA = "0x12AD7B8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x12AD808", Offset = "0x12AD808", VA = "0x12AD808", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x12AD87C", Offset = "0x12AD87C", VA = "0x12AD87C", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x12AD8F0", Offset = "0x12AD8F0", VA = "0x12AD8F0", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x12AD918", Offset = "0x12AD918", VA = "0x12AD918", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x12AD924", Offset = "0x12AD924", VA = "0x12AD924", Slot = "9")]
		public virtual void RefreshDeviceStatus()
		{
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x12ADA08", Offset = "0x12ADA08", VA = "0x12ADA08", Slot = "10")]
		public virtual void UpdateDevice()
		{
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x12ADC00", Offset = "0x12ADC00", VA = "0x12ADC00", Slot = "11")]
		protected virtual void OnBeforeRender()
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x12ADC0C", Offset = "0x12ADC0C", VA = "0x12ADC0C")]
		public TrackedDevice()
		{
		}
	}
	[Token(Token = "0x20000D3")]
	public enum TrackableDevice
	{
		[Token(Token = "0x40006C1")]
		HMD,
		[Token(Token = "0x40006C2")]
		LeftController,
		[Token(Token = "0x40006C3")]
		RightController
	}
	[Token(Token = "0x20000D4")]
	public class Arrow : MonoBehaviour
	{
		[Token(Token = "0x20000D5")]
		[CompilerGenerated]
		private sealed class <QueueDestroy>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Arrow <>4__this;

			[Token(Token = "0x17000054")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600047F")]
				[Address(RVA = "0x12AEDA8", Offset = "0x12AEDA8", VA = "0x12AEDA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000055")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000481")]
				[Address(RVA = "0x12AEDF0", Offset = "0x12AEDF0", VA = "0x12AEDF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600047C")]
			[Address(RVA = "0x12AE17C", Offset = "0x12AE17C", VA = "0x12AE17C")]
			[DebuggerHidden]
			public <QueueDestroy>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600047D")]
			[Address(RVA = "0x12AEC38", Offset = "0x12AEC38", VA = "0x12AEC38", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600047E")]
			[Address(RVA = "0x12AEC3C", Offset = "0x12AEC3C", VA = "0x12AEC3C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000480")]
			[Address(RVA = "0x12AEDB0", Offset = "0x12AEDB0", VA = "0x12AEDB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class <ReEnableCollider>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Arrow <>4__this;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <waitFrames>5__2;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <x>5__3;

			[Token(Token = "0x17000056")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000485")]
				[Address(RVA = "0x12AEECC", Offset = "0x12AEECC", VA = "0x12AEECC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000057")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000487")]
				[Address(RVA = "0x12AEF14", Offset = "0x12AEF14", VA = "0x12AEF14", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000482")]
			[Address(RVA = "0x12AE1A4", Offset = "0x12AE1A4", VA = "0x12AE1A4")]
			[DebuggerHidden]
			public <ReEnableCollider>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x6000483")]
			[Address(RVA = "0x12AEDF8", Offset = "0x12AEDF8", VA = "0x12AEDF8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000484")]
			[Address(RVA = "0x12AEDFC", Offset = "0x12AEDFC", VA = "0x12AEDFC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000486")]
			[Address(RVA = "0x12AEED4", Offset = "0x12AEED4", VA = "0x12AEED4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rb;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Grabbable grab;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Flying;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ZVel;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider ShaftCollider;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AudioSource impactSound;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float flightTime;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float destroyTime;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Coroutine queueDestroy;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Projectile ProjectileObject;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float arrowDamage;

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x12ADC14", Offset = "0x12ADC14", VA = "0x12ADC14")]
		private void Start()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x12ADD80", Offset = "0x12ADD80", VA = "0x12ADD80")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x12ADFB4", Offset = "0x12ADFB4", VA = "0x12ADFB4")]
		public void ShootArrow(Vector3 shotForce)
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x12AE114", Offset = "0x12AE114", VA = "0x12AE114")]
		[IteratorStateMachine(typeof(<QueueDestroy>d__14))]
		private IEnumerator QueueDestroy()
		{
			return null;
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x12AE0AC", Offset = "0x12AE0AC", VA = "0x12AE0AC")]
		[IteratorStateMachine(typeof(<ReEnableCollider>d__15))]
		private IEnumerator ReEnableCollider()
		{
			return null;
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x12AE1CC", Offset = "0x12AE1CC", VA = "0x12AE1CC")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x12AE6E8", Offset = "0x12AE6E8", VA = "0x12AE6E8")]
		private void tryStickArrow(Collision collision)
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x12AEB18", Offset = "0x12AEB18", VA = "0x12AEB18")]
		private void playSoundInterval(float fromSeconds, float toSeconds)
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x12AEC28", Offset = "0x12AEC28", VA = "0x12AEC28")]
		public Arrow()
		{
		}
	}
	[Token(Token = "0x20000D7")]
	public class ArrowGrabArea : MonoBehaviour
	{
		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Bow theBow;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x12AEF1C", Offset = "0x12AEF1C", VA = "0x12AEF1C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x12AEF88", Offset = "0x12AEF88", VA = "0x12AEF88")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x12AF2C8", Offset = "0x12AF2C8", VA = "0x12AF2C8")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x12AF3D4", Offset = "0x12AF3D4", VA = "0x12AF3D4")]
		public ArrowGrabArea()
		{
		}
	}
	[Token(Token = "0x20000D8")]
	public class AutoGrabGrabbable : GrabbableEvents
	{
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x12AF3DC", Offset = "0x12AF3DC", VA = "0x12AF3DC", Slot = "8")]
		public override void OnBecomesClosestGrabbable(Grabber touchingGrabber)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x12AF404", Offset = "0x12AF404", VA = "0x12AF404")]
		public AutoGrabGrabbable()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class Bow : GrabbableEvents
	{
		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("")]
		[Header("Bow Settings")]
		public float BowForce;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("If True the BowModel Transform will align itself with the grabber holding the arrow")]
		public bool AlignBowToArrow;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If AlignBowToArrow is true this transform will align itself with the grabber holding the arrow")]
		public Transform BowModel;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Arrow will rotate around this if bow is held in left hand or ArrowRestLeftHanded is null")]
		[Header("Arrow Settings")]
		public Transform ArrowRest;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool CanGrabArrowFromKnock;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the prefab used to create an arrow. Must be in a /Resources/ directory.")]
		public string ArrowPrefabName;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Arrow will rotate around this if bow is being held in right hand")]
		public Transform ArrowRestLeftHanded;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform ArrowKnock;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("Arrow Positioning")]
		public bool IgnoreXPosition;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool IgnoreYPosition;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		public bool AllowNegativeZ;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		[Header("Arrow Grabbing")]
		public bool CanGrabArrow;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		public Grabber ClosestGrabber;

		[Token(Token = "0x40006E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Arrow GrabbedArrow;

		[Token(Token = "0x40006E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable arrowGrabbable;

		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[HideInInspector]
		public Grabber arrowGrabber;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		public Vector3 LastValidPosition;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Header("String Settings")]
		public float MaxStringDistance;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float StringDistance;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private float _lastDrawPercent;

		[Token(Token = "0x40006ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private float _lastDrawHaptic;

		[Token(Token = "0x40006EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float _lastDrawHapticTime;

		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool playedDrawSound;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 initialKnockPosition;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool holdingArrow;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Grabbable bowGrabbable;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Header("Debug Text")]
		public Text PercentageUI;

		[Token(Token = "0x40006F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private List<DrawDefinition> drawDefs;

		[Token(Token = "0x40006F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private AudioSource audioSource;

		[Token(Token = "0x40006F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Vector3 BowUp;

		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public float AlignBowSpeed;

		[Token(Token = "0x17000058")]
		public float DrawPercent
		{
			[Token(Token = "0x600048E")]
			[Address(RVA = "0x12AF40C", Offset = "0x12AF40C", VA = "0x12AF40C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600048F")]
			[Address(RVA = "0x12AF414", Offset = "0x12AF414", VA = "0x12AF414")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x12AF41C", Offset = "0x12AF41C", VA = "0x12AF41C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x12AF95C", Offset = "0x12AF95C", VA = "0x12AF95C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x12B02A4", Offset = "0x12B02A4", VA = "0x12B02A4")]
		private Transform getArrowRest()
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x12B021C", Offset = "0x12B021C", VA = "0x12B021C")]
		private bool canGrabArrowFromKnock()
		{
			return default(bool);
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x12B0614", Offset = "0x12B0614", VA = "0x12B0614")]
		private float getGrabArrowInput()
		{
			return default(float);
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x12B0748", Offset = "0x12B0748", VA = "0x12B0748")]
		private float getGripInput(ControllerHand handSide)
		{
			return default(float);
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x12B0708", Offset = "0x12B0708", VA = "0x12B0708")]
		private float getTriggerInput(ControllerHand handSide)
		{
			return default(float);
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x12B0390", Offset = "0x12B0390", VA = "0x12B0390")]
		private void setKnockPosition()
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x12B05C0", Offset = "0x12B05C0", VA = "0x12B05C0")]
		private void checkDrawSound()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x12AFD28", Offset = "0x12AFD28", VA = "0x12AFD28")]
		private void updateDrawDistance()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x12AFEE4", Offset = "0x12AFEE4", VA = "0x12AFEE4")]
		private void checkBowHaptics()
		{
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x12B016C", Offset = "0x12B016C", VA = "0x12B016C")]
		private void resetStringPosition()
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x12B07A0", Offset = "0x12B07A0", VA = "0x12B07A0", Slot = "27")]
		protected virtual void alignArrow()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x12B08C8", Offset = "0x12B08C8", VA = "0x12B08C8", Slot = "28")]
		protected virtual void alignBow()
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x12B0C48", Offset = "0x12B0C48", VA = "0x12B0C48", Slot = "29")]
		public virtual void ResetBowAlignment()
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x12AF12C", Offset = "0x12AF12C", VA = "0x12AF12C")]
		public void GrabArrow(Arrow arrow)
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x12B0040", Offset = "0x12B0040", VA = "0x12B0040")]
		public void ReleaseArrow()
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x12B0D38", Offset = "0x12B0D38", VA = "0x12B0D38", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x12B0D24", Offset = "0x12B0D24", VA = "0x12B0D24")]
		private void resetArrowValues()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x12B0D5C", Offset = "0x12B0D5C", VA = "0x12B0D5C")]
		private void playSoundInterval(float fromSeconds, float toSeconds, float volume)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x12B0788", Offset = "0x12B0788", VA = "0x12B0788")]
		private void playBowDraw()
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x12B0D08", Offset = "0x12B0D08", VA = "0x12B0D08")]
		private void playBowRelease()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x12B0E90", Offset = "0x12B0E90", VA = "0x12B0E90")]
		public Bow()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public class DrawDefinition
	{
		[Token(Token = "0x17000059")]
		public float DrawPercentage
		{
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x15071DC", Offset = "0x15071DC", VA = "0x15071DC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0x15071E4", Offset = "0x15071E4", VA = "0x15071E4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public float HapticAmplitude
		{
			[Token(Token = "0x60004AA")]
			[Address(RVA = "0x15071EC", Offset = "0x15071EC", VA = "0x15071EC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AB")]
			[Address(RVA = "0x15071F4", Offset = "0x15071F4", VA = "0x15071F4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public float HapticFrequency
		{
			[Token(Token = "0x60004AC")]
			[Address(RVA = "0x15071FC", Offset = "0x15071FC", VA = "0x15071FC")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0x1507204", Offset = "0x1507204", VA = "0x1507204")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x150720C", Offset = "0x150720C", VA = "0x150720C")]
		public DrawDefinition()
		{
		}
	}
	[Token(Token = "0x20000DB")]
	public class BowArm : MonoBehaviour
	{
		[Token(Token = "0x40006FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Bow BowItem;

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float BowPercentStart;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotateDegrees;

		[Token(Token = "0x40006FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Speed;

		[Token(Token = "0x40006FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion _startRotation;

		[Token(Token = "0x4000700")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion _endRotation;

		[Token(Token = "0x4000701")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool RotateX;

		[Token(Token = "0x4000702")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool RotateZ;

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1507214", Offset = "0x1507214", VA = "0x1507214")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1507350", Offset = "0x1507350", VA = "0x1507350")]
		private void Update()
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1507528", Offset = "0x1507528", VA = "0x1507528")]
		public BowArm()
		{
		}
	}
	[Token(Token = "0x20000DC")]
	public class BulletHole : MonoBehaviour
	{
		[Token(Token = "0x4000703")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform BulletHoleDecal;

		[Token(Token = "0x4000704")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaxScale;

		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float MinScale;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool RandomYRotation;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float DestroyTime;

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x150754C", Offset = "0x150754C", VA = "0x150754C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1507710", Offset = "0x1507710", VA = "0x1507710")]
		public void TryAttachTo(Collider col)
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x150783C", Offset = "0x150783C", VA = "0x150783C")]
		private bool transformIsEqualScale(Transform theTransform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x15078AC", Offset = "0x15078AC", VA = "0x15078AC")]
		private void DestroySelf()
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1507938", Offset = "0x1507938", VA = "0x1507938")]
		public BulletHole()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public class CalibratePlayerHeight : MonoBehaviour
	{
		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Desired height of the player in meters. The player's presence in vr will be adjusted based on their physical height. 1.65 meters = 5.41 feet")]
		public float DesiredPlayerHeight;

		[Token(Token = "0x4000709")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Adjust the CharacterControllerYOffset property of this playerController. If not specified one will be found using GetComponentInChildren()")]
		public BNGPlayerController PlayerController;

		[Token(Token = "0x400070A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Startup")]
		[Tooltip("If true, the player's virtual height will be adjusted to match DesiredPlayerHeight on Start()")]
		public bool CalibrateOnStart;

		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If specified, pressing this button / action will activate the calibration")]
		[Header("Input :")]
		public InputAction CalibrateHeightAction;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float _initialOffset;

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x150795C", Offset = "0x150795C", VA = "0x150795C")]
		private void Start()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1507AB4", Offset = "0x1507AB4", VA = "0x1507AB4")]
		public void CalibrateHeight()
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1507ABC", Offset = "0x1507ABC", VA = "0x1507ABC")]
		public void CalibrateHeight(float calibrateHeight)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1507B6C", Offset = "0x1507B6C", VA = "0x1507B6C")]
		public void ResetPlayerHeight()
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1507AF0", Offset = "0x1507AF0", VA = "0x1507AF0")]
		public float GetCurrentPlayerHeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1507B8C", Offset = "0x1507B8C", VA = "0x1507B8C")]
		public CalibratePlayerHeight()
		{
		}
	}
	[Token(Token = "0x20000DE")]
	public class CustomCenterOfMass : MonoBehaviour
	{
		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Local coordinates to use as center of mass if 'CenterOfMassTransform' is not specified.")]
		[Header("Define Center of Mass")]
		public Vector3 CenterOfMass;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Use this Transform's local position for the center of mass if specified.")]
		public Transform CenterOfMassTransform;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Debug Options")]
		[Tooltip("If true a red sphere will in the editor show where the center of mass will be positioned")]
		public bool ShowGizmo;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbody rigid;

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1507BB0", Offset = "0x1507BB0", VA = "0x1507BB0")]
		private void Start()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1507C1C", Offset = "0x1507C1C", VA = "0x1507C1C", Slot = "4")]
		public virtual void SetCenterOfMass(Vector3 center)
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1507CCC", Offset = "0x1507CCC", VA = "0x1507CCC", Slot = "5")]
		protected virtual Vector3 getThisCenterOfMass()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1507D54", Offset = "0x1507D54", VA = "0x1507D54")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1507E80", Offset = "0x1507E80", VA = "0x1507E80")]
		public CustomCenterOfMass()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class DrawerSound : MonoBehaviour
	{
		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip DrawerOpenSound;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float DrawerOpenValue;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip DrawerCloseSound;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float DrawerCloseValue;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool playedOpenSound;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool playedCloseSound;

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1507EE8", Offset = "0x1507EE8", VA = "0x1507EE8")]
		public void OnDrawerUpdate(float drawerValue)
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1508078", Offset = "0x1508078", VA = "0x1508078")]
		public DrawerSound()
		{
		}
	}
	[Token(Token = "0x20000E0")]
	public class Explosive : MonoBehaviour
	{
		[Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private sealed class <explosionRoutine>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Explosive <>4__this;

			[Token(Token = "0x1700005C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004CD")]
				[Address(RVA = "0x1508658", Offset = "0x1508658", VA = "0x1508658", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004CF")]
				[Address(RVA = "0x15086A0", Offset = "0x15086A0", VA = "0x15086A0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004CA")]
			[Address(RVA = "0x1508118", Offset = "0x1508118", VA = "0x1508118")]
			[DebuggerHidden]
			public <explosionRoutine>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x150826C", Offset = "0x150826C", VA = "0x150826C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x1508270", Offset = "0x1508270", VA = "0x1508270", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x1508660", Offset = "0x1508660", VA = "0x1508660", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[CompilerGenerated]
		private sealed class <dealDelayedDamaged>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delayTime;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Damageable damageable;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Explosive <>4__this;

			[Token(Token = "0x1700005E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60004D3")]
				[Address(RVA = "0x150876C", Offset = "0x150876C", VA = "0x150876C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700005F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60004D5")]
				[Address(RVA = "0x15087B4", Offset = "0x15087B4", VA = "0x15087B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x15081C4", Offset = "0x15081C4", VA = "0x15081C4")]
			[DebuggerHidden]
			public <dealDelayedDamaged>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x15086A8", Offset = "0x15086A8", VA = "0x15086A8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x15086AC", Offset = "0x15086AC", VA = "0x15086AC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x1508774", Offset = "0x1508774", VA = "0x1508774", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Objects within this radius will have damage and force applied to it")]
		[Header("Explosion Settings : ")]
		public float ExplosionRadius;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Apply damage to an item if it has a Damageable component attached. ")]
		public float ExplosionDamage;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If an object has a Rigidbody and is within ExplosionRadius, it will have this amount of ExplosionForce added to it")]
		public float ExplosionForce;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Add an UpwardsModifier to AddExplosionForce. Use this to make objects fly more up into the air, instead of just outwardly.")]
		public float ExplosiveUpwardsModifier;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Shown for Debug : ")]
		public bool ShowExplosionRadius;

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1508090", Offset = "0x1508090", VA = "0x1508090", Slot = "4")]
		public virtual void DoExplosion()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x15080B0", Offset = "0x15080B0", VA = "0x15080B0")]
		[IteratorStateMachine(typeof(<explosionRoutine>d__6))]
		private IEnumerator explosionRoutine()
		{
			return null;
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1508140", Offset = "0x1508140", VA = "0x1508140")]
		[IteratorStateMachine(typeof(<dealDelayedDamaged>d__7))]
		private IEnumerator dealDelayedDamaged(Damageable damageable, float delayTime)
		{
			return null;
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x15081EC", Offset = "0x15081EC", VA = "0x15081EC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1508250", Offset = "0x1508250", VA = "0x1508250")]
		public Explosive()
		{
		}
	}
	[Token(Token = "0x20000E3")]
	public static class ExtensionMethods
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x15087BC", Offset = "0x15087BC", VA = "0x15087BC")]
		public static bool GetDown(this ControllerBinding binding)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E4")]
	public class Flashlight : GrabbableEvents
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Light SpotLight;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform LightSwitch;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 originalSwitchPosition;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1508824", Offset = "0x1508824", VA = "0x1508824")]
		private void Start()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x150885C", Offset = "0x150885C", VA = "0x150885C", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x15088C4", Offset = "0x15088C4", VA = "0x15088C4", Slot = "18")]
		public override void OnTriggerUp()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x150890C", Offset = "0x150890C", VA = "0x150890C")]
		public Flashlight()
		{
		}
	}
	[Token(Token = "0x20000E5")]
	public class FPSText : MonoBehaviour
	{
		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Text text;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float deltaTime;

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1508914", Offset = "0x1508914", VA = "0x1508914")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1508964", Offset = "0x1508964", VA = "0x1508964")]
		private void Update()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1508A4C", Offset = "0x1508A4C", VA = "0x1508A4C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1508B10", Offset = "0x1508B10", VA = "0x1508B10")]
		public FPSText()
		{
		}
	}
	[Token(Token = "0x20000E6")]
	public class GrappleShot : GrabbableEvents
	{
		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Range")]
		public float MaxRange;

		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Header("CharacterController Grapple Settings")]
		[Tooltip("(CharacterController Player Only) How much movement speed to apply to the CharacterController to move towards the grapple")]
		public float GrappleReelForce;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("currentGrappleDistance must be greater than this to reel in")]
		public float MinReelDistance;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Header("Rigidbody Grapple Settings")]
		[Tooltip("(Rigidbody Player Only) How much force to apply to the player to move towards the grapple")]
		public float GrappleForce;

		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Rigidbody Player Only) Type of ForceMode to use to move the player towards the grapple point. ForceMode. ForceMode.Acceleration will let you preserve momentum and Swing Around. Use lower number for Acceleration (ex : 3). ForceMode.Velocity will immediately alter your player's velocity, resulting in a smooth but linear movement. Use higher numbers (ex : 200).")]
		public ForceMode GrappleForceMode;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Header("Raycast Layers")]
		public LayerMask GrappleLayers;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Component definitions")]
		public Transform MuzzleTransform;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform HitTargetPrefab;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LineRenderer GrappleLine;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LineRenderer HelperLine;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioClip GrappleShotSound;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool grappling;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool wasGrappling;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CharacterController characterController;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private PlayerGravity playerGravity;

		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private PlayerClimbing playerClimbing;

		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Rigidbody playerRigid;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private AudioSource audioSource;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Header("Shown for Debug :")]
		public float currentGrappleDistance;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private bool validTargetFound;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		private bool isDynamic;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Rigidbody grappleTargetRigid;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Collider grappleTargetCollider;

		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform grappleTargetParent;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool requireRelease;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC9")]
		private bool climbing;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Climbable ClimbHelper;

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1508B18", Offset = "0x1508B18", VA = "0x1508B18")]
		private void Start()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1508CD8", Offset = "0x1508CD8", VA = "0x1508CD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x15093E0", Offset = "0x15093E0", VA = "0x15093E0", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x150945C", Offset = "0x150945C", VA = "0x150945C")]
		private void updateGrappleDistance()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1509D30", Offset = "0x1509D30", VA = "0x1509D30", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1509D38", Offset = "0x1509D38", VA = "0x1509D38", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1509B7C", Offset = "0x1509B7C", VA = "0x1509B7C")]
		private void onReleaseGrapple()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1508D50", Offset = "0x1508D50", VA = "0x1508D50")]
		private void drawGrappleHelper()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x15092A8", Offset = "0x15092A8", VA = "0x15092A8")]
		private void drawGrappleLine()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1509330", Offset = "0x1509330", VA = "0x1509330")]
		private void hideGrappleLine()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1509DE8", Offset = "0x1509DE8", VA = "0x1509DE8")]
		private void showGrappleHelper(Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1509194", Offset = "0x1509194", VA = "0x1509194")]
		private void hideGrappleHelper()
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1509538", Offset = "0x1509538", VA = "0x1509538")]
		private void reelInGrapple(float triggerValue)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1509A98", Offset = "0x1509A98", VA = "0x1509A98")]
		private void shootGrapple()
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1509FB4", Offset = "0x1509FB4", VA = "0x1509FB4")]
		private void dropGrapple()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1509D54", Offset = "0x1509D54", VA = "0x1509D54")]
		private void changeGravity(bool gravityOn)
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1509FC0", Offset = "0x1509FC0", VA = "0x1509FC0")]
		public GrappleShot()
		{
		}
	}
	[Token(Token = "0x20000E7")]
	public class HandJet : GrabbableEvents
	{
		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Movement Speed to apply if using a CharacterController, or Force to apply if using a Rigidbody controller.")]
		public float JetForce;

		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Enabled while jetting")]
		public ParticleSystem JetFX;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("If true the player will float in the air when not jetting. (Works for Rigidbody player only)")]
		public bool DisableGravityWhileHeld;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private CharacterController characterController;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private PlayerGravity playerGravity;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Rigidbody playerRigid;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 moveDirection;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 addRigidForce;

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1509FDC", Offset = "0x1509FDC", VA = "0x1509FDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x150A170", Offset = "0x150A170", VA = "0x150A170", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x150A578", Offset = "0x150A578", VA = "0x150A578")]
		public void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x150A6B4", Offset = "0x150A6B4", VA = "0x150A6B4", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x150A6C8", Offset = "0x150A6C8", VA = "0x150A6C8")]
		public void ChangeGravity(bool gravityOn)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x150A75C", Offset = "0x150A75C", VA = "0x150A75C", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x150A1B4", Offset = "0x150A1B4", VA = "0x150A1B4")]
		private void doJet(float triggerValue)
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x150A470", Offset = "0x150A470", VA = "0x150A470")]
		private void stopJet()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x150A788", Offset = "0x150A788", VA = "0x150A788", Slot = "18")]
		public override void OnTriggerUp()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x150A7A4", Offset = "0x150A7A4", VA = "0x150A7A4")]
		public HandJet()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class IKDummy : MonoBehaviour
	{
		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform ThisEyeBone;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform PlayerTransform;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform HeadFollow;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform RightHandFollow;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform LeftHandFollow;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 HandRotationOffset;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Animator animator;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform headBone;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform leftHandDummy;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform rightHandDummy;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Transform leftHandOnPlayer;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Transform rightHandOnPlayer;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform lookatDummy;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 localPos;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion localRot;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform cam;

		[Token(Token = "0x400075F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 leftHandLocalPos;

		[Token(Token = "0x4000760")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 rightHandLocalPos;

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion leftHandLocalRot;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Quaternion rightHandLocalRot;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Vector3 LeftHandsOffset;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public Vector3 RightHandsOffset;

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x150A7BC", Offset = "0x150A7BC", VA = "0x150A7BC")]
		private void Start()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x150AA20", Offset = "0x150AA20", VA = "0x150AA20")]
		public Transform SetParentAndLocalPosRot(string transformName, Transform parentToSet)
		{
			return null;
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x150AB38", Offset = "0x150AB38", VA = "0x150AB38")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x150ADF8", Offset = "0x150ADF8", VA = "0x150ADF8")]
		private void OnAnimatorIK()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x150B124", Offset = "0x150B124", VA = "0x150B124")]
		public IKDummy()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public class LaserPointer : MonoBehaviour
	{
		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MaxRange;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask ValidLayers;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform LaserEnd;

		[Token(Token = "0x4000768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool Active;

		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private LineRenderer line;

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x150B1AC", Offset = "0x150B1AC", VA = "0x150B1AC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x150B1FC", Offset = "0x150B1FC", VA = "0x150B1FC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x150B520", Offset = "0x150B520", VA = "0x150B520")]
		public LaserPointer()
		{
		}
	}
	[Token(Token = "0x20000EA")]
	public class LaserSword : GrabbableEvents
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Grabbable grabbable;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform BladeTransform;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform RaycastTransform;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public LayerMask LaserCollision;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public ParticleSystem CollisionParticle;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool BladeEnabled;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
		private bool SaberSwitchOn;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float LaserLength;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float LaserActivateSpeed;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AudioSource CollisionAudio;

		[Token(Token = "0x4000774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool Colliding;

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x150B538", Offset = "0x150B538", VA = "0x150B538")]
		private void Start()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x150B5EC", Offset = "0x150B5EC", VA = "0x150B5EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x150BB6C", Offset = "0x150BB6C", VA = "0x150BB6C", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x150B7DC", Offset = "0x150B7DC", VA = "0x150B7DC")]
		private void checkCollision()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x150BB88", Offset = "0x150BB88", VA = "0x150BB88")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x150BCB0", Offset = "0x150BCB0", VA = "0x150BCB0")]
		public LaserSword()
		{
		}
	}
	[Token(Token = "0x20000EB")]
	public class LiquidWobble : MonoBehaviour
	{
		[Token(Token = "0x4000775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer rend;

		[Token(Token = "0x4000776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPos;

		[Token(Token = "0x4000777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 velocity;

		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 lastRot;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 angularVelocity;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float MaxWobble;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float WobbleSpeed;

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float Recovery;

		[Token(Token = "0x400077D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float wobbleAmountX;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float wobbleAmountZ;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float wobbleAmountToAddX;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float wobbleAmountToAddZ;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pulse;

		[Token(Token = "0x4000782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float time;

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x150BCC4", Offset = "0x150BCC4", VA = "0x150BCC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x150BD14", Offset = "0x150BD14", VA = "0x150BD14")]
		private void Update()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x150BFC4", Offset = "0x150BFC4", VA = "0x150BFC4")]
		public LiquidWobble()
		{
		}
	}
	[Token(Token = "0x20000EC")]
	public class Marker : GrabbableEvents
	{
		[Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private sealed class <WriteRoutine>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000795")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Marker <>4__this;

			[Token(Token = "0x17000060")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000515")]
				[Address(RVA = "0x150CB2C", Offset = "0x150CB2C", VA = "0x150CB2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000061")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000517")]
				[Address(RVA = "0x150CB74", Offset = "0x150CB74", VA = "0x150CB74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000512")]
			[Address(RVA = "0x150C0C4", Offset = "0x150C0C4", VA = "0x150C0C4")]
			[DebuggerHidden]
			public <WriteRoutine>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000513")]
			[Address(RVA = "0x150C830", Offset = "0x150C830", VA = "0x150C830", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000514")]
			[Address(RVA = "0x150C834", Offset = "0x150C834", VA = "0x150C834", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000516")]
			[Address(RVA = "0x150CB34", Offset = "0x150CB34", VA = "0x150CB34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Material DrawMaterial;

		[Token(Token = "0x4000784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color DrawColor;

		[Token(Token = "0x4000785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float LineWidth;

		[Token(Token = "0x4000786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform RaycastStart;

		[Token(Token = "0x4000787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public LayerMask DrawingLayers;

		[Token(Token = "0x4000788")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float RaycastLength;

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float MinDrawDistance;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float ReuseTolerance;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool IsNewDraw;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 lastDrawPoint;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private LineRenderer LineRenderer;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Transform root;

		[Token(Token = "0x400078F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTransform;

		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Coroutine drawRoutine;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastLineWidth;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private int renderLifeTime;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x150BFE8", Offset = "0x150BFE8", VA = "0x150BFE8", Slot = "5")]
		public override void OnGrab(Grabber grabber)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x150C094", Offset = "0x150C094", VA = "0x150C094", Slot = "6")]
		public override void OnRelease()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x150C02C", Offset = "0x150C02C", VA = "0x150C02C")]
		[IteratorStateMachine(typeof(<WriteRoutine>d__18))]
		private IEnumerator WriteRoutine()
		{
			return null;
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x150C0EC", Offset = "0x150C0EC", VA = "0x150C0EC")]
		private void InitDraw(Vector3 position, Quaternion rotation, float lineWidth, Color lineColor)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x150C260", Offset = "0x150C260", VA = "0x150C260")]
		private Vector3 DrawPoint(Vector3 lastDrawPoint, Vector3 endPosition, float lineWidth, Color lineColor, Quaternion rotation)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x150C740", Offset = "0x150C740", VA = "0x150C740")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x150C7F8", Offset = "0x150C7F8", VA = "0x150C7F8")]
		public Marker()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class MoveToWaypoint : MonoBehaviour
	{
		[Token(Token = "0x4000796")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool IsActive;

		[Token(Token = "0x4000797")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Waypoint Destination;

		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float MovementSpeed;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool ReachedDestination;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Delay in seconds to way before starting movement towards Destination")]
		public float StartDelay;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool reachedDelay;

		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float delayedTime;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 previousPosition;

		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 PositionDifference;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool MoveInUpdate;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		public bool MoveInFixedUpdate;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigid;

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x150CB7C", Offset = "0x150CB7C", VA = "0x150CB7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x150CBDC", Offset = "0x150CBDC", VA = "0x150CBDC")]
		private void Update()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x150D058", Offset = "0x150D058", VA = "0x150D058")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x150CC94", Offset = "0x150CC94", VA = "0x150CC94")]
		private void movePlatform(float timeDelta)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x150D084", Offset = "0x150D084", VA = "0x150D084")]
		private void resetDelayStatus()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x150D090", Offset = "0x150D090", VA = "0x150D090")]
		public MoveToWaypoint()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public class MovingPlatform : MonoBehaviour
	{
		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If set to ParentToPlatform the CharacterController will be parented to any MovingPlatform object below it each frame. If set to PositionDifference the movement will be read from the PositionDifference property of the MoveToWaypoint object below it. ")]
		public MovingPlatformMethod MovementMethod;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[HideInInspector]
		public Vector3 PositionDelta;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Quaternion RotationDelta;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 previousPosition;

		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Quaternion previousRotation;

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x150D0B0", Offset = "0x150D0B0", VA = "0x150D0B0")]
		protected void Update()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x150D1F8", Offset = "0x150D1F8", VA = "0x150D1F8")]
		public MovingPlatform()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public enum MovingPlatformMethod
	{
		[Token(Token = "0x40007A8")]
		ParentToPlatform,
		[Token(Token = "0x40007A9")]
		PositionDifference
	}
	[Token(Token = "0x20000F1")]
	public class PlayerScaler : MonoBehaviour
	{
		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Transform> ScaleObjects;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float Scale;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float scaleSpeed;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x150D200", Offset = "0x150D200", VA = "0x150D200")]
		private void Update()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x150D438", Offset = "0x150D438", VA = "0x150D438")]
		public PlayerScaler()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class ProjectileLauncher : MonoBehaviour
	{
		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject ProjectileObject;

		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ProjectileForce;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip LaunchSound;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ParticleSystem LaunchParticles;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform MuzzleTransform;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float _initialProjectileForce;

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x150D44C", Offset = "0x150D44C", VA = "0x150D44C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x150D458", Offset = "0x150D458", VA = "0x150D458")]
		public GameObject ShootProjectile(float projectileForce)
		{
			return null;
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x150D704", Offset = "0x150D704", VA = "0x150D704")]
		public void ShootProjectile()
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x150D70C", Offset = "0x150D70C", VA = "0x150D70C")]
		public void SetForce(float force)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x150D714", Offset = "0x150D714", VA = "0x150D714")]
		public float GetInitialProjectileForce()
		{
			return default(float);
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x150D71C", Offset = "0x150D71C", VA = "0x150D71C")]
		public ProjectileLauncher()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class SceneLoader : MonoBehaviour
	{
		[Token(Token = "0x20000F4")]
		[CompilerGenerated]
		private sealed class <FadeThenLoadScene>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SceneLoader <>4__this;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600052E")]
				[Address(RVA = "0x150DA20", Offset = "0x150DA20", VA = "0x150DA20", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x150DA68", Offset = "0x150DA68", VA = "0x150DA68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600052B")]
			[Address(RVA = "0x150D7FC", Offset = "0x150D7FC", VA = "0x150D7FC")]
			[DebuggerHidden]
			public <FadeThenLoadScene>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x600052C")]
			[Address(RVA = "0x150D88C", Offset = "0x150D88C", VA = "0x150D88C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600052D")]
			[Address(RVA = "0x150D890", Offset = "0x150D890", VA = "0x150D890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600052F")]
			[Address(RVA = "0x150DA28", Offset = "0x150DA28", VA = "0x150DA28", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Unity 'LoadSceneMode' method of loading the scene (In most cases should be 'Single'). ")]
		public LoadSceneMode loadSceneMode;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If true, the ScreenFader component will fade the screen to black before loading a level.")]
		public bool UseSceenFader;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Wait this long in seconds before attempting to load the scene. Useful if you need to fade the screen out before attempting to load the level.")]
		public float ScreenFadeTime;

		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ScreenFader sf;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string _loadSceneName;

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x150D72C", Offset = "0x150D72C", VA = "0x150D72C")]
		public void LoadScene(string SceneName)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x150D794", Offset = "0x150D794", VA = "0x150D794")]
		[IteratorStateMachine(typeof(<FadeThenLoadScene>d__6))]
		public IEnumerator FadeThenLoadScene()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x150D824", Offset = "0x150D824", VA = "0x150D824")]
		public SceneLoader()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class TimeController : MonoBehaviour
	{
		[Token(Token = "0x20000F6")]
		[CompilerGenerated]
		private sealed class <resumeTimeRoutine>d__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TimeController <>4__this;

			[Token(Token = "0x17000065")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600053C")]
				[Address(RVA = "0x150DFDC", Offset = "0x150DFDC", VA = "0x150DFDC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000066")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600053E")]
				[Address(RVA = "0x150E024", Offset = "0x150E024", VA = "0x150E024", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x150DE38", Offset = "0x150DE38", VA = "0x150DE38")]
			[DebuggerHidden]
			public <resumeTimeRoutine>d__19(int <>1__state)
			{
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x150DE78", Offset = "0x150DE78", VA = "0x150DE78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x150DE7C", Offset = "0x150DE7C", VA = "0x150DE7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600053D")]
			[Address(RVA = "0x150DFE4", Offset = "0x150DFE4", VA = "0x150DFE4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Timescale to slow down to if slow down key is pressed")]
		public float SlowTimeScale;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If true, Y Button will always slow time. Useful for debugging. Otherwise call SlowTime / ResumeTime yourself")]
		public bool YKeySlowsTime;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Input Action used to initiate slow time")]
		public InputActionReference SlowTimeAction;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("(Optional) Play this clip when starting to slow time")]
		public AudioClip SlowTimeClip;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) Play this clip when ending slow mo")]
		public AudioClip SpeedupTimeClip;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, will set Time.fixedDeltaTime to the device refresh rate")]
		public bool SetFixedDelta;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		private bool _slowingTime;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
		private bool routineRunning;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float originalFixedDelta;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AudioSource audioSource;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool ForceTimeScale;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IEnumerator resumeRoutine;

		[Token(Token = "0x17000064")]
		public bool TimeSlowing
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x150DA70", Offset = "0x150DA70", VA = "0x150DA70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x150DA78", Offset = "0x150DA78", VA = "0x150DA78")]
		private void Start()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x150DB04", Offset = "0x150DB04", VA = "0x150DB04")]
		private void Update()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x150DCDC", Offset = "0x150DCDC", VA = "0x150DCDC", Slot = "4")]
		public virtual bool SlowTimeInputDown()
		{
			return default(bool);
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x150DB3C", Offset = "0x150DB3C", VA = "0x150DB3C")]
		public void SlowTime()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x150DC84", Offset = "0x150DC84", VA = "0x150DC84")]
		public void ResumeTime()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x150DDD0", Offset = "0x150DDD0", VA = "0x150DDD0")]
		[IteratorStateMachine(typeof(<resumeTimeRoutine>d__19))]
		private IEnumerator resumeTimeRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x150DE60", Offset = "0x150DE60", VA = "0x150DE60")]
		public TimeController()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class ToggleActiveOnInputAction : MonoBehaviour
	{
		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InputActionReference InputAction;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ToggleObject;

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x150E02C", Offset = "0x150E02C", VA = "0x150E02C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x150E0CC", Offset = "0x150E0CC", VA = "0x150E0CC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x150E16C", Offset = "0x150E16C", VA = "0x150E16C")]
		public void ToggleActive(InputAction.CallbackContext context)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x150E204", Offset = "0x150E204", VA = "0x150E204")]
		public ToggleActiveOnInputAction()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class VehicleController : MonoBehaviour
	{
		[Token(Token = "0x20000F9")]
		[CompilerGenerated]
		private sealed class <crankEngine>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VehicleController <>4__this;

			[Token(Token = "0x17000067")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600055B")]
				[Address(RVA = "0x150EDA0", Offset = "0x150EDA0", VA = "0x150EDA0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000068")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600055D")]
				[Address(RVA = "0x150EDE8", Offset = "0x150EDE8", VA = "0x150EDE8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000558")]
			[Address(RVA = "0x150E490", Offset = "0x150E490", VA = "0x150E490")]
			[DebuggerHidden]
			public <crankEngine>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x6000559")]
			[Address(RVA = "0x150EBAC", Offset = "0x150EBAC", VA = "0x150EBAC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600055A")]
			[Address(RVA = "0x150EBB0", Offset = "0x150EBB0", VA = "0x150EBB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600055C")]
			[Address(RVA = "0x150EDA8", Offset = "0x150EDA8", VA = "0x150EDA8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Engine Properties")]
		public float MotorTorque;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxSpeed;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float MaxSteeringAngle;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Header("Steering Grabbable")]
		[Tooltip("If true and SteeringGrabbable is being held, the right / left trigger will act as input for acceleration / defceleration.")]
		public bool CheckTriggerInput;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Grabbable SteeringGrabbable;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Engine Status")]
		[Tooltip("Is the Engine on and ready for input. If false, engine will need to be started first.")]
		public bool EngineOn;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("How long it takes to start the engine")]
		public float CrankTime;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Speedometer")]
		[Tooltip("Output the current speed to this label if specified")]
		public Text SpeedLabel;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Audio Setup")]
		public AudioSource EngineAudio;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Sound to play / loop when EngineOn = true. Pitch will be altered according to speed.")]
		public AudioClip IdleSound;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If specified this clip will play before the engine is turned on. Clip to play when starting the Engine.")]
		public AudioClip CrankSound;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip CollisionSound;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public float SteeringAngle;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[HideInInspector]
		public float MotorInput;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public float CurrentSpeed;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Wheel Configuration")]
		public List<WheelObject> Wheels;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 initialPosition;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Rigidbody rb;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool wasHoldingSteering;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool isHoldingSteering;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		protected bool crankingEngine;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x150E20C", Offset = "0x150E20C", VA = "0x150E20C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x150E280", Offset = "0x150E280", VA = "0x150E280")]
		private void Update()
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x150E3EC", Offset = "0x150E3EC", VA = "0x150E3EC", Slot = "4")]
		public virtual void CrankEngine()
		{
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x150E428", Offset = "0x150E428", VA = "0x150E428")]
		[IteratorStateMachine(typeof(<crankEngine>d__24))]
		private IEnumerator crankEngine()
		{
			return null;
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x150E4B8", Offset = "0x150E4B8", VA = "0x150E4B8", Slot = "5")]
		public virtual void CheckOutOfBounds()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x150E514", Offset = "0x150E514", VA = "0x150E514", Slot = "6")]
		public virtual void GetTorqueInputFromTriggers()
		{
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x150E5D0", Offset = "0x150E5D0", VA = "0x150E5D0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x150E768", Offset = "0x150E768", VA = "0x150E768", Slot = "7")]
		public virtual void UpdateWheelTorque()
		{
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x150E870", Offset = "0x150E870", VA = "0x150E870", Slot = "8")]
		public virtual void SetSteeringAngle(float steeringAngle)
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x150E878", Offset = "0x150E878", VA = "0x150E878", Slot = "9")]
		public virtual void SetSteeringAngleInverted(float steeringAngle)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x150E884", Offset = "0x150E884", VA = "0x150E884", Slot = "10")]
		public virtual void SetSteeringAngle(Vector2 steeringAngle)
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x150E88C", Offset = "0x150E88C", VA = "0x150E88C", Slot = "11")]
		public virtual void SetSteeringAngleInverted(Vector2 steeringAngle)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x150E898", Offset = "0x150E898", VA = "0x150E898", Slot = "12")]
		public virtual void SetMotorTorqueInput(float input)
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x150E8A0", Offset = "0x150E8A0", VA = "0x150E8A0", Slot = "13")]
		public virtual void SetMotorTorqueInputInverted(float input)
		{
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x150E8AC", Offset = "0x150E8AC", VA = "0x150E8AC", Slot = "14")]
		public virtual void SetMotorTorqueInput(Vector2 input)
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x150E8B4", Offset = "0x150E8B4", VA = "0x150E8B4", Slot = "15")]
		public virtual void SetMotorTorqueInputInverted(Vector2 input)
		{
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x150E8C0", Offset = "0x150E8C0", VA = "0x150E8C0", Slot = "16")]
		public virtual void UpdateWheelVisuals(WheelObject wheel)
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x150E9A4", Offset = "0x150E9A4", VA = "0x150E9A4", Slot = "17")]
		public virtual void UpdateEngineAudio()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x150EA58", Offset = "0x150EA58", VA = "0x150EA58")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x150E688", Offset = "0x150E688", VA = "0x150E688")]
		private float correctValue(float inputValue)
		{
			return default(float);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x150EB7C", Offset = "0x150EB7C", VA = "0x150EB7C")]
		public VehicleController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FA")]
	public class WheelObject
	{
		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public WheelCollider Wheel;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform WheelVisual;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool ApplyTorque;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool ApplySteering;

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x150EDF0", Offset = "0x150EDF0", VA = "0x150EDF0")]
		public WheelObject()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class VREmulator : MonoBehaviour
	{
		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Enable / Disable : ")]
		[Tooltip("Use Emulator if true and HMDIsActive is false")]
		public bool EmulatorEnabled;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Action set used specifically to mimic or supplement a vr setup")]
		[SerializeField]
		[Header("Input : ")]
		public InputActionAsset EmulatorActionSet;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Header("Player Teleportation")]
		[Tooltip("Will set the PlayerTeleport component's ForceStraightArrow = true while the emulator is active.")]
		public bool ForceStraightTeleportRotation;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[Tooltip("If true, move the player eye offset up / down whenever PlayerUpAction / PlayerDownAction is called.")]
		[Header("Move Player Up / Down")]
		public bool AllowUpDownControls;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Unity Input Action used to move the player up")]
		public InputActionReference PlayerUpAction;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Unity Input Action used to move the player down")]
		public InputActionReference PlayerDownAction;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Head Look")]
		[Tooltip("Unity Input Action used to lock the camera in game mode to look around")]
		public InputActionReference LockCameraAction;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Unity Input Action used to lock the camera in game mode to look around")]
		public InputActionReference CameraLookAction;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Multiply the CameraLookAction by this amount")]
		public float CameraLookSensitivityX;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Multiply the CameraLookAction by this amount")]
		public float CameraLookSensitivityY;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum local Eulers degrees the camera can rotate")]
		public float MinimumCameraY;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum local Eulers degrees the camera can rotate")]
		public float MaximumCameraY;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Header("Controller Emulation")]
		[Tooltip("Unity Input Action used to mimic holding the Left Grip")]
		public InputActionReference LeftGripAction;

		[Token(Token = "0x40007F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Unity Input Action used to mimic holding the Left Trigger")]
		public InputActionReference LeftTriggerAction;

		[Token(Token = "0x40007F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Unity Input Action used to mimic having your thumb near a button")]
		public InputActionReference LeftThumbNearAction;

		[Token(Token = "0x40007F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Unity Input Action used to move mimic holding the Right Grip")]
		public InputActionReference RightGripAction;

		[Token(Token = "0x40007F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Unity Input Action used to move mimic holding the Right Grip")]
		public InputActionReference RightTriggerAction;

		[Token(Token = "0x40007F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("Unity Input Action used to mimic having your thumb near a button")]
		public InputActionReference RightThumbNearAction;

		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float mouseRotationX;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float mouseRotationY;

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Transform mainCameraTransform;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Transform leftControllerTranform;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform rightControllerTranform;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform leftHandAnchor;

		[Token(Token = "0x4000800")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Transform rightHandAnchor;

		[Token(Token = "0x4000801")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private BNGPlayerController player;

		[Token(Token = "0x4000802")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private SmoothLocomotion smoothLocomotion;

		[Token(Token = "0x4000803")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private PlayerTeleport playerTeleport;

		[Token(Token = "0x4000804")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool didFirstActivate;

		[Token(Token = "0x4000805")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Grabber grabberLeft;

		[Token(Token = "0x4000806")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Grabber grabberRight;

		[Token(Token = "0x4000807")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float _originalPlayerYOffset;

		[Token(Token = "0x4000808")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Header("Shown for Debug : ")]
		public bool HMDIsActive;

		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public Vector3 LeftControllerPosition;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		public Vector3 RightControllerPosition;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private bool priorStraightSetting;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
		public bool RequireGameFocus;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float prevVal;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private bool isQuitting;

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x150EDF8", Offset = "0x150EDF8", VA = "0x150EDF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x150F1A4", Offset = "0x150F1A4", VA = "0x150F1A4")]
		public void OnBeforeRender()
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x150F230", Offset = "0x150F230", VA = "0x150F230")]
		private void onFirstActivate()
		{
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x150F254", Offset = "0x150F254", VA = "0x150F254")]
		private void Update()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x150F814", Offset = "0x150F814", VA = "0x150F814", Slot = "4")]
		public virtual bool HasRequiredFocus()
		{
			return default(bool);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x150F34C", Offset = "0x150F34C", VA = "0x150F34C")]
		public void CheckHeadControls()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x150F84C", Offset = "0x150F84C", VA = "0x150F84C")]
		public void UpdateInputs()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x150F5A4", Offset = "0x150F5A4", VA = "0x150F5A4")]
		public void CheckPlayerControls()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1510128", Offset = "0x1510128", VA = "0x1510128")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x151012C", Offset = "0x151012C", VA = "0x151012C", Slot = "5")]
		public virtual void UpdateControllerPositions()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x150FED0", Offset = "0x150FED0", VA = "0x150FED0")]
		private void checkGrabbers()
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1510244", Offset = "0x1510244", VA = "0x1510244", Slot = "6")]
		public virtual void ResetHands()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x15103B0", Offset = "0x15103B0", VA = "0x15103B0", Slot = "7")]
		public virtual void ResetAll()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x15104C4", Offset = "0x15104C4", VA = "0x15104C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x15109C0", Offset = "0x15109C0", VA = "0x15109C0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x1510ED4", Offset = "0x1510ED4", VA = "0x1510ED4")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1510EE0", Offset = "0x1510EE0", VA = "0x1510EE0")]
		public VREmulator()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class Waypoint : MonoBehaviour
	{
		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Waypoint Destination;

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1510F30", Offset = "0x1510F30", VA = "0x1510F30")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x1511088", Offset = "0x1511088", VA = "0x1511088")]
		public Waypoint()
		{
		}
	}
	[Token(Token = "0x20000FD")]
	public class Zipline : GrabbableEvents
	{
		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform ZiplineStart;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform ZiplineEnd;

		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float ZiplineSpeed;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool UseLinearMovement;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastMoveTime;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool movingForward;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private AudioSource audioSource;

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x1511090", Offset = "0x1511090", VA = "0x1511090")]
		private void Start()
		{
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0x1511154", Offset = "0x1511154", VA = "0x1511154")]
		private void Update()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x151121C", Offset = "0x151121C", VA = "0x151121C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x1511334", Offset = "0x1511334", VA = "0x1511334", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x151166C", Offset = "0x151166C", VA = "0x151166C", Slot = "19")]
		public override void OnButton1()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x15116A4", Offset = "0x15116A4", VA = "0x15116A4", Slot = "22")]
		public override void OnButton2()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x1511388", Offset = "0x1511388", VA = "0x1511388")]
		private void moveTowards(Vector3 pos, bool forwardDirection)
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x15116DC", Offset = "0x15116DC", VA = "0x15116DC")]
		public Zipline()
		{
		}
	}
	[Token(Token = "0x20000FE")]
	public class ControllerOffsetHelper : MonoBehaviour
	{
		[Token(Token = "0x20000FF")]
		[CompilerGenerated]
		private sealed class <checkForController>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400081D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400081E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400081F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ControllerOffsetHelper <>4__this;

			[Token(Token = "0x17000069")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0x1512024", Offset = "0x1512024", VA = "0x1512024", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700006A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x151206C", Offset = "0x151206C", VA = "0x151206C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x15117F8", Offset = "0x15117F8", VA = "0x15117F8")]
			[DebuggerHidden]
			public <checkForController>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x1511F30", Offset = "0x1511F30", VA = "0x1511F30", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000584")]
			[Address(RVA = "0x1511F34", Offset = "0x1511F34", VA = "0x1511F34", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x151202C", Offset = "0x151202C", VA = "0x151202C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ControllerHand ControllerHand;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Header("Shown for Debug :")]
		[Tooltip("The model of controller found")]
		[SerializeField]
		private string thisControllerModel;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ControllerOffset thisOffset;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The position offset is defined within this script and loaded once the controller is found.")]
		public Vector3 OffsetPosition;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The rotation offset is defined within this script and loaded once the controller is found.")]
		public Vector3 OffsetRotation;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<ControllerOffset> ControllerOffsets;

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x1511700", Offset = "0x1511700", VA = "0x1511700")]
		private void Start()
		{
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x1511790", Offset = "0x1511790", VA = "0x1511790")]
		[IteratorStateMachine(typeof(<checkForController>d__7))]
		private IEnumerator checkForController()
		{
			return null;
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x1511820", Offset = "0x1511820", VA = "0x1511820", Slot = "4")]
		public virtual void OnControllerFound()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x1511930", Offset = "0x1511930", VA = "0x1511930", Slot = "5")]
		public virtual ControllerOffset GetControllerOffset(string controllerName)
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x1511A30", Offset = "0x1511A30", VA = "0x1511A30", Slot = "6")]
		public virtual void DefineControllerOffsets()
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x1511E60", Offset = "0x1511E60", VA = "0x1511E60", Slot = "7")]
		public virtual ControllerOffset GetOpenXROffset()
		{
			return null;
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x1511EFC", Offset = "0x1511EFC", VA = "0x1511EFC")]
		public ControllerOffsetHelper()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class ControllerOffset
	{
		[Token(Token = "0x1700006B")]
		public string ControllerName
		{
			[Token(Token = "0x6000588")]
			[Address(RVA = "0x1512074", Offset = "0x1512074", VA = "0x1512074")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000589")]
			[Address(RVA = "0x151207C", Offset = "0x151207C", VA = "0x151207C")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public Vector3 LeftControllerPositionOffset
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1512084", Offset = "0x1512084", VA = "0x1512084")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1512090", Offset = "0x1512090", VA = "0x1512090")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public Vector3 RightControllerPositionOffset
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x151209C", Offset = "0x151209C", VA = "0x151209C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x15120A8", Offset = "0x15120A8", VA = "0x15120A8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006E")]
		public Vector3 LeftControllerRotationOffset
		{
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x15120B4", Offset = "0x15120B4", VA = "0x15120B4")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600058F")]
			[Address(RVA = "0x15120C0", Offset = "0x15120C0", VA = "0x15120C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public Vector3 RightControlleRotationOffset
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x15120CC", Offset = "0x15120CC", VA = "0x15120CC")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000591")]
			[Address(RVA = "0x15120D8", Offset = "0x15120D8", VA = "0x15120D8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1511E58", Offset = "0x1511E58", VA = "0x1511E58")]
		public ControllerOffset()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class DetachableLimb : MonoBehaviour
	{
		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform ShrinkBone;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject ReplaceGrabbableWith;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject EnableOnDetach;

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x15120E4", Offset = "0x15120E4", VA = "0x15120E4")]
		public void DoDismemberment(Grabber grabbedBy)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1512394", Offset = "0x1512394", VA = "0x1512394")]
		public void ReverseDismemberment()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x15124B4", Offset = "0x15124B4", VA = "0x15124B4")]
		public DetachableLimb()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class DoorHelper : MonoBehaviour
	{
		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip DoorOpenSound;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip DoorCloseSound;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Does the handle need to be turned in order to open the door from the closed position?")]
		public bool RequireHandleTurnToOpen;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool handleLocked;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform HandleFollower;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float DegreesTurned;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float DegreesTurnToOpen;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform DoorLockTransform;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float initialLockPosition;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private HingeJoint hinge;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody rigid;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool playedOpenSound;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool readyToPlayCloseSound;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float AngularVelocitySnapDoor;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float angle;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float AngularVelocity;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("If true the door will not respond to user input")]
		public bool DoorIsLocked;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float lockPos;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 currentRotation;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float moveLockAmount;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float rotateAngles;

		[Token(Token = "0x400083D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float ratio;

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x15124BC", Offset = "0x15124BC", VA = "0x15124BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1512594", Offset = "0x1512594", VA = "0x1512594")]
		private void Update()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1512A0C", Offset = "0x1512A0C", VA = "0x1512A0C")]
		public DoorHelper()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class GrabberArea : MonoBehaviour
	{
		[Token(Token = "0x400083E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabber InArea;

		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public List<Grabber> grabbersInArea;

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1512A2C", Offset = "0x1512A2C", VA = "0x1512A2C")]
		private void Update()
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x1512A44", Offset = "0x1512A44", VA = "0x1512A44")]
		public Grabber GetOpenGrabber()
		{
			return null;
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x1512BD4", Offset = "0x1512BD4", VA = "0x1512BD4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1512D54", Offset = "0x1512D54", VA = "0x1512D54")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1512E48", Offset = "0x1512E48", VA = "0x1512E48")]
		public GrabberArea()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class HandCollision : MonoBehaviour
	{
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HandController HandControl;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabber HandGrabber;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool EnableHandCollision;

		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool EnableCollisionOnPoint;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
		public bool EnableCollisionOnFist;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
		public bool EnableCollisionOnAllPoses;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool EnableCollisionDuringGrab;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float PointAmount;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float GripAmount;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool MakingFist;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private List<Collider> handColliders;

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1512E50", Offset = "0x1512E50", VA = "0x1512E50")]
		private void Start()
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1512FB0", Offset = "0x1512FB0", VA = "0x1512FB0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1513254", Offset = "0x1513254", VA = "0x1513254")]
		public HandCollision()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class HandController : MonoBehaviour
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("HandController parent will be set to this on Start if specified")]
		public Transform HandAnchor;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If true, this transform will be parented to HandAnchor and it's position / rotation set to 0,0,0.")]
		public bool ResetHandAnchorPosition;

		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator HandAnimator;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) If specified, this HandPoser can be used when setting poses retrieved from a grabbed Grabbable.")]
		public HandPoser handPoser;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) If specified, this AutoPoser component can be used when if set on the Grabbable, or if AutoPose is set to true")]
		public AutoPoser autoPoser;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("If true, this hand will autopose when not holding a Grabbable. AutoPoser must be specified.")]
		public bool AutoPoseWhenNoGrabbable;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("How fast to Lerp the Layer Animations")]
		public float HandAnimationSpeed;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Check the state of this grabber to determine animation state. If null, a child Grabber component will be used.")]
		public Grabber grabber;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Shown for Debug : ")]
		public float GripAmount;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float _prevGrip;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float PointAmount;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float _prevPoint;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float ThumbAmount;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _prevThumb;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int PoseId;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private ControllerOffsetHelper offset;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private InputBridge input;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Rigidbody rigid;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform offsetTransform;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject PreviousHeldObject;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool DoUpdateAnimationStates;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		public bool DoUpdateHandPoser;

		[Token(Token = "0x17000070")]
		private Vector3 offsetPosition
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x151326C", Offset = "0x151326C", VA = "0x151326C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000071")]
		private Vector3 offsetRotation
		{
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1513330", Offset = "0x1513330", VA = "0x1513330")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x15133F4", Offset = "0x15133F4", VA = "0x15133F4")]
		private void Start()
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1513718", Offset = "0x1513718", VA = "0x1513718")]
		public void Update()
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1513760", Offset = "0x1513760", VA = "0x1513760", Slot = "4")]
		public virtual void CheckForGrabChange()
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x15138C4", Offset = "0x15138C4", VA = "0x15138C4", Slot = "5")]
		public virtual void OnGrabChange(GameObject newlyHeldObject)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1513A1C", Offset = "0x1513A1C", VA = "0x1513A1C", Slot = "6")]
		public virtual void OnGrabDrop()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1513A78", Offset = "0x1513A78", VA = "0x1513A78", Slot = "7")]
		public virtual void SetHandAnimator()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x1513B28", Offset = "0x1513B28", VA = "0x1513B28", Slot = "8")]
		public virtual void UpdateFromInputs()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x1513D4C", Offset = "0x1513D4C", VA = "0x1513D4C", Slot = "9")]
		public virtual void UpdateAnimimationStates()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1514148", Offset = "0x1514148", VA = "0x1514148")]
		private void setAnimatorBlend(float min, float max, float input, int animationLayer)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1514170", Offset = "0x1514170", VA = "0x1514170", Slot = "10")]
		public virtual bool IsAnimatorGrabbable()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1514258", Offset = "0x1514258", VA = "0x1514258", Slot = "11")]
		public virtual void UpdateHandPoser()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x151439C", Offset = "0x151439C", VA = "0x151439C", Slot = "12")]
		public virtual void EnableHandPoser()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1514420", Offset = "0x1514420", VA = "0x1514420", Slot = "13")]
		public virtual void EnableAutoPoser(bool continuous)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x15145A0", Offset = "0x15145A0", VA = "0x15145A0", Slot = "14")]
		public virtual void DisableAutoPoser()
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1514618", Offset = "0x1514618", VA = "0x1514618", Slot = "15")]
		public virtual void EnableHandAnimator()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x15146B4", Offset = "0x15146B4", VA = "0x15146B4", Slot = "16")]
		public virtual void DisableHandAnimator()
		{
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1514750", Offset = "0x1514750", VA = "0x1514750", Slot = "17")]
		public virtual void OnGrabberGrabbed(Grabbable grabbed)
		{
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x151481C", Offset = "0x151481C", VA = "0x151481C", Slot = "18")]
		public virtual void OnGrabberReleased(Grabbable released)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1514828", Offset = "0x1514828", VA = "0x1514828")]
		public HandController()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class HandleGFXHelper : MonoBehaviour
	{
		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform LookAt;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable HandleGrabbable;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Speed;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float LocalYMin;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float LocalYMax;

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 initialRot;

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1514848", Offset = "0x1514848", VA = "0x1514848")]
		private void Start()
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1514878", Offset = "0x1514878", VA = "0x1514878")]
		private void Update()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1514B04", Offset = "0x1514B04", VA = "0x1514B04")]
		public HandleGFXHelper()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class HandleHelper : MonoBehaviour
	{
		[Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class <doRelease>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandleHelper <>4__this;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x1515188", Offset = "0x1515188", VA = "0x1515188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x15151D0", Offset = "0x15151D0", VA = "0x15151D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x15150A4", Offset = "0x15150A4", VA = "0x15150A4")]
			[DebuggerHidden]
			public <doRelease>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x15150D4", Offset = "0x15150D4", VA = "0x15150D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x15150D8", Offset = "0x15150D8", VA = "0x15150D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x1515190", Offset = "0x1515190", VA = "0x1515190", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody ParentRigid;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform HandleTransform;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Grabbable thisGrab;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Rigidbody rb;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool didRelease;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider col;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 lastAngularVelocity;

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1514B20", Offset = "0x1514B20", VA = "0x1514B20")]
		private void Start()
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1514C98", Offset = "0x1514C98", VA = "0x1514C98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1515070", Offset = "0x1515070", VA = "0x1515070")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1515008", Offset = "0x1515008", VA = "0x1515008")]
		[IteratorStateMachine(typeof(<doRelease>d__10))]
		private IEnumerator doRelease()
		{
			return null;
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x15150CC", Offset = "0x15150CC", VA = "0x15150CC")]
		public HandleHelper()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class HandPhysics : MonoBehaviour
	{
		[Token(Token = "0x200010A")]
		[CompilerGenerated]
		private sealed class <UnignoreAllCollisions>d__31 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HandPhysics <>4__this;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Grabbable <thisGrabbable>5__2;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005DF")]
				[Address(RVA = "0x15172A4", Offset = "0x15172A4", VA = "0x15172A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005E1")]
				[Address(RVA = "0x15172EC", Offset = "0x15172EC", VA = "0x15172EC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1516584", Offset = "0x1516584", VA = "0x1516584")]
			[DebuggerHidden]
			public <UnignoreAllCollisions>d__31(int <>1__state)
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x15171E4", Offset = "0x15171E4", VA = "0x15171E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x15171E8", Offset = "0x15171E8", VA = "0x15171E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x15172AC", Offset = "0x15172AC", VA = "0x15172AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("This is the object our physical hand should try to follow / match. Should typically be an object on the controller Transform")]
		public Transform AttachTo;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Amount of Velocity to apply to hands when trying to reach anchor point")]
		public float HandVelocity;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, Hand COlliders will be disabled while grabbing an object")]
		public bool DisableHandCollidersOnGrab;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If the hand exceeds this distance from it's origin it will snap back to the original position. Specified in meters.")]
		public float SnapBackDistance;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This is the Grabber to use when this hand is active.")]
		public Grabber ThisGrabber;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Disable this Grabber when this hand is active. (Optional)")]
		public Grabber DisableGrabber;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("This is the RemoteGrabber to use when this hand is active.")]
		public RemoteGrabber ThisRemoteGrabber;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Disable this RemoteGrabber when this hand is active. (Optional)")]
		public RemoteGrabber DisableRemoteGrabber;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Assign Hand Colliders this material if provided")]
		public PhysicMaterial ColliderMaterial;

		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform HandModel;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform HandModelOffset;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<Collider> handColliders;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody rigid;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ConfigurableJoint configJoint;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabbable heldGrabbable;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private List<Collider> collisions;

		[Token(Token = "0x4000881")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private LineRenderer line;

		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 localHandOffset;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 localHandOffsetRotation;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private bool wasHoldingObject;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Grabbable remoteIgnoredGrabbable;

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Transform _priorParent;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 _priorLocalOffsetPosition;

		[Token(Token = "0x17000074")]
		public bool HoldingObject
		{
			[Token(Token = "0x60005C4")]
			[Address(RVA = "0x15151D8", Offset = "0x15151D8", VA = "0x15151D8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x151527C", Offset = "0x151527C", VA = "0x151527C")]
		private void Start()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x15157D0", Offset = "0x15157D0", VA = "0x15157D0")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1515F98", Offset = "0x1515F98", VA = "0x1515F98")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x151556C", Offset = "0x151556C", VA = "0x151556C")]
		private void initHandColliders()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1515CF0", Offset = "0x1515CF0", VA = "0x1515CF0")]
		private void checkRemoteCollision()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1515B24", Offset = "0x1515B24", VA = "0x1515B24")]
		private void drawDistanceLine()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1515E6C", Offset = "0x1515E6C", VA = "0x1515E6C")]
		private void checkBreakDistance()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1515958", Offset = "0x1515958", VA = "0x1515958")]
		private void updateHandGraphics()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x151651C", Offset = "0x151651C", VA = "0x151651C")]
		[IteratorStateMachine(typeof(<UnignoreAllCollisions>d__31))]
		private IEnumerator UnignoreAllCollisions()
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1516404", Offset = "0x1516404", VA = "0x1516404")]
		public void IgnoreGrabbableCollisions(Grabbable grab, bool ignorePhysics)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x15165AC", Offset = "0x15165AC", VA = "0x15165AC")]
		public void DisableHandColliders()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x15166BC", Offset = "0x15166BC", VA = "0x15166BC")]
		public void EnableHandColliders()
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x15167CC", Offset = "0x15167CC", VA = "0x15167CC", Slot = "4")]
		public virtual void OnGrabbedObject(Grabbable grabbedObject)
		{
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x15167E4", Offset = "0x15167E4", VA = "0x15167E4", Slot = "5")]
		public virtual void LockLocalPosition()
		{
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1516828", Offset = "0x1516828", VA = "0x1516828", Slot = "6")]
		public virtual void UnlockLocalPosition()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1516850", Offset = "0x1516850", VA = "0x1516850", Slot = "7")]
		public virtual void OnReleasedObject(Grabbable grabbedObject)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x15168E8", Offset = "0x15168E8", VA = "0x15168E8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1516B7C", Offset = "0x1516B7C", VA = "0x1516B7C", Slot = "8")]
		public virtual void LockOffset()
		{
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1516BC8", Offset = "0x1516BC8", VA = "0x1516BC8", Slot = "9")]
		public virtual void UnlockOffset()
		{
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1516CF4", Offset = "0x1516CF4", VA = "0x1516CF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1516FAC", Offset = "0x1516FAC", VA = "0x1516FAC")]
		private void OnCollisionStay(Collision collision)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1517144", Offset = "0x1517144", VA = "0x1517144")]
		public bool IsValidCollision(Collider col)
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x151714C", Offset = "0x151714C", VA = "0x151714C")]
		public HandPhysics()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class HandRepresentationHelper : MonoBehaviour
	{
		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The GameObject to be shown or hidden depending on Distance from OtherHandTransform")]
		public Transform HandToToggle;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The other Hand Transform used to calculate distance")]
		public Transform OtherHandTransform;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Distance required to show this Transform in meters")]
		public float DistanceToShow;

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x15172F4", Offset = "0x15172F4", VA = "0x15172F4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x15173E8", Offset = "0x15173E8", VA = "0x15173E8")]
		public HandRepresentationHelper()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class IgnoreColliders : MonoBehaviour
	{
		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<Collider> CollidersToIgnore;

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x15173FC", Offset = "0x15173FC", VA = "0x15173FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x15175D0", Offset = "0x15175D0", VA = "0x15175D0")]
		public IgnoreColliders()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class InvalidTeleportArea : MonoBehaviour
	{
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x15175D8", Offset = "0x15175D8", VA = "0x15175D8")]
		public InvalidTeleportArea()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class JointBreaker : MonoBehaviour
	{
		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float BreakDistance;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float JointDistance;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool DestroyJointOnBreak;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrabberEvent OnBreakEvent;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Joint theJoint;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 startPos;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool brokeJoint;

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x15175E0", Offset = "0x15175E0", VA = "0x15175E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x1517654", Offset = "0x1517654", VA = "0x1517654")]
		private void Update()
		{
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x1517740", Offset = "0x1517740", VA = "0x1517740")]
		public void BreakJoint()
		{
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x15178B0", Offset = "0x15178B0", VA = "0x15178B0")]
		public JointBreaker()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class JointHelper : MonoBehaviour
	{
		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool LockXPosition;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool LockYPosition;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool LockZPosition;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B")]
		public bool LockXScale;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool LockYScale;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool LockZScale;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E")]
		public bool LockXRotation;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
		public bool LockYRotation;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool LockZRotation;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 initialPosition;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 initialRotation;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Vector3 initialScale;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3 currentPosition;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 currentScale;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentRotation;

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x15178C8", Offset = "0x15178C8", VA = "0x15178C8")]
		private void Start()
		{
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x1517938", Offset = "0x1517938", VA = "0x1517938")]
		private void lockPosition()
		{
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x1517B18", Offset = "0x1517B18", VA = "0x1517B18")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x1517B1C", Offset = "0x1517B1C", VA = "0x1517B1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x1517B20", Offset = "0x1517B20", VA = "0x1517B20")]
		public JointHelper()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class RagdollHelper : MonoBehaviour
	{
		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform player;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Collider> colliders;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider playerCol;

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x1517B38", Offset = "0x1517B38", VA = "0x1517B38")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1517D00", Offset = "0x1517D00", VA = "0x1517D00")]
		public RagdollHelper()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class RingHelper : MonoBehaviour
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Grabbable Object to Observe")]
		public Grabbable grabbable;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("(Optional) If specified, the ring helper will only be valid if this Grabpoint is the nearest on the the grabbable object")]
		public GrabPoint Grabpoint;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Default Color of the ring")]
		public Color RingColor;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Color to use if selected by primary controller")]
		public Color RingSelectedColor;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Color to use if selected by secondary controller")]
		public Color RingSecondarySelectedColor;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float ringSizeInRange;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float ringSizeGrabbable;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Don't show grab rings if left and right controllers / grabbers are  holding something")]
		public bool HideIfHandsAreFull;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("How fast to lerp the opacity if being hidden / shown")]
		public float RingFadeSpeed;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Canvas canvas;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Text text;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CanvasScaler scaler;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Grabber leftGrabber;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Grabber rightGrabber;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Grabber closestGrabber;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool handsFull;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private float _initalOpacity;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private float _currentOpacity;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform mainCam;

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1517D08", Offset = "0x1517D08", VA = "0x1517D08")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1517ED4", Offset = "0x1517ED4", VA = "0x1517ED4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x15184BC", Offset = "0x15184BC", VA = "0x15184BC", Slot = "4")]
		public virtual void AssignCamera()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1518598", Offset = "0x1518598", VA = "0x1518598", Slot = "5")]
		public virtual void AssignGrabbers()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x15183C8", Offset = "0x15183C8", VA = "0x15183C8")]
		private Color getSelectedColor()
		{
			return default(Color);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x15186D4", Offset = "0x15186D4", VA = "0x15186D4")]
		public RingHelper()
		{
		}
	}
	[Token(Token = "0x2000112")]
	public class ScaleMaterialHelper : MonoBehaviour
	{
		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer ren;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector2 Tiling;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector2 Offset;

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x156CD74", Offset = "0x156CD74", VA = "0x156CD74")]
		private void Start()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x156CDC8", Offset = "0x156CDC8", VA = "0x156CDC8")]
		private void updateTexture()
		{
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x156CEB8", Offset = "0x156CEB8", VA = "0x156CEB8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x156CEE0", Offset = "0x156CEE0", VA = "0x156CEE0")]
		public ScaleMaterialHelper()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class StaticBatch : MonoBehaviour
	{
		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Material CombineMaterial;

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x156CEF0", Offset = "0x156CEF0", VA = "0x156CEF0")]
		private void Start()
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x156D5A4", Offset = "0x156D5A4", VA = "0x156D5A4")]
		public StaticBatch()
		{
		}
	}
	[Token(Token = "0x2000114")]
	public class TeleportDestination : MonoBehaviour
	{
		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Where the player will be teleported to")]
		public Transform DestinationTransform;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Snap player to this rotation?")]
		public bool ForcePlayerRotation;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Called when a player uses the teleporter to enter this destination.")]
		public UnityEvent OnPlayerTeleported;

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x156D5AC", Offset = "0x156D5AC", VA = "0x156D5AC")]
		public TeleportDestination()
		{
		}
	}
	[Token(Token = "0x2000115")]
	public class TeleportPlayerOnEnter : MonoBehaviour
	{
		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform TeleportDestination;

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x156D5B4", Offset = "0x156D5B4", VA = "0x156D5B4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x156D6E8", Offset = "0x156D6E8", VA = "0x156D6E8")]
		public TeleportPlayerOnEnter()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class UITrigger : MonoBehaviour
	{
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x156D6F0", Offset = "0x156D6F0", VA = "0x156D6F0")]
		public UITrigger()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class VRIFGrabpointUpdater : MonoBehaviour
	{
		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Right Hand Model")]
		[Tooltip("This is the local position of the hand model that was defined in your previous xr rig, as well as what was used in the previewer.")]
		public Vector3 PriorModelOffsetRightPosition;

		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("This is the local position of the NEW hand model that is currently defined in your xr rig, as well as what is used in the previewer.")]
		public Vector3 NewModelOffsetRightPosition;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("This is the local rotation of the hand model that was defined in your previous xr rig, as well as what was used in the previewer.")]
		public Vector3 PriorModelOffsetRightRotation;

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("This is the local rotation of the NEW hand model that is currently defined in your xr rig, as well as what is used in the previewer.")]
		public Vector3 NewModelOffsetRightRotation;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Header("Left Hand Model")]
		[Tooltip("This is the local position of the hand model that was defined in your previous xr rig, as well as what was used in the previewer.")]
		public Vector3 PriorModelOffsetLeftPosition;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("This is the local position of the NEW hand model that is currently defined in your xr rig, as well as what is used in the previewer.")]
		public Vector3 NewModelOffsetLeftPosition;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("This is the local rotation of the hand model that was defined in your previous xr rig, as well as what was used in the previewer.")]
		public Vector3 PriorModelOffsetLeftRotation;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("This is the local rotation of the NEW hand model that is currently defined in your xr rig, as well as what is used in the previewer.")]
		public Vector3 NewModelOffsetLeftRotation;

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x156D6F8", Offset = "0x156D6F8", VA = "0x156D6F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x156D6FC", Offset = "0x156D6FC", VA = "0x156D6FC")]
		public void ApplyGrabPointUpdate()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x156DA68", Offset = "0x156DA68", VA = "0x156DA68")]
		public VRIFGrabpointUpdater()
		{
		}
	}
	[Token(Token = "0x2000118")]
	public class UIPointer : MonoBehaviour
	{
		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The controller side this pointer is on")]
		public ControllerHand ControllerSide;

		[Token(Token = "0x40008CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If true this object will update the VRUISystem's Left or Right Transform property")]
		public bool AutoUpdateUITransforms;

		[Token(Token = "0x40008CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject cursor;

		[Token(Token = "0x40008CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private GameObject _cursor;

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("If true the cursor and LineRenderer will be Hidden. Otherwise it will still be show at a fixed length")]
		public bool HidePointerIfNoObjectsFound;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("How long the line / cursor should extend if no objects are found to point at")]
		public float FixedPointerLength;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true the cursor object will scale based on how far away the pointer is from the origin. A cursor far away will have a larger cusor than one up close.")]
		public bool CursorScaling;

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Minimum scale of the Cursor object if CursorScaling is enabled")]
		public float CursorMinScale;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float CursorMaxScale;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 _cursorInitialLocalScale;

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Example : 0.5 = Line Goes Half Way. 1 = Line reaches end.")]
		public float LineDistanceModifier;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private VRUISystem uiSystem;

		[Token(Token = "0x40008D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private PointerEvents selectedPointerEvents;

		[Token(Token = "0x40008D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private PointerEventData data;

		[Token(Token = "0x40008DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("LineRenderer to use when showing a valid UI Canvas. Leave null to attempt a GetComponent<> on this object.")]
		public LineRenderer lineRenderer;

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x156DAB8", Offset = "0x156DAB8", VA = "0x156DAB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x156DDE4", Offset = "0x156DDE4", VA = "0x156DDE4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x156DE64", Offset = "0x156DE64", VA = "0x156DE64")]
		public void Update()
		{
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x156E408", Offset = "0x156E408", VA = "0x156E408", Slot = "4")]
		public virtual void HidePointer()
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x156E580", Offset = "0x156E580", VA = "0x156E580")]
		public UIPointer()
		{
		}
	}
	[Token(Token = "0x2000119")]
	[RequireComponent(typeof(GraphicRaycaster))]
	[RequireComponent(typeof(Canvas))]
	public class VRCanvas : MonoBehaviour
	{
		[Token(Token = "0x600060A")]
		[Address(RVA = "0x156E5BC", Offset = "0x156E5BC", VA = "0x156E5BC")]
		private void Start()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x156E62C", Offset = "0x156E62C", VA = "0x156E62C")]
		public VRCanvas()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public class VRUISystem : BaseInputModule
	{
		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("XR Controller Options : ")]
		[Tooltip("This setting determines if LeftPointerTransform or RightPointerTransform will be used as a forward vector for World Space UI events")]
		public ControllerHand SelectedHand;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("A transform on the left controller to use when raycasting for world space UI events")]
		public Transform LeftPointerTransform;

		[Token(Token = "0x40008DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("A transform on the right controller to use when raycasting for world space UI events")]
		public Transform RightPointerTransform;

		[Token(Token = "0x40008DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Controller Binding to use for input down, up, etc.")]
		public List<ControllerBinding> ControllerInput;

		[Token(Token = "0x40008DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Unity Input Action used to simulate a click or touch event")]
		public InputActionReference UIInputAction;

		[Token(Token = "0x40008E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("If true a PhysicsRaycaster component will be added to the UI camera, allowing physical objects to use IPointer events such as OnPointClick, OnPointEnter, etc.")]
		public bool AddPhysicsRaycaster;

		[Token(Token = "0x40008E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public LayerMask PhysicsRaycasterEventMask;

		[Token(Token = "0x40008E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("If true the Right Thumbstick will send scroll events to the UI")]
		public bool RightThumbstickScroll;

		[Token(Token = "0x40008E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("Shown for Debug : ")]
		public GameObject PressingObject;

		[Token(Token = "0x40008E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public GameObject DraggingObject;

		[Token(Token = "0x40008E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public GameObject ReleasingObject;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera cameraCaster;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private GameObject _initialPressObject;

		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool _lastInputDown;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		private bool inputDown;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VRUISystem _instance;

		[Token(Token = "0x17000077")]
		public PointerEventData EventData
		{
			[Token(Token = "0x600060C")]
			[Address(RVA = "0x156E634", Offset = "0x156E634", VA = "0x156E634")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x156E63C", Offset = "0x156E63C", VA = "0x156E63C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public static VRUISystem Instance
		{
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x156DC04", Offset = "0x156DC04", VA = "0x156DC04")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x156E644", Offset = "0x156E644", VA = "0x156E644", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x156E724", Offset = "0x156E724", VA = "0x156E724")]
		private void init()
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x156E890", Offset = "0x156E890", VA = "0x156E890", Slot = "17")]
		public override void Process()
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x156EC4C", Offset = "0x156EC4C", VA = "0x156EC4C", Slot = "27")]
		public virtual bool InputReady()
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x156EDC4", Offset = "0x156EDC4", VA = "0x156EDC4", Slot = "28")]
		public virtual bool CameraCasterReady()
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x156EE5C", Offset = "0x156EE5C", VA = "0x156EE5C", Slot = "29")]
		public virtual void PressDown()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x156F06C", Offset = "0x156F06C", VA = "0x156F06C", Slot = "30")]
		public virtual void Press()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x156F238", Offset = "0x156F238", VA = "0x156F238", Slot = "31")]
		public virtual void Release()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x156F494", Offset = "0x156F494", VA = "0x156F494", Slot = "32")]
		public virtual void ClearAll()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x156F510", Offset = "0x156F510", VA = "0x156F510", Slot = "33")]
		public virtual void SetPressingObject(GameObject pressing)
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x156F544", Offset = "0x156F544", VA = "0x156F544", Slot = "34")]
		public virtual void SetDraggingObject(GameObject dragging)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x156F564", Offset = "0x156F564", VA = "0x156F564", Slot = "35")]
		public virtual void SetReleasingObject(GameObject releasing)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x156F56C", Offset = "0x156F56C", VA = "0x156F56C", Slot = "36")]
		public virtual void AssignCameraToAllCanvases(Camera cam)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x156F640", Offset = "0x156F640", VA = "0x156F640", Slot = "37")]
		public virtual void AddCanvas(Canvas canvas)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x156F654", Offset = "0x156F654", VA = "0x156F654", Slot = "38")]
		public virtual void AddCanvasToCamera(Canvas canvas, Camera cam)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x156F670", Offset = "0x156F670", VA = "0x156F670", Slot = "39")]
		public virtual void UpdateControllerHand(ControllerHand hand)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x156F818", Offset = "0x156F818", VA = "0x156F818")]
		public VRUISystem()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class DestroyIfPlayMode : MonoBehaviour
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x156F914", Offset = "0x156F914", VA = "0x156F914")]
		private void Start()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x156F9C4", Offset = "0x156F9C4", VA = "0x156F9C4")]
		public DestroyIfPlayMode()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class VRUtils : MonoBehaviour
	{
		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static VRUtils _instance;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color LogTextColor;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Color WarnTextColor;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Color ErrTextColor;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform DebugTextHolder;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float MaxTextEntries;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public string LastDebugMsg;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int lastDebugMsgCount;

		[Token(Token = "0x17000079")]
		public static VRUtils Instance
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x156F9CC", Offset = "0x156F9CC", VA = "0x156F9CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x156FB20", Offset = "0x156FB20", VA = "0x156FB20")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x156FC10", Offset = "0x156FC10", VA = "0x156FC10")]
		public void Log(string msg)
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1570158", Offset = "0x1570158", VA = "0x1570158")]
		public void Warn(string msg)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x15701E8", Offset = "0x15701E8", VA = "0x15701E8")]
		public void Error(string msg)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x156FCA0", Offset = "0x156FCA0", VA = "0x156FCA0")]
		public void VRDebugLog(string msg, Color logColor)
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1570278", Offset = "0x1570278", VA = "0x1570278")]
		public void CullDebugPanel()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1570340", Offset = "0x1570340", VA = "0x1570340")]
		public AudioSource PlaySpatialClipAt(AudioClip clip, Vector3 pos, float volume, float spatialBlend = 1f, float randomizePitch = 0f)
		{
			return null;
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x15704F8", Offset = "0x15704F8", VA = "0x15704F8")]
		private float getRandomizedPitch(float randomAmount)
		{
			return default(float);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x157053C", Offset = "0x157053C", VA = "0x157053C")]
		public VRUtils()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class AmmoDispenser : MonoBehaviour
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Grabber LeftGrabber;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabber RightGrabber;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject AmmoDispenserObject;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject PistolClip;

		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public GameObject ShotgunShell;

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject RifleClip;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public int CurrentPistolClips;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int CurrentRifleClips;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int CurrentShotgunShells;

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1570570", Offset = "0x1570570", VA = "0x1570570")]
		private void Update()
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x15705E4", Offset = "0x15705E4", VA = "0x15705E4")]
		private bool grabberHasWeapon(Grabber g)
		{
			return default(bool);
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1570720", Offset = "0x1570720", VA = "0x1570720")]
		public GameObject GetAmmo()
		{
			return null;
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1570A48", Offset = "0x1570A48", VA = "0x1570A48")]
		public void GrabAmmo(Grabber grabber)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1570CF4", Offset = "0x1570CF4", VA = "0x1570CF4", Slot = "4")]
		public virtual void AddAmmo(string AmmoName)
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1570DD0", Offset = "0x1570DD0", VA = "0x1570DD0")]
		public AmmoDispenser()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class AmmoDisplay : MonoBehaviour
	{
		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RaycastWeapon Weapon;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Text AmmoLabel;

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1570DE8", Offset = "0x1570DE8", VA = "0x1570DE8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1570ECC", Offset = "0x1570ECC", VA = "0x1570ECC")]
		public AmmoDisplay()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class Bullet : MonoBehaviour
	{
		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1570ED4", Offset = "0x1570ED4", VA = "0x1570ED4")]
		public Bullet()
		{
		}
	}
	[Token(Token = "0x2000120")]
	public class BulletInsert : MonoBehaviour
	{
		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RaycastWeapon Weapon;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string AcceptBulletName;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip InsertSound;

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1570EDC", Offset = "0x1570EDC", VA = "0x1570EDC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1571124", Offset = "0x1571124", VA = "0x1571124")]
		public BulletInsert()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class MagazineSlide : MonoBehaviour
	{
		[Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class <EjectMagRoutine>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000911")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000912")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000913")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grabbable ejectedMag;

			[Token(Token = "0x4000914")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MagazineSlide <>4__this;

			[Token(Token = "0x1700007A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000647")]
				[Address(RVA = "0x15724B8", Offset = "0x15724B8", VA = "0x15724B8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x1572500", Offset = "0x1572500", VA = "0x1572500", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000644")]
			[Address(RVA = "0x1571FD0", Offset = "0x1571FD0", VA = "0x1571FD0")]
			[DebuggerHidden]
			public <EjectMagRoutine>d__23(int <>1__state)
			{
			}

			[Token(Token = "0x6000645")]
			[Address(RVA = "0x157224C", Offset = "0x157224C", VA = "0x157224C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000646")]
			[Address(RVA = "0x1572250", Offset = "0x1572250", VA = "0x1572250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000648")]
			[Address(RVA = "0x15724C0", Offset = "0x15724C0", VA = "0x15724C0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string AcceptableMagazineName;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Grabbable AttachedWeapon;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float ClipSnapDistance;

		[Token(Token = "0x4000905")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ClipUnsnapDistance;

		[Token(Token = "0x4000906")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float EjectForce;

		[Token(Token = "0x4000907")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Grabbable HeldMagazine;

		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Collider HeldCollider;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float MagazineDistance;

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool magazineInPlace;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool lockedInPlace;

		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AudioClip ClipAttachSound;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AudioClip ClipDetachSound;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private RaycastWeapon parentWeapon;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private GrabberArea grabClipArea;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float lastEjectTime;

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1571174", Offset = "0x1571174", VA = "0x1571174")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x15712CC", Offset = "0x15712CC", VA = "0x15712CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x15718B8", Offset = "0x15718B8", VA = "0x15718B8")]
		private bool recentlyEjected()
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1571868", Offset = "0x1571868", VA = "0x1571868")]
		private void moveMagazine(Vector3 localPosition)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x15716A0", Offset = "0x15716A0", VA = "0x15716A0")]
		public void CheckGrabClipInput()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x15718E8", Offset = "0x15718E8", VA = "0x15718E8")]
		private void attachMagazine()
		{
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1571B98", Offset = "0x1571B98", VA = "0x1571B98")]
		private Grabbable detachMagazine()
		{
			return null;
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1571F18", Offset = "0x1571F18", VA = "0x1571F18")]
		public void EjectMagazine()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1571F5C", Offset = "0x1571F5C", VA = "0x1571F5C")]
		[IteratorStateMachine(typeof(<EjectMagRoutine>d__23))]
		private IEnumerator EjectMagRoutine(Grabbable ejectedMag)
		{
			return null;
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1571E4C", Offset = "0x1571E4C", VA = "0x1571E4C")]
		public void OnGrabClipArea(Grabber grabbedBy)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1571FF8", Offset = "0x1571FF8", VA = "0x1571FF8", Slot = "4")]
		public virtual void AttachGrabbableMagazine(Grabbable mag, Collider magCollider)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x15720CC", Offset = "0x15720CC", VA = "0x15720CC")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x15721E8", Offset = "0x15721E8", VA = "0x15721E8")]
		public MagazineSlide()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class Projectile : MonoBehaviour
	{
		[Token(Token = "0x2000124")]
		[CompilerGenerated]
		private sealed class <CheckForRaycast>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400091D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400091E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400091F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Projectile <>4__this;

			[Token(Token = "0x1700007C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000654")]
				[Address(RVA = "0x1572E2C", Offset = "0x1572E2C", VA = "0x1572E2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1572E74", Offset = "0x1572E74", VA = "0x1572E74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1572D0C", Offset = "0x1572D0C", VA = "0x1572D0C")]
			[DebuggerHidden]
			public <CheckForRaycast>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1572D54", Offset = "0x1572D54", VA = "0x1572D54", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x1572D58", Offset = "0x1572D58", VA = "0x1572D58", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1572E34", Offset = "0x1572E34", VA = "0x1572E34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject HitFXPrefab;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool _checkRaycast;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float Damage;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AddRigidForce;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask ValidLayers;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool StickToObject;

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MinForceHit;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Unity Event called when the projectile damages something")]
		public UnityEvent onDealtDamageEvent;

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1572508", Offset = "0x1572508", VA = "0x1572508")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1572514", Offset = "0x1572514", VA = "0x1572514", Slot = "4")]
		public virtual void OnCollisionEvent(Collision collision)
		{
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x157289C", Offset = "0x157289C", VA = "0x157289C", Slot = "5")]
		public virtual void DoHitFX(Vector3 pos, Quaternion rot, Collider col)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1572A80", Offset = "0x1572A80", VA = "0x1572A80", Slot = "6")]
		public virtual void MarkAsRaycastBullet()
		{
		}

		[Token(Token = "0x600064E")]
		[Address(RVA = "0x1572B10", Offset = "0x1572B10", VA = "0x1572B10", Slot = "7")]
		public virtual void DoRayCastProjectile()
		{
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0x1572AA8", Offset = "0x1572AA8", VA = "0x1572AA8")]
		[IteratorStateMachine(typeof(<CheckForRaycast>d__13))]
		private IEnumerator CheckForRaycast()
		{
			return null;
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1572D34", Offset = "0x1572D34", VA = "0x1572D34")]
		public Projectile()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class RaycastWeapon : GrabbableEvents
	{
		[Token(Token = "0x2000126")]
		[CompilerGenerated]
		private sealed class <doMuzzleFlash>d__74 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000955")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000956")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RaycastWeapon <>4__this;

			[Token(Token = "0x1700007E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000672")]
				[Address(RVA = "0x1574B98", Offset = "0x1574B98", VA = "0x1574B98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x1574BE0", Offset = "0x1574BE0", VA = "0x1574BE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1574790", Offset = "0x1574790", VA = "0x1574790")]
			[DebuggerHidden]
			public <doMuzzleFlash>d__74(int <>1__state)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1574A78", Offset = "0x1574A78", VA = "0x1574A78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1574A7C", Offset = "0x1574A7C", VA = "0x1574A7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1574BA0", Offset = "0x1574BA0", VA = "0x1574BA0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000127")]
		[CompilerGenerated]
		private sealed class <animateSlideAndEject>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RaycastWeapon <>4__this;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <frames>5__2;

			[Token(Token = "0x400095C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private bool <slideEndReached>5__3;

			[Token(Token = "0x400095D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 <slideDestination>5__4;

			[Token(Token = "0x400095E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private bool <slideBeginningReached>5__5;

			[Token(Token = "0x17000080")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000678")]
				[Address(RVA = "0x15752FC", Offset = "0x15752FC", VA = "0x15752FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000081")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600067A")]
				[Address(RVA = "0x1575344", Offset = "0x1575344", VA = "0x1575344", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000675")]
			[Address(RVA = "0x15747B8", Offset = "0x15747B8", VA = "0x15747B8")]
			[DebuggerHidden]
			public <animateSlideAndEject>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1574BE8", Offset = "0x1574BE8", VA = "0x1574BE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1574BEC", Offset = "0x1574BEC", VA = "0x1574BEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1575304", Offset = "0x1575304", VA = "0x1575304", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("General : ")]
		public float MaxRange;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float Damage;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Semi requires user to press trigger repeatedly, Auto to hold down")]
		public FiringType FiringMethod;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public ReloadType ReloadMethod;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Ex : 0.2 = 5 Shots per second")]
		public float FiringRate;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float lastShotTime;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Amount of force to apply to a Rigidbody once damaged")]
		public float BulletImpactForce;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Current Internal Ammo if you are keeping track of ammo yourself. Firing will deduct from this number. Reloading will cause this to equal MaxInternalAmmo.")]
		public float InternalAmmo;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Maximum amount of internal ammo this weapon can hold. Does not account for attached clips.  For example, a shotgun has internal ammo")]
		public float MaxInternalAmmo;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("Set true to automatically chamber a new round on fire. False to require charging. Example : Bolt-Action Rifle does not auto chamber. ")]
		public bool AutoChamberRounds;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
		[Tooltip("Does it matter if rounds are chambered or not. Does the user have to charge weapon as soon as ammo is inserted")]
		public bool MustChamberRounds;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x56")]
		[Tooltip("If true a projectile will always be used instead of a raycast")]
		[Header("Projectile Settings : ")]
		public bool AlwaysFireProjectile;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x57")]
		[Tooltip("If true the ProjectilePrefab will be instantiated during slowmo instead of using a raycast.")]
		public bool FireProjectileInSlowMo;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("How fast to fire the weapon during slowmo. Keep in mind this is affected by Time.timeScale")]
		public float SlowMoRateOfFire;

		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Amount of force to apply to Projectile")]
		public float ShotForce;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Amount of force to apply to the BulletCasingPrefab object")]
		public float BulletCasingForce;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("How much force to apply to the tip of the barrel")]
		[Header("Recoil : ")]
		public Vector3 RecoilForce;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Time in seconds to allow the gun to be springy")]
		public float RecoilDuration;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody weaponRigid;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Raycast Options : ")]
		public LayerMask ValidLayers;

		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Header("Weapon Setup : ")]
		[Tooltip("Transform of trigger to animate rotation of")]
		public Transform TriggerTransform;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("Animate this back on fire")]
		public Transform SlideTransform;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Where our raycast or projectile will start from.")]
		public Transform MuzzlePointTransform;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Tooltip("Where to eject a bullet casing (optional)")]
		public Transform EjectPointTransform;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Tooltip("Transform of Chambered Bullet inside the weapon. Hide this when no bullet is chambered. (Optional)")]
		public Transform ChamberedBullet;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Tooltip("Make this active on fire. Randomize scale / rotation")]
		public GameObject MuzzleFlashObject;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("Eject this at EjectPointTransform (optional)")]
		public GameObject BulletCasingPrefab;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("If time is slowed this object will be instantiated at muzzle point instead of using a raycast")]
		public GameObject ProjectilePrefab;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Hit Effects spawned at point of impact")]
		public GameObject HitFXPrefab;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Tooltip("Play this sound on shoot")]
		public AudioClip GunShotSound;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("Volume to play the GunShotSound clip at. Range 0-1")]
		[Range(0f, 1f)]
		public float GunShotVolume;

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("Play this sound if no ammo and user presses trigger")]
		public AudioClip EmptySound;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Range(0f, 1f)]
		[Tooltip("Volume to play the EmptySound clip at. Range 0-1")]
		public float EmptySoundVolume;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[Tooltip("How far back to move the slide on fire")]
		[Header("Slide Configuration : ")]
		public float SlideDistance;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("Should the slide be forced back if we shoot the last bullet")]
		public bool ForceSlideBackOnLastShot;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[Tooltip("How fast to move back the slide on fire. Default : 1")]
		public float slideSpeed;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private float minSlideDistance;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Header("Inputs : ")]
		[Tooltip("Controller Input used to eject clip")]
		public List<GrabbedControllerBinding> EjectInput;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Tooltip("Controller Input used to release the charging mechanism.")]
		public List<GrabbedControllerBinding> ReleaseSlideInput;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[Tooltip("Controller Input used to release reload the weapon if ReloadMethod = InternalAmmo.")]
		public List<GrabbedControllerBinding> ReloadInput;

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[Tooltip("Is there currently a bullet chambered and ready to be fired")]
		[Header("Shown for Debug : ")]
		public bool BulletInChamber;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
		[Tooltip("Is there currently a bullet chambered and that must be ejected")]
		public bool EmptyBulletInChamber;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[Tooltip("Unity Event called when Shoot() method is successfully called")]
		[Header("Events")]
		public UnityEvent onShootEvent;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[Tooltip("Unity Event called when something attaches ammo to the weapon")]
		public UnityEvent onAttachedAmmoEvent;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[Tooltip("Unity Event called when something detaches ammo from the weapon")]
		public UnityEvent onDetachedAmmoEvent;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		[Tooltip("Unity Event called when the charging handle is successfully pulled back on the weapon")]
		public UnityEvent onWeaponChargedEvent;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Tooltip("Unity Event called when weapon damaged something")]
		public FloatEvent onDealtDamageEvent;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		[Tooltip("Passes along Raycast Hit info whenever a Raycast hit is successfully detected. Use this to display fx, add force, etc.")]
		public RaycastHitEvent onRaycastHitEvent;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private bool slideForcedBack;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private WeaponSlide ws;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private bool readyToShoot;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
		private bool playedEmptySound;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private IEnumerator shotRoutine;

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1572E7C", Offset = "0x1572E7C", VA = "0x1572E7C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1572FF8", Offset = "0x1572FF8", VA = "0x1572FF8", Slot = "16")]
		public override void OnTrigger(float triggerValue)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1573134", Offset = "0x1573134", VA = "0x1573134")]
		private void checkSlideInput()
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x157323C", Offset = "0x157323C", VA = "0x157323C")]
		private void checkEjectInput()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1573344", Offset = "0x1573344", VA = "0x1573344", Slot = "27")]
		public virtual void CheckReloadInput()
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1573458", Offset = "0x1573458", VA = "0x1573458", Slot = "28")]
		public virtual void UnlockSlide()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x15734E0", Offset = "0x15734E0", VA = "0x15734E0", Slot = "29")]
		public virtual void EjectMagazine()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1573590", Offset = "0x1573590", VA = "0x1573590", Slot = "30")]
		public virtual void Shoot()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1573C3C", Offset = "0x1573C3C", VA = "0x1573C3C", Slot = "31")]
		public virtual void ApplyRecoil()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1573DB4", Offset = "0x1573DB4", VA = "0x1573DB4", Slot = "32")]
		public virtual void OnRaycastHit(RaycastHit hit)
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x15740FC", Offset = "0x15740FC", VA = "0x15740FC", Slot = "33")]
		public virtual void ApplyParticleFX(Vector3 position, Quaternion rotation, Collider attachTo)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x157425C", Offset = "0x157425C", VA = "0x157425C", Slot = "34")]
		public virtual void OnAttachedAmmo()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1574284", Offset = "0x1574284", VA = "0x1574284", Slot = "35")]
		public virtual void OnDetachedAmmo()
		{
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x15742AC", Offset = "0x15742AC", VA = "0x15742AC", Slot = "36")]
		public virtual int GetBulletCount()
		{
			return default(int);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1574340", Offset = "0x1574340", VA = "0x1574340", Slot = "37")]
		public virtual void RemoveBullet()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1574444", Offset = "0x1574444", VA = "0x1574444", Slot = "38")]
		public virtual void Reload()
		{
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1572F4C", Offset = "0x1572F4C", VA = "0x1572F4C")]
		private void updateChamberedBullet()
		{
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1573B20", Offset = "0x1573B20", VA = "0x1573B20")]
		private void chamberRound()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1574450", Offset = "0x1574450", VA = "0x1574450")]
		private void randomizeMuzzleFlashScaleRotation()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1574538", Offset = "0x1574538", VA = "0x1574538", Slot = "39")]
		public virtual void OnWeaponCharged(bool allowCasingEject)
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x15745EC", Offset = "0x15745EC", VA = "0x15745EC", Slot = "40")]
		protected virtual void ejectCasing()
		{
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1573BD4", Offset = "0x1573BD4", VA = "0x1573BD4")]
		[IteratorStateMachine(typeof(<doMuzzleFlash>d__74))]
		private IEnumerator doMuzzleFlash()
		{
			return null;
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1573B6C", Offset = "0x1573B6C", VA = "0x1573B6C")]
		[IteratorStateMachine(typeof(<animateSlideAndEject>d__75))]
		private IEnumerator animateSlideAndEject()
		{
			return null;
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x15747E0", Offset = "0x15747E0", VA = "0x15747E0")]
		public RaycastWeapon()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public enum FiringType
	{
		[Token(Token = "0x4000960")]
		Semi,
		[Token(Token = "0x4000961")]
		Automatic
	}
	[Token(Token = "0x2000129")]
	public enum ReloadType
	{
		[Token(Token = "0x4000963")]
		InfiniteAmmo,
		[Token(Token = "0x4000964")]
		ManualClip,
		[Token(Token = "0x4000965")]
		InternalAmmo
	}
	[Token(Token = "0x200012A")]
	public class WeaponSlide : MonoBehaviour
	{
		[Token(Token = "0x200012B")]
		[CompilerGenerated]
		private sealed class <UnlockSlideRoutine>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000976")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000977")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000978")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WeaponSlide <>4__this;

			[Token(Token = "0x17000082")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600068C")]
				[Address(RVA = "0x1575EC4", Offset = "0x1575EC4", VA = "0x1575EC4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000083")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600068E")]
				[Address(RVA = "0x1575F0C", Offset = "0x1575F0C", VA = "0x1575F0C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1575DCC", Offset = "0x1575DCC", VA = "0x1575DCC")]
			[DebuggerHidden]
			public <UnlockSlideRoutine>d__27(int <>1__state)
			{
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1575E14", Offset = "0x1575E14", VA = "0x1575E14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1575E18", Offset = "0x1575E18", VA = "0x1575E18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1575ECC", Offset = "0x1575ECC", VA = "0x1575ECC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float MinLocalZ;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float MaxLocalZ;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool slidingBack;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool LockedBack;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioClip SlideReleaseSound;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip LockedBackSound;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool ZeroMassWhenNotHeld;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private RaycastWeapon parentWeapon;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Grabbable parentGrabbable;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 initialLocalPos;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Grabbable thisGrabbable;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private AudioSource audioSource;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody rigid;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float initialMass;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 _lockPosition;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool lockSlidePosition;

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x157534C", Offset = "0x157534C", VA = "0x157534C")]
		private void Start()
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1575508", Offset = "0x1575508", VA = "0x1575508", Slot = "4")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x15755C0", Offset = "0x15755C0", VA = "0x15755C0", Slot = "5")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1575678", Offset = "0x1575678", VA = "0x1575678")]
		private void Update()
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1575930", Offset = "0x1575930", VA = "0x1575930")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1575A0C", Offset = "0x1575A0C", VA = "0x1575A0C", Slot = "6")]
		public virtual void LockBack()
		{
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1575A9C", Offset = "0x1575A9C", VA = "0x1575A9C", Slot = "7")]
		public virtual void UnlockBack()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1575810", Offset = "0x1575810", VA = "0x1575810")]
		private void onSlideBack()
		{
		}

		[Token(Token = "0x6000683")]
		[Address(RVA = "0x15758D8", Offset = "0x15758D8", VA = "0x15758D8")]
		private void onSlideForward()
		{
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1575CD0", Offset = "0x1575CD0", VA = "0x1575CD0", Slot = "8")]
		public virtual void LockSlidePosition()
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1575D34", Offset = "0x1575D34", VA = "0x1575D34", Slot = "9")]
		public virtual void UnlockSlidePosition()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1575D64", Offset = "0x1575D64", VA = "0x1575D64")]
		[IteratorStateMachine(typeof(<UnlockSlideRoutine>d__27))]
		public IEnumerator UnlockSlideRoutine()
		{
			return null;
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1575B9C", Offset = "0x1575B9C", VA = "0x1575B9C")]
		private void playSoundInterval(float fromSeconds, float toSeconds, float volume)
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1575DF4", Offset = "0x1575DF4", VA = "0x1575DF4")]
		public WeaponSlide()
		{
		}
	}
}
