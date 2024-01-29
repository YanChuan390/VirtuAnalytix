using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36378", Offset = "0xB36378")]
	private sealed class <DestroyDelayed>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BulletHole <>4__this;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x17D214C", Offset = "0x17D214C", VA = "0x17D214C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x17D21B4", Offset = "0x17D21B4", VA = "0x17D21B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x17D2020", Offset = "0x17D2020", VA = "0x17D2020")]
		[DebuggerHidden]
		public <DestroyDelayed>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x17D205C", Offset = "0x17D205C", VA = "0x17D205C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x17D2060", Offset = "0x17D2060", VA = "0x17D2060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x17D2154", Offset = "0x17D2154", VA = "0x17D2154", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x17D1F84", Offset = "0x17D1F84", VA = "0x17D1F84")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x17D1FB0", Offset = "0x17D1FB0", VA = "0x17D1FB0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D010", Offset = "0xB3D010")]
	private IEnumerator DestroyDelayed()
	{
		return null;
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x17D204C", Offset = "0x17D204C", VA = "0x17D204C")]
	public BulletHole()
	{
	}
}
namespace RootMotion
{
	[Token(Token = "0x2000003")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AE")]
		public enum UpdateMode
		{
			[Token(Token = "0x40004F8")]
			Update,
			[Token(Token = "0x40004F9")]
			FixedUpdate,
			[Token(Token = "0x40004FA")]
			LateUpdate
		}

		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		public bool smoothFollow;

		[Token(Token = "0x4000007")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float followSpeed;

		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float distance;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float minDistance;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float maxDistance;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float zoomSpeed;

		[Token(Token = "0x400000C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float zoomSensitivity;

		[Token(Token = "0x400000D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rotationSensitivity;

		[Token(Token = "0x400000E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float yMinLimit;

		[Token(Token = "0x400000F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float yMaxLimit;

		[Token(Token = "0x4000010")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 offset;

		[Token(Token = "0x4000011")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public bool rotateAlways;

		[Token(Token = "0x4000012")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x4000013")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		public bool rotateOnRightButton;

		[Token(Token = "0x4000014")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x4000015")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36418", Offset = "0xB36418")]
		private float <x>k__BackingField;

		[Token(Token = "0x4000016")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36428", Offset = "0xB36428")]
		private float <y>k__BackingField;

		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36438", Offset = "0xB36438")]
		private float <distanceTarget>k__BackingField;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 targetDistance;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 position;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion rotation;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 smoothPosition;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Camera cam;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion r;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Vector3 lastUp;

		[Token(Token = "0x17000001")]
		public float x
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x17D8FB4", Offset = "0x17D8FB4", VA = "0x17D8FB4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D074", Offset = "0xB3D074")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x17D8FBC", Offset = "0x17D8FBC", VA = "0x17D8FBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D084", Offset = "0xB3D084")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float y
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x17D8FC4", Offset = "0x17D8FC4", VA = "0x17D8FC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D094", Offset = "0xB3D094")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x17D8FCC", Offset = "0x17D8FCC", VA = "0x17D8FCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D0A4", Offset = "0xB3D0A4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float distanceTarget
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x17D8FD4", Offset = "0x17D8FD4", VA = "0x17D8FD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D0B4", Offset = "0xB3D0B4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x17D8FDC", Offset = "0x17D8FDC", VA = "0x17D8FDC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D0C4", Offset = "0xB3D0C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000004")]
		private float zoomAdd
		{
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x17D9440", Offset = "0x17D9440", VA = "0x17D9440")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x17D8FE4", Offset = "0x17D8FE4", VA = "0x17D8FE4", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x17D9100", Offset = "0x17D9100", VA = "0x17D9100", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x17D915C", Offset = "0x17D915C", VA = "0x17D915C", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x17D9194", Offset = "0x17D9194", VA = "0x17D9194", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x17D91D8", Offset = "0x17D91D8", VA = "0x17D91D8")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x17D9134", Offset = "0x17D9134", VA = "0x17D9134")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x17D94B4", Offset = "0x17D94B4", VA = "0x17D94B4")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x17D9390", Offset = "0x17D9390", VA = "0x17D9390")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x17D9914", Offset = "0x17D9914", VA = "0x17D9914")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000004")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x17D9A08", Offset = "0x17D9A08", VA = "0x17D9A08")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17D9A40", Offset = "0x17D9A40", VA = "0x17D9A40")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17D9BF8", Offset = "0x17D9BF8", VA = "0x17D9BF8")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17D9CA8", Offset = "0x17D9CA8", VA = "0x17D9CA8")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000005")]
	public enum Axis
	{
		[Token(Token = "0x4000025")]
		X,
		[Token(Token = "0x4000026")]
		Y,
		[Token(Token = "0x4000027")]
		Z
	}
	[Token(Token = "0x2000006")]
	public class AxisTools
	{
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x17D21BC", Offset = "0x17D21BC", VA = "0x17D21BC")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x17D2274", Offset = "0x17D2274", VA = "0x17D2274")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x17D2320", Offset = "0x17D2320", VA = "0x17D2320")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x17D2504", Offset = "0x17D2504", VA = "0x17D2504")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x17D243C", Offset = "0x17D243C", VA = "0x17D243C")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x17D2620", Offset = "0x17D2620", VA = "0x17D2620")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x17D284C", Offset = "0x17D284C", VA = "0x17D284C")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000007")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x20000AF")]
		public class LimbOrientation
		{
			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x17D2B14", Offset = "0x17D2B14", VA = "0x17D2B14")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x17000005")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x17D28A0", Offset = "0x17D28A0", VA = "0x17D28A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x17D2B8C", Offset = "0x17D2B8C", VA = "0x17D2B8C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x17D2854", Offset = "0x17D2854", VA = "0x17D2854")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x2000008")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x20000B0")]
		public enum BoneType
		{
			[Token(Token = "0x40004FF")]
			Unassigned,
			[Token(Token = "0x4000500")]
			Spine,
			[Token(Token = "0x4000501")]
			Head,
			[Token(Token = "0x4000502")]
			Arm,
			[Token(Token = "0x4000503")]
			Leg,
			[Token(Token = "0x4000504")]
			Tail,
			[Token(Token = "0x4000505")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x20000B1")]
		public enum BoneSide
		{
			[Token(Token = "0x4000507")]
			Center,
			[Token(Token = "0x4000508")]
			Left,
			[Token(Token = "0x4000509")]
			Right
		}

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x17D2E00", Offset = "0x17D2E00", VA = "0x17D2E00")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x17D3100", Offset = "0x17D3100", VA = "0x17D3100")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x17D3350", Offset = "0x17D3350", VA = "0x17D3350")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x17D33D4", Offset = "0x17D33D4", VA = "0x17D33D4")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x17D3480", Offset = "0x17D3480", VA = "0x17D3480")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x17D2FB0", Offset = "0x17D2FB0", VA = "0x17D2FB0")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x17D32B0", Offset = "0x17D32B0", VA = "0x17D32B0")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x17D3CC0", Offset = "0x17D3CC0", VA = "0x17D3CC0")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x17D3AD8", Offset = "0x17D3AD8", VA = "0x17D3AD8")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x17D3BCC", Offset = "0x17D3BCC", VA = "0x17D3BCC")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x17D36A0", Offset = "0x17D36A0", VA = "0x17D36A0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x17D3754", Offset = "0x17D3754", VA = "0x17D3754")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x17D3808", Offset = "0x17D3808", VA = "0x17D3808")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x17D38BC", Offset = "0x17D38BC", VA = "0x17D38BC")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x17D3970", Offset = "0x17D3970", VA = "0x17D3970")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x17D3A24", Offset = "0x17D3A24", VA = "0x17D3A24")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x17D3ED4", Offset = "0x17D3ED4", VA = "0x17D3ED4")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x17D35B4", Offset = "0x17D35B4", VA = "0x17D35B4")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x17D3E44", Offset = "0x17D3E44", VA = "0x17D3E44")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x17D3F44", Offset = "0x17D3F44", VA = "0x17D3F44")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x17D401C", Offset = "0x17D401C", VA = "0x17D401C")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x17D3DC8", Offset = "0x17D3DC8", VA = "0x17D3DC8")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x17D3D50", Offset = "0x17D3D50", VA = "0x17D3D50")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000009")]
	public class BipedReferences
	{
		[Token(Token = "0x20000B2")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x17000071")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x6000575")]
				[Address(RVA = "0x17D8FAC", Offset = "0x17D8FAC", VA = "0x17D8FAC")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0xCB1ACC", Offset = "0xCB1ACC", VA = "0xCB1ACC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x17000007")]
		public virtual bool isFilled
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0x17D5B90", Offset = "0x17D5B90", VA = "0x17D5B90", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000008")]
		public bool isEmpty
		{
			[Token(Token = "0x600003B")]
			[Address(RVA = "0x17D5F7C", Offset = "0x17D5F7C", VA = "0x17D5F7C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x17D5F8C", Offset = "0x17D5F8C", VA = "0x17D5F8C", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x17D63B8", Offset = "0x17D63B8", VA = "0x17D63B8", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x17D67F0", Offset = "0x17D67F0", VA = "0x17D67F0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x17D6E00", Offset = "0x17D6E00", VA = "0x17D6E00")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x17D6A3C", Offset = "0x17D6A3C", VA = "0x17D6A3C")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x17D75B0", Offset = "0x17D75B0", VA = "0x17D75B0")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x17D76A4", Offset = "0x17D76A4", VA = "0x17D76A4")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x17D7BFC", Offset = "0x17D7BFC", VA = "0x17D7BFC")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x17D7A00", Offset = "0x17D7A00", VA = "0x17D7A00")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x17D7878", Offset = "0x17D7878", VA = "0x17D7878")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x17D7744", Offset = "0x17D7744", VA = "0x17D7744")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x17D7B04", Offset = "0x17D7B04", VA = "0x17D7B04")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x17D7CF8", Offset = "0x17D7CF8", VA = "0x17D7CF8")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x17D8798", Offset = "0x17D8798", VA = "0x17D8798")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x17D827C", Offset = "0x17D827C", VA = "0x17D827C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x17D8A8C", Offset = "0x17D8A8C", VA = "0x17D8A8C")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x17D85BC", Offset = "0x17D85BC", VA = "0x17D85BC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x17D8A94", Offset = "0x17D8A94", VA = "0x17D8A94")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x17D8A9C", Offset = "0x17D8A9C", VA = "0x17D8A9C")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x17D8C5C", Offset = "0x17D8C5C", VA = "0x17D8C5C")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x17D8E74", Offset = "0x17D8E74", VA = "0x17D8E74")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x17D69CC", Offset = "0x17D69CC", VA = "0x17D69CC")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x17D9CC4", Offset = "0x17D9CC4", VA = "0x17D9CC4")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x17D9CCC", Offset = "0x17D9CCC", VA = "0x17D9CCC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x17D9E0C", Offset = "0x17D9E0C", VA = "0x17D9E0C")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class Hierarchy
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x1D7A80C", Offset = "0x1D7A80C", VA = "0x1D7A80C")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x1D7AA0C", Offset = "0x1D7AA0C", VA = "0x1D7AA0C")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x1D7A8A4", Offset = "0x1D7A8A4", VA = "0x1D7A8A4")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x1D7AB30", Offset = "0x1D7AB30", VA = "0x1D7AB30")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x1D7AC54", Offset = "0x1D7AC54", VA = "0x1D7AC54")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0x1D7AEFC", Offset = "0x1D7AEFC", VA = "0x1D7AEFC")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x1D7B018", Offset = "0x1D7B018", VA = "0x1D7B018")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x1D7B1A0", Offset = "0x1D7B1A0", VA = "0x1D7B1A0")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x1D7B534", Offset = "0x1D7B534", VA = "0x1D7B534")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x1D7B320", Offset = "0x1D7B320", VA = "0x1D7B320")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x1D7B6D4", Offset = "0x1D7B6D4", VA = "0x1D7B6D4")]
		public Hierarchy()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200000D")]
	public enum InterpolationMode
	{
		[Token(Token = "0x4000053")]
		None,
		[Token(Token = "0x4000054")]
		InOutCubic,
		[Token(Token = "0x4000055")]
		InOutQuintic,
		[Token(Token = "0x4000056")]
		InOutSine,
		[Token(Token = "0x4000057")]
		InQuintic,
		[Token(Token = "0x4000058")]
		InQuartic,
		[Token(Token = "0x4000059")]
		InCubic,
		[Token(Token = "0x400005A")]
		InQuadratic,
		[Token(Token = "0x400005B")]
		InElastic,
		[Token(Token = "0x400005C")]
		InElasticSmall,
		[Token(Token = "0x400005D")]
		InElasticBig,
		[Token(Token = "0x400005E")]
		InSine,
		[Token(Token = "0x400005F")]
		InBack,
		[Token(Token = "0x4000060")]
		OutQuintic,
		[Token(Token = "0x4000061")]
		OutQuartic,
		[Token(Token = "0x4000062")]
		OutCubic,
		[Token(Token = "0x4000063")]
		OutInCubic,
		[Token(Token = "0x4000064")]
		OutInQuartic,
		[Token(Token = "0x4000065")]
		OutElastic,
		[Token(Token = "0x4000066")]
		OutElasticSmall,
		[Token(Token = "0x4000067")]
		OutElasticBig,
		[Token(Token = "0x4000068")]
		OutSine,
		[Token(Token = "0x4000069")]
		OutBack,
		[Token(Token = "0x400006A")]
		OutBackCubic,
		[Token(Token = "0x400006B")]
		OutBackQuartic,
		[Token(Token = "0x400006C")]
		BackInCubic,
		[Token(Token = "0x400006D")]
		BackInQuartic
	}
	[Token(Token = "0x200000E")]
	public class Interp
	{
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x1D7B6DC", Offset = "0x1D7B6DC", VA = "0x1D7B6DC")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x1D7C144", Offset = "0x1D7C144", VA = "0x1D7C144")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x1D7C24C", Offset = "0x1D7C24C", VA = "0x1D7C24C")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x1D7BA48", Offset = "0x1D7BA48", VA = "0x1D7BA48")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x1D7BA54", Offset = "0x1D7BA54", VA = "0x1D7BA54")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x1D7BA78", Offset = "0x1D7BA78", VA = "0x1D7BA78")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x1D7BAB4", Offset = "0x1D7BAB4", VA = "0x1D7BAB4")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x1D7BACC", Offset = "0x1D7BACC", VA = "0x1D7BACC")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x1D7BAE0", Offset = "0x1D7BAE0", VA = "0x1D7BAE0")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x1D7BAF4", Offset = "0x1D7BAF4", VA = "0x1D7BAF4")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x1D7BB04", Offset = "0x1D7BB04", VA = "0x1D7BB04")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x1D7BB4C", Offset = "0x1D7BB4C", VA = "0x1D7BB4C")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x1D7BB84", Offset = "0x1D7BB84", VA = "0x1D7BB84")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x1D7BBAC", Offset = "0x1D7BBAC", VA = "0x1D7BBAC")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x1D7C348", Offset = "0x1D7C348", VA = "0x1D7C348")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x1D7BBE0", Offset = "0x1D7BBE0", VA = "0x1D7BBE0")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x1D7BC08", Offset = "0x1D7BC08", VA = "0x1D7BC08")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x1D7BC38", Offset = "0x1D7BC38", VA = "0x1D7BC38")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x1D7BC6C", Offset = "0x1D7BC6C", VA = "0x1D7BC6C")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x1D7BCB0", Offset = "0x1D7BCB0", VA = "0x1D7BCB0")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x1D7BD14", Offset = "0x1D7BD14", VA = "0x1D7BD14")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x1D7BD78", Offset = "0x1D7BD78", VA = "0x1D7BD78")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x1D7BDCC", Offset = "0x1D7BDCC", VA = "0x1D7BDCC")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x1D7BE20", Offset = "0x1D7BE20", VA = "0x1D7BE20")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x1D7BEB8", Offset = "0x1D7BEB8", VA = "0x1D7BEB8")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x1D7BF4C", Offset = "0x1D7BF4C", VA = "0x1D7BF4C")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x1D7C37C", Offset = "0x1D7C37C", VA = "0x1D7C37C")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x1D7BFF0", Offset = "0x1D7BFF0", VA = "0x1D7BFF0")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x1D7C0D4", Offset = "0x1D7C0D4", VA = "0x1D7C0D4")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x1D7C104", Offset = "0x1D7C104", VA = "0x1D7C104")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x1D7C464", Offset = "0x1D7C464", VA = "0x1D7C464")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x400006E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400006F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x1D7C46C", Offset = "0x1D7C46C", VA = "0x1D7C46C")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x1D7C4DC", Offset = "0x1D7C4DC", VA = "0x1D7C4DC")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000010")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x1D7C54C", Offset = "0x1D7C54C", VA = "0x1D7C54C")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x1D7C5A4", Offset = "0x1D7C5A4", VA = "0x1D7C5A4")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x1D7C670", Offset = "0x1D7C670", VA = "0x1D7C670")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x1D7C5BC", Offset = "0x1D7C5BC", VA = "0x1D7C5BC")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x1D7C688", Offset = "0x1D7C688", VA = "0x1D7C688")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x1D7C72C", Offset = "0x1D7C72C", VA = "0x1D7C72C")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x1D7C758", Offset = "0x1D7C758", VA = "0x1D7C758")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x1D7C7A8", Offset = "0x1D7C7A8", VA = "0x1D7C7A8")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x1D7C814", Offset = "0x1D7C814", VA = "0x1D7C814")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x1D7C908", Offset = "0x1D7C908", VA = "0x1D7C908")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x1D7C9E0", Offset = "0x1D7C9E0", VA = "0x1D7C9E0")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x1D7CA40", Offset = "0x1D7CA40", VA = "0x1D7CA40")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x2000011")]
	public static class QuaTools
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x1D7CA70", Offset = "0x1D7CA70", VA = "0x1D7CA70")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x1D7CBBC", Offset = "0x1D7CBBC", VA = "0x1D7CBBC")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x1D7CD08", Offset = "0x1D7CD08", VA = "0x1D7CD08")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x1D7CE1C", Offset = "0x1D7CE1C", VA = "0x1D7CE1C")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x1D6F478", Offset = "0x1D6F478", VA = "0x1D6F478")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x1D7CF30", Offset = "0x1D7CF30", VA = "0x1D7CF30")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1D73898", Offset = "0x1D73898", VA = "0x1D73898")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x1D7D000", Offset = "0x1D7D000", VA = "0x1D7D000")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x1D7D284", Offset = "0x1D7D284", VA = "0x1D7D284")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x1D7D498", Offset = "0x1D7D498", VA = "0x1D7D498")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}
	}
	[Token(Token = "0x2000012")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000009")]
		public static T instance
		{
			[Token(Token = "0x6000097")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000098")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000099")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36458", Offset = "0xB36458")]
		public bool fixTransforms;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x4000075")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000076")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x1700000A")]
		private bool animatePhysics
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x1D7D750", Offset = "0x1D7D750", VA = "0x1D7D750")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		private bool isAnimated
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x1D7DA4C", Offset = "0x1D7DA4C", VA = "0x1D7DA4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x1D7D618", Offset = "0x1D7D618", VA = "0x1D7D618")]
		public void Disable()
		{
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x1D7D6B0", Offset = "0x1D7D6B0", VA = "0x1D7D6B0", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x1D7D6B4", Offset = "0x1D7D6B4", VA = "0x1D7D6B4", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x1D7D6B8", Offset = "0x1D7D6B8", VA = "0x1D7D6B8", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1D7D6BC", Offset = "0x1D7D6BC", VA = "0x1D7D6BC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1D7D74C", Offset = "0x1D7D74C", VA = "0x1D7D74C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1D7D6F4", Offset = "0x1D7D6F4", VA = "0x1D7D6F4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x1D7DA00", Offset = "0x1D7DA00", VA = "0x1D7DA00")]
		private void Update()
		{
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x1D7D840", Offset = "0x1D7D840", VA = "0x1D7D840")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x1D7DB08", Offset = "0x1D7DB08", VA = "0x1D7DB08")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x1D7DB64", Offset = "0x1D7DB64", VA = "0x1D7DB64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x1D7DBC0", Offset = "0x1D7DBC0", VA = "0x1D7DBC0")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x1D71F20", Offset = "0x1D71F20", VA = "0x1D71F20")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x2000014")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x1D7DC08", Offset = "0x1D7DC08", VA = "0x1D7DC08")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x1D7DCC0", Offset = "0x1D7DCC0", VA = "0x1D7DCC0")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1D7DD78", Offset = "0x1D7DD78", VA = "0x1D7DD78")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x1D7DE30", Offset = "0x1D7DE30", VA = "0x1D7DE30")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x2000015")]
	public static class V3Tools
	{
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x1D7DE38", Offset = "0x1D7DE38", VA = "0x1D7DE38")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x1D7DF30", Offset = "0x1D7DF30", VA = "0x1D7DF30")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x1D7E028", Offset = "0x1D7E028", VA = "0x1D7E028")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x1D7E120", Offset = "0x1D7E120", VA = "0x1D7E120")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x1D7E220", Offset = "0x1D7E220", VA = "0x1D7E220")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1D7E45C", Offset = "0x1D7E45C", VA = "0x1D7E45C")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x1D7E6AC", Offset = "0x1D7E6AC", VA = "0x1D7E6AC")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x1D7E8AC", Offset = "0x1D7E8AC", VA = "0x1D7E8AC")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000016")]
	public static class Warning
	{
		[Token(Token = "0x20000B3")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000078")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x1D7EA88", Offset = "0x1D7EA88", VA = "0x1D7EA88")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x1D6CAB0", Offset = "0x1D6CAB0", VA = "0x1D6CAB0")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x2000017")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000079")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400007A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x17D9E40", Offset = "0x17D9E40", VA = "0x17D9E40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x17D9EC4", Offset = "0x17D9EC4", VA = "0x17D9EC4")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x2000018")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x400007B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36490", Offset = "0xB36490")]
		public AimPoser aimPoser;

		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB364C8", Offset = "0xB364C8")]
		public AimIK aim;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36500", Offset = "0xB36500")]
		public LookAtIK lookAt;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36538", Offset = "0xB36538")]
		public Animator animator;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36570", Offset = "0xB36570")]
		public float crossfadeTime;

		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB365A8", Offset = "0xB365A8")]
		public float minAimDistance;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x17EB668", Offset = "0x17EB668", VA = "0x17EB668")]
		private void Start()
		{
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x17EB6AC", Offset = "0x17EB6AC", VA = "0x17EB6AC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x17EB800", Offset = "0x17EB800", VA = "0x17EB800")]
		private void Pose()
		{
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x17EBA04", Offset = "0x17EBA04", VA = "0x17EBA04")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x17EBBFC", Offset = "0x17EBBFC", VA = "0x17EBBFC")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x17EBCD4", Offset = "0x17EBCD4", VA = "0x17EBCD4")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x4000083")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x4000084")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x4000085")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x4000086")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x4000087")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x4000088")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x4000089")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x400008A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x16ABB64", Offset = "0x16ABB64", VA = "0x16ABB64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x16ABDC8", Offset = "0x16ABDC8", VA = "0x16ABDC8")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x16AC018", Offset = "0x16AC018", VA = "0x16AC018")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x200001A")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x400008B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400008C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x400008D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x400008E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x400008F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lookAtWeight;

		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float lookAtBodyWeight;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float lookAtHeadWeight;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float lookAtEyesWeight;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float lookAtClampWeight;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float lookAtClampWeightHead;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform footTargetBiped;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float footPositionWeight;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationWeight;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform handTargetBiped;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float handPositionWeight;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public float handRotationWeight;

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x17DB9C4", Offset = "0x17DB9C4", VA = "0x17DB9C4")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x17DBE70", Offset = "0x17DBE70", VA = "0x17DBE70")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x200001B")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private Vector3 lastPosition;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float sine;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private RaycastHit rootHit;

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x17E5B74", Offset = "0x17E5B74", VA = "0x17E5B74")]
		private void Update()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x17E65A8", Offset = "0x17E65A8", VA = "0x17E65A8")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x17E6290", Offset = "0x17E6290", VA = "0x17E6290")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x17E6750", Offset = "0x17E6750", VA = "0x17E6750")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x200001C")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700000C")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0x17E677C", Offset = "0x17E677C", VA = "0x17E677C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x17E681C", Offset = "0x17E681C", VA = "0x17E681C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x17E6AB4", Offset = "0x17E6AB4", VA = "0x17E6AB4")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x200001D")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000B4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36388", Offset = "0xB36388")]
		private sealed class <Step>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x17000072")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600057D")]
				[Address(RVA = "0x17E76F0", Offset = "0x17E76F0", VA = "0x17E76F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000073")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600057F")]
				[Address(RVA = "0x17E7758", Offset = "0x17E7758", VA = "0x17E7758", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600057A")]
			[Address(RVA = "0x17E7380", Offset = "0x17E7380", VA = "0x17E7380")]
			[DebuggerHidden]
			public <Step>d__24(int <>1__state)
			{
			}

			[Token(Token = "0x600057B")]
			[Address(RVA = "0x17E73DC", Offset = "0x17E73DC", VA = "0x17E73DC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x17E73E0", Offset = "0x17E73E0", VA = "0x17E73E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x17E76F8", Offset = "0x17E76F8", VA = "0x17E76F8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem sand;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IK ik;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float stepProgress;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float lastStepTime;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit hit;

		[Token(Token = "0x1700000D")]
		public bool isStepping
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0x17E6AC8", Offset = "0x17E6AC8", VA = "0x17E6AC8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		public Vector3 position
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x17E671C", Offset = "0x17E671C", VA = "0x17E671C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x17E6ADC", Offset = "0x17E6ADC", VA = "0x17E6ADC")]
			set
			{
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x17E6B2C", Offset = "0x17E6B2C", VA = "0x17E6B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x17E6CE8", Offset = "0x17E6CE8", VA = "0x17E6CE8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x17E70B8", Offset = "0x17E70B8", VA = "0x17E70B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x17E72D4", Offset = "0x17E72D4", VA = "0x17E72D4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D144", Offset = "0xB3D144")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x17E73AC", Offset = "0x17E73AC", VA = "0x17E73AC")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x17E7760", Offset = "0x17E7760", VA = "0x17E7760")]
		private void Start()
		{
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x17E780C", Offset = "0x17E780C", VA = "0x17E780C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x17E7AA0", Offset = "0x17E7AA0", VA = "0x17E7AA0")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000B5")]
		public struct Warp
		{
			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A648", Offset = "0xB3A648")]
			public int animationLayer;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A680", Offset = "0xB3A680")]
			public string animationState;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A6B8", Offset = "0xB3A6B8")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A6F0", Offset = "0xB3A6F0")]
			public Transform warpFrom;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A728", Offset = "0xB3A728")]
			public Transform warpTo;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A760", Offset = "0xB3A760")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000B6")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000518")]
			PositionOffset,
			[Token(Token = "0x4000519")]
			Position
		}

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB365E0", Offset = "0xB365E0")]
		public Animator animator;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36618", Offset = "0xB36618")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB36650", Offset = "0xB36650")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36650", Offset = "0xB36650")]
		public Warp[] warps;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x17D9ECC", Offset = "0x17D9ECC", VA = "0x17D9ECC", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x17D9EF8", Offset = "0x17D9EF8", VA = "0x17D9EF8")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x17DA100", Offset = "0x17DA100", VA = "0x17DA100", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x17DA4B4", Offset = "0x17DA4B4", VA = "0x17DA4B4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x17DA554", Offset = "0x17DA554", VA = "0x17DA554")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35298", Offset = "0xB35298")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x17DA55C", Offset = "0x17DA55C", VA = "0x17DA55C", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x17DA5B4", Offset = "0x17DA5B4", VA = "0x17DA5B4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x17DA7EC", Offset = "0x17DA7EC", VA = "0x17DA7EC", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x17DAA50", Offset = "0x17DAA50", VA = "0x17DAA50")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000021")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB352FC", Offset = "0xB352FC")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB352FC", Offset = "0xB352FC")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB366A0", Offset = "0xB366A0")]
		public float headLookWeight;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x40000D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x40000DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x40000DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x40000DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x17DAA64", Offset = "0x17DAA64", VA = "0x17DAA64", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x17DABD0", Offset = "0x17DABD0", VA = "0x17DABD0", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x17DAC44", Offset = "0x17DAC44", VA = "0x17DAC44")]
		private void Read()
		{
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x17DAD9C", Offset = "0x17DAD9C", VA = "0x17DAD9C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x17DADE4", Offset = "0x17DADE4", VA = "0x17DADE4")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x17DB3DC", Offset = "0x17DB3DC", VA = "0x17DB3DC")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x17DB1A0", Offset = "0x17DB1A0", VA = "0x17DB1A0")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x17DB734", Offset = "0x17DB734", VA = "0x17DB734")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x17DB82C", Offset = "0x17DB82C", VA = "0x17DB82C")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35388", Offset = "0xB35388")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x40000DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x17DCD0C", Offset = "0x17DCD0C", VA = "0x17DCD0C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x17DCD6C", Offset = "0x17DCD6C", VA = "0x17DCD6C", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x17DD028", Offset = "0x17DD028", VA = "0x17DD028")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x17DD1E0", Offset = "0x17DD1E0", VA = "0x17DD1E0")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000023")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB353EC", Offset = "0xB353EC")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x40000DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CameraController cam;

		[Token(Token = "0x40000DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x1700000F")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x17DE014", Offset = "0x17DE014", VA = "0x17DE014")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000010")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x17DE0B4", Offset = "0x17DE0B4", VA = "0x17DE0B4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x17DDD60", Offset = "0x17DDD60", VA = "0x17DDD60")]
		private void Start()
		{
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x17DDDD0", Offset = "0x17DDDD0", VA = "0x17DDDD0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x17DE154", Offset = "0x17DE154", VA = "0x17DE154")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000024")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x40000E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB366C8", Offset = "0xB366C8")]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x40000E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x40000E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x40000E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x17E0610", Offset = "0x17E0610", VA = "0x17E0610", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x17E0BF4", Offset = "0x17E0BF4", VA = "0x17E0BF4")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x17E0BFC", Offset = "0x17E0BFC", VA = "0x17E0BFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x17E0C9C", Offset = "0x17E0C9C", VA = "0x17E0C9C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x17E1118", Offset = "0x17E1118", VA = "0x17E1118")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x17E11C4", Offset = "0x17E11C4", VA = "0x17E11C4")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B7")]
		public class Limb
		{
			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x6000580")]
			[Address(RVA = "0x17E1398", Offset = "0x17E1398", VA = "0x17E1398")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000581")]
			[Address(RVA = "0x17E14CC", Offset = "0x17E14CC", VA = "0x17E14CC")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x17E124C", Offset = "0x17E124C", VA = "0x17E124C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x17E141C", Offset = "0x17E141C", VA = "0x17E141C")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x17E14B8", Offset = "0x17E14B8", VA = "0x17E14B8")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x17E14BC", Offset = "0x17E14BC", VA = "0x17E14BC")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000027")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x17E14DC", Offset = "0x17E14DC", VA = "0x17E14DC")]
		private void Start()
		{
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x17E1548", Offset = "0x17E1548", VA = "0x17E1548")]
		private void Update()
		{
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x17E1620", Offset = "0x17E1620", VA = "0x17E1620")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB366E0", Offset = "0xB366E0")]
		public Transform target;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36718", Offset = "0xB36718")]
		public Transform pin;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36750", Offset = "0xB36750")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36788", Offset = "0xB36788")]
		public AimIK aim;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB367C0", Offset = "0xB367C0")]
		public float weight;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB367F8", Offset = "0xB367F8")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36830", Offset = "0xB36830")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x17E1628", Offset = "0x17E1628", VA = "0x17E1628")]
		private void Start()
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0x17E1680", Offset = "0x17E1680", VA = "0x17E1680")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0x17E181C", Offset = "0x17E181C", VA = "0x17E181C")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000029")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000102")]
		[Address(RVA = "0x17E1824", Offset = "0x17E1824", VA = "0x17E1824")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0x17E18E4", Offset = "0x17E18E4", VA = "0x17E18E4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0x17E1970", Offset = "0x17E1970", VA = "0x17E1970")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000105")]
		[Address(RVA = "0x17E1E04", Offset = "0x17E1E04", VA = "0x17E1E04")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000106")]
		[Address(RVA = "0x17E1EFC", Offset = "0x17E1EFC", VA = "0x17E1EFC")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200002A")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36868", Offset = "0xB36868")]
		public float aimWeight;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36880", Offset = "0xB36880")]
		public float sightWeight;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36898", Offset = "0xB36898")]
		public float maxAngle;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool animatePhysics;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform gun;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform gunTarget;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AimIK gunAim;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CameraControllerFPS cam;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Recoil recoil;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36924", Offset = "0xB36924")]
		private float cameraRecoilWeight;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion gunTargetDefaultLocalRotation;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool updateFrame;

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x17E1F04", Offset = "0x17E1F04", VA = "0x17E1F04")]
		private void Start()
		{
		}

		[Token(Token = "0x6000108")]
		[Address(RVA = "0x17E2064", Offset = "0x17E2064", VA = "0x17E2064")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000109")]
		[Address(RVA = "0x17E2070", Offset = "0x17E2070", VA = "0x17E2070")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600010A")]
		[Address(RVA = "0x17E23B0", Offset = "0x17E23B0", VA = "0x17E23B0")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600010B")]
		[Address(RVA = "0x17E2584", Offset = "0x17E2584", VA = "0x17E2584")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x600010C")]
		[Address(RVA = "0x17E2134", Offset = "0x17E2134", VA = "0x17E2134")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0x17E2F90", Offset = "0x17E2F90", VA = "0x17E2F90")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35450", Offset = "0xB35450")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35450", Offset = "0xB35450")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36964", Offset = "0xB36964")]
		public float walkSpeed;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x600010E")]
		[Address(RVA = "0x17E2FB0", Offset = "0x17E2FB0", VA = "0x17E2FB0")]
		private void Start()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x17E3020", Offset = "0x17E3020", VA = "0x17E3020")]
		private void Update()
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x17E3144", Offset = "0x17E3144", VA = "0x17E3144")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x17E31F4", Offset = "0x17E31F4", VA = "0x17E31F4")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200002C")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HitReaction hitReaction;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float hitForce;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x17E3C30", Offset = "0x17E3C30", VA = "0x17E3C30")]
		private void Update()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x17E3DF0", Offset = "0x17E3DF0", VA = "0x17E3DF0")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x17E3FB4", Offset = "0x17E3FB4", VA = "0x17E3FB4")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200002D")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x17E3FC4", Offset = "0x17E3FC4", VA = "0x17E3FC4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x17E4170", Offset = "0x17E4170", VA = "0x17E4170")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x17E452C", Offset = "0x17E452C", VA = "0x17E452C")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200002E")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x17E453C", Offset = "0x17E453C", VA = "0x17E453C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x17E4670", Offset = "0x17E4670", VA = "0x17E4670")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x17E47C0", Offset = "0x17E47C0", VA = "0x17E47C0")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200002F")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x17E47C8", Offset = "0x17E47C8", VA = "0x17E47C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x17E4E98", Offset = "0x17E4E98", VA = "0x17E4E98")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000030")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB354DC", Offset = "0xB354DC")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3699C", Offset = "0xB3699C")]
		[SerializeField]
		private InteractionObject interactionObject;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB369E8", Offset = "0xB369E8")]
		[SerializeField]
		private FullBodyBipedEffector[] effectors;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x17E4EA0", Offset = "0x17E4EA0", VA = "0x17E4EA0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x17E4EF8", Offset = "0x17E4EF8", VA = "0x17E4EF8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x17E5204", Offset = "0x17E5204", VA = "0x17E5204")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000031")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B8")]
		public class Partner
		{
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000074")]
			private Transform neck
			{
				[Token(Token = "0x6000584")]
				[Address(RVA = "0x17E5B08", Offset = "0x17E5B08", VA = "0x17E5B08")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000582")]
			[Address(RVA = "0x17E5240", Offset = "0x17E5240", VA = "0x17E5240")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000583")]
			[Address(RVA = "0x17E52C0", Offset = "0x17E52C0", VA = "0x17E52C0")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x6000585")]
			[Address(RVA = "0x17E592C", Offset = "0x17E592C", VA = "0x17E592C")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x6000586")]
			[Address(RVA = "0x17E5B60", Offset = "0x17E5B60", VA = "0x17E5B60")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x17E520C", Offset = "0x17E520C", VA = "0x17E520C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x17E5260", Offset = "0x17E5260", VA = "0x17E5260")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x17E591C", Offset = "0x17E591C", VA = "0x17E591C")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class MotionAbsorb : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000B9")]
		public class Absorber
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A798", Offset = "0xB3A798")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A7D0", Offset = "0xB3A7D0")]
			public float weight;

			[Token(Token = "0x6000587")]
			[Address(RVA = "0x17E8178", Offset = "0x17E8178", VA = "0x17E8178")]
			public void SetToBone(IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x6000588")]
			[Address(RVA = "0x17E8230", Offset = "0x17E8230", VA = "0x17E8230")]
			public void SetEffectorWeights(IKSolverFullBodyBiped solver, float w)
			{
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x17E8314", Offset = "0x17E8314", VA = "0x17E8314")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x20000BA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36398", Offset = "0xB36398")]
		private sealed class <AbsorbMotion>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MotionAbsorb <>4__this;

			[Token(Token = "0x17000075")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600058D")]
				[Address(RVA = "0x17E82A4", Offset = "0x17E82A4", VA = "0x17E82A4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000076")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600058F")]
				[Address(RVA = "0x17E830C", Offset = "0x17E830C", VA = "0x17E830C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x17E7FC4", Offset = "0x17E7FC4", VA = "0x17E7FC4")]
			[DebuggerHidden]
			public <AbsorbMotion>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x17E8004", Offset = "0x17E8004", VA = "0x17E8004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x17E8008", Offset = "0x17E8008", VA = "0x17E8008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x17E82AC", Offset = "0x17E82AC", VA = "0x17E82AC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36A34", Offset = "0xB36A34")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36A6C", Offset = "0xB36A6C")]
		public Absorber[] absorbers;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36AA4", Offset = "0xB36AA4")]
		public float weight;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36ADC", Offset = "0xB36ADC")]
		public AnimationCurve falloff;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36B14", Offset = "0xB36B14")]
		public float falloffSpeed;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float timer;

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x17E7F18", Offset = "0x17E7F18", VA = "0x17E7F18")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x17E7F54", Offset = "0x17E7F54", VA = "0x17E7F54")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D1A8", Offset = "0xB3D1A8")]
		private IEnumerator AbsorbMotion()
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x17E7FF0", Offset = "0x17E7FF0", VA = "0x17E7FF0")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x17E8324", Offset = "0x17E8324", VA = "0x17E8324")]
		private void Start()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x17E839C", Offset = "0x17E839C", VA = "0x17E839C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x17E8450", Offset = "0x17E8450", VA = "0x17E8450")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x17E85B0", Offset = "0x17E85B0", VA = "0x17E85B0")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000BB")]
		public class EffectorLink
		{
			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x17E88F8", Offset = "0x17E88F8", VA = "0x17E88F8")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x17E85C4", Offset = "0x17E85C4", VA = "0x17E85C4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x17E86C4", Offset = "0x17E86C4", VA = "0x17E86C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x17E88F0", Offset = "0x17E88F0", VA = "0x17E88F0")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000035")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35540", Offset = "0xB35540")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36B4C", Offset = "0xB36B4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36B4C", Offset = "0xB36B4C")]
		public float weight;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36BA0", Offset = "0xB36BA0")]
		public float hangingDistanceMlp;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36BD8", Offset = "0xB36BD8")]
		[HideInInspector]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36C24", Offset = "0xB36C24")]
		[HideInInspector]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform target;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform leftHandTarget;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform rightHandTarget;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform leftFootTarget;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Transform rightFootTarget;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform pelvisTarget;

		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform bodyTarget;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Transform headTarget;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3 pelvisDownAxis;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x17E8908", Offset = "0x17E8908", VA = "0x17E8908")]
		private void Start()
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x17E8C44", Offset = "0x17E8C44", VA = "0x17E8C44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x17E9394", Offset = "0x17E9394", VA = "0x17E9394")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int GUIspace;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000011")]
		private bool holding
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x17E9A6C", Offset = "0x17E9A6C", VA = "0x17E9A6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x17E97AC", Offset = "0x17E97AC", VA = "0x17E97AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000131")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x17E9A8C", Offset = "0x17E9A8C", VA = "0x17E9A8C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x17E9BF4", Offset = "0x17E9BF4", VA = "0x17E9BF4")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x17E9D70", Offset = "0x17E9D70", VA = "0x17E9D70")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x17E9E50", Offset = "0x17E9E50", VA = "0x17E9E50")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x17E9F7C", Offset = "0x17E9F7C", VA = "0x17E9F7C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x17EA18C", Offset = "0x17EA18C", VA = "0x17EA18C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x17EA32C", Offset = "0x17EA32C", VA = "0x17EA32C")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x2000037")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x17EA340", Offset = "0x17EA340", VA = "0x17EA340", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x17EA534", Offset = "0x17EA534", VA = "0x17EA534")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x17EA548", Offset = "0x17EA548", VA = "0x17EA548", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x17EA6F4", Offset = "0x17EA6F4", VA = "0x17EA6F4")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x2000039")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x17EAE70", Offset = "0x17EAE70", VA = "0x17EAE70")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x17EAF48", Offset = "0x17EAF48", VA = "0x17EAF48")]
		private void Update()
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x17EB0F0", Offset = "0x17EB0F0", VA = "0x17EB0F0")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB355A4", Offset = "0xB355A4")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x17EB0F8", Offset = "0x17EB0F8", VA = "0x17EB0F8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x17EB150", Offset = "0x17EB150", VA = "0x17EB150")]
		private void Update()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x17EB1AC", Offset = "0x17EB1AC", VA = "0x17EB1AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x17EB284", Offset = "0x17EB284", VA = "0x17EB284")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200003B")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x20000BC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363A8", Offset = "0xB363A8")]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000077")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000594")]
				[Address(RVA = "0x17EB5F8", Offset = "0x17EB5F8", VA = "0x17EB5F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000078")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000596")]
				[Address(RVA = "0x17EB660", Offset = "0x17EB660", VA = "0x17EB660", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x17EB414", Offset = "0x17EB414", VA = "0x17EB414")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x17EB450", Offset = "0x17EB450", VA = "0x17EB450", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x17EB454", Offset = "0x17EB454", VA = "0x17EB454", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x17EB600", Offset = "0x17EB600", VA = "0x17EB600", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x17EB294", Offset = "0x17EB294", VA = "0x17EB294")]
		private void Start()
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x17EB34C", Offset = "0x17EB34C", VA = "0x17EB34C")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x17EB394", Offset = "0x17EB394", VA = "0x17EB394")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D20C", Offset = "0xB3D20C")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x17EB440", Offset = "0x17EB440", VA = "0x17EB440")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x200003C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35608", Offset = "0xB35608")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x20000BD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363B8", Offset = "0xB363B8")]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000079")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600059A")]
				[Address(RVA = "0x16ABAF4", Offset = "0x16ABAF4", VA = "0x16ABAF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600059C")]
				[Address(RVA = "0x16ABB5C", Offset = "0x16ABB5C", VA = "0x16ABB5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x16AB99C", Offset = "0x16AB99C", VA = "0x16AB99C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x16AB9D0", Offset = "0x16AB9D0", VA = "0x16AB9D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x16AB9D4", Offset = "0x16AB9D4", VA = "0x16AB9D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x16ABAFC", Offset = "0x16ABAFC", VA = "0x16ABAFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x16AB87C", Offset = "0x16AB87C", VA = "0x16AB87C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x16AB92C", Offset = "0x16AB92C", VA = "0x16AB92C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D270", Offset = "0xB3D270")]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x16AB9C8", Offset = "0x16AB9C8", VA = "0x16AB9C8")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000BE")]
		public class EffectorLink
		{
			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public LayerMask touchLayers;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float lerpSpeed;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float minSwitchTime;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float releaseDistance;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool sliding;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float raycastDistance;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private bool inTouch;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private RaycastHit hit;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 targetPosition;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Quaternion targetRotation;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private bool initiated;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private float nextSwitchTime;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float speedF;

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x16AC104", Offset = "0x16AC104", VA = "0x16AC104")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x16ACD8C", Offset = "0x16ACD8C", VA = "0x16ACD8C")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x16AC444", Offset = "0x16AC444", VA = "0x16AC444")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x16ACE74", Offset = "0x16ACE74", VA = "0x16ACE74")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x16AD010", Offset = "0x16AD010", VA = "0x16AD010")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x16AD0AC", Offset = "0x16AD0AC", VA = "0x16AD0AC")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x16AD144", Offset = "0x16AD144", VA = "0x16AD144")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x16ACC24", Offset = "0x16ACC24", VA = "0x16ACC24")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x16AD1DC", Offset = "0x16AD1DC", VA = "0x16AD1DC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x16AC08C", Offset = "0x16AC08C", VA = "0x16AC08C")]
		private void Start()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x16AC3D8", Offset = "0x16AC3D8", VA = "0x16AC3D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x16ACB5C", Offset = "0x16ACB5C", VA = "0x16ACB5C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x16ACD84", Offset = "0x16ACD84", VA = "0x16ACD84")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36D10", Offset = "0xB36D10")]
		public Transform to;

		[Token(Token = "0x4000176")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36D48", Offset = "0xB36D48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36D48", Offset = "0xB36D48")]
		public float transferMotion;

		[Token(Token = "0x4000177")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x16AD210", Offset = "0x16AD210", VA = "0x16AD210")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x16AD24C", Offset = "0x16AD24C", VA = "0x16AD24C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x16AD3A4", Offset = "0x16AD3A4", VA = "0x16AD3A4")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x200003F")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x4000178")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36D9C", Offset = "0xB36D9C")]
		public Transform leftHandTarget;

		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x16AD564", Offset = "0x16AD564", VA = "0x16AD564")]
		private void Start()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x16AD71C", Offset = "0x16AD71C", VA = "0x16AD71C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x16AD9B8", Offset = "0x16AD9B8", VA = "0x16AD9B8")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x16ADA84", Offset = "0x16ADA84", VA = "0x16ADA84")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x16ADB7C", Offset = "0x16ADB7C", VA = "0x16ADB7C")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000040")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterThirdPerson character;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool disableInputInInteraction;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x16ADDB4", Offset = "0x16ADDB4", VA = "0x16ADDB4", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x16AE22C", Offset = "0x16AE22C", VA = "0x16AE22C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x16AE484", Offset = "0x16AE484", VA = "0x16AE484")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000041")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x17E38AC", Offset = "0x17E38AC", VA = "0x17E38AC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x17E3BA8", Offset = "0x17E3BA8", VA = "0x17E3BA8")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x17E3C28", Offset = "0x17E3C28", VA = "0x17E3C28")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000042")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x20000BF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363C8", Offset = "0xB363C8")]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700007B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005A9")]
				[Address(RVA = "0x17EAE00", Offset = "0x17EAE00", VA = "0x17EAE00", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005AB")]
				[Address(RVA = "0x17EAE68", Offset = "0x17EAE68", VA = "0x17EAE68", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x17EAABC", Offset = "0x17EAABC", VA = "0x17EAABC")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x17EACC8", Offset = "0x17EACC8", VA = "0x17EACC8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x17EACCC", Offset = "0x17EACCC", VA = "0x17EACCC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x17EAE08", Offset = "0x17EAE08", VA = "0x17EAE08", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x17EA708", Offset = "0x17EA708", VA = "0x17EA708")]
		private void Start()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x17EA894", Offset = "0x17EA894", VA = "0x17EA894")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x17EA824", Offset = "0x17EA824", VA = "0x17EA824")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D2D4", Offset = "0xB3D2D4")]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17EAAE8", Offset = "0x17EAAE8", VA = "0x17EAAE8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x17EABCC", Offset = "0x17EABCC", VA = "0x17EABCC")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x17EACAC", Offset = "0x17EACAC", VA = "0x17EACAC")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x2000043")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36E04", Offset = "0xB36E04")]
		public float weight;

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x17DB88C", Offset = "0x17DB88C", VA = "0x17DB88C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x17DB8F8", Offset = "0x17DB8F8", VA = "0x17DB8F8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x17DB9B4", Offset = "0x17DB9B4", VA = "0x17DB9B4")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x2000044")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C0")]
		public class Part
		{
			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x16AD430", Offset = "0x16AD430", VA = "0x16AD430")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x16AD55C", Offset = "0x16AD55C", VA = "0x16AD55C")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x16AD3B8", Offset = "0x16AD3B8", VA = "0x16AD3B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x16AD554", Offset = "0x16AD554", VA = "0x16AD554")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x2000045")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3566C", Offset = "0xB3566C")]
	public class FixFeet : MonoBehaviour
	{
		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36E1C", Offset = "0xB36E1C")]
		public float weight;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 relativePosL;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 relativePosR;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion relativeRotL;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion relativeRotR;

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x17E3204", Offset = "0x17E3204", VA = "0x17E3204")]
		private void Start()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x17E3260", Offset = "0x17E3260", VA = "0x17E3260")]
		public void Sample()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x17E34B4", Offset = "0x17E34B4", VA = "0x17E34B4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x17E389C", Offset = "0x17E389C", VA = "0x17E389C")]
		public FixFeet()
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class Mirror : MonoBehaviour
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform[] children;

		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform[] targetChildren;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x17E7AA8", Offset = "0x17E7AA8", VA = "0x17E7AA8")]
		private void Start()
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x17E7C20", Offset = "0x17E7C20", VA = "0x17E7C20")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x17E7DB0", Offset = "0x17E7DB0", VA = "0x17E7DB0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x17E7EA8", Offset = "0x17E7EA8", VA = "0x17E7EA8")]
		public Mirror()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public class Phone : MonoBehaviour
	{
		[Token(Token = "0x20000C1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363D8", Offset = "0xB363D8")]
		private sealed class <EnableDisplay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Phone <>4__this;

			[Token(Token = "0x1700007D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60005B1")]
				[Address(RVA = "0x17E973C", Offset = "0x17E973C", VA = "0x17E973C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60005B3")]
				[Address(RVA = "0x17E97A4", Offset = "0x17E97A4", VA = "0x17E97A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x17E9570", Offset = "0x17E9570", VA = "0x17E9570")]
			[DebuggerHidden]
			public <EnableDisplay>d__5(int <>1__state)
			{
			}

			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x17E9684", Offset = "0x17E9684", VA = "0x17E9684", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x17E9688", Offset = "0x17E9688", VA = "0x17E9688", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x17E9744", Offset = "0x17E9744", VA = "0x17E9744", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36E34", Offset = "0xB36E34")]
		public Collider pickUpCollider;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36E6C", Offset = "0xB36E6C")]
		public InteractionObject pickUpObject;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36EA4", Offset = "0xB36EA4")]
		public GameObject display;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform parent;

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x17E9418", Offset = "0x17E9418", VA = "0x17E9418")]
		private void OnPickUp()
		{
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x17E9500", Offset = "0x17E9500", VA = "0x17E9500")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3D338", Offset = "0xB3D338")]
		private IEnumerator EnableDisplay()
		{
			return null;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x17E959C", Offset = "0x17E959C", VA = "0x17E959C")]
		private void OnButton1()
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x17E95A0", Offset = "0x17E95A0", VA = "0x17E95A0")]
		private void OnButton2()
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x17E95FC", Offset = "0x17E95FC", VA = "0x17E95FC")]
		private void DropPhone()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x17E967C", Offset = "0x17E967C", VA = "0x17E967C")]
		public Phone()
		{
		}
	}
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB356D0", Offset = "0xB356D0")]
	public class VRAimingController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public struct Targets
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform leftHand;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform rightHand;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bendGoalLeftArm;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform bendGoalRightArm;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public BoneRotationOffset[] boneRotationOffsets;
		}

		[Serializable]
		[Token(Token = "0x20000C3")]
		public enum Handedness
		{
			[Token(Token = "0x4000559")]
			Right,
			[Token(Token = "0x400055A")]
			Left
		}

		[Serializable]
		[Token(Token = "0x20000C4")]
		public class BoneRotationOffset
		{
			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 value;

			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x16B03A8", Offset = "0x16B03A8", VA = "0x16B03A8")]
			public BoneRotationOffset()
			{
			}
		}

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB36EDC", Offset = "0xB36EDC")]
		public VRAnimatorController animatorController;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36F14", Offset = "0xB36F14")]
		public WeaponBase currentWeapon;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB36F4C", Offset = "0xB36F4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36F4C", Offset = "0xB36F4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36F4C", Offset = "0xB36F4C")]
		public float weight;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB36FC4", Offset = "0xB36FC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB36FC4", Offset = "0xB36FC4")]
		public float spineTwistWeight;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37018", Offset = "0xB37018")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37018", Offset = "0xB37018")]
		public Handedness handedness;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37078", Offset = "0xB37078")]
		public float sideOffset;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB370B0", Offset = "0xB370B0")]
		public Targets leftHandedTargets;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB370E8", Offset = "0xB370E8")]
		public Targets rightHandedTargets;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37120", Offset = "0xB37120")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37120", Offset = "0xB37120")]
		public Transform weaponsPivot;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37180", Offset = "0xB37180")]
		public Transform weaponsAnchor;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB371B8", Offset = "0xB371B8")]
		public Transform pivotMotionTarget;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB371F0", Offset = "0xB371F0")]
		public float lerpSpeed;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37228", Offset = "0xB37228")]
		public float pivotMotionSmoothSpeed;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37260", Offset = "0xB37260")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37260", Offset = "0xB37260")]
		public float pivotMotionWeight;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB372B4", Offset = "0xB372B4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB372B4", Offset = "0xB372B4")]
		public float aimVerticalLimit;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3730C", Offset = "0xB3730C")]
		public float aimZ;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float lastWeight;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Poser poserLeftHand;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Poser poserRightHand;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 pivotRelativePosition;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 weaponsPivotLocalPosition;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 defaultWeaponsAnchorLocalPosition;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private Vector3 aimVel;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 aimRandom;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private float x;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float y;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private float aimWeight;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 cameraPosition;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Vector3 lastCharacterPosition;

		[Token(Token = "0x17000012")]
		private Transform cam
		{
			[Token(Token = "0x6000177")]
			[Address(RVA = "0x16AE4E0", Offset = "0x16AE4E0", VA = "0x16AE4E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000013")]
		private Transform characterController
		{
			[Token(Token = "0x6000178")]
			[Address(RVA = "0x16AE4FC", Offset = "0x16AE4FC", VA = "0x16AE4FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private Targets targets
		{
			[Token(Token = "0x600017C")]
			[Address(RVA = "0x16AF6A0", Offset = "0x16AF6A0", VA = "0x16AF6A0")]
			get
			{
				return default(Targets);
			}
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x16AE518", Offset = "0x16AE518", VA = "0x16AE518")]
		private void Start()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x16AE9C0", Offset = "0x16AE9C0", VA = "0x16AE9C0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x16AF6CC", Offset = "0x16AF6CC", VA = "0x16AF6CC")]
		private void RotateWeapon(float horAdd, float vertAdd)
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x16AE770", Offset = "0x16AE770", VA = "0x16AE770")]
		private Vector3 TargetsCameraPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x16AE6E4", Offset = "0x16AE6E4", VA = "0x16AE6E4")]
		private void SetHandedness(Handedness h)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x16AFD9C", Offset = "0x16AFD9C", VA = "0x16AFD9C")]
		private void TwistSpine()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x16AFFE0", Offset = "0x16AFFE0", VA = "0x16AFFE0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x16B01CC", Offset = "0x16B01CC", VA = "0x16B01CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x16B02C4", Offset = "0x16B02C4", VA = "0x16B02C4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x16B0374", Offset = "0x16B0374", VA = "0x16B0374")]
		public VRAimingController()
		{
		}
	}
	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35734", Offset = "0xB35734")]
	public class VRAnimatorController : MonoBehaviour
	{
		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37344", Offset = "0xB37344")]
		public VRSetup oculusSetup;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform characterController;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cam;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3737C", Offset = "0xB3737C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3737C", Offset = "0xB3737C")]
		public Vector3 cameraOffset;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB373DC", Offset = "0xB373DC")]
		public float smoothAccelerationTime;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37414", Offset = "0xB37414")]
		public float linearAcceleration;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3744C", Offset = "0xB3744C")]
		public float maxViewAngle;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37484", Offset = "0xB37484")]
		public float locomotionSpeed;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB374BC", Offset = "0xB374BC")]
		private Vector3 <velocity>k__BackingField;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Animator animator;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 velocityC;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool rootCorrection;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Vector3 playerVelocity;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 playerLastPosition;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FixFeet fixFeet;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Transform cameraPivot;

		[Token(Token = "0x17000015")]
		public Vector3 velocity
		{
			[Token(Token = "0x6000184")]
			[Address(RVA = "0x16B03B0", Offset = "0x16B03B0", VA = "0x16B03B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D39C", Offset = "0xB3D39C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000185")]
			[Address(RVA = "0x16B03BC", Offset = "0x16B03BC", VA = "0x16B03BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3AC", Offset = "0xB3D3AC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x16B03C8", Offset = "0x16B03C8", VA = "0x16B03C8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x16B061C", Offset = "0x16B061C", VA = "0x16B061C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x16B09E0", Offset = "0x16B09E0", VA = "0x16B09E0")]
		private Vector3 GetVelocityTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x16AFA38", Offset = "0x16AFA38", VA = "0x16AFA38")]
		public void RotateCharacter(Vector3 forward, float maxAngle, [Optional] Transform fix)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x16B0B7C", Offset = "0x16B0B7C", VA = "0x16B0B7C")]
		public VRAnimatorController()
		{
		}
	}
	[Token(Token = "0x200004A")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35798", Offset = "0xB35798")]
	public class VRCharacterController : MonoBehaviour
	{
		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float moveSpeed;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float rotationSpeed;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB374CC", Offset = "0xB374CC")]
		public float rotationRatchet;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public KeyCode ratchetRight;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public KeyCode ratchetLeft;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform forwardDirection;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private CharacterController characterController;

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x16B0B90", Offset = "0x16B0B90", VA = "0x16B0B90")]
		private void Awake()
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x16B0C30", Offset = "0x16B0C30", VA = "0x16B0C30")]
		private void Update()
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x16B0F90", Offset = "0x16B0F90", VA = "0x16B0F90")]
		public VRCharacterController()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x16B0FB4", Offset = "0x16B0FB4", VA = "0x16B0FB4")]
		private void Start()
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x16B1010", Offset = "0x16B1010", VA = "0x16B1010")]
		private void Update()
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x16B1224", Offset = "0x16B1224", VA = "0x16B1224")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x200004C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB357FC", Offset = "0xB357FC")]
	public class VRInteractionController : MonoBehaviour
	{
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB374E8", Offset = "0xB374E8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB374E8", Offset = "0xB374E8")]
		public float triggerTime;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3753C", Offset = "0xB3753C")]
		private InteractionSystem <interactionSystem>k__BackingField;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3754C", Offset = "0xB3754C")]
		private InteractionTrigger <currentTrigger>k__BackingField;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x17000016")]
		public InteractionSystem interactionSystem
		{
			[Token(Token = "0x6000191")]
			[Address(RVA = "0x16B129C", Offset = "0x16B129C", VA = "0x16B129C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3BC", Offset = "0xB3D3BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000192")]
			[Address(RVA = "0x16B12A4", Offset = "0x16B12A4", VA = "0x16B12A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3CC", Offset = "0xB3D3CC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000017")]
		public float triggerProgress
		{
			[Token(Token = "0x6000193")]
			[Address(RVA = "0x16B12AC", Offset = "0x16B12AC", VA = "0x16B12AC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public InteractionTrigger currentTrigger
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x16B12C8", Offset = "0x16B12C8", VA = "0x16B12C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3DC", Offset = "0xB3D3DC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x16B12D0", Offset = "0x16B12D0", VA = "0x16B12D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3EC", Offset = "0xB3D3EC")]
			private set
			{
			}
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x16B12D8", Offset = "0x16B12D8", VA = "0x16B12D8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x16B1330", Offset = "0x16B1330", VA = "0x16B1330")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x16B1428", Offset = "0x16B1428", VA = "0x16B1428")]
		private bool CanTrigger(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x16B1454", Offset = "0x16B1454", VA = "0x16B1454")]
		public VRInteractionController()
		{
		}
	}
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35860", Offset = "0xB35860")]
	public class VRInteractionUI : MonoBehaviour
	{
		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3755C", Offset = "0xB3755C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3755C", Offset = "0xB3755C")]
		public Slider slider;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB375BC", Offset = "0xB375BC")]
		public AnimationCurve alphaToProgress;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB375F4", Offset = "0xB375F4")]
		public Transform cursor;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private VRInteractionController interactionController;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Image[] sliderImages;

		[Token(Token = "0x40001E0")]
		private const string showCursorTag = "ShowCursor";

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x16B1464", Offset = "0x16B1464", VA = "0x16B1464")]
		private void Start()
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x16B14E0", Offset = "0x16B14E0", VA = "0x16B14E0")]
		private void Update()
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x16B1504", Offset = "0x16B1504", VA = "0x16B1504")]
		private void UpdateInteractionSlider()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x16B1704", Offset = "0x16B1704", VA = "0x16B1704")]
		private void UpdateCursor()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x16B1890", Offset = "0x16B1890", VA = "0x16B1890")]
		private void SetSliderAlpha(float a)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x16B1A28", Offset = "0x16B1A28", VA = "0x16B1A28")]
		public VRInteractionUI()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class VRSetup : MonoBehaviour
	{
		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Text text;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject model;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject[] enableOnR;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public VRCharacterController characterController;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool disableMovement;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3762C", Offset = "0xB3762C")]
		private bool <isFinished>k__BackingField;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float moveSpeed;

		[Token(Token = "0x17000019")]
		public bool isFinished
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x16B1A30", Offset = "0x16B1A30", VA = "0x16B1A30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D3FC", Offset = "0xB3D3FC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x16B1A38", Offset = "0x16B1A38", VA = "0x16B1A38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D40C", Offset = "0xB3D40C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x16B1A44", Offset = "0x16B1A44", VA = "0x16B1A44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x16B1B3C", Offset = "0x16B1B3C", VA = "0x16B1B3C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x16B1DD4", Offset = "0x16B1DD4", VA = "0x16B1DD4")]
		public VRSetup()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public abstract class WeaponBase : MonoBehaviour
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3763C", Offset = "0xB3763C")]
		public Vector3 recoilDirection;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float recoilAngleVertical;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float recoilAngleHorizontal;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float recoilRandom;

		[Token(Token = "0x60001A5")]
		public abstract void Fire();

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x16B1DDC", Offset = "0x16B1DDC", VA = "0x16B1DDC")]
		protected WeaponBase()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public class WeaponRifle : WeaponBase
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37674", Offset = "0xB37674")]
		public Transform shootFrom;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float range;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public LayerMask hitLayers;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB376AC", Offset = "0xB376AC")]
		public ParticleSystem muzzleFlash;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public ParticleSystem muzzleSmoke;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform bulletHole;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public ParticleSystem bulletHit;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float smokeFadeOutSpeed;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float smokeEmission;

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x16B1E70", Offset = "0x16B1E70", VA = "0x16B1E70", Slot = "4")]
		public override void Fire()
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x16B210C", Offset = "0x16B210C", VA = "0x16B210C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x16B2214", Offset = "0x16B2214", VA = "0x16B2214")]
		public WeaponRifle()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 localPosition;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion localRotation;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700001A")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x17DBEB4", Offset = "0x17DBEB4", VA = "0x17DBEB4", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x17DBE90", Offset = "0x17DBE90", VA = "0x17DBE90", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x17DBEBC", Offset = "0x17DBEBC", VA = "0x17DBEBC")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x17DBF80", Offset = "0x17DBF80", VA = "0x17DBF80", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x17DC1D8", Offset = "0x17DC1D8", VA = "0x17DC1D8", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x17DC438", Offset = "0x17DC438", VA = "0x17DC438")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB358C4", Offset = "0xB358C4")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CharacterThirdPerson characterController;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float pivotOffset;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private AnimationCurve moveSpeed;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Animator animator;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x17DC450", Offset = "0x17DC450", VA = "0x17DC450", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x17DC4B0", Offset = "0x17DC4B0", VA = "0x17DC4B0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x17DC5DC", Offset = "0x17DC5DC", VA = "0x17DC5DC")]
		private void Update()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x17DC758", Offset = "0x17DC758", VA = "0x17DC758")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35928", Offset = "0xB35928")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37744", Offset = "0xB37744")]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		protected Animator animator;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 lastForward;

		[Token(Token = "0x4000206")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000207")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x1700001B")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x17DC810", Offset = "0x17DC810", VA = "0x17DC810", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x17DC770", Offset = "0x17DC770", VA = "0x17DC770", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x17DC7F4", Offset = "0x17DC7F4", VA = "0x17DC7F4", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x17DC900", Offset = "0x17DC900", VA = "0x17DC900", Slot = "8")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x17DCC4C", Offset = "0x17DCC4C", VA = "0x17DCC4C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x17DCCE8", Offset = "0x17DCCE8", VA = "0x17DCCE8")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000054")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3598C", Offset = "0xB3598C")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB3598C", Offset = "0xB3598C")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37788", Offset = "0xB37788")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37788", Offset = "0xB37788")]
		public Transform gravityTarget;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB377E8", Offset = "0xB377E8")]
		[SerializeField]
		protected float gravityMultiplier;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected float airborneThreshold;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float slopeStartAngle;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float slopeEndAngle;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float spherecastRadius;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private LayerMask groundLayers;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000212")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60001BA")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x17DD204", Offset = "0x17DD204", VA = "0x17DD204")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x17DD388", Offset = "0x17DD388", VA = "0x17DD388", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x17DD520", Offset = "0x17DD520", VA = "0x17DD520", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x17DD798", Offset = "0x17DD798", VA = "0x17DD798")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x17DD85C", Offset = "0x17DD85C", VA = "0x17DD85C")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x17DDA44", Offset = "0x17DDA44", VA = "0x17DDA44")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x17DDBF4", Offset = "0x17DDBF4", VA = "0x17DDBF4")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x17DDC18", Offset = "0x17DDC18", VA = "0x17DDC18")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x17DDC3C", Offset = "0x17DDC3C", VA = "0x17DDC3C")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x17DDD40", Offset = "0x17DDD40", VA = "0x17DDD40")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x20000C5")]
		public enum MoveMode
		{
			[Token(Token = "0x400055E")]
			Directional,
			[Token(Token = "0x400055F")]
			Strafe
		}

		[Token(Token = "0x20000C6")]
		public struct AnimState
		{
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;
		}

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37884", Offset = "0xB37884")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB378BC", Offset = "0xB378BC")]
		public MoveMode moveMode;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB378F4", Offset = "0xB378F4")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3792C", Offset = "0xB3792C")]
		public float airSpeed;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airControl;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float jumpPower;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB37964", Offset = "0xB37964")]
		[SerializeField]
		private LayerMask wallRunLayers;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public float wallRunMaxLength;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB379B0", Offset = "0xB379B0")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB379E8", Offset = "0xB379E8")]
		private bool <onGround>k__BackingField;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public AnimState animState;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Animator animator;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Vector3 normal;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 platformVelocity;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private RaycastHit hit;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private float jumpLeg;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private float jumpEndTime;

		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private float forwardMlp;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private float groundDistance;

		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float lastAirTime;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float stickyForce;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private Vector3 wallNormal;

		[Token(Token = "0x400023F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private float wallRunWeight;

		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private bool fixedFrame;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private float wallRunEndTime;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private Vector3 gravity;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		private float velocityY;

		[Token(Token = "0x1700001C")]
		public bool onGround
		{
			[Token(Token = "0x60001C5")]
			[Address(RVA = "0x17DE15C", Offset = "0x17DE15C", VA = "0x17DE15C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D41C", Offset = "0xB3D41C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x17DE164", Offset = "0x17DE164", VA = "0x17DE164")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D42C", Offset = "0xB3D42C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x17DE170", Offset = "0x17DE170", VA = "0x17DE170", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x17DE2F4", Offset = "0x17DE2F4", VA = "0x17DE2F4")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x17DE384", Offset = "0x17DE384", VA = "0x17DE384", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x17DE4C0", Offset = "0x17DE4C0", VA = "0x17DE4C0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x17DF2E8", Offset = "0x17DF2E8", VA = "0x17DF2E8", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x17DF664", Offset = "0x17DF664", VA = "0x17DF664", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x17DE8E0", Offset = "0x17DE8E0", VA = "0x17DE8E0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x17DF744", Offset = "0x17DF744", VA = "0x17DF744")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x17DFD34", Offset = "0x17DFD34", VA = "0x17DFD34")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x17DF3C4", Offset = "0x17DF3C4", VA = "0x17DF3C4")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x17DFDD4", Offset = "0x17DFDD4", VA = "0x17DFDD4", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x17E020C", Offset = "0x17E020C", VA = "0x17E020C")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x17E0398", Offset = "0x17E0398", VA = "0x17E0398", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x17DEEC8", Offset = "0x17DEEC8", VA = "0x17DEEC8")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x17E052C", Offset = "0x17E052C", VA = "0x17E052C")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000056")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB35A18", Offset = "0xB35A18")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C7")]
		public enum RotationMode
		{
			[Token(Token = "0x4000567")]
			Smooth,
			[Token(Token = "0x4000568")]
			Linear
		}

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB379F8", Offset = "0xB379F8")]
		[SerializeField]
		private CameraController cameraController;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37A44", Offset = "0xB37A44")]
		[SerializeField]
		private float accelerationTime;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37A90", Offset = "0xB37A90")]
		[SerializeField]
		private float turnTime;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37ADC", Offset = "0xB37ADC")]
		[SerializeField]
		private bool walkByDefault;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37B28", Offset = "0xB37B28")]
		[SerializeField]
		private RotationMode rotationMode;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37B74", Offset = "0xB37B74")]
		[SerializeField]
		private float moveSpeed;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB37BC0", Offset = "0xB37BC0")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x1700001D")]
		public bool isGrounded
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x17EBCE8", Offset = "0x17EBCE8", VA = "0x17EBCE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D43C", Offset = "0xB3D43C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001D7")]
			[Address(RVA = "0x17EBCF0", Offset = "0x17EBCF0", VA = "0x17EBCF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D44C", Offset = "0xB3D44C")]
			private set
			{
			}
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x17EBCFC", Offset = "0x17EBCFC", VA = "0x17EBCFC")]
		private void Start()
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x17EBD84", Offset = "0x17EBD84", VA = "0x17EBD84")]
		private void Update()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x17EC480", Offset = "0x17EC480", VA = "0x17EC480")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x17EBDD8", Offset = "0x17EBDD8", VA = "0x17EBDD8")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x17EC1D8", Offset = "0x17EC1D8", VA = "0x17EC1D8")]
		private void Move()
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x17EC4C0", Offset = "0x17EC4C0", VA = "0x17EC4C0")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x17EC5B8", Offset = "0x17EC5B8", VA = "0x17EC5B8")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x17EC658", Offset = "0x17EC658", VA = "0x17EC658")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x2000057")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x16ADB84", Offset = "0x16ADB84", VA = "0x16ADB84", Slot = "4")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x16ADD88", Offset = "0x16ADD88", VA = "0x16ADD88")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000058")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x20000C8")]
		public struct State
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x16AE4A8", Offset = "0x16AE4A8", VA = "0x16AE4A8")]
		private void Start()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x16ADEC8", Offset = "0x16ADEC8", VA = "0x16ADEC8", Slot = "4")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x16ADDA4", Offset = "0x16ADDA4", VA = "0x16ADDA4")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000059")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x17DB848", Offset = "0x17DB848", VA = "0x17DB848")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x17DB884", Offset = "0x17DB884", VA = "0x17DB884")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x200005A")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private KeyCode[] keyCodes;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool mouse0;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[SerializeField]
		private bool mouse1;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float slowMoTimeScale;

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x17EC680", Offset = "0x17EC680", VA = "0x17EC680")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x17EC6B4", Offset = "0x17EC6B4", VA = "0x17EC6B4")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x17EC764", Offset = "0x17EC764", VA = "0x17EC764")]
		public SlowMo()
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35A7C", Offset = "0xB35A7C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35A7C", Offset = "0xB35A7C")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x16B2E5C", Offset = "0x16B2E5C", VA = "0x16B2E5C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D45C", Offset = "0xB3D45C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x16B2EA8", Offset = "0x16B2EA8", VA = "0x16B2EA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D494", Offset = "0xB3D494")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x16B2EF4", Offset = "0x16B2EF4", VA = "0x16B2EF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D4CC", Offset = "0xB3D4CC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x16B2F40", Offset = "0x16B2F40", VA = "0x16B2F40")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D504", Offset = "0xB3D504")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x16B2F8C", Offset = "0x16B2F8C", VA = "0x16B2F8C")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x16B3028", Offset = "0x16B3028", VA = "0x16B3028")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x16B3048", Offset = "0x16B3048", VA = "0x16B3048")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x16B3078", Offset = "0x16B3078", VA = "0x16B3078")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x16B30A8", Offset = "0x16B30A8", VA = "0x16B30A8")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x16B30E8", Offset = "0x16B30E8", VA = "0x16B30E8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x16B312C", Offset = "0x16B312C", VA = "0x16B312C")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x16B3150", Offset = "0x16B3150", VA = "0x16B3150")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x16B3174", Offset = "0x16B3174", VA = "0x16B3174")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x16B319C", Offset = "0x16B319C", VA = "0x16B319C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x16B31C8", Offset = "0x16B31C8", VA = "0x16B31C8")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x16B31F4", Offset = "0x16B31F4", VA = "0x16B31F4")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x16B2FAC", Offset = "0x16B2FAC", VA = "0x16B2FAC")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x16B321C", Offset = "0x16B321C", VA = "0x16B321C")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x16B3228", Offset = "0x16B3228", VA = "0x16B3228")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x16B3234", Offset = "0x16B3234", VA = "0x16B3234")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x16B351C", Offset = "0x16B351C", VA = "0x16B351C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x16B35C4", Offset = "0x16B35C4", VA = "0x16B35C4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x16B390C", Offset = "0x16B390C", VA = "0x16B390C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x16B3D5C", Offset = "0x16B3D5C", VA = "0x16B3D5C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x16B3D90", Offset = "0x16B3D90", VA = "0x16B3D90")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005C")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x1700001E")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x16B33D4", Offset = "0x16B33D4", VA = "0x16B33D4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001F")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x16B3F5C", Offset = "0x16B3F5C", VA = "0x16B3F5C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16B3794", Offset = "0x16B3794", VA = "0x16B3794")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x16B3E14", Offset = "0x16B3E14", VA = "0x16B3E14")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005D")]
	public abstract class Constraint
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000020")]
		public bool isValid
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x16B455C", Offset = "0x16B455C", VA = "0x16B455C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000208")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x16B45CC", Offset = "0x16B45CC", VA = "0x16B45CC")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005E")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x16B45D4", Offset = "0x16B45D4", VA = "0x16B45D4", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x16B46E0", Offset = "0x16B46E0", VA = "0x16B46E0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x16B46E8", Offset = "0x16B46E8", VA = "0x16B46E8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200005F")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000021")]
		private bool positionChanged
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x16B48B0", Offset = "0x16B48B0", VA = "0x16B48B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x16B4714", Offset = "0x16B4714", VA = "0x16B4714", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x16B496C", Offset = "0x16B496C", VA = "0x16B496C")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x16B4974", Offset = "0x16B4974", VA = "0x16B4974")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x16B49A0", Offset = "0x16B49A0", VA = "0x16B49A0", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x16B4AC8", Offset = "0x16B4AC8", VA = "0x16B4AC8")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x16B4AD0", Offset = "0x16B4AD0", VA = "0x16B4AD0")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000061")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000022")]
		private bool rotationChanged
		{
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x16B4C9C", Offset = "0x16B4C9C", VA = "0x16B4C9C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x16B4AFC", Offset = "0x16B4AFC", VA = "0x16B4AFC", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x16B4D6C", Offset = "0x16B4D6C", VA = "0x16B4D6C")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x16B4D74", Offset = "0x16B4D74", VA = "0x16B4D74")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public class Constraints
	{
		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 positionOffset;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 position;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37C10", Offset = "0xB37C10")]
		public float positionWeight;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 rotation;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37C28", Offset = "0xB37C28")]
		public float rotationWeight;

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x16B4DA0", Offset = "0x16B4DA0", VA = "0x16B4DA0")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x16B38B8", Offset = "0x16B38B8", VA = "0x16B38B8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x16B3A94", Offset = "0x16B3A94", VA = "0x16B3A94")]
		public void Update()
		{
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x16B4128", Offset = "0x16B4128", VA = "0x16B4128")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class Finger
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37C40", Offset = "0xB37C40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37C40", Offset = "0xB37C40")]
		public float weight;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37C94", Offset = "0xB37C94")]
		public Transform bone1;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37CCC", Offset = "0xB37CCC")]
		public Transform bone2;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37D04", Offset = "0xB37D04")]
		public Transform bone3;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37D3C", Offset = "0xB37D3C")]
		public Transform tip;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37D74", Offset = "0xB37D74")]
		public Transform target;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB37DAC", Offset = "0xB37DAC")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private IKSolverLimb solver;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x17000023")]
		public bool initiated
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x16BBFA4", Offset = "0x16BBFA4", VA = "0x16BBFA4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D53C", Offset = "0xB3D53C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x16BBFAC", Offset = "0x16BBFAC", VA = "0x16BBFAC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D54C", Offset = "0xB3D54C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x16BBFB8", Offset = "0x16BBFB8", VA = "0x16BBFB8")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x16BBFD8", Offset = "0x16BBFD8", VA = "0x16BBFD8")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x16BBFF8", Offset = "0x16BBFF8", VA = "0x16BBFF8")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x16BC018", Offset = "0x16BC018", VA = "0x16BC018")]
			set
			{
			}
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x16BC038", Offset = "0x16BC038", VA = "0x16BC038")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x16BC138", Offset = "0x16BC138", VA = "0x16BC138")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x16BC3A0", Offset = "0x16BC3A0", VA = "0x16BC3A0")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x16BC470", Offset = "0x16BC470", VA = "0x16BC470")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x16BC71C", Offset = "0x16BC71C", VA = "0x16BC71C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x2000064")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37DBC", Offset = "0xB37DBC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37DBC", Offset = "0xB37DBC")]
		public float weight;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB37E10", Offset = "0xB37E10")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000026")]
		public bool initiated
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x16BC72C", Offset = "0x16BC72C", VA = "0x16BC72C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D55C", Offset = "0xB3D55C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x16BC734", Offset = "0x16BC734", VA = "0x16BC734")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D56C", Offset = "0xB3D56C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x16BC740", Offset = "0x16BC740", VA = "0x16BC740")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x16BC7C8", Offset = "0x16BC7C8", VA = "0x16BC7C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D57C", Offset = "0xB3D57C")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x16BCAE8", Offset = "0x16BCAE8", VA = "0x16BCAE8")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x16BCC58", Offset = "0x16BCC58", VA = "0x16BCC58")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x16BC9E0", Offset = "0x16BC9E0", VA = "0x16BC9E0")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x16BCDC0", Offset = "0x16BCDC0", VA = "0x16BCDC0", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x16BCE80", Offset = "0x16BCE80", VA = "0x16BCE80")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x16BCF04", Offset = "0x16BCF04", VA = "0x16BCF04")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x16BCF6C", Offset = "0x16BCF6C", VA = "0x16BCF6C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x16BCF70", Offset = "0x16BCF70", VA = "0x16BCF70", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x16BCF74", Offset = "0x16BCF74", VA = "0x16BCF74")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x20000C9")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37E20", Offset = "0xB37E20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB37E20", Offset = "0xB37E20")]
		public float weight;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37E74", Offset = "0xB37E74")]
		public Grounding solver;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected bool initiated;

		[Token(Token = "0x6000234")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x16BDFA8", Offset = "0x16BDFA8", VA = "0x16BDFA8")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x16BE27C", Offset = "0x16BE27C", VA = "0x16BE27C")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x16BE0EC", Offset = "0x16BE0EC", VA = "0x16BE0EC")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x16BE2B0", Offset = "0x16BE2B0", VA = "0x16BE2B0")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000239")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x600023A")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x16BE4B8", Offset = "0x16BE4B8", VA = "0x16BE4B8")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35ADC", Offset = "0xB35ADC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35ADC", Offset = "0xB35ADC")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37EAC", Offset = "0xB37EAC")]
		public BipedIK ik;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37EE4", Offset = "0xB37EE4")]
		public float spineBend;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37F1C", Offset = "0xB37F1C")]
		public float spineSpeed;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x16BE808", Offset = "0x16BE808", VA = "0x16BE808", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D5B4", Offset = "0xB3D5B4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x16BE854", Offset = "0x16BE854", VA = "0x16BE854", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D5EC", Offset = "0xB3D5EC")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x16BE8A0", Offset = "0x16BE8A0", VA = "0x16BE8A0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x16BE9AC", Offset = "0x16BE9AC", VA = "0x16BE9AC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x16BEA5C", Offset = "0x16BEA5C", VA = "0x16BEA5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x16BEB10", Offset = "0x16BEB10", VA = "0x16BEB10")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x16BF02C", Offset = "0x16BF02C", VA = "0x16BF02C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x16BF080", Offset = "0x16BF080", VA = "0x16BF080")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x16BF83C", Offset = "0x16BF83C", VA = "0x16BF83C")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x16BF99C", Offset = "0x16BF99C", VA = "0x16BF99C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x16BFB2C", Offset = "0x16BFB2C", VA = "0x16BFB2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x16BFC9C", Offset = "0x16BFC9C", VA = "0x16BFC9C")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35B3C", Offset = "0xB35B3C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35B3C", Offset = "0xB35B3C")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x20000CA")]
		public class SpineEffector
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A818", Offset = "0xB3A818")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A850", Offset = "0xB3A850")]
			public float horizontalWeight;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A888", Offset = "0xB3A888")]
			public float verticalWeight;

			[Token(Token = "0x60005B9")]
			[Address(RVA = "0x16C0B04", Offset = "0x16C0B04", VA = "0x16C0B04")]
			public SpineEffector()
			{
			}
		}

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37F54", Offset = "0xB37F54")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37F8C", Offset = "0xB37F8C")]
		public float spineBend;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37FC4", Offset = "0xB37FC4")]
		public float spineSpeed;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x16BFD1C", Offset = "0x16BFD1C", VA = "0x16BFD1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D624", Offset = "0xB3D624")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x16BFD68", Offset = "0x16BFD68", VA = "0x16BFD68", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D65C", Offset = "0xB3D65C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x16BFDB4", Offset = "0x16BFDB4", VA = "0x16BFDB4", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D694", Offset = "0xB3D694")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x16BFE00", Offset = "0x16BFE00", VA = "0x16BFE00", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x16BFE80", Offset = "0x16BFE80", VA = "0x16BFE80")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x16BFF18", Offset = "0x16BFF18", VA = "0x16BFF18")]
		private void Update()
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0x16C01D4", Offset = "0x16C01D4", VA = "0x16C01D4")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x16C01E0", Offset = "0x16C01E0", VA = "0x16C01E0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x16BFFD4", Offset = "0x16BFFD4", VA = "0x16BFFD4")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x16C01EC", Offset = "0x16C01EC", VA = "0x16C01EC")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x16C068C", Offset = "0x16C068C", VA = "0x16C068C")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x16C084C", Offset = "0x16C084C", VA = "0x16C084C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x16C0984", Offset = "0x16C0984", VA = "0x16C0984")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x16C0A84", Offset = "0x16C0A84", VA = "0x16C0A84")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35B9C", Offset = "0xB35B9C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35B9C", Offset = "0xB35B9C")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB37FFC", Offset = "0xB37FFC")]
		public Transform pelvis;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38034", Offset = "0xB38034")]
		public Transform characterRoot;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3806C", Offset = "0xB3806C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3806C", Offset = "0xB3806C")]
		public float rootRotationWeight;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB380C0", Offset = "0xB380C0")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB380F8", Offset = "0xB380F8")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x16C0B14", Offset = "0x16C0B14", VA = "0x16C0B14", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D6CC", Offset = "0xB3D6CC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x16C0B60", Offset = "0x16C0B60", VA = "0x16C0B60", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D704", Offset = "0xB3D704")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x16C0BAC", Offset = "0x16C0BAC", VA = "0x16C0BAC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x16C0BC4", Offset = "0x16C0BC4", VA = "0x16C0BC4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x16C0DB4", Offset = "0x16C0DB4", VA = "0x16C0DB4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x16C0EB4", Offset = "0x16C0EB4", VA = "0x16C0EB4")]
		private void Update()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x16C14F8", Offset = "0x16C14F8", VA = "0x16C14F8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x16C18C0", Offset = "0x16C18C0", VA = "0x16C18C0")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x16C1B30", Offset = "0x16C1B30", VA = "0x16C1B30")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x16C1E50", Offset = "0x16C1E50", VA = "0x16C1E50")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x16C1FDC", Offset = "0x16C1FDC", VA = "0x16C1FDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x16C21A4", Offset = "0x16C21A4", VA = "0x16C21A4")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35BFC", Offset = "0xB35BFC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35BFC", Offset = "0xB35BFC")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x20000CB")]
		public struct Foot
		{
			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60005BA")]
			[Address(RVA = "0xCAF238", Offset = "0xCAF238", VA = "0xCAF238")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38130", Offset = "0xB38130")]
		public Grounding forelegSolver;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38168", Offset = "0xB38168")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38168", Offset = "0xB38168")]
		public float rootRotationWeight;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB381BC", Offset = "0xB381BC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB381BC", Offset = "0xB381BC")]
		public float minRootRotation;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38214", Offset = "0xB38214")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38214", Offset = "0xB38214")]
		public float maxRootRotation;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3826C", Offset = "0xB3826C")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB382A4", Offset = "0xB382A4")]
		public float maxLegOffset;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB382DC", Offset = "0xB382DC")]
		public float maxForeLegOffset;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38314", Offset = "0xB38314")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38314", Offset = "0xB38314")]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38368", Offset = "0xB38368")]
		public Transform characterRoot;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB383A0", Offset = "0xB383A0")]
		public Transform pelvis;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB383D8", Offset = "0xB383D8")]
		public Transform lastSpineBone;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38410", Offset = "0xB38410")]
		public Transform head;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x16C2224", Offset = "0x16C2224", VA = "0x16C2224", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D73C", Offset = "0xB3D73C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x16C2270", Offset = "0x16C2270", VA = "0x16C2270", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D774", Offset = "0xB3D774")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x16C22BC", Offset = "0x16C22BC", VA = "0x16C22BC", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x16C22F0", Offset = "0x16C22F0", VA = "0x16C22F0")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x16C2420", Offset = "0x16C2420", VA = "0x16C2420")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x16C25E0", Offset = "0x16C25E0", VA = "0x16C25E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x16C2648", Offset = "0x16C2648", VA = "0x16C2648")]
		private void Update()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x16C2700", Offset = "0x16C2700", VA = "0x16C2700")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x16C29E4", Offset = "0x16C29E4", VA = "0x16C29E4")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x16C2D44", Offset = "0x16C2D44", VA = "0x16C2D44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x16C2E90", Offset = "0x16C2E90", VA = "0x16C2E90")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x16C3220", Offset = "0x16C3220", VA = "0x16C3220")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x16C3A10", Offset = "0x16C3A10", VA = "0x16C3A10")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x16C3CD0", Offset = "0x16C3CD0", VA = "0x16C3CD0")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x16C3E30", Offset = "0x16C3E30", VA = "0x16C3E30")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x16C410C", Offset = "0x16C410C", VA = "0x16C410C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x16C4144", Offset = "0x16C4144", VA = "0x16C4144")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x16C4304", Offset = "0x16C4304", VA = "0x16C4304")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x200006A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35C5C", Offset = "0xB35C5C")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38458", Offset = "0xB38458")]
		public VRIK ik;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x16C4410", Offset = "0x16C4410", VA = "0x16C4410")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D7AC", Offset = "0xB3D7AC")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x16C4414", Offset = "0x16C4414", VA = "0x16C4414", Slot = "5")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D7E4", Offset = "0xB3D7E4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x16C4418", Offset = "0x16C4418", VA = "0x16C4418", Slot = "6")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D81C", Offset = "0xB3D81C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x16C441C", Offset = "0x16C441C", VA = "0x16C441C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x16C4434", Offset = "0x16C4434", VA = "0x16C4434")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x16C44CC", Offset = "0x16C44CC", VA = "0x16C44CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x16C4580", Offset = "0x16C4580", VA = "0x16C4580")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x16C4780", Offset = "0x16C4780", VA = "0x16C4780")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x16C4A14", Offset = "0x16C4A14", VA = "0x16C4A14")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x16C4B1C", Offset = "0x16C4B1C", VA = "0x16C4B1C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x16C4D1C", Offset = "0x16C4D1C", VA = "0x16C4D1C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x16C4E54", Offset = "0x16C4E54", VA = "0x16C4E54")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x16C4FB4", Offset = "0x16C4FB4", VA = "0x16C4FB4")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x20000CC")]
		public enum Quality
		{
			[Token(Token = "0x4000576")]
			Fastest,
			[Token(Token = "0x4000577")]
			Simple,
			[Token(Token = "0x4000578")]
			Best
		}

		[Token(Token = "0x20000CD")]
		public class Leg
		{
			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A8C0", Offset = "0xB3A8C0")]
			private bool <isGrounded>k__BackingField;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A8D0", Offset = "0xB3A8D0")]
			private Vector3 <IKPosition>k__BackingField;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A8E0", Offset = "0xB3A8E0")]
			private bool <initiated>k__BackingField;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A8F0", Offset = "0xB3A8F0")]
			private float <heightFromGround>k__BackingField;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A900", Offset = "0xB3A900")]
			private Vector3 <velocity>k__BackingField;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A910", Offset = "0xB3A910")]
			private Transform <transform>k__BackingField;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A920", Offset = "0xB3A920")]
			private float <IKOffset>k__BackingField;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Grounding grounding;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private float lastTime;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private float deltaTime;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Quaternion r;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private RaycastHit heelHit;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 up;

			[Token(Token = "0x1700007F")]
			public bool isGrounded
			{
				[Token(Token = "0x60005BB")]
				[Address(RVA = "0x1C783E4", Offset = "0x1C783E4", VA = "0x1C783E4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F160", Offset = "0xB3F160")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005BC")]
				[Address(RVA = "0x1C783EC", Offset = "0x1C783EC", VA = "0x1C783EC")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F170", Offset = "0xB3F170")]
				private set
				{
				}
			}

			[Token(Token = "0x17000080")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60005BD")]
				[Address(RVA = "0x1C783F8", Offset = "0x1C783F8", VA = "0x1C783F8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F180", Offset = "0xB3F180")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005BE")]
				[Address(RVA = "0x1C78404", Offset = "0x1C78404", VA = "0x1C78404")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F190", Offset = "0xB3F190")]
				private set
				{
				}
			}

			[Token(Token = "0x17000081")]
			public bool initiated
			{
				[Token(Token = "0x60005BF")]
				[Address(RVA = "0x1C78410", Offset = "0x1C78410", VA = "0x1C78410")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1A0", Offset = "0xB3F1A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005C0")]
				[Address(RVA = "0x1C78418", Offset = "0x1C78418", VA = "0x1C78418")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1B0", Offset = "0xB3F1B0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000082")]
			public float heightFromGround
			{
				[Token(Token = "0x60005C1")]
				[Address(RVA = "0x1C78424", Offset = "0x1C78424", VA = "0x1C78424")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1C0", Offset = "0xB3F1C0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C2")]
				[Address(RVA = "0x1C7842C", Offset = "0x1C7842C", VA = "0x1C7842C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1D0", Offset = "0xB3F1D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000083")]
			public Vector3 velocity
			{
				[Token(Token = "0x60005C3")]
				[Address(RVA = "0x1C78434", Offset = "0x1C78434", VA = "0x1C78434")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1E0", Offset = "0xB3F1E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005C4")]
				[Address(RVA = "0x1C78440", Offset = "0x1C78440", VA = "0x1C78440")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F1F0", Offset = "0xB3F1F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000084")]
			public Transform transform
			{
				[Token(Token = "0x60005C5")]
				[Address(RVA = "0x1C7844C", Offset = "0x1C7844C", VA = "0x1C7844C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F200", Offset = "0xB3F200")]
				get
				{
					return null;
				}
				[Token(Token = "0x60005C6")]
				[Address(RVA = "0x1C78454", Offset = "0x1C78454", VA = "0x1C78454")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F210", Offset = "0xB3F210")]
				private set
				{
				}
			}

			[Token(Token = "0x17000085")]
			public float IKOffset
			{
				[Token(Token = "0x60005C7")]
				[Address(RVA = "0x1C7845C", Offset = "0x1C7845C", VA = "0x1C7845C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F220", Offset = "0xB3F220")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005C8")]
				[Address(RVA = "0x1C78464", Offset = "0x1C78464", VA = "0x1C78464")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F230", Offset = "0xB3F230")]
				private set
				{
				}
			}

			[Token(Token = "0x17000086")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60005CD")]
				[Address(RVA = "0x1C79730", Offset = "0x1C79730", VA = "0x1C79730")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000087")]
			private float rootYOffset
			{
				[Token(Token = "0x60005D6")]
				[Address(RVA = "0x1C79A28", Offset = "0x1C79A28", VA = "0x1C79A28")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1C7846C", Offset = "0x1C7846C", VA = "0x1C7846C")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1C78550", Offset = "0x1C78550", VA = "0x1C78550")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1C7859C", Offset = "0x1C7859C", VA = "0x1C7859C")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1C78650", Offset = "0x1C78650", VA = "0x1C78650")]
			public void Process()
			{
			}

			[Token(Token = "0x60005CE")]
			[Address(RVA = "0x1C79478", Offset = "0x1C79478", VA = "0x1C79478")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005CF")]
			[Address(RVA = "0x1C78EB4", Offset = "0x1C78EB4", VA = "0x1C78EB4")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1C798B0", Offset = "0x1C798B0", VA = "0x1C798B0")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1C79108", Offset = "0x1C79108", VA = "0x1C79108")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1C79210", Offset = "0x1C79210", VA = "0x1C79210")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1C799AC", Offset = "0x1C799AC", VA = "0x1C799AC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x1C797BC", Offset = "0x1C797BC", VA = "0x1C797BC")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1C79B60", Offset = "0x1C79B60", VA = "0x1C79B60")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60005D7")]
			[Address(RVA = "0x1C79C50", Offset = "0x1C79C50", VA = "0x1C79C50")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x20000CE")]
		public class Pelvis
		{
			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A930", Offset = "0xB3A930")]
			private Vector3 <IKOffset>k__BackingField;

			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A940", Offset = "0xB3A940")]
			private float <heightOffset>k__BackingField;

			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x17000088")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60005D8")]
				[Address(RVA = "0x1C79CF8", Offset = "0x1C79CF8", VA = "0x1C79CF8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F240", Offset = "0xB3F240")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60005D9")]
				[Address(RVA = "0x1C79D04", Offset = "0x1C79D04", VA = "0x1C79D04")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F250", Offset = "0xB3F250")]
				private set
				{
				}
			}

			[Token(Token = "0x17000089")]
			public float heightOffset
			{
				[Token(Token = "0x60005DA")]
				[Address(RVA = "0x1C79D10", Offset = "0x1C79D10", VA = "0x1C79D10")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F260", Offset = "0xB3F260")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005DB")]
				[Address(RVA = "0x1C79D18", Offset = "0x1C79D18", VA = "0x1C79D18")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F270", Offset = "0xB3F270")]
				private set
				{
				}
			}

			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x1C79D20", Offset = "0x1C79D20", VA = "0x1C79D20")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1C79D90", Offset = "0x1C79D90", VA = "0x1C79D90")]
			public void Reset()
			{
			}

			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x1C79D30", Offset = "0x1C79D30", VA = "0x1C79D30")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x1C79E40", Offset = "0x1C79E40", VA = "0x1C79E40")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x1C7A08C", Offset = "0x1C7A08C", VA = "0x1C7A08C")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38490", Offset = "0xB38490")]
		public LayerMask layers;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB384C8", Offset = "0xB384C8")]
		public float maxStep;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38500", Offset = "0xB38500")]
		public float heightOffset;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38538", Offset = "0xB38538")]
		public float footSpeed;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38570", Offset = "0xB38570")]
		public float footRadius;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB385A8", Offset = "0xB385A8")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB385F4", Offset = "0xB385F4")]
		public float prediction;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3862C", Offset = "0xB3862C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3862C", Offset = "0xB3862C")]
		public float footRotationWeight;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38680", Offset = "0xB38680")]
		public float footRotationSpeed;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB386B8", Offset = "0xB386B8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB386B8", Offset = "0xB386B8")]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38710", Offset = "0xB38710")]
		public bool rotateSolver;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38748", Offset = "0xB38748")]
		public float pelvisSpeed;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38780", Offset = "0xB38780")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38780", Offset = "0xB38780")]
		public float pelvisDamper;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB387D4", Offset = "0xB387D4")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3880C", Offset = "0xB3880C")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38844", Offset = "0xB38844")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3887C", Offset = "0xB3887C")]
		public Quality quality;

		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB388B4", Offset = "0xB388B4")]
		private Leg[] <legs>k__BackingField;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB388C4", Offset = "0xB388C4")]
		private Pelvis <pelvis>k__BackingField;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB388D4", Offset = "0xB388D4")]
		private bool <isGrounded>k__BackingField;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB388E4", Offset = "0xB388E4")]
		private Transform <root>k__BackingField;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB388F4", Offset = "0xB388F4")]
		private RaycastHit <rootHit>k__BackingField;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x17000027")]
		public Leg[] legs
		{
			[Token(Token = "0x6000281")]
			[Address(RVA = "0x16C5010", Offset = "0x16C5010", VA = "0x16C5010")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D854", Offset = "0xB3D854")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000282")]
			[Address(RVA = "0x16C5018", Offset = "0x16C5018", VA = "0x16C5018")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D864", Offset = "0xB3D864")]
			private set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public Pelvis pelvis
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0x16C5020", Offset = "0x16C5020", VA = "0x16C5020")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D874", Offset = "0xB3D874")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000284")]
			[Address(RVA = "0x16C5028", Offset = "0x16C5028", VA = "0x16C5028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D884", Offset = "0xB3D884")]
			private set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public bool isGrounded
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0x16C5030", Offset = "0x16C5030", VA = "0x16C5030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D894", Offset = "0xB3D894")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000286")]
			[Address(RVA = "0x16C5038", Offset = "0x16C5038", VA = "0x16C5038")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8A4", Offset = "0xB3D8A4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public Transform root
		{
			[Token(Token = "0x6000287")]
			[Address(RVA = "0x16C5044", Offset = "0x16C5044", VA = "0x16C5044")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8B4", Offset = "0xB3D8B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000288")]
			[Address(RVA = "0x16C504C", Offset = "0x16C504C", VA = "0x16C504C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8C4", Offset = "0xB3D8C4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0x16C5054", Offset = "0x16C5054", VA = "0x16C5054")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8D4", Offset = "0xB3D8D4")]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x600028A")]
			[Address(RVA = "0x16C506C", Offset = "0x16C506C", VA = "0x16C506C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3D8E4", Offset = "0xB3D8E4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public bool rootGrounded
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0x16C508C", Offset = "0x16C508C", VA = "0x16C508C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public Vector3 up
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x16BF910", Offset = "0x16BF910", VA = "0x16BF910")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700002E")]
		private bool useRootRotation
		{
			[Token(Token = "0x6000296")]
			[Address(RVA = "0x16C55B4", Offset = "0x16C55B4", VA = "0x16C55B4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x16C50E0", Offset = "0x16C50E0", VA = "0x16C50E0")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x16C54C0", Offset = "0x16C54C0", VA = "0x16C54C0")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x16BEDC4", Offset = "0x16BEDC4", VA = "0x16BEDC4")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x16BF5CC", Offset = "0x16BF5CC", VA = "0x16BF5CC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x16C12E0", Offset = "0x16C12E0", VA = "0x16C12E0")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x16BE920", Offset = "0x16BE920", VA = "0x16BE920")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x16C559C", Offset = "0x16C559C", VA = "0x16C559C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x16C5684", Offset = "0x16C5684", VA = "0x16C5684")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x16C57EC", Offset = "0x16C57EC", VA = "0x16C57EC")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x16C58F0", Offset = "0x16C58F0", VA = "0x16C58F0")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x16BE56C", Offset = "0x16BE56C", VA = "0x16BE56C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35C94", Offset = "0xB35C94")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35C94", Offset = "0xB35C94")]
	public class AimIK : IK
	{
		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x16B2228", Offset = "0x16B2228", VA = "0x16B2228", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D8F4", Offset = "0xB3D8F4")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x16B2274", Offset = "0x16B2274", VA = "0x16B2274", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D92C", Offset = "0xB3D92C")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x16B22C0", Offset = "0x16B22C0", VA = "0x16B22C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D964", Offset = "0xB3D964")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x16B230C", Offset = "0x16B230C", VA = "0x16B230C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D99C", Offset = "0xB3D99C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x16B2358", Offset = "0x16B2358", VA = "0x16B2358")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3D9D4", Offset = "0xB3D9D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x16B23A4", Offset = "0x16B23A4", VA = "0x16B23A4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x16B23AC", Offset = "0x16B23AC", VA = "0x16B23AC")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35CF4", Offset = "0xB35CF4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35CF4", Offset = "0xB35CF4")]
	public class CCDIK : IK
	{
		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x16B43BC", Offset = "0x16B43BC", VA = "0x16B43BC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DA0C", Offset = "0xB3DA0C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x16B4408", Offset = "0x16B4408", VA = "0x16B4408", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DA44", Offset = "0xB3DA44")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x16B4454", Offset = "0x16B4454", VA = "0x16B4454")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DA7C", Offset = "0xB3DA7C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x16B44A0", Offset = "0x16B44A0", VA = "0x16B44A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DAB4", Offset = "0xB3DAB4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x16B44EC", Offset = "0x16B44EC", VA = "0x16B44EC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x16B44F4", Offset = "0x16B44F4", VA = "0x16B44F4")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35D54", Offset = "0xB35D54")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35D54", Offset = "0xB35D54")]
	public class FABRIK : IK
	{
		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x16B4E10", Offset = "0x16B4E10", VA = "0x16B4E10", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DAEC", Offset = "0xB3DAEC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x16B4E5C", Offset = "0x16B4E5C", VA = "0x16B4E5C", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DB24", Offset = "0xB3DB24")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x16B4EA8", Offset = "0x16B4EA8", VA = "0x16B4EA8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DB5C", Offset = "0xB3DB5C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x16B4EF4", Offset = "0x16B4EF4", VA = "0x16B4EF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DB94", Offset = "0xB3DB94")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x16B4F40", Offset = "0x16B4F40", VA = "0x16B4F40", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x16B4F48", Offset = "0x16B4F48", VA = "0x16B4F48")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35DB4", Offset = "0xB35DB4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35DB4", Offset = "0xB35DB4")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x16B55C8", Offset = "0x16B55C8", VA = "0x16B55C8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DBCC", Offset = "0xB3DBCC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x16B5614", Offset = "0x16B5614", VA = "0x16B5614", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DC04", Offset = "0xB3DC04")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x16B5660", Offset = "0x16B5660", VA = "0x16B5660")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DC3C", Offset = "0xB3DC3C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x16B56AC", Offset = "0x16B56AC", VA = "0x16B56AC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DC74", Offset = "0xB3DC74")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x16B56F8", Offset = "0x16B56F8", VA = "0x16B56F8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x16B5700", Offset = "0x16B5700", VA = "0x16B5700")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35E14", Offset = "0xB35E14")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35E14", Offset = "0xB35E14")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x16BCFDC", Offset = "0x16BCFDC", VA = "0x16BCFDC", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DCAC", Offset = "0xB3DCAC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x16BD028", Offset = "0x16BD028", VA = "0x16BD028", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DCE4", Offset = "0xB3DCE4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x16BD074", Offset = "0x16BD074", VA = "0x16BD074")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DD1C", Offset = "0xB3DD1C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x16BD0C0", Offset = "0x16BD0C0", VA = "0x16BD0C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DD54", Offset = "0xB3DD54")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x16BD10C", Offset = "0x16BD10C", VA = "0x16BD10C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DD8C", Offset = "0xB3DD8C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x16BD158", Offset = "0x16BD158", VA = "0x16BD158")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DDC4", Offset = "0xB3DDC4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x16BD1A4", Offset = "0x16BD1A4", VA = "0x16BD1A4")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x16BD1C8", Offset = "0x16BD1C8", VA = "0x16BD1C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x16BD1D0", Offset = "0x16BD1D0", VA = "0x16BD1D0")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x16BD38C", Offset = "0x16BD38C", VA = "0x16BD38C")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x16BD6E0", Offset = "0x16BD6E0", VA = "0x16BD6E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DDFC", Offset = "0xB3DDFC")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x16BD700", Offset = "0x16BD700", VA = "0x16BD700")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DE34", Offset = "0xB3DE34")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x16BD7DC", Offset = "0x16BD7DC", VA = "0x16BD7DC")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000071")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x60002BF")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x1C7CB8C", Offset = "0x1C7CB8C", VA = "0x1C7CB8C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x1C7CC78", Offset = "0x1C7CC78", VA = "0x1C7CC78", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x1C7CE34", Offset = "0x1C7CE34", VA = "0x1C7CE34", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60002C3")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x60002C4")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x1C7CE94", Offset = "0x1C7CE94", VA = "0x1C7CE94")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000072")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38904", Offset = "0xB38904")]
		public IK[] IKComponents;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3893C", Offset = "0xB3893C")]
		public Animator animator;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x1700002F")]
		private bool animatePhysics
		{
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x1C7FDF4", Offset = "0x1C7FDF4", VA = "0x1C7FDF4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x1C7FE90", Offset = "0x1C7FE90", VA = "0x1C7FE90")]
		private void Start()
		{
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x1C7FF00", Offset = "0x1C7FF00", VA = "0x1C7FF00")]
		private void Update()
		{
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x1C7FFBC", Offset = "0x1C7FFBC", VA = "0x1C7FFBC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x1C7FFF8", Offset = "0x1C7FFF8", VA = "0x1C7FFF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x1C7FF34", Offset = "0x1C7FF34", VA = "0x1C7FF34")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x1C80084", Offset = "0x1C80084", VA = "0x1C80084")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35E74", Offset = "0xB35E74")]
	public class LegIK : IK
	{
		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x1D7068C", Offset = "0x1D7068C", VA = "0x1D7068C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DE6C", Offset = "0xB3DE6C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x1D706F8", Offset = "0x1D706F8", VA = "0x1D706F8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DEA4", Offset = "0xB3DEA4")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x1D70764", Offset = "0x1D70764", VA = "0x1D70764")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DEDC", Offset = "0xB3DEDC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1D707B0", Offset = "0x1D707B0", VA = "0x1D707B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DF14", Offset = "0xB3DF14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1D707FC", Offset = "0x1D707FC", VA = "0x1D707FC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1D70804", Offset = "0x1D70804", VA = "0x1D70804")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35EAC", Offset = "0xB35EAC")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35EAC", Offset = "0xB35EAC")]
	public class LimbIK : IK
	{
		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x1D7086C", Offset = "0x1D7086C", VA = "0x1D7086C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DF4C", Offset = "0xB3DF4C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1D708B8", Offset = "0x1D708B8", VA = "0x1D708B8", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DF84", Offset = "0xB3DF84")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1D70904", Offset = "0x1D70904", VA = "0x1D70904")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DFBC", Offset = "0xB3DFBC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x1D70950", Offset = "0x1D70950", VA = "0x1D70950")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3DFF4", Offset = "0xB3DFF4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x1D7099C", Offset = "0x1D7099C", VA = "0x1D7099C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x1D709A4", Offset = "0x1D709A4", VA = "0x1D709A4")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35F0C", Offset = "0xB35F0C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35F0C", Offset = "0xB35F0C")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x1D70A0C", Offset = "0x1D70A0C", VA = "0x1D70A0C", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E02C", Offset = "0xB3E02C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1D70A58", Offset = "0x1D70A58", VA = "0x1D70A58", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E064", Offset = "0xB3E064")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1D70AA4", Offset = "0x1D70AA4", VA = "0x1D70AA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E09C", Offset = "0xB3E09C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x1D70AF0", Offset = "0x1D70AF0", VA = "0x1D70AF0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E0D4", Offset = "0xB3E0D4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1D70B3C", Offset = "0x1D70B3C", VA = "0x1D70B3C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1D70B44", Offset = "0x1D70B44", VA = "0x1D70B44")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB35F6C", Offset = "0xB35F6C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35F6C", Offset = "0xB35F6C")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1D78D88", Offset = "0x1D78D88", VA = "0x1D78D88", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E10C", Offset = "0xB3E10C")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1D78DD4", Offset = "0x1D78DD4", VA = "0x1D78DD4", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E144", Offset = "0xB3E144")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1D78E20", Offset = "0x1D78E20", VA = "0x1D78E20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E17C", Offset = "0xB3E17C")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1D78E6C", Offset = "0x1D78E6C", VA = "0x1D78E6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E1B4", Offset = "0xB3E1B4")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1D78EB8", Offset = "0x1D78EB8", VA = "0x1D78EB8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1D78EC0", Offset = "0x1D78EC0", VA = "0x1D78EC0")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000077")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB35FCC", Offset = "0xB35FCC")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x20000CF")]
		public class References
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform chest;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform neck;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Transform leftShoulder;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Transform rightShoulder;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Transform leftThigh;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Transform leftCalf;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Transform leftFoot;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public Transform leftToes;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public Transform rightThigh;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform rightCalf;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Transform rightFoot;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public Transform rightToes;

			[Token(Token = "0x1700008A")]
			public bool isFilled
			{
				[Token(Token = "0x60005E2")]
				[Address(RVA = "0x1D79FD4", Offset = "0x1D79FD4", VA = "0x1D79FD4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700008B")]
			public bool isEmpty
			{
				[Token(Token = "0x60005E3")]
				[Address(RVA = "0x1D79B58", Offset = "0x1D79B58", VA = "0x1D79B58")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x1D7A3C0", Offset = "0x1D7A3C0", VA = "0x1D7A3C0")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x1D79744", Offset = "0x1D79744", VA = "0x1D79744")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x1D7A3B8", Offset = "0x1D7A3B8", VA = "0x1D7A3B8")]
			public References()
			{
			}
		}

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "ContextMenuItemAttribute", RVA = "0xB38974", Offset = "0xB38974")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38974", Offset = "0xB38974")]
		public References references;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB389F0", Offset = "0xB389F0")]
		public IKSolverVR solver;

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1D795F8", Offset = "0x1D795F8", VA = "0x1D795F8", Slot = "8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E1EC", Offset = "0xB3E1EC")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1D79664", Offset = "0x1D79664", VA = "0x1D79664", Slot = "9")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E224", Offset = "0xB3E224")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x1D796D0", Offset = "0x1D796D0", VA = "0x1D796D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E25C", Offset = "0xB3E25C")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1D7971C", Offset = "0x1D7971C", VA = "0x1D7971C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E294", Offset = "0xB3E294")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1D79AB4", Offset = "0x1D79AB4", VA = "0x1D79AB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E2CC", Offset = "0xB3E2CC")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x1D79ADC", Offset = "0x1D79ADC", VA = "0x1D79ADC", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1D79AE4", Offset = "0x1D79AE4", VA = "0x1D79AE4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1D7A330", Offset = "0x1D7A330", VA = "0x1D7A330")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000078")]
	public class FABRIKChain
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38A28", Offset = "0xB38A28")]
		public float pull;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38A40", Offset = "0xB38A40")]
		public float pin;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x16B4FB0", Offset = "0x16B4FB0", VA = "0x16B4FB0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x16B5078", Offset = "0x16B5078", VA = "0x16B5078")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x16B5098", Offset = "0x16B5098", VA = "0x16B5098")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x16B5468", Offset = "0x16B5468", VA = "0x16B5468")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x16B516C", Offset = "0x16B516C", VA = "0x16B516C")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x16B5560", Offset = "0x16B5560", VA = "0x16B5560")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x16B5768", Offset = "0x16B5768", VA = "0x16B5768")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x16B5CD0", Offset = "0x16B5CD0", VA = "0x16B5CD0")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x16B5E90", Offset = "0x16B5E90", VA = "0x16B5E90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x16B5F88", Offset = "0x16B5F88", VA = "0x16B5F88")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200007A")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000D0")]
		public class BendBone
		{
			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A950", Offset = "0xB3A950")]
			public Transform transform;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A988", Offset = "0xB3A988")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3A988", Offset = "0xB3A988")]
			public float weight;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x16B8FF0", Offset = "0x16B8FF0", VA = "0x16B8FF0")]
			public BendBone()
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x16B9070", Offset = "0x16B9070", VA = "0x16B9070")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x16B6740", Offset = "0x16B6740", VA = "0x16B6740")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x16B6B48", Offset = "0x16B6B48", VA = "0x16B6B48")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38A58", Offset = "0xB38A58")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB38A90", Offset = "0xB38A90")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38A90", Offset = "0xB38A90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38A90", Offset = "0xB38A90")]
		public float positionWeight;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38B08", Offset = "0xB38B08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38B08", Offset = "0xB38B08")]
		public float bodyWeight;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38B5C", Offset = "0xB38B5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38B5C", Offset = "0xB38B5C")]
		public float thighWeight;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38BB0", Offset = "0xB38BB0")]
		public bool handsPullBody;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB38BE8", Offset = "0xB38BE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38BE8", Offset = "0xB38BE8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38BE8", Offset = "0xB38BE8")]
		public float rotationWeight;

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38C60", Offset = "0xB38C60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38C60", Offset = "0xB38C60")]
		public float bodyClampWeight;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38CB4", Offset = "0xB38CB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38CB4", Offset = "0xB38CB4")]
		public float headClampWeight;

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38D08", Offset = "0xB38D08")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38D08", Offset = "0xB38D08")]
		public float bendWeight;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38D5C", Offset = "0xB38D5C")]
		public BendBone[] bendBones;

		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB38D94", Offset = "0xB38D94")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38D94", Offset = "0xB38D94")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38D94", Offset = "0xB38D94")]
		public float CCDWeight;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38E0C", Offset = "0xB38E0C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38E0C", Offset = "0xB38E0C")]
		public float roll;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38E60", Offset = "0xB38E60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38E60", Offset = "0xB38E60")]
		public float damper;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38EB8", Offset = "0xB38EB8")]
		public Transform[] CCDBones;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB38EF0", Offset = "0xB38EF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38EF0", Offset = "0xB38EF0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB38EF0", Offset = "0xB38EF0")]
		public float postStretchWeight;

		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38F68", Offset = "0xB38F68")]
		public float maxStretch;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38FA0", Offset = "0xB38FA0")]
		public float stretchDamper;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB38FD8", Offset = "0xB38FD8")]
		public bool fixHead;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39010", Offset = "0xB39010")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "LargeHeader", RVA = "0xB39048", Offset = "0xB39048")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39080", Offset = "0xB39080")]
		public float chestDirectionWeight;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x16B5F90", Offset = "0x16B5F90", VA = "0x16B5F90")]
		private void Awake()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x16B62B8", Offset = "0x16B62B8", VA = "0x16B62B8")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x16B6778", Offset = "0x16B6778", VA = "0x16B6778")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x16B6B70", Offset = "0x16B6B70", VA = "0x16B6B70")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x16B74FC", Offset = "0x16B74FC", VA = "0x16B74FC")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x16B7848", Offset = "0x16B7848", VA = "0x16B7848")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x16B7BE4", Offset = "0x16B7BE4", VA = "0x16B7BE4")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x16B8664", Offset = "0x16B8664", VA = "0x16B8664")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x16B7228", Offset = "0x16B7228", VA = "0x16B7228")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x16B8888", Offset = "0x16B8888", VA = "0x16B8888")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x16B8520", Offset = "0x16B8520", VA = "0x16B8520")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x16B8384", Offset = "0x16B8384", VA = "0x16B8384")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x16B8BF4", Offset = "0x16B8BF4", VA = "0x16B8BF4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x16B8E74", Offset = "0x16B8E74", VA = "0x16B8E74")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007B")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public class ChildConstraint
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3A9FC", Offset = "0xB3A9FC")]
			private float <nominalDistance>k__BackingField;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AA0C", Offset = "0xB3AA0C")]
			private bool <isRigid>k__BackingField;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x1700008C")]
			public float nominalDistance
			{
				[Token(Token = "0x60005EA")]
				[Address(RVA = "0x16BBF34", Offset = "0x16BBF34", VA = "0x16BBF34")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F280", Offset = "0xB3F280")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60005EB")]
				[Address(RVA = "0x16BBF3C", Offset = "0x16BBF3C", VA = "0x16BBF3C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F290", Offset = "0xB3F290")]
				private set
				{
				}
			}

			[Token(Token = "0x1700008D")]
			public bool isRigid
			{
				[Token(Token = "0x60005EC")]
				[Address(RVA = "0x16BBF44", Offset = "0x16BBF44", VA = "0x16BBF44")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2A0", Offset = "0xB3F2A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60005ED")]
				[Address(RVA = "0x16BBF4C", Offset = "0x16BBF4C", VA = "0x16BBF4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2B0", Offset = "0xB3F2B0")]
				private set
				{
				}
			}

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x16BBF58", Offset = "0x16BBF58", VA = "0x16BBF58")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x16B9CB8", Offset = "0x16B9CB8", VA = "0x16B9CB8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x16BA1F8", Offset = "0x16BA1F8", VA = "0x16BA1F8")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x16BBC30", Offset = "0x16BBC30", VA = "0x16BBC30")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public enum Smoothing
		{
			[Token(Token = "0x40005B5")]
			None,
			[Token(Token = "0x40005B6")]
			Exponential,
			[Token(Token = "0x40005B7")]
			Cubic
		}

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39098", Offset = "0xB39098")]
		public float pin;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB390B0", Offset = "0xB390B0")]
		public float pull;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB390C8", Offset = "0xB390C8")]
		public float push;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB390E0", Offset = "0xB390E0")]
		public float pushParent;

		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB390F8", Offset = "0xB390F8")]
		public float reach;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000347")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x16B9114", Offset = "0x16B9114", VA = "0x16B9114")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x16B91E0", Offset = "0x16B91E0", VA = "0x16B91E0")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x16B92EC", Offset = "0x16B92EC", VA = "0x16B92EC")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x16B9410", Offset = "0x16B9410", VA = "0x16B9410")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x16B94EC", Offset = "0x16B94EC", VA = "0x16B94EC")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x16B95F0", Offset = "0x16B95F0", VA = "0x16B95F0")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x16B9D10", Offset = "0x16B9D10", VA = "0x16B9D10")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x16B9780", Offset = "0x16B9780", VA = "0x16B9780")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x16BA3FC", Offset = "0x16BA3FC", VA = "0x16BA3FC")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x16BA7A0", Offset = "0x16BA7A0", VA = "0x16BA7A0")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x16BAB84", Offset = "0x16BAB84", VA = "0x16BAB84")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x16BB108", Offset = "0x16BB108", VA = "0x16BB108")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x16BB6D8", Offset = "0x16BB6D8", VA = "0x16BB6D8")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x16BB970", Offset = "0x16BB970", VA = "0x16BB970")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x16BB5D0", Offset = "0x16BB5D0", VA = "0x16BB5D0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x16BAEF0", Offset = "0x16BAEF0", VA = "0x16BAEF0")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x16BB558", Offset = "0x16BB558", VA = "0x16BB558")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x16BBA58", Offset = "0x16BBA58", VA = "0x16BBA58")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x16BB478", Offset = "0x16BB478", VA = "0x16BB478")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x16BB858", Offset = "0x16BB858", VA = "0x16BB858")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007C")]
	public class IKConstraintBend
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39110", Offset = "0xB39110")]
		public float weight;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB39128", Offset = "0xB39128")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x17000030")]
		public bool initiated
		{
			[Token(Token = "0x600031A")]
			[Address(RVA = "0x1C7D064", Offset = "0x1C7D064", VA = "0x1C7D064")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E304", Offset = "0xB3E304")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x1C7D06C", Offset = "0x1C7D06C", VA = "0x1C7D06C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E314", Offset = "0xB3E314")]
			private set
			{
			}
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x1C7CE9C", Offset = "0x1C7CE9C", VA = "0x1C7CE9C")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1C7D078", Offset = "0x1C7D078", VA = "0x1C7D078")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x1C7D0FC", Offset = "0x1C7D0FC", VA = "0x1C7D0FC")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x1C7D1A8", Offset = "0x1C7D1A8", VA = "0x1C7D1A8")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x1C7D1B4", Offset = "0x1C7D1B4", VA = "0x1C7D1B4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x1C7D6DC", Offset = "0x1C7D6DC", VA = "0x1C7D6DC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1C7D90C", Offset = "0x1C7D90C", VA = "0x1C7D90C")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1C7DDA8", Offset = "0x1C7DDA8", VA = "0x1C7DDA8")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1C7D4AC", Offset = "0x1C7D4AC", VA = "0x1C7D4AC")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1C7D5C4", Offset = "0x1C7D5C4", VA = "0x1C7D5C4")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKEffector
	{
		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39138", Offset = "0xB39138")]
		public float positionWeight;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39150", Offset = "0xB39150")]
		public float rotationWeight;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB39168", Offset = "0xB39168")]
		private bool <isEndEffector>k__BackingField;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39178", Offset = "0xB39178")]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x17000031")]
		public bool isEndEffector
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x1C7E458", Offset = "0x1C7E458", VA = "0x1C7E458")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E324", Offset = "0xB3E324")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000327")]
			[Address(RVA = "0x1C7E460", Offset = "0x1C7E460", VA = "0x1C7E460")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E334", Offset = "0xB3E334")]
			private set
			{
			}
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1C7E3F0", Offset = "0x1C7E3F0", VA = "0x1C7E3F0")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1C7E46C", Offset = "0x1C7E46C", VA = "0x1C7E46C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1C7E540", Offset = "0x1C7E540", VA = "0x1C7E540")]
		public IKEffector()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1C7E67C", Offset = "0x1C7E67C", VA = "0x1C7E67C")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1C7E7D4", Offset = "0x1C7E7D4", VA = "0x1C7E7D4")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1C7EAC4", Offset = "0x1C7EAC4", VA = "0x1C7EAC4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1C7ED50", Offset = "0x1C7ED50", VA = "0x1C7ED50")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1C7EE88", Offset = "0x1C7EE88", VA = "0x1C7EE88")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1C7EF34", Offset = "0x1C7EF34", VA = "0x1C7EF34")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1C7F574", Offset = "0x1C7F574", VA = "0x1C7F574")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1C7F5E4", Offset = "0x1C7F5E4", VA = "0x1C7F5E4")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1C7F7F0", Offset = "0x1C7F7F0", VA = "0x1C7F7F0")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x1C7FB24", Offset = "0x1C7FB24", VA = "0x1C7FB24")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D3")]
		public class BoneMap
		{
			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x1700008E")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60005F3")]
				[Address(RVA = "0x1C802F4", Offset = "0x1C802F4", VA = "0x1C802F4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700008F")]
			public bool isNodeBone
			{
				[Token(Token = "0x60005F6")]
				[Address(RVA = "0x1C80460", Offset = "0x1C80460", VA = "0x1C80460")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000090")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x600060A")]
				[Address(RVA = "0x1C80A38", Offset = "0x1C80A38", VA = "0x1C80A38")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x1C802CC", Offset = "0x1C802CC", VA = "0x1C802CC")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x1C803C0", Offset = "0x1C803C0", VA = "0x1C803C0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x1C80410", Offset = "0x1C80410", VA = "0x1C80410")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60005F7")]
			[Address(RVA = "0x1C80470", Offset = "0x1C80470", VA = "0x1C80470")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x1C80558", Offset = "0x1C80558", VA = "0x1C80558")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x1C80560", Offset = "0x1C80560", VA = "0x1C80560")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x1C806F0", Offset = "0x1C806F0", VA = "0x1C806F0")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x1C807FC", Offset = "0x1C807FC", VA = "0x1C807FC")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x1C80888", Offset = "0x1C80888", VA = "0x1C80888")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60005FD")]
			[Address(RVA = "0x1C80C5C", Offset = "0x1C80C5C", VA = "0x1C80C5C")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x1C80C94", Offset = "0x1C80C94", VA = "0x1C80C94")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60005FF")]
			[Address(RVA = "0x1C80CCC", Offset = "0x1C80CCC", VA = "0x1C80CCC")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x6000600")]
			[Address(RVA = "0x1C80CF4", Offset = "0x1C80CF4", VA = "0x1C80CF4")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x6000601")]
			[Address(RVA = "0x1C80E1C", Offset = "0x1C80E1C", VA = "0x1C80E1C")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1C81154", Offset = "0x1C81154", VA = "0x1C81154")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1C81184", Offset = "0x1C81184", VA = "0x1C81184")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1C8131C", Offset = "0x1C8131C", VA = "0x1C8131C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x6000605")]
			[Address(RVA = "0x1C8138C", Offset = "0x1C8138C", VA = "0x1C8138C")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x6000606")]
			[Address(RVA = "0x1C815D0", Offset = "0x1C815D0", VA = "0x1C815D0")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x6000607")]
			[Address(RVA = "0x1C817F8", Offset = "0x1C817F8", VA = "0x1C817F8")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x6000608")]
			[Address(RVA = "0x1C81910", Offset = "0x1C81910", VA = "0x1C81910")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x6000609")]
			[Address(RVA = "0x1C80F5C", Offset = "0x1C80F5C", VA = "0x1C80F5C")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600060B")]
			[Address(RVA = "0x1C81AA0", Offset = "0x1C81AA0", VA = "0x1C81AA0")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1C8008C", Offset = "0x1C8008C", VA = "0x1C8008C", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1C80094", Offset = "0x1C80094", VA = "0x1C80094", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1C80098", Offset = "0x1C80098", VA = "0x1C80098")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x1C801BC", Offset = "0x1C801BC", VA = "0x1C801BC")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1C802C4", Offset = "0x1C802C4", VA = "0x1C802C4")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39190", Offset = "0xB39190")]
		public float maintainRotationWeight;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1C81ABC", Offset = "0x1C81ABC", VA = "0x1C81ABC", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1C81B5C", Offset = "0x1C81B5C", VA = "0x1C81B5C")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x1C81BE0", Offset = "0x1C81BE0", VA = "0x1C81BE0")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1C81C78", Offset = "0x1C81C78", VA = "0x1C81C78")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x1C81C90", Offset = "0x1C81C90", VA = "0x1C81C90")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x1C81CAC", Offset = "0x1C81CAC", VA = "0x1C81CAC", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x1C81D48", Offset = "0x1C81D48", VA = "0x1C81D48")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1C81D60", Offset = "0x1C81D60", VA = "0x1C81D60")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x20000D4")]
		public enum BoneMapType
		{
			[Token(Token = "0x40005CF")]
			Parent,
			[Token(Token = "0x40005D0")]
			Bone1,
			[Token(Token = "0x40005D1")]
			Bone2,
			[Token(Token = "0x40005D2")]
			Bone3
		}

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB391A8", Offset = "0xB391A8")]
		public float maintainRotationWeight;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB391C0", Offset = "0xB391C0")]
		public float weight;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private BoneMap boneMapParent;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMap1;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap2;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap3;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1C81D84", Offset = "0x1C81D84", VA = "0x1C81D84", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1C81E08", Offset = "0x1C81E08", VA = "0x1C81E08")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1C81EDC", Offset = "0x1C81EDC", VA = "0x1C81EDC")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1C82230", Offset = "0x1C82230", VA = "0x1C82230")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1C82330", Offset = "0x1C82330", VA = "0x1C82330")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1C8245C", Offset = "0x1C8245C", VA = "0x1C8245C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1C82468", Offset = "0x1C82468", VA = "0x1C82468")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1C82510", Offset = "0x1C82510", VA = "0x1C82510")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1C825C8", Offset = "0x1C825C8", VA = "0x1C825C8", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1C82838", Offset = "0x1C82838", VA = "0x1C82838")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1C828F0", Offset = "0x1C828F0", VA = "0x1C828F0")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB391D8", Offset = "0xB391D8")]
		public int iterations;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB391F0", Offset = "0xB391F0")]
		public float twistWeight;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1C82A58", Offset = "0x1C82A58", VA = "0x1C82A58", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1C82D48", Offset = "0x1C82D48", VA = "0x1C82D48")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1C82E64", Offset = "0x1C82E64", VA = "0x1C82E64")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1C82FBC", Offset = "0x1C82FBC", VA = "0x1C82FBC")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1C82FCC", Offset = "0x1C82FCC", VA = "0x1C82FCC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1C83034", Offset = "0x1C83034", VA = "0x1C83034")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1C830B4", Offset = "0x1C830B4", VA = "0x1C830B4", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1C83708", Offset = "0x1C83708", VA = "0x1C83708")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1C83740", Offset = "0x1C83740", VA = "0x1C83740")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1C83A20", Offset = "0x1C83A20", VA = "0x1C83A20")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1C83DCC", Offset = "0x1C83DCC", VA = "0x1C83DCC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1C83EB8", Offset = "0x1C83EB8", VA = "0x1C83EB8")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1C83F80", Offset = "0x1C83F80", VA = "0x1C83F80")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000D5")]
		public class Point
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AA1C", Offset = "0xB3AA1C")]
			public float weight;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600060C")]
			[Address(RVA = "0x1C85AA0", Offset = "0x1C85AA0", VA = "0x1C85AA0")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x600060D")]
			[Address(RVA = "0x1C85AF0", Offset = "0x1C85AF0", VA = "0x1C85AF0")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600060E")]
			[Address(RVA = "0x1C85C78", Offset = "0x1C85C78", VA = "0x1C85C78")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x600060F")]
			[Address(RVA = "0x1C85CB0", Offset = "0x1C85CB0", VA = "0x1C85CB0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000610")]
			[Address(RVA = "0x1C85CE8", Offset = "0x1C85CE8", VA = "0x1C85CE8")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000611")]
			[Address(RVA = "0x1C85D38", Offset = "0x1C85D38", VA = "0x1C85D38")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000612")]
			[Address(RVA = "0x1C85574", Offset = "0x1C85574", VA = "0x1C85574")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D6")]
		public class Bone : Point
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x17000091")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000613")]
				[Address(RVA = "0x1C84B44", Offset = "0x1C84B44", VA = "0x1C84B44")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000614")]
				[Address(RVA = "0x1C84C38", Offset = "0x1C84C38", VA = "0x1C84C38")]
				set
				{
				}
			}

			[Token(Token = "0x6000615")]
			[Address(RVA = "0x1C84CC0", Offset = "0x1C84CC0", VA = "0x1C84CC0")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000616")]
			[Address(RVA = "0x1C84F80", Offset = "0x1C84F80", VA = "0x1C84F80")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000617")]
			[Address(RVA = "0x1C85260", Offset = "0x1C85260", VA = "0x1C85260")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000618")]
			[Address(RVA = "0x1C854C8", Offset = "0x1C854C8", VA = "0x1C854C8")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x6000619")]
			[Address(RVA = "0x1C854F0", Offset = "0x1C854F0", VA = "0x1C854F0")]
			public Bone()
			{
			}

			[Token(Token = "0x600061A")]
			[Address(RVA = "0x1C855F4", Offset = "0x1C855F4", VA = "0x1C855F4")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600061B")]
			[Address(RVA = "0x1C8568C", Offset = "0x1C8568C", VA = "0x1C8568C")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Node : Point
		{
			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600061C")]
			[Address(RVA = "0x1C85A3C", Offset = "0x1C85A3C", VA = "0x1C85A3C")]
			public Node()
			{
			}

			[Token(Token = "0x600061D")]
			[Address(RVA = "0x1C85A40", Offset = "0x1C85A40", VA = "0x1C85A40")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x600061E")]
			[Address(RVA = "0x1C85A68", Offset = "0x1C85A68", VA = "0x1C85A68")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x20000D8")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x20000D9")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39218", Offset = "0xB39218")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39218", Offset = "0xB39218")]
		public float IKPositionWeight;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3926C", Offset = "0xB3926C")]
		private bool <initiated>k__BackingField;

		[Token(Token = "0x4000397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x17000032")]
		public bool initiated
		{
			[Token(Token = "0x6000362")]
			[Address(RVA = "0x1C84594", Offset = "0x1C84594", VA = "0x1C84594")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E344", Offset = "0xB3E344")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x1C8459C", Offset = "0x1C8459C", VA = "0x1C8459C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E354", Offset = "0xB3E354")]
			private set
			{
			}
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1C84260", Offset = "0x1C84260", VA = "0x1C84260")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x600035A")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1C7CCE8", Offset = "0x1C7CCE8", VA = "0x1C7CCE8")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1C7CC10", Offset = "0x1C7CC10", VA = "0x1C7CC10")]
		public void Update()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1C844E8", Offset = "0x1C844E8", VA = "0x1C844E8", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1C844F4", Offset = "0x1C844F4", VA = "0x1C844F4")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1C84500", Offset = "0x1C84500", VA = "0x1C84500")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1C84508", Offset = "0x1C84508", VA = "0x1C84508")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1C8458C", Offset = "0x1C8458C", VA = "0x1C8458C")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000364")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000365")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000366")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000367")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000368")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000369")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1C845A8", Offset = "0x1C845A8", VA = "0x1C845A8")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1C845C0", Offset = "0x1C845C0", VA = "0x1C845C0")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1C846FC", Offset = "0x1C846FC", VA = "0x1C846FC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1C847A8", Offset = "0x1C847A8", VA = "0x1C847A8")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1C84B2C", Offset = "0x1C84B2C", VA = "0x1C84B2C")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB392B4", Offset = "0xB392B4")]
		public float poleWeight;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB392CC", Offset = "0xB392CC")]
		public float clampWeight;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB392E4", Offset = "0xB392E4")]
		public int clampSmoothing;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x17000033")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x1C85ED0", Offset = "0x1C85ED0", VA = "0x1C85ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000034")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x1C85F9C", Offset = "0x1C85F9C", VA = "0x1C85F9C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000035")]
		protected override int minBones
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x1C86D0C", Offset = "0x1C86D0C", VA = "0x1C86D0C", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000036")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x1C872B0", Offset = "0x1C872B0", VA = "0x1C872B0", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1C85DD0", Offset = "0x1C85DD0", VA = "0x1C85DD0")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x1C86068", Offset = "0x1C86068", VA = "0x1C86068", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1C862E8", Offset = "0x1C862E8", VA = "0x1C862E8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x1C86C58", Offset = "0x1C86C58", VA = "0x1C86C58")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1C86880", Offset = "0x1C86880", VA = "0x1C86880")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1C86D14", Offset = "0x1C86D14", VA = "0x1C86D14")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1C87324", Offset = "0x1C87324", VA = "0x1C87324")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1C87434", Offset = "0x1C87434", VA = "0x1C87434")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1C874E4", Offset = "0x1C874E4", VA = "0x1C874E4", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1C87AD8", Offset = "0x1C87AD8", VA = "0x1C87AD8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1C88228", Offset = "0x1C88228", VA = "0x1C88228")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1C8897C", Offset = "0x1C8897C", VA = "0x1C8897C")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x17000037")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x6000384")]
			[Address(RVA = "0x1C89B9C", Offset = "0x1C89B9C", VA = "0x1C89B9C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1C88980", Offset = "0x1C88980", VA = "0x1C88980")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1C890C8", Offset = "0x1C890C8", VA = "0x1C890C8")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1C89200", Offset = "0x1C89200", VA = "0x1C89200", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1C89298", Offset = "0x1C89298", VA = "0x1C89298", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1C8983C", Offset = "0x1C8983C", VA = "0x1C8983C", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1C89BA4", Offset = "0x1C89BA4", VA = "0x1C89BA4")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1C88A54", Offset = "0x1C88A54", VA = "0x1C88A54")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1C891AC", Offset = "0x1C891AC", VA = "0x1C891AC")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1C89B40", Offset = "0x1C89B40", VA = "0x1C89B40")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1C88EF0", Offset = "0x1C88EF0", VA = "0x1C88EF0")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1C8A3E4", Offset = "0x1C8A3E4", VA = "0x1C8A3E4")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1C8A4F4", Offset = "0x1C8A4F4", VA = "0x1C8A4F4")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1C8A620", Offset = "0x1C8A620", VA = "0x1C8A620")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1C8A738", Offset = "0x1C8A738", VA = "0x1C8A738")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1C895A4", Offset = "0x1C895A4", VA = "0x1C895A4")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1C896F0", Offset = "0x1C896F0", VA = "0x1C896F0")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1C8A924", Offset = "0x1C8A924", VA = "0x1C8A924")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1C89E5C", Offset = "0x1C89E5C", VA = "0x1C89E5C")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1C8919C", Offset = "0x1C8919C", VA = "0x1C8919C")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1C8B08C", Offset = "0x1C8B08C", VA = "0x1C8B08C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1C8AAF8", Offset = "0x1C8AAF8", VA = "0x1C8AAF8")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1C89CBC", Offset = "0x1C89CBC", VA = "0x1C89CBC")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1C89D98", Offset = "0x1C89D98", VA = "0x1C89D98")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1C8B158", Offset = "0x1C8B158", VA = "0x1C8B158")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB392FC", Offset = "0xB392FC")]
		public float rootPin;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1C8B1CC", Offset = "0x1C8B1CC", VA = "0x1C8B1CC", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1C8BA98", Offset = "0x1C8BA98", VA = "0x1C8BA98", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x1C8BB30", Offset = "0x1C8BB30", VA = "0x1C8BB30", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1C8BBC8", Offset = "0x1C8BBC8", VA = "0x1C8BBC8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1C8BCC8", Offset = "0x1C8BCC8", VA = "0x1C8BCC8")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1C8BD64", Offset = "0x1C8BD64", VA = "0x1C8BD64", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1C8C2CC", Offset = "0x1C8C2CC", VA = "0x1C8C2CC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x1C8C4CC", Offset = "0x1C8C4CC", VA = "0x1C8C4CC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1C8C37C", Offset = "0x1C8C37C", VA = "0x1C8C37C")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1C8BF98", Offset = "0x1C8BF98", VA = "0x1C8BF98")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x1C8C564", Offset = "0x1C8C564", VA = "0x1C8C564")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39314", Offset = "0xB39314")]
		public int iterations;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x1C8C5DC", Offset = "0x1C8C5DC", VA = "0x1C8C5DC")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x1C8C6D0", Offset = "0x1C8C6D0", VA = "0x1C8C6D0")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1C8C72C", Offset = "0x1C8C72C", VA = "0x1C8C72C")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1C7E394", Offset = "0x1C7E394", VA = "0x1C7E394")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x1C7D42C", Offset = "0x1C7D42C", VA = "0x1C7D42C")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x1C8C860", Offset = "0x1C8C860", VA = "0x1C8C860", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x1C8C9E8", Offset = "0x1C8C9E8", VA = "0x1C8C9E8", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x1C8CB5C", Offset = "0x1C8CB5C", VA = "0x1C8CB5C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1C8CD5C", Offset = "0x1C8CD5C", VA = "0x1C8CD5C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1C8CE2C", Offset = "0x1C8CE2C", VA = "0x1C8CE2C", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1C8CF00", Offset = "0x1C8CF00", VA = "0x1C8CF00", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x1C8D070", Offset = "0x1C8D070", VA = "0x1C8D070", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x1C8D228", Offset = "0x1C8D228", VA = "0x1C8D228", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x1C8D464", Offset = "0x1C8D464", VA = "0x1C8D464", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x1C8D724", Offset = "0x1C8D724", VA = "0x1C8D724", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x1C8D768", Offset = "0x1C8D768", VA = "0x1C8D768", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x1C8D84C", Offset = "0x1C8D84C", VA = "0x1C8D84C")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x40003C4")]
		Body,
		[Token(Token = "0x40003C5")]
		LeftShoulder,
		[Token(Token = "0x40003C6")]
		RightShoulder,
		[Token(Token = "0x40003C7")]
		LeftThigh,
		[Token(Token = "0x40003C8")]
		RightThigh,
		[Token(Token = "0x40003C9")]
		LeftHand,
		[Token(Token = "0x40003CA")]
		RightHand,
		[Token(Token = "0x40003CB")]
		LeftFoot,
		[Token(Token = "0x40003CC")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000089")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x40003CE")]
		LeftArm,
		[Token(Token = "0x40003CF")]
		RightArm,
		[Token(Token = "0x40003D0")]
		LeftLeg,
		[Token(Token = "0x40003D1")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x200008A")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3932C", Offset = "0xB3932C")]
		public float spineStiffness;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39344", Offset = "0xB39344")]
		public float pullBodyVertical;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3935C", Offset = "0xB3935C")]
		public float pullBodyHorizontal;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB39374", Offset = "0xB39374")]
		private Vector3 <pullBodyOffset>k__BackingField;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x17000038")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x1C8D92C", Offset = "0x1C8D92C", VA = "0x1C8D92C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x1C8D934", Offset = "0x1C8D934", VA = "0x1C8D934")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0x1C8D93C", Offset = "0x1C8D93C", VA = "0x1C8D93C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x60003B7")]
			[Address(RVA = "0x1C8D944", Offset = "0x1C8D944", VA = "0x1C8D944")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x60003B8")]
			[Address(RVA = "0x1C8D94C", Offset = "0x1C8D94C", VA = "0x1C8D94C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x60003B9")]
			[Address(RVA = "0x1C8D954", Offset = "0x1C8D954", VA = "0x1C8D954")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003E")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0x1C8D95C", Offset = "0x1C8D95C", VA = "0x1C8D95C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x1C8D964", Offset = "0x1C8D964", VA = "0x1C8D964")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000040")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x1C8D96C", Offset = "0x1C8D96C", VA = "0x1C8D96C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x1C8D974", Offset = "0x1C8D974", VA = "0x1C8D974")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x1C8D9AC", Offset = "0x1C8D9AC", VA = "0x1C8D9AC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x1C8D9E4", Offset = "0x1C8D9E4", VA = "0x1C8D9E4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x1C8DA1C", Offset = "0x1C8DA1C", VA = "0x1C8DA1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x1C8DA54", Offset = "0x1C8DA54", VA = "0x1C8DA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000046")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x1C8DA88", Offset = "0x1C8DA88", VA = "0x1C8DA88")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x60003C3")]
			[Address(RVA = "0x1C8DAC0", Offset = "0x1C8DAC0", VA = "0x1C8DAC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000048")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x1C8DAF8", Offset = "0x1C8DAF8", VA = "0x1C8DAF8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x1C8DB30", Offset = "0x1C8DB30", VA = "0x1C8DB30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1C8FA80", Offset = "0x1C8FA80", VA = "0x1C8FA80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E364", Offset = "0xB3E364")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1C8FA8C", Offset = "0x1C8FA8C", VA = "0x1C8FA8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E374", Offset = "0xB3E374")]
			private set
			{
			}
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1C8DB64", Offset = "0x1C8DB64", VA = "0x1C8DB64")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1C8DC70", Offset = "0x1C8DC70", VA = "0x1C8DC70")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1C8DBB8", Offset = "0x1C8DBB8", VA = "0x1C8DBB8")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1C8DD4C", Offset = "0x1C8DD4C", VA = "0x1C8DD4C")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x1C7B840", Offset = "0x1C7B840", VA = "0x1C7B840")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x1C8DE1C", Offset = "0x1C8DE1C", VA = "0x1C8DE1C")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x1C8DED4", Offset = "0x1C8DED4", VA = "0x1C8DED4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x1C8DF88", Offset = "0x1C8DF88", VA = "0x1C8DF88")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x1C8E03C", Offset = "0x1C8E03C", VA = "0x1C8E03C")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x1C8E044", Offset = "0x1C8E044", VA = "0x1C8E044")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x1C8E078", Offset = "0x1C8E078", VA = "0x1C8E078")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x1C8E140", Offset = "0x1C8E140", VA = "0x1C8E140", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x1C8E2D0", Offset = "0x1C8E2D0", VA = "0x1C8E2D0")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x1C8F3A4", Offset = "0x1C8F3A4", VA = "0x1C8F3A4")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x1C8F838", Offset = "0x1C8F838", VA = "0x1C8F838")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x1C8F898", Offset = "0x1C8F898", VA = "0x1C8F898")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x1C8F6B8", Offset = "0x1C8F6B8", VA = "0x1C8F6B8")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x1C8F778", Offset = "0x1C8F778", VA = "0x1C8F778")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x1C8FA98", Offset = "0x1C8FA98", VA = "0x1C8FA98")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x1C8FB74", Offset = "0x1C8FB74", VA = "0x1C8FB74", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x1C8FCB8", Offset = "0x1C8FCB8", VA = "0x1C8FCB8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x1C8FE48", Offset = "0x1C8FE48", VA = "0x1C8FE48")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x1C90048", Offset = "0x1C90048", VA = "0x1C90048")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x1C90248", Offset = "0x1C90248", VA = "0x1C90248", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x1C90578", Offset = "0x1C90578", VA = "0x1C90578", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x1C90678", Offset = "0x1C90678", VA = "0x1C90678")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x1700004B")]
		protected virtual int minBones
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x1C90EA8", Offset = "0x1C90EA8", VA = "0x1C90EA8", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700004C")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x1C90EB0", Offset = "0x1C90EB0", VA = "0x1C90EB0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004D")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x1C90EB8", Offset = "0x1C90EB8", VA = "0x1C90EB8", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60003EF")]
			[Address(RVA = "0x1C90EC8", Offset = "0x1C90EC8", VA = "0x1C90EC8", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700004F")]
		protected float positionOffset
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0x1C88164", Offset = "0x1C88164", VA = "0x1C88164")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x1C90684", Offset = "0x1C90684", VA = "0x1C90684")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x1C90810", Offset = "0x1C90810", VA = "0x1C90810")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x1C9094C", Offset = "0x1C9094C", VA = "0x1C9094C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x1C909B4", Offset = "0x1C909B4", VA = "0x1C909B4", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x1C90A28", Offset = "0x1C90A28", VA = "0x1C90A28", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x1C90DAC", Offset = "0x1C90DAC", VA = "0x1C90DAC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1C90DB4", Offset = "0x1C90DB4", VA = "0x1C90DB4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x1C90EC0", Offset = "0x1C90EC0", VA = "0x1C90EC0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1C90EC4", Offset = "0x1C90EC4", VA = "0x1C90EC4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1C87564", Offset = "0x1C87564", VA = "0x1C87564")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1C87DCC", Offset = "0x1C87DCC", VA = "0x1C87DCC")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1C90FFC", Offset = "0x1C90FFC", VA = "0x1C90FFC")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1C873B8", Offset = "0x1C873B8", VA = "0x1C873B8")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39384", Offset = "0xB39384")]
		public float IKRotationWeight;

		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x1B92750", Offset = "0x1B92750", VA = "0x1B92750", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x1B92AC4", Offset = "0x1B92AC4", VA = "0x1B92AC4")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x1B92B34", Offset = "0x1B92B34", VA = "0x1B92B34", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1B92C90", Offset = "0x1B92C90", VA = "0x1B92C90", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1B92E28", Offset = "0x1B92E28", VA = "0x1B92E28", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x1B92E84", Offset = "0x1B92E84", VA = "0x1B92E84", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0x1B92EE0", Offset = "0x1B92EE0", VA = "0x1B92EE0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1B93244", Offset = "0x1B93244", VA = "0x1B93244", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1B93270", Offset = "0x1B93270", VA = "0x1B93270")]
		private void Solve()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1B92F44", Offset = "0x1B92F44", VA = "0x1B92F44")]
		private void Read()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1B93370", Offset = "0x1B93370", VA = "0x1B93370")]
		private void Write()
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1B9388C", Offset = "0x1B9388C", VA = "0x1B9388C")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x20000DA")]
		public enum BendModifier
		{
			[Token(Token = "0x40005E3")]
			Animation,
			[Token(Token = "0x40005E4")]
			Target,
			[Token(Token = "0x40005E5")]
			Parent,
			[Token(Token = "0x40005E6")]
			Arm,
			[Token(Token = "0x40005E7")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x20000DB")]
		public struct AxisDirection
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x6000627")]
			[Address(RVA = "0xCBA77C", Offset = "0xCBA77C", VA = "0xCBA77C")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3939C", Offset = "0xB3939C")]
		public float maintainRotationWeight;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB393B4", Offset = "0xB393B4")]
		public float bendModifierWeight;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x17000050")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x1B95190", Offset = "0x1B95190", VA = "0x1B95190")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1B93A8C", Offset = "0x1B93A8C", VA = "0x1B93A8C")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1B93ADC", Offset = "0x1B93ADC", VA = "0x1B93ADC")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1B93BF0", Offset = "0x1B93BF0", VA = "0x1B93BF0", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0x1B94260", Offset = "0x1B94260", VA = "0x1B94260", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000404")]
		[Address(RVA = "0x1B94E3C", Offset = "0x1B94E3C", VA = "0x1B94E3C", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000405")]
		[Address(RVA = "0x1B94F84", Offset = "0x1B94F84", VA = "0x1B94F84")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1B95108", Offset = "0x1B95108", VA = "0x1B95108")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x6000408")]
		[Address(RVA = "0x1B93F6C", Offset = "0x1B93F6C", VA = "0x1B93F6C")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x6000409")]
		[Address(RVA = "0x1B9438C", Offset = "0x1B9438C", VA = "0x1B9438C")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200008E")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DC")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x17000092")]
			public Vector3 forward
			{
				[Token(Token = "0x600062C")]
				[Address(RVA = "0x1B9700C", Offset = "0x1B9700C", VA = "0x1B9700C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1B97758", Offset = "0x1B97758", VA = "0x1B97758")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1B963E0", Offset = "0x1B963E0", VA = "0x1B963E0")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1B9671C", Offset = "0x1B9671C", VA = "0x1B9671C")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1B97410", Offset = "0x1B97410", VA = "0x1B97410")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB393CC", Offset = "0xB393CC")]
		public float bodyWeight;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB393E4", Offset = "0xB393E4")]
		public float headWeight;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB393FC", Offset = "0xB393FC")]
		public float eyesWeight;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39414", Offset = "0xB39414")]
		public float clampWeight;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3942C", Offset = "0xB3942C")]
		public float clampWeightHead;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39444", Offset = "0xB39444")]
		public float clampWeightEyes;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3945C", Offset = "0xB3945C")]
		public int clampSmoothing;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3[] spineForwards;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] headForwards;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] eyeForward;

		[Token(Token = "0x17000051")]
		private bool spineIsValid
		{
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1B95B44", Offset = "0x1B95B44", VA = "0x1B95B44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		private bool spineIsEmpty
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1B95D1C", Offset = "0x1B95D1C", VA = "0x1B95D1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000053")]
		private bool headIsValid
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1B95C28", Offset = "0x1B95C28", VA = "0x1B95C28")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		private bool headIsEmpty
		{
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1B95D40", Offset = "0x1B95D40", VA = "0x1B95D40")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		private bool eyesIsValid
		{
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1B95C38", Offset = "0x1B95C38", VA = "0x1B95C38")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		private bool eyesIsEmpty
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1B95DBC", Offset = "0x1B95DBC", VA = "0x1B95DBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x1B9520C", Offset = "0x1B9520C", VA = "0x1B9520C")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x1B95290", Offset = "0x1B95290", VA = "0x1B95290")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x1B9533C", Offset = "0x1B9533C", VA = "0x1B9533C")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1B95404", Offset = "0x1B95404", VA = "0x1B95404")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1B954F0", Offset = "0x1B954F0", VA = "0x1B954F0")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1B955FC", Offset = "0x1B955FC", VA = "0x1B955FC")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1B95744", Offset = "0x1B95744", VA = "0x1B95744", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1B95874", Offset = "0x1B95874", VA = "0x1B95874", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1B959B0", Offset = "0x1B959B0", VA = "0x1B959B0", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1B95DE0", Offset = "0x1B95DE0", VA = "0x1B95DE0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1B96018", Offset = "0x1B96018", VA = "0x1B96018", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1B961B8", Offset = "0x1B961B8", VA = "0x1B961B8")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1B9640C", Offset = "0x1B9640C", VA = "0x1B9640C", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000417")]
		[Address(RVA = "0x1B96858", Offset = "0x1B96858", VA = "0x1B96858", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600041A")]
		[Address(RVA = "0x1B9695C", Offset = "0x1B9695C", VA = "0x1B9695C")]
		private void SolveSpine()
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0x1B96B50", Offset = "0x1B96B50", VA = "0x1B96B50")]
		private void SolveHead()
		{
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0x1B96DAC", Offset = "0x1B96DAC", VA = "0x1B96DAC")]
		private void SolveEyes()
		{
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0x1B970D8", Offset = "0x1B970D8", VA = "0x1B970D8")]
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1B96268", Offset = "0x1B96268", VA = "0x1B96268")]
		private void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1B97578", Offset = "0x1B97578", VA = "0x1B97578")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1B98D1C", Offset = "0x1B98D1C", VA = "0x1B98D1C")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1B998C4", Offset = "0x1B998C4", VA = "0x1B998C4")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1B93B24", Offset = "0x1B93B24", VA = "0x1B93B24")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1B9998C", Offset = "0x1B9998C", VA = "0x1B9998C")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39474", Offset = "0xB39474")]
		public float IKRotationWeight;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1B97760", Offset = "0x1B97760", VA = "0x1B97760")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1B97950", Offset = "0x1B97950", VA = "0x1B97950")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1B97B04", Offset = "0x1B97B04", VA = "0x1B97B04")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1B97B10", Offset = "0x1B97B10", VA = "0x1B97B10")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1B97B94", Offset = "0x1B97B94", VA = "0x1B97B94")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1B97BA0", Offset = "0x1B97BA0", VA = "0x1B97BA0")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1B97BA8", Offset = "0x1B97BA8", VA = "0x1B97BA8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1B97CAC", Offset = "0x1B97CAC", VA = "0x1B97CAC", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1B97DCC", Offset = "0x1B97DCC", VA = "0x1B97DCC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1B97E18", Offset = "0x1B97E18", VA = "0x1B97E18", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1B97E64", Offset = "0x1B97E64", VA = "0x1B97E64", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1B98240", Offset = "0x1B98240", VA = "0x1B98240")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1B98298", Offset = "0x1B98298", VA = "0x1B98298")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1B98840", Offset = "0x1B98840", VA = "0x1B98840")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1B98A58", Offset = "0x1B98A58", VA = "0x1B98A58", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1B98C14", Offset = "0x1B98C14", VA = "0x1B98C14")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1B98B90", Offset = "0x1B98B90", VA = "0x1B98B90")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1B98EBC", Offset = "0x1B98EBC", VA = "0x1B98EBC", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1B99980", Offset = "0x1B99980", VA = "0x1B99980", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1B99984", Offset = "0x1B99984", VA = "0x1B99984", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1B99988", Offset = "0x1B99988", VA = "0x1B99988", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x1B995C8", Offset = "0x1B995C8", VA = "0x1B995C8")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1B94FF8", Offset = "0x1B94FF8", VA = "0x1B94FF8")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000090")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x20000DE")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000108")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x4000727")]
				YawPitch,
				[Token(Token = "0x4000728")]
				FromTo
			}

			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AA34", Offset = "0xB3AA34")]
			public Transform target;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AA6C", Offset = "0xB3AA6C")]
			public Transform bendGoal;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AAA4", Offset = "0xB3AAA4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AAA4", Offset = "0xB3AAA4")]
			public float positionWeight;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AAF8", Offset = "0xB3AAF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AAF8", Offset = "0xB3AAF8")]
			public float rotationWeight;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AB4C", Offset = "0xB3AB4C")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AB84", Offset = "0xB3AB84")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AB84", Offset = "0xB3AB84")]
			public float shoulderRotationWeight;

			[Token(Token = "0x40005F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3ABD8", Offset = "0xB3ABD8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3ABD8", Offset = "0xB3ABD8")]
			public float bendGoalWeight;

			[Token(Token = "0x40005F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AC2C", Offset = "0xB3AC2C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AC2C", Offset = "0xB3AC2C")]
			public float swivelOffset;

			[Token(Token = "0x40005F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AC88", Offset = "0xB3AC88")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40005F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3ACC0", Offset = "0xB3ACC0")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40005F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[HideInInspector]
			public Vector3 IKPosition;

			[Token(Token = "0x40005F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Quaternion IKRotation;

			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			public Vector3 bendDirection;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AD28", Offset = "0xB3AD28")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x40005FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AD38", Offset = "0xB3AD38")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x40005FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			private bool hasShoulder;

			[Token(Token = "0x40005FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40005FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x4000600")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			private Quaternion chestRotation;

			[Token(Token = "0x4000601")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Vector3 chestForward;

			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
			private Vector3 chestUp;

			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x4000604")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x4000605")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x17000093")]
			public Vector3 position
			{
				[Token(Token = "0x6000631")]
				[Address(RVA = "0x1BA1880", Offset = "0x1BA1880", VA = "0x1BA1880")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2C0", Offset = "0xB3F2C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000632")]
				[Address(RVA = "0x1BA188C", Offset = "0x1BA188C", VA = "0x1BA188C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2D0", Offset = "0xB3F2D0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000094")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000633")]
				[Address(RVA = "0x1BA1898", Offset = "0x1BA1898", VA = "0x1BA1898")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2E0", Offset = "0xB3F2E0")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000634")]
				[Address(RVA = "0x1BA18A4", Offset = "0x1BA18A4", VA = "0x1BA18A4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F2F0", Offset = "0xB3F2F0")]
				private set
				{
				}
			}

			[Token(Token = "0x17000095")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x6000635")]
				[Address(RVA = "0x1BA18B0", Offset = "0x1BA18B0", VA = "0x1BA18B0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000096")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x6000636")]
				[Address(RVA = "0x1BA18E4", Offset = "0x1BA18E4", VA = "0x1BA18E4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000097")]
			private VirtualBone forearm
			{
				[Token(Token = "0x6000637")]
				[Address(RVA = "0x1BA191C", Offset = "0x1BA191C", VA = "0x1BA191C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000098")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000638")]
				[Address(RVA = "0x1BA1954", Offset = "0x1BA1954", VA = "0x1BA1954")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000639")]
			[Address(RVA = "0x1BA198C", Offset = "0x1BA198C", VA = "0x1BA198C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600063A")]
			[Address(RVA = "0x1BA20F4", Offset = "0x1BA20F4", VA = "0x1BA20F4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600063B")]
			[Address(RVA = "0x1BA22E8", Offset = "0x1BA22E8", VA = "0x1BA22E8", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600063C")]
			[Address(RVA = "0x1B9FB2C", Offset = "0x1B9FB2C", VA = "0x1B9FB2C")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x600063D")]
			[Address(RVA = "0x1BA3408", Offset = "0x1BA3408", VA = "0x1BA3408", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600063E")]
			[Address(RVA = "0x1BA3478", Offset = "0x1BA3478", VA = "0x1BA3478", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600063F")]
			[Address(RVA = "0x1BA2394", Offset = "0x1BA2394", VA = "0x1BA2394")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x1BA26A0", Offset = "0x1BA26A0", VA = "0x1BA26A0")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000641")]
			[Address(RVA = "0x1BA3584", Offset = "0x1BA3584", VA = "0x1BA3584")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x6000642")]
			[Address(RVA = "0x1BA16A0", Offset = "0x1BA16A0", VA = "0x1BA16A0")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000DF")]
		public abstract class BodyPart
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AD48", Offset = "0xB3AD48")]
			private float <sqrMag>k__BackingField;

			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AD58", Offset = "0xB3AD58")]
			private float <mag>k__BackingField;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x17000099")]
			public float sqrMag
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x1BA3744", Offset = "0x1BA3744", VA = "0x1BA3744")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F300", Offset = "0xB3F300")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x1BA374C", Offset = "0x1BA374C", VA = "0x1BA374C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F310", Offset = "0xB3F310")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public float mag
			{
				[Token(Token = "0x600064A")]
				[Address(RVA = "0x1BA3754", Offset = "0x1BA3754", VA = "0x1BA3754")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F320", Offset = "0xB3F320")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600064B")]
				[Address(RVA = "0x1BA375C", Offset = "0x1BA375C", VA = "0x1BA375C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F330", Offset = "0xB3F330")]
				private set
				{
				}
			}

			[Token(Token = "0x6000643")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index);

			[Token(Token = "0x6000644")]
			public abstract void PreSolve();

			[Token(Token = "0x6000645")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x6000646")]
			public abstract void ApplyOffsets();

			[Token(Token = "0x6000647")]
			public abstract void ResetOffsets();

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x1B937C8", Offset = "0x1B937C8", VA = "0x1B937C8")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1BA3A50", Offset = "0x1BA3A50", VA = "0x1BA3A50")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1BA3BBC", Offset = "0x1BA3BBC", VA = "0x1BA3BBC")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1BA3E4C", Offset = "0x1BA3E4C", VA = "0x1BA3E4C")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1B9F8EC", Offset = "0x1B9F8EC", VA = "0x1B9F8EC")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x6000651")]
			[Address(RVA = "0x1BA3268", Offset = "0x1BA3268", VA = "0x1BA3268")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x6000652")]
			[Address(RVA = "0x1BA3EA0", Offset = "0x1BA3EA0", VA = "0x1BA3EA0")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x6000653")]
			[Address(RVA = "0x1BA3FE4", Offset = "0x1BA3FE4", VA = "0x1BA3FE4")]
			public void Visualize()
			{
			}

			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1BA36AC", Offset = "0x1BA36AC", VA = "0x1BA36AC")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E0")]
		public class Footstep
		{
			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AD78", Offset = "0xB3AD78")]
			private float <stepProgress>k__BackingField;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x1700009B")]
			public bool isStepping
			{
				[Token(Token = "0x6000655")]
				[Address(RVA = "0x1BA400C", Offset = "0x1BA400C", VA = "0x1BA400C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x1700009C")]
			public float stepProgress
			{
				[Token(Token = "0x6000656")]
				[Address(RVA = "0x1BA4020", Offset = "0x1BA4020", VA = "0x1BA4020")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F340", Offset = "0xB3F340")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000657")]
				[Address(RVA = "0x1BA4028", Offset = "0x1BA4028", VA = "0x1BA4028")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F350", Offset = "0xB3F350")]
				private set
				{
				}
			}

			[Token(Token = "0x6000658")]
			[Address(RVA = "0x1BA4030", Offset = "0x1BA4030", VA = "0x1BA4030")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1BA4160", Offset = "0x1BA4160", VA = "0x1BA4160")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1BA4290", Offset = "0x1BA4290", VA = "0x1BA4290")]
			public void StepTo(Vector3 p, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1BA4390", Offset = "0x1BA4390", VA = "0x1BA4390")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1BA4568", Offset = "0x1BA4568", VA = "0x1BA4568")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1BA4754", Offset = "0x1BA4754", VA = "0x1BA4754")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E1")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AD88", Offset = "0xB3AD88")]
			public Transform target;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3ADC0", Offset = "0xB3ADC0")]
			public Transform bendGoal;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3ADF8", Offset = "0xB3ADF8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3ADF8", Offset = "0xB3ADF8")]
			public float positionWeight;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AE4C", Offset = "0xB3AE4C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AE4C", Offset = "0xB3AE4C")]
			public float rotationWeight;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AEA0", Offset = "0xB3AEA0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AEA0", Offset = "0xB3AEA0")]
			public float bendGoalWeight;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AEF4", Offset = "0xB3AEF4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AEF4", Offset = "0xB3AEF4")]
			public float swivelOffset;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public Vector3 IKPosition;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public Quaternion IKRotation;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AFB0", Offset = "0xB3AFB0")]
			private Vector3 <position>k__BackingField;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AFC0", Offset = "0xB3AFC0")]
			private Quaternion <rotation>k__BackingField;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AFD0", Offset = "0xB3AFD0")]
			private bool <hasToes>k__BackingField;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3AFE0", Offset = "0xB3AFE0")]
			private Vector3 <thighRelativeToPelvis>k__BackingField;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Vector3 footPosition;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private Quaternion footRotation;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 bendNormal;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x1700009D")]
			public Vector3 position
			{
				[Token(Token = "0x600065E")]
				[Address(RVA = "0x1BA4970", Offset = "0x1BA4970", VA = "0x1BA4970")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F360", Offset = "0xB3F360")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600065F")]
				[Address(RVA = "0x1BA497C", Offset = "0x1BA497C", VA = "0x1BA497C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F370", Offset = "0xB3F370")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public Quaternion rotation
			{
				[Token(Token = "0x6000660")]
				[Address(RVA = "0x1BA4988", Offset = "0x1BA4988", VA = "0x1BA4988")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F380", Offset = "0xB3F380")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000661")]
				[Address(RVA = "0x1BA4994", Offset = "0x1BA4994", VA = "0x1BA4994")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F390", Offset = "0xB3F390")]
				private set
				{
				}
			}

			[Token(Token = "0x1700009F")]
			public bool hasToes
			{
				[Token(Token = "0x6000662")]
				[Address(RVA = "0x1BA49A0", Offset = "0x1BA49A0", VA = "0x1BA49A0")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3A0", Offset = "0xB3F3A0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000663")]
				[Address(RVA = "0x1BA49A8", Offset = "0x1BA49A8", VA = "0x1BA49A8")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3B0", Offset = "0xB3F3B0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A0")]
			public VirtualBone thigh
			{
				[Token(Token = "0x6000664")]
				[Address(RVA = "0x1BA49B4", Offset = "0x1BA49B4", VA = "0x1BA49B4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A1")]
			private VirtualBone calf
			{
				[Token(Token = "0x6000665")]
				[Address(RVA = "0x1BA49E8", Offset = "0x1BA49E8", VA = "0x1BA49E8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A2")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000666")]
				[Address(RVA = "0x1BA4A20", Offset = "0x1BA4A20", VA = "0x1BA4A20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A3")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000667")]
				[Address(RVA = "0x1BA4A58", Offset = "0x1BA4A58", VA = "0x1BA4A58")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A4")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000668")]
				[Address(RVA = "0x1B9F724", Offset = "0x1B9F724", VA = "0x1B9F724")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000A5")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000669")]
				[Address(RVA = "0x1BA4A90", Offset = "0x1BA4A90", VA = "0x1BA4A90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3C0", Offset = "0xB3F3C0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600066A")]
				[Address(RVA = "0x1BA4A9C", Offset = "0x1BA4A9C", VA = "0x1BA4A9C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3D0", Offset = "0xB3F3D0")]
				private set
				{
				}
			}

			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1BA4AA8", Offset = "0x1BA4AA8", VA = "0x1BA4AA8", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1BA4F50", Offset = "0x1BA4F50", VA = "0x1BA4F50", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600066D")]
			[Address(RVA = "0x1BA5630", Offset = "0x1BA5630", VA = "0x1BA5630", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1BA552C", Offset = "0x1BA552C", VA = "0x1BA552C")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1BA5304", Offset = "0x1BA5304", VA = "0x1BA5304")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1B93488", Offset = "0x1B93488", VA = "0x1B93488")]
			public void Solve()
			{
			}

			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1BA5BE0", Offset = "0x1BA5BE0", VA = "0x1BA5BE0", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1BA5CE8", Offset = "0x1BA5CE8", VA = "0x1BA5CE8", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1B939E0", Offset = "0x1B939E0", VA = "0x1B939E0")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Locomotion
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3AFF0", Offset = "0xB3AFF0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3AFF0", Offset = "0xB3AFF0")]
			public float weight;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B044", Offset = "0xB3B044")]
			public float footDistance;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B07C", Offset = "0xB3B07C")]
			public float stepThreshold;

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B0B4", Offset = "0xB3B0B4")]
			public float angleThreshold;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B0EC", Offset = "0xB3B0EC")]
			public float comAngleMlp;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B124", Offset = "0xB3B124")]
			public float maxVelocity;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B15C", Offset = "0xB3B15C")]
			public float velocityFactor;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B194", Offset = "0xB3B194")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B194", Offset = "0xB3B194")]
			public float maxLegStretch;

			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B1EC", Offset = "0xB3B1EC")]
			public float rootSpeed;

			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B224", Offset = "0xB3B224")]
			public float stepSpeed;

			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B25C", Offset = "0xB3B25C")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B294", Offset = "0xB3B294")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B2CC", Offset = "0xB3B2CC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B2CC", Offset = "0xB3B2CC")]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B324", Offset = "0xB3B324")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B35C", Offset = "0xB3B35C")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B394", Offset = "0xB3B394")]
			public Vector3 offset;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B40C", Offset = "0xB3B40C")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B444", Offset = "0xB3B444")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3B47C", Offset = "0xB3B47C")]
			private Vector3 <centerOfMass>k__BackingField;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private int leftFootIndex;

			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			private int rightFootIndex;

			[Token(Token = "0x170000A6")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000674")]
				[Address(RVA = "0x1BA5D98", Offset = "0x1BA5D98", VA = "0x1BA5D98")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3E0", Offset = "0xB3F3E0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000675")]
				[Address(RVA = "0x1BA5DA4", Offset = "0x1BA5DA4", VA = "0x1BA5DA4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F3F0", Offset = "0xB3F3F0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x600067B")]
				[Address(RVA = "0x1BA61E4", Offset = "0x1BA61E4", VA = "0x1BA61E4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A8")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x600067C")]
				[Address(RVA = "0x1BA6224", Offset = "0x1BA6224", VA = "0x1BA6224")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000A9")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600067D")]
				[Address(RVA = "0x1BA6268", Offset = "0x1BA6268", VA = "0x1BA6268")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000AA")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600067E")]
				[Address(RVA = "0x1BA62A8", Offset = "0x1BA62A8", VA = "0x1BA62A8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1B9DB00", Offset = "0x1B9DB00", VA = "0x1B9DB00")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes)
			{
			}

			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1B9BB30", Offset = "0x1B9BB30", VA = "0x1B9BB30")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000678")]
			[Address(RVA = "0x1B9AF80", Offset = "0x1B9AF80", VA = "0x1B9AF80")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1B9ADD0", Offset = "0x1B9ADD0", VA = "0x1B9ADD0")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x600067A")]
			[Address(RVA = "0x1B9E264", Offset = "0x1B9E264", VA = "0x1B9E264")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1BA5DF0", Offset = "0x1BA5DF0", VA = "0x1BA5DF0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1BA5F94", Offset = "0x1BA5F94", VA = "0x1BA5F94")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1BA6018", Offset = "0x1BA6018", VA = "0x1BA6018")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1BA179C", Offset = "0x1BA179C", VA = "0x1BA179C")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E3")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B48C", Offset = "0xB3B48C")]
			public Transform headTarget;

			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B4C4", Offset = "0xB3B4C4")]
			public Transform pelvisTarget;

			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B4FC", Offset = "0xB3B4FC")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B4FC", Offset = "0xB3B4FC")]
			public float positionWeight;

			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B550", Offset = "0xB3B550")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B550", Offset = "0xB3B550")]
			public float rotationWeight;

			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B5A4", Offset = "0xB3B5A4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B5A4", Offset = "0xB3B5A4")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B5F8", Offset = "0xB3B5F8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B5F8", Offset = "0xB3B5F8")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B64C", Offset = "0xB3B64C")]
			public float minHeadHeight;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B684", Offset = "0xB3B684")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B684", Offset = "0xB3B684")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B6D8", Offset = "0xB3B6D8")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B6D8", Offset = "0xB3B6D8")]
			public float bodyRotStiffness;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B72C", Offset = "0xB3B72C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B72C", Offset = "0xB3B72C")]
			public float chestRotationWeight;

			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B780", Offset = "0xB3B780")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B780", Offset = "0xB3B780")]
			public float chestClampWeight;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B7D4", Offset = "0xB3B7D4")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B7D4", Offset = "0xB3B7D4")]
			public float headClampWeight;

			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B828", Offset = "0xB3B828")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B828", Offset = "0xB3B828")]
			public float maintainPelvisPosition;

			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B87C", Offset = "0xB3B87C")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3B87C", Offset = "0xB3B87C")]
			public float maxRootAngle;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			[HideInInspector]
			public Vector3 faceDirection;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3B984", Offset = "0xB3B984")]
			private Quaternion <anchorRotation>k__BackingField;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			private Vector3 headPosition;

			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Quaternion headRotation;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
			private Quaternion anchorRelativeToHead;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000669")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x400066A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x400066B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x400066C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x400066D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
			private int pelvisIndex;

			[Token(Token = "0x400066E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private int spineIndex;

			[Token(Token = "0x400066F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
			private int chestIndex;

			[Token(Token = "0x4000670")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
			private int neckIndex;

			[Token(Token = "0x4000671")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
			private int headIndex;

			[Token(Token = "0x4000672")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private float length;

			[Token(Token = "0x4000673")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
			private bool hasChest;

			[Token(Token = "0x4000674")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C1")]
			private bool hasNeck;

			[Token(Token = "0x4000675")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
			private float headHeight;

			[Token(Token = "0x4000676")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
			private float sizeMlp;

			[Token(Token = "0x170000AB")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000683")]
				[Address(RVA = "0x1B9BDA4", Offset = "0x1B9BDA4", VA = "0x1B9BDA4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AC")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000684")]
				[Address(RVA = "0x1BA62EC", Offset = "0x1BA62EC", VA = "0x1BA62EC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AD")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000685")]
				[Address(RVA = "0x1B9FAD8", Offset = "0x1B9FAD8", VA = "0x1B9FAD8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AE")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000686")]
				[Address(RVA = "0x1BA632C", Offset = "0x1BA632C", VA = "0x1BA632C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000AF")]
			public VirtualBone head
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x1BA5DB0", Offset = "0x1BA5DB0", VA = "0x1BA5DB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B0")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000688")]
				[Address(RVA = "0x1BA636C", Offset = "0x1BA636C", VA = "0x1BA636C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F400", Offset = "0xB3F400")]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x1BA6380", Offset = "0x1BA6380", VA = "0x1BA6380")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F410", Offset = "0xB3F410")]
				private set
				{
				}
			}

			[Token(Token = "0x600068A")]
			[Address(RVA = "0x1BA6394", Offset = "0x1BA6394", VA = "0x1BA6394", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600068B")]
			[Address(RVA = "0x1BA6D30", Offset = "0x1BA6D30", VA = "0x1BA6D30", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600068C")]
			[Address(RVA = "0x1BA6EBC", Offset = "0x1BA6EBC", VA = "0x1BA6EBC", Slot = "7")]
			public override void ApplyOffsets()
			{
			}

			[Token(Token = "0x600068D")]
			[Address(RVA = "0x1BA73E0", Offset = "0x1BA73E0", VA = "0x1BA73E0")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600068E")]
			[Address(RVA = "0x1B9DDF8", Offset = "0x1B9DDF8", VA = "0x1B9DDF8")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms)
			{
			}

			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1BA83A0", Offset = "0x1BA83A0", VA = "0x1BA83A0")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1BA8740", Offset = "0x1BA8740", VA = "0x1BA8740", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000691")]
			[Address(RVA = "0x1BA891C", Offset = "0x1BA891C", VA = "0x1BA891C", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000692")]
			[Address(RVA = "0x1BA794C", Offset = "0x1BA794C", VA = "0x1BA794C")]
			private void AdjustChestByOffset(ref Quaternion chestTargetRotation)
			{
			}

			[Token(Token = "0x6000693")]
			[Address(RVA = "0x1BA7620", Offset = "0x1BA7620", VA = "0x1BA7620")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000694")]
			[Address(RVA = "0x1B9F764", Offset = "0x1B9F764", VA = "0x1B9F764")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000695")]
			[Address(RVA = "0x1BA7A18", Offset = "0x1BA7A18", VA = "0x1BA7A18")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation)
			{
			}

			[Token(Token = "0x6000696")]
			[Address(RVA = "0x1BA8A04", Offset = "0x1BA8A04", VA = "0x1BA8A04")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000697")]
			[Address(RVA = "0x1BA8154", Offset = "0x1BA8154", VA = "0x1BA8154")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000698")]
			[Address(RVA = "0x1BA1544", Offset = "0x1BA1544", VA = "0x1BA1544")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E4")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000678")]
			Pelvis,
			[Token(Token = "0x4000679")]
			Chest,
			[Token(Token = "0x400067A")]
			Head,
			[Token(Token = "0x400067B")]
			LeftHand,
			[Token(Token = "0x400067C")]
			RightHand,
			[Token(Token = "0x400067D")]
			LeftFoot,
			[Token(Token = "0x400067E")]
			RightFoot,
			[Token(Token = "0x400067F")]
			LeftHeel,
			[Token(Token = "0x4000680")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x20000E5")]
		public enum RotationOffset
		{
			[Token(Token = "0x4000682")]
			Pelvis,
			[Token(Token = "0x4000683")]
			Chest,
			[Token(Token = "0x4000684")]
			Head
		}

		[Serializable]
		[Token(Token = "0x20000E6")]
		public class VirtualBone
		{
			[Token(Token = "0x4000685")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000686")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000687")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000688")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000689")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x400068A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x400068B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000699")]
			[Address(RVA = "0x1B9DA64", Offset = "0x1B9DA64", VA = "0x1B9DA64")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069A")]
			[Address(RVA = "0x1B9DAE0", Offset = "0x1B9DAE0", VA = "0x1B9DAE0")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069B")]
			[Address(RVA = "0x1BA8D24", Offset = "0x1BA8D24", VA = "0x1BA8D24")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1BA3764", Offset = "0x1BA3764", VA = "0x1BA3764")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600069D")]
			[Address(RVA = "0x1BA3C64", Offset = "0x1BA3C64", VA = "0x1BA3C64")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069E")]
			[Address(RVA = "0x1BA8FB4", Offset = "0x1BA8FB4", VA = "0x1BA8FB4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600069F")]
			[Address(RVA = "0x1BA246C", Offset = "0x1BA246C", VA = "0x1BA246C")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x1BA91EC", Offset = "0x1BA91EC", VA = "0x1BA91EC")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x1BA2CBC", Offset = "0x1BA2CBC", VA = "0x1BA2CBC")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x1BA92A4", Offset = "0x1BA92A4", VA = "0x1BA92A4")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x1BA7DA0", Offset = "0x1BA7DA0", VA = "0x1BA7DA0")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length)
			{
			}

			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x1BA94BC", Offset = "0x1BA94BC", VA = "0x1BA94BC")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x1BA95C4", Offset = "0x1BA95C4", VA = "0x1BA95C4")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPelvisLocalPosition;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Vector3 rootV;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 rootVelocity;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 bodyOffset;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int supportLegIndex;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3948C", Offset = "0xB3948C")]
		public bool plantFeet;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB394C4", Offset = "0xB394C4")]
		private VirtualBone <rootBone>k__BackingField;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB394D4", Offset = "0xB394D4")]
		public Spine spine;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3950C", Offset = "0xB3950C")]
		public Arm leftArm;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39544", Offset = "0xB39544")]
		public Arm rightArm;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3957C", Offset = "0xB3957C")]
		public Leg leftLeg;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB395B4", Offset = "0xB395B4")]
		public Leg rightLeg;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB395EC", Offset = "0xB395EC")]
		public Locomotion locomotion;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x17000057")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1BA139C", Offset = "0x1BA139C", VA = "0x1BA139C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E384", Offset = "0xB3E384")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x1BA13A4", Offset = "0x1BA13A4", VA = "0x1BA13A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E394", Offset = "0xB3E394")]
			private set
			{
			}
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1B99994", Offset = "0x1B99994", VA = "0x1B99994")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1B99D88", Offset = "0x1B99D88", VA = "0x1B99D88")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x1B99C30", Offset = "0x1B99C30", VA = "0x1B99C30")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1B9A76C", Offset = "0x1B9A76C", VA = "0x1B9A76C")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1B9AA48", Offset = "0x1B9AA48", VA = "0x1B9AA48")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1B9AAEC", Offset = "0x1B9AAEC", VA = "0x1B9AAEC")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1B9AC4C", Offset = "0x1B9AC4C", VA = "0x1B9AC4C")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1B9B358", Offset = "0x1B9B358", VA = "0x1B9B358")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x1B9BDE4", Offset = "0x1B9BDE4", VA = "0x1B9BDE4", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x1B9BF28", Offset = "0x1B9BF28", VA = "0x1B9BF28", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1B9C06C", Offset = "0x1B9C06C", VA = "0x1B9C06C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1B9C0E0", Offset = "0x1B9C0E0", VA = "0x1B9C0E0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1B9C154", Offset = "0x1B9C154", VA = "0x1B9C154", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1B9C368", Offset = "0x1B9C368", VA = "0x1B9C368")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x1B9A020", Offset = "0x1B9A020", VA = "0x1B9A020")]
		private Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1B9A1F8", Offset = "0x1B9A1F8", VA = "0x1B9A1F8")]
		private Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1B9A648", Offset = "0x1B9A648", VA = "0x1B9A648")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1B9B4B4", Offset = "0x1B9B4B4", VA = "0x1B9B4B4")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1B9C648", Offset = "0x1B9C648", VA = "0x1B9C648", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x1B9C680", Offset = "0x1B9C680", VA = "0x1B9C680", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1B9D788", Offset = "0x1B9D788", VA = "0x1B9D788")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1B9B61C", Offset = "0x1B9B61C", VA = "0x1B9B61C")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1B9C6E0", Offset = "0x1B9C6E0", VA = "0x1B9C6E0")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1B9D960", Offset = "0x1B9D960", VA = "0x1B9D960")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1B9DA20", Offset = "0x1B9DA20", VA = "0x1B9DA20")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1B9D640", Offset = "0x1B9D640", VA = "0x1B9D640")]
		private void Write()
		{
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1BA0DB4", Offset = "0x1BA0DB4", VA = "0x1BA0DB4")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1BA13AC", Offset = "0x1BA13AC", VA = "0x1BA13AC")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x2000091")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39624", Offset = "0xB39624")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39624", Offset = "0xB39624")]
		public float weight;

		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39678", Offset = "0xB39678")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39678", Offset = "0xB39678")]
		public float parentChildCrossfade;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 twistAxis;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 axis;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform parent;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform child;

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1D78F28", Offset = "0x1D78F28", VA = "0x1D78F28")]
		public void Relax()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1D79284", Offset = "0x1D79284", VA = "0x1D79284")]
		private void Start()
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1D79560", Offset = "0x1D79560", VA = "0x1D79560")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1D79564", Offset = "0x1D79564", VA = "0x1D79564")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000092")]
	public class InteractionEffector
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB396CC", Offset = "0xB396CC")]
		private FullBodyBipedEffector <effectorType>k__BackingField;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB396DC", Offset = "0xB396DC")]
		private bool <isPaused>k__BackingField;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB396EC", Offset = "0xB396EC")]
		private InteractionObject <interactionObject>k__BackingField;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float resetTimer;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private bool positionWeightUsed;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
		private bool rotationWeightUsed;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
		private bool pullUsed;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
		private bool reachUsed;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool pushUsed;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool pushParentUsed;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pickedUp;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool defaults;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Transform target;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<bool> triggered;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool started;

		[Token(Token = "0x17000058")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x1BA9DEC", Offset = "0x1BA9DEC", VA = "0x1BA9DEC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3A4", Offset = "0xB3E3A4")]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x1BA9DF4", Offset = "0x1BA9DF4", VA = "0x1BA9DF4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3B4", Offset = "0xB3E3B4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public bool isPaused
		{
			[Token(Token = "0x600045F")]
			[Address(RVA = "0x1BA9DFC", Offset = "0x1BA9DFC", VA = "0x1BA9DFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3C4", Offset = "0xB3E3C4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000460")]
			[Address(RVA = "0x1BA9E04", Offset = "0x1BA9E04", VA = "0x1BA9E04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3D4", Offset = "0xB3E3D4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1BA9E10", Offset = "0x1BA9E10", VA = "0x1BA9E10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3E4", Offset = "0xB3E3E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x1BA9E18", Offset = "0x1BA9E18", VA = "0x1BA9E18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E3F4", Offset = "0xB3E3F4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005B")]
		public bool inInteraction
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0x1BA9E20", Offset = "0x1BA9E20", VA = "0x1BA9E20")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public float progress
		{
			[Token(Token = "0x600046C")]
			[Address(RVA = "0x1BABF54", Offset = "0x1BABF54", VA = "0x1BABF54")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1BA9E90", Offset = "0x1BA9E90", VA = "0x1BA9E90")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1BA9F14", Offset = "0x1BA9F14", VA = "0x1BA9F14")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1BA9FB8", Offset = "0x1BA9FB8", VA = "0x1BA9FB8")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1BAA0F8", Offset = "0x1BAA0F8", VA = "0x1BAA0F8")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1BAA504", Offset = "0x1BAA504", VA = "0x1BAA504")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1BAA638", Offset = "0x1BAA638", VA = "0x1BAA638")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1BAA690", Offset = "0x1BAA690", VA = "0x1BAA690")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1BAACA4", Offset = "0x1BAACA4", VA = "0x1BAACA4")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1BAB78C", Offset = "0x1BAB78C", VA = "0x1BAB78C")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1BAB9BC", Offset = "0x1BAB9BC", VA = "0x1BAB9BC")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x1BABDF8", Offset = "0x1BABDF8", VA = "0x1BABDF8")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x1BAC020", Offset = "0x1BAC020", VA = "0x1BAC020")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000093")]
	public class InteractionLookAt
	{
		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB396FC", Offset = "0xB396FC")]
		public LookAtIK ik;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39734", Offset = "0xB39734")]
		public float lerpSpeed;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3976C", Offset = "0xB3976C")]
		public float weightSpeed;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x4000464")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x4000465")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x1BAC284", Offset = "0x1BAC284", VA = "0x1BAC284")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x1BAC3FC", Offset = "0x1BAC3FC", VA = "0x1BAC3FC")]
		public void Update()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x1BAC640", Offset = "0x1BAC640", VA = "0x1BAC640")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1BAC738", Offset = "0x1BAC738", VA = "0x1BAC738")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1BAC804", Offset = "0x1BAC804", VA = "0x1BAC804")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB36004", Offset = "0xB36004")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB36004", Offset = "0xB36004")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E7")]
		public class InteractionEvent
		{
			[Token(Token = "0x400068C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B994", Offset = "0xB3B994")]
			public float time;

			[Token(Token = "0x400068D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3B9CC", Offset = "0xB3B9CC")]
			public bool pause;

			[Token(Token = "0x400068E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BA04", Offset = "0xB3BA04")]
			public bool pickUp;

			[Token(Token = "0x400068F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BA3C", Offset = "0xB3BA3C")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x4000690")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BA74", Offset = "0xB3BA74")]
			public Message[] messages;

			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x1D6AAA8", Offset = "0x1D6AAA8", VA = "0x1D6AAA8")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60006A7")]
			[Address(RVA = "0x1D6AC58", Offset = "0x1D6AC58", VA = "0x1D6AC58")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E8")]
		public class Message
		{
			[Token(Token = "0x4000691")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BAAC", Offset = "0xB3BAAC")]
			public string function;

			[Token(Token = "0x4000692")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BAE4", Offset = "0xB3BAE4")]
			public GameObject recipient;

			[Token(Token = "0x4000693")]
			private const string empty = "";

			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1D6AB68", Offset = "0x1D6AB68", VA = "0x1D6AB68")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1D6AC60", Offset = "0x1D6AC60", VA = "0x1D6AC60")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E9")]
		public class AnimatorEvent
		{
			[Token(Token = "0x4000694")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BB1C", Offset = "0xB3BB1C")]
			public Animator animator;

			[Token(Token = "0x4000695")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BB54", Offset = "0xB3BB54")]
			public Animation animation;

			[Token(Token = "0x4000696")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BB8C", Offset = "0xB3BB8C")]
			public string animationState;

			[Token(Token = "0x4000697")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BBC4", Offset = "0xB3BBC4")]
			public float crossfadeTime;

			[Token(Token = "0x4000698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BBFC", Offset = "0xB3BBFC")]
			public int layer;

			[Token(Token = "0x4000699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BC34", Offset = "0xB3BC34")]
			public bool resetNormalizedTime;

			[Token(Token = "0x400069A")]
			private const string empty = "";

			[Token(Token = "0x60006AA")]
			[Address(RVA = "0x1D6A808", Offset = "0x1D6A808", VA = "0x1D6A808")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60006AB")]
			[Address(RVA = "0x1D6A8FC", Offset = "0x1D6A8FC", VA = "0x1D6A8FC")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60006AC")]
			[Address(RVA = "0x1D6A9B4", Offset = "0x1D6A9B4", VA = "0x1D6A9B4")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x1D6AA94", Offset = "0x1D6AA94", VA = "0x1D6AA94")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EA")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x2000109")]
			public enum Type
			{
				[Token(Token = "0x400072A")]
				PositionWeight,
				[Token(Token = "0x400072B")]
				RotationWeight,
				[Token(Token = "0x400072C")]
				PositionOffsetX,
				[Token(Token = "0x400072D")]
				PositionOffsetY,
				[Token(Token = "0x400072E")]
				PositionOffsetZ,
				[Token(Token = "0x400072F")]
				Pull,
				[Token(Token = "0x4000730")]
				Reach,
				[Token(Token = "0x4000731")]
				RotateBoneWeight,
				[Token(Token = "0x4000732")]
				Push,
				[Token(Token = "0x4000733")]
				PushParent,
				[Token(Token = "0x4000734")]
				PoserWeight
			}

			[Token(Token = "0x400069B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BC6C", Offset = "0xB3BC6C")]
			public Type type;

			[Token(Token = "0x400069C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BCA4", Offset = "0xB3BCA4")]
			public AnimationCurve curve;

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1D6ACA4", Offset = "0x1D6ACA4", VA = "0x1D6ACA4")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1D6ACD0", Offset = "0x1D6ACD0", VA = "0x1D6ACD0")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class Multiplier
		{
			[Token(Token = "0x400069D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BCDC", Offset = "0xB3BCDC")]
			public WeightCurve.Type curve;

			[Token(Token = "0x400069E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BD14", Offset = "0xB3BD14")]
			public float multiplier;

			[Token(Token = "0x400069F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BD4C", Offset = "0xB3BD4C")]
			public WeightCurve.Type result;

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1D6AC68", Offset = "0x1D6AC68", VA = "0x1D6AC68")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60006B1")]
			[Address(RVA = "0x1D6ACC0", Offset = "0x1D6ACC0", VA = "0x1D6ACC0")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000466")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB397B4", Offset = "0xB397B4")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x4000467")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB397EC", Offset = "0xB397EC")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39824", Offset = "0xB39824")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x400046C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3985C", Offset = "0xB3985C")]
		private float <length>k__BackingField;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3986C", Offset = "0xB3986C")]
		private InteractionSystem <lastUsedInteractionSystem>k__BackingField;

		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x1700005D")]
		public float length
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x1BAC9E0", Offset = "0x1BAC9E0", VA = "0x1BAC9E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E554", Offset = "0xB3E554")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x1BAC9E8", Offset = "0x1BAC9E8", VA = "0x1BAC9E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E564", Offset = "0xB3E564")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x1BAC9F0", Offset = "0x1BAC9F0", VA = "0x1BAC9F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E574", Offset = "0xB3E574")]
			get
			{
				return null;
			}
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x1BAC9F8", Offset = "0x1BAC9F8", VA = "0x1BAC9F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E584", Offset = "0xB3E584")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x1BACC14", Offset = "0x1BACC14", VA = "0x1BACC14")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000060")]
		public Transform targetsRoot
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x1BABF90", Offset = "0x1BABF90", VA = "0x1BABF90")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1BAC818", Offset = "0x1BAC818", VA = "0x1BAC818")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E404", Offset = "0xB3E404")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1BAC864", Offset = "0x1BAC864", VA = "0x1BAC864")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E43C", Offset = "0xB3E43C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x1BAC8B0", Offset = "0x1BAC8B0", VA = "0x1BAC8B0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E474", Offset = "0xB3E474")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x1BAC8FC", Offset = "0x1BAC8FC", VA = "0x1BAC8FC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E4AC", Offset = "0xB3E4AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x1BAC948", Offset = "0x1BAC948", VA = "0x1BAC948")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E4E4", Offset = "0xB3E4E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x1BAC994", Offset = "0x1BAC994", VA = "0x1BAC994")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E51C", Offset = "0xB3E51C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x1BACA00", Offset = "0x1BACA00", VA = "0x1BACA00")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x1BACCA4", Offset = "0x1BACCA4", VA = "0x1BACCA4")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x1BAABF0", Offset = "0x1BAABF0", VA = "0x1BAABF0")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x1BACE28", Offset = "0x1BACE28", VA = "0x1BACE28")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x1BAAAA4", Offset = "0x1BAAAA4", VA = "0x1BAAAA4")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x1BAABE8", Offset = "0x1BAABE8", VA = "0x1BAABE8")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1BAB36C", Offset = "0x1BAB36C", VA = "0x1BAB36C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x1BABBCC", Offset = "0x1BABBCC", VA = "0x1BABBCC")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1BAD4E8", Offset = "0x1BAD4E8", VA = "0x1BAD4E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1BACEA0", Offset = "0x1BACEA0", VA = "0x1BACEA0")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x1BACE30", Offset = "0x1BACE30", VA = "0x1BACE30")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1BAD480", Offset = "0x1BAD480", VA = "0x1BAD480")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1BAD4EC", Offset = "0x1BAD4EC", VA = "0x1BAD4EC")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x1BAD554", Offset = "0x1BAD554", VA = "0x1BAD554")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E594", Offset = "0xB3E594")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x1BAD5A0", Offset = "0x1BAD5A0", VA = "0x1BAD5A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E5CC", Offset = "0xB3E5CC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x1BAD5EC", Offset = "0x1BAD5EC", VA = "0x1BAD5EC")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB36064", Offset = "0xB36064")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB36064", Offset = "0xB36064")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000EC")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000ED")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3987C", Offset = "0xB3987C")]
		public string targetTag;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB398B4", Offset = "0xB398B4")]
		public float fadeInTime;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB398EC", Offset = "0xB398EC")]
		public float speed;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39924", Offset = "0xB39924")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xB3995C", Offset = "0xB3995C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3995C", Offset = "0xB3995C")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB3995C", Offset = "0xB3995C")]
		public Collider characterCollider;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB399E0", Offset = "0xB399E0")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xB399E0", Offset = "0xB399E0")]
		public Transform FPSCamera;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39A40", Offset = "0xB39A40")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39A78", Offset = "0xB39A78")]
		public float camRaycastDistance;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB39AB0", Offset = "0xB39AB0")]
		private List<InteractionTrigger> <triggersInRange>k__BackingField;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB39AC0", Offset = "0xB39AC0")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39AC0", Offset = "0xB39AC0")]
		[SerializeField]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39B20", Offset = "0xB39B20")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool initiated;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x17000061")]
		public bool inInteraction
		{
			[Token(Token = "0x6000498")]
			[Address(RVA = "0x1D6AEA0", Offset = "0x1D6AEA0", VA = "0x1D6AEA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000062")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x1D6CB68", Offset = "0x1D6CB68", VA = "0x1D6CB68")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0x1D6CB70", Offset = "0x1D6CB70", VA = "0x1D6CB70")]
			set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x60004B4")]
			[Address(RVA = "0x1D6CB78", Offset = "0x1D6CB78", VA = "0x1D6CB78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E754", Offset = "0xB3E754")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0x1D6CB80", Offset = "0x1D6CB80", VA = "0x1D6CB80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3E764", Offset = "0xB3E764")]
			private set
			{
			}
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x1D6ACD8", Offset = "0x1D6ACD8", VA = "0x1D6ACD8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E604", Offset = "0xB3E604")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x1D6AD24", Offset = "0x1D6AD24", VA = "0x1D6AD24")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E63C", Offset = "0xB3E63C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x1D6AD70", Offset = "0x1D6AD70", VA = "0x1D6AD70")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E674", Offset = "0xB3E674")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x1D6ADBC", Offset = "0x1D6ADBC", VA = "0x1D6ADBC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E6AC", Offset = "0xB3E6AC")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x1D6AE08", Offset = "0x1D6AE08", VA = "0x1D6AE08")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E6E4", Offset = "0xB3E6E4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x1D6AE54", Offset = "0x1D6AE54", VA = "0x1D6AE54")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E71C", Offset = "0xB3E71C")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x1D6B030", Offset = "0x1D6B030", VA = "0x1D6B030")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x1D6B100", Offset = "0x1D6B100", VA = "0x1D6B100")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x1D6B1D0", Offset = "0x1D6B1D0", VA = "0x1D6B1D0")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1D6B280", Offset = "0x1D6B280", VA = "0x1D6B280")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1D6B37C", Offset = "0x1D6B37C", VA = "0x1D6B37C")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x1D6B49C", Offset = "0x1D6B49C", VA = "0x1D6B49C")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x1D6B530", Offset = "0x1D6B530", VA = "0x1D6B530")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x1D6B5C4", Offset = "0x1D6B5C4", VA = "0x1D6B5C4")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x1D6B658", Offset = "0x1D6B658", VA = "0x1D6B658")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x1D6B6D0", Offset = "0x1D6B6D0", VA = "0x1D6B6D0")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x1D6B748", Offset = "0x1D6B748", VA = "0x1D6B748")]
		public void StopAll()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x1D6B7B4", Offset = "0x1D6B7B4", VA = "0x1D6B7B4")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x1D6B840", Offset = "0x1D6B840", VA = "0x1D6B840")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1D6B8D4", Offset = "0x1D6B8D4", VA = "0x1D6B8D4")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1D6B9A0", Offset = "0x1D6B9A0", VA = "0x1D6B9A0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1D6BC40", Offset = "0x1D6BC40", VA = "0x1D6BC40")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x1D6BE18", Offset = "0x1D6BE18", VA = "0x1D6BE18")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x1D6C090", Offset = "0x1D6C090", VA = "0x1D6C090")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x1D6C384", Offset = "0x1D6C384", VA = "0x1D6C384")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x1D6C3C8", Offset = "0x1D6C3C8", VA = "0x1D6C3C8")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x1D6C444", Offset = "0x1D6C444", VA = "0x1D6C444")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x1D6C564", Offset = "0x1D6C564", VA = "0x1D6C564")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x1D6C6E0", Offset = "0x1D6C6E0", VA = "0x1D6C6E0")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x1D6C988", Offset = "0x1D6C988", VA = "0x1D6C988")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x1D6C190", Offset = "0x1D6C190", VA = "0x1D6C190")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1D6CB88", Offset = "0x1D6CB88", VA = "0x1D6CB88", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1D6D1DC", Offset = "0x1D6D1DC", VA = "0x1D6D1DC")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1D6D1FC", Offset = "0x1D6D1FC", VA = "0x1D6D1FC")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1D6D218", Offset = "0x1D6D218", VA = "0x1D6D218")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1D6D234", Offset = "0x1D6D234", VA = "0x1D6D234")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1D6D29C", Offset = "0x1D6D29C", VA = "0x1D6D29C")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1D6D3B8", Offset = "0x1D6D3B8", VA = "0x1D6D3B8")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1D6D4B4", Offset = "0x1D6D4B4", VA = "0x1D6D4B4")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1D6D80C", Offset = "0x1D6D80C", VA = "0x1D6D80C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1D6D8F8", Offset = "0x1D6D8F8", VA = "0x1D6D8F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1D6DB48", Offset = "0x1D6DB48", VA = "0x1D6DB48")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1D6CF54", Offset = "0x1D6CF54", VA = "0x1D6CF54")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1D6DC88", Offset = "0x1D6DC88", VA = "0x1D6DC88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x1D6DDBC", Offset = "0x1D6DDBC", VA = "0x1D6DDBC")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x1D6DE60", Offset = "0x1D6DE60", VA = "0x1D6DE60")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x1D6DF50", Offset = "0x1D6DF50", VA = "0x1D6DF50")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x1D6AF50", Offset = "0x1D6AF50", VA = "0x1D6AF50")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1D6BB40", Offset = "0x1D6BB40", VA = "0x1D6BB40")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1D6E1E0", Offset = "0x1D6E1E0", VA = "0x1D6E1E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E774", Offset = "0xB3E774")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1D6E22C", Offset = "0x1D6E22C", VA = "0x1D6E22C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E7AC", Offset = "0xB3E7AC")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1D6E278", Offset = "0x1D6E278", VA = "0x1D6E278")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB360C4", Offset = "0xB360C4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB360C4", Offset = "0xB360C4")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EE")]
		public class Multiplier
		{
			[Token(Token = "0x40006A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BD84", Offset = "0xB3BD84")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x40006A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BDBC", Offset = "0xB3BDBC")]
			public float multiplier;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1D6F728", Offset = "0x1D6F728", VA = "0x1D6F728")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39B58", Offset = "0xB39B58")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39B90", Offset = "0xB39B90")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39BC8", Offset = "0xB39BC8")]
		public float interactionSpeedMlp;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39C00", Offset = "0xB39C00")]
		public Transform pivot;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39C38", Offset = "0xB39C38")]
		public Vector3 twistAxis;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39C70", Offset = "0xB39C70")]
		public float twistWeight;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39CA8", Offset = "0xB39CA8")]
		public float swingWeight;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39CE0", Offset = "0xB39CE0")]
		public bool rotateOnce;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform lastPivot;

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1D6EC84", Offset = "0x1D6EC84", VA = "0x1D6EC84")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E7E4", Offset = "0xB3E7E4")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1D6ECD0", Offset = "0x1D6ECD0", VA = "0x1D6ECD0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E81C", Offset = "0xB3E81C")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1D6ED1C", Offset = "0x1D6ED1C", VA = "0x1D6ED1C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E854", Offset = "0xB3E854")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1D6ED68", Offset = "0x1D6ED68", VA = "0x1D6ED68")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E88C", Offset = "0xB3E88C")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x1D6EDB4", Offset = "0x1D6EDB4", VA = "0x1D6EDB4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E8C4", Offset = "0xB3E8C4")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x1D6EE00", Offset = "0x1D6EE00", VA = "0x1D6EE00")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E8FC", Offset = "0xB3E8FC")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1D6EE4C", Offset = "0x1D6EE4C", VA = "0x1D6EE4C")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x1D6EEBC", Offset = "0x1D6EEBC", VA = "0x1D6EEBC")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1D6EF58", Offset = "0x1D6EF58", VA = "0x1D6EF58")]
		public void RotateTo(Vector3 position)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1D6F604", Offset = "0x1D6F604", VA = "0x1D6F604")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E934", Offset = "0xB3E934")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1D6F650", Offset = "0x1D6F650", VA = "0x1D6F650")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E96C", Offset = "0xB3E96C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1D6F69C", Offset = "0x1D6F69C", VA = "0x1D6F69C")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB36124", Offset = "0xB36124")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB36124", Offset = "0xB36124")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000EF")]
		public class CharacterPosition
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BDF4", Offset = "0xB3BDF4")]
			public bool use;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BE2C", Offset = "0xB3BE2C")]
			public Vector2 offset;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BE64", Offset = "0xB3BE64")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3BE64", Offset = "0xB3BE64")]
			public float angleOffset;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BEC0", Offset = "0xB3BEC0")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3BEC0", Offset = "0xB3BEC0")]
			public float maxAngle;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BF18", Offset = "0xB3BF18")]
			public float radius;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BF50", Offset = "0xB3BF50")]
			public bool orbit;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BF88", Offset = "0xB3BF88")]
			public bool fixYAxis;

			[Token(Token = "0x170000B1")]
			public Vector3 offset3D
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1D6FEB0", Offset = "0x1D6FEB0", VA = "0x1D6FEB0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B2")]
			public Vector3 direction3D
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x1D6FEEC", Offset = "0x1D6FEEC", VA = "0x1D6FEEC")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1D6FFE4", Offset = "0x1D6FFE4", VA = "0x1D6FFE4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1D70660", Offset = "0x1D70660", VA = "0x1D70660")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F0")]
		public class CameraPosition
		{
			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BFC0", Offset = "0xB3BFC0")]
			public Collider lookAtTarget;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3BFF8", Offset = "0xB3BFF8")]
			public Vector3 direction;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C030", Offset = "0xB3C030")]
			public float maxDistance;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C068", Offset = "0xB3C068")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3C068", Offset = "0xB3C068")]
			public float maxAngle;

			[Token(Token = "0x40006AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C0C0", Offset = "0xB3C0C0")]
			public bool fixYAxis;

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1D6F99C", Offset = "0x1D6F99C", VA = "0x1D6F99C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1D6FB44", Offset = "0x1D6FB44", VA = "0x1D6FB44")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x1D6FE24", Offset = "0x1D6FE24", VA = "0x1D6FE24")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x200010A")]
			public class Interaction
			{
				[Token(Token = "0x4000735")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CC58", Offset = "0xB3CC58")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000736")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CC90", Offset = "0xB3CC90")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000726")]
				[Address(RVA = "0x1D70684", Offset = "0x1D70684", VA = "0x1D70684")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			[SerializeField]
			public string name;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			[SerializeField]
			public bool show;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C168", Offset = "0xB3C168")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C1A0", Offset = "0xB3C1A0")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C1D8", Offset = "0xB3C1D8")]
			public Interaction[] interactions;

			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1D6F818", Offset = "0x1D6F818", VA = "0x1D6F818")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1D70674", Offset = "0x1D70674", VA = "0x1D70674")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39D18", Offset = "0xB39D18")]
		public Range[] ranges;

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1D6F730", Offset = "0x1D6F730", VA = "0x1D6F730")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E9A4", Offset = "0xB3E9A4")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1D6F77C", Offset = "0x1D6F77C", VA = "0x1D6F77C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3E9DC", Offset = "0xB3E9DC")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1D6F7C8", Offset = "0x1D6F7C8", VA = "0x1D6F7C8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EA14", Offset = "0xB3EA14")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1D6F814", Offset = "0x1D6F814", VA = "0x1D6F814")]
		private void Start()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1D6D654", Offset = "0x1D6D654", VA = "0x1D6D654")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1D6F93C", Offset = "0x1D6F93C", VA = "0x1D6F93C")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000F2")]
		public class Map
		{
			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x16BDB4C", Offset = "0x16BDB4C", VA = "0x16BDB4C")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x16BDF50", Offset = "0x16BDF50", VA = "0x16BDF50")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x16BDF04", Offset = "0x16BDF04", VA = "0x16BDF04")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x16BDCFC", Offset = "0x16BDCFC", VA = "0x16BDCFC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x16BD864", Offset = "0x16BD864", VA = "0x16BD864", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EA4C", Offset = "0xB3EA4C")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x16BDBF0", Offset = "0x16BDBF0", VA = "0x16BDBF0", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x16BDBF4", Offset = "0x16BDBF4", VA = "0x16BDBF4", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x16BDE9C", Offset = "0x16BDE9C", VA = "0x16BDE9C", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x16BDB88", Offset = "0x16BDB88", VA = "0x16BDB88")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x16BDAAC", Offset = "0x16BDAAC", VA = "0x16BDAAC")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x16BDFA0", Offset = "0x16BDFA0", VA = "0x16BDFA0")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x2000099")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform _poseRoot;

		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] children;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1C7A094", Offset = "0x1C7A094", VA = "0x1C7A094", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1C7A14C", Offset = "0x1C7A14C", VA = "0x1C7A14C", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1C7A304", Offset = "0x1C7A304", VA = "0x1C7A304", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1C7A400", Offset = "0x1C7A400", VA = "0x1C7A400", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1C7A1A8", Offset = "0x1C7A1A8", VA = "0x1C7A1A8")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1C7A7B0", Offset = "0x1C7A7B0", VA = "0x1C7A7B0")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39D50", Offset = "0xB39D50")]
		public float weight;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39D68", Offset = "0xB39D68")]
		public float localRotationWeight;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39D80", Offset = "0xB39D80")]
		public float localPositionWeight;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x60004EA")]
		public abstract void AutoMapping();

		[Token(Token = "0x60004EB")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x60004EC")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x60004ED")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1D71E60", Offset = "0x1D71E60", VA = "0x1D71E60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1D71EB4", Offset = "0x1D71EB4", VA = "0x1D71EB4", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1D71EF0", Offset = "0x1D71EF0", VA = "0x1D71EF0", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1D71F08", Offset = "0x1D71F08", VA = "0x1D71F08")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xB36184", Offset = "0xB36184")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000F3")]
		public class Rigidbone
		{
			[Token(Token = "0x40006B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x40006B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x40006B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x40006BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x40006BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x40006BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1D724A4", Offset = "0x1D724A4", VA = "0x1D724A4")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x1D730B0", Offset = "0x1D730B0", VA = "0x1D730B0")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1D72E94", Offset = "0x1D72E94", VA = "0x1D72E94")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000F4")]
		public class Child
		{
			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1D72600", Offset = "0x1D72600", VA = "0x1D72600")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x1D73248", Offset = "0x1D73248", VA = "0x1D73248")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x1D731F8", Offset = "0x1D731F8", VA = "0x1D731F8")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000F5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363E8", Offset = "0xB363E8")]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x170000B3")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D1")]
				[Address(RVA = "0x1D73828", Offset = "0x1D73828", VA = "0x1D73828", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000B4")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x1D73890", Offset = "0x1D73890", VA = "0x1D73890", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x1D72660", Offset = "0x1D72660", VA = "0x1D72660")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x1D735E0", Offset = "0x1D735E0", VA = "0x1D735E0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1D735E4", Offset = "0x1D735E4", VA = "0x1D735E4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1D73830", Offset = "0x1D73830", VA = "0x1D73830", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39D98", Offset = "0xB39D98")]
		public IK ik;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39DD0", Offset = "0xB39DD0")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39E08", Offset = "0xB39E08")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39E40", Offset = "0xB39E40")]
		public float applyVelocity;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB39E78", Offset = "0xB39E78")]
		public float applyAngularVelocity;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000064")]
		private bool isRagdoll
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0x1D71F68", Offset = "0x1D71F68", VA = "0x1D71F68")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000065")]
		private bool ikUsed
		{
			[Token(Token = "0x60004FF")]
			[Address(RVA = "0x1D72A4C", Offset = "0x1D72A4C", VA = "0x1D72A4C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1D71F30", Offset = "0x1D71F30", VA = "0x1D71F30")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1D71FE0", Offset = "0x1D71FE0", VA = "0x1D71FE0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1D72110", Offset = "0x1D72110", VA = "0x1D72110")]
		public void Start()
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1D720A0", Offset = "0x1D720A0", VA = "0x1D720A0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3EA84", Offset = "0xB3EA84")]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1D7268C", Offset = "0x1D7268C", VA = "0x1D7268C")]
		private void Update()
		{
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1D728D8", Offset = "0x1D728D8", VA = "0x1D728D8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1D72990", Offset = "0x1D72990", VA = "0x1D72990")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1D72BD0", Offset = "0x1D72BD0", VA = "0x1D72BD0")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1D72A10", Offset = "0x1D72A10", VA = "0x1D72A10")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1D72B8C", Offset = "0x1D72B8C", VA = "0x1D72B8C")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1D72C6C", Offset = "0x1D72C6C", VA = "0x1D72C6C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1D72C04", Offset = "0x1D72C04", VA = "0x1D72C04")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x1D72038", Offset = "0x1D72038", VA = "0x1D72038")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1D72918", Offset = "0x1D72918", VA = "0x1D72918")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1D73410", Offset = "0x1D73410", VA = "0x1D73410")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1D73514", Offset = "0x1D73514", VA = "0x1D73514")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x200009C")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool initiated;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool applicationQuit;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000066")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x6000508")]
			[Address(RVA = "0x1D7520C", Offset = "0x1D7520C", VA = "0x1D7520C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000067")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1D75248", Offset = "0x1D75248", VA = "0x1D75248")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1D74E94", Offset = "0x1D74E94", VA = "0x1D74E94")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1D74ED8", Offset = "0x1D74ED8", VA = "0x1D74ED8")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x1D75164", Offset = "0x1D75164", VA = "0x1D75164")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1D751D4", Offset = "0x1D751D4", VA = "0x1D751D4")]
		public void Disable()
		{
		}

		[Token(Token = "0x600050A")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1D75074", Offset = "0x1D75074", VA = "0x1D75074")]
		private void Awake()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1D75318", Offset = "0x1D75318", VA = "0x1D75318")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1D7531C", Offset = "0x1D7531C", VA = "0x1D7531C")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1D7534C", Offset = "0x1D7534C", VA = "0x1D7534C")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1D75430", Offset = "0x1D75430", VA = "0x1D75430")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1D756AC", Offset = "0x1D756AC", VA = "0x1D756AC")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1D75768", Offset = "0x1D75768", VA = "0x1D75768")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB361E8", Offset = "0xB361E8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB361E8", Offset = "0xB361E8")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39EC0", Offset = "0xB39EC0")]
		public float limit;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39EDC", Offset = "0xB39EDC")]
		public float twistLimit;

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1D757E0", Offset = "0x1D757E0", VA = "0x1D757E0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EAE8", Offset = "0xB3EAE8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1D7582C", Offset = "0x1D7582C", VA = "0x1D7582C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EB20", Offset = "0xB3EB20")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1D75878", Offset = "0x1D75878", VA = "0x1D75878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EB58", Offset = "0xB3EB58")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1D758C4", Offset = "0x1D758C4", VA = "0x1D758C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EB90", Offset = "0xB3EB90")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1D75910", Offset = "0x1D75910", VA = "0x1D75910", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1D759C8", Offset = "0x1D759C8", VA = "0x1D759C8")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1D75C10", Offset = "0x1D75C10", VA = "0x1D75C10")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB36248", Offset = "0xB36248")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB36248", Offset = "0xB36248")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		public bool useLimits;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float min;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float max;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Quaternion lastRotation;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float lastAngle;

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1D75C20", Offset = "0x1D75C20", VA = "0x1D75C20")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EBC8", Offset = "0xB3EBC8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1D75C6C", Offset = "0x1D75C6C", VA = "0x1D75C6C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EC00", Offset = "0xB3EC00")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1D75CB8", Offset = "0x1D75CB8", VA = "0x1D75CB8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EC38", Offset = "0xB3EC38")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1D75D04", Offset = "0x1D75D04", VA = "0x1D75D04")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EC70", Offset = "0xB3EC70")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1D75D50", Offset = "0x1D75D50", VA = "0x1D75D50", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1D75D78", Offset = "0x1D75D78", VA = "0x1D75D78")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1D76078", Offset = "0x1D76078", VA = "0x1D76078")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB362A8", Offset = "0xB362A8")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB362A8", Offset = "0xB362A8")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public class ReachCone
		{
			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x170000B5")]
			public Vector3 o
			{
				[Token(Token = "0x60006D4")]
				[Address(RVA = "0x1D78014", Offset = "0x1D78014", VA = "0x1D78014")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B6")]
			public Vector3 a
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x1D7804C", Offset = "0x1D7804C", VA = "0x1D7804C")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B7")]
			public Vector3 b
			{
				[Token(Token = "0x60006D6")]
				[Address(RVA = "0x1D78088", Offset = "0x1D78088", VA = "0x1D78088")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B8")]
			public Vector3 c
			{
				[Token(Token = "0x60006D7")]
				[Address(RVA = "0x1D780C4", Offset = "0x1D780C4", VA = "0x1D780C4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000B9")]
			public bool isValid
			{
				[Token(Token = "0x60006D9")]
				[Address(RVA = "0x1D77178", Offset = "0x1D77178", VA = "0x1D77178")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x1D777C4", Offset = "0x1D777C4", VA = "0x1D777C4")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x1D77924", Offset = "0x1D77924", VA = "0x1D77924")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class LimitPoint
		{
			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x1D77188", Offset = "0x1D77188", VA = "0x1D77188")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39F08", Offset = "0xB39F08")]
		public float twistLimit;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39F24", Offset = "0xB39F24")]
		public int smoothIterations;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1D76100", Offset = "0x1D76100", VA = "0x1D76100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3ECA8", Offset = "0xB3ECA8")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1D7614C", Offset = "0x1D7614C", VA = "0x1D7614C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3ECE0", Offset = "0xB3ECE0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1D76198", Offset = "0x1D76198", VA = "0x1D76198")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3ED18", Offset = "0xB3ED18")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1D761E4", Offset = "0x1D761E4", VA = "0x1D761E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3ED50", Offset = "0xB3ED50")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1D76230", Offset = "0x1D76230", VA = "0x1D76230")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1D76714", Offset = "0x1D76714", VA = "0x1D76714", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1D7680C", Offset = "0x1D7680C", VA = "0x1D7680C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1D76DC4", Offset = "0x1D76DC4", VA = "0x1D76DC4")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1D762CC", Offset = "0x1D762CC", VA = "0x1D762CC")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1D7720C", Offset = "0x1D7720C", VA = "0x1D7720C")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1D77AE4", Offset = "0x1D77AE4", VA = "0x1D77AE4")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1D77B28", Offset = "0x1D77B28", VA = "0x1D77B28")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1D77C70", Offset = "0x1D77C70", VA = "0x1D77C70")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1D76A8C", Offset = "0x1D76A8C", VA = "0x1D76A8C")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1D77E00", Offset = "0x1D77E00", VA = "0x1D77E00")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0x1D77FB0", Offset = "0x1D77FB0", VA = "0x1D77FB0")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	[AttributeAttribute(Name = "HelpURLAttribute", RVA = "0xB36308", Offset = "0xB36308")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xB36308", Offset = "0xB36308")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB39FE4", Offset = "0xB39FE4")]
		public float twistLimit;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x6000530")]
		[Address(RVA = "0x1D78100", Offset = "0x1D78100", VA = "0x1D78100")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3ED88", Offset = "0xB3ED88")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000531")]
		[Address(RVA = "0x1D7814C", Offset = "0x1D7814C", VA = "0x1D7814C")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EDC0", Offset = "0xB3EDC0")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0x1D78198", Offset = "0x1D78198", VA = "0x1D78198")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EDF8", Offset = "0xB3EDF8")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000533")]
		[Address(RVA = "0x1D781E4", Offset = "0x1D781E4", VA = "0x1D781E4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0xB3EE30", Offset = "0xB3EE30")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1D78230", Offset = "0x1D78230", VA = "0x1D78230")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0x1D7824C", Offset = "0x1D7824C", VA = "0x1D7824C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0x1D78304", Offset = "0x1D78304", VA = "0x1D78304")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1D78630", Offset = "0x1D78630", VA = "0x1D78630")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000A1")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F8")]
		public class Pose
		{
			[Token(Token = "0x40006CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40006CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x16B24F0", Offset = "0x16B24F0", VA = "0x16B24F0")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x16B285C", Offset = "0x16B285C", VA = "0x16B285C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x16B2864", Offset = "0x16B2864", VA = "0x16B2864")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x16B2414", Offset = "0x16B2414", VA = "0x16B2414")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x16B2788", Offset = "0x16B2788", VA = "0x16B2788")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x16B27F4", Offset = "0x16B27F4", VA = "0x16B27F4")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000A2")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000F9")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x200010B")]
			public class EffectorLink
			{
				[Token(Token = "0x4000737")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CCC8", Offset = "0xB3CCC8")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000738")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CD00", Offset = "0xB3CD00")]
				public float weight;

				[Token(Token = "0x6000727")]
				[Address(RVA = "0x16B2E54", Offset = "0x16B2E54", VA = "0x16B2E54")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C210", Offset = "0xB3C210")]
			public Transform transform;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C248", Offset = "0xB3C248")]
			public Transform relativeTo;

			[Token(Token = "0x40006D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C280", Offset = "0xB3C280")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C2B8", Offset = "0xB3C2B8")]
			public float verticalWeight;

			[Token(Token = "0x40006D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C2F0", Offset = "0xB3C2F0")]
			public float horizontalWeight;

			[Token(Token = "0x40006D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C328", Offset = "0xB3C328")]
			public float speed;

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x16B29C0", Offset = "0x16B29C0", VA = "0x16B29C0")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x16B2E2C", Offset = "0x16B2E2C", VA = "0x16B2E2C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x16B2E3C", Offset = "0x16B2E3C", VA = "0x16B2E3C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A038", Offset = "0xB3A038")]
		public Body[] bodies;

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x16B2880", Offset = "0x16B2880", VA = "0x16B2880", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x16B2E24", Offset = "0x16B2E24", VA = "0x16B2E24")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000A3")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A070", Offset = "0xB3A070")]
		public float tiltSpeed;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A0A8", Offset = "0xB3A0A8")]
		public float tiltSensitivity;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A0E0", Offset = "0xB3A0E0")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A118", Offset = "0xB3A118")]
		public OffsetPose poseRight;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x16B4130", Offset = "0x16B4130", VA = "0x16B4130", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x16B4178", Offset = "0x16B4178", VA = "0x16B4178", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x16B43A8", Offset = "0x16B43A8", VA = "0x16B43A8")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000A4")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FA")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C360", Offset = "0xB3C360")]
			public string name;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C398", Offset = "0xB3C398")]
			public Collider collider;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C3D0", Offset = "0xB3C3D0")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C41C", Offset = "0xB3C41C")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C42C", Offset = "0xB3C42C")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40006E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C43C", Offset = "0xB3C43C")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40006E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C44C", Offset = "0xB3C44C")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BA")]
			protected float crossFader
			{
				[Token(Token = "0x60006E2")]
				[Address(RVA = "0x1C7AD4C", Offset = "0x1C7AD4C", VA = "0x1C7AD4C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F470", Offset = "0xB3F470")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E3")]
				[Address(RVA = "0x1C7AD54", Offset = "0x1C7AD54", VA = "0x1C7AD54")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F480", Offset = "0xB3F480")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BB")]
			protected float timer
			{
				[Token(Token = "0x60006E4")]
				[Address(RVA = "0x1C7AD5C", Offset = "0x1C7AD5C", VA = "0x1C7AD5C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F490", Offset = "0xB3F490")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006E5")]
				[Address(RVA = "0x1C7AD64", Offset = "0x1C7AD64", VA = "0x1C7AD64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4A0", Offset = "0xB3F4A0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BC")]
			protected Vector3 force
			{
				[Token(Token = "0x60006E6")]
				[Address(RVA = "0x1C7AD6C", Offset = "0x1C7AD6C", VA = "0x1C7AD6C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4B0", Offset = "0xB3F4B0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E7")]
				[Address(RVA = "0x1C7AD78", Offset = "0x1C7AD78", VA = "0x1C7AD78")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4C0", Offset = "0xB3F4C0")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BD")]
			protected Vector3 point
			{
				[Token(Token = "0x60006E8")]
				[Address(RVA = "0x1C7AD84", Offset = "0x1C7AD84", VA = "0x1C7AD84")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4D0", Offset = "0xB3F4D0")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006E9")]
				[Address(RVA = "0x1C7AD90", Offset = "0x1C7AD90", VA = "0x1C7AD90")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4E0", Offset = "0xB3F4E0")]
				private set
				{
				}
			}

			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1C7AC18", Offset = "0x1C7AC18", VA = "0x1C7AC18")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x60006EB")]
			[Address(RVA = "0x1C7A88C", Offset = "0x1C7A88C", VA = "0x1C7A88C")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006EC")]
			protected abstract float GetLength();

			[Token(Token = "0x60006ED")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x60006EE")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x60006EF")]
			[Address(RVA = "0x1C7AD9C", Offset = "0x1C7AD9C", VA = "0x1C7AD9C")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FB")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200010C")]
			public class EffectorLink
			{
				[Token(Token = "0x4000739")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CD38", Offset = "0xB3CD38")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400073A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CD70", Offset = "0xB3CD70")]
				public float weight;

				[Token(Token = "0x400073B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x400073C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x6000728")]
				[Address(RVA = "0x1C7B708", Offset = "0x1C7B708", VA = "0x1C7B708")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x6000729")]
				[Address(RVA = "0x1C7B4FC", Offset = "0x1C7B4FC", VA = "0x1C7B4FC")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600072A")]
				[Address(RVA = "0x1C7B980", Offset = "0x1C7B980", VA = "0x1C7B980")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C45C", Offset = "0xB3C45C")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40006E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C494", Offset = "0xB3C494")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40006E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C4CC", Offset = "0xB3C4CC")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x60006F0")]
			[Address(RVA = "0x1C7B318", Offset = "0x1C7B318", VA = "0x1C7B318", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F1")]
			[Address(RVA = "0x1C7B490", Offset = "0x1C7B490", VA = "0x1C7B490", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1C7B510", Offset = "0x1C7B510", VA = "0x1C7B510", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F3")]
			[Address(RVA = "0x1C7B82C", Offset = "0x1C7B82C", VA = "0x1C7B82C")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FC")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x200010D")]
			public class BoneLink
			{
				[Token(Token = "0x400073D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CDA8", Offset = "0xB3CDA8")]
				public Transform bone;

				[Token(Token = "0x400073E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CDE0", Offset = "0xB3CDE0")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CDE0", Offset = "0xB3CDE0")]
				public float weight;

				[Token(Token = "0x400073F")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x4000740")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x600072B")]
				[Address(RVA = "0x1C7B120", Offset = "0x1C7B120", VA = "0x1C7B120")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x600072C")]
				[Address(RVA = "0x1C7AEB8", Offset = "0x1C7AEB8", VA = "0x1C7AEB8")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600072D")]
				[Address(RVA = "0x1C7B290", Offset = "0x1C7B290", VA = "0x1C7B290")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40006EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C504", Offset = "0xB3C504")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C53C", Offset = "0xB3C53C")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x60006F4")]
			[Address(RVA = "0x1C7ADB0", Offset = "0x1C7ADB0", VA = "0x1C7ADB0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x60006F5")]
			[Address(RVA = "0x1C7AE54", Offset = "0x1C7AE54", VA = "0x1C7AE54", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x1C7AEC4", Offset = "0x1C7AEC4", VA = "0x1C7AEC4", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x60006F7")]
			[Address(RVA = "0x1C7B27C", Offset = "0x1C7B27C", VA = "0x1C7B27C")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A150", Offset = "0xB3A150")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A188", Offset = "0xB3A188")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1C7A7B8", Offset = "0x1C7A7B8", VA = "0x1C7A7B8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1C7A9D8", Offset = "0x1C7A9D8", VA = "0x1C7A9D8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1C7AD44", Offset = "0x1C7AD44", VA = "0x1C7AD44")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public abstract class Offset
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C574", Offset = "0xB3C574")]
			public string name;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C5AC", Offset = "0xB3C5AC")]
			public Collider collider;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C5E4", Offset = "0xB3C5E4")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C630", Offset = "0xB3C630")]
			private float <crossFader>k__BackingField;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C640", Offset = "0xB3C640")]
			private float <timer>k__BackingField;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C650", Offset = "0xB3C650")]
			private Vector3 <force>k__BackingField;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3C660", Offset = "0xB3C660")]
			private Vector3 <point>k__BackingField;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x170000BE")]
			protected float crossFader
			{
				[Token(Token = "0x60006F8")]
				[Address(RVA = "0x1C7BF38", Offset = "0x1C7BF38", VA = "0x1C7BF38")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F4F0", Offset = "0xB3F4F0")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006F9")]
				[Address(RVA = "0x1C7BF40", Offset = "0x1C7BF40", VA = "0x1C7BF40")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F500", Offset = "0xB3F500")]
				private set
				{
				}
			}

			[Token(Token = "0x170000BF")]
			protected float timer
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1C7BF48", Offset = "0x1C7BF48", VA = "0x1C7BF48")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F510", Offset = "0xB3F510")]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1C7BF50", Offset = "0x1C7BF50", VA = "0x1C7BF50")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F520", Offset = "0xB3F520")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C0")]
			protected Vector3 force
			{
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x1C7BF58", Offset = "0x1C7BF58", VA = "0x1C7BF58")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F530", Offset = "0xB3F530")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x1C7BF64", Offset = "0x1C7BF64", VA = "0x1C7BF64")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F540", Offset = "0xB3F540")]
				private set
				{
				}
			}

			[Token(Token = "0x170000C1")]
			protected Vector3 point
			{
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x1C7BF70", Offset = "0x1C7BF70", VA = "0x1C7BF70")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F550", Offset = "0xB3F550")]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x1C7BF7C", Offset = "0x1C7BF7C", VA = "0x1C7BF7C")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB3F560", Offset = "0xB3F560")]
				private set
				{
				}
			}

			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1C7BDF0", Offset = "0x1C7BDF0", VA = "0x1C7BDF0")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1C7BA54", Offset = "0x1C7BA54", VA = "0x1C7BA54")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000702")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000703")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000704")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1C7BF88", Offset = "0x1C7BF88", VA = "0x1C7BF88")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200010E")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x4000741")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CE34", Offset = "0xB3CE34")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x4000742")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CE6C", Offset = "0xB3CE6C")]
				public float weight;

				[Token(Token = "0x4000743")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x4000744")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600072E")]
				[Address(RVA = "0x1C7C444", Offset = "0x1C7C444", VA = "0x1C7C444")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600072F")]
				[Address(RVA = "0x1C7C200", Offset = "0x1C7C200", VA = "0x1C7C200")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000730")]
				[Address(RVA = "0x1C7C560", Offset = "0x1C7C560", VA = "0x1C7C560")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C670", Offset = "0xB3C670")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C6A8", Offset = "0xB3C6A8")]
			public int upDirCurveIndex;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C6E0", Offset = "0xB3C6E0")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1C7BF9C", Offset = "0x1C7BF9C", VA = "0x1C7BF9C", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1C7C194", Offset = "0x1C7C194", VA = "0x1C7C194", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1C7C214", Offset = "0x1C7C214", VA = "0x1C7C214", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1C7C544", Offset = "0x1C7C544", VA = "0x1C7C544")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FF")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x200010F")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x4000745")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CEA4", Offset = "0xB3CEA4")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x4000746")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CEDC", Offset = "0xB3CEDC")]
				[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CEDC", Offset = "0xB3CEDC")]
				public float weight;

				[Token(Token = "0x4000747")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x4000748")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000731")]
				[Address(RVA = "0x1C7C9C8", Offset = "0x1C7C9C8", VA = "0x1C7C9C8")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000732")]
				[Address(RVA = "0x1C7C6B0", Offset = "0x1C7C6B0", VA = "0x1C7C6B0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000733")]
				[Address(RVA = "0x1C7CB04", Offset = "0x1C7CB04", VA = "0x1C7CB04")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C718", Offset = "0xB3C718")]
			public int curveIndex;

			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C750", Offset = "0xB3C750")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x1C7C568", Offset = "0x1C7C568", VA = "0x1C7C568", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x1C7C64C", Offset = "0x1C7C64C", VA = "0x1C7C64C", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x1C7C6BC", Offset = "0x1C7C6BC", VA = "0x1C7C6BC", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600070D")]
			[Address(RVA = "0x1C7CAF0", Offset = "0x1C7CAF0", VA = "0x1C7CAF0")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A1C0", Offset = "0xB3A1C0")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A1F8", Offset = "0xB3A1F8")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x1C7B988", Offset = "0x1C7B988", VA = "0x1C7B988", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x1C7BBA8", Offset = "0x1C7BBA8", VA = "0x1C7BBA8")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x1C7BF30", Offset = "0x1C7BF30", VA = "0x1C7BF30")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000A6")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000100")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x2000110")]
			public class EffectorLink
			{
				[Token(Token = "0x4000749")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CF30", Offset = "0xB3CF30")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400074A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CF68", Offset = "0xB3CF68")]
				public float weight;

				[Token(Token = "0x6000734")]
				[Address(RVA = "0x1BA9DE4", Offset = "0x1BA9DE4", VA = "0x1BA9DE4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C788", Offset = "0xB3C788")]
			public Transform transform;

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C7C0", Offset = "0xB3C7C0")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C7F8", Offset = "0xB3C7F8")]
			public float speed;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C830", Offset = "0xB3C830")]
			public float acceleration;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C868", Offset = "0xB3C868")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3C868", Offset = "0xB3C868")]
			public float matchVelocity;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C8BC", Offset = "0xB3C8BC")]
			public float gravity;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x600070E")]
			[Address(RVA = "0x1BA98B0", Offset = "0x1BA98B0", VA = "0x1BA98B0")]
			public void Reset()
			{
			}

			[Token(Token = "0x600070F")]
			[Address(RVA = "0x1BA9A48", Offset = "0x1BA9A48", VA = "0x1BA9A48")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x1BA9DC8", Offset = "0x1BA9DC8", VA = "0x1BA9DC8")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A230", Offset = "0xB3A230")]
		public Body[] bodies;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A268", Offset = "0xB3A268")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x1BA9838", Offset = "0x1BA9838", VA = "0x1BA9838")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x1BA998C", Offset = "0x1BA998C", VA = "0x1BA998C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x1BA9DC0", Offset = "0x1BA9DC0", VA = "0x1BA9DC0")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000101")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C8F4", Offset = "0xB3C8F4")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C92C", Offset = "0xB3C92C")]
			public float spring;

			[Token(Token = "0x400070A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C964", Offset = "0xB3C964")]
			public bool x;

			[Token(Token = "0x400070B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C99C", Offset = "0xB3C99C")]
			public bool y;

			[Token(Token = "0x400070C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3C9D4", Offset = "0xB3C9D4")]
			public bool z;

			[Token(Token = "0x400070D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CA0C", Offset = "0xB3CA0C")]
			public float minX;

			[Token(Token = "0x400070E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CA44", Offset = "0xB3CA44")]
			public float maxX;

			[Token(Token = "0x400070F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CA7C", Offset = "0xB3CA7C")]
			public float minY;

			[Token(Token = "0x4000710")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CAB4", Offset = "0xB3CAB4")]
			public float maxY;

			[Token(Token = "0x4000711")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CAEC", Offset = "0xB3CAEC")]
			public float minZ;

			[Token(Token = "0x4000712")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CB24", Offset = "0xB3CB24")]
			public float maxZ;

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1D70E68", Offset = "0x1D70E68", VA = "0x1D70E68")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x1D71380", Offset = "0x1D71380", VA = "0x1D71380")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1D713B0", Offset = "0x1D713B0", VA = "0x1D713B0")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x6000714")]
			[Address(RVA = "0x1D71488", Offset = "0x1D71488", VA = "0x1D71488")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x2000102")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB363F8", Offset = "0xB363F8")]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000713")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000714")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000715")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x170000C2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000718")]
				[Address(RVA = "0x1D71310", Offset = "0x1D71310", VA = "0x1D71310", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x1D71378", Offset = "0x1D71378", VA = "0x1D71378", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000715")]
			[Address(RVA = "0x1D70C74", Offset = "0x1D70C74", VA = "0x1D70C74")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000716")]
			[Address(RVA = "0x1D711D0", Offset = "0x1D711D0", VA = "0x1D711D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000717")]
			[Address(RVA = "0x1D711D4", Offset = "0x1D711D4", VA = "0x1D711D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000719")]
			[Address(RVA = "0x1D71318", Offset = "0x1D71318", VA = "0x1D71318", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A2A0", Offset = "0xB3A2A0")]
		public float weight;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A2D8", Offset = "0xB3A2D8")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x17000068")]
		protected float deltaTime
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1D70BAC", Offset = "0x1D70BAC", VA = "0x1D70BAC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600054A")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x1D70BD8", Offset = "0x1D70BD8", VA = "0x1D70BD8", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x1D70C04", Offset = "0x1D70C04", VA = "0x1D70C04")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3EE68", Offset = "0xB3EE68")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1D70CA0", Offset = "0x1D70CA0", VA = "0x1D70CA0")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x1D70DAC", Offset = "0x1D70DAC", VA = "0x1D70DAC")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1D710C8", Offset = "0x1D710C8", VA = "0x1D710C8", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1D711C0", Offset = "0x1D711C0", VA = "0x1D711C0")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x2000103")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xB36408", Offset = "0xB36408")]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000716")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000717")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000718")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x170000C4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x1D718D8", Offset = "0x1D718D8", VA = "0x1D718D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000C5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x1D71940", Offset = "0x1D71940", VA = "0x1D71940", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600071B")]
			[Address(RVA = "0x1D71558", Offset = "0x1D71558", VA = "0x1D71558")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600071C")]
			[Address(RVA = "0x1D71798", Offset = "0x1D71798", VA = "0x1D71798", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600071D")]
			[Address(RVA = "0x1D7179C", Offset = "0x1D7179C", VA = "0x1D7179C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600071F")]
			[Address(RVA = "0x1D718E0", Offset = "0x1D718E0", VA = "0x1D718E0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A310", Offset = "0xB3A310")]
		public float weight;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A348", Offset = "0xB3A348")]
		public VRIK ik;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000069")]
		protected float deltaTime
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x1D71490", Offset = "0x1D71490", VA = "0x1D71490")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000552")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1D714BC", Offset = "0x1D714BC", VA = "0x1D714BC", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x1D714E8", Offset = "0x1D714E8", VA = "0x1D714E8")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xB3EECC", Offset = "0xB3EECC")]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x1D71584", Offset = "0x1D71584", VA = "0x1D71584")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x1D71690", Offset = "0x1D71690", VA = "0x1D71690", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x1D71788", Offset = "0x1D71788", VA = "0x1D71788")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000104")]
		public class EffectorLink
		{
			[Token(Token = "0x4000719")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x400071A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x400071B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400071C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000721")]
			[Address(RVA = "0x1D71A08", Offset = "0x1D71A08", VA = "0x1D71A08")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1D71E58", Offset = "0x1D71E58", VA = "0x1D71E58")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x1D71948", Offset = "0x1D71948", VA = "0x1D71948")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x1D71D40", Offset = "0x1D71D40", VA = "0x1D71D40")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x1D71DF8", Offset = "0x1D71DF8", VA = "0x1D71DF8")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000AA")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000105")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x2000111")]
			public class EffectorLink
			{
				[Token(Token = "0x400074B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CFA0", Offset = "0xB3CFA0")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400074C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CFD8", Offset = "0xB3CFD8")]
				public float weight;

				[Token(Token = "0x6000735")]
				[Address(RVA = "0x1D74E8C", Offset = "0x1D74E8C", VA = "0x1D74E8C")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400071D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CB5C", Offset = "0xB3CB5C")]
			public Vector3 offset;

			[Token(Token = "0x400071E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CB94", Offset = "0xB3CB94")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0xB3CB94", Offset = "0xB3CB94")]
			public float additivity;

			[Token(Token = "0x400071F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CBE8", Offset = "0xB3CBE8")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000720")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3CC20", Offset = "0xB3CC20")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000721")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1D73C14", Offset = "0x1D73C14", VA = "0x1D73C14")]
			public void Start()
			{
			}

			[Token(Token = "0x6000724")]
			[Address(RVA = "0x1D74764", Offset = "0x1D74764", VA = "0x1D74764")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x6000725")]
			[Address(RVA = "0x1D74E78", Offset = "0x1D74E78", VA = "0x1D74E78")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000106")]
		public enum Handedness
		{
			[Token(Token = "0x4000724")]
			Right,
			[Token(Token = "0x4000725")]
			Left
		}

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A380", Offset = "0xB3A380")]
		public AimIK aimIK;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A3B8", Offset = "0xB3A3B8")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A3F0", Offset = "0xB3A3F0")]
		public Handedness handedness;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A428", Offset = "0xB3A428")]
		public bool twoHanded;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A460", Offset = "0xB3A460")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A498", Offset = "0xB3A498")]
		public float magnitudeRandom;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A4D0", Offset = "0xB3A4D0")]
		public Vector3 rotationRandom;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A508", Offset = "0xB3A508")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A540", Offset = "0xB3A540")]
		public float blendTime;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xB3A578", Offset = "0xB3A578")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A578", Offset = "0xB3A578")]
		public RecoilOffset[] offsets;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x40004E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x40004E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x40004E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x40004E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x40004E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x40004E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x40004E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x40004EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x40004EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x40004EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x40004ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x40004EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x1700006A")]
		public bool isFinished
		{
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x1D739EC", Offset = "0x1D739EC", VA = "0x1D739EC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000561")]
			[Address(RVA = "0x1D74A18", Offset = "0x1D74A18", VA = "0x1D74A18")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000562")]
			[Address(RVA = "0x1D74A58", Offset = "0x1D74A58", VA = "0x1D74A58")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006D")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x1D749D8", Offset = "0x1D749D8", VA = "0x1D749D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x1D749F8", Offset = "0x1D749F8", VA = "0x1D749F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x1D73A1C", Offset = "0x1D73A1C", VA = "0x1D73A1C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x1D73A48", Offset = "0x1D73A48", VA = "0x1D73A48")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x1D73CC4", Offset = "0x1D73CC4", VA = "0x1D73CC4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x1D74A98", Offset = "0x1D74A98", VA = "0x1D74A98")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x1D74BF0", Offset = "0x1D74BF0", VA = "0x1D74BF0")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x1D74C2C", Offset = "0x1D74C2C", VA = "0x1D74C2C", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1D74DC4", Offset = "0x1D74DC4", VA = "0x1D74DC4")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x40004EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A5D8", Offset = "0xB3A5D8")]
		public float weight;

		[Token(Token = "0x40004F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xB3A610", Offset = "0xB3A610")]
		public float offset;

		[Token(Token = "0x40004F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40004F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1D7863C", Offset = "0x1D7863C", VA = "0x1D7863C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1D78710", Offset = "0x1D78710", VA = "0x1D78710")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1D787FC", Offset = "0x1D787FC", VA = "0x1D787FC")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1D78C44", Offset = "0x1D78C44", VA = "0x1D78C44")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x1D78C7C", Offset = "0x1D78C7C", VA = "0x1D78C7C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x1D78D74", Offset = "0x1D78D74", VA = "0x1D78D74")]
		public ShoulderRotator()
		{
		}
	}
}
