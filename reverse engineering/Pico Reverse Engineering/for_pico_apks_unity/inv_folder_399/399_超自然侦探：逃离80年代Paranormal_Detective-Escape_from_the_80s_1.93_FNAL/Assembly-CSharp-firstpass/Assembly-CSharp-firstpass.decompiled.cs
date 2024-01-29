using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace UnityStandardAssets.Vehicles.Car
{
	[Token(Token = "0x2000002")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x86A954", Offset = "0x86A954")]
	public class CarAudio : MonoBehaviour
	{
		[Token(Token = "0x2000003")]
		public enum EngineAudioOptions
		{
			[Token(Token = "0x4000014")]
			Simple,
			[Token(Token = "0x4000015")]
			FourChannel
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		public EngineAudioOptions engineSoundStyle;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip lowAccelClip;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip lowDecelClip;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip highAccelClip;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x38")]
		public AudioClip highDecelClip;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x40")]
		public float pitchMultiplier;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x44")]
		public float lowPitchMin;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x48")]
		public float lowPitchMax;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x4C")]
		public float highPitchMultiplier;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x50")]
		public float maxRolloffDistance;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x54")]
		public float dopplerLevel;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x58")]
		public bool useDoppler;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x60")]
		private AudioSource m_LowAccel;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x68")]
		private AudioSource m_LowDecel;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x70")]
		private AudioSource m_HighAccel;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x78")]
		private AudioSource m_HighDecel;

		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x80")]
		private bool m_StartedSound;

		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x88")]
		private CarController m_CarController;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1C89650", Offset = "0x1C89650", VA = "0x1C89650")]
		private void StartSound()
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1C89804", Offset = "0x1C89804", VA = "0x1C89804")]
		private void StopSound()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1C898EC", Offset = "0x1C898EC", VA = "0x1C898EC")]
		private void Update()
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1C896F8", Offset = "0x1C896F8", VA = "0x1C896F8")]
		private AudioSource SetUpEngineAudioSource(AudioClip clip)
		{
			return null;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1C89C34", Offset = "0x1C89C34", VA = "0x1C89C34")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1C89C4C", Offset = "0x1C89C4C", VA = "0x1C89C4C")]
		public CarAudio()
		{
		}
	}
	[Token(Token = "0x2000004")]
	internal enum CarDriveType
	{
		[Token(Token = "0x4000017")]
		FrontWheelDrive,
		[Token(Token = "0x4000018")]
		RearWheelDrive,
		[Token(Token = "0x4000019")]
		FourWheelDrive
	}
	[Token(Token = "0x2000005")]
	internal enum SpeedType
	{
		[Token(Token = "0x400001B")]
		MPH,
		[Token(Token = "0x400001C")]
		KPH
	}
	[Token(Token = "0x2000006")]
	public class CarController : MonoBehaviour
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarDriveType m_CarDriveType;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private WheelCollider[] m_WheelColliders;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] m_WheelMeshes;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private WheelEffects[] m_WheelEffects;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Vector3 m_CentreOfMassOffset;

		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float m_MaximumSteerAngle;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AAF4", Offset = "0x86AAF4")]
		[SerializeField]
		private float m_SteerHelper;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x86AB34", Offset = "0x86AB34")]
		[SerializeField]
		private float m_TractionControl;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float m_FullTorqueOverAllWheels;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float m_ReverseTorque;

		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float m_MaxHandbrakeTorque;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float m_Downforce;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SpeedType m_SpeedType;

		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float m_Topspeed;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private static int NoOfGears;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float m_RevRangeBoundary;

		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float m_SlipLimit;

		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float m_BrakeTorque;

		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x78")]
		private Quaternion[] m_WheelMeshLocalRotations;

		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_Prevpos;

		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 m_Pos;

		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x98")]
		private float m_SteerAngle;

		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x9C")]
		private int m_GearNum;

		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xA0")]
		private float m_GearFactor;

		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xA4")]
		private float m_OldRotation;

		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xA8")]
		private float m_CurrentTorque;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0xB0")]
		private Rigidbody m_Rigidbody;

		[Token(Token = "0x4000038")]
		private const float k_ReversingThreshold = 0.01f;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xB8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC14", Offset = "0x86AC14")]
		private bool <Skidding>k__BackingField;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC24", Offset = "0x86AC24")]
		private float <BrakeInput>k__BackingField;

		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0xC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC34", Offset = "0x86AC34")]
		private float <Revs>k__BackingField;

		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC44", Offset = "0x86AC44")]
		private float <AccelInput>k__BackingField;

		[Token(Token = "0x17000001")]
		public bool Skidding
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x1C89C78", Offset = "0x1C89C78", VA = "0x1C89C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC84", Offset = "0x86AC84")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x1C89C80", Offset = "0x1C89C80", VA = "0x1C89C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC94", Offset = "0x86AC94")]
			private set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public float BrakeInput
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x1C89C8C", Offset = "0x1C89C8C", VA = "0x1C89C8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACA4", Offset = "0x86ACA4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x1C89C94", Offset = "0x1C89C94", VA = "0x1C89C94")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACB4", Offset = "0x86ACB4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public float CurrentSteerAngle
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1C89C9C", Offset = "0x1C89C9C", VA = "0x1C89C9C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		public float CurrentSpeed
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x1C89CA4", Offset = "0x1C89CA4", VA = "0x1C89CA4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000005")]
		public float MaxSpeed
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1C89CF8", Offset = "0x1C89CF8", VA = "0x1C89CF8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000006")]
		public float Revs
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x1C89D00", Offset = "0x1C89D00", VA = "0x1C89D00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACC4", Offset = "0x86ACC4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x1C89D08", Offset = "0x1C89D08", VA = "0x1C89D08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACD4", Offset = "0x86ACD4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float AccelInput
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x1C89D10", Offset = "0x1C89D10", VA = "0x1C89D10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACE4", Offset = "0x86ACE4")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x1C89D18", Offset = "0x1C89D18", VA = "0x1C89D18")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ACF4", Offset = "0x86ACF4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x1C89D20", Offset = "0x1C89D20", VA = "0x1C89D20")]
		private void Start()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x1C89E74", Offset = "0x1C89E74", VA = "0x1C89E74")]
		private void GearChanging()
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1C89F84", Offset = "0x1C89F84", VA = "0x1C89F84")]
		private static float CurveFactor(float factor)
		{
			return default(float);
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1C89F98", Offset = "0x1C89F98", VA = "0x1C89F98")]
		private static float ULerp(float from, float to, float value)
		{
			return default(float);
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1C89FB0", Offset = "0x1C89FB0", VA = "0x1C89FB0")]
		private void CalculateGearFactor()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1C8A090", Offset = "0x1C8A090", VA = "0x1C8A090")]
		private void CalculateRevs()
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1C8A160", Offset = "0x1C8A160", VA = "0x1C8A160")]
		public void Move(float steering, float accel, float footbrake, float handbrake)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1C8A824", Offset = "0x1C8A824", VA = "0x1C8A824")]
		private void CapSpeed()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1C8A5B8", Offset = "0x1C8A5B8", VA = "0x1C8A5B8")]
		private void ApplyDrive(float accel, float footbrake)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1C8A3F0", Offset = "0x1C8A3F0", VA = "0x1C8A3F0")]
		private void SteerHelper()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1C8A8F8", Offset = "0x1C8A8F8", VA = "0x1C8A8F8")]
		private void AddDownForce()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1C8A9FC", Offset = "0x1C8A9FC", VA = "0x1C8A9FC")]
		private void CheckForWheelSpin()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1C8AB58", Offset = "0x1C8AB58", VA = "0x1C8AB58")]
		private void TractionControl()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1C8B078", Offset = "0x1C8B078", VA = "0x1C8B078")]
		private void AdjustTorque(float forwardSlip)
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1C8AED4", Offset = "0x1C8AED4", VA = "0x1C8AED4")]
		private bool AnySkidSoundPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1C8B0C0", Offset = "0x1C8B0C0", VA = "0x1C8B0C0")]
		public CarController()
		{
		}
	}
	[Token(Token = "0x2000007")]
	public class SkidTrail : MonoBehaviour
	{
		[Token(Token = "0x2000008")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86A9B4", Offset = "0x86A9B4")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400003E")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400003F")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000040")]
			[FieldOffset(Offset = "0x20")]
			public SkidTrail <>4__this;

			[Token(Token = "0x17000008")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x1C8B808", Offset = "0x1C8B808", VA = "0x1C8B808", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000009")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0x1C8B850", Offset = "0x1C8B850", VA = "0x1C8B850", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000025")]
			[Address(RVA = "0x1C8B3B0", Offset = "0x1C8B3B0", VA = "0x1C8B3B0")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000026")]
			[Address(RVA = "0x1C8B6D4", Offset = "0x1C8B6D4", VA = "0x1C8B6D4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000027")]
			[Address(RVA = "0x1C8B6D8", Offset = "0x1C8B6D8", VA = "0x1C8B6D8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000029")]
			[Address(RVA = "0x1C8B810", Offset = "0x1C8B810", VA = "0x1C8B810", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_PersistTime;

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1C8B344", Offset = "0x1C8B344", VA = "0x1C8B344")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x86AD04", Offset = "0x86AD04")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1C8B3DC", Offset = "0x1C8B3DC", VA = "0x1C8B3DC")]
		public SkidTrail()
		{
		}
	}
	[Token(Token = "0x2000009")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x86A9C4", Offset = "0x86A9C4")]
	public class WheelEffects : MonoBehaviour
	{
		[Token(Token = "0x200000A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AA24", Offset = "0x86AA24")]
		private sealed class <StartSkidTrail>d__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400004A")]
			[FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400004B")]
			[FieldOffset(Offset = "0x20")]
			public WheelEffects <>4__this;

			[Token(Token = "0x1700000C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x1C8B9EC", Offset = "0x1C8B9EC", VA = "0x1C8B9EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700000D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x1C8BA34", Offset = "0x1C8BA34", VA = "0x1C8BA34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000036")]
			[Address(RVA = "0x1C8B6A0", Offset = "0x1C8B6A0", VA = "0x1C8B6A0")]
			[DebuggerHidden]
			public <StartSkidTrail>d__18(int <>1__state)
			{
			}

			[Token(Token = "0x6000037")]
			[Address(RVA = "0x1C8B858", Offset = "0x1C8B858", VA = "0x1C8B858", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000038")]
			[Address(RVA = "0x1C8B85C", Offset = "0x1C8B85C", VA = "0x1C8B85C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600003A")]
			[Address(RVA = "0x1C8B9F4", Offset = "0x1C8B9F4", VA = "0x1C8B9F4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x18")]
		public Transform SkidTrailPrefab;

		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x0")]
		public static Transform skidTrailsDetachedParent;

		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x20")]
		public ParticleSystem skidParticles;

		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC64", Offset = "0x86AC64")]
		private bool <skidding>k__BackingField;

		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x29")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86AC74", Offset = "0x86AC74")]
		private bool <PlayingAudio>k__BackingField;

		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x30")]
		private AudioSource m_AudioSource;

		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0x38")]
		private Transform m_SkidTrail;

		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0x40")]
		private WheelCollider m_WheelCollider;

		[Token(Token = "0x1700000A")]
		public bool skidding
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x1C8B3E4", Offset = "0x1C8B3E4", VA = "0x1C8B3E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ADB4", Offset = "0x86ADB4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x1C8B3EC", Offset = "0x1C8B3EC", VA = "0x1C8B3EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ADC4", Offset = "0x86ADC4")]
			private set
			{
			}
		}

		[Token(Token = "0x1700000B")]
		public bool PlayingAudio
		{
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x1C8B3F8", Offset = "0x1C8B3F8", VA = "0x1C8B3F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ADD4", Offset = "0x86ADD4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x1C8B400", Offset = "0x1C8B400", VA = "0x1C8B400")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x86ADE4", Offset = "0x86ADE4")]
			private set
			{
			}
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x1C8B40C", Offset = "0x1C8B40C", VA = "0x1C8B40C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x1C8ADC0", Offset = "0x1C8ADC0", VA = "0x1C8ADC0")]
		public void EmitTyreSmoke()
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x1C8AF40", Offset = "0x1C8AF40", VA = "0x1C8AF40")]
		public void PlayAudio()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x1C8AF78", Offset = "0x1C8AF78", VA = "0x1C8AF78")]
		public void StopAudio()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x1C8B634", Offset = "0x1C8B634", VA = "0x1C8B634")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x86ADF4", Offset = "0x86ADF4")]
		public IEnumerator StartSkidTrail()
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x1C8AFAC", Offset = "0x1C8AFAC", VA = "0x1C8AFAC")]
		public void EndSkidTrail()
		{
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x1C8B6CC", Offset = "0x1C8B6CC", VA = "0x1C8B6CC")]
		public WheelEffects()
		{
		}
	}
}
namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200000B")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x86AA34", Offset = "0x86AA34")]
	public class FPSCounter : MonoBehaviour
	{
		[Token(Token = "0x400004C")]
		private const float fpsMeasurePeriod = 0.5f;

		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x18")]
		private int m_FpsAccumulator;

		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x1C")]
		private float m_FpsNextPeriod;

		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		private int m_CurrentFps;

		[Token(Token = "0x4000050")]
		private const string display = "{0} FPS";

		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x28")]
		private Text m_Text;

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x1C8B1D0", Offset = "0x1C8B1D0", VA = "0x1C8B1D0")]
		private void Start()
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x1C8B238", Offset = "0x1C8B238", VA = "0x1C8B238")]
		private void Update()
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x1C8B33C", Offset = "0x1C8B33C", VA = "0x1C8B33C")]
		public FPSCounter()
		{
		}
	}
}
