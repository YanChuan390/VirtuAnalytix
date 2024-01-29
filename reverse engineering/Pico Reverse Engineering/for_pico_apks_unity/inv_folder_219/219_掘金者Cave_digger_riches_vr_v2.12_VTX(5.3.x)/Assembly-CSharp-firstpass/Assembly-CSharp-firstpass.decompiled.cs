using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using DigitalOpus.MB.Core;
using Facepunch.Steamworks;
using Il2CppDummyDll;
using Poly2Tri;
using UltimateFracturing;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class EGA_DemoLasers : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject FirePoint;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Camera Cam;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float MaxLength;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject[] Prefabs;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Ray RayMouse;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 direction;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Quaternion rotation;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xADDD14", Offset = "0xADDD14")]
	private float windowDpi;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int Prefab;

	[Token(Token = "0x400000A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject Instance;

	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private EGA_Laser LaserScript;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float buttonSaver;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x160182C", Offset = "0x160182C", VA = "0x160182C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x16018E4", Offset = "0x16018E4", VA = "0x16018E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x1601F70", Offset = "0x1601F70", VA = "0x1601F70")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x160189C", Offset = "0x160189C", VA = "0x160189C")]
	private void Counter(int count)
	{
	}

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x1601DF0", Offset = "0x1601DF0", VA = "0x1601DF0")]
	private void RotateToMouseDirection(GameObject obj, Vector3 destination)
	{
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x160207C", Offset = "0x160207C", VA = "0x160207C")]
	public EGA_DemoLasers()
	{
	}
}
[Token(Token = "0x2000003")]
public class EGA_Laser : MonoBehaviour
{
	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject HitEffect;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float HitOffset;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float MaxLength;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LineRenderer Laser;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float MainTextureLength;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float NoiseTextureLength;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LayerMask hitLayers;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector4 Length;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector4 LaserSpeed;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector4 LaserStartSpeed;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private bool LaserSaver;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6D")]
	private bool UpdateSaver;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private ParticleSystem[] Effects;

	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem[] Hit;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 _hitPos;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float _distance;

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1602084", Offset = "0x1602084", VA = "0x1602084")]
	private void Start()
	{
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1602194", Offset = "0x1602194", VA = "0x1602194")]
	private void Update()
	{
	}

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1602918", Offset = "0x1602918", VA = "0x1602918")]
	public Vector3 GetHitPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1602924", Offset = "0x1602924", VA = "0x1602924")]
	public float GetHitDistance()
	{
		return default(float);
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1601CEC", Offset = "0x1601CEC", VA = "0x1601CEC")]
	public void DisablePrepare()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x160292C", Offset = "0x160292C", VA = "0x160292C")]
	public EGA_Laser()
	{
	}
}
[Token(Token = "0x2000004")]
[ExecuteInEditMode]
public class DistanceTool : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string distanceToolName;

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEngine.Color lineColor;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool initialized;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string initialName;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 startPoint;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector3 endPoint;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float distance;

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public float gizmoRadius;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool scaleToPixels;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public int pixelPerUnit;

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1601668", Offset = "0x1601668", VA = "0x1601668")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x160166C", Offset = "0x160166C", VA = "0x160166C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x16016D0", Offset = "0x16016D0", VA = "0x16016D0")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1601734", Offset = "0x1601734", VA = "0x1601734")]
	public DistanceTool()
	{
	}
}
[Token(Token = "0x2000005")]
public class DecalDestroyer : MonoBehaviour
{
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD674", Offset = "0xADD674")]
	private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DecalDestroyer <>4__this;

		[Token(Token = "0x170000E4")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BA")]
			[Address(RVA = "0x141A18C", Offset = "0x141A18C", VA = "0x141A18C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E5")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007BC")]
			[Address(RVA = "0x141A1F4", Offset = "0x141A1F4", VA = "0x141A1F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x141A060", Offset = "0x141A060", VA = "0x141A060")]
		[DebuggerHidden]
		public <Start>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x141A09C", Offset = "0x141A09C", VA = "0x141A09C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x141A0A0", Offset = "0x141A0A0", VA = "0x141A0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x141A194", Offset = "0x141A194", VA = "0x141A194", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float lifeTime;

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1419FF0", Offset = "0x1419FF0", VA = "0x1419FF0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADED80", Offset = "0xADED80")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x141A08C", Offset = "0x141A08C", VA = "0x141A08C")]
	public DecalDestroyer()
	{
	}
}
[Token(Token = "0x2000006")]
public class ExtinguishableFire : MonoBehaviour
{
	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD684", Offset = "0xADD684")]
	private sealed class <Extinguishing>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExtinguishableFire <>4__this;

		[Token(Token = "0x40003C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x170000E6")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x1603400", Offset = "0x1603400", VA = "0x1603400", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E7")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x1603468", Offset = "0x1603468", VA = "0x1603468", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x1603114", Offset = "0x1603114", VA = "0x1603114")]
		[DebuggerHidden]
		public <Extinguishing>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x1603174", Offset = "0x1603174", VA = "0x1603174", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x1603178", Offset = "0x1603178", VA = "0x1603178", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x1603408", Offset = "0x1603408", VA = "0x1603408", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD694", Offset = "0xADD694")]
	private sealed class <StartingFire>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ExtinguishableFire <>4__this;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <elapsedTime>5__2;

		[Token(Token = "0x170000E8")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x1603654", Offset = "0x1603654", VA = "0x1603654", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x16036BC", Offset = "0x16036BC", VA = "0x16036BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x1603140", Offset = "0x1603140", VA = "0x1603140")]
		[DebuggerHidden]
		public <StartingFire>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x1603470", Offset = "0x1603470", VA = "0x1603470", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x1603474", Offset = "0x1603474", VA = "0x1603474", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x160365C", Offset = "0x160365C", VA = "0x160365C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleSystem fireParticleSystem;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParticleSystem smokeParticleSystem;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected bool m_isExtinguished;

	[Token(Token = "0x400002B")]
	private const float m_FireStartingTime = 2f;

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1602F98", Offset = "0x1602F98", VA = "0x1602F98")]
	private void Start()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1603064", Offset = "0x1603064", VA = "0x1603064")]
	public void Extinguish()
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x16030A4", Offset = "0x16030A4", VA = "0x16030A4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEDE4", Offset = "0xADEDE4")]
	private IEnumerator Extinguishing()
	{
		return null;
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1602FF4", Offset = "0x1602FF4", VA = "0x1602FF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEE48", Offset = "0xADEE48")]
	private IEnumerator StartingFire()
	{
		return null;
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x160316C", Offset = "0x160316C", VA = "0x160316C")]
	public ExtinguishableFire()
	{
	}
}
[Token(Token = "0x2000007")]
public class GunAim : MonoBehaviour
{
	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int borderLeft;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int borderRight;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int borderTop;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int borderBottom;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera parentCamera;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isOutOfBounds;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x160A3B0", Offset = "0x160A3B0", VA = "0x160A3B0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x160A408", Offset = "0x160A408", VA = "0x160A408")]
	private void Update()
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x160A514", Offset = "0x160A514", VA = "0x160A514")]
	public bool GetIsOutOfBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x160A51C", Offset = "0x160A51C", VA = "0x160A51C")]
	public GunAim()
	{
	}
}
[Token(Token = "0x2000008")]
public class GunShoot : MonoBehaviour
{
	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float fireRate;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float weaponRange;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform gunEnd;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ParticleSystem muzzleFlash;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ParticleSystem cartridgeEjection;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject metalHitEffect;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject sandHitEffect;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject stoneHitEffect;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject waterLeakEffect;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject waterLeakExtinguishEffect;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject[] fleshHitEffects;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject woodHitEffect;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float nextFire;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Animator anim;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private GunAim gunAim;

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x160A524", Offset = "0x160A524", VA = "0x160A524")]
	private void Start()
	{
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0x160A594", Offset = "0x160A594", VA = "0x160A594")]
	private void Update()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0x160A700", Offset = "0x160A700", VA = "0x160A700")]
	private void HandleHit(RaycastHit hit)
	{
	}

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x160AAFC", Offset = "0x160AAFC", VA = "0x160AAFC")]
	private void SpawnDecal(RaycastHit hit, GameObject prefab)
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x160AC68", Offset = "0x160AC68", VA = "0x160AC68")]
	public GunShoot()
	{
	}
}
[Token(Token = "0x2000009")]
public class ParticleCollision : MonoBehaviour
{
	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<ParticleCollisionEvent> m_CollisionEvents;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ParticleSystem m_ParticleSystem;

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x19FCA40", Offset = "0x19FCA40", VA = "0x19FCA40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0x19FCA98", Offset = "0x19FCA98", VA = "0x19FCA98")]
	private void OnParticleCollision(GameObject other)
	{
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0x19FCBE0", Offset = "0x19FCBE0", VA = "0x19FCBE0")]
	public ParticleCollision()
	{
	}
}
[Serializable]
[Token(Token = "0x200000A")]
public class ParticleExamples
{
	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string title;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TextAreaAttribute", RVA = "0xADDD4C", Offset = "0xADDD4C")]
	public string description;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isWeaponEffect;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject particleSystemGO;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 particlePosition;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector3 particleRotation;

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x19FCC50", Offset = "0x19FCC50", VA = "0x19FCC50")]
	public ParticleExamples()
	{
	}
}
[Token(Token = "0x200000B")]
public class ParticleMenu : MonoBehaviour
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ParticleExamples[] particleSystems;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject gunGameObject;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int currentIndex;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject currentGO;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform spawnLocation;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Text title;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Text description;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Text navigationDetails;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x19FCC58", Offset = "0x19FCC58", VA = "0x19FCC58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x19FCC80", Offset = "0x19FCC80", VA = "0x19FCC80")]
	public void Navigate(int i)
	{
	}

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x19FD038", Offset = "0x19FD038", VA = "0x19FD038")]
	public ParticleMenu()
	{
	}
}
[Token(Token = "0x200000C")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xADD204", Offset = "0xADD204")]
[AttributeAttribute(Name = "AddComponentMenu", RVA = "0xADD204", Offset = "0xADD204")]
public class FXAA : FXAAPostEffectsBase
{
	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Shader shader;

	[Token(Token = "0x4000052")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material mat;

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x16036C4", Offset = "0x16036C4", VA = "0x16036C4")]
	private void CreateMaterials()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x1603AE0", Offset = "0x1603AE0", VA = "0x1603AE0")]
	private void Start()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x1603C28", Offset = "0x1603C28", VA = "0x1603C28")]
	public void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x1603D84", Offset = "0x1603D84", VA = "0x1603D84")]
	public FXAA()
	{
	}
}
[Token(Token = "0x200000D")]
[ExecuteInEditMode]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xADD29C", Offset = "0xADD29C")]
public class FXAAPostEffectsBase : MonoBehaviour
{
	[Token(Token = "0x4000053")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected bool supportHDRTextures;

	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	protected bool isSupported;

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x160374C", Offset = "0x160374C", VA = "0x160374C")]
	public Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x1603DD0", Offset = "0x1603DD0", VA = "0x1603DD0")]
	private Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x1603FC0", Offset = "0x1603FC0", VA = "0x1603FC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x1603FCC", Offset = "0x1603FCC", VA = "0x1603FCC")]
	private bool CheckSupport()
	{
		return default(bool);
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x1603FD4", Offset = "0x1603FD4", VA = "0x1603FD4")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[Token(Token = "0x6000031")]
	[Address(RVA = "0x1604084", Offset = "0x1604084", VA = "0x1604084")]
	private void Start()
	{
	}

	[Token(Token = "0x6000032")]
	[Address(RVA = "0x1603B48", Offset = "0x1603B48", VA = "0x1603B48")]
	public bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0x1604088", Offset = "0x1604088", VA = "0x1604088")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0x16040E4", Offset = "0x16040E4", VA = "0x16040E4")]
	private void ReportAutoDisable()
	{
	}

	[Token(Token = "0x6000035")]
	[Address(RVA = "0x160418C", Offset = "0x160418C", VA = "0x160418C")]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0x1603DA4", Offset = "0x1603DA4", VA = "0x1603DA4")]
	private void NotSupported()
	{
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0x160438C", Offset = "0x160438C", VA = "0x160438C")]
	private void DrawBorder(RenderTexture dest, Material material)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0x1603D94", Offset = "0x1603D94", VA = "0x1603D94")]
	public FXAAPostEffectsBase()
	{
	}
}
[Token(Token = "0x200000E")]
public class SteamAvatar : MonoBehaviour
{
	[Token(Token = "0x20000C4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6A4", Offset = "0xADD6A4")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SteamAvatar <>4__this;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ulong steamid;

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x1B4A03C", Offset = "0x1B4A03C", VA = "0x1B4A03C")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x1B4A2C4", Offset = "0x1B4A2C4", VA = "0x1B4A2C4")]
		internal void <Fetch>b__0(Facepunch.Steamworks.Image i)
		{
		}
	}

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ulong SteamId;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Friends.AvatarSize Size;

	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture FallbackTexture;

	[Token(Token = "0x6000039")]
	[Address(RVA = "0x1B49EC8", Offset = "0x1B49EC8", VA = "0x1B49EC8")]
	private void Start()
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0x1B49ED8", Offset = "0x1B49ED8", VA = "0x1B49ED8")]
	public void Fetch(ulong steamid)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0x1B4A104", Offset = "0x1B4A104", VA = "0x1B4A104")]
	private void OnImage(Facepunch.Steamworks.Image image, ulong steamid)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0x1B4A044", Offset = "0x1B4A044", VA = "0x1B4A044")]
	private void ApplyTexture(Texture texture)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x1B4A2BC", Offset = "0x1B4A2BC", VA = "0x1B4A2BC")]
	public SteamAvatar()
	{
	}
}
[Token(Token = "0x200000F")]
public class SteamClient : MonoBehaviour
{
	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public uint AppId;

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x1B4A2E4", Offset = "0x1B4A2E4", VA = "0x1B4A2E4")]
	public SteamClient()
	{
	}
}
[Token(Token = "0x2000010")]
public class LogicArcsAndColumns : MonoBehaviour
{
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x160AC7C", Offset = "0x160AC7C", VA = "0x160AC7C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x160AC80", Offset = "0x160AC80", VA = "0x160AC80")]
	private void Update()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x160AC84", Offset = "0x160AC84", VA = "0x160AC84")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x160B5D8", Offset = "0x160B5D8", VA = "0x160B5D8")]
	public LogicArcsAndColumns()
	{
	}
}
[Token(Token = "0x2000011")]
public class LogicCollidingSphere : MonoBehaviour
{
	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody ObjectToDrop;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool bDropped;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int nChunksDetached;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int nChunkCollisions;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x160B5E0", Offset = "0x160B5E0", VA = "0x160B5E0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x160B5E8", Offset = "0x160B5E8", VA = "0x160B5E8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x160B650", Offset = "0x160B650", VA = "0x160B650")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x160BE74", Offset = "0x160BE74", VA = "0x160BE74")]
	private void OnChunkDetach(FracturedChunk.CollisionInfo info)
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x160BE98", Offset = "0x160BE98", VA = "0x160BE98")]
	private void OnFreeChunkCollision(FracturedChunk.CollisionInfo info)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x160BEBC", Offset = "0x160BEBC", VA = "0x160BEBC")]
	public LogicCollidingSphere()
	{
	}
}
[Token(Token = "0x2000012")]
public class LogicCompoundObject : MonoBehaviour
{
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x160BEC4", Offset = "0x160BEC4", VA = "0x160BEC4")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004A")]
	[Address(RVA = "0x160C684", Offset = "0x160C684", VA = "0x160C684")]
	public LogicCompoundObject()
	{
	}
}
[Token(Token = "0x2000013")]
public class LogicExplodingFloor : MonoBehaviour
{
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x160C68C", Offset = "0x160C68C", VA = "0x160C68C")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x160CA5C", Offset = "0x160CA5C", VA = "0x160CA5C")]
	public LogicExplodingFloor()
	{
	}
}
[Token(Token = "0x2000014")]
public class LogicExplodingGoblin : MonoBehaviour
{
	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float ExplosionForce;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FracturedObject TargetFracturedObject;

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x160CA64", Offset = "0x160CA64", VA = "0x160CA64")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x160CFFC", Offset = "0x160CFFC", VA = "0x160CFFC")]
	public LogicExplodingGoblin()
	{
	}
}
[Token(Token = "0x2000015")]
public class LogicGlobalFracturing : MonoBehaviour
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[HideInInspector]
	public static bool HelpVisible;

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x160D00C", Offset = "0x160D00C", VA = "0x160D00C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x160B320", Offset = "0x160B320", VA = "0x160B320")]
	public static void GlobalGUI()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x160D078", Offset = "0x160D078", VA = "0x160D078")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x160D174", Offset = "0x160D174", VA = "0x160D174")]
	public LogicGlobalFracturing()
	{
	}
}
[Token(Token = "0x2000016")]
public class UltimateFracturingFPS : MonoBehaviour
{
	[Token(Token = "0x20000C5")]
	public enum Mode
	{
		[Token(Token = "0x40003C9")]
		ShootObjects,
		[Token(Token = "0x40003CA")]
		ExplodeRaycast
	}

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Mode ShootMode;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float MouseSpeed;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture HUDTexture;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float HUDSize;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public UnityEngine.Color HUDColorNormal;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public UnityEngine.Color HUDColorRaycast;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform Weapon;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AudioClip AudioWeaponShot;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float WeaponShotVolume;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float ExplosionForce;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float ExplosionRadius;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float RecoilDuration;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float RecoilIntensity;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject ObjectToShoot;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float InitialObjectSpeed;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public float ObjectScale;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public float ObjectMass;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float ObjectLife;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Vector3 m_v3MousePosition;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private bool m_bRaycastFound;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_fRecoilTimer;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Vector3 m_v3InitialWeaponPos;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Quaternion m_qInitialWeaponRot;

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x208A768", Offset = "0x208A768", VA = "0x208A768")]
	private void Start()
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x208A828", Offset = "0x208A828", VA = "0x208A828")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x208AA74", Offset = "0x208AA74", VA = "0x208AA74")]
	private void Update()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x208B214", Offset = "0x208B214", VA = "0x208B214")]
	public UltimateFracturingFPS()
	{
	}
}
[Token(Token = "0x2000017")]
public class CheckDynamicCollision : MonoBehaviour
{
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x140D584", Offset = "0x140D584", VA = "0x140D584")]
	private void Start()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x140D878", Offset = "0x140D878", VA = "0x140D878")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x140D758", Offset = "0x140D758", VA = "0x140D758")]
	private void EnableObjectColliders(GameObject chunk, bool bEnable)
	{
	}

	[Token(Token = "0x600005B")]
	private static void SearchForAllComponentsInHierarchy<T>(GameObject current, ref List<T> listOut) where T : Component
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x140DB60", Offset = "0x140DB60", VA = "0x140DB60")]
	public CheckDynamicCollision()
	{
	}
}
[Token(Token = "0x2000018")]
public class ExplosionSource : MonoBehaviour
{
	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float InfluenceRadius;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float Force;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool CheckStructureIntegrity;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool MoveManually;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 PosStart;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 PosEnd;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float MoveDuration;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private FracturedObject[] m_aFracturedObjects;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float m_fStartTime;

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x16029B4", Offset = "0x16029B4", VA = "0x16029B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x1602A80", Offset = "0x1602A80", VA = "0x1602A80")]
	private void Update()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x1602F80", Offset = "0x1602F80", VA = "0x1602F80")]
	public ExplosionSource()
	{
	}
}
[Serializable]
[Token(Token = "0x2000019")]
[ExecuteInEditMode]
public class FracturedChunk : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000C6")]
	public class AdjacencyInfo
	{
		[Token(Token = "0x40003CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		[Token(Token = "0x40003CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float fArea;

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x16066CC", Offset = "0x16066CC", VA = "0x16066CC")]
		public AdjacencyInfo(FracturedChunk chunk, float fArea)
		{
		}
	}

	[Token(Token = "0x20000C7")]
	public class CollisionInfo
	{
		[Token(Token = "0x40003CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FracturedChunk chunk;

		[Token(Token = "0x40003CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 collisionPoint;

		[Token(Token = "0x40003CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool bIsMain;

		[Token(Token = "0x40003D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
		public bool bCancelCollisionEvent;

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x16053AC", Offset = "0x16053AC", VA = "0x16053AC")]
		public CollisionInfo(FracturedChunk chunk, Vector3 collisionPoint, bool bIsMain)
		{
		}
	}

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FracturedObject FracturedObjectSource;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int SplitSubMeshIndex;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public bool DontDeleteAfterBroken;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	public bool IsSupportChunk;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	public bool IsNonSupportedChunk;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
	public bool IsDetachedChunk;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float RelativeVolume;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float Volume;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool HasConcaveCollider;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float PreviewDecompositionValue;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UnityEngine.Color RandomMaterialColor;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool Visited;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<AdjacencyInfo> ListAdjacentChunks;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Vector3 m_v3InitialLocalPosition;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[SerializeField]
	private Quaternion m_qInitialLocalRotation;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[SerializeField]
	private Vector3 m_v3InitialLocalScale;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool m_bInitialLocalRotScaleInitialized;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private List<AdjacencyInfo> ListAdjacentChunksCopy;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float m_fInvisibleTimer;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private bool m_bNonSupportedChunkStored;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Rigidbody myRigidbody;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Renderer myRenderer;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Collider myCollider;

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x1604708", Offset = "0x1604708", VA = "0x1604708")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x16048D4", Offset = "0x16048D4", VA = "0x16048D4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x1604B48", Offset = "0x1604B48", VA = "0x1604B48")]
	private void HandleCollision(Collider other, Vector3 v3CollisionPos, float relativeSpeed)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x160530C", Offset = "0x160530C", VA = "0x160530C")]
	public bool IsDestructibleChunk()
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x1605944", Offset = "0x1605944", VA = "0x1605944")]
	public void ResetChunk(FracturedObject fracturedObjectSource)
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x1605AAC", Offset = "0x1605AAC", VA = "0x1605AAC")]
	public void Impact(Vector3 v3Position, float fExplosionForce, float fRadius, bool bAlsoImpactFreeChunks)
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x1606160", Offset = "0x1606160", VA = "0x1606160")]
	public void OnCreateFromFracturedObject(FracturedObject fracturedComponent, int nSplitSubMeshIndex)
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x160624C", Offset = "0x160624C", VA = "0x160624C")]
	public void UpdatePreviewDecompositionPosition()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0x16063B4", Offset = "0x16063B4", VA = "0x16063B4")]
	public void ConnectTo(FracturedChunk chunk, float fArea)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0x1606708", Offset = "0x1606708", VA = "0x1606708")]
	public void DisconnectFrom(FracturedChunk chunk)
	{
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x16064E8", Offset = "0x16064E8", VA = "0x16064E8")]
	public bool IsConnectedTo(FracturedChunk chunk)
	{
		return default(bool);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x16055B8", Offset = "0x16055B8", VA = "0x16055B8")]
	public void DetachFromObject(bool bCheckStructureIntegrity = true)
	{
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0x16068DC", Offset = "0x16068DC", VA = "0x16068DC")]
	private void RemoveConnectionInfo()
	{
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x16054F0", Offset = "0x16054F0", VA = "0x16054F0")]
	public List<FracturedChunk> ComputeRandomConnectionBreaks()
	{
		return null;
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0x1606F34", Offset = "0x1606F34", VA = "0x1606F34")]
	private static void ComputeRandomConnectionBreaksRecursive(FracturedChunk chunk, List<FracturedChunk> listBreaksOut, int nLevel)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0x1607198", Offset = "0x1607198", VA = "0x1607198")]
	public static FracturedChunk ChunkRaycast(Vector3 v3Pos, Vector3 v3Forward, out RaycastHit hitInfo)
	{
		return null;
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x160732C", Offset = "0x160732C", VA = "0x160732C")]
	public FracturedChunk()
	{
	}
}
[Token(Token = "0x200001A")]
[ExecuteInEditMode]
public class FracturedObject : MonoBehaviour
{
	[Token(Token = "0x20000C8")]
	public enum EFracturePattern
	{
		[Token(Token = "0x40003D2")]
		BSP,
		[Token(Token = "0x40003D3")]
		Voronoi
	}

	[Token(Token = "0x20000C9")]
	public enum ColliderType
	{
		[Token(Token = "0x40003D5")]
		Collider,
		[Token(Token = "0x40003D6")]
		Trigger
	}

	[Serializable]
	[Token(Token = "0x20000CA")]
	public class PrefabInfo
	{
		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float MinLifeTime;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float MaxLifeTime;

		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject GameObject;

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x160A370", Offset = "0x160A370", VA = "0x160A370")]
		public PrefabInfo()
		{
		}
	}

	[Token(Token = "0x20000CB")]
	public enum ECCAlgorithm
	{
		[Token(Token = "0x40003DB")]
		Fast,
		[Token(Token = "0x40003DC")]
		Normal,
		[Token(Token = "0x40003DD")]
		Legacy
	}

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool GUIExpandMain;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject SourceObject;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool GenerateIslands;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	public bool GenerateChunkConnectionInfo;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	public bool StartStatic;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float ChunkConnectionMinArea;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float ChunkConnectionStrength;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public float ChunkHorizontalRadiusSupportStrength;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool SupportChunksAreIndestructible;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float ChunkIslandConnectionMaxDistance;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float TotalMass;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public PhysicMaterial ChunkPhysicMaterial;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public float MinColliderVolumeForBox;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public float CapPrecisionFix;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool InvertCapNormals;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public ColliderType ChunkColliderType;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool GUIExpandSplits;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public EFracturePattern FracturePattern;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool VoronoiVolumeOptimization;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool VoronoiProximityOptimization;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	public bool VoronoiMultithreading;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int VoronoiCellsXCount;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public int VoronoiCellsYCount;

	[Token(Token = "0x40000AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public int VoronoiCellsZCount;

	[Token(Token = "0x40000AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public float VoronoiCellsXSizeVariation;

	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	public float VoronoiCellsYSizeVariation;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public float VoronoiCellsZSizeVariation;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	public int GenerateNumChunks;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public bool SplitsWorldSpace;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	public bool SplitRegularly;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	public float SplitXProbability;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public float SplitYProbability;

	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	public float SplitZProbability;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public float SplitSizeVariation;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	public float SplitXVariation;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public float SplitYVariation;

	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float SplitZVariation;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Material SplitMaterial;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public float SplitMappingTileU;

	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	public float SplitMappingTileV;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public bool GUIExpandEvents;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	public float EventDetachMinMass;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float EventDetachMinVelocity;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	public float EventDetachExitForce;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public float EventDetachUpwardsModifier;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AudioClip EventDetachSound;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public PrefabInfo[] EventDetachPrefabsArray;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public string EventDetachCollisionCallMethod;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject EventDetachCollisionCallGameObject;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public float EventDetachedMinLifeTime;

	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	public float EventDetachedMaxLifeTime;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public float EventDetachedOffscreenLifeTime;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	public float EventDetachedMinMass;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public float EventDetachedMinVelocity;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	public int EventDetachedMaxSounds;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public AudioClip[] EventDetachedSoundArray;

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public int EventDetachedMaxPrefabs;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public PrefabInfo[] EventDetachedPrefabsArray;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public string EventDetachedCollisionCallMethod;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject EventDetachedCollisionCallGameObject;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public AudioClip EventExplosionSound;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public int EventExplosionPrefabsInstanceCount;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public PrefabInfo[] EventExplosionPrefabsArray;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public AudioClip EventImpactSound;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public PrefabInfo[] EventImpactPrefabsArray;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public string EventDetachedAnyCallMethod;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject EventDetachedAnyCallGameObject;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public bool GUIExpandSupportPlanes;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16C")]
	public int RandomSeed;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public float DecomposePreview;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
	public bool AlwaysComputeColliders;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x175")]
	public bool ShowChunkConnectionLines;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x176")]
	public bool ShowChunkColoredState;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x177")]
	public bool ShowChunkColoredRandomly;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public bool SaveMeshDataToAsset;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public string MeshAssetDataFile;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public bool Verbose;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x189")]
	public bool IntegrateWithConcaveCollider;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18C")]
	public ECCAlgorithm ConcaveColliderAlgorithm;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public int ConcaveColliderMaxHulls;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	public int ConcaveColliderMaxHullVertices;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public int ConcaveColliderLegacySteps;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Rigidbody fracturableRigidbody;

	[Token(Token = "0x40000EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	[HideInInspector]
	public List<SupportPlane> ListSupportPlanes;

	[Token(Token = "0x40000EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	[HideInInspector]
	public List<FracturedChunk> ListFracturedChunks;

	[Token(Token = "0x40000EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[HideInInspector]
	public GameObject SingleMeshObject;

	[Token(Token = "0x40000ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	[HideInInspector]
	public bool IsUsingSingleMeshObjectDraw;

	[Token(Token = "0x40000EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
	[HideInInspector]
	public float DecomposeRadius;

	[Token(Token = "0x40000EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UnityEngine.Color GizmoColorSupport;

	[Token(Token = "0x40000F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static UnityEngine.Color GizmoColorNonSupport;

	[Token(Token = "0x40000F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	private bool m_bCheckDetachNonSupportedChunkds;

	[Token(Token = "0x40000F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C9")]
	private bool m_bExploded;

	[Token(Token = "0x40000F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1CA")]
	private bool m_bDetached;

	[Token(Token = "0x40000F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	private float[] m_afFreeChunkSoundTimers;

	[Token(Token = "0x40000F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	private float[] m_afFreeChunkPrefabTimers;

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public bool singleMeshColliders;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E1")]
	public bool singleMeshColliderConvex;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E2")]
	public bool singleMeshRigibdody;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public GameObject skinnedMesh;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	private Material m_GizmosMaterial;

	[Token(Token = "0x17000001")]
	public Material GizmosMaterial
	{
		[Token(Token = "0x6000071")]
		[Address(RVA = "0x16073C0", Offset = "0x16073C0", VA = "0x16073C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000072")]
		[Address(RVA = "0x160748C", Offset = "0x160748C", VA = "0x160748C")]
		set
		{
		}
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x1607494", Offset = "0x1607494", VA = "0x1607494")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x16074F4", Offset = "0x16074F4", VA = "0x16074F4")]
	public void CacheChunkComponents()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x1607730", Offset = "0x1607730", VA = "0x1607730")]
	private void Start()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x1607D7C", Offset = "0x1607D7C", VA = "0x1607D7C")]
	public void OnCreateFracturedObject()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x160793C", Offset = "0x160793C", VA = "0x160793C")]
	public void SetSingleMeshVisibility(bool bEnabled)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x1607E60", Offset = "0x1607E60", VA = "0x1607E60")]
	public bool ResetChunks()
	{
		return default(bool);
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0x1605E20", Offset = "0x1605E20", VA = "0x1605E20")]
	public List<FracturedChunk> GetDestructibleChunksInRadius(Vector3 v3Position, float fRadius, bool bAlsoIncludeFreeChunks)
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0x16080F4", Offset = "0x16080F4", VA = "0x16080F4")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce)
	{
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x1602C34", Offset = "0x1602C34", VA = "0x1602C34")]
	public void Explode(Vector3 v3ExplosionPosition, float fExplosionForce, float fRadius, bool bPlayExplosionSound, bool bInstanceExplosionPrefabs, bool bAlsoExplodeFree, bool bCheckStructureIntegrityAfter)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x16084AC", Offset = "0x16084AC", VA = "0x16084AC")]
	public void DeleteChunks()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x160868C", Offset = "0x160868C", VA = "0x160868C")]
	public void CollapseChunks()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0x1608814", Offset = "0x1608814", VA = "0x1608814")]
	public void ExplodeChunks(float fExplosionForce, Vector3 v3ExplosionPosition, float fUpwardsModifier)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1608A18", Offset = "0x1608A18", VA = "0x1608A18")]
	public void ComputeChunksRelativeVolume()
	{
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x1608EF4", Offset = "0x1608EF4", VA = "0x1608EF4")]
	public void ComputeChunksMass(float fTotalMass)
	{
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x16090D0", Offset = "0x16090D0", VA = "0x16090D0")]
	public bool HasDetachedChunks()
	{
		return default(bool);
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x1606BB8", Offset = "0x1606BB8", VA = "0x1606BB8")]
	public void NotifyChunkDetach(FracturedChunk chunk)
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x1605414", Offset = "0x1605414", VA = "0x1605414")]
	public void NotifyDetachChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x16090D8", Offset = "0x16090D8", VA = "0x16090D8")]
	public void NotifyDetachChunkCollision(Vector3 v3Position, bool bIsMain)
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1605710", Offset = "0x1605710", VA = "0x1605710")]
	public void NotifyFreeChunkCollision(FracturedChunk.CollisionInfo collisionInfo)
	{
	}

	[Token(Token = "0x6000086")]
	[Address(RVA = "0x16060A4", Offset = "0x16060A4", VA = "0x16060A4")]
	public void NotifyImpact(Vector3 v3Position)
	{
	}

	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1606E04", Offset = "0x1606E04", VA = "0x1606E04")]
	public void ResetAllChunkVisitedFlags()
	{
	}

	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1606DEC", Offset = "0x1606DEC", VA = "0x1606DEC")]
	public void CheckDetachNonSupportedChunks(bool bForceImmediate = false)
	{
	}

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x16099FC", Offset = "0x16099FC", VA = "0x16099FC")]
	public void MarkNonSupportedChunks()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x16091A8", Offset = "0x16091A8", VA = "0x16091A8")]
	private void CheckDetachNonSupportedChunksInternal(bool bOnlyMarkThem = false)
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x1609B38", Offset = "0x1609B38", VA = "0x1609B38")]
	private static bool AreSupportedChunksRecursive(FracturedChunk chunk, List<FracturedChunk> listChunksVisited, List<FracturedChunk> listChunksSupport)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1609DB4", Offset = "0x1609DB4", VA = "0x1609DB4")]
	public void AddSupportPlane()
	{
	}

	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1609E68", Offset = "0x1609E68", VA = "0x1609E68")]
	public void ComputeSupportPlaneIntersections()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x160A100", Offset = "0x160A100", VA = "0x160A100")]
	public FracturedObject()
	{
	}
}
[Serializable]
[Token(Token = "0x200001B")]
public class MB_AtlasesAndRects
{
	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Texture2D[] atlases;

	[NonSerialized]
	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<MB_MaterialAndUVRect> mat2rect_map;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] texPropertyNames;

	[Token(Token = "0x6000090")]
	[Address(RVA = "0x16181B4", Offset = "0x16181B4", VA = "0x16181B4")]
	public MB_AtlasesAndRects()
	{
	}
}
[Serializable]
[Token(Token = "0x200001C")]
public class MB_MultiMaterial
{
	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material combinedMaterial;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool considerMeshUVs;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<Material> sourceMaterials;

	[Token(Token = "0x6000091")]
	[Address(RVA = "0x160E220", Offset = "0x160E220", VA = "0x160E220")]
	public MB_MultiMaterial()
	{
	}
}
[Serializable]
[Token(Token = "0x200001D")]
public class MB_MaterialAndUVRect
{
	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rect atlasRect;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string srcObjName;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool allPropsUseSameTiling;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xADDDFC", Offset = "0xADDDFC")]
	public Rect allPropsUseSameTiling_sourceMaterialTiling;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xADDE34", Offset = "0xADDE34")]
	public Rect allPropsUseSameTiling_samplingEncapsulatinRect;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public Rect propsUseDifferntTiling_srcUVsamplingRect;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public MB_TextureTilingTreatment tilingTreatment;

	[Token(Token = "0x6000092")]
	[Address(RVA = "0x160E140", Offset = "0x160E140", VA = "0x160E140")]
	public MB_MaterialAndUVRect(Material mat, Rect destRect, bool allPropsUseSameTiling, Rect sourceMaterialTiling, Rect samplingEncapsulatingRect, Rect srcUVsamplingRect, MB_TextureTilingTreatment treatment, string objName)
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0x16186D4", Offset = "0x16186D4", VA = "0x16186D4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x1618734", Offset = "0x1618734", VA = "0x1618734", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x160F6E0", Offset = "0x160F6E0", VA = "0x160F6E0")]
	public Rect GetEncapsulatingRect()
	{
		return default(Rect);
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x160F720", Offset = "0x160F720", VA = "0x160F720")]
	public Rect GetMaterialTilingRect()
	{
		return default(Rect);
	}
}
[Token(Token = "0x200001E")]
public class MB2_TextureBakeResults : ScriptableObject
{
	[Token(Token = "0x20000CC")]
	public class Material2AtlasRectangleMapper
	{
		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private MB2_TextureBakeResults tbr;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int[] numTimesMatAppearsInAtlas;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MB_MaterialAndUVRect[] matsAndSrcUVRect;

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x160EB8C", Offset = "0x160EB8C", VA = "0x160EB8C")]
		public Material2AtlasRectangleMapper(MB2_TextureBakeResults res)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x160EDEC", Offset = "0x160EDEC", VA = "0x160EDEC")]
		public bool TryMapMaterialToUVRect(Material mat, Mesh m, int submeshIdx, int idxInResultMats, MB3_MeshCombinerSingle.MeshChannelsCache meshChannelCache, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisCache, out MB_TextureTilingTreatment tilingTreatment, out Rect rectInAtlas, out Rect encapsulatingRectOut, out Rect sourceMaterialTilingOut, ref string errorMsg, MB2_LogLevel logLevel)
		{
			return default(bool);
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x160F670", Offset = "0x160F670", VA = "0x160F670")]
		private void UpgradeToCurrentVersion(MB2_TextureBakeResults tbr)
		{
		}
	}

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int version;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MB_MaterialAndUVRect[] materialsAndUVRects;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool doMultiMaterial;

	[Token(Token = "0x17000002")]
	public static int VERSION
	{
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x160D9D8", Offset = "0x160D9D8", VA = "0x160D9D8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x160D9E0", Offset = "0x160D9E0", VA = "0x160D9E0")]
	public MB2_TextureBakeResults()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x160DA0C", Offset = "0x160DA0C", VA = "0x160DA0C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x160DA80", Offset = "0x160DA80", VA = "0x160DA80")]
	public static MB2_TextureBakeResults CreateForMaterialsOnRenderer(GameObject[] gos, List<Material> matsOnTargetRenderer)
	{
		return null;
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x160E290", Offset = "0x160E290", VA = "0x160E290")]
	public bool DoAnyResultMatsUseConsiderMeshUVs()
	{
		return default(bool);
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x160E2FC", Offset = "0x160E2FC", VA = "0x160E2FC")]
	public bool ContainsMaterial(Material m)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x160E3DC", Offset = "0x160E3DC", VA = "0x160E3DC")]
	public string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0x160E770", Offset = "0x160E770", VA = "0x160E770")]
	public static bool IsMeshAndMaterialRectEnclosedByAtlasRect(MB_TextureTilingTreatment tilingTreatment, Rect uvR, Rect sourceMaterialTiling, Rect samplingEncapsulatinRect, MB2_LogLevel logLevel)
	{
		return default(bool);
	}
}
[Token(Token = "0x200001F")]
public class MB2_UpdateSkinnedMeshBoundsFromBones : MonoBehaviour
{
	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform[] bones;

	[Token(Token = "0x600009F")]
	[Address(RVA = "0x160F78C", Offset = "0x160F78C", VA = "0x160F78C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0x160F8B0", Offset = "0x160F8B0", VA = "0x160F8B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0x160F93C", Offset = "0x160F93C", VA = "0x160F93C")]
	public MB2_UpdateSkinnedMeshBoundsFromBones()
	{
	}
}
[Token(Token = "0x2000020")]
public class MB2_UpdateSkinnedMeshBoundsFromBounds : MonoBehaviour
{
	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<GameObject> objects;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private SkinnedMeshRenderer smr;

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0x160F944", Offset = "0x160F944", VA = "0x160F944")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0x160FC20", Offset = "0x160FC20", VA = "0x160FC20")]
	private void Update()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0x160FCB4", Offset = "0x160FCB4", VA = "0x160FCB4")]
	public MB2_UpdateSkinnedMeshBoundsFromBounds()
	{
	}
}
[Token(Token = "0x2000021")]
public class MB3_BatchPrefabBaker : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000CD")]
	public class MB3_PrefabBakerRow
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject sourcePrefab;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject resultPrefab;

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x1611038", Offset = "0x1611038", VA = "0x1611038")]
		public MB3_PrefabBakerRow()
		{
		}
	}

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MB3_PrefabBakerRow[] prefabRows;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string outputPrefabFolder;

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0x1611028", Offset = "0x1611028", VA = "0x1611028")]
	public MB3_BatchPrefabBaker()
	{
	}
}
[Token(Token = "0x2000022")]
public class MB3_BoneWeightCopier : MonoBehaviour
{
	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject inputGameObject;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject outputPrefab;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float radius;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public SkinnedMeshRenderer seamMesh;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string outputFolder;

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0x1611040", Offset = "0x1611040", VA = "0x1611040")]
	public MB3_BoneWeightCopier()
	{
	}
}
[Token(Token = "0x2000023")]
public class MB3_DisableHiddenAnimations : MonoBehaviour
{
	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<Animation> animationsToCull;

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0x1611054", Offset = "0x1611054", VA = "0x1611054")]
	private void Start()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0x1611154", Offset = "0x1611154", VA = "0x1611154")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0x1611254", Offset = "0x1611254", VA = "0x1611254")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0x1611354", Offset = "0x1611354", VA = "0x1611354")]
	public MB3_DisableHiddenAnimations()
	{
	}
}
[Token(Token = "0x2000024")]
public class MB3_MeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected MB3_MeshCombinerSingle _meshCombiner;

	[Token(Token = "0x17000003")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x16122FC", Offset = "0x16122FC", VA = "0x16122FC", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AC")]
	[Address(RVA = "0x1612304", Offset = "0x1612304", VA = "0x1612304")]
	public void BuildSceneMeshObject()
	{
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1612328", Offset = "0x1612328", VA = "0x1612328", Slot = "23")]
	public virtual bool ShowHide(GameObject[] gos, GameObject[] deleteGOs)
	{
		return default(bool);
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x1612344", Offset = "0x1612344", VA = "0x1612344", Slot = "24")]
	public virtual void ApplyShowHide()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x1612368", Offset = "0x1612368", VA = "0x1612368", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x1612414", Offset = "0x1612414", VA = "0x1612414", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x16124C0", Offset = "0x16124C0", VA = "0x16124C0")]
	public MB3_MeshBaker()
	{
	}
}
[Token(Token = "0x2000025")]
public abstract class MB3_MeshBakerCommon : MB3_MeshBakerRoot
{
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool useObjsToMeshFromTexBaker;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool clearBuffersAfterBake;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string bakeAssetsInPlaceFolderPath;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public GameObject resultPrefab;

	[Token(Token = "0x17000004")]
	public abstract MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x60000B2")]
		get;
	}

	[Token(Token = "0x17000005")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x1612594", Offset = "0x1612594", VA = "0x1612594", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x16125C0", Offset = "0x16125C0", VA = "0x16125C0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x1612600", Offset = "0x1612600", VA = "0x1612600", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x16127C8", Offset = "0x16127C8", VA = "0x16127C8")]
	public void EnableDisableSourceObjectRenderers(bool show)
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x1612A9C", Offset = "0x1612A9C", VA = "0x1612A9C", Slot = "8")]
	public virtual void ClearMesh()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x1612ACC", Offset = "0x1612ACC", VA = "0x1612ACC", Slot = "9")]
	public virtual void DestroyMesh()
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x1612AFC", Offset = "0x1612AFC", VA = "0x1612AFC", Slot = "10")]
	public virtual void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x1612B40", Offset = "0x1612B40", VA = "0x1612B40", Slot = "11")]
	public virtual int GetNumObjectsInCombined()
	{
		return default(int);
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x1612B70", Offset = "0x1612B70", VA = "0x1612B70", Slot = "12")]
	public virtual int GetNumVerticesFor(GameObject go)
	{
		return default(int);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x1612BB4", Offset = "0x1612BB4", VA = "0x1612BB4")]
	public MB3_TextureBaker GetTextureBaker()
	{
		return null;
	}

	[Token(Token = "0x60000BD")]
	public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

	[Token(Token = "0x60000BE")]
	public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true);

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x1612CCC", Offset = "0x1612CCC", VA = "0x1612CCC", Slot = "15")]
	public virtual void Apply([Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x1612D7C", Offset = "0x1612D7C", VA = "0x1612D7C", Slot = "16")]
	public virtual void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, [Optional] MB3_MeshCombiner.GenerateUV2Delegate uv2GenerationMethod)
	{
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x1612EC4", Offset = "0x1612EC4", VA = "0x1612EC4", Slot = "17")]
	public virtual bool CombinedMeshContains(GameObject go)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C2")]
	[Address(RVA = "0x1612F08", Offset = "0x1612F08", VA = "0x1612F08", Slot = "18")]
	public virtual void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV1 = false, bool updateUV2 = false, bool updateColors = false, bool updateSkinningInfo = false)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x1613038", Offset = "0x1613038", VA = "0x1613038", Slot = "19")]
	public virtual void UpdateSkinnedMeshApproximateBounds()
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x1613098", Offset = "0x1613098", VA = "0x1613098", Slot = "20")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBones()
	{
	}

	[Token(Token = "0x60000C5")]
	[Address(RVA = "0x16130F8", Offset = "0x16130F8", VA = "0x16130F8", Slot = "21")]
	public virtual void UpdateSkinnedMeshApproximateBoundsFromBounds()
	{
	}

	[Token(Token = "0x60000C6")]
	[Address(RVA = "0x1613158", Offset = "0x1613158", VA = "0x1613158", Slot = "22")]
	protected virtual bool _ValidateForUpdateSkinnedMeshBounds()
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x1612524", Offset = "0x1612524", VA = "0x1612524")]
	protected MB3_MeshBakerCommon()
	{
	}
}
[Token(Token = "0x2000026")]
public class MB3_MeshBakerGrouper : MonoBehaviour
{
	[Token(Token = "0x20000CE")]
	public enum ClusterType
	{
		[Token(Token = "0x40003E4")]
		none,
		[Token(Token = "0x40003E5")]
		grid,
		[Token(Token = "0x40003E6")]
		pie,
		[Token(Token = "0x40003E7")]
		agglomerative
	}

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBakerGrouperCore grouper;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ClusterType clusterType;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GrouperData data;

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Bounds sourceObjectBounds;

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x1613334", Offset = "0x1613334", VA = "0x1613334")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x16133E4", Offset = "0x16133E4", VA = "0x16133E4")]
	public MB3_MeshBakerGrouperCore CreateGrouper(ClusterType t, GrouperData data)
	{
		return null;
	}

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x1613588", Offset = "0x1613588", VA = "0x1613588")]
	public MB3_MeshBakerGrouper()
	{
	}
}
[Token(Token = "0x2000027")]
public abstract class MB3_MeshBakerRoot : MonoBehaviour
{
	[Token(Token = "0x20000CF")]
	public class ZSortObjects
	{
		[Token(Token = "0x2000190")]
		public class Item
		{
			[Token(Token = "0x400065F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x4000660")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 point;

			[Token(Token = "0x6000A38")]
			[Address(RVA = "0x16143FC", Offset = "0x16143FC", VA = "0x16143FC")]
			public Item()
			{
			}
		}

		[Token(Token = "0x2000191")]
		public class ItemComparer : IComparer<Item>
		{
			[Token(Token = "0x6000A39")]
			[Address(RVA = "0x1614414", Offset = "0x1614414", VA = "0x1614414", Slot = "4")]
			public int Compare(Item a, Item b)
			{
				return default(int);
			}

			[Token(Token = "0x6000A3A")]
			[Address(RVA = "0x1614404", Offset = "0x1614404", VA = "0x1614404")]
			public ItemComparer()
			{
			}
		}

		[Token(Token = "0x40003E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 sortAxis;

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x1613FA4", Offset = "0x1613FA4", VA = "0x1613FA4")]
		public void SortByDistanceAlongAxis(List<GameObject> gos)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x161440C", Offset = "0x161440C", VA = "0x161440C")]
		public ZSortObjects()
		{
		}
	}

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool DO_INTEGRITY_CHECKS;

	[Token(Token = "0x4000125")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 sortAxis;

	[Token(Token = "0x17000006")]
	[HideInInspector]
	public abstract MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x60000CB")]
		get;
		[Token(Token = "0x60000CC")]
		set;
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x1613684", Offset = "0x1613684", VA = "0x1613684", Slot = "6")]
	public virtual List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x161368C", Offset = "0x161368C", VA = "0x161368C")]
	public static bool DoCombinedValidate(MB3_MeshBakerRoot mom, MB_ObjsToCombineTypes objToCombineType, MB2_EditorMethodsInterface editorMethods, MB2_ValidationLevel validationLevel)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x161332C", Offset = "0x161332C", VA = "0x161332C")]
	protected MB3_MeshBakerRoot()
	{
	}
}
[Token(Token = "0x2000028")]
public class MB3_MultiMeshBaker : MB3_MeshBakerCommon
{
	[Token(Token = "0x4000126")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected MB3_MultiMeshCombiner _meshCombiner;

	[Token(Token = "0x17000007")]
	public override MB3_MeshCombiner meshCombiner
	{
		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x16144C4", Offset = "0x16144C4", VA = "0x16144C4", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x16144CC", Offset = "0x16144CC", VA = "0x16144CC", Slot = "13")]
	public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x161464C", Offset = "0x161464C", VA = "0x161464C", Slot = "14")]
	public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOs, bool disableRendererInSource)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x16147CC", Offset = "0x16147CC", VA = "0x16147CC")]
	public MB3_MultiMeshBaker()
	{
	}
}
[Token(Token = "0x2000029")]
public class MB3_TextureBaker : MB3_MeshBakerRoot
{
	[Token(Token = "0x20000D0")]
	public delegate void OnCombinedTexturesCoroutineSuccess();

	[Token(Token = "0x20000D1")]
	public delegate void OnCombinedTexturesCoroutineFail();

	[Token(Token = "0x20000D2")]
	public class CreateAtlasesCoroutineResult
	{
		[Token(Token = "0x40003E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool success;

		[Token(Token = "0x40003EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool isFinished;

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x1616748", Offset = "0x1616748", VA = "0x1616748")]
		public CreateAtlasesCoroutineResult()
		{
		}
	}

	[Token(Token = "0x20000D3")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6B4", Offset = "0xADD6B4")]
	private sealed class <CreateAtlasesCoroutine>d__94 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CreateAtlasesCoroutineResult coroutineResult;

		[Token(Token = "0x40003EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MB3_TextureBaker <>4__this;

		[Token(Token = "0x40003EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float maxTimePerFrame;

		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public bool saveAtlasesAsAssets;

		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ProgressUpdateDelegate progressInfo;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public MB2_EditorMethodsInterface editorMethods;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private MB3_TextureCombiner <combiner>5__2;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int <i>5__3;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult <coroutineResult2>5__4;

		[Token(Token = "0x170000EA")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E0")]
			[Address(RVA = "0x16185D4", Offset = "0x16185D4", VA = "0x16185D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EB")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E2")]
			[Address(RVA = "0x161863C", Offset = "0x161863C", VA = "0x161863C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x161671C", Offset = "0x161671C", VA = "0x161671C")]
		[DebuggerHidden]
		public <CreateAtlasesCoroutine>d__94(int <>1__state)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x1617764", Offset = "0x1617764", VA = "0x1617764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x1617768", Offset = "0x1617768", VA = "0x1617768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x16185DC", Offset = "0x16185DC", VA = "0x16185DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected MB2_TextureBakeResults _textureBakeResults;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected int _atlasPadding;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	protected int _maxAtlasSize;

	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected bool _useMaxAtlasWidthOverride;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	protected int _maxAtlasWidthOverride;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	protected bool _useMaxAtlasHeightOverride;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	protected int _maxAtlasHeightOverride;

	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	protected bool _resizePowerOfTwoTextures;

	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	[SerializeField]
	protected bool _fixOutOfBoundsUVs;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[SerializeField]
	protected int _maxTilingBakeSize;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	protected MB2_PackingAlgorithmEnum _packingAlgorithm;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[SerializeField]
	protected bool _meshBakerTexturePackerForcePowerOfTwo;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected List<ShaderTextureProperty> _customShaderProperties;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected List<string> _customShaderPropNames_Depricated;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected bool _doMultiMaterial;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfTooBig;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
	[SerializeField]
	protected bool _doMultiMaterialSplitAtlasesIfOBUVs;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	protected Material _resultMaterial;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	protected bool _considerNonTextureProperties;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[SerializeField]
	protected bool _doSuggestTreatment;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CreateAtlasesCoroutineResult _coroutineResult;

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MB_MultiMaterial[] resultMaterials;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public List<GameObject> objsToMesh;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public OnCombinedTexturesCoroutineSuccess onBuiltAtlasesSuccess;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public OnCombinedTexturesCoroutineFail onBuiltAtlasesFail;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public MB_AtlasesAndRects[] OnCombinedTexturesCoroutineAtlasesAndRects;

	[Token(Token = "0x17000008")]
	public override MB2_TextureBakeResults textureBakeResults
	{
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x16160C4", Offset = "0x16160C4", VA = "0x16160C4", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x16160CC", Offset = "0x16160CC", VA = "0x16160CC", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17000009")]
	public virtual int atlasPadding
	{
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x16160D4", Offset = "0x16160D4", VA = "0x16160D4", Slot = "7")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x16160DC", Offset = "0x16160DC", VA = "0x16160DC", Slot = "8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public virtual int maxAtlasSize
	{
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x16160E4", Offset = "0x16160E4", VA = "0x16160E4", Slot = "9")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x16160EC", Offset = "0x16160EC", VA = "0x16160EC", Slot = "10")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public virtual bool useMaxAtlasWidthOverride
	{
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x16160F4", Offset = "0x16160F4", VA = "0x16160F4", Slot = "11")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x16160FC", Offset = "0x16160FC", VA = "0x16160FC", Slot = "12")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public virtual int maxAtlasWidthOverride
	{
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x1616108", Offset = "0x1616108", VA = "0x1616108", Slot = "13")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x1616110", Offset = "0x1616110", VA = "0x1616110", Slot = "14")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public virtual bool useMaxAtlasHeightOverride
	{
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x1616118", Offset = "0x1616118", VA = "0x1616118", Slot = "15")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x1616120", Offset = "0x1616120", VA = "0x1616120", Slot = "16")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public virtual int maxAtlasHeightOverride
	{
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x161612C", Offset = "0x161612C", VA = "0x161612C", Slot = "17")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x1616134", Offset = "0x1616134", VA = "0x1616134", Slot = "18")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public virtual bool resizePowerOfTwoTextures
	{
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x161613C", Offset = "0x161613C", VA = "0x161613C", Slot = "19")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x1616144", Offset = "0x1616144", VA = "0x1616144", Slot = "20")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public virtual bool fixOutOfBoundsUVs
	{
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x1616150", Offset = "0x1616150", VA = "0x1616150", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x1616158", Offset = "0x1616158", VA = "0x1616158", Slot = "22")]
		set
		{
		}
	}

	[Token(Token = "0x17000011")]
	public virtual int maxTilingBakeSize
	{
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x1616164", Offset = "0x1616164", VA = "0x1616164", Slot = "23")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x161616C", Offset = "0x161616C", VA = "0x161616C", Slot = "24")]
		set
		{
		}
	}

	[Token(Token = "0x17000012")]
	public virtual MB2_PackingAlgorithmEnum packingAlgorithm
	{
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x1616174", Offset = "0x1616174", VA = "0x1616174", Slot = "25")]
		get
		{
			return default(MB2_PackingAlgorithmEnum);
		}
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x161617C", Offset = "0x161617C", VA = "0x161617C", Slot = "26")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	public bool meshBakerTexturePackerForcePowerOfTwo
	{
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x1616184", Offset = "0x1616184", VA = "0x1616184")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x161618C", Offset = "0x161618C", VA = "0x161618C")]
		set
		{
		}
	}

	[Token(Token = "0x17000014")]
	public virtual List<ShaderTextureProperty> customShaderProperties
	{
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x1616198", Offset = "0x1616198", VA = "0x1616198", Slot = "27")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x16161A0", Offset = "0x16161A0", VA = "0x16161A0", Slot = "28")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	public virtual List<string> customShaderPropNames
	{
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x16161A8", Offset = "0x16161A8", VA = "0x16161A8", Slot = "29")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x16161B0", Offset = "0x16161B0", VA = "0x16161B0", Slot = "30")]
		set
		{
		}
	}

	[Token(Token = "0x17000016")]
	public virtual bool doMultiMaterial
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x16161B8", Offset = "0x16161B8", VA = "0x16161B8", Slot = "31")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x16161C0", Offset = "0x16161C0", VA = "0x16161C0", Slot = "32")]
		set
		{
		}
	}

	[Token(Token = "0x17000017")]
	public virtual bool doMultiMaterialSplitAtlasesIfTooBig
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x16161CC", Offset = "0x16161CC", VA = "0x16161CC", Slot = "33")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x16161D4", Offset = "0x16161D4", VA = "0x16161D4", Slot = "34")]
		set
		{
		}
	}

	[Token(Token = "0x17000018")]
	public virtual bool doMultiMaterialSplitAtlasesIfOBUVs
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x16161E0", Offset = "0x16161E0", VA = "0x16161E0", Slot = "35")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x16161E8", Offset = "0x16161E8", VA = "0x16161E8", Slot = "36")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	public virtual Material resultMaterial
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x16161F4", Offset = "0x16161F4", VA = "0x16161F4", Slot = "37")]
		get
		{
			return null;
		}
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x16161FC", Offset = "0x16161FC", VA = "0x16161FC", Slot = "38")]
		set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool considerNonTextureProperties
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x1616204", Offset = "0x1616204", VA = "0x1616204")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x161620C", Offset = "0x161620C", VA = "0x161620C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	public bool doSuggestTreatment
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x1616218", Offset = "0x1616218", VA = "0x1616218")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1616220", Offset = "0x1616220", VA = "0x1616220")]
		set
		{
		}
	}

	[Token(Token = "0x1700001C")]
	public CreateAtlasesCoroutineResult CoroutineResult
	{
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x161622C", Offset = "0x161622C", VA = "0x161622C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1616234", Offset = "0x1616234", VA = "0x1616234", Slot = "6")]
	public override List<GameObject> GetObjectsToCombine()
	{
		return null;
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x16162A8", Offset = "0x16162A8", VA = "0x16162A8")]
	public MB_AtlasesAndRects[] CreateAtlases()
	{
		return null;
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1616670", Offset = "0x1616670", VA = "0x1616670")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEEAC", Offset = "0xADEEAC")]
	public IEnumerator CreateAtlasesCoroutine(ProgressUpdateDelegate progressInfo, CreateAtlasesCoroutineResult coroutineResult, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods, float maxTimePerFrame = 0.01f)
	{
		return null;
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x16162B8", Offset = "0x16162B8", VA = "0x16162B8")]
	public MB_AtlasesAndRects[] CreateAtlases(ProgressUpdateDelegate progressInfo, bool saveAtlasesAsAssets = false, [Optional] MB2_EditorMethodsInterface editorMethods)
	{
		return null;
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0x1616758", Offset = "0x1616758", VA = "0x1616758")]
	private void unpackMat2RectMap(MB2_TextureBakeResults tbr)
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1616980", Offset = "0x1616980", VA = "0x1616980")]
	public MB3_TextureCombiner CreateAndConfigureTextureCombiner()
	{
		return null;
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x1616A88", Offset = "0x1616A88", VA = "0x1616A88")]
	public static void ConfigureNewMaterialToMatchOld(Material newMat, Material original)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1616DC0", Offset = "0x1616DC0", VA = "0x1616DC0")]
	private string PrintSet(HashSet<Material> s)
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1616F0C", Offset = "0x1616F0C", VA = "0x1616F0C")]
	private bool _ValidateResultMaterials()
	{
		return default(bool);
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x161764C", Offset = "0x161764C", VA = "0x161764C")]
	public MB3_TextureBaker()
	{
	}
}
[Token(Token = "0x200002A")]
public class MB2_TestShowHide : MonoBehaviour
{
	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker mb;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] objs;

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x160D1D0", Offset = "0x160D1D0", VA = "0x160D1D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x160D314", Offset = "0x160D314", VA = "0x160D314")]
	public MB2_TestShowHide()
	{
	}
}
[Token(Token = "0x200002B")]
public class MB2_TestUpdate : MonoBehaviour
{
	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshbaker;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MB3_MultiMeshBaker multiMeshBaker;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject[] objsToMove;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject objWithChangingUVs;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector2[] uvs;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Mesh m;

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x160D31C", Offset = "0x160D31C", VA = "0x160D31C")]
	private void Start()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x160D544", Offset = "0x160D544", VA = "0x160D544")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x160D9D0", Offset = "0x160D9D0", VA = "0x160D9D0")]
	public MB2_TestUpdate()
	{
	}
}
[Token(Token = "0x200002C")]
public class MB3_TestAddingRemovingSkinnedMeshes : MonoBehaviour
{
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6C4", Offset = "0xADD6C4")]
	private sealed class <TestScript>d__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MB3_TestAddingRemovingSkinnedMeshes <>4__this;

		[Token(Token = "0x170000EC")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x16151FC", Offset = "0x16151FC", VA = "0x16151FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000ED")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x1615264", Offset = "0x1615264", VA = "0x1615264", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x16148CC", Offset = "0x16148CC", VA = "0x16148CC")]
		[DebuggerHidden]
		public <TestScript>d__3(int <>1__state)
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x1614900", Offset = "0x1614900", VA = "0x1614900", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0x1614904", Offset = "0x1614904", VA = "0x1614904", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0x1615204", Offset = "0x1615204", VA = "0x1615204", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MB3_MeshBaker meshBaker;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] g;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x1614830", Offset = "0x1614830", VA = "0x1614830")]
	private void Start()
	{
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0x161485C", Offset = "0x161485C", VA = "0x161485C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEF10", Offset = "0xADEF10")]
	private IEnumerator TestScript()
	{
		return null;
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0x16148F8", Offset = "0x16148F8", VA = "0x16148F8")]
	public MB3_TestAddingRemovingSkinnedMeshes()
	{
	}
}
[Token(Token = "0x200002D")]
public class MB3_TestBakeAllWithSameMaterial : MonoBehaviour
{
	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject[] listOfObjsToCombineGood;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject[] listOfObjsToCombineBad;

	[Token(Token = "0x6000110")]
	[Address(RVA = "0x161526C", Offset = "0x161526C", VA = "0x161526C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0x1615270", Offset = "0x1615270", VA = "0x1615270")]
	private void testCombine()
	{
	}

	[Token(Token = "0x6000112")]
	[Address(RVA = "0x16155B4", Offset = "0x16155B4", VA = "0x16155B4")]
	public MB3_TestBakeAllWithSameMaterial()
	{
	}
}
[Token(Token = "0x200002E")]
public class MB3_TestRenderTextureTestHarness : MonoBehaviour
{
	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D input;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool doColor;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Color32 color;

	[Token(Token = "0x6000113")]
	[Address(RVA = "0x16155BC", Offset = "0x16155BC", VA = "0x16155BC")]
	public Texture2D Create3x3Tex()
	{
		return null;
	}

	[Token(Token = "0x6000114")]
	[Address(RVA = "0x16156DC", Offset = "0x16156DC", VA = "0x16156DC")]
	public Texture2D Create3x3Clone()
	{
		return null;
	}

	[Token(Token = "0x6000115")]
	[Address(RVA = "0x161596C", Offset = "0x161596C", VA = "0x161596C")]
	public static void TestRender(Texture2D input, Texture2D output)
	{
	}

	[Token(Token = "0x6000116")]
	[Address(RVA = "0x16160BC", Offset = "0x16160BC", VA = "0x16160BC")]
	public MB3_TestRenderTextureTestHarness()
	{
	}
}
[Token(Token = "0x200002F")]
public class MB3_KMeansClustering
{
	[Token(Token = "0x20000D5")]
	private class DataPoint
	{
		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 center;

		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int Cluster;

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x1611678", Offset = "0x1611678", VA = "0x1611678")]
		public DataPoint(GameObject go)
		{
		}
	}

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private List<DataPoint> _normalizedDataToCluster;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3[] _clusters;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int _numberOfClusters;

	[Token(Token = "0x6000117")]
	[Address(RVA = "0x16113C4", Offset = "0x16113C4", VA = "0x16113C4")]
	public MB3_KMeansClustering(List<GameObject> gos, int numClusters)
	{
	}

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x16117A4", Offset = "0x16117A4", VA = "0x16117A4")]
	private void InitializeCentroids()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x161189C", Offset = "0x161189C", VA = "0x161189C")]
	private bool UpdateDataPointMeans(bool force)
	{
		return default(bool);
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x1611B40", Offset = "0x1611B40", VA = "0x1611B40")]
	private bool AnyAreEmpty(List<DataPoint> data)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x1611C58", Offset = "0x1611C58", VA = "0x1611C58")]
	private bool UpdateClusterMembership()
	{
		return default(bool);
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x1611E20", Offset = "0x1611E20", VA = "0x1611E20")]
	private float ElucidanDistance(DataPoint dataPoint, Vector3 mean)
	{
		return default(float);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x1611ED0", Offset = "0x1611ED0", VA = "0x1611ED0")]
	private int MinIndex(float[] distances)
	{
		return default(int);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1611F40", Offset = "0x1611F40", VA = "0x1611F40")]
	public List<Renderer> GetCluster(int idx, out Vector3 mean, out float size)
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x161225C", Offset = "0x161225C", VA = "0x161225C")]
	public void Cluster()
	{
	}
}
[Token(Token = "0x2000030")]
public class MB_TextureCombinerRenderTexture
{
	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Material mat;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private RenderTexture _destinationTexture;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Camera myCamera;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int _padding;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool _isNormalMap;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x35")]
	private bool _fixOutOfBoundsUVs;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x36")]
	private bool _doRenderAtlas;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Rect[] rs;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<MB_TexSet> textureSets;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int indexOfTexSetToRender;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ShaderTextureProperty _texPropertyName;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private MB3_TextureCombinerNonTextureProperties _resultMaterialTextureBlender;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Texture2D targTex;

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x160FDA0", Offset = "0x160FDA0", VA = "0x160FDA0")]
	public Texture2D DoRenderAtlas(GameObject gameObject, int width, int height, int padding, Rect[] rss, List<MB_TexSet> textureSetss, int indexOfTexSetToRenders, ShaderTextureProperty texPropertyname, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender, bool isNormalMap, bool fixOutOfBoundsUVs, bool considerNonTextureProperties, MB3_TextureCombiner texCombiner, MB2_LogLevel LOG_LEV)
	{
		return null;
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1610384", Offset = "0x1610384", VA = "0x1610384")]
	public void OnRenderObject()
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1619B30", Offset = "0x1619B30", VA = "0x1619B30")]
	private Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
	{
		return default(Color32);
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1619C6C", Offset = "0x1619C6C", VA = "0x1619C6C")]
	private bool IsOpenGL()
	{
		return default(bool);
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x1618874", Offset = "0x1618874", VA = "0x1618874")]
	private void CopyScaledAndTiledToAtlas(MB_TexSet texSet, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, Rect rec, ShaderTextureProperty texturePropertyName, MB3_TextureCombinerNonTextureProperties resultMatTexBlender)
	{
	}

	[Token(Token = "0x6000125")]
	[Address(RVA = "0x1619830", Offset = "0x1619830", VA = "0x1619830")]
	private void _printTexture(Texture2D t)
	{
	}

	[Token(Token = "0x6000126")]
	[Address(RVA = "0x160FD90", Offset = "0x160FD90", VA = "0x160FD90")]
	public MB_TextureCombinerRenderTexture()
	{
	}
}
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
public class MB3_AtlasPackerRenderTexture : MonoBehaviour
{
	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MB_TextureCombinerRenderTexture fastRenderer;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool _doRenderAtlas;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int width;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int height;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int padding;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool isNormalMap;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	public bool fixOutOfBoundsUVs;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	public bool considerNonTextureProperties;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rect[] rects;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Texture2D tex1;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public List<MB_TexSet> textureSets;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int indexOfTexSetToRender;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public ShaderTextureProperty texPropertyName;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public MB2_LogLevel LOG_LEVEL;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Texture2D testTex;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Material testMat;

	[Token(Token = "0x6000127")]
	[Address(RVA = "0x160FCBC", Offset = "0x160FCBC", VA = "0x160FCBC")]
	public Texture2D OnRenderAtlas(MB3_TextureCombiner combiner)
	{
		return null;
	}

	[Token(Token = "0x6000128")]
	[Address(RVA = "0x161034C", Offset = "0x161034C", VA = "0x161034C")]
	private void OnRenderObject()
	{
	}

	[Token(Token = "0x6000129")]
	[Address(RVA = "0x1611018", Offset = "0x1611018", VA = "0x1611018")]
	public MB3_AtlasPackerRenderTexture()
	{
	}
}
[Token(Token = "0x2000032")]
public class CombinedMesh : MonoBehaviour
{
	[Token(Token = "0x20000D6")]
	public delegate void CombineProgressDelegate(string strMessage, float fT);

	[Serializable]
	[Token(Token = "0x20000D7")]
	public class ObjectInfo
	{
		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material[] aMaterials;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 v3LocalPosition;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Quaternion qLocalRotation;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Vector3 v3LocalScale;

		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Matrix4x4 mtxLocal;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Matrix4x4 mtxWorld;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Vector3[] av3NormalsWorld;

		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Vector4[] av4TangentsWorld;

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x141085C", Offset = "0x141085C", VA = "0x141085C")]
		public ObjectInfo(Material[] aMaterials, Mesh mesh, Transform transform, Matrix4x4 mtxLocal)
		{
		}
	}

	[Token(Token = "0x20000D8")]
	private class MaterialMeshInfo
	{
		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform transform;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Mesh mesh;

		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int nSubMesh;

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x141081C", Offset = "0x141081C", VA = "0x141081C")]
		public MaterialMeshInfo(Transform transform, Mesh mesh, int nSubMesh)
		{
		}
	}

	[Token(Token = "0x20000D9")]
	public enum EPivotMode
	{
		[Token(Token = "0x4000409")]
		Keep,
		[Token(Token = "0x400040A")]
		Center,
		[Token(Token = "0x400040B")]
		BottomCenter,
		[Token(Token = "0x400040C")]
		TopCenter,
		[Token(Token = "0x400040D")]
		Min,
		[Token(Token = "0x400040E")]
		Max
	}

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool SaveMeshAsset;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool KeepPosition;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public EPivotMode PivotMode;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshFilter[] MeshObjects;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject RootNode;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool m_bCancelled;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<ObjectInfo> m_listObjectInfo;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<Material, List<MaterialMeshInfo>> m_dicMeshEntries;

	[Token(Token = "0x600012A")]
	[Address(RVA = "0x140DB68", Offset = "0x140DB68", VA = "0x140DB68")]
	public void CancelCombining()
	{
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x140DB74", Offset = "0x140DB74", VA = "0x140DB74")]
	public bool CombiningCancelled()
	{
		return default(bool);
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x140DB7C", Offset = "0x140DB7C", VA = "0x140DB7C")]
	public void TransformObjInfoMeshVectorsToLocal(Transform newTransform)
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x140DF2C", Offset = "0x140DF2C", VA = "0x140DF2C")]
	public int GetObjectCount()
	{
		return default(int);
	}

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x140DF7C", Offset = "0x140DF7C", VA = "0x140DF7C")]
	public ObjectInfo GetObjectInfo(int nIndex)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x140DFF4", Offset = "0x140DFF4", VA = "0x140DFF4")]
	public void Combine(CombineProgressDelegate progress)
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1410B2C", Offset = "0x1410B2C", VA = "0x1410B2C")]
	public CombinedMesh()
	{
	}
}
[Token(Token = "0x2000033")]
public static class MECExtensionMethods
{
	[Token(Token = "0x20000DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6D4", Offset = "0xADD6D4")]
	private sealed class <CancelWith>d__0 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject;

		[Token(Token = "0x170000EE")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x19FC2D4", Offset = "0x19FC2D4", VA = "0x19FC2D4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000EF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x19FC33C", Offset = "0x19FC33C", VA = "0x19FC33C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x19FBF18", Offset = "0x19FBF18", VA = "0x19FBF18")]
		[DebuggerHidden]
		public <CancelWith>d__0(int <>1__state)
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x19FC0B0", Offset = "0x19FC0B0", VA = "0x19FC0B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x19FC0B4", Offset = "0x19FC0B4", VA = "0x19FC0B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x19FC2DC", Offset = "0x19FC2DC", VA = "0x19FC2DC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6E4", Offset = "0xADD6E4")]
	private sealed class <CancelWith>d__1 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x170000F0")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0x19FC604", Offset = "0x19FC604", VA = "0x19FC604", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x19FC66C", Offset = "0x19FC66C", VA = "0x19FC66C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x19FBFC8", Offset = "0x19FBFC8", VA = "0x19FBFC8")]
		[DebuggerHidden]
		public <CancelWith>d__1(int <>1__state)
		{
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x19FC3A0", Offset = "0x19FC3A0", VA = "0x19FC3A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x19FC3A4", Offset = "0x19FC3A4", VA = "0x19FC3A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x19FC60C", Offset = "0x19FC60C", VA = "0x19FC60C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD6F4", Offset = "0xADD6F4")]
	private sealed class <CancelWith>d__2 : IEnumerator<float>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private float <>2__current;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IEnumerator<float> coroutine;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject gameObject1;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameObject gameObject2;

		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject gameObject3;

		[Token(Token = "0x170000F2")]
		private float System.Collections.Generic.IEnumerator<System.Single>.Current
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x19FC974", Offset = "0x19FC974", VA = "0x19FC974", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000F3")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x19FC9DC", Offset = "0x19FC9DC", VA = "0x19FC9DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x19FC084", Offset = "0x19FC084", VA = "0x19FC084")]
		[DebuggerHidden]
		public <CancelWith>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x19FC6D0", Offset = "0x19FC6D0", VA = "0x19FC6D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x19FC6D4", Offset = "0x19FC6D4", VA = "0x19FC6D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x19FC97C", Offset = "0x19FC97C", VA = "0x19FC97C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x19FBE9C", Offset = "0x19FBE9C", VA = "0x19FBE9C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEF74", Offset = "0xADEF74")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject)
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x19FBF44", Offset = "0x19FBF44", VA = "0x19FBF44")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADEFE8", Offset = "0xADEFE8")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x19FBFF4", Offset = "0x19FBFF4", VA = "0x19FBFF4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF05C", Offset = "0xADF05C")]
	public static IEnumerator<float> CancelWith(this IEnumerator<float> coroutine, GameObject gameObject1, GameObject gameObject2, GameObject gameObject3)
	{
		return null;
	}
}
namespace Sigtrap.Editors.ShaderStripper
{
	[Token(Token = "0x2000034")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xADD350", Offset = "0xADD350")]
	public class ShaderForceKeywords : ShaderStripperBase
	{
		[Serializable]
		[Token(Token = "0x20000DD")]
		private struct ForceBuiltin
		{
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public BuiltinShaderDefine defineToMatch;

			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public BuiltinShaderDefine defineToForce;

			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADEC80", Offset = "0xADEC80")]
			public bool invertMatch;

			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADECB8", Offset = "0xADECB8")]
			public bool invertForce;
		}

		[Serializable]
		[Token(Token = "0x20000DE")]
		private struct ForceKeyword
		{
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string keywordToMatch;

			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string keywordToForce;

			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADECF0", Offset = "0xADECF0")]
			public bool invertMatch;

			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADED28", Offset = "0xADED28")]
			public bool invertForce;
		}

		[Token(Token = "0x400017B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ForceBuiltin[] _forceBuiltins;

		[Token(Token = "0x400017C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ForceKeyword[] _forceKeywords;

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1B49A44", Offset = "0x1B49A44", VA = "0x1B49A44")]
		public ShaderForceKeywords()
		{
		}
	}
	[Token(Token = "0x2000035")]
	public class ShaderLog
	{
		[Token(Token = "0x400017D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<string> log;

		[Token(Token = "0x400017E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADE01C", Offset = "0xADE01C")]
		private string <logName>k__BackingField;

		[Token(Token = "0x1700001D")]
		public string logName
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1B49A74", Offset = "0x1B49A74", VA = "0x1B49A74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF0D0", Offset = "0xADF0D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1B49A7C", Offset = "0x1B49A7C", VA = "0x1B49A7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF0E0", Offset = "0xADF0E0")]
			private set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public int Count
		{
			[Token(Token = "0x6000137")]
			[Address(RVA = "0x1B49A84", Offset = "0x1B49A84", VA = "0x1B49A84")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1B49AD4", Offset = "0x1B49AD4", VA = "0x1B49AD4")]
		public ShaderLog(string logName)
		{
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1B49B58", Offset = "0x1B49B58", VA = "0x1B49B58")]
		public void Add(string s)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1B49BC0", Offset = "0x1B49BC0", VA = "0x1B49BC0")]
		public void Clear()
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1B49C18", Offset = "0x1B49C18", VA = "0x1B49C18")]
		public void Insert(int index, string s)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1B49C88", Offset = "0x1B49C88", VA = "0x1B49C88")]
		public bool Contains(string s)
		{
			return default(bool);
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1B49CF0", Offset = "0x1B49CF0", VA = "0x1B49CF0")]
		public string[] ToArray()
		{
			return null;
		}
	}
	[Token(Token = "0x2000036")]
	public abstract class ShaderStripperBase : ScriptableObject
	{
		[Serializable]
		[Token(Token = "0x20000DF")]
		protected class StringMatch
		{
			[Token(Token = "0x2000192")]
			public enum MatchType
			{
				[Token(Token = "0x4000662")]
				EQUALS,
				[Token(Token = "0x4000663")]
				CONTAINS,
				[Token(Token = "0x4000664")]
				STARTSWITH,
				[Token(Token = "0x4000665")]
				ENDSWITH
			}

			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MatchType matchType;

			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string namePattern;

			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public bool caseInsensitive;

			[Token(Token = "0x6000802")]
			[Address(RVA = "0x1B49D50", Offset = "0x1B49D50", VA = "0x1B49D50")]
			public bool Evaluate(string name)
			{
				return default(bool);
			}

			[Token(Token = "0x6000803")]
			[Address(RVA = "0x1B49E48", Offset = "0x1B49E48", VA = "0x1B49E48")]
			public StringMatch()
			{
			}
		}

		[Token(Token = "0x400017F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private bool _expanded;

		[Token(Token = "0x4000180")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[HideInInspector]
		private int _order;

		[Token(Token = "0x4000181")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _active;

		[Token(Token = "0x4000182")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _notes;

		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _logOutput;

		[Token(Token = "0x1700001F")]
		public bool active
		{
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x1B49D48", Offset = "0x1B49D48", VA = "0x1B49D48")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1B49A5C", Offset = "0x1B49A5C", VA = "0x1B49A5C")]
		protected ShaderStripperBase()
		{
		}
	}
	[Token(Token = "0x2000037")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xADD38C", Offset = "0xADD38C")]
	public class ShaderStripperPath : ShaderStripperBase
	{
		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private StringMatch[] _pathBlacklist;

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1B49E50", Offset = "0x1B49E50", VA = "0x1B49E50")]
		public ShaderStripperPath()
		{
		}
	}
	[Token(Token = "0x2000038")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xADD3C8", Offset = "0xADD3C8")]
	public class ShaderStripperPlatform : ShaderStripperBase
	{
		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE0DC", Offset = "0xADE0DC")]
		private bool _whitelist;

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1B49E68", Offset = "0x1B49E68", VA = "0x1B49E68")]
		public ShaderStripperPlatform()
		{
		}
	}
	[Token(Token = "0x2000039")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xADD404", Offset = "0xADD404")]
	public class ShaderStripperSimple : ShaderStripperBase
	{
		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE128", Offset = "0xADE128")]
		private List<StringMatch> _blacklistedShaderNames;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE174", Offset = "0xADE174")]
		private List<PassType> _blacklistedPassTypes;

		[Token(Token = "0x4000188")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE1C0", Offset = "0xADE1C0")]
		private List<string> _blacklistedKeywords;

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1B49E80", Offset = "0x1B49E80", VA = "0x1B49E80")]
		public ShaderStripperSimple()
		{
		}
	}
	[Token(Token = "0x200003A")]
	[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xADD440", Offset = "0xADD440")]
	public class ShaderStripperVariantCollection : ShaderStripperBase, ISerializationCallbackReceiver
	{
		[Token(Token = "0x4000189")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE20C", Offset = "0xADE20C")]
		private string _mergeToFile;

		[Token(Token = "0x400018A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE258", Offset = "0xADE258")]
		private List<ShaderVariantCollection> _whitelistedCollections;

		[Token(Token = "0x400018B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[HideInInspector]
		private List<string> _collectionPaths;

		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE2DC", Offset = "0xADE2DC")]
		private bool _stripHidden;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE328", Offset = "0xADE328")]
		private bool _allowVrVariants;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE374", Offset = "0xADE374")]
		private bool _allowInstancedVariants;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE3C0", Offset = "0xADE3C0")]
		private StringMatch[] _ignoreShadersByName;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE40C", Offset = "0xADE40C")]
		private List<PassType> _ignorePassTypes;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool _valid;

		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool _dirty;

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1B49E98", Offset = "0x1B49E98", VA = "0x1B49E98", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1B49EA4", Offset = "0x1B49EA4", VA = "0x1B49EA4", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1B49EB0", Offset = "0x1B49EB0", VA = "0x1B49EB0")]
		public ShaderStripperVariantCollection()
		{
		}
	}
}
namespace MEC
{
	[Token(Token = "0x200003B")]
	public class Timing : MonoBehaviour
	{
		[Token(Token = "0x20000E0")]
		private struct ProcessIndex : IEquatable<ProcessIndex>
		{
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Segment seg;

			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int i;

			[Token(Token = "0x6000804")]
			[Address(RVA = "0x19FBD7C", Offset = "0x19FBD7C", VA = "0x19FBD7C", Slot = "4")]
			public bool Equals(ProcessIndex other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000805")]
			[Address(RVA = "0x19FBDA4", Offset = "0x19FBDA4", VA = "0x19FBDA4", Slot = "0")]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6000806")]
			[Address(RVA = "0x19FBE3C", Offset = "0x19FBE3C", VA = "0x19FBE3C")]
			public static bool operator ==(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000807")]
			[Address(RVA = "0x19FBE5C", Offset = "0x19FBE5C", VA = "0x19FBE5C")]
			public static bool operator !=(ProcessIndex a, ProcessIndex b)
			{
				return default(bool);
			}

			[Token(Token = "0x6000808")]
			[Address(RVA = "0x19FBE7C", Offset = "0x19FBE7C", VA = "0x19FBE7C", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000E1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD704", Offset = "0xADD704")]
		private sealed class <_InjectDelay>d__111 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delayTime;

			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000F4")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600080C")]
				[Address(RVA = "0x19FB29C", Offset = "0x19FB29C", VA = "0x19FB29C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000F5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600080E")]
				[Address(RVA = "0x19FB304", Offset = "0x19FB304", VA = "0x19FB304", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000809")]
			[Address(RVA = "0x19F92A4", Offset = "0x19F92A4", VA = "0x19F92A4")]
			[DebuggerHidden]
			public <_InjectDelay>d__111(int <>1__state)
			{
			}

			[Token(Token = "0x600080A")]
			[Address(RVA = "0x19FB154", Offset = "0x19FB154", VA = "0x19FB154", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600080B")]
			[Address(RVA = "0x19FB158", Offset = "0x19FB158", VA = "0x19FB158", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600080D")]
			[Address(RVA = "0x19FB2A4", Offset = "0x19FB2A4", VA = "0x19FB2A4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD714", Offset = "0xADD714")]
		private sealed class <_StartWhenDone>d__118 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CoroutineHandle handle;

			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IEnumerator<float> proc;

			[Token(Token = "0x170000F6")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000813")]
				[Address(RVA = "0x19FB6E8", Offset = "0x19FB6E8", VA = "0x19FB6E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000F7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x19FB750", Offset = "0x19FB750", VA = "0x19FB750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600080F")]
			[Address(RVA = "0x19F991C", Offset = "0x19F991C", VA = "0x19F991C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__118(int <>1__state)
			{
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x19FB368", Offset = "0x19FB368", VA = "0x19FB368", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000811")]
			[Address(RVA = "0x19FB3BC", Offset = "0x19FB3BC", VA = "0x19FB3BC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x19FB394", Offset = "0x19FB394", VA = "0x19FB394")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x19FB6F0", Offset = "0x19FB6F0", VA = "0x19FB6F0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD724", Offset = "0xADD724")]
		private sealed class <_StartWhenDone>d__124 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public WWW www;

			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000F8")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000819")]
				[Address(RVA = "0x19FB8D4", Offset = "0x19FB8D4", VA = "0x19FB8D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000F9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600081B")]
				[Address(RVA = "0x19FB93C", Offset = "0x19FB93C", VA = "0x19FB93C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x19F9C8C", Offset = "0x19F9C8C", VA = "0x19F9C8C")]
			[DebuggerHidden]
			public <_StartWhenDone>d__124(int <>1__state)
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x19FB7B4", Offset = "0x19FB7B4", VA = "0x19FB7B4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x19FB7B8", Offset = "0x19FB7B8", VA = "0x19FB7B8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x19FB8DC", Offset = "0x19FB8DC", VA = "0x19FB8DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD734", Offset = "0xADD734")]
		private sealed class <_StartWhenDone>d__127 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public AsyncOperation operation;

			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000FA")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0x19FBAC0", Offset = "0x19FBAC0", VA = "0x19FBAC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000FB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000821")]
				[Address(RVA = "0x19FBB28", Offset = "0x19FBB28", VA = "0x19FBB28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x19F9EAC", Offset = "0x19F9EAC", VA = "0x19F9EAC")]
			[DebuggerHidden]
			public <_StartWhenDone>d__127(int <>1__state)
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x19FB9A0", Offset = "0x19FB9A0", VA = "0x19FB9A0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x19FB9A4", Offset = "0x19FB9A4", VA = "0x19FB9A4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x19FBAC8", Offset = "0x19FBAC8", VA = "0x19FBAC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD744", Offset = "0xADD744")]
		private sealed class <_StartWhenDone>d__130 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CustomYieldInstruction operation;

			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public IEnumerator<float> pausedProc;

			[Token(Token = "0x170000FC")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000825")]
				[Address(RVA = "0x19FBCB0", Offset = "0x19FBCB0", VA = "0x19FBCB0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000FD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0x19FBD18", Offset = "0x19FBD18", VA = "0x19FBD18", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x19FA0D0", Offset = "0x19FA0D0", VA = "0x19FA0D0")]
			[DebuggerHidden]
			public <_StartWhenDone>d__130(int <>1__state)
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x19FBB8C", Offset = "0x19FBB8C", VA = "0x19FBB8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x19FBB90", Offset = "0x19FBB90", VA = "0x19FBB90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x19FBCB8", Offset = "0x19FBCB8", VA = "0x19FBCB8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E6")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD754", Offset = "0xADD754")]
		private sealed class <_DelayedCall>d__137 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float delay;

			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public GameObject cancelWith;

			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Action action;

			[Token(Token = "0x170000FE")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x600082B")]
				[Address(RVA = "0x19FB088", Offset = "0x19FB088", VA = "0x19FB088", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x170000FF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600082D")]
				[Address(RVA = "0x19FB0F0", Offset = "0x19FB0F0", VA = "0x19FB0F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x19FA638", Offset = "0x19FA638", VA = "0x19FA638")]
			[DebuggerHidden]
			public <_DelayedCall>d__137(int <>1__state)
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x19FAF8C", Offset = "0x19FAF8C", VA = "0x19FAF8C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x19FAF90", Offset = "0x19FAF90", VA = "0x19FAF90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x19FB090", Offset = "0x19FB090", VA = "0x19FB090", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD764", Offset = "0xADD764")]
		private sealed class <_CallContinuously>d__146 : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private float <>2__current;

			[Token(Token = "0x4000449")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Timing <>4__this;

			[Token(Token = "0x400044A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float period;

			[Token(Token = "0x400044B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action action;

			[Token(Token = "0x400044C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float timeframe;

			[Token(Token = "0x400044D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action onDone;

			[Token(Token = "0x400044E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private double <startTime>5__2;

			[Token(Token = "0x17000100")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000831")]
				[Address(RVA = "0x19FAEC0", Offset = "0x19FAEC0", VA = "0x19FAEC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000101")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000833")]
				[Address(RVA = "0x19FAF28", Offset = "0x19FAF28", VA = "0x19FAF28", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x19FAAEC", Offset = "0x19FAAEC", VA = "0x19FAAEC")]
			[DebuggerHidden]
			public <_CallContinuously>d__146(int <>1__state)
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x19FADE0", Offset = "0x19FADE0", VA = "0x19FADE0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000830")]
			[Address(RVA = "0x19FADE4", Offset = "0x19FADE4", VA = "0x19FADE4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000832")]
			[Address(RVA = "0x19FAEC8", Offset = "0x19FAEC8", VA = "0x19FAEC8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x20000E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD774", Offset = "0xADD774")]
		private sealed class <_CallContinuously>d__155<T> : IEnumerator<float>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400044F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x4000450")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float <>2__current;

			[Token(Token = "0x4000451")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Timing <>4__this;

			[Token(Token = "0x4000452")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float period;

			[Token(Token = "0x4000453")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> action;

			[Token(Token = "0x4000454")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public T reference;

			[Token(Token = "0x4000455")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float timeframe;

			[Token(Token = "0x4000456")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Action<T> onDone;

			[Token(Token = "0x4000457")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private double <startTime>5__2;

			[Token(Token = "0x17000102")]
			private float System.Collections.Generic.IEnumerator<System.Single>.Current
			{
				[Token(Token = "0x6000837")]
				[DebuggerHidden]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x17000103")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000839")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000834")]
			[DebuggerHidden]
			public <_CallContinuously>d__155(int <>1__state)
			{
			}

			[Token(Token = "0x6000835")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000836")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000838")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE458", Offset = "0xADE458")]
		public float TimeBetweenSlowUpdateCalls;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE490", Offset = "0xADE490")]
		public DebugInfoType ProfilerDebugAmount;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE4C8", Offset = "0xADE4C8")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xADE4C8", Offset = "0xADE4C8")]
		public int UpdateCoroutines;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE518", Offset = "0xADE518")]
		public int FixedUpdateCoroutines;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE550", Offset = "0xADE550")]
		public int LateUpdateCoroutines;

		[Token(Token = "0x4000198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE588", Offset = "0xADE588")]
		public int SlowUpdateCoroutines;

		[NonSerialized]
		[Token(Token = "0x4000199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float localTime;

		[NonSerialized]
		[Token(Token = "0x400019A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float deltaTime;

		[Token(Token = "0x400019B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Func<IEnumerator<float>, CoroutineHandle, IEnumerator<float>> ReplacementFunction;

		[Token(Token = "0x400019D")]
		public const float WaitForOneFrame = 0f;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADE5D0", Offset = "0xADE5D0")]
		private static Thread <MainThread>k__BackingField;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static object _tmpRef;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static bool _tmpBool;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private static CoroutineHandle _tmpHandle;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _currentUpdateFrame;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private int _currentLateUpdateFrame;

		[Token(Token = "0x40001A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _currentSlowUpdateFrame;

		[Token(Token = "0x40001A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _nextUpdateProcessSlot;

		[Token(Token = "0x40001A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private int _nextLateUpdateProcessSlot;

		[Token(Token = "0x40001A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int _nextFixedUpdateProcessSlot;

		[Token(Token = "0x40001A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int _nextSlowUpdateProcessSlot;

		[Token(Token = "0x40001A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int _lastUpdateProcessSlot;

		[Token(Token = "0x40001AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int _lastLateUpdateProcessSlot;

		[Token(Token = "0x40001AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int _lastFixedUpdateProcessSlot;

		[Token(Token = "0x40001AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int _lastSlowUpdateProcessSlot;

		[Token(Token = "0x40001AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float _lastUpdateTime;

		[Token(Token = "0x40001AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float _lastLateUpdateTime;

		[Token(Token = "0x40001AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float _lastFixedUpdateTime;

		[Token(Token = "0x40001B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float _lastSlowUpdateTime;

		[Token(Token = "0x40001B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private float _lastSlowUpdateDeltaTime;

		[Token(Token = "0x40001B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ushort _framesSinceUpdate;

		[Token(Token = "0x40001B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A")]
		private ushort _expansions;

		[Token(Token = "0x40001B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private byte _instanceID;

		[Token(Token = "0x40001B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private readonly Dictionary<CoroutineHandle, HashSet<CoroutineHandle>> _waitingTriggers;

		[Token(Token = "0x40001B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private readonly HashSet<CoroutineHandle> _allWaiting;

		[Token(Token = "0x40001B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private readonly Dictionary<CoroutineHandle, ProcessIndex> _handleToIndex;

		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private readonly Dictionary<ProcessIndex, CoroutineHandle> _indexToHandle;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private readonly Dictionary<CoroutineHandle, string> _processTags;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly Dictionary<string, HashSet<CoroutineHandle>> _taggedProcesses;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private IEnumerator<float>[] UpdateProcesses;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private IEnumerator<float>[] LateUpdateProcesses;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private IEnumerator<float>[] FixedUpdateProcesses;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private IEnumerator<float>[] SlowUpdateProcesses;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private bool[] UpdatePaused;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private bool[] LateUpdatePaused;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool[] FixedUpdatePaused;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private bool[] SlowUpdatePaused;

		[Token(Token = "0x40001C3")]
		private const ushort FramesUntilMaintenance = 64;

		[Token(Token = "0x40001C4")]
		private const int ProcessArrayChunkSize = 64;

		[Token(Token = "0x40001C5")]
		private const int InitialBufferSizeLarge = 256;

		[Token(Token = "0x40001C6")]
		private const int InitialBufferSizeMedium = 64;

		[Token(Token = "0x40001C7")]
		private const int InitialBufferSizeSmall = 8;

		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static readonly Dictionary<byte, Timing> ActiveInstances;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Timing _instance;

		[Token(Token = "0x17000020")]
		public static float LocalTime
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x19F1F74", Offset = "0x19F1F74", VA = "0x19F1F74")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000021")]
		public static float DeltaTime
		{
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x19F2234", Offset = "0x19F2234", VA = "0x19F2234")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x17000022")]
		public static Thread MainThread
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x19F2480", Offset = "0x19F2480", VA = "0x19F2480")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF110", Offset = "0xADF110")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x19F24E8", Offset = "0x19F24E8", VA = "0x19F24E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF120", Offset = "0xADF120")]
			private set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public static Timing Instance
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x19F1FE0", Offset = "0x19F1FE0", VA = "0x19F1FE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x19F2554", Offset = "0x19F2554", VA = "0x19F2554")]
			set
			{
			}
		}

		[Token(Token = "0x14000001")]
		public static event Action OnPreExecute
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x19F22A0", Offset = "0x19F22A0", VA = "0x19F22A0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF0F0", Offset = "0xADF0F0")]
			add
			{
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x19F2390", Offset = "0x19F2390", VA = "0x19F2390")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADF100", Offset = "0xADF100")]
			remove
			{
			}
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x19F25C0", Offset = "0x19F25C0", VA = "0x19F25C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x19F2898", Offset = "0x19F2898", VA = "0x19F2898")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x19F29A8", Offset = "0x19F29A8", VA = "0x19F29A8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x19F4234", Offset = "0x19F4234", VA = "0x19F4234")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x19F46D4", Offset = "0x19F46D4", VA = "0x19F46D4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x19F34D8", Offset = "0x19F34D8", VA = "0x19F34D8")]
		private void RemoveUnused()
		{
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x19F4EE8", Offset = "0x19F4EE8", VA = "0x19F4EE8")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x19F6154", Offset = "0x19F6154", VA = "0x19F6154")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x19F6214", Offset = "0x19F6214", VA = "0x19F6214")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x19F62D4", Offset = "0x19F62D4", VA = "0x19F62D4")]
		public static CoroutineHandle RunCoroutine(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x19F63A0", Offset = "0x19F63A0", VA = "0x19F63A0")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x19F6404", Offset = "0x19F6404", VA = "0x19F6404")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x19F646C", Offset = "0x19F646C", VA = "0x19F646C")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x19F64D4", Offset = "0x19F64D4", VA = "0x19F64D4")]
		public CoroutineHandle RunCoroutineOnInstance(IEnumerator<float> coroutine, Segment segment, string tag)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x19F4FA4", Offset = "0x19F4FA4", VA = "0x19F4FA4")]
		private CoroutineHandle RunCoroutineInternal(IEnumerator<float> coroutine, Segment segment, string tag, CoroutineHandle handle, bool prewarm)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x19F6680", Offset = "0x19F6680", VA = "0x19F6680")]
		public static int KillCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x19F675C", Offset = "0x19F675C", VA = "0x19F675C")]
		public int KillCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x19F6908", Offset = "0x19F6908", VA = "0x19F6908")]
		public static int KillCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x19F33F0", Offset = "0x19F33F0", VA = "0x19F33F0")]
		public int KillCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x19F6B3C", Offset = "0x19F6B3C", VA = "0x19F6B3C")]
		public static int KillCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x19F6C2C", Offset = "0x19F6C2C", VA = "0x19F6C2C")]
		public int KillCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x19F6EA4", Offset = "0x19F6EA4", VA = "0x19F6EA4")]
		public static int PauseCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x19F6F80", Offset = "0x19F6F80", VA = "0x19F6F80")]
		public int PauseCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x19F78BC", Offset = "0x19F78BC", VA = "0x19F78BC")]
		public static int PauseCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x19F7990", Offset = "0x19F7990", VA = "0x19F7990")]
		public int PauseCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x19F80DC", Offset = "0x19F80DC", VA = "0x19F80DC")]
		public static int PauseCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x19F81CC", Offset = "0x19F81CC", VA = "0x19F81CC")]
		public int PauseCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x19F831C", Offset = "0x19F831C", VA = "0x19F831C")]
		public static int ResumeCoroutines()
		{
			return default(int);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x19F83F8", Offset = "0x19F83F8", VA = "0x19F83F8")]
		public int ResumeCoroutinesOnInstance()
		{
			return default(int);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x19F87A0", Offset = "0x19F87A0", VA = "0x19F87A0")]
		public static int ResumeCoroutines(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x19F8874", Offset = "0x19F8874", VA = "0x19F8874")]
		public int ResumeCoroutinesOnInstance(CoroutineHandle handle)
		{
			return default(int);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x19F8964", Offset = "0x19F8964", VA = "0x19F8964")]
		public static int ResumeCoroutines(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x19F8A54", Offset = "0x19F8A54", VA = "0x19F8A54")]
		public int ResumeCoroutinesOnInstance(string tag)
		{
			return default(int);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x19F3264", Offset = "0x19F3264", VA = "0x19F3264")]
		private bool UpdateTimeValues(Segment segment)
		{
			return default(bool);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x19F777C", Offset = "0x19F777C", VA = "0x19F777C")]
		private float GetSegmentTime(Segment segment)
		{
			return default(float);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x19F69DC", Offset = "0x19F69DC", VA = "0x19F69DC")]
		public static Timing GetInstance(byte ID)
		{
			return null;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x19F6548", Offset = "0x19F6548", VA = "0x19F6548")]
		private void AddTag(string tag, CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x19F4D94", Offset = "0x19F4D94", VA = "0x19F4D94")]
		private void RemoveTag(CoroutineHandle coindex)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x19F6E0C", Offset = "0x19F6E0C", VA = "0x19F6E0C")]
		private bool Nullify(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x19F6AAC", Offset = "0x19F6AAC", VA = "0x19F6AAC")]
		private IEnumerator<float> CoindexExtract(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x19F8BE0", Offset = "0x19F8BE0", VA = "0x19F8BE0")]
		private IEnumerator<float> CoindexPeek(ProcessIndex coindex)
		{
			return null;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x19F4B74", Offset = "0x19F4B74", VA = "0x19F4B74")]
		private bool CoindexIsNull(ProcessIndex coindex)
		{
			return default(bool);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x19F7A64", Offset = "0x19F7A64", VA = "0x19F7A64")]
		private bool SetPause(ProcessIndex coindex, bool newPausedState = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x19F8C6C", Offset = "0x19F8C6C", VA = "0x19F8C6C")]
		private IEnumerator<float> CreatePause(ProcessIndex coindex, IEnumerator<float> coptr, bool newPausedState = true)
		{
			return null;
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x19F782C", Offset = "0x19F782C", VA = "0x19F782C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF130", Offset = "0xADF130")]
		private IEnumerator<float> _InjectDelay(IEnumerator<float> proc, float delayTime)
		{
			return null;
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x19F92D0", Offset = "0x19F92D0", VA = "0x19F92D0")]
		private void CoindexReplace(ProcessIndex coindex, IEnumerator<float> replacement)
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x19F9390", Offset = "0x19F9390", VA = "0x19F9390")]
		public static float WaitForSeconds(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x19F941C", Offset = "0x19F941C", VA = "0x19F941C")]
		public float WaitForSecondsOnInstance(float waitTime)
		{
			return default(float);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x19F9460", Offset = "0x19F9460", VA = "0x19F9460")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine)
		{
			return default(float);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x19F94C8", Offset = "0x19F94C8", VA = "0x19F94C8")]
		public static float WaitUntilDone(CoroutineHandle otherCoroutine, bool warnOnIssue)
		{
			return default(float);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x19F97B8", Offset = "0x19F97B8", VA = "0x19F97B8")]
		private IEnumerator<float> WaitUntilDoneWrapper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x19F9730", Offset = "0x19F9730", VA = "0x19F9730")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF194", Offset = "0xADF194")]
		private IEnumerator<float> _StartWhenDone(CoroutineHandle handle, IEnumerator<float> proc)
		{
			return null;
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x19F4C08", Offset = "0x19F4C08", VA = "0x19F4C08")]
		private void CloseWaitingProcess(CoroutineHandle handle)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x19F9948", Offset = "0x19F9948", VA = "0x19F9948")]
		private bool HandleIsInWaitingList(CoroutineHandle handle)
		{
			return default(bool);
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x19F9A14", Offset = "0x19F9A14", VA = "0x19F9A14")]
		private static IEnumerator<float> ReturnTmpRefForRepFunc(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x19F9A88", Offset = "0x19F9A88", VA = "0x19F9A88")]
		public static float WaitUntilDone(WWW wwwObject)
		{
			return default(float);
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x19F9B60", Offset = "0x19F9B60", VA = "0x19F9B60")]
		private static IEnumerator<float> WaitUntilDoneWwwHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x19F9C10", Offset = "0x19F9C10", VA = "0x19F9C10")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF1F8", Offset = "0xADF1F8")]
		private static IEnumerator<float> _StartWhenDone(WWW www, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x19F9CB8", Offset = "0x19F9CB8", VA = "0x19F9CB8")]
		public static float WaitUntilDone(AsyncOperation operation)
		{
			return default(float);
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x19F9D80", Offset = "0x19F9D80", VA = "0x19F9D80")]
		private static IEnumerator<float> WaitUntilDoneAscOpHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x19F9E30", Offset = "0x19F9E30", VA = "0x19F9E30")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF25C", Offset = "0xADF25C")]
		private static IEnumerator<float> _StartWhenDone(AsyncOperation operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x19F9ED8", Offset = "0x19F9ED8", VA = "0x19F9ED8")]
		public static float WaitUntilDone(CustomYieldInstruction operation)
		{
			return default(float);
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x19F9FA4", Offset = "0x19F9FA4", VA = "0x19F9FA4")]
		private static IEnumerator<float> WaitUntilDoneCustYieldHelper(IEnumerator<float> coptr, CoroutineHandle handle)
		{
			return null;
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x19FA054", Offset = "0x19FA054", VA = "0x19FA054")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF2C0", Offset = "0xADF2C0")]
		private static IEnumerator<float> _StartWhenDone(CustomYieldInstruction operation, IEnumerator<float> pausedProc)
		{
			return null;
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x19FA0FC", Offset = "0x19FA0FC", VA = "0x19FA0FC")]
		public bool LockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x19FA294", Offset = "0x19FA294", VA = "0x19FA294")]
		public bool UnlockCoroutine(CoroutineHandle coroutine, CoroutineHandle key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x19FA3E4", Offset = "0x19FA3E4", VA = "0x19FA3E4")]
		public static CoroutineHandle CallDelayed(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x19FA514", Offset = "0x19FA514", VA = "0x19FA514")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x19FA554", Offset = "0x19FA554", VA = "0x19FA554")]
		public static CoroutineHandle CallDelayed(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x19FA5FC", Offset = "0x19FA5FC", VA = "0x19FA5FC")]
		public CoroutineHandle CallDelayedOnInstance(float delay, Action action, GameObject cancelWith)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x19FA480", Offset = "0x19FA480", VA = "0x19FA480")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF324", Offset = "0xADF324")]
		private IEnumerator<float> _DelayedCall(float delay, Action action, GameObject cancelWith)
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x19FA664", Offset = "0x19FA664", VA = "0x19FA664")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x19FA7B8", Offset = "0x19FA7B8", VA = "0x19FA7B8")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x19FA7F8", Offset = "0x19FA7F8", VA = "0x19FA7F8")]
		public static CoroutineHandle CallPeriodically(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x19FA8B0", Offset = "0x19FA8B0", VA = "0x19FA8B0")]
		public CoroutineHandle CallPeriodicallyOnInstance(float timeframe, float period, Action action, Segment segment, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x19FA8F8", Offset = "0x19FA8F8", VA = "0x19FA8F8")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x19FA9A8", Offset = "0x19FA9A8", VA = "0x19FA9A8")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x19FA9EC", Offset = "0x19FA9EC", VA = "0x19FA9EC")]
		public static CoroutineHandle CallContinuously(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x19FAAA0", Offset = "0x19FAAA0", VA = "0x19FAAA0")]
		public CoroutineHandle CallContinuouslyOnInstance(float timeframe, Action action, Segment timing, [Optional] Action onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x19FA718", Offset = "0x19FA718", VA = "0x19FA718")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF388", Offset = "0xADF388")]
		private IEnumerator<float> _CallContinuously(float timeframe, float period, Action action, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x600019E")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x600019F")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A0")]
		public static CoroutineHandle CallPeriodically<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A1")]
		public CoroutineHandle CallPeriodicallyOnInstance<T>(T reference, float timeframe, float period, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A2")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A3")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A4")]
		public static CoroutineHandle CallContinuously<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A5")]
		public CoroutineHandle CallContinuouslyOnInstance<T>(T reference, float timeframe, Action<T> action, Segment timing, [Optional] Action<T> onDone)
		{
			return default(CoroutineHandle);
		}

		[Token(Token = "0x60001A6")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF3EC", Offset = "0xADF3EC")]
		private IEnumerator<float> _CallContinuously<T>(T reference, float timeframe, float period, Action<T> action, [Optional] Action<T> onDone)
		{
			return null;
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x19FAB18", Offset = "0x19FAB18", VA = "0x19FAB18")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF450", Offset = "0xADF450")]
		public new Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x19FAB20", Offset = "0x19FAB20", VA = "0x19FAB20")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF48C", Offset = "0xADF48C")]
		public new Coroutine StartCoroutine(string methodName, object value)
		{
			return null;
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x19FAB28", Offset = "0x19FAB28", VA = "0x19FAB28")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF4C8", Offset = "0xADF4C8")]
		public new Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x19FAB30", Offset = "0x19FAB30", VA = "0x19FAB30")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF504", Offset = "0xADF504")]
		public new Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x19FAB38", Offset = "0x19FAB38", VA = "0x19FAB38")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF540", Offset = "0xADF540")]
		public new void StopCoroutine(string methodName)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x19FAB3C", Offset = "0x19FAB3C", VA = "0x19FAB3C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF57C", Offset = "0xADF57C")]
		public new void StopCoroutine(IEnumerator routine)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x19FAB40", Offset = "0x19FAB40", VA = "0x19FAB40")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF5B8", Offset = "0xADF5B8")]
		public new void StopCoroutine(Coroutine routine)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x19FAB44", Offset = "0x19FAB44", VA = "0x19FAB44")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF5F4", Offset = "0xADF5F4")]
		public new void StopAllCoroutines()
		{
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x19FAB48", Offset = "0x19FAB48", VA = "0x19FAB48")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF630", Offset = "0xADF630")]
		public new static void Destroy(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x19FAB4C", Offset = "0x19FAB4C", VA = "0x19FAB4C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF66C", Offset = "0xADF66C")]
		public new static void Destroy(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x19FAB50", Offset = "0x19FAB50", VA = "0x19FAB50")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF6A8", Offset = "0xADF6A8")]
		public static void DestroyObject(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x19FAB54", Offset = "0x19FAB54", VA = "0x19FAB54")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF6E4", Offset = "0xADF6E4")]
		public static void DestroyObject(UnityEngine.Object obj, float f)
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x19FAB58", Offset = "0x19FAB58", VA = "0x19FAB58")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF720", Offset = "0xADF720")]
		public new static void DestroyImmediate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x19FAB5C", Offset = "0x19FAB5C", VA = "0x19FAB5C")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF75C", Offset = "0xADF75C")]
		public new static void DestroyImmediate(UnityEngine.Object obj, bool b)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x19FAB60", Offset = "0x19FAB60", VA = "0x19FAB60")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF798", Offset = "0xADF798")]
		public new static void Instantiate(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x19FAB64", Offset = "0x19FAB64", VA = "0x19FAB64")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF7D4", Offset = "0xADF7D4")]
		public new static void Instantiate(UnityEngine.Object original, Vector3 position, Quaternion rotation)
		{
		}

		[Token(Token = "0x60001B7")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF810", Offset = "0xADF810")]
		public new static void Instantiate<T>(T original) where T : UnityEngine.Object
		{
		}

		[Token(Token = "0x60001B8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF84C", Offset = "0xADF84C")]
		public new static T FindObjectOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x19FAB68", Offset = "0x19FAB68", VA = "0x19FAB68")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF888", Offset = "0xADF888")]
		public new static UnityEngine.Object FindObjectOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF8C4", Offset = "0xADF8C4")]
		public new static T[] FindObjectsOfType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x19FAB70", Offset = "0x19FAB70", VA = "0x19FAB70")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF900", Offset = "0xADF900")]
		public new static UnityEngine.Object[] FindObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x19FAB78", Offset = "0x19FAB78", VA = "0x19FAB78")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0xADF93C", Offset = "0xADF93C")]
		public new static void print(object message)
		{
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x19FAB7C", Offset = "0x19FAB7C", VA = "0x19FAB7C")]
		public Timing()
		{
		}
	}
	[Token(Token = "0x200003C")]
	public enum Segment
	{
		[Token(Token = "0x40001CB")]
		Invalid = -1,
		[Token(Token = "0x40001CC")]
		Update,
		[Token(Token = "0x40001CD")]
		FixedUpdate,
		[Token(Token = "0x40001CE")]
		LateUpdate,
		[Token(Token = "0x40001CF")]
		SlowUpdate
	}
	[Token(Token = "0x200003D")]
	public enum DebugInfoType
	{
		[Token(Token = "0x40001D1")]
		None,
		[Token(Token = "0x40001D2")]
		SeperateCoroutines,
		[Token(Token = "0x40001D3")]
		SeperateTags
	}
	[Token(Token = "0x200003E")]
	public struct CoroutineHandle : IEquatable<CoroutineHandle>
	{
		[Token(Token = "0x40001D4")]
		private const byte ReservedSpace = 15;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int[] NextIndex;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly int _id;

		[Token(Token = "0x17000024")]
		public byte Key
		{
			[Token(Token = "0x60001BF")]
			[Address(RVA = "0x19F1D2C", Offset = "0x19F1D2C", VA = "0x19F1D2C")]
			get
			{
				return default(byte);
			}
		}

		[Token(Token = "0x17000025")]
		public bool IsValid
		{
			[Token(Token = "0x60001C6")]
			[Address(RVA = "0x19F1EDC", Offset = "0x19F1EDC", VA = "0x19F1EDC")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x19F1D38", Offset = "0x19F1D38", VA = "0x19F1D38")]
		public CoroutineHandle(byte ind)
		{
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x19F1E24", Offset = "0x19F1E24", VA = "0x19F1E24", Slot = "4")]
		public bool Equals(CoroutineHandle other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x19F1E34", Offset = "0x19F1E34", VA = "0x19F1E34", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x19F1EBC", Offset = "0x19F1EBC", VA = "0x19F1EBC")]
		public static bool operator ==(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x19F1EC8", Offset = "0x19F1EC8", VA = "0x19F1EC8")]
		public static bool operator !=(CoroutineHandle a, CoroutineHandle b)
		{
			return default(bool);
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x19F1ED4", Offset = "0x19F1ED4", VA = "0x19F1ED4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
namespace Unity.Labs.SuperScience
{
	[Token(Token = "0x200003F")]
	public class Stabilizr : MonoBehaviour
	{
		[Token(Token = "0x40001D7")]
		private const float k_AngleStabilization = 4f;

		[Token(Token = "0x40001D8")]
		private const float k_90FPS = 1f / 90f;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE5E0", Offset = "0xADE5E0")]
		private Transform m_FollowSource;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE62C", Offset = "0xADE62C")]
		private Transform m_StabilizationPoint;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE678", Offset = "0xADE678")]
		private bool m_UsePreviousOrientation;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xADE6C4", Offset = "0xADE6C4")]
		private bool m_UseEndPoint;

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x208B25C", Offset = "0x208B25C", VA = "0x208B25C")]
		private void Start()
		{
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x208B284", Offset = "0x208B284", VA = "0x208B284")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x208B618", Offset = "0x208B618", VA = "0x208B618")]
		private float CalculateStabilizedLerp(float distance, float timeSlice)
		{
			return default(float);
		}

		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x208B728", Offset = "0x208B728", VA = "0x208B728")]
		public Stabilizr()
		{
		}
	}
}
namespace DigitalOpus.MB.Core
{
	[Token(Token = "0x2000040")]
	public class MBVersionConcrete : MBVersionInterface
	{
		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Vector2 _HALF_UV;

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x1AA5B74", Offset = "0x1AA5B74", VA = "0x1AA5B74", Slot = "4")]
		public string version()
		{
			return null;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x1AA5BBC", Offset = "0x1AA5BBC", VA = "0x1AA5BBC", Slot = "5")]
		public int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x1AA5C68", Offset = "0x1AA5C68", VA = "0x1AA5C68", Slot = "6")]
		public int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x1AA5D18", Offset = "0x1AA5D18", VA = "0x1AA5D18", Slot = "7")]
		public bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x1AA5D34", Offset = "0x1AA5D34", VA = "0x1AA5D34", Slot = "8")]
		public void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x1AA5D54", Offset = "0x1AA5D54", VA = "0x1AA5D54", Slot = "9")]
		public void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x1AA5D74", Offset = "0x1AA5D74", VA = "0x1AA5D74", Slot = "10")]
		public UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x1AA5DDC", Offset = "0x1AA5DDC", VA = "0x1AA5DDC", Slot = "18")]
		public void OptimizeMesh(Mesh m)
		{
		}

		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x1AA5DE0", Offset = "0x1AA5DE0", VA = "0x1AA5DE0", Slot = "11")]
		public bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x1AA5E2C", Offset = "0x1AA5E2C", VA = "0x1AA5E2C")]
		public Vector2[] GetMeshUV1s(Mesh m, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x1AA60E0", Offset = "0x1AA60E0", VA = "0x1AA60E0", Slot = "12")]
		public Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x1AA63B0", Offset = "0x1AA63B0", VA = "0x1AA63B0", Slot = "13")]
		public void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x1AA63D0", Offset = "0x1AA63D0", VA = "0x1AA63D0", Slot = "14")]
		public void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x1AA63F0", Offset = "0x1AA63F0", VA = "0x1AA63F0", Slot = "15")]
		public void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x1AA6410", Offset = "0x1AA6410", VA = "0x1AA6410", Slot = "16")]
		public Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x1AA642C", Offset = "0x1AA642C", VA = "0x1AA642C", Slot = "17")]
		public Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x1AA6590", Offset = "0x1AA6590", VA = "0x1AA6590", Slot = "19")]
		public int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return default(int);
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x1AA65B0", Offset = "0x1AA65B0", VA = "0x1AA65B0", Slot = "20")]
		public float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x1AA65D4", Offset = "0x1AA65D4", VA = "0x1AA65D4", Slot = "21")]
		public void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x1AA6604", Offset = "0x1AA6604", VA = "0x1AA6604", Slot = "22")]
		public void ClearBlendShapes(Mesh m)
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x1AA6620", Offset = "0x1AA6620", VA = "0x1AA6620", Slot = "23")]
		public void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x1AA664C", Offset = "0x1AA664C", VA = "0x1AA664C", Slot = "24")]
		public int MaxMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x1AA6654", Offset = "0x1AA6654", VA = "0x1AA6654", Slot = "25")]
		public void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x1AA6708", Offset = "0x1AA6708", VA = "0x1AA6708")]
		public MBVersionConcrete()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000041")]
	public class GrouperData
	{
		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool clusterOnLMIndex;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
		public bool clusterByLODLevel;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 origin;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 cellSize;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int pieNumSegments;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 pieAxis;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int height;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float maxDistBetweenClusters;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool includeCellsWithOnlyOneRenderer;

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x141B108", Offset = "0x141B108", VA = "0x141B108")]
		public GrouperData()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000042")]
	public abstract class MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x20000E9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD784", Offset = "0xADD784")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000458")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Renderer r;

			[Token(Token = "0x4000459")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Predicate<Renderer> <>9__0;

			[Token(Token = "0x600083A")]
			[Address(RVA = "0x19AF5BC", Offset = "0x19AF5BC", VA = "0x19AF5BC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600083B")]
			[Address(RVA = "0x19AF8A0", Offset = "0x19AF8A0", VA = "0x19AF8A0")]
			internal bool <DoClustering>b__0(Renderer x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GrouperData d;

		[Token(Token = "0x60001E5")]
		public abstract Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection);

		[Token(Token = "0x60001E6")]
		public abstract void DrawGizmos(Bounds sourceObjectBounds);

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x19AE700", Offset = "0x19AE700", VA = "0x19AE700")]
		public void DoClustering(MB3_TextureBaker tb, MB3_MeshBakerGrouper grouper)
		{
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x19AF3D0", Offset = "0x19AF3D0", VA = "0x19AF3D0")]
		private Dictionary<int, List<Renderer>> GroupByLightmapIndex(List<Renderer> gaws)
		{
			return null;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x19AF5C4", Offset = "0x19AF5C4", VA = "0x19AF5C4")]
		private void AddMeshBaker(MB3_TextureBaker tb, string key, List<Renderer> gaws)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x19AD8A4", Offset = "0x19AD8A4", VA = "0x19AD8A4")]
		protected MB3_MeshBakerGrouperCore()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000043")]
	public class MB3_MeshBakerGrouperNone : MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x19B08B8", Offset = "0x19B08B8", VA = "0x19B08B8")]
		public MB3_MeshBakerGrouperNone(GrouperData d)
		{
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x19B08E4", Offset = "0x19B08E4", VA = "0x19B08E4", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x19B0AB4", Offset = "0x19B0AB4", VA = "0x19B0AB4", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000044")]
	public class MB3_MeshBakerGrouperGrid : MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x19AF91C", Offset = "0x19AF91C", VA = "0x19AF91C")]
		public MB3_MeshBakerGrouperGrid(GrouperData d)
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x19AF948", Offset = "0x19AF948", VA = "0x19AF948", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x19AFDC0", Offset = "0x19AFDC0", VA = "0x19AFDC0", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000045")]
	public class MB3_MeshBakerGrouperPie : MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x19B0AB8", Offset = "0x19B0AB8", VA = "0x19B0AB8")]
		public MB3_MeshBakerGrouperPie(GrouperData data)
		{
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x19B0AE4", Offset = "0x19B0AE4", VA = "0x19B0AE4", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x19B11D8", Offset = "0x19B11D8", VA = "0x19B11D8", Slot = "5")]
		public override void DrawGizmos(Bounds sourceObjectBounds)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x19B1518", Offset = "0x19B1518", VA = "0x19B1518")]
		public static void DrawCircle(Vector3 axis, Vector3 center, float radius, int subdiv)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000046")]
	public class MB3_MeshBakerGrouperKMeans : MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numClusters;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3[] clusterCenters;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float[] clusterSizes;

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x19B03D4", Offset = "0x19B03D4", VA = "0x19B03D4")]
		public MB3_MeshBakerGrouperKMeans(GrouperData data)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x19B0468", Offset = "0x19B0468", VA = "0x19B0468", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x19B07FC", Offset = "0x19B07FC", VA = "0x19B07FC", Slot = "5")]
		public override void DrawGizmos(Bounds sceneObjectBounds)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000047")]
	public class MB3_MeshBakerGrouperCluster : MB3_MeshBakerGrouperCore
	{
		[Token(Token = "0x20000EA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD794", Offset = "0xADD794")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400045A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<GameObject> gos;

			[Token(Token = "0x600083C")]
			[Address(RVA = "0x19ADF58", Offset = "0x19ADF58", VA = "0x19ADF58")]
			public <>c__DisplayClass8_0()
			{
			}
		}

		[Token(Token = "0x20000EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7A4", Offset = "0xADD7A4")]
		private sealed class <>c__DisplayClass8_1
		{
			[Token(Token = "0x400045B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400045C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals1;

			[Token(Token = "0x600083D")]
			[Address(RVA = "0x19ADF60", Offset = "0x19ADF60", VA = "0x19ADF60")]
			public <>c__DisplayClass8_1()
			{
			}

			[Token(Token = "0x600083E")]
			[Address(RVA = "0x19AE648", Offset = "0x19AE648", VA = "0x19AE648")]
			internal bool <BuildClusters>b__0(MB3_AgglomerativeClustering.item_s x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MB3_AgglomerativeClustering cluster;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float _lastMaxDistBetweenClusters;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float _ObjsExtents;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float _minDistBetweenClusters;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<MB3_AgglomerativeClustering.ClusterNode> _clustersToDraw;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float[] _radii;

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x19AD814", Offset = "0x19AD814", VA = "0x19AD814")]
		public MB3_MeshBakerGrouperCluster(GrouperData data, List<GameObject> gos)
		{
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x19AD8AC", Offset = "0x19AD8AC", VA = "0x19AD8AC", Slot = "4")]
		public override Dictionary<string, List<Renderer>> FilterIntoGroups(List<GameObject> selection)
		{
			return null;
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x19ADB08", Offset = "0x19ADB08", VA = "0x19ADB08")]
		public void BuildClusters(List<GameObject> gos, ProgressUpdateCancelableDelegate progFunc)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x19ADF68", Offset = "0x19ADF68", VA = "0x19ADF68")]
		private void _BuildListOfClustersToDraw(ProgressUpdateCancelableDelegate progFunc, out float smallest, out float largest)
		{
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x19AE514", Offset = "0x19AE514", VA = "0x19AE514", Slot = "5")]
		public override void DrawGizmos(Bounds sceneObjectBounds)
		{
		}
	}
	[Token(Token = "0x2000048")]
	public interface TextureBlender
	{
		[Token(Token = "0x60001FD")]
		bool DoesShaderNameMatch(string shaderName);

		[Token(Token = "0x60001FE")]
		void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName);

		[Token(Token = "0x60001FF")]
		UnityEngine.Color OnBlendTexturePixel(string shaderPropertyName, UnityEngine.Color pixelColor);

		[Token(Token = "0x6000200")]
		bool NonTexturePropertiesAreEqual(Material a, Material b);

		[Token(Token = "0x6000201")]
		void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial);

		[Token(Token = "0x6000202")]
		UnityEngine.Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName);
	}
	[Token(Token = "0x2000049")]
	public class TextureBlenderFallback : TextureBlender
	{
		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_doTintColor;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private UnityEngine.Color m_defaultColor;

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1AAA164", Offset = "0x1AAA164", VA = "0x1AAA164", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x1AAA16C", Offset = "0x1AAA16C", VA = "0x1AAA16C", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x1AAA254", Offset = "0x1AAA254", VA = "0x1AAA254", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string shaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1AAA2B0", Offset = "0x1AAA2B0", VA = "0x1AAA2B0", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1AAA474", Offset = "0x1AAA474", VA = "0x1AAA474", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1AAA524", Offset = "0x1AAA524", VA = "0x1AAA524", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texProperty)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x1AAA368", Offset = "0x1AAA368", VA = "0x1AAA368")]
		public static bool _compareColor(Material a, Material b, UnityEngine.Color defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1AAAEE8", Offset = "0x1AAAEE8", VA = "0x1AAAEE8")]
		public static bool _compareFloat(Material a, Material b, float defaultVal, string propertyName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x1AAAF84", Offset = "0x1AAAF84", VA = "0x1AAAF84")]
		public TextureBlenderFallback()
		{
		}
	}
	[Token(Token = "0x200004A")]
	public class TextureBlenderLegacyBumpDiffuse : TextureBlender
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool doColor;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private UnityEngine.Color m_defaultTintColor;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x1AAAFB8", Offset = "0x1AAAFB8", VA = "0x1AAAFB8", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1AAB040", Offset = "0x1AAB040", VA = "0x1AAB040", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1AAB0E8", Offset = "0x1AAB0E8", VA = "0x1AAB0E8", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x1AAB144", Offset = "0x1AAB144", VA = "0x1AAB144", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x1AAB1B0", Offset = "0x1AAB1B0", VA = "0x1AAB1B0", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x1AAB214", Offset = "0x1AAB214", VA = "0x1AAB214", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1AAB3D4", Offset = "0x1AAB3D4", VA = "0x1AAB3D4")]
		public TextureBlenderLegacyBumpDiffuse()
		{
		}
	}
	[Token(Token = "0x200004B")]
	public class TextureBlenderLegacyDiffuse : TextureBlender
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool doColor;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private UnityEngine.Color m_defaultTintColor;

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x1AAB408", Offset = "0x1AAB408", VA = "0x1AAB408", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x1AAB490", Offset = "0x1AAB490", VA = "0x1AAB490", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x1AAB538", Offset = "0x1AAB538", VA = "0x1AAB538", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x1AAB594", Offset = "0x1AAB594", VA = "0x1AAB594", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x1AAB600", Offset = "0x1AAB600", VA = "0x1AAB600", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x1AAB664", Offset = "0x1AAB664", VA = "0x1AAB664", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material m, ShaderTextureProperty texPropertyName)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x1AAB7E4", Offset = "0x1AAB7E4", VA = "0x1AAB7E4")]
		public TextureBlenderLegacyDiffuse()
		{
		}
	}
	[Token(Token = "0x200004C")]
	public class TextureBlenderMaterialPropertyCacheHelper
	{
		[Token(Token = "0x20000EC")]
		private struct MaterialPropertyPair
		{
			[Token(Token = "0x400045D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Material material;

			[Token(Token = "0x400045E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public string property;

			[Token(Token = "0x600083F")]
			[Address(RVA = "0x1AABA80", Offset = "0x1AABA80", VA = "0x1AABA80")]
			public MaterialPropertyPair(Material m, string prop)
			{
			}

			[Token(Token = "0x6000840")]
			[Address(RVA = "0x1AABC74", Offset = "0x1AABC74", VA = "0x1AABC74", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000841")]
			[Address(RVA = "0x1AABD28", Offset = "0x1AABD28", VA = "0x1AABD28", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<MaterialPropertyPair, object> nonTexturePropertyValuesForSourceMaterials;

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x1AAB818", Offset = "0x1AAB818", VA = "0x1AAB818")]
		private bool AllNonTexturePropertyValuesAreEqual(string prop)
		{
			return default(bool);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x1AABA00", Offset = "0x1AABA00", VA = "0x1AABA00")]
		public void CacheMaterialProperty(Material m, string property, object value)
		{
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x1AABA88", Offset = "0x1AABA88", VA = "0x1AABA88")]
		public object GetValueIfAllSourceAreTheSameOrDefault(string property, object defaultValue)
		{
			return null;
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x1AABC04", Offset = "0x1AABC04", VA = "0x1AABC04")]
		public TextureBlenderMaterialPropertyCacheHelper()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public class TextureBlenderStandardMetallic : TextureBlender
	{
		[Token(Token = "0x20000ED")]
		private enum Prop
		{
			[Token(Token = "0x4000460")]
			doColor,
			[Token(Token = "0x4000461")]
			doMetallic,
			[Token(Token = "0x4000462")]
			doEmission,
			[Token(Token = "0x4000463")]
			doBump,
			[Token(Token = "0x4000464")]
			doNone
		}

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityEngine.Color NeutralNormalMap;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_glossiness;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_glossMapScale;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float m_metallic;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool m_hasMetallicGlossMap;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_bumpScale;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private UnityEngine.Color m_emissionColor;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Prop propertyToDo;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private UnityEngine.Color m_generatingTintedAtlasColor;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_generatingTintedAtlasMetallic;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_generatingTintedAtlasGlossiness;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private float m_generatingTintedAtlasGlossMapScale;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private float m_generatingTintedAtlasBumpScale;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private UnityEngine.Color m_generatingTintedAtlasEmission;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x1AABD9C", Offset = "0x1AABD9C", VA = "0x1AABD9C", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x1AABDF8", Offset = "0x1AABDF8", VA = "0x1AABDF8", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x1AAC0F0", Offset = "0x1AAC0F0", VA = "0x1AAC0F0", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x1AAC27C", Offset = "0x1AAC27C", VA = "0x1AAC27C", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x1AAC4B8", Offset = "0x1AAC4B8", VA = "0x1AAC4B8", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x1AAC8F0", Offset = "0x1AAC8F0", VA = "0x1AAC8F0", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x1AACF64", Offset = "0x1AACF64", VA = "0x1AACF64")]
		public TextureBlenderStandardMetallic()
		{
		}
	}
	[Token(Token = "0x200004E")]
	public class TextureBlenderStandardMetallicRoughness : TextureBlender
	{
		[Token(Token = "0x20000EE")]
		private enum Prop
		{
			[Token(Token = "0x4000466")]
			doColor,
			[Token(Token = "0x4000467")]
			doMetallic,
			[Token(Token = "0x4000468")]
			doRoughness,
			[Token(Token = "0x4000469")]
			doEmission,
			[Token(Token = "0x400046A")]
			doBump,
			[Token(Token = "0x400046B")]
			doNone
		}

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityEngine.Color NeutralNormalMap;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_roughness;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_metallic;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool m_hasMetallicGlossMap;

		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool m_hasSpecGlossMap;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_bumpScale;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private UnityEngine.Color m_emissionColor;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private Prop propertyToDo;

		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private UnityEngine.Color m_generatingTintedAtlasColor;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private float m_generatingTintedAtlasMetallic;

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private float m_generatingTintedAtlasRoughness;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private float m_generatingTintedAtlasBumpScale;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private UnityEngine.Color m_generatingTintedAtlasEmission;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float m_notGeneratingAtlasDefaultMetallic;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x1AAD0A0", Offset = "0x1AAD0A0", VA = "0x1AAD0A0", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x1AAD0FC", Offset = "0x1AAD0FC", VA = "0x1AAD0FC", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x1AAD448", Offset = "0x1AAD448", VA = "0x1AAD448", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x1AAD5CC", Offset = "0x1AAD5CC", VA = "0x1AAD5CC", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x1AAD910", Offset = "0x1AAD910", VA = "0x1AAD910", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x1AADD60", Offset = "0x1AADD60", VA = "0x1AADD60", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x1AAE4D0", Offset = "0x1AAE4D0", VA = "0x1AAE4D0")]
		public TextureBlenderStandardMetallicRoughness()
		{
		}
	}
	[Token(Token = "0x200004F")]
	public class TextureBlenderStandardSpecular : TextureBlender
	{
		[Token(Token = "0x20000EF")]
		private enum Prop
		{
			[Token(Token = "0x400046D")]
			doColor,
			[Token(Token = "0x400046E")]
			doSpecular,
			[Token(Token = "0x400046F")]
			doEmission,
			[Token(Token = "0x4000470")]
			doBump,
			[Token(Token = "0x4000471")]
			doNone
		}

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static UnityEngine.Color NeutralNormalMap;

		[Token(Token = "0x4000225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TextureBlenderMaterialPropertyCacheHelper sourceMaterialPropertyCache;

		[Token(Token = "0x4000226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private UnityEngine.Color m_tintColor;

		[Token(Token = "0x4000227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_glossiness;

		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float m_SpecGlossMapScale;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityEngine.Color m_specColor;

		[Token(Token = "0x400022A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool m_hasSpecGlossMap;

		[Token(Token = "0x400022B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float m_bumpScale;

		[Token(Token = "0x400022C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool m_shaderDoesEmission;

		[Token(Token = "0x400022D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private UnityEngine.Color m_emissionColor;

		[Token(Token = "0x400022E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Prop propertyToDo;

		[Token(Token = "0x400022F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private UnityEngine.Color m_generatingTintedAtlaColor;

		[Token(Token = "0x4000230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private UnityEngine.Color m_generatingTintedAtlaSpecular;

		[Token(Token = "0x4000231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private float m_generatingTintedAtlaGlossiness;

		[Token(Token = "0x4000232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		private float m_generatingTintedAtlaSpecGlossMapScale;

		[Token(Token = "0x4000233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float m_generatingTintedAtlaBumpScale;

		[Token(Token = "0x4000234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private UnityEngine.Color m_generatingTintedAtlaEmission;

		[Token(Token = "0x4000235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultColor;

		[Token(Token = "0x4000236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultSpecularColor;

		[Token(Token = "0x4000237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
		private float m_notGeneratingAtlasDefaultGlossiness;

		[Token(Token = "0x4000238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private UnityEngine.Color m_notGeneratingAtlasDefaultEmisionColor;

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x1AAE608", Offset = "0x1AAE608", VA = "0x1AAE608", Slot = "4")]
		public bool DoesShaderNameMatch(string shaderName)
		{
			return default(bool);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x1AAE664", Offset = "0x1AAE664", VA = "0x1AAE664", Slot = "5")]
		public void OnBeforeTintTexture(Material sourceMat, string shaderTexturePropertyName)
		{
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x1AAE990", Offset = "0x1AAE990", VA = "0x1AAE990", Slot = "6")]
		public UnityEngine.Color OnBlendTexturePixel(string propertyToDoshaderPropertyName, UnityEngine.Color pixelColor)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x1AAEB18", Offset = "0x1AAEB18", VA = "0x1AAEB18", Slot = "7")]
		public bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x1AAED78", Offset = "0x1AAED78", VA = "0x1AAED78", Slot = "8")]
		public void SetNonTexturePropertyValuesOnResultMaterial(Material resultMaterial)
		{
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x1AAF1BC", Offset = "0x1AAF1BC", VA = "0x1AAF1BC", Slot = "9")]
		public UnityEngine.Color GetColorIfNoTexture(Material mat, ShaderTextureProperty texPropertyName)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x1AAF834", Offset = "0x1AAF834", VA = "0x1AAF834")]
		public TextureBlenderStandardSpecular()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public delegate void ProgressUpdateDelegate(string msg, float progress);
	[Token(Token = "0x2000051")]
	public delegate bool ProgressUpdateCancelableDelegate(string msg, float progress);
	[Token(Token = "0x2000052")]
	public enum MB_ObjsToCombineTypes
	{
		[Token(Token = "0x400023A")]
		prefabOnly,
		[Token(Token = "0x400023B")]
		sceneObjOnly,
		[Token(Token = "0x400023C")]
		dontCare
	}
	[Token(Token = "0x2000053")]
	public enum MB_OutputOptions
	{
		[Token(Token = "0x400023E")]
		bakeIntoPrefab,
		[Token(Token = "0x400023F")]
		bakeMeshsInPlace,
		[Token(Token = "0x4000240")]
		bakeTextureAtlasesOnly,
		[Token(Token = "0x4000241")]
		bakeIntoSceneObject
	}
	[Token(Token = "0x2000054")]
	public enum MB_RenderType
	{
		[Token(Token = "0x4000243")]
		meshRenderer,
		[Token(Token = "0x4000244")]
		skinnedMeshRenderer
	}
	[Token(Token = "0x2000055")]
	public enum MB2_OutputOptions
	{
		[Token(Token = "0x4000246")]
		bakeIntoSceneObject,
		[Token(Token = "0x4000247")]
		bakeMeshAssetsInPlace,
		[Token(Token = "0x4000248")]
		bakeIntoPrefab
	}
	[Token(Token = "0x2000056")]
	public enum MB2_LightmapOptions
	{
		[Token(Token = "0x400024A")]
		preserve_current_lightmapping,
		[Token(Token = "0x400024B")]
		ignore_UV2,
		[Token(Token = "0x400024C")]
		copy_UV2_unchanged,
		[Token(Token = "0x400024D")]
		generate_new_UV2_layout,
		[Token(Token = "0x400024E")]
		copy_UV2_unchanged_to_separate_rects
	}
	[Token(Token = "0x2000057")]
	public enum MB2_PackingAlgorithmEnum
	{
		[Token(Token = "0x4000250")]
		UnitysPackTextures,
		[Token(Token = "0x4000251")]
		MeshBakerTexturePacker,
		[Token(Token = "0x4000252")]
		MeshBakerTexturePacker_Fast,
		[Token(Token = "0x4000253")]
		MeshBakerTexturePacker_Horizontal,
		[Token(Token = "0x4000254")]
		MeshBakerTexturePacker_Vertical
	}
	[Token(Token = "0x2000058")]
	public enum MB_TextureTilingTreatment
	{
		[Token(Token = "0x4000256")]
		none,
		[Token(Token = "0x4000257")]
		considerUVs,
		[Token(Token = "0x4000258")]
		edgeToEdgeX,
		[Token(Token = "0x4000259")]
		edgeToEdgeY,
		[Token(Token = "0x400025A")]
		edgeToEdgeXY,
		[Token(Token = "0x400025B")]
		unknown
	}
	[Token(Token = "0x2000059")]
	public enum MB2_ValidationLevel
	{
		[Token(Token = "0x400025D")]
		none,
		[Token(Token = "0x400025E")]
		quick,
		[Token(Token = "0x400025F")]
		robust
	}
	[Token(Token = "0x200005A")]
	public interface MB2_EditorMethodsInterface
	{
		[Token(Token = "0x600023E")]
		void Clear();

		[Token(Token = "0x600023F")]
		void RestoreReadFlagsAndFormats(ProgressUpdateDelegate progressInfo);

		[Token(Token = "0x6000240")]
		void SetReadWriteFlag(Texture2D tx, bool isReadable, bool addToList);

		[Token(Token = "0x6000241")]
		void AddTextureFormat(Texture2D tx, bool isNormalMap);

		[Token(Token = "0x6000242")]
		void SaveAtlasToAssetDatabase(Texture2D atlas, ShaderTextureProperty texPropertyName, int atlasNum, Material resMat);

		[Token(Token = "0x6000243")]
		bool IsNormalMap(Texture2D tx);

		[Token(Token = "0x6000244")]
		string GetPlatformString();

		[Token(Token = "0x6000245")]
		void SetTextureSize(Texture2D tx, int size);

		[Token(Token = "0x6000246")]
		bool IsCompressed(Texture2D tx);

		[Token(Token = "0x6000247")]
		void CheckBuildSettings(long estimatedAtlasSize);

		[Token(Token = "0x6000248")]
		bool CheckPrefabTypes(MB_ObjsToCombineTypes prefabType, List<GameObject> gos);

		[Token(Token = "0x6000249")]
		bool ValidateSkinnedMeshes(List<GameObject> mom);

		[Token(Token = "0x600024A")]
		void CommitChangesToAssets();

		[Token(Token = "0x600024B")]
		void OnPreTextureBake();

		[Token(Token = "0x600024C")]
		void OnPostTextureBake();

		[Token(Token = "0x600024D")]
		void Destroy(UnityEngine.Object o);
	}
	[Token(Token = "0x200005B")]
	public enum MB2_LogLevel
	{
		[Token(Token = "0x4000261")]
		none,
		[Token(Token = "0x4000262")]
		error,
		[Token(Token = "0x4000263")]
		warn,
		[Token(Token = "0x4000264")]
		info,
		[Token(Token = "0x4000265")]
		debug,
		[Token(Token = "0x4000266")]
		trace
	}
	[Token(Token = "0x200005C")]
	public class MB2_Log
	{
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x141B19C", Offset = "0x141B19C", VA = "0x141B19C")]
		public static void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0x141B3AC", Offset = "0x141B3AC", VA = "0x141B3AC")]
		public static string Error(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0x141B488", Offset = "0x141B488", VA = "0x141B488")]
		public static string Warn(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000251")]
		[Address(RVA = "0x141B564", Offset = "0x141B564", VA = "0x141B564")]
		public static string Info(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0x141B640", Offset = "0x141B640", VA = "0x141B640")]
		public static string LogDebug(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000253")]
		[Address(RVA = "0x141B71C", Offset = "0x141B71C", VA = "0x141B71C")]
		public static string Trace(string msg, params object[] args)
		{
			return null;
		}

		[Token(Token = "0x6000254")]
		[Address(RVA = "0x141B7F8", Offset = "0x141B7F8", VA = "0x141B7F8")]
		public MB2_Log()
		{
		}
	}
	[Token(Token = "0x200005D")]
	public class ObjectLog
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int pos;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string[] logMessages;

		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1AA979C", Offset = "0x1AA979C", VA = "0x1AA979C")]
		private void _CacheLogMessage(string msg)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1AA9844", Offset = "0x1AA9844", VA = "0x1AA9844")]
		public ObjectLog(short bufferSize)
		{
		}

		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1AA98B4", Offset = "0x1AA98B4", VA = "0x1AA98B4")]
		public void Log(MB2_LogLevel l, string msg, MB2_LogLevel currentThreshold)
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1AA98F0", Offset = "0x1AA98F0", VA = "0x1AA98F0")]
		public void Error(string msg, params object[] args)
		{
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1AA9924", Offset = "0x1AA9924", VA = "0x1AA9924")]
		public void Warn(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1AA9958", Offset = "0x1AA9958", VA = "0x1AA9958")]
		public void Info(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1AA998C", Offset = "0x1AA998C", VA = "0x1AA998C")]
		public void LogDebug(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1AA99C0", Offset = "0x1AA99C0", VA = "0x1AA99C0")]
		public void Trace(string msg, params object[] args)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1AA99F4", Offset = "0x1AA99F4", VA = "0x1AA99F4")]
		public string Dump()
		{
			return null;
		}
	}
	[Token(Token = "0x200005E")]
	public interface MBVersionInterface
	{
		[Token(Token = "0x600025E")]
		string version();

		[Token(Token = "0x600025F")]
		int GetMajorVersion();

		[Token(Token = "0x6000260")]
		int GetMinorVersion();

		[Token(Token = "0x6000261")]
		bool GetActive(GameObject go);

		[Token(Token = "0x6000262")]
		void SetActive(GameObject go, bool isActive);

		[Token(Token = "0x6000263")]
		void SetActiveRecursively(GameObject go, bool isActive);

		[Token(Token = "0x6000264")]
		UnityEngine.Object[] FindSceneObjectsOfType(Type t);

		[Token(Token = "0x6000265")]
		bool IsRunningAndMeshNotReadWriteable(Mesh m);

		[Token(Token = "0x6000266")]
		Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x6000267")]
		void MeshClear(Mesh m, bool t);

		[Token(Token = "0x6000268")]
		void MeshAssignUV3(Mesh m, Vector2[] uv3s);

		[Token(Token = "0x6000269")]
		void MeshAssignUV4(Mesh m, Vector2[] uv4s);

		[Token(Token = "0x600026A")]
		Vector4 GetLightmapTilingOffset(Renderer r);

		[Token(Token = "0x600026B")]
		Transform[] GetBones(Renderer r);

		[Token(Token = "0x600026C")]
		void OptimizeMesh(Mesh m);

		[Token(Token = "0x600026D")]
		int GetBlendShapeFrameCount(Mesh m, int shapeIndex);

		[Token(Token = "0x600026E")]
		float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex);

		[Token(Token = "0x600026F")]
		void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		[Token(Token = "0x6000270")]
		void ClearBlendShapes(Mesh m);

		[Token(Token = "0x6000271")]
		void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		[Token(Token = "0x6000272")]
		int MaxMeshVertexCount();

		[Token(Token = "0x6000273")]
		void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles);
	}
	[Token(Token = "0x200005F")]
	public class MBVersion
	{
		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static MBVersionInterface _MBVersion;

		[Token(Token = "0x6000274")]
		[Address(RVA = "0x1AA4570", Offset = "0x1AA4570", VA = "0x1AA4570")]
		private static MBVersionInterface _CreateMBVersionConcrete()
		{
			return null;
		}

		[Token(Token = "0x6000275")]
		[Address(RVA = "0x1AA4618", Offset = "0x1AA4618", VA = "0x1AA4618")]
		public static string version()
		{
			return null;
		}

		[Token(Token = "0x6000276")]
		[Address(RVA = "0x1AA46F4", Offset = "0x1AA46F4", VA = "0x1AA46F4")]
		public static int GetMajorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1AA47D4", Offset = "0x1AA47D4", VA = "0x1AA47D4")]
		public static int GetMinorVersion()
		{
			return default(int);
		}

		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1AA48B4", Offset = "0x1AA48B4", VA = "0x1AA48B4")]
		public static bool GetActive(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000279")]
		[Address(RVA = "0x1AA49A4", Offset = "0x1AA49A4", VA = "0x1AA49A4")]
		public static void SetActive(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0x1AA4A9C", Offset = "0x1AA4A9C", VA = "0x1AA4A9C")]
		public static void SetActiveRecursively(GameObject go, bool isActive)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1AA4B94", Offset = "0x1AA4B94", VA = "0x1AA4B94")]
		public static UnityEngine.Object[] FindSceneObjectsOfType(Type t)
		{
			return null;
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0x1AA4C84", Offset = "0x1AA4C84", VA = "0x1AA4C84")]
		public static bool IsRunningAndMeshNotReadWriteable(Mesh m)
		{
			return default(bool);
		}

		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1AA4D74", Offset = "0x1AA4D74", VA = "0x1AA4D74")]
		public static Vector2[] GetMeshUV3orUV4(Mesh m, bool get3, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1AA4E7C", Offset = "0x1AA4E7C", VA = "0x1AA4E7C")]
		public static void MeshClear(Mesh m, bool t)
		{
		}

		[Token(Token = "0x600027F")]
		[Address(RVA = "0x1AA4F74", Offset = "0x1AA4F74", VA = "0x1AA4F74")]
		public static void MeshAssignUV3(Mesh m, Vector2[] uv3s)
		{
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0x1AA506C", Offset = "0x1AA506C", VA = "0x1AA506C")]
		public static void MeshAssignUV4(Mesh m, Vector2[] uv4s)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1AA5164", Offset = "0x1AA5164", VA = "0x1AA5164")]
		public static Vector4 GetLightmapTilingOffset(Renderer r)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1AA5254", Offset = "0x1AA5254", VA = "0x1AA5254")]
		public static Transform[] GetBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1AA5344", Offset = "0x1AA5344", VA = "0x1AA5344")]
		public static void OptimizeMesh(Mesh m)
		{
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1AA5434", Offset = "0x1AA5434", VA = "0x1AA5434")]
		public static int GetBlendShapeFrameCount(Mesh m, int shapeIndex)
		{
			return default(int);
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1AA552C", Offset = "0x1AA552C", VA = "0x1AA552C")]
		public static float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex)
		{
			return default(float);
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1AA5634", Offset = "0x1AA5634", VA = "0x1AA5634")]
		public static void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x1AA575C", Offset = "0x1AA575C", VA = "0x1AA575C")]
		public static void ClearBlendShapes(Mesh m)
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x1AA584C", Offset = "0x1AA584C", VA = "0x1AA584C")]
		public static void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts)
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x1AA597C", Offset = "0x1AA597C", VA = "0x1AA597C")]
		public static int MaxMeshVertexCount()
		{
			return default(int);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x1AA5A5C", Offset = "0x1AA5A5C", VA = "0x1AA5A5C")]
		public static void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles)
		{
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x1AA5B6C", Offset = "0x1AA5B6C", VA = "0x1AA5B6C")]
		public MBVersion()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000060")]
	public class MB3_AgglomerativeClustering
	{
		[Serializable]
		[Token(Token = "0x20000F0")]
		public class ClusterNode
		{
			[Token(Token = "0x4000472")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public item_s leaf;

			[Token(Token = "0x4000473")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ClusterNode cha;

			[Token(Token = "0x4000474")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ClusterNode chb;

			[Token(Token = "0x4000475")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int height;

			[Token(Token = "0x4000476")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float distToMergedCentroid;

			[Token(Token = "0x4000477")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 centroid;

			[Token(Token = "0x4000478")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public int[] leafs;

			[Token(Token = "0x4000479")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public int idx;

			[Token(Token = "0x400047A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public bool isUnclustered;

			[Token(Token = "0x6000842")]
			[Address(RVA = "0x19AC4A0", Offset = "0x19AC4A0", VA = "0x19AC4A0")]
			public ClusterNode(item_s ii, int index)
			{
			}

			[Token(Token = "0x6000843")]
			[Address(RVA = "0x19AC948", Offset = "0x19AC948", VA = "0x19AC948")]
			public ClusterNode(ClusterNode a, ClusterNode b, int index, int h, float dist, ClusterNode[] clusters)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F1")]
		public class item_s
		{
			[Token(Token = "0x400047B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject go;

			[Token(Token = "0x400047C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 coord;

			[Token(Token = "0x6000844")]
			[Address(RVA = "0x19ACD34", Offset = "0x19ACD34", VA = "0x19ACD34")]
			public item_s()
			{
			}
		}

		[Token(Token = "0x20000F2")]
		public class ClusterDistance
		{
			[Token(Token = "0x400047D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ClusterNode a;

			[Token(Token = "0x400047E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public ClusterNode b;

			[Token(Token = "0x6000845")]
			[Address(RVA = "0x19ACB8C", Offset = "0x19ACB8C", VA = "0x19ACB8C")]
			public ClusterDistance(ClusterNode aa, ClusterNode bb)
			{
			}
		}

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<item_s> items;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ClusterNode[] clusters;

		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool wasCanceled;

		[Token(Token = "0x400026D")]
		private const int MAX_PRIORITY_Q_SIZE = 2048;

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x19AB4F0", Offset = "0x19AB4F0", VA = "0x19AB4F0")]
		private float euclidean_distance(Vector3 a, Vector3 b)
		{
			return default(float);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x19AB598", Offset = "0x19AB598", VA = "0x19AB598")]
		public bool agglomerate(ProgressUpdateCancelableDelegate progFunc)
		{
			return default(bool);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x19AC55C", Offset = "0x19AC55C", VA = "0x19AC55C")]
		private float _RefillPriorityQWithSome(PriorityQueue<float, ClusterDistance> pq, List<ClusterNode> unclustered, ClusterNode[] clusters, ProgressUpdateCancelableDelegate progFunc)
		{
			return default(float);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x19ACBC4", Offset = "0x19ACBC4", VA = "0x19ACBC4")]
		public int TestRun(List<GameObject> gos)
		{
			return default(int);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x19ACD3C", Offset = "0x19ACD3C", VA = "0x19ACD3C")]
		public static void Main()
		{
		}

		[Token(Token = "0x6000291")]
		public static T NthSmallestElement<T>(List<T> array, int n) where T : IComparable<T>
		{
			return (T)null;
		}

		[Token(Token = "0x6000292")]
		private static List<T> QuickSelectSmallest<T>(List<T> input, int n) where T : IComparable<T>
		{
			return null;
		}

		[Token(Token = "0x6000293")]
		private static int QuickSelectPartition<T>(List<T> array, int startIndex, int endIndex, int pivotIndex) where T : IComparable<T>
		{
			return default(int);
		}

		[Token(Token = "0x6000294")]
		private static void Swap<T>(List<T> array, int index1, int index2)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x19ACE5C", Offset = "0x19ACE5C", VA = "0x19ACE5C")]
		public MB3_AgglomerativeClustering()
		{
		}
	}
	[Token(Token = "0x2000061")]
	public class MB3_CopyBoneWeights
	{
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x19ACECC", Offset = "0x19ACECC", VA = "0x19ACECC")]
		public static void CopyBoneWeightsFromSeamMeshToOtherMeshes(float radius, Mesh seamMesh, Mesh[] targetMeshes)
		{
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x19AD80C", Offset = "0x19AD80C", VA = "0x19AD80C")]
		public MB3_CopyBoneWeights()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000062")]
	public abstract class MB3_MeshCombiner
	{
		[Token(Token = "0x20000F3")]
		public delegate void GenerateUV2Delegate(Mesh m, float hardAngle, float packMargin);

		[Token(Token = "0x20000F4")]
		public class MBBlendShapeKey
		{
			[Token(Token = "0x400047F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int gameObjecID;

			[Token(Token = "0x4000480")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int blendShapeIndexInSrc;

			[Token(Token = "0x600084A")]
			[Address(RVA = "0x19B24C4", Offset = "0x19B24C4", VA = "0x19B24C4")]
			public MBBlendShapeKey(int srcSkinnedMeshRenderGameObjectID, int blendShapeIndexInSource)
			{
			}

			[Token(Token = "0x600084B")]
			[Address(RVA = "0x19B24FC", Offset = "0x19B24FC", VA = "0x19B24FC", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600084C")]
			[Address(RVA = "0x19B25A8", Offset = "0x19B25A8", VA = "0x19B25A8", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000F5")]
		public class MBBlendShapeValue
		{
			[Token(Token = "0x4000481")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject combinedMeshGameObject;

			[Token(Token = "0x4000482")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int blendShapeIndex;

			[Token(Token = "0x600084D")]
			[Address(RVA = "0x19B25C4", Offset = "0x19B25C4", VA = "0x19B25C4")]
			public MBBlendShapeValue()
			{
			}
		}

		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected MB2_LogLevel _LOG_LEVEL;

		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		[SerializeField]
		protected MB2_ValidationLevel _validationLevel;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected string _name;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected GameObject _resultSceneObject;

		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Renderer _targetRenderer;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected MB_RenderType _renderType;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected MB2_OutputOptions _outputOption;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected MB2_LightmapOptions _lightmapOption;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[SerializeField]
		protected bool _doNorm;

		[Token(Token = "0x4000278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		[SerializeField]
		protected bool _doTan;

		[Token(Token = "0x4000279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		[SerializeField]
		protected bool _doCol;

		[Token(Token = "0x400027A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
		[SerializeField]
		protected bool _doUV;

		[Token(Token = "0x400027B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected bool _doUV3;

		[Token(Token = "0x400027C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[SerializeField]
		protected bool _doUV4;

		[Token(Token = "0x400027D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
		[SerializeField]
		protected bool _doBlendShapes;

		[Token(Token = "0x400027E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
		[SerializeField]
		protected bool _recenterVertsToBoundsCenter;

		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public bool _optimizeAfterBake;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float uv2UnwrappingParamsHardAngle;

		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		public float uv2UnwrappingParamsPackMargin;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected bool _usingTemporaryTextureBakeResult;

		[Token(Token = "0x17000026")]
		public static bool EVAL_VERSION
		{
			[Token(Token = "0x6000298")]
			[Address(RVA = "0x19B175C", Offset = "0x19B175C", VA = "0x19B175C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000027")]
		public virtual MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x19B1764", Offset = "0x19B1764", VA = "0x19B1764", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x600029A")]
			[Address(RVA = "0x19B176C", Offset = "0x19B176C", VA = "0x19B176C", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x17000028")]
		public virtual MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600029B")]
			[Address(RVA = "0x19B1774", Offset = "0x19B1774", VA = "0x19B1774", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x19B177C", Offset = "0x19B177C", VA = "0x19B177C", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000029")]
		public string name
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x19B1784", Offset = "0x19B1784", VA = "0x19B1784")]
			get
			{
				return null;
			}
			[Token(Token = "0x600029E")]
			[Address(RVA = "0x19B178C", Offset = "0x19B178C", VA = "0x19B178C")]
			set
			{
			}
		}

		[Token(Token = "0x1700002A")]
		public virtual MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x600029F")]
			[Address(RVA = "0x19B1794", Offset = "0x19B1794", VA = "0x19B1794", Slot = "8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x19B179C", Offset = "0x19B179C", VA = "0x19B179C", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public virtual GameObject resultSceneObject
		{
			[Token(Token = "0x60002A1")]
			[Address(RVA = "0x19B17A4", Offset = "0x19B17A4", VA = "0x19B17A4", Slot = "10")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x19B17AC", Offset = "0x19B17AC", VA = "0x19B17AC", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x1700002C")]
		public virtual Renderer targetRenderer
		{
			[Token(Token = "0x60002A3")]
			[Address(RVA = "0x19B17B4", Offset = "0x19B17B4", VA = "0x19B17B4", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002A4")]
			[Address(RVA = "0x19B17BC", Offset = "0x19B17BC", VA = "0x19B17BC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x1700002D")]
		public virtual MB_RenderType renderType
		{
			[Token(Token = "0x60002A5")]
			[Address(RVA = "0x19B18A8", Offset = "0x19B18A8", VA = "0x19B18A8", Slot = "14")]
			get
			{
				return default(MB_RenderType);
			}
			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x19B18B0", Offset = "0x19B18B0", VA = "0x19B18B0", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700002E")]
		public virtual MB2_OutputOptions outputOption
		{
			[Token(Token = "0x60002A7")]
			[Address(RVA = "0x19B18B8", Offset = "0x19B18B8", VA = "0x19B18B8", Slot = "16")]
			get
			{
				return default(MB2_OutputOptions);
			}
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x19B18C0", Offset = "0x19B18C0", VA = "0x19B18C0", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1700002F")]
		public virtual MB2_LightmapOptions lightmapOption
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x19B18C8", Offset = "0x19B18C8", VA = "0x19B18C8", Slot = "18")]
			get
			{
				return default(MB2_LightmapOptions);
			}
			[Token(Token = "0x60002AA")]
			[Address(RVA = "0x19B18D0", Offset = "0x19B18D0", VA = "0x19B18D0", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x17000030")]
		public virtual bool doNorm
		{
			[Token(Token = "0x60002AB")]
			[Address(RVA = "0x19B18D8", Offset = "0x19B18D8", VA = "0x19B18D8", Slot = "20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AC")]
			[Address(RVA = "0x19B18E0", Offset = "0x19B18E0", VA = "0x19B18E0", Slot = "21")]
			set
			{
			}
		}

		[Token(Token = "0x17000031")]
		public virtual bool doTan
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x19B18EC", Offset = "0x19B18EC", VA = "0x19B18EC", Slot = "22")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x19B18F4", Offset = "0x19B18F4", VA = "0x19B18F4", Slot = "23")]
			set
			{
			}
		}

		[Token(Token = "0x17000032")]
		public virtual bool doCol
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x19B1900", Offset = "0x19B1900", VA = "0x19B1900", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B0")]
			[Address(RVA = "0x19B1908", Offset = "0x19B1908", VA = "0x19B1908", Slot = "25")]
			set
			{
			}
		}

		[Token(Token = "0x17000033")]
		public virtual bool doUV
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x19B1914", Offset = "0x19B1914", VA = "0x19B1914", Slot = "26")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x19B191C", Offset = "0x19B191C", VA = "0x19B191C", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public virtual bool doUV1
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x19B1928", Offset = "0x19B1928", VA = "0x19B1928", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x19B1930", Offset = "0x19B1930", VA = "0x19B1930", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public virtual bool doUV3
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x19B1958", Offset = "0x19B1958", VA = "0x19B1958", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B7")]
			[Address(RVA = "0x19B1960", Offset = "0x19B1960", VA = "0x19B1960", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000036")]
		public virtual bool doUV4
		{
			[Token(Token = "0x60002B8")]
			[Address(RVA = "0x19B196C", Offset = "0x19B196C", VA = "0x19B196C", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002B9")]
			[Address(RVA = "0x19B1974", Offset = "0x19B1974", VA = "0x19B1974", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000037")]
		public virtual bool doBlendShapes
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x19B1980", Offset = "0x19B1980", VA = "0x19B1980", Slot = "35")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x19B1988", Offset = "0x19B1988", VA = "0x19B1988", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000038")]
		public virtual bool recenterVertsToBoundsCenter
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x19B1994", Offset = "0x19B1994", VA = "0x19B1994", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BD")]
			[Address(RVA = "0x19B199C", Offset = "0x19B199C", VA = "0x19B199C", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000039")]
		public bool optimizeAfterBake
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x19B19A8", Offset = "0x19B19A8", VA = "0x19B19A8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002BF")]
			[Address(RVA = "0x19B19B0", Offset = "0x19B19B0", VA = "0x19B19B0")]
			set
			{
			}
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x19B1934", Offset = "0x19B1934", VA = "0x19B1934", Slot = "30")]
		public virtual bool doUV2()
		{
			return default(bool);
		}

		[Token(Token = "0x60002C0")]
		public abstract int GetLightmapIndex();

		[Token(Token = "0x60002C1")]
		public abstract void ClearBuffers();

		[Token(Token = "0x60002C2")]
		public abstract void ClearMesh();

		[Token(Token = "0x60002C3")]
		public abstract void DestroyMesh();

		[Token(Token = "0x60002C4")]
		public abstract void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods);

		[Token(Token = "0x60002C5")]
		public abstract List<GameObject> GetObjectsInCombined();

		[Token(Token = "0x60002C6")]
		public abstract int GetNumObjectsInCombined();

		[Token(Token = "0x60002C7")]
		public abstract int GetNumVerticesFor(GameObject go);

		[Token(Token = "0x60002C8")]
		public abstract int GetNumVerticesFor(int instanceID);

		[Token(Token = "0x60002C9")]
		public abstract Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap();

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x19B19BC", Offset = "0x19B19BC", VA = "0x19B19BC", Slot = "49")]
		public virtual void Apply()
		{
		}

		[Token(Token = "0x60002CB")]
		public abstract void Apply(GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60002CC")]
		public abstract void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapeFlag = false, [Optional] GenerateUV2Delegate uv2GenerationMethod);

		[Token(Token = "0x60002CD")]
		public abstract void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false);

		[Token(Token = "0x60002CE")]
		public abstract bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true);

		[Token(Token = "0x60002CF")]
		public abstract bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource);

		[Token(Token = "0x60002D0")]
		public abstract bool CombinedMeshContains(GameObject go);

		[Token(Token = "0x60002D1")]
		public abstract void UpdateSkinnedMeshApproximateBounds();

		[Token(Token = "0x60002D2")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBones();

		[Token(Token = "0x60002D3")]
		public abstract void CheckIntegrity();

		[Token(Token = "0x60002D4")]
		public abstract void UpdateSkinnedMeshApproximateBoundsFromBounds();

		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x19B19D0", Offset = "0x19B19D0", VA = "0x19B19D0")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBonesStatic(Transform[] bs, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x19B1D08", Offset = "0x19B1D08", VA = "0x19B1D08")]
		public static void UpdateSkinnedMeshApproximateBoundsFromBoundsStatic(List<GameObject> objectsInCombined, SkinnedMeshRenderer smr)
		{
		}

		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x19B1ED0", Offset = "0x19B1ED0", VA = "0x19B1ED0", Slot = "60")]
		protected virtual bool _CreateTemporaryTextrueBakeResult(GameObject[] gos, List<Material> matsOnTargetRenderer)
		{
			return default(bool);
		}

		[Token(Token = "0x60002D8")]
		public abstract List<Material> GetMaterialsOnTargetRenderer();

		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x19B1F98", Offset = "0x19B1F98", VA = "0x19B1F98")]
		protected MB3_MeshCombiner()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000063")]
	public class MB3_MeshCombinerSingle : MB3_MeshCombiner
	{
		[Serializable]
		[Token(Token = "0x20000F6")]
		public class SerializableIntArray
		{
			[Token(Token = "0x4000483")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int[] data;

			[Token(Token = "0x600084E")]
			[Address(RVA = "0x17808D4", Offset = "0x17808D4", VA = "0x17808D4")]
			public SerializableIntArray()
			{
			}

			[Token(Token = "0x600084F")]
			[Address(RVA = "0x17808DC", Offset = "0x17808DC", VA = "0x17808DC")]
			public SerializableIntArray(int len)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F7")]
		public class MB_DynamicGameObject : IComparable<MB_DynamicGameObject>
		{
			[Token(Token = "0x4000484")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int instanceID;

			[Token(Token = "0x4000485")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000486")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int vertIdx;

			[Token(Token = "0x4000487")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int blendShapeIdx;

			[Token(Token = "0x4000488")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int numVerts;

			[Token(Token = "0x4000489")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int numBlendShapes;

			[Token(Token = "0x400048A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int[] indexesOfBonesUsed;

			[Token(Token = "0x400048B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int lightmapIndex;

			[Token(Token = "0x400048C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public Vector4 lightmapTilingOffset;

			[Token(Token = "0x400048D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
			public Vector3 meshSize;

			[Token(Token = "0x400048E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool show;

			[Token(Token = "0x400048F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
			public bool invertTriangles;

			[Token(Token = "0x4000490")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public int[] submeshTriIdxs;

			[Token(Token = "0x4000491")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int[] submeshNumTris;

			[Token(Token = "0x4000492")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public int[] targetSubmeshIdxs;

			[Token(Token = "0x4000493")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Rect[] uvRects;

			[Token(Token = "0x4000494")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Rect[] encapsulatingRect;

			[Token(Token = "0x4000495")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Rect[] sourceMaterialTiling;

			[Token(Token = "0x4000496")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public Rect[] obUVRects;

			[Token(Token = "0x4000497")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			public bool _beingDeleted;

			[Token(Token = "0x4000498")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			public int _triangleIdxAdjustment;

			[NonSerialized]
			[Token(Token = "0x4000499")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			public SerializableIntArray[] _tmpSubmeshTris;

			[NonSerialized]
			[Token(Token = "0x400049A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
			public Transform[] _tmpCachedBones;

			[NonSerialized]
			[Token(Token = "0x400049B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
			public Matrix4x4[] _tmpCachedBindposes;

			[NonSerialized]
			[Token(Token = "0x400049C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
			public BoneWeight[] _tmpCachedBoneWeights;

			[NonSerialized]
			[Token(Token = "0x400049D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
			public int[] _tmpIndexesOfSourceBonesUsed;

			[Token(Token = "0x6000850")]
			[Address(RVA = "0x177E10C", Offset = "0x177E10C", VA = "0x177E10C", Slot = "4")]
			public int CompareTo(MB_DynamicGameObject b)
			{
				return default(int);
			}

			[Token(Token = "0x6000851")]
			[Address(RVA = "0x177E12C", Offset = "0x177E12C", VA = "0x177E12C")]
			public MB_DynamicGameObject()
			{
			}
		}

		[Token(Token = "0x20000F8")]
		public class MeshChannels
		{
			[Token(Token = "0x400049E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3[] vertices;

			[Token(Token = "0x400049F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] normals;

			[Token(Token = "0x40004A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector4[] tangents;

			[Token(Token = "0x40004A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector2[] uv0raw;

			[Token(Token = "0x40004A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2[] uv0modified;

			[Token(Token = "0x40004A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Vector2[] uv2;

			[Token(Token = "0x40004A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Vector2[] uv3;

			[Token(Token = "0x40004A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Vector2[] uv4;

			[Token(Token = "0x40004A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public UnityEngine.Color[] colors;

			[Token(Token = "0x40004A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public BoneWeight[] boneWeights;

			[Token(Token = "0x40004A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Matrix4x4[] bindPoses;

			[Token(Token = "0x40004A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public int[] triangles;

			[Token(Token = "0x40004AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public MBBlendShape[] blendShapes;

			[Token(Token = "0x6000852")]
			[Address(RVA = "0x177E200", Offset = "0x177E200", VA = "0x177E200")]
			public MeshChannels()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000F9")]
		public class MBBlendShapeFrame
		{
			[Token(Token = "0x40004AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float frameWeight;

			[Token(Token = "0x40004AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3[] vertices;

			[Token(Token = "0x40004AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3[] normals;

			[Token(Token = "0x40004AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Vector3[] tangents;

			[Token(Token = "0x6000853")]
			[Address(RVA = "0x177E104", Offset = "0x177E104", VA = "0x177E104")]
			public MBBlendShapeFrame()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x20000FA")]
		public class MBBlendShape
		{
			[Token(Token = "0x40004AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int gameObjectID;

			[Token(Token = "0x40004B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x40004B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int indexInSource;

			[Token(Token = "0x40004B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MBBlendShapeFrame[] frames;

			[Token(Token = "0x6000854")]
			[Address(RVA = "0x177E0FC", Offset = "0x177E0FC", VA = "0x177E0FC")]
			public MBBlendShape()
			{
			}
		}

		[Token(Token = "0x20000FB")]
		public class MeshChannelsCache
		{
			[Token(Token = "0x40004B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB3_MeshCombinerSingle mc;

			[Token(Token = "0x40004B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			protected Dictionary<int, MeshChannels> meshID2MeshChannels;

			[Token(Token = "0x40004B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Vector2 _HALF_UV;

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x177E208", Offset = "0x177E208", VA = "0x177E208")]
			public MeshChannelsCache(MB3_MeshCombinerSingle mcs)
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x177E2AC", Offset = "0x177E2AC", VA = "0x177E2AC")]
			internal Vector3[] GetVertices(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000857")]
			[Address(RVA = "0x177E3B4", Offset = "0x177E3B4", VA = "0x177E3B4")]
			internal Vector3[] GetNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000858")]
			[Address(RVA = "0x177E70C", Offset = "0x177E70C", VA = "0x177E70C")]
			internal Vector4[] GetTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000859")]
			[Address(RVA = "0x177E940", Offset = "0x177E940", VA = "0x177E940")]
			internal Vector2[] GetUv0Raw(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085A")]
			[Address(RVA = "0x177EC78", Offset = "0x177EC78", VA = "0x177EC78")]
			internal Vector2[] GetUv0Modified(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085B")]
			[Address(RVA = "0x177ED68", Offset = "0x177ED68", VA = "0x177ED68")]
			internal Vector2[] GetUv2(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085C")]
			[Address(RVA = "0x177F10C", Offset = "0x177F10C", VA = "0x177F10C")]
			internal Vector2[] GetUv3(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085D")]
			[Address(RVA = "0x177F230", Offset = "0x177F230", VA = "0x177F230")]
			internal Vector2[] GetUv4(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085E")]
			[Address(RVA = "0x177F354", Offset = "0x177F354", VA = "0x177F354")]
			internal UnityEngine.Color[] GetColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x600085F")]
			[Address(RVA = "0x177F6A0", Offset = "0x177F6A0", VA = "0x177F6A0")]
			internal Matrix4x4[] GetBindposes(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x6000860")]
			[Address(RVA = "0x177F9A4", Offset = "0x177F9A4", VA = "0x177F9A4")]
			internal BoneWeight[] GetBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x6000861")]
			[Address(RVA = "0x177FD04", Offset = "0x177FD04", VA = "0x177FD04")]
			internal int[] GetTriangles(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000862")]
			[Address(RVA = "0x177FE0C", Offset = "0x177FE0C", VA = "0x177FE0C")]
			internal MBBlendShape[] GetBlendShapes(Mesh m, int gameObjectID)
			{
				return null;
			}

			[Token(Token = "0x6000863")]
			[Address(RVA = "0x177F45C", Offset = "0x177F45C", VA = "0x177F45C")]
			private UnityEngine.Color[] _getMeshColors(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000864")]
			[Address(RVA = "0x177E4BC", Offset = "0x177E4BC", VA = "0x177E4BC")]
			private Vector3[] _getMeshNormals(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000865")]
			[Address(RVA = "0x177E814", Offset = "0x177E814", VA = "0x177E814")]
			private Vector4[] _getMeshTangents(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000866")]
			[Address(RVA = "0x177EA48", Offset = "0x177EA48", VA = "0x177EA48")]
			private Vector2[] _getMeshUVs(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000867")]
			[Address(RVA = "0x177EE70", Offset = "0x177EE70", VA = "0x177EE70")]
			private Vector2[] _getMeshUV2s(Mesh m)
			{
				return null;
			}

			[Token(Token = "0x6000868")]
			[Address(RVA = "0x177F7F0", Offset = "0x177F7F0", VA = "0x177F7F0")]
			public static Matrix4x4[] _getBindPoses(Renderer r)
			{
				return null;
			}

			[Token(Token = "0x6000869")]
			[Address(RVA = "0x177FAFC", Offset = "0x177FAFC", VA = "0x177FAFC")]
			public static BoneWeight[] _getBoneWeights(Renderer r, int numVertsInMeshBeingAdded)
			{
				return null;
			}

			[Token(Token = "0x600086A")]
			[Address(RVA = "0x17802C4", Offset = "0x17802C4", VA = "0x17802C4")]
			private void _generateTangents(int[] triangles, Vector3[] verts, Vector2[] uvs, Vector3[] normals, Vector4[] outTangents)
			{
			}
		}

		[Token(Token = "0x20000FC")]
		public struct BoneAndBindpose
		{
			[Token(Token = "0x40004B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Transform bone;

			[Token(Token = "0x40004B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Matrix4x4 bindPose;

			[Token(Token = "0x600086B")]
			[Address(RVA = "0x177DEE4", Offset = "0x177DEE4", VA = "0x177DEE4")]
			public BoneAndBindpose(Transform t, Matrix4x4 bp)
			{
			}

			[Token(Token = "0x600086C")]
			[Address(RVA = "0x177DF04", Offset = "0x177DF04", VA = "0x177DF04", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x600086D")]
			[Address(RVA = "0x177E078", Offset = "0x177E078", VA = "0x177E078", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Token(Token = "0x20000FD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7B4", Offset = "0xADD7B4")]
		private sealed class <>c__DisplayClass56_0
		{
			[Token(Token = "0x40004B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public GameObject[] _goToAdd;

			[Token(Token = "0x600086E")]
			[Address(RVA = "0x177DE6C", Offset = "0x177DE6C", VA = "0x177DE6C")]
			public <>c__DisplayClass56_0()
			{
			}
		}

		[Token(Token = "0x20000FE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7C4", Offset = "0xADD7C4")]
		private sealed class <>c__DisplayClass56_1
		{
			[Token(Token = "0x40004B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x40004BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass56_0 CS$<>8__locals1;

			[Token(Token = "0x600086F")]
			[Address(RVA = "0x177DE74", Offset = "0x177DE74", VA = "0x177DE74")]
			public <>c__DisplayClass56_1()
			{
			}

			[Token(Token = "0x6000870")]
			[Address(RVA = "0x177DE7C", Offset = "0x177DE7C", VA = "0x177DE7C")]
			internal bool <_addToCombined>b__0(int o)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		protected List<GameObject> objectsInCombinedMesh;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private int lightmapIndex;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Dictionary<int, MB_DynamicGameObject> _instance2combined_map;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Vector3[] verts;

		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector3[] normals;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector4[] tangents;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector2[] uvs;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector2[] uv2s;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Vector2[] uv3s;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Vector2[] uv4s;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UnityEngine.Color[] colors;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Matrix4x4[] bindPoses;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Transform[] bones;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		internal MBBlendShape[] blendShapes;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[SerializeField]
		internal MBBlendShape[] blendShapesInCombined;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private SerializableIntArray[] submeshTris;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Mesh _mesh;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private BoneWeight[] boneWeights;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private GameObject[] empty;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int[] emptyIDs;

		[Token(Token = "0x1700003A")]
		public override MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x60002DA")]
			[Address(RVA = "0x19B25CC", Offset = "0x19B25CC", VA = "0x19B25CC", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700003B")]
		public override MB_RenderType renderType
		{
			[Token(Token = "0x60002DB")]
			[Address(RVA = "0x19B26E8", Offset = "0x19B26E8", VA = "0x19B26E8", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x1700003C")]
		public override GameObject resultSceneObject
		{
			[Token(Token = "0x60002DC")]
			[Address(RVA = "0x19B27A0", Offset = "0x19B27A0", VA = "0x19B27A0", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x19B289C", Offset = "0x19B289C", VA = "0x19B289C")]
		private MB_DynamicGameObject instance2Combined_MapGet(int gameObjectID)
		{
			return null;
		}

		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x19B2904", Offset = "0x19B2904", VA = "0x19B2904")]
		private void instance2Combined_MapAdd(int gameObjectID, MB_DynamicGameObject dgo)
		{
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x19B2974", Offset = "0x19B2974", VA = "0x19B2974")]
		private void instance2Combined_MapRemove(int gameObjectID)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x19B29DC", Offset = "0x19B29DC", VA = "0x19B29DC")]
		private bool instance2Combined_MapTryGetValue(int gameObjectID, out MB_DynamicGameObject dgo)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x19B2A4C", Offset = "0x19B2A4C", VA = "0x19B2A4C")]
		private int instance2Combined_MapCount()
		{
			return default(int);
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x19B2AA4", Offset = "0x19B2AA4", VA = "0x19B2AA4")]
		private void instance2Combined_MapClear()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x19B2AFC", Offset = "0x19B2AFC", VA = "0x19B2AFC")]
		private bool instance2Combined_MapContainsKey(int gameObjectID)
		{
			return default(bool);
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x19B2B64", Offset = "0x19B2B64", VA = "0x19B2B64", Slot = "45")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x19B2BB4", Offset = "0x19B2BB4", VA = "0x19B2BB4", Slot = "44")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x19B2C3C", Offset = "0x19B2C3C", VA = "0x19B2C3C")]
		public Mesh GetMesh()
		{
			return null;
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x19B2CE0", Offset = "0x19B2CE0", VA = "0x19B2CE0")]
		public void SetMesh(Mesh m)
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x19B2CE8", Offset = "0x19B2CE8", VA = "0x19B2CE8")]
		public Transform[] GetBones()
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x19B2CF0", Offset = "0x19B2CF0", VA = "0x19B2CF0", Slot = "39")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x19B2D48", Offset = "0x19B2D48", VA = "0x19B2D48", Slot = "46")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x19B2D8C", Offset = "0x19B2D8C", VA = "0x19B2D8C", Slot = "47")]
		public override int GetNumVerticesFor(int instanceID)
		{
			return default(int);
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x19B2DCC", Offset = "0x19B2DCC", VA = "0x19B2DCC", Slot = "48")]
		public override Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap()
		{
			return null;
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x19B2F28", Offset = "0x19B2F28", VA = "0x19B2F28")]
		private void _initialize(int numResultMats)
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x19B35D8", Offset = "0x19B35D8", VA = "0x19B35D8")]
		private bool _collectMaterialTriangles(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map)
		{
			return default(bool);
		}

		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x19B3C60", Offset = "0x19B3C60", VA = "0x19B3C60")]
		private bool _collectOutOfBoundsUVRects2(Mesh m, MB_DynamicGameObject dgo, Material[] sharedMaterials, OrderedDictionary sourceMats2submeshIdx_map, Dictionary<int, MB_Utility.MeshAnalysisResult[]> meshAnalysisResults, MeshChannelsCache meshChannelCache)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x19B3F98", Offset = "0x19B3F98", VA = "0x19B3F98")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x19B40D4", Offset = "0x19B40D4", VA = "0x19B40D4")]
		private bool _validateMeshFlags()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x19B42D4", Offset = "0x19B42D4", VA = "0x19B42D4")]
		private bool _showHide(GameObject[] goToShow, GameObject[] goToHide)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x19B45AC", Offset = "0x19B45AC", VA = "0x19B45AC")]
		private bool _addToCombined(GameObject[] goToAdd, int[] goToDelete, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x19B9A10", Offset = "0x19B9A10", VA = "0x19B9A10")]
		private void _copyAndAdjustUVsFromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x19B9FCC", Offset = "0x19B9FCC", VA = "0x19B9FCC")]
		private void _copyAndAdjustUV2FromMesh(MB_DynamicGameObject dgo, Mesh mesh, int vertsIdx, MeshChannelsCache meshChannelsCache)
		{
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x19BABA8", Offset = "0x19BABA8", VA = "0x19BABA8", Slot = "56")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x19BABB8", Offset = "0x19BABB8", VA = "0x19BABB8", Slot = "57")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x19BAE7C", Offset = "0x19BAE7C", VA = "0x19BAE7C", Slot = "59")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x19BB140", Offset = "0x19BB140", VA = "0x19BB140")]
		private int _getNumBones(Renderer r)
		{
			return default(int);
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x19BB268", Offset = "0x19BB268", VA = "0x19BB268")]
		private Transform[] _getBones(Renderer r)
		{
			return null;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x19BB274", Offset = "0x19BB274", VA = "0x19BB274", Slot = "50")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x19BB37C", Offset = "0x19BB37C", VA = "0x19BB37C", Slot = "62")]
		public virtual void ApplyShowHide()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x19BBD14", Offset = "0x19BBD14", VA = "0x19BBD14", Slot = "51")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x19BBAEC", Offset = "0x19BBAEC", VA = "0x19BBAEC")]
		private int _numNonZeroLengthSubmeshTris(SerializableIntArray[] subTris)
		{
			return default(int);
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x19BBB60", Offset = "0x19BBB60", VA = "0x19BBB60")]
		private void _updateMaterialsOnTargetRenderer(SerializableIntArray[] subTris, int numNonZeroLengthSubmeshTris)
		{
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x19BB738", Offset = "0x19BB738", VA = "0x19BB738")]
		public SerializableIntArray[] GetSubmeshTrisWithShowHideApplied()
		{
			return null;
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x19BD520", Offset = "0x19BD520", VA = "0x19BD520", Slot = "52")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x19BD56C", Offset = "0x19BD56C", VA = "0x19BD56C")]
		private void _updateGameObjects(GameObject[] gos, bool recalcBounds, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo)
		{
		}

		[Token(Token = "0x6000303")]
		[Address(RVA = "0x19BD844", Offset = "0x19BD844", VA = "0x19BD844")]
		private void _updateGameObject(GameObject go, bool updateVertices, bool updateNormals, bool updateTangents, bool updateUV, bool updateUV2, bool updateUV3, bool updateUV4, bool updateColors, bool updateSkinningInfo, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0x19BE1FC", Offset = "0x19BE1FC", VA = "0x19BE1FC")]
		public bool ShowHideGameObjects(GameObject[] toShow, GameObject[] toHide)
		{
			return default(bool);
		}

		[Token(Token = "0x6000305")]
		[Address(RVA = "0x19BE2EC", Offset = "0x19BE2EC", VA = "0x19BE2EC", Slot = "53")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0x19BE4E4", Offset = "0x19BE4E4", VA = "0x19BE4E4", Slot = "54")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0x19BEB4C", Offset = "0x19BEB4C", VA = "0x19BEB4C", Slot = "55")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0x19BEBB4", Offset = "0x19BEBB4", VA = "0x19BEBB4", Slot = "40")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000309")]
		[Address(RVA = "0x19BEEC0", Offset = "0x19BEEC0", VA = "0x19BEEC0", Slot = "41")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0x19BEF7C", Offset = "0x19BEF7C", VA = "0x19BEF7C", Slot = "42")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x600030B")]
		[Address(RVA = "0x19BF114", Offset = "0x19BF114", VA = "0x19BF114", Slot = "43")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0x19B8A3C", Offset = "0x19B8A3C", VA = "0x19B8A3C")]
		public bool ValidateTargRendererAndMeshAndResultSceneObj()
		{
			return default(bool);
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0x19BF2FC", Offset = "0x19BF2FC", VA = "0x19BF2FC")]
		internal static Renderer BuildSceneHierarchPreBake(MB3_MeshCombinerSingle mom, GameObject root, Mesh m, bool createNewChild = false, [Optional] GameObject[] objsToBeAdded)
		{
			return null;
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0x19BFF00", Offset = "0x19BFF00", VA = "0x19BFF00")]
		public static void BuildPrefabHierarchy(MB3_MeshCombinerSingle mom, GameObject instantiatedPrefabRoot, Mesh m, bool createNewChild = false, [Optional] GameObject[] objsToBeAdded)
		{
		}

		[Token(Token = "0x600030F")]
		[Address(RVA = "0x19BFBA8", Offset = "0x19BFBA8", VA = "0x19BFBA8")]
		private static void _ConfigureSceneHierarch(MB3_MeshCombinerSingle mom, GameObject root, MeshRenderer mr, MeshFilter mf, SkinnedMeshRenderer smr, Mesh m, [Optional] GameObject[] objsToBeAdded)
		{
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0x19BEA4C", Offset = "0x19BEA4C", VA = "0x19BEA4C")]
		public void BuildSceneMeshObject([Optional] GameObject[] gos, bool createNewChild = false)
		{
		}

		[Token(Token = "0x6000311")]
		[Address(RVA = "0x19B93CC", Offset = "0x19B93CC", VA = "0x19B93CC")]
		private bool IsMirrored(Matrix4x4 tm)
		{
			return default(bool);
		}

		[Token(Token = "0x6000312")]
		[Address(RVA = "0x19C0500", Offset = "0x19C0500", VA = "0x19C0500", Slot = "58")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x6000313")]
		[Address(RVA = "0x19BD44C", Offset = "0x19BD44C", VA = "0x19BD44C")]
		private void _ZeroArray(Vector3[] arr, int idx, int length)
		{
		}

		[Token(Token = "0x6000314")]
		[Address(RVA = "0x19B8D98", Offset = "0x19B8D98", VA = "0x19B8D98")]
		private List<MB_DynamicGameObject>[] _buildBoneIdx2dgoMap()
		{
			return null;
		}

		[Token(Token = "0x6000315")]
		[Address(RVA = "0x19B8F44", Offset = "0x19B8F44", VA = "0x19B8F44")]
		private void _CollectBonesToAddForDGO(MB_DynamicGameObject dgo, Dictionary<Transform, int> bone2idx, HashSet<int> boneIdxsToDelete, HashSet<BoneAndBindpose> bonesToAdd, Renderer r, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x6000316")]
		[Address(RVA = "0x19B9570", Offset = "0x19B9570", VA = "0x19B9570")]
		private void _CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(HashSet<int> boneIdxsToDeleteHS, HashSet<BoneAndBindpose> bonesToAdd, Transform[] nbones, Matrix4x4[] nbindPoses, BoneWeight[] nboneWeights, int totalDeleteVerts)
		{
		}

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x19BA250", Offset = "0x19BA250", VA = "0x19BA250")]
		private void _AddBonesToNewBonesArrayAndAdjustBWIndexes(MB_DynamicGameObject dgo, Renderer r, int vertsIdx, Transform[] nbones, BoneWeight[] nboneWeights, MeshChannelsCache meshChannelCache)
		{
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x19BA764", Offset = "0x19BA764", VA = "0x19BA764")]
		private void _copyUV2unchangedToSeparateRects()
		{
		}

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x19C0A58", Offset = "0x19C0A58", VA = "0x19C0A58", Slot = "61")]
		public override List<Material> GetMaterialsOnTargetRenderer()
		{
			return null;
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x19C0B30", Offset = "0x19C0B30", VA = "0x19C0B30")]
		public MB3_MeshCombinerSingle()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000064")]
	public class MB3_MultiMeshCombiner : MB3_MeshCombiner
	{
		[Serializable]
		[Token(Token = "0x20000FF")]
		public class CombinedMesh
		{
			[Token(Token = "0x40004BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MB3_MeshCombinerSingle combinedMesh;

			[Token(Token = "0x40004BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int extraSpace;

			[Token(Token = "0x40004BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int numVertsInListToDelete;

			[Token(Token = "0x40004BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numVertsInListToAdd;

			[Token(Token = "0x40004BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<GameObject> gosToAdd;

			[Token(Token = "0x40004C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<int> gosToDelete;

			[Token(Token = "0x40004C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public List<GameObject> gosToUpdate;

			[Token(Token = "0x40004C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public bool isDirty;

			[Token(Token = "0x6000871")]
			[Address(RVA = "0x1783CA0", Offset = "0x1783CA0", VA = "0x1783CA0")]
			public CombinedMesh(int maxNumVertsInMesh, GameObject resultSceneObject, MB2_LogLevel ll)
			{
			}

			[Token(Token = "0x6000872")]
			[Address(RVA = "0x1784A30", Offset = "0x1784A30", VA = "0x1784A30")]
			public bool isEmpty()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameObject[] empty;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static int[] emptyIDs;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public Dictionary<int, CombinedMesh> obj2MeshCombinerMap;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<CombinedMesh> meshCombiners;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _maxVertsInMesh;

		[Token(Token = "0x1700003D")]
		public override MB2_LogLevel LOG_LEVEL
		{
			[Token(Token = "0x600031B")]
			[Address(RVA = "0x178094C", Offset = "0x178094C", VA = "0x178094C", Slot = "4")]
			get
			{
				return default(MB2_LogLevel);
			}
			[Token(Token = "0x600031C")]
			[Address(RVA = "0x1780954", Offset = "0x1780954", VA = "0x1780954", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700003E")]
		public override MB2_ValidationLevel validationLevel
		{
			[Token(Token = "0x600031E")]
			[Address(RVA = "0x1780AB4", Offset = "0x1780AB4", VA = "0x1780AB4", Slot = "6")]
			get
			{
				return default(MB2_ValidationLevel);
			}
			[Token(Token = "0x600031D")]
			[Address(RVA = "0x1780A04", Offset = "0x1780A04", VA = "0x1780A04", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700003F")]
		public int maxVertsInMesh
		{
			[Token(Token = "0x600031F")]
			[Address(RVA = "0x1780ABC", Offset = "0x1780ABC", VA = "0x1780ABC")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000320")]
			[Address(RVA = "0x1780AC4", Offset = "0x1780AC4", VA = "0x1780AC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x1780C18", Offset = "0x1780C18", VA = "0x1780C18", Slot = "45")]
		public override int GetNumObjectsInCombined()
		{
			return default(int);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x1780C70", Offset = "0x1780C70", VA = "0x1780C70", Slot = "46")]
		public override int GetNumVerticesFor(GameObject go)
		{
			return default(int);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x1780D28", Offset = "0x1780D28", VA = "0x1780D28", Slot = "47")]
		public override int GetNumVerticesFor(int gameObjectID)
		{
			return default(int);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x1780DCC", Offset = "0x1780DCC", VA = "0x1780DCC", Slot = "44")]
		public override List<GameObject> GetObjectsInCombined()
		{
			return null;
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x1780EC0", Offset = "0x1780EC0", VA = "0x1780EC0", Slot = "39")]
		public override int GetLightmapIndex()
		{
			return default(int);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x1780F48", Offset = "0x1780F48", VA = "0x1780F48", Slot = "55")]
		public override bool CombinedMeshContains(GameObject go)
		{
			return default(bool);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x1780FC4", Offset = "0x1780FC4", VA = "0x1780FC4")]
		private bool _validateTextureBakeResults()
		{
			return default(bool);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1781100", Offset = "0x1781100", VA = "0x1781100", Slot = "50")]
		public override void Apply(GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1781214", Offset = "0x1781214", VA = "0x1781214", Slot = "51")]
		public override void Apply(bool triangles, bool vertices, bool normals, bool tangents, bool uvs, bool uv2, bool uv3, bool uv4, bool colors, bool bones = false, bool blendShapesFlag = false, [Optional] GenerateUV2Delegate uv2GenerationMethod)
		{
		}

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x17813D8", Offset = "0x17813D8", VA = "0x17813D8", Slot = "56")]
		public override void UpdateSkinnedMeshApproximateBounds()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x1781480", Offset = "0x1781480", VA = "0x1781480", Slot = "57")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBones()
		{
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0x1781528", Offset = "0x1781528", VA = "0x1781528", Slot = "59")]
		public override void UpdateSkinnedMeshApproximateBoundsFromBounds()
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x17815D0", Offset = "0x17815D0", VA = "0x17815D0", Slot = "52")]
		public override void UpdateGameObjects(GameObject[] gos, bool recalcBounds = true, bool updateVertices = true, bool updateNormals = true, bool updateTangents = true, bool updateUV = false, bool updateUV2 = false, bool updateUV3 = false, bool updateUV4 = false, bool updateColors = false, bool updateSkinningInfo = false)
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x17819D8", Offset = "0x17819D8", VA = "0x17819D8", Slot = "53")]
		public override bool AddDeleteGameObjects(GameObject[] gos, GameObject[] deleteGOs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x1781BD0", Offset = "0x1781BD0", VA = "0x1781BD0", Slot = "54")]
		public override bool AddDeleteGameObjectsByID(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource = true)
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x1782088", Offset = "0x1782088", VA = "0x1782088")]
		private bool _validate(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
			return default(bool);
		}

		[Token(Token = "0x6000331")]
		[Address(RVA = "0x1782680", Offset = "0x1782680", VA = "0x1782680")]
		private void _distributeAmongBakers(GameObject[] gos, int[] deleteGOinstanceIDs)
		{
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0x1783070", Offset = "0x1783070", VA = "0x1783070")]
		private bool _bakeStep1(GameObject[] gos, int[] deleteGOinstanceIDs, bool disableRendererInSource)
		{
			return default(bool);
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x178401C", Offset = "0x178401C", VA = "0x178401C", Slot = "48")]
		public override Dictionary<MBBlendShapeKey, MBBlendShapeValue> BuildSourceBlendShapeToCombinedIndexMap()
		{
			return null;
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x1784244", Offset = "0x1784244", VA = "0x1784244", Slot = "40")]
		public override void ClearBuffers()
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x1784304", Offset = "0x1784304", VA = "0x1784304", Slot = "41")]
		public override void ClearMesh()
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x1784314", Offset = "0x1784314", VA = "0x1784314", Slot = "42")]
		public override void DestroyMesh()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x17844E8", Offset = "0x17844E8", VA = "0x17844E8", Slot = "43")]
		public override void DestroyMeshEditor(MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000338")]
		[Address(RVA = "0x1783DD4", Offset = "0x1783DD4", VA = "0x1783DD4")]
		private void _setMBValues(MB3_MeshCombinerSingle targ)
		{
		}

		[Token(Token = "0x6000339")]
		[Address(RVA = "0x1784718", Offset = "0x1784718", VA = "0x1784718", Slot = "61")]
		public override List<Material> GetMaterialsOnTargetRenderer()
		{
			return null;
		}

		[Token(Token = "0x600033A")]
		[Address(RVA = "0x1784834", Offset = "0x1784834", VA = "0x1784834", Slot = "58")]
		public override void CheckIntegrity()
		{
		}

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x178490C", Offset = "0x178490C", VA = "0x178490C")]
		public MB3_MultiMeshCombiner()
		{
		}
	}
	[Token(Token = "0x2000065")]
	public class PriorityQueue<TPriority, TValue> : ICollection<KeyValuePair<TPriority, TValue>>, IEnumerable<KeyValuePair<TPriority, TValue>>, IEnumerable
	{
		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<KeyValuePair<TPriority, TValue>> _baseHeap;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IComparer<TPriority> _comparer;

		[Token(Token = "0x17000040")]
		public bool IsEmpty
		{
			[Token(Token = "0x600034A")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000041")]
		public int Count
		{
			[Token(Token = "0x6000354")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000042")]
		public bool IsReadOnly
		{
			[Token(Token = "0x6000356")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600033D")]
		public PriorityQueue()
		{
		}

		[Token(Token = "0x600033E")]
		public PriorityQueue(int capacity)
		{
		}

		[Token(Token = "0x600033F")]
		public PriorityQueue(int capacity, IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000340")]
		public PriorityQueue(IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000341")]
		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data)
		{
		}

		[Token(Token = "0x6000342")]
		public PriorityQueue(IEnumerable<KeyValuePair<TPriority, TValue>> data, IComparer<TPriority> comparer)
		{
		}

		[Token(Token = "0x6000343")]
		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2)
		{
			return null;
		}

		[Token(Token = "0x6000344")]
		public static PriorityQueue<TPriority, TValue> MergeQueues(PriorityQueue<TPriority, TValue> pq1, PriorityQueue<TPriority, TValue> pq2, IComparer<TPriority> comparer)
		{
			return null;
		}

		[Token(Token = "0x6000345")]
		public void Enqueue(TPriority priority, TValue value)
		{
		}

		[Token(Token = "0x6000346")]
		public KeyValuePair<TPriority, TValue> Dequeue()
		{
			return default(KeyValuePair<TPriority, TValue>);
		}

		[Token(Token = "0x6000347")]
		public TValue DequeueValue()
		{
			return (TValue)null;
		}

		[Token(Token = "0x6000348")]
		public KeyValuePair<TPriority, TValue> Peek()
		{
			return default(KeyValuePair<TPriority, TValue>);
		}

		[Token(Token = "0x6000349")]
		public TValue PeekValue()
		{
			return (TValue)null;
		}

		[Token(Token = "0x600034B")]
		private void ExchangeElements(int pos1, int pos2)
		{
		}

		[Token(Token = "0x600034C")]
		private void Insert(TPriority priority, TValue value)
		{
		}

		[Token(Token = "0x600034D")]
		private int HeapifyFromEndToBeginning(int pos)
		{
			return default(int);
		}

		[Token(Token = "0x600034E")]
		private void DeleteRoot()
		{
		}

		[Token(Token = "0x600034F")]
		private void HeapifyFromBeginningToEnd(int pos)
		{
		}

		[Token(Token = "0x6000350")]
		public void Add(KeyValuePair<TPriority, TValue> item)
		{
		}

		[Token(Token = "0x6000351")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000352")]
		public bool Contains(KeyValuePair<TPriority, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000353")]
		public bool TryFindValue(TPriority item, out TValue foundVersion)
		{
			return default(bool);
		}

		[Token(Token = "0x6000355")]
		public void CopyTo(KeyValuePair<TPriority, TValue>[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000357")]
		public bool Remove(KeyValuePair<TPriority, TValue> item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000358")]
		public IEnumerator<KeyValuePair<TPriority, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000359")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x2000066")]
	public struct DVector2
	{
		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static double epsilon;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x141ACF0", Offset = "0x141ACF0", VA = "0x141ACF0")]
		public static DVector2 Subtract(DVector2 a, DVector2 b)
		{
			return default(DVector2);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x141A77C", Offset = "0x141A77C", VA = "0x141A77C")]
		public DVector2(double xx, double yy)
		{
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x141ACFC", Offset = "0x141ACFC", VA = "0x141ACFC")]
		public DVector2(DVector2 r)
		{
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x141AD04", Offset = "0x141AD04", VA = "0x141AD04")]
		public Vector2 GetVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x141AD3C", Offset = "0x141AD3C", VA = "0x141AD3C")]
		public bool IsContainedIn(DRect r)
		{
			return default(bool);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x141AD7C", Offset = "0x141AD7C", VA = "0x141AD7C")]
		public bool IsContainedInWithMargin(DRect r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x141AEC4", Offset = "0x141AEC4", VA = "0x141AEC4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x141AF68", Offset = "0x141AF68", VA = "0x141AF68")]
		public string ToString(string formatS)
		{
			return null;
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x141AFF4", Offset = "0x141AFF4", VA = "0x141AFF4")]
		public static double Distance(DVector2 a, DVector2 b)
		{
			return default(double);
		}
	}
	[Token(Token = "0x2000067")]
	public struct DRect
	{
		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public double x;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public double y;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public double width;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public double height;

		[Token(Token = "0x17000043")]
		public DVector2 minD
		{
			[Token(Token = "0x600036A")]
			[Address(RVA = "0x141A774", Offset = "0x141A774", VA = "0x141A774")]
			get
			{
				return default(DVector2);
			}
		}

		[Token(Token = "0x17000044")]
		public DVector2 maxD
		{
			[Token(Token = "0x600036B")]
			[Address(RVA = "0x141A784", Offset = "0x141A784", VA = "0x141A784")]
			get
			{
				return default(DVector2);
			}
		}

		[Token(Token = "0x17000045")]
		public Vector2 min
		{
			[Token(Token = "0x600036C")]
			[Address(RVA = "0x141A794", Offset = "0x141A794", VA = "0x141A794")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000046")]
		public Vector2 max
		{
			[Token(Token = "0x600036D")]
			[Address(RVA = "0x141A7CC", Offset = "0x141A7CC", VA = "0x141A7CC")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000047")]
		public Vector2 size
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x141A810", Offset = "0x141A810", VA = "0x141A810")]
			get
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x17000048")]
		public DVector2 center
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x141A848", Offset = "0x141A848", VA = "0x141A848")]
			get
			{
				return default(DVector2);
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x141A660", Offset = "0x141A660", VA = "0x141A660")]
		public DRect(Rect r)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x141A6DC", Offset = "0x141A6DC", VA = "0x141A6DC")]
		public DRect(Vector2 o, Vector2 s)
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x141A6F8", Offset = "0x141A6F8", VA = "0x141A6F8")]
		public DRect(DRect r)
		{
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x141A704", Offset = "0x141A704", VA = "0x141A704")]
		public DRect(float xx, float yy, float w, float h)
		{
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x141A720", Offset = "0x141A720", VA = "0x141A720")]
		public DRect(double xx, double yy, double w, double h)
		{
		}

		[Token(Token = "0x6000369")]
		[Address(RVA = "0x141A72C", Offset = "0x141A72C", VA = "0x141A72C")]
		public Rect GetRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000370")]
		[Address(RVA = "0x141A860", Offset = "0x141A860", VA = "0x141A860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000371")]
		[Address(RVA = "0x141A92C", Offset = "0x141A92C", VA = "0x141A92C")]
		public static bool operator ==(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000372")]
		[Address(RVA = "0x141A9C8", Offset = "0x141A9C8", VA = "0x141A9C8")]
		public static bool operator !=(DRect a, DRect b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000373")]
		[Address(RVA = "0x141AA68", Offset = "0x141AA68", VA = "0x141AA68", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000374")]
		[Address(RVA = "0x141ABF0", Offset = "0x141ABF0", VA = "0x141ABF0")]
		public void Expand(float amt)
		{
		}

		[Token(Token = "0x6000375")]
		[Address(RVA = "0x141AC18", Offset = "0x141AC18", VA = "0x141AC18")]
		public bool Encloses(DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000376")]
		[Address(RVA = "0x141AC88", Offset = "0x141AC88", VA = "0x141AC88", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000068")]
	public class MB3_UVTransformUtility
	{
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1AA36BC", Offset = "0x1AA36BC", VA = "0x1AA36BC")]
		public static void Test()
		{
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1AA3A94", Offset = "0x1AA3A94", VA = "0x1AA3A94")]
		public static float TransformX(DRect r, double x)
		{
			return default(float);
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1AA39E4", Offset = "0x1AA39E4", VA = "0x1AA39E4")]
		public static DRect CombineTransforms(ref DRect r1, ref DRect r2)
		{
			return default(DRect);
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0x1AA3AA4", Offset = "0x1AA3AA4", VA = "0x1AA3AA4")]
		public static Rect CombineTransforms(ref Rect r1, ref Rect r2)
		{
			return default(Rect);
		}

		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1AA39BC", Offset = "0x1AA39BC", VA = "0x1AA39BC")]
		public static DRect InverseTransform(ref DRect t)
		{
			return default(DRect);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1AA3BBC", Offset = "0x1AA3BBC", VA = "0x1AA3BBC")]
		public static DRect GetShiftTransformToFitBinA(ref DRect A, ref DRect B)
		{
			return default(DRect);
		}

		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1AA3CF0", Offset = "0x1AA3CF0", VA = "0x1AA3CF0")]
		public static DRect GetEncapsulatingRectShifted(ref DRect uvRect1, ref DRect willBeIn)
		{
			return default(DRect);
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0x1AA3EA8", Offset = "0x1AA3EA8", VA = "0x1AA3EA8")]
		public static DRect GetEncapsulatingRect(ref DRect uvRect1, ref DRect uvRect2)
		{
			return default(DRect);
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1AA3F44", Offset = "0x1AA3F44", VA = "0x1AA3F44")]
		public static bool RectContainsShifted(ref DRect bucket, ref DRect tryFit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1AA4090", Offset = "0x1AA4090", VA = "0x1AA4090")]
		public static bool RectContainsShifted(ref Rect bucket, ref Rect tryFit)
		{
			return default(bool);
		}

		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1AA438C", Offset = "0x1AA438C", VA = "0x1AA438C")]
		public static bool LineSegmentContainsShifted(float bucketOffset, float bucketLength, float tryFitOffset, float tryFitLength)
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1AA4484", Offset = "0x1AA4484", VA = "0x1AA4484")]
		public static bool RectContains(ref DRect bigRect, ref DRect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1AA41FC", Offset = "0x1AA41FC", VA = "0x1AA41FC")]
		public static bool RectContains(ref Rect bigRect, ref Rect smallToTestIfFits)
		{
			return default(bool);
		}

		[Token(Token = "0x6000384")]
		[Address(RVA = "0x1AA3A40", Offset = "0x1AA3A40", VA = "0x1AA3A40")]
		public static Vector2 TransformPoint(ref DRect r, Vector2 p)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1AA4524", Offset = "0x1AA4524", VA = "0x1AA4524")]
		public static DVector2 TransformPoint(ref DRect r, DVector2 p)
		{
			return default(DVector2);
		}

		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1AA4568", Offset = "0x1AA4568", VA = "0x1AA4568")]
		public MB3_UVTransformUtility()
		{
		}
	}
	[Token(Token = "0x2000069")]
	public static class MB_TGAWriter
	{
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1AA6750", Offset = "0x1AA6750", VA = "0x1AA6750")]
		public static void Write(UnityEngine.Color[] pixels, int width, int height, string path)
		{
		}

		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1AA67B8", Offset = "0x1AA67B8", VA = "0x1AA67B8")]
		public static void Write(UnityEngine.Color[] pixels, int width, int height, Stream output)
		{
		}
	}
	[Token(Token = "0x200006A")]
	public class MB_Utility
	{
		[Token(Token = "0x2000100")]
		public struct MeshAnalysisResult
		{
			[Token(Token = "0x40004C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Rect uvRect;

			[Token(Token = "0x40004C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool hasOutOfBoundsUVs;

			[Token(Token = "0x40004C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool hasOverlappingSubmeshVerts;

			[Token(Token = "0x40004C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool hasOverlappingSubmeshTris;

			[Token(Token = "0x40004C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public bool hasUVs;

			[Token(Token = "0x40004C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public float submeshArea;
		}

		[Token(Token = "0x2000101")]
		private class MB_Triangle
		{
			[Token(Token = "0x40004C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int submeshIdx;

			[Token(Token = "0x40004CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int[] vs;

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x1AA8EEC", Offset = "0x1AA8EEC", VA = "0x1AA8EEC")]
			public bool isSame(object obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x1AA9018", Offset = "0x1AA9018", VA = "0x1AA9018")]
			public bool sharesVerts(MB_Triangle obj)
			{
				return default(bool);
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x1AA8DE0", Offset = "0x1AA8DE0", VA = "0x1AA8DE0")]
			public void Initialize(int[] ts, int idx, int sIdx)
			{
			}

			[Token(Token = "0x6000876")]
			[Address(RVA = "0x1AA8D80", Offset = "0x1AA8D80", VA = "0x1AA8D80")]
			public MB_Triangle()
			{
			}
		}

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool DO_INTEGRITY_CHECKS;

		[Token(Token = "0x6000389")]
		[Address(RVA = "0x1AA82A8", Offset = "0x1AA82A8", VA = "0x1AA82A8")]
		public static Texture2D createTextureCopy(Texture2D source)
		{
			return null;
		}

		[Token(Token = "0x600038A")]
		[Address(RVA = "0x1AA8374", Offset = "0x1AA8374", VA = "0x1AA8374")]
		public static bool ArrayBIsSubsetOfA(object[] a, object[] b)
		{
			return default(bool);
		}

		[Token(Token = "0x600038B")]
		[Address(RVA = "0x1AA1A0C", Offset = "0x1AA1A0C", VA = "0x1AA1A0C")]
		public static Material[] GetGOMaterials(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1AA18BC", Offset = "0x1AA18BC", VA = "0x1AA18BC")]
		public static Mesh GetMesh(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1AA8418", Offset = "0x1AA8418", VA = "0x1AA8418")]
		public static void SetMesh(GameObject go, Mesh m)
		{
		}

		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1AA8570", Offset = "0x1AA8570", VA = "0x1AA8570")]
		public static Renderer GetRenderer(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1AA8694", Offset = "0x1AA8694", VA = "0x1AA8694")]
		public static void DisableRendererInSource(GameObject go)
		{
		}

		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1AA87D4", Offset = "0x1AA87D4", VA = "0x1AA87D4")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref Rect uvBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1AA1F64", Offset = "0x1AA1F64", VA = "0x1AA1F64")]
		public static bool hasOutOfBoundsUVs(Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1, int uvChannel = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1AA8870", Offset = "0x1AA8870", VA = "0x1AA8870")]
		public static bool hasOutOfBoundsUVs(Vector2[] uvs, Mesh m, ref MeshAnalysisResult putResultHere, int submeshIndex = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1A99968", Offset = "0x1A99968", VA = "0x1A99968")]
		public static void setSolidColor(Texture2D t, UnityEngine.Color c)
		{
		}

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x1A99A18", Offset = "0x1A99A18", VA = "0x1A99A18")]
		public static Texture2D resampleTexture(Texture2D source, int newWidth, int newHeight)
		{
			return null;
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1AA20A8", Offset = "0x1AA20A8", VA = "0x1AA20A8")]
		public static bool AreAllSharedMaterialsDistinct(Material[] sharedMaterials)
		{
			return default(bool);
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1AA8A94", Offset = "0x1AA8A94", VA = "0x1AA8A94")]
		public static int doSubmeshesShareVertsOrTris(Mesh m, ref MeshAnalysisResult mar)
		{
			return default(int);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x1AA9148", Offset = "0x1AA9148", VA = "0x1AA9148")]
		public static bool GetBounds(GameObject go, out Bounds b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x1A99B9C", Offset = "0x1A99B9C", VA = "0x1A99B9C")]
		public static void Destroy(UnityEngine.Object o)
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x1AA93C8", Offset = "0x1AA93C8", VA = "0x1AA93C8")]
		public MB_Utility()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006B")]
	public struct AtlasPadding
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int topBottom;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int leftRight;

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x141A650", Offset = "0x141A650", VA = "0x141A650")]
		public AtlasPadding(int p)
		{
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x141A658", Offset = "0x141A658", VA = "0x141A658")]
		public AtlasPadding(int px, int py)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200006C")]
	public class AtlasPackingResult
	{
		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int atlasX;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int atlasY;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int usedW;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int usedH;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Rect[] rects;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AtlasPadding[] padding;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int[] srcImgIdxs;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public object data;

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x141A1FC", Offset = "0x141A1FC", VA = "0x141A1FC")]
		public AtlasPackingResult(AtlasPadding[] pds)
		{
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x141A228", Offset = "0x141A228", VA = "0x141A228")]
		public void CalcUsedWidthAndHeight()
		{
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0x141A464", Offset = "0x141A464", VA = "0x141A464", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Token(Token = "0x200006D")]
	public abstract class MB2_TexturePacker
	{
		[Token(Token = "0x2000102")]
		internal enum NodeType
		{
			[Token(Token = "0x40004CC")]
			Container,
			[Token(Token = "0x40004CD")]
			maxDim,
			[Token(Token = "0x40004CE")]
			regular
		}

		[Token(Token = "0x2000103")]
		internal class PixRect
		{
			[Token(Token = "0x40004CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int x;

			[Token(Token = "0x40004D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int y;

			[Token(Token = "0x40004D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int w;

			[Token(Token = "0x40004D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int h;

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x141C264", Offset = "0x141C264", VA = "0x141C264")]
			public PixRect()
			{
			}

			[Token(Token = "0x6000878")]
			[Address(RVA = "0x141C26C", Offset = "0x141C26C", VA = "0x141C26C")]
			public PixRect(int xx, int yy, int ww, int hh)
			{
			}

			[Token(Token = "0x6000879")]
			[Address(RVA = "0x141C2B8", Offset = "0x141C2B8", VA = "0x141C2B8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x2000104")]
		internal class Image
		{
			[Token(Token = "0x40004D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int imgId;

			[Token(Token = "0x40004D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int w;

			[Token(Token = "0x40004D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int h;

			[Token(Token = "0x40004D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int x;

			[Token(Token = "0x40004D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int y;

			[Token(Token = "0x600087A")]
			[Address(RVA = "0x141C024", Offset = "0x141C024", VA = "0x141C024")]
			public Image(int id, int tw, int th, AtlasPadding padding, int minImageSizeX, int minImageSizeY)
			{
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x141C0F4", Offset = "0x141C0F4", VA = "0x141C0F4")]
			public Image(Image im)
			{
			}
		}

		[Token(Token = "0x2000105")]
		internal class ImgIDComparer : IComparer<Image>
		{
			[Token(Token = "0x600087C")]
			[Address(RVA = "0x141C220", Offset = "0x141C220", VA = "0x141C220", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x141C25C", Offset = "0x141C25C", VA = "0x141C25C")]
			public ImgIDComparer()
			{
			}
		}

		[Token(Token = "0x2000106")]
		internal class ImageHeightComparer : IComparer<Image>
		{
			[Token(Token = "0x600087E")]
			[Address(RVA = "0x141C198", Offset = "0x141C198", VA = "0x141C198", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x141C1D4", Offset = "0x141C1D4", VA = "0x141C1D4")]
			public ImageHeightComparer()
			{
			}
		}

		[Token(Token = "0x2000107")]
		internal class ImageWidthComparer : IComparer<Image>
		{
			[Token(Token = "0x6000880")]
			[Address(RVA = "0x141C1DC", Offset = "0x141C1DC", VA = "0x141C1DC", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x6000881")]
			[Address(RVA = "0x141C218", Offset = "0x141C218", VA = "0x141C218")]
			public ImageWidthComparer()
			{
			}
		}

		[Token(Token = "0x2000108")]
		internal class ImageAreaComparer : IComparer<Image>
		{
			[Token(Token = "0x6000882")]
			[Address(RVA = "0x141C14C", Offset = "0x141C14C", VA = "0x141C14C", Slot = "4")]
			public int Compare(Image x, Image y)
			{
				return default(int);
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x141C190", Offset = "0x141C190", VA = "0x141C190")]
			public ImageAreaComparer()
			{
			}
		}

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public bool atlasMustBePowerOfTwo;

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x141B800", Offset = "0x141B800", VA = "0x141B800")]
		public static int RoundToNearestPositivePowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x141B8AC", Offset = "0x141B8AC", VA = "0x141B8AC")]
		public static int CeilToNearestPowerOfTwo(int x)
		{
			return default(int);
		}

		[Token(Token = "0x60003A2")]
		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding);

		[Token(Token = "0x60003A3")]
		public abstract AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas);

		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x141B950", Offset = "0x141B950", VA = "0x141B950")]
		internal bool ScaleAtlasToFitMaxDim(Vector2 rootWH, List<Image> images, int maxDimensionX, int maxDimensionY, AtlasPadding padding, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, ref int outW, ref int outH, out float padX, out float padY, out int newMinSizeX, out int newMinSizeY)
		{
			return default(bool);
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x141BE50", Offset = "0x141BE50", VA = "0x141BE50")]
		public void normalizeRects(AtlasPackingResult rr, AtlasPadding padding)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x141C00C", Offset = "0x141C00C", VA = "0x141C00C")]
		protected MB2_TexturePacker()
		{
		}
	}
	[Token(Token = "0x200006E")]
	public class MB2_TexturePackerRegular : MB2_TexturePacker
	{
		[Token(Token = "0x2000109")]
		private class ProbeResult
		{
			[Token(Token = "0x40004D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int w;

			[Token(Token = "0x40004D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int h;

			[Token(Token = "0x40004DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int outW;

			[Token(Token = "0x40004DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public int outH;

			[Token(Token = "0x40004DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Node root;

			[Token(Token = "0x40004DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool largerOrEqualToMaxDim;

			[Token(Token = "0x40004DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public float efficiency;

			[Token(Token = "0x40004DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public float squareness;

			[Token(Token = "0x40004E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public float totalAtlasArea;

			[Token(Token = "0x40004E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int numAtlases;

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x19AB440", Offset = "0x19AB440", VA = "0x19AB440")]
			public void Set(int ww, int hh, int outw, int outh, Node r, bool fits, float e, float sq)
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x19AB45C", Offset = "0x19AB45C", VA = "0x19AB45C")]
			public float GetScore(bool doPowerOfTwoScore)
			{
				return default(float);
			}

			[Token(Token = "0x6000886")]
			[Address(RVA = "0x19AB494", Offset = "0x19AB494", VA = "0x19AB494")]
			public void PrintTree()
			{
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x19AB4E8", Offset = "0x19AB4E8", VA = "0x19AB4E8")]
			public ProbeResult()
			{
			}
		}

		[Token(Token = "0x200010A")]
		internal class Node
		{
			[Token(Token = "0x40004E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal NodeType isFullAtlas;

			[Token(Token = "0x40004E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Node[] child;

			[Token(Token = "0x40004E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal PixRect r;

			[Token(Token = "0x40004E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal Image img;

			[Token(Token = "0x40004E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ProbeResult bestRoot;

			[Token(Token = "0x6000888")]
			[Address(RVA = "0x19AAFCC", Offset = "0x19AAFCC", VA = "0x19AAFCC")]
			internal Node(NodeType rootType)
			{
			}

			[Token(Token = "0x6000889")]
			[Address(RVA = "0x19AB040", Offset = "0x19AB040", VA = "0x19AB040")]
			private bool isLeaf()
			{
				return default(bool);
			}

			[Token(Token = "0x600088A")]
			[Address(RVA = "0x19AB098", Offset = "0x19AB098", VA = "0x19AB098")]
			internal Node Insert(Image im, bool handed)
			{
				return null;
			}
		}

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private ProbeResult bestRoot;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int atlasY;

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x141E994", Offset = "0x141E994", VA = "0x141E994")]
		private static void printTree(Node r, string spc)
		{
		}

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x141EBE4", Offset = "0x141EBE4", VA = "0x141EBE4")]
		private static void flattenTree(Node r, List<Image> putHere)
		{
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x141ECD8", Offset = "0x141ECD8", VA = "0x141ECD8")]
		private static void drawGizmosNode(Node r)
		{
		}

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x141EF20", Offset = "0x141EF20", VA = "0x141EF20")]
		private static Texture2D createFilledTex(UnityEngine.Color c, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x141F028", Offset = "0x141F028", VA = "0x141F028")]
		public void DrawGizmos()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x141F0E4", Offset = "0x141F0E4", VA = "0x141F0E4")]
		private bool ProbeSingleAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x141F820", Offset = "0x141F820", VA = "0x141F820")]
		private bool ProbeMultiAtlas(Image[] imgsToAdd, int idealAtlasW, int idealAtlasH, float imgArea, int maxAtlasDimX, int maxAtlasDimY, ProbeResult pr)
		{
			return default(bool);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x141F740", Offset = "0x141F740", VA = "0x141F740")]
		internal void GetExtent(Node r, ref int x, ref int y)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x141FCC4", Offset = "0x141FCC4", VA = "0x141FCC4")]
		private int StepWidthHeight(int oldVal, int step, int maxDim)
		{
			return default(int);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x141FCF4", Offset = "0x141FCF4", VA = "0x141FCF4", Slot = "4")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int atPadding)
		{
			return null;
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x141FDEC", Offset = "0x141FDEC", VA = "0x141FDEC", Slot = "5")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
		{
			return null;
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x142113C", Offset = "0x142113C", VA = "0x142113C")]
		private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x141FFF4", Offset = "0x141FFF4", VA = "0x141FFF4")]
		private AtlasPackingResult[] _GetRectsMultiAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x1422CE8", Offset = "0x1422CE8", VA = "0x1422CE8")]
		public MB2_TexturePackerRegular()
		{
		}
	}
	[Token(Token = "0x200006F")]
	public class MB2_TexturePackerHorizontalVert : MB2_TexturePacker
	{
		[Token(Token = "0x200010B")]
		public enum TexturePackingOrientation
		{
			[Token(Token = "0x40004E8")]
			horizontal,
			[Token(Token = "0x40004E9")]
			vertical
		}

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TexturePackingOrientation packingOrientation;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool stretchImagesToEdges;

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x141C45C", Offset = "0x141C45C", VA = "0x141C45C", Slot = "4")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, int maxDimensionX, int maxDimensionY, int padding)
		{
			return null;
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x141C560", Offset = "0x141C560", VA = "0x141C560", Slot = "5")]
		public override AtlasPackingResult[] GetRects(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, bool doMultiAtlas)
		{
			return null;
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x141DA90", Offset = "0x141DA90", VA = "0x141DA90")]
		private AtlasPackingResult _GetRectsSingleAtlas(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionX, int maxDimensionY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY, int recursionDepth)
		{
			return null;
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x141C794", Offset = "0x141C794", VA = "0x141C794")]
		private AtlasPackingResult[] _GetRectsMultiAtlasVertical(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x141D124", Offset = "0x141D124", VA = "0x141D124")]
		private AtlasPackingResult[] _GetRectsMultiAtlasHorizontal(List<Vector2> imgWidthHeights, List<AtlasPadding> paddings, int maxDimensionPassedX, int maxDimensionPassedY, int minImageSizeX, int minImageSizeY, int masterImageSizeX, int masterImageSizeY)
		{
			return null;
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x141E874", Offset = "0x141E874", VA = "0x141E874")]
		private Image PopLargestThatFits(List<Image> images, int spaceRemaining, int maxDim, bool emptyAtlas)
		{
			return null;
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x141E978", Offset = "0x141E978", VA = "0x141E978")]
		public MB2_TexturePackerHorizontalVert()
		{
		}
	}
	[Token(Token = "0x2000070")]
	internal interface MB_ITextureCombinerPacker
	{
		[Token(Token = "0x60003BC")]
		IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x60003BD")]
		AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x60003BE")]
		IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);
	}
	[Token(Token = "0x2000071")]
	internal abstract class MB3_TextureCombinerPackerRoot : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7D4", Offset = "0xADD7D4")]
		private sealed class <ConvertTexturesToReadableFormats>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x40004ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x40004EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x17000104")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600088E")]
				[Address(RVA = "0x17939D0", Offset = "0x17939D0", VA = "0x17939D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000105")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000890")]
				[Address(RVA = "0x1793A38", Offset = "0x1793A38", VA = "0x1793A38", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600088B")]
			[Address(RVA = "0x179371C", Offset = "0x179371C", VA = "0x179371C")]
			[DebuggerHidden]
			public <ConvertTexturesToReadableFormats>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x600088C")]
			[Address(RVA = "0x1793754", Offset = "0x1793754", VA = "0x1793754", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600088D")]
			[Address(RVA = "0x1793758", Offset = "0x1793758", VA = "0x1793758", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600088F")]
			[Address(RVA = "0x17939D8", Offset = "0x17939D8", VA = "0x17939D8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x178FB60", Offset = "0x178FB60", VA = "0x178FB60")]
		internal static void CreateTemporaryTexturesForAtlas(List<MB_TexSet> distinctMaterialTextures, MB3_TextureCombiner combiner, int propIdx, MB3_TextureCombinerPipeline.TexturePipelineData data)
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x178FE3C", Offset = "0x178FE3C", VA = "0x178FE3C")]
		public static AtlasPackingResult[] CalculateAtlasRectanglesStatic(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x179362C", Offset = "0x179362C", VA = "0x179362C")]
		public static void MakeProceduralTexturesReadable(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x1793698", Offset = "0x1793698", VA = "0x1793698", Slot = "7")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF978", Offset = "0xADF978")]
		public virtual IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1793748", Offset = "0x1793748", VA = "0x1793748", Slot = "8")]
		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x60003C4")]
		public abstract IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL);

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x178E0B4", Offset = "0x178E0B4", VA = "0x178E0B4")]
		protected MB3_TextureCombinerPackerRoot()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000072")]
	public class ShaderTextureProperty
	{
		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool isNormalMap;

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1A9E8F4", Offset = "0x1A9E8F4", VA = "0x1A9E8F4")]
		public ShaderTextureProperty(string n, bool norm)
		{
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x1AAA098", Offset = "0x1AAA098", VA = "0x1AAA098", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x1AAA15C", Offset = "0x1AAA15C", VA = "0x1AAA15C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x1AA3378", Offset = "0x1AA3378", VA = "0x1AA3378")]
		public static string[] GetNames(List<ShaderTextureProperty> props)
		{
			return null;
		}
	}
	[Serializable]
	[Token(Token = "0x2000073")]
	public class MB3_TextureCombiner
	{
		[Token(Token = "0x200010D")]
		private class TemporaryTexture
		{
			[Token(Token = "0x40004EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal string property;

			[Token(Token = "0x40004F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal Texture2D texture;

			[Token(Token = "0x6000891")]
			[Address(RVA = "0x1785E18", Offset = "0x1785E18", VA = "0x1785E18")]
			public TemporaryTexture(string prop, Texture2D tex)
			{
			}
		}

		[Token(Token = "0x200010E")]
		public class CombineTexturesIntoAtlasesCoroutineResult
		{
			[Token(Token = "0x40004F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool success;

			[Token(Token = "0x40004F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool isFinished;

			[Token(Token = "0x6000892")]
			[Address(RVA = "0x17850D4", Offset = "0x17850D4", VA = "0x17850D4")]
			public CombineTexturesIntoAtlasesCoroutineResult()
			{
			}
		}

		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7E4", Offset = "0xADD7E4")]
		private sealed class <CombineTexturesIntoAtlasesCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40004F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40004F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40004F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CombineTexturesIntoAtlasesCoroutineResult coroutineResult;

			[Token(Token = "0x40004F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public float maxTimePerFrame;

			[Token(Token = "0x40004F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x40004F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40004F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x40004FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Material resultMaterial;

			[Token(Token = "0x40004FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<GameObject> objsToMesh;

			[Token(Token = "0x40004FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public List<Material> allowedMaterialsFilter;

			[Token(Token = "0x40004FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x40004FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public List<AtlasPackingResult> packingResults;

			[Token(Token = "0x40004FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public bool onlyPackRects;

			[Token(Token = "0x17000106")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000896")]
				[Address(RVA = "0x17881F8", Offset = "0x17881F8", VA = "0x17881F8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000107")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000898")]
				[Address(RVA = "0x1788260", Offset = "0x1788260", VA = "0x1788260", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000893")]
			[Address(RVA = "0x178528C", Offset = "0x178528C", VA = "0x178528C")]
			[DebuggerHidden]
			public <CombineTexturesIntoAtlasesCoroutine>d__68(int <>1__state)
			{
			}

			[Token(Token = "0x6000894")]
			[Address(RVA = "0x1788004", Offset = "0x1788004", VA = "0x1788004", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000895")]
			[Address(RVA = "0x1788008", Offset = "0x1788008", VA = "0x1788008", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000897")]
			[Address(RVA = "0x1788200", Offset = "0x1788200", VA = "0x1788200", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000110")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD7F4", Offset = "0xADD7F4")]
		private sealed class <_CombineTexturesIntoAtlases>d__69 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000500")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000501")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000502")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x4000503")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000504")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public List<GameObject> objsToMesh;

			[Token(Token = "0x4000505")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000506")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000507")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Material resultMaterial;

			[Token(Token = "0x4000508")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public List<Material> allowedMaterialsFilter;

			[Token(Token = "0x4000509")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool onlyPackRects;

			[Token(Token = "0x400050A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public List<AtlasPackingResult> atlasPackingResult;

			[Token(Token = "0x400050B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x400050C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Stopwatch <sw>5__2;

			[Token(Token = "0x17000108")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600089D")]
				[Address(RVA = "0x1788CB8", Offset = "0x1788CB8", VA = "0x1788CB8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000109")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600089F")]
				[Address(RVA = "0x1788D20", Offset = "0x1788D20", VA = "0x1788D20", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000899")]
			[Address(RVA = "0x17852B8", Offset = "0x17852B8", VA = "0x17852B8")]
			[DebuggerHidden]
			public <_CombineTexturesIntoAtlases>d__69(int <>1__state)
			{
			}

			[Token(Token = "0x600089A")]
			[Address(RVA = "0x1788268", Offset = "0x1788268", VA = "0x1788268", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600089B")]
			[Address(RVA = "0x1788548", Offset = "0x1788548", VA = "0x1788548", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600089C")]
			[Address(RVA = "0x1788294", Offset = "0x1788294", VA = "0x1788294")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x600089E")]
			[Address(RVA = "0x1788CC0", Offset = "0x1788CC0", VA = "0x1788CC0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000111")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD804", Offset = "0xADD804")]
		private sealed class <__CombineTexturesIntoAtlases>d__71 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400050D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400050E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400050F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x4000510")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000511")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000512")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000513")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000514")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x4000515")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private StringBuilder <report>5__2;

			[Token(Token = "0x4000516")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private MB_ITextureCombinerPacker <texturePaker>5__3;

			[Token(Token = "0x1700010A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A3")]
				[Address(RVA = "0x17896B0", Offset = "0x17896B0", VA = "0x17896B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008A5")]
				[Address(RVA = "0x1789718", Offset = "0x1789718", VA = "0x1789718", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A0")]
			[Address(RVA = "0x1785B0C", Offset = "0x1785B0C", VA = "0x1785B0C")]
			[DebuggerHidden]
			public <__CombineTexturesIntoAtlases>d__71(int <>1__state)
			{
			}

			[Token(Token = "0x60008A1")]
			[Address(RVA = "0x1788D28", Offset = "0x1788D28", VA = "0x1788D28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A2")]
			[Address(RVA = "0x1788D2C", Offset = "0x1788D2C", VA = "0x1788D2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008A4")]
			[Address(RVA = "0x17896B8", Offset = "0x17896B8", VA = "0x17896B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000112")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD814", Offset = "0xADD814")]
		private sealed class <__RunTexturePacker>d__72 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000517")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000518")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000519")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB3_TextureCombiner <>4__this;

			[Token(Token = "0x400051A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x400051B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x400051C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x400051D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public List<AtlasPackingResult> packingResult;

			[Token(Token = "0x1700010C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008A9")]
				[Address(RVA = "0x1789BA8", Offset = "0x1789BA8", VA = "0x1789BA8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700010D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008AB")]
				[Address(RVA = "0x1789C10", Offset = "0x1789C10", VA = "0x1789C10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008A6")]
			[Address(RVA = "0x1785BD0", Offset = "0x1785BD0", VA = "0x1785BD0")]
			[DebuggerHidden]
			public <__RunTexturePacker>d__72(int <>1__state)
			{
			}

			[Token(Token = "0x60008A7")]
			[Address(RVA = "0x1789720", Offset = "0x1789720", VA = "0x1789720", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008A8")]
			[Address(RVA = "0x1789724", Offset = "0x1789724", VA = "0x1789724", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008AA")]
			[Address(RVA = "0x1789BB0", Offset = "0x1789BB0", VA = "0x1789BB0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		protected MB2_TextureBakeResults _textureBakeResults;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int _atlasPadding;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[SerializeField]
		protected int _maxAtlasSize;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected int _maxAtlasWidthOverride;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected int _maxAtlasHeightOverride;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected bool _useMaxAtlasWidthOverride;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[SerializeField]
		protected bool _useMaxAtlasHeightOverride;

		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[SerializeField]
		protected bool _resizePowerOfTwoTextures;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		[SerializeField]
		protected bool _fixOutOfBoundsUVs;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		protected int _maxTilingBakeSize;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected bool _saveAtlasesAsAssets;

		[Token(Token = "0x40002C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[SerializeField]
		protected MB2_PackingAlgorithmEnum _packingAlgorithm;

		[Token(Token = "0x40002C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected bool _meshBakerTexturePackerForcePowerOfTwo;

		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected List<ShaderTextureProperty> _customShaderPropNames;

		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected bool _normalizeTexelDensity;

		[Token(Token = "0x40002C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		[SerializeField]
		protected bool _considerNonTextureProperties;

		[Token(Token = "0x40002CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<TemporaryTexture> _temporaryTextures;

		[Token(Token = "0x40002CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool _RunCorutineWithoutPauseIsRunning;

		[Token(Token = "0x17000049")]
		public MB2_TextureBakeResults textureBakeResults
		{
			[Token(Token = "0x60003CA")]
			[Address(RVA = "0x1784BA8", Offset = "0x1784BA8", VA = "0x1784BA8")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003CB")]
			[Address(RVA = "0x1784BB0", Offset = "0x1784BB0", VA = "0x1784BB0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004A")]
		public int atlasPadding
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0x1784BB8", Offset = "0x1784BB8", VA = "0x1784BB8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CD")]
			[Address(RVA = "0x1784BC0", Offset = "0x1784BC0", VA = "0x1784BC0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public int maxAtlasSize
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0x1784BC8", Offset = "0x1784BC8", VA = "0x1784BC8")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003CF")]
			[Address(RVA = "0x1784BD0", Offset = "0x1784BD0", VA = "0x1784BD0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public virtual int maxAtlasWidthOverride
		{
			[Token(Token = "0x60003D0")]
			[Address(RVA = "0x1784BD8", Offset = "0x1784BD8", VA = "0x1784BD8", Slot = "4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D1")]
			[Address(RVA = "0x1784BE0", Offset = "0x1784BE0", VA = "0x1784BE0", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		public virtual int maxAtlasHeightOverride
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0x1784BE8", Offset = "0x1784BE8", VA = "0x1784BE8", Slot = "6")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003D3")]
			[Address(RVA = "0x1784BF0", Offset = "0x1784BF0", VA = "0x1784BF0", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x1700004E")]
		public virtual bool useMaxAtlasWidthOverride
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0x1784BF8", Offset = "0x1784BF8", VA = "0x1784BF8", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D5")]
			[Address(RVA = "0x1784C00", Offset = "0x1784C00", VA = "0x1784C00", Slot = "9")]
			set
			{
			}
		}

		[Token(Token = "0x1700004F")]
		public virtual bool useMaxAtlasHeightOverride
		{
			[Token(Token = "0x60003D6")]
			[Address(RVA = "0x1784C0C", Offset = "0x1784C0C", VA = "0x1784C0C", Slot = "10")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D7")]
			[Address(RVA = "0x1784C14", Offset = "0x1784C14", VA = "0x1784C14", Slot = "11")]
			set
			{
			}
		}

		[Token(Token = "0x17000050")]
		public bool resizePowerOfTwoTextures
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0x1784C20", Offset = "0x1784C20", VA = "0x1784C20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003D9")]
			[Address(RVA = "0x1784C28", Offset = "0x1784C28", VA = "0x1784C28")]
			set
			{
			}
		}

		[Token(Token = "0x17000051")]
		public bool fixOutOfBoundsUVs
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x1784C34", Offset = "0x1784C34", VA = "0x1784C34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x1784C3C", Offset = "0x1784C3C", VA = "0x1784C3C")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public int maxTilingBakeSize
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x1784C48", Offset = "0x1784C48", VA = "0x1784C48")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x1784C50", Offset = "0x1784C50", VA = "0x1784C50")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public bool saveAtlasesAsAssets
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x1784C58", Offset = "0x1784C58", VA = "0x1784C58")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x1784C60", Offset = "0x1784C60", VA = "0x1784C60")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public MB2_PackingAlgorithmEnum packingAlgorithm
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x1784C6C", Offset = "0x1784C6C", VA = "0x1784C6C")]
			get
			{
				return default(MB2_PackingAlgorithmEnum);
			}
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x1784C74", Offset = "0x1784C74", VA = "0x1784C74")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public bool meshBakerTexturePackerForcePowerOfTwo
		{
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x1784C7C", Offset = "0x1784C7C", VA = "0x1784C7C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x1784C84", Offset = "0x1784C84", VA = "0x1784C84")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		public List<ShaderTextureProperty> customShaderPropNames
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x1784C90", Offset = "0x1784C90", VA = "0x1784C90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E5")]
			[Address(RVA = "0x1784C98", Offset = "0x1784C98", VA = "0x1784C98")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public bool considerNonTextureProperties
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0x1784CA0", Offset = "0x1784CA0", VA = "0x1784CA0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x1784CA8", Offset = "0x1784CA8", VA = "0x1784CA8")]
			set
			{
			}
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x1784CB4", Offset = "0x1784CB4", VA = "0x1784CB4")]
		public static void RunCorutineWithoutPause(IEnumerator cor, int recursionDepth)
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1784FB8", Offset = "0x1784FB8", VA = "0x1784FB8")]
		public bool CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, [Optional] MB2_EditorMethodsInterface textureEditorMethods, [Optional] List<AtlasPackingResult> packingResults, bool onlyPackRects = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x17851B0", Offset = "0x17851B0", VA = "0x17851B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADF9DC", Offset = "0xADF9DC")]
		public IEnumerator CombineTexturesIntoAtlasesCoroutine(ProgressUpdateDelegate progressInfo, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, [Optional] MB2_EditorMethodsInterface textureEditorMethods, [Optional] CombineTexturesIntoAtlasesCoroutineResult coroutineResult, float maxTimePerFrame = 0.01f, [Optional] List<AtlasPackingResult> packingResults, bool onlyPackRects = false)
		{
			return null;
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x17850E4", Offset = "0x17850E4", VA = "0x17850E4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFA40", Offset = "0xADFA40")]
		private IEnumerator _CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, Material resultMaterial, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> atlasPackingResult, bool onlyPackRects)
		{
			return null;
		}

		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x17852E4", Offset = "0x17852E4", VA = "0x17852E4")]
		private MB3_TextureCombinerPipeline.TexturePipelineData LoadPipelineData(Material resultMaterial, List<ShaderTextureProperty> texPropertyNames, List<GameObject> objsToMesh, List<Material> allowedMaterialsFilter, List<MB_TexSet> distinctMaterialTextures)
		{
			return null;
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0x1785A68", Offset = "0x1785A68", VA = "0x1785A68")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFAA4", Offset = "0xADFAA4")]
		private IEnumerator __CombineTexturesIntoAtlases(ProgressUpdateDelegate progressInfo, CombineTexturesIntoAtlasesCoroutineResult result, MB_AtlasesAndRects resultAtlasesAndRects, MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods)
		{
			return null;
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0x1785B38", Offset = "0x1785B38", VA = "0x1785B38")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFB08", Offset = "0xADFB08")]
		private IEnumerator __RunTexturePacker(CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB2_EditorMethodsInterface textureEditorMethods, List<AtlasPackingResult> packingResult)
		{
			return null;
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0x1785BFC", Offset = "0x1785BFC", VA = "0x1785BFC")]
		internal int _getNumTemporaryTextures()
		{
			return default(int);
		}

		[Token(Token = "0x60003F0")]
		[Address(RVA = "0x1785C4C", Offset = "0x1785C4C", VA = "0x1785C4C")]
		public Texture2D _createTemporaryTexture(string propertyName, int w, int h, TextureFormat texFormat, bool mipMaps)
		{
			return null;
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x1785E50", Offset = "0x1785E50", VA = "0x1785E50")]
		internal Texture2D _createTextureCopy(string propertyName, Texture2D t)
		{
			return null;
		}

		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x1785FD0", Offset = "0x1785FD0", VA = "0x1785FD0")]
		internal Texture2D _resizeTexture(string propertyName, Texture2D t, int w, int h)
		{
			return null;
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1786140", Offset = "0x1786140", VA = "0x1786140")]
		internal void _destroyAllTemporaryTextures()
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0x17862A8", Offset = "0x17862A8", VA = "0x17862A8")]
		internal void _destroyTemporaryTextures(string propertyName)
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0x17865C0", Offset = "0x17865C0", VA = "0x17865C0")]
		public void _restoreProceduralMaterials()
		{
		}

		[Token(Token = "0x60003F6")]
		[Address(RVA = "0x17865C4", Offset = "0x17865C4", VA = "0x17865C4")]
		public void SuggestTreatment(List<GameObject> objsToMesh, Material[] resultMaterials, List<ShaderTextureProperty> _customShaderPropNames)
		{
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0x1787E64", Offset = "0x1787E64", VA = "0x1787E64")]
		private string PrintList(List<GameObject> gos)
		{
			return null;
		}

		[Token(Token = "0x60003F8")]
		[Address(RVA = "0x1787F44", Offset = "0x1787F44", VA = "0x1787F44")]
		public MB3_TextureCombiner()
		{
		}
	}
	[Token(Token = "0x2000074")]
	public class MeshBakerMaterialTexture
	{
		[Token(Token = "0x40002CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Texture2D _t;

		[Token(Token = "0x40002CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float texelDensity;

		[Token(Token = "0x40002CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static bool readyToBuildAtlases;

		[Token(Token = "0x40002CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DRect encapsulatingSamplingRect;

		[Token(Token = "0x40002D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEA80", Offset = "0xADEA80")]
		private DRect <matTilingRect>k__BackingField;

		[Token(Token = "0x17000058")]
		public Texture2D t
		{
			[Token(Token = "0x60003FA")]
			[Address(RVA = "0x1AA9660", Offset = "0x1AA9660", VA = "0x1AA9660")]
			set
			{
			}
		}

		[Token(Token = "0x17000059")]
		public DRect matTilingRect
		{
			[Token(Token = "0x60003FB")]
			[Address(RVA = "0x1AA9668", Offset = "0x1AA9668", VA = "0x1AA9668")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFB6C", Offset = "0xADFB6C")]
			get
			{
				return default(DRect);
			}
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0x1AA9674", Offset = "0x1AA9674", VA = "0x1AA9674")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFB7C", Offset = "0xADFB7C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005A")]
		public bool isNull
		{
			[Token(Token = "0x6000403")]
			[Address(RVA = "0x1A9CAA0", Offset = "0x1A9CAA0", VA = "0x1A9CAA0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700005B")]
		public int width
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0x1A9DC0C", Offset = "0x1A9DC0C", VA = "0x1A9DC0C")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700005C")]
		public int height
		{
			[Token(Token = "0x6000405")]
			[Address(RVA = "0x1A9DCD4", Offset = "0x1A9DCD4", VA = "0x1A9DCD4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0x1AA9680", Offset = "0x1AA9680", VA = "0x1AA9680")]
		public MeshBakerMaterialTexture()
		{
		}

		[Token(Token = "0x60003FE")]
		[Address(RVA = "0x1AA9688", Offset = "0x1AA9688", VA = "0x1AA9688")]
		public MeshBakerMaterialTexture(Texture tx)
		{
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0x1AA21D0", Offset = "0x1AA21D0", VA = "0x1AA21D0")]
		public MeshBakerMaterialTexture(Texture tx, Vector2 matTilingOffset, Vector2 matTilingScale, float texelDens)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0x1AA978C", Offset = "0x1AA978C", VA = "0x1AA978C")]
		public DRect GetEncapsulatingSamplingRect()
		{
			return default(DRect);
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0x1AA6C7C", Offset = "0x1AA6C7C", VA = "0x1AA6C7C")]
		public void SetEncapsulatingSamplingRect(MB_TexSet ts, DRect r)
		{
		}

		[Token(Token = "0x6000402")]
		[Address(RVA = "0x1A9A0D0", Offset = "0x1A9A0D0", VA = "0x1A9A0D0")]
		public Texture2D GetTexture2D()
		{
			return null;
		}

		[Token(Token = "0x6000406")]
		[Address(RVA = "0x1A9DB6C", Offset = "0x1A9DB6C", VA = "0x1A9DB6C")]
		public string GetTexName()
		{
			return null;
		}

		[Token(Token = "0x6000407")]
		[Address(RVA = "0x1A9CB10", Offset = "0x1A9CB10", VA = "0x1A9CB10")]
		public bool AreTexturesEqual(MeshBakerMaterialTexture b)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000075")]
	public class MatAndTransformToMerged
	{
		[Token(Token = "0x40002D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material mat;

		[Token(Token = "0x40002D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEA90", Offset = "0xADEA90")]
		private DRect <obUVRectIfTilingSame>k__BackingField;

		[Token(Token = "0x40002D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAA0", Offset = "0xADEAA0")]
		private DRect <samplingRectMatAndUVTiling>k__BackingField;

		[Token(Token = "0x40002D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAB0", Offset = "0xADEAB0")]
		private DRect <materialTiling>k__BackingField;

		[Token(Token = "0x40002D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public string objName;

		[Token(Token = "0x1700005D")]
		public DRect obUVRectIfTilingSame
		{
			[Token(Token = "0x6000409")]
			[Address(RVA = "0x1AA93D4", Offset = "0x1AA93D4", VA = "0x1AA93D4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFB8C", Offset = "0xADFB8C")]
			get
			{
				return default(DRect);
			}
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x1AA93E0", Offset = "0x1AA93E0", VA = "0x1AA93E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFB9C", Offset = "0xADFB9C")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005E")]
		public DRect samplingRectMatAndUVTiling
		{
			[Token(Token = "0x600040B")]
			[Address(RVA = "0x1AA93EC", Offset = "0x1AA93EC", VA = "0x1AA93EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBAC", Offset = "0xADFBAC")]
			get
			{
				return default(DRect);
			}
			[Token(Token = "0x600040C")]
			[Address(RVA = "0x1AA93F8", Offset = "0x1AA93F8", VA = "0x1AA93F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBBC", Offset = "0xADFBBC")]
			private set
			{
			}
		}

		[Token(Token = "0x1700005F")]
		public DRect materialTiling
		{
			[Token(Token = "0x600040D")]
			[Address(RVA = "0x1AA9404", Offset = "0x1AA9404", VA = "0x1AA9404")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBCC", Offset = "0xADFBCC")]
			get
			{
				return default(DRect);
			}
			[Token(Token = "0x600040E")]
			[Address(RVA = "0x1AA9410", Offset = "0x1AA9410", VA = "0x1AA9410")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBDC", Offset = "0xADFBDC")]
			private set
			{
			}
		}

		[Token(Token = "0x600040F")]
		[Address(RVA = "0x1AA941C", Offset = "0x1AA941C", VA = "0x1AA941C")]
		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0x1AA2464", Offset = "0x1AA2464", VA = "0x1AA2464")]
		public MatAndTransformToMerged(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
		{
		}

		[Token(Token = "0x6000411")]
		[Address(RVA = "0x1AA9480", Offset = "0x1AA9480", VA = "0x1AA9480")]
		private void _init(DRect obUVrect, bool fixOutOfBoundsUVs, Material m)
		{
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0x1AA94EC", Offset = "0x1AA94EC", VA = "0x1AA94EC", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0x1AA95D4", Offset = "0x1AA95D4", VA = "0x1AA95D4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0x1A9FF78", Offset = "0x1A9FF78", VA = "0x1A9FF78")]
		public string GetMaterialName()
		{
			return null;
		}

		[Token(Token = "0x6000415")]
		[Address(RVA = "0x1AA71BC", Offset = "0x1AA71BC", VA = "0x1AA71BC")]
		public void AssignInitialValuesForMaterialTilingAndSamplingRectMatAndUVTiling(bool allTexturesUseSameMatTiling, DRect matTiling)
		{
		}
	}
	[Token(Token = "0x2000076")]
	public class MatsAndGOs
	{
		[Token(Token = "0x40002D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<MatAndTransformToMerged> mats;

		[Token(Token = "0x40002D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public List<GameObject> gos;

		[Token(Token = "0x6000416")]
		[Address(RVA = "0x1AA6B54", Offset = "0x1AA6B54", VA = "0x1AA6B54")]
		public MatsAndGOs()
		{
		}
	}
	[Token(Token = "0x2000077")]
	public class MB_TexSet
	{
		[Token(Token = "0x2000113")]
		private interface PipelineVariation
		{
			[Token(Token = "0x60008AC")]
			void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect);

			[Token(Token = "0x60008AD")]
			void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment);

			[Token(Token = "0x60008AE")]
			Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex);

			[Token(Token = "0x60008AF")]
			void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props);
		}

		[Token(Token = "0x2000114")]
		private class PipelineVariationAllTexturesUseSameMatTiling : PipelineVariation
		{
			[Token(Token = "0x400051E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB_TexSet texSet;

			[Token(Token = "0x60008B0")]
			[Address(RVA = "0x1AA6E54", Offset = "0x1AA6E54", VA = "0x1AA6E54")]
			public PipelineVariationAllTexturesUseSameMatTiling(MB_TexSet ts)
			{
			}

			[Token(Token = "0x60008B1")]
			[Address(RVA = "0x1AA7B84", Offset = "0x1AA7B84", VA = "0x1AA7B84", Slot = "4")]
			public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
			{
			}

			[Token(Token = "0x60008B2")]
			[Address(RVA = "0x1AA7C8C", Offset = "0x1AA7C8C", VA = "0x1AA7C8C", Slot = "5")]
			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			[Token(Token = "0x60008B3")]
			[Address(RVA = "0x1AA7DA4", Offset = "0x1AA7DA4", VA = "0x1AA7DA4", Slot = "6")]
			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default(Rect);
			}

			[Token(Token = "0x60008B4")]
			[Address(RVA = "0x1AA7E58", Offset = "0x1AA7E58", VA = "0x1AA7E58", Slot = "7")]
			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		[Token(Token = "0x2000115")]
		private class PipelineVariationSomeTexturesUseDifferentMatTiling : PipelineVariation
		{
			[Token(Token = "0x400051F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB_TexSet texSet;

			[Token(Token = "0x60008B5")]
			[Address(RVA = "0x1AA6B5C", Offset = "0x1AA6B5C", VA = "0x1AA6B5C")]
			public PipelineVariationSomeTexturesUseDifferentMatTiling(MB_TexSet ts)
			{
			}

			[Token(Token = "0x60008B6")]
			[Address(RVA = "0x1AA7E5C", Offset = "0x1AA7E5C", VA = "0x1AA7E5C", Slot = "4")]
			public void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
			{
			}

			[Token(Token = "0x60008B7")]
			[Address(RVA = "0x1AA7F80", Offset = "0x1AA7F80", VA = "0x1AA7F80", Slot = "5")]
			public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
			{
			}

			[Token(Token = "0x60008B8")]
			[Address(RVA = "0x1AA8098", Offset = "0x1AA8098", VA = "0x1AA8098", Slot = "6")]
			public Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
			{
				return default(Rect);
			}

			[Token(Token = "0x60008B9")]
			[Address(RVA = "0x1AA80D8", Offset = "0x1AA80D8", VA = "0x1AA80D8", Slot = "7")]
			public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
			{
			}
		}

		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MeshBakerMaterialTexture[] ts;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MatsAndGOs matsAndGOs;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAC0", Offset = "0xADEAC0")]
		private bool <allTexturesUseSameMatTiling>k__BackingField;

		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAD0", Offset = "0xADEAD0")]
		private bool <thisIsOnlyTexSetInAtlas>k__BackingField;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAE0", Offset = "0xADEAE0")]
		private MB_TextureTilingTreatment <tilingTreatment>k__BackingField;

		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEAF0", Offset = "0xADEAF0")]
		private Vector2 <obUVoffset>k__BackingField;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB00", Offset = "0xADEB00")]
		private Vector2 <obUVscale>k__BackingField;

		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public int idealWidth;

		[Token(Token = "0x40002E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int idealHeight;

		[Token(Token = "0x40002E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private PipelineVariation pipelineVariation;

		[Token(Token = "0x17000060")]
		public bool allTexturesUseSameMatTiling
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0x1AA6AC0", Offset = "0x1AA6AC0", VA = "0x1AA6AC0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBEC", Offset = "0xADFBEC")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000418")]
			[Address(RVA = "0x1AA6AC8", Offset = "0x1AA6AC8", VA = "0x1AA6AC8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFBFC", Offset = "0xADFBFC")]
			private set
			{
			}
		}

		[Token(Token = "0x17000061")]
		public bool thisIsOnlyTexSetInAtlas
		{
			[Token(Token = "0x6000419")]
			[Address(RVA = "0x1AA6AD4", Offset = "0x1AA6AD4", VA = "0x1AA6AD4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC0C", Offset = "0xADFC0C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600041A")]
			[Address(RVA = "0x1AA6ADC", Offset = "0x1AA6ADC", VA = "0x1AA6ADC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC1C", Offset = "0xADFC1C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000062")]
		public MB_TextureTilingTreatment tilingTreatment
		{
			[Token(Token = "0x600041B")]
			[Address(RVA = "0x1AA6AE8", Offset = "0x1AA6AE8", VA = "0x1AA6AE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC2C", Offset = "0xADFC2C")]
			get
			{
				return default(MB_TextureTilingTreatment);
			}
			[Token(Token = "0x600041C")]
			[Address(RVA = "0x1AA6AF0", Offset = "0x1AA6AF0", VA = "0x1AA6AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC3C", Offset = "0xADFC3C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000063")]
		public Vector2 obUVoffset
		{
			[Token(Token = "0x600041D")]
			[Address(RVA = "0x1AA6AF8", Offset = "0x1AA6AF8", VA = "0x1AA6AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC4C", Offset = "0xADFC4C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600041E")]
			[Address(RVA = "0x1AA6B00", Offset = "0x1AA6B00", VA = "0x1AA6B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC5C", Offset = "0xADFC5C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000064")]
		public Vector2 obUVscale
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0x1AA6B08", Offset = "0x1AA6B08", VA = "0x1AA6B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC6C", Offset = "0xADFC6C")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000420")]
			[Address(RVA = "0x1AA6B10", Offset = "0x1AA6B10", VA = "0x1AA6B10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADFC7C", Offset = "0xADFC7C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000065")]
		internal DRect obUVrect
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0x1AA6B18", Offset = "0x1AA6B18", VA = "0x1AA6B18")]
			get
			{
				return default(DRect);
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0x1AA2330", Offset = "0x1AA2330", VA = "0x1AA2330")]
		public MB_TexSet(MeshBakerMaterialTexture[] tss, Vector2 uvOffset, Vector2 uvScale, MB_TextureTilingTreatment treatment)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0x1A9EA28", Offset = "0x1A9EA28", VA = "0x1A9EA28")]
		internal bool IsEqual(object obj, bool fixOutOfBoundsUVs, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default(bool);
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0x1AA6B88", Offset = "0x1AA6B88", VA = "0x1AA6B88")]
		private Rect GetEncapsulatingSamplingRectIfTilingSame()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0x1AA6C1C", Offset = "0x1AA6C1C", VA = "0x1AA6C1C")]
		public void SetEncapsulatingSamplingRectWhenMergingTexSets(DRect newEncapsulatingSamplingRect)
		{
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0x1AA6C88", Offset = "0x1AA6C88", VA = "0x1AA6C88")]
		public void SetEncapsulatingSamplingRectForTesting(int propIdx, DRect newEncapsulatingSamplingRect)
		{
		}

		[Token(Token = "0x6000427")]
		[Address(RVA = "0x1A9FEE4", Offset = "0x1A9FEE4", VA = "0x1A9FEE4")]
		public void SetEncapsulatingRect(int propIdx, bool considerMeshUVs)
		{
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0x1AA6CD0", Offset = "0x1AA6CD0", VA = "0x1AA6CD0")]
		public void CreateColoredTexToReplaceNull(string propName, int propIdx, bool considerMeshUVs, MB3_TextureCombiner combiner, UnityEngine.Color col)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0x1A9FE10", Offset = "0x1A9FE10", VA = "0x1A9FE10")]
		public void SetThisIsOnlyTexSetInAtlasTrue()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0x1AA6DE8", Offset = "0x1AA6DE8", VA = "0x1AA6DE8")]
		public void SetAllTexturesUseSameMatTilingTrue()
		{
		}

		[Token(Token = "0x600042B")]
		[Address(RVA = "0x1AA3120", Offset = "0x1AA3120", VA = "0x1AA3120")]
		public void AdjustResultMaterialNonTextureProperties(Material resultMaterial, List<ShaderTextureProperty> props)
		{
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0x1A9FE1C", Offset = "0x1A9FE1C", VA = "0x1A9FE1C")]
		public void SetTilingTreatmentAndAdjustEncapsulatingSamplingRect(MB_TextureTilingTreatment newTilingTreatment)
		{
		}

		[Token(Token = "0x600042D")]
		[Address(RVA = "0x1AA31EC", Offset = "0x1AA31EC", VA = "0x1AA31EC")]
		internal void GetRectsForTextureBakeResults(out Rect allPropsUseSameTiling_encapsulatingSamplingRect, out Rect propsUseDifferntTiling_obUVRect)
		{
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0x1AA32B4", Offset = "0x1AA32B4", VA = "0x1AA32B4")]
		internal Rect GetMaterialTilingRectForTextureBakerResults(int materialIndex)
		{
			return default(Rect);
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0x1AA6E80", Offset = "0x1AA6E80", VA = "0x1AA6E80")]
		internal void CalcInitialFullSamplingRects(bool fixOutOfBoundsUVs)
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0x1AA706C", Offset = "0x1AA706C", VA = "0x1AA706C")]
		internal void CalcMatAndUVSamplingRects()
		{
		}

		[Token(Token = "0x6000431")]
		[Address(RVA = "0x1AA7264", Offset = "0x1AA7264", VA = "0x1AA7264")]
		public bool AllTexturesAreSameForMerge(MB_TexSet other, bool considerNonTextureProperties, MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender)
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0x1AA74AC", Offset = "0x1AA74AC", VA = "0x1AA74AC")]
		internal void DrawRectsToMergeGizmos(UnityEngine.Color encC, UnityEngine.Color innerC)
		{
		}

		[Token(Token = "0x6000433")]
		[Address(RVA = "0x1AA7770", Offset = "0x1AA7770", VA = "0x1AA7770")]
		internal string GetDescription()
		{
			return null;
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0x1AA7A20", Offset = "0x1AA7A20", VA = "0x1AA7A20")]
		internal string GetMatSubrectDescriptions()
		{
			return null;
		}
	}
	[Token(Token = "0x2000078")]
	public class MB3_TextureCombinerMerging
	{
		[Token(Token = "0x40002E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _considerNonTextureProperties;

		[Token(Token = "0x40002E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MB3_TextureCombinerNonTextureProperties resultMaterialTextureBlender;

		[Token(Token = "0x40002E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool fixOutOfBoundsUVs;

		[Token(Token = "0x40002E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40002E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool LOG_LEVEL_TRACE_MERGE_MAT_SUBRECTS;

		[Token(Token = "0x6000435")]
		[Address(RVA = "0x1789C18", Offset = "0x1789C18", VA = "0x1789C18")]
		public static Rect BuildTransformMeshUV2AtlasRect(bool considerMeshUVs, Rect _atlasRect, Rect _obUVRect, Rect _sourceMaterialTiling, Rect _encapsulatingRect)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0x1789DF0", Offset = "0x1789DF0", VA = "0x1789DF0")]
		public MB3_TextureCombinerMerging(bool considerNonTextureProps, MB3_TextureCombinerNonTextureProperties resultMaterialTexBlender, bool fixObUVs, MB2_LogLevel logLevel)
		{
		}

		[Token(Token = "0x6000437")]
		[Address(RVA = "0x1789E5C", Offset = "0x1789E5C", VA = "0x1789E5C")]
		public void MergeOverlappingDistinctMaterialTexturesAndCalcMaterialSubrects(List<MB_TexSet> distinctMaterialTextures)
		{
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0x178AED8", Offset = "0x178AED8", VA = "0x178AED8")]
		public void DoIntegrityCheckMergedEncapsulatingSamplingRects(List<MB_TexSet> distinctMaterialTextures)
		{
		}
	}
	[Token(Token = "0x2000079")]
	public class MB3_TextureCombinerNonTextureProperties
	{
		[Token(Token = "0x2000116")]
		public interface MaterialProperty
		{
			[Token(Token = "0x1700010E")]
			string PropertyName
			{
				[Token(Token = "0x60008BA")]
				get;
				[Token(Token = "0x60008BB")]
				set;
			}

			[Token(Token = "0x60008BC")]
			MaterialPropertyValueAveraged GetAverageCalculator();

			[Token(Token = "0x60008BD")]
			object GetDefaultValue();
		}

		[Token(Token = "0x2000117")]
		public class MaterialPropertyFloat : MaterialProperty
		{
			[Token(Token = "0x4000520")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADED60", Offset = "0xADED60")]
			private string <PropertyName>k__BackingField;

			[Token(Token = "0x4000521")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MaterialPropertyValueAveragedFloat _averageCalc;

			[Token(Token = "0x4000522")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private float _defaultValue;

			[Token(Token = "0x1700010F")]
			public string PropertyName
			{
				[Token(Token = "0x60008BE")]
				[Address(RVA = "0x178C838", Offset = "0x178C838", VA = "0x178C838", Slot = "4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0FDC", Offset = "0xAE0FDC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008BF")]
				[Address(RVA = "0x178C840", Offset = "0x178C840", VA = "0x178C840", Slot = "5")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0FEC", Offset = "0xAE0FEC")]
				set
				{
				}
			}

			[Token(Token = "0x60008C0")]
			[Address(RVA = "0x178B824", Offset = "0x178B824", VA = "0x178B824")]
			public MaterialPropertyFloat(string name, float defValue)
			{
			}

			[Token(Token = "0x60008C1")]
			[Address(RVA = "0x178C850", Offset = "0x178C850", VA = "0x178C850", Slot = "6")]
			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			[Token(Token = "0x60008C2")]
			[Address(RVA = "0x178C858", Offset = "0x178C858", VA = "0x178C858", Slot = "7")]
			public object GetDefaultValue()
			{
				return null;
			}
		}

		[Token(Token = "0x2000118")]
		public class MaterialPropertyColor : MaterialProperty
		{
			[Token(Token = "0x4000523")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADED70", Offset = "0xADED70")]
			private string <PropertyName>k__BackingField;

			[Token(Token = "0x4000524")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private MaterialPropertyValueAveragedColor _averageCalc;

			[Token(Token = "0x4000525")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private UnityEngine.Color _defaultValue;

			[Token(Token = "0x17000110")]
			public string PropertyName
			{
				[Token(Token = "0x60008C3")]
				[Address(RVA = "0x178C7B4", Offset = "0x178C7B4", VA = "0x178C7B4", Slot = "4")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0FFC", Offset = "0xAE0FFC")]
				get
				{
					return null;
				}
				[Token(Token = "0x60008C4")]
				[Address(RVA = "0x178C7BC", Offset = "0x178C7BC", VA = "0x178C7BC", Slot = "5")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE100C", Offset = "0xAE100C")]
				set
				{
				}
			}

			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x178B784", Offset = "0x178B784", VA = "0x178B784")]
			public MaterialPropertyColor(string name, UnityEngine.Color defaultVal)
			{
			}

			[Token(Token = "0x60008C6")]
			[Address(RVA = "0x178C7CC", Offset = "0x178C7CC", VA = "0x178C7CC", Slot = "6")]
			public MaterialPropertyValueAveraged GetAverageCalculator()
			{
				return null;
			}

			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x178C7D4", Offset = "0x178C7D4", VA = "0x178C7D4", Slot = "7")]
			public object GetDefaultValue()
			{
				return null;
			}
		}

		[Token(Token = "0x2000119")]
		public interface MaterialPropertyValueAveraged
		{
			[Token(Token = "0x60008C8")]
			void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property);

			[Token(Token = "0x60008C9")]
			object GetAverage();

			[Token(Token = "0x60008CA")]
			int NumValues();

			[Token(Token = "0x60008CB")]
			void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property);
		}

		[Token(Token = "0x200011A")]
		public class MaterialPropertyValueAveragedFloat : MaterialPropertyValueAveraged
		{
			[Token(Token = "0x4000526")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float averageVal;

			[Token(Token = "0x4000527")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int numValues;

			[Token(Token = "0x60008CC")]
			[Address(RVA = "0x178CD50", Offset = "0x178CD50", VA = "0x178CD50", Slot = "4")]
			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x178CEC4", Offset = "0x178CEC4", VA = "0x178CEC4", Slot = "5")]
			public object GetAverage()
			{
				return null;
			}

			[Token(Token = "0x60008CE")]
			[Address(RVA = "0x178CF28", Offset = "0x178CF28", VA = "0x178CF28", Slot = "6")]
			public int NumValues()
			{
				return default(int);
			}

			[Token(Token = "0x60008CF")]
			[Address(RVA = "0x178CF30", Offset = "0x178CF30", VA = "0x178CF30", Slot = "7")]
			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x60008D0")]
			[Address(RVA = "0x178C848", Offset = "0x178C848", VA = "0x178C848")]
			public MaterialPropertyValueAveragedFloat()
			{
			}
		}

		[Token(Token = "0x200011B")]
		public class MaterialPropertyValueAveragedColor : MaterialPropertyValueAveraged
		{
			[Token(Token = "0x4000528")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Color averageVal;

			[Token(Token = "0x4000529")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int numValues;

			[Token(Token = "0x60008D1")]
			[Address(RVA = "0x178C8BC", Offset = "0x178C8BC", VA = "0x178C8BC", Slot = "4")]
			public void TryGetPropValueFromMaterialAndBlendIntoAverage(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x60008D2")]
			[Address(RVA = "0x178CAD0", Offset = "0x178CAD0", VA = "0x178CAD0", Slot = "5")]
			public object GetAverage()
			{
				return null;
			}

			[Token(Token = "0x60008D3")]
			[Address(RVA = "0x178CB34", Offset = "0x178CB34", VA = "0x178CB34", Slot = "6")]
			public int NumValues()
			{
				return default(int);
			}

			[Token(Token = "0x60008D4")]
			[Address(RVA = "0x178CB3C", Offset = "0x178CB3C", VA = "0x178CB3C", Slot = "7")]
			public void SetAverageValueOrDefaultOnMaterial(Material mat, MaterialProperty property)
			{
			}

			[Token(Token = "0x60008D5")]
			[Address(RVA = "0x178C7C4", Offset = "0x178C7C4", VA = "0x178C7C4")]
			public MaterialPropertyValueAveragedColor()
			{
			}
		}

		[Token(Token = "0x200011C")]
		public struct TexPropertyNameColorPair
		{
			[Token(Token = "0x400052A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string name;

			[Token(Token = "0x400052B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public UnityEngine.Color color;

			[Token(Token = "0x60008D6")]
			[Address(RVA = "0x178B774", Offset = "0x178B774", VA = "0x178B774")]
			public TexPropertyNameColorPair(string nm, UnityEngine.Color col)
			{
			}
		}

		[Token(Token = "0x200011D")]
		private interface NonTextureProperties
		{
			[Token(Token = "0x60008D7")]
			bool NonTexturePropertiesAreEqual(Material a, Material b);

			[Token(Token = "0x60008D8")]
			Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName);

			[Token(Token = "0x60008D9")]
			void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods);

			[Token(Token = "0x60008DA")]
			UnityEngine.Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty);

			[Token(Token = "0x60008DB")]
			UnityEngine.Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty);
		}

		[Token(Token = "0x200011E")]
		private class NonTexturePropertiesDontBlendProps : NonTextureProperties
		{
			[Token(Token = "0x400052C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			[Token(Token = "0x60008DC")]
			[Address(RVA = "0x178B8AC", Offset = "0x178B8AC", VA = "0x178B8AC")]
			public NonTexturePropertiesDontBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties)
			{
			}

			[Token(Token = "0x60008DD")]
			[Address(RVA = "0x178DA20", Offset = "0x178DA20", VA = "0x178DA20", Slot = "4")]
			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default(bool);
			}

			[Token(Token = "0x60008DE")]
			[Address(RVA = "0x178DA28", Offset = "0x178DA28", VA = "0x178DA28", Slot = "5")]
			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			[Token(Token = "0x60008DF")]
			[Address(RVA = "0x178DAA0", Offset = "0x178DAA0", VA = "0x178DAA0", Slot = "6")]
			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
			{
			}

			[Token(Token = "0x60008E0")]
			[Address(RVA = "0x178DD6C", Offset = "0x178DD6C", VA = "0x178DD6C", Slot = "8")]
			public UnityEngine.Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60008E1")]
			[Address(RVA = "0x178DD74", Offset = "0x178DD74", VA = "0x178DD74", Slot = "7")]
			public UnityEngine.Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(UnityEngine.Color);
			}
		}

		[Token(Token = "0x200011F")]
		private class NonTexturePropertiesBlendProps : NonTextureProperties
		{
			[Token(Token = "0x400052D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private MB3_TextureCombinerNonTextureProperties _textureProperties;

			[Token(Token = "0x400052E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private TextureBlender resultMaterialTextureBlender;

			[Token(Token = "0x60008E2")]
			[Address(RVA = "0x178C298", Offset = "0x178C298", VA = "0x178C298")]
			public NonTexturePropertiesBlendProps(MB3_TextureCombinerNonTextureProperties textureProperties, TextureBlender resultMats)
			{
			}

			[Token(Token = "0x60008E3")]
			[Address(RVA = "0x178D13C", Offset = "0x178D13C", VA = "0x178D13C", Slot = "4")]
			public bool NonTexturePropertiesAreEqual(Material a, Material b)
			{
				return default(bool);
			}

			[Token(Token = "0x60008E4")]
			[Address(RVA = "0x178D208", Offset = "0x178D208", VA = "0x178D208", Slot = "5")]
			public Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
			{
				return null;
			}

			[Token(Token = "0x60008E5")]
			[Address(RVA = "0x178D5B4", Offset = "0x178D5B4", VA = "0x178D5B4", Slot = "6")]
			public void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
			{
			}

			[Token(Token = "0x60008E6")]
			[Address(RVA = "0x178D7C4", Offset = "0x178D7C4", VA = "0x178D7C4", Slot = "8")]
			public UnityEngine.Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60008E7")]
			[Address(RVA = "0x178D954", Offset = "0x178D954", VA = "0x178D954", Slot = "7")]
			public UnityEngine.Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
			{
				return default(UnityEngine.Color);
			}
		}

		[Token(Token = "0x40002E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static UnityEngine.Color NEUTRAL_NORMAL_MAP_COLOR;

		[Token(Token = "0x40002E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private TexPropertyNameColorPair[] defaultTextureProperty2DefaultColorMap;

		[Token(Token = "0x40002E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private MaterialProperty[] _nonTextureProperties;

		[Token(Token = "0x40002EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private MB2_LogLevel LOG_LEVEL;

		[Token(Token = "0x40002EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private bool _considerNonTextureProperties;

		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextureBlender resultMaterialTextureBlender;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextureBlender[] textureBlenders;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<string, UnityEngine.Color> textureProperty2DefaultColorMap;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private NonTextureProperties _nonTexturePropertiesBlender;

		[Token(Token = "0x600043A")]
		[Address(RVA = "0x1785468", Offset = "0x1785468", VA = "0x1785468")]
		public MB3_TextureCombinerNonTextureProperties(MB2_LogLevel ll, bool considerNonTextureProps)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0x178B8D8", Offset = "0x178B8D8", VA = "0x178B8D8")]
		internal void CollectAverageValuesOfNonTextureProperties(Material resultMaterial, Material mat)
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0x1788C80", Offset = "0x1788C80", VA = "0x1788C80")]
		internal void LoadTextureBlendersIfNeeded(Material resultMaterial)
		{
		}

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x178C110", Offset = "0x178C110", VA = "0x178C110")]
		private static bool InterfaceFilter(Type typeObj, object criteriaObj)
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0x178BFAC", Offset = "0x178BFAC", VA = "0x178BFAC")]
		private void FindBestTextureBlender(Material resultMaterial)
		{
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x178BAD8", Offset = "0x178BAD8", VA = "0x178BAD8")]
		private void LoadTextureBlenders()
		{
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x178C2D0", Offset = "0x178C2D0", VA = "0x178C2D0")]
		internal bool NonTexturePropertiesAreEqual(Material a, Material b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x178C398", Offset = "0x178C398", VA = "0x178C398")]
		internal Texture2D TintTextureWithTextureCombiner(Texture2D t, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName)
		{
			return null;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x178C474", Offset = "0x178C474", VA = "0x178C474")]
		internal void AdjustNonTextureProperties(Material resultMat, List<ShaderTextureProperty> texPropertyNames, List<MB_TexSet> distinctMaterialTextures, MB2_EditorMethodsInterface editorMethods)
		{
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x178C5A4", Offset = "0x178C5A4", VA = "0x178C5A4")]
		internal UnityEngine.Color GetColorAsItWouldAppearInAtlasIfNoTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x178C670", Offset = "0x178C670", VA = "0x178C670")]
		internal UnityEngine.Color GetColorForTemporaryTexture(Material matIfBlender, ShaderTextureProperty texProperty)
		{
			return default(UnityEngine.Color);
		}

		[Token(Token = "0x6000445")]
		[Address(RVA = "0x178C164", Offset = "0x178C164", VA = "0x178C164")]
		private TextureBlender FindMatchingTextureBlender(string shaderName)
		{
			return null;
		}
	}
	[Token(Token = "0x200007A")]
	internal class MB3_TextureCombinerPackerMeshBaker : MB3_TextureCombinerPackerRoot
	{
		[Token(Token = "0x2000120")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD824", Offset = "0xADD824")]
		private sealed class <CreateAtlases>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400052F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000530")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000531")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x4000532")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x4000535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Texture2D[] atlases;

			[Token(Token = "0x4000538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private Rect[] <uvRects>5__2;

			[Token(Token = "0x4000539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			private int <atlasSizeX>5__3;

			[Token(Token = "0x400053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
			private int <atlasSizeY>5__4;

			[Token(Token = "0x400053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private int <propIdx>5__5;

			[Token(Token = "0x400053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private ShaderTextureProperty <property>5__6;

			[Token(Token = "0x400053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private UnityEngine.Color[][] <atlasPixels>5__7;

			[Token(Token = "0x400053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private bool <isNormalMap>5__8;

			[Token(Token = "0x400053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			private int <texSetIdx>5__9;

			[Token(Token = "0x17000111")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008EB")]
				[Address(RVA = "0x178FD34", Offset = "0x178FD34", VA = "0x178FD34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000112")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008ED")]
				[Address(RVA = "0x178FD9C", Offset = "0x178FD9C", VA = "0x178FD9C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008E8")]
			[Address(RVA = "0x178DF54", Offset = "0x178DF54", VA = "0x178DF54")]
			[DebuggerHidden]
			public <CreateAtlases>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60008E9")]
			[Address(RVA = "0x178EAE8", Offset = "0x178EAE8", VA = "0x178EAE8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008EA")]
			[Address(RVA = "0x178EAEC", Offset = "0x178EAEC", VA = "0x178EAEC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008EC")]
			[Address(RVA = "0x178FD3C", Offset = "0x178FD3C", VA = "0x178FD3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000121")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD834", Offset = "0xADD834")]
		private sealed class <CopyScaledAndTiledToAtlas>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MeshBakerMaterialTexture source;

			[Token(Token = "0x4000543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public int targX;

			[Token(Token = "0x4000545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int targY;

			[Token(Token = "0x4000546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int targW;

			[Token(Token = "0x4000547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int targH;

			[Token(Token = "0x4000548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public AtlasPadding padding;

			[Token(Token = "0x4000549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public DRect srcSamplingRect;

			[Token(Token = "0x400054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x400054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x400054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public ShaderTextureProperty shaderPropertyName;

			[Token(Token = "0x400054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public MB_TexSet sourceMaterial;

			[Token(Token = "0x400054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
			public UnityEngine.Color[][] atlasPixels;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
			private int <w>5__2;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
			private int <h>5__3;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
			private int <i>5__4;

			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
			private int <j>5__5;

			[Token(Token = "0x17000113")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F1")]
				[Address(RVA = "0x178EA78", Offset = "0x178EA78", VA = "0x178EA78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F3")]
				[Address(RVA = "0x178EAE0", Offset = "0x178EAE0", VA = "0x178EAE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008EE")]
			[Address(RVA = "0x178E080", Offset = "0x178E080", VA = "0x178E080")]
			[DebuggerHidden]
			public <CopyScaledAndTiledToAtlas>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60008EF")]
			[Address(RVA = "0x178E0BC", Offset = "0x178E0BC", VA = "0x178E0BC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F0")]
			[Address(RVA = "0x178E0C0", Offset = "0x178E0C0", VA = "0x178E0C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F2")]
			[Address(RVA = "0x178EA80", Offset = "0x178EA80", VA = "0x178EA80", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0x178DEA4", Offset = "0x178DEA4", VA = "0x178DEA4", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFC8C", Offset = "0xADFC8C")]
		public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0x178DF80", Offset = "0x178DF80", VA = "0x178DF80")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFCF0", Offset = "0xADFCF0")]
		internal static IEnumerator CopyScaledAndTiledToAtlas(MeshBakerMaterialTexture source, MB_TexSet sourceMaterial, ShaderTextureProperty shaderPropertyName, DRect srcSamplingRect, int targX, int targY, int targW, int targH, AtlasPadding padding, UnityEngine.Color[][] atlasPixels, bool isNormalMap, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, [Optional] ProgressUpdateDelegate progressInfo, MB2_LogLevel LOG_LEVEL = MB2_LogLevel.info)
		{
			return null;
		}

		[Token(Token = "0x6000449")]
		[Address(RVA = "0x178E0AC", Offset = "0x178E0AC", VA = "0x178E0AC")]
		public MB3_TextureCombinerPackerMeshBaker()
		{
		}
	}
	[Token(Token = "0x200007B")]
	internal class MB3_TextureCombinerPackerMeshBakerFast : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD844", Offset = "0xADD844")]
		private sealed class <ConvertTexturesToReadableFormats>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000115")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008F7")]
				[Address(RVA = "0x1790174", Offset = "0x1790174", VA = "0x1790174", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008F9")]
				[Address(RVA = "0x17901DC", Offset = "0x17901DC", VA = "0x17901DC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008F4")]
			[Address(RVA = "0x178FE04", Offset = "0x178FE04", VA = "0x178FE04")]
			[DebuggerHidden]
			public <ConvertTexturesToReadableFormats>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x60008F5")]
			[Address(RVA = "0x1790158", Offset = "0x1790158", VA = "0x1790158", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008F6")]
			[Address(RVA = "0x179015C", Offset = "0x179015C", VA = "0x179015C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008F8")]
			[Address(RVA = "0x179017C", Offset = "0x179017C", VA = "0x179017C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD854", Offset = "0xADD854")]
		private sealed class <CreateAtlases>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Texture2D[] atlases;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x17000117")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60008FD")]
				[Address(RVA = "0x179130C", Offset = "0x179130C", VA = "0x179130C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000118")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60008FF")]
				[Address(RVA = "0x1791374", Offset = "0x1791374", VA = "0x1791374", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60008FA")]
			[Address(RVA = "0x1790124", Offset = "0x1790124", VA = "0x1790124")]
			[DebuggerHidden]
			public <CreateAtlases>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x17901E4", Offset = "0x17901E4", VA = "0x17901E4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60008FC")]
			[Address(RVA = "0x17901E8", Offset = "0x17901E8", VA = "0x17901E8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x1791314", Offset = "0x1791314", VA = "0x1791314", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0x178FDA4", Offset = "0x178FDA4", VA = "0x178FDA4", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFD54", Offset = "0xADFD54")]
		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x178FE30", Offset = "0x178FE30", VA = "0x178FE30", Slot = "7")]
		public virtual AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1790074", Offset = "0x1790074", VA = "0x1790074", Slot = "6")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFDB8", Offset = "0xADFDB8")]
		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1790150", Offset = "0x1790150", VA = "0x1790150")]
		public MB3_TextureCombinerPackerMeshBakerFast()
		{
		}
	}
	[Token(Token = "0x200007C")]
	internal class MB3_TextureCombinerPackerMeshBakerHorizontalVertical : MB3_TextureCombinerPackerMeshBaker
	{
		[Token(Token = "0x2000124")]
		private interface IPipeline
		{
			[Token(Token = "0x6000900")]
			MB2_PackingAlgorithmEnum GetPackingAlg();

			[Token(Token = "0x6000901")]
			void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight);

			[Token(Token = "0x6000902")]
			MB_TextureTilingTreatment GetEdge2EdgeTreatment();

			[Token(Token = "0x6000903")]
			void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue);

			[Token(Token = "0x6000904")]
			void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY);

			[Token(Token = "0x6000905")]
			void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight);
		}

		[Token(Token = "0x2000125")]
		private class VerticalPipeline : IPipeline
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x1792AE4", Offset = "0x1792AE4", VA = "0x1792AE4", Slot = "4")]
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default(MB2_PackingAlgorithmEnum);
			}

			[Token(Token = "0x6000907")]
			[Address(RVA = "0x1792AEC", Offset = "0x1792AEC", VA = "0x1792AEC", Slot = "5")]
			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			[Token(Token = "0x6000908")]
			[Address(RVA = "0x1792BBC", Offset = "0x1792BBC", VA = "0x1792BBC", Slot = "6")]
			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default(MB_TextureTilingTreatment);
			}

			[Token(Token = "0x6000909")]
			[Address(RVA = "0x1792BC4", Offset = "0x1792BC4", VA = "0x1792BC4", Slot = "7")]
			public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
			{
			}

			[Token(Token = "0x600090A")]
			[Address(RVA = "0x1792BCC", Offset = "0x1792BCC", VA = "0x1792BCC", Slot = "8")]
			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
			{
			}

			[Token(Token = "0x600090B")]
			[Address(RVA = "0x1792E00", Offset = "0x1792E00", VA = "0x1792E00", Slot = "9")]
			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
			{
			}

			[Token(Token = "0x600090C")]
			[Address(RVA = "0x17920E8", Offset = "0x17920E8", VA = "0x17920E8")]
			public VerticalPipeline()
			{
			}
		}

		[Token(Token = "0x2000126")]
		private class HorizontalPipeline : IPipeline
		{
			[Token(Token = "0x600090D")]
			[Address(RVA = "0x17927BC", Offset = "0x17927BC", VA = "0x17927BC", Slot = "4")]
			public MB2_PackingAlgorithmEnum GetPackingAlg()
			{
				return default(MB2_PackingAlgorithmEnum);
			}

			[Token(Token = "0x600090E")]
			[Address(RVA = "0x17927C4", Offset = "0x17927C4", VA = "0x17927C4", Slot = "5")]
			public void SortTexSetIntoBins(MB_TexSet texSet, List<MB_TexSet> horizontalVert, List<MB_TexSet> regular, int maxAtlasWidth, int maxAtlasHeight)
			{
			}

			[Token(Token = "0x600090F")]
			[Address(RVA = "0x1792894", Offset = "0x1792894", VA = "0x1792894", Slot = "6")]
			public MB_TextureTilingTreatment GetEdge2EdgeTreatment()
			{
				return default(MB_TextureTilingTreatment);
			}

			[Token(Token = "0x6000910")]
			[Address(RVA = "0x179289C", Offset = "0x179289C", VA = "0x179289C", Slot = "7")]
			public void InitializeAtlasPadding(ref AtlasPadding padding, int paddingValue)
			{
			}

			[Token(Token = "0x6000911")]
			[Address(RVA = "0x17928A4", Offset = "0x17928A4", VA = "0x17928A4", Slot = "8")]
			public void MergeAtlasPackingResultStackBonAInternal(AtlasPackingResult a, AtlasPackingResult b, out Rect AatlasToFinal, out Rect BatlasToFinal, bool stretchBToAtlasWidth, int maxWidthDim, int maxHeightDim, out int atlasX, out int atlasY)
			{
			}

			[Token(Token = "0x6000912")]
			[Address(RVA = "0x1792AD4", Offset = "0x1792AD4", VA = "0x1792AD4", Slot = "9")]
			public void GetExtraRoomForRegularAtlas(int usedHorizontalVertWidth, int usedHorizontalVertHeight, int maxAtlasWidth, int maxAtlasHeight, out int atlasRegularMaxWidth, out int atlasRegularMaxHeight)
			{
			}

			[Token(Token = "0x6000913")]
			[Address(RVA = "0x17920E0", Offset = "0x17920E0", VA = "0x17920E0")]
			public HorizontalPipeline()
			{
			}
		}

		[Token(Token = "0x2000127")]
		public enum AtlasDirection
		{
			[Token(Token = "0x4000560")]
			horizontal,
			[Token(Token = "0x4000561")]
			vertical
		}

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AtlasDirection _atlasDirection;

		[Token(Token = "0x600044E")]
		[Address(RVA = "0x179137C", Offset = "0x179137C", VA = "0x179137C")]
		public MB3_TextureCombinerPackerMeshBakerHorizontalVertical(AtlasDirection ad)
		{
		}

		[Token(Token = "0x600044F")]
		[Address(RVA = "0x17913A8", Offset = "0x17913A8", VA = "0x17913A8", Slot = "8")]
		public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0x1792694", Offset = "0x1792694", VA = "0x1792694")]
		public static AtlasPackingResult TestStackRectanglesHorizontal(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x1792728", Offset = "0x1792728", VA = "0x1792728")]
		public static AtlasPackingResult TestStackRectanglesVertical(AtlasPackingResult a, AtlasPackingResult b, int maxHeightDim, int maxWidthDim, bool stretchBToAtlasWidth)
		{
			return null;
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x17920F0", Offset = "0x17920F0", VA = "0x17920F0")]
		private static AtlasPackingResult MergeAtlasPackingResultStackBonA(AtlasPackingResult a, AtlasPackingResult b, int maxWidthDim, int maxHeightDim, bool stretchBToAtlasWidth, IPipeline pipeline)
		{
			return null;
		}
	}
	[Token(Token = "0x200007D")]
	internal class MB3_TextureCombinerPackerOneTextureInAtlas : MB_ITextureCombinerPacker
	{
		[Token(Token = "0x2000128")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD864", Offset = "0xADD864")]
		private sealed class <ConvertTexturesToReadableFormats>d__0 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x17000119")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000917")]
				[Address(RVA = "0x17932B0", Offset = "0x17932B0", VA = "0x17932B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000919")]
				[Address(RVA = "0x1793318", Offset = "0x1793318", VA = "0x1793318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000914")]
			[Address(RVA = "0x1792E70", Offset = "0x1792E70", VA = "0x1792E70")]
			[DebuggerHidden]
			public <ConvertTexturesToReadableFormats>d__0(int <>1__state)
			{
			}

			[Token(Token = "0x6000915")]
			[Address(RVA = "0x1793294", Offset = "0x1793294", VA = "0x1793294", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000916")]
			[Address(RVA = "0x1793298", Offset = "0x1793298", VA = "0x1793298", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000918")]
			[Address(RVA = "0x17932B8", Offset = "0x17932B8", VA = "0x17932B8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000129")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD874", Offset = "0xADD874")]
		private sealed class <CreateAtlases>d__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000564")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000565")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000566")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000567")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x4000568")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Texture2D[] atlases;

			[Token(Token = "0x1700011B")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600091D")]
				[Address(RVA = "0x17935BC", Offset = "0x17935BC", VA = "0x17935BC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011C")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600091F")]
				[Address(RVA = "0x1793624", Offset = "0x1793624", VA = "0x1793624", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600091A")]
			[Address(RVA = "0x1793260", Offset = "0x1793260", VA = "0x1793260")]
			[DebuggerHidden]
			public <CreateAtlases>d__2(int <>1__state)
			{
			}

			[Token(Token = "0x600091B")]
			[Address(RVA = "0x1793320", Offset = "0x1793320", VA = "0x1793320", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600091C")]
			[Address(RVA = "0x1793324", Offset = "0x1793324", VA = "0x1793324", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600091E")]
			[Address(RVA = "0x17935C4", Offset = "0x17935C4", VA = "0x17935C4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x1792E10", Offset = "0x1792E10", VA = "0x1792E10", Slot = "4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFE1C", Offset = "0xADFE1C")]
		public IEnumerator ConvertTexturesToReadableFormats(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x1792E9C", Offset = "0x1792E9C", VA = "0x1792E9C", Slot = "5")]
		public AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000455")]
		[Address(RVA = "0x17931DC", Offset = "0x17931DC", VA = "0x17931DC", Slot = "6")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFE80", Offset = "0xADFE80")]
		public IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0x179328C", Offset = "0x179328C", VA = "0x179328C")]
		public MB3_TextureCombinerPackerOneTextureInAtlas()
		{
		}
	}
	[Token(Token = "0x200007E")]
	internal class MB3_TextureCombinerPackerUnity : MB3_TextureCombinerPackerRoot
	{
		[Token(Token = "0x200012A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD884", Offset = "0xADD884")]
		private sealed class <CreateAtlases>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000569")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400056A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400056B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AtlasPackingResult packedAtlasRects;

			[Token(Token = "0x400056C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB3_TextureCombinerPipeline.TexturePipelineData data;

			[Token(Token = "0x400056D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Texture2D[] atlases;

			[Token(Token = "0x1700011D")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000923")]
				[Address(RVA = "0x1A9BA10", Offset = "0x1A9BA10", VA = "0x1A9BA10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700011E")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000925")]
				[Address(RVA = "0x1A9BA78", Offset = "0x1A9BA78", VA = "0x1A9BA78", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000920")]
			[Address(RVA = "0x1A99620", Offset = "0x1A99620", VA = "0x1A99620")]
			[DebuggerHidden]
			public <CreateAtlases>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1A9A534", Offset = "0x1A9A534", VA = "0x1A9A534", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1A9A538", Offset = "0x1A9A538", VA = "0x1A9A538", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000924")]
			[Address(RVA = "0x1A9BA18", Offset = "0x1A9BA18", VA = "0x1A9BA18", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x6000457")]
		[Address(RVA = "0x1A99490", Offset = "0x1A99490", VA = "0x1A99490", Slot = "8")]
		public override AtlasPackingResult[] CalculateAtlasRectangles(MB3_TextureCombinerPipeline.TexturePipelineData data, bool doMultiAtlas, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0x1A99574", Offset = "0x1A99574", VA = "0x1A99574", Slot = "9")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFEE4", Offset = "0xADFEE4")]
		public override IEnumerator CreateAtlases(ProgressUpdateDelegate progressInfo, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, AtlasPackingResult packedAtlasRects, Texture2D[] atlases, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0x1A9964C", Offset = "0x1A9964C", VA = "0x1A9964C")]
		internal static Texture2D _copyTexturesIntoAtlas(Texture2D[] texToPack, int padding, Rect[] rs, int w, int h, MB3_TextureCombiner combiner)
		{
			return null;
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0x1A99C40", Offset = "0x1A99C40", VA = "0x1A99C40")]
		internal static Texture2D GetAdjustedForScaleAndOffset2(string propertyName, MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, MB3_TextureCombinerPipeline.TexturePipelineData data, MB3_TextureCombiner combiner, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x1A9A52C", Offset = "0x1A9A52C", VA = "0x1A9A52C")]
		public MB3_TextureCombinerPackerUnity()
		{
		}
	}
	[Token(Token = "0x200007F")]
	public class MB3_TextureCombinerPipeline
	{
		[Token(Token = "0x200012B")]
		public struct CreateAtlasForProperty
		{
			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool allTexturesAreNull;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool allTexturesAreSame;

			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
			public bool allNonTexturePropsAreSame;

			[Token(Token = "0x6000926")]
			[Address(RVA = "0x1AA34E8", Offset = "0x1AA34E8", VA = "0x1AA34E8", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Token(Token = "0x200012C")]
		internal class TexturePipelineData
		{
			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			internal MB2_TextureBakeResults _textureBakeResults;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			internal int _atlasPadding;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			internal int _maxAtlasWidth;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			internal int _maxAtlasHeight;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			internal bool _useMaxAtlasHeightOverride;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
			internal bool _useMaxAtlasWidthOverride;

			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
			internal bool _resizePowerOfTwoTextures;

			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x27")]
			internal bool _fixOutOfBoundsUVs;

			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			internal int _maxTilingBakeSize;

			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			internal bool _saveAtlasesAsAssets;

			[Token(Token = "0x400057F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			internal MB2_PackingAlgorithmEnum _packingAlgorithm;

			[Token(Token = "0x4000580")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			internal bool _meshBakerTexturePackerForcePowerOfTwo;

			[Token(Token = "0x4000581")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			internal List<ShaderTextureProperty> _customShaderPropNames;

			[Token(Token = "0x4000582")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			internal bool _normalizeTexelDensity;

			[Token(Token = "0x4000583")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
			internal bool _considerNonTextureProperties;

			[Token(Token = "0x4000584")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			internal MB3_TextureCombinerNonTextureProperties nonTexturePropertyBlender;

			[Token(Token = "0x4000585")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			internal List<MB_TexSet> distinctMaterialTextures;

			[Token(Token = "0x4000586")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			internal List<GameObject> allObjsToMesh;

			[Token(Token = "0x4000587")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			internal List<Material> allowedMaterialsFilter;

			[Token(Token = "0x4000588")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			internal List<ShaderTextureProperty> texPropertyNames;

			[Token(Token = "0x4000589")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			internal CreateAtlasForProperty[] allTexturesAreNullAndSameColor;

			[Token(Token = "0x400058A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			internal Material resultMaterial;

			[Token(Token = "0x1700011F")]
			internal int numAtlases
			{
				[Token(Token = "0x6000927")]
				[Address(RVA = "0x1A9B9BC", Offset = "0x1A9B9BC", VA = "0x1A9B9BC")]
				get
				{
					return default(int);
				}
			}

			[Token(Token = "0x6000928")]
			[Address(RVA = "0x1AA35A8", Offset = "0x1AA35A8", VA = "0x1AA35A8")]
			internal bool OnlyOneTextureInAtlasReuseTextures()
			{
				return default(bool);
			}

			[Token(Token = "0x6000929")]
			[Address(RVA = "0x1AA3630", Offset = "0x1AA3630", VA = "0x1AA3630")]
			public TexturePipelineData()
			{
			}
		}

		[Token(Token = "0x200012D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD894", Offset = "0xADD894")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400058B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TexturePipelineData data;

			[Token(Token = "0x600092A")]
			[Address(RVA = "0x1A9C320", Offset = "0x1A9C320", VA = "0x1A9C320")]
			public <>c__DisplayClass5_0()
			{
			}
		}

		[Token(Token = "0x200012E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8A4", Offset = "0xADD8A4")]
		private sealed class <>c__DisplayClass5_1
		{
			[Token(Token = "0x400058C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int i;

			[Token(Token = "0x400058D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass5_0 CS$<>8__locals1;

			[Token(Token = "0x600092B")]
			[Address(RVA = "0x1A9C328", Offset = "0x1A9C328", VA = "0x1A9C328")]
			public <>c__DisplayClass5_1()
			{
			}

			[Token(Token = "0x600092C")]
			[Address(RVA = "0x1A9E934", Offset = "0x1A9E934", VA = "0x1A9E934")]
			internal bool <_CollectPropertyNames>b__0(ShaderTextureProperty x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200012F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8B4", Offset = "0xADD8B4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400058E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public TexturePipelineData data;

			[Token(Token = "0x600092D")]
			[Address(RVA = "0x1A9E9DC", Offset = "0x1A9E9DC", VA = "0x1A9E9DC")]
			public <>c__DisplayClass8_0()
			{
			}
		}

		[Token(Token = "0x2000130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8C4", Offset = "0xADD8C4")]
		private sealed class <>c__DisplayClass8_1
		{
			[Token(Token = "0x400058F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public MB_TexSet setOfTexs;

			[Token(Token = "0x4000590")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public <>c__DisplayClass8_0 CS$<>8__locals1;

			[Token(Token = "0x600092E")]
			[Address(RVA = "0x1A9E9E4", Offset = "0x1A9E9E4", VA = "0x1A9E9E4")]
			public <>c__DisplayClass8_1()
			{
			}

			[Token(Token = "0x600092F")]
			[Address(RVA = "0x1A9E9EC", Offset = "0x1A9E9EC", VA = "0x1A9E9EC")]
			internal bool <__Step1_CollectDistinctMatTexturesAndUsedObjects>b__0(MB_TexSet x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000131")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8D4", Offset = "0xADD8D4")]
		private sealed class <__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000591")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000592")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000593")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x4000594")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x4000595")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x4000596")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result;

			[Token(Token = "0x4000597")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x4000598")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public List<GameObject> usedObjsToMesh;

			[Token(Token = "0x17000120")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000933")]
				[Address(RVA = "0x1AA24D4", Offset = "0x1AA24D4", VA = "0x1AA24D4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000121")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000935")]
				[Address(RVA = "0x1AA253C", Offset = "0x1AA253C", VA = "0x1AA253C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000930")]
			[Address(RVA = "0x1A9C558", Offset = "0x1A9C558", VA = "0x1A9C558")]
			[DebuggerHidden]
			public <__Step1_CollectDistinctMatTexturesAndUsedObjects>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0x1AA00AC", Offset = "0x1AA00AC", VA = "0x1AA00AC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0x1AA00B0", Offset = "0x1AA00B0", VA = "0x1AA00B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000934")]
			[Address(RVA = "0x1AA24DC", Offset = "0x1AA24DC", VA = "0x1AA24DC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000132")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8E4", Offset = "0xADD8E4")]
		private sealed class <CalculateIdealSizesForTexturesInAtlasAndPadding>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000599")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x400059C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x17000122")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000939")]
				[Address(RVA = "0x1AA003C", Offset = "0x1AA003C", VA = "0x1AA003C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000123")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093B")]
				[Address(RVA = "0x1AA00A4", Offset = "0x1AA00A4", VA = "0x1AA00A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000936")]
			[Address(RVA = "0x1A9CC18", Offset = "0x1A9CC18", VA = "0x1A9CC18")]
			[DebuggerHidden]
			public <CalculateIdealSizesForTexturesInAtlasAndPadding>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000937")]
			[Address(RVA = "0x1A9EC78", Offset = "0x1A9EC78", VA = "0x1A9EC78", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000938")]
			[Address(RVA = "0x1A9EC7C", Offset = "0x1A9EC7C", VA = "0x1A9EC7C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0x1AA0044", Offset = "0x1AA0044", VA = "0x1AA0044", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000133")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD8F4", Offset = "0xADD8F4")]
		private sealed class <__Step3_BuildAndSaveAtlasesAndStoreResults>d__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400059D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400059E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400059F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TexturePipelineData data;

			[Token(Token = "0x40005A0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public MB2_LogLevel LOG_LEVEL;

			[Token(Token = "0x40005A1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public MB_ITextureCombinerPacker packer;

			[Token(Token = "0x40005A2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public ProgressUpdateDelegate progressInfo;

			[Token(Token = "0x40005A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public MB3_TextureCombiner combiner;

			[Token(Token = "0x40005A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public AtlasPackingResult atlasPackingResult;

			[Token(Token = "0x40005A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public MB2_EditorMethodsInterface textureEditorMethods;

			[Token(Token = "0x40005A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public StringBuilder report;

			[Token(Token = "0x40005A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public MB_AtlasesAndRects resultAtlasesAndRects;

			[Token(Token = "0x40005A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			private Stopwatch <sw>5__2;

			[Token(Token = "0x40005A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Texture2D[] <atlases>5__3;

			[Token(Token = "0x17000124")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600093F")]
				[Address(RVA = "0x1AA3478", Offset = "0x1AA3478", VA = "0x1AA3478", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000125")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000941")]
				[Address(RVA = "0x1AA34E0", Offset = "0x1AA34E0", VA = "0x1AA34E0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600093C")]
			[Address(RVA = "0x1A9D088", Offset = "0x1A9D088", VA = "0x1A9D088")]
			[DebuggerHidden]
			public <__Step3_BuildAndSaveAtlasesAndStoreResults>d__13(int <>1__state)
			{
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0x1AA2544", Offset = "0x1AA2544", VA = "0x1AA2544", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600093E")]
			[Address(RVA = "0x1AA2548", Offset = "0x1AA2548", VA = "0x1AA2548", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000940")]
			[Address(RVA = "0x1AA3480", Offset = "0x1AA3480", VA = "0x1AA3480", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40002F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool USE_EXPERIMENTAL_HOIZONTALVERTICAL;

		[Token(Token = "0x40002F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static ShaderTextureProperty[] shaderTexPropertyNames;

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x1A9B554", Offset = "0x1A9B554", VA = "0x1A9B554")]
		internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, bool considerNonTextureProperties, CreateAtlasForProperty[] allTexturesAreNullAndSameColor)
		{
			return default(bool);
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x1A9BA80", Offset = "0x1A9BA80", VA = "0x1A9BA80")]
		internal static bool _CollectPropertyNames(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default(bool);
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x1A9C330", Offset = "0x1A9C330", VA = "0x1A9C330")]
		internal static bool _ShouldWeCreateAtlasForThisProperty(int propertyIndex, CreateAtlasForProperty[] allTexturesAreNullAndSameColor, TexturePipelineData data)
		{
			return default(bool);
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x1A9C3A0", Offset = "0x1A9C3A0", VA = "0x1A9C3A0")]
		public static Texture GetTextureConsideringStandardShaderKeywords(string shaderName, Material mat, string propertyName)
		{
			return null;
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x1A9C4B0", Offset = "0x1A9C4B0", VA = "0x1A9C4B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFF48", Offset = "0xADFF48")]
		internal static IEnumerator __Step1_CollectDistinctMatTexturesAndUsedObjects(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, List<GameObject> usedObjsToMesh, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000461")]
		[Address(RVA = "0x1A9C584", Offset = "0x1A9C584", VA = "0x1A9C584")]
		private static CreateAtlasForProperty[] CalculateAllTexturesAreNullAndSameColor(TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0x1A9CB98", Offset = "0x1A9CB98", VA = "0x1A9CB98")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xADFFAC", Offset = "0xADFFAC")]
		internal static IEnumerator CalculateIdealSizesForTexturesInAtlasAndPadding(ProgressUpdateDelegate progressInfo, MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, TexturePipelineData data, MB3_TextureCombiner combiner, MB2_EditorMethodsInterface textureEditorMethods, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x1A9CC44", Offset = "0x1A9CC44", VA = "0x1A9CC44")]
		internal static AtlasPackingResult[] __Step3_RunTexturePacker(TexturePipelineData data, MB_ITextureCombinerPacker texturePacker, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1A9CE3C", Offset = "0x1A9CE3C", VA = "0x1A9CE3C")]
		internal static MB_ITextureCombinerPacker CreatePacker(bool onlyOneTextureInAtlasReuseTextures, MB2_PackingAlgorithmEnum packingAlgorithm)
		{
			return null;
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1A9CFCC", Offset = "0x1A9CFCC", VA = "0x1A9CFCC")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAE0010", Offset = "0xAE0010")]
		internal static IEnumerator __Step3_BuildAndSaveAtlasesAndStoreResults(MB3_TextureCombiner.CombineTexturesIntoAtlasesCoroutineResult result, ProgressUpdateDelegate progressInfo, TexturePipelineData data, MB3_TextureCombiner combiner, MB_ITextureCombinerPacker packer, AtlasPackingResult atlasPackingResult, MB2_EditorMethodsInterface textureEditorMethods, MB_AtlasesAndRects resultAtlasesAndRects, StringBuilder report, MB2_LogLevel LOG_LEVEL)
		{
			return null;
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1A9D0B4", Offset = "0x1A9D0B4", VA = "0x1A9D0B4")]
		internal static StringBuilder GenerateReport(TexturePipelineData data)
		{
			return null;
		}

		[Token(Token = "0x6000467")]
		[Address(RVA = "0x1A9DD9C", Offset = "0x1A9DD9C", VA = "0x1A9DD9C")]
		internal static MB2_TexturePacker CreateTexturePacker(MB2_PackingAlgorithmEnum _packingAlgorithm)
		{
			return null;
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1A9A1B4", Offset = "0x1A9A1B4", VA = "0x1A9A1B4")]
		internal static Vector2 GetAdjustedForScaleAndOffset2Dimensions(MeshBakerMaterialTexture source, Vector2 obUVoffset, Vector2 obUVscale, TexturePipelineData data, MB2_LogLevel LOG_LEVEL)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000469")]
		[Address(RVA = "0x1A9DEB0", Offset = "0x1A9DEB0", VA = "0x1A9DEB0")]
		internal static Color32 ConvertNormalFormatFromUnity_ToStandard(Color32 c)
		{
			return default(Color32);
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0x1A9DFEC", Offset = "0x1A9DFEC", VA = "0x1A9DFEC")]
		internal static float GetSubmeshArea(Mesh m, int submeshIdx)
		{
			return default(float);
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0x1A9E238", Offset = "0x1A9E238", VA = "0x1A9E238")]
		internal static bool IsPowerOfTwo(int x)
		{
			return default(bool);
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0x1A9E248", Offset = "0x1A9E248", VA = "0x1A9E248")]
		public MB3_TextureCombinerPipeline()
		{
		}
	}
}
namespace UltimateFracturing
{
	[Token(Token = "0x2000080")]
	public static class ConcaveColliderInterface
	{
		[Token(Token = "0x2000134")]
		private struct SConvexDecompositionInfoInOut
		{
			[Token(Token = "0x40005AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public uint uMaxHullVertices;

			[Token(Token = "0x40005AB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint uMaxHulls;

			[Token(Token = "0x40005AC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float fPrecision;

			[Token(Token = "0x40005AD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float fBackFaceDistanceFactor;

			[Token(Token = "0x40005AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public uint uLegacyDepth;

			[Token(Token = "0x40005AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public uint uNormalizeInputMesh;

			[Token(Token = "0x40005B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public uint uUseFastVersion;

			[Token(Token = "0x40005B1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public uint uTriangleCount;

			[Token(Token = "0x40005B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public uint uVertexCount;

			[Token(Token = "0x40005B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public int nHullsOut;
		}

		[Token(Token = "0x2000135")]
		private struct SConvexDecompositionHullInfo
		{
			[Token(Token = "0x40005B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nVertexCount;

			[Token(Token = "0x40005B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int nTriangleCount;
		}

		[Token(Token = "0x2000136")]
		public delegate void LogDelegate(string message);

		[PreserveSig]
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x166D200", Offset = "0x166D200", VA = "0x166D200")]
		private static extern void DllInit(bool bUseMultithreading);

		[PreserveSig]
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x166D280", Offset = "0x166D280", VA = "0x166D280")]
		private static extern void DllClose();

		[PreserveSig]
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x166D2F0", Offset = "0x166D2F0", VA = "0x166D2F0")]
		private static extern void SetLogFunctionPointer(IntPtr pfnUnity3DLog);

		[PreserveSig]
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x166D370", Offset = "0x166D370", VA = "0x166D370")]
		private static extern void SetProgressFunctionPointer(IntPtr pfnUnity3DProgress);

		[PreserveSig]
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x166D3F0", Offset = "0x166D3F0", VA = "0x166D3F0")]
		private static extern void CancelConvexDecomposition();

		[PreserveSig]
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x166D460", Offset = "0x166D460", VA = "0x166D460")]
		private static extern bool DoConvexDecomposition(ref SConvexDecompositionInfoInOut infoInOut, Vector3[] pfVertices, int[] puIndices);

		[PreserveSig]
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x166D510", Offset = "0x166D510", VA = "0x166D510")]
		private static extern bool GetHullInfo(uint uHullIndex, ref SConvexDecompositionHullInfo infoOut);

		[PreserveSig]
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x166D5A8", Offset = "0x166D5A8", VA = "0x166D5A8")]
		private static extern bool FillHullMeshData(uint uHullIndex, ref float pfVolumeOut, int[] pnIndicesOut, Vector3[] pfVerticesOut);

		[Token(Token = "0x6000476")]
		[Address(RVA = "0x166D668", Offset = "0x166D668", VA = "0x166D668")]
		public static int ComputeHull(GameObject gameObject, FracturedObject fracturedObject)
		{
			return default(int);
		}

		[Token(Token = "0x6000477")]
		[Address(RVA = "0x166D804", Offset = "0x166D804", VA = "0x166D804")]
		private static bool ComputeHull(GameObject gameObject, bool isTrigger, FracturedObject.ECCAlgorithm eAlgorithm, int nMaxHulls, int nMaxHullVertices, int nLegacySteps, bool bVerbose, out int nTotalTrianglesOut)
		{
			return default(bool);
		}

		[Token(Token = "0x6000478")]
		[Address(RVA = "0x166DE70", Offset = "0x166DE70", VA = "0x166DE70")]
		private static void Log(string message)
		{
		}
	}
	[Token(Token = "0x2000081")]
	public static class Fracturer
	{
		[Token(Token = "0x2000137")]
		private class FracturingStats
		{
			[Token(Token = "0x40005B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nChunkCount;

			[Token(Token = "0x40005B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int nTotalChunks;

			[Token(Token = "0x40005B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nSplitCount;

			[Token(Token = "0x40005B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool bCancelFracturing;

			[Token(Token = "0x6000946")]
			[Address(RVA = "0x1670AC8", Offset = "0x1670AC8", VA = "0x1670AC8")]
			public FracturingStats()
			{
			}
		}

		[Token(Token = "0x2000138")]
		public delegate void ProgressDelegate(string strTitle, string message, float fT);

		[Token(Token = "0x2000139")]
		private class SpaceTreeNode
		{
			[Token(Token = "0x40005BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private SpaceTreeNode nodeOneSide;

			[Token(Token = "0x40005BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private SpaceTreeNode nodeOtherSide;

			[Token(Token = "0x40005BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int nLevel;

			[Token(Token = "0x40005BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int nSplitsX;

			[Token(Token = "0x40005BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int nSplitsY;

			[Token(Token = "0x40005BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int nSplitsZ;

			[Token(Token = "0x40005C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3 v3Min;

			[Token(Token = "0x40005C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private Vector3 v3Max;

			[Token(Token = "0x40005C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private List<MeshData> listMeshDatasSpace;

			[Token(Token = "0x600094B")]
			[Address(RVA = "0x16821DC", Offset = "0x16821DC", VA = "0x16821DC")]
			public SpaceTreeNode()
			{
			}

			[Token(Token = "0x600094C")]
			[Address(RVA = "0x1682258", Offset = "0x1682258", VA = "0x1682258")]
			public bool ContainsCompletely(Vector3 v3Min, Vector3 v3Max)
			{
				return default(bool);
			}

			[Token(Token = "0x600094D")]
			[Address(RVA = "0x16822C8", Offset = "0x16822C8", VA = "0x16822C8")]
			public static List<MeshData> GetSmallestPossibleMeshData(SpaceTreeNode root, Vector3 v3Min, Vector3 v3Max)
			{
				return null;
			}

			[Token(Token = "0x600094E")]
			[Address(RVA = "0x168238C", Offset = "0x168238C", VA = "0x168238C")]
			public static SpaceTreeNode BuildSpaceTree(MeshData meshDataIn, int nSubdivisionLevels, FracturedObject fracturedComponent, [Optional] ProgressDelegate progress)
			{
				return null;
			}
		}

		[Token(Token = "0x200013A")]
		public class SplitOptions
		{
			[Token(Token = "0x40005C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static SplitOptions Default;

			[Token(Token = "0x40005C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool bForceNoProgressInfo;

			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool bForceNoIslandGeneration;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool bForceNoChunkConnectionInfo;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x13")]
			public bool bForceNoIslandConnectionInfo;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public bool bForceNoCap;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
			public bool bForceCapVertexSoup;

			[Token(Token = "0x40005CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
			public bool bIgnoreNegativeSide;

			[Token(Token = "0x40005CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x17")]
			public bool bVerticesAreLocal;

			[Token(Token = "0x40005CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int nForceMeshConnectivityHash;

			[Token(Token = "0x600094F")]
			[Address(RVA = "0x1682C38", Offset = "0x1682C38", VA = "0x1682C38")]
			public SplitOptions()
			{
			}
		}

		[Token(Token = "0x40002F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static FracturingStats s_FracturingStats;

		[Token(Token = "0x6000479")]
		[Address(RVA = "0x166E514", Offset = "0x166E514", VA = "0x166E514")]
		public static void CancelFracturing()
		{
		}

		[Token(Token = "0x600047A")]
		[Address(RVA = "0x166E618", Offset = "0x166E618", VA = "0x166E618")]
		public static bool IsFracturingCancelled()
		{
			return default(bool);
		}

		[Token(Token = "0x600047B")]
		[Address(RVA = "0x166E728", Offset = "0x166E728", VA = "0x166E728")]
		public static bool FractureToChunks(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x600047C")]
		[Address(RVA = "0x166ED30", Offset = "0x166ED30", VA = "0x166ED30")]
		private static Mesh CopyMesh(MeshFilter meshfIn)
		{
			return null;
		}

		[Token(Token = "0x600047D")]
		[Address(RVA = "0x166F13C", Offset = "0x166F13C", VA = "0x166F13C")]
		private static bool FractureToChunksBSP(FracturedObject fracturedComponent, bool bPositionOnSourceAndHideOriginal, out List<GameObject> listGameObjectsOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x167101C", Offset = "0x167101C", VA = "0x167101C")]
		public static List<MeshData> ComputeMeshDataIslands(MeshData meshDataIn, bool bVerticesAreLocal, FracturedObject fracturedComponent, ProgressDelegate progress)
		{
			return null;
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x167AD00", Offset = "0x167AD00", VA = "0x167AD00")]
		public static void ComputeChunkColliders(FracturedObject fracturedComponent, ProgressDelegate progress)
		{
		}

		[Token(Token = "0x6000480")]
		[Address(RVA = "0x167C0C8", Offset = "0x167C0C8", VA = "0x167C0C8")]
		public static void DeleteChunkColliders(FracturedObject fracturedComponent)
		{
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x1672578", Offset = "0x1672578", VA = "0x1672578")]
		private static Matrix4x4 GetRandomPlaneSplitMatrix(MeshData meshDataIn, FracturedObject fracturedComponent, out int nSplitAxisPerformed)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x167A670", Offset = "0x167A670", VA = "0x167A670")]
		private static GameObject CreateNewSplitGameObject(GameObject gameObjectIn, FracturedObject fracturedComponent, string strName, bool bTransformVerticesBackToLocal, MeshData meshData)
		{
			return null;
		}

		[Token(Token = "0x6000483")]
		[Address(RVA = "0x167C50C", Offset = "0x167C50C", VA = "0x167C50C")]
		private static int CreateMeshConnectivityVoronoiHash(int nCell1, int nCell2)
		{
			return default(int);
		}

		[Token(Token = "0x6000484")]
		[Address(RVA = "0x167AA38", Offset = "0x167AA38", VA = "0x167AA38")]
		private static void ComputeChunkConnections(FracturedObject fracturedObject, List<GameObject> listGameObjects, List<MeshData> listMeshDatas, [Optional] ProgressDelegate progress)
		{
		}

		[Token(Token = "0x6000485")]
		[Address(RVA = "0x167BDE8", Offset = "0x167BDE8", VA = "0x167BDE8")]
		private static void RemoveEmptySubmeshes(FracturedChunk fracturedChunk)
		{
		}

		[Token(Token = "0x6000486")]
		[Address(RVA = "0x167CF64", Offset = "0x167CF64", VA = "0x167CF64")]
		public static bool SplitMeshUsingPlane(GameObject gameObjectIn, FracturedObject fracturedComponent, SplitOptions splitOptions, Transform transformPlaneSplit, out List<GameObject> listGameObjectsPosOut, out List<GameObject> listGameObjectsNegOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000487")]
		[Address(RVA = "0x1672F5C", Offset = "0x1672F5C", VA = "0x1672F5C")]
		private static bool SplitMeshUsingPlane(MeshData meshDataIn, FracturedObject fracturedComponent, SplitOptions splitOptions, Vector3 v3PlaneNormal, Vector3 v3PlaneRight, Vector3 v3PlanePoint, out List<MeshData> listMeshDatasPosOut, out List<MeshData> listMeshDatasNegOut, [Optional] ProgressDelegate progress)
		{
			return default(bool);
		}

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x167164C", Offset = "0x167164C", VA = "0x167164C")]
		private static bool ComputeIslandsMeshDataConnectivity(FracturedObject fracturedComponent, bool bVerticesAreLocal, MeshData meshData1, MeshData meshData2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x1680654", Offset = "0x1680654", VA = "0x1680654")]
		public static bool IntersectEdges2D(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x1680890", Offset = "0x1680890", VA = "0x1680890")]
		private static float CrossProduct2D(Vector2 a, Vector2 b)
		{
			return default(float);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x167E624", Offset = "0x167E624", VA = "0x167E624")]
		private static void TriangulateConstrainedDelaunay(List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bForceVertexSoup, FracturedObject fracturedComponent, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		[Token(Token = "0x600048C")]
		[Address(RVA = "0x16808A0", Offset = "0x16808A0", VA = "0x16808A0")]
		private static void CreateIndexedMesh(IList<DelaunayTriangleX> listTriangles, List<Vector3> listVerticesOut, List<int> listIndicesOut, Matrix4x4 mtxTransform, bool bTransform)
		{
		}

		[Token(Token = "0x600048D")]
		[Address(RVA = "0x1680EDC", Offset = "0x1680EDC", VA = "0x1680EDC")]
		private static void Triangulate(List<Vector3> listVertices, List<int> listIndices, FracturedObject fracturedComponent, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay, bool bConnectivityPostprocess, MeshFaceConnectivity faceConnectivityPos, MeshFaceConnectivity faceConnectivityNeg, MeshDataConnectivity meshConnectivityPos, MeshDataConnectivity meshConnectivityNeg, int nForceMeshConnectivityHash, int nSplitCloseSubMesh, Matrix4x4 mtxPlane, Matrix4x4 mtxToLocalPos, Matrix4x4 mtxToLocalNeg, Vector3 v3CenterPos, Vector3 v3CenterNeg, List<int>[] aListIndicesPosInOut, List<VertexData> listVertexDataPosInOut, List<int>[] aListIndicesNegInOut, List<VertexData> listVertexDataNegInOut)
		{
		}

		[Token(Token = "0x600048E")]
		[Address(RVA = "0x1681E7C", Offset = "0x1681E7C", VA = "0x1681E7C")]
		private static int ComputeVertexHash(Vector3 v3Vertex, List<List<Vector3>> listlistPointsConstrainedDelaunay, List<List<int>> listlistHashValuesConstrainedDelaunay)
		{
			return default(int);
		}

		[Token(Token = "0x600048F")]
		[Address(RVA = "0x167D824", Offset = "0x167D824", VA = "0x167D824")]
		private static bool AddCapEdge(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, int nVertexHash1, int nVertexHash2, Vector3 v3Vertex1, Vector3 v3Vertex2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000490")]
		[Address(RVA = "0x167DCE4", Offset = "0x167DCE4", VA = "0x167DCE4")]
		private static bool ResolveCap(Dictionary<EdgeKeyByHash, CapEdge> dicCapEdges, List<List<Vector3>> listlistResolvedCapVertices, List<List<int>> listlistResolvedCapHashValues, FracturedObject fracturedComponent)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000082")]
	public class DieTimer : MonoBehaviour
	{
		[Token(Token = "0x40002F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SecondsToDie;

		[Token(Token = "0x40002F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float OffscreenLifeTime;

		[Token(Token = "0x40002F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_fTimer;

		[Token(Token = "0x6000492")]
		[Address(RVA = "0x166E29C", Offset = "0x166E29C", VA = "0x166E29C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000493")]
		[Address(RVA = "0x166E2A4", Offset = "0x166E2A4", VA = "0x166E2A4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x166E358", Offset = "0x166E358", VA = "0x166E358")]
		public DieTimer()
		{
		}
	}
	[Token(Token = "0x2000083")]
	public static class Parameters
	{
		[Token(Token = "0x40002F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float EPSILONDISTANCEPLANE;

		[Token(Token = "0x40002F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static float EPSILONDISTANCEVERTEX;

		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static float EPSILONCAPPRECISIONMIN;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static float EPSILONCROSSPRODUCT;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static float EPSILONINSIDETRIANGLE;

		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public static int VERTICESSPACESUBDIVISION;
	}
	[Token(Token = "0x2000084")]
	public class VertexData
	{
		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nVertexHash;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public Vector3 v3Vertex;

		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 v3Normal;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public Vector4 v4Tangent;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Color32 color32;

		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector2 v2Mapping1;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Vector2 v2Mapping2;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool bHasNormal;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool bHasTangent;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		public bool bHasColor32;

		[Token(Token = "0x4000307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
		public bool bHasMapping1;

		[Token(Token = "0x4000308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public bool bHasMapping2;

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x20892B8", Offset = "0x20892B8", VA = "0x20892B8")]
		public VertexData(int nVertexHash)
		{
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x20893CC", Offset = "0x20893CC", VA = "0x20893CC")]
		public VertexData(int nVertexHash, Vector3 v3Vertex, Vector3 v3Normal, Vector3 v4Tangent, Color32 color32, Vector2 v2Mapping1, Vector2 v2Mapping2, bool bHasNormal, bool bHasTangent, bool bHasColor32, bool bHasMapping1, bool bHasMapping2)
		{
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x2089558", Offset = "0x2089558", VA = "0x2089558")]
		public VertexData Copy()
		{
			return null;
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x2089634", Offset = "0x2089634", VA = "0x2089634")]
		public static VertexData Lerp(int nVertexHash, VertexData vd1, VertexData vd2, float fT)
		{
			return null;
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0x208994C", Offset = "0x208994C", VA = "0x208994C")]
		public static bool ClipAgainstPlane(VertexData[] aVertexDataInput, int nIndexA, int nIndexB, Vector3 v3A, Vector3 v3B, Plane planeSplit, ref VertexData clippedVertexDataOut)
		{
			return default(bool);
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0x2089BA4", Offset = "0x2089BA4", VA = "0x2089BA4")]
		public static VertexData[] BuildVertexDataArray(Mesh mesh, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld)
		{
			return null;
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0x208A210", Offset = "0x208A210", VA = "0x208A210")]
		public static void SetMeshDataFromVertexDataArray(MeshFilter meshFilter, MeshData meshData, bool bTransformVertexToLocal)
		{
		}
	}
	[Token(Token = "0x2000085")]
	public struct EdgeKeyByIndex
	{
		[Token(Token = "0x200013B")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByIndex>
		{
			[Token(Token = "0x6000951")]
			[Address(RVA = "0x166E48C", Offset = "0x166E48C", VA = "0x166E48C", Slot = "4")]
			public bool Equals(EdgeKeyByIndex x, EdgeKeyByIndex y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0x166E4C4", Offset = "0x166E4C4", VA = "0x166E4C4", Slot = "5")]
			public int GetHashCode(EdgeKeyByIndex x)
			{
				return default(int);
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0x166E50C", Offset = "0x166E50C", VA = "0x166E50C")]
			public EqualityComparer()
			{
			}
		}

		[Token(Token = "0x4000309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nIndexA;

		[Token(Token = "0x400030A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nIndexB;

		[Token(Token = "0x600049D")]
		[Address(RVA = "0x166E440", Offset = "0x166E440", VA = "0x166E440")]
		public EdgeKeyByIndex(int nIndexA, int nIndexB)
		{
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x166E448", Offset = "0x166E448", VA = "0x166E448")]
		public void Set(int nIndexA, int nIndexB)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x166E450", Offset = "0x166E450", VA = "0x166E450")]
		public bool CompareTo(int nIndexA, int nIndexB)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000086")]
	public struct EdgeKeyByHash
	{
		[Token(Token = "0x200013C")]
		public class EqualityComparer : IEqualityComparer<EdgeKeyByHash>
		{
			[Token(Token = "0x6000954")]
			[Address(RVA = "0x166E3B8", Offset = "0x166E3B8", VA = "0x166E3B8", Slot = "4")]
			public bool Equals(EdgeKeyByHash x, EdgeKeyByHash y)
			{
				return default(bool);
			}

			[Token(Token = "0x6000955")]
			[Address(RVA = "0x166E3F0", Offset = "0x166E3F0", VA = "0x166E3F0", Slot = "5")]
			public int GetHashCode(EdgeKeyByHash x)
			{
				return default(int);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0x166E438", Offset = "0x166E438", VA = "0x166E438")]
			public EqualityComparer()
			{
			}
		}

		[Token(Token = "0x400030B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nHashA;

		[Token(Token = "0x400030C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nHashB;

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x166E36C", Offset = "0x166E36C", VA = "0x166E36C")]
		public EdgeKeyByHash(int nHashA, int nHashB)
		{
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x166E374", Offset = "0x166E374", VA = "0x166E374")]
		public void Set(int nHashA, int nHashB)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x166E37C", Offset = "0x166E37C", VA = "0x166E37C")]
		public bool CompareTo(int nHashA, int nHashB)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x2000087")]
	public struct ClippedEdge
	{
		[Token(Token = "0x400030D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int nOldIndexA;

		[Token(Token = "0x400030E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int nOldIndexB;

		[Token(Token = "0x400030F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int nNewIndexA;

		[Token(Token = "0x4000310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int nNewIndexB;

		[Token(Token = "0x4000311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nClippedIndex;

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x166D1B8", Offset = "0x166D1B8", VA = "0x166D1B8")]
		public ClippedEdge(int nOldIndexA, int nOldIndexB, int nNewIndexA, int nNewIndexB, int nClippedIndex)
		{
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x166D1C8", Offset = "0x166D1C8", VA = "0x166D1C8")]
		public int GetFirstIndex(int nOldIndexA)
		{
			return default(int);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x166D1E4", Offset = "0x166D1E4", VA = "0x166D1E4")]
		public int GetSecondIndex(int nOldIndexB)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000088")]
	public struct CapEdge
	{
		[Token(Token = "0x4000312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public Vector3 v1;

		[Token(Token = "0x4000313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public Vector3 v2;

		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int nHash1;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int nHash2;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float fLength;

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x1B4A2EC", Offset = "0x1B4A2EC", VA = "0x1B4A2EC")]
		public CapEdge(int nHash1, int nHash2, Vector3 v1, Vector3 v2, float fLength)
		{
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x1B4A304", Offset = "0x1B4A304", VA = "0x1B4A304")]
		public int SharesVertex1Of(CapEdge edge)
		{
			return default(int);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x1B4A330", Offset = "0x1B4A330", VA = "0x1B4A330")]
		public int SharesVertex2Of(CapEdge edge)
		{
			return default(int);
		}
	}
	[Token(Token = "0x2000089")]
	public class MeshFaceConnectivity
	{
		[Token(Token = "0x200013D")]
		public struct EdgeData
		{
			[Token(Token = "0x2000193")]
			public struct SideData
			{
				[Token(Token = "0x4000666")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public int nFace;

				[Token(Token = "0x4000667")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public int nSubMesh;

				[Token(Token = "0x4000668")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public int nSubMeshFace;

				[Token(Token = "0x4000669")]
				[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
				public int nEdgePos;

				[Token(Token = "0x400066A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public int nVertexDataV1;

				[Token(Token = "0x400066B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				public int nVertexDataV2;

				[Token(Token = "0x6000A3B")]
				[Address(RVA = "0x20879A0", Offset = "0x20879A0", VA = "0x20879A0")]
				public SideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
				{
				}
			}

			[Token(Token = "0x40005CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nEdgeIndex;

			[Token(Token = "0x40005CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private int nVertex1Hash;

			[Token(Token = "0x40005CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int nVertex2Hash;

			[Token(Token = "0x40005D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 v1;

			[Token(Token = "0x40005D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Vector3 v2;

			[Token(Token = "0x40005D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<SideData> listSides;

			[Token(Token = "0x6000957")]
			[Address(RVA = "0x20876DC", Offset = "0x20876DC", VA = "0x20876DC")]
			public EdgeData(int nEdgeIndex, int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataV1, int nVertexDataV2)
			{
			}

			[Token(Token = "0x6000958")]
			[Address(RVA = "0x20879B0", Offset = "0x20879B0", VA = "0x20879B0")]
			public bool Compare(int nVertex1Hash, int nVertex2Hash)
			{
				return default(bool);
			}

			[Token(Token = "0x6000959")]
			[Address(RVA = "0x2087608", Offset = "0x2087608", VA = "0x2087608")]
			public void AddSideData(int nFace, int nSubMesh, int nSubMeshFace, int nEdgePos, int nVertexDataV1, int nVertexDataV2)
			{
			}

			[Token(Token = "0x600095A")]
			[Address(RVA = "0x20879EC", Offset = "0x20879EC", VA = "0x20879EC")]
			public bool HasMoreThanOneSide()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200013E")]
		public class TriangleData
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public int nSubMesh;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int nTriangle;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int[] anEdges;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<int>[] alistNeighborSubMeshes;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<int>[] alistNeighborTriangles;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool bVisited;

			[Token(Token = "0x600095B")]
			[Address(RVA = "0x2087800", Offset = "0x2087800", VA = "0x2087800")]
			public TriangleData(int nSubMesh, int nTriangle)
			{
			}
		}

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<TriangleData> listTriangles;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<EdgeData> listEdges;

		[Token(Token = "0x4000319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<int> listEdgeIndices;

		[Token(Token = "0x400031A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Dictionary<EdgeKeyByHash, EdgeData> dicEdges;

		[Token(Token = "0x400031B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int nEdgeCount;

		[Token(Token = "0x400031C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Dictionary<int, int> dicSubMeshTriangleCount;

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x2086790", Offset = "0x2086790", VA = "0x2086790")]
		public MeshFaceConnectivity()
		{
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x20868D0", Offset = "0x20868D0", VA = "0x20868D0")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x2086990", Offset = "0x2086990", VA = "0x2086990")]
		public void ResetVisited()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x2086A24", Offset = "0x2086A24", VA = "0x2086A24")]
		public void AddEdge(int nSubMesh, Vector3 v1, Vector3 v2, int nVertex1Hash, int nVertex2Hash, int nVertexDataIndex1, int nVertexDataIndex2)
		{
		}
	}
	[Token(Token = "0x200008A")]
	public class MeshDataConnectivity
	{
		[Token(Token = "0x200013F")]
		public struct Face
		{
			[Token(Token = "0x2000194")]
			public class EqualityComparer : IEqualityComparer<Face>
			{
				[Token(Token = "0x6000A3C")]
				[Address(RVA = "0x2086728", Offset = "0x2086728", VA = "0x2086728", Slot = "4")]
				public bool Equals(Face x, Face y)
				{
					return default(bool);
				}

				[Token(Token = "0x6000A3D")]
				[Address(RVA = "0x2086748", Offset = "0x2086748", VA = "0x2086748", Slot = "5")]
				public int GetHashCode(Face x)
				{
					return default(int);
				}

				[Token(Token = "0x6000A3E")]
				[Address(RVA = "0x20855EC", Offset = "0x20855EC", VA = "0x20855EC")]
				public EqualityComparer()
				{
				}
			}

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int nSubMesh;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int nFaceIndex;

			[Token(Token = "0x600095C")]
			[Address(RVA = "0x20860B8", Offset = "0x20860B8", VA = "0x20860B8")]
			public Face(int nSubMesh, int nFaceIndex)
			{
			}
		}

		[Token(Token = "0x400031D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static int s_CurrentSharedFaceHash;

		[Token(Token = "0x400031E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Dictionary<int, List<Face>> dicHash2FaceList;

		[Token(Token = "0x400031F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Dictionary<Face, List<int>> dicFace2HashList;

		[Token(Token = "0x4000320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<Face, bool> dicFace2IsClipped;

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x20854E8", Offset = "0x20854E8", VA = "0x20854E8")]
		public MeshDataConnectivity()
		{
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x20855F4", Offset = "0x20855F4", VA = "0x20855F4")]
		public MeshDataConnectivity GetDeepCopy()
		{
			return null;
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x2085D18", Offset = "0x2085D18", VA = "0x2085D18")]
		public void NotifyNewClippedFace(MeshData meshDataSource, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x20860C0", Offset = "0x20860C0", VA = "0x20860C0")]
		public static int GetNewHash()
		{
			return default(int);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x20861D4", Offset = "0x20861D4", VA = "0x20861D4")]
		public void NotifyNewCapFace(int nHash, int nSubMesh, int nFaceIndex)
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x2086370", Offset = "0x2086370", VA = "0x2086370")]
		public void NotifyRemappedFace(MeshDataConnectivity source, int nSourceSubMesh, int nSourceFaceIndex, int nDestSubMesh, int nDestFaceIndex)
		{
		}
	}
	[Token(Token = "0x200008B")]
	public class MeshData
	{
		[Token(Token = "0x2000140")]
		public class IncreasingSizeComparer : IComparer<MeshData>
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int nSplitAxis;

			[Token(Token = "0x600095D")]
			[Address(RVA = "0x20852D8", Offset = "0x20852D8", VA = "0x20852D8")]
			public IncreasingSizeComparer(int nSplitAxis)
			{
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x2085304", Offset = "0x2085304", VA = "0x2085304", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000141")]
		public class DecreasingSizeComparer : IComparer<MeshData>
		{
			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int nSplitAxis;

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x20850C8", Offset = "0x20850C8", VA = "0x20850C8")]
			public DecreasingSizeComparer(int nSplitAxis)
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x20850F4", Offset = "0x20850F4", VA = "0x20850F4", Slot = "4")]
			public int Compare(MeshData a, MeshData b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int nSubMeshCount;

		[Token(Token = "0x4000322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[][] aaIndices;

		[Token(Token = "0x4000323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int nSplitCloseSubMesh;

		[Token(Token = "0x4000324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public VertexData[] aVertexData;

		[Token(Token = "0x4000325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Vector3 v3Position;

		[Token(Token = "0x4000326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public Quaternion qRotation;

		[Token(Token = "0x4000327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public Vector3 v3Scale;

		[Token(Token = "0x4000328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Vector3 v3Min;

		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public Vector3 v3Max;

		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public int nCurrentVertexHash;

		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Material[] aMaterials;

		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public MeshDataConnectivity meshDataConnectivity;

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1682CD8", Offset = "0x1682CD8", VA = "0x1682CD8")]
		private MeshData()
		{
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x168036C", Offset = "0x168036C", VA = "0x168036C")]
		public MeshData(Material[] aMaterials, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Matrix4x4 mtxTransformVertices, bool bUseTransform, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1670F08", Offset = "0x1670F08", VA = "0x1670F08")]
		public MeshData(Transform transform, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x16833DC", Offset = "0x16833DC", VA = "0x16833DC")]
		public MeshData(Vector3 v3Position, Quaternion qRotation, Vector3 v3Scale, Mesh mesh, Material[] aMaterials, Matrix4x4 mtxLocalToWorld, bool bTransformVerticesToWorld, int nSplitCloseSubMesh, bool bBuildVertexHashData)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x168367C", Offset = "0x168367C", VA = "0x168367C")]
		public static MeshData CreateBoxMeshData(Vector3 v3Pos, Quaternion qRot, Vector3 v3Scale, Vector3 v3Min, Vector3 v3Max)
		{
			return null;
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1683B2C", Offset = "0x1683B2C", VA = "0x1683B2C")]
		public MeshData GetDeepCopy()
		{
			return null;
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x167C388", Offset = "0x167C388", VA = "0x167C388")]
		public bool FillMeshFilter(MeshFilter meshFilter, bool bTransformVerticesToLocal)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x167D998", Offset = "0x167D998", VA = "0x167D998")]
		public static void ComputeMinMax(IEnumerable<VertexData> VertexData, ref Vector3 v3Min, ref Vector3 v3Max)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1682D7C", Offset = "0x1682D7C", VA = "0x1682D7C")]
		private void BuildVertexHashData()
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x167C5AC", Offset = "0x167C5AC", VA = "0x167C5AC")]
		public bool GetSharedFacesArea(FracturedObject fracturedComponent, MeshData meshData2, out float fSharedArea)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1683D98", Offset = "0x1683D98", VA = "0x1683D98")]
		private static bool Face2InsideFace1(FracturedObject fracturedComponent, MeshData meshData1, MeshData meshData2, MeshDataConnectivity.Face face1, MeshDataConnectivity.Face face2)
		{
			return default(bool);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x167B784", Offset = "0x167B784", VA = "0x167B784")]
		public static List<MeshData> PostProcessConnectivity(MeshData meshDataSource, MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, List<int>[] alistIndices, List<VertexData> listVertexData, int nSplitCloseSubMesh, int nCurrentVertexHash, bool bTransformToLocal)
		{
			return null;
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1684BDC", Offset = "0x1684BDC", VA = "0x1684BDC")]
		private static bool StillHasFacesToProcess(List<int>[] alistFacesRemaining)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x16846E0", Offset = "0x16846E0", VA = "0x16846E0")]
		private static void LookForClosedObjectRecursive(MeshFaceConnectivity connectivity, MeshDataConnectivity meshConnectivity, int nSubMeshStart, int nFaceSubMeshStart, List<int>[] alistIndicesIn, List<VertexData> listVertexDataIn, List<int>[] alistFacesRemainingInOut, int[] aLinearFaceIndexStart, List<int>[] alistIndicesOut, List<VertexData> listVertexDataOut, Dictionary<int, int> dicVertexRemap, MeshDataConnectivity meshConnectivityOut)
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200008C")]
	public class SupportPlane
	{
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool GUIExpanded;

		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string GUIName;

		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool GUIShowInScene;

		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public Vector3 v3PlanePosition;

		[Token(Token = "0x4000331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Quaternion qPlaneRotation;

		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 v3PlaneScale;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Mesh planeMesh;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public FracturedObject fracturedObject;

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x2087AE4", Offset = "0x2087AE4", VA = "0x2087AE4")]
		public SupportPlane(FracturedObject fracturedObject)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x20882E0", Offset = "0x20882E0", VA = "0x20882E0")]
		public Matrix4x4 GetLocalMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x20883B8", Offset = "0x20883B8", VA = "0x20883B8")]
		public Vector3[] GetBoundingBoxSegments(Bounds bounds)
		{
			return null;
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2088808", Offset = "0x2088808", VA = "0x2088808")]
		public bool IntersectsWith(GameObject otherGameObject, bool bBelowIsAlsoValid = false)
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2088FF4", Offset = "0x2088FF4", VA = "0x2088FF4")]
		private static bool TestSegmentVsPlane(Vector3 v1, Vector3 v2, Plane plane, Matrix4x4 mtxToPlaneLocal, float fLimitRight, float fLimitUp, float fLimitForward)
		{
			return default(bool);
		}
	}
}
namespace Poly2Tri
{
	[Token(Token = "0x200008D")]
	public static class P2Tx
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static TriangulationAlgorithmX _defaultAlgorithm;

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x1B37C30", Offset = "0x1B37C30", VA = "0x1B37C30")]
		public static void Triangulate(PolygonSetX ps)
		{
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x1B37EB0", Offset = "0x1B37EB0", VA = "0x1B37EB0")]
		public static void Triangulate(PolygonX p)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x1B37FA4", Offset = "0x1B37FA4", VA = "0x1B37FA4")]
		public static void Triangulate(ConstrainedPointSetX cps)
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x1B38014", Offset = "0x1B38014", VA = "0x1B38014")]
		public static void Triangulate(PointSetX ps)
		{
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x1B38084", Offset = "0x1B38084", VA = "0x1B38084")]
		public static TriangulationContextZ CreateContext(TriangulationAlgorithmX algorithm)
		{
			return null;
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x1B37F20", Offset = "0x1B37F20", VA = "0x1B37F20")]
		public static void Triangulate(TriangulationAlgorithmX algorithm, ITriangulatable t)
		{
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x1B380E0", Offset = "0x1B380E0", VA = "0x1B380E0")]
		public static void Triangulate(TriangulationContextZ tcx)
		{
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x1B3817C", Offset = "0x1B3817C", VA = "0x1B3817C")]
		public static void Warmup()
		{
		}
	}
	[Token(Token = "0x200008E")]
	public class DelaunayTriangleX
	{
		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FixedArray3X<TriangulationPointX> Points;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FixedArray3X<DelaunayTriangleX> Neighbors;

		[Token(Token = "0x4000338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FixedBitArray3X mEdgeIsConstrained;

		[Token(Token = "0x4000339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
		public FixedBitArray3X EdgeIsDelaunay;

		[Token(Token = "0x400033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB10", Offset = "0xADEB10")]
		private bool <IsInterior>k__BackingField;

		[Token(Token = "0x17000066")]
		public FixedBitArray3X EdgeIsConstrained
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x1B3540C", Offset = "0x1B3540C", VA = "0x1B3540C")]
			get
			{
				return default(FixedBitArray3X);
			}
		}

		[Token(Token = "0x17000067")]
		public bool IsInterior
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x1B3541C", Offset = "0x1B3541C", VA = "0x1B3541C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0074", Offset = "0xAE0074")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x1B35424", Offset = "0x1B35424", VA = "0x1B35424")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0084", Offset = "0xAE0084")]
			set
			{
			}
		}

		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x1B35430", Offset = "0x1B35430", VA = "0x1B35430")]
		public DelaunayTriangleX(TriangulationPointX p1, TriangulationPointX p2, TriangulationPointX p3)
		{
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x1B354DC", Offset = "0x1B354DC", VA = "0x1B354DC")]
		public int IndexOf(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x1B35584", Offset = "0x1B35584", VA = "0x1B35584")]
		public int IndexCWFrom(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x1B355BC", Offset = "0x1B355BC", VA = "0x1B355BC")]
		public int IndexCCWFrom(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1B355F4", Offset = "0x1B355F4", VA = "0x1B355F4")]
		public bool Contains(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x1B35654", Offset = "0x1B35654", VA = "0x1B35654")]
		private void MarkNeighbor(TriangulationPointX p1, TriangulationPointX p2, DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1B3580C", Offset = "0x1B3580C", VA = "0x1B3580C")]
		public void MarkNeighbor(DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x1B359DC", Offset = "0x1B359DC", VA = "0x1B359DC")]
		public void ClearNeighbors()
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1B35A60", Offset = "0x1B35A60", VA = "0x1B35A60")]
		public void ClearNeighbor(DelaunayTriangleX triangle)
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x1B35B50", Offset = "0x1B35B50", VA = "0x1B35B50")]
		public void Clear()
		{
		}

		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1B35C1C", Offset = "0x1B35C1C", VA = "0x1B35C1C")]
		public TriangulationPointX OppositePoint(DelaunayTriangleX t, TriangulationPointX p)
		{
			return null;
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x1B35CE4", Offset = "0x1B35CE4", VA = "0x1B35CE4")]
		public DelaunayTriangleX NeighborCWFrom(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x1B35D80", Offset = "0x1B35D80", VA = "0x1B35D80")]
		public DelaunayTriangleX NeighborCCWFrom(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x1B35E1C", Offset = "0x1B35E1C", VA = "0x1B35E1C")]
		public DelaunayTriangleX NeighborAcrossFrom(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x1B35E98", Offset = "0x1B35E98", VA = "0x1B35E98")]
		public TriangulationPointX PointCCWFrom(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x1B35C54", Offset = "0x1B35C54", VA = "0x1B35C54")]
		public TriangulationPointX PointCWFrom(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x1B35F28", Offset = "0x1B35F28", VA = "0x1B35F28")]
		private void RotateCW()
		{
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x1B35FF0", Offset = "0x1B35FF0", VA = "0x1B35FF0")]
		public void Legalize(TriangulationPointX oPoint, TriangulationPointX nPoint)
		{
		}

		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x1B36090", Offset = "0x1B36090", VA = "0x1B36090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x1B3623C", Offset = "0x1B3623C", VA = "0x1B3623C")]
		public void MarkNeighborEdges()
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x1B36460", Offset = "0x1B36460", VA = "0x1B36460")]
		public void MarkEdge(DelaunayTriangleX triangle)
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x1B3656C", Offset = "0x1B3656C", VA = "0x1B3656C")]
		public void MarkEdge(List<DelaunayTriangleX> tList)
		{
		}

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x1B36728", Offset = "0x1B36728", VA = "0x1B36728")]
		public void MarkConstrainedEdge(int index)
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x1B367E8", Offset = "0x1B367E8", VA = "0x1B367E8")]
		public void MarkConstrainedEdge(DTSweepConstraintX edge)
		{
		}

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x1B36420", Offset = "0x1B36420", VA = "0x1B36420")]
		public void MarkConstrainedEdge(TriangulationPointX p, TriangulationPointX q)
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x1B36940", Offset = "0x1B36940", VA = "0x1B36940")]
		public double Area()
		{
			return default(double);
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x1B36A64", Offset = "0x1B36A64", VA = "0x1B36A64")]
		public TriangulationPointX Centroid()
		{
			return null;
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x1B3571C", Offset = "0x1B3571C", VA = "0x1B3571C")]
		public int EdgeIndex(TriangulationPointX p1, TriangulationPointX p2)
		{
			return default(int);
		}

		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x1B36C64", Offset = "0x1B36C64", VA = "0x1B36C64")]
		public bool GetConstrainedEdgeCCW(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1B36CC0", Offset = "0x1B36CC0", VA = "0x1B36CC0")]
		public bool GetConstrainedEdgeCW(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x1B36D1C", Offset = "0x1B36D1C", VA = "0x1B36D1C")]
		public bool GetConstrainedEdgeAcross(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x1B36D58", Offset = "0x1B36D58", VA = "0x1B36D58")]
		protected void SetConstrainedEdge(int idx, bool ce)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x1B36D64", Offset = "0x1B36D64", VA = "0x1B36D64")]
		public void SetConstrainedEdgeCCW(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1B36DB4", Offset = "0x1B36DB4", VA = "0x1B36DB4")]
		public void SetConstrainedEdgeCW(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1B36E04", Offset = "0x1B36E04", VA = "0x1B36E04")]
		public void SetConstrainedEdgeAcross(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1B36E38", Offset = "0x1B36E38", VA = "0x1B36E38")]
		public bool GetDelaunayEdgeCCW(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1B36E80", Offset = "0x1B36E80", VA = "0x1B36E80")]
		public bool GetDelaunayEdgeCW(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x1B36EC8", Offset = "0x1B36EC8", VA = "0x1B36EC8")]
		public bool GetDelaunayEdgeAcross(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1B36EF0", Offset = "0x1B36EF0", VA = "0x1B36EF0")]
		public void SetDelaunayEdgeCCW(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1B36F40", Offset = "0x1B36F40", VA = "0x1B36F40")]
		public void SetDelaunayEdgeCW(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1B36F90", Offset = "0x1B36F90", VA = "0x1B36F90")]
		public void SetDelaunayEdgeAcross(TriangulationPointX p, bool ce)
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1B36FC0", Offset = "0x1B36FC0", VA = "0x1B36FC0")]
		public bool GetEdge(int idx, out DTSweepConstraintX edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1B372EC", Offset = "0x1B372EC", VA = "0x1B372EC")]
		public bool GetEdgeCCW(TriangulationPointX p, out DTSweepConstraintX edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1B3733C", Offset = "0x1B3733C", VA = "0x1B3733C")]
		public bool GetEdgeCW(TriangulationPointX p, out DTSweepConstraintX edge)
		{
			return default(bool);
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1B3738C", Offset = "0x1B3738C", VA = "0x1B3738C")]
		public bool GetEdgeAcross(TriangulationPointX p, out DTSweepConstraintX edge)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200008F")]
	public class AdvancingFrontX
	{
		[Token(Token = "0x400033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNodeX Head;

		[Token(Token = "0x400033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNodeX Tail;

		[Token(Token = "0x400033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected AdvancingFrontNodeX Search;

		[Token(Token = "0x6000500")]
		[Address(RVA = "0x19FD0A8", Offset = "0x19FD0A8", VA = "0x19FD0A8")]
		public AdvancingFrontX(AdvancingFrontNodeX head, AdvancingFrontNodeX tail)
		{
		}

		[Token(Token = "0x6000501")]
		[Address(RVA = "0x19FD0E4", Offset = "0x19FD0E4", VA = "0x19FD0E4")]
		public void AddNode(AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0x19FD0E8", Offset = "0x19FD0E8", VA = "0x19FD0E8")]
		public void RemoveNode(AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000503")]
		[Address(RVA = "0x19FD0EC", Offset = "0x19FD0EC", VA = "0x19FD0EC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0x19FD1E4", Offset = "0x19FD1E4", VA = "0x19FD1E4")]
		private AdvancingFrontNodeX FindSearchNode(double x)
		{
			return null;
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0x19FD1EC", Offset = "0x19FD1EC", VA = "0x19FD1EC")]
		public AdvancingFrontNodeX LocateNode(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x19FD228", Offset = "0x19FD228", VA = "0x19FD228")]
		private AdvancingFrontNodeX LocateNode(double x)
		{
			return null;
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x19FD290", Offset = "0x19FD290", VA = "0x19FD290")]
		public AdvancingFrontNodeX LocatePoint(TriangulationPointX point)
		{
			return null;
		}
	}
	[Token(Token = "0x2000090")]
	public class AdvancingFrontNodeX
	{
		[Token(Token = "0x400033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNodeX Next;

		[Token(Token = "0x400033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNodeX Prev;

		[Token(Token = "0x4000340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public double Value;

		[Token(Token = "0x4000341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TriangulationPointX Point;

		[Token(Token = "0x4000342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DelaunayTriangleX Triangle;

		[Token(Token = "0x17000068")]
		public bool HasNext
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0x19FD088", Offset = "0x19FD088", VA = "0x19FD088")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000069")]
		public bool HasPrev
		{
			[Token(Token = "0x600050A")]
			[Address(RVA = "0x19FD098", Offset = "0x19FD098", VA = "0x19FD098")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x19FD040", Offset = "0x19FD040", VA = "0x19FD040")]
		public AdvancingFrontNodeX(TriangulationPointX point)
		{
		}
	}
	[Token(Token = "0x2000091")]
	public static class DTSweepX
	{
		[Token(Token = "0x4000343")]
		private const double PI_div2 = Math.PI / 2.0;

		[Token(Token = "0x4000344")]
		private const double PI_3div4 = Math.PI * 3.0 / 4.0;

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x1A028EC", Offset = "0x1A028EC", VA = "0x1A028EC")]
		public static void Triangulate(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1A02950", Offset = "0x1A02950", VA = "0x1A02950")]
		private static void Sweep(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1A02B50", Offset = "0x1A02B50", VA = "0x1A02B50")]
		private static void FixupConstrainedEdges(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x1A02D8C", Offset = "0x1A02D8C", VA = "0x1A02D8C")]
		private static void FinalizationConvexHull(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x1A034A4", Offset = "0x1A034A4", VA = "0x1A034A4")]
		private static void TurnAdvancingFrontConvex(DTSweepContextX tcx, AdvancingFrontNodeX b, AdvancingFrontNodeX c)
		{
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x1A02D10", Offset = "0x1A02D10", VA = "0x1A02D10")]
		private static void FinalizationPolygon(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x1A039AC", Offset = "0x1A039AC", VA = "0x1A039AC")]
		private static void FinalizationConstraints(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x1A030EC", Offset = "0x1A030EC", VA = "0x1A030EC")]
		private static AdvancingFrontNodeX PointEvent(DTSweepContextX tcx, TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x1A03A20", Offset = "0x1A03A20", VA = "0x1A03A20")]
		private static AdvancingFrontNodeX NewFrontTriangle(DTSweepContextX tcx, TriangulationPointX point, AdvancingFrontNodeX node)
		{
			return null;
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x1A03230", Offset = "0x1A03230", VA = "0x1A03230")]
		private static void EdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x1A03FD8", Offset = "0x1A03FD8", VA = "0x1A03FD8")]
		private static void FillEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x1A044B0", Offset = "0x1A044B0", VA = "0x1A044B0")]
		private static void FillRightConcaveEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x1A0458C", Offset = "0x1A0458C", VA = "0x1A0458C")]
		private static void FillRightConvexEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x1A04674", Offset = "0x1A04674", VA = "0x1A04674")]
		private static void FillRightBelowEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x1A0427C", Offset = "0x1A0427C", VA = "0x1A0427C")]
		private static void FillRightAboveEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x1A04780", Offset = "0x1A04780", VA = "0x1A04780")]
		private static void FillLeftConvexEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x1A04860", Offset = "0x1A04860", VA = "0x1A04860")]
		private static void FillLeftConcaveEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x1A04934", Offset = "0x1A04934", VA = "0x1A04934")]
		private static void FillLeftBelowEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x1A04398", Offset = "0x1A04398", VA = "0x1A04398")]
		private static void FillLeftAboveEdgeEvent(DTSweepContextX tcx, DTSweepConstraintX edge, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x1A03F18", Offset = "0x1A03F18", VA = "0x1A03F18")]
		private static bool IsEdgeSideOfTriangle(DelaunayTriangleX triangle, TriangulationPointX ep, TriangulationPointX eq)
		{
			return default(bool);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x1A04008", Offset = "0x1A04008", VA = "0x1A04008")]
		private static void EdgeEvent(DTSweepContextX tcx, TriangulationPointX ep, TriangulationPointX eq, DelaunayTriangleX triangle, TriangulationPointX point)
		{
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x1A04A3C", Offset = "0x1A04A3C", VA = "0x1A04A3C")]
		private static void FlipEdgeEvent(DTSweepContextX tcx, TriangulationPointX ep, TriangulationPointX eq, DelaunayTriangleX t, TriangulationPointX p)
		{
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x1A04DD4", Offset = "0x1A04DD4", VA = "0x1A04DD4")]
		private static bool NextFlipPoint(TriangulationPointX ep, TriangulationPointX eq, DelaunayTriangleX ot, TriangulationPointX op, out TriangulationPointX newP)
		{
			return default(bool);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x1A04D00", Offset = "0x1A04D00", VA = "0x1A04D00")]
		private static DelaunayTriangleX NextFlipTriangle(DTSweepContextX tcx, OrientationX o, DelaunayTriangleX t, DelaunayTriangleX ot, TriangulationPointX p, TriangulationPointX op)
		{
			return null;
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x1A04EDC", Offset = "0x1A04EDC", VA = "0x1A04EDC")]
		private static void FlipScanEdgeEvent(DTSweepContextX tcx, TriangulationPointX ep, TriangulationPointX eq, DelaunayTriangleX flipTriangle, DelaunayTriangleX t, TriangulationPointX p)
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x1A03B78", Offset = "0x1A03B78", VA = "0x1A03B78")]
		private static void FillAdvancingFront(DTSweepContextX tcx, AdvancingFrontNodeX n)
		{
		}

		[Token(Token = "0x6000525")]
		[Address(RVA = "0x1A052F0", Offset = "0x1A052F0", VA = "0x1A052F0")]
		private static void FillBasin(DTSweepContextX tcx, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0x1A05564", Offset = "0x1A05564", VA = "0x1A05564")]
		private static void FillBasinReq(DTSweepContextX tcx, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x6000527")]
		[Address(RVA = "0x1A05694", Offset = "0x1A05694", VA = "0x1A05694")]
		private static bool IsShallow(DTSweepContextX tcx, AdvancingFrontNodeX node)
		{
			return default(bool);
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0x1A0509C", Offset = "0x1A0509C", VA = "0x1A0509C")]
		private static double HoleAngle(AdvancingFrontNodeX node)
		{
			return default(double);
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0x1A051EC", Offset = "0x1A051EC", VA = "0x1A051EC")]
		private static double BasinAngle(AdvancingFrontNodeX node)
		{
			return default(double);
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0x1A0386C", Offset = "0x1A0386C", VA = "0x1A0386C")]
		private static void Fill(DTSweepContextX tcx, AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600052B")]
		[Address(RVA = "0x1A03C80", Offset = "0x1A03C80", VA = "0x1A03C80")]
		private static bool Legalize(DTSweepContextX tcx, DelaunayTriangleX t)
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0x1A035B0", Offset = "0x1A035B0", VA = "0x1A035B0")]
		private static void RotateTrianglePair(DelaunayTriangleX t, TriangulationPointX p, DelaunayTriangleX ot, TriangulationPointX op)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public class DTSweepBasinX
	{
		[Token(Token = "0x4000345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AdvancingFrontNodeX leftNode;

		[Token(Token = "0x4000346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AdvancingFrontNodeX bottomNode;

		[Token(Token = "0x4000347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AdvancingFrontNodeX rightNode;

		[Token(Token = "0x4000348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public double width;

		[Token(Token = "0x4000349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool leftHighest;

		[Token(Token = "0x600052D")]
		[Address(RVA = "0x1A01A30", Offset = "0x1A01A30", VA = "0x1A01A30")]
		public DTSweepBasinX()
		{
		}
	}
	[Token(Token = "0x2000093")]
	public class DTSweepConstraintX : TriangulationConstraintX
	{
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x1A01A38", Offset = "0x1A01A38", VA = "0x1A01A38")]
		public DTSweepConstraintX(TriangulationPointX p1, TriangulationPointX p2)
		{
		}
	}
	[Token(Token = "0x2000094")]
	public class DTSweepContextX : TriangulationContextZ
	{
		[Token(Token = "0x400034A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly float ALPHA;

		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public AdvancingFrontX Front;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB20", Offset = "0xADEB20")]
		private TriangulationPointX <Head>k__BackingField;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB30", Offset = "0xADEB30")]
		private TriangulationPointX <Tail>k__BackingField;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DTSweepBasinX Basin;

		[Token(Token = "0x400034F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DTSweepEdgeEventX EdgeEvent;

		[Token(Token = "0x4000350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private DTSweepPointComparatorX _comparator;

		[Token(Token = "0x1700006A")]
		public TriangulationPointX Head
		{
			[Token(Token = "0x600052F")]
			[Address(RVA = "0x1A01A78", Offset = "0x1A01A78", VA = "0x1A01A78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0094", Offset = "0xAE0094")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000530")]
			[Address(RVA = "0x1A01A80", Offset = "0x1A01A80", VA = "0x1A01A80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00A4", Offset = "0xAE00A4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006B")]
		public TriangulationPointX Tail
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x1A01A88", Offset = "0x1A01A88", VA = "0x1A01A88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00B4", Offset = "0xAE00B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x1A01A90", Offset = "0x1A01A90", VA = "0x1A01A90")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00C4", Offset = "0xAE00C4")]
			set
			{
			}
		}

		[Token(Token = "0x1700006C")]
		public override TriangulationAlgorithmX Algorithm
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0x1A01A98", Offset = "0x1A01A98", VA = "0x1A01A98", Slot = "4")]
			get
			{
				return default(TriangulationAlgorithmX);
			}
		}

		[Token(Token = "0x1700006D")]
		public override bool IsDebugEnabled
		{
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x1A01B74", Offset = "0x1A01B74", VA = "0x1A01B74", Slot = "8")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000536")]
			[Address(RVA = "0x1A01B7C", Offset = "0x1A01B7C", VA = "0x1A01B7C", Slot = "9")]
			protected set
			{
			}
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0x1A01AA0", Offset = "0x1A01AA0", VA = "0x1A01AA0")]
		public DTSweepContextX()
		{
		}

		[Token(Token = "0x6000537")]
		[Address(RVA = "0x1A01C08", Offset = "0x1A01C08", VA = "0x1A01C08")]
		public void RemoveFromList(DelaunayTriangleX triangle)
		{
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0x1A01C70", Offset = "0x1A01C70", VA = "0x1A01C70")]
		public void MeshClean(DelaunayTriangleX triangle)
		{
		}

		[Token(Token = "0x6000539")]
		[Address(RVA = "0x1A01C74", Offset = "0x1A01C74", VA = "0x1A01C74")]
		private void MeshCleanReq(DelaunayTriangleX triangle)
		{
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0x1A01DBC", Offset = "0x1A01DBC", VA = "0x1A01DBC", Slot = "7")]
		public override void Clear()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0x1A01E20", Offset = "0x1A01E20", VA = "0x1A01E20")]
		public void AddNode(AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0x1A01E38", Offset = "0x1A01E38", VA = "0x1A01E38")]
		public void RemoveNode(AdvancingFrontNodeX node)
		{
		}

		[Token(Token = "0x600053D")]
		[Address(RVA = "0x1A01E50", Offset = "0x1A01E50", VA = "0x1A01E50")]
		public AdvancingFrontNodeX LocateNode(TriangulationPointX point)
		{
			return null;
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0x1A01E68", Offset = "0x1A01E68", VA = "0x1A01E68")]
		public void CreateAdvancingFront()
		{
		}

		[Token(Token = "0x600053F")]
		[Address(RVA = "0x1A02044", Offset = "0x1A02044", VA = "0x1A02044")]
		public void MapTriangleToNodes(DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0x1A02120", Offset = "0x1A02120", VA = "0x1A02120", Slot = "5")]
		public override void PrepareTriangulation(ITriangulatable t)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0x1A02410", Offset = "0x1A02410", VA = "0x1A02410")]
		public void FinalizeTriangulation()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x1A024EC", Offset = "0x1A024EC", VA = "0x1A024EC", Slot = "6")]
		public override TriangulationConstraintX NewConstraint(TriangulationPointX a, TriangulationPointX b)
		{
			return null;
		}
	}
	[Token(Token = "0x2000095")]
	public class DTSweepDebugContextX : TriangulationDebugContextX
	{
		[Token(Token = "0x4000351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DelaunayTriangleX _primaryTriangle;

		[Token(Token = "0x4000352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DelaunayTriangleX _secondaryTriangle;

		[Token(Token = "0x4000353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TriangulationPointX _activePoint;

		[Token(Token = "0x4000354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private AdvancingFrontNodeX _activeNode;

		[Token(Token = "0x4000355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DTSweepConstraintX _activeConstraint;

		[Token(Token = "0x1700006E")]
		public DelaunayTriangleX PrimaryTriangle
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x1A0255C", Offset = "0x1A0255C", VA = "0x1A0255C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x1A02564", Offset = "0x1A02564", VA = "0x1A02564")]
			set
			{
			}
		}

		[Token(Token = "0x1700006F")]
		public DelaunayTriangleX SecondaryTriangle
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x1A025D0", Offset = "0x1A025D0", VA = "0x1A025D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000546")]
			[Address(RVA = "0x1A025D8", Offset = "0x1A025D8", VA = "0x1A025D8")]
			set
			{
			}
		}

		[Token(Token = "0x17000070")]
		public TriangulationPointX ActivePoint
		{
			[Token(Token = "0x6000547")]
			[Address(RVA = "0x1A02644", Offset = "0x1A02644", VA = "0x1A02644")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000548")]
			[Address(RVA = "0x1A0264C", Offset = "0x1A0264C", VA = "0x1A0264C")]
			set
			{
			}
		}

		[Token(Token = "0x17000071")]
		public AdvancingFrontNodeX ActiveNode
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0x1A026B8", Offset = "0x1A026B8", VA = "0x1A026B8")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054A")]
			[Address(RVA = "0x1A026C0", Offset = "0x1A026C0", VA = "0x1A026C0")]
			set
			{
			}
		}

		[Token(Token = "0x17000072")]
		public DTSweepConstraintX ActiveConstraint
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0x1A0272C", Offset = "0x1A0272C", VA = "0x1A0272C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600054C")]
			[Address(RVA = "0x1A02734", Offset = "0x1A02734", VA = "0x1A02734")]
			set
			{
			}
		}

		[Token(Token = "0x17000073")]
		public bool IsDebugContext
		{
			[Token(Token = "0x600054E")]
			[Address(RVA = "0x1A027A0", Offset = "0x1A027A0", VA = "0x1A027A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x1A01C00", Offset = "0x1A01C00", VA = "0x1A01C00")]
		public DTSweepDebugContextX(DTSweepContextX tcx)
		{
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x1A027A8", Offset = "0x1A027A8", VA = "0x1A027A8", Slot = "4")]
		public override void Clear()
		{
		}
	}
	[Token(Token = "0x2000096")]
	public class DTSweepEdgeEventX
	{
		[Token(Token = "0x4000356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DTSweepConstraintX ConstrainedEdge;

		[Token(Token = "0x4000357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool Right;

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x1A01B64", Offset = "0x1A01B64", VA = "0x1A01B64")]
		public DTSweepEdgeEventX()
		{
		}
	}
	[Token(Token = "0x2000097")]
	public class DTSweepPointComparatorX : IComparer<TriangulationPointX>
	{
		[Token(Token = "0x6000551")]
		[Address(RVA = "0x1A027F8", Offset = "0x1A027F8", VA = "0x1A027F8", Slot = "4")]
		public int Compare(TriangulationPointX p1, TriangulationPointX p2)
		{
			return default(int);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x1A01B6C", Offset = "0x1A01B6C", VA = "0x1A01B6C")]
		public DTSweepPointComparatorX()
		{
		}
	}
	[Token(Token = "0x2000098")]
	public class PointOnEdgeExceptionX : NotImplementedException
	{
		[Token(Token = "0x4000358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public readonly TriangulationPointX A;

		[Token(Token = "0x4000359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public readonly TriangulationPointX B;

		[Token(Token = "0x400035A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public readonly TriangulationPointX C;

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x1B3DE3C", Offset = "0x1B3DE3C", VA = "0x1B3DE3C")]
		public PointOnEdgeExceptionX(string message, TriangulationPointX a, TriangulationPointX b, TriangulationPointX c)
		{
		}
	}
	[Token(Token = "0x2000099")]
	public interface ITriangulatable
	{
		[Token(Token = "0x17000074")]
		IList<DelaunayTriangleX> Triangles
		{
			[Token(Token = "0x6000554")]
			get;
		}

		[Token(Token = "0x17000075")]
		TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x6000555")]
			get;
		}

		[Token(Token = "0x17000076")]
		string FileName
		{
			[Token(Token = "0x6000556")]
			get;
			[Token(Token = "0x6000557")]
			set;
		}

		[Token(Token = "0x17000077")]
		bool DisplayFlipX
		{
			[Token(Token = "0x6000558")]
			get;
			[Token(Token = "0x6000559")]
			set;
		}

		[Token(Token = "0x17000078")]
		bool DisplayFlipY
		{
			[Token(Token = "0x600055A")]
			get;
			[Token(Token = "0x600055B")]
			set;
		}

		[Token(Token = "0x17000079")]
		float DisplayRotate
		{
			[Token(Token = "0x600055C")]
			get;
			[Token(Token = "0x600055D")]
			set;
		}

		[Token(Token = "0x1700007A")]
		double Precision
		{
			[Token(Token = "0x600055E")]
			get;
			[Token(Token = "0x600055F")]
			set;
		}

		[Token(Token = "0x1700007B")]
		double MinX
		{
			[Token(Token = "0x6000560")]
			get;
		}

		[Token(Token = "0x1700007C")]
		double MaxX
		{
			[Token(Token = "0x6000561")]
			get;
		}

		[Token(Token = "0x1700007D")]
		double MinY
		{
			[Token(Token = "0x6000562")]
			get;
		}

		[Token(Token = "0x1700007E")]
		double MaxY
		{
			[Token(Token = "0x6000563")]
			get;
		}

		[Token(Token = "0x1700007F")]
		Rect2D Bounds
		{
			[Token(Token = "0x6000564")]
			get;
		}

		[Token(Token = "0x6000565")]
		void Prepare(TriangulationContextZ tcx);

		[Token(Token = "0x6000566")]
		void AddTriangle(DelaunayTriangleX t);

		[Token(Token = "0x6000567")]
		void AddTriangles(IEnumerable<DelaunayTriangleX> list);

		[Token(Token = "0x6000568")]
		void ClearTriangles();
	}
	[Token(Token = "0x200009A")]
	public enum OrientationX
	{
		[Token(Token = "0x400035C")]
		CW,
		[Token(Token = "0x400035D")]
		CCW,
		[Token(Token = "0x400035E")]
		Collinear
	}
	[Token(Token = "0x200009B")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD47C", Offset = "0xADD47C")]
	public class Contour : Point2DList, ITriangulatable, IEnumerable<TriangulationPointX>, IEnumerable, IList<TriangulationPointX>, ICollection<TriangulationPointX>
	{
		[Token(Token = "0x400035F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private List<Contour> mHoles;

		[Token(Token = "0x4000360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ITriangulatable mParent;

		[Token(Token = "0x4000361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string mName;

		[Token(Token = "0x17000080")]
		public new TriangulationPointX Item
		{
			[Token(Token = "0x6000569")]
			[Address(RVA = "0x19FE7FC", Offset = "0x19FE7FC", VA = "0x19FE7FC", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056A")]
			[Address(RVA = "0x1A0025C", Offset = "0x1A0025C", VA = "0x1A0025C", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x17000081")]
		public string Name
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x1A002CC", Offset = "0x1A002CC", VA = "0x1A002CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056C")]
			[Address(RVA = "0x1A002D4", Offset = "0x1A002D4", VA = "0x1A002D4")]
			set
			{
			}
		}

		[Token(Token = "0x17000082")]
		public IList<DelaunayTriangleX> Triangles
		{
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x1A002DC", Offset = "0x1A002DC", VA = "0x1A002DC", Slot = "27")]
			get
			{
				return null;
			}
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x1A00348", Offset = "0x1A00348", VA = "0x1A00348")]
			private set
			{
			}
		}

		[Token(Token = "0x17000083")]
		public TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x1A0034C", Offset = "0x1A0034C", VA = "0x1A0034C", Slot = "28")]
			get
			{
				return default(TriangulationModeX);
			}
		}

		[Token(Token = "0x17000084")]
		public string FileName
		{
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x1A00400", Offset = "0x1A00400", VA = "0x1A00400", Slot = "29")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x1A004B4", Offset = "0x1A004B4", VA = "0x1A004B4", Slot = "30")]
			set
			{
			}
		}

		[Token(Token = "0x17000085")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x1A004B8", Offset = "0x1A004B8", VA = "0x1A004B8", Slot = "31")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x1A0056C", Offset = "0x1A0056C", VA = "0x1A0056C", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x17000086")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x1A00570", Offset = "0x1A00570", VA = "0x1A00570", Slot = "33")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x1A00624", Offset = "0x1A00624", VA = "0x1A00624", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x17000087")]
		public float DisplayRotate
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x1A00628", Offset = "0x1A00628", VA = "0x1A00628", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x1A006DC", Offset = "0x1A006DC", VA = "0x1A006DC", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x17000088")]
		public double Precision
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x1A006E0", Offset = "0x1A006E0", VA = "0x1A006E0", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x1A00794", Offset = "0x1A00794", VA = "0x1A00794", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000089")]
		public double MinX
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1A00798", Offset = "0x1A00798", VA = "0x1A00798", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700008A")]
		public double MaxX
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x1A007B4", Offset = "0x1A007B4", VA = "0x1A007B4", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700008B")]
		public double MinY
		{
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x1A007D0", Offset = "0x1A007D0", VA = "0x1A007D0", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700008C")]
		public double MaxY
		{
			[Token(Token = "0x600057D")]
			[Address(RVA = "0x1A007EC", Offset = "0x1A007EC", VA = "0x1A007EC", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700008D")]
		public Rect2D Bounds
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0x1A00808", Offset = "0x1A00808", VA = "0x1A00808", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x19FE8B4", Offset = "0x19FE8B4", VA = "0x19FE8B4")]
		public Contour(ITriangulatable parent)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x19FE72C", Offset = "0x19FE72C", VA = "0x19FE72C")]
		public Contour(ITriangulatable parent, IList<TriangulationPointX> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x1A00ACC", Offset = "0x1A00ACC", VA = "0x1A00ACC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x1A00B34", Offset = "0x1A00B34", VA = "0x1A00B34", Slot = "48")]
		private IEnumerator<TriangulationPointX> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPointX>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x1A00B9C", Offset = "0x1A00B9C", VA = "0x1A00B9C", Slot = "51")]
		public int IndexOf(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x1A00C04", Offset = "0x1A00C04", VA = "0x1A00C04", Slot = "56")]
		public void Add(TriangulationPointX p)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x1A00C1C", Offset = "0x1A00C1C", VA = "0x1A00C1C", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x1A00D7C", Offset = "0x1A00D7C", VA = "0x1A00D7C", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x1A00810", Offset = "0x1A00810", VA = "0x1A00810")]
		public void AddRange(IList<TriangulationPointX> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x1A01204", Offset = "0x1A01204", VA = "0x1A01204", Slot = "52")]
		public void Insert(int idx, TriangulationPointX p)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x1A01224", Offset = "0x1A01224", VA = "0x1A01224", Slot = "60")]
		public bool Remove(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x1A01234", Offset = "0x1A01234", VA = "0x1A01234", Slot = "58")]
		public bool Contains(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x1A0129C", Offset = "0x1A0129C", VA = "0x1A0129C", Slot = "59")]
		public void CopyTo(TriangulationPointX[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x1A01468", Offset = "0x1A01468", VA = "0x1A01468")]
		protected void AddHole(Contour c)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x19FEBA0", Offset = "0x19FEBA0", VA = "0x19FEBA0")]
		public int GetNumHoles(bool parentIsHole)
		{
			return default(int);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x1A014D8", Offset = "0x1A014D8", VA = "0x1A014D8")]
		public int GetNumHoles()
		{
			return default(int);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x1A01528", Offset = "0x1A01528", VA = "0x1A01528")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x19FEE7C", Offset = "0x19FEE7C", VA = "0x19FEE7C")]
		public void GetActualHoles(bool parentIsHole, ref List<Contour> holes)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1A015B0", Offset = "0x1A015B0", VA = "0x1A015B0")]
		public List<Contour>.Enumerator GetHoleEnumerator()
		{
			return default(List<Contour>.Enumerator);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x19FFF54", Offset = "0x19FFF54", VA = "0x19FFF54")]
		public void InitializeHoles(ConstrainedPointSetX cps)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x19FF0B8", Offset = "0x19FF0B8", VA = "0x19FF0B8")]
		public static void InitializeHoles(List<Contour> holes, ITriangulatable parent, ConstrainedPointSetX cps)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1A0161C", Offset = "0x1A0161C", VA = "0x1A0161C", Slot = "44")]
		public void Prepare(TriangulationContextZ tcx)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1A01688", Offset = "0x1A01688", VA = "0x1A01688", Slot = "45")]
		public void AddTriangle(DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x1A016F4", Offset = "0x1A016F4", VA = "0x1A016F4", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangleX> list)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x1A01760", Offset = "0x1A01760", VA = "0x1A01760", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x1A017CC", Offset = "0x1A017CC", VA = "0x1A017CC")]
		public Point2D FindPointInContour()
		{
			return null;
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x1A018F8", Offset = "0x1A018F8", VA = "0x1A018F8")]
		public bool IsPointInsideContour(Point2D p)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD4B4", Offset = "0xADD4B4")]
	public class PolygonX : Point2DList, ITriangulatable, IEnumerable<TriangulationPointX>, IEnumerable, IList<TriangulationPointX>, ICollection<TriangulationPointX>
	{
		[Token(Token = "0x4000362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPointX> mPointMap;

		[Token(Token = "0x4000363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		protected List<DelaunayTriangleX> mTriangles;

		[Token(Token = "0x4000364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB40", Offset = "0xADEB40")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x4000365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB50", Offset = "0xADEB50")]
		private bool <DisplayFlipX>k__BackingField;

		[Token(Token = "0x4000366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB60", Offset = "0xADEB60")]
		private bool <DisplayFlipY>k__BackingField;

		[Token(Token = "0x4000367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB70", Offset = "0xADEB70")]
		private float <DisplayRotate>k__BackingField;

		[Token(Token = "0x4000368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private double mPrecision;

		[Token(Token = "0x4000369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected List<PolygonX> mHoles;

		[Token(Token = "0x400036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<TriangulationPointX> mSteinerPoints;

		[Token(Token = "0x400036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		protected PolygonPointX _last;

		[Token(Token = "0x1700008E")]
		public IList<TriangulationPointX> Points
		{
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x1B45E7C", Offset = "0x1B45E7C", VA = "0x1B45E7C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008F")]
		public IList<DelaunayTriangleX> Triangles
		{
			[Token(Token = "0x600059B")]
			[Address(RVA = "0x1B45E80", Offset = "0x1B45E80", VA = "0x1B45E80", Slot = "27")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		public TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x600059C")]
			[Address(RVA = "0x1B45E88", Offset = "0x1B45E88", VA = "0x1B45E88", Slot = "28")]
			get
			{
				return default(TriangulationModeX);
			}
		}

		[Token(Token = "0x17000091")]
		public string FileName
		{
			[Token(Token = "0x600059D")]
			[Address(RVA = "0x1B45E90", Offset = "0x1B45E90", VA = "0x1B45E90", Slot = "29")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00D4", Offset = "0xAE00D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600059E")]
			[Address(RVA = "0x1B45E98", Offset = "0x1B45E98", VA = "0x1B45E98", Slot = "30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00E4", Offset = "0xAE00E4")]
			set
			{
			}
		}

		[Token(Token = "0x17000092")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x1B45EA0", Offset = "0x1B45EA0", VA = "0x1B45EA0", Slot = "31")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE00F4", Offset = "0xAE00F4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x1B45EA8", Offset = "0x1B45EA8", VA = "0x1B45EA8", Slot = "32")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0104", Offset = "0xAE0104")]
			set
			{
			}
		}

		[Token(Token = "0x17000093")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x1B45EB4", Offset = "0x1B45EB4", VA = "0x1B45EB4", Slot = "33")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0114", Offset = "0xAE0114")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x1B45EBC", Offset = "0x1B45EBC", VA = "0x1B45EBC", Slot = "34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0124", Offset = "0xAE0124")]
			set
			{
			}
		}

		[Token(Token = "0x17000094")]
		public float DisplayRotate
		{
			[Token(Token = "0x60005A3")]
			[Address(RVA = "0x1B45EC8", Offset = "0x1B45EC8", VA = "0x1B45EC8", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0134", Offset = "0xAE0134")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x1B45ED0", Offset = "0x1B45ED0", VA = "0x1B45ED0", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0144", Offset = "0xAE0144")]
			set
			{
			}
		}

		[Token(Token = "0x17000095")]
		public double Precision
		{
			[Token(Token = "0x60005A5")]
			[Address(RVA = "0x1B45ED8", Offset = "0x1B45ED8", VA = "0x1B45ED8", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60005A6")]
			[Address(RVA = "0x1B45EE0", Offset = "0x1B45EE0", VA = "0x1B45EE0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x17000096")]
		public double MinX
		{
			[Token(Token = "0x60005A7")]
			[Address(RVA = "0x1B45EE8", Offset = "0x1B45EE8", VA = "0x1B45EE8", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000097")]
		public double MaxX
		{
			[Token(Token = "0x60005A8")]
			[Address(RVA = "0x1B45F04", Offset = "0x1B45F04", VA = "0x1B45F04", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000098")]
		public double MinY
		{
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x1B45F20", Offset = "0x1B45F20", VA = "0x1B45F20", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x17000099")]
		public double MaxY
		{
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x1B45F3C", Offset = "0x1B45F3C", VA = "0x1B45F3C", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x1700009A")]
		public Rect2D Bounds
		{
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x1B45F58", Offset = "0x1B45F58", VA = "0x1B45F58", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009B")]
		public new TriangulationPointX Item
		{
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x1B45F60", Offset = "0x1B45F60", VA = "0x1B45F60", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0x1B46018", Offset = "0x1B46018", VA = "0x1B46018", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x1700009C")]
		public IList<PolygonX> Holes
		{
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x1B46088", Offset = "0x1B46088", VA = "0x1B46088")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1B46090", Offset = "0x1B46090", VA = "0x1B46090")]
		public PolygonX(IList<PolygonPointX> points)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x1B464E8", Offset = "0x1B464E8", VA = "0x1B464E8")]
		public PolygonX(IEnumerable<PolygonPointX> points)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1B3FA9C", Offset = "0x1B3FA9C", VA = "0x1B3FA9C")]
		public PolygonX(params PolygonPointX[] points)
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1B46574", Offset = "0x1B46574", VA = "0x1B46574", Slot = "48")]
		private IEnumerator<TriangulationPointX> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPointX>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1B465E4", Offset = "0x1B465E4", VA = "0x1B465E4", Slot = "51")]
		public int IndexOf(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x1B4664C", Offset = "0x1B4664C", VA = "0x1B4664C", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x1B46664", Offset = "0x1B46664", VA = "0x1B46664", Slot = "56")]
		public void Add(TriangulationPointX p)
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x1B4667C", Offset = "0x1B4667C", VA = "0x1B4667C")]
		public void Add(PolygonPointX p)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x1B46694", Offset = "0x1B46694", VA = "0x1B46694", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x1B46228", Offset = "0x1B46228", VA = "0x1B46228")]
		public void AddRange(IList<PolygonPointX> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x1B467EC", Offset = "0x1B467EC", VA = "0x1B467EC")]
		public void AddRange(IList<TriangulationPointX> points, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x1B46AAC", Offset = "0x1B46AAC", VA = "0x1B46AAC", Slot = "52")]
		public void Insert(int idx, TriangulationPointX p)
		{
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x1B46ACC", Offset = "0x1B46ACC", VA = "0x1B46ACC", Slot = "60")]
		public bool Remove(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x1B46AD0", Offset = "0x1B46AD0", VA = "0x1B46AD0")]
		public void RemovePoint(PolygonPointX p)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1B46C68", Offset = "0x1B46C68", VA = "0x1B46C68", Slot = "58")]
		public bool Contains(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x1B46CD0", Offset = "0x1B46CD0", VA = "0x1B46CD0", Slot = "59")]
		public void CopyTo(TriangulationPointX[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1B46E98", Offset = "0x1B46E98", VA = "0x1B46E98")]
		public void AddSteinerPoint(TriangulationPointX point)
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1B46F30", Offset = "0x1B46F30", VA = "0x1B46F30")]
		public void AddSteinerPoints(List<TriangulationPointX> points)
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1B46FC8", Offset = "0x1B46FC8", VA = "0x1B46FC8")]
		public void ClearSteinerPoints()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1B47028", Offset = "0x1B47028", VA = "0x1B47028")]
		public void AddHole(PolygonX poly)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1B470C0", Offset = "0x1B470C0", VA = "0x1B470C0", Slot = "45")]
		public void AddTriangle(DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x1B47128", Offset = "0x1B47128", VA = "0x1B47128", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangleX> list)
		{
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x1B47190", Offset = "0x1B47190", VA = "0x1B47190", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x1B471F0", Offset = "0x1B471F0", VA = "0x1B471F0")]
		public bool IsPointInside(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x1B471F4", Offset = "0x1B471F4", VA = "0x1B471F4", Slot = "44")]
		public void Prepare(TriangulationContextZ tcx)
		{
		}
	}
	[Token(Token = "0x200009D")]
	public class PolygonPointX : TriangulationPointX
	{
		[Token(Token = "0x400036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB80", Offset = "0xADEB80")]
		private PolygonPointX <Next>k__BackingField;

		[Token(Token = "0x400036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEB90", Offset = "0xADEB90")]
		private PolygonPointX <Previous>k__BackingField;

		[Token(Token = "0x1700009D")]
		public PolygonPointX Next
		{
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x1B40C70", Offset = "0x1B40C70", VA = "0x1B40C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0154", Offset = "0xAE0154")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x1B40C78", Offset = "0x1B40C78", VA = "0x1B40C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0164", Offset = "0xAE0164")]
			set
			{
			}
		}

		[Token(Token = "0x1700009E")]
		public PolygonPointX Previous
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0x1B40C80", Offset = "0x1B40C80", VA = "0x1B40C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0174", Offset = "0xAE0174")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x1B40C88", Offset = "0x1B40C88", VA = "0x1B40C88")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0184", Offset = "0xAE0184")]
			set
			{
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x1B3FA20", Offset = "0x1B3FA20", VA = "0x1B3FA20")]
		public PolygonPointX(double x, double y)
		{
		}

		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x1B40C90", Offset = "0x1B40C90", VA = "0x1B40C90")]
		public static Point2D ToBasePoint(PolygonPointX p)
		{
			return null;
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x1B40C94", Offset = "0x1B40C94", VA = "0x1B40C94")]
		public static TriangulationPointX ToTriangulationPoint(PolygonPointX p)
		{
			return null;
		}
	}
	[Token(Token = "0x200009E")]
	public class PolygonSetX
	{
		[Token(Token = "0x400036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<PolygonX> _polygons;

		[Token(Token = "0x1700009F")]
		public IEnumerable<PolygonX> Polygons
		{
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x1B40E0C", Offset = "0x1B40E0C", VA = "0x1B40E0C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x1B40C98", Offset = "0x1B40C98", VA = "0x1B40C98")]
		public PolygonSetX()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x1B40D08", Offset = "0x1B40D08", VA = "0x1B40D08")]
		public PolygonSetX(PolygonX poly)
		{
		}

		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x1B40DA4", Offset = "0x1B40DA4", VA = "0x1B40DA4")]
		public void Add(PolygonX p)
		{
		}
	}
	[Token(Token = "0x200009F")]
	public class PolygonUtil
	{
		[Token(Token = "0x2000142")]
		public enum PolyUnionError
		{
			[Token(Token = "0x40005DE")]
			None,
			[Token(Token = "0x40005DF")]
			NoIntersections,
			[Token(Token = "0x40005E0")]
			Poly1InsidePoly2,
			[Token(Token = "0x40005E1")]
			InfiniteLoop
		}

		[Token(Token = "0x2000143")]
		[Flags]
		public enum PolyOperation : uint
		{
			[Token(Token = "0x40005E3")]
			None = 0u,
			[Token(Token = "0x40005E4")]
			Union = 1u,
			[Token(Token = "0x40005E5")]
			Intersect = 2u,
			[Token(Token = "0x40005E6")]
			Subtract = 4u
		}

		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x1B40E14", Offset = "0x1B40E14", VA = "0x1B40E14")]
		public static Point2DList.WindingOrderType CalculateWindingOrder(IList<Point2D> l)
		{
			return default(Point2DList.WindingOrderType);
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x1B41180", Offset = "0x1B41180", VA = "0x1B41180")]
		public static bool PolygonsAreSame2D(IList<Point2D> poly1, IList<Point2D> poly2)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x1B41574", Offset = "0x1B41574", VA = "0x1B41574")]
		public static bool PointInPolygon2D(IList<Point2D> polygon, Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x1B41910", Offset = "0x1B41910", VA = "0x1B41910")]
		public static bool PolygonsIntersect2D(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x1B41E74", Offset = "0x1B41E74", VA = "0x1B41E74")]
		public bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x1B41E90", Offset = "0x1B41E90", VA = "0x1B41E90")]
		public static bool PolygonContainsPolygon(IList<Point2D> poly1, Rect2D boundRect1, IList<Point2D> poly2, Rect2D boundRect2, bool runIntersectionTest)
		{
			return default(bool);
		}

		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x1B42154", Offset = "0x1B42154", VA = "0x1B42154")]
		public static void ClipPolygonToEdge2D(Point2D edgeBegin, Point2D edgeEnd, IList<Point2D> poly, out List<Point2D> outPoly)
		{
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x1B42ECC", Offset = "0x1B42ECC", VA = "0x1B42ECC")]
		public static void ClipPolygonToPolygon(IList<Point2D> poly, IList<Point2D> clipPoly, out List<Point2D> outPoly)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x1B431F0", Offset = "0x1B431F0", VA = "0x1B431F0")]
		public static PolyUnionError PolygonUnion(Point2DList polygon1, Point2DList polygon2, out Point2DList union)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x1B4328C", Offset = "0x1B4328C", VA = "0x1B4328C")]
		protected static void PolygonUnionInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x1B43708", Offset = "0x1B43708", VA = "0x1B43708")]
		public static PolyUnionError PolygonIntersect(Point2DList polygon1, Point2DList polygon2, out Point2DList intersectOut)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x1B437A4", Offset = "0x1B437A4", VA = "0x1B437A4")]
		protected static void PolygonIntersectInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x1B43C78", Offset = "0x1B43C78", VA = "0x1B43C78")]
		public static PolyUnionError PolygonSubtract(Point2DList polygon1, Point2DList polygon2, out Point2DList subtract)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x1B43D14", Offset = "0x1B43D14", VA = "0x1B43D14")]
		public static void PolygonSubtractInternal(PolygonOperationContext ctx)
		{
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x1B44234", Offset = "0x1B44234", VA = "0x1B44234")]
		public static PolyUnionError PolygonOperation(PolyOperation operations, Point2DList polygon1, Point2DList polygon2, out Dictionary<uint, Point2DList> results)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x1B442D0", Offset = "0x1B442D0", VA = "0x1B442D0")]
		public static PolyUnionError PolygonOperation(PolygonOperationContext ctx)
		{
			return default(PolyUnionError);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x1B44334", Offset = "0x1B44334", VA = "0x1B44334")]
		public static List<Point2DList> SplitComplexPolygon(Point2DList verts, double epsilon)
		{
			return null;
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x1B458B0", Offset = "0x1B458B0", VA = "0x1B458B0")]
		private static List<Point2DList> SplitComplexPolygonCleanup(IList<Point2D> orig)
		{
			return null;
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x1B45E74", Offset = "0x1B45E74", VA = "0x1B45E74")]
		public PolygonUtil()
		{
		}
	}
	[Token(Token = "0x20000A0")]
	public class EdgeIntersectInfo
	{
		[Token(Token = "0x400036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBA0", Offset = "0xADEBA0")]
		private Edge <EdgeOne>k__BackingField;

		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBB0", Offset = "0xADEBB0")]
		private Edge <EdgeTwo>k__BackingField;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBC0", Offset = "0xADEBC0")]
		private Point2D <IntersectionPoint>k__BackingField;

		[Token(Token = "0x170000A0")]
		public Edge EdgeOne
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x1B3747C", Offset = "0x1B3747C", VA = "0x1B3747C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0194", Offset = "0xAE0194")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x1B37484", Offset = "0x1B37484", VA = "0x1B37484")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01A4", Offset = "0xAE01A4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A1")]
		public Edge EdgeTwo
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x1B3748C", Offset = "0x1B3748C", VA = "0x1B3748C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01B4", Offset = "0xAE01B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x1B37494", Offset = "0x1B37494", VA = "0x1B37494")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01C4", Offset = "0xAE01C4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000A2")]
		public Point2D IntersectionPoint
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x1B3749C", Offset = "0x1B3749C", VA = "0x1B3749C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01D4", Offset = "0xAE01D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x1B374A4", Offset = "0x1B374A4", VA = "0x1B374A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01E4", Offset = "0xAE01E4")]
			private set
			{
			}
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x1B3743C", Offset = "0x1B3743C", VA = "0x1B3743C")]
		public EdgeIntersectInfo(Edge edgeOne, Edge edgeTwo, Point2D intersectionPoint)
		{
		}
	}
	[Token(Token = "0x20000A1")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD4EC", Offset = "0xADD4EC")]
	public class SplitComplexPolygonNode
	{
		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SplitComplexPolygonNode> mConnected;

		[Token(Token = "0x4000373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Point2D mPosition;

		[Token(Token = "0x170000A3")]
		public int NumConnected
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x1B45738", Offset = "0x1B45738", VA = "0x1B45738")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000A4")]
		public Point2D Position
		{
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x1B4801C", Offset = "0x1B4801C", VA = "0x1B4801C")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x1B48024", Offset = "0x1B48024", VA = "0x1B48024")]
			set
			{
			}
		}

		[Token(Token = "0x170000A5")]
		public SplitComplexPolygonNode Item
		{
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x1B4518C", Offset = "0x1B4518C", VA = "0x1B4518C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x1B4802C", Offset = "0x1B4802C", VA = "0x1B4802C")]
		public SplitComplexPolygonNode()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x1B45060", Offset = "0x1B45060", VA = "0x1B45060")]
		public SplitComplexPolygonNode(Point2D pos)
		{
		}

		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x1B4809C", Offset = "0x1B4809C", VA = "0x1B4809C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x1B48164", Offset = "0x1B48164", VA = "0x1B48164")]
		public bool Equals(SplitComplexPolygonNode pn)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x1B48188", Offset = "0x1B48188", VA = "0x1B48188", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x1B45204", Offset = "0x1B45204", VA = "0x1B45204")]
		public static bool operator ==(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x1B45788", Offset = "0x1B45788", VA = "0x1B45788")]
		public static bool operator !=(SplitComplexPolygonNode lhs, SplitComplexPolygonNode rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x1B48190", Offset = "0x1B48190", VA = "0x1B48190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x1B482E4", Offset = "0x1B482E4", VA = "0x1B482E4")]
		private bool IsRighter(double sinA, double cosA, double sinB, double cosB)
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x1B48324", Offset = "0x1B48324", VA = "0x1B48324")]
		private int remainder(int x, int modulus)
		{
			return default(int);
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x1B450E4", Offset = "0x1B450E4", VA = "0x1B450E4")]
		public void AddConnection(SplitComplexPolygonNode toMe)
		{
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x1B456D0", Offset = "0x1B456D0", VA = "0x1B456D0")]
		public void RemoveConnection(SplitComplexPolygonNode fromMe)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x1B4833C", Offset = "0x1B4833C", VA = "0x1B4833C")]
		private void RemoveConnectionByIndex(int index)
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x1B457D4", Offset = "0x1B457D4", VA = "0x1B457D4")]
		public void ClearConnections()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x1B483C4", Offset = "0x1B483C4", VA = "0x1B483C4")]
		private bool IsConnectedTo(SplitComplexPolygonNode me)
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x1B45B6C", Offset = "0x1B45B6C", VA = "0x1B45B6C")]
		public SplitComplexPolygonNode GetRightestConnection(SplitComplexPolygonNode incoming)
		{
			return null;
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x1B4582C", Offset = "0x1B4582C", VA = "0x1B4582C")]
		public SplitComplexPolygonNode GetRightestConnection(Point2D incomingDir)
		{
			return null;
		}
	}
	[Token(Token = "0x20000A2")]
	public class PolygonOperationContext
	{
		[Token(Token = "0x4000374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PolygonUtil.PolyOperation mOperations;

		[Token(Token = "0x4000375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Point2DList mOriginalPolygon1;

		[Token(Token = "0x4000376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Point2DList mOriginalPolygon2;

		[Token(Token = "0x4000377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Point2DList mPoly1;

		[Token(Token = "0x4000378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Point2DList mPoly2;

		[Token(Token = "0x4000379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public List<EdgeIntersectInfo> mIntersections;

		[Token(Token = "0x400037A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int mStartingIndex;

		[Token(Token = "0x400037B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public PolygonUtil.PolyUnionError mError;

		[Token(Token = "0x400037C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public List<int> mPoly1VectorAngles;

		[Token(Token = "0x400037D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public List<int> mPoly2VectorAngles;

		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public Dictionary<uint, Point2DList> mOutput;

		[Token(Token = "0x170000A6")]
		public Point2DList Union
		{
			[Token(Token = "0x6000602")]
			[Address(RVA = "0x1B3FD68", Offset = "0x1B3FD68", VA = "0x1B3FD68")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A7")]
		public Point2DList Intersect
		{
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x1B3FE1C", Offset = "0x1B3FE1C", VA = "0x1B3FE1C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		public Point2DList Subtract
		{
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x1B3FED0", Offset = "0x1B3FED0", VA = "0x1B3FED0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x1B3FF84", Offset = "0x1B3FF84", VA = "0x1B3FF84")]
		public PolygonOperationContext()
		{
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0x1B3FFF4", Offset = "0x1B3FFF4", VA = "0x1B3FFF4")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000607")]
		[Address(RVA = "0x1B40080", Offset = "0x1B40080", VA = "0x1B40080")]
		public bool Init(PolygonUtil.PolyOperation operations, Point2DList polygon1, Point2DList polygon2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x1B40780", Offset = "0x1B40780", VA = "0x1B40780")]
		private bool VerticesIntersect(Point2DList polygon1, Point2DList polygon2, out List<EdgeIntersectInfo> intersections)
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x1B40A20", Offset = "0x1B40A20", VA = "0x1B40A20")]
		public bool PointInPolygonAngle(Point2D point, Point2DList polygon)
		{
			return default(bool);
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x1B40B3C", Offset = "0x1B40B3C", VA = "0x1B40B3C")]
		public double VectorAngle(Point2D p1, Point2D p2)
		{
			return default(double);
		}
	}
	[Token(Token = "0x20000A3")]
	public class ConstrainedPointSetX : PointSetX
	{
		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected Dictionary<uint, TriangulationConstraintX> mConstraintMap;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		protected List<Contour> mHoles;

		[Token(Token = "0x170000A9")]
		public override TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0x19FD3D4", Offset = "0x19FD3D4", VA = "0x19FD3D4", Slot = "61")]
			get
			{
				return default(TriangulationModeX);
			}
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x19FD3DC", Offset = "0x19FD3DC", VA = "0x19FD3DC")]
		public ConstrainedPointSetX(List<TriangulationPointX> bounds)
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x19FD818", Offset = "0x19FD818", VA = "0x19FD818")]
		public ConstrainedPointSetX(List<TriangulationPointX> bounds, List<TriangulationConstraintX> constraints)
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x19FDAB0", Offset = "0x19FDAB0", VA = "0x19FDAB0")]
		public ConstrainedPointSetX(List<TriangulationPointX> bounds, int[] indices)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x19FD48C", Offset = "0x19FD48C", VA = "0x19FD48C")]
		protected void AddBoundaryConstraints()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x19FDE94", Offset = "0x19FDE94", VA = "0x19FDE94", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x19FDF30", Offset = "0x19FDF30", VA = "0x19FDF30", Slot = "62")]
		public override void Add(TriangulationPointX p)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x19FDF40", Offset = "0x19FDF40", VA = "0x19FDF40", Slot = "63")]
		public override bool AddRange(List<TriangulationPointX> points)
		{
			return default(bool);
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x19FE050", Offset = "0x19FE050", VA = "0x19FE050")]
		public bool AddHole(List<TriangulationPointX> points, string name)
		{
			return default(bool);
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x19FD8D8", Offset = "0x19FD8D8", VA = "0x19FD8D8")]
		public bool AddConstraints(List<TriangulationConstraintX> constraints)
		{
			return default(bool);
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x19FDCA0", Offset = "0x19FDCA0", VA = "0x19FDCA0")]
		public bool AddConstraint(TriangulationConstraintX tc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x19FE968", Offset = "0x19FE968", VA = "0x19FE968")]
		public bool TryGetConstraint(uint constraintCode, out TriangulationConstraintX tc)
		{
			return default(bool);
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x19FE9D8", Offset = "0x19FE9D8", VA = "0x19FE9D8")]
		public int GetNumConstraints()
		{
			return default(int);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x19FEA30", Offset = "0x19FEA30", VA = "0x19FEA30")]
		public Dictionary<uint, TriangulationConstraintX>.Enumerator GetConstraintEnumerator()
		{
			return default(Dictionary<uint, TriangulationConstraintX>.Enumerator);
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x19FEA9C", Offset = "0x19FEA9C", VA = "0x19FEA9C")]
		public int GetNumHoles()
		{
			return default(int);
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0x19FECB8", Offset = "0x19FECB8", VA = "0x19FECB8")]
		public Contour GetHole(int idx)
		{
			return null;
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x19FED40", Offset = "0x19FED40", VA = "0x19FED40")]
		public int GetActualHoles(out List<Contour> holes)
		{
			return default(int);
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0x19FEFB0", Offset = "0x19FEFB0", VA = "0x19FEFB0")]
		protected void InitializeHoles()
		{
		}

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1A00068", Offset = "0x1A00068", VA = "0x1A00068", Slot = "65")]
		public override bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1A00090", Offset = "0x1A00090", VA = "0x1A00090", Slot = "66")]
		public override void Prepare(TriangulationContextZ tcx)
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1A00198", Offset = "0x1A00198", VA = "0x1A00198", Slot = "64")]
		public override void AddTriangle(DelaunayTriangleX t)
		{
		}
	}
	[Token(Token = "0x20000A4")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD524", Offset = "0xADD524")]
	public class PointSetX : Point2DList, ITriangulatable, IEnumerable<TriangulationPointX>, IEnumerable, IList<TriangulationPointX>, ICollection<TriangulationPointX>
	{
		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		protected Dictionary<uint, TriangulationPointX> mPointMap;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBD0", Offset = "0xADEBD0")]
		private IList<DelaunayTriangleX> <Triangles>k__BackingField;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBE0", Offset = "0xADEBE0")]
		private string <FileName>k__BackingField;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEBF0", Offset = "0xADEBF0")]
		private bool <DisplayFlipX>k__BackingField;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC00", Offset = "0xADEC00")]
		private bool <DisplayFlipY>k__BackingField;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC10", Offset = "0xADEC10")]
		private float <DisplayRotate>k__BackingField;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected double mPrecision;

		[Token(Token = "0x170000AA")]
		public IList<TriangulationPointX> Points
		{
			[Token(Token = "0x6000620")]
			[Address(RVA = "0x1B3DE7C", Offset = "0x1B3DE7C", VA = "0x1B3DE7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x1B3DE80", Offset = "0x1B3DE80", VA = "0x1B3DE80")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AB")]
		public IList<DelaunayTriangleX> Triangles
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1B3DE84", Offset = "0x1B3DE84", VA = "0x1B3DE84", Slot = "27")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE01F4", Offset = "0xAE01F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1B3DE8C", Offset = "0x1B3DE8C", VA = "0x1B3DE8C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0204", Offset = "0xAE0204")]
			private set
			{
			}
		}

		[Token(Token = "0x170000AC")]
		public string FileName
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1B3DE94", Offset = "0x1B3DE94", VA = "0x1B3DE94", Slot = "29")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0214", Offset = "0xAE0214")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000625")]
			[Address(RVA = "0x1B3DE9C", Offset = "0x1B3DE9C", VA = "0x1B3DE9C", Slot = "30")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0224", Offset = "0xAE0224")]
			set
			{
			}
		}

		[Token(Token = "0x170000AD")]
		public bool DisplayFlipX
		{
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x1B3DEA4", Offset = "0x1B3DEA4", VA = "0x1B3DEA4", Slot = "31")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0234", Offset = "0xAE0234")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000627")]
			[Address(RVA = "0x1B3DEAC", Offset = "0x1B3DEAC", VA = "0x1B3DEAC", Slot = "32")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0244", Offset = "0xAE0244")]
			set
			{
			}
		}

		[Token(Token = "0x170000AE")]
		public bool DisplayFlipY
		{
			[Token(Token = "0x6000628")]
			[Address(RVA = "0x1B3DEB8", Offset = "0x1B3DEB8", VA = "0x1B3DEB8", Slot = "33")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0254", Offset = "0xAE0254")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000629")]
			[Address(RVA = "0x1B3DEC0", Offset = "0x1B3DEC0", VA = "0x1B3DEC0", Slot = "34")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0264", Offset = "0xAE0264")]
			set
			{
			}
		}

		[Token(Token = "0x170000AF")]
		public float DisplayRotate
		{
			[Token(Token = "0x600062A")]
			[Address(RVA = "0x1B3DECC", Offset = "0x1B3DECC", VA = "0x1B3DECC", Slot = "35")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0274", Offset = "0xAE0274")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x1B3DED4", Offset = "0x1B3DED4", VA = "0x1B3DED4", Slot = "36")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0284", Offset = "0xAE0284")]
			set
			{
			}
		}

		[Token(Token = "0x170000B0")]
		public double Precision
		{
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x1B3DEDC", Offset = "0x1B3DEDC", VA = "0x1B3DEDC", Slot = "37")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x1B3DEE4", Offset = "0x1B3DEE4", VA = "0x1B3DEE4", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x170000B1")]
		public double MinX
		{
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x1B3DEEC", Offset = "0x1B3DEEC", VA = "0x1B3DEEC", Slot = "39")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B2")]
		public double MaxX
		{
			[Token(Token = "0x600062F")]
			[Address(RVA = "0x1B3DF08", Offset = "0x1B3DF08", VA = "0x1B3DF08", Slot = "40")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B3")]
		public double MinY
		{
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x1B3DF24", Offset = "0x1B3DF24", VA = "0x1B3DF24", Slot = "41")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B4")]
		public double MaxY
		{
			[Token(Token = "0x6000631")]
			[Address(RVA = "0x1B3DF40", Offset = "0x1B3DF40", VA = "0x1B3DF40", Slot = "42")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000B5")]
		public Rect2D Bounds
		{
			[Token(Token = "0x6000632")]
			[Address(RVA = "0x1B3DF5C", Offset = "0x1B3DF5C", VA = "0x1B3DF5C", Slot = "43")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		public virtual TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x6000633")]
			[Address(RVA = "0x1B3DF64", Offset = "0x1B3DF64", VA = "0x1B3DF64", Slot = "61")]
			get
			{
				return default(TriangulationModeX);
			}
		}

		[Token(Token = "0x170000B7")]
		public new TriangulationPointX Item
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0x1B3DF6C", Offset = "0x1B3DF6C", VA = "0x1B3DF6C", Slot = "49")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x1B3E024", Offset = "0x1B3E024", VA = "0x1B3E024", Slot = "50")]
			set
			{
			}
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1B3E094", Offset = "0x1B3E094", VA = "0x1B3E094")]
		public PointSetX(List<TriangulationPointX> bounds)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1B3E35C", Offset = "0x1B3E35C", VA = "0x1B3E35C", Slot = "48")]
		private IEnumerator<TriangulationPointX> System.Collections.Generic.IEnumerable<Poly2Tri.TriangulationPointX>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1B3E400", Offset = "0x1B3E400", VA = "0x1B3E400", Slot = "51")]
		public int IndexOf(TriangulationPointX p)
		{
			return default(int);
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1B3E468", Offset = "0x1B3E468", VA = "0x1B3E468", Slot = "19")]
		public override void Add(Point2D p)
		{
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1B3E500", Offset = "0x1B3E500", VA = "0x1B3E500", Slot = "62")]
		public virtual void Add(TriangulationPointX p)
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1B3E50C", Offset = "0x1B3E50C", VA = "0x1B3E50C", Slot = "20")]
		protected override void Add(Point2D p, int idx, bool constrainToBounds)
		{
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1B3E260", Offset = "0x1B3E260", VA = "0x1B3E260")]
		protected bool Add(TriangulationPointX p, int idx, bool constrainToBounds)
		{
			return default(bool);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1B3E78C", Offset = "0x1B3E78C", VA = "0x1B3E78C", Slot = "22")]
		public override void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1B3E930", Offset = "0x1B3E930", VA = "0x1B3E930", Slot = "63")]
		public virtual bool AddRange(List<TriangulationPointX> points)
		{
			return default(bool);
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1B3EA3C", Offset = "0x1B3EA3C", VA = "0x1B3EA3C")]
		public bool TryGetPoint(double x, double y, out TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1B3EBD8", Offset = "0x1B3EBD8", VA = "0x1B3EBD8", Slot = "52")]
		public void Insert(int idx, TriangulationPointX item)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1B3EC48", Offset = "0x1B3EC48", VA = "0x1B3EC48", Slot = "24")]
		public override bool Remove(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1B3ECB0", Offset = "0x1B3ECB0", VA = "0x1B3ECB0", Slot = "60")]
		public bool Remove(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1B3ED18", Offset = "0x1B3ED18", VA = "0x1B3ED18", Slot = "25")]
		public override void RemoveAt(int idx)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1B3EDA4", Offset = "0x1B3EDA4", VA = "0x1B3EDA4", Slot = "58")]
		public bool Contains(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1B3EE0C", Offset = "0x1B3EE0C", VA = "0x1B3EE0C", Slot = "59")]
		public void CopyTo(TriangulationPointX[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1B3EFD4", Offset = "0x1B3EFD4", VA = "0x1B3EFD4")]
		protected bool ConstrainPointToBounds(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1B3E5B4", Offset = "0x1B3E5B4", VA = "0x1B3E5B4")]
		protected bool ConstrainPointToBounds(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1B3F1AC", Offset = "0x1B3F1AC", VA = "0x1B3F1AC", Slot = "64")]
		public virtual void AddTriangle(DelaunayTriangleX t)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1B3F270", Offset = "0x1B3F270", VA = "0x1B3F270", Slot = "46")]
		public void AddTriangles(IEnumerable<DelaunayTriangleX> list)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1B3F4D4", Offset = "0x1B3F4D4", VA = "0x1B3F4D4", Slot = "47")]
		public void ClearTriangles()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1B3F588", Offset = "0x1B3F588", VA = "0x1B3F588", Slot = "65")]
		public virtual bool Initialize()
		{
			return default(bool);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1B3F590", Offset = "0x1B3F590", VA = "0x1B3F590", Slot = "66")]
		public virtual void Prepare(TriangulationContextZ tcx)
		{
		}
	}
	[Token(Token = "0x20000A5")]
	public enum TriangulationAlgorithmX
	{
		[Token(Token = "0x4000389")]
		DTSweep
	}
	[Token(Token = "0x20000A6")]
	public class Edge
	{
		[Token(Token = "0x400038A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected Point2D mP;

		[Token(Token = "0x400038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Point2D mQ;

		[Token(Token = "0x170000B8")]
		public Point2D EdgeStart
		{
			[Token(Token = "0x600064D")]
			[Address(RVA = "0x1B373BC", Offset = "0x1B373BC", VA = "0x1B373BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1B373C4", Offset = "0x1B373C4", VA = "0x1B373C4")]
			set
			{
			}
		}

		[Token(Token = "0x170000B9")]
		public Point2D EdgeEnd
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1B373CC", Offset = "0x1B373CC", VA = "0x1B373CC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000650")]
			[Address(RVA = "0x1B373D4", Offset = "0x1B373D4", VA = "0x1B373D4")]
			set
			{
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1B373DC", Offset = "0x1B373DC", VA = "0x1B373DC")]
		public Edge()
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1B37404", Offset = "0x1B37404", VA = "0x1B37404")]
		public Edge(Point2D edgeStart, Point2D edgeEnd)
		{
		}
	}
	[Token(Token = "0x20000A7")]
	public class TriangulationConstraintX : Edge
	{
		[Token(Token = "0x400038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private uint mContraintCode;

		[Token(Token = "0x170000BA")]
		public TriangulationPointX P
		{
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x1B36838", Offset = "0x1B36838", VA = "0x1B36838")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x1B4842C", Offset = "0x1B4842C", VA = "0x1B4842C")]
			set
			{
			}
		}

		[Token(Token = "0x170000BB")]
		public TriangulationPointX Q
		{
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x1B368BC", Offset = "0x1B368BC", VA = "0x1B368BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x1B48484", Offset = "0x1B48484", VA = "0x1B48484")]
			set
			{
			}
		}

		[Token(Token = "0x170000BC")]
		public uint ConstraintCode
		{
			[Token(Token = "0x6000657")]
			[Address(RVA = "0x1B484A0", Offset = "0x1B484A0", VA = "0x1B484A0")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1B484A8", Offset = "0x1B484A8", VA = "0x1B484A8")]
		public TriangulationConstraintX(TriangulationPointX p1, TriangulationPointX p2)
		{
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1B485A4", Offset = "0x1B485A4", VA = "0x1B485A4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1B48448", Offset = "0x1B48448", VA = "0x1B48448")]
		public void CalculateContraintCode()
		{
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1B487B8", Offset = "0x1B487B8", VA = "0x1B487B8")]
		public static uint CalculateContraintCode(TriangulationPointX p, TriangulationPointX q)
		{
			return default(uint);
		}
	}
	[Token(Token = "0x20000A8")]
	public abstract class TriangulationContextZ
	{
		[Token(Token = "0x400038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC20", Offset = "0xADEC20")]
		private TriangulationDebugContextX <DebugContext>k__BackingField;

		[Token(Token = "0x400038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<DelaunayTriangleX> Triangles;

		[Token(Token = "0x400038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<TriangulationPointX> Points;

		[Token(Token = "0x4000390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC30", Offset = "0xADEC30")]
		private TriangulationModeX <TriangulationMode>k__BackingField;

		[Token(Token = "0x4000391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC40", Offset = "0xADEC40")]
		private ITriangulatable <Triangulatable>k__BackingField;

		[Token(Token = "0x4000392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC50", Offset = "0xADEC50")]
		private int <StepCount>k__BackingField;

		[Token(Token = "0x4000393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC60", Offset = "0xADEC60")]
		private bool <IsDebugEnabled>k__BackingField;

		[Token(Token = "0x170000BD")]
		public TriangulationDebugContextX DebugContext
		{
			[Token(Token = "0x600065C")]
			[Address(RVA = "0x1B488B8", Offset = "0x1B488B8", VA = "0x1B488B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0294", Offset = "0xAE0294")]
			get
			{
				return null;
			}
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x1B488C0", Offset = "0x1B488C0", VA = "0x1B488C0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02A4", Offset = "0xAE02A4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BE")]
		public TriangulationModeX TriangulationMode
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x1B488C8", Offset = "0x1B488C8", VA = "0x1B488C8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02B4", Offset = "0xAE02B4")]
			get
			{
				return default(TriangulationModeX);
			}
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x1B488D0", Offset = "0x1B488D0", VA = "0x1B488D0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02C4", Offset = "0xAE02C4")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000BF")]
		public ITriangulatable Triangulatable
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x1B488D8", Offset = "0x1B488D8", VA = "0x1B488D8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02D4", Offset = "0xAE02D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x1B488E0", Offset = "0x1B488E0", VA = "0x1B488E0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02E4", Offset = "0xAE02E4")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C0")]
		public int StepCount
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x1B488E8", Offset = "0x1B488E8", VA = "0x1B488E8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE02F4", Offset = "0xAE02F4")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x1B488F0", Offset = "0x1B488F0", VA = "0x1B488F0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0304", Offset = "0xAE0304")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C1")]
		public abstract TriangulationAlgorithmX Algorithm
		{
			[Token(Token = "0x6000665")]
			get;
		}

		[Token(Token = "0x170000C2")]
		public virtual bool IsDebugEnabled
		{
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x1B48AAC", Offset = "0x1B48AAC", VA = "0x1B48AAC", Slot = "8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0314", Offset = "0xAE0314")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600066B")]
			[Address(RVA = "0x1B48AB4", Offset = "0x1B48AB4", VA = "0x1B48AB4", Slot = "9")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0324", Offset = "0xAE0324")]
			protected set
			{
			}
		}

		[Token(Token = "0x170000C3")]
		public DTSweepDebugContextX DTDebugContext
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x1B48AC0", Offset = "0x1B48AC0", VA = "0x1B48AC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1B488F8", Offset = "0x1B488F8", VA = "0x1B488F8")]
		public void Done()
		{
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1B48908", Offset = "0x1B48908", VA = "0x1B48908", Slot = "5")]
		public virtual void PrepareTriangulation(ITriangulatable t)
		{
		}

		[Token(Token = "0x6000667")]
		public abstract TriangulationConstraintX NewConstraint(TriangulationPointX a, TriangulationPointX b);

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1B48A34", Offset = "0x1B48A34", VA = "0x1B48A34")]
		public void Update(string message)
		{
		}

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1B48A38", Offset = "0x1B48A38", VA = "0x1B48A38", Slot = "7")]
		public virtual void Clear()
		{
		}

		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1B48B44", Offset = "0x1B48B44", VA = "0x1B48B44")]
		protected TriangulationContextZ()
		{
		}
	}
	[Token(Token = "0x20000A9")]
	public abstract class TriangulationDebugContextX
	{
		[Token(Token = "0x4000394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected TriangulationContextZ _tcx;

		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1B48BE0", Offset = "0x1B48BE0", VA = "0x1B48BE0")]
		public TriangulationDebugContextX(TriangulationContextZ tcx)
		{
		}

		[Token(Token = "0x600066F")]
		public abstract void Clear();
	}
	[Token(Token = "0x20000AA")]
	public enum TriangulationModeX
	{
		[Token(Token = "0x4000396")]
		Unconstrained,
		[Token(Token = "0x4000397")]
		Constrained,
		[Token(Token = "0x4000398")]
		Polygon
	}
	[Token(Token = "0x20000AB")]
	public class TriangulationPointX : Point2D
	{
		[Token(Token = "0x4000399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly double kVertexCodeDefaultPrecision;

		[Token(Token = "0x400039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected uint mVertexCode;

		[Token(Token = "0x400039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADEC70", Offset = "0xADEC70")]
		private List<DTSweepConstraintX> <Edges>k__BackingField;

		[Token(Token = "0x170000C4")]
		public override double X
		{
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1B48ED8", Offset = "0x1B48ED8", VA = "0x1B48ED8", Slot = "5")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1B48EE0", Offset = "0x1B48EE0", VA = "0x1B48EE0", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000C5")]
		public override double Y
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1B48F7C", Offset = "0x1B48F7C", VA = "0x1B48F7C", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1B48F84", Offset = "0x1B48F84", VA = "0x1B48F84", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000C6")]
		public uint VertexCode
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x1B49020", Offset = "0x1B49020", VA = "0x1B49020")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x170000C7")]
		public List<DTSweepConstraintX> Edges
		{
			[Token(Token = "0x6000675")]
			[Address(RVA = "0x1B49028", Offset = "0x1B49028", VA = "0x1B49028")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0334", Offset = "0xAE0334")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x1B49030", Offset = "0x1B49030", VA = "0x1B49030")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE0344", Offset = "0xAE0344")]
			private set
			{
			}
		}

		[Token(Token = "0x170000C8")]
		public bool HasEdges
		{
			[Token(Token = "0x6000677")]
			[Address(RVA = "0x1B49038", Offset = "0x1B49038", VA = "0x1B49038")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000678")]
		[Address(RVA = "0x1B36BDC", Offset = "0x1B36BDC", VA = "0x1B36BDC")]
		public TriangulationPointX(double x, double y)
		{
		}

		[Token(Token = "0x6000679")]
		[Address(RVA = "0x1B49048", Offset = "0x1B49048", VA = "0x1B49048")]
		public TriangulationPointX(double x, double y, double precision)
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1B490E8", Offset = "0x1B490E8", VA = "0x1B490E8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1B49164", Offset = "0x1B49164", VA = "0x1B49164", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1B4916C", Offset = "0x1B4916C", VA = "0x1B4916C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1B49218", Offset = "0x1B49218", VA = "0x1B49218", Slot = "9")]
		public override void Set(double x, double y)
		{
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1B3EAF8", Offset = "0x1B3EAF8", VA = "0x1B3EAF8")]
		public static uint CreateVertexCode(double x, double y, double precision)
		{
			return default(uint);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1B492C0", Offset = "0x1B492C0", VA = "0x1B492C0")]
		public void AddEdge(DTSweepConstraintX e)
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1B49358", Offset = "0x1B49358", VA = "0x1B49358")]
		public bool HasEdge(TriangulationPointX p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1B370DC", Offset = "0x1B370DC", VA = "0x1B370DC")]
		public bool GetEdge(TriangulationPointX p, out DTSweepConstraintX edge)
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1B49380", Offset = "0x1B49380", VA = "0x1B49380")]
		public static Point2D ToPoint2D(TriangulationPointX p)
		{
			return null;
		}
	}
	[Token(Token = "0x20000AC")]
	public class TriangulationPointEnumerator : IEnumerator<TriangulationPointX>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		[Token(Token = "0x400039D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int position;

		[Token(Token = "0x170000C9")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x1B48CEC", Offset = "0x1B48CEC", VA = "0x1B48CEC", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		public TriangulationPointX Current
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0x1B48CF0", Offset = "0x1B48CF0", VA = "0x1B48CF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1B3E3CC", Offset = "0x1B3E3CC", VA = "0x1B3E3CC")]
		public TriangulationPointEnumerator(IList<Point2D> points)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1B48C0C", Offset = "0x1B48C0C", VA = "0x1B48C0C", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1B48CDC", Offset = "0x1B48CDC", VA = "0x1B48CDC", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1B48CE8", Offset = "0x1B48CE8", VA = "0x1B48CE8", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x20000AD")]
	public class TriangulationPointList : Point2DList
	{
		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1B48E74", Offset = "0x1B48E74", VA = "0x1B48E74")]
		public TriangulationPointList()
		{
		}
	}
	[Token(Token = "0x20000AE")]
	public class PointGenerator
	{
		[Token(Token = "0x400039E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random RNG;

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1B3DB4C", Offset = "0x1B3DB4C", VA = "0x1B3DB4C")]
		public static List<TriangulationPointX> UniformDistribution(int n, double scale)
		{
			return null;
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1B3DCA4", Offset = "0x1B3DCA4", VA = "0x1B3DCA4")]
		public static List<TriangulationPointX> UniformGrid(int n, double scale)
		{
			return null;
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1B3DDC8", Offset = "0x1B3DDC8", VA = "0x1B3DDC8")]
		public PointGenerator()
		{
		}
	}
	[Token(Token = "0x20000AF")]
	public class PolygonGenerator
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly System.Random RNG;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static double PI_2;

		[Token(Token = "0x600068F")]
		[Address(RVA = "0x1B3F714", Offset = "0x1B3F714", VA = "0x1B3F714")]
		public static PolygonX RandomCircleSweep(double scale, int vertexCount)
		{
			return null;
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0x1B3FAA0", Offset = "0x1B3FAA0", VA = "0x1B3FAA0")]
		public static PolygonX RandomCircleSweep2(double scale, int vertexCount)
		{
			return null;
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1B3FCD8", Offset = "0x1B3FCD8", VA = "0x1B3FCD8")]
		public PolygonGenerator()
		{
		}
	}
	[Token(Token = "0x20000B0")]
	public class TriangulationUtilX
	{
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1B493D8", Offset = "0x1B493D8", VA = "0x1B493D8")]
		public static bool SmartIncircle(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1B4955C", Offset = "0x1B4955C", VA = "0x1B4955C")]
		public static bool InScanArea(Point2D pa, Point2D pb, Point2D pc, Point2D pd)
		{
			return default(bool);
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1B3C0BC", Offset = "0x1B3C0BC", VA = "0x1B3C0BC")]
		public static OrientationX Orient2d(Point2D pa, Point2D pb, Point2D pc)
		{
			return default(OrientationX);
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1B49690", Offset = "0x1B49690", VA = "0x1B49690")]
		public static bool PointInBoundingBox(double xmin, double xmax, double ymin, double ymax, Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1B49738", Offset = "0x1B49738", VA = "0x1B49738")]
		public static bool PointOnLineSegment2D(Point2D lineStart, Point2D lineEnd, Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1B4981C", Offset = "0x1B4981C", VA = "0x1B4981C")]
		public static bool PointOnLineSegment2D(double x1, double y1, double x2, double y2, double x, double y, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1B47EDC", Offset = "0x1B47EDC", VA = "0x1B47EDC")]
		public static bool RectsIntersect(Rect2D r1, Rect2D r2)
		{
			return default(bool);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1B4523C", Offset = "0x1B4523C", VA = "0x1B4523C")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, bool firstIsSegment, bool secondIsSegment, bool coincidentEndPointCollisions, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1B3C634", Offset = "0x1B3C634", VA = "0x1B3C634")]
		public static bool LinesIntersect2D(Point2D ptStart0, Point2D ptEnd0, Point2D ptStart1, Point2D ptEnd1, ref Point2D pIntersectionPt, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0x1B499AC", Offset = "0x1B499AC", VA = "0x1B499AC")]
		public static double LI2DDotProduct(Point2D v0, Point2D v1)
		{
			return default(double);
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1B42BE4", Offset = "0x1B42BE4", VA = "0x1B42BE4")]
		public static bool RaysIntersect2D(Point2D ptRayOrigin0, Point2D ptRayVector0, Point2D ptRayOrigin1, Point2D ptRayVector1, ref Point2D ptIntersection)
		{
			return default(bool);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1B49A3C", Offset = "0x1B49A3C", VA = "0x1B49A3C")]
		public TriangulationUtilX()
		{
		}
	}
	[Token(Token = "0x20000B1")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD55C", Offset = "0xADD55C")]
	public struct FixedArray3X<T> : IEnumerable<T>, IEnumerable where T : class
	{
		[Token(Token = "0x2000144")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD914", Offset = "0xADD914")]
		private sealed class <Enumerate>d__10 : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>1__state;

			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T <>2__current;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FixedArray3X<T> <>4__this;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FixedArray3X<T> <>3__<>4__this;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int <i>5__2;

			[Token(Token = "0x17000126")]
			private T System.Collections.Generic.IEnumerator<T>.Current
			{
				[Token(Token = "0x6000964")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000127")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000966")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000961")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000962")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000963")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000965")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000967")]
			[DebuggerHidden]
			private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000968")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _0;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _1;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T _2;

		[Token(Token = "0x170000CB")]
		public T Item
		{
			[Token(Token = "0x600069F")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A0")]
			set
			{
			}
		}

		[Token(Token = "0x60006A1")]
		public bool Contains(T value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006A2")]
		public int IndexOf(T value)
		{
			return default(int);
		}

		[Token(Token = "0x60006A3")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006A4")]
		public void Clear(T value)
		{
		}

		[Token(Token = "0x60006A5")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAE0354", Offset = "0xAE0354")]
		private IEnumerable<T> Enumerate()
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006A7")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B2")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD594", Offset = "0xADD594")]
	public struct FixedBitArray3X : IEnumerable<bool>, IEnumerable
	{
		[Token(Token = "0x2000145")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD924", Offset = "0xADD924")]
		private sealed class <Enumerate>d__10 : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			private bool <>2__current;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private int <>l__initialThreadId;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public FixedBitArray3X <>4__this;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1F")]
			public FixedBitArray3X <>3__<>4__this;

			[Token(Token = "0x40005F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			private int <i>5__2;

			[Token(Token = "0x17000128")]
			private bool System.Collections.Generic.IEnumerator<System.Boolean>.Current
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0x1B377C0", Offset = "0x1B377C0", VA = "0x1B377C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x17000129")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096E")]
				[Address(RVA = "0x1B37828", Offset = "0x1B37828", VA = "0x1B37828", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1B3764C", Offset = "0x1B3764C", VA = "0x1B3764C")]
			[DebuggerHidden]
			public <Enumerate>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0x1B37740", Offset = "0x1B37740", VA = "0x1B37740", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0x1B37744", Offset = "0x1B37744", VA = "0x1B37744", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0x1B377C8", Offset = "0x1B377C8", VA = "0x1B377C8", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x600096F")]
			[Address(RVA = "0x1B3788C", Offset = "0x1B3788C", VA = "0x1B3788C", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<bool> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000970")]
			[Address(RVA = "0x1B37940", Offset = "0x1B37940", VA = "0x1B37940", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool _0;

		[Token(Token = "0x40003A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public bool _1;

		[Token(Token = "0x40003A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public bool _2;

		[Token(Token = "0x170000CC")]
		public bool Item
		{
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x1B36380", Offset = "0x1B36380", VA = "0x1B36380")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A9")]
			[Address(RVA = "0x1B36734", Offset = "0x1B36734", VA = "0x1B36734")]
			set
			{
			}
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1B374AC", Offset = "0x1B374AC", VA = "0x1B374AC")]
		public bool Contains(bool value)
		{
			return default(bool);
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1B37504", Offset = "0x1B37504", VA = "0x1B37504")]
		public int IndexOf(bool value)
		{
			return default(int);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1B37558", Offset = "0x1B37558", VA = "0x1B37558")]
		public void Clear()
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1B37564", Offset = "0x1B37564", VA = "0x1B37564")]
		public void Clear(bool value)
		{
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0x1B375C0", Offset = "0x1B375C0", VA = "0x1B375C0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAE03B8", Offset = "0xAE03B8")]
		private IEnumerable<bool> Enumerate()
		{
			return null;
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0x1B37684", Offset = "0x1B37684", VA = "0x1B37684", Slot = "4")]
		public IEnumerator<bool> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0x1B3773C", Offset = "0x1B3773C", VA = "0x1B3773C", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
	[Token(Token = "0x20000B3")]
	public class MathUtil
	{
		[Token(Token = "0x40003A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static double EPSILON;

		[Token(Token = "0x60006B1")]
		[Address(RVA = "0x1B37944", Offset = "0x1B37944", VA = "0x1B37944")]
		public static bool AreValuesEqual(double val1, double val2)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0x1B379D8", Offset = "0x1B379D8", VA = "0x1B379D8")]
		public static bool AreValuesEqual(double val1, double val2, double tolerance)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B3")]
		[Address(RVA = "0x1B379F8", Offset = "0x1B379F8", VA = "0x1B379F8")]
		public static bool IsValueBetween(double val, double min, double max, double tolerance)
		{
			return default(bool);
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0x1B37A30", Offset = "0x1B37A30", VA = "0x1B37A30")]
		public static double RoundWithPrecision(double f, double precision)
		{
			return default(double);
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x1B37AC4", Offset = "0x1B37AC4", VA = "0x1B37AC4")]
		public static double Clamp(double a, double low, double high)
		{
			return default(double);
		}

		[Token(Token = "0x60006B6")]
		public static void Swap<T>(ref T a, ref T b)
		{
		}

		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x1B37B58", Offset = "0x1B37B58", VA = "0x1B37B58")]
		public static uint Jenkins32Hash(byte[] data, uint nInitialValue)
		{
			return default(uint);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x1B37BC8", Offset = "0x1B37BC8", VA = "0x1B37BC8")]
		public MathUtil()
		{
		}
	}
	[Token(Token = "0x20000B4")]
	public class Point2D : IComparable<Point2D>
	{
		[Token(Token = "0x40003A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected double mX;

		[Token(Token = "0x40003A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected double mY;

		[Token(Token = "0x170000CD")]
		public virtual double X
		{
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x1B38184", Offset = "0x1B38184", VA = "0x1B38184", Slot = "5")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x1B3818C", Offset = "0x1B3818C", VA = "0x1B3818C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170000CE")]
		public virtual double Y
		{
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x1B38194", Offset = "0x1B38194", VA = "0x1B38194", Slot = "7")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x1B3819C", Offset = "0x1B3819C", VA = "0x1B3819C", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170000CF")]
		public float Xf
		{
			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x1B381A4", Offset = "0x1B381A4", VA = "0x1B381A4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x170000D0")]
		public float Yf
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x1B381C4", Offset = "0x1B381C4", VA = "0x1B381C4")]
			get
			{
				return default(float);
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x1B381E4", Offset = "0x1B381E4", VA = "0x1B381E4")]
		public Point2D()
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x1B3820C", Offset = "0x1B3820C", VA = "0x1B3820C")]
		public Point2D(double x, double y)
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x1B38244", Offset = "0x1B38244", VA = "0x1B38244")]
		public Point2D(Point2D p)
		{
		}

		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x1B3829C", Offset = "0x1B3829C", VA = "0x1B3829C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x1B3845C", Offset = "0x1B3845C", VA = "0x1B3845C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x1B38464", Offset = "0x1B38464", VA = "0x1B38464", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x1B38510", Offset = "0x1B38510", VA = "0x1B38510")]
		public bool Equals(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x1B38518", Offset = "0x1B38518", VA = "0x1B38518")]
		public bool Equals(Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x1B38640", Offset = "0x1B38640", VA = "0x1B38640", Slot = "4")]
		public int CompareTo(Point2D other)
		{
			return default(int);
		}

		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x1B38730", Offset = "0x1B38730", VA = "0x1B38730", Slot = "9")]
		public virtual void Set(double x, double y)
		{
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x1B38774", Offset = "0x1B38774", VA = "0x1B38774", Slot = "10")]
		public virtual void Set(Point2D p)
		{
		}

		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x1B387D8", Offset = "0x1B387D8", VA = "0x1B387D8")]
		public void Add(Point2D p)
		{
		}

		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x1B38874", Offset = "0x1B38874", VA = "0x1B38874")]
		public void Add(double scalar)
		{
		}

		[Token(Token = "0x60006CD")]
		[Address(RVA = "0x1B388DC", Offset = "0x1B388DC", VA = "0x1B388DC")]
		public void Subtract(Point2D p)
		{
		}

		[Token(Token = "0x60006CE")]
		[Address(RVA = "0x1B38978", Offset = "0x1B38978", VA = "0x1B38978")]
		public void Subtract(double scalar)
		{
		}

		[Token(Token = "0x60006CF")]
		[Address(RVA = "0x1B389E0", Offset = "0x1B389E0", VA = "0x1B389E0")]
		public void Multiply(Point2D p)
		{
		}

		[Token(Token = "0x60006D0")]
		[Address(RVA = "0x1B38A7C", Offset = "0x1B38A7C", VA = "0x1B38A7C")]
		public void Multiply(double scalar)
		{
		}

		[Token(Token = "0x60006D1")]
		[Address(RVA = "0x1B38AE4", Offset = "0x1B38AE4", VA = "0x1B38AE4")]
		public void Divide(Point2D p)
		{
		}

		[Token(Token = "0x60006D2")]
		[Address(RVA = "0x1B38B80", Offset = "0x1B38B80", VA = "0x1B38B80")]
		public void Divide(double scalar)
		{
		}

		[Token(Token = "0x60006D3")]
		[Address(RVA = "0x1B38BE8", Offset = "0x1B38BE8", VA = "0x1B38BE8")]
		public void Negate()
		{
		}

		[Token(Token = "0x60006D4")]
		[Address(RVA = "0x1B38C44", Offset = "0x1B38C44", VA = "0x1B38C44")]
		public double Magnitude()
		{
			return default(double);
		}

		[Token(Token = "0x60006D5")]
		[Address(RVA = "0x1B38D34", Offset = "0x1B38D34", VA = "0x1B38D34")]
		public double MagnitudeSquared()
		{
			return default(double);
		}

		[Token(Token = "0x60006D6")]
		[Address(RVA = "0x1B38DB4", Offset = "0x1B38DB4", VA = "0x1B38DB4")]
		public double MagnitudeReciprocal()
		{
			return default(double);
		}

		[Token(Token = "0x60006D7")]
		[Address(RVA = "0x1B38DD0", Offset = "0x1B38DD0", VA = "0x1B38DD0")]
		public void Normalize()
		{
		}

		[Token(Token = "0x60006D8")]
		[Address(RVA = "0x1B38DFC", Offset = "0x1B38DFC", VA = "0x1B38DFC")]
		public double Dot(Point2D p)
		{
			return default(double);
		}

		[Token(Token = "0x60006D9")]
		[Address(RVA = "0x1B38E8C", Offset = "0x1B38E8C", VA = "0x1B38E8C")]
		public double Cross(Point2D p)
		{
			return default(double);
		}

		[Token(Token = "0x60006DA")]
		[Address(RVA = "0x1B38F1C", Offset = "0x1B38F1C", VA = "0x1B38F1C")]
		public void Clamp(Point2D low, Point2D high)
		{
		}

		[Token(Token = "0x60006DB")]
		[Address(RVA = "0x1B39078", Offset = "0x1B39078", VA = "0x1B39078")]
		public void Abs()
		{
		}

		[Token(Token = "0x60006DC")]
		[Address(RVA = "0x1B39128", Offset = "0x1B39128", VA = "0x1B39128")]
		public void Reciprocal()
		{
		}

		[Token(Token = "0x60006DD")]
		[Address(RVA = "0x1B391D0", Offset = "0x1B391D0", VA = "0x1B391D0")]
		public void Translate(Point2D vector)
		{
		}

		[Token(Token = "0x60006DE")]
		[Address(RVA = "0x1B391D4", Offset = "0x1B391D4", VA = "0x1B391D4")]
		public void Translate(double x, double y)
		{
		}

		[Token(Token = "0x60006DF")]
		[Address(RVA = "0x1B39240", Offset = "0x1B39240", VA = "0x1B39240")]
		public void Scale(Point2D vector)
		{
		}

		[Token(Token = "0x60006E0")]
		[Address(RVA = "0x1B39244", Offset = "0x1B39244", VA = "0x1B39244")]
		public void Scale(double scalar)
		{
		}

		[Token(Token = "0x60006E1")]
		[Address(RVA = "0x1B39248", Offset = "0x1B39248", VA = "0x1B39248")]
		public void Scale(double x, double y)
		{
		}

		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x1B392B4", Offset = "0x1B392B4", VA = "0x1B392B4")]
		public void Rotate(double radians)
		{
		}

		[Token(Token = "0x60006E3")]
		[Address(RVA = "0x1B3939C", Offset = "0x1B3939C", VA = "0x1B3939C")]
		public void RotateDegrees(double degrees)
		{
		}

		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x1B393B8", Offset = "0x1B393B8", VA = "0x1B393B8")]
		public static double Dot(Point2D lhs, Point2D rhs)
		{
			return default(double);
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x1B39448", Offset = "0x1B39448", VA = "0x1B39448")]
		public static double Cross(Point2D lhs, Point2D rhs)
		{
			return default(double);
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0x1B394D8", Offset = "0x1B394D8", VA = "0x1B394D8")]
		public static Point2D Clamp(Point2D a, Point2D low, Point2D high)
		{
			return null;
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0x1B39560", Offset = "0x1B39560", VA = "0x1B39560")]
		public static Point2D Min(Point2D a, Point2D b)
		{
			return null;
		}

		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x1B39694", Offset = "0x1B39694", VA = "0x1B39694")]
		public static Point2D Max(Point2D a, Point2D b)
		{
			return null;
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0x1B397C8", Offset = "0x1B397C8", VA = "0x1B397C8")]
		public static Point2D Abs(Point2D a)
		{
			return null;
		}

		[Token(Token = "0x60006EA")]
		[Address(RVA = "0x1B39888", Offset = "0x1B39888", VA = "0x1B39888")]
		public static Point2D Reciprocal(Point2D a)
		{
			return null;
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x1B39930", Offset = "0x1B39930", VA = "0x1B39930")]
		public static Point2D Perpendicular(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0x1B399E0", Offset = "0x1B399E0", VA = "0x1B399E0")]
		public static Point2D Perpendicular(double scalar, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0x1B39A90", Offset = "0x1B39A90", VA = "0x1B39A90")]
		public static Point2D operator +(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x60006EE")]
		[Address(RVA = "0x1B39B10", Offset = "0x1B39B10", VA = "0x1B39B10")]
		public static Point2D operator +(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0x1B39B90", Offset = "0x1B39B90", VA = "0x1B39B90")]
		public static Point2D operator -(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x60006F0")]
		[Address(RVA = "0x1B39C10", Offset = "0x1B39C10", VA = "0x1B39C10")]
		public static Point2D operator -(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x1B39C90", Offset = "0x1B39C90", VA = "0x1B39C90")]
		public static Point2D operator *(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0x1B39D10", Offset = "0x1B39D10", VA = "0x1B39D10")]
		public static Point2D operator *(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0x1B39D90", Offset = "0x1B39D90", VA = "0x1B39D90")]
		public static Point2D operator *(double scalar, Point2D lhs)
		{
			return null;
		}

		[Token(Token = "0x60006F4")]
		[Address(RVA = "0x1B39E10", Offset = "0x1B39E10", VA = "0x1B39E10")]
		public static Point2D operator /(Point2D lhs, Point2D rhs)
		{
			return null;
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0x1B39E90", Offset = "0x1B39E90", VA = "0x1B39E90")]
		public static Point2D operator /(Point2D lhs, double scalar)
		{
			return null;
		}

		[Token(Token = "0x60006F6")]
		[Address(RVA = "0x1B39F10", Offset = "0x1B39F10", VA = "0x1B39F10")]
		public static Point2D operator -(Point2D p)
		{
			return null;
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0x1B39F80", Offset = "0x1B39F80", VA = "0x1B39F80")]
		public static bool operator <(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0x1B39FA4", Offset = "0x1B39FA4", VA = "0x1B39FA4")]
		public static bool operator >(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0x1B39FC8", Offset = "0x1B39FC8", VA = "0x1B39FC8")]
		public static bool operator <=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0x1B39FEC", Offset = "0x1B39FEC", VA = "0x1B39FEC")]
		public static bool operator >=(Point2D lhs, Point2D rhs)
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000B5")]
	public class Point2DEnumerator : IEnumerator<Point2D>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected IList<Point2D> mPoints;

		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected int position;

		[Token(Token = "0x170000D1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0x1B3A124", Offset = "0x1B3A124", VA = "0x1B3A124", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		public Point2D Current
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0x1B3A128", Offset = "0x1B3A128", VA = "0x1B3A128", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0x1B3A010", Offset = "0x1B3A010", VA = "0x1B3A010")]
		public Point2DEnumerator(IList<Point2D> points)
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x1B3A044", Offset = "0x1B3A044", VA = "0x1B3A044", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x1B3A114", Offset = "0x1B3A114", VA = "0x1B3A114", Slot = "8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x1B3A120", Offset = "0x1B3A120", VA = "0x1B3A120", Slot = "5")]
		private void System.IDisposable.Dispose()
		{
		}
	}
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xADD5CC", Offset = "0xADD5CC")]
	public class Point2DList : IEnumerable<Point2D>, IEnumerable, IList<Point2D>, ICollection<Point2D>
	{
		[Token(Token = "0x2000146")]
		public enum WindingOrderType
		{
			[Token(Token = "0x40005F4")]
			CW = 0,
			[Token(Token = "0x40005F5")]
			CCW = 1,
			[Token(Token = "0x40005F6")]
			Unknown = 2,
			[Token(Token = "0x40005F7")]
			Default = 1
		}

		[Token(Token = "0x2000147")]
		[Flags]
		public enum PolygonError : uint
		{
			[Token(Token = "0x40005F9")]
			None = 0u,
			[Token(Token = "0x40005FA")]
			NotEnoughVertices = 1u,
			[Token(Token = "0x40005FB")]
			NotConvex = 2u,
			[Token(Token = "0x40005FC")]
			NotSimple = 4u,
			[Token(Token = "0x40005FD")]
			AreaTooSmall = 8u,
			[Token(Token = "0x40005FE")]
			SidesTooCloseToParallel = 0x10u,
			[Token(Token = "0x40005FF")]
			TooThin = 0x20u,
			[Token(Token = "0x4000600")]
			Degenerate = 0x40u,
			[Token(Token = "0x4000601")]
			Unknown = 0x40000000u
		}

		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int kMaxPolygonVertices;

		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly double kLinearSlop;

		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static readonly double kAngularSlop;

		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected List<Point2D> mPoints;

		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected Rect2D mBoundingBox;

		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		protected WindingOrderType mWindingOrder;

		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		protected double mEpsilon;

		[Token(Token = "0x170000D3")]
		public Rect2D BoundingBox
		{
			[Token(Token = "0x6000701")]
			[Address(RVA = "0x1B3A27C", Offset = "0x1B3A27C", VA = "0x1B3A27C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		public WindingOrderType WindingOrder
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0x1B3A284", Offset = "0x1B3A284", VA = "0x1B3A284")]
			get
			{
				return default(WindingOrderType);
			}
			[Token(Token = "0x6000703")]
			[Address(RVA = "0x1B3A28C", Offset = "0x1B3A28C", VA = "0x1B3A28C")]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public double Epsilon
		{
			[Token(Token = "0x6000704")]
			[Address(RVA = "0x1B3A358", Offset = "0x1B3A358", VA = "0x1B3A358")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000D6")]
		public Point2D Item
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0x1B3A360", Offset = "0x1B3A360", VA = "0x1B3A360", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000706")]
			[Address(RVA = "0x1B3A3D8", Offset = "0x1B3A3D8", VA = "0x1B3A3D8", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x170000D7")]
		public int Count
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x1B3A448", Offset = "0x1B3A448", VA = "0x1B3A448", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D8")]
		public virtual bool IsReadOnly
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x1B3A498", Offset = "0x1B3A498", VA = "0x1B3A498", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1B3A4A0", Offset = "0x1B3A4A0", VA = "0x1B3A4A0")]
		public Point2DList()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1B3A5A4", Offset = "0x1B3A5A4", VA = "0x1B3A5A4")]
		public Point2DList(int capacity)
		{
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1B3A6A4", Offset = "0x1B3A6A4", VA = "0x1B3A6A4")]
		public Point2DList(IList<Point2D> l)
		{
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x1B3A810", Offset = "0x1B3A810", VA = "0x1B3A810")]
		public Point2DList(Point2DList l)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x1B3A9C8", Offset = "0x1B3A9C8", VA = "0x1B3A9C8", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x1B3AAC8", Offset = "0x1B3AAC8", VA = "0x1B3AAC8", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x1B3AB54", Offset = "0x1B3AB54", VA = "0x1B3AB54", Slot = "4")]
		private IEnumerator<Point2D> System.Collections.Generic.IEnumerable<Poly2Tri.Point2D>.GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x1B3ABC4", Offset = "0x1B3ABC4", VA = "0x1B3ABC4", Slot = "14")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x1B3AC7C", Offset = "0x1B3AC7C", VA = "0x1B3AC7C", Slot = "8")]
		public int IndexOf(Point2D p)
		{
			return default(int);
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x1B3ACE4", Offset = "0x1B3ACE4", VA = "0x1B3ACE4", Slot = "19")]
		public virtual void Add(Point2D p)
		{
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x1B3ACFC", Offset = "0x1B3ACFC", VA = "0x1B3ACFC", Slot = "20")]
		protected virtual void Add(Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
		{
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x1B3AFD4", Offset = "0x1B3AFD4", VA = "0x1B3AFD4", Slot = "21")]
		public virtual void AddRange(Point2DList l)
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x1B3B08C", Offset = "0x1B3B08C", VA = "0x1B3B08C", Slot = "22")]
		public virtual void AddRange(IEnumerator<Point2D> iter, WindingOrderType windingOrder)
		{
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x1B3B384", Offset = "0x1B3B384", VA = "0x1B3B384", Slot = "23")]
		public virtual void Insert(int idx, Point2D item)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x1B3B3A4", Offset = "0x1B3B3A4", VA = "0x1B3B3A4", Slot = "24")]
		public virtual bool Remove(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x1B3B540", Offset = "0x1B3B540", VA = "0x1B3B540", Slot = "25")]
		public virtual void RemoveAt(int idx)
		{
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x1B3B5D4", Offset = "0x1B3B5D4", VA = "0x1B3B5D4", Slot = "26")]
		public virtual void RemoveRange(int idxStart, int count)
		{
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x1B3B674", Offset = "0x1B3B674", VA = "0x1B3B674", Slot = "15")]
		public bool Contains(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x1B3B6DC", Offset = "0x1B3B6DC", VA = "0x1B3B6DC", Slot = "16")]
		public void CopyTo(Point2D[] array, int arrayIndex)
		{
		}

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x1B3B434", Offset = "0x1B3B434", VA = "0x1B3B434")]
		public void CalculateBounds()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x1B3AF00", Offset = "0x1B3AF00", VA = "0x1B3AF00")]
		public double CalculateEpsilon()
		{
			return default(double);
		}

		[Token(Token = "0x600071E")]
		[Address(RVA = "0x1B3A328", Offset = "0x1B3A328", VA = "0x1B3A328")]
		public WindingOrderType CalculateWindingOrder()
		{
			return default(WindingOrderType);
		}

		[Token(Token = "0x600071F")]
		[Address(RVA = "0x1B3B94C", Offset = "0x1B3B94C", VA = "0x1B3B94C")]
		public int NextIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000720")]
		[Address(RVA = "0x1B3B978", Offset = "0x1B3B978", VA = "0x1B3B978")]
		public int PreviousIndex(int index)
		{
			return default(int);
		}

		[Token(Token = "0x6000721")]
		[Address(RVA = "0x1B3B838", Offset = "0x1B3B838", VA = "0x1B3B838")]
		public double GetSignedArea()
		{
			return default(double);
		}

		[Token(Token = "0x6000722")]
		[Address(RVA = "0x1B3B998", Offset = "0x1B3B998", VA = "0x1B3B998")]
		public double GetArea()
		{
			return default(double);
		}

		[Token(Token = "0x6000723")]
		[Address(RVA = "0x1B3BAB8", Offset = "0x1B3BAB8", VA = "0x1B3BAB8")]
		public Point2D GetCentroid()
		{
			return null;
		}

		[Token(Token = "0x6000724")]
		[Address(RVA = "0x1B3BC30", Offset = "0x1B3BC30", VA = "0x1B3BC30")]
		public void Translate(Point2D vector)
		{
		}

		[Token(Token = "0x6000725")]
		[Address(RVA = "0x1B3BCA0", Offset = "0x1B3BCA0", VA = "0x1B3BCA0")]
		public void Scale(Point2D value)
		{
		}

		[Token(Token = "0x6000726")]
		[Address(RVA = "0x1B3BD10", Offset = "0x1B3BD10", VA = "0x1B3BD10")]
		public void Rotate(double radians)
		{
		}

		[Token(Token = "0x6000727")]
		[Address(RVA = "0x1B3BEC8", Offset = "0x1B3BEC8", VA = "0x1B3BEC8")]
		public bool IsDegenerate()
		{
			return default(bool);
		}

		[Token(Token = "0x6000728")]
		[Address(RVA = "0x1B3C264", Offset = "0x1B3C264", VA = "0x1B3C264")]
		public bool IsConvex()
		{
			return default(bool);
		}

		[Token(Token = "0x6000729")]
		[Address(RVA = "0x1B3C448", Offset = "0x1B3C448", VA = "0x1B3C448")]
		public bool IsSimple()
		{
			return default(bool);
		}

		[Token(Token = "0x600072A")]
		[Address(RVA = "0x1B3C664", Offset = "0x1B3C664", VA = "0x1B3C664")]
		public PolygonError CheckPolygon()
		{
			return default(PolygonError);
		}

		[Token(Token = "0x600072B")]
		[Address(RVA = "0x1B3CB20", Offset = "0x1B3CB20", VA = "0x1B3CB20")]
		public static string GetErrorString(PolygonError error)
		{
			return null;
		}

		[Token(Token = "0x600072C")]
		[Address(RVA = "0x1B3D164", Offset = "0x1B3D164", VA = "0x1B3D164")]
		public void RemoveDuplicateNeighborPoints()
		{
		}

		[Token(Token = "0x600072D")]
		[Address(RVA = "0x1B3D2F0", Offset = "0x1B3D2F0", VA = "0x1B3D2F0")]
		public void Simplify()
		{
		}

		[Token(Token = "0x600072E")]
		[Address(RVA = "0x1B3D2F8", Offset = "0x1B3D2F8", VA = "0x1B3D2F8")]
		public void Simplify(double bias)
		{
		}

		[Token(Token = "0x600072F")]
		[Address(RVA = "0x1B3D434", Offset = "0x1B3D434", VA = "0x1B3D434")]
		public void MergeParallelEdges(double tolerance)
		{
		}

		[Token(Token = "0x6000730")]
		[Address(RVA = "0x1B3DA0C", Offset = "0x1B3DA0C", VA = "0x1B3DA0C")]
		public void ProjectToAxis(Point2D axis, out double min, out double max)
		{
		}
	}
	[Token(Token = "0x20000B7")]
	public class Rect2D
	{
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double mMinX;

		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private double mMaxX;

		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private double mMinY;

		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private double mMaxY;

		[Token(Token = "0x170000D9")]
		public double MinX
		{
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x1B47508", Offset = "0x1B47508", VA = "0x1B47508")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000733")]
			[Address(RVA = "0x1B47510", Offset = "0x1B47510", VA = "0x1B47510")]
			set
			{
			}
		}

		[Token(Token = "0x170000DA")]
		public double MaxX
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x1B47518", Offset = "0x1B47518", VA = "0x1B47518")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000735")]
			[Address(RVA = "0x1B47520", Offset = "0x1B47520", VA = "0x1B47520")]
			set
			{
			}
		}

		[Token(Token = "0x170000DB")]
		public double MinY
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0x1B47528", Offset = "0x1B47528", VA = "0x1B47528")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000737")]
			[Address(RVA = "0x1B47530", Offset = "0x1B47530", VA = "0x1B47530")]
			set
			{
			}
		}

		[Token(Token = "0x170000DC")]
		public double MaxY
		{
			[Token(Token = "0x6000738")]
			[Address(RVA = "0x1B47538", Offset = "0x1B47538", VA = "0x1B47538")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x1B47540", Offset = "0x1B47540", VA = "0x1B47540")]
			set
			{
			}
		}

		[Token(Token = "0x170000DD")]
		public double Left
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x1B47548", Offset = "0x1B47548", VA = "0x1B47548")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x1B47550", Offset = "0x1B47550", VA = "0x1B47550")]
			set
			{
			}
		}

		[Token(Token = "0x170000DE")]
		public double Right
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x1B47558", Offset = "0x1B47558", VA = "0x1B47558")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600073D")]
			[Address(RVA = "0x1B47560", Offset = "0x1B47560", VA = "0x1B47560")]
			set
			{
			}
		}

		[Token(Token = "0x170000DF")]
		public double Top
		{
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x1B47568", Offset = "0x1B47568", VA = "0x1B47568")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x600073F")]
			[Address(RVA = "0x1B47570", Offset = "0x1B47570", VA = "0x1B47570")]
			set
			{
			}
		}

		[Token(Token = "0x170000E0")]
		public double Bottom
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0x1B47578", Offset = "0x1B47578", VA = "0x1B47578")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000741")]
			[Address(RVA = "0x1B47580", Offset = "0x1B47580", VA = "0x1B47580")]
			set
			{
			}
		}

		[Token(Token = "0x170000E1")]
		public double Width
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0x1B3B820", Offset = "0x1B3B820", VA = "0x1B3B820")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E2")]
		public double Height
		{
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x1B3B82C", Offset = "0x1B3B82C", VA = "0x1B3B82C")]
			get
			{
				return default(double);
			}
		}

		[Token(Token = "0x170000E3")]
		public bool Empty
		{
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x1B47588", Offset = "0x1B47588", VA = "0x1B47588")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0x1B3A574", Offset = "0x1B3A574", VA = "0x1B3A574")]
		public Rect2D()
		{
		}

		[Token(Token = "0x6000746")]
		[Address(RVA = "0x1B475AC", Offset = "0x1B475AC", VA = "0x1B475AC", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0x1B475B4", Offset = "0x1B475B4", VA = "0x1B475B4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000748")]
		[Address(RVA = "0x1B4765C", Offset = "0x1B4765C", VA = "0x1B4765C")]
		public bool Equals(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0x1B476DC", Offset = "0x1B476DC", VA = "0x1B476DC")]
		public bool Equals(Rect2D r, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0x1B3AC6C", Offset = "0x1B3AC6C", VA = "0x1B3AC6C")]
		public void Clear()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0x1B47830", Offset = "0x1B47830", VA = "0x1B47830")]
		public void Set(double xmin, double xmax, double ymin, double ymax)
		{
		}

		[Token(Token = "0x600074C")]
		[Address(RVA = "0x1B3A994", Offset = "0x1B3A994", VA = "0x1B3A994")]
		public void Set(Rect2D b)
		{
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0x1B4792C", Offset = "0x1B4792C", VA = "0x1B4792C")]
		public void SetSize(double w, double h)
		{
		}

		[Token(Token = "0x600074E")]
		[Address(RVA = "0x1B47948", Offset = "0x1B47948", VA = "0x1B47948")]
		public bool Contains(double x, double y)
		{
			return default(bool);
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0x1B47984", Offset = "0x1B47984", VA = "0x1B47984")]
		public bool Contains(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0x1B47A10", Offset = "0x1B47A10", VA = "0x1B47A10")]
		public bool Contains(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0x1B47A6C", Offset = "0x1B47A6C", VA = "0x1B47A6C")]
		public bool ContainsInclusive(double x, double y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000752")]
		[Address(RVA = "0x1B47AA8", Offset = "0x1B47AA8", VA = "0x1B47AA8")]
		public bool ContainsInclusive(double x, double y, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0x1B47AF4", Offset = "0x1B47AF4", VA = "0x1B47AF4")]
		public bool ContainsInclusive(Point2D p)
		{
			return default(bool);
		}

		[Token(Token = "0x6000754")]
		[Address(RVA = "0x1B47B80", Offset = "0x1B47B80", VA = "0x1B47B80")]
		public bool ContainsInclusive(Point2D p, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000755")]
		[Address(RVA = "0x1B47C20", Offset = "0x1B47C20", VA = "0x1B47C20")]
		public bool ContainsInclusive(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000756")]
		[Address(RVA = "0x1B47C7C", Offset = "0x1B47C7C", VA = "0x1B47C7C")]
		public bool ContainsInclusive(Rect2D r, double epsilon)
		{
			return default(bool);
		}

		[Token(Token = "0x6000757")]
		[Address(RVA = "0x1B41E18", Offset = "0x1B41E18", VA = "0x1B41E18")]
		public bool Intersects(Rect2D r)
		{
			return default(bool);
		}

		[Token(Token = "0x6000758")]
		[Address(RVA = "0x1B47CE8", Offset = "0x1B47CE8", VA = "0x1B47CE8")]
		public Point2D GetCenter()
		{
			return null;
		}

		[Token(Token = "0x6000759")]
		[Address(RVA = "0x1B47D78", Offset = "0x1B47D78", VA = "0x1B47D78")]
		public bool IsNormalized()
		{
			return default(bool);
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0x1B4783C", Offset = "0x1B4783C", VA = "0x1B4783C")]
		public void Normalize()
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0x1B3ADE0", Offset = "0x1B3ADE0", VA = "0x1B3ADE0")]
		public void AddPoint(Point2D p)
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0x1B47D9C", Offset = "0x1B47D9C", VA = "0x1B47D9C")]
		public void Inflate(double w, double h)
		{
		}

		[Token(Token = "0x600075D")]
		[Address(RVA = "0x1B47DC0", Offset = "0x1B47DC0", VA = "0x1B47DC0")]
		public void Inflate(double left, double top, double right, double bottom)
		{
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0x1B47DE4", Offset = "0x1B47DE4", VA = "0x1B47DE4")]
		public void Offset(double w, double h)
		{
		}

		[Token(Token = "0x600075F")]
		[Address(RVA = "0x1B47E00", Offset = "0x1B47E00", VA = "0x1B47E00")]
		public void SetPosition(double x, double y)
		{
		}

		[Token(Token = "0x6000760")]
		[Address(RVA = "0x1B47E2C", Offset = "0x1B47E2C", VA = "0x1B47E2C")]
		public bool Intersection(Rect2D r1, Rect2D r2)
		{
			return default(bool);
		}

		[Token(Token = "0x6000761")]
		[Address(RVA = "0x1B47F40", Offset = "0x1B47F40", VA = "0x1B47F40")]
		public void Union(Rect2D r1, Rect2D r2)
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20000B8")]
	public static class DOTweenModuleAudio
	{
		[Token(Token = "0x2000148")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD944", Offset = "0xADD944")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000602")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000971")]
			[Address(RVA = "0x14110A0", Offset = "0x14110A0", VA = "0x14110A0")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000972")]
			[Address(RVA = "0x1411848", Offset = "0x1411848", VA = "0x1411848")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000973")]
			[Address(RVA = "0x1411864", Offset = "0x1411864", VA = "0x1411864")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000149")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD954", Offset = "0xADD954")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000603")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioSource target;

			[Token(Token = "0x6000974")]
			[Address(RVA = "0x14111D8", Offset = "0x14111D8", VA = "0x14111D8")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000975")]
			[Address(RVA = "0x1411880", Offset = "0x1411880", VA = "0x1411880")]
			internal float <DOPitch>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000976")]
			[Address(RVA = "0x141189C", Offset = "0x141189C", VA = "0x141189C")]
			internal void <DOPitch>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200014A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD964", Offset = "0xADD964")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000604")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public AudioMixer target;

			[Token(Token = "0x4000605")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string floatName;

			[Token(Token = "0x6000977")]
			[Address(RVA = "0x1411314", Offset = "0x1411314", VA = "0x1411314")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0x14118B8", Offset = "0x14118B8", VA = "0x14118B8")]
			internal float <DOSetFloat>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0x14118F8", Offset = "0x14118F8", VA = "0x14118F8")]
			internal void <DOSetFloat>b__1(float x)
			{
			}
		}

		[Token(Token = "0x6000762")]
		[Address(RVA = "0x1410F48", Offset = "0x1410F48", VA = "0x1410F48")]
		public static Tweener DOFade(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x14110A8", Offset = "0x14110A8", VA = "0x14110A8")]
		public static Tweener DOPitch(this AudioSource target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x14111E0", Offset = "0x14111E0", VA = "0x14111E0")]
		public static Tweener DOSetFloat(this AudioMixer target, string floatName, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x141131C", Offset = "0x141131C", VA = "0x141131C")]
		public static int DOComplete(this AudioMixer target, bool withCallbacks = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x1411394", Offset = "0x1411394", VA = "0x1411394")]
		public static int DOKill(this AudioMixer target, bool complete = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x141140C", Offset = "0x141140C", VA = "0x141140C")]
		public static int DOFlip(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1411474", Offset = "0x1411474", VA = "0x1411474")]
		public static int DOGoto(this AudioMixer target, float to, bool andPlay = false)
		{
			return default(int);
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x14114FC", Offset = "0x14114FC", VA = "0x14114FC")]
		public static int DOPause(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076A")]
		[Address(RVA = "0x1411564", Offset = "0x1411564", VA = "0x1411564")]
		public static int DOPlay(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076B")]
		[Address(RVA = "0x14115CC", Offset = "0x14115CC", VA = "0x14115CC")]
		public static int DOPlayBackwards(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0x1411634", Offset = "0x1411634", VA = "0x1411634")]
		public static int DOPlayForward(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x141169C", Offset = "0x141169C", VA = "0x141169C")]
		public static int DORestart(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x141170C", Offset = "0x141170C", VA = "0x141170C")]
		public static int DORewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x1411778", Offset = "0x1411778", VA = "0x1411778")]
		public static int DOSmoothRewind(this AudioMixer target)
		{
			return default(int);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x14117E0", Offset = "0x14117E0", VA = "0x14117E0")]
		public static int DOTogglePause(this AudioMixer target)
		{
			return default(int);
		}
	}
	[Token(Token = "0x20000B9")]
	public static class DOTweenModulePhysics
	{
		[Token(Token = "0x200014B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD974", Offset = "0xADD974")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000606")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600097A")]
			[Address(RVA = "0x1411A80", Offset = "0x1411A80", VA = "0x1411A80")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0x1412E04", Offset = "0x1412E04", VA = "0x1412E04")]
			internal Vector3 <DOMove>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD984", Offset = "0xADD984")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600097C")]
			[Address(RVA = "0x1411C08", Offset = "0x1411C08", VA = "0x1411C08")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0x1412F40", Offset = "0x1412F40", VA = "0x1412F40")]
			internal Vector3 <DOMoveX>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD994", Offset = "0xADD994")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600097E")]
			[Address(RVA = "0x1411D90", Offset = "0x1411D90", VA = "0x1411D90")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0x1412F5C", Offset = "0x1412F5C", VA = "0x1412F5C")]
			internal Vector3 <DOMoveY>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9A4", Offset = "0xADD9A4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000980")]
			[Address(RVA = "0x1411F18", Offset = "0x1411F18", VA = "0x1411F18")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0x1412F78", Offset = "0x1412F78", VA = "0x1412F78")]
			internal Vector3 <DOMoveZ>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x200014F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9B4", Offset = "0xADD9B4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000982")]
			[Address(RVA = "0x141208C", Offset = "0x141208C", VA = "0x141208C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000983")]
			[Address(RVA = "0x1412F94", Offset = "0x1412F94", VA = "0x1412F94")]
			internal Quaternion <DORotate>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000150")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9C4", Offset = "0xADD9C4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000984")]
			[Address(RVA = "0x1412278", Offset = "0x1412278", VA = "0x1412278")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x6000985")]
			[Address(RVA = "0x1412FB0", Offset = "0x1412FB0", VA = "0x1412FB0")]
			internal Quaternion <DOLookAt>b__0()
			{
				return default(Quaternion);
			}
		}

		[Token(Token = "0x2000151")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9D4", Offset = "0xADD9D4")]
		private sealed class <>c__DisplayClass6_0
		{
			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector3 endValue;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Tween yTween;

			[Token(Token = "0x6000986")]
			[Address(RVA = "0x14126F4", Offset = "0x14126F4", VA = "0x14126F4")]
			public <>c__DisplayClass6_0()
			{
			}

			[Token(Token = "0x6000987")]
			[Address(RVA = "0x1412FCC", Offset = "0x1412FCC", VA = "0x1412FCC")]
			internal Vector3 <DOJump>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000988")]
			[Address(RVA = "0x1412FE8", Offset = "0x1412FE8", VA = "0x1412FE8")]
			internal void <DOJump>b__1()
			{
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0x141301C", Offset = "0x141301C", VA = "0x141301C")]
			internal Vector3 <DOJump>b__2()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0x1413038", Offset = "0x1413038", VA = "0x1413038")]
			internal Vector3 <DOJump>b__3()
			{
				return default(Vector3);
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0x1413054", Offset = "0x1413054", VA = "0x1413054")]
			internal void <DOJump>b__4()
			{
			}
		}

		[Token(Token = "0x2000152")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9E4", Offset = "0xADD9E4")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x600098C")]
			[Address(RVA = "0x14128E8", Offset = "0x14128E8", VA = "0x14128E8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1413114", Offset = "0x1413114", VA = "0x1413114")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000153")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADD9F4", Offset = "0xADD9F4")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x600098E")]
			[Address(RVA = "0x1412AF0", Offset = "0x1412AF0", VA = "0x1412AF0")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0x1413130", Offset = "0x1413130", VA = "0x1413130")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0x141314C", Offset = "0x141314C", VA = "0x141314C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000154")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA04", Offset = "0xADDA04")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody target;

			[Token(Token = "0x6000991")]
			[Address(RVA = "0x1412C70", Offset = "0x1412C70", VA = "0x1412C70")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6000992")]
			[Address(RVA = "0x1413250", Offset = "0x1413250", VA = "0x1413250")]
			internal Vector3 <DOPath>b__0()
			{
				return default(Vector3);
			}
		}

		[Token(Token = "0x2000155")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA14", Offset = "0xADDA14")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000617")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Transform trans;

			[Token(Token = "0x4000618")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Rigidbody target;

			[Token(Token = "0x6000993")]
			[Address(RVA = "0x1412DFC", Offset = "0x1412DFC", VA = "0x1412DFC")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x6000994")]
			[Address(RVA = "0x1412E20", Offset = "0x1412E20", VA = "0x1412E20")]
			internal Vector3 <DOLocalPath>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000995")]
			[Address(RVA = "0x1412E3C", Offset = "0x1412E3C", VA = "0x1412E3C")]
			internal void <DOLocalPath>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x141191C", Offset = "0x141191C", VA = "0x141191C")]
		public static Tweener DOMove(this Rigidbody target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x1411A88", Offset = "0x1411A88", VA = "0x1411A88")]
		public static Tweener DOMoveX(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x1411C10", Offset = "0x1411C10", VA = "0x1411C10")]
		public static Tweener DOMoveY(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x1411D98", Offset = "0x1411D98", VA = "0x1411D98")]
		public static Tweener DOMoveZ(this Rigidbody target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x1411F20", Offset = "0x1411F20", VA = "0x1411F20")]
		public static Tweener DORotate(this Rigidbody target, Vector3 endValue, float duration, RotateMode mode = RotateMode.Fast)
		{
			return null;
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0x1412094", Offset = "0x1412094", VA = "0x1412094")]
		public static Tweener DOLookAt(this Rigidbody target, Vector3 towards, float duration, AxisConstraint axisConstraint = AxisConstraint.None, [Optional] Vector3? up)
		{
			return null;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x1412280", Offset = "0x1412280", VA = "0x1412280")]
		public static Sequence DOJump(this Rigidbody target, Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0x14126FC", Offset = "0x14126FC", VA = "0x14126FC")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] UnityEngine.Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0x14128F0", Offset = "0x14128F0", VA = "0x14128F0")]
		public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, Vector3[] path, float duration, PathType pathType = PathType.Linear, PathMode pathMode = PathMode.Full3D, int resolution = 10, [Optional] UnityEngine.Color? gizmoColor)
		{
			return null;
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0x1412AF8", Offset = "0x1412AF8", VA = "0x1412AF8")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}

		[Token(Token = "0x600077B")]
		[Address(RVA = "0x1412C78", Offset = "0x1412C78", VA = "0x1412C78")]
		internal static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> DOLocalPath(this Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode = PathMode.Full3D)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BA")]
	public static class DOTweenModulePhysics2D
	{
		[Token(Token = "0x2000156")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA24", Offset = "0xADDA24")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000619")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000996")]
			[Address(RVA = "0x14133C8", Offset = "0x14133C8", VA = "0x14133C8")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000997")]
			[Address(RVA = "0x1413B74", Offset = "0x1413B74", VA = "0x1413B74")]
			internal Vector2 <DOMove>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000157")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA34", Offset = "0xADDA34")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x400061A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x6000998")]
			[Address(RVA = "0x141353C", Offset = "0x141353C", VA = "0x141353C")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x6000999")]
			[Address(RVA = "0x1413B90", Offset = "0x1413B90", VA = "0x1413B90")]
			internal Vector2 <DOMoveX>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000158")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA44", Offset = "0xADDA44")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600099A")]
			[Address(RVA = "0x14136B0", Offset = "0x14136B0", VA = "0x14136B0")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x600099B")]
			[Address(RVA = "0x1413BAC", Offset = "0x1413BAC", VA = "0x1413BAC")]
			internal Vector2 <DOMoveY>b__0()
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x2000159")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA54", Offset = "0xADDA54")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x600099C")]
			[Address(RVA = "0x14137EC", Offset = "0x14137EC", VA = "0x14137EC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x600099D")]
			[Address(RVA = "0x1413BC8", Offset = "0x1413BC8", VA = "0x1413BC8")]
			internal float <DORotate>b__0()
			{
				return default(float);
			}
		}

		[Token(Token = "0x200015A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA64", Offset = "0xADDA64")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Rigidbody2D target;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000621")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000622")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x4000623")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Tween yTween;

			[Token(Token = "0x600099E")]
			[Address(RVA = "0x1413B6C", Offset = "0x1413B6C", VA = "0x1413B6C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x600099F")]
			[Address(RVA = "0x1413BE4", Offset = "0x1413BE4", VA = "0x1413BE4")]
			internal Vector2 <DOJump>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009A0")]
			[Address(RVA = "0x1413C00", Offset = "0x1413C00", VA = "0x1413C00")]
			internal void <DOJump>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x60009A1")]
			[Address(RVA = "0x1413C1C", Offset = "0x1413C1C", VA = "0x1413C1C")]
			internal void <DOJump>b__2()
			{
			}

			[Token(Token = "0x60009A2")]
			[Address(RVA = "0x1413C50", Offset = "0x1413C50", VA = "0x1413C50")]
			internal Vector2 <DOJump>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009A3")]
			[Address(RVA = "0x1413C6C", Offset = "0x1413C6C", VA = "0x1413C6C")]
			internal void <DOJump>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x60009A4")]
			[Address(RVA = "0x1413C88", Offset = "0x1413C88", VA = "0x1413C88")]
			internal void <DOJump>b__5()
			{
			}
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0x141326C", Offset = "0x141326C", VA = "0x141326C")]
		public static Tweener DOMove(this Rigidbody2D target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600077D")]
		[Address(RVA = "0x14133D0", Offset = "0x14133D0", VA = "0x14133D0")]
		public static Tweener DOMoveX(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600077E")]
		[Address(RVA = "0x1413544", Offset = "0x1413544", VA = "0x1413544")]
		public static Tweener DOMoveY(this Rigidbody2D target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600077F")]
		[Address(RVA = "0x14136B8", Offset = "0x14136B8", VA = "0x14136B8")]
		public static Tweener DORotate(this Rigidbody2D target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000780")]
		[Address(RVA = "0x14137F4", Offset = "0x14137F4", VA = "0x14137F4")]
		public static Sequence DOJump(this Rigidbody2D target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BB")]
	public static class DOTweenModuleSprite
	{
		[Token(Token = "0x200015B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA74", Offset = "0xADDA74")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000624")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009A5")]
			[Address(RVA = "0x1413F08", Offset = "0x1413F08", VA = "0x1413F08")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009A6")]
			[Address(RVA = "0x14143F4", Offset = "0x14143F4", VA = "0x14143F4")]
			internal UnityEngine.Color <DOColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009A7")]
			[Address(RVA = "0x1414410", Offset = "0x1414410", VA = "0x1414410")]
			internal void <DOColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x200015C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA84", Offset = "0xADDA84")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000625")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public SpriteRenderer target;

			[Token(Token = "0x60009A8")]
			[Address(RVA = "0x1414040", Offset = "0x1414040", VA = "0x1414040")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009A9")]
			[Address(RVA = "0x141442C", Offset = "0x141442C", VA = "0x141442C")]
			internal UnityEngine.Color <DOFade>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009AA")]
			[Address(RVA = "0x1414448", Offset = "0x1414448", VA = "0x1414448")]
			internal void <DOFade>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x200015D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDA94", Offset = "0xADDA94")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000626")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Color to;

			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SpriteRenderer target;

			[Token(Token = "0x60009AB")]
			[Address(RVA = "0x14143EC", Offset = "0x14143EC", VA = "0x14143EC")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009AC")]
			[Address(RVA = "0x1414464", Offset = "0x1414464", VA = "0x1414464")]
			internal UnityEngine.Color <DOBlendableColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009AD")]
			[Address(RVA = "0x1414470", Offset = "0x1414470", VA = "0x1414470")]
			internal void <DOBlendableColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x1413DB0", Offset = "0x1413DB0", VA = "0x1413DB0")]
		public static Tweener DOColor(this SpriteRenderer target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x1413F10", Offset = "0x1413F10", VA = "0x1413F10")]
		public static Tweener DOFade(this SpriteRenderer target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x1414048", Offset = "0x1414048", VA = "0x1414048")]
		public static Sequence DOGradientColor(this SpriteRenderer target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000784")]
		[Address(RVA = "0x1414208", Offset = "0x1414208", VA = "0x1414208")]
		public static Tweener DOBlendableColor(this SpriteRenderer target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BC")]
	public static class DOTweenModuleUI
	{
		[Token(Token = "0x200015E")]
		public static class Utils
		{
			[Token(Token = "0x60009AE")]
			[Address(RVA = "0x141919C", Offset = "0x141919C", VA = "0x141919C")]
			public static Vector2 SwitchToRectTransform(RectTransform from, RectTransform to)
			{
				return default(Vector2);
			}
		}

		[Token(Token = "0x200015F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAA4", Offset = "0xADDAA4")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public CanvasGroup target;

			[Token(Token = "0x60009AF")]
			[Address(RVA = "0x141464C", Offset = "0x141464C", VA = "0x141464C")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x60009B0")]
			[Address(RVA = "0x1418058", Offset = "0x1418058", VA = "0x1418058")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009B1")]
			[Address(RVA = "0x1418074", Offset = "0x1418074", VA = "0x1418074")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000160")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAB4", Offset = "0xADDAB4")]
		private sealed class <>c__DisplayClass1_0
		{
			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60009B2")]
			[Address(RVA = "0x14147AC", Offset = "0x14147AC", VA = "0x14147AC")]
			public <>c__DisplayClass1_0()
			{
			}

			[Token(Token = "0x60009B3")]
			[Address(RVA = "0x14182C8", Offset = "0x14182C8", VA = "0x14182C8")]
			internal UnityEngine.Color <DOColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009B4")]
			[Address(RVA = "0x14182EC", Offset = "0x14182EC", VA = "0x14182EC")]
			internal void <DOColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000161")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAC4", Offset = "0xADDAC4")]
		private sealed class <>c__DisplayClass2_0
		{
			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Graphic target;

			[Token(Token = "0x60009B5")]
			[Address(RVA = "0x14148E4", Offset = "0x14148E4", VA = "0x14148E4")]
			public <>c__DisplayClass2_0()
			{
			}

			[Token(Token = "0x60009B6")]
			[Address(RVA = "0x1418954", Offset = "0x1418954", VA = "0x1418954")]
			internal UnityEngine.Color <DOFade>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009B7")]
			[Address(RVA = "0x1418978", Offset = "0x1418978", VA = "0x1418978")]
			internal void <DOFade>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000162")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAD4", Offset = "0xADDAD4")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.UI.Image target;

			[Token(Token = "0x60009B8")]
			[Address(RVA = "0x1414A44", Offset = "0x1414A44", VA = "0x1414A44")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x60009B9")]
			[Address(RVA = "0x1418E40", Offset = "0x1418E40", VA = "0x1418E40")]
			internal UnityEngine.Color <DOColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009BA")]
			[Address(RVA = "0x1418E64", Offset = "0x1418E64", VA = "0x1418E64")]
			internal void <DOColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000163")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAE4", Offset = "0xADDAE4")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.UI.Image target;

			[Token(Token = "0x60009BB")]
			[Address(RVA = "0x1414B7C", Offset = "0x1414B7C", VA = "0x1414B7C")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60009BC")]
			[Address(RVA = "0x1418E88", Offset = "0x1418E88", VA = "0x1418E88")]
			internal UnityEngine.Color <DOFade>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009BD")]
			[Address(RVA = "0x1418EAC", Offset = "0x1418EAC", VA = "0x1418EAC")]
			internal void <DOFade>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000164")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDAF4", Offset = "0xADDAF4")]
		private sealed class <>c__DisplayClass5_0
		{
			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.UI.Image target;

			[Token(Token = "0x60009BE")]
			[Address(RVA = "0x1414CD8", Offset = "0x1414CD8", VA = "0x1414CD8")]
			public <>c__DisplayClass5_0()
			{
			}

			[Token(Token = "0x60009BF")]
			[Address(RVA = "0x1418ED0", Offset = "0x1418ED0", VA = "0x1418ED0")]
			internal float <DOFillAmount>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x60009C0")]
			[Address(RVA = "0x1418EEC", Offset = "0x1418EEC", VA = "0x1418EEC")]
			internal void <DOFillAmount>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000165")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB04", Offset = "0xADDB04")]
		private sealed class <>c__DisplayClass7_0
		{
			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009C1")]
			[Address(RVA = "0x1414FF8", Offset = "0x1414FF8", VA = "0x1414FF8")]
			public <>c__DisplayClass7_0()
			{
			}

			[Token(Token = "0x60009C2")]
			[Address(RVA = "0x1418F08", Offset = "0x1418F08", VA = "0x1418F08")]
			internal Vector2 <DOFlexibleSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009C3")]
			[Address(RVA = "0x1418F88", Offset = "0x1418F88", VA = "0x1418F88")]
			internal void <DOFlexibleSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000166")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB14", Offset = "0xADDB14")]
		private sealed class <>c__DisplayClass8_0
		{
			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009C4")]
			[Address(RVA = "0x1415150", Offset = "0x1415150", VA = "0x1415150")]
			public <>c__DisplayClass8_0()
			{
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0x1418FE4", Offset = "0x1418FE4", VA = "0x1418FE4")]
			internal Vector2 <DOMinSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0x1419064", Offset = "0x1419064", VA = "0x1419064")]
			internal void <DOMinSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000167")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB24", Offset = "0xADDB24")]
		private sealed class <>c__DisplayClass9_0
		{
			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LayoutElement target;

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0x14152A8", Offset = "0x14152A8", VA = "0x14152A8")]
			public <>c__DisplayClass9_0()
			{
			}

			[Token(Token = "0x60009C8")]
			[Address(RVA = "0x14190C0", Offset = "0x14190C0", VA = "0x14190C0")]
			internal Vector2 <DOPreferredSize>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0x1419140", Offset = "0x1419140", VA = "0x1419140")]
			internal void <DOPreferredSize>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000168")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB34", Offset = "0xADDB34")]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60009CA")]
			[Address(RVA = "0x1415408", Offset = "0x1415408", VA = "0x1415408")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60009CB")]
			[Address(RVA = "0x1418090", Offset = "0x1418090", VA = "0x1418090")]
			internal UnityEngine.Color <DOColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009CC")]
			[Address(RVA = "0x14180B0", Offset = "0x14180B0", VA = "0x14180B0")]
			internal void <DOColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000169")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB44", Offset = "0xADDB44")]
		private sealed class <>c__DisplayClass11_0
		{
			[Token(Token = "0x4000632")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60009CD")]
			[Address(RVA = "0x1415540", Offset = "0x1415540", VA = "0x1415540")]
			public <>c__DisplayClass11_0()
			{
			}

			[Token(Token = "0x60009CE")]
			[Address(RVA = "0x14180CC", Offset = "0x14180CC", VA = "0x14180CC")]
			internal UnityEngine.Color <DOFade>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x60009CF")]
			[Address(RVA = "0x14180EC", Offset = "0x14180EC", VA = "0x14180EC")]
			internal void <DOFade>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x200016A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB54", Offset = "0xADDB54")]
		private sealed class <>c__DisplayClass12_0
		{
			[Token(Token = "0x4000633")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Outline target;

			[Token(Token = "0x60009D0")]
			[Address(RVA = "0x1415688", Offset = "0x1415688", VA = "0x1415688")]
			public <>c__DisplayClass12_0()
			{
			}

			[Token(Token = "0x60009D1")]
			[Address(RVA = "0x1418108", Offset = "0x1418108", VA = "0x1418108")]
			internal Vector2 <DOScale>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0x1418124", Offset = "0x1418124", VA = "0x1418124")]
			internal void <DOScale>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB64", Offset = "0xADDB64")]
		private sealed class <>c__DisplayClass13_0
		{
			[Token(Token = "0x4000634")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0x14157E0", Offset = "0x14157E0", VA = "0x14157E0")]
			public <>c__DisplayClass13_0()
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0x1418140", Offset = "0x1418140", VA = "0x1418140")]
			internal Vector2 <DOAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009D5")]
			[Address(RVA = "0x141815C", Offset = "0x141815C", VA = "0x141815C")]
			internal void <DOAnchorPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB74", Offset = "0xADDB74")]
		private sealed class <>c__DisplayClass14_0
		{
			[Token(Token = "0x4000635")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0x1415950", Offset = "0x1415950", VA = "0x1415950")]
			public <>c__DisplayClass14_0()
			{
			}

			[Token(Token = "0x60009D7")]
			[Address(RVA = "0x1418178", Offset = "0x1418178", VA = "0x1418178")]
			internal Vector2 <DOAnchorPosX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009D8")]
			[Address(RVA = "0x1418194", Offset = "0x1418194", VA = "0x1418194")]
			internal void <DOAnchorPosX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB84", Offset = "0xADDB84")]
		private sealed class <>c__DisplayClass15_0
		{
			[Token(Token = "0x4000636")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009D9")]
			[Address(RVA = "0x1415AC0", Offset = "0x1415AC0", VA = "0x1415AC0")]
			public <>c__DisplayClass15_0()
			{
			}

			[Token(Token = "0x60009DA")]
			[Address(RVA = "0x14181B0", Offset = "0x14181B0", VA = "0x14181B0")]
			internal Vector2 <DOAnchorPosY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009DB")]
			[Address(RVA = "0x14181CC", Offset = "0x14181CC", VA = "0x14181CC")]
			internal void <DOAnchorPosY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200016E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDB94", Offset = "0xADDB94")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000637")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009DC")]
			[Address(RVA = "0x1415C20", Offset = "0x1415C20", VA = "0x1415C20")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x60009DD")]
			[Address(RVA = "0x14181E8", Offset = "0x14181E8", VA = "0x14181E8")]
			internal Vector3 <DOAnchorPos3D>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009DE")]
			[Address(RVA = "0x1418204", Offset = "0x1418204", VA = "0x1418204")]
			internal void <DOAnchorPos3D>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200016F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBA4", Offset = "0xADDBA4")]
		private sealed class <>c__DisplayClass17_0
		{
			[Token(Token = "0x4000638")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0x1415D9C", Offset = "0x1415D9C", VA = "0x1415D9C")]
			public <>c__DisplayClass17_0()
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0x1418220", Offset = "0x1418220", VA = "0x1418220")]
			internal Vector3 <DOAnchorPos3DX>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0x141823C", Offset = "0x141823C", VA = "0x141823C")]
			internal void <DOAnchorPos3DX>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000170")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBB4", Offset = "0xADDBB4")]
		private sealed class <>c__DisplayClass18_0
		{
			[Token(Token = "0x4000639")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009E2")]
			[Address(RVA = "0x1415F18", Offset = "0x1415F18", VA = "0x1415F18")]
			public <>c__DisplayClass18_0()
			{
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0x1418258", Offset = "0x1418258", VA = "0x1418258")]
			internal Vector3 <DOAnchorPos3DY>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E4")]
			[Address(RVA = "0x1418274", Offset = "0x1418274", VA = "0x1418274")]
			internal void <DOAnchorPos3DY>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000171")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBC4", Offset = "0xADDBC4")]
		private sealed class <>c__DisplayClass19_0
		{
			[Token(Token = "0x400063A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009E5")]
			[Address(RVA = "0x1416094", Offset = "0x1416094", VA = "0x1416094")]
			public <>c__DisplayClass19_0()
			{
			}

			[Token(Token = "0x60009E6")]
			[Address(RVA = "0x1418290", Offset = "0x1418290", VA = "0x1418290")]
			internal Vector3 <DOAnchorPos3DZ>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009E7")]
			[Address(RVA = "0x14182AC", Offset = "0x14182AC", VA = "0x14182AC")]
			internal void <DOAnchorPos3DZ>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000172")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBD4", Offset = "0xADDBD4")]
		private sealed class <>c__DisplayClass20_0
		{
			[Token(Token = "0x400063B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009E8")]
			[Address(RVA = "0x14161EC", Offset = "0x14161EC", VA = "0x14161EC")]
			public <>c__DisplayClass20_0()
			{
			}

			[Token(Token = "0x60009E9")]
			[Address(RVA = "0x1418310", Offset = "0x1418310", VA = "0x1418310")]
			internal Vector2 <DOAnchorMax>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009EA")]
			[Address(RVA = "0x141832C", Offset = "0x141832C", VA = "0x141832C")]
			internal void <DOAnchorMax>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000173")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBE4", Offset = "0xADDBE4")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x400063C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009EB")]
			[Address(RVA = "0x1416344", Offset = "0x1416344", VA = "0x1416344")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0x1418348", Offset = "0x1418348", VA = "0x1418348")]
			internal Vector2 <DOAnchorMin>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0x1418364", Offset = "0x1418364", VA = "0x1418364")]
			internal void <DOAnchorMin>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000174")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDBF4", Offset = "0xADDBF4")]
		private sealed class <>c__DisplayClass22_0
		{
			[Token(Token = "0x400063D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0x141648C", Offset = "0x141648C", VA = "0x141648C")]
			public <>c__DisplayClass22_0()
			{
			}

			[Token(Token = "0x60009EF")]
			[Address(RVA = "0x1418380", Offset = "0x1418380", VA = "0x1418380")]
			internal Vector2 <DOPivot>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0x141839C", Offset = "0x141839C", VA = "0x141839C")]
			internal void <DOPivot>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC04", Offset = "0xADDC04")]
		private sealed class <>c__DisplayClass23_0
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009F1")]
			[Address(RVA = "0x14165F0", Offset = "0x14165F0", VA = "0x14165F0")]
			public <>c__DisplayClass23_0()
			{
			}

			[Token(Token = "0x60009F2")]
			[Address(RVA = "0x14183B8", Offset = "0x14183B8", VA = "0x14183B8")]
			internal Vector2 <DOPivotX>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009F3")]
			[Address(RVA = "0x14183D4", Offset = "0x14183D4", VA = "0x14183D4")]
			internal void <DOPivotX>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000176")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC14", Offset = "0xADDC14")]
		private sealed class <>c__DisplayClass24_0
		{
			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009F4")]
			[Address(RVA = "0x1416754", Offset = "0x1416754", VA = "0x1416754")]
			public <>c__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60009F5")]
			[Address(RVA = "0x14183F0", Offset = "0x14183F0", VA = "0x14183F0")]
			internal Vector2 <DOPivotY>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009F6")]
			[Address(RVA = "0x141840C", Offset = "0x141840C", VA = "0x141840C")]
			internal void <DOPivotY>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000177")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC24", Offset = "0xADDC24")]
		private sealed class <>c__DisplayClass25_0
		{
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009F7")]
			[Address(RVA = "0x14168AC", Offset = "0x14168AC", VA = "0x14168AC")]
			public <>c__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60009F8")]
			[Address(RVA = "0x1418428", Offset = "0x1418428", VA = "0x1418428")]
			internal Vector2 <DOSizeDelta>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0x1418444", Offset = "0x1418444", VA = "0x1418444")]
			internal void <DOSizeDelta>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x2000178")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC34", Offset = "0xADDC34")]
		private sealed class <>c__DisplayClass26_0
		{
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0x1416A64", Offset = "0x1416A64", VA = "0x1416A64")]
			public <>c__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0x1418460", Offset = "0x1418460", VA = "0x1418460")]
			internal Vector3 <DOPunchAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0x14184F0", Offset = "0x14184F0", VA = "0x14184F0")]
			internal void <DOPunchAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x2000179")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC44", Offset = "0xADDC44")]
		private sealed class <>c__DisplayClass27_0
		{
			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0x1416BEC", Offset = "0x1416BEC", VA = "0x1416BEC")]
			public <>c__DisplayClass27_0()
			{
			}

			[Token(Token = "0x60009FE")]
			[Address(RVA = "0x1418594", Offset = "0x1418594", VA = "0x1418594")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0x1418624", Offset = "0x1418624", VA = "0x1418624")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200017A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC54", Offset = "0xADDC54")]
		private sealed class <>c__DisplayClass28_0
		{
			[Token(Token = "0x4000643")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x6000A00")]
			[Address(RVA = "0x1416DC0", Offset = "0x1416DC0", VA = "0x1416DC0")]
			public <>c__DisplayClass28_0()
			{
			}

			[Token(Token = "0x6000A01")]
			[Address(RVA = "0x14186C8", Offset = "0x14186C8", VA = "0x14186C8")]
			internal Vector3 <DOShakeAnchorPos>b__0()
			{
				return default(Vector3);
			}

			[Token(Token = "0x6000A02")]
			[Address(RVA = "0x1418758", Offset = "0x1418758", VA = "0x1418758")]
			internal void <DOShakeAnchorPos>b__1(Vector3 x)
			{
			}
		}

		[Token(Token = "0x200017B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC64", Offset = "0xADDC64")]
		private sealed class <>c__DisplayClass29_0
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public RectTransform target;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float startPosY;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public bool offsetYSet;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float offsetY;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Sequence s;

			[Token(Token = "0x4000649")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Vector2 endValue;

			[Token(Token = "0x6000A03")]
			[Address(RVA = "0x1417144", Offset = "0x1417144", VA = "0x1417144")]
			public <>c__DisplayClass29_0()
			{
			}

			[Token(Token = "0x6000A04")]
			[Address(RVA = "0x14187FC", Offset = "0x14187FC", VA = "0x14187FC")]
			internal Vector2 <DOJumpAnchorPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A05")]
			[Address(RVA = "0x1418818", Offset = "0x1418818", VA = "0x1418818")]
			internal void <DOJumpAnchorPos>b__1(Vector2 x)
			{
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0x1418834", Offset = "0x1418834", VA = "0x1418834")]
			internal void <DOJumpAnchorPos>b__2()
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0x1418868", Offset = "0x1418868", VA = "0x1418868")]
			internal Vector2 <DOJumpAnchorPos>b__3()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0x1418884", Offset = "0x1418884", VA = "0x1418884")]
			internal void <DOJumpAnchorPos>b__4(Vector2 x)
			{
			}

			[Token(Token = "0x6000A09")]
			[Address(RVA = "0x14188A0", Offset = "0x14188A0", VA = "0x14188A0")]
			internal void <DOJumpAnchorPos>b__5()
			{
			}
		}

		[Token(Token = "0x200017C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC74", Offset = "0xADDC74")]
		private sealed class <>c__DisplayClass30_0
		{
			[Token(Token = "0x400064A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0x141729C", Offset = "0x141729C", VA = "0x141729C")]
			public <>c__DisplayClass30_0()
			{
			}

			[Token(Token = "0x6000A0B")]
			[Address(RVA = "0x141899C", Offset = "0x141899C", VA = "0x141899C")]
			internal Vector2 <DONormalizedPos>b__0()
			{
				return default(Vector2);
			}

			[Token(Token = "0x6000A0C")]
			[Address(RVA = "0x1418A0C", Offset = "0x1418A0C", VA = "0x1418A0C")]
			internal void <DONormalizedPos>b__1(Vector2 x)
			{
			}
		}

		[Token(Token = "0x200017D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC84", Offset = "0xADDC84")]
		private sealed class <>c__DisplayClass31_0
		{
			[Token(Token = "0x400064B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A0D")]
			[Address(RVA = "0x14173E4", Offset = "0x14173E4", VA = "0x14173E4")]
			public <>c__DisplayClass31_0()
			{
			}

			[Token(Token = "0x6000A0E")]
			[Address(RVA = "0x1418A58", Offset = "0x1418A58", VA = "0x1418A58")]
			internal float <DOHorizontalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A0F")]
			[Address(RVA = "0x1418A74", Offset = "0x1418A74", VA = "0x1418A74")]
			internal void <DOHorizontalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDC94", Offset = "0xADDC94")]
		private sealed class <>c__DisplayClass32_0
		{
			[Token(Token = "0x400064C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public ScrollRect target;

			[Token(Token = "0x6000A10")]
			[Address(RVA = "0x141752C", Offset = "0x141752C", VA = "0x141752C")]
			public <>c__DisplayClass32_0()
			{
			}

			[Token(Token = "0x6000A11")]
			[Address(RVA = "0x1418A90", Offset = "0x1418A90", VA = "0x1418A90")]
			internal float <DOVerticalNormalizedPos>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A12")]
			[Address(RVA = "0x1418AAC", Offset = "0x1418AAC", VA = "0x1418AAC")]
			internal void <DOVerticalNormalizedPos>b__1(float x)
			{
			}
		}

		[Token(Token = "0x200017F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCA4", Offset = "0xADDCA4")]
		private sealed class <>c__DisplayClass33_0
		{
			[Token(Token = "0x400064D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Slider target;

			[Token(Token = "0x6000A13")]
			[Address(RVA = "0x1417674", Offset = "0x1417674", VA = "0x1417674")]
			public <>c__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6000A14")]
			[Address(RVA = "0x1418AC8", Offset = "0x1418AC8", VA = "0x1418AC8")]
			internal float <DOValue>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000A15")]
			[Address(RVA = "0x1418AEC", Offset = "0x1418AEC", VA = "0x1418AEC")]
			internal void <DOValue>b__1(float x)
			{
			}
		}

		[Token(Token = "0x2000180")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCB4", Offset = "0xADDCB4")]
		private sealed class <>c__DisplayClass34_0
		{
			[Token(Token = "0x400064E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A16")]
			[Address(RVA = "0x14177D4", Offset = "0x14177D4", VA = "0x14177D4")]
			public <>c__DisplayClass34_0()
			{
			}

			[Token(Token = "0x6000A17")]
			[Address(RVA = "0x1418B10", Offset = "0x1418B10", VA = "0x1418B10")]
			internal UnityEngine.Color <DOColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x6000A18")]
			[Address(RVA = "0x1418B34", Offset = "0x1418B34", VA = "0x1418B34")]
			internal void <DOColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000181")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCC4", Offset = "0xADDCC4")]
		private sealed class <>c__DisplayClass35_0
		{
			[Token(Token = "0x400064F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A19")]
			[Address(RVA = "0x141790C", Offset = "0x141790C", VA = "0x141790C")]
			public <>c__DisplayClass35_0()
			{
			}

			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0x1418B58", Offset = "0x1418B58", VA = "0x1418B58")]
			internal UnityEngine.Color <DOFade>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0x1418B7C", Offset = "0x1418B7C", VA = "0x1418B7C")]
			internal void <DOFade>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000182")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCD4", Offset = "0xADDCD4")]
		private sealed class <>c__DisplayClass36_0
		{
			[Token(Token = "0x4000650")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Text target;

			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0x1417A74", Offset = "0x1417A74", VA = "0x1417A74")]
			public <>c__DisplayClass36_0()
			{
			}

			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0x1418BA0", Offset = "0x1418BA0", VA = "0x1418BA0")]
			internal string <DOText>b__0()
			{
				return null;
			}

			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0x1418BC4", Offset = "0x1418BC4", VA = "0x1418BC4")]
			internal void <DOText>b__1(string x)
			{
			}
		}

		[Token(Token = "0x2000183")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCE4", Offset = "0xADDCE4")]
		private sealed class <>c__DisplayClass37_0
		{
			[Token(Token = "0x4000651")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Color to;

			[Token(Token = "0x4000652")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Graphic target;

			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0x1417C68", Offset = "0x1417C68", VA = "0x1417C68")]
			public <>c__DisplayClass37_0()
			{
			}

			[Token(Token = "0x6000A20")]
			[Address(RVA = "0x1418BE8", Offset = "0x1418BE8", VA = "0x1418BE8")]
			internal UnityEngine.Color <DOBlendableColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x6000A21")]
			[Address(RVA = "0x1418BF4", Offset = "0x1418BF4", VA = "0x1418BF4")]
			internal void <DOBlendableColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDCF4", Offset = "0xADDCF4")]
		private sealed class <>c__DisplayClass38_0
		{
			[Token(Token = "0x4000653")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Color to;

			[Token(Token = "0x4000654")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public UnityEngine.UI.Image target;

			[Token(Token = "0x6000A22")]
			[Address(RVA = "0x1417E5C", Offset = "0x1417E5C", VA = "0x1417E5C")]
			public <>c__DisplayClass38_0()
			{
			}

			[Token(Token = "0x6000A23")]
			[Address(RVA = "0x1418CB0", Offset = "0x1418CB0", VA = "0x1418CB0")]
			internal UnityEngine.Color <DOBlendableColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x6000A24")]
			[Address(RVA = "0x1418CBC", Offset = "0x1418CBC", VA = "0x1418CBC")]
			internal void <DOBlendableColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x2000185")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xADDD04", Offset = "0xADDD04")]
		private sealed class <>c__DisplayClass39_0
		{
			[Token(Token = "0x4000655")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public UnityEngine.Color to;

			[Token(Token = "0x4000656")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Text target;

			[Token(Token = "0x6000A25")]
			[Address(RVA = "0x1418050", Offset = "0x1418050", VA = "0x1418050")]
			public <>c__DisplayClass39_0()
			{
			}

			[Token(Token = "0x6000A26")]
			[Address(RVA = "0x1418D78", Offset = "0x1418D78", VA = "0x1418D78")]
			internal UnityEngine.Color <DOBlendableColor>b__0()
			{
				return default(UnityEngine.Color);
			}

			[Token(Token = "0x6000A27")]
			[Address(RVA = "0x1418D84", Offset = "0x1418D84", VA = "0x1418D84")]
			internal void <DOBlendableColor>b__1(UnityEngine.Color x)
			{
			}
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x141451C", Offset = "0x141451C", VA = "0x141451C")]
		public static Tweener DOFade(this CanvasGroup target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x1414654", Offset = "0x1414654", VA = "0x1414654")]
		public static Tweener DOColor(this Graphic target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x14147B4", Offset = "0x14147B4", VA = "0x14147B4")]
		public static Tweener DOFade(this Graphic target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x14148EC", Offset = "0x14148EC", VA = "0x14148EC")]
		public static Tweener DOColor(this UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x1414A4C", Offset = "0x1414A4C", VA = "0x1414A4C")]
		public static Tweener DOFade(this UnityEngine.UI.Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x1414B84", Offset = "0x1414B84", VA = "0x1414B84")]
		public static Tweener DOFillAmount(this UnityEngine.UI.Image target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x1414CE0", Offset = "0x1414CE0", VA = "0x1414CE0")]
		public static Sequence DOGradientColor(this UnityEngine.UI.Image target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x1414EA8", Offset = "0x1414EA8", VA = "0x1414EA8")]
		public static Tweener DOFlexibleSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x1415000", Offset = "0x1415000", VA = "0x1415000")]
		public static Tweener DOMinSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1415158", Offset = "0x1415158", VA = "0x1415158")]
		public static Tweener DOPreferredSize(this LayoutElement target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x14152B0", Offset = "0x14152B0", VA = "0x14152B0")]
		public static Tweener DOColor(this Outline target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1415410", Offset = "0x1415410", VA = "0x1415410")]
		public static Tweener DOFade(this Outline target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x1415548", Offset = "0x1415548", VA = "0x1415548")]
		public static Tweener DOScale(this Outline target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x1415690", Offset = "0x1415690", VA = "0x1415690")]
		public static Tweener DOAnchorPos(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x14157E8", Offset = "0x14157E8", VA = "0x14157E8")]
		public static Tweener DOAnchorPosX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1415958", Offset = "0x1415958", VA = "0x1415958")]
		public static Tweener DOAnchorPosY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x1415AC8", Offset = "0x1415AC8", VA = "0x1415AC8")]
		public static Tweener DOAnchorPos3D(this RectTransform target, Vector3 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1415C28", Offset = "0x1415C28", VA = "0x1415C28")]
		public static Tweener DOAnchorPos3DX(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1415DA4", Offset = "0x1415DA4", VA = "0x1415DA4")]
		public static Tweener DOAnchorPos3DY(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1415F20", Offset = "0x1415F20", VA = "0x1415F20")]
		public static Tweener DOAnchorPos3DZ(this RectTransform target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x141609C", Offset = "0x141609C", VA = "0x141609C")]
		public static Tweener DOAnchorMax(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x14161F4", Offset = "0x14161F4", VA = "0x14161F4")]
		public static Tweener DOAnchorMin(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x141634C", Offset = "0x141634C", VA = "0x141634C")]
		public static Tweener DOPivot(this RectTransform target, Vector2 endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x1416494", Offset = "0x1416494", VA = "0x1416494")]
		public static Tweener DOPivotX(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x14165F8", Offset = "0x14165F8", VA = "0x14165F8")]
		public static Tweener DOPivotY(this RectTransform target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x141675C", Offset = "0x141675C", VA = "0x141675C")]
		public static Tweener DOSizeDelta(this RectTransform target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x14168B4", Offset = "0x14168B4", VA = "0x14168B4")]
		public static Tweener DOPunchAnchorPos(this RectTransform target, Vector2 punch, float duration, int vibrato = 10, float elasticity = 1f, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x1416A6C", Offset = "0x1416A6C", VA = "0x1416A6C")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, float strength = 100f, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x1416BF4", Offset = "0x1416BF4", VA = "0x1416BF4")]
		public static Tweener DOShakeAnchorPos(this RectTransform target, float duration, Vector2 strength, int vibrato = 10, float randomness = 90f, bool snapping = false, bool fadeOut = true)
		{
			return null;
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x1416DC8", Offset = "0x1416DC8", VA = "0x1416DC8")]
		public static Sequence DOJumpAnchorPos(this RectTransform target, Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x141714C", Offset = "0x141714C", VA = "0x141714C")]
		public static Tweener DONormalizedPos(this ScrollRect target, Vector2 endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x14172A4", Offset = "0x14172A4", VA = "0x14172A4")]
		public static Tweener DOHorizontalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x14173EC", Offset = "0x14173EC", VA = "0x14173EC")]
		public static Tweener DOVerticalNormalizedPos(this ScrollRect target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x1417534", Offset = "0x1417534", VA = "0x1417534")]
		public static Tweener DOValue(this Slider target, float endValue, float duration, bool snapping = false)
		{
			return null;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x141767C", Offset = "0x141767C", VA = "0x141767C")]
		public static Tweener DOColor(this Text target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x14177DC", Offset = "0x14177DC", VA = "0x14177DC")]
		public static Tweener DOFade(this Text target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x1417914", Offset = "0x1417914", VA = "0x1417914")]
		public static Tweener DOText(this Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = ScrambleMode.None, [Optional] string scrambleChars)
		{
			return null;
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x1417A7C", Offset = "0x1417A7C", VA = "0x1417A7C")]
		public static Tweener DOBlendableColor(this Graphic target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x1417C70", Offset = "0x1417C70", VA = "0x1417C70")]
		public static Tweener DOBlendableColor(this UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x1417E64", Offset = "0x1417E64", VA = "0x1417E64")]
		public static Tweener DOBlendableColor(this Text target, UnityEngine.Color endValue, float duration)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BD")]
	public static class DOTweenModuleUnityVersion
	{
		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x1419448", Offset = "0x1419448", VA = "0x1419448")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x141960C", Offset = "0x141960C", VA = "0x141960C")]
		public static Sequence DOGradientColor(this Material target, Gradient gradient, string property, float duration)
		{
			return null;
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x14197E4", Offset = "0x14197E4", VA = "0x14197E4")]
		public static CustomYieldInstruction WaitForCompletion(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x1419888", Offset = "0x1419888", VA = "0x1419888")]
		public static CustomYieldInstruction WaitForRewind(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x141992C", Offset = "0x141992C", VA = "0x141992C")]
		public static CustomYieldInstruction WaitForKill(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x14199D0", Offset = "0x14199D0", VA = "0x14199D0")]
		public static CustomYieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x1419A84", Offset = "0x1419A84", VA = "0x1419A84")]
		public static CustomYieldInstruction WaitForPosition(this Tween t, float position, bool returnCustomYieldInstruction)
		{
			return null;
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x1419B38", Offset = "0x1419B38", VA = "0x1419B38")]
		public static CustomYieldInstruction WaitForStart(this Tween t, bool returnCustomYieldInstruction)
		{
			return null;
		}
	}
	[Token(Token = "0x20000BE")]
	public static class DOTweenCYInstruction
	{
		[Token(Token = "0x2000186")]
		public class WaitForCompletion : CustomYieldInstruction
		{
			[Token(Token = "0x4000657")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700012A")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A28")]
				[Address(RVA = "0x1410C88", Offset = "0x1410C88", VA = "0x1410C88", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x1410CBC", Offset = "0x1410CBC", VA = "0x1410CBC")]
			public WaitForCompletion(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000187")]
		public class WaitForRewind : CustomYieldInstruction
		{
			[Token(Token = "0x4000658")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700012B")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A2A")]
				[Address(RVA = "0x1410E58", Offset = "0x1410E58", VA = "0x1410E58", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x1410EBC", Offset = "0x1410EBC", VA = "0x1410EBC")]
			public WaitForRewind(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000188")]
		public class WaitForKill : CustomYieldInstruction
		{
			[Token(Token = "0x4000659")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700012C")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A2C")]
				[Address(RVA = "0x1410D70", Offset = "0x1410D70", VA = "0x1410D70", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x1410D8C", Offset = "0x1410D8C", VA = "0x1410D8C")]
			public WaitForKill(Tween tween)
			{
			}
		}

		[Token(Token = "0x2000189")]
		public class WaitForElapsedLoops : CustomYieldInstruction
		{
			[Token(Token = "0x400065A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400065B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly int elapsedLoops;

			[Token(Token = "0x1700012D")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A2E")]
				[Address(RVA = "0x1410CE8", Offset = "0x1410CE8", VA = "0x1410CE8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x1410D34", Offset = "0x1410D34", VA = "0x1410D34")]
			public WaitForElapsedLoops(Tween tween, int elapsedLoops)
			{
			}
		}

		[Token(Token = "0x200018A")]
		public class WaitForPosition : CustomYieldInstruction
		{
			[Token(Token = "0x400065C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x400065D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private readonly float position;

			[Token(Token = "0x1700012E")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A30")]
				[Address(RVA = "0x1410DB8", Offset = "0x1410DB8", VA = "0x1410DB8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A31")]
			[Address(RVA = "0x1410E1C", Offset = "0x1410E1C", VA = "0x1410E1C")]
			public WaitForPosition(Tween tween, float position)
			{
			}
		}

		[Token(Token = "0x200018B")]
		public class WaitForStart : CustomYieldInstruction
		{
			[Token(Token = "0x400065E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private readonly Tween t;

			[Token(Token = "0x1700012F")]
			public override bool keepWaiting
			{
				[Token(Token = "0x6000A32")]
				[Address(RVA = "0x1410EE8", Offset = "0x1410EE8", VA = "0x1410EE8", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x1410F1C", Offset = "0x1410F1C", VA = "0x1410F1C")]
			public WaitForStart(Tween tween)
			{
			}
		}
	}
	[Token(Token = "0x20000BF")]
	public static class DOTweenModuleUtils
	{
		[Token(Token = "0x200018C")]
		public static class Physics
		{
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x1419C80", Offset = "0x1419C80", VA = "0x1419C80")]
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans)
			{
			}

			[Token(Token = "0x6000A35")]
			[Address(RVA = "0x1419D88", Offset = "0x1419D88", VA = "0x1419D88")]
			public static bool HasRigidbody2D(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A36")]
			[Address(RVA = "0x1419E18", Offset = "0x1419E18", VA = "0x1419E18")]
			public static bool HasRigidbody(Component target)
			{
				return default(bool);
			}

			[Token(Token = "0x6000A37")]
			[Address(RVA = "0x1419EA8", Offset = "0x1419EA8", VA = "0x1419EA8")]
			public static TweenerCore<Vector3, DG.Tweening.Plugins.Core.PathCore.Path, PathOptions> CreateDOTweenPathTween(MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, PathMode pathMode)
			{
				return null;
			}
		}

		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool _initialized;

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x1419BDC", Offset = "0x1419BDC", VA = "0x1419BDC")]
		public static void Init()
		{
		}
	}
}
