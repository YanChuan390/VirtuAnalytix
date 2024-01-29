using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using ExitGames.Client.Photon;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using MonsterLove.Collections;
using Multiplayer.UI;
using Oculus.Avatar2;
using Oculus.Platform;
using Oculus.Platform.Models;
using Photon.Pun;
using Photon.Realtime;
using Photon.Voice.Unity;
using Shapes;
using Sirenix.OdinInspector;
using TMPro;
using TheVegetationEngine;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.Networking;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;
using VR.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Token(Token = "0x2000002")]
public class RiverFractalAnimator : MonoBehaviour
{
	[Token(Token = "0x4000001")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float _Speed;

	[Token(Token = "0x4000002")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private int noiseTextureSize;

	[Token(Token = "0x4000003")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private float internalTimer;

	[Token(Token = "0x4000004")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private int offset;

	[Token(Token = "0x4000005")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Material Material;

	[Token(Token = "0x4000006")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private System.Random rand;

	[Token(Token = "0x6000001")]
	[Address(RVA = "0x138C578", Offset = "0x138C578", VA = "0x138C578")]
	private void Start()
	{
	}

	[Token(Token = "0x6000002")]
	[Address(RVA = "0x138C608", Offset = "0x138C608", VA = "0x138C608")]
	private void Update()
	{
	}

	[Token(Token = "0x6000003")]
	[Address(RVA = "0x138C6CC", Offset = "0x138C6CC", VA = "0x138C6CC")]
	private void UpdateShader()
	{
	}

	[Token(Token = "0x6000004")]
	[Address(RVA = "0x138C78C", Offset = "0x138C78C", VA = "0x138C78C")]
	public RiverFractalAnimator()
	{
	}
}
[Token(Token = "0x2000003")]
public class SunGlareFx : MonoBehaviour
{
	[Token(Token = "0x2000004")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3CFC", Offset = "0xAE3CFC")]
	private sealed class <Start>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400000A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400000B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SunGlareFx <>4__this;

		[Token(Token = "0x17000001")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x1677010", Offset = "0x1677010", VA = "0x1677010", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000002")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x1677058", Offset = "0x1677058", VA = "0x1677058", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x1676CF0", Offset = "0x1676CF0", VA = "0x1676CF0")]
		[DebuggerHidden]
		public <Start>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x1676D1C", Offset = "0x1676D1C", VA = "0x1676D1C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x1676D20", Offset = "0x1676D20", VA = "0x1676D20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x1677018", Offset = "0x1677018", VA = "0x1677018", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000007")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer SatDataMesh;

	[Token(Token = "0x4000008")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int GlareMask;

	[Token(Token = "0x6000005")]
	[Address(RVA = "0x13947C0", Offset = "0x13947C0", VA = "0x13947C0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEABD4", Offset = "0xAEABD4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000006")]
	[Address(RVA = "0x139482C", Offset = "0x139482C", VA = "0x139482C")]
	public SunGlareFx()
	{
	}
}
[Token(Token = "0x2000005")]
public class Bird : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D0C", Offset = "0xAE3D0C")]
	private sealed class <FindWaypoint>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400001A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400001B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400001C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Bird <>4__this;

		[Token(Token = "0x17000003")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0xE3F84C", Offset = "0xE3F84C", VA = "0xE3F84C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0xE3F894", Offset = "0xE3F894", VA = "0xE3F894", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0xE3F740", Offset = "0xE3F740", VA = "0xE3F740")]
		[DebuggerHidden]
		public <FindWaypoint>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0xE3F76C", Offset = "0xE3F76C", VA = "0xE3F76C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0xE3F770", Offset = "0xE3F770", VA = "0xE3F770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0xE3F854", Offset = "0xE3F854", VA = "0xE3F854", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400000C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform RollTransform;

	[Token(Token = "0x400000D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE4F48", Offset = "0xAE4F48")]
	public float GlidingAngle;

	[Token(Token = "0x400000E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal FlockController Controller;

	[Token(Token = "0x400000F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3 CurrentWaypoint;

	[Token(Token = "0x4000010")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private float TargetSpeed;

	[Token(Token = "0x4000011")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float TargetTurnSpeed;

	[Token(Token = "0x4000012")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float CurrentSpeed;

	[Token(Token = "0x4000013")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Animator Animator;

	[Token(Token = "0x4000014")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int GLIDE;

	[Token(Token = "0x4000015")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int FLAP;

	[Token(Token = "0x4000016")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool ForceGliding;

	[Token(Token = "0x4000017")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool ForceFlapping;

	[Token(Token = "0x4000018")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float ForcedAnimationTimeStart;

	[Token(Token = "0x4000019")]
	private const float ForcedAnimationDuration = 5f;

	[Token(Token = "0x600000E")]
	[Address(RVA = "0x1195B30", Offset = "0x1195B30", VA = "0x1195B30")]
	private void Start()
	{
	}

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1195DA8", Offset = "0x1195DA8", VA = "0x1195DA8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x1195D1C", Offset = "0x1195D1C", VA = "0x1195D1C")]
	public void Wander()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x1195DD4", Offset = "0x1195DD4", VA = "0x1195DD4")]
	private void Rotate()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1196094", Offset = "0x1196094", VA = "0x1196094")]
	private void Move()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x1196204", Offset = "0x1196204", VA = "0x1196204")]
	private void Animate()
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x11963BC", Offset = "0x11963BC", VA = "0x11963BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAC84", Offset = "0xAEAC84")]
	private IEnumerator FindWaypoint()
	{
		return null;
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x1195C54", Offset = "0x1195C54", VA = "0x1195C54")]
	private Vector3 GetWaypoint()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x1196428", Offset = "0x1196428", VA = "0x1196428")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x1196480", Offset = "0x1196480", VA = "0x1196480")]
	public Bird()
	{
	}
}
[Token(Token = "0x2000007")]
public class BirdRandomTexture : MonoBehaviour
{
	[Token(Token = "0x400001D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MaterialInfo[] MaterialInfos;

	[Token(Token = "0x600001F")]
	[Address(RVA = "0x119652C", Offset = "0x119652C", VA = "0x119652C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000020")]
	[Address(RVA = "0x1196530", Offset = "0x1196530", VA = "0x1196530")]
	private void Randomize()
	{
	}

	[Token(Token = "0x6000021")]
	[Address(RVA = "0x11967A8", Offset = "0x11967A8", VA = "0x11967A8")]
	public BirdRandomTexture()
	{
	}
}
[Serializable]
[Token(Token = "0x2000008")]
public class MaterialInfo
{
	[Token(Token = "0x400001E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int RendererIndex;

	[Token(Token = "0x400001F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int MaterialIndex;

	[Token(Token = "0x4000020")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int LODIndex;

	[Token(Token = "0x4000021")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture[] Textures;

	[Token(Token = "0x6000022")]
	[Address(RVA = "0xFFAF14", Offset = "0xFFAF14", VA = "0xFFAF14")]
	public MaterialInfo()
	{
	}
}
[Token(Token = "0x2000009")]
public class RavenAnimationEventHandler : MonoBehaviour
{
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x138C28C", Offset = "0x138C28C", VA = "0x138C28C")]
	public void PlaySound(string str)
	{
	}

	[Token(Token = "0x6000024")]
	[Address(RVA = "0x138C370", Offset = "0x138C370", VA = "0x138C370")]
	public RavenAnimationEventHandler()
	{
	}
}
[Token(Token = "0x200000A")]
public class RavenRandomIdleAnimation : StateMachineBehaviour
{
	[Token(Token = "0x4000022")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int NumberOfAnimations;

	[Token(Token = "0x4000023")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string IntegerParamName;

	[Token(Token = "0x6000025")]
	[Address(RVA = "0x138C378", Offset = "0x138C378", VA = "0x138C378", Slot = "4")]
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	[Token(Token = "0x6000026")]
	[Address(RVA = "0x138C3E8", Offset = "0x138C3E8", VA = "0x138C3E8")]
	public RavenRandomIdleAnimation()
	{
	}
}
[Token(Token = "0x200000B")]
public class FlockController : NetworkSyncedObject
{
	[Token(Token = "0x200000C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D1C", Offset = "0xAE3D1C")]
	private sealed class <EnableDelayed>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000032")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000033")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000034")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameObject bird;

		[Token(Token = "0x17000005")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000034")]
			[Address(RVA = "0xE40AC0", Offset = "0xE40AC0", VA = "0xE40AC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000006")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0xE40B08", Offset = "0xE40B08", VA = "0xE40B08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0xE409B8", Offset = "0xE409B8", VA = "0xE409B8")]
		[DebuggerHidden]
		public <EnableDelayed>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0xE409E4", Offset = "0xE409E4", VA = "0xE409E4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0xE409E8", Offset = "0xE409E8", VA = "0xE409E8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0xE40AC8", Offset = "0xE40AC8", VA = "0xE40AC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200000D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D2C", Offset = "0xAE3D2C")]
	private sealed class <SetFlockRandomPosition>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlockController <>4__this;

		[Token(Token = "0x17000007")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600003A")]
			[Address(RVA = "0xE40D88", Offset = "0xE40D88", VA = "0xE40D88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000008")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600003C")]
			[Address(RVA = "0xE40DD0", Offset = "0xE40DD0", VA = "0xE40DD0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0xE40B10", Offset = "0xE40B10", VA = "0xE40B10")]
		[DebuggerHidden]
		public <SetFlockRandomPosition>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0xE40B3C", Offset = "0xE40B3C", VA = "0xE40B3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0xE40B40", Offset = "0xE40B40", VA = "0xE40B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0xE40D90", Offset = "0xE40D90", VA = "0xE40D90", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000024")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject BirdPrefab;

	[Token(Token = "0x4000025")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE4F60", Offset = "0xAE4F60")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE4F60", Offset = "0xAE4F60")]
	public float FlyZoneRadius;

	[Token(Token = "0x4000026")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE4FB8", Offset = "0xAE4FB8")]
	public float FlyZoneHeight;

	[Token(Token = "0x4000027")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 SpawnOffset;

	[Token(Token = "0x4000028")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE4FD0", Offset = "0xAE4FD0")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE4FD0", Offset = "0xAE4FD0")]
	public int Amount;

	[Token(Token = "0x4000029")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 MinMaxSpeed;

	[Token(Token = "0x400002A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector2 MinMaxTurnSpeed;

	[Token(Token = "0x400002B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector2 MinMaxScale;

	[Token(Token = "0x400002C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5028", Offset = "0xAE5028")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE5028", Offset = "0xAE5028")]
	public float FlockSize;

	[Token(Token = "0x400002D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	public Vector2 WaypointChangeFlockDelay;

	[Token(Token = "0x400002E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	public float WaypointChangeBirdDelayMax;

	[Token(Token = "0x400002F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	internal Vector3 PositionBuffer;

	[Token(Token = "0x4000030")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly List<Bird> Birds;

	[Token(Token = "0x4000031")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine SetFlockRandomPositionCoroutine;

	[Token(Token = "0x6000027")]
	[Address(RVA = "0x15D8FDC", Offset = "0x15D8FDC", VA = "0x15D8FDC", Slot = "54")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000028")]
	[Address(RVA = "0x15D91C4", Offset = "0x15D91C4", VA = "0x15D91C4", Slot = "28")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x6000029")]
	[Address(RVA = "0x15D927C", Offset = "0x15D927C", VA = "0x15D927C", Slot = "29")]
	public override void OnDisable()
	{
	}

	[Token(Token = "0x600002A")]
	[Address(RVA = "0x15D9158", Offset = "0x15D9158", VA = "0x15D9158")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAD34", Offset = "0xAEAD34")]
	private IEnumerator EnableDelayed(GameObject bird)
	{
		return null;
	}

	[Token(Token = "0x600002B")]
	[Address(RVA = "0x15D9210", Offset = "0x15D9210", VA = "0x15D9210")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAD94", Offset = "0xAEAD94")]
	private IEnumerator SetFlockRandomPosition()
	{
		return null;
	}

	[Token(Token = "0x600002C")]
	[Address(RVA = "0x15D92C4", Offset = "0x15D92C4", VA = "0x15D92C4")]
	private void Wander()
	{
	}

	[Token(Token = "0x600002D")]
	[Address(RVA = "0x15D94D0", Offset = "0x15D94D0", VA = "0x15D94D0")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEADF4", Offset = "0xAEADF4")]
	private void RPC_WanderClient(Vector3 position)
	{
	}

	[Token(Token = "0x600002E")]
	[Address(RVA = "0x15D93EC", Offset = "0x15D93EC", VA = "0x15D93EC")]
	private Vector3 GetRandomPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600002F")]
	[Address(RVA = "0x15D960C", Offset = "0x15D960C", VA = "0x15D960C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000030")]
	[Address(RVA = "0x15D9694", Offset = "0x15D9694", VA = "0x15D9694")]
	public FlockController()
	{
	}
}
[Token(Token = "0x200000E")]
public class Butterfly : MonoBehaviour
{
	[Token(Token = "0x200000F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D3C", Offset = "0xAE3D3C")]
	private sealed class <SetFlockRandomPosition>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Butterfly <>4__this;

		[Token(Token = "0x17000009")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600004B")]
			[Address(RVA = "0xE40450", Offset = "0xE40450", VA = "0xE40450", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0xE40498", Offset = "0xE40498", VA = "0xE40498", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000048")]
		[Address(RVA = "0xE4036C", Offset = "0xE4036C", VA = "0xE4036C")]
		[DebuggerHidden]
		public <SetFlockRandomPosition>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0xE40398", Offset = "0xE40398", VA = "0xE40398", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0xE4039C", Offset = "0xE4039C", VA = "0xE4039C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0xE40458", Offset = "0xE40458", VA = "0xE40458", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000038")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float FlyZoneRadius;

	[Token(Token = "0x4000039")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public float FlyZoneHeight;

	[Token(Token = "0x400003A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Vector2 MinMaxSpeed;

	[Token(Token = "0x400003B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector2 MinMaxScale;

	[Token(Token = "0x400003C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 MinMaxTurnSpeed;

	[Token(Token = "0x400003D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 SpawnOffset;

	[Token(Token = "0x400003E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 WaypointChangeDelay;

	[Token(Token = "0x400003F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public float AnimationSpeed;

	[Token(Token = "0x4000040")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Vector3 StartPosition;

	[Token(Token = "0x4000041")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private Vector3 TargetPosition;

	[Token(Token = "0x4000042")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float TargetSpeed;

	[Token(Token = "0x4000043")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float TargetTurnSpeed;

	[Token(Token = "0x4000044")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float CurrentSpeed;

	[Token(Token = "0x4000045")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool ForceGliding;

	[Token(Token = "0x4000046")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75")]
	private bool ForceFlapping;

	[Token(Token = "0x4000047")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float ForcedAnimationTimeStart;

	[Token(Token = "0x4000048")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine SetFlockRandomPositionCoroutine;

	[Token(Token = "0x4000049")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animation Animation;

	[Token(Token = "0x600003D")]
	[Address(RVA = "0x119FEE8", Offset = "0x119FEE8", VA = "0x119FEE8")]
	private void Start()
	{
	}

	[Token(Token = "0x600003E")]
	[Address(RVA = "0x11A009C", Offset = "0x11A009C", VA = "0x11A009C")]
	private void Update()
	{
	}

	[Token(Token = "0x600003F")]
	[Address(RVA = "0x11A05EC", Offset = "0x11A05EC", VA = "0x11A05EC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000040")]
	[Address(RVA = "0x11A069C", Offset = "0x11A069C", VA = "0x11A069C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000041")]
	[Address(RVA = "0x11A0630", Offset = "0x11A0630", VA = "0x11A0630")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAECC", Offset = "0xAEAECC")]
	private IEnumerator SetFlockRandomPosition()
	{
		return null;
	}

	[Token(Token = "0x6000042")]
	[Address(RVA = "0x11A0058", Offset = "0x11A0058", VA = "0x11A0058")]
	private void Wander()
	{
	}

	[Token(Token = "0x6000043")]
	[Address(RVA = "0x11A0324", Offset = "0x11A0324", VA = "0x11A0324")]
	private void Rotate()
	{
	}

	[Token(Token = "0x6000044")]
	[Address(RVA = "0x11A047C", Offset = "0x11A047C", VA = "0x11A047C")]
	private void Move()
	{
	}

	[Token(Token = "0x6000045")]
	[Address(RVA = "0x11A06DC", Offset = "0x11A06DC", VA = "0x11A06DC")]
	private void FindTargetPosition()
	{
	}

	[Token(Token = "0x6000046")]
	[Address(RVA = "0x11A09B4", Offset = "0x11A09B4", VA = "0x11A09B4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x11A0A0C", Offset = "0x11A0A0C", VA = "0x11A0A0C")]
	public Butterfly()
	{
	}
}
[Token(Token = "0x2000010")]
public class FlySpawner : MonoBehaviour
{
	[Token(Token = "0x2000011")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D4C", Offset = "0xAE3D4C")]
	private sealed class <Spawn>d__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlySpawner <>4__this;

		[Token(Token = "0x1700000B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0xE4122C", Offset = "0xE4122C", VA = "0xE4122C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0xE41274", Offset = "0xE41274", VA = "0xE41274", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0xE40DD8", Offset = "0xE40DD8", VA = "0xE40DD8")]
		[DebuggerHidden]
		public <Spawn>d__9(int <>1__state)
		{
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0xE40E04", Offset = "0xE40E04", VA = "0xE40E04", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0xE40E08", Offset = "0xE40E08", VA = "0xE40E08", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0xE41234", Offset = "0xE41234", VA = "0xE41234", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400004D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject FlyPrefab;

	[Token(Token = "0x400004E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Vector2 MinMaxSpawnDelay;

	[Token(Token = "0x400004F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private GameObject Fly;

	[Token(Token = "0x4000050")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float TravelDistance;

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x15D9744", Offset = "0x15D9744", VA = "0x15D9744")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600004F")]
	[Address(RVA = "0x15D97DC", Offset = "0x15D97DC", VA = "0x15D97DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000050")]
	[Address(RVA = "0x15D98A0", Offset = "0x15D98A0", VA = "0x15D98A0")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x15D97E0", Offset = "0x15D97E0", VA = "0x15D97E0")]
	private void Clear()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x15D98A4", Offset = "0x15D98A4", VA = "0x15D98A4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x15D9770", Offset = "0x15D9770", VA = "0x15D9770")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEAF7C", Offset = "0xAEAF7C")]
	private IEnumerator Spawn()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x15D9B20", Offset = "0x15D9B20", VA = "0x15D9B20")]
	public FlySpawner()
	{
	}
}
[Token(Token = "0x2000012")]
public enum Pipeline
{
	[Token(Token = "0x4000055")]
	HDRP,
	[Token(Token = "0x4000056")]
	LWRP,
	[Token(Token = "0x4000057")]
	Standard
}
[Token(Token = "0x2000013")]
public class IntroAR : IntroBase
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3D5C", Offset = "0xAE3D5C")]
	private sealed class <Play>d__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400005B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400005C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400005D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool forceSkip;

		[Token(Token = "0x400005E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IntroAR <>4__this;

		[Token(Token = "0x1700000D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000065")]
			[Address(RVA = "0xE42AB0", Offset = "0xE42AB0", VA = "0xE42AB0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0xE42AF8", Offset = "0xE42AF8", VA = "0xE42AF8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0xE427DC", Offset = "0xE427DC", VA = "0xE427DC")]
		[DebuggerHidden]
		public <Play>d__7(int <>1__state)
		{
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0xE42808", Offset = "0xE42808", VA = "0xE42808", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0xE4280C", Offset = "0xE4280C", VA = "0xE4280C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0xE42AB8", Offset = "0xE42AB8", VA = "0xE42AB8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000058")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public RawImage Logo;

	[Token(Token = "0x4000059")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public RawImage MenuLogo;

	[Token(Token = "0x400005A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Coroutine PlayCo;

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x15E3880", Offset = "0x15E3880", VA = "0x15E3880")]
	private void Awake()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x15E3958", Offset = "0x15E3958", VA = "0x15E3958", Slot = "4")]
	public override void Launch(bool skipAnimations = false)
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x15E3A10", Offset = "0x15E3A10", VA = "0x15E3A10")]
	private void Update()
	{
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x15E3ADC", Offset = "0x15E3ADC", VA = "0x15E3ADC")]
	private void SwapLogos()
	{
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x15E3990", Offset = "0x15E3990", VA = "0x15E3990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB02C", Offset = "0xAEB02C")]
	private IEnumerator Play(bool forceSkip)
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x15E3CE8", Offset = "0x15E3CE8", VA = "0x15E3CE8")]
	public IntroAR()
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x15E3D70", Offset = "0x15E3D70", VA = "0x15E3D70")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB08C", Offset = "0xAEB08C")]
	private void <SwapLogos>b__6_0()
	{
	}
}
[Token(Token = "0x2000015")]
public class VersionCodeHelper
{
	[Token(Token = "0x400005F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int CODE;

	[Token(Token = "0x6000068")]
	[Address(RVA = "0xE3AFEC", Offset = "0xE3AFEC", VA = "0xE3AFEC")]
	public VersionCodeHelper()
	{
	}
}
[Token(Token = "0x2000016")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xAE3D6C", Offset = "0xAE3D6C")]
public class AddressablePrefab : MonoBehaviour
{
	[Token(Token = "0x4000060")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string AddressableGroup;

	[Token(Token = "0x4000061")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string AddressableLabel;

	[Token(Token = "0x600006A")]
	[Address(RVA = "0x118BB54", Offset = "0x118BB54", VA = "0x118BB54", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x600006B")]
	[Address(RVA = "0x118BB58", Offset = "0x118BB58", VA = "0x118BB58")]
	public AddressablePrefab()
	{
	}
}
[Token(Token = "0x2000017")]
[ExecuteInEditMode]
public class AddressablePrefabEditor : MonoBehaviour
{
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x118BB60", Offset = "0x118BB60", VA = "0x118BB60")]
	public AddressablePrefabEditor()
	{
	}
}
[Serializable]
[Token(Token = "0x2000018")]
public class AddressablePrefabOverrideData
{
	[Token(Token = "0x4000062")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string GameObjectPath;

	[Token(Token = "0x4000063")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string ComponentType;

	[Token(Token = "0x4000064")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string PropertyType;

	[Token(Token = "0x4000065")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string PropertyName;

	[Token(Token = "0x4000066")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string PropertyValue;

	[Token(Token = "0x600006D")]
	[Address(RVA = "0x118BB68", Offset = "0x118BB68", VA = "0x118BB68")]
	public AddressablePrefabOverrideData(string gameObjectPath, string componentType, string propertyType, string propertyName, string value)
	{
	}
}
[Token(Token = "0x2000019")]
[ExecuteInEditMode]
public class AddressablePrefabProxy : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200001A")]
	public struct ScenePrefabProxyAssetRef
	{
		[Token(Token = "0x200001B")]
		public enum ScenePrefabProxyAssetRefType
		{
			[Token(Token = "0x4000076")]
			Material,
			[Token(Token = "0x4000077")]
			Texture
		}

		[Token(Token = "0x4000070")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public string ComponentType;

		[Token(Token = "0x4000071")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public string PropertyPath;

		[Token(Token = "0x4000072")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Material Material;

		[Token(Token = "0x4000073")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Texture Texture;

		[Token(Token = "0x4000074")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ScenePrefabProxyAssetRefType PropertyType;

		[Token(Token = "0x6000079")]
		[Address(RVA = "0xE3E5BC", Offset = "0xE3E5BC", VA = "0xE3E5BC")]
		public ScenePrefabProxyAssetRef(string componentType, string path, Material m)
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0xE3E5CC", Offset = "0xE3E5CC", VA = "0xE3E5CC")]
		public ScenePrefabProxyAssetRef(string componentType, string path, Texture t)
		{
		}
	}

	[Token(Token = "0x4000067")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Address;

	[Token(Token = "0x4000068")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject EditorRef;

	[Token(Token = "0x4000069")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AddressablePrefabOverrideData[] OverridesData;

	[Token(Token = "0x400006A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ScenePrefabProxyAssetRef[] OverrideDataAssetRefs;

	[Token(Token = "0x400006B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE50A8", Offset = "0xAE50A8")]
	private bool <LoadComplete>k__BackingField;

	[Token(Token = "0x400006C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private AsyncOperationHandle<GameObject> Handle;

	[Token(Token = "0x400006D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject Instance;

	[Token(Token = "0x400006E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool AntiTextureLoadHickupTrickPerformed;

	[Token(Token = "0x400006F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
	private bool Loading;

	[Token(Token = "0x1700000F")]
	public bool LoadComplete
	{
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x118BC40", Offset = "0x118BC40", VA = "0x118BC40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB0EC", Offset = "0xAEB0EC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x118BC48", Offset = "0x118BC48", VA = "0x118BC48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB0FC", Offset = "0xAEB0FC")]
		private set
		{
		}
	}

	[Token(Token = "0x6000070")]
	[Address(RVA = "0x118BC54", Offset = "0x118BC54", VA = "0x118BC54")]
	private void Start()
	{
	}

	[Token(Token = "0x6000071")]
	[Address(RVA = "0x118BC58", Offset = "0x118BC58", VA = "0x118BC58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000072")]
	[Address(RVA = "0x118BEF4", Offset = "0x118BEF4", VA = "0x118BEF4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000073")]
	[Address(RVA = "0x118C00C", Offset = "0x118C00C", VA = "0x118C00C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000074")]
	[Address(RVA = "0x118C0D4", Offset = "0x118C0D4", VA = "0x118C0D4")]
	public void Load()
	{
	}

	[Token(Token = "0x6000075")]
	[Address(RVA = "0x118C1F4", Offset = "0x118C1F4", VA = "0x118C1F4")]
	private void ApplyOverrides()
	{
	}

	[Token(Token = "0x6000076")]
	[Address(RVA = "0x118CD04", Offset = "0x118CD04", VA = "0x118CD04")]
	public AddressablePrefabProxy()
	{
	}

	[Token(Token = "0x6000077")]
	[Address(RVA = "0x118CD0C", Offset = "0x118CD0C", VA = "0x118CD0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB10C", Offset = "0xAEB10C")]
	private void <Load>b__16_0(AsyncOperationHandle<IResourceLocator> op)
	{
	}

	[Token(Token = "0x6000078")]
	[Address(RVA = "0x118CF24", Offset = "0x118CF24", VA = "0x118CF24")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB11C", Offset = "0xAEB11C")]
	private void <Load>b__16_1(AsyncOperationHandle<GameObject> handle)
	{
	}
}
[Token(Token = "0x200001C")]
public class FootstepsAudio : MonoBehaviour
{
	[Token(Token = "0x4000078")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public StudioEventEmitter Footsteps;

	[Token(Token = "0x600007B")]
	[Address(RVA = "0x15D9B34", Offset = "0x15D9B34", VA = "0x15D9B34")]
	public void PlayRandom(float delay = 0f)
	{
	}

	[Token(Token = "0x600007C")]
	[Address(RVA = "0x15D9C54", Offset = "0x15D9C54", VA = "0x15D9C54")]
	public void Stop()
	{
	}

	[Token(Token = "0x600007D")]
	[Address(RVA = "0x15D9CA4", Offset = "0x15D9CA4", VA = "0x15D9CA4")]
	public FootstepsAudio()
	{
	}
}
[Token(Token = "0x200001D")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAE3DA4", Offset = "0xAE3DA4")]
public class OculusFMODCallbackHandler : PlatformCallbackHandler
{
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x10834B0", Offset = "0x10834B0", VA = "0x10834B0", Slot = "4")]
	public override void PreInitialize(FMOD.Studio.System studioSystem, Action<RESULT, string> reportResult)
	{
	}

	[Token(Token = "0x600007F")]
	[Address(RVA = "0x1083690", Offset = "0x1083690", VA = "0x1083690")]
	public OculusFMODCallbackHandler()
	{
	}
}
[Token(Token = "0x200001E")]
public class OculusSpatializerFMOD : MonoBehaviour
{
	[Token(Token = "0x200001F")]
	public delegate void AudioRaycastCallback(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data);

	[Token(Token = "0x4000079")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LayerMask layerMask;

	[Token(Token = "0x400007A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool visualizeRoom;

	[Token(Token = "0x400007B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
	private bool roomVisualizationInitialized;

	[Token(Token = "0x400007C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int raysPerSecond;

	[Token(Token = "0x400007D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public float roomInterpSpeed;

	[Token(Token = "0x400007E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public float maxWallDistance;

	[Token(Token = "0x400007F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int rayCacheSize;

	[Token(Token = "0x4000080")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool dynamicReflectionsEnabled;

	[Token(Token = "0x4000081")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AudioRaycastCallback _raycastCallback;

	[Token(Token = "0x4000082")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float particleSize;

	[Token(Token = "0x4000083")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float particleOffset;

	[Token(Token = "0x4000084")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private GameObject room;

	[Token(Token = "0x4000085")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Renderer[] wallRenderer;

	[Token(Token = "0x4000086")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private float[] dims;

	[Token(Token = "0x4000087")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float[] coefs;

	[Token(Token = "0x4000088")]
	private const int HIT_COUNT = 2048;

	[Token(Token = "0x4000089")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3[] points;

	[Token(Token = "0x400008A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3[] normals;

	[Token(Token = "0x400008B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private ParticleSystem sys;

	[Token(Token = "0x400008C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private ParticleSystem.Particle[] particles;

	[Token(Token = "0x400008D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask gLayerMask;

	[Token(Token = "0x400008E")]
	private const string strOSP = "OculusSpatializerFMOD";

	[Token(Token = "0x6000080")]
	[Address(RVA = "0x10845D4", Offset = "0x10845D4", VA = "0x10845D4")]
	private static Vector3 swapHandedness(Vector3 vec)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000081")]
	[Address(RVA = "0x10845DC", Offset = "0x10845DC", VA = "0x10845DC")]
	private static void AudioRaycast(Vector3 origin, Vector3 direction, out Vector3 point, out Vector3 normal, IntPtr data)
	{
	}

	[Token(Token = "0x6000082")]
	[Address(RVA = "0x108474C", Offset = "0x108474C", VA = "0x108474C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000083")]
	[Address(RVA = "0x10847C4", Offset = "0x10847C4", VA = "0x10847C4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000084")]
	[Address(RVA = "0x10848C0", Offset = "0x10848C0", VA = "0x10848C0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000085")]
	[Address(RVA = "0x1085168", Offset = "0x1085168", VA = "0x1085168")]
	private void inititalizeRoomVisualization()
	{
	}

	[PreserveSig]
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x1084830", Offset = "0x1084830", VA = "0x1084830")]
	private static extern int OSP_FMOD_AssignRayCastCallback(IntPtr callback, IntPtr data);

	[PreserveSig]
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x1084ED0", Offset = "0x1084ED0", VA = "0x1084ED0")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysPerSecond(int RaysPerSecond);

	[PreserveSig]
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x1084F50", Offset = "0x1084F50", VA = "0x1084F50")]
	private static extern int OSP_FMOD_SetDynamicRoomInterpSpeed(float InterpSpeed);

	[PreserveSig]
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x1084FD8", Offset = "0x1084FD8", VA = "0x1084FD8")]
	private static extern int OSP_FMOD_SetDynamicRoomMaxWallDistance(float MaxWallDistance);

	[PreserveSig]
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x1085060", Offset = "0x1085060", VA = "0x1085060")]
	private static extern int OSP_FMOD_SetDynamicRoomRaysRayCacheSize(int RayCacheSize);

	[PreserveSig]
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x10850E0", Offset = "0x10850E0", VA = "0x10850E0")]
	private static extern int OSP_FMOD_UpdateRoomModel(float wetLevel);

	[PreserveSig]
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x1085E30", Offset = "0x1085E30", VA = "0x1085E30")]
	private static extern int OSP_FMOD_GetRoomDimensions(float[] roomDimensions, float[] reflectionsCoefs, out Vector3 position);

	[PreserveSig]
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x1085ED8", Offset = "0x1085ED8", VA = "0x1085ED8")]
	private static extern int OSP_FMOD_GetRaycastHits(Vector3[] points, Vector3[] normals, int length);

	[Token(Token = "0x600008E")]
	[Address(RVA = "0x1085F80", Offset = "0x1085F80", VA = "0x1085F80")]
	public OculusSpatializerFMOD()
	{
	}
}
[Token(Token = "0x2000020")]
public class PlayFromAnimationEvent : MonoBehaviour
{
	[Token(Token = "0x400008F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private StudioEventEmitter Emitter;

	[Token(Token = "0x6000094")]
	[Address(RVA = "0x108C54C", Offset = "0x108C54C", VA = "0x108C54C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000095")]
	[Address(RVA = "0x108C5A0", Offset = "0x108C5A0", VA = "0x108C5A0")]
	public void Play()
	{
	}

	[Token(Token = "0x6000096")]
	[Address(RVA = "0x108C66C", Offset = "0x108C66C", VA = "0x108C66C")]
	public PlayFromAnimationEvent()
	{
	}
}
[Token(Token = "0x2000021")]
public class RandomAudioPlayback : MonoBehaviour
{
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3DE0", Offset = "0xAE3DE0")]
	private sealed class <PlayRandomAudio>d__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000096")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000097")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000098")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public RandomAudioPlayback <>4__this;

		[Token(Token = "0x17000010")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60000A1")]
			[Address(RVA = "0x167568C", Offset = "0x167568C", VA = "0x167568C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000011")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x16756D4", Offset = "0x16756D4", VA = "0x16756D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600009E")]
		[Address(RVA = "0x16752E4", Offset = "0x16752E4", VA = "0x16752E4")]
		[DebuggerHidden]
		public <PlayRandomAudio>d__11(int <>1__state)
		{
		}

		[Token(Token = "0x600009F")]
		[Address(RVA = "0x1675310", Offset = "0x1675310", VA = "0x1675310", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x1675314", Offset = "0x1675314", VA = "0x1675314", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x1675694", Offset = "0x1675694", VA = "0x1675694", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000090")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector2 MinMaxDelay;

	[Token(Token = "0x4000091")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool RandomizePosition;

	[Token(Token = "0x4000092")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 MinMaxPositionRadius;

	[Token(Token = "0x4000093")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private StudioEventEmitter Emitter;

	[Token(Token = "0x4000094")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Vector3 DefaultPosition;

	[Token(Token = "0x4000095")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool VeryFirstPlay;

	[Token(Token = "0x6000097")]
	[Address(RVA = "0x138BEE4", Offset = "0x138BEE4", VA = "0x138BEE4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000098")]
	[Address(RVA = "0x138BF5C", Offset = "0x138BF5C", VA = "0x138BF5C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000099")]
	[Address(RVA = "0x138BFF4", Offset = "0x138BFF4", VA = "0x138BFF4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600009A")]
	[Address(RVA = "0x138C0C8", Offset = "0x138C0C8", VA = "0x138C0C8")]
	public void Resume()
	{
	}

	[Token(Token = "0x600009B")]
	[Address(RVA = "0x138BFF8", Offset = "0x138BFF8", VA = "0x138BFF8")]
	public void Stop()
	{
	}

	[Token(Token = "0x600009C")]
	[Address(RVA = "0x138BF88", Offset = "0x138BF88", VA = "0x138BF88")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB12C", Offset = "0xAEB12C")]
	private IEnumerator PlayRandomAudio()
	{
		return null;
	}

	[Token(Token = "0x600009D")]
	[Address(RVA = "0x138C1CC", Offset = "0x138C1CC", VA = "0x138C1CC")]
	public RandomAudioPlayback()
	{
	}
}
[Token(Token = "0x2000023")]
public class WindVR : WindBase
{
	[Token(Token = "0x4000099")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private EventInstance Instance;

	[Token(Token = "0x400009A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float VolumeLeft;

	[Token(Token = "0x400009B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float VolumeRight;

	[Token(Token = "0x400009C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform HeadTransform;

	[Token(Token = "0x60000A4")]
	[Address(RVA = "0xE3D9C0", Offset = "0xE3D9C0", VA = "0xE3D9C0", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60000A5")]
	[Address(RVA = "0xE3D9C4", Offset = "0xE3D9C4", VA = "0xE3D9C4", Slot = "5")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60000A6")]
	[Address(RVA = "0xE3DE30", Offset = "0xE3DE30", VA = "0xE3DE30", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60000A7")]
	[Address(RVA = "0xE3DE8C", Offset = "0xE3DE8C", VA = "0xE3DE8C", Slot = "8")]
	public override void Pause()
	{
	}

	[Token(Token = "0x60000A8")]
	[Address(RVA = "0xE3DE9C", Offset = "0xE3DE9C", VA = "0xE3DE9C", Slot = "9")]
	public override void Resume()
	{
	}

	[Token(Token = "0x60000A9")]
	[Address(RVA = "0xE3DA40", Offset = "0xE3DA40", VA = "0xE3DA40")]
	private void SetEarsVolume()
	{
	}

	[Token(Token = "0x60000AA")]
	[Address(RVA = "0xE3DEAC", Offset = "0xE3DEAC", VA = "0xE3DEAC", Slot = "10")]
	protected override void Play()
	{
	}

	[Token(Token = "0x60000AB")]
	[Address(RVA = "0xE3DFE8", Offset = "0xE3DFE8", VA = "0xE3DFE8")]
	public WindVR()
	{
	}
}
[Token(Token = "0x2000024")]
public class BrinkPlayer : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000025")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3DF0", Offset = "0xAE3DF0")]
	private sealed class <>c
	{
		[Token(Token = "0x40000AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40000AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action<Marker> <>9__29_0;

		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xE3FC14", Offset = "0xE3FC14", VA = "0xE3FC14")]
		public <>c()
		{
		}

		[Token(Token = "0x60000CB")]
		[Address(RVA = "0xE3FC1C", Offset = "0xE3FC1C", VA = "0xE3FC1C")]
		internal void <OnOverlayClosing>b__29_0(Marker marker)
		{
		}
	}

	[Token(Token = "0x400009D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool SwitchingNightDay;

	[Token(Token = "0x400009E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE50B8", Offset = "0xAE50B8")]
	public LocationsMenuBase Menu;

	[Token(Token = "0x400009F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public POIPopupBase POIPopup;

	[Token(Token = "0x40000A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public WindBase Wind;

	[Token(Token = "0x40000A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public FootstepsAudio Footsteps;

	[Token(Token = "0x40000A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Narrator Narrator;

	[Token(Token = "0x40000A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal bool CalibrationComplete;

	[Token(Token = "0x40000A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected LocationController CurrentLocation;

	[Token(Token = "0x40000A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	protected static BrinkPlayer Instance;

	[Token(Token = "0x40000A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected static bool Teleporting;

	[Token(Token = "0x40000A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected bool AllowCameraCollisionDetection;

	[Token(Token = "0x40000A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	protected bool FirstLocationRevealed;

	[Token(Token = "0x40000A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	protected bool TravelingToLocation;

	[Token(Token = "0x40000AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Camera _MainCamera;

	[Token(Token = "0x40000AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Transform _CameraTransform;

	[Token(Token = "0x40000AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x53")]
	private bool IsFirstLocation;

	[Token(Token = "0x40000AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float VisitStartTime;

	[Token(Token = "0x17000012")]
	internal string CurrentSpotId
	{
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x1199F5C", Offset = "0x1199F5C", VA = "0x1199F5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000013")]
	protected virtual bool AllowMenuOpen
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x119B574", Offset = "0x119B574", VA = "0x119B574", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public bool NightModeSwitchAllowed
	{
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x119B620", Offset = "0x119B620", VA = "0x119B620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000015")]
	public static Transform CameraTransform
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x118BDFC", Offset = "0x118BDFC", VA = "0x118BDFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	public static WindBase WindSystem
	{
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x119B7E0", Offset = "0x119B7E0", VA = "0x119B7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000017")]
	public static Camera MainCamera
	{
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x119B6F0", Offset = "0x119B6F0", VA = "0x119B6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60000AD")]
	[Address(RVA = "0x1199F84", Offset = "0x1199F84", VA = "0x1199F84", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60000AE")]
	[Address(RVA = "0x119A01C", Offset = "0x119A01C", VA = "0x119A01C", Slot = "5")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000AF")]
	[Address(RVA = "0x119A200", Offset = "0x119A200", VA = "0x119A200")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x60000B0")]
	[Address(RVA = "0x119A69C", Offset = "0x119A69C", VA = "0x119A69C", Slot = "6")]
	public virtual void OnIntroEnded()
	{
	}

	[Token(Token = "0x60000B1")]
	[Address(RVA = "0x119A6B8", Offset = "0x119A6B8", VA = "0x119A6B8", Slot = "7")]
	public virtual void Calibrate()
	{
	}

	[Token(Token = "0x60000B2")]
	[Address(RVA = "0x119A6BC", Offset = "0x119A6BC", VA = "0x119A6BC", Slot = "8")]
	public virtual float HideCurrentLocation()
	{
		return default(float);
	}

	[Token(Token = "0x60000B3")]
	[Address(RVA = "0x119A9F4", Offset = "0x119A9F4", VA = "0x119A9F4", Slot = "9")]
	public virtual void MoveToSpawnPosition(Transform spawnPosition)
	{
	}

	[Token(Token = "0x60000B4")]
	[Address(RVA = "0x119A9F8", Offset = "0x119A9F8", VA = "0x119A9F8", Slot = "10")]
	public virtual void RevealLocation()
	{
	}

	[Token(Token = "0x60000B5")]
	[Address(RVA = "0x119AF88", Offset = "0x119AF88", VA = "0x119AF88", Slot = "11")]
	protected virtual void OnOverlayBeforeOpening()
	{
	}

	[Token(Token = "0x60000B6")]
	[Address(RVA = "0x119AF8C", Offset = "0x119AF8C", VA = "0x119AF8C", Slot = "12")]
	protected virtual void OnOverlayOpening()
	{
	}

	[Token(Token = "0x60000B7")]
	[Address(RVA = "0x119AFE0", Offset = "0x119AFE0", VA = "0x119AFE0", Slot = "13")]
	protected virtual void OnOverlayClosing()
	{
	}

	[Token(Token = "0x60000B8")]
	[Address(RVA = "0x119B1A8", Offset = "0x119B1A8", VA = "0x119B1A8", Slot = "14")]
	protected virtual void OnMarkerPoitingEnter(Marker marker)
	{
	}

	[Token(Token = "0x60000B9")]
	[Address(RVA = "0x119B1AC", Offset = "0x119B1AC", VA = "0x119B1AC", Slot = "15")]
	protected virtual void OnMarkerPoitingStay(Marker marker)
	{
	}

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x119B1B0", Offset = "0x119B1B0", VA = "0x119B1B0", Slot = "16")]
	protected virtual void OnTriggerFlashFx()
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x119B1B4", Offset = "0x119B1B4", VA = "0x119B1B4", Slot = "17")]
	protected virtual void OnCollectPOISelected()
	{
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x119B1D0", Offset = "0x119B1D0", VA = "0x119B1D0", Slot = "18")]
	protected virtual void OnMarkerClicked(Marker marker)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x119B1D4", Offset = "0x119B1D4", VA = "0x119B1D4", Slot = "19")]
	protected virtual void OnPOIMarkerTriggered(POIMarker marker, bool justFound, POIPopupObjectHighlight objectHighlight)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x119B3C8", Offset = "0x119B3C8", VA = "0x119B3C8", Slot = "20")]
	protected virtual void OnTeleportMarkerTriggered(TeleportMarker marker)
	{
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x119B48C", Offset = "0x119B48C", VA = "0x119B48C", Slot = "21")]
	protected virtual void TeleportTo(SpotController spot, bool keepPlayerCurrentOrientation, bool fromTeleporter = true)
	{
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x119B514", Offset = "0x119B514", VA = "0x119B514", Slot = "22")]
	protected virtual void WarpToSpot(SpotController spot, bool keepPlayerCurrentOrientation, bool fromTeleporter)
	{
	}

	[Token(Token = "0x60000C3")]
	[Address(RVA = "0x119AE74", Offset = "0x119AE74", VA = "0x119AE74")]
	protected void HideMarkers(bool v = true)
	{
	}

	[Token(Token = "0x60000C4")]
	[Address(RVA = "0x119A2E0", Offset = "0x119A2E0", VA = "0x119A2E0")]
	private void TrackVisitTime()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x119B88C", Offset = "0x119B88C", VA = "0x119B88C")]
	public BrinkPlayer()
	{
	}
}
[Token(Token = "0x2000026")]
public class ButtonBase : MonoBehaviour
{
	[Token(Token = "0x40000B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	protected static bool PreventOtherButtonSelect;

	[Token(Token = "0x40000B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal readonly PushableButtonEvent OnSelected;

	[Token(Token = "0x40000B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal readonly PushableButtonEvent OnPushStarted;

	[Token(Token = "0x40000B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAE50F0", Offset = "0xAE50F0")]
	public bool IsSelectable;

	[Token(Token = "0x40000B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5128", Offset = "0xAE5128")]
	private bool <Enabled>k__BackingField;

	[Token(Token = "0x40000B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A")]
	private bool _Selectable;

	[Token(Token = "0x40000B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5138", Offset = "0xAE5138")]
	private bool <Selected>k__BackingField;

	[Token(Token = "0x17000018")]
	public bool Enabled
	{
		[Token(Token = "0x60000CC")]
		[Address(RVA = "0x15D0814", Offset = "0x15D0814", VA = "0x15D0814")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB1DC", Offset = "0xAEB1DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CD")]
		[Address(RVA = "0x15D081C", Offset = "0x15D081C", VA = "0x15D081C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB1EC", Offset = "0xAEB1EC")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	protected bool Selectable
	{
		[Token(Token = "0x60000CE")]
		[Address(RVA = "0x15D0828", Offset = "0x15D0828", VA = "0x15D0828")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000CF")]
		[Address(RVA = "0x15D0830", Offset = "0x15D0830", VA = "0x15D0830")]
		private set
		{
		}
	}

	[Token(Token = "0x1700001A")]
	public bool Selected
	{
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x15D08D8", Offset = "0x15D08D8", VA = "0x15D08D8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB20C", Offset = "0xAEB20C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x15D08CC", Offset = "0x15D08CC", VA = "0x15D08CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB1FC", Offset = "0xAEB1FC")]
		private set
		{
		}
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x15D0858", Offset = "0x15D0858", VA = "0x15D0858", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x15D0880", Offset = "0x15D0880", VA = "0x15D0880", Slot = "5")]
	protected virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x15D08E0", Offset = "0x15D08E0", VA = "0x15D08E0", Slot = "6")]
	public virtual void Select(bool skipAnimation = false, bool dispatch = true)
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x15D08F4", Offset = "0x15D08F4", VA = "0x15D08F4", Slot = "7")]
	public virtual void Deselect(bool skipAnimation = false)
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x15D08FC", Offset = "0x15D08FC", VA = "0x15D08FC", Slot = "8")]
	protected virtual void OnSelect(bool dispatch = true)
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x15D09C4", Offset = "0x15D09C4", VA = "0x15D09C4")]
	public ButtonBase()
	{
	}
}
[Token(Token = "0x2000027")]
public class PushableButtonEvent : UnityEvent<ButtonBase>
{
	[Token(Token = "0x60000D8")]
	[Address(RVA = "0x138B8D0", Offset = "0x138B8D0", VA = "0x138B8D0")]
	public PushableButtonEvent()
	{
	}
}
[Token(Token = "0x2000028")]
public class IntroBase : MonoBehaviour
{
	[Token(Token = "0x40000B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected EventInstance Wind;

	[Token(Token = "0x40000B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected EventInstance Music;

	[Token(Token = "0x40000B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal readonly UnityEvent OnReadyToLoadPrerequisites;

	[Token(Token = "0x40000BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal readonly UnityEvent OnEndEvent;

	[Token(Token = "0x60000D9")]
	[Address(RVA = "0x15E3D98", Offset = "0x15E3D98", VA = "0x15E3D98")]
	private void Start()
	{
	}

	[Token(Token = "0x60000DA")]
	[Address(RVA = "0x15E3E10", Offset = "0x15E3E10", VA = "0x15E3E10", Slot = "4")]
	public virtual void Launch(bool skipAnimations = false)
	{
	}

	[Token(Token = "0x60000DB")]
	[Address(RVA = "0x15E3E14", Offset = "0x15E3E14", VA = "0x15E3E14", Slot = "5")]
	public virtual void PrepareForPlayerTeleport()
	{
	}

	[Token(Token = "0x60000DC")]
	[Address(RVA = "0x15E3E18", Offset = "0x15E3E18", VA = "0x15E3E18", Slot = "6")]
	public virtual void OnPlayerTeleported()
	{
	}

	[Token(Token = "0x60000DD")]
	[Address(RVA = "0x15E3E1C", Offset = "0x15E3E1C", VA = "0x15E3E1C")]
	public void StopAudio()
	{
	}

	[Token(Token = "0x60000DE")]
	[Address(RVA = "0x15E3E88", Offset = "0x15E3E88", VA = "0x15E3E88")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60000DF")]
	[Address(RVA = "0x15E3CEC", Offset = "0x15E3CEC", VA = "0x15E3CEC")]
	public IntroBase()
	{
	}
}
[Token(Token = "0x2000029")]
public class LocationsMenuBase : Overlay
{
	[Token(Token = "0x40000BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LocationsMenuDetailsBase Details;

	[Token(Token = "0x40000BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal readonly MenuEvent DetailsActionButtonSelected;

	[Token(Token = "0x40000BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EventInstance Music;

	[Token(Token = "0x60000E0")]
	[Address(RVA = "0x1425230", Offset = "0x1425230", VA = "0x1425230", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60000E1")]
	[Address(RVA = "0x14252FC", Offset = "0x14252FC", VA = "0x14252FC", Slot = "6")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60000E2")]
	[Address(RVA = "0x14253BC", Offset = "0x14253BC", VA = "0x14253BC", Slot = "10")]
	public virtual void Init(List<LocationInfoMenuListItem> list)
	{
	}

	[Token(Token = "0x60000E3")]
	[Address(RVA = "0x1425498", Offset = "0x1425498", VA = "0x1425498", Slot = "11")]
	protected virtual void AddItems(List<LocationInfoMenuListItem> locationInfoMenuList)
	{
	}

	[Token(Token = "0x60000E4")]
	[Address(RVA = "0x142549C", Offset = "0x142549C", VA = "0x142549C", Slot = "12")]
	protected virtual void ResetItemStates()
	{
	}

	[Token(Token = "0x60000E5")]
	[Address(RVA = "0x14254BC", Offset = "0x14254BC", VA = "0x14254BC", Slot = "13")]
	protected virtual void OnClearSelected()
	{
	}

	[Token(Token = "0x60000E6")]
	[Address(RVA = "0x14254C0", Offset = "0x14254C0", VA = "0x14254C0", Slot = "8")]
	protected override void Open()
	{
	}

	[Token(Token = "0x60000E7")]
	[Address(RVA = "0x1425668", Offset = "0x1425668", VA = "0x1425668", Slot = "9")]
	internal override void Close(bool dispatch = true)
	{
	}

	[Token(Token = "0x60000E8")]
	[Address(RVA = "0x1425740", Offset = "0x1425740", VA = "0x1425740")]
	protected void ShowDetails(string locationId)
	{
	}

	[Token(Token = "0x60000E9")]
	[Address(RVA = "0x1425760", Offset = "0x1425760", VA = "0x1425760")]
	private void OnDetailsActionButtonSelected(LocationInfo LocationInfo)
	{
	}

	[Token(Token = "0x60000EA")]
	[Address(RVA = "0x14257C8", Offset = "0x14257C8", VA = "0x14257C8")]
	public LocationsMenuBase()
	{
	}

	[Token(Token = "0x60000EB")]
	[Address(RVA = "0x1425858", Offset = "0x1425858", VA = "0x1425858")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB21C", Offset = "0xAEB21C")]
	private void <OnDisable>b__4_0()
	{
	}
}
[Token(Token = "0x200002A")]
public class MenuEvent : UnityEvent<string>
{
	[Token(Token = "0x60000EC")]
	[Address(RVA = "0xFFAF1C", Offset = "0xFFAF1C", VA = "0xFFAF1C")]
	public MenuEvent()
	{
	}
}
[Token(Token = "0x200002B")]
public class LocationsMenuDetailsBase : MonoBehaviour
{
	[Token(Token = "0x40000BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal readonly LocationsMenuDetailsEvent ActionButtonSelected;

	[Token(Token = "0x40000BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject Loader;

	[Token(Token = "0x40000C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ButtonBase ActionButton;

	[Token(Token = "0x40000C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public ButtonBase ClearButton;

	[Token(Token = "0x40000C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public UnityEvent OnClearSelected;

	[Token(Token = "0x40000C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	internal readonly UnityEvent<LocationInfo> OnLocationInfoLoadeSuccess;

	[Token(Token = "0x40000C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	internal readonly UnityEvent<string> OnLocationInfoLoadeFailed;

	[Token(Token = "0x40000C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected string LoadingLocationId;

	[Token(Token = "0x40000C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected LocationInfo LocationInfo;

	[Token(Token = "0x40000C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected string ActionButtonLabelString;

	[Token(Token = "0x40000C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float OpenedTime;

	[Token(Token = "0x60000ED")]
	[Address(RVA = "0x1425868", Offset = "0x1425868", VA = "0x1425868", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60000EE")]
	[Address(RVA = "0x1425888", Offset = "0x1425888", VA = "0x1425888", Slot = "5")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x1425984", Offset = "0x1425984", VA = "0x1425984", Slot = "6")]
	public virtual void LoadLocationInfo(string locationId)
	{
	}

	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x1425AE4", Offset = "0x1425AE4", VA = "0x1425AE4", Slot = "7")]
	protected virtual void OnLocationInfoLoadSuccess(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x60000F1")]
	[Address(RVA = "0x1425BAC", Offset = "0x1425BAC", VA = "0x1425BAC", Slot = "8")]
	protected virtual void OnLocationInfoLoadFailed(string locationId)
	{
	}

	[Token(Token = "0x60000F2")]
	[Address(RVA = "0x1425C44", Offset = "0x1425C44", VA = "0x1425C44", Slot = "9")]
	public virtual void ShowLocationDownloadError()
	{
	}

	[Token(Token = "0x60000F3")]
	[Address(RVA = "0x1425C48", Offset = "0x1425C48", VA = "0x1425C48", Slot = "10")]
	public virtual void ResetState()
	{
	}

	[Token(Token = "0x60000F4")]
	[Address(RVA = "0x1425C70", Offset = "0x1425C70", VA = "0x1425C70", Slot = "11")]
	public virtual void PrepareForLocationLoad()
	{
	}

	[Token(Token = "0x60000F5")]
	[Address(RVA = "0x1425C74", Offset = "0x1425C74", VA = "0x1425C74", Slot = "12")]
	protected virtual void OnActionButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60000F6")]
	[Address(RVA = "0x1425D1C", Offset = "0x1425D1C", VA = "0x1425D1C", Slot = "13")]
	protected virtual void OnClearButtonSelected(ButtonBase btn)
	{
	}

	[Token(Token = "0x60000F7")]
	[Address(RVA = "0x1425D20", Offset = "0x1425D20", VA = "0x1425D20")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x1425F50", Offset = "0x1425F50", VA = "0x1425F50")]
	protected static string GetTruncatedGPSString(string s)
	{
		return null;
	}

	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x1426000", Offset = "0x1426000", VA = "0x1426000")]
	public string GetDisplayedLocationInfo()
	{
		return null;
	}

	[Token(Token = "0x60000FA")]
	[Address(RVA = "0x14260B0", Offset = "0x14260B0", VA = "0x14260B0")]
	public LocationsMenuDetailsBase()
	{
	}
}
[Token(Token = "0x200002C")]
public class LocationsMenuDetailsEvent : UnityEvent<LocationInfo>
{
	[Token(Token = "0x60000FB")]
	[Address(RVA = "0x14261BC", Offset = "0x14261BC", VA = "0x14261BC")]
	public LocationsMenuDetailsEvent()
	{
	}
}
[Token(Token = "0x200002D")]
public class POIPopupBase : Overlay
{
	[Token(Token = "0x40000C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal readonly UnityEvent TriggerFlashFx;

	[Token(Token = "0x40000CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal readonly UnityEvent Collecting;

	[Token(Token = "0x40000CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected PointOfInterestData ImageData;

	[Token(Token = "0x40000CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected POIPopupObjectHighlight ObjectHighlight;

	[Token(Token = "0x40000CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private string TitleString;

	[Token(Token = "0x40000CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float OpenTime;

	[Token(Token = "0x60000FC")]
	[Address(RVA = "0x1087948", Offset = "0x1087948", VA = "0x1087948", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x1087A04", Offset = "0x1087A04", VA = "0x1087A04", Slot = "10")]
	public virtual void SetDataAndOpen(POIMarker marker, bool justFound, POIPopupObjectHighlight objectHighlight)
	{
	}

	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x1087A5C", Offset = "0x1087A5C", VA = "0x1087A5C", Slot = "9")]
	internal override void Close(bool dispatch = true)
	{
	}

	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x1087A84", Offset = "0x1087A84", VA = "0x1087A84")]
	private void TrackReadingTime()
	{
	}

	[Token(Token = "0x6000100")]
	[Address(RVA = "0x1087CAC", Offset = "0x1087CAC", VA = "0x1087CAC")]
	public POIPopupBase()
	{
	}
}
[Token(Token = "0x200002E")]
public class WindBase : MonoBehaviour
{
	[Token(Token = "0x200002F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3E00", Offset = "0xAE3E00")]
	private sealed class <LoadAndPlayCo>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40000D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40000D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40000D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WindBase <>4__this;

		[Token(Token = "0x1700001B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x167B49C", Offset = "0x167B49C", VA = "0x167B49C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000117")]
			[Address(RVA = "0x167B4E4", Offset = "0x167B4E4", VA = "0x167B4E4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x167B144", Offset = "0x167B144", VA = "0x167B144")]
		[DebuggerHidden]
		public <LoadAndPlayCo>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x167B170", Offset = "0x167B170", VA = "0x167B170", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x167B174", Offset = "0x167B174", VA = "0x167B174", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x167B4A4", Offset = "0x167B4A4", VA = "0x167B4A4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40000CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected string Type;

	[Token(Token = "0x40000D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected float Direction;

	[Token(Token = "0x40000D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	protected float GlobalVolume;

	[Token(Token = "0x40000D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected float VolumeMax;

	[Token(Token = "0x40000D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float DesiredVolumeMax;

	[Token(Token = "0x40000D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TextAsset WindAudioBank;

	[Token(Token = "0x40000D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private AsyncOperationHandle<TextAsset> BankHandle;

	[Token(Token = "0x6000101")]
	[Address(RVA = "0xE3D504", Offset = "0xE3D504", VA = "0xE3D504", Slot = "4")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x6000102")]
	[Address(RVA = "0xE3D508", Offset = "0xE3D508", VA = "0xE3D508", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0xE3D5B8", Offset = "0xE3D5B8", VA = "0xE3D5B8", Slot = "6")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0xE3D5BC", Offset = "0xE3D5BC", VA = "0xE3D5BC")]
	public void SetWinDirection(float direction)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0xE3D5C4", Offset = "0xE3D5C4", VA = "0xE3D5C4", Slot = "7")]
	public virtual void LoadAndPlay(string type)
	{
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0xE3D660", Offset = "0xE3D660", VA = "0xE3D660", Slot = "8")]
	public virtual void Pause()
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0xE3D664", Offset = "0xE3D664", VA = "0xE3D664", Slot = "9")]
	public virtual void Resume()
	{
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0xE3D668", Offset = "0xE3D668", VA = "0xE3D668")]
	public void StopAndUnload()
	{
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0xE3D738", Offset = "0xE3D738", VA = "0xE3D738")]
	public void SetVolume(float volume)
	{
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0xE3D74C", Offset = "0xE3D74C", VA = "0xE3D74C")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0xE3D758", Offset = "0xE3D758", VA = "0xE3D758")]
	public void FadeGlobalVolume(float v, float time = 4f)
	{
	}

	[Token(Token = "0x600010C")]
	[Address(RVA = "0xE3D890", Offset = "0xE3D890", VA = "0xE3D890", Slot = "10")]
	protected virtual void Play()
	{
	}

	[Token(Token = "0x600010D")]
	[Address(RVA = "0xE3D5F4", Offset = "0xE3D5F4", VA = "0xE3D5F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB22C", Offset = "0xAEB22C")]
	private IEnumerator LoadAndPlayCo()
	{
		return null;
	}

	[Token(Token = "0x600010E")]
	[Address(RVA = "0xE3D89C", Offset = "0xE3D89C", VA = "0xE3D89C")]
	public WindBase()
	{
	}

	[Token(Token = "0x600010F")]
	[Address(RVA = "0xE3D8A4", Offset = "0xE3D8A4", VA = "0xE3D8A4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB28C", Offset = "0xAEB28C")]
	private float <FadeGlobalVolume>b__17_0()
	{
		return default(float);
	}

	[Token(Token = "0x6000110")]
	[Address(RVA = "0xE3D8AC", Offset = "0xE3D8AC", VA = "0xE3D8AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB29C", Offset = "0xAEB29C")]
	private void <FadeGlobalVolume>b__17_1(float x)
	{
	}

	[Token(Token = "0x6000111")]
	[Address(RVA = "0xE3D8B4", Offset = "0xE3D8B4", VA = "0xE3D8B4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB2AC", Offset = "0xAEB2AC")]
	private void <LoadAndPlayCo>b__19_0(AsyncOperationHandle<TextAsset> operationHandle)
	{
	}
}
[Token(Token = "0x2000030")]
public class AlignWithCameraPivot : MonoBehaviour
{
	[Token(Token = "0x2000031")]
	public enum FOLLOW_TYPES
	{
		[Token(Token = "0x40000DF")]
		Smooth,
		[Token(Token = "0x40000E0")]
		Instant
	}

	[Token(Token = "0x40000D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool _OnEnable;

	[Token(Token = "0x40000DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool FollowOverTime;

	[Token(Token = "0x40000DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public FOLLOW_TYPES MoveFollowType;

	[Token(Token = "0x40000DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FOLLOW_TYPES RotateFollowType;

	[Token(Token = "0x40000DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[HideInInspector]
	public bool DontAlignOnEnable;

	[Token(Token = "0x6000118")]
	[Address(RVA = "0x118FB20", Offset = "0x118FB20", VA = "0x118FB20")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000119")]
	[Address(RVA = "0x118FBC0", Offset = "0x118FBC0", VA = "0x118FBC0")]
	private void Update()
	{
	}

	[Token(Token = "0x600011A")]
	[Address(RVA = "0x118FF00", Offset = "0x118FF00", VA = "0x118FF00")]
	public static void AlignAll()
	{
	}

	[Token(Token = "0x600011B")]
	[Address(RVA = "0x118FB58", Offset = "0x118FB58", VA = "0x118FB58")]
	public void Align()
	{
	}

	[Token(Token = "0x600011C")]
	[Address(RVA = "0x118FDD8", Offset = "0x118FDD8", VA = "0x118FDD8")]
	private Vector3 GetIdealPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011D")]
	[Address(RVA = "0x118FFC4", Offset = "0x118FFC4", VA = "0x118FFC4")]
	private Vector3 GetIdealEulers()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011E")]
	[Address(RVA = "0x1190078", Offset = "0x1190078", VA = "0x1190078")]
	private static Vector3 GetFloorCameraForward()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600011F")]
	[Address(RVA = "0x119015C", Offset = "0x119015C", VA = "0x119015C")]
	public AlignWithCameraPivot()
	{
	}
}
[Token(Token = "0x2000032")]
public class Analytics : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000033")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3E10", Offset = "0xAE3E10")]
	private struct <Start>d__0 : IAsyncStateMachine
	{
		[Token(Token = "0x40000E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x40000E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x40000E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x40000E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<List<string>> <>u__2;

		[Token(Token = "0x6000125")]
		[Address(RVA = "0xE3EE8C", Offset = "0xE3EE8C", VA = "0xE3EE8C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0xE3F330", Offset = "0xE3F330", VA = "0xE3F330", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x6000120")]
	[Address(RVA = "0x119016C", Offset = "0x119016C", VA = "0x119016C")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xAEB30C", Offset = "0xAEB30C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000121")]
	[Address(RVA = "0x1190224", Offset = "0x1190224", VA = "0x1190224")]
	public static void Track(string eventName, [Optional] Dictionary<string, object> parameters)
	{
	}

	[Token(Token = "0x6000122")]
	[Address(RVA = "0x1190484", Offset = "0x1190484", VA = "0x1190484")]
	public static void TrackFunnel(string eventName, string tutorialId)
	{
	}

	[Token(Token = "0x6000123")]
	[Address(RVA = "0x1190488", Offset = "0x1190488", VA = "0x1190488")]
	public static void TrackFunnel(string eventName, string tutorialId, int stepIndex)
	{
	}

	[Token(Token = "0x6000124")]
	[Address(RVA = "0x119048C", Offset = "0x119048C", VA = "0x119048C")]
	public Analytics()
	{
	}
}
[Token(Token = "0x2000034")]
public class AppEnv : MonoBehaviour
{
	[Token(Token = "0x2000035")]
	public enum XRs
	{
		[Token(Token = "0x40000E6")]
		VR,
		[Token(Token = "0x40000E7")]
		AR
	}

	[Token(Token = "0x2000036")]
	public enum DeviceTypes
	{
		[Token(Token = "0x40000E9")]
		MOBILE,
		[Token(Token = "0x40000EA")]
		DESKTOP
	}

	[Token(Token = "0x2000037")]
	public enum OperatingSystems
	{
		[Token(Token = "0x40000EC")]
		ANDROID,
		[Token(Token = "0x40000ED")]
		IOS,
		[Token(Token = "0x40000EE")]
		WINDOWS
	}

	[Token(Token = "0x2000038")]
	public enum Platforms
	{
		[Token(Token = "0x40000F0")]
		OCULUS,
		[Token(Token = "0x40000F1")]
		STEAM,
		[Token(Token = "0x40000F2")]
		VIVEPORT,
		[Token(Token = "0x40000F3")]
		GOOGLEPLAY,
		[Token(Token = "0x40000F4")]
		APPSTORE,
		[Token(Token = "0x40000F5")]
		PICO
	}

	[Token(Token = "0x1700001D")]
	public static XRs XR
	{
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1190494", Offset = "0x1190494", VA = "0x1190494")]
		get
		{
			return default(XRs);
		}
	}

	[Token(Token = "0x1700001E")]
	public static DeviceTypes DeviceType
	{
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x119049C", Offset = "0x119049C", VA = "0x119049C")]
		get
		{
			return default(DeviceTypes);
		}
	}

	[Token(Token = "0x1700001F")]
	public static OperatingSystems OperatingSystem
	{
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x11904A4", Offset = "0x11904A4", VA = "0x11904A4")]
		get
		{
			return default(OperatingSystems);
		}
	}

	[Token(Token = "0x17000020")]
	public static Platforms Platform
	{
		[Token(Token = "0x600012A")]
		[Address(RVA = "0x11904AC", Offset = "0x11904AC", VA = "0x11904AC")]
		get
		{
			return default(Platforms);
		}
	}

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x11904B4", Offset = "0x11904B4", VA = "0x11904B4")]
	public AppEnv()
	{
	}
}
[Token(Token = "0x2000039")]
public class AutoDestroy : MonoBehaviour
{
	[Token(Token = "0x600012C")]
	[Address(RVA = "0x1193C34", Offset = "0x1193C34", VA = "0x1193C34")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x1193CAC", Offset = "0x1193CAC", VA = "0x1193CAC")]
	public AutoDestroy()
	{
	}
}
[Token(Token = "0x200003A")]
public static class BrinkLocationPathUtils
{
	[Token(Token = "0x600012E")]
	[Address(RVA = "0x1199854", Offset = "0x1199854", VA = "0x1199854")]
	public static string GetLocationNameFromPath(string path)
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x11998F8", Offset = "0x11998F8", VA = "0x11998F8")]
	public static string GetSubLocationNameFromSubLocationScenePath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x119999C", Offset = "0x119999C", VA = "0x119999C")]
	public static string GetMeshFolderFromSubLocationScenePath(string path)
	{
		return null;
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1199CB8", Offset = "0x1199CB8", VA = "0x1199CB8")]
	public static string GetCollisionMeshFolderFromSubLocationScenePath(string path)
	{
		return null;
	}
}
[Token(Token = "0x200003B")]
public static class BrinkStringUtils
{
	[Token(Token = "0x17000021")]
	private static string HighlightedStyle
	{
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x119FB40", Offset = "0x119FB40", VA = "0x119FB40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x1190774", Offset = "0x1190774", VA = "0x1190774")]
	public static string GetTranslation(string key, bool upperFirst = false, bool toTitle = false, [Optional] string overrideLanguageCode)
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1192908", Offset = "0x1192908", VA = "0x1192908")]
	public static string ReplaceMarkup(string str)
	{
		return null;
	}

	[Token(Token = "0x6000135")]
	[Address(RVA = "0x119FC58", Offset = "0x119FC58", VA = "0x119FC58")]
	public static string RemoveMarkup(string str)
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x119FCE4", Offset = "0x119FCE4", VA = "0x119FCE4")]
	public static string RemoveHTML(string input)
	{
		return null;
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x119FB90", Offset = "0x119FB90", VA = "0x119FB90")]
	public static string UppercaseFirst(string s)
	{
		return null;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x119FBF4", Offset = "0x119FBF4", VA = "0x119FBF4")]
	public static string ToTitle(string s)
	{
		return null;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x119FD98", Offset = "0x119FD98", VA = "0x119FD98")]
	public static string FormatDescriptionText(string s)
	{
		return null;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x119FE4C", Offset = "0x119FE4C", VA = "0x119FE4C")]
	public static string FormatPOIPopupText(string text1, string text2)
	{
		return null;
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x119FDAC", Offset = "0x119FDAC", VA = "0x119FDAC")]
	public static string ReplaceBold(string str)
	{
		return null;
	}
}
[Token(Token = "0x200003C")]
public class CanyonBloom : MonoBehaviour
{
	[Token(Token = "0x40000F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AnimationCurve Curve;

	[Token(Token = "0x40000F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Bloom Bloom;

	[Token(Token = "0x40000F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float DefaultIntensity;

	[Token(Token = "0x40000F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float DefaultScatter;

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x15D2184", Offset = "0x15D2184", VA = "0x15D2184")]
	private void Start()
	{
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x15D224C", Offset = "0x15D224C", VA = "0x15D224C")]
	private void Update()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x15D23D8", Offset = "0x15D23D8", VA = "0x15D23D8")]
	public CanyonBloom()
	{
	}
}
[Token(Token = "0x200003D")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xAE3E20", Offset = "0xAE3E20")]
public class ChristmasLogoSwap : MonoBehaviour
{
	[Token(Token = "0x40000FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Material LogoMaterial;

	[Token(Token = "0x40000FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Texture2D LogoRegular;

	[Token(Token = "0x40000FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D LogoChristmas;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x15D23E0", Offset = "0x15D23E0", VA = "0x15D23E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x15D24CC", Offset = "0x15D24CC", VA = "0x15D24CC")]
	public ChristmasLogoSwap()
	{
	}
}
[Token(Token = "0x200003E")]
public class FaceCamera : MonoBehaviour
{
	[Token(Token = "0x6000141")]
	[Address(RVA = "0x15D6A1C", Offset = "0x15D6A1C", VA = "0x15D6A1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x15D6B18", Offset = "0x15D6B18", VA = "0x15D6B18")]
	public FaceCamera()
	{
	}
}
[Token(Token = "0x200003F")]
public class HandControllerOffsetFinder : MonoBehaviour
{
	[Token(Token = "0x40000FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Vector3 PositionRef;

	[Token(Token = "0x40000FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private Vector3 DirectionRef;

	[Token(Token = "0x40000FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform RefSpace;

	[Token(Token = "0x4000100")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform RightController;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x15DCCF4", Offset = "0x15DCCF4", VA = "0x15DCCF4")]
	public void Find()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x15DCE30", Offset = "0x15DCE30", VA = "0x15DCE30")]
	public HandControllerOffsetFinder()
	{
	}
}
[Token(Token = "0x2000040")]
public class HandFollow : MonoBehaviour
{
	[Token(Token = "0x2000041")]
	public enum HAND_SIDE
	{
		[Token(Token = "0x4000104")]
		Left,
		[Token(Token = "0x4000105")]
		Right
	}

	[Token(Token = "0x4000101")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public HAND_SIDE Hand;

	[Token(Token = "0x4000102")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform Follow;

	[Token(Token = "0x6000145")]
	[Address(RVA = "0x15DCE58", Offset = "0x15DCE58", VA = "0x15DCE58")]
	private void Update()
	{
	}

	[Token(Token = "0x6000146")]
	[Address(RVA = "0x15DD038", Offset = "0x15DD038", VA = "0x15DD038")]
	public HandFollow()
	{
	}
}
[Token(Token = "0x2000042")]
public class HideOnQuest1 : MonoBehaviour
{
	[Token(Token = "0x6000147")]
	[Address(RVA = "0x15E1FD0", Offset = "0x15E1FD0", VA = "0x15E1FD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000148")]
	[Address(RVA = "0x15E2064", Offset = "0x15E2064", VA = "0x15E2064")]
	public HideOnQuest1()
	{
	}
}
[Token(Token = "0x2000043")]
public class LerpFollow : MonoBehaviour
{
	[Token(Token = "0x4000106")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Follow;

	[Token(Token = "0x4000107")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5168", Offset = "0xAE5168")]
	public float Speed;

	[Token(Token = "0x6000149")]
	[Address(RVA = "0x141CAEC", Offset = "0x141CAEC", VA = "0x141CAEC")]
	private void Update()
	{
	}

	[Token(Token = "0x600014A")]
	[Address(RVA = "0x141CC78", Offset = "0x141CC78", VA = "0x141CC78")]
	public LerpFollow()
	{
	}
}
[Token(Token = "0x2000044")]
public static class LocalizationHelper
{
	[Token(Token = "0x2000045")]
	private class LocalizedFieldInfo
	{
		[Token(Token = "0x400010B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TextMeshPro Field;

		[Token(Token = "0x400010C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Key;

		[Token(Token = "0x400010D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool UpperFirst;

		[Token(Token = "0x400010E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool IsTitle;

		[Token(Token = "0x400010F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Dictionary<string, string> Parameters;

		[Token(Token = "0x4000110")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string Prefix;

		[Token(Token = "0x4000111")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Sufix;

		[Token(Token = "0x6000155")]
		[Address(RVA = "0xE44A20", Offset = "0xE44A20", VA = "0xE44A20")]
		public LocalizedFieldInfo()
		{
		}
	}

	[Token(Token = "0x4000108")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly UnityEvent OnLocalizeEvent;

	[Token(Token = "0x4000109")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<TextMeshPro, LocalizedFieldInfo> fieldToInfo;

	[Token(Token = "0x400010A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static readonly string[] SupportedLanguageCodes;

	[Token(Token = "0x17000022")]
	public static UserSettings.EXPERIENCE_LANGUAGE_VALUES DefaultSettingsOptionValue
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x141D590", Offset = "0x141D590", VA = "0x141D590")]
		get
		{
			return default(UserSettings.EXPERIENCE_LANGUAGE_VALUES);
		}
	}

	[Token(Token = "0x17000023")]
	public static string UserLanguageSettingCode
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x141CDBC", Offset = "0x141CDBC", VA = "0x141CDBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	public static string UserLanguageSettingCodeSimplified
	{
		[Token(Token = "0x6000152")]
		[Address(RVA = "0x141D65C", Offset = "0x141D65C", VA = "0x141D65C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000025")]
	public static bool CurrentLanguageIsAsian
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x141D754", Offset = "0x141D754", VA = "0x141D754")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x141CCE0", Offset = "0x141CCE0", VA = "0x141CCE0")]
	public static void Init()
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x141CEB0", Offset = "0x141CEB0", VA = "0x141CEB0")]
	private static void OnLanguageChange()
	{
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x141D444", Offset = "0x141D444", VA = "0x141D444")]
	public static void SetLocalizationInfo(this TextMeshPro field, string key, bool upperFirst = false, bool isTitle = false, [Optional] Dictionary<string, string> parameters, [Optional] string prefix, [Optional] string sufix)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x141D280", Offset = "0x141D280", VA = "0x141D280")]
	private static void Localize(LocalizedFieldInfo fieldInfo)
	{
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x141D054", Offset = "0x141D054", VA = "0x141D054")]
	private static void RemoveNullFields()
	{
	}
}
[Token(Token = "0x2000046")]
public static class PreloadSceneManager
{
	[Token(Token = "0x4000112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, AsyncOperation> SceneLoadHandles;

	[Token(Token = "0x4000113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<string, AsyncOperationHandle<SceneInstance>> SceneAdressabelHandles;

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x1090738", Offset = "0x1090738", VA = "0x1090738")]
	public static AsyncOperation PreloadSceneAsync(string sceneName, LoadSceneMode loadSceneMode)
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1090880", Offset = "0x1090880", VA = "0x1090880")]
	public static AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode loadSceneMode)
	{
		return null;
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1090984", Offset = "0x1090984", VA = "0x1090984")]
	public static AsyncOperationHandle<SceneInstance> AddressablesPreloadSceneAsync(string key, LoadSceneMode loadSceneMode)
	{
		return default(AsyncOperationHandle<SceneInstance>);
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1090AF0", Offset = "0x1090AF0", VA = "0x1090AF0")]
	public static AsyncOperationHandle<SceneInstance> AddressablesLoadSceneAsync(string key, LoadSceneMode loadSceneMode)
	{
		return default(AsyncOperationHandle<SceneInstance>);
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1090C38", Offset = "0x1090C38", VA = "0x1090C38")]
	public static void AddressablesPreloadSceneAsync(string empty)
	{
	}
}
[Token(Token = "0x2000047")]
public class UIFader : MonoBehaviour
{
	[Token(Token = "0x2000048")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3E48", Offset = "0xAE3E48")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x4000114")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float v;

		[Token(Token = "0x4000115")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UIFader <>4__this;

		[Token(Token = "0x4000116")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenCallback <>9__0;

		[Token(Token = "0x4000117")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweenCallback <>9__3;

		[Token(Token = "0x4000118")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TweenCallback <>9__4;

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x167AC2C", Offset = "0x167AC2C", VA = "0x167AC2C")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x167AC34", Offset = "0x167AC34", VA = "0x167AC34")]
		internal void <Fade>b__0()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x167AC78", Offset = "0x167AC78", VA = "0x167AC78")]
		internal void <Fade>b__3()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x167ACBC", Offset = "0x167ACBC", VA = "0x167ACBC")]
		internal void <Fade>b__4()
		{
		}
	}

	[Token(Token = "0x2000049")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3E58", Offset = "0xAE3E58")]
	private sealed class <>c__DisplayClass1_1
	{
		[Token(Token = "0x4000119")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OVROverlay OvrOverlay;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x167AD00", Offset = "0x167AD00", VA = "0x167AD00")]
		public <>c__DisplayClass1_1()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x167AD08", Offset = "0x167AD08", VA = "0x167AD08")]
		internal float <Fade>b__1()
		{
			return default(float);
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x167AD24", Offset = "0x167AD24", VA = "0x167AD24")]
		internal void <Fade>b__2(float x)
		{
		}
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0xE35C2C", Offset = "0xE35C2C", VA = "0xE35C2C")]
	public void FadeFromZero(float v, float time = 0f, float delay = 0f, Ease ease = Ease.Linear)
	{
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0xE35C90", Offset = "0xE35C90", VA = "0xE35C90")]
	public void Fade(float v, float time = 0f, float delay = 0f, Ease ease = Ease.Linear)
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0xE3638C", Offset = "0xE3638C", VA = "0xE3638C")]
	public UIFader()
	{
	}
}
[Token(Token = "0x200004A")]
public class URPDepthTextureEnabler : MonoBehaviour
{
	[Token(Token = "0x400011A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<GameObject> Enablers;

	[Token(Token = "0x6000166")]
	[Address(RVA = "0xE36394", Offset = "0xE36394", VA = "0xE36394")]
	private void OnBecameVisible()
	{
	}

	[Token(Token = "0x6000167")]
	[Address(RVA = "0xE36594", Offset = "0xE36594", VA = "0xE36594")]
	private void OnBecameInvisible()
	{
	}

	[Token(Token = "0x6000168")]
	[Address(RVA = "0xE366B0", Offset = "0xE366B0", VA = "0xE366B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000169")]
	[Address(RVA = "0xE364B0", Offset = "0xE364B0", VA = "0xE364B0")]
	private static void SetSupportsCameraDepthTexture()
	{
	}

	[Token(Token = "0x600016A")]
	[Address(RVA = "0xE367CC", Offset = "0xE367CC", VA = "0xE367CC")]
	public URPDepthTextureEnabler()
	{
	}
}
[Token(Token = "0x200004B")]
public static class URPSetterWorkAround
{
	[Token(Token = "0x400011B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static FieldInfo MainLightCastShadows_FieldInfo;

	[Token(Token = "0x400011C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static FieldInfo AdditionalLightCastShadows_FieldInfo;

	[Token(Token = "0x400011D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static FieldInfo MainLightShadowmapResolution_FieldInfo;

	[Token(Token = "0x400011E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static FieldInfo AdditionalLightShadowmapResolution_FieldInfo;

	[Token(Token = "0x400011F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static FieldInfo Cascade2Split_FieldInfo;

	[Token(Token = "0x4000120")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static FieldInfo Cascade4Split_FieldInfo;

	[Token(Token = "0x4000121")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static FieldInfo ShadowsEnabled_FieldInfo;

	[Token(Token = "0x4000122")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static FieldInfo SoftShadowsEnabled_FieldInfo;

	[Token(Token = "0x17000026")]
	public static bool MainLightCastShadows
	{
		[Token(Token = "0x600016D")]
		[Address(RVA = "0xE36AC8", Offset = "0xE36AC8", VA = "0xE36AC8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600016E")]
		[Address(RVA = "0xE36B90", Offset = "0xE36B90", VA = "0xE36B90")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	public static bool AdditionalLightCastShadows
	{
		[Token(Token = "0x600016F")]
		[Address(RVA = "0xE36C4C", Offset = "0xE36C4C", VA = "0xE36C4C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000170")]
		[Address(RVA = "0xE36D14", Offset = "0xE36D14", VA = "0xE36D14")]
		set
		{
		}
	}

	[Token(Token = "0x17000028")]
	public static ShadowResolution MainLightShadowResolution
	{
		[Token(Token = "0x6000171")]
		[Address(RVA = "0xE36DD0", Offset = "0xE36DD0", VA = "0xE36DD0")]
		get
		{
			return default(ShadowResolution);
		}
		[Token(Token = "0x6000172")]
		[Address(RVA = "0xE36E98", Offset = "0xE36E98", VA = "0xE36E98")]
		set
		{
		}
	}

	[Token(Token = "0x17000029")]
	public static ShadowResolution AdditionalLightShadowResolution
	{
		[Token(Token = "0x6000173")]
		[Address(RVA = "0xE36F54", Offset = "0xE36F54", VA = "0xE36F54")]
		get
		{
			return default(ShadowResolution);
		}
		[Token(Token = "0x6000174")]
		[Address(RVA = "0xE3701C", Offset = "0xE3701C", VA = "0xE3701C")]
		set
		{
		}
	}

	[Token(Token = "0x1700002A")]
	public static float Cascade2Split
	{
		[Token(Token = "0x6000175")]
		[Address(RVA = "0xE370D8", Offset = "0xE370D8", VA = "0xE370D8")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000176")]
		[Address(RVA = "0xE371A0", Offset = "0xE371A0", VA = "0xE371A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700002B")]
	public static Vector3 Cascade4Split
	{
		[Token(Token = "0x6000177")]
		[Address(RVA = "0xE3725C", Offset = "0xE3725C", VA = "0xE3725C")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000178")]
		[Address(RVA = "0xE37328", Offset = "0xE37328", VA = "0xE37328")]
		set
		{
		}
	}

	[Token(Token = "0x1700002C")]
	public static bool ShadowsEnabled
	{
		[Token(Token = "0x6000179")]
		[Address(RVA = "0xE37400", Offset = "0xE37400", VA = "0xE37400")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600017A")]
		[Address(RVA = "0xE374C8", Offset = "0xE374C8", VA = "0xE374C8")]
		set
		{
		}
	}

	[Token(Token = "0x1700002D")]
	public static bool SoftShadowsEnabled
	{
		[Token(Token = "0x600017B")]
		[Address(RVA = "0xE37584", Offset = "0xE37584", VA = "0xE37584")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600017C")]
		[Address(RVA = "0xE3764C", Offset = "0xE3764C", VA = "0xE3764C")]
		set
		{
		}
	}

	[Token(Token = "0x600016C")]
	[Address(RVA = "0xE3685C", Offset = "0xE3685C", VA = "0xE3685C")]
	static URPSetterWorkAround()
	{
	}
}
[Token(Token = "0x200004C")]
public static class WeightedRandomizer
{
	[Token(Token = "0x600017D")]
	public static WeightedRandomizer<R> From<R>(Dictionary<R, int> spawnRate)
	{
		return null;
	}
}
[Token(Token = "0x200004D")]
public class WeightedRandomizer<T>
{
	[Serializable]
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3E68", Offset = "0xAE3E68")]
	private sealed class <>c
	{
		[Token(Token = "0x4000125")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000126")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static Comparison<KeyValuePair<T, int>> <>9__4_0;

		[Token(Token = "0x6000183")]
		public <>c()
		{
		}

		[Token(Token = "0x6000184")]
		internal int <Sort>b__4_0(KeyValuePair<T, int> firstPair, KeyValuePair<T, int> nextPair)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000123")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static System.Random _random;

	[Token(Token = "0x4000124")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private Dictionary<T, int> _weights;

	[Token(Token = "0x600017E")]
	public WeightedRandomizer(Dictionary<T, int> weights)
	{
	}

	[Token(Token = "0x600017F")]
	public T TakeOne()
	{
		return (T)null;
	}

	[Token(Token = "0x6000180")]
	private List<KeyValuePair<T, int>> Sort(Dictionary<T, int> weights)
	{
		return null;
	}
}
[Token(Token = "0x200004F")]
public class Console : MonoBehaviour
{
	[Token(Token = "0x4000127")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Console Instance;

	[Token(Token = "0x4000128")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI OutputField;

	[Token(Token = "0x4000129")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<string> Lines;

	[Token(Token = "0x400012A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CanvasGroup CanvasGroup;

	[Token(Token = "0x6000185")]
	[Address(RVA = "0x15D4E80", Offset = "0x15D4E80", VA = "0x15D4E80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000186")]
	[Address(RVA = "0x15D4FD4", Offset = "0x15D4FD4", VA = "0x15D4FD4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000187")]
	[Address(RVA = "0x15D5050", Offset = "0x15D5050", VA = "0x15D5050")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000188")]
	[Address(RVA = "0x15D50CC", Offset = "0x15D50CC", VA = "0x15D50CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000189")]
	[Address(RVA = "0x15D5218", Offset = "0x15D5218", VA = "0x15D5218")]
	private void LogReceived(string message, string stacktrace, LogType type)
	{
	}

	[Token(Token = "0x600018A")]
	[Address(RVA = "0x15D5440", Offset = "0x15D5440", VA = "0x15D5440")]
	private static void Log(string s)
	{
	}

	[Token(Token = "0x600018B")]
	[Address(RVA = "0x15D5810", Offset = "0x15D5810", VA = "0x15D5810")]
	public Console()
	{
	}
}
[Token(Token = "0x2000050")]
[ExecuteInEditMode]
public class PlayerPositionGizmos : MonoBehaviour
{
	[Token(Token = "0x400012B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool HideInPlayMode;

	[Token(Token = "0x400012C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	public bool ShowOnlyWhenSelected;

	[Token(Token = "0x400012D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public Color Color;

	[Token(Token = "0x400012E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public Mesh Mesh;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x108C674", Offset = "0x108C674", VA = "0x108C674")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x108C828", Offset = "0x108C828", VA = "0x108C828")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x108C730", Offset = "0x108C730", VA = "0x108C730")]
	private void Draw()
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x108C82C", Offset = "0x108C82C", VA = "0x108C82C")]
	public PlayerPositionGizmos()
	{
	}
}
[Token(Token = "0x2000051")]
[ExecuteInEditMode]
public class HoloMesh : AddressablePrefab
{
	[Token(Token = "0x400012F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private HoloMeshPart[] _HoloMeshParts;

	[Token(Token = "0x1700002E")]
	public HoloMeshPart[] HoloMeshParts
	{
		[Token(Token = "0x6000192")]
		[Address(RVA = "0x15E20EC", Offset = "0x15E20EC", VA = "0x15E20EC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000191")]
	[Address(RVA = "0x15E206C", Offset = "0x15E206C", VA = "0x15E206C")]
	public void SetNightMode(bool v)
	{
	}

	[Token(Token = "0x6000193")]
	[Address(RVA = "0x15E22C4", Offset = "0x15E22C4", VA = "0x15E22C4")]
	public HoloMesh()
	{
	}
}
[Token(Token = "0x2000052")]
[ExecuteInEditMode]
public class HoloMeshPart : MonoBehaviour
{
	[Token(Token = "0x4000130")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int EXTRA_DARKNESS;

	[Token(Token = "0x4000131")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int CUTOFF;

	[Token(Token = "0x4000132")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5190", Offset = "0xAE5190")]
	public Material CustomMaterial;

	[Token(Token = "0x4000133")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool KeepCustomMaterialInMenu;

	[Token(Token = "0x4000134")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool KeepCustomMaterialAtNight;

	[Token(Token = "0x4000135")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE51C8", Offset = "0xAE51C8")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE51C8", Offset = "0xAE51C8")]
	public float NightExtraDarkness;

	[Token(Token = "0x4000136")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ReflectionProbeUsage ReflectionProbeUsage;

	[Token(Token = "0x4000137")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Shader CustomShader;

	[Token(Token = "0x4000138")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private MeshRenderer _MeshRenderer;

	[Token(Token = "0x4000139")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool UsingCustomMaterial;

	[Token(Token = "0x400013A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private HoloMeshPartData _Data;

	[Token(Token = "0x400013B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Shader _BrinkMeshShader;

	[Token(Token = "0x400013C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture _NoiseTex;

	[Token(Token = "0x1700002F")]
	private MeshRenderer MeshRenderer
	{
		[Token(Token = "0x600019E")]
		[Address(RVA = "0x15E24C4", Offset = "0x15E24C4", VA = "0x15E24C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000030")]
	private HoloMeshPartData Data
	{
		[Token(Token = "0x600019F")]
		[Address(RVA = "0x15E2FF0", Offset = "0x15E2FF0", VA = "0x15E2FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000031")]
	private Shader BrinkMeshShader
	{
		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x15E2F50", Offset = "0x15E2F50", VA = "0x15E2F50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000032")]
	private static Texture NoiseTex
	{
		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x15E3098", Offset = "0x15E3098", VA = "0x15E3098")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000033")]
	private bool MaterialVisibleInInspector
	{
		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x15E2568", Offset = "0x15E2568", VA = "0x15E2568")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000194")]
	[Address(RVA = "0x15E22CC", Offset = "0x15E22CC", VA = "0x15E22CC")]
	public void ToggleNightMode()
	{
	}

	[Token(Token = "0x6000195")]
	[Address(RVA = "0x15E2398", Offset = "0x15E2398", VA = "0x15E2398")]
	public void ShowMaterial()
	{
	}

	[Token(Token = "0x6000196")]
	[Address(RVA = "0x15E26C0", Offset = "0x15E26C0", VA = "0x15E26C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000197")]
	[Address(RVA = "0x15E2A70", Offset = "0x15E2A70", VA = "0x15E2A70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000198")]
	[Address(RVA = "0x15E216C", Offset = "0x15E216C", VA = "0x15E216C")]
	public void SetNightMode(bool isON)
	{
	}

	[Token(Token = "0x6000199")]
	[Address(RVA = "0x15E2B70", Offset = "0x15E2B70", VA = "0x15E2B70")]
	private void UseBrinkMeshShader()
	{
	}

	[Token(Token = "0x600019A")]
	[Address(RVA = "0x15E26F8", Offset = "0x15E26F8", VA = "0x15E26F8")]
	private void CreateOrUpdateMaterial()
	{
	}

	[Token(Token = "0x600019B")]
	[Address(RVA = "0x15E2C74", Offset = "0x15E2C74", VA = "0x15E2C74")]
	private void UpdateMaterialParams()
	{
	}

	[Token(Token = "0x600019C")]
	[Address(RVA = "0x15E31CC", Offset = "0x15E31CC", VA = "0x15E31CC")]
	public void Setup()
	{
	}

	[Token(Token = "0x600019D")]
	[Address(RVA = "0x15E3244", Offset = "0x15E3244", VA = "0x15E3244")]
	private void UpdateReflectionProbeUsage()
	{
	}

	[Token(Token = "0x60001A3")]
	[Address(RVA = "0x15E3274", Offset = "0x15E3274", VA = "0x15E3274")]
	public HoloMeshPart()
	{
	}
}
[Token(Token = "0x2000053")]
[ExecuteInEditMode]
public class HoloMeshPartData : MonoBehaviour
{
	[Token(Token = "0x400013D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture Texture;

	[Token(Token = "0x400013E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Mesh Mesh;

	[Token(Token = "0x60001A5")]
	[Address(RVA = "0x15E331C", Offset = "0x15E331C", VA = "0x15E331C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001A6")]
	[Address(RVA = "0x15E3370", Offset = "0x15E3370", VA = "0x15E3370")]
	public HoloMeshPartData()
	{
	}
}
[Token(Token = "0x2000054")]
[ExecuteInEditMode]
public class LocationController : MonoBehaviour
{
	[Token(Token = "0x2000055")]
	public enum NightModeEnum
	{
		[Token(Token = "0x4000187")]
		OFF,
		[Token(Token = "0x4000188")]
		ON
	}

	[Token(Token = "0x2000056")]
	public enum AMBIENT_SOURCES
	{
		[Token(Token = "0x400018A")]
		SKYBOX,
		[Token(Token = "0x400018B")]
		COLOR
	}

	[Token(Token = "0x2000057")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3EC8", Offset = "0xAE3EC8")]
	private sealed class <LoadAllInstantiators>d__89 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400018C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400018D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400018E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocationController <>4__this;

		[Token(Token = "0x400018F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AddressablePrefabProxy[] <>7__wrap1;

		[Token(Token = "0x4000190")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int <>7__wrap2;

		[Token(Token = "0x4000191")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private AddressablePrefabProxy <instantiator>5__4;

		[Token(Token = "0x1700003B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0xE44ECC", Offset = "0xE44ECC", VA = "0xE44ECC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0xE44F14", Offset = "0xE44F14", VA = "0xE44F14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001CE")]
		[Address(RVA = "0xE44C98", Offset = "0xE44C98", VA = "0xE44C98")]
		[DebuggerHidden]
		public <LoadAllInstantiators>d__89(int <>1__state)
		{
		}

		[Token(Token = "0x60001CF")]
		[Address(RVA = "0xE44CC4", Offset = "0xE44CC4", VA = "0xE44CC4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60001D0")]
		[Address(RVA = "0xE44CC8", Offset = "0xE44CC8", VA = "0xE44CC8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001D2")]
		[Address(RVA = "0xE44ED4", Offset = "0xE44ED4", VA = "0xE44ED4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000058")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3ED8", Offset = "0xAE3ED8")]
	private sealed class <>c
	{
		[Token(Token = "0x4000192")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000193")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static DOGetter<float> <>9__99_0;

		[Token(Token = "0x4000194")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static DOSetter<float> <>9__99_1;

		[Token(Token = "0x4000195")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static DOGetter<float> <>9__99_2;

		[Token(Token = "0x4000196")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static DOSetter<float> <>9__99_3;

		[Token(Token = "0x4000197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static TweenCallback <>9__99_4;

		[Token(Token = "0x60001D5")]
		[Address(RVA = "0xE44A88", Offset = "0xE44A88", VA = "0xE44A88")]
		public <>c()
		{
		}

		[Token(Token = "0x60001D6")]
		[Address(RVA = "0xE44A90", Offset = "0xE44A90", VA = "0xE44A90")]
		internal float <SetDitherEffect>b__99_0()
		{
			return default(float);
		}

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0xE44AF8", Offset = "0xE44AF8", VA = "0xE44AF8")]
		internal void <SetDitherEffect>b__99_1(float x)
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0xE44B70", Offset = "0xE44B70", VA = "0xE44B70")]
		internal float <SetDitherEffect>b__99_2()
		{
			return default(float);
		}

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0xE44BD8", Offset = "0xE44BD8", VA = "0xE44BD8")]
		internal void <SetDitherEffect>b__99_3(float x)
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0xE44C50", Offset = "0xE44C50", VA = "0xE44C50")]
		internal void <SetDitherEffect>b__99_4()
		{
		}
	}

	[Token(Token = "0x400013F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool NIGHT_MODE;

	[Token(Token = "0x4000140")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool LOADING_INSTANTIATORS;

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Vector3 LIGHT_DIRECTION;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string CURRENT_SPOT_ID;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static readonly int MESH_DITHER_OPACITY;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	private static readonly int MESH_DITHER_POS;

	[Token(Token = "0x4000145")]
	private const string MESH_DITHER_EFFECT = "MESH_DITHER_EFFECT";

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static readonly int HOLOMESH_BRIGHTNESS;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private static readonly int SUN_COLOR;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static readonly int MOON_COLOR;

	[Token(Token = "0x4000149")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public SkyEffects SkyEffects;

	[Token(Token = "0x400014A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Marker[] Markers;

	[Token(Token = "0x400014B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAE523C", Offset = "0xAE523C")]
	public NightModeEnum NightModeEditor;

	[Token(Token = "0x400014C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private bool _NightMode;

	[Token(Token = "0x400014D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE524C", Offset = "0xAE524C")]
	public float LuminaryRotationX;

	[Token(Token = "0x400014E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5268", Offset = "0xAE5268")]
	public float LuminaryRotationY;

	[Token(Token = "0x400014F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5284", Offset = "0xAE5284")]
	public bool EnableCubemapRotation;

	[Token(Token = "0x4000150")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE52BC", Offset = "0xAE52BC")]
	public float SkyRotationSpeed;

	[Token(Token = "0x4000151")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE52D4", Offset = "0xAE52D4")]
	public float SkyRotationAmplitude;

	[Token(Token = "0x4000152")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE52EC", Offset = "0xAE52EC")]
	public bool Visualize;

	[Token(Token = "0x4000153")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool DisableSunFlare;

	[Token(Token = "0x4000154")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
	public bool DisableAirplanes;

	[Token(Token = "0x4000155")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x47")]
	public bool DisableShootingStars;

	[Token(Token = "0x4000156")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5324", Offset = "0xAE5324")]
	public bool IndependantSpots;

	[Token(Token = "0x4000157")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE535C", Offset = "0xAE535C")]
	public Texture SkyboxTexture;

	[Token(Token = "0x4000158")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5394", Offset = "0xAE5394")]
	public bool UseSecondaryCubemap;

	[Token(Token = "0x4000159")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE53CC", Offset = "0xAE53CC")]
	public Texture SkyboxSecondaryTexture;

	[Token(Token = "0x400015A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5404", Offset = "0xAE5404")]
	public float SkyboxRotation;

	[Token(Token = "0x400015B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5424", Offset = "0xAE5424")]
	public float SkyboxExposure;

	[Token(Token = "0x400015C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE543C", Offset = "0xAE543C")]
	public float SunSize;

	[Token(Token = "0x400015D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5454", Offset = "0xAE5454")]
	public Color SunColor;

	[Token(Token = "0x400015E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Texture SunTexture;

	[Token(Token = "0x400015F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5468", Offset = "0xAE5468")]
	public Color LightColor;

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE547C", Offset = "0xAE547C")]
	public float LightIntensity;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5494", Offset = "0xAE5494")]
	public float ShadowIntensity;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AMBIENT_SOURCES AmbientSource;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE54AC", Offset = "0xAE54AC")]
	public Color AmbientColorDay;

	[Token(Token = "0x4000164")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE54C0", Offset = "0xAE54C0")]
	public float AmbientLightIntensity;

	[Token(Token = "0x4000165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE54D8", Offset = "0xAE54D8")]
	public int SkyboxRotationNight;

	[Token(Token = "0x4000166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE54F8", Offset = "0xAE54F8")]
	public float SkyboxExposureNight;

	[Token(Token = "0x4000167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5510", Offset = "0xAE5510")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5510", Offset = "0xAE5510")]
	public float SkyboxLandBrightnessNight;

	[Token(Token = "0x4000168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5564", Offset = "0xAE5564")]
	public Color GlowColor;

	[Token(Token = "0x4000169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5578", Offset = "0xAE5578")]
	public float GlowHeight;

	[Token(Token = "0x400016A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5594", Offset = "0xAE5594")]
	public float GlowSmoothness;

	[Token(Token = "0x400016B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE55AC", Offset = "0xAE55AC")]
	public float GlowOffset;

	[Token(Token = "0x400016C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE55C4", Offset = "0xAE55C4")]
	public Texture GlowMaskTexture;

	[Token(Token = "0x400016D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE55FC", Offset = "0xAE55FC")]
	public float MoonSize;

	[Token(Token = "0x400016E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5614", Offset = "0xAE5614")]
	public Color MoonColor;

	[Token(Token = "0x400016F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Texture MoonTexture;

	[Token(Token = "0x4000170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5628", Offset = "0xAE5628")]
	public float MeshBrightnessNight;

	[Token(Token = "0x4000171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5640", Offset = "0xAE5640")]
	public Color LightColorNight;

	[Token(Token = "0x4000172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5654", Offset = "0xAE5654")]
	public float LightIntensityNight;

	[Token(Token = "0x4000173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE566C", Offset = "0xAE566C")]
	public float ShadowIntensityNight;

	[Token(Token = "0x4000174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public string WindType;

	[Token(Token = "0x4000175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5684", Offset = "0xAE5684")]
	public float WindPower;

	[Token(Token = "0x4000176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE56A0", Offset = "0xAE56A0")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE56A0", Offset = "0xAE56A0")]
	public float WindDirection;

	[Token(Token = "0x4000177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public bool OverrideCameraFarClip;

	[Token(Token = "0x4000178")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE56F8", Offset = "0xAE56F8")]
	public float OverridenCameraFarClip;

	[Token(Token = "0x4000179")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	[HideInInspector]
	public SpotController[] Spots;

	[Token(Token = "0x400017A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	internal SpotController CurrentSpot;

	[Token(Token = "0x400017B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Light _MainLuminary;

	[Token(Token = "0x400017C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private static float DefaultFarClipPlane;

	[Token(Token = "0x400017D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static Texture Cubemap_Night;

	[Token(Token = "0x400017E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static Texture Cubemap_NightMilkyWayMask;

	[Token(Token = "0x400017F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Texture Default_Texture_Moon;

	[Token(Token = "0x4000180")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static Texture Default_Texture_Sun;

	[Token(Token = "0x4000181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static Texture Texture_MoonFlare;

	[Token(Token = "0x4000182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private float WindPowerMultiplier;

	[Token(Token = "0x4000183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	private bool FogDefault;

	[Token(Token = "0x4000184")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Tween MeshDitherOpacityTween;

	[Token(Token = "0x4000185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private TVEGlobalMotion _TVEGlobalMotion;

	[Token(Token = "0x17000034")]
	private static LocationInfo LocationInfo
	{
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x141DBEC", Offset = "0x141DBEC", VA = "0x141DBEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000035")]
	public bool NightMode
	{
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x141DC48", Offset = "0x141DC48", VA = "0x141DC48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x141DC50", Offset = "0x141DC50", VA = "0x141DC50")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	internal Transform SpawnPosition
	{
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x141DDBC", Offset = "0x141DDBC", VA = "0x141DDBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000037")]
	internal Marker[] CurrentSpotMarkers
	{
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x141DE48", Offset = "0x141DE48", VA = "0x141DE48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000038")]
	private Light LuminaryLight
	{
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x141DF18", Offset = "0x141DF18", VA = "0x141DF18")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000039")]
	private static WindBase PlayerWind
	{
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x141F16C", Offset = "0x141F16C", VA = "0x141F16C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003A")]
	private TVEGlobalMotion TVEGlobalMotion
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x141FC68", Offset = "0x141FC68", VA = "0x141FC68")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001AE")]
	[Address(RVA = "0x141F174", Offset = "0x141F174", VA = "0x141F174")]
	private void Awake()
	{
	}

	[Token(Token = "0x60001AF")]
	[Address(RVA = "0x141F5D4", Offset = "0x141F5D4", VA = "0x141F5D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60001B0")]
	[Address(RVA = "0x141F824", Offset = "0x141F824", VA = "0x141F824")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001B1")]
	[Address(RVA = "0x141F8C4", Offset = "0x141F8C4", VA = "0x141F8C4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001B2")]
	[Address(RVA = "0x141FA28", Offset = "0x141FA28", VA = "0x141FA28")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60001B3")]
	[Address(RVA = "0x141FB14", Offset = "0x141FB14", VA = "0x141FB14")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB38C", Offset = "0xAEB38C")]
	public IEnumerator LoadAllInstantiators()
	{
		return null;
	}

	[Token(Token = "0x60001B4")]
	[Address(RVA = "0x141FB80", Offset = "0x141FB80", VA = "0x141FB80")]
	public void InitForReveal()
	{
	}

	[Token(Token = "0x60001B5")]
	[Address(RVA = "0x141FD24", Offset = "0x141FD24", VA = "0x141FD24")]
	public void SetUIOverlayMode(bool v)
	{
	}

	[Token(Token = "0x60001B6")]
	[Address(RVA = "0x1420454", Offset = "0x1420454", VA = "0x1420454")]
	public void EnableSunFlare(bool v)
	{
	}

	[Token(Token = "0x60001B7")]
	[Address(RVA = "0x1420474", Offset = "0x1420474", VA = "0x1420474")]
	public void ToggleNightMode()
	{
	}

	[Token(Token = "0x60001B8")]
	[Address(RVA = "0x1420484", Offset = "0x1420484", VA = "0x1420484")]
	public void OnAppFocusOut()
	{
	}

	[Token(Token = "0x60001B9")]
	[Address(RVA = "0x1420558", Offset = "0x1420558", VA = "0x1420558")]
	public void OnAppFocusIn()
	{
	}

	[Token(Token = "0x60001BA")]
	[Address(RVA = "0x142066C", Offset = "0x142066C", VA = "0x142066C")]
	public void OnWillSaveScene()
	{
	}

	[Token(Token = "0x60001BB")]
	[Address(RVA = "0x141F758", Offset = "0x141F758", VA = "0x141F758")]
	private static void AssignAllViewIDs()
	{
	}

	[Token(Token = "0x60001BC")]
	[Address(RVA = "0x141DCF4", Offset = "0x141DCF4", VA = "0x141DCF4")]
	private void OnNightModeChange()
	{
	}

	[Token(Token = "0x60001BD")]
	[Address(RVA = "0x141FEFC", Offset = "0x141FEFC", VA = "0x141FEFC")]
	private void SetDitherEffect(bool v)
	{
	}

	[Token(Token = "0x60001BE")]
	[Address(RVA = "0x142069C", Offset = "0x142069C", VA = "0x142069C")]
	public void ActivateSpot(SpotController spot)
	{
	}

	[Token(Token = "0x60001BF")]
	[Address(RVA = "0x14206A0", Offset = "0x14206A0", VA = "0x14206A0")]
	public void FadeAudioOut()
	{
	}

	[Token(Token = "0x60001C0")]
	[Address(RVA = "0x1420720", Offset = "0x1420720", VA = "0x1420720")]
	public void DisablePOIMarkers(bool v = true)
	{
	}

	[Token(Token = "0x60001C1")]
	[Address(RVA = "0x1420804", Offset = "0x1420804", VA = "0x1420804")]
	public void ShowStageLine(bool v = true)
	{
	}

	[Token(Token = "0x60001C2")]
	[Address(RVA = "0x141F3C4", Offset = "0x141F3C4", VA = "0x141F3C4")]
	private void SetCurrentSpot(SpotController spot)
	{
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x141E26C", Offset = "0x141E26C", VA = "0x141E26C")]
	public void UpdateEnvironment()
	{
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x141FDC8", Offset = "0x141FDC8", VA = "0x141FDC8")]
	private void FadeWindPowerTo(float v)
	{
	}

	[Token(Token = "0x60001C5")]
	[Address(RVA = "0x141F900", Offset = "0x141F900", VA = "0x141F900")]
	private void UpdateWindPower()
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x141F8C0", Offset = "0x141F8C0", VA = "0x141F8C0")]
	private void OnEnabledEditor()
	{
	}

	[Token(Token = "0x60001C8")]
	[Address(RVA = "0x141F8FC", Offset = "0x141F8FC", VA = "0x141F8FC")]
	private void UpdateEditor()
	{
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x14208A8", Offset = "0x14208A8", VA = "0x14208A8")]
	public LocationController()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1420BA8", Offset = "0x1420BA8", VA = "0x1420BA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB3EC", Offset = "0xAEB3EC")]
	private bool <get_CurrentSpotMarkers>b__70_0(Marker marker)
	{
		return default(bool);
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1420C50", Offset = "0x1420C50", VA = "0x1420C50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB3FC", Offset = "0xAEB3FC")]
	private float <FadeWindPowerTo>b__107_0()
	{
		return default(float);
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x1420C58", Offset = "0x1420C58", VA = "0x1420C58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB40C", Offset = "0xAEB40C")]
	private void <FadeWindPowerTo>b__107_1(float x)
	{
	}
}
[Token(Token = "0x2000059")]
[ExecuteInEditMode]
public class SpotController : MonoBehaviour
{
	[Token(Token = "0x200005A")]
	[Flags]
	public enum DefaultEnum
	{
		[Token(Token = "0x40001B6")]
		InBuild = 2,
		[Token(Token = "0x40001B7")]
		InPlayMode = 8
	}

	[Serializable]
	[Token(Token = "0x200005B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F08", Offset = "0xAE3F08")]
	private sealed class <>c
	{
		[Token(Token = "0x40001B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<StudioEventEmitter, bool> <>9__56_0;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static DOGetter<float> <>9__71_0;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static DOSetter<float> <>9__71_1;

		[Token(Token = "0x6000202")]
		[Address(RVA = "0x1675FBC", Offset = "0x1675FBC", VA = "0x1675FBC")]
		public <>c()
		{
		}

		[Token(Token = "0x6000203")]
		[Address(RVA = "0x1675FC4", Offset = "0x1675FC4", VA = "0x1675FC4")]
		internal bool <Start>b__56_0(StudioEventEmitter emitter)
		{
			return default(bool);
		}

		[Token(Token = "0x6000204")]
		[Address(RVA = "0x167605C", Offset = "0x167605C", VA = "0x167605C")]
		internal float <DarkenMesh>b__71_0()
		{
			return default(float);
		}

		[Token(Token = "0x6000205")]
		[Address(RVA = "0x16760C4", Offset = "0x16760C4", VA = "0x16760C4")]
		internal void <DarkenMesh>b__71_1(float x)
		{
		}
	}

	[Token(Token = "0x200005C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F18", Offset = "0xAE3F18")]
	private sealed class <Start>d__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SpotController <>4__this;

		[Token(Token = "0x1700004B")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1676C04", Offset = "0x1676C04", VA = "0x1676C04", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x1676C4C", Offset = "0x1676C4C", VA = "0x1676C4C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000206")]
		[Address(RVA = "0x1676354", Offset = "0x1676354", VA = "0x1676354")]
		[DebuggerHidden]
		public <Start>d__56(int <>1__state)
		{
		}

		[Token(Token = "0x6000207")]
		[Address(RVA = "0x1676380", Offset = "0x1676380", VA = "0x1676380", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000208")]
		[Address(RVA = "0x1676384", Offset = "0x1676384", VA = "0x1676384", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600020A")]
		[Address(RVA = "0x1676C0C", Offset = "0x1676C0C", VA = "0x1676C0C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200005D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F28", Offset = "0xAE3F28")]
	private sealed class <>c__DisplayClass71_0
	{
		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SpotController <>4__this;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool v;

		[Token(Token = "0x600020C")]
		[Address(RVA = "0x167613C", Offset = "0x167613C", VA = "0x167613C")]
		public <>c__DisplayClass71_0()
		{
		}

		[Token(Token = "0x600020D")]
		[Address(RVA = "0x1676144", Offset = "0x1676144", VA = "0x1676144")]
		internal void <DarkenMesh>b__2()
		{
		}

		[Token(Token = "0x600020E")]
		[Address(RVA = "0x1676200", Offset = "0x1676200", VA = "0x1676200")]
		internal void <DarkenMesh>b__3()
		{
		}
	}

	[Token(Token = "0x200005E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F38", Offset = "0xAE3F38")]
	private sealed class <>c__DisplayClass74_0
	{
		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter emitter;

		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float targetVolume;

		[Token(Token = "0x600020F")]
		[Address(RVA = "0x16762BC", Offset = "0x16762BC", VA = "0x16762BC")]
		public <>c__DisplayClass74_0()
		{
		}

		[Token(Token = "0x6000210")]
		[Address(RVA = "0x16762C4", Offset = "0x16762C4", VA = "0x16762C4")]
		internal void <FadeInAudioLoops>b__0()
		{
		}
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F48", Offset = "0xAE3F48")]
	private sealed class <>c__DisplayClass76_0
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public StudioEventEmitter emitter;

		[Token(Token = "0x6000211")]
		[Address(RVA = "0x167630C", Offset = "0x167630C", VA = "0x167630C")]
		public <>c__DisplayClass76_0()
		{
		}

		[Token(Token = "0x6000212")]
		[Address(RVA = "0x1676314", Offset = "0x1676314", VA = "0x1676314")]
		internal void <FadeOutAudioLoops>b__0()
		{
		}
	}

	[Token(Token = "0x4000198")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int HOLOMESH_DARKENING_PROP;

	[Token(Token = "0x4000199")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public DefaultEnum Default;

	[Token(Token = "0x400019A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5728", Offset = "0xAE5728")]
	public bool LuminaryPositionOverride;

	[Token(Token = "0x400019B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5760", Offset = "0xAE5760")]
	public float LuminaryRotationX;

	[Token(Token = "0x400019C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE577C", Offset = "0xAE577C")]
	public float LuminaryRotationY;

	[Token(Token = "0x400019D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5798", Offset = "0xAE5798")]
	public bool SkyboxOverride;

	[Token(Token = "0x400019E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE57D0", Offset = "0xAE57D0")]
	public int SkyboxRotation;

	[Token(Token = "0x400019F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture SkyboxTexture;

	[Token(Token = "0x40001A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Texture SkyboxSecondaryTexture;

	[Token(Token = "0x40001A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public SpotController ParentSpot;

	[Token(Token = "0x40001A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int[] ParentSpotUDIMsToKeep;

	[Token(Token = "0x40001A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public bool KeepSatelliteData;

	[Token(Token = "0x40001A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	public bool KeepAnimations;

	[Token(Token = "0x40001A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE57EC", Offset = "0xAE57EC")]
	public bool WindPowerOverride;

	[Token(Token = "0x40001A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5824", Offset = "0xAE5824")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5824", Offset = "0xAE5824")]
	public int AudioReverb;

	[Token(Token = "0x40001A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE587C", Offset = "0xAE587C")]
	public float WindPower;

	[Token(Token = "0x40001A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject _HoloMeshCollision;

	[Token(Token = "0x40001A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public Transform SpawnPosition;

	[Token(Token = "0x40001AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Transform _Wildlife;

	[Token(Token = "0x40001AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Transform _Grabbables;

	[Token(Token = "0x40001AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Transform _Animations;

	[Token(Token = "0x40001AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform _Plants;

	[Token(Token = "0x40001AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Transform _PostProcessingVolumes;

	[Token(Token = "0x40001AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform _Particles;

	[Token(Token = "0x40001B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<Transform, Transform> PulledToOriginalParent;

	[Token(Token = "0x40001B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private List<StudioEventEmitter> AudioEvents;

	[Token(Token = "0x40001B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Tween DarkenTween;

	[Token(Token = "0x40001B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private bool NightMode;

	[Token(Token = "0x40001B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private StageBound _StageBound;

	[Token(Token = "0x1700003D")]
	public string SystemName
	{
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x138EAAC", Offset = "0x138EAAC", VA = "0x138EAAC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003E")]
	public string CustomName
	{
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x138EB54", Offset = "0x138EB54", VA = "0x138EB54")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700003F")]
	private string SpotId
	{
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x138ECC0", Offset = "0x138ECC0", VA = "0x138ECC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000040")]
	public GameObject HoloMeshCollider
	{
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x138EDD0", Offset = "0x138EDD0", VA = "0x138EDD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000041")]
	private Transform Wildlife
	{
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x138F070", Offset = "0x138F070", VA = "0x138F070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000042")]
	private Transform Grabbables
	{
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x138F124", Offset = "0x138F124", VA = "0x138F124")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000043")]
	private Transform Animations
	{
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x138F1D8", Offset = "0x138F1D8", VA = "0x138F1D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000044")]
	private Transform Plants
	{
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x138F28C", Offset = "0x138F28C", VA = "0x138F28C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000045")]
	private Transform PostProcessingVolumes
	{
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x138F340", Offset = "0x138F340", VA = "0x138F340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000046")]
	private Transform Particles
	{
		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x138F3F4", Offset = "0x138F3F4", VA = "0x138F3F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000047")]
	public HoloMesh HoloMesh
	{
		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x138EED4", Offset = "0x138EED4", VA = "0x138EED4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000048")]
	public StageBound StageBound
	{
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x138F4A8", Offset = "0x138F4A8", VA = "0x138F4A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000049")]
	private int SpotIndex
	{
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x138F5D0", Offset = "0x138F5D0", VA = "0x138F5D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700004A")]
	private static LocationInfo LocationInfo
	{
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x138EC64", Offset = "0x138EC64", VA = "0x138EC64")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60001E8")]
	[Address(RVA = "0x138F5FC", Offset = "0x138F5FC", VA = "0x138F5FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB46C", Offset = "0xAEB46C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60001E9")]
	[Address(RVA = "0x138F668", Offset = "0x138F668", VA = "0x138F668")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001EA")]
	[Address(RVA = "0x138FBE4", Offset = "0x138FBE4", VA = "0x138FBE4")]
	private void Update()
	{
	}

	[Token(Token = "0x60001EB")]
	[Address(RVA = "0x138F6AC", Offset = "0x138F6AC", VA = "0x138F6AC")]
	public void InitStageBound()
	{
	}

	[Token(Token = "0x60001EC")]
	[Address(RVA = "0x138FE88", Offset = "0x138FE88", VA = "0x138FE88")]
	public void Enable()
	{
	}

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x139009C", Offset = "0x139009C", VA = "0x139009C")]
	public void Disable()
	{
	}

	[Token(Token = "0x60001EE")]
	[Address(RVA = "0x13905D0", Offset = "0x13905D0", VA = "0x13905D0")]
	public void SetUIOverlayMode(bool v)
	{
	}

	[Token(Token = "0x60001EF")]
	[Address(RVA = "0x138F6CC", Offset = "0x138F6CC", VA = "0x138F6CC")]
	public void SetNightMode(bool v)
	{
	}

	[Token(Token = "0x60001F0")]
	[Address(RVA = "0x139194C", Offset = "0x139194C", VA = "0x139194C")]
	public void FadeAudioOut()
	{
	}

	[Token(Token = "0x60001F1")]
	[Address(RVA = "0x1391954", Offset = "0x1391954", VA = "0x1391954")]
	public void PauseAudio()
	{
	}

	[Token(Token = "0x60001F2")]
	[Address(RVA = "0x1391B28", Offset = "0x1391B28", VA = "0x1391B28")]
	public void ResumeAudio()
	{
	}

	[Token(Token = "0x60001F3")]
	[Address(RVA = "0x1391B2C", Offset = "0x1391B2C", VA = "0x1391B2C")]
	public void ShowStageLine(bool v)
	{
	}

	[Token(Token = "0x60001F4")]
	[Address(RVA = "0x1391BEC", Offset = "0x1391BEC", VA = "0x1391BEC")]
	private void CloneUDIMsFromParentSpot()
	{
	}

	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x138FEC4", Offset = "0x138FEC4", VA = "0x138FEC4")]
	private void PullFromParentSpot()
	{
	}

	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x1390394", Offset = "0x1390394", VA = "0x1390394")]
	private void PushBackToParentSpot()
	{
	}

	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x1390770", Offset = "0x1390770", VA = "0x1390770")]
	private void DarkenMesh(bool v)
	{
	}

	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x1390D10", Offset = "0x1390D10", VA = "0x1390D10")]
	private void HideEnvDetails()
	{
	}

	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x13913F8", Offset = "0x13913F8", VA = "0x13913F8")]
	private void ShowEnvDetails()
	{
	}

	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x1390FA4", Offset = "0x1390FA4", VA = "0x1390FA4")]
	private void FadeInAudioLoops()
	{
	}

	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x1390BB0", Offset = "0x1390BB0", VA = "0x1390BB0")]
	private void LowerDownAudioLoops()
	{
	}

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x13900E4", Offset = "0x13900E4", VA = "0x13900E4")]
	private void FadeOutAudioLoops(bool andStop = false)
	{
	}

	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x138F6C8", Offset = "0x138F6C8", VA = "0x138F6C8")]
	private void OnEnableEditor()
	{
	}

	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x139201C", Offset = "0x139201C", VA = "0x139201C")]
	public SpotController()
	{
	}
}
[Token(Token = "0x2000060")]
[ExecuteInEditMode]
public class StageBound : MonoBehaviour
{
	[Token(Token = "0x2000061")]
	private enum BoundModes
	{
		[Token(Token = "0x40001D3")]
		Terrain,
		[Token(Token = "0x40001D4")]
		Flat
	}

	[Token(Token = "0x2000062")]
	private enum ZTestModes
	{
		[Token(Token = "0x40001D6")]
		ON,
		[Token(Token = "0x40001D7")]
		OFF
	}

	[Token(Token = "0x40001C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color LineColor;

	[Token(Token = "0x40001C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE58A8", Offset = "0xAE58A8")]
	public bool UseLowestPoints;

	[Token(Token = "0x40001C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE58E0", Offset = "0xAE58E0")]
	public bool AlwaysDisplayFlat;

	[Token(Token = "0x40001C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private BoundModes LineMode;

	[Token(Token = "0x40001C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ZTestModes ZTestMode;

	[Token(Token = "0x40001C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Dictionary<Polyline, List<PolylinePoint>> LineToPoints2D;

	[Token(Token = "0x40001CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly Dictionary<Polyline, List<PolylinePoint>> LineToPoints3D;

	[Token(Token = "0x40001CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool Points3DValid;

	[Token(Token = "0x40001CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MeshCollider ColliderStage;

	[Token(Token = "0x40001CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Polygon Stage;

	[Token(Token = "0x40001CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Polyline Line;

	[Token(Token = "0x40001CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private bool LineVisible;

	[Token(Token = "0x40001D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private int ZTestValue;

	[Token(Token = "0x40001D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int ZTest;

	[Token(Token = "0x6000213")]
	[Address(RVA = "0x1392154", Offset = "0x1392154", VA = "0x1392154")]
	private void Start()
	{
	}

	[Token(Token = "0x6000214")]
	[Address(RVA = "0x139219C", Offset = "0x139219C", VA = "0x139219C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000215")]
	[Address(RVA = "0x1392428", Offset = "0x1392428", VA = "0x1392428")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000216")]
	[Address(RVA = "0x13924F0", Offset = "0x13924F0", VA = "0x13924F0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000217")]
	[Address(RVA = "0x138FD90", Offset = "0x138FD90", VA = "0x138FD90")]
	public void Init()
	{
	}

	[Token(Token = "0x6000218")]
	[Address(RVA = "0x1391B58", Offset = "0x1391B58", VA = "0x1391B58")]
	public void ShowLine(bool v)
	{
	}

	[Token(Token = "0x6000219")]
	[Address(RVA = "0x1393108", Offset = "0x1393108", VA = "0x1393108")]
	private void SetZTest()
	{
	}

	[Token(Token = "0x600021A")]
	[Address(RVA = "0x1392290", Offset = "0x1392290", VA = "0x1392290")]
	private void UpdateLineMode()
	{
	}

	[Token(Token = "0x600021B")]
	[Address(RVA = "0x139235C", Offset = "0x139235C", VA = "0x139235C")]
	private void UpdateLines()
	{
	}

	[Token(Token = "0x600021C")]
	[Address(RVA = "0x1392800", Offset = "0x1392800", VA = "0x1392800")]
	private void FindLinePoints(Polyline line, Polygon stage)
	{
	}

	[Token(Token = "0x600021D")]
	[Address(RVA = "0x13932AC", Offset = "0x13932AC", VA = "0x13932AC")]
	private void ShowLineEditor()
	{
	}

	[Token(Token = "0x600021E")]
	[Address(RVA = "0x13932E4", Offset = "0x13932E4", VA = "0x13932E4")]
	private void UpdateZTest()
	{
	}

	[Token(Token = "0x600021F")]
	[Address(RVA = "0x1393310", Offset = "0x1393310", VA = "0x1393310")]
	private void OnLocomotionSettingChange()
	{
	}

	[Token(Token = "0x6000220")]
	[Address(RVA = "0x13933A0", Offset = "0x13933A0", VA = "0x13933A0")]
	public StageBound()
	{
	}
}
[Token(Token = "0x2000063")]
public class MainController : MonoBehaviour
{
	[Token(Token = "0x2000064")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F68", Offset = "0xAE3F68")]
	private sealed class <Start>d__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainController <>4__this;

		[Token(Token = "0x17000056")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xE490C8", Offset = "0xE490C8", VA = "0xE490C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000057")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xE49110", Offset = "0xE49110", VA = "0xE49110", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0xE48A1C", Offset = "0xE48A1C", VA = "0xE48A1C")]
		[DebuggerHidden]
		public <Start>d__17(int <>1__state)
		{
		}

		[Token(Token = "0x6000242")]
		[Address(RVA = "0xE48A48", Offset = "0xE48A48", VA = "0xE48A48", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0xE48A4C", Offset = "0xE48A4C", VA = "0xE48A4C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0xE490D0", Offset = "0xE490D0", VA = "0xE490D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000065")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F78", Offset = "0xAE3F78")]
	private sealed class <LoadLocation>d__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MainController <>4__this;

		[Token(Token = "0x40001EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string locationId;

		[Token(Token = "0x17000058")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xE48358", Offset = "0xE48358", VA = "0xE48358", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000059")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xE483A0", Offset = "0xE483A0", VA = "0xE483A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0xE47F7C", Offset = "0xE47F7C", VA = "0xE47F7C")]
		[DebuggerHidden]
		public <LoadLocation>d__20(int <>1__state)
		{
		}

		[Token(Token = "0x6000248")]
		[Address(RVA = "0xE47FA8", Offset = "0xE47FA8", VA = "0xE47FA8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0xE47FAC", Offset = "0xE47FAC", VA = "0xE47FAC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0xE48360", Offset = "0xE48360", VA = "0xE48360", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000066")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F88", Offset = "0xAE3F88")]
	private sealed class <LoadStaticAudioBank>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40001EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IEnumerator<string> <>7__wrap1;

		[Token(Token = "0x40001EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private AsyncOperationHandle<TextAsset> <op>5__3;

		[Token(Token = "0x1700005A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0xE489CC", Offset = "0xE489CC", VA = "0xE489CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000253")]
			[Address(RVA = "0xE48A14", Offset = "0xE48A14", VA = "0xE48A14", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600024D")]
		[Address(RVA = "0xE483A8", Offset = "0xE483A8", VA = "0xE483A8")]
		[DebuggerHidden]
		public <LoadStaticAudioBank>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x600024E")]
		[Address(RVA = "0xE483D4", Offset = "0xE483D4", VA = "0xE483D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600024F")]
		[Address(RVA = "0xE484BC", Offset = "0xE484BC", VA = "0xE484BC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000250")]
		[Address(RVA = "0xE48400", Offset = "0xE48400", VA = "0xE48400")]
		private void <>m__Finally1()
		{
		}

		[Token(Token = "0x6000252")]
		[Address(RVA = "0xE489D4", Offset = "0xE489D4", VA = "0xE489D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000067")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3F98", Offset = "0xAE3F98")]
	private sealed class <>c__DisplayClass25_0
	{
		[Token(Token = "0x40001F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainController <>4__this;

		[Token(Token = "0x40001F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string locationId;

		[Token(Token = "0x40001F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string embeddedDefaultLocation;

		[Token(Token = "0x40001F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<LocationInfo> <>9__1;

		[Token(Token = "0x6000254")]
		[Address(RVA = "0xE47C60", Offset = "0xE47C60", VA = "0xE47C60")]
		public <>c__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6000255")]
		[Address(RVA = "0xE47C68", Offset = "0xE47C68", VA = "0xE47C68")]
		internal void <OnIntroReadyToLoadPrerequisites>b__0(LocationInfo locationInfo)
		{
		}

		[Token(Token = "0x6000256")]
		[Address(RVA = "0xE47DA8", Offset = "0xE47DA8", VA = "0xE47DA8")]
		internal void <OnIntroReadyToLoadPrerequisites>b__1(LocationInfo _)
		{
		}
	}

	[Token(Token = "0x2000068")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FA8", Offset = "0xAE3FA8")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x40001F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public MainController <>4__this;

		[Token(Token = "0x40001F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocationInfo locationInfo;

		[Token(Token = "0x6000257")]
		[Address(RVA = "0xE47DE8", Offset = "0xE47DE8", VA = "0xE47DE8")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000258")]
		[Address(RVA = "0xE47DF0", Offset = "0xE47DF0", VA = "0xE47DF0")]
		internal void <OnLocationDownloadSuccess>b__0()
		{
		}
	}

	[Token(Token = "0x2000069")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FB8", Offset = "0xAE3FB8")]
	private sealed class <DetectManufacturer>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40001F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700005C")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0xE47F2C", Offset = "0xE47F2C", VA = "0xE47F2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700005D")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0xE47F74", Offset = "0xE47F74", VA = "0xE47F74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0xE47E38", Offset = "0xE47E38", VA = "0xE47E38")]
		[DebuggerHidden]
		public <DetectManufacturer>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0xE47E64", Offset = "0xE47E64", VA = "0xE47E64", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0xE47E68", Offset = "0xE47E68", VA = "0xE47E68", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0xE47F34", Offset = "0xE47F34", VA = "0xE47F34", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40001D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static MainController Instance;

	[Token(Token = "0x40001D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool IntroIsPlaying;

	[Token(Token = "0x40001DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static bool LoadingLocation;

	[Token(Token = "0x40001DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public static bool PlayingFromLocationInEditor;

	[Token(Token = "0x40001DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public static bool MainAudioBanksLoaded;

	[Token(Token = "0x40001DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static bool PostcardSharingEnabled;

	[Token(Token = "0x40001DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	public static bool PostProcessingEnabled;

	[Token(Token = "0x40001DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrinkPlayer Player;

	[Token(Token = "0x40001E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public IntroBase Intro;

	[Token(Token = "0x40001E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public ShaderVariantCollection[] ShaderVariantCollectionWarmUp;

	[Token(Token = "0x40001E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string LocationIdFromInvite;

	[Token(Token = "0x40001E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string RoomCodeFromInvite;

	[Token(Token = "0x40001E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static string MANUFACTURER;

	[Token(Token = "0x1700004D")]
	public static LocationInfo CurrentLocationInfo
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xFF8134", Offset = "0xFF8134", VA = "0xFF8134")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004E")]
	public static string CurrentLocationId
	{
		[Token(Token = "0x6000223")]
		[Address(RVA = "0xFF8190", Offset = "0xFF8190", VA = "0xFF8190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004F")]
	public static string APP_ID
	{
		[Token(Token = "0x6000236")]
		[Address(RVA = "0xFF8498", Offset = "0xFF8498", VA = "0xFF8498")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000050")]
	public static bool IsUnknown
	{
		[Token(Token = "0x6000237")]
		[Address(RVA = "0xFF967C", Offset = "0xFF967C", VA = "0xFF967C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000051")]
	public static bool IsOculus
	{
		[Token(Token = "0x6000238")]
		[Address(RVA = "0xFF9704", Offset = "0xFF9704", VA = "0xFF9704")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000052")]
	public static bool IsValveIndex
	{
		[Token(Token = "0x6000239")]
		[Address(RVA = "0xFF9784", Offset = "0xFF9784", VA = "0xFF9784")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000053")]
	public static bool IsReverbG2
	{
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xFF7DA0", Offset = "0xFF7DA0", VA = "0xFF7DA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000054")]
	public static bool IsVive
	{
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xFF9804", Offset = "0xFF9804", VA = "0xFF9804")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000055")]
	public static bool IsPico
	{
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xFF9884", Offset = "0xFF9884", VA = "0xFF9884")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000224")]
	[Address(RVA = "0xFF822C", Offset = "0xFF822C", VA = "0xFF822C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000225")]
	[Address(RVA = "0xFF84DC", Offset = "0xFF84DC", VA = "0xFF84DC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB51C", Offset = "0xAEB51C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0xFF8548", Offset = "0xFF8548", VA = "0xFF8548")]
	private void OnApplicationQuit()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0xFF854C", Offset = "0xFF854C", VA = "0xFF854C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0xFF8618", Offset = "0xFF8618", VA = "0xFF8618")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB57C", Offset = "0xAEB57C")]
	private IEnumerator LoadLocation(string locationId)
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0xFF8690", Offset = "0xFF8690", VA = "0xFF8690")]
	private void OnBaseSceneLoaded(Transform spawnPosition)
	{
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0xFF8790", Offset = "0xFF8790", VA = "0xFF8790")]
	private void OnLocationMeshLoaded(string locationId)
	{
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0xFF89F4", Offset = "0xFF89F4", VA = "0xFF89F4")]
	private static void OnLoadingError(string locationId, string error)
	{
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0xFF8A58", Offset = "0xFF8A58", VA = "0xFF8A58")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB5DC", Offset = "0xAEB5DC")]
	private static IEnumerator LoadStaticAudioBank()
	{
		return null;
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0xFF8AB4", Offset = "0xFF8AB4", VA = "0xFF8AB4")]
	private void OnIntroReadyToLoadPrerequisites()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0xFF8C2C", Offset = "0xFF8C2C", VA = "0xFF8C2C")]
	private void OnIntroEnded()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0xFF8CE8", Offset = "0xFF8CE8", VA = "0xFF8CE8")]
	private void OnActionButtonSelected(string locationId)
	{
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0xFF8DB8", Offset = "0xFF8DB8", VA = "0xFF8DB8")]
	private void DownloadLocation(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0xFF8ECC", Offset = "0xFF8ECC", VA = "0xFF8ECC")]
	private void OnLocationDownloadSuccess(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000232")]
	[Address(RVA = "0xFF91C0", Offset = "0xFF91C0", VA = "0xFF91C0")]
	private void OnLocationDownloadFailed(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000233")]
	[Address(RVA = "0xFF91F4", Offset = "0xFF91F4", VA = "0xFF91F4")]
	private void OnLocationMenuOpen()
	{
	}

	[Token(Token = "0x6000234")]
	[Address(RVA = "0xFF9320", Offset = "0xFF9320", VA = "0xFF9320")]
	private void PauseApp()
	{
	}

	[Token(Token = "0x6000235")]
	[Address(RVA = "0xFF94A0", Offset = "0xFF94A0", VA = "0xFF94A0")]
	private void UnpauseApp()
	{
	}

	[Token(Token = "0x600023D")]
	[Address(RVA = "0xFF9904", Offset = "0xFF9904", VA = "0xFF9904")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB63C", Offset = "0xAEB63C")]
	private static IEnumerator DetectManufacturer()
	{
		return null;
	}

	[Token(Token = "0x600023E")]
	[Address(RVA = "0xFF9960", Offset = "0xFF9960", VA = "0xFF9960")]
	public MainController()
	{
	}

	[Token(Token = "0x6000240")]
	[Address(RVA = "0xFF99E8", Offset = "0xFF99E8", VA = "0xFF99E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEB69C", Offset = "0xAEB69C")]
	private void <OnActionButtonSelected>b__27_0(LocationInfo locationInfo)
	{
	}
}
[Token(Token = "0x200006A")]
public static class AddressableManager
{
	[Token(Token = "0x200006B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FC8", Offset = "0xAE3FC8")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x40001F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<AsyncOperationHandle> callback;

		[Token(Token = "0x40001F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetReference assetRef;

		[Token(Token = "0x6000262")]
		[Address(RVA = "0xE3E464", Offset = "0xE3E464", VA = "0xE3E464")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0xE3E46C", Offset = "0xE3E46C", VA = "0xE3E46C")]
		internal void <LoadAssetReferenceAsync>b__0(AsyncOperationHandle handle)
		{
		}
	}

	[Token(Token = "0x200006C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FD8", Offset = "0xAE3FD8")]
	private sealed class <>c__DisplayClass0_1
	{
		[Token(Token = "0x40001FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AsyncOperationHandle<UnityEngine.Object> op;

		[Token(Token = "0x40001FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public <>c__DisplayClass0_0 CS$<>8__locals1;

		[Token(Token = "0x6000264")]
		[Address(RVA = "0xE3E4F8", Offset = "0xE3E4F8", VA = "0xE3E4F8")]
		public <>c__DisplayClass0_1()
		{
		}

		[Token(Token = "0x6000265")]
		[Address(RVA = "0xE3E500", Offset = "0xE3E500", VA = "0xE3E500")]
		internal void <LoadAssetReferenceAsync>b__1(AsyncOperationHandle<UnityEngine.Object> handle)
		{
		}
	}

	[Token(Token = "0x200006D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FE8", Offset = "0xAE3FE8")]
	private sealed class <>c__DisplayClass1_0<type>
	{
		[Token(Token = "0x40001FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public object key;

		[Token(Token = "0x6000266")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000267")]
		internal bool <AddressableResourceExists>b__0(IResourceLocator l)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600025F")]
	[Address(RVA = "0x118B548", Offset = "0x118B548", VA = "0x118B548")]
	public static void LoadAssetReferenceAsync(AssetReference assetRef, Action<AsyncOperationHandle> callback)
	{
	}

	[Token(Token = "0x6000260")]
	public static bool AddressableResourceExists<type>(object key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000261")]
	[Address(RVA = "0x118B878", Offset = "0x118B878", VA = "0x118B878")]
	public static string GetAddressFromAssetReference(AssetReference reference)
	{
		return null;
	}
}
[Token(Token = "0x200006E")]
public class LocationLoadManager : MonoBehaviour
{
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE3FF8", Offset = "0xAE3FF8")]
	private sealed class <Start>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000204")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000205")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000060")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600027D")]
			[Address(RVA = "0xE46F40", Offset = "0xE46F40", VA = "0xE46F40", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000061")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600027F")]
			[Address(RVA = "0xE46F88", Offset = "0xE46F88", VA = "0xE46F88", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600027A")]
		[Address(RVA = "0xE46CFC", Offset = "0xE46CFC", VA = "0xE46CFC")]
		[DebuggerHidden]
		public <Start>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x600027B")]
		[Address(RVA = "0xE46D28", Offset = "0xE46D28", VA = "0xE46D28", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600027C")]
		[Address(RVA = "0xE46D2C", Offset = "0xE46D2C", VA = "0xE46D2C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600027E")]
		[Address(RVA = "0xE46F48", Offset = "0xE46F48", VA = "0xE46F48", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4008", Offset = "0xAE4008")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000206")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AsyncOperationHandle<Texture> handle;

		[Token(Token = "0x4000207")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<string, Texture> onSuccess;

		[Token(Token = "0x4000208")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string locationId;

		[Token(Token = "0x4000209")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Action<string> onFail;

		[Token(Token = "0x6000280")]
		[Address(RVA = "0xE45044", Offset = "0xE45044", VA = "0xE45044")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000281")]
		[Address(RVA = "0xE4504C", Offset = "0xE4504C", VA = "0xE4504C")]
		internal void <LoadLocationPostcard>b__0(AsyncOperationHandle<Texture> operationHandle)
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4018", Offset = "0xAE4018")]
	private struct <LoadLocationInfo>d__15 : IAsyncStateMachine
	{
		[Token(Token = "0x400020A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x400020B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x400020C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string locationId;

		[Token(Token = "0x400020D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<LocationInfo> onSuccess;

		[Token(Token = "0x400020E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<string> onFail;

		[Token(Token = "0x400020F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private AsyncOperationHandle<LocationInfo> <handle>5__2;

		[Token(Token = "0x4000210")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskAwaiter<LocationInfo> <>u__1;

		[Token(Token = "0x6000282")]
		[Address(RVA = "0xE46654", Offset = "0xE46654", VA = "0xE46654", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000283")]
		[Address(RVA = "0xE46CF0", Offset = "0xE46CF0", VA = "0xE46CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4028", Offset = "0xAE4028")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000211")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationInfo locationInfo;

		[Token(Token = "0x4000212")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<AsyncOperationHandle<IList<IResourceLocation>>> <>9__3;

		[Token(Token = "0x6000284")]
		[Address(RVA = "0xE45134", Offset = "0xE45134", VA = "0xE45134")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x6000285")]
		[Address(RVA = "0xE4513C", Offset = "0xE4513C", VA = "0xE4513C")]
		internal void <CheckCacheState>b__0(AsyncOperationHandle<long> h)
		{
		}

		[Token(Token = "0x6000286")]
		[Address(RVA = "0xE455D4", Offset = "0xE455D4", VA = "0xE455D4")]
		internal void <CheckCacheState>b__3(AsyncOperationHandle<IList<IResourceLocation>> handle)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4038", Offset = "0xAE4038")]
	private sealed class <>c
	{
		[Token(Token = "0x4000213")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000214")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LocationInfo, bool> <>9__17_1;

		[Token(Token = "0x4000215")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<LocationInfo, int> <>9__17_2;

		[Token(Token = "0x6000288")]
		[Address(RVA = "0xE45000", Offset = "0xE45000", VA = "0xE45000")]
		public <>c()
		{
		}

		[Token(Token = "0x6000289")]
		[Address(RVA = "0xE45008", Offset = "0xE45008", VA = "0xE45008")]
		internal bool <CheckCacheState>b__17_1(LocationInfo info)
		{
			return default(bool);
		}

		[Token(Token = "0x600028A")]
		[Address(RVA = "0xE4502C", Offset = "0xE4502C", VA = "0xE4502C")]
		internal int <CheckCacheState>b__17_2(LocationInfo info)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4048", Offset = "0xAE4048")]
	private sealed class <>c__DisplayClass19_0
	{
		[Token(Token = "0x4000216")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationInfo locationInfo;

		[Token(Token = "0x4000217")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string locationId;

		[Token(Token = "0x4000218")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<LocationInfo> onSuccess;

		[Token(Token = "0x4000219")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<LocationInfo> onFail;

		[Token(Token = "0x400021A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public AsyncOperationHandle handle;

		[Token(Token = "0x600028B")]
		[Address(RVA = "0xE45D60", Offset = "0xE45D60", VA = "0xE45D60")]
		public <>c__DisplayClass19_0()
		{
		}

		[Token(Token = "0x600028C")]
		[Address(RVA = "0xE45D68", Offset = "0xE45D68", VA = "0xE45D68")]
		internal void <DownloadLocationAssets>g__OnDownloadCompleted|0(AsyncOperationHandle h)
		{
		}
	}

	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4058", Offset = "0xAE4058")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x400021B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AsyncOperationHandle<bool> handle;

		[Token(Token = "0x400021C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public LocationInfo locationInfo;

		[Token(Token = "0x600028D")]
		[Address(RVA = "0xE4619C", Offset = "0xE4619C", VA = "0xE4619C")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0xE461A4", Offset = "0xE461A4", VA = "0xE461A4")]
		internal void <ClearLocationAssets>b__0(AsyncOperationHandle<bool> h)
		{
		}
	}

	[Token(Token = "0x2000076")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4068", Offset = "0xAE4068")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x2000077")]
		private sealed class <<LoadLocation>g__SceneLoadCo|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000222")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000223")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000224")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass21_0 <>4__this;

			[Token(Token = "0x4000225")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private AsyncOperation <unloadOp>5__2;

			[Token(Token = "0x17000062")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000297")]
				[Address(RVA = "0x167B954", Offset = "0x167B954", VA = "0x167B954", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000063")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000299")]
				[Address(RVA = "0x167B99C", Offset = "0x167B99C", VA = "0x167B99C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000294")]
			[Address(RVA = "0x167B4EC", Offset = "0x167B4EC", VA = "0x167B4EC")]
			[DebuggerHidden]
			public <<LoadLocation>g__SceneLoadCo|0>d(int <>1__state)
			{
			}

			[Token(Token = "0x6000295")]
			[Address(RVA = "0x167B518", Offset = "0x167B518", VA = "0x167B518", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000296")]
			[Address(RVA = "0x167B51C", Offset = "0x167B51C", VA = "0x167B51C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000298")]
			[Address(RVA = "0x167B95C", Offset = "0x167B95C", VA = "0x167B95C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x2000078")]
		private sealed class <<LoadLocation>g__WaitForInstantiatorsReady|1>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000226")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000227")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000228")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass21_0 <>4__this;

			[Token(Token = "0x17000064")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600029D")]
				[Address(RVA = "0x167BB04", Offset = "0x167BB04", VA = "0x167BB04", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000065")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x600029F")]
				[Address(RVA = "0x167BB4C", Offset = "0x167BB4C", VA = "0x167BB4C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600029A")]
			[Address(RVA = "0x167B9A4", Offset = "0x167B9A4", VA = "0x167B9A4")]
			[DebuggerHidden]
			public <<LoadLocation>g__WaitForInstantiatorsReady|1>d(int <>1__state)
			{
			}

			[Token(Token = "0x600029B")]
			[Address(RVA = "0x167B9D0", Offset = "0x167B9D0", VA = "0x167B9D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600029C")]
			[Address(RVA = "0x167B9D4", Offset = "0x167B9D4", VA = "0x167B9D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600029E")]
			[Address(RVA = "0x167BB0C", Offset = "0x167BB0C", VA = "0x167BB0C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400021D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string locationId;

		[Token(Token = "0x400021E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocationInfo locationInfo;

		[Token(Token = "0x400021F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<string, string> onFail;

		[Token(Token = "0x4000220")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<Transform> onSceneLoadSuccess;

		[Token(Token = "0x4000221")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action<string> onMeshLoadSuccess;

		[Token(Token = "0x600028F")]
		[Address(RVA = "0xE46378", Offset = "0xE46378", VA = "0xE46378")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0xE46380", Offset = "0xE46380", VA = "0xE46380")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB90C", Offset = "0xAEB90C")]
		internal IEnumerator <LoadLocation>g__SceneLoadCo|0()
		{
			return null;
		}

		[Token(Token = "0x6000291")]
		[Address(RVA = "0xE463EC", Offset = "0xE463EC", VA = "0xE463EC")]
		internal void <LoadLocation>g__onComplete|2(AsyncOperation o)
		{
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0xE464E8", Offset = "0xE464E8", VA = "0xE464E8")]
		internal void <LoadLocation>b__3(AsyncOperationHandle<SceneInstance> operationHandle)
		{
		}

		[Token(Token = "0x6000293")]
		[Address(RVA = "0xE4647C", Offset = "0xE4647C", VA = "0xE4647C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB96C", Offset = "0xAEB96C")]
		internal IEnumerator <LoadLocation>g__WaitForInstantiatorsReady|1()
		{
			return null;
		}
	}

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string _CurrentLocationId;

	[Token(Token = "0x40001FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static LocationLoadManager Instance;

	[Token(Token = "0x40001FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static AsyncOperationHandle<SceneInstance> LoadedLocationSceneHandle;

	[Token(Token = "0x4000200")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static readonly Dictionary<LocationInfo, AsyncOperationHandle> LoadingHandles;

	[Token(Token = "0x4000201")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly Dictionary<LocationInfo, float> LoadingSceneLoadStartTime;

	[Token(Token = "0x4000202")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static readonly List<LocationDownloadQueueItem> QueuedItems;

	[Token(Token = "0x4000203")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public LocationInfoMenuList LocationInfoMenuList;

	[Token(Token = "0x1700005E")]
	public static LocationInfo CurrentLocationInfo
	{
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x1422924", Offset = "0x1422924", VA = "0x1422924")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700005F")]
	public static string CurrentLocationId
	{
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x14235F0", Offset = "0x14235F0", VA = "0x14235F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x1423588", Offset = "0x1423588", VA = "0x1423588")]
		private set
		{
		}
	}

	[Token(Token = "0x600026B")]
	[Address(RVA = "0x1423654", Offset = "0x1423654", VA = "0x1423654")]
	private void Awake()
	{
	}

	[Token(Token = "0x600026C")]
	[Address(RVA = "0x14236BC", Offset = "0x14236BC", VA = "0x14236BC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEB7EC", Offset = "0xAEB7EC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600026D")]
	[Address(RVA = "0x1423718", Offset = "0x1423718", VA = "0x1423718")]
	public static void LoadLocationPostcard(string locationId, Action<string, Texture> onSuccess, Action<string> onFail)
	{
	}

	[Token(Token = "0x600026E")]
	[Address(RVA = "0x14238B4", Offset = "0x14238B4", VA = "0x14238B4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xAEB84C", Offset = "0xAEB84C")]
	public static void LoadLocationInfo(string locationId, [Optional] Action<LocationInfo> onSuccess, [Optional] Action<string> onFail)
	{
	}

	[Token(Token = "0x600026F")]
	[Address(RVA = "0x1423984", Offset = "0x1423984", VA = "0x1423984")]
	public static int GetLocationIndexById(string id)
	{
		return default(int);
	}

	[Token(Token = "0x6000270")]
	[Address(RVA = "0x1423AB0", Offset = "0x1423AB0", VA = "0x1423AB0")]
	private static void CheckCacheState(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000271")]
	[Address(RVA = "0x1423DA0", Offset = "0x1423DA0", VA = "0x1423DA0")]
	private static void DownloadLocationAssets(LocationDownloadQueueItem queueditem)
	{
	}

	[Token(Token = "0x6000272")]
	[Address(RVA = "0x1423EA0", Offset = "0x1423EA0", VA = "0x1423EA0")]
	public static void DownloadLocationAssets(string locationId, [Optional] Action<LocationInfo> onSuccess, [Optional] Action<LocationInfo> onFail)
	{
	}

	[Token(Token = "0x6000273")]
	[Address(RVA = "0x14245CC", Offset = "0x14245CC", VA = "0x14245CC")]
	public static void ClearLocationAssets(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000274")]
	[Address(RVA = "0x14248C0", Offset = "0x14248C0", VA = "0x14248C0")]
	public static void LoadLocation(string locationId, Action<Transform> onSceneLoadSuccess, [Optional] Action<string> onMeshLoadSuccess, [Optional] Action<string, string> onFail)
	{
	}

	[Token(Token = "0x6000275")]
	[Address(RVA = "0x1424BB0", Offset = "0x1424BB0", VA = "0x1424BB0")]
	public static string GetDefaultLocationId()
	{
		return null;
	}

	[Token(Token = "0x6000276")]
	[Address(RVA = "0x1424C24", Offset = "0x1424C24", VA = "0x1424C24")]
	private void Update()
	{
	}

	[Token(Token = "0x6000277")]
	[Address(RVA = "0x1424E48", Offset = "0x1424E48", VA = "0x1424E48")]
	private static void TrackDownloadTime(string locationId, LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000278")]
	[Address(RVA = "0x1425110", Offset = "0x1425110", VA = "0x1425110")]
	public LocationLoadManager()
	{
	}
}
[Token(Token = "0x2000079")]
internal class LocationDownloadQueueItem
{
	[Token(Token = "0x4000229")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly LocationInfo LocationInfo;

	[Token(Token = "0x400022A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly Action<LocationInfo> OnSuccess;

	[Token(Token = "0x400022B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly Action<LocationInfo> OnFail;

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x1420C68", Offset = "0x1420C68", VA = "0x1420C68")]
	public LocationDownloadQueueItem(LocationInfo locationInfo, Action<LocationInfo> onSuccess, Action<LocationInfo> onFail)
	{
	}
}
[Token(Token = "0x200007A")]
public class MultiplayerManager : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x200007B")]
	public enum MODE
	{
		[Token(Token = "0x4000245")]
		Private,
		[Token(Token = "0x4000246")]
		Public
	}

	[Serializable]
	[Token(Token = "0x200007C")]
	private class API_RoomStateData
	{
		[Serializable]
		[Token(Token = "0x200007D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4078", Offset = "0xAE4078")]
		private sealed class <>c
		{
			[Token(Token = "0x4000249")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x400024A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Traveler, bool> <>9__0_0;

			[Token(Token = "0x60002DD")]
			[Address(RVA = "0x167BBB4", Offset = "0x167BBB4", VA = "0x167BBB4")]
			public <>c()
			{
			}

			[Token(Token = "0x60002DE")]
			[Address(RVA = "0x167BBBC", Offset = "0x167BBBC", VA = "0x167BBBC")]
			internal bool <.ctor>b__0_0(Traveler traveler)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4000247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string roomId;

		[Token(Token = "0x4000248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public API_LocationStateData[] locations;

		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xE4B038", Offset = "0xE4B038", VA = "0xE4B038")]
		public API_RoomStateData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007E")]
	public class API_LocationStateData
	{
		[Token(Token = "0x400024B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string locationId;

		[Token(Token = "0x400024C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public API_PlayerData[] players;

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0xE4B8BC", Offset = "0xE4B8BC", VA = "0xE4B8BC")]
		public API_LocationStateData(string locationId, API_PlayerData[] players)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200007F")]
	public class API_UpdateResponseData
	{
		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool isPublic;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public API_LocationStateData[] locations;

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0xE4B92C", Offset = "0xE4B92C", VA = "0xE4B92C")]
		public API_UpdateResponseData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000080")]
	public class API_PlayerData
	{
		[Token(Token = "0x400024F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string pp_url;

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0xE4B8F4", Offset = "0xE4B8F4", VA = "0xE4B8F4")]
		public API_PlayerData(string photon_id, string image_url)
		{
		}
	}

	[Token(Token = "0x2000081")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4088", Offset = "0xAE4088")]
	private sealed class <>c__DisplayClass56_0
	{
		[Token(Token = "0x4000251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string locationId;

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0xE49754", Offset = "0xE49754", VA = "0xE49754")]
		public <>c__DisplayClass56_0()
		{
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0xE4975C", Offset = "0xE4975C", VA = "0xE4975C")]
		internal bool <IsLocationPopulated>b__0(API_LocationStateData location)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000082")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4098", Offset = "0xAE4098")]
	private sealed class <>c__DisplayClass73_0
	{
		[Token(Token = "0x4000252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string photonUserId;

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0xE49780", Offset = "0xE49780", VA = "0xE49780")]
		public <>c__DisplayClass73_0()
		{
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0xE49788", Offset = "0xE49788", VA = "0xE49788")]
		internal bool <GetTravelerByPhotonId>b__0(Traveler traveler)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000083")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40A8", Offset = "0xAE40A8")]
	private sealed class <Connect>d__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x1700006E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002E9")]
			[Address(RVA = "0xE49E90", Offset = "0xE49E90", VA = "0xE49E90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700006F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0xE49ED8", Offset = "0xE49ED8", VA = "0xE49ED8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0xE49A28", Offset = "0xE49A28", VA = "0xE49A28")]
		[DebuggerHidden]
		public <Connect>d__75(int <>1__state)
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0xE49A54", Offset = "0xE49A54", VA = "0xE49A54", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0xE49A58", Offset = "0xE49A58", VA = "0xE49A58", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0xE49E98", Offset = "0xE49E98", VA = "0xE49E98", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40B8", Offset = "0xAE40B8")]
	private sealed class <DoJoinOrCreatePublicRoom>d__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000070")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0xE4A4CC", Offset = "0xE4A4CC", VA = "0xE4A4CC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000071")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0xE4A514", Offset = "0xE4A514", VA = "0xE4A514", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002EC")]
		[Address(RVA = "0xE4A1E8", Offset = "0xE4A1E8", VA = "0xE4A1E8")]
		[DebuggerHidden]
		public <DoJoinOrCreatePublicRoom>d__76(int <>1__state)
		{
		}

		[Token(Token = "0x60002ED")]
		[Address(RVA = "0xE4A214", Offset = "0xE4A214", VA = "0xE4A214", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002EE")]
		[Address(RVA = "0xE4A218", Offset = "0xE4A218", VA = "0xE4A218", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F0")]
		[Address(RVA = "0xE4A4D4", Offset = "0xE4A4D4", VA = "0xE4A4D4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000085")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40C8", Offset = "0xAE40C8")]
	private sealed class <DoJoinPrivateRoom>d__77 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string code;

		[Token(Token = "0x17000072")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0xE4A750", Offset = "0xE4A750", VA = "0xE4A750", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000073")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0xE4A798", Offset = "0xE4A798", VA = "0xE4A798", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0xE4A51C", Offset = "0xE4A51C", VA = "0xE4A51C")]
		[DebuggerHidden]
		public <DoJoinPrivateRoom>d__77(int <>1__state)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0xE4A548", Offset = "0xE4A548", VA = "0xE4A548", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0xE4A54C", Offset = "0xE4A54C", VA = "0xE4A54C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0xE4A758", Offset = "0xE4A758", VA = "0xE4A758", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40D8", Offset = "0xAE40D8")]
	private sealed class <DoCreatePrivateRoom>d__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400025C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string partyCode;

		[Token(Token = "0x17000074")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0xE4A198", Offset = "0xE4A198", VA = "0xE4A198", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000075")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0xE4A1E0", Offset = "0xE4A1E0", VA = "0xE4A1E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0xE49EE0", Offset = "0xE49EE0", VA = "0xE49EE0")]
		[DebuggerHidden]
		public <DoCreatePrivateRoom>d__78(int <>1__state)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0xE49F0C", Offset = "0xE49F0C", VA = "0xE49F0C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0xE49F10", Offset = "0xE49F10", VA = "0xE49F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0xE4A1A0", Offset = "0xE4A1A0", VA = "0xE4A1A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000087")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40E8", Offset = "0xAE40E8")]
	private sealed class <>c__DisplayClass81_0
	{
		[Token(Token = "0x400025D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x60002FE")]
		[Address(RVA = "0xE497C0", Offset = "0xE497C0", VA = "0xE497C0")]
		public <>c__DisplayClass81_0()
		{
		}

		[Token(Token = "0x60002FF")]
		[Address(RVA = "0xE497C8", Offset = "0xE497C8", VA = "0xE497C8")]
		internal bool <IsCodeValid>b__0(KeyValuePair<string, RoomInfo> room)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000088")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE40F8", Offset = "0xAE40F8")]
	private sealed class <API_UpdateServerRoomInfo>d__84 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400025E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400025F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000076")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000303")]
			[Address(RVA = "0xE499D8", Offset = "0xE499D8", VA = "0xE499D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000077")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000305")]
			[Address(RVA = "0xE49A20", Offset = "0xE49A20", VA = "0xE49A20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000300")]
		[Address(RVA = "0xE4981C", Offset = "0xE4981C", VA = "0xE4981C")]
		[DebuggerHidden]
		public <API_UpdateServerRoomInfo>d__84(int <>1__state)
		{
		}

		[Token(Token = "0x6000301")]
		[Address(RVA = "0xE49848", Offset = "0xE49848", VA = "0xE49848", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0xE4984C", Offset = "0xE4984C", VA = "0xE4984C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000304")]
		[Address(RVA = "0xE499E0", Offset = "0xE499E0", VA = "0xE499E0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000089")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4108", Offset = "0xAE4108")]
	private sealed class <DoServerRoomInfoUpdate>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool delay;

		[Token(Token = "0x4000263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private UnityWebRequest <req>5__2;

		[Token(Token = "0x17000078")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000309")]
			[Address(RVA = "0xE4B86C", Offset = "0xE4B86C", VA = "0xE4B86C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000079")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600030B")]
			[Address(RVA = "0xE4B8B4", Offset = "0xE4B8B4", VA = "0xE4B8B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000306")]
		[Address(RVA = "0xE4ABD0", Offset = "0xE4ABD0", VA = "0xE4ABD0")]
		[DebuggerHidden]
		public <DoServerRoomInfoUpdate>d__85(int <>1__state)
		{
		}

		[Token(Token = "0x6000307")]
		[Address(RVA = "0xE4ABFC", Offset = "0xE4ABFC", VA = "0xE4ABFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000308")]
		[Address(RVA = "0xE4AC00", Offset = "0xE4AC00", VA = "0xE4AC00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600030A")]
		[Address(RVA = "0xE4B874", Offset = "0xE4B874", VA = "0xE4B874", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200008A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4118", Offset = "0xAE4118")]
	private sealed class <DoServerGetRoomInfo>d__86 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private UnityWebRequest <req>5__2;

		[Token(Token = "0x1700007A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600030F")]
			[Address(RVA = "0xE4AB80", Offset = "0xE4AB80", VA = "0xE4AB80", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700007B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000311")]
			[Address(RVA = "0xE4ABC8", Offset = "0xE4ABC8", VA = "0xE4ABC8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600030C")]
		[Address(RVA = "0xE4A7A0", Offset = "0xE4A7A0", VA = "0xE4A7A0")]
		[DebuggerHidden]
		public <DoServerGetRoomInfo>d__86(int <>1__state)
		{
		}

		[Token(Token = "0x600030D")]
		[Address(RVA = "0xE4A7CC", Offset = "0xE4A7CC", VA = "0xE4A7CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600030E")]
		[Address(RVA = "0xE4A7D0", Offset = "0xE4A7D0", VA = "0xE4A7D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000310")]
		[Address(RVA = "0xE4AB88", Offset = "0xE4AB88", VA = "0xE4AB88", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400022C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MultiplayerManager _Instance;

	[Token(Token = "0x400022D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static MODE ActiveMode;

	[Token(Token = "0x400022E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5918", Offset = "0xAE5918")]
	private static Traveler <LocalTraveler>k__BackingField;

	[Token(Token = "0x400022F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5928", Offset = "0xAE5928")]
	private static string <CurrentRoomCode>k__BackingField;

	[Token(Token = "0x4000230")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5938", Offset = "0xAE5938")]
	private static bool <Muted>k__BackingField;

	[Token(Token = "0x4000231")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static readonly List<Traveler> Travelers;

	[Token(Token = "0x4000232")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static readonly UnityEvent OnRoomJoined;

	[Token(Token = "0x4000233")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static readonly Dictionary<string, RoomInfo> CachedRoomList;

	[Token(Token = "0x4000234")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static bool AutoJoinPublicOnLocationLoad;

	[Token(Token = "0x4000235")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
	private static bool AutoJoiningPublic;

	[Token(Token = "0x4000236")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
	private static bool ConnectingToServer;

	[Token(Token = "0x4000237")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x43")]
	private static bool ConnectingToRoom;

	[Token(Token = "0x4000238")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private static bool RoomListUpdated;

	[Token(Token = "0x4000239")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static string ConnectingRoomCode;

	[Token(Token = "0x400023A")]
	private const float NotificationDuration = 6f;

	[Token(Token = "0x400023B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private static string LastKnownPhotonUserId;

	[Token(Token = "0x400023C")]
	private const string API_Key = "23e63a58-9a8d-42f9-9463-e1feecfd6a41";

	[Token(Token = "0x400023D")]
	private const string API_Entry_UpdatePublic = "multiplayer/updatePublicRoom";

	[Token(Token = "0x400023E")]
	private const string API_Entry_UpdatePrivate = "multiplayer/updatePrivateRoom";

	[Token(Token = "0x400023F")]
	private const string API_Entry_GetPrivate = "multiplayer/getPrivateRoomStatus";

	[Token(Token = "0x4000240")]
	private const string API_Entry_GetPublic = "multiplayer/getPublicLocationsStatus";

	[Token(Token = "0x4000241")]
	private const string API_Entry_Disconnect = "multiplayer/disconnect";

	[Token(Token = "0x4000242")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private static API_UpdateResponseData LocationsSocialStates;

	[Token(Token = "0x4000243")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Coroutine ServerUpdateCoroutine;

	[Token(Token = "0x17000066")]
	private static MultiplayerManager Instance
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0xFFF934", Offset = "0xFFF934", VA = "0xFFF934")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000067")]
	public static bool Connecting
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0xFFFA68", Offset = "0xFFFA68", VA = "0xFFFA68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000068")]
	public static bool Connected
	{
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0xFFFB00", Offset = "0xFFFB00", VA = "0xFFFB00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000069")]
	public static bool Enabled
	{
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0xFFFB68", Offset = "0xFFFB68", VA = "0xFFFB68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700006A")]
	public static int PlayerCount
	{
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0xFFFBF0", Offset = "0xFFFBF0", VA = "0xFFFBF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700006B")]
	public static Traveler LocalTraveler
	{
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0xFFFCF0", Offset = "0xFFFCF0", VA = "0xFFFCF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBA7C", Offset = "0xAEBA7C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0xFFFC88", Offset = "0xFFFC88", VA = "0xFFFC88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBA6C", Offset = "0xAEBA6C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700006C")]
	public static string CurrentRoomCode
	{
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0xFFFDBC", Offset = "0xFFFDBC", VA = "0xFFFDBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBA9C", Offset = "0xAEBA9C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0xFFFD54", Offset = "0xFFFD54", VA = "0xFFFD54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBA8C", Offset = "0xAEBA8C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700006D")]
	public static bool Muted
	{
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0xFFFE8C", Offset = "0xFFFE8C", VA = "0xFFFE8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBABC", Offset = "0xAEBABC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0xFFFE20", Offset = "0xFFFE20", VA = "0xFFFE20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBAAC", Offset = "0xAEBAAC")]
		private set
		{
		}
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0xFFFEF0", Offset = "0xFFFEF0", VA = "0xFFFEF0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x1000030", Offset = "0x1000030", VA = "0x1000030", Slot = "28")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x10000DC", Offset = "0x10000DC", VA = "0x10000DC")]
	private void Update()
	{
	}

	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x10001AC", Offset = "0x10001AC", VA = "0x10001AC")]
	public static void JoinOrCreatePublic()
	{
	}

	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x1000290", Offset = "0x1000290", VA = "0x1000290")]
	public static void JoinPrivateRoom(string partyCode)
	{
	}

	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x1000390", Offset = "0x1000390", VA = "0x1000390")]
	public static void CreatePrivateRoom([Optional] string partyCode)
	{
	}

	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x1000488", Offset = "0x1000488", VA = "0x1000488")]
	public static void LeavePublicRoom()
	{
	}

	[Token(Token = "0x60002B3")]
	[Address(RVA = "0xFF8868", Offset = "0xFF8868", VA = "0xFF8868")]
	public static void AutoJoin()
	{
	}

	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x1000580", Offset = "0x1000580", VA = "0x1000580")]
	public static Traveler RegisterTraveler(Avatar avatar)
	{
		return null;
	}

	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x10006B8", Offset = "0x10006B8", VA = "0x10006B8")]
	public static void UnRegisterTraveler(Traveler traveler)
	{
	}

	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x100079C", Offset = "0x100079C", VA = "0x100079C")]
	public static void Disconnect()
	{
	}

	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x1000830", Offset = "0x1000830", VA = "0x1000830")]
	public static void Mute(bool v = true)
	{
	}

	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x10008DC", Offset = "0x10008DC", VA = "0x10008DC")]
	public static bool IsLocationPopulated(string locationId)
	{
		return default(bool);
	}

	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x1000A40", Offset = "0x1000A40", VA = "0x1000A40")]
	public static API_PlayerData[] GetUserIdsInLocation(string locationId)
	{
		return null;
	}

	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x1000B68", Offset = "0x1000B68", VA = "0x1000B68", Slot = "45")]
	public override void OnConnectedToMaster()
	{
	}

	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x1000DE4", Offset = "0x1000DE4", VA = "0x1000DE4", Slot = "36")]
	public override void OnJoinedLobby()
	{
	}

	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x1000E54", Offset = "0x1000E54", VA = "0x1000E54", Slot = "40")]
	public override void OnRoomListUpdate(List<RoomInfo> roomList)
	{
	}

	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x100112C", Offset = "0x100112C", VA = "0x100112C", Slot = "41")]
	public override void OnJoinedRoom()
	{
	}

	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x1001A5C", Offset = "0x1001A5C", VA = "0x1001A5C", Slot = "50")]
	public override void OnCustomAuthenticationFailed(string message)
	{
	}

	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x1001C14", Offset = "0x1001C14", VA = "0x1001C14", Slot = "34")]
	public override void OnJoinRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x1001E7C", Offset = "0x1001E7C", VA = "0x1001E7C", Slot = "33")]
	public override void OnCreateRoomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x100215C", Offset = "0x100215C", VA = "0x100215C", Slot = "44")]
	public override void OnJoinRandomFailed(short returnCode, string message)
	{
	}

	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x1002348", Offset = "0x1002348", VA = "0x1002348", Slot = "37")]
	public override void OnLeftLobby()
	{
	}

	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x1002390", Offset = "0x1002390", VA = "0x1002390", Slot = "38")]
	public override void OnDisconnected(DisconnectCause cause)
	{
	}

	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x1002764", Offset = "0x1002764", VA = "0x1002764", Slot = "53")]
	public override void OnErrorInfo(ErrorInfo errorInfo)
	{
	}

	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x10027DC", Offset = "0x10027DC", VA = "0x10027DC")]
	public static bool IsTravelerBlocked(Traveler traveler)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x1002858", Offset = "0x1002858", VA = "0x1002858")]
	public static bool IsTravelerBlocked(string userId)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x10029B4", Offset = "0x10029B4", VA = "0x10029B4")]
	public static bool IsBlockingMe(Traveler traveler)
	{
		return default(bool);
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x1002BDC", Offset = "0x1002BDC", VA = "0x1002BDC")]
	public static void BlockPlayer(bool block, Traveler traveler)
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x1002E54", Offset = "0x1002E54", VA = "0x1002E54")]
	public static Traveler GetTravelerByPhotonId(string photonUserId)
	{
		return null;
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x1002F70", Offset = "0x1002F70", VA = "0x1002F70")]
	public static Transform GetTravelerAvatarHandAnchor(int actorNumber, bool isLeft)
	{
		return null;
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x1003160", Offset = "0x1003160", VA = "0x1003160")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBACC", Offset = "0xAEBACC")]
	private static IEnumerator Connect()
	{
		return null;
	}

	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x1000234", Offset = "0x1000234", VA = "0x1000234")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBB2C", Offset = "0xAEBB2C")]
	private static IEnumerator DoJoinOrCreatePublicRoom()
	{
		return null;
	}

	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x1000324", Offset = "0x1000324", VA = "0x1000324")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBB8C", Offset = "0xAEBB8C")]
	private static IEnumerator DoJoinPrivateRoom(string code)
	{
		return null;
	}

	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x100041C", Offset = "0x100041C", VA = "0x100041C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBBEC", Offset = "0xAEBBEC")]
	private static IEnumerator DoCreatePrivateRoom([Optional] string partyCode)
	{
		return null;
	}

	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x10031BC", Offset = "0x10031BC", VA = "0x10031BC")]
	private static string GetGeneratedCode()
	{
		return null;
	}

	[Token(Token = "0x60002D0")]
	[Address(RVA = "0x100325C", Offset = "0x100325C", VA = "0x100325C")]
	private static string GenerateCode()
	{
		return null;
	}

	[Token(Token = "0x60002D1")]
	[Address(RVA = "0x1003460", Offset = "0x1003460", VA = "0x1003460")]
	private static bool IsCodeValid(string code)
	{
		return default(bool);
	}

	[Token(Token = "0x60002D2")]
	[Address(RVA = "0x100189C", Offset = "0x100189C", VA = "0x100189C")]
	private static void InstantiateAvatar()
	{
	}

	[Token(Token = "0x60002D3")]
	[Address(RVA = "0x1000578", Offset = "0x1000578", VA = "0x1000578")]
	private static void SetPlatformPresence([Optional] string roomCode)
	{
	}

	[Token(Token = "0x60002D4")]
	[Address(RVA = "0x1000080", Offset = "0x1000080", VA = "0x1000080")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBC4C", Offset = "0xAEBC4C")]
	private IEnumerator API_UpdateServerRoomInfo()
	{
		return null;
	}

	[Token(Token = "0x60002D5")]
	[Address(RVA = "0x10019EC", Offset = "0x10019EC", VA = "0x10019EC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBCAC", Offset = "0xAEBCAC")]
	private static IEnumerator DoServerRoomInfoUpdate(bool delay = false)
	{
		return null;
	}

	[Token(Token = "0x60002D6")]
	[Address(RVA = "0x100357C", Offset = "0x100357C", VA = "0x100357C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBD0C", Offset = "0xAEBD0C")]
	private static IEnumerator DoServerGetRoomInfo()
	{
		return null;
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x10025D8", Offset = "0x10025D8", VA = "0x10025D8")]
	private static void DoServerDisconnectUpdate()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x10035D8", Offset = "0x10035D8", VA = "0x10035D8")]
	private static UnityWebRequest GetRequest(string entryName, [Optional] string data)
	{
		return null;
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x1003794", Offset = "0x1003794", VA = "0x1003794")]
	public MultiplayerManager()
	{
	}
}
[Token(Token = "0x200008B")]
public static class ProgressionManager
{
	[Token(Token = "0x200008C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4128", Offset = "0xAE4128")]
	private sealed class <>c__DisplayClass17_0
	{
		[Token(Token = "0x400026E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationInfo info;

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x1675240", Offset = "0x1675240", VA = "0x1675240")]
		public <>c__DisplayClass17_0()
		{
		}

		[Token(Token = "0x6000329")]
		[Address(RVA = "0x1675248", Offset = "0x1675248", VA = "0x1675248")]
		internal bool <PointOfInterestFoundByLocation>b__0(string poiId)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200008D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4138", Offset = "0xAE4138")]
	private sealed class <>c__DisplayClass18_0
	{
		[Token(Token = "0x400026F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationInfo info;

		[Token(Token = "0x600032A")]
		[Address(RVA = "0x1675284", Offset = "0x1675284", VA = "0x1675284")]
		public <>c__DisplayClass18_0()
		{
		}

		[Token(Token = "0x600032B")]
		[Address(RVA = "0x167528C", Offset = "0x167528C", VA = "0x167528C")]
		internal bool <SpotsFoundByLocation>b__0(string spotId)
		{
			return default(bool);
		}
	}

	[Serializable]
	[Token(Token = "0x200008E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4148", Offset = "0xAE4148")]
	private sealed class <>c
	{
		[Token(Token = "0x4000270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LocationData, string> <>9__26_0;

		[Token(Token = "0x600032D")]
		[Address(RVA = "0x1675220", Offset = "0x1675220", VA = "0x1675220")]
		public <>c()
		{
		}

		[Token(Token = "0x600032E")]
		[Address(RVA = "0x1675228", Offset = "0x1675228", VA = "0x1675228")]
		internal string <UpgradeTo110>b__26_0(LocationData deprecatedLocationData)
		{
			return null;
		}
	}

	[Token(Token = "0x200008F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4158", Offset = "0xAE4158")]
	private sealed class <>c__DisplayClass27_0
	{
		[Token(Token = "0x4000272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x600032F")]
		[Address(RVA = "0x16752C8", Offset = "0x16752C8", VA = "0x16752C8")]
		public <>c__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6000330")]
		[Address(RVA = "0x16752D0", Offset = "0x16752D0", VA = "0x16752D0")]
		internal bool <IsLocationDownloaded>b__0(string cached)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000267")]
	public const string FIRST_STEPS = "FIRST_STEPS";

	[Token(Token = "0x4000268")]
	public const string TELEPORTATION_STEP = "TELEPORTATION_STEP";

	[Token(Token = "0x4000269")]
	public const string PHOTO_STEP = "PHOTO_STEP";

	[Token(Token = "0x400026A")]
	public const string JOYSTICK_MOVE = "JOYSTICK_MOVE";

	[Token(Token = "0x400026B")]
	public const string OUTSIDE_WALKABLE = "OUTSIDE_WALKABLE";

	[Token(Token = "0x400026C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly string ProgressionJsonPath;

	[Token(Token = "0x400026D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static ProgressionData Progression;

	[Token(Token = "0x1700007C")]
	public static int PointsOfInterestFoundCount
	{
		[Token(Token = "0x6000318")]
		[Address(RVA = "0x1389E58", Offset = "0x1389E58", VA = "0x1389E58")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6000312")]
	[Address(RVA = "0x1389664", Offset = "0x1389664", VA = "0x1389664")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000313")]
	[Address(RVA = "0x1389778", Offset = "0x1389778", VA = "0x1389778")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000314")]
	[Address(RVA = "0x13899B8", Offset = "0x13899B8", VA = "0x13899B8")]
	private static void Save()
	{
	}

	[Token(Token = "0x6000315")]
	[Address(RVA = "0x1389A40", Offset = "0x1389A40", VA = "0x1389A40")]
	public static void SavePointOfInterestFound(string id)
	{
	}

	[Token(Token = "0x6000316")]
	[Address(RVA = "0x1389C7C", Offset = "0x1389C7C", VA = "0x1389C7C")]
	public static bool WasPointOfInterestFound(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000317")]
	[Address(RVA = "0x1389D48", Offset = "0x1389D48", VA = "0x1389D48")]
	public static void ClearAnyPOIFound()
	{
	}

	[Token(Token = "0x6000319")]
	[Address(RVA = "0x1389F08", Offset = "0x1389F08", VA = "0x1389F08")]
	public static void SaveSpotFound(LocationInfo info, int index)
	{
	}

	[Token(Token = "0x600031A")]
	[Address(RVA = "0x138A460", Offset = "0x138A460", VA = "0x138A460")]
	public static bool WasSpotFound(LocationInfo info, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600031B")]
	[Address(RVA = "0x138A554", Offset = "0x138A554", VA = "0x138A554")]
	public static int PointOfInterestFoundByLocation(LocationInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x600031C")]
	[Address(RVA = "0x138A690", Offset = "0x138A690", VA = "0x138A690")]
	public static int SpotsFoundByLocation(LocationInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x600031D")]
	[Address(RVA = "0x138A7CC", Offset = "0x138A7CC", VA = "0x138A7CC")]
	public static bool IsTutorialStepCompleted(string key)
	{
		return default(bool);
	}

	[Token(Token = "0x600031E")]
	[Address(RVA = "0x138A90C", Offset = "0x138A90C", VA = "0x138A90C")]
	public static bool WillPlayTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x600031F")]
	[Address(RVA = "0x138A9D0", Offset = "0x138A9D0", VA = "0x138A9D0")]
	public static void SaveTutorialStepComplete(string id)
	{
	}

	[Token(Token = "0x6000320")]
	[Address(RVA = "0x138AC0C", Offset = "0x138AC0C", VA = "0x138AC0C")]
	public static void SaveAllTutorialStepsComplete()
	{
	}

	[Token(Token = "0x6000321")]
	[Address(RVA = "0x138ACB4", Offset = "0x138ACB4", VA = "0x138ACB4")]
	public static string[] GetLocationDownloaded()
	{
		return null;
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x138AE10", Offset = "0x138AE10", VA = "0x138AE10")]
	public static void SaveLocationDownloaded(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x6000323")]
	[Address(RVA = "0x138B054", Offset = "0x138B054", VA = "0x138B054")]
	public static void RemoveLocationDownloaded(string id)
	{
	}

	[Token(Token = "0x6000324")]
	[Address(RVA = "0x138B210", Offset = "0x138B210", VA = "0x138B210")]
	public static void UpgradeTo110()
	{
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x138B460", Offset = "0x138B460", VA = "0x138B460")]
	public static bool IsLocationDownloaded(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x6000326")]
	[Address(RVA = "0x138B5C4", Offset = "0x138B5C4", VA = "0x138B5C4")]
	public static bool IsShowingBadge(string locationId)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x2000090")]
internal class ProgressionData
{
	[Token(Token = "0x4000273")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public LocationData[] LocationsCached;

	[Token(Token = "0x4000274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string[] LocationsDownloaded;

	[Token(Token = "0x4000275")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string[] POIsFound;

	[Token(Token = "0x4000276")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public string[] SpotsFound;

	[Token(Token = "0x4000277")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string[] TutorialStepsComplete;

	[Token(Token = "0x4000278")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public string[] LocationsBadgeHide;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x138965C", Offset = "0x138965C", VA = "0x138965C")]
	public ProgressionData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000091")]
internal class LocationData
{
	[Token(Token = "0x4000279")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string Id;

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int DiskSpace;

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x1420C60", Offset = "0x1420C60", VA = "0x1420C60")]
	public LocationData()
	{
	}
}
[Token(Token = "0x2000092")]
public class RPCManager : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static RPCManager Instance;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Rock[] Rocks;

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x138BC6C", Offset = "0x138BC6C", VA = "0x138BC6C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000334")]
	[Address(RVA = "0x138BDB8", Offset = "0x138BDB8", VA = "0x138BDB8")]
	public static void RPC(string methodName, RpcTarget target, params object[] parameters)
	{
	}

	[Token(Token = "0x6000335")]
	[Address(RVA = "0x138BEDC", Offset = "0x138BEDC", VA = "0x138BEDC")]
	public RPCManager()
	{
	}
}
[Token(Token = "0x2000093")]
public class TutorialManagerVR : MonoBehaviour
{
	[Token(Token = "0x2000094")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4168", Offset = "0xAE4168")]
	private sealed class <FirstSteps>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400029D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400029E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TutorialManagerVR <>4__this;

		[Token(Token = "0x400029F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <sentenceLength>5__2;

		[Token(Token = "0x40002A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <flyStartTime>5__3;

		[Token(Token = "0x40002A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <compassMessageVoiceTime>5__4;

		[Token(Token = "0x40002A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <compassMessageNotifTime>5__5;

		[Token(Token = "0x40002A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool <notifAdded>5__6;

		[Token(Token = "0x40002A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float <findTheOtherTwoMessageTime>5__7;

		[Token(Token = "0x40002A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float <watchFlyStartTime>5__8;

		[Token(Token = "0x40002A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private float <menuMessageTime>5__9;

		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private float <compassNotifTime>5__10;

		[Token(Token = "0x17000080")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1679DB8", Offset = "0x1679DB8", VA = "0x1679DB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000081")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000357")]
			[Address(RVA = "0x1679E00", Offset = "0x1679E00", VA = "0x1679E00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x1678344", Offset = "0x1678344", VA = "0x1678344")]
		[DebuggerHidden]
		public <FirstSteps>d__46(int <>1__state)
		{
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x1678370", Offset = "0x1678370", VA = "0x1678370", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000354")]
		[Address(RVA = "0x1678374", Offset = "0x1678374", VA = "0x1678374", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000356")]
		[Address(RVA = "0x1679DC0", Offset = "0x1679DC0", VA = "0x1679DC0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000095")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4178", Offset = "0xAE4178")]
	private sealed class <PauseIfPoiOrTalking>d__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x17000082")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x1679F00", Offset = "0x1679F00", VA = "0x1679F00", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000083")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x1679F48", Offset = "0x1679F48", VA = "0x1679F48", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000358")]
		[Address(RVA = "0x1679E08", Offset = "0x1679E08", VA = "0x1679E08")]
		[DebuggerHidden]
		public <PauseIfPoiOrTalking>d__48(int <>1__state)
		{
		}

		[Token(Token = "0x6000359")]
		[Address(RVA = "0x1679E34", Offset = "0x1679E34", VA = "0x1679E34", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600035A")]
		[Address(RVA = "0x1679E38", Offset = "0x1679E38", VA = "0x1679E38", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600035C")]
		[Address(RVA = "0x1679F08", Offset = "0x1679F08", VA = "0x1679F08", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000096")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4188", Offset = "0xAE4188")]
	private sealed class <TeleportationStep>d__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TutorialManagerVR <>4__this;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <sentenceEndTime>5__2;

		[Token(Token = "0x17000084")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x167ABDC", Offset = "0x167ABDC", VA = "0x167ABDC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000085")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000363")]
			[Address(RVA = "0x167AC24", Offset = "0x167AC24", VA = "0x167AC24", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600035E")]
		[Address(RVA = "0x167A5FC", Offset = "0x167A5FC", VA = "0x167A5FC")]
		[DebuggerHidden]
		public <TeleportationStep>d__49(int <>1__state)
		{
		}

		[Token(Token = "0x600035F")]
		[Address(RVA = "0x167A628", Offset = "0x167A628", VA = "0x167A628", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000360")]
		[Address(RVA = "0x167A62C", Offset = "0x167A62C", VA = "0x167A62C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000362")]
		[Address(RVA = "0x167ABE4", Offset = "0x167ABE4", VA = "0x167ABE4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000097")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4198", Offset = "0xAE4198")]
	private sealed class <PhotoSharingStep>d__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40002AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40002B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TutorialManagerVR <>4__this;

		[Token(Token = "0x40002B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <animationStartTime>5__2;

		[Token(Token = "0x40002B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private float <waitForSaveStartTime>5__3;

		[Token(Token = "0x17000086")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x167A5AC", Offset = "0x167A5AC", VA = "0x167A5AC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000087")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000369")]
			[Address(RVA = "0x167A5F4", Offset = "0x167A5F4", VA = "0x167A5F4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000364")]
		[Address(RVA = "0x1679F50", Offset = "0x1679F50", VA = "0x1679F50")]
		[DebuggerHidden]
		public <PhotoSharingStep>d__50(int <>1__state)
		{
		}

		[Token(Token = "0x6000365")]
		[Address(RVA = "0x1679F7C", Offset = "0x1679F7C", VA = "0x1679F7C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000366")]
		[Address(RVA = "0x1679F80", Offset = "0x1679F80", VA = "0x1679F80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000368")]
		[Address(RVA = "0x167A5B4", Offset = "0x167A5B4", VA = "0x167A5B4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000098")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE41A8", Offset = "0xAE41A8")]
	private sealed class <>c__DisplayClass51_0
	{
		[Token(Token = "0x40002B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Transform Item;

		[Token(Token = "0x40002B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 finalRotation;

		[Token(Token = "0x600036A")]
		[Address(RVA = "0x1678314", Offset = "0x1678314", VA = "0x1678314")]
		public <>c__DisplayClass51_0()
		{
		}

		[Token(Token = "0x600036B")]
		[Address(RVA = "0x167831C", Offset = "0x167831C", VA = "0x167831C")]
		internal void <AnimateItem>b__0()
		{
		}
	}

	[Token(Token = "0x400027D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool Running;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	public static bool PauseFirstPoiAnimation;

	[Token(Token = "0x400027F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
	public static bool WaitToShowPoiCollectButton;

	[Token(Token = "0x4000280")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3")]
	public static bool CollectPoiButtonPressed;

	[Token(Token = "0x4000281")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static bool HasTeleported;

	[Token(Token = "0x4000282")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5")]
	public static bool HasSavedPhoto;

	[Token(Token = "0x4000283")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6")]
	public static bool HasDiscardedPhoto;

	[Token(Token = "0x4000284")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7")]
	public static bool CompassGrabbed;

	[Token(Token = "0x4000285")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static bool ShowMarkerArrows;

	[Token(Token = "0x4000286")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9")]
	public static bool DisableWatchSecondaryButtons;

	[Token(Token = "0x4000287")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA")]
	public static bool DisableJoysticks;

	[Token(Token = "0x4000288")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB")]
	public static bool WaitingForWatchMenuButtonPress;

	[Token(Token = "0x4000289")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static bool _HasCreatedPhoto;

	[Token(Token = "0x400028A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	private static bool VisitingDefaultLocationFirstTimeEver;

	[Token(Token = "0x400028B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static TutorialManagerVR Instance;

	[Token(Token = "0x400028C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static Narrator Narrator;

	[Token(Token = "0x400028D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrinkPlayerVR Player;

	[Token(Token = "0x400028E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TutorialItemShineEffect ShineFX;

	[Token(Token = "0x400028F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Compass;

	[Token(Token = "0x4000290")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Watch;

	[Token(Token = "0x4000291")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform PhotoHands;

	[Token(Token = "0x4000292")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5948", Offset = "0xAE5948")]
	private float <SkippingProgress>k__BackingField;

	[Token(Token = "0x4000293")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Coroutine TutorialCoroutine;

	[Token(Token = "0x4000294")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float CompassMoveRatio;

	[Token(Token = "0x4000295")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float WatchMoveRatio;

	[Token(Token = "0x4000296")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private EventInstance _AchievementAudio;

	[Token(Token = "0x4000297")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool PlayerGrabbedCompassEarly;

	[Token(Token = "0x4000298")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Transform CompassTransformTo;

	[Token(Token = "0x4000299")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Transform WatchTransformTo;

	[Token(Token = "0x400029A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int JoysticksPressedCount;

	[Token(Token = "0x400029B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float JoysticksPressedStartTime;

	[Token(Token = "0x1700007D")]
	public static bool HasCreatedPhoto
	{
		[Token(Token = "0x6000337")]
		[Address(RVA = "0x139D8E0", Offset = "0x139D8E0", VA = "0x139D8E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000336")]
		[Address(RVA = "0x139D848", Offset = "0x139D848", VA = "0x139D848")]
		set
		{
		}
	}

	[Token(Token = "0x1700007E")]
	public float SkippingProgress
	{
		[Token(Token = "0x6000338")]
		[Address(RVA = "0x139D92C", Offset = "0x139D92C", VA = "0x139D92C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBF9C", Offset = "0xAEBF9C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000339")]
		[Address(RVA = "0x139D934", Offset = "0x139D934", VA = "0x139D934")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEBFAC", Offset = "0xAEBFAC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700007F")]
	private EventInstance AchievementAudio
	{
		[Token(Token = "0x600033A")]
		[Address(RVA = "0x139D93C", Offset = "0x139D93C", VA = "0x139D93C")]
		get
		{
			return default(EventInstance);
		}
	}

	[Token(Token = "0x600033B")]
	[Address(RVA = "0x139DA0C", Offset = "0x139DA0C", VA = "0x139DA0C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600033C")]
	[Address(RVA = "0x139DB64", Offset = "0x139DB64", VA = "0x139DB64")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600033D")]
	[Address(RVA = "0x139DBC8", Offset = "0x139DBC8", VA = "0x139DBC8")]
	private void Update()
	{
	}

	[Token(Token = "0x600033E")]
	[Address(RVA = "0x139E21C", Offset = "0x139E21C", VA = "0x139E21C")]
	private void Skip()
	{
	}

	[Token(Token = "0x600033F")]
	[Address(RVA = "0x139E584", Offset = "0x139E584", VA = "0x139E584")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000340")]
	[Address(RVA = "0x139E694", Offset = "0x139E694", VA = "0x139E694")]
	public void OnIntroEnded()
	{
	}

	[Token(Token = "0x6000341")]
	[Address(RVA = "0x139E7A0", Offset = "0x139E7A0", VA = "0x139E7A0")]
	private void OnNarrationEnd()
	{
	}

	[Token(Token = "0x6000342")]
	[Address(RVA = "0x139EA34", Offset = "0x139EA34", VA = "0x139EA34")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEBFBC", Offset = "0xAEBFBC")]
	private IEnumerator FirstSteps()
	{
		return null;
	}

	[Token(Token = "0x6000343")]
	[Address(RVA = "0x139EB78", Offset = "0x139EB78", VA = "0x139EB78")]
	private void OnPlayerTryToGrabCompassEarly()
	{
	}

	[Token(Token = "0x6000344")]
	[Address(RVA = "0x139EC74", Offset = "0x139EC74", VA = "0x139EC74")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC01C", Offset = "0xAEC01C")]
	private static IEnumerator PauseIfPoiOrTalking()
	{
		return null;
	}

	[Token(Token = "0x6000345")]
	[Address(RVA = "0x139EAA0", Offset = "0x139EAA0", VA = "0x139EAA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC07C", Offset = "0xAEC07C")]
	private IEnumerator TeleportationStep()
	{
		return null;
	}

	[Token(Token = "0x6000346")]
	[Address(RVA = "0x139EB0C", Offset = "0x139EB0C", VA = "0x139EB0C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC0DC", Offset = "0xAEC0DC")]
	private IEnumerator PhotoSharingStep()
	{
		return null;
	}

	[Token(Token = "0x6000347")]
	[Address(RVA = "0x139ECD0", Offset = "0x139ECD0", VA = "0x139ECD0")]
	private void AnimateItem(Transform Item, float rotationOffset = 150f)
	{
	}

	[Token(Token = "0x6000348")]
	[Address(RVA = "0x139EFC0", Offset = "0x139EFC0", VA = "0x139EFC0")]
	private static void ShowItemFacing(Transform Item, float distance = 0.75f)
	{
	}

	[Token(Token = "0x6000349")]
	[Address(RVA = "0x139F1B4", Offset = "0x139F1B4", VA = "0x139F1B4")]
	public static void LeavingLocation()
	{
	}

	[Token(Token = "0x600034A")]
	[Address(RVA = "0x139F3B8", Offset = "0x139F3B8", VA = "0x139F3B8")]
	public void OnJoystickPressed()
	{
	}

	[Token(Token = "0x600034B")]
	[Address(RVA = "0x139F3C8", Offset = "0x139F3C8", VA = "0x139F3C8")]
	public void OnJoystickReleased()
	{
	}

	[Token(Token = "0x600034C")]
	[Address(RVA = "0x139F3D8", Offset = "0x139F3D8", VA = "0x139F3D8")]
	public TutorialManagerVR()
	{
	}

	[Token(Token = "0x600034D")]
	[Address(RVA = "0x139F3E8", Offset = "0x139F3E8", VA = "0x139F3E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC13C", Offset = "0xAEC13C")]
	private float <FirstSteps>b__46_0()
	{
		return default(float);
	}

	[Token(Token = "0x600034E")]
	[Address(RVA = "0x139F3F0", Offset = "0x139F3F0", VA = "0x139F3F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC14C", Offset = "0xAEC14C")]
	private void <FirstSteps>b__46_1(float x)
	{
	}

	[Token(Token = "0x600034F")]
	[Address(RVA = "0x139F3F8", Offset = "0x139F3F8", VA = "0x139F3F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC15C", Offset = "0xAEC15C")]
	private void <FirstSteps>b__46_2()
	{
	}

	[Token(Token = "0x6000350")]
	[Address(RVA = "0x139F4F4", Offset = "0x139F4F4", VA = "0x139F4F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC16C", Offset = "0xAEC16C")]
	private float <FirstSteps>b__46_3()
	{
		return default(float);
	}

	[Token(Token = "0x6000351")]
	[Address(RVA = "0x139F4FC", Offset = "0x139F4FC", VA = "0x139F4FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC17C", Offset = "0xAEC17C")]
	private void <FirstSteps>b__46_4(float x)
	{
	}
}
[Token(Token = "0x2000099")]
[ExecuteInEditMode]
public class Marker : PointableObject
{
	[Token(Token = "0x40002B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool ClampScale;

	[Token(Token = "0x40002B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector2 ClampValues;

	[Token(Token = "0x40002B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Marker AnimatingAfterSelect;

	[Token(Token = "0x40002B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public MeshRenderer IconRenderer;

	[Token(Token = "0x40002B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Disc TimerImage;

	[Token(Token = "0x40002BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public StudioEventEmitter OverAudio;

	[Token(Token = "0x40002BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SphereCollider Collider;

	[Token(Token = "0x40002BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Transform TutorialArrow;

	[Token(Token = "0x40002BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	internal readonly MarkerEvent OnPointingEnter;

	[Token(Token = "0x40002BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	internal readonly MarkerEvent OnPointingExit;

	[Token(Token = "0x40002BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	internal readonly MarkerEvent OnPointingStay;

	[Token(Token = "0x40002C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal readonly MarkerEvent OnClicked;

	[Token(Token = "0x40002C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal bool PreventHiding;

	[Token(Token = "0x40002C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x81")]
	private bool _Disabled;

	[Token(Token = "0x40002C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	protected float PointedStartTime;

	[Token(Token = "0x40002C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private float Scale;

	[Token(Token = "0x40002C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private float IconDefaultScale;

	[Token(Token = "0x40002C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private float CircleDefaultScale;

	[Token(Token = "0x40002C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float SphereColliderDefaultRadius;

	[Token(Token = "0x40002C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool AutoFillingCircle;

	[Token(Token = "0x40002C9")]
	private const float SelectDelay = 1.2f;

	[Token(Token = "0x40002CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5958", Offset = "0xAE5958")]
	private bool <Found>k__BackingField;

	[Token(Token = "0x40002CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private SpotController _SpotController;

	[Token(Token = "0x17000088")]
	public static bool ANIMATING_SELECT
	{
		[Token(Token = "0x600036C")]
		[Address(RVA = "0xFF9ADC", Offset = "0xFF9ADC", VA = "0xFF9ADC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000089")]
	internal bool Disabled
	{
		[Token(Token = "0x600036E")]
		[Address(RVA = "0xFF9E18", Offset = "0xFF9E18", VA = "0xFF9E18")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600036D")]
		[Address(RVA = "0xFF9B60", Offset = "0xFF9B60", VA = "0xFF9B60")]
		set
		{
		}
	}

	[Token(Token = "0x1700008A")]
	public Texture MainTexture
	{
		[Token(Token = "0x600036F")]
		[Address(RVA = "0xFF9E20", Offset = "0xFF9E20", VA = "0xFF9E20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008B")]
	public float SelectionProgress
	{
		[Token(Token = "0x6000370")]
		[Address(RVA = "0xFF9E4C", Offset = "0xFF9E4C", VA = "0xFF9E4C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700008C")]
	public virtual bool Found
	{
		[Token(Token = "0x6000371")]
		[Address(RVA = "0xFF9E78", Offset = "0xFF9E78", VA = "0xFF9E78", Slot = "7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC2CC", Offset = "0xAEC2CC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000372")]
		[Address(RVA = "0xFF9E80", Offset = "0xFF9E80", VA = "0xFF9E80", Slot = "8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC2DC", Offset = "0xAEC2DC")]
		protected set
		{
		}
	}

	[Token(Token = "0x1700008D")]
	public float ViewDot
	{
		[Token(Token = "0x6000373")]
		[Address(RVA = "0xFF9E8C", Offset = "0xFF9E8C", VA = "0xFF9E8C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700008E")]
	protected SpotController SpotController
	{
		[Token(Token = "0x6000374")]
		[Address(RVA = "0xFF9F48", Offset = "0xFF9F48", VA = "0xFF9F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000375")]
	[Address(RVA = "0xFF9FF8", Offset = "0xFF9FF8", VA = "0xFF9FF8", Slot = "9")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000376")]
	[Address(RVA = "0xFFA13C", Offset = "0xFFA13C", VA = "0xFFA13C", Slot = "10")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x6000377")]
	[Address(RVA = "0xFFA414", Offset = "0xFFA414", VA = "0xFFA414", Slot = "11")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x6000378")]
	[Address(RVA = "0xFFA4D0", Offset = "0xFFA4D0", VA = "0xFFA4D0", Slot = "12")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000379")]
	[Address(RVA = "0xFFA4D8", Offset = "0xFFA4D8", VA = "0xFFA4D8", Slot = "13")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600037A")]
	[Address(RVA = "0xFFA938", Offset = "0xFFA938", VA = "0xFFA938")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600037B")]
	[Address(RVA = "0xFFA274", Offset = "0xFFA274", VA = "0xFFA274")]
	private void PopIn()
	{
	}

	[Token(Token = "0x600037C")]
	[Address(RVA = "0xFF9B8C", Offset = "0xFF9B8C", VA = "0xFF9B8C")]
	private void ToggleTutorialArrow()
	{
	}

	[Token(Token = "0x600037D")]
	[Address(RVA = "0xFFA984", Offset = "0xFFA984", VA = "0xFFA984", Slot = "14")]
	protected virtual void Select()
	{
	}

	[Token(Token = "0x600037E")]
	[Address(RVA = "0xFFAA00", Offset = "0xFFAA00", VA = "0xFFAA00", Slot = "15")]
	protected virtual void InvokeOnPointingStay()
	{
	}

	[Token(Token = "0x600037F")]
	[Address(RVA = "0xFFAA58", Offset = "0xFFAA58", VA = "0xFFAA58", Slot = "4")]
	public override void PointerEnter()
	{
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0xFFAB50", Offset = "0xFFAB50", VA = "0xFFAB50", Slot = "5")]
	public override void PointerExit()
	{
	}

	[Token(Token = "0x6000381")]
	[Address(RVA = "0xFFABD0", Offset = "0xFFABD0", VA = "0xFFABD0", Slot = "6")]
	public override void PointerClick()
	{
	}

	[Token(Token = "0x6000382")]
	[Address(RVA = "0xFFADA4", Offset = "0xFFADA4", VA = "0xFFADA4")]
	public Marker()
	{
	}

	[Token(Token = "0x6000383")]
	[Address(RVA = "0xFFAEAC", Offset = "0xFFAEAC", VA = "0xFFAEAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC2EC", Offset = "0xAEC2EC")]
	private float <PointerClick>b__51_0()
	{
		return default(float);
	}

	[Token(Token = "0x6000384")]
	[Address(RVA = "0xFFAEC8", Offset = "0xFFAEC8", VA = "0xFFAEC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC2FC", Offset = "0xAEC2FC")]
	private void <PointerClick>b__51_1(float x)
	{
	}

	[Token(Token = "0x6000385")]
	[Address(RVA = "0xFFAEE4", Offset = "0xFFAEE4", VA = "0xFFAEE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC30C", Offset = "0xAEC30C")]
	private void <PointerClick>b__51_2()
	{
	}
}
[Token(Token = "0x200009A")]
public class MarkerEvent : UnityEvent<Marker>
{
	[Token(Token = "0x6000386")]
	[Address(RVA = "0xFFAE60", Offset = "0xFFAE60", VA = "0xFFAE60")]
	public MarkerEvent()
	{
	}
}
[Token(Token = "0x200009B")]
[ExecuteInEditMode]
public class POIMarker : Marker
{
	[Serializable]
	[Token(Token = "0x200009C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE41D8", Offset = "0xAE41D8")]
	private sealed class <>c
	{
		[Token(Token = "0x40002D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40002D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<PointOfInterestData, ValueDropdownItem> <>9__5_0;

		[Token(Token = "0x40002DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Action<Texture, bool> <>9__20_0;

		[Token(Token = "0x6000395")]
		[Address(RVA = "0x1672478", Offset = "0x1672478", VA = "0x1672478")]
		public <>c()
		{
		}

		[Token(Token = "0x6000396")]
		[Address(RVA = "0x1672480", Offset = "0x1672480", VA = "0x1672480")]
		internal ValueDropdownItem <GetPoiIds>b__5_0(PointOfInterestData x)
		{
			return default(ValueDropdownItem);
		}

		[Token(Token = "0x6000397")]
		[Address(RVA = "0x16724D4", Offset = "0x16724D4", VA = "0x16724D4")]
		internal void <Select>b__20_0(Texture texture, bool noInternet)
		{
		}
	}

	[Token(Token = "0x200009D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE41E8", Offset = "0xAE41E8")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x40002DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Vector3 euler;

		[Token(Token = "0x40002DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public POIMarker <>4__this;

		[Token(Token = "0x6000398")]
		[Address(RVA = "0x16724D8", Offset = "0x16724D8", VA = "0x16724D8")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6000399")]
		[Address(RVA = "0x16724E0", Offset = "0x16724E0", VA = "0x16724E0")]
		internal void <Select>b__1()
		{
		}
	}

	[Token(Token = "0x200009E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE41F8", Offset = "0xAE41F8")]
	private sealed class <>c__DisplayClass21_0
	{
		[Token(Token = "0x40002DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool v;

		[Token(Token = "0x40002DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public POIMarker <>4__this;

		[Token(Token = "0x600039A")]
		[Address(RVA = "0x16726FC", Offset = "0x16726FC", VA = "0x16726FC")]
		public <>c__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600039B")]
		[Address(RVA = "0x1672704", Offset = "0x1672704", VA = "0x1672704")]
		internal void <ShowHighlightCircle>b__2()
		{
		}
	}

	[Token(Token = "0x200009F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4208", Offset = "0xAE4208")]
	private sealed class <>c__DisplayClass21_1
	{
		[Token(Token = "0x40002DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Disc circle;

		[Token(Token = "0x600039C")]
		[Address(RVA = "0x1672740", Offset = "0x1672740", VA = "0x1672740")]
		public <>c__DisplayClass21_1()
		{
		}

		[Token(Token = "0x600039D")]
		[Address(RVA = "0x1672748", Offset = "0x1672748", VA = "0x1672748")]
		internal float <ShowHighlightCircle>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x600039E")]
		[Address(RVA = "0x1672774", Offset = "0x1672774", VA = "0x1672774")]
		internal void <ShowHighlightCircle>b__1(float x)
		{
		}
	}

	[Token(Token = "0x40002CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	internal readonly POIMarkerEvent OnTrigger;

	[Token(Token = "0x40002CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public Texture FoundTexture;

	[Token(Token = "0x40002CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public Texture NotFoundTexture;

	[Token(Token = "0x40002CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public StudioEventEmitter FoundAudio;

	[Token(Token = "0x40002D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public string PointOfInterestId;

	[Token(Token = "0x40002D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[HideInInspector]
	public GameObject HighlightCircle;

	[Token(Token = "0x40002D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject ObjectHighlight;

	[Token(Token = "0x40002D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public bool ObjectHighlightStaysInPlace;

	[Token(Token = "0x40002D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private PointOfInterestData _PointOfInterestData;

	[Token(Token = "0x40002D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Tween HighlightCircleTween;

	[Token(Token = "0x40002D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int ZTest;

	[Token(Token = "0x40002D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private POIPopupObjectHighlight POIPopupObjectHighlight;

	[Token(Token = "0x1700008F")]
	public PointOfInterestData PointOfInterestData
	{
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x1086B6C", Offset = "0x1086B6C", VA = "0x1086B6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000387")]
	[Address(RVA = "0x108698C", Offset = "0x108698C", VA = "0x108698C")]
	private static IEnumerable GetPoiIds()
	{
		return null;
	}

	[Token(Token = "0x6000389")]
	[Address(RVA = "0x1086C6C", Offset = "0x1086C6C", VA = "0x1086C6C", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600038A")]
	[Address(RVA = "0x1086E68", Offset = "0x1086E68", VA = "0x1086E68", Slot = "10")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x600038B")]
	[Address(RVA = "0x1086F70", Offset = "0x1086F70", VA = "0x1086F70", Slot = "13")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600038C")]
	[Address(RVA = "0x108708C", Offset = "0x108708C", VA = "0x108708C", Slot = "11")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600038D")]
	[Address(RVA = "0x10870B4", Offset = "0x10870B4", VA = "0x10870B4")]
	public void HideHighlightCircle()
	{
	}

	[Token(Token = "0x600038E")]
	[Address(RVA = "0x1087414", Offset = "0x1087414", VA = "0x1087414", Slot = "14")]
	protected override void Select()
	{
	}

	[Token(Token = "0x600038F")]
	[Address(RVA = "0x10870BC", Offset = "0x10870BC", VA = "0x10870BC")]
	private void ShowHighlightCircle(bool v = true)
	{
	}

	[Token(Token = "0x6000390")]
	[Address(RVA = "0x108773C", Offset = "0x108773C", VA = "0x108773C", Slot = "15")]
	protected override void InvokeOnPointingStay()
	{
	}

	[Token(Token = "0x6000391")]
	[Address(RVA = "0x1087794", Offset = "0x1087794", VA = "0x1087794")]
	public POIMarker()
	{
	}

	[Token(Token = "0x6000393")]
	[Address(RVA = "0x10878AC", Offset = "0x10878AC", VA = "0x10878AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC31C", Offset = "0xAEC31C")]
	private void <Select>b__20_2()
	{
	}
}
[Token(Token = "0x20000A0")]
public class POIMarkerEvent : UnityEvent<POIMarker, bool, POIPopupObjectHighlight>
{
	[Token(Token = "0x600039F")]
	[Address(RVA = "0x10877F4", Offset = "0x10877F4", VA = "0x10877F4")]
	public POIMarkerEvent()
	{
	}
}
[Token(Token = "0x20000A1")]
public class TeleportMarker : Marker
{
	[Token(Token = "0x20000A2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4218", Offset = "0xAE4218")]
	private sealed class <>c__DisplayClass20_0
	{
		[Token(Token = "0x40002EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TeleportMarker <>4__this;

		[Token(Token = "0x40002ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Vector3 euler;

		[Token(Token = "0x40002EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public DOGetter<float> <>9__1;

		[Token(Token = "0x40002EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public DOSetter<float> <>9__2;

		[Token(Token = "0x40002F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TweenCallback <>9__3;

		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x1677060", Offset = "0x1677060", VA = "0x1677060")]
		public <>c__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60003AC")]
		[Address(RVA = "0x1677068", Offset = "0x1677068", VA = "0x1677068")]
		internal void <Select>b__0()
		{
		}

		[Token(Token = "0x60003AD")]
		[Address(RVA = "0x1677398", Offset = "0x1677398", VA = "0x1677398")]
		internal float <Select>b__1()
		{
			return default(float);
		}

		[Token(Token = "0x60003AE")]
		[Address(RVA = "0x16773B4", Offset = "0x16773B4", VA = "0x16773B4")]
		internal void <Select>b__2(float x)
		{
		}

		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x16773D0", Offset = "0x16773D0", VA = "0x16773D0")]
		internal void <Select>b__3()
		{
		}
	}

	[Token(Token = "0x40002E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Texture NotFoundTexture;

	[Token(Token = "0x40002E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public Texture FoundTexture;

	[Token(Token = "0x40002E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Texture WalkingToTexture;

	[Token(Token = "0x40002E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public MeshRenderer LabelBackground;

	[Token(Token = "0x40002E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TextMeshPro Label;

	[Token(Token = "0x40002E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public StudioEventEmitter SelectedAudio;

	[Token(Token = "0x40002E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public StudioEventEmitter FoundAudio;

	[Token(Token = "0x40002E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public BoxCollider TextCollider;

	[Token(Token = "0x40002E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	internal readonly TeleportMarkerEvent OnTrigger;

	[Token(Token = "0x40002E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private float LabelDefaultY;

	[Token(Token = "0x40002EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	private float LabelBackgroundDefaultAlpha;

	[Token(Token = "0x40002EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private float AlphaMultiplier;

	[Token(Token = "0x17000090")]
	public SpotController SpotTo
	{
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x1395E5C", Offset = "0x1395E5C", VA = "0x1395E5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000091")]
	public bool KeepPlayerCurrentOrientation
	{
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x1395EB8", Offset = "0x1395EB8", VA = "0x1395EB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003A2")]
	[Address(RVA = "0x1395F14", Offset = "0x1395F14", VA = "0x1395F14", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60003A3")]
	[Address(RVA = "0x1395FA4", Offset = "0x1395FA4", VA = "0x1395FA4", Slot = "10")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60003A4")]
	[Address(RVA = "0x13961F0", Offset = "0x13961F0", VA = "0x13961F0", Slot = "11")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60003A5")]
	[Address(RVA = "0x1396224", Offset = "0x1396224", VA = "0x1396224", Slot = "13")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60003A6")]
	[Address(RVA = "0x13964E4", Offset = "0x13964E4", VA = "0x13964E4", Slot = "14")]
	protected override void Select()
	{
	}

	[Token(Token = "0x60003A7")]
	[Address(RVA = "0x13962AC", Offset = "0x13962AC", VA = "0x13962AC")]
	private void SetAlpha()
	{
	}

	[Token(Token = "0x60003A8")]
	[Address(RVA = "0x1396864", Offset = "0x1396864", VA = "0x1396864", Slot = "4")]
	public override void PointerEnter()
	{
	}

	[Token(Token = "0x60003A9")]
	[Address(RVA = "0x139690C", Offset = "0x139690C", VA = "0x139690C", Slot = "5")]
	public override void PointerExit()
	{
	}

	[Token(Token = "0x60003AA")]
	[Address(RVA = "0x13969A4", Offset = "0x13969A4", VA = "0x13969A4")]
	public TeleportMarker()
	{
	}
}
[Token(Token = "0x20000A3")]
public class TeleportMarkerEvent : UnityEvent<TeleportMarker>
{
	[Token(Token = "0x60003B0")]
	[Address(RVA = "0x1396A0C", Offset = "0x1396A0C", VA = "0x1396A0C")]
	public TeleportMarkerEvent()
	{
	}
}
[Token(Token = "0x20000A4")]
[ExecuteInEditMode]
public class Teleporter : MonoBehaviour
{
	[Token(Token = "0x40002F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool KeepPlayerCurrentOrientation;

	[Token(Token = "0x40002F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal SpotController SpotFrom;

	[Token(Token = "0x40002F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SpotController SpotTo;

	[Token(Token = "0x60003B1")]
	[Address(RVA = "0x1396A58", Offset = "0x1396A58", VA = "0x1396A58")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B2")]
	[Address(RVA = "0x1396AF0", Offset = "0x1396AF0", VA = "0x1396AF0")]
	public Teleporter()
	{
	}
}
[Token(Token = "0x20000A5")]
public class Avatar : MonoBehaviourPunCallbacks, IPunObservable
{
	[Token(Token = "0x20000A6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4238", Offset = "0xAE4238")]
	private sealed class <Start>d__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Avatar <>4__this;

		[Token(Token = "0x17000095")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60003C7")]
			[Address(RVA = "0xE3F6F0", Offset = "0xE3F6F0", VA = "0xE3F6F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000096")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60003C9")]
			[Address(RVA = "0xE3F738", Offset = "0xE3F738", VA = "0xE3F738", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0xE3F478", Offset = "0xE3F478", VA = "0xE3F478")]
		[DebuggerHidden]
		public <Start>d__15(int <>1__state)
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0xE3F4A4", Offset = "0xE3F4A4", VA = "0xE3F4A4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0xE3F4A8", Offset = "0xE3F4A8", VA = "0xE3F4A8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0xE3F6F8", Offset = "0xE3F6F8", VA = "0xE3F6F8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40002F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform LeftHandAnchor;

	[Token(Token = "0x40002F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform RightHandAnchor;

	[Token(Token = "0x40002F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform UsernameField;

	[Token(Token = "0x40002F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform Voice;

	[Token(Token = "0x40002F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject IdleBadge;

	[Token(Token = "0x40002F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Recorder Recorder;

	[Token(Token = "0x40002FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Traveler Traveler;

	[Token(Token = "0x40002FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private TextMeshPro UsernameText;

	[Token(Token = "0x40002FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Speaker Speaker;

	[Token(Token = "0x40002FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 PreviousHeadPosition;

	[Token(Token = "0x40002FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private float NotMovingStartTime;

	[Token(Token = "0x40002FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 UsernamePosition;

	[Token(Token = "0x4000300")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private MeshRenderer IdleBadgeRenderer;

	[Token(Token = "0x4000301")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private MetaAvatar MetaAvatar;

	[Token(Token = "0x17000092")]
	public Vector3 HeadPosition
	{
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x1195048", Offset = "0x1195048", VA = "0x1195048")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x17000093")]
	public bool IsTalking
	{
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x1195128", Offset = "0x1195128", VA = "0x1195128")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000094")]
	private bool IsNotMoving
	{
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x1194DEC", Offset = "0x1194DEC", VA = "0x1194DEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003B3")]
	[Address(RVA = "0x1193E24", Offset = "0x1193E24", VA = "0x1193E24")]
	private void Awake()
	{
	}

	[Token(Token = "0x60003B4")]
	[Address(RVA = "0x1193ED8", Offset = "0x1193ED8", VA = "0x1193ED8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC32C", Offset = "0xAEC32C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60003B5")]
	[Address(RVA = "0x1193F44", Offset = "0x1193F44", VA = "0x1193F44")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60003B6")]
	[Address(RVA = "0x1193FBC", Offset = "0x1193FBC", VA = "0x1193FBC")]
	private void Update()
	{
	}

	[Token(Token = "0x60003B7")]
	[Address(RVA = "0x1194ECC", Offset = "0x1194ECC", VA = "0x1194ECC")]
	private void UpdateUsernamePosition()
	{
	}

	[Token(Token = "0x60003BB")]
	[Address(RVA = "0x1195144", Offset = "0x1195144", VA = "0x1195144")]
	private void InstantiateMetaAvatar(string metaId, bool isLocal)
	{
	}

	[Token(Token = "0x60003BC")]
	[Address(RVA = "0x11952B8", Offset = "0x11952B8", VA = "0x11952B8")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC38C", Offset = "0xAEC38C")]
	private void RPC_RequestAvatarPosition(int actorNumber)
	{
	}

	[Token(Token = "0x60003BD")]
	[Address(RVA = "0x11954F0", Offset = "0x11954F0", VA = "0x11954F0")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC3C4", Offset = "0xAEC3C4")]
	private void RPC_ReceiveAvatarPosition(Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x60003BE")]
	[Address(RVA = "0x1195580", Offset = "0x1195580", VA = "0x1195580")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC3FC", Offset = "0xAEC3FC")]
	private void RPC_ReceiveMetaAvatarStreamData(byte[] data, double time)
	{
	}

	[Token(Token = "0x60003BF")]
	[Address(RVA = "0x1195638", Offset = "0x1195638", VA = "0x1195638", Slot = "41")]
	public override void OnJoinedRoom()
	{
	}

	[Token(Token = "0x60003C0")]
	[Address(RVA = "0x119579C", Offset = "0x119579C", VA = "0x119579C", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x60003C1")]
	[Address(RVA = "0x119595C", Offset = "0x119595C", VA = "0x119595C", Slot = "43")]
	public override void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x60003C2")]
	[Address(RVA = "0x1195B1C", Offset = "0x1195B1C", VA = "0x1195B1C", Slot = "54")]
	public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
	{
	}

	[Token(Token = "0x60003C3")]
	[Address(RVA = "0x1195B20", Offset = "0x1195B20", VA = "0x1195B20")]
	public Avatar()
	{
	}
}
[Token(Token = "0x20000A7")]
public class BrinkAvatar : MonoBehaviourPun
{
	[Token(Token = "0x4000305")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform Head;

	[Token(Token = "0x4000306")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform HandRight;

	[Token(Token = "0x4000307")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform HeadLeft;

	[Token(Token = "0x60003CA")]
	[Address(RVA = "0x1196BC4", Offset = "0x1196BC4", VA = "0x1196BC4")]
	private void Update()
	{
	}

	[Token(Token = "0x60003CB")]
	[Address(RVA = "0x1196E1C", Offset = "0x1196E1C", VA = "0x1196E1C")]
	public BrinkAvatar()
	{
	}
}
[Token(Token = "0x20000A8")]
public class Traveler
{
	[StructLayout(3)]
	[Token(Token = "0x20000A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4248", Offset = "0xAE4248")]
	private struct <DownloadProfileImage>d__48 : IAsyncStateMachine
	{
		[Token(Token = "0x4000314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int <>1__state;

		[Token(Token = "0x4000315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Token(Token = "0x4000316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Traveler <>4__this;

		[Token(Token = "0x4000317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private UnityWebRequest <r>5__2;

		[Token(Token = "0x4000318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter <>u__1;

		[Token(Token = "0x60003E9")]
		[Address(RVA = "0x1677CB4", Offset = "0x1677CB4", VA = "0x1677CB4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60003EA")]
		[Address(RVA = "0x16781E8", Offset = "0x16781E8", VA = "0x16781E8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000308")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly Avatar Avatar;

	[Token(Token = "0x4000309")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Texture2D Image;

	[Token(Token = "0x400030A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string _PlatformUserId;

	[Token(Token = "0x400030B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string _PlatformUsername;

	[Token(Token = "0x400030C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string _PlatformUserImageUrl;

	[Token(Token = "0x400030D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool _Idle;

	[Token(Token = "0x400030E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	private bool _Muted;

	[Token(Token = "0x400030F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	private bool _IsTalking;

	[Token(Token = "0x4000310")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	private bool _NightMode;

	[Token(Token = "0x4000311")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private string _CurrentLocation;

	[Token(Token = "0x4000312")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string _CurrentSpot;

	[Token(Token = "0x4000313")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string[] _BlockingUserIds;

	[Token(Token = "0x17000097")]
	public PhotonView PhotonView
	{
		[Token(Token = "0x60003CC")]
		[Address(RVA = "0x139A678", Offset = "0x139A678", VA = "0x139A678")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000098")]
	public string PhotonUserId
	{
		[Token(Token = "0x60003CD")]
		[Address(RVA = "0x139A70C", Offset = "0x139A70C", VA = "0x139A70C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000099")]
	public string PlatformUserId
	{
		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x139A9BC", Offset = "0x139A9BC", VA = "0x139A9BC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003CE")]
		[Address(RVA = "0x139A7B0", Offset = "0x139A7B0", VA = "0x139A7B0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009A")]
	public string PlatformUsername
	{
		[Token(Token = "0x60003D1")]
		[Address(RVA = "0x139AC0C", Offset = "0x139AC0C", VA = "0x139AC0C")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003D0")]
		[Address(RVA = "0x139AA94", Offset = "0x139AA94", VA = "0x139AA94")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009B")]
	public bool Idle
	{
		[Token(Token = "0x60003D3")]
		[Address(RVA = "0x139ADD8", Offset = "0x139ADD8", VA = "0x139ADD8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D2")]
		[Address(RVA = "0x139ACE4", Offset = "0x139ACE4", VA = "0x139ACE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	public bool Muted
	{
		[Token(Token = "0x60003D5")]
		[Address(RVA = "0x139AFA8", Offset = "0x139AFA8", VA = "0x139AFA8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D4")]
		[Address(RVA = "0x139AEB4", Offset = "0x139AEB4", VA = "0x139AEB4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	public bool IsTalking
	{
		[Token(Token = "0x60003D7")]
		[Address(RVA = "0x139B178", Offset = "0x139B178", VA = "0x139B178")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D6")]
		[Address(RVA = "0x139B084", Offset = "0x139B084", VA = "0x139B084")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	public bool NightMode
	{
		[Token(Token = "0x60003D9")]
		[Address(RVA = "0x139B3BC", Offset = "0x139B3BC", VA = "0x139B3BC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60003D8")]
		[Address(RVA = "0x139B254", Offset = "0x139B254", VA = "0x139B254")]
		private set
		{
		}
	}

	[Token(Token = "0x1700009F")]
	public string PlatformUserImageUrl
	{
		[Token(Token = "0x60003DB")]
		[Address(RVA = "0x139B574", Offset = "0x139B574", VA = "0x139B574")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DA")]
		[Address(RVA = "0x139B498", Offset = "0x139B498", VA = "0x139B498")]
		set
		{
		}
	}

	[Token(Token = "0x170000A0")]
	public string CurrentLocation
	{
		[Token(Token = "0x60003DD")]
		[Address(RVA = "0x139B728", Offset = "0x139B728", VA = "0x139B728")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DC")]
		[Address(RVA = "0x139B64C", Offset = "0x139B64C", VA = "0x139B64C")]
		private set
		{
		}
	}

	[Token(Token = "0x170000A1")]
	private string CurrentSpot
	{
		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x139B8DC", Offset = "0x139B8DC", VA = "0x139B8DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x139B800", Offset = "0x139B800", VA = "0x139B800")]
		set
		{
		}
	}

	[Token(Token = "0x170000A2")]
	public string[] BlockingUserIds
	{
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x139BA68", Offset = "0x139BA68", VA = "0x139BA68")]
		get
		{
			return null;
		}
		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x139B9B4", Offset = "0x139B9B4", VA = "0x139B9B4")]
		set
		{
		}
	}

	[Token(Token = "0x170000A3")]
	public bool IsMe
	{
		[Token(Token = "0x60003E7")]
		[Address(RVA = "0x139BA48", Offset = "0x139BA48", VA = "0x139BA48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A4")]
	public bool InSameSpot
	{
		[Token(Token = "0x60003E8")]
		[Address(RVA = "0x139BF84", Offset = "0x139BF84", VA = "0x139BF84")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003E2")]
	[Address(RVA = "0x139BBE0", Offset = "0x139BBE0", VA = "0x139BBE0")]
	public Traveler(Avatar avatar)
	{
	}

	[Token(Token = "0x60003E3")]
	[Address(RVA = "0x139BD78", Offset = "0x139BD78", VA = "0x139BD78")]
	public void UpdateLocalState()
	{
	}

	[Token(Token = "0x60003E4")]
	[Address(RVA = "0x139BCB4", Offset = "0x139BCB4", VA = "0x139BCB4")]
	[AttributeAttribute(Name = "AsyncStateMachineAttribute", RVA = "0xAEC484", Offset = "0xAEC484")]
	private void DownloadProfileImage()
	{
	}

	[Token(Token = "0x60003E5")]
	[Address(RVA = "0x139A88C", Offset = "0x139A88C", VA = "0x139A88C")]
	private static void UpdateCustomProperty(string key, object value)
	{
	}

	[Token(Token = "0x60003E6")]
	private T GetCustomProperty<T>(string key)
	{
		return (T)null;
	}
}
[Token(Token = "0x20000AA")]
[ExecuteInEditMode]
public class NetworkSyncedObject : MonoBehaviourPunCallbacks
{
	[Token(Token = "0x4000319")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int ViewID;

	[Token(Token = "0x170000A5")]
	protected static bool Connected
	{
		[Token(Token = "0x60003EB")]
		[Address(RVA = "0x1009760", Offset = "0x1009760", VA = "0x1009760")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000A6")]
	protected static bool IsMasterClient
	{
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x10097B8", Offset = "0x10097B8", VA = "0x10097B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003ED")]
	[Address(RVA = "0x1009814", Offset = "0x1009814", VA = "0x1009814", Slot = "28")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x60003EE")]
	[Address(RVA = "0x100981C", Offset = "0x100981C", VA = "0x100981C", Slot = "54")]
	protected virtual void Start()
	{
	}

	[Token(Token = "0x60003EF")]
	[Address(RVA = "0x100991C", Offset = "0x100991C", VA = "0x100991C")]
	public void AssignViewID()
	{
	}

	[Token(Token = "0x60003F0")]
	[Address(RVA = "0x1009920", Offset = "0x1009920", VA = "0x1009920")]
	public NetworkSyncedObject()
	{
	}
}
[Token(Token = "0x20000AB")]
public sealed class SyncedGrabbable : Grabbable, IInRoomCallbacks
{
	[Token(Token = "0x400031A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x121")]
	private bool _EnableSyncing;

	[Token(Token = "0x400031B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private PhotonView PhotonView;

	[Token(Token = "0x400031C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private PhotonTransformView PhotonTransformView;

	[Token(Token = "0x400031D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Transform OriginalParent;

	[Token(Token = "0x400031E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private bool TransferingOwnershipToMe;

	[Token(Token = "0x170000A7")]
	public bool EnableSyncing
	{
		[Token(Token = "0x60003F1")]
		[Address(RVA = "0x13948A0", Offset = "0x13948A0", VA = "0x13948A0")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x60003F2")]
		[Address(RVA = "0x13948A8", Offset = "0x13948A8", VA = "0x13948A8")]
		set
		{
		}
	}

	[Token(Token = "0x170000A8")]
	private bool ActiveSyncing
	{
		[Token(Token = "0x60003F3")]
		[Address(RVA = "0x1394948", Offset = "0x1394948", VA = "0x1394948")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60003F4")]
	[Address(RVA = "0x13949C4", Offset = "0x13949C4", VA = "0x13949C4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60003F5")]
	[Address(RVA = "0x1394A08", Offset = "0x1394A08", VA = "0x1394A08")]
	private void Start()
	{
	}

	[Token(Token = "0x60003F6")]
	[Address(RVA = "0x1394FC0", Offset = "0x1394FC0", VA = "0x1394FC0")]
	private void Update()
	{
	}

	[Token(Token = "0x60003F7")]
	[Address(RVA = "0x139540C", Offset = "0x139540C", VA = "0x139540C", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x60003F8")]
	[Address(RVA = "0x13955FC", Offset = "0x13955FC", VA = "0x13955FC")]
	private void OnGrab(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x60003F9")]
	[Address(RVA = "0x1395820", Offset = "0x1395820", VA = "0x1395820")]
	private void OnRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x139593C", Offset = "0x139593C", VA = "0x139593C")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC4F4", Offset = "0xAEC4F4")]
	[PunRPC]
	private void RPC_InitializePosition(Vector3 position, Vector3 rotation)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x13959CC", Offset = "0x13959CC", VA = "0x13959CC")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC52C", Offset = "0xAEC52C")]
	[PunRPC]
	private void RPC_OnGrabbed(int actorNumber, bool isLeft)
	{
	}

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x1395AE0", Offset = "0x1395AE0", VA = "0x1395AE0")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC564", Offset = "0xAEC564")]
	[PunRPC]
	private void RPC_UpdateHandAnchorOffset(Vector3 anchorPosition, Quaternion anchorRotation)
	{
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x1395C34", Offset = "0x1395C34", VA = "0x1395C34")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC59C", Offset = "0xAEC59C")]
	private void RPC_OnReleased()
	{
	}

	[Token(Token = "0x60003FE")]
	[Address(RVA = "0x1395C6C", Offset = "0x1395C6C", VA = "0x1395C6C", Slot = "15")]
	public void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x60003FF")]
	[Address(RVA = "0x1395E3C", Offset = "0x1395E3C", VA = "0x1395E3C", Slot = "16")]
	public void OnPlayerLeftRoom(Player otherPlayer)
	{
	}

	[Token(Token = "0x6000400")]
	[Address(RVA = "0x1395E40", Offset = "0x1395E40", VA = "0x1395E40", Slot = "17")]
	public void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
	{
	}

	[Token(Token = "0x6000401")]
	[Address(RVA = "0x1395E44", Offset = "0x1395E44", VA = "0x1395E44", Slot = "18")]
	public void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
	{
	}

	[Token(Token = "0x6000402")]
	[Address(RVA = "0x1395E48", Offset = "0x1395E48", VA = "0x1395E48", Slot = "19")]
	public void OnMasterClientSwitched(Player newMasterClient)
	{
	}

	[Token(Token = "0x6000403")]
	[Address(RVA = "0x1395E4C", Offset = "0x1395E4C", VA = "0x1395E4C")]
	public SyncedGrabbable()
	{
	}
}
[Token(Token = "0x20000AC")]
public class Airplane : MonoBehaviour
{
	[Token(Token = "0x20000AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4268", Offset = "0xAE4268")]
	private sealed class <BlinkingLights>d__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Airplane <>4__this;

		[Token(Token = "0x170000A9")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600040F")]
			[Address(RVA = "0xE3E858", Offset = "0xE3E858", VA = "0xE3E858", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AA")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000411")]
			[Address(RVA = "0xE3E8A0", Offset = "0xE3E8A0", VA = "0xE3E8A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600040C")]
		[Address(RVA = "0xE3E5E0", Offset = "0xE3E5E0", VA = "0xE3E5E0")]
		[DebuggerHidden]
		public <BlinkingLights>d__23(int <>1__state)
		{
		}

		[Token(Token = "0x600040D")]
		[Address(RVA = "0xE3E60C", Offset = "0xE3E60C", VA = "0xE3E60C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600040E")]
		[Address(RVA = "0xE3E610", Offset = "0xE3E610", VA = "0xE3E610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000410")]
		[Address(RVA = "0xE3E860", Offset = "0xE3E860", VA = "0xE3E860", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4278", Offset = "0xAE4278")]
	private sealed class <FadeOutQuads>d__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Airplane <>4__this;

		[Token(Token = "0x170000AB")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000415")]
			[Address(RVA = "0xE3E9E0", Offset = "0xE3E9E0", VA = "0xE3E9E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AC")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000417")]
			[Address(RVA = "0xE3EA28", Offset = "0xE3EA28", VA = "0xE3EA28", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000412")]
		[Address(RVA = "0xE3E8A8", Offset = "0xE3E8A8", VA = "0xE3E8A8")]
		[DebuggerHidden]
		public <FadeOutQuads>d__24(int <>1__state)
		{
		}

		[Token(Token = "0x6000413")]
		[Address(RVA = "0xE3E8D4", Offset = "0xE3E8D4", VA = "0xE3E8D4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000414")]
		[Address(RVA = "0xE3E8D8", Offset = "0xE3E8D8", VA = "0xE3E8D8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000416")]
		[Address(RVA = "0xE3E9E8", Offset = "0xE3E9E8", VA = "0xE3E9E8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400031F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AirplaneTrailSpawner AirplaneTrailSpawner;

	[Token(Token = "0x4000320")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform Plane;

	[Token(Token = "0x4000321")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool SpotLightsOn;

	[Token(Token = "0x4000322")]
	private const float MaxDistFromPlayer = 9500f;

	[Token(Token = "0x4000323")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly AirplaneQuad[] TrailQuads;

	[Token(Token = "0x4000324")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Material TrailMat;

	[Token(Token = "0x4000325")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Renderer[] LightRenderers;

	[Token(Token = "0x4000326")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int QuadCounter;

	[Token(Token = "0x4000327")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private Vector2 QuadSize;

	[Token(Token = "0x4000328")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	[HideInInspector]
	public int Index;

	[Token(Token = "0x4000329")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public bool DoubleTrail;

	[Token(Token = "0x400032A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[HideInInspector]
	public float TimeElapsed;

	[Token(Token = "0x400032B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Quaternion StartRot;

	[Token(Token = "0x400032C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public Vector3 StartPos;

	[Token(Token = "0x400032D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float ExpansionRate;

	[Token(Token = "0x400032E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float MaxStretchDistance;

	[Token(Token = "0x400032F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float QuadWidth;

	[Token(Token = "0x4000330")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float Speed;

	[Token(Token = "0x4000331")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public bool OutOfBounds;

	[Token(Token = "0x6000404")]
	[Address(RVA = "0x118D13C", Offset = "0x118D13C", VA = "0x118D13C")]
	public void StartAirplane()
	{
	}

	[Token(Token = "0x6000405")]
	[Address(RVA = "0x118D1D0", Offset = "0x118D1D0", VA = "0x118D1D0")]
	private void SpawnQuads()
	{
	}

	[Token(Token = "0x6000406")]
	[Address(RVA = "0x118D248", Offset = "0x118D248", VA = "0x118D248")]
	private void GenerateQuad(Vector3 topCornerPos, bool bottom = false)
	{
	}

	[Token(Token = "0x6000407")]
	[Address(RVA = "0x118D4B4", Offset = "0x118D4B4", VA = "0x118D4B4")]
	private void Update()
	{
	}

	[Token(Token = "0x6000408")]
	[Address(RVA = "0x118D6A0", Offset = "0x118D6A0", VA = "0x118D6A0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC5D4", Offset = "0xAEC5D4")]
	private IEnumerator BlinkingLights()
	{
		return null;
	}

	[Token(Token = "0x6000409")]
	[Address(RVA = "0x118D70C", Offset = "0x118D70C", VA = "0x118D70C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC634", Offset = "0xAEC634")]
	private IEnumerator FadeOutQuads()
	{
		return null;
	}

	[Token(Token = "0x600040A")]
	[Address(RVA = "0x118D778", Offset = "0x118D778", VA = "0x118D778")]
	private void RemoveQuads()
	{
	}

	[Token(Token = "0x600040B")]
	[Address(RVA = "0x118D854", Offset = "0x118D854", VA = "0x118D854")]
	public Airplane()
	{
	}
}
[Token(Token = "0x20000AF")]
public class AirplaneQuad : MonoBehaviour
{
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4288", Offset = "0xAE4288")]
	private sealed class <CreateQuad>d__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400034B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400034C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400034D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AirplaneQuad <>4__this;

		[Token(Token = "0x400034E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Vector3 corner;

		[Token(Token = "0x170000AD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000424")]
			[Address(RVA = "0xE3EE3C", Offset = "0xE3EE3C", VA = "0xE3EE3C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000AE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000426")]
			[Address(RVA = "0xE3EE84", Offset = "0xE3EE84", VA = "0xE3EE84", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000421")]
		[Address(RVA = "0xE3EA30", Offset = "0xE3EA30", VA = "0xE3EA30")]
		[DebuggerHidden]
		public <CreateQuad>d__22(int <>1__state)
		{
		}

		[Token(Token = "0x6000422")]
		[Address(RVA = "0xE3EA5C", Offset = "0xE3EA5C", VA = "0xE3EA5C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000423")]
		[Address(RVA = "0xE3EA60", Offset = "0xE3EA60", VA = "0xE3EA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000425")]
		[Address(RVA = "0xE3EE44", Offset = "0xE3EE44", VA = "0xE3EE44", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000338")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Mesh Mesh;

	[Token(Token = "0x4000339")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Vector3[] MeshOrig;

	[Token(Token = "0x400033A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private MeshRenderer MeshRenderer;

	[Token(Token = "0x400033B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material _mat;

	[Token(Token = "0x400033C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly int _PanSpeed;

	[Token(Token = "0x400033D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private bool QuadReady;

	[Token(Token = "0x400033E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float NewZPos;

	[Token(Token = "0x400033F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private bool FastFwd;

	[Token(Token = "0x4000340")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	private bool StopExpansion;

	[Token(Token = "0x4000341")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Vector3 StartPos;

	[Token(Token = "0x4000342")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[HideInInspector]
	public Material Mat;

	[Token(Token = "0x4000343")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[HideInInspector]
	public Vector2 QuadStartSize;

	[Token(Token = "0x4000344")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	public int QuadNum;

	[Token(Token = "0x4000345")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[HideInInspector]
	public float ExpansionRate;

	[Token(Token = "0x4000346")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public float MaxStretchDist;

	[Token(Token = "0x4000347")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[HideInInspector]
	public float Speed;

	[Token(Token = "0x4000348")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public bool BottomQuad;

	[Token(Token = "0x4000349")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	[HideInInspector]
	public bool DoubleTrail;

	[Token(Token = "0x400034A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float TimeElapsed;

	[Token(Token = "0x6000418")]
	[Address(RVA = "0x118D8CC", Offset = "0x118D8CC", VA = "0x118D8CC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000419")]
	[Address(RVA = "0x118D930", Offset = "0x118D930", VA = "0x118D930")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600041A")]
	[Address(RVA = "0x118D9FC", Offset = "0x118D9FC", VA = "0x118D9FC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600041B")]
	[Address(RVA = "0x118D96C", Offset = "0x118D96C", VA = "0x118D96C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC734", Offset = "0xAEC734")]
	private IEnumerator CreateQuad(Vector3 corner)
	{
		return null;
	}

	[Token(Token = "0x600041C")]
	[Address(RVA = "0x118DA90", Offset = "0x118DA90", VA = "0x118DA90")]
	private void ExpandQuad(bool fastfwd = false)
	{
	}

	[Token(Token = "0x600041D")]
	[Address(RVA = "0x118DC00", Offset = "0x118DC00", VA = "0x118DC00")]
	private void StretchQuad(bool fastFwd = false)
	{
	}

	[Token(Token = "0x600041E")]
	[Address(RVA = "0x118DD44", Offset = "0x118DD44", VA = "0x118DD44")]
	private void Update()
	{
	}

	[Token(Token = "0x600041F")]
	[Address(RVA = "0x118DD8C", Offset = "0x118DD8C", VA = "0x118DD8C")]
	public void Fade()
	{
	}

	[Token(Token = "0x6000420")]
	[Address(RVA = "0x118DE40", Offset = "0x118DE40", VA = "0x118DE40")]
	public AirplaneQuad()
	{
	}
}
[Token(Token = "0x20000B1")]
public class AirplaneTrailSpawner : NetworkSyncedObject
{
	[Token(Token = "0x400034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject AirplanePrefab;

	[Token(Token = "0x4000350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5AF8", Offset = "0xAE5AF8")]
	public float SpawnRange;

	[Token(Token = "0x4000351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector2 Speed;

	[Token(Token = "0x4000352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public Vector2 QuadWidth;

	[Token(Token = "0x4000353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector2 ExpansionRate;

	[Token(Token = "0x4000354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public Vector2 MaxStretchDistance;

	[Token(Token = "0x4000355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Airplane[] Airplanes;

	[Token(Token = "0x4000356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float StartTime;

	[Token(Token = "0x4000357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool DoubleTrail;

	[Token(Token = "0x4000358")]
	private const float SpawnHeightMin = 2000f;

	[Token(Token = "0x4000359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x65")]
	private bool _Hidden;

	[Token(Token = "0x170000AF")]
	private bool IsPrivateRoom
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x118DEB8", Offset = "0x118DEB8", VA = "0x118DEB8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000B0")]
	public bool Hidden
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x118F81C", Offset = "0x118F81C", VA = "0x118F81C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x118F810", Offset = "0x118F810", VA = "0x118F810")]
		set
		{
		}
	}

	[Token(Token = "0x6000428")]
	[Address(RVA = "0x118DF24", Offset = "0x118DF24", VA = "0x118DF24", Slot = "28")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x6000429")]
	[Address(RVA = "0x118E378", Offset = "0x118E378", VA = "0x118E378", Slot = "54")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600042A")]
	[Address(RVA = "0x118EDB8", Offset = "0x118EDB8", VA = "0x118EDB8")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC7E4", Offset = "0xAEC7E4")]
	[PunRPC]
	private void RPC_SendPrivatePlayerAirplaneArray(int actorNum)
	{
	}

	[Token(Token = "0x600042B")]
	[Address(RVA = "0x118EB40", Offset = "0x118EB40", VA = "0x118EB40")]
	private string FindPrivateRoomMasterClientLocation()
	{
		return null;
	}

	[Token(Token = "0x600042C")]
	[Address(RVA = "0x118F434", Offset = "0x118F434", VA = "0x118F434", Slot = "42")]
	public override void OnPlayerEnteredRoom(Player newPlayer)
	{
	}

	[Token(Token = "0x600042D")]
	[Address(RVA = "0x118EE68", Offset = "0x118EE68", VA = "0x118EE68")]
	private void ResetAndSpawnTrails(Player newPlayer)
	{
	}

	[Token(Token = "0x600042E")]
	[Address(RVA = "0x118F48C", Offset = "0x118F48C", VA = "0x118F48C")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC81C", Offset = "0xAEC81C")]
	private void RPC_ResetAirplaneArray(int numOfAirplanes, bool doubleTrail)
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x118F5A0", Offset = "0x118F5A0", VA = "0x118F5A0")]
	[PunRPC]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC854", Offset = "0xAEC854")]
	private void RPC_SpawnAirplane(Quaternion rot, Vector3 pos, bool doubleTrail, float timeElapsed, float maxStretch, float speed, float quadWidth, float expansionRate, int index, bool outOfBounds)
	{
	}

	[Token(Token = "0x6000430")]
	[Address(RVA = "0x118E064", Offset = "0x118E064", VA = "0x118E064")]
	private Airplane SpawnAirplane(int num, bool outOfBounds = false)
	{
		return null;
	}

	[Token(Token = "0x6000433")]
	[Address(RVA = "0x118ED8C", Offset = "0x118ED8C", VA = "0x118ED8C")]
	private float CalculateSecondsPassed()
	{
		return default(float);
	}

	[Token(Token = "0x6000434")]
	[Address(RVA = "0x118F74C", Offset = "0x118F74C", VA = "0x118F74C")]
	private void EnsureHidden()
	{
	}

	[Token(Token = "0x6000435")]
	[Address(RVA = "0x118F824", Offset = "0x118F824", VA = "0x118F824")]
	public void UpdateNightMode(bool on = false)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x118FAFC", Offset = "0x118FAFC", VA = "0x118FAFC")]
	public AirplaneTrailSpawner()
	{
	}
}
[Token(Token = "0x20000B2")]
[ExecuteInEditMode]
public class DustParticles : MonoBehaviour
{
	[Token(Token = "0x400035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color Color;

	[Token(Token = "0x400035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int Count;

	[Token(Token = "0x400035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private ParticleSystem ParticleSystem;

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x15D6250", Offset = "0x15D6250", VA = "0x15D6250")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x15D62A4", Offset = "0x15D62A4", VA = "0x15D62A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x15D63E8", Offset = "0x15D63E8", VA = "0x15D63E8")]
	private void Update()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x15D62A8", Offset = "0x15D62A8", VA = "0x15D62A8")]
	private void SetValues()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x15D65D0", Offset = "0x15D65D0", VA = "0x15D65D0")]
	public DustParticles()
	{
	}
}
[Token(Token = "0x20000B3")]
public class GrabbaleImpactAudio : MonoBehaviour
{
	[Token(Token = "0x20000B4")]
	public enum ROCK_SIZE
	{
		[Token(Token = "0x4000369")]
		Small,
		[Token(Token = "0x400036A")]
		Medium,
		[Token(Token = "0x400036B")]
		Big
	}

	[Token(Token = "0x400035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool OverrideRockSize;

	[Token(Token = "0x400035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public ROCK_SIZE Size;

	[Token(Token = "0x400035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool PreventNextCollisionAudio;

	[Token(Token = "0x4000360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private EventInstance Instance;

	[Token(Token = "0x4000361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float SpawnTime;

	[Token(Token = "0x4000362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float ImpactAudioTime;

	[Token(Token = "0x4000363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Grabbable Grabbable;

	[Token(Token = "0x4000364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PLAYBACK_STATE PlaybackSate;

	[Token(Token = "0x4000365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float Volume;

	[Token(Token = "0x4000366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private bool CollidingWithGround;

	[Token(Token = "0x4000367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5B18", Offset = "0xAE5B18")]
	private float <BodyVolume>k__BackingField;

	[Token(Token = "0x170000B1")]
	public float BodyVolume
	{
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x15DC758", Offset = "0x15DC758", VA = "0x15DC758")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC88C", Offset = "0xAEC88C")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x15DC760", Offset = "0x15DC760", VA = "0x15DC760")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC89C", Offset = "0xAEC89C")]
		set
		{
		}
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x15DC768", Offset = "0x15DC768", VA = "0x15DC768")]
	private void Start()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x15DC7C8", Offset = "0x15DC7C8", VA = "0x15DC7C8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x15DC984", Offset = "0x15DC984", VA = "0x15DC984")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x15DCC00", Offset = "0x15DCC00", VA = "0x15DCC00")]
	private void CreateInstance()
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x15DCCEC", Offset = "0x15DCCEC", VA = "0x15DCCEC")]
	public GrabbaleImpactAudio()
	{
	}
}
[Token(Token = "0x20000B5")]
[SelectionBase]
[ExecuteInEditMode]
public class Plant : AddressablePrefab
{
	[Serializable]
	[Token(Token = "0x20000B6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE42E0", Offset = "0xAE42E0")]
	private sealed class <>c
	{
		[Token(Token = "0x4000370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Plant, IEnumerable<MeshRenderer>> <>9__6_0;

		[Token(Token = "0x4000372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Plant, IEnumerable<MeshRenderer>> <>9__7_0;

		[Token(Token = "0x600044B")]
		[Address(RVA = "0x1673A3C", Offset = "0x1673A3C", VA = "0x1673A3C")]
		public <>c()
		{
		}

		[Token(Token = "0x600044C")]
		[Address(RVA = "0x1673A44", Offset = "0x1673A44", VA = "0x1673A44")]
		internal IEnumerable<MeshRenderer> <Show>b__6_0(Plant plant)
		{
			return null;
		}

		[Token(Token = "0x600044D")]
		[Address(RVA = "0x1673A5C", Offset = "0x1673A5C", VA = "0x1673A5C")]
		internal IEnumerable<MeshRenderer> <Hide>b__7_0(Plant plant)
		{
			return null;
		}
	}

	[Token(Token = "0x400036C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject SpawnPosition;

	[Token(Token = "0x400036D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static readonly List<Plant> Plants;

	[Token(Token = "0x400036E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public MeshRenderer[] Renderers;

	[Token(Token = "0x400036F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public bool ForceShadowCastingOn;

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x108B8E0", Offset = "0x108B8E0", VA = "0x108B8E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000444")]
	[Address(RVA = "0x108B9EC", Offset = "0x108B9EC", VA = "0x108B9EC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000445")]
	[Address(RVA = "0x108BADC", Offset = "0x108BADC", VA = "0x108BADC")]
	public static void Show()
	{
	}

	[Token(Token = "0x6000446")]
	[Address(RVA = "0x108BEB4", Offset = "0x108BEB4", VA = "0x108BEB4")]
	public static void Hide()
	{
	}

	[Token(Token = "0x6000447")]
	[Address(RVA = "0x108C28C", Offset = "0x108C28C", VA = "0x108C28C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000448")]
	[Address(RVA = "0x108C4BC", Offset = "0x108C4BC", VA = "0x108C4BC")]
	public Plant()
	{
	}
}
[Token(Token = "0x20000B7")]
public class RandomSpawn : MonoBehaviour
{
	[Token(Token = "0x4000373")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE5B38", Offset = "0xAE5B38")]
	public int PercentChance;

	[Token(Token = "0x600044E")]
	[Address(RVA = "0x138C214", Offset = "0x138C214", VA = "0x138C214")]
	private void Start()
	{
	}

	[Token(Token = "0x600044F")]
	[Address(RVA = "0x138C27C", Offset = "0x138C27C", VA = "0x138C27C")]
	public RandomSpawn()
	{
	}
}
[Token(Token = "0x20000B8")]
[ExecuteInEditMode]
[SelectionBase]
public class Rock : AddressablePrefab
{
	[Token(Token = "0x4000374")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	[SerializeField]
	private float _MeshSize;

	[Token(Token = "0x4000375")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[HideInInspector]
	[SerializeField]
	private bool WasNeverSetup;

	[Token(Token = "0x4000376")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Rigidbody Rigidbody;

	[Token(Token = "0x4000377")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Grabbable Grabbable;

	[Token(Token = "0x4000378")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GrabbaleImpactAudio ImpactAudio;

	[Token(Token = "0x170000B2")]
	private float Volume
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x138C7A0", Offset = "0x138C7A0", VA = "0x138C7A0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000451")]
	[Address(RVA = "0x138C7D8", Offset = "0x138C7D8", VA = "0x138C7D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000452")]
	[Address(RVA = "0x138C87C", Offset = "0x138C87C", VA = "0x138C87C", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6000453")]
	[Address(RVA = "0x138C98C", Offset = "0x138C98C", VA = "0x138C98C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x138CBA0", Offset = "0x138CBA0", VA = "0x138CBA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x138CCFC", Offset = "0x138CCFC", VA = "0x138CCFC")]
	private void UpdateEditor()
	{
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x138CD00", Offset = "0x138CD00", VA = "0x138CD00")]
	public Rock()
	{
	}
}
[Token(Token = "0x20000B9")]
public class ShootingStar : MonoBehaviour
{
	[Token(Token = "0x4000379")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Mesh Mesh;

	[Token(Token = "0x400037A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private GameObject Child;

	[Token(Token = "0x400037B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3[] StartState;

	[Token(Token = "0x400037C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Vector3[] Verts;

	[Token(Token = "0x400037D")]
	private const int TopRt = 5;

	[Token(Token = "0x400037E")]
	private const int BotRt = 6;

	[Token(Token = "0x400037F")]
	private const int MidRt = 7;

	[Token(Token = "0x4000380")]
	private const int Tail = 8;

	[Token(Token = "0x4000381")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AnimationCurve ScaleOverLifetime;

	[Token(Token = "0x4000382")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AnimationCurve SpeedOverLifetime;

	[Token(Token = "0x4000383")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AnimationCurve AlphaOverLifetime;

	[Token(Token = "0x4000384")]
	private const float Frequency = 75f;

	[Token(Token = "0x4000385")]
	private const float Amp = 0.2f;

	[Token(Token = "0x4000386")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float CurrSpeed;

	[Token(Token = "0x4000387")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float AliveTime;

	[Token(Token = "0x4000388")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Material Mat;

	[Token(Token = "0x4000389")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly int _TailAlpha;

	[Token(Token = "0x400038A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[HideInInspector]
	public Vector3 StartPos;

	[Token(Token = "0x400038B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[HideInInspector]
	public float Scale;

	[Token(Token = "0x400038C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[HideInInspector]
	public float StartSpeed;

	[Token(Token = "0x400038D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[HideInInspector]
	public float StretchSpeed;

	[Token(Token = "0x400038E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[HideInInspector]
	public float BodyStretch;

	[Token(Token = "0x400038F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[HideInInspector]
	public float TailPinch;

	[Token(Token = "0x4000390")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	[HideInInspector]
	public float TailStretch;

	[Token(Token = "0x4000391")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[HideInInspector]
	public float Lifetime;

	[Token(Token = "0x4000392")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public float StartAlpha;

	[Token(Token = "0x4000393")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[HideInInspector]
	public Vector3 StartColor;

	[Token(Token = "0x4000394")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[HideInInspector]
	public float TailAlpha;

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x138D308", Offset = "0x138D308", VA = "0x138D308")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x138D3DC", Offset = "0x138D3DC", VA = "0x138D3DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x138D428", Offset = "0x138D428", VA = "0x138D428")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600045A")]
	[Address(RVA = "0x138D634", Offset = "0x138D634", VA = "0x138D634")]
	private void Update()
	{
	}

	[Token(Token = "0x600045B")]
	[Address(RVA = "0x138D9D8", Offset = "0x138D9D8", VA = "0x138D9D8")]
	private void LifetimeUpdates()
	{
	}

	[Token(Token = "0x600045C")]
	[Address(RVA = "0x138D6F0", Offset = "0x138D6F0", VA = "0x138D6F0")]
	private void StretchStar()
	{
	}

	[Token(Token = "0x600045D")]
	[Address(RVA = "0x138DB24", Offset = "0x138DB24", VA = "0x138DB24")]
	public ShootingStar()
	{
	}
}
[Token(Token = "0x20000BA")]
public class ShootingStarSystem : NetworkSyncedObject
{
	[Token(Token = "0x20000BB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4328", Offset = "0xAE4328")]
	private sealed class <StarSpawner>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShootingStarSystem <>4__this;

		[Token(Token = "0x40003A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <connectedAsMaster>5__2;

		[Token(Token = "0x170000B3")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000467")]
			[Address(RVA = "0x1675CEC", Offset = "0x1675CEC", VA = "0x1675CEC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000B4")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000469")]
			[Address(RVA = "0x1675D34", Offset = "0x1675D34", VA = "0x1675D34", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000464")]
		[Address(RVA = "0x1675818", Offset = "0x1675818", VA = "0x1675818")]
		[DebuggerHidden]
		public <StarSpawner>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x6000465")]
		[Address(RVA = "0x1675844", Offset = "0x1675844", VA = "0x1675844", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000466")]
		[Address(RVA = "0x1675848", Offset = "0x1675848", VA = "0x1675848", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000468")]
		[Address(RVA = "0x1675CF4", Offset = "0x1675CF4", VA = "0x1675CF4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000395")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ShootingStarPrefab;

	[Token(Token = "0x4000396")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector2 SpawnScale;

	[Token(Token = "0x4000397")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5C74", Offset = "0xAE5C74")]
	public Vector2 Lifetime;

	[Token(Token = "0x4000398")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector2 BodyStretch;

	[Token(Token = "0x4000399")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Vector2 TailStretch;

	[Token(Token = "0x400039A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5CAC", Offset = "0xAE5CAC")]
	public Vector2 TailPinch;

	[Token(Token = "0x400039B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Vector2 Speed;

	[Token(Token = "0x400039C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Vector2 SpawnDelay;

	[Token(Token = "0x400039D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5CE4", Offset = "0xAE5CE4")]
	public Gradient ColorOptions;

	[Token(Token = "0x400039E")]
	private const float SpawnHeight = 5000f;

	[Token(Token = "0x400039F")]
	private const float SpawnRange = 7000f;

	[Token(Token = "0x600045E")]
	[Address(RVA = "0x138DB80", Offset = "0x138DB80", VA = "0x138DB80", Slot = "28")]
	public override void OnEnable()
	{
	}

	[Token(Token = "0x600045F")]
	[Address(RVA = "0x138DC3C", Offset = "0x138DC3C", VA = "0x138DC3C", Slot = "29")]
	public override void OnDisable()
	{
	}

	[Token(Token = "0x6000460")]
	[Address(RVA = "0x138DBD0", Offset = "0x138DBD0", VA = "0x138DBD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEC8AC", Offset = "0xAEC8AC")]
	private IEnumerator StarSpawner()
	{
		return null;
	}

	[Token(Token = "0x6000461")]
	[Address(RVA = "0x138DC80", Offset = "0x138DC80", VA = "0x138DC80")]
	private ShootingStar CreateStar()
	{
		return null;
	}

	[Token(Token = "0x6000462")]
	[Address(RVA = "0x138DEE4", Offset = "0x138DEE4", VA = "0x138DEE4")]
	[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAEC90C", Offset = "0xAEC90C")]
	[PunRPC]
	private void RPC_SpawnStar(float scale, Vector3 startPos, Vector3 startColor, float startAlpha, float startSpeed, float tailStretch, float bodyStretch, float tailPinch, float lifetime, float tailAlpha)
	{
	}

	[Token(Token = "0x6000463")]
	[Address(RVA = "0x138E044", Offset = "0x138E044", VA = "0x138E044")]
	public ShootingStarSystem()
	{
	}
}
[Token(Token = "0x20000BC")]
public class SkyEffects : MonoBehaviour
{
	[Token(Token = "0x40003A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SunFlare SunFlare;

	[Token(Token = "0x40003A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject AirplaneTrails;

	[Token(Token = "0x40003A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject ShootingStars;

	[Token(Token = "0x40003A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool Hidden;

	[Token(Token = "0x40003A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	private bool NightMode;

	[Token(Token = "0x40003A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	private bool DisableSunflare;

	[Token(Token = "0x40003AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
	private bool DisableAirplanes;

	[Token(Token = "0x40003AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool DisableShootingStars;

	[Token(Token = "0x600046A")]
	[Address(RVA = "0x138E644", Offset = "0x138E644", VA = "0x138E644")]
	public void Setup(Vector3 position, bool nightMode, bool disableSunflare, bool disableAirplanes, bool disableShootingStars)
	{
	}

	[Token(Token = "0x600046B")]
	[Address(RVA = "0x138E784", Offset = "0x138E784", VA = "0x138E784")]
	public void Hide(bool v)
	{
	}

	[Token(Token = "0x600046C")]
	[Address(RVA = "0x138E8B0", Offset = "0x138E8B0", VA = "0x138E8B0")]
	public void EnableSunFlare(bool v)
	{
	}

	[Token(Token = "0x600046D")]
	[Address(RVA = "0x138E8E4", Offset = "0x138E8E4", VA = "0x138E8E4")]
	public SkyEffects()
	{
	}
}
[Token(Token = "0x20000BD")]
public class SnowParticles : MonoBehaviour
{
	[Token(Token = "0x40003AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Height;

	[Token(Token = "0x600046E")]
	[Address(RVA = "0x138E8EC", Offset = "0x138E8EC", VA = "0x138E8EC")]
	private void Update()
	{
	}

	[Token(Token = "0x600046F")]
	[Address(RVA = "0x138EA00", Offset = "0x138EA00", VA = "0x138EA00")]
	public SnowParticles()
	{
	}
}
[Token(Token = "0x20000BE")]
[ExecuteInEditMode]
public class SunFlare : MonoBehaviour
{
	[Token(Token = "0x40003AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer FlareRenderer;

	[Token(Token = "0x40003AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5D1C", Offset = "0xAE5D1C")]
	private bool <Enabled>k__BackingField;

	[Token(Token = "0x40003AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Light LuminaryLight;

	[Token(Token = "0x40003B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int RaycastCounter;

	[Token(Token = "0x40003B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private int HitCount;

	[Token(Token = "0x40003B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int RaysCount;

	[Token(Token = "0x40003B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private Vector3 DirectionSmoothed;

	[Token(Token = "0x40003B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Vector3 UnblockedAverageDirectionSmoothed;

	[Token(Token = "0x40003B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private Vector3 LastUnblockedAverageDirection;

	[Token(Token = "0x40003B6")]
	private const float ScaleMin = 0.3f;

	[Token(Token = "0x40003B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int OPACITY;

	[Token(Token = "0x40003B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int SunflareStrength;

	[Token(Token = "0x170000B5")]
	public bool Enabled
	{
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x13938DC", Offset = "0x13938DC", VA = "0x13938DC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9A4", Offset = "0xAEC9A4")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x13938D0", Offset = "0x13938D0", VA = "0x13938D0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC994", Offset = "0xAEC994")]
		set
		{
		}
	}

	[Token(Token = "0x6000472")]
	[Address(RVA = "0x13938E4", Offset = "0x13938E4", VA = "0x13938E4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000473")]
	[Address(RVA = "0x139394C", Offset = "0x139394C", VA = "0x139394C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000474")]
	[Address(RVA = "0x1394720", Offset = "0x1394720", VA = "0x1394720")]
	public SunFlare()
	{
	}
}
[Token(Token = "0x20000BF")]
[ExecuteInEditMode]
public class Water : MonoBehaviour
{
	[Token(Token = "0x40003B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<Water> Waters;

	[Token(Token = "0x40003BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public MeshRenderer Renderer;

	[Token(Token = "0x40003BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5D3C", Offset = "0xAE5D3C")]
	public Color ColorDay;

	[Token(Token = "0x40003BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5D54", Offset = "0xAE5D54")]
	public Color DepthColorDay;

	[Token(Token = "0x40003BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5D6C", Offset = "0xAE5D6C")]
	public Color ColorNight;

	[Token(Token = "0x40003BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "ColorUsageAttribute", RVA = "0xAE5D84", Offset = "0xAE5D84")]
	public Color DepthColorNight;

	[Token(Token = "0x40003BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Cubemap DayCubemap;

	[Token(Token = "0x40003C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Cubemap NightCubemap;

	[Token(Token = "0x40003C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool NightMode;

	[Token(Token = "0x6000476")]
	[Address(RVA = "0xE3CC80", Offset = "0xE3CC80", VA = "0xE3CC80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000477")]
	[Address(RVA = "0xE3CD40", Offset = "0xE3CD40", VA = "0xE3CD40")]
	private void UpdateColors()
	{
	}

	[Token(Token = "0x6000478")]
	[Address(RVA = "0xE3CEA4", Offset = "0xE3CEA4", VA = "0xE3CEA4")]
	public static void Show()
	{
	}

	[Token(Token = "0x6000479")]
	[Address(RVA = "0xE3D000", Offset = "0xE3D000", VA = "0xE3D000")]
	public static void Hide()
	{
	}

	[Token(Token = "0x600047A")]
	[Address(RVA = "0xE3D15C", Offset = "0xE3D15C", VA = "0xE3D15C")]
	public static void SetNightMode(bool v)
	{
	}

	[Token(Token = "0x600047B")]
	[Address(RVA = "0xE3D2AC", Offset = "0xE3D2AC", VA = "0xE3D2AC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600047C")]
	[Address(RVA = "0xE3D390", Offset = "0xE3D390", VA = "0xE3D390")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600047D")]
	[Address(RVA = "0xE3D474", Offset = "0xE3D474", VA = "0xE3D474")]
	public Water()
	{
	}
}
[Token(Token = "0x20000C0")]
public class MetaAvatar : OvrAvatarEntity
{
	[Token(Token = "0x20000C1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4358", Offset = "0xAE4358")]
	private sealed class <CheckHasAvatar>d__53 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MetaAvatar <>4__this;

		[Token(Token = "0x40003DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool <continueRetries>5__2;

		[Token(Token = "0x40003DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <retriesRemaining>5__3;

		[Token(Token = "0x40003DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <hasFoundAvatar>5__4;

		[Token(Token = "0x40003DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
		private bool <requestComplete>5__5;

		[Token(Token = "0x40003E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Task<OvrAvatarManager.HasAvatarRequestResultCode> <hasAvatarRequest>5__6;

		[Token(Token = "0x170000BD")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600049E")]
			[Address(RVA = "0xE494F8", Offset = "0xE494F8", VA = "0xE494F8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000BE")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A0")]
			[Address(RVA = "0xE49540", Offset = "0xE49540", VA = "0xE49540", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600049B")]
		[Address(RVA = "0xE49184", Offset = "0xE49184", VA = "0xE49184")]
		[DebuggerHidden]
		public <CheckHasAvatar>d__53(int <>1__state)
		{
		}

		[Token(Token = "0x600049C")]
		[Address(RVA = "0xE491B0", Offset = "0xE491B0", VA = "0xE491B0", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600049D")]
		[Address(RVA = "0xE491B4", Offset = "0xE491B4", VA = "0xE491B4", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600049F")]
		[Address(RVA = "0xE49500", Offset = "0xE49500", VA = "0xE49500", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x20000C2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4368", Offset = "0xAE4368")]
	private sealed class <LoadAvatar>d__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40003E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40003E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40003E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public MetaAvatar <>4__this;

		[Token(Token = "0x40003E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool loadFallbackOnFailure;

		[Token(Token = "0x40003E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <remainingAttempts>5__2;

		[Token(Token = "0x40003E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private bool <didLoadAvatar>5__3;

		[Token(Token = "0x40003E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float <currentPollingInterval>5__4;

		[Token(Token = "0x170000BF")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60004A4")]
			[Address(RVA = "0xE49704", Offset = "0xE49704", VA = "0xE49704", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000C0")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60004A6")]
			[Address(RVA = "0xE4974C", Offset = "0xE4974C", VA = "0xE4974C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60004A1")]
		[Address(RVA = "0xE49548", Offset = "0xE49548", VA = "0xE49548")]
		[DebuggerHidden]
		public <LoadAvatar>d__54(int <>1__state)
		{
		}

		[Token(Token = "0x60004A2")]
		[Address(RVA = "0xE49574", Offset = "0xE49574", VA = "0xE49574", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60004A3")]
		[Address(RVA = "0xE49578", Offset = "0xE49578", VA = "0xE49578", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60004A5")]
		[Address(RVA = "0xE4970C", Offset = "0xE4970C", VA = "0xE4970C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40003C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static MetaAvatarBodyTracking BodyTracking;

	[Token(Token = "0x40003C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
	public OvrAvatarCustomHandPose CustomHandLeft;

	[Token(Token = "0x40003C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
	public OvrAvatarCustomHandPose CustomHandRight;

	[Token(Token = "0x40003C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5D9C", Offset = "0xAE5D9C")]
	private bool <ShouldHide>k__BackingField;

	[Token(Token = "0x40003C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x269")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DAC", Offset = "0xAE5DAC")]
	private bool <AvatarLoaded>k__BackingField;

	[Token(Token = "0x40003C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DBC", Offset = "0xAE5DBC")]
	private Transform <HeadTransform>k__BackingField;

	[Token(Token = "0x40003C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DCC", Offset = "0xAE5DCC")]
	private Transform <LeftHandTransform>k__BackingField;

	[Token(Token = "0x40003C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DDC", Offset = "0xAE5DDC")]
	private Transform <RightHandTransform>k__BackingField;

	[Token(Token = "0x40003CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DEC", Offset = "0xAE5DEC")]
	private PhotonView <PhotonView>k__BackingField;

	[Token(Token = "0x40003CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE5DFC", Offset = "0xAE5DFC")]
	private Transform <ChestTransform>k__BackingField;

	[Token(Token = "0x40003CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
	private bool SkeletonLoaded;

	[Token(Token = "0x40003CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
	private GameObject LeftHandTracking;

	[Token(Token = "0x40003CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
	private GameObject RightHandTracking;

	[Token(Token = "0x40003CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
	private bool HeadTransformSetUp;

	[Token(Token = "0x40003D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B1")]
	private bool ChestTransformSetUp;

	[Token(Token = "0x40003D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B2")]
	private bool LeftHandTransformSetUp;

	[Token(Token = "0x40003D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B3")]
	private bool RightHandTransformSetUp;

	[Token(Token = "0x40003D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
	private Transform LocalLOD0;

	[Token(Token = "0x40003D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
	private readonly List<byte[]> StreamedDataArray;

	[Token(Token = "0x40003D5")]
	private const int MaxBytesToLog = 5;

	[Token(Token = "0x40003D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
	[SerializeField]
	private float IntervalToSendData;

	[Token(Token = "0x40003D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2CC")]
	private float CycleStartTime;

	[Token(Token = "0x40003D8")]
	private const string LogScope = "MetaAvatar";

	[Token(Token = "0x170000B6")]
	public bool ShouldHide
	{
		[Token(Token = "0x600047F")]
		[Address(RVA = "0xFFBE84", Offset = "0xFFBE84", VA = "0xFFBE84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9B4", Offset = "0xAEC9B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000480")]
		[Address(RVA = "0xFFBE8C", Offset = "0xFFBE8C", VA = "0xFFBE8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9C4", Offset = "0xAEC9C4")]
		set
		{
		}
	}

	[Token(Token = "0x170000B7")]
	public bool AvatarLoaded
	{
		[Token(Token = "0x6000481")]
		[Address(RVA = "0xFFBE98", Offset = "0xFFBE98", VA = "0xFFBE98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9D4", Offset = "0xAEC9D4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000482")]
		[Address(RVA = "0xFFBEA0", Offset = "0xFFBEA0", VA = "0xFFBEA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9E4", Offset = "0xAEC9E4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B8")]
	public Transform HeadTransform
	{
		[Token(Token = "0x6000483")]
		[Address(RVA = "0xFFBEAC", Offset = "0xFFBEAC", VA = "0xFFBEAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEC9F4", Offset = "0xAEC9F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000484")]
		[Address(RVA = "0xFFBEB4", Offset = "0xFFBEB4", VA = "0xFFBEB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA04", Offset = "0xAECA04")]
		private set
		{
		}
	}

	[Token(Token = "0x170000B9")]
	public Transform LeftHandTransform
	{
		[Token(Token = "0x6000485")]
		[Address(RVA = "0xFFBEBC", Offset = "0xFFBEBC", VA = "0xFFBEBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA14", Offset = "0xAECA14")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000486")]
		[Address(RVA = "0xFFBEC4", Offset = "0xFFBEC4", VA = "0xFFBEC4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA24", Offset = "0xAECA24")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BA")]
	public Transform RightHandTransform
	{
		[Token(Token = "0x6000487")]
		[Address(RVA = "0xFFBECC", Offset = "0xFFBECC", VA = "0xFFBECC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA34", Offset = "0xAECA34")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000488")]
		[Address(RVA = "0xFFBED4", Offset = "0xFFBED4", VA = "0xFFBED4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA44", Offset = "0xAECA44")]
		private set
		{
		}
	}

	[Token(Token = "0x170000BB")]
	private PhotonView PhotonView
	{
		[Token(Token = "0x6000489")]
		[Address(RVA = "0xFFBEDC", Offset = "0xFFBEDC", VA = "0xFFBEDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA54", Offset = "0xAECA54")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048A")]
		[Address(RVA = "0xFFBEE4", Offset = "0xFFBEE4", VA = "0xFFBEE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA64", Offset = "0xAECA64")]
		set
		{
		}
	}

	[Token(Token = "0x170000BC")]
	private Transform ChestTransform
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0xFFBEEC", Offset = "0xFFBEEC", VA = "0xFFBEEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA74", Offset = "0xAECA74")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048C")]
		[Address(RVA = "0xFFBEF4", Offset = "0xFFBEF4", VA = "0xFFBEF4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECA84", Offset = "0xAECA84")]
		set
		{
		}
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0xFFBEFC", Offset = "0xFFBEFC", VA = "0xFFBEFC", Slot = "5")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0xFFC17C", Offset = "0xFFC17C", VA = "0xFFC17C")]
	public void Init(ulong id, Transform voice)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0xFFC828", Offset = "0xFFC828", VA = "0xFFC828")]
	private void Update()
	{
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0xFFD688", Offset = "0xFFD688", VA = "0xFFD688")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0xFFD854", Offset = "0xFFD854", VA = "0xFFD854", Slot = "14")]
	protected override void OnSkeletonLoaded()
	{
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0xFFD860", Offset = "0xFFD860", VA = "0xFFD860", Slot = "15")]
	protected override void OnDefaultAvatarLoaded()
	{
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0xFFD86C", Offset = "0xFFD86C", VA = "0xFFD86C", Slot = "17")]
	protected override void OnUserAvatarLoaded()
	{
	}

	[Token(Token = "0x6000494")]
	[Address(RVA = "0xFFD6E4", Offset = "0xFFD6E4", VA = "0xFFD6E4")]
	private void RecordAndSendStreamDataIfHasAuthority()
	{
	}

	[Token(Token = "0x6000495")]
	[Address(RVA = "0xFFD878", Offset = "0xFFD878", VA = "0xFFD878")]
	public void ReceiveMetaAvatarStreamData(byte[] bytes, double time)
	{
	}

	[Token(Token = "0x6000496")]
	[Address(RVA = "0xFFD990", Offset = "0xFFD990", VA = "0xFFD990")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECA94", Offset = "0xAECA94")]
	private IEnumerator CheckHasAvatar()
	{
		return null;
	}

	[Token(Token = "0x6000497")]
	[Address(RVA = "0xFFD9FC", Offset = "0xFFD9FC", VA = "0xFFD9FC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECAF4", Offset = "0xAECAF4")]
	private IEnumerator LoadAvatar(bool loadFallbackOnFailure)
	{
		return null;
	}

	[Token(Token = "0x6000498")]
	[Address(RVA = "0xFFC6E4", Offset = "0xFFC6E4", VA = "0xFFC6E4")]
	private void UserHasNoAvatarFallback()
	{
	}

	[Token(Token = "0x6000499")]
	[Address(RVA = "0xFFDA7C", Offset = "0xFFDA7C", VA = "0xFFDA7C")]
	public MetaAvatar()
	{
	}

	[Token(Token = "0x600049A")]
	[Address(RVA = "0xFFDB2C", Offset = "0xFFDB2C", VA = "0xFFDB2C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECB54", Offset = "0xAECB54")]
	private void <Init>b__44_0(Message<string> m)
	{
	}
}
[Token(Token = "0x20000C3")]
public class MetaAvatarBodyTracking : OvrAvatarInputManager
{
	[Token(Token = "0x60004A7")]
	[Address(RVA = "0xFFC618", Offset = "0xFFC618", VA = "0xFFC618")]
	public void SetRigTransforms(Transform head, Transform left, Transform right)
	{
	}

	[Token(Token = "0x60004A8")]
	[Address(RVA = "0xFFDBEC", Offset = "0xFFDBEC", VA = "0xFFDBEC")]
	public MetaAvatarBodyTracking()
	{
	}
}
[Token(Token = "0x20000C4")]
public class MetaFaceSample : OvrAvatarFaceTrackingBehaviorOvrPlugin
{
	[Token(Token = "0x60004A9")]
	[Address(RVA = "0xFFF8E4", Offset = "0xFFF8E4", VA = "0xFFF8E4")]
	public MetaFaceSample()
	{
	}
}
[Token(Token = "0x20000C5")]
public class MetaEyeSample : OvrAvatarEyeTrackingBehaviorOvrPlugin
{
	[Token(Token = "0x60004AA")]
	[Address(RVA = "0xFFF8DC", Offset = "0xFFF8DC", VA = "0xFFF8DC")]
	public MetaEyeSample()
	{
	}
}
[Token(Token = "0x20000C6")]
public class InputTrackingDelegate : OvrAvatarInputTrackingDelegate
{
	[Token(Token = "0x40003E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly Transform Head;

	[Token(Token = "0x40003E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Transform Left;

	[Token(Token = "0x40003EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Transform Right;

	[Token(Token = "0x60004AB")]
	[Address(RVA = "0x15E36E4", Offset = "0x15E36E4", VA = "0x15E36E4")]
	public InputTrackingDelegate(Transform head, Transform left, Transform right)
	{
	}

	[Token(Token = "0x60004AC")]
	[Address(RVA = "0x15E3724", Offset = "0x15E3724", VA = "0x15E3724", Slot = "5")]
	public override bool GetRawInputTrackingState(out OvrAvatarInputTrackingState inputTrackingState)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000C7")]
public static class OculusPlatformManager
{
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4378", Offset = "0xAE4378")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x40003F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BrinkPlayerVR Player;

		[Token(Token = "0x60004B3")]
		[Address(RVA = "0x1671CF4", Offset = "0x1671CF4", VA = "0x1671CF4")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60004B4")]
		[Address(RVA = "0x1671CFC", Offset = "0x1671CFC", VA = "0x1671CFC")]
		internal void <Init>b__0()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x20000C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4388", Offset = "0xAE4388")]
	private sealed class <>c
	{
		[Token(Token = "0x40003F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40003F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static OvrAvatarLog.LogDelegate <>9__5_1;

		[Token(Token = "0x40003F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Message<User>.Callback <>9__6_2;

		[Token(Token = "0x40003F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Message.Callback <>9__6_1;

		[Token(Token = "0x40003F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Message<PlatformInitialize>.Callback <>9__6_0;

		[Token(Token = "0x40003F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Message.Callback <>9__7_0;

		[Token(Token = "0x40003F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Message<InvitePanelResultInfo>.Callback <>9__8_0;

		[Token(Token = "0x60004B6")]
		[Address(RVA = "0x1671528", Offset = "0x1671528", VA = "0x1671528")]
		public <>c()
		{
		}

		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x1671530", Offset = "0x1671530", VA = "0x1671530")]
		internal void <Init>b__5_1(OvrAvatarLog.ELogLevel level, string scope, string msg)
		{
		}

		[Token(Token = "0x60004B8")]
		[Address(RVA = "0x1671534", Offset = "0x1671534", VA = "0x1671534")]
		internal void <GetUserInfos>b__6_0(Message<PlatformInitialize> initMsg)
		{
		}

		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x1671760", Offset = "0x1671760", VA = "0x1671760")]
		internal void <GetUserInfos>b__6_1(Message entitlementMsg)
		{
		}

		[Token(Token = "0x60004BA")]
		[Address(RVA = "0x1671950", Offset = "0x1671950", VA = "0x1671950")]
		internal void <GetUserInfos>b__6_2(Message<User> isUserLoggedInMsg)
		{
		}

		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x1671B64", Offset = "0x1671B64", VA = "0x1671B64")]
		internal void <SetPresence>b__7_0(Message message1)
		{
		}

		[Token(Token = "0x60004BC")]
		[Address(RVA = "0x1671C2C", Offset = "0x1671C2C", VA = "0x1671C2C")]
		internal void <InviteFriend>b__8_0(Message<InvitePanelResultInfo> message)
		{
		}
	}

	[Token(Token = "0x20000CA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4398", Offset = "0xAE4398")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x40003F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public User user;

		[Token(Token = "0x60004BD")]
		[Address(RVA = "0x1671B5C", Offset = "0x1671B5C", VA = "0x1671B5C")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x1671D18", Offset = "0x1671D18", VA = "0x1671D18")]
		internal void <GetUserInfos>b__3(Message<UserProof> proofMsg)
		{
		}
	}

	[Token(Token = "0x40003EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool USER_NOT_LOGGED_IN;

	[Token(Token = "0x40003EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static ulong USER_ID;

	[Token(Token = "0x40003ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string USER_NAME;

	[Token(Token = "0x40003EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string USER_IMAGE_URL;

	[Token(Token = "0x40003EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static string USER_NONCE;

	[Token(Token = "0x60004AD")]
	[Address(RVA = "0x1083698", Offset = "0x1083698", VA = "0x1083698")]
	public static void Init(BrinkPlayerVR Player, Action UnpauseApp, Action PauseApp)
	{
	}

	[Token(Token = "0x60004AE")]
	[Address(RVA = "0x1083CA0", Offset = "0x1083CA0", VA = "0x1083CA0")]
	private static void GetUserInfos()
	{
	}

	[Token(Token = "0x60004AF")]
	[Address(RVA = "0x1083E20", Offset = "0x1083E20", VA = "0x1083E20")]
	public static void SetPresence(string lobbyCode)
	{
	}

	[Token(Token = "0x60004B0")]
	[Address(RVA = "0x10840D0", Offset = "0x10840D0", VA = "0x10840D0")]
	public static void InviteFriend()
	{
	}

	[Token(Token = "0x60004B1")]
	[Address(RVA = "0x108422C", Offset = "0x108422C", VA = "0x108422C")]
	public static void RefreshUserInfo()
	{
	}

	[Token(Token = "0x60004B2")]
	[Address(RVA = "0x1084278", Offset = "0x1084278", VA = "0x1084278")]
	private static void OnJoinIntentChangeNotif(Message<GroupPresenceJoinIntent> message)
	{
	}
}
[Token(Token = "0x20000CB")]
public class AppSettings : ScriptableObject
{
	[Token(Token = "0x40003F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AppSettings _Instance;

	[Token(Token = "0x40003FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string Version;

	[Token(Token = "0x40003FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private int Code;

	[Token(Token = "0x40003FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string APIVersion;

	[Token(Token = "0x40003FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string BucketAddress;

	[Token(Token = "0x40003FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool ClearCacheOnStartup;

	[Token(Token = "0x170000C1")]
	private static AppSettings Instance
	{
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x1192D84", Offset = "0x1192D84", VA = "0x1192D84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C2")]
	public static string DLCs_BUILD_PATH
	{
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x1192E5C", Offset = "0x1192E5C", VA = "0x1192E5C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C3")]
	public static string SERVER_ADDRESS
	{
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x1192F20", Offset = "0x1192F20", VA = "0x1192F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C4")]
	public static string VERSION
	{
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x1192F00", Offset = "0x1192F00", VA = "0x1192F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C5")]
	public static int CODE
	{
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x119309C", Offset = "0x119309C", VA = "0x119309C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000C6")]
	public static string API_VERSION
	{
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x11930BC", Offset = "0x11930BC", VA = "0x11930BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C7")]
	public static string API_ADDRESS
	{
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x11930DC", Offset = "0x11930DC", VA = "0x11930DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C8")]
	public static string BUCKET_ADDRESS
	{
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x119307C", Offset = "0x119307C", VA = "0x119307C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C9")]
	public static bool RESET_ON_STARTUP
	{
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x119319C", Offset = "0x119319C", VA = "0x119319C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60004C8")]
	[Address(RVA = "0x1193220", Offset = "0x1193220", VA = "0x1193220")]
	public AppSettings()
	{
	}
}
[Token(Token = "0x20000CC")]
public class BrinkTextureToolSettings : ScriptableObject
{
	[Token(Token = "0x40003FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int Falloff;

	[Token(Token = "0x4000400")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Keyframe[] Points;

	[Token(Token = "0x60004C9")]
	[Address(RVA = "0x119FED8", Offset = "0x119FED8", VA = "0x119FED8")]
	public BrinkTextureToolSettings()
	{
	}
}
[Token(Token = "0x20000CD")]
public class DebugAppSettings : ScriptableObject
{
	[Token(Token = "0x4000401")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DebugAppSettings _Instance;

	[Token(Token = "0x4000402")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool ClearCacheOnPlay;

	[Token(Token = "0x4000403")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	[SerializeField]
	private bool SkipIntro;

	[Token(Token = "0x4000404")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A")]
	[SerializeField]
	private bool SkipTutorial;

	[Token(Token = "0x4000405")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string LocalServerIp;

	[Token(Token = "0x4000406")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool LogStackTrace;

	[Token(Token = "0x170000CA")]
	private static DebugAppSettings Instance
	{
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x15D5A34", Offset = "0x15D5A34", VA = "0x15D5A34")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CB")]
	public static bool RESET_ON_PLAY
	{
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x15D5B0C", Offset = "0x15D5B0C", VA = "0x15D5B0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CC")]
	public static bool SKIP_INTRO
	{
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x15D5B48", Offset = "0x15D5B48", VA = "0x15D5B48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CD")]
	public static bool SKIP_TUTORIAL
	{
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x15D5BCC", Offset = "0x15D5BCC", VA = "0x15D5BCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CE")]
	public static bool LOG_STACK_TRACE
	{
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x15D5C50", Offset = "0x15D5C50", VA = "0x15D5C50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000CF")]
	public static string LOCAL_SERVER_IP
	{
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x15D5C8C", Offset = "0x15D5C8C", VA = "0x15D5C8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004D0")]
	[Address(RVA = "0x15D5CAC", Offset = "0x15D5CAC", VA = "0x15D5CAC")]
	public DebugAppSettings()
	{
	}
}
[Token(Token = "0x20000CE")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAE43A8", Offset = "0xAE43A8")]
public sealed class LocationInfo : ScriptableObject
{
	[Token(Token = "0x20000CF")]
	public enum BadgeEnum
	{
		[Token(Token = "0x400042A")]
		NONE,
		[Token(Token = "0x400042B")]
		NEW_SPOT,
		[Token(Token = "0x400042C")]
		NEW_LOCATION
	}

	[Token(Token = "0x20000D0")]
	public enum LocationCacheState
	{
		[Token(Token = "0x400042E")]
		NOT_CACHED,
		[Token(Token = "0x400042F")]
		QUEUED,
		[Token(Token = "0x4000430")]
		DOWNLOADING,
		[Token(Token = "0x4000431")]
		CACHED,
		[Token(Token = "0x4000432")]
		NOT_ENOUGH_DISK_SPACE,
		[Token(Token = "0x4000433")]
		NEED_UPDATE
	}

	[Token(Token = "0x20000D1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE43F8", Offset = "0xAE43F8")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000434")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x60004E9")]
		[Address(RVA = "0xE44F1C", Offset = "0xE44F1C", VA = "0xE44F1C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x60004EA")]
		[Address(RVA = "0xE44F24", Offset = "0xE44F24", VA = "0xE44F24")]
		internal bool <GetById>b__0(LocationInfo locationInfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20000D2")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4408", Offset = "0xAE4408")]
	private sealed class <>c__DisplayClass63_0
	{
		[Token(Token = "0x4000435")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x60004EB")]
		[Address(RVA = "0xE44F48", Offset = "0xE44F48", VA = "0xE44F48")]
		public <>c__DisplayClass63_0()
		{
		}

		[Token(Token = "0x60004EC")]
		[Address(RVA = "0xE44F50", Offset = "0xE44F50", VA = "0xE44F50")]
		internal bool <GetPOIById>b__0(PointOfInterestData poi)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000407")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<LocationInfo> _LocationInfos;

	[NonSerialized]
	[Token(Token = "0x4000408")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float DownloadStartTime;

	[Token(Token = "0x4000409")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string LocationName;

	[Token(Token = "0x400040A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int SpotsCount;

	[Token(Token = "0x400040B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public bool Enabled;

	[Token(Token = "0x400040C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2D")]
	public bool IsAvailable;

	[Token(Token = "0x400040D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2E")]
	public bool IsDLC;

	[Token(Token = "0x400040E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2F")]
	public bool FreeInAR;

	[Token(Token = "0x400040F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Texture AtlasTexture;

	[Token(Token = "0x4000410")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Mesh Map;

	[Token(Token = "0x4000411")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Countries Country;

	[Token(Token = "0x4000412")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public string Date;

	[Token(Token = "0x4000413")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public int WindSpeed;

	[Token(Token = "0x4000414")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public int Temperature;

	[Token(Token = "0x4000415")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public int Elevation;

	[Token(Token = "0x4000416")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public string Latitude;

	[Token(Token = "0x4000417")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public string Longitude;

	[Token(Token = "0x4000418")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public PointOfInterestData POI1;

	[Token(Token = "0x4000419")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public PointOfInterestData POI2;

	[Token(Token = "0x400041A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public PointOfInterestData POI3;

	[Token(Token = "0x400041B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5EBC", Offset = "0xAE5EBC")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAE5EBC", Offset = "0xAE5EBC")]
	public bool FormatEnglishTitle;

	[Token(Token = "0x400041C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5F1C", Offset = "0xAE5F1C")]
	public string EnglishTitleFormating;

	[Token(Token = "0x400041D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public bool ShowVertigoWarning;

	[Token(Token = "0x400041E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x99")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5F54", Offset = "0xAE5F54")]
	public bool LockVerticalMovementInAR;

	[Token(Token = "0x400041F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE5F8C", Offset = "0xAE5F8C")]
	public BadgeEnum Badge;

	[NonSerialized]
	[Token(Token = "0x4000420")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public LocationCacheState CacheState;

	[NonSerialized]
	[Token(Token = "0x4000421")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	public float DownloadPercent;

	[NonSerialized]
	[Token(Token = "0x4000422")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public int RequiredDiskSpaceMB;

	[NonSerialized]
	[Token(Token = "0x4000423")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public int ClearableDiskMB;

	[Token(Token = "0x4000424")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string[] StaticDependencies;

	[Token(Token = "0x4000425")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public string[] SharedDependenciesLabels;

	[Token(Token = "0x4000426")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public string DependencyWindBankAddress;

	[Token(Token = "0x4000427")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public bool IncludeInTestContent;

	[Token(Token = "0x4000428")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public AsyncOperationHandle<LocationInfo> AddressableHandle;

	[Token(Token = "0x170000D0")]
	public static List<LocationInfo> LocationInfos
	{
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x1420CA8", Offset = "0x1420CA8", VA = "0x1420CA8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D1")]
	public PointOfInterestData[] POIs
	{
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x14210B4", Offset = "0x14210B4", VA = "0x14210B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D2")]
	public string LocationHumanName
	{
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x14211B4", Offset = "0x14211B4", VA = "0x14211B4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D3")]
	public string Description
	{
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x1421230", Offset = "0x1421230", VA = "0x1421230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D4")]
	public string GeographicLocation
	{
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x14212AC", Offset = "0x14212AC", VA = "0x14212AC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D5")]
	public string DependencySceneAddress
	{
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x1421328", Offset = "0x1421328", VA = "0x1421328")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D6")]
	public List<string> AllDependencies
	{
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x14214DC", Offset = "0x14214DC", VA = "0x14214DC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D7")]
	private string[] DependencyAudioIntroKeys
	{
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x1421804", Offset = "0x1421804", VA = "0x1421804")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D8")]
	private IEnumerable<string> DependencyPoiImages
	{
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x14215FC", Offset = "0x14215FC", VA = "0x14215FC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000D9")]
	public string TitleFormated
	{
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x1421908", Offset = "0x1421908", VA = "0x1421908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004D2")]
	[Address(RVA = "0x1420D14", Offset = "0x1420D14", VA = "0x1420D14")]
	public static void Add(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x1420E8C", Offset = "0x1420E8C", VA = "0x1420E8C")]
	public static void Remove(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x1420F98", Offset = "0x1420F98", VA = "0x1420F98")]
	public static LocationInfo GetById(string id)
	{
		return null;
	}

	[Token(Token = "0x60004DE")]
	[Address(RVA = "0x1421B30", Offset = "0x1421B30", VA = "0x1421B30")]
	public static string FormatTitle(string title, bool applyFormating, string formating)
	{
		return null;
	}

	[Token(Token = "0x60004DF")]
	[Address(RVA = "0x1421B38", Offset = "0x1421B38", VA = "0x1421B38")]
	public string GetSpotUniqueIndex(int index)
	{
		return null;
	}

	[Token(Token = "0x60004E0")]
	[Address(RVA = "0x1421BAC", Offset = "0x1421BAC", VA = "0x1421BAC")]
	public string GetSpotName(int index)
	{
		return null;
	}

	[Token(Token = "0x60004E1")]
	[Address(RVA = "0x1421D18", Offset = "0x1421D18", VA = "0x1421D18")]
	public string GetSpotId(int index)
	{
		return null;
	}

	[Token(Token = "0x60004E2")]
	[Address(RVA = "0x1421D3C", Offset = "0x1421D3C", VA = "0x1421D3C")]
	public PointOfInterestData GetPOIById(string id)
	{
		return null;
	}

	[Token(Token = "0x60004E3")]
	[Address(RVA = "0x1421E34", Offset = "0x1421E34", VA = "0x1421E34")]
	public List<string> GetClearableDependencies()
	{
		return null;
	}

	[Token(Token = "0x60004E4")]
	[Address(RVA = "0x14229F4", Offset = "0x14229F4", VA = "0x14229F4")]
	public LocationInfo()
	{
	}

	[Token(Token = "0x60004E6")]
	[Address(RVA = "0x1422BEC", Offset = "0x1422BEC", VA = "0x1422BEC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECC04", Offset = "0xAECC04")]
	private string <get_DependencyAudioIntroKeys>b__54_0(string languageCode)
	{
		return null;
	}

	[Token(Token = "0x60004E7")]
	[Address(RVA = "0x1422D84", Offset = "0x1422D84", VA = "0x1422D84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECC14", Offset = "0xAECC14")]
	private bool <GetClearableDependencies>b__64_0(LocationInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x60004E8")]
	[Address(RVA = "0x1422DF8", Offset = "0x1422DF8", VA = "0x1422DF8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECC24", Offset = "0xAECC24")]
	private bool <GetClearableDependencies>b__64_1(LocationInfo info)
	{
		return default(bool);
	}
}
[Serializable]
[Token(Token = "0x20000D3")]
public class PointOfInterestData
{
	[Token(Token = "0x20000D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4418", Offset = "0xAE4418")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400043C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PointOfInterestData <>4__this;

		[Token(Token = "0x400043D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<Texture, bool> callback;

		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x1673A74", Offset = "0x1673A74", VA = "0x1673A74")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x1673A7C", Offset = "0x1673A7C", VA = "0x1673A7C")]
		internal void <GetImage>b__0(AsyncOperationHandle handle)
		{
		}
	}

	[Token(Token = "0x4000436")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public string Id;

	[Token(Token = "0x4000437")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public int Index;

	[Token(Token = "0x4000438")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string LocationId;

	[Token(Token = "0x4000439")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AssetReference ImageRef;

	[Token(Token = "0x400043A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private AsyncOperationHandle ImageHandle;

	[Token(Token = "0x400043B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Texture Image;

	[Token(Token = "0x170000DA")]
	public string Title
	{
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x107CEE8", Offset = "0x107CEE8", VA = "0x107CEE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DB")]
	public string Text1
	{
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x107CF8C", Offset = "0x107CF8C", VA = "0x107CF8C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DC")]
	public string Text2
	{
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x1089DFC", Offset = "0x1089DFC", VA = "0x1089DFC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000DD")]
	public bool Found
	{
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x107CE80", Offset = "0x107CE80", VA = "0x107CE80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60004ED")]
	[Address(RVA = "0x108C868", Offset = "0x108C868", VA = "0x108C868")]
	public void Init(string locationId, int index)
	{
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x108C910", Offset = "0x108C910", VA = "0x108C910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x107D030", Offset = "0x107D030", VA = "0x107D030")]
	public void GetImage(Action<Texture, bool> callback)
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x108C914", Offset = "0x108C914", VA = "0x108C914")]
	public PointOfInterestData()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D5")]
public class LocationInfoMenuList : ScriptableObject
{
	[Token(Token = "0x20000D6")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4428", Offset = "0xAE4428")]
	private sealed class <>c__DisplayClass3_0
	{
		[Token(Token = "0x4000440")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string locationId;

		[Token(Token = "0x4000441")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<LocationInfoMenuListItem, bool> <>9__0;

		[Token(Token = "0x60004FB")]
		[Address(RVA = "0xE44F74", Offset = "0xE44F74", VA = "0xE44F74")]
		public <>c__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60004FC")]
		[Address(RVA = "0xE44F7C", Offset = "0xE44F7C", VA = "0xE44F7C")]
		internal bool <Remove>b__0(LocationInfoMenuListItem listItem)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400043E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UnityEvent Refreshed;

	[Token(Token = "0x400043F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public List<LocationInfoMenuListItem> List;

	[Token(Token = "0x60004F7")]
	[Address(RVA = "0x1422E6C", Offset = "0x1422E6C", VA = "0x1422E6C")]
	public string GetDefaultLocationId()
	{
		return null;
	}

	[Token(Token = "0x60004F8")]
	[Address(RVA = "0x1422EE4", Offset = "0x1422EE4", VA = "0x1422EE4")]
	public void Remove(string locationId)
	{
	}

	[Token(Token = "0x60004F9")]
	[Address(RVA = "0x14232C4", Offset = "0x14232C4", VA = "0x14232C4")]
	public LocationInfoMenuList()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D7")]
public class LocationInfoMenuListItem
{
	[Token(Token = "0x20000D8")]
	public enum TYPE
	{
		[Token(Token = "0x400044D")]
		Regular,
		[Token(Token = "0x400044E")]
		AndMore
	}

	[Token(Token = "0x4000442")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string HumanName;

	[Token(Token = "0x4000443")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool Available;

	[Token(Token = "0x4000444")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[HideInInspector]
	public TYPE Type;

	[Token(Token = "0x4000445")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public string Id;

	[Token(Token = "0x4000446")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[HideInInspector]
	public LocationInfoMenuListItemTitle[] LocalizedTitles;

	[Token(Token = "0x4000447")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool FormatEnglishTitle;

	[Token(Token = "0x4000448")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public string EnglishTitleFormating;

	[Token(Token = "0x4000449")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public bool FreeInAR;

	[Token(Token = "0x400044A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[HideInInspector]
	public int BadgeIndex;

	[Token(Token = "0x400044B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[HideInInspector]
	public Countries Country;

	[Token(Token = "0x170000DE")]
	public string Title
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x1423340", Offset = "0x1423340", VA = "0x1423340")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60004FE")]
	[Address(RVA = "0x1423548", Offset = "0x1423548", VA = "0x1423548")]
	public LocationInfoMenuListItem()
	{
	}
}
[Serializable]
[Token(Token = "0x20000D9")]
public class LocationInfoMenuListItemTitle
{
	[Token(Token = "0x400044F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x4000450")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string text;

	[Token(Token = "0x60004FF")]
	[Address(RVA = "0x1423550", Offset = "0x1423550", VA = "0x1423550")]
	public LocationInfoMenuListItemTitle(string language, string text)
	{
	}
}
[Serializable]
[Token(Token = "0x20000DA")]
public class UserSettings
{
	[Token(Token = "0x20000DB")]
	public enum COMFORT_MOVEMENT_VALUES
	{
		[Token(Token = "0x4000463")]
		Movement_Mode_Step,
		[Token(Token = "0x4000464")]
		Movement_Mode_Snap,
		[Token(Token = "0x4000465")]
		Movement_Mode_Smooth
	}

	[Token(Token = "0x20000DC")]
	public enum COMFORT_TERRAIN_FOLLOW_VALUES
	{
		[Token(Token = "0x4000467")]
		Movement_Terrain_Follow_On,
		[Token(Token = "0x4000468")]
		Movement_Terrain_Follow_Off
	}

	[Token(Token = "0x20000DD")]
	public enum COMFORT_MOVEMENTS_SPEED_VALUES
	{
		[Token(Token = "0x400046A")]
		Movement_Speed_Slow,
		[Token(Token = "0x400046B")]
		Movement_Speed_Medium,
		[Token(Token = "0x400046C")]
		Movement_Speed_Fast
	}

	[Token(Token = "0x20000DE")]
	public enum COMFORT_MOVEMENT_DIRECTION_VALUES
	{
		[Token(Token = "0x400046E")]
		Movement_Direction_Head,
		[Token(Token = "0x400046F")]
		Movement_Direction_Controller
	}

	[Token(Token = "0x20000DF")]
	public enum COMFORT_ACCELERATION_VALUES
	{
		[Token(Token = "0x4000471")]
		ON,
		[Token(Token = "0x4000472")]
		OFF
	}

	[Token(Token = "0x20000E0")]
	public enum COMFORT_SITTING_VALUES
	{
		[Token(Token = "0x4000474")]
		OFF,
		[Token(Token = "0x4000475")]
		ON
	}

	[Token(Token = "0x20000E1")]
	public enum COMFORT_TURNING_VALUES
	{
		[Token(Token = "0x4000477")]
		Turning_Mode_Step,
		[Token(Token = "0x4000478")]
		Turning_Mode_Snap,
		[Token(Token = "0x4000479")]
		Turning_Mode_Smooth
	}

	[Token(Token = "0x20000E2")]
	public enum COMFORT_TURNING_SPEED_VALUES
	{
		[Token(Token = "0x400047B")]
		Turning_Speed_Slow,
		[Token(Token = "0x400047C")]
		Turning_Speed_Medium,
		[Token(Token = "0x400047D")]
		Turning_Speed_Fast
	}

	[Token(Token = "0x20000E3")]
	public enum EXPERIENCE_LANGUAGE_VALUES
	{
		[Token(Token = "0x400047F")]
		Language_English,
		[Token(Token = "0x4000480")]
		Language_French,
		[Token(Token = "0x4000481")]
		Language_Spanish,
		[Token(Token = "0x4000482")]
		Language_Italian,
		[Token(Token = "0x4000483")]
		Language_German,
		[Token(Token = "0x4000484")]
		Language_Chinese_Simp,
		[Token(Token = "0x4000485")]
		Language_Chinese_Trad,
		[Token(Token = "0x4000486")]
		Language_Japanese,
		[Token(Token = "0x4000487")]
		Language_Korean
	}

	[Token(Token = "0x20000E4")]
	public enum EXPERIENCE_VIRTUAL_GUIDE_VALUES
	{
		[Token(Token = "0x4000489")]
		ON,
		[Token(Token = "0x400048A")]
		OFF
	}

	[Token(Token = "0x20000E5")]
	public enum EXPERIENCE_SUBTITLES_VALUES
	{
		[Token(Token = "0x400048C")]
		ON,
		[Token(Token = "0x400048D")]
		OFF
	}

	[Token(Token = "0x20000E6")]
	public enum EXPERIENCE_BOUNDARIES_VALUES
	{
		[Token(Token = "0x400048F")]
		ON,
		[Token(Token = "0x4000490")]
		OFF
	}

	[Token(Token = "0x20000E7")]
	public enum EXPERIENCE_HAPTICS_VALUES
	{
		[Token(Token = "0x4000492")]
		ON,
		[Token(Token = "0x4000493")]
		OFF
	}

	[Token(Token = "0x20000E8")]
	public enum EXPERIENCE_MUSIC_VALUES
	{
		[Token(Token = "0x4000495")]
		ON,
		[Token(Token = "0x4000496")]
		OFF
	}

	[Token(Token = "0x4000451")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static UserSettings Instance;

	[Token(Token = "0x4000452")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static UnityEvent SettingsChanged;

	[Token(Token = "0x4000453")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private COMFORT_TERRAIN_FOLLOW_VALUES ComfortTerrainFollow;

	[Token(Token = "0x4000454")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private COMFORT_MOVEMENT_VALUES ComfortMovement;

	[Token(Token = "0x4000455")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private COMFORT_MOVEMENTS_SPEED_VALUES ComfortMovementSpeed;

	[Token(Token = "0x4000456")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private COMFORT_MOVEMENT_DIRECTION_VALUES ComfortMovementDirection;

	[Token(Token = "0x4000457")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private COMFORT_TURNING_VALUES ComfortTurning;

	[Token(Token = "0x4000458")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private COMFORT_TURNING_SPEED_VALUES ComfortTurningSpeed;

	[Token(Token = "0x4000459")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private COMFORT_ACCELERATION_VALUES ComfortAcceleration;

	[Token(Token = "0x400045A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private COMFORT_SITTING_VALUES ComfortSitting;

	[Token(Token = "0x400045B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private EXPERIENCE_LANGUAGE_VALUES ExperienceLanguage;

	[Token(Token = "0x400045C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[SerializeField]
	private EXPERIENCE_VIRTUAL_GUIDE_VALUES ExperienceVirtualGuide;

	[Token(Token = "0x400045D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private EXPERIENCE_SUBTITLES_VALUES ExperienceSubtitles;

	[Token(Token = "0x400045E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private EXPERIENCE_BOUNDARIES_VALUES ExperienceBoundaries;

	[Token(Token = "0x400045F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private EXPERIENCE_HAPTICS_VALUES ExperienceHaptics;

	[Token(Token = "0x4000460")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[SerializeField]
	private EXPERIENCE_MUSIC_VALUES ExperienceMusic;

	[Token(Token = "0x4000461")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly string JsonPath;

	[Token(Token = "0x170000DF")]
	public static COMFORT_TERRAIN_FOLLOW_VALUES COMFORT_TERRAIN_FOLLOW
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0xE37C94", Offset = "0xE37C94", VA = "0xE37C94")]
		get
		{
			return default(COMFORT_TERRAIN_FOLLOW_VALUES);
		}
		[Token(Token = "0x6000505")]
		[Address(RVA = "0xE37D08", Offset = "0xE37D08", VA = "0xE37D08")]
		set
		{
		}
	}

	[Token(Token = "0x170000E0")]
	public static COMFORT_MOVEMENT_VALUES COMFORT_MOVEMENT
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0xE37DB8", Offset = "0xE37DB8", VA = "0xE37DB8")]
		get
		{
			return default(COMFORT_MOVEMENT_VALUES);
		}
		[Token(Token = "0x6000507")]
		[Address(RVA = "0xE37E2C", Offset = "0xE37E2C", VA = "0xE37E2C")]
		set
		{
		}
	}

	[Token(Token = "0x170000E1")]
	public static COMFORT_MOVEMENTS_SPEED_VALUES COMFORT_MOVEMENTS_SPEED
	{
		[Token(Token = "0x6000508")]
		[Address(RVA = "0xE37EDC", Offset = "0xE37EDC", VA = "0xE37EDC")]
		get
		{
			return default(COMFORT_MOVEMENTS_SPEED_VALUES);
		}
		[Token(Token = "0x6000509")]
		[Address(RVA = "0xE37F50", Offset = "0xE37F50", VA = "0xE37F50")]
		set
		{
		}
	}

	[Token(Token = "0x170000E2")]
	public static COMFORT_MOVEMENT_DIRECTION_VALUES COMFORT_MOVEMENT_DIRECTION
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0xE38000", Offset = "0xE38000", VA = "0xE38000")]
		get
		{
			return default(COMFORT_MOVEMENT_DIRECTION_VALUES);
		}
		[Token(Token = "0x600050B")]
		[Address(RVA = "0xE38074", Offset = "0xE38074", VA = "0xE38074")]
		set
		{
		}
	}

	[Token(Token = "0x170000E3")]
	public static COMFORT_TURNING_VALUES COMFORT_TURNING
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0xE38124", Offset = "0xE38124", VA = "0xE38124")]
		get
		{
			return default(COMFORT_TURNING_VALUES);
		}
		[Token(Token = "0x600050D")]
		[Address(RVA = "0xE38198", Offset = "0xE38198", VA = "0xE38198")]
		set
		{
		}
	}

	[Token(Token = "0x170000E4")]
	public static COMFORT_TURNING_SPEED_VALUES COMFORT_TURNING_SPEED
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0xE38248", Offset = "0xE38248", VA = "0xE38248")]
		get
		{
			return default(COMFORT_TURNING_SPEED_VALUES);
		}
		[Token(Token = "0x600050F")]
		[Address(RVA = "0xE382BC", Offset = "0xE382BC", VA = "0xE382BC")]
		set
		{
		}
	}

	[Token(Token = "0x170000E5")]
	public static COMFORT_ACCELERATION_VALUES COMFORT_ACCELERATION
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0xE3836C", Offset = "0xE3836C", VA = "0xE3836C")]
		get
		{
			return default(COMFORT_ACCELERATION_VALUES);
		}
		[Token(Token = "0x6000511")]
		[Address(RVA = "0xE383E0", Offset = "0xE383E0", VA = "0xE383E0")]
		set
		{
		}
	}

	[Token(Token = "0x170000E6")]
	public static COMFORT_SITTING_VALUES COMFORT_SITTING
	{
		[Token(Token = "0x6000512")]
		[Address(RVA = "0xE38490", Offset = "0xE38490", VA = "0xE38490")]
		get
		{
			return default(COMFORT_SITTING_VALUES);
		}
		[Token(Token = "0x6000513")]
		[Address(RVA = "0xE38504", Offset = "0xE38504", VA = "0xE38504")]
		set
		{
		}
	}

	[Token(Token = "0x170000E7")]
	public static EXPERIENCE_LANGUAGE_VALUES EXPERIENCE_LANGUAGE
	{
		[Token(Token = "0x6000514")]
		[Address(RVA = "0xE385B4", Offset = "0xE385B4", VA = "0xE385B4")]
		get
		{
			return default(EXPERIENCE_LANGUAGE_VALUES);
		}
		[Token(Token = "0x6000515")]
		[Address(RVA = "0xE38628", Offset = "0xE38628", VA = "0xE38628")]
		set
		{
		}
	}

	[Token(Token = "0x170000E8")]
	public static EXPERIENCE_VIRTUAL_GUIDE_VALUES EXPERIENCE_VIRTUAL_GUIDE
	{
		[Token(Token = "0x6000516")]
		[Address(RVA = "0xE386D8", Offset = "0xE386D8", VA = "0xE386D8")]
		get
		{
			return default(EXPERIENCE_VIRTUAL_GUIDE_VALUES);
		}
		[Token(Token = "0x6000517")]
		[Address(RVA = "0xE3874C", Offset = "0xE3874C", VA = "0xE3874C")]
		set
		{
		}
	}

	[Token(Token = "0x170000E9")]
	public static EXPERIENCE_SUBTITLES_VALUES EXPERIENCE_SUBTITLES
	{
		[Token(Token = "0x6000518")]
		[Address(RVA = "0xE387FC", Offset = "0xE387FC", VA = "0xE387FC")]
		get
		{
			return default(EXPERIENCE_SUBTITLES_VALUES);
		}
		[Token(Token = "0x6000519")]
		[Address(RVA = "0xE38870", Offset = "0xE38870", VA = "0xE38870")]
		set
		{
		}
	}

	[Token(Token = "0x170000EA")]
	public static EXPERIENCE_BOUNDARIES_VALUES EXPERIENCE_BOUNDARY_LINE
	{
		[Token(Token = "0x600051A")]
		[Address(RVA = "0xE38920", Offset = "0xE38920", VA = "0xE38920")]
		get
		{
			return default(EXPERIENCE_BOUNDARIES_VALUES);
		}
		[Token(Token = "0x600051B")]
		[Address(RVA = "0xE38994", Offset = "0xE38994", VA = "0xE38994")]
		set
		{
		}
	}

	[Token(Token = "0x170000EB")]
	public static EXPERIENCE_HAPTICS_VALUES EXPERIENCE_HAPTICS
	{
		[Token(Token = "0x600051C")]
		[Address(RVA = "0xE38A44", Offset = "0xE38A44", VA = "0xE38A44")]
		get
		{
			return default(EXPERIENCE_HAPTICS_VALUES);
		}
		[Token(Token = "0x600051D")]
		[Address(RVA = "0xE38AB8", Offset = "0xE38AB8", VA = "0xE38AB8")]
		set
		{
		}
	}

	[Token(Token = "0x170000EC")]
	public static EXPERIENCE_MUSIC_VALUES EXPERIENCE_MUSIC
	{
		[Token(Token = "0x600051E")]
		[Address(RVA = "0xE38B68", Offset = "0xE38B68", VA = "0xE38B68")]
		get
		{
			return default(EXPERIENCE_MUSIC_VALUES);
		}
		[Token(Token = "0x600051F")]
		[Address(RVA = "0xE38BDC", Offset = "0xE38BDC", VA = "0xE38BDC")]
		set
		{
		}
	}

	[Token(Token = "0x6000500")]
	[Address(RVA = "0xE37708", Offset = "0xE37708", VA = "0xE37708")]
	public static void Init()
	{
	}

	[Token(Token = "0x6000501")]
	[Address(RVA = "0xE37990", Offset = "0xE37990", VA = "0xE37990")]
	public static void ResetToDefault(bool save = true)
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0xE37AF0", Offset = "0xE37AF0", VA = "0xE37AF0")]
	public static void Save()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0xE37BE0", Offset = "0xE37BE0", VA = "0xE37BE0")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0xE37AE8", Offset = "0xE37AE8", VA = "0xE37AE8")]
	public UserSettings()
	{
	}
}
[Token(Token = "0x20000E9")]
[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[Token(Token = "0x170000ED")]
	public static bool Initialized
	{
		[Token(Token = "0x6000522")]
		[Address(RVA = "0x13934EC", Offset = "0x13934EC", VA = "0x13934EC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x13934F4", Offset = "0x13934F4", VA = "0x13934F4")]
	public SteamManager()
	{
	}
}
[Token(Token = "0x20000EA")]
public class CollisionNotifier : MonoBehaviour
{
	[Token(Token = "0x4000497")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly CollisionNotifierEvent CollisionEnterEvent;

	[Token(Token = "0x4000498")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly CollisionNotifierEvent CollisionStayEvent;

	[Token(Token = "0x4000499")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly CollisionNotifierEvent CollisionExitEvent;

	[Token(Token = "0x400049A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Collider[] IgnoreColliders;

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x15D24D4", Offset = "0x15D24D4", VA = "0x15D24D4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x15D25D8", Offset = "0x15D25D8", VA = "0x15D25D8")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x15D26DC", Offset = "0x15D26DC", VA = "0x15D26DC")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x15D27E0", Offset = "0x15D27E0", VA = "0x15D27E0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x15D2838", Offset = "0x15D2838", VA = "0x15D2838")]
	public CollisionNotifier()
	{
	}
}
[Token(Token = "0x20000EB")]
public class CollisionNotifierEvent : UnityEvent<Collision>
{
	[Token(Token = "0x6000529")]
	[Address(RVA = "0x15D28C8", Offset = "0x15D28C8", VA = "0x15D28C8")]
	public CollisionNotifierEvent()
	{
	}
}
[Token(Token = "0x20000EC")]
public class CollisionTriggerNotifier : MonoBehaviour
{
	[Token(Token = "0x400049B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly CollisionTriggerNotifierEvent TriggerEnterEvent;

	[Token(Token = "0x400049C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly CollisionTriggerNotifierEvent TriggerStayEvent;

	[Token(Token = "0x400049D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly CollisionTriggerNotifierEvent TriggerExitEvent;

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x15D2914", Offset = "0x15D2914", VA = "0x15D2914", Slot = "4")]
	protected virtual void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x15D2978", Offset = "0x15D2978", VA = "0x15D2978", Slot = "5")]
	protected virtual void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x15D29DC", Offset = "0x15D29DC", VA = "0x15D29DC", Slot = "6")]
	protected virtual void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x15D2A40", Offset = "0x15D2A40", VA = "0x15D2A40")]
	public CollisionTriggerNotifier()
	{
	}
}
[Token(Token = "0x20000ED")]
public class CollisionTriggerNotifierEvent : UnityEvent<Collider>
{
	[Token(Token = "0x600052E")]
	[Address(RVA = "0x15D2AD0", Offset = "0x15D2AD0", VA = "0x15D2AD0")]
	public CollisionTriggerNotifierEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x20000EE")]
public enum Countries
{
	[Token(Token = "0x400049F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6154", Offset = "0xAE6154")]
	AF = 1,
	[Token(Token = "0x40004A0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE618C", Offset = "0xAE618C")]
	AX,
	[Token(Token = "0x40004A1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE61C4", Offset = "0xAE61C4")]
	AL,
	[Token(Token = "0x40004A2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE61FC", Offset = "0xAE61FC")]
	DZ,
	[Token(Token = "0x40004A3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6234", Offset = "0xAE6234")]
	AS,
	[Token(Token = "0x40004A4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE626C", Offset = "0xAE626C")]
	AD,
	[Token(Token = "0x40004A5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE62A4", Offset = "0xAE62A4")]
	AO,
	[Token(Token = "0x40004A6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE62DC", Offset = "0xAE62DC")]
	AI,
	[Token(Token = "0x40004A7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6314", Offset = "0xAE6314")]
	AQ,
	[Token(Token = "0x40004A8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE634C", Offset = "0xAE634C")]
	AG,
	[Token(Token = "0x40004A9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6384", Offset = "0xAE6384")]
	AR,
	[Token(Token = "0x40004AA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE63BC", Offset = "0xAE63BC")]
	AM,
	[Token(Token = "0x40004AB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE63F4", Offset = "0xAE63F4")]
	AW,
	[Token(Token = "0x40004AC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE642C", Offset = "0xAE642C")]
	AU,
	[Token(Token = "0x40004AD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6464", Offset = "0xAE6464")]
	AT,
	[Token(Token = "0x40004AE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE649C", Offset = "0xAE649C")]
	AZ,
	[Token(Token = "0x40004AF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE64D4", Offset = "0xAE64D4")]
	BS,
	[Token(Token = "0x40004B0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE650C", Offset = "0xAE650C")]
	BH,
	[Token(Token = "0x40004B1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6544", Offset = "0xAE6544")]
	BD,
	[Token(Token = "0x40004B2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE657C", Offset = "0xAE657C")]
	BB,
	[Token(Token = "0x40004B3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE65B4", Offset = "0xAE65B4")]
	BY,
	[Token(Token = "0x40004B4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE65EC", Offset = "0xAE65EC")]
	BE,
	[Token(Token = "0x40004B5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6624", Offset = "0xAE6624")]
	BZ,
	[Token(Token = "0x40004B6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE665C", Offset = "0xAE665C")]
	BJ,
	[Token(Token = "0x40004B7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6694", Offset = "0xAE6694")]
	BM,
	[Token(Token = "0x40004B8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE66CC", Offset = "0xAE66CC")]
	BT,
	[Token(Token = "0x40004B9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6704", Offset = "0xAE6704")]
	BO,
	[Token(Token = "0x40004BA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE673C", Offset = "0xAE673C")]
	BQ,
	[Token(Token = "0x40004BB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6774", Offset = "0xAE6774")]
	BA,
	[Token(Token = "0x40004BC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE67AC", Offset = "0xAE67AC")]
	BW,
	[Token(Token = "0x40004BD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE67E4", Offset = "0xAE67E4")]
	BV,
	[Token(Token = "0x40004BE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE681C", Offset = "0xAE681C")]
	BR,
	[Token(Token = "0x40004BF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6854", Offset = "0xAE6854")]
	IO,
	[Token(Token = "0x40004C0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE688C", Offset = "0xAE688C")]
	BN,
	[Token(Token = "0x40004C1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE68C4", Offset = "0xAE68C4")]
	BG,
	[Token(Token = "0x40004C2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE68FC", Offset = "0xAE68FC")]
	BF,
	[Token(Token = "0x40004C3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6934", Offset = "0xAE6934")]
	BI,
	[Token(Token = "0x40004C4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE696C", Offset = "0xAE696C")]
	CV,
	[Token(Token = "0x40004C5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE69A4", Offset = "0xAE69A4")]
	KH,
	[Token(Token = "0x40004C6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE69DC", Offset = "0xAE69DC")]
	CM,
	[Token(Token = "0x40004C7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6A14", Offset = "0xAE6A14")]
	CA,
	[Token(Token = "0x40004C8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6A4C", Offset = "0xAE6A4C")]
	KY,
	[Token(Token = "0x40004C9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6A84", Offset = "0xAE6A84")]
	CF,
	[Token(Token = "0x40004CA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6ABC", Offset = "0xAE6ABC")]
	TD,
	[Token(Token = "0x40004CB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6AF4", Offset = "0xAE6AF4")]
	CL,
	[Token(Token = "0x40004CC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6B2C", Offset = "0xAE6B2C")]
	CN,
	[Token(Token = "0x40004CD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6B64", Offset = "0xAE6B64")]
	CX,
	[Token(Token = "0x40004CE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6B9C", Offset = "0xAE6B9C")]
	CC,
	[Token(Token = "0x40004CF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6BD4", Offset = "0xAE6BD4")]
	CO,
	[Token(Token = "0x40004D0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6C0C", Offset = "0xAE6C0C")]
	KM,
	[Token(Token = "0x40004D1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6C44", Offset = "0xAE6C44")]
	CG,
	[Token(Token = "0x40004D2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6C7C", Offset = "0xAE6C7C")]
	CD,
	[Token(Token = "0x40004D3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6CB4", Offset = "0xAE6CB4")]
	CK,
	[Token(Token = "0x40004D4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6CEC", Offset = "0xAE6CEC")]
	CR,
	[Token(Token = "0x40004D5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6D24", Offset = "0xAE6D24")]
	CI,
	[Token(Token = "0x40004D6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6D5C", Offset = "0xAE6D5C")]
	HR,
	[Token(Token = "0x40004D7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6D94", Offset = "0xAE6D94")]
	CU,
	[Token(Token = "0x40004D8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6DCC", Offset = "0xAE6DCC")]
	CW,
	[Token(Token = "0x40004D9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6E04", Offset = "0xAE6E04")]
	CY,
	[Token(Token = "0x40004DA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6E3C", Offset = "0xAE6E3C")]
	CZ,
	[Token(Token = "0x40004DB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6E74", Offset = "0xAE6E74")]
	DK,
	[Token(Token = "0x40004DC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6EAC", Offset = "0xAE6EAC")]
	DJ,
	[Token(Token = "0x40004DD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6EE4", Offset = "0xAE6EE4")]
	DM,
	[Token(Token = "0x40004DE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6F1C", Offset = "0xAE6F1C")]
	DO,
	[Token(Token = "0x40004DF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6F54", Offset = "0xAE6F54")]
	EC,
	[Token(Token = "0x40004E0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6F8C", Offset = "0xAE6F8C")]
	EG,
	[Token(Token = "0x40004E1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6FC4", Offset = "0xAE6FC4")]
	SV,
	[Token(Token = "0x40004E2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE6FFC", Offset = "0xAE6FFC")]
	GQ,
	[Token(Token = "0x40004E3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7034", Offset = "0xAE7034")]
	ER,
	[Token(Token = "0x40004E4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE706C", Offset = "0xAE706C")]
	EE,
	[Token(Token = "0x40004E5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE70A4", Offset = "0xAE70A4")]
	ET,
	[Token(Token = "0x40004E6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE70DC", Offset = "0xAE70DC")]
	FK,
	[Token(Token = "0x40004E7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7114", Offset = "0xAE7114")]
	FO,
	[Token(Token = "0x40004E8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE714C", Offset = "0xAE714C")]
	FJ,
	[Token(Token = "0x40004E9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7184", Offset = "0xAE7184")]
	FI,
	[Token(Token = "0x40004EA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE71BC", Offset = "0xAE71BC")]
	FR,
	[Token(Token = "0x40004EB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE71F4", Offset = "0xAE71F4")]
	GF,
	[Token(Token = "0x40004EC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE722C", Offset = "0xAE722C")]
	PF,
	[Token(Token = "0x40004ED")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7264", Offset = "0xAE7264")]
	TF,
	[Token(Token = "0x40004EE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE729C", Offset = "0xAE729C")]
	GA,
	[Token(Token = "0x40004EF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE72D4", Offset = "0xAE72D4")]
	GM,
	[Token(Token = "0x40004F0")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE730C", Offset = "0xAE730C")]
	GE,
	[Token(Token = "0x40004F1")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7344", Offset = "0xAE7344")]
	DE,
	[Token(Token = "0x40004F2")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE737C", Offset = "0xAE737C")]
	GH,
	[Token(Token = "0x40004F3")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE73B4", Offset = "0xAE73B4")]
	GI,
	[Token(Token = "0x40004F4")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE73EC", Offset = "0xAE73EC")]
	GR,
	[Token(Token = "0x40004F5")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7424", Offset = "0xAE7424")]
	GL,
	[Token(Token = "0x40004F6")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE745C", Offset = "0xAE745C")]
	GD,
	[Token(Token = "0x40004F7")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7494", Offset = "0xAE7494")]
	GP,
	[Token(Token = "0x40004F8")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE74CC", Offset = "0xAE74CC")]
	GU,
	[Token(Token = "0x40004F9")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7504", Offset = "0xAE7504")]
	GT,
	[Token(Token = "0x40004FA")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE753C", Offset = "0xAE753C")]
	GG,
	[Token(Token = "0x40004FB")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7574", Offset = "0xAE7574")]
	GN,
	[Token(Token = "0x40004FC")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE75AC", Offset = "0xAE75AC")]
	GW,
	[Token(Token = "0x40004FD")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE75E4", Offset = "0xAE75E4")]
	GY,
	[Token(Token = "0x40004FE")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE761C", Offset = "0xAE761C")]
	HT,
	[Token(Token = "0x40004FF")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7654", Offset = "0xAE7654")]
	HM,
	[Token(Token = "0x4000500")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE768C", Offset = "0xAE768C")]
	VA,
	[Token(Token = "0x4000501")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE76C4", Offset = "0xAE76C4")]
	HN,
	[Token(Token = "0x4000502")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE76FC", Offset = "0xAE76FC")]
	HK,
	[Token(Token = "0x4000503")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7734", Offset = "0xAE7734")]
	HU,
	[Token(Token = "0x4000504")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE776C", Offset = "0xAE776C")]
	IS,
	[Token(Token = "0x4000505")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE77A4", Offset = "0xAE77A4")]
	IN,
	[Token(Token = "0x4000506")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE77DC", Offset = "0xAE77DC")]
	ID,
	[Token(Token = "0x4000507")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7814", Offset = "0xAE7814")]
	IR,
	[Token(Token = "0x4000508")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE784C", Offset = "0xAE784C")]
	IQ,
	[Token(Token = "0x4000509")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7884", Offset = "0xAE7884")]
	IE,
	[Token(Token = "0x400050A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE78BC", Offset = "0xAE78BC")]
	IM,
	[Token(Token = "0x400050B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE78F4", Offset = "0xAE78F4")]
	IL,
	[Token(Token = "0x400050C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE792C", Offset = "0xAE792C")]
	IT,
	[Token(Token = "0x400050D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7964", Offset = "0xAE7964")]
	JM,
	[Token(Token = "0x400050E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE799C", Offset = "0xAE799C")]
	JP,
	[Token(Token = "0x400050F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE79D4", Offset = "0xAE79D4")]
	JE,
	[Token(Token = "0x4000510")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7A0C", Offset = "0xAE7A0C")]
	JO,
	[Token(Token = "0x4000511")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7A44", Offset = "0xAE7A44")]
	KZ,
	[Token(Token = "0x4000512")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7A7C", Offset = "0xAE7A7C")]
	KE,
	[Token(Token = "0x4000513")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7AB4", Offset = "0xAE7AB4")]
	KI,
	[Token(Token = "0x4000514")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7AEC", Offset = "0xAE7AEC")]
	KP,
	[Token(Token = "0x4000515")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7B24", Offset = "0xAE7B24")]
	KR,
	[Token(Token = "0x4000516")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7B5C", Offset = "0xAE7B5C")]
	KW,
	[Token(Token = "0x4000517")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7B94", Offset = "0xAE7B94")]
	KG,
	[Token(Token = "0x4000518")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7BCC", Offset = "0xAE7BCC")]
	LA,
	[Token(Token = "0x4000519")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7C04", Offset = "0xAE7C04")]
	LV,
	[Token(Token = "0x400051A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7C3C", Offset = "0xAE7C3C")]
	LB,
	[Token(Token = "0x400051B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7C74", Offset = "0xAE7C74")]
	LS,
	[Token(Token = "0x400051C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7CAC", Offset = "0xAE7CAC")]
	LR,
	[Token(Token = "0x400051D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7CE4", Offset = "0xAE7CE4")]
	LY,
	[Token(Token = "0x400051E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7D1C", Offset = "0xAE7D1C")]
	LI,
	[Token(Token = "0x400051F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7D54", Offset = "0xAE7D54")]
	LT,
	[Token(Token = "0x4000520")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7D8C", Offset = "0xAE7D8C")]
	LU,
	[Token(Token = "0x4000521")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7DC4", Offset = "0xAE7DC4")]
	MO,
	[Token(Token = "0x4000522")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7DFC", Offset = "0xAE7DFC")]
	MK,
	[Token(Token = "0x4000523")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7E34", Offset = "0xAE7E34")]
	MG,
	[Token(Token = "0x4000524")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7E6C", Offset = "0xAE7E6C")]
	MW,
	[Token(Token = "0x4000525")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7EA4", Offset = "0xAE7EA4")]
	MY,
	[Token(Token = "0x4000526")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7EDC", Offset = "0xAE7EDC")]
	MV,
	[Token(Token = "0x4000527")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7F14", Offset = "0xAE7F14")]
	ML,
	[Token(Token = "0x4000528")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7F4C", Offset = "0xAE7F4C")]
	MT,
	[Token(Token = "0x4000529")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7F84", Offset = "0xAE7F84")]
	MH,
	[Token(Token = "0x400052A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7FBC", Offset = "0xAE7FBC")]
	MQ,
	[Token(Token = "0x400052B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE7FF4", Offset = "0xAE7FF4")]
	MR,
	[Token(Token = "0x400052C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE802C", Offset = "0xAE802C")]
	MU,
	[Token(Token = "0x400052D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8064", Offset = "0xAE8064")]
	YT,
	[Token(Token = "0x400052E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE809C", Offset = "0xAE809C")]
	MX,
	[Token(Token = "0x400052F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE80D4", Offset = "0xAE80D4")]
	FM,
	[Token(Token = "0x4000530")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE810C", Offset = "0xAE810C")]
	MD,
	[Token(Token = "0x4000531")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8144", Offset = "0xAE8144")]
	MC,
	[Token(Token = "0x4000532")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE817C", Offset = "0xAE817C")]
	MN,
	[Token(Token = "0x4000533")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE81B4", Offset = "0xAE81B4")]
	ME,
	[Token(Token = "0x4000534")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE81EC", Offset = "0xAE81EC")]
	MS,
	[Token(Token = "0x4000535")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8224", Offset = "0xAE8224")]
	MA,
	[Token(Token = "0x4000536")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE825C", Offset = "0xAE825C")]
	MZ,
	[Token(Token = "0x4000537")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8294", Offset = "0xAE8294")]
	MM,
	[Token(Token = "0x4000538")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE82CC", Offset = "0xAE82CC")]
	NA,
	[Token(Token = "0x4000539")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8304", Offset = "0xAE8304")]
	NR,
	[Token(Token = "0x400053A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE833C", Offset = "0xAE833C")]
	NP,
	[Token(Token = "0x400053B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8374", Offset = "0xAE8374")]
	NL,
	[Token(Token = "0x400053C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE83AC", Offset = "0xAE83AC")]
	NC,
	[Token(Token = "0x400053D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE83E4", Offset = "0xAE83E4")]
	NZ,
	[Token(Token = "0x400053E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE841C", Offset = "0xAE841C")]
	NI,
	[Token(Token = "0x400053F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8454", Offset = "0xAE8454")]
	NE,
	[Token(Token = "0x4000540")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE848C", Offset = "0xAE848C")]
	NG,
	[Token(Token = "0x4000541")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE84C4", Offset = "0xAE84C4")]
	NU,
	[Token(Token = "0x4000542")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE84FC", Offset = "0xAE84FC")]
	NF,
	[Token(Token = "0x4000543")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8534", Offset = "0xAE8534")]
	MP,
	[Token(Token = "0x4000544")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE856C", Offset = "0xAE856C")]
	NO,
	[Token(Token = "0x4000545")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE85A4", Offset = "0xAE85A4")]
	OM,
	[Token(Token = "0x4000546")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE85DC", Offset = "0xAE85DC")]
	PK,
	[Token(Token = "0x4000547")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8614", Offset = "0xAE8614")]
	PW,
	[Token(Token = "0x4000548")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE864C", Offset = "0xAE864C")]
	PS,
	[Token(Token = "0x4000549")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8684", Offset = "0xAE8684")]
	PA,
	[Token(Token = "0x400054A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE86BC", Offset = "0xAE86BC")]
	PG,
	[Token(Token = "0x400054B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE86F4", Offset = "0xAE86F4")]
	PY,
	[Token(Token = "0x400054C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE872C", Offset = "0xAE872C")]
	PE,
	[Token(Token = "0x400054D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8764", Offset = "0xAE8764")]
	PH,
	[Token(Token = "0x400054E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE879C", Offset = "0xAE879C")]
	PN,
	[Token(Token = "0x400054F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE87D4", Offset = "0xAE87D4")]
	PL,
	[Token(Token = "0x4000550")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE880C", Offset = "0xAE880C")]
	PT,
	[Token(Token = "0x4000551")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8844", Offset = "0xAE8844")]
	PR,
	[Token(Token = "0x4000552")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE887C", Offset = "0xAE887C")]
	QA,
	[Token(Token = "0x4000553")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE88B4", Offset = "0xAE88B4")]
	RE,
	[Token(Token = "0x4000554")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE88EC", Offset = "0xAE88EC")]
	RO,
	[Token(Token = "0x4000555")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8924", Offset = "0xAE8924")]
	RU,
	[Token(Token = "0x4000556")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE895C", Offset = "0xAE895C")]
	RW,
	[Token(Token = "0x4000557")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8994", Offset = "0xAE8994")]
	BL,
	[Token(Token = "0x4000558")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE89CC", Offset = "0xAE89CC")]
	SH,
	[Token(Token = "0x4000559")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8A04", Offset = "0xAE8A04")]
	KN,
	[Token(Token = "0x400055A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8A3C", Offset = "0xAE8A3C")]
	LC,
	[Token(Token = "0x400055B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8A74", Offset = "0xAE8A74")]
	MF,
	[Token(Token = "0x400055C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8AAC", Offset = "0xAE8AAC")]
	PM,
	[Token(Token = "0x400055D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8AE4", Offset = "0xAE8AE4")]
	VC,
	[Token(Token = "0x400055E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8B1C", Offset = "0xAE8B1C")]
	WS,
	[Token(Token = "0x400055F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8B54", Offset = "0xAE8B54")]
	SM,
	[Token(Token = "0x4000560")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8B8C", Offset = "0xAE8B8C")]
	ST,
	[Token(Token = "0x4000561")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8BC4", Offset = "0xAE8BC4")]
	SA,
	[Token(Token = "0x4000562")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8BFC", Offset = "0xAE8BFC")]
	SN,
	[Token(Token = "0x4000563")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8C34", Offset = "0xAE8C34")]
	RS,
	[Token(Token = "0x4000564")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8C6C", Offset = "0xAE8C6C")]
	SC,
	[Token(Token = "0x4000565")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8CA4", Offset = "0xAE8CA4")]
	SL,
	[Token(Token = "0x4000566")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8CDC", Offset = "0xAE8CDC")]
	SG,
	[Token(Token = "0x4000567")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8D14", Offset = "0xAE8D14")]
	SX,
	[Token(Token = "0x4000568")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8D4C", Offset = "0xAE8D4C")]
	SK,
	[Token(Token = "0x4000569")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8D84", Offset = "0xAE8D84")]
	SI,
	[Token(Token = "0x400056A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8DBC", Offset = "0xAE8DBC")]
	SB,
	[Token(Token = "0x400056B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8DF4", Offset = "0xAE8DF4")]
	SO,
	[Token(Token = "0x400056C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8E2C", Offset = "0xAE8E2C")]
	ZA,
	[Token(Token = "0x400056D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8E64", Offset = "0xAE8E64")]
	GS,
	[Token(Token = "0x400056E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8E9C", Offset = "0xAE8E9C")]
	SS,
	[Token(Token = "0x400056F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8ED4", Offset = "0xAE8ED4")]
	ES,
	[Token(Token = "0x4000570")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8F0C", Offset = "0xAE8F0C")]
	LK,
	[Token(Token = "0x4000571")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8F44", Offset = "0xAE8F44")]
	SD,
	[Token(Token = "0x4000572")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8F7C", Offset = "0xAE8F7C")]
	SR,
	[Token(Token = "0x4000573")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8FB4", Offset = "0xAE8FB4")]
	SJ,
	[Token(Token = "0x4000574")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE8FEC", Offset = "0xAE8FEC")]
	SZ,
	[Token(Token = "0x4000575")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9024", Offset = "0xAE9024")]
	SE,
	[Token(Token = "0x4000576")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE905C", Offset = "0xAE905C")]
	CH,
	[Token(Token = "0x4000577")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9094", Offset = "0xAE9094")]
	SY,
	[Token(Token = "0x4000578")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE90CC", Offset = "0xAE90CC")]
	TW,
	[Token(Token = "0x4000579")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9104", Offset = "0xAE9104")]
	TJ,
	[Token(Token = "0x400057A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE913C", Offset = "0xAE913C")]
	TZ,
	[Token(Token = "0x400057B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9174", Offset = "0xAE9174")]
	TH,
	[Token(Token = "0x400057C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE91AC", Offset = "0xAE91AC")]
	TL,
	[Token(Token = "0x400057D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE91E4", Offset = "0xAE91E4")]
	TG,
	[Token(Token = "0x400057E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE921C", Offset = "0xAE921C")]
	TK,
	[Token(Token = "0x400057F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9254", Offset = "0xAE9254")]
	TO,
	[Token(Token = "0x4000580")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE928C", Offset = "0xAE928C")]
	TT,
	[Token(Token = "0x4000581")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE92C4", Offset = "0xAE92C4")]
	TN,
	[Token(Token = "0x4000582")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE92FC", Offset = "0xAE92FC")]
	TR,
	[Token(Token = "0x4000583")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9334", Offset = "0xAE9334")]
	TM,
	[Token(Token = "0x4000584")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE936C", Offset = "0xAE936C")]
	TC,
	[Token(Token = "0x4000585")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE93A4", Offset = "0xAE93A4")]
	TV,
	[Token(Token = "0x4000586")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE93DC", Offset = "0xAE93DC")]
	UG,
	[Token(Token = "0x4000587")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9414", Offset = "0xAE9414")]
	UA,
	[Token(Token = "0x4000588")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE944C", Offset = "0xAE944C")]
	AE,
	[Token(Token = "0x4000589")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9484", Offset = "0xAE9484")]
	GB,
	[Token(Token = "0x400058A")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE94BC", Offset = "0xAE94BC")]
	US,
	[Token(Token = "0x400058B")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE94F4", Offset = "0xAE94F4")]
	UM,
	[Token(Token = "0x400058C")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE952C", Offset = "0xAE952C")]
	UY,
	[Token(Token = "0x400058D")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9564", Offset = "0xAE9564")]
	UZ,
	[Token(Token = "0x400058E")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE959C", Offset = "0xAE959C")]
	VU,
	[Token(Token = "0x400058F")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE95D4", Offset = "0xAE95D4")]
	VE,
	[Token(Token = "0x4000590")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE960C", Offset = "0xAE960C")]
	VN,
	[Token(Token = "0x4000591")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9644", Offset = "0xAE9644")]
	VG,
	[Token(Token = "0x4000592")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE967C", Offset = "0xAE967C")]
	VI,
	[Token(Token = "0x4000593")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE96B4", Offset = "0xAE96B4")]
	WF,
	[Token(Token = "0x4000594")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE96EC", Offset = "0xAE96EC")]
	EH,
	[Token(Token = "0x4000595")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9724", Offset = "0xAE9724")]
	YE,
	[Token(Token = "0x4000596")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE975C", Offset = "0xAE975C")]
	ZM,
	[Token(Token = "0x4000597")]
	[AttributeAttribute(Name = "DescriptionAttribute", RVA = "0xAE9794", Offset = "0xAE9794")]
	ZW
}
[Token(Token = "0x20000EF")]
public static class ExtensionMethods
{
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4458", Offset = "0xAE4458")]
	private sealed class <>c__DisplayClass0_0
	{
		[Token(Token = "0x4000598")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<PointerEventData> listener;

		[Token(Token = "0x600053A")]
		[Address(RVA = "0xE40900", Offset = "0xE40900", VA = "0xE40900")]
		public <>c__DisplayClass0_0()
		{
		}

		[Token(Token = "0x600053B")]
		[Address(RVA = "0xE40908", Offset = "0xE40908", VA = "0xE40908")]
		internal void <AddListener>b__0(BaseEventData data)
		{
		}
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x15D6634", Offset = "0x15D6634", VA = "0x15D6634")]
	public static void AddListener(this EventTrigger trigger, EventTriggerType eventType, Action<PointerEventData> listener)
	{
	}

	[Token(Token = "0x6000530")]
	public static T GetOrAddComponent<T>(this Component child) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000531")]
	public static T GetOrAddComponent<T>(this GameObject child) where T : Component
	{
		return null;
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x15D6794", Offset = "0x15D6794", VA = "0x15D6794")]
	public static void EditorLog(this UnityEngine.Object go, string log)
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x15D1410", Offset = "0x15D1410", VA = "0x15D1410")]
	public static float Map(this float from, float fromMin, float fromMax, float toMin, float toMax)
	{
		return default(float);
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x15D689C", Offset = "0x15D689C", VA = "0x15D689C")]
	public static float MapClamp(this float from, float fromMin, float fromMax, float toMin, float toMax)
	{
		return default(float);
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x15D68C4", Offset = "0x15D68C4", VA = "0x15D68C4")]
	public static Color SetAlpha(this Color t, float v)
	{
		return default(Color);
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x15D68CC", Offset = "0x15D68CC", VA = "0x15D68CC")]
	public static Vector3 SetZ(this Vector3 t, float v)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x15D68D4", Offset = "0x15D68D4", VA = "0x15D68D4")]
	public static float Clamp0360(this float n)
	{
		return default(float);
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x15D691C", Offset = "0x15D691C", VA = "0x15D691C")]
	public static Vector3 Clamp0360(this Vector3 n)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x15D69C4", Offset = "0x15D69C4", VA = "0x15D69C4")]
	public static bool Contains(this LayerMask mask, int layer)
	{
		return default(bool);
	}
}
[Token(Token = "0x20000F1")]
[ExecuteInEditMode]
public class HideInHierarchy : MonoBehaviour
{
	[Token(Token = "0x600053C")]
	[Address(RVA = "0x15E1FA4", Offset = "0x15E1FA4", VA = "0x15E1FA4")]
	private void Start()
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x15E1FB0", Offset = "0x15E1FB0", VA = "0x15E1FB0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x15E1FBC", Offset = "0x15E1FBC", VA = "0x15E1FBC")]
	private void Update()
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x15E1FC8", Offset = "0x15E1FC8", VA = "0x15E1FC8")]
	public HideInHierarchy()
	{
	}
}
[Token(Token = "0x20000F2")]
public static class JsonHelper
{
	[Serializable]
	[Token(Token = "0x20000F3")]
	private class Wrapper<T>
	{
		[Token(Token = "0x4000599")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public T[] items;

		[Token(Token = "0x6000545")]
		public Wrapper()
		{
		}
	}

	[Token(Token = "0x6000540")]
	public static T[] FromJson<T>(string jsonArray)
	{
		return null;
	}

	[Token(Token = "0x6000541")]
	public static T[] FromJsonWrapped<T>(string jsonObject)
	{
		return null;
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x141C068", Offset = "0x141C068", VA = "0x141C068")]
	private static string WrapArray(string jsonArray)
	{
		return null;
	}

	[Token(Token = "0x6000543")]
	public static string ToJson<T>(T[] array)
	{
		return null;
	}

	[Token(Token = "0x6000544")]
	public static string ToJson<T>(T[] array, bool prettyPrint)
	{
		return null;
	}
}
[Token(Token = "0x20000F4")]
public class KonamiCodeChecker : MonoBehaviour
{
	[Token(Token = "0x400059A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly string[] KonamiSequence;

	[Token(Token = "0x400059B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private int KonamiSequenceIndex;

	[Token(Token = "0x400059C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float LastValidKonamiInput;

	[Token(Token = "0x400059D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private bool WaitForTurnThumbstickReleaseKonami;

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x141C0D0", Offset = "0x141C0D0", VA = "0x141C0D0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x141C0D4", Offset = "0x141C0D4", VA = "0x141C0D4")]
	private void CheckKonamiCode()
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x141C3F0", Offset = "0x141C3F0", VA = "0x141C3F0")]
	public KonamiCodeChecker()
	{
	}
}
[Token(Token = "0x20000F5")]
[ExecuteInEditMode]
public class MapMeshFitter : MonoBehaviour
{
	[Token(Token = "0x6000549")]
	[Address(RVA = "0xFF9AD4", Offset = "0xFF9AD4", VA = "0xFF9AD4")]
	public MapMeshFitter()
	{
	}
}
[Token(Token = "0x20000F6")]
public class MeshExtrusion
{
	[Token(Token = "0x20000F7")]
	public class Edge
	{
		[Token(Token = "0x400059E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int[] vertexIndex;

		[Token(Token = "0x400059F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int[] faceIndex;

		[Token(Token = "0x600054F")]
		[Address(RVA = "0xE49118", Offset = "0xE49118", VA = "0xE49118")]
		public Edge()
		{
		}
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0xFFAF68", Offset = "0xFFAF68", VA = "0xFFAF68")]
	public static void ExtrudeMesh(Mesh srcMesh, Mesh extrudedMesh, Matrix4x4[] extrusion, bool invertFaces)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0xFFB14C", Offset = "0xFFB14C", VA = "0xFFB14C")]
	public static void ExtrudeMesh(Mesh srcMesh, Mesh extrudedMesh, Matrix4x4[] extrusion, Edge[] edges, bool invertFaces)
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0xFFAFB0", Offset = "0xFFAFB0", VA = "0xFFAFB0")]
	public static Edge[] BuildManifoldEdges(Mesh mesh)
	{
		return null;
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0xFFB940", Offset = "0xFFB940", VA = "0xFFB940")]
	public static Edge[] BuildEdges(int vertexCount, int[] triangleArray)
	{
		return null;
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0xFFBE7C", Offset = "0xFFBE7C", VA = "0xFFBE7C")]
	public MeshExtrusion()
	{
	}
}
[Token(Token = "0x20000F8")]
public class MinMaxAttribute : PropertyAttribute
{
	[Token(Token = "0x40005A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public float minLimit;

	[Token(Token = "0x40005A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public float maxLimit;

	[Token(Token = "0x6000550")]
	[Address(RVA = "0xFFF8EC", Offset = "0xFFF8EC", VA = "0xFFF8EC")]
	public MinMaxAttribute(int min, int max)
	{
	}
}
[Token(Token = "0x20000F9")]
public static class NativeProcessHelper
{
	[Token(Token = "0x20000FA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4488", Offset = "0xAE4488")]
	private sealed class <>c__DisplayClass1_0
	{
		[Token(Token = "0x40005A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string filepath;

		[Token(Token = "0x6000554")]
		[Address(RVA = "0xE4BD18", Offset = "0xE4BD18", VA = "0xE4BD18")]
		public <>c__DisplayClass1_0()
		{
		}

		[Token(Token = "0x6000555")]
		[Address(RVA = "0xE4BD20", Offset = "0xE4BD20", VA = "0xE4BD20")]
		internal void <Execute>b__0(object sender, EventArgs args)
		{
		}
	}

	[Token(Token = "0x6000551")]
	[Address(RVA = "0x100931C", Offset = "0x100931C", VA = "0x100931C")]
	public static void Execute(string command, string workingDir = "")
	{
	}

	[Token(Token = "0x6000552")]
	[Address(RVA = "0x10093C8", Offset = "0x10093C8", VA = "0x10093C8")]
	public static void Execute(string[] commands, string workingDir = "")
	{
	}

	[Token(Token = "0x6000553")]
	[Address(RVA = "0x1009650", Offset = "0x1009650", VA = "0x1009650")]
	public static int ExecuteAndReadExitCode(string command, string workingDir = "")
	{
		return default(int);
	}
}
[Token(Token = "0x20000FB")]
public class AutoRelease : MonoBehaviour
{
	[Token(Token = "0x20000FC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4498", Offset = "0xAE4498")]
	private sealed class <Release>d__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AutoRelease <>4__this;

		[Token(Token = "0x170000EE")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600055E")]
			[Address(RVA = "0xE3F428", Offset = "0xE3F428", VA = "0xE3F428", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000EF")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000560")]
			[Address(RVA = "0xE3F470", Offset = "0xE3F470", VA = "0xE3F470", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0xE3F33C", Offset = "0xE3F33C", VA = "0xE3F33C")]
		[DebuggerHidden]
		public <Release>d__4(int <>1__state)
		{
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0xE3F368", Offset = "0xE3F368", VA = "0xE3F368", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0xE3F36C", Offset = "0xE3F36C", VA = "0xE3F36C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0xE3F430", Offset = "0xE3F430", VA = "0xE3F430", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float delay;

	[Token(Token = "0x6000556")]
	[Address(RVA = "0x1193CB4", Offset = "0x1193CB4", VA = "0x1193CB4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000557")]
	[Address(RVA = "0x1193E04", Offset = "0x1193E04", VA = "0x1193E04")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000558")]
	[Address(RVA = "0x1193E0C", Offset = "0x1193E0C", VA = "0x1193E0C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000559")]
	[Address(RVA = "0x1193D98", Offset = "0x1193D98", VA = "0x1193D98")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECCE4", Offset = "0xAECCE4")]
	private IEnumerator Release()
	{
		return null;
	}

	[Token(Token = "0x600055A")]
	[Address(RVA = "0x1193E14", Offset = "0x1193E14", VA = "0x1193E14")]
	public AutoRelease()
	{
	}
}
[Token(Token = "0x20000FD")]
public class PoolManager : Singleton<PoolManager>
{
	[Token(Token = "0x20000FE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE44A8", Offset = "0xAE44A8")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40005AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public PoolManager <>4__this;

		[Token(Token = "0x40005AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public GameObject prefab;

		[Token(Token = "0x40005AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool initialWarmUp;

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x1673BF4", Offset = "0x1673BF4", VA = "0x1673BF4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x1673BFC", Offset = "0x1673BFC", VA = "0x1673BFC")]
		internal GameObject <warmPool>b__0()
		{
			return null;
		}
	}

	[Token(Token = "0x40005A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public bool logStatus;

	[Token(Token = "0x40005A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform root;

	[Token(Token = "0x40005A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<GameObject, ObjectPool<GameObject>> prefabLookup;

	[Token(Token = "0x40005AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<GameObject, ObjectPool<GameObject>> instanceLookup;

	[Token(Token = "0x40005AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool dirty;

	[Token(Token = "0x6000561")]
	[Address(RVA = "0x108D634", Offset = "0x108D634", VA = "0x108D634")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000562")]
	[Address(RVA = "0x108D710", Offset = "0x108D710", VA = "0x108D710")]
	private void Update()
	{
	}

	[Token(Token = "0x6000563")]
	[Address(RVA = "0x108D9C0", Offset = "0x108D9C0", VA = "0x108D9C0")]
	public void warmPool(GameObject prefab, int size, bool initialWarmUp = false)
	{
	}

	[Token(Token = "0x6000564")]
	[Address(RVA = "0x108DB44", Offset = "0x108DB44", VA = "0x108DB44")]
	public void clearPool(GameObject prefab)
	{
	}

	[Token(Token = "0x6000565")]
	[Address(RVA = "0x108DBE0", Offset = "0x108DBE0", VA = "0x108DBE0")]
	public GameObject spawnObject(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x6000566")]
	[Address(RVA = "0x108DC60", Offset = "0x108DC60", VA = "0x108DC60")]
	public GameObject spawnObject(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x6000567")]
	[Address(RVA = "0x108DF44", Offset = "0x108DF44", VA = "0x108DF44")]
	public void releaseObject(GameObject clone)
	{
	}

	[Token(Token = "0x6000568")]
	[Address(RVA = "0x108E154", Offset = "0x108E154", VA = "0x108E154")]
	private GameObject InstantiatePrefab(GameObject prefab, bool Inactive = false)
	{
		return null;
	}

	[Token(Token = "0x6000569")]
	[Address(RVA = "0x108D748", Offset = "0x108D748", VA = "0x108D748")]
	public void PrintStatus()
	{
	}

	[Token(Token = "0x600056A")]
	[Address(RVA = "0x108DED8", Offset = "0x108DED8", VA = "0x108DED8")]
	public static void WarmPool(GameObject prefab, int size)
	{
	}

	[Token(Token = "0x600056B")]
	[Address(RVA = "0x108E234", Offset = "0x108E234", VA = "0x108E234")]
	public static GameObject SpawnObject(GameObject prefab)
	{
		return null;
	}

	[Token(Token = "0x600056C")]
	[Address(RVA = "0x108E28C", Offset = "0x108E28C", VA = "0x108E28C")]
	public static GameObject SpawnObject(GameObject prefab, Vector3 position, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600056D")]
	[Address(RVA = "0x108E33C", Offset = "0x108E33C", VA = "0x108E33C")]
	public static void ReleaseObject(GameObject clone)
	{
	}

	[Token(Token = "0x600056E")]
	[Address(RVA = "0x108E394", Offset = "0x108E394", VA = "0x108E394")]
	public PoolManager()
	{
	}
}
[Token(Token = "0x20000FF")]
public class PoolableObject : MonoBehaviour
{
	[Token(Token = "0x40005AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int InstanciateOnStart;

	[Token(Token = "0x40005B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int MaxInstances;

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x108E3E0", Offset = "0x108E3E0", VA = "0x108E3E0")]
	public PoolableObject()
	{
	}
}
[Token(Token = "0x2000100")]
public class ReleaseWithDelay : MonoBehaviour
{
	[Token(Token = "0x2000101")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE44B8", Offset = "0xAE44B8")]
	private sealed class <Release>d__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40005B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40005B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40005B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ReleaseWithDelay <>4__this;

		[Token(Token = "0x170000F0")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x16757C8", Offset = "0x16757C8", VA = "0x16757C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F1")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x1675810", Offset = "0x1675810", VA = "0x1675810", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x16756DC", Offset = "0x16756DC", VA = "0x16756DC")]
		[DebuggerHidden]
		public <Release>d__2(int <>1__state)
		{
		}

		[Token(Token = "0x6000576")]
		[Address(RVA = "0x1675708", Offset = "0x1675708", VA = "0x1675708", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000577")]
		[Address(RVA = "0x167570C", Offset = "0x167570C", VA = "0x167570C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x16757D0", Offset = "0x16757D0", VA = "0x16757D0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Delay;

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x138C3F8", Offset = "0x138C3F8", VA = "0x138C3F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x138C424", Offset = "0x138C424", VA = "0x138C424")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECD94", Offset = "0xAECD94")]
	private IEnumerator Release()
	{
		return null;
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x138C490", Offset = "0x138C490", VA = "0x138C490")]
	public ReleaseWithDelay()
	{
	}
}
[Token(Token = "0x2000102")]
public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	[Token(Token = "0x40005B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static T instance;

	[Token(Token = "0x170000F2")]
	public static T Instance
	{
		[Token(Token = "0x600057B")]
		get
		{
			return null;
		}
		[Token(Token = "0x600057C")]
		set
		{
		}
	}

	[Token(Token = "0x600057D")]
	public Singleton()
	{
	}
}
[Serializable]
[Token(Token = "0x2000103")]
public class SceneReference : ISerializationCallbackReceiver
{
	[Token(Token = "0x40005B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private string scenePath;

	[Token(Token = "0x170000F3")]
	public string ScenePath
	{
		[Token(Token = "0x600057E")]
		[Address(RVA = "0x138CD10", Offset = "0x138CD10", VA = "0x138CD10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600057F")]
		[Address(RVA = "0x138CD18", Offset = "0x138CD18", VA = "0x138CD18")]
		set
		{
		}
	}

	[Token(Token = "0x6000580")]
	[Address(RVA = "0x138CD20", Offset = "0x138CD20", VA = "0x138CD20")]
	public static implicit operator string(SceneReference sceneReference)
	{
		return null;
	}

	[Token(Token = "0x6000581")]
	[Address(RVA = "0x138CD38", Offset = "0x138CD38", VA = "0x138CD38", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x6000582")]
	[Address(RVA = "0x138CD3C", Offset = "0x138CD3C", VA = "0x138CD3C", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x6000583")]
	[Address(RVA = "0x138CD40", Offset = "0x138CD40", VA = "0x138CD40")]
	public SceneReference()
	{
	}
}
[Token(Token = "0x2000104")]
public class SetRenderQueue : MonoBehaviour
{
	[Token(Token = "0x40005B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int RenderQueue;

	[Token(Token = "0x40005B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Renderer[] Renderers;

	[Token(Token = "0x40005B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int NumChildren;

	[Token(Token = "0x6000584")]
	[Address(RVA = "0x138CD9C", Offset = "0x138CD9C", VA = "0x138CD9C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000585")]
	[Address(RVA = "0x138CE14", Offset = "0x138CE14", VA = "0x138CE14")]
	private void Update()
	{
	}

	[Token(Token = "0x6000586")]
	[Address(RVA = "0x138CDA0", Offset = "0x138CDA0", VA = "0x138CDA0")]
	private void GetRenderers()
	{
	}

	[Token(Token = "0x6000587")]
	[Address(RVA = "0x138CEE0", Offset = "0x138CEE0", VA = "0x138CEE0")]
	private void ApplyRenderqueue()
	{
	}

	[Token(Token = "0x6000588")]
	[Address(RVA = "0x138CF9C", Offset = "0x138CF9C", VA = "0x138CF9C")]
	public SetRenderQueue()
	{
	}
}
[Token(Token = "0x2000105")]
public class SetRenderQueueInChildren : MonoBehaviour
{
	[Token(Token = "0x40005BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Renderer[] _Renderers;

	[Token(Token = "0x170000F4")]
	private IEnumerable<Renderer> Renderers
	{
		[Token(Token = "0x6000589")]
		[Address(RVA = "0x138CFB0", Offset = "0x138CFB0", VA = "0x138CFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600058A")]
	[Address(RVA = "0x138D01C", Offset = "0x138D01C", VA = "0x138D01C")]
	public void SetRenderQueue(int v)
	{
	}

	[Token(Token = "0x600058B")]
	[Address(RVA = "0x138D300", Offset = "0x138D300", VA = "0x138D300")]
	public SetRenderQueueInChildren()
	{
	}
}
[Token(Token = "0x2000106")]
public class SimpleCameraController : MonoBehaviour
{
	[Token(Token = "0x2000107")]
	private class CameraState
	{
		[Token(Token = "0x40005C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float yaw;

		[Token(Token = "0x40005C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public float pitch;

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float roll;

		[Token(Token = "0x40005C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float x;

		[Token(Token = "0x40005C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float y;

		[Token(Token = "0x40005C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public float z;

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x1675D3C", Offset = "0x1675D3C", VA = "0x1675D3C")]
		public void SetFromTransform(Transform t)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x1675DC4", Offset = "0x1675DC4", VA = "0x1675DC4")]
		public void Translate(Vector3 translation)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x1675E40", Offset = "0x1675E40", VA = "0x1675E40")]
		public void LerpTowards(CameraState target, float positionLerpPct, float rotationLerpPct)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x1675F08", Offset = "0x1675F08", VA = "0x1675F08")]
		public void UpdateTransform(Transform t)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x1675F54", Offset = "0x1675F54", VA = "0x1675F54")]
		public CameraState()
		{
		}
	}

	[Token(Token = "0x40005BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private CameraState m_TargetCameraState;

	[Token(Token = "0x40005BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private CameraState m_InterpolatingCameraState;

	[Token(Token = "0x40005BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE97DC", Offset = "0xAE97DC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE97DC", Offset = "0xAE97DC")]
	public float boost;

	[Token(Token = "0x40005BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE983C", Offset = "0xAE983C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE983C", Offset = "0xAE983C")]
	public float positionLerpTime;

	[Token(Token = "0x40005BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9894", Offset = "0xAE9894")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9894", Offset = "0xAE9894")]
	public AnimationCurve mouseSensitivityCurve;

	[Token(Token = "0x40005C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE98F4", Offset = "0xAE98F4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE98F4", Offset = "0xAE98F4")]
	public float rotationLerpTime;

	[Token(Token = "0x40005C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE994C", Offset = "0xAE994C")]
	public bool invertY;

	[Token(Token = "0x600058C")]
	[Address(RVA = "0x138E07C", Offset = "0x138E07C", VA = "0x138E07C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600058D")]
	[Address(RVA = "0x138E0DC", Offset = "0x138E0DC", VA = "0x138E0DC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600058E")]
	[Address(RVA = "0x138E100", Offset = "0x138E100", VA = "0x138E100")]
	private Vector3 GetInputTranslationDirection()
	{
		return default(Vector3);
	}

	[Token(Token = "0x600058F")]
	[Address(RVA = "0x138E214", Offset = "0x138E214", VA = "0x138E214")]
	private void Update()
	{
	}

	[Token(Token = "0x6000590")]
	[Address(RVA = "0x138E490", Offset = "0x138E490", VA = "0x138E490")]
	public SimpleCameraController()
	{
	}
}
[Token(Token = "0x2000108")]
public class StringUtils
{
	[Serializable]
	[Token(Token = "0x2000109")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE44C8", Offset = "0xAE44C8")]
	private sealed class <>c
	{
		[Token(Token = "0x40005C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x40005C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<string, string, string> <>9__1_0;

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x1676CB4", Offset = "0x1676CB4", VA = "0x1676CB4")]
		public <>c()
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x1676CBC", Offset = "0x1676CBC", VA = "0x1676CBC")]
		internal string <CamelCaseNoSpace>b__1_0(string current, string segment)
		{
			return null;
		}
	}

	[Token(Token = "0x6000596")]
	[Address(RVA = "0x13934FC", Offset = "0x13934FC", VA = "0x13934FC")]
	public static string UppercaseFirst(string s)
	{
		return null;
	}

	[Token(Token = "0x6000597")]
	[Address(RVA = "0x13935F8", Offset = "0x13935F8", VA = "0x13935F8")]
	public static string CamelCaseNoSpace(string s)
	{
		return null;
	}

	[Token(Token = "0x6000598")]
	[Address(RVA = "0x13937CC", Offset = "0x13937CC", VA = "0x13937CC")]
	public static string ReplaceAll(string input, char target, char replace)
	{
		return null;
	}

	[Token(Token = "0x6000599")]
	[Address(RVA = "0x1393860", Offset = "0x1393860", VA = "0x1393860")]
	public static string ReplaceAll(string input, string target, string replace)
	{
		return null;
	}

	[Token(Token = "0x600059A")]
	[Address(RVA = "0x13938C8", Offset = "0x13938C8", VA = "0x13938C8")]
	public StringUtils()
	{
	}
}
[Token(Token = "0x200010A")]
public class Timer
{
	[Token(Token = "0x200010B")]
	private class TimerManager : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200010C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE44D8", Offset = "0xAE44D8")]
		private sealed class <>c
		{
			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x40005DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Predicate<Timer> <>9__7_0;

			[Token(Token = "0x60005C5")]
			[Address(RVA = "0x167C7C4", Offset = "0x167C7C4", VA = "0x167C7C4")]
			public <>c()
			{
			}

			[Token(Token = "0x60005C6")]
			[Address(RVA = "0x167C7CC", Offset = "0x167C7CC", VA = "0x167C7CC")]
			internal bool <UpdateAllTimers>b__7_0(Timer t)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x40005D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<Timer> _timers;

		[Token(Token = "0x40005D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private List<Timer> _timersToAdd;

		[Token(Token = "0x60005BD")]
		[Address(RVA = "0x1677444", Offset = "0x1677444", VA = "0x1677444")]
		public void RegisterTimer(Timer timer)
		{
		}

		[Token(Token = "0x60005BE")]
		[Address(RVA = "0x16774A8", Offset = "0x16774A8", VA = "0x16774A8")]
		public void CancelAllTimers()
		{
		}

		[Token(Token = "0x60005BF")]
		[Address(RVA = "0x1677620", Offset = "0x1677620", VA = "0x1677620")]
		public void PauseAllTimers()
		{
		}

		[Token(Token = "0x60005C0")]
		[Address(RVA = "0x1677738", Offset = "0x1677738", VA = "0x1677738")]
		public void ResumeAllTimers()
		{
		}

		[Token(Token = "0x60005C1")]
		[Address(RVA = "0x1677850", Offset = "0x1677850", VA = "0x1677850")]
		[AttributeAttribute(Name = "UsedImplicitlyAttribute", RVA = "0xAECEC4", Offset = "0xAECEC4")]
		private void Update()
		{
		}

		[Token(Token = "0x60005C2")]
		[Address(RVA = "0x1677854", Offset = "0x1677854", VA = "0x1677854")]
		private void UpdateAllTimers()
		{
		}

		[Token(Token = "0x60005C3")]
		[Address(RVA = "0x1677AC8", Offset = "0x1677AC8", VA = "0x1677AC8")]
		public TimerManager()
		{
		}
	}

	[Token(Token = "0x40005CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9984", Offset = "0xAE9984")]
	private float <duration>k__BackingField;

	[Token(Token = "0x40005CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9994", Offset = "0xAE9994")]
	private bool <isLooped>k__BackingField;

	[Token(Token = "0x40005CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE99A4", Offset = "0xAE99A4")]
	private bool <isCompleted>k__BackingField;

	[Token(Token = "0x40005CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x16")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE99B4", Offset = "0xAE99B4")]
	private bool <usesRealTime>k__BackingField;

	[Token(Token = "0x40005CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static TimerManager _manager;

	[Token(Token = "0x40005CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Action _onComplete;

	[Token(Token = "0x40005D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly Action<float> _onUpdate;

	[Token(Token = "0x40005D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private float _startTime;

	[Token(Token = "0x40005D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	private float _lastUpdateTime;

	[Token(Token = "0x40005D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float? _timeElapsedBeforeCancel;

	[Token(Token = "0x40005D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private float? _timeElapsedBeforePause;

	[Token(Token = "0x40005D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly MonoBehaviour _autoDestroyOwner;

	[Token(Token = "0x40005D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly bool _hasAutoDestroyOwner;

	[Token(Token = "0x170000F5")]
	public float duration
	{
		[Token(Token = "0x600059E")]
		[Address(RVA = "0x1398F60", Offset = "0x1398F60", VA = "0x1398F60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE44", Offset = "0xAECE44")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600059F")]
		[Address(RVA = "0x1398F68", Offset = "0x1398F68", VA = "0x1398F68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE54", Offset = "0xAECE54")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F6")]
	public bool isLooped
	{
		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x1398F70", Offset = "0x1398F70", VA = "0x1398F70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE64", Offset = "0xAECE64")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x1398F78", Offset = "0x1398F78", VA = "0x1398F78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE74", Offset = "0xAECE74")]
		set
		{
		}
	}

	[Token(Token = "0x170000F7")]
	public bool isCompleted
	{
		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x1398F84", Offset = "0x1398F84", VA = "0x1398F84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE84", Offset = "0xAECE84")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x1398F8C", Offset = "0x1398F8C", VA = "0x1398F8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECE94", Offset = "0xAECE94")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F8")]
	public bool usesRealTime
	{
		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x1398F98", Offset = "0x1398F98", VA = "0x1398F98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECEA4", Offset = "0xAECEA4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x1398FA0", Offset = "0x1398FA0", VA = "0x1398FA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECEB4", Offset = "0xAECEB4")]
		private set
		{
		}
	}

	[Token(Token = "0x170000F9")]
	public bool isPaused
	{
		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x1398FAC", Offset = "0x1398FAC", VA = "0x1398FAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FA")]
	public bool isCancelled
	{
		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x1398FEC", Offset = "0x1398FEC", VA = "0x1398FEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FB")]
	public bool isDone
	{
		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x139902C", Offset = "0x139902C", VA = "0x139902C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FC")]
	private bool isOwnerDestroyed
	{
		[Token(Token = "0x60005B7")]
		[Address(RVA = "0x139908C", Offset = "0x139908C", VA = "0x139908C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60005A9")]
	[Address(RVA = "0x1399110", Offset = "0x1399110", VA = "0x1399110")]
	public static Timer Register(float duration, Action onComplete, [Optional] Action<float> onUpdate, bool isLooped = false, bool useRealTime = false, [Optional] MonoBehaviour autoDestroyOwner)
	{
		return null;
	}

	[Token(Token = "0x60005AA")]
	[Address(RVA = "0x13993D8", Offset = "0x13993D8", VA = "0x13993D8")]
	public static void Cancel(Timer timer)
	{
	}

	[Token(Token = "0x60005AB")]
	[Address(RVA = "0x139945C", Offset = "0x139945C", VA = "0x139945C")]
	public static void Pause(Timer timer)
	{
	}

	[Token(Token = "0x60005AC")]
	[Address(RVA = "0x1399508", Offset = "0x1399508", VA = "0x1399508")]
	public static void Resume(Timer timer)
	{
	}

	[Token(Token = "0x60005AD")]
	[Address(RVA = "0x1399568", Offset = "0x1399568", VA = "0x1399568")]
	public static void CancelAllRegisteredTimers()
	{
	}

	[Token(Token = "0x60005AE")]
	[Address(RVA = "0x1399618", Offset = "0x1399618", VA = "0x1399618")]
	public static void PauseAllRegisteredTimers()
	{
	}

	[Token(Token = "0x60005AF")]
	[Address(RVA = "0x13996C8", Offset = "0x13996C8", VA = "0x13996C8")]
	public static void ResumeAllRegisteredTimers()
	{
	}

	[Token(Token = "0x60005B0")]
	[Address(RVA = "0x13993E4", Offset = "0x13993E4", VA = "0x13993E4")]
	public void Cancel()
	{
	}

	[Token(Token = "0x60005B1")]
	[Address(RVA = "0x1399468", Offset = "0x1399468", VA = "0x1399468")]
	public void Pause()
	{
	}

	[Token(Token = "0x60005B2")]
	[Address(RVA = "0x1399514", Offset = "0x1399514", VA = "0x1399514")]
	public void Resume()
	{
	}

	[Token(Token = "0x60005B3")]
	[Address(RVA = "0x1399778", Offset = "0x1399778", VA = "0x1399778")]
	public float GetTimeElapsed()
	{
		return default(float);
	}

	[Token(Token = "0x60005B4")]
	[Address(RVA = "0x1399870", Offset = "0x1399870", VA = "0x1399870")]
	public float GetTimeRemaining()
	{
		return default(float);
	}

	[Token(Token = "0x60005B5")]
	[Address(RVA = "0x1399894", Offset = "0x1399894", VA = "0x1399894")]
	public float GetRatioComplete()
	{
		return default(float);
	}

	[Token(Token = "0x60005B6")]
	[Address(RVA = "0x13998BC", Offset = "0x13998BC", VA = "0x13998BC")]
	public float GetRatioRemaining()
	{
		return default(float);
	}

	[Token(Token = "0x60005B8")]
	[Address(RVA = "0x13992E8", Offset = "0x13992E8", VA = "0x13992E8")]
	private Timer(float duration, Action onComplete, Action<float> onUpdate, bool isLooped, bool usesRealTime, MonoBehaviour autoDestroyOwner)
	{
	}

	[Token(Token = "0x60005B9")]
	[Address(RVA = "0x1399848", Offset = "0x1399848", VA = "0x1399848")]
	private float GetWorldTime()
	{
		return default(float);
	}

	[Token(Token = "0x60005BA")]
	[Address(RVA = "0x1399860", Offset = "0x1399860", VA = "0x1399860")]
	private float GetFireTime()
	{
		return default(float);
	}

	[Token(Token = "0x60005BB")]
	[Address(RVA = "0x13998F4", Offset = "0x13998F4", VA = "0x13998F4")]
	private float GetTimeDelta()
	{
		return default(float);
	}

	[Token(Token = "0x60005BC")]
	[Address(RVA = "0x1399934", Offset = "0x1399934", VA = "0x1399934")]
	private void Update()
	{
	}
}
[Token(Token = "0x200010D")]
public static class TimerExtensions
{
	[Token(Token = "0x60005C7")]
	[Address(RVA = "0x1399A98", Offset = "0x1399A98", VA = "0x1399A98")]
	public static Timer AttachTimer(this MonoBehaviour behaviour, float duration, Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x60005C8")]
	[Address(RVA = "0x1399AB0", Offset = "0x1399AB0", VA = "0x1399AB0")]
	public static Timer AttachTimer(this MonoBehaviour behaviour, float duration, Action onComplete, [Optional] Action<float> onUpdate, bool isLooped = false, bool useRealTime = false)
	{
		return null;
	}

	[Token(Token = "0x60005C9")]
	[Address(RVA = "0x1399ACC", Offset = "0x1399ACC", VA = "0x1399ACC")]
	public static Timer AttachTimer(this MonoBehaviour behaviour, float duration, Action onComplete, bool isLooped = false, bool useRealTime = false)
	{
		return null;
	}
}
[Serializable]
[Token(Token = "0x200010E")]
public class UDateTime : ISerializationCallbackReceiver
{
	[Token(Token = "0x40005DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[HideInInspector]
	public DateTime dateTime;

	[Token(Token = "0x40005DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	[SerializeField]
	private string _dateTime;

	[Token(Token = "0x60005CA")]
	[Address(RVA = "0xE35B08", Offset = "0xE35B08", VA = "0xE35B08")]
	public static implicit operator DateTime(UDateTime udt)
	{
		return default(DateTime);
	}

	[Token(Token = "0x60005CB")]
	[Address(RVA = "0xE35B20", Offset = "0xE35B20", VA = "0xE35B20")]
	public static implicit operator UDateTime(DateTime dt)
	{
		return null;
	}

	[Token(Token = "0x60005CC")]
	[Address(RVA = "0xE35B90", Offset = "0xE35B90", VA = "0xE35B90", Slot = "5")]
	public void OnAfterDeserialize()
	{
	}

	[Token(Token = "0x60005CD")]
	[Address(RVA = "0xE35C00", Offset = "0xE35C00", VA = "0xE35C00", Slot = "4")]
	public void OnBeforeSerialize()
	{
	}

	[Token(Token = "0x60005CE")]
	[Address(RVA = "0xE35B88", Offset = "0xE35B88", VA = "0xE35B88")]
	public UDateTime()
	{
	}
}
[Token(Token = "0x200010F")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xAE44F8", Offset = "0xAE44F8")]
public class BrinkPlayerVR : BrinkPlayer
{
	[Token(Token = "0x2000110")]
	[Flags]
	public enum ActionFlags
	{
		[Token(Token = "0x40005FA")]
		NONE = 0,
		[Token(Token = "0x40005FB")]
		ALL = 0xBFA,
		[Token(Token = "0x40005FC")]
		CompassGrab = 2,
		[Token(Token = "0x40005FD")]
		CompassRelease = 8,
		[Token(Token = "0x40005FE")]
		NotepadGrab = 0x18,
		[Token(Token = "0x40005FF")]
		NotepadRelease = 0x40,
		[Token(Token = "0x4000600")]
		Menu = 0xA0,
		[Token(Token = "0x4000601")]
		TeleportersEnabled = 0x180,
		[Token(Token = "0x4000602")]
		POIsEnabled = 0x380,
		[Token(Token = "0x4000603")]
		PhotoShoot = 0x800
	}

	[Token(Token = "0x2000111")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE451C", Offset = "0xAE451C")]
	private sealed class <>c__DisplayClass52_0
	{
		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public BrinkPlayerVR <>4__this;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public SpotController spot;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool keepPlayerCurrentOrientation;

		[Token(Token = "0x4000607")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool fromTeleporter;

		[Token(Token = "0x600061B")]
		[Address(RVA = "0xE3FFC8", Offset = "0xE3FFC8", VA = "0xE3FFC8")]
		public <>c__DisplayClass52_0()
		{
		}

		[Token(Token = "0x600061C")]
		[Address(RVA = "0xE3FFD0", Offset = "0xE3FFD0", VA = "0xE3FFD0")]
		internal void <TeleportTo>b__0()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000112")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE452C", Offset = "0xAE452C")]
	private sealed class <>c
	{
		[Token(Token = "0x4000608")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000609")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Action <>9__75_1;

		[Token(Token = "0x600061E")]
		[Address(RVA = "0xE3FF74", Offset = "0xE3FF74", VA = "0xE3FF74")]
		public <>c()
		{
		}

		[Token(Token = "0x600061F")]
		[Address(RVA = "0xE3FF7C", Offset = "0xE3FF7C", VA = "0xE3FF7C")]
		internal void <OnWatchNightModeButtonSelected>b__75_1()
		{
		}
	}

	[Token(Token = "0x2000113")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE453C", Offset = "0xAE453C")]
	private sealed class <CheckIfCollidingWithAvatarCo>d__85 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400060A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400060B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400060C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400060D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public BrinkPlayerVR <>4__this;

		[Token(Token = "0x17000108")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000623")]
			[Address(RVA = "0xE4031C", Offset = "0xE4031C", VA = "0xE4031C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000109")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000625")]
			[Address(RVA = "0xE40364", Offset = "0xE40364", VA = "0xE40364", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000620")]
		[Address(RVA = "0xE40004", Offset = "0xE40004", VA = "0xE40004")]
		[DebuggerHidden]
		public <CheckIfCollidingWithAvatarCo>d__85(int <>1__state)
		{
		}

		[Token(Token = "0x6000621")]
		[Address(RVA = "0xE40030", Offset = "0xE40030", VA = "0xE40030", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000622")]
		[Address(RVA = "0xE40034", Offset = "0xE40034", VA = "0xE40034", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000624")]
		[Address(RVA = "0xE40324", Offset = "0xE40324", VA = "0xE40324", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000114")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE454C", Offset = "0xAE454C")]
	private sealed class <<OnSystemRecenter>g__Recenter|81_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400060E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400060F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000610")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrinkPlayerVR <>4__this;

		[Token(Token = "0x1700010A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000629")]
			[Address(RVA = "0xE3FEC4", Offset = "0xE3FEC4", VA = "0xE3FEC4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700010B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600062B")]
			[Address(RVA = "0xE3FF0C", Offset = "0xE3FF0C", VA = "0xE3FF0C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000626")]
		[Address(RVA = "0xE3FCAC", Offset = "0xE3FCAC", VA = "0xE3FCAC")]
		[DebuggerHidden]
		public <<OnSystemRecenter>g__Recenter|81_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x6000627")]
		[Address(RVA = "0xE3FCD8", Offset = "0xE3FCD8", VA = "0xE3FCD8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000628")]
		[Address(RVA = "0xE3FCDC", Offset = "0xE3FCDC", VA = "0xE3FCDC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600062A")]
		[Address(RVA = "0xE3FECC", Offset = "0xE3FECC", VA = "0xE3FECC", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40005DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly Color SCREENFADE_COLOR;

	[Token(Token = "0x40005DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9A0C", Offset = "0xAE9A0C")]
	public BrinkHand RightHand;

	[Token(Token = "0x40005DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public BrinkHand LeftHand;

	[Token(Token = "0x40005E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public BrinkHandPoseManager HandPoseManager;

	[Token(Token = "0x40005E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Watch Watch;

	[Token(Token = "0x40005E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AppMenuVR AppMenu;

	[Token(Token = "0x40005E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MultiplayerMenu MultiplayerMenu;

	[Token(Token = "0x40005E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public PostcardManager PostcardManager;

	[Token(Token = "0x40005E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Notepad Notepad;

	[Token(Token = "0x40005E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Compass Compass;

	[Token(Token = "0x40005E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public NotificationVR Notification;

	[Token(Token = "0x40005E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public AlignWithCameraPivot Traveling;

	[Token(Token = "0x40005E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public OutsideOfBoundsVR OutsideOfBounds;

	[Token(Token = "0x40005EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public GameObject NotepadHandIcon;

	[Token(Token = "0x40005EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public GameObject CompassHandIcon;

	[Token(Token = "0x40005EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public GameObject ForceLargeTexturesLoadDummy;

	[Token(Token = "0x40005ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Camera MenuCamera;

	[Token(Token = "0x40005EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public LayerMask DefaultCameraMask;

	[Token(Token = "0x40005EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	public LayerMask MenuCameraMask;

	[Token(Token = "0x40005F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private VRRig Rig;

	[Token(Token = "0x40005F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool AppHasFocus;

	[Token(Token = "0x40005F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE9")]
	private bool PreventCompassGrab;

	[Token(Token = "0x40005F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private float AppResetStartTime;

	[Token(Token = "0x40005F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private UniversalAdditionalCameraData UniversalAdditionalCameraData;

	[Token(Token = "0x40005F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool PostProcessingEnabled;

	[Token(Token = "0x40005F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private float CollidingWithMeshStartTime;

	[Token(Token = "0x40005F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static ActionFlags ActionStates;

	[Token(Token = "0x40005F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private int ForceLargeTexturesLoadDummyCount;

	[Token(Token = "0x170000FD")]
	protected override bool AllowMenuOpen
	{
		[Token(Token = "0x60005F1")]
		[Address(RVA = "0x119E514", Offset = "0x119E514", VA = "0x119E514", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FE")]
	private bool AllowToolGrab
	{
		[Token(Token = "0x60005F2")]
		[Address(RVA = "0x119E5D4", Offset = "0x119E5D4", VA = "0x119E5D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170000FF")]
	private bool AllowCompassGrab
	{
		[Token(Token = "0x60005F3")]
		[Address(RVA = "0x119CD60", Offset = "0x119CD60", VA = "0x119CD60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000100")]
	private bool AllowNotepadGrab
	{
		[Token(Token = "0x60005F4")]
		[Address(RVA = "0x119CCA8", Offset = "0x119CCA8", VA = "0x119CCA8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000101")]
	public static Transform RigTransform
	{
		[Token(Token = "0x600060C")]
		[Address(RVA = "0x1194CEC", Offset = "0x1194CEC", VA = "0x1194CEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000102")]
	public static BrinkHand HandRight
	{
		[Token(Token = "0x600060D")]
		[Address(RVA = "0x119F394", Offset = "0x119F394", VA = "0x119F394")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000103")]
	public static BrinkHand HandLeft
	{
		[Token(Token = "0x600060E")]
		[Address(RVA = "0x119F484", Offset = "0x119F484", VA = "0x119F484")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000104")]
	public static Transform HandRightTransform
	{
		[Token(Token = "0x600060F")]
		[Address(RVA = "0x1196D1C", Offset = "0x1196D1C", VA = "0x1196D1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000105")]
	public static Transform HandLeftTransform
	{
		[Token(Token = "0x6000610")]
		[Address(RVA = "0x1194F48", Offset = "0x1194F48", VA = "0x1194F48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000106")]
	public static Transform LeftHandPalmTransform
	{
		[Token(Token = "0x6000611")]
		[Address(RVA = "0x119F574", Offset = "0x119F574", VA = "0x119F574")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000107")]
	public static Transform RightHandPalmTransform
	{
		[Token(Token = "0x6000612")]
		[Address(RVA = "0x119F674", Offset = "0x119F674", VA = "0x119F674")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60005CF")]
	[Address(RVA = "0x119B8A0", Offset = "0x119B8A0", VA = "0x119B8A0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60005D0")]
	[Address(RVA = "0x119BD04", Offset = "0x119BD04", VA = "0x119BD04", Slot = "5")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60005D1")]
	[Address(RVA = "0x119BF0C", Offset = "0x119BF0C", VA = "0x119BF0C")]
	private void UpdateTexts()
	{
	}

	[Token(Token = "0x60005D2")]
	[Address(RVA = "0x119C070", Offset = "0x119C070", VA = "0x119C070")]
	private void Update()
	{
	}

	[Token(Token = "0x60005D3")]
	[Address(RVA = "0x119D074", Offset = "0x119D074", VA = "0x119D074")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60005D4")]
	[Address(RVA = "0x119D138", Offset = "0x119D138", VA = "0x119D138", Slot = "8")]
	public override float HideCurrentLocation()
	{
		return default(float);
	}

	[Token(Token = "0x60005D5")]
	[Address(RVA = "0x119D2F8", Offset = "0x119D2F8", VA = "0x119D2F8", Slot = "9")]
	public override void MoveToSpawnPosition(Transform spawnPosition)
	{
	}

	[Token(Token = "0x60005D6")]
	[Address(RVA = "0x119D3A0", Offset = "0x119D3A0", VA = "0x119D3A0", Slot = "10")]
	public override void RevealLocation()
	{
	}

	[Token(Token = "0x60005D7")]
	[Address(RVA = "0x119D824", Offset = "0x119D824", VA = "0x119D824")]
	public void OnGripPress(InputDevice device)
	{
	}

	[Token(Token = "0x60005D8")]
	[Address(RVA = "0x119D934", Offset = "0x119D934", VA = "0x119D934")]
	public void SetGripRight(float v)
	{
	}

	[Token(Token = "0x60005D9")]
	[Address(RVA = "0x119DA1C", Offset = "0x119DA1C", VA = "0x119DA1C")]
	public void SetGripLeft(float v)
	{
	}

	[Token(Token = "0x60005DA")]
	[Address(RVA = "0x119DB08", Offset = "0x119DB08", VA = "0x119DB08")]
	public void SetTriggerRight(float v)
	{
	}

	[Token(Token = "0x60005DB")]
	[Address(RVA = "0x119DB30", Offset = "0x119DB30", VA = "0x119DB30")]
	public void SetTriggerLeft(float v)
	{
	}

	[Token(Token = "0x60005DC")]
	[Address(RVA = "0x119DB58", Offset = "0x119DB58", VA = "0x119DB58")]
	public void OnTriggerPress(InputDevice device)
	{
	}

	[Token(Token = "0x60005DD")]
	[Address(RVA = "0x119DB74", Offset = "0x119DB74", VA = "0x119DB74")]
	public void OnAppMenuButtonPress(InputDevice device)
	{
	}

	[Token(Token = "0x60005DE")]
	[Address(RVA = "0x119DBC0", Offset = "0x119DBC0", VA = "0x119DBC0")]
	public void OnMultiplayerButtonPress(InputDevice device)
	{
	}

	[Token(Token = "0x60005DF")]
	[Address(RVA = "0x119DC0C", Offset = "0x119DC0C", VA = "0x119DC0C")]
	public void OnAnyJoystickButtonBegin(InputDevice device)
	{
	}

	[Token(Token = "0x60005E0")]
	[Address(RVA = "0x119DC84", Offset = "0x119DC84", VA = "0x119DC84")]
	public void OnAnyMenuButtonPress(InputDevice device)
	{
	}

	[Token(Token = "0x60005E1")]
	[Address(RVA = "0x119DE4C", Offset = "0x119DE4C", VA = "0x119DE4C")]
	private void OnWatchLocationsMenuButtonSelected(ButtonBase button)
	{
	}

	[Token(Token = "0x60005E2")]
	[Address(RVA = "0x119DE98", Offset = "0x119DE98", VA = "0x119DE98")]
	private void OnWatchAppMenuButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60005E3")]
	[Address(RVA = "0x119DCD0", Offset = "0x119DCD0", VA = "0x119DCD0")]
	private void MenuButtonPressed(string source)
	{
	}

	[Token(Token = "0x60005E4")]
	[Address(RVA = "0x119DEE4", Offset = "0x119DEE4", VA = "0x119DEE4")]
	private void OnCompassGrabbed()
	{
	}

	[Token(Token = "0x60005E5")]
	[Address(RVA = "0x119DEEC", Offset = "0x119DEEC", VA = "0x119DEEC")]
	private void OnCompassReleased()
	{
	}

	[Token(Token = "0x60005E6")]
	[Address(RVA = "0x119DEF4", Offset = "0x119DEF4", VA = "0x119DEF4", Slot = "21")]
	protected override void TeleportTo(SpotController spot, bool keepPlayerCurrentOrientation, bool fromTeleporter = true)
	{
	}

	[Token(Token = "0x60005E7")]
	[Address(RVA = "0x119E09C", Offset = "0x119E09C", VA = "0x119E09C", Slot = "22")]
	protected override void WarpToSpot(SpotController spot, bool keepPlayerCurrentOrientation, bool fromTeleporter)
	{
	}

	[Token(Token = "0x60005E8")]
	[Address(RVA = "0x119E148", Offset = "0x119E148", VA = "0x119E148", Slot = "11")]
	protected override void OnOverlayBeforeOpening()
	{
	}

	[Token(Token = "0x60005E9")]
	[Address(RVA = "0x119E174", Offset = "0x119E174", VA = "0x119E174", Slot = "12")]
	protected override void OnOverlayOpening()
	{
	}

	[Token(Token = "0x60005EA")]
	[Address(RVA = "0x119E1B8", Offset = "0x119E1B8", VA = "0x119E1B8", Slot = "13")]
	protected override void OnOverlayClosing()
	{
	}

	[Token(Token = "0x60005EB")]
	[Address(RVA = "0x119E20C", Offset = "0x119E20C", VA = "0x119E20C", Slot = "14")]
	protected override void OnMarkerPoitingEnter(Marker marker)
	{
	}

	[Token(Token = "0x60005EC")]
	[Address(RVA = "0x119E234", Offset = "0x119E234", VA = "0x119E234", Slot = "15")]
	protected override void OnMarkerPoitingStay(Marker marker)
	{
	}

	[Token(Token = "0x60005ED")]
	[Address(RVA = "0x119E338", Offset = "0x119E338", VA = "0x119E338", Slot = "19")]
	protected override void OnPOIMarkerTriggered(POIMarker marker, bool justFound, POIPopupObjectHighlight objectHighlight)
	{
	}

	[Token(Token = "0x60005EE")]
	[Address(RVA = "0x119E3A0", Offset = "0x119E3A0", VA = "0x119E3A0", Slot = "20")]
	protected override void OnTeleportMarkerTriggered(TeleportMarker marker)
	{
	}

	[Token(Token = "0x60005EF")]
	[Address(RVA = "0x119E3CC", Offset = "0x119E3CC", VA = "0x119E3CC", Slot = "18")]
	protected override void OnMarkerClicked(Marker marker)
	{
	}

	[Token(Token = "0x60005F0")]
	[Address(RVA = "0x119E454", Offset = "0x119E454", VA = "0x119E454", Slot = "16")]
	protected override void OnTriggerFlashFx()
	{
	}

	[Token(Token = "0x60005F5")]
	[Address(RVA = "0x119C7A4", Offset = "0x119C7A4", VA = "0x119C7A4")]
	private void SetAllowFlags()
	{
	}

	[Token(Token = "0x60005F6")]
	[Address(RVA = "0x119CAD8", Offset = "0x119CAD8", VA = "0x119CAD8")]
	private void ShowOutsideOfBoundsIfNeeded()
	{
	}

	[Token(Token = "0x60005F7")]
	[Address(RVA = "0x119E740", Offset = "0x119E740", VA = "0x119E740")]
	private void OnNotificationRequestFadeOverlay()
	{
	}

	[Token(Token = "0x60005F8")]
	[Address(RVA = "0x119E780", Offset = "0x119E780", VA = "0x119E780")]
	private void OnNotificationClosedWithFadeOverlay()
	{
	}

	[Token(Token = "0x60005F9")]
	[Address(RVA = "0x119E81C", Offset = "0x119E81C", VA = "0x119E81C")]
	private void OnWatchNightModeButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60005FA")]
	[Address(RVA = "0x119E988", Offset = "0x119E988", VA = "0x119E988")]
	private void OnWatchMultiplayerButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60005FB")]
	[Address(RVA = "0x119D294", Offset = "0x119D294", VA = "0x119D294")]
	public static void DeactivateAllActions()
	{
	}

	[Token(Token = "0x60005FC")]
	[Address(RVA = "0x119D5E0", Offset = "0x119D5E0", VA = "0x119D5E0")]
	public static void AllowAllActions()
	{
	}

	[Token(Token = "0x60005FD")]
	[Address(RVA = "0x119E9A4", Offset = "0x119E9A4", VA = "0x119E9A4")]
	public static void ActivateActionFlag(ActionFlags flag)
	{
	}

	[Token(Token = "0x60005FE")]
	[Address(RVA = "0x119EA14", Offset = "0x119EA14", VA = "0x119EA14")]
	public static void DeactivateActionFlag(ActionFlags flag)
	{
	}

	[Token(Token = "0x60005FF")]
	[Address(RVA = "0x119EA84", Offset = "0x119EA84", VA = "0x119EA84")]
	public void OnSystemRecenter()
	{
	}

	[Token(Token = "0x6000600")]
	[Address(RVA = "0x119E67C", Offset = "0x119E67C", VA = "0x119E67C")]
	public static bool IsActionEnabled(ActionFlags flag)
	{
		return default(bool);
	}

	[Token(Token = "0x6000601")]
	[Address(RVA = "0x119D648", Offset = "0x119D648", VA = "0x119D648")]
	private void InitForCurrentSpot(float screenFadeTime, float screenFadeDelay = 0f, bool keepPlayerCurrentOrientation = false)
	{
	}

	[Token(Token = "0x6000602")]
	[Address(RVA = "0x119F0A0", Offset = "0x119F0A0", VA = "0x119F0A0")]
	private void OnRoomJoined()
	{
	}

	[Token(Token = "0x6000603")]
	[Address(RVA = "0x119F0D0", Offset = "0x119F0D0", VA = "0x119F0D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECF04", Offset = "0xAECF04")]
	private IEnumerator CheckIfCollidingWithAvatarCo(float delay = 0f)
	{
		return null;
	}

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x119EB1C", Offset = "0x119EB1C", VA = "0x119EB1C")]
	private Transform FindSpawnPosition()
	{
		return null;
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x119CE0C", Offset = "0x119CE0C", VA = "0x119CE0C")]
	private void EnablePostProcessingIfNeeded()
	{
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x119D980", Offset = "0x119D980", VA = "0x119D980")]
	private void RightHandRelease()
	{
	}

	[Token(Token = "0x6000607")]
	[Address(RVA = "0x119DA68", Offset = "0x119DA68", VA = "0x119DA68")]
	private void LeftHandRelease()
	{
	}

	[Token(Token = "0x6000608")]
	[Address(RVA = "0x119F14C", Offset = "0x119F14C", VA = "0x119F14C")]
	private void OnRigTeleported()
	{
	}

	[Token(Token = "0x6000609")]
	[Address(RVA = "0x119CF78", Offset = "0x119CF78", VA = "0x119CF78")]
	private void CheckAppReset()
	{
	}

	[Token(Token = "0x600060A")]
	[Address(RVA = "0x119F19C", Offset = "0x119F19C", VA = "0x119F19C")]
	public void OnAppFocusOut()
	{
	}

	[Token(Token = "0x600060B")]
	[Address(RVA = "0x119F2A4", Offset = "0x119F2A4", VA = "0x119F2A4")]
	public void OnAppFocusIn()
	{
	}

	[Token(Token = "0x6000613")]
	[Address(RVA = "0x119F774", Offset = "0x119F774", VA = "0x119F774")]
	public static void SetNightMode(bool v)
	{
	}

	[Token(Token = "0x6000614")]
	[Address(RVA = "0x119F844", Offset = "0x119F844", VA = "0x119F844")]
	public BrinkPlayerVR()
	{
	}

	[Token(Token = "0x6000616")]
	[Address(RVA = "0x119F8E8", Offset = "0x119F8E8", VA = "0x119F8E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECF64", Offset = "0xAECF64")]
	private void <HideCurrentLocation>b__34_0()
	{
	}

	[Token(Token = "0x6000617")]
	[Address(RVA = "0x119F9EC", Offset = "0x119F9EC", VA = "0x119F9EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECF74", Offset = "0xAECF74")]
	private void <OnTriggerFlashFx>b__62_0()
	{
	}

	[Token(Token = "0x6000618")]
	[Address(RVA = "0x119FA1C", Offset = "0x119FA1C", VA = "0x119FA1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECF84", Offset = "0xAECF84")]
	private void <OnWatchNightModeButtonSelected>b__75_0()
	{
	}

	[Token(Token = "0x6000619")]
	[Address(RVA = "0x119EAB0", Offset = "0x119EAB0", VA = "0x119EAB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAECF94", Offset = "0xAECF94")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAECF94", Offset = "0xAECF94")]
	private IEnumerator <OnSystemRecenter>g__Recenter|81_0()
	{
		return null;
	}

	[Token(Token = "0x600061A")]
	[Address(RVA = "0x119FB34", Offset = "0x119FB34", VA = "0x119FB34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED004", Offset = "0xAED004")]
	private void <InitForCurrentSpot>b__83_0()
	{
	}
}
[Token(Token = "0x2000115")]
[SelectionBase]
public class BrinkHand : MonoBehaviour
{
	[Token(Token = "0x4000611")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public XRNode XRNode;

	[Token(Token = "0x4000612")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform IndexFingerTip;

	[Token(Token = "0x4000613")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform NotificationLinePoint;

	[Token(Token = "0x4000614")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9A44", Offset = "0xAE9A44")]
	private float <Grip>k__BackingField;

	[Token(Token = "0x4000615")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9A54", Offset = "0xAE9A54")]
	private Vector3 <RealWorldRigSpaceVelocity>k__BackingField;

	[Token(Token = "0x4000616")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UnityEvent GrabEvent;

	[Token(Token = "0x4000617")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private VRRig Rig;

	[Token(Token = "0x4000618")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private BrinkHandVisual Visual;

	[Token(Token = "0x4000619")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private BrinkHandHaptics Haptics;

	[Token(Token = "0x400061A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HandPhysics Physics;

	[Token(Token = "0x400061B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private PressButton InteractingButton;

	[Token(Token = "0x400061C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 PositionOnInteractingButtonSelected;

	[Token(Token = "0x400061D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private float LastButtonCollisionStayTime;

	[Token(Token = "0x400061E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 PositionOffset;

	[Token(Token = "0x400061F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector3 RotationOffset;

	[Token(Token = "0x1700010C")]
	public bool IsHoldingObject
	{
		[Token(Token = "0x600062C")]
		[Address(RVA = "0x1196E24", Offset = "0x1196E24", VA = "0x1196E24")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010D")]
	public bool NearPhysicalObject
	{
		[Token(Token = "0x600062D")]
		[Address(RVA = "0x1196E98", Offset = "0x1196E98", VA = "0x1196E98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700010E")]
	public Transform PalmTransform
	{
		[Token(Token = "0x600062E")]
		[Address(RVA = "0x1196EB4", Offset = "0x1196EB4", VA = "0x1196EB4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700010F")]
	public float Grip
	{
		[Token(Token = "0x600062F")]
		[Address(RVA = "0x1196ED0", Offset = "0x1196ED0", VA = "0x1196ED0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED0B4", Offset = "0xAED0B4")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000630")]
		[Address(RVA = "0x1196ED8", Offset = "0x1196ED8", VA = "0x1196ED8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED0C4", Offset = "0xAED0C4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000110")]
	public Vector3 RealWorldRigSpaceVelocity
	{
		[Token(Token = "0x6000632")]
		[Address(RVA = "0x1196EEC", Offset = "0x1196EEC", VA = "0x1196EEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED0E4", Offset = "0xAED0E4")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x6000631")]
		[Address(RVA = "0x1196EE0", Offset = "0x1196EE0", VA = "0x1196EE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED0D4", Offset = "0xAED0D4")]
		private set
		{
		}
	}

	[Token(Token = "0x6000633")]
	[Address(RVA = "0x1196EF8", Offset = "0x1196EF8", VA = "0x1196EF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000634")]
	[Address(RVA = "0x1197044", Offset = "0x1197044", VA = "0x1197044")]
	private void Start()
	{
	}

	[Token(Token = "0x6000635")]
	[Address(RVA = "0x11970CC", Offset = "0x11970CC", VA = "0x11970CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000636")]
	[Address(RVA = "0x1197728", Offset = "0x1197728", VA = "0x1197728")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000637")]
	[Address(RVA = "0x119790C", Offset = "0x119790C", VA = "0x119790C")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x6000638")]
	[Address(RVA = "0x1197A30", Offset = "0x1197A30", VA = "0x1197A30")]
	public void Grab()
	{
	}

	[Token(Token = "0x6000639")]
	[Address(RVA = "0x1197A6C", Offset = "0x1197A6C", VA = "0x1197A6C")]
	public void Release()
	{
	}

	[Token(Token = "0x600063A")]
	[Address(RVA = "0x1197A88", Offset = "0x1197A88", VA = "0x1197A88")]
	public float SetGrip(float grip)
	{
		return default(float);
	}

	[Token(Token = "0x600063B")]
	[Address(RVA = "0x1197AE8", Offset = "0x1197AE8", VA = "0x1197AE8")]
	public void SetTrigger(float v)
	{
	}

	[Token(Token = "0x600063C")]
	[Address(RVA = "0x1197B04", Offset = "0x1197B04", VA = "0x1197B04")]
	public void ForceGrab(Grabbable grabbable)
	{
	}

	[Token(Token = "0x600063D")]
	[Address(RVA = "0x1197BAC", Offset = "0x1197BAC", VA = "0x1197BAC")]
	public void SetIntentPose(BrinkHandPoseData pose)
	{
	}

	[Token(Token = "0x600063E")]
	[Address(RVA = "0x1197BC8", Offset = "0x1197BC8", VA = "0x1197BC8")]
	public void CancelIntentPose(BrinkHandPoseData pose)
	{
	}

	[Token(Token = "0x600063F")]
	[Address(RVA = "0x1197BE4", Offset = "0x1197BE4", VA = "0x1197BE4")]
	public void SendHapticImpulse(float amplitude)
	{
	}

	[Token(Token = "0x6000640")]
	[Address(RVA = "0x1197D08", Offset = "0x1197D08", VA = "0x1197D08")]
	public Vector3 GetRelativeVelocity(Transform parent)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000641")]
	[Address(RVA = "0x1197D38", Offset = "0x1197D38", VA = "0x1197D38")]
	public void Snap()
	{
	}

	[Token(Token = "0x6000642")]
	[Address(RVA = "0x1197D54", Offset = "0x1197D54", VA = "0x1197D54")]
	private void OnObjectGrabbed(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x6000643")]
	[Address(RVA = "0x1197EB0", Offset = "0x1197EB0", VA = "0x1197EB0")]
	private void OnInteractingButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x6000644")]
	[Address(RVA = "0x1197FA4", Offset = "0x1197FA4", VA = "0x1197FA4")]
	public BrinkHand()
	{
	}
}
[Token(Token = "0x2000116")]
public class BrinkHandHaptics : MonoBehaviour
{
	[Token(Token = "0x4000620")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private XRNode XRNode;

	[Token(Token = "0x4000621")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Rigidbody Rigidbody;

	[Token(Token = "0x6000645")]
	[Address(RVA = "0x1198040", Offset = "0x1198040", VA = "0x1198040")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000646")]
	[Address(RVA = "0x11980C4", Offset = "0x11980C4", VA = "0x11980C4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000647")]
	[Address(RVA = "0x119818C", Offset = "0x119818C", VA = "0x119818C")]
	private void OnCollisionStay(Collision collision)
	{
	}

	[Token(Token = "0x6000648")]
	[Address(RVA = "0x1197BFC", Offset = "0x1197BFC", VA = "0x1197BFC")]
	public void SendHapticImpulse(float amplitude)
	{
	}

	[Token(Token = "0x6000649")]
	[Address(RVA = "0x1198400", Offset = "0x1198400", VA = "0x1198400")]
	public BrinkHandHaptics()
	{
	}
}
[Token(Token = "0x2000117")]
public class BrinkHandIcon : MonoBehaviour
{
	[Token(Token = "0x2000118")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE456C", Offset = "0xAE456C")]
	private sealed class <ShowGrabText>d__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BrinkHandIcon <>4__this;

		[Token(Token = "0x17000111")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000654")]
			[Address(RVA = "0xE3FB64", Offset = "0xE3FB64", VA = "0xE3FB64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000112")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000656")]
			[Address(RVA = "0xE3FBAC", Offset = "0xE3FBAC", VA = "0xE3FBAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000651")]
		[Address(RVA = "0xE3F9F4", Offset = "0xE3F9F4", VA = "0xE3F9F4")]
		[DebuggerHidden]
		public <ShowGrabText>d__8(int <>1__state)
		{
		}

		[Token(Token = "0x6000652")]
		[Address(RVA = "0xE3FA20", Offset = "0xE3FA20", VA = "0xE3FA20", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000653")]
		[Address(RVA = "0xE3FA24", Offset = "0xE3FA24", VA = "0xE3FA24", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000655")]
		[Address(RVA = "0xE3FB6C", Offset = "0xE3FB6C", VA = "0xE3FB6C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000622")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer Icon;

	[Token(Token = "0x4000623")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro GrabText;

	[Token(Token = "0x4000624")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 IconDefaultScale;

	[Token(Token = "0x600064A")]
	[Address(RVA = "0x1198408", Offset = "0x1198408", VA = "0x1198408")]
	private void Awake()
	{
	}

	[Token(Token = "0x600064B")]
	[Address(RVA = "0x119844C", Offset = "0x119844C", VA = "0x119844C")]
	private void Start()
	{
	}

	[Token(Token = "0x600064C")]
	[Address(RVA = "0x119847C", Offset = "0x119847C", VA = "0x119847C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600064D")]
	[Address(RVA = "0x1198720", Offset = "0x1198720", VA = "0x1198720")]
	private void Update()
	{
	}

	[Token(Token = "0x600064E")]
	[Address(RVA = "0x1198850", Offset = "0x1198850", VA = "0x1198850")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600064F")]
	[Address(RVA = "0x11986B4", Offset = "0x11986B4", VA = "0x11986B4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED0F4", Offset = "0xAED0F4")]
	private IEnumerator ShowGrabText()
	{
		return null;
	}

	[Token(Token = "0x6000650")]
	[Address(RVA = "0x1198894", Offset = "0x1198894", VA = "0x1198894")]
	public BrinkHandIcon()
	{
	}
}
[Token(Token = "0x2000119")]
public class BrinkHandIntentPoseTrigger : CollisionTriggerNotifier
{
	[Token(Token = "0x4000628")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAE9A64", Offset = "0xAE9A64")]
	public BrinkHandPoseData PoseDataRight;

	[Token(Token = "0x4000629")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public BrinkHandPoseData PoseDataLeft;

	[Token(Token = "0x400062A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool DisableAllCollidersExceptIndex;

	[Token(Token = "0x400062B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private HandPhysics HandPhysics;

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x119889C", Offset = "0x119889C", VA = "0x119889C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x1198914", Offset = "0x1198914", VA = "0x1198914", Slot = "5")]
	protected override void OnTriggerStay(Collider c)
	{
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x1198AAC", Offset = "0x1198AAC", VA = "0x1198AAC", Slot = "6")]
	protected override void OnTriggerExit(Collider c)
	{
	}

	[Token(Token = "0x600065A")]
	[Address(RVA = "0x1198B70", Offset = "0x1198B70", VA = "0x1198B70")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600065B")]
	[Address(RVA = "0x1198B80", Offset = "0x1198B80", VA = "0x1198B80")]
	public BrinkHandIntentPoseTrigger()
	{
	}
}
[Token(Token = "0x200011A")]
[AttributeAttribute(Name = "CreateAssetMenuAttribute", RVA = "0xAE457C", Offset = "0xAE457C")]
public class BrinkHandPoseData : ScriptableObject
{
	[Token(Token = "0x400062C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Vector3[] PosePositions;

	[Token(Token = "0x400062D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Quaternion[] PoseRotations;

	[Token(Token = "0x400062E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public bool Relative;

	[Token(Token = "0x400062F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public Vector3 HandOffset;

	[Token(Token = "0x4000630")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Vector3 RotationOffset;

	[Token(Token = "0x600065C")]
	[Address(RVA = "0x1198B88", Offset = "0x1198B88", VA = "0x1198B88")]
	public BrinkHandPoseData()
	{
	}
}
[Token(Token = "0x200011B")]
public class BrinkHandPoseManager : MonoBehaviour
{
	[Token(Token = "0x4000631")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrinkHand RightHand;

	[Token(Token = "0x4000632")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BrinkHand LeftHand;

	[Token(Token = "0x4000633")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9A9C", Offset = "0xAE9A9C")]
	public BrinkHandPoseData HandPoseCameraRight;

	[Token(Token = "0x4000634")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public BrinkHandPoseData HandPoseCameraLeft;

	[Token(Token = "0x4000635")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9AD4", Offset = "0xAE9AD4")]
	private bool <AllowGestures>k__BackingField;

	[Token(Token = "0x4000636")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9AE4", Offset = "0xAE9AE4")]
	private bool <DoingCameraGesture>k__BackingField;

	[Token(Token = "0x4000637")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9AF4", Offset = "0xAE9AF4")]
	private bool <ValidHandPositionForNotepad>k__BackingField;

	[Token(Token = "0x4000638")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE9B04", Offset = "0xAE9B04")]
	private bool <ValidHandPositionForCompass>k__BackingField;

	[Token(Token = "0x4000639")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static int DoingPointingGestureRightCount;

	[Token(Token = "0x400063A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static int DoingPointingGestureLeftCount;

	[Token(Token = "0x17000113")]
	public bool AllowGestures
	{
		[Token(Token = "0x600065D")]
		[Address(RVA = "0x1198B98", Offset = "0x1198B98", VA = "0x1198B98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1A4", Offset = "0xAED1A4")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x600065E")]
		[Address(RVA = "0x1198BA0", Offset = "0x1198BA0", VA = "0x1198BA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1B4", Offset = "0xAED1B4")]
		set
		{
		}
	}

	[Token(Token = "0x17000114")]
	public bool DoingCameraGesture
	{
		[Token(Token = "0x600065F")]
		[Address(RVA = "0x1198BAC", Offset = "0x1198BAC", VA = "0x1198BAC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1C4", Offset = "0xAED1C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000660")]
		[Address(RVA = "0x1198BB4", Offset = "0x1198BB4", VA = "0x1198BB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1D4", Offset = "0xAED1D4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000115")]
	public bool ValidHandPositionForNotepad
	{
		[Token(Token = "0x6000661")]
		[Address(RVA = "0x1198BC0", Offset = "0x1198BC0", VA = "0x1198BC0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1E4", Offset = "0xAED1E4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000662")]
		[Address(RVA = "0x1198BC8", Offset = "0x1198BC8", VA = "0x1198BC8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED1F4", Offset = "0xAED1F4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000116")]
	public bool ValidHandPositionForCompass
	{
		[Token(Token = "0x6000663")]
		[Address(RVA = "0x1198BD4", Offset = "0x1198BD4", VA = "0x1198BD4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED204", Offset = "0xAED204")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000664")]
		[Address(RVA = "0x1198BDC", Offset = "0x1198BDC", VA = "0x1198BDC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED214", Offset = "0xAED214")]
		private set
		{
		}
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x1198BE8", Offset = "0x1198BE8", VA = "0x1198BE8")]
	private void Update()
	{
	}

	[Token(Token = "0x6000666")]
	[Address(RVA = "0x1198CD0", Offset = "0x1198CD0", VA = "0x1198CD0")]
	private void UpdateDoingCameraGesture()
	{
	}

	[Token(Token = "0x6000667")]
	[Address(RVA = "0x1199380", Offset = "0x1199380", VA = "0x1199380")]
	private void UpdateLeftHandIconAllowed()
	{
	}

	[Token(Token = "0x6000668")]
	[Address(RVA = "0x1199434", Offset = "0x1199434", VA = "0x1199434")]
	private void UpdateRightHandIconAllowed()
	{
	}

	[Token(Token = "0x6000669")]
	[Address(RVA = "0x11994E8", Offset = "0x11994E8", VA = "0x11994E8")]
	private static bool ApproximatelyEqual(float a, float b, float threshold)
	{
		return default(bool);
	}

	[Token(Token = "0x600066A")]
	[Address(RVA = "0x1199504", Offset = "0x1199504", VA = "0x1199504")]
	public BrinkHandPoseManager()
	{
	}
}
[Token(Token = "0x200011C")]
public sealed class BrinkHandVisual : MonoBehaviour
{
	[Token(Token = "0x400063B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SkinnedMeshRenderer HandModelRenderer;

	[Token(Token = "0x400063C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Material HandColorMaterial;

	[Token(Token = "0x400063D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Color OriginalColor;

	[Token(Token = "0x400063E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color OriginalRimColor;

	[Token(Token = "0x400063F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Color NightColor;

	[Token(Token = "0x4000640")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Color MenuColor;

	[Token(Token = "0x4000641")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Color NightRimColor;

	[Token(Token = "0x4000642")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int BASECOLOR;

	[Token(Token = "0x4000643")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static readonly int RIMCOLOR;

	[Token(Token = "0x17000117")]
	public bool FullOpacity
	{
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x1197410", Offset = "0x1197410", VA = "0x1197410")]
		set
		{
		}
	}

	[Token(Token = "0x600066B")]
	[Address(RVA = "0x119950C", Offset = "0x119950C", VA = "0x119950C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600066C")]
	[Address(RVA = "0x11996A4", Offset = "0x11996A4", VA = "0x11996A4")]
	private void OnInputFocusAcquired()
	{
	}

	[Token(Token = "0x600066D")]
	[Address(RVA = "0x11996C4", Offset = "0x11996C4", VA = "0x11996C4")]
	private void OnInputFocusLost()
	{
	}

	[Token(Token = "0x600066F")]
	[Address(RVA = "0x11996E4", Offset = "0x11996E4", VA = "0x11996E4")]
	public BrinkHandVisual()
	{
	}
}
[Token(Token = "0x200011D")]
public class Finger : MonoBehaviour
{
	[Token(Token = "0x200011E")]
	public enum FingerType
	{
		[Token(Token = "0x4000650")]
		THUMB,
		[Token(Token = "0x4000651")]
		INDEX,
		[Token(Token = "0x4000652")]
		MIDDLE,
		[Token(Token = "0x4000653")]
		RING,
		[Token(Token = "0x4000654")]
		PINKY
	}

	[StructLayout(3)]
	[Token(Token = "0x200011F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE45CC", Offset = "0xAE45CC")]
	private struct <>c__DisplayClass17_0
	{
		[Token(Token = "0x4000655")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int i;
	}

	[Token(Token = "0x4000644")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public FingerType Type;

	[Token(Token = "0x4000645")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9B14", Offset = "0xAE9B14")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9B14", Offset = "0xAE9B14")]
	public Transform tip;

	[Token(Token = "0x4000646")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9B74", Offset = "0xAE9B74")]
	public float tipRadius;

	[Token(Token = "0x4000647")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0xAE9BAC", Offset = "0xAE9BAC")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9BAC", Offset = "0xAE9BAC")]
	public float bendOffset;

	[Token(Token = "0x4000648")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float currBendOffset;

	[Token(Token = "0x4000649")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private float bend;

	[Token(Token = "0x400064A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	[SerializeField]
	private Quaternion[] minGripRotPose;

	[Token(Token = "0x400064B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	[HideInInspector]
	private Vector3[] minGripPosPose;

	[Token(Token = "0x400064C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	[HideInInspector]
	private Quaternion[] maxGripRotPose;

	[Token(Token = "0x400064D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	[HideInInspector]
	private Vector3[] maxGripPosPose;

	[Token(Token = "0x400064E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	[HideInInspector]
	private Transform[] fingerJoints;

	[Token(Token = "0x6000671")]
	[Address(RVA = "0x15D6B20", Offset = "0x15D6B20", VA = "0x15D6B20")]
	private void Update()
	{
	}

	[Token(Token = "0x6000672")]
	[Address(RVA = "0x15D6BA8", Offset = "0x15D6BA8", VA = "0x15D6BA8")]
	public bool BendFingerUntilHit(int steps, int layermask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000673")]
	[Address(RVA = "0x15D6F04", Offset = "0x15D6F04", VA = "0x15D6F04")]
	public bool BendFingerUntilHit(int steps, RaycastHit target)
	{
		return default(bool);
	}

	[Token(Token = "0x6000674")]
	[Address(RVA = "0x15D742C", Offset = "0x15D742C", VA = "0x15D742C")]
	public bool UpdateFingerBend(float bend, int layermask)
	{
		return default(bool);
	}

	[Token(Token = "0x6000675")]
	[Address(RVA = "0x15D7290", Offset = "0x15D7290", VA = "0x15D7290")]
	public void SetFingerBend(float b)
	{
	}

	[Token(Token = "0x6000676")]
	[Address(RVA = "0x15D7678", Offset = "0x15D7678", VA = "0x15D7678")]
	public void SetFingerPose(BrinkHandPoseData data)
	{
	}

	[Token(Token = "0x6000677")]
	[Address(RVA = "0x15D77B0", Offset = "0x15D77B0", VA = "0x15D77B0")]
	public bool UnbendSmooth(float b)
	{
		return default(bool);
	}

	[Token(Token = "0x6000678")]
	[Address(RVA = "0x15D6B24", Offset = "0x15D6B24", VA = "0x15D6B24")]
	private void SlowBend()
	{
	}

	[Token(Token = "0x6000679")]
	[Address(RVA = "0x15D6E08", Offset = "0x15D6E08", VA = "0x15D6E08")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED224", Offset = "0xAED224")]
	public void ResetBend()
	{
	}

	[Token(Token = "0x600067A")]
	[Address(RVA = "0x15D7A68", Offset = "0x15D7A68", VA = "0x15D7A68")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED25C", Offset = "0xAED25C")]
	public void Grip()
	{
	}

	[Token(Token = "0x600067B")]
	[Address(RVA = "0x15D7B64", Offset = "0x15D7B64", VA = "0x15D7B64")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED294", Offset = "0xAED294")]
	public void SetMinPose()
	{
	}

	[Token(Token = "0x600067C")]
	[Address(RVA = "0x15D7E90", Offset = "0x15D7E90", VA = "0x15D7E90")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED2CC", Offset = "0xAED2CC")]
	public void SetMaxPose()
	{
	}

	[Token(Token = "0x600067D")]
	[Address(RVA = "0x15D7C4C", Offset = "0x15D7C4C", VA = "0x15D7C4C")]
	private void GetKidsCount(Transform obj, ref int count)
	{
	}

	[Token(Token = "0x600067E")]
	[Address(RVA = "0x15D80D4", Offset = "0x15D80D4", VA = "0x15D80D4")]
	public Finger()
	{
	}

	[Token(Token = "0x600067F")]
	[Address(RVA = "0x15D76B0", Offset = "0x15D76B0", VA = "0x15D76B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED304", Offset = "0xAED304")]
	internal static void <SetFingerPose>g__AssignChildrenPose|17_0(Transform obj, BrinkHandPoseData pose, ref <>c__DisplayClass17_0 P_2)
	{
	}

	[Token(Token = "0x6000680")]
	[Address(RVA = "0x15D7D34", Offset = "0x15D7D34", VA = "0x15D7D34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED314", Offset = "0xAED314")]
	private void <SetMinPose>g__AssignChildrenPose|22_0(Transform obj, ref int index)
	{
	}

	[Token(Token = "0x6000681")]
	[Address(RVA = "0x15D80E8", Offset = "0x15D80E8", VA = "0x15D80E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED324", Offset = "0xAED324")]
	private void <SetMinPose>g__AssignPoint|22_1(int point, Vector3 pos, Quaternion rot, Transform joint)
	{
	}

	[Token(Token = "0x6000682")]
	[Address(RVA = "0x15D7F78", Offset = "0x15D7F78", VA = "0x15D7F78")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED334", Offset = "0xAED334")]
	private void <SetMaxPose>g__AssignChildrenPose|23_0(Transform obj, ref int index)
	{
	}

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x15D81A8", Offset = "0x15D81A8", VA = "0x15D81A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED344", Offset = "0xAED344")]
	private void <SetMaxPose>g__AssignPoint|23_1(int point, Vector3 pos, Quaternion rot, Transform joint)
	{
	}
}
[Token(Token = "0x2000120")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE45DC", Offset = "0xAE45DC")]
public class GrabLock : MonoBehaviour
{
	[Token(Token = "0x4000656")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent OnGrabPressed;

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x15D9CAC", Offset = "0x15D9CAC", VA = "0x15D9CAC")]
	public GrabLock()
	{
	}
}
[Token(Token = "0x2000121")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE463C", Offset = "0xAE463C")]
[SelectionBase]
public class Grabbable : MonoBehaviour
{
	[Token(Token = "0x4000657")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9D18", Offset = "0xAE9D18")]
	public Collider GrabCollider;

	[Token(Token = "0x4000658")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public StudioEventEmitter CustomGrabAudio;

	[Token(Token = "0x4000659")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAE9D50", Offset = "0xAE9D50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9D50", Offset = "0xAE9D50")]
	public HandType handType;

	[Token(Token = "0x400065A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAE9D9C", Offset = "0xAE9D9C")]
	public Vector3 heldPositionOffsetLeft;

	[Token(Token = "0x400065B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0xAE9DD4", Offset = "0xAE9DD4")]
	public Vector3 heldRotationOffsetLeft;

	[Token(Token = "0x400065C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public Vector3 heldPositionOffsetRight;

	[Token(Token = "0x400065D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Vector3 heldRotationOffsetRight;

	[Token(Token = "0x400065E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9E0C", Offset = "0xAE9E0C")]
	public bool singleHandOnly;

	[Token(Token = "0x400065F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5D")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9E44", Offset = "0xAE9E44")]
	public bool releaseOnTeleport;

	[Token(Token = "0x4000660")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5E")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9E7C", Offset = "0xAE9E7C")]
	public bool lockHandOnGrab;

	[Token(Token = "0x4000661")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5F")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9EB4", Offset = "0xAE9EB4")]
	public bool LookAssist;

	[Token(Token = "0x4000662")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAE9EEC", Offset = "0xAE9EEC")]
	public Material hightlightMaterial;

	[Token(Token = "0x4000663")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[HideInInspector]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9F24", Offset = "0xAE9F24")]
	public bool pullApartBreakOnly;

	[Token(Token = "0x4000664")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAE9F70", Offset = "0xAE9F70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9F70", Offset = "0xAE9F70")]
	public int jointBreakForce;

	[Token(Token = "0x4000665")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAE9FBC", Offset = "0xAE9FBC")]
	public int jointBreakTorque;

	[Token(Token = "0x4000666")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public HandGrabEvent OnGrabEvent;

	[Token(Token = "0x4000667")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public HandGrabEvent OnReleaseEvent;

	[Token(Token = "0x4000668")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public HandGrabEvent OnForceReleaseEvent;

	[Token(Token = "0x4000669")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public HandGrabEvent OnSqueezeEvent;

	[Token(Token = "0x400066A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public HandGrabEvent OnUnsqueezeEvent;

	[Token(Token = "0x400066B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public HandGrabEvent OnJointBreakEvent;

	[Token(Token = "0x400066C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	[HideInInspector]
	public UnityEvent onGrab;

	[Token(Token = "0x400066D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	[HideInInspector]
	public UnityEvent onRelease;

	[Token(Token = "0x400066E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	[HideInInspector]
	public UnityEvent onSqueeze;

	[Token(Token = "0x400066F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	[HideInInspector]
	public UnityEvent onUnsqueeze;

	[Token(Token = "0x4000670")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[HideInInspector]
	public UnityEvent OnJointBreak;

	[Token(Token = "0x4000671")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA044", Offset = "0xAEA044")]
	private Rigidbody <body>k__BackingField;

	[Token(Token = "0x4000672")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	internal bool BeingHeld;

	[Token(Token = "0x4000673")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private readonly CollisionDetectionMode detectionMode;

	[Token(Token = "0x4000674")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Vector3 lastCenterOfMassPos;

	[Token(Token = "0x4000675")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private Quaternion lastCenterOfMassRot;

	[Token(Token = "0x4000676")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<HandPhysics> heldBy;

	[Token(Token = "0x4000677")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private bool throwing;

	[Token(Token = "0x4000678")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
	private bool hightlighting;

	[Token(Token = "0x4000679")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private GameObject highlightObj;

	[Token(Token = "0x400067A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private PlacePoint placePoint;

	[Token(Token = "0x400067B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private bool beingDestroyed;

	[Token(Token = "0x17000118")]
	public Rigidbody body
	{
		[Token(Token = "0x6000685")]
		[Address(RVA = "0x15D9CB4", Offset = "0x15D9CB4", VA = "0x15D9CB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED354", Offset = "0xAED354")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000686")]
		[Address(RVA = "0x15D9CBC", Offset = "0x15D9CBC", VA = "0x15D9CBC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED364", Offset = "0xAED364")]
		private set
		{
		}
	}

	[Token(Token = "0x17000119")]
	public HandPhysics HoldingHand
	{
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x15DAF84", Offset = "0x15DAF84", VA = "0x15DAF84")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000687")]
	[Address(RVA = "0x15D2CC8", Offset = "0x15D2CC8", VA = "0x15D2CC8", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6000688")]
	[Address(RVA = "0x15D9CC4", Offset = "0x15D9CC4", VA = "0x15D9CC4", Slot = "5")]
	protected virtual void FixedUpdate()
	{
	}

	[Token(Token = "0x6000689")]
	[Address(RVA = "0x15D9D34", Offset = "0x15D9D34", VA = "0x15D9D34", Slot = "6")]
	public virtual void Highlight()
	{
	}

	[Token(Token = "0x600068A")]
	[Address(RVA = "0x15DA09C", Offset = "0x15DA09C", VA = "0x15DA09C", Slot = "7")]
	public virtual void Unhighlight()
	{
	}

	[Token(Token = "0x600068B")]
	[Address(RVA = "0x15DA158", Offset = "0x15DA158", VA = "0x15DA158", Slot = "8")]
	public virtual void OnSqueeze(HandPhysics hand)
	{
	}

	[Token(Token = "0x600068C")]
	[Address(RVA = "0x15DA530", Offset = "0x15DA530", VA = "0x15DA530", Slot = "9")]
	public virtual void OnUnsqueeze(HandPhysics hand)
	{
	}

	[Token(Token = "0x600068D")]
	[Address(RVA = "0x15DA574", Offset = "0x15DA574", VA = "0x15DA574", Slot = "10")]
	public virtual void OnGrab(HandPhysics hand)
	{
	}

	[Token(Token = "0x600068E")]
	[Address(RVA = "0x15DA758", Offset = "0x15DA758", VA = "0x15DA758", Slot = "11")]
	public virtual void OnRelease(HandPhysics hand, bool thrown)
	{
	}

	[Token(Token = "0x600068F")]
	[Address(RVA = "0x15DAA6C", Offset = "0x15DAA6C", VA = "0x15DAA6C")]
	public void ForceHandsRelease()
	{
	}

	[Token(Token = "0x6000690")]
	[Address(RVA = "0x15DAF38", Offset = "0x15DAF38", VA = "0x15DAF38")]
	public int HeldCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000692")]
	[Address(RVA = "0x15DAFF0", Offset = "0x15DAFF0", VA = "0x15DAFF0", Slot = "12")]
	protected virtual void OnDestroy()
	{
	}

	[Token(Token = "0x6000693")]
	[Address(RVA = "0x15DAFFC", Offset = "0x15DAFFC", VA = "0x15DAFFC", Slot = "13")]
	public virtual void OnHandJointBreak(HandPhysics hand)
	{
	}

	[Token(Token = "0x6000694")]
	[Address(RVA = "0x15DB08C", Offset = "0x15DB08C", VA = "0x15DB08C")]
	public bool IsThrowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6000695")]
	[Address(RVA = "0x15DB094", Offset = "0x15DB094", VA = "0x15DB094")]
	private Vector3 GetAngularVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000696")]
	[Address(RVA = "0x15DB194", Offset = "0x15DB194", VA = "0x15DB194", Slot = "14")]
	protected virtual void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000697")]
	[Address(RVA = "0x15DB260", Offset = "0x15DB260", VA = "0x15DB260")]
	public void SetPlacePoint(PlacePoint point)
	{
	}

	[Token(Token = "0x6000698")]
	[Address(RVA = "0x15DB268", Offset = "0x15DB268", VA = "0x15DB268")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000699")]
	[Address(RVA = "0x15DB4E8", Offset = "0x15DB4E8", VA = "0x15DB4E8")]
	public void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x600069A")]
	[Address(RVA = "0x15DB61C", Offset = "0x15DB61C", VA = "0x15DB61C")]
	protected void ResetThrowing()
	{
	}

	[Token(Token = "0x600069B")]
	[Address(RVA = "0x15DB624", Offset = "0x15DB624", VA = "0x15DB624")]
	protected void ResetLayerAfterRelease()
	{
	}

	[Token(Token = "0x600069C")]
	[Address(RVA = "0x15DAEC0", Offset = "0x15DAEC0", VA = "0x15DAEC0")]
	public static void SetLayer(Transform obj, int oldLayer, int newLayer)
	{
	}

	[Token(Token = "0x600069D")]
	[Address(RVA = "0x15DB714", Offset = "0x15DB714", VA = "0x15DB714")]
	public void DoDestroy()
	{
	}

	[Token(Token = "0x600069E")]
	[Address(RVA = "0x15DA714", Offset = "0x15DA714", VA = "0x15DA714")]
	private void ContinuousCollisionDetection()
	{
	}

	[Token(Token = "0x600069F")]
	[Address(RVA = "0x15DB78C", Offset = "0x15DB78C", VA = "0x15DB78C")]
	protected void OriginalCollisionDetection()
	{
	}

	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x15DB850", Offset = "0x15DB850", VA = "0x15DB850")]
	public Vector3 GetHeldPositionOffset(bool left)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006A1")]
	[Address(RVA = "0x15DB888", Offset = "0x15DB888", VA = "0x15DB888")]
	public Vector3 GetHeldRotationOffset(bool left)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006A2")]
	[Address(RVA = "0x15D4DF0", Offset = "0x15D4DF0", VA = "0x15D4DF0")]
	public Grabbable()
	{
	}
}
[Token(Token = "0x2000122")]
public class GrabbablePoint : GrabbablePointBase
{
	[Token(Token = "0x400067C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform rightPoint;

	[Token(Token = "0x400067D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform leftPoint;

	[Token(Token = "0x60006A3")]
	[Address(RVA = "0x15DB8C0", Offset = "0x15DB8C0", VA = "0x15DB8C0", Slot = "4")]
	public override bool Align(HandPhysics hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60006A4")]
	[Address(RVA = "0x15DBA50", Offset = "0x15DBA50", VA = "0x15DBA50")]
	public GrabbablePoint()
	{
	}
}
[Token(Token = "0x2000123")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE46AC", Offset = "0xAE46AC")]
public class GrabbablePointBase : MonoBehaviour
{
	[Token(Token = "0x60006A5")]
	[Address(RVA = "0x15DBA60", Offset = "0x15DBA60", VA = "0x15DBA60", Slot = "4")]
	public virtual bool Align(HandPhysics hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60006A6")]
	[Address(RVA = "0x15DBA58", Offset = "0x15DBA58", VA = "0x15DBA58")]
	public GrabbablePointBase()
	{
	}
}
[Token(Token = "0x2000124")]
public class GrabbablePoints : GrabbablePointBase
{
	[Token(Token = "0x400067E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform[] leftPoints;

	[Token(Token = "0x400067F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform[] rightPoints;

	[Token(Token = "0x60006A7")]
	[Address(RVA = "0x15DBA68", Offset = "0x15DBA68", VA = "0x15DBA68", Slot = "4")]
	public override bool Align(HandPhysics hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60006A8")]
	[Address(RVA = "0x15DBB2C", Offset = "0x15DBB2C", VA = "0x15DBB2C")]
	private static Transform ClosestGrabPoint(IReadOnlyList<Transform> points, Component hand)
	{
		return null;
	}

	[Token(Token = "0x60006A9")]
	[Address(RVA = "0x15DC028", Offset = "0x15DC028", VA = "0x15DC028")]
	public GrabbablePoints()
	{
	}
}
[Token(Token = "0x2000125")]
public class GrabbablePose : MonoBehaviour
{
	[StructLayout(3)]
	[Token(Token = "0x2000126")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE470C", Offset = "0xAE470C")]
	private struct <>c__DisplayClass2_0
	{
		[Token(Token = "0x4000682")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int i;

		[Token(Token = "0x4000683")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public BrinkHandPoseData PoseData;
	}

	[Token(Token = "0x4000680")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BrinkHandPoseData RightPoseData;

	[Token(Token = "0x4000681")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BrinkHandPoseData LeftPoseData;

	[Token(Token = "0x60006AA")]
	[Address(RVA = "0x15DC030", Offset = "0x15DC030", VA = "0x15DC030")]
	public bool SetGrabPose(HandPhysics hand)
	{
		return default(bool);
	}

	[Token(Token = "0x60006AB")]
	[Address(RVA = "0x15DC564", Offset = "0x15DC564", VA = "0x15DC564")]
	public GrabbablePose()
	{
	}

	[Token(Token = "0x60006AC")]
	[Address(RVA = "0x15DC340", Offset = "0x15DC340", VA = "0x15DC340")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED374", Offset = "0xAED374")]
	internal static void <SetGrabPose>g__AssignChildrenPose|2_0(Transform obj, ref <>c__DisplayClass2_0 P_1)
	{
	}
}
[Token(Token = "0x2000127")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE471C", Offset = "0xAE471C")]
public class GrabbableThrowEvent : MonoBehaviour
{
	[Token(Token = "0x4000684")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA054", Offset = "0xAEA054")]
	public float breakVelocity;

	[Token(Token = "0x4000685")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA08C", Offset = "0xAEA08C")]
	public LayerMask collisionLayers;

	[Token(Token = "0x4000686")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnBreak;

	[Token(Token = "0x4000687")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Rigidbody rb;

	[Token(Token = "0x4000688")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Grabbable grab;

	[Token(Token = "0x60006AD")]
	[Address(RVA = "0x15DC56C", Offset = "0x15DC56C", VA = "0x15DC56C")]
	private void Start()
	{
	}

	[Token(Token = "0x60006AE")]
	[Address(RVA = "0x15DC5E4", Offset = "0x15DC5E4", VA = "0x15DC5E4")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60006AF")]
	[Address(RVA = "0x15DC700", Offset = "0x15DC700", VA = "0x15DC700")]
	private void Break()
	{
	}

	[Token(Token = "0x60006B0")]
	[Address(RVA = "0x15DC71C", Offset = "0x15DC71C", VA = "0x15DC71C")]
	public GrabbableThrowEvent()
	{
	}
}
[Token(Token = "0x2000128")]
public delegate void HandGrabEvent(HandPhysics hand, Grabbable grabbable);
[Token(Token = "0x2000129")]
public enum HandType
{
	[Token(Token = "0x400068A")]
	both,
	[Token(Token = "0x400068B")]
	right,
	[Token(Token = "0x400068C")]
	left
}
[Token(Token = "0x200012A")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE47A4", Offset = "0xAE47A4")]
public class HandPhysics : MonoBehaviour
{
	[Token(Token = "0x200012B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4804", Offset = "0xAE4804")]
	private sealed class <GrabObject>d__115 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPhysics <>4__this;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public RaycastHit hit;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Grabbable <tempHoldingObj>5__2;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private GrabbablePointBase <grabBase>5__3;

		[Token(Token = "0x17000121")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60006FD")]
			[Address(RVA = "0xE425BC", Offset = "0xE425BC", VA = "0xE425BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000122")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60006FF")]
			[Address(RVA = "0xE42604", Offset = "0xE42604", VA = "0xE42604", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FA")]
		[Address(RVA = "0xE418E4", Offset = "0xE418E4", VA = "0xE418E4")]
		[DebuggerHidden]
		public <GrabObject>d__115(int <>1__state)
		{
		}

		[Token(Token = "0x60006FB")]
		[Address(RVA = "0xE41910", Offset = "0xE41910", VA = "0xE41910", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0xE41914", Offset = "0xE41914", VA = "0xE41914", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0xE425C4", Offset = "0xE425C4", VA = "0xE425C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200012C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4814", Offset = "0xAE4814")]
	private struct <>c__DisplayClass116_0
	{
		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int i;
	}

	[Token(Token = "0x200012D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4824", Offset = "0xAE4824")]
	private sealed class <TimedResetLayer>d__118 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPhysics <>4__this;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string startLayer;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float seconds;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string resetLayer;

		[Token(Token = "0x17000123")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000703")]
			[Address(RVA = "0xE4278C", Offset = "0xE4278C", VA = "0xE4278C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000124")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000705")]
			[Address(RVA = "0xE427D4", Offset = "0xE427D4", VA = "0xE427D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0xE4260C", Offset = "0xE4260C", VA = "0xE4260C")]
		[DebuggerHidden]
		public <TimedResetLayer>d__118(int <>1__state)
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0xE42638", Offset = "0xE42638", VA = "0xE42638", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0xE4263C", Offset = "0xE4263C", VA = "0xE4263C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0xE42794", Offset = "0xE42794", VA = "0xE42794", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[StructLayout(3)]
	[Token(Token = "0x200012E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4834", Offset = "0xAE4834")]
	private struct <>c__DisplayClass120_0
	{
		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int i;
	}

	[Token(Token = "0x200012F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4844", Offset = "0xAE4844")]
	private sealed class <<Snap>g__PreventInterpolation|107_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPhysics <>4__this;

		[Token(Token = "0x17000125")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0xE41894", Offset = "0xE41894", VA = "0xE41894", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000126")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0xE418DC", Offset = "0xE418DC", VA = "0xE418DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0xE416E0", Offset = "0xE416E0", VA = "0xE416E0")]
		[DebuggerHidden]
		public <<Snap>g__PreventInterpolation|107_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0xE4170C", Offset = "0xE4170C", VA = "0xE4170C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0xE41710", Offset = "0xE41710", VA = "0xE41710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0xE4189C", Offset = "0xE4189C", VA = "0xE4189C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000130")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4854", Offset = "0xAE4854")]
	private sealed class <<GrabObject>g__AutoAllign|115_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public HandPhysics <>4__this;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float <mass>5__2;

		[Token(Token = "0x17000127")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600070F")]
			[Address(RVA = "0xE41690", Offset = "0xE41690", VA = "0xE41690", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000128")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000711")]
			[Address(RVA = "0xE416D8", Offset = "0xE416D8", VA = "0xE416D8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0xE4127C", Offset = "0xE4127C", VA = "0xE4127C")]
		[DebuggerHidden]
		public <<GrabObject>g__AutoAllign|115_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0xE412A8", Offset = "0xE412A8", VA = "0xE412A8", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600070E")]
		[Address(RVA = "0xE412AC", Offset = "0xE412AC", VA = "0xE412AC", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0xE41698", Offset = "0xE41698", VA = "0xE41698", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400068D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LayerMask _PhysicalObjectsMask;

	[Token(Token = "0x400068E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform HandModelRoot;

	[Token(Token = "0x400068F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA0C4", Offset = "0xAEA0C4")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA0C4", Offset = "0xAEA0C4")]
	public Transform follow;

	[Token(Token = "0x4000690")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Vector3 followPositionOffset;

	[Token(Token = "0x4000691")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	public Vector3 followRotationOffset;

	[Token(Token = "0x4000692")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA124", Offset = "0xAEA124")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA124", Offset = "0xAEA124")]
	public float maxVelocity;

	[Token(Token = "0x4000693")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA174", Offset = "0xAEA174")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA174", Offset = "0xAEA174")]
	public float followPositionStrength;

	[Token(Token = "0x4000694")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA1C4", Offset = "0xAEA1C4")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA1C4", Offset = "0xAEA1C4")]
	public float followRotationStrength;

	[Token(Token = "0x4000695")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA214", Offset = "0xAEA214")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA214", Offset = "0xAEA214")]
	public float maxFollowDistance;

	[Token(Token = "0x4000696")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA264", Offset = "0xAEA264")]
	public bool left;

	[Token(Token = "0x4000697")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA29C", Offset = "0xAEA29C")]
	public Transform palmTransform;

	[Token(Token = "0x4000698")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA2D4", Offset = "0xAEA2D4")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA2D4", Offset = "0xAEA2D4")]
	public float lookAssistSpeed;

	[Token(Token = "0x4000699")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA324", Offset = "0xAEA324")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA324", Offset = "0xAEA324")]
	public float throwPower;

	[Token(Token = "0x400069A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA374", Offset = "0xAEA374")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA374", Offset = "0xAEA374")]
	public float reachDistance;

	[Token(Token = "0x400069B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA3C4", Offset = "0xAEA3C4")]
	public float grabSpreadOffset;

	[Token(Token = "0x400069C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA3FC", Offset = "0xAEA3FC")]
	[AttributeAttribute(Name = "MinAttribute", RVA = "0xAEA3FC", Offset = "0xAEA3FC")]
	public float ignoreReleaseTime;

	[Token(Token = "0x400069D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA44C", Offset = "0xAEA44C")]
	public int fingerBendSteps;

	[Token(Token = "0x400069E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private float PalmRayOffset;

	[Token(Token = "0x400069F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA494", Offset = "0xAEA494")]
	public Finger[] fingers;

	[Token(Token = "0x40006A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA4CC", Offset = "0xAEA4CC")]
	public float swayStrength;

	[Token(Token = "0x40006A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	[HideInInspector]
	public bool freezeRot;

	[Token(Token = "0x40006A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA514", Offset = "0xAEA514")]
	private bool <FreezeRotation>k__BackingField;

	[Token(Token = "0x40006AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA594", Offset = "0xAEA594")]
	private bool <Grabbing>k__BackingField;

	[Token(Token = "0x40006AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	internal Grabbable HoldingObject;

	[Token(Token = "0x40006AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA5A4", Offset = "0xAEA5A4")]
	private bool <MoveWithPhysics>k__BackingField;

	[Token(Token = "0x40006AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA5B4", Offset = "0xAEA5B4")]
	private bool <FingersColliderActive>k__BackingField;

	[Token(Token = "0x40006AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	internal Vector3 RealWorldRigSpaceVelocity;

	[Token(Token = "0x40006AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	internal Vector3 RealWorldRigSpaceAngularVelocity;

	[Token(Token = "0x40006B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Collider[] PhysicColliders;

	[Token(Token = "0x40006B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private Grabbable LookingAtObj;

	[Token(Token = "0x40006B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Transform MoveToTransform;

	[Token(Token = "0x40006B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Rigidbody Rigidbody;

	[Token(Token = "0x40006B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private FixedJoint Joint1;

	[Token(Token = "0x40006B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private FixedJoint Joint2;

	[Token(Token = "0x40006B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private bool Squeezing;

	[Token(Token = "0x40006B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private float CurrentGrip;

	[Token(Token = "0x40006B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private float CurrentTrigger;

	[Token(Token = "0x40006B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
	private float CurrentSwayGrip;

	[Token(Token = "0x40006BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private float CurrentSwayTrigger;

	[Token(Token = "0x40006BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private Vector3[] HandRays;

	[Token(Token = "0x40006BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Transform GrabPoint;

	[Token(Token = "0x40006BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private bool GrabLocked;

	[Token(Token = "0x40006BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	private Vector3 PreRenderPos;

	[Token(Token = "0x40006BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Quaternion PreRenderRot;

	[Token(Token = "0x40006C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Vector3 PalmOffset;

	[Token(Token = "0x40006C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
	private bool Teleporting;

	[Token(Token = "0x40006C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private int HandLayers;

	[Token(Token = "0x40006C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
	private Vector3 StartGrabPos;

	[Token(Token = "0x40006C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Quaternion StartGrabRot;

	[Token(Token = "0x40006C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private bool GrabbingFrame;

	[Token(Token = "0x40006C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private GrabbablePose GrabPose;

	[Token(Token = "0x40006C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private BrinkHandPoseData IntentPose;

	[Token(Token = "0x40006C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
	private bool CancelingIntentPose;

	[Token(Token = "0x40006C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1BC")]
	private float LastObjectForceReleaseTime;

	[Token(Token = "0x40006CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
	private Coroutine PreventInterpolationCo;

	[Token(Token = "0x1700011A")]
	private static LayerMask PhysicalObjectsMask
	{
		[Token(Token = "0x60006B5")]
		[Address(RVA = "0x15DD07C", Offset = "0x15DD07C", VA = "0x15DD07C")]
		get
		{
			return default(LayerMask);
		}
	}

	[Token(Token = "0x1700011B")]
	public bool FreezeRotation
	{
		[Token(Token = "0x60006B6")]
		[Address(RVA = "0x15DD358", Offset = "0x15DD358", VA = "0x15DD358")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED384", Offset = "0xAED384")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006B7")]
		[Address(RVA = "0x15DD360", Offset = "0x15DD360", VA = "0x15DD360")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED394", Offset = "0xAED394")]
		set
		{
		}
	}

	[Token(Token = "0x1700011C")]
	private bool Grabbing
	{
		[Token(Token = "0x60006C7")]
		[Address(RVA = "0x15DDC38", Offset = "0x15DDC38", VA = "0x15DDC38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED494", Offset = "0xAED494")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x15DDC2C", Offset = "0x15DDC2C", VA = "0x15DDC2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED484", Offset = "0xAED484")]
		set
		{
		}
	}

	[Token(Token = "0x1700011D")]
	internal bool MoveWithPhysics
	{
		[Token(Token = "0x60006C8")]
		[Address(RVA = "0x15DDC40", Offset = "0x15DDC40", VA = "0x15DDC40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED4A4", Offset = "0xAED4A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006C9")]
		[Address(RVA = "0x15DDC48", Offset = "0x15DDC48", VA = "0x15DDC48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED4B4", Offset = "0xAED4B4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700011E")]
	internal bool FingersColliderActive
	{
		[Token(Token = "0x60006CA")]
		[Address(RVA = "0x15DDC54", Offset = "0x15DDC54", VA = "0x15DDC54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED4C4", Offset = "0xAED4C4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60006CB")]
		[Address(RVA = "0x15DDC5C", Offset = "0x15DDC5C", VA = "0x15DDC5C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED4D4", Offset = "0xAED4D4")]
		set
		{
		}
	}

	[Token(Token = "0x1700011F")]
	internal bool HasIntentPose
	{
		[Token(Token = "0x60006CC")]
		[Address(RVA = "0x15DDC68", Offset = "0x15DDC68", VA = "0x15DDC68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000120")]
	private bool JustForceReleasedAnObject
	{
		[Token(Token = "0x60006EB")]
		[Address(RVA = "0x15DEF70", Offset = "0x15DEF70", VA = "0x15DEF70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000001")]
	public event HandGrabEvent OnBeforeGrabbed
	{
		[Token(Token = "0x60006B8")]
		[Address(RVA = "0x15DD36C", Offset = "0x15DD36C", VA = "0x15DD36C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3A4", Offset = "0xAED3A4")]
		add
		{
		}
		[Token(Token = "0x60006B9")]
		[Address(RVA = "0x15DD40C", Offset = "0x15DD40C", VA = "0x15DD40C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3B4", Offset = "0xAED3B4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000002")]
	public event HandGrabEvent OnGrabbed
	{
		[Token(Token = "0x60006BA")]
		[Address(RVA = "0x15DD4AC", Offset = "0x15DD4AC", VA = "0x15DD4AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3C4", Offset = "0xAED3C4")]
		add
		{
		}
		[Token(Token = "0x60006BB")]
		[Address(RVA = "0x15DD54C", Offset = "0x15DD54C", VA = "0x15DD54C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3D4", Offset = "0xAED3D4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000003")]
	public event HandGrabEvent OnBeforeReleased
	{
		[Token(Token = "0x60006BC")]
		[Address(RVA = "0x15DD5EC", Offset = "0x15DD5EC", VA = "0x15DD5EC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3E4", Offset = "0xAED3E4")]
		add
		{
		}
		[Token(Token = "0x60006BD")]
		[Address(RVA = "0x15DD68C", Offset = "0x15DD68C", VA = "0x15DD68C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED3F4", Offset = "0xAED3F4")]
		remove
		{
		}
	}

	[Token(Token = "0x14000004")]
	public event HandGrabEvent OnReleased
	{
		[Token(Token = "0x60006BE")]
		[Address(RVA = "0x15DD72C", Offset = "0x15DD72C", VA = "0x15DD72C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED404", Offset = "0xAED404")]
		add
		{
		}
		[Token(Token = "0x60006BF")]
		[Address(RVA = "0x15DD7CC", Offset = "0x15DD7CC", VA = "0x15DD7CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED414", Offset = "0xAED414")]
		remove
		{
		}
	}

	[Token(Token = "0x14000005")]
	public event HandGrabEvent OnForcedRelease
	{
		[Token(Token = "0x60006C0")]
		[Address(RVA = "0x15DD86C", Offset = "0x15DD86C", VA = "0x15DD86C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED424", Offset = "0xAED424")]
		add
		{
		}
		[Token(Token = "0x60006C1")]
		[Address(RVA = "0x15DD90C", Offset = "0x15DD90C", VA = "0x15DD90C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED434", Offset = "0xAED434")]
		remove
		{
		}
	}

	[Token(Token = "0x14000006")]
	public event HandGrabEvent OnSqueezed
	{
		[Token(Token = "0x60006C2")]
		[Address(RVA = "0x15DD9AC", Offset = "0x15DD9AC", VA = "0x15DD9AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED444", Offset = "0xAED444")]
		add
		{
		}
		[Token(Token = "0x60006C3")]
		[Address(RVA = "0x15DDA4C", Offset = "0x15DDA4C", VA = "0x15DDA4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED454", Offset = "0xAED454")]
		remove
		{
		}
	}

	[Token(Token = "0x14000007")]
	public event HandGrabEvent OnUnsqueezed
	{
		[Token(Token = "0x60006C4")]
		[Address(RVA = "0x15DDAEC", Offset = "0x15DDAEC", VA = "0x15DDAEC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED464", Offset = "0xAED464")]
		add
		{
		}
		[Token(Token = "0x60006C5")]
		[Address(RVA = "0x15DDB8C", Offset = "0x15DDB8C", VA = "0x15DDB8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED474", Offset = "0xAED474")]
		remove
		{
		}
	}

	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x15DDCD4", Offset = "0x15DDCD4", VA = "0x15DDCD4")]
	public void Start()
	{
	}

	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x15DDED0", Offset = "0x15DDED0", VA = "0x15DDED0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x15DE2A4", Offset = "0x15DE2A4", VA = "0x15DE2A4")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x15DEB1C", Offset = "0x15DEB1C", VA = "0x15DEB1C")]
	public void FixedUpdate()
	{
	}

	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x15DF5AC", Offset = "0x15DF5AC", VA = "0x15DF5AC")]
	public void OnPreRender()
	{
	}

	[Token(Token = "0x60006D2")]
	[Address(RVA = "0x15DF7A0", Offset = "0x15DF7A0", VA = "0x15DF7A0")]
	public void OnPostRender()
	{
	}

	[Token(Token = "0x60006D3")]
	[Address(RVA = "0x15DEFA8", Offset = "0x15DEFA8", VA = "0x15DEFA8")]
	private void EnableColliders(bool v = true)
	{
	}

	[Token(Token = "0x60006D4")]
	[Address(RVA = "0x15DF034", Offset = "0x15DF034", VA = "0x15DF034")]
	private void MoveToWithPhysics()
	{
	}

	[Token(Token = "0x60006D5")]
	[Address(RVA = "0x15DF200", Offset = "0x15DF200", VA = "0x15DF200")]
	private void RotateToWithPhysics()
	{
	}

	[Token(Token = "0x60006D6")]
	[Address(RVA = "0x15DF87C", Offset = "0x15DF87C", VA = "0x15DF87C")]
	public void SetGrip(float v)
	{
	}

	[Token(Token = "0x60006D7")]
	[Address(RVA = "0x15DF884", Offset = "0x15DF884", VA = "0x15DF884")]
	public void SetTrigger(float v)
	{
	}

	[Token(Token = "0x60006D8")]
	[Address(RVA = "0x15DF88C", Offset = "0x15DF88C", VA = "0x15DF88C")]
	public void Grab()
	{
	}

	[Token(Token = "0x60006D9")]
	[Address(RVA = "0x15E00AC", Offset = "0x15E00AC", VA = "0x15E00AC")]
	public void ForceGrab(Grabbable grabbable)
	{
	}

	[Token(Token = "0x60006DA")]
	[Address(RVA = "0x15E080C", Offset = "0x15E080C", VA = "0x15E080C")]
	public void Release()
	{
	}

	[Token(Token = "0x60006DB")]
	[Address(RVA = "0x15DADF8", Offset = "0x15DADF8", VA = "0x15DADF8")]
	public void ForceReleaseGrab()
	{
	}

	[Token(Token = "0x60006DC")]
	[Address(RVA = "0x15E0B48", Offset = "0x15E0B48", VA = "0x15E0B48")]
	public void Snap()
	{
	}

	[Token(Token = "0x60006DD")]
	[Address(RVA = "0x15E0958", Offset = "0x15E0958", VA = "0x15E0958")]
	private void BreakGrabConnection()
	{
	}

	[Token(Token = "0x60006DE")]
	[Address(RVA = "0x15E0E88", Offset = "0x15E0E88", VA = "0x15E0E88")]
	public void Squeeze()
	{
	}

	[Token(Token = "0x60006DF")]
	[Address(RVA = "0x15E0F3C", Offset = "0x15E0F3C", VA = "0x15E0F3C")]
	public void Unsqueeze()
	{
	}

	[Token(Token = "0x60006E0")]
	[Address(RVA = "0x15DAA50", Offset = "0x15DAA50", VA = "0x15DAA50")]
	internal Vector3 ThrowVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006E1")]
	[Address(RVA = "0x15E0FEC", Offset = "0x15E0FEC", VA = "0x15E0FEC")]
	internal Vector3 ThrowAngularVelocity()
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006E2")]
	[Address(RVA = "0x15DEA44", Offset = "0x15DEA44", VA = "0x15DEA44")]
	private void DeterminPose()
	{
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x15E133C", Offset = "0x15E133C", VA = "0x15E133C")]
	private static bool GetGrabbable(GameObject obj, out Grabbable grabbable)
	{
		return default(bool);
	}

	[Token(Token = "0x60006E4")]
	[Address(RVA = "0x15E0018", Offset = "0x15E0018", VA = "0x15E0018")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED4E4", Offset = "0xAED4E4")]
	private IEnumerator GrabObject(RaycastHit hit)
	{
		return null;
	}

	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x15E148C", Offset = "0x15E148C", VA = "0x15E148C")]
	public void SetIntentPose(BrinkHandPoseData data)
	{
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x15E16E0", Offset = "0x15E16E0", VA = "0x15E16E0")]
	public void CancelIntentPose(BrinkHandPoseData pose)
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x15E0DF8", Offset = "0x15E0DF8", VA = "0x15E0DF8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED544", Offset = "0xAED544")]
	private IEnumerator TimedResetLayer(float seconds, string startLayer, string resetLayer)
	{
		return null;
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x15DFBEC", Offset = "0x15DFBEC", VA = "0x15DFBEC")]
	public Vector3 HandClosestHit(out RaycastHit closestHit, float dist, int layerMask)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x15E0FF8", Offset = "0x15E0FF8", VA = "0x15E0FF8")]
	private void UpdateFingersForIntent()
	{
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x15E1148", Offset = "0x15E1148", VA = "0x15E1148")]
	private void UpdateFingersFree()
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x15E1994", Offset = "0x15E1994", VA = "0x15E1994")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED5A4", Offset = "0xAED5A4")]
	public void RelaxHand()
	{
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x15E1A00", Offset = "0x15E1A00", VA = "0x15E1A00")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED5DC", Offset = "0xAED5DC")]
	public void OpenHand()
	{
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x15E1A6C", Offset = "0x15E1A6C", VA = "0x15E1A6C")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED614", Offset = "0xAED614")]
	public void CloseHand()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x15E1AE4", Offset = "0x15E1AE4", VA = "0x15E1AE4")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0xAED64C", Offset = "0xAED64C")]
	public void ProceduralFingerBend()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x15E1AF0", Offset = "0x15E1AF0", VA = "0x15E1AF0")]
	public void ProceduralFingerBend(int layermask)
	{
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x15E1B70", Offset = "0x15E1B70", VA = "0x15E1B70")]
	public void ProceduralFingerBend(RaycastHit hit)
	{
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x15E1C18", Offset = "0x15E1C18", VA = "0x15E1C18")]
	public static void SetLayerRecursive(Transform obj, int fromLayer, int toLayer)
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x15DE1BC", Offset = "0x15DE1BC", VA = "0x15DE1BC")]
	private static void SetLayerRecursive(Transform obj, int newLayer)
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x15E1D28", Offset = "0x15E1D28", VA = "0x15E1D28")]
	public HandPhysics()
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x15E0D8C", Offset = "0x15E0D8C", VA = "0x15E0D8C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED684", Offset = "0xAED684")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED684", Offset = "0xAED684")]
	private IEnumerator <Snap>g__PreventInterpolation|107_0()
	{
		return null;
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x15E1DE4", Offset = "0x15E1DE4", VA = "0x15E1DE4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED6F4", Offset = "0xAED6F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED6F4", Offset = "0xAED6F4")]
	private IEnumerator <GrabObject>g__AutoAllign|115_0()
	{
		return null;
	}

	[Token(Token = "0x60006F8")]
	[Address(RVA = "0x15E158C", Offset = "0x15E158C", VA = "0x15E158C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED764", Offset = "0xAED764")]
	internal static void <SetIntentPose>g__AssignChildrenPose|116_0(Transform obj, BrinkHandPoseData pose, ref <>c__DisplayClass116_0 P_2)
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x15E176C", Offset = "0x15E176C", VA = "0x15E176C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED774", Offset = "0xAED774")]
	internal static void <UpdateFingersForIntent>g__AssignChildrenPose|120_0(Transform obj, BrinkHandPoseData pose, ref <>c__DisplayClass120_0 P_2)
	{
	}
}
[Token(Token = "0x2000131")]
public class HandStabilizer : MonoBehaviour
{
	[Token(Token = "0x40006E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private HandPhysics[] hands;

	[Token(Token = "0x6000712")]
	[Address(RVA = "0x15E1E50", Offset = "0x15E1E50", VA = "0x15E1E50")]
	private void Start()
	{
	}

	[Token(Token = "0x6000713")]
	[Address(RVA = "0x15E1ECC", Offset = "0x15E1ECC", VA = "0x15E1ECC")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x6000714")]
	[Address(RVA = "0x15E1F34", Offset = "0x15E1F34", VA = "0x15E1F34")]
	private void OnPreRender()
	{
	}

	[Token(Token = "0x6000715")]
	[Address(RVA = "0x15E1F9C", Offset = "0x15E1F9C", VA = "0x15E1F9C")]
	public HandStabilizer()
	{
	}
}
[Token(Token = "0x2000132")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE4864", Offset = "0xAE4864")]
public class PlacePoint : MonoBehaviour
{
	[Token(Token = "0x40006E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA5C4", Offset = "0xAEA5C4")]
	public float placeRadius;

	[Token(Token = "0x40006E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA5FC", Offset = "0xAEA5FC")]
	public Vector3 offset;

	[Token(Token = "0x40006E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA634", Offset = "0xAEA634")]
	public string[] placeNames;

	[Token(Token = "0x40006E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA66C", Offset = "0xAEA66C")]
	public bool makeKinematic;

	[Token(Token = "0x40006E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA6A4", Offset = "0xAEA6A4")]
	public Grabbable startPlaced;

	[Token(Token = "0x40006E6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA6DC", Offset = "0xAEA6DC")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA6DC", Offset = "0xAEA6DC")]
	public Rigidbody jointLink;

	[Token(Token = "0x40006E7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public int jointBreakForce;

	[Token(Token = "0x40006E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public int jointBreakTorque;

	[Token(Token = "0x40006E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEA73C", Offset = "0xAEA73C")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA73C", Offset = "0xAEA73C")]
	public bool callGrabbableHighlight;

	[Token(Token = "0x40006EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UnityEvent OnPlace;

	[Token(Token = "0x40006EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public UnityEvent OnRemove;

	[Token(Token = "0x40006EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public UnityEvent OnHighlight;

	[Token(Token = "0x40006ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public UnityEvent OnStopHighlight;

	[Token(Token = "0x40006EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private FixedJoint joint;

	[Token(Token = "0x40006EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Grabbable placedObject;

	[Token(Token = "0x40006F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool occupied;

	[Token(Token = "0x40006F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private SphereCollider col;

	[Token(Token = "0x40006F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private Transform originParent;

	[Token(Token = "0x6000716")]
	[Address(RVA = "0x108B0AC", Offset = "0x108B0AC", VA = "0x108B0AC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000717")]
	[Address(RVA = "0x108B1EC", Offset = "0x108B1EC", VA = "0x108B1EC", Slot = "4")]
	public virtual bool CanPlace(Transform placeObj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000718")]
	[Address(RVA = "0x108B2A0", Offset = "0x108B2A0", VA = "0x108B2A0", Slot = "5")]
	public virtual void Place(Grabbable placeObj)
	{
	}

	[Token(Token = "0x6000719")]
	[Address(RVA = "0x108B4EC", Offset = "0x108B4EC", VA = "0x108B4EC", Slot = "6")]
	public virtual void Remove(Grabbable placeObj)
	{
	}

	[Token(Token = "0x600071A")]
	[Address(RVA = "0x108B56C", Offset = "0x108B56C", VA = "0x108B56C")]
	private void OnJointBreak(float breakForce)
	{
	}

	[Token(Token = "0x600071B")]
	[Address(RVA = "0x108B660", Offset = "0x108B660", VA = "0x108B660")]
	public Grabbable PlacedObject()
	{
		return null;
	}

	[Token(Token = "0x600071C")]
	[Address(RVA = "0x108B668", Offset = "0x108B668", VA = "0x108B668")]
	internal float Distance(Transform from)
	{
		return default(float);
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x108B6F0", Offset = "0x108B6F0", VA = "0x108B6F0")]
	internal void Highlight()
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x108B77C", Offset = "0x108B77C", VA = "0x108B77C")]
	internal void StopHighlight()
	{
	}

	[Token(Token = "0x600071F")]
	[Address(RVA = "0x108B808", Offset = "0x108B808", VA = "0x108B808")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000720")]
	[Address(RVA = "0x108B8C0", Offset = "0x108B8C0", VA = "0x108B8C0")]
	public PlacePoint()
	{
	}
}
[Token(Token = "0x2000133")]
public class Compass : Grabbable
{
	[Token(Token = "0x2000134")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE48C4", Offset = "0xAE48C4")]
	private sealed class <CheckIfHeldOnNextFrame>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000705")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000706")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000707")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Compass <>4__this;

		[Token(Token = "0x4000708")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool animate;

		[Token(Token = "0x17000129")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000737")]
			[Address(RVA = "0xE40834", Offset = "0xE40834", VA = "0xE40834", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000739")]
			[Address(RVA = "0xE4087C", Offset = "0xE4087C", VA = "0xE4087C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000734")]
		[Address(RVA = "0xE406E0", Offset = "0xE406E0", VA = "0xE406E0")]
		[DebuggerHidden]
		public <CheckIfHeldOnNextFrame>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x6000735")]
		[Address(RVA = "0xE4070C", Offset = "0xE4070C", VA = "0xE4070C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000736")]
		[Address(RVA = "0xE40710", Offset = "0xE40710", VA = "0xE40710", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000738")]
		[Address(RVA = "0xE4083C", Offset = "0xE4083C", VA = "0xE4083C", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40006F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool ACTIVE;

	[Token(Token = "0x40006F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA79C", Offset = "0xAEA79C")]
	public Transform PointingTransform;

	[Token(Token = "0x40006F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public Transform Ring;

	[Token(Token = "0x40006F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Line AimLine;

	[Token(Token = "0x40006F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Line GuideLine;

	[Token(Token = "0x40006F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Disc AimIcon;

	[Token(Token = "0x40006F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public Disc POIIcon;

	[Token(Token = "0x40006FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public GameObject POIPrefab;

	[Token(Token = "0x40006FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public GameObject TeleportPrefab;

	[Token(Token = "0x40006FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Transform ScaleAnimationRoot;

	[Token(Token = "0x40006FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public GameObject MarkersContainer;

	[Token(Token = "0x40006FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private Dictionary<Marker, GameObject> MarkerToIconGameObject;

	[Token(Token = "0x40006FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private Dictionary<Marker, MeshRenderer> MarkerToIconRenderer;

	[Token(Token = "0x4000700")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Marker[] CurrentMarkers;

	[Token(Token = "0x4000701")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private Marker PointingAtMarker;

	[Token(Token = "0x4000702")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private Marker LookingAtMarker;

	[Token(Token = "0x4000703")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
	private Marker LastLookingAtMarker;

	[Token(Token = "0x4000704")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
	private bool Scanning;

	[Token(Token = "0x6000721")]
	[Address(RVA = "0x15D2B1C", Offset = "0x15D2B1C", VA = "0x15D2B1C", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000722")]
	[Address(RVA = "0x15D2FBC", Offset = "0x15D2FBC", VA = "0x15D2FBC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000723")]
	[Address(RVA = "0x15D31D8", Offset = "0x15D31D8", VA = "0x15D31D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000724")]
	[Address(RVA = "0x15D3224", Offset = "0x15D3224", VA = "0x15D3224")]
	private void Update()
	{
	}

	[Token(Token = "0x6000725")]
	[Address(RVA = "0x15D4248", Offset = "0x15D4248", VA = "0x15D4248")]
	public void Init(Marker[] markers)
	{
	}

	[Token(Token = "0x6000726")]
	[Address(RVA = "0x15D48A0", Offset = "0x15D48A0", VA = "0x15D48A0")]
	public void Hide(bool v = true)
	{
	}

	[Token(Token = "0x6000727")]
	[Address(RVA = "0x15D4968", Offset = "0x15D4968", VA = "0x15D4968")]
	private void OnMarkerClicked(Marker arg0)
	{
	}

	[Token(Token = "0x6000728")]
	[Address(RVA = "0x15D4554", Offset = "0x15D4554", VA = "0x15D4554")]
	private void RemoveCurrentMarkers()
	{
	}

	[Token(Token = "0x6000729")]
	[Address(RVA = "0x15D4970", Offset = "0x15D4970", VA = "0x15D4970")]
	private void OnMarkerPointerEnter(Marker marker)
	{
	}

	[Token(Token = "0x600072A")]
	[Address(RVA = "0x15D4978", Offset = "0x15D4978", VA = "0x15D4978")]
	private void OnMarkerPointerExit(Marker marker)
	{
	}

	[Token(Token = "0x600072B")]
	[Address(RVA = "0x15D41AC", Offset = "0x15D41AC", VA = "0x15D41AC")]
	private void RotateToPosition(Transform t, Vector3 p)
	{
	}

	[Token(Token = "0x600072C")]
	[Address(RVA = "0x15D4980", Offset = "0x15D4980", VA = "0x15D4980")]
	private void OnGrab(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x600072D")]
	[Address(RVA = "0x15D4A70", Offset = "0x15D4A70", VA = "0x15D4A70")]
	private void OnRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x600072E")]
	[Address(RVA = "0x15D4B4C", Offset = "0x15D4B4C", VA = "0x15D4B4C")]
	private void OnForceRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x600072F")]
	[Address(RVA = "0x15D4ACC", Offset = "0x15D4ACC", VA = "0x15D4ACC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED8C4", Offset = "0xAED8C4")]
	private IEnumerator CheckIfHeldOnNextFrame(bool animate = true)
	{
		return null;
	}

	[Token(Token = "0x6000730")]
	[Address(RVA = "0x15D4BA8", Offset = "0x15D4BA8", VA = "0x15D4BA8")]
	private void Close(bool animate)
	{
	}

	[Token(Token = "0x6000731")]
	[Address(RVA = "0x15D4D1C", Offset = "0x15D4D1C", VA = "0x15D4D1C")]
	public Compass()
	{
	}

	[Token(Token = "0x6000732")]
	[Address(RVA = "0x15D4E14", Offset = "0x15D4E14", VA = "0x15D4E14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED924", Offset = "0xAED924")]
	private void <OnEnable>b__19_0()
	{
	}

	[Token(Token = "0x6000733")]
	[Address(RVA = "0x15D4E34", Offset = "0x15D4E34", VA = "0x15D4E34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED934", Offset = "0xAED934")]
	private void <Close>b__33_0()
	{
	}
}
[Token(Token = "0x2000135")]
public class Diorama : MonoBehaviour
{
	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Arrow;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Grabbable Grabbable;

	[Token(Token = "0x600073A")]
	[Address(RVA = "0x15D5CB4", Offset = "0x15D5CB4", VA = "0x15D5CB4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600073B")]
	[Address(RVA = "0x15D5D08", Offset = "0x15D5D08", VA = "0x15D5D08")]
	private void Update()
	{
	}

	[Token(Token = "0x600073C")]
	[Address(RVA = "0x15D5D34", Offset = "0x15D5D34", VA = "0x15D5D34")]
	public Diorama()
	{
	}
}
[Token(Token = "0x2000136")]
public class Notepad : MonoBehaviour
{
	[Token(Token = "0x2000137")]
	public enum LastActionTypes
	{
		[Token(Token = "0x400071D")]
		POI,
		[Token(Token = "0x400071E")]
		PHOTO
	}

	[Token(Token = "0x2000138")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE48D4", Offset = "0xAE48D4")]
	private sealed class <CheckIfHeldOnNextFrame>d__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400071F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Notepad <>4__this;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool animate;

		[Token(Token = "0x1700012E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600075D")]
			[Address(RVA = "0xE4BEF8", Offset = "0xE4BEF8", VA = "0xE4BEF8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700012F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0xE4BF40", Offset = "0xE4BF40", VA = "0xE4BF40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600075A")]
		[Address(RVA = "0xE4BD60", Offset = "0xE4BD60", VA = "0xE4BD60")]
		[DebuggerHidden]
		public <CheckIfHeldOnNextFrame>d__43(int <>1__state)
		{
		}

		[Token(Token = "0x600075B")]
		[Address(RVA = "0xE4BD8C", Offset = "0xE4BD8C", VA = "0xE4BD8C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600075C")]
		[Address(RVA = "0xE4BD90", Offset = "0xE4BD90", VA = "0xE4BD90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600075E")]
		[Address(RVA = "0xE4BF00", Offset = "0xE4BF00", VA = "0xE4BF00", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA7D4", Offset = "0xAEA7D4")]
	private static bool <OPENED>k__BackingField;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA7E4", Offset = "0xAEA7E4")]
	private static LastActionTypes <LastActionType>k__BackingField;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA7F4", Offset = "0xAEA7F4")]
	public Transform ScaleAnimationRoot;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Grabbable Grabbable;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject PagePois;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public GameObject PagePhotos;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public FlatButtonVR PhotosButton;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FlatButtonVR POIsButton;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform Marker;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro LocationName;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform SideButtons;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform BottomButtons;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 DefaultPagePhotosPosition;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private Vector3 DefaultMarkerPosition;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Vector3 PhotoAnimationStartPosition;

	[Token(Token = "0x400071B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Vector3 PhotoAnimationStartEulers;

	[Token(Token = "0x1700012B")]
	public static bool OPENED
	{
		[Token(Token = "0x600073E")]
		[Address(RVA = "0x100997C", Offset = "0x100997C", VA = "0x100997C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED9A4", Offset = "0xAED9A4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600073D")]
		[Address(RVA = "0x1009928", Offset = "0x1009928", VA = "0x1009928")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED994", Offset = "0xAED994")]
		private set
		{
		}
	}

	[Token(Token = "0x1700012C")]
	public static LastActionTypes LastActionType
	{
		[Token(Token = "0x600073F")]
		[Address(RVA = "0x10099C8", Offset = "0x10099C8", VA = "0x10099C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED9B4", Offset = "0xAED9B4")]
		get
		{
			return default(LastActionTypes);
		}
		[Token(Token = "0x6000740")]
		[Address(RVA = "0x1009A14", Offset = "0x1009A14", VA = "0x1009A14")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAED9C4", Offset = "0xAED9C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700012D")]
	public bool BeingHeld
	{
		[Token(Token = "0x6000741")]
		[Address(RVA = "0x1009A64", Offset = "0x1009A64", VA = "0x1009A64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000742")]
	[Address(RVA = "0x1009A80", Offset = "0x1009A80", VA = "0x1009A80")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000743")]
	[Address(RVA = "0x100A098", Offset = "0x100A098", VA = "0x100A098")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000744")]
	[Address(RVA = "0x100A670", Offset = "0x100A670", VA = "0x100A670")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000745")]
	[Address(RVA = "0x100A6BC", Offset = "0x100A6BC", VA = "0x100A6BC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000746")]
	[Address(RVA = "0x100A8B0", Offset = "0x100A8B0", VA = "0x100A8B0")]
	public void HideLastPictureAndGetPosition(ref Vector3 position)
	{
	}

	[Token(Token = "0x6000747")]
	[Address(RVA = "0x100A920", Offset = "0x100A920", VA = "0x100A920")]
	public void ShowLastPicture()
	{
	}

	[Token(Token = "0x6000748")]
	[Address(RVA = "0x100A980", Offset = "0x100A980", VA = "0x100A980")]
	public void RefreshPhotos()
	{
	}

	[Token(Token = "0x6000749")]
	[Address(RVA = "0x100A9BC", Offset = "0x100A9BC", VA = "0x100A9BC")]
	public void OpenForPhotoAnimation()
	{
	}

	[Token(Token = "0x600074A")]
	[Address(RVA = "0x100AE78", Offset = "0x100AE78", VA = "0x100AE78")]
	public void CloseAfterPhotoAnimation()
	{
	}

	[Token(Token = "0x600074B")]
	[Address(RVA = "0x100B09C", Offset = "0x100B09C", VA = "0x100B09C")]
	private void OnPhotosButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x600074C")]
	[Address(RVA = "0x100B0A4", Offset = "0x100B0A4", VA = "0x100B0A4")]
	private void OnPOIsButtonSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x600074D")]
	[Address(RVA = "0x100A15C", Offset = "0x100A15C", VA = "0x100A15C")]
	private void ShowPhotosPage(bool animate = true)
	{
	}

	[Token(Token = "0x600074E")]
	[Address(RVA = "0x1009D78", Offset = "0x1009D78", VA = "0x1009D78")]
	private void ShowPOIsPage(bool animate = true)
	{
	}

	[Token(Token = "0x600074F")]
	[Address(RVA = "0x100A590", Offset = "0x100A590", VA = "0x100A590")]
	private void OpenAnimation()
	{
	}

	[Token(Token = "0x6000750")]
	[Address(RVA = "0x100B0AC", Offset = "0x100B0AC", VA = "0x100B0AC")]
	private void Close()
	{
	}

	[Token(Token = "0x6000751")]
	[Address(RVA = "0x100B1F0", Offset = "0x100B1F0", VA = "0x100B1F0")]
	private void OnGrabEvent(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x6000752")]
	[Address(RVA = "0x100B210", Offset = "0x100B210", VA = "0x100B210")]
	private void OnRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x6000753")]
	[Address(RVA = "0x100B26C", Offset = "0x100B26C", VA = "0x100B26C")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAED9D4", Offset = "0xAED9D4")]
	private IEnumerator CheckIfHeldOnNextFrame(bool animate = true)
	{
		return null;
	}

	[Token(Token = "0x6000754")]
	[Address(RVA = "0x100B2EC", Offset = "0x100B2EC", VA = "0x100B2EC")]
	private void OnForceRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x6000755")]
	[Address(RVA = "0x100B348", Offset = "0x100B348", VA = "0x100B348")]
	public Notepad()
	{
	}

	[Token(Token = "0x6000756")]
	[Address(RVA = "0x100B350", Offset = "0x100B350", VA = "0x100B350")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDA34", Offset = "0xAEDA34")]
	private void <OpenForPhotoAnimation>b__33_0()
	{
	}

	[Token(Token = "0x6000757")]
	[Address(RVA = "0x100B37C", Offset = "0x100B37C", VA = "0x100B37C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDA44", Offset = "0xAEDA44")]
	private void <CloseAfterPhotoAnimation>b__34_0()
	{
	}

	[Token(Token = "0x6000758")]
	[Address(RVA = "0x100B3F8", Offset = "0x100B3F8", VA = "0x100B3F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDA54", Offset = "0xAEDA54")]
	private void <ShowPOIsPage>b__38_0()
	{
	}

	[Token(Token = "0x6000759")]
	[Address(RVA = "0x100B45C", Offset = "0x100B45C", VA = "0x100B45C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDA64", Offset = "0xAEDA64")]
	private void <Close>b__40_0()
	{
	}
}
[Token(Token = "0x2000139")]
public class NotepadInfo : MonoBehaviour
{
	[Token(Token = "0x200013A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE48E4", Offset = "0xAE48E4")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int index;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public NotepadInfo <>4__this;

		[Token(Token = "0x6000766")]
		[Address(RVA = "0x16702A0", Offset = "0x16702A0", VA = "0x16702A0")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000767")]
		[Address(RVA = "0x16702A8", Offset = "0x16702A8", VA = "0x16702A8")]
		internal void <Setup>b__0(Texture texture, bool noInternet)
		{
		}
	}

	[Token(Token = "0x200013B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE48F4", Offset = "0xAE48F4")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NotepadInfo <>4__this;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro text;

		[Token(Token = "0x6000768")]
		[Address(RVA = "0x1670328", Offset = "0x1670328", VA = "0x1670328")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000769")]
		[Address(RVA = "0x1670330", Offset = "0x1670330", VA = "0x1670330")]
		internal void <RevealInfosByIndexAnimation>b__0()
		{
		}
	}

	[Token(Token = "0x4000723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer Panorama;

	[Token(Token = "0x4000724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro LocationTitle;

	[Token(Token = "0x4000725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer[] Polaroids;

	[Token(Token = "0x4000726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public MeshRenderer[] Checkmarks;

	[Token(Token = "0x4000727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public TextMeshPro[] Titles;

	[Token(Token = "0x4000728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro[] Texts;

	[Token(Token = "0x4000729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public StudioEventEmitter WritingAudio;

	[Token(Token = "0x400072A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Material CheckmarkOn;

	[Token(Token = "0x400072B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Material CheckmarkOFF;

	[Token(Token = "0x400072C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int HiddenInfosIndex;

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x107C798", Offset = "0x107C798", VA = "0x107C798")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x107CE74", Offset = "0x107CE74", VA = "0x107CE74")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x107C7A0", Offset = "0x107C7A0", VA = "0x107C7A0")]
	private void Setup(bool force = false)
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x107D108", Offset = "0x107D108", VA = "0x107D108")]
	public void HideInfosByIndex(int index)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x107D2B4", Offset = "0x107D2B4", VA = "0x107D2B4")]
	public void RevealInfosByIndexAnimation(int index)
	{
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x107D618", Offset = "0x107D618", VA = "0x107D618")]
	public NotepadInfo()
	{
	}
}
[Token(Token = "0x200013C")]
public class NotepadPhoto : MonoBehaviour
{
	[Token(Token = "0x4000731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer Image;

	[Token(Token = "0x4000732")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public FlatButtonVR ShareButton;

	[Token(Token = "0x4000733")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public CollisionTriggerNotifier ButtonRevealTriggerNotifier;

	[Token(Token = "0x4000734")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<string, Texture2D> pathToTexture;

	[Token(Token = "0x4000735")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal Texture2D CurrentTexture;

	[Token(Token = "0x4000736")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	internal string CurrentPhotoPath;

	[Token(Token = "0x4000737")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool IndexIsClose;

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x107D628", Offset = "0x107D628", VA = "0x107D628")]
	private void Awake()
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x107D744", Offset = "0x107D744", VA = "0x107D744")]
	private void Update()
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x107D7E8", Offset = "0x107D7E8", VA = "0x107D7E8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x107D7F0", Offset = "0x107D7F0", VA = "0x107D7F0")]
	public void Show(string photoPath)
	{
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x107DAD8", Offset = "0x107DAD8", VA = "0x107DAD8")]
	public void Hide()
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x107DB00", Offset = "0x107DB00", VA = "0x107DB00")]
	private void OnIntentColliderTriggerStay(Collider arg0)
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x107DB08", Offset = "0x107DB08", VA = "0x107DB08")]
	private void OnIntentColliderTriggerEnter(Collider arg0)
	{
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x107D8B4", Offset = "0x107D8B4", VA = "0x107D8B4")]
	private static Texture2D LoadPNG(string filePath)
	{
		return null;
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x107DB14", Offset = "0x107DB14", VA = "0x107DB14")]
	public NotepadPhoto()
	{
	}
}
[Token(Token = "0x200013D")]
public class NotepadPhotos : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200013E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4904", Offset = "0xAE4904")]
	private sealed class <>c
	{
		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<FileInfo, DateTime> <>9__20_0;

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x16703D8", Offset = "0x16703D8", VA = "0x16703D8")]
		public <>c()
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x16703E0", Offset = "0x16703E0", VA = "0x16703E0")]
		internal DateTime <OnEnable>b__20_0(FileInfo p)
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x200013F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4914", Offset = "0xAE4914")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationInfo locationInfo;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool loadingLocationInfo;

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x16703FC", Offset = "0x16703FC", VA = "0x16703FC")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x1670404", Offset = "0x1670404", VA = "0x1670404")]
		internal void <Share>b__0(LocationInfo info)
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x1670410", Offset = "0x1670410", VA = "0x1670410")]
		internal void <Share>b__1(string id)
		{
		}
	}

	[Token(Token = "0x2000140")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4924", Offset = "0xAE4924")]
	private sealed class <Share>d__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string path;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private <>c__DisplayClass30_0 <>8__1;

		[Token(Token = "0x400074F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NotepadPhotos <>4__this;

		[Token(Token = "0x4000750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Texture2D texture;

		[Token(Token = "0x4000751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private string <shareText>5__2;

		[Token(Token = "0x17000132")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x1670E28", Offset = "0x1670E28", VA = "0x1670E28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000133")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x1670E70", Offset = "0x1670E70", VA = "0x1670E70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x1670870", Offset = "0x1670870", VA = "0x1670870")]
		[DebuggerHidden]
		public <Share>d__30(int <>1__state)
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x167089C", Offset = "0x167089C", VA = "0x167089C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x16708A0", Offset = "0x16708A0", VA = "0x16708A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x1670E30", Offset = "0x1670E30", VA = "0x1670E30", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000141")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4934", Offset = "0xAE4934")]
	private sealed class <SaveImage>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string postcardText;

		[Token(Token = "0x4000755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Texture texture;

		[Token(Token = "0x4000756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NotepadPhotos <>4__this;

		[Token(Token = "0x4000757")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private RenderTexture <RT>5__2;

		[Token(Token = "0x17000134")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000799")]
			[Address(RVA = "0x1670820", Offset = "0x1670820", VA = "0x1670820", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000135")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600079B")]
			[Address(RVA = "0x1670868", Offset = "0x1670868", VA = "0x1670868", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x1670418", Offset = "0x1670418", VA = "0x1670418")]
		[DebuggerHidden]
		public <SaveImage>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x1670444", Offset = "0x1670444", VA = "0x1670444", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000798")]
		[Address(RVA = "0x1670448", Offset = "0x1670448", VA = "0x1670448", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x1670828", Offset = "0x1670828", VA = "0x1670828", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000738")]
	public const string PHOTO_PREFIX = "BRINK Traveler";

	[Token(Token = "0x4000739")]
	public const string PHOTO_LOCATION_PREFFIX = " [";

	[Token(Token = "0x400073A")]
	public const string PHOTO_LOCATION_SUFFIX = "] ";

	[Token(Token = "0x400073B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public NotepadPhoto[] Photos;

	[Token(Token = "0x400073C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro HelpText;

	[Token(Token = "0x400073D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public FlatButtonVR PreviousPageButton;

	[Token(Token = "0x400073E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public FlatButtonVR NextPageButton;

	[Token(Token = "0x400073F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Camera PhotoCamera;

	[Token(Token = "0x4000740")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshProUGUI PhotoTitle;

	[Token(Token = "0x4000741")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public RawImage PhotoImage;

	[Token(Token = "0x4000742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshPro Page;

	[Token(Token = "0x4000743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] PhotoPaths;

	[Token(Token = "0x4000744")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private int CurrentPage;

	[Token(Token = "0x4000745")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private string SharedImagePath;

	[Token(Token = "0x4000746")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private int LatestPhotoPageIndex;

	[Token(Token = "0x17000130")]
	public static string STORAGE_DIR_OLD
	{
		[Token(Token = "0x6000774")]
		[Address(RVA = "0x107DBA4", Offset = "0x107DBA4", VA = "0x107DBA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000131")]
	public static string STORAGE_DIR
	{
		[Token(Token = "0x6000775")]
		[Address(RVA = "0x107DBF4", Offset = "0x107DBF4", VA = "0x107DBF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x107DD38", Offset = "0x107DD38", VA = "0x107DD38")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x107DF00", Offset = "0x107DF00", VA = "0x107DF00")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x107E4B0", Offset = "0x107E4B0", VA = "0x107E4B0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x107E4F4", Offset = "0x107E4F4", VA = "0x107E4F4")]
	private void Update()
	{
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x107E5EC", Offset = "0x107E5EC", VA = "0x107E5EC")]
	public void HideLastPictureAndGetPosition(ref Vector3 position)
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x107E694", Offset = "0x107E694", VA = "0x107E694")]
	public void ShowLastPicture()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x107E29C", Offset = "0x107E29C", VA = "0x107E29C")]
	private void ShowCurrentPage()
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x107E438", Offset = "0x107E438", VA = "0x107E438")]
	private void TurnPrevNextOnOff()
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x107E6EC", Offset = "0x107E6EC", VA = "0x107E6EC")]
	private void OnNextSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x107E6FC", Offset = "0x107E6FC", VA = "0x107E6FC")]
	private void OnPreviousSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x107E70C", Offset = "0x107E70C", VA = "0x107E70C")]
	private void OnShareSelected(ButtonBase button)
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x107E7A8", Offset = "0x107E7A8", VA = "0x107E7A8")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDAC4", Offset = "0xAEDAC4")]
	private IEnumerator Share(Texture2D texture, string path)
	{
		return null;
	}

	[Token(Token = "0x6000782")]
	[Address(RVA = "0x107E828", Offset = "0x107E828", VA = "0x107E828")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDB24", Offset = "0xAEDB24")]
	private IEnumerator SaveImage(string postcardText, Texture texture)
	{
		return null;
	}

	[Token(Token = "0x6000783")]
	[Address(RVA = "0x107E8A8", Offset = "0x107E8A8", VA = "0x107E8A8")]
	private void ShareImage(string text)
	{
	}

	[Token(Token = "0x6000784")]
	[Address(RVA = "0x107EB78", Offset = "0x107EB78", VA = "0x107EB78")]
	private void OnOculusShareComplete(Message<ShareMediaResult> message)
	{
	}

	[Token(Token = "0x6000785")]
	[Address(RVA = "0x107E4B4", Offset = "0x107E4B4", VA = "0x107E4B4")]
	private void DeleteGeneratedImage()
	{
	}

	[Token(Token = "0x6000786")]
	[Address(RVA = "0x107EB30", Offset = "0x107EB30", VA = "0x107EB30")]
	private void ShareSucceeded()
	{
	}

	[Token(Token = "0x6000787")]
	[Address(RVA = "0x107ECF0", Offset = "0x107ECF0", VA = "0x107ECF0")]
	private void ShareCanceled()
	{
	}

	[Token(Token = "0x6000788")]
	[Address(RVA = "0x107EA68", Offset = "0x107EA68", VA = "0x107EA68")]
	private void ShareFailed()
	{
	}

	[Token(Token = "0x6000789")]
	[Address(RVA = "0x107EE40", Offset = "0x107EE40", VA = "0x107EE40")]
	public NotepadPhotos()
	{
	}
}
[Token(Token = "0x2000142")]
public class Watch : MonoBehaviour
{
	[Token(Token = "0x4000758")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject Menu;

	[Token(Token = "0x4000759")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer WatchRenderer;

	[Token(Token = "0x400075A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public GameObject MultiplayerBadge;

	[Token(Token = "0x400075B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject MultiplayerMute;

	[Token(Token = "0x400075C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public WatchButton MenuButton;

	[Token(Token = "0x400075D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public WatchButton AppMenuButton;

	[Token(Token = "0x400075E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public WatchButton MultiplayerButton;

	[Token(Token = "0x400075F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public WatchButton NightModeButton;

	[Token(Token = "0x4000760")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro BuildNumber;

	[Token(Token = "0x4000761")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private HandPhysics LeftHand;

	[Token(Token = "0x4000762")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private TextMeshPro MultiplayerBadgeField;

	[Token(Token = "0x4000763")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private bool PlayerLookingAt;

	[Token(Token = "0x4000764")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly int MAIN_TEX;

	[Token(Token = "0x600079C")]
	[Address(RVA = "0xE3B044", Offset = "0xE3B044", VA = "0xE3B044")]
	private void Awake()
	{
	}

	[Token(Token = "0x600079D")]
	[Address(RVA = "0xE3B0C8", Offset = "0xE3B0C8", VA = "0xE3B0C8")]
	private void Update()
	{
	}

	[Token(Token = "0x600079E")]
	[Address(RVA = "0xE3BBAC", Offset = "0xE3BBAC", VA = "0xE3BBAC")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600079F")]
	[Address(RVA = "0xE3BC14", Offset = "0xE3BC14", VA = "0xE3BC14")]
	public Watch()
	{
	}
}
[Token(Token = "0x2000143")]
public class WatchInfo : MonoBehaviour
{
	[Token(Token = "0x4000765")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro InfoField;

	[Token(Token = "0x4000766")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool UsingImperial;

	[Token(Token = "0x4000767")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static UnityEvent UsingImperialChanged;

	[Token(Token = "0x60007A1")]
	[Address(RVA = "0xE3C250", Offset = "0xE3C250", VA = "0xE3C250")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007A2")]
	[Address(RVA = "0xE3C254", Offset = "0xE3C254", VA = "0xE3C254")]
	private void UpdateInfo()
	{
	}

	[Token(Token = "0x60007A3")]
	[Address(RVA = "0xE3C640", Offset = "0xE3C640", VA = "0xE3C640")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60007A4")]
	[Address(RVA = "0xE3C80C", Offset = "0xE3C80C", VA = "0xE3C80C")]
	public WatchInfo()
	{
	}

	[Token(Token = "0x60007A6")]
	[Address(RVA = "0xE3C898", Offset = "0xE3C898", VA = "0xE3C898")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDC24", Offset = "0xAEDC24")]
	private void <OnCollisionEnter>b__5_0()
	{
	}
}
[Token(Token = "0x2000144")]
public class WatchMute : MonoBehaviour
{
	[Token(Token = "0x4000768")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer Bg;

	[Token(Token = "0x4000769")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer Icon;

	[Token(Token = "0x400076A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Material MutedBgMaterial;

	[Token(Token = "0x400076B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Material DefaultBgMaterial;

	[Token(Token = "0x400076C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly Color ColorMuted;

	[Token(Token = "0x400076D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float LastTriggerTime;

	[Token(Token = "0x60007A7")]
	[Address(RVA = "0xE3C944", Offset = "0xE3C944", VA = "0xE3C944")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007A8")]
	[Address(RVA = "0xE3C978", Offset = "0xE3C978", VA = "0xE3C978")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60007A9")]
	[Address(RVA = "0xE3CAC0", Offset = "0xE3CAC0", VA = "0xE3CAC0")]
	private void OnCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x60007AA")]
	[Address(RVA = "0xE3CAC4", Offset = "0xE3CAC4", VA = "0xE3CAC4")]
	private void Update()
	{
	}

	[Token(Token = "0x60007AB")]
	[Address(RVA = "0xE3CC24", Offset = "0xE3CC24", VA = "0xE3CC24")]
	public WatchMute()
	{
	}
}
[Token(Token = "0x2000145")]
public class AppMenuAboutUsPanel : MonoBehaviour
{
	[Token(Token = "0x400076E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro CreditsText;

	[Token(Token = "0x400076F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private string OriginalText;

	[Token(Token = "0x60007AC")]
	[Address(RVA = "0x11904BC", Offset = "0x11904BC", VA = "0x11904BC")]
	private void Start()
	{
	}

	[Token(Token = "0x60007AD")]
	[Address(RVA = "0x11905A8", Offset = "0x11905A8", VA = "0x11905A8")]
	private void UpdateTexts()
	{
	}

	[Token(Token = "0x60007AE")]
	[Address(RVA = "0x1190910", Offset = "0x1190910", VA = "0x1190910")]
	public AppMenuAboutUsPanel()
	{
	}
}
[Token(Token = "0x2000146")]
public class AppMenuSettingsOption : MonoBehaviour
{
	[Token(Token = "0x4000770")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro TitleField;

	[Token(Token = "0x4000771")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public TextMeshPro ValueField;

	[Token(Token = "0x4000772")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro Dots;

	[Token(Token = "0x4000773")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public FlatButtonVR PrevButton;

	[Token(Token = "0x4000774")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public FlatButtonVR NextButton;

	[Token(Token = "0x4000775")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly AppMenuSettingsOptionEvent OnChangeEvent;

	[Token(Token = "0x4000776")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private string[] ValueKeys;

	[Token(Token = "0x4000777")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private int CurrentValueIndex;

	[Token(Token = "0x4000778")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private int Length;

	[Token(Token = "0x4000779")]
	private const string KeyPrefix = "UI_Settings_";

	[Token(Token = "0x60007AF")]
	[Address(RVA = "0x1190918", Offset = "0x1190918", VA = "0x1190918")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B0")]
	[Address(RVA = "0x1190A34", Offset = "0x1190A34", VA = "0x1190A34")]
	public AppMenuSettingsOptionEvent Init(string titleKey, string[] valueKeys, int index, int length)
	{
		return null;
	}

	[Token(Token = "0x60007B1")]
	[Address(RVA = "0x1190D08", Offset = "0x1190D08", VA = "0x1190D08")]
	private void OnPrevSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007B2")]
	[Address(RVA = "0x1190D1C", Offset = "0x1190D1C", VA = "0x1190D1C")]
	private void OnNextSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007B3")]
	[Address(RVA = "0x1190B20", Offset = "0x1190B20", VA = "0x1190B20")]
	private void Set(int index, bool dispatch = true)
	{
	}

	[Token(Token = "0x60007B4")]
	[Address(RVA = "0x1190D30", Offset = "0x1190D30", VA = "0x1190D30")]
	public AppMenuSettingsOption()
	{
	}
}
[Token(Token = "0x2000147")]
public class AppMenuSettingsOptionEvent : UnityEvent<AppMenuSettingsOption, int>
{
	[Token(Token = "0x60007B5")]
	[Address(RVA = "0x1190D90", Offset = "0x1190D90", VA = "0x1190D90")]
	public AppMenuSettingsOptionEvent()
	{
	}
}
[Token(Token = "0x2000148")]
public class AppMenuSettingsPanel : MonoBehaviour
{
	[Token(Token = "0x400077A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AppMenuSettingsOption Comfort_Movement;

	[Token(Token = "0x400077B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public AppMenuSettingsOption Comfort_TerrainFolow;

	[Token(Token = "0x400077C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public AppMenuSettingsOption Comfort_MovementSpeed;

	[Token(Token = "0x400077D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public AppMenuSettingsOption Comfort_ForwardDirection;

	[Token(Token = "0x400077E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AppMenuSettingsOption Comfort_Acceleration;

	[Token(Token = "0x400077F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public AppMenuSettingsOption Comfort_Sitting;

	[Token(Token = "0x4000780")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public AppMenuSettingsOption Comfort_Turning;

	[Token(Token = "0x4000781")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public AppMenuSettingsOption Comfort_TurningRate;

	[Token(Token = "0x4000782")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public AppMenuSettingsOption Experience_Language;

	[Token(Token = "0x4000783")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public AppMenuSettingsOption Experience_VirtualGuide;

	[Token(Token = "0x4000784")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public AppMenuSettingsOption Experience_Subtitles;

	[Token(Token = "0x4000785")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public AppMenuSettingsOption Experience_Boundaries;

	[Token(Token = "0x4000786")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public AppMenuSettingsOption Experience_Haptics;

	[Token(Token = "0x4000787")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public AppMenuSettingsOption Experience_Music;

	[Token(Token = "0x4000788")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public FlatButtonVR ResetButton;

	[Token(Token = "0x60007B6")]
	[Address(RVA = "0x1190DDC", Offset = "0x1190DDC", VA = "0x1190DDC")]
	private void Start()
	{
	}

	[Token(Token = "0x60007B7")]
	[Address(RVA = "0x1190EA8", Offset = "0x1190EA8", VA = "0x1190EA8")]
	private void UpdateOptionStates()
	{
	}

	[Token(Token = "0x60007B8")]
	[Address(RVA = "0x1191AC8", Offset = "0x1191AC8", VA = "0x1191AC8")]
	private void OnResetSelected(ButtonBase btn)
	{
	}

	[Token(Token = "0x60007B9")]
	[Address(RVA = "0x1191B34", Offset = "0x1191B34", VA = "0x1191B34")]
	private void OnAnySettingChanged(AppMenuSettingsOption option, int value)
	{
	}

	[Token(Token = "0x60007BA")]
	[Address(RVA = "0x11921F8", Offset = "0x11921F8", VA = "0x11921F8")]
	public AppMenuSettingsPanel()
	{
	}
}
[Token(Token = "0x2000149")]
public class AppMenuVR : Overlay
{
	[Token(Token = "0x4000789")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject DefaultPanels;

	[Token(Token = "0x400078A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public GameObject ResetPanel;

	[Token(Token = "0x400078B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public PressButton CloseButton;

	[Token(Token = "0x400078C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public PressButton CancelButton;

	[Token(Token = "0x400078D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public PressButton ResetConfirmButton;

	[Token(Token = "0x400078E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public TextMeshPro ResetText;

	[Token(Token = "0x400078F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public FlatButtonVR ResetButton;

	[Token(Token = "0x4000790")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public FlatButtonVR ExitButton;

	[Token(Token = "0x4000791")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 HelpViewScale;

	[Token(Token = "0x4000792")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 ResetViewScale;

	[Token(Token = "0x17000136")]
	private bool DefaultPanelIsActive
	{
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x1192200", Offset = "0x1192200", VA = "0x1192200")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000137")]
	private bool ResetPanelIsActive
	{
		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x11922AC", Offset = "0x11922AC", VA = "0x11922AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60007BD")]
	[Address(RVA = "0x1192358", Offset = "0x1192358", VA = "0x1192358", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60007BE")]
	[Address(RVA = "0x11923D8", Offset = "0x11923D8", VA = "0x11923D8")]
	private void Start()
	{
	}

	[Token(Token = "0x60007BF")]
	[Address(RVA = "0x119267C", Offset = "0x119267C", VA = "0x119267C")]
	private void UpdateTexts()
	{
	}

	[Token(Token = "0x60007C0")]
	[Address(RVA = "0x11929D8", Offset = "0x11929D8", VA = "0x11929D8", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60007C1")]
	[Address(RVA = "0x1192BAC", Offset = "0x1192BAC", VA = "0x1192BAC", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60007C2")]
	[Address(RVA = "0x1192C60", Offset = "0x1192C60", VA = "0x1192C60")]
	private void OnResetPress(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007C3")]
	[Address(RVA = "0x1192C68", Offset = "0x1192C68", VA = "0x1192C68")]
	private void OnExitPress(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007C4")]
	[Address(RVA = "0x1192C70", Offset = "0x1192C70", VA = "0x1192C70")]
	private void OnCancelPress(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007C5")]
	[Address(RVA = "0x1192A28", Offset = "0x1192A28", VA = "0x1192A28")]
	private void OpenPanels(GameObject t)
	{
	}

	[Token(Token = "0x60007C6")]
	[Address(RVA = "0x1192C78", Offset = "0x1192C78", VA = "0x1192C78")]
	private void OnResetConfirmPress(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60007C7")]
	[Address(RVA = "0x1192D10", Offset = "0x1192D10", VA = "0x1192D10")]
	private void OnClosePress(ButtonBase btn)
	{
	}

	[Token(Token = "0x60007C8")]
	[Address(RVA = "0x1192D20", Offset = "0x1192D20", VA = "0x1192D20")]
	public AppMenuVR()
	{
	}
}
[Token(Token = "0x200014A")]
public class AtlasIcon : MonoBehaviour
{
	[Token(Token = "0x200014B")]
	public enum ICONS
	{
		[Token(Token = "0x4000796")]
		SETTINGS_RESET,
		[Token(Token = "0x4000797")]
		SETTINGS,
		[Token(Token = "0x4000798")]
		SHARE,
		[Token(Token = "0x4000799")]
		EXIT,
		[Token(Token = "0x400079A")]
		PHOTOS,
		[Token(Token = "0x400079B")]
		CAMERA,
		[Token(Token = "0x400079C")]
		SAVE_NOTEBOOK,
		[Token(Token = "0x400079D")]
		REFRESH,
		[Token(Token = "0x400079E")]
		TRASH,
		[Token(Token = "0x400079F")]
		ARROW_LEFT,
		[Token(Token = "0x40007A0")]
		ARROW_RIGHT,
		[Token(Token = "0x40007A1")]
		CLOSE,
		[Token(Token = "0x40007A2")]
		JOIN,
		[Token(Token = "0x40007A3")]
		INVITE,
		[Token(Token = "0x40007A4")]
		BLOCK,
		[Token(Token = "0x40007A5")]
		BLOCKED,
		[Token(Token = "0x40007A6")]
		MUTE,
		[Token(Token = "0x40007A7")]
		UNMUTE,
		[Token(Token = "0x40007A8")]
		FOV
	}

	[Token(Token = "0x4000793")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ICONS Icon;

	[Token(Token = "0x4000794")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public bool NoIcon;

	[Token(Token = "0x60007C9")]
	[Address(RVA = "0x1193460", Offset = "0x1193460", VA = "0x1193460")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60007CA")]
	[Address(RVA = "0x11936D0", Offset = "0x11936D0", VA = "0x11936D0")]
	public void ChangeIcon(ICONS icon)
	{
	}

	[Token(Token = "0x60007CB")]
	[Address(RVA = "0x1193464", Offset = "0x1193464", VA = "0x1193464")]
	private void UpdateTextureOffset()
	{
	}

	[Token(Token = "0x60007CC")]
	[Address(RVA = "0x11936D8", Offset = "0x11936D8", VA = "0x11936D8")]
	public AtlasIcon()
	{
	}
}
[Token(Token = "0x200014C")]
public class FlatButtonVR : ButtonBase
{
	[Token(Token = "0x40007A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Background;

	[Token(Token = "0x40007AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public ShapeRenderer Highlight;

	[Token(Token = "0x40007AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private CollisionNotifier CollisionNotifier;

	[Token(Token = "0x40007AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private TextMeshPro Label;

	[Token(Token = "0x40007AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private float LastSelectionTime;

	[Token(Token = "0x40007AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private BrinkHand InteractingHand;

	[Token(Token = "0x40007AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private MeshRenderer BackgroundRenderer;

	[Token(Token = "0x40007B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Color DefaultLabelColor;

	[Token(Token = "0x60007CD")]
	[Address(RVA = "0x15D8268", Offset = "0x15D8268", VA = "0x15D8268")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x15D8488", Offset = "0x15D8488", VA = "0x15D8488")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x15D85A4", Offset = "0x15D85A4", VA = "0x15D85A4", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x15D8688", Offset = "0x15D8688", VA = "0x15D8688")]
	private void Update()
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x15D88AC", Offset = "0x15D88AC", VA = "0x15D88AC")]
	private void OnButtonCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x15D8980", Offset = "0x15D8980", VA = "0x15D8980")]
	private void OnButtonCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x60007D3")]
	[Address(RVA = "0x15D89A4", Offset = "0x15D89A4", VA = "0x15D89A4", Slot = "6")]
	public override void Select(bool skipAnimation = false, bool dispatch = true)
	{
	}

	[Token(Token = "0x60007D4")]
	[Address(RVA = "0x15D8D84", Offset = "0x15D8D84", VA = "0x15D8D84", Slot = "7")]
	public override void Deselect(bool skipAnimation = false)
	{
	}

	[Token(Token = "0x60007D5")]
	[Address(RVA = "0x15D8DF0", Offset = "0x15D8DF0", VA = "0x15D8DF0", Slot = "8")]
	protected override void OnSelect(bool dispatch = true)
	{
	}

	[Token(Token = "0x60007D6")]
	[Address(RVA = "0x15D8ED4", Offset = "0x15D8ED4", VA = "0x15D8ED4")]
	public FlatButtonVR()
	{
	}

	[Token(Token = "0x60007D7")]
	[Address(RVA = "0x15D8ED8", Offset = "0x15D8ED8", VA = "0x15D8ED8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDC34", Offset = "0xAEDC34")]
	private float <Select>b__14_0()
	{
		return default(float);
	}

	[Token(Token = "0x60007D8")]
	[Address(RVA = "0x15D8F04", Offset = "0x15D8F04", VA = "0x15D8F04")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDC44", Offset = "0xAEDC44")]
	private void <Select>b__14_1(float x)
	{
	}

	[Token(Token = "0x60007D9")]
	[Address(RVA = "0x15D8FBC", Offset = "0x15D8FBC", VA = "0x15D8FBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDC54", Offset = "0xAEDC54")]
	private void <Select>b__14_2()
	{
	}
}
[Token(Token = "0x200014D")]
public class IntroVR : IntroBase
{
	[Token(Token = "0x200014E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4944", Offset = "0xAE4944")]
	private sealed class <Play>d__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroVR <>4__this;

		[Token(Token = "0x40007BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool skipAnimations;

		[Token(Token = "0x17000138")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0xE43398", Offset = "0xE43398", VA = "0xE43398", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000139")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0xE433E0", Offset = "0xE433E0", VA = "0xE433E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007E5")]
		[Address(RVA = "0xE42E10", Offset = "0xE42E10", VA = "0xE42E10")]
		[DebuggerHidden]
		public <Play>d__13(int <>1__state)
		{
		}

		[Token(Token = "0x60007E6")]
		[Address(RVA = "0xE42E3C", Offset = "0xE42E3C", VA = "0xE42E3C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007E7")]
		[Address(RVA = "0xE42E40", Offset = "0xE42E40", VA = "0xE42E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0xE433A0", Offset = "0xE433A0", VA = "0xE433A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200014F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4954", Offset = "0xAE4954")]
	private sealed class <LoadPrerequisites>d__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40007C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40007C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40007C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IntroVR <>4__this;

		[Token(Token = "0x1700013A")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0xE42DC0", Offset = "0xE42DC0", VA = "0xE42DC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013B")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0xE42E08", Offset = "0xE42E08", VA = "0xE42E08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0xE42B00", Offset = "0xE42B00", VA = "0xE42B00")]
		[DebuggerHidden]
		public <LoadPrerequisites>d__14(int <>1__state)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0xE42B2C", Offset = "0xE42B2C", VA = "0xE42B2C", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0xE42B30", Offset = "0xE42B30", VA = "0xE42B30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0xE42DC8", Offset = "0xE42DC8", VA = "0xE42DC8", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x40007B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool SKIPPED;

	[Token(Token = "0x40007B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public UIFader LoadingTexts;

	[Token(Token = "0x40007B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public UIFader Logo;

	[Token(Token = "0x40007B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public TextMeshPro HeadphonesField;

	[Token(Token = "0x40007B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshPro LoadingField;

	[Token(Token = "0x40007B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Vector3 HeadphonesDefaultPos;

	[Token(Token = "0x40007B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 LoadingDefaultPos;

	[Token(Token = "0x40007B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 LogoDefaultPos;

	[Token(Token = "0x40007B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Coroutine PlayCo;

	[Token(Token = "0x40007BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Transform DefaultTransform;

	[Token(Token = "0x40007BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool CanSkip;

	[Token(Token = "0x60007DA")]
	[Address(RVA = "0x15E3EC4", Offset = "0x15E3EC4", VA = "0x15E3EC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x60007DB")]
	[Address(RVA = "0x15E41DC", Offset = "0x15E41DC", VA = "0x15E41DC", Slot = "4")]
	public override void Launch(bool skipAnimations = false)
	{
	}

	[Token(Token = "0x60007DC")]
	[Address(RVA = "0x15E4214", Offset = "0x15E4214", VA = "0x15E4214")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDC64", Offset = "0xAEDC64")]
	private IEnumerator Play(bool skipAnimations)
	{
		return null;
	}

	[Token(Token = "0x60007DD")]
	[Address(RVA = "0x15E4294", Offset = "0x15E4294", VA = "0x15E4294")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDCC4", Offset = "0xAEDCC4")]
	private IEnumerator LoadPrerequisites()
	{
		return null;
	}

	[Token(Token = "0x60007DE")]
	[Address(RVA = "0x15E4300", Offset = "0x15E4300", VA = "0x15E4300", Slot = "5")]
	public override void PrepareForPlayerTeleport()
	{
	}

	[Token(Token = "0x60007DF")]
	[Address(RVA = "0x15E4364", Offset = "0x15E4364", VA = "0x15E4364", Slot = "6")]
	public override void OnPlayerTeleported()
	{
	}

	[Token(Token = "0x60007E0")]
	[Address(RVA = "0x15E4398", Offset = "0x15E4398", VA = "0x15E4398")]
	public void PauseAudio()
	{
	}

	[Token(Token = "0x60007E1")]
	[Address(RVA = "0x15E4404", Offset = "0x15E4404", VA = "0x15E4404")]
	public void ResumeAudio()
	{
	}

	[Token(Token = "0x60007E2")]
	[Address(RVA = "0x15E4470", Offset = "0x15E4470", VA = "0x15E4470")]
	public void Skip()
	{
	}

	[Token(Token = "0x60007E3")]
	[Address(RVA = "0x15E4660", Offset = "0x15E4660", VA = "0x15E4660")]
	public IntroVR()
	{
	}

	[Token(Token = "0x60007E4")]
	[Address(RVA = "0x15E4664", Offset = "0x15E4664", VA = "0x15E4664")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDD24", Offset = "0xAEDD24")]
	private void <LoadPrerequisites>b__14_0()
	{
	}
}
[Token(Token = "0x2000150")]
public class LoaderSpinner : MonoBehaviour
{
	[Token(Token = "0x40007C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float Speed;

	[Token(Token = "0x60007F1")]
	[Address(RVA = "0x141CC88", Offset = "0x141CC88", VA = "0x141CC88")]
	private void Update()
	{
	}

	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x141CCD0", Offset = "0x141CCD0", VA = "0x141CCD0")]
	public LoaderSpinner()
	{
	}
}
[Token(Token = "0x2000151")]
public class LocationsMenuDetailsVR : LocationsMenuDetailsBase
{
	[Token(Token = "0x2000152")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4964", Offset = "0xAE4964")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x40007E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LocationsMenuDetailsVR <>4__this;

		[Token(Token = "0x40007E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public LocationInfo locationInfo;

		[Token(Token = "0x40007E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenCallback <>9__1;

		[Token(Token = "0x40007E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TweenCallback <>9__2;

		[Token(Token = "0x40007E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public TweenCallback <>9__3;

		[Token(Token = "0x40007E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TweenCallback <>9__4;

		[Token(Token = "0x6000808")]
		[Address(RVA = "0xE46F90", Offset = "0xE46F90", VA = "0xE46F90")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6000809")]
		[Address(RVA = "0xE46F98", Offset = "0xE46F98", VA = "0xE46F98")]
		internal void <OnLocationInfoLoadSuccess>b__0()
		{
		}

		[Token(Token = "0x600080A")]
		[Address(RVA = "0xE47574", Offset = "0xE47574", VA = "0xE47574")]
		internal void <OnLocationInfoLoadSuccess>b__1()
		{
		}

		[Token(Token = "0x600080B")]
		[Address(RVA = "0xE475AC", Offset = "0xE475AC", VA = "0xE475AC")]
		internal void <OnLocationInfoLoadSuccess>b__2()
		{
		}

		[Token(Token = "0x600080C")]
		[Address(RVA = "0xE475D8", Offset = "0xE475D8", VA = "0xE475D8")]
		internal void <OnLocationInfoLoadSuccess>b__3()
		{
		}

		[Token(Token = "0x600080D")]
		[Address(RVA = "0xE47610", Offset = "0xE47610", VA = "0xE47610")]
		internal void <OnLocationInfoLoadSuccess>b__4()
		{
		}
	}

	[Token(Token = "0x2000153")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4974", Offset = "0xAE4974")]
	private sealed class <>c__DisplayClass45_0
	{
		[Token(Token = "0x40007E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject element;

		[Token(Token = "0x40007E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public float offset;

		[Token(Token = "0x40007E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public float timeMultiplier;

		[Token(Token = "0x600080E")]
		[Address(RVA = "0xE47648", Offset = "0xE47648", VA = "0xE47648")]
		public <>c__DisplayClass45_0()
		{
		}

		[Token(Token = "0x600080F")]
		[Address(RVA = "0xE47650", Offset = "0xE47650", VA = "0xE47650")]
		internal void <AnimateElement>b__0()
		{
		}
	}

	[Token(Token = "0x40007C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public GameObject YouAreHere;

	[Token(Token = "0x40007C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MeshRenderer Panoramic;

	[Token(Token = "0x40007C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public MeshRenderer Polaroid1;

	[Token(Token = "0x40007C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public MeshRenderer Polaroid2;

	[Token(Token = "0x40007C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public MeshRenderer Polaroid3;

	[Token(Token = "0x40007C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Transform Compass;

	[Token(Token = "0x40007CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public MeshRenderer Map;

	[Token(Token = "0x40007CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public TextMeshPro Title;

	[Token(Token = "0x40007CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public TextMeshPro Description;

	[Token(Token = "0x40007CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro DetailsText;

	[Token(Token = "0x40007CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshPro LocationInfoText;

	[Token(Token = "0x40007CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public TextMeshPro ActionButtonLabel;

	[Token(Token = "0x40007D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Rectangle ActionButtonHighlight;

	[Token(Token = "0x40007D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public GameObject VertigoWarning;

	[Token(Token = "0x40007D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	public TextMeshPro NotEnoughDiskSpace;

	[Token(Token = "0x40007D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	public TextMeshPro LocationSize1;

	[Token(Token = "0x40007D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public TextMeshPro LocationSize2;

	[Token(Token = "0x40007D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public TextMeshPro POIsFoundLabel;

	[Token(Token = "0x40007D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public TextMeshPro SpotsFoundLabel;

	[Token(Token = "0x40007D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public Transform Panel;

	[Token(Token = "0x40007D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextMeshPro LocationInfoNoInternet;

	[Token(Token = "0x40007D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public TextMeshPro DownloadNoInternet;

	[Token(Token = "0x40007DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 DefaultPanelPosition;

	[Token(Token = "0x40007DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 DefaultActionButtonPosition;

	[Token(Token = "0x40007DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 DefaultVertigoWarningScale;

	[Token(Token = "0x40007DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private Vector3 DefaultNotEnoughDiskSpaceScale;

	[Token(Token = "0x40007DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private Vector3 DefaultYouAreHerePosition;

	[Token(Token = "0x40007DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Sequence AnimationSequence;

	[Token(Token = "0x40007E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private bool WaitingForClearConfirmation;

	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x1426208", Offset = "0x1426208", VA = "0x1426208", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60007F4")]
	[Address(RVA = "0x14264A8", Offset = "0x14264A8", VA = "0x14264A8", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x60007F5")]
	[Address(RVA = "0x14265A0", Offset = "0x14265A0", VA = "0x14265A0", Slot = "6")]
	public override void LoadLocationInfo(string locationId)
	{
	}

	[Token(Token = "0x60007F6")]
	[Address(RVA = "0x1426664", Offset = "0x1426664", VA = "0x1426664", Slot = "9")]
	public override void ShowLocationDownloadError()
	{
	}

	[Token(Token = "0x60007F7")]
	[Address(RVA = "0x14267B4", Offset = "0x14267B4", VA = "0x14267B4", Slot = "10")]
	public override void ResetState()
	{
	}

	[Token(Token = "0x60007F8")]
	[Address(RVA = "0x142681C", Offset = "0x142681C", VA = "0x142681C", Slot = "11")]
	public override void PrepareForLocationLoad()
	{
	}

	[Token(Token = "0x60007F9")]
	[Address(RVA = "0x1426844", Offset = "0x1426844", VA = "0x1426844", Slot = "7")]
	protected override void OnLocationInfoLoadSuccess(LocationInfo locationInfo)
	{
	}

	[Token(Token = "0x60007FA")]
	[Address(RVA = "0x14272F4", Offset = "0x14272F4", VA = "0x14272F4")]
	private void UpdateTempAndWind()
	{
	}

	[Token(Token = "0x60007FB")]
	[Address(RVA = "0x1427844", Offset = "0x1427844", VA = "0x1427844", Slot = "8")]
	protected override void OnLocationInfoLoadFailed(string locationId)
	{
	}

	[Token(Token = "0x60007FC")]
	[Address(RVA = "0x14279A4", Offset = "0x14279A4", VA = "0x14279A4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x142822C", Offset = "0x142822C", VA = "0x142822C", Slot = "13")]
	protected override void OnClearButtonSelected(ButtonBase btn)
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x1428494", Offset = "0x1428494", VA = "0x1428494")]
	private void OnUsingImperialChanged()
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x1428498", Offset = "0x1428498", VA = "0x1428498")]
	private void OnPolaroid1Touched(Collider c)
	{
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0x1428598", Offset = "0x1428598", VA = "0x1428598")]
	private void OnPolaroid2Touched(Collider c)
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0x1428698", Offset = "0x1428698", VA = "0x1428698")]
	private void OnPolaroid3Touched(Collider c)
	{
	}

	[Token(Token = "0x6000802")]
	[Address(RVA = "0x1428798", Offset = "0x1428798", VA = "0x1428798")]
	private void OnCompassTouched(Collider c)
	{
	}

	[Token(Token = "0x6000803")]
	[Address(RVA = "0x142764C", Offset = "0x142764C", VA = "0x142764C")]
	private static void AnimateElement(GameObject element, float direction = 0f, float rotationMin = 6f, float rotationMax = 10f, float timeMultiplier = 1f)
	{
	}

	[Token(Token = "0x6000804")]
	[Address(RVA = "0x142889C", Offset = "0x142889C", VA = "0x142889C")]
	public LocationsMenuDetailsVR()
	{
	}

	[Token(Token = "0x6000805")]
	[Address(RVA = "0x14288A0", Offset = "0x14288A0", VA = "0x14288A0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDDD4", Offset = "0xAEDDD4")]
	private void <ShowLocationDownloadError>b__32_0()
	{
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0x14288D0", Offset = "0x14288D0", VA = "0x14288D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDDE4", Offset = "0xAEDDE4")]
	private void <OnLocationInfoLoadFailed>b__37_0()
	{
	}

	[Token(Token = "0x6000807")]
	[Address(RVA = "0x1428900", Offset = "0x1428900", VA = "0x1428900")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDDF4", Offset = "0xAEDDF4")]
	private void <OnClearButtonSelected>b__39_0()
	{
	}
}
[Token(Token = "0x2000154")]
public class LocationsMenuItemVR : PressButton
{
	[Token(Token = "0x2000155")]
	public enum VisualModes
	{
		[Token(Token = "0x400080E")]
		DEFAULT,
		[Token(Token = "0x400080F")]
		SELECTED,
		[Token(Token = "0x4000810")]
		DARKEN
	}

	[Token(Token = "0x40007EA")]
	public const float ITEM_WIDTH = 0.205f;

	[Token(Token = "0x40007EB")]
	public const float ITEM_GAP = 0.1f;

	[Token(Token = "0x40007EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static float OpacityMultiplier;

	[Token(Token = "0x40007ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA82C", Offset = "0xAEA82C")]
	public GameObject Container;

	[Token(Token = "0x40007EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	public Renderer ImageRenderer;

	[Token(Token = "0x40007EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	public Renderer EnvelopeRenderer;

	[Token(Token = "0x40007F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	public TextMeshPro ComingSoonText;

	[Token(Token = "0x40007F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	public TextMeshPro CountryText;

	[Token(Token = "0x40007F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	public TextMeshPro TitleText;

	[Token(Token = "0x40007F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public TextMeshPro InfoText;

	[Token(Token = "0x40007F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	public TextMeshPro StateText;

	[Token(Token = "0x40007F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	public MeshRenderer Badge;

	[Token(Token = "0x40007F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public TextMeshPro BadgeText;

	[Token(Token = "0x40007F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public Texture2D PublicBaseTex;

	[Token(Token = "0x40007F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public Texture2D PrivateBaseTex;

	[Token(Token = "0x40007F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public Texture2D DefaultProfilePicTex;

	[Token(Token = "0x40007FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public float DisableDistance;

	[Token(Token = "0x40007FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x154")]
	public float FadeDistance;

	[Token(Token = "0x40007FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	internal string LocationId;

	[Token(Token = "0x40007FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	internal VisualModes VisualMode;

	[Token(Token = "0x40007FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
	internal bool Available;

	[Token(Token = "0x40007FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private LocationInfo.BadgeEnum BadgeType;

	[Token(Token = "0x4000800")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private Material ImageRendererMaterial;

	[Token(Token = "0x4000801")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private LocationInfo LocationInfo;

	[Token(Token = "0x4000802")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private LocationInfoMenuListItem LocationInfoMenuListItem;

	[Token(Token = "0x4000803")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private float Opacity;

	[Token(Token = "0x4000804")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private LocationsMenuVR Menu;

	[Token(Token = "0x4000805")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
	private bool Visible;

	[Token(Token = "0x4000806")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19C")]
	private Color DefaultTitleColor;

	[Token(Token = "0x4000807")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
	private bool PostcardImageLoading;

	[Token(Token = "0x4000808")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AD")]
	private bool PostcardImageLoaded;

	[Token(Token = "0x4000809")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1AE")]
	private bool IsAndMoreType;

	[Token(Token = "0x400080A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Shader MenuItemOpaqueShader;

	[Token(Token = "0x400080B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Shader MenuItemTransparentShader;

	[Token(Token = "0x400080C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
	private Color _ItemColor;

	[Token(Token = "0x1700013C")]
	private Color ItemColor
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x142A500", Offset = "0x142A500", VA = "0x142A500")]
		get
		{
			return default(Color);
		}
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x1429F80", Offset = "0x1429F80", VA = "0x1429F80")]
		set
		{
		}
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x1428930", Offset = "0x1428930", VA = "0x1428930", Slot = "9")]
	public override void Awake()
	{
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x1428AE0", Offset = "0x1428AE0", VA = "0x1428AE0")]
	public void Init(LocationsMenuVR menu, LocationInfoMenuListItem locationInfoMenuListItem)
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x1428E54", Offset = "0x1428E54", VA = "0x1428E54")]
	private void UpdateTexts()
	{
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x1428D28", Offset = "0x1428D28", VA = "0x1428D28")]
	private void LoadPostcardImage()
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x14290BC", Offset = "0x14290BC", VA = "0x14290BC")]
	private void OnPostcardLoadSuccess(string locationId, Texture texture)
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x14290E8", Offset = "0x14290E8", VA = "0x14290E8")]
	private void OnPostcardLoadFailed(string locationId)
	{
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x14290F0", Offset = "0x14290F0", VA = "0x14290F0", Slot = "10")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x142913C", Offset = "0x142913C", VA = "0x142913C", Slot = "11")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x1429164", Offset = "0x1429164", VA = "0x1429164", Slot = "12")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x1429064", Offset = "0x1429064", VA = "0x1429064")]
	public void ForceTransparent()
	{
	}

	[Token(Token = "0x600081A")]
	[Address(RVA = "0x142A418", Offset = "0x142A418", VA = "0x142A418", Slot = "7")]
	public override void Deselect(bool skipAnimation = false)
	{
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0x1429C8C", Offset = "0x1429C8C", VA = "0x1429C8C")]
	private void UpdatePositionAndColor()
	{
	}

	[Token(Token = "0x600081E")]
	[Address(RVA = "0x142A428", Offset = "0x142A428", VA = "0x142A428")]
	private void SetShaderByOpacity(float a)
	{
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0x142A514", Offset = "0x142A514", VA = "0x142A514")]
	public LocationsMenuItemVR()
	{
	}
}
[Token(Token = "0x2000156")]
public class LocationsMenuScrollerVR : MonoBehaviour
{
	[Token(Token = "0x4000811")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color GlowColor;

	[Token(Token = "0x4000812")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform ItemsContainer;

	[Token(Token = "0x4000813")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Transform Indicator;

	[Token(Token = "0x4000814")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform IndicatorLine;

	[Token(Token = "0x4000815")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform Lines;

	[Token(Token = "0x4000816")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Transform GlowPivotCenter;

	[Token(Token = "0x4000817")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Transform GlowPivot;

	[Token(Token = "0x4000818")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro SwipeText;

	[Token(Token = "0x4000819")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Transform LeftHand;

	[Token(Token = "0x400081A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform RightHand;

	[Token(Token = "0x400081B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public float MaxVelocityY;

	[Token(Token = "0x400081C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	internal readonly UnityEvent OnScrollStart;

	[Token(Token = "0x400081D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	internal readonly UnityEvent ScrollEnd;

	[Token(Token = "0x400081E")]
	private const float ScrollSpeed = 3.8f;

	[Token(Token = "0x400081F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool HandScrollAllowed;

	[Token(Token = "0x4000820")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x89")]
	private bool ScrollingToItem;

	[Token(Token = "0x4000821")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8A")]
	private bool InteractingWithHand;

	[Token(Token = "0x4000822")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private BrinkHand InteractingHand;

	[Token(Token = "0x4000823")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private float AutomaticTargetPosition;

	[Token(Token = "0x4000824")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float AutomaticPositioningSpeed;

	[Token(Token = "0x4000825")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float InteractionStartTime;

	[Token(Token = "0x4000826")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Material LinesMaterial;

	[Token(Token = "0x4000827")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Material GlowMaterial;

	[Token(Token = "0x4000828")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Material IndicatorArrowMaterial;

	[Token(Token = "0x4000829")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Material IndicatorLineMaterial;

	[Token(Token = "0x400082A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Color LinesColor;

	[Token(Token = "0x400082B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Color LinesColorOff;

	[Token(Token = "0x400082C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Color GlowColorOff;

	[Token(Token = "0x400082D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private Color IndicatorArrowColor;

	[Token(Token = "0x400082E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Color IndicatorArrowColorOff;

	[Token(Token = "0x400082F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Color IndicatorLineColor;

	[Token(Token = "0x4000830")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Color IndicatorLineColorOff;

	[Token(Token = "0x4000831")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private bool Scrolling;

	[Token(Token = "0x4000832")]
	private const float LimitLeft = 0f;

	[Token(Token = "0x4000833")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x13C")]
	private float LimitRight;

	[Token(Token = "0x4000834")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private float LastCollisionStayTime;

	[Token(Token = "0x1700013D")]
	private Vector3 LocalHandVelocity
	{
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x142AC10", Offset = "0x142AC10", VA = "0x142AC10")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x142A5B4", Offset = "0x142A5B4", VA = "0x142A5B4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0x142A7FC", Offset = "0x142A7FC", VA = "0x142A7FC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x142A8CC", Offset = "0x142A8CC", VA = "0x142A8CC")]
	private void UpdateTexts()
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0x142A9D8", Offset = "0x142A9D8", VA = "0x142A9D8")]
	public void Init(List<LocationsMenuItemVR> menuItems)
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0x142AA48", Offset = "0x142AA48", VA = "0x142AA48")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0x142AAFC", Offset = "0x142AAFC", VA = "0x142AAFC")]
	public void OpenAnimationToItem(LocationsMenuItemVR item)
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x142ABB4", Offset = "0x142ABB4", VA = "0x142ABB4")]
	public void ScrollToItem(LocationsMenuItemVR item)
	{
	}

	[Token(Token = "0x6000829")]
	[Address(RVA = "0x142ACC8", Offset = "0x142ACC8", VA = "0x142ACC8")]
	private void OnInteractionStart()
	{
	}

	[Token(Token = "0x600082A")]
	[Address(RVA = "0x142AD04", Offset = "0x142AD04", VA = "0x142AD04")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600082B")]
	[Address(RVA = "0x142AE08", Offset = "0x142AE08", VA = "0x142AE08")]
	private void OnCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x600082C")]
	[Address(RVA = "0x142AF20", Offset = "0x142AF20", VA = "0x142AF20")]
	private void OnScrollingStart(bool swiping = true)
	{
	}

	[Token(Token = "0x600082D")]
	[Address(RVA = "0x142AA50", Offset = "0x142AA50", VA = "0x142AA50")]
	private void StopScroll()
	{
	}

	[Token(Token = "0x600082E")]
	[Address(RVA = "0x142B054", Offset = "0x142B054", VA = "0x142B054")]
	private void Update()
	{
	}

	[Token(Token = "0x600082F")]
	[Address(RVA = "0x142B958", Offset = "0x142B958", VA = "0x142B958")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0x142BA08", Offset = "0x142BA08", VA = "0x142BA08")]
	public LocationsMenuItemVR GetCenteredItem()
	{
		return null;
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0x142BB58", Offset = "0x142BB58", VA = "0x142BB58")]
	public LocationsMenuScrollerVR()
	{
	}
}
[Token(Token = "0x2000157")]
public class LocationsMenuVR : LocationsMenuBase
{
	[Serializable]
	[Token(Token = "0x2000158")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4984", Offset = "0xAE4984")]
	private sealed class <>c
	{
		[Token(Token = "0x400083F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x4000840")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<LocationsMenuItemVR, bool> <>9__18_0;

		[Token(Token = "0x4000841")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static DOGetter<float> <>9__19_0;

		[Token(Token = "0x4000842")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static DOSetter<float> <>9__19_1;

		[Token(Token = "0x6000844")]
		[Address(RVA = "0xE47740", Offset = "0xE47740", VA = "0xE47740")]
		public <>c()
		{
		}

		[Token(Token = "0x6000845")]
		[Address(RVA = "0xE47748", Offset = "0xE47748", VA = "0xE47748")]
		internal bool <OpenAnimation>b__18_0(LocationsMenuItemVR item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000846")]
		[Address(RVA = "0xE477C4", Offset = "0xE477C4", VA = "0xE477C4")]
		internal float <AutoScrollToItemOnNextFrame>b__19_0()
		{
			return default(float);
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0xE47828", Offset = "0xE47828", VA = "0xE47828")]
		internal void <AutoScrollToItemOnNextFrame>b__19_1(float value)
		{
		}
	}

	[Token(Token = "0x2000159")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4994", Offset = "0xAE4994")]
	private sealed class <AutoScrollToItemOnNextFrame>d__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000843")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000844")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000845")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LocationsMenuVR <>4__this;

		[Token(Token = "0x4000846")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public LocationsMenuItemVR item;

		[Token(Token = "0x1700013E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0xE47C10", Offset = "0xE47C10", VA = "0xE47C10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700013F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x600084D")]
			[Address(RVA = "0xE47C58", Offset = "0xE47C58", VA = "0xE47C58", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0xE47898", Offset = "0xE47898", VA = "0xE47898")]
		[DebuggerHidden]
		public <AutoScrollToItemOnNextFrame>d__19(int <>1__state)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0xE478C4", Offset = "0xE478C4", VA = "0xE478C4", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0xE478C8", Offset = "0xE478C8", VA = "0xE478C8", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0xE47C18", Offset = "0xE47C18", VA = "0xE47C18", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000835")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject MenuItemPrefab;

	[Token(Token = "0x4000836")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform Container;

	[Token(Token = "0x4000837")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Vector3 ItemsRotationRatio;

	[Token(Token = "0x4000838")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public TextMeshPro SwipeText;

	[Token(Token = "0x4000839")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly List<LocationsMenuItemVR> MenuItems;

	[Token(Token = "0x400083A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private LocationsMenuScrollerVR Scroller;

	[Token(Token = "0x400083B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private Vector3 OpeningHeadPosition;

	[Token(Token = "0x400083C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Tween OpacityMultiplierTween;

	[Token(Token = "0x400083D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float LastComingSonnPlayTime;

	[Token(Token = "0x400083E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private LocationsMenuItemVR SelectedItem;

	[Token(Token = "0x6000832")]
	[Address(RVA = "0xFF3AC0", Offset = "0xFF3AC0", VA = "0xFF3AC0", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0xFF3D54", Offset = "0xFF3D54", VA = "0xFF3D54", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0xFF3E64", Offset = "0xFF3E64", VA = "0xFF3E64", Slot = "6")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0xFF3E94", Offset = "0xFF3E94", VA = "0xFF3E94", Slot = "10")]
	public override void Init(List<LocationInfoMenuListItem> list)
	{
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0xFF4064", Offset = "0xFF4064", VA = "0xFF4064")]
	public void ForceSelectCenteredItem()
	{
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0xFF44D8", Offset = "0xFF44D8", VA = "0xFF44D8", Slot = "11")]
	protected override void AddItems(List<LocationInfoMenuListItem> locationInfoMenuList)
	{
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0xFF481C", Offset = "0xFF481C", VA = "0xFF481C", Slot = "8")]
	protected override void Open()
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0xFF4884", Offset = "0xFF4884", VA = "0xFF4884", Slot = "12")]
	protected override void ResetItemStates()
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0xFF3B74", Offset = "0xFF3B74", VA = "0xFF3B74")]
	private void OpenAnimation()
	{
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0xFF49C4", Offset = "0xFF49C4", VA = "0xFF49C4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDE04", Offset = "0xAEDE04")]
	private IEnumerator AutoScrollToItemOnNextFrame(LocationsMenuItemVR item)
	{
		return null;
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0xFF4164", Offset = "0xFF4164", VA = "0xFF4164")]
	private void OnItemSelected(ButtonBase selected)
	{
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0xFF4BD0", Offset = "0xFF4BD0", VA = "0xFF4BD0")]
	private void OnScrollStart()
	{
	}

	[Token(Token = "0x600083E")]
	[Address(RVA = "0xFF4CFC", Offset = "0xFF4CFC", VA = "0xFF4CFC")]
	private void DeselectSelected()
	{
	}

	[Token(Token = "0x600083F")]
	[Address(RVA = "0xFF4D90", Offset = "0xFF4D90", VA = "0xFF4D90")]
	private void OnFirstScrollStart()
	{
	}

	[Token(Token = "0x6000840")]
	[Address(RVA = "0xFF4EB0", Offset = "0xFF4EB0", VA = "0xFF4EB0", Slot = "13")]
	protected override void OnClearSelected()
	{
	}

	[Token(Token = "0x6000841")]
	[Address(RVA = "0xFF4FF4", Offset = "0xFF4FF4", VA = "0xFF4FF4")]
	public LocationsMenuVR()
	{
	}

	[Token(Token = "0x6000842")]
	[Address(RVA = "0xFF507C", Offset = "0xFF507C", VA = "0xFF507C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDE64", Offset = "0xAEDE64")]
	private void <OnFirstScrollStart>b__23_0()
	{
	}
}
[Token(Token = "0x200015A")]
public class Narrator : MonoBehaviour
{
	[Token(Token = "0x200015B")]
	private enum SentenceTypeEnum
	{
		[Token(Token = "0x400085B")]
		NONE,
		[Token(Token = "0x400085C")]
		NARRATION,
		[Token(Token = "0x400085D")]
		TUTORIAL
	}

	[Token(Token = "0x200015C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49A4", Offset = "0xAE49A4")]
	private sealed class <Start>d__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400085E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400085F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000860")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Narrator <>4__this;

		[Token(Token = "0x17000143")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0xE4BC20", Offset = "0xE4BC20", VA = "0xE4BC20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000144")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000870")]
			[Address(RVA = "0xE4BC68", Offset = "0xE4BC68", VA = "0xE4BC68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600086B")]
		[Address(RVA = "0xE4BA90", Offset = "0xE4BA90", VA = "0xE4BA90")]
		[DebuggerHidden]
		public <Start>d__28(int <>1__state)
		{
		}

		[Token(Token = "0x600086C")]
		[Address(RVA = "0xE4BABC", Offset = "0xE4BABC", VA = "0xE4BABC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x600086D")]
		[Address(RVA = "0xE4BAC0", Offset = "0xE4BAC0", VA = "0xE4BAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600086F")]
		[Address(RVA = "0xE4BC28", Offset = "0xE4BC28", VA = "0xE4BC28", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200015D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49B4", Offset = "0xAE49B4")]
	private sealed class <>c__DisplayClass30_0
	{
		[Token(Token = "0x200015E")]
		private sealed class <<PlayMisc>g__PlayCo|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000864")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000865")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x4000866")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass30_0 <>4__this;

			[Token(Token = "0x17000145")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000876")]
				[Address(RVA = "0x167BD2C", Offset = "0x167BD2C", VA = "0x167BD2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000146")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000878")]
				[Address(RVA = "0x167BD74", Offset = "0x167BD74", VA = "0x167BD74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000873")]
			[Address(RVA = "0x167BC1C", Offset = "0x167BC1C", VA = "0x167BC1C")]
			[DebuggerHidden]
			public <<PlayMisc>g__PlayCo|0>d(int <>1__state)
			{
			}

			[Token(Token = "0x6000874")]
			[Address(RVA = "0x167BC48", Offset = "0x167BC48", VA = "0x167BC48", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000875")]
			[Address(RVA = "0x167BC4C", Offset = "0x167BC4C", VA = "0x167BC4C", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000877")]
			[Address(RVA = "0x167BD34", Offset = "0x167BD34", VA = "0x167BD34", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000861")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float delay;

		[Token(Token = "0x4000862")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string key;

		[Token(Token = "0x4000863")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool showSubtitles;

		[Token(Token = "0x6000871")]
		[Address(RVA = "0xE4B934", Offset = "0xE4B934", VA = "0xE4B934")]
		public <>c__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6000872")]
		[Address(RVA = "0xE4B93C", Offset = "0xE4B93C", VA = "0xE4B93C")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE054", Offset = "0xAEE054")]
		internal IEnumerator <PlayMisc>g__PlayCo|0()
		{
			return null;
		}
	}

	[Token(Token = "0x200015F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49C4", Offset = "0xAE49C4")]
	private sealed class <>c__DisplayClass36_0
	{
		[Token(Token = "0x2000160")]
		private sealed class <<PlayNarration>g__PlayCoroutine|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000869")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass36_0 <>4__this;

			[Token(Token = "0x17000147")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x600087E")]
				[Address(RVA = "0x167C054", Offset = "0x167C054", VA = "0x167C054", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x17000148")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000880")]
				[Address(RVA = "0x167C09C", Offset = "0x167C09C", VA = "0x167C09C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600087B")]
			[Address(RVA = "0x167BD7C", Offset = "0x167BD7C", VA = "0x167BD7C")]
			[DebuggerHidden]
			public <<PlayNarration>g__PlayCoroutine|0>d(int <>1__state)
			{
			}

			[Token(Token = "0x600087C")]
			[Address(RVA = "0x167BDA8", Offset = "0x167BDA8", VA = "0x167BDA8", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x600087D")]
			[Address(RVA = "0x167BDAC", Offset = "0x167BDAC", VA = "0x167BDAC", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x600087F")]
			[Address(RVA = "0x167C05C", Offset = "0x167C05C", VA = "0x167C05C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x4000867")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public float delay;

		[Token(Token = "0x4000868")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Narrator <>4__this;

		[Token(Token = "0x6000879")]
		[Address(RVA = "0xE4B9A8", Offset = "0xE4B9A8", VA = "0xE4B9A8")]
		public <>c__DisplayClass36_0()
		{
		}

		[Token(Token = "0x600087A")]
		[Address(RVA = "0xE4B9B0", Offset = "0xE4B9B0", VA = "0xE4B9B0")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE104", Offset = "0xAEE104")]
		internal IEnumerator <PlayNarration>g__PlayCoroutine|0()
		{
			return null;
		}
	}

	[Token(Token = "0x2000161")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49D4", Offset = "0xAE49D4")]
	private sealed class <>c__DisplayClass46_0
	{
		[Token(Token = "0x2000162")]
		private sealed class <<LoadLocalizedBanks>g__LoadDefaultCo|0>d : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400086D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x400086E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			[Token(Token = "0x400086F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public <>c__DisplayClass46_0 <>4__this;

			[Token(Token = "0x4000870")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private string <miscKey>5__2;

			[Token(Token = "0x4000871")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private string <narrationKey>5__3;

			[Token(Token = "0x4000872")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private AsyncOperationHandle<TextAsset> <op1>5__4;

			[Token(Token = "0x4000873")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private AsyncOperationHandle<TextAsset> <op2>5__5;

			[Token(Token = "0x4000874")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			private AsyncOperationHandle<TextAsset> <op3>5__6;

			[Token(Token = "0x17000149")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[Token(Token = "0x6000886")]
				[Address(RVA = "0x167C714", Offset = "0x167C714", VA = "0x167C714", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700014A")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000888")]
				[Address(RVA = "0x167C75C", Offset = "0x167C75C", VA = "0x167C75C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000883")]
			[Address(RVA = "0x167C0A4", Offset = "0x167C0A4", VA = "0x167C0A4")]
			[DebuggerHidden]
			public <<LoadLocalizedBanks>g__LoadDefaultCo|0>d(int <>1__state)
			{
			}

			[Token(Token = "0x6000884")]
			[Address(RVA = "0x167C0D0", Offset = "0x167C0D0", VA = "0x167C0D0", Slot = "5")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000885")]
			[Address(RVA = "0x167C0D4", Offset = "0x167C0D4", VA = "0x167C0D4", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000887")]
			[Address(RVA = "0x167C71C", Offset = "0x167C71C", VA = "0x167C71C", Slot = "8")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}
		}

		[Token(Token = "0x400086C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool restartIntro;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0xE4BA1C", Offset = "0xE4BA1C", VA = "0xE4BA1C")]
		public <>c__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0xE4BA24", Offset = "0xE4BA24", VA = "0xE4BA24")]
		[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE1B4", Offset = "0xAEE1B4")]
		internal IEnumerator <LoadLocalizedBanks>g__LoadDefaultCo|0()
		{
			return null;
		}
	}

	[Token(Token = "0x4000847")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Narrator Instance;

	[Token(Token = "0x4000848")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private UnityEvent _NarrationSequenceEndEvent;

	[Token(Token = "0x4000849")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static SentenceTypeEnum CurrentSentenceType;

	[Token(Token = "0x400084A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TutorialManagerVR TutorialManager;

	[Token(Token = "0x400084B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal NarratorUI NarratorUI;

	[Token(Token = "0x400084C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private EVENT_CALLBACK NarrationEventCallback;

	[Token(Token = "0x400084D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private EVENT_CALLBACK NarrationPOIEventCallback;

	[Token(Token = "0x400084E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EventInstance VoiceInstance;

	[Token(Token = "0x400084F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private EventInstance MiscInstance;

	[Token(Token = "0x4000850")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Coroutine PlayNarrationCoroutine;

	[Token(Token = "0x4000851")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private AlignWithCameraPivot Align;

	[Token(Token = "0x4000852")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	private static bool WasTalking;

	[Token(Token = "0x4000853")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Vector3 DefaultNarratorUIPosition;

	[Token(Token = "0x4000854")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Quaternion DefaultNarratorUIRotation;

	[Token(Token = "0x4000855")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	private bool IsPaused;

	[Token(Token = "0x4000856")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7D")]
	private bool CheckActiveLanguageOnAppMenuClose;

	[Token(Token = "0x4000857")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD")]
	private static bool LoadingBanks;

	[Token(Token = "0x4000858")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static string LoadedBanksLocale;

	[Token(Token = "0x4000859")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA864", Offset = "0xAEA864")]
	private static bool <IsTalking>k__BackingField;

	[Token(Token = "0x17000140")]
	public UnityEvent NarrationSequenceEndEvent
	{
		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1005290", Offset = "0x1005290", VA = "0x1005290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000141")]
	public static bool IsTalking
	{
		[Token(Token = "0x6000850")]
		[Address(RVA = "0x100534C", Offset = "0x100534C", VA = "0x100534C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDED4", Offset = "0xAEDED4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600084F")]
		[Address(RVA = "0x10052F8", Offset = "0x10052F8", VA = "0x10052F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEDEC4", Offset = "0xAEDEC4")]
		private set
		{
		}
	}

	[Token(Token = "0x17000142")]
	public static bool IsTeaching
	{
		[Token(Token = "0x6000851")]
		[Address(RVA = "0xFF7D1C", Offset = "0xFF7D1C", VA = "0xFF7D1C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x1005398", Offset = "0x1005398", VA = "0x1005398")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x10055D0", Offset = "0x10055D0", VA = "0x10055D0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEDEE4", Offset = "0xAEDEE4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x100563C", Offset = "0x100563C", VA = "0x100563C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0xFF4A3C", Offset = "0xFF4A3C", VA = "0xFF4A3C")]
	public static void PlayMisc(string key, float delay = 0f, bool showSubtitles = true)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x1006614", Offset = "0x1006614", VA = "0x1006614")]
	public void StopMisc()
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x1006684", Offset = "0x1006684", VA = "0x1006684")]
	public void OnIntroEnded()
	{
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x10066A0", Offset = "0x10066A0", VA = "0x10066A0")]
	public void TeleportWithUser()
	{
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x1006784", Offset = "0x1006784", VA = "0x1006784")]
	public void OnAppFocusOut()
	{
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x10067F0", Offset = "0x10067F0", VA = "0x10067F0")]
	public void OnAppFocusIn(float delay = 0f)
	{
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x10068E8", Offset = "0x10068E8", VA = "0x10068E8")]
	public void PlayNarration(float delay = 0f)
	{
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1006A00", Offset = "0x1006A00", VA = "0x1006A00")]
	public void PauseNarration()
	{
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x1006AC0", Offset = "0x1006AC0", VA = "0x1006AC0")]
	public void ResumeNarration(float delay = 0f)
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x1006C60", Offset = "0x1006C60", VA = "0x1006C60")]
	public void StopTalking()
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x1006D34", Offset = "0x1006D34", VA = "0x1006D34")]
	public void StopTalkingAndReset()
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x1006FB4", Offset = "0x1006FB4", VA = "0x1006FB4")]
	public float PlayTutorial(string key)
	{
		return default(float);
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x1007094", Offset = "0x1007094", VA = "0x1007094")]
	private float PlayKey(string key, SentenceTypeEnum type)
	{
		return default(float);
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x100764C", Offset = "0x100764C", VA = "0x100764C")]
	private void OnAnySettingChange()
	{
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x1006DC8", Offset = "0x1006DC8", VA = "0x1006DC8")]
	private static void UnloadOtherNarrationBanks()
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x1007700", Offset = "0x1007700", VA = "0x1007700")]
	public static void UnloadAllBanks()
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x1005F84", Offset = "0x1005F84", VA = "0x1005F84")]
	public static void LoadLocalizedBanks(bool restartIntro = false)
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x100796C", Offset = "0x100796C", VA = "0x100796C")]
	private static void UnloadAllOtherBanks()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x1007B78", Offset = "0x1007B78", VA = "0x1007B78")]
	private void PlayMiscKey(string key, bool showSubtitles = true)
	{
	}

	[Token(Token = "0x6000868")]
	[Address(RVA = "0x1004B5C", Offset = "0x1004B5C", VA = "0x1004B5C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xAEDF44", Offset = "0xAEDF44")]
	private static RESULT NarratorCallback(EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr parameterPtr)
	{
		return default(RESULT);
	}

	[Token(Token = "0x6000869")]
	[Address(RVA = "0x1004F3C", Offset = "0x1004F3C", VA = "0x1004F3C")]
	[AttributeAttribute(Name = "MonoPInvokeCallbackAttribute", RVA = "0xAEDFA4", Offset = "0xAEDFA4")]
	private static RESULT NarratorMiscCallback(EVENT_CALLBACK_TYPE type, IntPtr instancePtr, IntPtr parameterPtr)
	{
		return default(RESULT);
	}

	[Token(Token = "0x600086A")]
	[Address(RVA = "0x1007E14", Offset = "0x1007E14", VA = "0x1007E14")]
	public Narrator()
	{
	}
}
[Token(Token = "0x2000163")]
public class NarratorSpectrum : MonoBehaviour
{
	[Token(Token = "0x4000875")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform LinesContainer;

	[Token(Token = "0x4000876")]
	internal const float Gap = 0.018f;

	[Token(Token = "0x4000877")]
	private const float Intensity = 0.5f;

	[Token(Token = "0x4000878")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private DSP dsp;

	[Token(Token = "0x4000879")]
	private const int WindowSize = 64;

	[Token(Token = "0x400087A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int numSampleInFirstBand;

	[Token(Token = "0x400087B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private float[] Samples;

	[Token(Token = "0x400087C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly List<float> freqRanges;

	[Token(Token = "0x400087D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static float[] freqBands;

	[Token(Token = "0x400087E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[HideInInspector]
	public Line[] Lines;

	[Token(Token = "0x6000889")]
	[Address(RVA = "0x1007E1C", Offset = "0x1007E1C", VA = "0x1007E1C")]
	public void Init()
	{
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x1007F48", Offset = "0x1007F48", VA = "0x1007F48")]
	private void SetNumberOfMeters()
	{
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x1008018", Offset = "0x1008018", VA = "0x1008018")]
	private void SpawnMeterObjects()
	{
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x1008304", Offset = "0x1008304", VA = "0x1008304")]
	private void Update()
	{
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x1008510", Offset = "0x1008510", VA = "0x1008510")]
	private void GetSpectrumData(DSP_PARAMETER_FFT fftData)
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x1008600", Offset = "0x1008600", VA = "0x1008600")]
	private void FrequencyBands()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x10088E8", Offset = "0x10088E8", VA = "0x10088E8")]
	public NarratorSpectrum()
	{
	}
}
[Token(Token = "0x2000164")]
public class NarratorUI : MonoBehaviour
{
	[Token(Token = "0x2000165")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49E4", Offset = "0xAE49E4")]
	private sealed class <>c__DisplayClass29_0
	{
		[Token(Token = "0x4000893")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NarratorUI <>4__this;

		[Token(Token = "0x4000894")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string text;

		[Token(Token = "0x60008A0")]
		[Address(RVA = "0xE4BC70", Offset = "0xE4BC70", VA = "0xE4BC70")]
		public <>c__DisplayClass29_0()
		{
		}

		[Token(Token = "0x60008A1")]
		[Address(RVA = "0xE4BC78", Offset = "0xE4BC78", VA = "0xE4BC78")]
		internal void <InitSubs>b__0()
		{
		}
	}

	[Token(Token = "0x400087F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Transform Icon;

	[Token(Token = "0x4000880")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public RectTransform SubtitlesViewport;

	[Token(Token = "0x4000881")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI SubtitlesText;

	[Token(Token = "0x4000882")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject SubtitlesBg;

	[Token(Token = "0x4000883")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public CanvasGroup CanvasGroup;

	[Token(Token = "0x4000884")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public GameObject SkipTutorialTip;

	[Token(Token = "0x4000885")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Image SkipTutorialProgressImage;

	[Token(Token = "0x4000886")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public NarratorSpectrum Spectrum;

	[Token(Token = "0x4000887")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA884", Offset = "0xAEA884")]
	private bool <Shown>k__BackingField;

	[Token(Token = "0x4000888")]
	private const float InitialPauseTime = 2.5f;

	[Token(Token = "0x4000889")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly List<GameObject> Renderers;

	[Token(Token = "0x400088A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float SubtitlesTimeStart;

	[Token(Token = "0x400088B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private float SubtitlesDuration;

	[Token(Token = "0x400088C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private float OnDisableTime;

	[Token(Token = "0x400088D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
	private bool Scrolling;

	[Token(Token = "0x400088E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Vector3 DefaultIconScale;

	[Token(Token = "0x400088F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private float ScrollingSpeed;

	[Token(Token = "0x4000890")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Camera MenuCamera;

	[Token(Token = "0x4000891")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private string CurrentSubtitlesKey;

	[Token(Token = "0x4000892")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private bool QuickFadeOut;

	[Token(Token = "0x1700014B")]
	public bool Shown
	{
		[Token(Token = "0x6000891")]
		[Address(RVA = "0x1008974", Offset = "0x1008974", VA = "0x1008974")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE274", Offset = "0xAEE274")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000890")]
		[Address(RVA = "0x1008968", Offset = "0x1008968", VA = "0x1008968")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE264", Offset = "0xAEE264")]
		private set
		{
		}
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x100897C", Offset = "0x100897C", VA = "0x100897C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x10089B4", Offset = "0x10089B4", VA = "0x10089B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x1008D60", Offset = "0x1008D60", VA = "0x1008D60")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x1008E08", Offset = "0x1008E08", VA = "0x1008E08")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000896")]
	[Address(RVA = "0x1008E50", Offset = "0x1008E50", VA = "0x1008E50")]
	private void Update()
	{
	}

	[Token(Token = "0x6000897")]
	[Address(RVA = "0x10060F8", Offset = "0x10060F8", VA = "0x10060F8")]
	public void Show(bool v)
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x10073F0", Offset = "0x10073F0", VA = "0x10073F0")]
	public void InitSubs(string key, float duration)
	{
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x1006450", Offset = "0x1006450", VA = "0x1006450")]
	public void RenderInOverlay(bool v = true)
	{
	}

	[Token(Token = "0x600089A")]
	[Address(RVA = "0x10090CC", Offset = "0x10090CC", VA = "0x10090CC")]
	public void ShowTutorialSkippingTip(bool v = true)
	{
	}

	[Token(Token = "0x600089B")]
	[Address(RVA = "0x10090EC", Offset = "0x10090EC", VA = "0x10090EC")]
	public void UpdateSkippingProgress(float v)
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0x1009108", Offset = "0x1009108", VA = "0x1009108")]
	private void OnLanguageChanged()
	{
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0x10091C0", Offset = "0x10091C0", VA = "0x10091C0")]
	public NarratorUI()
	{
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0x1009240", Offset = "0x1009240", VA = "0x1009240")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE284", Offset = "0xAEE284")]
	private void <Show>b__28_0()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x1009268", Offset = "0x1009268", VA = "0x1009268")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE294", Offset = "0xAEE294")]
	private void <Show>b__28_1()
	{
	}
}
[Token(Token = "0x2000166")]
public class NotificationVR : MonoBehaviour
{
	[Token(Token = "0x2000167")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE49F4", Offset = "0xAE49F4")]
	private sealed class <>c__DisplayClass23_0
	{
		[Token(Token = "0x40008A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x40008A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Func<Data, bool> <>9__0;

		[Token(Token = "0x60008C0")]
		[Address(RVA = "0x1670E78", Offset = "0x1670E78", VA = "0x1670E78")]
		public <>c__DisplayClass23_0()
		{
		}

		[Token(Token = "0x60008C1")]
		[Address(RVA = "0x1670E80", Offset = "0x1670E80", VA = "0x1670E80")]
		internal bool <CancelById>b__0(Data data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000168")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A04", Offset = "0xAE4A04")]
	private sealed class <Show>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NotificationVR <>4__this;

		[Token(Token = "0x1700014E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008C5")]
			[Address(RVA = "0x167132C", Offset = "0x167132C", VA = "0x167132C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700014F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008C7")]
			[Address(RVA = "0x1671374", Offset = "0x1671374", VA = "0x1671374", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C2")]
		[Address(RVA = "0x167110C", Offset = "0x167110C", VA = "0x167110C")]
		[DebuggerHidden]
		public <Show>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x60008C3")]
		[Address(RVA = "0x1671138", Offset = "0x1671138", VA = "0x1671138", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008C4")]
		[Address(RVA = "0x167113C", Offset = "0x167113C", VA = "0x167113C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008C6")]
		[Address(RVA = "0x1671334", Offset = "0x1671334", VA = "0x1671334", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000169")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A14", Offset = "0xAE4A14")]
	private sealed class <HideDelayed>d__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NotificationVR <>4__this;

		[Token(Token = "0x17000150")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008CB")]
			[Address(RVA = "0x16710BC", Offset = "0x16710BC", VA = "0x16710BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000151")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60008CD")]
			[Address(RVA = "0x1671104", Offset = "0x1671104", VA = "0x1671104", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008C8")]
		[Address(RVA = "0x1670ED0", Offset = "0x1670ED0", VA = "0x1670ED0")]
		[DebuggerHidden]
		public <HideDelayed>d__32(int <>1__state)
		{
		}

		[Token(Token = "0x60008C9")]
		[Address(RVA = "0x1670EFC", Offset = "0x1670EFC", VA = "0x1670EFC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008CA")]
		[Address(RVA = "0x1670F00", Offset = "0x1670F00", VA = "0x1670F00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008CC")]
		[Address(RVA = "0x16710C4", Offset = "0x16710C4", VA = "0x16710C4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x200016A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A24", Offset = "0xAE4A24")]
	private sealed class <>c__DisplayClass35_0
	{
		[Token(Token = "0x40008AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x60008CE")]
		[Address(RVA = "0x1670EA4", Offset = "0x1670EA4", VA = "0x1670EA4")]
		public <>c__DisplayClass35_0()
		{
		}

		[Token(Token = "0x60008CF")]
		[Address(RVA = "0x1670EAC", Offset = "0x1670EAC", VA = "0x1670EAC")]
		internal bool <InQueue>b__0(Data data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000895")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static readonly List<Data> Queue;

	[Token(Token = "0x4000896")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Data CurrentNotifData;

	[Token(Token = "0x4000897")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public UnityEvent OpenWithFadeOverlayEvent;

	[Token(Token = "0x4000898")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent ClosedWithFadeOverlayEvent;

	[Token(Token = "0x4000899")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Container;

	[Token(Token = "0x400089A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public TextMeshPro Label;

	[Token(Token = "0x400089B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Renderer Background;

	[Token(Token = "0x400089C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public LineRenderer Line;

	[Token(Token = "0x400089D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public ButtonBase Button;

	[Token(Token = "0x400089E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private AlignWithCameraPivot AlignWithCameraPivot;

	[Token(Token = "0x400089F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GradientAlphaKey[] DefaultAlphaKeys;

	[Token(Token = "0x40008A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float AllowedTime;

	[Token(Token = "0x40008A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private Vector3 DefaultBgScale;

	[Token(Token = "0x40008A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Vector3 DefaultButtonPosition;

	[Token(Token = "0x40008A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CollisionTriggerNotifier ButtonIntentNotifier;

	[Token(Token = "0x40008A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Coroutine ShowAndHideCo;

	[Token(Token = "0x40008A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool _Allowed;

	[Token(Token = "0x40008A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private float _LineAlpha;

	[Token(Token = "0x1700014C")]
	public bool Allowed
	{
		[Token(Token = "0x60008A2")]
		[Address(RVA = "0x107EE9C", Offset = "0x107EE9C", VA = "0x107EE9C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60008A3")]
		[Address(RVA = "0x107EEA4", Offset = "0x107EEA4", VA = "0x107EEA4")]
		set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	private float LineAlpha
	{
		[Token(Token = "0x60008B6")]
		[Address(RVA = "0x1080B48", Offset = "0x1080B48", VA = "0x1080B48")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60008B5")]
		[Address(RVA = "0x107F7D8", Offset = "0x107F7D8", VA = "0x107F7D8")]
		set
		{
		}
	}

	[Token(Token = "0x60008A4")]
	[Address(RVA = "0x107EEEC", Offset = "0x107EEEC", VA = "0x107EEEC")]
	public static void Add(string message, [Optional] Transform focus, bool requiresFadeOverlay = false, [Optional] string id, [Optional] Action buttonCallback, string buttonLabel = "Got it!")
	{
	}

	[Token(Token = "0x60008A5")]
	[Address(RVA = "0x107ED38", Offset = "0x107ED38", VA = "0x107ED38")]
	public static void Add(string message, float duration, [Optional] Transform focus, bool requiresFadeOverlay = false, [Optional] string id, [Optional] Action buttonCallback, [Optional] string buttonLabel)
	{
	}

	[Token(Token = "0x60008A6")]
	[Address(RVA = "0x107EF90", Offset = "0x107EF90", VA = "0x107EF90")]
	public static void CancelCurrent()
	{
	}

	[Token(Token = "0x60008A7")]
	[Address(RVA = "0x107F048", Offset = "0x107F048", VA = "0x107F048")]
	public static void CancelById(string id)
	{
	}

	[Token(Token = "0x60008A8")]
	[Address(RVA = "0x107F430", Offset = "0x107F430", VA = "0x107F430")]
	public static bool IsNotificationIgnored(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x60008A9")]
	[Address(RVA = "0x107F438", Offset = "0x107F438", VA = "0x107F438")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008AA")]
	[Address(RVA = "0x107F8A4", Offset = "0x107F8A4", VA = "0x107F8A4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0x107F918", Offset = "0x107F918", VA = "0x107F918")]
	private void Update()
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0x107FB18", Offset = "0x107FB18", VA = "0x107FB18")]
	private void UpdateLine()
	{
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0x10800B4", Offset = "0x10800B4", VA = "0x10800B4")]
	private void OnButtonIntentStart(Collider arg0)
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x10800C0", Offset = "0x10800C0", VA = "0x10800C0")]
	private void OnButtonIntentEnd(Collider arg0)
	{
	}

	[Token(Token = "0x60008AF")]
	[Address(RVA = "0x107FAAC", Offset = "0x107FAAC", VA = "0x107FAAC")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE2A4", Offset = "0xAEE2A4")]
	private IEnumerator Show()
	{
		return null;
	}

	[Token(Token = "0x60008B0")]
	[Address(RVA = "0x10800F4", Offset = "0x10800F4", VA = "0x10800F4")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE304", Offset = "0xAEE304")]
	private IEnumerator HideDelayed()
	{
		return null;
	}

	[Token(Token = "0x60008B1")]
	[Address(RVA = "0x1080160", Offset = "0x1080160", VA = "0x1080160")]
	private void ShowAnimation()
	{
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x107FD44", Offset = "0x107FD44", VA = "0x107FD44")]
	private void Hide()
	{
	}

	[Token(Token = "0x60008B3")]
	[Address(RVA = "0x1080998", Offset = "0x1080998", VA = "0x1080998")]
	public static bool InQueue(string id)
	{
		return default(bool);
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x1080AB4", Offset = "0x1080AB4", VA = "0x1080AB4")]
	private static void OnButtonSelect(ButtonBase btn)
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x1080B50", Offset = "0x1080B50", VA = "0x1080B50")]
	public NotificationVR()
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x1080C64", Offset = "0x1080C64", VA = "0x1080C64")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE364", Offset = "0xAEE364")]
	private void <ShowAnimation>b__33_0()
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x1080C84", Offset = "0x1080C84", VA = "0x1080C84")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE374", Offset = "0xAEE374")]
	private float <ShowAnimation>b__33_1()
	{
		return default(float);
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x1080C8C", Offset = "0x1080C8C", VA = "0x1080C8C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE384", Offset = "0xAEE384")]
	private void <ShowAnimation>b__33_2(float x)
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x1080C90", Offset = "0x1080C90", VA = "0x1080C90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE394", Offset = "0xAEE394")]
	private void <ShowAnimation>b__33_3()
	{
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x1080CC0", Offset = "0x1080CC0", VA = "0x1080CC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE3A4", Offset = "0xAEE3A4")]
	private float <Hide>b__34_0()
	{
		return default(float);
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x1080CC8", Offset = "0x1080CC8", VA = "0x1080CC8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE3B4", Offset = "0xAEE3B4")]
	private void <Hide>b__34_1(float x)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x1080CCC", Offset = "0x1080CCC", VA = "0x1080CCC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE3C4", Offset = "0xAEE3C4")]
	private void <Hide>b__34_2()
	{
	}
}
[Token(Token = "0x200016B")]
internal class Data
{
	[Token(Token = "0x40008B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public readonly string Id;

	[Token(Token = "0x40008B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public readonly string Message;

	[Token(Token = "0x40008B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly float Duration;

	[Token(Token = "0x40008B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public readonly Transform Focus;

	[Token(Token = "0x40008B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public readonly bool RequireFadeOverlay;

	[Token(Token = "0x40008B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public readonly Action ButtonCallback;

	[Token(Token = "0x40008B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public readonly string ButtonLabel;

	[Token(Token = "0x60008D0")]
	[Address(RVA = "0x15D59BC", Offset = "0x15D59BC", VA = "0x15D59BC")]
	public Data(string id, string message, float duration, Transform focus, bool requiresFadeOverlay, Action buttonCallback, string buttonLabel)
	{
	}
}
[Token(Token = "0x200016C")]
public class OutsideOfBoundsVR : MonoBehaviour
{
	[Token(Token = "0x40008B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public TextMeshPro Text;

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x1086130", Offset = "0x1086130", VA = "0x1086130")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x1086150", Offset = "0x1086150", VA = "0x1086150")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x108625C", Offset = "0x108625C", VA = "0x108625C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x10862E0", Offset = "0x10862E0", VA = "0x10862E0")]
	public OutsideOfBoundsVR()
	{
	}
}
[Token(Token = "0x200016D")]
public class Overlay : MonoBehaviour
{
	[Token(Token = "0x40008B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static Overlay ActiveOverlay;

	[Token(Token = "0x40008B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Transform VirtualGuideAnchor;

	[Token(Token = "0x40008BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal static readonly UnityEvent BeforeOpening;

	[Token(Token = "0x40008BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal static readonly UnityEvent Opening;

	[Token(Token = "0x40008BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal static readonly UnityEvent Closing;

	[Token(Token = "0x17000152")]
	public static bool Active
	{
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x10862E8", Offset = "0x10862E8", VA = "0x10862E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60008D6")]
	[Address(RVA = "0x1086388", Offset = "0x1086388", VA = "0x1086388", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x60008D7")]
	[Address(RVA = "0x108638C", Offset = "0x108638C", VA = "0x108638C", Slot = "5")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x1086488", Offset = "0x1086488", VA = "0x1086488", Slot = "6")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x10864EC", Offset = "0x10864EC", VA = "0x10864EC", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x10864F0", Offset = "0x10864F0", VA = "0x10864F0", Slot = "8")]
	protected virtual void Open()
	{
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x10866B0", Offset = "0x10866B0", VA = "0x10866B0", Slot = "9")]
	internal virtual void Close(bool dispatch = true)
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x1086784", Offset = "0x1086784", VA = "0x1086784")]
	public void Toggle()
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x10868C8", Offset = "0x10868C8", VA = "0x10868C8")]
	public Overlay()
	{
	}
}
[Token(Token = "0x200016E")]
public class POIPopupObjectHighlight : MonoBehaviour
{
	[Token(Token = "0x40008BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal bool StaysInPlace;

	[Token(Token = "0x40008BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x19")]
	internal bool IsPrefab;

	[Token(Token = "0x40008BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal GameObject OriginalObject;

	[Token(Token = "0x40008C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 DefaultPosition;

	[Token(Token = "0x40008C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 DefaultRotation;

	[Token(Token = "0x40008C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Transform OriginalParent;

	[Token(Token = "0x40008C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform TransformTo;

	[Token(Token = "0x40008C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private LayerMask OriginalRenderersLayerMask;

	[Token(Token = "0x40008C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private bool DefaultIsKinematic;

	[Token(Token = "0x40008C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x55")]
	private bool CachedUseGravity;

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x1087D5C", Offset = "0x1087D5C", VA = "0x1087D5C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60008E0")]
	[Address(RVA = "0x1087E5C", Offset = "0x1087E5C", VA = "0x1087E5C")]
	private void Start()
	{
	}

	[Token(Token = "0x60008E1")]
	[Address(RVA = "0x1087E68", Offset = "0x1087E68", VA = "0x1087E68")]
	public void AnimateToPOIPopup(Transform transformTo)
	{
	}

	[Token(Token = "0x60008E2")]
	[Address(RVA = "0x10884A0", Offset = "0x10884A0", VA = "0x10884A0")]
	public void MoveBack()
	{
	}

	[Token(Token = "0x60008E3")]
	[Address(RVA = "0x1088974", Offset = "0x1088974", VA = "0x1088974")]
	private void Update()
	{
	}

	[Token(Token = "0x60008E4")]
	[Address(RVA = "0x1088BC0", Offset = "0x1088BC0", VA = "0x1088BC0")]
	private void OnObjectGrabbed()
	{
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0x1088C7C", Offset = "0x1088C7C", VA = "0x1088C7C")]
	private void OnObjectReleased()
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0x1088F80", Offset = "0x1088F80", VA = "0x1088F80")]
	public POIPopupObjectHighlight()
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0x1088F88", Offset = "0x1088F88", VA = "0x1088F88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE474", Offset = "0xAEE474")]
	private void <AnimateToPOIPopup>b__12_0()
	{
	}
}
[Token(Token = "0x200016F")]
public class POIPopupVR : POIPopupBase
{
	[Token(Token = "0x2000170")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A34", Offset = "0xAE4A34")]
	private sealed class <OpenAnimation>d__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public POIPopupVR <>4__this;

		[Token(Token = "0x17000153")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60008FE")]
			[Address(RVA = "0x167398C", Offset = "0x167398C", VA = "0x167398C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000154")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000900")]
			[Address(RVA = "0x16739D4", Offset = "0x16739D4", VA = "0x16739D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x16735A0", Offset = "0x16735A0", VA = "0x16735A0")]
		[DebuggerHidden]
		public <OpenAnimation>d__38(int <>1__state)
		{
		}

		[Token(Token = "0x60008FC")]
		[Address(RVA = "0x16735CC", Offset = "0x16735CC", VA = "0x16735CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60008FD")]
		[Address(RVA = "0x16735D0", Offset = "0x16735D0", VA = "0x16735D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60008FF")]
		[Address(RVA = "0x1673994", Offset = "0x1673994", VA = "0x1673994", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000171")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A44", Offset = "0xAE4A44")]
	private sealed class <CollectAnimationAndClose>d__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40008E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x40008EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x40008EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public POIPopupVR <>4__this;

		[Token(Token = "0x40008EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private int <slotIndex>5__2;

		[Token(Token = "0x40008ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private int <poisFoundCount>5__3;

		[Token(Token = "0x17000155")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000904")]
			[Address(RVA = "0x1673550", Offset = "0x1673550", VA = "0x1673550", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000156")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000906")]
			[Address(RVA = "0x1673598", Offset = "0x1673598", VA = "0x1673598", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000901")]
		[Address(RVA = "0x1672A48", Offset = "0x1672A48", VA = "0x1672A48")]
		[DebuggerHidden]
		public <CollectAnimationAndClose>d__39(int <>1__state)
		{
		}

		[Token(Token = "0x6000902")]
		[Address(RVA = "0x1672A74", Offset = "0x1672A74", VA = "0x1672A74", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000903")]
		[Address(RVA = "0x1672A78", Offset = "0x1672A78", VA = "0x1672A78", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000905")]
		[Address(RVA = "0x1673558", Offset = "0x1673558", VA = "0x1673558", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x2000172")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4A54", Offset = "0xAE4A54")]
	private sealed class <>c__DisplayClass41_0
	{
		[Token(Token = "0x40008EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public POIPopupVR <>4__this;

		[Token(Token = "0x40008EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int poisFoundCount;

		[Token(Token = "0x40008F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TweenCallback <>9__1;

		[Token(Token = "0x6000907")]
		[Address(RVA = "0x167282C", Offset = "0x167282C", VA = "0x167282C")]
		public <>c__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6000908")]
		[Address(RVA = "0x1672834", Offset = "0x1672834", VA = "0x1672834")]
		internal void <ShowCount>b__0()
		{
		}

		[Token(Token = "0x6000909")]
		[Address(RVA = "0x16729BC", Offset = "0x16729BC", VA = "0x16729BC")]
		internal void <ShowCount>b__1()
		{
		}
	}

	[Token(Token = "0x40008C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal static bool WaitingForPOICollect;

	[Token(Token = "0x40008C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public MeshRenderer FullsizeImage;

	[Token(Token = "0x40008C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public MeshRenderer PolaroidImage;

	[Token(Token = "0x40008CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TextMeshPro Title;

	[Token(Token = "0x40008CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public TextMeshPro Text;

	[Token(Token = "0x40008CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Transform Polaroid;

	[Token(Token = "0x40008CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Transform PolaroidRotationAxis;

	[Token(Token = "0x40008CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public MeshRenderer PolaroidShine;

	[Token(Token = "0x40008CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public NotepadInfo Notepad;

	[Token(Token = "0x40008D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public GameObject Note;

	[Token(Token = "0x40008D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public PressButton CloseButton;

	[Token(Token = "0x40008D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public StudioEventEmitter OpenAudio;

	[Token(Token = "0x40008D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public StudioEventEmitter CameraAudio;

	[Token(Token = "0x40008D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public BrinkHand LeftHand;

	[Token(Token = "0x40008D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public UIFader Count;

	[Token(Token = "0x40008D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public TextMeshPro CountLabel;

	[Token(Token = "0x40008D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public TextMeshPro ImageLoadingErrorLabel;

	[Token(Token = "0x40008D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public MeshRenderer Loader;

	[Token(Token = "0x40008D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	public Transform ObjectHighlightPosition;

	[Token(Token = "0x40008DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	public Transform[] PolaroidSlots;

	[Token(Token = "0x40008DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Texture DefaultImageTexture;

	[Token(Token = "0x40008DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Animator Animator;

	[Token(Token = "0x40008DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Vector3 OpeningHeadPosition;

	[Token(Token = "0x40008DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private Vector3 NoteDefaultPosition;

	[Token(Token = "0x40008DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private Vector3 NoteDefaultRotation;

	[Token(Token = "0x40008E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x114")]
	private Vector3 CloseButtonDefaultPosition;

	[Token(Token = "0x40008E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Vector3 PolaroidDefaultPosition;

	[Token(Token = "0x40008E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
	private Vector3 PolaroidDefaultRotation;

	[Token(Token = "0x40008E3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private Vector3 PolaroidDefaultScale;

	[Token(Token = "0x40008E4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x144")]
	private bool CollectAnimationPlaying;

	[Token(Token = "0x40008E5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private Grabbable NoteGrabbable;

	[Token(Token = "0x60008E8")]
	[Address(RVA = "0x1088FB0", Offset = "0x1088FB0", VA = "0x1088FB0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0x1089300", Offset = "0x1089300", VA = "0x1089300", Slot = "5")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0x108944C", Offset = "0x108944C", VA = "0x108944C", Slot = "7")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x1089494", Offset = "0x1089494", VA = "0x1089494", Slot = "6")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x10895A8", Offset = "0x10895A8", VA = "0x10895A8", Slot = "10")]
	public override void SetDataAndOpen(POIMarker marker, bool justFound, POIPopupObjectHighlight objectHighlight)
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x1089C70", Offset = "0x1089C70", VA = "0x1089C70", Slot = "9")]
	internal override void Close(bool dispatch = true)
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x1089804", Offset = "0x1089804", VA = "0x1089804")]
	private void InitAndLoadImage()
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x1089EA0", Offset = "0x1089EA0", VA = "0x1089EA0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE484", Offset = "0xAEE484")]
	private IEnumerator OpenAnimation()
	{
		return null;
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x1089D90", Offset = "0x1089D90", VA = "0x1089D90")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE4E4", Offset = "0xAEE4E4")]
	private IEnumerator CollectAnimationAndClose()
	{
		return null;
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x1089F0C", Offset = "0x1089F0C", VA = "0x1089F0C")]
	private void HideCount()
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x1089F78", Offset = "0x1089F78", VA = "0x1089F78")]
	private void ShowCount(int poisFoundCount)
	{
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x108A320", Offset = "0x108A320", VA = "0x108A320")]
	private int FindRelevantSlot()
	{
		return default(int);
	}

	[Token(Token = "0x60008F4")]
	[Address(RVA = "0x108A444", Offset = "0x108A444", VA = "0x108A444")]
	private void OnCloseSelected(ButtonBase arg0)
	{
	}

	[Token(Token = "0x60008F5")]
	[Address(RVA = "0x108A4E4", Offset = "0x108A4E4", VA = "0x108A4E4")]
	private void OnNoteGrabbed(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x60008F6")]
	[Address(RVA = "0x108A584", Offset = "0x108A584", VA = "0x108A584")]
	private void OnNoteRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x60008F7")]
	[Address(RVA = "0x108A6B8", Offset = "0x108A6B8", VA = "0x108A6B8")]
	public POIPopupVR()
	{
	}

	[Token(Token = "0x60008F8")]
	[Address(RVA = "0x108A6BC", Offset = "0x108A6BC", VA = "0x108A6BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE544", Offset = "0xAEE544")]
	private void <InitAndLoadImage>b__37_0(Texture texture, bool noInternet)
	{
	}

	[Token(Token = "0x60008F9")]
	[Address(RVA = "0x108A7EC", Offset = "0x108A7EC", VA = "0x108A7EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE554", Offset = "0xAEE554")]
	private void <CollectAnimationAndClose>b__39_0()
	{
	}

	[Token(Token = "0x60008FA")]
	[Address(RVA = "0x108A81C", Offset = "0x108A81C", VA = "0x108A81C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE564", Offset = "0xAEE564")]
	private void <CollectAnimationAndClose>b__39_1()
	{
	}
}
[Token(Token = "0x2000173")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE4A64", Offset = "0xAE4A64")]
public class PressButton : ButtonBase
{
	[Token(Token = "0x40008F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public GameObject Press;

	[Token(Token = "0x40008F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Collider IntentCollider;

	[Token(Token = "0x40008F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public bool DisableHandOnPress;

	[Token(Token = "0x40008F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Rigidbody ParentRigidbody;

	[Token(Token = "0x40008F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA8A4", Offset = "0xAEA8A4")]
	public ShapeRenderer Highlight;

	[Token(Token = "0x40008F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected readonly List<BrinkHand> InteractingHands;

	[Token(Token = "0x40008F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Rigidbody FixedRigidbody;

	[Token(Token = "0x40008F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private StudioEventEmitter SelectAudio;

	[Token(Token = "0x40008F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject LimitColliderDown;

	[Token(Token = "0x40008FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private GameObject LimitColliderUp;

	[Token(Token = "0x40008FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Vector3 PreviousButtonPosition;

	[Token(Token = "0x40008FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Quaternion PreviousButtonRotation;

	[Token(Token = "0x40008FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float Threshold;

	[Token(Token = "0x40008FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Rigidbody PressRigibody;

	[Token(Token = "0x40008FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private Collider PressCollider;

	[Token(Token = "0x4000900")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private float PressRestLocalPositionY;

	[Token(Token = "0x4000901")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	private bool WaitForRelease;

	[Token(Token = "0x4000902")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private Vector3 HighlightOriginalScale;

	[Token(Token = "0x4000903")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC4")]
	private Vector3 PressColliderBounds;

	[Token(Token = "0x4000904")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private CollisionNotifier CollisionNotifier;

	[Token(Token = "0x4000905")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private bool OnEnableCalled;

	[Token(Token = "0x4000906")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Rigidbody ParentRigidBody;

	[Token(Token = "0x17000157")]
	private bool PressIsTweening
	{
		[Token(Token = "0x6000910")]
		[Address(RVA = "0x1092830", Offset = "0x1092830", VA = "0x1092830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000158")]
	private bool PressRigibodyIsKinematic
	{
		[Token(Token = "0x6000912")]
		[Address(RVA = "0x109289C", Offset = "0x109289C", VA = "0x109289C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000911")]
		[Address(RVA = "0x1091118", Offset = "0x1091118", VA = "0x1091118")]
		set
		{
		}
	}

	[Token(Token = "0x600090A")]
	[Address(RVA = "0x1090D48", Offset = "0x1090D48", VA = "0x1090D48", Slot = "9")]
	public virtual void Awake()
	{
	}

	[Token(Token = "0x600090B")]
	[Address(RVA = "0x1090E34", Offset = "0x1090E34", VA = "0x1090E34", Slot = "4")]
	protected override void Start()
	{
	}

	[Token(Token = "0x600090C")]
	[Address(RVA = "0x10918D0", Offset = "0x10918D0", VA = "0x10918D0", Slot = "10")]
	protected virtual void OnEnable()
	{
	}

	[Token(Token = "0x600090D")]
	[Address(RVA = "0x1091ABC", Offset = "0x1091ABC", VA = "0x1091ABC", Slot = "11")]
	protected virtual void OnDisable()
	{
	}

	[Token(Token = "0x600090E")]
	[Address(RVA = "0x1091CD4", Offset = "0x1091CD4", VA = "0x1091CD4", Slot = "12")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600090F")]
	[Address(RVA = "0x1091FF4", Offset = "0x1091FF4", VA = "0x1091FF4", Slot = "5")]
	protected override void FixedUpdate()
	{
	}

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x10928B8", Offset = "0x10928B8", VA = "0x10928B8")]
	private void OnPressCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x10929D8", Offset = "0x10929D8", VA = "0x10929D8")]
	private void OnPressCollisionStay(Collision other)
	{
	}

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x1092AF8", Offset = "0x1092AF8", VA = "0x1092AF8")]
	private void OnPressCollisionExit(Collision other)
	{
	}

	[Token(Token = "0x6000916")]
	[Address(RVA = "0x1091EBC", Offset = "0x1091EBC", VA = "0x1091EBC")]
	private void KeepAligned()
	{
	}

	[Token(Token = "0x6000917")]
	[Address(RVA = "0x1092BD0", Offset = "0x1092BD0", VA = "0x1092BD0", Slot = "6")]
	public override void Select(bool skipAnimation = false, bool dispatch = true)
	{
	}

	[Token(Token = "0x6000918")]
	[Address(RVA = "0x1092D80", Offset = "0x1092D80", VA = "0x1092D80", Slot = "7")]
	public override void Deselect(bool skipAnimation = false)
	{
	}

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x1092E50", Offset = "0x1092E50", VA = "0x1092E50", Slot = "8")]
	protected override void OnSelect(bool dispatch = true)
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x1091454", Offset = "0x1091454", VA = "0x1091454")]
	private void CreateLimitColliders()
	{
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0x1091D30", Offset = "0x1091D30", VA = "0x1091D30")]
	private void UpdateHighlightOpacity()
	{
	}

	[Token(Token = "0x600091C")]
	[Address(RVA = "0x109117C", Offset = "0x109117C", VA = "0x109117C")]
	private static Vector3 GetBoundingBox(Collider c)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600091D")]
	[Address(RVA = "0x1092F80", Offset = "0x1092F80", VA = "0x1092F80")]
	public PressButton()
	{
	}

	[Token(Token = "0x600091E")]
	[Address(RVA = "0x1093008", Offset = "0x1093008", VA = "0x1093008")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE614", Offset = "0xAEE614")]
	private void <Select>b__37_0()
	{
	}
}
[Token(Token = "0x2000174")]
public class Postcard : Grabbable
{
	[Token(Token = "0x2000175")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4AC4", Offset = "0xAE4AC4")]
	private sealed class <Save>d__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400091C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x400091D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x400091E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Postcard <>4__this;

		[Token(Token = "0x400091F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private RenderTexture <RT>5__2;

		[Token(Token = "0x4000920")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private string <fullPath>5__3;

		[Token(Token = "0x4000921")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private byte[] <bytes>5__4;

		[Token(Token = "0x4000922")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int <seconds>5__5;

		[Token(Token = "0x17000159")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000933")]
			[Address(RVA = "0x1674C9C", Offset = "0x1674C9C", VA = "0x1674C9C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015A")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000935")]
			[Address(RVA = "0x1674CE4", Offset = "0x1674CE4", VA = "0x1674CE4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1673C24", Offset = "0x1673C24", VA = "0x1673C24")]
		[DebuggerHidden]
		public <Save>d__31(int <>1__state)
		{
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1673C50", Offset = "0x1673C50", VA = "0x1673C50", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1673C54", Offset = "0x1673C54", VA = "0x1673C54", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1674CA4", Offset = "0x1674CA4", VA = "0x1674CA4", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000907")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool SELFIE_MODE;

	[Token(Token = "0x4000908")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	private static bool WIDE_FOV;

	[Token(Token = "0x4000909")]
	public const int PHOTO_WIDTH = 2048;

	[Token(Token = "0x400090A")]
	public const int PHOTO_HEIGHT = 1332;

	[Token(Token = "0x400090B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	[AttributeAttribute(Name = "HeaderAttribute", RVA = "0xAEA8DC", Offset = "0xAEA8DC")]
	public MeshRenderer FrontImage;

	[Token(Token = "0x400090C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	public MeshRenderer BackImage;

	[Token(Token = "0x400090D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	public GameObject ShareButton;

	[Token(Token = "0x400090E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	public GameObject DiscardButton;

	[Token(Token = "0x400090F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public GameObject FlipButton;

	[Token(Token = "0x4000910")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	public GameObject FOVButton;

	[Token(Token = "0x4000911")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	public TextMeshPro CoundownField;

	[Token(Token = "0x4000912")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	public Camera RealtimeCamera;

	[Token(Token = "0x4000913")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	public Camera PhotoCamera;

	[Token(Token = "0x4000914")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	public Canvas Canvas;

	[Token(Token = "0x4000915")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	public CanvasScaler CanvasScaler;

	[Token(Token = "0x4000916")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	public UnityEvent SavedEvent;

	[Token(Token = "0x4000917")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private Rigidbody Rigidbody;

	[Token(Token = "0x4000918")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private bool HasBeenDiscarded;

	[Token(Token = "0x4000919")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x191")]
	private bool HasBeenThrownAway;

	[Token(Token = "0x400091A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x192")]
	private bool Saving;

	[Token(Token = "0x400091B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x193")]
	private bool CountDownActive;

	[Token(Token = "0x600091F")]
	[Address(RVA = "0x108E3F4", Offset = "0x108E3F4", VA = "0x108E3F4", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6000920")]
	[Address(RVA = "0x108E884", Offset = "0x108E884", VA = "0x108E884")]
	private void OnRelease(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x6000921")]
	[Address(RVA = "0x108E914", Offset = "0x108E914", VA = "0x108E914")]
	private void Start()
	{
	}

	[Token(Token = "0x6000922")]
	[Address(RVA = "0x108E958", Offset = "0x108E958", VA = "0x108E958")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000923")]
	[Address(RVA = "0x108EB08", Offset = "0x108EB08", VA = "0x108EB08")]
	private void Update()
	{
	}

	[Token(Token = "0x6000924")]
	[Address(RVA = "0x108F13C", Offset = "0x108F13C", VA = "0x108F13C", Slot = "14")]
	protected override void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000925")]
	[Address(RVA = "0x108F178", Offset = "0x108F178", VA = "0x108F178", Slot = "12")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6000926")]
	[Address(RVA = "0x108F404", Offset = "0x108F404", VA = "0x108F404")]
	public void AnimateIn()
	{
	}

	[Token(Token = "0x6000927")]
	[Address(RVA = "0x108F4B0", Offset = "0x108F4B0", VA = "0x108F4B0")]
	public void AnimateToNotepad()
	{
	}

	[Token(Token = "0x6000928")]
	[Address(RVA = "0x108F5E8", Offset = "0x108F5E8", VA = "0x108F5E8")]
	private void OnSaveButtonPress(ButtonBase btn)
	{
	}

	[Token(Token = "0x6000929")]
	[Address(RVA = "0x108F678", Offset = "0x108F678", VA = "0x108F678")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE624", Offset = "0xAEE624")]
	private IEnumerator Save()
	{
		return null;
	}

	[Token(Token = "0x600092A")]
	[Address(RVA = "0x108F6E4", Offset = "0x108F6E4", VA = "0x108F6E4")]
	private void OnDiscardButtonPress(ButtonBase btn)
	{
	}

	[Token(Token = "0x600092B")]
	[Address(RVA = "0x108F6E8", Offset = "0x108F6E8", VA = "0x108F6E8")]
	private void OnFlipButtonPress(ButtonBase btn)
	{
	}

	[Token(Token = "0x600092C")]
	[Address(RVA = "0x108F73C", Offset = "0x108F73C", VA = "0x108F73C")]
	private void OnFOVButtonPress(ButtonBase btn)
	{
	}

	[Token(Token = "0x600092D")]
	[Address(RVA = "0x108F014", Offset = "0x108F014", VA = "0x108F014")]
	private void Discard()
	{
	}

	[Token(Token = "0x600092E")]
	[Address(RVA = "0x108F790", Offset = "0x108F790", VA = "0x108F790")]
	public Postcard()
	{
	}

	[Token(Token = "0x600092F")]
	[Address(RVA = "0x108F7F4", Offset = "0x108F7F4", VA = "0x108F7F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE684", Offset = "0xAEE684")]
	private void <Discard>b__35_0()
	{
	}
}
[Token(Token = "0x2000176")]
public class PostcardManager : MonoBehaviour
{
	[Token(Token = "0x2000177")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4AD4", Offset = "0xAE4AD4")]
	private sealed class <<OnPostcardSaved>g__FlyToNotepad|26_0>d : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000934")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000935")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000936")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PostcardManager <>4__this;

		[Token(Token = "0x4000937")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Tween <t>5__2;

		[Token(Token = "0x4000938")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private float <flyStartTime>5__3;

		[Token(Token = "0x1700015E")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x1675170", Offset = "0x1675170", VA = "0x1675170", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700015F")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x16751B8", Offset = "0x16751B8", VA = "0x16751B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x1674CEC", Offset = "0x1674CEC", VA = "0x1674CEC")]
		[DebuggerHidden]
		public <<OnPostcardSaved>g__FlyToNotepad|26_0>d(int <>1__state)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x1674D18", Offset = "0x1674D18", VA = "0x1674D18", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x1674D1C", Offset = "0x1674D1C", VA = "0x1674D1C", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x1675178", Offset = "0x1675178", VA = "0x1675178", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000923")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Postcard CurrentPostcard;

	[Token(Token = "0x4000924")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public GameObject PostcardPrefab;

	[Token(Token = "0x4000925")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public BrinkHand RightHand;

	[Token(Token = "0x4000926")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public BrinkHand LeftHand;

	[Token(Token = "0x4000927")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Notepad Notepad;

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public Transform RightController;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public Transform LeftController;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Rectangle TimerRectangle;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA914", Offset = "0xAEA914")]
	private bool <DoingCameraGesture>k__BackingField;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA924", Offset = "0xAEA924")]
	private bool <TakingPicture>k__BackingField;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public UnityEvent OnPostcardSpawned;

	[Token(Token = "0x400092E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float GestureStartTime;

	[Token(Token = "0x400092F")]
	private const float GestureHoldTime = 0.7f;

	[Token(Token = "0x4000930")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private bool WaitForNotDoingCameraGesture;

	[Token(Token = "0x4000931")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float FlyToNotepadRatio;

	[Token(Token = "0x4000932")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 SavedPostcardFinalPositionTo;

	[Token(Token = "0x4000933")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool FlyingToNotepad;

	[Token(Token = "0x1700015B")]
	public static bool TakingSelfie
	{
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x108F86C", Offset = "0x108F86C", VA = "0x108F86C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700015C")]
	public bool DoingCameraGesture
	{
		[Token(Token = "0x6000938")]
		[Address(RVA = "0x108F934", Offset = "0x108F934", VA = "0x108F934")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE6F4", Offset = "0xAEE6F4")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6000937")]
		[Address(RVA = "0x108F928", Offset = "0x108F928", VA = "0x108F928")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE6E4", Offset = "0xAEE6E4")]
		set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public bool TakingPicture
	{
		[Token(Token = "0x600093A")]
		[Address(RVA = "0x108F948", Offset = "0x108F948", VA = "0x108F948")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE714", Offset = "0xAEE714")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000939")]
		[Address(RVA = "0x108F93C", Offset = "0x108F93C", VA = "0x108F93C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE704", Offset = "0xAEE704")]
		private set
		{
		}
	}

	[Token(Token = "0x600093B")]
	[Address(RVA = "0x108F950", Offset = "0x108F950", VA = "0x108F950")]
	private void Update()
	{
	}

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x1090380", Offset = "0x1090380", VA = "0x1090380")]
	private void OnPostcardSaved()
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0x1090500", Offset = "0x1090500", VA = "0x1090500")]
	private void OnNotepadReleasedDuringAnimation(HandPhysics hand, Grabbable grabbable)
	{
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0x109051C", Offset = "0x109051C", VA = "0x109051C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0x10905CC", Offset = "0x10905CC", VA = "0x10905CC")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x10906C4", Offset = "0x10906C4", VA = "0x10906C4")]
	public PostcardManager()
	{
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0x1090494", Offset = "0x1090494", VA = "0x1090494")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE724", Offset = "0xAEE724")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE724", Offset = "0xAEE724")]
	private IEnumerator <OnPostcardSaved>g__FlyToNotepad|26_0()
	{
		return null;
	}

	[Token(Token = "0x6000942")]
	[Address(RVA = "0x1090728", Offset = "0x1090728", VA = "0x1090728")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE794", Offset = "0xAEE794")]
	private float <OnPostcardSaved>b__26_1()
	{
		return default(float);
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0x1090730", Offset = "0x1090730", VA = "0x1090730")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE7A4", Offset = "0xAEE7A4")]
	private void <OnPostcardSaved>b__26_2(float x)
	{
	}
}
[Token(Token = "0x2000178")]
[ExecuteInEditMode]
public class TextMeshProFakeLit : MonoBehaviour
{
	[Token(Token = "0x4000939")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Light Luminary;

	[Token(Token = "0x400093A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Color DarkColor;

	[Token(Token = "0x400093B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Color BrightColor;

	[Token(Token = "0x400093C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private TextMeshPro TextMeshPro;

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x1396AF8", Offset = "0x1396AF8", VA = "0x1396AF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x1396B4C", Offset = "0x1396B4C", VA = "0x1396B4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x1396E94", Offset = "0x1396E94", VA = "0x1396E94")]
	public TextMeshProFakeLit()
	{
	}
}
[Token(Token = "0x2000179")]
public class TextMeshPro_WithBrinkHighlight : TextMeshPro
{
	[Token(Token = "0x400093D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x75C")]
	public Vector4 BgMargin;

	[Token(Token = "0x400093E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
	public Texture2D CustomBgTexture;

	[Token(Token = "0x400093F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
	private Vector3[] Vertices;

	[Token(Token = "0x4000940")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
	private Vector2[] UVs;

	[Token(Token = "0x4000941")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
	private Color32[] Colors32;

	[Token(Token = "0x4000942")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
	private int[] Triangles;

	[Token(Token = "0x4000943")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
	private MeshFilter HighlightMeshFiter;

	[Token(Token = "0x4000944")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static Shader Shader;

	[Token(Token = "0x4000945")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Texture Texture;

	[Token(Token = "0x600094D")]
	[Address(RVA = "0x1396ED8", Offset = "0x1396ED8", VA = "0x1396ED8", Slot = "4")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x1397020", Offset = "0x1397020", VA = "0x1397020", Slot = "7")]
	protected override void OnDisable()
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x13970CC", Offset = "0x13970CC", VA = "0x13970CC", Slot = "142")]
	protected override void GenerateTextMesh()
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x13974FC", Offset = "0x13974FC", VA = "0x13974FC", Slot = "126")]
	protected override void DrawTextHighlight(Vector3 start, Vector3 end, ref int index, Color32 highlightColor)
	{
	}

	[Token(Token = "0x6000951")]
	[Address(RVA = "0x13979C8", Offset = "0x13979C8", VA = "0x13979C8", Slot = "122")]
	protected override void FillCharacterVertexBuffers(int i, int index_X4)
	{
	}

	[Token(Token = "0x6000952")]
	[Address(RVA = "0x13980D4", Offset = "0x13980D4", VA = "0x13980D4", Slot = "124")]
	protected override void FillSpriteVertexBuffers(int i, int index_X4)
	{
	}

	[Token(Token = "0x6000953")]
	[Address(RVA = "0x13987E0", Offset = "0x13987E0", VA = "0x13987E0")]
	public TextMeshPro_WithBrinkHighlight()
	{
	}
}
[Token(Token = "0x200017A")]
public class Tips : MonoBehaviour
{
	[Token(Token = "0x200017B")]
	private struct Tip
	{
		[Token(Token = "0x400094A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public readonly int Index;

		[Token(Token = "0x400094B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public readonly string Key;

		[Token(Token = "0x400094C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly int Weight;

		[Token(Token = "0x6000959")]
		[Address(RVA = "0x1677CA4", Offset = "0x1677CA4", VA = "0x1677CA4")]
		public Tip(int index, string key, int weight)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200017C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4AF4", Offset = "0xAE4AF4")]
	private sealed class <>c
	{
		[Token(Token = "0x400094D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly <>c <>9;

		[Token(Token = "0x400094E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<Tip, bool> <>9__7_0;

		[Token(Token = "0x400094F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<Tip, Tip> <>9__7_1;

		[Token(Token = "0x4000950")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<Tip, int> <>9__7_2;

		[Token(Token = "0x600095B")]
		[Address(RVA = "0x1677BC0", Offset = "0x1677BC0", VA = "0x1677BC0")]
		public <>c()
		{
		}

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1677BC8", Offset = "0x1677BC8", VA = "0x1677BC8")]
		internal bool <GetShuffledTip>b__7_0(Tip t)
		{
			return default(bool);
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1677C88", Offset = "0x1677C88", VA = "0x1677C88")]
		internal Tip <GetShuffledTip>b__7_1(Tip t)
		{
			return default(Tip);
		}

		[Token(Token = "0x600095E")]
		[Address(RVA = "0x1677C9C", Offset = "0x1677C9C", VA = "0x1677C9C")]
		internal int <GetShuffledTip>b__7_2(Tip t)
		{
			return default(int);
		}
	}

	[Token(Token = "0x4000946")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private readonly Tip[] AllTips;

	[Token(Token = "0x4000947")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static List<Tip> UsedIndexes;

	[Token(Token = "0x4000948")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public MeshRenderer Icon;

	[Token(Token = "0x4000949")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public TextMeshPro Text;

	[Token(Token = "0x6000954")]
	[Address(RVA = "0x1399AE4", Offset = "0x1399AE4", VA = "0x1399AE4")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000955")]
	[Address(RVA = "0x1399AE8", Offset = "0x1399AE8", VA = "0x1399AE8")]
	private void UpdateTip()
	{
	}

	[Token(Token = "0x6000956")]
	[Address(RVA = "0x1399CDC", Offset = "0x1399CDC", VA = "0x1399CDC")]
	private Tip GetShuffledTip()
	{
		return default(Tip);
	}

	[Token(Token = "0x6000957")]
	[Address(RVA = "0x139A0E4", Offset = "0x139A0E4", VA = "0x139A0E4")]
	public Tips()
	{
	}
}
[Token(Token = "0x200017D")]
public class TutorialItemShineEffect : MonoBehaviour
{
	[Token(Token = "0x4000951")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer FlareRenderer;

	[Token(Token = "0x4000952")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Transform Pivot;

	[Token(Token = "0x4000953")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public MeshRenderer FocusCircle;

	[Token(Token = "0x4000954")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Transform Item;

	[Token(Token = "0x600095F")]
	[Address(RVA = "0x139D064", Offset = "0x139D064", VA = "0x139D064")]
	private void Update()
	{
	}

	[Token(Token = "0x6000960")]
	[Address(RVA = "0x139D0E8", Offset = "0x139D0E8", VA = "0x139D0E8")]
	private void UpdatePosition()
	{
	}

	[Token(Token = "0x6000961")]
	[Address(RVA = "0x139D24C", Offset = "0x139D24C", VA = "0x139D24C")]
	public void ActivateOn(Transform item)
	{
	}

	[Token(Token = "0x6000962")]
	[Address(RVA = "0x139D728", Offset = "0x139D728", VA = "0x139D728")]
	public void FadeOut()
	{
	}

	[Token(Token = "0x6000963")]
	[Address(RVA = "0x139D818", Offset = "0x139D818", VA = "0x139D818")]
	public TutorialItemShineEffect()
	{
	}

	[Token(Token = "0x6000964")]
	[Address(RVA = "0x139D820", Offset = "0x139D820", VA = "0x139D820")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE804", Offset = "0xAEE804")]
	private void <FadeOut>b__7_0()
	{
	}
}
[Token(Token = "0x200017E")]
public class AuthManager : MonoBehaviour
{
	[Token(Token = "0x4000955")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static AuthManager _Instance;

	[Token(Token = "0x4000956")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static string USER_ID;

	[Token(Token = "0x4000957")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static string USER_GAME_ID;

	[Token(Token = "0x4000958")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string USERNAME;

	[Token(Token = "0x4000959")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public UnityEvent OnAuthSuccess;

	[Token(Token = "0x400095A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public UnityEvent OnAuthRequired2DStep;

	[Token(Token = "0x400095B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public UnityEvent OnAuthFailed;

	[Token(Token = "0x400095C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected bool IsInitializing;

	[Token(Token = "0x17000160")]
	public static AuthManager Instance
	{
		[Token(Token = "0x6000965")]
		[Address(RVA = "0x11936E0", Offset = "0x11936E0", VA = "0x11936E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000161")]
	public virtual bool IsInitialized
	{
		[Token(Token = "0x6000968")]
		[Address(RVA = "0x11939EC", Offset = "0x11939EC", VA = "0x11939EC", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000966")]
	[Address(RVA = "0x1193840", Offset = "0x1193840", VA = "0x1193840")]
	private void Start()
	{
	}

	[Token(Token = "0x6000967")]
	[Address(RVA = "0x11938B8", Offset = "0x11938B8", VA = "0x11938B8", Slot = "4")]
	public virtual void Initialize(string appId)
	{
	}

	[Token(Token = "0x6000969")]
	[Address(RVA = "0x11939F4", Offset = "0x11939F4", VA = "0x11939F4")]
	private void OnAuthCallback()
	{
	}

	[Token(Token = "0x600096A")]
	[Address(RVA = "0x1193AFC", Offset = "0x1193AFC", VA = "0x1193AFC")]
	public AuthManager()
	{
	}
}
[Token(Token = "0x200017F")]
public class DLCManager : MonoBehaviour
{
	[Token(Token = "0x400095D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DLCManager _Instance;

	[Token(Token = "0x17000162")]
	public static DLCManager Instance
	{
		[Token(Token = "0x600096C")]
		[Address(RVA = "0x15D58A0", Offset = "0x15D58A0", VA = "0x15D58A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600096D")]
	[Address(RVA = "0x15D59AC", Offset = "0x15D59AC", VA = "0x15D59AC", Slot = "4")]
	public virtual void GetDownloadableAssetsList(Action<bool, AssetFileItemData[], string> callback)
	{
	}

	[Token(Token = "0x600096E")]
	[Address(RVA = "0x15D59B0", Offset = "0x15D59B0", VA = "0x15D59B0", Slot = "5")]
	public virtual void Download(AssetFileItemData item, Action<bool, AssetFileItemData, string> callback)
	{
	}

	[Token(Token = "0x600096F")]
	[Address(RVA = "0x15D59B4", Offset = "0x15D59B4", VA = "0x15D59B4")]
	public DLCManager()
	{
	}
}
[Token(Token = "0x2000180")]
public class IAPManager : MonoBehaviour
{
	[Token(Token = "0x400095E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IAPManager _Instance;

	[Token(Token = "0x400095F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static readonly string[] skus;

	[Token(Token = "0x4000960")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Action<bool, string, string[]> GetUserPurchasesCallback;

	[Token(Token = "0x4000961")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Action<bool, string, Dictionary<string, string>> GetPricesCallback;

	[Token(Token = "0x4000962")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected Action<bool, string, string> PurchaseCallback;

	[Token(Token = "0x4000963")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Action<bool, string> ConsumePurchaseCallback;

	[Token(Token = "0x4000964")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected bool IsInitializing;

	[Token(Token = "0x4000965")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x39")]
	protected bool IsInitialized;

	[Token(Token = "0x17000163")]
	public static IAPManager Instance
	{
		[Token(Token = "0x6000970")]
		[Address(RVA = "0x15E3378", Offset = "0x15E3378", VA = "0x15E3378")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000971")]
	[Address(RVA = "0x15E34F4", Offset = "0x15E34F4", VA = "0x15E34F4")]
	private void Start()
	{
	}

	[Token(Token = "0x6000972")]
	[Address(RVA = "0x15E356C", Offset = "0x15E356C", VA = "0x15E356C", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x6000973")]
	[Address(RVA = "0x15E3570", Offset = "0x15E3570", VA = "0x15E3570", Slot = "5")]
	public virtual void GetUserPurchases(Action<bool, string, string[]> callback)
	{
	}

	[Token(Token = "0x6000974")]
	[Address(RVA = "0x15E3578", Offset = "0x15E3578", VA = "0x15E3578", Slot = "6")]
	public virtual void GetPrices(Action<bool, string, Dictionary<string, string>> callback)
	{
	}

	[Token(Token = "0x6000975")]
	[Address(RVA = "0x15E3580", Offset = "0x15E3580", VA = "0x15E3580", Slot = "7")]
	public virtual void Purchase(string SKU, Action<bool, string, string> callback)
	{
	}

	[Token(Token = "0x6000976")]
	[Address(RVA = "0x15E3588", Offset = "0x15E3588", VA = "0x15E3588", Slot = "8")]
	public virtual void Consume(string sku, Action<bool, string> callback)
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0x15E3590", Offset = "0x15E3590", VA = "0x15E3590")]
	public IAPManager()
	{
	}
}
[Token(Token = "0x2000181")]
public class LeaderboardsManager : MonoBehaviour
{
	[Token(Token = "0x4000966")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LeaderboardsManager _Instance;

	[Token(Token = "0x4000967")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected readonly Dictionary<string, long> UserBestScores;

	[Token(Token = "0x4000968")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected readonly Dictionary<string, ulong> EntriesCount;

	[Token(Token = "0x4000969")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string CurrentBoardName;

	[Token(Token = "0x400096A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected Action<bool, string, SortedDictionary<int, LeaderboardItemData>> GetEntriesCallback;

	[Token(Token = "0x400096B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Action<bool, string, LeaderboardItemData> GetPlayerCallback;

	[Token(Token = "0x400096C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected Action<bool, string> SetEntryCallback;

	[Token(Token = "0x17000164")]
	public static LeaderboardsManager Instance
	{
		[Token(Token = "0x6000979")]
		[Address(RVA = "0x141C70C", Offset = "0x141C70C", VA = "0x141C70C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000165")]
	public virtual bool HasNextPage
	{
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x141CA24", Offset = "0x141CA24", VA = "0x141CA24", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000166")]
	public virtual bool HasPreviousPage
	{
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x141CA2C", Offset = "0x141CA2C", VA = "0x141CA2C", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0x141C834", Offset = "0x141C834", VA = "0x141C834")]
	private void Start()
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0x141C8AC", Offset = "0x141C8AC", VA = "0x141C8AC", Slot = "4")]
	public virtual void Init()
	{
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0x141C8B0", Offset = "0x141C8B0", VA = "0x141C8B0")]
	public long GetUserBestScore(string leaderboard_id)
	{
		return default(long);
	}

	[Token(Token = "0x600097D")]
	[Address(RVA = "0x141C954", Offset = "0x141C954", VA = "0x141C954")]
	public ulong GetEntriesCount(string leaderboard_id)
	{
		return default(ulong);
	}

	[Token(Token = "0x600097E")]
	[Address(RVA = "0x141C9F8", Offset = "0x141C9F8", VA = "0x141C9F8", Slot = "5")]
	public virtual void GetTopEntries(string leaderboard_id, int count, Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x600097F")]
	[Address(RVA = "0x141CA00", Offset = "0x141CA00", VA = "0x141CA00", Slot = "6")]
	public virtual void GetUserEntry(string leaderboard_id, Action<bool, string, LeaderboardItemData> callback)
	{
	}

	[Token(Token = "0x6000980")]
	[Address(RVA = "0x141CA0C", Offset = "0x141CA0C", VA = "0x141CA0C", Slot = "7")]
	public virtual void GetNextEntries(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x6000981")]
	[Address(RVA = "0x141CA14", Offset = "0x141CA14", VA = "0x141CA14", Slot = "8")]
	public virtual void GetPreviousEntries(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x6000982")]
	[Address(RVA = "0x141CA1C", Offset = "0x141CA1C", VA = "0x141CA1C", Slot = "9")]
	public virtual void WriteEntry(string leaderboard_id, long score, Action<bool, string> callback, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6000985")]
	[Address(RVA = "0x141CA34", Offset = "0x141CA34", VA = "0x141CA34")]
	public LeaderboardsManager()
	{
	}
}
[Token(Token = "0x2000182")]
public class AssetFileItemData
{
	[Token(Token = "0x2000183")]
	public enum AssetFileItemDownloadStatus
	{
		[Token(Token = "0x4000974")]
		Undefined,
		[Token(Token = "0x4000975")]
		Installed,
		[Token(Token = "0x4000976")]
		Available,
		[Token(Token = "0x4000977")]
		InProgress
	}

	[Token(Token = "0x2000184")]
	public enum AssetFileItemIAPStatus
	{
		[Token(Token = "0x4000979")]
		Undefined,
		[Token(Token = "0x400097A")]
		Free,
		[Token(Token = "0x400097B")]
		Entitle,
		[Token(Token = "0x400097C")]
		NotEntitled
	}

	[Token(Token = "0x400096D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public ulong Id;

	[Token(Token = "0x400096E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public AssetFileItemDownloadStatus DownloadStatus;

	[Token(Token = "0x400096F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected string Type;

	[Token(Token = "0x4000970")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	protected string Filepath;

	[Token(Token = "0x4000971")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	protected AssetFileItemIAPStatus IapStatus;

	[Token(Token = "0x4000972")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected readonly AssetFileItemDataEvent DownloadProgressEvent;

	[Token(Token = "0x6000986")]
	[Address(RVA = "0x1193228", Offset = "0x1193228", VA = "0x1193228")]
	public AssetFileItemData()
	{
	}
}
[Serializable]
[Token(Token = "0x2000185")]
public class AssetFileItemDataEvent : UnityEvent<float>
{
	[Token(Token = "0x6000987")]
	[Address(RVA = "0x1193288", Offset = "0x1193288", VA = "0x1193288")]
	public AssetFileItemDataEvent()
	{
	}
}
[Token(Token = "0x2000186")]
public class LeaderboardItemData
{
	[Token(Token = "0x400097D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public bool IsMe;

	[Token(Token = "0x400097E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public string Username;

	[Token(Token = "0x400097F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public string ImageURL;

	[Token(Token = "0x4000980")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Texture2D Image;

	[Token(Token = "0x4000981")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public int Rank;

	[Token(Token = "0x4000982")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public long Score;

	[Token(Token = "0x6000988")]
	[Address(RVA = "0x141C704", Offset = "0x141C704", VA = "0x141C704")]
	public LeaderboardItemData()
	{
	}
}
[Token(Token = "0x2000187")]
public class AssetFileItemDataOVR : AssetFileItemData
{
	[Token(Token = "0x6000989")]
	[Address(RVA = "0x11932D4", Offset = "0x11932D4", VA = "0x11932D4")]
	public AssetFileItemDataOVR(ulong id, string type, AssetFileItemDownloadStatus downloadStatus, string filepath, AssetFileItemIAPStatus iapStatus)
	{
	}

	[Token(Token = "0x600098A")]
	[Address(RVA = "0x11933A8", Offset = "0x11933A8", VA = "0x11933A8")]
	private void OnDownloadUpdateNotification(Message<AssetFileDownloadUpdate> message)
	{
	}
}
[Token(Token = "0x2000188")]
public class OVRAuthManager : AuthManager
{
	[Token(Token = "0x17000167")]
	public override bool IsInitialized
	{
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x1081034", Offset = "0x1081034", VA = "0x1081034", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600098B")]
	[Address(RVA = "0x1080CFC", Offset = "0x1080CFC", VA = "0x1080CFC", Slot = "4")]
	public override void Initialize(string appID)
	{
	}

	[Token(Token = "0x600098C")]
	[Address(RVA = "0x1080FD8", Offset = "0x1080FD8", VA = "0x1080FD8")]
	private void EntitlementCheckCallback(Message msg)
	{
	}

	[Token(Token = "0x600098E")]
	[Address(RVA = "0x1080EEC", Offset = "0x1080EEC", VA = "0x1080EEC")]
	private void HandleEntitlementCheckResult(bool success, [Optional] Oculus.Platform.Models.Error error)
	{
	}

	[Token(Token = "0x600098F")]
	[Address(RVA = "0x10810D0", Offset = "0x10810D0", VA = "0x10810D0")]
	private void OnGetLoggedInUser(Message<User> message)
	{
	}

	[Token(Token = "0x6000990")]
	[Address(RVA = "0x1081288", Offset = "0x1081288", VA = "0x1081288")]
	public OVRAuthManager()
	{
	}
}
[Token(Token = "0x2000189")]
public class OVRDLCManager : DLCManager
{
	[Token(Token = "0x200018A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4B04", Offset = "0xAE4B04")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x4000985")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public OVRDLCManager <>4__this;

		[Token(Token = "0x4000986")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public AssetFileDownloadResult downloadResult;

		[Token(Token = "0x4000987")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AssetFileItemDataOVR downloadedItem;

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x167137C", Offset = "0x167137C", VA = "0x167137C")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1671384", Offset = "0x1671384", VA = "0x1671384")]
		internal void <OnDownloadComplete>b__0(bool success, AssetFileItemData[] items, string infoMessage)
		{
		}
	}

	[Token(Token = "0x4000983")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Action<bool, AssetFileItemDataOVR[], string> GetDownloadableAssetsCallback;

	[Token(Token = "0x4000984")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	protected Action<bool, AssetFileItemDataOVR, string> DownloadCallback;

	[Token(Token = "0x6000991")]
	[Address(RVA = "0x10812EC", Offset = "0x10812EC", VA = "0x10812EC", Slot = "4")]
	public override void GetDownloadableAssetsList(Action<bool, AssetFileItemData[], string> callback)
	{
	}

	[Token(Token = "0x6000992")]
	[Address(RVA = "0x10813CC", Offset = "0x10813CC", VA = "0x10813CC")]
	private void OnGetList(Message<AssetDetailsList> msg)
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0x1081944", Offset = "0x1081944", VA = "0x1081944")]
	public void Download(AssetFileItemDataOVR item, Action<bool, AssetFileItemData, string> callback)
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0x1081B34", Offset = "0x1081B34", VA = "0x1081B34")]
	private void OnDownloadComplete(Message<AssetFileDownloadResult> message)
	{
	}

	[Token(Token = "0x6000995")]
	[Address(RVA = "0x1081CD0", Offset = "0x1081CD0", VA = "0x1081CD0")]
	public OVRDLCManager()
	{
	}
}
[Token(Token = "0x200018B")]
public class OVRIAPManager : IAPManager
{
	[Token(Token = "0x6000998")]
	[Address(RVA = "0x1081CD8", Offset = "0x1081CD8", VA = "0x1081CD8", Slot = "7")]
	public override void Purchase(string sku, Action<bool, string, string> callback)
	{
	}

	[Token(Token = "0x6000999")]
	[Address(RVA = "0x1081DC0", Offset = "0x1081DC0", VA = "0x1081DC0", Slot = "6")]
	public override void GetPrices(Action<bool, string, Dictionary<string, string>> callback)
	{
	}

	[Token(Token = "0x600099A")]
	[Address(RVA = "0x1081EC8", Offset = "0x1081EC8", VA = "0x1081EC8", Slot = "5")]
	public override void GetUserPurchases(Action<bool, string, string[]> callback)
	{
	}

	[Token(Token = "0x600099B")]
	[Address(RVA = "0x1081F9C", Offset = "0x1081F9C", VA = "0x1081F9C", Slot = "8")]
	public override void Consume(string sku, Action<bool, string> callback)
	{
	}

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x108205C", Offset = "0x108205C", VA = "0x108205C")]
	private void ConsumeCallback(Message message)
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x1082124", Offset = "0x1082124", VA = "0x1082124")]
	private void GetProductsBySKUCallback(Message<ProductList> msg)
	{
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x1082310", Offset = "0x1082310", VA = "0x1082310")]
	private void GetViewerPurchasesCallback(Message<PurchaseList> msg)
	{
	}

	[Token(Token = "0x600099F")]
	[Address(RVA = "0x10824F4", Offset = "0x10824F4", VA = "0x10824F4")]
	private void LaunchCheckoutFlowCallback(Message<Purchase> msg)
	{
	}

	[Token(Token = "0x60009A0")]
	[Address(RVA = "0x1082634", Offset = "0x1082634", VA = "0x1082634")]
	public OVRIAPManager()
	{
	}
}
[Token(Token = "0x200018C")]
public class OVRLeaderboardsManager : LeaderboardsManager
{
	[Token(Token = "0x4000988")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Message<LeaderboardEntryList> LastMessage;

	[Token(Token = "0x17000168")]
	public override bool HasNextPage
	{
		[Token(Token = "0x60009A5")]
		[Address(RVA = "0x1082AA8", Offset = "0x1082AA8", VA = "0x1082AA8", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000169")]
	public override bool HasPreviousPage
	{
		[Token(Token = "0x60009A6")]
		[Address(RVA = "0x1082B20", Offset = "0x1082B20", VA = "0x1082B20", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60009A1")]
	[Address(RVA = "0x1082698", Offset = "0x1082698", VA = "0x1082698", Slot = "5")]
	public override void GetTopEntries(string leaderboard_id, int count, Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x60009A2")]
	[Address(RVA = "0x108279C", Offset = "0x108279C", VA = "0x108279C", Slot = "6")]
	public override void GetUserEntry(string leaderboard_id, Action<bool, string, LeaderboardItemData> callback)
	{
	}

	[Token(Token = "0x60009A3")]
	[Address(RVA = "0x1082890", Offset = "0x1082890", VA = "0x1082890", Slot = "7")]
	public override void GetNextEntries(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x108299C", Offset = "0x108299C", VA = "0x108299C", Slot = "8")]
	public override void GetPreviousEntries(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x60009A7")]
	[Address(RVA = "0x1082B98", Offset = "0x1082B98", VA = "0x1082B98")]
	private void OnGetPlayer(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60009A8")]
	[Address(RVA = "0x1082D9C", Offset = "0x1082D9C", VA = "0x1082D9C")]
	private void OnGetEntries(Message<LeaderboardEntryList> msg)
	{
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0x10832D0", Offset = "0x10832D0", VA = "0x10832D0", Slot = "9")]
	public override void WriteEntry(string leaderboard_id, long score, Action<bool, string> callback, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x10833E0", Offset = "0x10833E0", VA = "0x10833E0")]
	private void OnWriteEntry(Message<bool> msg)
	{
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x10834A8", Offset = "0x10834A8", VA = "0x10834A8")]
	public OVRLeaderboardsManager()
	{
	}
}
[Token(Token = "0x200018D")]
public class CameraCollisionManager : MonoBehaviour
{
	[Token(Token = "0x200018E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4B14", Offset = "0xAE4B14")]
	private sealed class <EnableColliderCo>d__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000992")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int <>1__state;

		[Token(Token = "0x4000993")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object <>2__current;

		[Token(Token = "0x4000994")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CameraCollisionManager <>4__this;

		[Token(Token = "0x1700016D")]
		private object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[Token(Token = "0x60009BE")]
			[Address(RVA = "0xE40598", Offset = "0xE40598", VA = "0xE40598", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700016E")]
		private object System.Collections.IEnumerator.Current
		{
			[Token(Token = "0x60009C0")]
			[Address(RVA = "0xE405E0", Offset = "0xE405E0", VA = "0xE405E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60009BB")]
		[Address(RVA = "0xE404A0", Offset = "0xE404A0", VA = "0xE404A0")]
		[DebuggerHidden]
		public <EnableColliderCo>d__18(int <>1__state)
		{
		}

		[Token(Token = "0x60009BC")]
		[Address(RVA = "0xE404CC", Offset = "0xE404CC", VA = "0xE404CC", Slot = "5")]
		[DebuggerHidden]
		private void System.IDisposable.Dispose()
		{
		}

		[Token(Token = "0x60009BD")]
		[Address(RVA = "0xE404D0", Offset = "0xE404D0", VA = "0xE404D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60009BF")]
		[Address(RVA = "0xE405A0", Offset = "0xE405A0", VA = "0xE405A0", Slot = "8")]
		[DebuggerHidden]
		private void System.Collections.IEnumerator.Reset()
		{
		}
	}

	[Token(Token = "0x4000989")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CameraFadeOverlay CameraFadeOverlay;

	[Token(Token = "0x400098A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask CollisionMask;

	[Token(Token = "0x400098B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SphereColliderStatus HeadColliderStatus;

	[Token(Token = "0x400098C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	internal Vector3 CollisionVector;

	[Token(Token = "0x400098D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	internal bool IsCloseToCollideWithMesh;

	[Token(Token = "0x400098E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private float DefaultHeadColliderRadius;

	[Token(Token = "0x400098F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	private float ColliderRadius;

	[Token(Token = "0x4000990")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Timer HideTimer;

	[Token(Token = "0x4000991")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA934", Offset = "0xAEA934")]
	private float <FadeOpacity>k__BackingField;

	[Token(Token = "0x1700016A")]
	internal bool IsCollidingWithMesh
	{
		[Token(Token = "0x60009AC")]
		[Address(RVA = "0x15D0A50", Offset = "0x15D0A50", VA = "0x15D0A50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700016B")]
	internal bool OverlayOpaqueEnoughForText
	{
		[Token(Token = "0x60009AD")]
		[Address(RVA = "0x15D0A6C", Offset = "0x15D0A6C", VA = "0x15D0A6C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700016C")]
	private float FadeOpacity
	{
		[Token(Token = "0x60009AF")]
		[Address(RVA = "0x15D0A8C", Offset = "0x15D0A8C", VA = "0x15D0A8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE824", Offset = "0xAEE824")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x60009AE")]
		[Address(RVA = "0x15D0A84", Offset = "0x15D0A84", VA = "0x15D0A84")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE814", Offset = "0xAEE814")]
		set
		{
		}
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x15D0A94", Offset = "0x15D0A94", VA = "0x15D0A94")]
	private void Awake()
	{
	}

	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x15D0B1C", Offset = "0x15D0B1C", VA = "0x15D0B1C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x15D0BD0", Offset = "0x15D0BD0", VA = "0x15D0BD0")]
	[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE834", Offset = "0xAEE834")]
	private IEnumerator EnableColliderCo()
	{
		return null;
	}

	[Token(Token = "0x60009B3")]
	[Address(RVA = "0x15D0C3C", Offset = "0x15D0C3C", VA = "0x15D0C3C")]
	private void Update()
	{
	}

	[Token(Token = "0x60009B4")]
	[Address(RVA = "0x15D0E28", Offset = "0x15D0E28", VA = "0x15D0E28")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x60009B5")]
	[Address(RVA = "0x15D0ED0", Offset = "0x15D0ED0", VA = "0x15D0ED0")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x60009B6")]
	[Address(RVA = "0x15D0F04", Offset = "0x15D0F04", VA = "0x15D0F04")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60009B7")]
	[Address(RVA = "0x15D142C", Offset = "0x15D142C", VA = "0x15D142C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60009B8")]
	[Address(RVA = "0x15D1434", Offset = "0x15D1434", VA = "0x15D1434")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60009B9")]
	[Address(RVA = "0x15D14B4", Offset = "0x15D14B4", VA = "0x15D14B4")]
	public CameraCollisionManager()
	{
	}

	[Token(Token = "0x60009BA")]
	[Address(RVA = "0x15D14E8", Offset = "0x15D14E8", VA = "0x15D14E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE894", Offset = "0xAEE894")]
	private void <OnTriggerExit>b__20_0()
	{
	}
}
[Token(Token = "0x200018F")]
public class CameraFadeOverlay : MonoBehaviour
{
	[Token(Token = "0x2000190")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4B24", Offset = "0xAE4B24")]
	private sealed class <>c__DisplayClass15_0
	{
		[Token(Token = "0x400099B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CameraFadeOverlay <>4__this;

		[Token(Token = "0x400099C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onComplete;

		[Token(Token = "0x60009CF")]
		[Address(RVA = "0xE405E8", Offset = "0xE405E8", VA = "0xE405E8")]
		public <>c__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60009D0")]
		[Address(RVA = "0xE405F0", Offset = "0xE405F0", VA = "0xE405F0")]
		internal float <Show>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60009D1")]
		[Address(RVA = "0xE4060C", Offset = "0xE4060C", VA = "0xE4060C")]
		internal void <Show>b__1(float x)
		{
		}

		[Token(Token = "0x60009D2")]
		[Address(RVA = "0xE40628", Offset = "0xE40628", VA = "0xE40628")]
		internal void <Show>b__2()
		{
		}
	}

	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4B34", Offset = "0xAE4B34")]
	private sealed class <>c__DisplayClass16_0
	{
		[Token(Token = "0x400099D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public CameraFadeOverlay <>4__this;

		[Token(Token = "0x400099E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action onComplete;

		[Token(Token = "0x60009D3")]
		[Address(RVA = "0xE40664", Offset = "0xE40664", VA = "0xE40664")]
		public <>c__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60009D4")]
		[Address(RVA = "0xE4066C", Offset = "0xE4066C", VA = "0xE4066C")]
		internal float <Hide>b__0()
		{
			return default(float);
		}

		[Token(Token = "0x60009D5")]
		[Address(RVA = "0xE40688", Offset = "0xE40688", VA = "0xE40688")]
		internal void <Hide>b__1(float x)
		{
		}

		[Token(Token = "0x60009D6")]
		[Address(RVA = "0xE406A4", Offset = "0xE406A4", VA = "0xE406A4")]
		internal void <Hide>b__2()
		{
		}
	}

	[Token(Token = "0x4000995")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private MeshRenderer _OverlayQuad;

	[Token(Token = "0x4000996")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform MainCameraTransform;

	[Token(Token = "0x4000997")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Sequence Sequence;

	[Token(Token = "0x4000998")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Tween ColorTween;

	[Token(Token = "0x4000999")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Color TargetColor;

	[Token(Token = "0x400099A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private float TargetAlpha;

	[Token(Token = "0x1700016F")]
	private MeshRenderer OverlayQuad
	{
		[Token(Token = "0x60009C1")]
		[Address(RVA = "0x15D14F0", Offset = "0x15D14F0", VA = "0x15D14F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000170")]
	public bool Shown
	{
		[Token(Token = "0x60009C2")]
		[Address(RVA = "0x15D1590", Offset = "0x15D1590", VA = "0x15D1590")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000171")]
	private bool AlphaIsTweening
	{
		[Token(Token = "0x60009CB")]
		[Address(RVA = "0x15D18F0", Offset = "0x15D18F0", VA = "0x15D18F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60009C3")]
	[Address(RVA = "0x15D15B0", Offset = "0x15D15B0", VA = "0x15D15B0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60009C4")]
	[Address(RVA = "0x15D17B4", Offset = "0x15D17B4", VA = "0x15D17B4")]
	private void Update()
	{
	}

	[Token(Token = "0x60009C5")]
	[Address(RVA = "0x15D199C", Offset = "0x15D199C", VA = "0x15D199C")]
	public void FromBlackSplashColorTOGrey(Color color)
	{
	}

	[Token(Token = "0x60009C6")]
	[Address(RVA = "0x15D1A84", Offset = "0x15D1A84", VA = "0x15D1A84")]
	public void SetColor(Color c, float duration = 0f)
	{
	}

	[Token(Token = "0x60009C7")]
	[Address(RVA = "0x15D0AE8", Offset = "0x15D0AE8", VA = "0x15D0AE8")]
	public void SetAlpha(float opacity)
	{
	}

	[Token(Token = "0x60009C8")]
	[Address(RVA = "0x15D1C44", Offset = "0x15D1C44", VA = "0x15D1C44")]
	public void Show(float time, float delay, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60009C9")]
	[Address(RVA = "0x15D1EF0", Offset = "0x15D1EF0", VA = "0x15D1EF0")]
	public void Hide(float time, float delay = 0f, [Optional] Action onComplete, Ease ease = Ease.Linear)
	{
	}

	[Token(Token = "0x60009CA")]
	[Address(RVA = "0x15D15B4", Offset = "0x15D15B4", VA = "0x15D15B4")]
	private void AttachToCamera()
	{
	}

	[Token(Token = "0x60009CC")]
	[Address(RVA = "0x15D215C", Offset = "0x15D215C", VA = "0x15D215C")]
	public CameraFadeOverlay()
	{
	}

	[Token(Token = "0x60009CD")]
	[Address(RVA = "0x15D216C", Offset = "0x15D216C", VA = "0x15D216C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE8F4", Offset = "0xAEE8F4")]
	private Color <SetColor>b__13_0()
	{
		return default(Color);
	}

	[Token(Token = "0x60009CE")]
	[Address(RVA = "0x15D2178", Offset = "0x15D2178", VA = "0x15D2178")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE904", Offset = "0xAEE904")]
	private void <SetColor>b__13_1(Color x)
	{
	}
}
[Token(Token = "0x2000192")]
public class LocomotionSystem : MonoBehaviour
{
	[Token(Token = "0x400099F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static bool GOD_MODE;

	[Token(Token = "0x40009A0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Rigidbody Rigidbody;

	[Token(Token = "0x40009A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public LayerMask StageMask;

	[Token(Token = "0x40009A2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public LayerMask MeshMask;

	[Token(Token = "0x40009A3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Transform Tracked;

	[Token(Token = "0x40009A4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[HideInInspector]
	public bool TerrainFollowAllowed;

	[Token(Token = "0x40009A5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA954", Offset = "0xAEA954")]
	private bool <TooFarFromStage>k__BackingField;

	[Token(Token = "0x40009A6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA964", Offset = "0xAEA964")]
	private bool <OutsideStage>k__BackingField;

	[Token(Token = "0x40009A7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[HideInInspector]
	public UnityEvent OnTeleported;

	[Token(Token = "0x40009A8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA984", Offset = "0xAEA984")]
	private static bool <Crouching>k__BackingField;

	[Token(Token = "0x40009A9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private bool AboveStage;

	[Token(Token = "0x40009AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Transform CameraTransform;

	[Token(Token = "0x40009AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private bool WaitForMoveThumbstickRelease;

	[Token(Token = "0x40009AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x51")]
	private bool WaitForTurnThumbstickRelease;

	[Token(Token = "0x40009AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x52")]
	private bool WaitForTurnThumbstickReleaseKonami;

	[Token(Token = "0x40009AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	private float CurrentMeshOffset;

	[Token(Token = "0x40009AF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private int CheckGroundCounter;

	[Token(Token = "0x40009B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	private float TraveledDistanceUsingTriggers;

	[Token(Token = "0x40009B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private float TraveledDistanceWithoutUsingTriggers;

	[Token(Token = "0x40009B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
	private float RotationStep;

	[Token(Token = "0x40009B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private float RotationStepTarget;

	[Token(Token = "0x40009B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
	private Vector3 StepPositionTo;

	[Token(Token = "0x40009B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private float FlatFloorPosition;

	[Token(Token = "0x40009B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	private static float LastGodModeTriggerEnterTime;

	[Token(Token = "0x40009B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static float GodModeTriggerCount;

	[Token(Token = "0x17000172")]
	public bool TooFarFromStage
	{
		[Token(Token = "0x60009D8")]
		[Address(RVA = "0xFF50B8", Offset = "0xFF50B8", VA = "0xFF50B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE924", Offset = "0xAEE924")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009D7")]
		[Address(RVA = "0xFF50AC", Offset = "0xFF50AC", VA = "0xFF50AC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE914", Offset = "0xAEE914")]
		private set
		{
		}
	}

	[Token(Token = "0x17000173")]
	public bool OutsideStage
	{
		[Token(Token = "0x60009DA")]
		[Address(RVA = "0xFF50CC", Offset = "0xFF50CC", VA = "0xFF50CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE944", Offset = "0xAEE944")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009D9")]
		[Address(RVA = "0xFF50C0", Offset = "0xFF50C0", VA = "0xFF50C0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE934", Offset = "0xAEE934")]
		private set
		{
		}
	}

	[Token(Token = "0x17000174")]
	private static float CrouchingOffset
	{
		[Token(Token = "0x60009DB")]
		[Address(RVA = "0xFF50D4", Offset = "0xFF50D4", VA = "0xFF50D4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000175")]
	private static float SittingModeOffset
	{
		[Token(Token = "0x60009DC")]
		[Address(RVA = "0xFF5184", Offset = "0xFF5184", VA = "0xFF5184")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000176")]
	private static bool Crouching
	{
		[Token(Token = "0x60009DD")]
		[Address(RVA = "0xFF51F8", Offset = "0xFF51F8", VA = "0xFF51F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE954", Offset = "0xAEE954")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xFF525C", Offset = "0xFF525C", VA = "0xFF525C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE964", Offset = "0xAEE964")]
		set
		{
		}
	}

	[Token(Token = "0x17000177")]
	private static float JoysticksDeadzone
	{
		[Token(Token = "0x60009EB")]
		[Address(RVA = "0xFF6510", Offset = "0xFF6510", VA = "0xFF6510")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60009DF")]
	[Address(RVA = "0xFF52C8", Offset = "0xFF52C8", VA = "0xFF52C8")]
	private void Start()
	{
	}

	[Token(Token = "0x60009E0")]
	[Address(RVA = "0xFF5320", Offset = "0xFF5320", VA = "0xFF5320")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0xFF5408", Offset = "0xFF5408", VA = "0xFF5408")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0xFF6F80", Offset = "0xFF6F80", VA = "0xFF6F80")]
	private void Update()
	{
	}

	[Token(Token = "0x60009E3")]
	[Address(RVA = "0xFF7778", Offset = "0xFF7778", VA = "0xFF7778")]
	public void MatchTransform(Transform transformTo, bool keepCurrentOrientation = false)
	{
	}

	[Token(Token = "0x60009E4")]
	[Address(RVA = "0xFF7B40", Offset = "0xFF7B40", VA = "0xFF7B40")]
	public static void ToggleCrouch()
	{
	}

	[Token(Token = "0x60009E5")]
	[Address(RVA = "0xFF7C28", Offset = "0xFF7C28", VA = "0xFF7C28")]
	public void Stand()
	{
	}

	[Token(Token = "0x60009E6")]
	[Address(RVA = "0xFF6584", Offset = "0xFF6584", VA = "0xFF6584")]
	private Vector3 CheckGround(Vector3 direction, bool smoothMode = true)
	{
		return default(Vector3);
	}

	[Token(Token = "0x60009E7")]
	[Address(RVA = "0xFF6BC0", Offset = "0xFF6BC0", VA = "0xFF6BC0")]
	private void MoveToTerrainHeight()
	{
	}

	[Token(Token = "0x60009E8")]
	[Address(RVA = "0xFF7994", Offset = "0xFF7994", VA = "0xFF7994")]
	private void MatchDirection(Transform PlayerPosition)
	{
	}

	[Token(Token = "0x60009E9")]
	[Address(RVA = "0xFF6D1C", Offset = "0xFF6D1C", VA = "0xFF6D1C")]
	private void FindJoystickSmoothTraveledDistances()
	{
	}

	[Token(Token = "0x60009EA")]
	[Address(RVA = "0xFF6D00", Offset = "0xFF6D00", VA = "0xFF6D00")]
	private void OnTeleport()
	{
	}

	[Token(Token = "0x60009EC")]
	[Address(RVA = "0xFF7E20", Offset = "0xFF7E20", VA = "0xFF7E20")]
	public static void OnGodModeButtonPress()
	{
	}

	[Token(Token = "0x60009ED")]
	[Address(RVA = "0xFF8080", Offset = "0xFF8080", VA = "0xFF8080")]
	public LocomotionSystem()
	{
	}
}
[Token(Token = "0x2000193")]
public abstract class PointableObject : MonoBehaviour
{
	[Token(Token = "0x40009B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[HideInInspector]
	public bool Interactable;

	[Token(Token = "0x40009B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Transform PointableLineTarget;

	[Token(Token = "0x60009EF")]
	public abstract void PointerEnter();

	[Token(Token = "0x60009F0")]
	public abstract void PointerExit();

	[Token(Token = "0x60009F1")]
	public abstract void PointerClick();

	[Token(Token = "0x60009F2")]
	[Address(RVA = "0x108C91C", Offset = "0x108C91C", VA = "0x108C91C")]
	protected PointableObject()
	{
	}
}
[Token(Token = "0x2000194")]
public class PointableRaycaster : MonoBehaviour
{
	[Token(Token = "0x40009BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public float DistanceMax;

	[Token(Token = "0x40009BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public LayerMask InteractableLayerMask;

	[Token(Token = "0x40009BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private PointableObject ActiveInteractableObject;

	[Token(Token = "0x40009BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA9B4", Offset = "0xAEA9B4")]
	private Transform <CameraTransform>k__BackingField;

	[Token(Token = "0x40009BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA9C4", Offset = "0xAEA9C4")]
	private Transform <RaycastingOrigin>k__BackingField;

	[Token(Token = "0x40009BF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEA9D4", Offset = "0xAEA9D4")]
	private bool <IsInteracting>k__BackingField;

	[Token(Token = "0x40009C0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	private int RaycastCheckCount;

	[Token(Token = "0x17000178")]
	public Transform CameraTransform
	{
		[Token(Token = "0x60009F4")]
		[Address(RVA = "0x108C934", Offset = "0x108C934", VA = "0x108C934")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE984", Offset = "0xAEE984")]
		private get
		{
			return null;
		}
		[Token(Token = "0x60009F3")]
		[Address(RVA = "0x108C92C", Offset = "0x108C92C", VA = "0x108C92C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE974", Offset = "0xAEE974")]
		set
		{
		}
	}

	[Token(Token = "0x17000179")]
	public Transform RaycastingOrigin
	{
		[Token(Token = "0x60009F6")]
		[Address(RVA = "0x108C944", Offset = "0x108C944", VA = "0x108C944")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE9A4", Offset = "0xAEE9A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60009F5")]
		[Address(RVA = "0x108C93C", Offset = "0x108C93C", VA = "0x108C93C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE994", Offset = "0xAEE994")]
		set
		{
		}
	}

	[Token(Token = "0x1700017A")]
	private bool IsInteracting
	{
		[Token(Token = "0x60009F7")]
		[Address(RVA = "0x108C94C", Offset = "0x108C94C", VA = "0x108C94C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE9B4", Offset = "0xAEE9B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60009F8")]
		[Address(RVA = "0x108C954", Offset = "0x108C954", VA = "0x108C954")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE9C4", Offset = "0xAEE9C4")]
		set
		{
		}
	}

	[Token(Token = "0x1700017B")]
	private bool CameraAndPointerAboutSameDirection
	{
		[Token(Token = "0x60009FC")]
		[Address(RVA = "0x108CF00", Offset = "0x108CF00", VA = "0x108CF00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60009F9")]
	[Address(RVA = "0x108C960", Offset = "0x108C960", VA = "0x108C960")]
	private void Update()
	{
	}

	[Token(Token = "0x60009FA")]
	[Address(RVA = "0x108CE5C", Offset = "0x108CE5C", VA = "0x108CE5C")]
	public void OnTriggerPress()
	{
	}

	[Token(Token = "0x60009FB")]
	[Address(RVA = "0x108CAB8", Offset = "0x108CAB8", VA = "0x108CAB8")]
	private void Raycast()
	{
	}

	[Token(Token = "0x60009FD")]
	[Address(RVA = "0x108CF7C", Offset = "0x108CF7C", VA = "0x108CF7C")]
	public PointableRaycaster()
	{
	}
}
[Token(Token = "0x2000195")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE4B44", Offset = "0xAE4B44")]
public class PointableUIButton : PointableObject
{
	[Token(Token = "0x40009C1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Sprite TextureOn;

	[Token(Token = "0x40009C2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Sprite TextureOff;

	[Token(Token = "0x40009C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	protected Button Button;

	[Token(Token = "0x40009C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected bool IsOver;

	[Token(Token = "0x60009FE")]
	[Address(RVA = "0x108CF8C", Offset = "0x108CF8C", VA = "0x108CF8C", Slot = "7")]
	public virtual void Start()
	{
	}

	[Token(Token = "0x60009FF")]
	[Address(RVA = "0x108CFEC", Offset = "0x108CFEC", VA = "0x108CFEC", Slot = "4")]
	public override void PointerEnter()
	{
	}

	[Token(Token = "0x6000A00")]
	[Address(RVA = "0x108D150", Offset = "0x108D150", VA = "0x108D150", Slot = "5")]
	public override void PointerExit()
	{
	}

	[Token(Token = "0x6000A01")]
	[Address(RVA = "0x108D2B0", Offset = "0x108D2B0", VA = "0x108D2B0", Slot = "6")]
	public override void PointerClick()
	{
	}

	[Token(Token = "0x6000A02")]
	[Address(RVA = "0x108D3FC", Offset = "0x108D3FC", VA = "0x108D3FC", Slot = "8")]
	protected virtual void UpdateTexture()
	{
	}

	[Token(Token = "0x6000A03")]
	[Address(RVA = "0x108D4B0", Offset = "0x108D4B0", VA = "0x108D4B0")]
	public PointableUIButton()
	{
	}
}
[Token(Token = "0x2000196")]
[ExecuteInEditMode]
public class PointableUIToggle : PointableUIButton
{
	[Token(Token = "0x40009C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public Sprite TextureOnOver;

	[Token(Token = "0x40009C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Sprite TextureOffOver;

	[Token(Token = "0x40009C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public bool IsOn;

	[Token(Token = "0x40009C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x59")]
	private bool _IsOn;

	[Token(Token = "0x6000A04")]
	[Address(RVA = "0x108D4C0", Offset = "0x108D4C0", VA = "0x108D4C0", Slot = "7")]
	public override void Start()
	{
	}

	[Token(Token = "0x6000A05")]
	[Address(RVA = "0x108D4E8", Offset = "0x108D4E8", VA = "0x108D4E8")]
	public void Update()
	{
	}

	[Token(Token = "0x6000A06")]
	[Address(RVA = "0x108D51C", Offset = "0x108D51C", VA = "0x108D51C", Slot = "6")]
	public override void PointerClick()
	{
	}

	[Token(Token = "0x6000A07")]
	[Address(RVA = "0x108D554", Offset = "0x108D554", VA = "0x108D554", Slot = "8")]
	protected override void UpdateTexture()
	{
	}

	[Token(Token = "0x6000A08")]
	[Address(RVA = "0x108D624", Offset = "0x108D624", VA = "0x108D624")]
	public PointableUIToggle()
	{
	}
}
[Token(Token = "0x2000197")]
public class ReticlePointer : MonoBehaviour
{
	[Token(Token = "0x40009C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public MeshRenderer Crosshair;

	[Token(Token = "0x6000A09")]
	[Address(RVA = "0x138C4A0", Offset = "0x138C4A0", VA = "0x138C4A0")]
	public void SetVisibility(bool value)
	{
	}

	[Token(Token = "0x6000A0A")]
	[Address(RVA = "0x138C4D4", Offset = "0x138C4D4", VA = "0x138C4D4")]
	public void FullOpacity(bool v)
	{
	}

	[Token(Token = "0x6000A0B")]
	[Address(RVA = "0x138C570", Offset = "0x138C570", VA = "0x138C570")]
	public ReticlePointer()
	{
	}
}
[Token(Token = "0x2000198")]
public class SphereColliderStatus : MonoBehaviour
{
	[Token(Token = "0x40009CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public SphereCollider Collider;

	[Token(Token = "0x40009CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal bool Colliding;

	[Token(Token = "0x40009CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal float DefaultRadius;

	[Token(Token = "0x6000A0C")]
	[Address(RVA = "0x138EA10", Offset = "0x138EA10", VA = "0x138EA10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000A0D")]
	[Address(RVA = "0x138EA44", Offset = "0x138EA44", VA = "0x138EA44")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6000A0E")]
	[Address(RVA = "0x138EA7C", Offset = "0x138EA7C", VA = "0x138EA7C")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000A0F")]
	[Address(RVA = "0x138EAA4", Offset = "0x138EAA4", VA = "0x138EAA4")]
	public SphereColliderStatus()
	{
	}
}
[Serializable]
[Token(Token = "0x2000199")]
public class BoolEvent : UnityEvent<bool>
{
	[Token(Token = "0x6000A10")]
	[Address(RVA = "0x11967B0", Offset = "0x11967B0", VA = "0x11967B0")]
	public BoolEvent()
	{
	}
}
[Token(Token = "0x200019A")]
public class VRInput : MonoBehaviour
{
	[Token(Token = "0x40009CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private XRNode XRNode;

	[Token(Token = "0x40009CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private XRBindingState[] bindingsState;

	[Token(Token = "0x40009CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private XRBindingValue[] bindingsValue;

	[Token(Token = "0x1700017C")]
	public static InputDevice LeftController
	{
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0xE38D6C", Offset = "0xE38D6C", VA = "0xE38D6C")]
		get
		{
			return default(InputDevice);
		}
	}

	[Token(Token = "0x1700017D")]
	public static InputDevice RightController
	{
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0xE38D78", Offset = "0xE38D78", VA = "0xE38D78")]
		get
		{
			return default(InputDevice);
		}
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0xE38D84", Offset = "0xE38D84", VA = "0xE38D84")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0xE38FD8", Offset = "0xE38FD8", VA = "0xE38FD8")]
	public static Vector2 GetJoystick()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A15")]
	[Address(RVA = "0xE3901C", Offset = "0xE3901C", VA = "0xE3901C")]
	public static Vector2 GetJoystick(XRNode node)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A16")]
	[Address(RVA = "0xE390B8", Offset = "0xE390B8", VA = "0xE390B8")]
	public static Vector2 GetJoystick(XRNode node, float deadZone)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6000A17")]
	[Address(RVA = "0xE3913C", Offset = "0xE3913C", VA = "0xE3913C")]
	public static float GetTrigger(XRNode node)
	{
		return default(float);
	}

	[Token(Token = "0x6000A18")]
	[Address(RVA = "0xE391D8", Offset = "0xE391D8", VA = "0xE391D8")]
	public static float GetBothTriggers()
	{
		return default(float);
	}

	[Token(Token = "0x6000A19")]
	[Address(RVA = "0xE39210", Offset = "0xE39210", VA = "0xE39210")]
	public static bool GetPrimaryButton(XRNode node)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1A")]
	[Address(RVA = "0xE392AC", Offset = "0xE392AC", VA = "0xE392AC")]
	public static bool GetSecondaryButton(XRNode node)
	{
		return default(bool);
	}

	[Token(Token = "0x6000A1B")]
	[Address(RVA = "0xE39348", Offset = "0xE39348", VA = "0xE39348")]
	public VRInput()
	{
	}
}
[Serializable]
[Token(Token = "0x200019B")]
public class XRBindingState
{
	[Token(Token = "0x40009D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private XRButtonState button;

	[Token(Token = "0x40009D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	[SerializeField]
	private StateType condition;

	[Token(Token = "0x40009D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRInputBindingStateEvent OnActive;

	[Token(Token = "0x40009D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private bool wasPressed;

	[Token(Token = "0x6000A1C")]
	[Address(RVA = "0xE38E78", Offset = "0xE38E78", VA = "0xE38E78")]
	public void Update(InputDevice device)
	{
	}

	[Token(Token = "0x6000A1D")]
	[Address(RVA = "0xE3E2F0", Offset = "0xE3E2F0", VA = "0xE3E2F0")]
	public XRBindingState()
	{
	}
}
[Serializable]
[Token(Token = "0x200019C")]
public class XRBindingValue
{
	[Token(Token = "0x40009D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	[SerializeField]
	private XRButton1D button;

	[Token(Token = "0x40009D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private VRInputBindingValueEvent XRBindingEvent;

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0xE38F50", Offset = "0xE38F50", VA = "0xE38F50")]
	public void Update(InputDevice device)
	{
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0xE3E45C", Offset = "0xE3E45C", VA = "0xE3E45C")]
	public XRBindingValue()
	{
	}
}
[Token(Token = "0x200019D")]
public static class XRStatics
{
	[Token(Token = "0x6000A20")]
	[Address(RVA = "0xE3DFF0", Offset = "0xE3DFF0", VA = "0xE3DFF0")]
	public static InputFeatureUsage<bool> GetFeature(XRButtonState button)
	{
		return default(InputFeatureUsage<bool>);
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0xE3E2F8", Offset = "0xE3E2F8", VA = "0xE3E2F8")]
	public static InputFeatureUsage<float> GetFeatureValue(XRButton1D button)
	{
		return default(InputFeatureUsage<float>);
	}
}
[Token(Token = "0x200019E")]
public enum StateType
{
	[Token(Token = "0x40009D7")]
	Begin,
	[Token(Token = "0x40009D8")]
	End,
	[Token(Token = "0x40009D9")]
	Continuous
}
[Token(Token = "0x200019F")]
public enum XRButtonState
{
	[Token(Token = "0x40009DB")]
	Trigger,
	[Token(Token = "0x40009DC")]
	Grip,
	[Token(Token = "0x40009DD")]
	Primary,
	[Token(Token = "0x40009DE")]
	PrimaryTouch,
	[Token(Token = "0x40009DF")]
	Secondary,
	[Token(Token = "0x40009E0")]
	SecondaryTouch,
	[Token(Token = "0x40009E1")]
	Primary2DAxisClick,
	[Token(Token = "0x40009E2")]
	Primary2DAxisTouch,
	[Token(Token = "0x40009E3")]
	Thumbrest,
	[Token(Token = "0x40009E4")]
	Menu
}
[Token(Token = "0x20001A0")]
public enum XRButton1D
{
	[Token(Token = "0x40009E6")]
	GripValue,
	[Token(Token = "0x40009E7")]
	TriggerValue
}
[Serializable]
[Token(Token = "0x20001A1")]
public class VRInputBindingStateEvent : UnityEvent<InputDevice>
{
	[Token(Token = "0x6000A22")]
	[Address(RVA = "0xE39358", Offset = "0xE39358", VA = "0xE39358")]
	public VRInputBindingStateEvent()
	{
	}
}
[Serializable]
[Token(Token = "0x20001A2")]
public class VRInputBindingValueEvent : UnityEvent<float>
{
	[Token(Token = "0x6000A23")]
	[Address(RVA = "0xE393A4", Offset = "0xE393A4", VA = "0xE393A4")]
	public VRInputBindingValueEvent()
	{
	}
}
[Token(Token = "0x20001A3")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0xAE4BB4", Offset = "0xAE4BB4")]
public class VRRig : MonoBehaviour
{
	[Token(Token = "0x40009E8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public VRInput LeftVRInput;

	[Token(Token = "0x40009E9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public VRInput RightVRInput;

	[Token(Token = "0x40009EA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private LocomotionSystem LocomotionSystem;

	[Token(Token = "0x40009EB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private CameraCollisionManager CameraCollisionManager;

	[Token(Token = "0x40009EC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private CameraFadeOverlay CameraFadeOverlay;

	[Token(Token = "0x40009ED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private PointableRaycaster PointableRaycaster;

	[Token(Token = "0x40009EE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA64", Offset = "0xAEAA64")]
	private bool <MovementAllowed>k__BackingField;

	[Token(Token = "0x1700017E")]
	public bool AllowControllerInputs
	{
		[Token(Token = "0x6000A24")]
		[Address(RVA = "0xE3A54C", Offset = "0xE3A54C", VA = "0xE3A54C")]
		set
		{
		}
	}

	[Token(Token = "0x1700017F")]
	public bool AllowCameraCollisionDetection
	{
		[Token(Token = "0x6000A25")]
		[Address(RVA = "0xE3A598", Offset = "0xE3A598", VA = "0xE3A598")]
		set
		{
		}
	}

	[Token(Token = "0x17000180")]
	public bool AllowInteractingWithPointableObject
	{
		[Token(Token = "0x6000A26")]
		[Address(RVA = "0xE3A5B8", Offset = "0xE3A5B8", VA = "0xE3A5B8")]
		set
		{
		}
	}

	[Token(Token = "0x17000181")]
	public Transform CameraTransform
	{
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0xE3A5D8", Offset = "0xE3A5D8", VA = "0xE3A5D8")]
		set
		{
		}
	}

	[Token(Token = "0x17000182")]
	public bool MovementAllowed
	{
		[Token(Token = "0x6000A28")]
		[Address(RVA = "0xE3A5F4", Offset = "0xE3A5F4", VA = "0xE3A5F4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE9D4", Offset = "0xAEE9D4")]
		private get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A29")]
		[Address(RVA = "0xE3A5FC", Offset = "0xE3A5FC", VA = "0xE3A5FC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEE9E4", Offset = "0xAEE9E4")]
		set
		{
		}
	}

	[Token(Token = "0x17000183")]
	public bool IsCollidingWithMesh
	{
		[Token(Token = "0x6000A2A")]
		[Address(RVA = "0xE3A608", Offset = "0xE3A608", VA = "0xE3A608")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000184")]
	public bool IsCloseToCollideWithMesh
	{
		[Token(Token = "0x6000A2B")]
		[Address(RVA = "0xE3A658", Offset = "0xE3A658", VA = "0xE3A658")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000185")]
	public bool CameraFadeOverlayVisible
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0xE3A6A8", Offset = "0xE3A6A8", VA = "0xE3A6A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000186")]
	public bool TooFarFromStage
	{
		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0xE3A6C4", Offset = "0xE3A6C4", VA = "0xE3A6C4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000187")]
	public bool CantGoAnyFurther
	{
		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0xE3A6E0", Offset = "0xE3A6E0", VA = "0xE3A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000188")]
	public bool TerrainFollowAllowed
	{
		[Token(Token = "0x6000A2F")]
		[Address(RVA = "0xE3A6FC", Offset = "0xE3A6FC", VA = "0xE3A6FC")]
		set
		{
		}
	}

	[Token(Token = "0x17000189")]
	public UnityEvent OnRigTeleported
	{
		[Token(Token = "0x6000A30")]
		[Address(RVA = "0xE3A71C", Offset = "0xE3A71C", VA = "0xE3A71C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018A")]
	public Transform TrackedTransform
	{
		[Token(Token = "0x6000A31")]
		[Address(RVA = "0xE3A738", Offset = "0xE3A738", VA = "0xE3A738")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700018B")]
	public Transform PointingTransform
	{
		[Token(Token = "0x6000A32")]
		[Address(RVA = "0xE3A754", Offset = "0xE3A754", VA = "0xE3A754")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A33")]
		[Address(RVA = "0xE3A770", Offset = "0xE3A770", VA = "0xE3A770")]
		set
		{
		}
	}

	[Token(Token = "0x6000A34")]
	[Address(RVA = "0xE3A78C", Offset = "0xE3A78C", VA = "0xE3A78C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A35")]
	[Address(RVA = "0xE3AA24", Offset = "0xE3AA24", VA = "0xE3AA24")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6000A36")]
	[Address(RVA = "0xE3AB08", Offset = "0xE3AB08", VA = "0xE3AB08")]
	public void MatchTransform(Transform PlayerPosition, bool keepCurrentOrientation = false)
	{
	}

	[Token(Token = "0x6000A37")]
	[Address(RVA = "0xE3ABB0", Offset = "0xE3ABB0", VA = "0xE3ABB0")]
	public void ShowScreenFade(float time, float delay = 0f, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6000A38")]
	[Address(RVA = "0xE3ABCC", Offset = "0xE3ABCC", VA = "0xE3ABCC")]
	public void HideScreenFade(float time, float delay = 0f, [Optional] Action onComplete, Ease ease = Ease.Linear)
	{
	}

	[Token(Token = "0x6000A39")]
	[Address(RVA = "0xE3ABEC", Offset = "0xE3ABEC", VA = "0xE3ABEC")]
	public void SetScreenFadeColor(Color color, float duration = 0f)
	{
	}

	[Token(Token = "0x6000A3A")]
	[Address(RVA = "0xE3AC08", Offset = "0xE3AC08", VA = "0xE3AC08")]
	public void OnTriggerPress()
	{
	}

	[Token(Token = "0x6000A3B")]
	[Address(RVA = "0xE3AC24", Offset = "0xE3AC24", VA = "0xE3AC24")]
	public void Stand()
	{
	}

	[Token(Token = "0x6000A3C")]
	[Address(RVA = "0xE3AC40", Offset = "0xE3AC40", VA = "0xE3AC40")]
	public void ToggleCrouch()
	{
	}

	[Token(Token = "0x6000A3D")]
	[Address(RVA = "0xE3AC9C", Offset = "0xE3AC9C", VA = "0xE3AC9C")]
	public VRRig()
	{
	}
}
[Token(Token = "0x20001A4")]
public class VRSystemInfo : MonoBehaviour
{
	[Token(Token = "0x20001A5")]
	public enum VRSystems
	{
		[Token(Token = "0x40009F1")]
		UNKNOWN,
		[Token(Token = "0x40009F2")]
		Rift,
		[Token(Token = "0x40009F3")]
		RiftS,
		[Token(Token = "0x40009F4")]
		Quest1,
		[Token(Token = "0x40009F5")]
		Quest2,
		[Token(Token = "0x40009F6")]
		QuestLink,
		[Token(Token = "0x40009F7")]
		GenericSteamVR
	}

	[Token(Token = "0x40009EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static VRSystems _ActiveSystem;

	[Token(Token = "0x1700018C")]
	public static VRSystems ActiveSystem
	{
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0xE3ACA4", Offset = "0xE3ACA4", VA = "0xE3ACA4")]
		get
		{
			return default(VRSystems);
		}
	}

	[Token(Token = "0x1700018D")]
	public static bool IsQuest1
	{
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0xE3AF7C", Offset = "0xE3AF7C", VA = "0xE3AF7C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000A40")]
	[Address(RVA = "0xE3AFE0", Offset = "0xE3AFE0", VA = "0xE3AFE0")]
	public VRSystemInfo()
	{
	}
}
[Token(Token = "0x20001A6")]
public static class VRPlatform
{
	[Token(Token = "0x20001A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4BC8", Offset = "0xAE4BC8")]
	private sealed class <>c__DisplayClass4_0
	{
		[Token(Token = "0x40009FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool, AssetFileItemData[], string> callback;

		[Token(Token = "0x6000A54")]
		[Address(RVA = "0x167AEC4", Offset = "0x167AEC4", VA = "0x167AEC4")]
		public <>c__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6000A55")]
		[Address(RVA = "0x167AECC", Offset = "0x167AECC", VA = "0x167AECC")]
		internal void <DLC_GetDownloadableAssetsList>b__0()
		{
		}
	}

	[Token(Token = "0x20001A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4BD8", Offset = "0xAE4BD8")]
	private sealed class <>c__DisplayClass5_0
	{
		[Token(Token = "0x40009FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public AssetFileItemData item;

		[Token(Token = "0x40009FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, AssetFileItemData, string> callback;

		[Token(Token = "0x6000A56")]
		[Address(RVA = "0x167AF04", Offset = "0x167AF04", VA = "0x167AF04")]
		public <>c__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000A57")]
		[Address(RVA = "0x167AF0C", Offset = "0x167AF0C", VA = "0x167AF0C")]
		internal void <DLC_Download>b__0()
		{
		}
	}

	[Token(Token = "0x20001A9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4BE8", Offset = "0xAE4BE8")]
	private sealed class <>c__DisplayClass6_0
	{
		[Token(Token = "0x40009FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool, string, string[]> callback;

		[Token(Token = "0x6000A58")]
		[Address(RVA = "0x167AF44", Offset = "0x167AF44", VA = "0x167AF44")]
		public <>c__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6000A59")]
		[Address(RVA = "0x167AF4C", Offset = "0x167AF4C", VA = "0x167AF4C")]
		internal void <IAP_GetOwnedProducts>b__0()
		{
		}
	}

	[Token(Token = "0x20001AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4BF8", Offset = "0xAE4BF8")]
	private sealed class <>c__DisplayClass7_0
	{
		[Token(Token = "0x40009FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool, string, Dictionary<string, string>> callback;

		[Token(Token = "0x6000A5A")]
		[Address(RVA = "0x167AFC4", Offset = "0x167AFC4", VA = "0x167AFC4")]
		public <>c__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6000A5B")]
		[Address(RVA = "0x167AFCC", Offset = "0x167AFCC", VA = "0x167AFCC")]
		internal void <IAP_GetPrices>b__0()
		{
		}
	}

	[Token(Token = "0x20001AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C08", Offset = "0xAE4C08")]
	private sealed class <>c__DisplayClass8_0
	{
		[Token(Token = "0x4000A00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sku;

		[Token(Token = "0x4000A01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, string, string> callback;

		[Token(Token = "0x6000A5C")]
		[Address(RVA = "0x167B044", Offset = "0x167B044", VA = "0x167B044")]
		public <>c__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000A5D")]
		[Address(RVA = "0x167B04C", Offset = "0x167B04C", VA = "0x167B04C")]
		internal void <IAP_Purchase>b__0()
		{
		}
	}

	[Token(Token = "0x20001AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C18", Offset = "0xAE4C18")]
	private sealed class <>c__DisplayClass9_0
	{
		[Token(Token = "0x4000A02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string sku;

		[Token(Token = "0x4000A03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, string> callback;

		[Token(Token = "0x6000A5E")]
		[Address(RVA = "0x167B0C4", Offset = "0x167B0C4", VA = "0x167B0C4")]
		public <>c__DisplayClass9_0()
		{
		}

		[Token(Token = "0x6000A5F")]
		[Address(RVA = "0x167B0CC", Offset = "0x167B0CC", VA = "0x167B0CC")]
		internal void <IAP_ConsumePurchase>b__0()
		{
		}
	}

	[Token(Token = "0x20001AD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C28", Offset = "0xAE4C28")]
	private sealed class <>c__DisplayClass10_0
	{
		[Token(Token = "0x4000A04")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000A05")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int limit;

		[Token(Token = "0x4000A06")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback;

		[Token(Token = "0x6000A60")]
		[Address(RVA = "0x167AD74", Offset = "0x167AD74", VA = "0x167AD74")]
		public <>c__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6000A61")]
		[Address(RVA = "0x167AD7C", Offset = "0x167AD7C", VA = "0x167AD7C")]
		internal void <LEADERBOARD_GetTopEntries>b__0()
		{
		}
	}

	[Token(Token = "0x20001AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C38", Offset = "0xAE4C38")]
	private sealed class <>c__DisplayClass11_0
	{
		[Token(Token = "0x4000A07")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000A08")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action<bool, string, LeaderboardItemData> callback;

		[Token(Token = "0x6000A62")]
		[Address(RVA = "0x167ADBC", Offset = "0x167ADBC", VA = "0x167ADBC")]
		public <>c__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6000A63")]
		[Address(RVA = "0x167ADC4", Offset = "0x167ADC4", VA = "0x167ADC4")]
		internal void <LEADERBOARD_GetPlayerLeaderboardEntry>b__0()
		{
		}
	}

	[Token(Token = "0x20001AF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C48", Offset = "0xAE4C48")]
	private sealed class <>c__DisplayClass12_0
	{
		[Token(Token = "0x4000A09")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback;

		[Token(Token = "0x6000A64")]
		[Address(RVA = "0x167ADFC", Offset = "0x167ADFC", VA = "0x167ADFC")]
		public <>c__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6000A65")]
		[Address(RVA = "0x167AE04", Offset = "0x167AE04", VA = "0x167AE04")]
		internal void <LEADERBOARD_GetLeaderboardNext>b__0()
		{
		}
	}

	[Token(Token = "0x20001B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C58", Offset = "0xAE4C58")]
	private sealed class <>c__DisplayClass13_0
	{
		[Token(Token = "0x4000A0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback;

		[Token(Token = "0x6000A66")]
		[Address(RVA = "0x167AE3C", Offset = "0x167AE3C", VA = "0x167AE3C")]
		public <>c__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6000A67")]
		[Address(RVA = "0x167AE44", Offset = "0x167AE44", VA = "0x167AE44")]
		internal void <LEADERBOARD_GetLeaderboardPrevious>b__0()
		{
		}
	}

	[Token(Token = "0x20001B1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4C68", Offset = "0xAE4C68")]
	private sealed class <>c__DisplayClass14_0
	{
		[Token(Token = "0x4000A0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x4000A0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public long score;

		[Token(Token = "0x4000A0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool, string> callback;

		[Token(Token = "0x4000A0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool forceUpdate;

		[Token(Token = "0x6000A68")]
		[Address(RVA = "0x167AE7C", Offset = "0x167AE7C", VA = "0x167AE7C")]
		public <>c__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6000A69")]
		[Address(RVA = "0x167AE84", Offset = "0x167AE84", VA = "0x167AE84")]
		internal void <LEADERBOARD_SetLeaderboardResult>b__0()
		{
		}
	}

	[Token(Token = "0x40009F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static string AppId;

	[Token(Token = "0x40009F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static bool Initialized;

	[Token(Token = "0x40009FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly List<Action> ActionsOnInitializeSuccess;

	[Token(Token = "0x6000A42")]
	[Address(RVA = "0xE393F0", Offset = "0xE393F0", VA = "0xE393F0")]
	public static void Init(string appId)
	{
	}

	[Token(Token = "0x6000A43")]
	[Address(RVA = "0xE3958C", Offset = "0xE3958C", VA = "0xE3958C")]
	public static void DLC_GetDownloadableAssetsList(Action<bool, AssetFileItemData[], string> callback)
	{
	}

	[Token(Token = "0x6000A44")]
	[Address(RVA = "0xE39798", Offset = "0xE39798", VA = "0xE39798")]
	public static void DLC_Download(AssetFileItemData item, Action<bool, AssetFileItemData, string> callback)
	{
	}

	[Token(Token = "0x6000A45")]
	[Address(RVA = "0xE3987C", Offset = "0xE3987C", VA = "0xE3987C")]
	public static void IAP_GetOwnedProducts(Action<bool, string, string[]> callback)
	{
	}

	[Token(Token = "0x6000A46")]
	[Address(RVA = "0xE39954", Offset = "0xE39954", VA = "0xE39954")]
	public static void IAP_GetPrices(Action<bool, string, Dictionary<string, string>> callback)
	{
	}

	[Token(Token = "0x6000A47")]
	[Address(RVA = "0xE39A2C", Offset = "0xE39A2C", VA = "0xE39A2C")]
	public static void IAP_Purchase(string sku, Action<bool, string, string> callback)
	{
	}

	[Token(Token = "0x6000A48")]
	[Address(RVA = "0xE39B10", Offset = "0xE39B10", VA = "0xE39B10")]
	public static void IAP_ConsumePurchase(string sku, Action<bool, string> callback)
	{
	}

	[Token(Token = "0x6000A49")]
	[Address(RVA = "0xE39BF4", Offset = "0xE39BF4", VA = "0xE39BF4")]
	public static void LEADERBOARD_GetTopEntries(string id, int limit, Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0xE39D94", Offset = "0xE39D94", VA = "0xE39D94")]
	public static void LEADERBOARD_GetPlayerLeaderboardEntry(string id, Action<bool, string, LeaderboardItemData> callback)
	{
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0xE39E84", Offset = "0xE39E84", VA = "0xE39E84")]
	public static void LEADERBOARD_GetLeaderboardNext(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0xE39F5C", Offset = "0xE39F5C", VA = "0xE39F5C")]
	public static void LEADERBOARD_GetLeaderboardPrevious(Action<bool, string, SortedDictionary<int, LeaderboardItemData>> callback)
	{
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0xE3A034", Offset = "0xE3A034", VA = "0xE3A034")]
	public static void LEADERBOARD_SetLeaderboardResult(string id, long score, Action<bool, string> callback, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6000A4E")]
	[Address(RVA = "0xE3A140", Offset = "0xE3A140", VA = "0xE3A140")]
	public static long LEADERBOARD_GetUserLeaderboardBestScore(string id)
	{
		return default(long);
	}

	[Token(Token = "0x6000A4F")]
	[Address(RVA = "0xE3A1C0", Offset = "0xE3A1C0", VA = "0xE3A1C0")]
	public static ulong LEADERBOARD_GetLeaderboardEntriesCount(string id)
	{
		return default(ulong);
	}

	[Token(Token = "0x6000A50")]
	[Address(RVA = "0xE39CF0", Offset = "0xE39CF0", VA = "0xE39CF0")]
	private static string GetLeaderboardIdByEnvironment(string id)
	{
		return null;
	}

	[Token(Token = "0x6000A51")]
	[Address(RVA = "0xE39664", Offset = "0xE39664", VA = "0xE39664")]
	private static void ExecuteOrInitializeThenExecute(Action action)
	{
	}

	[Token(Token = "0x6000A52")]
	[Address(RVA = "0xE3A240", Offset = "0xE3A240", VA = "0xE3A240")]
	private static void OnAuthCallback()
	{
	}
}
namespace Autohand.Demo
{
	[Token(Token = "0x20001B2")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE4C78", Offset = "0xAE4C78")]
	public class PhysicsButton : MonoBehaviour
	{
		[Token(Token = "0x4000A0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private SpringJoint spring;

		[Token(Token = "0x4000A10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Vector3 startPos;

		[Token(Token = "0x4000A11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		private bool pressed;

		[Token(Token = "0x4000A12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public float threshHold;

		[Token(Token = "0x4000A13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "SpaceAttribute", RVA = "0xAEAA74", Offset = "0xAEAA74")]
		public UnityEvent OnPressed;

		[Token(Token = "0x4000A14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public UnityEvent OnUnpressed;

		[Token(Token = "0x6000A6A")]
		[Address(RVA = "0x108AC60", Offset = "0x108AC60", VA = "0x108AC60")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x108ACD8", Offset = "0x108ACD8", VA = "0x108ACD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x108AD8C", Offset = "0x108AD8C", VA = "0x108AD8C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x108AE7C", Offset = "0x108AE7C", VA = "0x108AE7C")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x108AE54", Offset = "0x108AE54", VA = "0x108AE54")]
		public void Pressed()
		{
		}

		[Token(Token = "0x6000A6F")]
		[Address(RVA = "0x108AE68", Offset = "0x108AE68", VA = "0x108AE68")]
		public void Unpressed()
		{
		}

		[Token(Token = "0x6000A70")]
		[Address(RVA = "0x108AEF4", Offset = "0x108AEF4", VA = "0x108AEF4")]
		public PhysicsButton()
		{
		}
	}
	[Token(Token = "0x20001B3")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0xAE4CD8", Offset = "0xAE4CD8")]
	public class PhysicsLever : MonoBehaviour
	{
		[Token(Token = "0x4000A15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HingeJoint joint;

		[Token(Token = "0x4000A16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public float buffer;

		[Token(Token = "0x4000A17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public UnityEvent SwitchOn;

		[Token(Token = "0x4000A18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public UnityEvent SwitchOff;

		[Token(Token = "0x4000A19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool on;

		[Token(Token = "0x4000A1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		protected float leverPoint;

		[Token(Token = "0x6000A71")]
		[Address(RVA = "0x108AF08", Offset = "0x108AF08", VA = "0x108AF08")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A72")]
		[Address(RVA = "0x108AF5C", Offset = "0x108AF5C", VA = "0x108AF5C")]
		public void Update()
		{
		}

		[Token(Token = "0x6000A73")]
		[Address(RVA = "0x108B070", Offset = "0x108B070", VA = "0x108B070", Slot = "4")]
		public virtual void OnSwitchOn()
		{
		}

		[Token(Token = "0x6000A74")]
		[Address(RVA = "0x108B084", Offset = "0x108B084", VA = "0x108B084", Slot = "5")]
		public virtual void OnSwitchOff()
		{
		}

		[Token(Token = "0x6000A75")]
		[Address(RVA = "0x108B098", Offset = "0x108B098", VA = "0x108B098")]
		public PhysicsLever()
		{
		}
	}
}
namespace VR.UI
{
	[Token(Token = "0x20001B4")]
	public class MultiplayerMenu : Overlay
	{
		[Token(Token = "0x4000A1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Root;

		[Token(Token = "0x4000A1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PressButton CloseButton;

		[Token(Token = "0x4000A1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MultiplayerMenuConnect ConnectGroup;

		[Token(Token = "0x4000A1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MultiplayerMenuLoading LoadingGroup;

		[Token(Token = "0x4000A1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MultiplayerMenuConnected ConnectedGroup;

		[Token(Token = "0x4000A20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly MenuEvent OnJoinSelected;

		[Token(Token = "0x6000A76")]
		[Address(RVA = "0x10038A0", Offset = "0x10038A0", VA = "0x10038A0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A77")]
		[Address(RVA = "0x10039F0", Offset = "0x10039F0", VA = "0x10039F0")]
		private void OnJoinTravelerButtonSelected(string locationId)
		{
		}

		[Token(Token = "0x6000A78")]
		[Address(RVA = "0x1003A54", Offset = "0x1003A54", VA = "0x1003A54", Slot = "7")]
		protected override void Update()
		{
		}

		[Token(Token = "0x6000A79")]
		[Address(RVA = "0x1003C50", Offset = "0x1003C50", VA = "0x1003C50", Slot = "8")]
		protected override void Open()
		{
		}

		[Token(Token = "0x6000A7A")]
		[Address(RVA = "0x1003CF8", Offset = "0x1003CF8", VA = "0x1003CF8")]
		private void OnClosePress(ButtonBase btn)
		{
		}

		[Token(Token = "0x6000A7B")]
		[Address(RVA = "0x1003D08", Offset = "0x1003D08", VA = "0x1003D08")]
		public MultiplayerMenu()
		{
		}
	}
	[Token(Token = "0x20001B5")]
	public class MultiplayerMenuConnect : MonoBehaviour
	{
		[Token(Token = "0x4000A21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FlatButtonVR ConnectToPublicButton;

		[Token(Token = "0x4000A22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PartyCodeButton PartyCodeButton1;

		[Token(Token = "0x4000A23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PartyCodeButton PartyCodeButton2;

		[Token(Token = "0x4000A24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public PartyCodeButton PartyCodeButton3;

		[Token(Token = "0x4000A25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public PartyCodeButton PartyCodeButton4;

		[Token(Token = "0x4000A26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public FlatButtonVR JoinPrivateButton;

		[Token(Token = "0x4000A27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public FlatButtonVR CreatePrivateButton;

		[Token(Token = "0x1700018E")]
		private string Code
		{
			[Token(Token = "0x6000A82")]
			[Address(RVA = "0x1003FD0", Offset = "0x1003FD0", VA = "0x1003FD0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000A7C")]
		[Address(RVA = "0x1003D94", Offset = "0x1003D94", VA = "0x1003D94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A7D")]
		[Address(RVA = "0x1003F00", Offset = "0x1003F00", VA = "0x1003F00")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000A7E")]
		[Address(RVA = "0x1003F5C", Offset = "0x1003F5C", VA = "0x1003F5C")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A7F")]
		[Address(RVA = "0x1004098", Offset = "0x1004098", VA = "0x1004098")]
		private void OnConnectToPublicButtonPressed(ButtonBase b)
		{
		}

		[Token(Token = "0x6000A80")]
		[Address(RVA = "0x10040F0", Offset = "0x10040F0", VA = "0x10040F0")]
		private void JoinPrivateButtonPressed(ButtonBase arg0)
		{
		}

		[Token(Token = "0x6000A81")]
		[Address(RVA = "0x1004160", Offset = "0x1004160", VA = "0x1004160")]
		private void CreatePrivateButtonPressed(ButtonBase arg0)
		{
		}

		[Token(Token = "0x6000A83")]
		[Address(RVA = "0x10041BC", Offset = "0x10041BC", VA = "0x10041BC")]
		public MultiplayerMenuConnect()
		{
		}
	}
	[Token(Token = "0x20001B6")]
	public class MultiplayerMenuConnected : MonoBehaviour
	{
		[Token(Token = "0x4000A28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TextMeshPro Title;

		[Token(Token = "0x4000A29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshPro Subtitle;

		[Token(Token = "0x4000A2A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MeshRenderer BgRenderer;

		[Token(Token = "0x4000A2B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FlatButtonVR LeaveRoomButton;

		[Token(Token = "0x4000A2C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TextMeshPro CurrentRoomCodeField;

		[Token(Token = "0x4000A2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TravelerUI[] Travelers;

		[Token(Token = "0x4000A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly MenuEvent OnJoinTravelerSelected;

		[Token(Token = "0x4000A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private int UpdateCounter;

		[Token(Token = "0x4000A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int CONNECTED_COUNT;

		[Token(Token = "0x6000A84")]
		[Address(RVA = "0x10041C4", Offset = "0x10041C4", VA = "0x10041C4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000A85")]
		[Address(RVA = "0x100436C", Offset = "0x100436C", VA = "0x100436C")]
		public void OnEnable()
		{
		}

		[Token(Token = "0x6000A86")]
		[Address(RVA = "0x1004930", Offset = "0x1004930", VA = "0x1004930")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A87")]
		[Address(RVA = "0x10045C8", Offset = "0x10045C8", VA = "0x10045C8")]
		private void UpdateContent()
		{
		}

		[Token(Token = "0x6000A88")]
		[Address(RVA = "0x1004454", Offset = "0x1004454", VA = "0x1004454")]
		private void PopulateRoomCode()
		{
		}

		[Token(Token = "0x6000A89")]
		[Address(RVA = "0x1004950", Offset = "0x1004950", VA = "0x1004950")]
		private void OnLeaveRoomButtonPressed(ButtonBase b)
		{
		}

		[Token(Token = "0x6000A8A")]
		[Address(RVA = "0x10049A8", Offset = "0x10049A8", VA = "0x10049A8")]
		private void OnJoinTravelerButtonSelected(string locationId)
		{
		}

		[Token(Token = "0x6000A8B")]
		[Address(RVA = "0x1004A0C", Offset = "0x1004A0C", VA = "0x1004A0C")]
		public MultiplayerMenuConnected()
		{
		}
	}
	[Token(Token = "0x20001B7")]
	public class MultiplayerMenuLoading : MonoBehaviour
	{
		[Token(Token = "0x4000A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Transform Rotator;

		[Token(Token = "0x6000A8D")]
		[Address(RVA = "0x1004AD8", Offset = "0x1004AD8", VA = "0x1004AD8")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A8E")]
		[Address(RVA = "0x1004B54", Offset = "0x1004B54", VA = "0x1004B54")]
		public MultiplayerMenuLoading()
		{
		}
	}
	[Token(Token = "0x20001B8")]
	public class WatchButton : ButtonBase
	{
		[Token(Token = "0x4000A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static WatchButton PressedButton;

		[Token(Token = "0x4000A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static float LastWatchButtonPressTime;

		[Token(Token = "0x4000A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public MeshRenderer Renderer;

		[Token(Token = "0x4000A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private static readonly int COLOR;

		[Token(Token = "0x6000A8F")]
		[Address(RVA = "0xE3BC88", Offset = "0xE3BC88", VA = "0xE3BC88")]
		private void Update()
		{
		}

		[Token(Token = "0x6000A90")]
		[Address(RVA = "0xE3BEB8", Offset = "0xE3BEB8", VA = "0xE3BEB8")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x6000A91")]
		[Address(RVA = "0xE3C0FC", Offset = "0xE3C0FC", VA = "0xE3C0FC")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6000A92")]
		[Address(RVA = "0xE3C1DC", Offset = "0xE3C1DC", VA = "0xE3C1DC")]
		public WatchButton()
		{
		}
	}
}
namespace VR.Hand
{
	[Token(Token = "0x20001B9")]
	[ExecuteAlways]
	public class BrinkHandBonesGui : MonoBehaviour
	{
		[Token(Token = "0x4000A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Color color;

		[Token(Token = "0x4000A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool drawAxes;

		[Token(Token = "0x4000A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public float axisSize;

		[Token(Token = "0x6000A94")]
		[Address(RVA = "0x1198038", Offset = "0x1198038", VA = "0x1198038")]
		public BrinkHandBonesGui()
		{
		}
	}
}
namespace SimpleJSON
{
	[Token(Token = "0x20001BA")]
	public enum JSONNodeType
	{
		[Token(Token = "0x4000A3A")]
		Array = 1,
		[Token(Token = "0x4000A3B")]
		Object = 2,
		[Token(Token = "0x4000A3C")]
		String = 3,
		[Token(Token = "0x4000A3D")]
		Number = 4,
		[Token(Token = "0x4000A3E")]
		NullValue = 5,
		[Token(Token = "0x4000A3F")]
		Boolean = 6,
		[Token(Token = "0x4000A40")]
		None = 7,
		[Token(Token = "0x4000A41")]
		Custom = 255
	}
	[Token(Token = "0x20001BB")]
	public enum JSONTextMode
	{
		[Token(Token = "0x4000A43")]
		Compact,
		[Token(Token = "0x4000A44")]
		Indent
	}
	[Token(Token = "0x20001BC")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xAE4D48", Offset = "0xAE4D48")]
	public abstract class JSONNode
	{
		[Token(Token = "0x20001BD")]
		public struct Enumerator
		{
			[Token(Token = "0x20001BE")]
			private enum Type
			{
				[Token(Token = "0x4000A50")]
				None,
				[Token(Token = "0x4000A51")]
				Array,
				[Token(Token = "0x4000A52")]
				Object
			}

			[Token(Token = "0x4000A4C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Type type;

			[Token(Token = "0x4000A4D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private Dictionary<string, JSONNode>.Enumerator m_Object;

			[Token(Token = "0x4000A4E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator m_Array;

			[Token(Token = "0x170001A8")]
			public bool IsValid
			{
				[Token(Token = "0x6000AFB")]
				[Address(RVA = "0xE43FB0", Offset = "0xE43FB0", VA = "0xE43FB0")]
				get
				{
					return default(bool);
				}
			}

			[Token(Token = "0x170001A9")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000AFE")]
				[Address(RVA = "0xE4400C", Offset = "0xE4400C", VA = "0xE4400C")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x6000AFC")]
			[Address(RVA = "0xE43FC0", Offset = "0xE43FC0", VA = "0xE43FC0")]
			public Enumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000AFD")]
			[Address(RVA = "0xE43FE8", Offset = "0xE43FE8", VA = "0xE43FE8")]
			public Enumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000AFF")]
			[Address(RVA = "0xE440E0", Offset = "0xE440E0", VA = "0xE440E0")]
			public bool MoveNext()
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001BF")]
		public struct ValueEnumerator
		{
			[Token(Token = "0x4000A53")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x170001AA")]
			public JSONNode Current
			{
				[Token(Token = "0x6000B03")]
				[Address(RVA = "0xE4460C", Offset = "0xE4460C", VA = "0xE4460C")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B00")]
			[Address(RVA = "0xE44560", Offset = "0xE44560", VA = "0xE44560")]
			public ValueEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000B01")]
			[Address(RVA = "0xE445A8", Offset = "0xE445A8", VA = "0xE445A8")]
			public ValueEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000B02")]
			[Address(RVA = "0xE445F4", Offset = "0xE445F4", VA = "0xE445F4")]
			public ValueEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000B04")]
			[Address(RVA = "0xE44654", Offset = "0xE44654", VA = "0xE44654")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B05")]
			[Address(RVA = "0xE44658", Offset = "0xE44658", VA = "0xE44658")]
			public ValueEnumerator GetEnumerator()
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x20001C0")]
		public struct KeyEnumerator
		{
			[Token(Token = "0x4000A54")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x170001AB")]
			public string Current
			{
				[Token(Token = "0x6000B09")]
				[Address(RVA = "0xE44224", Offset = "0xE44224", VA = "0xE44224")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B06")]
			[Address(RVA = "0xE44178", Offset = "0xE44178", VA = "0xE44178")]
			public KeyEnumerator(List<JSONNode>.Enumerator aArrayEnum)
			{
			}

			[Token(Token = "0x6000B07")]
			[Address(RVA = "0xE441C0", Offset = "0xE441C0", VA = "0xE441C0")]
			public KeyEnumerator(Dictionary<string, JSONNode>.Enumerator aDictEnum)
			{
			}

			[Token(Token = "0x6000B08")]
			[Address(RVA = "0xE4420C", Offset = "0xE4420C", VA = "0xE4420C")]
			public KeyEnumerator(Enumerator aEnumerator)
			{
			}

			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0xE44264", Offset = "0xE44264", VA = "0xE44264")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0xE44268", Offset = "0xE44268", VA = "0xE44268")]
			public KeyEnumerator GetEnumerator()
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x20001C1")]
		public class LinqEnumerator : IEnumerator<KeyValuePair<string, JSONNode>>, IEnumerator, IDisposable, IEnumerable<KeyValuePair<string, JSONNode>>, IEnumerable
		{
			[Token(Token = "0x4000A55")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private JSONNode m_Node;

			[Token(Token = "0x4000A56")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private Enumerator m_Enumerator;

			[Token(Token = "0x170001AC")]
			public KeyValuePair<string, JSONNode> Current
			{
				[Token(Token = "0x6000B0D")]
				[Address(RVA = "0xE4434C", Offset = "0xE4434C", VA = "0xE4434C", Slot = "4")]
				get
				{
					return default(KeyValuePair<string, JSONNode>);
				}
			}

			[Token(Token = "0x170001AD")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B0E")]
				[Address(RVA = "0xE44354", Offset = "0xE44354", VA = "0xE44354", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0xE44278", Offset = "0xE44278", VA = "0xE44278")]
			internal LinqEnumerator(JSONNode aNode)
			{
			}

			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0xE443BC", Offset = "0xE443BC", VA = "0xE443BC", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B10")]
			[Address(RVA = "0xE443C4", Offset = "0xE443C4", VA = "0xE443C4", Slot = "5")]
			public void Dispose()
			{
			}

			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xE443E4", Offset = "0xE443E4", VA = "0xE443E4", Slot = "9")]
			public IEnumerator<KeyValuePair<string, JSONNode>> GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B12")]
			[Address(RVA = "0xE44444", Offset = "0xE44444", VA = "0xE44444", Slot = "8")]
			public void Reset()
			{
			}

			[Token(Token = "0x6000B13")]
			[Address(RVA = "0xE44500", Offset = "0xE44500", VA = "0xE44500", Slot = "10")]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001C2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4D80", Offset = "0xAE4D80")]
		private sealed class <get_Children>d__41 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A57")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A58")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000A59")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x170001AE")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000B17")]
				[Address(RVA = "0xE43754", Offset = "0xE43754", VA = "0xE43754", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001AF")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B19")]
				[Address(RVA = "0xE4379C", Offset = "0xE4379C", VA = "0xE4379C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B14")]
			[Address(RVA = "0xE43700", Offset = "0xE43700", VA = "0xE43700")]
			[DebuggerHidden]
			public <get_Children>d__41(int <>1__state)
			{
			}

			[Token(Token = "0x6000B15")]
			[Address(RVA = "0xE43738", Offset = "0xE43738", VA = "0xE43738", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B16")]
			[Address(RVA = "0xE4373C", Offset = "0xE4373C", VA = "0xE4373C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B18")]
			[Address(RVA = "0xE4375C", Offset = "0xE4375C", VA = "0xE4375C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0xE437A4", Offset = "0xE437A4", VA = "0xE437A4", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0xE43838", Offset = "0xE43838", VA = "0xE43838", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x20001C3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4D90", Offset = "0xAE4D90")]
		private sealed class <get_DeepChildren>d__43 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A5A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A5B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000A5C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A5D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONNode <>4__this;

			[Token(Token = "0x4000A5E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private IEnumerator<JSONNode> <>7__wrap1;

			[Token(Token = "0x4000A5F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private IEnumerator<JSONNode> <>7__wrap2;

			[Token(Token = "0x170001B0")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000B21")]
				[Address(RVA = "0xE43EB4", Offset = "0xE43EB4", VA = "0xE43EB4", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001B1")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B23")]
				[Address(RVA = "0xE43EFC", Offset = "0xE43EFC", VA = "0xE43EFC", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0xE4383C", Offset = "0xE4383C", VA = "0xE4383C")]
			[DebuggerHidden]
			public <get_DeepChildren>d__43(int <>1__state)
			{
			}

			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0xE43874", Offset = "0xE43874", VA = "0xE43874", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0xE43A7C", Offset = "0xE43A7C", VA = "0xE43A7C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0xE439C0", Offset = "0xE439C0", VA = "0xE439C0")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000B20")]
			[Address(RVA = "0xE43904", Offset = "0xE43904", VA = "0xE43904")]
			private void <>m__Finally2()
			{
			}

			[Token(Token = "0x6000B22")]
			[Address(RVA = "0xE43EBC", Offset = "0xE43EBC", VA = "0xE43EBC", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000B24")]
			[Address(RVA = "0xE43F04", Offset = "0xE43F04", VA = "0xE43F04", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B25")]
			[Address(RVA = "0xE43FAC", Offset = "0xE43FAC", VA = "0xE43FAC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A45")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static bool forceASCII;

		[Token(Token = "0x4000A46")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
		public static bool longAsString;

		[Token(Token = "0x4000A47")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2")]
		public static bool allowLineComments;

		[Token(Token = "0x4000A48")]
		[ThreadStatic]
		private static StringBuilder m_EscapeBuilder;

		[Token(Token = "0x4000A49")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public static JSONContainerType VectorContainerType;

		[Token(Token = "0x4000A4A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static JSONContainerType QuaternionContainerType;

		[Token(Token = "0x4000A4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static JSONContainerType RectContainerType;

		[Token(Token = "0x1700018F")]
		public abstract JSONNodeType Tag
		{
			[Token(Token = "0x6000A95")]
			get;
		}

		[Token(Token = "0x17000190")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000A96")]
			[Address(RVA = "0x1416DFC", Offset = "0x1416DFC", VA = "0x1416DFC", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A97")]
			[Address(RVA = "0x1416E04", Offset = "0x1416E04", VA = "0x1416E04", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x17000191")]
		public virtual JSONNode Item
		{
			[Token(Token = "0x6000A98")]
			[Address(RVA = "0x1416E08", Offset = "0x1416E08", VA = "0x1416E08", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A99")]
			[Address(RVA = "0x1416E10", Offset = "0x1416E10", VA = "0x1416E10", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x17000192")]
		public virtual string Value
		{
			[Token(Token = "0x6000A9A")]
			[Address(RVA = "0x1416E14", Offset = "0x1416E14", VA = "0x1416E14", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000A9B")]
			[Address(RVA = "0x1416E58", Offset = "0x1416E58", VA = "0x1416E58", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x17000193")]
		public virtual int Count
		{
			[Token(Token = "0x6000A9C")]
			[Address(RVA = "0x1416E5C", Offset = "0x1416E5C", VA = "0x1416E5C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000194")]
		public virtual bool IsNumber
		{
			[Token(Token = "0x6000A9D")]
			[Address(RVA = "0x1416E64", Offset = "0x1416E64", VA = "0x1416E64", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000195")]
		public virtual bool IsString
		{
			[Token(Token = "0x6000A9E")]
			[Address(RVA = "0x1416E6C", Offset = "0x1416E6C", VA = "0x1416E6C", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000196")]
		public virtual bool IsBoolean
		{
			[Token(Token = "0x6000A9F")]
			[Address(RVA = "0x1416E74", Offset = "0x1416E74", VA = "0x1416E74", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000197")]
		public virtual bool IsNull
		{
			[Token(Token = "0x6000AA0")]
			[Address(RVA = "0x1416E7C", Offset = "0x1416E7C", VA = "0x1416E7C", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000198")]
		public virtual bool IsArray
		{
			[Token(Token = "0x6000AA1")]
			[Address(RVA = "0x1416E84", Offset = "0x1416E84", VA = "0x1416E84", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000199")]
		public virtual bool IsObject
		{
			[Token(Token = "0x6000AA2")]
			[Address(RVA = "0x1416E8C", Offset = "0x1416E8C", VA = "0x1416E8C", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700019A")]
		public virtual bool Inline
		{
			[Token(Token = "0x6000AA3")]
			[Address(RVA = "0x1416E94", Offset = "0x1416E94", VA = "0x1416E94", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000AA4")]
			[Address(RVA = "0x1416E9C", Offset = "0x1416E9C", VA = "0x1416E9C", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x1700019B")]
		public virtual IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000AAA")]
			[Address(RVA = "0x1416F24", Offset = "0x1416F24", VA = "0x1416F24", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEE9F4", Offset = "0xAEE9F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019C")]
		public IEnumerable<JSONNode> DeepChildren
		{
			[Token(Token = "0x6000AAB")]
			[Address(RVA = "0x1416F80", Offset = "0x1416F80", VA = "0x1416F80")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEEA54", Offset = "0xAEEA54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019D")]
		public IEnumerable<KeyValuePair<string, JSONNode>> Linq
		{
			[Token(Token = "0x6000AB2")]
			[Address(RVA = "0x1417128", Offset = "0x1417128", VA = "0x1417128")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700019E")]
		public KeyEnumerator Keys
		{
			[Token(Token = "0x6000AB3")]
			[Address(RVA = "0x1417188", Offset = "0x1417188", VA = "0x1417188")]
			get
			{
				return default(KeyEnumerator);
			}
		}

		[Token(Token = "0x1700019F")]
		public ValueEnumerator Values
		{
			[Token(Token = "0x6000AB4")]
			[Address(RVA = "0x14171D0", Offset = "0x14171D0", VA = "0x14171D0")]
			get
			{
				return default(ValueEnumerator);
			}
		}

		[Token(Token = "0x170001A0")]
		public virtual double AsDouble
		{
			[Token(Token = "0x6000AB5")]
			[Address(RVA = "0x1417218", Offset = "0x1417218", VA = "0x1417218", Slot = "31")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000AB6")]
			[Address(RVA = "0x14172FC", Offset = "0x14172FC", VA = "0x14172FC", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170001A1")]
		public virtual int AsInt
		{
			[Token(Token = "0x6000AB7")]
			[Address(RVA = "0x1417390", Offset = "0x1417390", VA = "0x1417390", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000AB8")]
			[Address(RVA = "0x14173C8", Offset = "0x14173C8", VA = "0x14173C8", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x170001A2")]
		public virtual float AsFloat
		{
			[Token(Token = "0x6000AB9")]
			[Address(RVA = "0x14173E0", Offset = "0x14173E0", VA = "0x14173E0", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000ABA")]
			[Address(RVA = "0x1417404", Offset = "0x1417404", VA = "0x1417404", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170001A3")]
		public virtual bool AsBool
		{
			[Token(Token = "0x6000ABB")]
			[Address(RVA = "0x1417418", Offset = "0x1417418", VA = "0x1417418", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000ABC")]
			[Address(RVA = "0x14174DC", Offset = "0x14174DC", VA = "0x14174DC", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x170001A4")]
		public virtual long AsLong
		{
			[Token(Token = "0x6000ABD")]
			[Address(RVA = "0x1417560", Offset = "0x1417560", VA = "0x1417560", Slot = "39")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000ABE")]
			[Address(RVA = "0x14175A0", Offset = "0x14175A0", VA = "0x14175A0", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x170001A5")]
		public virtual JSONArray AsArray
		{
			[Token(Token = "0x6000ABF")]
			[Address(RVA = "0x14175E0", Offset = "0x14175E0", VA = "0x14175E0", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A6")]
		public virtual JSONObject AsObject
		{
			[Token(Token = "0x6000AC0")]
			[Address(RVA = "0x141765C", Offset = "0x141765C", VA = "0x141765C", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001A7")]
		internal static StringBuilder EscapeBuilder
		{
			[Token(Token = "0x6000AD2")]
			[Address(RVA = "0x1417DDC", Offset = "0x1417DDC", VA = "0x1417DDC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x1416EA0", Offset = "0x1416EA0", VA = "0x1416EA0", Slot = "20")]
		public virtual void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x1416EA4", Offset = "0x1416EA4", VA = "0x1416EA4", Slot = "21")]
		public virtual void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x1416F0C", Offset = "0x1416F0C", VA = "0x1416F0C", Slot = "22")]
		public virtual JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x1416F14", Offset = "0x1416F14", VA = "0x1416F14", Slot = "23")]
		public virtual JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x1416F1C", Offset = "0x1416F1C", VA = "0x1416F1C", Slot = "24")]
		public virtual JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x1416FEC", Offset = "0x1416FEC", VA = "0x1416FEC", Slot = "26")]
		public virtual bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x1416FF4", Offset = "0x1416FF4", VA = "0x1416FF4", Slot = "27")]
		public virtual JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x1416FFC", Offset = "0x1416FFC", VA = "0x1416FFC", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x141708C", Offset = "0x141708C", VA = "0x141708C", Slot = "28")]
		public virtual string ToString(int aIndent)
		{
			return null;
		}

		[Token(Token = "0x6000AB0")]
		internal abstract void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode);

		[Token(Token = "0x6000AB1")]
		public abstract Enumerator GetEnumerator();

		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x14176D8", Offset = "0x14176D8", VA = "0x14176D8")]
		public static implicit operator JSONNode(string s)
		{
			return null;
		}

		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x1417734", Offset = "0x1417734", VA = "0x1417734")]
		public static implicit operator string(JSONNode d)
		{
			return null;
		}

		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x14177C4", Offset = "0x14177C4", VA = "0x14177C4")]
		public static implicit operator JSONNode(double n)
		{
			return null;
		}

		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x1417828", Offset = "0x1417828", VA = "0x1417828")]
		public static implicit operator double(JSONNode d)
		{
			return default(double);
		}

		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x14178BC", Offset = "0x14178BC", VA = "0x14178BC")]
		public static implicit operator JSONNode(float n)
		{
			return null;
		}

		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x1417920", Offset = "0x1417920", VA = "0x1417920")]
		public static implicit operator float(JSONNode d)
		{
			return default(float);
		}

		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x14179B4", Offset = "0x14179B4", VA = "0x14179B4")]
		public static implicit operator JSONNode(int n)
		{
			return null;
		}

		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x1417A10", Offset = "0x1417A10", VA = "0x1417A10")]
		public static implicit operator int(JSONNode d)
		{
			return default(int);
		}

		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x1417AA4", Offset = "0x1417AA4", VA = "0x1417AA4")]
		public static implicit operator JSONNode(long n)
		{
			return null;
		}

		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x1417B88", Offset = "0x1417B88", VA = "0x1417B88")]
		public static implicit operator long(JSONNode d)
		{
			return default(long);
		}

		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x1417C1C", Offset = "0x1417C1C", VA = "0x1417C1C")]
		public static implicit operator JSONNode(bool b)
		{
			return null;
		}

		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x1417C78", Offset = "0x1417C78", VA = "0x1417C78")]
		public static implicit operator bool(JSONNode d)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x1417D0C", Offset = "0x1417D0C", VA = "0x1417D0C")]
		public static implicit operator JSONNode(KeyValuePair<string, JSONNode> aKeyValue)
		{
			return null;
		}

		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x1415564", Offset = "0x1415564", VA = "0x1415564")]
		public static bool operator ==(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x1417D4C", Offset = "0x1417D4C", VA = "0x1417D4C")]
		public static bool operator !=(JSONNode a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x1417DC8", Offset = "0x1417DC8", VA = "0x1417DC8", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x1417DD4", Offset = "0x1417DD4", VA = "0x1417DD4", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x1417EB4", Offset = "0x1417EB4", VA = "0x1417EB4")]
		internal static string Escape(string aText)
		{
			return null;
		}

		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x14181BC", Offset = "0x14181BC", VA = "0x14181BC")]
		private static JSONNode ParseElement(string token, bool quoted)
		{
			return null;
		}

		[Token(Token = "0x6000AD5")]
		[Address(RVA = "0x1414A64", Offset = "0x1414A64", VA = "0x1414A64")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}

		[Token(Token = "0x6000AD6")]
		[Address(RVA = "0x1418404", Offset = "0x1418404", VA = "0x1418404")]
		private static JSONNode GetContainer(JSONContainerType aType)
		{
			return null;
		}

		[Token(Token = "0x6000AD7")]
		[Address(RVA = "0x1418488", Offset = "0x1418488", VA = "0x1418488")]
		public static implicit operator JSONNode(Vector2 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000AD8")]
		[Address(RVA = "0x141867C", Offset = "0x141867C", VA = "0x141867C")]
		public static implicit operator JSONNode(Vector3 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000AD9")]
		[Address(RVA = "0x1418900", Offset = "0x1418900", VA = "0x1418900")]
		public static implicit operator JSONNode(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x1418BF4", Offset = "0x1418BF4", VA = "0x1418BF4")]
		public static implicit operator JSONNode(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x1418EE8", Offset = "0x1418EE8", VA = "0x1418EE8")]
		public static implicit operator JSONNode(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x1419238", Offset = "0x1419238", VA = "0x1419238")]
		public static implicit operator JSONNode(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x1419580", Offset = "0x1419580", VA = "0x1419580")]
		public static implicit operator Vector2(JSONNode aNode)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x14195D8", Offset = "0x14195D8", VA = "0x14195D8")]
		public static implicit operator Vector3(JSONNode aNode)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x1419630", Offset = "0x1419630", VA = "0x1419630")]
		public static implicit operator Vector4(JSONNode aNode)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x141966C", Offset = "0x141966C", VA = "0x141966C")]
		public static implicit operator Quaternion(JSONNode aNode)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x14196A8", Offset = "0x14196A8", VA = "0x14196A8")]
		public static implicit operator Rect(JSONNode aNode)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x14196E0", Offset = "0x14196E0", VA = "0x14196E0")]
		public static implicit operator RectOffset(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x1419754", Offset = "0x1419754", VA = "0x1419754")]
		public Vector2 ReadVector2(Vector2 aDefault)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x1419898", Offset = "0x1419898", VA = "0x1419898")]
		public Vector2 ReadVector2(string aXName, string aYName)
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x14195B0", Offset = "0x14195B0", VA = "0x14195B0")]
		public Vector2 ReadVector2()
		{
			return default(Vector2);
		}

		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x1418540", Offset = "0x1418540", VA = "0x1418540")]
		public JSONNode WriteVector2(Vector2 aVec, string aXName = "x", string aYName = "y")
		{
			return null;
		}

		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x1419954", Offset = "0x1419954", VA = "0x1419954")]
		public Vector3 ReadVector3(Vector3 aDefault)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x1419B14", Offset = "0x1419B14", VA = "0x1419B14")]
		public Vector3 ReadVector3(string aXName, string aYName, string aZName)
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x1419608", Offset = "0x1419608", VA = "0x1419608")]
		public Vector3 ReadVector3()
		{
			return default(Vector3);
		}

		[Token(Token = "0x6000AEA")]
		[Address(RVA = "0x141875C", Offset = "0x141875C", VA = "0x141875C")]
		public JSONNode WriteVector3(Vector3 aVec, string aXName = "x", string aYName = "y", string aZName = "z")
		{
			return null;
		}

		[Token(Token = "0x6000AEB")]
		[Address(RVA = "0x1419C08", Offset = "0x1419C08", VA = "0x1419C08")]
		public Vector4 ReadVector4(Vector4 aDefault)
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000AEC")]
		[Address(RVA = "0x1419644", Offset = "0x1419644", VA = "0x1419644")]
		public Vector4 ReadVector4()
		{
			return default(Vector4);
		}

		[Token(Token = "0x6000AED")]
		[Address(RVA = "0x14189A0", Offset = "0x14189A0", VA = "0x14189A0")]
		public JSONNode WriteVector4(Vector4 aVec)
		{
			return null;
		}

		[Token(Token = "0x6000AEE")]
		[Address(RVA = "0x1419E64", Offset = "0x1419E64", VA = "0x1419E64")]
		public Quaternion ReadQuaternion(Quaternion aDefault)
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AEF")]
		[Address(RVA = "0x1419680", Offset = "0x1419680", VA = "0x1419680")]
		public Quaternion ReadQuaternion()
		{
			return default(Quaternion);
		}

		[Token(Token = "0x6000AF0")]
		[Address(RVA = "0x1418C94", Offset = "0x1418C94", VA = "0x1418C94")]
		public JSONNode WriteQuaternion(Quaternion aRot)
		{
			return null;
		}

		[Token(Token = "0x6000AF1")]
		[Address(RVA = "0x141A0C0", Offset = "0x141A0C0", VA = "0x141A0C0")]
		public Rect ReadRect(Rect aDefault)
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AF2")]
		[Address(RVA = "0x14196CC", Offset = "0x14196CC", VA = "0x14196CC")]
		public Rect ReadRect()
		{
			return default(Rect);
		}

		[Token(Token = "0x6000AF3")]
		[Address(RVA = "0x1418F88", Offset = "0x1418F88", VA = "0x1418F88")]
		public JSONNode WriteRect(Rect aRect)
		{
			return null;
		}

		[Token(Token = "0x6000AF4")]
		[Address(RVA = "0x141A31C", Offset = "0x141A31C", VA = "0x141A31C")]
		public RectOffset ReadRectOffset(RectOffset aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000AF5")]
		[Address(RVA = "0x14196F4", Offset = "0x14196F4", VA = "0x14196F4")]
		public RectOffset ReadRectOffset()
		{
			return null;
		}

		[Token(Token = "0x6000AF6")]
		[Address(RVA = "0x14192B0", Offset = "0x14192B0", VA = "0x14192B0")]
		public JSONNode WriteRectOffset(RectOffset aRect)
		{
			return null;
		}

		[Token(Token = "0x6000AF7")]
		[Address(RVA = "0x141A5B8", Offset = "0x141A5B8", VA = "0x141A5B8")]
		public Matrix4x4 ReadMatrix()
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000AF8")]
		[Address(RVA = "0x141A684", Offset = "0x141A684", VA = "0x141A684")]
		public JSONNode WriteMatrix(Matrix4x4 aMatrix)
		{
			return null;
		}

		[Token(Token = "0x6000AF9")]
		[Address(RVA = "0x1415DA4", Offset = "0x1415DA4", VA = "0x1415DA4")]
		protected JSONNode()
		{
		}
	}
	[Token(Token = "0x20001C4")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xAE4DA0", Offset = "0xAE4DA0")]
	public class JSONArray : JSONNode
	{
		[Token(Token = "0x20001C5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4DD8", Offset = "0xAE4DD8")]
		private sealed class <get_Children>d__22 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A62")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A63")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000A64")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A65")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONArray <>4__this;

			[Token(Token = "0x4000A66")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private List<JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170001B9")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000B3A")]
				[Address(RVA = "0xE43604", Offset = "0xE43604", VA = "0xE43604", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001BA")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B3C")]
				[Address(RVA = "0xE4364C", Offset = "0xE4364C", VA = "0xE4364C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B36")]
			[Address(RVA = "0xE433E8", Offset = "0xE433E8", VA = "0xE433E8")]
			[DebuggerHidden]
			public <get_Children>d__22(int <>1__state)
			{
			}

			[Token(Token = "0x6000B37")]
			[Address(RVA = "0xE43420", Offset = "0xE43420", VA = "0xE43420", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B38")]
			[Address(RVA = "0xE43490", Offset = "0xE43490", VA = "0xE43490", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B39")]
			[Address(RVA = "0xE4343C", Offset = "0xE4343C", VA = "0xE4343C")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000B3B")]
			[Address(RVA = "0xE4360C", Offset = "0xE4360C", VA = "0xE4360C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0xE43654", Offset = "0xE43654", VA = "0xE43654", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0xE436FC", Offset = "0xE436FC", VA = "0xE436FC", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<JSONNode> m_List;

		[Token(Token = "0x4000A61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x170001B2")]
		public override bool Inline
		{
			[Token(Token = "0x6000B26")]
			[Address(RVA = "0x1415258", Offset = "0x1415258", VA = "0x1415258", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B27")]
			[Address(RVA = "0x1415260", Offset = "0x1415260", VA = "0x1415260", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170001B3")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x141526C", Offset = "0x141526C", VA = "0x141526C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001B4")]
		public override bool IsArray
		{
			[Token(Token = "0x6000B29")]
			[Address(RVA = "0x1415274", Offset = "0x1415274", VA = "0x1415274", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001B5")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B2B")]
			[Address(RVA = "0x141530C", Offset = "0x141530C", VA = "0x141530C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2C")]
			[Address(RVA = "0x141543C", Offset = "0x141543C", VA = "0x141543C", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001B6")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B2D")]
			[Address(RVA = "0x1415798", Offset = "0x1415798", VA = "0x1415798", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B2E")]
			[Address(RVA = "0x14157F4", Offset = "0x14157F4", VA = "0x14157F4", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001B7")]
		public override int Count
		{
			[Token(Token = "0x6000B2F")]
			[Address(RVA = "0x14158C8", Offset = "0x14158C8", VA = "0x14158C8", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001B8")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000B33")]
			[Address(RVA = "0x1415B14", Offset = "0x1415B14", VA = "0x1415B14", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEEB94", Offset = "0xAEEB94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x141527C", Offset = "0x141527C", VA = "0x141527C", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x1415914", Offset = "0x1415914", VA = "0x1415914", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x14159E8", Offset = "0x14159E8", VA = "0x14159E8", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x1415AA8", Offset = "0x1415AA8", VA = "0x1415AA8", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x1415B80", Offset = "0x1415B80", VA = "0x1415B80", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x1415D00", Offset = "0x1415D00", VA = "0x1415D00")]
		public JSONArray()
		{
		}
	}
	[Token(Token = "0x20001C6")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xAE4DE8", Offset = "0xAE4DE8")]
	public class JSONObject : JSONNode
	{
		[Token(Token = "0x20001C7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4E20", Offset = "0xAE4E20")]
		private sealed class <>c__DisplayClass21_0
		{
			[Token(Token = "0x4000A69")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public JSONNode aNode;

			[Token(Token = "0x6000B52")]
			[Address(RVA = "0xE44668", Offset = "0xE44668", VA = "0xE44668")]
			public <>c__DisplayClass21_0()
			{
			}

			[Token(Token = "0x6000B53")]
			[Address(RVA = "0xE44670", Offset = "0xE44670", VA = "0xE44670")]
			internal bool <Remove>b__0(KeyValuePair<string, JSONNode> k)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x20001C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4E30", Offset = "0xAE4E30")]
		private sealed class <get_Children>d__25 : IEnumerable<JSONNode>, IEnumerable, IEnumerator<JSONNode>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A6A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			[Token(Token = "0x4000A6B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private JSONNode <>2__current;

			[Token(Token = "0x4000A6C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private int <>l__initialThreadId;

			[Token(Token = "0x4000A6D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public JSONObject <>4__this;

			[Token(Token = "0x4000A6E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Dictionary<string, JSONNode>.Enumerator <>7__wrap1;

			[Token(Token = "0x170001C2")]
			private JSONNode System.Collections.Generic.IEnumerator<SimpleJSON.JSONNode>.Current
			{
				[Token(Token = "0x6000B58")]
				[Address(RVA = "0xE44924", Offset = "0xE44924", VA = "0xE44924", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170001C3")]
			private object System.Collections.IEnumerator.Current
			{
				[Token(Token = "0x6000B5A")]
				[Address(RVA = "0xE4496C", Offset = "0xE4496C", VA = "0xE4496C", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6000B54")]
			[Address(RVA = "0xE446F4", Offset = "0xE446F4", VA = "0xE446F4")]
			[DebuggerHidden]
			public <get_Children>d__25(int <>1__state)
			{
			}

			[Token(Token = "0x6000B55")]
			[Address(RVA = "0xE4472C", Offset = "0xE4472C", VA = "0xE4472C", Slot = "7")]
			[DebuggerHidden]
			private void System.IDisposable.Dispose()
			{
			}

			[Token(Token = "0x6000B56")]
			[Address(RVA = "0xE4479C", Offset = "0xE4479C", VA = "0xE4479C", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6000B57")]
			[Address(RVA = "0xE44748", Offset = "0xE44748", VA = "0xE44748")]
			private void <>m__Finally1()
			{
			}

			[Token(Token = "0x6000B59")]
			[Address(RVA = "0xE4492C", Offset = "0xE4492C", VA = "0xE4492C", Slot = "10")]
			[DebuggerHidden]
			private void System.Collections.IEnumerator.Reset()
			{
			}

			[Token(Token = "0x6000B5B")]
			[Address(RVA = "0xE44974", Offset = "0xE44974", VA = "0xE44974", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<JSONNode> System.Collections.Generic.IEnumerable<SimpleJSON.JSONNode>.GetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000B5C")]
			[Address(RVA = "0xE44A1C", Offset = "0xE44A1C", VA = "0xE44A1C", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System.Collections.IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, JSONNode> m_Dict;

		[Token(Token = "0x4000A68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool inline;

		[Token(Token = "0x170001BB")]
		public override bool Inline
		{
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x141AF68", Offset = "0x141AF68", VA = "0x141AF68", Slot = "18")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x141AF70", Offset = "0x141AF70", VA = "0x141AF70", Slot = "19")]
			set
			{
			}
		}

		[Token(Token = "0x170001BC")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x141AF7C", Offset = "0x141AF7C", VA = "0x141AF7C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001BD")]
		public override bool IsObject
		{
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x141AF84", Offset = "0x141AF84", VA = "0x141AF84", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001BE")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B44")]
			[Address(RVA = "0x141B01C", Offset = "0x141B01C", VA = "0x141B01C", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B45")]
			[Address(RVA = "0x141B0EC", Offset = "0x141B0EC", VA = "0x141B0EC", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001BF")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B46")]
			[Address(RVA = "0x141B22C", Offset = "0x141B22C", VA = "0x141B22C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B47")]
			[Address(RVA = "0x141B2D8", Offset = "0x141B2D8", VA = "0x141B2D8", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001C0")]
		public override int Count
		{
			[Token(Token = "0x6000B48")]
			[Address(RVA = "0x141B42C", Offset = "0x141B42C", VA = "0x141B42C", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001C1")]
		public override IEnumerable<JSONNode> Children
		{
			[Token(Token = "0x6000B4F")]
			[Address(RVA = "0x141BAA0", Offset = "0x141BAA0", VA = "0x141BAA0", Slot = "25")]
			[AttributeAttribute(Name = "IteratorStateMachineAttribute", RVA = "0xAEEC64", Offset = "0xAEEC64")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B43")]
		[Address(RVA = "0x141AF8C", Offset = "0x141AF8C", VA = "0x141AF8C", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B49")]
		[Address(RVA = "0x141B480", Offset = "0x141B480", VA = "0x141B480", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B4A")]
		[Address(RVA = "0x141B630", Offset = "0x141B630", VA = "0x141B630", Slot = "22")]
		public override JSONNode Remove(string aKey)
		{
			return null;
		}

		[Token(Token = "0x6000B4B")]
		[Address(RVA = "0x141B700", Offset = "0x141B700", VA = "0x141B700", Slot = "23")]
		public override JSONNode Remove(int aIndex)
		{
			return null;
		}

		[Token(Token = "0x6000B4C")]
		[Address(RVA = "0x141B7E8", Offset = "0x141B7E8", VA = "0x141B7E8", Slot = "24")]
		public override JSONNode Remove(JSONNode aNode)
		{
			return null;
		}

		[Token(Token = "0x6000B4D")]
		[Address(RVA = "0x141B9B4", Offset = "0x141B9B4", VA = "0x141B9B4", Slot = "26")]
		public override bool HasKey(string aKey)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B4E")]
		[Address(RVA = "0x141BA18", Offset = "0x141BA18", VA = "0x141BA18", Slot = "27")]
		public override JSONNode GetValueOrDefault(string aKey, JSONNode aDefault)
		{
			return null;
		}

		[Token(Token = "0x6000B50")]
		[Address(RVA = "0x141BB0C", Offset = "0x141BB0C", VA = "0x141BB0C", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000B51")]
		[Address(RVA = "0x1416344", Offset = "0x1416344", VA = "0x1416344")]
		public JSONObject()
		{
		}
	}
	[Token(Token = "0x20001C9")]
	public class JSONString : JSONNode
	{
		[Token(Token = "0x4000A6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string m_Data;

		[Token(Token = "0x170001C4")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B5D")]
			[Address(RVA = "0x141BE2C", Offset = "0x141BE2C", VA = "0x141BE2C", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001C5")]
		public override bool IsString
		{
			[Token(Token = "0x6000B5E")]
			[Address(RVA = "0x141BE34", Offset = "0x141BE34", VA = "0x141BE34", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C6")]
		public override string Value
		{
			[Token(Token = "0x6000B60")]
			[Address(RVA = "0x141BE5C", Offset = "0x141BE5C", VA = "0x141BE5C", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B61")]
			[Address(RVA = "0x141BE64", Offset = "0x141BE64", VA = "0x141BE64", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x141BE3C", Offset = "0x141BE3C", VA = "0x141BE3C", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B62")]
		[Address(RVA = "0x1416A0C", Offset = "0x1416A0C", VA = "0x1416A0C")]
		public JSONString(string aData)
		{
		}

		[Token(Token = "0x6000B63")]
		[Address(RVA = "0x141BE6C", Offset = "0x141BE6C", VA = "0x141BE6C", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000B64")]
		[Address(RVA = "0x141BF20", Offset = "0x141BF20", VA = "0x141BF20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B65")]
		[Address(RVA = "0x141C048", Offset = "0x141C048", VA = "0x141C048", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001CA")]
	public class JSONNumber : JSONNode
	{
		[Token(Token = "0x4000A70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private double m_Data;

		[Token(Token = "0x170001C7")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B66")]
			[Address(RVA = "0x141AA08", Offset = "0x141AA08", VA = "0x141AA08", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001C8")]
		public override bool IsNumber
		{
			[Token(Token = "0x6000B67")]
			[Address(RVA = "0x141AA10", Offset = "0x141AA10", VA = "0x141AA10", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001C9")]
		public override string Value
		{
			[Token(Token = "0x6000B69")]
			[Address(RVA = "0x141AA38", Offset = "0x141AA38", VA = "0x141AA38", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B6A")]
			[Address(RVA = "0x141AAAC", Offset = "0x141AAAC", VA = "0x141AAAC", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170001CA")]
		public override double AsDouble
		{
			[Token(Token = "0x6000B6B")]
			[Address(RVA = "0x141AB78", Offset = "0x141AB78", VA = "0x141AB78", Slot = "31")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000B6C")]
			[Address(RVA = "0x141AB80", Offset = "0x141AB80", VA = "0x141AB80", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170001CB")]
		public override long AsLong
		{
			[Token(Token = "0x6000B6D")]
			[Address(RVA = "0x141AB88", Offset = "0x141AB88", VA = "0x141AB88", Slot = "39")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000B6E")]
			[Address(RVA = "0x141ABA8", Offset = "0x141ABA8", VA = "0x141ABA8", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x6000B68")]
		[Address(RVA = "0x141AA18", Offset = "0x141AA18", VA = "0x141AA18", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x14165F8", Offset = "0x14165F8", VA = "0x14165F8")]
		public JSONNumber(double aData)
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x141ABB4", Offset = "0x141ABB4", VA = "0x141ABB4")]
		public JSONNumber(string aData)
		{
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x141AC38", Offset = "0x141AC38", VA = "0x141AC38", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x141AC78", Offset = "0x141AC78", VA = "0x141AC78")]
		private static bool IsNumeric(object value)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x141AE1C", Offset = "0x141AE1C", VA = "0x141AE1C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B74")]
		[Address(RVA = "0x141AF5C", Offset = "0x141AF5C", VA = "0x141AF5C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001CB")]
	public class JSONBool : JSONNode
	{
		[Token(Token = "0x4000A71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool m_Data;

		[Token(Token = "0x170001CC")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B75")]
			[Address(RVA = "0x1415DAC", Offset = "0x1415DAC", VA = "0x1415DAC", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001CD")]
		public override bool IsBoolean
		{
			[Token(Token = "0x6000B76")]
			[Address(RVA = "0x1415DB4", Offset = "0x1415DB4", VA = "0x1415DB4", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001CE")]
		public override string Value
		{
			[Token(Token = "0x6000B78")]
			[Address(RVA = "0x1415DDC", Offset = "0x1415DDC", VA = "0x1415DDC", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B79")]
			[Address(RVA = "0x1415DE8", Offset = "0x1415DE8", VA = "0x1415DE8", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170001CF")]
		public override bool AsBool
		{
			[Token(Token = "0x6000B7A")]
			[Address(RVA = "0x1415E70", Offset = "0x1415E70", VA = "0x1415E70", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B7B")]
			[Address(RVA = "0x1415E78", Offset = "0x1415E78", VA = "0x1415E78", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x6000B77")]
		[Address(RVA = "0x1415DBC", Offset = "0x1415DBC", VA = "0x1415DBC", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x1415E84", Offset = "0x1415E84", VA = "0x1415E84")]
		public JSONBool(bool aData)
		{
		}

		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x1415F00", Offset = "0x1415F00", VA = "0x1415F00")]
		public JSONBool(string aData)
		{
		}

		[Token(Token = "0x6000B7E")]
		[Address(RVA = "0x1415F84", Offset = "0x1415F84", VA = "0x1415F84", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}

		[Token(Token = "0x6000B7F")]
		[Address(RVA = "0x1416008", Offset = "0x1416008", VA = "0x1416008", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B80")]
		[Address(RVA = "0x141608C", Offset = "0x141608C", VA = "0x141608C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Token(Token = "0x20001CC")]
	public class JSONNull : JSONNode
	{
		[Token(Token = "0x4000A72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static JSONNull m_StaticInstance;

		[Token(Token = "0x4000A73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static bool reuseSameInstance;

		[Token(Token = "0x170001D0")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B83")]
			[Address(RVA = "0x141A820", Offset = "0x141A820", VA = "0x141A820", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001D1")]
		public override bool IsNull
		{
			[Token(Token = "0x6000B84")]
			[Address(RVA = "0x141A828", Offset = "0x141A828", VA = "0x141A828", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x170001D2")]
		public override string Value
		{
			[Token(Token = "0x6000B86")]
			[Address(RVA = "0x141A850", Offset = "0x141A850", VA = "0x141A850", Slot = "9")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B87")]
			[Address(RVA = "0x141A894", Offset = "0x141A894", VA = "0x141A894", Slot = "10")]
			set
			{
			}
		}

		[Token(Token = "0x170001D3")]
		public override bool AsBool
		{
			[Token(Token = "0x6000B88")]
			[Address(RVA = "0x141A898", Offset = "0x141A898", VA = "0x141A898", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B89")]
			[Address(RVA = "0x141A8A0", Offset = "0x141A8A0", VA = "0x141A8A0", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x6000B81")]
		[Address(RVA = "0x14156FC", Offset = "0x14156FC", VA = "0x14156FC")]
		public static JSONNull CreateOrGet()
		{
			return null;
		}

		[Token(Token = "0x6000B82")]
		[Address(RVA = "0x141A7BC", Offset = "0x141A7BC", VA = "0x141A7BC")]
		private JSONNull()
		{
		}

		[Token(Token = "0x6000B85")]
		[Address(RVA = "0x141A830", Offset = "0x141A830", VA = "0x141A830", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B8A")]
		[Address(RVA = "0x141A8A4", Offset = "0x141A8A4", VA = "0x141A8A4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B8B")]
		[Address(RVA = "0x141A93C", Offset = "0x141A93C", VA = "0x141A93C", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000B8C")]
		[Address(RVA = "0x141A944", Offset = "0x141A944", VA = "0x141A944", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x20001CD")]
	[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0xAE4E40", Offset = "0xAE4E40")]
	internal class JSONLazyCreator : JSONNode
	{
		[Token(Token = "0x4000A74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private JSONNode m_Node;

		[Token(Token = "0x4000A75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string m_Key;

		[Token(Token = "0x170001D4")]
		public override JSONNodeType Tag
		{
			[Token(Token = "0x6000B8E")]
			[Address(RVA = "0x1416098", Offset = "0x1416098", VA = "0x1416098", Slot = "4")]
			get
			{
				return default(JSONNodeType);
			}
		}

		[Token(Token = "0x170001D5")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B93")]
			[Address(RVA = "0x141613C", Offset = "0x141613C", VA = "0x141613C", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B94")]
			[Address(RVA = "0x1416198", Offset = "0x1416198", VA = "0x1416198", Slot = "6")]
			set
			{
			}
		}

		[Token(Token = "0x170001D6")]
		public override JSONNode Item
		{
			[Token(Token = "0x6000B95")]
			[Address(RVA = "0x1416234", Offset = "0x1416234", VA = "0x1416234", Slot = "7")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000B96")]
			[Address(RVA = "0x14162A0", Offset = "0x14162A0", VA = "0x14162A0", Slot = "8")]
			set
			{
			}
		}

		[Token(Token = "0x170001D7")]
		public override int AsInt
		{
			[Token(Token = "0x6000B9D")]
			[Address(RVA = "0x1416578", Offset = "0x1416578", VA = "0x1416578", Slot = "33")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6000B9E")]
			[Address(RVA = "0x1416670", Offset = "0x1416670", VA = "0x1416670", Slot = "34")]
			set
			{
			}
		}

		[Token(Token = "0x170001D8")]
		public override float AsFloat
		{
			[Token(Token = "0x6000B9F")]
			[Address(RVA = "0x14166F4", Offset = "0x14166F4", VA = "0x14166F4", Slot = "35")]
			get
			{
				return default(float);
			}
			[Token(Token = "0x6000BA0")]
			[Address(RVA = "0x1416774", Offset = "0x1416774", VA = "0x1416774", Slot = "36")]
			set
			{
			}
		}

		[Token(Token = "0x170001D9")]
		public override double AsDouble
		{
			[Token(Token = "0x6000BA1")]
			[Address(RVA = "0x14167F8", Offset = "0x14167F8", VA = "0x14167F8", Slot = "31")]
			get
			{
				return default(double);
			}
			[Token(Token = "0x6000BA2")]
			[Address(RVA = "0x1416878", Offset = "0x1416878", VA = "0x1416878", Slot = "32")]
			set
			{
			}
		}

		[Token(Token = "0x170001DA")]
		public override long AsLong
		{
			[Token(Token = "0x6000BA3")]
			[Address(RVA = "0x14168FC", Offset = "0x14168FC", VA = "0x14168FC", Slot = "39")]
			get
			{
				return default(long);
			}
			[Token(Token = "0x6000BA4")]
			[Address(RVA = "0x1416A84", Offset = "0x1416A84", VA = "0x1416A84", Slot = "40")]
			set
			{
			}
		}

		[Token(Token = "0x170001DB")]
		public override bool AsBool
		{
			[Token(Token = "0x6000BA5")]
			[Address(RVA = "0x1416BB8", Offset = "0x1416BB8", VA = "0x1416BB8", Slot = "37")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BA6")]
			[Address(RVA = "0x1416C38", Offset = "0x1416C38", VA = "0x1416C38", Slot = "38")]
			set
			{
			}
		}

		[Token(Token = "0x170001DC")]
		public override JSONArray AsArray
		{
			[Token(Token = "0x6000BA7")]
			[Address(RVA = "0x1416CBC", Offset = "0x1416CBC", VA = "0x1416CBC", Slot = "41")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001DD")]
		public override JSONObject AsObject
		{
			[Token(Token = "0x6000BA8")]
			[Address(RVA = "0x1416D30", Offset = "0x1416D30", VA = "0x1416D30", Slot = "42")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x14160A0", Offset = "0x14160A0", VA = "0x14160A0", Slot = "30")]
		public override Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x14153C4", Offset = "0x14153C4", VA = "0x14153C4")]
		public JSONLazyCreator(JSONNode aNode)
		{
		}

		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x14160C0", Offset = "0x14160C0", VA = "0x14160C0")]
		public JSONLazyCreator(JSONNode aNode, string aKey)
		{
		}

		[Token(Token = "0x6000B92")]
		private T Set<T>(T aVal) where T : JSONNode
		{
			return null;
		}

		[Token(Token = "0x6000B97")]
		[Address(RVA = "0x14163E8", Offset = "0x14163E8", VA = "0x14163E8", Slot = "21")]
		public override void Add(JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B98")]
		[Address(RVA = "0x1416484", Offset = "0x1416484", VA = "0x1416484", Slot = "20")]
		public override void Add(string aKey, JSONNode aItem)
		{
		}

		[Token(Token = "0x6000B99")]
		[Address(RVA = "0x1416528", Offset = "0x1416528", VA = "0x1416528")]
		public static bool operator ==(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9A")]
		[Address(RVA = "0x1416540", Offset = "0x1416540", VA = "0x1416540")]
		public static bool operator !=(JSONLazyCreator a, object b)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9B")]
		[Address(RVA = "0x1416558", Offset = "0x1416558", VA = "0x1416558", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x1416570", Offset = "0x1416570", VA = "0x1416570", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6000BA9")]
		[Address(RVA = "0x1416DA4", Offset = "0x1416DA4", VA = "0x1416DA4", Slot = "29")]
		internal override void WriteToStringBuilder(StringBuilder aSB, int aIndent, int aIndentInc, JSONTextMode aMode)
		{
		}
	}
	[Token(Token = "0x20001CE")]
	public static class JSON
	{
		[Token(Token = "0x6000BAA")]
		[Address(RVA = "0x1414A04", Offset = "0x1414A04", VA = "0x1414A04")]
		public static JSONNode Parse(string aJSON)
		{
			return null;
		}
	}
	[Token(Token = "0x20001CF")]
	public enum JSONContainerType
	{
		[Token(Token = "0x4000A77")]
		Array,
		[Token(Token = "0x4000A78")]
		Object
	}
}
namespace RoboRyanTron.QuickButtons
{
	[Serializable]
	[Token(Token = "0x20001D0")]
	public class QuickButton
	{
		[Token(Token = "0x4000A79")]
		private const BindingFlags FLAGS = BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;

		[Token(Token = "0x4000A7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly string functionName;

		[Token(Token = "0x4000A7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly object[] functionArgs;

		[Token(Token = "0x4000A7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly Action<object> action;

		[Token(Token = "0x4000A7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Action<object> invocation;

		[Token(Token = "0x6000BAB")]
		[Address(RVA = "0x138B91C", Offset = "0x138B91C", VA = "0x138B91C")]
		public QuickButton(string functionName, params object[] functionArgs)
		{
		}

		[Token(Token = "0x6000BAC")]
		[Address(RVA = "0x138B9C8", Offset = "0x138B9C8", VA = "0x138B9C8")]
		public QuickButton(Action<object> action)
		{
		}

		[Token(Token = "0x6000BAD")]
		[Address(RVA = "0x138BA70", Offset = "0x138BA70", VA = "0x138BA70")]
		public void Invoke(object target)
		{
		}

		[Token(Token = "0x6000BAE")]
		[Address(RVA = "0x138BAD4", Offset = "0x138BAD4", VA = "0x138BAD4")]
		private void ActionInvoke(object target)
		{
		}

		[Token(Token = "0x6000BAF")]
		[Address(RVA = "0x138BB38", Offset = "0x138BB38", VA = "0x138BB38")]
		private void NameInvoke(object target)
		{
		}
	}
}
namespace MonsterLove.Collections
{
	[Token(Token = "0x20001D1")]
	public class ObjectPool<T>
	{
		[Serializable]
		[Token(Token = "0x20001D2")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4E78", Offset = "0xAE4E78")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A82")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A83")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static Comparison<ObjectPoolContainer<T>> <>9__7_0;

			[Token(Token = "0x6000BBA")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BBB")]
			internal int <GetItem>b__7_0(ObjectPoolContainer<T> p1, ObjectPoolContainer<T> p2)
			{
				return default(int);
			}
		}

		[Token(Token = "0x4000A7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private List<ObjectPoolContainer<T>> list;

		[Token(Token = "0x4000A7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<T, ObjectPoolContainer<T>> lookup;

		[Token(Token = "0x4000A80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Func<T> factoryFunc;

		[Token(Token = "0x4000A81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private int lastIndex;

		[Token(Token = "0x170001DE")]
		public int Count
		{
			[Token(Token = "0x6000BB7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170001DF")]
		public int CountUsedItems
		{
			[Token(Token = "0x6000BB8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6000BB0")]
		public ObjectPool(Func<T> factoryFunc, int initialSize)
		{
		}

		[Token(Token = "0x6000BB1")]
		private void Warm(int capacity)
		{
		}

		[Token(Token = "0x6000BB2")]
		private ObjectPoolContainer<T> CreateContainer()
		{
			return null;
		}

		[Token(Token = "0x6000BB3")]
		public T GetItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000BB4")]
		public T GetOldestItem()
		{
			return (T)null;
		}

		[Token(Token = "0x6000BB5")]
		public void ReleaseItem(object item)
		{
		}

		[Token(Token = "0x6000BB6")]
		public void ReleaseItem(T item)
		{
		}
	}
	[Token(Token = "0x20001D3")]
	public class ObjectPoolContainer<T>
	{
		[Token(Token = "0x4000A84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private T item;

		[Token(Token = "0x4000A85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEAA94", Offset = "0xAEAA94")]
		private bool <Used>k__BackingField;

		[Token(Token = "0x4000A86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public float TimeUsed;

		[Token(Token = "0x170001E0")]
		public bool Used
		{
			[Token(Token = "0x6000BBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEED34", Offset = "0xAEED34")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000BBD")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAEED44", Offset = "0xAEED44")]
			private set
			{
			}
		}

		[Token(Token = "0x170001E1")]
		public T Item
		{
			[Token(Token = "0x6000BBF")]
			get
			{
				return (T)null;
			}
			[Token(Token = "0x6000BC0")]
			set
			{
			}
		}

		[Token(Token = "0x6000BBE")]
		public void Consume()
		{
		}

		[Token(Token = "0x6000BC1")]
		public void Release()
		{
		}

		[Token(Token = "0x6000BC2")]
		public ObjectPoolContainer()
		{
		}
	}
}
namespace UnityEngine
{
	[Token(Token = "0x20001D4")]
	public static class BoundsExtensions
	{
		[Serializable]
		[Token(Token = "0x20001D5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4E98", Offset = "0xAE4E98")]
		private sealed class <>c
		{
			[Token(Token = "0x4000A87")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly <>c <>9;

			[Token(Token = "0x4000A88")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Renderer, Bounds> <>9__0_0;

			[Token(Token = "0x4000A89")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public static Func<Mesh, Bounds> <>9__1_0;

			[Token(Token = "0x4000A8A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public static Func<Bounds, Bounds, Bounds> <>9__2_0;

			[Token(Token = "0x6000BC7")]
			[Address(RVA = "0xE3F8FC", Offset = "0xE3F8FC", VA = "0xE3F8FC")]
			public <>c()
			{
			}

			[Token(Token = "0x6000BC8")]
			[Address(RVA = "0xE3F904", Offset = "0xE3F904", VA = "0xE3F904")]
			internal Bounds <EncapsulatedBounds>b__0_0(Renderer renderer)
			{
				return default(Bounds);
			}

			[Token(Token = "0x6000BC9")]
			[Address(RVA = "0xE3F950", Offset = "0xE3F950", VA = "0xE3F950")]
			internal Bounds <EncapsulatedBounds>b__1_0(Mesh mesh)
			{
				return default(Bounds);
			}

			[Token(Token = "0x6000BCA")]
			[Address(RVA = "0xE3F99C", Offset = "0xE3F99C", VA = "0xE3F99C")]
			internal Bounds <Encapsulation>b__2_0(Bounds encapsulation, Bounds next)
			{
				return default(Bounds);
			}
		}

		[Token(Token = "0x6000BC3")]
		[Address(RVA = "0x11967FC", Offset = "0x11967FC", VA = "0x11967FC")]
		public static Bounds EncapsulatedBounds(this IEnumerable<Renderer> renderers)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000BC4")]
		[Address(RVA = "0x1196A80", Offset = "0x1196A80", VA = "0x1196A80")]
		public static Bounds EncapsulatedBounds(this IEnumerable<Mesh> meshes)
		{
			return default(Bounds);
		}

		[Token(Token = "0x6000BC5")]
		[Address(RVA = "0x1196940", Offset = "0x1196940", VA = "0x1196940")]
		public static Bounds Encapsulation(this IEnumerable<Bounds> bounds)
		{
			return default(Bounds);
		}
	}
}
namespace Oculus
{
	[Token(Token = "0x20001D6")]
	public class MetaAvatarHand : MonoBehaviour
	{
		[Token(Token = "0x6000BCB")]
		[Address(RVA = "0xFFDBF4", Offset = "0xFFDBF4", VA = "0xFFDBF4")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BCC")]
		[Address(RVA = "0xFFDBF8", Offset = "0xFFDBF8", VA = "0xFFDBF8")]
		private void SetupAll()
		{
		}

		[Token(Token = "0x6000BCD")]
		[Address(RVA = "0xFFF774", Offset = "0xFFF774", VA = "0xFFF774")]
		private void Setup(string path, OvrAvatarHandJointType.HandJointType type)
		{
		}

		[Token(Token = "0x6000BCE")]
		[Address(RVA = "0xFFF8D4", Offset = "0xFFF8D4", VA = "0xFFF8D4")]
		public MetaAvatarHand()
		{
		}
	}
}
namespace Multiplayer.UI
{
	[Token(Token = "0x20001D7")]
	public class PartyCodeButton : MonoBehaviour
	{
		[Token(Token = "0x4000A8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public FlatButtonVR UpButton;

		[Token(Token = "0x4000A8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FlatButtonVR DownButton;

		[Token(Token = "0x4000A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshPro Field;

		[Token(Token = "0x4000A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private int CurrentIndex;

		[Token(Token = "0x4000A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly string[] Chars;

		[Token(Token = "0x6000BCF")]
		[Address(RVA = "0x108A864", Offset = "0x108A864", VA = "0x108A864")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BD0")]
		[Address(RVA = "0x108A980", Offset = "0x108A980", VA = "0x108A980")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000BD1")]
		[Address(RVA = "0x108A9EC", Offset = "0x108A9EC", VA = "0x108A9EC")]
		private void OnDownPress(ButtonBase arg0)
		{
		}

		[Token(Token = "0x6000BD2")]
		[Address(RVA = "0x108AA60", Offset = "0x108AA60", VA = "0x108AA60")]
		private void OnUpPress(ButtonBase arg0)
		{
		}

		[Token(Token = "0x6000BD3")]
		[Address(RVA = "0x108AAD4", Offset = "0x108AAD4", VA = "0x108AAD4")]
		public PartyCodeButton()
		{
		}
	}
	[Token(Token = "0x20001D8")]
	public class TravelerUI : MonoBehaviour
	{
		[Token(Token = "0x20001D9")]
		private enum ButtonStates
		{
			[Token(Token = "0x4000A9F")]
			Join,
			[Token(Token = "0x4000AA0")]
			Block,
			[Token(Token = "0x4000AA1")]
			Unblock,
			[Token(Token = "0x4000AA2")]
			Invite,
			[Token(Token = "0x4000AA3")]
			Mute,
			[Token(Token = "0x4000AA4")]
			Unmute
		}

		[Token(Token = "0x20001DA")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4EA8", Offset = "0xAE4EA8")]
		private sealed class <>c__DisplayClass16_0
		{
			[Token(Token = "0x4000AA5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string locationId;

			[Token(Token = "0x6000BDE")]
			[Address(RVA = "0x16781F4", Offset = "0x16781F4", VA = "0x16781F4")]
			public <>c__DisplayClass16_0()
			{
			}

			[Token(Token = "0x6000BDF")]
			[Address(RVA = "0x16781FC", Offset = "0x16781FC", VA = "0x16781FC")]
			internal void <UpdateContent>b__0(LocationInfo info)
			{
			}

			[Token(Token = "0x6000BE0")]
			[Address(RVA = "0x1678288", Offset = "0x1678288", VA = "0x1678288")]
			internal void <UpdateContent>b__1(string info)
			{
			}
		}

		[Token(Token = "0x4000A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public MeshRenderer ImageRenderer;

		[Token(Token = "0x4000A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public TextMeshPro Username;

		[Token(Token = "0x4000A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public TextMeshPro Location;

		[Token(Token = "0x4000A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public FlatButtonVR Button;

		[Token(Token = "0x4000A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public MeshRenderer ButtonBg;

		[Token(Token = "0x4000A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TextMeshPro DownloadingField;

		[Token(Token = "0x4000A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Texture DefaultTravelerTexture;

		[Token(Token = "0x4000A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public readonly MenuEvent OnJoinTravelerSelected;

		[Token(Token = "0x4000A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly List<string> LoadingLocationInfo;

		[Token(Token = "0x4000A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private AtlasIcon ButtonIcon;

		[Token(Token = "0x4000A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Traveler TravelerData;

		[Token(Token = "0x4000A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool BlockingMe;

		[Token(Token = "0x4000A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool Blocked;

		[Token(Token = "0x4000A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private ButtonStates _ButtonState;

		[Token(Token = "0x170001E2")]
		private ButtonStates ButtonState
		{
			[Token(Token = "0x6000BDB")]
			[Address(RVA = "0x139CF70", Offset = "0x139CF70", VA = "0x139CF70")]
			get
			{
				return default(ButtonStates);
			}
			[Token(Token = "0x6000BDA")]
			[Address(RVA = "0x139C268", Offset = "0x139C268", VA = "0x139C268")]
			set
			{
			}
		}

		[Token(Token = "0x6000BD4")]
		[Address(RVA = "0x139C06C", Offset = "0x139C06C", VA = "0x139C06C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000BD5")]
		[Address(RVA = "0x139C164", Offset = "0x139C164", VA = "0x139C164")]
		public void Show(bool v = true, bool showInviteButton = false)
		{
		}

		[Token(Token = "0x6000BD6")]
		[Address(RVA = "0x139C474", Offset = "0x139C474", VA = "0x139C474")]
		public void UpdateContent(Traveler travelerData, int index)
		{
		}

		[Token(Token = "0x6000BD7")]
		[Address(RVA = "0x139CA34", Offset = "0x139CA34", VA = "0x139CA34")]
		private void UpdateButtonState()
		{
		}

		[Token(Token = "0x6000BD8")]
		[Address(RVA = "0x139CDC8", Offset = "0x139CDC8", VA = "0x139CDC8")]
		private void OnButtonSelected(ButtonBase arg0)
		{
		}

		[Token(Token = "0x6000BD9")]
		[Address(RVA = "0x139CF68", Offset = "0x139CF68", VA = "0x139CF68")]
		private static void Invite()
		{
		}

		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x139CF78", Offset = "0x139CF78", VA = "0x139CF78")]
		public TravelerUI()
		{
		}
	}
}
namespace ntw.CurvedTextMeshPro
{
	[Token(Token = "0x20001DB")]
	[ExecuteInEditMode]
	public class TextProOnACircle : TextProOnACurve
	{
		[Token(Token = "0x4000AA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAAA4", Offset = "0xAEAAA4")]
		[SerializeField]
		private float m_radius;

		[Token(Token = "0x4000AA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAAF0", Offset = "0xAEAAF0")]
		[SerializeField]
		private float m_arcDegrees;

		[Token(Token = "0x4000AA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAB3C", Offset = "0xAEAB3C")]
		private float m_angularOffset;

		[Token(Token = "0x4000AA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[AttributeAttribute(Name = "TooltipAttribute", RVA = "0xAEAB88", Offset = "0xAEAB88")]
		private int m_maxDegreesPerLetter;

		[Token(Token = "0x4000AAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private float m_oldRadius;

		[Token(Token = "0x4000AAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private float m_oldArcDegrees;

		[Token(Token = "0x4000AAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		private float m_oldAngularOffset;

		[Token(Token = "0x4000AAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private float m_oldMaxDegreesPerLetter;

		[Token(Token = "0x6000BE1")]
		[Address(RVA = "0x1398844", Offset = "0x1398844", VA = "0x1398844", Slot = "4")]
		protected override bool ParametersHaveChanged()
		{
			return default(bool);
		}

		[Token(Token = "0x6000BE2")]
		[Address(RVA = "0x13988C4", Offset = "0x13988C4", VA = "0x13988C4", Slot = "5")]
		protected override Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx)
		{
			return default(Matrix4x4);
		}

		[Token(Token = "0x6000BE3")]
		[Address(RVA = "0x1398A74", Offset = "0x1398A74", VA = "0x1398A74")]
		public TextProOnACircle()
		{
		}
	}
	[Token(Token = "0x20001DC")]
	[ExecuteInEditMode]
	public abstract class TextProOnACurve : MonoBehaviour
	{
		[Token(Token = "0x4000AAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private TMP_Text m_TextComponent;

		[Token(Token = "0x4000AAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool m_forceUpdate;

		[Token(Token = "0x6000BE4")]
		[Address(RVA = "0x1398AA8", Offset = "0x1398AA8", VA = "0x1398AA8")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000BE5")]
		[Address(RVA = "0x1398B0C", Offset = "0x1398B0C", VA = "0x1398B0C")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000BE6")]
		[Address(RVA = "0x1398B18", Offset = "0x1398B18", VA = "0x1398B18")]
		protected void Update()
		{
		}

		[Token(Token = "0x6000BE7")]
		protected abstract bool ParametersHaveChanged();

		[Token(Token = "0x6000BE8")]
		protected abstract Matrix4x4 ComputeTransformationMatrix(Vector3 charMidBaselinePos, float zeroToOnePos, TMP_TextInfo textInfo, int charIdx);

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x1398AA0", Offset = "0x1398AA0", VA = "0x1398AA0")]
		protected TextProOnACurve()
		{
		}
	}
}
namespace DG.Tweening
{
	[Token(Token = "0x20001DD")]
	public static class DoTweenModuleFmod
	{
		[Token(Token = "0x20001DE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4EE8", Offset = "0xAE4EE8")]
		private sealed class <>c__DisplayClass0_0
		{
			[Token(Token = "0x4000AB0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance target;

			[Token(Token = "0x6000BF3")]
			[Address(RVA = "0xE40884", Offset = "0xE40884", VA = "0xE40884")]
			public <>c__DisplayClass0_0()
			{
			}

			[Token(Token = "0x6000BF4")]
			[Address(RVA = "0xE4088C", Offset = "0xE4088C", VA = "0xE4088C")]
			internal float <DOFade>b__0()
			{
				return default(float);
			}

			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0xE408C4", Offset = "0xE408C4", VA = "0xE408C4")]
			internal void <DOFade>b__1(float x)
			{
			}
		}

		[Token(Token = "0x20001DF")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4EF8", Offset = "0xAE4EF8")]
		private sealed class <>c__DisplayClass3_0
		{
			[Token(Token = "0x4000AB1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance target;

			[Token(Token = "0x6000BF6")]
			[Address(RVA = "0xE408D0", Offset = "0xE408D0", VA = "0xE408D0")]
			public <>c__DisplayClass3_0()
			{
			}

			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0xE408D8", Offset = "0xE408D8", VA = "0xE408D8")]
			internal void <DOFadeOutAndStop>b__0()
			{
			}
		}

		[Token(Token = "0x20001E0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0xAE4F08", Offset = "0xAE4F08")]
		private sealed class <>c__DisplayClass4_0
		{
			[Token(Token = "0x4000AB2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public EventInstance target;

			[Token(Token = "0x6000BF8")]
			[Address(RVA = "0xE408E8", Offset = "0xE408E8", VA = "0xE408E8")]
			public <>c__DisplayClass4_0()
			{
			}

			[Token(Token = "0x6000BF9")]
			[Address(RVA = "0xE408F0", Offset = "0xE408F0", VA = "0xE408F0")]
			internal void <DOFadeOutAndPause>b__0()
			{
			}
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x15D5D3C", Offset = "0x15D5D3C", VA = "0x15D5D3C")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this EventInstance target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x15D5F60", Offset = "0x15D5F60", VA = "0x15D5F60")]
		public static TweenerCore<float, float, FloatOptions> DoFadeIn(this EventInstance target, float duration, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x15D5FAC", Offset = "0x15D5FAC", VA = "0x15D5FAC")]
		public static TweenerCore<float, float, FloatOptions> DoFadeOut(this EventInstance target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x15D5FB8", Offset = "0x15D5FB8", VA = "0x15D5FB8")]
		public static TweenerCore<float, float, FloatOptions> DOFadeOutAndStop(this EventInstance target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x15D60B4", Offset = "0x15D60B4", VA = "0x15D60B4")]
		public static TweenerCore<float, float, FloatOptions> DOFadeOutAndPause(this EventInstance target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x15D61B0", Offset = "0x15D61B0", VA = "0x15D61B0")]
		public static TweenerCore<float, float, FloatOptions> DOFade(this StudioEventEmitter target, float endValue, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x15D61C8", Offset = "0x15D61C8", VA = "0x15D61C8")]
		public static TweenerCore<float, float, FloatOptions> DoFadeIn(this StudioEventEmitter target, float duration, float volume = 1f)
		{
			return null;
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x15D6220", Offset = "0x15D6220", VA = "0x15D6220")]
		public static TweenerCore<float, float, FloatOptions> DOFadeOutAndStop(this StudioEventEmitter target, float duration)
		{
			return null;
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x15D6238", Offset = "0x15D6238", VA = "0x15D6238")]
		public static TweenerCore<float, float, FloatOptions> DOFadeOutAndPause(this StudioEventEmitter target, float duration)
		{
			return null;
		}
	}
}
