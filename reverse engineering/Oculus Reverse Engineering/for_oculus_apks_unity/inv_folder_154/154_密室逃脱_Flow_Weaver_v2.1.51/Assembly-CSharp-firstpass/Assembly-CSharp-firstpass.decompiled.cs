using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[assembly: AssemblyVersion("0.0.0.0")]
[Serializable]
[Token(Token = "0x2000002")]
public class FMODEventPlayable : PlayableAsset, ITimelineClipAsset
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FMODEventPlayableBehavior template;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA84", Offset = "0x8DCA84")]
	private GameObject <TrackTargetObject>k__BackingField;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float eventLength;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private FMODEventPlayableBehavior behavior;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[EventRef]
	[SerializeField]
	public string eventName;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	public STOP_MODE stopType;

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	public ParamRef[] parameters;

	[NonSerialized]
	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool cachedParameters;

	[Token(Token = "0x4000009")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCAEC", Offset = "0x8DCAEC")]
	private TimelineClip <OwningClip>k__BackingField;

	[Token(Token = "0x17000001")]
	public GameObject TrackTargetObject
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1AED208", Offset = "0x1AED208", VA = "0x1AED208")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCCDC", Offset = "0x8DCCDC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1AED210", Offset = "0x1AED210", VA = "0x1AED210")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCCEC", Offset = "0x8DCCEC")]
		set
		{
		}
	}

	[Token(Token = "0x17000002")]
	public override double duration
	{
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1AED218", Offset = "0x1AED218", VA = "0x1AED218", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Token(Token = "0x17000003")]
	public ClipCaps clipCaps
	{
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1AED234", Offset = "0x1AED234", VA = "0x1AED234", Slot = "9")]
		get
		{
			return default(ClipCaps);
		}
	}

	[Token(Token = "0x17000004")]
	public TimelineClip OwningClip
	{
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x1AED23C", Offset = "0x1AED23C", VA = "0x1AED23C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCCFC", Offset = "0x8DCCFC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x1AED244", Offset = "0x1AED244", VA = "0x1AED244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCD0C", Offset = "0x8DCD0C")]
		set
		{
		}
	}

	[Token(Token = "0x6000007")]
	[Address(RVA = "0x1AED24C", Offset = "0x1AED24C", VA = "0x1AED24C", Slot = "6")]
	public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000008")]
	[Address(RVA = "0x1AED4E0", Offset = "0x1AED4E0", VA = "0x1AED4E0")]
	public FMODEventPlayable()
	{
	}
}
[Token(Token = "0x2000003")]
public enum STOP_MODE
{
	[Token(Token = "0x400000B")]
	AllowFadeout,
	[Token(Token = "0x400000C")]
	Immediate,
	[Token(Token = "0x400000D")]
	None
}
[Token(Token = "0x2000004")]
public class FMODEventPlayableBehavior : PlayableBehaviour
{
	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string eventName;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public STOP_MODE stopType;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ParamRef[] parameters;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject TrackTargetObject;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TimelineClip OwningClip;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool isPlayheadInside;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance eventInstance;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool isPaused;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int pausedPos;

	[Token(Token = "0x6000009")]
	[Address(RVA = "0x1AED5BC", Offset = "0x1AED5BC", VA = "0x1AED5BC")]
	protected void PlayEvent()
	{
	}

	[Token(Token = "0x600000A")]
	[Address(RVA = "0x1AEDC30", Offset = "0x1AEDC30", VA = "0x1AEDC30")]
	public void OnEnter()
	{
	}

	[Token(Token = "0x600000B")]
	[Address(RVA = "0x1AEDD4C", Offset = "0x1AEDD4C", VA = "0x1AEDD4C")]
	public void OnExit()
	{
	}

	[Token(Token = "0x600000C")]
	[Address(RVA = "0x1AED0EC", Offset = "0x1AED0EC", VA = "0x1AED0EC")]
	public void UpdateBehaviour(float time)
	{
	}

	[Token(Token = "0x600000D")]
	[Address(RVA = "0x1AEDDB8", Offset = "0x1AEDDB8", VA = "0x1AEDDB8", Slot = "14")]
	public override void OnGraphStop(Playable playable)
	{
	}

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1AED55C", Offset = "0x1AED55C", VA = "0x1AED55C")]
	public FMODEventPlayableBehavior()
	{
	}
}
[Token(Token = "0x2000005")]
[AttributeAttribute(Name = "TrackColorAttribute", RVA = "0x8DC69C", Offset = "0x8DC69C")]
[AttributeAttribute(Name = "TrackClipTypeAttribute", RVA = "0x8DC69C", Offset = "0x8DC69C")]
[AttributeAttribute(Name = "TrackBindingTypeAttribute", RVA = "0x8DC69C", Offset = "0x8DC69C")]
public class FMODEventTrack : TrackAsset
{
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1AEDED8", Offset = "0x1AEDED8", VA = "0x1AEDED8", Slot = "23")]
	public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
	{
		return default(Playable);
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1AEE2C8", Offset = "0x1AEE2C8", VA = "0x1AEE2C8")]
	public FMODEventTrack()
	{
	}
}
[Token(Token = "0x2000006")]
public class FMODEventMixerBehaviour : PlayableBehaviour
{
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1AECF78", Offset = "0x1AECF78", VA = "0x1AECF78", Slot = "20")]
	public override void ProcessFrame(Playable playable, FrameData info, object playerData)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1AED154", Offset = "0x1AED154", VA = "0x1AED154", Slot = "18")]
	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1AED200", Offset = "0x1AED200", VA = "0x1AED200")]
	public FMODEventMixerBehaviour()
	{
	}
}
namespace UnityStandardAssets.Effects
{
	[Token(Token = "0x2000007")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x8DC750", Offset = "0x8DC750")]
	public class AfterburnerPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x4000017")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float effectAngle;

		[Token(Token = "0x4000018")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float effectWidth;

		[Token(Token = "0x4000019")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float effectDistance;

		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float force;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Collider[] m_Cols;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private SphereCollider m_Sphere;

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x1AF6C54", Offset = "0x1AF6C54", VA = "0x1AF6C54")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x1AF6CEC", Offset = "0x1AF6CEC", VA = "0x1AF6CEC")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x1AF71B8", Offset = "0x1AF71B8", VA = "0x1AF71B8")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x1AF7708", Offset = "0x1AF7708", VA = "0x1AF7708")]
		public AfterburnerPhysicsForce()
		{
		}
	}
	[Token(Token = "0x2000008")]
	public class ExplosionFireAndDebris : MonoBehaviour
	{
		[Token(Token = "0x200010E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA04", Offset = "0x8DCA04")]
		private sealed class <Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionFireAndDebris <>4__this;

			[Token(Token = "0x4000552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private float <multiplier>5__2;

			[Token(Token = "0x17000014")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B1")]
				[Address(RVA = "0x1AF7F40", Offset = "0x1AF7F40", VA = "0x1AF7F40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000015")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B3")]
				[Address(RVA = "0x1AF7FAC", Offset = "0x1AF7FAC", VA = "0x1AF7FAC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x1AF7790", Offset = "0x1AF7790", VA = "0x1AF7790")]
			[DebuggerHidden]
			public <Start>d__4(int <>1__state)
			{
			}

			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x1AF7948", Offset = "0x1AF7948", VA = "0x1AF7948", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x1AF794C", Offset = "0x1AF794C", VA = "0x1AF794C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x1AF7F48", Offset = "0x1AF7F48", VA = "0x1AF7F48", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400001D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform[] debrisPrefabs;

		[Token(Token = "0x400001E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform firePrefab;

		[Token(Token = "0x400001F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int numDebrisPieces;

		[Token(Token = "0x4000020")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public int numFires;

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1AF771C", Offset = "0x1AF771C", VA = "0x1AF771C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DCD1C", Offset = "0x8DCD1C")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x1AF77BC", Offset = "0x1AF77BC", VA = "0x1AF77BC")]
		private void AddFire(Transform t, Vector3 pos, Vector3 normal)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x1AF7940", Offset = "0x1AF7940", VA = "0x1AF7940")]
		public ExplosionFireAndDebris()
		{
		}
	}
	[Token(Token = "0x2000009")]
	public class ExplosionPhysicsForce : MonoBehaviour
	{
		[Token(Token = "0x200010F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA14", Offset = "0x8DCA14")]
		private sealed class <Start>d__1 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ExplosionPhysicsForce <>4__this;

			[Token(Token = "0x17000016")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006B7")]
				[Address(RVA = "0x1AF8378", Offset = "0x1AF8378", VA = "0x1AF8378", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000017")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006B9")]
				[Address(RVA = "0x1AF83E4", Offset = "0x1AF83E4", VA = "0x1AF83E4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006B4")]
			[Address(RVA = "0x1AF8028", Offset = "0x1AF8028", VA = "0x1AF8028")]
			[DebuggerHidden]
			public <Start>d__1(int <>1__state)
			{
			}

			[Token(Token = "0x60006B5")]
			[Address(RVA = "0x1AF8064", Offset = "0x1AF8064", VA = "0x1AF8064", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006B6")]
			[Address(RVA = "0x1AF8068", Offset = "0x1AF8068", VA = "0x1AF8068", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x1AF8380", Offset = "0x1AF8380", VA = "0x1AF8380", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000021")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float explosionForce;

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x1AF7FB4", Offset = "0x1AF7FB4", VA = "0x1AF7FB4")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DCD80", Offset = "0x8DCD80")]
		private IEnumerator Start()
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x1AF8054", Offset = "0x1AF8054", VA = "0x1AF8054")]
		public ExplosionPhysicsForce()
		{
		}
	}
	[Token(Token = "0x200000A")]
	public class ExtinguishableParticleSystem : MonoBehaviour
	{
		[Token(Token = "0x4000022")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x4000023")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ParticleSystem[] m_Systems;

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x1AF83EC", Offset = "0x1AF83EC", VA = "0x1AF83EC")]
		private void Start()
		{
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x1AF8444", Offset = "0x1AF8444", VA = "0x1AF8444")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x1AF84DC", Offset = "0x1AF84DC", VA = "0x1AF84DC")]
		public ExtinguishableParticleSystem()
		{
		}
	}
	[Token(Token = "0x200000B")]
	public class FireLight : MonoBehaviour
	{
		[Token(Token = "0x4000024")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private float m_Rnd;

		[Token(Token = "0x4000025")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private bool m_Burning;

		[Token(Token = "0x4000026")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Light m_Light;

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x1AF84EC", Offset = "0x1AF84EC", VA = "0x1AF84EC")]
		private void Start()
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x1AF855C", Offset = "0x1AF855C", VA = "0x1AF855C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x1AF87C0", Offset = "0x1AF87C0", VA = "0x1AF87C0")]
		public void Extinguish()
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x1AF87E8", Offset = "0x1AF87E8", VA = "0x1AF87E8")]
		public FireLight()
		{
		}
	}
	[Token(Token = "0x200000C")]
	public class Hose : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float maxPower;

		[Token(Token = "0x4000028")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float minPower;

		[Token(Token = "0x4000029")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float changeSpeed;

		[Token(Token = "0x400002A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ParticleSystem[] hoseWaterSystems;

		[Token(Token = "0x400002B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Renderer systemRenderer;

		[Token(Token = "0x400002C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_Power;

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x1AF87F8", Offset = "0x1AF87F8", VA = "0x1AF87F8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x1AF89C4", Offset = "0x1AF89C4", VA = "0x1AF89C4")]
		public Hose()
		{
		}
	}
	[Token(Token = "0x200000D")]
	public class ParticleSystemMultiplier : MonoBehaviour
	{
		[Token(Token = "0x400002D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float multiplier;

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x1AF89E0", Offset = "0x1AF89E0", VA = "0x1AF89E0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x1AF8B74", Offset = "0x1AF8B74", VA = "0x1AF8B74")]
		public ParticleSystemMultiplier()
		{
		}
	}
	[Token(Token = "0x200000E")]
	public class SmokeParticles : MonoBehaviour
	{
		[Token(Token = "0x400002E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AudioClip[] extinguishSounds;

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x1AF8B84", Offset = "0x1AF8B84", VA = "0x1AF8B84")]
		private void Start()
		{
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x1AF8C50", Offset = "0x1AF8C50", VA = "0x1AF8C50")]
		public SmokeParticles()
		{
		}
	}
	[Token(Token = "0x200000F")]
	public class WaterHoseParticles : MonoBehaviour
	{
		[Token(Token = "0x400002F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static float lastSoundTime;

		[Token(Token = "0x4000030")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float force;

		[Token(Token = "0x4000031")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<ParticleCollisionEvent> m_CollisionEvents;

		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ParticleSystem m_ParticleSystem;

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x1AF8C58", Offset = "0x1AF8C58", VA = "0x1AF8C58")]
		private void Start()
		{
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x1AF8CB0", Offset = "0x1AF8CB0", VA = "0x1AF8CB0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x1AF8F44", Offset = "0x1AF8F44", VA = "0x1AF8F44")]
		public WaterHoseParticles()
		{
		}
	}
}
namespace FMOD
{
	[Token(Token = "0x2000010")]
	public class VERSION
	{
		[Token(Token = "0x4000033")]
		public const int number = 131075;

		[Token(Token = "0x4000034")]
		public const string dll = "fmod";

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x1AECF70", Offset = "0x1AECF70", VA = "0x1AECF70")]
		public VERSION()
		{
		}
	}
	[Token(Token = "0x2000011")]
	public class CONSTANTS
	{
		[Token(Token = "0x4000035")]
		public const int MAX_CHANNEL_WIDTH = 32;

		[Token(Token = "0x4000036")]
		public const int MAX_LISTENERS = 8;

		[Token(Token = "0x4000037")]
		public const int REVERB_MAXINSTANCES = 4;

		[Token(Token = "0x4000038")]
		public const int MAX_SYSTEMS = 8;

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x175F65C", Offset = "0x175F65C", VA = "0x175F65C")]
		public CONSTANTS()
		{
		}
	}
	[Token(Token = "0x2000012")]
	public enum RESULT
	{
		[Token(Token = "0x400003A")]
		OK,
		[Token(Token = "0x400003B")]
		ERR_BADCOMMAND,
		[Token(Token = "0x400003C")]
		ERR_CHANNEL_ALLOC,
		[Token(Token = "0x400003D")]
		ERR_CHANNEL_STOLEN,
		[Token(Token = "0x400003E")]
		ERR_DMA,
		[Token(Token = "0x400003F")]
		ERR_DSP_CONNECTION,
		[Token(Token = "0x4000040")]
		ERR_DSP_DONTPROCESS,
		[Token(Token = "0x4000041")]
		ERR_DSP_FORMAT,
		[Token(Token = "0x4000042")]
		ERR_DSP_INUSE,
		[Token(Token = "0x4000043")]
		ERR_DSP_NOTFOUND,
		[Token(Token = "0x4000044")]
		ERR_DSP_RESERVED,
		[Token(Token = "0x4000045")]
		ERR_DSP_SILENCE,
		[Token(Token = "0x4000046")]
		ERR_DSP_TYPE,
		[Token(Token = "0x4000047")]
		ERR_FILE_BAD,
		[Token(Token = "0x4000048")]
		ERR_FILE_COULDNOTSEEK,
		[Token(Token = "0x4000049")]
		ERR_FILE_DISKEJECTED,
		[Token(Token = "0x400004A")]
		ERR_FILE_EOF,
		[Token(Token = "0x400004B")]
		ERR_FILE_ENDOFDATA,
		[Token(Token = "0x400004C")]
		ERR_FILE_NOTFOUND,
		[Token(Token = "0x400004D")]
		ERR_FORMAT,
		[Token(Token = "0x400004E")]
		ERR_HEADER_MISMATCH,
		[Token(Token = "0x400004F")]
		ERR_HTTP,
		[Token(Token = "0x4000050")]
		ERR_HTTP_ACCESS,
		[Token(Token = "0x4000051")]
		ERR_HTTP_PROXY_AUTH,
		[Token(Token = "0x4000052")]
		ERR_HTTP_SERVER_ERROR,
		[Token(Token = "0x4000053")]
		ERR_HTTP_TIMEOUT,
		[Token(Token = "0x4000054")]
		ERR_INITIALIZATION,
		[Token(Token = "0x4000055")]
		ERR_INITIALIZED,
		[Token(Token = "0x4000056")]
		ERR_INTERNAL,
		[Token(Token = "0x4000057")]
		ERR_INVALID_FLOAT,
		[Token(Token = "0x4000058")]
		ERR_INVALID_HANDLE,
		[Token(Token = "0x4000059")]
		ERR_INVALID_PARAM,
		[Token(Token = "0x400005A")]
		ERR_INVALID_POSITION,
		[Token(Token = "0x400005B")]
		ERR_INVALID_SPEAKER,
		[Token(Token = "0x400005C")]
		ERR_INVALID_SYNCPOINT,
		[Token(Token = "0x400005D")]
		ERR_INVALID_THREAD,
		[Token(Token = "0x400005E")]
		ERR_INVALID_VECTOR,
		[Token(Token = "0x400005F")]
		ERR_MAXAUDIBLE,
		[Token(Token = "0x4000060")]
		ERR_MEMORY,
		[Token(Token = "0x4000061")]
		ERR_MEMORY_CANTPOINT,
		[Token(Token = "0x4000062")]
		ERR_NEEDS3D,
		[Token(Token = "0x4000063")]
		ERR_NEEDSHARDWARE,
		[Token(Token = "0x4000064")]
		ERR_NET_CONNECT,
		[Token(Token = "0x4000065")]
		ERR_NET_SOCKET_ERROR,
		[Token(Token = "0x4000066")]
		ERR_NET_URL,
		[Token(Token = "0x4000067")]
		ERR_NET_WOULD_BLOCK,
		[Token(Token = "0x4000068")]
		ERR_NOTREADY,
		[Token(Token = "0x4000069")]
		ERR_OUTPUT_ALLOCATED,
		[Token(Token = "0x400006A")]
		ERR_OUTPUT_CREATEBUFFER,
		[Token(Token = "0x400006B")]
		ERR_OUTPUT_DRIVERCALL,
		[Token(Token = "0x400006C")]
		ERR_OUTPUT_FORMAT,
		[Token(Token = "0x400006D")]
		ERR_OUTPUT_INIT,
		[Token(Token = "0x400006E")]
		ERR_OUTPUT_NODRIVERS,
		[Token(Token = "0x400006F")]
		ERR_PLUGIN,
		[Token(Token = "0x4000070")]
		ERR_PLUGIN_MISSING,
		[Token(Token = "0x4000071")]
		ERR_PLUGIN_RESOURCE,
		[Token(Token = "0x4000072")]
		ERR_PLUGIN_VERSION,
		[Token(Token = "0x4000073")]
		ERR_RECORD,
		[Token(Token = "0x4000074")]
		ERR_REVERB_CHANNELGROUP,
		[Token(Token = "0x4000075")]
		ERR_REVERB_INSTANCE,
		[Token(Token = "0x4000076")]
		ERR_SUBSOUNDS,
		[Token(Token = "0x4000077")]
		ERR_SUBSOUND_ALLOCATED,
		[Token(Token = "0x4000078")]
		ERR_SUBSOUND_CANTMOVE,
		[Token(Token = "0x4000079")]
		ERR_TAGNOTFOUND,
		[Token(Token = "0x400007A")]
		ERR_TOOMANYCHANNELS,
		[Token(Token = "0x400007B")]
		ERR_TRUNCATED,
		[Token(Token = "0x400007C")]
		ERR_UNIMPLEMENTED,
		[Token(Token = "0x400007D")]
		ERR_UNINITIALIZED,
		[Token(Token = "0x400007E")]
		ERR_UNSUPPORTED,
		[Token(Token = "0x400007F")]
		ERR_VERSION,
		[Token(Token = "0x4000080")]
		ERR_EVENT_ALREADY_LOADED,
		[Token(Token = "0x4000081")]
		ERR_EVENT_LIVEUPDATE_BUSY,
		[Token(Token = "0x4000082")]
		ERR_EVENT_LIVEUPDATE_MISMATCH,
		[Token(Token = "0x4000083")]
		ERR_EVENT_LIVEUPDATE_TIMEOUT,
		[Token(Token = "0x4000084")]
		ERR_EVENT_NOTFOUND,
		[Token(Token = "0x4000085")]
		ERR_STUDIO_UNINITIALIZED,
		[Token(Token = "0x4000086")]
		ERR_STUDIO_NOT_LOADED,
		[Token(Token = "0x4000087")]
		ERR_INVALID_STRING,
		[Token(Token = "0x4000088")]
		ERR_ALREADY_LOCKED,
		[Token(Token = "0x4000089")]
		ERR_NOT_LOCKED,
		[Token(Token = "0x400008A")]
		ERR_RECORD_DISCONNECTED,
		[Token(Token = "0x400008B")]
		ERR_TOOMANYSAMPLES
	}
	[Token(Token = "0x2000013")]
	public enum CHANNELCONTROL_TYPE
	{
		[Token(Token = "0x400008D")]
		CHANNEL,
		[Token(Token = "0x400008E")]
		CHANNELGROUP,
		[Token(Token = "0x400008F")]
		MAX
	}
	[Token(Token = "0x2000014")]
	public struct VECTOR
	{
		[Token(Token = "0x4000090")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float x;

		[Token(Token = "0x4000091")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float y;

		[Token(Token = "0x4000092")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float z;
	}
	[Token(Token = "0x2000015")]
	public struct ATTRIBUTES_3D
	{
		[Token(Token = "0x4000093")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public VECTOR position;

		[Token(Token = "0x4000094")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public VECTOR velocity;

		[Token(Token = "0x4000095")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public VECTOR forward;

		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public VECTOR up;
	}
	[Token(Token = "0x2000016")]
	public struct ASYNCREADINFO
	{
		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint offset;

		[Token(Token = "0x4000099")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public uint sizebytes;

		[Token(Token = "0x400009A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int priority;

		[Token(Token = "0x400009B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr userdata;

		[Token(Token = "0x400009C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntPtr buffer;

		[Token(Token = "0x400009D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public uint bytesread;

		[Token(Token = "0x400009E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_ASYNCDONE_FUNC done;
	}
	[Token(Token = "0x2000017")]
	public enum OUTPUTTYPE
	{
		[Token(Token = "0x40000A0")]
		AUTODETECT,
		[Token(Token = "0x40000A1")]
		UNKNOWN,
		[Token(Token = "0x40000A2")]
		NOSOUND,
		[Token(Token = "0x40000A3")]
		WAVWRITER,
		[Token(Token = "0x40000A4")]
		NOSOUND_NRT,
		[Token(Token = "0x40000A5")]
		WAVWRITER_NRT,
		[Token(Token = "0x40000A6")]
		WASAPI,
		[Token(Token = "0x40000A7")]
		ASIO,
		[Token(Token = "0x40000A8")]
		PULSEAUDIO,
		[Token(Token = "0x40000A9")]
		ALSA,
		[Token(Token = "0x40000AA")]
		COREAUDIO,
		[Token(Token = "0x40000AB")]
		AUDIOTRACK,
		[Token(Token = "0x40000AC")]
		OPENSL,
		[Token(Token = "0x40000AD")]
		AUDIOOUT,
		[Token(Token = "0x40000AE")]
		AUDIO3D,
		[Token(Token = "0x40000AF")]
		WEBAUDIO,
		[Token(Token = "0x40000B0")]
		NNAUDIO,
		[Token(Token = "0x40000B1")]
		WINSONIC,
		[Token(Token = "0x40000B2")]
		AAUDIO,
		[Token(Token = "0x40000B3")]
		MAX
	}
	[Token(Token = "0x2000018")]
	public enum DEBUG_MODE
	{
		[Token(Token = "0x40000B5")]
		TTY,
		[Token(Token = "0x40000B6")]
		FILE,
		[Token(Token = "0x40000B7")]
		CALLBACK
	}
	[Token(Token = "0x2000019")]
	[Flags]
	public enum DEBUG_FLAGS : uint
	{
		[Token(Token = "0x40000B9")]
		NONE = 0u,
		[Token(Token = "0x40000BA")]
		ERROR = 1u,
		[Token(Token = "0x40000BB")]
		WARNING = 2u,
		[Token(Token = "0x40000BC")]
		LOG = 4u,
		[Token(Token = "0x40000BD")]
		TYPE_MEMORY = 0x100u,
		[Token(Token = "0x40000BE")]
		TYPE_FILE = 0x200u,
		[Token(Token = "0x40000BF")]
		TYPE_CODEC = 0x400u,
		[Token(Token = "0x40000C0")]
		TYPE_TRACE = 0x800u,
		[Token(Token = "0x40000C1")]
		DISPLAY_TIMESTAMPS = 0x10000u,
		[Token(Token = "0x40000C2")]
		DISPLAY_LINENUMBERS = 0x20000u,
		[Token(Token = "0x40000C3")]
		DISPLAY_THREAD = 0x40000u
	}
	[Token(Token = "0x200001A")]
	[Flags]
	public enum MEMORY_TYPE : uint
	{
		[Token(Token = "0x40000C5")]
		NORMAL = 0u,
		[Token(Token = "0x40000C6")]
		STREAM_FILE = 1u,
		[Token(Token = "0x40000C7")]
		STREAM_DECODE = 2u,
		[Token(Token = "0x40000C8")]
		SAMPLEDATA = 4u,
		[Token(Token = "0x40000C9")]
		DSP_BUFFER = 8u,
		[Token(Token = "0x40000CA")]
		PLUGIN = 0x10u,
		[Token(Token = "0x40000CB")]
		PERSISTENT = 0x200000u,
		[Token(Token = "0x40000CC")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200001B")]
	public enum SPEAKERMODE
	{
		[Token(Token = "0x40000CE")]
		DEFAULT,
		[Token(Token = "0x40000CF")]
		RAW,
		[Token(Token = "0x40000D0")]
		MONO,
		[Token(Token = "0x40000D1")]
		STEREO,
		[Token(Token = "0x40000D2")]
		QUAD,
		[Token(Token = "0x40000D3")]
		SURROUND,
		[Token(Token = "0x40000D4")]
		_5POINT1,
		[Token(Token = "0x40000D5")]
		_7POINT1,
		[Token(Token = "0x40000D6")]
		_7POINT1POINT4,
		[Token(Token = "0x40000D7")]
		MAX
	}
	[Token(Token = "0x200001C")]
	public enum SPEAKER
	{
		[Token(Token = "0x40000D9")]
		NONE = -1,
		[Token(Token = "0x40000DA")]
		FRONT_LEFT,
		[Token(Token = "0x40000DB")]
		FRONT_RIGHT,
		[Token(Token = "0x40000DC")]
		FRONT_CENTER,
		[Token(Token = "0x40000DD")]
		LOW_FREQUENCY,
		[Token(Token = "0x40000DE")]
		SURROUND_LEFT,
		[Token(Token = "0x40000DF")]
		SURROUND_RIGHT,
		[Token(Token = "0x40000E0")]
		BACK_LEFT,
		[Token(Token = "0x40000E1")]
		BACK_RIGHT,
		[Token(Token = "0x40000E2")]
		TOP_FRONT_LEFT,
		[Token(Token = "0x40000E3")]
		TOP_FRONT_RIGHT,
		[Token(Token = "0x40000E4")]
		TOP_BACK_LEFT,
		[Token(Token = "0x40000E5")]
		TOP_BACK_RIGHT,
		[Token(Token = "0x40000E6")]
		MAX
	}
	[Token(Token = "0x200001D")]
	[Flags]
	public enum CHANNELMASK : uint
	{
		[Token(Token = "0x40000E8")]
		FRONT_LEFT = 1u,
		[Token(Token = "0x40000E9")]
		FRONT_RIGHT = 2u,
		[Token(Token = "0x40000EA")]
		FRONT_CENTER = 4u,
		[Token(Token = "0x40000EB")]
		LOW_FREQUENCY = 8u,
		[Token(Token = "0x40000EC")]
		SURROUND_LEFT = 0x10u,
		[Token(Token = "0x40000ED")]
		SURROUND_RIGHT = 0x20u,
		[Token(Token = "0x40000EE")]
		BACK_LEFT = 0x40u,
		[Token(Token = "0x40000EF")]
		BACK_RIGHT = 0x80u,
		[Token(Token = "0x40000F0")]
		BACK_CENTER = 0x100u,
		[Token(Token = "0x40000F1")]
		MONO = 1u,
		[Token(Token = "0x40000F2")]
		STEREO = 3u,
		[Token(Token = "0x40000F3")]
		LRC = 7u,
		[Token(Token = "0x40000F4")]
		QUAD = 0x33u,
		[Token(Token = "0x40000F5")]
		SURROUND = 0x37u,
		[Token(Token = "0x40000F6")]
		_5POINT1 = 0x3Fu,
		[Token(Token = "0x40000F7")]
		_5POINT1_REARS = 0xCFu,
		[Token(Token = "0x40000F8")]
		_7POINT0 = 0xF7u,
		[Token(Token = "0x40000F9")]
		_7POINT1 = 0xFFu
	}
	[Token(Token = "0x200001E")]
	public enum CHANNELORDER
	{
		[Token(Token = "0x40000FB")]
		DEFAULT,
		[Token(Token = "0x40000FC")]
		WAVEFORMAT,
		[Token(Token = "0x40000FD")]
		PROTOOLS,
		[Token(Token = "0x40000FE")]
		ALLMONO,
		[Token(Token = "0x40000FF")]
		ALLSTEREO,
		[Token(Token = "0x4000100")]
		ALSA,
		[Token(Token = "0x4000101")]
		MAX
	}
	[Token(Token = "0x200001F")]
	public enum PLUGINTYPE
	{
		[Token(Token = "0x4000103")]
		OUTPUT,
		[Token(Token = "0x4000104")]
		CODEC,
		[Token(Token = "0x4000105")]
		DSP,
		[Token(Token = "0x4000106")]
		MAX
	}
	[Token(Token = "0x2000020")]
	public struct PLUGINLIST
	{
		[Token(Token = "0x4000107")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private PLUGINTYPE type;

		[Token(Token = "0x4000108")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr description;
	}
	[Token(Token = "0x2000021")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x400010A")]
		NORMAL = 0u,
		[Token(Token = "0x400010B")]
		STREAM_FROM_UPDATE = 1u,
		[Token(Token = "0x400010C")]
		MIX_FROM_UPDATE = 2u,
		[Token(Token = "0x400010D")]
		_3D_RIGHTHANDED = 4u,
		[Token(Token = "0x400010E")]
		CHANNEL_LOWPASS = 0x100u,
		[Token(Token = "0x400010F")]
		CHANNEL_DISTANCEFILTER = 0x200u,
		[Token(Token = "0x4000110")]
		PROFILE_ENABLE = 0x10000u,
		[Token(Token = "0x4000111")]
		VOL0_BECOMES_VIRTUAL = 0x20000u,
		[Token(Token = "0x4000112")]
		GEOMETRY_USECLOSEST = 0x40000u,
		[Token(Token = "0x4000113")]
		PREFER_DOLBY_DOWNMIX = 0x80000u,
		[Token(Token = "0x4000114")]
		THREAD_UNSAFE = 0x100000u,
		[Token(Token = "0x4000115")]
		PROFILE_METER_ALL = 0x200000u
	}
	[Token(Token = "0x2000022")]
	public enum SOUND_TYPE
	{
		[Token(Token = "0x4000117")]
		UNKNOWN,
		[Token(Token = "0x4000118")]
		AIFF,
		[Token(Token = "0x4000119")]
		ASF,
		[Token(Token = "0x400011A")]
		DLS,
		[Token(Token = "0x400011B")]
		FLAC,
		[Token(Token = "0x400011C")]
		FSB,
		[Token(Token = "0x400011D")]
		IT,
		[Token(Token = "0x400011E")]
		MIDI,
		[Token(Token = "0x400011F")]
		MOD,
		[Token(Token = "0x4000120")]
		MPEG,
		[Token(Token = "0x4000121")]
		OGGVORBIS,
		[Token(Token = "0x4000122")]
		PLAYLIST,
		[Token(Token = "0x4000123")]
		RAW,
		[Token(Token = "0x4000124")]
		S3M,
		[Token(Token = "0x4000125")]
		USER,
		[Token(Token = "0x4000126")]
		WAV,
		[Token(Token = "0x4000127")]
		XM,
		[Token(Token = "0x4000128")]
		XMA,
		[Token(Token = "0x4000129")]
		AUDIOQUEUE,
		[Token(Token = "0x400012A")]
		AT9,
		[Token(Token = "0x400012B")]
		VORBIS,
		[Token(Token = "0x400012C")]
		MEDIA_FOUNDATION,
		[Token(Token = "0x400012D")]
		MEDIACODEC,
		[Token(Token = "0x400012E")]
		FADPCM,
		[Token(Token = "0x400012F")]
		MAX
	}
	[Token(Token = "0x2000023")]
	public enum SOUND_FORMAT
	{
		[Token(Token = "0x4000131")]
		NONE,
		[Token(Token = "0x4000132")]
		PCM8,
		[Token(Token = "0x4000133")]
		PCM16,
		[Token(Token = "0x4000134")]
		PCM24,
		[Token(Token = "0x4000135")]
		PCM32,
		[Token(Token = "0x4000136")]
		PCMFLOAT,
		[Token(Token = "0x4000137")]
		BITSTREAM,
		[Token(Token = "0x4000138")]
		MAX
	}
	[Token(Token = "0x2000024")]
	[Flags]
	public enum MODE : uint
	{
		[Token(Token = "0x400013A")]
		DEFAULT = 0u,
		[Token(Token = "0x400013B")]
		LOOP_OFF = 1u,
		[Token(Token = "0x400013C")]
		LOOP_NORMAL = 2u,
		[Token(Token = "0x400013D")]
		LOOP_BIDI = 4u,
		[Token(Token = "0x400013E")]
		_2D = 8u,
		[Token(Token = "0x400013F")]
		_3D = 0x10u,
		[Token(Token = "0x4000140")]
		CREATESTREAM = 0x80u,
		[Token(Token = "0x4000141")]
		CREATESAMPLE = 0x100u,
		[Token(Token = "0x4000142")]
		CREATECOMPRESSEDSAMPLE = 0x200u,
		[Token(Token = "0x4000143")]
		OPENUSER = 0x400u,
		[Token(Token = "0x4000144")]
		OPENMEMORY = 0x800u,
		[Token(Token = "0x4000145")]
		OPENMEMORY_POINT = 0x10000000u,
		[Token(Token = "0x4000146")]
		OPENRAW = 0x1000u,
		[Token(Token = "0x4000147")]
		OPENONLY = 0x2000u,
		[Token(Token = "0x4000148")]
		ACCURATETIME = 0x4000u,
		[Token(Token = "0x4000149")]
		MPEGSEARCH = 0x8000u,
		[Token(Token = "0x400014A")]
		NONBLOCKING = 0x10000u,
		[Token(Token = "0x400014B")]
		UNIQUE = 0x20000u,
		[Token(Token = "0x400014C")]
		_3D_HEADRELATIVE = 0x40000u,
		[Token(Token = "0x400014D")]
		_3D_WORLDRELATIVE = 0x80000u,
		[Token(Token = "0x400014E")]
		_3D_INVERSEROLLOFF = 0x100000u,
		[Token(Token = "0x400014F")]
		_3D_LINEARROLLOFF = 0x200000u,
		[Token(Token = "0x4000150")]
		_3D_LINEARSQUAREROLLOFF = 0x400000u,
		[Token(Token = "0x4000151")]
		_3D_INVERSETAPEREDROLLOFF = 0x800000u,
		[Token(Token = "0x4000152")]
		_3D_CUSTOMROLLOFF = 0x4000000u,
		[Token(Token = "0x4000153")]
		_3D_IGNOREGEOMETRY = 0x40000000u,
		[Token(Token = "0x4000154")]
		IGNORETAGS = 0x2000000u,
		[Token(Token = "0x4000155")]
		LOWMEM = 0x8000000u,
		[Token(Token = "0x4000156")]
		VIRTUAL_PLAYFROMSTART = 0x80000000u
	}
	[Token(Token = "0x2000025")]
	public enum OPENSTATE
	{
		[Token(Token = "0x4000158")]
		READY,
		[Token(Token = "0x4000159")]
		LOADING,
		[Token(Token = "0x400015A")]
		ERROR,
		[Token(Token = "0x400015B")]
		CONNECTING,
		[Token(Token = "0x400015C")]
		BUFFERING,
		[Token(Token = "0x400015D")]
		SEEKING,
		[Token(Token = "0x400015E")]
		PLAYING,
		[Token(Token = "0x400015F")]
		SETPOSITION,
		[Token(Token = "0x4000160")]
		MAX
	}
	[Token(Token = "0x2000026")]
	public enum SOUNDGROUP_BEHAVIOR
	{
		[Token(Token = "0x4000162")]
		BEHAVIOR_FAIL,
		[Token(Token = "0x4000163")]
		BEHAVIOR_MUTE,
		[Token(Token = "0x4000164")]
		BEHAVIOR_STEALLOWEST,
		[Token(Token = "0x4000165")]
		MAX
	}
	[Token(Token = "0x2000027")]
	public enum CHANNELCONTROL_CALLBACK_TYPE
	{
		[Token(Token = "0x4000167")]
		END,
		[Token(Token = "0x4000168")]
		VIRTUALVOICE,
		[Token(Token = "0x4000169")]
		SYNCPOINT,
		[Token(Token = "0x400016A")]
		OCCLUSION,
		[Token(Token = "0x400016B")]
		MAX
	}
	[Token(Token = "0x2000028")]
	public struct CHANNELCONTROL_DSP_INDEX
	{
		[Token(Token = "0x400016C")]
		public const int HEAD = -1;

		[Token(Token = "0x400016D")]
		public const int FADER = -2;

		[Token(Token = "0x400016E")]
		public const int TAIL = -3;
	}
	[Token(Token = "0x2000029")]
	public enum ERRORCALLBACK_INSTANCETYPE
	{
		[Token(Token = "0x4000170")]
		NONE,
		[Token(Token = "0x4000171")]
		SYSTEM,
		[Token(Token = "0x4000172")]
		CHANNEL,
		[Token(Token = "0x4000173")]
		CHANNELGROUP,
		[Token(Token = "0x4000174")]
		CHANNELCONTROL,
		[Token(Token = "0x4000175")]
		SOUND,
		[Token(Token = "0x4000176")]
		SOUNDGROUP,
		[Token(Token = "0x4000177")]
		DSP,
		[Token(Token = "0x4000178")]
		DSPCONNECTION,
		[Token(Token = "0x4000179")]
		GEOMETRY,
		[Token(Token = "0x400017A")]
		REVERB3D,
		[Token(Token = "0x400017B")]
		STUDIO_SYSTEM,
		[Token(Token = "0x400017C")]
		STUDIO_EVENTDESCRIPTION,
		[Token(Token = "0x400017D")]
		STUDIO_EVENTINSTANCE,
		[Token(Token = "0x400017E")]
		STUDIO_PARAMETERINSTANCE,
		[Token(Token = "0x400017F")]
		STUDIO_BUS,
		[Token(Token = "0x4000180")]
		STUDIO_VCA,
		[Token(Token = "0x4000181")]
		STUDIO_BANK,
		[Token(Token = "0x4000182")]
		STUDIO_COMMANDREPLAY
	}
	[Token(Token = "0x200002A")]
	public struct ERRORCALLBACK_INFO
	{
		[Token(Token = "0x4000183")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public RESULT result;

		[Token(Token = "0x4000184")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public ERRORCALLBACK_INSTANCETYPE instancetype;

		[Token(Token = "0x4000185")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr instance;

		[Token(Token = "0x4000186")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StringWrapper functionname;

		[Token(Token = "0x4000187")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public StringWrapper functionparams;
	}
	[Token(Token = "0x200002B")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000189")]
		DEVICELISTCHANGED = 1u,
		[Token(Token = "0x400018A")]
		DEVICELOST = 2u,
		[Token(Token = "0x400018B")]
		MEMORYALLOCATIONFAILED = 4u,
		[Token(Token = "0x400018C")]
		THREADCREATED = 8u,
		[Token(Token = "0x400018D")]
		BADDSPCONNECTION = 0x10u,
		[Token(Token = "0x400018E")]
		PREMIX = 0x20u,
		[Token(Token = "0x400018F")]
		POSTMIX = 0x40u,
		[Token(Token = "0x4000190")]
		ERROR = 0x80u,
		[Token(Token = "0x4000191")]
		MIDMIX = 0x100u,
		[Token(Token = "0x4000192")]
		THREADDESTROYED = 0x200u,
		[Token(Token = "0x4000193")]
		PREUPDATE = 0x400u,
		[Token(Token = "0x4000194")]
		POSTUPDATE = 0x800u,
		[Token(Token = "0x4000195")]
		RECORDLISTCHANGED = 0x1000u,
		[Token(Token = "0x4000196")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x200002C")]
	public delegate RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message);
	[Token(Token = "0x200002D")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata1, IntPtr commanddata2, IntPtr userdata);
	[Token(Token = "0x200002E")]
	public delegate RESULT CHANNELCONTROL_CALLBACK(IntPtr channelcontrol, CHANNELCONTROL_TYPE controltype, CHANNELCONTROL_CALLBACK_TYPE callbacktype, IntPtr commanddata1, IntPtr commanddata2);
	[Token(Token = "0x200002F")]
	public delegate RESULT SOUND_NONBLOCK_CALLBACK(IntPtr sound, RESULT result);
	[Token(Token = "0x2000030")]
	public delegate RESULT SOUND_PCMREAD_CALLBACK(IntPtr sound, IntPtr data, uint datalen);
	[Token(Token = "0x2000031")]
	public delegate RESULT SOUND_PCMSETPOS_CALLBACK(IntPtr sound, int subsound, uint position, TIMEUNIT postype);
	[Token(Token = "0x2000032")]
	public delegate RESULT FILE_OPEN_CALLBACK(StringWrapper name, ref uint filesize, ref IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000033")]
	public delegate RESULT FILE_CLOSE_CALLBACK(IntPtr handle, IntPtr userdata);
	[Token(Token = "0x2000034")]
	public delegate RESULT FILE_READ_CALLBACK(IntPtr handle, IntPtr buffer, uint sizebytes, ref uint bytesread, IntPtr userdata);
	[Token(Token = "0x2000035")]
	public delegate RESULT FILE_SEEK_CALLBACK(IntPtr handle, uint pos, IntPtr userdata);
	[Token(Token = "0x2000036")]
	public delegate RESULT FILE_ASYNCREAD_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000037")]
	public delegate RESULT FILE_ASYNCCANCEL_CALLBACK(IntPtr info, IntPtr userdata);
	[Token(Token = "0x2000038")]
	public delegate RESULT FILE_ASYNCDONE_FUNC(IntPtr info, RESULT result);
	[Token(Token = "0x2000039")]
	public delegate IntPtr MEMORY_ALLOC_CALLBACK(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200003A")]
	public delegate IntPtr MEMORY_REALLOC_CALLBACK(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200003B")]
	public delegate void MEMORY_FREE_CALLBACK(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x200003C")]
	public delegate float CB_3D_ROLLOFF_CALLBACK(IntPtr channelcontrol, float distance);
	[Token(Token = "0x200003D")]
	public enum DSP_RESAMPLER
	{
		[Token(Token = "0x4000198")]
		DEFAULT,
		[Token(Token = "0x4000199")]
		NOINTERP,
		[Token(Token = "0x400019A")]
		LINEAR,
		[Token(Token = "0x400019B")]
		CUBIC,
		[Token(Token = "0x400019C")]
		SPLINE,
		[Token(Token = "0x400019D")]
		MAX
	}
	[Token(Token = "0x200003E")]
	public enum DSPCONNECTION_TYPE
	{
		[Token(Token = "0x400019F")]
		STANDARD,
		[Token(Token = "0x40001A0")]
		SIDECHAIN,
		[Token(Token = "0x40001A1")]
		SEND,
		[Token(Token = "0x40001A2")]
		SEND_SIDECHAIN,
		[Token(Token = "0x40001A3")]
		MAX
	}
	[Token(Token = "0x200003F")]
	public enum TAGTYPE
	{
		[Token(Token = "0x40001A5")]
		UNKNOWN,
		[Token(Token = "0x40001A6")]
		ID3V1,
		[Token(Token = "0x40001A7")]
		ID3V2,
		[Token(Token = "0x40001A8")]
		VORBISCOMMENT,
		[Token(Token = "0x40001A9")]
		SHOUTCAST,
		[Token(Token = "0x40001AA")]
		ICECAST,
		[Token(Token = "0x40001AB")]
		ASF,
		[Token(Token = "0x40001AC")]
		MIDI,
		[Token(Token = "0x40001AD")]
		PLAYLIST,
		[Token(Token = "0x40001AE")]
		FMOD,
		[Token(Token = "0x40001AF")]
		USER,
		[Token(Token = "0x40001B0")]
		MAX
	}
	[Token(Token = "0x2000040")]
	public enum TAGDATATYPE
	{
		[Token(Token = "0x40001B2")]
		BINARY,
		[Token(Token = "0x40001B3")]
		INT,
		[Token(Token = "0x40001B4")]
		FLOAT,
		[Token(Token = "0x40001B5")]
		STRING,
		[Token(Token = "0x40001B6")]
		STRING_UTF16,
		[Token(Token = "0x40001B7")]
		STRING_UTF16BE,
		[Token(Token = "0x40001B8")]
		STRING_UTF8,
		[Token(Token = "0x40001B9")]
		MAX
	}
	[Token(Token = "0x2000041")]
	public struct TAG
	{
		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public TAGTYPE type;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public TAGDATATYPE datatype;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public StringWrapper name;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr data;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint datalen;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool updated;
	}
	[Token(Token = "0x2000042")]
	[Flags]
	public enum TIMEUNIT : uint
	{
		[Token(Token = "0x40001C1")]
		MS = 1u,
		[Token(Token = "0x40001C2")]
		PCM = 2u,
		[Token(Token = "0x40001C3")]
		PCMBYTES = 4u,
		[Token(Token = "0x40001C4")]
		RAWBYTES = 8u,
		[Token(Token = "0x40001C5")]
		PCMFRACTION = 0x10u,
		[Token(Token = "0x40001C6")]
		MODORDER = 0x100u,
		[Token(Token = "0x40001C7")]
		MODROW = 0x200u,
		[Token(Token = "0x40001C8")]
		MODPATTERN = 0x400u
	}
	[Token(Token = "0x2000043")]
	public struct PORT_INDEX
	{
		[Token(Token = "0x40001C9")]
		public const ulong NONE = ulong.MaxValue;
	}
	[Token(Token = "0x2000044")]
	public struct CREATESOUNDEXINFO
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint length;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public uint fileoffset;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int numchannels;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int defaultfrequency;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public SOUND_FORMAT format;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public uint decodebuffersize;

		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int initialsubsound;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int numsubsounds;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr inclusionlist;

		[Token(Token = "0x40001D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int inclusionlistnum;

		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public SOUND_PCMREAD_CALLBACK pcmreadcallback;

		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public SOUND_PCMSETPOS_CALLBACK pcmsetposcallback;

		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public SOUND_NONBLOCK_CALLBACK nonblockcallback;

		[Token(Token = "0x40001D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public IntPtr dlsname;

		[Token(Token = "0x40001D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr encryptionkey;

		[Token(Token = "0x40001DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public int maxpolyphony;

		[Token(Token = "0x40001DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public IntPtr userdata;

		[Token(Token = "0x40001DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public SOUND_TYPE suggestedsoundtype;

		[Token(Token = "0x40001DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public FILE_OPEN_CALLBACK fileuseropen;

		[Token(Token = "0x40001DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public FILE_CLOSE_CALLBACK fileuserclose;

		[Token(Token = "0x40001DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public FILE_READ_CALLBACK fileuserread;

		[Token(Token = "0x40001E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public FILE_SEEK_CALLBACK fileuserseek;

		[Token(Token = "0x40001E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public FILE_ASYNCREAD_CALLBACK fileuserasyncread;

		[Token(Token = "0x40001E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public FILE_ASYNCCANCEL_CALLBACK fileuserasynccancel;

		[Token(Token = "0x40001E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr fileuserdata;

		[Token(Token = "0x40001E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public int filebuffersize;

		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
		public CHANNELORDER channelorder;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public IntPtr initialsoundgroup;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public uint initialseekposition;

		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
		public TIMEUNIT initialseekpostype;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public int ignoresetfilesystem;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		public uint audioqueuepolicy;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		public uint minmidigranularity;

		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		public int nonblockthreadid;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		public IntPtr fsbguid;
	}
	[Token(Token = "0x2000045")]
	public struct REVERB_PROPERTIES
	{
		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float DecayTime;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float EarlyDelay;

		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float LateDelay;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float HFReference;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float HFDecayRatio;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float Diffusion;

		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Density;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float LowShelfFrequency;

		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float LowShelfGain;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float HighCut;

		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public float EarlyLateMix;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float WetLevel;

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x9ADB40", Offset = "0x9ADB40", VA = "0x9ADB40")]
		public REVERB_PROPERTIES(float decayTime, float earlyDelay, float lateDelay, float hfReference, float hfDecayRatio, float diffusion, float density, float lowShelfFrequency, float lowShelfGain, float highCut, float earlyLateMix, float wetLevel)
		{
		}
	}
	[Token(Token = "0x2000046")]
	public class PRESET
	{
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x11EF978", Offset = "0x11EF978", VA = "0x11EF978")]
		public static REVERB_PROPERTIES OFF()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x11EF9C8", Offset = "0x11EF9C8", VA = "0x11EF9C8")]
		public static REVERB_PROPERTIES GENERIC()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x11EF9EC", Offset = "0x11EF9EC", VA = "0x11EF9EC")]
		public static REVERB_PROPERTIES PADDEDCELL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x11EFA10", Offset = "0x11EFA10", VA = "0x11EFA10")]
		public static REVERB_PROPERTIES ROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x11EFA34", Offset = "0x11EFA34", VA = "0x11EFA34")]
		public static REVERB_PROPERTIES BATHROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x11EFA58", Offset = "0x11EFA58", VA = "0x11EFA58")]
		public static REVERB_PROPERTIES LIVINGROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x11EFA7C", Offset = "0x11EFA7C", VA = "0x11EFA7C")]
		public static REVERB_PROPERTIES STONEROOM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x11EFAA0", Offset = "0x11EFAA0", VA = "0x11EFAA0")]
		public static REVERB_PROPERTIES AUDITORIUM()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x11EFAC4", Offset = "0x11EFAC4", VA = "0x11EFAC4")]
		public static REVERB_PROPERTIES CONCERTHALL()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x11EFAE8", Offset = "0x11EFAE8", VA = "0x11EFAE8")]
		public static REVERB_PROPERTIES CAVE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x11EFB0C", Offset = "0x11EFB0C", VA = "0x11EFB0C")]
		public static REVERB_PROPERTIES ARENA()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x11EFB30", Offset = "0x11EFB30", VA = "0x11EFB30")]
		public static REVERB_PROPERTIES HANGAR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x11EFB54", Offset = "0x11EFB54", VA = "0x11EFB54")]
		public static REVERB_PROPERTIES CARPETTEDHALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x11EFB78", Offset = "0x11EFB78", VA = "0x11EFB78")]
		public static REVERB_PROPERTIES HALLWAY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x11EFB9C", Offset = "0x11EFB9C", VA = "0x11EFB9C")]
		public static REVERB_PROPERTIES STONECORRIDOR()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x11EFBC0", Offset = "0x11EFBC0", VA = "0x11EFBC0")]
		public static REVERB_PROPERTIES ALLEY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x11EFBE4", Offset = "0x11EFBE4", VA = "0x11EFBE4")]
		public static REVERB_PROPERTIES FOREST()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x11EFC08", Offset = "0x11EFC08", VA = "0x11EFC08")]
		public static REVERB_PROPERTIES CITY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x11EFC2C", Offset = "0x11EFC2C", VA = "0x11EFC2C")]
		public static REVERB_PROPERTIES MOUNTAINS()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x11EFC50", Offset = "0x11EFC50", VA = "0x11EFC50")]
		public static REVERB_PROPERTIES QUARRY()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x11EFC74", Offset = "0x11EFC74", VA = "0x11EFC74")]
		public static REVERB_PROPERTIES PLAIN()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x11EFC98", Offset = "0x11EFC98", VA = "0x11EFC98")]
		public static REVERB_PROPERTIES PARKINGLOT()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x11EFCBC", Offset = "0x11EFCBC", VA = "0x11EFCBC")]
		public static REVERB_PROPERTIES SEWERPIPE()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x11EFCE0", Offset = "0x11EFCE0", VA = "0x11EFCE0")]
		public static REVERB_PROPERTIES UNDERWATER()
		{
			return default(REVERB_PROPERTIES);
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x11EFD04", Offset = "0x11EFD04", VA = "0x11EFD04")]
		public PRESET()
		{
		}
	}
	[Token(Token = "0x2000047")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbSize;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int maxMPEGCodecs;

		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int maxADPCMCodecs;

		[Token(Token = "0x40001FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int maxXMACodecs;

		[Token(Token = "0x40001FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int maxVorbisCodecs;

		[Token(Token = "0x40001FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int maxAT9Codecs;

		[Token(Token = "0x4000200")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int maxFADPCMCodecs;

		[Token(Token = "0x4000201")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public int maxPCMCodecs;

		[Token(Token = "0x4000202")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int ASIONumChannels;

		[Token(Token = "0x4000203")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr ASIOChannelList;

		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IntPtr ASIOSpeakerList;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public float vol0virtualvol;

		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public uint defaultDecodeBufferSize;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public ushort profilePort;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public uint geometryMaxFadeTime;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float distanceFilterCenterFreq;

		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int reverb3Dinstance;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int DSPBufferPoolSize;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		public uint stackSizeStream;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public uint stackSizeNonBlocking;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		public uint stackSizeMixer;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_RESAMPLER resamplerMethod;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public uint commandQueueSize;

		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public uint randomSeed;
	}
	[Token(Token = "0x2000048")]
	[Flags]
	public enum DRIVER_STATE : uint
	{
		[Token(Token = "0x4000213")]
		CONNECTED = 1u,
		[Token(Token = "0x4000214")]
		DEFAULT = 2u
	}
	[Token(Token = "0x2000049")]
	public struct Factory
	{
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x11EDD30", Offset = "0x11EDD30", VA = "0x11EDD30")]
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x11EDD34", Offset = "0x11EDD34", VA = "0x11EDD34")]
		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
	[Token(Token = "0x200004A")]
	public struct Memory
	{
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x11EF7C4", Offset = "0x11EF7C4", VA = "0x11EF7C4")]
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x11EF8C0", Offset = "0x11EF8C0", VA = "0x11EF8C0")]
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x11EF7C8", Offset = "0x11EF7C8", VA = "0x11EF7C8")]
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags);

		[PreserveSig]
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x11EF8C8", Offset = "0x11EF8C8", VA = "0x11EF8C8")]
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking);
	}
	[Token(Token = "0x200004B")]
	public struct Debug
	{
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x1772438", Offset = "0x1772438", VA = "0x1772438")]
		public static RESULT Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode = DEBUG_MODE.TTY, [Optional] DEBUG_CALLBACK callback, [Optional] string filename)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x17725AC", Offset = "0x17725AC", VA = "0x17725AC")]
		private static extern RESULT FMOD5_Debug_Initialize(DEBUG_FLAGS flags, DEBUG_MODE mode, DEBUG_CALLBACK callback, byte[] filename);
	}
	[Token(Token = "0x200004C")]
	public struct System
	{
		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000095")]
		[Address(RVA = "0x9AECF0", Offset = "0x9AECF0", VA = "0x9AECF0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000096")]
		[Address(RVA = "0x9AECF8", Offset = "0x9AECF8", VA = "0x9AECF8")]
		public RESULT setOutput(OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x9AED00", Offset = "0x9AED00", VA = "0x9AED00")]
		public RESULT getOutput(out OUTPUTTYPE output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x9AED08", Offset = "0x9AED08", VA = "0x9AED08")]
		public RESULT getNumDrivers(out int numdrivers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000099")]
		[Address(RVA = "0x9AED10", Offset = "0x9AED10", VA = "0x9AED10")]
		public RESULT getDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009A")]
		[Address(RVA = "0x9AED18", Offset = "0x9AED18", VA = "0x9AED18")]
		public RESULT getDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x9AED20", Offset = "0x9AED20", VA = "0x9AED20")]
		public RESULT setDriver(int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009C")]
		[Address(RVA = "0x9AED28", Offset = "0x9AED28", VA = "0x9AED28")]
		public RESULT getDriver(out int driver)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009D")]
		[Address(RVA = "0x9AED30", Offset = "0x9AED30", VA = "0x9AED30")]
		public RESULT setSoftwareChannels(int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x9AED38", Offset = "0x9AED38", VA = "0x9AED38")]
		public RESULT getSoftwareChannels(out int numsoftwarechannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x9AED40", Offset = "0x9AED40", VA = "0x9AED40")]
		public RESULT setSoftwareFormat(int samplerate, SPEAKERMODE speakermode, int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x9AED48", Offset = "0x9AED48", VA = "0x9AED48")]
		public RESULT getSoftwareFormat(out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x9AED50", Offset = "0x9AED50", VA = "0x9AED50")]
		public RESULT setDSPBufferSize(uint bufferlength, int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x9AED58", Offset = "0x9AED58", VA = "0x9AED58")]
		public RESULT getDSPBufferSize(out uint bufferlength, out int numbuffers)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x9AED60", Offset = "0x9AED60", VA = "0x9AED60")]
		public RESULT setFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x9AED68", Offset = "0x9AED68", VA = "0x9AED68")]
		public RESULT attachFileSystem(FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A5")]
		[Address(RVA = "0x9AED70", Offset = "0x9AED70", VA = "0x9AED70")]
		public RESULT setAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x9AED78", Offset = "0x9AED78", VA = "0x9AED78")]
		public RESULT getAdvancedSettings(ref ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x9AED80", Offset = "0x9AED80", VA = "0x9AED80")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x9AED88", Offset = "0x9AED88", VA = "0x9AED88")]
		public RESULT setPluginPath(string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x9AED90", Offset = "0x9AED90", VA = "0x9AED90")]
		public RESULT loadPlugin(string filename, out uint handle, uint priority = 0u)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x9AED98", Offset = "0x9AED98", VA = "0x9AED98")]
		public RESULT unloadPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x9AEDA0", Offset = "0x9AEDA0", VA = "0x9AEDA0")]
		public RESULT getNumNestedPlugins(uint handle, out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x9AEDA8", Offset = "0x9AEDA8", VA = "0x9AEDA8")]
		public RESULT getNestedPlugin(uint handle, int index, out uint nestedhandle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x9AEDB0", Offset = "0x9AEDB0", VA = "0x9AEDB0")]
		public RESULT getNumPlugins(PLUGINTYPE plugintype, out int numplugins)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x9AEDB8", Offset = "0x9AEDB8", VA = "0x9AEDB8")]
		public RESULT getPluginHandle(PLUGINTYPE plugintype, int index, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x9AEDC0", Offset = "0x9AEDC0", VA = "0x9AEDC0")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out string name, int namelen, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x9AEDC8", Offset = "0x9AEDC8", VA = "0x9AEDC8")]
		public RESULT getPluginInfo(uint handle, out PLUGINTYPE plugintype, out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x9AEDD0", Offset = "0x9AEDD0", VA = "0x9AEDD0")]
		public RESULT setOutputByPlugin(uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x9AEDD8", Offset = "0x9AEDD8", VA = "0x9AEDD8")]
		public RESULT getOutputByPlugin(out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x9AEDE0", Offset = "0x9AEDE0", VA = "0x9AEDE0")]
		public RESULT createDSPByPlugin(uint handle, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x9AEDE8", Offset = "0x9AEDE8", VA = "0x9AEDE8")]
		public RESULT getDSPInfoByPlugin(uint handle, out IntPtr description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x9AEDF0", Offset = "0x9AEDF0", VA = "0x9AEDF0")]
		public RESULT registerDSP(ref DSP_DESCRIPTION description, out uint handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x9AEDF8", Offset = "0x9AEDF8", VA = "0x9AEDF8")]
		public RESULT init(int maxchannels, INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x9AEE00", Offset = "0x9AEE00", VA = "0x9AEE00")]
		public RESULT close()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x9AEE08", Offset = "0x9AEE08", VA = "0x9AEE08")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x9AEE10", Offset = "0x9AEE10", VA = "0x9AEE10")]
		public RESULT setSpeakerPosition(SPEAKER speaker, float x, float y, bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x9AEE1C", Offset = "0x9AEE1C", VA = "0x9AEE1C")]
		public RESULT getSpeakerPosition(SPEAKER speaker, out float x, out float y, out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x9AEE24", Offset = "0x9AEE24", VA = "0x9AEE24")]
		public RESULT setStreamBufferSize(uint filebuffersize, TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x9AEE2C", Offset = "0x9AEE2C", VA = "0x9AEE2C")]
		public RESULT getStreamBufferSize(out uint filebuffersize, out TIMEUNIT filebuffersizetype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x9AEE34", Offset = "0x9AEE34", VA = "0x9AEE34")]
		public RESULT set3DSettings(float dopplerscale, float distancefactor, float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9AEE3C", Offset = "0x9AEE3C", VA = "0x9AEE3C")]
		public RESULT get3DSettings(out float dopplerscale, out float distancefactor, out float rolloffscale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x9AEE44", Offset = "0x9AEE44", VA = "0x9AEE44")]
		public RESULT set3DNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x9AEE4C", Offset = "0x9AEE4C", VA = "0x9AEE4C")]
		public RESULT get3DNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x9AEE54", Offset = "0x9AEE54", VA = "0x9AEE54")]
		public RESULT set3DListenerAttributes(int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x9AEE5C", Offset = "0x9AEE5C", VA = "0x9AEE5C")]
		public RESULT get3DListenerAttributes(int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x9AEE64", Offset = "0x9AEE64", VA = "0x9AEE64")]
		public RESULT set3DRolloffCallback(CB_3D_ROLLOFF_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x9AEE6C", Offset = "0x9AEE6C", VA = "0x9AEE6C")]
		public RESULT mixerSuspend()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x9AEE74", Offset = "0x9AEE74", VA = "0x9AEE74")]
		public RESULT mixerResume()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x9AEE7C", Offset = "0x9AEE7C", VA = "0x9AEE7C")]
		public RESULT getDefaultMixMatrix(SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x9AEE84", Offset = "0x9AEE84", VA = "0x9AEE84")]
		public RESULT getSpeakerModeChannels(SPEAKERMODE mode, out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x9AEE8C", Offset = "0x9AEE8C", VA = "0x9AEE8C")]
		public RESULT getVersion(out uint version)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000C9")]
		[Address(RVA = "0x9AEE94", Offset = "0x9AEE94", VA = "0x9AEE94")]
		public RESULT getOutputHandle(out IntPtr handle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0x9AEE9C", Offset = "0x9AEE9C", VA = "0x9AEE9C")]
		public RESULT getChannelsPlaying(out int channels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0x9AEEA4", Offset = "0x9AEEA4", VA = "0x9AEEA4")]
		public RESULT getChannelsPlaying(out int channels, out int realchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x9AEEAC", Offset = "0x9AEEAC", VA = "0x9AEEAC")]
		public RESULT getCPUUsage(out float dsp, out float stream, out float geometry, out float update, out float total)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x9AEEB4", Offset = "0x9AEEB4", VA = "0x9AEEB4")]
		public RESULT getFileUsage(out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x9AEEBC", Offset = "0x9AEEBC", VA = "0x9AEEBC")]
		public RESULT createSound(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x9AEEC4", Offset = "0x9AEEC4", VA = "0x9AEEC4")]
		public RESULT createSound(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D0")]
		[Address(RVA = "0x9AEECC", Offset = "0x9AEECC", VA = "0x9AEECC")]
		public RESULT createSound(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D1")]
		[Address(RVA = "0x9AEED4", Offset = "0x9AEED4", VA = "0x9AEED4")]
		public RESULT createSound(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x9AEEDC", Offset = "0x9AEEDC", VA = "0x9AEEDC")]
		public RESULT createStream(string name, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x9AEEE4", Offset = "0x9AEEE4", VA = "0x9AEEE4")]
		public RESULT createStream(byte[] data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x9AEEEC", Offset = "0x9AEEEC", VA = "0x9AEEEC")]
		public RESULT createStream(IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x9AEEF4", Offset = "0x9AEEF4", VA = "0x9AEEF4")]
		public RESULT createStream(string name, MODE mode, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x9AEEFC", Offset = "0x9AEEFC", VA = "0x9AEEFC")]
		public RESULT createDSP(ref DSP_DESCRIPTION description, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x9AEF04", Offset = "0x9AEF04", VA = "0x9AEF04")]
		public RESULT createDSPByType(DSP_TYPE type, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x9AEF0C", Offset = "0x9AEF0C", VA = "0x9AEF0C")]
		public RESULT createChannelGroup(string name, out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x9AEF14", Offset = "0x9AEF14", VA = "0x9AEF14")]
		public RESULT createSoundGroup(string name, out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x9AEF1C", Offset = "0x9AEF1C", VA = "0x9AEF1C")]
		public RESULT createReverb3D(out Reverb3D reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x9AEF24", Offset = "0x9AEF24", VA = "0x9AEF24")]
		public RESULT playSound(Sound sound, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x9AEF30", Offset = "0x9AEF30", VA = "0x9AEF30")]
		public RESULT playDSP(DSP dsp, ChannelGroup channelgroup, bool paused, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x9AEF3C", Offset = "0x9AEF3C", VA = "0x9AEF3C")]
		public RESULT getChannel(int channelid, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x9AEF44", Offset = "0x9AEF44", VA = "0x9AEF44")]
		public RESULT getMasterChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x9AEF4C", Offset = "0x9AEF4C", VA = "0x9AEF4C")]
		public RESULT getMasterSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x9AEF54", Offset = "0x9AEF54", VA = "0x9AEF54")]
		public RESULT attachChannelGroupToPort(uint portType, ulong portIndex, ChannelGroup channelgroup, bool passThru = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x9AEF60", Offset = "0x9AEF60", VA = "0x9AEF60")]
		public RESULT detachChannelGroupFromPort(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x9AEF68", Offset = "0x9AEF68", VA = "0x9AEF68")]
		public RESULT setReverbProperties(int instance, ref REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x9AEF70", Offset = "0x9AEF70", VA = "0x9AEF70")]
		public RESULT getReverbProperties(int instance, out REVERB_PROPERTIES prop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x9AEF78", Offset = "0x9AEF78", VA = "0x9AEF78")]
		public RESULT lockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x9AEF80", Offset = "0x9AEF80", VA = "0x9AEF80")]
		public RESULT unlockDSP()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x9AEF88", Offset = "0x9AEF88", VA = "0x9AEF88")]
		public RESULT getRecordNumDrivers(out int numdrivers, out int numconnected)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x9AEF90", Offset = "0x9AEF90", VA = "0x9AEF90")]
		public RESULT getRecordDriverInfo(int id, out string name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x9AEFA0", Offset = "0x9AEFA0", VA = "0x9AEFA0")]
		public RESULT getRecordDriverInfo(int id, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x9AEFA8", Offset = "0x9AEFA8", VA = "0x9AEFA8")]
		public RESULT getRecordPosition(int id, out uint position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x9AEFB0", Offset = "0x9AEFB0", VA = "0x9AEFB0")]
		public RESULT recordStart(int id, Sound sound, bool loop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x9AEFBC", Offset = "0x9AEFBC", VA = "0x9AEFBC")]
		public RESULT recordStop(int id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x9AEFC4", Offset = "0x9AEFC4", VA = "0x9AEFC4")]
		public RESULT isRecording(int id, out bool recording)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x9AEFCC", Offset = "0x9AEFCC", VA = "0x9AEFCC")]
		public RESULT createGeometry(int maxpolygons, int maxvertices, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x9AEFD4", Offset = "0x9AEFD4", VA = "0x9AEFD4")]
		public RESULT setGeometrySettings(float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x9AEFDC", Offset = "0x9AEFDC", VA = "0x9AEFDC")]
		public RESULT getGeometrySettings(out float maxworldsize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x9AEFE4", Offset = "0x9AEFE4", VA = "0x9AEFE4")]
		public RESULT loadGeometry(IntPtr data, int datasize, out Geometry geometry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x9AEFEC", Offset = "0x9AEFEC", VA = "0x9AEFEC")]
		public RESULT getGeometryOcclusion(ref VECTOR listener, ref VECTOR source, out float direct, out float reverb)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x9AEFF4", Offset = "0x9AEFF4", VA = "0x9AEFF4")]
		public RESULT setNetworkProxy(string proxy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x9AEFFC", Offset = "0x9AEFFC", VA = "0x9AEFFC")]
		public RESULT getNetworkProxy(out string proxy, int proxylen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x9AF004", Offset = "0x9AF004", VA = "0x9AF004")]
		public RESULT setNetworkTimeout(int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x9AF00C", Offset = "0x9AF00C", VA = "0x9AF00C")]
		public RESULT getNetworkTimeout(out int timeout)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x9AF014", Offset = "0x9AF014", VA = "0x9AF014")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x9AF01C", Offset = "0x9AF01C", VA = "0x9AF01C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x1201FDC", Offset = "0x1201FDC", VA = "0x1201FDC")]
		private static extern RESULT FMOD5_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x120207C", Offset = "0x120207C", VA = "0x120207C")]
		private static extern RESULT FMOD5_System_SetOutput(IntPtr system, OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x120212C", Offset = "0x120212C", VA = "0x120212C")]
		private static extern RESULT FMOD5_System_GetOutput(IntPtr system, out OUTPUTTYPE output);

		[PreserveSig]
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x12021DC", Offset = "0x12021DC", VA = "0x12021DC")]
		private static extern RESULT FMOD5_System_GetNumDrivers(IntPtr system, out int numdrivers);

		[PreserveSig]
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x1202480", Offset = "0x1202480", VA = "0x1202480")]
		private static extern RESULT FMOD5_System_GetDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels);

		[PreserveSig]
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x1202610", Offset = "0x1202610", VA = "0x1202610")]
		private static extern RESULT FMOD5_System_SetDriver(IntPtr system, int driver);

		[PreserveSig]
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x12026C0", Offset = "0x12026C0", VA = "0x12026C0")]
		private static extern RESULT FMOD5_System_GetDriver(IntPtr system, out int driver);

		[PreserveSig]
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x1202770", Offset = "0x1202770", VA = "0x1202770")]
		private static extern RESULT FMOD5_System_SetSoftwareChannels(IntPtr system, int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x1202820", Offset = "0x1202820", VA = "0x1202820")]
		private static extern RESULT FMOD5_System_GetSoftwareChannels(IntPtr system, out int numsoftwarechannels);

		[PreserveSig]
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x12028D0", Offset = "0x12028D0", VA = "0x12028D0")]
		private static extern RESULT FMOD5_System_SetSoftwareFormat(IntPtr system, int samplerate, SPEAKERMODE speakermode, int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x1202998", Offset = "0x1202998", VA = "0x1202998")]
		private static extern RESULT FMOD5_System_GetSoftwareFormat(IntPtr system, out int samplerate, out SPEAKERMODE speakermode, out int numrawspeakers);

		[PreserveSig]
		[Token(Token = "0x6000103")]
		[Address(RVA = "0x1202A60", Offset = "0x1202A60", VA = "0x1202A60")]
		private static extern RESULT FMOD5_System_SetDSPBufferSize(IntPtr system, uint bufferlength, int numbuffers);

		[PreserveSig]
		[Token(Token = "0x6000104")]
		[Address(RVA = "0x1202B18", Offset = "0x1202B18", VA = "0x1202B18")]
		private static extern RESULT FMOD5_System_GetDSPBufferSize(IntPtr system, out uint bufferlength, out int numbuffers);

		[PreserveSig]
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x1202BD0", Offset = "0x1202BD0", VA = "0x1202BD0")]
		private static extern RESULT FMOD5_System_SetFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek, FILE_ASYNCREAD_CALLBACK userasyncread, FILE_ASYNCCANCEL_CALLBACK userasynccancel, int blockalign);

		[PreserveSig]
		[Token(Token = "0x6000106")]
		[Address(RVA = "0x1202D0C", Offset = "0x1202D0C", VA = "0x1202D0C")]
		private static extern RESULT FMOD5_System_AttachFileSystem(IntPtr system, FILE_OPEN_CALLBACK useropen, FILE_CLOSE_CALLBACK userclose, FILE_READ_CALLBACK userread, FILE_SEEK_CALLBACK userseek);

		[PreserveSig]
		[Token(Token = "0x6000107")]
		[Address(RVA = "0x1202EBC", Offset = "0x1202EBC", VA = "0x1202EBC")]
		private static extern RESULT FMOD5_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x1203020", Offset = "0x1203020", VA = "0x1203020")]
		private static extern RESULT FMOD5_System_GetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x12030D0", Offset = "0x12030D0", VA = "0x12030D0")]
		private static extern RESULT FMOD5_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x12032E0", Offset = "0x12032E0", VA = "0x12032E0")]
		private static extern RESULT FMOD5_System_SetPluginPath(IntPtr system, byte[] path);

		[PreserveSig]
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x1203500", Offset = "0x1203500", VA = "0x1203500")]
		private static extern RESULT FMOD5_System_LoadPlugin(IntPtr system, byte[] filename, out uint handle, uint priority);

		[PreserveSig]
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x12035D0", Offset = "0x12035D0", VA = "0x12035D0")]
		private static extern RESULT FMOD5_System_UnloadPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x1203680", Offset = "0x1203680", VA = "0x1203680")]
		private static extern RESULT FMOD5_System_GetNumNestedPlugins(IntPtr system, uint handle, out int count);

		[PreserveSig]
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x1203738", Offset = "0x1203738", VA = "0x1203738")]
		private static extern RESULT FMOD5_System_GetNestedPlugin(IntPtr system, uint handle, int index, out uint nestedhandle);

		[PreserveSig]
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x1203800", Offset = "0x1203800", VA = "0x1203800")]
		private static extern RESULT FMOD5_System_GetNumPlugins(IntPtr system, PLUGINTYPE plugintype, out int numplugins);

		[PreserveSig]
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x12038B8", Offset = "0x12038B8", VA = "0x12038B8")]
		private static extern RESULT FMOD5_System_GetPluginHandle(IntPtr system, PLUGINTYPE plugintype, int index, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x1203B54", Offset = "0x1203B54", VA = "0x1203B54")]
		private static extern RESULT FMOD5_System_GetPluginInfo(IntPtr system, uint handle, out PLUGINTYPE plugintype, IntPtr name, int namelen, out uint version);

		[PreserveSig]
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x1203CA8", Offset = "0x1203CA8", VA = "0x1203CA8")]
		private static extern RESULT FMOD5_System_SetOutputByPlugin(IntPtr system, uint handle);

		[PreserveSig]
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x1203D58", Offset = "0x1203D58", VA = "0x1203D58")]
		private static extern RESULT FMOD5_System_GetOutputByPlugin(IntPtr system, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000114")]
		[Address(RVA = "0x1203E08", Offset = "0x1203E08", VA = "0x1203E08")]
		private static extern RESULT FMOD5_System_CreateDSPByPlugin(IntPtr system, uint handle, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000115")]
		[Address(RVA = "0x1203EC0", Offset = "0x1203EC0", VA = "0x1203EC0")]
		private static extern RESULT FMOD5_System_GetDSPInfoByPlugin(IntPtr system, uint handle, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x6000116")]
		[Address(RVA = "0x1203F78", Offset = "0x1203F78", VA = "0x1203F78")]
		private static extern RESULT FMOD5_System_RegisterDSP(IntPtr system, ref DSP_DESCRIPTION description, out uint handle);

		[PreserveSig]
		[Token(Token = "0x6000117")]
		[Address(RVA = "0x120408C", Offset = "0x120408C", VA = "0x120408C")]
		private static extern RESULT FMOD5_System_Init(IntPtr system, int maxchannels, INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x6000118")]
		[Address(RVA = "0x1204154", Offset = "0x1204154", VA = "0x1204154")]
		private static extern RESULT FMOD5_System_Close(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x12041F4", Offset = "0x12041F4", VA = "0x12041F4")]
		private static extern RESULT FMOD5_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600011A")]
		[Address(RVA = "0x1204298", Offset = "0x1204298", VA = "0x1204298")]
		private static extern RESULT FMOD5_System_SetSpeakerPosition(IntPtr system, SPEAKER speaker, float x, float y, bool active);

		[PreserveSig]
		[Token(Token = "0x600011B")]
		[Address(RVA = "0x1204368", Offset = "0x1204368", VA = "0x1204368")]
		private static extern RESULT FMOD5_System_GetSpeakerPosition(IntPtr system, SPEAKER speaker, out float x, out float y, out bool active);

		[PreserveSig]
		[Token(Token = "0x600011C")]
		[Address(RVA = "0x120444C", Offset = "0x120444C", VA = "0x120444C")]
		private static extern RESULT FMOD5_System_SetStreamBufferSize(IntPtr system, uint filebuffersize, TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x1204504", Offset = "0x1204504", VA = "0x1204504")]
		private static extern RESULT FMOD5_System_GetStreamBufferSize(IntPtr system, out uint filebuffersize, out TIMEUNIT filebuffersizetype);

		[PreserveSig]
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x12045BC", Offset = "0x12045BC", VA = "0x12045BC")]
		private static extern RESULT FMOD5_System_Set3DSettings(IntPtr system, float dopplerscale, float distancefactor, float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x1204684", Offset = "0x1204684", VA = "0x1204684")]
		private static extern RESULT FMOD5_System_Get3DSettings(IntPtr system, out float dopplerscale, out float distancefactor, out float rolloffscale);

		[PreserveSig]
		[Token(Token = "0x6000120")]
		[Address(RVA = "0x120474C", Offset = "0x120474C", VA = "0x120474C")]
		private static extern RESULT FMOD5_System_Set3DNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000121")]
		[Address(RVA = "0x12047FC", Offset = "0x12047FC", VA = "0x12047FC")]
		private static extern RESULT FMOD5_System_Get3DNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x6000122")]
		[Address(RVA = "0x12048AC", Offset = "0x12048AC", VA = "0x12048AC")]
		private static extern RESULT FMOD5_System_Set3DListenerAttributes(IntPtr system, int listener, ref VECTOR pos, ref VECTOR vel, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000123")]
		[Address(RVA = "0x120498C", Offset = "0x120498C", VA = "0x120498C")]
		private static extern RESULT FMOD5_System_Get3DListenerAttributes(IntPtr system, int listener, out VECTOR pos, out VECTOR vel, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1204A6C", Offset = "0x1204A6C", VA = "0x1204A6C")]
		private static extern RESULT FMOD5_System_Set3DRolloffCallback(IntPtr system, CB_3D_ROLLOFF_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1204B24", Offset = "0x1204B24", VA = "0x1204B24")]
		private static extern RESULT FMOD5_System_MixerSuspend(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1204BC4", Offset = "0x1204BC4", VA = "0x1204BC4")]
		private static extern RESULT FMOD5_System_MixerResume(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1204C64", Offset = "0x1204C64", VA = "0x1204C64")]
		private static extern RESULT FMOD5_System_GetDefaultMixMatrix(IntPtr system, SPEAKERMODE sourcespeakermode, SPEAKERMODE targetspeakermode, float[] matrix, int matrixhop);

		[PreserveSig]
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1204D3C", Offset = "0x1204D3C", VA = "0x1204D3C")]
		private static extern RESULT FMOD5_System_GetSpeakerModeChannels(IntPtr system, SPEAKERMODE mode, out int channels);

		[PreserveSig]
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1204DF4", Offset = "0x1204DF4", VA = "0x1204DF4")]
		private static extern RESULT FMOD5_System_GetVersion(IntPtr system, out uint version);

		[PreserveSig]
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x1204EA4", Offset = "0x1204EA4", VA = "0x1204EA4")]
		private static extern RESULT FMOD5_System_GetOutputHandle(IntPtr system, out IntPtr handle);

		[PreserveSig]
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x1204FA4", Offset = "0x1204FA4", VA = "0x1204FA4")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x120505C", Offset = "0x120505C", VA = "0x120505C")]
		private static extern RESULT FMOD5_System_GetChannelsPlaying(IntPtr system, out int channels, out int realchannels);

		[PreserveSig]
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1205114", Offset = "0x1205114", VA = "0x1205114")]
		private static extern RESULT FMOD5_System_GetCPUUsage(IntPtr system, out float dsp, out float stream, out float geometry, out float update, out float total);

		[PreserveSig]
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x12051F4", Offset = "0x12051F4", VA = "0x12051F4")]
		private static extern RESULT FMOD5_System_GetFileUsage(IntPtr system, out long sampleBytesRead, out long streamBytesRead, out long otherBytesRead);

		[PreserveSig]
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x120542C", Offset = "0x120542C", VA = "0x120542C")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1205570", Offset = "0x1205570", VA = "0x1205570")]
		private static extern RESULT FMOD5_System_CreateSound(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x12058F8", Offset = "0x12058F8", VA = "0x12058F8")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, byte[] name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1205A3C", Offset = "0x1205A3C", VA = "0x1205A3C")]
		private static extern RESULT FMOD5_System_CreateStream(IntPtr system, IntPtr name_or_data, MODE mode, ref CREATESOUNDEXINFO exinfo, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1205C54", Offset = "0x1205C54", VA = "0x1205C54")]
		private static extern RESULT FMOD5_System_CreateDSP(IntPtr system, ref DSP_DESCRIPTION description, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1205D6C", Offset = "0x1205D6C", VA = "0x1205D6C")]
		private static extern RESULT FMOD5_System_CreateDSPByType(IntPtr system, DSP_TYPE type, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x1205F7C", Offset = "0x1205F7C", VA = "0x1205F7C")]
		private static extern RESULT FMOD5_System_CreateChannelGroup(IntPtr system, byte[] name, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000136")]
		[Address(RVA = "0x1206194", Offset = "0x1206194", VA = "0x1206194")]
		private static extern RESULT FMOD5_System_CreateSoundGroup(IntPtr system, byte[] name, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1206254", Offset = "0x1206254", VA = "0x1206254")]
		private static extern RESULT FMOD5_System_CreateReverb3D(IntPtr system, out IntPtr reverb);

		[PreserveSig]
		[Token(Token = "0x6000138")]
		[Address(RVA = "0x1206308", Offset = "0x1206308", VA = "0x1206308")]
		private static extern RESULT FMOD5_System_PlaySound(IntPtr system, IntPtr sound, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x12063DC", Offset = "0x12063DC", VA = "0x12063DC")]
		private static extern RESULT FMOD5_System_PlayDSP(IntPtr system, IntPtr dsp, IntPtr channelgroup, bool paused, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x12064AC", Offset = "0x12064AC", VA = "0x12064AC")]
		private static extern RESULT FMOD5_System_GetChannel(IntPtr system, int channelid, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1206564", Offset = "0x1206564", VA = "0x1206564")]
		private static extern RESULT FMOD5_System_GetMasterChannelGroup(IntPtr system, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1206614", Offset = "0x1206614", VA = "0x1206614")]
		private static extern RESULT FMOD5_System_GetMasterSoundGroup(IntPtr system, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x12066C8", Offset = "0x12066C8", VA = "0x12066C8")]
		private static extern RESULT FMOD5_System_AttachChannelGroupToPort(IntPtr system, uint portType, ulong portIndex, IntPtr channelgroup, bool passThru);

		[PreserveSig]
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1206798", Offset = "0x1206798", VA = "0x1206798")]
		private static extern RESULT FMOD5_System_DetachChannelGroupFromPort(IntPtr system, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1206848", Offset = "0x1206848", VA = "0x1206848")]
		private static extern RESULT FMOD5_System_SetReverbProperties(IntPtr system, int instance, ref REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1206900", Offset = "0x1206900", VA = "0x1206900")]
		private static extern RESULT FMOD5_System_GetReverbProperties(IntPtr system, int instance, out REVERB_PROPERTIES prop);

		[PreserveSig]
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x12069B8", Offset = "0x12069B8", VA = "0x12069B8")]
		private static extern RESULT FMOD5_System_LockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1206A58", Offset = "0x1206A58", VA = "0x1206A58")]
		private static extern RESULT FMOD5_System_UnlockDSP(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1206AF8", Offset = "0x1206AF8", VA = "0x1206AF8")]
		private static extern RESULT FMOD5_System_GetRecordNumDrivers(IntPtr system, out int numdrivers, out int numconnected);

		[PreserveSig]
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1206DAC", Offset = "0x1206DAC", VA = "0x1206DAC")]
		private static extern RESULT FMOD5_System_GetRecordDriverInfo(IntPtr system, int id, IntPtr name, int namelen, out Guid guid, out int systemrate, out SPEAKERMODE speakermode, out int speakermodechannels, out DRIVER_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1206F4C", Offset = "0x1206F4C", VA = "0x1206F4C")]
		private static extern RESULT FMOD5_System_GetRecordPosition(IntPtr system, int id, out uint position);

		[PreserveSig]
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1207008", Offset = "0x1207008", VA = "0x1207008")]
		private static extern RESULT FMOD5_System_RecordStart(IntPtr system, int id, IntPtr sound, bool loop);

		[PreserveSig]
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x12070CC", Offset = "0x12070CC", VA = "0x12070CC")]
		private static extern RESULT FMOD5_System_RecordStop(IntPtr system, int id);

		[PreserveSig]
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x120717C", Offset = "0x120717C", VA = "0x120717C")]
		private static extern RESULT FMOD5_System_IsRecording(IntPtr system, int id, out bool recording);

		[PreserveSig]
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1207248", Offset = "0x1207248", VA = "0x1207248")]
		private static extern RESULT FMOD5_System_CreateGeometry(IntPtr system, int maxpolygons, int maxvertices, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1207310", Offset = "0x1207310", VA = "0x1207310")]
		private static extern RESULT FMOD5_System_SetGeometrySettings(IntPtr system, float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x12073C0", Offset = "0x12073C0", VA = "0x12073C0")]
		private static extern RESULT FMOD5_System_GetGeometrySettings(IntPtr system, out float maxworldsize);

		[PreserveSig]
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1207470", Offset = "0x1207470", VA = "0x1207470")]
		private static extern RESULT FMOD5_System_LoadGeometry(IntPtr system, IntPtr data, int datasize, out IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1207538", Offset = "0x1207538", VA = "0x1207538")]
		private static extern RESULT FMOD5_System_GetGeometryOcclusion(IntPtr system, ref VECTOR listener, ref VECTOR source, out float direct, out float reverb);

		[PreserveSig]
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1207758", Offset = "0x1207758", VA = "0x1207758")]
		private static extern RESULT FMOD5_System_SetNetworkProxy(IntPtr system, byte[] proxy);

		[PreserveSig]
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x12079CC", Offset = "0x12079CC", VA = "0x12079CC")]
		private static extern RESULT FMOD5_System_GetNetworkProxy(IntPtr system, IntPtr proxy, int proxylen);

		[PreserveSig]
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1207A84", Offset = "0x1207A84", VA = "0x1207A84")]
		private static extern RESULT FMOD5_System_SetNetworkTimeout(IntPtr system, int timeout);

		[PreserveSig]
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1207B34", Offset = "0x1207B34", VA = "0x1207B34")]
		private static extern RESULT FMOD5_System_GetNetworkTimeout(IntPtr system, out int timeout);

		[PreserveSig]
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x1207BE4", Offset = "0x1207BE4", VA = "0x1207BE4")]
		private static extern RESULT FMOD5_System_SetUserData(IntPtr system, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x1207C94", Offset = "0x1207C94", VA = "0x1207C94")]
		private static extern RESULT FMOD5_System_GetUserData(IntPtr system, out IntPtr userdata);

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x9AF024", Offset = "0x9AF024", VA = "0x9AF024")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x9AF02C", Offset = "0x9AF02C", VA = "0x9AF02C")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004D")]
	public struct Sound
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x9ADC6C", Offset = "0x9ADC6C", VA = "0x9ADC6C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x9ADC74", Offset = "0x9ADC74", VA = "0x9ADC74")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x9ADC7C", Offset = "0x9ADC7C", VA = "0x9ADC7C")]
		public RESULT @lock(uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x9ADC84", Offset = "0x9ADC84", VA = "0x9ADC84")]
		public RESULT unlock(IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x9ADC8C", Offset = "0x9ADC8C", VA = "0x9ADC8C")]
		public RESULT setDefaults(float frequency, int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015B")]
		[Address(RVA = "0x9ADC94", Offset = "0x9ADC94", VA = "0x9ADC94")]
		public RESULT getDefaults(out float frequency, out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015C")]
		[Address(RVA = "0x9ADC9C", Offset = "0x9ADC9C", VA = "0x9ADC9C")]
		public RESULT set3DMinMaxDistance(float min, float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x9ADCA4", Offset = "0x9ADCA4", VA = "0x9ADCA4")]
		public RESULT get3DMinMaxDistance(out float min, out float max)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x9ADCAC", Offset = "0x9ADCAC", VA = "0x9ADCAC")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x9ADCB4", Offset = "0x9ADCB4", VA = "0x9ADCB4")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x9ADCBC", Offset = "0x9ADCBC", VA = "0x9ADCBC")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x9ADCC4", Offset = "0x9ADCC4", VA = "0x9ADCC4")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x9ADCCC", Offset = "0x9ADCCC", VA = "0x9ADCCC")]
		public RESULT getSubSound(int index, out Sound subsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x9ADCD4", Offset = "0x9ADCD4", VA = "0x9ADCD4")]
		public RESULT getSubSoundParent(out Sound parentsound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x9ADCDC", Offset = "0x9ADCDC", VA = "0x9ADCDC")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x9ADCE4", Offset = "0x9ADCE4", VA = "0x9ADCE4")]
		public RESULT getLength(out uint length, TIMEUNIT lengthtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x9ADCEC", Offset = "0x9ADCEC", VA = "0x9ADCEC")]
		public RESULT getFormat(out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x9ADCF4", Offset = "0x9ADCF4", VA = "0x9ADCF4")]
		public RESULT getNumSubSounds(out int numsubsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x9ADCFC", Offset = "0x9ADCFC", VA = "0x9ADCFC")]
		public RESULT getNumTags(out int numtags, out int numtagsupdated)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x9ADD04", Offset = "0x9ADD04", VA = "0x9ADD04")]
		public RESULT getTag(string name, int index, out TAG tag)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x9ADD0C", Offset = "0x9ADD0C", VA = "0x9ADD0C")]
		public RESULT getOpenState(out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x9ADD14", Offset = "0x9ADD14", VA = "0x9ADD14")]
		public RESULT readData(IntPtr buffer, uint length, out uint read)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x9ADD1C", Offset = "0x9ADD1C", VA = "0x9ADD1C")]
		public RESULT seekData(uint pcm)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x9ADD24", Offset = "0x9ADD24", VA = "0x9ADD24")]
		public RESULT setSoundGroup(SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x9ADD2C", Offset = "0x9ADD2C", VA = "0x9ADD2C")]
		public RESULT getSoundGroup(out SoundGroup soundgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x9ADD34", Offset = "0x9ADD34", VA = "0x9ADD34")]
		public RESULT getNumSyncPoints(out int numsyncpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x9ADD3C", Offset = "0x9ADD3C", VA = "0x9ADD3C")]
		public RESULT getSyncPoint(int index, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x9ADD44", Offset = "0x9ADD44", VA = "0x9ADD44")]
		public RESULT getSyncPointInfo(IntPtr point, out string name, int namelen, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x9ADD4C", Offset = "0x9ADD4C", VA = "0x9ADD4C")]
		public RESULT getSyncPointInfo(IntPtr point, out uint offset, TIMEUNIT offsettype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x9ADD54", Offset = "0x9ADD54", VA = "0x9ADD54")]
		public RESULT addSyncPoint(uint offset, TIMEUNIT offsettype, string name, out IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x9ADD5C", Offset = "0x9ADD5C", VA = "0x9ADD5C")]
		public RESULT deleteSyncPoint(IntPtr point)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x9ADD64", Offset = "0x9ADD64", VA = "0x9ADD64")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x9ADD6C", Offset = "0x9ADD6C", VA = "0x9ADD6C")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x9ADD74", Offset = "0x9ADD74", VA = "0x9ADD74")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x9ADD7C", Offset = "0x9ADD7C", VA = "0x9ADD7C")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x9ADD84", Offset = "0x9ADD84", VA = "0x9ADD84")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x9ADD8C", Offset = "0x9ADD8C", VA = "0x9ADD8C")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x9ADD94", Offset = "0x9ADD94", VA = "0x9ADD94")]
		public RESULT getMusicNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x9ADD9C", Offset = "0x9ADD9C", VA = "0x9ADD9C")]
		public RESULT setMusicChannelVolume(int channel, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x9ADDA4", Offset = "0x9ADDA4", VA = "0x9ADDA4")]
		public RESULT getMusicChannelVolume(int channel, out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x9ADDAC", Offset = "0x9ADDAC", VA = "0x9ADDAC")]
		public RESULT setMusicSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x9ADDB4", Offset = "0x9ADDB4", VA = "0x9ADDB4")]
		public RESULT getMusicSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x9ADDBC", Offset = "0x9ADDBC", VA = "0x9ADDBC")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x9ADDC4", Offset = "0x9ADDC4", VA = "0x9ADDC4")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000182")]
		[Address(RVA = "0x11F127C", Offset = "0x11F127C", VA = "0x11F127C")]
		private static extern RESULT FMOD5_Sound_Release(IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000183")]
		[Address(RVA = "0x11F131C", Offset = "0x11F131C", VA = "0x11F131C")]
		private static extern RESULT FMOD5_Sound_GetSystemObject(IntPtr sound, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000184")]
		[Address(RVA = "0x11F13CC", Offset = "0x11F13CC", VA = "0x11F13CC")]
		private static extern RESULT FMOD5_Sound_Lock(IntPtr sound, uint offset, uint length, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2);

		[PreserveSig]
		[Token(Token = "0x6000185")]
		[Address(RVA = "0x11F14B4", Offset = "0x11F14B4", VA = "0x11F14B4")]
		private static extern RESULT FMOD5_Sound_Unlock(IntPtr sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2);

		[PreserveSig]
		[Token(Token = "0x6000186")]
		[Address(RVA = "0x11F1584", Offset = "0x11F1584", VA = "0x11F1584")]
		private static extern RESULT FMOD5_Sound_SetDefaults(IntPtr sound, float frequency, int priority);

		[PreserveSig]
		[Token(Token = "0x6000187")]
		[Address(RVA = "0x11F1644", Offset = "0x11F1644", VA = "0x11F1644")]
		private static extern RESULT FMOD5_Sound_GetDefaults(IntPtr sound, out float frequency, out int priority);

		[PreserveSig]
		[Token(Token = "0x6000188")]
		[Address(RVA = "0x11F16FC", Offset = "0x11F16FC", VA = "0x11F16FC")]
		private static extern RESULT FMOD5_Sound_Set3DMinMaxDistance(IntPtr sound, float min, float max);

		[PreserveSig]
		[Token(Token = "0x6000189")]
		[Address(RVA = "0x11F17B4", Offset = "0x11F17B4", VA = "0x11F17B4")]
		private static extern RESULT FMOD5_Sound_Get3DMinMaxDistance(IntPtr sound, out float min, out float max);

		[PreserveSig]
		[Token(Token = "0x600018A")]
		[Address(RVA = "0x11F186C", Offset = "0x11F186C", VA = "0x11F186C")]
		private static extern RESULT FMOD5_Sound_Set3DConeSettings(IntPtr sound, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600018B")]
		[Address(RVA = "0x11F1934", Offset = "0x11F1934", VA = "0x11F1934")]
		private static extern RESULT FMOD5_Sound_Get3DConeSettings(IntPtr sound, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x600018C")]
		[Address(RVA = "0x11F19FC", Offset = "0x11F19FC", VA = "0x11F19FC")]
		private static extern RESULT FMOD5_Sound_Set3DCustomRolloff(IntPtr sound, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x600018D")]
		[Address(RVA = "0x11F1AB4", Offset = "0x11F1AB4", VA = "0x11F1AB4")]
		private static extern RESULT FMOD5_Sound_Get3DCustomRolloff(IntPtr sound, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600018E")]
		[Address(RVA = "0x11F1B6C", Offset = "0x11F1B6C", VA = "0x11F1B6C")]
		private static extern RESULT FMOD5_Sound_GetSubSound(IntPtr sound, int index, out IntPtr subsound);

		[PreserveSig]
		[Token(Token = "0x600018F")]
		[Address(RVA = "0x11F1C24", Offset = "0x11F1C24", VA = "0x11F1C24")]
		private static extern RESULT FMOD5_Sound_GetSubSoundParent(IntPtr sound, out IntPtr parentsound);

		[PreserveSig]
		[Token(Token = "0x6000190")]
		[Address(RVA = "0x11F1E90", Offset = "0x11F1E90", VA = "0x11F1E90")]
		private static extern RESULT FMOD5_Sound_GetName(IntPtr sound, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000191")]
		[Address(RVA = "0x11F23EC", Offset = "0x11F23EC", VA = "0x11F23EC")]
		private static extern RESULT FMOD5_Sound_GetLength(IntPtr sound, out uint length, TIMEUNIT lengthtype);

		[PreserveSig]
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x11F24A4", Offset = "0x11F24A4", VA = "0x11F24A4")]
		private static extern RESULT FMOD5_Sound_GetFormat(IntPtr sound, out SOUND_TYPE type, out SOUND_FORMAT format, out int channels, out int bits);

		[PreserveSig]
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x11F2574", Offset = "0x11F2574", VA = "0x11F2574")]
		private static extern RESULT FMOD5_Sound_GetNumSubSounds(IntPtr sound, out int numsubsounds);

		[PreserveSig]
		[Token(Token = "0x6000194")]
		[Address(RVA = "0x11F2624", Offset = "0x11F2624", VA = "0x11F2624")]
		private static extern RESULT FMOD5_Sound_GetNumTags(IntPtr sound, out int numtags, out int numtagsupdated);

		[PreserveSig]
		[Token(Token = "0x6000195")]
		[Address(RVA = "0x11F2990", Offset = "0x11F2990", VA = "0x11F2990")]
		private static extern RESULT FMOD5_Sound_GetTag(IntPtr sound, byte[] name, int index, out TAG tag);

		[PreserveSig]
		[Token(Token = "0x6000196")]
		[Address(RVA = "0x11F2A9C", Offset = "0x11F2A9C", VA = "0x11F2A9C")]
		private static extern RESULT FMOD5_Sound_GetOpenState(IntPtr sound, out OPENSTATE openstate, out uint percentbuffered, out bool starving, out bool diskbusy);

		[PreserveSig]
		[Token(Token = "0x6000197")]
		[Address(RVA = "0x11F2B90", Offset = "0x11F2B90", VA = "0x11F2B90")]
		private static extern RESULT FMOD5_Sound_ReadData(IntPtr sound, IntPtr buffer, uint length, out uint read);

		[PreserveSig]
		[Token(Token = "0x6000198")]
		[Address(RVA = "0x11F2C58", Offset = "0x11F2C58", VA = "0x11F2C58")]
		private static extern RESULT FMOD5_Sound_SeekData(IntPtr sound, uint pcm);

		[PreserveSig]
		[Token(Token = "0x6000199")]
		[Address(RVA = "0x11F2D08", Offset = "0x11F2D08", VA = "0x11F2D08")]
		private static extern RESULT FMOD5_Sound_SetSoundGroup(IntPtr sound, IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600019A")]
		[Address(RVA = "0x11F2DB8", Offset = "0x11F2DB8", VA = "0x11F2DB8")]
		private static extern RESULT FMOD5_Sound_GetSoundGroup(IntPtr sound, out IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600019B")]
		[Address(RVA = "0x11F2E68", Offset = "0x11F2E68", VA = "0x11F2E68")]
		private static extern RESULT FMOD5_Sound_GetNumSyncPoints(IntPtr sound, out int numsyncpoints);

		[PreserveSig]
		[Token(Token = "0x600019C")]
		[Address(RVA = "0x11F2F18", Offset = "0x11F2F18", VA = "0x11F2F18")]
		private static extern RESULT FMOD5_Sound_GetSyncPoint(IntPtr sound, int index, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x600019D")]
		[Address(RVA = "0x11F31A4", Offset = "0x11F31A4", VA = "0x11F31A4")]
		private static extern RESULT FMOD5_Sound_GetSyncPointInfo(IntPtr sound, IntPtr point, IntPtr name, int namelen, out uint offset, TIMEUNIT offsettype);

		[PreserveSig]
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x11F3468", Offset = "0x11F3468", VA = "0x11F3468")]
		private static extern RESULT FMOD5_Sound_AddSyncPoint(IntPtr sound, uint offset, TIMEUNIT offsettype, byte[] name, out IntPtr point);

		[PreserveSig]
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x11F3540", Offset = "0x11F3540", VA = "0x11F3540")]
		private static extern RESULT FMOD5_Sound_DeleteSyncPoint(IntPtr sound, IntPtr point);

		[PreserveSig]
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x11F35F0", Offset = "0x11F35F0", VA = "0x11F35F0")]
		private static extern RESULT FMOD5_Sound_SetMode(IntPtr sound, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x11F36A0", Offset = "0x11F36A0", VA = "0x11F36A0")]
		private static extern RESULT FMOD5_Sound_GetMode(IntPtr sound, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x11F3750", Offset = "0x11F3750", VA = "0x11F3750")]
		private static extern RESULT FMOD5_Sound_SetLoopCount(IntPtr sound, int loopcount);

		[PreserveSig]
		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x11F3800", Offset = "0x11F3800", VA = "0x11F3800")]
		private static extern RESULT FMOD5_Sound_GetLoopCount(IntPtr sound, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x11F38B0", Offset = "0x11F38B0", VA = "0x11F38B0")]
		private static extern RESULT FMOD5_Sound_SetLoopPoints(IntPtr sound, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x11F3980", Offset = "0x11F3980", VA = "0x11F3980")]
		private static extern RESULT FMOD5_Sound_GetLoopPoints(IntPtr sound, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x11F3A50", Offset = "0x11F3A50", VA = "0x11F3A50")]
		private static extern RESULT FMOD5_Sound_GetMusicNumChannels(IntPtr sound, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x11F3B00", Offset = "0x11F3B00", VA = "0x11F3B00")]
		private static extern RESULT FMOD5_Sound_SetMusicChannelVolume(IntPtr sound, int channel, float volume);

		[PreserveSig]
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x11F3BC0", Offset = "0x11F3BC0", VA = "0x11F3BC0")]
		private static extern RESULT FMOD5_Sound_GetMusicChannelVolume(IntPtr sound, int channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x11F3C78", Offset = "0x11F3C78", VA = "0x11F3C78")]
		private static extern RESULT FMOD5_Sound_SetMusicSpeed(IntPtr sound, float speed);

		[PreserveSig]
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x11F3D28", Offset = "0x11F3D28", VA = "0x11F3D28")]
		private static extern RESULT FMOD5_Sound_GetMusicSpeed(IntPtr sound, out float speed);

		[PreserveSig]
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x11F3DD8", Offset = "0x11F3DD8", VA = "0x11F3DD8")]
		private static extern RESULT FMOD5_Sound_SetUserData(IntPtr sound, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x11F3E88", Offset = "0x11F3E88", VA = "0x11F3E88")]
		private static extern RESULT FMOD5_Sound_GetUserData(IntPtr sound, out IntPtr userdata);

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x9ADDCC", Offset = "0x9ADDCC", VA = "0x9ADDCC")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x9ADDD4", Offset = "0x9ADDD4", VA = "0x9ADDD4")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x200004E")]
	internal interface IChannelControl
	{
		[Token(Token = "0x60001AF")]
		RESULT getSystemObject(out System system);

		[Token(Token = "0x60001B0")]
		RESULT stop();

		[Token(Token = "0x60001B1")]
		RESULT setPaused(bool paused);

		[Token(Token = "0x60001B2")]
		RESULT getPaused(out bool paused);

		[Token(Token = "0x60001B3")]
		RESULT setVolume(float volume);

		[Token(Token = "0x60001B4")]
		RESULT getVolume(out float volume);

		[Token(Token = "0x60001B5")]
		RESULT setVolumeRamp(bool ramp);

		[Token(Token = "0x60001B6")]
		RESULT getVolumeRamp(out bool ramp);

		[Token(Token = "0x60001B7")]
		RESULT getAudibility(out float audibility);

		[Token(Token = "0x60001B8")]
		RESULT setPitch(float pitch);

		[Token(Token = "0x60001B9")]
		RESULT getPitch(out float pitch);

		[Token(Token = "0x60001BA")]
		RESULT setMute(bool mute);

		[Token(Token = "0x60001BB")]
		RESULT getMute(out bool mute);

		[Token(Token = "0x60001BC")]
		RESULT setReverbProperties(int instance, float wet);

		[Token(Token = "0x60001BD")]
		RESULT getReverbProperties(int instance, out float wet);

		[Token(Token = "0x60001BE")]
		RESULT setLowPassGain(float gain);

		[Token(Token = "0x60001BF")]
		RESULT getLowPassGain(out float gain);

		[Token(Token = "0x60001C0")]
		RESULT setMode(MODE mode);

		[Token(Token = "0x60001C1")]
		RESULT getMode(out MODE mode);

		[Token(Token = "0x60001C2")]
		RESULT setCallback(CHANNELCONTROL_CALLBACK callback);

		[Token(Token = "0x60001C3")]
		RESULT isPlaying(out bool isplaying);

		[Token(Token = "0x60001C4")]
		RESULT setPan(float pan);

		[Token(Token = "0x60001C5")]
		RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[Token(Token = "0x60001C6")]
		RESULT setMixLevelsInput(float[] levels, int numlevels);

		[Token(Token = "0x60001C7")]
		RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[Token(Token = "0x60001C8")]
		RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[Token(Token = "0x60001C9")]
		RESULT getDSPClock(out ulong dspclock, out ulong parentclock);

		[Token(Token = "0x60001CA")]
		RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[Token(Token = "0x60001CB")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end);

		[Token(Token = "0x60001CC")]
		RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[Token(Token = "0x60001CD")]
		RESULT addFadePoint(ulong dspclock, float volume);

		[Token(Token = "0x60001CE")]
		RESULT setFadePointRamp(ulong dspclock, float volume);

		[Token(Token = "0x60001CF")]
		RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end);

		[Token(Token = "0x60001D0")]
		RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[Token(Token = "0x60001D1")]
		RESULT getDSP(int index, out DSP dsp);

		[Token(Token = "0x60001D2")]
		RESULT addDSP(int index, DSP dsp);

		[Token(Token = "0x60001D3")]
		RESULT removeDSP(DSP dsp);

		[Token(Token = "0x60001D4")]
		RESULT getNumDSPs(out int numdsps);

		[Token(Token = "0x60001D5")]
		RESULT setDSPIndex(DSP dsp, int index);

		[Token(Token = "0x60001D6")]
		RESULT getDSPIndex(DSP dsp, out int index);

		[Token(Token = "0x60001D7")]
		RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel);

		[Token(Token = "0x60001D8")]
		RESULT get3DAttributes(out VECTOR pos, out VECTOR vel);

		[Token(Token = "0x60001D9")]
		RESULT set3DMinMaxDistance(float mindistance, float maxdistance);

		[Token(Token = "0x60001DA")]
		RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance);

		[Token(Token = "0x60001DB")]
		RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume);

		[Token(Token = "0x60001DC")]
		RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[Token(Token = "0x60001DD")]
		RESULT set3DConeOrientation(ref VECTOR orientation);

		[Token(Token = "0x60001DE")]
		RESULT get3DConeOrientation(out VECTOR orientation);

		[Token(Token = "0x60001DF")]
		RESULT set3DCustomRolloff(ref VECTOR points, int numpoints);

		[Token(Token = "0x60001E0")]
		RESULT get3DCustomRolloff(out IntPtr points, out int numpoints);

		[Token(Token = "0x60001E1")]
		RESULT set3DOcclusion(float directocclusion, float reverbocclusion);

		[Token(Token = "0x60001E2")]
		RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion);

		[Token(Token = "0x60001E3")]
		RESULT set3DSpread(float angle);

		[Token(Token = "0x60001E4")]
		RESULT get3DSpread(out float angle);

		[Token(Token = "0x60001E5")]
		RESULT set3DLevel(float level);

		[Token(Token = "0x60001E6")]
		RESULT get3DLevel(out float level);

		[Token(Token = "0x60001E7")]
		RESULT set3DDopplerLevel(float level);

		[Token(Token = "0x60001E8")]
		RESULT get3DDopplerLevel(out float level);

		[Token(Token = "0x60001E9")]
		RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq);

		[Token(Token = "0x60001EA")]
		RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq);

		[Token(Token = "0x60001EB")]
		RESULT setUserData(IntPtr userdata);

		[Token(Token = "0x60001EC")]
		RESULT getUserData(out IntPtr userdata);
	}
	[Token(Token = "0x200004F")]
	public struct Channel : IChannelControl
	{
		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x9C50C4", Offset = "0x9C50C4", VA = "0x9C50C4")]
		public RESULT setFrequency(float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x9C50CC", Offset = "0x9C50CC", VA = "0x9C50CC")]
		public RESULT getFrequency(out float frequency)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x9C50D4", Offset = "0x9C50D4", VA = "0x9C50D4")]
		public RESULT setPriority(int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x9C50DC", Offset = "0x9C50DC", VA = "0x9C50DC")]
		public RESULT getPriority(out int priority)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x9C50E4", Offset = "0x9C50E4", VA = "0x9C50E4")]
		public RESULT setPosition(uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x9C50EC", Offset = "0x9C50EC", VA = "0x9C50EC")]
		public RESULT getPosition(out uint position, TIMEUNIT postype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x9C50F4", Offset = "0x9C50F4", VA = "0x9C50F4")]
		public RESULT setChannelGroup(ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x9C50FC", Offset = "0x9C50FC", VA = "0x9C50FC")]
		public RESULT getChannelGroup(out ChannelGroup channelgroup)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x9C5104", Offset = "0x9C5104", VA = "0x9C5104")]
		public RESULT setLoopCount(int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x9C510C", Offset = "0x9C510C", VA = "0x9C510C")]
		public RESULT getLoopCount(out int loopcount)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x9C5114", Offset = "0x9C5114", VA = "0x9C5114")]
		public RESULT setLoopPoints(uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x9C511C", Offset = "0x9C511C", VA = "0x9C511C")]
		public RESULT getLoopPoints(out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x9C5124", Offset = "0x9C5124", VA = "0x9C5124")]
		public RESULT isVirtual(out bool isvirtual)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x9C512C", Offset = "0x9C512C", VA = "0x9C512C")]
		public RESULT getCurrentSound(out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x9C5134", Offset = "0x9C5134", VA = "0x9C5134")]
		public RESULT getIndex(out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x9C513C", Offset = "0x9C513C", VA = "0x9C513C", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9C5144", Offset = "0x9C5144", VA = "0x9C5144", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x9C514C", Offset = "0x9C514C", VA = "0x9C514C", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x9C5158", Offset = "0x9C5158", VA = "0x9C5158", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x9C5160", Offset = "0x9C5160", VA = "0x9C5160", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000201")]
		[Address(RVA = "0x9C5168", Offset = "0x9C5168", VA = "0x9C5168", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x9C5170", Offset = "0x9C5170", VA = "0x9C5170", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x9C517C", Offset = "0x9C517C", VA = "0x9C517C", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x9C5184", Offset = "0x9C5184", VA = "0x9C5184", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x9C518C", Offset = "0x9C518C", VA = "0x9C518C", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x9C5194", Offset = "0x9C5194", VA = "0x9C5194", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x9C519C", Offset = "0x9C519C", VA = "0x9C519C", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x9C51A8", Offset = "0x9C51A8", VA = "0x9C51A8", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000209")]
		[Address(RVA = "0x9C51B0", Offset = "0x9C51B0", VA = "0x9C51B0", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x9C51B8", Offset = "0x9C51B8", VA = "0x9C51B8", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020B")]
		[Address(RVA = "0x9C51C0", Offset = "0x9C51C0", VA = "0x9C51C0", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x9C51C8", Offset = "0x9C51C8", VA = "0x9C51C8", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x9C51D0", Offset = "0x9C51D0", VA = "0x9C51D0", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x9C51D8", Offset = "0x9C51D8", VA = "0x9C51D8", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x9C51E0", Offset = "0x9C51E0", VA = "0x9C51E0", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x9C51E8", Offset = "0x9C51E8", VA = "0x9C51E8", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x9C51F0", Offset = "0x9C51F0", VA = "0x9C51F0", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x9C51F8", Offset = "0x9C51F8", VA = "0x9C51F8", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000213")]
		[Address(RVA = "0x9C5200", Offset = "0x9C5200", VA = "0x9C5200", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000214")]
		[Address(RVA = "0x9C5208", Offset = "0x9C5208", VA = "0x9C5208", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000215")]
		[Address(RVA = "0x9C5210", Offset = "0x9C5210", VA = "0x9C5210", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000216")]
		[Address(RVA = "0x9C5218", Offset = "0x9C5218", VA = "0x9C5218", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000217")]
		[Address(RVA = "0x9C5220", Offset = "0x9C5220", VA = "0x9C5220", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000218")]
		[Address(RVA = "0x9C522C", Offset = "0x9C522C", VA = "0x9C522C", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000219")]
		[Address(RVA = "0x9C5234", Offset = "0x9C5234", VA = "0x9C5234", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021A")]
		[Address(RVA = "0x9C523C", Offset = "0x9C523C", VA = "0x9C523C", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021B")]
		[Address(RVA = "0x9C5244", Offset = "0x9C5244", VA = "0x9C5244", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021C")]
		[Address(RVA = "0x9C524C", Offset = "0x9C524C", VA = "0x9C524C", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021D")]
		[Address(RVA = "0x9C5254", Offset = "0x9C5254", VA = "0x9C5254", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021E")]
		[Address(RVA = "0x9C525C", Offset = "0x9C525C", VA = "0x9C525C", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600021F")]
		[Address(RVA = "0x9C5264", Offset = "0x9C5264", VA = "0x9C5264", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000220")]
		[Address(RVA = "0x9C526C", Offset = "0x9C526C", VA = "0x9C526C", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000221")]
		[Address(RVA = "0x9C5274", Offset = "0x9C5274", VA = "0x9C5274", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000222")]
		[Address(RVA = "0x9C527C", Offset = "0x9C527C", VA = "0x9C527C", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000223")]
		[Address(RVA = "0x9C5284", Offset = "0x9C5284", VA = "0x9C5284", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000224")]
		[Address(RVA = "0x9C528C", Offset = "0x9C528C", VA = "0x9C528C", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x9C5294", Offset = "0x9C5294", VA = "0x9C5294", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x9C529C", Offset = "0x9C529C", VA = "0x9C529C", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x9C52A4", Offset = "0x9C52A4", VA = "0x9C52A4", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x9C52AC", Offset = "0x9C52AC", VA = "0x9C52AC", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x9C52B4", Offset = "0x9C52B4", VA = "0x9C52B4", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x9C52BC", Offset = "0x9C52BC", VA = "0x9C52BC", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022B")]
		[Address(RVA = "0x9C52C4", Offset = "0x9C52C4", VA = "0x9C52C4", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022C")]
		[Address(RVA = "0x9C52CC", Offset = "0x9C52CC", VA = "0x9C52CC", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022D")]
		[Address(RVA = "0x9C52D4", Offset = "0x9C52D4", VA = "0x9C52D4", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022E")]
		[Address(RVA = "0x9C52DC", Offset = "0x9C52DC", VA = "0x9C52DC", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600022F")]
		[Address(RVA = "0x9C52E4", Offset = "0x9C52E4", VA = "0x9C52E4", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000230")]
		[Address(RVA = "0x9C52EC", Offset = "0x9C52EC", VA = "0x9C52EC", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000231")]
		[Address(RVA = "0x9C52F4", Offset = "0x9C52F4", VA = "0x9C52F4", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000232")]
		[Address(RVA = "0x9C52FC", Offset = "0x9C52FC", VA = "0x9C52FC", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x9C5304", Offset = "0x9C5304", VA = "0x9C5304", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x9C530C", Offset = "0x9C530C", VA = "0x9C530C", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x9C5314", Offset = "0x9C5314", VA = "0x9C5314", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000236")]
		[Address(RVA = "0x9C531C", Offset = "0x9C531C", VA = "0x9C531C", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x9C5328", Offset = "0x9C5328", VA = "0x9C5328", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x9C5330", Offset = "0x9C5330", VA = "0x9C5330", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x9C5338", Offset = "0x9C5338", VA = "0x9C5338", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x175F66C", Offset = "0x175F66C", VA = "0x175F66C")]
		private static extern RESULT FMOD5_Channel_SetFrequency(IntPtr channel, float frequency);

		[PreserveSig]
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x175F71C", Offset = "0x175F71C", VA = "0x175F71C")]
		private static extern RESULT FMOD5_Channel_GetFrequency(IntPtr channel, out float frequency);

		[PreserveSig]
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x175F7CC", Offset = "0x175F7CC", VA = "0x175F7CC")]
		private static extern RESULT FMOD5_Channel_SetPriority(IntPtr channel, int priority);

		[PreserveSig]
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x175F87C", Offset = "0x175F87C", VA = "0x175F87C")]
		private static extern RESULT FMOD5_Channel_GetPriority(IntPtr channel, out int priority);

		[PreserveSig]
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x175F92C", Offset = "0x175F92C", VA = "0x175F92C")]
		private static extern RESULT FMOD5_Channel_SetPosition(IntPtr channel, uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x175F9E4", Offset = "0x175F9E4", VA = "0x175F9E4")]
		private static extern RESULT FMOD5_Channel_GetPosition(IntPtr channel, out uint position, TIMEUNIT postype);

		[PreserveSig]
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x175FA9C", Offset = "0x175FA9C", VA = "0x175FA9C")]
		private static extern RESULT FMOD5_Channel_SetChannelGroup(IntPtr channel, IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x175FB4C", Offset = "0x175FB4C", VA = "0x175FB4C")]
		private static extern RESULT FMOD5_Channel_GetChannelGroup(IntPtr channel, out IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x175FBFC", Offset = "0x175FBFC", VA = "0x175FBFC")]
		private static extern RESULT FMOD5_Channel_SetLoopCount(IntPtr channel, int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x175FCAC", Offset = "0x175FCAC", VA = "0x175FCAC")]
		private static extern RESULT FMOD5_Channel_GetLoopCount(IntPtr channel, out int loopcount);

		[PreserveSig]
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x175FD5C", Offset = "0x175FD5C", VA = "0x175FD5C")]
		private static extern RESULT FMOD5_Channel_SetLoopPoints(IntPtr channel, uint loopstart, TIMEUNIT loopstarttype, uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x175FE2C", Offset = "0x175FE2C", VA = "0x175FE2C")]
		private static extern RESULT FMOD5_Channel_GetLoopPoints(IntPtr channel, out uint loopstart, TIMEUNIT loopstarttype, out uint loopend, TIMEUNIT loopendtype);

		[PreserveSig]
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x175FEFC", Offset = "0x175FEFC", VA = "0x175FEFC")]
		private static extern RESULT FMOD5_Channel_IsVirtual(IntPtr channel, out bool isvirtual);

		[PreserveSig]
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x175FFC0", Offset = "0x175FFC0", VA = "0x175FFC0")]
		private static extern RESULT FMOD5_Channel_GetCurrentSound(IntPtr channel, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x1760070", Offset = "0x1760070", VA = "0x1760070")]
		private static extern RESULT FMOD5_Channel_GetIndex(IntPtr channel, out int index);

		[PreserveSig]
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x1760120", Offset = "0x1760120", VA = "0x1760120")]
		private static extern RESULT FMOD5_Channel_GetSystemObject(IntPtr channel, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x17601D0", Offset = "0x17601D0", VA = "0x17601D0")]
		private static extern RESULT FMOD5_Channel_Stop(IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x1760274", Offset = "0x1760274", VA = "0x1760274")]
		private static extern RESULT FMOD5_Channel_SetPaused(IntPtr channel, bool paused);

		[PreserveSig]
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x1760324", Offset = "0x1760324", VA = "0x1760324")]
		private static extern RESULT FMOD5_Channel_GetPaused(IntPtr channel, out bool paused);

		[PreserveSig]
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x17603E8", Offset = "0x17603E8", VA = "0x17603E8")]
		private static extern RESULT FMOD5_Channel_SetVolume(IntPtr channel, float volume);

		[PreserveSig]
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x1760498", Offset = "0x1760498", VA = "0x1760498")]
		private static extern RESULT FMOD5_Channel_GetVolume(IntPtr channel, out float volume);

		[PreserveSig]
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x176054C", Offset = "0x176054C", VA = "0x176054C")]
		private static extern RESULT FMOD5_Channel_SetVolumeRamp(IntPtr channel, bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x17605FC", Offset = "0x17605FC", VA = "0x17605FC")]
		private static extern RESULT FMOD5_Channel_GetVolumeRamp(IntPtr channel, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x17606C0", Offset = "0x17606C0", VA = "0x17606C0")]
		private static extern RESULT FMOD5_Channel_GetAudibility(IntPtr channel, out float audibility);

		[PreserveSig]
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x1760770", Offset = "0x1760770", VA = "0x1760770")]
		private static extern RESULT FMOD5_Channel_SetPitch(IntPtr channel, float pitch);

		[PreserveSig]
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x1760820", Offset = "0x1760820", VA = "0x1760820")]
		private static extern RESULT FMOD5_Channel_GetPitch(IntPtr channel, out float pitch);

		[PreserveSig]
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x17608D4", Offset = "0x17608D4", VA = "0x17608D4")]
		private static extern RESULT FMOD5_Channel_SetMute(IntPtr channel, bool mute);

		[PreserveSig]
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x1760984", Offset = "0x1760984", VA = "0x1760984")]
		private static extern RESULT FMOD5_Channel_GetMute(IntPtr channel, out bool mute);

		[PreserveSig]
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x1760A48", Offset = "0x1760A48", VA = "0x1760A48")]
		private static extern RESULT FMOD5_Channel_SetReverbProperties(IntPtr channel, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x1760B08", Offset = "0x1760B08", VA = "0x1760B08")]
		private static extern RESULT FMOD5_Channel_GetReverbProperties(IntPtr channel, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x1760BC0", Offset = "0x1760BC0", VA = "0x1760BC0")]
		private static extern RESULT FMOD5_Channel_SetLowPassGain(IntPtr channel, float gain);

		[PreserveSig]
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x1760C70", Offset = "0x1760C70", VA = "0x1760C70")]
		private static extern RESULT FMOD5_Channel_GetLowPassGain(IntPtr channel, out float gain);

		[PreserveSig]
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x1760D20", Offset = "0x1760D20", VA = "0x1760D20")]
		private static extern RESULT FMOD5_Channel_SetMode(IntPtr channel, MODE mode);

		[PreserveSig]
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x1760DD0", Offset = "0x1760DD0", VA = "0x1760DD0")]
		private static extern RESULT FMOD5_Channel_GetMode(IntPtr channel, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x1760E80", Offset = "0x1760E80", VA = "0x1760E80")]
		private static extern RESULT FMOD5_Channel_SetCallback(IntPtr channel, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x1760F38", Offset = "0x1760F38", VA = "0x1760F38")]
		private static extern RESULT FMOD5_Channel_IsPlaying(IntPtr channel, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x1760FFC", Offset = "0x1760FFC", VA = "0x1760FFC")]
		private static extern RESULT FMOD5_Channel_SetPan(IntPtr channel, float pan);

		[PreserveSig]
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x17610AC", Offset = "0x17610AC", VA = "0x17610AC")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsOutput(IntPtr channel, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x17611AC", Offset = "0x17611AC", VA = "0x17611AC")]
		private static extern RESULT FMOD5_Channel_SetMixLevelsInput(IntPtr channel, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x176126C", Offset = "0x176126C", VA = "0x176126C")]
		private static extern RESULT FMOD5_Channel_SetMixMatrix(IntPtr channel, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x1761344", Offset = "0x1761344", VA = "0x1761344")]
		private static extern RESULT FMOD5_Channel_GetMixMatrix(IntPtr channel, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x176141C", Offset = "0x176141C", VA = "0x176141C")]
		private static extern RESULT FMOD5_Channel_GetDSPClock(IntPtr channel, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x17614D8", Offset = "0x17614D8", VA = "0x17614D8")]
		private static extern RESULT FMOD5_Channel_SetDelay(IntPtr channel, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x17615F8", Offset = "0x17615F8", VA = "0x17615F8")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x17616C0", Offset = "0x17616C0", VA = "0x17616C0")]
		private static extern RESULT FMOD5_Channel_GetDelay(IntPtr channel, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x176179C", Offset = "0x176179C", VA = "0x176179C")]
		private static extern RESULT FMOD5_Channel_AddFadePoint(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x176185C", Offset = "0x176185C", VA = "0x176185C")]
		private static extern RESULT FMOD5_Channel_SetFadePointRamp(IntPtr channel, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x176191C", Offset = "0x176191C", VA = "0x176191C")]
		private static extern RESULT FMOD5_Channel_RemoveFadePoints(IntPtr channel, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x17619D4", Offset = "0x17619D4", VA = "0x17619D4")]
		private static extern RESULT FMOD5_Channel_GetFadePoints(IntPtr channel, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x1761AAC", Offset = "0x1761AAC", VA = "0x1761AAC")]
		private static extern RESULT FMOD5_Channel_GetDSP(IntPtr channel, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x1761B60", Offset = "0x1761B60", VA = "0x1761B60")]
		private static extern RESULT FMOD5_Channel_AddDSP(IntPtr channel, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x1761C14", Offset = "0x1761C14", VA = "0x1761C14")]
		private static extern RESULT FMOD5_Channel_RemoveDSP(IntPtr channel, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x1761CC4", Offset = "0x1761CC4", VA = "0x1761CC4")]
		private static extern RESULT FMOD5_Channel_GetNumDSPs(IntPtr channel, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x1761D74", Offset = "0x1761D74", VA = "0x1761D74")]
		private static extern RESULT FMOD5_Channel_SetDSPIndex(IntPtr channel, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x1761E2C", Offset = "0x1761E2C", VA = "0x1761E2C")]
		private static extern RESULT FMOD5_Channel_GetDSPIndex(IntPtr channel, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x1761EE4", Offset = "0x1761EE4", VA = "0x1761EE4")]
		private static extern RESULT FMOD5_Channel_Set3DAttributes(IntPtr channel, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x1761F9C", Offset = "0x1761F9C", VA = "0x1761F9C")]
		private static extern RESULT FMOD5_Channel_Get3DAttributes(IntPtr channel, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x1762054", Offset = "0x1762054", VA = "0x1762054")]
		private static extern RESULT FMOD5_Channel_Set3DMinMaxDistance(IntPtr channel, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x176210C", Offset = "0x176210C", VA = "0x176210C")]
		private static extern RESULT FMOD5_Channel_Get3DMinMaxDistance(IntPtr channel, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x17621C4", Offset = "0x17621C4", VA = "0x17621C4")]
		private static extern RESULT FMOD5_Channel_Set3DConeSettings(IntPtr channel, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x176228C", Offset = "0x176228C", VA = "0x176228C")]
		private static extern RESULT FMOD5_Channel_Get3DConeSettings(IntPtr channel, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x1762354", Offset = "0x1762354", VA = "0x1762354")]
		private static extern RESULT FMOD5_Channel_Set3DConeOrientation(IntPtr channel, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x1762404", Offset = "0x1762404", VA = "0x1762404")]
		private static extern RESULT FMOD5_Channel_Get3DConeOrientation(IntPtr channel, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x17624B4", Offset = "0x17624B4", VA = "0x17624B4")]
		private static extern RESULT FMOD5_Channel_Set3DCustomRolloff(IntPtr channel, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x176256C", Offset = "0x176256C", VA = "0x176256C")]
		private static extern RESULT FMOD5_Channel_Get3DCustomRolloff(IntPtr channel, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x1762624", Offset = "0x1762624", VA = "0x1762624")]
		private static extern RESULT FMOD5_Channel_Set3DOcclusion(IntPtr channel, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x17626DC", Offset = "0x17626DC", VA = "0x17626DC")]
		private static extern RESULT FMOD5_Channel_Get3DOcclusion(IntPtr channel, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x1762794", Offset = "0x1762794", VA = "0x1762794")]
		private static extern RESULT FMOD5_Channel_Set3DSpread(IntPtr channel, float angle);

		[PreserveSig]
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x1762844", Offset = "0x1762844", VA = "0x1762844")]
		private static extern RESULT FMOD5_Channel_Get3DSpread(IntPtr channel, out float angle);

		[PreserveSig]
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x17628F4", Offset = "0x17628F4", VA = "0x17628F4")]
		private static extern RESULT FMOD5_Channel_Set3DLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x17629A4", Offset = "0x17629A4", VA = "0x17629A4")]
		private static extern RESULT FMOD5_Channel_Get3DLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000281")]
		[Address(RVA = "0x1762A54", Offset = "0x1762A54", VA = "0x1762A54")]
		private static extern RESULT FMOD5_Channel_Set3DDopplerLevel(IntPtr channel, float level);

		[PreserveSig]
		[Token(Token = "0x6000282")]
		[Address(RVA = "0x1762B04", Offset = "0x1762B04", VA = "0x1762B04")]
		private static extern RESULT FMOD5_Channel_Get3DDopplerLevel(IntPtr channel, out float level);

		[PreserveSig]
		[Token(Token = "0x6000283")]
		[Address(RVA = "0x1762BB8", Offset = "0x1762BB8", VA = "0x1762BB8")]
		private static extern RESULT FMOD5_Channel_Set3DDistanceFilter(IntPtr channel, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x1762C80", Offset = "0x1762C80", VA = "0x1762C80")]
		private static extern RESULT FMOD5_Channel_Get3DDistanceFilter(IntPtr channel, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x1762D5C", Offset = "0x1762D5C", VA = "0x1762D5C")]
		private static extern RESULT FMOD5_Channel_SetUserData(IntPtr channel, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x1762E0C", Offset = "0x1762E0C", VA = "0x1762E0C")]
		private static extern RESULT FMOD5_Channel_GetUserData(IntPtr channel, out IntPtr userdata);

		[Token(Token = "0x6000287")]
		[Address(RVA = "0x9C5340", Offset = "0x9C5340", VA = "0x9C5340")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000288")]
		[Address(RVA = "0x9C5348", Offset = "0x9C5348", VA = "0x9C5348")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000050")]
	public struct ChannelGroup : IChannelControl
	{
		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000289")]
		[Address(RVA = "0x9C538C", Offset = "0x9C538C", VA = "0x9C538C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0x9C5394", Offset = "0x9C5394", VA = "0x9C5394")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock = true)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028B")]
		[Address(RVA = "0x9C53A0", Offset = "0x9C53A0", VA = "0x9C53A0")]
		public RESULT addGroup(ChannelGroup group, bool propagatedspclock, out DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0x9C53AC", Offset = "0x9C53AC", VA = "0x9C53AC")]
		public RESULT getNumGroups(out int numgroups)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028D")]
		[Address(RVA = "0x9C53B4", Offset = "0x9C53B4", VA = "0x9C53B4")]
		public RESULT getGroup(int index, out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x9C53BC", Offset = "0x9C53BC", VA = "0x9C53BC")]
		public RESULT getParentGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x9C53C4", Offset = "0x9C53C4", VA = "0x9C53C4")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x9C53CC", Offset = "0x9C53CC", VA = "0x9C53CC")]
		public RESULT getNumChannels(out int numchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0x9C53D4", Offset = "0x9C53D4", VA = "0x9C53D4")]
		public RESULT getChannel(int index, out Channel channel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x9C53DC", Offset = "0x9C53DC", VA = "0x9C53DC", Slot = "4")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0x9C53E4", Offset = "0x9C53E4", VA = "0x9C53E4", Slot = "5")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x9C53EC", Offset = "0x9C53EC", VA = "0x9C53EC", Slot = "6")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x9C53F8", Offset = "0x9C53F8", VA = "0x9C53F8", Slot = "7")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x9C5400", Offset = "0x9C5400", VA = "0x9C5400", Slot = "8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x9C5408", Offset = "0x9C5408", VA = "0x9C5408", Slot = "9")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x9C5410", Offset = "0x9C5410", VA = "0x9C5410", Slot = "10")]
		public RESULT setVolumeRamp(bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x9C541C", Offset = "0x9C541C", VA = "0x9C541C", Slot = "11")]
		public RESULT getVolumeRamp(out bool ramp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x9C5424", Offset = "0x9C5424", VA = "0x9C5424", Slot = "12")]
		public RESULT getAudibility(out float audibility)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x9C542C", Offset = "0x9C542C", VA = "0x9C542C", Slot = "13")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x9C5434", Offset = "0x9C5434", VA = "0x9C5434", Slot = "14")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9C543C", Offset = "0x9C543C", VA = "0x9C543C", Slot = "15")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x9C5448", Offset = "0x9C5448", VA = "0x9C5448", Slot = "16")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x9C5450", Offset = "0x9C5450", VA = "0x9C5450", Slot = "17")]
		public RESULT setReverbProperties(int instance, float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x9C5458", Offset = "0x9C5458", VA = "0x9C5458", Slot = "18")]
		public RESULT getReverbProperties(int instance, out float wet)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x9C5460", Offset = "0x9C5460", VA = "0x9C5460", Slot = "19")]
		public RESULT setLowPassGain(float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x9C5468", Offset = "0x9C5468", VA = "0x9C5468", Slot = "20")]
		public RESULT getLowPassGain(out float gain)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x9C5470", Offset = "0x9C5470", VA = "0x9C5470", Slot = "21")]
		public RESULT setMode(MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x9C5478", Offset = "0x9C5478", VA = "0x9C5478", Slot = "22")]
		public RESULT getMode(out MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x9C5480", Offset = "0x9C5480", VA = "0x9C5480", Slot = "23")]
		public RESULT setCallback(CHANNELCONTROL_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x9C5488", Offset = "0x9C5488", VA = "0x9C5488", Slot = "24")]
		public RESULT isPlaying(out bool isplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x9C5490", Offset = "0x9C5490", VA = "0x9C5490", Slot = "25")]
		public RESULT setPan(float pan)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x9C5498", Offset = "0x9C5498", VA = "0x9C5498", Slot = "26")]
		public RESULT setMixLevelsOutput(float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x9C54A0", Offset = "0x9C54A0", VA = "0x9C54A0", Slot = "27")]
		public RESULT setMixLevelsInput(float[] levels, int numlevels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x9C54A8", Offset = "0x9C54A8", VA = "0x9C54A8", Slot = "28")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x9C54B0", Offset = "0x9C54B0", VA = "0x9C54B0", Slot = "29")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x9C54B8", Offset = "0x9C54B8", VA = "0x9C54B8", Slot = "30")]
		public RESULT getDSPClock(out ulong dspclock, out ulong parentclock)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AD")]
		[Address(RVA = "0x9C54C0", Offset = "0x9C54C0", VA = "0x9C54C0", Slot = "31")]
		public RESULT setDelay(ulong dspclock_start, ulong dspclock_end, bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AE")]
		[Address(RVA = "0x9C54CC", Offset = "0x9C54CC", VA = "0x9C54CC", Slot = "32")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002AF")]
		[Address(RVA = "0x9C54D4", Offset = "0x9C54D4", VA = "0x9C54D4", Slot = "33")]
		public RESULT getDelay(out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x9C54DC", Offset = "0x9C54DC", VA = "0x9C54DC", Slot = "34")]
		public RESULT addFadePoint(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x9C54E4", Offset = "0x9C54E4", VA = "0x9C54E4", Slot = "35")]
		public RESULT setFadePointRamp(ulong dspclock, float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x9C54EC", Offset = "0x9C54EC", VA = "0x9C54EC", Slot = "36")]
		public RESULT removeFadePoints(ulong dspclock_start, ulong dspclock_end)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x9C54F4", Offset = "0x9C54F4", VA = "0x9C54F4", Slot = "37")]
		public RESULT getFadePoints(ref uint numpoints, ulong[] point_dspclock, float[] point_volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x9C54FC", Offset = "0x9C54FC", VA = "0x9C54FC", Slot = "38")]
		public RESULT getDSP(int index, out DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x9C5504", Offset = "0x9C5504", VA = "0x9C5504", Slot = "39")]
		public RESULT addDSP(int index, DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B6")]
		[Address(RVA = "0x9C550C", Offset = "0x9C550C", VA = "0x9C550C", Slot = "40")]
		public RESULT removeDSP(DSP dsp)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x9C5514", Offset = "0x9C5514", VA = "0x9C5514", Slot = "41")]
		public RESULT getNumDSPs(out int numdsps)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x9C551C", Offset = "0x9C551C", VA = "0x9C551C", Slot = "42")]
		public RESULT setDSPIndex(DSP dsp, int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x9C5524", Offset = "0x9C5524", VA = "0x9C5524", Slot = "43")]
		public RESULT getDSPIndex(DSP dsp, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BA")]
		[Address(RVA = "0x9C552C", Offset = "0x9C552C", VA = "0x9C552C", Slot = "44")]
		public RESULT set3DAttributes(ref VECTOR pos, ref VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BB")]
		[Address(RVA = "0x9C5534", Offset = "0x9C5534", VA = "0x9C5534", Slot = "45")]
		public RESULT get3DAttributes(out VECTOR pos, out VECTOR vel)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BC")]
		[Address(RVA = "0x9C553C", Offset = "0x9C553C", VA = "0x9C553C", Slot = "46")]
		public RESULT set3DMinMaxDistance(float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x9C5544", Offset = "0x9C5544", VA = "0x9C5544", Slot = "47")]
		public RESULT get3DMinMaxDistance(out float mindistance, out float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BE")]
		[Address(RVA = "0x9C554C", Offset = "0x9C554C", VA = "0x9C554C", Slot = "48")]
		public RESULT set3DConeSettings(float insideconeangle, float outsideconeangle, float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x9C5554", Offset = "0x9C5554", VA = "0x9C5554", Slot = "49")]
		public RESULT get3DConeSettings(out float insideconeangle, out float outsideconeangle, out float outsidevolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x9C555C", Offset = "0x9C555C", VA = "0x9C555C", Slot = "50")]
		public RESULT set3DConeOrientation(ref VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x9C5564", Offset = "0x9C5564", VA = "0x9C5564", Slot = "51")]
		public RESULT get3DConeOrientation(out VECTOR orientation)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x9C556C", Offset = "0x9C556C", VA = "0x9C556C", Slot = "52")]
		public RESULT set3DCustomRolloff(ref VECTOR points, int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C3")]
		[Address(RVA = "0x9C5574", Offset = "0x9C5574", VA = "0x9C5574", Slot = "53")]
		public RESULT get3DCustomRolloff(out IntPtr points, out int numpoints)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x9C557C", Offset = "0x9C557C", VA = "0x9C557C", Slot = "54")]
		public RESULT set3DOcclusion(float directocclusion, float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x9C5584", Offset = "0x9C5584", VA = "0x9C5584", Slot = "55")]
		public RESULT get3DOcclusion(out float directocclusion, out float reverbocclusion)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C6")]
		[Address(RVA = "0x9C558C", Offset = "0x9C558C", VA = "0x9C558C", Slot = "56")]
		public RESULT set3DSpread(float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C7")]
		[Address(RVA = "0x9C5594", Offset = "0x9C5594", VA = "0x9C5594", Slot = "57")]
		public RESULT get3DSpread(out float angle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C8")]
		[Address(RVA = "0x9C559C", Offset = "0x9C559C", VA = "0x9C559C", Slot = "58")]
		public RESULT set3DLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x9C55A4", Offset = "0x9C55A4", VA = "0x9C55A4", Slot = "59")]
		public RESULT get3DLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CA")]
		[Address(RVA = "0x9C55AC", Offset = "0x9C55AC", VA = "0x9C55AC", Slot = "60")]
		public RESULT set3DDopplerLevel(float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CB")]
		[Address(RVA = "0x9C55B4", Offset = "0x9C55B4", VA = "0x9C55B4", Slot = "61")]
		public RESULT get3DDopplerLevel(out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CC")]
		[Address(RVA = "0x9C55BC", Offset = "0x9C55BC", VA = "0x9C55BC", Slot = "62")]
		public RESULT set3DDistanceFilter(bool custom, float customLevel, float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x9C55C8", Offset = "0x9C55C8", VA = "0x9C55C8", Slot = "63")]
		public RESULT get3DDistanceFilter(out bool custom, out float customLevel, out float centerFreq)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x9C55D0", Offset = "0x9C55D0", VA = "0x9C55D0", Slot = "64")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x9C55D8", Offset = "0x9C55D8", VA = "0x9C55D8", Slot = "65")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x1762F4C", Offset = "0x1762F4C", VA = "0x1762F4C")]
		private static extern RESULT FMOD5_ChannelGroup_Release(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x1763044", Offset = "0x1763044", VA = "0x1763044")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x1763110", Offset = "0x1763110", VA = "0x1763110")]
		private static extern RESULT FMOD5_ChannelGroup_AddGroup(IntPtr channelgroup, IntPtr group, bool propagatedspclock, out IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x17631D8", Offset = "0x17631D8", VA = "0x17631D8")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumGroups(IntPtr channelgroup, out int numgroups);

		[PreserveSig]
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x1763288", Offset = "0x1763288", VA = "0x1763288")]
		private static extern RESULT FMOD5_ChannelGroup_GetGroup(IntPtr channelgroup, int index, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x1763340", Offset = "0x1763340", VA = "0x1763340")]
		private static extern RESULT FMOD5_ChannelGroup_GetParentGroup(IntPtr channelgroup, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x17635B4", Offset = "0x17635B4", VA = "0x17635B4")]
		private static extern RESULT FMOD5_ChannelGroup_GetName(IntPtr channelgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x176366C", Offset = "0x176366C", VA = "0x176366C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumChannels(IntPtr channelgroup, out int numchannels);

		[PreserveSig]
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x176371C", Offset = "0x176371C", VA = "0x176371C")]
		private static extern RESULT FMOD5_ChannelGroup_GetChannel(IntPtr channelgroup, int index, out IntPtr channel);

		[PreserveSig]
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x17637D4", Offset = "0x17637D4", VA = "0x17637D4")]
		private static extern RESULT FMOD5_ChannelGroup_GetSystemObject(IntPtr channelgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x1763884", Offset = "0x1763884", VA = "0x1763884")]
		private static extern RESULT FMOD5_ChannelGroup_Stop(IntPtr channelgroup);

		[PreserveSig]
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x1763928", Offset = "0x1763928", VA = "0x1763928")]
		private static extern RESULT FMOD5_ChannelGroup_SetPaused(IntPtr channelgroup, bool paused);

		[PreserveSig]
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x17639D8", Offset = "0x17639D8", VA = "0x17639D8")]
		private static extern RESULT FMOD5_ChannelGroup_GetPaused(IntPtr channelgroup, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x1763A9C", Offset = "0x1763A9C", VA = "0x1763A9C")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolume(IntPtr channelgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x1763B4C", Offset = "0x1763B4C", VA = "0x1763B4C")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolume(IntPtr channelgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x1763C00", Offset = "0x1763C00", VA = "0x1763C00")]
		private static extern RESULT FMOD5_ChannelGroup_SetVolumeRamp(IntPtr channelgroup, bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x1763CB0", Offset = "0x1763CB0", VA = "0x1763CB0")]
		private static extern RESULT FMOD5_ChannelGroup_GetVolumeRamp(IntPtr channelgroup, out bool ramp);

		[PreserveSig]
		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x1763D74", Offset = "0x1763D74", VA = "0x1763D74")]
		private static extern RESULT FMOD5_ChannelGroup_GetAudibility(IntPtr channelgroup, out float audibility);

		[PreserveSig]
		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1763E24", Offset = "0x1763E24", VA = "0x1763E24")]
		private static extern RESULT FMOD5_ChannelGroup_SetPitch(IntPtr channelgroup, float pitch);

		[PreserveSig]
		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1763ED4", Offset = "0x1763ED4", VA = "0x1763ED4")]
		private static extern RESULT FMOD5_ChannelGroup_GetPitch(IntPtr channelgroup, out float pitch);

		[PreserveSig]
		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1763F88", Offset = "0x1763F88", VA = "0x1763F88")]
		private static extern RESULT FMOD5_ChannelGroup_SetMute(IntPtr channelgroup, bool mute);

		[PreserveSig]
		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x1764038", Offset = "0x1764038", VA = "0x1764038")]
		private static extern RESULT FMOD5_ChannelGroup_GetMute(IntPtr channelgroup, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x17640FC", Offset = "0x17640FC", VA = "0x17640FC")]
		private static extern RESULT FMOD5_ChannelGroup_SetReverbProperties(IntPtr channelgroup, int instance, float wet);

		[PreserveSig]
		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x17641BC", Offset = "0x17641BC", VA = "0x17641BC")]
		private static extern RESULT FMOD5_ChannelGroup_GetReverbProperties(IntPtr channelgroup, int instance, out float wet);

		[PreserveSig]
		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1764274", Offset = "0x1764274", VA = "0x1764274")]
		private static extern RESULT FMOD5_ChannelGroup_SetLowPassGain(IntPtr channelgroup, float gain);

		[PreserveSig]
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1764324", Offset = "0x1764324", VA = "0x1764324")]
		private static extern RESULT FMOD5_ChannelGroup_GetLowPassGain(IntPtr channelgroup, out float gain);

		[PreserveSig]
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x17643D4", Offset = "0x17643D4", VA = "0x17643D4")]
		private static extern RESULT FMOD5_ChannelGroup_SetMode(IntPtr channelgroup, MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x1764484", Offset = "0x1764484", VA = "0x1764484")]
		private static extern RESULT FMOD5_ChannelGroup_GetMode(IntPtr channelgroup, out MODE mode);

		[PreserveSig]
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x1764534", Offset = "0x1764534", VA = "0x1764534")]
		private static extern RESULT FMOD5_ChannelGroup_SetCallback(IntPtr channelgroup, CHANNELCONTROL_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x17645EC", Offset = "0x17645EC", VA = "0x17645EC")]
		private static extern RESULT FMOD5_ChannelGroup_IsPlaying(IntPtr channelgroup, out bool isplaying);

		[PreserveSig]
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x17646B0", Offset = "0x17646B0", VA = "0x17646B0")]
		private static extern RESULT FMOD5_ChannelGroup_SetPan(IntPtr channelgroup, float pan);

		[PreserveSig]
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x1764760", Offset = "0x1764760", VA = "0x1764760")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsOutput(IntPtr channelgroup, float frontleft, float frontright, float center, float lfe, float surroundleft, float surroundright, float backleft, float backright);

		[PreserveSig]
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x1764860", Offset = "0x1764860", VA = "0x1764860")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixLevelsInput(IntPtr channelgroup, float[] levels, int numlevels);

		[PreserveSig]
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x1764920", Offset = "0x1764920", VA = "0x1764920")]
		private static extern RESULT FMOD5_ChannelGroup_SetMixMatrix(IntPtr channelgroup, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x17649F8", Offset = "0x17649F8", VA = "0x17649F8")]
		private static extern RESULT FMOD5_ChannelGroup_GetMixMatrix(IntPtr channelgroup, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x1764AD0", Offset = "0x1764AD0", VA = "0x1764AD0")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPClock(IntPtr channelgroup, out ulong dspclock, out ulong parentclock);

		[PreserveSig]
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x1764B8C", Offset = "0x1764B8C", VA = "0x1764B8C")]
		private static extern RESULT FMOD5_ChannelGroup_SetDelay(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end, bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x1764CAC", Offset = "0x1764CAC", VA = "0x1764CAC")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x1764D74", Offset = "0x1764D74", VA = "0x1764D74")]
		private static extern RESULT FMOD5_ChannelGroup_GetDelay(IntPtr channelgroup, out ulong dspclock_start, out ulong dspclock_end, out bool stopchannels);

		[PreserveSig]
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x1764E50", Offset = "0x1764E50", VA = "0x1764E50")]
		private static extern RESULT FMOD5_ChannelGroup_AddFadePoint(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x1764F10", Offset = "0x1764F10", VA = "0x1764F10")]
		private static extern RESULT FMOD5_ChannelGroup_SetFadePointRamp(IntPtr channelgroup, ulong dspclock, float volume);

		[PreserveSig]
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x1764FD0", Offset = "0x1764FD0", VA = "0x1764FD0")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveFadePoints(IntPtr channelgroup, ulong dspclock_start, ulong dspclock_end);

		[PreserveSig]
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x1765088", Offset = "0x1765088", VA = "0x1765088")]
		private static extern RESULT FMOD5_ChannelGroup_GetFadePoints(IntPtr channelgroup, ref uint numpoints, ulong[] point_dspclock, float[] point_volume);

		[PreserveSig]
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x176515C", Offset = "0x176515C", VA = "0x176515C")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSP(IntPtr channelgroup, int index, out IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x1765214", Offset = "0x1765214", VA = "0x1765214")]
		private static extern RESULT FMOD5_ChannelGroup_AddDSP(IntPtr channelgroup, int index, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x17652CC", Offset = "0x17652CC", VA = "0x17652CC")]
		private static extern RESULT FMOD5_ChannelGroup_RemoveDSP(IntPtr channelgroup, IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x176537C", Offset = "0x176537C", VA = "0x176537C")]
		private static extern RESULT FMOD5_ChannelGroup_GetNumDSPs(IntPtr channelgroup, out int numdsps);

		[PreserveSig]
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x176542C", Offset = "0x176542C", VA = "0x176542C")]
		private static extern RESULT FMOD5_ChannelGroup_SetDSPIndex(IntPtr channelgroup, IntPtr dsp, int index);

		[PreserveSig]
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x17654E4", Offset = "0x17654E4", VA = "0x17654E4")]
		private static extern RESULT FMOD5_ChannelGroup_GetDSPIndex(IntPtr channelgroup, IntPtr dsp, out int index);

		[PreserveSig]
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x176559C", Offset = "0x176559C", VA = "0x176559C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DAttributes(IntPtr channelgroup, ref VECTOR pos, ref VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x1765654", Offset = "0x1765654", VA = "0x1765654")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DAttributes(IntPtr channelgroup, out VECTOR pos, out VECTOR vel);

		[PreserveSig]
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x176570C", Offset = "0x176570C", VA = "0x176570C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DMinMaxDistance(IntPtr channelgroup, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x17657C4", Offset = "0x17657C4", VA = "0x17657C4")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DMinMaxDistance(IntPtr channelgroup, out float mindistance, out float maxdistance);

		[PreserveSig]
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x176587C", Offset = "0x176587C", VA = "0x176587C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeSettings(IntPtr channelgroup, float insideconeangle, float outsideconeangle, float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x1765944", Offset = "0x1765944", VA = "0x1765944")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeSettings(IntPtr channelgroup, out float insideconeangle, out float outsideconeangle, out float outsidevolume);

		[PreserveSig]
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x1765A0C", Offset = "0x1765A0C", VA = "0x1765A0C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DConeOrientation(IntPtr channelgroup, ref VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x1765ABC", Offset = "0x1765ABC", VA = "0x1765ABC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DConeOrientation(IntPtr channelgroup, out VECTOR orientation);

		[PreserveSig]
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x1765B6C", Offset = "0x1765B6C", VA = "0x1765B6C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DCustomRolloff(IntPtr channelgroup, ref VECTOR points, int numpoints);

		[PreserveSig]
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x1765C24", Offset = "0x1765C24", VA = "0x1765C24")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DCustomRolloff(IntPtr channelgroup, out IntPtr points, out int numpoints);

		[PreserveSig]
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x1765CDC", Offset = "0x1765CDC", VA = "0x1765CDC")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DOcclusion(IntPtr channelgroup, float directocclusion, float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x1765D94", Offset = "0x1765D94", VA = "0x1765D94")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DOcclusion(IntPtr channelgroup, out float directocclusion, out float reverbocclusion);

		[PreserveSig]
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x1765E4C", Offset = "0x1765E4C", VA = "0x1765E4C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DSpread(IntPtr channelgroup, float angle);

		[PreserveSig]
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x1765EFC", Offset = "0x1765EFC", VA = "0x1765EFC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DSpread(IntPtr channelgroup, out float angle);

		[PreserveSig]
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x1765FAC", Offset = "0x1765FAC", VA = "0x1765FAC")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x176605C", Offset = "0x176605C", VA = "0x176605C")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x176610C", Offset = "0x176610C", VA = "0x176610C")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDopplerLevel(IntPtr channelgroup, float level);

		[PreserveSig]
		[Token(Token = "0x6000312")]
		[Address(RVA = "0x17661BC", Offset = "0x17661BC", VA = "0x17661BC")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDopplerLevel(IntPtr channelgroup, out float level);

		[PreserveSig]
		[Token(Token = "0x6000313")]
		[Address(RVA = "0x1766270", Offset = "0x1766270", VA = "0x1766270")]
		private static extern RESULT FMOD5_ChannelGroup_Set3DDistanceFilter(IntPtr channelgroup, bool custom, float customLevel, float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000314")]
		[Address(RVA = "0x1766338", Offset = "0x1766338", VA = "0x1766338")]
		private static extern RESULT FMOD5_ChannelGroup_Get3DDistanceFilter(IntPtr channelgroup, out bool custom, out float customLevel, out float centerFreq);

		[PreserveSig]
		[Token(Token = "0x6000315")]
		[Address(RVA = "0x1766414", Offset = "0x1766414", VA = "0x1766414")]
		private static extern RESULT FMOD5_ChannelGroup_SetUserData(IntPtr channelgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000316")]
		[Address(RVA = "0x17664C4", Offset = "0x17664C4", VA = "0x17664C4")]
		private static extern RESULT FMOD5_ChannelGroup_GetUserData(IntPtr channelgroup, out IntPtr userdata);

		[Token(Token = "0x6000317")]
		[Address(RVA = "0x9C55E0", Offset = "0x9C55E0", VA = "0x9C55E0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000318")]
		[Address(RVA = "0x9C55E8", Offset = "0x9C55E8", VA = "0x9C55E8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000051")]
	public struct SoundGroup
	{
		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000319")]
		[Address(RVA = "0x9ADE18", Offset = "0x9ADE18", VA = "0x9ADE18")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031A")]
		[Address(RVA = "0x9ADE20", Offset = "0x9ADE20", VA = "0x9ADE20")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031B")]
		[Address(RVA = "0x9ADE28", Offset = "0x9ADE28", VA = "0x9ADE28")]
		public RESULT setMaxAudible(int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031C")]
		[Address(RVA = "0x9ADE30", Offset = "0x9ADE30", VA = "0x9ADE30")]
		public RESULT getMaxAudible(out int maxaudible)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031D")]
		[Address(RVA = "0x9ADE38", Offset = "0x9ADE38", VA = "0x9ADE38")]
		public RESULT setMaxAudibleBehavior(SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031E")]
		[Address(RVA = "0x9ADE40", Offset = "0x9ADE40", VA = "0x9ADE40")]
		public RESULT getMaxAudibleBehavior(out SOUNDGROUP_BEHAVIOR behavior)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600031F")]
		[Address(RVA = "0x9ADE48", Offset = "0x9ADE48", VA = "0x9ADE48")]
		public RESULT setMuteFadeSpeed(float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000320")]
		[Address(RVA = "0x9ADE50", Offset = "0x9ADE50", VA = "0x9ADE50")]
		public RESULT getMuteFadeSpeed(out float speed)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000321")]
		[Address(RVA = "0x9ADE58", Offset = "0x9ADE58", VA = "0x9ADE58")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000322")]
		[Address(RVA = "0x9ADE60", Offset = "0x9ADE60", VA = "0x9ADE60")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000323")]
		[Address(RVA = "0x9ADE68", Offset = "0x9ADE68", VA = "0x9ADE68")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000324")]
		[Address(RVA = "0x9ADE70", Offset = "0x9ADE70", VA = "0x9ADE70")]
		public RESULT getName(out string name, int namelen)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000325")]
		[Address(RVA = "0x9ADE78", Offset = "0x9ADE78", VA = "0x9ADE78")]
		public RESULT getNumSounds(out int numsounds)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000326")]
		[Address(RVA = "0x9ADE80", Offset = "0x9ADE80", VA = "0x9ADE80")]
		public RESULT getSound(int index, out Sound sound)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x9ADE88", Offset = "0x9ADE88", VA = "0x9ADE88")]
		public RESULT getNumPlaying(out int numplaying)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x9ADE90", Offset = "0x9ADE90", VA = "0x9ADE90")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x9ADE98", Offset = "0x9ADE98", VA = "0x9ADE98")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600032A")]
		[Address(RVA = "0x11F3FC8", Offset = "0x11F3FC8", VA = "0x11F3FC8")]
		private static extern RESULT FMOD5_SoundGroup_Release(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x600032B")]
		[Address(RVA = "0x11F4068", Offset = "0x11F4068", VA = "0x11F4068")]
		private static extern RESULT FMOD5_SoundGroup_GetSystemObject(IntPtr soundgroup, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600032C")]
		[Address(RVA = "0x11F4118", Offset = "0x11F4118", VA = "0x11F4118")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudible(IntPtr soundgroup, int maxaudible);

		[PreserveSig]
		[Token(Token = "0x600032D")]
		[Address(RVA = "0x11F41C8", Offset = "0x11F41C8", VA = "0x11F41C8")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudible(IntPtr soundgroup, out int maxaudible);

		[PreserveSig]
		[Token(Token = "0x600032E")]
		[Address(RVA = "0x11F4278", Offset = "0x11F4278", VA = "0x11F4278")]
		private static extern RESULT FMOD5_SoundGroup_SetMaxAudibleBehavior(IntPtr soundgroup, SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x600032F")]
		[Address(RVA = "0x11F4328", Offset = "0x11F4328", VA = "0x11F4328")]
		private static extern RESULT FMOD5_SoundGroup_GetMaxAudibleBehavior(IntPtr soundgroup, out SOUNDGROUP_BEHAVIOR behavior);

		[PreserveSig]
		[Token(Token = "0x6000330")]
		[Address(RVA = "0x11F43D8", Offset = "0x11F43D8", VA = "0x11F43D8")]
		private static extern RESULT FMOD5_SoundGroup_SetMuteFadeSpeed(IntPtr soundgroup, float speed);

		[PreserveSig]
		[Token(Token = "0x6000331")]
		[Address(RVA = "0x11F4488", Offset = "0x11F4488", VA = "0x11F4488")]
		private static extern RESULT FMOD5_SoundGroup_GetMuteFadeSpeed(IntPtr soundgroup, out float speed);

		[PreserveSig]
		[Token(Token = "0x6000332")]
		[Address(RVA = "0x11F4538", Offset = "0x11F4538", VA = "0x11F4538")]
		private static extern RESULT FMOD5_SoundGroup_SetVolume(IntPtr soundgroup, float volume);

		[PreserveSig]
		[Token(Token = "0x6000333")]
		[Address(RVA = "0x11F45E8", Offset = "0x11F45E8", VA = "0x11F45E8")]
		private static extern RESULT FMOD5_SoundGroup_GetVolume(IntPtr soundgroup, out float volume);

		[PreserveSig]
		[Token(Token = "0x6000334")]
		[Address(RVA = "0x11F4698", Offset = "0x11F4698", VA = "0x11F4698")]
		private static extern RESULT FMOD5_SoundGroup_Stop(IntPtr soundgroup);

		[PreserveSig]
		[Token(Token = "0x6000335")]
		[Address(RVA = "0x11F48F4", Offset = "0x11F48F4", VA = "0x11F48F4")]
		private static extern RESULT FMOD5_SoundGroup_GetName(IntPtr soundgroup, IntPtr name, int namelen);

		[PreserveSig]
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x11F49AC", Offset = "0x11F49AC", VA = "0x11F49AC")]
		private static extern RESULT FMOD5_SoundGroup_GetNumSounds(IntPtr soundgroup, out int numsounds);

		[PreserveSig]
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x11F4A5C", Offset = "0x11F4A5C", VA = "0x11F4A5C")]
		private static extern RESULT FMOD5_SoundGroup_GetSound(IntPtr soundgroup, int index, out IntPtr sound);

		[PreserveSig]
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x11F4B14", Offset = "0x11F4B14", VA = "0x11F4B14")]
		private static extern RESULT FMOD5_SoundGroup_GetNumPlaying(IntPtr soundgroup, out int numplaying);

		[PreserveSig]
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x11F4BC4", Offset = "0x11F4BC4", VA = "0x11F4BC4")]
		private static extern RESULT FMOD5_SoundGroup_SetUserData(IntPtr soundgroup, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x11F4C74", Offset = "0x11F4C74", VA = "0x11F4C74")]
		private static extern RESULT FMOD5_SoundGroup_GetUserData(IntPtr soundgroup, out IntPtr userdata);

		[Token(Token = "0x600033B")]
		[Address(RVA = "0x9ADEA0", Offset = "0x9ADEA0", VA = "0x9ADEA0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600033C")]
		[Address(RVA = "0x9ADEA8", Offset = "0x9ADEA8", VA = "0x9ADEA8")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000052")]
	public struct DSP
	{
		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600033D")]
		[Address(RVA = "0x9C564C", Offset = "0x9C564C", VA = "0x9C564C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033E")]
		[Address(RVA = "0x9C5654", Offset = "0x9C5654", VA = "0x9C5654")]
		public RESULT getSystemObject(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600033F")]
		[Address(RVA = "0x9C565C", Offset = "0x9C565C", VA = "0x9C565C")]
		public RESULT addInput(DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000340")]
		[Address(RVA = "0x9C5664", Offset = "0x9C5664", VA = "0x9C5664")]
		public RESULT addInput(DSP input, out DSPConnection connection, DSPCONNECTION_TYPE type = DSPCONNECTION_TYPE.STANDARD)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000341")]
		[Address(RVA = "0x9C566C", Offset = "0x9C566C", VA = "0x9C566C")]
		public RESULT disconnectFrom(DSP target, DSPConnection connection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000342")]
		[Address(RVA = "0x9C5674", Offset = "0x9C5674", VA = "0x9C5674")]
		public RESULT disconnectAll(bool inputs, bool outputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000343")]
		[Address(RVA = "0x9C5684", Offset = "0x9C5684", VA = "0x9C5684")]
		public RESULT getNumInputs(out int numinputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000344")]
		[Address(RVA = "0x9C568C", Offset = "0x9C568C", VA = "0x9C568C")]
		public RESULT getNumOutputs(out int numoutputs)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000345")]
		[Address(RVA = "0x9C5694", Offset = "0x9C5694", VA = "0x9C5694")]
		public RESULT getInput(int index, out DSP input, out DSPConnection inputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000346")]
		[Address(RVA = "0x9C569C", Offset = "0x9C569C", VA = "0x9C569C")]
		public RESULT getOutput(int index, out DSP output, out DSPConnection outputconnection)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000347")]
		[Address(RVA = "0x9C56A4", Offset = "0x9C56A4", VA = "0x9C56A4")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000348")]
		[Address(RVA = "0x9C56B0", Offset = "0x9C56B0", VA = "0x9C56B0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000349")]
		[Address(RVA = "0x9C56B8", Offset = "0x9C56B8", VA = "0x9C56B8")]
		public RESULT setBypass(bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034A")]
		[Address(RVA = "0x9C56C4", Offset = "0x9C56C4", VA = "0x9C56C4")]
		public RESULT getBypass(out bool bypass)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034B")]
		[Address(RVA = "0x9C56CC", Offset = "0x9C56CC", VA = "0x9C56CC")]
		public RESULT setWetDryMix(float prewet, float postwet, float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034C")]
		[Address(RVA = "0x9C56D4", Offset = "0x9C56D4", VA = "0x9C56D4")]
		public RESULT getWetDryMix(out float prewet, out float postwet, out float dry)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034D")]
		[Address(RVA = "0x9C56DC", Offset = "0x9C56DC", VA = "0x9C56DC")]
		public RESULT setChannelFormat(CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034E")]
		[Address(RVA = "0x9C56E4", Offset = "0x9C56E4", VA = "0x9C56E4")]
		public RESULT getChannelFormat(out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x9C56EC", Offset = "0x9C56EC", VA = "0x9C56EC")]
		public RESULT getOutputChannelFormat(CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x9C56F4", Offset = "0x9C56F4", VA = "0x9C56F4")]
		public RESULT reset()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x9C56FC", Offset = "0x9C56FC", VA = "0x9C56FC")]
		public RESULT setParameterFloat(int index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x9C5704", Offset = "0x9C5704", VA = "0x9C5704")]
		public RESULT setParameterInt(int index, int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x9C570C", Offset = "0x9C570C", VA = "0x9C570C")]
		public RESULT setParameterBool(int index, bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x9C5718", Offset = "0x9C5718", VA = "0x9C5718")]
		public RESULT setParameterData(int index, byte[] data)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000355")]
		[Address(RVA = "0x9C5720", Offset = "0x9C5720", VA = "0x9C5720")]
		public RESULT getParameterFloat(int index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x9C5728", Offset = "0x9C5728", VA = "0x9C5728")]
		public RESULT getParameterInt(int index, out int value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000357")]
		[Address(RVA = "0x9C5730", Offset = "0x9C5730", VA = "0x9C5730")]
		public RESULT getParameterBool(int index, out bool value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x9C5738", Offset = "0x9C5738", VA = "0x9C5738")]
		public RESULT getParameterData(int index, out IntPtr data, out uint length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x9C5740", Offset = "0x9C5740", VA = "0x9C5740")]
		public RESULT getNumParameters(out int numparams)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x9C5748", Offset = "0x9C5748", VA = "0x9C5748")]
		public RESULT getParameterInfo(int index, out DSP_PARAMETER_DESC desc)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035B")]
		[Address(RVA = "0x9C5750", Offset = "0x9C5750", VA = "0x9C5750")]
		public RESULT getDataParameterIndex(int datatype, out int index)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x9C5758", Offset = "0x9C5758", VA = "0x9C5758")]
		public RESULT showConfigDialog(IntPtr hwnd, bool show)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035D")]
		[Address(RVA = "0x9C5764", Offset = "0x9C5764", VA = "0x9C5764")]
		public RESULT getInfo(out string name, out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x9C576C", Offset = "0x9C576C", VA = "0x9C576C")]
		public RESULT getInfo(out uint version, out int channels, out int configwidth, out int configheight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x9C5774", Offset = "0x9C5774", VA = "0x9C5774")]
		public RESULT getType(out DSP_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x9C577C", Offset = "0x9C577C", VA = "0x9C577C")]
		public RESULT getIdle(out bool idle)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000361")]
		[Address(RVA = "0x9C5784", Offset = "0x9C5784", VA = "0x9C5784")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x9C578C", Offset = "0x9C578C", VA = "0x9C578C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000363")]
		[Address(RVA = "0x9C5794", Offset = "0x9C5794", VA = "0x9C5794")]
		public RESULT setMeteringEnabled(bool inputEnabled, bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x9C57A4", Offset = "0x9C57A4", VA = "0x9C57A4")]
		public RESULT getMeteringEnabled(out bool inputEnabled, out bool outputEnabled)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x9C57AC", Offset = "0x9C57AC", VA = "0x9C57AC")]
		public RESULT getMeteringInfo(IntPtr zero, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x9C57B4", Offset = "0x9C57B4", VA = "0x9C57B4")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, IntPtr zero)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000367")]
		[Address(RVA = "0x9C57BC", Offset = "0x9C57BC", VA = "0x9C57BC")]
		public RESULT getMeteringInfo(out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x9C57C4", Offset = "0x9C57C4", VA = "0x9C57C4")]
		public RESULT getCPUUsage(out uint exclusive, out uint inclusive)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x17669E8", Offset = "0x17669E8", VA = "0x17669E8")]
		private static extern RESULT FMOD5_DSP_Release(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1766A88", Offset = "0x1766A88", VA = "0x1766A88")]
		private static extern RESULT FMOD5_DSP_GetSystemObject(IntPtr dsp, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x1766B8C", Offset = "0x1766B8C", VA = "0x1766B8C")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, IntPtr zero, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600036C")]
		[Address(RVA = "0x1766C54", Offset = "0x1766C54", VA = "0x1766C54")]
		private static extern RESULT FMOD5_DSP_AddInput(IntPtr dsp, IntPtr input, out IntPtr connection, DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600036D")]
		[Address(RVA = "0x1766D1C", Offset = "0x1766D1C", VA = "0x1766D1C")]
		private static extern RESULT FMOD5_DSP_DisconnectFrom(IntPtr dsp, IntPtr target, IntPtr connection);

		[PreserveSig]
		[Token(Token = "0x600036E")]
		[Address(RVA = "0x1766DD8", Offset = "0x1766DD8", VA = "0x1766DD8")]
		private static extern RESULT FMOD5_DSP_DisconnectAll(IntPtr dsp, bool inputs, bool outputs);

		[PreserveSig]
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x1766E90", Offset = "0x1766E90", VA = "0x1766E90")]
		private static extern RESULT FMOD5_DSP_GetNumInputs(IntPtr dsp, out int numinputs);

		[PreserveSig]
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x1766F40", Offset = "0x1766F40", VA = "0x1766F40")]
		private static extern RESULT FMOD5_DSP_GetNumOutputs(IntPtr dsp, out int numoutputs);

		[PreserveSig]
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x1766FF0", Offset = "0x1766FF0", VA = "0x1766FF0")]
		private static extern RESULT FMOD5_DSP_GetInput(IntPtr dsp, int index, out IntPtr input, out IntPtr inputconnection);

		[PreserveSig]
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x17670B8", Offset = "0x17670B8", VA = "0x17670B8")]
		private static extern RESULT FMOD5_DSP_GetOutput(IntPtr dsp, int index, out IntPtr output, out IntPtr outputconnection);

		[PreserveSig]
		[Token(Token = "0x6000373")]
		[Address(RVA = "0x1767184", Offset = "0x1767184", VA = "0x1767184")]
		private static extern RESULT FMOD5_DSP_SetActive(IntPtr dsp, bool active);

		[PreserveSig]
		[Token(Token = "0x6000374")]
		[Address(RVA = "0x1767234", Offset = "0x1767234", VA = "0x1767234")]
		private static extern RESULT FMOD5_DSP_GetActive(IntPtr dsp, out bool active);

		[PreserveSig]
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x17672FC", Offset = "0x17672FC", VA = "0x17672FC")]
		private static extern RESULT FMOD5_DSP_SetBypass(IntPtr dsp, bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x17673AC", Offset = "0x17673AC", VA = "0x17673AC")]
		private static extern RESULT FMOD5_DSP_GetBypass(IntPtr dsp, out bool bypass);

		[PreserveSig]
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x1767470", Offset = "0x1767470", VA = "0x1767470")]
		private static extern RESULT FMOD5_DSP_SetWetDryMix(IntPtr dsp, float prewet, float postwet, float dry);

		[PreserveSig]
		[Token(Token = "0x6000378")]
		[Address(RVA = "0x1767538", Offset = "0x1767538", VA = "0x1767538")]
		private static extern RESULT FMOD5_DSP_GetWetDryMix(IntPtr dsp, out float prewet, out float postwet, out float dry);

		[PreserveSig]
		[Token(Token = "0x6000379")]
		[Address(RVA = "0x1767600", Offset = "0x1767600", VA = "0x1767600")]
		private static extern RESULT FMOD5_DSP_SetChannelFormat(IntPtr dsp, CHANNELMASK channelmask, int numchannels, SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x17676C8", Offset = "0x17676C8", VA = "0x17676C8")]
		private static extern RESULT FMOD5_DSP_GetChannelFormat(IntPtr dsp, out CHANNELMASK channelmask, out int numchannels, out SPEAKERMODE source_speakermode);

		[PreserveSig]
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x1767790", Offset = "0x1767790", VA = "0x1767790")]
		private static extern RESULT FMOD5_DSP_GetOutputChannelFormat(IntPtr dsp, CHANNELMASK inmask, int inchannels, SPEAKERMODE inspeakermode, out CHANNELMASK outmask, out int outchannels, out SPEAKERMODE outspeakermode);

		[PreserveSig]
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x1767878", Offset = "0x1767878", VA = "0x1767878")]
		private static extern RESULT FMOD5_DSP_Reset(IntPtr dsp);

		[PreserveSig]
		[Token(Token = "0x600037D")]
		[Address(RVA = "0x1767918", Offset = "0x1767918", VA = "0x1767918")]
		private static extern RESULT FMOD5_DSP_SetParameterFloat(IntPtr dsp, int index, float value);

		[PreserveSig]
		[Token(Token = "0x600037E")]
		[Address(RVA = "0x17679D8", Offset = "0x17679D8", VA = "0x17679D8")]
		private static extern RESULT FMOD5_DSP_SetParameterInt(IntPtr dsp, int index, int value);

		[PreserveSig]
		[Token(Token = "0x600037F")]
		[Address(RVA = "0x1767A94", Offset = "0x1767A94", VA = "0x1767A94")]
		private static extern RESULT FMOD5_DSP_SetParameterBool(IntPtr dsp, int index, bool value);

		[PreserveSig]
		[Token(Token = "0x6000380")]
		[Address(RVA = "0x1767BEC", Offset = "0x1767BEC", VA = "0x1767BEC")]
		private static extern RESULT FMOD5_DSP_SetParameterData(IntPtr dsp, int index, IntPtr data, uint length);

		[PreserveSig]
		[Token(Token = "0x6000381")]
		[Address(RVA = "0x1767D10", Offset = "0x1767D10", VA = "0x1767D10")]
		private static extern RESULT FMOD5_DSP_GetParameterFloat(IntPtr dsp, int index, out float value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000382")]
		[Address(RVA = "0x1767E3C", Offset = "0x1767E3C", VA = "0x1767E3C")]
		private static extern RESULT FMOD5_DSP_GetParameterInt(IntPtr dsp, int index, out int value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000383")]
		[Address(RVA = "0x1767F68", Offset = "0x1767F68", VA = "0x1767F68")]
		private static extern RESULT FMOD5_DSP_GetParameterBool(IntPtr dsp, int index, out bool value, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000384")]
		[Address(RVA = "0x17680B8", Offset = "0x17680B8", VA = "0x17680B8")]
		private static extern RESULT FMOD5_DSP_GetParameterData(IntPtr dsp, int index, out IntPtr data, out uint length, IntPtr valuestr, int valuestrlen);

		[PreserveSig]
		[Token(Token = "0x6000385")]
		[Address(RVA = "0x1768198", Offset = "0x1768198", VA = "0x1768198")]
		private static extern RESULT FMOD5_DSP_GetNumParameters(IntPtr dsp, out int numparams);

		[PreserveSig]
		[Token(Token = "0x6000386")]
		[Address(RVA = "0x1768248", Offset = "0x1768248", VA = "0x1768248")]
		private static extern RESULT FMOD5_DSP_GetParameterInfo(IntPtr dsp, int index, out DSP_PARAMETER_DESC desc);

		[PreserveSig]
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x1768354", Offset = "0x1768354", VA = "0x1768354")]
		private static extern RESULT FMOD5_DSP_GetDataParameterIndex(IntPtr dsp, int datatype, out int index);

		[PreserveSig]
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1768410", Offset = "0x1768410", VA = "0x1768410")]
		private static extern RESULT FMOD5_DSP_ShowConfigDialog(IntPtr dsp, IntPtr hwnd, bool show);

		[PreserveSig]
		[Token(Token = "0x6000389")]
		[Address(RVA = "0x17686A4", Offset = "0x17686A4", VA = "0x17686A4")]
		private static extern RESULT FMOD5_DSP_GetInfo(IntPtr dsp, IntPtr name, out uint version, out int channels, out int configwidth, out int configheight);

		[PreserveSig]
		[Token(Token = "0x600038A")]
		[Address(RVA = "0x17687FC", Offset = "0x17687FC", VA = "0x17687FC")]
		private static extern RESULT FMOD5_DSP_GetType(IntPtr dsp, out DSP_TYPE type);

		[PreserveSig]
		[Token(Token = "0x600038B")]
		[Address(RVA = "0x17688AC", Offset = "0x17688AC", VA = "0x17688AC")]
		private static extern RESULT FMOD5_DSP_GetIdle(IntPtr dsp, out bool idle);

		[PreserveSig]
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x1768970", Offset = "0x1768970", VA = "0x1768970")]
		private static extern RESULT FMOD5_DSP_SetUserData(IntPtr dsp, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x1768A20", Offset = "0x1768A20", VA = "0x1768A20")]
		private static extern RESULT FMOD5_DSP_GetUserData(IntPtr dsp, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x600038E")]
		[Address(RVA = "0x1768AD8", Offset = "0x1768AD8", VA = "0x1768AD8")]
		public static extern RESULT FMOD5_DSP_SetMeteringEnabled(IntPtr dsp, bool inputEnabled, bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x600038F")]
		[Address(RVA = "0x1768B90", Offset = "0x1768B90", VA = "0x1768B90")]
		public static extern RESULT FMOD5_DSP_GetMeteringEnabled(IntPtr dsp, out bool inputEnabled, out bool outputEnabled);

		[PreserveSig]
		[Token(Token = "0x6000390")]
		[Address(RVA = "0x1768C6C", Offset = "0x1768C6C", VA = "0x1768C6C")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, IntPtr zero, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000391")]
		[Address(RVA = "0x1768D6C", Offset = "0x1768D6C", VA = "0x1768D6C")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, IntPtr zero);

		[PreserveSig]
		[Token(Token = "0x6000392")]
		[Address(RVA = "0x1768E6C", Offset = "0x1768E6C", VA = "0x1768E6C")]
		public static extern RESULT FMOD5_DSP_GetMeteringInfo(IntPtr dsp, out DSP_METERING_INFO inputInfo, out DSP_METERING_INFO outputInfo);

		[PreserveSig]
		[Token(Token = "0x6000393")]
		[Address(RVA = "0x1768F9C", Offset = "0x1768F9C", VA = "0x1768F9C")]
		public static extern RESULT FMOD5_DSP_GetCPUUsage(IntPtr dsp, out uint exclusive, out uint inclusive);

		[Token(Token = "0x6000394")]
		[Address(RVA = "0x9C59E8", Offset = "0x9C59E8", VA = "0x9C59E8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x9C59F0", Offset = "0x9C59F0", VA = "0x9C59F0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000053")]
	public struct DSPConnection
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x9C5A34", Offset = "0x9C5A34", VA = "0x9C5A34")]
		public RESULT getInput(out DSP input)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x9C5A3C", Offset = "0x9C5A3C", VA = "0x9C5A3C")]
		public RESULT getOutput(out DSP output)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x9C5A44", Offset = "0x9C5A44", VA = "0x9C5A44")]
		public RESULT setMix(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x9C5A4C", Offset = "0x9C5A4C", VA = "0x9C5A4C")]
		public RESULT getMix(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x9C5A54", Offset = "0x9C5A54", VA = "0x9C5A54")]
		public RESULT setMixMatrix(float[] matrix, int outchannels, int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x9C5A5C", Offset = "0x9C5A5C", VA = "0x9C5A5C")]
		public RESULT getMixMatrix(float[] matrix, out int outchannels, out int inchannels, int inchannel_hop = 0)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x9C5A64", Offset = "0x9C5A64", VA = "0x9C5A64")]
		public RESULT getType(out DSPCONNECTION_TYPE type)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x9C5A6C", Offset = "0x9C5A6C", VA = "0x9C5A6C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x9C5A74", Offset = "0x9C5A74", VA = "0x9C5A74")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600039F")]
		[Address(RVA = "0x17690E4", Offset = "0x17690E4", VA = "0x17690E4")]
		private static extern RESULT FMOD5_DSPConnection_GetInput(IntPtr dspconnection, out IntPtr input);

		[PreserveSig]
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1769194", Offset = "0x1769194", VA = "0x1769194")]
		private static extern RESULT FMOD5_DSPConnection_GetOutput(IntPtr dspconnection, out IntPtr output);

		[PreserveSig]
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1769244", Offset = "0x1769244", VA = "0x1769244")]
		private static extern RESULT FMOD5_DSPConnection_SetMix(IntPtr dspconnection, float volume);

		[PreserveSig]
		[Token(Token = "0x60003A2")]
		[Address(RVA = "0x17692F4", Offset = "0x17692F4", VA = "0x17692F4")]
		private static extern RESULT FMOD5_DSPConnection_GetMix(IntPtr dspconnection, out float volume);

		[PreserveSig]
		[Token(Token = "0x60003A3")]
		[Address(RVA = "0x17693A4", Offset = "0x17693A4", VA = "0x17693A4")]
		private static extern RESULT FMOD5_DSPConnection_SetMixMatrix(IntPtr dspconnection, float[] matrix, int outchannels, int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60003A4")]
		[Address(RVA = "0x176947C", Offset = "0x176947C", VA = "0x176947C")]
		private static extern RESULT FMOD5_DSPConnection_GetMixMatrix(IntPtr dspconnection, float[] matrix, out int outchannels, out int inchannels, int inchannel_hop);

		[PreserveSig]
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x1769554", Offset = "0x1769554", VA = "0x1769554")]
		private static extern RESULT FMOD5_DSPConnection_GetType(IntPtr dspconnection, out DSPCONNECTION_TYPE type);

		[PreserveSig]
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x1769604", Offset = "0x1769604", VA = "0x1769604")]
		private static extern RESULT FMOD5_DSPConnection_SetUserData(IntPtr dspconnection, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x17696B4", Offset = "0x17696B4", VA = "0x17696B4")]
		private static extern RESULT FMOD5_DSPConnection_GetUserData(IntPtr dspconnection, out IntPtr userdata);

		[Token(Token = "0x60003A8")]
		[Address(RVA = "0x9C5A7C", Offset = "0x9C5A7C", VA = "0x9C5A7C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003A9")]
		[Address(RVA = "0x9C5A84", Offset = "0x9C5A84", VA = "0x9C5A84")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000054")]
	public struct Geometry
	{
		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x9AD9FC", Offset = "0x9AD9FC", VA = "0x9AD9FC")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x9ADA04", Offset = "0x9ADA04", VA = "0x9ADA04")]
		public RESULT addPolygon(float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x9ADA10", Offset = "0x9ADA10", VA = "0x9ADA10")]
		public RESULT getNumPolygons(out int numpolygons)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x9ADA18", Offset = "0x9ADA18", VA = "0x9ADA18")]
		public RESULT getMaxPolygons(out int maxpolygons, out int maxvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x9ADA20", Offset = "0x9ADA20", VA = "0x9ADA20")]
		public RESULT getPolygonNumVertices(int index, out int numvertices)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x9ADA28", Offset = "0x9ADA28", VA = "0x9ADA28")]
		public RESULT setPolygonVertex(int index, int vertexindex, ref VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x9ADA30", Offset = "0x9ADA30", VA = "0x9ADA30")]
		public RESULT getPolygonVertex(int index, int vertexindex, out VECTOR vertex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B1")]
		[Address(RVA = "0x9ADA38", Offset = "0x9ADA38", VA = "0x9ADA38")]
		public RESULT setPolygonAttributes(int index, float directocclusion, float reverbocclusion, bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B2")]
		[Address(RVA = "0x9ADA44", Offset = "0x9ADA44", VA = "0x9ADA44")]
		public RESULT getPolygonAttributes(int index, out float directocclusion, out float reverbocclusion, out bool doublesided)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B3")]
		[Address(RVA = "0x9ADA4C", Offset = "0x9ADA4C", VA = "0x9ADA4C")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B4")]
		[Address(RVA = "0x9ADA58", Offset = "0x9ADA58", VA = "0x9ADA58")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B5")]
		[Address(RVA = "0x9ADA60", Offset = "0x9ADA60", VA = "0x9ADA60")]
		public RESULT setRotation(ref VECTOR forward, ref VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B6")]
		[Address(RVA = "0x9ADA68", Offset = "0x9ADA68", VA = "0x9ADA68")]
		public RESULT getRotation(out VECTOR forward, out VECTOR up)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B7")]
		[Address(RVA = "0x9ADA70", Offset = "0x9ADA70", VA = "0x9ADA70")]
		public RESULT setPosition(ref VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x9ADA78", Offset = "0x9ADA78", VA = "0x9ADA78")]
		public RESULT getPosition(out VECTOR position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x9ADA80", Offset = "0x9ADA80", VA = "0x9ADA80")]
		public RESULT setScale(ref VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x9ADA88", Offset = "0x9ADA88", VA = "0x9ADA88")]
		public RESULT getScale(out VECTOR scale)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BB")]
		[Address(RVA = "0x9ADA90", Offset = "0x9ADA90", VA = "0x9ADA90")]
		public RESULT save(IntPtr data, out int datasize)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BC")]
		[Address(RVA = "0x9ADA98", Offset = "0x9ADA98", VA = "0x9ADA98")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003BD")]
		[Address(RVA = "0x9ADAA0", Offset = "0x9ADAA0", VA = "0x9ADAA0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x11EDDD4", Offset = "0x11EDDD4", VA = "0x11EDDD4")]
		private static extern RESULT FMOD5_Geometry_Release(IntPtr geometry);

		[PreserveSig]
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x11EDE78", Offset = "0x11EDE78", VA = "0x11EDE78")]
		private static extern RESULT FMOD5_Geometry_AddPolygon(IntPtr geometry, float directocclusion, float reverbocclusion, bool doublesided, int numvertices, VECTOR[] vertices, out int polygonindex);

		[PreserveSig]
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x11EDF68", Offset = "0x11EDF68", VA = "0x11EDF68")]
		private static extern RESULT FMOD5_Geometry_GetNumPolygons(IntPtr geometry, out int numpolygons);

		[PreserveSig]
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x11EE018", Offset = "0x11EE018", VA = "0x11EE018")]
		private static extern RESULT FMOD5_Geometry_GetMaxPolygons(IntPtr geometry, out int maxpolygons, out int maxvertices);

		[PreserveSig]
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x11EE0D0", Offset = "0x11EE0D0", VA = "0x11EE0D0")]
		private static extern RESULT FMOD5_Geometry_GetPolygonNumVertices(IntPtr geometry, int index, out int numvertices);

		[PreserveSig]
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x11EE188", Offset = "0x11EE188", VA = "0x11EE188")]
		private static extern RESULT FMOD5_Geometry_SetPolygonVertex(IntPtr geometry, int index, int vertexindex, ref VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x11EE250", Offset = "0x11EE250", VA = "0x11EE250")]
		private static extern RESULT FMOD5_Geometry_GetPolygonVertex(IntPtr geometry, int index, int vertexindex, out VECTOR vertex);

		[PreserveSig]
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x11EE31C", Offset = "0x11EE31C", VA = "0x11EE31C")]
		private static extern RESULT FMOD5_Geometry_SetPolygonAttributes(IntPtr geometry, int index, float directocclusion, float reverbocclusion, bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x11EE3EC", Offset = "0x11EE3EC", VA = "0x11EE3EC")]
		private static extern RESULT FMOD5_Geometry_GetPolygonAttributes(IntPtr geometry, int index, out float directocclusion, out float reverbocclusion, out bool doublesided);

		[PreserveSig]
		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x11EE4D4", Offset = "0x11EE4D4", VA = "0x11EE4D4")]
		private static extern RESULT FMOD5_Geometry_SetActive(IntPtr geometry, bool active);

		[PreserveSig]
		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x11EE584", Offset = "0x11EE584", VA = "0x11EE584")]
		private static extern RESULT FMOD5_Geometry_GetActive(IntPtr geometry, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003C9")]
		[Address(RVA = "0x11EE648", Offset = "0x11EE648", VA = "0x11EE648")]
		private static extern RESULT FMOD5_Geometry_SetRotation(IntPtr geometry, ref VECTOR forward, ref VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003CA")]
		[Address(RVA = "0x11EE700", Offset = "0x11EE700", VA = "0x11EE700")]
		private static extern RESULT FMOD5_Geometry_GetRotation(IntPtr geometry, out VECTOR forward, out VECTOR up);

		[PreserveSig]
		[Token(Token = "0x60003CB")]
		[Address(RVA = "0x11EE7B8", Offset = "0x11EE7B8", VA = "0x11EE7B8")]
		private static extern RESULT FMOD5_Geometry_SetPosition(IntPtr geometry, ref VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x11EE868", Offset = "0x11EE868", VA = "0x11EE868")]
		private static extern RESULT FMOD5_Geometry_GetPosition(IntPtr geometry, out VECTOR position);

		[PreserveSig]
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x11EE918", Offset = "0x11EE918", VA = "0x11EE918")]
		private static extern RESULT FMOD5_Geometry_SetScale(IntPtr geometry, ref VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x11EE9C8", Offset = "0x11EE9C8", VA = "0x11EE9C8")]
		private static extern RESULT FMOD5_Geometry_GetScale(IntPtr geometry, out VECTOR scale);

		[PreserveSig]
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x11EEA78", Offset = "0x11EEA78", VA = "0x11EEA78")]
		private static extern RESULT FMOD5_Geometry_Save(IntPtr geometry, IntPtr data, out int datasize);

		[PreserveSig]
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x11EEB30", Offset = "0x11EEB30", VA = "0x11EEB30")]
		private static extern RESULT FMOD5_Geometry_SetUserData(IntPtr geometry, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x11EEBE0", Offset = "0x11EEBE0", VA = "0x11EEBE0")]
		private static extern RESULT FMOD5_Geometry_GetUserData(IntPtr geometry, out IntPtr userdata);

		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x9ADAA8", Offset = "0x9ADAA8", VA = "0x9ADAA8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x9ADAB0", Offset = "0x9ADAB0", VA = "0x9ADAB0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000055")]
	public struct Reverb3D
	{
		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x9ADB6C", Offset = "0x9ADB6C", VA = "0x9ADB6C")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x9ADB74", Offset = "0x9ADB74", VA = "0x9ADB74")]
		public RESULT set3DAttributes(ref VECTOR position, float mindistance, float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x9ADB7C", Offset = "0x9ADB7C", VA = "0x9ADB7C")]
		public RESULT get3DAttributes(ref VECTOR position, ref float mindistance, ref float maxdistance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x9ADB84", Offset = "0x9ADB84", VA = "0x9ADB84")]
		public RESULT setProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x9ADB8C", Offset = "0x9ADB8C", VA = "0x9ADB8C")]
		public RESULT getProperties(ref REVERB_PROPERTIES properties)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x9ADB94", Offset = "0x9ADB94", VA = "0x9ADB94")]
		public RESULT setActive(bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x9ADBA0", Offset = "0x9ADBA0", VA = "0x9ADBA0")]
		public RESULT getActive(out bool active)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x9ADBA8", Offset = "0x9ADBA8", VA = "0x9ADBA8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x9ADBB0", Offset = "0x9ADBB0", VA = "0x9ADBB0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x11EFD14", Offset = "0x11EFD14", VA = "0x11EFD14")]
		private static extern RESULT FMOD5_Reverb3D_Release(IntPtr reverb3d);

		[PreserveSig]
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x11EFDB4", Offset = "0x11EFDB4", VA = "0x11EFDB4")]
		private static extern RESULT FMOD5_Reverb3D_Set3DAttributes(IntPtr reverb3d, ref VECTOR position, float mindistance, float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x11EFE7C", Offset = "0x11EFE7C", VA = "0x11EFE7C")]
		private static extern RESULT FMOD5_Reverb3D_Get3DAttributes(IntPtr reverb3d, ref VECTOR position, ref float mindistance, ref float maxdistance);

		[PreserveSig]
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x11EFF44", Offset = "0x11EFF44", VA = "0x11EFF44")]
		private static extern RESULT FMOD5_Reverb3D_SetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x11EFFF4", Offset = "0x11EFFF4", VA = "0x11EFFF4")]
		private static extern RESULT FMOD5_Reverb3D_GetProperties(IntPtr reverb3d, ref REVERB_PROPERTIES properties);

		[PreserveSig]
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x11F00A8", Offset = "0x11F00A8", VA = "0x11F00A8")]
		private static extern RESULT FMOD5_Reverb3D_SetActive(IntPtr reverb3d, bool active);

		[PreserveSig]
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x11F0158", Offset = "0x11F0158", VA = "0x11F0158")]
		private static extern RESULT FMOD5_Reverb3D_GetActive(IntPtr reverb3d, out bool active);

		[PreserveSig]
		[Token(Token = "0x60003E4")]
		[Address(RVA = "0x11F021C", Offset = "0x11F021C", VA = "0x11F021C")]
		private static extern RESULT FMOD5_Reverb3D_SetUserData(IntPtr reverb3d, IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x11F02CC", Offset = "0x11F02CC", VA = "0x11F02CC")]
		private static extern RESULT FMOD5_Reverb3D_GetUserData(IntPtr reverb3d, out IntPtr userdata);

		[Token(Token = "0x60003E6")]
		[Address(RVA = "0x9ADBB8", Offset = "0x9ADBB8", VA = "0x9ADBB8")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x9ADBC0", Offset = "0x9ADBC0", VA = "0x9ADBC0")]
		public void clearHandle()
		{
		}
	}
	[Token(Token = "0x2000056")]
	public struct StringWrapper
	{
		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IntPtr nativeUtf8Ptr;

		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x11F5084", Offset = "0x11F5084", VA = "0x11F5084")]
		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
	[Token(Token = "0x2000057")]
	internal static class StringHelper
	{
		[Token(Token = "0x2000110")]
		public class ThreadSafeEncoding : IDisposable
		{
			[Token(Token = "0x4000556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private UTF8Encoding encoding;

			[Token(Token = "0x4000557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private byte[] encodedBuffer;

			[Token(Token = "0x4000558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private char[] decodedBuffer;

			[Token(Token = "0x4000559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private bool inUse;

			[Token(Token = "0x400055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private GCHandle gcHandle;

			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x11F4EC8", Offset = "0x11F4EC8", VA = "0x11F4EC8")]
			public bool InUse()
			{
				return default(bool);
			}

			[Token(Token = "0x60006BB")]
			[Address(RVA = "0x11F4E44", Offset = "0x11F4E44", VA = "0x11F4E44")]
			public void SetInUse()
			{
			}

			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x11F4ED0", Offset = "0x11F4ED0", VA = "0x11F4ED0")]
			private int roundUpPowerTwo(int number)
			{
				return default(int);
			}

			[Token(Token = "0x60006BD")]
			[Address(RVA = "0x11F2844", Offset = "0x11F2844", VA = "0x11F2844")]
			public byte[] byteFromStringUTF8(string s)
			{
				return null;
			}

			[Token(Token = "0x60006BE")]
			[Address(RVA = "0x11F4EE8", Offset = "0x11F4EE8", VA = "0x11F4EE8")]
			public IntPtr intptrFromStringUTF8(string s)
			{
				return default(IntPtr);
			}

			[Token(Token = "0x60006BF")]
			[Address(RVA = "0x11F21D0", Offset = "0x11F21D0", VA = "0x11F21D0")]
			public string stringFromNative(IntPtr nativePtr)
			{
				return null;
			}

			[Token(Token = "0x60006C0")]
			[Address(RVA = "0x11F4F74", Offset = "0x11F4F74", VA = "0x11F4F74", Slot = "4")]
			public void Dispose()
			{
			}

			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x11F4DAC", Offset = "0x11F4DAC", VA = "0x11F4DAC")]
			public ThreadSafeEncoding()
			{
			}
		}

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static List<ThreadSafeEncoding> encoders;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x11F1F40", Offset = "0x11F1F40", VA = "0x11F1F40")]
		public static ThreadSafeEncoding GetFreeHelper()
		{
			return null;
		}
	}
	[Token(Token = "0x2000058")]
	internal static class Android
	{
		[Token(Token = "0x2000111")]
		public struct THREADAFFINITY
		{
			[Token(Token = "0x400055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public THREAD mixer;

			[Token(Token = "0x400055C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public THREAD stream;

			[Token(Token = "0x400055D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public THREAD nonblocking;

			[Token(Token = "0x400055E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public THREAD file;

			[Token(Token = "0x400055F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public THREAD geometry;

			[Token(Token = "0x4000560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public THREAD profiler;

			[Token(Token = "0x4000561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public THREAD studioUpdate;

			[Token(Token = "0x4000562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public THREAD studioLoadBank;

			[Token(Token = "0x4000563")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public THREAD studioLoadSample;
		}

		[Token(Token = "0x2000112")]
		[Flags]
		public enum THREAD : uint
		{
			[Token(Token = "0x4000565")]
			DEFAULT = 0u,
			[Token(Token = "0x4000566")]
			CORE0 = 1u,
			[Token(Token = "0x4000567")]
			CORE1 = 2u,
			[Token(Token = "0x4000568")]
			CORE2 = 4u,
			[Token(Token = "0x4000569")]
			CORE3 = 8u,
			[Token(Token = "0x400056A")]
			CORE4 = 0x10u,
			[Token(Token = "0x400056B")]
			CORE5 = 0x20u,
			[Token(Token = "0x400056C")]
			CORE6 = 0x40u,
			[Token(Token = "0x400056D")]
			CORE7 = 0x80u
		}

		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x175EE90", Offset = "0x175EE90", VA = "0x175EE90")]
		public static RESULT setThreadAffinity(ref THREADAFFINITY affinity)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x175EE94", Offset = "0x175EE94", VA = "0x175EE94")]
		private static extern RESULT FMOD_Android_SetThreadAffinity(ref THREADAFFINITY affinity);
	}
	[Token(Token = "0x2000059")]
	public struct DSP_BUFFER_ARRAY
	{
		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numbuffers;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int[] buffernumchannels;

		[Token(Token = "0x4000222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CHANNELMASK[] bufferchannelmask;

		[Token(Token = "0x4000223")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr[] buffers;

		[Token(Token = "0x4000224")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SPEAKERMODE speakermode;
	}
	[Token(Token = "0x200005A")]
	public enum DSP_PROCESS_OPERATION
	{
		[Token(Token = "0x4000226")]
		PROCESS_PERFORM,
		[Token(Token = "0x4000227")]
		PROCESS_QUERY
	}
	[Token(Token = "0x200005B")]
	public struct COMPLEX
	{
		[Token(Token = "0x4000228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float real;

		[Token(Token = "0x4000229")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float imag;
	}
	[Token(Token = "0x200005C")]
	public enum DSP_PAN_SURROUND_FLAGS
	{
		[Token(Token = "0x400022B")]
		DEFAULT,
		[Token(Token = "0x400022C")]
		ROTATION_NOT_BIASED
	}
	[Token(Token = "0x200005D")]
	public delegate RESULT DSP_CREATECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200005E")]
	public delegate RESULT DSP_RELEASECALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200005F")]
	public delegate RESULT DSP_RESETCALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x2000060")]
	public delegate RESULT DSP_SETPOSITIONCALLBACK(ref DSP_STATE dsp_state, uint pos);
	[Token(Token = "0x2000061")]
	public delegate RESULT DSP_READCALLBACK(ref DSP_STATE dsp_state, IntPtr inbuffer, IntPtr outbuffer, uint length, int inchannels, ref int outchannels);
	[Token(Token = "0x2000062")]
	public delegate RESULT DSP_SHOULDIPROCESS_CALLBACK(ref DSP_STATE dsp_state, bool inputsidle, uint length, CHANNELMASK inmask, int inchannels, SPEAKERMODE speakermode);
	[Token(Token = "0x2000063")]
	public delegate RESULT DSP_PROCESS_CALLBACK(ref DSP_STATE dsp_state, uint length, ref DSP_BUFFER_ARRAY inbufferarray, ref DSP_BUFFER_ARRAY outbufferarray, bool inputsidle, DSP_PROCESS_OPERATION op);
	[Token(Token = "0x2000064")]
	public delegate RESULT DSP_SETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, float value);
	[Token(Token = "0x2000065")]
	public delegate RESULT DSP_SETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, int value);
	[Token(Token = "0x2000066")]
	public delegate RESULT DSP_SETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, bool value);
	[Token(Token = "0x2000067")]
	public delegate RESULT DSP_SETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, IntPtr data, uint length);
	[Token(Token = "0x2000068")]
	public delegate RESULT DSP_GETPARAM_FLOAT_CALLBACK(ref DSP_STATE dsp_state, int index, ref float value, IntPtr valuestr);
	[Token(Token = "0x2000069")]
	public delegate RESULT DSP_GETPARAM_INT_CALLBACK(ref DSP_STATE dsp_state, int index, ref int value, IntPtr valuestr);
	[Token(Token = "0x200006A")]
	public delegate RESULT DSP_GETPARAM_BOOL_CALLBACK(ref DSP_STATE dsp_state, int index, ref bool value, IntPtr valuestr);
	[Token(Token = "0x200006B")]
	public delegate RESULT DSP_GETPARAM_DATA_CALLBACK(ref DSP_STATE dsp_state, int index, ref IntPtr data, ref uint length, IntPtr valuestr);
	[Token(Token = "0x200006C")]
	public delegate RESULT DSP_SYSTEM_REGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200006D")]
	public delegate RESULT DSP_SYSTEM_DEREGISTER_CALLBACK(ref DSP_STATE dsp_state);
	[Token(Token = "0x200006E")]
	public delegate RESULT DSP_SYSTEM_MIX_CALLBACK(ref DSP_STATE dsp_state, int stage);
	[Token(Token = "0x200006F")]
	public delegate IntPtr DSP_ALLOC_FUNC(uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000070")]
	public delegate IntPtr DSP_REALLOC_FUNC(IntPtr ptr, uint size, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000071")]
	public delegate void DSP_FREE_FUNC(IntPtr ptr, MEMORY_TYPE type, StringWrapper sourcestr);
	[Token(Token = "0x2000072")]
	public delegate void DSP_LOG_FUNC(DEBUG_FLAGS level, StringWrapper file, int line, StringWrapper function, StringWrapper format);
	[Token(Token = "0x2000073")]
	public delegate RESULT DSP_GETSAMPLERATE_FUNC(ref DSP_STATE dsp_state, ref int rate);
	[Token(Token = "0x2000074")]
	public delegate RESULT DSP_GETBLOCKSIZE_FUNC(ref DSP_STATE dsp_state, ref uint blocksize);
	[Token(Token = "0x2000075")]
	public delegate RESULT DSP_GETSPEAKERMODE_FUNC(ref DSP_STATE dsp_state, ref int speakermode_mixer, ref int speakermode_output);
	[Token(Token = "0x2000076")]
	public delegate RESULT DSP_GETCLOCK_FUNC(ref DSP_STATE dsp_state, out ulong clock, out uint offset, out uint length);
	[Token(Token = "0x2000077")]
	public delegate RESULT DSP_GETLISTENERATTRIBUTES_FUNC(ref DSP_STATE dsp_state, ref int numlisteners, IntPtr attributes);
	[Token(Token = "0x2000078")]
	public delegate RESULT DSP_GETUSERDATA_FUNC(ref DSP_STATE dsp_state, out IntPtr userdata);
	[Token(Token = "0x2000079")]
	public delegate RESULT DSP_DFT_FFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr signal, IntPtr dft, IntPtr window, int signalhop);
	[Token(Token = "0x200007A")]
	public delegate RESULT DSP_DFT_IFFTREAL_FUNC(ref DSP_STATE dsp_state, int size, IntPtr dft, IntPtr signal, IntPtr window, int signalhop);
	[Token(Token = "0x200007B")]
	public delegate RESULT DSP_PAN_SUMMONOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float lowFrequencyGain, float overallGain, IntPtr matrix);
	[Token(Token = "0x200007C")]
	public delegate RESULT DSP_PAN_SUMSTEREOMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, float pan, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200007D")]
	public delegate RESULT DSP_PAN_SUMSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int sourceSpeakerMode, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix, DSP_PAN_SURROUND_FLAGS flags);
	[Token(Token = "0x200007E")]
	public delegate RESULT DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x200007F")]
	public delegate RESULT DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC(ref DSP_STATE dsp_state, int targetSpeakerMode, float direction, float extent, float rotation, float lowFrequencyGain, float overallGain, int matrixHop, IntPtr matrix);
	[Token(Token = "0x2000080")]
	public delegate RESULT DSP_PAN_GETROLLOFFGAIN_FUNC(ref DSP_STATE dsp_state, DSP_PAN_3D_ROLLOFF_TYPE rolloff, float distance, float mindistance, float maxdistance, out float gain);
	[Token(Token = "0x2000081")]
	public enum DSP_TYPE
	{
		[Token(Token = "0x400022E")]
		UNKNOWN,
		[Token(Token = "0x400022F")]
		MIXER,
		[Token(Token = "0x4000230")]
		OSCILLATOR,
		[Token(Token = "0x4000231")]
		LOWPASS,
		[Token(Token = "0x4000232")]
		ITLOWPASS,
		[Token(Token = "0x4000233")]
		HIGHPASS,
		[Token(Token = "0x4000234")]
		ECHO,
		[Token(Token = "0x4000235")]
		FADER,
		[Token(Token = "0x4000236")]
		FLANGE,
		[Token(Token = "0x4000237")]
		DISTORTION,
		[Token(Token = "0x4000238")]
		NORMALIZE,
		[Token(Token = "0x4000239")]
		LIMITER,
		[Token(Token = "0x400023A")]
		PARAMEQ,
		[Token(Token = "0x400023B")]
		PITCHSHIFT,
		[Token(Token = "0x400023C")]
		CHORUS,
		[Token(Token = "0x400023D")]
		VSTPLUGIN,
		[Token(Token = "0x400023E")]
		WINAMPPLUGIN,
		[Token(Token = "0x400023F")]
		ITECHO,
		[Token(Token = "0x4000240")]
		COMPRESSOR,
		[Token(Token = "0x4000241")]
		SFXREVERB,
		[Token(Token = "0x4000242")]
		LOWPASS_SIMPLE,
		[Token(Token = "0x4000243")]
		DELAY,
		[Token(Token = "0x4000244")]
		TREMOLO,
		[Token(Token = "0x4000245")]
		LADSPAPLUGIN,
		[Token(Token = "0x4000246")]
		SEND,
		[Token(Token = "0x4000247")]
		RETURN,
		[Token(Token = "0x4000248")]
		HIGHPASS_SIMPLE,
		[Token(Token = "0x4000249")]
		PAN,
		[Token(Token = "0x400024A")]
		THREE_EQ,
		[Token(Token = "0x400024B")]
		FFT,
		[Token(Token = "0x400024C")]
		LOUDNESS_METER,
		[Token(Token = "0x400024D")]
		ENVELOPEFOLLOWER,
		[Token(Token = "0x400024E")]
		CONVOLUTIONREVERB,
		[Token(Token = "0x400024F")]
		CHANNELMIX,
		[Token(Token = "0x4000250")]
		TRANSCEIVER,
		[Token(Token = "0x4000251")]
		OBJECTPAN,
		[Token(Token = "0x4000252")]
		MULTIBAND_EQ,
		[Token(Token = "0x4000253")]
		MAX
	}
	[Token(Token = "0x2000082")]
	public enum DSP_PARAMETER_TYPE
	{
		[Token(Token = "0x4000255")]
		FLOAT,
		[Token(Token = "0x4000256")]
		INT,
		[Token(Token = "0x4000257")]
		BOOL,
		[Token(Token = "0x4000258")]
		DATA,
		[Token(Token = "0x4000259")]
		MAX
	}
	[Token(Token = "0x2000083")]
	public enum DSP_PARAMETER_FLOAT_MAPPING_TYPE
	{
		[Token(Token = "0x400025B")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_LINEAR,
		[Token(Token = "0x400025C")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_AUTO,
		[Token(Token = "0x400025D")]
		DSP_PARAMETER_FLOAT_MAPPING_TYPE_PIECEWISE_LINEAR
	}
	[Token(Token = "0x2000084")]
	public struct DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numpoints;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr pointparamvalues;

		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr pointpositions;
	}
	[Token(Token = "0x2000085")]
	public struct DSP_PARAMETER_FLOAT_MAPPING
	{
		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_FLOAT_MAPPING_TYPE type;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PARAMETER_FLOAT_MAPPING_PIECEWISE_LINEAR piecewiselinearmapping;
	}
	[Token(Token = "0x2000086")]
	public struct DSP_PARAMETER_DESC_FLOAT
	{
		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float min;

		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float max;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float defaultval;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PARAMETER_FLOAT_MAPPING mapping;
	}
	[Token(Token = "0x2000087")]
	public struct DSP_PARAMETER_DESC_INT
	{
		[Token(Token = "0x4000267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int min;

		[Token(Token = "0x4000268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int max;

		[Token(Token = "0x4000269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int defaultval;

		[Token(Token = "0x400026A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public bool goestoinf;

		[Token(Token = "0x400026B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x2000088")]
	public struct DSP_PARAMETER_DESC_BOOL
	{
		[Token(Token = "0x400026C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool defaultval;

		[Token(Token = "0x400026D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr valuenames;
	}
	[Token(Token = "0x2000089")]
	public struct DSP_PARAMETER_DESC_DATA
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int datatype;
	}
	[StructLayout(2)]
	[Token(Token = "0x200008A")]
	public struct DSP_PARAMETER_DESC_UNION
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_FLOAT floatdesc;

		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_INT intdesc;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_BOOL booldesc;

		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_DESC_DATA datadesc;
	}
	[Token(Token = "0x200008B")]
	public struct DSP_PARAMETER_DESC
	{
		[Token(Token = "0x4000273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PARAMETER_TYPE type;

		[Token(Token = "0x4000274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x4000275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public char[] label;

		[Token(Token = "0x4000276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string description;

		[Token(Token = "0x4000277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PARAMETER_DESC_UNION desc;
	}
	[Token(Token = "0x200008C")]
	public enum DSP_PARAMETER_DATA_TYPE
	{
		[Token(Token = "0x4000279")]
		DSP_PARAMETER_DATA_TYPE_USER = 0,
		[Token(Token = "0x400027A")]
		DSP_PARAMETER_DATA_TYPE_OVERALLGAIN = -1,
		[Token(Token = "0x400027B")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES = -2,
		[Token(Token = "0x400027C")]
		DSP_PARAMETER_DATA_TYPE_SIDECHAIN = -3,
		[Token(Token = "0x400027D")]
		DSP_PARAMETER_DATA_TYPE_FFT = -4,
		[Token(Token = "0x400027E")]
		DSP_PARAMETER_DATA_TYPE_3DATTRIBUTES_MULTI = -5
	}
	[Token(Token = "0x200008D")]
	public struct DSP_PARAMETER_OVERALLGAIN
	{
		[Token(Token = "0x400027F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float linear_gain;

		[Token(Token = "0x4000280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float linear_gain_additive;
	}
	[Token(Token = "0x200008E")]
	public struct DSP_PARAMETER_3DATTRIBUTES
	{
		[Token(Token = "0x4000281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public ATTRIBUTES_3D relative;

		[Token(Token = "0x4000282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x200008F")]
	public struct DSP_PARAMETER_3DATTRIBUTES_MULTI
	{
		[Token(Token = "0x4000283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numlisteners;

		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public ATTRIBUTES_3D[] relative;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] weight;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ATTRIBUTES_3D absolute;
	}
	[Token(Token = "0x2000090")]
	public struct DSP_PARAMETER_SIDECHAIN
	{
		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int sidechainenable;
	}
	[Token(Token = "0x2000091")]
	public struct DSP_PARAMETER_FFT
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int length;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int numchannels;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private IntPtr[] spectrum_internal;

		[Token(Token = "0x17000005")]
		public float[][] spectrum
		{
			[Token(Token = "0x600047D")]
			[Address(RVA = "0x9C79A0", Offset = "0x9C79A0", VA = "0x9C79A0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600047E")]
		[Address(RVA = "0x9C79A8", Offset = "0x9C79A8", VA = "0x9C79A8")]
		public void getSpectrum(ref float[][] buffer)
		{
		}

		[Token(Token = "0x600047F")]
		[Address(RVA = "0x9C79B0", Offset = "0x9C79B0", VA = "0x9C79B0")]
		public void getSpectrum(int channel, ref float[] buffer)
		{
		}
	}
	[Token(Token = "0x2000092")]
	public struct DSP_DESCRIPTION
	{
		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint pluginsdkversion;

		[Token(Token = "0x400028C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public char[] name;

		[Token(Token = "0x400028D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint version;

		[Token(Token = "0x400028E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int numinputbuffers;

		[Token(Token = "0x400028F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int numoutputbuffers;

		[Token(Token = "0x4000290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_CREATECALLBACK create;

		[Token(Token = "0x4000291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_RELEASECALLBACK release;

		[Token(Token = "0x4000292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DSP_RESETCALLBACK reset;

		[Token(Token = "0x4000293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public DSP_READCALLBACK read;

		[Token(Token = "0x4000294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public DSP_PROCESS_CALLBACK process;

		[Token(Token = "0x4000295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public DSP_SETPOSITIONCALLBACK setposition;

		[Token(Token = "0x4000296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int numparameters;

		[Token(Token = "0x4000297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public IntPtr paramdesc;

		[Token(Token = "0x4000298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public DSP_SETPARAM_FLOAT_CALLBACK setparameterfloat;

		[Token(Token = "0x4000299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public DSP_SETPARAM_INT_CALLBACK setparameterint;

		[Token(Token = "0x400029A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public DSP_SETPARAM_BOOL_CALLBACK setparameterbool;

		[Token(Token = "0x400029B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public DSP_SETPARAM_DATA_CALLBACK setparameterdata;

		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		public DSP_GETPARAM_FLOAT_CALLBACK getparameterfloat;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public DSP_GETPARAM_INT_CALLBACK getparameterint;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public DSP_GETPARAM_BOOL_CALLBACK getparameterbool;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public DSP_GETPARAM_DATA_CALLBACK getparameterdata;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public DSP_SHOULDIPROCESS_CALLBACK shouldiprocess;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public IntPtr userdata;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public DSP_SYSTEM_REGISTER_CALLBACK sys_register;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public DSP_SYSTEM_DEREGISTER_CALLBACK sys_deregister;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public DSP_SYSTEM_MIX_CALLBACK sys_mix;
	}
	[Token(Token = "0x2000093")]
	public struct DSP_STATE_DFT_FUNCTIONS
	{
		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_DFT_FFTREAL_FUNC fftreal;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_DFT_IFFTREAL_FUNC inversefftreal;
	}
	[Token(Token = "0x2000094")]
	public struct DSP_STATE_PAN_FUNCTIONS
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public DSP_PAN_SUMMONOMATRIX_FUNC summonomatrix;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public DSP_PAN_SUMSTEREOMATRIX_FUNC sumstereomatrix;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public DSP_PAN_SUMSURROUNDMATRIX_FUNC sumsurroundmatrix;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DSP_PAN_SUMMONOTOSURROUNDMATRIX_FUNC summonotosurroundmatrix;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public DSP_PAN_SUMSTEREOTOSURROUNDMATRIX_FUNC sumstereotosurroundmatrix;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DSP_PAN_GETROLLOFFGAIN_FUNC getrolloffgain;
	}
	[Token(Token = "0x2000095")]
	public struct DSP_STATE_FUNCTIONS
	{
		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private DSP_ALLOC_FUNC alloc;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private DSP_REALLOC_FUNC realloc;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private DSP_FREE_FUNC free;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private DSP_GETSAMPLERATE_FUNC getsamplerate;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private DSP_GETBLOCKSIZE_FUNC getblocksize;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IntPtr dft;

		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private IntPtr pan;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private DSP_GETSPEAKERMODE_FUNC getspeakermode;

		[Token(Token = "0x40002B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private DSP_GETCLOCK_FUNC getclock;

		[Token(Token = "0x40002B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private DSP_GETLISTENERATTRIBUTES_FUNC getlistenerattributes;

		[Token(Token = "0x40002B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DSP_LOG_FUNC log;

		[Token(Token = "0x40002B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private DSP_GETUSERDATA_FUNC getuserdata;
	}
	[Token(Token = "0x2000096")]
	public struct DSP_STATE
	{
		[Token(Token = "0x40002B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr instance;

		[Token(Token = "0x40002BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr plugindata;

		[Token(Token = "0x40002BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public uint channelmask;

		[Token(Token = "0x40002BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int source_speakermode;

		[Token(Token = "0x40002BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr sidechaindata;

		[Token(Token = "0x40002BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public int sidechainchannels;

		[Token(Token = "0x40002BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntPtr functions;

		[Token(Token = "0x40002C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int systemobject;
	}
	[Token(Token = "0x2000097")]
	public struct DSP_METERING_INFO
	{
		[Token(Token = "0x40002C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int numsamples;

		[Token(Token = "0x40002C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float[] peaklevel;

		[Token(Token = "0x40002C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float[] rmslevel;

		[Token(Token = "0x40002C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public short numchannels;
	}
	[Token(Token = "0x2000098")]
	public enum DSP_OSCILLATOR
	{
		[Token(Token = "0x40002C6")]
		TYPE,
		[Token(Token = "0x40002C7")]
		RATE
	}
	[Token(Token = "0x2000099")]
	public enum DSP_LOWPASS
	{
		[Token(Token = "0x40002C9")]
		CUTOFF,
		[Token(Token = "0x40002CA")]
		RESONANCE
	}
	[Token(Token = "0x200009A")]
	public enum DSP_ITLOWPASS
	{
		[Token(Token = "0x40002CC")]
		CUTOFF,
		[Token(Token = "0x40002CD")]
		RESONANCE
	}
	[Token(Token = "0x200009B")]
	public enum DSP_HIGHPASS
	{
		[Token(Token = "0x40002CF")]
		CUTOFF,
		[Token(Token = "0x40002D0")]
		RESONANCE
	}
	[Token(Token = "0x200009C")]
	public enum DSP_ECHO
	{
		[Token(Token = "0x40002D2")]
		DELAY,
		[Token(Token = "0x40002D3")]
		FEEDBACK,
		[Token(Token = "0x40002D4")]
		DRYLEVEL,
		[Token(Token = "0x40002D5")]
		WETLEVEL
	}
	[Token(Token = "0x200009D")]
	public enum DSP_FADER
	{
		[Token(Token = "0x40002D7")]
		GAIN,
		[Token(Token = "0x40002D8")]
		OVERALL_GAIN
	}
	[Token(Token = "0x200009E")]
	public enum DSP_DELAY
	{
		[Token(Token = "0x40002DA")]
		CH0,
		[Token(Token = "0x40002DB")]
		CH1,
		[Token(Token = "0x40002DC")]
		CH2,
		[Token(Token = "0x40002DD")]
		CH3,
		[Token(Token = "0x40002DE")]
		CH4,
		[Token(Token = "0x40002DF")]
		CH5,
		[Token(Token = "0x40002E0")]
		CH6,
		[Token(Token = "0x40002E1")]
		CH7,
		[Token(Token = "0x40002E2")]
		CH8,
		[Token(Token = "0x40002E3")]
		CH9,
		[Token(Token = "0x40002E4")]
		CH10,
		[Token(Token = "0x40002E5")]
		CH11,
		[Token(Token = "0x40002E6")]
		CH12,
		[Token(Token = "0x40002E7")]
		CH13,
		[Token(Token = "0x40002E8")]
		CH14,
		[Token(Token = "0x40002E9")]
		CH15,
		[Token(Token = "0x40002EA")]
		MAXDELAY
	}
	[Token(Token = "0x200009F")]
	public enum DSP_FLANGE
	{
		[Token(Token = "0x40002EC")]
		MIX,
		[Token(Token = "0x40002ED")]
		DEPTH,
		[Token(Token = "0x40002EE")]
		RATE
	}
	[Token(Token = "0x20000A0")]
	public enum DSP_TREMOLO
	{
		[Token(Token = "0x40002F0")]
		FREQUENCY,
		[Token(Token = "0x40002F1")]
		DEPTH,
		[Token(Token = "0x40002F2")]
		SHAPE,
		[Token(Token = "0x40002F3")]
		SKEW,
		[Token(Token = "0x40002F4")]
		DUTY,
		[Token(Token = "0x40002F5")]
		SQUARE,
		[Token(Token = "0x40002F6")]
		PHASE,
		[Token(Token = "0x40002F7")]
		SPREAD
	}
	[Token(Token = "0x20000A1")]
	public enum DSP_DISTORTION
	{
		[Token(Token = "0x40002F9")]
		LEVEL
	}
	[Token(Token = "0x20000A2")]
	public enum DSP_NORMALIZE
	{
		[Token(Token = "0x40002FB")]
		FADETIME,
		[Token(Token = "0x40002FC")]
		THRESHHOLD,
		[Token(Token = "0x40002FD")]
		MAXAMP
	}
	[Token(Token = "0x20000A3")]
	public enum DSP_LIMITER
	{
		[Token(Token = "0x40002FF")]
		RELEASETIME,
		[Token(Token = "0x4000300")]
		CEILING,
		[Token(Token = "0x4000301")]
		MAXIMIZERGAIN,
		[Token(Token = "0x4000302")]
		MODE
	}
	[Token(Token = "0x20000A4")]
	public enum DSP_PARAMEQ
	{
		[Token(Token = "0x4000304")]
		CENTER,
		[Token(Token = "0x4000305")]
		BANDWIDTH,
		[Token(Token = "0x4000306")]
		GAIN
	}
	[Token(Token = "0x20000A5")]
	public enum DSP_MULTIBAND_EQ
	{
		[Token(Token = "0x4000308")]
		A_FILTER,
		[Token(Token = "0x4000309")]
		A_FREQUENCY,
		[Token(Token = "0x400030A")]
		A_Q,
		[Token(Token = "0x400030B")]
		A_GAIN,
		[Token(Token = "0x400030C")]
		B_FILTER,
		[Token(Token = "0x400030D")]
		B_FREQUENCY,
		[Token(Token = "0x400030E")]
		B_Q,
		[Token(Token = "0x400030F")]
		B_GAIN,
		[Token(Token = "0x4000310")]
		C_FILTER,
		[Token(Token = "0x4000311")]
		C_FREQUENCY,
		[Token(Token = "0x4000312")]
		C_Q,
		[Token(Token = "0x4000313")]
		C_GAIN,
		[Token(Token = "0x4000314")]
		D_FILTER,
		[Token(Token = "0x4000315")]
		D_FREQUENCY,
		[Token(Token = "0x4000316")]
		D_Q,
		[Token(Token = "0x4000317")]
		D_GAIN,
		[Token(Token = "0x4000318")]
		E_FILTER,
		[Token(Token = "0x4000319")]
		E_FREQUENCY,
		[Token(Token = "0x400031A")]
		E_Q,
		[Token(Token = "0x400031B")]
		E_GAIN
	}
	[Token(Token = "0x20000A6")]
	public enum DSP_MULTIBAND_EQ_FILTER_TYPE
	{
		[Token(Token = "0x400031D")]
		DISABLED,
		[Token(Token = "0x400031E")]
		LOWPASS_12DB,
		[Token(Token = "0x400031F")]
		LOWPASS_24DB,
		[Token(Token = "0x4000320")]
		LOWPASS_48DB,
		[Token(Token = "0x4000321")]
		HIGHPASS_12DB,
		[Token(Token = "0x4000322")]
		HIGHPASS_24DB,
		[Token(Token = "0x4000323")]
		HIGHPASS_48DB,
		[Token(Token = "0x4000324")]
		LOWSHELF,
		[Token(Token = "0x4000325")]
		HIGHSHELF,
		[Token(Token = "0x4000326")]
		PEAKING,
		[Token(Token = "0x4000327")]
		BANDPASS,
		[Token(Token = "0x4000328")]
		NOTCH,
		[Token(Token = "0x4000329")]
		ALLPASS
	}
	[Token(Token = "0x20000A7")]
	public enum DSP_PITCHSHIFT
	{
		[Token(Token = "0x400032B")]
		PITCH,
		[Token(Token = "0x400032C")]
		FFTSIZE,
		[Token(Token = "0x400032D")]
		OVERLAP,
		[Token(Token = "0x400032E")]
		MAXCHANNELS
	}
	[Token(Token = "0x20000A8")]
	public enum DSP_CHORUS
	{
		[Token(Token = "0x4000330")]
		MIX,
		[Token(Token = "0x4000331")]
		RATE,
		[Token(Token = "0x4000332")]
		DEPTH
	}
	[Token(Token = "0x20000A9")]
	public enum DSP_ITECHO
	{
		[Token(Token = "0x4000334")]
		WETDRYMIX,
		[Token(Token = "0x4000335")]
		FEEDBACK,
		[Token(Token = "0x4000336")]
		LEFTDELAY,
		[Token(Token = "0x4000337")]
		RIGHTDELAY,
		[Token(Token = "0x4000338")]
		PANDELAY
	}
	[Token(Token = "0x20000AA")]
	public enum DSP_COMPRESSOR
	{
		[Token(Token = "0x400033A")]
		THRESHOLD,
		[Token(Token = "0x400033B")]
		RATIO,
		[Token(Token = "0x400033C")]
		ATTACK,
		[Token(Token = "0x400033D")]
		RELEASE,
		[Token(Token = "0x400033E")]
		GAINMAKEUP,
		[Token(Token = "0x400033F")]
		USESIDECHAIN,
		[Token(Token = "0x4000340")]
		LINKED
	}
	[Token(Token = "0x20000AB")]
	public enum DSP_SFXREVERB
	{
		[Token(Token = "0x4000342")]
		DECAYTIME,
		[Token(Token = "0x4000343")]
		EARLYDELAY,
		[Token(Token = "0x4000344")]
		LATEDELAY,
		[Token(Token = "0x4000345")]
		HFREFERENCE,
		[Token(Token = "0x4000346")]
		HFDECAYRATIO,
		[Token(Token = "0x4000347")]
		DIFFUSION,
		[Token(Token = "0x4000348")]
		DENSITY,
		[Token(Token = "0x4000349")]
		LOWSHELFFREQUENCY,
		[Token(Token = "0x400034A")]
		LOWSHELFGAIN,
		[Token(Token = "0x400034B")]
		HIGHCUT,
		[Token(Token = "0x400034C")]
		EARLYLATEMIX,
		[Token(Token = "0x400034D")]
		WETLEVEL,
		[Token(Token = "0x400034E")]
		DRYLEVEL
	}
	[Token(Token = "0x20000AC")]
	public enum DSP_LOWPASS_SIMPLE
	{
		[Token(Token = "0x4000350")]
		CUTOFF
	}
	[Token(Token = "0x20000AD")]
	public enum DSP_SEND
	{
		[Token(Token = "0x4000352")]
		RETURNID,
		[Token(Token = "0x4000353")]
		LEVEL
	}
	[Token(Token = "0x20000AE")]
	public enum DSP_RETURN
	{
		[Token(Token = "0x4000355")]
		ID,
		[Token(Token = "0x4000356")]
		INPUT_SPEAKER_MODE
	}
	[Token(Token = "0x20000AF")]
	public enum DSP_HIGHPASS_SIMPLE
	{
		[Token(Token = "0x4000358")]
		CUTOFF
	}
	[Token(Token = "0x20000B0")]
	public enum DSP_PAN_2D_STEREO_MODE_TYPE
	{
		[Token(Token = "0x400035A")]
		DISTRIBUTED,
		[Token(Token = "0x400035B")]
		DISCRETE
	}
	[Token(Token = "0x20000B1")]
	public enum DSP_PAN_MODE_TYPE
	{
		[Token(Token = "0x400035D")]
		MONO,
		[Token(Token = "0x400035E")]
		STEREO,
		[Token(Token = "0x400035F")]
		SURROUND
	}
	[Token(Token = "0x20000B2")]
	public enum DSP_PAN_3D_ROLLOFF_TYPE
	{
		[Token(Token = "0x4000361")]
		LINEARSQUARED,
		[Token(Token = "0x4000362")]
		LINEAR,
		[Token(Token = "0x4000363")]
		INVERSE,
		[Token(Token = "0x4000364")]
		INVERSETAPERED,
		[Token(Token = "0x4000365")]
		CUSTOM
	}
	[Token(Token = "0x20000B3")]
	public enum DSP_PAN_3D_EXTENT_MODE_TYPE
	{
		[Token(Token = "0x4000367")]
		AUTO,
		[Token(Token = "0x4000368")]
		USER,
		[Token(Token = "0x4000369")]
		OFF
	}
	[Token(Token = "0x20000B4")]
	public enum DSP_PAN
	{
		[Token(Token = "0x400036B")]
		MODE,
		[Token(Token = "0x400036C")]
		_2D_STEREO_POSITION,
		[Token(Token = "0x400036D")]
		_2D_DIRECTION,
		[Token(Token = "0x400036E")]
		_2D_EXTENT,
		[Token(Token = "0x400036F")]
		_2D_ROTATION,
		[Token(Token = "0x4000370")]
		_2D_LFE_LEVEL,
		[Token(Token = "0x4000371")]
		_2D_STEREO_MODE,
		[Token(Token = "0x4000372")]
		_2D_STEREO_SEPARATION,
		[Token(Token = "0x4000373")]
		_2D_STEREO_AXIS,
		[Token(Token = "0x4000374")]
		ENABLED_SPEAKERS,
		[Token(Token = "0x4000375")]
		_3D_POSITION,
		[Token(Token = "0x4000376")]
		_3D_ROLLOFF,
		[Token(Token = "0x4000377")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x4000378")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x4000379")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x400037A")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x400037B")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x400037C")]
		_3D_PAN_BLEND,
		[Token(Token = "0x400037D")]
		LFE_UPMIX_ENABLED,
		[Token(Token = "0x400037E")]
		OVERALL_GAIN,
		[Token(Token = "0x400037F")]
		SURROUND_SPEAKER_MODE,
		[Token(Token = "0x4000380")]
		_2D_HEIGHT_BLEND
	}
	[Token(Token = "0x20000B5")]
	public enum DSP_THREE_EQ_CROSSOVERSLOPE_TYPE
	{
		[Token(Token = "0x4000382")]
		_12DB,
		[Token(Token = "0x4000383")]
		_24DB,
		[Token(Token = "0x4000384")]
		_48DB
	}
	[Token(Token = "0x20000B6")]
	public enum DSP_THREE_EQ
	{
		[Token(Token = "0x4000386")]
		LOWGAIN,
		[Token(Token = "0x4000387")]
		MIDGAIN,
		[Token(Token = "0x4000388")]
		HIGHGAIN,
		[Token(Token = "0x4000389")]
		LOWCROSSOVER,
		[Token(Token = "0x400038A")]
		HIGHCROSSOVER,
		[Token(Token = "0x400038B")]
		CROSSOVERSLOPE
	}
	[Token(Token = "0x20000B7")]
	public enum DSP_FFT_WINDOW
	{
		[Token(Token = "0x400038D")]
		RECT,
		[Token(Token = "0x400038E")]
		TRIANGLE,
		[Token(Token = "0x400038F")]
		HAMMING,
		[Token(Token = "0x4000390")]
		HANNING,
		[Token(Token = "0x4000391")]
		BLACKMAN,
		[Token(Token = "0x4000392")]
		BLACKMANHARRIS
	}
	[Token(Token = "0x20000B8")]
	public enum DSP_FFT
	{
		[Token(Token = "0x4000394")]
		WINDOWSIZE,
		[Token(Token = "0x4000395")]
		WINDOWTYPE,
		[Token(Token = "0x4000396")]
		SPECTRUMDATA,
		[Token(Token = "0x4000397")]
		DOMINANT_FREQ
	}
	[Token(Token = "0x20000B9")]
	public enum DSP_ENVELOPEFOLLOWER
	{
		[Token(Token = "0x4000399")]
		ATTACK,
		[Token(Token = "0x400039A")]
		RELEASE,
		[Token(Token = "0x400039B")]
		ENVELOPE,
		[Token(Token = "0x400039C")]
		USESIDECHAIN
	}
	[Token(Token = "0x20000BA")]
	public enum DSP_CONVOLUTION_REVERB
	{
		[Token(Token = "0x400039E")]
		IR,
		[Token(Token = "0x400039F")]
		WET,
		[Token(Token = "0x40003A0")]
		DRY,
		[Token(Token = "0x40003A1")]
		LINKED
	}
	[Token(Token = "0x20000BB")]
	public enum DSP_CHANNELMIX_OUTPUT
	{
		[Token(Token = "0x40003A3")]
		DEFAULT,
		[Token(Token = "0x40003A4")]
		ALLMONO,
		[Token(Token = "0x40003A5")]
		ALLSTEREO,
		[Token(Token = "0x40003A6")]
		ALLQUAD,
		[Token(Token = "0x40003A7")]
		ALL5POINT1,
		[Token(Token = "0x40003A8")]
		ALL7POINT1,
		[Token(Token = "0x40003A9")]
		ALLLFE,
		[Token(Token = "0x40003AA")]
		ALL7POINT1POINT4
	}
	[Token(Token = "0x20000BC")]
	public enum DSP_CHANNELMIX
	{
		[Token(Token = "0x40003AC")]
		OUTPUTGROUPING,
		[Token(Token = "0x40003AD")]
		GAIN_CH0,
		[Token(Token = "0x40003AE")]
		GAIN_CH1,
		[Token(Token = "0x40003AF")]
		GAIN_CH2,
		[Token(Token = "0x40003B0")]
		GAIN_CH3,
		[Token(Token = "0x40003B1")]
		GAIN_CH4,
		[Token(Token = "0x40003B2")]
		GAIN_CH5,
		[Token(Token = "0x40003B3")]
		GAIN_CH6,
		[Token(Token = "0x40003B4")]
		GAIN_CH7,
		[Token(Token = "0x40003B5")]
		GAIN_CH8,
		[Token(Token = "0x40003B6")]
		GAIN_CH9,
		[Token(Token = "0x40003B7")]
		GAIN_CH10,
		[Token(Token = "0x40003B8")]
		GAIN_CH11,
		[Token(Token = "0x40003B9")]
		GAIN_CH12,
		[Token(Token = "0x40003BA")]
		GAIN_CH13,
		[Token(Token = "0x40003BB")]
		GAIN_CH14,
		[Token(Token = "0x40003BC")]
		GAIN_CH15,
		[Token(Token = "0x40003BD")]
		GAIN_CH16,
		[Token(Token = "0x40003BE")]
		GAIN_CH17,
		[Token(Token = "0x40003BF")]
		GAIN_CH18,
		[Token(Token = "0x40003C0")]
		GAIN_CH19,
		[Token(Token = "0x40003C1")]
		GAIN_CH20,
		[Token(Token = "0x40003C2")]
		GAIN_CH21,
		[Token(Token = "0x40003C3")]
		GAIN_CH22,
		[Token(Token = "0x40003C4")]
		GAIN_CH23,
		[Token(Token = "0x40003C5")]
		GAIN_CH24,
		[Token(Token = "0x40003C6")]
		GAIN_CH25,
		[Token(Token = "0x40003C7")]
		GAIN_CH26,
		[Token(Token = "0x40003C8")]
		GAIN_CH27,
		[Token(Token = "0x40003C9")]
		GAIN_CH28,
		[Token(Token = "0x40003CA")]
		GAIN_CH29,
		[Token(Token = "0x40003CB")]
		GAIN_CH30,
		[Token(Token = "0x40003CC")]
		GAIN_CH31,
		[Token(Token = "0x40003CD")]
		OUTPUT_CH0,
		[Token(Token = "0x40003CE")]
		OUTPUT_CH1,
		[Token(Token = "0x40003CF")]
		OUTPUT_CH2,
		[Token(Token = "0x40003D0")]
		OUTPUT_CH3,
		[Token(Token = "0x40003D1")]
		OUTPUT_CH4,
		[Token(Token = "0x40003D2")]
		OUTPUT_CH5,
		[Token(Token = "0x40003D3")]
		OUTPUT_CH6,
		[Token(Token = "0x40003D4")]
		OUTPUT_CH7,
		[Token(Token = "0x40003D5")]
		OUTPUT_CH8,
		[Token(Token = "0x40003D6")]
		OUTPUT_CH9,
		[Token(Token = "0x40003D7")]
		OUTPUT_CH10,
		[Token(Token = "0x40003D8")]
		OUTPUT_CH11,
		[Token(Token = "0x40003D9")]
		OUTPUT_CH12,
		[Token(Token = "0x40003DA")]
		OUTPUT_CH13,
		[Token(Token = "0x40003DB")]
		OUTPUT_CH14,
		[Token(Token = "0x40003DC")]
		OUTPUT_CH15,
		[Token(Token = "0x40003DD")]
		OUTPUT_CH16,
		[Token(Token = "0x40003DE")]
		OUTPUT_CH17,
		[Token(Token = "0x40003DF")]
		OUTPUT_CH18,
		[Token(Token = "0x40003E0")]
		OUTPUT_CH19,
		[Token(Token = "0x40003E1")]
		OUTPUT_CH20,
		[Token(Token = "0x40003E2")]
		OUTPUT_CH21,
		[Token(Token = "0x40003E3")]
		OUTPUT_CH22,
		[Token(Token = "0x40003E4")]
		OUTPUT_CH23,
		[Token(Token = "0x40003E5")]
		OUTPUT_CH24,
		[Token(Token = "0x40003E6")]
		OUTPUT_CH25,
		[Token(Token = "0x40003E7")]
		OUTPUT_CH26,
		[Token(Token = "0x40003E8")]
		OUTPUT_CH27,
		[Token(Token = "0x40003E9")]
		OUTPUT_CH28,
		[Token(Token = "0x40003EA")]
		OUTPUT_CH29,
		[Token(Token = "0x40003EB")]
		OUTPUT_CH30,
		[Token(Token = "0x40003EC")]
		OUTPUT_CH31
	}
	[Token(Token = "0x20000BD")]
	public enum DSP_TRANSCEIVER_SPEAKERMODE
	{
		[Token(Token = "0x40003EE")]
		AUTO = -1,
		[Token(Token = "0x40003EF")]
		MONO,
		[Token(Token = "0x40003F0")]
		STEREO,
		[Token(Token = "0x40003F1")]
		SURROUND
	}
	[Token(Token = "0x20000BE")]
	public enum DSP_TRANSCEIVER
	{
		[Token(Token = "0x40003F3")]
		TRANSMIT,
		[Token(Token = "0x40003F4")]
		GAIN,
		[Token(Token = "0x40003F5")]
		CHANNEL,
		[Token(Token = "0x40003F6")]
		TRANSMITSPEAKERMODE
	}
	[Token(Token = "0x20000BF")]
	public enum DSP_OBJECTPAN
	{
		[Token(Token = "0x40003F8")]
		_3D_POSITION,
		[Token(Token = "0x40003F9")]
		_3D_ROLLOFF,
		[Token(Token = "0x40003FA")]
		_3D_MIN_DISTANCE,
		[Token(Token = "0x40003FB")]
		_3D_MAX_DISTANCE,
		[Token(Token = "0x40003FC")]
		_3D_EXTENT_MODE,
		[Token(Token = "0x40003FD")]
		_3D_SOUND_SIZE,
		[Token(Token = "0x40003FE")]
		_3D_MIN_EXTENT,
		[Token(Token = "0x40003FF")]
		OVERALL_GAIN,
		[Token(Token = "0x4000400")]
		OUTPUTGAIN
	}
	[Token(Token = "0x20000C0")]
	public class Error
	{
		[Token(Token = "0x6000480")]
		[Address(RVA = "0x177267C", Offset = "0x177267C", VA = "0x177267C")]
		public static string String(RESULT errcode)
		{
			return null;
		}

		[Token(Token = "0x6000481")]
		[Address(RVA = "0x17726E0", Offset = "0x17726E0", VA = "0x17726E0")]
		public Error()
		{
		}
	}
}
namespace FMOD.Studio
{
	[Token(Token = "0x20000C1")]
	public class STUDIO_VERSION
	{
		[Token(Token = "0x4000401")]
		public const string dll = "fmodstudio";

		[Token(Token = "0x6000482")]
		[Address(RVA = "0x11FD0F0", Offset = "0x11FD0F0", VA = "0x11FD0F0")]
		public STUDIO_VERSION()
		{
		}
	}
	[Token(Token = "0x20000C2")]
	public enum STOP_MODE
	{
		[Token(Token = "0x4000403")]
		ALLOWFADEOUT,
		[Token(Token = "0x4000404")]
		IMMEDIATE
	}
	[Token(Token = "0x20000C3")]
	public enum LOADING_STATE
	{
		[Token(Token = "0x4000406")]
		UNLOADING,
		[Token(Token = "0x4000407")]
		UNLOADED,
		[Token(Token = "0x4000408")]
		LOADING,
		[Token(Token = "0x4000409")]
		LOADED,
		[Token(Token = "0x400040A")]
		ERROR
	}
	[Token(Token = "0x20000C4")]
	public struct PROGRAMMER_SOUND_PROPERTIES
	{
		[Token(Token = "0x400040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr sound;

		[Token(Token = "0x400040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int subsoundIndex;
	}
	[Token(Token = "0x20000C5")]
	public struct TIMELINE_MARKER_PROPERTIES
	{
		[Token(Token = "0x400040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;
	}
	[Token(Token = "0x20000C6")]
	public struct TIMELINE_BEAT_PROPERTIES
	{
		[Token(Token = "0x4000410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int bar;

		[Token(Token = "0x4000411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int beat;

		[Token(Token = "0x4000412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int position;

		[Token(Token = "0x4000413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float tempo;

		[Token(Token = "0x4000414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int timesignatureupper;

		[Token(Token = "0x4000415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int timesignaturelower;
	}
	[Token(Token = "0x20000C7")]
	public struct ADVANCEDSETTINGS
	{
		[Token(Token = "0x4000416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int cbsize;

		[Token(Token = "0x4000417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int commandqueuesize;

		[Token(Token = "0x4000418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int handleinitialsize;

		[Token(Token = "0x4000419")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int studioupdateperiod;

		[Token(Token = "0x400041A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int idlesampledatapoolsize;

		[Token(Token = "0x400041B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public int streamingscheduledelay;

		[Token(Token = "0x400041C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public IntPtr encryptionkey;
	}
	[Token(Token = "0x20000C8")]
	public struct CPU_USAGE
	{
		[Token(Token = "0x400041D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float dspusage;

		[Token(Token = "0x400041E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public float streamusage;

		[Token(Token = "0x400041F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public float geometryusage;

		[Token(Token = "0x4000420")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public float updateusage;

		[Token(Token = "0x4000421")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float studiousage;
	}
	[Token(Token = "0x20000C9")]
	public struct BUFFER_INFO
	{
		[Token(Token = "0x4000422")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int currentusage;

		[Token(Token = "0x4000423")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int peakusage;

		[Token(Token = "0x4000424")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int capacity;

		[Token(Token = "0x4000425")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int stallcount;

		[Token(Token = "0x4000426")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float stalltime;
	}
	[Token(Token = "0x20000CA")]
	public struct BUFFER_USAGE
	{
		[Token(Token = "0x4000427")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public BUFFER_INFO studiocommandqueue;

		[Token(Token = "0x4000428")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public BUFFER_INFO studiohandle;
	}
	[Token(Token = "0x20000CB")]
	public struct BANK_INFO
	{
		[Token(Token = "0x4000429")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int size;

		[Token(Token = "0x400042A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr userdata;

		[Token(Token = "0x400042B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int userdatalength;

		[Token(Token = "0x400042C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FILE_OPEN_CALLBACK opencallback;

		[Token(Token = "0x400042D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FILE_CLOSE_CALLBACK closecallback;

		[Token(Token = "0x400042E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public FILE_READ_CALLBACK readcallback;

		[Token(Token = "0x400042F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FILE_SEEK_CALLBACK seekcallback;
	}
	[Token(Token = "0x20000CC")]
	[Flags]
	public enum SYSTEM_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000431")]
		PREUPDATE = 1u,
		[Token(Token = "0x4000432")]
		POSTUPDATE = 2u,
		[Token(Token = "0x4000433")]
		BANK_UNLOAD = 4u,
		[Token(Token = "0x4000434")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000CD")]
	public delegate RESULT SYSTEM_CALLBACK(IntPtr system, SYSTEM_CALLBACK_TYPE type, IntPtr commanddata, IntPtr userdata);
	[Token(Token = "0x20000CE")]
	public enum PARAMETER_TYPE
	{
		[Token(Token = "0x4000436")]
		GAME_CONTROLLED,
		[Token(Token = "0x4000437")]
		AUTOMATIC_DISTANCE,
		[Token(Token = "0x4000438")]
		AUTOMATIC_EVENT_CONE_ANGLE,
		[Token(Token = "0x4000439")]
		AUTOMATIC_EVENT_ORIENTATION,
		[Token(Token = "0x400043A")]
		AUTOMATIC_DIRECTION,
		[Token(Token = "0x400043B")]
		AUTOMATIC_ELEVATION,
		[Token(Token = "0x400043C")]
		AUTOMATIC_LISTENER_ORIENTATION,
		[Token(Token = "0x400043D")]
		AUTOMATIC_SPEED,
		[Token(Token = "0x400043E")]
		MAX
	}
	[Token(Token = "0x20000CF")]
	[Flags]
	public enum PARAMETER_FLAGS : uint
	{
		[Token(Token = "0x4000440")]
		READONLY = 1u,
		[Token(Token = "0x4000441")]
		AUTOMATIC = 2u,
		[Token(Token = "0x4000442")]
		GLOBAL = 4u
	}
	[Token(Token = "0x20000D0")]
	public struct PARAMETER_ID
	{
		[Token(Token = "0x4000443")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public uint data1;

		[Token(Token = "0x4000444")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public uint data2;
	}
	[Token(Token = "0x20000D1")]
	public struct PARAMETER_DESCRIPTION
	{
		[Token(Token = "0x4000445")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x4000446")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public PARAMETER_ID id;

		[Token(Token = "0x4000447")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float minimum;

		[Token(Token = "0x4000448")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float maximum;

		[Token(Token = "0x4000449")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float defaultvalue;

		[Token(Token = "0x400044A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_TYPE type;

		[Token(Token = "0x400044B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PARAMETER_FLAGS flags;
	}
	[Token(Token = "0x20000D2")]
	internal enum LOAD_MEMORY_MODE
	{
		[Token(Token = "0x400044D")]
		LOAD_MEMORY,
		[Token(Token = "0x400044E")]
		LOAD_MEMORY_POINT
	}
	[Token(Token = "0x20000D3")]
	internal enum LOAD_MEMORY_ALIGNMENT
	{
		[Token(Token = "0x4000450")]
		VALUE = 0x20
	}
	[Token(Token = "0x20000D4")]
	public struct SOUND_INFO
	{
		[Token(Token = "0x4000451")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		[Token(Token = "0x4000452")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public MODE mode;

		[Token(Token = "0x4000453")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		[Token(Token = "0x4000454")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public int subsoundindex;

		[Token(Token = "0x17000006")]
		public string name
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x9AE7C8", Offset = "0x9AE7C8", VA = "0x9AE7C8")]
			get
			{
				return null;
			}
		}
	}
	[Token(Token = "0x20000D5")]
	public enum USER_PROPERTY_TYPE
	{
		[Token(Token = "0x4000456")]
		INTEGER,
		[Token(Token = "0x4000457")]
		BOOLEAN,
		[Token(Token = "0x4000458")]
		FLOAT,
		[Token(Token = "0x4000459")]
		STRING
	}
	[Token(Token = "0x20000D6")]
	public struct USER_PROPERTY
	{
		[Token(Token = "0x400045A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper name;

		[Token(Token = "0x400045B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public USER_PROPERTY_TYPE type;

		[Token(Token = "0x400045C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Union_IntBoolFloatString value;

		[Token(Token = "0x6000488")]
		[Address(RVA = "0x9AEBF4", Offset = "0x9AEBF4", VA = "0x9AEBF4")]
		public int intValue()
		{
			return default(int);
		}

		[Token(Token = "0x6000489")]
		[Address(RVA = "0x9AEC0C", Offset = "0x9AEC0C", VA = "0x9AEC0C")]
		public bool boolValue()
		{
			return default(bool);
		}

		[Token(Token = "0x600048A")]
		[Address(RVA = "0x9AEC30", Offset = "0x9AEC30", VA = "0x9AEC30")]
		public float floatValue()
		{
			return default(float);
		}

		[Token(Token = "0x600048B")]
		[Address(RVA = "0x9AEC4C", Offset = "0x9AEC4C", VA = "0x9AEC4C")]
		public string stringValue()
		{
			return null;
		}
	}
	[StructLayout(2)]
	[Token(Token = "0x20000D7")]
	internal struct Union_IntBoolFloatString
	{
		[Token(Token = "0x400045D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int intvalue;

		[Token(Token = "0x400045E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public bool boolvalue;

		[Token(Token = "0x400045F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float floatvalue;

		[Token(Token = "0x4000460")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper stringvalue;
	}
	[Token(Token = "0x20000D8")]
	[Flags]
	public enum INITFLAGS : uint
	{
		[Token(Token = "0x4000462")]
		NORMAL = 0u,
		[Token(Token = "0x4000463")]
		LIVEUPDATE = 1u,
		[Token(Token = "0x4000464")]
		ALLOW_MISSING_PLUGINS = 2u,
		[Token(Token = "0x4000465")]
		SYNCHRONOUS_UPDATE = 4u,
		[Token(Token = "0x4000466")]
		DEFERRED_CALLBACKS = 8u,
		[Token(Token = "0x4000467")]
		LOAD_FROM_UPDATE = 0x10u
	}
	[Token(Token = "0x20000D9")]
	[Flags]
	public enum LOAD_BANK_FLAGS : uint
	{
		[Token(Token = "0x4000469")]
		NORMAL = 0u,
		[Token(Token = "0x400046A")]
		NONBLOCKING = 1u,
		[Token(Token = "0x400046B")]
		DECOMPRESS_SAMPLES = 2u,
		[Token(Token = "0x400046C")]
		UNENCRYPTED = 4u
	}
	[Token(Token = "0x20000DA")]
	[Flags]
	public enum COMMANDCAPTURE_FLAGS : uint
	{
		[Token(Token = "0x400046E")]
		NORMAL = 0u,
		[Token(Token = "0x400046F")]
		FILEFLUSH = 1u,
		[Token(Token = "0x4000470")]
		SKIP_INITIAL_STATE = 2u
	}
	[Token(Token = "0x20000DB")]
	[Flags]
	public enum COMMANDREPLAY_FLAGS : uint
	{
		[Token(Token = "0x4000472")]
		NORMAL = 0u,
		[Token(Token = "0x4000473")]
		SKIP_CLEANUP = 1u,
		[Token(Token = "0x4000474")]
		FAST_FORWARD = 2u,
		[Token(Token = "0x4000475")]
		SKIP_BANK_LOAD = 4u
	}
	[Token(Token = "0x20000DC")]
	public enum PLAYBACK_STATE
	{
		[Token(Token = "0x4000477")]
		PLAYING,
		[Token(Token = "0x4000478")]
		SUSTAINING,
		[Token(Token = "0x4000479")]
		STOPPED,
		[Token(Token = "0x400047A")]
		STARTING,
		[Token(Token = "0x400047B")]
		STOPPING
	}
	[Token(Token = "0x20000DD")]
	public enum EVENT_PROPERTY
	{
		[Token(Token = "0x400047D")]
		CHANNELPRIORITY,
		[Token(Token = "0x400047E")]
		SCHEDULE_DELAY,
		[Token(Token = "0x400047F")]
		SCHEDULE_LOOKAHEAD,
		[Token(Token = "0x4000480")]
		MINIMUM_DISTANCE,
		[Token(Token = "0x4000481")]
		MAXIMUM_DISTANCE,
		[Token(Token = "0x4000482")]
		MAX
	}
	[Token(Token = "0x20000DE")]
	public struct PLUGIN_INSTANCE_PROPERTIES
	{
		[Token(Token = "0x4000483")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr name;

		[Token(Token = "0x4000484")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public IntPtr dsp;
	}
	[Token(Token = "0x20000DF")]
	[Flags]
	public enum EVENT_CALLBACK_TYPE : uint
	{
		[Token(Token = "0x4000486")]
		CREATED = 1u,
		[Token(Token = "0x4000487")]
		DESTROYED = 2u,
		[Token(Token = "0x4000488")]
		STARTING = 4u,
		[Token(Token = "0x4000489")]
		STARTED = 8u,
		[Token(Token = "0x400048A")]
		RESTARTED = 0x10u,
		[Token(Token = "0x400048B")]
		STOPPED = 0x20u,
		[Token(Token = "0x400048C")]
		START_FAILED = 0x40u,
		[Token(Token = "0x400048D")]
		CREATE_PROGRAMMER_SOUND = 0x80u,
		[Token(Token = "0x400048E")]
		DESTROY_PROGRAMMER_SOUND = 0x100u,
		[Token(Token = "0x400048F")]
		PLUGIN_CREATED = 0x200u,
		[Token(Token = "0x4000490")]
		PLUGIN_DESTROYED = 0x400u,
		[Token(Token = "0x4000491")]
		TIMELINE_MARKER = 0x800u,
		[Token(Token = "0x4000492")]
		TIMELINE_BEAT = 0x1000u,
		[Token(Token = "0x4000493")]
		SOUND_PLAYED = 0x2000u,
		[Token(Token = "0x4000494")]
		SOUND_STOPPED = 0x4000u,
		[Token(Token = "0x4000495")]
		REAL_TO_VIRTUAL = 0x8000u,
		[Token(Token = "0x4000496")]
		VIRTUAL_TO_REAL = 0x10000u,
		[Token(Token = "0x4000497")]
		ALL = uint.MaxValue
	}
	[Token(Token = "0x20000E0")]
	public delegate RESULT EVENT_CALLBACK(EVENT_CALLBACK_TYPE type, EventInstance _event, IntPtr parameters);
	[Token(Token = "0x20000E1")]
	public delegate RESULT COMMANDREPLAY_FRAME_CALLBACK(CommandReplay replay, int commandindex, float currenttime, IntPtr userdata);
	[Token(Token = "0x20000E2")]
	public delegate RESULT COMMANDREPLAY_LOAD_BANK_CALLBACK(CommandReplay replay, int commandindex, Guid bankguid, StringWrapper bankfilename, LOAD_BANK_FLAGS flags, out Bank bank, IntPtr userdata);
	[Token(Token = "0x20000E3")]
	public delegate RESULT COMMANDREPLAY_CREATE_INSTANCE_CALLBACK(CommandReplay replay, int commandindex, EventDescription eventdescription, out EventInstance instance, IntPtr userdata);
	[Token(Token = "0x20000E4")]
	public enum INSTANCETYPE
	{
		[Token(Token = "0x4000499")]
		NONE,
		[Token(Token = "0x400049A")]
		SYSTEM,
		[Token(Token = "0x400049B")]
		EVENTDESCRIPTION,
		[Token(Token = "0x400049C")]
		EVENTINSTANCE,
		[Token(Token = "0x400049D")]
		PARAMETERINSTANCE,
		[Token(Token = "0x400049E")]
		BUS,
		[Token(Token = "0x400049F")]
		VCA,
		[Token(Token = "0x40004A0")]
		BANK,
		[Token(Token = "0x40004A1")]
		COMMANDREPLAY
	}
	[Token(Token = "0x20000E5")]
	public struct COMMAND_INFO
	{
		[Token(Token = "0x40004A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public StringWrapper commandname;

		[Token(Token = "0x40004A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int parentcommandindex;

		[Token(Token = "0x40004A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public int framenumber;

		[Token(Token = "0x40004A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float frametime;

		[Token(Token = "0x40004A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public INSTANCETYPE instancetype;

		[Token(Token = "0x40004A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public INSTANCETYPE outputtype;

		[Token(Token = "0x40004A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public uint instancehandle;

		[Token(Token = "0x40004A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public uint outputhandle;
	}
	[Token(Token = "0x20000E6")]
	public struct Util
	{
		[Token(Token = "0x600049C")]
		[Address(RVA = "0x1201724", Offset = "0x1201724", VA = "0x1201724")]
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600049D")]
		[Address(RVA = "0x1201874", Offset = "0x1201874", VA = "0x1201874")]
		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
	[Token(Token = "0x20000E7")]
	public struct System
	{
		[Token(Token = "0x40004AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600049E")]
		[Address(RVA = "0x11FD4A8", Offset = "0x11FD4A8", VA = "0x11FD4A8")]
		public static RESULT create(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0x9AE7EC", Offset = "0x9AE7EC", VA = "0x9AE7EC")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A0")]
		[Address(RVA = "0x9AE820", Offset = "0x9AE820", VA = "0x9AE820")]
		public RESULT setAdvancedSettings(ADVANCEDSETTINGS settings, string encryptionKey)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0x9AE854", Offset = "0x9AE854", VA = "0x9AE854")]
		public RESULT getAdvancedSettings(out ADVANCEDSETTINGS settings)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0x9AE85C", Offset = "0x9AE85C", VA = "0x9AE85C")]
		public RESULT initialize(int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0x9AE864", Offset = "0x9AE864", VA = "0x9AE864")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A4")]
		[Address(RVA = "0x9AE86C", Offset = "0x9AE86C", VA = "0x9AE86C")]
		public RESULT update()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0x9AE874", Offset = "0x9AE874", VA = "0x9AE874")]
		public RESULT getCoreSystem(out FMOD.System coresystem)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A6")]
		[Address(RVA = "0x9AE87C", Offset = "0x9AE87C", VA = "0x9AE87C")]
		public RESULT getEvent(string path, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A7")]
		[Address(RVA = "0x9AE884", Offset = "0x9AE884", VA = "0x9AE884")]
		public RESULT getBus(string path, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A8")]
		[Address(RVA = "0x9AE88C", Offset = "0x9AE88C", VA = "0x9AE88C")]
		public RESULT getVCA(string path, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004A9")]
		[Address(RVA = "0x9AE894", Offset = "0x9AE894", VA = "0x9AE894")]
		public RESULT getBank(string path, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AA")]
		[Address(RVA = "0x9AE89C", Offset = "0x9AE89C", VA = "0x9AE89C")]
		public RESULT getEventByID(Guid id, out EventDescription _event)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AB")]
		[Address(RVA = "0x9AE8C8", Offset = "0x9AE8C8", VA = "0x9AE8C8")]
		public RESULT getBusByID(Guid id, out Bus bus)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AC")]
		[Address(RVA = "0x9AE8F4", Offset = "0x9AE8F4", VA = "0x9AE8F4")]
		public RESULT getVCAByID(Guid id, out VCA vca)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AD")]
		[Address(RVA = "0x9AE920", Offset = "0x9AE920", VA = "0x9AE920")]
		public RESULT getBankByID(Guid id, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AE")]
		[Address(RVA = "0x9AE94C", Offset = "0x9AE94C", VA = "0x9AE94C")]
		public RESULT getSoundInfo(string key, out SOUND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x9AE954", Offset = "0x9AE954", VA = "0x9AE954")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B0")]
		[Address(RVA = "0x9AE95C", Offset = "0x9AE95C", VA = "0x9AE95C")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B1")]
		[Address(RVA = "0x9AE964", Offset = "0x9AE964", VA = "0x9AE964")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B2")]
		[Address(RVA = "0x9AE98C", Offset = "0x9AE98C", VA = "0x9AE98C")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x9AE994", Offset = "0x9AE994", VA = "0x9AE994")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x9AE9A0", Offset = "0x9AE9A0", VA = "0x9AE9A0")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x9AE9AC", Offset = "0x9AE9AC", VA = "0x9AE9AC")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x9AE9D4", Offset = "0x9AE9D4", VA = "0x9AE9D4")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x9AE9DC", Offset = "0x9AE9DC", VA = "0x9AE9DC")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x9AE9E8", Offset = "0x9AE9E8", VA = "0x9AE9E8")]
		public RESULT lookupID(string path, out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x9AE9F0", Offset = "0x9AE9F0", VA = "0x9AE9F0")]
		public RESULT lookupPath(Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x9AE9F8", Offset = "0x9AE9F8", VA = "0x9AE9F8")]
		public RESULT getNumListeners(out int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x9AEA00", Offset = "0x9AEA00", VA = "0x9AEA00")]
		public RESULT setNumListeners(int numlisteners)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x9AEA08", Offset = "0x9AEA08", VA = "0x9AEA08")]
		public RESULT getListenerAttributes(int listener, out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x9AEA10", Offset = "0x9AEA10", VA = "0x9AEA10")]
		public RESULT setListenerAttributes(int listener, ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x9AEA4C", Offset = "0x9AEA4C", VA = "0x9AEA4C")]
		public RESULT getListenerWeight(int listener, out float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x9AEA54", Offset = "0x9AEA54", VA = "0x9AEA54")]
		public RESULT setListenerWeight(int listener, float weight)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x9AEA5C", Offset = "0x9AEA5C", VA = "0x9AEA5C")]
		public RESULT loadBankFile(string filename, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x9AEA64", Offset = "0x9AEA64", VA = "0x9AEA64")]
		public RESULT loadBankMemory(byte[] buffer, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x9AEA6C", Offset = "0x9AEA6C", VA = "0x9AEA6C")]
		public RESULT loadBankCustom(BANK_INFO info, LOAD_BANK_FLAGS flags, out Bank bank)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x9AEAB0", Offset = "0x9AEAB0", VA = "0x9AEAB0")]
		public RESULT unloadAll()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x9AEAB8", Offset = "0x9AEAB8", VA = "0x9AEAB8")]
		public RESULT flushCommands()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x9AEAC0", Offset = "0x9AEAC0", VA = "0x9AEAC0")]
		public RESULT flushSampleLoading()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x9AEAC8", Offset = "0x9AEAC8", VA = "0x9AEAC8")]
		public RESULT startCommandCapture(string filename, COMMANDCAPTURE_FLAGS flags)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x9AEAD0", Offset = "0x9AEAD0", VA = "0x9AEAD0")]
		public RESULT stopCommandCapture()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x9AEAD8", Offset = "0x9AEAD8", VA = "0x9AEAD8")]
		public RESULT loadCommandReplay(string filename, COMMANDREPLAY_FLAGS flags, out CommandReplay replay)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x9AEAE0", Offset = "0x9AEAE0", VA = "0x9AEAE0")]
		public RESULT getBankCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x9AEAE8", Offset = "0x9AEAE8", VA = "0x9AEAE8")]
		public RESULT getBankList(out Bank[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x9AEAF0", Offset = "0x9AEAF0", VA = "0x9AEAF0")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x9AEAF8", Offset = "0x9AEAF8", VA = "0x9AEAF8")]
		public RESULT getParameterDescriptionList(out PARAMETER_DESCRIPTION[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x9AEB00", Offset = "0x9AEB00", VA = "0x9AEB00")]
		public RESULT getCPUUsage(out CPU_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x9AEB08", Offset = "0x9AEB08", VA = "0x9AEB08")]
		public RESULT getBufferUsage(out BUFFER_USAGE usage)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x9AEB10", Offset = "0x9AEB10", VA = "0x9AEB10")]
		public RESULT resetBufferUsage()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x9AEB18", Offset = "0x9AEB18", VA = "0x9AEB18")]
		public RESULT setCallback(SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask = SYSTEM_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x9AEB20", Offset = "0x9AEB20", VA = "0x9AEB20")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x9AEB28", Offset = "0x9AEB28", VA = "0x9AEB28")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x11FD4B4", Offset = "0x11FD4B4", VA = "0x11FD4B4")]
		private static extern RESULT FMOD_Studio_System_Create(out IntPtr system, uint headerversion);

		[PreserveSig]
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x12014FC", Offset = "0x12014FC", VA = "0x12014FC")]
		private static extern bool FMOD_Studio_System_IsValid(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x11FD620", Offset = "0x11FD620", VA = "0x11FD620")]
		private static extern RESULT FMOD_Studio_System_SetAdvancedSettings(IntPtr system, ref ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x11FD910", Offset = "0x11FD910", VA = "0x11FD910")]
		private static extern RESULT FMOD_Studio_System_GetAdvancedSettings(IntPtr system, out ADVANCEDSETTINGS settings);

		[PreserveSig]
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x11FD9C0", Offset = "0x11FD9C0", VA = "0x11FD9C0")]
		private static extern RESULT FMOD_Studio_System_Initialize(IntPtr system, int maxchannels, INITFLAGS studioflags, FMOD.INITFLAGS flags, IntPtr extradriverdata);

		[PreserveSig]
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x11FDA90", Offset = "0x11FDA90", VA = "0x11FDA90")]
		private static extern RESULT FMOD_Studio_System_Release(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x11FDB30", Offset = "0x11FDB30", VA = "0x11FDB30")]
		private static extern RESULT FMOD_Studio_System_Update(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x11FDBD0", Offset = "0x11FDBD0", VA = "0x11FDBD0")]
		private static extern RESULT FMOD_Studio_System_GetCoreSystem(IntPtr system, out IntPtr coresystem);

		[PreserveSig]
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x11FDDD8", Offset = "0x11FDDD8", VA = "0x11FDDD8")]
		private static extern RESULT FMOD_Studio_System_GetEvent(IntPtr system, byte[] path, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x11FDFF0", Offset = "0x11FDFF0", VA = "0x11FDFF0")]
		private static extern RESULT FMOD_Studio_System_GetBus(IntPtr system, byte[] path, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x11FE208", Offset = "0x11FE208", VA = "0x11FE208")]
		private static extern RESULT FMOD_Studio_System_GetVCA(IntPtr system, byte[] path, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x11FE420", Offset = "0x11FE420", VA = "0x11FE420")]
		private static extern RESULT FMOD_Studio_System_GetBank(IntPtr system, byte[] path, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x11FE504", Offset = "0x11FE504", VA = "0x11FE504")]
		private static extern RESULT FMOD_Studio_System_GetEventByID(IntPtr system, ref Guid id, out IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x11FE5E0", Offset = "0x11FE5E0", VA = "0x11FE5E0")]
		private static extern RESULT FMOD_Studio_System_GetBusByID(IntPtr system, ref Guid id, out IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x11FE6BC", Offset = "0x11FE6BC", VA = "0x11FE6BC")]
		private static extern RESULT FMOD_Studio_System_GetVCAByID(IntPtr system, ref Guid id, out IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x11FE798", Offset = "0x11FE798", VA = "0x11FE798")]
		private static extern RESULT FMOD_Studio_System_GetBankByID(IntPtr system, ref Guid id, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x11FE9A8", Offset = "0x11FE9A8", VA = "0x11FE9A8")]
		private static extern RESULT FMOD_Studio_System_GetSoundInfo(IntPtr system, byte[] key, out SOUND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x11FEC64", Offset = "0x11FEC64", VA = "0x11FEC64")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByName(IntPtr system, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x11FED24", Offset = "0x11FED24", VA = "0x11FED24")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionByID(IntPtr system, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x11FEE04", Offset = "0x11FEE04", VA = "0x11FEE04")]
		private static extern RESULT FMOD_Studio_System_GetParameterByID(IntPtr system, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x11FEED0", Offset = "0x11FEED0", VA = "0x11FEED0")]
		private static extern RESULT FMOD_Studio_System_SetParameterByID(IntPtr system, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x11FEF9C", Offset = "0x11FEF9C", VA = "0x11FEF9C")]
		private static extern RESULT FMOD_Studio_System_SetParametersByIDs(IntPtr system, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x11FF208", Offset = "0x11FF208", VA = "0x11FF208")]
		private static extern RESULT FMOD_Studio_System_GetParameterByName(IntPtr system, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x11FF440", Offset = "0x11FF440", VA = "0x11FF440")]
		private static extern RESULT FMOD_Studio_System_SetParameterByName(IntPtr system, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x11FF668", Offset = "0x11FF668", VA = "0x11FF668")]
		private static extern RESULT FMOD_Studio_System_LookupID(IntPtr system, byte[] path, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x11FF974", Offset = "0x11FF974", VA = "0x11FF974")]
		private static extern RESULT FMOD_Studio_System_LookupPath(IntPtr system, ref Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x11FFA44", Offset = "0x11FFA44", VA = "0x11FFA44")]
		private static extern RESULT FMOD_Studio_System_GetNumListeners(IntPtr system, out int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x11FFAF4", Offset = "0x11FFAF4", VA = "0x11FFAF4")]
		private static extern RESULT FMOD_Studio_System_SetNumListeners(IntPtr system, int numlisteners);

		[PreserveSig]
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x11FFBA4", Offset = "0x11FFBA4", VA = "0x11FFBA4")]
		private static extern RESULT FMOD_Studio_System_GetListenerAttributes(IntPtr system, int listener, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x11FFC5C", Offset = "0x11FFC5C", VA = "0x11FFC5C")]
		private static extern RESULT FMOD_Studio_System_SetListenerAttributes(IntPtr system, int listener, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x11FFD14", Offset = "0x11FFD14", VA = "0x11FFD14")]
		private static extern RESULT FMOD_Studio_System_GetListenerWeight(IntPtr system, int listener, out float weight);

		[PreserveSig]
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x11FFDCC", Offset = "0x11FFDCC", VA = "0x11FFDCC")]
		private static extern RESULT FMOD_Studio_System_SetListenerWeight(IntPtr system, int listener, float weight);

		[PreserveSig]
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x11FFFF4", Offset = "0x11FFFF4", VA = "0x11FFFF4")]
		private static extern RESULT FMOD_Studio_System_LoadBankFile(IntPtr system, byte[] filename, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x1200150", Offset = "0x1200150", VA = "0x1200150")]
		private static extern RESULT FMOD_Studio_System_LoadBankMemory(IntPtr system, IntPtr buffer, int length, LOAD_MEMORY_MODE mode, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1200310", Offset = "0x1200310", VA = "0x1200310")]
		private static extern RESULT FMOD_Studio_System_LoadBankCustom(IntPtr system, ref BANK_INFO info, LOAD_BANK_FLAGS flags, out IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x120043C", Offset = "0x120043C", VA = "0x120043C")]
		private static extern RESULT FMOD_Studio_System_UnloadAll(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x12004DC", Offset = "0x12004DC", VA = "0x12004DC")]
		private static extern RESULT FMOD_Studio_System_FlushCommands(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x120057C", Offset = "0x120057C", VA = "0x120057C")]
		private static extern RESULT FMOD_Studio_System_FlushSampleLoading(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x1200774", Offset = "0x1200774", VA = "0x1200774")]
		private static extern RESULT FMOD_Studio_System_StartCommandCapture(IntPtr system, byte[] filename, COMMANDCAPTURE_FLAGS flags);

		[PreserveSig]
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x1200834", Offset = "0x1200834", VA = "0x1200834")]
		private static extern RESULT FMOD_Studio_System_StopCommandCapture(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x1200A3C", Offset = "0x1200A3C", VA = "0x1200A3C")]
		private static extern RESULT FMOD_Studio_System_LoadCommandReplay(IntPtr system, byte[] filename, COMMANDREPLAY_FLAGS flags, out IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x1200B0C", Offset = "0x1200B0C", VA = "0x1200B0C")]
		private static extern RESULT FMOD_Studio_System_GetBankCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1200D0C", Offset = "0x1200D0C", VA = "0x1200D0C")]
		private static extern RESULT FMOD_Studio_System_GetBankList(IntPtr system, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x1200DDC", Offset = "0x1200DDC", VA = "0x1200DDC")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionCount(IntPtr system, out int count);

		[PreserveSig]
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x1200F78", Offset = "0x1200F78", VA = "0x1200F78")]
		private static extern RESULT FMOD_Studio_System_GetParameterDescriptionList(IntPtr system, [Out] PARAMETER_DESCRIPTION[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x12010E4", Offset = "0x12010E4", VA = "0x12010E4")]
		private static extern RESULT FMOD_Studio_System_GetCPUUsage(IntPtr system, out CPU_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x1201194", Offset = "0x1201194", VA = "0x1201194")]
		private static extern RESULT FMOD_Studio_System_GetBufferUsage(IntPtr system, out BUFFER_USAGE usage);

		[PreserveSig]
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1201244", Offset = "0x1201244", VA = "0x1201244")]
		private static extern RESULT FMOD_Studio_System_ResetBufferUsage(IntPtr system);

		[PreserveSig]
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x12012E4", Offset = "0x12012E4", VA = "0x12012E4")]
		private static extern RESULT FMOD_Studio_System_SetCallback(IntPtr system, SYSTEM_CALLBACK callback, SYSTEM_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x12013A4", Offset = "0x12013A4", VA = "0x12013A4")]
		private static extern RESULT FMOD_Studio_System_GetUserData(IntPtr system, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x1201454", Offset = "0x1201454", VA = "0x1201454")]
		private static extern RESULT FMOD_Studio_System_SetUserData(IntPtr system, IntPtr userdata);

		[Token(Token = "0x6000506")]
		[Address(RVA = "0x9AEB30", Offset = "0x9AEB30", VA = "0x9AEB30")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000507")]
		[Address(RVA = "0x9AEB38", Offset = "0x9AEB38", VA = "0x9AEB38")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x9AEB7C", Offset = "0x9AEB7C", VA = "0x9AEB7C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E8")]
	public struct EventDescription
	{
		[Token(Token = "0x40004AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x9AE35C", Offset = "0x9AE35C", VA = "0x9AE35C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x9AE364", Offset = "0x9AE364", VA = "0x9AE364")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x9AE36C", Offset = "0x9AE36C", VA = "0x9AE36C")]
		public RESULT getParameterDescriptionCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x9AE374", Offset = "0x9AE374", VA = "0x9AE374")]
		public RESULT getParameterDescriptionByIndex(int index, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x9AE37C", Offset = "0x9AE37C", VA = "0x9AE37C")]
		public RESULT getParameterDescriptionByName(string name, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050E")]
		[Address(RVA = "0x9AE384", Offset = "0x9AE384", VA = "0x9AE384")]
		public RESULT getParameterDescriptionByID(PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600050F")]
		[Address(RVA = "0x9AE38C", Offset = "0x9AE38C", VA = "0x9AE38C")]
		public RESULT getUserPropertyCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000510")]
		[Address(RVA = "0x9AE394", Offset = "0x9AE394", VA = "0x9AE394")]
		public RESULT getUserPropertyByIndex(int index, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000511")]
		[Address(RVA = "0x9AE39C", Offset = "0x9AE39C", VA = "0x9AE39C")]
		public RESULT getUserProperty(string name, out USER_PROPERTY property)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000512")]
		[Address(RVA = "0x9AE3A4", Offset = "0x9AE3A4", VA = "0x9AE3A4")]
		public RESULT getLength(out int length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000513")]
		[Address(RVA = "0x9AE3AC", Offset = "0x9AE3AC", VA = "0x9AE3AC")]
		public RESULT getMinimumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000514")]
		[Address(RVA = "0x9AE3B4", Offset = "0x9AE3B4", VA = "0x9AE3B4")]
		public RESULT getMaximumDistance(out float distance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000515")]
		[Address(RVA = "0x9AE3BC", Offset = "0x9AE3BC", VA = "0x9AE3BC")]
		public RESULT getSoundSize(out float size)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000516")]
		[Address(RVA = "0x9AE3C4", Offset = "0x9AE3C4", VA = "0x9AE3C4")]
		public RESULT isSnapshot(out bool snapshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000517")]
		[Address(RVA = "0x9AE3CC", Offset = "0x9AE3CC", VA = "0x9AE3CC")]
		public RESULT isOneshot(out bool oneshot)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000518")]
		[Address(RVA = "0x9AE3D4", Offset = "0x9AE3D4", VA = "0x9AE3D4")]
		public RESULT isStream(out bool isStream)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000519")]
		[Address(RVA = "0x9AE3DC", Offset = "0x9AE3DC", VA = "0x9AE3DC")]
		public RESULT is3D(out bool is3D)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051A")]
		[Address(RVA = "0x9AE3E4", Offset = "0x9AE3E4", VA = "0x9AE3E4")]
		public RESULT hasCue(out bool cue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051B")]
		[Address(RVA = "0x9AE3EC", Offset = "0x9AE3EC", VA = "0x9AE3EC")]
		public RESULT createInstance(out EventInstance instance)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051C")]
		[Address(RVA = "0x9AE3F4", Offset = "0x9AE3F4", VA = "0x9AE3F4")]
		public RESULT getInstanceCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051D")]
		[Address(RVA = "0x9AE3FC", Offset = "0x9AE3FC", VA = "0x9AE3FC")]
		public RESULT getInstanceList(out EventInstance[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051E")]
		[Address(RVA = "0x9AE404", Offset = "0x9AE404", VA = "0x9AE404")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600051F")]
		[Address(RVA = "0x9AE40C", Offset = "0x9AE40C", VA = "0x9AE40C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000520")]
		[Address(RVA = "0x9AE414", Offset = "0x9AE414", VA = "0x9AE414")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000521")]
		[Address(RVA = "0x9AE41C", Offset = "0x9AE41C", VA = "0x9AE41C")]
		public RESULT releaseAllInstances()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000522")]
		[Address(RVA = "0x9AE424", Offset = "0x9AE424", VA = "0x9AE424")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000523")]
		[Address(RVA = "0x9AE42C", Offset = "0x9AE42C", VA = "0x9AE42C")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000524")]
		[Address(RVA = "0x9AE434", Offset = "0x9AE434", VA = "0x9AE434")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x11FB244", Offset = "0x11FB244", VA = "0x11FB244")]
		private static extern bool FMOD_Studio_EventDescription_IsValid(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x11F97B8", Offset = "0x11F97B8", VA = "0x11F97B8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetID(IntPtr eventdescription, out Guid id);

		[PreserveSig]
		[Token(Token = "0x6000527")]
		[Address(RVA = "0x11F9AA8", Offset = "0x11F9AA8", VA = "0x11F9AA8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetPath(IntPtr eventdescription, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x6000528")]
		[Address(RVA = "0x11F9B70", Offset = "0x11F9B70", VA = "0x11F9B70")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x6000529")]
		[Address(RVA = "0x11F9C20", Offset = "0x11F9C20", VA = "0x11F9C20")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByIndex(IntPtr eventdescription, int index, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600052A")]
		[Address(RVA = "0x11F9E30", Offset = "0x11F9E30", VA = "0x11F9E30")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByName(IntPtr eventdescription, byte[] name, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600052B")]
		[Address(RVA = "0x11F9EF0", Offset = "0x11F9EF0", VA = "0x11F9EF0")]
		private static extern RESULT FMOD_Studio_EventDescription_GetParameterDescriptionByID(IntPtr eventdescription, PARAMETER_ID id, out PARAMETER_DESCRIPTION parameter);

		[PreserveSig]
		[Token(Token = "0x600052C")]
		[Address(RVA = "0x11F9FA8", Offset = "0x11F9FA8", VA = "0x11F9FA8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x600052D")]
		[Address(RVA = "0x11FA058", Offset = "0x11FA058", VA = "0x11FA058")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserPropertyByIndex(IntPtr eventdescription, int index, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600052E")]
		[Address(RVA = "0x11FA298", Offset = "0x11FA298", VA = "0x11FA298")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserProperty(IntPtr eventdescription, byte[] name, out USER_PROPERTY property);

		[PreserveSig]
		[Token(Token = "0x600052F")]
		[Address(RVA = "0x11FA388", Offset = "0x11FA388", VA = "0x11FA388")]
		private static extern RESULT FMOD_Studio_EventDescription_GetLength(IntPtr eventdescription, out int length);

		[PreserveSig]
		[Token(Token = "0x6000530")]
		[Address(RVA = "0x11FA438", Offset = "0x11FA438", VA = "0x11FA438")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMinimumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000531")]
		[Address(RVA = "0x11FA4E8", Offset = "0x11FA4E8", VA = "0x11FA4E8")]
		private static extern RESULT FMOD_Studio_EventDescription_GetMaximumDistance(IntPtr eventdescription, out float distance);

		[PreserveSig]
		[Token(Token = "0x6000532")]
		[Address(RVA = "0x11FA598", Offset = "0x11FA598", VA = "0x11FA598")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSoundSize(IntPtr eventdescription, out float size);

		[PreserveSig]
		[Token(Token = "0x6000533")]
		[Address(RVA = "0x11FA648", Offset = "0x11FA648", VA = "0x11FA648")]
		private static extern RESULT FMOD_Studio_EventDescription_IsSnapshot(IntPtr eventdescription, out bool snapshot);

		[PreserveSig]
		[Token(Token = "0x6000534")]
		[Address(RVA = "0x11FA70C", Offset = "0x11FA70C", VA = "0x11FA70C")]
		private static extern RESULT FMOD_Studio_EventDescription_IsOneshot(IntPtr eventdescription, out bool oneshot);

		[PreserveSig]
		[Token(Token = "0x6000535")]
		[Address(RVA = "0x11FA7D0", Offset = "0x11FA7D0", VA = "0x11FA7D0")]
		private static extern RESULT FMOD_Studio_EventDescription_IsStream(IntPtr eventdescription, out bool isStream);

		[PreserveSig]
		[Token(Token = "0x6000536")]
		[Address(RVA = "0x11FA894", Offset = "0x11FA894", VA = "0x11FA894")]
		private static extern RESULT FMOD_Studio_EventDescription_Is3D(IntPtr eventdescription, out bool is3D);

		[PreserveSig]
		[Token(Token = "0x6000537")]
		[Address(RVA = "0x11FA958", Offset = "0x11FA958", VA = "0x11FA958")]
		private static extern RESULT FMOD_Studio_EventDescription_HasCue(IntPtr eventdescription, out bool cue);

		[PreserveSig]
		[Token(Token = "0x6000538")]
		[Address(RVA = "0x11FAA1C", Offset = "0x11FAA1C", VA = "0x11FAA1C")]
		private static extern RESULT FMOD_Studio_EventDescription_CreateInstance(IntPtr eventdescription, out IntPtr instance);

		[PreserveSig]
		[Token(Token = "0x6000539")]
		[Address(RVA = "0x11FAACC", Offset = "0x11FAACC", VA = "0x11FAACC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceCount(IntPtr eventdescription, out int count);

		[PreserveSig]
		[Token(Token = "0x600053A")]
		[Address(RVA = "0x11FACCC", Offset = "0x11FACCC", VA = "0x11FACCC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetInstanceList(IntPtr eventdescription, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x600053B")]
		[Address(RVA = "0x11FAD9C", Offset = "0x11FAD9C", VA = "0x11FAD9C")]
		private static extern RESULT FMOD_Studio_EventDescription_LoadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053C")]
		[Address(RVA = "0x11FAE3C", Offset = "0x11FAE3C", VA = "0x11FAE3C")]
		private static extern RESULT FMOD_Studio_EventDescription_UnloadSampleData(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053D")]
		[Address(RVA = "0x11FAEDC", Offset = "0x11FAEDC", VA = "0x11FAEDC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetSampleLoadingState(IntPtr eventdescription, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x600053E")]
		[Address(RVA = "0x11FAF8C", Offset = "0x11FAF8C", VA = "0x11FAF8C")]
		private static extern RESULT FMOD_Studio_EventDescription_ReleaseAllInstances(IntPtr eventdescription);

		[PreserveSig]
		[Token(Token = "0x600053F")]
		[Address(RVA = "0x11FB02C", Offset = "0x11FB02C", VA = "0x11FB02C")]
		private static extern RESULT FMOD_Studio_EventDescription_SetCallback(IntPtr eventdescription, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000540")]
		[Address(RVA = "0x11FB0EC", Offset = "0x11FB0EC", VA = "0x11FB0EC")]
		private static extern RESULT FMOD_Studio_EventDescription_GetUserData(IntPtr eventdescription, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000541")]
		[Address(RVA = "0x11FB19C", Offset = "0x11FB19C", VA = "0x11FB19C")]
		private static extern RESULT FMOD_Studio_EventDescription_SetUserData(IntPtr eventdescription, IntPtr userdata);

		[Token(Token = "0x6000542")]
		[Address(RVA = "0x9AE45C", Offset = "0x9AE45C", VA = "0x9AE45C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000543")]
		[Address(RVA = "0x9AE464", Offset = "0x9AE464", VA = "0x9AE464")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x6000544")]
		[Address(RVA = "0x9AE4A8", Offset = "0x9AE4A8", VA = "0x9AE4A8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000E9")]
	public struct EventInstance
	{
		[Token(Token = "0x40004AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x6000545")]
		[Address(RVA = "0x9AE4B0", Offset = "0x9AE4B0", VA = "0x9AE4B0")]
		public RESULT getDescription(out EventDescription description)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000546")]
		[Address(RVA = "0x9AE4B8", Offset = "0x9AE4B8", VA = "0x9AE4B8")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000547")]
		[Address(RVA = "0x9AE4E0", Offset = "0x9AE4E0", VA = "0x9AE4E0")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000548")]
		[Address(RVA = "0x9AE4E8", Offset = "0x9AE4E8", VA = "0x9AE4E8")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000549")]
		[Address(RVA = "0x9AE4F0", Offset = "0x9AE4F0", VA = "0x9AE4F0")]
		public RESULT getPitch(out float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054A")]
		[Address(RVA = "0x9AE518", Offset = "0x9AE518", VA = "0x9AE518")]
		public RESULT getPitch(out float pitch, out float finalpitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054B")]
		[Address(RVA = "0x9AE520", Offset = "0x9AE520", VA = "0x9AE520")]
		public RESULT setPitch(float pitch)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054C")]
		[Address(RVA = "0x9AE528", Offset = "0x9AE528", VA = "0x9AE528")]
		public RESULT get3DAttributes(out ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054D")]
		[Address(RVA = "0x9AE530", Offset = "0x9AE530", VA = "0x9AE530")]
		public RESULT set3DAttributes(ATTRIBUTES_3D attributes)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054E")]
		[Address(RVA = "0x9AE56C", Offset = "0x9AE56C", VA = "0x9AE56C")]
		public RESULT getListenerMask(out uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600054F")]
		[Address(RVA = "0x9AE574", Offset = "0x9AE574", VA = "0x9AE574")]
		public RESULT setListenerMask(uint mask)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000550")]
		[Address(RVA = "0x9AE57C", Offset = "0x9AE57C", VA = "0x9AE57C")]
		public RESULT getProperty(EVENT_PROPERTY index, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x9AE584", Offset = "0x9AE584", VA = "0x9AE584")]
		public RESULT setProperty(EVENT_PROPERTY index, float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x9AE58C", Offset = "0x9AE58C", VA = "0x9AE58C")]
		public RESULT getReverbLevel(int index, out float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000553")]
		[Address(RVA = "0x9AE594", Offset = "0x9AE594", VA = "0x9AE594")]
		public RESULT setReverbLevel(int index, float level)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000554")]
		[Address(RVA = "0x9AE59C", Offset = "0x9AE59C", VA = "0x9AE59C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0x9AE5A4", Offset = "0x9AE5A4", VA = "0x9AE5A4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000556")]
		[Address(RVA = "0x9AE5B0", Offset = "0x9AE5B0", VA = "0x9AE5B0")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000557")]
		[Address(RVA = "0x9AE5B8", Offset = "0x9AE5B8", VA = "0x9AE5B8")]
		public RESULT stop(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000558")]
		[Address(RVA = "0x9AE5C0", Offset = "0x9AE5C0", VA = "0x9AE5C0")]
		public RESULT getTimelinePosition(out int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000559")]
		[Address(RVA = "0x9AE5C8", Offset = "0x9AE5C8", VA = "0x9AE5C8")]
		public RESULT setTimelinePosition(int position)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055A")]
		[Address(RVA = "0x9AE5D0", Offset = "0x9AE5D0", VA = "0x9AE5D0")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x9AE5D8", Offset = "0x9AE5D8", VA = "0x9AE5D8")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x9AE5E0", Offset = "0x9AE5E0", VA = "0x9AE5E0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x9AE5E8", Offset = "0x9AE5E8", VA = "0x9AE5E8")]
		public RESULT isVirtual(out bool virtualstate)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x9AE5F0", Offset = "0x9AE5F0", VA = "0x9AE5F0")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x9AE618", Offset = "0x9AE618", VA = "0x9AE618")]
		public RESULT getParameterByID(PARAMETER_ID id, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x9AE620", Offset = "0x9AE620", VA = "0x9AE620")]
		public RESULT setParameterByID(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x9AE62C", Offset = "0x9AE62C", VA = "0x9AE62C")]
		public RESULT setParametersByIDs(PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x9AE638", Offset = "0x9AE638", VA = "0x9AE638")]
		public RESULT getParameterByName(string name, out float value)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x9AE660", Offset = "0x9AE660", VA = "0x9AE660")]
		public RESULT getParameterByName(string name, out float value, out float finalvalue)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x9AE668", Offset = "0x9AE668", VA = "0x9AE668")]
		public RESULT setParameterByName(string name, float value, bool ignoreseekspeed = false)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x9AE674", Offset = "0x9AE674", VA = "0x9AE674")]
		public RESULT triggerCue()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x9AE67C", Offset = "0x9AE67C", VA = "0x9AE67C")]
		public RESULT setCallback(EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask = EVENT_CALLBACK_TYPE.ALL)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x9AE684", Offset = "0x9AE684", VA = "0x9AE684")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x9AE68C", Offset = "0x9AE68C", VA = "0x9AE68C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x6000569")]
		[Address(RVA = "0x11FCE0C", Offset = "0x11FCE0C", VA = "0x11FCE0C")]
		private static extern bool FMOD_Studio_EventInstance_IsValid(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600056A")]
		[Address(RVA = "0x11FB3B4", Offset = "0x11FB3B4", VA = "0x11FB3B4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetDescription(IntPtr _event, out IntPtr description);

		[PreserveSig]
		[Token(Token = "0x600056B")]
		[Address(RVA = "0x11FB48C", Offset = "0x11FB48C", VA = "0x11FB48C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetVolume(IntPtr _event, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x11FB544", Offset = "0x11FB544", VA = "0x11FB544")]
		private static extern RESULT FMOD_Studio_EventInstance_SetVolume(IntPtr _event, float volume);

		[PreserveSig]
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x11FB61C", Offset = "0x11FB61C", VA = "0x11FB61C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPitch(IntPtr _event, out float pitch, out float finalpitch);

		[PreserveSig]
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x11FB6D4", Offset = "0x11FB6D4", VA = "0x11FB6D4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPitch(IntPtr _event, float pitch);

		[PreserveSig]
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x11FB784", Offset = "0x11FB784", VA = "0x11FB784")]
		private static extern RESULT FMOD_Studio_EventInstance_Get3DAttributes(IntPtr _event, out ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000570")]
		[Address(RVA = "0x11FB834", Offset = "0x11FB834", VA = "0x11FB834")]
		private static extern RESULT FMOD_Studio_EventInstance_Set3DAttributes(IntPtr _event, ref ATTRIBUTES_3D attributes);

		[PreserveSig]
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x11FB8E4", Offset = "0x11FB8E4", VA = "0x11FB8E4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetListenerMask(IntPtr _event, out uint mask);

		[PreserveSig]
		[Token(Token = "0x6000572")]
		[Address(RVA = "0x11FB994", Offset = "0x11FB994", VA = "0x11FB994")]
		private static extern RESULT FMOD_Studio_EventInstance_SetListenerMask(IntPtr _event, uint mask);

		[PreserveSig]
		[Token(Token = "0x6000573")]
		[Address(RVA = "0x11FBA44", Offset = "0x11FBA44", VA = "0x11FBA44")]
		private static extern RESULT FMOD_Studio_EventInstance_GetProperty(IntPtr _event, EVENT_PROPERTY index, out float value);

		[PreserveSig]
		[Token(Token = "0x6000574")]
		[Address(RVA = "0x11FBAFC", Offset = "0x11FBAFC", VA = "0x11FBAFC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetProperty(IntPtr _event, EVENT_PROPERTY index, float value);

		[PreserveSig]
		[Token(Token = "0x6000575")]
		[Address(RVA = "0x11FBBBC", Offset = "0x11FBBBC", VA = "0x11FBBBC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetReverbLevel(IntPtr _event, int index, out float level);

		[PreserveSig]
		[Token(Token = "0x6000576")]
		[Address(RVA = "0x11FBC74", Offset = "0x11FBC74", VA = "0x11FBC74")]
		private static extern RESULT FMOD_Studio_EventInstance_SetReverbLevel(IntPtr _event, int index, float level);

		[PreserveSig]
		[Token(Token = "0x6000577")]
		[Address(RVA = "0x11FBD34", Offset = "0x11FBD34", VA = "0x11FBD34")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPaused(IntPtr _event, out bool paused);

		[PreserveSig]
		[Token(Token = "0x6000578")]
		[Address(RVA = "0x11FBDFC", Offset = "0x11FBDFC", VA = "0x11FBDFC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetPaused(IntPtr _event, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000579")]
		[Address(RVA = "0x11FBEAC", Offset = "0x11FBEAC", VA = "0x11FBEAC")]
		private static extern RESULT FMOD_Studio_EventInstance_Start(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x600057A")]
		[Address(RVA = "0x11FBF4C", Offset = "0x11FBF4C", VA = "0x11FBF4C")]
		private static extern RESULT FMOD_Studio_EventInstance_Stop(IntPtr _event, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x600057B")]
		[Address(RVA = "0x11FBFFC", Offset = "0x11FBFFC", VA = "0x11FBFFC")]
		private static extern RESULT FMOD_Studio_EventInstance_GetTimelinePosition(IntPtr _event, out int position);

		[PreserveSig]
		[Token(Token = "0x600057C")]
		[Address(RVA = "0x11FC0AC", Offset = "0x11FC0AC", VA = "0x11FC0AC")]
		private static extern RESULT FMOD_Studio_EventInstance_SetTimelinePosition(IntPtr _event, int position);

		[PreserveSig]
		[Token(Token = "0x600057D")]
		[Address(RVA = "0x11FC15C", Offset = "0x11FC15C", VA = "0x11FC15C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetPlaybackState(IntPtr _event, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x11FC20C", Offset = "0x11FC20C", VA = "0x11FC20C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetChannelGroup(IntPtr _event, out IntPtr group);

		[PreserveSig]
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x11FC2BC", Offset = "0x11FC2BC", VA = "0x11FC2BC")]
		private static extern RESULT FMOD_Studio_EventInstance_Release(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000580")]
		[Address(RVA = "0x11FC35C", Offset = "0x11FC35C", VA = "0x11FC35C")]
		private static extern RESULT FMOD_Studio_EventInstance_IsVirtual(IntPtr _event, out bool virtualstate);

		[PreserveSig]
		[Token(Token = "0x6000581")]
		[Address(RVA = "0x11FC84C", Offset = "0x11FC84C", VA = "0x11FC84C")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByName(IntPtr _event, byte[] name, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000582")]
		[Address(RVA = "0x11FCA84", Offset = "0x11FCA84", VA = "0x11FCA84")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByName(IntPtr _event, byte[] name, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000583")]
		[Address(RVA = "0x11FC448", Offset = "0x11FC448", VA = "0x11FC448")]
		private static extern RESULT FMOD_Studio_EventInstance_GetParameterByID(IntPtr _event, PARAMETER_ID id, out float value, out float finalvalue);

		[PreserveSig]
		[Token(Token = "0x6000584")]
		[Address(RVA = "0x11FC514", Offset = "0x11FC514", VA = "0x11FC514")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParameterByID(IntPtr _event, PARAMETER_ID id, float value, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000585")]
		[Address(RVA = "0x11FC5E0", Offset = "0x11FC5E0", VA = "0x11FC5E0")]
		private static extern RESULT FMOD_Studio_EventInstance_SetParametersByIDs(IntPtr _event, PARAMETER_ID[] ids, float[] values, int count, bool ignoreseekspeed);

		[PreserveSig]
		[Token(Token = "0x6000586")]
		[Address(RVA = "0x11FCB54", Offset = "0x11FCB54", VA = "0x11FCB54")]
		private static extern RESULT FMOD_Studio_EventInstance_TriggerCue(IntPtr _event);

		[PreserveSig]
		[Token(Token = "0x6000587")]
		[Address(RVA = "0x11FCBF4", Offset = "0x11FCBF4", VA = "0x11FCBF4")]
		private static extern RESULT FMOD_Studio_EventInstance_SetCallback(IntPtr _event, EVENT_CALLBACK callback, EVENT_CALLBACK_TYPE callbackmask);

		[PreserveSig]
		[Token(Token = "0x6000588")]
		[Address(RVA = "0x11FCCB4", Offset = "0x11FCCB4", VA = "0x11FCCB4")]
		private static extern RESULT FMOD_Studio_EventInstance_GetUserData(IntPtr _event, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x11FCD64", Offset = "0x11FCD64", VA = "0x11FCD64")]
		private static extern RESULT FMOD_Studio_EventInstance_SetUserData(IntPtr _event, IntPtr userdata);

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x9AE694", Offset = "0x9AE694", VA = "0x9AE694")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x9AE69C", Offset = "0x9AE69C", VA = "0x9AE69C")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x9AE6E0", Offset = "0x9AE6E0", VA = "0x9AE6E0")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EA")]
	public struct Bus
	{
		[Token(Token = "0x40004AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x9AE0F8", Offset = "0x9AE0F8", VA = "0x9AE0F8")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x9AE100", Offset = "0x9AE100", VA = "0x9AE100")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x9AE108", Offset = "0x9AE108", VA = "0x9AE108")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x9AE130", Offset = "0x9AE130", VA = "0x9AE130")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x9AE138", Offset = "0x9AE138", VA = "0x9AE138")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x9AE140", Offset = "0x9AE140", VA = "0x9AE140")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x9AE148", Offset = "0x9AE148", VA = "0x9AE148")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x9AE154", Offset = "0x9AE154", VA = "0x9AE154")]
		public RESULT getMute(out bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x9AE15C", Offset = "0x9AE15C", VA = "0x9AE15C")]
		public RESULT setMute(bool mute)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x9AE168", Offset = "0x9AE168", VA = "0x9AE168")]
		public RESULT stopAllEvents(STOP_MODE mode)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x9AE170", Offset = "0x9AE170", VA = "0x9AE170")]
		public RESULT lockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x9AE178", Offset = "0x9AE178", VA = "0x9AE178")]
		public RESULT unlockChannelGroup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x9AE180", Offset = "0x9AE180", VA = "0x9AE180")]
		public RESULT getChannelGroup(out ChannelGroup group)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x600059A")]
		[Address(RVA = "0x11F72EC", Offset = "0x11F72EC", VA = "0x11F72EC")]
		private static extern bool FMOD_Studio_Bus_IsValid(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x600059B")]
		[Address(RVA = "0x11F681C", Offset = "0x11F681C", VA = "0x11F681C")]
		private static extern RESULT FMOD_Studio_Bus_GetID(IntPtr bus, out Guid id);

		[PreserveSig]
		[Token(Token = "0x600059C")]
		[Address(RVA = "0x11F6B0C", Offset = "0x11F6B0C", VA = "0x11F6B0C")]
		private static extern RESULT FMOD_Studio_Bus_GetPath(IntPtr bus, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x600059D")]
		[Address(RVA = "0x11F6BFC", Offset = "0x11F6BFC", VA = "0x11F6BFC")]
		private static extern RESULT FMOD_Studio_Bus_GetVolume(IntPtr bus, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x11F6CB4", Offset = "0x11F6CB4", VA = "0x11F6CB4")]
		private static extern RESULT FMOD_Studio_Bus_SetVolume(IntPtr bus, float volume);

		[PreserveSig]
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x11F6D64", Offset = "0x11F6D64", VA = "0x11F6D64")]
		private static extern RESULT FMOD_Studio_Bus_GetPaused(IntPtr bus, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x11F6E2C", Offset = "0x11F6E2C", VA = "0x11F6E2C")]
		private static extern RESULT FMOD_Studio_Bus_SetPaused(IntPtr bus, bool paused);

		[PreserveSig]
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x11F6EDC", Offset = "0x11F6EDC", VA = "0x11F6EDC")]
		private static extern RESULT FMOD_Studio_Bus_GetMute(IntPtr bus, out bool mute);

		[PreserveSig]
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x11F6FA4", Offset = "0x11F6FA4", VA = "0x11F6FA4")]
		private static extern RESULT FMOD_Studio_Bus_SetMute(IntPtr bus, bool mute);

		[PreserveSig]
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x11F7054", Offset = "0x11F7054", VA = "0x11F7054")]
		private static extern RESULT FMOD_Studio_Bus_StopAllEvents(IntPtr bus, STOP_MODE mode);

		[PreserveSig]
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x11F7104", Offset = "0x11F7104", VA = "0x11F7104")]
		private static extern RESULT FMOD_Studio_Bus_LockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x11F71A4", Offset = "0x11F71A4", VA = "0x11F71A4")]
		private static extern RESULT FMOD_Studio_Bus_UnlockChannelGroup(IntPtr bus);

		[PreserveSig]
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x11F7244", Offset = "0x11F7244", VA = "0x11F7244")]
		private static extern RESULT FMOD_Studio_Bus_GetChannelGroup(IntPtr bus, out IntPtr group);

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x9AE188", Offset = "0x9AE188", VA = "0x9AE188")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x9AE190", Offset = "0x9AE190", VA = "0x9AE190")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x9AE1D4", Offset = "0x9AE1D4", VA = "0x9AE1D4")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EB")]
	public struct VCA
	{
		[Token(Token = "0x40004AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x9AEC54", Offset = "0x9AEC54", VA = "0x9AEC54")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x9AEC5C", Offset = "0x9AEC5C", VA = "0x9AEC5C")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x9AEC64", Offset = "0x9AEC64", VA = "0x9AEC64")]
		public RESULT getVolume(out float volume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x9AEC8C", Offset = "0x9AEC8C", VA = "0x9AEC8C")]
		public RESULT getVolume(out float volume, out float finalvolume)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x9AEC94", Offset = "0x9AEC94", VA = "0x9AEC94")]
		public RESULT setVolume(float volume)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x1201E6C", Offset = "0x1201E6C", VA = "0x1201E6C")]
		private static extern bool FMOD_Studio_VCA_IsValid(IntPtr vca);

		[PreserveSig]
		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x120192C", Offset = "0x120192C", VA = "0x120192C")]
		private static extern RESULT FMOD_Studio_VCA_GetID(IntPtr vca, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x1201C1C", Offset = "0x1201C1C", VA = "0x1201C1C")]
		private static extern RESULT FMOD_Studio_VCA_GetPath(IntPtr vca, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005B2")]
		[Address(RVA = "0x1201D0C", Offset = "0x1201D0C", VA = "0x1201D0C")]
		private static extern RESULT FMOD_Studio_VCA_GetVolume(IntPtr vca, out float volume, out float finalvolume);

		[PreserveSig]
		[Token(Token = "0x60005B3")]
		[Address(RVA = "0x1201DC4", Offset = "0x1201DC4", VA = "0x1201DC4")]
		private static extern RESULT FMOD_Studio_VCA_SetVolume(IntPtr vca, float volume);

		[Token(Token = "0x60005B4")]
		[Address(RVA = "0x9AEC9C", Offset = "0x9AEC9C", VA = "0x9AEC9C")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005B5")]
		[Address(RVA = "0x9AECA4", Offset = "0x9AECA4", VA = "0x9AECA4")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005B6")]
		[Address(RVA = "0x9AECE8", Offset = "0x9AECE8", VA = "0x9AECE8")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000EC")]
	public struct Bank
	{
		[Token(Token = "0x40004AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x9AE01C", Offset = "0x9AE01C", VA = "0x9AE01C")]
		public RESULT getID(out Guid id)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B8")]
		[Address(RVA = "0x9AE024", Offset = "0x9AE024", VA = "0x9AE024")]
		public RESULT getPath(out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005B9")]
		[Address(RVA = "0x9AE02C", Offset = "0x9AE02C", VA = "0x9AE02C")]
		public RESULT unload()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BA")]
		[Address(RVA = "0x9AE034", Offset = "0x9AE034", VA = "0x9AE034")]
		public RESULT loadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BB")]
		[Address(RVA = "0x9AE03C", Offset = "0x9AE03C", VA = "0x9AE03C")]
		public RESULT unloadSampleData()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BC")]
		[Address(RVA = "0x9AE044", Offset = "0x9AE044", VA = "0x9AE044")]
		public RESULT getLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x9AE04C", Offset = "0x9AE04C", VA = "0x9AE04C")]
		public RESULT getSampleLoadingState(out LOADING_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x9AE054", Offset = "0x9AE054", VA = "0x9AE054")]
		public RESULT getStringCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x9AE05C", Offset = "0x9AE05C", VA = "0x9AE05C")]
		public RESULT getStringInfo(int index, out Guid id, out string path)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x9AE064", Offset = "0x9AE064", VA = "0x9AE064")]
		public RESULT getEventCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x9AE06C", Offset = "0x9AE06C", VA = "0x9AE06C")]
		public RESULT getEventList(out EventDescription[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x9AE074", Offset = "0x9AE074", VA = "0x9AE074")]
		public RESULT getBusCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x9AE07C", Offset = "0x9AE07C", VA = "0x9AE07C")]
		public RESULT getBusList(out Bus[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C4")]
		[Address(RVA = "0x9AE084", Offset = "0x9AE084", VA = "0x9AE084")]
		public RESULT getVCACount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C5")]
		[Address(RVA = "0x9AE08C", Offset = "0x9AE08C", VA = "0x9AE08C")]
		public RESULT getVCAList(out VCA[] array)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C6")]
		[Address(RVA = "0x9AE094", Offset = "0x9AE094", VA = "0x9AE094")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005C7")]
		[Address(RVA = "0x9AE09C", Offset = "0x9AE09C", VA = "0x9AE09C")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005C8")]
		[Address(RVA = "0x11F66AC", Offset = "0x11F66AC", VA = "0x11F66AC")]
		private static extern bool FMOD_Studio_Bank_IsValid(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005C9")]
		[Address(RVA = "0x11F51CC", Offset = "0x11F51CC", VA = "0x11F51CC")]
		private static extern RESULT FMOD_Studio_Bank_GetID(IntPtr bank, out Guid id);

		[PreserveSig]
		[Token(Token = "0x60005CA")]
		[Address(RVA = "0x11F54BC", Offset = "0x11F54BC", VA = "0x11F54BC")]
		private static extern RESULT FMOD_Studio_Bank_GetPath(IntPtr bank, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005CB")]
		[Address(RVA = "0x11F5584", Offset = "0x11F5584", VA = "0x11F5584")]
		private static extern RESULT FMOD_Studio_Bank_Unload(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005CC")]
		[Address(RVA = "0x11F5624", Offset = "0x11F5624", VA = "0x11F5624")]
		private static extern RESULT FMOD_Studio_Bank_LoadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005CD")]
		[Address(RVA = "0x11F56C4", Offset = "0x11F56C4", VA = "0x11F56C4")]
		private static extern RESULT FMOD_Studio_Bank_UnloadSampleData(IntPtr bank);

		[PreserveSig]
		[Token(Token = "0x60005CE")]
		[Address(RVA = "0x11F5764", Offset = "0x11F5764", VA = "0x11F5764")]
		private static extern RESULT FMOD_Studio_Bank_GetLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005CF")]
		[Address(RVA = "0x11F5814", Offset = "0x11F5814", VA = "0x11F5814")]
		private static extern RESULT FMOD_Studio_Bank_GetSampleLoadingState(IntPtr bank, out LOADING_STATE state);

		[PreserveSig]
		[Token(Token = "0x60005D0")]
		[Address(RVA = "0x11F58C4", Offset = "0x11F58C4", VA = "0x11F58C4")]
		private static extern RESULT FMOD_Studio_Bank_GetStringCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D1")]
		[Address(RVA = "0x11F5C04", Offset = "0x11F5C04", VA = "0x11F5C04")]
		private static extern RESULT FMOD_Studio_Bank_GetStringInfo(IntPtr bank, int index, out Guid id, IntPtr path, int size, out int retrieved);

		[PreserveSig]
		[Token(Token = "0x60005D2")]
		[Address(RVA = "0x11F5CE4", Offset = "0x11F5CE4", VA = "0x11F5CE4")]
		private static extern RESULT FMOD_Studio_Bank_GetEventCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D3")]
		[Address(RVA = "0x11F5EE4", Offset = "0x11F5EE4", VA = "0x11F5EE4")]
		private static extern RESULT FMOD_Studio_Bank_GetEventList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D4")]
		[Address(RVA = "0x11F5FB4", Offset = "0x11F5FB4", VA = "0x11F5FB4")]
		private static extern RESULT FMOD_Studio_Bank_GetBusCount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D5")]
		[Address(RVA = "0x11F61B4", Offset = "0x11F61B4", VA = "0x11F61B4")]
		private static extern RESULT FMOD_Studio_Bank_GetBusList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D6")]
		[Address(RVA = "0x11F6284", Offset = "0x11F6284", VA = "0x11F6284")]
		private static extern RESULT FMOD_Studio_Bank_GetVCACount(IntPtr bank, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D7")]
		[Address(RVA = "0x11F6484", Offset = "0x11F6484", VA = "0x11F6484")]
		private static extern RESULT FMOD_Studio_Bank_GetVCAList(IntPtr bank, IntPtr[] array, int capacity, out int count);

		[PreserveSig]
		[Token(Token = "0x60005D8")]
		[Address(RVA = "0x11F6554", Offset = "0x11F6554", VA = "0x11F6554")]
		private static extern RESULT FMOD_Studio_Bank_GetUserData(IntPtr bank, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x60005D9")]
		[Address(RVA = "0x11F6604", Offset = "0x11F6604", VA = "0x11F6604")]
		private static extern RESULT FMOD_Studio_Bank_SetUserData(IntPtr bank, IntPtr userdata);

		[Token(Token = "0x60005DA")]
		[Address(RVA = "0x9AE0A4", Offset = "0x9AE0A4", VA = "0x9AE0A4")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x60005DB")]
		[Address(RVA = "0x9AE0AC", Offset = "0x9AE0AC", VA = "0x9AE0AC")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x60005DC")]
		[Address(RVA = "0x9AE0F0", Offset = "0x9AE0F0", VA = "0x9AE0F0")]
		public bool isValid()
		{
			return default(bool);
		}
	}
	[Token(Token = "0x20000ED")]
	public struct CommandReplay
	{
		[Token(Token = "0x40004B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public IntPtr handle;

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x9AE244", Offset = "0x9AE244", VA = "0x9AE244")]
		public RESULT getSystem(out System system)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x9AE24C", Offset = "0x9AE24C", VA = "0x9AE24C")]
		public RESULT getLength(out float length)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x9AE254", Offset = "0x9AE254", VA = "0x9AE254")]
		public RESULT getCommandCount(out int count)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x9AE25C", Offset = "0x9AE25C", VA = "0x9AE25C")]
		public RESULT getCommandInfo(int commandIndex, out COMMAND_INFO info)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x9AE264", Offset = "0x9AE264", VA = "0x9AE264")]
		public RESULT getCommandString(int commandIndex, out string buffer)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x9AE26C", Offset = "0x9AE26C", VA = "0x9AE26C")]
		public RESULT getCommandAtTime(float time, out int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x9AE274", Offset = "0x9AE274", VA = "0x9AE274")]
		public RESULT setBankPath(string bankPath)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x9AE27C", Offset = "0x9AE27C", VA = "0x9AE27C")]
		public RESULT start()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E5")]
		[Address(RVA = "0x9AE284", Offset = "0x9AE284", VA = "0x9AE284")]
		public RESULT stop()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x9AE28C", Offset = "0x9AE28C", VA = "0x9AE28C")]
		public RESULT seekToTime(float time)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E7")]
		[Address(RVA = "0x9AE294", Offset = "0x9AE294", VA = "0x9AE294")]
		public RESULT seekToCommand(int commandIndex)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E8")]
		[Address(RVA = "0x9AE29C", Offset = "0x9AE29C", VA = "0x9AE29C")]
		public RESULT getPaused(out bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x9AE2A4", Offset = "0x9AE2A4", VA = "0x9AE2A4")]
		public RESULT setPaused(bool paused)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x9AE2B0", Offset = "0x9AE2B0", VA = "0x9AE2B0")]
		public RESULT getPlaybackState(out PLAYBACK_STATE state)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x9AE2B8", Offset = "0x9AE2B8", VA = "0x9AE2B8")]
		public RESULT getCurrentCommand(out int commandIndex, out float currentTime)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EC")]
		[Address(RVA = "0x9AE2C0", Offset = "0x9AE2C0", VA = "0x9AE2C0")]
		public RESULT release()
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005ED")]
		[Address(RVA = "0x9AE2C8", Offset = "0x9AE2C8", VA = "0x9AE2C8")]
		public RESULT setFrameCallback(COMMANDREPLAY_FRAME_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EE")]
		[Address(RVA = "0x9AE2D0", Offset = "0x9AE2D0", VA = "0x9AE2D0")]
		public RESULT setLoadBankCallback(COMMANDREPLAY_LOAD_BANK_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005EF")]
		[Address(RVA = "0x9AE2D8", Offset = "0x9AE2D8", VA = "0x9AE2D8")]
		public RESULT setCreateInstanceCallback(COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F0")]
		[Address(RVA = "0x9AE2E0", Offset = "0x9AE2E0", VA = "0x9AE2E0")]
		public RESULT getUserData(out IntPtr userdata)
		{
			return default(RESULT);
		}

		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x9AE2E8", Offset = "0x9AE2E8", VA = "0x9AE2E8")]
		public RESULT setUserData(IntPtr userdata)
		{
			return default(RESULT);
		}

		[PreserveSig]
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x11F92BC", Offset = "0x11F92BC", VA = "0x11F92BC")]
		private static extern bool FMOD_Studio_CommandReplay_IsValid(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x11F8078", Offset = "0x11F8078", VA = "0x11F8078")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetSystem(IntPtr replay, out IntPtr system);

		[PreserveSig]
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x11F8128", Offset = "0x11F8128", VA = "0x11F8128")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetLength(IntPtr replay, out float length);

		[PreserveSig]
		[Token(Token = "0x60005F5")]
		[Address(RVA = "0x11F81D8", Offset = "0x11F81D8", VA = "0x11F81D8")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandCount(IntPtr replay, out int count);

		[PreserveSig]
		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x11F8288", Offset = "0x11F8288", VA = "0x11F8288")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandInfo(IntPtr replay, int commandindex, out COMMAND_INFO info);

		[PreserveSig]
		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x11F858C", Offset = "0x11F858C", VA = "0x11F858C")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandString(IntPtr replay, int commandIndex, IntPtr buffer, int length);

		[PreserveSig]
		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x11F8654", Offset = "0x11F8654", VA = "0x11F8654")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCommandAtTime(IntPtr replay, float time, out int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x11F8864", Offset = "0x11F8864", VA = "0x11F8864")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetBankPath(IntPtr replay, byte[] bankPath);

		[PreserveSig]
		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x11F891C", Offset = "0x11F891C", VA = "0x11F891C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Start(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x11F89BC", Offset = "0x11F89BC", VA = "0x11F89BC")]
		private static extern RESULT FMOD_Studio_CommandReplay_Stop(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x11F8A5C", Offset = "0x11F8A5C", VA = "0x11F8A5C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToTime(IntPtr replay, float time);

		[PreserveSig]
		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x11F8B0C", Offset = "0x11F8B0C", VA = "0x11F8B0C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SeekToCommand(IntPtr replay, int commandIndex);

		[PreserveSig]
		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x11F8BBC", Offset = "0x11F8BBC", VA = "0x11F8BBC")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPaused(IntPtr replay, out bool paused);

		[PreserveSig]
		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x11F8C84", Offset = "0x11F8C84", VA = "0x11F8C84")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetPaused(IntPtr replay, bool paused);

		[PreserveSig]
		[Token(Token = "0x6000600")]
		[Address(RVA = "0x11F8D34", Offset = "0x11F8D34", VA = "0x11F8D34")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetPlaybackState(IntPtr replay, out PLAYBACK_STATE state);

		[PreserveSig]
		[Token(Token = "0x6000601")]
		[Address(RVA = "0x11F8DE4", Offset = "0x11F8DE4", VA = "0x11F8DE4")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetCurrentCommand(IntPtr replay, out int commandIndex, out float currentTime);

		[PreserveSig]
		[Token(Token = "0x6000602")]
		[Address(RVA = "0x11F8E9C", Offset = "0x11F8E9C", VA = "0x11F8E9C")]
		private static extern RESULT FMOD_Studio_CommandReplay_Release(IntPtr replay);

		[PreserveSig]
		[Token(Token = "0x6000603")]
		[Address(RVA = "0x11F8F3C", Offset = "0x11F8F3C", VA = "0x11F8F3C")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetFrameCallback(IntPtr replay, COMMANDREPLAY_FRAME_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000604")]
		[Address(RVA = "0x11F8FF4", Offset = "0x11F8FF4", VA = "0x11F8FF4")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetLoadBankCallback(IntPtr replay, COMMANDREPLAY_LOAD_BANK_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000605")]
		[Address(RVA = "0x11F90AC", Offset = "0x11F90AC", VA = "0x11F90AC")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetCreateInstanceCallback(IntPtr replay, COMMANDREPLAY_CREATE_INSTANCE_CALLBACK callback);

		[PreserveSig]
		[Token(Token = "0x6000606")]
		[Address(RVA = "0x11F9164", Offset = "0x11F9164", VA = "0x11F9164")]
		private static extern RESULT FMOD_Studio_CommandReplay_GetUserData(IntPtr replay, out IntPtr userdata);

		[PreserveSig]
		[Token(Token = "0x6000607")]
		[Address(RVA = "0x11F9214", Offset = "0x11F9214", VA = "0x11F9214")]
		private static extern RESULT FMOD_Studio_CommandReplay_SetUserData(IntPtr replay, IntPtr userdata);

		[Token(Token = "0x6000608")]
		[Address(RVA = "0x9AE2F0", Offset = "0x9AE2F0", VA = "0x9AE2F0")]
		public bool hasHandle()
		{
			return default(bool);
		}

		[Token(Token = "0x6000609")]
		[Address(RVA = "0x9AE2F8", Offset = "0x9AE2F8", VA = "0x9AE2F8")]
		public void clearHandle()
		{
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x9AE33C", Offset = "0x9AE33C", VA = "0x9AE33C")]
		public bool isValid()
		{
			return default(bool);
		}
	}
}
namespace FMODUnity
{
	[Token(Token = "0x20000EE")]
	public class BankRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600060B")]
		[Address(RVA = "0x1AEE4EC", Offset = "0x1AEE4EC", VA = "0x1AEE4EC")]
		public BankRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000EF")]
	public abstract class EventHandler : MonoBehaviour
	{
		[Token(Token = "0x40004B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string CollisionTag;

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1AEE5A8", Offset = "0x1AEE5A8", VA = "0x1AEE5A8")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x600060D")]
		[Address(RVA = "0x1AEE5B8", Offset = "0x1AEE5B8", VA = "0x1AEE5B8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x600060E")]
		[Address(RVA = "0x1AEE5C8", Offset = "0x1AEE5C8", VA = "0x1AEE5C8")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1AEE634", Offset = "0x1AEE634", VA = "0x1AEE634")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1AEE6A0", Offset = "0x1AEE6A0", VA = "0x1AEE6A0")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000611")]
		[Address(RVA = "0x1AEE70C", Offset = "0x1AEE70C", VA = "0x1AEE70C")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x6000612")]
		[Address(RVA = "0x1AEE778", Offset = "0x1AEE778", VA = "0x1AEE778")]
		private void OnCollisionEnter()
		{
		}

		[Token(Token = "0x6000613")]
		[Address(RVA = "0x1AEE788", Offset = "0x1AEE788", VA = "0x1AEE788")]
		private void OnCollisionExit()
		{
		}

		[Token(Token = "0x6000614")]
		[Address(RVA = "0x1AEE798", Offset = "0x1AEE798", VA = "0x1AEE798")]
		private void OnCollisionEnter2D()
		{
		}

		[Token(Token = "0x6000615")]
		[Address(RVA = "0x1AEE7A8", Offset = "0x1AEE7A8", VA = "0x1AEE7A8")]
		private void OnCollisionExit2D()
		{
		}

		[Token(Token = "0x6000616")]
		[Address(RVA = "0x1AEE7B8", Offset = "0x1AEE7B8", VA = "0x1AEE7B8")]
		private void OnMouseEnter()
		{
		}

		[Token(Token = "0x6000617")]
		[Address(RVA = "0x1AEE7C8", Offset = "0x1AEE7C8", VA = "0x1AEE7C8")]
		private void OnMouseExit()
		{
		}

		[Token(Token = "0x6000618")]
		[Address(RVA = "0x1AEE7D8", Offset = "0x1AEE7D8", VA = "0x1AEE7D8")]
		private void OnMouseDown()
		{
		}

		[Token(Token = "0x6000619")]
		[Address(RVA = "0x1AEE7E8", Offset = "0x1AEE7E8", VA = "0x1AEE7E8")]
		private void OnMouseUp()
		{
		}

		[Token(Token = "0x600061A")]
		protected abstract void HandleGameEvent(EmitterGameEvent gameEvent);

		[Token(Token = "0x600061B")]
		[Address(RVA = "0x1AEE7F8", Offset = "0x1AEE7F8", VA = "0x1AEE7F8")]
		protected EventHandler()
		{
		}
	}
	[Token(Token = "0x20000F0")]
	public class EventRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x600061C")]
		[Address(RVA = "0x1AEE9D4", Offset = "0x1AEE9D4", VA = "0x1AEE9D4")]
		public EventRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000F1")]
	public class FMODRuntimeManagerOnGUIHelper : MonoBehaviour
	{
		[Token(Token = "0x40004B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public RuntimeManager TargetRuntimeManager;

		[Token(Token = "0x600061D")]
		[Address(RVA = "0x1AEE9DC", Offset = "0x1AEE9DC", VA = "0x1AEE9DC")]
		private void OnGUI()
		{
		}

		[Token(Token = "0x600061E")]
		[Address(RVA = "0x1AEEB74", Offset = "0x1AEEB74", VA = "0x1AEEB74")]
		public FMODRuntimeManagerOnGUIHelper()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000F2")]
	public class ParamRef
	{
		[Token(Token = "0x40004B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Name;

		[Token(Token = "0x40004B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float Value;

		[Token(Token = "0x40004B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public PARAMETER_ID ID;

		[Token(Token = "0x600061F")]
		[Address(RVA = "0x1AEEB7C", Offset = "0x1AEEB7C", VA = "0x1AEEB7C")]
		public ParamRef()
		{
		}
	}
	[Token(Token = "0x20000F3")]
	public class ParamRefAttribute : PropertyAttribute
	{
		[Token(Token = "0x6000620")]
		[Address(RVA = "0x1AEEB84", Offset = "0x1AEEB84", VA = "0x1AEEB84")]
		public ParamRefAttribute()
		{
		}
	}
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC8A4", Offset = "0x8DC8A4")]
	public class RuntimeManager : MonoBehaviour
	{
		[Token(Token = "0x2000113")]
		private struct LoadedBank
		{
			[Token(Token = "0x400056E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Bank Bank;

			[Token(Token = "0x400056F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int RefCount;
		}

		[Token(Token = "0x2000114")]
		private class GuidComparer : IEqualityComparer<Guid>
		{
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x1AF4DB8", Offset = "0x1AF4DB8", VA = "0x1AF4DB8", Slot = "4")]
			private bool System.Collections.Generic.IEqualityComparer<System.Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x1AF4DEC", Offset = "0x1AF4DEC", VA = "0x1AF4DEC", Slot = "5")]
			private int System.Collections.Generic.IEqualityComparer<System.Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}

			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x1AF4A14", Offset = "0x1AF4A14", VA = "0x1AF4A14")]
			public GuidComparer()
			{
			}
		}

		[Token(Token = "0x2000115")]
		private class AttachedInstance
		{
			[Token(Token = "0x4000570")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance instance;

			[Token(Token = "0x4000571")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public Transform transform;

			[Token(Token = "0x4000572")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Rigidbody rigidBody;

			[Token(Token = "0x4000573")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Rigidbody2D rigidBody2D;

			[Token(Token = "0x60006C5")]
			[Address(RVA = "0x1AF1D04", Offset = "0x1AF1D04", VA = "0x1AF1D04")]
			public AttachedInstance()
			{
			}
		}

		[Token(Token = "0x2000116")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA34", Offset = "0x8DCA34")]
		private sealed class <loadFromWeb>d__42 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000574")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000575")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000576")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string bankPath;

			[Token(Token = "0x4000577")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public RuntimeManager <>4__this;

			[Token(Token = "0x4000578")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string bankName;

			[Token(Token = "0x4000579")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public bool loadSamples;

			[Token(Token = "0x400057A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest <www>5__2;

			[Token(Token = "0x17000018")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x60006C9")]
				[Address(RVA = "0x1AF4D44", Offset = "0x1AF4D44", VA = "0x1AF4D44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000019")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x60006CB")]
				[Address(RVA = "0x1AF4DB0", Offset = "0x1AF4DB0", VA = "0x1AF4DB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x1AF2820", Offset = "0x1AF2820", VA = "0x1AF2820")]
			[DebuggerHidden]
			public <loadFromWeb>d__42(int <>1__state)
			{
			}

			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x1AF4AA4", Offset = "0x1AF4AA4", VA = "0x1AF4AA4", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x1AF4AA8", Offset = "0x1AF4AA8", VA = "0x1AF4AA8", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x1AF4D4C", Offset = "0x1AF4D4C", VA = "0x1AF4D4C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x40004B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static SystemNotInitializedException initException;

		[Token(Token = "0x40004B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static RuntimeManager instance;

		[Token(Token = "0x40004B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FMODPlatform fmodPlatform;

		[Token(Token = "0x40004B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private FMOD.Studio.System studioSystem;

		[Token(Token = "0x40004BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private FMOD.System coreSystem;

		[Token(Token = "0x40004BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private DSP mixerHead;

		[Token(Token = "0x40004BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private long[] cachedPointers;

		[Token(Token = "0x40004BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Dictionary<string, LoadedBank> loadedBanks;

		[Token(Token = "0x40004BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private Dictionary<string, uint> loadedPlugins;

		[Token(Token = "0x40004BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private Dictionary<Guid, EventDescription> cachedDescriptions;

		[Token(Token = "0x40004C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<AttachedInstance> attachedInstances;

		[Token(Token = "0x40004C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool listenerWarningIssued;

		[Token(Token = "0x40004C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		protected bool isOverlayEnabled;

		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Rect windowRect;

		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private string lastDebugText;

		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private float lastDebugUpdate;

		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static List<StudioListener> Listeners;

		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static int numListeners;

		[Token(Token = "0x17000007")]
		private static RuntimeManager Instance
		{
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x1AEEE48", Offset = "0x1AEEE48", VA = "0x1AEEE48")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		public static FMOD.Studio.System StudioSystem
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x1AED474", Offset = "0x1AED474", VA = "0x1AED474")]
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		[Token(Token = "0x17000009")]
		public static FMOD.System CoreSystem
		{
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x1AEFF10", Offset = "0x1AEFF10", VA = "0x1AEFF10")]
			get
			{
				return default(FMOD.System);
			}
		}

		[Token(Token = "0x1700000A")]
		public static bool IsInitialized
		{
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x1AF46A8", Offset = "0x1AF46A8", VA = "0x1AF46A8")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700000B")]
		public static bool HasBanksLoaded
		{
			[Token(Token = "0x600064F")]
			[Address(RVA = "0x1AF455C", Offset = "0x1AF455C", VA = "0x1AF455C")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0x1AEEC84", Offset = "0x1AEEC84", VA = "0x1AEEC84")]
		[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0x8DCDE4", Offset = "0x8DCDE4")]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, StringWrapper file, int line, StringWrapper func, StringWrapper message)
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000625")]
		[Address(RVA = "0x1AEFF7C", Offset = "0x1AEFF7C", VA = "0x1AEFF7C")]
		private void CheckInitResult(RESULT result, string cause)
		{
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0x1AEF81C", Offset = "0x1AEF81C", VA = "0x1AEF81C")]
		private RESULT Initialize()
		{
			return default(RESULT);
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0x1AF0EC4", Offset = "0x1AF0EC4", VA = "0x1AF0EC4")]
		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0x1AF12DC", Offset = "0x1AF12DC", VA = "0x1AF12DC")]
		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		[Token(Token = "0x6000629")]
		[Address(RVA = "0x1AF1604", Offset = "0x1AF1604", VA = "0x1AF1604")]
		private void Update()
		{
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0x1AED978", Offset = "0x1AED978", VA = "0x1AED978")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x600062B")]
		[Address(RVA = "0x1AEDA68", Offset = "0x1AEDA68", VA = "0x1AEDA68")]
		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1AF1D0C", Offset = "0x1AF1D0C", VA = "0x1AF1D0C")]
		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1AEEA68", Offset = "0x1AEEA68", VA = "0x1AEEA68")]
		public void ExecuteOnGUI()
		{
		}

		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1AF1E08", Offset = "0x1AF1E08", VA = "0x1AF1E08")]
		private void Start()
		{
		}

		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1AF1F18", Offset = "0x1AF1F18", VA = "0x1AF1F18")]
		private void DrawDebugOverlay(int windowID)
		{
		}

		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1AF2378", Offset = "0x1AF2378", VA = "0x1AF2378")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1AF23F0", Offset = "0x1AF23F0", VA = "0x1AF23F0")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1AF2494", Offset = "0x1AF2494", VA = "0x1AF2494")]
		private void OnApplicationPause(bool pauseStatus)
		{
		}

		[Token(Token = "0x6000633")]
		[Address(RVA = "0x1AF2608", Offset = "0x1AF2608", VA = "0x1AF2608")]
		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		[Token(Token = "0x6000634")]
		[Address(RVA = "0x1AF2784", Offset = "0x1AF2784", VA = "0x1AF2784")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0x8DCE48", Offset = "0x8DCE48")]
		private IEnumerator loadFromWeb(string bankPath, string bankName, bool loadSamples)
		{
			return null;
		}

		[Token(Token = "0x6000635")]
		[Address(RVA = "0x1AF284C", Offset = "0x1AF284C", VA = "0x1AF284C")]
		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000636")]
		[Address(RVA = "0x1AF2D74", Offset = "0x1AF2D74", VA = "0x1AF2D74")]
		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		[Token(Token = "0x6000637")]
		[Address(RVA = "0x1AF0A1C", Offset = "0x1AF0A1C", VA = "0x1AF0A1C")]
		private void LoadBanks(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000638")]
		[Address(RVA = "0x1AF303C", Offset = "0x1AF303C", VA = "0x1AF303C")]
		public static void UnloadBank(string bankName)
		{
		}

		[Token(Token = "0x6000639")]
		[Address(RVA = "0x1AF3174", Offset = "0x1AF3174", VA = "0x1AF3174")]
		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		[Token(Token = "0x600063A")]
		[Address(RVA = "0x1AF2FCC", Offset = "0x1AF2FCC", VA = "0x1AF2FCC")]
		public static void WaitForAllLoads()
		{
		}

		[Token(Token = "0x600063B")]
		[Address(RVA = "0x1AF32CC", Offset = "0x1AF32CC", VA = "0x1AF32CC")]
		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		[Token(Token = "0x600063C")]
		[Address(RVA = "0x1AED868", Offset = "0x1AED868", VA = "0x1AED868")]
		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600063D")]
		[Address(RVA = "0x1AF3400", Offset = "0x1AF3400", VA = "0x1AF3400")]
		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		[Token(Token = "0x600063E")]
		[Address(RVA = "0x1AF36A4", Offset = "0x1AF36A4", VA = "0x1AF36A4")]
		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x600063F")]
		[Address(RVA = "0x1AF3804", Offset = "0x1AF3804", VA = "0x1AF3804")]
		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		[Token(Token = "0x6000640")]
		[Address(RVA = "0x1AF38E4", Offset = "0x1AF38E4", VA = "0x1AF38E4")]
		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000641")]
		[Address(RVA = "0x1AF3A28", Offset = "0x1AF3A28", VA = "0x1AF3A28")]
		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		[Token(Token = "0x6000642")]
		[Address(RVA = "0x1AF3B10", Offset = "0x1AF3B10", VA = "0x1AF3B10")]
		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000643")]
		[Address(RVA = "0x1AF349C", Offset = "0x1AF349C", VA = "0x1AF349C")]
		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		[Token(Token = "0x6000644")]
		[Address(RVA = "0x1AF3C20", Offset = "0x1AF3C20", VA = "0x1AF3C20")]
		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000645")]
		[Address(RVA = "0x1AF3DFC", Offset = "0x1AF3DFC", VA = "0x1AF3DFC")]
		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000646")]
		[Address(RVA = "0x1AF3FE4", Offset = "0x1AF3FE4", VA = "0x1AF3FE4")]
		public static void SetListenerLocation(Transform transform)
		{
		}

		[Token(Token = "0x6000647")]
		[Address(RVA = "0x1AF412C", Offset = "0x1AF412C", VA = "0x1AF412C")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody)
		{
		}

		[Token(Token = "0x6000648")]
		[Address(RVA = "0x1AF41D8", Offset = "0x1AF41D8", VA = "0x1AF41D8")]
		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D)
		{
		}

		[Token(Token = "0x6000649")]
		[Address(RVA = "0x1AF4284", Offset = "0x1AF4284", VA = "0x1AF4284")]
		public static void SetListenerLocation(int listenerIndex, Transform transform)
		{
		}

		[Token(Token = "0x600064A")]
		[Address(RVA = "0x1AF4328", Offset = "0x1AF4328", VA = "0x1AF4328")]
		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		[Token(Token = "0x600064B")]
		[Address(RVA = "0x1AF43EC", Offset = "0x1AF43EC", VA = "0x1AF43EC")]
		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		[Token(Token = "0x600064C")]
		[Address(RVA = "0x1AF2544", Offset = "0x1AF2544", VA = "0x1AF2544")]
		public static void PauseAllEvents(bool paused)
		{
		}

		[Token(Token = "0x600064D")]
		[Address(RVA = "0x1AF45E4", Offset = "0x1AF45E4", VA = "0x1AF45E4")]
		public static void MuteAllEvents(bool muted)
		{
		}

		[Token(Token = "0x6000650")]
		[Address(RVA = "0x1AF4790", Offset = "0x1AF4790", VA = "0x1AF4790")]
		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0x1AF0864", Offset = "0x1AF0864", VA = "0x1AF0864")]
		private void LoadPlugins(Settings fmodSettings)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0x1AF0754", Offset = "0x1AF0754", VA = "0x1AF0754")]
		private void SetThreadAffinity()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0x1AF489C", Offset = "0x1AF489C", VA = "0x1AF489C")]
		public RuntimeManager()
		{
		}
	}
	[Token(Token = "0x20000F5")]
	public class EventNotFoundException : Exception
	{
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public Guid Guid;

		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public string Path;

		[Token(Token = "0x6000655")]
		[Address(RVA = "0x1AEE850", Offset = "0x1AEE850", VA = "0x1AEE850")]
		public EventNotFoundException(string path)
		{
		}

		[Token(Token = "0x6000656")]
		[Address(RVA = "0x1AEE8FC", Offset = "0x1AEE8FC", VA = "0x1AEE8FC")]
		public EventNotFoundException(Guid guid)
		{
		}
	}
	[Token(Token = "0x20000F6")]
	public class BusNotFoundException : Exception
	{
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000657")]
		[Address(RVA = "0x1AEE4F4", Offset = "0x1AEE4F4", VA = "0x1AEE4F4")]
		public BusNotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000F7")]
	public class VCANotFoundException : Exception
	{
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x6000658")]
		[Address(RVA = "0x1AF44B0", Offset = "0x1AF44B0", VA = "0x1AF44B0")]
		public VCANotFoundException(string path)
		{
		}
	}
	[Token(Token = "0x20000F8")]
	public class BankLoadException : Exception
	{
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public string Path;

		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public RESULT Result;

		[Token(Token = "0x6000659")]
		[Address(RVA = "0x1AEE330", Offset = "0x1AEE330", VA = "0x1AEE330")]
		public BankLoadException(string path, RESULT result)
		{
		}

		[Token(Token = "0x600065A")]
		[Address(RVA = "0x1AEE43C", Offset = "0x1AEE43C", VA = "0x1AEE43C")]
		public BankLoadException(string path, string error)
		{
		}
	}
	[Token(Token = "0x20000F9")]
	public class SystemNotInitializedException : Exception
	{
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public RESULT Result;

		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public string Location;

		[Token(Token = "0x600065B")]
		[Address(RVA = "0x1AEFE04", Offset = "0x1AEFE04", VA = "0x1AEFE04")]
		public SystemNotInitializedException(RESULT result, string location)
		{
		}

		[Token(Token = "0x600065C")]
		[Address(RVA = "0x1AEFD80", Offset = "0x1AEFD80", VA = "0x1AEFD80")]
		public SystemNotInitializedException(Exception inner)
		{
		}
	}
	[Token(Token = "0x20000FA")]
	public enum EmitterGameEvent
	{
		[Token(Token = "0x40004D2")]
		None,
		[Token(Token = "0x40004D3")]
		ObjectStart,
		[Token(Token = "0x40004D4")]
		ObjectDestroy,
		[Token(Token = "0x40004D5")]
		TriggerEnter,
		[Token(Token = "0x40004D6")]
		TriggerExit,
		[Token(Token = "0x40004D7")]
		TriggerEnter2D,
		[Token(Token = "0x40004D8")]
		TriggerExit2D,
		[Token(Token = "0x40004D9")]
		CollisionEnter,
		[Token(Token = "0x40004DA")]
		CollisionExit,
		[Token(Token = "0x40004DB")]
		CollisionEnter2D,
		[Token(Token = "0x40004DC")]
		CollisionExit2D,
		[Token(Token = "0x40004DD")]
		ObjectEnable,
		[Token(Token = "0x40004DE")]
		ObjectDisable,
		[Token(Token = "0x40004DF")]
		MouseEnter,
		[Token(Token = "0x40004E0")]
		MouseExit,
		[Token(Token = "0x40004E1")]
		MouseDown,
		[Token(Token = "0x40004E2")]
		MouseUp
	}
	[Token(Token = "0x20000FB")]
	public enum LoaderGameEvent
	{
		[Token(Token = "0x40004E4")]
		None,
		[Token(Token = "0x40004E5")]
		ObjectStart,
		[Token(Token = "0x40004E6")]
		ObjectDestroy,
		[Token(Token = "0x40004E7")]
		TriggerEnter,
		[Token(Token = "0x40004E8")]
		TriggerExit,
		[Token(Token = "0x40004E9")]
		TriggerEnter2D,
		[Token(Token = "0x40004EA")]
		TriggerExit2D
	}
	[Token(Token = "0x20000FC")]
	public static class RuntimeUtils
	{
		[Token(Token = "0x40004EB")]
		private const string BankExtension = ".bank";

		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1AF4E14", Offset = "0x1AF4E14", VA = "0x1AF4E14")]
		public static string GetCommonPlatformPath(string path)
		{
			return null;
		}

		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1AF4E68", Offset = "0x1AF4E68", VA = "0x1AF4E68")]
		public static VECTOR ToFMODVector(this Vector3 vec)
		{
			return default(VECTOR);
		}

		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1AEDB5C", Offset = "0x1AEDB5C", VA = "0x1AEDB5C")]
		public static ATTRIBUTES_3D To3DAttributes(this Vector3 pos)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1AF407C", Offset = "0x1AF407C", VA = "0x1AF407C")]
		public static ATTRIBUTES_3D To3DAttributes(this Transform transform)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1AF1AA8", Offset = "0x1AF1AA8", VA = "0x1AF1AA8")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1AF3CC8", Offset = "0x1AF3CC8", VA = "0x1AF3CC8")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, [Optional] Rigidbody rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1AF1BD0", Offset = "0x1AF1BD0", VA = "0x1AF1BD0")]
		public static ATTRIBUTES_3D To3DAttributes(Transform transform, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1AF3EA4", Offset = "0x1AF3EA4", VA = "0x1AF3EA4")]
		public static ATTRIBUTES_3D To3DAttributes(GameObject go, Rigidbody2D rigidbody)
		{
			return default(ATTRIBUTES_3D);
		}

		[Token(Token = "0x6000665")]
		[Address(RVA = "0x1AF0244", Offset = "0x1AF0244", VA = "0x1AF0244")]
		internal static FMODPlatform GetCurrentPlatform()
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000666")]
		[Address(RVA = "0x1AF2C40", Offset = "0x1AF2C40", VA = "0x1AF2C40")]
		internal static string GetBankPath(string bankName)
		{
			return null;
		}

		[Token(Token = "0x6000667")]
		[Address(RVA = "0x1AF4820", Offset = "0x1AF4820", VA = "0x1AF4820")]
		internal static string GetPluginPath(string pluginName)
		{
			return null;
		}

		[Token(Token = "0x6000668")]
		[Address(RVA = "0x1AEF688", Offset = "0x1AEF688", VA = "0x1AEF688")]
		public static void EnforceLibraryOrder()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x20000FD")]
	public enum FMODPlatform
	{
		[Token(Token = "0x40004ED")]
		None,
		[Token(Token = "0x40004EE")]
		PlayInEditor,
		[Token(Token = "0x40004EF")]
		Default,
		[Token(Token = "0x40004F0")]
		Desktop,
		[Token(Token = "0x40004F1")]
		Mobile,
		[Token(Token = "0x40004F2")]
		MobileHigh,
		[Token(Token = "0x40004F3")]
		MobileLow,
		[Token(Token = "0x40004F4")]
		Console,
		[Token(Token = "0x40004F5")]
		Windows,
		[Token(Token = "0x40004F6")]
		Mac,
		[Token(Token = "0x40004F7")]
		Linux,
		[Token(Token = "0x40004F8")]
		iOS,
		[Token(Token = "0x40004F9")]
		Android,
		[Token(Token = "0x40004FA")]
		Deprecated_1,
		[Token(Token = "0x40004FB")]
		XboxOne,
		[Token(Token = "0x40004FC")]
		PS4,
		[Token(Token = "0x40004FD")]
		Deprecated_2,
		[Token(Token = "0x40004FE")]
		Deprecated_3,
		[Token(Token = "0x40004FF")]
		AppleTV,
		[Token(Token = "0x4000500")]
		UWP,
		[Token(Token = "0x4000501")]
		Switch,
		[Token(Token = "0x4000502")]
		WebGL,
		[Token(Token = "0x4000503")]
		Count
	}
	[Serializable]
	[Token(Token = "0x20000FE")]
	public enum ImportType
	{
		[Token(Token = "0x4000505")]
		StreamingAssets,
		[Token(Token = "0x4000506")]
		AssetBundle
	}
	[Serializable]
	[Token(Token = "0x20000FF")]
	public enum BankLoadType
	{
		[Token(Token = "0x4000508")]
		All,
		[Token(Token = "0x4000509")]
		Specified,
		[Token(Token = "0x400050A")]
		None
	}
	[Token(Token = "0x2000100")]
	public class PlatformSettingBase
	{
		[Token(Token = "0x400050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public FMODPlatform Platform;

		[Token(Token = "0x6000669")]
		[Address(RVA = "0x1AEEC2C", Offset = "0x1AEEC2C", VA = "0x1AEEC2C")]
		public PlatformSettingBase()
		{
		}
	}
	[Token(Token = "0x2000101")]
	public class PlatformSetting<T> : PlatformSettingBase
	{
		[Token(Token = "0x400050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T Value;

		[Token(Token = "0x600066A")]
		public PlatformSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000102")]
	public class PlatformIntSetting : PlatformSetting<int>
	{
		[Token(Token = "0x600066B")]
		[Address(RVA = "0x1AEEBDC", Offset = "0x1AEEBDC", VA = "0x1AEEBDC")]
		public PlatformIntSetting()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x2000103")]
	public class PlatformStringSetting : PlatformSetting<string>
	{
		[Token(Token = "0x600066C")]
		[Address(RVA = "0x1AEEC34", Offset = "0x1AEEC34", VA = "0x1AEEC34")]
		public PlatformStringSetting()
		{
		}
	}
	[Token(Token = "0x2000104")]
	public enum TriStateBool
	{
		[Token(Token = "0x400050E")]
		Disabled,
		[Token(Token = "0x400050F")]
		Enabled,
		[Token(Token = "0x4000510")]
		Development
	}
	[Serializable]
	[Token(Token = "0x2000105")]
	public class PlatformBoolSetting : PlatformSetting<TriStateBool>
	{
		[Token(Token = "0x600066D")]
		[Address(RVA = "0x1AEEB8C", Offset = "0x1AEEB8C", VA = "0x1AEEB8C")]
		public PlatformBoolSetting()
		{
		}
	}
	[Token(Token = "0x2000106")]
	public class Settings : ScriptableObject
	{
		[Token(Token = "0x2000117")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA44", Offset = "0x8DCA44")]
		private sealed class <>c__DisplayClass40_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x400057B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006CC")]
			public <>c__DisplayClass40_0()
			{
			}

			[Token(Token = "0x60006CD")]
			internal bool <HasSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA54", Offset = "0x8DCA54")]
		private sealed class <>c__DisplayClass41_0<T, U> where T : PlatformSetting<U>
		{
			[Token(Token = "0x400057C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006CE")]
			public <>c__DisplayClass41_0()
			{
			}

			[Token(Token = "0x60006CF")]
			internal bool <GetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x2000119")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA64", Offset = "0x8DCA64")]
		private sealed class <>c__DisplayClass42_0<T, U> where T : PlatformSetting<U>, new()
		{
			[Token(Token = "0x400057D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006D0")]
			public <>c__DisplayClass42_0()
			{
			}

			[Token(Token = "0x60006D1")]
			internal bool <SetSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x200011A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x8DCA74", Offset = "0x8DCA74")]
		private sealed class <>c__DisplayClass43_0<T> where T : PlatformSettingBase
		{
			[Token(Token = "0x400057E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FMODPlatform platform;

			[Token(Token = "0x60006D2")]
			public <>c__DisplayClass43_0()
			{
			}

			[Token(Token = "0x60006D3")]
			internal bool <RemoveSetting>b__0(T x)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool SwitchSettingsMigration;

		[Token(Token = "0x4000512")]
		private const string SettingsAssetName = "FMODStudioSettings";

		[Token(Token = "0x4000513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Settings instance;

		[Token(Token = "0x4000514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
		[SerializeField]
		public bool HasSourceProject;

		[Token(Token = "0x4000515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
		[SerializeField]
		public bool HasPlatforms;

		[Token(Token = "0x4000516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string sourceProjectPath;

		[Token(Token = "0x4000517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string SourceBankPathUnformatted;

		[Token(Token = "0x4000518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		public bool AutomaticEventLoading;

		[Token(Token = "0x4000519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		public BankLoadType BankLoadType;

		[Token(Token = "0x400051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		public bool AutomaticSampleLoading;

		[Token(Token = "0x400051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		public string EncryptionKey;

		[Token(Token = "0x400051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		public ImportType ImportType;

		[Token(Token = "0x400051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		public string TargetAssetPath;

		[Token(Token = "0x400051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public DEBUG_FLAGS LoggingLevel;

		[Token(Token = "0x400051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		public List<PlatformIntSetting> SpeakerModeSettings;

		[Token(Token = "0x4000520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		public List<PlatformIntSetting> SampleRateSettings;

		[Token(Token = "0x4000521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<PlatformBoolSetting> LiveUpdateSettings;

		[Token(Token = "0x4000522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		public List<PlatformBoolSetting> OverlaySettings;

		[Token(Token = "0x4000523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public List<PlatformBoolSetting> LoggingSettings;

		[Token(Token = "0x4000524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		public List<PlatformStringSetting> BankDirectorySettings;

		[Token(Token = "0x4000525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		public List<PlatformIntSetting> VirtualChannelSettings;

		[Token(Token = "0x4000526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		public List<PlatformIntSetting> RealChannelSettings;

		[Token(Token = "0x4000527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		public List<string> Plugins;

		[Token(Token = "0x4000528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		public List<string> MasterBanks;

		[Token(Token = "0x4000529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		public List<string> Banks;

		[Token(Token = "0x400052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		public List<string> BanksToLoad;

		[Token(Token = "0x400052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		public ushort LiveUpdatePort;

		[Token(Token = "0x1700000C")]
		public static Settings Instance
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x1AF0034", Offset = "0x1AF0034", VA = "0x1AF0034")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000D")]
		public string SourceProjectPathRelative
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x1AF4E6C", Offset = "0x1AF4E6C", VA = "0x1AF4E6C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000670")]
			[Address(RVA = "0x1AF4E74", Offset = "0x1AF4E74", VA = "0x1AF4E74")]
			set
			{
			}
		}

		[Token(Token = "0x1700000E")]
		public string SourceProjectPathFull
		{
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x1AF4E9C", Offset = "0x1AF4E9C", VA = "0x1AF4E9C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000F")]
		public string SourceBankPathRelative
		{
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x1AF4F30", Offset = "0x1AF4F30", VA = "0x1AF4F30")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x1AF4F38", Offset = "0x1AF4F38", VA = "0x1AF4F38")]
			set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public string SourceBankPathFull
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x1AF4F60", Offset = "0x1AF4F60", VA = "0x1AF4F60")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000675")]
		[Address(RVA = "0x1AF4FF4", Offset = "0x1AF4FF4", VA = "0x1AF4FF4")]
		public static FMODPlatform GetParent(FMODPlatform platform)
		{
			return default(FMODPlatform);
		}

		[Token(Token = "0x6000676")]
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
			return default(bool);
		}

		[Token(Token = "0x6000677")]
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def) where T : PlatformSetting<U>
		{
			return (U)null;
		}

		[Token(Token = "0x6000678")]
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value) where T : PlatformSetting<U>, new()
		{
		}

		[Token(Token = "0x6000679")]
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform) where T : PlatformSettingBase
		{
		}

		[Token(Token = "0x600067A")]
		[Address(RVA = "0x1AF07D0", Offset = "0x1AF07D0", VA = "0x1AF07D0")]
		public bool IsLiveUpdateEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600067B")]
		[Address(RVA = "0x1AF1E84", Offset = "0x1AF1E84", VA = "0x1AF1E84")]
		public bool IsOverlayEnabled(FMODPlatform platform)
		{
			return default(bool);
		}

		[Token(Token = "0x600067C")]
		[Address(RVA = "0x1AF05BC", Offset = "0x1AF05BC", VA = "0x1AF05BC")]
		public int GetRealChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600067D")]
		[Address(RVA = "0x1AF0644", Offset = "0x1AF0644", VA = "0x1AF0644")]
		public int GetVirtualChannels(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600067E")]
		[Address(RVA = "0x1AF06CC", Offset = "0x1AF06CC", VA = "0x1AF06CC")]
		public int GetSpeakerMode(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x600067F")]
		[Address(RVA = "0x1AF0534", Offset = "0x1AF0534", VA = "0x1AF0534")]
		public int GetSampleRate(FMODPlatform platform)
		{
			return default(int);
		}

		[Token(Token = "0x6000680")]
		[Address(RVA = "0x1AF5048", Offset = "0x1AF5048", VA = "0x1AF5048")]
		public string GetBankPlatform(FMODPlatform platform)
		{
			return null;
		}

		[Token(Token = "0x6000681")]
		[Address(RVA = "0x1AF50F4", Offset = "0x1AF50F4", VA = "0x1AF50F4")]
		private Settings()
		{
		}

		[Token(Token = "0x6000682")]
		[Address(RVA = "0x1AF5408", Offset = "0x1AF5408", VA = "0x1AF5408")]
		private void OnEnable()
		{
		}
	}
	[Token(Token = "0x2000107")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC8EC", Offset = "0x8DC8EC")]
	public class StudioBankLoader : MonoBehaviour
	{
		[Token(Token = "0x400052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LoaderGameEvent LoadEvent;

		[Token(Token = "0x400052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public LoaderGameEvent UnloadEvent;

		[Token(Token = "0x400052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[BankRef]
		public List<string> Banks;

		[Token(Token = "0x400052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string CollisionTag;

		[Token(Token = "0x4000530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool PreloadSamples;

		[Token(Token = "0x4000531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool isQuitting;

		[Token(Token = "0x6000684")]
		[Address(RVA = "0x1AF55F4", Offset = "0x1AF55F4", VA = "0x1AF55F4")]
		private void HandleGameEvent(LoaderGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000685")]
		[Address(RVA = "0x1AF5978", Offset = "0x1AF5978", VA = "0x1AF5978")]
		private void Start()
		{
		}

		[Token(Token = "0x6000686")]
		[Address(RVA = "0x1AF59A0", Offset = "0x1AF59A0", VA = "0x1AF59A0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000687")]
		[Address(RVA = "0x1AF59AC", Offset = "0x1AF59AC", VA = "0x1AF59AC")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000688")]
		[Address(RVA = "0x1AF59C0", Offset = "0x1AF59C0", VA = "0x1AF59C0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x6000689")]
		[Address(RVA = "0x1AF5A24", Offset = "0x1AF5A24", VA = "0x1AF5A24")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600068A")]
		[Address(RVA = "0x1AF5A88", Offset = "0x1AF5A88", VA = "0x1AF5A88")]
		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		[Token(Token = "0x600068B")]
		[Address(RVA = "0x1AF5AEC", Offset = "0x1AF5AEC", VA = "0x1AF5AEC")]
		private void OnTriggerExit2D(Collider2D other)
		{
		}

		[Token(Token = "0x600068C")]
		[Address(RVA = "0x1AF5644", Offset = "0x1AF5644", VA = "0x1AF5644")]
		public void Load()
		{
		}

		[Token(Token = "0x600068D")]
		[Address(RVA = "0x1AF585C", Offset = "0x1AF585C", VA = "0x1AF585C")]
		public void Unload()
		{
		}

		[Token(Token = "0x600068E")]
		[Address(RVA = "0x1AF5B50", Offset = "0x1AF5B50", VA = "0x1AF5B50")]
		public StudioBankLoader()
		{
		}
	}
	[Token(Token = "0x2000108")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC924", Offset = "0x8DC924")]
	public class StudioEventEmitter : EventHandler
	{
		[Token(Token = "0x4000532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[EventRef]
		public string Event;

		[Token(Token = "0x4000533")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent PlayEvent;

		[Token(Token = "0x4000534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public EmitterGameEvent StopEvent;

		[Token(Token = "0x4000535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool AllowFadeout;

		[Token(Token = "0x4000536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		public bool TriggerOnce;

		[Token(Token = "0x4000537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
		public bool Preload;

		[Token(Token = "0x4000538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public ParamRef[] Params;

		[Token(Token = "0x4000539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public bool OverrideAttenuation;

		[Token(Token = "0x400053A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float OverrideMinDistance;

		[Token(Token = "0x400053B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public float OverrideMaxDistance;

		[Token(Token = "0x400053C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		protected EventDescription eventDescription;

		[Token(Token = "0x400053D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		protected EventInstance instance;

		[Token(Token = "0x400053E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool hasTriggered;

		[Token(Token = "0x400053F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x61")]
		private bool isQuitting;

		[Token(Token = "0x4000540")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x62")]
		private bool isOneshot;

		[Token(Token = "0x4000541")]
		private const string SnapshotString = "snapshot";

		[Token(Token = "0x17000011")]
		public EventDescription EventDescription
		{
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x1AF5B58", Offset = "0x1AF5B58", VA = "0x1AF5B58")]
			get
			{
				return default(EventDescription);
			}
		}

		[Token(Token = "0x17000012")]
		public EventInstance EventInstance
		{
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x1AF5B60", Offset = "0x1AF5B60", VA = "0x1AF5B60")]
			get
			{
				return default(EventInstance);
			}
		}

		[Token(Token = "0x6000691")]
		[Address(RVA = "0x1AF5B68", Offset = "0x1AF5B68", VA = "0x1AF5B68")]
		private void Start()
		{
		}

		[Token(Token = "0x6000692")]
		[Address(RVA = "0x1AF5D84", Offset = "0x1AF5D84", VA = "0x1AF5D84")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000693")]
		[Address(RVA = "0x1AF5D90", Offset = "0x1AF5D90", VA = "0x1AF5D90")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000694")]
		[Address(RVA = "0x1AF5E84", Offset = "0x1AF5E84", VA = "0x1AF5E84", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x6000695")]
		[Address(RVA = "0x1AF5C50", Offset = "0x1AF5C50", VA = "0x1AF5C50")]
		private void Lookup()
		{
		}

		[Token(Token = "0x6000696")]
		[Address(RVA = "0x1AF5ED4", Offset = "0x1AF5ED4", VA = "0x1AF5ED4")]
		public void Play()
		{
		}

		[Token(Token = "0x6000697")]
		[Address(RVA = "0x1AF6214", Offset = "0x1AF6214", VA = "0x1AF6214")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000698")]
		[Address(RVA = "0x1AF627C", Offset = "0x1AF627C", VA = "0x1AF627C")]
		public void SetParameter(string name, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x6000699")]
		[Address(RVA = "0x1AF62EC", Offset = "0x1AF62EC", VA = "0x1AF62EC")]
		public void SetParameter(PARAMETER_ID id, float value, bool ignoreseekspeed = false)
		{
		}

		[Token(Token = "0x600069A")]
		[Address(RVA = "0x1AF635C", Offset = "0x1AF635C", VA = "0x1AF635C")]
		public bool IsPlaying()
		{
			return default(bool);
		}

		[Token(Token = "0x600069B")]
		[Address(RVA = "0x1AF63C8", Offset = "0x1AF63C8", VA = "0x1AF63C8")]
		public StudioEventEmitter()
		{
		}
	}
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC95C", Offset = "0x8DC95C")]
	public class StudioGlobalParameterTrigger : EventHandler
	{
		[Token(Token = "0x4000542")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[ParamRef]
		public string parameter;

		[Token(Token = "0x4000543")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x4000544")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float value;

		[Token(Token = "0x4000545")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private PARAMETER_DESCRIPTION parameterDescription;

		[Token(Token = "0x17000013")]
		public PARAMETER_DESCRIPTION ParameterDesctription
		{
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x1AF6448", Offset = "0x1AF6448", VA = "0x1AF6448")]
			get
			{
				return default(PARAMETER_DESCRIPTION);
			}
		}

		[Token(Token = "0x600069D")]
		[Address(RVA = "0x1AF6464", Offset = "0x1AF6464", VA = "0x1AF6464")]
		private RESULT Lookup()
		{
			return default(RESULT);
		}

		[Token(Token = "0x600069E")]
		[Address(RVA = "0x1AF64EC", Offset = "0x1AF64EC", VA = "0x1AF64EC")]
		private void Awake()
		{
		}

		[Token(Token = "0x600069F")]
		[Address(RVA = "0x1AF6530", Offset = "0x1AF6530", VA = "0x1AF6530", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60006A0")]
		[Address(RVA = "0x1AF6544", Offset = "0x1AF6544", VA = "0x1AF6544")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60006A1")]
		[Address(RVA = "0x1AF6658", Offset = "0x1AF6658", VA = "0x1AF6658")]
		public StudioGlobalParameterTrigger()
		{
		}
	}
	[Token(Token = "0x200010A")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC994", Offset = "0x8DC994")]
	public class StudioListener : MonoBehaviour
	{
		[Token(Token = "0x4000546")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Rigidbody rigidBody;

		[Token(Token = "0x4000547")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Rigidbody2D rigidBody2D;

		[Token(Token = "0x4000548")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int ListenerNumber;

		[Token(Token = "0x60006A2")]
		[Address(RVA = "0x1AF665C", Offset = "0x1AF665C", VA = "0x1AF665C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x1AF6718", Offset = "0x1AF6718", VA = "0x1AF6718")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x1AF677C", Offset = "0x1AF677C", VA = "0x1AF677C")]
		private void Update()
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x1AF6790", Offset = "0x1AF6790", VA = "0x1AF6790")]
		private void SetListenerLocation()
		{
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x1AF688C", Offset = "0x1AF688C", VA = "0x1AF688C")]
		public StudioListener()
		{
		}
	}
	[Serializable]
	[Token(Token = "0x200010B")]
	public class EmitterRef
	{
		[Token(Token = "0x4000549")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter Target;

		[Token(Token = "0x400054A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ParamRef[] Params;

		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x1AEE5A0", Offset = "0x1AEE5A0", VA = "0x1AEE5A0")]
		public EmitterRef()
		{
		}
	}
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "AddComponentMenu", RVA = "0x8DC9CC", Offset = "0x8DC9CC")]
	public class StudioParameterTrigger : EventHandler
	{
		[Token(Token = "0x400054B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public EmitterRef[] Emitters;

		[Token(Token = "0x400054C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public EmitterGameEvent TriggerEvent;

		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x1AF689C", Offset = "0x1AF689C", VA = "0x1AF689C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x1AF6A9C", Offset = "0x1AF6A9C", VA = "0x1AF6A9C", Slot = "4")]
		protected override void HandleGameEvent(EmitterGameEvent gameEvent)
		{
		}

		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x1AF6AB0", Offset = "0x1AF6AB0", VA = "0x1AF6AB0")]
		public void TriggerParameters()
		{
		}

		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x1AF6C50", Offset = "0x1AF6C50", VA = "0x1AF6C50")]
		public StudioParameterTrigger()
		{
		}
	}
}
namespace FMODUnity.Timeline
{
	[Token(Token = "0x200010D")]
	public static class FMODTracksManager
	{
		[Token(Token = "0x400054D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Action<string> OnProcessing;

		[Token(Token = "0x400054E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action OnEnded;

		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x1AEDCD8", Offset = "0x1AEDCD8", VA = "0x1AEDCD8")]
		public static void RunSubtitles(string token)
		{
		}

		[Token(Token = "0x60006AD")]
		[Address(RVA = "0x1AED19C", Offset = "0x1AED19C", VA = "0x1AED19C")]
		public static void EraseSubtitles()
		{
		}
	}
}
