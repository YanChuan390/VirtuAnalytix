using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Photon.Pun;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Rendering;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Sigtrap.VrTunnellingPro
{
	[Token(Token = "0x2000002")]
	public class Tunnelling : TunnellingImageBase
	{
		[Token(Token = "0x17000001")]
		protected override CameraEvent _maskCmdEvt
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0xFE74E4", Offset = "0xFE74E4", VA = "0xFE74E4", Slot = "9")]
			get
			{
				return default(CameraEvent);
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0xFE74EC", Offset = "0xFE74EC", VA = "0xFE74EC")]
		private void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0xFE79B0", Offset = "0xFE79B0", VA = "0xFE79B0")]
		public Tunnelling()
		{
		}
	}
	[Token(Token = "0x2000003")]
	public abstract class TunnellingBase : MonoBehaviour
	{
		[Token(Token = "0x2000004")]
		public enum BackgroundMode
		{
			[Token(Token = "0x4000060")]
			COLOR,
			[Token(Token = "0x4000061")]
			SKYBOX,
			[Token(Token = "0x4000062")]
			CAGE_COLOR,
			[Token(Token = "0x4000063")]
			CAGE_SKYBOX,
			[Token(Token = "0x4000064")]
			CAGE_ONLY,
			[Token(Token = "0x4000065")]
			BLUR
		}

		[Token(Token = "0x2000005")]
		public enum MaskMode
		{
			[Token(Token = "0x4000067")]
			OFF,
			[Token(Token = "0x4000068")]
			MASK,
			[Token(Token = "0x4000069")]
			WINDOW,
			[Token(Token = "0x400006A")]
			PORTAL
		}

		[Token(Token = "0x2000006")]
		public enum MSAA
		{
			[Token(Token = "0x400006C")]
			AUTO,
			[Token(Token = "0x400006D")]
			OFF,
			[Token(Token = "0x400006E")]
			X2,
			[Token(Token = "0x400006F")]
			X4,
			[Token(Token = "0x4000070")]
			X8
		}

		[Token(Token = "0x2000007")]
		public enum ForceVignetteMode
		{
			[Token(Token = "0x4000072")]
			NONE = 0,
			[Token(Token = "0x4000073")]
			CONSTANT = 10,
			[Token(Token = "0x4000074")]
			MAX = 20,
			[Token(Token = "0x4000075")]
			MIN = 30,
			[Token(Token = "0x4000076")]
			ADD = 40
		}

		[Token(Token = "0x4000001")]
		public const string VRTP_VERSION = "1.4.0";

		[Token(Token = "0x4000002")]
		public const int VRTP_VERSION_MAJOR = 1;

		[Token(Token = "0x4000003")]
		public const int VRTP_VERSION_MINOR = 4;

		[Token(Token = "0x4000004")]
		public const int VRTP_VERSION_PATCH = 0;

		[Token(Token = "0x4000005")]
		public const string VRTP_VERSION_BETA = "";

		[Token(Token = "0x4000006")]
		public const string GLOBAL_PROP_FOGCOLOR = "_VRTP_Cage_FogColor";

		[Token(Token = "0x4000007")]
		public const string GLOBAL_PROP_FOGDENSITY = "_VRTP_Cage_FogDensity";

		[Token(Token = "0x4000008")]
		public const string GLOBAL_PROP_FOGPOWER = "_VRTP_Cage_FogPower";

		[Token(Token = "0x4000009")]
		public const string GLOBAL_PROP_FOGBLEND = "_VRTP_Cage_FogBlend";

		[Token(Token = "0x400000A")]
		protected const string PATH_SHADERS = "Hidden/VrTunnellingPro/";

		[Token(Token = "0x400000B")]
		protected const string PATH_MESHES = "Meshes/";

		[Token(Token = "0x400000C")]
		protected const string PATH_IRISMESH = "Iris";

		[Token(Token = "0x400000D")]
		protected const string PROP_OUTER = "_FxOuter";

		[Token(Token = "0x400000E")]
		protected const string PROP_INNER = "_FxInner";

		[Token(Token = "0x400000F")]
		protected const string PROP_COLOR = "_Color";

		[Token(Token = "0x4000010")]
		protected const string PROP_SKYBOX = "_Skybox";

		[Token(Token = "0x4000011")]
		protected const string PROP_EYEPRJ = "_EyeProjection";

		[Token(Token = "0x4000012")]
		protected const string PROP_EYEMAT = "_EyeToWorld";

		[Token(Token = "0x4000013")]
		protected const string KEYWORD_BKG = "TUNNEL_BKG";

		[Token(Token = "0x4000014")]
		protected const string KEYWORD_SKYBOX = "TUNNEL_SKYBOX";

		[Token(Token = "0x4000015")]
		protected const string KEYWORD_OVERLAY = "TUNNEL_OVERLAY";

		[Token(Token = "0x4000016")]
		public const float FEATHER_MAX = 0.5f;

		[Token(Token = "0x4000017")]
		public const float MOTION_STRENGTH_MAX = 2f;

		[Token(Token = "0x4000018")]
		public const float COUNTER_STRENGTH_MAX = 2f;

		[Token(Token = "0x4000019")]
		public const int FPSDIV_MAX = 60;

		[Token(Token = "0x400001A")]
		private const float COVERAGE_MIN = 0.65f;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int _propFxInner;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		protected int _propFxOuter;

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int _propEyeProjection;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int _propEyeToWorld;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected int _globPropFogColor;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		protected int _globPropFogDensity;

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected int _globPropFogPower;

		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		protected int _globPropFogBlend;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Matrix4x4[] _eyeToWorld;

		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Matrix4x4[] _eyeProjection;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Motion calculated using this Transform.\n> Generally shouldn't use HMD")]
		public Transform motionTarget;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Colour of vignette.\n> Alpha is blend factor.")]
		public Color effectColor;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		[Tooltip("Maximum screen coverage.")]
		public float effectCoverage;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Feather around cut-off as fraction of screen.")]
		[Range(0f, 0.5f)]
		public float effectFeather;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Cubemap effectSkybox;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool applyColorToBackground;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		[Tooltip("Add angular velocity to effect strength?\nHelps players with average sim-sickness.")]
		public bool useAngularVelocity;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 2f)]
		public float angularVelocityStrength;

		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float angularVelocityMin;

		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public float angularVelocityMax;

		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public float angularVelocitySmoothing;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Tooltip("Add linear acceleration to effect strength?\nHelps players with above-average sim-sickness.")]
		public bool useAcceleration;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 2f)]
		public float accelerationStrength;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float accelerationMin;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float accelerationMax;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float accelerationSmoothing;

		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[Tooltip("Add linear velocity to effect strength?\nHelps players with strong sim-sickness.")]
		public bool useVelocity;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[Range(0f, 2f)]
		public float velocityStrength;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public float velocityMin;

		[Token(Token = "0x4000038")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float velocityMax;

		[Token(Token = "0x4000039")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float velocitySmoothing;

		[Token(Token = "0x400003A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Tooltip("How to combine Force Vignette Value with motion value to calculate effect radius.")]
		public ForceVignetteMode forceVignetteMode;

		[Token(Token = "0x400003B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		[Tooltip("Force vignette radius to this value.\nCombined with motion value according to Force Vignette Mode.")]
		public float forceVignetteValue;

		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[Tooltip("Transform used for artificial tilt and framerate division.\nShould be below Motion Target in hierarchy.\nTarget's transform should not be modified by anything else.")]
		public Transform motionEffectTarget;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Move/rotate cage/skybox opposite to Motion Target motion.")]
		public bool useCounterMotion;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		[Tooltip("Scale counter-rotation relative to Motion Target rotation.")]
		public float counterRotationStrength;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Scale counter-rotation on individual axes.\nX: Pitch, Y: Yaw, Z: Roll")]
		public Vector3 counterRotationPerAxis;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[Tooltip("Artifically tilt the camera when moving to simulate acceleration forces.")]
		public bool useArtificialTilt;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("Strength of artificial tilt relative to linear acceleration.")]
		public float tiltStrength;

		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Tooltip("Maximum artificial tilt in degrees. Zero for no clamp.\nX: Pitch, Y: Roll.")]
		public Vector2 tiltMaxAngles;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Range(0f, 0.5f)]
		[Tooltip("Smooth out tilt over this time.")]
		public float tiltSmoothTime;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Range(1f, 60f)]
		[Tooltip("Divide VR framerate by this number while keeping HMD and cage at device framerate.")]
		public int framerateDivision;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public bool divideTranslation;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xED")]
		public bool divideRotation;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Quaternion _lastRot;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Vector3 _lastFwd;

		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 _lastPos;

		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private float _lastSpeed;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		private Vector3 _lastVel;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		protected Quaternion _cmRot;

		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private float _avSmoothed;

		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private float _avSlew;

		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private float _speedSmoothed;

		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		private float _speedSlew;

		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private float _accelSmoothed;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
		private float _accelSlew;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Transform _prevMotionEffectTarget;

		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private bool _prevUseTilt;

		[Token(Token = "0x4000055")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
		private Vector3 _tiltAccelSmoothed;

		[Token(Token = "0x4000056")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private Vector3 _tiltAccelSlew;

		[Token(Token = "0x4000057")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private Angle3 _tiltInit;

		[Token(Token = "0x4000058")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private int _lastFpsDivision;

		[Token(Token = "0x4000059")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		private Vector3 _mfxTgtLocalPosInit;

		[Token(Token = "0x400005A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Quaternion _mfxTgtLocalRotInit;

		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		protected Camera _cam;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		protected bool _hasDrawnThisFrame;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private Vector3 _fpsPosition;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Quaternion _fpsRotation;

		[Token(Token = "0x17000002")]
		public bool usingMotionEffectTarget
		{
			[Token(Token = "0x6000004")]
			[Address(RVA = "0xFE7B88", Offset = "0xFE7B88", VA = "0xFE7B88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xFE7BA8", Offset = "0xFE7BA8", VA = "0xFE7BA8", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xFE7D44", Offset = "0xFE7D44", VA = "0xFE7D44", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xFE7DAC", Offset = "0xFE7DAC", VA = "0xFE7DAC")]
		protected void ApplyPresetBase(TunnellingPresetBase p)
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0xFE8190", Offset = "0xFE8190", VA = "0xFE8190")]
		protected void FillMaskBuffer(CommandBuffer cb, List<Renderer> rs, Material m)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xFE7D48", Offset = "0xFE7D48", VA = "0xFE7D48")]
		protected void ResetMotion()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0xFE8354", Offset = "0xFE8354", VA = "0xFE8354", Slot = "6")]
		public virtual void ResetCounterMotion()
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0xFE83C4", Offset = "0xFE83C4", VA = "0xFE83C4")]
		private float RemapRadius(float radius)
		{
			return default(float);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0xFE83F0", Offset = "0xFE83F0", VA = "0xFE83F0")]
		protected float CalculateMotion(float dT)
		{
			return default(float);
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0xFE91DC", Offset = "0xFE91DC", VA = "0xFE91DC")]
		public static Vector3 SmoothDampAngle(Vector3 current, Vector3 target, ref Vector3 vel, float smoothTime, float maxSpeed, float dT)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0xFE9380", Offset = "0xFE9380", VA = "0xFE9380", Slot = "7")]
		protected virtual void UpdateCounterMotion(Vector3 deltaPos, Quaternion deltaRot)
		{
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0xFE9440", Offset = "0xFE9440", VA = "0xFE9440")]
		protected Quaternion GetCounterRotationDelta(Quaternion deltaRot)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0xFE9514", Offset = "0xFE9514", VA = "0xFE9514")]
		protected void UpdateEyeMatrices()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0xFE9B08", Offset = "0xFE9B08", VA = "0xFE9B08", Slot = "8")]
		protected virtual void CorrectEyeMatrices(Matrix4x4[] eyePrj, Matrix4x4[] eyeToWorld)
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0xFE9B0C", Offset = "0xFE9B0C", VA = "0xFE9B0C")]
		protected void ApplyEyeMatrices(Material m)
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0xFE9B54", Offset = "0xFE9B54", VA = "0xFE9B54")]
		protected TunnellingBase()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public struct Angle
	{
		[Token(Token = "0x2000009")]
		public enum AngleType
		{
			[Token(Token = "0x4000079")]
			ANGLE,
			[Token(Token = "0x400007A")]
			ACUTE,
			[Token(Token = "0x400007B")]
			REFLEX
		}

		[Token(Token = "0x4000077")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private float _angle;

		[Token(Token = "0x17000003")]
		public float angle
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0xFE9CBC", Offset = "0xFE9CBC", VA = "0xFE9CBC")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000004")]
		public float acute
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0xFE9CC4", Offset = "0xFE9CC4", VA = "0xFE9CC4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000005")]
		public float reflex
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0xFE9D88", Offset = "0xFE9D88", VA = "0xFE9D88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xFE9DD4", Offset = "0xFE9DD4", VA = "0xFE9DD4")]
		public Angle(float a)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0xFE9E04", Offset = "0xFE9E04", VA = "0xFE9E04")]
		public Angle(Angle a)
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xFE9E34", Offset = "0xFE9E34", VA = "0xFE9E34")]
		public float ToFloat(AngleType type)
		{
			return default(float);
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xFE9D10", Offset = "0xFE9D10", VA = "0xFE9D10")]
		public static float ToAngle(float a, AngleType type)
		{
			return default(float);
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xFE9E40", Offset = "0xFE9E40", VA = "0xFE9E40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0xFE9EC4", Offset = "0xFE9EC4", VA = "0xFE9EC4")]
		public static bool operator <(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xFE9ED0", Offset = "0xFE9ED0", VA = "0xFE9ED0")]
		public static bool operator >(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0xFE9EDC", Offset = "0xFE9EDC", VA = "0xFE9EDC")]
		public static bool operator <=(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0xFE9EE8", Offset = "0xFE9EE8", VA = "0xFE9EE8")]
		public static bool operator >=(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0xFE9EF4", Offset = "0xFE9EF4", VA = "0xFE9EF4")]
		public static Angle operator +(Angle a, Angle b)
		{
			return default(Angle);
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0xFE9F24", Offset = "0xFE9F24", VA = "0xFE9F24")]
		public static Angle operator -(Angle a, Angle b)
		{
			return default(Angle);
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0xFE9F54", Offset = "0xFE9F54", VA = "0xFE9F54")]
		public static bool operator ==(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0xFE9F60", Offset = "0xFE9F60", VA = "0xFE9F60")]
		public static bool operator !=(Angle a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0xFE9F6C", Offset = "0xFE9F6C", VA = "0xFE9F6C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xFEA024", Offset = "0xFEA024", VA = "0xFEA024", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xFEA02C", Offset = "0xFEA02C", VA = "0xFEA02C")]
		public static bool operator <(Angle a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xFEA060", Offset = "0xFEA060", VA = "0xFEA060")]
		public static bool operator >(Angle a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0xFEA094", Offset = "0xFEA094", VA = "0xFEA094")]
		public static bool operator <=(Angle a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xFEA0C8", Offset = "0xFEA0C8", VA = "0xFEA0C8")]
		public static bool operator >=(Angle a, float b)
		{
			return default(bool);
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0xFEA0FC", Offset = "0xFEA0FC", VA = "0xFEA0FC")]
		public static Angle operator +(Angle a, float b)
		{
			return default(Angle);
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xFEA148", Offset = "0xFEA148", VA = "0xFEA148")]
		public static Angle operator -(Angle a, float b)
		{
			return default(Angle);
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xFEA194", Offset = "0xFEA194", VA = "0xFEA194")]
		public static Angle operator *(Angle a, float b)
		{
			return default(Angle);
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xFEA1C4", Offset = "0xFEA1C4", VA = "0xFEA1C4")]
		public static Angle operator /(Angle a, float b)
		{
			return default(Angle);
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0xFEA1F4", Offset = "0xFEA1F4", VA = "0xFEA1F4")]
		public static bool operator <(float a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xFEA1FC", Offset = "0xFEA1FC", VA = "0xFEA1FC")]
		public static bool operator >(float a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0xFEA204", Offset = "0xFEA204", VA = "0xFEA204")]
		public static bool operator <=(float a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xFEA20C", Offset = "0xFEA20C", VA = "0xFEA20C")]
		public static bool operator >=(float a, Angle b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xFEA214", Offset = "0xFEA214", VA = "0xFEA214")]
		public static Angle operator +(float a, Angle b)
		{
			return default(Angle);
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xFEA260", Offset = "0xFEA260", VA = "0xFEA260")]
		public static Angle operator -(float a, Angle b)
		{
			return default(Angle);
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0xFEA2AC", Offset = "0xFEA2AC", VA = "0xFEA2AC")]
		public static implicit operator Angle(float f)
		{
			return default(Angle);
		}
	}
	[Token(Token = "0x200000A")]
	public struct Angle3
	{
		[Token(Token = "0x400007C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Angle x;

		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public Angle y;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Angle z;

		[Token(Token = "0x17000006")]
		public Vector3 eulerAngles
		{
			[Token(Token = "0x6000035")]
			[Address(RVA = "0xFEA2D8", Offset = "0xFEA2D8", VA = "0xFEA2D8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000007")]
		public Vector3 eulerAcute
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xFE8FD0", Offset = "0xFE8FD0", VA = "0xFE8FD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000008")]
		public Vector3 eulerReflex
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0xFEA2E4", Offset = "0xFEA2E4", VA = "0xFEA2E4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000009")]
		public Angle angle
		{
			[Token(Token = "0x6000038")]
			[Address(RVA = "0xFEA36C", Offset = "0xFEA36C", VA = "0xFEA36C")]
			get
			{
				return default(Angle);
			}
		}

		[Token(Token = "0x1700000A")]
		public Vector3 axis
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0xFEA42C", Offset = "0xFEA42C", VA = "0xFEA42C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0xFE90C0", Offset = "0xFE90C0", VA = "0xFE90C0")]
		public Angle3(float x, float y, float z)
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xFEA460", Offset = "0xFEA460", VA = "0xFEA460")]
		public Angle3(Angle x, Angle y, Angle z)
		{
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0xFE9058", Offset = "0xFE9058", VA = "0xFE9058")]
		public Angle3(Vector3 euler)
		{
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0xFEA464", Offset = "0xFEA464", VA = "0xFEA464")]
		public Angle3(Quaternion rotation)
		{
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0xFEA39C", Offset = "0xFEA39C", VA = "0xFEA39C")]
		public void ToAxisAngle(out Vector3 axis, out Angle angle)
		{
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0xFEA49C", Offset = "0xFEA49C", VA = "0xFEA49C")]
		public Vector3 ToEuler(Angle.AngleType type)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0xFEA500", Offset = "0xFEA500", VA = "0xFEA500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0xFE9118", Offset = "0xFE9118", VA = "0xFE9118")]
		public static Angle3 operator +(Angle3 a, Angle3 b)
		{
			return default(Angle3);
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0xFEA5C4", Offset = "0xFEA5C4", VA = "0xFEA5C4")]
		public static Angle3 operator -(Angle3 a, Angle3 b)
		{
			return default(Angle3);
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0xFEA688", Offset = "0xFEA688", VA = "0xFEA688")]
		public static Angle3 operator *(Angle3 a, float b)
		{
			return default(Angle3);
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0xFEA74C", Offset = "0xFEA74C", VA = "0xFEA74C")]
		public static bool operator ==(Angle3 a, Angle3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0xFEA774", Offset = "0xFEA774", VA = "0xFEA774")]
		public static bool operator !=(Angle3 a, Angle3 b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0xFEA79C", Offset = "0xFEA79C", VA = "0xFEA79C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0xFEA878", Offset = "0xFEA878", VA = "0xFEA878", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xFE905C", Offset = "0xFE905C", VA = "0xFE905C")]
		public static implicit operator Angle3(Vector3 v)
		{
			return default(Angle3);
		}
	}
	[Token(Token = "0x200000B")]
	public abstract class TunnellingImageBase : TunnellingBase
	{
		[Token(Token = "0x200000C")]
		public enum BlurKernel
		{
			[Token(Token = "0x40000DA")]
			FIVE,
			[Token(Token = "0x40000DB")]
			NINE,
			[Token(Token = "0x40000DC")]
			THIRTEEN
		}

		[Token(Token = "0x200000D")]
		public enum CounterVelocityMode
		{
			[Token(Token = "0x40000DE")]
			OFF,
			[Token(Token = "0x40000DF")]
			SHADER,
			[Token(Token = "0x40000E0")]
			REAL
		}

		[Token(Token = "0x400007F")]
		private const string KEYWORD_MASK = "TUNNEL_MASK";

		[Token(Token = "0x4000080")]
		private const string KEYWORD_CONSTANT = "TUNNEL_CONSTANT";

		[Token(Token = "0x4000081")]
		private const string KEYWORD_INVERT = "TUNNEL_INVERT_MASK";

		[Token(Token = "0x4000082")]
		private const string KEYWORD_BLUR = "TUNNEL_BLUR";

		[Token(Token = "0x4000083")]
		private const string PATH_TUNNELSHADER = "Tunnelling";

		[Token(Token = "0x4000084")]
		private const string PATH_MASKSHADER = "Mask";

		[Token(Token = "0x4000085")]
		private const string PATH_WINDOWSHADER = "Window";

		[Token(Token = "0x4000086")]
		private const string PATH_COPYSHADER = "BlitA";

		[Token(Token = "0x4000087")]
		private const string PATH_BLURSHADER = "SeparableBlur";

		[Token(Token = "0x4000088")]
		private const string PATH_IRISSHADER = "TunnellingVertexZ";

		[Token(Token = "0x4000089")]
		private const string PATH_SKYSPHERESHADER = "Skysphere";

		[Token(Token = "0x400008A")]
		private const string PATH_SKYSPHEREMESH = "Skysphere";

		[Token(Token = "0x400008B")]
		private const string PROP_FEATHER = "_Feather";

		[Token(Token = "0x400008C")]
		private const string PROP_BKGRT = "_BkgTex";

		[Token(Token = "0x400008D")]
		private const string PROP_MASKRT = "_MaskTex";

		[Token(Token = "0x400008E")]
		private const string PROP_BLUR = "_Blur";

		[Token(Token = "0x400008F")]
		private const string PROP_OVERLAY = "_Overlay";

		[Token(Token = "0x4000090")]
		private const string PROP_BLUR_OFFSETS = "_Offsets";

		[Token(Token = "0x4000091")]
		private const float BLUR_OFFSET_1 = 1.3333334f;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float[] BLUR_OFFSETS_9;

		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly float[] BLUR_OFFSETS_13;

		[Token(Token = "0x4000094")]
		public const string GLOBAL_PROP_WORLD2CAGE = "_VRTP_WorldToCage";

		[Token(Token = "0x4000095")]
		public const string GLOBAL_PROP_WORLD2CAGE_NORMAL = "_VRTP_WorldToCageNormal";

		[Token(Token = "0x4000096")]
		public const string GLOBAL_PROP_CAGEPOS = "_VRTP_CagePos";

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[Tooltip("Determines what is rendered in the vignette effect.")]
		public BackgroundMode backgroundMode;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[Tooltip("Allows a persistent overlay of the effect across the entire view.")]
		[Range(0f, 1f)]
		public float effectOverlay;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[SerializeField]
		[Tooltip("Root of objects to render as 'cage'.\n> No lighting! Use Unlit materials\n> Parent to camera's parent, to be 'static'")]
		private GameObject _cageParent;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		[Range(0f, 2f)]
		public int cageDownsample;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		public MSAA cageAntiAliasing;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		public bool cageUpdateEveryFrame;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		[Range(0.001f, 0.2f)]
		public float cageFogDensity;

		[Token(Token = "0x400009F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		[Range(1f, 5f)]
		public float cageFogPower;

		[Token(Token = "0x40000A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		[Range(0f, 1f)]
		public float cageFogBlend;

		[Token(Token = "0x40000A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		public MaskMode maskMode;

		[Token(Token = "0x40000A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F4")]
		[Range(0f, 4f)]
		public int blurDownsample;

		[Token(Token = "0x40000A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		[Range(1f, 5f)]
		public float blurDistance;

		[Token(Token = "0x40000A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
		[Range(1f, 5f)]
		public int blurPasses;

		[Token(Token = "0x40000A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		public BlurKernel blurSamples;

		[Token(Token = "0x40000A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
		[Tooltip("At start of rendering, fill Z buffer where effect will be to save fillrate on drawing world.\nDisabled with blur or masking.")]
		public bool irisZRejection;

		[Token(Token = "0x40000A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		public CounterVelocityMode counterVelocityMode;

		[Token(Token = "0x40000A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		[Tooltip("Reset cage after this distance.\nSet 0 for no distance-based reset.")]
		public float counterVelocityResetDistance;

		[Token(Token = "0x40000A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		[Tooltip("Reset cage after this time.\nSet 0 for no distance-based reset.")]
		public float counterVelocityResetTime;

		[Token(Token = "0x40000AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
		[Range(0f, 2f)]
		[Tooltip("Scale counter-velocity relative to Motion Target velocity.")]
		public float counterVelocityStrength;

		[Token(Token = "0x40000AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		[Tooltip("Scale counter-velocity on individual axes.\nMultiplied by Counter Velocity Strength.")]
		public Vector3 counterVelocityPerAxis;

		[Token(Token = "0x40000AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private CommandBuffer _maskCmd;

		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private Material _matTunnel;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private Material _matMask;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private Material _matWindow;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private Material _matCopyAlpha;

		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private Material _matBlur;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private Material _matSkysphere;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private Mesh _meshSkysphere;

		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private MeshRenderer[] _cageMrs;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private List<MeshFilter> _cageMfs;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private List<Renderer> _maskObjects;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private RenderTexture _cageRt;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private RenderTexture _maskRt;

		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private RenderTexture _blurRt0;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private RenderTexture _blurRt1;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private int _rtX;

		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A4")]
		private int _rtY;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private int _rtA;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private CommandBuffer _irisCmd;

		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private Material _matIris;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private Mesh _meshIris;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private Vector4[] _blurOffsets;

		[Token(Token = "0x40000C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private MaskMode _lastMaskMode;

		[Token(Token = "0x40000C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D4")]
		private MSAA _lastCageMsaa;

		[Token(Token = "0x40000C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private bool _camHasMaskBuffer;

		[Token(Token = "0x40000C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2DC")]
		private int _lastCageDownsample;

		[Token(Token = "0x40000C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private int _lastBlurDownsample;

		[Token(Token = "0x40000C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private float _lastBlurRadius;

		[Token(Token = "0x40000C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private BlurKernel _lastBlurKernel;

		[Token(Token = "0x40000C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2EC")]
		private bool _wasDrawingIrisEarly;

		[Token(Token = "0x40000CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2ED")]
		private bool _camHasIrisBuffer;

		[Token(Token = "0x40000CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private CounterVelocityMode _lastCvMode;

		[Token(Token = "0x40000CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private Vector3 _cmPos;

		[Token(Token = "0x40000CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private Vector3 _cageInitialPosLocal;

		[Token(Token = "0x40000CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30C")]
		private float _timeToResetCounterVelocity;

		[Token(Token = "0x40000CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private int _propColor;

		[Token(Token = "0x40000D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		private int _propBkgRt;

		[Token(Token = "0x40000D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private int _propMaskRt;

		[Token(Token = "0x40000D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31C")]
		private int _propSkybox;

		[Token(Token = "0x40000D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private int _propOverlay;

		[Token(Token = "0x40000D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		private int _propBlur;

		[Token(Token = "0x40000D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private int _propBlurOffsets;

		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private int _globPropWorld2Cage;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private int _globPropWorld2CageNormal;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		private int _globPropCagePos;

		[Token(Token = "0x1700000B")]
		public static TunnellingImageBase instance
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0xFEA8E4", Offset = "0xFEA8E4", VA = "0xFEA8E4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600004A")]
			[Address(RVA = "0xFEA93C", Offset = "0xFEA93C", VA = "0xFEA93C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700000C")]
		public bool usingMask
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xFEA99C", Offset = "0xFEA99C", VA = "0xFEA99C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000D")]
		public bool usingCage
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0xFEA9AC", Offset = "0xFEA9AC", VA = "0xFEA9AC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000E")]
		private bool _usingCageRt
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xFEA9D0", Offset = "0xFEA9D0", VA = "0xFEA9D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000F")]
		private bool _canDrawIris
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0xFEA9E4", Offset = "0xFEA9E4", VA = "0xFEA9E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000010")]
		private bool _drawIris
		{
			[Token(Token = "0x600004F")]
			[Address(RVA = "0xFEAA18", Offset = "0xFEAA18", VA = "0xFEAA18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000011")]
		private bool _isInstanced
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0xFEAA54", Offset = "0xFEAA54", VA = "0xFEAA54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000012")]
		protected abstract CameraEvent _maskCmdEvt
		{
			[Token(Token = "0x6000051")]
			get;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0xFEAA88", Offset = "0xFEAA88", VA = "0xFEAA88", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0xFEB46C", Offset = "0xFEB46C", VA = "0xFEB46C", Slot = "5")]
		protected override void OnEnable()
		{
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0xFEB858", Offset = "0xFEB858", VA = "0xFEB858")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xFEB8CC", Offset = "0xFEB8CC", VA = "0xFEB8CC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xFEBAB8", Offset = "0xFEBAB8", VA = "0xFEBAB8")]
		private void ReleaseRT(ref RenderTexture rt)
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xFEBB4C", Offset = "0xFEBB4C", VA = "0xFEBB4C")]
		public void AddObjectToMask(Renderer r, bool includeChildren = false)
		{
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0xFEBEC8", Offset = "0xFEBEC8", VA = "0xFEBEC8")]
		public void RemoveObjectFromMask(Renderer r, bool includeChildren = false)
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xFEB4EC", Offset = "0xFEB4EC", VA = "0xFEB4EC")]
		public void UpdateCage()
		{
		}

		[Token(Token = "0x600005A")]
		[Address(RVA = "0xFEBFAC", Offset = "0xFEBFAC", VA = "0xFEBFAC", Slot = "6")]
		public override void ResetCounterMotion()
		{
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0xFEC094", Offset = "0xFEC094", VA = "0xFEC094")]
		public void ApplyPreset(TunnellingPreset p)
		{
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0xFEC4C4", Offset = "0xFEC4C4", VA = "0xFEC4C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0xFECACC", Offset = "0xFECACC", VA = "0xFECACC")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0xFE74F0", Offset = "0xFE74F0", VA = "0xFE74F0")]
		protected void Draw(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0xFED31C", Offset = "0xFED31C", VA = "0xFED31C", Slot = "8")]
		protected override void CorrectEyeMatrices(Matrix4x4[] eyePrj, Matrix4x4[] eyeToWorld)
		{
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0xFED380", Offset = "0xFED380", VA = "0xFED380", Slot = "7")]
		protected override void UpdateCounterMotion(Vector3 deltaPos, Quaternion deltaRot)
		{
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0xFEB1F0", Offset = "0xFEB1F0", VA = "0xFEB1F0")]
		private void UpdateKeywords()
		{
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xFEC85C", Offset = "0xFEC85C", VA = "0xFEC85C")]
		private void UpdateBlurKernel()
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xFED580", Offset = "0xFED580", VA = "0xFED580")]
		private int GetMsaa(MSAA m, int srcMsaa)
		{
			return default(int);
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xFED5A4", Offset = "0xFED5A4", VA = "0xFED5A4")]
		private void SetTexArrayIfNeeded(RenderTexture target)
		{
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0xFECCB0", Offset = "0xFECCB0", VA = "0xFECCB0")]
		private void UpdateRenderTextures(int srcX, int srcY, int srcMsaa)
		{
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xFEBCD8", Offset = "0xFEBCD8", VA = "0xFEBCD8")]
		private void ResetMaskCommandBuffer()
		{
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0xFEB7A8", Offset = "0xFEB7A8", VA = "0xFEB7A8")]
		private void ToggleMaskCommandBuffer(bool on)
		{
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0xFEB80C", Offset = "0xFEB80C", VA = "0xFEB80C")]
		private void ToggleIrisCommandBuffer(bool on)
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0xFE7A04", Offset = "0xFE7A04", VA = "0xFE7A04")]
		protected TunnellingImageBase()
		{
		}
	}
	[Token(Token = "0x200000E")]
	[RequireComponent(typeof(Renderer))]
	public class TunnellingMaskObject : MonoBehaviour
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool autoAddChildren;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer _r;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _started;

		[Token(Token = "0x600006B")]
		[Address(RVA = "0xFED6F0", Offset = "0xFED6F0", VA = "0xFED6F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0xFED748", Offset = "0xFED748", VA = "0xFED748")]
		private void Start()
		{
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0xFED754", Offset = "0xFED754", VA = "0xFED754")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0xFED8E0", Offset = "0xFED8E0", VA = "0xFED8E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0xFEDA54", Offset = "0xFEDA54", VA = "0xFEDA54")]
		public TunnellingMaskObject()
		{
		}
	}
	[Token(Token = "0x200000F")]
	[RequireComponent(typeof(Renderer))]
	public class TunnellingMaskObjectMobile : MonoBehaviour
	{
		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool autoAddChildren;

		[Token(Token = "0x40000E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Renderer _r;

		[Token(Token = "0x40000E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool _started;

		[Token(Token = "0x6000070")]
		[Address(RVA = "0xFEDA5C", Offset = "0xFEDA5C", VA = "0xFEDA5C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0xFEDAB4", Offset = "0xFEDAB4", VA = "0xFEDAB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0xFEDAC0", Offset = "0xFEDAC0", VA = "0xFEDAC0")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0xFEDFF4", Offset = "0xFEDFF4", VA = "0xFEDFF4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0xFEE2BC", Offset = "0xFEE2BC", VA = "0xFEE2BC")]
		public TunnellingMaskObjectMobile()
		{
		}
	}
	[Token(Token = "0x2000010")]
	public class TunnellingMobile : TunnellingBase
	{
		[Token(Token = "0x40000E7")]
		public const string GLOBAL_PROP_STENCILREF = "_VRTP_Stencil_Ref";

		[Token(Token = "0x40000E8")]
		public const string GLOBAL_PROP_STENCILMASK = "_VRTP_Stencil_Mask";

		[Token(Token = "0x40000E9")]
		public const string GLOBAL_PROP_STENCILBIAS = "_VRTP_Stencil_Bias";

		[Token(Token = "0x40000EA")]
		private const string PROP_WRITEZ = "_WriteZ";

		[Token(Token = "0x40000EB")]
		private const string PATH_SHADER = "TunnellingVertex";

		[Token(Token = "0x40000EC")]
		private const string PATH_STENCILSHADER = "TunnellingMobileStencil";

		[Token(Token = "0x40000ED")]
		private const CameraEvent CEVENT_FX = CameraEvent.BeforeImageEffects;

		[Token(Token = "0x40000EE")]
		private const CameraEvent CEVENT_Z = CameraEvent.BeforeForwardOpaque;

		[Token(Token = "0x40000EF")]
		private const int RQUEUE_FIRST = 1;

		[Token(Token = "0x40000F0")]
		private const int RQUEUE_MASK = 2499;

		[Token(Token = "0x40000F1")]
		private const int RQUEUE_OPAQUE = 2501;

		[Token(Token = "0x40000F2")]
		private const int RQUEUE_LAST = 5000;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material _stencilMat;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		[Tooltip("Draw skybox over vignette instead of solid color.")]
		public bool drawSkybox;

		[Token(Token = "0x40000F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
		[Tooltip("Use stencil mask to exclude objects from vignette?\nCan stress drawcalls and fillrate.")]
		public bool useMask;

		[Token(Token = "0x40000F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
		[Tooltip("If ticked, transparent objects will draw on top of vignette.\nDisables z-rejection optimisation.")]
		public bool drawBeforeTransparent;

		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
		[Tooltip("Pixels with this value in the stencil buffer will be masked.")]
		[Range(0f, 255f)]
		public int stencilReference;

		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		[Tooltip("Write- and read-mask for stencil buffer.\nIf in doubt, leave at 255.")]
		[Range(0f, 255f)]
		public int stencilMask;

		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		[Tooltip("Offset Z on mask to avoid z-fighting.")]
		[Range(0f, 10f)]
		public float stencilBias;

		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private int _propColor;

		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1DC")]
		private int _propSkybox;

		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private int _propWriteZ;

		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private int _globPropStencilRef;

		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private int _globPropStencilMask;

		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1EC")]
		private int _globPropStencilBias;

		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private Material _irisMatOuter;

		[Token(Token = "0x4000102")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private Material _irisMatInner;

		[Token(Token = "0x4000103")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private Mesh _irisMesh;

		[Token(Token = "0x4000104")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private Dictionary<Renderer, MeshFilter> _maskObjects;

		[Token(Token = "0x4000105")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Stack<Mesh> _skinnedMeshPool;

		[Token(Token = "0x4000106")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private Stack<Mesh> _skinnedMeshesRendering;

		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private List<UnityEngine.Object> _toDestroy;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private List<MeshRenderer> _tempMeshChildren;

		[Token(Token = "0x4000109")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private List<SkinnedMeshRenderer> _tempSkinnedMeshChildren;

		[Token(Token = "0x17000013")]
		public static TunnellingMobile instance
		{
			[Token(Token = "0x6000075")]
			[Address(RVA = "0xFEE2C4", Offset = "0xFEE2C4", VA = "0xFEE2C4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000076")]
			[Address(RVA = "0xFEE30C", Offset = "0xFEE30C", VA = "0xFEE30C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000014")]
		public static Material stencilMat
		{
			[Token(Token = "0x6000077")]
			[Address(RVA = "0xFEE364", Offset = "0xFEE364", VA = "0xFEE364")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public bool irisZRejectionEnabled
		{
			[Token(Token = "0x6000078")]
			[Address(RVA = "0xFEE460", Offset = "0xFEE460", VA = "0xFEE460")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xFEE480", Offset = "0xFEE480", VA = "0xFEE480")]
		public void ApplyPreset(TunnellingPresetMobile p)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xFEDBFC", Offset = "0xFEDBFC", VA = "0xFEDBFC")]
		public void AddObjectToMask(Renderer r, bool includeChildren = false)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0xFEE118", Offset = "0xFEE118", VA = "0xFEE118")]
		public void RemoveObjectFromMask(Renderer r, bool includeChildren = false)
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0xFEE534", Offset = "0xFEE534", VA = "0xFEE534", Slot = "4")]
		protected override void Awake()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0xFEE9F0", Offset = "0xFEE9F0", VA = "0xFEE9F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0xFEEDCC", Offset = "0xFEEDCC", VA = "0xFEEDCC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0xFEF5A0", Offset = "0xFEF5A0", VA = "0xFEF5A0")]
		private void DrawIris(Material m, int submesh, int opaqueQueue, int camLayer)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0xFEF844", Offset = "0xFEF844", VA = "0xFEF844")]
		private void OnPreRender()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xFEF86C", Offset = "0xFEF86C", VA = "0xFEF86C")]
		public TunnellingMobile()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class TunnellingOpaque : TunnellingImageBase
	{
		[Token(Token = "0x17000016")]
		protected override CameraEvent _maskCmdEvt
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0xFEFA78", Offset = "0xFEFA78", VA = "0xFEFA78", Slot = "9")]
			get
			{
				return default(CameraEvent);
			}
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xFEFA80", Offset = "0xFEFA80", VA = "0xFEFA80")]
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0xFEFA84", Offset = "0xFEFA84", VA = "0xFEFA84")]
		public TunnellingOpaque()
		{
		}
	}
	[Token(Token = "0x2000012")]
	[CreateAssetMenu(menuName = "VrTunnellingPro/Tunnelling Preset", order = 0)]
	public class TunnellingPreset : TunnellingPresetBase
	{
		[Token(Token = "0x400010A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _effectOverlay;

		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private bool _overrideEffectOverlay;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private TunnellingBase.BackgroundMode _backgroundMode;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private bool _overrideBackgroundMode;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 2f)]
		[SerializeField]
		private int _cageDownsample;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private bool _overrideCageDownsample;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private TunnellingBase.MSAA _cageAntiAliasing;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private bool _overrideCageAntiAliasing;

		[Token(Token = "0x4000112")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCD")]
		[SerializeField]
		private bool _cageUpdateEveryFrame;

		[Token(Token = "0x4000113")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCE")]
		[SerializeField]
		private bool _overrideCageUpdateEveryFrame;

		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[Range(0.001f, 0.2f)]
		[SerializeField]
		private float _cageFogDensity;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private bool _overrideCageFogDensity;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Range(1f, 5f)]
		private float _cageFogPower;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[SerializeField]
		private bool _overrideCageFogPower;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _cageFogBlend;

		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[SerializeField]
		private bool _overrideCageFogBlend;

		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private TunnellingBase.MaskMode _maskMode;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		[SerializeField]
		private bool _overrideMaskMode;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[SerializeField]
		[Range(0f, 4f)]
		private int _blurDownsample;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		[SerializeField]
		private bool _overrideBlurDownsample;

		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Range(1f, 5f)]
		private float _blurDistance;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[SerializeField]
		private bool _overrideBlurDistance;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Range(1f, 5f)]
		[SerializeField]
		private int _blurPasses;

		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		[SerializeField]
		private bool _overrideBlurPasses;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[SerializeField]
		private TunnellingImageBase.BlurKernel _blurSamples;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		[SerializeField]
		private bool _overrideBlurSamples;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		[SerializeField]
		private TunnellingImageBase.CounterVelocityMode _counterVelocityMode;

		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		[SerializeField]
		private bool _overrideCounterVelocityMode;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _counterVelocityResetDistance;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private bool _overrideCounterVelocityResetDistance;

		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _counterVelocityResetTime;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _overrideCounterVelocityResetTime;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _counterVelocityStrength;

		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		[SerializeField]
		private bool _overrideCounterVelocityStrength;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		[SerializeField]
		private Vector3 _counterVelocityPerAxis;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[SerializeField]
		private bool _overrideCounterVelocityPerAxis;

		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13D")]
		[SerializeField]
		private bool _irisZRejection;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13E")]
		[SerializeField]
		private bool _overrideIrisZRejection;

		[Token(Token = "0x17000017")]
		public float effectOverlay
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0xFEFAD8", Offset = "0xFEFAD8", VA = "0xFEFAD8")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000018")]
		public bool overrideEffectOverlay
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xFEFAE0", Offset = "0xFEFAE0", VA = "0xFEFAE0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000019")]
		public TunnellingBase.BackgroundMode backgroundMode
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0xFEFAE8", Offset = "0xFEFAE8", VA = "0xFEFAE8")]
			get
			{
				return default(TunnellingBase.BackgroundMode);
			}
		}

		[Token(Token = "0x1700001A")]
		public bool overrideBackgroundMode
		{
			[Token(Token = "0x6000088")]
			[Address(RVA = "0xFEC284", Offset = "0xFEC284", VA = "0xFEC284")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001B")]
		public int cageDownsample
		{
			[Token(Token = "0x6000089")]
			[Address(RVA = "0xFEFAF0", Offset = "0xFEFAF0", VA = "0xFEFAF0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700001C")]
		public bool overrideCageDownsample
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xFEC2A4", Offset = "0xFEC2A4", VA = "0xFEC2A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001D")]
		public TunnellingBase.MSAA cageAntiAliasing
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0xFEFAF8", Offset = "0xFEFAF8", VA = "0xFEFAF8")]
			get
			{
				return default(TunnellingBase.MSAA);
			}
		}

		[Token(Token = "0x1700001E")]
		public bool overrideCageAntiAliasing
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xFEC2C4", Offset = "0xFEC2C4", VA = "0xFEC2C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700001F")]
		public bool cageUpdateEveryFrame
		{
			[Token(Token = "0x600008D")]
			[Address(RVA = "0xFEFB00", Offset = "0xFEFB00", VA = "0xFEFB00")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000020")]
		public bool overrideCageUpdateEveryFrame
		{
			[Token(Token = "0x600008E")]
			[Address(RVA = "0xFEC2E4", Offset = "0xFEC2E4", VA = "0xFEC2E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000021")]
		public float cageFogDensity
		{
			[Token(Token = "0x600008F")]
			[Address(RVA = "0xFEFB08", Offset = "0xFEFB08", VA = "0xFEFB08")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public bool overrideCageFogDensity
		{
			[Token(Token = "0x6000090")]
			[Address(RVA = "0xFEC304", Offset = "0xFEC304", VA = "0xFEC304")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000023")]
		public float cageFogPower
		{
			[Token(Token = "0x6000091")]
			[Address(RVA = "0xFEFB10", Offset = "0xFEFB10", VA = "0xFEFB10")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000024")]
		public bool overrideCageFogPower
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0xFEC324", Offset = "0xFEC324", VA = "0xFEC324")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000025")]
		public float cageFogBlend
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xFEFB18", Offset = "0xFEFB18", VA = "0xFEFB18")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000026")]
		public bool overrideCageFogBlend
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xFEC344", Offset = "0xFEC344", VA = "0xFEC344")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public TunnellingBase.MaskMode maskMode
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0xFEFB20", Offset = "0xFEFB20", VA = "0xFEFB20")]
			get
			{
				return default(TunnellingBase.MaskMode);
			}
		}

		[Token(Token = "0x17000028")]
		public bool overrideMaskMode
		{
			[Token(Token = "0x6000096")]
			[Address(RVA = "0xFEC364", Offset = "0xFEC364", VA = "0xFEC364")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000029")]
		public int blurDownsample
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0xFEFB28", Offset = "0xFEFB28", VA = "0xFEFB28")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002A")]
		public bool overrideBlurDownsample
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0xFEC384", Offset = "0xFEC384", VA = "0xFEC384")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002B")]
		public float blurDistance
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0xFEFB30", Offset = "0xFEFB30", VA = "0xFEFB30")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700002C")]
		public bool overrideBlurDistance
		{
			[Token(Token = "0x600009A")]
			[Address(RVA = "0xFEC3A4", Offset = "0xFEC3A4", VA = "0xFEC3A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002D")]
		public int blurPasses
		{
			[Token(Token = "0x600009B")]
			[Address(RVA = "0xFEFB38", Offset = "0xFEFB38", VA = "0xFEFB38")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700002E")]
		public bool overrideBlurPasses
		{
			[Token(Token = "0x600009C")]
			[Address(RVA = "0xFEC3C4", Offset = "0xFEC3C4", VA = "0xFEC3C4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002F")]
		public TunnellingImageBase.BlurKernel blurSamples
		{
			[Token(Token = "0x600009D")]
			[Address(RVA = "0xFEFB40", Offset = "0xFEFB40", VA = "0xFEFB40")]
			get
			{
				return default(TunnellingImageBase.BlurKernel);
			}
		}

		[Token(Token = "0x17000030")]
		public bool overrideBlurSamples
		{
			[Token(Token = "0x600009E")]
			[Address(RVA = "0xFEC3E4", Offset = "0xFEC3E4", VA = "0xFEC3E4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000031")]
		public TunnellingImageBase.CounterVelocityMode counterVelocityMode
		{
			[Token(Token = "0x600009F")]
			[Address(RVA = "0xFEFB48", Offset = "0xFEFB48", VA = "0xFEFB48")]
			get
			{
				return default(TunnellingImageBase.CounterVelocityMode);
			}
		}

		[Token(Token = "0x17000032")]
		public bool overrideCounterVelocityMode
		{
			[Token(Token = "0x60000A0")]
			[Address(RVA = "0xFEC404", Offset = "0xFEC404", VA = "0xFEC404")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000033")]
		public float counterVelocityResetDistance
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0xFEFB50", Offset = "0xFEFB50", VA = "0xFEFB50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000034")]
		public bool overrideCounterVelocityResetDistance
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0xFEC424", Offset = "0xFEC424", VA = "0xFEC424")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000035")]
		public float counterVelocityResetTime
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0xFEFB58", Offset = "0xFEFB58", VA = "0xFEFB58")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000036")]
		public bool overrideCounterVelocityResetTime
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0xFEC444", Offset = "0xFEC444", VA = "0xFEC444")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000037")]
		public float counterVelocityStrength
		{
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0xFEFB60", Offset = "0xFEFB60", VA = "0xFEFB60")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000038")]
		public bool overrideCounterVelocityStrength
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0xFEC464", Offset = "0xFEC464", VA = "0xFEC464")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000039")]
		public Vector3 counterVelocityPerAxis
		{
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0xFEFB68", Offset = "0xFEFB68", VA = "0xFEFB68")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x1700003A")]
		public bool overrideCounterVelocityPerAxis
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0xFEC484", Offset = "0xFEC484", VA = "0xFEC484")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003B")]
		public bool irisZRejection
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xFEFB78", Offset = "0xFEFB78", VA = "0xFEFB78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003C")]
		public bool overrideIrisZRejection
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0xFEC4A4", Offset = "0xFEC4A4", VA = "0xFEC4A4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0xFEFB80", Offset = "0xFEFB80", VA = "0xFEFB80")]
		public TunnellingPreset()
		{
		}
	}
	[Token(Token = "0x2000013")]
	public abstract class TunnellingPresetBase : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x2000014")]
		public class MotionSettings
		{
			[Token(Token = "0x4000153")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[SerializeField]
			private bool _use;

			[Token(Token = "0x4000154")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Range(0f, 2f)]
			[SerializeField]
			private float _strength;

			[Token(Token = "0x4000155")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _min;

			[Token(Token = "0x4000156")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private float _max;

			[Token(Token = "0x4000157")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private float _smoothing;

			[Token(Token = "0x17000060")]
			public bool use
			{
				[Token(Token = "0x60000D0")]
				[Address(RVA = "0xFEFDEC", Offset = "0xFEFDEC", VA = "0xFEFDEC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000061")]
			public float strength
			{
				[Token(Token = "0x60000D1")]
				[Address(RVA = "0xFEFDF4", Offset = "0xFEFDF4", VA = "0xFEFDF4")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000062")]
			public float min
			{
				[Token(Token = "0x60000D2")]
				[Address(RVA = "0xFEFDFC", Offset = "0xFEFDFC", VA = "0xFEFDFC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000063")]
			public float max
			{
				[Token(Token = "0x60000D3")]
				[Address(RVA = "0xFEFE04", Offset = "0xFEFE04", VA = "0xFEFE04")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000064")]
			public float smoothing
			{
				[Token(Token = "0x60000D4")]
				[Address(RVA = "0xFEFE0C", Offset = "0xFEFE0C", VA = "0xFEFE0C")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60000D5")]
			[Address(RVA = "0xFEFE14", Offset = "0xFEFE14", VA = "0xFEFE14")]
			public MotionSettings()
			{
			}
		}

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _overrideAll;

		[Token(Token = "0x4000131")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _effectCoverage;

		[Token(Token = "0x4000132")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _overrideEffectCoverage;

		[Token(Token = "0x4000133")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Color _effectColor;

		[Token(Token = "0x4000134")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _overrideEffectColor;

		[Token(Token = "0x4000135")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Range(0f, 0.5f)]
		private float _effectFeather;

		[Token(Token = "0x4000136")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _overrideEffectFeather;

		[Token(Token = "0x4000137")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _applyColorToBackground;

		[Token(Token = "0x4000138")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool _overrideApplyColorToBackground;

		[Token(Token = "0x4000139")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Cubemap _skybox;

		[Token(Token = "0x400013A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _overrideSkybox;

		[Token(Token = "0x400013B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private MotionSettings _angularVelocity;

		[Token(Token = "0x400013C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _overrideAngularVelocity;

		[Token(Token = "0x400013D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private MotionSettings _acceleration;

		[Token(Token = "0x400013E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _overrideAcceleration;

		[Token(Token = "0x400013F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private MotionSettings _velocity;

		[Token(Token = "0x4000140")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _overrideVelocity;

		[Token(Token = "0x4000141")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _useCounterMotion;

		[Token(Token = "0x4000142")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool _overrideUseCounterMotion;

		[Token(Token = "0x4000143")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[SerializeField]
		[Range(0f, 2f)]
		private float _counterRotationStrength;

		[Token(Token = "0x4000144")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private bool _overrideCounterRotationStrength;

		[Token(Token = "0x4000145")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private Vector3 _counterRotationPerAxis;

		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _overrideCounterRotationPerAxis;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		[SerializeField]
		private bool _useArtificialTilt;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		[SerializeField]
		private bool _overrideUseArtificialTilt;

		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Range(0f, 60f)]
		private int _framerateDivision;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _overrideFramerateDivision;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _divideTranslation;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A")]
		[SerializeField]
		private bool _overrideDivideTranslation;

		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B")]
		[SerializeField]
		private bool _divideRotation;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private bool _overrideDivideRotation;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private TunnellingBase.ForceVignetteMode _forceVignetteMode;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private bool _overrideForceVignetteMode;

		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _forceVignetteValue;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private bool _overrideForceVignetteValue;

		[Token(Token = "0x1700003D")]
		protected bool overrideAll
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0xFEFD34", Offset = "0xFEFD34", VA = "0xFEFD34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700003E")]
		public float effectCoverage
		{
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0xFEFD3C", Offset = "0xFEFD3C", VA = "0xFEFD3C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700003F")]
		public bool overrideEffectCoverage
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0xFE7F90", Offset = "0xFE7F90", VA = "0xFE7F90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000040")]
		public Color effectColor
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xFEFD44", Offset = "0xFEFD44", VA = "0xFEFD44")]
			get
			{
				return default(Color);
			}
		}

		[Token(Token = "0x17000041")]
		public bool overrideEffectColor
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0xFE7FB0", Offset = "0xFE7FB0", VA = "0xFE7FB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000042")]
		public float effectFeather
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xFEFD50", Offset = "0xFEFD50", VA = "0xFEFD50")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000043")]
		public bool overrideEffectFeather
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0xFE7FD0", Offset = "0xFE7FD0", VA = "0xFE7FD0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000044")]
		public bool applyColorToBackground
		{
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0xFEFD58", Offset = "0xFEFD58", VA = "0xFEFD58")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000045")]
		public bool overrideApplyColorToBackground
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0xFE7FF0", Offset = "0xFE7FF0", VA = "0xFE7FF0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000046")]
		public Cubemap skybox
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xFEFD60", Offset = "0xFEFD60", VA = "0xFEFD60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		public bool overrideSkybox
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0xFE8010", Offset = "0xFE8010", VA = "0xFE8010")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000048")]
		public MotionSettings angularVelocity
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xFEFD68", Offset = "0xFEFD68", VA = "0xFEFD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		public bool overrideAngularVelocity
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0xFE8030", Offset = "0xFE8030", VA = "0xFE8030")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004A")]
		public MotionSettings acceleration
		{
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0xFEFD70", Offset = "0xFEFD70", VA = "0xFEFD70")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		public bool overrideAcceleration
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0xFE8050", Offset = "0xFE8050", VA = "0xFE8050")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004C")]
		public MotionSettings velocity
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xFEFD78", Offset = "0xFEFD78", VA = "0xFEFD78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public bool overrideVelocity
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0xFE8070", Offset = "0xFE8070", VA = "0xFE8070")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004E")]
		public bool useCounterMotion
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xFEFD80", Offset = "0xFEFD80", VA = "0xFEFD80")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700004F")]
		public bool overrideUseCounterMotion
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0xFE8090", Offset = "0xFE8090", VA = "0xFE8090")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000050")]
		public float counterRotationStrength
		{
			[Token(Token = "0x60000BF")]
			[Address(RVA = "0xFEFD88", Offset = "0xFEFD88", VA = "0xFEFD88")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000051")]
		public bool overrideCounterRotationStrength
		{
			[Token(Token = "0x60000C0")]
			[Address(RVA = "0xFEFD90", Offset = "0xFEFD90", VA = "0xFEFD90")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000052")]
		public Vector3 counterRotationPerAxis
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xFEFDB0", Offset = "0xFEFDB0", VA = "0xFEFDB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000053")]
		public bool overrideCounterRotationPerAxis
		{
			[Token(Token = "0x60000C2")]
			[Address(RVA = "0xFE80B0", Offset = "0xFE80B0", VA = "0xFE80B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000054")]
		public bool useArtificialTilt
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xFEFDBC", Offset = "0xFEFDBC", VA = "0xFEFDBC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000055")]
		public bool overrideUseArtificialTilt
		{
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0xFE80D0", Offset = "0xFE80D0", VA = "0xFE80D0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000056")]
		public int framerateDivision
		{
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0xFEFDC4", Offset = "0xFEFDC4", VA = "0xFEFDC4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000057")]
		public bool overrideFramerateDivision
		{
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0xFE80F0", Offset = "0xFE80F0", VA = "0xFE80F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000058")]
		public bool divideTranslation
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xFEFDCC", Offset = "0xFEFDCC", VA = "0xFEFDCC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000059")]
		public bool overrideDivideTranslation
		{
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0xFE8110", Offset = "0xFE8110", VA = "0xFE8110")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005A")]
		public bool divideRotation
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xFEFDD4", Offset = "0xFEFDD4", VA = "0xFEFDD4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public bool overrideDividerotation
		{
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0xFE8130", Offset = "0xFE8130", VA = "0xFE8130")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005C")]
		public TunnellingBase.ForceVignetteMode forceVignetteMode
		{
			[Token(Token = "0x60000CB")]
			[Address(RVA = "0xFEFDDC", Offset = "0xFEFDDC", VA = "0xFEFDDC")]
			get
			{
				return default(TunnellingBase.ForceVignetteMode);
			}
		}

		[Token(Token = "0x1700005D")]
		public bool overrideForceVignetteMode
		{
			[Token(Token = "0x60000CC")]
			[Address(RVA = "0xFE8150", Offset = "0xFE8150", VA = "0xFE8150")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005E")]
		public float forceVignetteValue
		{
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0xFEFDE4", Offset = "0xFEFDE4", VA = "0xFEFDE4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x1700005F")]
		public bool overrideForceVignetteValue
		{
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0xFE8170", Offset = "0xFE8170", VA = "0xFE8170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0xFEFC5C", Offset = "0xFEFC5C", VA = "0xFEFC5C")]
		protected TunnellingPresetBase()
		{
		}
	}
	[Token(Token = "0x2000015")]
	[CreateAssetMenu(menuName = "VrTunnellingPro/Tunnelling Mobile Preset", order = 1)]
	public class TunnellingPresetMobile : TunnellingPresetBase
	{
		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
		[SerializeField]
		private bool _drawSkybox;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
		[SerializeField]
		private bool _overrideDrawSkybox;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF")]
		[SerializeField]
		private bool _drawBeforeTransparent;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private bool _overrideDrawBeforeTransparent;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB1")]
		[SerializeField]
		private bool _useMask;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB2")]
		[SerializeField]
		private bool _overrideUseMask;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Range(0f, 255f)]
		private int _stencilReference;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _overrideStencilReference;

		[Token(Token = "0x4000160")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		[Range(0f, 255f)]
		[SerializeField]
		private int _stencilMask;

		[Token(Token = "0x4000161")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private bool _overrideStencilMask;

		[Token(Token = "0x4000162")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 10f)]
		[SerializeField]
		private int _stencilBias;

		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool _overrideStencilBias;

		[Token(Token = "0x17000065")]
		public bool drawSkybox
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0xFEFE24", Offset = "0xFEFE24", VA = "0xFEFE24")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000066")]
		public bool overrideDrawSkybox
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0xFEE514", Offset = "0xFEE514", VA = "0xFEE514")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000067")]
		public bool drawBeforeTransparent
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0xFEFE2C", Offset = "0xFEFE2C", VA = "0xFEFE2C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000068")]
		public bool overrideDrawBeforeTransparent
		{
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0xFEFE34", Offset = "0xFEFE34", VA = "0xFEFE34")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public bool useMask
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0xFEFE3C", Offset = "0xFEFE3C", VA = "0xFEFE3C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006A")]
		public bool overrideUseMask
		{
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0xFEFE44", Offset = "0xFEFE44", VA = "0xFEFE44")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006B")]
		public int stencilReference
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0xFEFE4C", Offset = "0xFEFE4C", VA = "0xFEFE4C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006C")]
		public bool overrideStencilReference
		{
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0xFEFE54", Offset = "0xFEFE54", VA = "0xFEFE54")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006D")]
		public int stencilMask
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0xFEFE5C", Offset = "0xFEFE5C", VA = "0xFEFE5C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700006E")]
		public bool overrideStencilMask
		{
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0xFEFE64", Offset = "0xFEFE64", VA = "0xFEFE64")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700006F")]
		public int stencilBias
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0xFEFE6C", Offset = "0xFEFE6C", VA = "0xFEFE6C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000070")]
		public bool overrideStencilBias
		{
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0xFEFE74", Offset = "0xFEFE74", VA = "0xFEFE74")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0xFEFE7C", Offset = "0xFEFE7C", VA = "0xFEFE7C")]
		public TunnellingPresetMobile()
		{
		}
	}
}
namespace Sigtrap.VrTunnellingPro.Examples
{
	[Token(Token = "0x2000016")]
	public class VRTP_ExampleMovement : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000017")]
		private struct Preset
		{
			[Token(Token = "0x4000176")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public KeyCode key;

			[Token(Token = "0x4000177")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public GameObject[] worldObjects;

			[Token(Token = "0x4000178")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TunnellingPreset postPreset;
		}

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _disableModes;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _rotSensitivity;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _movSensitivity;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Cubemap[] _skyboxes;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject[] _cages;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Preset[] _modePresets;

		[Token(Token = "0x400016A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _currentMode;

		[Token(Token = "0x400016B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private bool _hasWarnedInput;

		[Token(Token = "0x400016C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Tunnelling _tunnelling;

		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private CharacterController _char;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _currentSkybox;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _currentCage;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 _speedCurrent;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 _speedSlew;

		[Token(Token = "0x4000172")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _speedSmoothing;

		[Token(Token = "0x4000173")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float _rotCurrent;

		[Token(Token = "0x4000174")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float _rotSlew;

		[Token(Token = "0x4000175")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _rotSmoothing;

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xFEFEAC", Offset = "0xFEFEAC", VA = "0xFEFEAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xFEFF3C", Offset = "0xFEFF3C", VA = "0xFEFF3C")]
		private void Update()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xFF03E4", Offset = "0xFF03E4", VA = "0xFF03E4")]
		private void SetPreset(int i)
		{
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0xFF0524", Offset = "0xFF0524", VA = "0xFF0524")]
		public VRTP_ExampleMovement()
		{
		}
	}
}
namespace Umbrace.Unity.PurePool
{
	[Token(Token = "0x2000018")]
	public class SetLoggingLevels : MonoBehaviour
	{
		[Token(Token = "0x4000179")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool informationLoggingEnabled;

		[Token(Token = "0x400017A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool warningLoggingEnabled;

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool errorLoggingEnabled;

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xFF0538", Offset = "0xFF0538", VA = "0xFF0538")]
		private void Start()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0xFF05B0", Offset = "0xFF05B0", VA = "0xFF05B0")]
		public SetLoggingLevels()
		{
		}
	}
	[Token(Token = "0x2000019")]
	public static class StaticComponentPoolManager
	{
		[Token(Token = "0x17000071")]
		public static ComponentPoolManager Instance
		{
			[Token(Token = "0x60000E9")]
			[Address(RVA = "0xFF05B8", Offset = "0xFF05B8", VA = "0xFF05B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xFF05C0", Offset = "0xFF05C0", VA = "0xFF05C0")]
		public static Component Acquire(this Type componentType)
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xFF0618", Offset = "0xFF0618", VA = "0xFF0618")]
		public static Component Acquire(this Type componentType, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0xFF0650", Offset = "0xFF0650", VA = "0xFF0650")]
		public static Component Acquire(this Type componentType, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xFF06D0", Offset = "0xFF06D0", VA = "0xFF06D0")]
		public static Component Acquire(this Type componentType, Transform parent, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60000EE")]
		public static Component Acquire<T>() where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000EF")]
		public static Component Acquire<T>(Transform parent) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000F0")]
		public static Component Acquire<T>(Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000F1")]
		public static Component Acquire<T>(Transform parent, Vector3 position, Quaternion rotation) where T : Component
		{
			return null;
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0xFF0760", Offset = "0xFF0760", VA = "0xFF0760")]
		public static void Release(this Component instance)
		{
		}
	}
	[Token(Token = "0x200001A")]
	public static class StaticNamedPoolManager
	{
		[Token(Token = "0x17000072")]
		public static NamedGameObjectPoolManager Instance
		{
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0xFF07B8", Offset = "0xFF07B8", VA = "0xFF07B8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0xFF07C0", Offset = "0xFF07C0", VA = "0xFF07C0")]
		public static GameObject Acquire(string sourceObject)
		{
			return null;
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0xFF07E8", Offset = "0xFF07E8", VA = "0xFF07E8")]
		public static GameObject Acquire(string sourceObject, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0xFF0820", Offset = "0xFF0820", VA = "0xFF0820")]
		public static GameObject Acquire(string sourceObject, Transform parent, bool spawnInWorldSpace)
		{
			return null;
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0xFF0860", Offset = "0xFF0860", VA = "0xFF0860")]
		public static GameObject Acquire(string sourceObject, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60000F8")]
		[Address(RVA = "0xFF08E0", Offset = "0xFF08E0", VA = "0xFF08E0")]
		public static GameObject Acquire(string sourceObject, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}
	}
	[Token(Token = "0x200001B")]
	public static class StaticPoolManager
	{
		[Token(Token = "0x17000073")]
		public static GameObjectPoolManager Instance
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0xFF0970", Offset = "0xFF0970", VA = "0xFF0970")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000FA")]
		[Address(RVA = "0xFF0978", Offset = "0xFF0978", VA = "0xFF0978")]
		public static GameObject Acquire(this GameObject sourceObject)
		{
			return null;
		}

		[Token(Token = "0x60000FB")]
		[Address(RVA = "0xFF09D0", Offset = "0xFF09D0", VA = "0xFF09D0")]
		public static GameObject Acquire(this GameObject sourceObject, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60000FC")]
		[Address(RVA = "0xFF0A08", Offset = "0xFF0A08", VA = "0xFF0A08")]
		public static GameObject Acquire(this GameObject sourceObject, Transform parent, bool spawnInWorldSpace)
		{
			return null;
		}

		[Token(Token = "0x60000FD")]
		[Address(RVA = "0xFF0A48", Offset = "0xFF0A48", VA = "0xFF0A48")]
		public static GameObject Acquire(this GameObject sourceObject, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Token(Token = "0x60000FE")]
		[Address(RVA = "0xFF0AC8", Offset = "0xFF0AC8", VA = "0xFF0AC8")]
		public static GameObject Acquire(this GameObject sourceObject, Vector3 position, Quaternion rotation, Transform parent)
		{
			return null;
		}

		[Token(Token = "0x60000FF")]
		[Address(RVA = "0xFF0B58", Offset = "0xFF0B58", VA = "0xFF0B58")]
		public static void Release(this GameObject instance)
		{
		}

		[Token(Token = "0x6000100")]
		[Address(RVA = "0xFF0BB0", Offset = "0xFF0BB0", VA = "0xFF0BB0")]
		public static void Release(this GameObject instance, float delay)
		{
		}
	}
}
namespace RootMotion
{
	[Token(Token = "0x200001C")]
	[AddComponentMenu("Scripts/RootMotion/Baker")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page3.html")]
	public abstract class Baker : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200001D")]
		public enum Mode
		{
			[Token(Token = "0x400018B")]
			AnimationClips,
			[Token(Token = "0x400018C")]
			AnimationStates,
			[Token(Token = "0x400018D")]
			PlayableDirector,
			[Token(Token = "0x400018E")]
			Realtime
		}

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(1f, 90f)]
		[Tooltip("In AnimationClips, AnimationStates or PlayableDirector mode - the frame rate at which the animation clip will be sampled. In Realtime mode - the frame rate at which the pose will be sampled. With the latter, the frame rate is not guaranteed if the player is not able to reach it.")]
		public int frameRate;

		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 0.1f)]
		[Tooltip("Maximum allowed error for keyframe reduction.")]
		public float keyReductionError;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("AnimationClips mode can be used to bake a batch of AnimationClips directly without the need of setting up an AnimatorController. AnimationStates mode is useful for when you need to set up a more complex rig with layers and AvatarMasks in Mecanim. PlayableDirector mode bakes a Timeline. Realtime mode is for continuous baking of gameplay, ragdoll phsysics or PuppetMaster dynamics.")]
		public Mode mode;

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("AnimationClips to bake.")]
		public AnimationClip[] animationClips;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The name of the AnimationStates to bake (must be on the base layer) in the Animator above (Right-click on this component header and select 'Find Animation States' to have Baker fill those in automatically, required that state names match with the names of the clips used in them).")]
		public string[] animationStates;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Sets the baked animation clip to loop time and matches the last frame keys with the first. Note that when overwriting a previously baked clip, AnimationClipSettings will be copied from the existing clip.")]
		public bool loop;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The folder to save the baked AnimationClips to.")]
		public string saveToFolder;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("String that will be added to each clip or animation state name for the saved clip. For example if your animation state/clip names were 'Idle' and 'Walk', then with '_Baked' as Append Name, the Baker will create 'Idle_Baked' and 'Walk_Baked' animation clips.")]
		public string appendName;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Name of the created AnimationClip file.")]
		public string saveName;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[HideInInspector]
		public Animator animator;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[HideInInspector]
		public PlayableDirector director;

		[Token(Token = "0x17000074")]
		public bool isBaking
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0xFF0D28", Offset = "0xFF0D28", VA = "0xFF0D28")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0xFF0D30", Offset = "0xFF0D30", VA = "0xFF0D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000075")]
		public float bakingProgress
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0xFF0D3C", Offset = "0xFF0D3C", VA = "0xFF0D3C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0xFF0D44", Offset = "0xFF0D44", VA = "0xFF0D44")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000076")]
		protected float clipLength
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0xFF0D4C", Offset = "0xFF0D4C", VA = "0xFF0D4C")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0xFF0D54", Offset = "0xFF0D54", VA = "0xFF0D54")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000101")]
		[Address(RVA = "0xFF0C18", Offset = "0xFF0C18", VA = "0xFF0C18")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000102")]
		[Address(RVA = "0xFF0C5C", Offset = "0xFF0C5C", VA = "0xFF0C5C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000103")]
		[Address(RVA = "0xFF0CA0", Offset = "0xFF0CA0", VA = "0xFF0CA0")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000104")]
		[Address(RVA = "0xFF0CE4", Offset = "0xFF0CE4", VA = "0xFF0CE4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000109")]
		protected abstract Transform GetCharacterRoot();

		[Token(Token = "0x600010A")]
		protected abstract void OnStartBaking();

		[Token(Token = "0x600010B")]
		protected abstract void OnSetLoopFrame(float time);

		[Token(Token = "0x600010C")]
		protected abstract void OnSetCurves(ref AnimationClip clip);

		[Token(Token = "0x600010D")]
		protected abstract void OnSetKeyframes(float time, bool lastFrame);

		[Token(Token = "0x6000110")]
		[Address(RVA = "0xFF0D5C", Offset = "0xFF0D5C", VA = "0xFF0D5C")]
		public void BakeClip()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xFF0D60", Offset = "0xFF0D60", VA = "0xFF0D60")]
		public void StartBaking()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0xFF0D64", Offset = "0xFF0D64", VA = "0xFF0D64")]
		public void StopBaking()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xFF0D68", Offset = "0xFF0D68", VA = "0xFF0D68")]
		protected Baker()
		{
		}
	}
	[Token(Token = "0x200001E")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("If true, produced AnimationClips will be marked as Legacy and usable with the Legacy animation system.")]
		public bool markAsLegacy;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Root Transform of the hierarchy to bake.")]
		public Transform root;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("Root Node used for root motion.")]
		public Transform rootNode;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Tooltip("List of Transforms to ignore, rotation curves will not be baked for these Transforms.")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Tooltip("LocalPosition curves will be baked for these Transforms only. If you are baking a character, the pelvis bone should be added to this array.")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xFF0E90", Offset = "0xFF0E90", VA = "0xFF0E90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xFF12D4", Offset = "0xFF12D4", VA = "0xFF12D4", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0xFF12DC", Offset = "0xFF12DC", VA = "0xFF12DC", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xFF1518", Offset = "0xFF1518", VA = "0xFF1518", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0xFF177C", Offset = "0xFF177C", VA = "0xFF177C", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xFF1A94", Offset = "0xFF1A94", VA = "0xFF1A94", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xFF10BC", Offset = "0xFF10BC", VA = "0xFF10BC")]
		private bool IsIgnored(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xFF1174", Offset = "0xFF1174", VA = "0xFF1174")]
		private bool BakePosition(Transform t)
		{
			return default(bool);
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0xFF1CF4", Offset = "0xFF1CF4", VA = "0xFF1CF4")]
		public GenericBaker()
		{
		}
	}
	[Token(Token = "0x200001F")]
	public class TQ
	{
		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 t;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion q;

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xFF1D5C", Offset = "0xFF1D5C", VA = "0xFF1D5C")]
		public TQ(Vector3 translation, Quaternion rotation)
		{
		}
	}
	[Token(Token = "0x2000020")]
	public class AvatarUtility
	{
		[Token(Token = "0x600011E")]
		[Address(RVA = "0xFF1DC0", Offset = "0xFF1DC0", VA = "0xFF1DC0")]
		public static Quaternion GetPostRotation(Avatar avatar, AvatarIKGoal avatarIKGoal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xFF201C", Offset = "0xFF201C", VA = "0xFF201C")]
		public static TQ GetIKGoalTQ(Avatar avatar, float humanScale, AvatarIKGoal avatarIKGoal, TQ bodyPositionRotation, TQ boneTQ)
		{
			return null;
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xFF1FFC", Offset = "0xFF1FFC", VA = "0xFF1FFC")]
		public static HumanBodyBones HumanIDFromAvatarIKGoal(AvatarIKGoal avatarIKGoal)
		{
			return default(HumanBodyBones);
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xFF268C", Offset = "0xFF268C", VA = "0xFF268C")]
		public AvatarUtility()
		{
		}
	}
	[Token(Token = "0x2000021")]
	public static class BakerUtilities
	{
		[Token(Token = "0x6000122")]
		[Address(RVA = "0xFF2694", Offset = "0xFF2694", VA = "0xFF2694")]
		public static void ReduceKeyframes(AnimationCurve curve, float maxError)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xFF26CC", Offset = "0xFF26CC", VA = "0xFF26CC")]
		public static Keyframe[] GetReducedKeyframes(AnimationCurve curve, float maxError)
		{
			return null;
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0xFF2A90", Offset = "0xFF2A90", VA = "0xFF2A90")]
		public static void SetLoopFrame(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xFF2C70", Offset = "0xFF2C70", VA = "0xFF2C70")]
		public static void SetTangentMode(AnimationCurve curve)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xFF2C74", Offset = "0xFF2C74", VA = "0xFF2C74")]
		public static Quaternion EnsureQuaternionContinuity(Quaternion lastQ, Quaternion q)
		{
			return default(Quaternion);
		}
	}
	[Serializable]
	[Token(Token = "0x2000022")]
	public class BakerHumanoidQT
	{
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Transform transform;

		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string Qx;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string Qy;

		[Token(Token = "0x400019C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string Qz;

		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string Qw;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private string Tx;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string Ty;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string Tz;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve rotX;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AnimationCurve rotY;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public AnimationCurve rotW;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve posX;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public AnimationCurve posY;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public AnimationCurve posZ;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AvatarIKGoal goal;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Quaternion lastQ;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private bool lastQSet;

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xFF2E08", Offset = "0xFF2E08", VA = "0xFF2E08")]
		public BakerHumanoidQT(string name)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0xFF316C", Offset = "0xFF316C", VA = "0xFF316C")]
		public BakerHumanoidQT(Transform transform, AvatarIKGoal goal, string name)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xFF2FD4", Offset = "0xFF2FD4", VA = "0xFF2FD4")]
		public void Reset()
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0xFF3354", Offset = "0xFF3354", VA = "0xFF3354")]
		public void SetIKKeyframes(float time, Avatar avatar, Transform root, float humanScale, Vector3 bodyPosition, Quaternion bodyRotation)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xFF36E4", Offset = "0xFF36E4", VA = "0xFF36E4")]
		public void SetKeyframes(float time, Vector3 pos, Quaternion rot)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xFF37D4", Offset = "0xFF37D4", VA = "0xFF37D4")]
		public void MoveLastKeyframes(float time)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xFF38B8", Offset = "0xFF38B8", VA = "0xFF38B8")]
		public void SetLoopFrame(float time)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0xFF383C", Offset = "0xFF383C", VA = "0xFF383C")]
		private void MoveLastKeyframe(float time, AnimationCurve curve)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xFF3920", Offset = "0xFF3920", VA = "0xFF3920")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0xFF39C8", Offset = "0xFF39C8", VA = "0xFF39C8")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000023")]
	public class BakerMuscle
	{
		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AnimationCurve curve;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int muscleIndex;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string propertyName;

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xFF3CB4", Offset = "0xFF3CB4", VA = "0xFF3CB4")]
		public BakerMuscle(int muscleIndex)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xFF3D24", Offset = "0xFF3D24", VA = "0xFF3D24")]
		private string MuscleNameToPropertyName(string n)
		{
			return null;
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xFF47C0", Offset = "0xFF47C0", VA = "0xFF47C0")]
		public void MultiplyLength(AnimationCurve curve, float mlp)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0xFF4868", Offset = "0xFF4868", VA = "0xFF4868")]
		public void SetCurves(ref AnimationClip clip, float maxError, float lengthMlp)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xFF4758", Offset = "0xFF4758", VA = "0xFF4758")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0xFF495C", Offset = "0xFF495C", VA = "0xFF495C")]
		public void SetKeyframe(float time, float[] muscles)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0xFF4998", Offset = "0xFF4998", VA = "0xFF4998")]
		public void SetLoopFrame(float time)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000024")]
	public class BakerTransform
	{
		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AnimationCurve posX;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve posY;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve posZ;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve rotX;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve rotY;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve rotZ;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AnimationCurve rotW;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string relativePath;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool recordPosition;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 relativePosition;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool isRootNode;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Quaternion relativeRotation;

		[Token(Token = "0x6000138")]
		[Address(RVA = "0xFF122C", Offset = "0xFF122C", VA = "0xFF122C")]
		public BakerTransform(Transform transform, Transform root, bool recordPosition, bool isRootNode)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0xFF1504", Offset = "0xFF1504", VA = "0xFF1504")]
		public void SetRelativeSpace(Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0xFF17E0", Offset = "0xFF17E0", VA = "0xFF17E0")]
		public void SetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0xFF49A0", Offset = "0xFF49A0", VA = "0xFF49A0")]
		private void AddRootMotionCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0xFF13AC", Offset = "0xFF13AC", VA = "0xFF13AC")]
		public void Reset()
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0xFF4C28", Offset = "0xFF4C28", VA = "0xFF4C28")]
		public void ReduceKeyframes(float maxError)
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0xFF1B00", Offset = "0xFF1B00", VA = "0xFF1B00")]
		public void SetKeyframes(float time)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0xFF1584", Offset = "0xFF1584", VA = "0xFF1584")]
		public void AddLoopFrame(float time)
		{
		}
	}
	[Token(Token = "0x2000025")]
	public class HumanoidBaker : Baker
	{
		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Tooltip("Should the hand IK curves be added to the animation? Disable this if the original hand positions are not important when using the clip on another character via Humanoid retargeting.")]
		public bool bakeHandIK;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("Max keyframe reduction error for the Root.Q/T, LeftFoot IK and RightFoot IK channels. Having a larger error value for 'Key Reduction Error' and a smaller one for this enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(0f, 0.1f)]
		public float IKKeyReductionError;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Tooltip("Frame rate divider for the muscle curves. If you have 'Frame Rate' set to 30, and this value set to 3, the muscle curves will be baked at 10 fps. Only the Root Q/T and Hand and Foot IK curves will be baked at 30. This enables you to optimize clip data size without the floating feet effect by enabling 'Foot IK' in the Animator.")]
		[Range(1f, 9f)]
		public int muscleFrameRateDiv;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BakerMuscle[] bakerMuscles;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private BakerHumanoidQT rootQT;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private BakerHumanoidQT leftFootQT;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private BakerHumanoidQT rightFootQT;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private BakerHumanoidQT leftHandQT;

		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private BakerHumanoidQT rightHandQT;

		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private float[] muscles;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private HumanPose pose;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private HumanPoseHandler handler;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Vector3 bodyPosition;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion bodyRotation;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private int mN;

		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion lastBodyRotation;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0xFF4C90", Offset = "0xFF4C90", VA = "0xFF4C90")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0xFF51F0", Offset = "0xFF51F0", VA = "0xFF51F0", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0xFF520C", Offset = "0xFF520C", VA = "0xFF520C", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0xFF52E8", Offset = "0xFF52E8", VA = "0xFF52E8", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0xFF53A4", Offset = "0xFF53A4", VA = "0xFF53A4", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0xFF5544", Offset = "0xFF5544", VA = "0xFF5544", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000146")]
		[Address(RVA = "0xFF5858", Offset = "0xFF5858", VA = "0xFF5858")]
		private void UpdateHumanPose()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xFF5930", Offset = "0xFF5930", VA = "0xFF5930")]
		public HumanoidBaker()
		{
		}
	}
	[Token(Token = "0x2000026")]
	public class CameraController : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000027")]
		public enum UpdateMode
		{
			[Token(Token = "0x40001F2")]
			Update,
			[Token(Token = "0x40001F3")]
			FixedUpdate,
			[Token(Token = "0x40001F4")]
			LateUpdate,
			[Token(Token = "0x40001F5")]
			FixedLateUpdate
		}

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rotationSpace;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateMode updateMode;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
		[Header("Position")]
		public bool smoothFollow;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 offset;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float followSpeed;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Rotation")]
		public float rotationSensitivity;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float yMinLimit;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float yMaxLimit;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool rotateAlways;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		public bool rotateOnLeftButton;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E")]
		public bool rotateOnRightButton;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F")]
		public bool rotateOnMiddleButton;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Header("Distance")]
		public float distance;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float maxDistance;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float zoomSpeed;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float zoomSensitivity;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Header("Blocking")]
		public LayerMask blockingLayers;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float blockingRadius;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float blockingSmoothTime;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public float blockingOriginOffset;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0f, 1f)]
		public float blockedOffset;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 targetDistance;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 position;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion rotation;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 smoothPosition;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Camera cam;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool fixedFrame;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float fixedDeltaTime;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Quaternion r;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Vector3 lastUp;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private float blockedDistance;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private float blockedDistanceV;

		[Token(Token = "0x17000077")]
		public float x
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0xFF59E0", Offset = "0xFF59E0", VA = "0xFF59E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0xFF59E8", Offset = "0xFF59E8", VA = "0xFF59E8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000078")]
		public float y
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xFF59F0", Offset = "0xFF59F0", VA = "0xFF59F0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0xFF59F8", Offset = "0xFF59F8", VA = "0xFF59F8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000079")]
		public float distanceTarget
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xFF5A00", Offset = "0xFF5A00", VA = "0xFF5A00")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0xFF5A08", Offset = "0xFF5A08", VA = "0xFF5A08")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700007A")]
		private float zoomAdd
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0xFF6470", Offset = "0xFF6470", VA = "0xFF6470")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0xFF5A10", Offset = "0xFF5A10", VA = "0xFF5A10")]
		public void SetAngles(Quaternion rotation)
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0xFF5A48", Offset = "0xFF5A48", VA = "0xFF5A48")]
		public void SetAngles(float yaw, float pitch)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0xFF5A50", Offset = "0xFF5A50", VA = "0xFF5A50", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0xFF5B88", Offset = "0xFF5B88", VA = "0xFF5B88", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0xFF5BD0", Offset = "0xFF5BD0", VA = "0xFF5BD0", Slot = "6")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0xFF5C28", Offset = "0xFF5C28", VA = "0xFF5C28", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0xFF5C80", Offset = "0xFF5C80", VA = "0xFF5C80")]
		public void UpdateInput()
		{
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xFF5BB4", Offset = "0xFF5BB4", VA = "0xFF5BB4")]
		public void UpdateTransform()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0xFF5E0C", Offset = "0xFF5E0C", VA = "0xFF5E0C")]
		public void UpdateTransform(float deltaTime)
		{
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0xFF6434", Offset = "0xFF6434", VA = "0xFF6434")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0xFF64DC", Offset = "0xFF64DC", VA = "0xFF64DC")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000028")]
	public class CameraControllerFPS : MonoBehaviour
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotationSensitivity;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float yMinLimit;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float yMaxLimit;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private float x;

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float y;

		[Token(Token = "0x600015A")]
		[Address(RVA = "0xFF65A4", Offset = "0xFF65A4", VA = "0xFF65A4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0xFF65D0", Offset = "0xFF65D0", VA = "0xFF65D0")]
		public void LateUpdate()
		{
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0xFF67F4", Offset = "0xFF67F4", VA = "0xFF67F4")]
		private float ClampAngle(float angle, float min, float max)
		{
			return default(float);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0xFF6830", Offset = "0xFF6830", VA = "0xFF6830")]
		public CameraControllerFPS()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000029")]
	public enum Axis
	{
		[Token(Token = "0x40001FC")]
		X,
		[Token(Token = "0x40001FD")]
		Y,
		[Token(Token = "0x40001FE")]
		Z
	}
	[Token(Token = "0x200002A")]
	public class AxisTools
	{
		[Token(Token = "0x600015E")]
		[Address(RVA = "0xFF684C", Offset = "0xFF684C", VA = "0xFF684C")]
		public static Vector3 ToVector3(Axis axis)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xFF692C", Offset = "0xFF692C", VA = "0xFF692C")]
		public static Axis ToAxis(Vector3 v)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xFF6964", Offset = "0xFF6964", VA = "0xFF6964")]
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xFF6AAC", Offset = "0xFF6AAC", VA = "0xFF6AAC")]
		public static Axis GetAxisToDirection(Transform t, Vector3 direction)
		{
			return default(Axis);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0xFF6A60", Offset = "0xFF6A60", VA = "0xFF6A60")]
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xFF6BA8", Offset = "0xFF6BA8", VA = "0xFF6BA8")]
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0xFF6BEC", Offset = "0xFF6BEC", VA = "0xFF6BEC")]
		public static Vector3 GetAxisVectorToDirection(Quaternion r, Vector3 direction)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0xFF7078", Offset = "0xFF7078", VA = "0xFF7078")]
		public AxisTools()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200002B")]
	public class BipedLimbOrientations
	{
		[Serializable]
		[Token(Token = "0x200002C")]
		public class LimbOrientation
		{
			[Token(Token = "0x4000203")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 upperBoneForwardAxis;

			[Token(Token = "0x4000204")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 lowerBoneForwardAxis;

			[Token(Token = "0x4000205")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 lastBoneLeftAxis;

			[Token(Token = "0x6000169")]
			[Address(RVA = "0xFF73AC", Offset = "0xFF73AC", VA = "0xFF73AC")]
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis)
			{
			}
		}

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LimbOrientation leftArm;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbOrientation rightArm;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbOrientation leftLeg;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LimbOrientation rightLeg;

		[Token(Token = "0x1700007B")]
		public static BipedLimbOrientations UMA
		{
			[Token(Token = "0x6000167")]
			[Address(RVA = "0xFF70F4", Offset = "0xFF70F4", VA = "0xFF70F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		public static BipedLimbOrientations MaxBiped
		{
			[Token(Token = "0x6000168")]
			[Address(RVA = "0xFF7420", Offset = "0xFF7420", VA = "0xFF7420")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0xFF7080", Offset = "0xFF7080", VA = "0xFF7080")]
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg)
		{
		}
	}
	[Token(Token = "0x200002D")]
	public static class BipedNaming
	{
		[Serializable]
		[Token(Token = "0x200002E")]
		public enum BoneType
		{
			[Token(Token = "0x4000219")]
			Unassigned,
			[Token(Token = "0x400021A")]
			Spine,
			[Token(Token = "0x400021B")]
			Head,
			[Token(Token = "0x400021C")]
			Arm,
			[Token(Token = "0x400021D")]
			Leg,
			[Token(Token = "0x400021E")]
			Tail,
			[Token(Token = "0x400021F")]
			Eye
		}

		[Serializable]
		[Token(Token = "0x200002F")]
		public enum BoneSide
		{
			[Token(Token = "0x4000221")]
			Center,
			[Token(Token = "0x4000222")]
			Left,
			[Token(Token = "0x4000223")]
			Right
		}

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static string[] typeLeft;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static string[] typeRight;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static string[] typeSpine;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static string[] typeHead;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static string[] typeArm;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static string[] typeLeg;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static string[] typeTail;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public static string[] typeEye;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public static string[] typeExclude;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public static string[] typeExcludeSpine;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static string[] typeExcludeHead;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public static string[] typeExcludeArm;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public static string[] typeExcludeLeg;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public static string[] typeExcludeTail;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public static string[] typeExcludeEye;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public static string[] pelvis;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public static string[] hand;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public static string[] foot;

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xFF76D8", Offset = "0xFF76D8", VA = "0xFF76D8")]
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xFF79A4", Offset = "0xFF79A4", VA = "0xFF79A4")]
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0xFF7BE0", Offset = "0xFF7BE0", VA = "0xFF7BE0")]
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xFF7C54", Offset = "0xFF7C54", VA = "0xFF7C54")]
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0xFF7CE8", Offset = "0xFF7CE8", VA = "0xFF7CE8")]
		public static Transform GetNamingMatch(Transform[] transforms, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0xFF788C", Offset = "0xFF788C", VA = "0xFF788C")]
		public static BoneType GetBoneType(string boneName)
		{
			return default(BoneType);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0xFF7B58", Offset = "0xFF7B58", VA = "0xFF7B58")]
		public static BoneSide GetBoneSide(string boneName)
		{
			return default(BoneSide);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0xFF8420", Offset = "0xFF8420", VA = "0xFF8420")]
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center, params string[][] namings)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0xFF8278", Offset = "0xFF8278", VA = "0xFF8278")]
		private static bool isLeft(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0xFF834C", Offset = "0xFF834C", VA = "0xFF834C")]
		private static bool isRight(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0xFF7ED0", Offset = "0xFF7ED0", VA = "0xFF7ED0")]
		private static bool isSpine(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0xFF7F6C", Offset = "0xFF7F6C", VA = "0xFF7F6C")]
		private static bool isHead(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0xFF8008", Offset = "0xFF8008", VA = "0xFF8008")]
		private static bool isArm(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0xFF80A4", Offset = "0xFF80A4", VA = "0xFF80A4")]
		private static bool isLeg(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0xFF8140", Offset = "0xFF8140", VA = "0xFF8140")]
		private static bool isTail(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0xFF81DC", Offset = "0xFF81DC", VA = "0xFF81DC")]
		private static bool isEye(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0xFF8608", Offset = "0xFF8608", VA = "0xFF8608")]
		private static bool isTypeExclude(string boneName)
		{
			return default(bool);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0xFF7DFC", Offset = "0xFF7DFC", VA = "0xFF7DFC")]
		private static bool matchesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0xFF8584", Offset = "0xFF8584", VA = "0xFF8584")]
		private static bool excludesNaming(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0xFF8668", Offset = "0xFF8668", VA = "0xFF8668")]
		private static bool matchesLastLetter(string boneName, string[] namingConvention)
		{
			return default(bool);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0xFF8728", Offset = "0xFF8728", VA = "0xFF8728")]
		private static bool LastLetterIs(string boneName, string letter)
		{
			return default(bool);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0xFF8510", Offset = "0xFF8510", VA = "0xFF8510")]
		private static string firstLetter(string boneName)
		{
			return null;
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0xFF84A0", Offset = "0xFF84A0", VA = "0xFF84A0")]
		private static string lastLetter(string boneName)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000030")]
	public class BipedReferences
	{
		[Token(Token = "0x2000031")]
		public struct AutoDetectParams
		{
			[Token(Token = "0x4000235")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool legsParentInSpine;

			[Token(Token = "0x4000236")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool includeEyes;

			[Token(Token = "0x1700007F")]
			public static AutoDetectParams Default
			{
				[Token(Token = "0x600019B")]
				[Address(RVA = "0xFFF1F0", Offset = "0xFFF1F0", VA = "0xFFF1F0")]
				get
				{
					return default(AutoDetectParams);
				}
			}

			[Token(Token = "0x600019A")]
			[Address(RVA = "0xFFF1DC", Offset = "0xFFF1DC", VA = "0xFFF1DC")]
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes)
			{
			}
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform root;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform pelvis;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform leftThigh;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftCalf;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftFoot;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform rightThigh;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform rightCalf;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform rightFoot;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform leftUpperArm;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftForearm;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform leftHand;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform rightUpperArm;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform rightForearm;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform rightHand;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Transform head;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] spine;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Transform[] eyes;

		[Token(Token = "0x1700007D")]
		public virtual bool isFilled
		{
			[Token(Token = "0x6000182")]
			[Address(RVA = "0xFFB518", Offset = "0xFFB518", VA = "0xFFB518", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700007E")]
		public bool isEmpty
		{
			[Token(Token = "0x6000183")]
			[Address(RVA = "0xFFB874", Offset = "0xFFB874", VA = "0xFFB874")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0xFFB884", Offset = "0xFFB884", VA = "0xFFB884", Slot = "5")]
		public virtual bool IsEmpty(bool includeRoot)
		{
			return default(bool);
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0xFFBC10", Offset = "0xFFBC10", VA = "0xFFBC10", Slot = "6")]
		public virtual bool Contains(Transform t, bool ignoreRoot = false)
		{
			return default(bool);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0xFFBFA0", Offset = "0xFFBFA0", VA = "0xFFBFA0")]
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0xFFC6C4", Offset = "0xFFC6C4", VA = "0xFFC6C4")]
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0xFFC234", Offset = "0xFFC234", VA = "0xFFC234")]
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0xFFCF50", Offset = "0xFFCF50", VA = "0xFFCF50")]
		public static bool SetupError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0xFFD03C", Offset = "0xFFD03C", VA = "0xFFD03C")]
		public static bool SetupWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0xFFDB5C", Offset = "0xFFDB5C", VA = "0xFFDB5C")]
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm)
		{
			return default(bool);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0xFFD968", Offset = "0xFFD968", VA = "0xFFD968")]
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0xFFD708", Offset = "0xFFD708", VA = "0xFFD708")]
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams)
		{
			return default(bool);
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0xFFD0D8", Offset = "0xFFD0D8", VA = "0xFFD0D8")]
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0xFFDA5C", Offset = "0xFFDA5C", VA = "0xFFDA5C")]
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0xFFDC3C", Offset = "0xFFDC3C", VA = "0xFFDC3C")]
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0xFFE7E4", Offset = "0xFFE7E4", VA = "0xFFE7E4")]
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0xFFE28C", Offset = "0xFFE28C", VA = "0xFFE28C")]
		private static bool SpineError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xFFEB30", Offset = "0xFFEB30", VA = "0xFFEB30")]
		private static bool SpineWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xFFE5EC", Offset = "0xFFE5EC", VA = "0xFFE5EC")]
		private static bool EyesError(BipedReferences references, ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xFFEB38", Offset = "0xFFEB38", VA = "0xFFEB38")]
		private static bool EyesWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0xFFEB40", Offset = "0xFFEB40", VA = "0xFFEB40")]
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xFFED00", Offset = "0xFFED00", VA = "0xFFED00")]
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0xFFF174", Offset = "0xFFF174", VA = "0xFFF174")]
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0xFFC1B4", Offset = "0xFFC1B4", VA = "0xFFC1B4")]
		public BipedReferences()
		{
		}
	}
	[Token(Token = "0x2000032")]
	public class Comments : MonoBehaviour
	{
		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Multiline]
		public string text;

		[Token(Token = "0x600019C")]
		[Address(RVA = "0xFFF1F8", Offset = "0xFFF1F8", VA = "0xFFF1F8")]
		public Comments()
		{
		}
	}
	[Token(Token = "0x2000033")]
	public class DemoGUIMessage : MonoBehaviour
	{
		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Color color;

		[Token(Token = "0x600019D")]
		[Address(RVA = "0xFFF200", Offset = "0xFFF200", VA = "0xFFF200")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0xFFF2F8", Offset = "0xFFF2F8", VA = "0xFFF2F8")]
		public DemoGUIMessage()
		{
		}
	}
	[Token(Token = "0x2000034")]
	public class Hierarchy
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0xFFF0F0", Offset = "0xFFF0F0", VA = "0xFFF0F0")]
		public static bool HierarchyIsValid(Transform[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0xFFEFE4", Offset = "0xFFEFE4", VA = "0xFFEFE4")]
		public static UnityEngine.Object ContainsDuplicate(UnityEngine.Object[] objects)
		{
			return null;
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0xFFD240", Offset = "0xFFD240", VA = "0xFFD240")]
		public static bool IsAncestor(Transform transform, Transform ancestor)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0xFFD858", Offset = "0xFFD858", VA = "0xFFD858")]
		public static bool ContainsChild(Transform transform, Transform child)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0xFFD4C0", Offset = "0xFFD4C0", VA = "0xFFD4C0")]
		public static void AddAncestors(Transform transform, Transform blocker, ref Transform[] array)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0xFFF308", Offset = "0xFFF308", VA = "0xFFF308")]
		public static Transform GetAncestor(Transform transform, int minChildCount)
		{
			return null;
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0xFFD370", Offset = "0xFFD370", VA = "0xFFD370")]
		public static Transform GetFirstCommonAncestor(Transform t1, Transform t2)
		{
			return null;
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0xFFF3FC", Offset = "0xFFF3FC", VA = "0xFFF3FC")]
		public static Transform GetFirstCommonAncestor(Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0xFFF768", Offset = "0xFFF768", VA = "0xFFF768")]
		public static Transform GetFirstCommonAncestorRecursive(Transform transform, Transform[] transforms)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0xFFF560", Offset = "0xFFF560", VA = "0xFFF560")]
		public static bool IsCommonAncestor(Transform transform, Transform[] transforms)
		{
			return default(bool);
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0xFFF8F0", Offset = "0xFFF8F0", VA = "0xFFF8F0")]
		public Hierarchy()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class InspectorComment : PropertyAttribute
	{
		[Token(Token = "0x400023A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400023B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0xFFF8F8", Offset = "0xFFF8F8", VA = "0xFFF8F8")]
		public InspectorComment(string name)
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xFFF980", Offset = "0xFFF980", VA = "0xFFF980")]
		public InspectorComment(string name, string color)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000036")]
	public enum InterpolationMode
	{
		[Token(Token = "0x400023D")]
		None,
		[Token(Token = "0x400023E")]
		InOutCubic,
		[Token(Token = "0x400023F")]
		InOutQuintic,
		[Token(Token = "0x4000240")]
		InOutSine,
		[Token(Token = "0x4000241")]
		InQuintic,
		[Token(Token = "0x4000242")]
		InQuartic,
		[Token(Token = "0x4000243")]
		InCubic,
		[Token(Token = "0x4000244")]
		InQuadratic,
		[Token(Token = "0x4000245")]
		InElastic,
		[Token(Token = "0x4000246")]
		InElasticSmall,
		[Token(Token = "0x4000247")]
		InElasticBig,
		[Token(Token = "0x4000248")]
		InSine,
		[Token(Token = "0x4000249")]
		InBack,
		[Token(Token = "0x400024A")]
		OutQuintic,
		[Token(Token = "0x400024B")]
		OutQuartic,
		[Token(Token = "0x400024C")]
		OutCubic,
		[Token(Token = "0x400024D")]
		OutInCubic,
		[Token(Token = "0x400024E")]
		OutInQuartic,
		[Token(Token = "0x400024F")]
		OutElastic,
		[Token(Token = "0x4000250")]
		OutElasticSmall,
		[Token(Token = "0x4000251")]
		OutElasticBig,
		[Token(Token = "0x4000252")]
		OutSine,
		[Token(Token = "0x4000253")]
		OutBack,
		[Token(Token = "0x4000254")]
		OutBackCubic,
		[Token(Token = "0x4000255")]
		OutBackQuartic,
		[Token(Token = "0x4000256")]
		BackInCubic,
		[Token(Token = "0x4000257")]
		BackInQuartic
	}
	[Token(Token = "0x2000037")]
	public class Interp
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xFFFA0C", Offset = "0xFFFA0C", VA = "0xFFFA0C")]
		public static float Float(float t, InterpolationMode mode)
		{
			return default(float);
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x1000394", Offset = "0x1000394", VA = "0x1000394")]
		public static Vector3 V3(Vector3 v1, Vector3 v2, float t, InterpolationMode mode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x1000404", Offset = "0x1000404", VA = "0x1000404")]
		public static float LerpValue(float value, float target, float increaseSpeed, float decreaseSpeed)
		{
			return default(float);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xFFFE0C", Offset = "0xFFFE0C", VA = "0xFFFE0C")]
		private static float None(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0xFFFE18", Offset = "0xFFFE18", VA = "0xFFFE18")]
		private static float InOutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0xFFFE3C", Offset = "0xFFFE3C", VA = "0xFFFE3C")]
		private static float InOutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0xFFFE78", Offset = "0xFFFE78", VA = "0xFFFE78")]
		private static float InQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0xFFFE90", Offset = "0xFFFE90", VA = "0xFFFE90")]
		private static float InQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0xFFFEA4", Offset = "0xFFFEA4", VA = "0xFFFEA4")]
		private static float InCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0xFFFEB8", Offset = "0xFFFEB8", VA = "0xFFFEB8")]
		private static float InQuadratic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0xFFFEC8", Offset = "0xFFFEC8", VA = "0xFFFEC8")]
		private static float OutQuintic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0xFFFF10", Offset = "0xFFFF10", VA = "0xFFFF10")]
		private static float OutQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0xFFFF48", Offset = "0xFFFF48", VA = "0xFFFF48")]
		private static float OutCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0xFFFF70", Offset = "0xFFFF70", VA = "0xFFFF70")]
		private static float OutInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x1000474", Offset = "0x1000474", VA = "0x1000474")]
		private static float OutInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0xFFFFA4", Offset = "0xFFFFA4", VA = "0xFFFFA4")]
		private static float BackInCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xFFFFCC", Offset = "0xFFFFCC", VA = "0xFFFFCC")]
		private static float BackInQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xFFFFFC", Offset = "0xFFFFFC", VA = "0xFFFFFC")]
		private static float OutBackCubic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x1000030", Offset = "0x1000030", VA = "0x1000030")]
		private static float OutBackQuartic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x1000074", Offset = "0x1000074", VA = "0x1000074")]
		private static float OutElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x10000D8", Offset = "0x10000D8", VA = "0x10000D8")]
		private static float OutElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x100013C", Offset = "0x100013C", VA = "0x100013C")]
		private static float InElasticSmall(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x1000190", Offset = "0x1000190", VA = "0x1000190")]
		private static float InElasticBig(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x10001E4", Offset = "0x10001E4", VA = "0x10001E4")]
		private static float InSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x100021C", Offset = "0x100021C", VA = "0x100021C")]
		private static float OutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x1000250", Offset = "0x1000250", VA = "0x1000250")]
		private static float InOutSine(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x10004A8", Offset = "0x10004A8", VA = "0x10004A8")]
		private static float InElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x1000294", Offset = "0x1000294", VA = "0x1000294")]
		private static float OutElastic(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1000324", Offset = "0x1000324", VA = "0x1000324")]
		private static float InBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1000354", Offset = "0x1000354", VA = "0x1000354")]
		private static float OutBack(float t, float b, float c)
		{
			return default(float);
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x1000538", Offset = "0x1000538", VA = "0x1000538")]
		public Interp()
		{
		}
	}
	[Token(Token = "0x2000038")]
	public class LargeHeader : PropertyAttribute
	{
		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string color;

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x1000540", Offset = "0x1000540", VA = "0x1000540")]
		public LargeHeader(string name)
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x10005C8", Offset = "0x10005C8", VA = "0x10005C8")]
		public LargeHeader(string name, string color)
		{
		}
	}
	[Token(Token = "0x2000039")]
	public static class LayerMaskExtensions
	{
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1000654", Offset = "0x1000654", VA = "0x1000654")]
		public static bool Contains(LayerMask mask, int layer)
		{
			return default(bool);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x10006A0", Offset = "0x10006A0", VA = "0x10006A0")]
		public static LayerMask Create(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x100075C", Offset = "0x100075C", VA = "0x100075C")]
		public static LayerMask Create(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x10006B4", Offset = "0x10006B4", VA = "0x10006B4")]
		public static LayerMask NamesToMask(params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1000770", Offset = "0x1000770", VA = "0x1000770")]
		public static LayerMask LayerNumbersToMask(params int[] layerNumbers)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1000800", Offset = "0x1000800", VA = "0x1000800")]
		public static LayerMask Inverse(this LayerMask original)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1000828", Offset = "0x1000828", VA = "0x1000828")]
		public static LayerMask AddToMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1000874", Offset = "0x1000874", VA = "0x1000874")]
		public static LayerMask RemoveFromMask(this LayerMask original, params string[] layerNames)
		{
			return default(LayerMask);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x10008DC", Offset = "0x10008DC", VA = "0x10008DC")]
		public static string[] MaskToNames(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1000A38", Offset = "0x1000A38", VA = "0x1000A38")]
		public static int[] MaskToNumbers(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1000B70", Offset = "0x1000B70", VA = "0x1000B70")]
		public static string MaskToString(this LayerMask original)
		{
			return null;
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1000BC8", Offset = "0x1000BC8", VA = "0x1000BC8")]
		public static string MaskToString(this LayerMask original, string delimiter)
		{
			return null;
		}
	}
	[Token(Token = "0x200003A")]
	public static class QuaTools
	{
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1000BEC", Offset = "0x1000BEC", VA = "0x1000BEC")]
		public static float GetYaw(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1000C44", Offset = "0x1000C44", VA = "0x1000C44")]
		public static float GetPitch(Quaternion space, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1000D74", Offset = "0x1000D74", VA = "0x1000D74")]
		public static float GetBank(Quaternion space, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1000EF4", Offset = "0x1000EF4", VA = "0x1000EF4")]
		public static float GetYaw(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1000FD0", Offset = "0x1000FD0", VA = "0x1000FD0")]
		public static float GetPitch(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x10010AC", Offset = "0x10010AC", VA = "0x10010AC")]
		public static float GetBank(Quaternion space, Quaternion rotation)
		{
			return default(float);
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x10012C4", Offset = "0x10012C4", VA = "0x10012C4")]
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1001310", Offset = "0x1001310", VA = "0x1001310")]
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x100135C", Offset = "0x100135C", VA = "0x100135C")]
		public static Quaternion LinearBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1001460", Offset = "0x1001460", VA = "0x1001460")]
		public static Quaternion SphericalBlend(Quaternion q, float weight)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1001564", Offset = "0x1001564", VA = "0x1001564")]
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x1001678", Offset = "0x1001678", VA = "0x1001678")]
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x1001720", Offset = "0x1001720", VA = "0x1001720")]
		public static Quaternion FromToRotation(Quaternion from, Quaternion to)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x100182C", Offset = "0x100182C", VA = "0x100182C")]
		public static Vector3 GetAxis(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x1001994", Offset = "0x1001994", VA = "0x1001994")]
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x1001B78", Offset = "0x1001B78", VA = "0x1001B78")]
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing)
		{
			return default(float);
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x1001C48", Offset = "0x1001C48", VA = "0x1001C48")]
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x1001DCC", Offset = "0x1001DCC", VA = "0x1001DCC")]
		public static Vector3 ToBiPolar(Vector3 euler)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x1001ED8", Offset = "0x1001ED8", VA = "0x1001ED8")]
		public static float ToBiPolar(float angle)
		{
			return default(float);
		}
	}
	[Token(Token = "0x200003B")]
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static T sInstance;

		[Token(Token = "0x17000080")]
		public static T instance
		{
			[Token(Token = "0x60001EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001ED")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x60001EE")]
		protected Singleton()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public class SolverManager : MonoBehaviour
	{
		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If true, will fix all the Transforms used by the solver to their initial state in each Update. This prevents potential problems with unanimated bones and animator culling with a small cost of performance. Not recommended for CCD and FABRIK solvers.")]
		public bool fixTransforms;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Animation legacy;

		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool updateFrame;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool componentInitiated;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		private bool skipSolverUpdate;

		[Token(Token = "0x17000081")]
		private bool animatePhysics
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x100204C", Offset = "0x100204C", VA = "0x100204C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000082")]
		private bool isAnimated
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x1002348", Offset = "0x1002348", VA = "0x1002348")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x1001F30", Offset = "0x1001F30", VA = "0x1001F30")]
		public void Disable()
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x1001FC4", Offset = "0x1001FC4", VA = "0x1001FC4", Slot = "4")]
		protected virtual void InitiateSolver()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x1001FC8", Offset = "0x1001FC8", VA = "0x1001FC8", Slot = "5")]
		protected virtual void UpdateSolver()
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x1001FCC", Offset = "0x1001FCC", VA = "0x1001FCC", Slot = "6")]
		protected virtual void FixTransforms()
		{
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x1001FD0", Offset = "0x1001FD0", VA = "0x1001FD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x1002048", Offset = "0x1002048", VA = "0x1002048")]
		private void Start()
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x1001FF8", Offset = "0x1001FF8", VA = "0x1001FF8")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x100230C", Offset = "0x100230C", VA = "0x100230C")]
		private void Update()
		{
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x1002118", Offset = "0x1002118", VA = "0x1002118")]
		private void FindAnimatorRecursive(Transform t, bool findInChildren)
		{
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x10023E0", Offset = "0x10023E0", VA = "0x10023E0")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x100242C", Offset = "0x100242C", VA = "0x100242C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x1002478", Offset = "0x1002478", VA = "0x1002478")]
		public void UpdateSolverExternal()
		{
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x10024B0", Offset = "0x10024B0", VA = "0x10024B0")]
		public SolverManager()
		{
		}
	}
	[Token(Token = "0x200003D")]
	public class TriggerEventBroadcaster : MonoBehaviour
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject target;

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x10024C0", Offset = "0x10024C0", VA = "0x10024C0")]
		private void OnTriggerEnter(Collider collider)
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x1002574", Offset = "0x1002574", VA = "0x1002574")]
		private void OnTriggerStay(Collider collider)
		{
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x1002628", Offset = "0x1002628", VA = "0x1002628")]
		private void OnTriggerExit(Collider collider)
		{
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x10026DC", Offset = "0x10026DC", VA = "0x10026DC")]
		public TriggerEventBroadcaster()
		{
		}
	}
	[Token(Token = "0x200003E")]
	public static class V2Tools
	{
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x10026E4", Offset = "0x10026E4", VA = "0x10026E4")]
		public static Vector2 XZ(Vector3 v)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x10026EC", Offset = "0x10026EC", VA = "0x10026EC")]
		public static float DeltaAngle(Vector2 dir1, Vector2 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x100277C", Offset = "0x100277C", VA = "0x100277C")]
		public static float DeltaAngleXZ(Vector3 dir1, Vector3 dir2)
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1002810", Offset = "0x1002810", VA = "0x1002810")]
		public static bool LineCircleIntersect(Vector2 p1, Vector2 p2, Vector2 c, float r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x10028C0", Offset = "0x10028C0", VA = "0x10028C0")]
		public static bool RayCircleIntersect(Vector2 p1, Vector2 dir, Vector2 c, float r)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200003F")]
	public static class V3Tools
	{
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x100291C", Offset = "0x100291C", VA = "0x100291C")]
		public static float GetYaw(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x100293C", Offset = "0x100293C", VA = "0x100293C")]
		public static float GetPitch(Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1002A10", Offset = "0x1002A10", VA = "0x1002A10")]
		public static float GetBank(Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1002AC8", Offset = "0x1002AC8", VA = "0x1002AC8")]
		public static float GetYaw(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1002B24", Offset = "0x1002B24", VA = "0x1002B24")]
		public static float GetPitch(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward)
		{
			return default(float);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1002B80", Offset = "0x1002B80", VA = "0x1002B80")]
		public static float GetBank(Vector3 spaceForward, Vector3 spaceUp, Vector3 forward, Vector3 up)
		{
			return default(float);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1002C98", Offset = "0x1002C98", VA = "0x1002C98")]
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1002CF4", Offset = "0x1002CF4", VA = "0x1002CF4")]
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1002D2C", Offset = "0x1002D2C", VA = "0x1002D2C")]
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1002E7C", Offset = "0x1002E7C", VA = "0x1002E7C")]
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1002FF8", Offset = "0x1002FF8", VA = "0x1002FF8")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1003228", Offset = "0x1003228", VA = "0x1003228")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1003478", Offset = "0x1003478", VA = "0x1003478")]
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x10036D0", Offset = "0x10036D0", VA = "0x10036D0")]
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x100387C", Offset = "0x100387C", VA = "0x100387C")]
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1003A74", Offset = "0x1003A74", VA = "0x1003A74")]
		public static Vector3 TransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1003AF0", Offset = "0x1003AF0", VA = "0x1003AF0")]
		public static Vector3 InverseTransformPointUnscaled(Transform t, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1003B80", Offset = "0x1003B80", VA = "0x1003B80")]
		public static Vector3 InverseTransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1003C18", Offset = "0x1003C18", VA = "0x1003C18")]
		public static Vector3 TransformPoint(Vector3 tPos, Quaternion tRot, Vector3 tScale, Vector3 point)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1003C08", Offset = "0x1003C08", VA = "0x1003C08")]
		public static Vector3 Div(Vector3 v1, Vector3 v2)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x2000040")]
	public static class Warning
	{
		[Token(Token = "0x2000041")]
		public delegate void Logger(string message);

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool logged;

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1003C94", Offset = "0x1003C94", VA = "0x1003C94")]
		public static void Log(string message, Logger logger, bool logInEditMode = false)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xFFCE9C", Offset = "0xFFCE9C", VA = "0xFFCE9C")]
		public static void Log(string message, Transform context, bool logInEditMode = false)
		{
		}
	}
}
namespace RootMotion.FinalIK
{
	[Token(Token = "0x2000042")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page4.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Biped IK")]
	public class BipedIK : SolverManager
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public BipedIKSolvers solvers;

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1003E50", Offset = "0x1003E50", VA = "0x1003E50")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1003E94", Offset = "0x1003E94", VA = "0x1003E94")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1003ED8", Offset = "0x1003ED8", VA = "0x1003ED8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1003F1C", Offset = "0x1003F1C", VA = "0x1003F1C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x1003F60", Offset = "0x1003F60", VA = "0x1003F60")]
		public float GetIKPositionWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1003FF8", Offset = "0x1003FF8", VA = "0x1003FF8")]
		public float GetIKRotationWeight(AvatarIKGoal goal)
		{
			return default(float);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1004014", Offset = "0x1004014", VA = "0x1004014")]
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1004040", Offset = "0x1004040", VA = "0x1004040")]
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight)
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x100406C", Offset = "0x100406C", VA = "0x100406C")]
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition)
		{
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x10040A8", Offset = "0x10040A8", VA = "0x10040A8")]
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x10040E8", Offset = "0x10040E8", VA = "0x10040E8")]
		public Vector3 GetIKPosition(AvatarIKGoal goal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1004108", Offset = "0x1004108", VA = "0x1004108")]
		public Quaternion GetIKRotation(AvatarIKGoal goal)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x1004128", Offset = "0x1004128", VA = "0x1004128")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes)
		{
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x100414C", Offset = "0x100414C", VA = "0x100414C")]
		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1004174", Offset = "0x1004174", VA = "0x1004174")]
		public void SetSpinePosition(Vector3 spinePosition)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x100419C", Offset = "0x100419C", VA = "0x100419C")]
		public void SetSpineWeight(float weight)
		{
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1003F7C", Offset = "0x1003F7C", VA = "0x1003F7C")]
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal)
		{
			return null;
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x10041C0", Offset = "0x10041C0", VA = "0x10041C0")]
		public void InitiateBipedIK()
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x10041CC", Offset = "0x10041CC", VA = "0x10041CC")]
		public void UpdateBipedIK()
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x10041D8", Offset = "0x10041D8", VA = "0x10041D8")]
		public void SetToDefaults()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x100448C", Offset = "0x100448C", VA = "0x100448C", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x1004528", Offset = "0x1004528", VA = "0x1004528", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x100484C", Offset = "0x100484C", VA = "0x100484C", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x1004CB8", Offset = "0x1004CB8", VA = "0x1004CB8")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x1004CDC", Offset = "0x1004CDC", VA = "0x1004CDC")]
		public BipedIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class BipedIKSolvers
	{
		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IKSolverLimb leftFoot;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IKSolverLimb rightFoot;

		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IKSolverLimb leftHand;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IKSolverLimb rightHand;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolverFABRIK spine;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt lookAt;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverAim aim;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Constraints pelvis;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb[] _limbs;

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private IKSolver[] _ikSolvers;

		[Token(Token = "0x17000083")]
		public IKSolverLimb[] limbs
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0x1004314", Offset = "0x1004314", VA = "0x1004314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		public IKSolver[] ikSolvers
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0x1004F78", Offset = "0x1004F78", VA = "0x1004F78")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x10046D8", Offset = "0x10046D8", VA = "0x10046D8")]
		public void AssignReferences(BipedReferences references)
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x1004D8C", Offset = "0x1004D8C", VA = "0x1004D8C")]
		public BipedIKSolvers()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public abstract class Constraint
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float weight;

		[Token(Token = "0x17000085")]
		public bool isValid
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x10051A0", Offset = "0x10051A0", VA = "0x10051A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600023F")]
		public abstract void UpdateConstraint();

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x1005200", Offset = "0x1005200", VA = "0x1005200")]
		protected Constraint()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class ConstraintPosition : Constraint
	{
		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 position;

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x1005208", Offset = "0x1005208", VA = "0x1005208", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0x10052A0", Offset = "0x10052A0", VA = "0x10052A0")]
		public ConstraintPosition()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x10052A8", Offset = "0x10052A8", VA = "0x10052A8")]
		public ConstraintPosition(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class ConstraintPositionOffset : Constraint
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Vector3 offset;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 defaultLocalPosition;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 lastLocalPosition;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool initiated;

		[Token(Token = "0x17000086")]
		private bool positionChanged
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0x10053DC", Offset = "0x10053DC", VA = "0x10053DC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000244")]
		[Address(RVA = "0x10052D8", Offset = "0x10052D8", VA = "0x10052D8", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x1005438", Offset = "0x1005438", VA = "0x1005438")]
		public ConstraintPositionOffset()
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x1005440", Offset = "0x1005440", VA = "0x1005440")]
		public ConstraintPositionOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class ConstraintRotation : Constraint
	{
		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1005470", Offset = "0x1005470", VA = "0x1005470", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x10054EC", Offset = "0x10054EC", VA = "0x10054EC")]
		public ConstraintRotation()
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x10054F4", Offset = "0x10054F4", VA = "0x10054F4")]
		public ConstraintRotation(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000048")]
	public class ConstraintRotationOffset : Constraint
	{
		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion offset;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastLocalRotation;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion defaultTargetLocalRotation;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool initiated;

		[Token(Token = "0x17000087")]
		private bool rotationChanged
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x1005628", Offset = "0x1005628", VA = "0x1005628")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1005524", Offset = "0x1005524", VA = "0x1005524", Slot = "4")]
		public override void UpdateConstraint()
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1005680", Offset = "0x1005680", VA = "0x1005680")]
		public ConstraintRotationOffset()
		{
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0x1005688", Offset = "0x1005688", VA = "0x1005688")]
		public ConstraintRotationOffset(Transform transform)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000049")]
	public class Constraints
	{
		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 positionOffset;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 position;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 rotationOffset;

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rotation;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x10056B8", Offset = "0x10056B8", VA = "0x10056B8")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x10047F8", Offset = "0x10047F8", VA = "0x10047F8")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x10049C0", Offset = "0x10049C0", VA = "0x10049C0")]
		public void Update()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1005198", Offset = "0x1005198", VA = "0x1005198")]
		public Constraints()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200004A")]
	public class Finger
	{
		[Serializable]
		[Token(Token = "0x200004B")]
		public enum DOF
		{
			[Token(Token = "0x4000298")]
			One,
			[Token(Token = "0x4000299")]
			Three
		}

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		[Tooltip("Master Weight for the finger.")]
		public float weight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("The weight of rotating the finger tip and bending the finger to the target.")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Rotational degrees of freedom. When set to 'One' the fingers will be able to be rotated only around a single axis. When 3, all 3 axes are free to rotate around.")]
		public DOF rotationDOF;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("If enabled, keeps bone1 twist angle fixed relative to bone2.")]
		public bool fixBone1Twist;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The first bone of the finger.")]
		public Transform bone1;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The second bone of the finger.")]
		public Transform bone2;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The (optional) third bone of the finger. This can be ignored for thumbs.")]
		public Transform bone3;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The fingertip object. If your character doesn't have tip bones, you can create an empty GameObject and parent it to the last bone in the finger. Place it to the tip of the finger.")]
		public Transform tip;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The IK target (optional, can use IKPosition and IKRotation directly).")]
		public Transform target;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IKSolverLimb solver;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion bone3RelativeToTarget;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 bone3DefaultLocalPosition;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Quaternion bone3DefaultLocalRotation;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 bone1Axis;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 tipAxis;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 bone1TwistAxis;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 defaultBendNormal;

		[Token(Token = "0x17000088")]
		public bool initiated
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0x1005718", Offset = "0x1005718", VA = "0x1005718")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x1005720", Offset = "0x1005720", VA = "0x1005720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public Vector3 IKPosition
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x100572C", Offset = "0x100572C", VA = "0x100572C")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x100574C", Offset = "0x100574C", VA = "0x100574C")]
			set
			{
			}
		}

		[Token(Token = "0x1700008A")]
		public Quaternion IKRotation
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x100576C", Offset = "0x100576C", VA = "0x100576C")]
			get
			{
				return default(Quaternion);
			}
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x100578C", Offset = "0x100578C", VA = "0x100578C")]
			set
			{
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x10057AC", Offset = "0x10057AC", VA = "0x10057AC")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x10058A4", Offset = "0x10058A4", VA = "0x10058A4")]
		public void Initiate(Transform hand, int index)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1005F28", Offset = "0x1005F28", VA = "0x1005F28")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1005FF4", Offset = "0x1005FF4", VA = "0x1005FF4")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x10060AC", Offset = "0x10060AC", VA = "0x10060AC")]
		public void Update(float masterWeight)
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x100664C", Offset = "0x100664C", VA = "0x100664C")]
		public Finger()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class FingerRig : SolverManager
	{
		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		[Tooltip("The master weight for all fingers.")]
		public float weight;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Finger[] fingers;

		[Token(Token = "0x1700008B")]
		public bool initiated
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x100665C", Offset = "0x100665C", VA = "0x100665C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x1006664", Offset = "0x1006664", VA = "0x1006664")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x1006670", Offset = "0x1006670", VA = "0x1006670")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000262")]
		[Address(RVA = "0x10066E4", Offset = "0x10066E4", VA = "0x10066E4")]
		[ContextMenu("Auto-detect")]
		public void AutoDetect()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x1006A5C", Offset = "0x1006A5C", VA = "0x1006A5C")]
		public void AddFinger(Transform bone1, Transform bone2, Transform bone3, Transform tip, [Optional] Transform target)
		{
		}

		[Token(Token = "0x6000264")]
		[Address(RVA = "0x1006C14", Offset = "0x1006C14", VA = "0x1006C14")]
		public void RemoveFinger(int index)
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0x100696C", Offset = "0x100696C", VA = "0x100696C")]
		private void AddChildrenRecursive(Transform parent, ref Transform[] array)
		{
		}

		[Token(Token = "0x6000266")]
		[Address(RVA = "0x1006D90", Offset = "0x1006D90", VA = "0x1006D90", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000267")]
		[Address(RVA = "0x1006E38", Offset = "0x1006E38", VA = "0x1006E38")]
		public void UpdateFingerSolvers()
		{
		}

		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1006E9C", Offset = "0x1006E9C", VA = "0x1006E9C")]
		public void FixFingerTransforms()
		{
		}

		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1006F04", Offset = "0x1006F04", VA = "0x1006F04")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600026A")]
		[Address(RVA = "0x1006F60", Offset = "0x1006F60", VA = "0x1006F60", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1006F64", Offset = "0x1006F64", VA = "0x1006F64", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1006F78", Offset = "0x1006F78", VA = "0x1006F78")]
		public FingerRig()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public abstract class Grounder : MonoBehaviour
	{
		[Token(Token = "0x200004E")]
		public delegate void GrounderDelegate();

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight. Use this to fade in/out the grounding effect.")]
		public float weight;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The Grounding solver. Not to confuse with IK solvers.")]
		public Grounding solver;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GrounderDelegate OnPreGrounder;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GrounderDelegate OnPostGrounder;

		[Token(Token = "0x1700008C")]
		public bool initiated
		{
			[Token(Token = "0x600026E")]
			[Address(RVA = "0x1006FEC", Offset = "0x1006FEC", VA = "0x1006FEC")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026F")]
			[Address(RVA = "0x1006FF4", Offset = "0x1006FF4", VA = "0x1006FF4")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Token(Token = "0x600026D")]
		public abstract void ResetPosition();

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1007000", Offset = "0x1007000", VA = "0x1007000")]
		protected Vector3 GetSpineOffsetTarget()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x10072B0", Offset = "0x10072B0", VA = "0x10072B0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x10070C4", Offset = "0x10070C4", VA = "0x10070C4")]
		private Vector3 GetLegSpineBendVector(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x10072D4", Offset = "0x10072D4", VA = "0x10072D4")]
		private Vector3 GetLegSpineTangent(Grounding.Leg leg)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000274")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000275")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1007448", Offset = "0x1007448", VA = "0x1007448")]
		protected Grounder()
		{
		}
	}
	[Token(Token = "0x200004F")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Biped")]
	public class GrounderBipedIK : Grounder
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The BipedIK componet.")]
		public BipedIK ik;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Transform[] feet;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastWeight;

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x100766C", Offset = "0x100766C", VA = "0x100766C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x10076B0", Offset = "0x10076B0", VA = "0x10076B0", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x10076F4", Offset = "0x10076F4", VA = "0x10076F4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x10077DC", Offset = "0x10077DC", VA = "0x10077DC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x100787C", Offset = "0x100787C", VA = "0x100787C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x10078D0", Offset = "0x10078D0", VA = "0x10078D0")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1007EE4", Offset = "0x1007EE4", VA = "0x1007EE4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1007F24", Offset = "0x1007F24", VA = "0x1007F24")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x10085A0", Offset = "0x10085A0", VA = "0x10085A0")]
		private void SetLegIK(IKSolverLimb limb, int index)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x10086C8", Offset = "0x10086C8", VA = "0x10086C8")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1008898", Offset = "0x1008898", VA = "0x1008898")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1008A70", Offset = "0x1008A70", VA = "0x1008A70")]
		public GrounderBipedIK()
		{
		}
	}
	[Token(Token = "0x2000050")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Full Body Biped")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderFBBIK : Grounder
	{
		[Serializable]
		[Token(Token = "0x2000051")]
		public class SpineEffector
		{
			[Token(Token = "0x40002B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the effector.")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40002B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The weight of horizontal bend offset towards the slope.")]
			public float horizontalWeight;

			[Token(Token = "0x40002B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The vertical bend offset weight.")]
			public float verticalWeight;

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x10097C0", Offset = "0x10097C0", VA = "0x10097C0")]
			public SpineEffector()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x10097D0", Offset = "0x10097D0", VA = "0x10097D0")]
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight)
			{
			}
		}

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the FBBIK componet.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The amount of spine bending towards upward slopes.")]
		public float spineBend;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The interpolation speed of spine bending.")]
		public float spineSpeed;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public SpineEffector[] spine;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] feet;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 spineOffset;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private bool firstSolve;

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1008B14", Offset = "0x1008B14", VA = "0x1008B14")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1008B58", Offset = "0x1008B58", VA = "0x1008B58", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1008B9C", Offset = "0x1008B9C", VA = "0x1008B9C", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1008BE0", Offset = "0x1008BE0", VA = "0x1008BE0", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1008C48", Offset = "0x1008C48", VA = "0x1008C48")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x1008CD0", Offset = "0x1008CD0", VA = "0x1008CD0")]
		private void Update()
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x1008F7C", Offset = "0x1008F7C", VA = "0x1008F7C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x1008F88", Offset = "0x1008F88", VA = "0x1008F88")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x1008D2C", Offset = "0x1008D2C", VA = "0x1008D2C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x1008F94", Offset = "0x1008F94", VA = "0x1008F94")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x1009304", Offset = "0x1009304", VA = "0x1009304")]
		private void SetLegIK(IKEffector effector, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x1009488", Offset = "0x1009488", VA = "0x1009488")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x10095E8", Offset = "0x10095E8", VA = "0x10095E8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x100971C", Offset = "0x100971C", VA = "0x100971C")]
		public GrounderFBBIK()
		{
		}
	}
	[Token(Token = "0x2000052")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderIK : Grounder
	{
		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IK[] legs;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The pelvis transform. Common ancestor of all the legs.")]
		public Transform pelvis;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The weight of rotating the character root to the ground normal (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float rootRotationWeight;

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The speed of rotating the character root to the ground normal (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The maximum angle of root rotation (range: 0 - 90).")]
		public float maxRootRotationAngle;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform[] feet;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] footRotations;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private int solvedFeet;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool solved;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float lastWeight;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x1009814", Offset = "0x1009814", VA = "0x1009814", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x1009858", Offset = "0x1009858", VA = "0x1009858", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x100989C", Offset = "0x100989C", VA = "0x100989C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x10098B4", Offset = "0x10098B4", VA = "0x10098B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x1009AD0", Offset = "0x1009AD0", VA = "0x1009AD0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x1009BB0", Offset = "0x1009BB0", VA = "0x1009BB0")]
		private void Update()
		{
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x100A29C", Offset = "0x100A29C", VA = "0x100A29C")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x100A754", Offset = "0x100A754", VA = "0x100A754")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x100A900", Offset = "0x100A900", VA = "0x100A900")]
		private void SetLegIK(int index)
		{
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x100AC88", Offset = "0x100AC88", VA = "0x100AC88")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x100AE60", Offset = "0x100AE60", VA = "0x100AE60")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x100B088", Offset = "0x100B088", VA = "0x100B088")]
		public GrounderIK()
		{
		}
	}
	[Token(Token = "0x2000053")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder Quadruped")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page9.html")]
	public class GrounderQuadruped : Grounder
	{
		[Token(Token = "0x2000054")]
		public struct Foot
		{
			[Token(Token = "0x40002E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IKSolver solver;

			[Token(Token = "0x40002E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x40002E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Quaternion rotation;

			[Token(Token = "0x40002E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Grounding.Leg leg;

			[Token(Token = "0x60002B5")]
			[Address(RVA = "0x100BC78", Offset = "0x100BC78", VA = "0x100BC78")]
			public Foot(IKSolver solver, Transform transform)
			{
			}
		}

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The Grounding solver for the forelegs.")]
		public Grounding forelegSolver;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the character root to the ground angle (range: 0 - 1).")]
		public float rootRotationWeight;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(-90f, 0f)]
		[Tooltip("The maximum angle of rotating the quadruped downwards (going downhill, range: -90 - 0).")]
		public float minRootRotation;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 90f)]
		[Tooltip("The maximum angle of rotating the quadruped upwards (going uphill, range: 0 - 90).")]
		public float maxRootRotation;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The speed of interpolating the character root rotation (range: 0 - inf).")]
		public float rootRotationSpeed;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The maximum IK offset for the legs (range: 0 - inf).")]
		public float maxLegOffset;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("The maximum IK offset for the forelegs (range: 0 - inf).")]
		public float maxForeLegOffset;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("The weight of maintaining the head's rotation as it was before solving the Grounding (range: 0 - 1).")]
		[Range(0f, 1f)]
		public float maintainHeadRotationWeight;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("The root Transform of the character, with the rigidbody and the collider.")]
		public Transform characterRoot;

		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The pelvis transform. Common ancestor of both legs and the spine.")]
		public Transform pelvis;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The last bone in the spine that is the common parent for both forelegs.")]
		public Transform lastSpineBone;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Tooltip("The head (optional, if you intend to maintain it's rotation).")]
		public Transform head;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IK[] legs;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IK[] forelegs;

		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		public Vector3 gravity;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Foot[] feet;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 animatedPelvisLocalPosition;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Quaternion animatedPelvisLocalRotation;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private Quaternion animatedHeadLocalRotation;

		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 solvedPelvisLocalPosition;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Quaternion solvedPelvisLocalRotation;

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion solvedHeadLocalRotation;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private int solvedFeet;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private bool solved;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private float angle;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Transform forefeetRoot;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Quaternion headRotation;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private float lastWeight;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private Rigidbody characterRootRigidbody;

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x100B12C", Offset = "0x100B12C", VA = "0x100B12C", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x100B170", Offset = "0x100B170", VA = "0x100B170", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x100B1B4", Offset = "0x100B1B4", VA = "0x100B1B4", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x100B1DC", Offset = "0x100B1DC", VA = "0x100B1DC")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x100B2E0", Offset = "0x100B2E0", VA = "0x100B2E0")]
		private bool IsReadyToInitiateLegs(IK[] ikComponents)
		{
			return default(bool);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x100B4D4", Offset = "0x100B4D4", VA = "0x100B4D4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x100B538", Offset = "0x100B538", VA = "0x100B538")]
		private void Update()
		{
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x100B590", Offset = "0x100B590", VA = "0x100B590")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x100B8DC", Offset = "0x100B8DC", VA = "0x100B8DC")]
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset)
		{
			return null;
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x100BCD8", Offset = "0x100BCD8", VA = "0x100BCD8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x100BD68", Offset = "0x100BD68", VA = "0x100BD68")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x100C1B8", Offset = "0x100C1B8", VA = "0x100C1B8")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x100C878", Offset = "0x100C878", VA = "0x100C878")]
		private void UpdateForefeetRoot()
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x100CB30", Offset = "0x100CB30", VA = "0x100CB30")]
		private void SetFootIK(Foot foot, float maxOffset)
		{
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x100CC64", Offset = "0x100CC64", VA = "0x100CC64")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x100CF2C", Offset = "0x100CF2C", VA = "0x100CF2C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x100CF5C", Offset = "0x100CF5C", VA = "0x100CF5C")]
		private void DestroyLegs(IK[] ikComponents)
		{
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x100D17C", Offset = "0x100D17C", VA = "0x100D17C")]
		public GrounderQuadruped()
		{
		}
	}
	[Token(Token = "0x2000055")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Grounder/Grounder VRIK")]
	[HelpURL("https://www.youtube.com/watch?v=9MiZiaJorws&index=6&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class GrounderVRIK : Grounder
	{
		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Reference to the VRIK componet.")]
		public VRIK ik;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform[] feet;

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x100D2D0", Offset = "0x100D2D0", VA = "0x100D2D0")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x100D314", Offset = "0x100D314", VA = "0x100D314", Slot = "5")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x100D358", Offset = "0x100D358", VA = "0x100D358", Slot = "6")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x100D39C", Offset = "0x100D39C", VA = "0x100D39C", Slot = "4")]
		public override void ResetPosition()
		{
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x100D3B4", Offset = "0x100D3B4", VA = "0x100D3B4")]
		private bool IsReadyToInitiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x100D43C", Offset = "0x100D43C", VA = "0x100D43C")]
		private void Update()
		{
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x100D490", Offset = "0x100D490", VA = "0x100D490")]
		private void Initiate()
		{
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x100D714", Offset = "0x100D714", VA = "0x100D714")]
		private void OnSolverUpdate()
		{
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x100D908", Offset = "0x100D908", VA = "0x100D908")]
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg)
		{
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x100D98C", Offset = "0x100D98C", VA = "0x100D98C")]
		private void OnPostSolverUpdate()
		{
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x100DC28", Offset = "0x100DC28", VA = "0x100DC28")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x100DD88", Offset = "0x100DD88", VA = "0x100DD88")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x100DF50", Offset = "0x100DF50", VA = "0x100DF50")]
		public GrounderVRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000056")]
	public class Grounding
	{
		[Serializable]
		[Token(Token = "0x2000057")]
		public enum Quality
		{
			[Token(Token = "0x40002FF")]
			Fastest,
			[Token(Token = "0x4000300")]
			Simple,
			[Token(Token = "0x4000301")]
			Best
		}

		[Token(Token = "0x2000058")]
		public class Leg
		{
			[Token(Token = "0x4000304")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Quaternion rotationOffset;

			[Token(Token = "0x400030A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public bool invertFootCenter;

			[Token(Token = "0x400030D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Grounding grounding;

			[Token(Token = "0x400030E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private float lastTime;

			[Token(Token = "0x400030F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private float deltaTime;

			[Token(Token = "0x4000310")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000311")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private Quaternion toHitNormal;

			[Token(Token = "0x4000312")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
			private Quaternion r;

			[Token(Token = "0x4000313")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 up;

			[Token(Token = "0x4000314")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private bool doOverrideFootPosition;

			[Token(Token = "0x4000315")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Vector3 overrideFootPosition;

			[Token(Token = "0x4000316")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			private Vector3 transformPosition;

			[Token(Token = "0x17000095")]
			public bool isGrounded
			{
				[Token(Token = "0x60002DB")]
				[Address(RVA = "0x100E6EC", Offset = "0x100E6EC", VA = "0x100E6EC")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002DC")]
				[Address(RVA = "0x100E6F4", Offset = "0x100E6F4", VA = "0x100E6F4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000096")]
			public Vector3 IKPosition
			{
				[Token(Token = "0x60002DD")]
				[Address(RVA = "0x100E700", Offset = "0x100E700", VA = "0x100E700")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002DE")]
				[Address(RVA = "0x100E70C", Offset = "0x100E70C", VA = "0x100E70C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000097")]
			public bool initiated
			{
				[Token(Token = "0x60002DF")]
				[Address(RVA = "0x100E718", Offset = "0x100E718", VA = "0x100E718")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x60002E0")]
				[Address(RVA = "0x100E720", Offset = "0x100E720", VA = "0x100E720")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000098")]
			public float heightFromGround
			{
				[Token(Token = "0x60002E1")]
				[Address(RVA = "0x100E72C", Offset = "0x100E72C", VA = "0x100E72C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002E2")]
				[Address(RVA = "0x100E734", Offset = "0x100E734", VA = "0x100E734")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000099")]
			public Vector3 velocity
			{
				[Token(Token = "0x60002E3")]
				[Address(RVA = "0x100E73C", Offset = "0x100E73C", VA = "0x100E73C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002E4")]
				[Address(RVA = "0x100E748", Offset = "0x100E748", VA = "0x100E748")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009A")]
			public Transform transform
			{
				[Token(Token = "0x60002E5")]
				[Address(RVA = "0x100E754", Offset = "0x100E754", VA = "0x100E754")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60002E6")]
				[Address(RVA = "0x100E75C", Offset = "0x100E75C", VA = "0x100E75C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009B")]
			public float IKOffset
			{
				[Token(Token = "0x60002E7")]
				[Address(RVA = "0x100E764", Offset = "0x100E764", VA = "0x100E764")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60002E8")]
				[Address(RVA = "0x100E76C", Offset = "0x100E76C", VA = "0x100E76C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009C")]
			public RaycastHit heelHit
			{
				[Token(Token = "0x60002E9")]
				[Address(RVA = "0x100E774", Offset = "0x100E774", VA = "0x100E774")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60002EA")]
				[Address(RVA = "0x100E78C", Offset = "0x100E78C", VA = "0x100E78C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009D")]
			public RaycastHit capsuleHit
			{
				[Token(Token = "0x60002EB")]
				[Address(RVA = "0x100E7AC", Offset = "0x100E7AC", VA = "0x100E7AC")]
				[CompilerGenerated]
				get
				{
					return default(RaycastHit);
				}
				[Token(Token = "0x60002EC")]
				[Address(RVA = "0x100E7C4", Offset = "0x100E7C4", VA = "0x100E7C4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700009E")]
			public RaycastHit GetHitPoint
			{
				[Token(Token = "0x60002ED")]
				[Address(RVA = "0x100E7E4", Offset = "0x100E7E4", VA = "0x100E7E4")]
				get
				{
					return default(RaycastHit);
				}
			}

			[Token(Token = "0x1700009F")]
			public float stepHeightFromGround
			{
				[Token(Token = "0x60002F3")]
				[Address(RVA = "0x100FBAC", Offset = "0x100FBAC", VA = "0x100FBAC")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000A0")]
			private float rootYOffset
			{
				[Token(Token = "0x60002FC")]
				[Address(RVA = "0x100FD00", Offset = "0x100FD00", VA = "0x100FD00")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x100E82C", Offset = "0x100E82C", VA = "0x100E82C")]
			public void SetFootPosition(Vector3 position)
			{
			}

			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x100E840", Offset = "0x100E840", VA = "0x100E840")]
			public void Initiate(Grounding grounding, Transform transform)
			{
			}

			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x100E918", Offset = "0x100E918", VA = "0x100E918")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x100E958", Offset = "0x100E958", VA = "0x100E958")]
			public void Reset()
			{
			}

			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x100E9EC", Offset = "0x100E9EC", VA = "0x100E9EC")]
			public void Process()
			{
			}

			[Token(Token = "0x60002F4")]
			[Address(RVA = "0x100F7B8", Offset = "0x100F7B8", VA = "0x100F7B8")]
			private RaycastHit GetCapsuleHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x100F354", Offset = "0x100F354", VA = "0x100F354")]
			private RaycastHit GetRaycastHit(Vector3 offsetFromHeel)
			{
				return default(RaycastHit);
			}

			[Token(Token = "0x60002F6")]
			[Address(RVA = "0x100FC40", Offset = "0x100FC40", VA = "0x100FC40")]
			private Vector3 RotateNormal(Vector3 normal)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x100F620", Offset = "0x100F620", VA = "0x100F620")]
			private void SetFootToPoint(Vector3 normal, Vector3 point)
			{
			}

			[Token(Token = "0x60002F8")]
			[Address(RVA = "0x100F6A0", Offset = "0x100F6A0", VA = "0x100F6A0")]
			private void SetFootToPlane(Vector3 planeNormal, Vector3 planePoint, Vector3 heelHitPoint)
			{
			}

			[Token(Token = "0x60002F9")]
			[Address(RVA = "0x100FCAC", Offset = "0x100FCAC", VA = "0x100FCAC")]
			private float GetHeightFromGround(Vector3 hitPoint)
			{
				return default(float);
			}

			[Token(Token = "0x60002FA")]
			[Address(RVA = "0x100FBE0", Offset = "0x100FBE0", VA = "0x100FBE0")]
			private void RotateFoot()
			{
			}

			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x100FD90", Offset = "0x100FD90", VA = "0x100FD90")]
			private Quaternion GetRotationOffsetTarget()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x100FF40", Offset = "0x100FF40", VA = "0x100FF40")]
			public Leg()
			{
			}
		}

		[Token(Token = "0x2000059")]
		public class Pelvis
		{
			[Token(Token = "0x4000319")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Grounding grounding;

			[Token(Token = "0x400031A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Vector3 lastRootPosition;

			[Token(Token = "0x400031B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float damperF;

			[Token(Token = "0x400031C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private bool initiated;

			[Token(Token = "0x400031D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float lastTime;

			[Token(Token = "0x170000A1")]
			public Vector3 IKOffset
			{
				[Token(Token = "0x60002FE")]
				[Address(RVA = "0x100FFD8", Offset = "0x100FFD8", VA = "0x100FFD8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x60002FF")]
				[Address(RVA = "0x100FFE4", Offset = "0x100FFE4", VA = "0x100FFE4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A2")]
			public float heightOffset
			{
				[Token(Token = "0x6000300")]
				[Address(RVA = "0x100FFF0", Offset = "0x100FFF0", VA = "0x100FFF0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000301")]
				[Address(RVA = "0x100FFF8", Offset = "0x100FFF8", VA = "0x100FFF8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000302")]
			[Address(RVA = "0x1010000", Offset = "0x1010000", VA = "0x1010000")]
			public void Initiate(Grounding grounding)
			{
			}

			[Token(Token = "0x6000303")]
			[Address(RVA = "0x1010078", Offset = "0x1010078", VA = "0x1010078")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000304")]
			[Address(RVA = "0x1010024", Offset = "0x1010024", VA = "0x1010024")]
			public void OnEnable()
			{
			}

			[Token(Token = "0x6000305")]
			[Address(RVA = "0x101010C", Offset = "0x101010C", VA = "0x101010C")]
			public void Process(float lowestOffset, float highestOffset, bool isGrounded)
			{
			}

			[Token(Token = "0x6000306")]
			[Address(RVA = "0x10102D8", Offset = "0x10102D8", VA = "0x10102D8")]
			public Pelvis()
			{
			}
		}

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Layers to ground the character to. Make sure to exclude the layer of the character controller.")]
		public LayerMask layers;

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Max step height. Maximum vertical distance of Grounding from the root of the character.")]
		public float maxStep;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The height offset of the root.")]
		public float heightOffset;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The speed of moving the feet up/down.")]
		public float footSpeed;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("CapsuleCast radius. Should match approximately with the size of the feet.")]
		public float footRadius;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Offset of the foot center along character forward axis.")]
		[HideInInspector]
		public float footCenterOffset;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Amount of velocity based prediction of the foot positions.")]
		public float prediction;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Weight of rotating the feet to the ground normal offset.")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Speed of slerping the feet to their grounded rotations.")]
		public float footRotationSpeed;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Max Foot Rotation Angle. Max angular offset from the foot's rotation.")]
		[Range(0f, 90f)]
		public float maxFootRotationAngle;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("If true, solver will rotate with the character root so the character can be grounded for example to spherical planets. For performance reasons leave this off unless needed.")]
		public bool rotateSolver;

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The speed of moving the character up/down.")]
		public float pelvisSpeed;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[Tooltip("Used for smoothing out vertical pelvis movement (range 0 - 1).")]
		public float pelvisDamper;

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("The weight of lowering the pelvis to the lowest foot.")]
		public float lowerPelvisWeight;

		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of lifting the pelvis to the highest foot. This is useful when you don't want the feet to go too high relative to the body when crouching.")]
		public float liftPelvisWeight;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The radius of the spherecast from the root that determines whether the character root is grounded.")]
		public float rootSphereCastRadius;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("If false, keeps the foot that is over a ledge at the root level. If true, lowers the overstepping foot and body by the 'Max Step' value.")]
		public bool overstepFallsDown;

		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("The raycasting quality. Fastest is a single raycast per foot, Simple is three raycasts, Best is one raycast and a capsule cast per foot.")]
		public Quality quality;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool initiated;

		[Token(Token = "0x1700008D")]
		public Leg[] legs
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x100DFB0", Offset = "0x100DFB0", VA = "0x100DFB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C4")]
			[Address(RVA = "0x100DFB8", Offset = "0x100DFB8", VA = "0x100DFB8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008E")]
		public Pelvis pelvis
		{
			[Token(Token = "0x60002C5")]
			[Address(RVA = "0x100DFC0", Offset = "0x100DFC0", VA = "0x100DFC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002C6")]
			[Address(RVA = "0x100DFC8", Offset = "0x100DFC8", VA = "0x100DFC8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x1700008F")]
		public bool isGrounded
		{
			[Token(Token = "0x60002C7")]
			[Address(RVA = "0x100DFD0", Offset = "0x100DFD0", VA = "0x100DFD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002C8")]
			[Address(RVA = "0x100DFD8", Offset = "0x100DFD8", VA = "0x100DFD8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000090")]
		public Transform root
		{
			[Token(Token = "0x60002C9")]
			[Address(RVA = "0x100DFE4", Offset = "0x100DFE4", VA = "0x100DFE4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60002CA")]
			[Address(RVA = "0x100DFEC", Offset = "0x100DFEC", VA = "0x100DFEC")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000091")]
		public RaycastHit rootHit
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x100DFF4", Offset = "0x100DFF4", VA = "0x100DFF4")]
			[CompilerGenerated]
			get
			{
				return default(RaycastHit);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x100E00C", Offset = "0x100E00C", VA = "0x100E00C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool rootGrounded
		{
			[Token(Token = "0x60002CD")]
			[Address(RVA = "0x100E02C", Offset = "0x100E02C", VA = "0x100E02C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000093")]
		public Vector3 up
		{
			[Token(Token = "0x60002D5")]
			[Address(RVA = "0x1008660", Offset = "0x1008660", VA = "0x1008660")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000094")]
		private bool useRootRotation
		{
			[Token(Token = "0x60002D8")]
			[Address(RVA = "0x100E3F0", Offset = "0x100E3F0", VA = "0x100E3F0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x100E074", Offset = "0x100E074", VA = "0x100E074")]
		public RaycastHit GetRootHit(float maxDistanceMlp = 10f)
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x100E2D4", Offset = "0x100E2D4", VA = "0x100E2D4")]
		public bool IsValid(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1007C2C", Offset = "0x1007C2C", VA = "0x1007C2C")]
		public void Initiate(Transform root, Transform[] feet)
		{
		}

		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x100839C", Offset = "0x100839C", VA = "0x100839C")]
		public void Update()
		{
		}

		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x100A124", Offset = "0x100A124", VA = "0x100A124")]
		public Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x100775C", Offset = "0x100775C", VA = "0x100775C")]
		public void Reset()
		{
		}

		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x100E3DC", Offset = "0x100E3DC", VA = "0x100E3DC")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x100E4A4", Offset = "0x100E4A4", VA = "0x100E4A4")]
		public float GetVerticalOffset(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x100E528", Offset = "0x100E528", VA = "0x100E528")]
		public Vector3 Flatten(Vector3 v)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x100E67C", Offset = "0x100E67C", VA = "0x100E67C")]
		public Vector3 GetFootCenterOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x100750C", Offset = "0x100750C", VA = "0x100750C")]
		public Grounding()
		{
		}
	}
	[Token(Token = "0x200005A")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Aim IK")]
	[HelpURL("https://www.youtube.com/watch?v=wT8fViZpLmQ&index=3&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class AimIK : IK
	{
		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverAim solver;

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x10102E0", Offset = "0x10102E0", VA = "0x10102E0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1010324", Offset = "0x1010324", VA = "0x1010324", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1010368", Offset = "0x1010368", VA = "0x1010368")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x10103AC", Offset = "0x10103AC", VA = "0x10103AC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x10103F0", Offset = "0x10103F0", VA = "0x10103F0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1010434", Offset = "0x1010434", VA = "0x1010434", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x101043C", Offset = "0x101043C", VA = "0x101043C")]
		public AimIK()
		{
		}
	}
	[Token(Token = "0x200005B")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page2.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Arm IK")]
	public class ArmIK : IK
	{
		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverArm solver;

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x10104B8", Offset = "0x10104B8", VA = "0x10104B8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x10104FC", Offset = "0x10104FC", VA = "0x10104FC", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x1010540", Offset = "0x1010540", VA = "0x1010540")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x1010584", Offset = "0x1010584", VA = "0x1010584")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x10105C8", Offset = "0x10105C8", VA = "0x10105C8", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x10105D0", Offset = "0x10105D0", VA = "0x10105D0")]
		public ArmIK()
		{
		}
	}
	[Token(Token = "0x200005C")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/CCD IK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page5.html")]
	public class CCDIK : IK
	{
		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverCCD solver;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1010644", Offset = "0x1010644", VA = "0x1010644", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1010688", Offset = "0x1010688", VA = "0x1010688", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x10106CC", Offset = "0x10106CC", VA = "0x10106CC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x1010710", Offset = "0x1010710", VA = "0x1010710")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1010754", Offset = "0x1010754", VA = "0x1010754", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x101075C", Offset = "0x101075C", VA = "0x101075C")]
		public CCDIK()
		{
		}
	}
	[Token(Token = "0x200005D")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page6.html")]
	public class FABRIK : IK
	{
		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIK solver;

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x10107D0", Offset = "0x10107D0", VA = "0x10107D0", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x1010814", Offset = "0x1010814", VA = "0x1010814", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x1010858", Offset = "0x1010858", VA = "0x1010858")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x101089C", Offset = "0x101089C", VA = "0x101089C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x10108E0", Offset = "0x10108E0", VA = "0x10108E0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x10108E8", Offset = "0x10108E8", VA = "0x10108E8")]
		public FABRIK()
		{
		}
	}
	[Token(Token = "0x200005E")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page7.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/FABRIK Root")]
	public class FABRIKRoot : IK
	{
		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverFABRIKRoot solver;

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x101095C", Offset = "0x101095C", VA = "0x101095C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x10109A0", Offset = "0x10109A0", VA = "0x10109A0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x10109E4", Offset = "0x10109E4", VA = "0x10109E4")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1010A28", Offset = "0x1010A28", VA = "0x1010A28")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1010A6C", Offset = "0x1010A6C", VA = "0x1010A6C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1010A74", Offset = "0x1010A74", VA = "0x1010A74")]
		public FABRIKRoot()
		{
		}
	}
	[Token(Token = "0x200005F")]
	[HelpURL("https://www.youtube.com/watch?v=7__IafZGwvI&index=1&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Full Body Biped IK")]
	public class FullBodyBipedIK : IK
	{
		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public BipedReferences references;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public IKSolverFullBodyBiped solver;

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1010AE8", Offset = "0x1010AE8", VA = "0x1010AE8", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1010B2C", Offset = "0x1010B2C", VA = "0x1010B2C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1010B70", Offset = "0x1010B70", VA = "0x1010B70")]
		[ContextMenu("TUTORIAL VIDEO (SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1010BB4", Offset = "0x1010BB4", VA = "0x1010BB4")]
		[ContextMenu("TUTORIAL VIDEO (INSPECTOR)")]
		private void OpenInspectorTutorial()
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1010BF8", Offset = "0x1010BF8", VA = "0x1010BF8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1010C3C", Offset = "0x1010C3C", VA = "0x1010C3C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1010C80", Offset = "0x1010C80", VA = "0x1010C80")]
		public void SetReferences(BipedReferences references, Transform rootNode)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1010CC0", Offset = "0x1010CC0", VA = "0x1010CC0", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1010CC8", Offset = "0x1010CC8", VA = "0x1010CC8")]
		public bool ReferencesError(ref string errorMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1010E98", Offset = "0x1010E98", VA = "0x1010E98")]
		public bool ReferencesWarning(ref string warningMessage)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1011354", Offset = "0x1011354", VA = "0x1011354")]
		[ContextMenu("Reinitiate")]
		private void Reinitiate()
		{
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1011374", Offset = "0x1011374", VA = "0x1011374")]
		[ContextMenu("Auto-detect References")]
		private void AutoDetectReferences()
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1011464", Offset = "0x1011464", VA = "0x1011464")]
		public FullBodyBipedIK()
		{
		}
	}
	[Token(Token = "0x2000060")]
	public abstract class IK : SolverManager
	{
		[Token(Token = "0x6000333")]
		public abstract IKSolver GetIKSolver();

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1011514", Offset = "0x1011514", VA = "0x1011514", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x10115F8", Offset = "0x10115F8", VA = "0x10115F8", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x10117E8", Offset = "0x10117E8", VA = "0x10117E8", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x6000337")]
		protected abstract void OpenUserManual();

		[Token(Token = "0x6000338")]
		protected abstract void OpenScriptReference();

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x10104B0", Offset = "0x10104B0", VA = "0x10104B0")]
		protected IK()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class IKExecutionOrder : MonoBehaviour
	{
		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The IK components, assign in the order in which you wish to update them.")]
		public IK[] IKComponents;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Optional. Assign it if you are using 'Animate Physics' as the Update Mode.")]
		public Animator animator;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool fixedFrame;

		[Token(Token = "0x170000A3")]
		private bool animatePhysics
		{
			[Token(Token = "0x600033A")]
			[Address(RVA = "0x1011838", Offset = "0x1011838", VA = "0x1011838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x10118C4", Offset = "0x10118C4", VA = "0x10118C4")]
		private void Start()
		{
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x1011928", Offset = "0x1011928", VA = "0x1011928")]
		private void Update()
		{
		}

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x10119C8", Offset = "0x10119C8", VA = "0x10119C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x10119F4", Offset = "0x10119F4", VA = "0x10119F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x101194C", Offset = "0x101194C", VA = "0x101194C")]
		private void FixTransforms()
		{
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x1011A74", Offset = "0x1011A74", VA = "0x1011A74")]
		public IKExecutionOrder()
		{
		}
	}
	[Token(Token = "0x2000062")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page11.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Leg IK")]
	public class LegIK : IK
	{
		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLeg solver;

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x1011A7C", Offset = "0x1011A7C", VA = "0x1011A7C", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x1011AC0", Offset = "0x1011AC0", VA = "0x1011AC0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x1011B04", Offset = "0x1011B04", VA = "0x1011B04")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x1011B48", Offset = "0x1011B48", VA = "0x1011B48")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x1011B8C", Offset = "0x1011B8C", VA = "0x1011B8C", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x1011B94", Offset = "0x1011B94", VA = "0x1011B94")]
		public LegIK()
		{
		}
	}
	[Token(Token = "0x2000063")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page12.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Limb IK")]
	public class LimbIK : IK
	{
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLimb solver;

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x1011C08", Offset = "0x1011C08", VA = "0x1011C08", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x1011C4C", Offset = "0x1011C4C", VA = "0x1011C4C", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x1011C90", Offset = "0x1011C90", VA = "0x1011C90")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x1011CD4", Offset = "0x1011CD4", VA = "0x1011CD4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x1011D18", Offset = "0x1011D18", VA = "0x1011D18", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x1011D20", Offset = "0x1011D20", VA = "0x1011D20")]
		public LimbIK()
		{
		}
	}
	[Token(Token = "0x2000064")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page13.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Look At IK")]
	public class LookAtIK : IK
	{
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverLookAt solver;

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x1011D94", Offset = "0x1011D94", VA = "0x1011D94", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x1011DD8", Offset = "0x1011DD8", VA = "0x1011DD8", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x1011E1C", Offset = "0x1011E1C", VA = "0x1011E1C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x1011E60", Offset = "0x1011E60", VA = "0x1011E60")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x1011EA4", Offset = "0x1011EA4", VA = "0x1011EA4", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1011EAC", Offset = "0x1011EAC", VA = "0x1011EAC")]
		public LookAtIK()
		{
		}
	}
	[Token(Token = "0x2000065")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page15.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/Trigonometric IK")]
	public class TrigonometricIK : IK
	{
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public IKSolverTrigonometric solver;

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1011F20", Offset = "0x1011F20", VA = "0x1011F20", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1011F64", Offset = "0x1011F64", VA = "0x1011F64", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x1011FA8", Offset = "0x1011FA8", VA = "0x1011FA8")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1011FEC", Offset = "0x1011FEC", VA = "0x1011FEC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x1012030", Offset = "0x1012030", VA = "0x1012030", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1012038", Offset = "0x1012038", VA = "0x1012038")]
		public TrigonometricIK()
		{
		}
	}
	[Token(Token = "0x2000066")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/IK/VR IK")]
	public class VRIK : IK
	{
		[Serializable]
		[Token(Token = "0x2000067")]
		public class References
		{
			[Token(Token = "0x400032E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform root;

			[Token(Token = "0x400032F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform pelvis;

			[Token(Token = "0x4000330")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spine;

			[Token(Token = "0x4000331")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Optional")]
			public Transform chest;

			[Token(Token = "0x4000332")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Optional")]
			public Transform neck;

			[Token(Token = "0x4000333")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Transform head;

			[Token(Token = "0x4000334")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Optional")]
			public Transform leftShoulder;

			[Token(Token = "0x4000335")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Transform leftUpperArm;

			[Token(Token = "0x4000336")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Transform leftForearm;

			[Token(Token = "0x4000337")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Transform leftHand;

			[Token(Token = "0x4000338")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Optional")]
			public Transform rightShoulder;

			[Token(Token = "0x4000339")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Transform rightUpperArm;

			[Token(Token = "0x400033A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Transform rightForearm;

			[Token(Token = "0x400033B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Transform rightHand;

			[Token(Token = "0x400033C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftThigh;

			[Token(Token = "0x400033D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftCalf;

			[Token(Token = "0x400033E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform leftFoot;

			[Token(Token = "0x400033F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Tooltip("Optional")]
			public Transform leftToes;

			[Token(Token = "0x4000340")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightThigh;

			[Token(Token = "0x4000341")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightCalf;

			[Token(Token = "0x4000342")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			[Tooltip("VRIK also supports legless characters.If you do not wish to use legs, leave all leg references empty.")]
			public Transform rightFoot;

			[Token(Token = "0x4000343")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			[Tooltip("Optional")]
			public Transform rightToes;

			[Token(Token = "0x170000A4")]
			public bool isFilled
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x1012A88", Offset = "0x1012A88", VA = "0x1012A88")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000A5")]
			public bool isEmpty
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x10126CC", Offset = "0x10126CC", VA = "0x10126CC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000362")]
			[Address(RVA = "0x101308C", Offset = "0x101308C", VA = "0x101308C")]
			public Transform[] GetTransforms()
			{
				return null;
			}

			[Token(Token = "0x6000365")]
			[Address(RVA = "0x1012194", Offset = "0x1012194", VA = "0x1012194")]
			public static bool AutoDetectReferences(Transform root, out References references)
			{
				return default(bool);
			}

			[Token(Token = "0x6000366")]
			[Address(RVA = "0x1013084", Offset = "0x1013084", VA = "0x1013084")]
			public References()
			{
			}
		}

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Bone mapping. Right-click on the component header and select 'Auto-detect References' of fill in manually if not a Humanoid character. Chest, neck, shoulder and toe bones are optional. VRIK also supports legless characters. If you do not wish to use legs, leave all leg references empty.")]
		[ContextMenuItem("Auto-detect References", "AutoDetectReferences")]
		public References references;

		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The VRIK solver.")]
		public IKSolverVR solver;

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x10120AC", Offset = "0x10120AC", VA = "0x10120AC", Slot = "8")]
		[ContextMenu("User Manual")]
		protected override void OpenUserManual()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x10120F0", Offset = "0x10120F0", VA = "0x10120F0", Slot = "9")]
		[ContextMenu("Scrpt Reference")]
		protected override void OpenScriptReference()
		{
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x1012134", Offset = "0x1012134", VA = "0x1012134")]
		[ContextMenu("TUTORIAL VIDEO (STEAMVR SETUP)")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1012178", Offset = "0x1012178", VA = "0x1012178")]
		[ContextMenu("Auto-detect References")]
		public void AutoDetectReferences()
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x1012630", Offset = "0x1012630", VA = "0x1012630")]
		[ContextMenu("Guess Hand Orientations")]
		public void GuessHandOrientations()
		{
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x1012658", Offset = "0x1012658", VA = "0x1012658", Slot = "7")]
		public override IKSolver GetIKSolver()
		{
			return null;
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x1012660", Offset = "0x1012660", VA = "0x1012660", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x1012E44", Offset = "0x1012E44", VA = "0x1012E44", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x1012FD4", Offset = "0x1012FD4", VA = "0x1012FD4")]
		public VRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000068")]
	public class FABRIKChain
	{
		[Token(Token = "0x4000344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FABRIK ik;

		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int[] children;

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x10135D0", Offset = "0x10135D0", VA = "0x10135D0")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x10136A0", Offset = "0x10136A0", VA = "0x10136A0")]
		public void Initiate()
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x10136C0", Offset = "0x10136C0", VA = "0x10136C0")]
		public void Stage1(FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1013914", Offset = "0x1013914", VA = "0x1013914")]
		public void Stage2(Vector3 rootPosition, FABRIKChain[] chain)
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1013780", Offset = "0x1013780", VA = "0x1013780")]
		private Vector3 GetCentroid(FABRIKChain[] chain)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600036C")]
		[Address(RVA = "0x10139F8", Offset = "0x10139F8", VA = "0x10139F8")]
		public FABRIKChain()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public class FBBIKArmBending : MonoBehaviour
	{
		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 bendDirectionOffsetLeft;

		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 bendDirectionOffsetRight;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 characterSpaceBendOffsetLeft;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 characterSpaceBendOffsetRight;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandTargetRotation;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Quaternion rightHandTargetRotation;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool initiated;

		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1013A64", Offset = "0x1013A64", VA = "0x1013A64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1013F14", Offset = "0x1013F14", VA = "0x1013F14")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x600036F")]
		[Address(RVA = "0x10140A8", Offset = "0x10140A8", VA = "0x10140A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x10141D4", Offset = "0x10141D4", VA = "0x10141D4")]
		public FBBIKArmBending()
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class FBBIKHeadEffector : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		public class BendBone
		{
			[Token(Token = "0x400037E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Assign spine and/or neck bones.")]
			public Transform transform;

			[Token(Token = "0x400037F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight of rotating this bone.")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x4000380")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x600037F")]
			[Address(RVA = "0x101748C", Offset = "0x101748C", VA = "0x101748C")]
			public BendBone()
			{
			}

			[Token(Token = "0x6000380")]
			[Address(RVA = "0x10174EC", Offset = "0x10174EC", VA = "0x10174EC")]
			public BendBone(Transform transform, float weight)
			{
			}

			[Token(Token = "0x6000381")]
			[Address(RVA = "0x1014ACC", Offset = "0x1014ACC", VA = "0x1014ACC")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000382")]
			[Address(RVA = "0x1014E9C", Offset = "0x1014E9C", VA = "0x1014E9C")]
			public void FixTransforms()
			{
			}
		}

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the FBBIK component.")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight for positioning the head.")]
		[LargeHeader("Position")]
		public float positionWeight;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The weight of moving the body along with the head")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of moving the thighs along with the head")]
		[Range(0f, 1f)]
		public float thighWeight;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If false, hands will not pull the head away if they are too far. Disabling this will improve performance significantly.")]
		public bool handsPullBody;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rotating the head bone after solving")]
		[LargeHeader("Rotation")]
		public float rotationWeight;

		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Clamping the rotation of the body")]
		[Range(0f, 1f)]
		public float bodyClampWeight;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		[Tooltip("Clamping the rotation of the head")]
		public float headClampWeight;

		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of bending/twisting the spine to the rotation of the head effector. This is similar to CCD, but uses the rotation of the head effector not the position.")]
		public float bendWeight;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The bones to use for bending.")]
		public BendBone[] bendBones;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		[Tooltip("Optional. The master weight of the CCD (Cyclic Coordinate Descent) IK effect that bends the spine towards the head effector before FBBIK solves.")]
		[LargeHeader("CCD")]
		public float CCDWeight;

		[Token(Token = "0x400035B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		[Tooltip("The weight of rolling the bones in towards the target")]
		public float roll;

		[Token(Token = "0x400035C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1000f)]
		[Tooltip("Smoothing the CCD effect.")]
		public float damper;

		[Token(Token = "0x400035D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Bones to use for the CCD pass. Assign spine and/or neck bones.")]
		public Transform[] CCDBones;

		[Token(Token = "0x400035E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[LargeHeader("Stretching")]
		[Tooltip("Stretching the spine/neck to help reach the target. This is useful for making sure the head stays locked relative to the VR headset. NB! Stretching is done after FBBIK has solved so if you have the hand effectors pinned and spine bones included in the 'Stretch Bones', the hands might become offset from their target positions.")]
		[Range(0f, 1f)]
		public float postStretchWeight;

		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Tooltip("Stretch magnitude limit.")]
		public float maxStretch;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("If > 0, dampers the stretching effect.")]
		public float stretchDamper;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If true, will fix head position to this Transform no matter what. Good for making sure the head will not budge away from the VR headset")]
		public bool fixHead;

		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("Bones to use for stretching. The more bones you add, the less noticable the effect.")]
		public Transform[] stretchBones;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[LargeHeader("Chest Direction")]
		public Vector3 chestDirection;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float chestDirectionWeight;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform[] chestBones;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public IKSolver.UpdateDelegate OnPostHeadEffectorFK;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 offset;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 headToBody;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 shoulderCenterToHead;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private Vector3 headToLeftThigh;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private Vector3 headToRightThigh;

		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 leftShoulderPos;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Vector3 rightShoulderPos;

		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		private float shoulderDist;

		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private float leftShoulderDist;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private float rightShoulderDist;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Quaternion chestRotation;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Quaternion headRotationRelativeToRoot;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion[] ccdDefaultLocalRotations;

		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 headLocalPosition;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
		private Quaternion headLocalRotation;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private Vector3[] stretchLocalPositions;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Quaternion[] stretchLocalRotations;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Vector3[] chestLocalPositions;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Quaternion[] chestLocalRotations;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private int bendBonesCount;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private int ccdBonesCount;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private int stretchBonesCount;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private int chestBonesCount;

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x10141DC", Offset = "0x10141DC", VA = "0x10141DC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x101461C", Offset = "0x101461C", VA = "0x101461C")]
		private void OnStoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1014AF8", Offset = "0x1014AF8", VA = "0x1014AF8")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1014EC4", Offset = "0x1014EC4", VA = "0x1014EC4")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x10157C0", Offset = "0x10157C0", VA = "0x10157C0")]
		private void SpineBend()
		{
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x1015BB8", Offset = "0x1015BB8", VA = "0x1015BB8")]
		private void CCDPass()
		{
		}

		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1015FC8", Offset = "0x1015FC8", VA = "0x1015FC8")]
		private void Iterate(int iteration)
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1016940", Offset = "0x1016940", VA = "0x1016940")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1015504", Offset = "0x1015504", VA = "0x1015504")]
		private void ChestDirection()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1016B7C", Offset = "0x1016B7C", VA = "0x1016B7C")]
		private void PostStretching()
		{
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1016860", Offset = "0x1016860", VA = "0x1016860")]
		private void LerpSolverPosition(IKEffector effector, Vector3 position, float weight, Vector3 offset)
		{
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1016760", Offset = "0x1016760", VA = "0x1016760")]
		private void Solve(ref Vector3 pos1, ref Vector3 pos2, float nominalDistance)
		{
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1016EDC", Offset = "0x1016EDC", VA = "0x1016EDC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1017278", Offset = "0x1017278", VA = "0x1017278")]
		public FBBIKHeadEffector()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class FBIKChain
	{
		[Serializable]
		[Token(Token = "0x200006D")]
		public class ChildConstraint
		{
			[Token(Token = "0x4000398")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float pushElasticity;

			[Token(Token = "0x4000399")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float pullElasticity;

			[Token(Token = "0x400039A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Transform bone1;

			[Token(Token = "0x400039B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[SerializeField]
			private Transform bone2;

			[Token(Token = "0x400039E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float crossFade;

			[Token(Token = "0x400039F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float inverseCrossFade;

			[Token(Token = "0x40003A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int chain1Index;

			[Token(Token = "0x40003A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int chain2Index;

			[Token(Token = "0x170000A6")]
			public float nominalDistance
			{
				[Token(Token = "0x6000397")]
				[Address(RVA = "0x101A5F4", Offset = "0x101A5F4", VA = "0x101A5F4")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x101A5FC", Offset = "0x101A5FC", VA = "0x101A5FC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000A7")]
			public bool isRigid
			{
				[Token(Token = "0x6000399")]
				[Address(RVA = "0x101A604", Offset = "0x101A604", VA = "0x101A604")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600039A")]
				[Address(RVA = "0x101A60C", Offset = "0x101A60C", VA = "0x101A60C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600039B")]
			[Address(RVA = "0x101A618", Offset = "0x101A618", VA = "0x101A618")]
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f, float pullElasticity = 0f)
			{
			}

			[Token(Token = "0x600039C")]
			[Address(RVA = "0x10182C8", Offset = "0x10182C8", VA = "0x10182C8")]
			public void Initiate(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600039D")]
			[Address(RVA = "0x10189AC", Offset = "0x10189AC", VA = "0x10189AC")]
			public void OnPreSolve(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x600039E")]
			[Address(RVA = "0x101A3B8", Offset = "0x101A3B8", VA = "0x101A3B8")]
			public void Solve(IKSolverFullBody solver)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200006E")]
		public enum Smoothing
		{
			[Token(Token = "0x40003A3")]
			None,
			[Token(Token = "0x40003A4")]
			Exponential,
			[Token(Token = "0x40003A5")]
			Cubic
		}

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Range(0f, 1f)]
		public float pin;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Range(0f, 1f)]
		public float pull;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float push;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(-1f, 1f)]
		public float pushParent;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float reach;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Smoothing reachSmoothing;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Smoothing pushSmoothing;

		[Token(Token = "0x4000388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IKSolver.Node[] nodes;

		[Token(Token = "0x4000389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int[] children;

		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ChildConstraint[] childConstraints;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public IKConstraintBend bendConstraint;

		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float rootLength;

		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private bool initiated;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float length;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float distance;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private IKSolver.Point p;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float reachForce;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float pullParentSum;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float[] crossFades;

		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sqrMag1;

		[Token(Token = "0x4000395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float sqrMag2;

		[Token(Token = "0x4000396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float sqrMagDif;

		[Token(Token = "0x4000397")]
		private const float maxLimbLength = 0.99999f;

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1017574", Offset = "0x1017574", VA = "0x1017574")]
		public FBIKChain()
		{
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x101770C", Offset = "0x101770C", VA = "0x101770C")]
		public FBIKChain(float pin, float pull, params Transform[] nodeTransforms)
		{
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x101787C", Offset = "0x101787C", VA = "0x101787C")]
		public void SetNodes(params Transform[] boneTransforms)
		{
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x10179AC", Offset = "0x10179AC", VA = "0x10179AC")]
		public int GetNodeIndex(Transform boneTransform)
		{
			return default(int);
		}

		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1017A68", Offset = "0x1017A68", VA = "0x1017A68")]
		public bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1017B84", Offset = "0x1017B84", VA = "0x1017B84")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x10185C8", Offset = "0x10185C8", VA = "0x10185C8")]
		public void ReadPose(IKSolverFullBody solver, bool fullBody)
		{
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1017D00", Offset = "0x1017D00", VA = "0x1017D00")]
		private void CalculateBoneLengths(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1018B90", Offset = "0x1018B90", VA = "0x1018B90")]
		public void Reach(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1018E24", Offset = "0x1018E24", VA = "0x1018E24")]
		public Vector3 Push(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x10190F4", Offset = "0x10190F4", VA = "0x10190F4")]
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1019ABC", Offset = "0x1019ABC", VA = "0x1019ABC")]
		public void Stage1(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1019FB4", Offset = "0x1019FB4", VA = "0x1019FB4")]
		public void Stage2(IKSolverFullBody solver, Vector3 position)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x101A1B4", Offset = "0x101A1B4", VA = "0x101A1B4")]
		public void SolveConstraintSystems(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1019EA0", Offset = "0x1019EA0", VA = "0x1019EA0")]
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x101995C", Offset = "0x101995C", VA = "0x101995C")]
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1019E3C", Offset = "0x1019E3C", VA = "0x1019E3C")]
		private void SolveChildConstraints(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x101A290", Offset = "0x101A290", VA = "0x101A290")]
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance)
		{
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1019D68", Offset = "0x1019D68", VA = "0x1019D68")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x101A0B8", Offset = "0x101A0B8", VA = "0x101A0B8")]
		private void BackwardReach(Vector3 position)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006F")]
	public class IKConstraintBend
	{
		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone1;

		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone2;

		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone3;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bendGoal;

		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 direction;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion rotationOffset;

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Vector3 defaultLocalDirection;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Vector3 defaultChildDirection;

		[NonSerialized]
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float clampF;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int chainIndex1;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int nodeIndex1;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int chainIndex2;

		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int nodeIndex2;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int chainIndex3;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private int nodeIndex3;

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		private bool limbOrientationsSet;

		[Token(Token = "0x170000A8")]
		public bool initiated
		{
			[Token(Token = "0x60003A0")]
			[Address(RVA = "0x101A84C", Offset = "0x101A84C", VA = "0x101A84C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003A1")]
			[Address(RVA = "0x101A854", Offset = "0x101A854", VA = "0x101A854")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x101A674", Offset = "0x101A674", VA = "0x101A674")]
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x10176A0", Offset = "0x10176A0", VA = "0x10176A0")]
		public IKConstraintBend()
		{
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x101A860", Offset = "0x101A860", VA = "0x101A860")]
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x101831C", Offset = "0x101831C", VA = "0x101831C")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3)
		{
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1018360", Offset = "0x1018360", VA = "0x1018360")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x101AA3C", Offset = "0x101AA3C", VA = "0x101AA3C")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last)
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x101AD90", Offset = "0x101AD90", VA = "0x101AD90")]
		public void LimitBend(float solverWeight, float positionWeight)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x101932C", Offset = "0x101932C", VA = "0x101932C")]
		public Vector3 GetDir(IKSolverFullBody solver)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x101A8F4", Offset = "0x101A8F4", VA = "0x101A8F4")]
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x101A998", Offset = "0x101A998", VA = "0x101A998")]
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000070")]
	public class IKEffector
	{
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40003B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x40003BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float positionWeight;

		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Range(0f, 1f)]
		public float rotationWeight;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Quaternion rotation;

		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 positionOffset;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool effectChildNodes;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Range(0f, 1f)]
		public float maintainRelativePositionWeight;

		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform[] childBones;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform planeBone1;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform planeBone2;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform planeBone3;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Quaternion planeRotationOffset;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float posW;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float rotW;

		[Token(Token = "0x40003C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] localPositions;

		[Token(Token = "0x40003CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private bool usePlaneNodes;

		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Quaternion animatedPlaneRotation;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private Vector3 animatedPosition;

		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private bool firstUpdate;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int chainIndex;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int nodeIndex;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private int plane1ChainIndex;

		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private int plane1NodeIndex;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private int plane2ChainIndex;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private int plane2NodeIndex;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private int plane3ChainIndex;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private int plane3NodeIndex;

		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int[] childChainIndexes;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private int[] childNodeIndexes;

		[Token(Token = "0x170000A9")]
		public bool isEndEffector
		{
			[Token(Token = "0x60003AC")]
			[Address(RVA = "0x101B158", Offset = "0x101B158", VA = "0x101B158")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x101B160", Offset = "0x101B160", VA = "0x101B160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1016E80", Offset = "0x1016E80", VA = "0x1016E80")]
		public IKSolver.Node GetNode(IKSolverFullBody solver)
		{
			return null;
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x101B16C", Offset = "0x101B16C", VA = "0x101B16C")]
		public void PinToBone(float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x101B1F0", Offset = "0x101B1F0", VA = "0x101B1F0")]
		public IKEffector()
		{
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x101B3C0", Offset = "0x101B3C0", VA = "0x101B3C0")]
		public IKEffector(Transform bone, Transform[] childBones)
		{
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x101B5CC", Offset = "0x101B5CC", VA = "0x101B5CC")]
		public bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x101B8D4", Offset = "0x101B8D4", VA = "0x101B8D4")]
		public void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x101BBAC", Offset = "0x101BBAC", VA = "0x101BBAC")]
		public void ResetOffset(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x101BCCC", Offset = "0x101BCCC", VA = "0x101BCCC")]
		public void SetToTarget()
		{
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x101BD68", Offset = "0x101BD68", VA = "0x101BD68")]
		public void OnPreSolve(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x101C41C", Offset = "0x101C41C", VA = "0x101C41C")]
		public void OnPostWrite()
		{
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x101C474", Offset = "0x101C474", VA = "0x101C474")]
		private Quaternion GetPlaneRotation(IKSolverFullBody solver)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x101C648", Offset = "0x101C648", VA = "0x101C648")]
		public void Update(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x101C8A4", Offset = "0x101C8A4", VA = "0x101C8A4")]
		private Vector3 GetPosition(IKSolverFullBody solver, out Quaternion planeRotationOffset)
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x2000071")]
	public class IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000072")]
		public class BoneMap
		{
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int chainIndex;

			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int nodeIndex;

			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 localSwingAxis;

			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 localTwistAxis;

			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 planePosition;

			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 ikPosition;

			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion defaultLocalTargetRotation;

			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			private Quaternion maintainRotation;

			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			public float length;

			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Quaternion animatedRotation;

			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Transform planeBone1;

			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private Transform planeBone2;

			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			private Transform planeBone3;

			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int plane1ChainIndex;

			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int plane1NodeIndex;

			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			private int plane2ChainIndex;

			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
			private int plane2NodeIndex;

			[Token(Token = "0x40003EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			private int plane3ChainIndex;

			[Token(Token = "0x40003ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
			private int plane3NodeIndex;

			[Token(Token = "0x170000AA")]
			public Vector3 swingDirection
			{
				[Token(Token = "0x60003C0")]
				[Address(RVA = "0x101CE14", Offset = "0x101CE14", VA = "0x101CE14")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000AB")]
			public bool isNodeBone
			{
				[Token(Token = "0x60003C3")]
				[Address(RVA = "0x101CECC", Offset = "0x101CECC", VA = "0x101CECC")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000AC")]
			private Quaternion lastAnimatedTargetRotation
			{
				[Token(Token = "0x60003D7")]
				[Address(RVA = "0x101D2B8", Offset = "0x101D2B8", VA = "0x101D2B8")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x101CDD0", Offset = "0x101CDD0", VA = "0x101CDD0")]
			public void Initiate(Transform transform, IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x101CE44", Offset = "0x101CE44", VA = "0x101CE44")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x60003C2")]
			[Address(RVA = "0x101CE88", Offset = "0x101CE88", VA = "0x101CE88")]
			public void FixTransform(bool position)
			{
			}

			[Token(Token = "0x60003C4")]
			[Address(RVA = "0x101CEDC", Offset = "0x101CEDC", VA = "0x101CEDC")]
			public void SetLength(BoneMap nextBone)
			{
			}

			[Token(Token = "0x60003C5")]
			[Address(RVA = "0x101CFB0", Offset = "0x101CFB0", VA = "0x101CFB0")]
			public void SetLocalSwingAxis(BoneMap swingTarget)
			{
			}

			[Token(Token = "0x60003C6")]
			[Address(RVA = "0x101CFB8", Offset = "0x101CFB8", VA = "0x101CFB8")]
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2)
			{
			}

			[Token(Token = "0x60003C7")]
			[Address(RVA = "0x101D084", Offset = "0x101D084", VA = "0x101D084")]
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection)
			{
			}

			[Token(Token = "0x60003C8")]
			[Address(RVA = "0x101D0F0", Offset = "0x101D0F0", VA = "0x101D0F0")]
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3)
			{
			}

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x101D1A8", Offset = "0x101D1A8", VA = "0x101D1A8")]
			public void UpdatePlane(bool rotation, bool position)
			{
			}

			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x101D420", Offset = "0x101D420", VA = "0x101D420")]
			public void SetIKPosition()
			{
			}

			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x101D44C", Offset = "0x101D44C", VA = "0x101D44C")]
			public void MaintainRotation()
			{
			}

			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x101D478", Offset = "0x101D478", VA = "0x101D478")]
			public void SetToIKPosition()
			{
			}

			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x101D4A0", Offset = "0x101D4A0", VA = "0x101D4A0")]
			public void FixToNode(IKSolverFullBody solver, float weight, [Optional] IKSolver.Node fixNode)
			{
			}

			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x101D564", Offset = "0x101D564", VA = "0x101D564")]
			public Vector3 GetPlanePosition(IKSolverFullBody solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x101D6F8", Offset = "0x101D6F8", VA = "0x101D6F8")]
			public void PositionToPlane(IKSolverFullBody solver)
			{
			}

			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x101D71C", Offset = "0x101D71C", VA = "0x101D71C")]
			public void RotateToPlane(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x101D83C", Offset = "0x101D83C", VA = "0x101D83C")]
			public void Swing(Vector3 swingTarget, float weight)
			{
			}

			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x101D8A0", Offset = "0x101D8A0", VA = "0x101D8A0")]
			public void Swing(Vector3 pos1, Vector3 pos2, float weight)
			{
			}

			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x101DA20", Offset = "0x101DA20", VA = "0x101DA20")]
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight)
			{
			}

			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x101DBA0", Offset = "0x101DBA0", VA = "0x101DBA0")]
			public void RotateToMaintain(float weight)
			{
			}

			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x101DC1C", Offset = "0x101DC1C", VA = "0x101DC1C")]
			public void RotateToEffector(IKSolverFullBody solver, float weight)
			{
			}

			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x101D5DC", Offset = "0x101D5DC", VA = "0x101D5DC")]
			private Quaternion GetTargetRotation(IKSolverFullBody solver)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x101DD44", Offset = "0x101DD44", VA = "0x101DD44")]
			public BoneMap()
			{
			}
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x101CB60", Offset = "0x101CB60", VA = "0x101CB60", Slot = "4")]
		public virtual bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x101CB68", Offset = "0x101CB68", VA = "0x101CB68", Slot = "5")]
		public virtual void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x101CB6C", Offset = "0x101CB6C", VA = "0x101CB6C")]
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, [Optional] Warning.Logger logger)
		{
			return default(bool);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x101CCB4", Offset = "0x101CCB4", VA = "0x101CCB4")]
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x101CDC8", Offset = "0x101CDC8", VA = "0x101CDC8")]
		public IKMapping()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class IKMappingBone : IKMapping
	{
		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform bone;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private BoneMap boneMap;

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x101DD60", Offset = "0x101DD60", VA = "0x101DD60", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x101DE08", Offset = "0x101DE08", VA = "0x101DE08")]
		public IKMappingBone()
		{
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x101DE98", Offset = "0x101DE98", VA = "0x101DE98")]
		public IKMappingBone(Transform bone)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x101DF44", Offset = "0x101DF44", VA = "0x101DF44")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x101DF5C", Offset = "0x101DF5C", VA = "0x101DF5C")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x101DF78", Offset = "0x101DF78", VA = "0x101DF78", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x101E020", Offset = "0x101E020", VA = "0x101E020")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x101E038", Offset = "0x101E038", VA = "0x101E038")]
		public void WritePose(float solverWeight)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000074")]
	public class IKMappingLimb : IKMapping
	{
		[Serializable]
		[Token(Token = "0x2000075")]
		public enum BoneMapType
		{
			[Token(Token = "0x40003FD")]
			Parent,
			[Token(Token = "0x40003FE")]
			Bone1,
			[Token(Token = "0x40003FF")]
			Bone2,
			[Token(Token = "0x4000400")]
			Bone3
		}

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform parentBone;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform bone1;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform bone2;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform bone3;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float weight;

		[NonSerialized]
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool updatePlaneRotations;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BoneMap boneMapParent;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap boneMap1;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap boneMap2;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap boneMap3;

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x101E05C", Offset = "0x101E05C", VA = "0x101E05C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x101E0D0", Offset = "0x101E0D0", VA = "0x101E0D0")]
		public BoneMap GetBoneMap(BoneMapType boneMap)
		{
			return null;
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x101E198", Offset = "0x101E198", VA = "0x101E198")]
		public void SetLimbOrientation(Vector3 upper, Vector3 lower)
		{
		}

		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x101E450", Offset = "0x101E450", VA = "0x101E450")]
		public IKMappingLimb()
		{
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x101E59C", Offset = "0x101E59C", VA = "0x101E59C")]
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x101E720", Offset = "0x101E720", VA = "0x101E720")]
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, [Optional] Transform parentBone)
		{
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x101E780", Offset = "0x101E780", VA = "0x101E780")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x101E818", Offset = "0x101E818", VA = "0x101E818")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x101E8C0", Offset = "0x101E8C0", VA = "0x101E8C0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x101EB74", Offset = "0x101EB74", VA = "0x101EB74")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x101EBD4", Offset = "0x101EBD4", VA = "0x101EBD4")]
		public void WritePose(IKSolverFullBody solver, bool fullBody)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000076")]
	public class IKMappingSpine : IKMapping
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform[] spineBones;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform leftUpperArmBone;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform rightUpperArmBone;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftThighBone;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightThighBone;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(1f, 3f)]
		public int iterations;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float twistWeight;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int rootNodeIndex;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private BoneMap[] spine;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private BoneMap leftUpperArm;

		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private BoneMap rightUpperArm;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private BoneMap leftThigh;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private BoneMap rightThigh;

		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool useFABRIK;

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x101ED1C", Offset = "0x101ED1C", VA = "0x101ED1C", Slot = "4")]
		public override bool IsValid(IKSolver solver, ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x101F048", Offset = "0x101F048", VA = "0x101F048")]
		public IKMappingSpine()
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x101F1C0", Offset = "0x101F1C0", VA = "0x101F1C0")]
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x101F378", Offset = "0x101F378", VA = "0x101F378")]
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone)
		{
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x101F3EC", Offset = "0x101F3EC", VA = "0x101F3EC")]
		public void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x101F448", Offset = "0x101F448", VA = "0x101F448")]
		public void FixTransforms()
		{
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x101F4C0", Offset = "0x101F4C0", VA = "0x101F4C0", Slot = "5")]
		public override void Initiate(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x101FB38", Offset = "0x101FB38", VA = "0x101FB38")]
		private bool UseFABRIK()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x101FB70", Offset = "0x101FB70", VA = "0x101FB70")]
		public void ReadPose()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x101FDD4", Offset = "0x101FDD4", VA = "0x101FDD4")]
		public void WritePose(IKSolverFullBody solver)
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x10200FC", Offset = "0x10200FC", VA = "0x10200FC")]
		public void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x10201DC", Offset = "0x10201DC", VA = "0x10201DC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1020290", Offset = "0x1020290", VA = "0x1020290")]
		private void MapToSolverPositions(IKSolverFullBody solver)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000077")]
	public abstract class IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000078")]
		public class Point
		{
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Range(0f, 1f)]
			public float weight;

			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 solverPosition;

			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Quaternion solverRotation;

			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector3 defaultLocalPosition;

			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Quaternion defaultLocalRotation;

			[Token(Token = "0x600040F")]
			[Address(RVA = "0x1021980", Offset = "0x1021980", VA = "0x1021980")]
			public void StoreDefaultLocalState()
			{
			}

			[Token(Token = "0x6000410")]
			[Address(RVA = "0x10219C4", Offset = "0x10219C4", VA = "0x10219C4")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000411")]
			[Address(RVA = "0x1021AA4", Offset = "0x1021AA4", VA = "0x1021AA4")]
			public void UpdateSolverPosition()
			{
			}

			[Token(Token = "0x6000412")]
			[Address(RVA = "0x1021AD0", Offset = "0x1021AD0", VA = "0x1021AD0")]
			public void UpdateSolverLocalPosition()
			{
			}

			[Token(Token = "0x6000413")]
			[Address(RVA = "0x1021AFC", Offset = "0x1021AFC", VA = "0x1021AFC")]
			public void UpdateSolverState()
			{
			}

			[Token(Token = "0x6000414")]
			[Address(RVA = "0x1021B40", Offset = "0x1021B40", VA = "0x1021B40")]
			public void UpdateSolverLocalState()
			{
			}

			[Token(Token = "0x6000415")]
			[Address(RVA = "0x1021B84", Offset = "0x1021B84", VA = "0x1021B84")]
			public Point()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000079")]
		public class Bone : Point
		{
			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float sqrMag;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 axis;

			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private RotationLimit _rotationLimit;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private bool isLimited;

			[Token(Token = "0x170000AE")]
			public RotationLimit rotationLimit
			{
				[Token(Token = "0x6000416")]
				[Address(RVA = "0x1021BE4", Offset = "0x1021BE4", VA = "0x1021BE4")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000417")]
				[Address(RVA = "0x1021CD4", Offset = "0x1021CD4", VA = "0x1021CD4")]
				set
				{
				}
			}

			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1021D58", Offset = "0x1021D58", VA = "0x1021D58")]
			public void Swing(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1021FC4", Offset = "0x1021FC4", VA = "0x1021FC4")]
			public static void SolverSwing(Bone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1022280", Offset = "0x1022280", VA = "0x1022280")]
			public void Swing2D(Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1022474", Offset = "0x1022474", VA = "0x1022474")]
			public void SetToSolverPosition()
			{
			}

			[Token(Token = "0x600041C")]
			[Address(RVA = "0x102249C", Offset = "0x102249C", VA = "0x102249C")]
			public Bone()
			{
			}

			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1022508", Offset = "0x1022508", VA = "0x1022508")]
			public Bone(Transform transform)
			{
			}

			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1022588", Offset = "0x1022588", VA = "0x1022588")]
			public Bone(Transform transform, float weight)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200007A")]
		public class Node : Point
		{
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public float length;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float effectorPositionWeight;

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public float effectorRotationWeight;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 offset;

			[Token(Token = "0x600041F")]
			[Address(RVA = "0x102261C", Offset = "0x102261C", VA = "0x102261C")]
			public Node()
			{
			}

			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1022620", Offset = "0x1022620", VA = "0x1022620")]
			public Node(Transform transform)
			{
			}

			[Token(Token = "0x6000421")]
			[Address(RVA = "0x102264C", Offset = "0x102264C", VA = "0x102264C")]
			public Node(Transform transform, float weight)
			{
			}
		}

		[Token(Token = "0x200007B")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200007C")]
		public delegate void IterationDelegate(int i);

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[HideInInspector]
		public bool executedInEditor;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[HideInInspector]
		public Vector3 IKPosition;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The positional or the master weight of the solver.")]
		[Range(0f, 1f)]
		public float IKPositionWeight;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UpdateDelegate OnPreInitiate;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public UpdateDelegate OnPreUpdate;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UpdateDelegate OnPostUpdate;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected bool firstInitiation;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[HideInInspector]
		protected Transform root;

		[Token(Token = "0x170000AD")]
		public bool initiated
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0x102058C", Offset = "0x102058C", VA = "0x102058C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1020594", Offset = "0x1020594", VA = "0x1020594")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0x10204D4", Offset = "0x10204D4", VA = "0x10204D4")]
		public bool IsValid()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FA")]
		public abstract bool IsValid(ref string message);

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0x1011664", Offset = "0x1011664", VA = "0x1011664")]
		public void Initiate(Transform root)
		{
		}

		[Token(Token = "0x60003FC")]
		[Address(RVA = "0x1011588", Offset = "0x1011588", VA = "0x1011588")]
		public void Update()
		{
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1020548", Offset = "0x1020548", VA = "0x1020548", Slot = "5")]
		public virtual Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1020554", Offset = "0x1020554", VA = "0x1020554")]
		public void SetIKPosition(Vector3 position)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1020560", Offset = "0x1020560", VA = "0x1020560")]
		public float GetIKPositionWeight()
		{
			return default(float);
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1020568", Offset = "0x1020568", VA = "0x1020568")]
		public void SetIKPositionWeight(float weight)
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1020584", Offset = "0x1020584", VA = "0x1020584")]
		public Transform GetRoot()
		{
			return null;
		}

		[Token(Token = "0x6000404")]
		public abstract Point[] GetPoints();

		[Token(Token = "0x6000405")]
		public abstract Point GetPoint(Transform transform);

		[Token(Token = "0x6000406")]
		public abstract void FixTransforms();

		[Token(Token = "0x6000407")]
		public abstract void StoreDefaultLocalState();

		[Token(Token = "0x6000408")]
		protected abstract void OnInitiate();

		[Token(Token = "0x6000409")]
		protected abstract void OnUpdate();

		[Token(Token = "0x600040A")]
		[Address(RVA = "0x10205A0", Offset = "0x10205A0", VA = "0x10205A0")]
		protected void LogWarning(string message)
		{
		}

		[Token(Token = "0x600040B")]
		[Address(RVA = "0x10205B8", Offset = "0x10205B8", VA = "0x10205B8")]
		public static Transform ContainsDuplicateBone(Bone[] bones)
		{
			return null;
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0x10206DC", Offset = "0x10206DC", VA = "0x10206DC")]
		public static bool HierarchyIsValid(Bone[] bones)
		{
			return default(bool);
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0x1020774", Offset = "0x1020774", VA = "0x1020774")]
		protected static float PreSolveBones(ref Bone[] bones)
		{
			return default(float);
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0x1020968", Offset = "0x1020968", VA = "0x1020968")]
		protected IKSolver()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007D")]
	public class IKSolverAim : IKSolverHeuristic
	{
		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Transform transform;

		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 axis;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public Vector3 poleAxis;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public Vector3 polePosition;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float poleWeight;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform poleTarget;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x4000430")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000431")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private float step;

		[Token(Token = "0x4000432")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Vector3 clampedIKPosition;

		[Token(Token = "0x4000433")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private RotationLimit transformLimit;

		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Transform lastTransform;

		[Token(Token = "0x170000AF")]
		public Vector3 transformAxis
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0x1022A48", Offset = "0x1022A48", VA = "0x1022A48")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B0")]
		public Vector3 transformPoleAxis
		{
			[Token(Token = "0x600042C")]
			[Address(RVA = "0x1022A78", Offset = "0x1022A78", VA = "0x1022A78")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000B1")]
		protected override int minBones
		{
			[Token(Token = "0x600042F")]
			[Address(RVA = "0x10236C4", Offset = "0x10236C4", VA = "0x10236C4", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000B2")]
		protected override Vector3 localDirection
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0x1023C04", Offset = "0x1023C04", VA = "0x1023C04", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1022910", Offset = "0x1022910", VA = "0x1022910")]
		public float GetAngle()
		{
			return default(float);
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1022AA8", Offset = "0x1022AA8", VA = "0x1022AA8", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1022D34", Offset = "0x1022D34", VA = "0x1022D34", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x102361C", Offset = "0x102361C", VA = "0x102361C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x10232B8", Offset = "0x10232B8", VA = "0x10232B8")]
		private Vector3 GetClampedIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x10236CC", Offset = "0x10236CC", VA = "0x10236CC")]
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight)
		{
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1023C64", Offset = "0x1023C64", VA = "0x1023C64")]
		public IKSolverAim()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007E")]
	public class IKSolverArm : IKSolver
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point chest;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point shoulder;

		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point upperArm;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point forearm;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point hand;

		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isLeft;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IKSolverVR.Arm arm;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3[] positions;

		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion[] rotations;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1023D78", Offset = "0x1023D78", VA = "0x1023D78", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x102411C", Offset = "0x102411C", VA = "0x102411C")]
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x10241D0", Offset = "0x10241D0", VA = "0x10241D0", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x1024350", Offset = "0x1024350", VA = "0x1024350", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000439")]
		[Address(RVA = "0x10244B0", Offset = "0x10244B0", VA = "0x10244B0", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x10244F0", Offset = "0x10244F0", VA = "0x10244F0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x1024540", Offset = "0x1024540", VA = "0x1024540", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x10248A0", Offset = "0x10248A0", VA = "0x10248A0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x10248C0", Offset = "0x10248C0", VA = "0x10248C0")]
		private void Solve()
		{
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x1024598", Offset = "0x1024598", VA = "0x1024598")]
		private void Read()
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x1024924", Offset = "0x1024924", VA = "0x1024924")]
		private void Write()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x1024A9C", Offset = "0x1024A9C", VA = "0x1024A9C")]
		public IKSolverArm()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200007F")]
	public class IKSolverCCD : IKSolverHeuristic
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x1024C80", Offset = "0x1024C80", VA = "0x1024C80")]
		public void FadeOutBoneWeights()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x1024CF0", Offset = "0x1024CF0", VA = "0x1024CF0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x10251E4", Offset = "0x10251E4", VA = "0x10251E4", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x10258B8", Offset = "0x10258B8", VA = "0x10258B8")]
		protected void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x1025F48", Offset = "0x1025F48", VA = "0x1025F48")]
		public IKSolverCCD()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000080")]
	public class IKSolverFABRIK : IKSolverHeuristic
	{
		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool[] limitedBones;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3[] solverLocalPositions;

		[Token(Token = "0x170000B3")]
		protected override bool boneLengthCanBeZero
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0x1026F28", Offset = "0x1026F28", VA = "0x1026F28", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0x1025F4C", Offset = "0x1025F4C", VA = "0x1025F4C")]
		public void SolveForward(Vector3 position)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x1026528", Offset = "0x1026528", VA = "0x1026528")]
		public void SolveBackward(Vector3 position)
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x1026654", Offset = "0x1026654", VA = "0x1026654", Slot = "5")]
		public override Vector3 GetIKPosition()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x10266DC", Offset = "0x10266DC", VA = "0x10266DC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x1026BF0", Offset = "0x1026BF0", VA = "0x1026BF0", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1026F30", Offset = "0x1026F30", VA = "0x1026F30")]
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1026020", Offset = "0x1026020", VA = "0x1026020")]
		private void OnPreSolve()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x102660C", Offset = "0x102660C", VA = "0x102660C")]
		private void OnPostSolve()
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x1026EE0", Offset = "0x1026EE0", VA = "0x1026EE0")]
		private void Solve(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x10263BC", Offset = "0x10263BC", VA = "0x10263BC")]
		private void ForwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x10275DC", Offset = "0x10275DC", VA = "0x10275DC")]
		private void SolverMove(int index, Vector3 offset)
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x1027644", Offset = "0x1027644", VA = "0x1027644")]
		private void SolverRotate(int index, Quaternion rotation, bool recursive)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1027714", Offset = "0x1027714", VA = "0x1027714")]
		private void SolverRotateChildren(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x10277DC", Offset = "0x10277DC", VA = "0x10277DC")]
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x1026968", Offset = "0x1026968", VA = "0x1026968")]
		private Quaternion GetParentSolverRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x1026AAC", Offset = "0x1026AAC", VA = "0x1026AAC")]
		private Vector3 GetParentSolverPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x10278CC", Offset = "0x10278CC", VA = "0x10278CC")]
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x10271CC", Offset = "0x10271CC", VA = "0x10271CC")]
		private void LimitForward(int rotateBone, int limitBone)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x10265FC", Offset = "0x10265FC", VA = "0x10265FC")]
		private void BackwardReach(Vector3 position)
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1027F3C", Offset = "0x1027F3C", VA = "0x1027F3C")]
		private void BackwardReachUnlimited(Vector3 position)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1027A8C", Offset = "0x1027A8C", VA = "0x1027A8C")]
		private void BackwardReachLimited(Vector3 position)
		{
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x102704C", Offset = "0x102704C", VA = "0x102704C")]
		private void MapToSolverPositions()
		{
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x102711C", Offset = "0x102711C", VA = "0x102711C")]
		private void MapToSolverPositionsLimited()
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1027FF4", Offset = "0x1027FF4", VA = "0x1027FF4")]
		public IKSolverFABRIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000081")]
	public class IKSolverFABRIKRoot : IKSolver
	{
		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int iterations;

		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float rootPin;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FABRIKChain[] chains;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool zeroWeightApplied;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] isRoot;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 rootDefaultPosition;

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x102808C", Offset = "0x102808C", VA = "0x102808C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1028750", Offset = "0x1028750", VA = "0x1028750", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x10287DC", Offset = "0x10287DC", VA = "0x10287DC", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1028870", Offset = "0x1028870", VA = "0x1028870", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1028968", Offset = "0x1028968", VA = "0x1028968")]
		private bool IsRoot(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x10289F8", Offset = "0x10289F8", VA = "0x10289F8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1028DF8", Offset = "0x1028DF8", VA = "0x1028DF8", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1028FF0", Offset = "0x1028FF0", VA = "0x1028FF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1028E98", Offset = "0x1028E98", VA = "0x1028E98")]
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain)
		{
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1028BD0", Offset = "0x1028BD0", VA = "0x1028BD0")]
		private Vector3 GetCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1029074", Offset = "0x1029074", VA = "0x1029074")]
		public IKSolverFABRIKRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000082")]
	public class IKSolverFullBody : IKSolver
	{
		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		public int iterations;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public FBIKChain[] chain;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IKEffector[] effectors;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public IKMappingSpine spineMapping;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public IKMappingBone[] boneMappings;

		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public IKMappingLimb[] limbMappings;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public bool FABRIKPass;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnPreRead;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnPreSolve;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public IterationDelegate OnPreIteration;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IterationDelegate OnPostIteration;

		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnPreBend;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public UpdateDelegate OnPostSolve;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public UpdateDelegate OnStoreDefaultLocalState;

		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x10290E0", Offset = "0x10290E0", VA = "0x10290E0")]
		public IKEffector GetEffector(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x10291BC", Offset = "0x10291BC", VA = "0x10291BC")]
		public FBIKChain GetChain(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1029204", Offset = "0x1029204", VA = "0x1029204")]
		public int GetChainIndex(Transform transform)
		{
			return default(int);
		}

		[Token(Token = "0x600046D")]
		[Address(RVA = "0x1029318", Offset = "0x1029318", VA = "0x1029318")]
		public Node GetNode(int chainIndex, int nodeIndex)
		{
			return null;
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0x1029368", Offset = "0x1029368", VA = "0x1029368")]
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex)
		{
		}

		[Token(Token = "0x600046F")]
		[Address(RVA = "0x10293DC", Offset = "0x10293DC", VA = "0x10293DC", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000470")]
		[Address(RVA = "0x102957C", Offset = "0x102957C", VA = "0x102957C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000471")]
		[Address(RVA = "0x10296D8", Offset = "0x10296D8", VA = "0x10296D8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000472")]
		[Address(RVA = "0x10298DC", Offset = "0x10298DC", VA = "0x10298DC", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000473")]
		[Address(RVA = "0x10299B0", Offset = "0x10299B0", VA = "0x10299B0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000474")]
		[Address(RVA = "0x1029A98", Offset = "0x1029A98", VA = "0x1029A98", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000475")]
		[Address(RVA = "0x1029BF8", Offset = "0x1029BF8", VA = "0x1029BF8", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x1029D94", Offset = "0x1029D94", VA = "0x1029D94", Slot = "12")]
		protected virtual void ReadPose()
		{
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x1029FCC", Offset = "0x1029FCC", VA = "0x1029FCC", Slot = "13")]
		protected virtual void Solve()
		{
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x102A2AC", Offset = "0x102A2AC", VA = "0x102A2AC", Slot = "14")]
		protected virtual void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x102A2E4", Offset = "0x102A2E4", VA = "0x102A2E4", Slot = "15")]
		protected virtual void WritePose()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x102A3C8", Offset = "0x102A3C8", VA = "0x102A3C8")]
		public IKSolverFullBody()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000083")]
	public enum FullBodyBipedEffector
	{
		[Token(Token = "0x400045A")]
		Body,
		[Token(Token = "0x400045B")]
		LeftShoulder,
		[Token(Token = "0x400045C")]
		RightShoulder,
		[Token(Token = "0x400045D")]
		LeftThigh,
		[Token(Token = "0x400045E")]
		RightThigh,
		[Token(Token = "0x400045F")]
		LeftHand,
		[Token(Token = "0x4000460")]
		RightHand,
		[Token(Token = "0x4000461")]
		LeftFoot,
		[Token(Token = "0x4000462")]
		RightFoot
	}
	[Serializable]
	[Token(Token = "0x2000084")]
	public enum FullBodyBipedChain
	{
		[Token(Token = "0x4000464")]
		LeftArm,
		[Token(Token = "0x4000465")]
		RightArm,
		[Token(Token = "0x4000466")]
		LeftLeg,
		[Token(Token = "0x4000467")]
		RightLeg
	}
	[Serializable]
	[Token(Token = "0x2000085")]
	public class IKSolverFullBodyBiped : IKSolverFullBody
	{
		[Token(Token = "0x4000468")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Transform rootNode;

		[Token(Token = "0x4000469")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Range(0f, 1f)]
		public float spineStiffness;

		[Token(Token = "0x400046A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		[Range(-1f, 1f)]
		public float pullBodyVertical;

		[Token(Token = "0x400046B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Range(-1f, 1f)]
		public float pullBodyHorizontal;

		[Token(Token = "0x400046D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Vector3 offset;

		[Token(Token = "0x170000B4")]
		public IKEffector bodyEffector
		{
			[Token(Token = "0x600047B")]
			[Address(RVA = "0x102A514", Offset = "0x102A514", VA = "0x102A514")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B5")]
		public IKEffector leftShoulderEffector
		{
			[Token(Token = "0x600047C")]
			[Address(RVA = "0x102A654", Offset = "0x102A654", VA = "0x102A654")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public IKEffector rightShoulderEffector
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x102A65C", Offset = "0x102A65C", VA = "0x102A65C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B7")]
		public IKEffector leftThighEffector
		{
			[Token(Token = "0x600047E")]
			[Address(RVA = "0x102A664", Offset = "0x102A664", VA = "0x102A664")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		public IKEffector rightThighEffector
		{
			[Token(Token = "0x600047F")]
			[Address(RVA = "0x102A66C", Offset = "0x102A66C", VA = "0x102A66C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B9")]
		public IKEffector leftHandEffector
		{
			[Token(Token = "0x6000480")]
			[Address(RVA = "0x102A674", Offset = "0x102A674", VA = "0x102A674")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		public IKEffector rightHandEffector
		{
			[Token(Token = "0x6000481")]
			[Address(RVA = "0x102A67C", Offset = "0x102A67C", VA = "0x102A67C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BB")]
		public IKEffector leftFootEffector
		{
			[Token(Token = "0x6000482")]
			[Address(RVA = "0x102A684", Offset = "0x102A684", VA = "0x102A684")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		public IKEffector rightFootEffector
		{
			[Token(Token = "0x6000483")]
			[Address(RVA = "0x102A68C", Offset = "0x102A68C", VA = "0x102A68C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BD")]
		public FBIKChain leftArmChain
		{
			[Token(Token = "0x6000484")]
			[Address(RVA = "0x102A694", Offset = "0x102A694", VA = "0x102A694")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		public FBIKChain rightArmChain
		{
			[Token(Token = "0x6000485")]
			[Address(RVA = "0x102A6C0", Offset = "0x102A6C0", VA = "0x102A6C0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BF")]
		public FBIKChain leftLegChain
		{
			[Token(Token = "0x6000486")]
			[Address(RVA = "0x102A6EC", Offset = "0x102A6EC", VA = "0x102A6EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		public FBIKChain rightLegChain
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x102A718", Offset = "0x102A718", VA = "0x102A718")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C1")]
		public IKMappingLimb leftArmMapping
		{
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x102A744", Offset = "0x102A744", VA = "0x102A744")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		public IKMappingLimb rightArmMapping
		{
			[Token(Token = "0x6000489")]
			[Address(RVA = "0x102A76C", Offset = "0x102A76C", VA = "0x102A76C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C3")]
		public IKMappingLimb leftLegMapping
		{
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x102A798", Offset = "0x102A798", VA = "0x102A798")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		public IKMappingLimb rightLegMapping
		{
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x102A7C4", Offset = "0x102A7C4", VA = "0x102A7C4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C5")]
		public IKMappingBone headMapping
		{
			[Token(Token = "0x600048C")]
			[Address(RVA = "0x102A7F0", Offset = "0x102A7F0", VA = "0x102A7F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		public Vector3 pullBodyOffset
		{
			[Token(Token = "0x600049C")]
			[Address(RVA = "0x102CA2C", Offset = "0x102CA2C", VA = "0x102CA2C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600049D")]
			[Address(RVA = "0x102CA38", Offset = "0x102CA38", VA = "0x102CA38")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x102A818", Offset = "0x102A818", VA = "0x102A818")]
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x102A918", Offset = "0x102A918", VA = "0x102A918")]
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight)
		{
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x102A868", Offset = "0x102A868", VA = "0x102A868")]
		public FBIKChain GetChain(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x102A990", Offset = "0x102A990", VA = "0x102A990")]
		public FBIKChain GetChain(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000491")]
		[Address(RVA = "0x102A51C", Offset = "0x102A51C", VA = "0x102A51C")]
		public IKEffector GetEffector(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x102AA58", Offset = "0x102AA58", VA = "0x102AA58")]
		public IKEffector GetEndEffector(FullBodyBipedChain c)
		{
			return null;
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x102AB08", Offset = "0x102AB08", VA = "0x102AB08")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x102ABB4", Offset = "0x102ABB4", VA = "0x102ABB4")]
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector)
		{
			return null;
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x102AC60", Offset = "0x102AC60", VA = "0x102AC60")]
		public IKMappingSpine GetSpineMapping()
		{
			return null;
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x102AC68", Offset = "0x102AC68", VA = "0x102AC68")]
		public IKMappingBone GetHeadMapping()
		{
			return null;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x102AC90", Offset = "0x102AC90", VA = "0x102AC90")]
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb)
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x102AD50", Offset = "0x102AD50", VA = "0x102AD50", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x102AEE4", Offset = "0x102AEE4", VA = "0x102AEE4")]
		public void SetToReferences(BipedReferences references, [Optional] Transform rootNode)
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x102C324", Offset = "0x102C324", VA = "0x102C324")]
		public static Transform DetectRootNodeBone(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x102C8D4", Offset = "0x102C8D4", VA = "0x102C8D4")]
		public void SetLimbOrientations(BipedLimbOrientations o)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x102C930", Offset = "0x102C930", VA = "0x102C930")]
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x102C774", Offset = "0x102C774", VA = "0x102C774")]
		private static Transform GetLeftClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x102C824", Offset = "0x102C824", VA = "0x102C824")]
		private static Transform GetRightClavicle(BipedReferences references)
		{
			return null;
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x102CA44", Offset = "0x102CA44", VA = "0x102CA44")]
		private static bool Contains(Transform[] array, Transform transform)
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x102CB08", Offset = "0x102CB08", VA = "0x102CB08", Slot = "12")]
		protected override void ReadPose()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x102CBD8", Offset = "0x102CBD8", VA = "0x102CBD8")]
		private void PullBody()
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x102CCF4", Offset = "0x102CCF4", VA = "0x102CCF4")]
		private Vector3 GetBodyOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x102CE84", Offset = "0x102CE84", VA = "0x102CE84")]
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x102CFFC", Offset = "0x102CFFC", VA = "0x102CFFC", Slot = "14")]
		protected override void ApplyBendConstraints()
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x102D25C", Offset = "0x102D25C", VA = "0x102D25C", Slot = "15")]
		protected override void WritePose()
		{
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x102D2D4", Offset = "0x102D2D4", VA = "0x102D2D4")]
		public IKSolverFullBodyBiped()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000086")]
	public class IKSolverHeuristic : IKSolver
	{
		[Token(Token = "0x400046E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400046F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float tolerance;

		[Token(Token = "0x4000470")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public int maxIterations;

		[Token(Token = "0x4000471")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public bool useRotationLimits;

		[Token(Token = "0x4000472")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		public bool XY;

		[Token(Token = "0x4000473")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Bone[] bones;

		[Token(Token = "0x4000474")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Vector3 lastLocalDirection;

		[Token(Token = "0x4000475")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		protected float chainLength;

		[Token(Token = "0x170000C7")]
		protected virtual int minBones
		{
			[Token(Token = "0x60004B0")]
			[Address(RVA = "0x102DB68", Offset = "0x102DB68", VA = "0x102DB68", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000C8")]
		protected virtual bool boneLengthCanBeZero
		{
			[Token(Token = "0x60004B1")]
			[Address(RVA = "0x102DB70", Offset = "0x102DB70", VA = "0x102DB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000C9")]
		protected virtual bool allowCommonParent
		{
			[Token(Token = "0x60004B2")]
			[Address(RVA = "0x102DB78", Offset = "0x102DB78", VA = "0x102DB78", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CA")]
		protected virtual Vector3 localDirection
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x102DB88", Offset = "0x102DB88", VA = "0x102DB88", Slot = "15")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x170000CB")]
		protected float positionOffset
		{
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x1025870", Offset = "0x1025870", VA = "0x1025870")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x102D2E0", Offset = "0x102D2E0", VA = "0x102D2E0")]
		public bool SetChain(Transform[] hierarchy, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x102D48C", Offset = "0x102D48C", VA = "0x102D48C")]
		public void AddBone(Transform bone)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x102D5D8", Offset = "0x102D5D8", VA = "0x102D5D8", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x102D634", Offset = "0x102D634", VA = "0x102D634", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x102D6A4", Offset = "0x102D6A4", VA = "0x102D6A4", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x102DA84", Offset = "0x102DA84", VA = "0x102DA84", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x102DA8C", Offset = "0x102DA8C", VA = "0x102DA8C", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x102DB80", Offset = "0x102DB80", VA = "0x102DB80", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x102DB84", Offset = "0x102DB84", VA = "0x102DB84", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x1024D5C", Offset = "0x1024D5C", VA = "0x1024D5C")]
		protected void InitiateBones()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x10254C4", Offset = "0x10254C4", VA = "0x10254C4")]
		protected Vector3 GetSingularityOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x102DC44", Offset = "0x102DC44", VA = "0x102DC44")]
		private bool SingularityDetected()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1023D04", Offset = "0x1023D04", VA = "0x1023D04")]
		public IKSolverHeuristic()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000087")]
	public class IKSolverLeg : IKSolver
	{
		[Token(Token = "0x4000476")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x4000477")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public Quaternion IKRotation;

		[Token(Token = "0x4000478")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Point pelvis;

		[Token(Token = "0x4000479")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Point thigh;

		[Token(Token = "0x400047A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Point calf;

		[Token(Token = "0x400047B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Point foot;

		[Token(Token = "0x400047C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Point toe;

		[Token(Token = "0x400047D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public IKSolverVR.Leg leg;

		[Token(Token = "0x400047E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 heelOffset;

		[Token(Token = "0x400047F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3[] positions;

		[Token(Token = "0x4000480")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Quaternion[] rotations;

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x102DED8", Offset = "0x102DED8", VA = "0x102DED8", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x102E27C", Offset = "0x102E27C", VA = "0x102E27C")]
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x102E330", Offset = "0x102E330", VA = "0x102E330", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x102E4B0", Offset = "0x102E4B0", VA = "0x102E4B0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x102E610", Offset = "0x102E610", VA = "0x102E610", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x102E650", Offset = "0x102E650", VA = "0x102E650", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x102E6A0", Offset = "0x102E6A0", VA = "0x102E6A0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x102EA00", Offset = "0x102EA00", VA = "0x102EA00", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x102EA20", Offset = "0x102EA20", VA = "0x102EA20")]
		private void Solve()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x102E6F8", Offset = "0x102E6F8", VA = "0x102E6F8")]
		private void Read()
		{
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x102EAAC", Offset = "0x102EAAC", VA = "0x102EAAC")]
		private void Write()
		{
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x102EC24", Offset = "0x102EC24", VA = "0x102EC24")]
		public IKSolverLeg()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000088")]
	public class IKSolverLimb : IKSolverTrigonometric
	{
		[Serializable]
		[Token(Token = "0x2000089")]
		public enum BendModifier
		{
			[Token(Token = "0x4000492")]
			Animation,
			[Token(Token = "0x4000493")]
			Target,
			[Token(Token = "0x4000494")]
			Parent,
			[Token(Token = "0x4000495")]
			Arm,
			[Token(Token = "0x4000496")]
			Goal
		}

		[Serializable]
		[Token(Token = "0x200008A")]
		public struct AxisDirection
		{
			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 direction;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 axis;

			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float dot;

			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1030214", Offset = "0x1030214", VA = "0x1030214")]
			public AxisDirection(Vector3 direction, Vector3 axis)
			{
			}
		}

		[Token(Token = "0x4000481")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public AvatarIKGoal goal;

		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public BendModifier bendModifier;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[Range(0f, 1f)]
		public float maintainRotationWeight;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float bendModifierWeight;

		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public Transform bendGoal;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private bool maintainBendFor1Frame;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		private bool maintainRotationFor1Frame;

		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion defaultRootRotation;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		private Quaternion parentDefaultRotation;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Quaternion bone3RotationBeforeSolve;

		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Quaternion maintainRotation;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private Quaternion bone3DefaultRotation;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		private Vector3 _bendNormal;

		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private Vector3 animationNormal;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private AxisDirection[] axisDirectionsLeft;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private AxisDirection[] axisDirectionsRight;

		[Token(Token = "0x170000CC")]
		private AxisDirection[] axisDirections
		{
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x10301F8", Offset = "0x10301F8", VA = "0x10301F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x102EE08", Offset = "0x102EE08", VA = "0x102EE08")]
		public void MaintainRotation()
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x102EE4C", Offset = "0x102EE4C", VA = "0x102EE4C")]
		public void MaintainBend()
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x102EE8C", Offset = "0x102EE8C", VA = "0x102EE8C", Slot = "12")]
		protected override void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x102F3CC", Offset = "0x102F3CC", VA = "0x102F3CC", Slot = "13")]
		protected override void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x102FEE8", Offset = "0x102FEE8", VA = "0x102FEE8", Slot = "14")]
		protected override void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x102FF90", Offset = "0x102FF90", VA = "0x102FF90")]
		public IKSolverLimb()
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1030160", Offset = "0x1030160", VA = "0x1030160")]
		public IKSolverLimb(AvatarIKGoal goal)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x102F1E0", Offset = "0x102F1E0", VA = "0x102F1E0")]
		private void StoreAxisDirections(ref AxisDirection[] axisDirections)
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x102F488", Offset = "0x102F488", VA = "0x102F488")]
		private Vector3 GetModifiedBendNormal()
		{
			return default(Vector3);
		}
	}
	[Serializable]
	[Token(Token = "0x200008B")]
	public class IKSolverLookAt : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008C")]
		public class LookAtBone : Bone
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			public Vector3 baseForwardOffsetEuler;

			[Token(Token = "0x170000D3")]
			public Vector3 forward
			{
				[Token(Token = "0x60004F1")]
				[Address(RVA = "0x1032094", Offset = "0x1032094", VA = "0x1032094")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x60004ED")]
			[Address(RVA = "0x1032740", Offset = "0x1032740", VA = "0x1032740")]
			public LookAtBone()
			{
			}

			[Token(Token = "0x60004EE")]
			[Address(RVA = "0x10311B4", Offset = "0x10311B4", VA = "0x10311B4")]
			public LookAtBone(Transform transform)
			{
			}

			[Token(Token = "0x60004EF")]
			[Address(RVA = "0x10314A4", Offset = "0x10314A4", VA = "0x10314A4")]
			public void Initiate(Transform root)
			{
			}

			[Token(Token = "0x60004F0")]
			[Address(RVA = "0x10323DC", Offset = "0x10323DC", VA = "0x10323DC")]
			public void LookAt(Vector3 direction, float weight)
			{
			}
		}

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public LookAtBone[] spine;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public LookAtBone head;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public LookAtBone[] eyes;

		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Range(0f, 1f)]
		public float bodyWeight;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		[Range(0f, 1f)]
		public float headWeight;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float eyesWeight;

		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float clampWeight;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 1f)]
		public float clampWeightHead;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		[Range(0f, 1f)]
		public float clampWeightEyes;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[Range(0f, 2f)]
		public int clampSmoothing;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public AnimationCurve spineWeightCurve;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public Vector3 spineTargetOffset;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		protected Vector3[] spineForwards;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		protected Vector3[] headForwards;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		protected Vector3[] eyeForward;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool isDirty;

		[Token(Token = "0x170000CD")]
		protected bool spineIsValid
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x1030940", Offset = "0x1030940", VA = "0x1030940")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CE")]
		protected bool spineIsEmpty
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x1030AE8", Offset = "0x1030AE8", VA = "0x1030AE8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000CF")]
		protected bool headIsValid
		{
			[Token(Token = "0x60004E4")]
			[Address(RVA = "0x1030A0C", Offset = "0x1030A0C", VA = "0x1030A0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D0")]
		protected bool headIsEmpty
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0x1030B0C", Offset = "0x1030B0C", VA = "0x1030B0C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D1")]
		protected bool eyesIsValid
		{
			[Token(Token = "0x60004E7")]
			[Address(RVA = "0x1030A1C", Offset = "0x1030A1C", VA = "0x1030A1C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000D2")]
		protected bool eyesIsEmpty
		{
			[Token(Token = "0x60004E8")]
			[Address(RVA = "0x1030B78", Offset = "0x1030B78", VA = "0x1030B78")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x10303B0", Offset = "0x10303B0", VA = "0x10303B0")]
		public void SetLookAtWeight(float weight)
		{
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x10303CC", Offset = "0x10303CC", VA = "0x10303CC")]
		public void SetLookAtWeight(float weight, float bodyWeight)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x10303F8", Offset = "0x10303F8", VA = "0x10303F8")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1030430", Offset = "0x1030430", VA = "0x1030430")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight)
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1030478", Offset = "0x1030478", VA = "0x1030478")]
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x10304D0", Offset = "0x10304D0", VA = "0x10304D0")]
		public void SetLookAtWeight(float weight, float bodyWeight = 0f, float headWeight = 1f, float eyesWeight = 0.5f, float clampWeight = 0.5f, float clampWeightHead = 0.5f, float clampWeightEyes = 0.3f)
		{
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1030540", Offset = "0x1030540", VA = "0x1030540", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x103064C", Offset = "0x103064C", VA = "0x103064C")]
		public void SetDirty()
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1030658", Offset = "0x1030658", VA = "0x1030658", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x103077C", Offset = "0x103077C", VA = "0x103077C", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1030B9C", Offset = "0x1030B9C", VA = "0x1030B9C", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1030DF0", Offset = "0x1030DF0", VA = "0x1030DF0", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1030F50", Offset = "0x1030F50", VA = "0x1030F50")]
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x10311E0", Offset = "0x10311E0", VA = "0x10311E0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1031590", Offset = "0x1031590", VA = "0x1031590", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1031654", Offset = "0x1031654", VA = "0x1031654")]
		protected void SolveSpine()
		{
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1031870", Offset = "0x1031870", VA = "0x1031870")]
		protected void SolveHead()
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1031BB8", Offset = "0x1031BB8", VA = "0x1031BB8")]
		protected void SolveEyes()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x10320C4", Offset = "0x10320C4", VA = "0x10320C4")]
		protected Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp)
		{
			return null;
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1031014", Offset = "0x1031014", VA = "0x1031014")]
		protected void SetBones(Transform[] array, ref LookAtBone[] bones)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x10324E4", Offset = "0x10324E4", VA = "0x10324E4")]
		public IKSolverLookAt()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008D")]
	public class IKSolverTrigonometric : IKSolver
	{
		[Serializable]
		[Token(Token = "0x200008E")]
		public class TrigonometricBone : Bone
		{
			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			private Quaternion targetToLocalSpace;

			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private Vector3 defaultLocalBendNormal;

			[Token(Token = "0x6000509")]
			[Address(RVA = "0x1034230", Offset = "0x1034230", VA = "0x1034230")]
			public void Initiate(Vector3 childPosition, Vector3 bendNormal)
			{
			}

			[Token(Token = "0x600050A")]
			[Address(RVA = "0x1034320", Offset = "0x1034320", VA = "0x1034320")]
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal)
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600050B")]
			[Address(RVA = "0x10343B0", Offset = "0x10343B0", VA = "0x10343B0")]
			public Vector3 GetBendNormalFromCurrentRotation()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600050C")]
			[Address(RVA = "0x10343E0", Offset = "0x10343E0", VA = "0x10343E0")]
			public TrigonometricBone()
			{
			}
		}

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform target;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float IKRotationWeight;

		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Quaternion IKRotation;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public Vector3 bendNormal;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public TrigonometricBone bone1;

		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public TrigonometricBone bone2;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public TrigonometricBone bone3;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		protected Vector3 weightIKPosition;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		protected bool directHierarchy;

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1032744", Offset = "0x1032744", VA = "0x1032744")]
		public void SetBendGoalPosition(Vector3 goalPosition, float weight)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x10328D8", Offset = "0x10328D8", VA = "0x10328D8")]
		public void SetBendPlaneToCurrent()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1032A58", Offset = "0x1032A58", VA = "0x1032A58")]
		public void SetIKRotation(Quaternion rotation)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1032A64", Offset = "0x1032A64", VA = "0x1032A64")]
		public void SetIKRotationWeight(float weight)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1032A80", Offset = "0x1032A80", VA = "0x1032A80")]
		public Quaternion GetIKRotation()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1032A8C", Offset = "0x1032A8C", VA = "0x1032A8C")]
		public float GetIKRotationWeight()
		{
			return default(float);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1032A94", Offset = "0x1032A94", VA = "0x1032A94", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1032BA4", Offset = "0x1032BA4", VA = "0x1032BA4", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1032C9C", Offset = "0x1032C9C", VA = "0x1032C9C", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1032CD0", Offset = "0x1032CD0", VA = "0x1032CD0", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1032D14", Offset = "0x1032D14", VA = "0x1032D14", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x10330E8", Offset = "0x10330E8", VA = "0x10330E8")]
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1033164", Offset = "0x1033164", VA = "0x1033164")]
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1033658", Offset = "0x1033658", VA = "0x1033658")]
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x10337B0", Offset = "0x10337B0", VA = "0x10337B0", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1033964", Offset = "0x1033964", VA = "0x1033964")]
		private bool IsDirectHierarchy()
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x10338DC", Offset = "0x10338DC", VA = "0x10338DC")]
		private void InitiateBones()
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x1033A54", Offset = "0x1033A54", VA = "0x1033A54", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x1034224", Offset = "0x1034224", VA = "0x1034224", Slot = "12")]
		protected virtual void OnInitiateVirtual()
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1034228", Offset = "0x1034228", VA = "0x1034228", Slot = "13")]
		protected virtual void OnUpdateVirtual()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x103422C", Offset = "0x103422C", VA = "0x103422C", Slot = "14")]
		protected virtual void OnPostSolveVirtual()
		{
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x1034064", Offset = "0x1034064", VA = "0x1034064")]
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x1030014", Offset = "0x1030014", VA = "0x1030014")]
		public IKSolverTrigonometric()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008F")]
	public class IKSolverVR : IKSolver
	{
		[Serializable]
		[Token(Token = "0x2000090")]
		public class Arm : BodyPart
		{
			[Serializable]
			[Token(Token = "0x2000091")]
			public enum ShoulderRotationMode
			{
				[Token(Token = "0x40004FA")]
				YawPitch,
				[Token(Token = "0x40004FB")]
				FromTo
			}

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The hand target. This should not be the hand controller itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the hand bone. The best practice for setup would be to move the hand controller to the avatar's hand as it it was held by the avatar, duplicate the avatar's hand bone and parent it to the hand controller. Then assign the duplicate to this slot.")]
			public Transform target;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The elbow will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Positional weight of the hand target. Note that if you have nulled the target, the hand will still be pulled to the last position of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float positionWeight;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the hand target. Note that if you have nulled the target, the hand will still be rotated to the last rotation of the target until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Different techniques for shoulder bone rotation.")]
			public ShoulderRotationMode shoulderRotationMode;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Tooltip("The weight of shoulder rotation")]
			[Range(0f, 1f)]
			public float shoulderRotationWeight;

			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Range(0f, 1f)]
			[Tooltip("The weight of twisting the shoulders backwards when arms are lifted up.")]
			public float shoulderTwistWeight;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the elbow towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Angular offset of the elbow bending direction.")]
			[Range(-180f, 180f)]
			public float swivelOffset;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Local axis of the hand bone that points from the wrist towards the palm. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 wristToPalmAxis;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Local axis of the hand bone that points from the palm towards the thumb. Used for defining hand bone orientation. If you have copied VRIK component from another avatar that has different bone orientations, right-click on VRIK header and select 'Guess Hand Orientations' from the context menu.")]
			public Vector3 palmToThumbAxis;

			[Token(Token = "0x40004E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the arm shorter/longer. Works by displacement of hand and forearm localPosition.")]
			public float armLengthMlp;

			[Token(Token = "0x40004E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Evaluates stretching of the arm by target distance relative to arm length. Value at time 1 represents stretching amount at the point where distance to the target is equal to arm length. Value at time 2 represents stretching amount at the point where distance to the target is double the arm length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce elbow snapping (start stretching the arm slightly before target distance reaches arm length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x40004E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
			[HideInInspector]
			public Vector3 bendDirection;

			[NonSerialized]
			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public Vector3 handPositionOffset;

			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			private bool hasShoulder;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
			private Vector3 chestForwardAxis;

			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			private Vector3 chestUpAxis;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
			private Quaternion chestRotation;

			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
			private Vector3 chestForward;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
			private Vector3 chestUp;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			private Quaternion forearmRelToUpperArm;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
			private Vector3 upperArmBendAxis;

			[Token(Token = "0x40004F7")]
			private const float yawOffsetAngle = 45f;

			[Token(Token = "0x40004F8")]
			private const float pitchOffsetAngle = -30f;

			[Token(Token = "0x170000D5")]
			public Vector3 position
			{
				[Token(Token = "0x6000529")]
				[Address(RVA = "0x103C910", Offset = "0x103C910", VA = "0x103C910")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600052A")]
				[Address(RVA = "0x103C91C", Offset = "0x103C91C", VA = "0x103C91C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D6")]
			public Quaternion rotation
			{
				[Token(Token = "0x600052B")]
				[Address(RVA = "0x103C928", Offset = "0x103C928", VA = "0x103C928")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600052C")]
				[Address(RVA = "0x103C934", Offset = "0x103C934", VA = "0x103C934")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000D7")]
			private VirtualBone shoulder
			{
				[Token(Token = "0x600052D")]
				[Address(RVA = "0x103C940", Offset = "0x103C940", VA = "0x103C940")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D8")]
			private VirtualBone upperArm
			{
				[Token(Token = "0x600052E")]
				[Address(RVA = "0x103C968", Offset = "0x103C968", VA = "0x103C968")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000D9")]
			private VirtualBone forearm
			{
				[Token(Token = "0x600052F")]
				[Address(RVA = "0x103C99C", Offset = "0x103C99C", VA = "0x103C99C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000DA")]
			private VirtualBone hand
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x103C9DC", Offset = "0x103C9DC", VA = "0x103C9DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000531")]
			[Address(RVA = "0x103CA1C", Offset = "0x103CA1C", VA = "0x103CA1C", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000532")]
			[Address(RVA = "0x103D3A4", Offset = "0x103D3A4", VA = "0x103D3A4", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000533")]
			[Address(RVA = "0x103D650", Offset = "0x103D650", VA = "0x103D650", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000534")]
			[Address(RVA = "0x103D674", Offset = "0x103D674", VA = "0x103D674")]
			private void Stretching()
			{
			}

			[Token(Token = "0x6000535")]
			[Address(RVA = "0x103A4BC", Offset = "0x103A4BC", VA = "0x103A4BC")]
			public void Solve(bool isLeft)
			{
			}

			[Token(Token = "0x6000536")]
			[Address(RVA = "0x103E610", Offset = "0x103E610", VA = "0x103E610", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000537")]
			[Address(RVA = "0x103E668", Offset = "0x103E668", VA = "0x103E668", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000538")]
			[Address(RVA = "0x103D9C4", Offset = "0x103D9C4", VA = "0x103D9C4")]
			private float DamperValue(float value, float min, float max, float weight = 1f)
			{
				return default(float);
			}

			[Token(Token = "0x6000539")]
			[Address(RVA = "0x103DBCC", Offset = "0x103DBCC", VA = "0x103DBCC")]
			private Vector3 GetBendNormal(Vector3 dir)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600053A")]
			[Address(RVA = "0x103E874", Offset = "0x103E874", VA = "0x103E874")]
			private void Visualize(VirtualBone bone1, VirtualBone bone2, VirtualBone bone3, Color color)
			{
			}

			[Token(Token = "0x600053B")]
			[Address(RVA = "0x103C574", Offset = "0x103C574", VA = "0x103C574")]
			public Arm()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000092")]
		public abstract class BodyPart
		{
			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public VirtualBone[] bones;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			protected bool initiated;

			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			protected Vector3 rootPosition;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			protected Quaternion rootRotation;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			protected int index;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			protected int LOD;

			[Token(Token = "0x170000DB")]
			public float sqrMag
			{
				[Token(Token = "0x6000541")]
				[Address(RVA = "0x103EA30", Offset = "0x103EA30", VA = "0x103EA30")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000542")]
				[Address(RVA = "0x103EA38", Offset = "0x103EA38", VA = "0x103EA38")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000DC")]
			public float mag
			{
				[Token(Token = "0x6000543")]
				[Address(RVA = "0x103EA40", Offset = "0x103EA40", VA = "0x103EA40")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000544")]
				[Address(RVA = "0x103EA48", Offset = "0x103EA48", VA = "0x103EA48")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x600053C")]
			protected abstract void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index);

			[Token(Token = "0x600053D")]
			public abstract void PreSolve();

			[Token(Token = "0x600053E")]
			public abstract void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations);

			[Token(Token = "0x600053F")]
			public abstract void ApplyOffsets(float scale);

			[Token(Token = "0x6000540")]
			public abstract void ResetOffsets();

			[Token(Token = "0x6000545")]
			[Address(RVA = "0x103EA50", Offset = "0x103EA50", VA = "0x103EA50")]
			public void SetLOD(int LOD)
			{
			}

			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1038264", Offset = "0x1038264", VA = "0x1038264")]
			public void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000547")]
			[Address(RVA = "0x103EBB8", Offset = "0x103EBB8", VA = "0x103EBB8")]
			public void MovePosition(Vector3 position)
			{
			}

			[Token(Token = "0x6000548")]
			[Address(RVA = "0x103EC40", Offset = "0x103EC40", VA = "0x103EC40")]
			public void MoveRotation(Quaternion rotation)
			{
			}

			[Token(Token = "0x6000549")]
			[Address(RVA = "0x103EE44", Offset = "0x103EE44", VA = "0x103EE44")]
			public void Translate(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600054A")]
			[Address(RVA = "0x103A10C", Offset = "0x103A10C", VA = "0x103A10C")]
			public void TranslateRoot(Vector3 newRootPos, Quaternion newRootRot)
			{
			}

			[Token(Token = "0x600054B")]
			[Address(RVA = "0x103E4AC", Offset = "0x103E4AC", VA = "0x103E4AC")]
			public void RotateTo(VirtualBone bone, Quaternion rotation, float weight = 1f)
			{
			}

			[Token(Token = "0x600054C")]
			[Address(RVA = "0x103EE8C", Offset = "0x103EE8C", VA = "0x103EE8C")]
			public void Visualize(Color color)
			{
			}

			[Token(Token = "0x600054D")]
			[Address(RVA = "0x103EFB0", Offset = "0x103EFB0", VA = "0x103EFB0")]
			public void Visualize()
			{
			}

			[Token(Token = "0x600054E")]
			[Address(RVA = "0x103E98C", Offset = "0x103E98C", VA = "0x103E98C")]
			protected BodyPart()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000093")]
		public class Footstep
		{
			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float stepSpeed;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 characterSpaceOffset;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 position;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Quaternion rotation;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Quaternion stepToRootRot;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isSupportLeg;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
			public bool relaxFlag;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			public Vector3 stepFrom;

			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Vector3 stepTo;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			public Quaternion stepFromRot;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			public Quaternion stepToRot;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			private Quaternion footRelativeToRoot;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private float supportLegW;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private float supportLegWV;

			[Token(Token = "0x170000DD")]
			public bool isStepping
			{
				[Token(Token = "0x600054F")]
				[Address(RVA = "0x103EFC4", Offset = "0x103EFC4", VA = "0x103EFC4")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170000DE")]
			public float stepProgress
			{
				[Token(Token = "0x6000550")]
				[Address(RVA = "0x103EFD8", Offset = "0x103EFD8", VA = "0x103EFD8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6000551")]
				[Address(RVA = "0x103EFE0", Offset = "0x103EFE0", VA = "0x103EFE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000552")]
			[Address(RVA = "0x103EFE8", Offset = "0x103EFE8", VA = "0x103EFE8")]
			public Footstep(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation, Vector3 characterSpaceOffset)
			{
			}

			[Token(Token = "0x6000553")]
			[Address(RVA = "0x103F1AC", Offset = "0x103F1AC", VA = "0x103F1AC")]
			public void Reset(Quaternion rootRotation, Vector3 footPosition, Quaternion footRotation)
			{
			}

			[Token(Token = "0x6000554")]
			[Address(RVA = "0x103F1F4", Offset = "0x103F1F4", VA = "0x103F1F4")]
			public void StepTo(Vector3 p, Quaternion rootRotation, float stepThreshold)
			{
			}

			[Token(Token = "0x6000555")]
			[Address(RVA = "0x103F438", Offset = "0x103F438", VA = "0x103F438")]
			public void UpdateStepping(Vector3 p, Quaternion rootRotation, float speed)
			{
			}

			[Token(Token = "0x6000556")]
			[Address(RVA = "0x103F640", Offset = "0x103F640", VA = "0x103F640")]
			public void UpdateStanding(Quaternion rootRotation, float minAngle, float speed)
			{
			}

			[Token(Token = "0x6000557")]
			[Address(RVA = "0x103F824", Offset = "0x103F824", VA = "0x103F824")]
			public void Update(InterpolationMode interpolation, UnityEvent onStep)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000094")]
		public class Leg : BodyPart
		{
			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The foot/toe target. This should not be the foot tracker itself, but a child GameObject parented to it so you could adjust it's position/rotation to match the orientation of the foot/toe bone. If a toe bone is assigned in the References, the solver will match the toe bone to this target. If no toe bone assigned, foot bone will be used instead.")]
			public Transform target;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The knee will be bent towards this Transform if 'Bend Goal Weight' > 0.")]
			public Transform bendGoal;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the toe/foot target. Note that if you have nulled the target, the foot will still be pulled to the last position of the target until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the toe/foot target. Note that if you have nulled the target, the foot will still be rotated to the last rotation of the target until you set this value to 0.")]
			public float rotationWeight;

			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("If greater than 0, will bend the knee towards the 'Bend Goal' Transform.")]
			public float bendGoalWeight;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(-180f, 180f)]
			[Tooltip("Angular offset of knee bending direction.")]
			public float swivelOffset;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 0, the bend plane will be locked to the rotation of the pelvis and rotating the foot will have no effect on the knee direction. If 1, to the target rotation of the leg so that the knee will bend towards the forward axis of the foot. Values in between will be slerped between the two.")]
			[Range(0f, 1f)]
			public float bendToTargetWeight;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[Range(0.01f, 2f)]
			[Tooltip("Use this to make the leg shorter/longer. Works by displacement of foot and calf localPosition.")]
			public float legLengthMlp;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Evaluates stretching of the leg by target distance relative to leg length. Value at time 1 represents stretching amount at the point where distance to the target is equal to leg length. Value at time 1 represents stretching amount at the point where distance to the target is double the leg length. Value represents the amount of stretching. Linear stretching would be achieved with a linear curve going up by 45 degrees. Increase the range of stretching by moving the last key up and right at the same amount. Smoothing in the curve can help reduce knee snapping (start stretching the arm slightly before target distance reaches leg length). To get a good optimal value for this curve, please go to the 'VRIK (Basic)' demo scene and copy the stretch curve over from the Pilot character.")]
			public AnimationCurve stretchCurve;

			[NonSerialized]
			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[HideInInspector]
			public Vector3 IKPosition;

			[NonSerialized]
			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[HideInInspector]
			public Quaternion IKRotation;

			[NonSerialized]
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[HideInInspector]
			public Vector3 footPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 heelPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion footRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public float currentMag;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			[HideInInspector]
			public bool useAnimatedBendNormal;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			private Vector3 footPosition;

			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			private Quaternion footRotation;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
			private Vector3 bendNormal;

			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			private Quaternion calfRelToThigh;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			private Quaternion thighRelToFoot;

			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			private Vector3 bendNormalRelToPelvis;

			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			private Vector3 bendNormalRelToTarget;

			[Token(Token = "0x170000DF")]
			public Vector3 position
			{
				[Token(Token = "0x6000558")]
				[Address(RVA = "0x103F998", Offset = "0x103F998", VA = "0x103F998")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000559")]
				[Address(RVA = "0x103F9A4", Offset = "0x103F9A4", VA = "0x103F9A4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E0")]
			public Quaternion rotation
			{
				[Token(Token = "0x600055A")]
				[Address(RVA = "0x103F9B0", Offset = "0x103F9B0", VA = "0x103F9B0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x600055B")]
				[Address(RVA = "0x103F9BC", Offset = "0x103F9BC", VA = "0x103F9BC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E1")]
			public bool hasToes
			{
				[Token(Token = "0x600055C")]
				[Address(RVA = "0x103F9C8", Offset = "0x103F9C8", VA = "0x103F9C8")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600055D")]
				[Address(RVA = "0x103F9D0", Offset = "0x103F9D0", VA = "0x103F9D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E2")]
			public VirtualBone thigh
			{
				[Token(Token = "0x600055E")]
				[Address(RVA = "0x103F9DC", Offset = "0x103F9DC", VA = "0x103F9DC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E3")]
			private VirtualBone calf
			{
				[Token(Token = "0x600055F")]
				[Address(RVA = "0x103FA04", Offset = "0x103FA04", VA = "0x103FA04")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E4")]
			private VirtualBone foot
			{
				[Token(Token = "0x6000560")]
				[Address(RVA = "0x103FA30", Offset = "0x103FA30", VA = "0x103FA30")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E5")]
			private VirtualBone toes
			{
				[Token(Token = "0x6000561")]
				[Address(RVA = "0x103FA5C", Offset = "0x103FA5C", VA = "0x103FA5C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E6")]
			public VirtualBone lastBone
			{
				[Token(Token = "0x6000562")]
				[Address(RVA = "0x103A000", Offset = "0x103A000", VA = "0x103A000")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000E7")]
			public Vector3 thighRelativeToPelvis
			{
				[Token(Token = "0x6000563")]
				[Address(RVA = "0x103FA88", Offset = "0x103FA88", VA = "0x103FA88")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000564")]
				[Address(RVA = "0x103FA94", Offset = "0x103FA94", VA = "0x103FA94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000565")]
			[Address(RVA = "0x103FAA0", Offset = "0x103FAA0", VA = "0x103FAA0", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x6000566")]
			[Address(RVA = "0x1040010", Offset = "0x1040010", VA = "0x1040010", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x6000567")]
			[Address(RVA = "0x1040840", Offset = "0x1040840", VA = "0x1040840", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x6000568")]
			[Address(RVA = "0x10407F0", Offset = "0x10407F0", VA = "0x10407F0")]
			private void ApplyPositionOffset(Vector3 offset, float weight)
			{
			}

			[Token(Token = "0x6000569")]
			[Address(RVA = "0x10405A4", Offset = "0x10405A4", VA = "0x10405A4")]
			private void ApplyRotationOffset(Quaternion offset, float weight)
			{
			}

			[Token(Token = "0x600056A")]
			[Address(RVA = "0x103A230", Offset = "0x103A230", VA = "0x103A230")]
			public void Solve(bool stretch)
			{
			}

			[Token(Token = "0x600056B")]
			[Address(RVA = "0x10410F8", Offset = "0x10410F8", VA = "0x10410F8")]
			private void FixTwistRotations()
			{
			}

			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1040D1C", Offset = "0x1040D1C", VA = "0x1040D1C")]
			private void Stretching()
			{
			}

			[Token(Token = "0x600056D")]
			[Address(RVA = "0x1041550", Offset = "0x1041550", VA = "0x1041550", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1041758", Offset = "0x1041758", VA = "0x1041758", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x600056F")]
			[Address(RVA = "0x103C70C", Offset = "0x103C70C", VA = "0x103C70C")]
			public Leg()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000095")]
		public class Locomotion
		{
			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Range(0f, 1f)]
			[Tooltip("Used for blending in/out of procedural locomotion.")]
			public float weight;

			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Tries to maintain this distance between the legs.")]
			public float footDistance;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Makes a step only if step target position is at least this far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past the 'Angle Threshold'.")]
			public float stepThreshold;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Makes a step only if step target position is at least 'Step Threshold' far from the current footstep or the foot does not reach the current footstep anymore or footstep angle is past this value.")]
			public float angleThreshold;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Multiplies angle of the center of mass - center of pressure vector. Larger value makes the character step sooner if losing balance.")]
			public float comAngleMlp;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Maximum magnitude of head/hand target velocity used in prediction.")]
			public float maxVelocity;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The amount of head/hand target velocity prediction.")]
			public float velocityFactor;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("How much can a leg be extended before it is forced to step to another position? 1 means fully stretched.")]
			[Range(0.9f, 1f)]
			public float maxLegStretch;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The speed of lerping the root of the character towards the horizontal mid-point of the footsteps.")]
			public float rootSpeed;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The speed of moving a foot to the next position.")]
			public float stepSpeed;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("The height of the foot by normalized step progress (0 - 1).")]
			public AnimationCurve stepHeight;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			[Tooltip("Reduce this value if locomotion makes the head bob too much.")]
			public float maxBodyYOffset;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The height offset of the heel by normalized step progress (0 - 1).")]
			public AnimationCurve heelHeight;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Rotates the foot while the leg is not stepping to relax the twist rotation of the leg if ideal rotation is past this angle.")]
			[Range(0f, 180f)]
			public float relaxLegTwistMinAngle;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("The speed of rotating the foot while the leg is not stepping to relax the twist rotation of the leg.")]
			public float relaxLegTwistSpeed;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Interpolation mode of the step.")]
			public InterpolationMode stepInterpolation;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset for the approximated center of mass.")]
			public Vector3 offset;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[HideInInspector]
			public bool blockingEnabled;

			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
			[HideInInspector]
			public LayerMask blockingLayers;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[HideInInspector]
			public float raycastRadius;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[HideInInspector]
			public float raycastHeight;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Called when the left foot has finished a step.")]
			public UnityEvent onLeftFootstep;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Tooltip("Called when the right foot has finished a step")]
			public UnityEvent onRightFootstep;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private Footstep[] footsteps;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private Vector3 lastComPosition;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private Vector3 comVelocity;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			private int leftFootIndex;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			private int rightFootIndex;

			[Token(Token = "0x170000E8")]
			public Vector3 centerOfMass
			{
				[Token(Token = "0x6000570")]
				[Address(RVA = "0x1041838", Offset = "0x1041838", VA = "0x1041838")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000571")]
				[Address(RVA = "0x1041844", Offset = "0x1041844", VA = "0x1041844")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000E9")]
			public Vector3 leftFootstepPosition
			{
				[Token(Token = "0x6000578")]
				[Address(RVA = "0x1041CA0", Offset = "0x1041CA0", VA = "0x1041CA0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EA")]
			public Vector3 rightFootstepPosition
			{
				[Token(Token = "0x6000579")]
				[Address(RVA = "0x1041CD4", Offset = "0x1041CD4", VA = "0x1041CD4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x170000EB")]
			public Quaternion leftFootstepRotation
			{
				[Token(Token = "0x600057A")]
				[Address(RVA = "0x1041D0C", Offset = "0x1041D0C", VA = "0x1041D0C")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x170000EC")]
			public Quaternion rightFootstepRotation
			{
				[Token(Token = "0x600057B")]
				[Address(RVA = "0x1041D40", Offset = "0x1041D40", VA = "0x1041D40")]
				get
				{
					return default(Quaternion);
				}
			}

			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1038320", Offset = "0x1038320", VA = "0x1038320")]
			public void Initiate(Vector3[] positions, Quaternion[] rotations, bool hasToes, float scale)
			{
			}

			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1035C3C", Offset = "0x1035C3C", VA = "0x1035C3C")]
			public void Reset(Vector3[] positions, Quaternion[] rotations)
			{
			}

			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1041850", Offset = "0x1041850", VA = "0x1041850")]
			public void Relax()
			{
			}

			[Token(Token = "0x6000575")]
			[Address(RVA = "0x10350A4", Offset = "0x10350A4", VA = "0x10350A4")]
			public void AddDeltaRotation(Quaternion delta, Vector3 pivot)
			{
			}

			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1034FEC", Offset = "0x1034FEC", VA = "0x1034FEC")]
			public void AddDeltaPosition(Vector3 delta)
			{
			}

			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1038B8C", Offset = "0x1038B8C", VA = "0x1038B8C")]
			public void Solve(VirtualBone rootBone, Spine spine, Leg leftLeg, Leg rightLeg, Arm leftArm, Arm rightArm, int supportLegIndex, out Vector3 leftFootPosition, out Vector3 rightFootPosition, out Quaternion leftFootRotation, out Quaternion rightFootRotation, out float leftFootOffset, out float rightFootOffset, out float leftHeelOffset, out float rightHeelOffset, float scale)
			{
			}

			[Token(Token = "0x600057C")]
			[Address(RVA = "0x10418D0", Offset = "0x10418D0", VA = "0x10418D0")]
			private bool StepBlocked(Vector3 fromPosition, Vector3 toPosition, Vector3 rootPosition)
			{
				return default(bool);
			}

			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1041A84", Offset = "0x1041A84", VA = "0x1041A84")]
			private bool CanStep()
			{
				return default(bool);
			}

			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1041AF0", Offset = "0x1041AF0", VA = "0x1041AF0")]
			private static bool GetLineSphereCollision(Vector3 lineStart, Vector3 lineEnd, Vector3 sphereCenter, float sphereRadius)
			{
				return default(bool);
			}

			[Token(Token = "0x600057F")]
			[Address(RVA = "0x103C7F4", Offset = "0x103C7F4", VA = "0x103C7F4")]
			public Locomotion()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000096")]
		public class Spine : BodyPart
		{
			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			[Tooltip("The head target. This should not be the camera Transform itself, but a child GameObject parented to it so you could adjust it's position/rotation  to match the orientation of the head bone. The best practice for setup would be to move the camera to the avatar's eyes, duplicate the avatar's head bone and parent it to the camera. Then assign the duplicate to this slot.")]
			public Transform headTarget;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The pelvis target (optional), useful for seated rigs or if you had an additional tracker on the backpack or belt are. The best practice for setup would be to duplicate the avatar's pelvis bone and parenting it to the pelvis tracker. Then assign the duplicate to this slot.")]
			public Transform pelvisTarget;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the head target. Note that if you have nulled the headTarget, the head will still be pulled to the last position of the headTarget until you set this value to 0.")]
			public float positionWeight;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Rotational weight of the head target. Note that if you have nulled the headTarget, the head will still be rotated to the last rotation of the headTarget until you set this value to 0.")]
			[Range(0f, 1f)]
			public float rotationWeight;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Range(0f, 1f)]
			[Tooltip("Positional weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be pulled to the last position of the pelvisTarget until you set this value to 0.")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			[Range(0f, 1f)]
			[Tooltip("Rotational weight of the pelvis target. Note that if you have nulled the pelvisTarget, the pelvis will still be rotated to the last rotation of the pelvisTarget until you set this value to 0.")]
			public float pelvisRotationWeight;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("If 'Chest Goal Weight' is greater than 0, the chest will be turned towards this Transform.")]
			public Transform chestGoal;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			[Tooltip("Weight of turning the chest towards the 'Chest Goal'.")]
			[Range(0f, 1f)]
			public float chestGoalWeight;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Minimum height of the head from the root of the character.")]
			public float minHeadHeight;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Range(0f, 1f)]
			[Tooltip("Determines how much the body will follow the position of the head.")]
			public float bodyPosStiffness;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Determines how much the body will follow the rotation of the head.")]
			[Range(0f, 1f)]
			public float bodyRotStiffness;

			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[FormerlySerializedAs("chestRotationWeight")]
			[Tooltip("Determines how much the chest will rotate to the rotation of the head.")]
			[Range(0f, 1f)]
			public float neckStiffness;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			[Tooltip("The amount of rotation applied to the chest based on hand positions.")]
			public float rotateChestByHands;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			[Range(0f, 1f)]
			[Tooltip("Clamps chest rotation. Value of 0.5 allows 90 degrees of rotation for the chest relative to the head. Value of 0 allows 180 degrees and value of 1 means the chest will be locked relative to the head.")]
			public float chestClampWeight;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
			[Tooltip("Clamps head rotation. Value of 0.5 allows 90 degrees of rotation for the head relative to the headTarget. Value of 0 allows 180 degrees and value of 1 means head rotation will be locked to the target.")]
			[Range(0f, 1f)]
			public float headClampWeight;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			[Tooltip("Moves the body horizontally along -character.forward axis by that value when the player is crouching.")]
			public float moveBodyBackWhenCrouching;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			[Range(0f, 1f)]
			[Tooltip("How much will the pelvis maintain it's animated position?")]
			public float maintainPelvisPosition;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			[Range(0f, 180f)]
			[Tooltip("Will automatically rotate the root of the character if the head target has turned past this angle.")]
			public float maxRootAngle;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			[Tooltip("Angular offset for root heading. Adjust this value to turn the root relative to the HMD around the vertical axis. Usefulf for fighting or shooting games where you would sometimes want the avatar to stand at an angled stance.")]
			[Range(-180f, 180f)]
			public float rootHeadingOffset;

			[NonSerialized]
			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			[HideInInspector]
			public Vector3 IKPositionHead;

			[NonSerialized]
			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			[HideInInspector]
			public Quaternion IKRotationHead;

			[NonSerialized]
			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
			[HideInInspector]
			public Vector3 IKPositionPelvis;

			[NonSerialized]
			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[HideInInspector]
			public Quaternion IKRotationPelvis;

			[NonSerialized]
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[HideInInspector]
			public Vector3 goalPositionChest;

			[NonSerialized]
			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
			[HideInInspector]
			public Vector3 pelvisPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
			[HideInInspector]
			public Vector3 chestPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
			[HideInInspector]
			public Vector3 headPositionOffset;

			[NonSerialized]
			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[HideInInspector]
			public Quaternion pelvisRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[HideInInspector]
			public Quaternion chestRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			[HideInInspector]
			public Quaternion headRotationOffset;

			[NonSerialized]
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			[HideInInspector]
			public Vector3 faceDirection;

			[NonSerialized]
			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
			[HideInInspector]
			public Vector3 locomotionHeadPositionOffset;

			[NonSerialized]
			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[HideInInspector]
			public Vector3 headPosition;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
			private Quaternion headRotation;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
			private Quaternion pelvisRotation;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
			private Quaternion anchorRelativeToPelvis;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
			private Quaternion pelvisRelativeRotation;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
			private Quaternion chestRelativeRotation;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1CC")]
			private Vector3 headDeltaPosition;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
			private Quaternion pelvisDeltaRotation;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
			private Quaternion chestTargetRotation;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
			private int pelvisIndex;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1FC")]
			private int spineIndex;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
			private int chestIndex;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x204")]
			private int neckIndex;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
			private int headIndex;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
			private float length;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
			private bool hasChest;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x211")]
			private bool hasNeck;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x212")]
			private bool hasLegs;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x214")]
			private float headHeight;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
			private float sizeMlp;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
			private Vector3 chestForward;

			[Token(Token = "0x170000ED")]
			public VirtualBone pelvis
			{
				[Token(Token = "0x6000580")]
				[Address(RVA = "0x1035E20", Offset = "0x1035E20", VA = "0x1035E20")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EE")]
			public VirtualBone firstSpineBone
			{
				[Token(Token = "0x6000581")]
				[Address(RVA = "0x1041D78", Offset = "0x1041D78", VA = "0x1041D78")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000EF")]
			public VirtualBone chest
			{
				[Token(Token = "0x6000582")]
				[Address(RVA = "0x103A474", Offset = "0x103A474", VA = "0x103A474")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F0")]
			private VirtualBone neck
			{
				[Token(Token = "0x6000583")]
				[Address(RVA = "0x1041DAC", Offset = "0x1041DAC", VA = "0x1041DAC")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F1")]
			public VirtualBone head
			{
				[Token(Token = "0x6000584")]
				[Address(RVA = "0x104189C", Offset = "0x104189C", VA = "0x104189C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170000F2")]
			public Quaternion anchorRotation
			{
				[Token(Token = "0x6000585")]
				[Address(RVA = "0x1041DE0", Offset = "0x1041DE0", VA = "0x1041DE0")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000586")]
				[Address(RVA = "0x1041DF4", Offset = "0x1041DF4", VA = "0x1041DF4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x170000F3")]
			public Quaternion anchorRelativeToHead
			{
				[Token(Token = "0x6000587")]
				[Address(RVA = "0x1041E08", Offset = "0x1041E08", VA = "0x1041E08")]
				[CompilerGenerated]
				get
				{
					return default(Quaternion);
				}
				[Token(Token = "0x6000588")]
				[Address(RVA = "0x1041E1C", Offset = "0x1041E1C", VA = "0x1041E1C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000589")]
			[Address(RVA = "0x1041E30", Offset = "0x1041E30", VA = "0x1041E30", Slot = "4")]
			protected override void OnRead(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs, int rootIndex, int index)
			{
			}

			[Token(Token = "0x600058A")]
			[Address(RVA = "0x1042AD0", Offset = "0x1042AD0", VA = "0x1042AD0", Slot = "5")]
			public override void PreSolve()
			{
			}

			[Token(Token = "0x600058B")]
			[Address(RVA = "0x1042CB8", Offset = "0x1042CB8", VA = "0x1042CB8", Slot = "7")]
			public override void ApplyOffsets(float scale)
			{
			}

			[Token(Token = "0x600058C")]
			[Address(RVA = "0x1043460", Offset = "0x1043460", VA = "0x1043460")]
			private void CalculateChestTargetRotation(VirtualBone rootBone, Arm[] arms)
			{
			}

			[Token(Token = "0x600058D")]
			[Address(RVA = "0x1038648", Offset = "0x1038648", VA = "0x1038648")]
			public void Solve(VirtualBone rootBone, Leg[] legs, Arm[] arms, float scale)
			{
			}

			[Token(Token = "0x600058E")]
			[Address(RVA = "0x1043EB8", Offset = "0x1043EB8", VA = "0x1043EB8")]
			private void FABRIKPass(Vector3 animatedPelvisPos, Vector3 rootUp, float weight)
			{
			}

			[Token(Token = "0x600058F")]
			[Address(RVA = "0x1044584", Offset = "0x1044584", VA = "0x1044584")]
			private void SolvePelvis()
			{
			}

			[Token(Token = "0x6000590")]
			[Address(RVA = "0x1044B64", Offset = "0x1044B64", VA = "0x1044B64", Slot = "6")]
			public override void Write(ref Vector3[] solvedPositions, ref Quaternion[] solvedRotations)
			{
			}

			[Token(Token = "0x6000591")]
			[Address(RVA = "0x1044D34", Offset = "0x1044D34", VA = "0x1044D34", Slot = "8")]
			public override void ResetOffsets()
			{
			}

			[Token(Token = "0x6000592")]
			[Address(RVA = "0x10436A4", Offset = "0x10436A4", VA = "0x10436A4")]
			private void AdjustChestByHands(ref Quaternion chestTargetRotation, Arm[] arms)
			{
			}

			[Token(Token = "0x6000593")]
			[Address(RVA = "0x103A034", Offset = "0x103A034", VA = "0x103A034")]
			public void InverseTranslateToHead(Leg[] legs, bool limited, bool useCurrentLegMag, Vector3 offset, float w)
			{
			}

			[Token(Token = "0x6000594")]
			[Address(RVA = "0x1043A9C", Offset = "0x1043A9C", VA = "0x1043A9C")]
			private void TranslatePelvis(Leg[] legs, Vector3 deltaPosition, Quaternion deltaRotation, float scale)
			{
			}

			[Token(Token = "0x6000595")]
			[Address(RVA = "0x1044E08", Offset = "0x1044E08", VA = "0x1044E08")]
			private Vector3 LimitPelvisPosition(Leg[] legs, Vector3 pelvisPosition, bool useCurrentLegMag, int it = 2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000596")]
			[Address(RVA = "0x1044388", Offset = "0x1044388", VA = "0x1044388")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000597")]
			[Address(RVA = "0x1044118", Offset = "0x1044118", VA = "0x1044118")]
			private void Bend(VirtualBone[] bones, int firstIndex, int lastIndex, Quaternion targetRotation, Quaternion rotationOffset, float clampWeight, bool uniformWeight, float w)
			{
			}

			[Token(Token = "0x6000598")]
			[Address(RVA = "0x103C45C", Offset = "0x103C45C", VA = "0x103C45C")]
			public Spine()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000097")]
		public enum PositionOffset
		{
			[Token(Token = "0x4000583")]
			Pelvis,
			[Token(Token = "0x4000584")]
			Chest,
			[Token(Token = "0x4000585")]
			Head,
			[Token(Token = "0x4000586")]
			LeftHand,
			[Token(Token = "0x4000587")]
			RightHand,
			[Token(Token = "0x4000588")]
			LeftFoot,
			[Token(Token = "0x4000589")]
			RightFoot,
			[Token(Token = "0x400058A")]
			LeftHeel,
			[Token(Token = "0x400058B")]
			RightHeel
		}

		[Serializable]
		[Token(Token = "0x2000098")]
		public enum RotationOffset
		{
			[Token(Token = "0x400058D")]
			Pelvis,
			[Token(Token = "0x400058E")]
			Chest,
			[Token(Token = "0x400058F")]
			Head
		}

		[Serializable]
		[Token(Token = "0x2000099")]
		public class VirtualBone
		{
			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 readPosition;

			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Quaternion readRotation;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 solverPosition;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Quaternion solverRotation;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public float length;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public float sqrMag;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Vector3 axis;

			[Token(Token = "0x6000599")]
			[Address(RVA = "0x10381D4", Offset = "0x10381D4", VA = "0x10381D4")]
			public VirtualBone(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1038244", Offset = "0x1038244", VA = "0x1038244")]
			public void Read(Vector3 position, Quaternion rotation)
			{
			}

			[Token(Token = "0x600059B")]
			[Address(RVA = "0x10450A4", Offset = "0x10450A4", VA = "0x10450A4")]
			public static void SwingRotation(VirtualBone[] bones, int index, Vector3 swingTarget, float weight = 1f)
			{
			}

			[Token(Token = "0x600059C")]
			[Address(RVA = "0x103EA58", Offset = "0x103EA58", VA = "0x103EA58")]
			public static float PreSolve(ref VirtualBone[] bones)
			{
				return default(float);
			}

			[Token(Token = "0x600059D")]
			[Address(RVA = "0x103ECD4", Offset = "0x103ECD4", VA = "0x103ECD4")]
			public static void RotateAroundPoint(VirtualBone[] bones, int index, Vector3 point, Quaternion rotation)
			{
			}

			[Token(Token = "0x600059E")]
			[Address(RVA = "0x10452A4", Offset = "0x10452A4", VA = "0x10452A4")]
			public static void RotateBy(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x600059F")]
			[Address(RVA = "0x103DA44", Offset = "0x103DA44", VA = "0x103DA44")]
			public static void RotateBy(VirtualBone[] bones, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x104544C", Offset = "0x104544C", VA = "0x104544C")]
			public static void RotateTo(VirtualBone[] bones, int index, Quaternion rotation)
			{
			}

			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x103E0C8", Offset = "0x103E0C8", VA = "0x103E0C8")]
			public static void SolveTrigonometric(VirtualBone[] bones, int first, int second, int third, Vector3 targetPosition, Vector3 bendNormal, float weight)
			{
			}

			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x10454F0", Offset = "0x10454F0", VA = "0x10454F0")]
			private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1044798", Offset = "0x1044798", VA = "0x1044798")]
			public static void SolveFABRIK(VirtualBone[] bones, Vector3 startPosition, Vector3 targetPosition, float weight, float minNormalizedTargetDistance, int iterations, float length, Vector3 startOffset)
			{
			}

			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1045648", Offset = "0x1045648", VA = "0x1045648")]
			private static Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x104575C", Offset = "0x104575C", VA = "0x104575C")]
			public static void SolveCCD(VirtualBone[] bones, Vector3 targetPosition, float weight, int iterations)
			{
			}
		}

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform[] solverTransforms;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasChest;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool hasNeck;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool hasShoulders;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool hasToes;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool hasLegs;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] readPositions;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] readRotations;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3[] solvedPositions;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Quaternion[] solvedRotations;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 rootV;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private Vector3 rootVelocity;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Vector3 bodyOffset;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private int supportLegIndex;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private int lastLOD;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		[Range(0f, 2f)]
		[Tooltip("LOD 0: Full quality solving. LOD 1: Shoulder solving, stretching plant feet disabled, spine solving quality reduced. This provides about 30% of performance gain. LOD 2: Culled, but updating root position and rotation if locomotion is enabled.")]
		public int LOD;

		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Scale of the character. Value of 1 means normal adult human size.")]
		public float scale;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Tooltip("If true, will keep the toes planted even if head target is out of reach, so this can cause the camera to exit the head if it is too high for the model to reach. Enabling this increases the cost of the solver as the legs will have to be solved multiple times.")]
		public bool plantFeet;

		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[Tooltip("The spine solver.")]
		public Spine spine;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[Tooltip("The left arm solver.")]
		public Arm leftArm;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[Tooltip("The right arm solver.")]
		public Arm rightArm;

		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		[Tooltip("The left leg solver.")]
		public Leg leftLeg;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Tooltip("The right leg solver.")]
		public Leg rightLeg;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		[Tooltip("Procedural leg shuffling for stationary VR games. Not designed for roomscale and thumbstick locomotion. For those it would be better to use a strafing locomotion blend tree to make the character follow the horizontal direction towards the HMD by root motion or script.")]
		public Locomotion locomotion;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Leg[] legs;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Arm[] arms;

		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 headPosition;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 headDeltaPosition;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 raycastOriginPelvis;

		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private Vector3 lastOffset;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Vector3 debugPos1;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
		private Vector3 debugPos2;

		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private Vector3 debugPos3;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private Vector3 debugPos4;

		[Token(Token = "0x170000D4")]
		[HideInInspector]
		public VirtualBone rootBone
		{
			[Token(Token = "0x6000524")]
			[Address(RVA = "0x103C168", Offset = "0x103C168", VA = "0x103C168")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x103C170", Offset = "0x103C170", VA = "0x103C170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x10343E8", Offset = "0x10343E8", VA = "0x10343E8")]
		public void SetToReferences(VRIK.References references)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1034854", Offset = "0x1034854", VA = "0x1034854")]
		public void GuessHandOrientations(VRIK.References references, bool onlyIfZero)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x10346E8", Offset = "0x10346E8", VA = "0x10346E8")]
		public void DefaultAnimationCurves()
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1034C70", Offset = "0x1034C70", VA = "0x1034C70")]
		public void AddPositionOffset(PositionOffset positionOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1034DB4", Offset = "0x1034DB4", VA = "0x1034DB4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Vector3 value)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1034DF4", Offset = "0x1034DF4", VA = "0x1034DF4")]
		public void AddRotationOffset(RotationOffset rotationOffset, Quaternion value)
		{
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1034F18", Offset = "0x1034F18", VA = "0x1034F18")]
		public void AddPlatformMotion(Vector3 deltaPosition, Quaternion deltaRotation, Vector3 platformPivot)
		{
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x103546C", Offset = "0x103546C", VA = "0x103546C")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1035E54", Offset = "0x1035E54", VA = "0x1035E54", Slot = "9")]
		public override void StoreDefaultLocalState()
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1035FA8", Offset = "0x1035FA8", VA = "0x1035FA8", Slot = "8")]
		public override void FixTransforms()
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1036194", Offset = "0x1036194", VA = "0x1036194", Slot = "6")]
		public override Point[] GetPoints()
		{
			return null;
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1036204", Offset = "0x1036204", VA = "0x1036204", Slot = "7")]
		public override Point GetPoint(Transform transform)
		{
			return null;
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1036274", Offset = "0x1036274", VA = "0x1036274", Slot = "4")]
		public override bool IsValid(ref string message)
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x103647C", Offset = "0x103647C", VA = "0x103647C")]
		private Vector3 GetNormal(Transform[] transforms)
		{
			return default(Vector3);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1034B5C", Offset = "0x1034B5C", VA = "0x1034B5C")]
		private static Keyframe[] GetSineKeyframes(float mag)
		{
			return null;
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1035578", Offset = "0x1035578", VA = "0x1035578")]
		private void UpdateSolverTransforms()
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x10366EC", Offset = "0x10366EC", VA = "0x10366EC", Slot = "10")]
		protected override void OnInitiate()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1036728", Offset = "0x1036728", VA = "0x1036728", Slot = "11")]
		protected override void OnUpdate()
		{
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1037D0C", Offset = "0x1037D0C", VA = "0x1037D0C")]
		private void WriteTransforms()
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x10356C8", Offset = "0x10356C8", VA = "0x10356C8")]
		private void Read(Vector3[] positions, Quaternion[] rotations, bool hasChest, bool hasNeck, bool hasShoulders, bool hasToes, bool hasLegs)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1036B2C", Offset = "0x1036B2C", VA = "0x1036B2C")]
		private void Solve()
		{
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1038160", Offset = "0x1038160", VA = "0x1038160")]
		private Vector3 GetPosition(int index)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x103819C", Offset = "0x103819C", VA = "0x103819C")]
		private Quaternion GetRotation(int index)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1037BD0", Offset = "0x1037BD0", VA = "0x1037BD0")]
		private void Write()
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x103BA9C", Offset = "0x103BA9C", VA = "0x103BA9C")]
		private Vector3 GetPelvisOffset()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x103C178", Offset = "0x103C178", VA = "0x103C178")]
		public IKSolverVR()
		{
		}
	}
	[Token(Token = "0x200009A")]
	public class TwistRelaxer : MonoBehaviour
	{
		[Token(Token = "0x4000597")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IK ik;

		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If using multiple solvers, add them in inverse hierarchical order - first forearm roll bone, then forearm bone and upper arm bone.")]
		public TwistSolver[] twistSolvers;

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1045910", Offset = "0x1045910", VA = "0x1045910")]
		public void Start()
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1045F90", Offset = "0x1045F90", VA = "0x1045F90")]
		private void OnPostUpdate()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x1046524", Offset = "0x1046524", VA = "0x1046524")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x10465D4", Offset = "0x10465D4", VA = "0x10465D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x104670C", Offset = "0x104670C", VA = "0x104670C")]
		public TwistRelaxer()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009B")]
	public class TwistSolver
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("The transform that this solver operates on.")]
		public Transform transform;

		[Token(Token = "0x400059A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If this is the forearm roll bone, the parent should be the forearm bone. If null, will be found automatically.")]
		public Transform parent;

		[Token(Token = "0x400059B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If this is the forearm roll bone, the child should be the hand bone. If null, will attempt to find automatically. Assign the hand manually if the hand bone is not a child of the roll bone.")]
		public Transform[] children;

		[Token(Token = "0x400059C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The weight of relaxing the twist of this Transform")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400059D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("If 0.5, this Transform will be twisted half way from parent to child. If 1, the twist angle will be locked to the child and will rotate with along with it.")]
		[Range(0f, 1f)]
		public float parentChildCrossfade;

		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(-180f, 180f)]
		[Tooltip("Rotation offset around the twist axis.")]
		public float twistAngleOffset;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Vector3 twistAxis;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 axis;

		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 axisRelativeToParentDefault;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 axisRelativeToChildDefault;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Quaternion[] childRotations;

		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool inititated;

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x1046770", Offset = "0x1046770", VA = "0x1046770")]
		public TwistSolver()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x1045AF8", Offset = "0x1045AF8", VA = "0x1045AF8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x1046040", Offset = "0x1046040", VA = "0x1046040")]
		public void Relax()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009C")]
	public class InteractionEffector
	{
		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Poser poser;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IKEffector effector;

		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float timer;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float length;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float weight;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float fadeInSpeed;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float defaultPositionWeight;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float defaultRotationWeight;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float defaultPull;

		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private float defaultReach;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float defaultPush;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float defaultPushParent;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private float defaultBendGoalWeight;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private float resetTimer;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool positionWeightUsed;

		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool rotationWeightUsed;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool pullUsed;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x63")]
		private bool reachUsed;

		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool pushUsed;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
		private bool pushParentUsed;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x66")]
		private bool bendGoalWeightUsed;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x67")]
		private bool pickedUp;

		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool defaults;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool pickUpOnPostFBBIK;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Vector3 pausePositionRelative;

		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private Quaternion pauseRotationRelative;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private InteractionTarget interactionTarget;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Transform target;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<bool> triggered;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private bool started;

		[Token(Token = "0x170000F4")]
		public FullBodyBipedEffector effectorType
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1046868", Offset = "0x1046868", VA = "0x1046868")]
			[CompilerGenerated]
			get
			{
				return default(FullBodyBipedEffector);
			}
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0x1046870", Offset = "0x1046870", VA = "0x1046870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F5")]
		public bool isPaused
		{
			[Token(Token = "0x60005B0")]
			[Address(RVA = "0x1046878", Offset = "0x1046878", VA = "0x1046878")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005B1")]
			[Address(RVA = "0x1046880", Offset = "0x1046880", VA = "0x1046880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F6")]
		public InteractionObject interactionObject
		{
			[Token(Token = "0x60005B2")]
			[Address(RVA = "0x104688C", Offset = "0x104688C", VA = "0x104688C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x1046894", Offset = "0x1046894", VA = "0x1046894")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000F7")]
		public bool inInteraction
		{
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x104689C", Offset = "0x104689C", VA = "0x104689C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000F8")]
		public float progress
		{
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x104919C", Offset = "0x104919C", VA = "0x104919C")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x10468FC", Offset = "0x10468FC", VA = "0x10468FC")]
		public InteractionEffector(FullBodyBipedEffector effectorType)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1046998", Offset = "0x1046998", VA = "0x1046998")]
		public void Initiate(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1046A50", Offset = "0x1046A50", VA = "0x1046A50")]
		private void StoreDefaults()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1046BBC", Offset = "0x1046BBC", VA = "0x1046BBC")]
		public bool ResetToDefaults(float speed)
		{
			return default(bool);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1046F98", Offset = "0x1046F98", VA = "0x1046F98")]
		public bool Pause()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x10470B8", Offset = "0x10470B8", VA = "0x10470B8")]
		public bool Resume()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x104710C", Offset = "0x104710C", VA = "0x104710C")]
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1047DF0", Offset = "0x1047DF0", VA = "0x1047DF0")]
		public void Update(Transform root, float speed)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1048944", Offset = "0x1048944", VA = "0x1048944")]
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1048B64", Offset = "0x1048B64", VA = "0x1048B64")]
		private void PickUp(Transform root)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1049038", Offset = "0x1049038", VA = "0x1049038")]
		public bool Stop()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x104939C", Offset = "0x104939C", VA = "0x104939C")]
		public void OnPostFBBIK()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200009D")]
	public class InteractionLookAt
	{
		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("(Optional) reference to the LookAtIK component that will be used to make the character look at the objects that it is interacting with.")]
		public LookAtIK ik;

		[Token(Token = "0x40005CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Interpolation speed of the LookAtIK target.")]
		public float lerpSpeed;

		[Token(Token = "0x40005CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Interpolation speed of the LookAtIK weight.")]
		public float weightSpeed;

		[Token(Token = "0x40005CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public bool isPaused;

		[Token(Token = "0x40005CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform lookAtTarget;

		[Token(Token = "0x40005CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float stopLookTime;

		[Token(Token = "0x40005CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float weight;

		[Token(Token = "0x40005D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool firstFBBIKSolve;

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1049664", Offset = "0x1049664", VA = "0x1049664")]
		public void Look(Transform target, float time)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1049780", Offset = "0x1049780", VA = "0x1049780")]
		public void OnFixTransforms()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1049818", Offset = "0x1049818", VA = "0x1049818")]
		public void Update()
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1049A20", Offset = "0x1049A20", VA = "0x1049A20")]
		public void SolveSpine()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1049AC8", Offset = "0x1049AC8", VA = "0x1049AC8")]
		public void SolveHead()
		{
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1049B74", Offset = "0x1049B74", VA = "0x1049B74")]
		public InteractionLookAt()
		{
		}
	}
	[Token(Token = "0x200009E")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Object")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionObject : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200009F")]
		public class InteractionEvent
		{
			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The time of the event since interaction start.")]
			public float time;

			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("If true, the interaction will be paused on this event. The interaction can be resumed by InteractionSystem.ResumeInteraction() or InteractionSystem.ResumeAll;")]
			public bool pause;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			[Tooltip("If true, the object will be parented to the effector bone on this event. Note that picking up like this can be done by only a single effector at a time. If you wish to pick up an object with both hands, see the Interaction PickUp2Handed demo scene.")]
			public bool pickUp;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The animations called on this event.")]
			public AnimatorEvent[] animations;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The messages sent on this event using GameObject.SendMessage().")]
			public Message[] messages;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The UnityEvent to invoke on this event.")]
			public UnityEvent unityEvent;

			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x10491CC", Offset = "0x10491CC", VA = "0x10491CC")]
			public void Activate(Transform t)
			{
			}

			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x104AAF0", Offset = "0x104AAF0", VA = "0x104AAF0")]
			public InteractionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A0")]
		public class Message
		{
			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The name of the function called.")]
			public string function;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The recipient game object.")]
			public GameObject recipient;

			[Token(Token = "0x40005E2")]
			private const string empty = "";

			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x104A9F8", Offset = "0x104A9F8", VA = "0x104A9F8")]
			public void Send(Transform t)
			{
			}

			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x104AAF8", Offset = "0x104AAF8", VA = "0x104AAF8")]
			public Message()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A1")]
		public class AnimatorEvent
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Animator component that will receive the AnimatorEvents.")]
			public Animator animator;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Animation component that will receive the AnimatorEvents (Legacy).")]
			public Animation animation;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The name of the animation state.")]
			public string animationState;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The crossfading time.")]
			public float crossfadeTime;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The layer of the animation state (if using Legacy, the animation state will be forced to this layer).")]
			public int layer;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Should the animation always start from 0 normalized time?")]
			public bool resetNormalizedTime;

			[Token(Token = "0x40005E9")]
			private const string empty = "";

			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x104A91C", Offset = "0x104A91C", VA = "0x104A91C")]
			public void Activate(bool pickUp)
			{
			}

			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x104AB00", Offset = "0x104AB00", VA = "0x104AB00")]
			private void Activate(Animator animator)
			{
			}

			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x104ABB0", Offset = "0x104ABB0", VA = "0x104ABB0")]
			private void Activate(Animation animation)
			{
			}

			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x104AC88", Offset = "0x104AC88", VA = "0x104AC88")]
			public AnimatorEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A2")]
		public class WeightCurve
		{
			[Serializable]
			[Token(Token = "0x20000A3")]
			public enum Type
			{
				[Token(Token = "0x40005ED")]
				PositionWeight,
				[Token(Token = "0x40005EE")]
				RotationWeight,
				[Token(Token = "0x40005EF")]
				PositionOffsetX,
				[Token(Token = "0x40005F0")]
				PositionOffsetY,
				[Token(Token = "0x40005F1")]
				PositionOffsetZ,
				[Token(Token = "0x40005F2")]
				Pull,
				[Token(Token = "0x40005F3")]
				Reach,
				[Token(Token = "0x40005F4")]
				RotateBoneWeight,
				[Token(Token = "0x40005F5")]
				Push,
				[Token(Token = "0x40005F6")]
				PushParent,
				[Token(Token = "0x40005F7")]
				PoserWeight,
				[Token(Token = "0x40005F8")]
				BendGoalWeight
			}

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of the curve (InteractionObject.WeightCurve.Type).")]
			public Type type;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The weight curve.")]
			public AnimationCurve curve;

			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x104A220", Offset = "0x104A220", VA = "0x104A220")]
			public float GetValue(float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x104AC9C", Offset = "0x104AC9C", VA = "0x104AC9C")]
			public WeightCurve()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000A4")]
		public class Multiplier
		{
			[Token(Token = "0x40005F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type to multiply.")]
			public WeightCurve.Type curve;

			[Token(Token = "0x40005FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x40005FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The resulting value will be applied to this channel.")]
			public WeightCurve.Type result;

			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x104A828", Offset = "0x104A828", VA = "0x104A828")]
			public float GetValue(WeightCurve weightCurve, float timer)
			{
				return default(float);
			}

			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x104ACA4", Offset = "0x104ACA4", VA = "0x104ACA4")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x40005D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If the Interaction System has a 'Look At' LookAtIK component assigned, will use it to make the character look at the specified Transform. If unassigned, will look at this GameObject.")]
		public Transform otherLookAtTarget;

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The root Transform of the InteractionTargets. If null, will use this GameObject. GetComponentsInChildren<InteractionTarget>() will be used at initiation to find all InteractionTargets associated with this InteractionObject.")]
		public Transform otherTargetsRoot;

		[Token(Token = "0x40005D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If assigned, all PositionOffset channels will be applied in the rotation space of this Transform. If not, they will be in the rotation space of the character.")]
		public Transform positionOffsetSpace;

		[Token(Token = "0x40005D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WeightCurve[] weightCurves;

		[Token(Token = "0x40005D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Multiplier[] multipliers;

		[Token(Token = "0x40005D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionEvent[] events;

		[Token(Token = "0x40005D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private InteractionTarget[] targets;

		[Token(Token = "0x170000F9")]
		public float length
		{
			[Token(Token = "0x60005D0")]
			[Address(RVA = "0x1049DA8", Offset = "0x1049DA8", VA = "0x1049DA8")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x1049DB0", Offset = "0x1049DB0", VA = "0x1049DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FA")]
		public InteractionSystem lastUsedInteractionSystem
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1049DB8", Offset = "0x1049DB8", VA = "0x1049DB8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x1049DC0", Offset = "0x1049DC0", VA = "0x1049DC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x170000FB")]
		public Transform lookAtTarget
		{
			[Token(Token = "0x60005D5")]
			[Address(RVA = "0x1049F80", Offset = "0x1049F80", VA = "0x1049F80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		public Transform targetsRoot
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x1049290", Offset = "0x1049290", VA = "0x1049290")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1049B88", Offset = "0x1049B88", VA = "0x1049B88")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x1049BCC", Offset = "0x1049BCC", VA = "0x1049BCC")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x1049C10", Offset = "0x1049C10", VA = "0x1049C10")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x1049C54", Offset = "0x1049C54", VA = "0x1049C54")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x1049C98", Offset = "0x1049C98", VA = "0x1049C98")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1049CDC", Offset = "0x1049CDC", VA = "0x1049CDC")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1049D20", Offset = "0x1049D20", VA = "0x1049D20")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1049D64", Offset = "0x1049D64", VA = "0x1049D64")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1049DC8", Offset = "0x1049DC8", VA = "0x1049DC8")]
		public void Initiate()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x104A000", Offset = "0x104A000", VA = "0x104A000")]
		public InteractionTarget GetTarget(FullBodyBipedEffector effectorType, InteractionSystem interactionSystem)
		{
			return null;
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1047714", Offset = "0x1047714", VA = "0x1047714")]
		public bool CurveUsed(WeightCurve.Type type)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x104A150", Offset = "0x104A150", VA = "0x104A150")]
		public InteractionTarget[] GetTargets()
		{
			return null;
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x10475D8", Offset = "0x10475D8", VA = "0x10475D8")]
		public Transform GetTarget(FullBodyBipedEffector effectorType, string tag)
		{
			return null;
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x104770C", Offset = "0x104770C", VA = "0x104770C")]
		public void OnStartInteraction(InteractionSystem interactionSystem)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x104853C", Offset = "0x104853C", VA = "0x104853C")]
		public void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, InteractionTarget target, float timer, float weight)
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1048E2C", Offset = "0x1048E2C", VA = "0x1048E2C")]
		public float GetValue(WeightCurve.Type weightCurveType, InteractionTarget target, float timer)
		{
			return default(float);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x104A858", Offset = "0x104A858", VA = "0x104A858")]
		private void Start()
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x104A23C", Offset = "0x104A23C", VA = "0x104A23C")]
		private void Apply(IKSolverFullBodyBiped solver, FullBodyBipedEffector effector, WeightCurve.Type type, float value, float weight)
		{
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x104A158", Offset = "0x104A158", VA = "0x104A158")]
		private Transform GetTarget(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x104A7CC", Offset = "0x104A7CC", VA = "0x104A7CC")]
		private int GetWeightCurveIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x104A85C", Offset = "0x104A85C", VA = "0x104A85C")]
		private int GetMultiplierIndex(WeightCurve.Type weightCurveType)
		{
			return default(int);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x104A8B8", Offset = "0x104A8B8", VA = "0x104A8B8")]
		public InteractionObject()
		{
		}
	}
	[Token(Token = "0x20000A5")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction System")]
	public class InteractionSystem : MonoBehaviour
	{
		[Token(Token = "0x20000A6")]
		public delegate void InteractionDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject);

		[Token(Token = "0x20000A7")]
		public delegate void InteractionEventDelegate(FullBodyBipedEffector effectorType, InteractionObject interactionObject, InteractionObject.InteractionEvent interactionEvent);

		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If not empty, only the targets with the specified tag will be used by this Interaction System.")]
		public string targetTag;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The fade in time of the interaction.")]
		public float fadeInTime;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("The master speed for all interactions.")]
		public float speed;

		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If > 0, lerps all the FBBIK channels used by the Interaction System back to their default or initial values when not in interaction.")]
		public float resetToDefaultsSpeed;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Header("Triggering")]
		[Tooltip("The collider that registers OnTriggerEnter and OnTriggerExit events with InteractionTriggers.")]
		[FormerlySerializedAs("collider")]
		public Collider characterCollider;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Will be used by Interaction Triggers that need the camera's position. Assign the first person view character camera.")]
		[FormerlySerializedAs("camera")]
		public Transform FPSCamera;

		[Token(Token = "0x4000602")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The layers that will be raycasted from the camera (along camera.forward). All InteractionTrigger look at target colliders should be included.")]
		public LayerMask camRaycastLayers;

		[Token(Token = "0x4000603")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Max distance of raycasting from the camera.")]
		public float camRaycastDistance;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<InteractionTrigger> inContact;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<int> bestRangeIndexes;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public InteractionDelegate OnInteractionStart;

		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public InteractionDelegate OnInteractionPause;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public InteractionDelegate OnInteractionPickUp;

		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public InteractionDelegate OnInteractionResume;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public InteractionDelegate OnInteractionStop;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public InteractionEventDelegate OnInteractionEvent;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RaycastHit raycastHit;

		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[Tooltip("Reference to the FBBIK component.")]
		[SerializeField]
		[Space(10f)]
		private FullBodyBipedIK fullBody;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Tooltip("Handles looking at the interactions.")]
		public InteractionLookAt lookAt;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private InteractionEffector[] interactionEffectors;

		[Token(Token = "0x4000612")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Collider lastCollider;

		[Token(Token = "0x4000613")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Collider c;

		[Token(Token = "0x170000FD")]
		public bool inInteraction
		{
			[Token(Token = "0x60005F8")]
			[Address(RVA = "0x104AED4", Offset = "0x104AED4", VA = "0x104AED4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170000FE")]
		public FullBodyBipedIK ik
		{
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x104C97C", Offset = "0x104C97C", VA = "0x104C97C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000613")]
			[Address(RVA = "0x104C984", Offset = "0x104C984", VA = "0x104C984")]
			set
			{
			}
		}

		[Token(Token = "0x170000FF")]
		public List<InteractionTrigger> triggersInRange
		{
			[Token(Token = "0x6000614")]
			[Address(RVA = "0x104C98C", Offset = "0x104C98C", VA = "0x104C98C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000615")]
			[Address(RVA = "0x104C994", Offset = "0x104C994", VA = "0x104C994")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public bool initiated
		{
			[Token(Token = "0x6000616")]
			[Address(RVA = "0x104C99C", Offset = "0x104C99C", VA = "0x104C99C")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x104C9A4", Offset = "0x104C9A4", VA = "0x104C9A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x104ACB4", Offset = "0x104ACB4", VA = "0x104ACB4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x104ACF8", Offset = "0x104ACF8", VA = "0x104ACF8")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x104AD3C", Offset = "0x104AD3C", VA = "0x104AD3C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x104AD80", Offset = "0x104AD80", VA = "0x104AD80")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x104ADC4", Offset = "0x104ADC4", VA = "0x104ADC4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x104AE08", Offset = "0x104AE08", VA = "0x104AE08")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x104AE4C", Offset = "0x104AE4C", VA = "0x104AE4C")]
		[ContextMenu("Support")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x104AE90", Offset = "0x104AE90", VA = "0x104AE90")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x104B04C", Offset = "0x104B04C", VA = "0x104B04C")]
		public bool IsInInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x104B104", Offset = "0x104B104", VA = "0x104B104")]
		public bool IsPaused(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x104B1BC", Offset = "0x104B1BC", VA = "0x104B1BC")]
		public bool IsPaused()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x104B254", Offset = "0x104B254", VA = "0x104B254")]
		public bool IsInSync()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x104B338", Offset = "0x104B338", VA = "0x104B338")]
		public bool StartInteraction(FullBodyBipedEffector effectorType, InteractionObject interactionObject, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x104B430", Offset = "0x104B430", VA = "0x104B430")]
		public bool PauseInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x104B4B4", Offset = "0x104B4B4", VA = "0x104B4B4")]
		public bool ResumeInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x104B538", Offset = "0x104B538", VA = "0x104B538")]
		public bool StopInteraction(FullBodyBipedEffector effectorType)
		{
			return default(bool);
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x104B5BC", Offset = "0x104B5BC", VA = "0x104B5BC")]
		public void PauseAll()
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x104B624", Offset = "0x104B624", VA = "0x104B624")]
		public void ResumeAll()
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x104B68C", Offset = "0x104B68C", VA = "0x104B68C")]
		public void StopAll()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x104B6E8", Offset = "0x104B6E8", VA = "0x104B6E8")]
		public InteractionObject GetInteractionObject(FullBodyBipedEffector effectorType)
		{
			return null;
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x104B768", Offset = "0x104B768", VA = "0x104B768")]
		public float GetProgress(FullBodyBipedEffector effectorType)
		{
			return default(float);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x104B810", Offset = "0x104B810", VA = "0x104B810")]
		public float GetMinActiveProgress()
		{
			return default(float);
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x104B8E0", Offset = "0x104B8E0", VA = "0x104B8E0")]
		public bool TriggerInteraction(int index, bool interrupt)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x104BB70", Offset = "0x104BB70", VA = "0x104BB70")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionObject interactionObject)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x104BD44", Offset = "0x104BD44", VA = "0x104BD44")]
		public bool TriggerInteraction(int index, bool interrupt, out InteractionTarget interactionTarget)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x104BFB4", Offset = "0x104BFB4", VA = "0x104BFB4")]
		public InteractionTrigger.Range GetClosestInteractionRange()
		{
			return null;
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x104C240", Offset = "0x104C240", VA = "0x104C240")]
		public InteractionObject GetClosestInteractionObjectInRange()
		{
			return null;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x104C278", Offset = "0x104C278", VA = "0x104C278")]
		public InteractionTarget GetClosestInteractionTargetInRange()
		{
			return null;
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x104C2D8", Offset = "0x104C2D8", VA = "0x104C2D8")]
		public InteractionObject[] GetClosestInteractionObjectsInRange()
		{
			return null;
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x104C404", Offset = "0x104C404", VA = "0x104C404")]
		public InteractionTarget[] GetClosestInteractionTargetsInRange()
		{
			return null;
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x104C5E8", Offset = "0x104C5E8", VA = "0x104C5E8")]
		public bool TriggerEffectorsReady(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x104C85C", Offset = "0x104C85C", VA = "0x104C85C")]
		public InteractionTrigger.Range GetTriggerRange(int index)
		{
			return null;
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x104C09C", Offset = "0x104C09C", VA = "0x104C09C")]
		public int GetClosestTriggerIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x104C9B0", Offset = "0x104C9B0", VA = "0x104C9B0")]
		public void Start()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x104D2D4", Offset = "0x104D2D4", VA = "0x104D2D4")]
		private void InteractionPause(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x104D2F4", Offset = "0x104D2F4", VA = "0x104D2F4")]
		private void InteractionResume(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x104D310", Offset = "0x104D310", VA = "0x104D310")]
		private void InteractionStop(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x104D32C", Offset = "0x104D32C", VA = "0x104D32C")]
		private void LookAtInteraction(FullBodyBipedEffector effector, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x104D380", Offset = "0x104D380", VA = "0x104D380")]
		public void OnTriggerEnter(Collider c)
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x104D504", Offset = "0x104D504", VA = "0x104D504")]
		public void OnTriggerExit(Collider c)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x104D600", Offset = "0x104D600", VA = "0x104D600")]
		private bool ContactIsInRange(int index, out int bestRangeIndex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0x104D95C", Offset = "0x104D95C", VA = "0x104D95C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x104DA74", Offset = "0x104DA74", VA = "0x104DA74")]
		public void Update()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0x104DD38", Offset = "0x104DD38", VA = "0x104DD38")]
		private void Raycasting()
		{
		}

		[Token(Token = "0x6000623")]
		[Address(RVA = "0x104D074", Offset = "0x104D074", VA = "0x104D074")]
		private void UpdateTriggerEventBroadcasting()
		{
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0x104DE68", Offset = "0x104DE68", VA = "0x104DE68")]
		private void UpdateEffectors()
		{
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x104DF74", Offset = "0x104DF74", VA = "0x104DF74")]
		private void OnPreFBBIK()
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x104DFFC", Offset = "0x104DFFC", VA = "0x104DFFC")]
		private void OnPostFBBIK()
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x104E0BC", Offset = "0x104E0BC", VA = "0x104E0BC")]
		private void OnFixTransforms()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x104E0D4", Offset = "0x104E0D4", VA = "0x104E0D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x104AF6C", Offset = "0x104AF6C", VA = "0x104AF6C")]
		private bool IsValid(bool log)
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x104BA5C", Offset = "0x104BA5C", VA = "0x104BA5C")]
		private bool TriggerIndexIsValid(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x104E54C", Offset = "0x104E54C", VA = "0x104E54C")]
		public InteractionSystem()
		{
		}
	}
	[Token(Token = "0x20000A8")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Target")]
	[HelpURL("https://www.youtube.com/watch?v=r5jiZnsDH3M")]
	public class InteractionTarget : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000A9")]
		public enum RotationMode
		{
			[Token(Token = "0x4000621")]
			TwoDOF,
			[Token(Token = "0x4000622")]
			ThreeDOF
		}

		[Serializable]
		[Token(Token = "0x20000AA")]
		public class Multiplier
		{
			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The curve type (InteractionObject.WeightCurve.Type).")]
			public InteractionObject.WeightCurve.Type curve;

			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Multiplier of the curve's value.")]
			public float multiplier;

			[Token(Token = "0x6000640")]
			[Address(RVA = "0x104EE68", Offset = "0x104EE68", VA = "0x104EE68")]
			public Multiplier()
			{
			}
		}

		[Token(Token = "0x4000614")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The type of the FBBIK effector.")]
		public FullBodyBipedEffector effectorType;

		[Token(Token = "0x4000615")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("InteractionObject weight curve multipliers for this effector target.")]
		public Multiplier[] multipliers;

		[Token(Token = "0x4000616")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The interaction speed multiplier for this effector. This can be used to make interactions faster/slower for specific effectors.")]
		public float interactionSpeedMlp;

		[Token(Token = "0x4000617")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The pivot to twist/swing this interaction target about. For symmetric objects that can be interacted with from a certain angular range.")]
		public Transform pivot;

		[Token(Token = "0x4000618")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("2 or 3 degrees of freedom to match this InteractionTarget's rotation to the effector bone rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The axis of twisting the interaction target (blue line).")]
		public Vector3 twistAxis;

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("The weight of twisting the interaction target towards the effector bone in the start of the interaction.")]
		public float twistWeight;

		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The weight of swinging the interaction target towards the effector bone in the start of the interaction. Swing is defined as a 3-DOF rotation around any axis, while twist is only around the twist axis.")]
		public float swingWeight;

		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The weight of rotating this InteractionTarget to the effector bone in the start of the interaction (and during if 'Rotate Once' is disabled")]
		[Range(0f, 1f)]
		public float threeDOFWeight;

		[Token(Token = "0x400061D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("If true, will twist/swing around the pivot only once at the start of the interaction. If false, will continue rotating throuout the whole interaction.")]
		public bool rotateOnce;

		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion defaultLocalRotation;

		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastPivot;

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x104EBD4", Offset = "0x104EBD4", VA = "0x104EBD4")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x104EC18", Offset = "0x104EC18", VA = "0x104EC18")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x104EC5C", Offset = "0x104EC5C", VA = "0x104EC5C")]
		[ContextMenu("TUTORIAL VIDEO (PART 1: BASICS)")]
		private void OpenTutorial1()
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x104ECA0", Offset = "0x104ECA0", VA = "0x104ECA0")]
		[ContextMenu("TUTORIAL VIDEO (PART 2: PICKING UP...)")]
		private void OpenTutorial2()
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x104ECE4", Offset = "0x104ECE4", VA = "0x104ECE4")]
		[ContextMenu("TUTORIAL VIDEO (PART 3: ANIMATION)")]
		private void OpenTutorial3()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x104ED28", Offset = "0x104ED28", VA = "0x104ED28")]
		[ContextMenu("TUTORIAL VIDEO (PART 4: TRIGGERS)")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x104ED6C", Offset = "0x104ED6C", VA = "0x104ED6C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x104EDB0", Offset = "0x104EDB0", VA = "0x104EDB0")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x104A1BC", Offset = "0x104A1BC", VA = "0x104A1BC")]
		public float GetValue(InteractionObject.WeightCurve.Type curveType)
		{
			return default(float);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1049310", Offset = "0x1049310", VA = "0x1049310")]
		public void ResetRotation()
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x10477A8", Offset = "0x10477A8", VA = "0x10477A8")]
		public void RotateTo(Transform bone)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x104EDF4", Offset = "0x104EDF4", VA = "0x104EDF4")]
		public InteractionTarget()
		{
		}
	}
	[Token(Token = "0x20000AB")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Interaction System/Interaction Trigger")]
	[HelpURL("https://www.youtube.com/watch?v=-TDZpNjt2mk&index=15&list=PLVxSIA1OaTOu8Nos3CalXbJ2DrKnntMv6")]
	public class InteractionTrigger : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000AC")]
		public class CharacterPosition
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("If false, will not care where the character stands, as long as it is in contact with the trigger collider.")]
			public bool use;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("The offset of the character's position relative to the trigger in XZ plane. Y position of the character is unlimited as long as it is contact with the collider.")]
			public Vector2 offset;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("Angle offset from the default forward direction.")]
			[Range(-180f, 180f)]
			public float angleOffset;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max angular offset of the character's forward from the direction of this trigger.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max offset of the character's position from this range's center.")]
			public float radius;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("If true, will rotate the trigger around it's Y axis relative to the position of the character, so the object can be interacted with from all sides.")]
			public bool orbit;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object. For example a gun will be able to be picked up from the same direction relative to the barrel no matter which side the gun is resting on.")]
			public bool fixYAxis;

			[Token(Token = "0x17000101")]
			public Vector3 offset3D
			{
				[Token(Token = "0x6000648")]
				[Address(RVA = "0x104F0D8", Offset = "0x104F0D8", VA = "0x104F0D8")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x17000102")]
			public Vector3 direction3D
			{
				[Token(Token = "0x6000649")]
				[Address(RVA = "0x104F0E4", Offset = "0x104F0E4", VA = "0x104F0E4")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x600064A")]
			[Address(RVA = "0x104F1A4", Offset = "0x104F1A4", VA = "0x104F1A4")]
			public bool IsInRange(Transform character, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600064B")]
			[Address(RVA = "0x104F908", Offset = "0x104F908", VA = "0x104F908")]
			public CharacterPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AD")]
		public class CameraPosition
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("What the camera should be looking at to trigger the interaction? If null, this camera position will not be used.")]
			public Collider lookAtTarget;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The direction from the lookAtTarget towards the camera (in lookAtTarget's space).")]
			public Vector3 direction;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("Max distance from the lookAtTarget to the camera.")]
			public float maxDistance;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Max angle between the direction and the direction towards the camera.")]
			[Range(0f, 180f)]
			public float maxAngle;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Fixes the Y axis of the trigger to Vector3.up. This makes the trigger symmetrical relative to the object.")]
			public bool fixYAxis;

			[Token(Token = "0x600064C")]
			[Address(RVA = "0x104F91C", Offset = "0x104F91C", VA = "0x104F91C")]
			public Quaternion GetRotation()
			{
				return default(Quaternion);
			}

			[Token(Token = "0x600064D")]
			[Address(RVA = "0x104FA94", Offset = "0x104FA94", VA = "0x104FA94")]
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error)
			{
				return default(bool);
			}

			[Token(Token = "0x600064E")]
			[Address(RVA = "0x104FD9C", Offset = "0x104FD9C", VA = "0x104FD9C")]
			public CameraPosition()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000AE")]
		public class Range
		{
			[Serializable]
			[Token(Token = "0x20000AF")]
			public class Interaction
			{
				[Token(Token = "0x4000637")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The InteractionObject to interact with.")]
				public InteractionObject interactionObject;

				[Token(Token = "0x4000638")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Tooltip("The effectors to interact with.")]
				public FullBodyBipedEffector[] effectors;

				[Token(Token = "0x6000651")]
				[Address(RVA = "0x104FE20", Offset = "0x104FE20", VA = "0x104FE20")]
				public Interaction()
				{
				}
			}

			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public bool show;

			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The range for the character's position and rotation.")]
			public CharacterPosition characterPosition;

			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The range for the character camera's position and rotation.")]
			public CameraPosition cameraPosition;

			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Definitions of the interactions associated with this range.")]
			public Interaction[] interactions;

			[Token(Token = "0x600064F")]
			[Address(RVA = "0x104EFC4", Offset = "0x104EFC4", VA = "0x104EFC4")]
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError)
			{
				return default(bool);
			}

			[Token(Token = "0x6000650")]
			[Address(RVA = "0x104FE10", Offset = "0x104FE10", VA = "0x104FE10")]
			public Range()
			{
			}
		}

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The valid ranges of the character's and/or it's camera's position for triggering interaction when the character is in contact with the collider of this trigger.")]
		public Range[] ranges;

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x104EE70", Offset = "0x104EE70", VA = "0x104EE70")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x104EEB4", Offset = "0x104EEB4", VA = "0x104EEB4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x104EEF8", Offset = "0x104EEF8", VA = "0x104EEF8")]
		[ContextMenu("TUTORIAL VIDEO")]
		private void OpenTutorial4()
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x104EF3C", Offset = "0x104EF3C", VA = "0x104EF3C")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x104EF80", Offset = "0x104EF80", VA = "0x104EF80")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x104D7A8", Offset = "0x104D7A8", VA = "0x104D7A8")]
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit)
		{
			return default(int);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x104F074", Offset = "0x104F074", VA = "0x104F074")]
		public InteractionTrigger()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20000B1")]
		public class Map
		{
			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000659")]
			[Address(RVA = "0x1050120", Offset = "0x1050120", VA = "0x1050120")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x600065A")]
			[Address(RVA = "0x1050478", Offset = "0x1050478", VA = "0x1050478")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x600065B")]
			[Address(RVA = "0x1050438", Offset = "0x1050438", VA = "0x1050438")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x600065C")]
			[Address(RVA = "0x10502BC", Offset = "0x10502BC", VA = "0x10502BC")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x104FE28", Offset = "0x104FE28", VA = "0x104FE28", Slot = "7")]
		[ContextMenu("Auto-Mapping")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x10501C8", Offset = "0x10501C8", VA = "0x10501C8", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000654")]
		[Address(RVA = "0x10501CC", Offset = "0x10501CC", VA = "0x10501CC", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x10503DC", Offset = "0x10503DC", VA = "0x10503DC", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x105016C", Offset = "0x105016C", VA = "0x105016C")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x105008C", Offset = "0x105008C", VA = "0x105008C")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x10504BC", Offset = "0x10504BC", VA = "0x10504BC")]
		public GenericPoser()
		{
		}
	}
	[Token(Token = "0x20000B2")]
	public class HandPoser : Poser
	{
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Transform[] children;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Transform _poseRoot;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Transform[] poseChildren;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3[] defaultLocalPositions;

		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Quaternion[] defaultLocalRotations;

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x10504DC", Offset = "0x10504DC", VA = "0x10504DC", Slot = "7")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x10505AC", Offset = "0x10505AC", VA = "0x10505AC", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1050784", Offset = "0x1050784", VA = "0x1050784", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x105086C", Offset = "0x105086C", VA = "0x105086C", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x105060C", Offset = "0x105060C", VA = "0x105060C")]
		protected void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1050B9C", Offset = "0x1050B9C", VA = "0x1050B9C")]
		public HandPoser()
		{
		}
	}
	[Token(Token = "0x20000B3")]
	public abstract class Poser : SolverManager
	{
		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform poseRoot;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float localRotationWeight;

		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float localPositionWeight;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool initiated;

		[Token(Token = "0x6000663")]
		public abstract void AutoMapping();

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1050BAC", Offset = "0x1050BAC", VA = "0x1050BAC")]
		public void UpdateManual()
		{
		}

		[Token(Token = "0x6000665")]
		protected abstract void InitiatePoser();

		[Token(Token = "0x6000666")]
		protected abstract void UpdatePoser();

		[Token(Token = "0x6000667")]
		protected abstract void FixPoserTransforms();

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1050BB8", Offset = "0x1050BB8", VA = "0x1050BB8", Slot = "5")]
		protected override void UpdateSolver()
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1050BFC", Offset = "0x1050BFC", VA = "0x1050BFC", Slot = "4")]
		protected override void InitiateSolver()
		{
		}

		[Token(Token = "0x600066A")]
		[Address(RVA = "0x1050C28", Offset = "0x1050C28", VA = "0x1050C28", Slot = "6")]
		protected override void FixTransforms()
		{
		}

		[Token(Token = "0x600066B")]
		[Address(RVA = "0x10504CC", Offset = "0x10504CC", VA = "0x10504CC")]
		protected Poser()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class RagdollUtility : MonoBehaviour
	{
		[Token(Token = "0x20000B5")]
		public class Rigidbone
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody r;

			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform t;

			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Collider collider;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Joint joint;

			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Rigidbody c;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool updateAnchor;

			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector3 deltaPosition;

			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Quaternion deltaRotation;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public float deltaTime;

			[Token(Token = "0x4000661")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			public Vector3 lastPosition;

			[Token(Token = "0x4000662")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Quaternion lastRotation;

			[Token(Token = "0x600067E")]
			[Address(RVA = "0x1051298", Offset = "0x1051298", VA = "0x1051298")]
			public Rigidbone(Rigidbody r)
			{
			}

			[Token(Token = "0x600067F")]
			[Address(RVA = "0x1051E44", Offset = "0x1051E44", VA = "0x1051E44")]
			public void RecordVelocity()
			{
			}

			[Token(Token = "0x6000680")]
			[Address(RVA = "0x1051C04", Offset = "0x1051C04", VA = "0x1051C04")]
			public void WakeUp(float velocityWeight, float angularVelocityWeight)
			{
			}
		}

		[Token(Token = "0x20000B6")]
		public class Child
		{
			[Token(Token = "0x4000663")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform t;

			[Token(Token = "0x4000664")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 localPosition;

			[Token(Token = "0x4000665")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public Quaternion localRotation;

			[Token(Token = "0x6000681")]
			[Address(RVA = "0x1051440", Offset = "0x1051440", VA = "0x1051440")]
			public Child(Transform transform)
			{
			}

			[Token(Token = "0x6000682")]
			[Address(RVA = "0x1051F5C", Offset = "0x1051F5C", VA = "0x1051F5C")]
			public void FixTransform(float weight)
			{
			}

			[Token(Token = "0x6000683")]
			[Address(RVA = "0x1051F18", Offset = "0x1051F18", VA = "0x1051F18")]
			public void StoreLocalState()
			{
			}
		}

		[Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private sealed class <DisableRagdollSmooth>d__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000666")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000667")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000668")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public RagdollUtility <>4__this;

			[Token(Token = "0x17000105")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000687")]
				[Address(RVA = "0x10524C8", Offset = "0x10524C8", VA = "0x10524C8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000106")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000689")]
				[Address(RVA = "0x1052510", Offset = "0x1052510", VA = "0x1052510", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000684")]
			[Address(RVA = "0x10514AC", Offset = "0x10514AC", VA = "0x10514AC")]
			[DebuggerHidden]
			public <DisableRagdollSmooth>d__21(int <>1__state)
			{
			}

			[Token(Token = "0x6000685")]
			[Address(RVA = "0x10522D8", Offset = "0x10522D8", VA = "0x10522D8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000686")]
			[Address(RVA = "0x10522DC", Offset = "0x10522DC", VA = "0x10522DC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000688")]
			[Address(RVA = "0x10524D0", Offset = "0x10524D0", VA = "0x10524D0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If you have multiple IK components, then this should be the one that solves last each frame.")]
		public IK ik;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("How long does it take to blend from ragdoll to animation?")]
		public float ragdollToAnimationTime;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("If true, IK can be used on top of physical ragdoll simulation.")]
		public bool applyIkOnRagdoll;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("How much velocity transfer from animation to ragdoll?")]
		public float applyVelocity;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("How much angular velocity to transfer from animation to ragdoll?")]
		public float applyAngularVelocity;

		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Rigidbone[] rigidbones;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Child[] children;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool enableRagdollFlag;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorUpdateMode animatorUpdateMode;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private IK[] allIKComponents;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool[] fixTransforms;

		[Token(Token = "0x4000654")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float ragdollWeight;

		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float ragdollWeightV;

		[Token(Token = "0x4000656")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool fixedFrame;

		[Token(Token = "0x4000657")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool[] disabledIKComponents;

		[Token(Token = "0x17000103")]
		private bool isRagdoll
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1050C6C", Offset = "0x1050C6C", VA = "0x1050C6C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000104")]
		private bool ikUsed
		{
			[Token(Token = "0x6000679")]
			[Address(RVA = "0x1051838", Offset = "0x1051838", VA = "0x1051838")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1050C40", Offset = "0x1050C40", VA = "0x1050C40")]
		public void EnableRagdoll()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1050CD0", Offset = "0x1050CD0", VA = "0x1050CD0")]
		public void DisableRagdoll()
		{
		}

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1050DE8", Offset = "0x1050DE8", VA = "0x1050DE8")]
		public void Start()
		{
		}

		[Token(Token = "0x600066F")]
		[Address(RVA = "0x1050D74", Offset = "0x1050D74", VA = "0x1050D74")]
		[IteratorStateMachine(typeof(<DisableRagdollSmooth>d__21))]
		private IEnumerator DisableRagdollSmooth()
		{
			return null;
		}

		[Token(Token = "0x6000670")]
		[Address(RVA = "0x10514D4", Offset = "0x10514D4", VA = "0x10514D4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000671")]
		[Address(RVA = "0x10516FC", Offset = "0x10516FC", VA = "0x10516FC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000672")]
		[Address(RVA = "0x105179C", Offset = "0x105179C", VA = "0x105179C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000673")]
		[Address(RVA = "0x105198C", Offset = "0x105198C", VA = "0x105198C")]
		private void AfterLastIK()
		{
		}

		[Token(Token = "0x6000674")]
		[Address(RVA = "0x105180C", Offset = "0x105180C", VA = "0x105180C")]
		private void AfterAnimation()
		{
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1051958", Offset = "0x1051958", VA = "0x1051958")]
		private void OnFinalPose()
		{
		}

		[Token(Token = "0x6000676")]
		[Address(RVA = "0x1051A0C", Offset = "0x1051A0C", VA = "0x1051A0C")]
		private void RagdollEnabler()
		{
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x10519B0", Offset = "0x10519B0", VA = "0x10519B0")]
		private void RecordVelocities()
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1050D18", Offset = "0x1050D18", VA = "0x1050D18")]
		private void StoreLocalState()
		{
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1051730", Offset = "0x1051730", VA = "0x1051730")]
		private void FixTransforms(float weight)
		{
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x105206C", Offset = "0x105206C", VA = "0x105206C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x10521A4", Offset = "0x10521A4", VA = "0x10521A4")]
		public RagdollUtility()
		{
		}
	}
	[Token(Token = "0x20000B8")]
	public abstract class RotationLimit : MonoBehaviour
	{
		[Token(Token = "0x4000669")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 axis;

		[Token(Token = "0x400066A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[HideInInspector]
		public Quaternion defaultLocalRotation;

		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
		private bool initiated;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
		private bool applicationQuit;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x37")]
		private bool defaultLocalRotationSet;

		[Token(Token = "0x17000107")]
		public Vector3 secondaryAxis
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x105297C", Offset = "0x105297C", VA = "0x105297C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000108")]
		public Vector3 crossAxis
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1052988", Offset = "0x1052988", VA = "0x1052988")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000109")]
		public bool defaultLocalRotationOverride
		{
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x10529B8", Offset = "0x10529B8", VA = "0x10529B8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x10529C0", Offset = "0x10529C0", VA = "0x10529C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1052518", Offset = "0x1052518", VA = "0x1052518")]
		public void SetDefaultLocalRotation()
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1052554", Offset = "0x1052554", VA = "0x1052554")]
		public void SetDefaultLocalRotation(Quaternion localRotation)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x105256C", Offset = "0x105256C", VA = "0x105256C")]
		public Quaternion GetLimitedLocalRotation(Quaternion localRotation, out bool changed)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x10528EC", Offset = "0x10528EC", VA = "0x10528EC")]
		public bool Apply()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1052950", Offset = "0x1052950", VA = "0x1052950")]
		public void Disable()
		{
		}

		[Token(Token = "0x6000693")]
		protected abstract Quaternion LimitRotation(Quaternion rotation);

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x10527F0", Offset = "0x10527F0", VA = "0x10527F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x10529CC", Offset = "0x10529CC", VA = "0x10529CC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x10529D0", Offset = "0x10529D0", VA = "0x10529D0")]
		public void LogWarning(string message)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x10529F8", Offset = "0x10529F8", VA = "0x10529F8")]
		protected static Quaternion Limit1DOF(Quaternion rotation, Vector3 axis)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1052ACC", Offset = "0x1052ACC", VA = "0x1052ACC")]
		protected static Quaternion LimitTwist(Quaternion rotation, Vector3 axis, Vector3 orthoAxis, float twistLimit)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1052D24", Offset = "0x1052D24", VA = "0x1052D24")]
		protected static float GetOrthogonalAngle(Vector3 v1, Vector3 v2, Vector3 normal)
		{
			return default(float);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1052E78", Offset = "0x1052E78", VA = "0x1052E78")]
		protected RotationLimit()
		{
		}
	}
	[Token(Token = "0x20000B9")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Angle")]
	public class RotationLimitAngle : RotationLimit
	{
		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float limit;

		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1052ED8", Offset = "0x1052ED8", VA = "0x1052ED8")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1052F1C", Offset = "0x1052F1C", VA = "0x1052F1C")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1052F60", Offset = "0x1052F60", VA = "0x1052F60")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1052FA4", Offset = "0x1052FA4", VA = "0x1052FA4")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1052FE8", Offset = "0x1052FE8", VA = "0x1052FE8", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1053020", Offset = "0x1053020", VA = "0x1053020")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1053344", Offset = "0x1053344", VA = "0x1053344")]
		public RotationLimitAngle()
		{
		}
	}
	[Token(Token = "0x20000BA")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Hinge")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	public class RotationLimitHinge : RotationLimit
	{
		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool useLimits;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float min;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float max;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[HideInInspector]
		public float zeroAxisDisplayOffset;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float lastAngle;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1053354", Offset = "0x1053354", VA = "0x1053354")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1053398", Offset = "0x1053398", VA = "0x1053398")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x10533DC", Offset = "0x10533DC", VA = "0x10533DC")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1053420", Offset = "0x1053420", VA = "0x1053420")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1053464", Offset = "0x1053464", VA = "0x1053464", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1053468", Offset = "0x1053468", VA = "0x1053468")]
		private Quaternion LimitHinge(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1053688", Offset = "0x1053688", VA = "0x1053688")]
		public RotationLimitHinge()
		{
		}
	}
	[Token(Token = "0x20000BB")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Polygonal")]
	public class RotationLimitPolygonal : RotationLimit
	{
		[Serializable]
		[Token(Token = "0x20000BC")]
		public class ReachCone
		{
			[Token(Token = "0x400067B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] tetrahedron;

			[Token(Token = "0x400067C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float volume;

			[Token(Token = "0x400067D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 S;

			[Token(Token = "0x400067E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 B;

			[Token(Token = "0x1700010A")]
			public Vector3 o
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1055534", Offset = "0x1055534", VA = "0x1055534")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010B")]
			public Vector3 a
			{
				[Token(Token = "0x60006BA")]
				[Address(RVA = "0x1055560", Offset = "0x1055560", VA = "0x1055560")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010C")]
			public Vector3 b
			{
				[Token(Token = "0x60006BB")]
				[Address(RVA = "0x1055590", Offset = "0x1055590", VA = "0x1055590")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010D")]
			public Vector3 c
			{
				[Token(Token = "0x60006BC")]
				[Address(RVA = "0x10555C0", Offset = "0x10555C0", VA = "0x10555C0")]
				get
				{
					return default(Vector3);
				}
			}

			[Token(Token = "0x1700010E")]
			public bool isValid
			{
				[Token(Token = "0x60006BE")]
				[Address(RVA = "0x1054A5C", Offset = "0x1054A5C", VA = "0x1054A5C")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1054F00", Offset = "0x1054F00", VA = "0x1054F00")]
			public ReachCone(Vector3 _o, Vector3 _a, Vector3 _b, Vector3 _c)
			{
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1055078", Offset = "0x1055078", VA = "0x1055078")]
			public void Calculate()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000BD")]
		public class LimitPoint
		{
			[Token(Token = "0x400067F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 point;

			[Token(Token = "0x4000680")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float tangentWeight;

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x1054A6C", Offset = "0x1054A6C", VA = "0x1054A6C")]
			public LimitPoint()
			{
			}
		}

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 3f)]
		public int smoothIterations;

		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public LimitPoint[] points;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[HideInInspector]
		public Vector3[] P;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[HideInInspector]
		public ReachCone[] reachCones;

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x10536A0", Offset = "0x10536A0", VA = "0x10536A0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x10536E4", Offset = "0x10536E4", VA = "0x10536E4")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1053728", Offset = "0x1053728", VA = "0x1053728")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x105376C", Offset = "0x105376C", VA = "0x105376C")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x10537B0", Offset = "0x10537B0", VA = "0x10537B0")]
		public void SetLimitPoints(LimitPoint[] points)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1053E94", Offset = "0x1053E94", VA = "0x1053E94", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1053F1C", Offset = "0x1053F1C", VA = "0x1053F1C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1054568", Offset = "0x1054568", VA = "0x1054568")]
		public void ResetToDefault()
		{
		}

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1053848", Offset = "0x1053848", VA = "0x1053848")]
		public void BuildReachCones()
		{
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1054AD0", Offset = "0x1054AD0", VA = "0x1054AD0")]
		private Vector3[] SmoothPoints()
		{
			return null;
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x10552EC", Offset = "0x10552EC", VA = "0x10552EC")]
		private float GetScalar(int k)
		{
			return default(float);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1055334", Offset = "0x1055334", VA = "0x1055334")]
		private Vector3 PointToTangentPlane(Vector3 p, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1055394", Offset = "0x1055394", VA = "0x1055394")]
		private Vector3 TangentPointToSphere(Vector3 q, float r)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x10542C4", Offset = "0x10542C4", VA = "0x10542C4")]
		private Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1055400", Offset = "0x1055400", VA = "0x1055400")]
		private int GetReachCone(Vector3 L)
		{
			return default(int);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x10554CC", Offset = "0x10554CC", VA = "0x10554CC")]
		public RotationLimitPolygonal()
		{
		}
	}
	[Token(Token = "0x20000BE")]
	[HelpURL("http://www.root-motion.com/finalikdox/html/page14.html")]
	[AddComponentMenu("Scripts/RootMotion.FinalIK/Rotation Limits/Rotation Limit Spline")]
	public class RotationLimitSpline : RotationLimit
	{
		[Token(Token = "0x4000681")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 180f)]
		public float twistLimit;

		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public AnimationCurve spline;

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x10555F0", Offset = "0x10555F0", VA = "0x10555F0")]
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1055634", Offset = "0x1055634", VA = "0x1055634")]
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1055678", Offset = "0x1055678", VA = "0x1055678")]
		[ContextMenu("Support Group")]
		private void SupportGroup()
		{
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x10556BC", Offset = "0x10556BC", VA = "0x10556BC")]
		[ContextMenu("Asset Store Thread")]
		private void ASThread()
		{
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1055700", Offset = "0x1055700", VA = "0x1055700")]
		public void SetSpline(Keyframe[] keyframes)
		{
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x105571C", Offset = "0x105571C", VA = "0x105571C", Slot = "4")]
		protected override Quaternion LimitRotation(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1055754", Offset = "0x1055754", VA = "0x1055754")]
		public Quaternion LimitSwing(Quaternion rotation)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1055B00", Offset = "0x1055B00", VA = "0x1055B00")]
		public RotationLimitSpline()
		{
		}
	}
	[Token(Token = "0x20000BF")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class <TurnToTarget>d__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AimController <>4__this;

			[Token(Token = "0x17000110")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006D3")]
				[Address(RVA = "0x1056B04", Offset = "0x1056B04", VA = "0x1056B04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000111")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006D5")]
				[Address(RVA = "0x1056B4C", Offset = "0x1056B4C", VA = "0x1056B4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x1056904", Offset = "0x1056904", VA = "0x1056904")]
			[DebuggerHidden]
			public <TurnToTarget>d__37(int <>1__state)
			{
			}

			[Token(Token = "0x60006D1")]
			[Address(RVA = "0x1056A10", Offset = "0x1056A10", VA = "0x1056A10", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006D2")]
			[Address(RVA = "0x1056A14", Offset = "0x1056A14", VA = "0x1056A14", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x1056B0C", Offset = "0x1056B0C", VA = "0x1056B0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK ik;

		[Token(Token = "0x4000684")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		[Tooltip("Master weight of the IK solver.")]
		public float weight;

		[Token(Token = "0x4000685")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The target to aim at. Do not use the Target transform that is assigned to AimIK. Set to null if you wish to stop aiming.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x4000686")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000687")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("The time it takes to blend in/out of AimIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000688")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000689")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x400068A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x400068B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x400068C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Smoothing time for turning towards the yaw and pitch of the target using Mathf.SmoothDampAngle. Value of 0 means smooth damping is disabled.")]
		public float smoothDampTime;

		[Token(Token = "0x400068D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("The position of the pivot that the aim target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x400068E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("Minimum distance of aiming from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x400068F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Offset applied to the target in world space. Convenient for scripting aiming inaccuracy.")]
		public Vector3 offset;

		[Token(Token = "0x4000690")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("RootRotation")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the aiming direction.")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("If enabled, aligns the root forward to target direction after 'Max Root Angle' has been exceeded.")]
		public bool turnToTarget;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("The time of turning towards the target direction if 'Max Root Angle has been exceeded and 'Turn To Target' is enabled.")]
		public float turnToTargetTime;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Header("Mode")]
		[Tooltip("If true, AimIK will consider whatever the current direction of the weapon to be the forward aiming direction and work additively on top of that. This enables you to use recoil and reloading animations seamlessly with AimIK. Adjust the Vector3 value below if the weapon is not aiming perfectly forward in the aiming animation clip.")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[Tooltip("The direction of the animated weapon aiming in character space. Tweak this value to adjust the aiming. 'Use Animated Aim Direction' must be enabled for this property to work.")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Transform lastTarget;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float switchWeight;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float switchWeightV;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float weightV;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 dir;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB5")]
		private bool turningToTarget;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float turnToTargetMlp;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float turnToTargetMlpV;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float yawV;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private float pitchV;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float dirMagV;

		[Token(Token = "0x1700010F")]
		private Vector3 pivot
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x1055B8C", Offset = "0x1055B8C", VA = "0x1055B8C")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1055B0C", Offset = "0x1055B0C", VA = "0x1055B0C")]
		private void Start()
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1055C10", Offset = "0x1055C10", VA = "0x1055C10")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1056468", Offset = "0x1056468", VA = "0x1056468")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x10565EC", Offset = "0x10565EC", VA = "0x10565EC")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1056890", Offset = "0x1056890", VA = "0x1056890")]
		[IteratorStateMachine(typeof(<TurnToTarget>d__37))]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x105692C", Offset = "0x105692C", VA = "0x105692C")]
		public AimController()
		{
		}
	}
	[Token(Token = "0x20000C1")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000C2")]
		public class Pose
		{
			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x40006AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x40006AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x1056C24", Offset = "0x1056C24", VA = "0x1056C24")]
			public bool IsInDirection(Vector3 d)
			{
				return default(bool);
			}

			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x10571A0", Offset = "0x10571A0", VA = "0x10571A0")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x10571A8", Offset = "0x10571A8", VA = "0x10571A8")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1056B54", Offset = "0x1056B54", VA = "0x1056B54")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x10570D4", Offset = "0x10570D4", VA = "0x10570D4")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1057134", Offset = "0x1057134", VA = "0x1057134")]
		public AimPoser()
		{
		}
	}
	[Token(Token = "0x20000C3")]
	public class Amplifier : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000C4")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000C5")]
			public class EffectorLink
			{
				[Token(Token = "0x40006B7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006B8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x60006E1")]
				[Address(RVA = "0x1057634", Offset = "0x1057634", VA = "0x1057634")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform that's motion we are reading.")]
			public Transform transform;

			[Token(Token = "0x40006AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Amplify the 'transform's' position relative to this Transform.")]
			public Transform relativeTo;

			[Token(Token = "0x40006B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x40006B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Amplification magnitude along the up axis of the character.")]
			public float verticalWeight;

			[Token(Token = "0x40006B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Amplification magnitude along the horizontal axes of the character.")]
			public float horizontalWeight;

			[Token(Token = "0x40006B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("Speed of the amplifier. 0 means instant.")]
			public float speed;

			[Token(Token = "0x40006B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 lastRelativePos;

			[Token(Token = "0x40006B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Vector3 smoothDelta;

			[Token(Token = "0x40006B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private bool firstUpdate;

			[Token(Token = "0x60006DE")]
			[Address(RVA = "0x10572F4", Offset = "0x10572F4", VA = "0x10572F4")]
			public void Update(IKSolverFullBodyBiped solver, float w, float deltaTime)
			{
			}

			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x105760C", Offset = "0x105760C", VA = "0x105760C")]
			private static Vector3 Multiply(Vector3 v1, Vector3 v2)
			{
				return default(Vector3);
			}

			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x105761C", Offset = "0x105761C", VA = "0x105761C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The amplified bodies.")]
		public Body[] bodies;

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x10571C4", Offset = "0x10571C4", VA = "0x10571C4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1057604", Offset = "0x1057604", VA = "0x1057604")]
		public Amplifier()
		{
		}
	}
	[Token(Token = "0x20000C6")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Speed of tilting")]
		public float tiltSpeed;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Sensitivity of tilting")]
		public float tiltSensitivity;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseLeft;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("The OffsetPose components")]
		public OffsetPose poseRight;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x105763C", Offset = "0x105763C", VA = "0x105763C", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1057678", Offset = "0x1057678", VA = "0x1057678", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1057864", Offset = "0x1057864", VA = "0x1057864")]
		public BodyTilt()
		{
		}
	}
	[Token(Token = "0x20000C7")]
	public class CCDBendGoal : MonoBehaviour
	{
		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CCDIK ik;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1057878", Offset = "0x1057878", VA = "0x1057878")]
		private void Start()
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1057958", Offset = "0x1057958", VA = "0x1057958")]
		private void BeforeIK()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1057BEC", Offset = "0x1057BEC", VA = "0x1057BEC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1057D18", Offset = "0x1057D18", VA = "0x1057D18")]
		public CCDBendGoal()
		{
		}
	}
	[Token(Token = "0x20000C8")]
	[ExecuteInEditMode]
	public class EditorIK : MonoBehaviour
	{
		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("If slot assigned, will update Animator before IK.")]
		public Animator animator;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Create/Final IK/Editor IK Pose")]
		public EditorIKPose defaultPose;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[HideInInspector]
		public Transform[] bones;

		[Token(Token = "0x17000112")]
		public IK ik
		{
			[Token(Token = "0x60006E9")]
			[Address(RVA = "0x1057D28", Offset = "0x1057D28", VA = "0x1057D28")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0x1057D30", Offset = "0x1057D30", VA = "0x1057D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1057D38", Offset = "0x1057D38", VA = "0x1057D38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1057ED8", Offset = "0x1057ED8", VA = "0x1057ED8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1058134", Offset = "0x1058134", VA = "0x1058134")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1058270", Offset = "0x1058270", VA = "0x1058270")]
		public void StoreDefaultPose()
		{
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1058450", Offset = "0x1058450", VA = "0x1058450")]
		public bool Initiate()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1058664", Offset = "0x1058664", VA = "0x1058664")]
		public void Update()
		{
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x10588E8", Offset = "0x10588E8", VA = "0x10588E8")]
		public EditorIK()
		{
		}
	}
	[Token(Token = "0x20000C9")]
	[CreateAssetMenu(fileName = "Editor IK Pose", menuName = "Final IK/Editor IK Pose", order = 1)]
	public class EditorIKPose : ScriptableObject
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3[] localPositions;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Quaternion[] localRotations;

		[Token(Token = "0x17000113")]
		public bool poseStored
		{
			[Token(Token = "0x60006F2")]
			[Address(RVA = "0x1057FB4", Offset = "0x1057FB4", VA = "0x1057FB4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x10582EC", Offset = "0x10582EC", VA = "0x10582EC")]
		public void Store(Transform[] T)
		{
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1057FD8", Offset = "0x1057FD8", VA = "0x1057FD8")]
		public bool Restore(Transform[] T)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x105894C", Offset = "0x105894C", VA = "0x105894C")]
		public EditorIKPose()
		{
		}
	}
	[Token(Token = "0x20000CA")]
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000CB")]
		public abstract class HitPoint
		{
			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40006D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40006D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40006D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x17000115")]
			public bool inProgress
			{
				[Token(Token = "0x60006FA")]
				[Address(RVA = "0x1058A84", Offset = "0x1058A84", VA = "0x1058A84")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000116")]
			protected float crossFader
			{
				[Token(Token = "0x60006FB")]
				[Address(RVA = "0x1058F7C", Offset = "0x1058F7C", VA = "0x1058F7C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FC")]
				[Address(RVA = "0x1058F84", Offset = "0x1058F84", VA = "0x1058F84")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000117")]
			protected float timer
			{
				[Token(Token = "0x60006FD")]
				[Address(RVA = "0x1058F8C", Offset = "0x1058F8C", VA = "0x1058F8C")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x60006FE")]
				[Address(RVA = "0x1058F94", Offset = "0x1058F94", VA = "0x1058F94")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000118")]
			protected Vector3 force
			{
				[Token(Token = "0x60006FF")]
				[Address(RVA = "0x1058F9C", Offset = "0x1058F9C", VA = "0x1058F9C")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000700")]
				[Address(RVA = "0x1058FA8", Offset = "0x1058FA8", VA = "0x1058FA8")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x17000119")]
			protected Vector3 point
			{
				[Token(Token = "0x6000701")]
				[Address(RVA = "0x1058FB4", Offset = "0x1058FB4", VA = "0x1058FB4")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000702")]
				[Address(RVA = "0x1058FC0", Offset = "0x1058FC0", VA = "0x1058FC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1058E4C", Offset = "0x1058E4C", VA = "0x1058E4C")]
			public void Hit(Vector3 force, Vector3 point)
			{
			}

			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1058B58", Offset = "0x1058B58", VA = "0x1058B58")]
			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000705")]
			protected abstract float GetLength();

			[Token(Token = "0x6000706")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000707")]
			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);

			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1058FCC", Offset = "0x1058FCC", VA = "0x1058FCC")]
			protected HitPoint()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CC")]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000CD")]
			public class EffectorLink
			{
				[Token(Token = "0x40006D6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x40006D7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40006D8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006D9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600070D")]
				[Address(RVA = "0x1059304", Offset = "0x1059304", VA = "0x1059304")]
				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600070E")]
				[Address(RVA = "0x10593A0", Offset = "0x10593A0", VA = "0x10593A0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600070F")]
				[Address(RVA = "0x10593B4", Offset = "0x10593B4", VA = "0x10593B4")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Token(Token = "0x40006D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Token(Token = "0x40006D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x6000709")]
			[Address(RVA = "0x1058FE0", Offset = "0x1058FE0", VA = "0x1058FE0", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x600070A")]
			[Address(RVA = "0x10590FC", Offset = "0x10590FC", VA = "0x10590FC", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600070B")]
			[Address(RVA = "0x105915C", Offset = "0x105915C", VA = "0x105915C", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600070C")]
			[Address(RVA = "0x10592F0", Offset = "0x10592F0", VA = "0x10592F0")]
			public HitPointEffector()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000CE")]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			[Token(Token = "0x20000CF")]
			public class BoneLink
			{
				[Token(Token = "0x40006DD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Token(Token = "0x40006DE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40006DF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private Quaternion lastValue;

				[Token(Token = "0x40006E0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
				private Quaternion current;

				[Token(Token = "0x6000714")]
				[Address(RVA = "0x1059684", Offset = "0x1059684", VA = "0x1059684")]
				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000715")]
				[Address(RVA = "0x10594A0", Offset = "0x10594A0", VA = "0x10594A0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000716")]
				[Address(RVA = "0x1059818", Offset = "0x1059818", VA = "0x1059818")]
				public BoneLink()
				{
				}
			}

			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x6000710")]
			[Address(RVA = "0x10593BC", Offset = "0x10593BC", VA = "0x10593BC", Slot = "4")]
			protected override float GetLength()
			{
				return default(float);
			}

			[Token(Token = "0x6000711")]
			[Address(RVA = "0x1059448", Offset = "0x1059448", VA = "0x1059448", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000712")]
			[Address(RVA = "0x10594AC", Offset = "0x10594AC", VA = "0x10594AC", Slot = "6")]
			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x6000713")]
			[Address(RVA = "0x1059810", Offset = "0x1059810", VA = "0x1059810")]
			public HitPointBone()
			{
			}
		}

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		[Token(Token = "0x17000114")]
		public bool inProgress
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0x10589E8", Offset = "0x10589E8", VA = "0x10589E8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1058A98", Offset = "0x1058A98", VA = "0x1058A98", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1058C30", Offset = "0x1058C30", VA = "0x1058C30")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1058F74", Offset = "0x1058F74", VA = "0x1058F74")]
		public HitReaction()
		{
		}
	}
	[Token(Token = "0x20000D0")]
	public class HitReactionVRIK : OffsetModifierVRIK
	{
		[Serializable]
		[Token(Token = "0x20000D1")]
		public abstract class Offset
		{
			[Token(Token = "0x40006E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Token(Token = "0x40006E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Token(Token = "0x40006E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			[Token(Token = "0x40006EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float length;

			[Token(Token = "0x40006EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float crossFadeSpeed;

			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			private float lastTime;

			[Token(Token = "0x1700011A")]
			protected float crossFader
			{
				[Token(Token = "0x600071A")]
				[Address(RVA = "0x1059D88", Offset = "0x1059D88", VA = "0x1059D88")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071B")]
				[Address(RVA = "0x1059D90", Offset = "0x1059D90", VA = "0x1059D90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011B")]
			protected float timer
			{
				[Token(Token = "0x600071C")]
				[Address(RVA = "0x1059D98", Offset = "0x1059D98", VA = "0x1059D98")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x600071D")]
				[Address(RVA = "0x1059DA0", Offset = "0x1059DA0", VA = "0x1059DA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011C")]
			protected Vector3 force
			{
				[Token(Token = "0x600071E")]
				[Address(RVA = "0x1059DA8", Offset = "0x1059DA8", VA = "0x1059DA8")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x600071F")]
				[Address(RVA = "0x1059DB4", Offset = "0x1059DB4", VA = "0x1059DB4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x1700011D")]
			protected Vector3 point
			{
				[Token(Token = "0x6000720")]
				[Address(RVA = "0x1059DC0", Offset = "0x1059DC0", VA = "0x1059DC0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000721")]
				[Address(RVA = "0x1059DCC", Offset = "0x1059DCC", VA = "0x1059DCC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Token(Token = "0x6000722")]
			[Address(RVA = "0x1059C38", Offset = "0x1059C38", VA = "0x1059C38")]
			public void Hit(Vector3 force, AnimationCurve[] curves, Vector3 point)
			{
			}

			[Token(Token = "0x6000723")]
			[Address(RVA = "0x1059934", Offset = "0x1059934", VA = "0x1059934")]
			public void Apply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000724")]
			protected abstract float GetLength(AnimationCurve[] curves);

			[Token(Token = "0x6000725")]
			protected abstract void CrossFadeStart();

			[Token(Token = "0x6000726")]
			protected abstract void OnApply(VRIK ik, AnimationCurve[] curves, float weight);

			[Token(Token = "0x6000727")]
			[Address(RVA = "0x1059DD8", Offset = "0x1059DD8", VA = "0x1059DD8")]
			protected Offset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D2")]
		public class PositionOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D3")]
			public class PositionOffsetLink
			{
				[Token(Token = "0x40006F1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("The FBBIK effector type")]
				public IKSolverVR.PositionOffset positionOffset;

				[Token(Token = "0x40006F2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				[Token(Token = "0x40006F3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Vector3 lastValue;

				[Token(Token = "0x40006F4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				private Vector3 current;

				[Token(Token = "0x600072C")]
				[Address(RVA = "0x105A1BC", Offset = "0x105A1BC", VA = "0x105A1BC")]
				public void Apply(VRIK ik, Vector3 offset, float crossFader)
				{
				}

				[Token(Token = "0x600072D")]
				[Address(RVA = "0x1059FE0", Offset = "0x1059FE0", VA = "0x1059FE0")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x600072E")]
				[Address(RVA = "0x105A250", Offset = "0x105A250", VA = "0x105A250")]
				public PositionOffsetLink()
				{
				}
			}

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Offset magnitude in the direction of the hit force")]
			public int forceDirCurveIndex;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			[Tooltip("Offset magnitude in the direction of character.up")]
			public int upDirCurveIndex;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this offset to the VRIK position offsets")]
			public PositionOffsetLink[] offsetLinks;

			[Token(Token = "0x6000728")]
			[Address(RVA = "0x1059DEC", Offset = "0x1059DEC", VA = "0x1059DEC", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000729")]
			[Address(RVA = "0x1059F80", Offset = "0x1059F80", VA = "0x1059F80", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x600072A")]
			[Address(RVA = "0x1059FF4", Offset = "0x1059FF4", VA = "0x1059FF4", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x600072B")]
			[Address(RVA = "0x105A234", Offset = "0x105A234", VA = "0x105A234")]
			public PositionOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000D4")]
		public class RotationOffset : Offset
		{
			[Serializable]
			[Token(Token = "0x20000D5")]
			public class RotationOffsetLink
			{
				[Token(Token = "0x40006F8")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Reference to the bone that this hit point rotates")]
				public IKSolverVR.RotationOffset rotationOffset;

				[Token(Token = "0x40006F9")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Range(0f, 1f)]
				[Tooltip("Weight of rotating the bone")]
				public float weight;

				[Token(Token = "0x40006FA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private Quaternion lastValue;

				[Token(Token = "0x40006FB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				private Quaternion current;

				[Token(Token = "0x6000733")]
				[Address(RVA = "0x105A624", Offset = "0x105A624", VA = "0x105A624")]
				public void Apply(VRIK ik, Quaternion offset, float crossFader)
				{
				}

				[Token(Token = "0x6000734")]
				[Address(RVA = "0x105A388", Offset = "0x105A388", VA = "0x105A388")]
				public void CrossFadeStart()
				{
				}

				[Token(Token = "0x6000735")]
				[Address(RVA = "0x105A740", Offset = "0x105A740", VA = "0x105A740")]
				public RotationOffsetLink()
				{
				}
			}

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("The angle to rotate the bone around it's rigidbody's world center of mass")]
			public int curveIndex;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			[Tooltip("Linking this hit point to bone(s)")]
			public RotationOffsetLink[] offsetLinks;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private Rigidbody rigidbody;

			[Token(Token = "0x600072F")]
			[Address(RVA = "0x105A258", Offset = "0x105A258", VA = "0x105A258", Slot = "4")]
			protected override float GetLength(AnimationCurve[] curves)
			{
				return default(float);
			}

			[Token(Token = "0x6000730")]
			[Address(RVA = "0x105A330", Offset = "0x105A330", VA = "0x105A330", Slot = "5")]
			protected override void CrossFadeStart()
			{
			}

			[Token(Token = "0x6000731")]
			[Address(RVA = "0x105A394", Offset = "0x105A394", VA = "0x105A394", Slot = "6")]
			protected override void OnApply(VRIK ik, AnimationCurve[] curves, float weight)
			{
			}

			[Token(Token = "0x6000732")]
			[Address(RVA = "0x105A72C", Offset = "0x105A72C", VA = "0x105A72C")]
			public RotationOffset()
			{
			}
		}

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve[] offsetCurves;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Hit points for the FBBIK effectors")]
		public PositionOffset[] positionOffsets;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public RotationOffset[] rotationOffsets;

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x105987C", Offset = "0x105987C", VA = "0x105987C", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1059A14", Offset = "0x1059A14", VA = "0x1059A14")]
		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1059D68", Offset = "0x1059D68", VA = "0x1059D68")]
		public HitReactionVRIK()
		{
		}
	}
	[Token(Token = "0x20000D6")]
	public class Inertia : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000D7")]
		public class Body
		{
			[Serializable]
			[Token(Token = "0x20000D8")]
			public class EffectorLink
			{
				[Token(Token = "0x4000709")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x400070A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600073C")]
				[Address(RVA = "0x105AD38", Offset = "0x105AD38", VA = "0x105AD38")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The Transform to follow, can be any bone of the character")]
			public Transform transform;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Linking the body to effectors. One Body can be used to offset more than one effector")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The speed to follow the Transform")]
			public float speed;

			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The acceleration, smaller values means lazyer following")]
			public float acceleration;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Matching target velocity")]
			[Range(0f, 1f)]
			public float matchVelocity;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("gravity applied to the Body")]
			public float gravity;

			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 delta;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lazyPoint;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 direction;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 lastPosition;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private bool firstUpdate;

			[Token(Token = "0x6000739")]
			[Address(RVA = "0x105A810", Offset = "0x105A810", VA = "0x105A810")]
			public void Reset()
			{
			}

			[Token(Token = "0x600073A")]
			[Address(RVA = "0x105A9B0", Offset = "0x105A9B0", VA = "0x105A9B0")]
			public void Update(IKSolverFullBodyBiped solver, float weight, float deltaTime)
			{
			}

			[Token(Token = "0x600073B")]
			[Address(RVA = "0x105AD1C", Offset = "0x105AD1C", VA = "0x105AD1C")]
			public Body()
			{
			}
		}

		[Token(Token = "0x40006FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The array of Bodies")]
		public Body[] bodies;

		[Token(Token = "0x40006FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The array of OffsetLimits")]
		public OffsetLimits[] limits;

		[Token(Token = "0x6000736")]
		[Address(RVA = "0x105A7A4", Offset = "0x105A7A4", VA = "0x105A7A4")]
		public void ResetBodies()
		{
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0x105A8EC", Offset = "0x105A8EC", VA = "0x105A8EC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0x105ACFC", Offset = "0x105ACFC", VA = "0x105ACFC")]
		public Inertia()
		{
		}
	}
	[Token(Token = "0x20000D9")]
	public class LookAtController : MonoBehaviour
	{
		[Token(Token = "0x400070B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LookAtIK ik;

		[Token(Token = "0x400070C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The target to look at. Do not use the Target transform that is assigned to LookAtIK. Set to null if you wish to stop looking.")]
		[Header("Target Smoothing")]
		public Transform target;

		[Token(Token = "0x400070D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x400070E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector3 offset;

		[Token(Token = "0x400070F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The time it takes to switch targets.")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000710")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The time it takes to blend in/out of LookAtIK weight.")]
		public float weightSmoothTime;

		[Token(Token = "0x4000711")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Header("Turning Towards The Target")]
		[Tooltip("Enables smooth turning towards the target according to the parameters under this header.")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000712")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Tooltip("Speed of turning towards the target using Vector3.RotateTowards.")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000713")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Speed of moving towards the target using Vector3.RotateTowards.")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000714")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Tooltip("Speed of slerping towards the target.")]
		public float slerpSpeed;

		[Token(Token = "0x4000715")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("The position of the pivot that the look at target is rotated around relative to the root of the character.")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000716")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Minimum distance of looking from the first bone. Keeps the solver from failing if the target is too close.")]
		public float minDistance;

		[Token(Token = "0x4000717")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Character root will be rotate around the Y axis to keep root forward within this angle from the look direction.")]
		[Header("RootRotation")]
		[Range(0f, 180f)]
		public float maxRootAngle;

		[Token(Token = "0x4000718")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Transform lastTarget;

		[Token(Token = "0x4000719")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float switchWeight;

		[Token(Token = "0x400071A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float switchWeightV;

		[Token(Token = "0x400071B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float weightV;

		[Token(Token = "0x400071C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private Vector3 lastPosition;

		[Token(Token = "0x400071D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 dir;

		[Token(Token = "0x400071E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x1700011E")]
		private Vector3 pivot
		{
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x105ADA8", Offset = "0x105ADA8", VA = "0x105ADA8")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0x105AD40", Offset = "0x105AD40", VA = "0x105AD40")]
		private void Start()
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0x105AE2C", Offset = "0x105AE2C", VA = "0x105AE2C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000740")]
		[Address(RVA = "0x105B334", Offset = "0x105B334", VA = "0x105B334")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0x105B4B8", Offset = "0x105B4B8", VA = "0x105B4B8")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000742")]
		[Address(RVA = "0x105B704", Offset = "0x105B704", VA = "0x105B704")]
		public LookAtController()
		{
		}
	}
	[Token(Token = "0x20000DA")]
	public abstract class OffsetModifier : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000DB")]
		public class OffsetLimits
		{
			[Token(Token = "0x4000722")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The effector type (this is just an enum)")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000723")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Spring force, if zero then this is a hard limit, if not, offset can exceed the limit.")]
			public float spring;

			[Token(Token = "0x4000724")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool x;

			[Token(Token = "0x4000725")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool y;

			[Token(Token = "0x4000726")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
			[Tooltip("Which axes to limit the offset on?")]
			public bool z;

			[Token(Token = "0x4000727")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Tooltip("The limits")]
			public float minX;

			[Token(Token = "0x4000728")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("The limits")]
			public float maxX;

			[Token(Token = "0x4000729")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			[Tooltip("The limits")]
			public float minY;

			[Token(Token = "0x400072A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("The limits")]
			public float maxY;

			[Token(Token = "0x400072B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("The limits")]
			public float minZ;

			[Token(Token = "0x400072C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The limits")]
			public float maxZ;

			[Token(Token = "0x600074B")]
			[Address(RVA = "0x105B92C", Offset = "0x105B92C", VA = "0x105B92C")]
			public void Apply(IKEffector e, Quaternion rootRotation)
			{
			}

			[Token(Token = "0x600074C")]
			[Address(RVA = "0x105BBBC", Offset = "0x105BBBC", VA = "0x105BBBC")]
			private float SpringAxis(float value, float min, float max)
			{
				return default(float);
			}

			[Token(Token = "0x600074D")]
			[Address(RVA = "0x105BC2C", Offset = "0x105BC2C", VA = "0x105BC2C")]
			private float Spring(float value, float limit, bool negative)
			{
				return default(float);
			}

			[Token(Token = "0x600074E")]
			[Address(RVA = "0x105BC74", Offset = "0x105BC74", VA = "0x105BC74")]
			public OffsetLimits()
			{
			}
		}

		[Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private sealed class <Initiate>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400072D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400072E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400072F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifier <>4__this;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000752")]
				[Address(RVA = "0x105BDF0", Offset = "0x105BDF0", VA = "0x105BDF0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000754")]
				[Address(RVA = "0x105BE38", Offset = "0x105BE38", VA = "0x105BE38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600074F")]
			[Address(RVA = "0x105B830", Offset = "0x105B830", VA = "0x105B830")]
			[DebuggerHidden]
			public <Initiate>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000750")]
			[Address(RVA = "0x105BC7C", Offset = "0x105BC7C", VA = "0x105BC7C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000751")]
			[Address(RVA = "0x105BC80", Offset = "0x105BC80", VA = "0x105BC80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000753")]
			[Address(RVA = "0x105BDF8", Offset = "0x105BDF8", VA = "0x105BDF8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the FBBIK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected float lastTime;

		[Token(Token = "0x1700011F")]
		protected float deltaTime
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x105A990", Offset = "0x105A990", VA = "0x105A990")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000744")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x105B79C", Offset = "0x105B79C", VA = "0x105B79C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x105B7BC", Offset = "0x105B7BC", VA = "0x105B7BC")]
		[IteratorStateMachine(typeof(<Initiate>d__8))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x105B858", Offset = "0x105B858", VA = "0x105B858")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x105AC54", Offset = "0x105AC54", VA = "0x105AC54")]
		protected void ApplyLimits(OffsetLimits[] limits)
		{
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x105BA90", Offset = "0x105BA90", VA = "0x105BA90", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x105AD0C", Offset = "0x105AD0C", VA = "0x105AD0C")]
		protected OffsetModifier()
		{
		}
	}
	[Token(Token = "0x20000DD")]
	public abstract class OffsetModifierVRIK : MonoBehaviour
	{
		[Token(Token = "0x20000DE")]
		[CompilerGenerated]
		private sealed class <Initiate>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000733")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000734")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000735")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public OffsetModifierVRIK <>4__this;

			[Token(Token = "0x17000123")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600075F")]
				[Address(RVA = "0x105C290", Offset = "0x105C290", VA = "0x105C290", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000124")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000761")]
				[Address(RVA = "0x105C2D8", Offset = "0x105C2D8", VA = "0x105C2D8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600075C")]
			[Address(RVA = "0x105BEF4", Offset = "0x105BEF4", VA = "0x105BEF4")]
			[DebuggerHidden]
			public <Initiate>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600075D")]
			[Address(RVA = "0x105C11C", Offset = "0x105C11C", VA = "0x105C11C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600075E")]
			[Address(RVA = "0x105C120", Offset = "0x105C120", VA = "0x105C120", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000760")]
			[Address(RVA = "0x105C298", Offset = "0x105C298", VA = "0x105C298", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the VRIK component")]
		public VRIK ik;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float lastTime;

		[Token(Token = "0x17000122")]
		protected float deltaTime
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x105BE40", Offset = "0x105BE40", VA = "0x105BE40")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x6000756")]
		protected abstract void OnModifyOffset();

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x105BE60", Offset = "0x105BE60", VA = "0x105BE60", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x105BE80", Offset = "0x105BE80", VA = "0x105BE80")]
		[IteratorStateMachine(typeof(<Initiate>d__7))]
		private IEnumerator Initiate()
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x105BF1C", Offset = "0x105BF1C", VA = "0x105BF1C")]
		private void ModifyOffset()
		{
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x105BFF0", Offset = "0x105BFF0", VA = "0x105BFF0", Slot = "6")]
		protected virtual void OnDestroy()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1059D78", Offset = "0x1059D78", VA = "0x1059D78")]
		protected OffsetModifierVRIK()
		{
		}
	}
	[Token(Token = "0x20000DF")]
	public class OffsetPose : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000E0")]
		public class EffectorLink
		{
			[Token(Token = "0x4000737")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000738")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 offset;

			[Token(Token = "0x4000739")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 pin;

			[Token(Token = "0x400073A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 pinWeight;

			[Token(Token = "0x6000765")]
			[Address(RVA = "0x105C394", Offset = "0x105C394", VA = "0x105C394")]
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
			{
			}

			[Token(Token = "0x6000766")]
			[Address(RVA = "0x105C6EC", Offset = "0x105C6EC", VA = "0x105C6EC")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x105C2E0", Offset = "0x105C2E0", VA = "0x105C2E0")]
		public void Apply(IKSolverFullBodyBiped solver, float weight)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x105C5E4", Offset = "0x105C5E4", VA = "0x105C5E4")]
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation)
		{
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x105C688", Offset = "0x105C688", VA = "0x105C688")]
		public OffsetPose()
		{
		}
	}
	[Token(Token = "0x20000E1")]
	public class PenetrationAvoidance : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E2")]
		public class Avoider
		{
			[Serializable]
			[Token(Token = "0x20000E3")]
			public class EffectorLink
			{
				[Token(Token = "0x4000746")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Effector to apply the offset to.")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000747")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Multiplier of the offset value, can be negative.")]
				public float weight;

				[Token(Token = "0x600076D")]
				[Address(RVA = "0x105CD40", Offset = "0x105CD40", VA = "0x105CD40")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400073C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Bones to start the raycast from. Multiple raycasts can be used by assigning more than 1 bone.")]
			public Transform[] raycastFrom;

			[Token(Token = "0x400073D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("The Transform to raycast towards. Usually the body part that you want to keep from penetrating.")]
			public Transform raycastTo;

			[Token(Token = "0x400073E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("If 0, will use simple raycasting, if > 0, will use sphere casting (better, but slower).")]
			[Range(0f, 1f)]
			public float raycastRadius;

			[Token(Token = "0x400073F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this to FBBIK effectors.")]
			public EffectorLink[] effectors;

			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			[Tooltip("The time of smooth interpolation of the offset value to avoid penetration.")]
			public float smoothTimeIn;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			[Tooltip("The time of smooth interpolation of the offset value blending out of penetration avoidance.")]
			public float smoothTimeOut;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Layers to keep penetrating from.")]
			public LayerMask layers;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 offset;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 offsetTarget;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 offsetV;

			[Token(Token = "0x6000769")]
			[Address(RVA = "0x105C764", Offset = "0x105C764", VA = "0x105C764")]
			public void Solve(IKSolverFullBodyBiped solver, float weight)
			{
			}

			[Token(Token = "0x600076A")]
			[Address(RVA = "0x105C904", Offset = "0x105C904", VA = "0x105C904")]
			private Vector3 GetOffsetTarget(IKSolverFullBodyBiped solver)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600076B")]
			[Address(RVA = "0x105CA0C", Offset = "0x105CA0C", VA = "0x105CA0C")]
			private Vector3 Raycast(Vector3 from, Vector3 to)
			{
				return default(Vector3);
			}

			[Token(Token = "0x600076C")]
			[Address(RVA = "0x105CD2C", Offset = "0x105CD2C", VA = "0x105CD2C")]
			public Avoider()
			{
			}
		}

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Definitions of penetration avoidances.")]
		public Avoider[] avoiders;

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x105C6F4", Offset = "0x105C6F4", VA = "0x105C6F4", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x105C8F4", Offset = "0x105C8F4", VA = "0x105C8F4")]
		public PenetrationAvoidance()
		{
		}
	}
	[Token(Token = "0x20000E4")]
	public class Recoil : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000E5")]
		public class RecoilOffset
		{
			[Serializable]
			[Token(Token = "0x20000E6")]
			public class EffectorLink
			{
				[Token(Token = "0x4000765")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				[Tooltip("Type of the FBBIK effector to use")]
				public FullBodyBipedEffector effector;

				[Token(Token = "0x4000766")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				[Tooltip("Weight of using this effector")]
				public float weight;

				[Token(Token = "0x600077D")]
				[Address(RVA = "0x105E0EC", Offset = "0x105E0EC", VA = "0x105E0EC")]
				public EffectorLink()
				{
				}
			}

			[Token(Token = "0x400075F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Offset vector for the associated effector when doing recoil.")]
			public Vector3 offset;

			[Token(Token = "0x4000760")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("When firing before the last recoil has faded, how much of the current recoil offset will be maintained?")]
			public float additivity;

			[Token(Token = "0x4000761")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Max additive recoil for automatic fire.")]
			public float maxAdditiveOffsetMag;

			[Token(Token = "0x4000762")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Linking this recoil offset to FBBIK effectors.")]
			public EffectorLink[] effectorLinks;

			[Token(Token = "0x4000763")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 additiveOffset;

			[Token(Token = "0x4000764")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 lastOffset;

			[Token(Token = "0x600077A")]
			[Address(RVA = "0x105CEE4", Offset = "0x105CEE4", VA = "0x105CEE4")]
			public void Start()
			{
			}

			[Token(Token = "0x600077B")]
			[Address(RVA = "0x105DA64", Offset = "0x105DA64", VA = "0x105DA64")]
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft)
			{
			}

			[Token(Token = "0x600077C")]
			[Address(RVA = "0x105E0D8", Offset = "0x105E0D8", VA = "0x105E0D8")]
			public RecoilOffset()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000E7")]
		public enum Handedness
		{
			[Token(Token = "0x4000768")]
			Right,
			[Token(Token = "0x4000769")]
			Left
		}

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the AimIK component. Optional, only used to getting the aiming direction.")]
		public AimIK aimIK;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Set this true if you are using IKExecutionOrder.cs or a custom script to force AimIK solve after FBBIK.")]
		public bool aimIKSolvedLast;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Which hand is holding the weapon?")]
		public Handedness handedness;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Check for 2-handed weapons.")]
		public bool twoHanded;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Weight curve for the recoil offsets. Recoil procedure is as long as this curve.")]
		public AnimationCurve recoilWeight;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("How much is the magnitude randomized each time Recoil is called?")]
		public float magnitudeRandom;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[Tooltip("How much is the rotation randomized each time Recoil is called?")]
		public Vector3 rotationRandom;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Rotating the primary hand bone for the recoil (in local space).")]
		public Vector3 handRotationOffset;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Tooltip("Time of blending in another recoil when doing automatic fire.")]
		public float blendTime;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Tooltip("FBBIK effector position offsets for the recoil (in aiming direction space).")]
		[Space(10f)]
		public RecoilOffset[] offsets;

		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[HideInInspector]
		public Quaternion rotationOffset;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float magnitudeMlp;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float endTime;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Quaternion handRotation;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Quaternion secondaryHandRelativeRotation;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private Quaternion randomRotation;

		[Token(Token = "0x4000758")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private float length;

		[Token(Token = "0x4000759")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private bool initiated;

		[Token(Token = "0x400075A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private float blendWeight;

		[Token(Token = "0x400075B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		private float w;

		[Token(Token = "0x400075C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Quaternion primaryHandRotation;

		[Token(Token = "0x400075D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool handRotationsSet;

		[Token(Token = "0x400075E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		private Vector3 aimIKAxis;

		[Token(Token = "0x17000125")]
		public bool isFinished
		{
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x105CD48", Offset = "0x105CD48", VA = "0x105CD48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000126")]
		private IKEffector primaryHandEffector
		{
			[Token(Token = "0x6000774")]
			[Address(RVA = "0x105DC68", Offset = "0x105DC68", VA = "0x105DC68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000127")]
		private IKEffector secondaryHandEffector
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x105DCA4", Offset = "0x105DCA4", VA = "0x105DCA4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private Transform primaryHand
		{
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x105DC30", Offset = "0x105DC30", VA = "0x105DC30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000129")]
		private Transform secondaryHand
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x105DC4C", Offset = "0x105DC4C", VA = "0x105DC4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x105CD6C", Offset = "0x105CD6C", VA = "0x105CD6C")]
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation)
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x105CD98", Offset = "0x105CD98", VA = "0x105CD98")]
		public void Fire(float magnitude)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x105CFB8", Offset = "0x105CFB8", VA = "0x105CFB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x105DCE0", Offset = "0x105DCE0", VA = "0x105DCE0")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x105DDF8", Offset = "0x105DDF8", VA = "0x105DDF8")]
		private void AfterAimIK()
		{
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x105DE48", Offset = "0x105DE48", VA = "0x105DE48", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x105E04C", Offset = "0x105E04C", VA = "0x105E04C")]
		public Recoil()
		{
		}
	}
	[Token(Token = "0x20000E8")]
	public class ShoulderRotator : MonoBehaviour
	{
		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Weight of shoulder rotation")]
		public float weight;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("The greater the offset, the sooner the shoulder will start rotating")]
		public float offset;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool skip;

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x105E0F4", Offset = "0x105E0F4", VA = "0x105E0F4")]
		private void Start()
		{
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x105E208", Offset = "0x105E208", VA = "0x105E208")]
		private void RotateShoulders()
		{
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x105E2E4", Offset = "0x105E2E4", VA = "0x105E2E4")]
		private void RotateShoulder(FullBodyBipedChain chain, float weight, float offset)
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x105E6E8", Offset = "0x105E6E8", VA = "0x105E6E8")]
		private IKMapping.BoneMap GetParentBoneMap(FullBodyBipedChain chain)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x105E71C", Offset = "0x105E71C", VA = "0x105E71C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x105E848", Offset = "0x105E848", VA = "0x105E848")]
		public ShoulderRotator()
		{
		}
	}
	[Token(Token = "0x20000E9")]
	public static class VRIKCalibrator
	{
		[Serializable]
		[Token(Token = "0x20000EA")]
		public class Settings
		{
			[Token(Token = "0x400076E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Multiplies character scale")]
			public float scaleMlp;

			[Token(Token = "0x400076F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("Local axis of the HMD facing forward.")]
			public Vector3 headTrackerForward;

			[Token(Token = "0x4000770")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("Local axis of the HMD facing up.")]
			public Vector3 headTrackerUp;

			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			[Tooltip("Local axis of the hand trackers pointing from the wrist towards the palm.")]
			public Vector3 handTrackerForward;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			[Tooltip("Local axis of the hand trackers pointing in the direction of the surface normal of the back of the hand.")]
			public Vector3 handTrackerUp;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			[Tooltip("Local axis of the foot trackers towards the player's forward direction.")]
			public Vector3 footTrackerForward;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			[Tooltip("Local axis of the foot tracker towards the up direction.")]
			public Vector3 footTrackerUp;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			[Tooltip("Offset of the head bone from the HMD in (headTrackerForward, headTrackerUp) space relative to the head tracker.")]
			[Space(10f)]
			public Vector3 headOffset;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			[Tooltip("Offset of the hand bones from the hand trackers in (handTrackerForward, handTrackerUp) space relative to the hand trackers.")]
			public Vector3 handOffset;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
			[Tooltip("Forward offset of the foot bones from the foot trackers.")]
			public float footForwardOffset;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Tooltip("Inward offset of the foot bones from the foot trackers.")]
			public float footInwardOffset;

			[Token(Token = "0x4000779")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
			[Tooltip("Used for adjusting foot heading relative to the foot trackers.")]
			[Range(-180f, 180f)]
			public float footHeadingOffset;

			[Token(Token = "0x400077A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			[Range(0f, 1f)]
			public float pelvisPositionWeight;

			[Token(Token = "0x400077B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			[Range(0f, 1f)]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1062A20", Offset = "0x1062A20", VA = "0x1062A20")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000EB")]
		public class CalibrationData
		{
			[Serializable]
			[Token(Token = "0x20000EC")]
			public class Target
			{
				[Token(Token = "0x4000788")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool used;

				[Token(Token = "0x4000789")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public Vector3 localPosition;

				[Token(Token = "0x400078A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Quaternion localRotation;

				[Token(Token = "0x6000795")]
				[Address(RVA = "0x106059C", Offset = "0x106059C", VA = "0x106059C")]
				public Target(Transform t)
				{
				}

				[Token(Token = "0x6000796")]
				[Address(RVA = "0x1060FFC", Offset = "0x1060FFC", VA = "0x1060FFC")]
				public void SetTo(Transform t)
				{
				}
			}

			[Token(Token = "0x400077C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float scale;

			[Token(Token = "0x400077D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Target head;

			[Token(Token = "0x400077E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Target leftHand;

			[Token(Token = "0x400077F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Target rightHand;

			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Target pelvis;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Target leftFoot;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Target rightFoot;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Target leftLegGoal;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Target rightLegGoal;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public Vector3 pelvisTargetRight;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			public float pelvisPositionWeight;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public float pelvisRotationWeight;

			[Token(Token = "0x6000794")]
			[Address(RVA = "0x105FCA0", Offset = "0x105FCA0", VA = "0x105FCA0")]
			public CalibrationData()
			{
			}
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x105E85C", Offset = "0x105E85C", VA = "0x105E85C")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, Settings settings)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x105E874", Offset = "0x105E874", VA = "0x105E874")]
		public static void RecalibrateScale(VRIK ik, CalibrationData data, float scaleMlp)
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x105E99C", Offset = "0x105E99C", VA = "0x105E99C")]
		private static void CalibrateScale(VRIK ik, Settings settings)
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x105E8BC", Offset = "0x105E8BC", VA = "0x105E8BC")]
		private static void CalibrateScale(VRIK ik, float scaleMlp = 1f)
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x105E9B4", Offset = "0x105E9B4", VA = "0x105E9B4")]
		public static CalibrationData Calibrate(VRIK ik, Settings settings, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x105FCA8", Offset = "0x105FCA8", VA = "0x105FCA8")]
		private static void CalibrateLeg(Settings settings, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1060650", Offset = "0x1060650", VA = "0x1060650")]
		public static void Calibrate(VRIK ik, CalibrationData data, Transform headTracker, [Optional] Transform bodyTracker, [Optional] Transform leftHandTracker, [Optional] Transform rightHandTracker, [Optional] Transform leftFootTracker, [Optional] Transform rightFootTracker)
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1061058", Offset = "0x1061058", VA = "0x1061058")]
		private static void CalibrateLeg(CalibrationData data, Transform tracker, IKSolverVR.Leg leg, Transform lastBone, Vector3 rootForward, bool isLeft)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1061488", Offset = "0x1061488", VA = "0x1061488")]
		public static CalibrationData Calibrate(VRIK ik, Transform centerEyeAnchor, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 centerEyePositionOffset, Vector3 centerEyeRotationOffset, Vector3 handPositionOffset, Vector3 handRotationOffset, float scaleMlp = 1f)
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x10616BC", Offset = "0x10616BC", VA = "0x10616BC")]
		public static void CalibrateHead(VRIK ik, Transform centerEyeAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1061EA0", Offset = "0x1061EA0", VA = "0x1061EA0")]
		public static void CalibrateBody(VRIK ik, Transform pelvisTracker, Vector3 trackerPositionOffset, Vector3 trackerRotationOffset)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1061C50", Offset = "0x1061C50", VA = "0x1061C50")]
		public static void CalibrateHands(VRIK ik, Transform leftHandAnchor, Transform rightHandAnchor, Vector3 anchorPositionOffset, Vector3 anchorRotationOffset)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1062154", Offset = "0x1062154", VA = "0x1062154")]
		private static void CalibrateHand(Transform hand, Transform forearm, Transform target, Transform anchor, Vector3 positionOffset, Vector3 rotationOffset, bool isLeft)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x10625EC", Offset = "0x10625EC", VA = "0x10625EC")]
		public static Vector3 GuessWristToPalmAxis(Transform hand, Transform forearm)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x10626D0", Offset = "0x10626D0", VA = "0x10626D0")]
		public static Vector3 GuessPalmToThumbAxis(Transform hand, Transform forearm, bool forceFlip = false)
		{
			return default(Vector3);
		}
	}
	[Token(Token = "0x20000ED")]
	public class VRIKLODController : MonoBehaviour
	{
		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Renderer LODRenderer;

		[Token(Token = "0x400078C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LODDistance;

		[Token(Token = "0x400078D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool allowCulled;

		[Token(Token = "0x400078E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private VRIK ik;

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1062BB4", Offset = "0x1062BB4", VA = "0x1062BB4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1062C0C", Offset = "0x1062C0C", VA = "0x1062C0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x1062C34", Offset = "0x1062C34", VA = "0x1062C34")]
		private int GetLODLevel()
		{
			return default(int);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1062D54", Offset = "0x1062D54", VA = "0x1062D54")]
		public VRIKLODController()
		{
		}
	}
	[Token(Token = "0x20000EE")]
	public class VRIKRootController : MonoBehaviour
	{
		[Token(Token = "0x4000790")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform pelvisTarget;

		[Token(Token = "0x4000791")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform leftFootTarget;

		[Token(Token = "0x4000792")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform rightFootTarget;

		[Token(Token = "0x4000793")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private VRIK ik;

		[Token(Token = "0x1700012A")]
		public Vector3 pelvisTargetRight
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1062D6C", Offset = "0x1062D6C", VA = "0x1062D6C")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600079C")]
			[Address(RVA = "0x1062D78", Offset = "0x1062D78", VA = "0x1062D78")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x1062D84", Offset = "0x1062D84", VA = "0x1062D84")]
		private void Awake()
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x1060388", Offset = "0x1060388", VA = "0x1060388")]
		public void Calibrate()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x10612E8", Offset = "0x10612E8", VA = "0x10612E8")]
		public void Calibrate(VRIKCalibrator.CalibrationData data)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1062EA0", Offset = "0x1062EA0", VA = "0x1062EA0")]
		private void OnPreUpdate()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1063268", Offset = "0x1063268", VA = "0x1063268")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1063394", Offset = "0x1063394", VA = "0x1063394")]
		public VRIKRootController()
		{
		}
	}
}
namespace RootMotion.Demos
{
	[Token(Token = "0x20000EF")]
	public class FKOffset : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class Offset
		{
			[Token(Token = "0x4000796")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[HideInInspector]
			public string name;

			[Token(Token = "0x4000797")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public HumanBodyBones bone;

			[Token(Token = "0x4000798")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public Vector3 rotationOffset;

			[Token(Token = "0x4000799")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private Transform t;

			[Token(Token = "0x60007A7")]
			[Address(RVA = "0x1063458", Offset = "0x1063458", VA = "0x1063458")]
			public void Apply(Animator animator)
			{
			}

			[Token(Token = "0x60007A8")]
			[Address(RVA = "0x10636D4", Offset = "0x10636D4", VA = "0x10636D4")]
			public Offset()
			{
			}
		}

		[Token(Token = "0x4000794")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Offset[] offsets;

		[Token(Token = "0x4000795")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x106339C", Offset = "0x106339C", VA = "0x106339C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x10633F4", Offset = "0x10633F4", VA = "0x10633F4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x1063608", Offset = "0x1063608", VA = "0x1063608")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x10636CC", Offset = "0x10636CC", VA = "0x10636CC")]
		public FKOffset()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class AimBoxing : MonoBehaviour
	{
		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform pin;

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x10636DC", Offset = "0x10636DC", VA = "0x10636DC")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x106375C", Offset = "0x106375C", VA = "0x106375C")]
		public AimBoxing()
		{
		}
	}
	[Token(Token = "0x20000F2")]
	public class AimSwing : MonoBehaviour
	{
		[Token(Token = "0x400079C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x400079D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The direction of the animated weapon swing in character space. Tweak this value to adjust the aiming.")]
		public Vector3 animatedSwingDirection;

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1063764", Offset = "0x1063764", VA = "0x1063764")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x10637D0", Offset = "0x10637D0", VA = "0x10637D0")]
		public AimSwing()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class SecondHandOnGun : MonoBehaviour
	{
		[Token(Token = "0x400079E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aim;

		[Token(Token = "0x400079F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LimbIK leftArmIK;

		[Token(Token = "0x40007A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform leftHand;

		[Token(Token = "0x40007A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform rightHand;

		[Token(Token = "0x40007A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Vector3 leftHandPositionOffset;

		[Token(Token = "0x40007A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public Vector3 leftHandRotationOffset;

		[Token(Token = "0x40007A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 leftHandPosRelToRight;

		[Token(Token = "0x40007A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion leftHandRotRelToRight;

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1063830", Offset = "0x1063830", VA = "0x1063830")]
		private void Start()
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x1063868", Offset = "0x1063868", VA = "0x1063868")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x1063B24", Offset = "0x1063B24", VA = "0x1063B24")]
		public SecondHandOnGun()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	public class SimpleAimingSystem : MonoBehaviour
	{
		[Token(Token = "0x40007A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("AimPoser is a tool that returns an animation name based on direction.")]
		public AimPoser aimPoser;

		[Token(Token = "0x40007A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Reference to the AimIK component.")]
		public AimIK aim;

		[Token(Token = "0x40007A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Reference to the LookAt component (only used for the head in this instance).")]
		public LookAtIK lookAt;

		[Token(Token = "0x40007A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component.")]
		public Animator animator;

		[Token(Token = "0x40007AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Time of cross-fading from pose to pose.")]
		public float crossfadeTime;

		[Token(Token = "0x40007AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("Will keep the aim target at a distance.")]
		public float minAimDistance;

		[Token(Token = "0x40007AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AimPoser.Pose aimPose;

		[Token(Token = "0x40007AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AimPoser.Pose lastPose;

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1063B2C", Offset = "0x1063B2C", VA = "0x1063B2C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x1063B64", Offset = "0x1063B64", VA = "0x1063B64")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x1063CB0", Offset = "0x1063CB0", VA = "0x1063CB0")]
		private void Pose()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1063E3C", Offset = "0x1063E3C", VA = "0x1063E3C")]
		private void LimitAimTarget()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1064020", Offset = "0x1064020", VA = "0x1064020")]
		private void DirectCrossFade(string state, float target)
		{
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x10640B0", Offset = "0x10640B0", VA = "0x10640B0")]
		public SimpleAimingSystem()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class TerrainOffset : MonoBehaviour
	{
		[Token(Token = "0x40007AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AimIK aimIK;

		[Token(Token = "0x40007AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 raycastOffset;

		[Token(Token = "0x40007B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40007B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float min;

		[Token(Token = "0x40007B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float max;

		[Token(Token = "0x40007B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float lerpSpeed;

		[Token(Token = "0x40007B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private RaycastHit hit;

		[Token(Token = "0x40007B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 offset;

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x10640C4", Offset = "0x10640C4", VA = "0x10640C4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x1064230", Offset = "0x1064230", VA = "0x1064230")]
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x106442C", Offset = "0x106442C", VA = "0x106442C")]
		public TerrainOffset()
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class BipedIKvsAnimatorIK : MonoBehaviour
	{
		[Token(Token = "0x40007B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[LargeHeader("References")]
		public Animator animator;

		[Token(Token = "0x40007B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BipedIK bipedIK;

		[Token(Token = "0x40007B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[LargeHeader("Look At")]
		public Transform lookAtTargetBiped;

		[Token(Token = "0x40007B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform lookAtTargetAnimator;

		[Token(Token = "0x40007BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Range(0f, 1f)]
		public float lookAtWeight;

		[Token(Token = "0x40007BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Range(0f, 1f)]
		public float lookAtBodyWeight;

		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float lookAtHeadWeight;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float lookAtEyesWeight;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float lookAtClampWeight;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float lookAtClampWeightHead;

		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float lookAtClampWeightEyes;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[LargeHeader("Foot")]
		public Transform footTargetBiped;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform footTargetAnimator;

		[Token(Token = "0x40007C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Range(0f, 1f)]
		public float footPositionWeight;

		[Token(Token = "0x40007C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[Range(0f, 1f)]
		public float footRotationWeight;

		[Token(Token = "0x40007C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[LargeHeader("Hand")]
		public Transform handTargetBiped;

		[Token(Token = "0x40007C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform handTargetAnimator;

		[Token(Token = "0x40007C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(0f, 1f)]
		public float handPositionWeight;

		[Token(Token = "0x40007C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		[Range(0f, 1f)]
		public float handRotationWeight;

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x106445C", Offset = "0x106445C", VA = "0x106445C")]
		private void OnAnimatorIK(int layer)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x1064888", Offset = "0x1064888", VA = "0x1064888")]
		public BipedIKvsAnimatorIK()
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class MechSpider : MonoBehaviour
	{
		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask raycastLayers;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float scale;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform body;

		[Token(Token = "0x40007CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MechSpiderLeg[] legs;

		[Token(Token = "0x40007CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float legRotationWeight;

		[Token(Token = "0x40007CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rootPositionSpeed;

		[Token(Token = "0x40007CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float rootRotationSpeed;

		[Token(Token = "0x40007D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float breatheSpeed;

		[Token(Token = "0x40007D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float breatheMagnitude;

		[Token(Token = "0x40007D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float height;

		[Token(Token = "0x40007D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float minHeight;

		[Token(Token = "0x40007D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public float raycastHeight;

		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float raycastDistance;

		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 lastPosition;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 defaultBodyLocalPosition;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float sine;

		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private RaycastHit rootHit;

		[Token(Token = "0x1700012B")]
		public Vector3 velocity
		{
			[Token(Token = "0x60007BB")]
			[Address(RVA = "0x10648A8", Offset = "0x10648A8", VA = "0x10648A8")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x10648B4", Offset = "0x10648B4", VA = "0x10648B4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x10648C0", Offset = "0x10648C0", VA = "0x10648C0")]
		private void Start()
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x10648F0", Offset = "0x10648F0", VA = "0x10648F0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1065274", Offset = "0x1065274", VA = "0x1065274")]
		private Vector3 GetLegCentroid()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x1064FF0", Offset = "0x1064FF0", VA = "0x1064FF0")]
		private Vector3 GetLegsPlaneNormal()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1065384", Offset = "0x1065384", VA = "0x1065384")]
		public MechSpider()
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class MechSpiderController : MonoBehaviour
	{
		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform cameraTransform;

		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float speed;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float turnSpeed;

		[Token(Token = "0x1700012C")]
		public Vector3 inputVector
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x10653B0", Offset = "0x10653B0", VA = "0x10653B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1065430", Offset = "0x1065430", VA = "0x1065430")]
		private void Update()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1065774", Offset = "0x1065774", VA = "0x1065774")]
		public MechSpiderController()
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20000FA")]
		[CompilerGenerated]
		private sealed class <Step>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40007F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40007F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40007F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MechSpiderLeg <>4__this;

			[Token(Token = "0x40007F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x40007F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x1700012F")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60007D3")]
				[Address(RVA = "0x10667CC", Offset = "0x10667CC", VA = "0x10667CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000130")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60007D5")]
				[Address(RVA = "0x1066814", Offset = "0x1066814", VA = "0x1066814", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60007D0")]
			[Address(RVA = "0x1066464", Offset = "0x1066464", VA = "0x1066464")]
			[DebuggerHidden]
			public <Step>d__33(int <>1__state)
			{
			}

			[Token(Token = "0x60007D1")]
			[Address(RVA = "0x106651C", Offset = "0x106651C", VA = "0x106651C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60007D2")]
			[Address(RVA = "0x1066520", Offset = "0x1066520", VA = "0x1066520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60007D4")]
			[Address(RVA = "0x10667D4", Offset = "0x10667D4", VA = "0x10667D4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x40007EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x40007EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x40007EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x40007ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x40007EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x40007EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x40007F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40007F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x40007F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x40007F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x40007F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x1700012D")]
		public bool isStepping
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x1065788", Offset = "0x1065788", VA = "0x1065788")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700012E")]
		public Vector3 position
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1065354", Offset = "0x1065354", VA = "0x1065354")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x106579C", Offset = "0x106579C", VA = "0x106579C")]
			set
			{
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x10657E8", Offset = "0x10657E8", VA = "0x10657E8")]
		private void Awake()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1065A68", Offset = "0x1065A68", VA = "0x1065A68")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1065C40", Offset = "0x1065C40", VA = "0x1065C40")]
		private void Start()
		{
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x1065E64", Offset = "0x1065E64", VA = "0x1065E64")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x10660C4", Offset = "0x10660C4", VA = "0x10660C4")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x106622C", Offset = "0x106622C", VA = "0x106622C")]
		private void Update()
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x1065DB4", Offset = "0x1065DB4", VA = "0x1065DB4")]
		[IteratorStateMachine(typeof(<Step>d__33))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x106648C", Offset = "0x106648C", VA = "0x106648C")]
		public MechSpiderLeg()
		{
		}
	}
	[Token(Token = "0x20000FB")]
	public class MechSpiderParticles : MonoBehaviour
	{
		[Token(Token = "0x40007FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MechSpiderController mechSpiderController;

		[Token(Token = "0x40007FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem particles;

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x106681C", Offset = "0x106681C", VA = "0x106681C")]
		private void Start()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x10668F8", Offset = "0x10668F8", VA = "0x10668F8")]
		private void Update()
		{
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x1066B6C", Offset = "0x1066B6C", VA = "0x1066B6C")]
		public MechSpiderParticles()
		{
		}
	}
	[Token(Token = "0x20000FC")]
	public class AnimationWarping : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x20000FD")]
		public struct Warp
		{
			[Token(Token = "0x4000800")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[Tooltip("Layer of the 'Animation State' in the Animator.")]
			public int animationLayer;

			[Token(Token = "0x4000801")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[Tooltip("Name of the state in the Animator to warp.")]
			public string animationState;

			[Token(Token = "0x4000802")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("Warping weight by normalized time of the animation state.")]
			public AnimationCurve weightCurve;

			[Token(Token = "0x4000803")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[Tooltip("Animated point to warp from. This should be in character space so keep this Transform parented to the root of the character.")]
			public Transform warpFrom;

			[Token(Token = "0x4000804")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			[Tooltip("World space point to warp to.")]
			public Transform warpTo;

			[Token(Token = "0x4000805")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			[Tooltip("Which FBBIK effector to use?")]
			public FullBodyBipedEffector effector;
		}

		[Serializable]
		[Token(Token = "0x20000FE")]
		public enum EffectorMode
		{
			[Token(Token = "0x4000807")]
			PositionOffset,
			[Token(Token = "0x4000808")]
			Position
		}

		[Token(Token = "0x40007FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Reference to the Animator component to use")]
		public Animator animator;

		[Token(Token = "0x40007FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Using effector.positionOffset or effector.position with effector.positionWeight? The former will enable you to use effector.position for other things, the latter will weigh in the effectors, hence using Reach and Pull in the process.")]
		public EffectorMode effectorMode;

		[Token(Token = "0x40007FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Space(10f)]
		[Tooltip("The array of warps, can have multiple simultaneous warps.")]
		public Warp[] warps;

		[Token(Token = "0x40007FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private EffectorMode lastMode;

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x1066B74", Offset = "0x1066B74", VA = "0x1066B74", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x1066BA0", Offset = "0x1066BA0", VA = "0x1066BA0")]
		public float GetWarpWeight(int warpIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x1066DB8", Offset = "0x1066DB8", VA = "0x1066DB8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1067070", Offset = "0x1067070", VA = "0x1067070")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x1067104", Offset = "0x1067104", VA = "0x1067104")]
		public AnimationWarping()
		{
		}
	}
	[Token(Token = "0x20000FF")]
	public class AnimatorController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x4000809")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float rotateSpeed;

		[Token(Token = "0x400080A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float blendSpeed;

		[Token(Token = "0x400080B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float maxAngle;

		[Token(Token = "0x400080C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float moveSpeed;

		[Token(Token = "0x400080D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float rootMotionWeight;

		[Token(Token = "0x400080E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Animator animator;

		[Token(Token = "0x400080F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected Vector3 moveBlend;

		[Token(Token = "0x4000810")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		protected Vector3 moveInput;

		[Token(Token = "0x4000811")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected Vector3 velocity;

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1067114", Offset = "0x1067114", VA = "0x1067114", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x106716C", Offset = "0x106716C", VA = "0x106716C")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x1067374", Offset = "0x1067374", VA = "0x1067374", Slot = "5")]
		public virtual void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x106759C", Offset = "0x106759C", VA = "0x106759C")]
		public AnimatorController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000100")]
	public class AnimatorController3rdPersonIK : AnimatorController3rdPerson
	{
		[Token(Token = "0x4000812")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float headLookWeight;

		[Token(Token = "0x4000813")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 gunHoldOffset;

		[Token(Token = "0x4000814")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000815")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Recoil recoil;

		[Token(Token = "0x4000816")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private AimIK aim;

		[Token(Token = "0x4000817")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x4000818")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private Vector3 headLookAxis;

		[Token(Token = "0x4000819")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private Vector3 leftHandPosRelToRightHand;

		[Token(Token = "0x400081A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Quaternion leftHandRotRelToRightHand;

		[Token(Token = "0x400081B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private Vector3 aimTarget;

		[Token(Token = "0x400081C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x10675B0", Offset = "0x10675B0", VA = "0x10675B0", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x1067784", Offset = "0x1067784", VA = "0x1067784", Slot = "5")]
		public override void Move(Vector3 moveInput, bool isMoving, Vector3 faceDirection, Vector3 aimTarget)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x10677F4", Offset = "0x10677F4", VA = "0x10677F4")]
		private void Read()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x106792C", Offset = "0x106792C", VA = "0x106792C")]
		private void AimIK()
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0x1067988", Offset = "0x1067988", VA = "0x1067988")]
		private void FBBIK()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1067FF0", Offset = "0x1067FF0", VA = "0x1067FF0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x1067E04", Offset = "0x1067E04", VA = "0x1067E04")]
		private void HeadLookAt(Vector3 lookAtTarget)
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1068294", Offset = "0x1068294", VA = "0x1068294")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x10683C0", Offset = "0x10683C0", VA = "0x10683C0")]
		public AnimatorController3rdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class CharacterAnimationThirdPersonIK : CharacterAnimationThirdPerson
	{
		[Token(Token = "0x400081D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x10683DC", Offset = "0x10683DC", VA = "0x10683DC", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x1068440", Offset = "0x1068440", VA = "0x1068440", Slot = "7")]
		protected override void LateUpdate()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x106877C", Offset = "0x106877C", VA = "0x106877C")]
		private void RotateEffector(IKEffector effector, Quaternion rotation, float mlp)
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x106886C", Offset = "0x106886C", VA = "0x106886C")]
		public CharacterAnimationThirdPersonIK()
		{
		}
	}
	[Token(Token = "0x2000102")]
	public class CharacterController3rdPerson : MonoBehaviour
	{
		[Token(Token = "0x400081E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public CameraController cam;

		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private AnimatorController3rdPerson animatorController;

		[Token(Token = "0x17000131")]
		private static Vector3 inputVector
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x1068AD4", Offset = "0x1068AD4", VA = "0x1068AD4")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x17000132")]
		private static Vector3 inputVectorRaw
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x1068B54", Offset = "0x1068B54", VA = "0x1068B54")]
			get
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x1068874", Offset = "0x1068874", VA = "0x1068874")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x10688E4", Offset = "0x10688E4", VA = "0x10688E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x1068BD4", Offset = "0x1068BD4", VA = "0x1068BD4")]
		public CharacterController3rdPerson()
		{
		}
	}
	[Token(Token = "0x2000103")]
	public class EffectorOffset : OffsetModifier
	{
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float handsMaintainRelativePositionWeight;

		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 bodyOffset;

		[Token(Token = "0x4000822")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 leftShoulderOffset;

		[Token(Token = "0x4000823")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector3 rightShoulderOffset;

		[Token(Token = "0x4000824")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Vector3 leftThighOffset;

		[Token(Token = "0x4000825")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Vector3 rightThighOffset;

		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public Vector3 leftHandOffset;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Vector3 rightHandOffset;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public Vector3 leftFootOffset;

		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public Vector3 rightFootOffset;

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x1068BDC", Offset = "0x1068BDC", VA = "0x1068BDC", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x1069038", Offset = "0x1069038", VA = "0x1069038")]
		public EffectorOffset()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public class ExplosionDemo : MonoBehaviour
	{
		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SimpleLocomotion character;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float forceMlp;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float upForce;

		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weightFalloffSpeed;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AnimationCurve weightFalloff;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve explosionForceByDistance;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public AnimationCurve scale;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float weight;

		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 defaultScale;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Rigidbody r;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x1069048", Offset = "0x1069048", VA = "0x1069048")]
		private void Start()
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x1069100", Offset = "0x1069100", VA = "0x1069100")]
		private void Update()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x106955C", Offset = "0x106955C", VA = "0x106955C")]
		private void SetEffectorWeights(float w)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x10695FC", Offset = "0x10695FC", VA = "0x10695FC")]
		public ExplosionDemo()
		{
		}
	}
	[Token(Token = "0x2000105")]
	public class FBBIKSettings : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000106")]
		public class Limb
		{
			[Token(Token = "0x400083D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FBIKChain.Smoothing reachSmoothing;

			[Token(Token = "0x400083E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float maintainRelativePositionWeight;

			[Token(Token = "0x400083F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float mappingWeight;

			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x1069790", Offset = "0x1069790", VA = "0x1069790")]
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver)
			{
			}

			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x10698B4", Offset = "0x10698B4", VA = "0x10698B4")]
			public Limb()
			{
			}
		}

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool disableAfterStart;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Limb leftArm;

		[Token(Token = "0x4000838")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Limb rightArm;

		[Token(Token = "0x4000839")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Limb leftLeg;

		[Token(Token = "0x400083A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Limb rightLeg;

		[Token(Token = "0x400083B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float rootPin;

		[Token(Token = "0x400083C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public bool bodyEffectChildNodes;

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x106966C", Offset = "0x106966C", VA = "0x106966C")]
		public void UpdateSettings()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x1069808", Offset = "0x1069808", VA = "0x1069808")]
		private void Start()
		{
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x10698A0", Offset = "0x10698A0", VA = "0x10698A0")]
		private void Update()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x10698A4", Offset = "0x10698A4", VA = "0x10698A4")]
		public FBBIKSettings()
		{
		}
	}
	[Token(Token = "0x2000107")]
	public class FBIKBendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedChain chain;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float weight;

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x10698C4", Offset = "0x10698C4", VA = "0x10698C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x106992C", Offset = "0x106992C", VA = "0x106992C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x1069A00", Offset = "0x1069A00", VA = "0x1069A00")]
		public FBIKBendGoal()
		{
		}
	}
	[Token(Token = "0x2000108")]
	public class FBIKBoxing : MonoBehaviour
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The target we want to hit")]
		public Transform target;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The pin Transform is used to reference the exact hit point in the animation (used by AimIK to aim the upper body to follow the target).In Legacy and Generic modes you can just create and position a reference point in your animating software and include it in the FBX. Then in Unity if you added a GameObject with the exact same name under the character's root, it would be animated to the required position.In Humanoid mode however, Mecanim loses track of any Transform that does not belong to the avatar, so in this case the pin point has to be manually set inside the Unity Editor.")]
		public Transform pin;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The Full Body Biped IK component")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("The Aim IK component. Aim IK is ust used for following the target slightly with the body.")]
		public AimIK aim;

		[Token(Token = "0x4000847")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("The master weight")]
		public float weight;

		[Token(Token = "0x4000848")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[Tooltip("The effector type of the punching hand")]
		public FullBodyBipedEffector effector;

		[Token(Token = "0x4000849")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Weight of aiming the body to follow the target")]
		public AnimationCurve aimWeight;

		[Token(Token = "0x400084A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Animator animator;

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x1069A08", Offset = "0x1069A08", VA = "0x1069A08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x1069A60", Offset = "0x1069A60", VA = "0x1069A60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x1069BF8", Offset = "0x1069BF8", VA = "0x1069BF8")]
		public FBIKBoxing()
		{
		}
	}
	[Token(Token = "0x2000109")]
	public class FBIKHandsOnProp : MonoBehaviour
	{
		[Token(Token = "0x400084B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x400084C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool leftHanded;

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x1069C00", Offset = "0x1069C00", VA = "0x1069C00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x1069CE0", Offset = "0x1069CE0", VA = "0x1069CE0")]
		private void OnPreRead()
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0x1069D6C", Offset = "0x1069D6C", VA = "0x1069D6C")]
		private void HandsOnProp(IKEffector mainHand, IKEffector otherHand)
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0x106A240", Offset = "0x106A240", VA = "0x106A240")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0x106A36C", Offset = "0x106A36C", VA = "0x106A36C")]
		public FBIKHandsOnProp()
		{
		}
	}
	[Token(Token = "0x200010A")]
	public class FPSAiming : MonoBehaviour
	{
		[Token(Token = "0x400084D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float aimWeight;

		[Token(Token = "0x400084E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Range(0f, 1f)]
		public float sightWeight;

		[Token(Token = "0x400084F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 180f)]
		public float maxAngle;

		[Token(Token = "0x4000850")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 aimOffset;

		[Token(Token = "0x4000851")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool animatePhysics;

		[Token(Token = "0x4000852")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform gun;

		[Token(Token = "0x4000853")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform gunTarget;

		[Token(Token = "0x4000854")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FullBodyBipedIK ik;

		[Token(Token = "0x4000855")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public AimIK gunAim;

		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public AimIK headAim;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CameraControllerFPS cam;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Recoil recoil;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 1f)]
		public float cameraRecoilWeight;

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private Vector3 gunTargetDefaultLocalPosition;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 gunTargetDefaultLocalRotation;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private Vector3 camDefaultLocalPosition;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Vector3 camRelativeToGunTarget;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		private bool updateFrame;

		[Token(Token = "0x600080B")]
		[Address(RVA = "0x106A374", Offset = "0x106A374", VA = "0x106A374")]
		private void Start()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0x106A510", Offset = "0x106A510", VA = "0x106A510")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0x106A51C", Offset = "0x106A51C", VA = "0x106A51C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600080E")]
		[Address(RVA = "0x106A7DC", Offset = "0x106A7DC", VA = "0x106A7DC")]
		private void Aiming()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0x106AA80", Offset = "0x106AA80", VA = "0x106AA80")]
		private void LookDownTheSight()
		{
		}

		[Token(Token = "0x6000810")]
		[Address(RVA = "0x106A5E0", Offset = "0x106A5E0", VA = "0x106A5E0")]
		private void RotateCharacter()
		{
		}

		[Token(Token = "0x6000811")]
		[Address(RVA = "0x106B748", Offset = "0x106B748", VA = "0x106B748")]
		public FPSAiming()
		{
		}
	}
	[Token(Token = "0x200010B")]
	public class FPSCharacter : MonoBehaviour
	{
		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float sVel;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Animator animator;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FPSAiming FPSAiming;

		[Token(Token = "0x6000812")]
		[Address(RVA = "0x106C768", Offset = "0x106C768", VA = "0x106C768")]
		private void Start()
		{
		}

		[Token(Token = "0x6000813")]
		[Address(RVA = "0x106C7F8", Offset = "0x106C7F8", VA = "0x106C7F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000814")]
		[Address(RVA = "0x106C8F4", Offset = "0x106C8F4", VA = "0x106C8F4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000815")]
		[Address(RVA = "0x106C9A0", Offset = "0x106C9A0", VA = "0x106C9A0")]
		public FPSCharacter()
		{
		}
	}
	[Token(Token = "0x200010C")]
	public class HitReactionTrigger : MonoBehaviour
	{
		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReaction hitReaction;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x6000816")]
		[Address(RVA = "0x106C9B0", Offset = "0x106C9B0", VA = "0x106C9B0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000817")]
		[Address(RVA = "0x106CB00", Offset = "0x106CB00", VA = "0x106CB00")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000818")]
		[Address(RVA = "0x106CC64", Offset = "0x106CC64", VA = "0x106CC64")]
		public HitReactionTrigger()
		{
		}
	}
	[Token(Token = "0x200010D")]
	public class HoldingHands : MonoBehaviour
	{
		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FullBodyBipedIK rightHandChar;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FullBodyBipedIK leftHandChar;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform rightHandTarget;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform leftHandTarget;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float crossFade;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float speed;

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Quaternion rightHandRotation;

		[Token(Token = "0x400086D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Quaternion leftHandRotation;

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x106CC74", Offset = "0x106CC74", VA = "0x106CC74")]
		private void Start()
		{
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x106CE40", Offset = "0x106CE40", VA = "0x106CE40")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x106D250", Offset = "0x106D250", VA = "0x106D250")]
		public HoldingHands()
		{
		}
	}
	[Token(Token = "0x200010E")]
	public class InteractionC2CDemo : MonoBehaviour
	{
		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem character1;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem character2;

		[Token(Token = "0x4000870")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject handShake;

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x106D260", Offset = "0x106D260", VA = "0x106D260")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x106D348", Offset = "0x106D348", VA = "0x106D348")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x106D434", Offset = "0x106D434", VA = "0x106D434")]
		public InteractionC2CDemo()
		{
		}
	}
	[Token(Token = "0x200010F")]
	public class InteractionDemo : MonoBehaviour
	{
		[Token(Token = "0x4000871")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x4000872")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool interrupt;

		[Token(Token = "0x4000873")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject ball;

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public InteractionObject benchMain;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public InteractionObject benchHands;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public InteractionObject button;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public InteractionObject cigarette;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionObject door;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool isSitting;

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x106D43C", Offset = "0x106D43C", VA = "0x106D43C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000820")]
		[Address(RVA = "0x106D93C", Offset = "0x106D93C", VA = "0x106D93C")]
		public InteractionDemo()
		{
		}
	}
	[Token(Token = "0x2000110")]
	public class InteractionSystemTestGUI : MonoBehaviour
	{
		[Token(Token = "0x400087A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The object to interact to")]
		public InteractionObject interactionObject;

		[Token(Token = "0x400087B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The effectors to interact with")]
		public FullBodyBipedEffector[] effectors;

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private InteractionSystem interactionSystem;

		[Token(Token = "0x6000821")]
		[Address(RVA = "0x106D944", Offset = "0x106D944", VA = "0x106D944")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000822")]
		[Address(RVA = "0x106D99C", Offset = "0x106D99C", VA = "0x106D99C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000823")]
		[Address(RVA = "0x106DC48", Offset = "0x106DC48", VA = "0x106DC48")]
		public InteractionSystemTestGUI()
		{
		}
	}
	[Token(Token = "0x2000111")]
	public class KissingRig : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000112")]
		public class Partner
		{
			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedIK ik;

			[Token(Token = "0x4000882")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform mouth;

			[Token(Token = "0x4000883")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform mouthTarget;

			[Token(Token = "0x4000884")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Transform touchTargetLeftHand;

			[Token(Token = "0x4000885")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Transform touchTargetRightHand;

			[Token(Token = "0x4000886")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float bodyWeightHorizontal;

			[Token(Token = "0x4000887")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float bodyWeightVertical;

			[Token(Token = "0x4000888")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float neckRotationWeight;

			[Token(Token = "0x4000889")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public float headTiltAngle;

			[Token(Token = "0x400088A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector3 headTiltAxis;

			[Token(Token = "0x400088B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Quaternion neckRotation;

			[Token(Token = "0x17000133")]
			private Transform neck
			{
				[Token(Token = "0x6000829")]
				[Address(RVA = "0x106E454", Offset = "0x106E454", VA = "0x106E454")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x106DC78", Offset = "0x106DC78", VA = "0x106DC78")]
			public void Initiate()
			{
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x106DCF4", Offset = "0x106DCF4", VA = "0x106DCF4")]
			public void Update(float weight)
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x106E2EC", Offset = "0x106E2EC", VA = "0x106E2EC")]
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight)
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x106E4A0", Offset = "0x106E4A0", VA = "0x106E4A0")]
			public Partner()
			{
			}
		}

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Partner partner1;

		[Token(Token = "0x400087E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Partner partner2;

		[Token(Token = "0x400087F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float weight;

		[Token(Token = "0x4000880")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int iterations;

		[Token(Token = "0x6000824")]
		[Address(RVA = "0x106DC50", Offset = "0x106DC50", VA = "0x106DC50")]
		private void Start()
		{
		}

		[Token(Token = "0x6000825")]
		[Address(RVA = "0x106DC98", Offset = "0x106DC98", VA = "0x106DC98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000826")]
		[Address(RVA = "0x106E2DC", Offset = "0x106E2DC", VA = "0x106E2DC")]
		public KissingRig()
		{
		}
	}
	[Token(Token = "0x2000113")]
	public class MotionAbsorb : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000114")]
		public enum Mode
		{
			[Token(Token = "0x4000894")]
			Position,
			[Token(Token = "0x4000895")]
			PositionOffset
		}

		[Serializable]
		[Token(Token = "0x2000115")]
		public class Absorber
		{
			[Token(Token = "0x4000896")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[Tooltip("The type of effector (hand, foot, shoulder...) - this is just an enum")]
			public FullBodyBipedEffector effector;

			[Token(Token = "0x4000897")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			[Tooltip("How much should motion be absorbed on this effector")]
			public float weight;

			[Token(Token = "0x4000898")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Vector3 position;

			[Token(Token = "0x4000899")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private Quaternion rotation;

			[Token(Token = "0x400089A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IKEffector e;

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x106E62C", Offset = "0x106E62C", VA = "0x106E62C")]
			public void SetToBone(IKSolverFullBodyBiped solver, Mode mode)
			{
			}

			[Token(Token = "0x6000833")]
			[Address(RVA = "0x106E814", Offset = "0x106E814", VA = "0x106E814")]
			public void UpdateEffectorWeights(float w)
			{
			}

			[Token(Token = "0x6000834")]
			[Address(RVA = "0x106E838", Offset = "0x106E838", VA = "0x106E838")]
			public void SetPosition(float w)
			{
			}

			[Token(Token = "0x6000835")]
			[Address(RVA = "0x106E948", Offset = "0x106E948", VA = "0x106E948")]
			public void SetRotation(float w)
			{
			}

			[Token(Token = "0x6000836")]
			[Address(RVA = "0x106EB00", Offset = "0x106EB00", VA = "0x106EB00")]
			public Absorber()
			{
			}
		}

		[Token(Token = "0x400088C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Use either effector position, position weight, rotation, rotationWeight or positionOffset and rotating the bone directly.")]
		public Mode mode;

		[Token(Token = "0x400088D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Array containing the absorbers")]
		public Absorber[] absorbers;

		[Token(Token = "0x400088E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("Weight falloff curve (how fast will the effect reduce after impact)")]
		public AnimationCurve falloff;

		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("How fast will the impact fade away. (if 1, effect lasts for 1 second)")]
		public float falloffSpeed;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float timer;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float w;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Mode initialMode;

		[Token(Token = "0x600082C")]
		[Address(RVA = "0x106E4B4", Offset = "0x106E4B4", VA = "0x106E4B4", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600082D")]
		[Address(RVA = "0x106E5AC", Offset = "0x106E5AC", VA = "0x106E5AC")]
		private void OnCollisionEnter(Collision c)
		{
		}

		[Token(Token = "0x600082E")]
		[Address(RVA = "0x106E708", Offset = "0x106E708", VA = "0x106E708", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600082F")]
		[Address(RVA = "0x106E8CC", Offset = "0x106E8CC", VA = "0x106E8CC")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000830")]
		[Address(RVA = "0x106E9B8", Offset = "0x106E9B8", VA = "0x106E9B8", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		[Token(Token = "0x6000831")]
		[Address(RVA = "0x106EAF0", Offset = "0x106EAF0", VA = "0x106EAF0")]
		public MotionAbsorb()
		{
		}
	}
	[Token(Token = "0x2000116")]
	public class MotionAbsorbCharacter : MonoBehaviour
	{
		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Animator animator;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MotionAbsorb motionAbsorb;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform cube;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float cubeRandomPosition;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AnimationCurve motionAbsorbWeight;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 cubeDefaultPosition;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private AnimatorStateInfo info;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rigidbody cubeRigidbody;

		[Token(Token = "0x6000837")]
		[Address(RVA = "0x106EB60", Offset = "0x106EB60", VA = "0x106EB60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000838")]
		[Address(RVA = "0x106EBD8", Offset = "0x106EBD8", VA = "0x106EBD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000839")]
		[Address(RVA = "0x106ECA8", Offset = "0x106ECA8", VA = "0x106ECA8")]
		private void SwingStart()
		{
		}

		[Token(Token = "0x600083A")]
		[Address(RVA = "0x106EDF0", Offset = "0x106EDF0", VA = "0x106EDF0")]
		public MotionAbsorbCharacter()
		{
		}
	}
	[Token(Token = "0x2000117")]
	public class OffsetEffector : OffsetModifier
	{
		[Serializable]
		[Token(Token = "0x2000118")]
		public class EffectorLink
		{
			[Token(Token = "0x40008A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40008A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float weightMultiplier;

			[Token(Token = "0x40008A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			[HideInInspector]
			public Vector3 localPosition;

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x106F070", Offset = "0x106F070", VA = "0x106F070")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600083B")]
		[Address(RVA = "0x106EE04", Offset = "0x106EE04", VA = "0x106EE04", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x600083C")]
		[Address(RVA = "0x106EEF0", Offset = "0x106EEF0", VA = "0x106EEF0", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x600083D")]
		[Address(RVA = "0x106F068", Offset = "0x106F068", VA = "0x106F068")]
		public OffsetEffector()
		{
		}
	}
	[Token(Token = "0x2000119")]
	public class PendulumExample : MonoBehaviour
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Range(0f, 1f)]
		[Tooltip("The master weight of this script.")]
		public float weight;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Multiplier for the distance of the root to the target.")]
		public float hangingDistanceMlp;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[Tooltip("Where does the root of the character land when weight is blended out?")]
		public Vector3 rootTargetPosition;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		[Tooltip("How is the root of the character rotated when weight is blended out?")]
		public Quaternion rootTargetRotation;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform target;

		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform leftHandTarget;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Transform rightHandTarget;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Transform leftFootTarget;

		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Transform rightFootTarget;

		[Token(Token = "0x40008B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Transform pelvisTarget;

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public Transform bodyTarget;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Transform headTarget;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public Vector3 pelvisDownAxis;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Quaternion rootRelativeToPelvis;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Vector3 pelvisToRoot;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		private float lastWeight;

		[Token(Token = "0x600083F")]
		[Address(RVA = "0x106F080", Offset = "0x106F080", VA = "0x106F080")]
		private void Start()
		{
		}

		[Token(Token = "0x6000840")]
		[Address(RVA = "0x106F394", Offset = "0x106F394", VA = "0x106F394")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x106FB90", Offset = "0x106FB90", VA = "0x106FB90")]
		public PendulumExample()
		{
		}
	}
	[Token(Token = "0x200011A")]
	public abstract class PickUp2Handed : MonoBehaviour
	{
		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int GUIspace;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public InteractionObject obj;

		[Token(Token = "0x40008BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Transform pivot;

		[Token(Token = "0x40008BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Transform holdPoint;

		[Token(Token = "0x40008BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float pickUpTime;

		[Token(Token = "0x40008BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float holdWeight;

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float holdWeightVel;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 pickUpPosition;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Quaternion pickUpRotation;

		[Token(Token = "0x17000134")]
		private bool holding
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x106FF88", Offset = "0x106FF88", VA = "0x106FF88")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000135")]
		private bool holdingLeft
		{
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x1070058", Offset = "0x1070058", VA = "0x1070058")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000136")]
		private bool holdingRight
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x106FFB0", Offset = "0x106FFB0", VA = "0x106FFB0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000842")]
		[Address(RVA = "0x106FBFC", Offset = "0x106FBFC", VA = "0x106FBFC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000843")]
		protected abstract void RotatePivot();

		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1070100", Offset = "0x1070100", VA = "0x1070100")]
		private void Start()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0x10702F0", Offset = "0x10702F0", VA = "0x10702F0")]
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0x1070460", Offset = "0x1070460", VA = "0x1070460")]
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x1070530", Offset = "0x1070530", VA = "0x1070530")]
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x107065C", Offset = "0x107065C", VA = "0x107065C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x10707DC", Offset = "0x10707DC", VA = "0x10707DC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1070A18", Offset = "0x1070A18", VA = "0x1070A18")]
		protected PickUp2Handed()
		{
		}
	}
	[Token(Token = "0x200011B")]
	public class PickUpBox : PickUp2Handed
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1070A2C", Offset = "0x1070A2C", VA = "0x1070A2C", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1070C0C", Offset = "0x1070C0C", VA = "0x1070C0C")]
		public PickUpBox()
		{
		}
	}
	[Token(Token = "0x200011C")]
	public class PickUpSphere : PickUp2Handed
	{
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1070C20", Offset = "0x1070C20", VA = "0x1070C20", Slot = "4")]
		protected override void RotatePivot()
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x1070D34", Offset = "0x1070D34", VA = "0x1070D34")]
		public PickUpSphere()
		{
		}
	}
	[Token(Token = "0x200011D")]
	public class RagdollUtilityDemo : MonoBehaviour
	{
		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RagdollUtility ragdollUtility;

		[Token(Token = "0x40008C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform root;

		[Token(Token = "0x40008C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Rigidbody pelvis;

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1070D48", Offset = "0x1070D48", VA = "0x1070D48")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x1070DE0", Offset = "0x1070DE0", VA = "0x1070DE0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000854")]
		[Address(RVA = "0x1070EF8", Offset = "0x1070EF8", VA = "0x1070EF8")]
		public RagdollUtilityDemo()
		{
		}
	}
	[Token(Token = "0x200011E")]
	public class RecoilTest : MonoBehaviour
	{
		[Token(Token = "0x40008C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float magnitude;

		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Recoil recoil;

		[Token(Token = "0x6000855")]
		[Address(RVA = "0x1070F00", Offset = "0x1070F00", VA = "0x1070F00")]
		private void Start()
		{
		}

		[Token(Token = "0x6000856")]
		[Address(RVA = "0x1070F58", Offset = "0x1070F58", VA = "0x1070F58")]
		private void Update()
		{
		}

		[Token(Token = "0x6000857")]
		[Address(RVA = "0x1070FA4", Offset = "0x1070FA4", VA = "0x1070FA4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000858")]
		[Address(RVA = "0x107103C", Offset = "0x107103C", VA = "0x107103C")]
		public RecoilTest()
		{
		}
	}
	[Token(Token = "0x200011F")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000120")]
		[CompilerGenerated]
		private sealed class <ResetObject>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ResetInteractionObject <>4__this;

			[Token(Token = "0x17000137")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000860")]
				[Address(RVA = "0x10713B4", Offset = "0x10713B4", VA = "0x10713B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000138")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000862")]
				[Address(RVA = "0x10713FC", Offset = "0x10713FC", VA = "0x10713FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x10711D0", Offset = "0x10711D0", VA = "0x10711D0")]
			[DebuggerHidden]
			public <ResetObject>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x1071208", Offset = "0x1071208", VA = "0x1071208", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x107120C", Offset = "0x107120C", VA = "0x107120C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x10713BC", Offset = "0x10713BC", VA = "0x10713BC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000859")]
		[Address(RVA = "0x107104C", Offset = "0x107104C", VA = "0x107104C")]
		private void Start()
		{
		}

		[Token(Token = "0x600085A")]
		[Address(RVA = "0x1071110", Offset = "0x1071110", VA = "0x1071110")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x600085B")]
		[Address(RVA = "0x107114C", Offset = "0x107114C", VA = "0x107114C")]
		[IteratorStateMachine(typeof(<ResetObject>d__7))]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x600085C")]
		[Address(RVA = "0x10711F8", Offset = "0x10711F8", VA = "0x10711F8")]
		public ResetInteractionObject()
		{
		}
	}
	[Token(Token = "0x2000121")]
	public class SoccerDemo : MonoBehaviour
	{
		[Token(Token = "0x2000122")]
		[CompilerGenerated]
		private sealed class <ResetDelayed>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SoccerDemo <>4__this;

			[Token(Token = "0x17000139")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000869")]
				[Address(RVA = "0x10716A0", Offset = "0x10716A0", VA = "0x10716A0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600086B")]
				[Address(RVA = "0x10716E8", Offset = "0x10716E8", VA = "0x10716E8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x107152C", Offset = "0x107152C", VA = "0x107152C")]
			[DebuggerHidden]
			public <ResetDelayed>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x107155C", Offset = "0x107155C", VA = "0x107155C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x1071560", Offset = "0x1071560", VA = "0x1071560", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x10716A8", Offset = "0x10716A8", VA = "0x10716A8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Animator animator;

		[Token(Token = "0x40008D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 defaultPosition;

		[Token(Token = "0x40008D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x6000863")]
		[Address(RVA = "0x1071404", Offset = "0x1071404", VA = "0x1071404")]
		private void Start()
		{
		}

		[Token(Token = "0x6000864")]
		[Address(RVA = "0x10714B8", Offset = "0x10714B8", VA = "0x10714B8")]
		[IteratorStateMachine(typeof(<ResetDelayed>d__4))]
		private IEnumerator ResetDelayed()
		{
			return null;
		}

		[Token(Token = "0x6000865")]
		[Address(RVA = "0x1071554", Offset = "0x1071554", VA = "0x1071554")]
		public SoccerDemo()
		{
		}
	}
	[Token(Token = "0x2000123")]
	public class TouchWalls : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2000124")]
		public class EffectorLink
		{
			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool enabled;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public FullBodyBipedEffector effectorType;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public InteractionObject interactionObject;

			[Token(Token = "0x40008DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Transform spherecastFrom;

			[Token(Token = "0x40008DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float spherecastRadius;

			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float minDistance;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float distanceMlp;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public LayerMask touchLayers;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float lerpSpeed;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public float minSwitchTime;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public float releaseDistance;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public bool sliding;

			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private Vector3 raycastDirectionLocal;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float raycastDistance;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private bool inTouch;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
			private RaycastHit hit;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			private Vector3 targetPosition;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
			private Quaternion targetRotation;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private bool initiated;

			[Token(Token = "0x40008EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			private float nextSwitchTime;

			[Token(Token = "0x40008EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
			private float speedF;

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x1071754", Offset = "0x1071754", VA = "0x1071754")]
			public void Initiate(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x1072328", Offset = "0x1072328", VA = "0x1072328")]
			private bool FindWalls(Vector3 direction)
			{
				return default(bool);
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1071B5C", Offset = "0x1071B5C", VA = "0x1071B5C")]
			public void Update(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1072410", Offset = "0x1072410", VA = "0x1072410")]
			private void StopTouch(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x10724F4", Offset = "0x10724F4", VA = "0x10724F4")]
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x1072580", Offset = "0x1072580", VA = "0x1072580")]
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x1072608", Offset = "0x1072608", VA = "0x1072608")]
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject)
			{
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x1072114", Offset = "0x1072114", VA = "0x1072114")]
			public void Destroy(InteractionSystem interactionSystem)
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x1072690", Offset = "0x1072690", VA = "0x1072690")]
			public EffectorLink()
			{
			}
		}

		[Token(Token = "0x40008D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40008D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EffectorLink[] effectorLinks;

		[Token(Token = "0x600086C")]
		[Address(RVA = "0x10716F0", Offset = "0x10716F0", VA = "0x10716F0")]
		private void Start()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0x1071AFC", Offset = "0x1071AFC", VA = "0x1071AFC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0x1072064", Offset = "0x1072064", VA = "0x1072064")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0x1072320", Offset = "0x1072320", VA = "0x1072320")]
		public TouchWalls()
		{
		}
	}
	[Token(Token = "0x2000125")]
	public class TransferMotion : MonoBehaviour
	{
		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The Transform to transfer motion to.")]
		public Transform to;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The amount of motion to transfer.")]
		[Range(0f, 1f)]
		public float transferMotion;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0x10726CC", Offset = "0x10726CC", VA = "0x10726CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0x10726FC", Offset = "0x10726FC", VA = "0x10726FC")]
		private void Update()
		{
		}

		[Token(Token = "0x600087B")]
		[Address(RVA = "0x10727AC", Offset = "0x10727AC", VA = "0x10727AC")]
		public TransferMotion()
		{
		}
	}
	[Token(Token = "0x2000126")]
	public class TwoHandedProp : MonoBehaviour
	{
		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The left hand target parented to the right hand.")]
		public Transform leftHandTarget;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FullBodyBipedIK ik;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 targetPosRelativeToRight;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private Quaternion targetRotRelativeToRight;

		[Token(Token = "0x600087C")]
		[Address(RVA = "0x10727C0", Offset = "0x10727C0", VA = "0x10727C0")]
		private void Start()
		{
		}

		[Token(Token = "0x600087D")]
		[Address(RVA = "0x10729D8", Offset = "0x10729D8", VA = "0x10729D8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600087E")]
		[Address(RVA = "0x1072C74", Offset = "0x1072C74", VA = "0x1072C74")]
		private void AfterFBBIK()
		{
		}

		[Token(Token = "0x600087F")]
		[Address(RVA = "0x1072D3C", Offset = "0x1072D3C", VA = "0x1072D3C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000880")]
		[Address(RVA = "0x1072E68", Offset = "0x1072E68", VA = "0x1072E68")]
		public TwoHandedProp()
		{
		}
	}
	[Token(Token = "0x2000127")]
	public class UserControlInteractions : UserControlThirdPerson
	{
		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public CharacterThirdPerson character;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public InteractionSystem interactionSystem;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public bool disableInputInInteraction;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float enableInputAtProgress;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x1072E70", Offset = "0x1072E70", VA = "0x1072E70", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x10732C8", Offset = "0x10732C8", VA = "0x10732C8")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x1073490", Offset = "0x1073490", VA = "0x1073490")]
		public UserControlInteractions()
		{
		}
	}
	[Token(Token = "0x2000128")]
	public class GrounderDemo : MonoBehaviour
	{
		[Token(Token = "0x40008F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject[] characters;

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x10734C4", Offset = "0x10734C4", VA = "0x10734C4")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x10736CC", Offset = "0x10736CC", VA = "0x10736CC")]
		public void Activate(int index)
		{
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x1073738", Offset = "0x1073738", VA = "0x1073738")]
		public GrounderDemo()
		{
		}
	}
	[Token(Token = "0x2000129")]
	public class PlatformRotator : MonoBehaviour
	{
		[Token(Token = "0x200012A")]
		[CompilerGenerated]
		private sealed class <SwitchRotation>d__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PlatformRotator <>4__this;

			[Token(Token = "0x1700013B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x1073EA8", Offset = "0x1073EA8", VA = "0x1073EA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700013C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000892")]
				[Address(RVA = "0x1073EF0", Offset = "0x1073EF0", VA = "0x1073EF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1073B30", Offset = "0x1073B30", VA = "0x1073B30")]
			[DebuggerHidden]
			public <SwitchRotation>d__14(int <>1__state)
			{
			}

			[Token(Token = "0x600088E")]
			[Address(RVA = "0x1073D20", Offset = "0x1073D20", VA = "0x1073D20", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x1073D24", Offset = "0x1073D24", VA = "0x1073D24", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1073EB0", Offset = "0x1073EB0", VA = "0x1073EB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxAngle;

		[Token(Token = "0x40008FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float switchRotationTime;

		[Token(Token = "0x40008FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float random;

		[Token(Token = "0x40008FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float rotationSpeed;

		[Token(Token = "0x40008FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 movePosition;

		[Token(Token = "0x40008FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float moveSpeed;

		[Token(Token = "0x40008FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int characterLayer;

		[Token(Token = "0x4000900")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000901")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion targetRotation;

		[Token(Token = "0x4000902")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Vector3 targetPosition;

		[Token(Token = "0x4000903")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Vector3 velocity;

		[Token(Token = "0x4000904")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Rigidbody r;

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x1073740", Offset = "0x1073740", VA = "0x1073740")]
		private void Start()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x107387C", Offset = "0x107387C", VA = "0x107387C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000889")]
		[Address(RVA = "0x1073808", Offset = "0x1073808", VA = "0x1073808")]
		[IteratorStateMachine(typeof(<SwitchRotation>d__14))]
		private IEnumerator SwitchRotation()
		{
			return null;
		}

		[Token(Token = "0x600088A")]
		[Address(RVA = "0x1073B58", Offset = "0x1073B58", VA = "0x1073B58")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600088B")]
		[Address(RVA = "0x1073C30", Offset = "0x1073C30", VA = "0x1073C30")]
		private void OnCollisionExit(Collision collision)
		{
		}

		[Token(Token = "0x600088C")]
		[Address(RVA = "0x1073D04", Offset = "0x1073D04", VA = "0x1073D04")]
		public PlatformRotator()
		{
		}
	}
	[Token(Token = "0x200012B")]
	public class BendGoal : MonoBehaviour
	{
		[Token(Token = "0x4000908")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LimbIK limbIK;

		[Token(Token = "0x4000909")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float weight;

		[Token(Token = "0x6000893")]
		[Address(RVA = "0x1073EF8", Offset = "0x1073EF8", VA = "0x1073EF8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0x1073F60", Offset = "0x1073F60", VA = "0x1073F60")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000895")]
		[Address(RVA = "0x107400C", Offset = "0x107400C", VA = "0x107400C")]
		public BendGoal()
		{
		}
	}
	[Token(Token = "0x200012C")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200012D")]
		public class Part
		{
			[Token(Token = "0x400090C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x400090D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000898")]
			[Address(RVA = "0x1074080", Offset = "0x1074080", VA = "0x1074080")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x10741BC", Offset = "0x10741BC", VA = "0x10741BC")]
			public Part()
			{
			}
		}

		[Token(Token = "0x400090A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x400090B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000896")]
		[Address(RVA = "0x107401C", Offset = "0x107401C", VA = "0x107401C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0x10741B4", Offset = "0x10741B4", VA = "0x10741B4")]
		public Turret()
		{
		}
	}
	[Token(Token = "0x200012E")]
	public class VRIKAvatarScaleCalibrationOculus : MonoBehaviour
	{
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x10741C4", Offset = "0x10741C4", VA = "0x10741C4")]
		public VRIKAvatarScaleCalibrationOculus()
		{
		}
	}
	[Token(Token = "0x200012F")]
	public class HitReactionVRIKTrigger : MonoBehaviour
	{
		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HitReactionVRIK hitReaction;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float hitForce;

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string colliderName;

		[Token(Token = "0x600089B")]
		[Address(RVA = "0x10741CC", Offset = "0x10741CC", VA = "0x10741CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0x107431C", Offset = "0x107431C", VA = "0x107431C")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0x1074480", Offset = "0x1074480", VA = "0x1074480")]
		public HitReactionVRIKTrigger()
		{
		}
	}
	[Token(Token = "0x2000130")]
	public class VRIKCalibrationBasic : MonoBehaviour
	{
		[Token(Token = "0x4000911")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The VRIK component.")]
		public VRIK ik;

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("HMD.")]
		[Header("Head")]
		public Transform centerEyeAnchor;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("Position offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorPositionOffset;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[Tooltip("Rotation offset of the camera from the head bone (root space).")]
		public Vector3 headAnchorRotationOffset;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("Left Hand Controller")]
		[Header("Hands")]
		public Transform leftHandAnchor;

		[Token(Token = "0x4000916")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("Right Hand Controller")]
		public Transform rightHandAnchor;

		[Token(Token = "0x4000917")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("Position offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorPositionOffset;

		[Token(Token = "0x4000918")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Tooltip("Rotation offset of the hand controller from the hand bone (controller space).")]
		public Vector3 handAnchorRotationOffset;

		[Token(Token = "0x4000919")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Multiplies the scale of the root.")]
		[Header("Scale")]
		public float scaleMlp;

		[Token(Token = "0x400091A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x600089E")]
		[Address(RVA = "0x1074490", Offset = "0x1074490", VA = "0x1074490")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600089F")]
		[Address(RVA = "0x1074624", Offset = "0x1074624", VA = "0x1074624")]
		public VRIKCalibrationBasic()
		{
		}
	}
	[Token(Token = "0x2000131")]
	public class VRIKCalibrationController : MonoBehaviour
	{
		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Reference to the VRIK component on the avatar.")]
		public VRIK ik;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("The settings for VRIK calibration.")]
		public VRIKCalibrator.Settings settings;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("The HMD.")]
		public Transform headTracker;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("(Optional) A tracker placed anywhere on the body of the player, preferrably close to the pelvis, on the belt area.")]
		public Transform bodyTracker;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's left hand.")]
		public Transform leftHandTracker;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Tooltip("(Optional) A tracker or hand controller device placed anywhere on or in the player's right hand.")]
		public Transform rightHandTracker;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's left leg.")]
		public Transform leftFootTracker;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Tooltip("(Optional) A tracker placed anywhere on the ankle or toes of the player's right leg.")]
		public Transform rightFootTracker;

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Header("Data stored by Calibration")]
		public VRIKCalibrator.CalibrationData data;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0x10746A0", Offset = "0x10746A0", VA = "0x10746A0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0x1074804", Offset = "0x1074804", VA = "0x1074804")]
		public VRIKCalibrationController()
		{
		}
	}
	[Token(Token = "0x2000132")]
	public class VRIKPlatform : MonoBehaviour
	{
		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x1074878", Offset = "0x1074878", VA = "0x1074878")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x10748C8", Offset = "0x10748C8", VA = "0x10748C8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0x1074AA0", Offset = "0x1074AA0", VA = "0x1074AA0")]
		public VRIKPlatform()
		{
		}
	}
	[Token(Token = "0x2000133")]
	public class VRIKPlatformController : MonoBehaviour
	{
		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VRIK ik;

		[Token(Token = "0x4000928")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform trackingSpace;

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform platform;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool moveToPlatform;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform lastPlatform;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Vector3 lastPosition;

		[Token(Token = "0x400092D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x1074AF8", Offset = "0x1074AF8", VA = "0x1074AF8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0x1075028", Offset = "0x1075028", VA = "0x1075028")]
		public VRIKPlatformController()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000134")]
	public class NetworkTransform
	{
		[Token(Token = "0x400092E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 position;

		[Token(Token = "0x400092F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public Quaternion rotation;

		[Token(Token = "0x4000930")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000931")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Quaternion lastRotation;

		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform receiveRelTo;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int lastReceiveRelToId;

		[Token(Token = "0x60008A7")]
		[Address(RVA = "0x1075084", Offset = "0x1075084", VA = "0x1075084")]
		public void Reset(Transform t)
		{
		}

		[Token(Token = "0x60008A8")]
		[Address(RVA = "0x10750F8", Offset = "0x10750F8", VA = "0x10750F8")]
		public void Send(PhotonStream stream)
		{
		}

		[Token(Token = "0x60008A9")]
		[Address(RVA = "0x10751B8", Offset = "0x10751B8", VA = "0x10751B8")]
		public void SendRelTo(PhotonStream stream, PhotonView relTo)
		{
		}

		[Token(Token = "0x60008AA")]
		[Address(RVA = "0x10752F8", Offset = "0x10752F8", VA = "0x10752F8")]
		public void Receive(PhotonStream stream)
		{
		}

		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x10753CC", Offset = "0x10753CC", VA = "0x10753CC")]
		public void ReceiveRelTo(PhotonStream stream)
		{
		}

		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x1075584", Offset = "0x1075584", VA = "0x1075584")]
		public void ReadTransformLocal(Transform t, PhotonView relTo)
		{
		}

		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x1075838", Offset = "0x1075838", VA = "0x1075838")]
		public void ReadTransformLocal(Transform t)
		{
		}

		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x1075884", Offset = "0x1075884", VA = "0x1075884")]
		public void ApplyToLocal(Transform t)
		{
		}

		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x1075AB0", Offset = "0x1075AB0", VA = "0x1075AB0")]
		public void ApplyRemoteInterpolated(Transform t, float interpolationSpeed, float maxErrorSqrMag)
		{
		}

		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x1075CB0", Offset = "0x1075CB0", VA = "0x1075CB0")]
		private Vector3 Interpolate(Vector3 v, Vector3 target)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x1075660", Offset = "0x1075660", VA = "0x1075660")]
		private Vector3 SendRelTo(Vector3 v, Transform t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B2")]
		[Address(RVA = "0x1075718", Offset = "0x1075718", VA = "0x1075718")]
		private Quaternion SendRelTo(Quaternion r, Transform t)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008B3")]
		[Address(RVA = "0x10758E0", Offset = "0x10758E0", VA = "0x10758E0")]
		private Vector3 ReceiveRelTo(Vector3 v, Transform t)
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B4")]
		[Address(RVA = "0x1075998", Offset = "0x1075998", VA = "0x1075998")]
		private Quaternion ReceiveRelTo(Quaternion r, Transform t)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x1075D34", Offset = "0x1075D34", VA = "0x1075D34")]
		public NetworkTransform()
		{
		}
	}
	[Token(Token = "0x2000135")]
	public abstract class CharacterAnimationBase : MonoBehaviour
	{
		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool smoothFollow;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float smoothFollowSpeed;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected bool animatePhysics;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 localPosition;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private Quaternion localRotation;

		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Quaternion lastRotation;

		[Token(Token = "0x1700013D")]
		public virtual bool animationGrounded
		{
			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1075DC0", Offset = "0x1075DC0", VA = "0x1075DC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1075DA0", Offset = "0x1075DA0", VA = "0x1075DA0", Slot = "4")]
		public virtual Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008B8")]
		[Address(RVA = "0x1075DC8", Offset = "0x1075DC8", VA = "0x1075DC8")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008B9")]
		[Address(RVA = "0x1075E28", Offset = "0x1075E28", VA = "0x1075E28", Slot = "6")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008BA")]
		[Address(RVA = "0x1075FAC", Offset = "0x1075FAC", VA = "0x1075FAC", Slot = "7")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008BB")]
		[Address(RVA = "0x1076228", Offset = "0x1076228", VA = "0x1076228", Slot = "8")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x60008BC")]
		[Address(RVA = "0x1075FBC", Offset = "0x1075FBC", VA = "0x1075FBC")]
		private void SmoothFollow()
		{
		}

		[Token(Token = "0x60008BD")]
		[Address(RVA = "0x1076238", Offset = "0x1076238", VA = "0x1076238")]
		protected CharacterAnimationBase()
		{
		}
	}
	[Token(Token = "0x2000136")]
	public class CharacterAnimationSimple : CharacterAnimationBase
	{
		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public float pivotOffset;

		[Token(Token = "0x400093D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public AnimationCurve moveSpeed;

		[Token(Token = "0x400093E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Animator animator;

		[Token(Token = "0x60008BE")]
		[Address(RVA = "0x1076250", Offset = "0x1076250", VA = "0x1076250", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008BF")]
		[Address(RVA = "0x10762B0", Offset = "0x10762B0", VA = "0x10762B0", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1076340", Offset = "0x1076340", VA = "0x1076340")]
		private void Update()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1076464", Offset = "0x1076464", VA = "0x1076464")]
		public CharacterAnimationSimple()
		{
		}
	}
	[Token(Token = "0x2000137")]
	public class CharacterAnimationThirdPerson : CharacterAnimationBase
	{
		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public CharacterThirdPerson characterController;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private float turnSensitivity;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float turnSpeed;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float runCycleLegOffset;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		[Range(0.1f, 3f)]
		[SerializeField]
		private float animSpeedMultiplier;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		protected Animator animator;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 lastForward;

		[Token(Token = "0x4000946")]
		private const string groundedDirectional = "Grounded Directional";

		[Token(Token = "0x4000947")]
		private const string groundedStrafe = "Grounded Strafe";

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float deltaAngle;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float jumpLeg;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private bool lastJump;

		[Token(Token = "0x1700013E")]
		public override bool animationGrounded
		{
			[Token(Token = "0x60008C4")]
			[Address(RVA = "0x1076520", Offset = "0x1076520", VA = "0x1076520", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x107647C", Offset = "0x107647C", VA = "0x107647C", Slot = "6")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1076504", Offset = "0x1076504", VA = "0x1076504", Slot = "4")]
		public override Vector3 GetPivotPoint()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008C5")]
		[Address(RVA = "0x1076614", Offset = "0x1076614", VA = "0x1076614", Slot = "9")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1076A04", Offset = "0x1076A04", VA = "0x1076A04")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008C7")]
		[Address(RVA = "0x1076B2C", Offset = "0x1076B2C", VA = "0x1076B2C")]
		public CharacterAnimationThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000138")]
	public abstract class CharacterBase : MonoBehaviour
	{
		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Header("Base Parameters")]
		[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
		public Transform gravityTarget;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
		public float gravityMultiplier;

		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float airborneThreshold;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float slopeStartAngle;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float slopeEndAngle;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float spherecastRadius;

		[Token(Token = "0x4000951")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public LayerMask groundLayers;

		[Token(Token = "0x4000952")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private PhysicMaterial zeroFrictionMaterial;

		[Token(Token = "0x4000953")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PhysicMaterial highFrictionMaterial;

		[Token(Token = "0x4000954")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		protected Rigidbody r;

		[Token(Token = "0x4000955")]
		protected const float half = 0.5f;

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected float originalHeight;

		[Token(Token = "0x4000957")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		protected Vector3 originalCenter;

		[Token(Token = "0x4000958")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected CapsuleCollider capsule;

		[Token(Token = "0x60008C8")]
		public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1076B50", Offset = "0x1076B50", VA = "0x1076B50")]
		protected Vector3 GetGravity()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1076D3C", Offset = "0x1076D3C", VA = "0x1076D3C", Slot = "5")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008CB")]
		[Address(RVA = "0x1076F68", Offset = "0x1076F68", VA = "0x1076F68", Slot = "6")]
		protected virtual RaycastHit GetSpherecastHit()
		{
			return default(RaycastHit);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x1077108", Offset = "0x1077108", VA = "0x1077108")]
		public float GetAngleFromForward(Vector3 worldDirection)
		{
			return default(float);
		}

		[Token(Token = "0x60008CD")]
		[Address(RVA = "0x1077168", Offset = "0x1077168", VA = "0x1077168")]
		protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle)
		{
		}

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x10772CC", Offset = "0x10772CC", VA = "0x10772CC")]
		protected void ScaleCapsule(float mlp)
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x10774D0", Offset = "0x10774D0", VA = "0x10774D0")]
		protected void HighFriction()
		{
		}

		[Token(Token = "0x60008D0")]
		[Address(RVA = "0x10774F4", Offset = "0x10774F4", VA = "0x10774F4")]
		protected void ZeroFriction()
		{
		}

		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x1077518", Offset = "0x1077518", VA = "0x1077518")]
		protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal)
		{
			return default(float);
		}

		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x1077664", Offset = "0x1077664", VA = "0x1077664")]
		protected CharacterBase()
		{
		}
	}
	[Token(Token = "0x2000139")]
	public class CharacterThirdPerson : CharacterBase
	{
		[Serializable]
		[Token(Token = "0x200013A")]
		public enum MoveMode
		{
			[Token(Token = "0x4000993")]
			Directional,
			[Token(Token = "0x4000994")]
			Strafe
		}

		[Token(Token = "0x200013B")]
		public struct AnimState
		{
			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 moveDirection;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool jump;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
			public bool crouch;

			[Token(Token = "0x4000998")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE")]
			public bool onGround;

			[Token(Token = "0x4000999")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF")]
			public bool isStrafing;

			[Token(Token = "0x400099A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float yVelocity;

			[Token(Token = "0x400099B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool doubleJump;
		}

		[Token(Token = "0x200013C")]
		[CompilerGenerated]
		private sealed class <JumpSmooth>d__75 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400099C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400099D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400099E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CharacterThirdPerson <>4__this;

			[Token(Token = "0x400099F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3 jumpVelocity;

			[Token(Token = "0x40009A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <steps>5__2;

			[Token(Token = "0x40009A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <stepsToTake>5__3;

			[Token(Token = "0x17000140")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008E8")]
				[Address(RVA = "0x107A0F8", Offset = "0x107A0F8", VA = "0x107A0F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000141")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008EA")]
				[Address(RVA = "0x107A140", Offset = "0x107A140", VA = "0x107A140", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x1079EB8", Offset = "0x1079EB8", VA = "0x1079EB8")]
			[DebuggerHidden]
			public <JumpSmooth>d__75(int <>1__state)
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x1079FF4", Offset = "0x1079FF4", VA = "0x1079FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x1079FF8", Offset = "0x1079FF8", VA = "0x1079FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x107A100", Offset = "0x107A100", VA = "0x107A100", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000959")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Header("References")]
		public CharacterAnimationBase characterAnimation;

		[Token(Token = "0x400095A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public UserControlThirdPerson userControl;

		[Token(Token = "0x400095B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public CameraController cam;

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Header("Movement")]
		public MoveMode moveMode;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool smoothPhysics;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public float smoothAccelerationTime;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float linearAccelerationSpeed;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float platformFriction;

		[Token(Token = "0x4000961")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float groundStickyEffect;

		[Token(Token = "0x4000962")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float maxVerticalVelocityOnGround;

		[Token(Token = "0x4000963")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public float velocityToGroundTangentWeight;

		[Token(Token = "0x4000964")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[Header("Rotation")]
		public bool lookInCameraDirection;

		[Token(Token = "0x4000965")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
		public float turnSpeed;

		[Token(Token = "0x4000966")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public float stationaryTurnSpeedMlp;

		[Token(Token = "0x4000967")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Header("Jumping and Falling")]
		public bool smoothJump;

		[Token(Token = "0x4000968")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float airSpeed;

		[Token(Token = "0x4000969")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float airControl;

		[Token(Token = "0x400096A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public float jumpPower;

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		public float jumpRepeatDelayTime;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool doubleJumpEnabled;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public float doubleJumpPowerMlp;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Header("Wall Running")]
		public LayerMask wallRunLayers;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public float wallRunMaxLength;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public float wallRunMinMoveMag;

		[Token(Token = "0x4000971")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public float wallRunMinVelocityY;

		[Token(Token = "0x4000972")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public float wallRunRotationSpeed;

		[Token(Token = "0x4000973")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
		public float wallRunMaxRotationAngle;

		[Token(Token = "0x4000974")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float wallRunWeightSpeed;

		[Token(Token = "0x4000975")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		[Header("Crouching")]
		public float crouchCapsuleScaleMlp;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public AnimState animState;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		protected Vector3 moveDirection;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Animator animator;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Vector3 normal;

		[Token(Token = "0x400097B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		private Vector3 platformVelocity;

		[Token(Token = "0x400097C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private Vector3 platformAngularVelocity;

		[Token(Token = "0x400097D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		private RaycastHit hit;

		[Token(Token = "0x400097E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private float jumpLeg;

		[Token(Token = "0x400097F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
		private float jumpEndTime;

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private float forwardMlp;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private float groundDistance;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private float lastAirTime;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private float stickyForce;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Vector3 wallNormal;

		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
		private Vector3 moveDirectionVelocity;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private float wallRunWeight;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
		private float lastWallRunWeight;

		[Token(Token = "0x4000988")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private float fixedDeltaTime;

		[Token(Token = "0x4000989")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
		private Vector3 fixedDeltaPosition;

		[Token(Token = "0x400098A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Quaternion fixedDeltaRotation;

		[Token(Token = "0x400098B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private bool fixedFrame;

		[Token(Token = "0x400098C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private float wallRunEndTime;

		[Token(Token = "0x400098D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private Vector3 gravity;

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D4")]
		private Vector3 verticalVelocity;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private float velocityY;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E4")]
		private bool doubleJumped;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E5")]
		private bool jumpReleased;

		[Token(Token = "0x1700013F")]
		public bool onGround
		{
			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x1077684", Offset = "0x1077684", VA = "0x1077684")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x107768C", Offset = "0x107768C", VA = "0x107768C")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x1077698", Offset = "0x1077698", VA = "0x1077698", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x1077884", Offset = "0x1077884", VA = "0x1077884")]
		private void OnAnimatorMove()
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x1077908", Offset = "0x1077908", VA = "0x1077908", Slot = "4")]
		public override void Move(Vector3 deltaPosition, Quaternion deltaRotation)
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x1077A1C", Offset = "0x1077A1C", VA = "0x1077A1C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x1078A44", Offset = "0x1078A44", VA = "0x1078A44", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x1078ED4", Offset = "0x1078ED4", VA = "0x1078ED4", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x10780D0", Offset = "0x10780D0", VA = "0x10780D0")]
		private void MoveFixed(Vector3 deltaPosition)
		{
		}

		[Token(Token = "0x60008DC")]
		[Address(RVA = "0x1078FAC", Offset = "0x1078FAC", VA = "0x1078FAC")]
		private void WallRun()
		{
		}

		[Token(Token = "0x60008DD")]
		[Address(RVA = "0x1079634", Offset = "0x1079634", VA = "0x1079634")]
		private bool CanWallRun()
		{
			return default(bool);
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0x1078AD0", Offset = "0x1078AD0", VA = "0x1078AD0")]
		private Vector3 GetMoveDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0x1079724", Offset = "0x1079724", VA = "0x1079724", Slot = "9")]
		protected virtual void Rotate()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0x1079BA4", Offset = "0x1079BA4", VA = "0x1079BA4")]
		private Vector3 GetForwardDirection()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x1079CCC", Offset = "0x1079CCC", VA = "0x1079CCC", Slot = "10")]
		protected virtual bool Jump()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x1079E20", Offset = "0x1079E20", VA = "0x1079E20")]
		[IteratorStateMachine(typeof(<JumpSmooth>d__75))]
		private IEnumerator JumpSmooth(Vector3 jumpVelocity)
		{
			return null;
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x10784E4", Offset = "0x10784E4", VA = "0x10784E4")]
		private void GroundCheck()
		{
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x1079EE0", Offset = "0x1079EE0", VA = "0x1079EE0")]
		public CharacterThirdPerson()
		{
		}
	}
	[Token(Token = "0x200013D")]
	public class SimpleLocomotion : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013E")]
		public enum RotationMode
		{
			[Token(Token = "0x40009B0")]
			Smooth,
			[Token(Token = "0x40009B1")]
			Linear
		}

		[Token(Token = "0x40009A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("The component that updates the camera.")]
		public CameraController cameraController;

		[Token(Token = "0x40009A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Acceleration of movement.")]
		public float accelerationTime;

		[Token(Token = "0x40009A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[Tooltip("Turning speed.")]
		public float turnTime;

		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Tooltip("If true, will run on left shift, if not will walk on left shift.")]
		public bool walkByDefault;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Tooltip("Smooth or linear rotation.")]
		public RotationMode rotationMode;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Tooltip("Procedural motion speed (if not using root motion).")]
		public float moveSpeed;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Animator animator;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float speed;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float angleVel;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float speedVel;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Vector3 linearTargetDirection;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CharacterController characterController;

		[Token(Token = "0x17000142")]
		public bool isGrounded
		{
			[Token(Token = "0x60008EB")]
			[Address(RVA = "0x107A148", Offset = "0x107A148", VA = "0x107A148")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x107A150", Offset = "0x107A150", VA = "0x107A150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x60008ED")]
		[Address(RVA = "0x107A15C", Offset = "0x107A15C", VA = "0x107A15C")]
		private void Start()
		{
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0x107A204", Offset = "0x107A204", VA = "0x107A204")]
		private void Update()
		{
		}

		[Token(Token = "0x60008EF")]
		[Address(RVA = "0x107A81C", Offset = "0x107A81C", VA = "0x107A81C")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0x107A24C", Offset = "0x107A24C", VA = "0x107A24C")]
		private void Rotate()
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0x107A5B4", Offset = "0x107A5B4", VA = "0x107A5B4")]
		private void Move()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0x107A84C", Offset = "0x107A84C", VA = "0x107A84C")]
		private Vector3 GetInputVector()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F3")]
		[Address(RVA = "0x107A8E4", Offset = "0x107A8E4", VA = "0x107A8E4")]
		private Vector3 GetInputVectorRaw()
		{
			return default(Vector3);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x107A964", Offset = "0x107A964", VA = "0x107A964")]
		public SimpleLocomotion()
		{
		}
	}
	[Token(Token = "0x200013F")]
	public class UserControlAI : UserControlThirdPerson
	{
		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform moveTarget;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float stoppingDistance;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float stoppingThreshold;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Navigator navigator;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x107A98C", Offset = "0x107A98C", VA = "0x107A98C", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x107AAD4", Offset = "0x107AAD4", VA = "0x107AAD4", Slot = "5")]
		protected override void Update()
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x107B14C", Offset = "0x107B14C", VA = "0x107B14C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x107B338", Offset = "0x107B338", VA = "0x107B338")]
		public UserControlAI()
		{
		}
	}
	[Token(Token = "0x2000140")]
	public class UserControlThirdPerson : MonoBehaviour
	{
		[Token(Token = "0x2000141")]
		public struct State
		{
			[Token(Token = "0x40009BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 move;

			[Token(Token = "0x40009BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 lookPos;

			[Token(Token = "0x40009BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool crouch;

			[Token(Token = "0x40009BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
			public bool jump;

			[Token(Token = "0x40009BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int actionIndex;
		}

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool walkByDefault;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		public bool canCrouch;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		public bool canJump;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public State state;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		protected Transform cam;

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x107A9C8", Offset = "0x107A9C8", VA = "0x107A9C8", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x1072F84", Offset = "0x1072F84", VA = "0x1072F84", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x10734B4", Offset = "0x10734B4", VA = "0x10734B4")]
		public UserControlThirdPerson()
		{
		}
	}
	[Token(Token = "0x2000142")]
	public class ApplicationQuit : MonoBehaviour
	{
		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x107B354", Offset = "0x107B354", VA = "0x107B354")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x107B38C", Offset = "0x107B38C", VA = "0x107B38C")]
		public ApplicationQuit()
		{
		}
	}
	[Token(Token = "0x2000143")]
	public class SlowMo : MonoBehaviour
	{
		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public KeyCode[] keyCodes;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool mouse0;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool mouse1;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float slowMoTimeScale;

		[Token(Token = "0x60008FE")]
		[Address(RVA = "0x107B394", Offset = "0x107B394", VA = "0x107B394")]
		private void Update()
		{
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x107B3BC", Offset = "0x107B3BC", VA = "0x107B3BC")]
		private bool IsSlowMotion()
		{
			return default(bool);
		}

		[Token(Token = "0x6000900")]
		[Address(RVA = "0x107B460", Offset = "0x107B460", VA = "0x107B460")]
		public SlowMo()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000144")]
	public class Navigator
	{
		[Token(Token = "0x2000145")]
		public enum State
		{
			[Token(Token = "0x40009D3")]
			Idle,
			[Token(Token = "0x40009D4")]
			Seeking,
			[Token(Token = "0x40009D5")]
			OnPath
		}

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[Tooltip("Should this Navigator be actively seeking a path.")]
		public bool activeTargetSeeking;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[Tooltip("Increase this value if the character starts running in a circle, not able to reach the corner because of a too large turning radius.")]
		public float cornerRadius;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Recalculate path if target position has moved by this distance from the position it was at when the path was originally calculated")]
		public float recalculateOnPathDistance;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[Tooltip("Sample within this distance from sourcePosition.")]
		public float maxSampleDistance;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("Interval of updating the path")]
		public float nextPathInterval;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform transform;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int cornerIndex;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Vector3[] corners;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private NavMeshPath path;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Vector3 lastTargetPosition;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private bool initiated;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float nextPathTime;

		[Token(Token = "0x17000143")]
		public Vector3 normalizedDeltaPosition
		{
			[Token(Token = "0x6000901")]
			[Address(RVA = "0x107B474", Offset = "0x107B474", VA = "0x107B474")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000902")]
			[Address(RVA = "0x107B480", Offset = "0x107B480", VA = "0x107B480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000144")]
		public State state
		{
			[Token(Token = "0x6000903")]
			[Address(RVA = "0x107B48C", Offset = "0x107B48C", VA = "0x107B48C")]
			[CompilerGenerated]
			get
			{
				return default(State);
			}
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x107B494", Offset = "0x107B494", VA = "0x107B494")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x107A9FC", Offset = "0x107A9FC", VA = "0x107A9FC")]
		public void Initiate(Transform transform)
		{
		}

		[Token(Token = "0x6000906")]
		[Address(RVA = "0x107ACF4", Offset = "0x107ACF4", VA = "0x107ACF4")]
		public void Update(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x107B574", Offset = "0x107B574", VA = "0x107B574")]
		private void CalculatePath(Vector3 targetPosition)
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x107B5D8", Offset = "0x107B5D8", VA = "0x107B5D8")]
		private bool Find(Vector3 targetPosition)
		{
			return default(bool);
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x107B49C", Offset = "0x107B49C", VA = "0x107B49C")]
		private void Stop()
		{
		}

		[Token(Token = "0x600090A")]
		[Address(RVA = "0x107B4F8", Offset = "0x107B4F8", VA = "0x107B4F8")]
		private float HorDistance(Vector3 p1, Vector3 p2)
		{
			return default(float);
		}

		[Token(Token = "0x600090B")]
		[Address(RVA = "0x107B174", Offset = "0x107B174", VA = "0x107B174")]
		public void Visualize()
		{
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0x107B70C", Offset = "0x107B70C", VA = "0x107B70C")]
		public Navigator()
		{
		}
	}
}
