using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class LightFlicker : MonoBehaviour
{
	[Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class <Flicker>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LightFlicker <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000008")]
			[Address(RVA = "0xAEBE70", Offset = "0xAEBE70", VA = "0xAEBE70", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000A")]
			[Address(RVA = "0xAEBEB8", Offset = "0xAEBEB8", VA = "0xAEBEB8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0xAEBD0C", Offset = "0xAEBD0C", VA = "0xAEBD0C")]
		[DebuggerHidden]
		public <Flicker>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0xAEBD3C", Offset = "0xAEBD3C", VA = "0xAEBD3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0xAEBD40", Offset = "0xAEBD40", VA = "0xAEBD40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0xAEBE78", Offset = "0xAEBE78", VA = "0xAEBE78", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float maximumDim;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float maximumBoost;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float strength;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool noFlicker;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Light source;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float initialIntensity;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0xAEBBFC", Offset = "0xAEBBFC", VA = "0xAEBBFC")]
	public void Reset()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0xAEBC0C", Offset = "0xAEBC0C", VA = "0xAEBC0C")]
	public void Start()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0xAEBC98", Offset = "0xAEBC98", VA = "0xAEBC98")]
	[IteratorStateMachine(typeof(<Flicker>d__9))]
	private IEnumerator Flicker()
	{
		return null;
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0xAEBD34", Offset = "0xAEBD34", VA = "0xAEBD34")]
	public LightFlicker()
	{
	}
}
[Token(Token = "0x2000004")]
public class MouseComponent : MonoBehaviour
{
	[Token(Token = "0x400000B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float mouseSensitivity;

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform playerBody;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float xRotation;

	[Token(Token = "0x600000B")]
	[Address(RVA = "0xAEBEC0", Offset = "0xAEBEC0", VA = "0xAEBEC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0xAEBECC", Offset = "0xAEBECC", VA = "0xAEBECC")]
	private void Update()
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0xAEC04C", Offset = "0xAEC04C", VA = "0xAEC04C")]
	public MouseComponent()
	{
	}
}
[Token(Token = "0x2000005")]
public class PlayerMovement : MonoBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CharacterController controller;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float speed;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float gravity;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float jumpHeight;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform groundCheck;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float groundDistance;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LayerMask groundMask;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Vector3 velocity;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool isGrounded;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AudioClip footStepSound;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public float footStepDelay;

	[Token(Token = "0x4000019")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float nextFootstep;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0xAEC05C", Offset = "0xAEC05C", VA = "0xAEC05C")]
	private void Update()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0xAEC348", Offset = "0xAEC348", VA = "0xAEC348")]
	public PlayerMovement()
	{
	}
}
[Token(Token = "0x2000006")]
public class PlayRandomSound : MonoBehaviour
{
	[Token(Token = "0x400001A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource randomSound;

	[Token(Token = "0x400001B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip[] audioSources;

	[Token(Token = "0x400001C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int clipDelay;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0xAEC370", Offset = "0xAEC370", VA = "0xAEC370")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0xAEC374", Offset = "0xAEC374", VA = "0xAEC374")]
	private void StartAudio()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0xAEC3C8", Offset = "0xAEC3C8", VA = "0xAEC3C8")]
	private void RandomSoundness()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0xAEC43C", Offset = "0xAEC43C", VA = "0xAEC43C")]
	public PlayRandomSound()
	{
	}
}
[Token(Token = "0x2000007")]
public class PushPhysics : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float pushPower;

	[Token(Token = "0x6000014")]
	[Address(RVA = "0xAEC44C", Offset = "0xAEC44C", VA = "0xAEC44C")]
	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0xAEC560", Offset = "0xAEC560", VA = "0xAEC560")]
	public PushPhysics()
	{
	}
}
[Token(Token = "0x2000008")]
public class Readme : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000009")]
	public class Section
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string heading;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string linkText;

		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x6000017")]
		[Address(RVA = "0xAEC580", Offset = "0xAEC580", VA = "0xAEC580")]
		public Section()
		{
		}
	}

	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D icon;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float iconMaxWidth;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string title;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string titlesub;

	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Section[] sections;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool loadedLayout;

	[Token(Token = "0x6000016")]
	[Address(RVA = "0xAEC570", Offset = "0xAEC570", VA = "0xAEC570")]
	public Readme()
	{
	}
}
[Token(Token = "0x200000A")]
public class AudioCue : MonoBehaviour
{
	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AudioCueSO audioCueSO;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AudioCueEventSO _eventSO;

	[Token(Token = "0x6000018")]
	[Address(RVA = "0xAEC588", Offset = "0xAEC588", VA = "0xAEC588")]
	public void PlayAudioCue(int playIndex)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0xAEC5E4", Offset = "0xAEC5E4", VA = "0xAEC5E4")]
	public AudioCue()
	{
	}
}
[Token(Token = "0x200000B")]
public class BulletHole : MonoBehaviour
{
	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform BulletHoleDecal;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool RandomYRotation;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float DestroyTime;

	[Token(Token = "0x600001A")]
	[Address(RVA = "0xAEC5EC", Offset = "0xAEC5EC", VA = "0xAEC5EC")]
	private void Start()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0xAEC77C", Offset = "0xAEC77C", VA = "0xAEC77C")]
	public void TryAttachTo(Collider col)
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0xAEC890", Offset = "0xAEC890", VA = "0xAEC890")]
	private bool transformIsEqualScale(Transform theTransform)
	{
		return default(bool);
	}

	[Token(Token = "0x600001D")]
	[Address(RVA = "0xAEC900", Offset = "0xAEC900", VA = "0xAEC900")]
	private void DestroySelf()
	{
	}

	[Token(Token = "0x600001E")]
	[Address(RVA = "0xAEC98C", Offset = "0xAEC98C", VA = "0xAEC98C")]
	public BulletHole()
	{
	}
}
[Token(Token = "0x200000C")]
public class CarController : MonoBehaviour
{
	[Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class <StraightLineTo>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400003C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400003D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400003E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CarController <>4__this;

		[Token(Token = "0x400003F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 target;

		[Token(Token = "0x4000040")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x4000041")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float brakeTime;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0xAECCA8", Offset = "0xAECCA8", VA = "0xAECCA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0xAECCF0", Offset = "0xAECCF0", VA = "0xAECCF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0xAECA78", Offset = "0xAECA78", VA = "0xAECA78")]
		[DebuggerHidden]
		public <StraightLineTo>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0xAECC1C", Offset = "0xAECC1C", VA = "0xAECC1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0xAECC20", Offset = "0xAECC20", VA = "0xAECC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0xAECCB0", Offset = "0xAECCB0", VA = "0xAECCB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class <StraightLine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000042")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000043")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000044")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 target;

		[Token(Token = "0x4000045")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public CarController <>4__this;

		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float speed;

		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float brakeTime;

		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <dis>5__2;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600002E")]
			[Address(RVA = "0xAECF74", Offset = "0xAECF74", VA = "0xAECF74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000030")]
			[Address(RVA = "0xAECFBC", Offset = "0xAECFBC", VA = "0xAECFBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0xAECB4C", Offset = "0xAECB4C", VA = "0xAECB4C")]
		[DebuggerHidden]
		public <StraightLine>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0xAECCF8", Offset = "0xAECCF8", VA = "0xAECCF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0xAECCFC", Offset = "0xAECCFC", VA = "0xAECCFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0xAECF7C", Offset = "0xAECF7C", VA = "0xAECF7C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float h;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float v;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float angle;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform lf;

	[Token(Token = "0x4000032")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform rf;

	[Token(Token = "0x4000033")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform lb;

	[Token(Token = "0x4000034")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform rb;

	[Token(Token = "0x4000035")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public WheelCollider lfw;

	[Token(Token = "0x4000036")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public WheelCollider rfw;

	[Token(Token = "0x4000037")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public WheelCollider lbw;

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public WheelCollider rbw;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float angleSpeed;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float speed;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform thisTransForm;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0xAEC9A4", Offset = "0xAEC9A4", VA = "0xAEC9A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0xAEC9C8", Offset = "0xAEC9C8", VA = "0xAEC9C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0xAEC9CC", Offset = "0xAEC9CC", VA = "0xAEC9CC")]
	[IteratorStateMachine(typeof(<StraightLineTo>d__16))]
	public IEnumerator StraightLineTo(Vector3 target, float speed, float brakeTime)
	{
		return null;
	}

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xAECAA0", Offset = "0xAECAA0", VA = "0xAECAA0")]
	[IteratorStateMachine(typeof(<StraightLine>d__17))]
	private IEnumerator StraightLine(Vector3 target, float speed, float brakeTime)
	{
		return null;
	}

	[Token(Token = "0x6000023")]
	[Address(RVA = "0xAECB74", Offset = "0xAECB74", VA = "0xAECB74")]
	private void UpdateWhell(Transform tran, WheelCollider wheel)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0xAECC14", Offset = "0xAECC14", VA = "0xAECC14")]
	public CarController()
	{
	}
}
[Token(Token = "0x200000F")]
public abstract class ColorMapper : MonoBehaviour
{
	[Token(Token = "0x6000031")]
	public abstract void Map(IList<Vector3> points, Vector3 planeNormal, out Color32[] colorsA, out Color32[] colorsB);

	[Token(Token = "0x6000032")]
	[Address(RVA = "0xAECFC4", Offset = "0xAECFC4", VA = "0xAECFC4")]
	protected ColorMapper()
	{
	}
}
[Token(Token = "0x2000010")]
public class FastHull : IHull
{
	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static float smallestValidLength;

	[Token(Token = "0x400004A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	protected static float smallestValidRatio;

	[Token(Token = "0x400004B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected bool isValid;

	[Token(Token = "0x400004C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<Vector3> vertices;

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<Vector3> normals;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected List<Color32> colors;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected List<Vector4> tangents;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<Vector2> uvs;

	[Token(Token = "0x4000051")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected List<int> indices;

	[Token(Token = "0x17000007")]
	public bool IsEmpty
	{
		[Token(Token = "0x6000035")]
		[Address(RVA = "0xAED658", Offset = "0xAED658", VA = "0xAED658", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000033")]
	[Address(RVA = "0xAECFCC", Offset = "0xAECFCC", VA = "0xAECFCC")]
	public FastHull(Mesh mesh)
	{
	}

	[Token(Token = "0x6000034")]
	[Address(RVA = "0xAED398", Offset = "0xAED398", VA = "0xAED398")]
	public FastHull(FastHull reference)
	{
	}

	[Token(Token = "0x6000036")]
	[Address(RVA = "0xAED6D8", Offset = "0xAED6D8", VA = "0xAED6D8", Slot = "5")]
	public Mesh GetMesh()
	{
		return null;
	}

	[Token(Token = "0x6000037")]
	[Address(RVA = "0xAED86C", Offset = "0xAED86C", VA = "0xAED86C", Slot = "6")]
	public void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB)
	{
	}

	[Token(Token = "0x6000038")]
	[Address(RVA = "0xAEDB84", Offset = "0xAEDB84", VA = "0xAEDB84")]
	protected void AssignVertices(FastHull a, FastHull b, Vector3 pointOnPlane, Vector3 planeNormal, out bool[] vertexAbovePlane, out int[] oldToNewVertexMap)
	{
	}

	[Token(Token = "0x6000039")]
	[Address(RVA = "0xAEE1FC", Offset = "0xAEE1FC", VA = "0xAEE1FC")]
	protected void AssignTriangles(FastHull a, FastHull b, bool[] vertexAbovePlane, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, out IList<Vector3> cutEdges)
	{
	}

	[Token(Token = "0x600003A")]
	[Address(RVA = "0xAEFB70", Offset = "0xAEFB70", VA = "0xAEFB70")]
	protected void SplitTriangle(FastHull topHull, FastHull bottomHull, int[] oldToNewVertexMap, Vector3 pointOnPlane, Vector3 planeNormal, int top, int cw, int ccw, out Vector3 cwIntersection, out Vector3 ccwIntersection)
	{
	}

	[Token(Token = "0x600003B")]
	[Address(RVA = "0xAEE864", Offset = "0xAEE864", VA = "0xAEE864")]
	protected void FillCutEdges(FastHull a, FastHull b, IList<Vector3> edges, Vector3 planeNormal, UvMapper uvMapper, ColorMapper colorMapper)
	{
	}

	[Token(Token = "0x600003C")]
	[Address(RVA = "0xAEFA50", Offset = "0xAEFA50", VA = "0xAEFA50")]
	protected void ValidateOutput(FastHull a, FastHull b, Vector3 planeNormal)
	{
	}

	[Token(Token = "0x600003D")]
	[Address(RVA = "0xAF1270", Offset = "0xAF1270", VA = "0xAF1270")]
	protected float LengthAlongAxis(Vector3 axis)
	{
		return default(float);
	}
}
[Token(Token = "0x2000011")]
public enum HullType
{
	[Token(Token = "0x4000053")]
	FastHull
}
[Token(Token = "0x2000012")]
public interface IHull
{
	[Token(Token = "0x17000008")]
	bool IsEmpty
	{
		[Token(Token = "0x600003F")]
		get;
	}

	[Token(Token = "0x6000040")]
	Mesh GetMesh();

	[Token(Token = "0x6000041")]
	void Split(Vector3 localPointOnPlane, Vector3 localPlaneNormal, bool fillCut, UvMapper uvMapper, ColorMapper colorMapper, out IHull resultA, out IHull resultB);
}
[Token(Token = "0x2000013")]
public interface ITriangulator
{
	[Token(Token = "0x6000042")]
	void Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges);
}
[Token(Token = "0x2000014")]
public class ShatterOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000054")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float requiredVelocity;

	[Token(Token = "0x4000055")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float cooldownTime;

	[Token(Token = "0x4000056")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected float timeSinceInstantiated;

	[Token(Token = "0x6000043")]
	[Address(RVA = "0xAF14AC", Offset = "0xAF14AC", VA = "0xAF14AC")]
	public void Update()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0xAF14D8", Offset = "0xAF14D8", VA = "0xAF14D8")]
	public void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0xAF1764", Offset = "0xAF1764", VA = "0xAF1764")]
	public ShatterOnCollision()
	{
	}
}
[Token(Token = "0x2000015")]
[RequireComponent(typeof(MeshFilter))]
public class ShatterTool : MonoBehaviour
{
	[Token(Token = "0x4000057")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	protected int generation;

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	protected int generationLimit;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected int cuts;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected bool fillCut;

	[Token(Token = "0x400005B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[SerializeField]
	protected bool sendPreSplitMessage;

	[Token(Token = "0x400005C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	[SerializeField]
	protected bool sendPostSplitMessage;

	[Token(Token = "0x400005D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected HullType internalHullType;

	[Token(Token = "0x400005E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	protected bool isIntact;

	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected IHull hull;

	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Vector3 center;

	[Token(Token = "0x17000009")]
	public int Generation
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0xAF1778", Offset = "0xAF1778", VA = "0xAF1778")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000047")]
		[Address(RVA = "0xAF1780", Offset = "0xAF1780", VA = "0xAF1780")]
		set
		{
		}
	}

	[Token(Token = "0x1700000A")]
	public int GenerationLimit
	{
		[Token(Token = "0x6000048")]
		[Address(RVA = "0xAF1790", Offset = "0xAF1790", VA = "0xAF1790")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000049")]
		[Address(RVA = "0xAF1798", Offset = "0xAF1798", VA = "0xAF1798")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	public int Cuts
	{
		[Token(Token = "0x600004A")]
		[Address(RVA = "0xAF17A8", Offset = "0xAF17A8", VA = "0xAF17A8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600004B")]
		[Address(RVA = "0xAF17B0", Offset = "0xAF17B0", VA = "0xAF17B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000C")]
	public bool FillCut
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0xAF17C0", Offset = "0xAF17C0", VA = "0xAF17C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004D")]
		[Address(RVA = "0xAF17C8", Offset = "0xAF17C8", VA = "0xAF17C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	public bool SendPreSplitMessage
	{
		[Token(Token = "0x600004E")]
		[Address(RVA = "0xAF17D4", Offset = "0xAF17D4", VA = "0xAF17D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600004F")]
		[Address(RVA = "0xAF17DC", Offset = "0xAF17DC", VA = "0xAF17DC")]
		set
		{
		}
	}

	[Token(Token = "0x1700000E")]
	public bool SendPostSplitMessage
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xAF17E8", Offset = "0xAF17E8", VA = "0xAF17E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000051")]
		[Address(RVA = "0xAF17F0", Offset = "0xAF17F0", VA = "0xAF17F0")]
		set
		{
		}
	}

	[Token(Token = "0x1700000F")]
	public HullType InternalHullType
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0xAF17FC", Offset = "0xAF17FC", VA = "0xAF17FC")]
		get
		{
			return default(HullType);
		}
		[Token(Token = "0x6000053")]
		[Address(RVA = "0xAF1804", Offset = "0xAF1804", VA = "0xAF1804")]
		set
		{
		}
	}

	[Token(Token = "0x17000010")]
	public bool IsFirstGeneration
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0xAF180C", Offset = "0xAF180C", VA = "0xAF180C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000011")]
	public bool IsLastGeneration
	{
		[Token(Token = "0x6000055")]
		[Address(RVA = "0xAF181C", Offset = "0xAF181C", VA = "0xAF181C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000012")]
	public Vector3 Center
	{
		[Token(Token = "0x6000056")]
		[Address(RVA = "0xAF182C", Offset = "0xAF182C", VA = "0xAF182C")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0xAF1858", Offset = "0xAF1858", VA = "0xAF1858")]
	protected void CalculateCenter()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0xAF18F8", Offset = "0xAF18F8", VA = "0xAF18F8")]
	public void Start()
	{
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0xAF1A18", Offset = "0xAF1A18", VA = "0xAF1A18")]
	public void Shatter(Vector3 point)
	{
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0xAF1B18", Offset = "0xAF1B18", VA = "0xAF1B18")]
	public void Split(Plane[] planes)
	{
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0xAF1D0C", Offset = "0xAF1D0C", VA = "0xAF1D0C")]
	protected void ConvertPlanesToLocalspace(Plane[] planes, out Vector3[] points, out Vector3[] normals)
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0xAF1FE0", Offset = "0xAF1FE0", VA = "0xAF1FE0")]
	protected void CreateNewHulls(UvMapper uvMapper, ColorMapper colorMapper, Vector3[] points, Vector3[] normals, out IList<IHull> newHulls)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0xAF25A4", Offset = "0xAF25A4", VA = "0xAF25A4")]
	protected void CreateNewGameObjects(IList<IHull> newHulls, out GameObject[] newGameObjects)
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0xAF2E2C", Offset = "0xAF2E2C", VA = "0xAF2E2C")]
	private void destroyThis(GameObject o, int second)
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0xAF2E94", Offset = "0xAF2E94", VA = "0xAF2E94")]
	public ShatterTool()
	{
	}
}
[Token(Token = "0x2000016")]
public static class Tools
{
	[Token(Token = "0x6000060")]
	[Address(RVA = "0xAF2EBC", Offset = "0xAF2EBC", VA = "0xAF2EBC")]
	public static bool IsPointInsideTriangle(ref Vector3 point, ref Vector3 triangle0, ref Vector3 triangle1, ref Vector3 triangle2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0xAF2F38", Offset = "0xAF2F38", VA = "0xAF2F38")]
	public static bool IsPointInsideTriangle(ref Vector3 point, ref Vector3 triangle0, ref Vector3 triangle1, ref Vector3 triangle2, ref Vector3 triangleNormal)
	{
		return default(bool);
	}
}
[Token(Token = "0x2000017")]
public class Triangulator : ITriangulator
{
	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected List<Vector3> points;

	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected List<int> edges;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected List<int> triangles;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected List<int> triangleEdges;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected List<List<int>> loops;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected List<List<bool>> concavities;

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected List<int> duplicateEdges;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Vector3 planeNormal;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected int originalEdgeCount;

	[Token(Token = "0x6000062")]
	[Address(RVA = "0xAF10D4", Offset = "0xAF10D4", VA = "0xAF10D4")]
	public Triangulator(IList<Vector3> points, IList<int> edges, Vector3 planeNormal)
	{
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0xAF3150", Offset = "0xAF3150", VA = "0xAF3150", Slot = "4")]
	public void Fill(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
	{
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0xAF3488", Offset = "0xAF3488", VA = "0xAF3488")]
	protected void FindLoops()
	{
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0xAF37C4", Offset = "0xAF37C4", VA = "0xAF37C4")]
	protected void FindConcavities()
	{
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0xAF3D38", Offset = "0xAF3D38", VA = "0xAF3D38")]
	protected void PrepareDuplicateEdges()
	{
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0xAF4C3C", Offset = "0xAF4C3C", VA = "0xAF4C3C")]
	protected void ValidateConcavities()
	{
	}

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xAF51F0", Offset = "0xAF51F0", VA = "0xAF51F0")]
	protected void UpdateConcavity(int index, List<int> loop, List<bool> concavity)
	{
	}

	[Token(Token = "0x6000069")]
	[Address(RVA = "0xAF4BE0", Offset = "0xAF4BE0", VA = "0xAF4BE0")]
	protected bool IsLinePairConcave(ref Vector3 line0, ref Vector3 line1)
	{
		return default(bool);
	}

	[Token(Token = "0x600006A")]
	[Address(RVA = "0xAF3DB4", Offset = "0xAF3DB4", VA = "0xAF3DB4")]
	protected bool IsTriangleOverlappingLoop(int first, int second, int third, List<int> loop, List<bool> concavity)
	{
		return default(bool);
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0xAF4030", Offset = "0xAF4030", VA = "0xAF4030")]
	protected bool MergeLoops(int first, int second, int third, List<int> loop, List<bool> concavity, out int swallowedLoopIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600006C")]
	[Address(RVA = "0xAF5438", Offset = "0xAF5438", VA = "0xAF5438")]
	protected bool FindClosestPointInTriangle(int first, int second, int third, List<int> loop, out int loopIndex, out int loopLocation)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	[Address(RVA = "0xAF5984", Offset = "0xAF5984", VA = "0xAF5984")]
	protected void InsertLoop(int insertLocation, List<int> loop, List<bool> concavity, int otherAnchorLocation, List<int> otherLoop, List<bool> otherConcavity)
	{
	}

	[Token(Token = "0x600006E")]
	[Address(RVA = "0xAF4198", Offset = "0xAF4198", VA = "0xAF4198")]
	protected void FillTriangle(int zero, int first, int second, int third, List<int> loop, List<bool> concavity)
	{
	}

	[Token(Token = "0x600006F")]
	[Address(RVA = "0xAF4874", Offset = "0xAF4874", VA = "0xAF4874")]
	protected void RemoveDuplicateEdges()
	{
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0xAF4A24", Offset = "0xAF4A24", VA = "0xAF4A24")]
	protected void SetOutput(out int[] newEdges, out int[] newTriangles, out int[] newTriangleEdges)
	{
	}
}
[Token(Token = "0x2000018")]
public abstract class UvMapper : MonoBehaviour
{
	[Token(Token = "0x6000071")]
	public abstract void Map(IList<Vector3> points, Vector3 planeNormal, out Vector4[] tangentsA, out Vector4[] tangentsB, out Vector2[] uvsA, out Vector2[] uvsB);

	[Token(Token = "0x6000072")]
	[Address(RVA = "0xAF5EF0", Offset = "0xAF5EF0", VA = "0xAF5EF0")]
	protected UvMapper()
	{
	}
}
[Token(Token = "0x2000019")]
public class BoatController : BaseNpcController
{
	[Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class <SetMuzzleFlash>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400007D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400007E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400007F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoatController <>4__this;

		[Token(Token = "0x17000013")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0xAF70F8", Offset = "0xAF70F8", VA = "0xAF70F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000086")]
			[Address(RVA = "0xAF7140", Offset = "0xAF7140", VA = "0xAF7140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0xAF6B1C", Offset = "0xAF6B1C", VA = "0xAF6B1C")]
		[DebuggerHidden]
		public <SetMuzzleFlash>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0xAF6FBC", Offset = "0xAF6FBC", VA = "0xAF6FBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0xAF6FC0", Offset = "0xAF6FC0", VA = "0xAF6FC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0xAF7100", Offset = "0xAF7100", VA = "0xAF7100", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class <shotRuning>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000080")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000081")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000082")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BoatController <>4__this;

		[Token(Token = "0x17000015")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0xAF75C0", Offset = "0xAF75C0", VA = "0xAF75C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000016")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600008C")]
			[Address(RVA = "0xAF7608", Offset = "0xAF7608", VA = "0xAF7608", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0xAF6CD4", Offset = "0xAF6CD4", VA = "0xAF6CD4")]
		[DebuggerHidden]
		public <shotRuning>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0xAF7148", Offset = "0xAF7148", VA = "0xAF7148", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0xAF714C", Offset = "0xAF714C", VA = "0xAF714C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0xAF75C8", Offset = "0xAF75C8", VA = "0xAF75C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("组件")]
	private AudioCue audioCue;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject Enemy;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("目标")]
	private Transform targetTran;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<Transform> targetTrans;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject Shelters;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int id;

	[Token(Token = "0x4000070")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool arrive;

	[Token(Token = "0x4000071")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string move;

	[Token(Token = "0x4000072")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float dis;

	[Token(Token = "0x4000073")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float fightShotTimer;

	[Token(Token = "0x4000074")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float fightShotCD;

	[Token(Token = "0x4000075")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string target;

	[Token(Token = "0x4000076")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string targetType;

	[Token(Token = "0x4000077")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string drop;

	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[Header("爆炸特效")]
	public GameObject bombFx;

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject muzzleFlash;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[Tooltip("子弹发射位置")]
	public GameObject bulletPoint;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject ProtectObj;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public LayerMask ValidLayers;

	[Token(Token = "0x6000073")]
	[Address(RVA = "0xAF5EF8", Offset = "0xAF5EF8", VA = "0xAF5EF8")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0xAF5F1C", Offset = "0xAF5F1C", VA = "0xAF5F1C")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0xAF6058", Offset = "0xAF6058", VA = "0xAF6058")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0xAF6410", Offset = "0xAF6410", VA = "0xAF6410")]
	public void init(int id, string target, string targetType, string targetParam, string drop)
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0xAF60DC", Offset = "0xAF60DC", VA = "0xAF60DC")]
	private void controller()
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0xAF69A4", Offset = "0xAF69A4", VA = "0xAF69A4")]
	private void TakeAction()
	{
	}

	[Token(Token = "0x6000079")]
	[Address(RVA = "0xAF6AA8", Offset = "0xAF6AA8", VA = "0xAF6AA8")]
	[IteratorStateMachine(typeof(<SetMuzzleFlash>d__25))]
	private IEnumerator SetMuzzleFlash()
	{
		return null;
	}

	[Token(Token = "0x600007A")]
	[Address(RVA = "0xAF6A58", Offset = "0xAF6A58", VA = "0xAF6A58")]
	private bool fightShot()
	{
		return default(bool);
	}

	[Token(Token = "0x600007B")]
	[Address(RVA = "0xAF6C60", Offset = "0xAF6C60", VA = "0xAF6C60")]
	[IteratorStateMachine(typeof(<shotRuning>d__27))]
	private IEnumerator shotRuning()
	{
		return null;
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0xAF6CFC", Offset = "0xAF6CFC", VA = "0xAF6CFC")]
	public void injured(int atk)
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0xAF5FDC", Offset = "0xAF5FDC", VA = "0xAF5FDC")]
	private void protextObj()
	{
	}

	[Token(Token = "0x600007E")]
	[Address(RVA = "0xAF6D44", Offset = "0xAF6D44", VA = "0xAF6D44")]
	private void Die()
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0xAF6B44", Offset = "0xAF6B44", VA = "0xAF6B44")]
	private bool getRandomTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000080")]
	[Address(RVA = "0xAF6ECC", Offset = "0xAF6ECC", VA = "0xAF6ECC")]
	public BoatController()
	{
	}
}
[Token(Token = "0x200001C")]
public class BossController : MonoBehaviour
{
	[Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class <fightShot>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x40000B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <n>5__2;

		[Token(Token = "0x17000017")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0xAF962C", Offset = "0xAF962C", VA = "0xAF962C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000018")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0xAF9674", Offset = "0xAF9674", VA = "0xAF9674", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0xAF82EC", Offset = "0xAF82EC", VA = "0xAF82EC")]
		[DebuggerHidden]
		public <fightShot>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0xAF9228", Offset = "0xAF9228", VA = "0xAF9228", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0xAF922C", Offset = "0xAF922C", VA = "0xAF922C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0xAF9634", Offset = "0xAF9634", VA = "0xAF9634", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class <shot>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x17000019")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0xAF9714", Offset = "0xAF9714", VA = "0xAF9714", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0xAF975C", Offset = "0xAF975C", VA = "0xAF975C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0xAF8388", Offset = "0xAF8388", VA = "0xAF8388")]
		[DebuggerHidden]
		public <shot>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0xAF967C", Offset = "0xAF967C", VA = "0xAF967C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0xAF9680", Offset = "0xAF9680", VA = "0xAF9680", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0xAF971C", Offset = "0xAF971C", VA = "0xAF971C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class <shotFire>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x40000B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Vector3 <head>5__2;

		[Token(Token = "0x40000B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int <i>5__3;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0xAF9BC0", Offset = "0xAF9BC0", VA = "0xAF9BC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0xAF9C08", Offset = "0xAF9C08", VA = "0xAF9C08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0xAF8424", Offset = "0xAF8424", VA = "0xAF8424")]
		[DebuggerHidden]
		public <shotFire>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0xAF9764", Offset = "0xAF9764", VA = "0xAF9764", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0xAF9768", Offset = "0xAF9768", VA = "0xAF9768", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0xAF9BC8", Offset = "0xAF9BC8", VA = "0xAF9BC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class <dance>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x1700001D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0xAF9DF8", Offset = "0xAF9DF8", VA = "0xAF9DF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0xAF9E40", Offset = "0xAF9E40", VA = "0xAF9E40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0xAF84C0", Offset = "0xAF84C0", VA = "0xAF84C0")]
		[DebuggerHidden]
		public <dance>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0xAF9C10", Offset = "0xAF9C10", VA = "0xAF9C10", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0xAF9C14", Offset = "0xAF9C14", VA = "0xAF9C14", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0xAF9E00", Offset = "0xAF9E00", VA = "0xAF9E00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class <shotRuning>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x1700001F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C1")]
			[Address(RVA = "0xAFA40C", Offset = "0xAFA40C", VA = "0xAFA40C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0xAFA454", Offset = "0xAFA454", VA = "0xAFA454", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0xAF855C", Offset = "0xAF855C", VA = "0xAF855C")]
		[DebuggerHidden]
		public <shotRuning>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0xAF9E48", Offset = "0xAF9E48", VA = "0xAF9E48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0xAF9E4C", Offset = "0xAF9E4C", VA = "0xAF9E4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0xAFA414", Offset = "0xAFA414", VA = "0xAFA414", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class <SetMuzzleFlash>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BossController <>4__this;

		[Token(Token = "0x17000021")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000C7")]
			[Address(RVA = "0xAFA598", Offset = "0xAFA598", VA = "0xAFA598", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000022")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000C9")]
			[Address(RVA = "0xAFA5E0", Offset = "0xAFA5E0", VA = "0xAFA5E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xAF8E28", Offset = "0xAF8E28", VA = "0xAF8E28")]
		[DebuggerHidden]
		public <SetMuzzleFlash>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xAFA45C", Offset = "0xAFA45C", VA = "0xAFA45C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xAFA460", Offset = "0xAFA460", VA = "0xAFA460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xAFA5A0", Offset = "0xAFA5A0", VA = "0xAFA5A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("组件")]
	private NavMeshAgent agent;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Animator ani;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject player;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject playerHead;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioCue audioCue;

	[Token(Token = "0x4000088")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("目标")]
	public Transform targetTran;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public List<Transform> targetTrans;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject Shelters;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int id;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private bool arrive;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform thisTranForm;

	[Token(Token = "0x400008E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private int playerHp;

	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public int Hp;

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float dis;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private int Atk;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Slider HpSlider;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public PlayerEventSO _eventSO;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float fightShotTimer;

	[Token(Token = "0x4000096")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float fightShotCD;

	[Token(Token = "0x4000097")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Tooltip("子弹发射位置")]
	public GameObject bulletPoint;

	[Token(Token = "0x4000098")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private string MoveAni;

	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private string FireAni;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Rigidbody[] RagDolls;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool isProtect;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject muzzleFlash;

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject weaponObj;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public BossTriggerSO BossSO;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 worldDeltaPosition;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private LookAt lookAt;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float disA;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector3 playerV;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 head;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Ray ray;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	public LayerMask ValidLayers;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float timerOffMeshLink;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float timeOffMeshLink;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool isJump;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	private bool isMoveToStartPos;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13A")]
	public bool isShot;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float Protext;

	[Token(Token = "0x600008D")]
	[Address(RVA = "0xAF7610", Offset = "0xAF7610", VA = "0xAF7610")]
	private void Awake()
	{
	}

	[Token(Token = "0x600008E")]
	[Address(RVA = "0xAF7634", Offset = "0xAF7634", VA = "0xAF7634")]
	private void Start()
	{
	}

	[Token(Token = "0x600008F")]
	[Address(RVA = "0xAF7888", Offset = "0xAF7888", VA = "0xAF7888")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000090")]
	[Address(RVA = "0xAF7970", Offset = "0xAF7970", VA = "0xAF7970")]
	public void gainPlayer(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000091")]
	[Address(RVA = "0xAF798C", Offset = "0xAF798C", VA = "0xAF798C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000092")]
	[Address(RVA = "0xAF7BBC", Offset = "0xAF7BBC", VA = "0xAF7BBC")]
	private void controller()
	{
	}

	[Token(Token = "0x6000093")]
	[Address(RVA = "0xAF7D2C", Offset = "0xAF7D2C", VA = "0xAF7D2C")]
	private void TakeAction()
	{
	}

	[Token(Token = "0x6000094")]
	[Address(RVA = "0xAF7E08", Offset = "0xAF7E08", VA = "0xAF7E08")]
	private void RunToTarget()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0xAF7FA4", Offset = "0xAF7FA4", VA = "0xAF7FA4")]
	[IteratorStateMachine(typeof(<fightShot>d__49))]
	private IEnumerator fightShot()
	{
		return null;
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0xAF8314", Offset = "0xAF8314", VA = "0xAF8314")]
	[IteratorStateMachine(typeof(<shot>d__50))]
	private IEnumerator shot()
	{
		return null;
	}

	[Token(Token = "0x6000097")]
	[Address(RVA = "0xAF83B0", Offset = "0xAF83B0", VA = "0xAF83B0")]
	[IteratorStateMachine(typeof(<shotFire>d__51))]
	private IEnumerator shotFire()
	{
		return null;
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0xAF844C", Offset = "0xAF844C", VA = "0xAF844C")]
	[IteratorStateMachine(typeof(<dance>d__52))]
	private IEnumerator dance()
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0xAF84E8", Offset = "0xAF84E8", VA = "0xAF84E8")]
	[IteratorStateMachine(typeof(<shotRuning>d__53))]
	private IEnumerator shotRuning()
	{
		return null;
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0xAF8584", Offset = "0xAF8584", VA = "0xAF8584")]
	private void getRandomTarget(int n)
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0xAF87FC", Offset = "0xAF87FC", VA = "0xAF87FC")]
	private void lookAtPlayer()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0xAF8884", Offset = "0xAF8884", VA = "0xAF8884")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0xAF89D8", Offset = "0xAF89D8", VA = "0xAF89D8")]
	public void injured(int hurt)
	{
	}

	[Token(Token = "0x600009E")]
	[Address(RVA = "0xAF8DB4", Offset = "0xAF8DB4", VA = "0xAF8DB4")]
	[IteratorStateMachine(typeof(<SetMuzzleFlash>d__59))]
	private IEnumerator SetMuzzleFlash()
	{
		return null;
	}

	[Token(Token = "0x600009F")]
	[Address(RVA = "0xAF8E50", Offset = "0xAF8E50", VA = "0xAF8E50")]
	public void StopRagDolls()
	{
	}

	[Token(Token = "0x60000A0")]
	[Address(RVA = "0xAF8BF0", Offset = "0xAF8BF0", VA = "0xAF8BF0")]
	private void die()
	{
	}

	[Token(Token = "0x60000A1")]
	[Address(RVA = "0xAF9084", Offset = "0xAF9084", VA = "0xAF9084")]
	private void ActivetFalse()
	{
	}

	[Token(Token = "0x60000A2")]
	[Address(RVA = "0xAF90A8", Offset = "0xAF90A8", VA = "0xAF90A8")]
	public void HackKinfeAni()
	{
	}

	[Token(Token = "0x60000A3")]
	[Address(RVA = "0xAF8018", Offset = "0xAF8018", VA = "0xAF8018")]
	protected void JumpOffMeshLink()
	{
	}

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xAF8EB4", Offset = "0xAF8EB4", VA = "0xAF8EB4")]
	public void Init_Animator()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xAF9164", Offset = "0xAF9164", VA = "0xAF9164")]
	public BossController()
	{
	}
}
[Token(Token = "0x2000023")]
public class BossStandController : MonoBehaviour
{
	[Token(Token = "0x2000024")]
	public enum FireType
	{
		[Token(Token = "0x40000C5")]
		Fire_1,
		[Token(Token = "0x40000C6")]
		Fire_2,
		[Token(Token = "0x40000C7")]
		Fire_3
	}

	[Token(Token = "0x2000025")]
	public enum MoveType
	{
		[Token(Token = "0x40000C9")]
		Move_1,
		[Token(Token = "0x40000CA")]
		Move_2,
		[Token(Token = "0x40000CB")]
		Move_3,
		[Token(Token = "0x40000CC")]
		Move_4,
		[Token(Token = "0x40000CD")]
		Move_5,
		[Token(Token = "0x40000CE")]
		Move_6
	}

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FireType fireType;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public MoveType moveType;

	[Token(Token = "0x60000CA")]
	[Address(RVA = "0xAFA5E8", Offset = "0xAFA5E8", VA = "0xAFA5E8")]
	public BossStandController()
	{
	}
}
[Token(Token = "0x2000026")]
public class BulletController : MonoBehaviour
{
	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atk;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioCue cue;

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0xAFA5F0", Offset = "0xAFA5F0", VA = "0xAFA5F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0xAFA648", Offset = "0xAFA648", VA = "0xAFA648")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0xAFA87C", Offset = "0xAFA87C", VA = "0xAFA87C")]
	public BulletController()
	{
	}
}
[Token(Token = "0x2000027")]
public class BulletTankController : MonoBehaviour
{
	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int atk;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private AudioCue cue;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject bombFx;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0xAFA88C", Offset = "0xAFA88C", VA = "0xAFA88C")]
	private void Start()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0xAFA8E4", Offset = "0xAFA8E4", VA = "0xAFA8E4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0xAFAC50", Offset = "0xAFAC50", VA = "0xAFAC50")]
	public BulletTankController()
	{
	}
}
[Token(Token = "0x2000028")]
public class DroneController : MonoBehaviour
{
	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class <shotFire>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DroneController <>4__this;

		[Token(Token = "0x40000ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000023")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0xAFBCC8", Offset = "0xAFBCC8", VA = "0xAFBCC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000024")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000E8")]
			[Address(RVA = "0xAFBD10", Offset = "0xAFBD10", VA = "0xAFBD10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0xAFB7A0", Offset = "0xAFB7A0", VA = "0xAFB7A0")]
		[DebuggerHidden]
		public <shotFire>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0xAFBC00", Offset = "0xAFBC00", VA = "0xAFBC00", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0xAFBC04", Offset = "0xAFBC04", VA = "0xAFBC04", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0xAFBCD0", Offset = "0xAFBCD0", VA = "0xAFBCD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class <shotRuning>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DroneController <>4__this;

		[Token(Token = "0x17000025")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xAFC2B8", Offset = "0xAFC2B8", VA = "0xAFC2B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000026")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0xAFC300", Offset = "0xAFC300", VA = "0xAFC300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0xAFB83C", Offset = "0xAFB83C", VA = "0xAFB83C")]
		[DebuggerHidden]
		public <shotRuning>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0xAFBD18", Offset = "0xAFBD18", VA = "0xAFBD18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0xAFBD1C", Offset = "0xAFBD1C", VA = "0xAFBD1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0xAFC2C0", Offset = "0xAFC2C0", VA = "0xAFC2C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class <Hurt>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Vector3 HurtV;

		[Token(Token = "0x40000F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DroneController <>4__this;

		[Token(Token = "0x40000F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 <target>5__2;

		[Token(Token = "0x17000027")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0xAFC760", Offset = "0xAFC760", VA = "0xAFC760", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000028")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0xAFC7A8", Offset = "0xAFC7A8", VA = "0xAFC7A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0xAFBBB0", Offset = "0xAFBBB0", VA = "0xAFBBB0")]
		[DebuggerHidden]
		public <Hurt>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0xAFC308", Offset = "0xAFC308", VA = "0xAFC308", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0xAFC30C", Offset = "0xAFC30C", VA = "0xAFC30C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0xAFC768", Offset = "0xAFC768", VA = "0xAFC768", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform FirePoint;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform[] TargetTrans;

	[Token(Token = "0x40000D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Target;

	[Token(Token = "0x40000D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform player;

	[Token(Token = "0x40000D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject playerHead;

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float Speed;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float fightShotTimer;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float fightShotCD;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int Hp;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float Protext;

	[Token(Token = "0x40000DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float standTimer;

	[Token(Token = "0x40000DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float standCD;

	[Token(Token = "0x40000E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private AudioCue audioCue;

	[Token(Token = "0x40000E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("爆炸特效")]
	public GameObject bombFx;

	[Token(Token = "0x40000E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AudioSource audioSource;

	[Token(Token = "0x40000E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public GameObject ProtectObj;

	[Token(Token = "0x40000E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("Player相关")]
	protected int playerHp;

	[Token(Token = "0x40000E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected bool isPause;

	[Token(Token = "0x40000E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
	protected bool isWin;

	[Token(Token = "0x40000E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x40000E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x40000E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public LayerMask ValidLayers;

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0xAFAC60", Offset = "0xAFAC60", VA = "0xAFAC60")]
	private void Start()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0xAFAE7C", Offset = "0xAFAE7C", VA = "0xAFAE7C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0xAFAF64", Offset = "0xAFAF64", VA = "0xAFAF64")]
	public void gainPlayer(PlayerDataSO so)
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0xAFAF90", Offset = "0xAFAF90", VA = "0xAFAF90")]
	public void SetTargetFroms(Transform[] vTrans)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0xAFAFAC", Offset = "0xAFAFAC", VA = "0xAFAFAC")]
	public void go()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0xAFB004", Offset = "0xAFB004", VA = "0xAFB004")]
	private void Update()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0xAFB294", Offset = "0xAFB294", VA = "0xAFB294")]
	private void Fei(Vector3 targetV)
	{
	}

	[Token(Token = "0x60000D8")]
	[Address(RVA = "0xAFB3BC", Offset = "0xAFB3BC", VA = "0xAFB3BC")]
	private void Fire()
	{
	}

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0xAFB594", Offset = "0xAFB594", VA = "0xAFB594")]
	private void shot()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0xAFB640", Offset = "0xAFB640", VA = "0xAFB640")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0xAFB6F0", Offset = "0xAFB6F0", VA = "0xAFB6F0")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0xAFB5CC", Offset = "0xAFB5CC", VA = "0xAFB5CC")]
	[IteratorStateMachine(typeof(<shotFire>d__33))]
	private IEnumerator shotFire()
	{
		return null;
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0xAFB7C8", Offset = "0xAFB7C8", VA = "0xAFB7C8")]
	[IteratorStateMachine(typeof(<shotRuning>d__34))]
	private IEnumerator shotRuning()
	{
		return null;
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0xAFB864", Offset = "0xAFB864", VA = "0xAFB864")]
	public void injured(int atk)
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0xAFAE00", Offset = "0xAFAE00", VA = "0xAFAE00")]
	private void protextObj()
	{
	}

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0xAFB8E0", Offset = "0xAFB8E0", VA = "0xAFB8E0")]
	[IteratorStateMachine(typeof(<Hurt>d__37))]
	private IEnumerator Hurt(Vector3 HurtV)
	{
		return null;
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0xAFB978", Offset = "0xAFB978", VA = "0xAFB978")]
	private void Die()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0xAFBBD8", Offset = "0xAFBBD8", VA = "0xAFBBD8")]
	public DroneController()
	{
	}
}
[Token(Token = "0x200002C")]
public class EnemyController : BaseNpcController
{
	[Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class <shotFire>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400011C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x400011D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000029")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0xAFF94C", Offset = "0xAFF94C", VA = "0xAFF94C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000112")]
			[Address(RVA = "0xAFF994", Offset = "0xAFF994", VA = "0xAFF994", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010D")]
		[Address(RVA = "0xAFE3F0", Offset = "0xAFE3F0", VA = "0xAFE3F0")]
		[DebuggerHidden]
		public <shotFire>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x600010E")]
		[Address(RVA = "0xAFF81C", Offset = "0xAFF81C", VA = "0xAFF81C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0xAFF820", Offset = "0xAFF820", VA = "0xAFF820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0xAFF954", Offset = "0xAFF954", VA = "0xAFF954", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class <shotRuning>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400011E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400011F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000120")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x1700002B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000116")]
			[Address(RVA = "0xAFFF6C", Offset = "0xAFFF6C", VA = "0xAFFF6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000118")]
			[Address(RVA = "0xAFFFB4", Offset = "0xAFFFB4", VA = "0xAFFFB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0xAFE418", Offset = "0xAFE418", VA = "0xAFE418")]
		[DebuggerHidden]
		public <shotRuning>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0xAFF99C", Offset = "0xAFF99C", VA = "0xAFF99C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0xAFF9A0", Offset = "0xAFF9A0", VA = "0xAFF9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0xAFFF74", Offset = "0xAFFF74", VA = "0xAFFF74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class <TakeActionCrouchA>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000121")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000122")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000123")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x4000124")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <crouch>5__2;

		[Token(Token = "0x1700002D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600011C")]
			[Address(RVA = "0xB0025C", Offset = "0xB0025C", VA = "0xB0025C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600011E")]
			[Address(RVA = "0xB002A4", Offset = "0xB002A4", VA = "0xB002A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0xAFF068", Offset = "0xAFF068", VA = "0xAFF068")]
		[DebuggerHidden]
		public <TakeActionCrouchA>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0xAFFFBC", Offset = "0xAFFFBC", VA = "0xAFFFBC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0xAFFFC0", Offset = "0xAFFFC0", VA = "0xAFFFC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0xB00264", Offset = "0xB00264", VA = "0xB00264", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class <TakeActionCrouchB>d__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000127")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x1700002F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000122")]
			[Address(RVA = "0xB004AC", Offset = "0xB004AC", VA = "0xB004AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000030")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000124")]
			[Address(RVA = "0xB004F4", Offset = "0xB004F4", VA = "0xB004F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0xAFF090", Offset = "0xAFF090", VA = "0xAFF090")]
		[DebuggerHidden]
		public <TakeActionCrouchB>d__52(int <>1__state)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0xB002AC", Offset = "0xB002AC", VA = "0xB002AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0xB002B0", Offset = "0xB002B0", VA = "0xB002B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0xB004B4", Offset = "0xB004B4", VA = "0xB004B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class <TakeActionDodgeA>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000128")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000129")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400012A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x17000031")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000128")]
			[Address(RVA = "0xB00628", Offset = "0xB00628", VA = "0xB00628", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000032")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0xB00670", Offset = "0xB00670", VA = "0xB00670", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xAFF0B8", Offset = "0xAFF0B8", VA = "0xAFF0B8")]
		[DebuggerHidden]
		public <TakeActionDodgeA>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xB004FC", Offset = "0xB004FC", VA = "0xB004FC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0xB00500", Offset = "0xB00500", VA = "0xB00500", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0xB00630", Offset = "0xB00630", VA = "0xB00630", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class <TakeActionDodgeB>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400012D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x17000033")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600012E")]
			[Address(RVA = "0xB017BC", Offset = "0xB017BC", VA = "0xB017BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xB01804", Offset = "0xB01804", VA = "0xB01804", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0xB01678", Offset = "0xB01678", VA = "0xB01678")]
		[DebuggerHidden]
		public <TakeActionDodgeB>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0xB016A0", Offset = "0xB016A0", VA = "0xB016A0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0xB016A4", Offset = "0xB016A4", VA = "0xB016A4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0xB017C4", Offset = "0xB017C4", VA = "0xB017C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class <SetMuzzleFlash>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400012E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400012F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000130")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyController <>4__this;

		[Token(Token = "0x17000035")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000134")]
			[Address(RVA = "0xB01970", Offset = "0xB01970", VA = "0xB01970", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000036")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000136")]
			[Address(RVA = "0xB019B8", Offset = "0xB019B8", VA = "0xB019B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0xB0180C", Offset = "0xB0180C", VA = "0xB0180C")]
		[DebuggerHidden]
		public <SetMuzzleFlash>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0xB01834", Offset = "0xB01834", VA = "0xB01834", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0xB01838", Offset = "0xB01838", VA = "0xB01838", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0xB01978", Offset = "0xB01978", VA = "0xB01978", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float dis;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private bool isShot;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Rigidbody rig;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Tooltip("射程")]
	private float firingRange;

	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[Tooltip("停止距离")]
	private float stopRange;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Tooltip("子弹发射位置")]
	private GameObject bulletPoint;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[Tooltip("子弹射速")]
	private int ShotForce;

	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[Tooltip("射击频率")]
	private float shotCD;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Tooltip("连发数量")]
	private int shotRunNum;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[Tooltip("原地射击的概率")]
	private int OnsituShotProb;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Tooltip("攻击力")]
	private int atk;

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public GameObject muzzleFlash;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform targetTran;

	[Token(Token = "0x4000103")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform shelterTranform;

	[Token(Token = "0x4000104")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Transform headTran;

	[Token(Token = "0x4000105")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int id;

	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private string enemyName;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private AudioCue audioCue;

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject Shelters;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string target;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool arrive;

	[Token(Token = "0x400010B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private string weapon;

	[Token(Token = "0x400010C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private double speed;

	[Token(Token = "0x400010D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private string targetType;

	[Token(Token = "0x400010E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private string targetParam;

	[Token(Token = "0x400010F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private string drop;

	[Token(Token = "0x4000110")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private string move;

	[Token(Token = "0x4000111")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private string actionAni;

	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private GameObject weaponObj;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int WeaponIndex;

	[Token(Token = "0x4000114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private bool isKnife;

	[Token(Token = "0x4000115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Rigidbody[] RagDolls;

	[Token(Token = "0x4000116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private float fightShotTimer;

	[Token(Token = "0x4000117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x194")]
	private float runShowTimer;

	[Token(Token = "0x4000118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public LayerMask ValidLayers;

	[Token(Token = "0x4000119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private bool startAction;

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0xAFC7B0", Offset = "0xAFC7B0", VA = "0xAFC7B0")]
	private new void Start()
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0xAFC84C", Offset = "0xAFC84C", VA = "0xAFC84C")]
	private new void Update()
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0xAFCF8C", Offset = "0xAFCF8C", VA = "0xAFCF8C")]
	public void init(int id, string EnemyName, string target, string weapon, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0xAFCA90", Offset = "0xAFCA90", VA = "0xAFCA90")]
	private void controller()
	{
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0xAFE154", Offset = "0xAFE154", VA = "0xAFE154")]
	public float checkTargetDirForMe(Transform target)
	{
		return default(float);
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0xAFE344", Offset = "0xAFE344", VA = "0xAFE344")]
	private void shot()
	{
	}

	[Token(Token = "0x60000FB")]
	[Address(RVA = "0xAFE37C", Offset = "0xAFE37C", VA = "0xAFE37C")]
	[IteratorStateMachine(typeof(<shotFire>d__41))]
	private IEnumerator shotFire()
	{
		return null;
	}

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0xAFE2D0", Offset = "0xAFE2D0", VA = "0xAFE2D0")]
	[IteratorStateMachine(typeof(<shotRuning>d__42))]
	private IEnumerator shotRuning()
	{
		return null;
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0xAFE144", Offset = "0xAFE144", VA = "0xAFE144")]
	private void fight()
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0xAFE440", Offset = "0xAFE440", VA = "0xAFE440")]
	private void fightKinfe()
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0xAFE9D8", Offset = "0xAFE9D8", VA = "0xAFE9D8")]
	public void HackKinfeAni()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0xAFE610", Offset = "0xAFE610", VA = "0xAFE610")]
	private bool fightShot()
	{
		return default(bool);
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xAFEA94", Offset = "0xAFEA94", VA = "0xAFEA94")]
	private void Dedge_Fire()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xAFDF94", Offset = "0xAFDF94", VA = "0xAFDF94")]
	private void TakeAction()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xAFEF9C", Offset = "0xAFEF9C", VA = "0xAFEF9C")]
	private void TakeActionDefault()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xAFEDCC", Offset = "0xAFEDCC", VA = "0xAFEDCC")]
	[IteratorStateMachine(typeof(<TakeActionCrouchA>d__51))]
	private IEnumerator TakeActionCrouchA()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xAFEE40", Offset = "0xAFEE40", VA = "0xAFEE40")]
	[IteratorStateMachine(typeof(<TakeActionCrouchB>d__52))]
	private IEnumerator TakeActionCrouchB()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xAFEEB4", Offset = "0xAFEEB4", VA = "0xAFEEB4")]
	[IteratorStateMachine(typeof(<TakeActionDodgeA>d__53))]
	private IEnumerator TakeActionDodgeA()
	{
		return null;
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xAFEF28", Offset = "0xAFEF28", VA = "0xAFEF28")]
	[IteratorStateMachine(typeof(<TakeActionDodgeB>d__54))]
	private IEnumerator TakeActionDodgeB()
	{
		return null;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xAFF0E0", Offset = "0xAFF0E0", VA = "0xAFF0E0")]
	[IteratorStateMachine(typeof(<SetMuzzleFlash>d__55))]
	private IEnumerator SetMuzzleFlash()
	{
		return null;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xAFF154", Offset = "0xAFF154", VA = "0xAFF154")]
	public void injured(int hurt)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xAFF6F0", Offset = "0xAFF6F0", VA = "0xAFF6F0")]
	public void StopRagDolls()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xAFF19C", Offset = "0xAFF19C", VA = "0xAFF19C")]
	private void die()
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xAFF754", Offset = "0xAFF754", VA = "0xAFF754")]
	public EnemyController()
	{
	}
}
[Token(Token = "0x2000034")]
public struct EventTrigger
{
	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public int id;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public string createPoint;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int trigger;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int gap;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string enemy;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string target;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool isCreate;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string show;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string targetType;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string targetParam;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string drop;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string move;
}
[Token(Token = "0x2000035")]
public class EnemyEnevtTriggerManager : MonoBehaviour
{
	[Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class <crontoller>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000146")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000147")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000148")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyEnevtTriggerManager <>4__this;

		[Token(Token = "0x17000038")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0xB05664", Offset = "0xB05664", VA = "0xB05664", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000039")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0xB056AC", Offset = "0xB056AC", VA = "0xB056AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0xB02B90", Offset = "0xB02B90", VA = "0xB02B90")]
		[DebuggerHidden]
		public <crontoller>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0xB052D8", Offset = "0xB052D8", VA = "0xB052D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0xB052DC", Offset = "0xB052DC", VA = "0xB052DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0xB0566C", Offset = "0xB0566C", VA = "0xB0566C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<EventTrigger> triggerList;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<EventTrigger> liveTriggerList;

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int trigger;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float triggerGapTimer;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject EnemyCreatePoint;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool nextTrigger;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private EnemyTriggerSO enemyTriggerSO;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private EnemyTriggerEventSO _eventSO;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EnemyEnevtTriggerManager _instance;

	[Token(Token = "0x17000037")]
	public static EnemyEnevtTriggerManager Instance
	{
		[Token(Token = "0x6000137")]
		[Address(RVA = "0xB019C0", Offset = "0xB019C0", VA = "0xB019C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0xB01A94", Offset = "0xB01A94", VA = "0xB01A94")]
	private void Start()
	{
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0xB02B64", Offset = "0xB02B64", VA = "0xB02B64")]
	private void Update()
	{
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0xB02AF0", Offset = "0xB02AF0", VA = "0xB02AF0")]
	[IteratorStateMachine(typeof(<crontoller>d__13))]
	private IEnumerator crontoller()
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0xB02BB8", Offset = "0xB02BB8", VA = "0xB02BB8")]
	public void notiftNextTrigger()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0xB02BC8", Offset = "0xB02BC8", VA = "0xB02BC8")]
	private void createEnemy(int id, string EnemyName, string target, string createPoint, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0xB02D8C", Offset = "0xB02D8C", VA = "0xB02D8C")]
	private void createRobot(int id, string EnemyName, string target, string createPoint, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0xB03288", Offset = "0xB03288", VA = "0xB03288")]
	private void createTank(int id, string EnemyName, string target, string createPoint, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0xB03784", Offset = "0xB03784", VA = "0xB03784")]
	private void createBoat(int id, string EnemyName, string target, string createPoint, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0xB03C8C", Offset = "0xB03C8C", VA = "0xB03C8C")]
	private void createHuman(int id, string EnemyName, string target, string createPoint, string targetType, string targetParam, string drop, string move)
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0xB04D44", Offset = "0xB04D44", VA = "0xB04D44")]
	public void reportOverEvent(int id)
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0xB050D0", Offset = "0xB050D0", VA = "0xB050D0")]
	private int getNewTrigger()
	{
		return default(int);
	}

	[Token(Token = "0x6000143")]
	[Address(RVA = "0xB05210", Offset = "0xB05210", VA = "0xB05210")]
	public void startTrigger()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0xB02988", Offset = "0xB02988", VA = "0xB02988")]
	private void copyTriggerList()
	{
	}

	[Token(Token = "0x6000145")]
	[Address(RVA = "0xB01B80", Offset = "0xB01B80", VA = "0xB01B80")]
	public void initTriggleList()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0xB05220", Offset = "0xB05220", VA = "0xB05220")]
	public EnemyEnevtTriggerManager()
	{
	}
}
[Token(Token = "0x2000037")]
[RequireComponent(typeof(Animator))]
public class LookAt : MonoBehaviour
{
	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform head;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector3 lookAtTargetPosition;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool run;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform stopLookAt;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public float lookAtCoolTime;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public float lookAtHeatTime;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool looking;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private Vector3 lookAtPosition;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Animator animator;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float lookAtWeight;

	[Token(Token = "0x600014D")]
	[Address(RVA = "0xB056B4", Offset = "0xB056B4", VA = "0xB056B4")]
	private void Start()
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0xB0581C", Offset = "0xB0581C", VA = "0xB0581C")]
	private void OnAnimatorIK()
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0xB05A84", Offset = "0xB05A84", VA = "0xB05A84")]
	public LookAt()
	{
	}
}
[Token(Token = "0x2000038")]
public class PackController : MonoBehaviour
{
	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Warning;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isWarning;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool isHit;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Afterbumer;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject bombFx;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioCue cue;

	[Token(Token = "0x6000150")]
	[Address(RVA = "0xB05AA4", Offset = "0xB05AA4", VA = "0xB05AA4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0xB05B1C", Offset = "0xB05B1C", VA = "0xB05B1C")]
	public void Hit()
	{
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0xB05D00", Offset = "0xB05D00", VA = "0xB05D00")]
	public void Die()
	{
	}

	[Token(Token = "0x6000153")]
	[Address(RVA = "0xB05DCC", Offset = "0xB05DCC", VA = "0xB05DCC")]
	private void Plus()
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0xB06054", Offset = "0xB06054", VA = "0xB06054")]
	private void Sub()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0xB0620C", Offset = "0xB0620C", VA = "0xB0620C")]
	private void Bomb()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0xB06368", Offset = "0xB06368", VA = "0xB06368")]
	public void setIsHit()
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0xB06374", Offset = "0xB06374", VA = "0xB06374")]
	public PackController()
	{
	}
}
[Token(Token = "0x2000039")]
public class PlaneController : MonoBehaviour
{
	[Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class <RunTo>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000163")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlaneController <>4__this;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x1700003A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000162")]
			[Address(RVA = "0xB06A94", Offset = "0xB06A94", VA = "0xB06A94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000164")]
			[Address(RVA = "0xB06ADC", Offset = "0xB06ADC", VA = "0xB06ADC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0xB067D4", Offset = "0xB067D4", VA = "0xB067D4")]
		[DebuggerHidden]
		public <RunTo>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0xB0680C", Offset = "0xB0680C", VA = "0xB0680C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0xB06810", Offset = "0xB06810", VA = "0xB06810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0xB06A9C", Offset = "0xB06A9C", VA = "0xB06A9C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int PackNum;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private int PackSaveNum;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float PackTimer;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform PackPoint;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform BombPoint;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject bombFx;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioCue audioCue;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 direction;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float angle;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 cross;

	[Token(Token = "0x6000158")]
	[Address(RVA = "0xB0637C", Offset = "0xB0637C", VA = "0xB0637C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0xB063D4", Offset = "0xB063D4", VA = "0xB063D4")]
	private void Update()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0xB06400", Offset = "0xB06400", VA = "0xB06400")]
	public void RunToMethod(Vector3 v, float speed, bool isDestory)
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0xB064FC", Offset = "0xB064FC", VA = "0xB064FC")]
	public void Hit()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xB067CC", Offset = "0xB067CC", VA = "0xB067CC")]
	public int getPackSaveNum()
	{
		return default(int);
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xB06460", Offset = "0xB06460", VA = "0xB06460")]
	[IteratorStateMachine(typeof(<RunTo>d__15))]
	private IEnumerator RunTo(Vector3 v, float speed, bool isDestory)
	{
		return null;
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xB067FC", Offset = "0xB067FC", VA = "0xB067FC")]
	public PlaneController()
	{
	}
}
[Token(Token = "0x200003B")]
public class Plus1Controller : MonoBehaviour
{
	[Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class <RunTo>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400016D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400016E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400016F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Plus1Controller <>4__this;

		[Token(Token = "0x4000170")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x4000171")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float speed;

		[Token(Token = "0x1700003C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0xB06F18", Offset = "0xB06F18", VA = "0xB06F18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0xB06F60", Offset = "0xB06F60", VA = "0xB06F60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0xB06C10", Offset = "0xB06C10", VA = "0xB06C10")]
		[DebuggerHidden]
		public <RunTo>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0xB06C40", Offset = "0xB06C40", VA = "0xB06C40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0xB06C44", Offset = "0xB06C44", VA = "0xB06C44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0xB06F20", Offset = "0xB06F20", VA = "0xB06F20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform startT;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform endT;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Plus;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Sub;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private GameObject playerHead;

	[Token(Token = "0x6000165")]
	[Address(RVA = "0xB06AE4", Offset = "0xB06AE4", VA = "0xB06AE4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xB05F84", Offset = "0xB05F84", VA = "0xB05F84")]
	public void InitS(string sign)
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xB06B74", Offset = "0xB06B74", VA = "0xB06B74")]
	[IteratorStateMachine(typeof(<RunTo>d__7))]
	private IEnumerator RunTo(Vector3 v, float speed, bool isDestory)
	{
		return null;
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xB06C38", Offset = "0xB06C38", VA = "0xB06C38")]
	public Plus1Controller()
	{
	}
}
[Token(Token = "0x200003D")]
public class RobotController : BaseNpcController
{
	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("组件")]
	private AudioCue audioCue;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[Header("目标")]
	private Transform targetTran;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<Transform> targetTrans;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private GameObject Shelters;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private int id;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool arrive;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string move;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private float dis;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float fightShotTimer;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float fightShotCD;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string target;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string targetType;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string drop;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Header("爆炸特效")]
	public GameObject bombFx;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[Tooltip("子弹发射位置")]
	public GameObject bulletPoint;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject ProtectObj;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public LayerMask ValidLayers;

	[Token(Token = "0x600016F")]
	[Address(RVA = "0xB06F68", Offset = "0xB06F68", VA = "0xB06F68")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6000170")]
	[Address(RVA = "0xB06F8C", Offset = "0xB06F8C", VA = "0xB06F8C")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000171")]
	[Address(RVA = "0xB07078", Offset = "0xB07078", VA = "0xB07078")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000172")]
	[Address(RVA = "0xB04218", Offset = "0xB04218", VA = "0xB04218")]
	public void init(int id, string target, string targetType, string targetParam, string drop)
	{
	}

	[Token(Token = "0x6000173")]
	[Address(RVA = "0xB070FC", Offset = "0xB070FC", VA = "0xB070FC")]
	private void controller()
	{
	}

	[Token(Token = "0x6000174")]
	[Address(RVA = "0xB073F8", Offset = "0xB073F8", VA = "0xB073F8")]
	private void TakeAction()
	{
	}

	[Token(Token = "0x6000175")]
	[Address(RVA = "0xB07494", Offset = "0xB07494", VA = "0xB07494")]
	private bool fightShot()
	{
		return default(bool);
	}

	[Token(Token = "0x6000176")]
	[Address(RVA = "0xB07888", Offset = "0xB07888", VA = "0xB07888")]
	public void shotRuning()
	{
	}

	[Token(Token = "0x6000177")]
	[Address(RVA = "0xB07DA4", Offset = "0xB07DA4", VA = "0xB07DA4")]
	public void injured(int atk)
	{
	}

	[Token(Token = "0x6000178")]
	[Address(RVA = "0xB06FFC", Offset = "0xB06FFC", VA = "0xB06FFC")]
	private void protextObj()
	{
	}

	[Token(Token = "0x6000179")]
	[Address(RVA = "0xB07E74", Offset = "0xB07E74", VA = "0xB07E74")]
	private void Die()
	{
	}

	[Token(Token = "0x600017A")]
	[Address(RVA = "0xB0776C", Offset = "0xB0776C", VA = "0xB0776C")]
	private bool getRandomTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x600017B")]
	[Address(RVA = "0xB08020", Offset = "0xB08020", VA = "0xB08020")]
	public RobotController()
	{
	}
}
[Token(Token = "0x200003E")]
public class TankController : BaseNpcController
{
	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("组件")]
	private AudioCue audioCue;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject tower;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("目标")]
	private Transform targetTran;

	[Token(Token = "0x4000186")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private List<Transform> targetTrans;

	[Token(Token = "0x4000187")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private GameObject Shelters;

	[Token(Token = "0x4000188")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int id;

	[Token(Token = "0x4000189")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private bool arrive;

	[Token(Token = "0x400018A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string move;

	[Token(Token = "0x400018B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float dis;

	[Token(Token = "0x400018C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float fightShotTimer;

	[Token(Token = "0x400018D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float fightShotCD;

	[Token(Token = "0x400018E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private string target;

	[Token(Token = "0x400018F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private string targetType;

	[Token(Token = "0x4000190")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private string drop;

	[Token(Token = "0x4000191")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[Header("爆炸特效")]
	public GameObject bombFx;

	[Token(Token = "0x4000192")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject bombYan;

	[Token(Token = "0x4000193")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[Tooltip("子弹发射位置")]
	public GameObject bulletPoint;

	[Token(Token = "0x4000194")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject ProtectObj;

	[Token(Token = "0x4000195")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public LayerMask ValidLayers;

	[Token(Token = "0x600017C")]
	[Address(RVA = "0xB08110", Offset = "0xB08110", VA = "0xB08110")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xB08134", Offset = "0xB08134", VA = "0xB08134")]
	private new void Start()
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0xB08220", Offset = "0xB08220", VA = "0xB08220")]
	private new void Update()
	{
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0xB047B0", Offset = "0xB047B0", VA = "0xB047B0")]
	public void init(int id, string target, string targetType, string targetParam, string drop)
	{
	}

	[Token(Token = "0x6000180")]
	[Address(RVA = "0xB082A4", Offset = "0xB082A4", VA = "0xB082A4")]
	private void controller()
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0xB085A0", Offset = "0xB085A0", VA = "0xB085A0")]
	private void TakeAction()
	{
	}

	[Token(Token = "0x6000182")]
	[Address(RVA = "0xB0866C", Offset = "0xB0866C", VA = "0xB0866C")]
	private bool fightShot()
	{
		return default(bool);
	}

	[Token(Token = "0x6000183")]
	[Address(RVA = "0xB08A60", Offset = "0xB08A60", VA = "0xB08A60")]
	public void shotRuning()
	{
	}

	[Token(Token = "0x6000184")]
	[Address(RVA = "0xB09038", Offset = "0xB09038", VA = "0xB09038")]
	public void injured(int atk)
	{
	}

	[Token(Token = "0x6000185")]
	[Address(RVA = "0xB081A4", Offset = "0xB081A4", VA = "0xB081A4")]
	private void protextObj()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0xB09080", Offset = "0xB09080", VA = "0xB09080")]
	private void Die()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0xB08944", Offset = "0xB08944", VA = "0xB08944")]
	private bool getRandomTarget()
	{
		return default(bool);
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0xB0926C", Offset = "0xB0926C", VA = "0xB0926C")]
	private void Yan()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0xB0937C", Offset = "0xB0937C", VA = "0xB0937C")]
	public TankController()
	{
	}
}
[Token(Token = "0x200003F")]
public class ThiefController : BaseNpcController
{
	[Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class <RunTo>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400019D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400019E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400019F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ThiefController <>4__this;

		[Token(Token = "0x40001A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x40001A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x40001A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isDestory;

		[Token(Token = "0x40001A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <dis>5__2;

		[Token(Token = "0x1700003E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0xB0A48C", Offset = "0xB0A48C", VA = "0xB0A48C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0xB0A4D4", Offset = "0xB0A4D4", VA = "0xB0A4D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0xB09CF0", Offset = "0xB09CF0", VA = "0xB09CF0")]
		[DebuggerHidden]
		public <RunTo>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0xB0A0E8", Offset = "0xB0A0E8", VA = "0xB0A0E8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0xB0A0EC", Offset = "0xB0A0EC", VA = "0xB0A0EC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0xB0A494", Offset = "0xB0A494", VA = "0xB0A494", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000196")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int HP;

	[Token(Token = "0x4000197")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Rigidbody[] RagDolls;

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject baohu;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Header("SO")]
	public ThiefDataSO so;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public ThiefEventSO _eventSO;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Header("制剂桶")]
	private GameObject PackObj;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public GameObject Safeguard;

	[Token(Token = "0x600018A")]
	[Address(RVA = "0xB0946C", Offset = "0xB0946C", VA = "0xB0946C")]
	private new void Start()
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0xB0952C", Offset = "0xB0952C", VA = "0xB0952C")]
	private new void Update()
	{
	}

	[Token(Token = "0x600018C")]
	[Address(RVA = "0xB09748", Offset = "0xB09748", VA = "0xB09748")]
	public void InitS(string EnemyNum)
	{
	}

	[Token(Token = "0x600018D")]
	[Address(RVA = "0xB09BB8", Offset = "0xB09BB8", VA = "0xB09BB8")]
	public void RunToMethod(Vector3 v, string aniStr, bool isDestory, string EnemyNum)
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0xB09C30", Offset = "0xB09C30", VA = "0xB09C30")]
	[IteratorStateMachine(typeof(<RunTo>d__11))]
	private IEnumerator RunTo(Vector3 v, string aniStr, bool isDestory)
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0xB09D18", Offset = "0xB09D18", VA = "0xB09D18")]
	public void Die()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0xB0A074", Offset = "0xB0A074", VA = "0xB0A074")]
	public void StopRagDolls()
	{
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0xB09470", Offset = "0xB09470", VA = "0xB09470")]
	private void BaohuLookAt()
	{
	}

	[Token(Token = "0x6000192")]
	[Address(RVA = "0xB0A0D8", Offset = "0xB0A0D8", VA = "0xB0A0D8")]
	public ThiefController()
	{
	}
}
[Token(Token = "0x2000041")]
public class CameraCapture : MonoBehaviour
{
	[Token(Token = "0x2000042")]
	public enum CaptureSize
	{
		[Token(Token = "0x40001AA")]
		CameraSize,
		[Token(Token = "0x40001AB")]
		ScreenResolution,
		[Token(Token = "0x40001AC")]
		FixedSize
	}

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Camera targetCamera;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public CaptureSize captureSize;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector2 pixelSize;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string savePath;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string fileName;

	[Token(Token = "0x6000199")]
	[Address(RVA = "0xB0A4DC", Offset = "0xB0A4DC", VA = "0xB0A4DC")]
	public void saveCapture()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0xB0AA2C", Offset = "0xB0AA2C", VA = "0xB0AA2C")]
	public static Texture2D capture(Camera camera)
	{
		return null;
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0xB0A848", Offset = "0xB0A848", VA = "0xB0A848")]
	public static Texture2D capture(Camera camera, int width, int height)
	{
		return null;
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0xB0AA04", Offset = "0xB0AA04", VA = "0xB0AA04")]
	public static void saveTexture(string path, Texture2D texture)
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0xB0AA64", Offset = "0xB0AA64", VA = "0xB0AA64")]
	public CameraCapture()
	{
	}
}
[Token(Token = "0x2000043")]
[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class CombineMesh : MonoBehaviour
{
	[Token(Token = "0x600019E")]
	[Address(RVA = "0xB0AAE8", Offset = "0xB0AAE8", VA = "0xB0AAE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600019F")]
	[Address(RVA = "0xB0AD58", Offset = "0xB0AD58", VA = "0xB0AD58")]
	public CombineMesh()
	{
	}
}
[Token(Token = "0x2000044")]
public class PlayerPrefsConstant : MonoBehaviour
{
	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static string isFrist;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static int InitLanguage;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static float heightY;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string HeightSectionInt;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string BGM;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string SoundEffect;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static string LeftHand;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static string Aim;

	[Token(Token = "0x40001B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static string ThisLevel;

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static string MaxLevel;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static string Difficulty;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static string LevelBattleReport;

	[Token(Token = "0x40001B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static string Language;

	[Token(Token = "0x40001BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static string Level1Name;

	[Token(Token = "0x40001BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static string Level2Name;

	[Token(Token = "0x40001BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static string Level3Name;

	[Token(Token = "0x40001BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static string Level4Name;

	[Token(Token = "0x40001BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static string Level5Name;

	[Token(Token = "0x40001BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static string Level6Name;

	[Token(Token = "0x40001C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static string Level7Name;

	[Token(Token = "0x40001C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public static string Level8Name;

	[Token(Token = "0x40001C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public static string Level1EName;

	[Token(Token = "0x40001C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public static string Level2EName;

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public static string Level3EName;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public static string Level4EName;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public static string Level5EName;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public static string Level6EName;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public static string Level7EName;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public static string Level8EName;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public static string Level1PrimaryTask;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public static string Level2PrimaryTask;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public static string Level3PrimaryTask;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public static string Level4PrimaryTask;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public static string Level5PrimaryTask;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public static string Level6PrimaryTask;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public static string Level7PrimaryTask;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public static string Level8PrimaryTask;

	[Token(Token = "0x40001D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public static string Level1EPrimaryTask;

	[Token(Token = "0x40001D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public static string Level2EPrimaryTask;

	[Token(Token = "0x40001D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public static string Level3EPrimaryTask;

	[Token(Token = "0x40001D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public static string Level4EPrimaryTask;

	[Token(Token = "0x40001D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public static string Level5EPrimaryTask;

	[Token(Token = "0x40001D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public static string Level6EPrimaryTask;

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public static string Level7EPrimaryTask;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public static string Level8EPrimaryTask;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public static string Level1MinorTask;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public static string Level2MinorTask;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public static string Level3MinorTask;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public static string Level4MinorTask;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public static string Level5MinorTask;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public static string Level6MinorTask;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public static string Level7MinorTask;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public static string Level8MinorTask;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public static string Level1EMinorTask;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public static string Level2EMinorTask;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public static string Level3EMinorTask;

	[Token(Token = "0x40001E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	public static string Level4EMinorTask;

	[Token(Token = "0x40001E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public static string Level5EMinorTask;

	[Token(Token = "0x40001E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public static string Level6EMinorTask;

	[Token(Token = "0x40001E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public static string Level7EMinorTask;

	[Token(Token = "0x40001E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public static string Level8EMinorTask;

	[Token(Token = "0x60001A0")]
	[Address(RVA = "0xB0AD60", Offset = "0xB0AD60", VA = "0xB0AD60")]
	public PlayerPrefsConstant()
	{
	}
}
[Token(Token = "0x2000045")]
public class PrimaryHandGUIController : MonoBehaviour
{
	[Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class <fire>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrimaryHandGUIController <>4__this;

		[Token(Token = "0x17000040")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001AE")]
			[Address(RVA = "0xB0C794", Offset = "0xB0C794", VA = "0xB0C794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000041")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0xB0C7DC", Offset = "0xB0C7DC", VA = "0xB0C7DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0xB0C490", Offset = "0xB0C490", VA = "0xB0C490")]
		[DebuggerHidden]
		public <fire>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0xB0C724", Offset = "0xB0C724", VA = "0xB0C724", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0xB0C728", Offset = "0xB0C728", VA = "0xB0C728", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0xB0C79C", Offset = "0xB0C79C", VA = "0xB0C79C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRController PrimaryController;

	[Token(Token = "0x40001EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject weaponObj;

	[Token(Token = "0x40001EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform gunEnd;

	[Token(Token = "0x40001ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Rigidbody ShowBullet;

	[Token(Token = "0x40001EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isFire;

	[Token(Token = "0x40001EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string weapon;

	[Token(Token = "0x40001F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Animator ani;

	[Token(Token = "0x40001F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public LineRenderer rayLine;

	[Token(Token = "0x40001F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI NumText;

	[Token(Token = "0x40001F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("事件处理")]
	private UIEventHandler UIEvent;

	[Token(Token = "0x40001F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private AudioCue audioCue;

	[Token(Token = "0x40001F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isClick;

	[Token(Token = "0x40001F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private string hitAniName;

	[Token(Token = "0x60001A2")]
	[Address(RVA = "0xB0B770", Offset = "0xB0B770", VA = "0xB0B770")]
	private void Start()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0xB0B8C0", Offset = "0xB0B8C0", VA = "0xB0B8C0")]
	private void Update()
	{
	}

	[Token(Token = "0x60001A4")]
	[Address(RVA = "0xB0B8C4", Offset = "0xB0B8C4", VA = "0xB0B8C4")]
	private void RayHIt()
	{
	}

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0xB0BD4C", Offset = "0xB0BD4C", VA = "0xB0BD4C")]
	private void HoldLeftHand(LeftHandModelSO so)
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0xB0BD50", Offset = "0xB0BD50", VA = "0xB0BD50")]
	private void test()
	{
	}

	[Token(Token = "0x60001A7")]
	[Address(RVA = "0xB0BCD8", Offset = "0xB0BCD8", VA = "0xB0BCD8")]
	[IteratorStateMachine(typeof(<fire>d__18))]
	private IEnumerator fire()
	{
		return null;
	}

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0xB0C4B8", Offset = "0xB0C4B8", VA = "0xB0C4B8")]
	private void FireShot()
	{
	}

	[Token(Token = "0x60001A9")]
	[Address(RVA = "0xB0BCBC", Offset = "0xB0BCBC", VA = "0xB0BCBC")]
	private void clickUI(UIModuleSO so)
	{
	}

	[Token(Token = "0x60001AA")]
	[Address(RVA = "0xB0C6A0", Offset = "0xB0C6A0", VA = "0xB0C6A0")]
	public PrimaryHandGUIController()
	{
	}
}
[Token(Token = "0x2000047")]
public class TouchDieController : MonoBehaviour
{
	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform playerTran;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform thisTransform;

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0xB0C7E4", Offset = "0xB0C7E4", VA = "0xB0C7E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0xB0C870", Offset = "0xB0C870", VA = "0xB0C870")]
	private void checkPlayerDie()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0xB0C990", Offset = "0xB0C990", VA = "0xB0C990")]
	public TouchDieController()
	{
	}
}
[Token(Token = "0x2000048")]
public class TwoHand : XRGrabInteractable
{
	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public XRSimpleInteractable secondHandGrabPoint;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private XRBaseInteractor secondInteractor;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public GameObject PrimaryHand;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public TextMeshProUGUI textA;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private bool isShow;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
	private bool isHide;

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0xB0C998", Offset = "0xB0C998", VA = "0xB0C998")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0xB0CB44", Offset = "0xB0CB44", VA = "0xB0CB44")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0xB0CB48", Offset = "0xB0CB48", VA = "0xB0CB48", Slot = "16")]
	public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0xB0CD08", Offset = "0xB0CD08", VA = "0xB0CD08")]
	public void OnSecondHandGrab(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0xB0CD18", Offset = "0xB0CD18", VA = "0xB0CD18")]
	public void OnSecondHandRelease(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0xB0CD2C", Offset = "0xB0CD2C", VA = "0xB0CD2C")]
	public void showA(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0xB0CD60", Offset = "0xB0CD60", VA = "0xB0CD60")]
	public void hideA(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0xB0CD98", Offset = "0xB0CD98", VA = "0xB0CD98")]
	public TwoHand()
	{
	}
}
[Token(Token = "0x2000049")]
public class UIEventListener : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
{
	[Token(Token = "0x200004A")]
	public delegate void UIEventProxy(GameObject gb);

	[Token(Token = "0x14000001")]
	public event UIEventProxy OnClick
	{
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0xB0CDA8", Offset = "0xB0CDA8", VA = "0xB0CDA8")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0xB0CE44", Offset = "0xB0CE44", VA = "0xB0CE44")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event UIEventProxy OnMouseEnter
	{
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0xB0CEE0", Offset = "0xB0CEE0", VA = "0xB0CEE0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0xB0CF7C", Offset = "0xB0CF7C", VA = "0xB0CF7C")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event UIEventProxy OnMouseExit
	{
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0xB0D018", Offset = "0xB0D018", VA = "0xB0D018")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0xB0D0B4", Offset = "0xB0D0B4", VA = "0xB0D0B4")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0xB0D150", Offset = "0xB0D150", VA = "0xB0D150", Slot = "4")]
	public void OnPointerClick(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0xB0D188", Offset = "0xB0D188", VA = "0xB0D188", Slot = "5")]
	public void OnPointerEnter(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0xB0D1C0", Offset = "0xB0D1C0", VA = "0xB0D1C0", Slot = "6")]
	public void OnPointerExit(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0xB0D1F8", Offset = "0xB0D1F8", VA = "0xB0D1F8")]
	public UIEventListener()
	{
	}
}
[Token(Token = "0x200004B")]
public class XRBGMController : MonoBehaviour
{
	[Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class <PlayBgm>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRBGMController <>4__this;

		[Token(Token = "0x17000042")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0xB0D7B8", Offset = "0xB0D7B8", VA = "0xB0D7B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000043")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0xB0D800", Offset = "0xB0D800", VA = "0xB0D800", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xB0D4BC", Offset = "0xB0D4BC", VA = "0xB0D4BC")]
		[DebuggerHidden]
		public <PlayBgm>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xB0D4F4", Offset = "0xB0D4F4", VA = "0xB0D4F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D1")]
		[Address(RVA = "0xB0D4F8", Offset = "0xB0D4F8", VA = "0xB0D4F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D3")]
		[Address(RVA = "0xB0D7C0", Offset = "0xB0D7C0", VA = "0xB0D7C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000205")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioSource audioSource;

	[Token(Token = "0x4000206")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public List<AudioClip> audios;

	[Token(Token = "0x4000207")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int playIndex;

	[Token(Token = "0x4000208")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float playVolume;

	[Token(Token = "0x4000209")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool playLoop;

	[Token(Token = "0x400020A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool isPlay;

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0xB0D2F4", Offset = "0xB0D2F4", VA = "0xB0D2F4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0xB0D328", Offset = "0xB0D328", VA = "0xB0D328")]
	public void PlayBgmIndex(int index, float volume, bool loop)
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0xB0D448", Offset = "0xB0D448", VA = "0xB0D448")]
	[IteratorStateMachine(typeof(<PlayBgm>d__8))]
	private IEnumerator PlayBgm()
	{
		return null;
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0xB0D398", Offset = "0xB0D398", VA = "0xB0D398")]
	private void StopBgm()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0xB0D4E4", Offset = "0xB0D4E4", VA = "0xB0D4E4")]
	public XRBGMController()
	{
	}
}
[Token(Token = "0x200004D")]
public class XRConfigController : MonoBehaviour
{
	[Token(Token = "0x400020E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRRig xRRig;

	[Token(Token = "0x400020F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CharacterController character;

	[Token(Token = "0x4000210")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform CameraOffsetTran;

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0xB0D808", Offset = "0xB0D808", VA = "0xB0D808")]
	private void Start()
	{
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0xB0D8E4", Offset = "0xB0D8E4", VA = "0xB0D8E4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001D7")]
	[Address(RVA = "0xB0D80C", Offset = "0xB0D80C", VA = "0xB0D80C")]
	public void Height()
	{
	}

	[Token(Token = "0x60001D8")]
	[Address(RVA = "0xB0D8E8", Offset = "0xB0D8E8", VA = "0xB0D8E8")]
	public XRConfigController()
	{
	}
}
[Token(Token = "0x200004E")]
public class XRTeleportionRayController : MonoBehaviour
{
	[Token(Token = "0x4000211")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRController PrimaryXRRay;

	[Token(Token = "0x4000212")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public InputHelpers.Button teleportActivationButton;

	[Token(Token = "0x4000213")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float activationThreshold;

	[Token(Token = "0x4000214")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool activated;

	[Token(Token = "0x4000215")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject[] TeleportAreas;

	[Token(Token = "0x4000216")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isOpen;

	[Token(Token = "0x60001D9")]
	[Address(RVA = "0xB0D8F0", Offset = "0xB0D8F0", VA = "0xB0D8F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DA")]
	[Address(RVA = "0xB0D948", Offset = "0xB0D948", VA = "0xB0D948")]
	private void Update()
	{
	}

	[Token(Token = "0x60001DB")]
	[Address(RVA = "0xB0D9F0", Offset = "0xB0D9F0", VA = "0xB0D9F0")]
	public bool CheckIfActivated(XRController controller)
	{
		return default(bool);
	}

	[Token(Token = "0x60001DC")]
	[Address(RVA = "0xB0DA94", Offset = "0xB0DA94", VA = "0xB0DA94")]
	public XRTeleportionRayController()
	{
	}
}
[Token(Token = "0x200004F")]
public class GunPistolHeroineController : MonoBehaviour
{
	[Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class <MuzzleFlashAnimation>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GunPistolHeroineController <>4__this;

		[Token(Token = "0x17000044")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0xB0E0CC", Offset = "0xB0E0CC", VA = "0xB0E0CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000045")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0xB0E114", Offset = "0xB0E114", VA = "0xB0E114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0xB0DF18", Offset = "0xB0DF18", VA = "0xB0DF18")]
		[DebuggerHidden]
		public <MuzzleFlashAnimation>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0xB0DF50", Offset = "0xB0DF50", VA = "0xB0DF50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0xB0DF54", Offset = "0xB0DF54", VA = "0xB0DF54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0xB0E0D4", Offset = "0xB0E0D4", VA = "0xB0E0D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000217")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("子弹位置")]
	public Transform bulletPoint;

	[Token(Token = "0x4000218")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("子弹预制体")]
	public GameObject Projectile;

	[Token(Token = "0x4000219")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("火光位置")]
	public Transform MuzzleFlash;

	[Token(Token = "0x400021A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AudioSource audioSource;

	[Token(Token = "0x400021B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float ShotForce;

	[Token(Token = "0x400021C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AudioCue audioCue;

	[Token(Token = "0x60001DD")]
	[Address(RVA = "0xB0DAA8", Offset = "0xB0DAA8", VA = "0xB0DAA8")]
	private void Start()
	{
	}

	[Token(Token = "0x60001DE")]
	[Address(RVA = "0xB0DB38", Offset = "0xB0DB38", VA = "0xB0DB38")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001DF")]
	[Address(RVA = "0xB0DB40", Offset = "0xB0DB40", VA = "0xB0DB40")]
	public void fire(Transform target)
	{
	}

	[Token(Token = "0x60001E0")]
	[Address(RVA = "0xB0DEA4", Offset = "0xB0DEA4", VA = "0xB0DEA4")]
	[IteratorStateMachine(typeof(<MuzzleFlashAnimation>d__9))]
	private IEnumerator MuzzleFlashAnimation()
	{
		return null;
	}

	[Token(Token = "0x60001E1")]
	[Address(RVA = "0xB0DBB0", Offset = "0xB0DBB0", VA = "0xB0DBB0")]
	private void shot(Transform target)
	{
	}

	[Token(Token = "0x60001E2")]
	[Address(RVA = "0xB0DF40", Offset = "0xB0DF40", VA = "0xB0DF40")]
	public GunPistolHeroineController()
	{
	}
}
[Token(Token = "0x2000051")]
public class HeroineController : BaseNpcController
{
	[Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class <SlowMotion>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400023C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400023D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400023E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float <f>5__2;

		[Token(Token = "0x17000046")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0xB0FF90", Offset = "0xB0FF90", VA = "0xB0FF90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000047")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xB0FFD8", Offset = "0xB0FFD8", VA = "0xB0FFD8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0xB0E970", Offset = "0xB0E970", VA = "0xB0E970")]
		[DebuggerHidden]
		public <SlowMotion>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0xB0FEA0", Offset = "0xB0FEA0", VA = "0xB0FEA0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0xB0FEA4", Offset = "0xB0FEA4", VA = "0xB0FEA4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0xB0FF98", Offset = "0xB0FF98", VA = "0xB0FF98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class <GoTo>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HeroineController <>4__this;

		[Token(Token = "0x4000244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform tran;

		[Token(Token = "0x4000245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string aniStr;

		[Token(Token = "0x4000246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinDis;

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Transform lookAtV;

		[Token(Token = "0x17000048")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600020D")]
			[Address(RVA = "0xB1023C", Offset = "0xB1023C", VA = "0xB1023C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000049")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020F")]
			[Address(RVA = "0xB10284", Offset = "0xB10284", VA = "0xB10284", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0xB0F6F4", Offset = "0xB0F6F4", VA = "0xB0F6F4")]
		[DebuggerHidden]
		public <GoTo>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0xB10070", Offset = "0xB10070", VA = "0xB10070", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0xB10074", Offset = "0xB10074", VA = "0xB10074", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0xB10244", Offset = "0xB10244", VA = "0xB10244", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class <GoToV>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400024A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HeroineController <>4__this;

		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MinDis;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Transform lookAtV;

		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private float <dis>5__2;

		[Token(Token = "0x1700004A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000213")]
			[Address(RVA = "0xB1080C", Offset = "0xB1080C", VA = "0xB1080C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000215")]
			[Address(RVA = "0xB10854", Offset = "0xB10854", VA = "0xB10854", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0xB0F7EC", Offset = "0xB0F7EC", VA = "0xB0F7EC")]
		[DebuggerHidden]
		public <GoToV>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0xB1028C", Offset = "0xB1028C", VA = "0xB1028C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0xB10290", Offset = "0xB10290", VA = "0xB10290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0xB10814", Offset = "0xB10814", VA = "0xB10814", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class <talkStr>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HeroineController <>4__this;

		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string animation;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string talk;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool skip;

		[Token(Token = "0x1700004C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000219")]
			[Address(RVA = "0xB1099C", Offset = "0xB1099C", VA = "0xB1099C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0xB109E4", Offset = "0xB109E4", VA = "0xB109E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0xB0F8E0", Offset = "0xB0F8E0", VA = "0xB0F8E0")]
		[DebuggerHidden]
		public <talkStr>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0xB1085C", Offset = "0xB1085C", VA = "0xB1085C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0xB10860", Offset = "0xB10860", VA = "0xB10860", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0xB109A4", Offset = "0xB109A4", VA = "0xB109A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class <TypeText>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HeroineController <>4__this;

		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showSkip;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string msg;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private char[] <>7__wrap1;

		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <>7__wrap2;

		[Token(Token = "0x1700004E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0xB10E18", Offset = "0xB10E18", VA = "0xB10E18", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0xB10E60", Offset = "0xB10E60", VA = "0xB10E60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0xB0F9A4", Offset = "0xB0F9A4", VA = "0xB0F9A4")]
		[DebuggerHidden]
		public <TypeText>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0xB109EC", Offset = "0xB109EC", VA = "0xB109EC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0xB109F0", Offset = "0xB109F0", VA = "0xB109F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0xB10E20", Offset = "0xB10E20", VA = "0xB10E20", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000220")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private float dis;

	[Token(Token = "0x4000221")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform Head;

	[Token(Token = "0x4000222")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Transform playerTran;

	[Token(Token = "0x4000223")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public float followDis;

	[Token(Token = "0x4000224")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public float stopDis;

	[Token(Token = "0x4000225")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public float triggerDis;

	[Token(Token = "0x4000226")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool isDialogue;

	[Token(Token = "0x4000227")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDD")]
	private bool isHoldGun;

	[Token(Token = "0x4000228")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public GameObject gun;

	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public bool isFeight;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool isTalk;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEA")]
	private bool isTalking;

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float printCD;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshProUGUI hudText;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private AudioSource audioSource;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private float fireTimer;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
	private float fireCD;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private GunPistolHeroineController gunPistolHeroineController;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public AudioCue audioCue;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private bool followPlayer;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x119")]
	private bool isRun;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11A")]
	private bool isShot;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private string fireType;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public AudioClip WalkClip;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public AudioClip RunClip;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public LayerMask ValidLayers;

	[Token(Token = "0x400023A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Transform TargetTran;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public NavMeshObstacle navMeshObstacle;

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0xB0E11C", Offset = "0xB0E11C", VA = "0xB0E11C")]
	private new void Awake()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0xB0E320", Offset = "0xB0E320", VA = "0xB0E320")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0xB0E414", Offset = "0xB0E414", VA = "0xB0E414")]
	private new void Start()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0xB0E41C", Offset = "0xB0E41C", VA = "0xB0E41C")]
	private new void Update()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0xB0E654", Offset = "0xB0E654", VA = "0xB0E654")]
	private void controll()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0xB0E854", Offset = "0xB0E854", VA = "0xB0E854")]
	private void doPlayerDataSO(PlayerDataSO so)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0xB0E910", Offset = "0xB0E910", VA = "0xB0E910")]
	[IteratorStateMachine(typeof(<SlowMotion>d__34))]
	private IEnumerator SlowMotion()
	{
		return null;
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0xB0E664", Offset = "0xB0E664", VA = "0xB0E664")]
	private void fightControll()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0xB0E998", Offset = "0xB0E998", VA = "0xB0E998")]
	private void fire()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0xB0F624", Offset = "0xB0F624", VA = "0xB0F624")]
	[IteratorStateMachine(typeof(<GoTo>d__37))]
	public IEnumerator GoTo(Transform tran, string aniStr, float MinDis, [Optional] Transform lookAtV)
	{
		return null;
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0xB0F71C", Offset = "0xB0F71C", VA = "0xB0F71C")]
	[IteratorStateMachine(typeof(<GoToV>d__38))]
	public IEnumerator GoToV(Vector3 v, string aniStr, float MinDis, [Optional] Transform lookAtV)
	{
		return null;
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0xB0F814", Offset = "0xB0F814", VA = "0xB0F814")]
	[IteratorStateMachine(typeof(<talkStr>d__39))]
	public IEnumerator talkStr(string animation, string talk, AudioClip clip, bool skip = false)
	{
		return null;
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0xB0F908", Offset = "0xB0F908", VA = "0xB0F908")]
	[IteratorStateMachine(typeof(<TypeText>d__40))]
	public IEnumerator TypeText(string msg, bool showSkip = false)
	{
		return null;
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0xB0F9CC", Offset = "0xB0F9CC", VA = "0xB0F9CC")]
	public void cleanTalkText()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0xB0FA54", Offset = "0xB0FA54", VA = "0xB0FA54")]
	public void startAni2Bool(string animation)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0xB0FB14", Offset = "0xB0FB14", VA = "0xB0FB14")]
	public void startAni2Trigger(string animation)
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0xB0FBD0", Offset = "0xB0FBD0", VA = "0xB0FBD0")]
	public bool isAni2Bool(string animation)
	{
		return default(bool);
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0xB0FBEC", Offset = "0xB0FBEC", VA = "0xB0FBEC")]
	public void stoptAni2Bool(string animation)
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0xB0FCAC", Offset = "0xB0FCAC", VA = "0xB0FCAC")]
	public void holdFight()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0xB0FD98", Offset = "0xB0FD98", VA = "0xB0FD98")]
	public void overFight()
	{
	}

	[Token(Token = "0x60001FD")]
	[Address(RVA = "0xB0FDE8", Offset = "0xB0FDE8", VA = "0xB0FDE8")]
	public void StopAll()
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0xB0E8F4", Offset = "0xB0E8F4", VA = "0xB0E8F4")]
	public void talkAudioCue(int index)
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0xB0FE10", Offset = "0xB0FE10", VA = "0xB0FE10")]
	public void setRun(bool run)
	{
	}

	[Token(Token = "0x6000200")]
	[Address(RVA = "0xB0FE1C", Offset = "0xB0FE1C", VA = "0xB0FE1C")]
	public HeroineController()
	{
	}
}
[Token(Token = "0x2000058")]
public class HeroineStandController : MonoBehaviour
{
	[Token(Token = "0x2000059")]
	public enum FireType
	{
		[Token(Token = "0x4000260")]
		Fire_1,
		[Token(Token = "0x4000261")]
		Fire_2
	}

	[Token(Token = "0x400025E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FireType fireType;

	[Token(Token = "0x6000222")]
	[Address(RVA = "0xB10E68", Offset = "0xB10E68", VA = "0xB10E68")]
	public HeroineStandController()
	{
	}
}
[Token(Token = "0x200005A")]
public class IDCanvasController : MonoBehaviour
{
	[Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class <ScaleAnimation>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IDCanvasController <>4__this;

		[Token(Token = "0x17000050")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0xB112D8", Offset = "0xB112D8", VA = "0xB112D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xB11320", Offset = "0xB11320", VA = "0xB11320", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0xB111B8", Offset = "0xB111B8", VA = "0xB111B8")]
		[DebuggerHidden]
		public <ScaleAnimation>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0xB11234", Offset = "0xB11234", VA = "0xB11234", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0xB11238", Offset = "0xB11238", VA = "0xB11238", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0xB112E0", Offset = "0xB112E0", VA = "0xB112E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000262")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject IdCanvas;

	[Token(Token = "0x4000263")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Article;

	[Token(Token = "0x4000264")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image Head;

	[Token(Token = "0x4000265")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI NameStr;

	[Token(Token = "0x4000266")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI RoleStr;

	[Token(Token = "0x4000267")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI GoodAtStr;

	[Token(Token = "0x4000268")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI Content;

	[Token(Token = "0x4000269")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject Stroy;

	[Token(Token = "0x400026A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Image Cover;

	[Token(Token = "0x400026B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI ContentStr;

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public float MinScale;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float MaxScale;

	[Token(Token = "0x400026E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float scale;

	[Token(Token = "0x400026F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI testText;

	[Token(Token = "0x6000223")]
	[Address(RVA = "0xB10E70", Offset = "0xB10E70", VA = "0xB10E70")]
	public void Inits(Level0RoleDataSO so)
	{
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xB11078", Offset = "0xB11078", VA = "0xB11078")]
	public void InitStory(Level0PlotDataSO so)
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xB11004", Offset = "0xB11004", VA = "0xB11004")]
	[IteratorStateMachine(typeof(<ScaleAnimation>d__16))]
	private IEnumerator ScaleAnimation()
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xB111E0", Offset = "0xB111E0", VA = "0xB111E0")]
	public void close()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xB11210", Offset = "0xB11210", VA = "0xB11210")]
	private void Start()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xB11214", Offset = "0xB11214", VA = "0xB11214")]
	private void Update()
	{
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xB11218", Offset = "0xB11218", VA = "0xB11218")]
	public IDCanvasController()
	{
	}
}
[Token(Token = "0x200005C")]
public class OptionController : MonoBehaviour
{
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Head_Course;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Head_Assist;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Head_Opt;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Image HeadCourseImg;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Image HeadAssistImg;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Image HeadOptImg;

	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject Course;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject Assist;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject Opt;

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xB11328", Offset = "0xB11328", VA = "0xB11328")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xB11334", Offset = "0xB11334", VA = "0xB11334")]
	private void Start()
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xB115E4", Offset = "0xB115E4", VA = "0xB115E4")]
	public void clickCouse()
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xB116B0", Offset = "0xB116B0", VA = "0xB116B0")]
	public void clickAssist()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xB1177C", Offset = "0xB1177C", VA = "0xB1177C")]
	public void clickOpt()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xB11848", Offset = "0xB11848", VA = "0xB11848")]
	public OptionController()
	{
	}
}
[Token(Token = "0x200005D")]
public class PlotCheckController : MonoBehaviour
{
	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI testText;

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isRoleCheck;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform RoleCheck;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform RoleUnCheck;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform RoleHover;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform PlotCheck;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform PlotUnCheck;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform PlotHover;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform ContentPlot;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform ContentRole;

	[Token(Token = "0x6000239")]
	[Address(RVA = "0xB1185C", Offset = "0xB1185C", VA = "0xB1185C")]
	private void Start()
	{
	}

	[Token(Token = "0x600023A")]
	[Address(RVA = "0xB11860", Offset = "0xB11860", VA = "0xB11860")]
	public void CheckRole()
	{
	}

	[Token(Token = "0x600023B")]
	[Address(RVA = "0xB1197C", Offset = "0xB1197C", VA = "0xB1197C")]
	public void EnterHoverRole()
	{
	}

	[Token(Token = "0x600023C")]
	[Address(RVA = "0xB119A8", Offset = "0xB119A8", VA = "0xB119A8")]
	public void ExitHoverRole()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xB119D4", Offset = "0xB119D4", VA = "0xB119D4")]
	public void CheckPlot()
	{
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xB11AF0", Offset = "0xB11AF0", VA = "0xB11AF0")]
	public void EnterHoverPlot()
	{
	}

	[Token(Token = "0x600023F")]
	[Address(RVA = "0xB11B1C", Offset = "0xB11B1C", VA = "0xB11B1C")]
	public void ExitHoverPlot()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xB11B48", Offset = "0xB11B48", VA = "0xB11B48")]
	public PlotCheckController()
	{
	}
}
[Token(Token = "0x200005E")]
public class StartCanvasController : MonoBehaviour
{
	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button StartButton;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public CheckLevelSO so;

	[Token(Token = "0x6000241")]
	[Address(RVA = "0xB11B58", Offset = "0xB11B58", VA = "0xB11B58")]
	private void Start()
	{
	}

	[Token(Token = "0x6000242")]
	[Address(RVA = "0xB11BEC", Offset = "0xB11BEC", VA = "0xB11BEC")]
	private void loadScene()
	{
	}

	[Token(Token = "0x6000243")]
	[Address(RVA = "0xB11C1C", Offset = "0xB11C1C", VA = "0xB11C1C")]
	public StartCanvasController()
	{
	}
}
[Token(Token = "0x200005F")]
public class StartGameBlockController : MonoBehaviour
{
	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Animator ani;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI testText;

	[Token(Token = "0x6000245")]
	[Address(RVA = "0xB11C28", Offset = "0xB11C28", VA = "0xB11C28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000246")]
	[Address(RVA = "0xB11C80", Offset = "0xB11C80", VA = "0xB11C80")]
	public void EnterHover(XRBaseInteractor interactor)
	{
	}

	[Token(Token = "0x6000247")]
	[Address(RVA = "0xB11D04", Offset = "0xB11D04", VA = "0xB11D04")]
	private void Update()
	{
	}

	[Token(Token = "0x6000248")]
	[Address(RVA = "0xB11D08", Offset = "0xB11D08", VA = "0xB11D08")]
	public StartGameBlockController()
	{
	}
}
[Token(Token = "0x2000060")]
public class TestUpDownController : MonoBehaviour
{
	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Button btn;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Button Down;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI NumText;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public XRController rightController;

	[Token(Token = "0x6000249")]
	[Address(RVA = "0xB11D10", Offset = "0xB11D10", VA = "0xB11D10")]
	private void Awake()
	{
	}

	[Token(Token = "0x600024A")]
	[Address(RVA = "0xB11D14", Offset = "0xB11D14", VA = "0xB11D14")]
	public TestUpDownController()
	{
	}
}
[Token(Token = "0x2000061")]
public class UIBattleReportShower : MonoBehaviour
{
	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("面板")]
	public TextMeshProUGUI ImageTitle;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI ShowNumText;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI HitNumText;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI KillNumText;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI HitRateText;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI HurtNumText;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI AccideNumText;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI LoseNumText;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI FinishText;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshProUGUI ShowNum;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI HitNum;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI KillNum;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI HitRate;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI HurtNum;

	[Token(Token = "0x400029C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI AccideNum;

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public TextMeshProUGUI LoseNum;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI Finish;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private int LevelX;

	[Token(Token = "0x40002A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x600024B")]
	[Address(RVA = "0xB11D1C", Offset = "0xB11D1C", VA = "0xB11D1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0xB12770", Offset = "0xB12770", VA = "0xB12770")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0xB12858", Offset = "0xB12858", VA = "0xB12858")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0xB12A94", Offset = "0xB12A94", VA = "0xB12A94")]
	private void CheckB1(UIModuleSO so)
	{
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0xB12A9C", Offset = "0xB12A9C", VA = "0xB12A9C")]
	private void CheckB2(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0xB12AA4", Offset = "0xB12AA4", VA = "0xB12AA4")]
	private void CheckB3(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0xB12AAC", Offset = "0xB12AAC", VA = "0xB12AAC")]
	private void CheckB4(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0xB12AB4", Offset = "0xB12AB4", VA = "0xB12AB4")]
	private void CheckB5(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0xB12ABC", Offset = "0xB12ABC", VA = "0xB12ABC")]
	private void CheckB6(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000254")]
	[Address(RVA = "0xB11E24", Offset = "0xB11E24", VA = "0xB11E24")]
	private void show(int levelN)
	{
	}

	[Token(Token = "0x6000255")]
	[Address(RVA = "0xB12068", Offset = "0xB12068", VA = "0xB12068")]
	private void InitImageTitle(int levelN)
	{
	}

	[Token(Token = "0x6000256")]
	[Address(RVA = "0xB1242C", Offset = "0xB1242C", VA = "0xB1242C")]
	private void InitLanguage()
	{
	}

	[Token(Token = "0x6000257")]
	[Address(RVA = "0xB12AC4", Offset = "0xB12AC4", VA = "0xB12AC4")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000258")]
	[Address(RVA = "0xB12AC8", Offset = "0xB12AC8", VA = "0xB12AC8")]
	public UIBattleReportShower()
	{
	}
}
[Token(Token = "0x2000062")]
public class UICheckpointShower : MonoBehaviour
{
	[Token(Token = "0x2000063")]
	[CompilerGenerated]
	private sealed class <Fei1_3>d__103 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICheckpointShower <>4__this;

		[Token(Token = "0x17000052")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0xB15930", Offset = "0xB15930", VA = "0xB15930", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000053")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xB15978", Offset = "0xB15978", VA = "0xB15978", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xB153F0", Offset = "0xB153F0", VA = "0xB153F0")]
		[DebuggerHidden]
		public <Fei1_3>d__103(int <>1__state)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xB15418", Offset = "0xB15418", VA = "0xB15418", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xB1541C", Offset = "0xB1541C", VA = "0xB1541C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xB15938", Offset = "0xB15938", VA = "0xB15938", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class <Fei4_6>d__104 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICheckpointShower <>4__this;

		[Token(Token = "0x17000054")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000283")]
			[Address(RVA = "0xB15EE0", Offset = "0xB15EE0", VA = "0xB15EE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000055")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000285")]
			[Address(RVA = "0xB15F28", Offset = "0xB15F28", VA = "0xB15F28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xB15980", Offset = "0xB15980", VA = "0xB15980")]
		[DebuggerHidden]
		public <Fei4_6>d__104(int <>1__state)
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xB159A8", Offset = "0xB159A8", VA = "0xB159A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xB159AC", Offset = "0xB159AC", VA = "0xB159AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xB15EE8", Offset = "0xB15EE8", VA = "0xB15EE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[CompilerGenerated]
	private sealed class <Fei7_8>d__105 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public UICheckpointShower <>4__this;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000289")]
			[Address(RVA = "0xB164B0", Offset = "0xB164B0", VA = "0xB164B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600028B")]
			[Address(RVA = "0xB164F8", Offset = "0xB164F8", VA = "0xB164F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xB15F30", Offset = "0xB15F30", VA = "0xB15F30")]
		[DebuggerHidden]
		public <Fei7_8>d__105(int <>1__state)
		{
		}

		[Token(Token = "0x6000287")]
		[Address(RVA = "0xB15F58", Offset = "0xB15F58", VA = "0xB15F58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xB15F5C", Offset = "0xB15F5C", VA = "0xB15F5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xB164B8", Offset = "0xB164B8", VA = "0xB164B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class <dongBan>d__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int level;

		[Token(Token = "0x4000305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UICheckpointShower <>4__this;

		[Token(Token = "0x4000306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Vector3 <target>5__2;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600028F")]
			[Address(RVA = "0xB16898", Offset = "0xB16898", VA = "0xB16898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0xB168E0", Offset = "0xB168E0", VA = "0xB168E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xB16500", Offset = "0xB16500", VA = "0xB16500")]
		[DebuggerHidden]
		public <dongBan>d__118(int <>1__state)
		{
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xB16528", Offset = "0xB16528", VA = "0xB16528", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xB1652C", Offset = "0xB1652C", VA = "0xB1652C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xB168A0", Offset = "0xB168A0", VA = "0xB168A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("PageOne")]
	public Transform PageOne;

	[Token(Token = "0x40002A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("B1")]
	public Transform B1;

	[Token(Token = "0x40002A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform B1Canvas;

	[Token(Token = "0x40002A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform B1Cover;

	[Token(Token = "0x40002A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform B1Lock;

	[Token(Token = "0x40002A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform B1Title;

	[Token(Token = "0x40002A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform B1Content;

	[Token(Token = "0x40002A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform B1Medal;

	[Token(Token = "0x40002A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("B2")]
	public Transform B2;

	[Token(Token = "0x40002AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform B2Canvas;

	[Token(Token = "0x40002AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform B2Cover;

	[Token(Token = "0x40002AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform B2Lock;

	[Token(Token = "0x40002AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform B2Title;

	[Token(Token = "0x40002AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Transform B2Content;

	[Token(Token = "0x40002AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Transform B2Medal;

	[Token(Token = "0x40002B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[Header("B3")]
	public Transform B3;

	[Token(Token = "0x40002B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform B3Canvas;

	[Token(Token = "0x40002B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Transform B3Cover;

	[Token(Token = "0x40002B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform B3Lock;

	[Token(Token = "0x40002B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Transform B3Title;

	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform B3Content;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform B3Medal;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("PageTwo")]
	public Transform PageTwo;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[Header("B4")]
	public Transform B4;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform B4Canvas;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform B4Cover;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform B4Lock;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Transform B4Title;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform B4Content;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform B4Medal;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Header("B5")]
	public Transform B5;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform B5Canvas;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Transform B5Cover;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Transform B5Lock;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Transform B5Title;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Transform B5Content;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Transform B5Medal;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Header("B6")]
	public Transform B6;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Transform B6Canvas;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Transform B6Cover;

	[Token(Token = "0x40002C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public Transform B6Lock;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Transform B6Title;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Transform B6Content;

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Transform B6Medal;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[Header("PageThree")]
	public Transform PageThree;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[Header("B7")]
	public Transform B7;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public Transform B7Canvas;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public Transform B7Cover;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	public Transform B7Lock;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	public Transform B7Title;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	public Transform B7Content;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	public Transform B7Medal;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	[Header("B8")]
	public Transform B8;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	public Transform B8Canvas;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
	public Transform B8Cover;

	[Token(Token = "0x40002D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
	public Transform B8Lock;

	[Token(Token = "0x40002D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
	public Transform B8Title;

	[Token(Token = "0x40002DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
	public Transform B8Content;

	[Token(Token = "0x40002DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
	public Transform B8Medal;

	[Token(Token = "0x40002DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x40002DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
	[Header("关卡1-3/4-6/7-8")]
	public Transform T1_3;

	[Token(Token = "0x40002DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
	public Transform T4_6;

	[Token(Token = "0x40002DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
	public Transform T7_8;

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
	public Transform Target;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
	public Transform Default;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
	[Header("打把开始")]
	public Transform ShotTarget;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
	public Transform ShotImage;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
	public TextMeshProUGUI Text;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
	[Header("中E文")]
	public TextMeshProUGUI B1ImageTitle;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
	public TextMeshProUGUI B2ImageTitle;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
	public TextMeshProUGUI B3ImageTitle;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
	public TextMeshProUGUI B4ImageTitle;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public TextMeshProUGUI B5ImageTitle;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public TextMeshProUGUI B6ImageTitle;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	public TextMeshProUGUI B7ImageTitle;

	[Token(Token = "0x40002EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	public TextMeshProUGUI B8ImageTitle;

	[Token(Token = "0x40002ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	public TextMeshProUGUI B13ImageTitle;

	[Token(Token = "0x40002EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	public TextMeshProUGUI B13Title;

	[Token(Token = "0x40002EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	public TextMeshProUGUI B46ImageTitle;

	[Token(Token = "0x40002F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	public TextMeshProUGUI B46Title;

	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	public TextMeshProUGUI B78ImageTitle;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	public TextMeshProUGUI B78Title;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	[Header("任务说明版")]
	public GameObject Ban;

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	public TextMeshProUGUI BanLevelText;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	public TextMeshProUGUI BanPrimaryText;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	public TextMeshProUGUI BanMinorText;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	public GameObject BanClose;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
	[SerializeField]
	[Header("Setting")]
	public Image Setting;

	[Token(Token = "0x6000259")]
	[Address(RVA = "0xB12AD8", Offset = "0xB12AD8", VA = "0xB12AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x600025A")]
	[Address(RVA = "0xB13194", Offset = "0xB13194", VA = "0xB13194")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600025B")]
	[Address(RVA = "0xB1327C", Offset = "0xB1327C", VA = "0xB1327C")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x600025C")]
	[Address(RVA = "0xB12C4C", Offset = "0xB12C4C", VA = "0xB12C4C")]
	private void InitLanguage()
	{
	}

	[Token(Token = "0x600025D")]
	[Address(RVA = "0xB136A0", Offset = "0xB136A0", VA = "0xB136A0")]
	private void CheckB1(UIModuleSO so)
	{
	}

	[Token(Token = "0x600025E")]
	[Address(RVA = "0xB137C8", Offset = "0xB137C8", VA = "0xB137C8")]
	private void CheckB2(UIModuleSO so)
	{
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0xB138F0", Offset = "0xB138F0", VA = "0xB138F0")]
	private void CheckB3(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000260")]
	[Address(RVA = "0xB13A18", Offset = "0xB13A18", VA = "0xB13A18")]
	private void CheckB4(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0xB13B40", Offset = "0xB13B40", VA = "0xB13B40")]
	private void CheckB5(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000262")]
	[Address(RVA = "0xB13C68", Offset = "0xB13C68", VA = "0xB13C68")]
	private void CheckB6(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000263")]
	[Address(RVA = "0xB13D90", Offset = "0xB13D90", VA = "0xB13D90")]
	private void CheckB7(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000264")]
	[Address(RVA = "0xB13EB8", Offset = "0xB13EB8", VA = "0xB13EB8")]
	private void CheckB8(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000265")]
	[Address(RVA = "0xB13FE0", Offset = "0xB13FE0", VA = "0xB13FE0")]
	private void CheckT1_3(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000266")]
	[Address(RVA = "0xB14064", Offset = "0xB14064", VA = "0xB14064")]
	private void CheckT4_6(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000267")]
	[Address(RVA = "0xB140E8", Offset = "0xB140E8", VA = "0xB140E8")]
	private void CheckT7_8(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000268")]
	[Address(RVA = "0xB14CA8", Offset = "0xB14CA8", VA = "0xB14CA8")]
	[IteratorStateMachine(typeof(<Fei1_3>d__103))]
	private IEnumerator Fei1_3()
	{
		return null;
	}

	[Token(Token = "0x6000269")]
	[Address(RVA = "0xB14D1C", Offset = "0xB14D1C", VA = "0xB14D1C")]
	[IteratorStateMachine(typeof(<Fei4_6>d__104))]
	private IEnumerator Fei4_6()
	{
		return null;
	}

	[Token(Token = "0x600026A")]
	[Address(RVA = "0xB14D90", Offset = "0xB14D90", VA = "0xB14D90")]
	[IteratorStateMachine(typeof(<Fei7_8>d__105))]
	private IEnumerator Fei7_8()
	{
		return null;
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0xB1416C", Offset = "0xB1416C", VA = "0xB1416C")]
	private void CheckStartGame(UIModuleSO so)
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0xB12C04", Offset = "0xB12C04", VA = "0xB12C04")]
	private void InitB()
	{
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0xB14E04", Offset = "0xB14E04", VA = "0xB14E04")]
	private void InitB1()
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0xB14EB0", Offset = "0xB14EB0", VA = "0xB14EB0")]
	private void InitB2()
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0xB14F5C", Offset = "0xB14F5C", VA = "0xB14F5C")]
	private void InitB3()
	{
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0xB15008", Offset = "0xB15008", VA = "0xB15008")]
	private void InitB4()
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0xB150B4", Offset = "0xB150B4", VA = "0xB150B4")]
	private void InitB5()
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0xB15160", Offset = "0xB15160", VA = "0xB15160")]
	private void InitB6()
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0xB1520C", Offset = "0xB1520C", VA = "0xB1520C")]
	private void InitB7()
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0xB152B8", Offset = "0xB152B8", VA = "0xB152B8")]
	private void InitB8()
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0xB14220", Offset = "0xB14220", VA = "0xB14220")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0xB14224", Offset = "0xB14224", VA = "0xB14224")]
	private void showBan(int level)
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0xB15364", Offset = "0xB15364", VA = "0xB15364")]
	[IteratorStateMachine(typeof(<dongBan>d__118))]
	private IEnumerator dongBan(int level)
	{
		return null;
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0xB14AD0", Offset = "0xB14AD0", VA = "0xB14AD0")]
	private void InitLevelStar(Transform ImageContent, int starNum)
	{
	}

	[Token(Token = "0x6000279")]
	[Address(RVA = "0xB153E8", Offset = "0xB153E8", VA = "0xB153E8")]
	public UICheckpointShower()
	{
	}
}
[Token(Token = "0x2000067")]
public class UIEventHandler : MonoBehaviour
{
	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private GameObject XRPlayer;

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public UIModuleEventSO _eventSO;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public LeftHandEventSO _leftHandEventSO;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioCue audioCue;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshProUGUI Text;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int CheckBX;

	[Token(Token = "0x6000292")]
	[Address(RVA = "0xB168E8", Offset = "0xB168E8", VA = "0xB168E8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0xB169CC", Offset = "0xB169CC", VA = "0xB169CC")]
	public void onclick(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0xB1746C", Offset = "0xB1746C", VA = "0xB1746C")]
	private void HeightUpDown(UIModuleSO so, bool Add)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0xB17578", Offset = "0xB17578", VA = "0xB17578")]
	private void SetBGM(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0xB17628", Offset = "0xB17628", VA = "0xB17628")]
	private void SetSoundEffect(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000297")]
	[Address(RVA = "0xB176CC", Offset = "0xB176CC", VA = "0xB176CC")]
	private void SetAim(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000298")]
	[Address(RVA = "0xB1777C", Offset = "0xB1777C", VA = "0xB1777C")]
	private void SetLeftHand(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000299")]
	[Address(RVA = "0xB178EC", Offset = "0xB178EC", VA = "0xB178EC")]
	private void SetClose(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029A")]
	[Address(RVA = "0xB17918", Offset = "0xB17918", VA = "0xB17918")]
	private void GlobalSet(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029B")]
	[Address(RVA = "0xB179E0", Offset = "0xB179E0", VA = "0xB179E0")]
	private void CheckB1(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029C")]
	[Address(RVA = "0xB17A60", Offset = "0xB17A60", VA = "0xB17A60")]
	private void CheckB2(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029D")]
	[Address(RVA = "0xB17AE0", Offset = "0xB17AE0", VA = "0xB17AE0")]
	private void CheckB3(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0xB17B60", Offset = "0xB17B60", VA = "0xB17B60")]
	private void CheckB4(UIModuleSO so)
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0xB17BE0", Offset = "0xB17BE0", VA = "0xB17BE0")]
	private void CheckB5(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0xB17C60", Offset = "0xB17C60", VA = "0xB17C60")]
	private void CheckB6(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A1")]
	[Address(RVA = "0xB17CE0", Offset = "0xB17CE0", VA = "0xB17CE0")]
	private void CheckB7(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A2")]
	[Address(RVA = "0xB17D60", Offset = "0xB17D60", VA = "0xB17D60")]
	private void CheckB8(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0xB17DE0", Offset = "0xB17DE0", VA = "0xB17DE0")]
	private void CheckT1_3(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0xB17E34", Offset = "0xB17E34", VA = "0xB17E34")]
	private void CheckT4_6(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0xB17E88", Offset = "0xB17E88", VA = "0xB17E88")]
	private void CheckT7_8(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0xB17EDC", Offset = "0xB17EDC", VA = "0xB17EDC")]
	private void CheckStartGame(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0xB188F8", Offset = "0xB188F8", VA = "0xB188F8")]
	private void startGame()
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0xB17FB0", Offset = "0xB17FB0", VA = "0xB17FB0")]
	private void DiffP1(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0xB18014", Offset = "0xB18014", VA = "0xB18014")]
	private void DiffP2(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0xB18078", Offset = "0xB18078", VA = "0xB18078")]
	private void DiffP3(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0xB180DC", Offset = "0xB180DC", VA = "0xB180DC")]
	private void RoleHeroine(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xB181A4", Offset = "0xB181A4", VA = "0xB181A4")]
	private void RolePlayer(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0xB181D0", Offset = "0xB181D0", VA = "0xB181D0")]
	private void RoleClose(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0xB181FC", Offset = "0xB181FC", VA = "0xB181FC")]
	private void PauseBack(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0xB18220", Offset = "0xB18220", VA = "0xB18220")]
	private void PauseContinue(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0xB182E4", Offset = "0xB182E4", VA = "0xB182E4")]
	private void GameOver(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0xB18310", Offset = "0xB18310", VA = "0xB18310")]
	private void GameOverBack(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0xB18334", Offset = "0xB18334", VA = "0xB18334")]
	private void GameOverContinue(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xB18354", Offset = "0xB18354", VA = "0xB18354")]
	private void Language(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0xB18B2C", Offset = "0xB18B2C", VA = "0xB18B2C")]
	public UIEventHandler()
	{
	}
}
[Token(Token = "0x2000068")]
public class UIGlobalShower : MonoBehaviour
{
	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("设置相关")]
	public Transform SetBoard;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform Set;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0xB18B34", Offset = "0xB18B34", VA = "0xB18B34")]
	private void Start()
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0xB18C1C", Offset = "0xB18C1C", VA = "0xB18C1C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0xB18D04", Offset = "0xB18D04", VA = "0xB18D04")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0xB18D74", Offset = "0xB18D74", VA = "0xB18D74")]
	private void SetButton(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0xB18DF4", Offset = "0xB18DF4", VA = "0xB18DF4")]
	public UIGlobalShower()
	{
	}
}
[Token(Token = "0x2000069")]
public class UIMedalShower : MonoBehaviour
{
	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("荣誉勋章")]
	public TextMeshProUGUI Title;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("Level1")]
	public GameObject Level1Medal;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Level1Text;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Level1Star;

	[Token(Token = "0x4000314")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Level2")]
	public GameObject Level2Medal;

	[Token(Token = "0x4000315")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI Level2Text;

	[Token(Token = "0x4000316")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform Level2Star;

	[Token(Token = "0x4000317")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Level3")]
	public GameObject Level3Medal;

	[Token(Token = "0x4000318")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI Level3Text;

	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform Level3Star;

	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[Header("Level4")]
	public GameObject Level4Medal;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI Level4Text;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Transform Level4Star;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[Header("Level5")]
	public GameObject Level5Medal;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public TextMeshProUGUI Level5Text;

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Transform Level5Star;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("Level6")]
	public GameObject Level6Medal;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public TextMeshProUGUI Level6Text;

	[Token(Token = "0x4000322")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform Level6Star;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("Level7")]
	public GameObject Level7Medal;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI Level7Text;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform Level7Star;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[Header("Level8")]
	public GameObject Level8Medal;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI Level8Text;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform Level8Star;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0xB18DFC", Offset = "0xB18DFC", VA = "0xB18DFC")]
	private void Start()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0xB194FC", Offset = "0xB194FC", VA = "0xB194FC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0xB195E4", Offset = "0xB195E4", VA = "0xB195E4")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0xB19654", Offset = "0xB19654", VA = "0xB19654")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0xB18EEC", Offset = "0xB18EEC", VA = "0xB18EEC")]
	private void show()
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0xB19860", Offset = "0xB19860", VA = "0xB19860")]
	private void InitLevelStar(Transform ImageContent, int starNum)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0xB19A38", Offset = "0xB19A38", VA = "0xB19A38")]
	public UIMedalShower()
	{
	}
}
[Token(Token = "0x200006A")]
public class UIPatternShower : MonoBehaviour
{
	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("P1")]
	public Transform P1;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform P1UnCheck;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform P1Checked;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI P1Text;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("P2")]
	public Transform P2;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform P2UnCheck;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform P2Checked;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI P2Text;

	[Token(Token = "0x4000332")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("P3")]
	public Transform P3;

	[Token(Token = "0x4000333")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform P3UnCheck;

	[Token(Token = "0x4000334")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform P3Checked;

	[Token(Token = "0x4000335")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI P3Text;

	[Token(Token = "0x4000336")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0xB19A40", Offset = "0xB19A40", VA = "0xB19A40")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0xB19D40", Offset = "0xB19D40", VA = "0xB19D40")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0xB19E28", Offset = "0xB19E28", VA = "0xB19E28")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0xB19F44", Offset = "0xB19F44", VA = "0xB19F44")]
	private void DiffP1(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0xB1A078", Offset = "0xB1A078", VA = "0xB1A078")]
	private void DiffP2(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0xB1A1AC", Offset = "0xB1A1AC", VA = "0xB1A1AC")]
	private void DiffP3(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0xB19BD0", Offset = "0xB19BD0", VA = "0xB19BD0")]
	private void Init()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0xB19BF0", Offset = "0xB19BF0", VA = "0xB19BF0")]
	private void InitLanguage()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0xB1A2E4", Offset = "0xB1A2E4", VA = "0xB1A2E4")]
	private void InitP1()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0xB1A41C", Offset = "0xB1A41C", VA = "0xB1A41C")]
	private void InitP3()
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0xB1A380", Offset = "0xB1A380", VA = "0xB1A380")]
	private void InitP2()
	{
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0xB1A2E0", Offset = "0xB1A2E0", VA = "0xB1A2E0")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0xB1A4B8", Offset = "0xB1A4B8", VA = "0xB1A4B8")]
	public UIPatternShower()
	{
	}
}
[Token(Token = "0x200006B")]
public class UIPlaneAreaShower : MonoBehaviour
{
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0xB1A4C0", Offset = "0xB1A4C0", VA = "0xB1A4C0")]
	private void Start()
	{
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0xB1A4C4", Offset = "0xB1A4C4", VA = "0xB1A4C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0xB1A4C8", Offset = "0xB1A4C8", VA = "0xB1A4C8")]
	public UIPlaneAreaShower()
	{
	}
}
[Token(Token = "0x200006C")]
public class UIPushShower : MonoBehaviour
{
	[Token(Token = "0x4000337")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Transform thisTransForm;

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Header("暂停")]
	public Transform PauseWin;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("Over")]
	public Transform GameOverObj;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform OverTextObj;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Header("Win")]
	public Image WinImg;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject cameraObj;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Header("事件触发")]
	public UIModuleEventSO _eventSO;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public WinImgSO winImgSO;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Header("UI")]
	public Image PauseBack;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image PauseContinues;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Image OverBack;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Image OverContinues;

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0xB1A4D0", Offset = "0xB1A4D0", VA = "0xB1A4D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0xB1A744", Offset = "0xB1A744", VA = "0xB1A744")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0xB1A82C", Offset = "0xB1A82C", VA = "0xB1A82C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0xB1A914", Offset = "0xB1A914", VA = "0xB1A914")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0xB1AA90", Offset = "0xB1AA90", VA = "0xB1AA90")]
	private void PauseContinue(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0xB1AA34", Offset = "0xB1AA34", VA = "0xB1AA34")]
	private void PauseOpenWin(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0xB1AAE0", Offset = "0xB1AAE0", VA = "0xB1AAE0")]
	private void GameOver(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0xB1AED8", Offset = "0xB1AED8", VA = "0xB1AED8")]
	private void ShowOver()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0xB1AC48", Offset = "0xB1AC48", VA = "0xB1AC48")]
	private void GameWin(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0xB1AD0C", Offset = "0xB1AD0C", VA = "0xB1AD0C")]
	private void moveToPlayer(float dis)
	{
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0xB1A54C", Offset = "0xB1A54C", VA = "0xB1A54C")]
	private void InitUI()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0xB1AF28", Offset = "0xB1AF28", VA = "0xB1AF28")]
	public UIPushShower()
	{
	}
}
[Token(Token = "0x200006D")]
public class UIRolePhotoShower : MonoBehaviour
{
	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("照片按钮")]
	public Transform HeroineButton;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform PlayerButton;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Header("面板")]
	public Transform Board;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Close;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Image photo;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("黑鹰组织")]
	[SerializeField]
	private TextMeshProUGUI BlackOrg;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextMeshProUGUI Bull;

	[Token(Token = "0x400034B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextMeshProUGUI Hound;

	[Token(Token = "0x400034C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshProUGUI Wolf;

	[Token(Token = "0x400034D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextMeshProUGUI Fox;

	[Token(Token = "0x400034E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private TextMeshProUGUI Leopard;

	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Image Boss1;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Image Boss2;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Image Boss3;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Image Boss4;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	private Image Boss5;

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0xB1AF30", Offset = "0xB1AF30", VA = "0xB1AF30")]
	private void Start()
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0xB1B5A0", Offset = "0xB1B5A0", VA = "0xB1B5A0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002DF")]
	[Address(RVA = "0xB1B298", Offset = "0xB1B298", VA = "0xB1B298")]
	private void InitBoss()
	{
	}

	[Token(Token = "0x60002E0")]
	[Address(RVA = "0xB1B688", Offset = "0xB1B688", VA = "0xB1B688")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002E1")]
	[Address(RVA = "0xB1B028", Offset = "0xB1B028", VA = "0xB1B028")]
	private void InitLanguage()
	{
	}

	[Token(Token = "0x60002E2")]
	[Address(RVA = "0xB1B7A4", Offset = "0xB1B7A4", VA = "0xB1B7A4")]
	private void RoleHeroine(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002E3")]
	[Address(RVA = "0xB1B8A8", Offset = "0xB1B8A8", VA = "0xB1B8A8")]
	private void RolePlayer(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002E4")]
	[Address(RVA = "0xB1B9AC", Offset = "0xB1B9AC", VA = "0xB1B9AC")]
	private void RoleClose(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002E5")]
	[Address(RVA = "0xB1B9D8", Offset = "0xB1B9D8", VA = "0xB1B9D8")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002E6")]
	[Address(RVA = "0xB1B9DC", Offset = "0xB1B9DC", VA = "0xB1B9DC")]
	public UIRolePhotoShower()
	{
	}
}
[Token(Token = "0x200006E")]
public class UISetAreaShower : MonoBehaviour
{
	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("箭头的UI展示")]
	[SerializeField]
	public Transform SetPersonUp;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public Transform SetPersonDown;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Transform[] arrows;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Header("BGM按钮展示")]
	[SerializeField]
	public Transform Bgm;

	[Token(Token = "0x4000358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Transform BgmOpen;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public Transform BgmClose;

	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[Header("音效按钮展示")]
	[SerializeField]
	public Transform SoundEffect;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public Transform SoundEffectOpen;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public Transform SoundEffectClose;

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("瞄准按钮展示")]
	[SerializeField]
	public Transform Aim;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	public Transform AimOpen;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	public Transform AimClose;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Header("左手按钮展示")]
	[SerializeField]
	public Transform LeftHand;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public Transform LeftHandOpen;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public Transform LeftHandClose;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public Image Setting;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("事件触发")]
	[SerializeField]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("文字/中英")]
	public TextMeshProUGUI SettingText;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshProUGUI PlayerHeightText;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshProUGUI ShootingRaysText;

	[Token(Token = "0x4000368")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshProUGUI ShootingRaysOnText;

	[Token(Token = "0x4000369")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshProUGUI ShootingRaysOffText;

	[Token(Token = "0x400036A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TextMeshProUGUI LeftHandText;

	[Token(Token = "0x400036B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public TextMeshProUGUI LeftHandOnText;

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public TextMeshProUGUI LeftHandOffText;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TextMeshProUGUI SoundEffectText;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TextMeshProUGUI SoundEffectOnText;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshProUGUI SoundEffectOffText;

	[Token(Token = "0x4000370")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public TextMeshProUGUI BGMText;

	[Token(Token = "0x4000371")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public TextMeshProUGUI BGMOnText;

	[Token(Token = "0x4000372")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public TextMeshProUGUI BGMOffText;

	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Animator ani;

	[Token(Token = "0x60002E7")]
	[Address(RVA = "0xB1B9E4", Offset = "0xB1B9E4", VA = "0xB1B9E4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002E8")]
	[Address(RVA = "0xB1BB3C", Offset = "0xB1BB3C", VA = "0xB1BB3C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002E9")]
	[Address(RVA = "0xB1BB04", Offset = "0xB1BB04", VA = "0xB1BB04")]
	private void init()
	{
	}

	[Token(Token = "0x60002EA")]
	[Address(RVA = "0xB1C088", Offset = "0xB1C088", VA = "0xB1C088")]
	private void initLanguage()
	{
	}

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0xB1C5E8", Offset = "0xB1C5E8", VA = "0xB1C5E8")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0xB1BC24", Offset = "0xB1BC24", VA = "0xB1BC24")]
	private void initHeightUpDown()
	{
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0xB1C8B0", Offset = "0xB1C8B0", VA = "0xB1C8B0")]
	private void HeightUpDown(UIModuleSO so, bool Add)
	{
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0xB1BD20", Offset = "0xB1BD20", VA = "0xB1BD20")]
	private void initBGM()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0xB1C940", Offset = "0xB1C940", VA = "0xB1C940")]
	private void SetBGM(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0xB1BDFC", Offset = "0xB1BDFC", VA = "0xB1BDFC")]
	private void initSoundEffect()
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0xB1CA2C", Offset = "0xB1CA2C", VA = "0xB1CA2C")]
	private void SetSoundEffect(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F2")]
	[Address(RVA = "0xB1BED8", Offset = "0xB1BED8", VA = "0xB1BED8")]
	private void initAim()
	{
	}

	[Token(Token = "0x60002F3")]
	[Address(RVA = "0xB1CB18", Offset = "0xB1CB18", VA = "0xB1CB18")]
	private void SetAim(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F4")]
	[Address(RVA = "0xB1BFB0", Offset = "0xB1BFB0", VA = "0xB1BFB0")]
	private void initLeftHand()
	{
	}

	[Token(Token = "0x60002F5")]
	[Address(RVA = "0xB1CC04", Offset = "0xB1CC04", VA = "0xB1CC04")]
	private void SetLeftHand(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F6")]
	[Address(RVA = "0xB1CCF0", Offset = "0xB1CCF0", VA = "0xB1CCF0")]
	private void SetClose(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F7")]
	[Address(RVA = "0xB1CD48", Offset = "0xB1CD48", VA = "0xB1CD48")]
	private void Close()
	{
	}

	[Token(Token = "0x60002F8")]
	[Address(RVA = "0xB1CD44", Offset = "0xB1CD44", VA = "0xB1CD44")]
	private void SetLanguage(UIModuleSO so)
	{
	}

	[Token(Token = "0x60002F9")]
	[Address(RVA = "0xB1CD6C", Offset = "0xB1CD6C", VA = "0xB1CD6C")]
	public UISetAreaShower()
	{
	}
}
[Token(Token = "0x200006F")]
public class AudioCueManager : MonoBehaviour
{
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioCueEventSO _eventSO;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isPlay;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioCuePool pool;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int language;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AudioCueManager _instance;

	[Token(Token = "0x1700005A")]
	public static AudioCueManager Instance
	{
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xB18A58", Offset = "0xB18A58", VA = "0xB18A58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60002FB")]
	[Address(RVA = "0xB1CD74", Offset = "0xB1CD74", VA = "0xB1CD74")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002FC")]
	[Address(RVA = "0xB1CEA4", Offset = "0xB1CEA4", VA = "0xB1CEA4")]
	public void setLanguage(int languagex)
	{
	}

	[Token(Token = "0x60002FD")]
	[Address(RVA = "0xB1CEAC", Offset = "0xB1CEAC", VA = "0xB1CEAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0xB1CF94", Offset = "0xB1CF94", VA = "0xB1CF94")]
	public void playAudio(AudioCueSO so)
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0xB1D0C0", Offset = "0xB1D0C0", VA = "0xB1D0C0")]
	public AudioCueManager()
	{
	}
}
[Token(Token = "0x2000070")]
public class BattleReportManager : MonoBehaviour
{
	[Token(Token = "0x2000071")]
	[SerializeField]
	public class BattleReport
	{
		[Token(Token = "0x400037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int ShotNum;

		[Token(Token = "0x400037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int HitNum;

		[Token(Token = "0x4000380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int KillNum;

		[Token(Token = "0x4000381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int HurtNum;

		[Token(Token = "0x4000382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int AccideNum;

		[Token(Token = "0x4000383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Finish;

		[Token(Token = "0x4000384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int LoseNum;

		[Token(Token = "0x4000385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int starNum;

		[Token(Token = "0x4000386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int NpcDieNum;

		[Token(Token = "0x4000387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public int ThiefLiveNum;

		[Token(Token = "0x6000314")]
		[Address(RVA = "0xB1D4F8", Offset = "0xB1D4F8", VA = "0xB1D4F8")]
		public BattleReport()
		{
		}
	}

	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int levelX;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BattleReport report;

	[Token(Token = "0x400037D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static BattleReportManager _instance;

	[Token(Token = "0x1700005B")]
	public static BattleReportManager Instance
	{
		[Token(Token = "0x6000300")]
		[Address(RVA = "0xB19658", Offset = "0xB19658", VA = "0xB19658")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000301")]
	[Address(RVA = "0xB1D0C8", Offset = "0xB1D0C8", VA = "0xB1D0C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000302")]
	[Address(RVA = "0xB1D0CC", Offset = "0xB1D0CC", VA = "0xB1D0CC")]
	private void Init()
	{
	}

	[Token(Token = "0x6000303")]
	[Address(RVA = "0xB1D10C", Offset = "0xB1D10C", VA = "0xB1D10C")]
	public void AddShotNum()
	{
	}

	[Token(Token = "0x6000304")]
	[Address(RVA = "0xB1D140", Offset = "0xB1D140", VA = "0xB1D140")]
	public void AddHitNum()
	{
	}

	[Token(Token = "0x6000305")]
	[Address(RVA = "0xB1D174", Offset = "0xB1D174", VA = "0xB1D174")]
	public void AddKillNum()
	{
	}

	[Token(Token = "0x6000306")]
	[Address(RVA = "0xB1D26C", Offset = "0xB1D26C", VA = "0xB1D26C")]
	public void AddHurtNum()
	{
	}

	[Token(Token = "0x6000307")]
	[Address(RVA = "0xB1D2A0", Offset = "0xB1D2A0", VA = "0xB1D2A0")]
	public void AddAccideNum()
	{
	}

	[Token(Token = "0x6000308")]
	[Address(RVA = "0xB1D2D4", Offset = "0xB1D2D4", VA = "0xB1D2D4")]
	public void Finish()
	{
	}

	[Token(Token = "0x6000309")]
	[Address(RVA = "0xB1D304", Offset = "0xB1D304", VA = "0xB1D304")]
	public void setStar(int star)
	{
	}

	[Token(Token = "0x600030A")]
	[Address(RVA = "0xB1D348", Offset = "0xB1D348", VA = "0xB1D348")]
	public void setNpcDieNum(int num)
	{
	}

	[Token(Token = "0x600030B")]
	[Address(RVA = "0xB1D380", Offset = "0xB1D380", VA = "0xB1D380")]
	public int getNpcDieNum()
	{
		return default(int);
	}

	[Token(Token = "0x600030C")]
	[Address(RVA = "0xB1D3AC", Offset = "0xB1D3AC", VA = "0xB1D3AC")]
	public void setThiefLiveNum(int num)
	{
	}

	[Token(Token = "0x600030D")]
	[Address(RVA = "0xB1D3E4", Offset = "0xB1D3E4", VA = "0xB1D3E4")]
	public int getThiefLiveNum()
	{
		return default(int);
	}

	[Token(Token = "0x600030E")]
	[Address(RVA = "0xB1D410", Offset = "0xB1D410", VA = "0xB1D410")]
	public int getLevelX()
	{
		return default(int);
	}

	[Token(Token = "0x600030F")]
	[Address(RVA = "0xB1D418", Offset = "0xB1D418", VA = "0xB1D418")]
	public void AddLoseNum()
	{
	}

	[Token(Token = "0x6000310")]
	[Address(RVA = "0xB1D44C", Offset = "0xB1D44C", VA = "0xB1D44C")]
	public int getLoseNum()
	{
		return default(int);
	}

	[Token(Token = "0x6000311")]
	[Address(RVA = "0xB1972C", Offset = "0xB1972C", VA = "0xB1972C")]
	public BattleReport readReport(int levelN)
	{
		return null;
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0xB1D500", Offset = "0xB1D500", VA = "0xB1D500")]
	public void writeReport()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0xB1D5CC", Offset = "0xB1D5CC", VA = "0xB1D5CC")]
	public BattleReportManager()
	{
	}
}
[Token(Token = "0x2000072")]
public class EnemyCreateCsvManager : MonoBehaviour
{
	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<string[]> arrayData;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DataTable dt;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EnemyCreateCsvManager _instance;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int levelX;

	[Token(Token = "0x1700005C")]
	public static EnemyCreateCsvManager Instance
	{
		[Token(Token = "0x6000315")]
		[Address(RVA = "0xB1D5D4", Offset = "0xB1D5D4", VA = "0xB1D5D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0xB1D6A8", Offset = "0xB1D6A8", VA = "0xB1D6A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0xB1D6AC", Offset = "0xB1D6AC", VA = "0xB1D6AC")]
	private void readCsv()
	{
	}

	[Token(Token = "0x6000318")]
	[Address(RVA = "0xB1DB6C", Offset = "0xB1DB6C", VA = "0xB1DB6C")]
	public DataTable listEnemyCreate()
	{
		return null;
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0xB1D748", Offset = "0xB1D748", VA = "0xB1D748")]
	public static string GetTextFromStreamingAssets(string path)
	{
		return null;
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0xB1D8C8", Offset = "0xB1D8C8", VA = "0xB1D8C8")]
	public static DataTable ReadCSV(string str)
	{
		return null;
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0xB1DB90", Offset = "0xB1DB90", VA = "0xB1DB90")]
	public static DataTable OpenCSV(string filePath)
	{
		return null;
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0xB1DEA0", Offset = "0xB1DEA0", VA = "0xB1DEA0")]
	public EnemyCreateCsvManager()
	{
	}
}
[Token(Token = "0x2000073")]
public struct EnemyData
{
	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public string EnemyName;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public int Hp;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public float FiringRange;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float StopRange;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int ShotForce;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int shotCD;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int shotRunNum;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int OnsituShotProb;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int atk;

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public double speed;
}
[Token(Token = "0x2000074")]
public class EnemyCsvManager : MonoBehaviour
{
	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private DataTable dt;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, EnemyData> dictEnemy;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EnemyCsvManager _instance;

	[Token(Token = "0x1700005D")]
	public static EnemyCsvManager Instance
	{
		[Token(Token = "0x600031D")]
		[Address(RVA = "0xB1DF30", Offset = "0xB1DF30", VA = "0xB1DF30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0xB1E004", Offset = "0xB1E004", VA = "0xB1E004")]
	public EnemyData getEnemy(string enemyName)
	{
		return default(EnemyData);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0xB1ED40", Offset = "0xB1ED40", VA = "0xB1ED40")]
	private void Start()
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0xB1ED44", Offset = "0xB1ED44", VA = "0xB1ED44")]
	private void InitReadCSV()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0xB1F220", Offset = "0xB1F220", VA = "0xB1F220")]
	public DataTable listEnemyCreate()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0xB1EDFC", Offset = "0xB1EDFC", VA = "0xB1EDFC")]
	public static string GetTextFromStreamingAssets(string path)
	{
		return null;
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0xB1EF7C", Offset = "0xB1EF7C", VA = "0xB1EF7C")]
	public static DataTable ReadCSV(string str)
	{
		return null;
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0xB1F228", Offset = "0xB1F228", VA = "0xB1F228")]
	public static DataTable OpenCSV(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0xB1E0E4", Offset = "0xB1E0E4", VA = "0xB1E0E4")]
	private Dictionary<string, EnemyData> initEnemyDict()
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0xB1F538", Offset = "0xB1F538", VA = "0xB1F538")]
	public EnemyCsvManager()
	{
	}
}
[Token(Token = "0x2000075")]
public class MainManager : MonoBehaviour
{
	[Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class <go>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400039F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainManager <>4__this;

		[Token(Token = "0x1700005E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600032F")]
			[Address(RVA = "0xB1F948", Offset = "0xB1F948", VA = "0xB1F948", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000331")]
			[Address(RVA = "0xB1F990", Offset = "0xB1F990", VA = "0xB1F990", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600032C")]
		[Address(RVA = "0xB1F7CC", Offset = "0xB1F7CC", VA = "0xB1F7CC")]
		[DebuggerHidden]
		public <go>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x600032D")]
		[Address(RVA = "0xB1F824", Offset = "0xB1F824", VA = "0xB1F824", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0xB1F828", Offset = "0xB1F828", VA = "0xB1F828", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0xB1F950", Offset = "0xB1F950", VA = "0xB1F950", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class <TakeWalk>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainManager <>4__this;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000335")]
			[Address(RVA = "0xB200D8", Offset = "0xB200D8", VA = "0xB200D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000337")]
			[Address(RVA = "0xB20120", Offset = "0xB20120", VA = "0xB20120", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000332")]
		[Address(RVA = "0xB1F7F4", Offset = "0xB1F7F4", VA = "0xB1F7F4")]
		[DebuggerHidden]
		public <TakeWalk>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000333")]
		[Address(RVA = "0xB1F998", Offset = "0xB1F998", VA = "0xB1F998", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0xB1F99C", Offset = "0xB1F99C", VA = "0xB1F99C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0xB200E0", Offset = "0xB200E0", VA = "0xB200E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject heroine;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private HeroineController heroineController;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform[] targets;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject playerHead;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform t;

	[Token(Token = "0x400039E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[Header("Level0 Event SO")]
	[SerializeField]
	public AudioCueSO Level0CueSO;

	[Token(Token = "0x6000327")]
	[Address(RVA = "0xB1F540", Offset = "0xB1F540", VA = "0xB1F540")]
	private void Start()
	{
	}

	[Token(Token = "0x6000328")]
	[Address(RVA = "0xB1F6F8", Offset = "0xB1F6F8", VA = "0xB1F6F8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000329")]
	[Address(RVA = "0xB1F758", Offset = "0xB1F758", VA = "0xB1F758")]
	[IteratorStateMachine(typeof(<go>d__8))]
	private IEnumerator go()
	{
		return null;
	}

	[Token(Token = "0x600032A")]
	[Address(RVA = "0xB1F684", Offset = "0xB1F684", VA = "0xB1F684")]
	[IteratorStateMachine(typeof(<TakeWalk>d__9))]
	private IEnumerator TakeWalk()
	{
		return null;
	}

	[Token(Token = "0x600032B")]
	[Address(RVA = "0xB1F81C", Offset = "0xB1F81C", VA = "0xB1F81C")]
	public MainManager()
	{
	}
}
[Token(Token = "0x2000078")]
public class OptionManager : MonoBehaviour
{
	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static OptionManager _instance;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private bool isXR;

	[Token(Token = "0x17000062")]
	public static OptionManager Instance
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0xB183EC", Offset = "0xB183EC", VA = "0xB183EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000339")]
	[Address(RVA = "0xB20128", Offset = "0xB20128", VA = "0xB20128")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033A")]
	[Address(RVA = "0xB201CC", Offset = "0xB201CC", VA = "0xB201CC")]
	public void SetXR(bool xr)
	{
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0xB201D8", Offset = "0xB201D8", VA = "0xB201D8")]
	public bool GetXR()
	{
		return default(bool);
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0xB1851C", Offset = "0xB1851C", VA = "0xB1851C")]
	public void SetHeightSectionInt(int sectionInt)
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0xB184C0", Offset = "0xB184C0", VA = "0xB184C0")]
	public int GetHeightSectionInt()
	{
		return default(int);
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0xB185DC", Offset = "0xB185DC", VA = "0xB185DC")]
	public void SetBGM(int value)
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0xB18580", Offset = "0xB18580", VA = "0xB18580")]
	public int GetBGM()
	{
		return default(int);
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0xB1869C", Offset = "0xB1869C", VA = "0xB1869C")]
	public void SetSoundEffect(int value)
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0xB18640", Offset = "0xB18640", VA = "0xB18640")]
	public int GetSoundEffect()
	{
		return default(int);
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0xB1881C", Offset = "0xB1881C", VA = "0xB1881C")]
	public void SetLeftHand(int value)
	{
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0xB187C0", Offset = "0xB187C0", VA = "0xB187C0")]
	public int GetLeftHand()
	{
		return default(int);
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0xB1875C", Offset = "0xB1875C", VA = "0xB1875C")]
	public void SetAim(int value)
	{
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0xB18700", Offset = "0xB18700", VA = "0xB18700")]
	public int GetAim()
	{
		return default(int);
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0xB201E0", Offset = "0xB201E0", VA = "0xB201E0")]
	public void SetMaxLevel(int value)
	{
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0xB18880", Offset = "0xB18880", VA = "0xB18880")]
	public int GetMaxLevel()
	{
		return default(int);
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0xB2027C", Offset = "0xB2027C", VA = "0xB2027C")]
	public void SetThisLevel(int value)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0xB202E0", Offset = "0xB202E0", VA = "0xB202E0")]
	public int GetThisLevel()
	{
		return default(int);
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0xB18934", Offset = "0xB18934", VA = "0xB18934")]
	public void SetDifficulty(int value)
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0xB19B58", Offset = "0xB19B58", VA = "0xB19B58")]
	public int GetDifficulty()
	{
		return default(int);
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0xB1D478", Offset = "0xB1D478", VA = "0xB1D478")]
	public string GetBattleReport(int levelX)
	{
		return null;
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0xB1D53C", Offset = "0xB1D53C", VA = "0xB1D53C")]
	public void SetBattleResport(int levelX, string report)
	{
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0xB18998", Offset = "0xB18998", VA = "0xB18998")]
	public int getLanguage()
	{
		return default(int);
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0xB189F4", Offset = "0xB189F4", VA = "0xB189F4")]
	public void SetLanguage(int language)
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0xB20358", Offset = "0xB20358", VA = "0xB20358")]
	public OptionManager()
	{
	}
}
[Token(Token = "0x2000079")]
public class PauseManager : MonoBehaviour
{
	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject pause;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI hudText;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public XRPlayerController xRPlayerController;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Button Back;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Button Restart;

	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Button Quit;

	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Button Close;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	public CheckLevelSO so;

	[Token(Token = "0x6000351")]
	[Address(RVA = "0xB20368", Offset = "0xB20368", VA = "0xB20368")]
	private void Start()
	{
	}

	[Token(Token = "0x6000352")]
	[Address(RVA = "0xB205B4", Offset = "0xB205B4", VA = "0xB205B4")]
	public void close()
	{
	}

	[Token(Token = "0x6000353")]
	[Address(RVA = "0xB205D0", Offset = "0xB205D0", VA = "0xB205D0")]
	public void ExitGame()
	{
	}

	[Token(Token = "0x6000354")]
	[Address(RVA = "0xB205D8", Offset = "0xB205D8", VA = "0xB205D8")]
	public PauseManager()
	{
	}
}
[Token(Token = "0x200007B")]
public class PlayerUIManager : MonoBehaviour
{
	[Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class <IGameOver>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerUIManager <>4__this;

		[Token(Token = "0x40003D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <f>5__2;

		[Token(Token = "0x40003D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <n>5__3;

		[Token(Token = "0x17000063")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600037B")]
			[Address(RVA = "0xB21ED0", Offset = "0xB21ED0", VA = "0xB21ED0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000064")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600037D")]
			[Address(RVA = "0xB21F18", Offset = "0xB21F18", VA = "0xB21F18", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000378")]
		[Address(RVA = "0xB219CC", Offset = "0xB219CC", VA = "0xB219CC")]
		[DebuggerHidden]
		public <IGameOver>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x6000379")]
		[Address(RVA = "0xB21CD8", Offset = "0xB21CD8", VA = "0xB21CD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600037A")]
		[Address(RVA = "0xB21CDC", Offset = "0xB21CDC", VA = "0xB21CDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600037C")]
		[Address(RVA = "0xB21ED8", Offset = "0xB21ED8", VA = "0xB21ED8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class <hurt>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerUIManager <>4__this;

		[Token(Token = "0x17000065")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000381")]
			[Address(RVA = "0xB2203C", Offset = "0xB2203C", VA = "0xB2203C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000066")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000383")]
			[Address(RVA = "0xB22084", Offset = "0xB22084", VA = "0xB22084", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600037E")]
		[Address(RVA = "0xB219F4", Offset = "0xB219F4", VA = "0xB219F4")]
		[DebuggerHidden]
		public <hurt>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600037F")]
		[Address(RVA = "0xB21F20", Offset = "0xB21F20", VA = "0xB21F20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000380")]
		[Address(RVA = "0xB21F24", Offset = "0xB21F24", VA = "0xB21F24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000382")]
		[Address(RVA = "0xB22044", Offset = "0xB22044", VA = "0xB22044", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject HurtImage;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Image OverImage;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Image TipImage;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshProUGUI TipText;

	[Token(Token = "0x40003B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject HpBar;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI HpNum_R;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshProUGUI HP_R;

	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI HpNum_L;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshProUGUI HP_L;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Image Hearth;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI KillNum_R;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI Kill_R;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI KillNum_L;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI Kill_L;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public PlayerEventSO _eventSO;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public GameObject cameraObj;

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public GameObject PauseWindow;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Button Back;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Button Restart;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Button Quit;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Button Close;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject PassWindow;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject FailWindow;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Button FailBackBtn;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Button FailAgentBtn;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Header("事件触发")]
	private UIModuleEventSO _eventUISO;

	[Token(Token = "0x600035B")]
	[Address(RVA = "0xB20768", Offset = "0xB20768", VA = "0xB20768")]
	private void Awake()
	{
	}

	[Token(Token = "0x600035C")]
	[Address(RVA = "0xB20B80", Offset = "0xB20B80", VA = "0xB20B80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0xB20D1C", Offset = "0xB20D1C", VA = "0xB20D1C")]
	private void Start()
	{
	}

	[Token(Token = "0x600035E")]
	[Address(RVA = "0xB210E4", Offset = "0xB210E4", VA = "0xB210E4")]
	private void Init()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0xB21228", Offset = "0xB21228", VA = "0xB21228")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0xB212B8", Offset = "0xB212B8", VA = "0xB212B8")]
	public void updatePlayer(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000361")]
	[Address(RVA = "0xB21394", Offset = "0xB21394", VA = "0xB21394")]
	private void moveUIAdd()
	{
	}

	[Token(Token = "0x6000362")]
	[Address(RVA = "0xB20904", Offset = "0xB20904", VA = "0xB20904")]
	private void moveUI()
	{
	}

	[Token(Token = "0x6000363")]
	[Address(RVA = "0xB21648", Offset = "0xB21648", VA = "0xB21648")]
	public void updateHP(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000364")]
	[Address(RVA = "0xB2178C", Offset = "0xB2178C", VA = "0xB2178C")]
	public void updateKillNum(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000365")]
	[Address(RVA = "0xB21870", Offset = "0xB21870", VA = "0xB21870")]
	public void GameOver(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000366")]
	[Address(RVA = "0xB21938", Offset = "0xB21938", VA = "0xB21938")]
	public void GameOver()
	{
	}

	[Token(Token = "0x6000367")]
	[Address(RVA = "0xB21958", Offset = "0xB21958", VA = "0xB21958")]
	[IteratorStateMachine(typeof(<IGameOver>d__38))]
	private IEnumerator IGameOver()
	{
		return null;
	}

	[Token(Token = "0x6000368")]
	[Address(RVA = "0xB215D4", Offset = "0xB215D4", VA = "0xB215D4")]
	[IteratorStateMachine(typeof(<hurt>d__39))]
	private IEnumerator hurt()
	{
		return null;
	}

	[Token(Token = "0x6000369")]
	[Address(RVA = "0xB218AC", Offset = "0xB218AC", VA = "0xB218AC")]
	private void BlackSet()
	{
	}

	[Token(Token = "0x600036A")]
	[Address(RVA = "0xB21A1C", Offset = "0xB21A1C", VA = "0xB21A1C")]
	private void blackChange()
	{
	}

	[Token(Token = "0x600036B")]
	[Address(RVA = "0xB218B0", Offset = "0xB218B0", VA = "0xB218B0")]
	private void BlackCancel()
	{
	}

	[Token(Token = "0x600036C")]
	[Address(RVA = "0xB21918", Offset = "0xB21918", VA = "0xB21918")]
	public void PauseGame()
	{
	}

	[Token(Token = "0x600036D")]
	[Address(RVA = "0xB21298", Offset = "0xB21298", VA = "0xB21298")]
	public void RecoverGame()
	{
	}

	[Token(Token = "0x600036E")]
	[Address(RVA = "0xB21A84", Offset = "0xB21A84", VA = "0xB21A84")]
	public void ExitGame()
	{
	}

	[Token(Token = "0x600036F")]
	[Address(RVA = "0xB21A8C", Offset = "0xB21A8C", VA = "0xB21A8C")]
	public PlayerUIManager()
	{
	}
}
[Token(Token = "0x200007F")]
public class Scene1Manager : SceneBaseManager
{
	[Token(Token = "0x2000080")]
	[CompilerGenerated]
	private sealed class <plots>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000067")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A2")]
			[Address(RVA = "0xB236F0", Offset = "0xB236F0", VA = "0xB236F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000068")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003A4")]
			[Address(RVA = "0xB23738", Offset = "0xB23738", VA = "0xB23738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600039F")]
		[Address(RVA = "0xB22A88", Offset = "0xB22A88", VA = "0xB22A88")]
		[DebuggerHidden]
		public <plots>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60003A0")]
		[Address(RVA = "0xB235B8", Offset = "0xB235B8", VA = "0xB235B8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A1")]
		[Address(RVA = "0xB235BC", Offset = "0xB235BC", VA = "0xB235BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A3")]
		[Address(RVA = "0xB236F8", Offset = "0xB236F8", VA = "0xB236F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000081")]
	[CompilerGenerated]
	private sealed class <plotT0>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000069")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0xB238B4", Offset = "0xB238B4", VA = "0xB238B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003AA")]
			[Address(RVA = "0xB238FC", Offset = "0xB238FC", VA = "0xB238FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003A5")]
		[Address(RVA = "0xB22B24", Offset = "0xB22B24", VA = "0xB22B24")]
		[DebuggerHidden]
		public <plotT0>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60003A6")]
		[Address(RVA = "0xB23740", Offset = "0xB23740", VA = "0xB23740", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003A7")]
		[Address(RVA = "0xB23744", Offset = "0xB23744", VA = "0xB23744", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0xB238BC", Offset = "0xB238BC", VA = "0xB238BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000082")]
	[CompilerGenerated]
	private sealed class <plotT1>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x40003FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string <animation>5__2;

		[Token(Token = "0x1700006B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0xB23C58", Offset = "0xB23C58", VA = "0xB23C58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0xB23CA0", Offset = "0xB23CA0", VA = "0xB23CA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0xB22BC0", Offset = "0xB22BC0", VA = "0xB22BC0")]
		[DebuggerHidden]
		public <plotT1>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0xB23904", Offset = "0xB23904", VA = "0xB23904", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0xB23908", Offset = "0xB23908", VA = "0xB23908", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0xB23C60", Offset = "0xB23C60", VA = "0xB23C60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000083")]
	[CompilerGenerated]
	private sealed class <plotT1_2>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000400")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x1700006D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0xB24264", Offset = "0xB24264", VA = "0xB24264", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003B6")]
			[Address(RVA = "0xB242AC", Offset = "0xB242AC", VA = "0xB242AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0xB22C5C", Offset = "0xB22C5C", VA = "0xB22C5C")]
		[DebuggerHidden]
		public <plotT1_2>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0xB23CA8", Offset = "0xB23CA8", VA = "0xB23CA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0xB23CAC", Offset = "0xB23CAC", VA = "0xB23CAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0xB2426C", Offset = "0xB2426C", VA = "0xB2426C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[CompilerGenerated]
	private sealed class <questPlotT>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000401")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000402")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000403")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x1700006F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003BA")]
			[Address(RVA = "0xB24374", Offset = "0xB24374", VA = "0xB24374", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000070")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0xB243BC", Offset = "0xB243BC", VA = "0xB243BC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xB22C84", Offset = "0xB22C84", VA = "0xB22C84")]
		[DebuggerHidden]
		public <questPlotT>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0xB242B4", Offset = "0xB242B4", VA = "0xB242B4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0xB242B8", Offset = "0xB242B8", VA = "0xB242B8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0xB2437C", Offset = "0xB2437C", VA = "0xB2437C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class <plotStart>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000404")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000405")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000406")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000071")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0xB24448", Offset = "0xB24448", VA = "0xB24448", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000072")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C2")]
			[Address(RVA = "0xB24490", Offset = "0xB24490", VA = "0xB24490", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0xB22D20", Offset = "0xB22D20", VA = "0xB22D20")]
		[DebuggerHidden]
		public <plotStart>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x60003BE")]
		[Address(RVA = "0xB243C4", Offset = "0xB243C4", VA = "0xB243C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0xB243C8", Offset = "0xB243C8", VA = "0xB243C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0xB24450", Offset = "0xB24450", VA = "0xB24450", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000407")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000408")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000409")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x400040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x17000073")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C6")]
			[Address(RVA = "0xB24ABC", Offset = "0xB24ABC", VA = "0xB24ABC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000074")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C8")]
			[Address(RVA = "0xB24B04", Offset = "0xB24B04", VA = "0xB24B04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0xB22DF8", Offset = "0xB22DF8", VA = "0xB22DF8")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xB24498", Offset = "0xB24498", VA = "0xB24498", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xB2449C", Offset = "0xB2449C", VA = "0xB2449C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0xB24AC4", Offset = "0xB24AC4", VA = "0xB24AC4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[CompilerGenerated]
	private sealed class <plotTrigger11s>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000075")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003CC")]
			[Address(RVA = "0xB24B8C", Offset = "0xB24B8C", VA = "0xB24B8C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003CE")]
			[Address(RVA = "0xB24BD4", Offset = "0xB24BD4", VA = "0xB24BD4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C9")]
		[Address(RVA = "0xB22E94", Offset = "0xB22E94", VA = "0xB22E94")]
		[DebuggerHidden]
		public <plotTrigger11s>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60003CA")]
		[Address(RVA = "0xB24B0C", Offset = "0xB24B0C", VA = "0xB24B0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003CB")]
		[Address(RVA = "0xB24B10", Offset = "0xB24B10", VA = "0xB24B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003CD")]
		[Address(RVA = "0xB24B94", Offset = "0xB24B94", VA = "0xB24B94", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000077")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D2")]
			[Address(RVA = "0xB25110", Offset = "0xB25110", VA = "0xB25110", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000078")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003D4")]
			[Address(RVA = "0xB25158", Offset = "0xB25158", VA = "0xB25158", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0xB22F30", Offset = "0xB22F30", VA = "0xB22F30")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60003D0")]
		[Address(RVA = "0xB24BDC", Offset = "0xB24BDC", VA = "0xB24BDC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D1")]
		[Address(RVA = "0xB24BE0", Offset = "0xB24BE0", VA = "0xB24BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0xB25118", Offset = "0xB25118", VA = "0xB25118", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class <plotTrigger21s>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000079")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003D8")]
			[Address(RVA = "0xB251E0", Offset = "0xB251E0", VA = "0xB251E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0xB25228", Offset = "0xB25228", VA = "0xB25228", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0xB22FCC", Offset = "0xB22FCC", VA = "0xB22FCC")]
		[DebuggerHidden]
		public <plotTrigger21s>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0xB25160", Offset = "0xB25160", VA = "0xB25160", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0xB25164", Offset = "0xB25164", VA = "0xB25164", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0xB251E8", Offset = "0xB251E8", VA = "0xB251E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class <plotTrigger21_1>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x1700007B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0xB257D0", Offset = "0xB257D0", VA = "0xB257D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0xB25818", Offset = "0xB25818", VA = "0xB25818", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0xB23068", Offset = "0xB23068", VA = "0xB23068")]
		[DebuggerHidden]
		public <plotTrigger21_1>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0xB25230", Offset = "0xB25230", VA = "0xB25230", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003DD")]
		[Address(RVA = "0xB25234", Offset = "0xB25234", VA = "0xB25234", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0xB257D8", Offset = "0xB257D8", VA = "0xB257D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class <plotTrigger22s>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x1700007D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0xB258A0", Offset = "0xB258A0", VA = "0xB258A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003E6")]
			[Address(RVA = "0xB258E8", Offset = "0xB258E8", VA = "0xB258E8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E1")]
		[Address(RVA = "0xB23104", Offset = "0xB23104", VA = "0xB23104")]
		[DebuggerHidden]
		public <plotTrigger22s>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60003E2")]
		[Address(RVA = "0xB25820", Offset = "0xB25820", VA = "0xB25820", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E3")]
		[Address(RVA = "0xB25824", Offset = "0xB25824", VA = "0xB25824", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E5")]
		[Address(RVA = "0xB258A8", Offset = "0xB258A8", VA = "0xB258A8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class <plotTrigger22_1>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x1700007F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0xB2596C", Offset = "0xB2596C", VA = "0xB2596C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000080")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003EC")]
			[Address(RVA = "0xB259B4", Offset = "0xB259B4", VA = "0xB259B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0xB231A0", Offset = "0xB231A0", VA = "0xB231A0")]
		[DebuggerHidden]
		public <plotTrigger22_1>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0xB258F0", Offset = "0xB258F0", VA = "0xB258F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0xB258F4", Offset = "0xB258F4", VA = "0xB258F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0xB25974", Offset = "0xB25974", VA = "0xB25974", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class <plotTrigger26s>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000081")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F0")]
			[Address(RVA = "0xB25A3C", Offset = "0xB25A3C", VA = "0xB25A3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000082")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0xB25A84", Offset = "0xB25A84", VA = "0xB25A84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003ED")]
		[Address(RVA = "0xB2323C", Offset = "0xB2323C", VA = "0xB2323C")]
		[DebuggerHidden]
		public <plotTrigger26s>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x60003EE")]
		[Address(RVA = "0xB259BC", Offset = "0xB259BC", VA = "0xB259BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003EF")]
		[Address(RVA = "0xB259C0", Offset = "0xB259C0", VA = "0xB259C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F1")]
		[Address(RVA = "0xB25A44", Offset = "0xB25A44", VA = "0xB25A44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class <plotTrigger26_1>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000083")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003F6")]
			[Address(RVA = "0xB25B34", Offset = "0xB25B34", VA = "0xB25B34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000084")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003F8")]
			[Address(RVA = "0xB25B7C", Offset = "0xB25B7C", VA = "0xB25B7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F3")]
		[Address(RVA = "0xB232D8", Offset = "0xB232D8", VA = "0xB232D8")]
		[DebuggerHidden]
		public <plotTrigger26_1>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x60003F4")]
		[Address(RVA = "0xB25A8C", Offset = "0xB25A8C", VA = "0xB25A8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003F5")]
		[Address(RVA = "0xB25A90", Offset = "0xB25A90", VA = "0xB25A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003F7")]
		[Address(RVA = "0xB25B3C", Offset = "0xB25B3C", VA = "0xB25B3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008F")]
	[CompilerGenerated]
	private sealed class <plotTrigger31s>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000085")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003FC")]
			[Address(RVA = "0xB25C04", Offset = "0xB25C04", VA = "0xB25C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000086")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003FE")]
			[Address(RVA = "0xB25C4C", Offset = "0xB25C4C", VA = "0xB25C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003F9")]
		[Address(RVA = "0xB23374", Offset = "0xB23374", VA = "0xB23374")]
		[DebuggerHidden]
		public <plotTrigger31s>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x60003FA")]
		[Address(RVA = "0xB25B84", Offset = "0xB25B84", VA = "0xB25B84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003FB")]
		[Address(RVA = "0xB25B88", Offset = "0xB25B88", VA = "0xB25B88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003FD")]
		[Address(RVA = "0xB25C0C", Offset = "0xB25C0C", VA = "0xB25C0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000090")]
	[CompilerGenerated]
	private sealed class <win>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene1Manager <>4__this;

		[Token(Token = "0x17000087")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000402")]
			[Address(RVA = "0xB263C0", Offset = "0xB263C0", VA = "0xB263C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000088")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000404")]
			[Address(RVA = "0xB26408", Offset = "0xB26408", VA = "0xB26408", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003FF")]
		[Address(RVA = "0xB23410", Offset = "0xB23410", VA = "0xB23410")]
		[DebuggerHidden]
		public <win>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000400")]
		[Address(RVA = "0xB25C54", Offset = "0xB25C54", VA = "0xB25C54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000401")]
		[Address(RVA = "0xB25C58", Offset = "0xB25C58", VA = "0xB25C58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000403")]
		[Address(RVA = "0xB263C8", Offset = "0xB263C8", VA = "0xB263C8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Header("[配置项")]
	[SerializeField]
	public AudioCueSO Level2CueSO;

	[Token(Token = "0x40003DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x40003DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform FirstDoor;

	[Token(Token = "0x40003DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform SecondDoorL;

	[Token(Token = "0x40003DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform SecondDoorR;

	[Token(Token = "0x40003DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform ThirdDoorL;

	[Token(Token = "0x40003DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform ThirdDoorR;

	[Token(Token = "0x40003E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Transform FourthDoorL;

	[Token(Token = "0x40003E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Transform FourthDoorR;

	[Token(Token = "0x40003E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public TextMeshProUGUI DoorText0;

	[Token(Token = "0x40003E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public TextMeshProUGUI DoorText1;

	[Token(Token = "0x40003E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public TextMeshProUGUI DoorText2;

	[Token(Token = "0x40003E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Image Course;

	[Token(Token = "0x40003E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[Header("NPC")]
	private Transform NpcJc1;

	[Token(Token = "0x40003E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Transform NpcJc2;

	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[Header("长按相关")]
	private bool StartGame;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x161")]
	private bool isPress;

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private float lastPressTime;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Header("黑鹰组织")]
	private TextMeshProUGUI BlackOrg;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private TextMeshProUGUI Bull;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private TextMeshProUGUI Hound;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private TextMeshProUGUI Wolf;

	[Token(Token = "0x40003F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private TextMeshProUGUI Fox;

	[Token(Token = "0x40003F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private TextMeshProUGUI Leopard;

	[Token(Token = "0x40003F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int trigger;

	[Token(Token = "0x40003F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private bool BossDie;

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xB2208C", Offset = "0xB2208C", VA = "0xB2208C")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xB22658", Offset = "0xB22658", VA = "0xB22658")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000386")]
	[Address(RVA = "0xB22800", Offset = "0xB22800", VA = "0xB22800")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0xB2224C", Offset = "0xB2224C", VA = "0xB2224C")]
	private void Init()
	{
	}

	[Token(Token = "0x6000388")]
	[Address(RVA = "0xB2282C", Offset = "0xB2282C", VA = "0xB2282C")]
	private void longPress()
	{
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0xB22638", Offset = "0xB22638", VA = "0xB22638")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0xB22A14", Offset = "0xB22A14", VA = "0xB22A14")]
	[IteratorStateMachine(typeof(<plots>d__33))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0xB22AB0", Offset = "0xB22AB0", VA = "0xB22AB0")]
	[IteratorStateMachine(typeof(<plotT0>d__34))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0xB22B4C", Offset = "0xB22B4C", VA = "0xB22B4C")]
	[IteratorStateMachine(typeof(<plotT1>d__35))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0xB22BE8", Offset = "0xB22BE8", VA = "0xB22BE8")]
	[IteratorStateMachine(typeof(<plotT1_2>d__36))]
	private IEnumerator plotT1_2()
	{
		return null;
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0xB229A0", Offset = "0xB229A0", VA = "0xB229A0")]
	[IteratorStateMachine(typeof(<questPlotT>d__37))]
	private IEnumerator questPlotT()
	{
		return null;
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0xB22CAC", Offset = "0xB22CAC", VA = "0xB22CAC")]
	[IteratorStateMachine(typeof(<plotStart>d__38))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0xB22D48", Offset = "0xB22D48", VA = "0xB22D48")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0xB22D68", Offset = "0xB22D68", VA = "0xB22D68")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__40))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x6000392")]
	[Address(RVA = "0xB22E20", Offset = "0xB22E20", VA = "0xB22E20")]
	[IteratorStateMachine(typeof(<plotTrigger11s>d__41))]
	private IEnumerator plotTrigger11s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0xB22EBC", Offset = "0xB22EBC", VA = "0xB22EBC")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__42))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x6000394")]
	[Address(RVA = "0xB22F58", Offset = "0xB22F58", VA = "0xB22F58")]
	[IteratorStateMachine(typeof(<plotTrigger21s>d__43))]
	private IEnumerator plotTrigger21s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000395")]
	[Address(RVA = "0xB22FF4", Offset = "0xB22FF4", VA = "0xB22FF4")]
	[IteratorStateMachine(typeof(<plotTrigger21_1>d__44))]
	private IEnumerator plotTrigger21_1()
	{
		return null;
	}

	[Token(Token = "0x6000396")]
	[Address(RVA = "0xB23090", Offset = "0xB23090", VA = "0xB23090")]
	[IteratorStateMachine(typeof(<plotTrigger22s>d__45))]
	private IEnumerator plotTrigger22s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000397")]
	[Address(RVA = "0xB2312C", Offset = "0xB2312C", VA = "0xB2312C")]
	[IteratorStateMachine(typeof(<plotTrigger22_1>d__46))]
	private IEnumerator plotTrigger22_1()
	{
		return null;
	}

	[Token(Token = "0x6000398")]
	[Address(RVA = "0xB231C8", Offset = "0xB231C8", VA = "0xB231C8")]
	[IteratorStateMachine(typeof(<plotTrigger26s>d__47))]
	private IEnumerator plotTrigger26s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000399")]
	[Address(RVA = "0xB23264", Offset = "0xB23264", VA = "0xB23264")]
	[IteratorStateMachine(typeof(<plotTrigger26_1>d__48))]
	private IEnumerator plotTrigger26_1()
	{
		return null;
	}

	[Token(Token = "0x600039A")]
	[Address(RVA = "0xB23300", Offset = "0xB23300", VA = "0xB23300")]
	[IteratorStateMachine(typeof(<plotTrigger31s>d__49))]
	private IEnumerator plotTrigger31s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x600039B")]
	[Address(RVA = "0xB2339C", Offset = "0xB2339C", VA = "0xB2339C")]
	[IteratorStateMachine(typeof(<win>d__50))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x600039C")]
	[Address(RVA = "0xB23438", Offset = "0xB23438", VA = "0xB23438")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x600039D")]
	[Address(RVA = "0xB23520", Offset = "0xB23520", VA = "0xB23520")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x600039E")]
	[Address(RVA = "0xB23560", Offset = "0xB23560", VA = "0xB23560")]
	public Scene1Manager()
	{
	}
}
[Token(Token = "0x2000091")]
public class Scene2Manager : SceneBaseManager
{
	[Token(Token = "0x2000092")]
	[CompilerGenerated]
	private sealed class <questPlotT>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000436")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000437")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000438")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x17000089")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600041F")]
			[Address(RVA = "0xB2728C", Offset = "0xB2728C", VA = "0xB2728C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000421")]
			[Address(RVA = "0xB272D4", Offset = "0xB272D4", VA = "0xB272D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600041C")]
		[Address(RVA = "0xB2719C", Offset = "0xB2719C", VA = "0xB2719C")]
		[DebuggerHidden]
		public <questPlotT>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600041D")]
		[Address(RVA = "0xB271C4", Offset = "0xB271C4", VA = "0xB271C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600041E")]
		[Address(RVA = "0xB271C8", Offset = "0xB271C8", VA = "0xB271C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000420")]
		[Address(RVA = "0xB27294", Offset = "0xB27294", VA = "0xB27294", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000093")]
	[CompilerGenerated]
	private sealed class <plots>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000439")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400043B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x1700008B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000425")]
			[Address(RVA = "0xB2744C", Offset = "0xB2744C", VA = "0xB2744C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000427")]
			[Address(RVA = "0xB27494", Offset = "0xB27494", VA = "0xB27494", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xB272DC", Offset = "0xB272DC", VA = "0xB272DC")]
		[DebuggerHidden]
		public <plots>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xB27304", Offset = "0xB27304", VA = "0xB27304", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000424")]
		[Address(RVA = "0xB27308", Offset = "0xB27308", VA = "0xB27308", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000426")]
		[Address(RVA = "0xB27454", Offset = "0xB27454", VA = "0xB27454", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000094")]
	[CompilerGenerated]
	private sealed class <plotT0>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400043E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x1700008D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600042B")]
			[Address(RVA = "0xB27644", Offset = "0xB27644", VA = "0xB27644", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700008E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600042D")]
			[Address(RVA = "0xB2768C", Offset = "0xB2768C", VA = "0xB2768C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000428")]
		[Address(RVA = "0xB2749C", Offset = "0xB2749C", VA = "0xB2749C")]
		[DebuggerHidden]
		public <plotT0>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000429")]
		[Address(RVA = "0xB274C4", Offset = "0xB274C4", VA = "0xB274C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600042A")]
		[Address(RVA = "0xB274C8", Offset = "0xB274C8", VA = "0xB274C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600042C")]
		[Address(RVA = "0xB2764C", Offset = "0xB2764C", VA = "0xB2764C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[CompilerGenerated]
	private sealed class <plotT1>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400043F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x1700008F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000431")]
			[Address(RVA = "0xB27B3C", Offset = "0xB27B3C", VA = "0xB27B3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000090")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000433")]
			[Address(RVA = "0xB27B84", Offset = "0xB27B84", VA = "0xB27B84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600042E")]
		[Address(RVA = "0xB27694", Offset = "0xB27694", VA = "0xB27694")]
		[DebuggerHidden]
		public <plotT1>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x600042F")]
		[Address(RVA = "0xB276BC", Offset = "0xB276BC", VA = "0xB276BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000430")]
		[Address(RVA = "0xB276C0", Offset = "0xB276C0", VA = "0xB276C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000432")]
		[Address(RVA = "0xB27B44", Offset = "0xB27B44", VA = "0xB27B44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[CompilerGenerated]
	private sealed class <plotT1_2>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000442")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x17000091")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000437")]
			[Address(RVA = "0xB27E7C", Offset = "0xB27E7C", VA = "0xB27E7C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000092")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000439")]
			[Address(RVA = "0xB27EC4", Offset = "0xB27EC4", VA = "0xB27EC4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000434")]
		[Address(RVA = "0xB27B8C", Offset = "0xB27B8C", VA = "0xB27B8C")]
		[DebuggerHidden]
		public <plotT1_2>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000435")]
		[Address(RVA = "0xB27BB4", Offset = "0xB27BB4", VA = "0xB27BB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000436")]
		[Address(RVA = "0xB27BB8", Offset = "0xB27BB8", VA = "0xB27BB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000438")]
		[Address(RVA = "0xB27E84", Offset = "0xB27E84", VA = "0xB27E84", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class <downElevator>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x17000093")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600043D")]
			[Address(RVA = "0xB27FCC", Offset = "0xB27FCC", VA = "0xB27FCC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000094")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600043F")]
			[Address(RVA = "0xB28014", Offset = "0xB28014", VA = "0xB28014", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600043A")]
		[Address(RVA = "0xB27ECC", Offset = "0xB27ECC", VA = "0xB27ECC")]
		[DebuggerHidden]
		public <downElevator>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600043B")]
		[Address(RVA = "0xB27EF4", Offset = "0xB27EF4", VA = "0xB27EF4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600043C")]
		[Address(RVA = "0xB27EF8", Offset = "0xB27EF8", VA = "0xB27EF8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600043E")]
		[Address(RVA = "0xB27FD4", Offset = "0xB27FD4", VA = "0xB27FD4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[CompilerGenerated]
	private sealed class <plotStart>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000443")]
			[Address(RVA = "0xB2815C", Offset = "0xB2815C", VA = "0xB2815C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000445")]
			[Address(RVA = "0xB281A4", Offset = "0xB281A4", VA = "0xB281A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0xB2801C", Offset = "0xB2801C", VA = "0xB2801C")]
		[DebuggerHidden]
		public <plotStart>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0xB28044", Offset = "0xB28044", VA = "0xB28044", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0xB28048", Offset = "0xB28048", VA = "0xB28048", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0xB28164", Offset = "0xB28164", VA = "0xB28164", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400044C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400044D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x400044E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x17000097")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000449")]
			[Address(RVA = "0xB28C58", Offset = "0xB28C58", VA = "0xB28C58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000098")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600044B")]
			[Address(RVA = "0xB28CA0", Offset = "0xB28CA0", VA = "0xB28CA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000446")]
		[Address(RVA = "0xB281AC", Offset = "0xB281AC", VA = "0xB281AC")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000447")]
		[Address(RVA = "0xB281D4", Offset = "0xB281D4", VA = "0xB281D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000448")]
		[Address(RVA = "0xB281D8", Offset = "0xB281D8", VA = "0xB281D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600044A")]
		[Address(RVA = "0xB28C60", Offset = "0xB28C60", VA = "0xB28C60", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009A")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400044F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000450")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x17000099")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0xB28FB0", Offset = "0xB28FB0", VA = "0xB28FB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0xB28FF8", Offset = "0xB28FF8", VA = "0xB28FF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0xB28CA8", Offset = "0xB28CA8", VA = "0xB28CA8")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0xB28CD0", Offset = "0xB28CD0", VA = "0xB28CD0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600044E")]
		[Address(RVA = "0xB28CD4", Offset = "0xB28CD4", VA = "0xB28CD4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000450")]
		[Address(RVA = "0xB28FB8", Offset = "0xB28FB8", VA = "0xB28FB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009B")]
	[CompilerGenerated]
	private sealed class <plotTrigger21_1>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x1700009B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0xB290B0", Offset = "0xB290B0", VA = "0xB290B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0xB290F8", Offset = "0xB290F8", VA = "0xB290F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0xB29000", Offset = "0xB29000", VA = "0xB29000")]
		[DebuggerHidden]
		public <plotTrigger21_1>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0xB29028", Offset = "0xB29028", VA = "0xB29028", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0xB2902C", Offset = "0xB2902C", VA = "0xB2902C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000456")]
		[Address(RVA = "0xB290B8", Offset = "0xB290B8", VA = "0xB290B8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009C")]
	[CompilerGenerated]
	private sealed class <win>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000455")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000456")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000457")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x1700009D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0xB295FC", Offset = "0xB295FC", VA = "0xB295FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700009E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0xB29644", Offset = "0xB29644", VA = "0xB29644", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000458")]
		[Address(RVA = "0xB29100", Offset = "0xB29100", VA = "0xB29100")]
		[DebuggerHidden]
		public <win>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000459")]
		[Address(RVA = "0xB29128", Offset = "0xB29128", VA = "0xB29128", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600045A")]
		[Address(RVA = "0xB2912C", Offset = "0xB2912C", VA = "0xB2912C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0xB29604", Offset = "0xB29604", VA = "0xB29604", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009D")]
	[CompilerGenerated]
	private sealed class <ElevatorMove>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000458")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000459")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float y;

		[Token(Token = "0x1700009F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0xB298C4", Offset = "0xB298C4", VA = "0xB298C4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000463")]
			[Address(RVA = "0xB2990C", Offset = "0xB2990C", VA = "0xB2990C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0xB2964C", Offset = "0xB2964C", VA = "0xB2964C")]
		[DebuggerHidden]
		public <ElevatorMove>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0xB29674", Offset = "0xB29674", VA = "0xB29674", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0xB29678", Offset = "0xB29678", VA = "0xB29678", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000462")]
		[Address(RVA = "0xB298CC", Offset = "0xB298CC", VA = "0xB298CC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009E")]
	[CompilerGenerated]
	private sealed class <DoorLMove>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x170000A1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0xB29B24", Offset = "0xB29B24", VA = "0xB29B24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0xB29B6C", Offset = "0xB29B6C", VA = "0xB29B6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0xB29914", Offset = "0xB29914", VA = "0xB29914")]
		[DebuggerHidden]
		public <DoorLMove>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0xB2993C", Offset = "0xB2993C", VA = "0xB2993C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0xB29940", Offset = "0xB29940", VA = "0xB29940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0xB29B2C", Offset = "0xB29B2C", VA = "0xB29B2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200009F")]
	[CompilerGenerated]
	private sealed class <DoorRMove>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000461")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000462")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene2Manager <>4__this;

		[Token(Token = "0x4000463")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x170000A3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600046D")]
			[Address(RVA = "0xB29D84", Offset = "0xB29D84", VA = "0xB29D84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600046F")]
			[Address(RVA = "0xB29DCC", Offset = "0xB29DCC", VA = "0xB29DCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600046A")]
		[Address(RVA = "0xB29B74", Offset = "0xB29B74", VA = "0xB29B74")]
		[DebuggerHidden]
		public <DoorRMove>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x600046B")]
		[Address(RVA = "0xB29B9C", Offset = "0xB29B9C", VA = "0xB29B9C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600046C")]
		[Address(RVA = "0xB29BA0", Offset = "0xB29BA0", VA = "0xB29BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600046E")]
		[Address(RVA = "0xB29D8C", Offset = "0xB29D8C", VA = "0xB29D8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000429")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Header("[配置项")]
	[SerializeField]
	public AudioCueSO Level3CueSO;

	[Token(Token = "0x400042A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x400042B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("电梯")]
	public Transform Elevator;

	[Token(Token = "0x400042C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[Header("门")]
	public Transform DoorL;

	[Token(Token = "0x400042D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform DoorR;

	[Token(Token = "0x400042E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x400042F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Header("长按相关")]
	private bool StartGame;

	[Token(Token = "0x4000430")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x111")]
	private bool isPress;

	[Token(Token = "0x4000431")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private float lastPressTime;

	[Token(Token = "0x4000432")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public TextMeshProUGUI ElevatorNumText;

	[Token(Token = "0x4000433")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int ElevatorNum;

	[Token(Token = "0x4000434")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private int trigger;

	[Token(Token = "0x4000435")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool BossDie;

	[Token(Token = "0x6000405")]
	[Address(RVA = "0xB26410", Offset = "0xB26410", VA = "0xB26410")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0xB265E8", Offset = "0xB265E8", VA = "0xB265E8")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0xB26790", Offset = "0xB26790", VA = "0xB26790")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0xB267BC", Offset = "0xB267BC", VA = "0xB267BC")]
	private void longPress()
	{
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0xB265C8", Offset = "0xB265C8", VA = "0xB265C8")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0xB26930", Offset = "0xB26930", VA = "0xB26930")]
	[IteratorStateMachine(typeof(<questPlotT>d__18))]
	private IEnumerator questPlotT()
	{
		return null;
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0xB269A4", Offset = "0xB269A4", VA = "0xB269A4")]
	[IteratorStateMachine(typeof(<plots>d__19))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x600040C")]
	[Address(RVA = "0xB26A18", Offset = "0xB26A18", VA = "0xB26A18")]
	[IteratorStateMachine(typeof(<plotT0>d__20))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x600040D")]
	[Address(RVA = "0xB26A8C", Offset = "0xB26A8C", VA = "0xB26A8C")]
	[IteratorStateMachine(typeof(<plotT1>d__21))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x600040E")]
	[Address(RVA = "0xB26B00", Offset = "0xB26B00", VA = "0xB26B00")]
	[IteratorStateMachine(typeof(<plotT1_2>d__22))]
	private IEnumerator plotT1_2()
	{
		return null;
	}

	[Token(Token = "0x600040F")]
	[Address(RVA = "0xB26B74", Offset = "0xB26B74", VA = "0xB26B74")]
	[IteratorStateMachine(typeof(<downElevator>d__23))]
	private IEnumerator downElevator()
	{
		return null;
	}

	[Token(Token = "0x6000410")]
	[Address(RVA = "0xB26BE8", Offset = "0xB26BE8", VA = "0xB26BE8")]
	[IteratorStateMachine(typeof(<plotStart>d__24))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x6000411")]
	[Address(RVA = "0xB26C5C", Offset = "0xB26C5C", VA = "0xB26C5C")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x6000412")]
	[Address(RVA = "0xB26C7C", Offset = "0xB26C7C", VA = "0xB26C7C")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__26))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x6000413")]
	[Address(RVA = "0xB26D0C", Offset = "0xB26D0C", VA = "0xB26D0C")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__27))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x6000414")]
	[Address(RVA = "0xB26D80", Offset = "0xB26D80", VA = "0xB26D80")]
	[IteratorStateMachine(typeof(<plotTrigger21_1>d__28))]
	private IEnumerator plotTrigger21_1()
	{
		return null;
	}

	[Token(Token = "0x6000415")]
	[Address(RVA = "0xB26DF4", Offset = "0xB26DF4", VA = "0xB26DF4")]
	[IteratorStateMachine(typeof(<win>d__29))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x6000416")]
	[Address(RVA = "0xB26E68", Offset = "0xB26E68", VA = "0xB26E68")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x6000417")]
	[Address(RVA = "0xB26F70", Offset = "0xB26F70", VA = "0xB26F70")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x6000418")]
	[Address(RVA = "0xB26FB0", Offset = "0xB26FB0", VA = "0xB26FB0")]
	[IteratorStateMachine(typeof(<ElevatorMove>d__32))]
	private IEnumerator ElevatorMove(float y)
	{
		return null;
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0xB27034", Offset = "0xB27034", VA = "0xB27034")]
	[IteratorStateMachine(typeof(<DoorLMove>d__33))]
	private IEnumerator DoorLMove(float x)
	{
		return null;
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0xB270B8", Offset = "0xB270B8", VA = "0xB270B8")]
	[IteratorStateMachine(typeof(<DoorRMove>d__34))]
	private IEnumerator DoorRMove(float x)
	{
		return null;
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0xB2713C", Offset = "0xB2713C", VA = "0xB2713C")]
	public Scene2Manager()
	{
	}
}
[Token(Token = "0x20000A0")]
public class Scene3Manager : SceneBaseManager
{
	[Token(Token = "0x20000A1")]
	[CompilerGenerated]
	private sealed class <quickBlack>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000482")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000A5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049B")]
			[Address(RVA = "0xB2B7DC", Offset = "0xB2B7DC", VA = "0xB2B7DC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600049D")]
			[Address(RVA = "0xB2B824", Offset = "0xB2B824", VA = "0xB2B824", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0xB2A334", Offset = "0xB2A334", VA = "0xB2A334")]
		[DebuggerHidden]
		public <quickBlack>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0xB2B71C", Offset = "0xB2B71C", VA = "0xB2B71C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049A")]
		[Address(RVA = "0xB2B720", Offset = "0xB2B720", VA = "0xB2B720", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xB2B7E4", Offset = "0xB2B7E4", VA = "0xB2B7E4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A2")]
	[CompilerGenerated]
	private sealed class <plots>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000485")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000486")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000487")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000A7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0xB2BA44", Offset = "0xB2BA44", VA = "0xB2BA44", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000A8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A3")]
			[Address(RVA = "0xB2BA8C", Offset = "0xB2BA8C", VA = "0xB2BA8C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049E")]
		[Address(RVA = "0xB2A3D0", Offset = "0xB2A3D0", VA = "0xB2A3D0")]
		[DebuggerHidden]
		public <plots>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xB2B82C", Offset = "0xB2B82C", VA = "0xB2B82C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0xB2B830", Offset = "0xB2B830", VA = "0xB2B830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xB2BA4C", Offset = "0xB2BA4C", VA = "0xB2BA4C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A3")]
	[CompilerGenerated]
	private sealed class <plot1>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000488")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000489")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000A9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0xB2BCFC", Offset = "0xB2BCFC", VA = "0xB2BCFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A9")]
			[Address(RVA = "0xB2BD44", Offset = "0xB2BD44", VA = "0xB2BD44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0xB2A46C", Offset = "0xB2A46C", VA = "0xB2A46C")]
		[DebuggerHidden]
		public <plot1>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xB2BA94", Offset = "0xB2BA94", VA = "0xB2BA94", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0xB2BA98", Offset = "0xB2BA98", VA = "0xB2BA98", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0xB2BD04", Offset = "0xB2BD04", VA = "0xB2BD04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A4")]
	[CompilerGenerated]
	private sealed class <plotT1>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400048D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000AB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004AD")]
			[Address(RVA = "0xB2BFF0", Offset = "0xB2BFF0", VA = "0xB2BFF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004AF")]
			[Address(RVA = "0xB2C038", Offset = "0xB2C038", VA = "0xB2C038", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0xB2A508", Offset = "0xB2A508", VA = "0xB2A508")]
		[DebuggerHidden]
		public <plotT1>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0xB2BD4C", Offset = "0xB2BD4C", VA = "0xB2BD4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0xB2BD50", Offset = "0xB2BD50", VA = "0xB2BD50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0xB2BFF8", Offset = "0xB2BFF8", VA = "0xB2BFF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A5")]
	[CompilerGenerated]
	private sealed class <plotT2>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400048E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400048F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000490")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000AD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B3")]
			[Address(RVA = "0xB2C228", Offset = "0xB2C228", VA = "0xB2C228", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004B5")]
			[Address(RVA = "0xB2C270", Offset = "0xB2C270", VA = "0xB2C270", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0xB2A5A4", Offset = "0xB2A5A4", VA = "0xB2A5A4")]
		[DebuggerHidden]
		public <plotT2>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0xB2C040", Offset = "0xB2C040", VA = "0xB2C040", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0xB2C044", Offset = "0xB2C044", VA = "0xB2C044", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xB2C230", Offset = "0xB2C230", VA = "0xB2C230", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A6")]
	[CompilerGenerated]
	private sealed class <plotT3>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000491")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000492")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000493")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000AF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0xB2C3F4", Offset = "0xB2C3F4", VA = "0xB2C3F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004BB")]
			[Address(RVA = "0xB2C43C", Offset = "0xB2C43C", VA = "0xB2C43C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xB2A640", Offset = "0xB2A640", VA = "0xB2A640")]
		[DebuggerHidden]
		public <plotT3>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0xB2C278", Offset = "0xB2C278", VA = "0xB2C278", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xB2C27C", Offset = "0xB2C27C", VA = "0xB2C27C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xB2C3FC", Offset = "0xB2C3FC", VA = "0xB2C3FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A7")]
	[CompilerGenerated]
	private sealed class <plotT4>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000494")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000495")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000496")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000B1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004BF")]
			[Address(RVA = "0xB2C584", Offset = "0xB2C584", VA = "0xB2C584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C1")]
			[Address(RVA = "0xB2C5CC", Offset = "0xB2C5CC", VA = "0xB2C5CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0xB2A6DC", Offset = "0xB2A6DC", VA = "0xB2A6DC")]
		[DebuggerHidden]
		public <plotT4>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0xB2C444", Offset = "0xB2C444", VA = "0xB2C444", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0xB2C448", Offset = "0xB2C448", VA = "0xB2C448", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0xB2C58C", Offset = "0xB2C58C", VA = "0xB2C58C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private sealed class <plotBomb>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000497")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000498")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000499")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x400049A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004C5")]
			[Address(RVA = "0xB2CBF0", Offset = "0xB2CBF0", VA = "0xB2CBF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0xB2CC38", Offset = "0xB2CC38", VA = "0xB2CC38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0xB2A778", Offset = "0xB2A778", VA = "0xB2A778")]
		[DebuggerHidden]
		public <plotBomb>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0xB2C5D4", Offset = "0xB2C5D4", VA = "0xB2C5D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0xB2C5D8", Offset = "0xB2C5D8", VA = "0xB2C5D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0xB2CBF8", Offset = "0xB2CBF8", VA = "0xB2CBF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private sealed class <plotBlock>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400049D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000B5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0xB2CDC8", Offset = "0xB2CDC8", VA = "0xB2CDC8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0xB2CE10", Offset = "0xB2CE10", VA = "0xB2CE10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0xB2A814", Offset = "0xB2A814", VA = "0xB2A814")]
		[DebuggerHidden]
		public <plotBlock>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0xB2CC40", Offset = "0xB2CC40", VA = "0xB2CC40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0xB2CC44", Offset = "0xB2CC44", VA = "0xB2CC44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0xB2CDD0", Offset = "0xB2CDD0", VA = "0xB2CDD0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private sealed class <plotStart>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400049E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400049F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000B7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0xB2D1A4", Offset = "0xB2D1A4", VA = "0xB2D1A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0xB2D1EC", Offset = "0xB2D1EC", VA = "0xB2D1EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0xB2A8B0", Offset = "0xB2A8B0", VA = "0xB2A8B0")]
		[DebuggerHidden]
		public <plotStart>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0xB2CE18", Offset = "0xB2CE18", VA = "0xB2CE18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0xB2CE1C", Offset = "0xB2CE1C", VA = "0xB2CE1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0xB2D1AC", Offset = "0xB2D1AC", VA = "0xB2D1AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnemyTriggerSO so;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000B9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0xB2DCB8", Offset = "0xB2DCB8", VA = "0xB2DCB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xB2DD00", Offset = "0xB2DD00", VA = "0xB2DD00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004D4")]
		[Address(RVA = "0xB2A988", Offset = "0xB2A988", VA = "0xB2A988")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x60004D5")]
		[Address(RVA = "0xB2D1F4", Offset = "0xB2D1F4", VA = "0xB2D1F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004D6")]
		[Address(RVA = "0xB2D1F8", Offset = "0xB2D1F8", VA = "0xB2D1F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004D8")]
		[Address(RVA = "0xB2DCC0", Offset = "0xB2DCC0", VA = "0xB2DCC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private sealed class <plotTrigger6s>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000BB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0xB2DD88", Offset = "0xB2DD88", VA = "0xB2DD88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0xB2DDD0", Offset = "0xB2DDD0", VA = "0xB2DDD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004DA")]
		[Address(RVA = "0xB2AA24", Offset = "0xB2AA24", VA = "0xB2AA24")]
		[DebuggerHidden]
		public <plotTrigger6s>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x60004DB")]
		[Address(RVA = "0xB2DD08", Offset = "0xB2DD08", VA = "0xB2DD08", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004DC")]
		[Address(RVA = "0xB2DD0C", Offset = "0xB2DD0C", VA = "0xB2DD0C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004DE")]
		[Address(RVA = "0xB2DD90", Offset = "0xB2DD90", VA = "0xB2DD90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private sealed class <plotTrigger6_1>d__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000BD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0xB2DE88", Offset = "0xB2DE88", VA = "0xB2DE88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004E5")]
			[Address(RVA = "0xB2DED0", Offset = "0xB2DED0", VA = "0xB2DED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E0")]
		[Address(RVA = "0xB2AAC0", Offset = "0xB2AAC0", VA = "0xB2AAC0")]
		[DebuggerHidden]
		public <plotTrigger6_1>d__41(int <>1__state)
		{
		}

		[Token(Token = "0x60004E1")]
		[Address(RVA = "0xB2DDD8", Offset = "0xB2DDD8", VA = "0xB2DDD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E2")]
		[Address(RVA = "0xB2DDDC", Offset = "0xB2DDDC", VA = "0xB2DDDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004E4")]
		[Address(RVA = "0xB2DE90", Offset = "0xB2DE90", VA = "0xB2DE90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[CompilerGenerated]
	private sealed class <plotTrigger8s>d__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000BF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004E9")]
			[Address(RVA = "0xB2DF98", Offset = "0xB2DF98", VA = "0xB2DF98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004EB")]
			[Address(RVA = "0xB2DFE0", Offset = "0xB2DFE0", VA = "0xB2DFE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004E6")]
		[Address(RVA = "0xB2AB5C", Offset = "0xB2AB5C", VA = "0xB2AB5C")]
		[DebuggerHidden]
		public <plotTrigger8s>d__42(int <>1__state)
		{
		}

		[Token(Token = "0x60004E7")]
		[Address(RVA = "0xB2DED8", Offset = "0xB2DED8", VA = "0xB2DED8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004E8")]
		[Address(RVA = "0xB2DEDC", Offset = "0xB2DEDC", VA = "0xB2DEDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xB2DFA0", Offset = "0xB2DFA0", VA = "0xB2DFA0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AF")]
	[CompilerGenerated]
	private sealed class <plotTrigger8_1>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000C1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004EF")]
			[Address(RVA = "0xB2E67C", Offset = "0xB2E67C", VA = "0xB2E67C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F1")]
			[Address(RVA = "0xB2E6C4", Offset = "0xB2E6C4", VA = "0xB2E6C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xB2ABF8", Offset = "0xB2ABF8", VA = "0xB2ABF8")]
		[DebuggerHidden]
		public <plotTrigger8_1>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x60004ED")]
		[Address(RVA = "0xB2DFE8", Offset = "0xB2DFE8", VA = "0xB2DFE8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004EE")]
		[Address(RVA = "0xB2DFEC", Offset = "0xB2DFEC", VA = "0xB2DFEC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F0")]
		[Address(RVA = "0xB2E684", Offset = "0xB2E684", VA = "0xB2E684", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B0")]
	[CompilerGenerated]
	private sealed class <plotTrigger8_2>d__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000C3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004F5")]
			[Address(RVA = "0xB2E77C", Offset = "0xB2E77C", VA = "0xB2E77C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004F7")]
			[Address(RVA = "0xB2E7C4", Offset = "0xB2E7C4", VA = "0xB2E7C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F2")]
		[Address(RVA = "0xB2AC94", Offset = "0xB2AC94", VA = "0xB2AC94")]
		[DebuggerHidden]
		public <plotTrigger8_2>d__44(int <>1__state)
		{
		}

		[Token(Token = "0x60004F3")]
		[Address(RVA = "0xB2E6CC", Offset = "0xB2E6CC", VA = "0xB2E6CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004F4")]
		[Address(RVA = "0xB2E6D0", Offset = "0xB2E6D0", VA = "0xB2E6D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0xB2E784", Offset = "0xB2E784", VA = "0xB2E784", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class <plotTrigger9s>d__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000C5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004FB")]
			[Address(RVA = "0xB2E84C", Offset = "0xB2E84C", VA = "0xB2E84C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004FD")]
			[Address(RVA = "0xB2E894", Offset = "0xB2E894", VA = "0xB2E894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0xB2AD30", Offset = "0xB2AD30", VA = "0xB2AD30")]
		[DebuggerHidden]
		public <plotTrigger9s>d__45(int <>1__state)
		{
		}

		[Token(Token = "0x60004F9")]
		[Address(RVA = "0xB2E7CC", Offset = "0xB2E7CC", VA = "0xB2E7CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004FA")]
		[Address(RVA = "0xB2E7D0", Offset = "0xB2E7D0", VA = "0xB2E7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xB2E854", Offset = "0xB2E854", VA = "0xB2E854", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class <plotTrigger9_1>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000C7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000501")]
			[Address(RVA = "0xB2EC0C", Offset = "0xB2EC0C", VA = "0xB2EC0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000503")]
			[Address(RVA = "0xB2EC54", Offset = "0xB2EC54", VA = "0xB2EC54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004FE")]
		[Address(RVA = "0xB2ADCC", Offset = "0xB2ADCC", VA = "0xB2ADCC")]
		[DebuggerHidden]
		public <plotTrigger9_1>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x60004FF")]
		[Address(RVA = "0xB2E89C", Offset = "0xB2E89C", VA = "0xB2E89C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000500")]
		[Address(RVA = "0xB2E8A0", Offset = "0xB2E8A0", VA = "0xB2E8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000502")]
		[Address(RVA = "0xB2EC14", Offset = "0xB2EC14", VA = "0xB2EC14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class <plotTrigger11s>d__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000C9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000507")]
			[Address(RVA = "0xB2ECDC", Offset = "0xB2ECDC", VA = "0xB2ECDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000509")]
			[Address(RVA = "0xB2ED24", Offset = "0xB2ED24", VA = "0xB2ED24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000504")]
		[Address(RVA = "0xB2AE68", Offset = "0xB2AE68", VA = "0xB2AE68")]
		[DebuggerHidden]
		public <plotTrigger11s>d__47(int <>1__state)
		{
		}

		[Token(Token = "0x6000505")]
		[Address(RVA = "0xB2EC5C", Offset = "0xB2EC5C", VA = "0xB2EC5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000506")]
		[Address(RVA = "0xB2EC60", Offset = "0xB2EC60", VA = "0xB2EC60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0xB2ECE4", Offset = "0xB2ECE4", VA = "0xB2ECE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B4")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000CB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0xB2F2E8", Offset = "0xB2F2E8", VA = "0xB2F2E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600050F")]
			[Address(RVA = "0xB2F330", Offset = "0xB2F330", VA = "0xB2F330", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0xB2AF04", Offset = "0xB2AF04", VA = "0xB2AF04")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0xB2ED2C", Offset = "0xB2ED2C", VA = "0xB2ED2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0xB2ED30", Offset = "0xB2ED30", VA = "0xB2ED30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0xB2F2F0", Offset = "0xB2F2F0", VA = "0xB2F2F0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B5")]
	[CompilerGenerated]
	private sealed class <plotTrigger18s>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000CD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000513")]
			[Address(RVA = "0xB2F3B8", Offset = "0xB2F3B8", VA = "0xB2F3B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000CE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000515")]
			[Address(RVA = "0xB2F400", Offset = "0xB2F400", VA = "0xB2F400", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0xB2AFA0", Offset = "0xB2AFA0", VA = "0xB2AFA0")]
		[DebuggerHidden]
		public <plotTrigger18s>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0xB2F338", Offset = "0xB2F338", VA = "0xB2F338", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0xB2F33C", Offset = "0xB2F33C", VA = "0xB2F33C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0xB2F3C0", Offset = "0xB2F3C0", VA = "0xB2F3C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B6")]
	[CompilerGenerated]
	private sealed class <plotTrigger18_1>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000CF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000519")]
			[Address(RVA = "0xB2F938", Offset = "0xB2F938", VA = "0xB2F938", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600051B")]
			[Address(RVA = "0xB2F980", Offset = "0xB2F980", VA = "0xB2F980", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0xB2B03C", Offset = "0xB2B03C", VA = "0xB2B03C")]
		[DebuggerHidden]
		public <plotTrigger18_1>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0xB2F408", Offset = "0xB2F408", VA = "0xB2F408", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0xB2F40C", Offset = "0xB2F40C", VA = "0xB2F40C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0xB2F940", Offset = "0xB2F940", VA = "0xB2F940", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B7")]
	[CompilerGenerated]
	private sealed class <plotTrigger28s>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000D1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600051F")]
			[Address(RVA = "0xB2FA08", Offset = "0xB2FA08", VA = "0xB2FA08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000521")]
			[Address(RVA = "0xB2FA50", Offset = "0xB2FA50", VA = "0xB2FA50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0xB2B0D8", Offset = "0xB2B0D8", VA = "0xB2B0D8")]
		[DebuggerHidden]
		public <plotTrigger28s>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0xB2F988", Offset = "0xB2F988", VA = "0xB2F988", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0xB2F98C", Offset = "0xB2F98C", VA = "0xB2F98C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0xB2FA10", Offset = "0xB2FA10", VA = "0xB2FA10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class <plotTrigger28_1>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000D3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000525")]
			[Address(RVA = "0xB2FEEC", Offset = "0xB2FEEC", VA = "0xB2FEEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000527")]
			[Address(RVA = "0xB2FF34", Offset = "0xB2FF34", VA = "0xB2FF34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0xB2B174", Offset = "0xB2B174", VA = "0xB2B174")]
		[DebuggerHidden]
		public <plotTrigger28_1>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0xB2FA58", Offset = "0xB2FA58", VA = "0xB2FA58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0xB2FA5C", Offset = "0xB2FA5C", VA = "0xB2FA5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000526")]
		[Address(RVA = "0xB2FEF4", Offset = "0xB2FEF4", VA = "0xB2FEF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000B9")]
	[CompilerGenerated]
	private sealed class <win>d__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000D5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600052B")]
			[Address(RVA = "0xB30424", Offset = "0xB30424", VA = "0xB30424", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600052D")]
			[Address(RVA = "0xB3046C", Offset = "0xB3046C", VA = "0xB3046C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000528")]
		[Address(RVA = "0xB2B210", Offset = "0xB2B210", VA = "0xB2B210")]
		[DebuggerHidden]
		public <win>d__57(int <>1__state)
		{
		}

		[Token(Token = "0x6000529")]
		[Address(RVA = "0xB2FF3C", Offset = "0xB2FF3C", VA = "0xB2FF3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600052A")]
		[Address(RVA = "0xB2FF40", Offset = "0xB2FF40", VA = "0xB2FF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600052C")]
		[Address(RVA = "0xB3042C", Offset = "0xB3042C", VA = "0xB3042C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BA")]
	[CompilerGenerated]
	private sealed class <HeroineMove>d__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int trigger;

		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x170000D7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000531")]
			[Address(RVA = "0xB305B8", Offset = "0xB305B8", VA = "0xB305B8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000D8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000533")]
			[Address(RVA = "0xB30600", Offset = "0xB30600", VA = "0xB30600", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600052E")]
		[Address(RVA = "0xB2B390", Offset = "0xB2B390", VA = "0xB2B390")]
		[DebuggerHidden]
		public <HeroineMove>d__59(int <>1__state)
		{
		}

		[Token(Token = "0x600052F")]
		[Address(RVA = "0xB30474", Offset = "0xB30474", VA = "0xB30474", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000530")]
		[Address(RVA = "0xB30478", Offset = "0xB30478", VA = "0xB30478", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000532")]
		[Address(RVA = "0xB305C0", Offset = "0xB305C0", VA = "0xB305C0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BB")]
	[CompilerGenerated]
	private sealed class <plotNpc1>d__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000D9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000537")]
			[Address(RVA = "0xB308D8", Offset = "0xB308D8", VA = "0xB308D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000539")]
			[Address(RVA = "0xB30920", Offset = "0xB30920", VA = "0xB30920", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000534")]
		[Address(RVA = "0xB2B42C", Offset = "0xB2B42C", VA = "0xB2B42C")]
		[DebuggerHidden]
		public <plotNpc1>d__64(int <>1__state)
		{
		}

		[Token(Token = "0x6000535")]
		[Address(RVA = "0xB30608", Offset = "0xB30608", VA = "0xB30608", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000536")]
		[Address(RVA = "0xB3060C", Offset = "0xB3060C", VA = "0xB3060C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000538")]
		[Address(RVA = "0xB308E0", Offset = "0xB308E0", VA = "0xB308E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private sealed class <plotBombNpc>d__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000DB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600053D")]
			[Address(RVA = "0xB30ADC", Offset = "0xB30ADC", VA = "0xB30ADC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600053F")]
			[Address(RVA = "0xB30B24", Offset = "0xB30B24", VA = "0xB30B24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xB2B4C8", Offset = "0xB2B4C8", VA = "0xB2B4C8")]
		[DebuggerHidden]
		public <plotBombNpc>d__65(int <>1__state)
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xB30928", Offset = "0xB30928", VA = "0xB30928", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600053C")]
		[Address(RVA = "0xB3092C", Offset = "0xB3092C", VA = "0xB3092C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600053E")]
		[Address(RVA = "0xB30AE4", Offset = "0xB30AE4", VA = "0xB30AE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BD")]
	[CompilerGenerated]
	private sealed class <plotStartNpc>d__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000DD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000543")]
			[Address(RVA = "0xB30BE4", Offset = "0xB30BE4", VA = "0xB30BE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000545")]
			[Address(RVA = "0xB30C2C", Offset = "0xB30C2C", VA = "0xB30C2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000540")]
		[Address(RVA = "0xB2B564", Offset = "0xB2B564", VA = "0xB2B564")]
		[DebuggerHidden]
		public <plotStartNpc>d__66(int <>1__state)
		{
		}

		[Token(Token = "0x6000541")]
		[Address(RVA = "0xB30B2C", Offset = "0xB30B2C", VA = "0xB30B2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000542")]
		[Address(RVA = "0xB30B30", Offset = "0xB30B30", VA = "0xB30B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0xB30BEC", Offset = "0xB30BEC", VA = "0xB30BEC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BE")]
	[CompilerGenerated]
	private sealed class <destroyNpc>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000DF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000549")]
			[Address(RVA = "0xB30D08", Offset = "0xB30D08", VA = "0xB30D08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600054B")]
			[Address(RVA = "0xB30D50", Offset = "0xB30D50", VA = "0xB30D50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0xB2B600", Offset = "0xB2B600", VA = "0xB2B600")]
		[DebuggerHidden]
		public <destroyNpc>d__67(int <>1__state)
		{
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0xB30C34", Offset = "0xB30C34", VA = "0xB30C34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0xB30C38", Offset = "0xB30C38", VA = "0xB30C38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0xB30D10", Offset = "0xB30D10", VA = "0xB30D10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000BF")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1Npc>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene3Manager <>4__this;

		[Token(Token = "0x170000E1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600054F")]
			[Address(RVA = "0xB30F68", Offset = "0xB30F68", VA = "0xB30F68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000551")]
			[Address(RVA = "0xB30FB0", Offset = "0xB30FB0", VA = "0xB30FB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0xB2B69C", Offset = "0xB2B69C", VA = "0xB2B69C")]
		[DebuggerHidden]
		public <plotTrigger11_1Npc>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0xB30D58", Offset = "0xB30D58", VA = "0xB30D58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0xB30D5C", Offset = "0xB30D5C", VA = "0xB30D5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0xB30F70", Offset = "0xB30F70", VA = "0xB30F70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000464")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private string DefaultWeapon;

	[Token(Token = "0x4000465")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[Header("爆炸特效")]
	public GameObject bombFx;

	[Token(Token = "0x4000466")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("爆炸的车")]
	public GameObject car1;

	[Token(Token = "0x4000467")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	[Header("门")]
	public GameObject DoorL;

	[Token(Token = "0x4000468")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public GameObject DoorR;

	[Token(Token = "0x4000469")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject DepotDoor;

	[Token(Token = "0x400046A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextMeshProUGUI DoorUI;

	[Token(Token = "0x400046B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public TextMeshProUGUI DepoteDoorUI;

	[Token(Token = "0x400046C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject PathSign;

	[Token(Token = "0x400046D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject DoorLan;

	[Token(Token = "0x400046E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[Header("冲击的车")]
	public GameObject ShockCar;

	[Token(Token = "0x400046F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject ShockCarDoorL;

	[Token(Token = "0x4000470")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject ShockCarDoorR;

	[Token(Token = "0x4000471")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[Header("长按相关")]
	private bool StartGame;

	[Token(Token = "0x4000472")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x149")]
	private bool isPress;

	[Token(Token = "0x4000473")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14C")]
	private float lastPressTime;

	[Token(Token = "0x4000474")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[Header("Npc和队长")]
	public GameObject Npc1;

	[Token(Token = "0x4000475")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject Npc2;

	[Token(Token = "0x4000476")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject Npc3;

	[Token(Token = "0x4000477")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public GameObject Npc4;

	[Token(Token = "0x4000478")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[Header("Level1 Event SO")]
	[SerializeField]
	public AudioCueSO Level1CueSO;

	[Token(Token = "0x4000479")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[Header("TeleportArea")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_1;

	[Token(Token = "0x400047A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Transform NpcJc1;

	[Token(Token = "0x400047B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Transform NpcJc2;

	[Token(Token = "0x400047C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Transform NpcJc3;

	[Token(Token = "0x400047D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Transform NpcJc4;

	[Token(Token = "0x400047E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private NpcController npcContr1;

	[Token(Token = "0x400047F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private NpcController npcContr2;

	[Token(Token = "0x4000480")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private NpcController npcContr3;

	[Token(Token = "0x4000481")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private NpcController npcContr4;

	[Token(Token = "0x6000470")]
	[Address(RVA = "0xB29DD4", Offset = "0xB29DD4", VA = "0xB29DD4")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000471")]
	[Address(RVA = "0xB2A04C", Offset = "0xB2A04C", VA = "0xB2A04C")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0xB2A140", Offset = "0xB2A140", VA = "0xB2A140")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0xB29F7C", Offset = "0xB29F7C", VA = "0xB29F7C")]
	private void Init()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0xB2A16C", Offset = "0xB2A16C", VA = "0xB2A16C")]
	private void longPress()
	{
	}

	[Token(Token = "0x6000475")]
	[Address(RVA = "0xB2A2C0", Offset = "0xB2A2C0", VA = "0xB2A2C0")]
	[IteratorStateMachine(typeof(<quickBlack>d__27))]
	private IEnumerator quickBlack()
	{
		return null;
	}

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xB2A02C", Offset = "0xB2A02C", VA = "0xB2A02C")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xB2A35C", Offset = "0xB2A35C", VA = "0xB2A35C")]
	[IteratorStateMachine(typeof(<plots>d__29))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xB2A3F8", Offset = "0xB2A3F8", VA = "0xB2A3F8")]
	[IteratorStateMachine(typeof(<plot1>d__30))]
	private IEnumerator plot1()
	{
		return null;
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xB2A494", Offset = "0xB2A494", VA = "0xB2A494")]
	[IteratorStateMachine(typeof(<plotT1>d__31))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xB2A530", Offset = "0xB2A530", VA = "0xB2A530")]
	[IteratorStateMachine(typeof(<plotT2>d__32))]
	private IEnumerator plotT2()
	{
		return null;
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xB2A5CC", Offset = "0xB2A5CC", VA = "0xB2A5CC")]
	[IteratorStateMachine(typeof(<plotT3>d__33))]
	private IEnumerator plotT3()
	{
		return null;
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xB2A668", Offset = "0xB2A668", VA = "0xB2A668")]
	[IteratorStateMachine(typeof(<plotT4>d__34))]
	private IEnumerator plotT4()
	{
		return null;
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xB2A704", Offset = "0xB2A704", VA = "0xB2A704")]
	[IteratorStateMachine(typeof(<plotBomb>d__35))]
	private IEnumerator plotBomb()
	{
		return null;
	}

	[Token(Token = "0x600047E")]
	[Address(RVA = "0xB2A7A0", Offset = "0xB2A7A0", VA = "0xB2A7A0")]
	[IteratorStateMachine(typeof(<plotBlock>d__36))]
	private IEnumerator plotBlock()
	{
		return null;
	}

	[Token(Token = "0x600047F")]
	[Address(RVA = "0xB2A83C", Offset = "0xB2A83C", VA = "0xB2A83C")]
	[IteratorStateMachine(typeof(<plotStart>d__37))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x6000480")]
	[Address(RVA = "0xB2A8D8", Offset = "0xB2A8D8", VA = "0xB2A8D8")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x6000481")]
	[Address(RVA = "0xB2A8F8", Offset = "0xB2A8F8", VA = "0xB2A8F8")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__39))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x6000482")]
	[Address(RVA = "0xB2A9B0", Offset = "0xB2A9B0", VA = "0xB2A9B0")]
	[IteratorStateMachine(typeof(<plotTrigger6s>d__40))]
	private IEnumerator plotTrigger6s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000483")]
	[Address(RVA = "0xB2AA4C", Offset = "0xB2AA4C", VA = "0xB2AA4C")]
	[IteratorStateMachine(typeof(<plotTrigger6_1>d__41))]
	private IEnumerator plotTrigger6_1()
	{
		return null;
	}

	[Token(Token = "0x6000484")]
	[Address(RVA = "0xB2AAE8", Offset = "0xB2AAE8", VA = "0xB2AAE8")]
	[IteratorStateMachine(typeof(<plotTrigger8s>d__42))]
	private IEnumerator plotTrigger8s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000485")]
	[Address(RVA = "0xB2AB84", Offset = "0xB2AB84", VA = "0xB2AB84")]
	[IteratorStateMachine(typeof(<plotTrigger8_1>d__43))]
	private IEnumerator plotTrigger8_1()
	{
		return null;
	}

	[Token(Token = "0x6000486")]
	[Address(RVA = "0xB2AC20", Offset = "0xB2AC20", VA = "0xB2AC20")]
	[IteratorStateMachine(typeof(<plotTrigger8_2>d__44))]
	private IEnumerator plotTrigger8_2()
	{
		return null;
	}

	[Token(Token = "0x6000487")]
	[Address(RVA = "0xB2ACBC", Offset = "0xB2ACBC", VA = "0xB2ACBC")]
	[IteratorStateMachine(typeof(<plotTrigger9s>d__45))]
	private IEnumerator plotTrigger9s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000488")]
	[Address(RVA = "0xB2AD58", Offset = "0xB2AD58", VA = "0xB2AD58")]
	[IteratorStateMachine(typeof(<plotTrigger9_1>d__46))]
	private IEnumerator plotTrigger9_1()
	{
		return null;
	}

	[Token(Token = "0x6000489")]
	[Address(RVA = "0xB2ADF4", Offset = "0xB2ADF4", VA = "0xB2ADF4")]
	[IteratorStateMachine(typeof(<plotTrigger11s>d__47))]
	private IEnumerator plotTrigger11s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x600048A")]
	[Address(RVA = "0xB2AE90", Offset = "0xB2AE90", VA = "0xB2AE90")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__48))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x600048B")]
	[Address(RVA = "0xB2AF2C", Offset = "0xB2AF2C", VA = "0xB2AF2C")]
	[IteratorStateMachine(typeof(<plotTrigger18s>d__49))]
	private IEnumerator plotTrigger18s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x600048C")]
	[Address(RVA = "0xB2AFC8", Offset = "0xB2AFC8", VA = "0xB2AFC8")]
	[IteratorStateMachine(typeof(<plotTrigger18_1>d__50))]
	private IEnumerator plotTrigger18_1()
	{
		return null;
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xB2B064", Offset = "0xB2B064", VA = "0xB2B064")]
	[IteratorStateMachine(typeof(<plotTrigger28s>d__55))]
	private IEnumerator plotTrigger28s(int trigger)
	{
		return null;
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xB2B100", Offset = "0xB2B100", VA = "0xB2B100")]
	[IteratorStateMachine(typeof(<plotTrigger28_1>d__56))]
	private IEnumerator plotTrigger28_1()
	{
		return null;
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xB2B19C", Offset = "0xB2B19C", VA = "0xB2B19C")]
	[IteratorStateMachine(typeof(<win>d__57))]
	private IEnumerator win(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xB2B238", Offset = "0xB2B238", VA = "0xB2B238")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xB2B30C", Offset = "0xB2B30C", VA = "0xB2B30C")]
	[IteratorStateMachine(typeof(<HeroineMove>d__59))]
	private new IEnumerator HeroineMove(int trigger)
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xB2B3B8", Offset = "0xB2B3B8", VA = "0xB2B3B8")]
	[IteratorStateMachine(typeof(<plotNpc1>d__64))]
	private IEnumerator plotNpc1()
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xB2B454", Offset = "0xB2B454", VA = "0xB2B454")]
	[IteratorStateMachine(typeof(<plotBombNpc>d__65))]
	private IEnumerator plotBombNpc()
	{
		return null;
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xB2B4F0", Offset = "0xB2B4F0", VA = "0xB2B4F0")]
	[IteratorStateMachine(typeof(<plotStartNpc>d__66))]
	private IEnumerator plotStartNpc()
	{
		return null;
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xB2B58C", Offset = "0xB2B58C", VA = "0xB2B58C")]
	[IteratorStateMachine(typeof(<destroyNpc>d__67))]
	private IEnumerator destroyNpc()
	{
		return null;
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xB2B628", Offset = "0xB2B628", VA = "0xB2B628")]
	[IteratorStateMachine(typeof(<plotTrigger11_1Npc>d__68))]
	private IEnumerator plotTrigger11_1Npc()
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xB2B6C4", Offset = "0xB2B6C4", VA = "0xB2B6C4")]
	public Scene3Manager()
	{
	}
}
[Token(Token = "0x20000C0")]
public class Scene4Manager : SceneBaseManager
{
	[Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private sealed class <plots>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40004FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40004FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000E3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000566")]
			[Address(RVA = "0xB31AF0", Offset = "0xB31AF0", VA = "0xB31AF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000568")]
			[Address(RVA = "0xB31B38", Offset = "0xB31B38", VA = "0xB31B38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0xB3130C", Offset = "0xB3130C", VA = "0xB3130C")]
		[DebuggerHidden]
		public <plots>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0xB319F0", Offset = "0xB319F0", VA = "0xB319F0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0xB319F4", Offset = "0xB319F4", VA = "0xB319F4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0xB31AF8", Offset = "0xB31AF8", VA = "0xB31AF8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C2")]
	[CompilerGenerated]
	private sealed class <plotT0>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40004FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000E5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600056C")]
			[Address(RVA = "0xB31D68", Offset = "0xB31D68", VA = "0xB31D68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600056E")]
			[Address(RVA = "0xB31DB0", Offset = "0xB31DB0", VA = "0xB31DB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0xB313A8", Offset = "0xB313A8", VA = "0xB313A8")]
		[DebuggerHidden]
		public <plotT0>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0xB31B40", Offset = "0xB31B40", VA = "0xB31B40", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0xB31B44", Offset = "0xB31B44", VA = "0xB31B44", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0xB31D70", Offset = "0xB31D70", VA = "0xB31D70", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C3")]
	[CompilerGenerated]
	private sealed class <plotT1>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000E7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000572")]
			[Address(RVA = "0xB320D0", Offset = "0xB320D0", VA = "0xB320D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000E8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0xB32118", Offset = "0xB32118", VA = "0xB32118", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0xB31444", Offset = "0xB31444", VA = "0xB31444")]
		[DebuggerHidden]
		public <plotT1>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0xB31DB8", Offset = "0xB31DB8", VA = "0xB31DB8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0xB31DBC", Offset = "0xB31DBC", VA = "0xB31DBC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000573")]
		[Address(RVA = "0xB320D8", Offset = "0xB320D8", VA = "0xB320D8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C4")]
	[CompilerGenerated]
	private sealed class <plotStart>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000E9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0xB32230", Offset = "0xB32230", VA = "0xB32230", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0xB32278", Offset = "0xB32278", VA = "0xB32278", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0xB314E0", Offset = "0xB314E0", VA = "0xB314E0")]
		[DebuggerHidden]
		public <plotStart>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0xB32120", Offset = "0xB32120", VA = "0xB32120", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0xB32124", Offset = "0xB32124", VA = "0xB32124", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0xB32238", Offset = "0xB32238", VA = "0xB32238", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C5")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x170000EB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600057E")]
			[Address(RVA = "0xB32A0C", Offset = "0xB32A0C", VA = "0xB32A0C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000580")]
			[Address(RVA = "0xB32A54", Offset = "0xB32A54", VA = "0xB32A54", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0xB315B8", Offset = "0xB315B8", VA = "0xB315B8")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__35(int <>1__state)
		{
		}

		[Token(Token = "0x600057C")]
		[Address(RVA = "0xB32280", Offset = "0xB32280", VA = "0xB32280", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0xB32284", Offset = "0xB32284", VA = "0xB32284", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0xB32A14", Offset = "0xB32A14", VA = "0xB32A14", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C6")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000ED")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000584")]
			[Address(RVA = "0xB33030", Offset = "0xB33030", VA = "0xB33030", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000586")]
			[Address(RVA = "0xB33078", Offset = "0xB33078", VA = "0xB33078", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0xB31654", Offset = "0xB31654", VA = "0xB31654")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__36(int <>1__state)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0xB32A5C", Offset = "0xB32A5C", VA = "0xB32A5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0xB32A60", Offset = "0xB32A60", VA = "0xB32A60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0xB33038", Offset = "0xB33038", VA = "0xB33038", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C7")]
	[CompilerGenerated]
	private sealed class <win>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x170000EF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600058A")]
			[Address(RVA = "0xB33518", Offset = "0xB33518", VA = "0xB33518", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600058C")]
			[Address(RVA = "0xB33560", Offset = "0xB33560", VA = "0xB33560", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0xB316F0", Offset = "0xB316F0", VA = "0xB316F0")]
		[DebuggerHidden]
		public <win>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0xB33080", Offset = "0xB33080", VA = "0xB33080", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0xB33084", Offset = "0xB33084", VA = "0xB33084", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0xB33520", Offset = "0xB33520", VA = "0xB33520", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C8")]
	[CompilerGenerated]
	private sealed class <DoorLMove>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x170000F1")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000590")]
			[Address(RVA = "0xB33770", Offset = "0xB33770", VA = "0xB33770", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000592")]
			[Address(RVA = "0xB337B8", Offset = "0xB337B8", VA = "0xB337B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0xB318C4", Offset = "0xB318C4", VA = "0xB318C4")]
		[DebuggerHidden]
		public <DoorLMove>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0xB33568", Offset = "0xB33568", VA = "0xB33568", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0xB3356C", Offset = "0xB3356C", VA = "0xB3356C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0xB33778", Offset = "0xB33778", VA = "0xB33778", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private sealed class <DoorRMove>d__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene4Manager <>4__this;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x170000F3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000596")]
			[Address(RVA = "0xB339C8", Offset = "0xB339C8", VA = "0xB339C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000598")]
			[Address(RVA = "0xB33A10", Offset = "0xB33A10", VA = "0xB33A10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0xB31970", Offset = "0xB31970", VA = "0xB31970")]
		[DebuggerHidden]
		public <DoorRMove>d__40(int <>1__state)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0xB337C0", Offset = "0xB337C0", VA = "0xB337C0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0xB337C4", Offset = "0xB337C4", VA = "0xB337C4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0xB339D0", Offset = "0xB339D0", VA = "0xB339D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40004E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Header("[配置项")]
	[SerializeField]
	public AudioCueSO Level4CueSO;

	[Token(Token = "0x40004E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x40004E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform Door1;

	[Token(Token = "0x40004E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform Door2;

	[Token(Token = "0x40004E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform Door3;

	[Token(Token = "0x40004E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public TextMeshProUGUI DoorText1;

	[Token(Token = "0x40004E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextMeshProUGUI DoorText2;

	[Token(Token = "0x40004EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject BackM1;

	[Token(Token = "0x40004EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject BackM2;

	[Token(Token = "0x40004EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Transform DoorL;

	[Token(Token = "0x40004ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Transform DoorR;

	[Token(Token = "0x40004EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[Header("路障")]
	public GameObject Zh_1;

	[Token(Token = "0x40004EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject Zh_2;

	[Token(Token = "0x40004F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public GameObject LZ_1;

	[Token(Token = "0x40004F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public GameObject LZ_2;

	[Token(Token = "0x40004F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject LZ_3;

	[Token(Token = "0x40004F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x40004F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	[SerializeField]
	[Header("Teleport")]
	private GameObject[] ArriveTeleportAreas_1;

	[Token(Token = "0x40004F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_2;

	[Token(Token = "0x40004F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_3;

	[Token(Token = "0x40004F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	[SerializeField]
	private GameObject ArriveTeleportAreas_3_1;

	[Token(Token = "0x40004F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	[SerializeField]
	private GameObject ArriveTeleportAreas_3_2;

	[Token(Token = "0x40004F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	[SerializeField]
	private GameObject ArriveTeleportAreas_3_3;

	[Token(Token = "0x40004FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private int trigger;

	[Token(Token = "0x40004FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private bool BossDie;

	[Token(Token = "0x6000552")]
	[Address(RVA = "0xB30FB8", Offset = "0xB30FB8", VA = "0xB30FB8")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0xB3119C", Offset = "0xB3119C", VA = "0xB3119C")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000554")]
	[Address(RVA = "0xB31290", Offset = "0xB31290", VA = "0xB31290")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000555")]
	[Address(RVA = "0xB3117C", Offset = "0xB3117C", VA = "0xB3117C")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x6000556")]
	[Address(RVA = "0xB31298", Offset = "0xB31298", VA = "0xB31298")]
	[IteratorStateMachine(typeof(<plots>d__29))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0xB310CC", Offset = "0xB310CC", VA = "0xB310CC")]
	private void Init()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0xB31334", Offset = "0xB31334", VA = "0xB31334")]
	[IteratorStateMachine(typeof(<plotT0>d__31))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0xB313D0", Offset = "0xB313D0", VA = "0xB313D0")]
	[IteratorStateMachine(typeof(<plotT1>d__32))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0xB3146C", Offset = "0xB3146C", VA = "0xB3146C")]
	[IteratorStateMachine(typeof(<plotStart>d__33))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x600055B")]
	[Address(RVA = "0xB31508", Offset = "0xB31508", VA = "0xB31508")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x600055C")]
	[Address(RVA = "0xB31528", Offset = "0xB31528", VA = "0xB31528")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__35))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x600055D")]
	[Address(RVA = "0xB315E0", Offset = "0xB315E0", VA = "0xB315E0")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__36))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x600055E")]
	[Address(RVA = "0xB3167C", Offset = "0xB3167C", VA = "0xB3167C")]
	[IteratorStateMachine(typeof(<win>d__37))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x600055F")]
	[Address(RVA = "0xB31718", Offset = "0xB31718", VA = "0xB31718")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x6000560")]
	[Address(RVA = "0xB31840", Offset = "0xB31840", VA = "0xB31840")]
	[IteratorStateMachine(typeof(<DoorLMove>d__39))]
	private IEnumerator DoorLMove(float x)
	{
		return null;
	}

	[Token(Token = "0x6000561")]
	[Address(RVA = "0xB318EC", Offset = "0xB318EC", VA = "0xB318EC")]
	[IteratorStateMachine(typeof(<DoorRMove>d__40))]
	private IEnumerator DoorRMove(float x)
	{
		return null;
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0xB31998", Offset = "0xB31998", VA = "0xB31998")]
	public Scene4Manager()
	{
	}
}
[Token(Token = "0x20000CA")]
public class Scene5Manager : SceneBaseManager
{
	[Token(Token = "0x20000CB")]
	[CompilerGenerated]
	private sealed class <plots>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x170000F5")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005AD")]
			[Address(RVA = "0xB34560", Offset = "0xB34560", VA = "0xB34560", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F6")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005AF")]
			[Address(RVA = "0xB345A8", Offset = "0xB345A8", VA = "0xB345A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0xB33E14", Offset = "0xB33E14", VA = "0xB33E14")]
		[DebuggerHidden]
		public <plots>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0xB34460", Offset = "0xB34460", VA = "0xB34460", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0xB34464", Offset = "0xB34464", VA = "0xB34464", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0xB34568", Offset = "0xB34568", VA = "0xB34568", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CC")]
	[CompilerGenerated]
	private sealed class <plotT0>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x170000F7")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0xB347C8", Offset = "0xB347C8", VA = "0xB347C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F8")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0xB34810", Offset = "0xB34810", VA = "0xB34810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0xB33EB0", Offset = "0xB33EB0", VA = "0xB33EB0")]
		[DebuggerHidden]
		public <plotT0>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0xB345B0", Offset = "0xB345B0", VA = "0xB345B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B2")]
		[Address(RVA = "0xB345B4", Offset = "0xB345B4", VA = "0xB345B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0xB347D0", Offset = "0xB347D0", VA = "0xB347D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CD")]
	[CompilerGenerated]
	private sealed class <plotT1>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x170000F9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005B9")]
			[Address(RVA = "0xB34C9C", Offset = "0xB34C9C", VA = "0xB34C9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005BB")]
			[Address(RVA = "0xB34CE4", Offset = "0xB34CE4", VA = "0xB34CE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0xB33F4C", Offset = "0xB33F4C", VA = "0xB33F4C")]
		[DebuggerHidden]
		public <plotT1>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0xB34818", Offset = "0xB34818", VA = "0xB34818", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0xB3481C", Offset = "0xB3481C", VA = "0xB3481C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0xB34CA4", Offset = "0xB34CA4", VA = "0xB34CA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CE")]
	[CompilerGenerated]
	private sealed class <plotStart>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x170000FB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0xB34DFC", Offset = "0xB34DFC", VA = "0xB34DFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005C1")]
			[Address(RVA = "0xB34E44", Offset = "0xB34E44", VA = "0xB34E44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0xB33FE8", Offset = "0xB33FE8", VA = "0xB33FE8")]
		[DebuggerHidden]
		public <plotStart>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0xB34CEC", Offset = "0xB34CEC", VA = "0xB34CEC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0xB34CF0", Offset = "0xB34CF0", VA = "0xB34CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0xB34E04", Offset = "0xB34E04", VA = "0xB34E04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000CF")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x170000FD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005C5")]
			[Address(RVA = "0xB350E4", Offset = "0xB350E4", VA = "0xB350E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000FE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0xB3512C", Offset = "0xB3512C", VA = "0xB3512C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0xB340C0", Offset = "0xB340C0", VA = "0xB340C0")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0xB34E4C", Offset = "0xB34E4C", VA = "0xB34E4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0xB34E50", Offset = "0xB34E50", VA = "0xB34E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0xB350EC", Offset = "0xB350EC", VA = "0xB350EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D0")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x170000FF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005CB")]
			[Address(RVA = "0xB3552C", Offset = "0xB3552C", VA = "0xB3552C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000100")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005CD")]
			[Address(RVA = "0xB35574", Offset = "0xB35574", VA = "0xB35574", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005C8")]
		[Address(RVA = "0xB3415C", Offset = "0xB3415C", VA = "0xB3415C")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60005C9")]
		[Address(RVA = "0xB35134", Offset = "0xB35134", VA = "0xB35134", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005CA")]
		[Address(RVA = "0xB35138", Offset = "0xB35138", VA = "0xB35138", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005CC")]
		[Address(RVA = "0xB35534", Offset = "0xB35534", VA = "0xB35534", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D1")]
	[CompilerGenerated]
	private sealed class <plotTrigger21_1>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x17000101")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0xB35A2C", Offset = "0xB35A2C", VA = "0xB35A2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000102")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0xB35A74", Offset = "0xB35A74", VA = "0xB35A74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005CE")]
		[Address(RVA = "0xB3557C", Offset = "0xB3557C", VA = "0xB3557C")]
		[DebuggerHidden]
		public <plotTrigger21_1>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60005CF")]
		[Address(RVA = "0xB355A4", Offset = "0xB355A4", VA = "0xB355A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D0")]
		[Address(RVA = "0xB355A8", Offset = "0xB355A8", VA = "0xB355A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D2")]
		[Address(RVA = "0xB35A34", Offset = "0xB35A34", VA = "0xB35A34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D2")]
	[CompilerGenerated]
	private sealed class <plotTrigger12>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x17000103")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005D7")]
			[Address(RVA = "0xB35BF8", Offset = "0xB35BF8", VA = "0xB35BF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000104")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005D9")]
			[Address(RVA = "0xB35C40", Offset = "0xB35C40", VA = "0xB35C40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005D4")]
		[Address(RVA = "0xB35A7C", Offset = "0xB35A7C", VA = "0xB35A7C")]
		[DebuggerHidden]
		public <plotTrigger12>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60005D5")]
		[Address(RVA = "0xB35AA4", Offset = "0xB35AA4", VA = "0xB35AA4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005D6")]
		[Address(RVA = "0xB35AA8", Offset = "0xB35AA8", VA = "0xB35AA8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005D8")]
		[Address(RVA = "0xB35C00", Offset = "0xB35C00", VA = "0xB35C00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D3")]
	[CompilerGenerated]
	private sealed class <win>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000541")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene5Manager <>4__this;

		[Token(Token = "0x17000105")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0xB366D8", Offset = "0xB366D8", VA = "0xB366D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000106")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0xB36720", Offset = "0xB36720", VA = "0xB36720", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0xB35C48", Offset = "0xB35C48", VA = "0xB35C48")]
		[DebuggerHidden]
		public <win>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0xB35C70", Offset = "0xB35C70", VA = "0xB35C70", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0xB35C74", Offset = "0xB35C74", VA = "0xB35C74", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0xB366E0", Offset = "0xB366E0", VA = "0xB366E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400051A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Header("[配置项")]
	public AudioCueSO Level5CueSO;

	[Token(Token = "0x400051B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x400051C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform Door1;

	[Token(Token = "0x400051D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform Door2;

	[Token(Token = "0x400051E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[Header("NPC")]
	private Transform NpcJc1;

	[Token(Token = "0x400051F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Transform NpcJc2;

	[Token(Token = "0x4000520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x4000521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[Header("Teleport")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_1;

	[Token(Token = "0x4000522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_2;

	[Token(Token = "0x4000523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private GameObject PlaneObj;

	[Token(Token = "0x4000524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int trigger;

	[Token(Token = "0x4000525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private bool BossDie;

	[Token(Token = "0x6000599")]
	[Address(RVA = "0xB33A18", Offset = "0xB33A18", VA = "0xB33A18")]
	private new void Start()
	{
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0xB33BF0", Offset = "0xB33BF0", VA = "0xB33BF0")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x600059B")]
	[Address(RVA = "0xB33D98", Offset = "0xB33D98", VA = "0xB33D98")]
	private new void Update()
	{
	}

	[Token(Token = "0x600059C")]
	[Address(RVA = "0xB33BD0", Offset = "0xB33BD0", VA = "0xB33BD0")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0xB33DA0", Offset = "0xB33DA0", VA = "0xB33DA0")]
	[IteratorStateMachine(typeof(<plots>d__16))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0xB33E3C", Offset = "0xB33E3C", VA = "0xB33E3C")]
	[IteratorStateMachine(typeof(<plotT0>d__17))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x600059F")]
	[Address(RVA = "0xB33ED8", Offset = "0xB33ED8", VA = "0xB33ED8")]
	[IteratorStateMachine(typeof(<plotT1>d__18))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x60005A0")]
	[Address(RVA = "0xB33F74", Offset = "0xB33F74", VA = "0xB33F74")]
	[IteratorStateMachine(typeof(<plotStart>d__19))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x60005A1")]
	[Address(RVA = "0xB34010", Offset = "0xB34010", VA = "0xB34010")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x60005A2")]
	[Address(RVA = "0xB34030", Offset = "0xB34030", VA = "0xB34030")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__21))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x60005A3")]
	[Address(RVA = "0xB340E8", Offset = "0xB340E8", VA = "0xB340E8")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__22))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x60005A4")]
	[Address(RVA = "0xB34184", Offset = "0xB34184", VA = "0xB34184")]
	[IteratorStateMachine(typeof(<plotTrigger21_1>d__23))]
	private IEnumerator plotTrigger21_1()
	{
		return null;
	}

	[Token(Token = "0x60005A5")]
	[Address(RVA = "0xB341F8", Offset = "0xB341F8", VA = "0xB341F8")]
	[IteratorStateMachine(typeof(<plotTrigger12>d__24))]
	private IEnumerator plotTrigger12()
	{
		return null;
	}

	[Token(Token = "0x60005A6")]
	[Address(RVA = "0xB3426C", Offset = "0xB3426C", VA = "0xB3426C")]
	[IteratorStateMachine(typeof(<win>d__25))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x60005A7")]
	[Address(RVA = "0xB342E0", Offset = "0xB342E0", VA = "0xB342E0")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x60005A8")]
	[Address(RVA = "0xB343C8", Offset = "0xB343C8", VA = "0xB343C8")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0xB34408", Offset = "0xB34408", VA = "0xB34408")]
	public Scene5Manager()
	{
	}
}
[Token(Token = "0x20000D4")]
public class Scene6Manager : SceneBaseManager
{
	[Token(Token = "0x20000D5")]
	[CompilerGenerated]
	private sealed class <plots>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000553")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000554")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000555")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x17000107")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0xB3791C", Offset = "0xB3791C", VA = "0xB3791C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000108")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0xB37964", Offset = "0xB37964", VA = "0xB37964", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0xB37174", Offset = "0xB37174", VA = "0xB37174")]
		[DebuggerHidden]
		public <plots>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0xB3781C", Offset = "0xB3781C", VA = "0xB3781C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F2")]
		[Address(RVA = "0xB37820", Offset = "0xB37820", VA = "0xB37820", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005F4")]
		[Address(RVA = "0xB37924", Offset = "0xB37924", VA = "0xB37924", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D6")]
	[CompilerGenerated]
	private sealed class <plotT0>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000556")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000557")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000558")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x17000109")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0xB37BF4", Offset = "0xB37BF4", VA = "0xB37BF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0xB37C3C", Offset = "0xB37C3C", VA = "0xB37C3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0xB37210", Offset = "0xB37210", VA = "0xB37210")]
		[DebuggerHidden]
		public <plotT0>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0xB3796C", Offset = "0xB3796C", VA = "0xB3796C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0xB37970", Offset = "0xB37970", VA = "0xB37970", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0xB37BFC", Offset = "0xB37BFC", VA = "0xB37BFC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D7")]
	[CompilerGenerated]
	private sealed class <plotT1>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000559")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400055B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x1700010B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60005FF")]
			[Address(RVA = "0xB380C8", Offset = "0xB380C8", VA = "0xB380C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000601")]
			[Address(RVA = "0xB38110", Offset = "0xB38110", VA = "0xB38110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0xB372AC", Offset = "0xB372AC", VA = "0xB372AC")]
		[DebuggerHidden]
		public <plotT1>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0xB37C44", Offset = "0xB37C44", VA = "0xB37C44", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0xB37C48", Offset = "0xB37C48", VA = "0xB37C48", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0xB380D0", Offset = "0xB380D0", VA = "0xB380D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D8")]
	[CompilerGenerated]
	private sealed class <plotStart>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400055D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400055E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x1700010D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000605")]
			[Address(RVA = "0xB382F4", Offset = "0xB382F4", VA = "0xB382F4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0xB3833C", Offset = "0xB3833C", VA = "0xB3833C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0xB37348", Offset = "0xB37348", VA = "0xB37348")]
		[DebuggerHidden]
		public <plotStart>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0xB38118", Offset = "0xB38118", VA = "0xB38118", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0xB3811C", Offset = "0xB3811C", VA = "0xB3811C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000606")]
		[Address(RVA = "0xB382FC", Offset = "0xB382FC", VA = "0xB382FC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000D9")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400055F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000560")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000561")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x4000562")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x1700010F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600060B")]
			[Address(RVA = "0xB38BA0", Offset = "0xB38BA0", VA = "0xB38BA0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000110")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600060D")]
			[Address(RVA = "0xB38BE8", Offset = "0xB38BE8", VA = "0xB38BE8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000608")]
		[Address(RVA = "0xB37420", Offset = "0xB37420", VA = "0xB37420")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0xB38344", Offset = "0xB38344", VA = "0xB38344", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0xB38348", Offset = "0xB38348", VA = "0xB38348", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0xB38BA8", Offset = "0xB38BA8", VA = "0xB38BA8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DA")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000563")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000564")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000565")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x17000111")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000611")]
			[Address(RVA = "0xB39018", Offset = "0xB39018", VA = "0xB39018", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000613")]
			[Address(RVA = "0xB39060", Offset = "0xB39060", VA = "0xB39060", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0xB374BC", Offset = "0xB374BC", VA = "0xB374BC")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__27(int <>1__state)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0xB38BF0", Offset = "0xB38BF0", VA = "0xB38BF0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0xB38BF4", Offset = "0xB38BF4", VA = "0xB38BF4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0xB39020", Offset = "0xB39020", VA = "0xB39020", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DB")]
	[CompilerGenerated]
	private sealed class <plotTrigger21_1>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000566")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000567")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000568")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x17000113")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000617")]
			[Address(RVA = "0xB394B4", Offset = "0xB394B4", VA = "0xB394B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000114")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000619")]
			[Address(RVA = "0xB394FC", Offset = "0xB394FC", VA = "0xB394FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0xB37558", Offset = "0xB37558", VA = "0xB37558")]
		[DebuggerHidden]
		public <plotTrigger21_1>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0xB39068", Offset = "0xB39068", VA = "0xB39068", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0xB3906C", Offset = "0xB3906C", VA = "0xB3906C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0xB394BC", Offset = "0xB394BC", VA = "0xB394BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DC")]
	[CompilerGenerated]
	private sealed class <win>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000569")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400056A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400056B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene6Manager <>4__this;

		[Token(Token = "0x17000115")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600061D")]
			[Address(RVA = "0xB39A88", Offset = "0xB39A88", VA = "0xB39A88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000116")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600061F")]
			[Address(RVA = "0xB39AD0", Offset = "0xB39AD0", VA = "0xB39AD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600061A")]
		[Address(RVA = "0xB375F4", Offset = "0xB375F4", VA = "0xB375F4")]
		[DebuggerHidden]
		public <win>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xB39504", Offset = "0xB39504", VA = "0xB39504", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xB39508", Offset = "0xB39508", VA = "0xB39508", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xB39A90", Offset = "0xB39A90", VA = "0xB39A90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000542")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Header("[配置项")]
	public AudioCueSO Level6CueSO;

	[Token(Token = "0x4000543")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x4000544")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform Door1;

	[Token(Token = "0x4000545")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform Door2;

	[Token(Token = "0x4000546")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform Door3;

	[Token(Token = "0x4000547")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public GameObject River;

	[Token(Token = "0x4000548")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public GameObject Ceng3;

	[Token(Token = "0x4000549")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject CloundPlane1;

	[Token(Token = "0x400054A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public GameObject CloundPlane2;

	[Token(Token = "0x400054B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public GameObject Clound;

	[Token(Token = "0x400054C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[Header("NPC")]
	private Transform NpcJc1;

	[Token(Token = "0x400054D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Transform NpcJc2;

	[Token(Token = "0x400054E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x400054F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[SerializeField]
	[Header("Teleport")]
	private GameObject[] ArriveTeleportAreas_1;

	[Token(Token = "0x4000550")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	[SerializeField]
	private GameObject[] ArriveTeleportAreas_2;

	[Token(Token = "0x4000551")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private int trigger;

	[Token(Token = "0x4000552")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15C")]
	private bool BossDie;

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0xB36728", Offset = "0xB36728", VA = "0xB36728")]
	private new void Start()
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0xB36D0C", Offset = "0xB36D0C", VA = "0xB36D0C")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0xB370F8", Offset = "0xB370F8", VA = "0xB370F8")]
	private new void Update()
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0xB36CEC", Offset = "0xB36CEC", VA = "0xB36CEC")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0xB37100", Offset = "0xB37100", VA = "0xB37100")]
	[IteratorStateMachine(typeof(<plots>d__21))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0xB3719C", Offset = "0xB3719C", VA = "0xB3719C")]
	[IteratorStateMachine(typeof(<plotT0>d__22))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0xB37238", Offset = "0xB37238", VA = "0xB37238")]
	[IteratorStateMachine(typeof(<plotT1>d__23))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0xB372D4", Offset = "0xB372D4", VA = "0xB372D4")]
	[IteratorStateMachine(typeof(<plotStart>d__24))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0xB37370", Offset = "0xB37370", VA = "0xB37370")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0xB37390", Offset = "0xB37390", VA = "0xB37390")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__26))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0xB37448", Offset = "0xB37448", VA = "0xB37448")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__27))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0xB374E4", Offset = "0xB374E4", VA = "0xB374E4")]
	[IteratorStateMachine(typeof(<plotTrigger21_1>d__28))]
	private IEnumerator plotTrigger21_1()
	{
		return null;
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0xB37580", Offset = "0xB37580", VA = "0xB37580")]
	[IteratorStateMachine(typeof(<win>d__29))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0xB3761C", Offset = "0xB3761C", VA = "0xB3761C")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0xB3776C", Offset = "0xB3776C", VA = "0xB3776C")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0xB377AC", Offset = "0xB377AC", VA = "0xB377AC")]
	public Scene6Manager()
	{
	}
}
[Token(Token = "0x20000DD")]
public class Scene7Manager : SceneBaseManager
{
	[Token(Token = "0x20000DE")]
	[CompilerGenerated]
	private sealed class <plots>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000576")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000577")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000578")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000117")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000634")]
			[Address(RVA = "0xB3A680", Offset = "0xB3A680", VA = "0xB3A680", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000118")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000636")]
			[Address(RVA = "0xB3A6C8", Offset = "0xB3A6C8", VA = "0xB3A6C8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0xB39EC8", Offset = "0xB39EC8", VA = "0xB39EC8")]
		[DebuggerHidden]
		public <plots>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0xB3A580", Offset = "0xB3A580", VA = "0xB3A580", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0xB3A584", Offset = "0xB3A584", VA = "0xB3A584", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0xB3A688", Offset = "0xB3A688", VA = "0xB3A688", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000DF")]
	[CompilerGenerated]
	private sealed class <plotT0>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000579")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000119")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600063A")]
			[Address(RVA = "0xB3A920", Offset = "0xB3A920", VA = "0xB3A920", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600063C")]
			[Address(RVA = "0xB3A968", Offset = "0xB3A968", VA = "0xB3A968", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0xB39F64", Offset = "0xB39F64", VA = "0xB39F64")]
		[DebuggerHidden]
		public <plotT0>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0xB3A6D0", Offset = "0xB3A6D0", VA = "0xB3A6D0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0xB3A6D4", Offset = "0xB3A6D4", VA = "0xB3A6D4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0xB3A928", Offset = "0xB3A928", VA = "0xB3A928", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E0")]
	[CompilerGenerated]
	private sealed class <plotT1>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400057D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400057E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x1700011B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000640")]
			[Address(RVA = "0xB3ADAC", Offset = "0xB3ADAC", VA = "0xB3ADAC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000642")]
			[Address(RVA = "0xB3ADF4", Offset = "0xB3ADF4", VA = "0xB3ADF4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0xB3A000", Offset = "0xB3A000", VA = "0xB3A000")]
		[DebuggerHidden]
		public <plotT1>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0xB3A970", Offset = "0xB3A970", VA = "0xB3A970", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0xB3A974", Offset = "0xB3A974", VA = "0xB3A974", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0xB3ADB4", Offset = "0xB3ADB4", VA = "0xB3ADB4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E1")]
	[CompilerGenerated]
	private sealed class <plotStart>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400057F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000580")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000581")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x1700011D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000646")]
			[Address(RVA = "0xB3AF08", Offset = "0xB3AF08", VA = "0xB3AF08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700011E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000648")]
			[Address(RVA = "0xB3AF50", Offset = "0xB3AF50", VA = "0xB3AF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0xB3A09C", Offset = "0xB3A09C", VA = "0xB3A09C")]
		[DebuggerHidden]
		public <plotStart>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0xB3ADFC", Offset = "0xB3ADFC", VA = "0xB3ADFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0xB3AE00", Offset = "0xB3AE00", VA = "0xB3AE00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0xB3AF10", Offset = "0xB3AF10", VA = "0xB3AF10", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E2")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000582")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000583")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000584")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x4000585")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x1700011F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600064C")]
			[Address(RVA = "0xB3B0CC", Offset = "0xB3B0CC", VA = "0xB3B0CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000120")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0xB3B114", Offset = "0xB3B114", VA = "0xB3B114", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0xB3A174", Offset = "0xB3A174", VA = "0xB3A174")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0xB3AF58", Offset = "0xB3AF58", VA = "0xB3AF58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0xB3AF5C", Offset = "0xB3AF5C", VA = "0xB3AF5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0xB3B0D4", Offset = "0xB3B0D4", VA = "0xB3B0D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E3")]
	[CompilerGenerated]
	private sealed class <plotTrigger11_1>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000586")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000587")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000588")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000121")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000652")]
			[Address(RVA = "0xB3B560", Offset = "0xB3B560", VA = "0xB3B560", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xB3B5A8", Offset = "0xB3B5A8", VA = "0xB3B5A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600064F")]
		[Address(RVA = "0xB3A210", Offset = "0xB3A210", VA = "0xB3A210")]
		[DebuggerHidden]
		public <plotTrigger11_1>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0xB3B11C", Offset = "0xB3B11C", VA = "0xB3B11C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xB3B120", Offset = "0xB3B120", VA = "0xB3B120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xB3B568", Offset = "0xB3B568", VA = "0xB3B568", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E4")]
	[CompilerGenerated]
	private sealed class <plotTrigger16s>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000589")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400058B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000123")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000658")]
			[Address(RVA = "0xB3B630", Offset = "0xB3B630", VA = "0xB3B630", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600065A")]
			[Address(RVA = "0xB3B678", Offset = "0xB3B678", VA = "0xB3B678", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xB3A2AC", Offset = "0xB3A2AC", VA = "0xB3A2AC")]
		[DebuggerHidden]
		public <plotTrigger16s>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0xB3B5B0", Offset = "0xB3B5B0", VA = "0xB3B5B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000657")]
		[Address(RVA = "0xB3B5B4", Offset = "0xB3B5B4", VA = "0xB3B5B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000659")]
		[Address(RVA = "0xB3B638", Offset = "0xB3B638", VA = "0xB3B638", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E5")]
	[CompilerGenerated]
	private sealed class <plotTrigger16_1>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400058D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400058E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000125")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600065E")]
			[Address(RVA = "0xB3B8E4", Offset = "0xB3B8E4", VA = "0xB3B8E4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0xB3B92C", Offset = "0xB3B92C", VA = "0xB3B92C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600065B")]
		[Address(RVA = "0xB3A348", Offset = "0xB3A348", VA = "0xB3A348")]
		[DebuggerHidden]
		public <plotTrigger16_1>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0xB3B680", Offset = "0xB3B680", VA = "0xB3B680", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600065D")]
		[Address(RVA = "0xB3B684", Offset = "0xB3B684", VA = "0xB3B684", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0xB3B8EC", Offset = "0xB3B8EC", VA = "0xB3B8EC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E6")]
	[CompilerGenerated]
	private sealed class <win>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400058F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000590")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000591")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene7Manager <>4__this;

		[Token(Token = "0x17000127")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0xB3C088", Offset = "0xB3C088", VA = "0xB3C088", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000666")]
			[Address(RVA = "0xB3C0D0", Offset = "0xB3C0D0", VA = "0xB3C0D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0xB3A3E4", Offset = "0xB3A3E4", VA = "0xB3A3E4")]
		[DebuggerHidden]
		public <win>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0xB3B934", Offset = "0xB3B934", VA = "0xB3B934", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0xB3B938", Offset = "0xB3B938", VA = "0xB3B938", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0xB3C090", Offset = "0xB3C090", VA = "0xB3C090", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400056C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[Header("[配置项")]
	[SerializeField]
	public AudioCueSO Level7CueSO;

	[Token(Token = "0x400056D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x400056E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform Door1;

	[Token(Token = "0x400056F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform Door1Cube;

	[Token(Token = "0x4000570")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	[Header("NPC")]
	private Transform NpcJc1;

	[Token(Token = "0x4000571")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Transform NpcJc2;

	[Token(Token = "0x4000572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x4000573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	[SerializeField]
	[Header("Teleport")]
	private GameObject[] ArriveTeleportAreas_1;

	[Token(Token = "0x4000574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private int trigger;

	[Token(Token = "0x4000575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private bool BossDie;

	[Token(Token = "0x6000620")]
	[Address(RVA = "0xB39AD8", Offset = "0xB39AD8", VA = "0xB39AD8")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0xB39CAC", Offset = "0xB39CAC", VA = "0xB39CAC")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0xB39E50", Offset = "0xB39E50", VA = "0xB39E50")]
	private new void Update()
	{
	}

	[Token(Token = "0x6000623")]
	[Address(RVA = "0xB39C8C", Offset = "0xB39C8C", VA = "0xB39C8C")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x6000624")]
	[Address(RVA = "0xB39E54", Offset = "0xB39E54", VA = "0xB39E54")]
	[IteratorStateMachine(typeof(<plots>d__14))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x6000625")]
	[Address(RVA = "0xB39EF0", Offset = "0xB39EF0", VA = "0xB39EF0")]
	[IteratorStateMachine(typeof(<plotT0>d__15))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x6000626")]
	[Address(RVA = "0xB39F8C", Offset = "0xB39F8C", VA = "0xB39F8C")]
	[IteratorStateMachine(typeof(<plotT1>d__16))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x6000627")]
	[Address(RVA = "0xB3A028", Offset = "0xB3A028", VA = "0xB3A028")]
	[IteratorStateMachine(typeof(<plotStart>d__17))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x6000628")]
	[Address(RVA = "0xB3A0C4", Offset = "0xB3A0C4", VA = "0xB3A0C4")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x6000629")]
	[Address(RVA = "0xB3A0E4", Offset = "0xB3A0E4", VA = "0xB3A0E4")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__19))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x600062A")]
	[Address(RVA = "0xB3A19C", Offset = "0xB3A19C", VA = "0xB3A19C")]
	[IteratorStateMachine(typeof(<plotTrigger11_1>d__20))]
	private IEnumerator plotTrigger11_1()
	{
		return null;
	}

	[Token(Token = "0x600062B")]
	[Address(RVA = "0xB3A238", Offset = "0xB3A238", VA = "0xB3A238")]
	[IteratorStateMachine(typeof(<plotTrigger16s>d__21))]
	private IEnumerator plotTrigger16s()
	{
		return null;
	}

	[Token(Token = "0x600062C")]
	[Address(RVA = "0xB3A2D4", Offset = "0xB3A2D4", VA = "0xB3A2D4")]
	[IteratorStateMachine(typeof(<plotTrigger16_1>d__22))]
	private IEnumerator plotTrigger16_1()
	{
		return null;
	}

	[Token(Token = "0x600062D")]
	[Address(RVA = "0xB3A370", Offset = "0xB3A370", VA = "0xB3A370")]
	[IteratorStateMachine(typeof(<win>d__23))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x600062E")]
	[Address(RVA = "0xB3A40C", Offset = "0xB3A40C", VA = "0xB3A40C")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x600062F")]
	[Address(RVA = "0xB3A4E0", Offset = "0xB3A4E0", VA = "0xB3A4E0")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x6000630")]
	[Address(RVA = "0xB3A520", Offset = "0xB3A520", VA = "0xB3A520")]
	public Scene7Manager()
	{
	}
}
[Token(Token = "0x20000E7")]
public class Scene8Manager : SceneBaseManager
{
	[Token(Token = "0x20000E8")]
	[CompilerGenerated]
	private sealed class <plots>d__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000129")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000681")]
			[Address(RVA = "0xB3D090", Offset = "0xB3D090", VA = "0xB3D090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000683")]
			[Address(RVA = "0xB3D0D8", Offset = "0xB3D0D8", VA = "0xB3D0D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0xB3C4C8", Offset = "0xB3C4C8", VA = "0xB3C4C8")]
		[DebuggerHidden]
		public <plots>d__16(int <>1__state)
		{
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0xB3CF90", Offset = "0xB3CF90", VA = "0xB3CF90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0xB3CF94", Offset = "0xB3CF94", VA = "0xB3CF94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0xB3D098", Offset = "0xB3D098", VA = "0xB3D098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000E9")]
	[CompilerGenerated]
	private sealed class <plotT0>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x1700012B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000687")]
			[Address(RVA = "0xB3D2F8", Offset = "0xB3D2F8", VA = "0xB3D2F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000689")]
			[Address(RVA = "0xB3D340", Offset = "0xB3D340", VA = "0xB3D340", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000684")]
		[Address(RVA = "0xB3C564", Offset = "0xB3C564", VA = "0xB3C564")]
		[DebuggerHidden]
		public <plotT0>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0xB3D0E0", Offset = "0xB3D0E0", VA = "0xB3D0E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0xB3D0E4", Offset = "0xB3D0E4", VA = "0xB3D0E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0xB3D300", Offset = "0xB3D300", VA = "0xB3D300", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EA")]
	[CompilerGenerated]
	private sealed class <plotT1>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x1700012D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600068D")]
			[Address(RVA = "0xB3D86C", Offset = "0xB3D86C", VA = "0xB3D86C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0xB3D8B4", Offset = "0xB3D8B4", VA = "0xB3D8B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0xB3C600", Offset = "0xB3C600", VA = "0xB3C600")]
		[DebuggerHidden]
		public <plotT1>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0xB3D348", Offset = "0xB3D348", VA = "0xB3D348", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0xB3D34C", Offset = "0xB3D34C", VA = "0xB3D34C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0xB3D874", Offset = "0xB3D874", VA = "0xB3D874", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EB")]
	[CompilerGenerated]
	private sealed class <plotStart>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x1700012F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000693")]
			[Address(RVA = "0xB3DA24", Offset = "0xB3DA24", VA = "0xB3DA24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000130")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000695")]
			[Address(RVA = "0xB3DA6C", Offset = "0xB3DA6C", VA = "0xB3DA6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000690")]
		[Address(RVA = "0xB3C69C", Offset = "0xB3C69C", VA = "0xB3C69C")]
		[DebuggerHidden]
		public <plotStart>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0xB3D8BC", Offset = "0xB3D8BC", VA = "0xB3D8BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0xB3D8C0", Offset = "0xB3D8C0", VA = "0xB3D8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0xB3DA2C", Offset = "0xB3DA2C", VA = "0xB3DA2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EC")]
	[CompilerGenerated]
	private sealed class <plotByTriggerEnumerator>d__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyTriggerSO so;

		[Token(Token = "0x17000131")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000699")]
			[Address(RVA = "0xB3E328", Offset = "0xB3E328", VA = "0xB3E328", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000132")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600069B")]
			[Address(RVA = "0xB3E370", Offset = "0xB3E370", VA = "0xB3E370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0xB3C774", Offset = "0xB3C774", VA = "0xB3C774")]
		[DebuggerHidden]
		public <plotByTriggerEnumerator>d__21(int <>1__state)
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0xB3DA74", Offset = "0xB3DA74", VA = "0xB3DA74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0xB3DA78", Offset = "0xB3DA78", VA = "0xB3DA78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0xB3E330", Offset = "0xB3E330", VA = "0xB3E330", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000ED")]
	[CompilerGenerated]
	private sealed class <plotTrigger6>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000133")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0xB3E414", Offset = "0xB3E414", VA = "0xB3E414", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000134")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0xB3E45C", Offset = "0xB3E45C", VA = "0xB3E45C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600069C")]
		[Address(RVA = "0xB3C810", Offset = "0xB3C810", VA = "0xB3C810")]
		[DebuggerHidden]
		public <plotTrigger6>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0xB3E378", Offset = "0xB3E378", VA = "0xB3E378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0xB3E37C", Offset = "0xB3E37C", VA = "0xB3E37C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0xB3E41C", Offset = "0xB3E41C", VA = "0xB3E41C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EE")]
	[CompilerGenerated]
	private sealed class <plotTrigger13>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000135")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0xB3E584", Offset = "0xB3E584", VA = "0xB3E584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000136")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006A7")]
			[Address(RVA = "0xB3E5CC", Offset = "0xB3E5CC", VA = "0xB3E5CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0xB3C8AC", Offset = "0xB3C8AC", VA = "0xB3C8AC")]
		[DebuggerHidden]
		public <plotTrigger13>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0xB3E464", Offset = "0xB3E464", VA = "0xB3E464", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0xB3E468", Offset = "0xB3E468", VA = "0xB3E468", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0xB3E58C", Offset = "0xB3E58C", VA = "0xB3E58C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000EF")]
	[CompilerGenerated]
	private sealed class <plotTrigger14>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000137")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006AB")]
			[Address(RVA = "0xB3E65C", Offset = "0xB3E65C", VA = "0xB3E65C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0xB3E6A4", Offset = "0xB3E6A4", VA = "0xB3E6A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0xB3C948", Offset = "0xB3C948", VA = "0xB3C948")]
		[DebuggerHidden]
		public <plotTrigger14>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0xB3E5D4", Offset = "0xB3E5D4", VA = "0xB3E5D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0xB3E5D8", Offset = "0xB3E5D8", VA = "0xB3E5D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0xB3E664", Offset = "0xB3E664", VA = "0xB3E664", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F0")]
	[CompilerGenerated]
	private sealed class <win>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000139")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B1")]
			[Address(RVA = "0xB3EBA8", Offset = "0xB3EBA8", VA = "0xB3EBA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B3")]
			[Address(RVA = "0xB3EBF0", Offset = "0xB3EBF0", VA = "0xB3EBF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006AE")]
		[Address(RVA = "0xB3C9E4", Offset = "0xB3C9E4", VA = "0xB3C9E4")]
		[DebuggerHidden]
		public <win>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x60006AF")]
		[Address(RVA = "0xB3E6AC", Offset = "0xB3E6AC", VA = "0xB3E6AC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B0")]
		[Address(RVA = "0xB3E6B0", Offset = "0xB3E6B0", VA = "0xB3E6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B2")]
		[Address(RVA = "0xB3EBB0", Offset = "0xB3EBB0", VA = "0xB3EBB0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F1")]
	[CompilerGenerated]
	private sealed class <BigDoorMove>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x40005BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float y;

		[Token(Token = "0x1700013B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0xB3EE34", Offset = "0xB3EE34", VA = "0xB3EE34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0xB3EE7C", Offset = "0xB3EE7C", VA = "0xB3EE7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006B4")]
		[Address(RVA = "0xB3CBC4", Offset = "0xB3CBC4", VA = "0xB3CBC4")]
		[DebuggerHidden]
		public <BigDoorMove>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x60006B5")]
		[Address(RVA = "0xB3EBF8", Offset = "0xB3EBF8", VA = "0xB3EBF8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006B6")]
		[Address(RVA = "0xB3EBFC", Offset = "0xB3EBFC", VA = "0xB3EBFC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006B8")]
		[Address(RVA = "0xB3EE3C", Offset = "0xB3EE3C", VA = "0xB3EE3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F2")]
	[CompilerGenerated]
	private sealed class <DoorLMove>d__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x40005C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x1700013D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006BD")]
			[Address(RVA = "0xB3F06C", Offset = "0xB3F06C", VA = "0xB3F06C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006BF")]
			[Address(RVA = "0xB3F0B4", Offset = "0xB3F0B4", VA = "0xB3F0B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006BA")]
		[Address(RVA = "0xB3CC70", Offset = "0xB3CC70", VA = "0xB3CC70")]
		[DebuggerHidden]
		public <DoorLMove>d__29(int <>1__state)
		{
		}

		[Token(Token = "0x60006BB")]
		[Address(RVA = "0xB3EE84", Offset = "0xB3EE84", VA = "0xB3EE84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006BC")]
		[Address(RVA = "0xB3EE88", Offset = "0xB3EE88", VA = "0xB3EE88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006BE")]
		[Address(RVA = "0xB3F074", Offset = "0xB3F074", VA = "0xB3F074", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F3")]
	[CompilerGenerated]
	private sealed class <DoorRMove>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float x;

		[Token(Token = "0x1700013F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0xB3F2A4", Offset = "0xB3F2A4", VA = "0xB3F2A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000140")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006C5")]
			[Address(RVA = "0xB3F2EC", Offset = "0xB3F2EC", VA = "0xB3F2EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C0")]
		[Address(RVA = "0xB3CD1C", Offset = "0xB3CD1C", VA = "0xB3CD1C")]
		[DebuggerHidden]
		public <DoorRMove>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x60006C1")]
		[Address(RVA = "0xB3F0BC", Offset = "0xB3F0BC", VA = "0xB3F0BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C2")]
		[Address(RVA = "0xB3F0C0", Offset = "0xB3F0C0", VA = "0xB3F0C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006C4")]
		[Address(RVA = "0xB3F2AC", Offset = "0xB3F2AC", VA = "0xB3F2AC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F4")]
	[CompilerGenerated]
	private sealed class <HeroineTalk>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Scene8Manager <>4__this;

		[Token(Token = "0x17000141")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0xB3F430", Offset = "0xB3F430", VA = "0xB3F430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000142")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0xB3F478", Offset = "0xB3F478", VA = "0xB3F478", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006C6")]
		[Address(RVA = "0xB3CEE8", Offset = "0xB3CEE8", VA = "0xB3CEE8")]
		[DebuggerHidden]
		public <HeroineTalk>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60006C7")]
		[Address(RVA = "0xB3F2F4", Offset = "0xB3F2F4", VA = "0xB3F2F4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006C8")]
		[Address(RVA = "0xB3F2F8", Offset = "0xB3F2F8", VA = "0xB3F2F8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006CA")]
		[Address(RVA = "0xB3F438", Offset = "0xB3F438", VA = "0xB3F438", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000592")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[SerializeField]
	[Header("[配置项")]
	public AudioCueSO Level8CueSO;

	[Token(Token = "0x4000593")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private string DefaultWeapon;

	[Token(Token = "0x4000594")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[Header("门")]
	public Transform DoorL;

	[Token(Token = "0x4000595")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform DoorR;

	[Token(Token = "0x4000596")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Transform BigDoor;

	[Token(Token = "0x4000597")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform W4;

	[Token(Token = "0x4000598")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform ZLDoor2;

	[Token(Token = "0x4000599")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject DLight;

	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	[Header("Event")]
	public BossTriggerEventSO BossEventSO;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private int trigger;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private bool BossDie;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public GameObject PackFX;

	[Token(Token = "0x6000667")]
	[Address(RVA = "0xB3C0D8", Offset = "0xB3C0D8", VA = "0xB3C0D8")]
	private new void Start()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0xB3C2AC", Offset = "0xB3C2AC", VA = "0xB3C2AC")]
	private new void OnDestroy()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0xB3C450", Offset = "0xB3C450", VA = "0xB3C450")]
	private new void Update()
	{
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0xB3C28C", Offset = "0xB3C28C", VA = "0xB3C28C")]
	private void FeatureFilm()
	{
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0xB3C454", Offset = "0xB3C454", VA = "0xB3C454")]
	[IteratorStateMachine(typeof(<plots>d__16))]
	private IEnumerator plots()
	{
		return null;
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0xB3C4F0", Offset = "0xB3C4F0", VA = "0xB3C4F0")]
	[IteratorStateMachine(typeof(<plotT0>d__17))]
	private IEnumerator plotT0()
	{
		return null;
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0xB3C58C", Offset = "0xB3C58C", VA = "0xB3C58C")]
	[IteratorStateMachine(typeof(<plotT1>d__18))]
	private IEnumerator plotT1()
	{
		return null;
	}

	[Token(Token = "0x600066E")]
	[Address(RVA = "0xB3C628", Offset = "0xB3C628", VA = "0xB3C628")]
	[IteratorStateMachine(typeof(<plotStart>d__19))]
	private IEnumerator plotStart()
	{
		return null;
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0xB3C6C4", Offset = "0xB3C6C4", VA = "0xB3C6C4")]
	private void plotByTrigger(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x6000670")]
	[Address(RVA = "0xB3C6E4", Offset = "0xB3C6E4", VA = "0xB3C6E4")]
	[IteratorStateMachine(typeof(<plotByTriggerEnumerator>d__21))]
	private IEnumerator plotByTriggerEnumerator(EnemyTriggerSO so)
	{
		return null;
	}

	[Token(Token = "0x6000671")]
	[Address(RVA = "0xB3C79C", Offset = "0xB3C79C", VA = "0xB3C79C")]
	[IteratorStateMachine(typeof(<plotTrigger6>d__22))]
	private IEnumerator plotTrigger6()
	{
		return null;
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0xB3C838", Offset = "0xB3C838", VA = "0xB3C838")]
	[IteratorStateMachine(typeof(<plotTrigger13>d__23))]
	private IEnumerator plotTrigger13()
	{
		return null;
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0xB3C8D4", Offset = "0xB3C8D4", VA = "0xB3C8D4")]
	[IteratorStateMachine(typeof(<plotTrigger14>d__24))]
	private IEnumerator plotTrigger14()
	{
		return null;
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0xB3C970", Offset = "0xB3C970", VA = "0xB3C970")]
	[IteratorStateMachine(typeof(<win>d__25))]
	private IEnumerator win()
	{
		return null;
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0xB3CA0C", Offset = "0xB3CA0C", VA = "0xB3CA0C")]
	private void heroineTalk2PlayerByTriiger(int trigger)
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0xB3CB00", Offset = "0xB3CB00", VA = "0xB3CB00")]
	private void HandleBoss(BossTriggerSO so)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0xB3CB40", Offset = "0xB3CB40", VA = "0xB3CB40")]
	[IteratorStateMachine(typeof(<BigDoorMove>d__28))]
	private IEnumerator BigDoorMove(float y)
	{
		return null;
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0xB3CBEC", Offset = "0xB3CBEC", VA = "0xB3CBEC")]
	[IteratorStateMachine(typeof(<DoorLMove>d__29))]
	private IEnumerator DoorLMove(float x)
	{
		return null;
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0xB3CC98", Offset = "0xB3CC98", VA = "0xB3CC98")]
	[IteratorStateMachine(typeof(<DoorRMove>d__30))]
	private IEnumerator DoorRMove(float x)
	{
		return null;
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0xB3CD44", Offset = "0xB3CD44", VA = "0xB3CD44", Slot = "4")]
	public override void AddPack()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0xB3CE74", Offset = "0xB3CE74", VA = "0xB3CE74")]
	[IteratorStateMachine(typeof(<HeroineTalk>d__32))]
	private IEnumerator HeroineTalk()
	{
		return null;
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0xB3CF10", Offset = "0xB3CF10", VA = "0xB3CF10")]
	private void HidePackFX()
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0xB3CF30", Offset = "0xB3CF30", VA = "0xB3CF30")]
	public Scene8Manager()
	{
	}
}
[Token(Token = "0x20000F5")]
public class SceneBaseManager : MonoBehaviour
{
	[Token(Token = "0x20000F6")]
	[CompilerGenerated]
	private sealed class <HeroineMove>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x40005E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int trigger;

		[Token(Token = "0x40005E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <i>5__2;

		[Token(Token = "0x17000143")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006E8")]
			[Address(RVA = "0xB3FE48", Offset = "0xB3FE48", VA = "0xB3FE48", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006EA")]
			[Address(RVA = "0xB3FE90", Offset = "0xB3FE90", VA = "0xB3FE90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006E5")]
		[Address(RVA = "0xB3F480", Offset = "0xB3F480", VA = "0xB3F480")]
		[DebuggerHidden]
		public <HeroineMove>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60006E6")]
		[Address(RVA = "0xB3FD04", Offset = "0xB3FD04", VA = "0xB3FD04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006E7")]
		[Address(RVA = "0xB3FD08", Offset = "0xB3FD08", VA = "0xB3FD08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006E9")]
		[Address(RVA = "0xB3FE50", Offset = "0xB3FE50", VA = "0xB3FE50", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F7")]
	[CompilerGenerated]
	private sealed class <closeDoorAndPress>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x40005ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshProUGUI doorUI;

		[Token(Token = "0x40005EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float DissOpen;

		[Token(Token = "0x40005EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <diss>5__2;

		[Token(Token = "0x40005F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <press>5__3;

		[Token(Token = "0x17000145")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006EE")]
			[Address(RVA = "0xB40090", Offset = "0xB40090", VA = "0xB40090", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000146")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F0")]
			[Address(RVA = "0xB400D8", Offset = "0xB400D8", VA = "0xB400D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006EB")]
		[Address(RVA = "0xB3F548", Offset = "0xB3F548", VA = "0xB3F548")]
		[DebuggerHidden]
		public <closeDoorAndPress>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60006EC")]
		[Address(RVA = "0xB3FE98", Offset = "0xB3FE98", VA = "0xB3FE98", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006ED")]
		[Address(RVA = "0xB3FE9C", Offset = "0xB3FE9C", VA = "0xB3FE9C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006EF")]
		[Address(RVA = "0xB40098", Offset = "0xB40098", VA = "0xB40098", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F8")]
	[CompilerGenerated]
	private sealed class <closeToTarget>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x40005F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 targetV;

		[Token(Token = "0x40005F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float targetDis;

		[Token(Token = "0x40005F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float <diss>5__2;

		[Token(Token = "0x17000147")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006F4")]
			[Address(RVA = "0xB40210", Offset = "0xB40210", VA = "0xB40210", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000148")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006F6")]
			[Address(RVA = "0xB40258", Offset = "0xB40258", VA = "0xB40258", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F1")]
		[Address(RVA = "0xB3F570", Offset = "0xB3F570", VA = "0xB3F570")]
		[DebuggerHidden]
		public <closeToTarget>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x60006F2")]
		[Address(RVA = "0xB400E0", Offset = "0xB400E0", VA = "0xB400E0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F3")]
		[Address(RVA = "0xB400E4", Offset = "0xB400E4", VA = "0xB400E4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006F5")]
		[Address(RVA = "0xB40218", Offset = "0xB40218", VA = "0xB40218", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000F9")]
	[CompilerGenerated]
	private sealed class <closeToY>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x40005FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float Y;

		[Token(Token = "0x40005FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 <targetV>5__2;

		[Token(Token = "0x17000149")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FA")]
			[Address(RVA = "0xB40328", Offset = "0xB40328", VA = "0xB40328", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0xB40370", Offset = "0xB40370", VA = "0xB40370", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006F7")]
		[Address(RVA = "0xB3F598", Offset = "0xB3F598", VA = "0xB3F598")]
		[DebuggerHidden]
		public <closeToY>d__34(int <>1__state)
		{
		}

		[Token(Token = "0x60006F8")]
		[Address(RVA = "0xB40260", Offset = "0xB40260", VA = "0xB40260", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006F9")]
		[Address(RVA = "0xB40264", Offset = "0xB40264", VA = "0xB40264", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xB40330", Offset = "0xB40330", VA = "0xB40330", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FA")]
	[CompilerGenerated]
	private sealed class <OpenFight>d__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x1700014B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000700")]
			[Address(RVA = "0xB40458", Offset = "0xB40458", VA = "0xB40458", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000702")]
			[Address(RVA = "0xB404A0", Offset = "0xB404A0", VA = "0xB404A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0xB3F674", Offset = "0xB3F674", VA = "0xB3F674")]
		[DebuggerHidden]
		public <OpenFight>d__37(int <>1__state)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xB40378", Offset = "0xB40378", VA = "0xB40378", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0xB4037C", Offset = "0xB4037C", VA = "0xB4037C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xB40460", Offset = "0xB40460", VA = "0xB40460", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private sealed class <showSign>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000600")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000601")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SceneBaseManager <>4__this;

		[Token(Token = "0x1700014D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000706")]
			[Address(RVA = "0xB405D8", Offset = "0xB405D8", VA = "0xB405D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0xB40620", Offset = "0xB40620", VA = "0xB40620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0xB3FCDC", Offset = "0xB3FCDC", VA = "0xB3FCDC")]
		[DebuggerHidden]
		public <showSign>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xB404A8", Offset = "0xB404A8", VA = "0xB404A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0xB404AC", Offset = "0xB404AC", VA = "0xB404AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xB405E0", Offset = "0xB405E0", VA = "0xB405E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("Map")]
	public GameObject Map;

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int Level;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Header("[配置项")]
	public bool isXR;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected GameObject Heroine;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected GameObject Player;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected GameObject PlayerUnder;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected HeroineController heroineController;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected PlayerController playerController;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected XRPlayerController xrPlayerController;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected AudioCue audioCue;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[Header("女主每个trigger的跑位")]
	public Transform[] HeroineTrans;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform HeroineTranFrist;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[Header("Base Event SO")]
	[SerializeField]
	public EnemyTriggerSO enemyTriggerSO;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	public EnemyTriggerEventSO _EnemyEventSO;

	[Token(Token = "0x40005D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	public NpcEventSO _NpcEventSO;

	[Token(Token = "0x40005D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	public ThiefEventSO _thiefEventSO;

	[Token(Token = "0x40005D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x40005DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[Header("无人机")]
	public Transform[] DroneTran;

	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[Header("队长")]
	public GameObject NpcDZObj;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected DZController dZController;

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("Boss")]
	public Transform Boss;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[Header("Pack")]
	public GameObject[] packs;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject Sign;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public int NpcDieNum;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	public int ThiefDieNum;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public int NpcLiveNum;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	public int ThiefLiveNum;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected int language;

	[Token(Token = "0x60006CC")]
	[Address(RVA = "0xB368DC", Offset = "0xB368DC", VA = "0xB368DC")]
	protected void Start()
	{
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0xB370FC", Offset = "0xB370FC", VA = "0xB370FC")]
	protected void Update()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0xB36EB0", Offset = "0xB36EB0", VA = "0xB36EB0")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0xB376E8", Offset = "0xB376E8", VA = "0xB376E8")]
	[IteratorStateMachine(typeof(<HeroineMove>d__31))]
	protected IEnumerator HeroineMove(int trigger)
	{
		return null;
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0xB3F4A8", Offset = "0xB3F4A8", VA = "0xB3F4A8")]
	[IteratorStateMachine(typeof(<closeDoorAndPress>d__32))]
	protected IEnumerator closeDoorAndPress(TextMeshProUGUI doorUI, float DissOpen = 4f)
	{
		return null;
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0xB399EC", Offset = "0xB399EC", VA = "0xB399EC")]
	[IteratorStateMachine(typeof(<closeToTarget>d__33))]
	protected IEnumerator closeToTarget(Vector3 targetV, float targetDis)
	{
		return null;
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0xB35B74", Offset = "0xB35B74", VA = "0xB35B74")]
	[IteratorStateMachine(typeof(<closeToY>d__34))]
	protected IEnumerator closeToY(float Y)
	{
		return null;
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0xB3F5C0", Offset = "0xB3F5C0", VA = "0xB3F5C0")]
	protected bool clickNext()
	{
		return default(bool);
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0xB38224", Offset = "0xB38224", VA = "0xB38224")]
	protected void gameFight()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0xB3F600", Offset = "0xB3F600", VA = "0xB3F600")]
	[IteratorStateMachine(typeof(<OpenFight>d__37))]
	protected IEnumerator OpenFight()
	{
		return null;
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0xB3B6F8", Offset = "0xB3B6F8", VA = "0xB3B6F8")]
	protected void CreateDrone(int num, Vector3 initV)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0xB36664", Offset = "0xB36664", VA = "0xB36664")]
	protected void succeed(int level, int star)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0xB3F69C", Offset = "0xB3F69C", VA = "0xB3F69C")]
	protected void backLevel0()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0xB3F6C0", Offset = "0xB3F6C0", VA = "0xB3F6C0")]
	protected void DoNpcSo(NpcDataSO so)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0xB3F724", Offset = "0xB3F724", VA = "0xB3F724")]
	protected void DoThiefSo(ThiefDataSO so)
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0xB35980", Offset = "0xB35980", VA = "0xB35980")]
	protected void BulletAllDestory()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0xB3F7A0", Offset = "0xB3F7A0", VA = "0xB3F7A0")]
	protected void NpcRunWay(string npc, Vector3 createV, Vector3 targetV, string move)
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0xB389E8", Offset = "0xB389E8", VA = "0xB389E8")]
	protected void ThiefRunWay(string thief, Vector3 createV, Vector3 targetV, string move, string EnemyNum)
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0xB3F988", Offset = "0xB3F988", VA = "0xB3F988")]
	protected GameObject PlaneRunWay(string plane, Vector3 createV, Vector3 targetV, float speed)
	{
		return null;
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0xB3FB3C", Offset = "0xB3FB3C", VA = "0xB3FB3C")]
	private void doPlayerDataSO(PlayerDataSO so)
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0xB3FBB0", Offset = "0xB3FBB0", VA = "0xB3FBB0")]
	private void HideMap()
	{
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0xB3FBD0", Offset = "0xB3FBD0", VA = "0xB3FBD0")]
	public Vector3 PlayerUnderTran()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0xB3FC50", Offset = "0xB3FC50", VA = "0xB3FC50", Slot = "4")]
	public virtual void AddPack()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0xB3FC68", Offset = "0xB3FC68", VA = "0xB3FC68")]
	[IteratorStateMachine(typeof(<showSign>d__51))]
	public IEnumerator showSign()
	{
		return null;
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0xB3780C", Offset = "0xB3780C", VA = "0xB3780C")]
	public SceneBaseManager()
	{
	}
}
[Token(Token = "0x20000FC")]
public class TestManager : MonoBehaviour
{
	[Token(Token = "0x6000709")]
	[Address(RVA = "0xB40628", Offset = "0xB40628", VA = "0xB40628")]
	private void Start()
	{
	}

	[Token(Token = "0x600070A")]
	[Address(RVA = "0xB40678", Offset = "0xB40678", VA = "0xB40678")]
	private void create(Vector3 v)
	{
	}

	[Token(Token = "0x600070B")]
	[Address(RVA = "0xB40878", Offset = "0xB40878", VA = "0xB40878")]
	public TestManager()
	{
	}
}
[Token(Token = "0x20000FD")]
public class BaseNpcController : MonoBehaviour
{
	[Token(Token = "0x4000602")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("基本配置项")]
	protected Transform thisTranForm;

	[Token(Token = "0x4000603")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected GameObject player;

	[Token(Token = "0x4000604")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject PlayerUnder;

	[Token(Token = "0x4000605")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected NavMeshAgent agent;

	[Token(Token = "0x4000606")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Animator ani;

	[Token(Token = "0x4000607")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected LineRenderer lineRenderer;

	[Token(Token = "0x4000608")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected bool isAniGo;

	[Token(Token = "0x4000609")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[Header("HP")]
	protected int Hp;

	[Token(Token = "0x400060A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Header("Player相关")]
	protected int playerHp;

	[Token(Token = "0x400060B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	protected bool isPause;

	[Token(Token = "0x400060C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	protected bool isWin;

	[Token(Token = "0x400060D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x400060E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x400060F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float timerOffMeshLink;

	[Token(Token = "0x4000610")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float timeOffMeshLink;

	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool isJump;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
	private bool isMoveToStartPos;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	protected Vector3 worldDeltaPosition;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected LookAt lookAt;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Vector3 playerV;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public AnimationCurve curve;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 startV;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	private Vector3 endV;

	[Token(Token = "0x600070C")]
	[Address(RVA = "0xB40880", Offset = "0xB40880", VA = "0xB40880")]
	protected void Awake()
	{
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0xB408A4", Offset = "0xB408A4", VA = "0xB408A4")]
	protected void Start()
	{
	}

	[Token(Token = "0x600070E")]
	[Address(RVA = "0xB409A4", Offset = "0xB409A4", VA = "0xB409A4")]
	protected void Init()
	{
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0xB40C5C", Offset = "0xB40C5C", VA = "0xB40C5C")]
	protected void Update()
	{
	}

	[Token(Token = "0x6000710")]
	[Address(RVA = "0xB40CB4", Offset = "0xB40CB4", VA = "0xB40CB4")]
	protected void OnDestroy()
	{
	}

	[Token(Token = "0x6000711")]
	[Address(RVA = "0xB40D9C", Offset = "0xB40D9C", VA = "0xB40D9C")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x6000712")]
	[Address(RVA = "0xB40EF8", Offset = "0xB40EF8", VA = "0xB40EF8")]
	public void gainPlayer(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0xB40F24", Offset = "0xB40F24", VA = "0xB40F24")]
	public void EnableAgent(bool f)
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0xB37B68", Offset = "0xB37B68", VA = "0xB37B68")]
	public void lookAtPlayer()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0xB40FDC", Offset = "0xB40FDC", VA = "0xB40FDC")]
	public void lookAtPlayerAngle()
	{
	}

	[Token(Token = "0x6000716")]
	[Address(RVA = "0xB41070", Offset = "0xB41070", VA = "0xB41070")]
	protected void DrawAgentPath()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0xB41164", Offset = "0xB41164", VA = "0xB41164")]
	public void Init_Animator()
	{
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0xB41334", Offset = "0xB41334", VA = "0xB41334")]
	public Vector3 PlayerUnderTran()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0xB413B4", Offset = "0xB413B4", VA = "0xB413B4")]
	protected void RunToTarget(Transform targetTran, string move)
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0xB414E0", Offset = "0xB414E0", VA = "0xB414E0")]
	protected void JumpOffMeshLink()
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0xB41AC8", Offset = "0xB41AC8", VA = "0xB41AC8")]
	public BaseNpcController()
	{
	}
}
[Token(Token = "0x20000FE")]
public class DZController : MonoBehaviour
{
	[Token(Token = "0x20000FF")]
	[CompilerGenerated]
	private sealed class <RunToAndFire>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Vector3 fireLookAt;

		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int num;

		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public float TimeCD;

		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private float <dis>5__2;

		[Token(Token = "0x1700014F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000734")]
			[Address(RVA = "0xB42E34", Offset = "0xB42E34", VA = "0xB42E34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000150")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000736")]
			[Address(RVA = "0xB42E7C", Offset = "0xB42E7C", VA = "0xB42E7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000731")]
		[Address(RVA = "0xB41EF8", Offset = "0xB41EF8", VA = "0xB41EF8")]
		[DebuggerHidden]
		public <RunToAndFire>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000732")]
		[Address(RVA = "0xB42B58", Offset = "0xB42B58", VA = "0xB42B58", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000733")]
		[Address(RVA = "0xB42B5C", Offset = "0xB42B5C", VA = "0xB42B5C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xB42E3C", Offset = "0xB42E3C", VA = "0xB42E3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000100")]
	[CompilerGenerated]
	private sealed class <RunToWait>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float dis;

		[Token(Token = "0x17000151")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600073A")]
			[Address(RVA = "0xB42F14", Offset = "0xB42F14", VA = "0xB42F14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000152")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600073C")]
			[Address(RVA = "0xB42F5C", Offset = "0xB42F5C", VA = "0xB42F5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000737")]
		[Address(RVA = "0xB42048", Offset = "0xB42048", VA = "0xB42048")]
		[DebuggerHidden]
		public <RunToWait>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xB42E84", Offset = "0xB42E84", VA = "0xB42E84", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000739")]
		[Address(RVA = "0xB42E88", Offset = "0xB42E88", VA = "0xB42E88", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600073B")]
		[Address(RVA = "0xB42F1C", Offset = "0xB42F1C", VA = "0xB42F1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000101")]
	[CompilerGenerated]
	private sealed class <RunTo>d__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x4000640")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float disA;

		[Token(Token = "0x4000641")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <dis>5__2;

		[Token(Token = "0x17000153")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000740")]
			[Address(RVA = "0xB433BC", Offset = "0xB433BC", VA = "0xB433BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000742")]
			[Address(RVA = "0xB43404", Offset = "0xB43404", VA = "0xB43404", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600073D")]
		[Address(RVA = "0xB42070", Offset = "0xB42070", VA = "0xB42070")]
		[DebuggerHidden]
		public <RunTo>d__25(int <>1__state)
		{
		}

		[Token(Token = "0x600073E")]
		[Address(RVA = "0xB42F64", Offset = "0xB42F64", VA = "0xB42F64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600073F")]
		[Address(RVA = "0xB42F68", Offset = "0xB42F68", VA = "0xB42F68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000741")]
		[Address(RVA = "0xB433C4", Offset = "0xB433C4", VA = "0xB433C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000102")]
	[CompilerGenerated]
	private sealed class <shot>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000642")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000644")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x4000645")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x17000155")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000746")]
			[Address(RVA = "0xB4373C", Offset = "0xB4373C", VA = "0xB4373C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000748")]
			[Address(RVA = "0xB43784", Offset = "0xB43784", VA = "0xB43784", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000743")]
		[Address(RVA = "0xB425B4", Offset = "0xB425B4", VA = "0xB425B4")]
		[DebuggerHidden]
		public <shot>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000744")]
		[Address(RVA = "0xB4340C", Offset = "0xB4340C", VA = "0xB4340C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000745")]
		[Address(RVA = "0xB43410", Offset = "0xB43410", VA = "0xB43410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000747")]
		[Address(RVA = "0xB43744", Offset = "0xB43744", VA = "0xB43744", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000103")]
	[CompilerGenerated]
	private sealed class <talkStr>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000646")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000647")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000648")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x4000649")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string animation;

		[Token(Token = "0x400064A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AudioClip clip;

		[Token(Token = "0x400064B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string talk;

		[Token(Token = "0x400064C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool skip;

		[Token(Token = "0x17000157")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600074C")]
			[Address(RVA = "0xB438B4", Offset = "0xB438B4", VA = "0xB438B4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000158")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600074E")]
			[Address(RVA = "0xB438FC", Offset = "0xB438FC", VA = "0xB438FC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000749")]
		[Address(RVA = "0xB425DC", Offset = "0xB425DC", VA = "0xB425DC")]
		[DebuggerHidden]
		public <talkStr>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x600074A")]
		[Address(RVA = "0xB4378C", Offset = "0xB4378C", VA = "0xB4378C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600074B")]
		[Address(RVA = "0xB43790", Offset = "0xB43790", VA = "0xB43790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600074D")]
		[Address(RVA = "0xB438BC", Offset = "0xB438BC", VA = "0xB438BC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000104")]
	[CompilerGenerated]
	private sealed class <TypeText>d__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400064D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400064E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400064F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DZController <>4__this;

		[Token(Token = "0x4000650")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool showSkip;

		[Token(Token = "0x4000651")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string msg;

		[Token(Token = "0x4000652")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private char[] <>7__wrap1;

		[Token(Token = "0x4000653")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <>7__wrap2;

		[Token(Token = "0x17000159")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000752")]
			[Address(RVA = "0xB43C54", Offset = "0xB43C54", VA = "0xB43C54", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0xB43C9C", Offset = "0xB43C9C", VA = "0xB43C9C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600074F")]
		[Address(RVA = "0xB426A0", Offset = "0xB426A0", VA = "0xB426A0")]
		[DebuggerHidden]
		public <TypeText>d__33(int <>1__state)
		{
		}

		[Token(Token = "0x6000750")]
		[Address(RVA = "0xB43904", Offset = "0xB43904", VA = "0xB43904", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000751")]
		[Address(RVA = "0xB43908", Offset = "0xB43908", VA = "0xB43908", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000753")]
		[Address(RVA = "0xB43C5C", Offset = "0xB43C5C", VA = "0xB43C5C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator ani;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private NavMeshAgent agent;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private AudioCue audioCue;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 fireLookAt;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int shotNum;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float shotFireTimeCD;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform bulletPoint;

	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AudioSource audioSource;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform playerTran;

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float printCD;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool isTalking;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public TextMeshProUGUI hudText;

	[Token(Token = "0x4000625")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform thisTranForm;

	[Token(Token = "0x4000626")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AudioClip WalkClip;

	[Token(Token = "0x4000627")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioClip RunClip;

	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float timerOffMeshLink;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float timeOffMeshLink;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool isJump;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool isMoveToStartPos;

	[Token(Token = "0x600071C")]
	[Address(RVA = "0xB41AE8", Offset = "0xB41AE8", VA = "0xB41AE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0xB41C3C", Offset = "0xB41C3C", VA = "0xB41C3C")]
	private void Update()
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0xB3D7D0", Offset = "0xB3D7D0", VA = "0xB3D7D0")]
	public void RunToAndFireMethod(Vector3 v, string aniStr, Vector3 fireLookAt, int num, float TimeCD)
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0xB41E10", Offset = "0xB41E10", VA = "0xB41E10")]
	[IteratorStateMachine(typeof(<RunToAndFire>d__22))]
	private IEnumerator RunToAndFire(Vector3 v, string aniStr, Vector3 fireLookAt, int num, float TimeCD)
	{
		return null;
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0xB41F20", Offset = "0xB41F20", VA = "0xB41F20")]
	public void RunToMethod(Vector3 v, string aniStr, float dis)
	{
	}

	[Token(Token = "0x6000721")]
	[Address(RVA = "0xB36418", Offset = "0xB36418", VA = "0xB36418")]
	[IteratorStateMachine(typeof(<RunToWait>d__24))]
	public IEnumerator RunToWait(Vector3 v, string aniStr, float dis)
	{
		return null;
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0xB41F8C", Offset = "0xB41F8C", VA = "0xB41F8C")]
	[IteratorStateMachine(typeof(<RunTo>d__25))]
	private IEnumerator RunTo(Vector3 v, string aniStr, float disA)
	{
		return null;
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0xB42098", Offset = "0xB42098", VA = "0xB42098")]
	public void Fire2(Vector3 fireLookAt, int num, float TimeCD)
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0xB423A0", Offset = "0xB423A0", VA = "0xB423A0")]
	public void setAni(string aniName)
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0xB42460", Offset = "0xB42460", VA = "0xB42460")]
	public void cancelAni(string aniName)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0xB42520", Offset = "0xB42520", VA = "0xB42520")]
	public void StopCoroutine()
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0xB42528", Offset = "0xB42528", VA = "0xB42528")]
	public void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0xB4232C", Offset = "0xB4232C", VA = "0xB4232C")]
	[IteratorStateMachine(typeof(<shot>d__31))]
	private IEnumerator shot()
	{
		return null;
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0xB3651C", Offset = "0xB3651C", VA = "0xB3651C")]
	[IteratorStateMachine(typeof(<talkStr>d__32))]
	public IEnumerator talkStr(string animation, string talk, AudioClip clip, bool skip = false)
	{
		return null;
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0xB42604", Offset = "0xB42604", VA = "0xB42604")]
	[IteratorStateMachine(typeof(<TypeText>d__33))]
	public IEnumerator TypeText(string msg, bool showSkip = false)
	{
		return null;
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0xB365E8", Offset = "0xB365E8", VA = "0xB365E8")]
	public void cleanTalkText()
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0xB4215C", Offset = "0xB4215C", VA = "0xB4215C")]
	public void Init_Animator()
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0xB426C8", Offset = "0xB426C8", VA = "0xB426C8")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0xB42844", Offset = "0xB42844", VA = "0xB42844")]
	protected void JumpOffMeshLink()
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0xB42B14", Offset = "0xB42B14", VA = "0xB42B14")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0xB42B3C", Offset = "0xB42B3C", VA = "0xB42B3C")]
	public DZController()
	{
	}
}
[Token(Token = "0x2000105")]
public class NpcController : MonoBehaviour
{
	[Token(Token = "0x2000106")]
	[CompilerGenerated]
	private sealed class <shot>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400066C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400066D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400066E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcController <>4__this;

		[Token(Token = "0x400066F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <i>5__2;

		[Token(Token = "0x1700015B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600076F")]
			[Address(RVA = "0xB457EC", Offset = "0xB457EC", VA = "0xB457EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000771")]
			[Address(RVA = "0xB45834", Offset = "0xB45834", VA = "0xB45834", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600076C")]
		[Address(RVA = "0xB4442C", Offset = "0xB4442C", VA = "0xB4442C")]
		[DebuggerHidden]
		public <shot>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0xB454BC", Offset = "0xB454BC", VA = "0xB454BC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0xB454C0", Offset = "0xB454C0", VA = "0xB454C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0xB457F4", Offset = "0xB457F4", VA = "0xB457F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000107")]
	[CompilerGenerated]
	private sealed class <RunToAndFire>d__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000670")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000671")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000672")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcController <>4__this;

		[Token(Token = "0x4000673")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x4000674")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Vector3 fireLookAt;

		[Token(Token = "0x4000675")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int num;

		[Token(Token = "0x4000676")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float TimeCD;

		[Token(Token = "0x4000677")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <dis>5__2;

		[Token(Token = "0x1700015D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0xB45B84", Offset = "0xB45B84", VA = "0xB45B84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0xB45BCC", Offset = "0xB45BCC", VA = "0xB45BCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0xB44858", Offset = "0xB44858", VA = "0xB44858")]
		[DebuggerHidden]
		public <RunToAndFire>d__26(int <>1__state)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0xB4583C", Offset = "0xB4583C", VA = "0xB4583C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0xB45840", Offset = "0xB45840", VA = "0xB45840", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000776")]
		[Address(RVA = "0xB45B8C", Offset = "0xB45B8C", VA = "0xB45B8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000108")]
	[CompilerGenerated]
	private sealed class <RunTo>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000678")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000679")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400067A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NpcController <>4__this;

		[Token(Token = "0x400067B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 v;

		[Token(Token = "0x400067C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string aniStr;

		[Token(Token = "0x400067D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool isDestory;

		[Token(Token = "0x400067E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <dis>5__2;

		[Token(Token = "0x1700015F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0xB46008", Offset = "0xB46008", VA = "0xB46008", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000160")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600077D")]
			[Address(RVA = "0xB46050", Offset = "0xB46050", VA = "0xB46050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000778")]
		[Address(RVA = "0xB45BD4", Offset = "0xB45BD4", VA = "0xB45BD4")]
		[DebuggerHidden]
		public <RunTo>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x6000779")]
		[Address(RVA = "0xB45BFC", Offset = "0xB45BFC", VA = "0xB45BFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600077A")]
		[Address(RVA = "0xB45C00", Offset = "0xB45C00", VA = "0xB45C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600077C")]
		[Address(RVA = "0xB46010", Offset = "0xB46010", VA = "0xB46010", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000654")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Animator ani;

	[Token(Token = "0x4000655")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private NavMeshAgent agent;

	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public NpcDataSO so;

	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public NpcEventSO _eventSO;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 fireLookAt;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private int shotNum;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float shotFireTimeCD;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform bulletPoint;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AudioCue audioCue;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public bool isWeapon;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private int HP;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform thisTranForm;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject baohu;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject playerHead;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public GameObject RZLive;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject RZDie;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Rigidbody[] RagDolls;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float timerOffMeshLink;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float timeOffMeshLink;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool isJump;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA1")]
	private bool isMoveToStartPos;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AnimationCurve curve;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 startV;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private Vector3 endV;

	[Token(Token = "0x6000755")]
	[Address(RVA = "0xB43CA4", Offset = "0xB43CA4", VA = "0xB43CA4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0xB43DB8", Offset = "0xB43DB8", VA = "0xB43DB8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0xB43E88", Offset = "0xB43E88", VA = "0xB43E88")]
	private void Update()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0xB440A4", Offset = "0xB440A4", VA = "0xB440A4")]
	public void Fire2(Vector3 fireLookAt, int num, float TimeCD)
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0xB364D4", Offset = "0xB364D4", VA = "0xB364D4")]
	public void LookAt(Transform LookAt)
	{
	}

	[Token(Token = "0x600075A")]
	[Address(RVA = "0xB443B8", Offset = "0xB443B8", VA = "0xB443B8")]
	[IteratorStateMachine(typeof(<shot>d__22))]
	private IEnumerator shot()
	{
		return null;
	}

	[Token(Token = "0x600075B")]
	[Address(RVA = "0xB44454", Offset = "0xB44454", VA = "0xB44454")]
	public void Die()
	{
	}

	[Token(Token = "0x600075C")]
	[Address(RVA = "0xB44690", Offset = "0xB44690", VA = "0xB44690")]
	public void StopRagDolls()
	{
	}

	[Token(Token = "0x600075D")]
	[Address(RVA = "0xB446F4", Offset = "0xB446F4", VA = "0xB446F4")]
	public void RunToAndFireMethod(Vector3 v, Vector3 fireLookAt, int num, float TimeCD)
	{
	}

	[Token(Token = "0x600075E")]
	[Address(RVA = "0xB44788", Offset = "0xB44788", VA = "0xB44788")]
	[IteratorStateMachine(typeof(<RunToAndFire>d__26))]
	private IEnumerator RunToAndFire(Vector3 v, Vector3 fireLookAt, int num, float TimeCD)
	{
		return null;
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0xB3638C", Offset = "0xB3638C", VA = "0xB3638C")]
	public void RunToMethod(Vector3 v, string aniStr, bool isDestory)
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0xB44880", Offset = "0xB44880", VA = "0xB44880")]
	[IteratorStateMachine(typeof(<RunTo>d__28))]
	private IEnumerator RunTo(Vector3 v, string aniStr, bool isDestory)
	{
		return null;
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0xB44940", Offset = "0xB44940", VA = "0xB44940")]
	public void setWeapon(bool weapon)
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0xB4494C", Offset = "0xB4494C", VA = "0xB4494C")]
	public void setAni(string aniName)
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0xB44A28", Offset = "0xB44A28", VA = "0xB44A28")]
	public void cancelAni(string aniName)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0xB441E8", Offset = "0xB441E8", VA = "0xB441E8")]
	public void Init_Animator()
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0xB44B04", Offset = "0xB44B04", VA = "0xB44B04")]
	private void ToRotate(Vector3 targetV)
	{
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0xB44D04", Offset = "0xB44D04", VA = "0xB44D04")]
	public void Dedge_Fire()
	{
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0xB44D08", Offset = "0xB44D08", VA = "0xB44D08")]
	private void OnAnimatorMove()
	{
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0xB3F95C", Offset = "0xB3F95C", VA = "0xB3F95C")]
	public void showNpcText()
	{
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0xB44E0C", Offset = "0xB44E0C", VA = "0xB44E0C")]
	private void BaohuLookAt()
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0xB44EBC", Offset = "0xB44EBC", VA = "0xB44EBC")]
	protected void JumpOffMeshLink()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0xB454A4", Offset = "0xB454A4", VA = "0xB454A4")]
	public NpcController()
	{
	}
}
[Token(Token = "0x2000109")]
public class PlayerController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200010A")]
	public class projectile
	{
		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody bombPrefab;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject muzzleflare;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float min;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float max;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool rapidFire;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rapidFireCooldown;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool shotgunBehavior;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int shotgunPellets;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject shellPrefab;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool hasShells;

		[Token(Token = "0x600079A")]
		[Address(RVA = "0xB47D78", Offset = "0xB47D78", VA = "0xB47D78")]
		public projectile()
		{
		}
	}

	[Token(Token = "0x200010B")]
	[CompilerGenerated]
	private sealed class <MinorInjury>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerController <>4__this;

		[Token(Token = "0x17000161")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600079E")]
			[Address(RVA = "0xB47DFC", Offset = "0xB47DFC", VA = "0xB47DFC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000162")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A0")]
			[Address(RVA = "0xB47E44", Offset = "0xB47E44", VA = "0xB47E44", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0xB47744", Offset = "0xB47744", VA = "0xB47744")]
		[DebuggerHidden]
		public <MinorInjury>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0xB47D80", Offset = "0xB47D80", VA = "0xB47D80", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0xB47D84", Offset = "0xB47D84", VA = "0xB47D84", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0xB47E04", Offset = "0xB47E04", VA = "0xB47E04", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200010C")]
	[CompilerGenerated]
	private sealed class <SeriousInjury>d__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerController <>4__this;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <f>5__2;

		[Token(Token = "0x17000163")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0xB4801C", Offset = "0xB4801C", VA = "0xB4801C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000164")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007A6")]
			[Address(RVA = "0xB48064", Offset = "0xB48064", VA = "0xB48064", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0xB477E0", Offset = "0xB477E0", VA = "0xB477E0")]
		[DebuggerHidden]
		public <SeriousInjury>d__51(int <>1__state)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0xB47E4C", Offset = "0xB47E4C", VA = "0xB47E4C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0xB47E50", Offset = "0xB47E50", VA = "0xB47E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0xB48024", Offset = "0xB48024", VA = "0xB48024", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200010D")]
	[CompilerGenerated]
	private sealed class <talkStr>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string talk;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PlayerController <>4__this;

		[Token(Token = "0x17000165")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0xB4812C", Offset = "0xB4812C", VA = "0xB4812C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000166")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0xB48174", Offset = "0xB48174", VA = "0xB48174", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0xB47964", Offset = "0xB47964", VA = "0xB47964")]
		[DebuggerHidden]
		public <talkStr>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0xB4806C", Offset = "0xB4806C", VA = "0xB4806C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0xB48070", Offset = "0xB48070", VA = "0xB48070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0xB48134", Offset = "0xB48134", VA = "0xB48134", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200010E")]
	[CompilerGenerated]
	private sealed class <TypeText>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PlayerController <>4__this;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private char[] <>7__wrap1;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>7__wrap2;

		[Token(Token = "0x17000167")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007B0")]
			[Address(RVA = "0xB48340", Offset = "0xB48340", VA = "0xB48340", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000168")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0xB48388", Offset = "0xB48388", VA = "0xB48388", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0xB47A1C", Offset = "0xB47A1C", VA = "0xB47A1C")]
		[DebuggerHidden]
		public <TypeText>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0xB4817C", Offset = "0xB4817C", VA = "0xB4817C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0xB48180", Offset = "0xB48180", VA = "0xB48180", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0xB48348", Offset = "0xB48348", VA = "0xB48348", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CharacterController controller;

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform playTrans;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4000682")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float jumpSpeed;

	[Token(Token = "0x4000683")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float gravity;

	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 moveDirection;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float rotateSpeed;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[Range(1f, 2f)]
	public float rotateRation;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform eyeViewTrans;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float x_RotateOffset;

	[Token(Token = "0x4000689")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform bulletTran;

	[Token(Token = "0x400068A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Animator ani;

	[Token(Token = "0x400068B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject GunObj;

	[Token(Token = "0x400068C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private GameObject FlashLight;

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[Tooltip("子弹预制体")]
	public GameObject Projectile;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public LayerMask ValidLayers;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public AudioSource audioSource;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRBGMController xRBGMController;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public TextMeshProUGUI hudText;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float printCD;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public GameObject HpBar;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject gameOver;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	private PlayerDataSO playerDataSO;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	private PlayerEventSO _playerEventSO;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public UIModuleEventSO _UIEventSO;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool isFeight;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform spawnLocatorMuzzleFlare;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public Transform shellLocator;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public Transform spawnLocator;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Transform shotgunLocator;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public projectile bomb;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public Rigidbody HideBullet;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private AudioCue audioCue;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public Transform HurtLine;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public GameObject cameraObj;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isStart;

	[Token(Token = "0x40006A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	private float shotTimer;

	[Token(Token = "0x40006A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private float shotCD;

	[Token(Token = "0x600077E")]
	[Address(RVA = "0xB46058", Offset = "0xB46058", VA = "0xB46058")]
	private void Start()
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0xB46160", Offset = "0xB46160", VA = "0xB46160")]
	private void initSO()
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0xB46280", Offset = "0xB46280", VA = "0xB46280")]
	private void Update()
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0xB462B8", Offset = "0xB462B8", VA = "0xB462B8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0xB46450", Offset = "0xB46450", VA = "0xB46450")]
	private void playerRotate()
	{
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0xB46324", Offset = "0xB46324", VA = "0xB46324")]
	private void playerMove()
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0xB46F04", Offset = "0xB46F04", VA = "0xB46F04")]
	private void shot()
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0xB46608", Offset = "0xB46608", VA = "0xB46608")]
	public void Fire()
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0xB47544", Offset = "0xB47544", VA = "0xB47544")]
	public void PlayBgmIndex(int index, float volume, bool loop)
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0xB4761C", Offset = "0xB4761C", VA = "0xB4761C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0xB476B8", Offset = "0xB476B8", VA = "0xB476B8")]
	public void HpHurt(int atk)
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0xB476D0", Offset = "0xB476D0", VA = "0xB476D0")]
	[IteratorStateMachine(typeof(<MinorInjury>d__50))]
	private IEnumerator MinorInjury()
	{
		return null;
	}

	[Token(Token = "0x600078A")]
	[Address(RVA = "0xB4776C", Offset = "0xB4776C", VA = "0xB4776C")]
	[IteratorStateMachine(typeof(<SeriousInjury>d__51))]
	private IEnumerator SeriousInjury()
	{
		return null;
	}

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xB461F0", Offset = "0xB461F0", VA = "0xB461F0")]
	private void replenishHp()
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xB47808", Offset = "0xB47808", VA = "0xB47808")]
	public void holdFight()
	{
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xB47898", Offset = "0xB47898", VA = "0xB47898")]
	public void overFight()
	{
	}

	[Token(Token = "0x600078E")]
	[Address(RVA = "0xB478C0", Offset = "0xB478C0", VA = "0xB478C0")]
	[IteratorStateMachine(typeof(<talkStr>d__55))]
	public IEnumerator talkStr(string talk, AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x600078F")]
	[Address(RVA = "0xB4798C", Offset = "0xB4798C", VA = "0xB4798C")]
	[IteratorStateMachine(typeof(<TypeText>d__56))]
	private IEnumerator TypeText(string msg)
	{
		return null;
	}

	[Token(Token = "0x6000790")]
	[Address(RVA = "0xB4783C", Offset = "0xB4783C", VA = "0xB4783C")]
	public void cleanTalkText()
	{
	}

	[Token(Token = "0x6000791")]
	[Address(RVA = "0xB47A44", Offset = "0xB47A44", VA = "0xB47A44")]
	public void setBlack()
	{
	}

	[Token(Token = "0x6000792")]
	[Address(RVA = "0xB47A88", Offset = "0xB47A88", VA = "0xB47A88")]
	public void cancelBlack()
	{
	}

	[Token(Token = "0x6000793")]
	[Address(RVA = "0xB47AC8", Offset = "0xB47AC8", VA = "0xB47AC8")]
	public void StopAll()
	{
	}

	[Token(Token = "0x6000794")]
	[Address(RVA = "0xB47AF0", Offset = "0xB47AF0", VA = "0xB47AF0")]
	public void GameOver(string str)
	{
	}

	[Token(Token = "0x6000795")]
	[Address(RVA = "0xB47B58", Offset = "0xB47B58", VA = "0xB47B58")]
	public void PlayWinImg(int level)
	{
	}

	[Token(Token = "0x6000796")]
	[Address(RVA = "0xB47C68", Offset = "0xB47C68", VA = "0xB47C68")]
	public void playAudio(AudioClip clip)
	{
	}

	[Token(Token = "0x6000797")]
	[Address(RVA = "0xB47C84", Offset = "0xB47C84", VA = "0xB47C84")]
	public void Win()
	{
	}

	[Token(Token = "0x6000798")]
	[Address(RVA = "0xB47CC8", Offset = "0xB47CC8", VA = "0xB47CC8")]
	public void setMinorLight(bool light)
	{
	}

	[Token(Token = "0x6000799")]
	[Address(RVA = "0xB47CE8", Offset = "0xB47CE8", VA = "0xB47CE8")]
	public PlayerController()
	{
	}
}
[Token(Token = "0x200010F")]
public class AudioCuePool : MonoBehaviour
{
	[Token(Token = "0x2000110")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AudioCuePool <>4__this;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject bullet;

		[Token(Token = "0x1700016A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0xB48A84", Offset = "0xB48A84", VA = "0xB48A84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0xB48ACC", Offset = "0xB48ACC", VA = "0xB48ACC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0xB48914", Offset = "0xB48914", VA = "0xB48914")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0xB489CC", Offset = "0xB489CC", VA = "0xB489CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0xB489D0", Offset = "0xB489D0", VA = "0xB489D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0xB48A8C", Offset = "0xB48A8C", VA = "0xB48A8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> audioPool;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int poolCount;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AudioCuePool _instance;

	[Token(Token = "0x17000169")]
	public static AudioCuePool Instance
	{
		[Token(Token = "0x60007B3")]
		[Address(RVA = "0xB48390", Offset = "0xB48390", VA = "0xB48390")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0xB48464", Offset = "0xB48464", VA = "0xB48464")]
	public void push(GameObject bullet)
	{
	}

	[Token(Token = "0x60007B5")]
	[Address(RVA = "0xB48584", Offset = "0xB48584", VA = "0xB48584")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0xB4885C", Offset = "0xB4885C", VA = "0xB4885C")]
	public void pushLazy(GameObject bullet, int second)
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0xB4887C", Offset = "0xB4887C", VA = "0xB4887C")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__8))]
	private IEnumerator pushLazyIEnum(GameObject bullet, int second)
	{
		return null;
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0xB486A0", Offset = "0xB486A0", VA = "0xB486A0")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0xB4893C", Offset = "0xB4893C", VA = "0xB4893C")]
	public AudioCuePool()
	{
	}
}
[Token(Token = "0x2000111")]
public class EnemyBulletPool : MonoBehaviour
{
	[Token(Token = "0x2000112")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EnemyBulletPool <>4__this;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject bullet;

		[Token(Token = "0x1700016D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0xB49190", Offset = "0xB49190", VA = "0xB49190", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007CD")]
			[Address(RVA = "0xB491D8", Offset = "0xB491D8", VA = "0xB491D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0xB48C44", Offset = "0xB48C44", VA = "0xB48C44")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0xB490D8", Offset = "0xB490D8", VA = "0xB490D8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0xB490DC", Offset = "0xB490DC", VA = "0xB490DC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0xB49198", Offset = "0xB49198", VA = "0xB49198", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject bullet;

	[Token(Token = "0x40006CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> bulletPool;

	[Token(Token = "0x40006CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int poolCount;

	[Token(Token = "0x40006CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static EnemyBulletPool _instance;

	[Token(Token = "0x1700016C")]
	public static EnemyBulletPool Instance
	{
		[Token(Token = "0x60007C0")]
		[Address(RVA = "0xB48AD4", Offset = "0xB48AD4", VA = "0xB48AD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0xB48BA8", Offset = "0xB48BA8", VA = "0xB48BA8")]
	public void pushLazy(GameObject bullet, int second)
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0xB48BAC", Offset = "0xB48BAC", VA = "0xB48BAC")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__7))]
	private IEnumerator pushLazyIEnum(GameObject bullet, int second)
	{
		return null;
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0xB48C6C", Offset = "0xB48C6C", VA = "0xB48C6C")]
	public void push(GameObject bullet)
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0xB48DBC", Offset = "0xB48DBC", VA = "0xB48DBC")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0xB48ED4", Offset = "0xB48ED4", VA = "0xB48ED4")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0xB49044", Offset = "0xB49044", VA = "0xB49044")]
	private void Start()
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0xB49048", Offset = "0xB49048", VA = "0xB49048")]
	public EnemyBulletPool()
	{
	}
}
[Token(Token = "0x2000113")]
public class MuzzleflarePool : MonoBehaviour
{
	[Token(Token = "0x2000114")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MuzzleflarePool <>4__this;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x17000170")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007D8")]
			[Address(RVA = "0xB49884", Offset = "0xB49884", VA = "0xB49884", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000171")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007DA")]
			[Address(RVA = "0xB498CC", Offset = "0xB498CC", VA = "0xB498CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0xB4936C", Offset = "0xB4936C", VA = "0xB4936C")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0xB497CC", Offset = "0xB497CC", VA = "0xB497CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0xB497D0", Offset = "0xB497D0", VA = "0xB497D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0xB4988C", Offset = "0xB4988C", VA = "0xB4988C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> projectilePool;

	[Token(Token = "0x40006D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int poolCount;

	[Token(Token = "0x40006D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MuzzleflarePool _instance;

	[Token(Token = "0x1700016F")]
	public static MuzzleflarePool Instance
	{
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0xB491E0", Offset = "0xB491E0", VA = "0xB491E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0xB492B4", Offset = "0xB492B4", VA = "0xB492B4")]
	public void pushLazy(GameObject projectile, int second)
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0xB492D4", Offset = "0xB492D4", VA = "0xB492D4")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__6))]
	private IEnumerator pushLazyIEnum(GameObject projectile, int second)
	{
		return null;
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0xB49394", Offset = "0xB49394", VA = "0xB49394")]
	public void push(GameObject projectile)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0xB494B4", Offset = "0xB494B4", VA = "0xB494B4")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0xB495CC", Offset = "0xB495CC", VA = "0xB495CC")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0xB4973C", Offset = "0xB4973C", VA = "0xB4973C")]
	public MuzzleflarePool()
	{
	}
}
[Token(Token = "0x2000115")]
public class ProjectilePool : MonoBehaviour
{
	[Token(Token = "0x2000116")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProjectilePool <>4__this;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x17000173")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0xB49D6C", Offset = "0xB49D6C", VA = "0xB49D6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000174")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0xB49DB4", Offset = "0xB49DB4", VA = "0xB49DB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0xB4996C", Offset = "0xB4996C", VA = "0xB4996C")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x60007E3")]
		[Address(RVA = "0xB49CB4", Offset = "0xB49CB4", VA = "0xB49CB4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E4")]
		[Address(RVA = "0xB49CB8", Offset = "0xB49CB8", VA = "0xB49CB8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xB49D74", Offset = "0xB49D74", VA = "0xB49D74", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject projectile;

	[Token(Token = "0x40006DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private List<GameObject> projectilePool;

	[Token(Token = "0x40006DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int poolCount;

	[Token(Token = "0x40006DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ProjectilePool _instance;

	[Token(Token = "0x17000172")]
	public static ProjectilePool Instance
	{
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0xB4724C", Offset = "0xB4724C", VA = "0xB4724C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0xB47438", Offset = "0xB47438", VA = "0xB47438")]
	public void pushLazy(GameObject projectile, int second)
	{
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0xB498D4", Offset = "0xB498D4", VA = "0xB498D4")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__7))]
	private IEnumerator pushLazyIEnum(GameObject projectile, int second)
	{
		return null;
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0xB49994", Offset = "0xB49994", VA = "0xB49994")]
	public void push(GameObject projectile)
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0xB47320", Offset = "0xB47320", VA = "0xB47320")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0xB49AB4", Offset = "0xB49AB4", VA = "0xB49AB4")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0xB49C24", Offset = "0xB49C24", VA = "0xB49C24")]
	public ProjectilePool()
	{
	}
}
[Token(Token = "0x2000117")]
public class RocketBulletPool : MonoBehaviour
{
	[Token(Token = "0x2000118")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RocketBulletPool <>4__this;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x17000176")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0xB4A520", Offset = "0xB4A520", VA = "0xB4A520", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000177")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0xB4A568", Offset = "0xB4A568", VA = "0xB4A568", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xB49F48", Offset = "0xB49F48", VA = "0xB49F48")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0xB4A468", Offset = "0xB4A468", VA = "0xB4A468", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0xB4A46C", Offset = "0xB4A46C", VA = "0xB4A46C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0xB4A528", Offset = "0xB4A528", VA = "0xB4A528", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> projectilePool;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int poolCount;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RocketBulletPool _instance;

	[Token(Token = "0x17000175")]
	public static RocketBulletPool Instance
	{
		[Token(Token = "0x60007E8")]
		[Address(RVA = "0xB49DBC", Offset = "0xB49DBC", VA = "0xB49DBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007E9")]
	[Address(RVA = "0xB49E90", Offset = "0xB49E90", VA = "0xB49E90")]
	public void pushLazy(GameObject projectile, int second)
	{
	}

	[Token(Token = "0x60007EA")]
	[Address(RVA = "0xB49EB0", Offset = "0xB49EB0", VA = "0xB49EB0")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__6))]
	private IEnumerator pushLazyIEnum(GameObject projectile, int second)
	{
		return null;
	}

	[Token(Token = "0x60007EB")]
	[Address(RVA = "0xB49F70", Offset = "0xB49F70", VA = "0xB49F70")]
	public void push(GameObject projectile)
	{
	}

	[Token(Token = "0x60007EC")]
	[Address(RVA = "0xB4A0E4", Offset = "0xB4A0E4", VA = "0xB4A0E4")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007ED")]
	[Address(RVA = "0xB4A268", Offset = "0xB4A268", VA = "0xB4A268")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007EE")]
	[Address(RVA = "0xB4A3D8", Offset = "0xB4A3D8", VA = "0xB4A3D8")]
	public RocketBulletPool()
	{
	}
}
[Token(Token = "0x2000119")]
public class ShellPool : MonoBehaviour
{
	[Token(Token = "0x200011A")]
	[CompilerGenerated]
	private sealed class <pushLazyIEnum>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int second;

		[Token(Token = "0x40006F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShellPool <>4__this;

		[Token(Token = "0x40006F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public GameObject projectile;

		[Token(Token = "0x17000179")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0xB4AC14", Offset = "0xB4AC14", VA = "0xB4AC14", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0xB4AC5C", Offset = "0xB4AC5C", VA = "0xB4AC5C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0xB4A6FC", Offset = "0xB4A6FC", VA = "0xB4A6FC")]
		[DebuggerHidden]
		public <pushLazyIEnum>d__6(int <>1__state)
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0xB4AB5C", Offset = "0xB4AB5C", VA = "0xB4AB5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0xB4AB60", Offset = "0xB4AB60", VA = "0xB4AB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0xB4AC1C", Offset = "0xB4AC1C", VA = "0xB4AC1C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> projectilePool;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int poolCount;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static ShellPool _instance;

	[Token(Token = "0x17000178")]
	public static ShellPool Instance
	{
		[Token(Token = "0x60007F5")]
		[Address(RVA = "0xB4A570", Offset = "0xB4A570", VA = "0xB4A570")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0xB4A644", Offset = "0xB4A644", VA = "0xB4A644")]
	public void pushLazy(GameObject projectile, int second)
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0xB4A664", Offset = "0xB4A664", VA = "0xB4A664")]
	[IteratorStateMachine(typeof(<pushLazyIEnum>d__6))]
	private IEnumerator pushLazyIEnum(GameObject projectile, int second)
	{
		return null;
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0xB4A724", Offset = "0xB4A724", VA = "0xB4A724")]
	public void push(GameObject projectile)
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0xB4A844", Offset = "0xB4A844", VA = "0xB4A844")]
	public GameObject pull()
	{
		return null;
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0xB4A95C", Offset = "0xB4A95C", VA = "0xB4A95C")]
	private GameObject Instantiate()
	{
		return null;
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0xB4AACC", Offset = "0xB4AACC", VA = "0xB4AACC")]
	public ShellPool()
	{
	}
}
[Token(Token = "0x200011B")]
public class ProjectileController : MonoBehaviour
{
	[Token(Token = "0x200011C")]
	[CompilerGenerated]
	private sealed class <CheckForRaycast>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProjectileController <>4__this;

		[Token(Token = "0x1700017B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0xB4B2E0", Offset = "0xB4B2E0", VA = "0xB4B2E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0xB4B328", Offset = "0xB4B328", VA = "0xB4B328", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0xB4ACF8", Offset = "0xB4ACF8", VA = "0xB4ACF8")]
		[DebuggerHidden]
		public <CheckForRaycast>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xB4B200", Offset = "0xB4B200", VA = "0xB4B200", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xB4B204", Offset = "0xB4B204", VA = "0xB4B204", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xB4B2E8", Offset = "0xB4B2E8", VA = "0xB4B2E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask ValidLayers;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject HitFXPrefab;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float AddRigidForce;

	[Token(Token = "0x6000802")]
	[Address(RVA = "0xB4AC64", Offset = "0xB4AC64", VA = "0xB4AC64", Slot = "4")]
	public virtual void MarkAsRaycastBullet()
	{
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0xB4AC84", Offset = "0xB4AC84", VA = "0xB4AC84")]
	[IteratorStateMachine(typeof(<CheckForRaycast>d__4))]
	private IEnumerator CheckForRaycast()
	{
		return null;
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0xB4AD20", Offset = "0xB4AD20", VA = "0xB4AD20", Slot = "5")]
	public virtual void DoRayCastProjectile()
	{
	}

	[Token(Token = "0x6000805")]
	[Address(RVA = "0xB4AEBC", Offset = "0xB4AEBC", VA = "0xB4AEBC", Slot = "6")]
	public virtual void DoHitFX(Vector3 pos, Quaternion rot, Collider col)
	{
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0xB4B1F0", Offset = "0xB4B1F0", VA = "0xB4B1F0")]
	public ProjectileController()
	{
	}
}
[Token(Token = "0x200011D")]
public class SceneController : MonoBehaviour
{
	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string nextScene;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AsyncOperation async;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float temProgress;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI text;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static SceneController _instance;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GameObject Player;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject Canvas;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Image image;

	[Token(Token = "0x1700017D")]
	public static SceneController Instance
	{
		[Token(Token = "0x600080D")]
		[Address(RVA = "0xB4B330", Offset = "0xB4B330", VA = "0xB4B330")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0xB4B544", Offset = "0xB4B544", VA = "0xB4B544")]
	private void Start()
	{
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0xB4B7E4", Offset = "0xB4B7E4", VA = "0xB4B7E4")]
	private void LookAtPlayer()
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0xB4B904", Offset = "0xB4B904", VA = "0xB4B904")]
	public void loadLoadingScene(int level)
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0xB4B9E0", Offset = "0xB4B9E0", VA = "0xB4B9E0")]
	public void loadLoadingScene(string scene)
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0xB4BA84", Offset = "0xB4BA84", VA = "0xB4BA84")]
	public void loadLoadingThisScene()
	{
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0xB4BAEC", Offset = "0xB4BAEC", VA = "0xB4BAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0xB4BC9C", Offset = "0xB4BC9C", VA = "0xB4BC9C")]
	public SceneController()
	{
	}
}
[Token(Token = "0x200011E")]
[CreateAssetMenu(fileName = "AudioCueSO", menuName = "SO/Data/AudioCueSO")]
public class AudioCueSO : ScriptableObject
{
	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int playIndex;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AudioClip[] clips;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 vector;

	[Token(Token = "0x4000705")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AudioClip[] E_clips;

	[Token(Token = "0x6000815")]
	[Address(RVA = "0xB4BCA4", Offset = "0xB4BCA4", VA = "0xB4BCA4")]
	public AudioClip ClipIndex(int index, int language = 0)
	{
		return null;
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0xB4BCF0", Offset = "0xB4BCF0", VA = "0xB4BCF0")]
	public AudioCueSO()
	{
	}
}
[Token(Token = "0x200011F")]
[CreateAssetMenu(fileName = "BossTriggerSO", menuName = "SO/Data/BossTriggerSO")]
public class BossTriggerSO : ScriptableObject
{
	[Token(Token = "0x4000706")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int HP;

	[Token(Token = "0x4000707")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	public int MaxHP;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int Atk;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	public float fightShotCD;

	[Token(Token = "0x6000817")]
	[Address(RVA = "0xB4BCF8", Offset = "0xB4BCF8", VA = "0xB4BCF8")]
	public BossTriggerSO()
	{
	}
}
[Token(Token = "0x2000120")]
[CreateAssetMenu(fileName = "CheckLevelSO", menuName = "SO/Data/CheckLevelSO")]
public class CheckLevelSO : ScriptableObject
{
	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int level;

	[Token(Token = "0x6000818")]
	[Address(RVA = "0xB4BD00", Offset = "0xB4BD00", VA = "0xB4BD00")]
	public CheckLevelSO()
	{
	}
}
[Token(Token = "0x2000121")]
[CreateAssetMenu(fileName = "EnemyTriggerSO", menuName = "SO/Data/EnemyTriggerSO")]
public class EnemyTriggerSO : ScriptableObject
{
	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	public int trigger;

	[Token(Token = "0x6000819")]
	[Address(RVA = "0xB4BD08", Offset = "0xB4BD08", VA = "0xB4BD08")]
	public EnemyTriggerSO()
	{
	}
}
[Token(Token = "0x2000122")]
[CreateAssetMenu(fileName = "HeroineFireSO", menuName = "SO/Data/HeroineFireSO")]
public class HeroineFireSO : ScriptableObject
{
	[Token(Token = "0x2000123")]
	public enum FireType
	{
		[Token(Token = "0x400070E")]
		Fire_1,
		[Token(Token = "0x400070F")]
		Fire_2
	}

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FireType fireType;

	[Token(Token = "0x600081A")]
	[Address(RVA = "0xB4BD10", Offset = "0xB4BD10", VA = "0xB4BD10")]
	public HeroineFireSO()
	{
	}
}
[Token(Token = "0x2000124")]
[CreateAssetMenu(fileName = "LeftHandModelSO", menuName = "SO/Data/LeftHandModelSO")]
public class LeftHandModelSO : ScriptableObject
{
	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool isLeft;

	[Token(Token = "0x600081B")]
	[Address(RVA = "0xB4BD18", Offset = "0xB4BD18", VA = "0xB4BD18")]
	public LeftHandModelSO()
	{
	}
}
[Token(Token = "0x2000125")]
[CreateAssetMenu(fileName = "Level0PlotDataSO", menuName = "SO/Data/Level0PlotDataSO")]
public class Level0PlotDataSO : ScriptableObject
{
	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite Cover;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string Content;

	[Token(Token = "0x600081C")]
	[Address(RVA = "0xB4BD20", Offset = "0xB4BD20", VA = "0xB4BD20")]
	public Level0PlotDataSO()
	{
	}
}
[Token(Token = "0x2000126")]
[CreateAssetMenu(fileName = "Level0RoleDataSO", menuName = "SO/Data/Level0RoleDataSO")]
public class Level0RoleDataSO : ScriptableObject
{
	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int index;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite Head;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string NameStr;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string RoleStr;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string GoodAtStr;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string Content;

	[Token(Token = "0x600081D")]
	[Address(RVA = "0xB4BD28", Offset = "0xB4BD28", VA = "0xB4BD28")]
	public Level0RoleDataSO()
	{
	}
}
[Token(Token = "0x2000127")]
[CreateAssetMenu(fileName = "NpcDataSO", menuName = "SO/Data/NpcDataSO")]
public class NpcDataSO : ScriptableObject
{
	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string NpcName;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isDie;

	[Token(Token = "0x600081E")]
	[Address(RVA = "0xB4BD30", Offset = "0xB4BD30", VA = "0xB4BD30")]
	public NpcDataSO()
	{
	}
}
[Token(Token = "0x2000128")]
[CreateAssetMenu(fileName = "PlayerDataSO", menuName = "SO/Data/PlayerDataCreatorSO", order = 1)]
public class PlayerDataSO : ScriptableObject
{
	[Token(Token = "0x400071C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Range(0f, 100f)]
	[SerializeField]
	public int PlayerHp;

	[Token(Token = "0x400071D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	[Range(0f, 100f)]
	private int playerMaxHp;

	[Token(Token = "0x400071E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public bool isFail;

	[Token(Token = "0x400071F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	[SerializeField]
	public bool isDamage;

	[Token(Token = "0x4000720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x22")]
	[SerializeField]
	public bool isBlack;

	[Token(Token = "0x4000721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x23")]
	[SerializeField]
	public bool isTalk;

	[Token(Token = "0x4000722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	public bool isPause;

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x25")]
	[SerializeField]
	public bool isGameOver;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x26")]
	[SerializeField]
	public bool isWin;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string message;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string killNum;

	[Token(Token = "0x1700017E")]
	public int PlayerMaxHp
	{
		[Token(Token = "0x600081F")]
		[Address(RVA = "0xB4BD38", Offset = "0xB4BD38", VA = "0xB4BD38")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000820")]
	[Address(RVA = "0xB4BD40", Offset = "0xB4BD40", VA = "0xB4BD40")]
	public PlayerDataSO()
	{
	}
}
[Token(Token = "0x2000129")]
[CreateAssetMenu(fileName = "ShieldDataSO", menuName = "SO/Data/ShieldDataSO")]
public class ShieldDataSO : ScriptableObject
{
	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int MaxSecond;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int Second;

	[Token(Token = "0x6000821")]
	[Address(RVA = "0xB4BDC4", Offset = "0xB4BDC4", VA = "0xB4BDC4")]
	public ShieldDataSO()
	{
	}
}
[Token(Token = "0x200012A")]
[CreateAssetMenu(fileName = "ThiefDataSO", menuName = "SO/Data/ThiefDataSO")]
public class ThiefDataSO : ScriptableObject
{
	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ThiefName;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isDie;

	[Token(Token = "0x6000822")]
	[Address(RVA = "0xB4BDCC", Offset = "0xB4BDCC", VA = "0xB4BDCC")]
	public ThiefDataSO()
	{
	}
}
[Token(Token = "0x200012B")]
[CreateAssetMenu(fileName = "UIModuleSO", menuName = "SO/Data/UIModuleSO")]
public class UIModuleSO : ScriptableObject
{
	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string names;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool toOpen;

	[Token(Token = "0x400072D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int level;

	[Token(Token = "0x6000823")]
	[Address(RVA = "0xB47C60", Offset = "0xB47C60", VA = "0xB47C60")]
	public UIModuleSO()
	{
	}
}
[Token(Token = "0x200012C")]
[CreateAssetMenu(fileName = "WeaponDataSO", menuName = "SO/Data/WeaponDataSO")]
public class WeaponDataSO : ScriptableObject
{
	[Token(Token = "0x400072E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Tooltip("射击间隔")]
	public float fireCD;

	[Token(Token = "0x400072F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[Tooltip("子弹射速")]
	public float ShotForce;

	[Token(Token = "0x4000730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[Tooltip("剩余子弹数")]
	public int bulletNum;

	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[Tooltip("最大子弹数")]
	public int bulletMaxNum;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[Tooltip("枪的路径")]
	public string weaponPah;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[Tooltip("火的路径")]
	public string MuzzleFlushPath;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[Tooltip("弹夹")]
	public string shellPath;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string FirePath;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string bulletNumText;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[Tooltip("最小速度")]
	public float min;

	[Token(Token = "0x4000738")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[Tooltip("最大速度")]
	public float max;

	[Token(Token = "0x4000739")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[Tooltip("左手子集路径")]
	public string IncludeLeftHand;

	[Token(Token = "0x400073A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public int weaponSoundIndex;

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string weaponType;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public string weapon;

	[Token(Token = "0x6000824")]
	[Address(RVA = "0xB4BDD4", Offset = "0xB4BDD4", VA = "0xB4BDD4")]
	public WeaponDataSO()
	{
	}
}
[Token(Token = "0x200012D")]
[CreateAssetMenu(fileName = "WinImgSO", menuName = "SO/Data/WinImgSO")]
public class WinImgSO : ScriptableObject
{
	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int playerIndex;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite[] images;

	[Token(Token = "0x6000825")]
	[Address(RVA = "0xB4BDEC", Offset = "0xB4BDEC", VA = "0xB4BDEC")]
	public WinImgSO()
	{
	}
}
[Token(Token = "0x200012E")]
[CreateAssetMenu(fileName = "XRDataSO", menuName = "SO/Data/XRDataSO")]
public class XRDataSO : ScriptableObject
{
	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float YOffset;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float add;

	[Token(Token = "0x6000826")]
	[Address(RVA = "0xB4BDF4", Offset = "0xB4BDF4", VA = "0xB4BDF4")]
	public XRDataSO()
	{
	}
}
[Token(Token = "0x200012F")]
[CreateAssetMenu(menuName = "SO/Event/AudioCueEventSO")]
public class AudioCueEventSO : ScriptableObject
{
	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<AudioCueSO> OnTrigger;

	[Token(Token = "0x6000827")]
	[Address(RVA = "0xB4BDFC", Offset = "0xB4BDFC", VA = "0xB4BDFC")]
	public void Raise(AudioCueSO so)
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0xB4BE18", Offset = "0xB4BE18", VA = "0xB4BE18")]
	public AudioCueEventSO()
	{
	}
}
[Token(Token = "0x2000130")]
[CreateAssetMenu(fileName = "BossTriggerEventSO", menuName = "SO/Event/BossTriggerEventSO")]
public class BossTriggerEventSO : ScriptableObject
{
	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<BossTriggerSO> OnTrigger;

	[Token(Token = "0x6000829")]
	[Address(RVA = "0xB4BE20", Offset = "0xB4BE20", VA = "0xB4BE20")]
	public void Raise(BossTriggerSO so)
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0xB4BE3C", Offset = "0xB4BE3C", VA = "0xB4BE3C")]
	public BossTriggerEventSO()
	{
	}
}
[Token(Token = "0x2000131")]
[CreateAssetMenu(fileName = "CheckLevelEventSO", menuName = "SO/Event/CheckLevelEventSO")]
public class CheckLevelEventSO : ScriptableObject
{
	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<CheckLevelSO> OnTrigger;

	[Token(Token = "0x600082B")]
	[Address(RVA = "0xB4BE44", Offset = "0xB4BE44", VA = "0xB4BE44")]
	public void Raise(CheckLevelSO so)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0xB4BE60", Offset = "0xB4BE60", VA = "0xB4BE60")]
	public CheckLevelEventSO()
	{
	}
}
[Token(Token = "0x2000132")]
[CreateAssetMenu(fileName = "EnemyTriggerEventSO", menuName = "SO/Event/EnemyTriggerEventSO")]
public class EnemyTriggerEventSO : ScriptableObject
{
	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<EnemyTriggerSO> OnTrigger;

	[Token(Token = "0x600082D")]
	[Address(RVA = "0xB4BE68", Offset = "0xB4BE68", VA = "0xB4BE68")]
	public void Raise(EnemyTriggerSO so)
	{
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0xB4BE84", Offset = "0xB4BE84", VA = "0xB4BE84")]
	public EnemyTriggerEventSO()
	{
	}
}
[Token(Token = "0x2000133")]
[CreateAssetMenu(fileName = "LeftHandEventSO", menuName = "SO/Event/LeftHandEventSO")]
public class LeftHandEventSO : ScriptableObject
{
	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<LeftHandModelSO> OnTrigger;

	[Token(Token = "0x600082F")]
	[Address(RVA = "0xB4BE8C", Offset = "0xB4BE8C", VA = "0xB4BE8C")]
	public void Raise(LeftHandModelSO so)
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0xB4BEA8", Offset = "0xB4BEA8", VA = "0xB4BEA8")]
	public LeftHandEventSO()
	{
	}
}
[Token(Token = "0x2000134")]
[CreateAssetMenu(fileName = "NpcEventSO", menuName = "SO/Event/NpcEventSO")]
public class NpcEventSO : ScriptableObject
{
	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<NpcDataSO> OnTrigger;

	[Token(Token = "0x6000831")]
	[Address(RVA = "0xB4BEB0", Offset = "0xB4BEB0", VA = "0xB4BEB0")]
	public void Raise(NpcDataSO so)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0xB4BECC", Offset = "0xB4BECC", VA = "0xB4BECC")]
	public NpcEventSO()
	{
	}
}
[Token(Token = "0x2000135")]
[CreateAssetMenu(fileName = "PlayerEventSO", menuName = "SO/Event/PlayerEventSO", order = 1)]
public class PlayerEventSO : ScriptableObject
{
	[Token(Token = "0x4000747")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<PlayerDataSO> OnTrigger;

	[Token(Token = "0x6000833")]
	[Address(RVA = "0xB47528", Offset = "0xB47528", VA = "0xB47528")]
	public void Raise(PlayerDataSO so)
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0xB4BED4", Offset = "0xB4BED4", VA = "0xB4BED4")]
	public PlayerEventSO()
	{
	}
}
[Token(Token = "0x2000136")]
[CreateAssetMenu(fileName = "ShieldEventSO", menuName = "SO/Event/ShieldEventSO", order = 1)]
public class ShieldEventSO : ScriptableObject
{
	[Token(Token = "0x4000748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<ShieldDataSO> OnTrigger;

	[Token(Token = "0x6000835")]
	[Address(RVA = "0xB4BEDC", Offset = "0xB4BEDC", VA = "0xB4BEDC")]
	public void Raise(ShieldDataSO so)
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0xB4BEF8", Offset = "0xB4BEF8", VA = "0xB4BEF8")]
	public ShieldEventSO()
	{
	}
}
[Token(Token = "0x2000137")]
[CreateAssetMenu(fileName = "ThiefEventSO", menuName = "SO/Event/ThiefEventSO")]
public class ThiefEventSO : ScriptableObject
{
	[Token(Token = "0x4000749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<ThiefDataSO> OnTrigger;

	[Token(Token = "0x6000837")]
	[Address(RVA = "0xB4BF00", Offset = "0xB4BF00", VA = "0xB4BF00")]
	public void Raise(ThiefDataSO so)
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0xB4BF1C", Offset = "0xB4BF1C", VA = "0xB4BF1C")]
	public ThiefEventSO()
	{
	}
}
[Token(Token = "0x2000138")]
[CreateAssetMenu(fileName = "UIModuleEventSO", menuName = "SO/Event/UIModuleEventSO", order = 1)]
public class UIModuleEventSO : ScriptableObject
{
	[Token(Token = "0x400074A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityAction<UIModuleSO> OnTrigger;

	[Token(Token = "0x6000839")]
	[Address(RVA = "0xB4BF24", Offset = "0xB4BF24", VA = "0xB4BF24")]
	public void Raise(UIModuleSO so)
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0xB4BF40", Offset = "0xB4BF40", VA = "0xB4BF40")]
	public UIModuleEventSO()
	{
	}
}
[Token(Token = "0x2000139")]
public class IKControl : MonoBehaviour
{
	[Token(Token = "0x400074B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x400074C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator animator;

	[Token(Token = "0x600083B")]
	[Address(RVA = "0xB4BF48", Offset = "0xB4BF48", VA = "0xB4BF48")]
	private void OnAnimatorIK(int layerIndex)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0xB4BFE0", Offset = "0xB4BFE0", VA = "0xB4BFE0")]
	public IKControl()
	{
	}
}
[Token(Token = "0x200013A")]
public class destroyMe_cp : MonoBehaviour
{
	[Token(Token = "0x400074D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private float timer;

	[Token(Token = "0x400074E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float deathtimer;

	[Token(Token = "0x600083D")]
	[Address(RVA = "0xB4BFE8", Offset = "0xB4BFE8", VA = "0xB4BFE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0xB4BFEC", Offset = "0xB4BFEC", VA = "0xB4BFEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0xB4C090", Offset = "0xB4C090", VA = "0xB4C090")]
	public destroyMe_cp()
	{
	}
}
[Token(Token = "0x200013B")]
public class ExplodingProjectile_cp : MonoBehaviour
{
	[Token(Token = "0x400074F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject impactPrefab;

	[Token(Token = "0x4000750")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject squirtBlood;

	[Token(Token = "0x4000751")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject explosionPrefab;

	[Token(Token = "0x4000752")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public float thrust;

	[Token(Token = "0x4000753")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Rigidbody thisRigidbody;

	[Token(Token = "0x4000754")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject particleKillGroup;

	[Token(Token = "0x4000755")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Collider thisCollider;

	[Token(Token = "0x4000756")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool LookRotation;

	[Token(Token = "0x4000757")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool Missile;

	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform missileTarget;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public float projectileSpeed;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public float projectileSpeedMultiplier;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public bool ignorePrevRotation;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	public bool explodeOnTimer;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float explosionTimer;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float timer;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	public LayerMask ValidLayers;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 previousPosition;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private AudioCue cue;

	[Token(Token = "0x6000840")]
	[Address(RVA = "0xB4C0A0", Offset = "0xB4C0A0", VA = "0xB4C0A0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0xB4C1C4", Offset = "0xB4C1C4", VA = "0xB4C1C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0xB4C334", Offset = "0xB4C334", VA = "0xB4C334")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000843")]
	[Address(RVA = "0xB4C3F0", Offset = "0xB4C3F0", VA = "0xB4C3F0")]
	private void CheckCollision(Vector3 prevPos)
	{
	}

	[Token(Token = "0x6000844")]
	[Address(RVA = "0xB4CB44", Offset = "0xB4CB44", VA = "0xB4CB44")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0xB4C214", Offset = "0xB4C214", VA = "0xB4C214")]
	private void Explode()
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0xB4CE18", Offset = "0xB4CE18", VA = "0xB4CE18")]
	public ExplodingProjectile_cp()
	{
	}
}
[Token(Token = "0x200013C")]
public class GunController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013D")]
	public class projectile
	{
		[Token(Token = "0x4000769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string name;

		[Token(Token = "0x400076A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Rigidbody bombPrefab;

		[Token(Token = "0x400076B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject muzzleflare;

		[Token(Token = "0x400076C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float min;

		[Token(Token = "0x400076D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float max;

		[Token(Token = "0x400076E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool rapidFire;

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float rapidFireCooldown;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool shotgunBehavior;

		[Token(Token = "0x4000771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int shotgunPellets;

		[Token(Token = "0x4000772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public GameObject shellPrefab;

		[Token(Token = "0x4000773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool hasShells;

		[Token(Token = "0x600084B")]
		[Address(RVA = "0xB4D2CC", Offset = "0xB4D2CC", VA = "0xB4D2CC")]
		public projectile()
		{
		}
	}

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int projectileSimFire;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform spawnLocatorMuzzleFlare;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform shellLocator;

	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform spawnLocator;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform shotgunLocator;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Rigidbody bullet;

	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public projectile bomb;

	[Token(Token = "0x6000847")]
	[Address(RVA = "0xB4CE28", Offset = "0xB4CE28", VA = "0xB4CE28")]
	private void Start()
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0xB4CE2C", Offset = "0xB4CE2C", VA = "0xB4CE2C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0xB4CE8C", Offset = "0xB4CE8C", VA = "0xB4CE8C")]
	public void Fire()
	{
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0xB4D2BC", Offset = "0xB4D2BC", VA = "0xB4D2BC")]
	public GunController()
	{
	}
}
[Token(Token = "0x200013E")]
public class instantiateEffectCaller_cp : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013F")]
	public class chainEffect
	{
		[NonSerialized]
		[Token(Token = "0x4000778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPlayed;

		[Token(Token = "0x4000779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float activateTimer;

		[Token(Token = "0x400077A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject Effect;

		[Token(Token = "0x400077B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform effectLocator;

		[Token(Token = "0x6000851")]
		[Address(RVA = "0xB4D55C", Offset = "0xB4D55C", VA = "0xB4D55C")]
		public chainEffect()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool fired;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private float timer;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public float timeLimit;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public chainEffect[] chainEffectList;

	[Token(Token = "0x600084C")]
	[Address(RVA = "0xB4D2D4", Offset = "0xB4D2D4", VA = "0xB4D2D4")]
	private void Start()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0xB4D2D8", Offset = "0xB4D2D8", VA = "0xB4D2D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0xB4D308", Offset = "0xB4D308", VA = "0xB4D308")]
	private void CheckTimer()
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0xB4D500", Offset = "0xB4D500", VA = "0xB4D500")]
	public void ResetTimers()
	{
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0xB4D554", Offset = "0xB4D554", VA = "0xB4D554")]
	public instantiateEffectCaller_cp()
	{
	}
}
[Token(Token = "0x2000140")]
[ExecuteInEditMode]
public class particleColorChanger_cp : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000141")]
	public class colorChange
	{
		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x4000780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParticleSystem[] colored_ParticleSystem;

		[Token(Token = "0x4000781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Gradient Gradient_custom;

		[Token(Token = "0x6000854")]
		[Address(RVA = "0xB4D6A0", Offset = "0xB4D6A0", VA = "0xB4D6A0")]
		public colorChange()
		{
		}
	}

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public colorChange[] colorChangeList;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool applyChanges;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool Keep_applyChanges;

	[Token(Token = "0x6000852")]
	[Address(RVA = "0xB4D564", Offset = "0xB4D564", VA = "0xB4D564")]
	private void Update()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0xB4D698", Offset = "0xB4D698", VA = "0xB4D698")]
	public particleColorChanger_cp()
	{
	}
}
[Token(Token = "0x2000142")]
public class UIAue : MonoBehaviour
{
	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UIModuleSO so;

	[Token(Token = "0x6000855")]
	[Address(RVA = "0xB4D6A8", Offset = "0xB4D6A8", VA = "0xB4D6A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0xB4D6AC", Offset = "0xB4D6AC", VA = "0xB4D6AC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0xB4D6B0", Offset = "0xB4D6B0", VA = "0xB4D6B0")]
	public UIAue()
	{
	}
}
[Token(Token = "0x2000143")]
public class PairSort
{
	[Token(Token = "0x1700017F")]
	public GameObject obj
	{
		[Token(Token = "0x6000858")]
		[Address(RVA = "0xB4D6B8", Offset = "0xB4D6B8", VA = "0xB4D6B8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6000859")]
		[Address(RVA = "0xB4D6C0", Offset = "0xB4D6C0", VA = "0xB4D6C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000180")]
	public float sort
	{
		[Token(Token = "0x600085A")]
		[Address(RVA = "0xB4D6C8", Offset = "0xB4D6C8", VA = "0xB4D6C8")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600085B")]
		[Address(RVA = "0xB4D6D0", Offset = "0xB4D6D0", VA = "0xB4D6D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0xB4D6D8", Offset = "0xB4D6D8", VA = "0xB4D6D8")]
	public PairSort(GameObject obj, float sort)
	{
	}
}
[Token(Token = "0x2000144")]
public class TimeTool : MonoBehaviour
{
	[Token(Token = "0x600085D")]
	[Address(RVA = "0xB4D71C", Offset = "0xB4D71C", VA = "0xB4D71C")]
	public static long ConvertDateTimep(DateTime time)
	{
		return default(long);
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0xB4D780", Offset = "0xB4D780", VA = "0xB4D780")]
	public static DateTime GetTime(string timeStamp)
	{
		return default(DateTime);
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0xB4D864", Offset = "0xB4D864", VA = "0xB4D864")]
	public TimeTool()
	{
	}
}
[Token(Token = "0x2000145")]
public class HideBulletController : MonoBehaviour
{
	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AudioCue audioCue;

	[Token(Token = "0x6000860")]
	[Address(RVA = "0xB4D86C", Offset = "0xB4D86C", VA = "0xB4D86C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0xB4D8C4", Offset = "0xB4D8C4", VA = "0xB4D8C4")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0xB4D9DC", Offset = "0xB4D9DC", VA = "0xB4D9DC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0xB4DB08", Offset = "0xB4DB08", VA = "0xB4DB08")]
	public HideBulletController()
	{
	}
}
[Token(Token = "0x2000146")]
public class MinorHandShieldController : MonoBehaviour
{
	[Token(Token = "0x2000147")]
	[CompilerGenerated]
	private sealed class <KeepSecond>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000798")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000799")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400079A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MinorHandShieldController <>4__this;

		[Token(Token = "0x400079B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ShieldDataSO so;

		[Token(Token = "0x17000181")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xB4EDE0", Offset = "0xB4EDE0", VA = "0xB4EDE0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000182")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000872")]
			[Address(RVA = "0xB4EE28", Offset = "0xB4EE28", VA = "0xB4EE28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xB4EBF0", Offset = "0xB4EBF0", VA = "0xB4EBF0")]
		[DebuggerHidden]
		public <KeepSecond>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600086E")]
		[Address(RVA = "0xB4EC90", Offset = "0xB4EC90", VA = "0xB4EC90", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xB4EC94", Offset = "0xB4EC94", VA = "0xB4EC94", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xB4EDE8", Offset = "0xB4EDE8", VA = "0xB4EDE8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRController MinorController;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator ani;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject Shield;

	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SwitchBombVFX;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	public ShieldDataSO so;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public ShieldEventSO _event;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private AudioCue audioCue;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshProUGUI SecondText;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool isShield;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool isFlashLight;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject Ipad;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool isPad;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float PadTimer;

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public TextMeshProUGUI padTitleText;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public TextMeshProUGUI padText;

	[Token(Token = "0x4000795")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public TextMeshProUGUI padClose;

	[Token(Token = "0x4000796")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Image padImg;

	[Token(Token = "0x4000797")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private GameObject FlashLightObj;

	[Token(Token = "0x6000864")]
	[Address(RVA = "0xB4DB10", Offset = "0xB4DB10", VA = "0xB4DB10")]
	private void Start()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0xB4DC5C", Offset = "0xB4DC5C", VA = "0xB4DC5C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0xB4DD44", Offset = "0xB4DD44", VA = "0xB4DD44")]
	private void Update()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0xB4E898", Offset = "0xB4E898", VA = "0xB4E898")]
	public void GainShield(ShieldDataSO so)
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0xB4EB68", Offset = "0xB4EB68", VA = "0xB4EB68")]
	public void setFlashLight(bool FlashLight)
	{
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0xB4DFA0", Offset = "0xB4DFA0", VA = "0xB4DFA0")]
	public void setPad(bool pad)
	{
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0xB4EAD8", Offset = "0xB4EAD8", VA = "0xB4EAD8")]
	[IteratorStateMachine(typeof(<KeepSecond>d__24))]
	private IEnumerator KeepSecond(ShieldDataSO so)
	{
		return null;
	}

	[Token(Token = "0x600086B")]
	[Address(RVA = "0xB4EC18", Offset = "0xB4EC18", VA = "0xB4EC18")]
	private void DestoryShield()
	{
	}

	[Token(Token = "0x600086C")]
	[Address(RVA = "0xB4EC88", Offset = "0xB4EC88", VA = "0xB4EC88")]
	public MinorHandShieldController()
	{
	}
}
[Token(Token = "0x2000148")]
public class PrimaryHandGunController : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000149")]
	public class projectile
	{
		[Token(Token = "0x40007C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Rigidbody bombPrefab;

		[Token(Token = "0x40007CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject muzzleflare;

		[Token(Token = "0x40007CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject shellPrefab;

		[Token(Token = "0x600088F")]
		[Address(RVA = "0xB51774", Offset = "0xB51774", VA = "0xB51774")]
		public projectile()
		{
		}
	}

	[Token(Token = "0x200014A")]
	public enum WeaponType
	{
		[Token(Token = "0x40007CD")]
		M1911,
		[Token(Token = "0x40007CE")]
		M1912,
		[Token(Token = "0x40007CF")]
		AK,
		[Token(Token = "0x40007D0")]
		Assault,
		[Token(Token = "0x40007D1")]
		Sniper,
		[Token(Token = "0x40007D2")]
		Shotgun,
		[Token(Token = "0x40007D3")]
		Assault3,
		[Token(Token = "0x40007D4")]
		Smg
	}

	[Serializable]
	[Token(Token = "0x200014B")]
	public struct WeaponStruct
	{
		[Token(Token = "0x40007D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WeaponType weaponType;

		[Token(Token = "0x40007D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public WeaponDataSO so;
	}

	[Token(Token = "0x200014C")]
	[CompilerGenerated]
	private sealed class <fire>d__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrimaryHandGunController <>4__this;

		[Token(Token = "0x17000183")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000893")]
			[Address(RVA = "0xB51B24", Offset = "0xB51B24", VA = "0xB51B24", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000184")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000895")]
			[Address(RVA = "0xB51B6C", Offset = "0xB51B6C", VA = "0xB51B6C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000890")]
		[Address(RVA = "0xB4FFC4", Offset = "0xB4FFC4", VA = "0xB4FFC4")]
		[DebuggerHidden]
		public <fire>d__55(int <>1__state)
		{
		}

		[Token(Token = "0x6000891")]
		[Address(RVA = "0xB5177C", Offset = "0xB5177C", VA = "0xB5177C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000892")]
		[Address(RVA = "0xB51780", Offset = "0xB51780", VA = "0xB51780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000894")]
		[Address(RVA = "0xB51B2C", Offset = "0xB51B2C", VA = "0xB51B2C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014D")]
	[CompilerGenerated]
	private sealed class <fireBulletWeapon>d__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrimaryHandGunController <>4__this;

		[Token(Token = "0x17000185")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000899")]
			[Address(RVA = "0xB51C84", Offset = "0xB51C84", VA = "0xB51C84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000186")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600089B")]
			[Address(RVA = "0xB51CCC", Offset = "0xB51CCC", VA = "0xB51CCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000896")]
		[Address(RVA = "0xB512AC", Offset = "0xB512AC", VA = "0xB512AC")]
		[DebuggerHidden]
		public <fireBulletWeapon>d__60(int <>1__state)
		{
		}

		[Token(Token = "0x6000897")]
		[Address(RVA = "0xB51B74", Offset = "0xB51B74", VA = "0xB51B74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000898")]
		[Address(RVA = "0xB51B78", Offset = "0xB51B78", VA = "0xB51B78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600089A")]
		[Address(RVA = "0xB51C8C", Offset = "0xB51C8C", VA = "0xB51C8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014E")]
	[CompilerGenerated]
	private sealed class <ReloadBullets>d__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrimaryHandGunController <>4__this;

		[Token(Token = "0x17000187")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600089F")]
			[Address(RVA = "0xB51D84", Offset = "0xB51D84", VA = "0xB51D84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000188")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A1")]
			[Address(RVA = "0xB51DCC", Offset = "0xB51DCC", VA = "0xB51DCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600089C")]
		[Address(RVA = "0xB512D4", Offset = "0xB512D4", VA = "0xB512D4")]
		[DebuggerHidden]
		public <ReloadBullets>d__61(int <>1__state)
		{
		}

		[Token(Token = "0x600089D")]
		[Address(RVA = "0xB51CD4", Offset = "0xB51CD4", VA = "0xB51CD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600089E")]
		[Address(RVA = "0xB51CD8", Offset = "0xB51CD8", VA = "0xB51CD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xB51D8C", Offset = "0xB51D8C", VA = "0xB51D8C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014F")]
	[CompilerGenerated]
	private sealed class <ReloadBulletIEnum>d__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PrimaryHandGunController <>4__this;

		[Token(Token = "0x17000189")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008A5")]
			[Address(RVA = "0xB51F34", Offset = "0xB51F34", VA = "0xB51F34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008A7")]
			[Address(RVA = "0xB51F7C", Offset = "0xB51F7C", VA = "0xB51F7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008A2")]
		[Address(RVA = "0xB51370", Offset = "0xB51370", VA = "0xB51370")]
		[DebuggerHidden]
		public <ReloadBulletIEnum>d__62(int <>1__state)
		{
		}

		[Token(Token = "0x60008A3")]
		[Address(RVA = "0xB51DD4", Offset = "0xB51DD4", VA = "0xB51DD4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008A4")]
		[Address(RVA = "0xB51DD8", Offset = "0xB51DD8", VA = "0xB51DD8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008A6")]
		[Address(RVA = "0xB51F3C", Offset = "0xB51F3C", VA = "0xB51F3C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400079C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRController PrimaryController;

	[Token(Token = "0x400079D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject minorHand;

	[Token(Token = "0x400079E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float fireCD;

	[Token(Token = "0x400079F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public float ShotForce;

	[Token(Token = "0x40007A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int bulletNum;

	[Token(Token = "0x40007A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public int bulletMaxNum;

	[Token(Token = "0x40007A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public LayerMask ValidLayers;

	[Token(Token = "0x40007A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public LayerMask UIValidLayers;

	[Token(Token = "0x40007A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject weaponObj;

	[Token(Token = "0x40007A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string weaponType;

	[Token(Token = "0x40007A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string weapon;

	[Token(Token = "0x40007A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TextMeshProUGUI bulletNumStr;

	[Token(Token = "0x40007A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private string DefaultWeapon;

	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public GameObject SwitchBombVFX;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform spawnLocatorMuzzleFlare;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform shellLocator;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform spawnLocator;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform shotgunLocator;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public projectile bomb;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Rigidbody HideBullet;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float min;

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private float max;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Transform IncludeLeftHand;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool isShowLeftHand;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[SerializeField]
	public ShieldDataSO shieldSO;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[SerializeField]
	public ShieldEventSO shieldEventSO;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[SerializeField]
	private UIModuleEventSO _eventSO;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private bool isReLoad;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
	private bool isFire;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private float DisLeftHand;

	[Token(Token = "0x40007BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private AudioCue audioCue;

	[Token(Token = "0x40007BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Animator ani;

	[Token(Token = "0x40007BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private int weaponSoundIndex;

	[Token(Token = "0x40007BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public WeaponStruct[] weapons;

	[Token(Token = "0x40007C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Dictionary<WeaponType, WeaponDataSO> WeaponDict;

	[Token(Token = "0x40007C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private int gun;

	[Token(Token = "0x40007C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public LineRenderer rayLine;

	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public Transform gunEnd;

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public Transform FireEnd;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private string hitAniName;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool isClick;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x139")]
	private bool isRay;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Header("事件处理")]
	private UIEventHandler UIEvent;

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xB4EE30", Offset = "0xB4EE30", VA = "0xB4EE30")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xB4EF18", Offset = "0xB4EF18", VA = "0xB4EF18")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0xB4F000", Offset = "0xB4F000", VA = "0xB4F000")]
	private void Start()
	{
	}

	[Token(Token = "0x6000876")]
	[Address(RVA = "0xB4F0C0", Offset = "0xB4F0C0", VA = "0xB4F0C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000877")]
	[Address(RVA = "0xB4FF70", Offset = "0xB4FF70", VA = "0xB4FF70")]
	public void setIsRay(bool ray)
	{
	}

	[Token(Token = "0x6000878")]
	[Address(RVA = "0xB4FAE8", Offset = "0xB4FAE8", VA = "0xB4FAE8")]
	private void RayHIt()
	{
	}

	[Token(Token = "0x6000879")]
	[Address(RVA = "0xB4FF98", Offset = "0xB4FF98", VA = "0xB4FF98")]
	public void InitDefaultWeapon(string weapon)
	{
	}

	[Token(Token = "0x600087A")]
	[Address(RVA = "0xB4F7D8", Offset = "0xB4F7D8", VA = "0xB4F7D8")]
	[IteratorStateMachine(typeof(<fire>d__55))]
	private IEnumerator fire()
	{
		return null;
	}

	[Token(Token = "0x600087B")]
	[Address(RVA = "0xB4FE80", Offset = "0xB4FE80", VA = "0xB4FE80")]
	public void InstallWeapon(string weapon)
	{
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0xB4FFEC", Offset = "0xB4FFEC", VA = "0xB4FFEC")]
	public void clearWeapon()
	{
	}

	[Token(Token = "0x600087D")]
	[Address(RVA = "0xB500B8", Offset = "0xB500B8", VA = "0xB500B8")]
	private void ReInitWeapon(WeaponDataSO so)
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0xB506D0", Offset = "0xB506D0", VA = "0xB506D0")]
	public void FireShot(Transform firePoint)
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0xB51238", Offset = "0xB51238", VA = "0xB51238")]
	[IteratorStateMachine(typeof(<fireBulletWeapon>d__60))]
	private IEnumerator fireBulletWeapon()
	{
		return null;
	}

	[Token(Token = "0x6000880")]
	[Address(RVA = "0xB4F86C", Offset = "0xB4F86C", VA = "0xB4F86C")]
	[IteratorStateMachine(typeof(<ReloadBullets>d__61))]
	private IEnumerator ReloadBullets()
	{
		return null;
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0xB512FC", Offset = "0xB512FC", VA = "0xB512FC")]
	[IteratorStateMachine(typeof(<ReloadBulletIEnum>d__62))]
	private IEnumerator ReloadBulletIEnum()
	{
		return null;
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0xB4F84C", Offset = "0xB4F84C", VA = "0xB4F84C")]
	private void NoBullet()
	{
	}

	[Token(Token = "0x6000883")]
	[Address(RVA = "0xB51398", Offset = "0xB51398", VA = "0xB51398")]
	private void DropShell()
	{
	}

	[Token(Token = "0x6000884")]
	[Address(RVA = "0xB513DC", Offset = "0xB513DC", VA = "0xB513DC")]
	public void showWeapon()
	{
	}

	[Token(Token = "0x6000885")]
	[Address(RVA = "0xB51464", Offset = "0xB51464", VA = "0xB51464")]
	public void hideWeapon()
	{
	}

	[Token(Token = "0x6000886")]
	[Address(RVA = "0xB4F8E0", Offset = "0xB4F8E0", VA = "0xB4F8E0")]
	private void CheckLeftHand()
	{
	}

	[Token(Token = "0x6000887")]
	[Address(RVA = "0xB5153C", Offset = "0xB5153C", VA = "0xB5153C")]
	public void ShowLeftHandHoldWeapon()
	{
	}

	[Token(Token = "0x6000888")]
	[Address(RVA = "0xB51598", Offset = "0xB51598", VA = "0xB51598")]
	public void HideLeftHandHoldWeapon()
	{
	}

	[Token(Token = "0x6000889")]
	[Address(RVA = "0xB50504", Offset = "0xB50504", VA = "0xB50504")]
	public void Init_Animator()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0xB515F0", Offset = "0xB515F0", VA = "0xB515F0")]
	private void handleSO(UIModuleSO so)
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0xB4F74C", Offset = "0xB4F74C", VA = "0xB4F74C")]
	private void clickUI(UIModuleSO so)
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0xB51698", Offset = "0xB51698", VA = "0xB51698")]
	private void PauseContinue()
	{
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0xB516A0", Offset = "0xB516A0", VA = "0xB516A0")]
	private void GameOver()
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0xB516A8", Offset = "0xB516A8", VA = "0xB516A8")]
	public PrimaryHandGunController()
	{
	}
}
[Token(Token = "0x2000150")]
public class ShieldController : MonoBehaviour
{
	[Token(Token = "0x40007E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioCue audioCue;

	[Token(Token = "0x40007E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public XRController MinorController;

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0xB51F84", Offset = "0xB51F84", VA = "0xB51F84")]
	private void Start()
	{
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0xB51FDC", Offset = "0xB51FDC", VA = "0xB51FDC")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0xB52088", Offset = "0xB52088", VA = "0xB52088")]
	public void TriggerEnter()
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0xB520E8", Offset = "0xB520E8", VA = "0xB520E8")]
	public ShieldController()
	{
	}
}
[Token(Token = "0x2000151")]
public class WeaponIconSwitchController : MonoBehaviour
{
	[Token(Token = "0x2000152")]
	private enum SelfAxis
	{
		[Token(Token = "0x40007ED")]
		X,
		[Token(Token = "0x40007EE")]
		Y,
		[Token(Token = "0x40007EF")]
		Z
	}

	[Token(Token = "0x40007E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string weapon;

	[Token(Token = "0x40007E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool isOpen;

	[Token(Token = "0x40007E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int speed;

	[Token(Token = "0x40007E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Transform targetTran;

	[Token(Token = "0x40007E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool isMove;

	[Token(Token = "0x40007EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform QuanTran;

	[Token(Token = "0x40007EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform WeaponTran;

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0xB520F0", Offset = "0xB520F0", VA = "0xB520F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0xB520F4", Offset = "0xB520F4", VA = "0xB520F4")]
	[Obsolete]
	public void initWeapon(string weapon)
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0xB520F8", Offset = "0xB520F8", VA = "0xB520F8")]
	private void Update()
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0xB52144", Offset = "0xB52144", VA = "0xB52144")]
	private void QuanRotateAxisOfSelf(SelfAxis selfAxis, int speed = 2)
	{
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0xB521E4", Offset = "0xB521E4", VA = "0xB521E4")]
	private void WeaponRotateAxisOfSelf(SelfAxis selfAxis, int speed = 2)
	{
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0xB47458", Offset = "0xB47458", VA = "0xB47458")]
	public string MoveTarget(Transform targetTran)
	{
		return null;
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0xB52284", Offset = "0xB52284", VA = "0xB52284")]
	private void Move()
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0xB523F4", Offset = "0xB523F4", VA = "0xB523F4")]
	public WeaponIconSwitchController()
	{
	}
}
[Token(Token = "0x2000153")]
public class XRPlayerController : MonoBehaviour
{
	[Token(Token = "0x2000154")]
	[CompilerGenerated]
	private sealed class <MinorInjury>d__67 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000826")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000827")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000828")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRPlayerController <>4__this;

		[Token(Token = "0x1700018B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008E1")]
			[Address(RVA = "0xB540F8", Offset = "0xB540F8", VA = "0xB540F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E3")]
			[Address(RVA = "0xB54140", Offset = "0xB54140", VA = "0xB54140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008DE")]
		[Address(RVA = "0xB536D4", Offset = "0xB536D4", VA = "0xB536D4")]
		[DebuggerHidden]
		public <MinorInjury>d__67(int <>1__state)
		{
		}

		[Token(Token = "0x60008DF")]
		[Address(RVA = "0xB5407C", Offset = "0xB5407C", VA = "0xB5407C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E0")]
		[Address(RVA = "0xB54080", Offset = "0xB54080", VA = "0xB54080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xB54100", Offset = "0xB54100", VA = "0xB54100", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000155")]
	[CompilerGenerated]
	private sealed class <SeriousInjury>d__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000829")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400082A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400082B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRPlayerController <>4__this;

		[Token(Token = "0x400082C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <f>5__2;

		[Token(Token = "0x1700018D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008E7")]
			[Address(RVA = "0xB544C8", Offset = "0xB544C8", VA = "0xB544C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700018E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008E9")]
			[Address(RVA = "0xB54510", Offset = "0xB54510", VA = "0xB54510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xB536FC", Offset = "0xB536FC", VA = "0xB536FC")]
		[DebuggerHidden]
		public <SeriousInjury>d__68(int <>1__state)
		{
		}

		[Token(Token = "0x60008E5")]
		[Address(RVA = "0xB54148", Offset = "0xB54148", VA = "0xB54148", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008E6")]
		[Address(RVA = "0xB5414C", Offset = "0xB5414C", VA = "0xB5414C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008E8")]
		[Address(RVA = "0xB544D0", Offset = "0xB544D0", VA = "0xB544D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000156")]
	[CompilerGenerated]
	private sealed class <talkStr>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400082D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400082E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400082F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x4000830")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string talk;

		[Token(Token = "0x4000831")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public XRPlayerController <>4__this;

		[Token(Token = "0x1700018F")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008ED")]
			[Address(RVA = "0xB545D8", Offset = "0xB545D8", VA = "0xB545D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000190")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008EF")]
			[Address(RVA = "0xB54620", Offset = "0xB54620", VA = "0xB54620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008EA")]
		[Address(RVA = "0xB53AFC", Offset = "0xB53AFC", VA = "0xB53AFC")]
		[DebuggerHidden]
		public <talkStr>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60008EB")]
		[Address(RVA = "0xB54518", Offset = "0xB54518", VA = "0xB54518", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008EC")]
		[Address(RVA = "0xB5451C", Offset = "0xB5451C", VA = "0xB5451C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008EE")]
		[Address(RVA = "0xB545E0", Offset = "0xB545E0", VA = "0xB545E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000157")]
	[CompilerGenerated]
	private sealed class <TypeText>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000832")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000833")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000834")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public XRPlayerController <>4__this;

		[Token(Token = "0x4000835")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x4000836")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private char[] <>7__wrap1;

		[Token(Token = "0x4000837")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int <>7__wrap2;

		[Token(Token = "0x17000191")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008F3")]
			[Address(RVA = "0xB547EC", Offset = "0xB547EC", VA = "0xB547EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000192")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008F5")]
			[Address(RVA = "0xB54834", Offset = "0xB54834", VA = "0xB54834", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008F0")]
		[Address(RVA = "0xB53BD0", Offset = "0xB53BD0", VA = "0xB53BD0")]
		[DebuggerHidden]
		public <TypeText>d__78(int <>1__state)
		{
		}

		[Token(Token = "0x60008F1")]
		[Address(RVA = "0xB54628", Offset = "0xB54628", VA = "0xB54628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008F2")]
		[Address(RVA = "0xB5462C", Offset = "0xB5462C", VA = "0xB5462C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0xB547F4", Offset = "0xB547F4", VA = "0xB547F4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("左右手 / 正副手")]
	public GameObject RightController_Primary;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject RightHand_Primary;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject LeftController_Minor;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand_Minor;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public XRController RightRay_Primary;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject LeftMinorLight;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject LeftController_Primay;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject LeftHand_Primary;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public GameObject RightController_Minor;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public GameObject RightHand_Minor;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public XRController LeftRay_Primary;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject RightMinorLight;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private XRController PimaryXRController;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private XRController MinorXRController;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject PimaryHand;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private XRController MinorRay;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private GameObject MinorHand;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private PrimaryHandGunController PrimaryHandGunController;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private MinorHandShieldController MinorHandShieldController;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[Header("启动个人配置")]
	public GameObject cameraObj;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Camera XRcamera;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public float gravity;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private float speed;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public CharacterController controller;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool isStart;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	private bool isFeight;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public TextMeshProUGUI hudText;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private float printCD;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public AudioSource audioSource;

	[Token(Token = "0x400080D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private XRBGMController xRBGMController;

	[Token(Token = "0x400080E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Transform HurtLine;

	[Token(Token = "0x400080F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Transform ThisTransform;

	[Token(Token = "0x4000810")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	[Header("UI")]
	public Image Sure;

	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextMeshProUGUI Skip;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Image Tip;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool isPause;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[Header("SO")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	[SerializeField]
	public PlayerEventSO _playerEventSO;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[SerializeField]
	public UIModuleEventSO _UIEventSO;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	[Header("声音")]
	public AudioCue audioCuePlayer;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public AudioCue audioCueHeroine;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public UIModuleSO UIModelSo;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	[Header("Teleport Ray")]
	private bool activated;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private GameObject[] TeleportAreas;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool isOpen;

	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x169")]
	private bool isTeleport;

	[Token(Token = "0x400081E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Transform cameraObjTransform;

	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	[Header("XR")]
	public LayerMask GroupValidLayers;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public Transform Offset;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	public TextMeshProUGUI Tishe;

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	public XRRig rig;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Vector3 moveDirection;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A4")]
	private float TeleportTimer;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private float TeleMoveTimer;

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0xB52404", Offset = "0xB52404", VA = "0xB52404")]
	private void Start()
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0xB5252C", Offset = "0xB5252C", VA = "0xB5252C")]
	private void InitHand()
	{
	}

	[Token(Token = "0x60008B6")]
	[Address(RVA = "0xB52878", Offset = "0xB52878", VA = "0xB52878")]
	private void initSO()
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0xB52908", Offset = "0xB52908", VA = "0xB52908")]
	private void initRay()
	{
	}

	[Token(Token = "0x60008B8")]
	[Address(RVA = "0xB5290C", Offset = "0xB5290C", VA = "0xB5290C")]
	private void InitUI()
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0xB52B6C", Offset = "0xB52B6C", VA = "0xB52B6C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0xB52C58", Offset = "0xB52C58", VA = "0xB52C58")]
	private void Move()
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0xB52EB4", Offset = "0xB52EB4", VA = "0xB52EB4")]
	private void RemoteMove()
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0xB531CC", Offset = "0xB531CC", VA = "0xB531CC")]
	private bool checkOnTeleport()
	{
		return default(bool);
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0xB530E0", Offset = "0xB530E0", VA = "0xB530E0")]
	private void CapsuleFollowHeadset()
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0xB531D4", Offset = "0xB531D4", VA = "0xB531D4")]
	public void SetInitPos(Vector3 tarV, Vector3 RotateV)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0xB52DA8", Offset = "0xB52DA8", VA = "0xB52DA8")]
	private bool TeleportMove()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0xB5329C", Offset = "0xB5329C", VA = "0xB5329C")]
	public void HpHurt(int atk)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0xB534B4", Offset = "0xB534B4", VA = "0xB534B4")]
	[IteratorStateMachine(typeof(<MinorInjury>d__67))]
	private IEnumerator MinorInjury()
	{
		return null;
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0xB53528", Offset = "0xB53528", VA = "0xB53528")]
	[IteratorStateMachine(typeof(<SeriousInjury>d__68))]
	private IEnumerator SeriousInjury()
	{
		return null;
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0xB5341C", Offset = "0xB5341C", VA = "0xB5341C")]
	private void hurtVoice()
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0xB53724", Offset = "0xB53724", VA = "0xB53724")]
	private void replenishHp()
	{
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0xB537B4", Offset = "0xB537B4", VA = "0xB537B4")]
	public bool getXRKeyA()
	{
		return default(bool);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0xB53850", Offset = "0xB53850", VA = "0xB53850")]
	public void setXRWeapon(string weapon)
	{
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0xB538EC", Offset = "0xB538EC", VA = "0xB538EC")]
	public void holdFight()
	{
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0xB539D0", Offset = "0xB539D0", VA = "0xB539D0")]
	public void setFeight(bool f)
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0xB539DC", Offset = "0xB539DC", VA = "0xB539DC")]
	public void overFight()
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0xB53A58", Offset = "0xB53A58", VA = "0xB53A58")]
	[IteratorStateMachine(typeof(<talkStr>d__76))]
	public IEnumerator talkStr(string talk, AudioClip clip)
	{
		return null;
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0xB53B24", Offset = "0xB53B24", VA = "0xB53B24")]
	public void playAudio(AudioClip clip)
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0xB53B40", Offset = "0xB53B40", VA = "0xB53B40")]
	[IteratorStateMachine(typeof(<TypeText>d__78))]
	private IEnumerator TypeText(string msg)
	{
		return null;
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0xB53974", Offset = "0xB53974", VA = "0xB53974")]
	public void cleanTalkText()
	{
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0xB53BF8", Offset = "0xB53BF8", VA = "0xB53BF8")]
	public void setBlack()
	{
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0xB53C60", Offset = "0xB53C60", VA = "0xB53C60")]
	public void cancelBlack()
	{
	}

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0xB53CC4", Offset = "0xB53CC4", VA = "0xB53CC4")]
	public void StopAll()
	{
	}

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0xB52CCC", Offset = "0xB52CCC", VA = "0xB52CCC")]
	public void Pause()
	{
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0xB53CEC", Offset = "0xB53CEC", VA = "0xB53CEC")]
	private void RecoverPause()
	{
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0xB53CF4", Offset = "0xB53CF4", VA = "0xB53CF4")]
	public void Contiune()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0xB5359C", Offset = "0xB5359C", VA = "0xB5359C")]
	public void GameOver(string str)
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0xB53D28", Offset = "0xB53D28", VA = "0xB53D28")]
	public void PlayBgmIndex(int index, float volume, bool loop)
	{
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0xB53E00", Offset = "0xB53E00", VA = "0xB53E00")]
	public void PlayWinImg(int level)
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0xB53F08", Offset = "0xB53F08", VA = "0xB53F08")]
	public void Win()
	{
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0xB531F0", Offset = "0xB531F0", VA = "0xB531F0")]
	public bool CheckIfActivated(XRController controller)
	{
		return default(bool);
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0xB53F4C", Offset = "0xB53F4C", VA = "0xB53F4C")]
	public void setMinorLight(bool light)
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0xB53F68", Offset = "0xB53F68", VA = "0xB53F68")]
	public void setPad(bool ipad)
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0xB53F84", Offset = "0xB53F84", VA = "0xB53F84")]
	public void ClosePad()
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0xB53FA0", Offset = "0xB53FA0", VA = "0xB53FA0")]
	public void DelayClosePad(int second)
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0xB53FFC", Offset = "0xB53FFC", VA = "0xB53FFC")]
	public XRPlayerController()
	{
	}
}
[Token(Token = "0x2000158")]
public class XRPlayerGUIController : MonoBehaviour
{
	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[Header("左右手 / 正副手")]
	public GameObject RightController_Primary;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject RightHand_Primary;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject LeftController_Minor;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject LeftHand_Minor;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject LeftController_Primay;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject LeftHand_Primary;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject RightController_Minor;

	[Token(Token = "0x400083F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public GameObject RightHand_Minor;

	[Token(Token = "0x4000840")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private XRController PimaryXRController;

	[Token(Token = "0x4000841")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private XRController MinorXRController;

	[Token(Token = "0x4000842")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject PimaryHand;

	[Token(Token = "0x4000843")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject MinorHand;

	[Token(Token = "0x4000844")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public CharacterController controller;

	[Token(Token = "0x4000845")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AudioSource audioSource;

	[Token(Token = "0x4000846")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private XRBGMController xRBGMController;

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	public LeftHandEventSO _LeftHandEventSO;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	public PlayerDataSO playerDataSO;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Vector3 moveDirection;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public GameObject cameraObj;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public XRRig rig;

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0xB5483C", Offset = "0xB5483C", VA = "0xB5483C")]
	private void Start()
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0xB54A90", Offset = "0xB54A90", VA = "0xB54A90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0xB54A00", Offset = "0xB54A00", VA = "0xB54A00")]
	private void initSO()
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0xB54B78", Offset = "0xB54B78", VA = "0xB54B78")]
	private void HoldLeftHand(LeftHandModelSO so)
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0xB54940", Offset = "0xB54940", VA = "0xB54940")]
	private void InitHand()
	{
	}

	[Token(Token = "0x60008FB")]
	[Address(RVA = "0xB54B7C", Offset = "0xB54B7C", VA = "0xB54B7C")]
	public void hideHand()
	{
	}

	[Token(Token = "0x60008FC")]
	[Address(RVA = "0xB54BDC", Offset = "0xB54BDC", VA = "0xB54BDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60008FD")]
	[Address(RVA = "0xB54BE0", Offset = "0xB54BE0", VA = "0xB54BE0")]
	private void CapsuleFollowHeadset()
	{
	}

	[Token(Token = "0x60008FE")]
	[Address(RVA = "0xB54CCC", Offset = "0xB54CCC", VA = "0xB54CCC")]
	public void SetInitPos(Vector3 tarV, Vector3 RotateV)
	{
	}

	[Token(Token = "0x60008FF")]
	[Address(RVA = "0xB54CE8", Offset = "0xB54CE8", VA = "0xB54CE8")]
	public XRPlayerGUIController()
	{
	}
}
[Token(Token = "0x2000159")]
public class XRRoundController : MonoBehaviour
{
	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private AudioCue aue;

	[Token(Token = "0x6000900")]
	[Address(RVA = "0xB54D48", Offset = "0xB54D48", VA = "0xB54D48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000901")]
	[Address(RVA = "0xB54DA0", Offset = "0xB54DA0", VA = "0xB54DA0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000902")]
	[Address(RVA = "0xB54E30", Offset = "0xB54E30", VA = "0xB54E30")]
	public XRRoundController()
	{
	}
}
[Token(Token = "0x200015A")]
public class ChatController : MonoBehaviour
{
	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TMP_InputField ChatInputField;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TMP_Text ChatDisplayOutput;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Scrollbar ChatScrollbar;

	[Token(Token = "0x6000903")]
	[Address(RVA = "0xB54E38", Offset = "0xB54E38", VA = "0xB54E38")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000904")]
	[Address(RVA = "0xB54EE0", Offset = "0xB54EE0", VA = "0xB54EE0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000905")]
	[Address(RVA = "0xB54F88", Offset = "0xB54F88", VA = "0xB54F88")]
	private void AddToChatOutput(string newText)
	{
	}

	[Token(Token = "0x6000906")]
	[Address(RVA = "0xB55430", Offset = "0xB55430", VA = "0xB55430")]
	public ChatController()
	{
	}
}
[Token(Token = "0x200015B")]
public class DropdownSample : MonoBehaviour
{
	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI text;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TMP_Dropdown dropdownWithoutPlaceholder;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Dropdown dropdownWithPlaceholder;

	[Token(Token = "0x6000907")]
	[Address(RVA = "0xB55438", Offset = "0xB55438", VA = "0xB55438")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6000908")]
	[Address(RVA = "0xB55540", Offset = "0xB55540", VA = "0xB55540")]
	public DropdownSample()
	{
	}
}
[Token(Token = "0x200015C")]
public class EnvMapAnimator : MonoBehaviour
{
	[Token(Token = "0x200015D")]
	[CompilerGenerated]
	private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000856")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000857")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000858")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EnvMapAnimator <>4__this;

		[Token(Token = "0x4000859")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Matrix4x4 <matrix>5__2;

		[Token(Token = "0x17000193")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600090F")]
			[Address(RVA = "0xB55888", Offset = "0xB55888", VA = "0xB55888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000194")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000911")]
			[Address(RVA = "0xB558D0", Offset = "0xB558D0", VA = "0xB558D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600090C")]
		[Address(RVA = "0xB55644", Offset = "0xB55644", VA = "0xB55644")]
		[DebuggerHidden]
		public <Start>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600090D")]
		[Address(RVA = "0xB55674", Offset = "0xB55674", VA = "0xB55674", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600090E")]
		[Address(RVA = "0xB55678", Offset = "0xB55678", VA = "0xB55678", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000910")]
		[Address(RVA = "0xB55890", Offset = "0xB55890", VA = "0xB55890", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3 RotationSpeeds;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TMP_Text m_textMeshPro;

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material m_material;

	[Token(Token = "0x6000909")]
	[Address(RVA = "0xB55548", Offset = "0xB55548", VA = "0xB55548")]
	private void Awake()
	{
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0xB555D0", Offset = "0xB555D0", VA = "0xB555D0")]
	[IteratorStateMachine(typeof(<Start>d__4))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0xB5566C", Offset = "0xB5566C", VA = "0xB5566C")]
	public EnvMapAnimator()
	{
	}
}
namespace TMPro
{
	[Serializable]
	[Token(Token = "0x200015E")]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000912")]
		[Address(RVA = "0xB558D8", Offset = "0xB558D8", VA = "0xB558D8", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000913")]
		[Address(RVA = "0xB55958", Offset = "0xB55958", VA = "0xB55958")]
		public TMP_DigitValidator()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200015F")]
	public class TMP_PhoneNumberValidator : TMP_InputValidator
	{
		[Token(Token = "0x6000914")]
		[Address(RVA = "0xB55960", Offset = "0xB55960", VA = "0xB55960", Slot = "4")]
		public override char Validate(ref string text, ref int pos, char ch)
		{
			return default(char);
		}

		[Token(Token = "0x6000915")]
		[Address(RVA = "0xB55DD4", Offset = "0xB55DD4", VA = "0xB55DD4")]
		public TMP_PhoneNumberValidator()
		{
		}
	}
	[Token(Token = "0x2000160")]
	public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Serializable]
		[Token(Token = "0x2000161")]
		public class CharacterSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600092A")]
			[Address(RVA = "0xB56818", Offset = "0xB56818", VA = "0xB56818")]
			public CharacterSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000162")]
		public class SpriteSelectionEvent : UnityEvent<char, int>
		{
			[Token(Token = "0x600092B")]
			[Address(RVA = "0xB56860", Offset = "0xB56860", VA = "0xB56860")]
			public SpriteSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000163")]
		public class WordSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600092C")]
			[Address(RVA = "0xB568A8", Offset = "0xB568A8", VA = "0xB568A8")]
			public WordSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000164")]
		public class LineSelectionEvent : UnityEvent<string, int, int>
		{
			[Token(Token = "0x600092D")]
			[Address(RVA = "0xB568F0", Offset = "0xB568F0", VA = "0xB568F0")]
			public LineSelectionEvent()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2000165")]
		public class LinkSelectionEvent : UnityEvent<string, string, int>
		{
			[Token(Token = "0x600092E")]
			[Address(RVA = "0xB56938", Offset = "0xB56938", VA = "0xB56938")]
			public LinkSelectionEvent()
			{
			}
		}

		[Token(Token = "0x400085A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CharacterSelectionEvent m_OnCharacterSelection;

		[Token(Token = "0x400085B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SpriteSelectionEvent m_OnSpriteSelection;

		[Token(Token = "0x400085C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private WordSelectionEvent m_OnWordSelection;

		[Token(Token = "0x400085D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LineSelectionEvent m_OnLineSelection;

		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private LinkSelectionEvent m_OnLinkSelection;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Camera m_Camera;

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private int m_selectedLink;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000864")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private int m_lastWordIndex;

		[Token(Token = "0x4000865")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		private int m_lastLineIndex;

		[Token(Token = "0x17000195")]
		public CharacterSelectionEvent onCharacterSelection
		{
			[Token(Token = "0x6000916")]
			[Address(RVA = "0xB55DDC", Offset = "0xB55DDC", VA = "0xB55DDC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000917")]
			[Address(RVA = "0xB55DE4", Offset = "0xB55DE4", VA = "0xB55DE4")]
			set
			{
			}
		}

		[Token(Token = "0x17000196")]
		public SpriteSelectionEvent onSpriteSelection
		{
			[Token(Token = "0x6000918")]
			[Address(RVA = "0xB55DEC", Offset = "0xB55DEC", VA = "0xB55DEC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000919")]
			[Address(RVA = "0xB55DF4", Offset = "0xB55DF4", VA = "0xB55DF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000197")]
		public WordSelectionEvent onWordSelection
		{
			[Token(Token = "0x600091A")]
			[Address(RVA = "0xB55DFC", Offset = "0xB55DFC", VA = "0xB55DFC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091B")]
			[Address(RVA = "0xB55E04", Offset = "0xB55E04", VA = "0xB55E04")]
			set
			{
			}
		}

		[Token(Token = "0x17000198")]
		public LineSelectionEvent onLineSelection
		{
			[Token(Token = "0x600091C")]
			[Address(RVA = "0xB55E0C", Offset = "0xB55E0C", VA = "0xB55E0C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091D")]
			[Address(RVA = "0xB55E14", Offset = "0xB55E14", VA = "0xB55E14")]
			set
			{
			}
		}

		[Token(Token = "0x17000199")]
		public LinkSelectionEvent onLinkSelection
		{
			[Token(Token = "0x600091E")]
			[Address(RVA = "0xB55E1C", Offset = "0xB55E1C", VA = "0xB55E1C")]
			get
			{
				return null;
			}
			[Token(Token = "0x600091F")]
			[Address(RVA = "0xB55E24", Offset = "0xB55E24", VA = "0xB55E24")]
			set
			{
			}
		}

		[Token(Token = "0x6000920")]
		[Address(RVA = "0xB55E2C", Offset = "0xB55E2C", VA = "0xB55E2C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000921")]
		[Address(RVA = "0xB55FE4", Offset = "0xB55FE4", VA = "0xB55FE4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000922")]
		[Address(RVA = "0xB566B8", Offset = "0xB566B8", VA = "0xB566B8", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000923")]
		[Address(RVA = "0xB566BC", Offset = "0xB566BC", VA = "0xB566BC", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x6000924")]
		[Address(RVA = "0xB5645C", Offset = "0xB5645C", VA = "0xB5645C")]
		private void SendOnCharacterSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000925")]
		[Address(RVA = "0xB564D0", Offset = "0xB564D0", VA = "0xB564D0")]
		private void SendOnSpriteSelection(char character, int characterIndex)
		{
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0xB56544", Offset = "0xB56544", VA = "0xB56544")]
		private void SendOnWordSelection(string word, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0xB565C0", Offset = "0xB565C0", VA = "0xB565C0")]
		private void SendOnLineSelection(string line, int charIndex, int length)
		{
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0xB5663C", Offset = "0xB5663C", VA = "0xB5663C")]
		private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0xB566C0", Offset = "0xB566C0", VA = "0xB566C0")]
		public TMP_TextEventHandler()
		{
		}
	}
}
namespace TMPro.Examples
{
	[Token(Token = "0x2000166")]
	public class Benchmark01 : MonoBehaviour
	{
		[Token(Token = "0x2000167")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01 <>4__this;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700019A")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000934")]
				[Address(RVA = "0xB56FD8", Offset = "0xB56FD8", VA = "0xB56FD8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019B")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000936")]
				[Address(RVA = "0xB57020", Offset = "0xB57020", VA = "0xB57020", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000931")]
			[Address(RVA = "0xB569F4", Offset = "0xB569F4", VA = "0xB569F4")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x6000932")]
			[Address(RVA = "0xB56A24", Offset = "0xB56A24", VA = "0xB56A24", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000933")]
			[Address(RVA = "0xB56A28", Offset = "0xB56A28", VA = "0xB56A28", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000935")]
			[Address(RVA = "0xB56FE0", Offset = "0xB56FE0", VA = "0xB56FE0", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000866")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Font TextMeshFont;

		[Token(Token = "0x4000869")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x400086A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextContainer m_textContainer;

		[Token(Token = "0x400086B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TextMesh m_textMesh;

		[Token(Token = "0x400086C")]
		private const string label01 = "The <#0050FF>count is: </color>{0}";

		[Token(Token = "0x400086D")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x400086E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x400086F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x600092F")]
		[Address(RVA = "0xB56980", Offset = "0xB56980", VA = "0xB56980")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0xB56A1C", Offset = "0xB56A1C", VA = "0xB56A1C")]
		public Benchmark01()
		{
		}
	}
	[Token(Token = "0x2000168")]
	public class Benchmark01_UGUI : MonoBehaviour
	{
		[Token(Token = "0x2000169")]
		[CompilerGenerated]
		private sealed class <Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400087E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400087F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000880")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Benchmark01_UGUI <>4__this;

			[Token(Token = "0x4000881")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <i>5__2;

			[Token(Token = "0x1700019C")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600093C")]
				[Address(RVA = "0xB57564", Offset = "0xB57564", VA = "0xB57564", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019D")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600093E")]
				[Address(RVA = "0xB575AC", Offset = "0xB575AC", VA = "0xB575AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000939")]
			[Address(RVA = "0xB5709C", Offset = "0xB5709C", VA = "0xB5709C")]
			[DebuggerHidden]
			public <Start>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x600093A")]
			[Address(RVA = "0xB570CC", Offset = "0xB570CC", VA = "0xB570CC", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600093B")]
			[Address(RVA = "0xB570D0", Offset = "0xB570D0", VA = "0xB570D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600093D")]
			[Address(RVA = "0xB5756C", Offset = "0xB5756C", VA = "0xB5756C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000874")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int BenchmarkType;

		[Token(Token = "0x4000875")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Canvas canvas;

		[Token(Token = "0x4000876")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TMP_FontAsset TMProFont;

		[Token(Token = "0x4000877")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Font TextMeshFont;

		[Token(Token = "0x4000878")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TextMeshProUGUI m_textMeshPro;

		[Token(Token = "0x4000879")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Text m_textMesh;

		[Token(Token = "0x400087A")]
		private const string label01 = "The <#0050FF>count is: </color>";

		[Token(Token = "0x400087B")]
		private const string label02 = "The <color=#0050FF>count is: </color>";

		[Token(Token = "0x400087C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Material m_material01;

		[Token(Token = "0x400087D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Material m_material02;

		[Token(Token = "0x6000937")]
		[Address(RVA = "0xB57028", Offset = "0xB57028", VA = "0xB57028")]
		[IteratorStateMachine(typeof(<Start>d__10))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0xB570C4", Offset = "0xB570C4", VA = "0xB570C4")]
		public Benchmark01_UGUI()
		{
		}
	}
	[Token(Token = "0x200016A")]
	public class Benchmark02 : MonoBehaviour
	{
		[Token(Token = "0x4000882")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000883")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x4000884")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x4000885")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x600093F")]
		[Address(RVA = "0xB575B4", Offset = "0xB575B4", VA = "0xB575B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000940")]
		[Address(RVA = "0xB57BB4", Offset = "0xB57BB4", VA = "0xB57BB4")]
		public Benchmark02()
		{
		}
	}
	[Token(Token = "0x200016B")]
	public class Benchmark03 : MonoBehaviour
	{
		[Token(Token = "0x200016C")]
		public enum BenchmarkType
		{
			[Token(Token = "0x400088A")]
			TMP_SDF_MOBILE,
			[Token(Token = "0x400088B")]
			TMP_SDF__MOBILE_SSD,
			[Token(Token = "0x400088C")]
			TMP_SDF,
			[Token(Token = "0x400088D")]
			TMP_BITMAP_MOBILE,
			[Token(Token = "0x400088E")]
			TEXTMESH_BITMAP
		}

		[Token(Token = "0x4000886")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int NumberOfSamples;

		[Token(Token = "0x4000887")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public BenchmarkType Benchmark;

		[Token(Token = "0x4000888")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font SourceFont;

		[Token(Token = "0x6000941")]
		[Address(RVA = "0xB57BC4", Offset = "0xB57BC4", VA = "0xB57BC4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000942")]
		[Address(RVA = "0xB57BC8", Offset = "0xB57BC8", VA = "0xB57BC8")]
		private void Start()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0xB58004", Offset = "0xB58004", VA = "0xB58004")]
		public Benchmark03()
		{
		}
	}
	[Token(Token = "0x200016D")]
	public class Benchmark04 : MonoBehaviour
	{
		[Token(Token = "0x400088F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x4000890")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int MinPointSize;

		[Token(Token = "0x4000891")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int MaxPointSize;

		[Token(Token = "0x4000892")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public int Steps;

		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Transform m_Transform;

		[Token(Token = "0x6000944")]
		[Address(RVA = "0xB58014", Offset = "0xB58014", VA = "0xB58014")]
		private void Start()
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xB5831C", Offset = "0xB5831C", VA = "0xB5831C")]
		public Benchmark04()
		{
		}
	}
	[Token(Token = "0x200016E")]
	public class CameraController : MonoBehaviour
	{
		[Token(Token = "0x200016F")]
		public enum CameraModes
		{
			[Token(Token = "0x40008AE")]
			Follow,
			[Token(Token = "0x40008AF")]
			Isometric,
			[Token(Token = "0x40008B0")]
			Free
		}

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Transform cameraTransform;

		[Token(Token = "0x4000895")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform dummyTarget;

		[Token(Token = "0x4000896")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Transform CameraTarget;

		[Token(Token = "0x4000897")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float FollowDistance;

		[Token(Token = "0x4000898")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public float MaxFollowDistance;

		[Token(Token = "0x4000899")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float MinFollowDistance;

		[Token(Token = "0x400089A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float ElevationAngle;

		[Token(Token = "0x400089B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public float MaxElevationAngle;

		[Token(Token = "0x400089C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float MinElevationAngle;

		[Token(Token = "0x400089D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OrbitalAngle;

		[Token(Token = "0x400089E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public CameraModes CameraMode;

		[Token(Token = "0x400089F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool MovementSmoothing;

		[Token(Token = "0x40008A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
		public bool RotationSmoothing;

		[Token(Token = "0x40008A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
		private bool previousSmoothing;

		[Token(Token = "0x40008A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public float MovementSmoothingValue;

		[Token(Token = "0x40008A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float RotationSmoothingValue;

		[Token(Token = "0x40008A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public float MoveSensitivity;

		[Token(Token = "0x40008A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Vector3 currentVelocity;

		[Token(Token = "0x40008A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private Vector3 desiredPosition;

		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private float mouseX;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private float mouseY;

		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private Vector3 moveVector;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		private float mouseWheel;

		[Token(Token = "0x40008AB")]
		private const string event_SmoothingValue = "Slider - Smoothing Value";

		[Token(Token = "0x40008AC")]
		private const string event_FollowDistance = "Slider - Camera Zoom";

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xB58338", Offset = "0xB58338", VA = "0xB58338")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xB583B4", Offset = "0xB583B4", VA = "0xB583B4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0xB584A8", Offset = "0xB584A8", VA = "0xB584A8")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0xB587DC", Offset = "0xB587DC", VA = "0xB587DC")]
		private void GetPlayerInput()
		{
		}

		[Token(Token = "0x600094A")]
		[Address(RVA = "0xB59004", Offset = "0xB59004", VA = "0xB59004")]
		public CameraController()
		{
		}
	}
	[Token(Token = "0x2000170")]
	public class ObjectSpin : MonoBehaviour
	{
		[Token(Token = "0x2000171")]
		public enum MotionType
		{
			[Token(Token = "0x40008BC")]
			Rotation,
			[Token(Token = "0x40008BD")]
			BackAndForth,
			[Token(Token = "0x40008BE")]
			Translation
		}

		[Token(Token = "0x40008B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float SpinSpeed;

		[Token(Token = "0x40008B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int RotationRange;

		[Token(Token = "0x40008B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Transform m_transform;

		[Token(Token = "0x40008B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float m_time;

		[Token(Token = "0x40008B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private Vector3 m_prevPOS;

		[Token(Token = "0x40008B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Vector3 m_initial_Rotation;

		[Token(Token = "0x40008B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private Vector3 m_initial_Position;

		[Token(Token = "0x40008B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Color32 m_lightColor;

		[Token(Token = "0x40008B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int frames;

		[Token(Token = "0x40008BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public MotionType Motion;

		[Token(Token = "0x600094B")]
		[Address(RVA = "0xB59090", Offset = "0xB59090", VA = "0xB59090")]
		private void Awake()
		{
		}

		[Token(Token = "0x600094C")]
		[Address(RVA = "0xB59478", Offset = "0xB59478", VA = "0xB59478")]
		private void Update()
		{
		}

		[Token(Token = "0x600094D")]
		[Address(RVA = "0xB595C0", Offset = "0xB595C0", VA = "0xB595C0")]
		public ObjectSpin()
		{
		}
	}
	[Token(Token = "0x2000172")]
	public class ShaderPropAnimator : MonoBehaviour
	{
		[Token(Token = "0x2000173")]
		[CompilerGenerated]
		private sealed class <AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ShaderPropAnimator <>4__this;

			[Token(Token = "0x1700019E")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000955")]
				[Address(RVA = "0xB59880", Offset = "0xB59880", VA = "0xB59880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700019F")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000957")]
				[Address(RVA = "0xB598C8", Offset = "0xB598C8", VA = "0xB598C8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000952")]
			[Address(RVA = "0xB596E8", Offset = "0xB596E8", VA = "0xB596E8")]
			[DebuggerHidden]
			public <AnimateProperties>d__6(int <>1__state)
			{
			}

			[Token(Token = "0x6000953")]
			[Address(RVA = "0xB59718", Offset = "0xB59718", VA = "0xB59718", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000954")]
			[Address(RVA = "0xB5971C", Offset = "0xB5971C", VA = "0xB5971C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000956")]
			[Address(RVA = "0xB59888", Offset = "0xB59888", VA = "0xB59888", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Renderer m_Renderer;

		[Token(Token = "0x40008C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_Material;

		[Token(Token = "0x40008C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AnimationCurve GlowCurve;

		[Token(Token = "0x40008C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float m_frame;

		[Token(Token = "0x600094E")]
		[Address(RVA = "0xB595D4", Offset = "0xB595D4", VA = "0xB595D4")]
		private void Awake()
		{
		}

		[Token(Token = "0x600094F")]
		[Address(RVA = "0xB59654", Offset = "0xB59654", VA = "0xB59654")]
		private void Start()
		{
		}

		[Token(Token = "0x6000950")]
		[Address(RVA = "0xB59674", Offset = "0xB59674", VA = "0xB59674")]
		[IteratorStateMachine(typeof(<AnimateProperties>d__6))]
		private IEnumerator AnimateProperties()
		{
			return null;
		}

		[Token(Token = "0x6000951")]
		[Address(RVA = "0xB59710", Offset = "0xB59710", VA = "0xB59710")]
		public ShaderPropAnimator()
		{
		}
	}
	[Token(Token = "0x2000174")]
	public class SimpleScript : MonoBehaviour
	{
		[Token(Token = "0x40008C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40008C7")]
		private const string label = "The <#0050FF>count is: </color>{0:2}";

		[Token(Token = "0x40008C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private float m_frame;

		[Token(Token = "0x6000958")]
		[Address(RVA = "0xB598D0", Offset = "0xB598D0", VA = "0xB598D0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000959")]
		[Address(RVA = "0xB59994", Offset = "0xB59994", VA = "0xB59994")]
		private void Update()
		{
		}

		[Token(Token = "0x600095A")]
		[Address(RVA = "0xB59A20", Offset = "0xB59A20", VA = "0xB59A20")]
		public SimpleScript()
		{
		}
	}
	[Token(Token = "0x2000175")]
	public class SkewTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000176")]
		[CompilerGenerated]
		private sealed class <WarpText>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008CF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SkewTextExample <>4__this;

			[Token(Token = "0x40008D0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x40008D1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <old_ShearValue>5__3;

			[Token(Token = "0x40008D2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__4;

			[Token(Token = "0x170001A0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000963")]
				[Address(RVA = "0xB5A740", Offset = "0xB5A740", VA = "0xB5A740", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000965")]
				[Address(RVA = "0xB5A788", Offset = "0xB5A788", VA = "0xB5A788", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0xB59BA4", Offset = "0xB59BA4", VA = "0xB59BA4")]
			[DebuggerHidden]
			public <WarpText>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0xB59E08", Offset = "0xB59E08", VA = "0xB59E08", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0xB59E0C", Offset = "0xB59E0C", VA = "0xB59E0C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000964")]
			[Address(RVA = "0xB5A748", Offset = "0xB5A748", VA = "0xB5A748", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40008CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x40008CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float CurveScale;

		[Token(Token = "0x40008CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float ShearAmount;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0xB59A28", Offset = "0xB59A28", VA = "0xB59A28")]
		private void Awake()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0xB59A90", Offset = "0xB59A90", VA = "0xB59A90")]
		private void Start()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0xB59B24", Offset = "0xB59B24", VA = "0xB59B24")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0xB59AB0", Offset = "0xB59AB0", VA = "0xB59AB0")]
		[IteratorStateMachine(typeof(<WarpText>d__7))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x600095F")]
		[Address(RVA = "0xB59BCC", Offset = "0xB59BCC", VA = "0xB59BCC")]
		public SkewTextExample()
		{
		}
	}
	[Token(Token = "0x2000177")]
	public class TeleType : MonoBehaviour
	{
		[Token(Token = "0x2000178")]
		[CompilerGenerated]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TeleType <>4__this;

			[Token(Token = "0x40008D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalVisibleCharacters>5__2;

			[Token(Token = "0x40008DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <counter>5__3;

			[Token(Token = "0x170001A2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600096C")]
				[Address(RVA = "0xB5AB80", Offset = "0xB5AB80", VA = "0xB5AB80", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600096E")]
				[Address(RVA = "0xB5ABC8", Offset = "0xB5ABC8", VA = "0xB5ABC8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000969")]
			[Address(RVA = "0xB5A8A8", Offset = "0xB5A8A8", VA = "0xB5A8A8")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x600096A")]
			[Address(RVA = "0xB5A954", Offset = "0xB5A954", VA = "0xB5A954", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600096B")]
			[Address(RVA = "0xB5A958", Offset = "0xB5A958", VA = "0xB5A958", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600096D")]
			[Address(RVA = "0xB5AB88", Offset = "0xB5AB88", VA = "0xB5AB88", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string label01;

		[Token(Token = "0x40008D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string label02;

		[Token(Token = "0x40008D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_textMeshPro;

		[Token(Token = "0x6000966")]
		[Address(RVA = "0xB5A790", Offset = "0xB5A790", VA = "0xB5A790")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0xB5A834", Offset = "0xB5A834", VA = "0xB5A834")]
		[IteratorStateMachine(typeof(<Start>d__4))]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0xB5A8D0", Offset = "0xB5A8D0", VA = "0xB5A8D0")]
		public TeleType()
		{
		}
	}
	[Token(Token = "0x2000179")]
	public class TextConsoleSimulator : MonoBehaviour
	{
		[Token(Token = "0x200017A")]
		[CompilerGenerated]
		private sealed class <RevealCharacters>d__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40008E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public TextConsoleSimulator <>4__this;

			[Token(Token = "0x40008E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x40008E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40008E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private int <visibleCount>5__4;

			[Token(Token = "0x170001A4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600097A")]
				[Address(RVA = "0xB5B0E0", Offset = "0xB5B0E0", VA = "0xB5B0E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600097C")]
				[Address(RVA = "0xB5B128", Offset = "0xB5B128", VA = "0xB5B128", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000977")]
			[Address(RVA = "0xB5AE90", Offset = "0xB5AE90", VA = "0xB5AE90")]
			[DebuggerHidden]
			public <RevealCharacters>d__7(int <>1__state)
			{
			}

			[Token(Token = "0x6000978")]
			[Address(RVA = "0xB5AF5C", Offset = "0xB5AF5C", VA = "0xB5AF5C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000979")]
			[Address(RVA = "0xB5AF60", Offset = "0xB5AF60", VA = "0xB5AF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600097B")]
			[Address(RVA = "0xB5B0E8", Offset = "0xB5B0E8", VA = "0xB5B0E8", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017B")]
		[CompilerGenerated]
		private sealed class <RevealWords>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TMP_Text textComponent;

			[Token(Token = "0x40008E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private int <totalWordCount>5__2;

			[Token(Token = "0x40008E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private int <totalVisibleCharacters>5__3;

			[Token(Token = "0x40008E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <counter>5__4;

			[Token(Token = "0x40008EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private int <visibleCount>5__5;

			[Token(Token = "0x170001A6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000980")]
				[Address(RVA = "0xB5B308", Offset = "0xB5B308", VA = "0xB5B308", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000982")]
				[Address(RVA = "0xB5B350", Offset = "0xB5B350", VA = "0xB5B350", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600097D")]
			[Address(RVA = "0xB5AF2C", Offset = "0xB5AF2C", VA = "0xB5AF2C")]
			[DebuggerHidden]
			public <RevealWords>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x600097E")]
			[Address(RVA = "0xB5B130", Offset = "0xB5B130", VA = "0xB5B130", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600097F")]
			[Address(RVA = "0xB5B134", Offset = "0xB5B134", VA = "0xB5B134", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000981")]
			[Address(RVA = "0xB5B310", Offset = "0xB5B310", VA = "0xB5B310", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x40008DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool hasTextChanged;

		[Token(Token = "0x600096F")]
		[Address(RVA = "0xB5ABD0", Offset = "0xB5ABD0", VA = "0xB5ABD0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000970")]
		[Address(RVA = "0xB5AC38", Offset = "0xB5AC38", VA = "0xB5AC38")]
		private void Start()
		{
		}

		[Token(Token = "0x6000971")]
		[Address(RVA = "0xB5ACEC", Offset = "0xB5ACEC", VA = "0xB5ACEC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000972")]
		[Address(RVA = "0xB5ADB8", Offset = "0xB5ADB8", VA = "0xB5ADB8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000973")]
		[Address(RVA = "0xB5AE84", Offset = "0xB5AE84", VA = "0xB5AE84")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x6000974")]
		[Address(RVA = "0xB5AC5C", Offset = "0xB5AC5C", VA = "0xB5AC5C")]
		[IteratorStateMachine(typeof(<RevealCharacters>d__7))]
		private IEnumerator RevealCharacters(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000975")]
		[Address(RVA = "0xB5AEB8", Offset = "0xB5AEB8", VA = "0xB5AEB8")]
		[IteratorStateMachine(typeof(<RevealWords>d__8))]
		private IEnumerator RevealWords(TMP_Text textComponent)
		{
			return null;
		}

		[Token(Token = "0x6000976")]
		[Address(RVA = "0xB5AF54", Offset = "0xB5AF54", VA = "0xB5AF54")]
		public TextConsoleSimulator()
		{
		}
	}
	[Token(Token = "0x200017C")]
	public class TextMeshProFloatingText : MonoBehaviour
	{
		[Token(Token = "0x200017D")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshProFloatingText>d__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40008F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x40008F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x40008FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x40008FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x40008FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x40008FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x40008FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x40008FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x4000900")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x4000901")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170001A8")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600098C")]
				[Address(RVA = "0xB5C83C", Offset = "0xB5C83C", VA = "0xB5C83C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001A9")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600098E")]
				[Address(RVA = "0xB5C884", Offset = "0xB5C884", VA = "0xB5C884", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000989")]
			[Address(RVA = "0xB5B944", Offset = "0xB5B944", VA = "0xB5B944")]
			[DebuggerHidden]
			public <DisplayTextMeshProFloatingText>d__15(int <>1__state)
			{
			}

			[Token(Token = "0x600098A")]
			[Address(RVA = "0xB5C148", Offset = "0xB5C148", VA = "0xB5C148", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600098B")]
			[Address(RVA = "0xB5C14C", Offset = "0xB5C14C", VA = "0xB5C14C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600098D")]
			[Address(RVA = "0xB5C844", Offset = "0xB5C844", VA = "0xB5C844", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x200017E")]
		[CompilerGenerated]
		private sealed class <DisplayTextMeshFloatingText>d__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000902")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000903")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000904")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public TextMeshProFloatingText <>4__this;

			[Token(Token = "0x4000905")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <CountDuration>5__2;

			[Token(Token = "0x4000906")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float <starting_Count>5__3;

			[Token(Token = "0x4000907")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float <current_Count>5__4;

			[Token(Token = "0x4000908")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			private Vector3 <start_pos>5__5;

			[Token(Token = "0x4000909")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private Color32 <start_color>5__6;

			[Token(Token = "0x400090A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			private float <alpha>5__7;

			[Token(Token = "0x400090B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private float <fadeDuration>5__8;

			[Token(Token = "0x170001AA")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000992")]
				[Address(RVA = "0xB5CF68", Offset = "0xB5CF68", VA = "0xB5CF68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AB")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000994")]
				[Address(RVA = "0xB5CFB0", Offset = "0xB5CFB0", VA = "0xB5CFB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600098F")]
			[Address(RVA = "0xB5B96C", Offset = "0xB5B96C", VA = "0xB5B96C")]
			[DebuggerHidden]
			public <DisplayTextMeshFloatingText>d__16(int <>1__state)
			{
			}

			[Token(Token = "0x6000990")]
			[Address(RVA = "0xB5C88C", Offset = "0xB5C88C", VA = "0xB5C88C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000991")]
			[Address(RVA = "0xB5C890", Offset = "0xB5C890", VA = "0xB5C890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000993")]
			[Address(RVA = "0xB5CF70", Offset = "0xB5CF70", VA = "0xB5CF70", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Font TheFont;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private GameObject m_floatingText;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshPro m_textMeshPro;

		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMesh m_textMesh;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_transform;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform m_floatingText_Transform;

		[Token(Token = "0x40008F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Transform m_cameraTransform;

		[Token(Token = "0x40008F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Vector3 lastPOS;

		[Token(Token = "0x40008F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private Quaternion lastRotation;

		[Token(Token = "0x40008F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public int SpawnType;

		[Token(Token = "0x40008F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool IsTextObjectScaleStatic;

		[Token(Token = "0x40008F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WaitForEndOfFrame k_WaitForEndOfFrame;

		[Token(Token = "0x40008F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static WaitForSeconds[] k_WaitForSecondsRandom;

		[Token(Token = "0x6000983")]
		[Address(RVA = "0xB5B358", Offset = "0xB5B358", VA = "0xB5B358")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000984")]
		[Address(RVA = "0xB5B440", Offset = "0xB5B440", VA = "0xB5B440")]
		private void Start()
		{
		}

		[Token(Token = "0x6000985")]
		[Address(RVA = "0xB5B85C", Offset = "0xB5B85C", VA = "0xB5B85C")]
		[IteratorStateMachine(typeof(<DisplayTextMeshProFloatingText>d__15))]
		public IEnumerator DisplayTextMeshProFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000986")]
		[Address(RVA = "0xB5B8D0", Offset = "0xB5B8D0", VA = "0xB5B8D0")]
		[IteratorStateMachine(typeof(<DisplayTextMeshFloatingText>d__16))]
		public IEnumerator DisplayTextMeshFloatingText()
		{
			return null;
		}

		[Token(Token = "0x6000987")]
		[Address(RVA = "0xB5B994", Offset = "0xB5B994", VA = "0xB5B994")]
		public TextMeshProFloatingText()
		{
		}
	}
	[Token(Token = "0x200017F")]
	public class TextMeshSpawner : MonoBehaviour
	{
		[Token(Token = "0x400090C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int SpawnType;

		[Token(Token = "0x400090D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int NumberOfNPC;

		[Token(Token = "0x400090E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Font TheFont;

		[Token(Token = "0x400090F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProFloatingText floatingText_Script;

		[Token(Token = "0x6000995")]
		[Address(RVA = "0xB5CFB8", Offset = "0xB5CFB8", VA = "0xB5CFB8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0xB5CFBC", Offset = "0xB5CFBC", VA = "0xB5CFBC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0xB5D2BC", Offset = "0xB5D2BC", VA = "0xB5D2BC")]
		public TextMeshSpawner()
		{
		}
	}
	[Token(Token = "0x2000180")]
	public class TMPro_InstructionOverlay : MonoBehaviour
	{
		[Token(Token = "0x2000181")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000917")]
			TopLeft,
			[Token(Token = "0x4000918")]
			BottomLeft,
			[Token(Token = "0x4000919")]
			TopRight,
			[Token(Token = "0x400091A")]
			BottomRight
		}

		[Token(Token = "0x4000910")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000911")]
		private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";

		[Token(Token = "0x4000912")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000913")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextContainer m_textContainer;

		[Token(Token = "0x4000914")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x4000915")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		[Token(Token = "0x6000998")]
		[Address(RVA = "0xB5D2CC", Offset = "0xB5D2CC", VA = "0xB5D2CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000999")]
		[Address(RVA = "0xB5D584", Offset = "0xB5D584", VA = "0xB5D584")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x600099A")]
		[Address(RVA = "0xB5D698", Offset = "0xB5D698", VA = "0xB5D698")]
		public TMPro_InstructionOverlay()
		{
		}
	}
	[Token(Token = "0x2000182")]
	public class TMP_ExampleScript_01 : MonoBehaviour
	{
		[Token(Token = "0x2000183")]
		public enum objectType
		{
			[Token(Token = "0x4000921")]
			TextMeshPro,
			[Token(Token = "0x4000922")]
			TextMeshProUGUI
		}

		[Token(Token = "0x400091B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public objectType ObjectType;

		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool isStatic;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_text;

		[Token(Token = "0x400091E")]
		private const string k_label = "The count is <#0080ff>{0}</color>";

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int count;

		[Token(Token = "0x600099B")]
		[Address(RVA = "0xB5D6A8", Offset = "0xB5D6A8", VA = "0xB5D6A8")]
		private void Awake()
		{
		}

		[Token(Token = "0x600099C")]
		[Address(RVA = "0xB5D8CC", Offset = "0xB5D8CC", VA = "0xB5D8CC")]
		private void Update()
		{
		}

		[Token(Token = "0x600099D")]
		[Address(RVA = "0xB5D960", Offset = "0xB5D960", VA = "0xB5D960")]
		public TMP_ExampleScript_01()
		{
		}
	}
	[Token(Token = "0x2000184")]
	public class TMP_FrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x2000185")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x400092E")]
			TopLeft,
			[Token(Token = "0x400092F")]
			BottomLeft,
			[Token(Token = "0x4000930")]
			TopRight,
			[Token(Token = "0x4000931")]
			BottomRight
		}

		[Token(Token = "0x4000923")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000924")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x4000925")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x4000926")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x4000927")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x4000928")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x4000929")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x400092A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_frameCounter_transform;

		[Token(Token = "0x400092B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_camera;

		[Token(Token = "0x400092C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x600099E")]
		[Address(RVA = "0xB5D968", Offset = "0xB5D968", VA = "0xB5D968")]
		private void Awake()
		{
		}

		[Token(Token = "0x600099F")]
		[Address(RVA = "0xB5DDA0", Offset = "0xB5DDA0", VA = "0xB5DDA0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009A0")]
		[Address(RVA = "0xB5DDC0", Offset = "0xB5DDC0", VA = "0xB5DDC0")]
		private void Update()
		{
		}

		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xB5DBC4", Offset = "0xB5DBC4", VA = "0xB5DBC4")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xB5DF14", Offset = "0xB5DF14", VA = "0xB5DF14")]
		public TMP_FrameRateCounter()
		{
		}
	}
	[Token(Token = "0x2000186")]
	public class TMP_TextEventCheck : MonoBehaviour
	{
		[Token(Token = "0x4000932")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TMP_TextEventHandler TextEventHandler;

		[Token(Token = "0x4000933")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xB5DF2C", Offset = "0xB5DF2C", VA = "0xB5DF2C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009A4")]
		[Address(RVA = "0xB5E200", Offset = "0xB5E200", VA = "0xB5E200")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009A5")]
		[Address(RVA = "0xB5E49C", Offset = "0xB5E49C", VA = "0xB5E49C")]
		private void OnCharacterSelection(char c, int index)
		{
		}

		[Token(Token = "0x60009A6")]
		[Address(RVA = "0xB5E6EC", Offset = "0xB5E6EC", VA = "0xB5E6EC")]
		private void OnSpriteSelection(char c, int index)
		{
		}

		[Token(Token = "0x60009A7")]
		[Address(RVA = "0xB5E93C", Offset = "0xB5E93C", VA = "0xB5E93C")]
		private void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60009A8")]
		[Address(RVA = "0xB5EC1C", Offset = "0xB5EC1C", VA = "0xB5EC1C")]
		private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
		}

		[Token(Token = "0x60009A9")]
		[Address(RVA = "0xB5EEFC", Offset = "0xB5EEFC", VA = "0xB5EEFC")]
		private void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
		}

		[Token(Token = "0x60009AA")]
		[Address(RVA = "0xB5F230", Offset = "0xB5F230", VA = "0xB5F230")]
		public TMP_TextEventCheck()
		{
		}
	}
	[Token(Token = "0x2000187")]
	public class TMP_TextInfoDebugTool : MonoBehaviour
	{
		[Token(Token = "0x60009AB")]
		[Address(RVA = "0xB5F238", Offset = "0xB5F238", VA = "0xB5F238")]
		public TMP_TextInfoDebugTool()
		{
		}
	}
	[Token(Token = "0x2000188")]
	public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TextMeshPro m_TextMeshPro;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Camera m_Camera;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool m_isHoveringObject;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int m_selectedLink;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int m_lastCharIndex;

		[Token(Token = "0x4000939")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int m_lastWordIndex;

		[Token(Token = "0x60009AC")]
		[Address(RVA = "0xB5F240", Offset = "0xB5F240", VA = "0xB5F240")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009AD")]
		[Address(RVA = "0xB5F2E4", Offset = "0xB5F2E4", VA = "0xB5F2E4")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009AE")]
		[Address(RVA = "0xB5F988", Offset = "0xB5F988", VA = "0xB5F988", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009AF")]
		[Address(RVA = "0xB5FA00", Offset = "0xB5FA00", VA = "0xB5FA00", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009B0")]
		[Address(RVA = "0xB5FA74", Offset = "0xB5FA74", VA = "0xB5FA74")]
		public TMP_TextSelector_A()
		{
		}
	}
	[Token(Token = "0x2000189")]
	public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
	{
		[Token(Token = "0x400093A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RectTransform TextPopup_Prefab_01;

		[Token(Token = "0x400093B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private RectTransform m_TextPopup_RectTransform;

		[Token(Token = "0x400093C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TextMeshProUGUI m_TextPopup_TMPComponent;

		[Token(Token = "0x400093D")]
		private const string k_LinkText = "You have selected link <#ffff00>";

		[Token(Token = "0x400093E")]
		private const string k_WordText = "Word Index: <#ffff00>";

		[Token(Token = "0x400093F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x4000940")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x4000941")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Camera m_Camera;

		[Token(Token = "0x4000942")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool isHoveringObject;

		[Token(Token = "0x4000943")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private int m_selectedWord;

		[Token(Token = "0x4000944")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int m_selectedLink;

		[Token(Token = "0x4000945")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		private int m_lastIndex;

		[Token(Token = "0x4000946")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Matrix4x4 m_matrix;

		[Token(Token = "0x4000947")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TMP_MeshInfo[] m_cachedMeshInfoVertexData;

		[Token(Token = "0x60009B1")]
		[Address(RVA = "0xB5FA8C", Offset = "0xB5FA8C", VA = "0xB5FA8C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009B2")]
		[Address(RVA = "0xB5FC54", Offset = "0xB5FC54", VA = "0xB5FC54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009B3")]
		[Address(RVA = "0xB5FD20", Offset = "0xB5FD20", VA = "0xB5FD20")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009B4")]
		[Address(RVA = "0xB5FDEC", Offset = "0xB5FDEC", VA = "0xB5FDEC")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009B5")]
		[Address(RVA = "0xB5FE98", Offset = "0xB5FE98", VA = "0xB5FE98")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x60009B6")]
		[Address(RVA = "0xB6136C", Offset = "0xB6136C", VA = "0xB6136C", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009B7")]
		[Address(RVA = "0xB61378", Offset = "0xB61378", VA = "0xB61378", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009B8")]
		[Address(RVA = "0xB61380", Offset = "0xB61380", VA = "0xB61380", Slot = "6")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009B9")]
		[Address(RVA = "0xB61384", Offset = "0xB61384", VA = "0xB61384", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Token(Token = "0x60009BA")]
		[Address(RVA = "0xB60AE8", Offset = "0xB60AE8", VA = "0xB60AE8")]
		private void RestoreCachedVertexAttributes(int index)
		{
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xB61388", Offset = "0xB61388", VA = "0xB61388")]
		public TMP_TextSelector_B()
		{
		}
	}
	[Token(Token = "0x200018A")]
	public class TMP_UiFrameRateCounter : MonoBehaviour
	{
		[Token(Token = "0x200018B")]
		public enum FpsCounterAnchorPositions
		{
			[Token(Token = "0x4000952")]
			TopLeft,
			[Token(Token = "0x4000953")]
			BottomLeft,
			[Token(Token = "0x4000954")]
			TopRight,
			[Token(Token = "0x4000955")]
			BottomRight
		}

		[Token(Token = "0x4000948")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float UpdateInterval;

		[Token(Token = "0x4000949")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private float m_LastInterval;

		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_Frames;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public FpsCounterAnchorPositions AnchorPosition;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string htmlColorTag;

		[Token(Token = "0x400094D")]
		private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TextMeshProUGUI m_TextMeshPro;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RectTransform m_frameCounter_transform;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private FpsCounterAnchorPositions last_AnchorPosition;

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xB613A0", Offset = "0xB613A0", VA = "0xB613A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xB617FC", Offset = "0xB617FC", VA = "0xB617FC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009BE")]
		[Address(RVA = "0xB6181C", Offset = "0xB6181C", VA = "0xB6181C")]
		private void Update()
		{
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xB615C4", Offset = "0xB615C4", VA = "0xB615C4")]
		private void Set_FrameCounter_Position(FpsCounterAnchorPositions anchor_position)
		{
		}

		[Token(Token = "0x60009C0")]
		[Address(RVA = "0xB61970", Offset = "0xB61970", VA = "0xB61970")]
		public TMP_UiFrameRateCounter()
		{
		}
	}
	[Token(Token = "0x200018C")]
	public class VertexColorCycler : MonoBehaviour
	{
		[Token(Token = "0x200018D")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000957")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000958")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000959")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexColorCycler <>4__this;

			[Token(Token = "0x400095A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400095B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <currentCharacter>5__3;

			[Token(Token = "0x170001AC")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009C8")]
				[Address(RVA = "0xB61DEC", Offset = "0xB61DEC", VA = "0xB61DEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009CA")]
				[Address(RVA = "0xB61E34", Offset = "0xB61E34", VA = "0xB61E34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009C5")]
			[Address(RVA = "0xB61A74", Offset = "0xB61A74", VA = "0xB61A74")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__3(int <>1__state)
			{
			}

			[Token(Token = "0x60009C6")]
			[Address(RVA = "0xB61AA4", Offset = "0xB61AA4", VA = "0xB61AA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009C7")]
			[Address(RVA = "0xB61AA8", Offset = "0xB61AA8", VA = "0xB61AA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009C9")]
			[Address(RVA = "0xB61DF4", Offset = "0xB61DF4", VA = "0xB61DF4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000956")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x60009C1")]
		[Address(RVA = "0xB61988", Offset = "0xB61988", VA = "0xB61988")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009C2")]
		[Address(RVA = "0xB619E0", Offset = "0xB619E0", VA = "0xB619E0")]
		private void Start()
		{
		}

		[Token(Token = "0x60009C3")]
		[Address(RVA = "0xB61A00", Offset = "0xB61A00", VA = "0xB61A00")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__3))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60009C4")]
		[Address(RVA = "0xB61A9C", Offset = "0xB61A9C", VA = "0xB61A9C")]
		public VertexColorCycler()
		{
		}
	}
	[Token(Token = "0x200018E")]
	public class VertexJitter : MonoBehaviour
	{
		[Token(Token = "0x200018F")]
		private struct VertexAnim
		{
			[Token(Token = "0x4000961")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float angleRange;

			[Token(Token = "0x4000962")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float angle;

			[Token(Token = "0x4000963")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float speed;
		}

		[Token(Token = "0x2000190")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000964")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000965")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000966")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexJitter <>4__this;

			[Token(Token = "0x4000967")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000968")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int <loopCount>5__3;

			[Token(Token = "0x4000969")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private VertexAnim[] <vertexAnim>5__4;

			[Token(Token = "0x400096A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TMP_MeshInfo[] <cachedMeshInfo>5__5;

			[Token(Token = "0x170001AE")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009D5")]
				[Address(RVA = "0xB62A9C", Offset = "0xB62A9C", VA = "0xB62A9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009D7")]
				[Address(RVA = "0xB62AE4", Offset = "0xB62AE4", VA = "0xB62AE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009D2")]
			[Address(RVA = "0xB6213C", Offset = "0xB6213C", VA = "0xB6213C")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60009D3")]
			[Address(RVA = "0xB6217C", Offset = "0xB6217C", VA = "0xB6217C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009D4")]
			[Address(RVA = "0xB62180", Offset = "0xB62180", VA = "0xB62180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009D6")]
			[Address(RVA = "0xB62AA4", Offset = "0xB62AA4", VA = "0xB62AA4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400095C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400095D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400095E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x400095F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000960")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60009CB")]
		[Address(RVA = "0xB61E3C", Offset = "0xB61E3C", VA = "0xB61E3C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009CC")]
		[Address(RVA = "0xB61E94", Offset = "0xB61E94", VA = "0xB61E94")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009CD")]
		[Address(RVA = "0xB61F60", Offset = "0xB61F60", VA = "0xB61F60")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009CE")]
		[Address(RVA = "0xB6202C", Offset = "0xB6202C", VA = "0xB6202C")]
		private void Start()
		{
		}

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xB620C0", Offset = "0xB620C0", VA = "0xB620C0")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xB6204C", Offset = "0xB6204C", VA = "0xB6204C")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xB62164", Offset = "0xB62164", VA = "0xB62164")]
		public VertexJitter()
		{
		}
	}
	[Token(Token = "0x2000191")]
	public class VertexShakeA : MonoBehaviour
	{
		[Token(Token = "0x2000192")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000971")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000972")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000973")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeA <>4__this;

			[Token(Token = "0x4000974")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x4000975")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170001B0")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009E2")]
				[Address(RVA = "0xB63850", Offset = "0xB63850", VA = "0xB63850", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009E4")]
				[Address(RVA = "0xB63898", Offset = "0xB63898", VA = "0xB63898", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009DF")]
			[Address(RVA = "0xB62DDC", Offset = "0xB62DDC", VA = "0xB62DDC")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__11(int <>1__state)
			{
			}

			[Token(Token = "0x60009E0")]
			[Address(RVA = "0xB62E14", Offset = "0xB62E14", VA = "0xB62E14", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009E1")]
			[Address(RVA = "0xB62E18", Offset = "0xB62E18", VA = "0xB62E18", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009E3")]
			[Address(RVA = "0xB63858", Offset = "0xB63858", VA = "0xB63858", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400096B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x400096C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x400096D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float ScaleMultiplier;

		[Token(Token = "0x400096E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float RotationMultiplier;

		[Token(Token = "0x400096F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000970")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xB62AEC", Offset = "0xB62AEC", VA = "0xB62AEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xB62B44", Offset = "0xB62B44", VA = "0xB62B44")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xB62C10", Offset = "0xB62C10", VA = "0xB62C10")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xB62CDC", Offset = "0xB62CDC", VA = "0xB62CDC")]
		private void Start()
		{
		}

		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xB62D70", Offset = "0xB62D70", VA = "0xB62D70")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xB62CFC", Offset = "0xB62CFC", VA = "0xB62CFC")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__11))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xB62E04", Offset = "0xB62E04", VA = "0xB62E04")]
		public VertexShakeA()
		{
		}
	}
	[Token(Token = "0x2000193")]
	public class VertexShakeB : MonoBehaviour
	{
		[Token(Token = "0x2000194")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400097B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400097C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400097D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexShakeB <>4__this;

			[Token(Token = "0x400097E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400097F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Vector3[][] <copyOfVertices>5__3;

			[Token(Token = "0x170001B2")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009EF")]
				[Address(RVA = "0xB64AF4", Offset = "0xB64AF4", VA = "0xB64AF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60009F1")]
				[Address(RVA = "0xB64B3C", Offset = "0xB64B3C", VA = "0xB64B3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009EC")]
			[Address(RVA = "0xB63B90", Offset = "0xB63B90", VA = "0xB63B90")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009ED")]
			[Address(RVA = "0xB63BD0", Offset = "0xB63BD0", VA = "0xB63BD0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009EE")]
			[Address(RVA = "0xB63BD4", Offset = "0xB63BD4", VA = "0xB63BD4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009F0")]
			[Address(RVA = "0xB64AFC", Offset = "0xB64AFC", VA = "0xB64AFC", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000976")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000977")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000978")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000979")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400097A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60009E5")]
		[Address(RVA = "0xB638A0", Offset = "0xB638A0", VA = "0xB638A0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009E6")]
		[Address(RVA = "0xB638F8", Offset = "0xB638F8", VA = "0xB638F8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009E7")]
		[Address(RVA = "0xB639C4", Offset = "0xB639C4", VA = "0xB639C4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009E8")]
		[Address(RVA = "0xB63A90", Offset = "0xB63A90", VA = "0xB63A90")]
		private void Start()
		{
		}

		[Token(Token = "0x60009E9")]
		[Address(RVA = "0xB63B24", Offset = "0xB63B24", VA = "0xB63B24")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009EA")]
		[Address(RVA = "0xB63AB0", Offset = "0xB63AB0", VA = "0xB63AB0")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xB63BB8", Offset = "0xB63BB8", VA = "0xB63BB8")]
		public VertexShakeB()
		{
		}
	}
	[Token(Token = "0x2000195")]
	public class VertexZoom : MonoBehaviour
	{
		[Token(Token = "0x2000196")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass10_0
		{
			[Token(Token = "0x4000985")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public List<float> modifiedCharScale;

			[Token(Token = "0x4000986")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Comparison<int> <>9__0;

			[Token(Token = "0x60009F9")]
			[Address(RVA = "0xB64E84", Offset = "0xB64E84", VA = "0xB64E84")]
			public <>c__DisplayClass10_0()
			{
			}

			[Token(Token = "0x60009FA")]
			[Address(RVA = "0xB64E8C", Offset = "0xB64E8C", VA = "0xB64E8C")]
			internal int <AnimateVertexColors>b__0(int a, int b)
			{
				return default(int);
			}
		}

		[Token(Token = "0x2000197")]
		[CompilerGenerated]
		private sealed class <AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000987")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000988")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000989")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public VertexZoom <>4__this;

			[Token(Token = "0x400098A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private <>c__DisplayClass10_0 <>8__1;

			[Token(Token = "0x400098B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TMP_TextInfo <textInfo>5__2;

			[Token(Token = "0x400098C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

			[Token(Token = "0x400098D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private List<int> <scaleSortingOrder>5__4;

			[Token(Token = "0x170001B4")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60009FE")]
				[Address(RVA = "0xB65BBC", Offset = "0xB65BBC", VA = "0xB65BBC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B5")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A00")]
				[Address(RVA = "0xB65C04", Offset = "0xB65C04", VA = "0xB65C04", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60009FB")]
			[Address(RVA = "0xB64E44", Offset = "0xB64E44", VA = "0xB64E44")]
			[DebuggerHidden]
			public <AnimateVertexColors>d__10(int <>1__state)
			{
			}

			[Token(Token = "0x60009FC")]
			[Address(RVA = "0xB64F1C", Offset = "0xB64F1C", VA = "0xB64F1C", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60009FD")]
			[Address(RVA = "0xB64F20", Offset = "0xB64F20", VA = "0xB64F20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60009FF")]
			[Address(RVA = "0xB65BC4", Offset = "0xB65BC4", VA = "0xB65BC4", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000980")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float AngleMultiplier;

		[Token(Token = "0x4000981")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000982")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float CurveScale;

		[Token(Token = "0x4000983")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000984")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool hasTextChanged;

		[Token(Token = "0x60009F2")]
		[Address(RVA = "0xB64B44", Offset = "0xB64B44", VA = "0xB64B44")]
		private void Awake()
		{
		}

		[Token(Token = "0x60009F3")]
		[Address(RVA = "0xB64B9C", Offset = "0xB64B9C", VA = "0xB64B9C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60009F4")]
		[Address(RVA = "0xB64C68", Offset = "0xB64C68", VA = "0xB64C68")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60009F5")]
		[Address(RVA = "0xB64D34", Offset = "0xB64D34", VA = "0xB64D34")]
		private void Start()
		{
		}

		[Token(Token = "0x60009F6")]
		[Address(RVA = "0xB64DC8", Offset = "0xB64DC8", VA = "0xB64DC8")]
		private void ON_TEXT_CHANGED(UnityEngine.Object obj)
		{
		}

		[Token(Token = "0x60009F7")]
		[Address(RVA = "0xB64D54", Offset = "0xB64D54", VA = "0xB64D54")]
		[IteratorStateMachine(typeof(<AnimateVertexColors>d__10))]
		private IEnumerator AnimateVertexColors()
		{
			return null;
		}

		[Token(Token = "0x60009F8")]
		[Address(RVA = "0xB64E6C", Offset = "0xB64E6C", VA = "0xB64E6C")]
		public VertexZoom()
		{
		}
	}
	[Token(Token = "0x2000198")]
	public class WarpTextExample : MonoBehaviour
	{
		[Token(Token = "0x2000199")]
		[CompilerGenerated]
		private sealed class <WarpText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000993")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000994")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000995")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public WarpTextExample <>4__this;

			[Token(Token = "0x4000996")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <old_CurveScale>5__2;

			[Token(Token = "0x4000997")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private AnimationCurve <old_curve>5__3;

			[Token(Token = "0x170001B6")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A09")]
				[Address(RVA = "0xB66864", Offset = "0xB66864", VA = "0xB66864", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B7")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A0B")]
				[Address(RVA = "0xB668AC", Offset = "0xB668AC", VA = "0xB668AC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A06")]
			[Address(RVA = "0xB65D88", Offset = "0xB65D88", VA = "0xB65D88")]
			[DebuggerHidden]
			public <WarpText>d__8(int <>1__state)
			{
			}

			[Token(Token = "0x6000A07")]
			[Address(RVA = "0xB65FF4", Offset = "0xB65FF4", VA = "0xB65FF4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A08")]
			[Address(RVA = "0xB65FF8", Offset = "0xB65FF8", VA = "0xB65FF8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A0A")]
			[Address(RVA = "0xB6686C", Offset = "0xB6686C", VA = "0xB6686C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400098E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x400098F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AnimationCurve VertexCurve;

		[Token(Token = "0x4000990")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float AngleMultiplier;

		[Token(Token = "0x4000991")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float SpeedMultiplier;

		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float CurveScale;

		[Token(Token = "0x6000A01")]
		[Address(RVA = "0xB65C0C", Offset = "0xB65C0C", VA = "0xB65C0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A02")]
		[Address(RVA = "0xB65C74", Offset = "0xB65C74", VA = "0xB65C74")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A03")]
		[Address(RVA = "0xB65D08", Offset = "0xB65D08", VA = "0xB65D08")]
		private AnimationCurve CopyAnimationCurve(AnimationCurve curve)
		{
			return null;
		}

		[Token(Token = "0x6000A04")]
		[Address(RVA = "0xB65C94", Offset = "0xB65C94", VA = "0xB65C94")]
		[IteratorStateMachine(typeof(<WarpText>d__8))]
		private IEnumerator WarpText()
		{
			return null;
		}

		[Token(Token = "0x6000A05")]
		[Address(RVA = "0xB65DB0", Offset = "0xB65DB0", VA = "0xB65DB0")]
		public WarpTextExample()
		{
		}
	}
}
namespace HighlightPlus
{
	[Token(Token = "0x200019A")]
	public delegate bool OnObjectHighlightStartEvent(GameObject obj);
	[Token(Token = "0x200019B")]
	public delegate void OnObjectHighlightEndEvent(GameObject obj);
	[Token(Token = "0x200019C")]
	public delegate bool OnRendererHighlightEvent(Renderer renderer);
	[Token(Token = "0x200019D")]
	public enum SeeThroughMode
	{
		[Token(Token = "0x4000999")]
		WhenHighlighted,
		[Token(Token = "0x400099A")]
		AlwaysWhenOccluded,
		[Token(Token = "0x400099B")]
		Never
	}
	[Token(Token = "0x200019E")]
	public enum QualityLevel
	{
		[Token(Token = "0x400099D")]
		Fastest,
		[Token(Token = "0x400099E")]
		High,
		[Token(Token = "0x400099F")]
		Highest
	}
	[Token(Token = "0x200019F")]
	public enum TargetOptions
	{
		[Token(Token = "0x40009A1")]
		Children,
		[Token(Token = "0x40009A2")]
		OnlyThisObject,
		[Token(Token = "0x40009A3")]
		RootToChildren,
		[Token(Token = "0x40009A4")]
		Layer
	}
	[Serializable]
	[Token(Token = "0x20001A0")]
	public struct GlowPassData
	{
		[Token(Token = "0x40009A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float offset;

		[Token(Token = "0x40009A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float alpha;

		[Token(Token = "0x40009A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Color color;
	}
	[Token(Token = "0x20001A1")]
	[HelpURL("https://kronnect.freshdesk.com/support/solutions/42000065090")]
	[ExecuteInEditMode]
	public class HighlightEffect : MonoBehaviour
	{
		[Token(Token = "0x20001A2")]
		private struct ModelMaterials
		{
			[Token(Token = "0x4000A1E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool render;

			[Token(Token = "0x4000A1F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Transform transform;

			[Token(Token = "0x4000A20")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool bakedTransform;

			[Token(Token = "0x4000A21")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector3 currentPosition;

			[Token(Token = "0x4000A22")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Vector3 currentRotation;

			[Token(Token = "0x4000A23")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public Vector3 currentScale;

			[Token(Token = "0x4000A24")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool renderWasVisibleDuringSetup;

			[Token(Token = "0x4000A25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public Mesh mesh;

			[Token(Token = "0x4000A26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Mesh originalMesh;

			[Token(Token = "0x4000A27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Renderer renderer;

			[Token(Token = "0x4000A28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool skinnedMesh;

			[Token(Token = "0x4000A29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
			public Material[] fxMatMask;

			[Token(Token = "0x4000A2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
			public Material[] fxMatSolidColor;

			[Token(Token = "0x4000A2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			public Material[] fxMatSeeThrough;

			[Token(Token = "0x4000A2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			public Material[] fxMatOverlay;

			[Token(Token = "0x4000A2D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			public Material[] fxMatInnerGlow;

			[Token(Token = "0x4000A2E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
			public Matrix4x4 renderingMatrix;
		}

		[Token(Token = "0x20001A3")]
		private enum FadingState
		{
			[Token(Token = "0x4000A30")]
			FadingOut = -1,
			[Token(Token = "0x4000A31")]
			NoFading,
			[Token(Token = "0x4000A32")]
			FadingIn
		}

		[Token(Token = "0x20001A4")]
		[CompilerGenerated]
		private sealed class <OverlayOneShotAnimator>d__158 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A33")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A34")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A35")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HighlightEffect <>4__this;

			[Token(Token = "0x4000A36")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Color color;

			[Token(Token = "0x4000A37")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public float duration;

			[Token(Token = "0x4000A38")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			private float <startTime>5__2;

			[Token(Token = "0x4000A39")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private float <t>5__3;

			[Token(Token = "0x4000A3A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private WaitForEndOfFrame <ef>5__4;

			[Token(Token = "0x170001B9")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A43")]
				[Address(RVA = "0xB6E900", Offset = "0xB6E900", VA = "0xB6E900", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A45")]
				[Address(RVA = "0xB6E948", Offset = "0xB6E948", VA = "0xB6E948", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A40")]
			[Address(RVA = "0xB6E79C", Offset = "0xB6E79C", VA = "0xB6E79C")]
			[DebuggerHidden]
			public <OverlayOneShotAnimator>d__158(int <>1__state)
			{
			}

			[Token(Token = "0x6000A41")]
			[Address(RVA = "0xB6E7C4", Offset = "0xB6E7C4", VA = "0xB6E7C4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A42")]
			[Address(RVA = "0xB6E7C8", Offset = "0xB6E7C8", VA = "0xB6E7C8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A44")]
			[Address(RVA = "0xB6E908", Offset = "0xB6E908", VA = "0xB6E908", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40009A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public HighlightProfile profile;

		[Token(Token = "0x40009A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Tooltip("If enabled, settings will be synced with profile.")]
		public bool profileSync;

		[Token(Token = "0x40009AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool previewInEditor;

		[Token(Token = "0x40009AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TargetOptions effectGroup;

		[Token(Token = "0x40009AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LayerMask effectGroupLayer;

		[Token(Token = "0x40009AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[Range(0f, 1f)]
		public float alphaCutOff;

		[Token(Token = "0x40009AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool cullBackFaces;

		[Token(Token = "0x40009AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		[Tooltip("Show highlight effects even if the object is not visible. If this object or its children use GPU Instancing tools, the MeshRenderer can be disabled although the object is visible. In this case, this option is useful to enable highlighting.")]
		public bool ignoreObjectVisibility;

		[Token(Token = "0x40009B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		[Tooltip("Support reflection probes. Enable only if you want the effects to be visible in reflections.")]
		public bool reflectionProbes;

		[Token(Token = "0x40009B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
		[Tooltip("Ignore highlighting on this object.")]
		public bool ignore;

		[Token(Token = "0x40009B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _highlighted;

		[Token(Token = "0x40009B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float fadeInDuration;

		[Token(Token = "0x40009B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public float fadeOutDuration;

		[Token(Token = "0x40009B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool flipY;

		[Token(Token = "0x40009B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		public bool constantWidth;

		[Token(Token = "0x40009B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		[Range(0f, 1f)]
		public float overlay;

		[Token(Token = "0x40009B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Color overlayColor;

		[Token(Token = "0x40009B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public float overlayAnimationSpeed;

		[Token(Token = "0x40009BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[Range(0f, 1f)]
		public float overlayMinIntensity;

		[Token(Token = "0x40009BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Range(0f, 1f)]
		public float overlayBlending;

		[Token(Token = "0x40009BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		[Range(0f, 1f)]
		public float outline;

		[Token(Token = "0x40009BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public Color outlineColor;

		[Token(Token = "0x40009BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public float outlineWidth;

		[Token(Token = "0x40009BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public QualityLevel outlineQuality;

		[Token(Token = "0x40009C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[Range(1f, 8f)]
		public int outlineDownsampling;

		[Token(Token = "0x40009C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
		public bool outlineAlwaysOnTop;

		[Token(Token = "0x40009C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x85")]
		public bool outlineOptimalBlit;

		[Token(Token = "0x40009C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x86")]
		public bool outlineBlitDebug;

		[Token(Token = "0x40009C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[Range(0f, 5f)]
		public float glow;

		[Token(Token = "0x40009C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public float glowWidth;

		[Token(Token = "0x40009C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public QualityLevel glowQuality;

		[Token(Token = "0x40009C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		[Range(1f, 8f)]
		public int glowDownsampling;

		[Token(Token = "0x40009C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Color glowHQColor;

		[Token(Token = "0x40009C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool glowDithering;

		[Token(Token = "0x40009CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public float glowMagicNumber1;

		[Token(Token = "0x40009CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public float glowMagicNumber2;

		[Token(Token = "0x40009CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public float glowAnimationSpeed;

		[Token(Token = "0x40009CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public bool glowAlwaysOnTop;

		[Token(Token = "0x40009CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB9")]
		public bool glowOptimalBlit;

		[Token(Token = "0x40009CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xBA")]
		public bool glowBlitDebug;

		[Token(Token = "0x40009D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public GlowPassData[] glowPasses;

		[Token(Token = "0x40009D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[Range(0f, 5f)]
		public float innerGlow;

		[Token(Token = "0x40009D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[Range(0f, 2f)]
		public float innerGlowWidth;

		[Token(Token = "0x40009D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Color innerGlowColor;

		[Token(Token = "0x40009D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public bool innerGlowAlwaysOnTop;

		[Token(Token = "0x40009D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE1")]
		public bool targetFX;

		[Token(Token = "0x40009D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public Texture2D targetFXTexture;

		[Token(Token = "0x40009D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public Color targetFXColor;

		[Token(Token = "0x40009D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Transform targetFXCenter;

		[Token(Token = "0x40009D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		public float targetFXRotationSpeed;

		[Token(Token = "0x40009DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		public float targetFXInitialScale;

		[Token(Token = "0x40009DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		public float targetFXEndScale;

		[Token(Token = "0x40009DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
		public float targetFXTransitionDuration;

		[Token(Token = "0x40009DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		public float targetFXStayDuration;

		[Token(Token = "0x40009E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		public SeeThroughMode seeThrough;

		[Token(Token = "0x40009E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
		[Range(0f, 5f)]
		public float seeThroughIntensity;

		[Token(Token = "0x40009E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		[Range(0f, 1f)]
		public float seeThroughTintAlpha;

		[Token(Token = "0x40009E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
		public Color seeThroughTintColor;

		[Token(Token = "0x40009E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		[SerializeField]
		[HideInInspector]
		private ModelMaterials[] rms;

		[Token(Token = "0x40009E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		[HideInInspector]
		[SerializeField]
		private int rmsCount;

		[NonSerialized]
		[Token(Token = "0x40009E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		public Transform target;

		[NonSerialized]
		[Token(Token = "0x40009E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		public float highlightStartTime;

		[Token(Token = "0x40009E9")]
		private const string SKW_ALPHACLIP = "HP_ALPHACLIP";

		[Token(Token = "0x40009EA")]
		private const string UNIFORM_CUTOFF = "_CutOff";

		[Token(Token = "0x40009EB")]
		private const float TAU = 0.70711f;

		[Token(Token = "0x40009EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Material fxMatMask;

		[Token(Token = "0x40009ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static Material fxMatSolidColor;

		[Token(Token = "0x40009EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static Material fxMatSeeThrough;

		[Token(Token = "0x40009EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static Material fxMatOverlay;

		[Token(Token = "0x40009F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Material fxMatGlow;

		[Token(Token = "0x40009F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private Material fxMatInnerGlow;

		[Token(Token = "0x40009F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private Material fxMatOutline;

		[Token(Token = "0x40009F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private Material fxMatOccluder;

		[Token(Token = "0x40009F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private Material fxMatTarget;

		[Token(Token = "0x40009F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private Material fxMatComposeGlow;

		[Token(Token = "0x40009F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private Material fxMatComposeOutline;

		[Token(Token = "0x40009F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private Material fxMatBlurGlow;

		[Token(Token = "0x40009F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private Material fxMatBlurOutline;

		[Token(Token = "0x40009F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static Vector3[] offsets;

		[Token(Token = "0x40009FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private float fadeStartTime;

		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C4")]
		private FadingState fading;

		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private CommandBuffer cbOccluder;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private CommandBuffer cbMask;

		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private CommandBuffer cbSeeThrough;

		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private CommandBuffer cbGlow;

		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private CommandBuffer cbOutline;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private CommandBuffer cbOverlay;

		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private CommandBuffer cbInnerGlow;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private CommandBuffer cbSmoothBlend;

		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int[] mipGlowBuffers;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private int[] mipOutlineBuffers;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private int glowRT;

		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21C")]
		private int outlineRT;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static Mesh quadMesh;

		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private int sourceRT;

		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x224")]
		private Matrix4x4 quadGlowMatrix;

		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x264")]
		private Matrix4x4 quadOutlineMatrix;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Vector3[] corners;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private RenderTextureDescriptor sourceDesc;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E4")]
		private Color debugColor;

		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F4")]
		private Color blackColor;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private List<Renderer> tempRR;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static Vector3[] newNormals;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static int[] matches;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static Dictionary<Vector3, int> vv;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private bool overlayOneShotRunning;

		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x311")]
		private bool currentHighlighted;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x314")]
		private Color overlayOneShotCurrentColor;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x324")]
		private float overlayOneShotCurrentAnimationSpeed;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private float overlayOneShotCurrentOverlay;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32C")]
		private float overlayOneShotCurrentOuterGlow;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private float overlayOneShotCurrentInnerGlow;

		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x334")]
		private float overlayOneShotCurrentOutline;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private float overlayOneShotCurrentSeeThroughIntensity;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private Coroutine overlayOneShotCo;

		[Token(Token = "0x170001B8")]
		public bool highlighted
		{
			[Token(Token = "0x6000A18")]
			[Address(RVA = "0xB66C24", Offset = "0xB66C24", VA = "0xB66C24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A19")]
			[Address(RVA = "0xB66C2C", Offset = "0xB66C2C", VA = "0xB66C2C")]
			set
			{
			}
		}

		[Token(Token = "0x14000004")]
		public event OnObjectHighlightStartEvent OnObjectHighlightStart
		{
			[Token(Token = "0x6000A1A")]
			[Address(RVA = "0xB66E44", Offset = "0xB66E44", VA = "0xB66E44")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A1B")]
			[Address(RVA = "0xB66EE4", Offset = "0xB66EE4", VA = "0xB66EE4")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000005")]
		public event OnObjectHighlightEndEvent OnObjectHighlightEnd
		{
			[Token(Token = "0x6000A1C")]
			[Address(RVA = "0xB66F84", Offset = "0xB66F84", VA = "0xB66F84")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A1D")]
			[Address(RVA = "0xB67024", Offset = "0xB67024", VA = "0xB67024")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x14000006")]
		public event OnRendererHighlightEvent OnRendererHighlightStart
		{
			[Token(Token = "0x6000A1E")]
			[Address(RVA = "0xB670C4", Offset = "0xB670C4", VA = "0xB670C4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000A1F")]
			[Address(RVA = "0xB67164", Offset = "0xB67164", VA = "0xB67164")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Token(Token = "0x6000A20")]
		[Address(RVA = "0xB67204", Offset = "0xB67204", VA = "0xB67204")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A21")]
		[Address(RVA = "0xB684B8", Offset = "0xB684B8", VA = "0xB684B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A22")]
		[Address(RVA = "0xB69198", Offset = "0xB69198", VA = "0xB69198")]
		private void Reset()
		{
		}

		[Token(Token = "0x6000A23")]
		[Address(RVA = "0xB6919C", Offset = "0xB6919C", VA = "0xB6919C")]
		public void ProfileLoad(HighlightProfile profile)
		{
		}

		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xB69230", Offset = "0xB69230", VA = "0xB69230")]
		public void ProfileReload()
		{
		}

		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xB692B8", Offset = "0xB692B8", VA = "0xB692B8")]
		public void ProfileSaveChanges(HighlightProfile profile)
		{
		}

		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xB6934C", Offset = "0xB6934C", VA = "0xB6934C")]
		public void ProfileSaveChanges()
		{
		}

		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xB693D4", Offset = "0xB693D4", VA = "0xB693D4")]
		public void Refresh()
		{
		}

		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xB693FC", Offset = "0xB693FC", VA = "0xB693FC")]
		public void RenderOccluder()
		{
		}

		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xB69D4C", Offset = "0xB69D4C", VA = "0xB69D4C")]
		private void OnRenderObject()
		{
		}

		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xB6C040", Offset = "0xB6C040", VA = "0xB6C040")]
		private bool ComputeSmoothQuadMatrix(Camera cam, Bounds bounds)
		{
			return default(bool);
		}

		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xB6D2D8", Offset = "0xB6D2D8", VA = "0xB6D2D8")]
		private void BuildMatrix(Camera cam, Vector3 scrMin, Vector3 scrMax, int border, ref Matrix4x4 quadMatrix)
		{
		}

		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xB6C3E4", Offset = "0xB6C3E4", VA = "0xB6C3E4")]
		private void SmoothGlow(Camera cam, int sourceRT, int rtWidth, int rtHeight)
		{
		}

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xB6C9A4", Offset = "0xB6C9A4", VA = "0xB6C9A4")]
		private void SmoothOutline(Camera cam, int sourceRT, int rtWidth, int rtHeight)
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xB6CD00", Offset = "0xB6CD00", VA = "0xB6CD00")]
		private void ComposeSmoothBlend(bool glowOnTop, bool outlineOnTop)
		{
		}

		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xB6D504", Offset = "0xB6D504", VA = "0xB6D504")]
		private void InitMaterial(ref Material material, string shaderName)
		{
		}

		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xB6D694", Offset = "0xB6D694", VA = "0xB6D694")]
		public void SetTarget(Transform transform)
		{
		}

		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xB66C34", Offset = "0xB66C34", VA = "0xB66C34")]
		public void SetHighlighted(bool state)
		{
		}

		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xB67B88", Offset = "0xB67B88", VA = "0xB67B88")]
		private void SetupMaterial()
		{
		}

		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xB6D768", Offset = "0xB6D768", VA = "0xB6D768")]
		private Renderer[] FindRenderersWithLayer(LayerMask layer)
		{
			return null;
		}

		[Token(Token = "0x6000A34")]
		[Address(RVA = "0xB6793C", Offset = "0xB6793C", VA = "0xB6793C")]
		private void CheckGeometrySupportDependencies()
		{
		}

		[Token(Token = "0x6000A35")]
		[Address(RVA = "0xB6D9F4", Offset = "0xB6D9F4", VA = "0xB6D9F4")]
		private void CheckCommandBuffers()
		{
		}

		[Token(Token = "0x6000A36")]
		[Address(RVA = "0xB6E3F4", Offset = "0xB6E3F4", VA = "0xB6E3F4")]
		private void CheckBlurCommandBuffer()
		{
		}

		[Token(Token = "0x6000A37")]
		[Address(RVA = "0xB6DCD0", Offset = "0xB6DCD0", VA = "0xB6DCD0")]
		private Material[] Fork(Material mat, Mesh mesh)
		{
			return null;
		}

		[Token(Token = "0x6000A38")]
		[Address(RVA = "0xB69924", Offset = "0xB69924", VA = "0xB69924")]
		private void BakeTransform(int objIndex, bool duplicateMesh)
		{
		}

		[Token(Token = "0x6000A39")]
		[Address(RVA = "0xB684BC", Offset = "0xB684BC", VA = "0xB684BC")]
		private void UpdateMaterialProperties()
		{
		}

		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0xB67668", Offset = "0xB67668", VA = "0xB67668")]
		private void BuildQuad()
		{
		}

		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0xB6DE3C", Offset = "0xB6DE3C", VA = "0xB6DE3C")]
		private void AverageNormals(int objIndex)
		{
		}

		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0xB6E49C", Offset = "0xB6E49C", VA = "0xB6E49C")]
		public void OverlayOneShot(Color color, float duration)
		{
		}

		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0xB6E600", Offset = "0xB6E600", VA = "0xB6E600")]
		[IteratorStateMachine(typeof(<OverlayOneShotAnimator>d__158))]
		private IEnumerator OverlayOneShotAnimator(Color color, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xB6E59C", Offset = "0xB6E59C", VA = "0xB6E59C")]
		private void OverlayOneShotEnd()
		{
		}

		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xB6E6AC", Offset = "0xB6E6AC", VA = "0xB6E6AC")]
		public HighlightEffect()
		{
		}
	}
	[Token(Token = "0x20001A5")]
	[HelpURL("https://kronnect.freshdesk.com/support/solutions/42000065090")]
	[RequireComponent(typeof(HighlightEffect))]
	public class HighlightManager : MonoBehaviour
	{
		[Token(Token = "0x4000A3B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LayerMask layerMask;

		[Token(Token = "0x4000A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera raycastCamera;

		[Token(Token = "0x4000A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayCastSource raycastSource;

		[Token(Token = "0x4000A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private HighlightEffect baseEffect;

		[Token(Token = "0x4000A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private HighlightEffect currentEffect;

		[Token(Token = "0x4000A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Transform currentObject;

		[Token(Token = "0x6000A46")]
		[Address(RVA = "0xB6E950", Offset = "0xB6E950", VA = "0xB6E950")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A47")]
		[Address(RVA = "0xB6EC08", Offset = "0xB6EC08", VA = "0xB6EC08")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000A48")]
		[Address(RVA = "0xB6EE00", Offset = "0xB6EE00", VA = "0xB6EE00")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A49")]
		[Address(RVA = "0xB6EC10", Offset = "0xB6EC10", VA = "0xB6EC10")]
		private void SwitchesCollider(Transform newObject)
		{
		}

		[Token(Token = "0x6000A4A")]
		[Address(RVA = "0xB6EB60", Offset = "0xB6EB60", VA = "0xB6EB60")]
		public static Camera GetCamera()
		{
			return null;
		}

		[Token(Token = "0x6000A4B")]
		[Address(RVA = "0xB6F004", Offset = "0xB6F004", VA = "0xB6F004")]
		public HighlightManager()
		{
		}
	}
	[Token(Token = "0x20001A6")]
	[HelpURL("https://kronnect.freshdesk.com/support/solutions/42000065090")]
	[CreateAssetMenu(menuName = "Highlight Plus Profile", fileName = "Highlight Plus Profile", order = 100)]
	public class HighlightProfile : ScriptableObject
	{
		[Token(Token = "0x4000A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TargetOptions effectGroup;

		[Token(Token = "0x4000A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LayerMask effectGroupLayer;

		[Token(Token = "0x4000A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[Range(0f, 1f)]
		public float alphaCutOff;

		[Token(Token = "0x4000A44")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public bool cullBackFaces;

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float fadeInDuration;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float fadeOutDuration;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		public float overlay;

		[Token(Token = "0x4000A48")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public Color overlayColor;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float overlayAnimationSpeed;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Range(0f, 1f)]
		public float overlayMinIntensity;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		[Range(0f, 1f)]
		public float overlayBlending;

		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Range(0f, 1f)]
		public float outline;

		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public Color outlineColor;

		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float outlineWidth;

		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public QualityLevel outlineQuality;

		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		public bool outlineAlwaysOnTop;

		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[Range(0f, 5f)]
		public float glow;

		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public float glowWidth;

		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public QualityLevel glowQuality;

		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		public Color glowHQColor;

		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
		public bool glowDithering;

		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public float glowMagicNumber1;

		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
		public float glowMagicNumber2;

		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public float glowAnimationSpeed;

		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
		public bool glowAlwaysOnTop;

		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public GlowPassData[] glowPasses;

		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[Range(0f, 5f)]
		public float innerGlow;

		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		[Range(0f, 2f)]
		public float innerGlowWidth;

		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public Color innerGlowColor;

		[Token(Token = "0x4000A5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public bool innerGlowAlwaysOnTop;

		[Token(Token = "0x4000A5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC1")]
		public bool targetFX;

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public Texture2D targetFXTexture;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public Color targetFXColor;

		[Token(Token = "0x4000A62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		public float targetFXRotationSpeed;

		[Token(Token = "0x4000A63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
		public float targetFXInitialScale;

		[Token(Token = "0x4000A64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		public float targetFXEndScale;

		[Token(Token = "0x4000A65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
		public float targetFXTransitionDuration;

		[Token(Token = "0x4000A66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public float targetFXStayDuration;

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		public SeeThroughMode seeThrough;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		[Range(0f, 5f)]
		public float seeThroughIntensity;

		[Token(Token = "0x4000A69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		[Range(0f, 1f)]
		public float seeThroughTintAlpha;

		[Token(Token = "0x4000A6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		public Color seeThroughTintColor;

		[Token(Token = "0x6000A4C")]
		[Address(RVA = "0xB6F02C", Offset = "0xB6F02C", VA = "0xB6F02C")]
		public void Load(HighlightEffect effect)
		{
		}

		[Token(Token = "0x6000A4D")]
		[Address(RVA = "0xB6F23C", Offset = "0xB6F23C", VA = "0xB6F23C")]
		public void Save(HighlightEffect effect)
		{
		}

		[Token(Token = "0x6000A4E")]
		[Address(RVA = "0xB6F168", Offset = "0xB6F168", VA = "0xB6F168")]
		private GlowPassData[] GetGlowPassesCopy(GlowPassData[] glowPasses)
		{
			return null;
		}

		[Token(Token = "0x6000A4F")]
		[Address(RVA = "0xB6F37C", Offset = "0xB6F37C", VA = "0xB6F37C")]
		public HighlightProfile()
		{
		}
	}
	[Token(Token = "0x20001A7")]
	[HelpURL("https://kronnect.freshdesk.com/support/solutions/42000065090")]
	[RequireComponent(typeof(HighlightEffect))]
	[ExecuteInEditMode]
	public class HighlightSeeThroughOccluder : MonoBehaviour
	{
		[Token(Token = "0x4000A6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HighlightEffect effect;

		[Token(Token = "0x6000A50")]
		[Address(RVA = "0xB6F448", Offset = "0xB6F448", VA = "0xB6F448")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000A51")]
		[Address(RVA = "0xB6F4A0", Offset = "0xB6F4A0", VA = "0xB6F4A0")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A52")]
		[Address(RVA = "0xB6F4BC", Offset = "0xB6F4BC", VA = "0xB6F4BC")]
		public HighlightSeeThroughOccluder()
		{
		}
	}
	[Token(Token = "0x20001A8")]
	public enum TriggerMode
	{
		[Token(Token = "0x4000A6D")]
		ColliderEventsOnlyOnThisObject,
		[Token(Token = "0x4000A6E")]
		RaycastOnThisObjectAndChildren
	}
	[Token(Token = "0x20001A9")]
	public enum RayCastSource
	{
		[Token(Token = "0x4000A70")]
		MousePosition,
		[Token(Token = "0x4000A71")]
		CameraDirection
	}
	[Token(Token = "0x20001AA")]
	[RequireComponent(typeof(HighlightEffect))]
	[ExecuteInEditMode]
	[HelpURL("https://kronnect.freshdesk.com/support/solutions/42000065090")]
	public class HighlightTrigger : MonoBehaviour
	{
		[Token(Token = "0x20001AB")]
		[CompilerGenerated]
		private sealed class <DoRayCast>d__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A79")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A7A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000A7B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HighlightTrigger <>4__this;

			[Token(Token = "0x170001BB")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000A60")]
				[Address(RVA = "0xB6FE34", Offset = "0xB6FE34", VA = "0xB6FE34", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BC")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000A62")]
				[Address(RVA = "0xB6FE7C", Offset = "0xB6FE7C", VA = "0xB6FE7C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000A5D")]
			[Address(RVA = "0xB6F8B0", Offset = "0xB6F8B0", VA = "0xB6F8B0")]
			[DebuggerHidden]
			public <DoRayCast>d__9(int <>1__state)
			{
			}

			[Token(Token = "0x6000A5E")]
			[Address(RVA = "0xB6FB28", Offset = "0xB6FB28", VA = "0xB6FB28", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000A5F")]
			[Address(RVA = "0xB6FB2C", Offset = "0xB6FB2C", VA = "0xB6FB2C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000A61")]
			[Address(RVA = "0xB6FE3C", Offset = "0xB6FE3C", VA = "0xB6FE3C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[Tooltip("Used to trigger automatic highlighting including children objects.")]
		public TriggerMode triggerMode;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Camera raycastCamera;

		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RayCastSource raycastSource;

		[Token(Token = "0x4000A75")]
		private const int MAX_RAYCAST_HITS = 100;

		[NonSerialized]
		[Token(Token = "0x4000A76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Collider[] colliders;

		[Token(Token = "0x4000A77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Collider currentCollider;

		[Token(Token = "0x4000A78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static RaycastHit[] hits;

		[Token(Token = "0x6000A53")]
		[Address(RVA = "0xB6F4C4", Offset = "0xB6F4C4", VA = "0xB6F4C4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0xB6F598", Offset = "0xB6F598", VA = "0xB6F598")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0xB6F83C", Offset = "0xB6F83C", VA = "0xB6F83C")]
		[IteratorStateMachine(typeof(<DoRayCast>d__9))]
		private IEnumerator DoRayCast()
		{
			return null;
		}

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0xB6F8D8", Offset = "0xB6F8D8", VA = "0xB6F8D8")]
		private void SwitchCollider(Collider newCollider)
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0xB6FA84", Offset = "0xB6FA84", VA = "0xB6FA84")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0xB6FAB8", Offset = "0xB6FAB8", VA = "0xB6FAB8")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0xB6FAEC", Offset = "0xB6FAEC", VA = "0xB6FAEC")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0xB6F964", Offset = "0xB6F964", VA = "0xB6F964")]
		private void Highlight(bool state)
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0xB6F4C8", Offset = "0xB6F4C8", VA = "0xB6F4C8")]
		public void Init()
		{
		}

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0xB6FB20", Offset = "0xB6FB20", VA = "0xB6FB20")]
		public HighlightTrigger()
		{
		}
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x20001AC")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0xB6FE84", Offset = "0xB6FE84", VA = "0xB6FE84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0xB6FFC4", Offset = "0xB6FFC4", VA = "0xB6FFC4")]
		public ParticleSystemMultiplier()
		{
		}
	}
}
